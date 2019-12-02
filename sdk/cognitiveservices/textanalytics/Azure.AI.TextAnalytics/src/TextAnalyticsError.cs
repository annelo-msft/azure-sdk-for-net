// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;

namespace Azure.AI.TextAnalytics
{
    internal class TextAnalyticsError
    {
        public string Code { get; internal set; }

        public string Message { get; internal set; }

        public string Target { get; internal set; }

        public TextAnalyticsError InnerError { get; internal set; }

        public IDictionary<string, string> Details { get; } = new Dictionary<string, string>();

        internal TextAnalyticsError()
        {
        }

        internal static TextAnalyticsError FromJson(JsonElement element)
        {
            TextAnalyticsError error = new TextAnalyticsError();

            if (element.TryGetProperty("code", out JsonElement codeValue))
            {
                error.Code = codeValue.ToString();
            }

            if (element.TryGetProperty("message", out JsonElement messageValue))
            {
                error.Message = messageValue.ToString();
            }

            if (element.TryGetProperty("target", out JsonElement targetValue))
            {
                error.Target = targetValue.ToString();
            }

            if (element.TryGetProperty("innerError", out JsonElement innerErrorValue))
            {
                error.InnerError = FromJson(innerErrorValue);
            }

            if (element.TryGetProperty("details", out JsonElement detailsValue))
            {
                foreach (JsonElement detailElement in detailsValue.EnumerateArray())
                {
                    // YOU ARE HERE.
                    //detailElement.
                }
            }


            return error;
        }

        /// <summary>
        /// Create an exception corresponding to the StorageError.
        /// </summary>
        /// <param name="response">The failed response.</param>
        /// <returns>A RequestFailedException.</returns>
        public Exception CreateException(Azure.Response response)
            => CreateException(response, Code, Message, Target, InnerError, );


        /// <summary>
        /// Create a RequestFailedException with a proper error message.
        /// </summary>
        /// <param name="response">The failed response.</param>
        /// <param name="message">The optional message.</param>
        /// <param name="innerException">An optional inner Exception.</param>
        /// <param name="errorCode">An optional error code.</param>
        /// <param name="additionalInfo">Optional additional information.</param>
        /// <returns></returns>
        public static RequestFailedException CreateException(
            Response response,
            string message = null,
            string errorCode = null,
            Exception innerException = null,)
        {
            Argument.AssertNotNull(response, nameof(response));

            var exception = new RequestFailedException(
                response.Status,
                CreateMessage(response, message ?? response.ReasonPhrase, errorCode, additionalInfo),
                errorCode,
                innerException);

            if (additionalInfo != null)
            {
                foreach (KeyValuePair<string, string> pair in additionalInfo)
                {
                    exception.Data.Add(pair.Key, pair.Value);
                }
            }

            return exception;
        }

        /// <summary>
        /// Create the exception's Message.
        /// </summary>
        /// <param name="message">The default message.</param>
        /// <param name="response">The error response.</param>
        /// <param name="errorCode">An optional error code.</param>
        /// <param name="additionalInfo">Optional additional information.</param>
        /// <returns>The exception's Message.</returns>
        private static string CreateMessage(
            Response response,
            string message,
            string errorCode,
            IDictionary<string, string> additionalInfo)
        {
            // Start with the message, status, and reason
            StringBuilder messageBuilder = new StringBuilder()
                .AppendLine(message)
                .Append("Status: ")
                .Append(response.Status.ToString(CultureInfo.InvariantCulture))
                .Append(" (")
                .Append(response.ReasonPhrase)
                .AppendLine(")");

            // Make the ErrorCode especially prominent
            if (!string.IsNullOrEmpty(errorCode))
            {
                messageBuilder
                    .AppendLine()
                    .Append("ErrorCode: ")
                    .AppendLine(errorCode);
            }

            // A Storage error's Content is (currently) always the ErrorCode and
            // AdditionalInfo, so we skip the specific Content section
            if (additionalInfo != null && additionalInfo.Count > 0)
            {
                messageBuilder
                    .AppendLine()
                    .AppendLine("Additional Information:");

                foreach (KeyValuePair<string, string> info in additionalInfo)
                {
                    messageBuilder
                        .Append(info.Key)
                        .Append(": ")
                        .AppendLine(info.Value);
                }
            }

            // Include the response headers
            messageBuilder
                .AppendLine()
                .AppendLine("Headers:");
            foreach (HttpHeader responseHeader in response.Headers)
            {
                messageBuilder
                    .Append(responseHeader.Name)
                    .Append(": ")
                    .AppendLine(responseHeader.Value);
            }

            return messageBuilder.ToString();
        }

    }
}
