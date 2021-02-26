// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Containers.ContainerRegistry
{
    public class ContainerRegistryUserCredential
    {
        public ContainerRegistryUserCredential(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }

        internal string UserName { get; }

        internal string Password { get; private set; }

        public void Update(string password)
        {
            Password = password;
        }
    }
}
