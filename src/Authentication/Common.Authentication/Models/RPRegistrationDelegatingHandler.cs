// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Azure.Common.Authentication.Models
{
    class RPRegistrationDelegatingHandler : DelegatingHandler
    {
        /// <summary>
        /// Contains all providers we have attempted to register 
        /// </summary>
        private HashSet<string> registeredProviders;

        private IClientFactory clientFactory;

        private AzureContext context;

        public RPRegistrationDelegatingHandler(IClientFactory clientFactory, AzureContext context)
        {
            this.registeredProviders = new HashSet<string>();
            this.clientFactory = clientFactory;
            this.context = context;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            HttpResponseMessage responseMessage = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
            if (IsProviderNotRegistereError(responseMessage))
            {
                var providerName = GetProviderName(request.RequestUri);
                if (!string.IsNullOrEmpty(providerName) && !registeredProviders.Contains(providerName))
                {
                    registeredProviders.Add(providerName);
                    // Assume registration is instantanuous.
                    clientFactory.ResourceProviderRegistrationAction(providerName, context);
                    responseMessage = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
                }
            }
            return responseMessage;
        }

        private bool IsProviderNotRegistereError(HttpResponseMessage responseMessage)
        {
            return responseMessage.StatusCode == System.Net.HttpStatusCode.Conflict &&
                responseMessage.Content.ReadAsStringAsync().Result.Contains("registered to use namespace");
        }

        /// <summary>
        /// Extract provider name from request uri such as
        /// "https://management.azure.com/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/providers/{resource-provider-name}"
        /// We analyze the uri's segments and check the index of 5 is "providers/" and return the next segment.    
        /// </summary>
        /// <param name="requestUri">request uri to extract provider out</param>
        /// <returns>provider name, or null on unexpected format</returns>
        private string GetProviderName(Uri requestUri)
        {
            return (requestUri.Segments.Length > 7 && requestUri.Segments[5].ToLower() == "providers/") ?
                requestUri.Segments[6].ToLower() : null;
        }
    }
}
