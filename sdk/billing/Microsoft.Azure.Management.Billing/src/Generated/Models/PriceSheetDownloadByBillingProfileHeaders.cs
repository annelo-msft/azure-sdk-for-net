// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for DownloadByBillingProfile operation.
    /// </summary>
    public partial class PriceSheetDownloadByBillingProfileHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PriceSheetDownloadByBillingProfileHeaders class.
        /// </summary>
        public PriceSheetDownloadByBillingProfileHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PriceSheetDownloadByBillingProfileHeaders class.
        /// </summary>
        /// <param name="location">GET this URL to retrieve the status of the
        /// asynchronous operation.</param>
        /// <param name="retryAfter">The amount of delay to use while the
        /// status of the operation is checked. The value is expressed in
        /// seconds.</param>
        /// <param name="oDataEntityId">The operation entity Id GUID.</param>
        public PriceSheetDownloadByBillingProfileHeaders(string location = default(string), string retryAfter = default(string), string oDataEntityId = default(string))
        {
            Location = location;
            RetryAfter = retryAfter;
            ODataEntityId = oDataEntityId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets GET this URL to retrieve the status of the
        /// asynchronous operation.
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the amount of delay to use while the status of the
        /// operation is checked. The value is expressed in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "Retry-After")]
        public string RetryAfter { get; set; }

        /// <summary>
        /// Gets or sets the operation entity Id GUID.
        /// </summary>
        [JsonProperty(PropertyName = "OData-EntityId")]
        public string ODataEntityId { get; set; }

    }
}
