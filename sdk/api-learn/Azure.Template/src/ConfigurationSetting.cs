// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;

namespace Azure.Learn.AppConfig.Models
{
    [CodeGenModel("KeyValue")]
    public partial class ConfigurationSetting
    {
        /// <summary>Initializes a new instance of the <see cref="ConfigurationClient"/>.</summary>
        /// <param name="key">The unique id of the key-value.</param>
        public ConfigurationSetting(string key)
        {
            Key = key;
        }

        /// <summary> The content type of the value. </summary>
        public string ContentType { get; set; }
        /// <summary> The value of the key-value. </summary>
        public string Value { get; set; }
    }
}
