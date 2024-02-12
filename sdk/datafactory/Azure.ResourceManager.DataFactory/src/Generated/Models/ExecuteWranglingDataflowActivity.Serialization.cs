// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class ExecuteWranglingDataflowActivity : IUtf8JsonSerializable, IJsonModel<ExecuteWranglingDataflowActivity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExecuteWranglingDataflowActivity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExecuteWranglingDataflowActivity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecuteWranglingDataflowActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExecuteWranglingDataflowActivity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Policy))
            {
                writer.WritePropertyName("policy"u8);
                writer.WriteObjectValue(Policy);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ActivityType);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(OnInactiveMarkAs))
            {
                writer.WritePropertyName("onInactiveMarkAs"u8);
                writer.WriteStringValue(OnInactiveMarkAs.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn"u8);
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UserProperties))
            {
                writer.WritePropertyName("userProperties"u8);
                writer.WriteStartArray();
                foreach (var item in UserProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("dataFlow"u8);
            writer.WriteObjectValue(DataFlow);
            if (Optional.IsDefined(Staging))
            {
                writer.WritePropertyName("staging"u8);
                writer.WriteObjectValue(Staging);
            }
            if (Optional.IsDefined(IntegrationRuntime))
            {
                writer.WritePropertyName("integrationRuntime"u8);
                writer.WriteObjectValue(IntegrationRuntime);
            }
            if (Optional.IsDefined(Compute))
            {
                writer.WritePropertyName("compute"u8);
                writer.WriteObjectValue(Compute);
            }
            if (Optional.IsDefined(TraceLevel))
            {
                writer.WritePropertyName("traceLevel"u8);
                JsonSerializer.Serialize(writer, TraceLevel);
            }
            if (Optional.IsDefined(ContinueOnError))
            {
                writer.WritePropertyName("continueOnError"u8);
                JsonSerializer.Serialize(writer, ContinueOnError);
            }
            if (Optional.IsDefined(RunConcurrently))
            {
                writer.WritePropertyName("runConcurrently"u8);
                JsonSerializer.Serialize(writer, RunConcurrently);
            }
            if (Optional.IsDefined(SourceStagingConcurrency))
            {
                writer.WritePropertyName("sourceStagingConcurrency"u8);
                JsonSerializer.Serialize(writer, SourceStagingConcurrency);
            }
            if (Optional.IsCollectionDefined(Sinks))
            {
                writer.WritePropertyName("sinks"u8);
                writer.WriteStartObject();
                foreach (var item in Sinks)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Queries))
            {
                writer.WritePropertyName("queries"u8);
                writer.WriteStartArray();
                foreach (var item in Queries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndObject();
        }

        ExecuteWranglingDataflowActivity IJsonModel<ExecuteWranglingDataflowActivity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecuteWranglingDataflowActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExecuteWranglingDataflowActivity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExecuteWranglingDataflowActivity(document.RootElement, options);
        }

        internal static ExecuteWranglingDataflowActivity DeserializeExecuteWranglingDataflowActivity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PipelineActivityPolicy> policy = default;
            string name = default;
            string type = default;
            Optional<string> description = default;
            Optional<PipelineActivityState> state = default;
            Optional<ActivityOnInactiveMarkAs> onInactiveMarkAs = default;
            Optional<IList<PipelineActivityDependency>> dependsOn = default;
            Optional<IList<PipelineActivityUserProperty>> userProperties = default;
            DataFlowReference dataFlow = default;
            Optional<DataFlowStagingInfo> staging = default;
            Optional<IntegrationRuntimeReference> integrationRuntime = default;
            Optional<ExecuteDataFlowActivityComputeType> compute = default;
            Optional<DataFactoryElement<string>> traceLevel = default;
            Optional<DataFactoryElement<bool>> continueOnError = default;
            Optional<DataFactoryElement<bool>> runConcurrently = default;
            Optional<DataFactoryElement<int>> sourceStagingConcurrency = default;
            Optional<IDictionary<string, PowerQuerySink>> sinks = default;
            Optional<IList<PowerQuerySinkMapping>> queries = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policy = PipelineActivityPolicy.DeserializePipelineActivityPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new PipelineActivityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("onInactiveMarkAs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onInactiveMarkAs = new ActivityOnInactiveMarkAs(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dependsOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PipelineActivityDependency> array = new List<PipelineActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PipelineActivityDependency.DeserializePipelineActivityDependency(item));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PipelineActivityUserProperty> array = new List<PipelineActivityUserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PipelineActivityUserProperty.DeserializePipelineActivityUserProperty(item));
                    }
                    userProperties = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("dataFlow"u8))
                        {
                            dataFlow = DataFlowReference.DeserializeDataFlowReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("staging"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            staging = DataFlowStagingInfo.DeserializeDataFlowStagingInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("integrationRuntime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            integrationRuntime = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("compute"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            compute = ExecuteDataFlowActivityComputeType.DeserializeExecuteDataFlowActivityComputeType(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("traceLevel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            traceLevel = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("continueOnError"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            continueOnError = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("runConcurrently"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            runConcurrently = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("sourceStagingConcurrency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceStagingConcurrency = JsonSerializer.Deserialize<DataFactoryElement<int>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("sinks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, PowerQuerySink> dictionary = new Dictionary<string, PowerQuerySink>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, PowerQuerySink.DeserializePowerQuerySink(property1.Value));
                            }
                            sinks = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("queries"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PowerQuerySinkMapping> array = new List<PowerQuerySinkMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PowerQuerySinkMapping.DeserializePowerQuerySinkMapping(item));
                            }
                            queries = array;
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ExecuteWranglingDataflowActivity(name, type, description.Value, Optional.ToNullable(state), Optional.ToNullable(onInactiveMarkAs), Optional.ToList(dependsOn), Optional.ToList(userProperties), additionalProperties, policy.Value, dataFlow, staging.Value, integrationRuntime.Value, compute.Value, traceLevel.Value, continueOnError.Value, runConcurrently.Value, sourceStagingConcurrency.Value, Optional.ToDictionary(sinks), Optional.ToList(queries));
        }

        BinaryData IPersistableModel<ExecuteWranglingDataflowActivity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecuteWranglingDataflowActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExecuteWranglingDataflowActivity)} does not support '{options.Format}' format.");
            }
        }

        ExecuteWranglingDataflowActivity IPersistableModel<ExecuteWranglingDataflowActivity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecuteWranglingDataflowActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExecuteWranglingDataflowActivity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExecuteWranglingDataflowActivity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExecuteWranglingDataflowActivity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
