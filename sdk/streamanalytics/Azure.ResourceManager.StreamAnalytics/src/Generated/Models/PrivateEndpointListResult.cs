// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.StreamAnalytics;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> A list of private endpoints. </summary>
    internal partial class PrivateEndpointListResult
    {
        /// <summary> Initializes a new instance of PrivateEndpointListResult. </summary>
        internal PrivateEndpointListResult()
        {
            Value = new ChangeTrackingList<StreamAnalyticsPrivateEndpointData>();
        }

        /// <summary> Initializes a new instance of PrivateEndpointListResult. </summary>
        /// <param name="value"> A list of private endpoints. </param>
        /// <param name="nextLink"> The URL to fetch the next set of private endpoints. </param>
        internal PrivateEndpointListResult(IReadOnlyList<StreamAnalyticsPrivateEndpointData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of private endpoints. </summary>
        public IReadOnlyList<StreamAnalyticsPrivateEndpointData> Value { get; }
        /// <summary> The URL to fetch the next set of private endpoints. </summary>
        public string NextLink { get; }
    }
}
