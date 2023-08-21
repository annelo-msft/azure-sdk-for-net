// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Contains the list of gallery applications that should be made available to the VM/VMSS. </summary>
    internal partial class ApplicationProfile
    {
        /// <summary> Initializes a new instance of ApplicationProfile. </summary>
        public ApplicationProfile()
        {
            GalleryApplications = new Core.ChangeTrackingList<VirtualMachineGalleryApplication>();
        }

        /// <summary> Initializes a new instance of ApplicationProfile. </summary>
        /// <param name="galleryApplications"> Specifies the gallery applications that should be made available to the VM/VMSS. </param>
        internal ApplicationProfile(IList<VirtualMachineGalleryApplication> galleryApplications)
        {
            GalleryApplications = galleryApplications;
        }

        /// <summary> Specifies the gallery applications that should be made available to the VM/VMSS. </summary>
        public IList<VirtualMachineGalleryApplication> GalleryApplications { get; }
    }
}
