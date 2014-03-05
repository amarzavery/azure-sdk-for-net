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

namespace Microsoft.WindowsAzure.Scheduler.Models
{
    /// <summary>
    /// Queue and content for a queue message action type.
    /// </summary>
    public partial class JobQueueMessage
    {
        private string _message;
        
        /// <summary>
        /// Content of the message to send to the queue.
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }
        
        private string _queueName;
        
        /// <summary>
        /// Name of the queue to send to.
        /// </summary>
        public string QueueName
        {
            get { return this._queueName; }
            set { this._queueName = value; }
        }
        
        private string _sasToken;
        
        /// <summary>
        /// SAS key for the storage account to send message to the queue.
        /// </summary>
        public string SasToken
        {
            get { return this._sasToken; }
            set { this._sasToken = value; }
        }
        
        private string _storageAccountName;
        
        /// <summary>
        /// Name of the storage account for the queue.
        /// </summary>
        public string StorageAccountName
        {
            get { return this._storageAccountName; }
            set { this._storageAccountName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobQueueMessage class.
        /// </summary>
        public JobQueueMessage()
        {
        }
    }
}