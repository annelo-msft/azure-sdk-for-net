// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Queues.Models
{
    public partial class QueueServiceProperties : Core.IXmlSerializable
    {
        void Core.IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "StorageServiceProperties");
            if (Core.Optional.IsDefined(Logging))
            {
                writer.WriteObjectValue(Logging, "Logging");
            }
            if (Core.Optional.IsDefined(HourMetrics))
            {
                writer.WriteObjectValue(HourMetrics, "HourMetrics");
            }
            if (Core.Optional.IsDefined(MinuteMetrics))
            {
                writer.WriteObjectValue(MinuteMetrics, "MinuteMetrics");
            }
            if (Core.Optional.IsCollectionDefined(Cors))
            {
                writer.WriteStartElement("Cors");
                foreach (var item in Cors)
                {
                    writer.WriteObjectValue(item, "CorsRule");
                }
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        internal static QueueServiceProperties DeserializeQueueServiceProperties(XElement element)
        {
            QueueAnalyticsLogging logging = default;
            QueueMetrics hourMetrics = default;
            QueueMetrics minuteMetrics = default;
            IList<QueueCorsRule> cors = default;
            if (element.Element("Logging") is XElement loggingElement)
            {
                logging = QueueAnalyticsLogging.DeserializeQueueAnalyticsLogging(loggingElement);
            }
            if (element.Element("HourMetrics") is XElement hourMetricsElement)
            {
                hourMetrics = QueueMetrics.DeserializeQueueMetrics(hourMetricsElement);
            }
            if (element.Element("MinuteMetrics") is XElement minuteMetricsElement)
            {
                minuteMetrics = QueueMetrics.DeserializeQueueMetrics(minuteMetricsElement);
            }
            if (element.Element("Cors") is XElement corsElement)
            {
                var array = new List<QueueCorsRule>();
                foreach (var e in corsElement.Elements("CorsRule"))
                {
                    array.Add(QueueCorsRule.DeserializeQueueCorsRule(e));
                }
                cors = array;
            }
            return new QueueServiceProperties(logging, hourMetrics, minuteMetrics, cors);
        }
    }
}
