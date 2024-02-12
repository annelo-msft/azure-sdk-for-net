// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Execute Synapse notebook activity. </summary>
    public partial class SynapseNotebookActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of <see cref="SynapseNotebookActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="notebook"> Synapse notebook reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="notebook"/> is null. </exception>
        public SynapseNotebookActivity(string name, SynapseNotebookReference notebook) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(notebook, nameof(notebook));

            Notebook = notebook;
            Parameters = new ChangeTrackingDictionary<string, NotebookParameter>();
            SparkConfig = new ChangeTrackingDictionary<string, BinaryData>();
            ActivityType = "SynapseNotebook";
        }

        /// <summary> Initializes a new instance of <see cref="SynapseNotebookActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="notebook"> Synapse notebook reference. </param>
        /// <param name="sparkPool"> The name of the big data pool which will be used to execute the notebook. </param>
        /// <param name="parameters"> Notebook parameters. </param>
        /// <param name="executorSize"> Number of core and memory to be used for executors allocated in the specified Spark pool for the session, which will be used for overriding 'executorCores' and 'executorMemory' of the notebook you provide. Type: string (or Expression with resultType string). </param>
        /// <param name="conf"> Spark configuration properties, which will override the 'conf' of the notebook you provide. </param>
        /// <param name="driverSize"> Number of core and memory to be used for driver allocated in the specified Spark pool for the session, which will be used for overriding 'driverCores' and 'driverMemory' of the notebook you provide. Type: string (or Expression with resultType string). </param>
        /// <param name="numExecutors"> Number of executors to launch for this session, which will override the 'numExecutors' of the notebook you provide. Type: integer (or Expression with resultType integer). </param>
        /// <param name="configurationType"> The type of the spark config. </param>
        /// <param name="targetSparkConfiguration"> The spark configuration of the spark job. </param>
        /// <param name="sparkConfig"> Spark configuration property. </param>
        internal SynapseNotebookActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, DataFactoryLinkedServiceReference linkedServiceName, PipelineActivityPolicy policy, SynapseNotebookReference notebook, BigDataPoolParametrizationReference sparkPool, IDictionary<string, NotebookParameter> parameters, DataFactoryElement<string> executorSize, BinaryData conf, DataFactoryElement<string> driverSize, DataFactoryElement<int> numExecutors, DataFactorySparkConfigurationType? configurationType, SparkConfigurationParametrizationReference targetSparkConfiguration, IDictionary<string, BinaryData> sparkConfig) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            Notebook = notebook;
            SparkPool = sparkPool;
            Parameters = parameters;
            ExecutorSize = executorSize;
            Conf = conf;
            DriverSize = driverSize;
            NumExecutors = numExecutors;
            ConfigurationType = configurationType;
            TargetSparkConfiguration = targetSparkConfiguration;
            SparkConfig = sparkConfig;
            ActivityType = activityType ?? "SynapseNotebook";
        }

        /// <summary> Initializes a new instance of <see cref="SynapseNotebookActivity"/> for deserialization. </summary>
        internal SynapseNotebookActivity()
        {
        }

        /// <summary> Synapse notebook reference. </summary>
        public SynapseNotebookReference Notebook { get; set; }
        /// <summary> The name of the big data pool which will be used to execute the notebook. </summary>
        public BigDataPoolParametrizationReference SparkPool { get; set; }
        /// <summary> Notebook parameters. </summary>
        public IDictionary<string, NotebookParameter> Parameters { get; }
        /// <summary> Number of core and memory to be used for executors allocated in the specified Spark pool for the session, which will be used for overriding 'executorCores' and 'executorMemory' of the notebook you provide. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ExecutorSize { get; set; }
        /// <summary>
        /// Spark configuration properties, which will override the 'conf' of the notebook you provide.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Conf { get; set; }
        /// <summary> Number of core and memory to be used for driver allocated in the specified Spark pool for the session, which will be used for overriding 'driverCores' and 'driverMemory' of the notebook you provide. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> DriverSize { get; set; }
        /// <summary> Number of executors to launch for this session, which will override the 'numExecutors' of the notebook you provide. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> NumExecutors { get; set; }
        /// <summary> The type of the spark config. </summary>
        public DataFactorySparkConfigurationType? ConfigurationType { get; set; }
        /// <summary> The spark configuration of the spark job. </summary>
        public SparkConfigurationParametrizationReference TargetSparkConfiguration { get; set; }
        /// <summary>
        /// Spark configuration property.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IDictionary<string, BinaryData> SparkConfig { get; }
    }
}
