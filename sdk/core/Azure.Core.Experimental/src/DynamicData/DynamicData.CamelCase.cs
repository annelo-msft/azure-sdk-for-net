// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.Core.Dynamic
{
    public partial class DynamicData
    {
        // From: https://github.com/dotnet/runtime/blob/bda1f6c691c6517259a75e969f408e242dbc8103/src/libraries/System.Text.Json/Common/JsonCamelCaseNamingPolicy.cs
        private static string ConvertToCamelCase(string name)
        {
            if (string.IsNullOrEmpty(name) || !char.IsUpper(name[0]))
            {
                return name;
            }

#if NETCOREAPP
            return string.Create(name.Length, name, (chars, name) =>
            {
                name
#if !NETCOREAPP
                .AsSpan()
#endif
                .CopyTo(chars);
                FixCasing(chars);
            });
#else
            char[] chars = name.ToCharArray();
            FixCasing(chars);
            return new string(chars);
#endif
        }

        private static void FixCasing(Span<char> chars)
        {
            for (int i = 0; i < chars.Length; i++)
            {
                if (i == 1 && !char.IsUpper(chars[i]))
                {
                    break;
                }

                bool hasNext = (i + 1 < chars.Length);

                // Stop when next char is already lowercase.
                if (i > 0 && hasNext && !char.IsUpper(chars[i + 1]))
                {
                    // If the next char is a space, lowercase current char before exiting.
                    if (chars[i + 1] == ' ')
                    {
                        chars[i] = char.ToLowerInvariant(chars[i]);
                    }

                    break;
                }

                chars[i] = char.ToLowerInvariant(chars[i]);
            }
        }
    }
}
