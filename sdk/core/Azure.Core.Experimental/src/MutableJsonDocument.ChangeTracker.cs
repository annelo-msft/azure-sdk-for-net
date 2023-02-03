// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Buffers;
using System.Collections.Generic;

namespace Azure.Core.Dynamic
{
    public partial class MutableJsonDocument
    {
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

            internal static string PopIndex(string path)
            {
                return PopProperty(path);
            }

            internal static ReadOnlySpan<byte> PopIndex(ReadOnlySpan<byte> path)
            {
                return PopProperty(path);
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

            internal static void PushProperty(Span<byte> path, Span<byte> name, ref int pathLength)
            {
                if (pathLength != 0)
                {
                    AppendPath(path, Utf8Delimiter, ref pathLength);
                }

                AppendPath(path, name, ref pathLength);
            }

            internal static void AppendPath(Span<byte> path, byte value, ref int pathLength)
            {

            }

            internal static void AppendPath(Span<byte> path, Span<byte> value, ref int pathLength)
            {
                if (value.TryCopyTo(path.Slice(pathLength)))
                {
                    pathLength += value.Length;
                    return;
                }

                //// We need to reallocate the Span
                //// TODO: use pooled buffer
                //Span<byte> newPath = new byte[path.Length * 2];
                //path.Slice(0, pathLength).CopyTo(newPath);
                //path = newPath;

                Span<byte> newPath = ArrayPool<byte>.Rent(path.Length * 2);
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
                int lastDelimiter = path.LastIndexOf(Utf8Delimiter);
                if (lastDelimiter == -1)
                {
                    return Span<byte>.Empty;
                }
                return path.Slice(0, lastDelimiter);
            }
        }
    }
}
