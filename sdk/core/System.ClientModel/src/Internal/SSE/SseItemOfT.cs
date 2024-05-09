// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace System.Formats.Sse;

internal struct SseItem<T>
{
    // TODO: why nullable?
    //public string? Event { get; set; } = "message";

    public string EventType { get; set; }

    public T Data { get; set; }

    // TODO: is the event the best place for id and retry?
    // would a different place make more sense?

    //public string LastEventId { get; set; }
    public string? Id { get; set; }

    // TODO: name?
    //public TimeSpan ReconnectionInterval { get; set; }
    public TimeSpan? ReconnectionTime {  get; set; }

    //internal SseItem(string name, T data, int? id, string retry)
    //{
    //    Data = data;
    //    Event = eventName;
    //    LastEventId = id;
    //    // TODO: retry
    //}
}
