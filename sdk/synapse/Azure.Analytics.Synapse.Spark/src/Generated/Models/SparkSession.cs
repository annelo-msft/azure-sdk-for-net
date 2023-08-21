// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Spark.Models
{
    /// <summary> The SparkSession. </summary>
    public partial class SparkSession
    {
        /// <summary> Initializes a new instance of SparkSession. </summary>
        /// <param name="id"></param>
        internal SparkSession(int id)
        {
            Errors = new Core.ChangeTrackingList<SparkServiceError>();
            Tags = new Core.ChangeTrackingDictionary<string, string>();
            Id = id;
            AppInfo = new Core.ChangeTrackingDictionary<string, string>();
            LogLines = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of SparkSession. </summary>
        /// <param name="livyInfo"></param>
        /// <param name="name"></param>
        /// <param name="workspaceName"></param>
        /// <param name="sparkPoolName"></param>
        /// <param name="submitterName"></param>
        /// <param name="submitterId"></param>
        /// <param name="artifactId"></param>
        /// <param name="jobType"> The job type. </param>
        /// <param name="result"></param>
        /// <param name="scheduler"></param>
        /// <param name="plugin"></param>
        /// <param name="errors"></param>
        /// <param name="tags"> Dictionary of &lt;string&gt;. </param>
        /// <param name="id"></param>
        /// <param name="appId"></param>
        /// <param name="appInfo"> Dictionary of &lt;string&gt;. </param>
        /// <param name="state"> The session state. </param>
        /// <param name="logLines"></param>
        internal SparkSession(SparkSessionState livyInfo, string name, string workspaceName, string sparkPoolName, string submitterName, string submitterId, string artifactId, SparkJobType? jobType, SparkSessionResultType? result, SparkScheduler scheduler, SparkServicePlugin plugin, IReadOnlyList<SparkServiceError> errors, IReadOnlyDictionary<string, string> tags, int id, string appId, IReadOnlyDictionary<string, string> appInfo, LivyStates? state, IReadOnlyList<string> logLines)
        {
            LivyInfo = livyInfo;
            Name = name;
            WorkspaceName = workspaceName;
            SparkPoolName = sparkPoolName;
            SubmitterName = submitterName;
            SubmitterId = submitterId;
            ArtifactId = artifactId;
            JobType = jobType;
            Result = result;
            Scheduler = scheduler;
            Plugin = plugin;
            Errors = errors;
            Tags = tags;
            Id = id;
            AppId = appId;
            AppInfo = appInfo;
            State = state;
            LogLines = logLines;
        }

        /// <summary> Gets the livy info. </summary>
        public SparkSessionState LivyInfo { get; }
        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the workspace name. </summary>
        public string WorkspaceName { get; }
        /// <summary> Gets the spark pool name. </summary>
        public string SparkPoolName { get; }
        /// <summary> Gets the submitter name. </summary>
        public string SubmitterName { get; }
        /// <summary> Gets the submitter id. </summary>
        public string SubmitterId { get; }
        /// <summary> Gets the artifact id. </summary>
        public string ArtifactId { get; }
        /// <summary> The job type. </summary>
        public SparkJobType? JobType { get; }
        /// <summary> Gets the result. </summary>
        public SparkSessionResultType? Result { get; }
        /// <summary> Gets the scheduler. </summary>
        public SparkScheduler Scheduler { get; }
        /// <summary> Gets the plugin. </summary>
        public SparkServicePlugin Plugin { get; }
        /// <summary> Gets the errors. </summary>
        public IReadOnlyList<SparkServiceError> Errors { get; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
        /// <summary> Gets the id. </summary>
        public int Id { get; }
        /// <summary> Gets the app id. </summary>
        public string AppId { get; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IReadOnlyDictionary<string, string> AppInfo { get; }
        /// <summary> The session state. </summary>
        public LivyStates? State { get; }
        /// <summary> Gets the log lines. </summary>
        public IReadOnlyList<string> LogLines { get; }
    }
}
