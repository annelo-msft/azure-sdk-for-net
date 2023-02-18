// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Azure.Core.Json
{
    public partial class MutableJsonDocument
    {
        internal const byte Delimiter = (byte)'.';

        internal class ChangeTracker
        {
            private List<MutableJsonChange>? _changes;

            internal bool HasChanges => _changes != null && _changes.Count > 0;

            internal bool AncestorChanged(ReadOnlySpan<byte> utf8Path, int highWaterMark)
            {
                if (_changes == null)
                {
                    return false;
                }

                bool changed = false;

                // Check for changes to ancestor elements
                while (!changed && utf8Path.Length > 0)
                {
                    utf8Path = PopProperty(utf8Path);
                    changed = TryGetChange(utf8Path, highWaterMark, out MutableJsonChange _);
                }

                return changed;
            }

            internal bool DescendantChanged(ReadOnlySpan<byte> utf8Path, int highWaterMark)
            {
                if (_changes == null)
                {
                    return false;
                }

                bool changed = false;

                for (int i = _changes!.Count - 1; i > highWaterMark; i--)
                {
                    MutableJsonChange c = _changes[i];
                    if (c.Utf8Path.Span.StartsWith(utf8Path))
                    {
                        return true;
                    }
                }

                return changed;
            }

            internal bool TryGetChange(ReadOnlySpan<byte> utf8Path, in int lastAppliedChange, out MutableJsonChange change)
            {
                if (_changes == null)
                {
                    change = default;
                    return false;
                }

                for (int i = _changes!.Count - 1; i > lastAppliedChange; i--)
                {
                    MutableJsonChange c = _changes[i];
                    if (c.Utf8Path.Span.SequenceEqual(utf8Path))
                    {
                        change = c;
                        return true;
                    }
                }

                change = default;
                return false;
            }

            internal bool TryGetChange(string path, in int lastAppliedChange, out MutableJsonChange change)
            {
                if (_changes == null)
                {
                    change = default;
                    return false;
                }

                for (int i = _changes!.Count - 1; i > lastAppliedChange; i--)
                {
                    MutableJsonChange c = _changes[i];
                    if (c.Path == path)
                    {
                        change = c;
                        return true;
                    }
                }

                change = default;
                return false;
            }

            internal int AddChange(string path, object? value, bool replaceJsonElement = false)
            {
                if (_changes == null)
                {
                    _changes = new List<MutableJsonChange>();
                }

                int index = _changes.Count;

                _changes.Add(new MutableJsonChange(path, index, value, replaceJsonElement));

                return index;
            }

            internal int AddChange(ReadOnlyMemory<byte> utf8Path, object? value, bool replaceJsonElement = false)
            {
                if (_changes == null)
                {
                    _changes = new List<MutableJsonChange>();
                }

                int index = _changes.Count;

                _changes.Add(new MutableJsonChange(utf8Path, index, value, replaceJsonElement));

                return index;
            }

            internal static string PushIndex(string path, int index)
            {
                return PushProperty(path, $"{index}");
            }

            internal static ReadOnlyMemory<byte> PushIndex(ReadOnlySpan<byte> path, int index)
            {
                // TODO: optimize int-to-utf8 conversion.
                return PushProperty(path, StringToUtf8($"{index}").Span);
            }

            internal static int PushIndex(Span<byte> path, int pathLength, int index)
            {
                // TODO: optimize int-to-utf8 conversion.
                return PushProperty(path, pathLength, StringToUtf8($"{index}").Span);
            }

            internal static string PopIndex(string path)
            {
                return PopProperty(path);
            }

            internal static ReadOnlySpan<byte> PopIndex(ReadOnlySpan<byte> path)
            {
                return PopProperty(path);
            }

            internal static int PopIndex(ReadOnlySpan<byte> path, int length)
            {
                return PopProperty(path, length);
            }

            internal static string PushProperty(string path, string value)
            {
                if (path.Length == 0)
                {
                    return value;
                }
                return $"{path}.{value}";
            }

            internal static string PushProperty(string path, ReadOnlySpan<byte> value)
            {
                string propertyName = BinaryData.FromBytes(value.ToArray()).ToString();
                if (path.Length == 0)
                {
                    return propertyName;
                }
                return $"{path}.{propertyName}";
            }

            internal static ReadOnlyMemory<byte> PushProperty(ReadOnlySpan<byte> path, ReadOnlySpan<byte> value)
            {
                int pathLength = path.Length;
                Memory<byte> propertyPath = new byte[path.Length + value.Length + 1];
                if (pathLength > 0)
                {
                    path.CopyTo(propertyPath.Span);
                    propertyPath.Span[pathLength] = Delimiter;
                    pathLength++;
                }
                value.CopyTo(propertyPath.Span.Slice(pathLength));
                pathLength += value.Length;
                return propertyPath.Slice(0, pathLength);
            }

            internal static int PushProperty(Span<byte> path, int length, ReadOnlySpan<byte> propertyName)
            {
                if (length + propertyName.Length + 1 > path.Length)
                {
                    // TODO: allocate a new buffer from ArrayPool when the path gets long.
                    throw new InvalidOperationException("Pushing the path segment would exceed the buffer length.");
                }

                if (length != 0)
                {
                    path[length] = Delimiter;
                    length++;
                }

                if (!propertyName.TryCopyTo(path.Slice(length)))
                {
                    throw new InvalidOperationException("Shouldn't have gotten here, per initial check.");
                }
                length += propertyName.Length;

                return length;
            }

            internal static string PopProperty(string path)
            {
                int lastDelimiter = path.LastIndexOf('.');
                if (lastDelimiter == -1)
                {
                    return string.Empty;
                }
                return path.Substring(0, lastDelimiter);
            }

            internal static ReadOnlySpan<byte> PopProperty(ReadOnlySpan<byte> path)
            {
                int lastDelimiter = path.LastIndexOf(Delimiter);
                if (lastDelimiter == -1)
                {
                    return Span<byte>.Empty;
                }
                return path.Slice(0, lastDelimiter);
            }

            internal static int PopProperty(ReadOnlySpan<byte> path, int length)
            {
                int lastDelimiter = path.Slice(0, length).LastIndexOf(Delimiter);
                if (lastDelimiter == -1)
                {
                    return 0;
                }
                return lastDelimiter;
            }
        }
    }
}
