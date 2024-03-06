// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary>
    /// A time period defined by a start and end date and optionally time
    /// Based on [FHIR Period](https://www.hl7.org/fhir/R4/datatypes.html#Period)
    /// </summary>
    public partial class FhirR4Period : FhirR4Element
    {
        /// <summary> Initializes a new instance of <see cref="FhirR4Period"/>. </summary>
        public FhirR4Period()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FhirR4Period"/>. </summary>
        /// <param name="id"> Unique id for inter-element referencing. </param>
        /// <param name="extension"> Additional Content defined by implementations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="start"> Starting time with inclusive boundary. </param>
        /// <param name="end"> End time with inclusive boundary, if not ongoing. </param>
        internal FhirR4Period(string id, IReadOnlyList<FhirR4Extension> extension, IDictionary<string, BinaryData> serializedAdditionalRawData, string start, string end) : base(id, extension, serializedAdditionalRawData)
        {
            Start = start;
            End = end;
        }

        /// <summary> Starting time with inclusive boundary. </summary>
        public string Start { get; set; }
        /// <summary> End time with inclusive boundary, if not ongoing. </summary>
        public string End { get; set; }
    }
}
