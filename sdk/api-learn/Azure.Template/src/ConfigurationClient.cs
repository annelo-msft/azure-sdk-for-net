// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Learn.AppConfig.Models;

namespace Azure.Learn.AppConfig
{
    public class ConfigurationClient
    {
        protected ConfigurationClient()
        {
        }

        public ConfigurationClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new ConfigurationClientOptions())
        {
        }

#pragma warning disable CA1801
        public ConfigurationClient(Uri endpoint, TokenCredential credential, ConfigurationClientOptions options)
        {
        }
#pragma warning restore CA1801

        public virtual Response<KeyValue> GetKeyValue(string key, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<Response<KeyValue>> GetKeyValueAsync(string key, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => {}).ConfigureAwait(false);
            throw new NotImplementedException();
        }
    }
}
