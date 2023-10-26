// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net.ClientModel.Core;
using System.Net.ClientModel.Internal;
using System.Text.Json;
using System.Buffers;

namespace OpenAI;

public partial class CompletionsOptions : IUtf8JsonContentWriteable
{
    void IUtf8JsonContentWriteable.Write(Utf8JsonWriter writer)
    {
        writer.WriteStartObject();
        writer.WritePropertyName("prompt"u8);
        writer.WriteStartArray();
        foreach (var item in Prompts)
        {
            writer.WriteStringValue(item);
        }
        writer.WriteEndArray();
        if (OptionalProperty.IsDefined(MaxTokens))
        {
            writer.WritePropertyName("max_tokens"u8);
            writer.WriteNumberValue(MaxTokens.Value);
        }
        if (OptionalProperty.IsDefined(Temperature))
        {
            writer.WritePropertyName("temperature"u8);
            writer.WriteNumberValue(Temperature.Value);
        }
        if (OptionalProperty.IsDefined(NucleusSamplingFactor))
        {
            writer.WritePropertyName("top_p"u8);
            writer.WriteNumberValue(NucleusSamplingFactor.Value);
        }
        if (OptionalProperty.IsCollectionDefined(InternalStringKeyedTokenSelectionBiases))
        {
            writer.WritePropertyName("logit_bias"u8);
            writer.WriteStartObject();
            foreach (var item in InternalStringKeyedTokenSelectionBiases)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteNumberValue(item.Value);
            }
            writer.WriteEndObject();
        }
        if (OptionalProperty.IsDefined(User))
        {
            writer.WritePropertyName("user"u8);
            writer.WriteStringValue(User);
        }
        if (OptionalProperty.IsDefined(ChoicesPerPrompt))
        {
            writer.WritePropertyName("n"u8);
            writer.WriteNumberValue(ChoicesPerPrompt.Value);
        }
        if (OptionalProperty.IsDefined(LogProbabilityCount))
        {
            writer.WritePropertyName("logprobs"u8);
            writer.WriteNumberValue(LogProbabilityCount.Value);
        }
        if (OptionalProperty.IsDefined(Echo))
        {
            writer.WritePropertyName("echo"u8);
            writer.WriteBooleanValue(Echo.Value);
        }
        if (OptionalProperty.IsCollectionDefined(StopSequences))
        {
            writer.WritePropertyName("stop"u8);
            writer.WriteStartArray();
            foreach (var item in StopSequences)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
        }
        if (OptionalProperty.IsDefined(PresencePenalty))
        {
            writer.WritePropertyName("presence_penalty"u8);
            writer.WriteNumberValue(PresencePenalty.Value);
        }
        if (OptionalProperty.IsDefined(FrequencyPenalty))
        {
            writer.WritePropertyName("frequency_penalty"u8);
            writer.WriteNumberValue(FrequencyPenalty.Value);
        }
        if (OptionalProperty.IsDefined(GenerationSampleCount))
        {
            writer.WritePropertyName("best_of"u8);
            writer.WriteNumberValue(GenerationSampleCount.Value);
        }
        if (OptionalProperty.IsDefined(InternalShouldStreamResponse))
        {
            writer.WritePropertyName("stream"u8);
            writer.WriteBooleanValue(InternalShouldStreamResponse.Value);
        }
        if (OptionalProperty.IsDefined(InternalNonAzureModelName))
        {
            writer.WritePropertyName("model"u8);
            writer.WriteStringValue(InternalNonAzureModelName);
        }
        writer.WriteEndObject();
    }

    /// <summary> Convert to a message content that can be used on a request. </summary>
    internal virtual MessageBody ToRequestContent()
    {
        // Note this method goes away and turns into implicit cast.

        using Utf8JsonContentWriter writer = new();
        writer.Write(this);
        return MessageBody.CreateContent(writer.WrittenContent);
    }
}
