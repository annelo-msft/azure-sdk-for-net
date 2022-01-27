﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using Azure.Core;
using OpenTelemetry.Logs;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    internal partial class TelemetryItem
    {
        private const string DateTimeFormat = "yyyy-MM-ddTHH:mm:ss.fffffffZ";
        private static readonly IReadOnlyDictionary<TelemetryType, string> PartA_Name_Mapping = new Dictionary<TelemetryType, string>
        {
            [TelemetryType.Request] = "Request",
            [TelemetryType.Dependency] = "RemoteDependency",
            [TelemetryType.Message] = "Message",
            [TelemetryType.Event] = "Event",
        };

        public TelemetryItem(Activity activity, ref TagEnumerationState monitorTags)
        {
            this.Name = PartA_Name_Mapping[activity.GetTelemetryType()];
            this.Time = FormatUtcTimestamp(activity.StartTimeUtc);
            this.Tags = new ChangeTrackingDictionary<string, string>();

            if (activity.ParentSpanId != default)
            {
                this.Tags[ContextTagKeys.AiOperationParentId.ToString()] = activity.ParentSpanId.ToHexString();
            }

            this.Tags[ContextTagKeys.AiOperationId.ToString()] = activity.TraceId.ToHexString();
            // todo: update swagger to include this key.
            this.Tags["ai.user.userAgent"] = AzMonList.GetTagValue(ref monitorTags.PartBTags, SemanticConventions.AttributeHttpUserAgent)?.ToString();

            // we only have mapping for server spans
            // todo: non-server spans
            if (activity.Kind == ActivityKind.Server)
            {
                this.Tags[ContextTagKeys.AiOperationName.ToString()] = GetOperationName(activity, ref monitorTags.PartBTags);
                this.Tags[ContextTagKeys.AiLocationIp.ToString()] = GetLocationIp(ref monitorTags.PartBTags);
            }

            this.Tags[ContextTagKeys.AiInternalSdkVersion.ToString()] = SdkVersionUtils.SdkVersion;
        }

        public TelemetryItem (LogRecord logRecord)
        {
            this.Name = PartA_Name_Mapping[TelemetryType.Message];
            this.Time = FormatUtcTimestamp(logRecord.Timestamp);
            this.Tags = new ChangeTrackingDictionary<string, string>();

            if (logRecord.TraceId != default)
            {
                this.Tags[ContextTagKeys.AiOperationId.ToString()] = logRecord.TraceId.ToHexString();
            }

            if (logRecord.SpanId != default)
            {
                this.Tags[ContextTagKeys.AiOperationParentId.ToString()] = logRecord.SpanId.ToHexString();
            }

            this.Tags[ContextTagKeys.AiInternalSdkVersion.ToString()] = SdkVersionUtils.SdkVersion;
        }

        internal void SetResource(string roleName, string roleInstance)
        {
            Tags[ContextTagKeys.AiCloudRole.ToString()] = roleName;
            Tags[ContextTagKeys.AiCloudRoleInstance.ToString()] = roleInstance;
        }

        internal static string GetOperationName(Activity activity, ref AzMonList partBTags)
        {
            var httpMethod = AzMonList.GetTagValue(ref partBTags, SemanticConventions.AttributeHttpMethod)?.ToString();
            if (!string.IsNullOrWhiteSpace(httpMethod))
            {
                var httpRoute = AzMonList.GetTagValue(ref partBTags, SemanticConventions.AttributeHttpRoute)?.ToString();
                // ASP.NET instrumentation assigns route as {controller}/{action}/{id} which would result in the same name for different operations.
                // To work around that we will use path from httpUrl.
                if (!string.IsNullOrWhiteSpace(httpRoute) && !httpRoute.Contains("{controller}"))
                {
                    return $"{httpMethod} {httpRoute}";
                }
                var httpUrl = AzMonList.GetTagValue(ref partBTags, SemanticConventions.AttributeHttpUrl)?.ToString();
                if (!string.IsNullOrWhiteSpace(httpUrl) && Uri.TryCreate(httpUrl.ToString(), UriKind.RelativeOrAbsolute, out var uri) && uri.IsAbsoluteUri)
                {
                    return $"{httpMethod} {uri.AbsolutePath}";
                }
            }

            return activity.DisplayName;
        }

        private static string GetLocationIp(ref AzMonList partBTags)
        {
            var httpClientIp = AzMonList.GetTagValue(ref partBTags, SemanticConventions.AttributeHttpClientIP)?.ToString();
            if (!string.IsNullOrWhiteSpace(httpClientIp))
            {
                return httpClientIp;
            }

            return AzMonList.GetTagValue(ref partBTags, SemanticConventions.AttributeNetPeerIp)?.ToString();
        }

        internal static string FormatUtcTimestamp(System.DateTime utcTimestamp)
        {
            return utcTimestamp.ToString(DateTimeFormat, CultureInfo.InvariantCulture);
        }
    }
}
