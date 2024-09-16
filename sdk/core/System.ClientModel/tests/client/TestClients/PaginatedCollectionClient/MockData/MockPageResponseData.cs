// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;

namespace ClientModel.Tests.Collections;

public class MockPageResponseData
{
    public const int TotalItemCount = 16;

    public const int DefaultPageSize = 4;
    public const int DefaultOffset = 0;

    // Source of all the data
    public static IEnumerable<ValueItem> GetAllValues()
    {
        for (int i = 0; i < TotalItemCount; i++)
        {
            yield return new ValueItem(i, $"{i}");
        }
    }

    public static IEnumerable<ValueItemPage> GetPages(int? pageSize = DefaultPageSize)
    {
        pageSize ??= DefaultPageSize;

        IEnumerable<ValueItem> valueSource = GetAllValues();

        for (int i = 0; i < TotalItemCount;)
        {
            IEnumerable<ValueItem> pageItems = valueSource.Skip(i).Take(pageSize.Value);
            i += pageSize.Value;
            yield return new ValueItemPage(pageItems, i < TotalItemCount);
        }
    }
}
