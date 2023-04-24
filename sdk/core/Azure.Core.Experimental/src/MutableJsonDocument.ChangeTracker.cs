// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace Azure.Core.Json
{
    public partial class MutableJsonDocument
    {
        private List<MutableJsonChange>? _changes;

        internal const char Delimiter = (char)1;
        private static ReadOnlyMemory<byte> Utf8Delimiter = Encoding.UTF8.GetBytes(new char[] { (char)1 }).AsMemory();

        internal bool HasChanges => _changes != null && _changes.Count > 0;

        internal bool AncestorChanged(string path, int highWaterMark)
        {
            if (_changes == null)
            {
                return false;
            }

            bool changed = false;

            // Check for changes to ancestor elements
            while (!changed && path.Length > 0)
            {
                path = PopProperty(path);
                changed = TryGetChange(path, highWaterMark, out MutableJsonChange change);
            }

            return changed;
        }

        internal bool DescendantChanged(string path, int highWaterMark)
        {
            if (_changes == null)
            {
                return false;
            }

            bool changed = false;

            if (path.Length > 0)
            {
                path += Delimiter;
            }

            for (int i = _changes!.Count - 1; i > highWaterMark; i--)
            {
                var c = _changes[i];
                if (c.Path.StartsWith(path, StringComparison.Ordinal))
                {
                    return true;
                }
            }

            return changed;
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
                var c = _changes[i];
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
            _changes ??= new List<MutableJsonChange>();

            int index = _changes.Count;

            _changes.Add(new MutableJsonChange()
            {
                Path = path,
                Value = value,
                Index = index,
                ReplacesJsonElement = replaceJsonElement
            });

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

            return string.Concat(path, Delimiter, value);
        }

        //internal static void PushProperty(Span<byte> path, Span<byte> name, ref int pathLength)
        //{
        //    if (pathLength != 0)
        //    {
        //        AppendPath(path, Utf8Delimiter.Span, ref pathLength);
        //    }

        //    AppendPath(path, name, ref pathLength);
        //}

        //internal static void AppendPath(Span<byte> path, ReadOnlySpan<byte> value, ref int pathLength)
        //{
        //    if (value.TryCopyTo(path.Slice(pathLength)))
        //    {
        //        pathLength += value.Length;
        //        return;
        //    }

        //    //// We need to reallocate the Span
        //    //// TODO: use pooled buffer
        //    //Span<byte> newPath = new byte[path.Length * 2];
        //    //path.Slice(0, pathLength).CopyTo(newPath);
        //    //path = newPath;

        //    Span<byte> newPath = ArrayPool<byte>.Rent(path.Length * 2);
        //}

        internal static string PushProperty(string path, ReadOnlySpan<byte> value)
        {
            string propertyName = BinaryData.FromBytes(value.ToArray()).ToString();

            if (path.Length == 0)
            {
                return propertyName;
            }

            return string.Concat(path, Delimiter, propertyName);
        }

        internal static string PopProperty(string path)
        {
            int lastDelimiter = path.LastIndexOf(Delimiter);

            if (lastDelimiter == -1)
            {
                return string.Empty;
            }

            return path.Substring(0, lastDelimiter);
        }

        internal static ReadOnlySpan<byte> PopProperty(ReadOnlySpan<byte> path)
        {
            int lastDelimiter = path.LastIndexOf(Utf8Delimiter.Span);
            if (lastDelimiter == -1)
            {
                return Span<byte>.Empty;
            }
            return path.Slice(0, lastDelimiter);
        }
    }
}
