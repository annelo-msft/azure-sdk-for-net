// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Learn.AppConfig
{
    /// <summary>
    /// The Configuration Client
    /// </summary>
    public class ConfigurationClient
    {
        private ServiceRestClient _serviceRestClient = null;
        private ClientDiagnostics _clientDiagnostics = null;

        /// <summary>Initializes a new instance of the <see cref="ConfigurationClient"/>.</summary>
        public ConfigurationClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new ConfigurationClientOptions())
        {
        }

        /// <summary>Initializes a new instance of the <see cref="ConfigurationClient"/>.</summary>
        public ConfigurationClient(Uri endpoint, TokenCredential credential, ConfigurationClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            Argument.AssertNotNull(options, nameof(options));

            options ??= new ConfigurationClientOptions();

            string scope = $"{endpoint.AbsoluteUri}.default";

            _clientDiagnostics = new ClientDiagnostics(options);
            var pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scope));
            _serviceRestClient = new ServiceRestClient(_clientDiagnostics, pipeline, endpoint.AbsoluteUri);
        }

        /// <summary> Initializes a new instance of ConfigurationClient for mocking. </summary>
        protected ConfigurationClient()
        {
        }

        /// <summary>Retrieve a <see cref="ConfigurationSetting"/> from the configuration store.</summary>
        public virtual Response<ConfigurationSetting> GetConfigurationSetting(string key, string label = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(ConfigurationClient)}.{nameof(GetConfigurationSetting)}");
            scope.Start();
            try
            {
                ResponseWithHeaders<ConfigurationSetting, ServiceGetKeyValueHeaders> responseWithHeaders = _serviceRestClient.GetKeyValue(key, label, acceptDatetime: null, ifMatch: null, ifNoneMatch: null, select: null, cancellationToken);
                return Response.FromValue(responseWithHeaders.Value, responseWithHeaders.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>Retrieve a <see cref="ConfigurationSetting"/> from the configuration store.</summary>
        public virtual async Task<Response<ConfigurationSetting>> GetConfigurationSettingAsync(string key, string label = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(ConfigurationClient)}.{nameof(GetConfigurationSetting)}");
            scope.Start();
            try
            {
                ResponseWithHeaders<ConfigurationSetting, ServiceGetKeyValueHeaders> responseWithHeaders = await _serviceRestClient.GetKeyValueAsync(key, label, acceptDatetime: null, ifMatch: null, ifNoneMatch: null, select: null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(responseWithHeaders.Value, responseWithHeaders.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>Conditionally retrieve a <see cref="ConfigurationSetting"/> from the configuration store if the setting has been changed since it was last retrieved.</summary>
        public virtual Response<ConfigurationSetting> GetConfigurationSetting(ConfigurationSetting setting, bool onlyIfChanged = false, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(setting, nameof(setting));

            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(ConfigurationClient)}.{nameof(GetConfigurationSetting)}");
            scope.Start();
            try
            {
                ResponseWithHeaders<ConfigurationSetting, ServiceGetKeyValueHeaders> responseWithHeaders = _serviceRestClient.GetKeyValue(setting.Key, setting.Label, acceptDatetime: null, ifMatch: null, ifNoneMatch: $"\"{setting.ETag.ToString()}\"", select: null, cancellationToken);
                return Response.FromValue(responseWithHeaders.Value, responseWithHeaders.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>Conditionally retrieve a <see cref="ConfigurationSetting"/> from the configuration store if the setting has been changed since it was last retrieved.</summary>
        public virtual async Task<Response<ConfigurationSetting>> GetConfigurationSettingAsync(ConfigurationSetting setting, bool onlyIfChanged = false, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(setting, nameof(setting));

            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(ConfigurationClient)}.{nameof(GetConfigurationSetting)}");
            scope.Start();
            try
            {
                ResponseWithHeaders<ConfigurationSetting, ServiceGetKeyValueHeaders> responseWithHeaders = await _serviceRestClient.GetKeyValueAsync(setting.Key, setting.Label, acceptDatetime: null, ifMatch: null, ifNoneMatch: $"\"{setting.ETag.ToString()}\"", select: null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(responseWithHeaders.Value, responseWithHeaders.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }
    }
}
