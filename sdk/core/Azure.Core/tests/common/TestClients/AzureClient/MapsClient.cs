// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ClientModel.Primitives;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Maps;

public class MapsClient
{
    private readonly Uri _endpoint;
    private readonly AzureKeyCredential _credential;
    private readonly ClientPipeline _scmPipeline;
    private readonly string _apiVersion;

    public MapsClient(Uri endpoint, AzureKeyCredential credential, MapsClientOptions options = default)
    {
        if (endpoint is null)
            throw new ArgumentNullException(nameof(endpoint));
        if (credential is null)
            throw new ArgumentNullException(nameof(credential));

        options ??= new MapsClientOptions();

        _endpoint = endpoint;
        _credential = credential;
        _apiVersion = options.Version;

        AzureKeyCredentialPolicy azureAuthPolicy = new(_credential, "subscription-key");
        PipelinePolicy scmAuthPolicy = HttpPipelinePolicy.ToPipelinePolicy(azureAuthPolicy);

        // TODO: convert Azure client options to SCM client options
        ClientPipelineOptions scmPipelineOptions = ClientOptions.ToPipelineOptions(options);

        // TODO: take an Azure policy in an SCM pipeline
        _scmPipeline = ClientPipeline.Create(scmPipelineOptions,
            perCallPolicies: ReadOnlySpan<PipelinePolicy>.Empty,
            perTryPolicies: new PipelinePolicy[] { scmAuthPolicy },
            beforeTransportPolicies: ReadOnlySpan<PipelinePolicy>.Empty);
    }

    public virtual async Task<Response<IPAddressCountryPair>> GetCountryCodeAsync(IPAddress ipAddress, CancellationToken cancellationToken = default)
    {
        if (ipAddress is null)
            throw new ArgumentNullException(nameof(ipAddress));

        RequestContext options = cancellationToken.CanBeCanceled ?
            new RequestContext() { CancellationToken = cancellationToken } :
            new RequestContext();

        Response response = await GetCountryCodeAsync(ipAddress.ToString(), options).ConfigureAwait(false);

        IPAddressCountryPair value = IPAddressCountryPair.FromResponse(response);

        return Response.FromValue(value, response);
    }

    public virtual async Task<Response> GetCountryCodeAsync(string ipAddress, RequestContext context = null)
    {
        if (ipAddress is null)
            throw new ArgumentNullException(nameof(ipAddress));

        context ??= new RequestContext();

        // TODO: convert RequestContext to RequestOptions
        RequestOptions scmOptions = RequestContext.ToRequestOptions(context);

        using PipelineMessage message = CreateGetLocationRequest(ipAddress, scmOptions);

        await _scmPipeline.SendAsync(message).ConfigureAwait(false);

        PipelineResponse scmResponse = message.Response!;

        // TODO: convert SCM response to Azure Response
        Response azureReponse = Response.FromPipelineResponse(scmResponse);

        if (azureReponse.IsError && context.ErrorOptions == ErrorOptions.Default)
        {
            // NOTE: throw RFE instead of CRE
            throw new RequestFailedException(azureReponse);
        }

        return azureReponse;
    }

    public virtual Response<IPAddressCountryPair> GetCountryCode(IPAddress ipAddress, CancellationToken cancellationToken = default)
    {
        if (ipAddress is null)
            throw new ArgumentNullException(nameof(ipAddress));

        RequestContext options = cancellationToken.CanBeCanceled ?
            new RequestContext() { CancellationToken = cancellationToken } :
            new RequestContext();

        Response response = GetCountryCode(ipAddress.ToString(), options);

        IPAddressCountryPair value = IPAddressCountryPair.FromResponse(response);

        return Response.FromValue(value, response);
    }

    public virtual Response GetCountryCode(string ipAddress, RequestContext context = null)
    {
        if (ipAddress is null)
        {
            throw new ArgumentNullException(nameof(ipAddress));
        }

        context ??= new RequestContext();

        // TODO: convert RequestContext to RequestOptions
        RequestOptions scmOptions = RequestContext.ToRequestOptions(context);

        using PipelineMessage message = CreateGetLocationRequest(ipAddress, scmOptions);

        _scmPipeline.Send(message);

        PipelineResponse scmResponse = message.Response!;

        // TODO: convert SCM response to Azure Response
        Response azureReponse = Response.FromPipelineResponse(scmResponse);

        if (azureReponse.IsError && context.ErrorOptions == ErrorOptions.Default)
        {
        	// NOTE: throw RFE instead of CRE
            throw new RequestFailedException(azureReponse);
        }

        return azureReponse;
    }

    private PipelineMessage CreateGetLocationRequest(string ipAddress, RequestOptions options)
    {
        PipelineMessage message = _scmPipeline.CreateMessage();

        message.ResponseClassifier = PipelineMessageClassifier.Create(stackalloc ushort[] { 200 });

        PipelineRequest request = message.Request;
        request.Method = "GET";

        UriBuilder uriBuilder = new(_endpoint.ToString());

        StringBuilder path = new();
        path.Append("geolocation/ip");
        path.Append("/json");
        uriBuilder.Path += path.ToString();

        StringBuilder query = new();
        query.Append("api-version=");
        query.Append(Uri.EscapeDataString(_apiVersion));
        query.Append("&ip=");
        query.Append(Uri.EscapeDataString(ipAddress));
        uriBuilder.Query = query.ToString();

        request.Uri = uriBuilder.Uri;

        request.Headers.Add("Accept", "application/json");

        message.Apply(options);

        return message;
    }
}
