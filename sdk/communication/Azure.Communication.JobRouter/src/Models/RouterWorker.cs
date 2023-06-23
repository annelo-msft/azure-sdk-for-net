// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    [CodeGenModel("RouterWorker")]
    public partial class RouterWorker
    {
        /// <summary>
        /// A set of key/value pairs that are identifying attributes used by the rules engines to make decisions.
        /// </summary>
        public IDictionary<string, Value> Labels { get; } = new Dictionary<string, Value>();

        /// <summary>
        /// A set of non-identifying attributes attached to this worker.
        /// </summary>
        public IDictionary<string, Value> Tags { get; } = new Dictionary<string, Value>();

        /// <summary> The channel(s) this worker can handle and their impact on the workers capacity. </summary>
        public IDictionary<string, ChannelConfiguration> ChannelConfigurations { get; } = new Dictionary<string, ChannelConfiguration>();

        /// <summary> The queue(s) that this worker can receive work from. </summary>
        public IDictionary<string, RouterQueueAssignment> QueueAssignments { get; } = new Dictionary<string, RouterQueueAssignment>();

        [CodeGenMember("Labels")]
        internal IDictionary<string, Value> _labels
        {
            get
            {
                return Labels != null && Labels.Count != 0
                    ? Labels?.ToDictionary(x => x.Key, x => x.Value)
                    : new ChangeTrackingDictionary<string, Value>();
            }
            set
            {
                if (value != null && value.Count != 0)
                {
                    foreach (var label in value)
                    {
                        Labels[label.Key] = new Value(label.Value);
                    }
                }
            }
        }

        [CodeGenMember("Tags")]
        internal IDictionary<string, Value> _tags
        {
            get
            {
                return Tags != null && Tags.Count != 0
                    ? Tags?.ToDictionary(x => x.Key, x => x.Value)
                    : new ChangeTrackingDictionary<string, Value>();
            }
            set
            {
                if (value != null && value.Count != 0)
                {
                    foreach (var tag in value)
                    {
                        Tags[tag.Key] = new Value(tag.Value);
                    }
                }
            }
        }

        [CodeGenMember("ChannelConfigurations")]
        internal IDictionary<string, ChannelConfiguration> _channelConfigurations {
            get
            {
                return ChannelConfigurations ?? new ChangeTrackingDictionary<string, ChannelConfiguration>();
            }
            set
            {
                foreach (var channelConfiguration in value)
                {
                    ChannelConfigurations[channelConfiguration.Key] = new ChannelConfiguration(channelConfiguration.Value.CapacityCostPerJob)
                    {
                        MaxNumberOfJobs = channelConfiguration.Value.MaxNumberOfJobs
                    };
                }
            }
        }

        [CodeGenMember("QueueAssignments")]
        internal IDictionary<string, object> _queueAssignments
        {
            get
            {
                return QueueAssignments != null
                    ? QueueAssignments.ToDictionary(x => x.Key,
                        x => (object)x.Value)
                    : new ChangeTrackingDictionary<string, object>();
            }
            set
            {
                foreach (var queueAssignment in value)
                {
                    QueueAssignments[queueAssignment.Key] = new RouterQueueAssignment();
                }
            }
        }
    }
}
