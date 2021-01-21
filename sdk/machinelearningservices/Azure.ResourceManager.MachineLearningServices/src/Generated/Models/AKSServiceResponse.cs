// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The response for an AKS service. </summary>
    public partial class AKSServiceResponse : AKSVariantResponse
    {
        /// <summary> Initializes a new instance of AKSServiceResponse. </summary>
        public AKSServiceResponse()
        {
            Models = new ChangeTrackingList<Model>();
            ModelConfigMap = new ChangeTrackingDictionary<string, object>();
            ComputeType = ComputeEnvironmentType.AKS;
        }

        /// <summary> Initializes a new instance of AKSServiceResponse. </summary>
        /// <param name="description"> The service description. </param>
        /// <param name="kvTags"> The service tag dictionary. Tags are mutable. </param>
        /// <param name="properties"> The service property dictionary. Properties are immutable. </param>
        /// <param name="state"> The current state of the service. </param>
        /// <param name="error"> The error details. </param>
        /// <param name="computeType"> The compute environment type for the service. </param>
        /// <param name="deploymentType"> The deployment type for the service. </param>
        /// <param name="isDefault"> Is this the default variant. </param>
        /// <param name="trafficPercentile"> The amount of traffic variant receives. </param>
        /// <param name="type"> The type of the variant. </param>
        /// <param name="models"> The list of models. </param>
        /// <param name="containerResourceRequirements"> The container resource requirements. </param>
        /// <param name="maxConcurrentRequestsPerContainer"> The maximum number of concurrent requests per container. </param>
        /// <param name="maxQueueWaitMs"> Maximum time a request will wait in the queue (in milliseconds). After this time, the service will return 503 (Service Unavailable). </param>
        /// <param name="computeName"> The name of the compute resource. </param>
        /// <param name="namespace"> The Kubernetes namespace of the deployment. </param>
        /// <param name="numReplicas"> The number of replicas on the cluster. </param>
        /// <param name="dataCollection"> Details of the data collection options specified. </param>
        /// <param name="appInsightsEnabled"> Whether or not Application Insights is enabled. </param>
        /// <param name="autoScaler"> The auto scaler properties. </param>
        /// <param name="scoringUri"> The Uri for sending scoring requests. </param>
        /// <param name="deploymentStatus"> The deployment status. </param>
        /// <param name="scoringTimeoutMs"> The scoring timeout in milliseconds. </param>
        /// <param name="livenessProbeRequirements"> The liveness probe requirements. </param>
        /// <param name="authEnabled"> Whether or not authentication is enabled. </param>
        /// <param name="aadAuthEnabled"> Whether or not AAD authentication is enabled. </param>
        /// <param name="swaggerUri"> The Uri for sending swagger requests. </param>
        /// <param name="modelConfigMap"> Details on the models and configurations. </param>
        /// <param name="environmentImageRequest"> The Environment, models and assets used for inferencing. </param>
        internal AKSServiceResponse(string description, IDictionary<string, string> kvTags, IDictionary<string, string> properties, WebServiceState? state, ErrorResponse error, ComputeEnvironmentType computeType, DeploymentType? deploymentType, bool? isDefault, float? trafficPercentile, VariantType? type, IList<Model> models, ContainerResourceRequirements containerResourceRequirements, int? maxConcurrentRequestsPerContainer, int? maxQueueWaitMs, string computeName, string @namespace, int? numReplicas, ModelDataCollection dataCollection, bool? appInsightsEnabled, AutoScaler autoScaler, string scoringUri, AKSReplicaStatus deploymentStatus, int? scoringTimeoutMs, LivenessProbeRequirements livenessProbeRequirements, bool? authEnabled, bool? aadAuthEnabled, string swaggerUri, IReadOnlyDictionary<string, object> modelConfigMap, EnvironmentImageResponse environmentImageRequest) : base(description, kvTags, properties, state, error, computeType, deploymentType, isDefault, trafficPercentile, type)
        {
            Models = models;
            ContainerResourceRequirements = containerResourceRequirements;
            MaxConcurrentRequestsPerContainer = maxConcurrentRequestsPerContainer;
            MaxQueueWaitMs = maxQueueWaitMs;
            ComputeName = computeName;
            Namespace = @namespace;
            NumReplicas = numReplicas;
            DataCollection = dataCollection;
            AppInsightsEnabled = appInsightsEnabled;
            AutoScaler = autoScaler;
            ScoringUri = scoringUri;
            DeploymentStatus = deploymentStatus;
            ScoringTimeoutMs = scoringTimeoutMs;
            LivenessProbeRequirements = livenessProbeRequirements;
            AuthEnabled = authEnabled;
            AadAuthEnabled = aadAuthEnabled;
            SwaggerUri = swaggerUri;
            ModelConfigMap = modelConfigMap;
            EnvironmentImageRequest = environmentImageRequest;
            ComputeType = computeType;
        }

        /// <summary> The list of models. </summary>
        public IList<Model> Models { get; }
        /// <summary> The container resource requirements. </summary>
        public ContainerResourceRequirements ContainerResourceRequirements { get; set; }
        /// <summary> The maximum number of concurrent requests per container. </summary>
        public int? MaxConcurrentRequestsPerContainer { get; set; }
        /// <summary> Maximum time a request will wait in the queue (in milliseconds). After this time, the service will return 503 (Service Unavailable). </summary>
        public int? MaxQueueWaitMs { get; set; }
        /// <summary> The name of the compute resource. </summary>
        public string ComputeName { get; set; }
        /// <summary> The Kubernetes namespace of the deployment. </summary>
        public string Namespace { get; set; }
        /// <summary> The number of replicas on the cluster. </summary>
        public int? NumReplicas { get; set; }
        /// <summary> Details of the data collection options specified. </summary>
        public ModelDataCollection DataCollection { get; set; }
        /// <summary> Whether or not Application Insights is enabled. </summary>
        public bool? AppInsightsEnabled { get; set; }
        /// <summary> The auto scaler properties. </summary>
        public AutoScaler AutoScaler { get; set; }
        /// <summary> The Uri for sending scoring requests. </summary>
        public string ScoringUri { get; }
        /// <summary> The deployment status. </summary>
        public AKSReplicaStatus DeploymentStatus { get; }
        /// <summary> The scoring timeout in milliseconds. </summary>
        public int? ScoringTimeoutMs { get; set; }
        /// <summary> The liveness probe requirements. </summary>
        public LivenessProbeRequirements LivenessProbeRequirements { get; set; }
        /// <summary> Whether or not authentication is enabled. </summary>
        public bool? AuthEnabled { get; set; }
        /// <summary> Whether or not AAD authentication is enabled. </summary>
        public bool? AadAuthEnabled { get; set; }
        /// <summary> The Uri for sending swagger requests. </summary>
        public string SwaggerUri { get; }
        /// <summary> Details on the models and configurations. </summary>
        public IReadOnlyDictionary<string, object> ModelConfigMap { get; }
        /// <summary> The Environment, models and assets used for inferencing. </summary>
        public EnvironmentImageResponse EnvironmentImageRequest { get; set; }
    }
}
