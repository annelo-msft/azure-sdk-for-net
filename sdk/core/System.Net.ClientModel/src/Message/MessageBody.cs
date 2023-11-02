﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Net.ClientModel.Internal;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.ClientModel.Core
{
    // I wish we could have the name MessageContent, but there is already
    // Azure.Messaging.MessageContent.
    public abstract class MessageBody
    {
        // TODO(matell): The .NET Framework team plans to add BinaryData.Empty in dotnet/runtime#49670, and we can use it then.
        internal static readonly BinaryData EmptyBinaryData = new(Array.Empty<byte>());
        internal static MessageBody Empty = Create(EmptyBinaryData);

        /// <summary>
        /// Creates an instance of <see cref="MessageBody"/> that wraps a <see cref="BinaryData"/>.
        /// </summary>
        /// <param name="value">The <see cref="BinaryData"/> to use.</param>
        /// <returns>An instance of <see cref="MessageBody"/> that wraps a <see cref="BinaryData"/>.</returns>
        public static MessageBody Create(BinaryData value) => new BinaryDataMessageBody(value.ToMemory());

        /// <summary>
        /// Creates an instance of <see cref="MessageBody"/> that wraps a <see cref="IModel{T}"/>.
        /// </summary>
        /// <param name="model">The <see cref="IModel{T}"/> to write.</param>
        /// <param name="options">The <see cref="ModelReaderWriterOptions"/> to use.</param>
        /// <returns>An instance of <see cref="MessageBody"/> that wraps a <see cref="IModel{T}"/>.</returns>
        public static MessageBody Create(IModel<object> model, ModelReaderWriterOptions? options = default)
            => new ModelMessageBody(model, options ?? ModelReaderWriterOptions.DefaultWireOptions);

        /// <summary>
        /// Attempts to compute the length of the underlying body content, if available.
        /// </summary>
        /// <param name="length">The length of the underlying data.</param>
        public abstract bool TryComputeLength(out long length);

        /// <summary>
        /// Writes contents of this object to an instance of <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <param name="cancellationToken">To cancellation token to use.</param>
        public abstract Task WriteToAsync(Stream stream, CancellationToken cancellationToken);

        /// <summary>
        /// Writes contents of this object to an instance of <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <param name="cancellationToken">To cancellation token to use.</param>
        public abstract void WriteTo(Stream stream, CancellationToken cancellationToken);

        internal virtual bool IsBuffered { get; }

        private sealed class ModelMessageBody : MessageBody, IDisposable
        {
            private readonly IModel<object> _model;
            private readonly ModelReaderWriterOptions _options;

            // Used when _model is an IJsonModel
            private ModelWriter? _writer;
            private ModelWriter Writer
            {
                get
                {
                    if (_model is not IJsonModel<object> jsonModel)
                    {
                        throw new InvalidOperationException("Cannot use Writer with non-IJsonModel model type.");
                    }

                    _writer ??= new ModelWriter(jsonModel, _options);
                    return _writer;
                }
            }

            // Used when _model is an IModel
            private BinaryData? _data;
            private BinaryData Data
            {
                get
                {
                    if (_model is IJsonModel<object>)
                    {
                        throw new InvalidOperationException("Should use ModelWriter instead of _model.Write with IJsonModel.");
                    }

                    _data ??= _model.Write(_options);
                    return _data;
                }
            }

            public ModelMessageBody(IModel<object> model, ModelReaderWriterOptions options)
            {
                _model = model;
                _options = options;
            }

            public override bool TryComputeLength(out long length)
            {
                if (_model is IJsonModel<object>)
                {
                    return Writer.TryComputeLength(out length);
                }

                length = Data.ToMemory().Length;
                return true;
            }

#if NETFRAMEWORK || NETSTANDARD2_0
            private byte[]? _bytes;
            private byte[] Bytes => _bytes ??= Data.ToArray();
#endif

            public override void WriteTo(Stream stream, CancellationToken cancellation)
            {
                if (_model is IJsonModel<object>)
                {
                    Writer.CopyTo(stream, cancellation);
                    return;
                }

#if NETFRAMEWORK || NETSTANDARD2_0
                stream.Write(Bytes, 0, Bytes.Length);
#else
                stream.Write(Data.ToMemory().Span);
#endif
            }

            public override async Task WriteToAsync(Stream stream, CancellationToken cancellation)
            {
                if (_model is IJsonModel<object>)
                {
                    await Writer.CopyToAsync(stream, cancellation).ConfigureAwait(false);
                    return;
                }

                await stream.WriteAsync(Data.ToMemory(), cancellation).ConfigureAwait(false);
            }

            public void Dispose()
            {
                var writer = _writer;
                if (writer != null)
                {
                    _writer = null;
                    writer.Dispose();
                }
            }
        }

        // BinaryData holds ReadOnlyMemory<byte> so this is the type that works
        // with BinaryData in an optimized way.
        private sealed class BinaryDataMessageBody : MessageBody
        {
            private readonly ReadOnlyMemory<byte> _bytes;

            public BinaryDataMessageBody(ReadOnlyMemory<byte> bytes)
            {
                _bytes = bytes;
            }

            internal override bool IsBuffered => true;

            public override bool TryComputeLength(out long length)
            {
                length = _bytes.Length;
                return true;
            }

            public override void WriteTo(Stream stream, CancellationToken cancellation)
            {
                byte[] buffer = _bytes.ToArray();
                stream.Write(buffer, 0, buffer.Length);
            }

            public override async Task WriteToAsync(Stream stream, CancellationToken cancellation)
                => await stream.WriteAsync(_bytes, cancellation).ConfigureAwait(false);
        }
    }
}