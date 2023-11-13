// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ComponentModel;
using System.Threading;

namespace System.ClientModel;

public class KeyCredential
{
    private string _key;

    /// <summary>
    /// Key used to authenticate to an Azure service.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string Key
    {
        get => Volatile.Read(ref _key);
        private set => Volatile.Write(ref _key, value);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="KeyCredential"/> class.
    /// </summary>
    /// <param name="key">Key to use to authenticate with the Azure service.</param>
    /// <exception cref="System.ArgumentNullException">
    /// Thrown when the <paramref name="key"/> is null.
    /// </exception>
    /// <exception cref="System.ArgumentException">
    /// Thrown when the <paramref name="key"/> is empty.
    /// </exception>
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
    public KeyCredential(string key) => Update(key);
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.

    /// <summary>
    /// Updates the service key.
    /// This is intended to be used when you've regenerated your service key
    /// and want to update long lived clients.
    /// </summary>
    /// <param name="key">Key to authenticate the service against.</param>
    /// <exception cref="System.ArgumentNullException">
    /// Thrown when the <paramref name="key"/> is null.
    /// </exception>
    /// <exception cref="System.ArgumentException">
    /// Thrown when the <paramref name="key"/> is empty.
    /// </exception>
    public void Update(string key)
    {
        if (key is null) throw new ArgumentNullException(nameof(key));
        if (key.Length == 0) throw new ArgumentException("Value cannot be an empty string.", nameof(key));

        Key = key;
    }
}
