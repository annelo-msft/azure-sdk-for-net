// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(DynamicsCrmLinkedServiceConverter))]
    public partial class DynamicsCrmLinkedService : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Core.Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue(ConnectVia);
            }
            if (Core.Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Core.Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Core.Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("deploymentType"u8);
            writer.WriteObjectValue(DeploymentType);
            if (Core.Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteObjectValue(HostName);
            }
            if (Core.Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteObjectValue(Port);
            }
            if (Core.Optional.IsDefined(ServiceUri))
            {
                writer.WritePropertyName("serviceUri"u8);
                writer.WriteObjectValue(ServiceUri);
            }
            if (Core.Optional.IsDefined(OrganizationName))
            {
                writer.WritePropertyName("organizationName"u8);
                writer.WriteObjectValue(OrganizationName);
            }
            writer.WritePropertyName("authenticationType"u8);
            writer.WriteObjectValue(AuthenticationType);
            if (Core.Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username"u8);
                writer.WriteObjectValue(Username);
            }
            if (Core.Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteObjectValue(Password);
            }
            if (Core.Optional.IsDefined(ServicePrincipalId))
            {
                writer.WritePropertyName("servicePrincipalId"u8);
                writer.WriteObjectValue(ServicePrincipalId);
            }
            if (Core.Optional.IsDefined(ServicePrincipalCredentialType))
            {
                writer.WritePropertyName("servicePrincipalCredentialType"u8);
                writer.WriteObjectValue(ServicePrincipalCredentialType);
            }
            if (Core.Optional.IsDefined(ServicePrincipalCredential))
            {
                writer.WritePropertyName("servicePrincipalCredential"u8);
                writer.WriteObjectValue(ServicePrincipalCredential);
            }
            if (Core.Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteObjectValue(EncryptedCredential);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static DynamicsCrmLinkedService DeserializeDynamicsCrmLinkedService(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Core.Optional<IntegrationRuntimeReference> connectVia = default;
            Core.Optional<string> description = default;
            Core.Optional<IDictionary<string, ParameterSpecification>> parameters = default;
            Core.Optional<IList<object>> annotations = default;
            object deploymentType = default;
            Core.Optional<object> hostName = default;
            Core.Optional<object> port = default;
            Core.Optional<object> serviceUri = default;
            Core.Optional<object> organizationName = default;
            object authenticationType = default;
            Core.Optional<object> username = default;
            Core.Optional<SecretBase> password = default;
            Core.Optional<object> servicePrincipalId = default;
            Core.Optional<object> servicePrincipalCredentialType = default;
            Core.Optional<SecretBase> servicePrincipalCredential = default;
            Core.Optional<object> encryptedCredential = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetObject());
                        }
                    }
                    annotations = array;
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
                        if (property0.NameEquals("deploymentType"u8))
                        {
                            deploymentType = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("hostName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("port"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            port = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("serviceUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceUri = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("organizationName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            organizationName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("authenticationType"u8))
                        {
                            authenticationType = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("username"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            username = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("password"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            password = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalCredentialType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalCredentialType = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalCredential = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptedCredential = property0.Value.GetObject();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DynamicsCrmLinkedService(type, connectVia.Value, description.Value, Core.Optional.ToDictionary(parameters), Core.Optional.ToList(annotations), additionalProperties, deploymentType, hostName.Value, port.Value, serviceUri.Value, organizationName.Value, authenticationType, username.Value, password.Value, servicePrincipalId.Value, servicePrincipalCredentialType.Value, servicePrincipalCredential.Value, encryptedCredential.Value);
        }

        internal partial class DynamicsCrmLinkedServiceConverter : JsonConverter<DynamicsCrmLinkedService>
        {
            public override void Write(Utf8JsonWriter writer, DynamicsCrmLinkedService model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DynamicsCrmLinkedService Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDynamicsCrmLinkedService(document.RootElement);
            }
        }
    }
}
