// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Client.Models
{
    /// <summary> A single, existing message within an agent thread. </summary>
    public partial class ThreadMessage
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

        /// <summary> Initializes a new instance of <see cref="ThreadMessage"/>. </summary>
        /// <param name="id"> The identifier, which can be referenced in API endpoints. </param>
        /// <param name="createdAt"> The Unix timestamp, in seconds, representing when this object was created. </param>
        /// <param name="threadId"> The ID of the thread that this message belongs to. </param>
        /// <param name="status"> The status of the message. </param>
        /// <param name="incompleteDetails"> On an incomplete message, details about why the message is incomplete. </param>
        /// <param name="completedAt"> The Unix timestamp (in seconds) for when the message was completed. </param>
        /// <param name="incompleteAt"> The Unix timestamp (in seconds) for when the message was marked as incomplete. </param>
        /// <param name="role"> The role associated with the agent thread message. </param>
        /// <param name="contentItems">
        /// The list of content items associated with the agent thread message.
        /// Please note <see cref="MessageContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MessageImageFileContent"/> and <see cref="MessageTextContent"/>.
        /// </param>
        /// <param name="assistantId"> If applicable, the ID of the agent that authored this message. </param>
        /// <param name="runId"> If applicable, the ID of the run associated with the authoring of this message. </param>
        /// <param name="attachments"> A list of files attached to the message, and the tools they were added to. </param>
        /// <param name="metadata"> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="threadId"/> or <paramref name="contentItems"/> is null. </exception>
        public ThreadMessage(string id, DateTimeOffset createdAt, string threadId, MessageStatus status, MessageIncompleteDetails incompleteDetails, DateTimeOffset? completedAt, DateTimeOffset? incompleteAt, MessageRole role, IEnumerable<MessageContent> contentItems, string assistantId, string runId, IEnumerable<MessageAttachment> attachments, IDictionary<string, string> metadata)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(threadId, nameof(threadId));
            Argument.AssertNotNull(contentItems, nameof(contentItems));

            Id = id;
            CreatedAt = createdAt;
            ThreadId = threadId;
            Status = status;
            IncompleteDetails = incompleteDetails;
            CompletedAt = completedAt;
            IncompleteAt = incompleteAt;
            Role = role;
            ContentItems = contentItems.ToList();
            AssistantId = assistantId;
            RunId = runId;
            Attachments = attachments?.ToList();
            Metadata = metadata;
        }

        /// <summary> Initializes a new instance of <see cref="ThreadMessage"/>. </summary>
        /// <param name="id"> The identifier, which can be referenced in API endpoints. </param>
        /// <param name="object"> The object type, which is always 'thread.message'. </param>
        /// <param name="createdAt"> The Unix timestamp, in seconds, representing when this object was created. </param>
        /// <param name="threadId"> The ID of the thread that this message belongs to. </param>
        /// <param name="status"> The status of the message. </param>
        /// <param name="incompleteDetails"> On an incomplete message, details about why the message is incomplete. </param>
        /// <param name="completedAt"> The Unix timestamp (in seconds) for when the message was completed. </param>
        /// <param name="incompleteAt"> The Unix timestamp (in seconds) for when the message was marked as incomplete. </param>
        /// <param name="role"> The role associated with the agent thread message. </param>
        /// <param name="contentItems">
        /// The list of content items associated with the agent thread message.
        /// Please note <see cref="MessageContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MessageImageFileContent"/> and <see cref="MessageTextContent"/>.
        /// </param>
        /// <param name="assistantId"> If applicable, the ID of the agent that authored this message. </param>
        /// <param name="runId"> If applicable, the ID of the run associated with the authoring of this message. </param>
        /// <param name="attachments"> A list of files attached to the message, and the tools they were added to. </param>
        /// <param name="metadata"> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ThreadMessage(string id, string @object, DateTimeOffset createdAt, string threadId, MessageStatus status, MessageIncompleteDetails incompleteDetails, DateTimeOffset? completedAt, DateTimeOffset? incompleteAt, MessageRole role, IList<MessageContent> contentItems, string assistantId, string runId, IList<MessageAttachment> attachments, IDictionary<string, string> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Object = @object;
            CreatedAt = createdAt;
            ThreadId = threadId;
            Status = status;
            IncompleteDetails = incompleteDetails;
            CompletedAt = completedAt;
            IncompleteAt = incompleteAt;
            Role = role;
            ContentItems = contentItems;
            AssistantId = assistantId;
            RunId = runId;
            Attachments = attachments;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ThreadMessage"/> for deserialization. </summary>
        internal ThreadMessage()
        {
        }

        /// <summary> The identifier, which can be referenced in API endpoints. </summary>
        public string Id { get; set; }

        /// <summary> The Unix timestamp, in seconds, representing when this object was created. </summary>
        public DateTimeOffset CreatedAt { get; set; }
        /// <summary> The ID of the thread that this message belongs to. </summary>
        public string ThreadId { get; set; }
        /// <summary> The status of the message. </summary>
        public MessageStatus Status { get; set; }
        /// <summary> On an incomplete message, details about why the message is incomplete. </summary>
        public MessageIncompleteDetails IncompleteDetails { get; set; }
        /// <summary> The Unix timestamp (in seconds) for when the message was completed. </summary>
        public DateTimeOffset? CompletedAt { get; set; }
        /// <summary> The Unix timestamp (in seconds) for when the message was marked as incomplete. </summary>
        public DateTimeOffset? IncompleteAt { get; set; }
        /// <summary> The role associated with the agent thread message. </summary>
        public MessageRole Role { get; set; }
        /// <summary>
        /// The list of content items associated with the agent thread message.
        /// Please note <see cref="MessageContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MessageImageFileContent"/> and <see cref="MessageTextContent"/>.
        /// </summary>
        public IList<MessageContent> ContentItems { get; }
        /// <summary> If applicable, the ID of the agent that authored this message. </summary>
        public string AssistantId { get; set; }
        /// <summary> If applicable, the ID of the run associated with the authoring of this message. </summary>
        public string RunId { get; set; }
        /// <summary> A list of files attached to the message, and the tools they were added to. </summary>
        public IList<MessageAttachment> Attachments { get; set; }
        /// <summary> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </summary>
        public IDictionary<string, string> Metadata { get; set; }
    }
}
