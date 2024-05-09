// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Diagnostics;

namespace System.Formats.Sse;

internal struct PendingSseItem
{
    private const char LF = '\n';

    private List<ServerSentEventField>? _dataFields;

    // TODO: I think making the fields nullable makes them take up more space?

    public int DataLength { get; set; }
    public List<ServerSentEventField> DataFields => _dataFields ??= new();
    public ServerSentEventField? EventTypeField { get; set; }
    public ServerSentEventField? IdField { get; set; }
    public ServerSentEventField? RetryField { get; set; }

    public SseItem<T> ToSseItem<T>(Func<string, T> itemParser)
    {
        SseItem<T> item = default;

        // Per spec, if event type buffer is empty, set event.type to "message".
        item.EventType = EventTypeField.HasValue ?
            EventTypeField.Value.Value.ToString() :
            "message";

        if (IdField.HasValue)
        {
            item.Id = IdField.Value.Value.ToString();
        }

        if (RetryField.HasValue)
        {
#if NETSTANDARD2_0
            item.ReconnectionTime = int.TryParse(RetryField.Value.Value.ToString(), out int retry) ? TimeSpan.FromMilliseconds(retry) : null;
#else
            item.ReconnectionTime = int.TryParse(RetryField.Value.Value.Span, out int retry) ? TimeSpan.FromMilliseconds(retry) : null;
#endif
        }

        Debug.Assert(DataLength > 0);

        Memory<char> buffer = new(new char[DataLength]);

        int curr = 0;

        foreach (ServerSentEventField field in DataFields)
        {
            Debug.Assert(field.FieldType == ServerSentEventFieldKind.Data);

            field.Value.Span.CopyTo(buffer.Span.Slice(curr));
            buffer.Span[curr + field.Value.Length] = LF;
            curr += field.Value.Length + 1;
        }

        // remove trailing LF and parse as T.
        item.Data = itemParser(buffer.Slice(0, buffer.Length - 1).ToString());

        return item;
    }
}
