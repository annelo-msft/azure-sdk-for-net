// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy.Models
{
    internal partial class TasksStateTasks
    {
        internal static TasksStateTasks DeserializeTasksStateTasks(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int completed = default;
            int failed = default;
            int inProgress = default;
            int total = default;
            Core.Optional<IReadOnlyList<TasksStateTasksEntityRecognitionTasksItem>> entityRecognitionTasks = default;
            Core.Optional<IReadOnlyList<TasksStateTasksEntityRecognitionPiiTasksItem>> entityRecognitionPiiTasks = default;
            Core.Optional<IReadOnlyList<TasksStateTasksKeyPhraseExtractionTasksItem>> keyPhraseExtractionTasks = default;
            Core.Optional<IReadOnlyList<TasksStateTasksEntityLinkingTasksItem>> entityLinkingTasks = default;
            Core.Optional<IReadOnlyList<TasksStateTasksSentimentAnalysisTasksItem>> sentimentAnalysisTasks = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("completed"u8))
                {
                    completed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("failed"u8))
                {
                    failed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("inProgress"u8))
                {
                    inProgress = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("total"u8))
                {
                    total = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("entityRecognitionTasks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TasksStateTasksEntityRecognitionTasksItem> array = new List<TasksStateTasksEntityRecognitionTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TasksStateTasksEntityRecognitionTasksItem.DeserializeTasksStateTasksEntityRecognitionTasksItem(item));
                    }
                    entityRecognitionTasks = array;
                    continue;
                }
                if (property.NameEquals("entityRecognitionPiiTasks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TasksStateTasksEntityRecognitionPiiTasksItem> array = new List<TasksStateTasksEntityRecognitionPiiTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TasksStateTasksEntityRecognitionPiiTasksItem.DeserializeTasksStateTasksEntityRecognitionPiiTasksItem(item));
                    }
                    entityRecognitionPiiTasks = array;
                    continue;
                }
                if (property.NameEquals("keyPhraseExtractionTasks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TasksStateTasksKeyPhraseExtractionTasksItem> array = new List<TasksStateTasksKeyPhraseExtractionTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TasksStateTasksKeyPhraseExtractionTasksItem.DeserializeTasksStateTasksKeyPhraseExtractionTasksItem(item));
                    }
                    keyPhraseExtractionTasks = array;
                    continue;
                }
                if (property.NameEquals("entityLinkingTasks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TasksStateTasksEntityLinkingTasksItem> array = new List<TasksStateTasksEntityLinkingTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TasksStateTasksEntityLinkingTasksItem.DeserializeTasksStateTasksEntityLinkingTasksItem(item));
                    }
                    entityLinkingTasks = array;
                    continue;
                }
                if (property.NameEquals("sentimentAnalysisTasks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TasksStateTasksSentimentAnalysisTasksItem> array = new List<TasksStateTasksSentimentAnalysisTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TasksStateTasksSentimentAnalysisTasksItem.DeserializeTasksStateTasksSentimentAnalysisTasksItem(item));
                    }
                    sentimentAnalysisTasks = array;
                    continue;
                }
            }
            return new TasksStateTasks(completed, failed, inProgress, total, Core.Optional.ToList(entityRecognitionTasks), Core.Optional.ToList(entityRecognitionPiiTasks), Core.Optional.ToList(keyPhraseExtractionTasks), Core.Optional.ToList(entityLinkingTasks), Core.Optional.ToList(sentimentAnalysisTasks));
        }
    }
}
