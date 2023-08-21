// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Communication.JobRouter;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    public partial class RouterJob : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ChannelReference))
            {
                writer.WritePropertyName("channelReference"u8);
                writer.WriteStringValue(ChannelReference);
            }
            if (Core.Optional.IsDefined(ChannelId))
            {
                writer.WritePropertyName("channelId"u8);
                writer.WriteStringValue(ChannelId);
            }
            if (Core.Optional.IsDefined(ClassificationPolicyId))
            {
                writer.WritePropertyName("classificationPolicyId"u8);
                writer.WriteStringValue(ClassificationPolicyId);
            }
            if (Core.Optional.IsDefined(QueueId))
            {
                writer.WritePropertyName("queueId"u8);
                writer.WriteStringValue(QueueId);
            }
            if (Core.Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (Core.Optional.IsDefined(DispositionCode))
            {
                writer.WritePropertyName("dispositionCode"u8);
                writer.WriteStringValue(DispositionCode);
            }
            if (Core.Optional.IsCollectionDefined(_requestedWorkerSelectors))
            {
                writer.WritePropertyName("requestedWorkerSelectors"u8);
                writer.WriteStartArray();
                foreach (var item in _requestedWorkerSelectors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(_labels))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartObject();
                foreach (var item in _labels)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Core.Optional.IsCollectionDefined(_tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in _tags)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Core.Optional.IsCollectionDefined(_notes))
            {
                writer.WritePropertyName("notes"u8);
                writer.WriteStartObject();
                foreach (var item in _notes)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Core.Optional.IsDefined(MatchingMode))
            {
                writer.WritePropertyName("matchingMode"u8);
                writer.WriteObjectValue(MatchingMode);
            }
            writer.WriteEndObject();
        }

        internal static RouterJob DeserializeRouterJob(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> id = default;
            Core.Optional<string> channelReference = default;
            Core.Optional<RouterJobStatus> status = default;
            Core.Optional<DateTimeOffset> enqueuedAt = default;
            Core.Optional<string> channelId = default;
            Core.Optional<string> classificationPolicyId = default;
            Core.Optional<string> queueId = default;
            Core.Optional<int> priority = default;
            Core.Optional<string> dispositionCode = default;
            Core.Optional<IList<RouterWorkerSelector>> requestedWorkerSelectors = default;
            Core.Optional<IReadOnlyList<RouterWorkerSelector>> attachedWorkerSelectors = default;
            Core.Optional<IDictionary<string, object>> labels = default;
            Core.Optional<IReadOnlyDictionary<string, RouterJobAssignment>> assignments = default;
            Core.Optional<IDictionary<string, object>> tags = default;
            Core.Optional<IDictionary<string, string>> notes = default;
            Core.Optional<DateTimeOffset> scheduledAt = default;
            Core.Optional<JobMatchingMode> matchingMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelReference"u8))
                {
                    channelReference = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new RouterJobStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enqueuedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enqueuedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("channelId"u8))
                {
                    channelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("classificationPolicyId"u8))
                {
                    classificationPolicyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queueId"u8))
                {
                    queueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dispositionCode"u8))
                {
                    dispositionCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestedWorkerSelectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouterWorkerSelector> array = new List<RouterWorkerSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouterWorkerSelector.DeserializeRouterWorkerSelector(item));
                    }
                    requestedWorkerSelectors = array;
                    continue;
                }
                if (property.NameEquals("attachedWorkerSelectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouterWorkerSelector> array = new List<RouterWorkerSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouterWorkerSelector.DeserializeRouterWorkerSelector(item));
                    }
                    attachedWorkerSelectors = array;
                    continue;
                }
                if (property.NameEquals("labels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    labels = dictionary;
                    continue;
                }
                if (property.NameEquals("assignments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, RouterJobAssignment> dictionary = new Dictionary<string, RouterJobAssignment>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, RouterJobAssignment.DeserializeRouterJobAssignment(property0.Value));
                    }
                    assignments = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("notes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    notes = dictionary;
                    continue;
                }
                if (property.NameEquals("scheduledAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduledAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("matchingMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    matchingMode = JobMatchingMode.DeserializeJobMatchingMode(property.Value);
                    continue;
                }
            }
            return new RouterJob(id.Value, channelReference.Value, Core.Optional.ToNullable(status), Core.Optional.ToNullable(enqueuedAt), channelId.Value, classificationPolicyId.Value, queueId.Value, Core.Optional.ToNullable(priority), dispositionCode.Value, Core.Optional.ToList(requestedWorkerSelectors), Core.Optional.ToList(attachedWorkerSelectors), Core.Optional.ToDictionary(labels), Core.Optional.ToDictionary(assignments), Core.Optional.ToDictionary(tags), Core.Optional.ToDictionary(notes), Core.Optional.ToNullable(scheduledAt), matchingMode.Value);
        }
    }
}
