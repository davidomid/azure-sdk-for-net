// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> A recoverable server resource. </summary>
    public partial class RecoverableServerResource : ResourceData
    {
        /// <summary> Initializes a new instance of RecoverableServerResource. </summary>
        public RecoverableServerResource()
        {
        }

        /// <summary> Initializes a new instance of RecoverableServerResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="lastAvailableBackupDateTime"> The last available backup date time. </param>
        /// <param name="serviceLevelObjective"> The service level objective. </param>
        /// <param name="edition"> Edition of the performance tier. </param>
        /// <param name="vCore"> vCore associated with the service level objective. </param>
        /// <param name="hardwareGeneration"> Hardware generation associated with the service level objective. </param>
        /// <param name="version"> The MySQL version. </param>
        internal RecoverableServerResource(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string lastAvailableBackupDateTime, string serviceLevelObjective, string edition, int? vCore, string hardwareGeneration, string version) : base(id, name, resourceType, systemData)
        {
            LastAvailableBackupDateTime = lastAvailableBackupDateTime;
            ServiceLevelObjective = serviceLevelObjective;
            Edition = edition;
            VCore = vCore;
            HardwareGeneration = hardwareGeneration;
            Version = version;
        }

        /// <summary> The last available backup date time. </summary>
        public string LastAvailableBackupDateTime { get; }
        /// <summary> The service level objective. </summary>
        public string ServiceLevelObjective { get; }
        /// <summary> Edition of the performance tier. </summary>
        public string Edition { get; }
        /// <summary> vCore associated with the service level objective. </summary>
        public int? VCore { get; }
        /// <summary> Hardware generation associated with the service level objective. </summary>
        public string HardwareGeneration { get; }
        /// <summary> The MySQL version. </summary>
        public string Version { get; }
    }
}
