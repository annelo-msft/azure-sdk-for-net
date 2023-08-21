// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Files.Shares.Models
{
    public partial class ShareAccessPolicy : Core.IXmlSerializable
    {
        void Core.IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "AccessPolicy");
            if (Core.Optional.IsDefined(PolicyStartsOn))
            {
                writer.WriteStartElement("Start");
                writer.WriteValue(PolicyStartsOn.Value, "O");
                writer.WriteEndElement();
            }
            if (Core.Optional.IsDefined(PolicyExpiresOn))
            {
                writer.WriteStartElement("Expiry");
                writer.WriteValue(PolicyExpiresOn.Value, "O");
                writer.WriteEndElement();
            }
            if (Core.Optional.IsDefined(Permissions))
            {
                writer.WriteStartElement("Permission");
                writer.WriteValue(Permissions);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        internal static ShareAccessPolicy DeserializeShareAccessPolicy(XElement element)
        {
            DateTimeOffset? policyStartsOn = default;
            DateTimeOffset? policyExpiresOn = default;
            string permissions = default;
            if (element.Element("Start") is XElement startElement)
            {
                policyStartsOn = startElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("Expiry") is XElement expiryElement)
            {
                policyExpiresOn = expiryElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("Permission") is XElement permissionElement)
            {
                permissions = (string)permissionElement;
            }
            return new ShareAccessPolicy(policyStartsOn, policyExpiresOn, permissions);
        }
    }
}
