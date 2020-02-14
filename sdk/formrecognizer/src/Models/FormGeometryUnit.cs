// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer.Models
{
    // TODO: Make extensible enum

    /// <summary>
    /// The unit used by the width, height and boundingBox properties.
    /// </summary>
    public enum FormDimensionUnit
    {
        /// <summary>Pixel.</summary>
        Pixel = 1,

        /// <summary>Inch.</summary>
        Inch = 2,
    }
}
