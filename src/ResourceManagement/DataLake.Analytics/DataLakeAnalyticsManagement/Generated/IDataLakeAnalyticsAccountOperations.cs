// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.DataLake.Analytics.Models;

namespace Microsoft.Azure.Management.DataLake.Analytics
{
    /// <summary>
    /// Operations for managing Data Lake Analytics accounts
    /// </summary>
    public partial interface IDataLakeAnalyticsAccountOperations
    {
        /// <summary>
        /// Updates the Data Lake Analytics account specified to include the
        /// additional Data Lake Store account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The Data Lake Analytics account name to add the Data Lake Store
        /// account to
        /// </param>
        /// <param name='dataLakeStoreAccountName'>
        /// The name of the Data Lake Store account to add
        /// </param>
        /// <param name='parameters'>
        /// The parameters containing the optional properties associated with
        /// the named Data Lake account.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> AddDataLakeStoreAccountAsync(string resourceGroupName, string accountName, string dataLakeStoreAccountName, AddDataLakeStoreParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Updates the Data Lake Analytics account specified to include the
        /// additional Azure Storage account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The Data Lake Analytics account name to add the Azure Storage
        /// account to
        /// </param>
        /// <param name='storageAccountName'>
        /// The name of the Azure Storage account to add
        /// </param>
        /// <param name='parameters'>
        /// The parameters containing the access key and optional suffix for
        /// the Azure Storage Account.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> AddStorageAccountAsync(string resourceGroupName, string accountName, string storageAccountName, AddStorageAccountParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Begins the creation process for the specified Data Lake Analytics
        /// account.This supplies the user with computation services for Data
        /// Lake Analytics workloads
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group the account will be associated with.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create Data Lake Analytics account
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        Task<AzureAsyncOperationResponse> BeginCreateAsync(string resourceGroupName, DataLakeAnalyticsAccountCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Begins the delete delete process for the Data Lake Analytics
        /// account object specified by the account name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to delete
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        Task<AzureAsyncOperationResponse> BeginDeleteAsync(string resourceGroupName, string accountName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Updates the Data Lake Analytics account object specified by the
        /// accountName with the contents of the account object.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the update Data Lake Analytics account
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        Task<AzureAsyncOperationResponse> BeginUpdateAsync(string resourceGroupName, DataLakeAnalyticsAccountCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates the specified Data Lake Analytics account.This supplies the
        /// user with computation services for Data Lake Analytics workloads
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create Data Lake Analytics account
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        Task<AzureAsyncOperationResponse> CreateAsync(string resourceGroupName, DataLakeAnalyticsAccountCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the next page of the Data Lake Store account objects within
        /// the specified Data Lake Analytics account with the link to the
        /// next page, if any.
        /// </summary>
        /// <param name='nextLink'>
        /// The url to the next Data Lake Store account page.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Data Lake Account list information.
        /// </returns>
        Task<DataLakeAnalyticsAccountListDataLakeStoreResponse> DataLakeStoreAccountListNextAsync(string nextLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes the Data Lake Analytics account object specified by the
        /// account name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to delete
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        Task<AzureAsyncOperationResponse> DeleteAsync(string resourceGroupName, string accountName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Updates the Data Lake Analytics account specified to remove the
        /// specified Data Lake Store account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The Data Lake Analytics account name to remove the Data Lake Store
        /// account from
        /// </param>
        /// <param name='dataLakeStoreAccountName'>
        /// The name of the Data Lake Store account to remove
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteDataLakeStoreAccountAsync(string resourceGroupName, string accountName, string dataLakeStoreAccountName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Updates the Data Lake Analytics account specified to remove the
        /// specified Azure Storage account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The Data Lake Analytics account name to remove the Azure Storage
        /// account from
        /// </param>
        /// <param name='storageAccountName'>
        /// The name of the Azure Storage account to remove
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteStorageAccountAsync(string resourceGroupName, string accountName, string storageAccountName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the Data Lake Analytics account object specified by the
        /// account name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to retrieve
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Data Lake Analytics Account information response.
        /// </returns>
        Task<DataLakeAnalyticsAccountGetResponse> GetAsync(string resourceGroupName, string accountName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the specified Data Lake Store account details in the specified
        /// Data Lake Analytics account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to retrieve the Data Lake Store account
        /// details from
        /// </param>
        /// <param name='dataLakeStoreAccountName'>
        /// The name of the account to retrieve
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Data Lake Account information response.
        /// </returns>
        Task<DataLakeAnalyticsAccountGetDataLakeStoreAccountResponse> GetDataLakeStoreAccountAsync(string resourceGroupName, string accountName, string dataLakeStoreAccountName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the specified Azure storage account details in the specified
        /// Data Lake Analytics account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to retrieve the Azure storage account
        /// details from
        /// </param>
        /// <param name='storageAccountName'>
        /// The name of the account to retrieve
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Storage Account information response.
        /// </returns>
        Task<DataLakeAnalyticsAccountGetStorageAccountResponse> GetStorageAccountAsync(string resourceGroupName, string accountName, string storageAccountName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the specified Azure Storage container object associated with
        /// the specified Data Lake Analytics and Azure Storage accounts.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account to retrieve blob
        /// container for
        /// </param>
        /// <param name='storageAccountName'>
        /// The name of the Azure storage account to retrieve the blob
        /// container from
        /// </param>
        /// <param name='containerName'>
        /// The name of the Azure storage container to retrieve
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Storage Container information response.
        /// </returns>
        Task<GetBlobContainerResponse> GetStorageContainerAsync(string resourceGroupName, string accountName, string storageAccountName, string containerName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the first page of the Data Lake Analytics account objects
        /// within the subscription or within a specific resource group. This
        /// includes a link to the next page, if any.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// DataLakeAnalytics Account list information.
        /// </returns>
        Task<DataLakeAnalyticsAccountListResponse> ListAsync(string resourceGroupName, DataLakeAnalyticsAccountListParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the first page of the Data Lake Store account objects within
        /// the specified Data Lake Analytics account. This includes a link to
        /// the next page, if any.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account to list Data Lake Store
        /// accounts for.
        /// </param>
        /// <param name='parameters'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Data Lake Account list information.
        /// </returns>
        Task<DataLakeAnalyticsAccountListDataLakeStoreResponse> ListDataLakeStoreAccountsAsync(string resourceGroupName, string accountName, DataLakeAnalyticsAccountListParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the next page of the Data Lake Analytics account objects
        /// within the subscription or within a specific resource group with
        /// the link to the next page, if any.
        /// </summary>
        /// <param name='nextLink'>
        /// The url to the next Data Lake Analytics account page.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// DataLakeAnalytics Account list information.
        /// </returns>
        Task<DataLakeAnalyticsAccountListResponse> ListNextAsync(string nextLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the SAS token associated with the specified Data Lake
        /// Analytics and WASB storage account and container combination.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account to get the SAS token for
        /// </param>
        /// <param name='storageAccountName'>
        /// The name of the Azure storage account to retrieve the blob
        /// container from
        /// </param>
        /// <param name='containerName'>
        /// The name of the Azure storage container to retrieve
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The SAS response that contains the storage account, container and
        /// associated SAS token for connection use.
        /// </returns>
        Task<ListSasTokensResponse> ListSasTokensAsync(string resourceGroupName, string accountName, string storageAccountName, string containerName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the first page of the Data Lake Analytics account objects
        /// within the subscription or within a specific resource group. This
        /// includes a link to the next page, if any.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account to list Storage
        /// accounts for.
        /// </param>
        /// <param name='parameters'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Azure Storage Account list information.
        /// </returns>
        Task<DataLakeAnalyticsAccountListStorageAccountsResponse> ListStorageAccountsAsync(string resourceGroupName, string accountName, DataLakeAnalyticsAccountListParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the Azure Storage containers object associated with the
        /// specified Data Lake Analytics and Azure Storage accounts.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account to retrieve blob
        /// containers for
        /// </param>
        /// <param name='storageAccountName'>
        /// The name of the Azure storage account to retrieve blob containers
        /// from
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The list of blob containers associated with the storage account
        /// attached to the Data Lake Analytics account.
        /// </returns>
        Task<ListBlobContainersResponse> ListStorageContainersAsync(string resourceGroupName, string accountName, string storageAccountName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the next page of the SAS token objects within the specified
        /// Azure Storage account and container, if any.
        /// </summary>
        /// <param name='nextLink'>
        /// The url to the next Azure Storage Container SAS token page.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The SAS response that contains the storage account, container and
        /// associated SAS token for connection use.
        /// </returns>
        Task<ListSasTokensResponse> SasTokensListNextAsync(string nextLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the next page of the Azure Storage account objects within the
        /// specified Data Lake Analytics account with the link to the next
        /// page, if any.
        /// </summary>
        /// <param name='nextLink'>
        /// The url to the next Azure Storage account page.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Azure Storage Account list information.
        /// </returns>
        Task<DataLakeAnalyticsAccountListStorageAccountsResponse> StorageAccountListNextAsync(string nextLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the next page of the Azure Storage Container objects within
        /// the specified Azure Storage account, if any.
        /// </summary>
        /// <param name='nextLink'>
        /// The url to the next Azure Storage Container page.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The list of blob containers associated with the storage account
        /// attached to the Data Lake Analytics account.
        /// </returns>
        Task<ListBlobContainersResponse> StorageContainersListNextAsync(string nextLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Updates the Data Lake Analytics account object specified by the
        /// accountName with the contents of the account object.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the update Data Lake Analytics account
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        Task<AzureAsyncOperationResponse> UpdateAsync(string resourceGroupName, DataLakeAnalyticsAccountCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Updates the specified storage account. This is currently only
        /// supported for Azure blob accounts to update their access keys and
        /// suffix.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The Data Lake Analytics account name to modify storage accounts in
        /// </param>
        /// <param name='storageAccountName'>
        /// The Azure Storage account to modify
        /// </param>
        /// <param name='parameters'>
        /// The parameters containing the access key and suffix to update the
        /// storage account with.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> UpdateStorageAccountAsync(string resourceGroupName, string accountName, string storageAccountName, AddStorageAccountParameters parameters, CancellationToken cancellationToken);
    }
}
