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

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The properties of a vCenter object.
    /// </summary>
    public partial class VCenterProperties
    {
        private string _discoveryStatus;
        
        /// <summary>
        /// Optional. vCenter discovery status.
        /// </summary>
        public string DiscoveryStatus
        {
            get { return this._discoveryStatus; }
            set { this._discoveryStatus = value; }
        }
        
        private string _fabricArmResourceName;
        
        /// <summary>
        /// Optional. ARM resource name of the fabric containing this VCenter.
        /// </summary>
        public string FabricArmResourceName
        {
            get { return this._fabricArmResourceName; }
            set { this._fabricArmResourceName = value; }
        }
        
        private string _friendlyName;
        
        /// <summary>
        /// Optional. Friendly name of the vCenter.
        /// </summary>
        public string FriendlyName
        {
            get { return this._friendlyName; }
            set { this._friendlyName = value; }
        }
        
        private string _infrastructureId;
        
        /// <summary>
        /// Optional. Infrastructure Id of the vCenter.
        /// </summary>
        public string InfrastructureId
        {
            get { return this._infrastructureId; }
            set { this._infrastructureId = value; }
        }
        
        private string _internalId;
        
        /// <summary>
        /// Optional. Internal ID of the vCenter.
        /// </summary>
        public string InternalId
        {
            get { return this._internalId; }
            set { this._internalId = value; }
        }
        
        private string _ipAddress;
        
        /// <summary>
        /// Optional. IP Address of the vCenter.
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }
        
        private System.DateTime? _lastHeartbeat;
        
        /// <summary>
        /// Optional. Last time vCenter synced with the service.
        /// </summary>
        public System.DateTime? LastHeartbeat
        {
            get { return this._lastHeartbeat; }
            set { this._lastHeartbeat = value; }
        }
        
        private string _port;
        
        /// <summary>
        /// Optional. Port of the vCenter.
        /// </summary>
        public string Port
        {
            get { return this._port; }
            set { this._port = value; }
        }
        
        private string _processServerId;
        
        /// <summary>
        /// Optional. Process Server Id.
        /// </summary>
        public string ProcessServerId
        {
            get { return this._processServerId; }
            set { this._processServerId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VCenterProperties class.
        /// </summary>
        public VCenterProperties()
        {
        }
    }
}
