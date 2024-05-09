// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace System.Formats.Sse;

internal static class SseParser
{
    //// The proposed API relies on ref structs being able to be used as a
    //// generic parameters and on Func being annotated accordingly. This
    //// is on track to happen for .NET 9 / C# 13, but if it doesn't, a
    //// different shape might be needed.
    //public static IAsyncEnumerable<SseItem<T>> ParseAsync<T>(
    //    Stream sseStream,
    //    Func<string?, ReadOnlySpan<byte>, T> itemParser,
    //    CancellationToken cancellationToken = default)
    //{
    //    throw new NotImplementedException();
    //}

    // TODO: why is string be nullable?
    // TODO: is Func the best type for terminal event check?
    // TODO: responsibility for disposal of stream? -> obtain lazily?
    // TODO: I think, don't take cancellationToken?

    public static IAsyncEnumerable<SseItem<T>> ParseAsync<T>(
        Func<Task<Stream>> getSseStreamAsync,
        Func<string, T> parseItem,
        Func<SseItem<T>, bool>? isTerminalEvent = default)
    {
        throw new NotImplementedException();
    }
}
