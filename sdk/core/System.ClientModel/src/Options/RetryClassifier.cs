﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;

namespace System.ClientModel.Primitives;

public class RetryClassifier
{
    /// <summary>
    /// Specifies if the request contained in the <paramref name="message"/> should be retried.
    /// </summary>
    public virtual bool IsRetriable(PipelineMessage message)
        => message.Response.Status switch
        {
            // Request Timeout
            408 => true,

            // Too Many Requests
            429 => true,

            // Internal Server Error
            500 => true,

            // Bad Gateway
            502 => true,

            // Service Unavailable
            503 => true,

            // Gateway Timeout
            504 => true,

            // Default case
            _ => false
        };

    /// <summary>
    /// Specifies if the operation that caused the exception should be retried.
    /// </summary>
    public virtual bool IsRetriable(Exception exception)
        => (exception is IOException) ||
           (exception is ClientRequestException ex && ex.Status == 0);

    /// <summary>
    /// Specifies if the operation that caused the exception should be retried,
    /// taking the <see cref="PipelineMessage"/> into consideration.
    /// </summary>
    public virtual bool IsRetriable(PipelineMessage message, Exception exception)
     => IsRetriable(exception) ||
        // Retry non-user initiated cancellations
        (exception is OperationCanceledException &&
        !message.CancellationToken.IsCancellationRequested);
}
