// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace System.Net.Http;

internal static class MultipartFormDataContentExtensions
{
    public static void CopyTo(this MultipartFormDataContent content, Stream stream, CancellationToken cancellationToken = default)
    {
#if NET6_0_OR_GREATER
        content.CopyTo(stream, context: default, cancellationToken);
#else
        //content.CopyTo(stream, cancellation);
        // Write start boundary.
        WriteToStream(stream, "--" + _boundary + CrLf);

        // Write each nested content.
        foreach (HttpContent contentPart in content)
        {

        }
        for (int contentIndex = 0; contentIndex < _nestedContent.Count; contentIndex++)
        {
            // Write divider, headers, and content.
            HttpContent content = _nestedContent[contentIndex];
            SerializeHeadersToStream(stream, content, writeDivider: contentIndex != 0);
            content.CopyTo(stream, cancellationToken);
        }

        // Write footer boundary.
        WriteToStream(stream, CrLf + "--" + _boundary + "--" + CrLf);
#endif
    }
}
