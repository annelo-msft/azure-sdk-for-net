// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.Json;

#nullable enable

namespace Azure.Core.Json
{
    internal readonly struct MutableJsonDictionary<T> : IDictionary<string, T>
    {
        private readonly MutableJsonElement _element;

        public MutableJsonDictionary(MutableJsonElement element)
        {
            Debug.Assert(element.ValueKind == JsonValueKind.Object);

            _element = element;
        }

        private static T ConvertTo(MutableJsonElement element)
        {
            JsonElement je = element.GetJsonElement();
            Utf8JsonReader reader = MutableJsonElement.GetReaderForElement(je);

            T? value;

            // TODO: support IModelJsonSerializable

            // TODO: we can optimize for common types like string, int, etc - don't need to
            // to use a deserializer in all cases

#if NET6_0_OR_GREATER
            value = JsonSerializer.Deserialize<T>(je);
#else
            value = JsonSerializer.Deserialize<T>(ref reader);
#endif

            if (value is null)
            {
                throw new InvalidCastException($"Unable to convert value of kind '{element.ValueKind}' to type '{typeof(T)}'.");
            }

            return value!;
        }

        public T this[string key]
        {
            get
            {
                if (!_element.TryGetProperty(key, out MutableJsonElement value))
                {
                    throw new KeyNotFoundException($"The given key '{key}' was not present in the dictionary.");
                }

                return ConvertTo(value);
            }

            set => _element.SetProperty(key, value);
        }

        // TODO: implement
        public ICollection<string> Keys => throw new NotImplementedException();

        // TODO: implement
        public ICollection<T> Values => throw new NotImplementedException();

        public int Count => _element.EnumerateObject().Count();

        ICollection<string> IDictionary<string, T>.Keys => throw new NotImplementedException();

        ICollection<T> IDictionary<string, T>.Values => throw new NotImplementedException();

        private void Add(string key, T value)
        {
            Argument.AssertNotNull(key, nameof(key));

            if (_element.TryGetProperty(key, out _))
            {
                throw new ArgumentException($"An element with the same key already exists in the MutableJsonDictionary<string,{typeof(T)}>.");
            }

            _element.SetProperty(key, value);
        }

        private void Add(KeyValuePair<string, T> item) => Add(item.Key, item.Value);

        private void Clear() => _element.Set(JsonDocument.Parse(MutableJsonDocument.EmptyJson));

        private bool Contains(KeyValuePair<string, T> item)
        {
            if (!_element.TryGetProperty(item.Key, out MutableJsonElement element))
            {
                return false;
            }

            if (item.Value == null)
            {
                return element.ValueKind == JsonValueKind.Null;
            }

            return item.Value.Equals(ConvertTo(element));
        }

        private bool ContainsKey(string key) => _element.TryGetProperty(key, out _);

        private void CopyTo(KeyValuePair<string, T>[] array, int arrayIndex)
        {
            Argument.AssertNotNull(array, nameof(array));
            Argument.AssertInRange(arrayIndex, 0, int.MaxValue, nameof(arrayIndex));

            int i = arrayIndex;
            foreach ((string Name, MutableJsonElement Value) in _element.EnumerateObject())
            {
                if (i >= array.Length)
                {
                    throw new ArgumentException("The number of elements in the dictionary is greater than the available space from 'arrayIndex' to the end of the destination array.");
                }

                array[i++] = new KeyValuePair<string, T>(Name, ConvertTo(Value));
            }
        }

        private IEnumerator<KeyValuePair<string, T>> GetEnumerator()
        {
            foreach ((string Name, MutableJsonElement Value) in _element.EnumerateObject())
            {
                yield return new KeyValuePair<string, T>(Name, ConvertTo(Value));
            }
        }

        private bool Remove(string key)
        {
            _element.RemoveProperty(key);
            return true;
        }

        private bool Remove(KeyValuePair<string, T> item)
        {
            _element.RemoveProperty(item.Key);
            return true;
        }

#if NET6_0_OR_GREATER
        public bool TryGetValue(string key, [MaybeNullWhen(false)] out T value)
#else
        public bool TryGetValue(string key, out T value)
#endif
        {
            if (_element.TryGetProperty(key, out MutableJsonElement element))
            {
                value = ConvertTo(element);
                return true;
            }

            value = default!;
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        void IDictionary<string, T>.Add(string key, T value) => Add(key, value);

        bool IDictionary<string, T>.ContainsKey(string key) => ContainsKey(key);

        bool IDictionary<string, T>.Remove(string key) => Remove(key);

        void ICollection<KeyValuePair<string, T>>.Add(KeyValuePair<string, T> item) => Add(item);

        void ICollection<KeyValuePair<string, T>>.Clear() => Clear();

        bool ICollection<KeyValuePair<string, T>>.Contains(KeyValuePair<string, T> item) => Contains(item);

        void ICollection<KeyValuePair<string, T>>.CopyTo(KeyValuePair<string, T>[] array, int arrayIndex) => CopyTo(array, arrayIndex);

        bool ICollection<KeyValuePair<string, T>>.IsReadOnly => false;

        bool ICollection<KeyValuePair<string, T>>.Remove(KeyValuePair<string, T> item) => Remove(item);

        IEnumerator<KeyValuePair<string, T>> IEnumerable<KeyValuePair<string, T>>.GetEnumerator() => GetEnumerator();
    }
}
