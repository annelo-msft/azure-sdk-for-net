﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Buffers;
using System.ClientModel.Internal;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.ClientModel;

/// <summary>
/// Represents binary content that can be sent to a cloud service as part of
/// a <see cref="PipelineRequest"/>.
/// </summary>
public abstract class BinaryContent : IDisposable
{
    private static readonly ModelReaderWriterOptions ModelWriteWireOptions = new ModelReaderWriterOptions("W");

    private static readonly Encoding s_UTF8NoBomEncoding = new UTF8Encoding(false);

    /// <summary>
    /// Creates an instance of <see cref="BinaryContent"/> that contains the
    /// bytes held in the provided <see cref="BinaryData"/> instance.
    /// </summary>
    /// <param name="value">The <see cref="BinaryData"/> containing the bytes
    /// this <see cref="BinaryContent"/> will hold.</param>
    /// <returns>An an instance of <see cref="BinaryContent"/> that contains the
    /// bytes held in the provided <see cref="BinaryData"/> instance.</returns>
    public static BinaryContent FromBinaryData(BinaryData value)
        => new BinaryDataBinaryContent(value.ToMemory());

    /// <summary>
    /// Creates an instance of <see cref="BinaryContent"/> that contains the
    /// bytes resulting from writing the value of the provided
    /// <see cref="IPersistableModel{T}"/>.
    /// </summary>
    /// <param name="model">The <see cref="IPersistableModel{T}"/> to write.</param>
    /// <param name="options">The <see cref="ModelReaderWriterOptions"/>, if any,
    /// that indicates what format the <paramref name="model"/> will be written in.
    /// </param>
    /// <returns>An instance of <see cref="BinaryContent"/> that wraps a <see cref="IPersistableModel{T}"/>.</returns>
    public static BinaryContent FromModel<T>(T model, ModelReaderWriterOptions? options = default) where T : IPersistableModel<T>
        => new ModelBinaryContent<T>(model, options ?? ModelWriteWireOptions);

    /// <summary>
    /// Creates an instance of <see cref="BinaryContent"/> that contains the
    /// bytes held in the provided <see cref="Stream"/> instance.
    /// </summary>
    /// <param name="stream">The <see cref="Stream"/> containing the bytes
    /// this <see cref="BinaryContent"/> will hold.</param>
    /// <returns>An an instance of <see cref="BinaryContent"/> that contains the
    /// bytes held in the provided <see cref="Stream"/> instance.</returns>
    public static BinaryContent FromStream(Stream stream)
        => new StreamBinaryContent(stream);

    /// <summary>
    /// Creates an instance of <see cref="BinaryContent"/> that contains the
    /// bytes held in the <see cref="FileStream"/> opened from the provided
    /// <paramref name="path"/>.
    /// </summary>
    /// <param name="path">The path to the file containing the content
    /// this <see cref="BinaryContent"/> will hold.</param>
    /// <returns>An an instance of <see cref="BinaryContent"/> that contains the
    /// bytes held in the <see cref="FileStream"/> opened from the provided
    /// <paramref name="path"/>.</returns>
    /// <remarks>The caller is responsible for calling <see cref="Dispose"/>
    /// on the instance returned from this method.</remarks>
    public static BinaryContent FromPath(string path)
        => new StreamBinaryContent(File.OpenRead(path));

    /// <summary>
    /// TBD.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static BinaryContent FromString(string value)
        => new BinaryDataBinaryContent(s_UTF8NoBomEncoding.GetBytes(value));

    /// <summary>
    /// TBD.
    /// </summary>
    /// <param name="parts"></param>
    /// <returns></returns>
    public static BinaryContent CreateMultipartFormDataContent(IEnumerable<(BinaryContent Content, PipelineRequestHeaders Headers)> parts)
        => new MultipartFormDataBinaryContent(parts);

    /// <summary>
    /// Attempts to compute the length of the underlying body content, if available.
    /// </summary>
    /// <param name="length">The length of the underlying data.</param>
    public abstract bool TryComputeLength(out long length);

    /// <summary>
    /// Writes contents of this <see cref="BinaryContent"/> instance to the
    /// provided <see cref="Stream"/>.
    /// </summary>
    /// <param name="stream">The stream to write the binary content to.</param>
    /// <param name="cancellationToken">To <see cref="CancellationToken"/> to
    /// use for the write operation.</param>
    public abstract Task WriteToAsync(Stream stream, CancellationToken cancellationToken = default);

    /// <summary>
    /// Writes contents of this <see cref="BinaryContent"/> instance to the
    /// provided <see cref="Stream"/>.
    /// </summary>
    /// <param name="stream">The stream to write the binary content to.</param>
    /// <param name="cancellationToken">To <see cref="CancellationToken"/> to
    /// use for the write operation.</param>
    public abstract void WriteTo(Stream stream, CancellationToken cancellationToken = default);

    /// <inheritdoc/>
    public abstract void Dispose();

    private sealed class BinaryDataBinaryContent : BinaryContent
    {
        internal readonly ReadOnlyMemory<byte> _bytes;

        public BinaryDataBinaryContent(ReadOnlyMemory<byte> bytes)
        {
            _bytes = bytes;
        }

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

        public override void Dispose() { }
    }

    private sealed class ModelBinaryContent<T> : BinaryContent where T : IPersistableModel<T>
    {
        private readonly T _model;
        private readonly ModelReaderWriterOptions _options;

        // Used when _model is an IJsonModel
        private UnsafeBufferSequence.Reader? _sequenceReader;

        // Used when _model is an IModel
        private BinaryData? _data;

        public ModelBinaryContent(T model, ModelReaderWriterOptions options)
        {
            _model = model;
            _options = options;
        }

        private UnsafeBufferSequence.Reader SequenceReader
        {
            get
            {
                if (_model is not IJsonModel<T> jsonModel)
                {
                    throw new InvalidOperationException("Cannot use Writer with non-IJsonModel model type.");
                }

                if (_sequenceReader == null)
                {
                    _sequenceReader = new ModelWriter<T>(jsonModel, _options).ExtractReader();
                }
                return _sequenceReader;
            }
        }

        private BinaryData Data
        {
            get
            {
                if (ModelReaderWriter.ShouldWriteAsJson(_model, _options))
                {
                    throw new InvalidOperationException("Should use ModelWriter instead of _model.Write with IJsonModel.");
                }

                _data ??= _model.Write(_options);
                return _data;
            }
        }

        public override bool TryComputeLength(out long length)
        {
            length = ModelReaderWriter.ShouldWriteAsJson(_model, _options) ? SequenceReader.Length : Data.ToMemory().Length;

            return true;
        }

#if NETFRAMEWORK || NETSTANDARD2_0
        private byte[]? _bytes;
        private byte[] Bytes => _bytes ??= Data.ToArray();
#endif

        public override void WriteTo(Stream stream, CancellationToken cancellation)
        {
            if (ModelReaderWriter.ShouldWriteAsJson(_model, _options))
            {
                SequenceReader.CopyTo(stream, cancellation);
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
            if (ModelReaderWriter.ShouldWriteAsJson(_model, _options))
            {
                await SequenceReader.CopyToAsync(stream, cancellation).ConfigureAwait(false);
                return;
            }

            await stream.WriteAsync(Data.ToMemory(), cancellation).ConfigureAwait(false);
        }

        public override void Dispose()
        {
            var sequenceReader = _sequenceReader;
            if (sequenceReader != null)
            {
                _sequenceReader = null;
                sequenceReader.Dispose();
            }
        }
    }

    private sealed class StreamBinaryContent : BinaryContent
    {
        private const int CopyToBufferSize = 81920;

        internal readonly Stream _stream;
        private readonly long _origin;

        public StreamBinaryContent(Stream stream)
        {
            if (!stream.CanSeek)
            {
                throw new ArgumentException("Stream must be seekable.", nameof(stream));
            }

            _stream = stream;
            _origin = stream.Position;
        }

        public override bool TryComputeLength(out long length)
        {
            if (_stream.CanSeek)
            {
                length = _stream.Length - _origin;
                return true;
            }

            length = 0;
            return false;
        }

        public override void WriteTo(Stream stream, CancellationToken cancellationToken)
        {
            _stream.Seek(_origin, SeekOrigin.Begin);

            // This is not using CopyTo so that we can honor cancellations.
            byte[] buffer = ArrayPool<byte>.Shared.Rent(CopyToBufferSize);

            try
            {
                while (true)
                {
                    CancellationHelper.ThrowIfCancellationRequested(cancellationToken);

                    int read = _stream.Read(buffer, 0, buffer.Length);

                    if (read == 0)
                    {
                        break;
                    }

                    CancellationHelper.ThrowIfCancellationRequested(cancellationToken);

                    stream.Write(buffer, 0, read);
                }
            }
            finally
            {
                stream.Flush();
                ArrayPool<byte>.Shared.Return(buffer, true);
            }
        }

        public override async Task WriteToAsync(Stream stream, CancellationToken cancellation)
        {
            _stream.Seek(_origin, SeekOrigin.Begin);

            await _stream.CopyToAsync(stream, CopyToBufferSize, cancellation).ConfigureAwait(false);
        }

        public override void Dispose()
        {
            _stream.Dispose();
        }
    }

    //private sealed class MultipartFormDataPart : BinaryContent
    //{
    //    public MultipartFormDataPart(BinaryContent content, PipelineRequestHeaders headers)
    //    {
    //        Content = content;
    //        Headers = headers;
    //    }

    //    public BinaryContent Content { get; }
    //    public PipelineRequestHeaders Headers { get; }
    //}

    internal sealed class MultipartFormDataBinaryContent : BinaryContent
    {
        private static Random _random = new();
        private static readonly char[] _boundaryValues = "()+,-./0123456789:=?ABCDEFGHIJKLMNOPQRSTUVWXYZ_abcdefghijklmnopqrstuvwxyz".ToCharArray();

        private MultipartFormDataContent _multipartContent;

        public MultipartFormDataBinaryContent(IEnumerable<(BinaryContent Content, PipelineRequestHeaders Headers)> parts)
        {
            _multipartContent = new MultipartFormDataContent(CreateBoundary());

            AddParts(parts);
        }

        private void AddParts(IEnumerable<(BinaryContent Content, PipelineRequestHeaders Headers)> parts)
        {
            foreach (var part in parts)
            {
                AddPart(part);
            }
        }

        private void AddPart((BinaryContent Content, PipelineRequestHeaders Headers) part)
        {
            BinaryContent content = part.Content;
            PipelineRequestHeaders headers = part.Headers;

            HttpContent httpContent = content switch
            {
                StreamBinaryContent streamContent => new StreamContent(streamContent._stream),

                // TODO: Make more efficient
                BinaryDataBinaryContent binaryDataContent => new ByteArrayContent(binaryDataContent._bytes.ToArray()),

                // ModelBinaryContent?

                _ => throw new NotImplementedException(),
            };

            // TODO: pull values out of headers ...
            _multipartContent.Add(httpContent, )
        }

        public void AddHeaders(PipelineRequest request)
        {
            if (_multipartContent.Headers.ContentType is not null)
            {
                // TODO: Is there a way not to call ToString?
                request.Headers.Set("Content-Type", _multipartContent.Headers.ContentType.ToString());
            }

            if (_multipartContent.Headers.ContentLength is long contentLength)
            {
                // TODO: Is there a way not to call ToString?
                request.Headers.Set("Content-Length", contentLength.ToString());
            }
        }

        private static string CreateBoundary()
        {
            // TODO: test it.

            Span<char> chars = new char[70];

            byte[] random = new byte[70];
            _random.NextBytes(random);

            int mask = _boundaryValues.Length - 1;
            for (int i = 0; i < 70; i++)
            {
                chars[i] = _boundaryValues[random[i] & mask];
            }

            return chars.ToString();
        }

        public override bool TryComputeLength(out long length)
        {
            if (_multipartContent.Headers.ContentLength is long contentLength)
            {
                length = contentLength;
                return true;
            }

            length = 0;
            return false;
        }

        public override void WriteTo(Stream stream, CancellationToken cancellationToken = default)
        {
            // TODO: Can we do better than sync-over-async?
            // This approach, using the netstandard2.0 API also doesn't use the CT.
            Stream contentStream = _multipartContent.ReadAsStreamAsync().Result;
            contentStream.CopyTo(contentStream, cancellationToken);
        }

        public override async Task WriteToAsync(Stream stream, CancellationToken cancellationToken = default)
        {
            await _multipartContent.CopyToAsync(stream, cancellationToken).ConfigureAwait(false);
        }
        public override void Dispose()
        {
            _multipartContent.Dispose();
        }
    }
}
