// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    [CodeGenModel("RouterQueue")]
    public partial class RouterQueue
    {
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

        /// <summary>
        /// A set of key/value pairs that are identifying attributes used by the rules engines to make decisions.
        /// </summary>
        public IDictionary<string, Value> Labels { get; } = new Dictionary<string, Value>();

        /// <summary> Initializes a new instance of JobQueue. </summary>
        internal RouterQueue()
        {
        }
    }
}
