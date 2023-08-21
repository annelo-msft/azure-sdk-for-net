// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> Search for available phone numbers to purchase. </summary>
    public partial class SearchAvailablePhoneNumbersOperation : Operation<PhoneNumberSearchResult>, Core.IOperationSource<PhoneNumberSearchResult>
    {
        private readonly OperationInternal<PhoneNumberSearchResult> _operation;

        /// <summary> Initializes a new instance of SearchAvailablePhoneNumbersOperation for mocking. </summary>
        protected SearchAvailablePhoneNumbersOperation()
        {
        }
#pragma warning restore CA1822

        /// <inheritdoc />
        public override PhoneNumberSearchResult Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.RawResponse;

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override Response<PhoneNumberSearchResult> WaitForCompletion(CancellationToken cancellationToken = default) => _operation.WaitForCompletion(cancellationToken);

        /// <inheritdoc />
        public override Response<PhoneNumberSearchResult> WaitForCompletion(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletion(pollingInterval, cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<PhoneNumberSearchResult>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<PhoneNumberSearchResult>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        PhoneNumberSearchResult Core.IOperationSource<PhoneNumberSearchResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return PhoneNumberSearchResult.DeserializePhoneNumberSearchResult(document.RootElement);
        }

        async ValueTask<PhoneNumberSearchResult> Core.IOperationSource<PhoneNumberSearchResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return PhoneNumberSearchResult.DeserializePhoneNumberSearchResult(document.RootElement);
        }
    }
}
