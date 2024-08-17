// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Internal;
using System.Globalization;
using System.Text;

namespace System.ClientModel.Primitives;

#pragma warning disable CS1591 // public XML comments
public static class UriBuilderExtensions
{
    public static void AppendPath(this UriBuilder uriBuilder, string value, bool escape)
    {
        Argument.AssertNotNullOrWhiteSpace(value, nameof(value));

        if (escape)
        {
            value = Uri.EscapeDataString(value);
        }

        StringBuilder pathBuilder = new(uriBuilder.Path);

        if (pathBuilder.Length > 0 &&
            pathBuilder[pathBuilder.Length - 1] == '/' &&
            value[0] == '/')
        {
            pathBuilder.Remove(pathBuilder.Length - 1, 1);
        }

        pathBuilder.Append(value);
        uriBuilder.Path = pathBuilder.ToString();
    }

    public static void AppendQuery(this UriBuilder uriBuilder, string name, string value, bool escape)
    {
        Argument.AssertNotNullOrWhiteSpace(name, nameof(name));
        Argument.AssertNotNullOrWhiteSpace(value, nameof(value));

        StringBuilder queryBuilder = new(uriBuilder.Query);

        if (queryBuilder.Length > 0)
        {
            queryBuilder.Append('&');
        }

        if (escape)
        {
            value = Uri.EscapeDataString(value);
        }

        queryBuilder.Append(name);
        queryBuilder.Append('=');
        queryBuilder.Append(value);

        uriBuilder.Query = queryBuilder.ToString();
    }

    public static void AppendQuery(this UriBuilder uriBuilder, string name, int value)
    {
        string queryValue = value.ToString("G", CultureInfo.InvariantCulture);
        uriBuilder.AppendQuery(name, queryValue, escape: true);
    }
}

#pragma warning restore CS1951 // public XML comments
