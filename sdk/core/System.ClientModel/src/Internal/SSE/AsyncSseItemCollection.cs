// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Formats.Sse;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace System.ClientModel.Internal;

internal class AsyncSseItemCollection<T> : IAsyncEnumerable<SseItem<T>>
{
    private readonly Func<Task<Stream>> _getSseStreamAsync;
    private readonly Func<string, T> _parseItem;
    private readonly Func<SseItem<T>, bool>? _isTerminalEvent;

    public AsyncSseItemCollection(Func<Task<Stream>> getSseStreamAsync,
        Func<string, T> parseItem,
        Func<SseItem<T>, bool>? isTerminalEvent = default)
    {
        _getSseStreamAsync = getSseStreamAsync;
        _parseItem = parseItem;
        _isTerminalEvent = isTerminalEvent;
    }

    public IAsyncEnumerator<SseItem<T>> GetAsyncEnumerator(CancellationToken cancellationToken = default)
    {
        return new AsyncSseItemEnumerator(_getSseStreamAsync, _parseItem, _isTerminalEvent, cancellationToken);
    }

    private sealed class AsyncSseItemEnumerator : IAsyncEnumerator<SseItem<T>>
    {
        private readonly Func<Task<Stream>> _getSseStreamAsync;
        private readonly Func<string, T> _parseItem;
        private readonly Func<SseItem<T>, bool>? _isTerminalEvent;
        private readonly CancellationToken _cancellationToken;

        private ServerSentEventReader<T>? _reader;
        private bool _started;
        private SseItem<T> _current;

        public SseItem<T> Current => _current;

        public AsyncSseItemEnumerator(Func<Task<Stream>> getSseStreamAsync,
        Func<string, T> parseItem,
        Func<SseItem<T>, bool>? isTerminalEvent = default,
        CancellationToken cancellationToken = default)
        {
            _getSseStreamAsync = getSseStreamAsync;
            _parseItem = parseItem;
            _isTerminalEvent = isTerminalEvent;
            _cancellationToken = cancellationToken;
        }

        public async ValueTask<bool> MoveNextAsync()
        {
            if (_reader is null && _started)
            {
                throw new ObjectDisposedException(nameof(AsyncSseItemCollection<T>));
            }

            // TODO: consolidate with above
            if (_reader is null)
            {
                Stream stream = await _getSseStreamAsync().ConfigureAwait(false);
                _reader = new(stream, _parseItem);
                _started = true;
            }

            SseItem<T>? nextEvent = await _reader.TryGetNextEventAsync(_cancellationToken).ConfigureAwait(false);

            if (nextEvent.HasValue)
            {
                if (_isTerminalEvent is not null &&
                    _isTerminalEvent(nextEvent.Value))
                {
                    _current = default;
                    return false;
                }

                _current = nextEvent.Value;
                return true;
            }

            return false;
        }

        public async ValueTask DisposeAsync()
        {
            await DisposeAsyncCore().ConfigureAwait(false);

            GC.SuppressFinalize(this);
        }

        private async ValueTask DisposeAsyncCore()
        {
            if (_reader is not null)
            {
                await _reader.DisposeAsync().ConfigureAwait(false);
                _reader = null;
            }
        }
    }
}
