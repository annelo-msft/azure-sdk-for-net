// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class to add extension methods to Tenant. </summary>
    public static partial class TenantExtensions
    {
        private static TenantExtensionClient GetExtensionClient(Tenant tenant)
        {
            return tenant.GetCachedClient((armClient) =>
            {
                return new TenantExtensionClient(armClient, tenant.Id);
            }
            );
        }

        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="System.ArgumentException"> <paramref name="accountName"/> is empty. </exception>
        /// <exception cref="System.ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public static async Task<Response<bool>> CheckNameExistsDatabaseAccountAsync(this Tenant tenant, string accountName, CancellationToken cancellationToken = default)
        {
            return await GetExtensionClient(tenant).CheckNameExistsDatabaseAccountAsync(accountName, cancellationToken).ConfigureAwait(false);
        }

        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="System.ArgumentException"> <paramref name="accountName"/> is empty. </exception>
        /// <exception cref="System.ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public static Response<bool> CheckNameExistsDatabaseAccount(this Tenant tenant, string accountName, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(tenant).CheckNameExistsDatabaseAccount(accountName, cancellationToken);
        }
    }
}
