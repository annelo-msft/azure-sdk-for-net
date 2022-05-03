// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using System.Text;

namespace Azure.IoT.DeviceUpdate
{
    public partial class DeviceUpdateClient
    {
        /// <summary>
        /// </summary>
        /// <param name="waitUntil"></param>
        /// <param name="provider"></param>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public virtual async Task<Operation> DeleteUpdateValueAsync(WaitUntil waitUntil, string provider, string name, string version, CancellationToken cancellationToken = default)
        {
            // TODO: do this without an allocation
            var context = new RequestContext()
            {
                CancellationToken = cancellationToken
            };

            return await this.DeleteUpdateAsync(waitUntil, provider, name, version, context).ConfigureAwait(false);
        }

        /// <summary>
        /// </summary>
        /// <param name="waitUntil"></param>
        /// <param name="provider"></param>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public virtual Operation DeleteUpdateValue(WaitUntil waitUntil, string provider, string name, string version, CancellationToken cancellationToken = default)
        {
            var context = new RequestContext()
            {
                CancellationToken = cancellationToken
            };

            return this.DeleteUpdate(waitUntil, provider, name, version, context);
        }
    }
}
