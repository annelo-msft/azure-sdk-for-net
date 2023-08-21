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
    /// <summary> DatabricksNotebook activity. </summary>
    public partial class DatabricksNotebookActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of DatabricksNotebookActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="notebookPath"> The absolute path of the notebook to be run in the Databricks Workspace. This path must begin with a slash. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="notebookPath"/> is null. </exception>
        public DatabricksNotebookActivity(string name, DataFactoryElement<string> notebookPath) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(notebookPath, nameof(notebookPath));

            NotebookPath = notebookPath;
            BaseParameters = new Core.ChangeTrackingDictionary<string, BinaryData>();
            Libraries = new Core.ChangeTrackingList<IDictionary<string, BinaryData>>();
            ActivityType = "DatabricksNotebook";
        }

        /// <summary> Initializes a new instance of DatabricksNotebookActivity. </summary>
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
        /// <param name="notebookPath"> The absolute path of the notebook to be run in the Databricks Workspace. This path must begin with a slash. Type: string (or Expression with resultType string). </param>
        /// <param name="baseParameters"> Base parameters to be used for each run of this job.If the notebook takes a parameter that is not specified, the default value from the notebook will be used. </param>
        /// <param name="libraries"> A list of libraries to be installed on the cluster that will execute the job. </param>
        internal DatabricksNotebookActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, DataFactoryLinkedServiceReference linkedServiceName, PipelineActivityPolicy policy, DataFactoryElement<string> notebookPath, IDictionary<string, BinaryData> baseParameters, IList<IDictionary<string, BinaryData>> libraries) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            NotebookPath = notebookPath;
            BaseParameters = baseParameters;
            Libraries = libraries;
            ActivityType = activityType ?? "DatabricksNotebook";
        }

        /// <summary> The absolute path of the notebook to be run in the Databricks Workspace. This path must begin with a slash. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> NotebookPath { get; set; }
        /// <summary>
        /// Base parameters to be used for each run of this job.If the notebook takes a parameter that is not specified, the default value from the notebook will be used.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public IDictionary<string, BinaryData> BaseParameters { get; }
        /// <summary> A list of libraries to be installed on the cluster that will execute the job. </summary>
        public IList<IDictionary<string, BinaryData>> Libraries { get; }
    }
}
