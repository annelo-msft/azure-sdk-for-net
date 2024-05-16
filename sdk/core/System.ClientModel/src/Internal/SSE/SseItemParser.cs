// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Formats.Sse;

/// <summary>Encapsulates a method for parsing the bytes payload of a server-sent event.</summary>
/// <typeparam name="T">Specifies the type of the return value of the parser.</typeparam>
/// <param name="eventType">The event's type.</param>
/// <param name="data">The event's payload bytes.</param>
/// <returns>The parsed <typeparamref name="T"/>.</returns>
public delegate T SseItemParser<out T>(string eventType, ReadOnlySpan<byte> data);
