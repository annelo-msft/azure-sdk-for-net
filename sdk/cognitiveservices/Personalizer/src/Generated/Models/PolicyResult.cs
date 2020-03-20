// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Personalizer.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class PolicyResult
    {
        /// <summary>
        /// Initializes a new instance of the PolicyResult class.
        /// </summary>
        public PolicyResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PolicyResult class.
        /// </summary>
        public PolicyResult(string name = default(string), string arguments = default(string), IList<PolicyResultSummary> summary = default(IList<PolicyResultSummary>), PolicyResultTotalSummary totalSummary = default(PolicyResultTotalSummary))
        {
            Name = name;
            Arguments = arguments;
            Summary = summary;
            TotalSummary = totalSummary;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "arguments")]
        public string Arguments { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public IList<PolicyResultSummary> Summary { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalSummary")]
        public PolicyResultTotalSummary TotalSummary { get; private set; }

    }
}
