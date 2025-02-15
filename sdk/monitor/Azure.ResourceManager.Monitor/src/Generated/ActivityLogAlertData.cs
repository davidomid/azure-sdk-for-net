// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class representing the ActivityLogAlert data model. </summary>
    public partial class ActivityLogAlertData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ActivityLogAlertData. </summary>
        /// <param name="location"> The location. </param>
        public ActivityLogAlertData(AzureLocation location) : base(location)
        {
            Scopes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ActivityLogAlertData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="scopes"> A list of resourceIds that will be used as prefixes. The alert will only apply to activityLogs with resourceIds that fall under one of these prefixes. This list must include at least one item. </param>
        /// <param name="isEnabled"> Indicates whether this activity log alert is enabled. If an activity log alert is not enabled, then none of its actions will be activated. </param>
        /// <param name="condition"> The condition that will cause this alert to activate. </param>
        /// <param name="actions"> The actions that will activate when the condition is met. </param>
        /// <param name="description"> A description of this activity log alert. </param>
        internal ActivityLogAlertData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IList<string> scopes, bool? isEnabled, ActivityLogAlertAllOfCondition condition, ActivityLogAlertActionList actions, string description) : base(id, name, resourceType, systemData, tags, location)
        {
            Scopes = scopes;
            IsEnabled = isEnabled;
            Condition = condition;
            Actions = actions;
            Description = description;
        }

        /// <summary> A list of resourceIds that will be used as prefixes. The alert will only apply to activityLogs with resourceIds that fall under one of these prefixes. This list must include at least one item. </summary>
        public IList<string> Scopes { get; }
        /// <summary> Indicates whether this activity log alert is enabled. If an activity log alert is not enabled, then none of its actions will be activated. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The condition that will cause this alert to activate. </summary>
        internal ActivityLogAlertAllOfCondition Condition { get; set; }
        /// <summary> The list of activity log alert conditions. </summary>
        public IList<ActivityLogAlertLeafCondition> ConditionAllOf
        {
            get => Condition is null ? default : Condition.AllOf;
            set => Condition = new ActivityLogAlertAllOfCondition(value);
        }

        /// <summary> The actions that will activate when the condition is met. </summary>
        internal ActivityLogAlertActionList Actions { get; set; }
        /// <summary> The list of activity log alerts. </summary>
        public IList<ActivityLogAlertActionGroup> ActionsActionGroups
        {
            get
            {
                if (Actions is null)
                    Actions = new ActivityLogAlertActionList();
                return Actions.ActionGroups;
            }
        }

        /// <summary> A description of this activity log alert. </summary>
        public string Description { get; set; }
    }
}
