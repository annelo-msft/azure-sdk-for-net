// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace System.ClientModel.Primitives;

#pragma warning disable CS1591 // public XML comments
public class BinaryContent<T> : BinaryContent where T : IPersistableModel<T>
{
    private BinaryContent? _content;

    public BinaryContent(T value)
    {
        Value = value;
    }

    public T Value { get; }

    private BinaryContent Content => _content ??= Create(Value);

    public override bool TryComputeLength(out long length)
        => Content.TryComputeLength(out length);

    public override void WriteTo(Stream stream, CancellationToken cancellationToken = default)
        => Content.WriteTo(stream, cancellationToken);

    public async override Task WriteToAsync(Stream stream, CancellationToken cancellationToken = default)
        => await Content.WriteToAsync(stream, cancellationToken).ConfigureAwait(false);

    public override void Dispose()
        => Content.Dispose();
}
#pragma warning restore CS1591 // public XML comments
