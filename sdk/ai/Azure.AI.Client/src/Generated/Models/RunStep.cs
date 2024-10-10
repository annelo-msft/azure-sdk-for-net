// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Client.Models
{
    /// <summary> Detailed information about a single step of an agent thread run. </summary>
    public partial class RunStep
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

        /// <summary> Initializes a new instance of <see cref="RunStep"/>. </summary>
        /// <param name="id"> The identifier, which can be referenced in API endpoints. </param>
        /// <param name="type"> The type of run step, which can be either message_creation or tool_calls. </param>
        /// <param name="assistantId"> The ID of the agent associated with the run step. </param>
        /// <param name="threadId"> The ID of the thread that was run. </param>
        /// <param name="runId"> The ID of the run that this run step is a part of. </param>
        /// <param name="status"> The status of this run step. </param>
        /// <param name="stepDetails">
        /// The details for this run step.
        /// Please note <see cref="RunStepDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RunStepMessageCreationDetails"/> and <see cref="RunStepToolCallDetails"/>.
        /// </param>
        /// <param name="lastError"> If applicable, information about the last error encountered by this run step. </param>
        /// <param name="createdAt"> The Unix timestamp, in seconds, representing when this object was created. </param>
        /// <param name="expiredAt"> The Unix timestamp, in seconds, representing when this item expired. </param>
        /// <param name="completedAt"> The Unix timestamp, in seconds, representing when this completed. </param>
        /// <param name="cancelledAt"> The Unix timestamp, in seconds, representing when this was cancelled. </param>
        /// <param name="failedAt"> The Unix timestamp, in seconds, representing when this failed. </param>
        /// <param name="metadata"> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="assistantId"/>, <paramref name="threadId"/>, <paramref name="runId"/> or <paramref name="stepDetails"/> is null. </exception>
        internal RunStep(string id, RunStepType type, string assistantId, string threadId, string runId, RunStepStatus status, RunStepDetails stepDetails, RunStepError lastError, DateTimeOffset createdAt, DateTimeOffset? expiredAt, DateTimeOffset? completedAt, DateTimeOffset? cancelledAt, DateTimeOffset? failedAt, IReadOnlyDictionary<string, string> metadata)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(assistantId, nameof(assistantId));
            Argument.AssertNotNull(threadId, nameof(threadId));
            Argument.AssertNotNull(runId, nameof(runId));
            Argument.AssertNotNull(stepDetails, nameof(stepDetails));

            Id = id;
            Type = type;
            AssistantId = assistantId;
            ThreadId = threadId;
            RunId = runId;
            Status = status;
            StepDetails = stepDetails;
            LastError = lastError;
            CreatedAt = createdAt;
            ExpiredAt = expiredAt;
            CompletedAt = completedAt;
            CancelledAt = cancelledAt;
            FailedAt = failedAt;
            Metadata = metadata;
        }

        /// <summary> Initializes a new instance of <see cref="RunStep"/>. </summary>
        /// <param name="id"> The identifier, which can be referenced in API endpoints. </param>
        /// <param name="object"> The object type, which is always 'thread.run.step'. </param>
        /// <param name="type"> The type of run step, which can be either message_creation or tool_calls. </param>
        /// <param name="assistantId"> The ID of the agent associated with the run step. </param>
        /// <param name="threadId"> The ID of the thread that was run. </param>
        /// <param name="runId"> The ID of the run that this run step is a part of. </param>
        /// <param name="status"> The status of this run step. </param>
        /// <param name="stepDetails">
        /// The details for this run step.
        /// Please note <see cref="RunStepDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RunStepMessageCreationDetails"/> and <see cref="RunStepToolCallDetails"/>.
        /// </param>
        /// <param name="lastError"> If applicable, information about the last error encountered by this run step. </param>
        /// <param name="createdAt"> The Unix timestamp, in seconds, representing when this object was created. </param>
        /// <param name="expiredAt"> The Unix timestamp, in seconds, representing when this item expired. </param>
        /// <param name="completedAt"> The Unix timestamp, in seconds, representing when this completed. </param>
        /// <param name="cancelledAt"> The Unix timestamp, in seconds, representing when this was cancelled. </param>
        /// <param name="failedAt"> The Unix timestamp, in seconds, representing when this failed. </param>
        /// <param name="usage"> Usage statistics related to the run step. This value will be `null` while the run step's status is `in_progress`. </param>
        /// <param name="metadata"> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RunStep(string id, string @object, RunStepType type, string assistantId, string threadId, string runId, RunStepStatus status, RunStepDetails stepDetails, RunStepError lastError, DateTimeOffset createdAt, DateTimeOffset? expiredAt, DateTimeOffset? completedAt, DateTimeOffset? cancelledAt, DateTimeOffset? failedAt, RunStepCompletionUsage usage, IReadOnlyDictionary<string, string> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Object = @object;
            Type = type;
            AssistantId = assistantId;
            ThreadId = threadId;
            RunId = runId;
            Status = status;
            StepDetails = stepDetails;
            LastError = lastError;
            CreatedAt = createdAt;
            ExpiredAt = expiredAt;
            CompletedAt = completedAt;
            CancelledAt = cancelledAt;
            FailedAt = failedAt;
            Usage = usage;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RunStep"/> for deserialization. </summary>
        internal RunStep()
        {
        }

        /// <summary> The identifier, which can be referenced in API endpoints. </summary>
        public string Id { get; }

        /// <summary> The type of run step, which can be either message_creation or tool_calls. </summary>
        public RunStepType Type { get; }
        /// <summary> The ID of the agent associated with the run step. </summary>
        public string AssistantId { get; }
        /// <summary> The ID of the thread that was run. </summary>
        public string ThreadId { get; }
        /// <summary> The ID of the run that this run step is a part of. </summary>
        public string RunId { get; }
        /// <summary> The status of this run step. </summary>
        public RunStepStatus Status { get; }
        /// <summary>
        /// The details for this run step.
        /// Please note <see cref="RunStepDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RunStepMessageCreationDetails"/> and <see cref="RunStepToolCallDetails"/>.
        /// </summary>
        public RunStepDetails StepDetails { get; }
        /// <summary> If applicable, information about the last error encountered by this run step. </summary>
        public RunStepError LastError { get; }
        /// <summary> The Unix timestamp, in seconds, representing when this object was created. </summary>
        public DateTimeOffset CreatedAt { get; }
        /// <summary> The Unix timestamp, in seconds, representing when this item expired. </summary>
        public DateTimeOffset? ExpiredAt { get; }
        /// <summary> The Unix timestamp, in seconds, representing when this completed. </summary>
        public DateTimeOffset? CompletedAt { get; }
        /// <summary> The Unix timestamp, in seconds, representing when this was cancelled. </summary>
        public DateTimeOffset? CancelledAt { get; }
        /// <summary> The Unix timestamp, in seconds, representing when this failed. </summary>
        public DateTimeOffset? FailedAt { get; }
        /// <summary> Usage statistics related to the run step. This value will be `null` while the run step's status is `in_progress`. </summary>
        public RunStepCompletionUsage Usage { get; }
        /// <summary> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </summary>
        public IReadOnlyDictionary<string, string> Metadata { get; }
    }
}
