// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> A container instance. </summary>
    public partial class ContainerInstanceContainer
    {
        /// <summary> Initializes a new instance of ContainerInstanceContainer. </summary>
        /// <param name="name"> The user-provided name of the container instance. </param>
        /// <param name="image"> The name of the image used to create the container instance. </param>
        /// <param name="resources"> The resource requirements of the container instance. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="image"/> or <paramref name="resources"/> is null. </exception>
        public ContainerInstanceContainer(string name, string image, ContainerResourceRequirements resources)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(image, nameof(image));
            Argument.AssertNotNull(resources, nameof(resources));

            Name = name;
            Image = image;
            Command = new Core.ChangeTrackingList<string>();
            Ports = new Core.ChangeTrackingList<ContainerPort>();
            EnvironmentVariables = new Core.ChangeTrackingList<ContainerEnvironmentVariable>();
            Resources = resources;
            VolumeMounts = new Core.ChangeTrackingList<ContainerVolumeMount>();
        }

        /// <summary> Initializes a new instance of ContainerInstanceContainer. </summary>
        /// <param name="name"> The user-provided name of the container instance. </param>
        /// <param name="image"> The name of the image used to create the container instance. </param>
        /// <param name="command"> The commands to execute within the container instance in exec form. </param>
        /// <param name="ports"> The exposed ports on the container instance. </param>
        /// <param name="environmentVariables"> The environment variables to set in the container instance. </param>
        /// <param name="instanceView"> The instance view of the container instance. Only valid in response. </param>
        /// <param name="resources"> The resource requirements of the container instance. </param>
        /// <param name="volumeMounts"> The volume mounts available to the container instance. </param>
        /// <param name="livenessProbe"> The liveness probe. </param>
        /// <param name="readinessProbe"> The readiness probe. </param>
        /// <param name="securityContext"> The container security properties. </param>
        internal ContainerInstanceContainer(string name, string image, IList<string> command, IList<ContainerPort> ports, IList<ContainerEnvironmentVariable> environmentVariables, ContainerInstanceView instanceView, ContainerResourceRequirements resources, IList<ContainerVolumeMount> volumeMounts, ContainerProbe livenessProbe, ContainerProbe readinessProbe, ContainerSecurityContextDefinition securityContext)
        {
            Name = name;
            Image = image;
            Command = command;
            Ports = ports;
            EnvironmentVariables = environmentVariables;
            InstanceView = instanceView;
            Resources = resources;
            VolumeMounts = volumeMounts;
            LivenessProbe = livenessProbe;
            ReadinessProbe = readinessProbe;
            SecurityContext = securityContext;
        }

        /// <summary> The user-provided name of the container instance. </summary>
        public string Name { get; set; }
        /// <summary> The name of the image used to create the container instance. </summary>
        public string Image { get; set; }
        /// <summary> The commands to execute within the container instance in exec form. </summary>
        public IList<string> Command { get; }
        /// <summary> The exposed ports on the container instance. </summary>
        public IList<ContainerPort> Ports { get; }
        /// <summary> The environment variables to set in the container instance. </summary>
        public IList<ContainerEnvironmentVariable> EnvironmentVariables { get; }
        /// <summary> The instance view of the container instance. Only valid in response. </summary>
        public ContainerInstanceView InstanceView { get; }
        /// <summary> The resource requirements of the container instance. </summary>
        public ContainerResourceRequirements Resources { get; set; }
        /// <summary> The volume mounts available to the container instance. </summary>
        public IList<ContainerVolumeMount> VolumeMounts { get; }
        /// <summary> The liveness probe. </summary>
        public ContainerProbe LivenessProbe { get; set; }
        /// <summary> The readiness probe. </summary>
        public ContainerProbe ReadinessProbe { get; set; }
        /// <summary> The container security properties. </summary>
        public ContainerSecurityContextDefinition SecurityContext { get; set; }
    }
}
