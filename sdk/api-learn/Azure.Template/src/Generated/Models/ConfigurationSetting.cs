// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Learn.AppConfig.Models
{
    /// <summary> The KeyValue. </summary>
    public partial class ConfigurationSetting
    {
        /// <summary> Initializes a new instance of ConfigurationSetting. </summary>
        internal ConfigurationSetting()
        {
        }

        /// <summary> Initializes a new instance of ConfigurationSetting. </summary>
        /// <param name="key"> The unique id of the key-value. </param>
        /// <param name="contentType"> The content type of the value. </param>
        /// <param name="value"> The value of the key-value. </param>
        /// <param name="lastModified"> The time the key-value was last modified. </param>
        internal ConfigurationSetting(string key, string contentType, string value, DateTimeOffset? lastModified)
        {
            Key = key;
            ContentType = contentType;
            Value = value;
            LastModified = lastModified;
        }

        /// <summary> The unique id of the key-value. </summary>
        public string Key { get; }
        /// <summary> The content type of the value. </summary>
        public string ContentType { get; }
        /// <summary> The value of the key-value. </summary>
        public string Value { get; }
        /// <summary> The time the key-value was last modified. </summary>
        public DateTimeOffset? LastModified { get; }
    }
}
