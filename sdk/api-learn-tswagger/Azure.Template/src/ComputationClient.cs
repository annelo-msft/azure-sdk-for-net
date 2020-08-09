// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core;

namespace Azure.Learn.TrainingService
{
    public class ComputationClient
    {
        public ComputationClient(Uri endpoint, TokenCredential credential)
        {
        }

        public ComputationClient(Uri endpoint, TokenCredential credential, ComputationClientOptions options)
        {
        }

        protected ComputationClient()
        {
        }
    }
}
