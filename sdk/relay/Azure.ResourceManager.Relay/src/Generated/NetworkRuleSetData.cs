// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Relay.Models;

namespace Azure.ResourceManager.Relay
{
    /// <summary> A class representing the NetworkRuleSet data model. </summary>
    public partial class NetworkRuleSetData : ResourceData
    {
        /// <summary> Initializes a new instance of NetworkRuleSetData. </summary>
        public NetworkRuleSetData()
        {
            IPRules = new ChangeTrackingList<NWRuleSetIPRules>();
        }

        /// <summary> Initializes a new instance of NetworkRuleSetData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="defaultAction"> Default Action for Network Rule Set. </param>
        /// <param name="ipRules"> List of IpRules. </param>
        internal NetworkRuleSetData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DefaultAction? defaultAction, IList<NWRuleSetIPRules> ipRules) : base(id, name, resourceType, systemData)
        {
            DefaultAction = defaultAction;
            IPRules = ipRules;
        }

        /// <summary> Default Action for Network Rule Set. </summary>
        public DefaultAction? DefaultAction { get; set; }
        /// <summary> List of IpRules. </summary>
        public IList<NWRuleSetIPRules> IPRules { get; }
    }
}
