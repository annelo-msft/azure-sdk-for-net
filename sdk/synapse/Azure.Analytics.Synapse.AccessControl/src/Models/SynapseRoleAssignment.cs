﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;

namespace Azure.Analytics.Synapse.AccessControl
{
    public class SynapseRoleAssignment
    {
        public SynapseRoleAssignment(Guid roleId, Guid principalId, string scope, SynapsePrincipalType? principalType = null)
        {
            Id = roleId;
            Properties = new SynapseRoleAssignmentProperties(
                principalId,
                scope,
                principalType);

            // TODO: Why aren't name and type available? (Where they are available in ARM + KV APIs)
            //Name = name;
            //Type = type;
        }

        internal SynapseRoleAssignment(Guid roleId, Guid principalId, Guid roleDefinitionId, string scope, SynapsePrincipalType? principalType = null)
        {
            Id = roleId;
            Properties = new SynapseRoleAssignmentProperties(
                principalId,
                roleDefinitionId,
                scope,
                principalType);
        }

        public Guid Id { get; }

        public SynapseRoleAssignmentProperties Properties { get; }

        public static implicit operator RequestContent(SynapseRoleAssignment value) => RequestContent.Create(
            new
            {
                Id = value.Id,
                Properties = value.Properties
            });

        public static implicit operator SynapseRoleAssignment(Response response)
        {
            response.ThrowIfError();  // What about async?
            return DeserializeResponse(response);
        }

        private static SynapseRoleAssignment DeserializeResponse(Response response)
        {
            throw new NotImplementedException();
        }
    }
}
