// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Azure.Core.Json;

namespace Azure.Core.Dynamic
{
    public partial class DynamicData
    {
        internal class AllowList
        {
            public static void AssertAllowedType<T>(T value)
            {
                if (value == null)
                {
                    return;
                }

                if (!IsAllowedType(value.GetType(), value))
                {
                    throw new NotSupportedException($"Type is not currently supported: '{value.GetType()}'.");
                }

                // TODO: validate types in collections
            }

            public static bool IsAllowedType<T>(Type type, T value)
            {
                if (IsAllowedKnownType(type, value))
                {
                    return true;
                }

                return IsAllowedPoco(type, new HashSet<Type>());
            }

            private static bool IsAllowedKnownType<T>(Type type, T value)
            {
                return IsAllowedPrimitive(type) ||
                    IsAllowedArray(type) ||
                    IsAllowedCollection(type, value) ||
                    IsAllowedInterface(type) ||

                    // TODO: separate out non-primitive values?
                    type == typeof(JsonElement) ||
                    type == typeof(JsonDocument) ||
                    type == typeof(MutableJsonDocument) ||
                    type == typeof(MutableJsonElement) ||

                    // TODO: We'll want to remove this dependency
                    type == typeof(DynamicData) ||

                    // TODO: Keep this?
                    type == typeof(object[])
                    ;
            }

            private static bool IsAllowedPrimitive(Type type)
            {
                return
                    type.IsPrimitive ||
                    type == typeof(decimal) ||
                    type == typeof(string) ||
                    type == typeof(DateTime) ||
                    type == typeof(DateTimeOffset) ||
                    type == typeof(TimeSpan) ||
                    type == typeof(Uri) ||
                    type == typeof(Guid) ||
                    type == typeof(ETag);
            }

            private static bool IsAllowedArray(Type type)
            {
                if (type.IsArray)
                {
                    Type? elementType = type.GetElementType();
                    return elementType != null && IsAllowedType(elementType);
                }

                return false;
            }

            private static bool IsAllowedCollection<T>(Type type, T value)
            {
                if (type == typeof(object[]))
                {
                    object[] objects = (object[])(object)value!;
                    foreach (object obj in objects)
                    {
                        if (!IsAllowedObject(obj))
                        {
                            return false;
                        }
                    }

                    return true;
                }

                if (type == typeof(Dictionary<,>))
                {
                    Type[] types = type.GetGenericArguments();

                    if (types[0] == typeof(object))
                    {
                        IDictionary dict = (IDictionary)value!;
                        foreach (object obj in dict.Keys)
                        {
                            if (!IsAllowedObject(obj))
                            {
                                return false;
                            }
                        }
                    }

                    if (types[1] == typeof(object))
                    {
                        IDictionary dict = (IDictionary)value;
                        foreach (object obj in dict.Values)
                        {
                            if (!IsAllowedObject(obj))
                            {
                                return false;
                            }
                        }
                    }
                }

                // TODO: Collection support
                return
                    type == typeof(Dictionary<string, object>) ||
                    type == typeof(List<int>);
            }

            private static bool IsAllowedObject(object value)
            {
                if (value == null)
                {
                    return true;
                }

                return IsAllowedType(value.GetType());
            }

            private static bool IsAllowedInterface(Type type)
            {
                // TODO: Interface support
                return
                    type == typeof(IEnumerable<bool>) ||
                    type == typeof(IEnumerable<int>);
            }

            private static bool IsAllowedPoco(Type type, HashSet<Type> ancestorTypes)
            {
                if (!HasPublicParameterlessConstructor(type) && !IsAnonymousType(type))
                {
                    return false;
                }

                foreach (PropertyInfo property in type.GetProperties())
                {
                    if (!property.CanRead)
                    {
                        return false;
                    }

                    if (!property.CanWrite && !IsAnonymousType(type))
                    {
                        return false;
                    }

                    if (IsAllowedKnownType(property.PropertyType))
                    {
                        continue;
                    }

                    // Trust but verify
                    if (ancestorTypes.Contains(property.PropertyType))
                    {
                        continue;
                    }

                    // Recurse
                    ancestorTypes.Add(type);
                    if (!IsAllowedPoco(property.PropertyType, ancestorTypes))
                    {
                        return false;
                    }
                }

                return true;
            }

            private static bool HasPublicParameterlessConstructor(Type type)
            {
                return type.GetConstructor(Type.EmptyTypes) != null;
            }

            private static bool IsAnonymousType(Type type)
            {
                return
                    type.Namespace == null &&
                    Attribute.IsDefined(type, typeof(CompilerGeneratedAttribute), false);
            }
        }
    }
}
