// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The resource of an Azure Cosmos DB SQL database event. </summary>
    public partial class ExtendedRestorableSqlDatabaseResourceInfo
    {
        /// <summary> Initializes a new instance of ExtendedRestorableSqlDatabaseResourceInfo. </summary>
        internal ExtendedRestorableSqlDatabaseResourceInfo()
        {
        }

        /// <summary> Initializes a new instance of ExtendedRestorableSqlDatabaseResourceInfo. </summary>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="operationType"> The operation type of this database event. </param>
        /// <param name="eventTimestamp"> The time when this database event happened. </param>
        /// <param name="ownerId"> The name of the SQL database. </param>
        /// <param name="ownerResourceId"> The resource ID of the SQL database. </param>
        /// <param name="database"> Cosmos DB SQL database resource object. </param>
        internal ExtendedRestorableSqlDatabaseResourceInfo(string rid, CosmosDBOperationType? operationType, string eventTimestamp, string ownerId, string ownerResourceId, RestorableSqlDatabasePropertiesResourceDatabase database)
        {
            Rid = rid;
            OperationType = operationType;
            EventTimestamp = eventTimestamp;
            OwnerId = ownerId;
            OwnerResourceId = ownerResourceId;
            Database = database;
        }

        /// <summary> A system generated property. A unique identifier. </summary>
        public string Rid { get; }
        /// <summary> The operation type of this database event. </summary>
        public CosmosDBOperationType? OperationType { get; }
        /// <summary> The time when this database event happened. </summary>
        public string EventTimestamp { get; }
        /// <summary> The name of the SQL database. </summary>
        public string OwnerId { get; }
        /// <summary> The resource ID of the SQL database. </summary>
        public string OwnerResourceId { get; }
        /// <summary> Cosmos DB SQL database resource object. </summary>
        public RestorableSqlDatabasePropertiesResourceDatabase Database { get; }
    }
}
