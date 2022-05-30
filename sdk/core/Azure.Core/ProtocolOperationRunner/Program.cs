using Azure;
using Azure.Core;
using Azure.Core.Pipeline;


ServiceClient client = new ServiceClient();
Operation<BinaryData> computeOp = client.ComputeResource(WaitUntil.Started, new BinaryData("<data>"));

//ProtocolOperation<BinaryData> rehydratedComputeOp = new ProtocolOperation<BinaryData>(computeOp.ContinuationToken, client.Pipeline);
//rehydratedComputeOp.WaitForCompletion(); // TODO: 

public class ProtocolOperation : Operation
{
    public ProtocolOperation(string continuationToken, HttpPipeline pipeline, RequestContext context = null)
    {
    }

    public override string Id => throw new NotImplementedException();

    public override bool HasCompleted => throw new NotImplementedException();

    public override Response GetRawResponse() => throw new NotImplementedException();

    public override Response UpdateStatus(CancellationToken cancellationToken = default) => throw new NotImplementedException();

    public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => throw new NotImplementedException();
}

public class ProtocolOperation<T> : Operation<T> where T : notnull, IProtocolConvertable<T>
{
    private ProtocolOperation _protocolOperation;

    public ProtocolOperation(string continuationToken, HttpPipeline pipeline, RequestContext context = null)
    {
        _protocolOperation = new ProtocolOperation(continuationToken, pipeline, context);
    }

    public override T Value => _protocolOperation.GetRawResponse().Content.ToObjectFromJson<T>();

    public override bool HasValue => throw new NotImplementedException();

    public override string Id => _protocolOperation.Id;

    public override bool HasCompleted => throw new NotImplementedException();

    public override Response GetRawResponse()
    {
        throw new NotImplementedException();
    }

    public override Response UpdateStatus(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

}

public interface IProtocolConvertable<T>
{
    T FromResponse(Response response);
    RequestContent ToRequestContent(T value);
}

public class ServiceClient
{
    public HttpPipeline Pipeline { get; }

    public Operation DeleteResource(WaitUntil waitUntil, string id, RequestContext context = null) => throw new NotImplementedException();
    public Operation<BinaryData> ComputeResource(WaitUntil wait, RequestContent content, RequestContext context = null) => throw new NotImplementedException();
}
