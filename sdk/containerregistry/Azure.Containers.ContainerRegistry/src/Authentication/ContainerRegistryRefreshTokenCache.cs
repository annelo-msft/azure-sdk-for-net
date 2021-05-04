// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

#nullable enable

namespace Azure.Containers.ContainerRegistry
{
    internal class ContainerRegistryRefreshTokenCache
    {
        private readonly TimeSpan DefaultTokenRefreshOffset = TimeSpan.FromMinutes(5);
        private readonly TimeSpan DefaultTokenRefreshRetryDelay = TimeSpan.FromSeconds(30);
        private readonly TimeSpan DefaultTokenExpiryOffset = TimeSpan.FromHours(2);

        private readonly object _syncObj = new object();

        private readonly TokenCredential _aadTokenCredential;
        private readonly TimeSpan _tokenRefreshOffset;
        private readonly TimeSpan _tokenRefreshRetryDelay;
        private readonly TimeSpan _tokenExpiryOffset;
        private readonly IContainerRegistryAuthenticationClient _authenticationRestClient;

        private ValueTask<RefreshTokenInfo>? _tokenLookupTask;

        public ContainerRegistryRefreshTokenCache(TokenCredential aadTokenCredential, IContainerRegistryAuthenticationClient authClient, TimeSpan? tokenRefreshOffset = null, TimeSpan? tokenRefreshRetryDelay = null, TimeSpan? tokenExpiryOffset = null)
        {
            _aadTokenCredential = aadTokenCredential;
            _authenticationRestClient = authClient;

            _tokenRefreshOffset = tokenRefreshOffset ?? DefaultTokenRefreshOffset;
            _tokenRefreshRetryDelay = tokenRefreshRetryDelay ?? DefaultTokenRefreshRetryDelay;
            _tokenExpiryOffset = tokenExpiryOffset ?? DefaultTokenExpiryOffset;
        }

        public async ValueTask<string> GetAcrRefreshTokenAsync(TokenRequestContext context, string service, bool async, CancellationToken cancellationToken)
        {
            lock (_syncObj)
            {
                if (_tokenLookupTask == null || _tokenLookupTask.Value. TokenNeedsRefresh(service))
                {
                    _tokenLookupTask = GetRefreshTokenFromCredentialAsync(context, service, async, cancellationToken);
                }
            }

            return async ? (await _tokenLookupTask.Value.ConfigureAwait(false)).Token.RefreshToken : _tokenLookupTask.Value.Result.Token.RefreshToken;
        }

        private bool TokenNeedsRefresh(string service)
        {
            DateTimeOffset now = DateTimeOffset.UtcNow;

            return _tokenLookupTask == null ||
               _cachedToken.Value.HasExpired(now) ||
               _cachedToken.Value.WillExpireSoon(now) ||
               RequestRequiresNewToken(service);
        }

        private bool RequestRequiresNewToken(string service) =>
            _cachedToken == null ||
            (service != null && !string.Equals(service, _cachedToken.Value.Service));

        private async ValueTask<RefreshTokenInfo> GetRefreshTokenFromCredentialAsync(TokenRequestContext context, string service, bool async, CancellationToken cancellationToken)
        {
            AccessToken aadAccessToken = async ? await _aadTokenCredential.GetTokenAsync(context, cancellationToken).ConfigureAwait(false) :
                _aadTokenCredential.GetToken(context, cancellationToken);

            AcrRefreshToken acrRefreshToken = async ? await _authenticationRestClient.ExchangeAadAccessTokenForAcrRefreshTokenAsync(service, aadAccessToken.Token, cancellationToken).ConfigureAwait(false) :
                _authenticationRestClient.ExchangeAadAccessTokenForAcrRefreshToken(service, aadAccessToken.Token, cancellationToken);

            DateTime expiresOn = DateTime.UtcNow + _tokenExpiryOffset;
            DateTime refreshOn = expiresOn - _tokenRefreshOffset;

            return new RefreshTokenInfo(acrRefreshToken, service, expiresOn, refreshOn);
        }

        private readonly struct RefreshTokenInfo
        {
            public AcrRefreshToken Token { get; }
            public string Service { get; }
            private readonly DateTimeOffset _expiresOn;
            private readonly DateTimeOffset _refreshOn;

            public RefreshTokenInfo(AcrRefreshToken refreshToken, string service, DateTimeOffset expiresOn, DateTimeOffset refreshOn)
            {
                Token = refreshToken;
                Service = service;
                _expiresOn = expiresOn;
                _refreshOn = refreshOn;
            }

            public bool HasExpired(DateTimeOffset now)
            {
                return now > _expiresOn;
            }

            public bool WillExpireSoon(DateTimeOffset now)
            {
                return now >= _refreshOn;
            }
        }
    }
}
