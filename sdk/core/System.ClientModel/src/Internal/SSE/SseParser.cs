// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Text;

namespace System.Formats.Sse;

/// <summary>Provides a parser for parsing server-sent events.</summary>
public static class SseParser
{
    /// <summary>Parses a <paramref name="sseStream"/> of server-sent events into a sequence of <see cref="SseItem{String}"/> values.</summary>
    /// <param name="sseStream">The stream containing the data to parse.</param>
    /// <returns>
    /// The enumerable of strings, which may be enumerated synchronously or asynchronously. The strings
    /// are decoded from the UTF8-encoded bytes of the payload of each event.
    /// </returns>
    /// <exception cref="ArgumentNullException"><paramref name="sseStream"/> is null.</exception>
    public static SseEnumerable<string> Parse(Stream sseStream) =>
        Parse(sseStream, static (_, bytes) => Utf8GetString(bytes));

    /// <summary>Parses a <paramref name="sseStream"/> of server-sent events into a sequence of <see cref="SseItem{T}"/> values.</summary>
    /// <typeparam name="T">Specifies the type of data in each event.</typeparam>
    /// <param name="sseStream">The stream containing the data to parse.</param>
    /// <param name="itemParser">The parser to use to transform each payload of bytes into a data element.</param>
    /// <returns>The enumerable, which may be enumerated synchronously or asynchronously.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="sseStream"/> is null.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="itemParser"/> is null.</exception>
    public static SseEnumerable<T> Parse<T>(Stream sseStream, SseItemParser<T> itemParser) =>
        new SseEnumerable<T>(
            sseStream ?? throw new ArgumentNullException(nameof(sseStream)),
            itemParser ?? throw new ArgumentNullException(nameof(itemParser)));

    /// <summary>Encoding.UTF8.GetString(bytes)</summary>
    internal static /*unsafe*/ string Utf8GetString(ReadOnlySpan<byte> bytes)
    {
        //#if NET
#if NET6_0_OR_GREATER
        return Encoding.UTF8.GetString(bytes);
#else
        return Encoding.UTF8.GetString(bytes.ToArray());
#endif
        //#else
        //        fixed (byte* ptr = bytes)
        //        {
        //            return ptr is null ?
        //                string.Empty :
        //                Encoding.UTF8.GetString(ptr, bytes.Length);
        //        }
        //#endif
    }
}
