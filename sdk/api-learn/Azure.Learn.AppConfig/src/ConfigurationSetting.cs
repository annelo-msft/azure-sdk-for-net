// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;

namespace Azure.Learn.AppConfig
{
    [CodeGenModel("KeyValue")]
    public partial class ConfigurationSetting
    {
        /// <summary>
        /// The setting's ETag
        /// </summary>
        [CodeGenMember("Etag")]
        public ETag ETag { get; }
    }
}
