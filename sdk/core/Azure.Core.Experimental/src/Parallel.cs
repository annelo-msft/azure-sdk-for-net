// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA1801 // Review unused parameters
namespace Azure.Core
{
    /// <summary>
    /// </summary>
    public static class Parallel
    {
        //public static Task ForEachAsync<TSource>(IAsyncEnumerable<TSource> source, ParallelOptions parallelOptions, Func<TSource, CancellationToken, ValueTask> body)
        //{
        //    throw new NotImplementedException();
        //}
        //public static Task ForEachAsync<TSource>(IEnumerable<TSource> source, ParallelOptions parallelOptions, Func<TSource, CancellationToken, ValueTask> body)
        //{
        //    throw new NotImplementedException();
        //}

        public static Task ForEachAsync<TSource>(IAsyncEnumerable<TSource> source, int maxDegreeOfParallelism, Func<TSource, CancellationToken, ValueTask> body)
        {
            throw new NotImplementedException();
        }
        public static Task ForEachAsync<TSource>(IEnumerable<TSource> source, int maxDegreeOfParallelism, Func<TSource, CancellationToken, ValueTask> body)
        {
            throw new NotImplementedException();
        }

        //public static Task ForEachAsync<TSource>(IEnumerable<TSource> source, CancellationToken cancellationToken, Func<TSource, CancellationToken, ValueTask> body)
        //{
        //    throw new NotImplementedException();
        //}
        //public static Task ForEachAsync<TSource>(IAsyncEnumerable<TSource> source, CancellationToken cancellationToken, Func<TSource, CancellationToken, ValueTask> body)
        //{
        //    throw new NotImplementedException();
        //}
    }
#pragma warning restore CA1801 // Review unused parameters
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
