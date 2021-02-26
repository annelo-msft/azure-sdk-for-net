// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Tag attributes. </summary>
    public partial class TagProperties
    {
        /// <summary> Initializes a new instance of TagProperties. </summary>
        internal TagProperties()
        {
        }

        /// <summary> Initializes a new instance of TagProperties. </summary>
        /// <param name="registry"> Registry name. </param>
        /// <param name="imageName"> Image name. </param>
        /// <param name="attributes"> List of tag attribute details. </param>
        internal TagProperties(string registry, string imageName, TagAttributesBase attributes)
        {
            Registry = registry;
            ImageName = imageName;
            Attributes = attributes;
        }

        /// <summary> Registry name. </summary>
        public string Registry { get; }
        /// <summary> Image name. </summary>
        public string ImageName { get; }
    }
}
