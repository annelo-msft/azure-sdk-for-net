// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Formats.Sse;

/// <summary>Represents a server-sent event.</summary>
/// <typeparam name="T">Specifies the type of data payload in the event.</typeparam>
public readonly struct SseItem<T>
{
    /// <summary>Initializes the server-sent event.</summary>
    /// <param name="data">The event's payload.</param>
    /// <param name="eventType">The event's type.</param>
    public SseItem(T data, string eventType)
    {
        Data = data;
        EventType = eventType;
    }

    /// <summary>Gets the event's payload.</summary>
    public T Data { get; }

    /// <summary>Gets the event's type.</summary>
    public string EventType { get; }
}
