// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The parameters for a task run request. </summary>
    public partial class TaskRunRequest : RunContent
    {
        /// <summary> Initializes a new instance of TaskRunRequest. </summary>
        /// <param name="taskId"> The resource ID of task against which run has to be queued. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="taskId"/> is null. </exception>
        public TaskRunRequest(string taskId)
        {
            if (taskId == null)
            {
                throw new ArgumentNullException(nameof(taskId));
            }

            TaskId = taskId;
            RunRequestType = "TaskRunRequest";
        }

        /// <summary> Initializes a new instance of TaskRunRequest. </summary>
        /// <param name="runRequestType"> The type of the run request. </param>
        /// <param name="isArchiveEnabled"> The value that indicates whether archiving is enabled for the run or not. </param>
        /// <param name="agentPoolName"> The dedicated agent pool for the run. </param>
        /// <param name="logTemplate"> The template that describes the repository and tag information for run log artifact. </param>
        /// <param name="taskId"> The resource ID of task against which run has to be queued. </param>
        /// <param name="overrideTaskStepProperties"> Set of overridable parameters that can be passed when running a Task. </param>
        internal TaskRunRequest(string runRequestType, bool? isArchiveEnabled, string agentPoolName, string logTemplate, string taskId, OverrideTaskStepProperties overrideTaskStepProperties) : base(runRequestType, isArchiveEnabled, agentPoolName, logTemplate)
        {
            TaskId = taskId;
            OverrideTaskStepProperties = overrideTaskStepProperties;
            RunRequestType = runRequestType ?? "TaskRunRequest";
        }

        /// <summary> The resource ID of task against which run has to be queued. </summary>
        public string TaskId { get; set; }
        /// <summary> Set of overridable parameters that can be passed when running a Task. </summary>
        public OverrideTaskStepProperties OverrideTaskStepProperties { get; set; }
    }
}
