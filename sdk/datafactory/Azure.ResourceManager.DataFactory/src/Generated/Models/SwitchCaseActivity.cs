// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Switch cases with have a value and corresponding activities. </summary>
    public partial class SwitchCaseActivity
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SwitchCaseActivity"/>. </summary>
        public SwitchCaseActivity()
        {
            Activities = new ChangeTrackingList<PipelineActivity>();
        }

        /// <summary> Initializes a new instance of <see cref="SwitchCaseActivity"/>. </summary>
        /// <param name="value"> Expected value that satisfies the expression result of the 'on' property. </param>
        /// <param name="activities">
        /// List of activities to execute for satisfied case condition.
        /// Please note <see cref="PipelineActivity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AppendVariableActivity"/>, <see cref="AzureDataExplorerCommandActivity"/>, <see cref="AzureFunctionActivity"/>, <see cref="AzureMLBatchExecutionActivity"/>, <see cref="AzureMLExecutePipelineActivity"/>, <see cref="AzureMLUpdateResourceActivity"/>, <see cref="ControlActivity"/>, <see cref="CopyActivity"/>, <see cref="CustomActivity"/>, <see cref="DatabricksNotebookActivity"/>, <see cref="DatabricksSparkJarActivity"/>, <see cref="DatabricksSparkPythonActivity"/>, <see cref="DataLakeAnalyticsUsqlActivity"/>, <see cref="DeleteActivity"/>, <see cref="ExecuteDataFlowActivity"/>, <see cref="ExecutePipelineActivity"/>, <see cref="ExecuteSsisPackageActivity"/>, <see cref="ExecuteWranglingDataflowActivity"/>, <see cref="ExecutionActivity"/>, <see cref="FailActivity"/>, <see cref="FilterActivity"/>, <see cref="ForEachActivity"/>, <see cref="GetDatasetMetadataActivity"/>, <see cref="HDInsightHiveActivity"/>, <see cref="HDInsightMapReduceActivity"/>, <see cref="HDInsightPigActivity"/>, <see cref="HDInsightSparkActivity"/>, <see cref="HDInsightStreamingActivity"/>, <see cref="IfConditionActivity"/>, <see cref="LookupActivity"/>, <see cref="DataFactoryScriptActivity"/>, <see cref="SetVariableActivity"/>, <see cref="SynapseSparkJobDefinitionActivity"/>, <see cref="SqlServerStoredProcedureActivity"/>, <see cref="SwitchActivity"/>, <see cref="SynapseNotebookActivity"/>, <see cref="UntilActivity"/>, <see cref="ValidationActivity"/>, <see cref="WaitActivity"/>, <see cref="WebActivity"/> and <see cref="WebHookActivity"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SwitchCaseActivity(string value, IList<PipelineActivity> activities, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            Activities = activities;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Expected value that satisfies the expression result of the 'on' property. </summary>
        public string Value { get; set; }
        /// <summary>
        /// List of activities to execute for satisfied case condition.
        /// Please note <see cref="PipelineActivity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AppendVariableActivity"/>, <see cref="AzureDataExplorerCommandActivity"/>, <see cref="AzureFunctionActivity"/>, <see cref="AzureMLBatchExecutionActivity"/>, <see cref="AzureMLExecutePipelineActivity"/>, <see cref="AzureMLUpdateResourceActivity"/>, <see cref="ControlActivity"/>, <see cref="CopyActivity"/>, <see cref="CustomActivity"/>, <see cref="DatabricksNotebookActivity"/>, <see cref="DatabricksSparkJarActivity"/>, <see cref="DatabricksSparkPythonActivity"/>, <see cref="DataLakeAnalyticsUsqlActivity"/>, <see cref="DeleteActivity"/>, <see cref="ExecuteDataFlowActivity"/>, <see cref="ExecutePipelineActivity"/>, <see cref="ExecuteSsisPackageActivity"/>, <see cref="ExecuteWranglingDataflowActivity"/>, <see cref="ExecutionActivity"/>, <see cref="FailActivity"/>, <see cref="FilterActivity"/>, <see cref="ForEachActivity"/>, <see cref="GetDatasetMetadataActivity"/>, <see cref="HDInsightHiveActivity"/>, <see cref="HDInsightMapReduceActivity"/>, <see cref="HDInsightPigActivity"/>, <see cref="HDInsightSparkActivity"/>, <see cref="HDInsightStreamingActivity"/>, <see cref="IfConditionActivity"/>, <see cref="LookupActivity"/>, <see cref="DataFactoryScriptActivity"/>, <see cref="SetVariableActivity"/>, <see cref="SynapseSparkJobDefinitionActivity"/>, <see cref="SqlServerStoredProcedureActivity"/>, <see cref="SwitchActivity"/>, <see cref="SynapseNotebookActivity"/>, <see cref="UntilActivity"/>, <see cref="ValidationActivity"/>, <see cref="WaitActivity"/>, <see cref="WebActivity"/> and <see cref="WebHookActivity"/>.
        /// </summary>
        public IList<PipelineActivity> Activities { get; }
    }
}
