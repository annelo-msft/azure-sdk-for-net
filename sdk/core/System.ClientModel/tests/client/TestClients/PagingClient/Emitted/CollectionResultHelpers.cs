// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;

namespace ClientModel.Tests.Paging;

internal class CollectionResultHelpers
{
    public static AsyncCollectionResult<T> CreateAsync<T>(PageEnumerator<T> enumerator)
        => new AsyncPaginatedCollectionResult<T>(enumerator);

    public static CollectionResult<T> Create<T>(PageEnumerator<T> enumerator)
        => new PaginatedCollectionResult<T>(enumerator);

    public static AsyncCollectionResult CreateAsync(PageEnumerator enumerator)
        => new AsyncPaginatedCollectionResult(enumerator);

    public static CollectionResult Create(PageEnumerator enumerator)
        => new PaginatedCollectionResult(enumerator);

    private class AsyncPaginatedCollectionResult<T> : AsyncCollectionResult<T>
    {
        private readonly PageEnumerator<T> _pageEnumerator;

        public AsyncPaginatedCollectionResult(PageEnumerator<T> pageEnumerator)
        {
            _pageEnumerator = pageEnumerator;
        }

        public override ContinuationToken? GetContinuationToken(ClientResult page)
            => _pageEnumerator.GetNextPageToken(page);

        public async override IAsyncEnumerable<ClientResult> GetRawPagesAsync()
        {
            // TODO: this must use a different enumerator each time it's called.
            while (await _pageEnumerator.MoveNextAsync())
            {
                yield return _pageEnumerator.Current;
            }
        }
        protected override IAsyncEnumerable<T> GetValuesFromPageAsync(ClientResult page)
        {
            throw new System.NotImplementedException();
        }
    }

    private class PaginatedCollectionResult<T> : CollectionResult<T>
    {
        private readonly PageEnumerator<T> _pageEnumerator;

        public PaginatedCollectionResult(PageEnumerator<T> pageEnumerator)
        {
            _pageEnumerator = pageEnumerator;
        }

        public override ContinuationToken? GetContinuationToken(ClientResult page)
            => _pageEnumerator.GetNextPageToken(page);

        protected override IEnumerable<T> GetValuesFromPage(ClientResult result)
        {
            throw new System.NotImplementedException();
        }

        public override IEnumerable<ClientResult> GetRawPages()
        {
            // TODO: this must use a different enumerator each time it's called.
            while (_pageEnumerator.MoveNext())
            {
                yield return _pageEnumerator.Current;
            }
        }
    }

    private class AsyncPaginatedCollectionResult : AsyncCollectionResult
    {
        private readonly PageEnumerator _pageEnumerator;

        public AsyncPaginatedCollectionResult(PageEnumerator pageEnumerator)
        {
            _pageEnumerator = pageEnumerator;
        }

        public override ContinuationToken? GetContinuationToken(ClientResult page)
            => _pageEnumerator.GetNextPageToken(page);

        public async override IAsyncEnumerable<ClientResult> GetRawPagesAsync()
        {
            while (await _pageEnumerator.MoveNextAsync())
            {
                yield return _pageEnumerator.Current;
            }
        }
    }

    private class PaginatedCollectionResult : CollectionResult
    {
        private readonly PageEnumerator _pageEnumerator;

        public PaginatedCollectionResult(PageEnumerator pageEnumerator)
        {
            _pageEnumerator = pageEnumerator;
        }

        public override ContinuationToken? GetContinuationToken(ClientResult page)
            => _pageEnumerator.GetNextPageToken(page);

        public override IEnumerable<ClientResult> GetRawPages()
        {
            while (_pageEnumerator.MoveNext())
            {
                yield return _pageEnumerator.Current;
            }
        }
    }
}
