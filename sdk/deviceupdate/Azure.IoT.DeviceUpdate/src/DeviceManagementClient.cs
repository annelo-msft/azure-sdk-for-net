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
using Azure.IoT.DeviceUpdate.Models;

namespace Azure.IoT.DeviceUpdate
{
    public partial class DeviceManagementClient
    {
        /// <summary>
        /// </summary>
        /// <param name="waitUntil"></param>
        /// <param name="action"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<Operation> ImportDevicesAsync(WaitUntil waitUntil, ImportAction action, ImportType type, CancellationToken cancellationToken = default)
        {
            await Task.Delay(10, cancellationToken).ConfigureAwait(false);
            throw new NotImplementedException();
            //RequestContext requestContext =
            //return await this.ImportDevicesAsync(waitUntil, action.ToString(), type, new RequestContext { CancellationToken = cancellationToken }).ConfigureAwait(false);
        }

        /// <summary>
        /// </summary>
        /// <param name="waitUntil"></param>
        /// <param name="action"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Operation ImportDevices(WaitUntil waitUntil, ImportAction action, ImportType type, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
