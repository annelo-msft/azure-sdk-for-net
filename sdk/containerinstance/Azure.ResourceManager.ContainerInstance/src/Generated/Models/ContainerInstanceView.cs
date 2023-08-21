// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The instance view of the container instance. Only valid in response. </summary>
    public partial class ContainerInstanceView
    {
        /// <summary> Initializes a new instance of ContainerInstanceView. </summary>
        internal ContainerInstanceView()
        {
            Events = new Core.ChangeTrackingList<ContainerEvent>();
        }

        /// <summary> Initializes a new instance of ContainerInstanceView. </summary>
        /// <param name="restartCount"> The number of times that the container instance has been restarted. </param>
        /// <param name="currentState"> Current container instance state. </param>
        /// <param name="previousState"> Previous container instance state. </param>
        /// <param name="events"> The events of the container instance. </param>
        internal ContainerInstanceView(int? restartCount, ContainerState currentState, ContainerState previousState, IReadOnlyList<ContainerEvent> events)
        {
            RestartCount = restartCount;
            CurrentState = currentState;
            PreviousState = previousState;
            Events = events;
        }

        /// <summary> The number of times that the container instance has been restarted. </summary>
        public int? RestartCount { get; }
        /// <summary> Current container instance state. </summary>
        public ContainerState CurrentState { get; }
        /// <summary> Previous container instance state. </summary>
        public ContainerState PreviousState { get; }
        /// <summary> The events of the container instance. </summary>
        public IReadOnlyList<ContainerEvent> Events { get; }
    }
}
