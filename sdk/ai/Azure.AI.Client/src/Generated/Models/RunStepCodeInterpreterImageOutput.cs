// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Client.Models
{
    /// <summary> A representation of an image output emitted by a code interpreter tool in response to a tool call by the model. </summary>
    public partial class RunStepCodeInterpreterImageOutput : RunStepCodeInterpreterToolCallOutput
    {
        /// <summary> Initializes a new instance of <see cref="RunStepCodeInterpreterImageOutput"/>. </summary>
        /// <param name="image"> Referential information for the image associated with this output. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="image"/> is null. </exception>
        internal RunStepCodeInterpreterImageOutput(RunStepCodeInterpreterImageReference image)
        {
            Argument.AssertNotNull(image, nameof(image));

            Type = "image";
            Image = image;
        }

        /// <summary> Initializes a new instance of <see cref="RunStepCodeInterpreterImageOutput"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="image"> Referential information for the image associated with this output. </param>
        internal RunStepCodeInterpreterImageOutput(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, RunStepCodeInterpreterImageReference image) : base(type, serializedAdditionalRawData)
        {
            Image = image;
        }

        /// <summary> Initializes a new instance of <see cref="RunStepCodeInterpreterImageOutput"/> for deserialization. </summary>
        internal RunStepCodeInterpreterImageOutput()
        {
        }

        /// <summary> Referential information for the image associated with this output. </summary>
        public RunStepCodeInterpreterImageReference Image { get; }
    }
}
