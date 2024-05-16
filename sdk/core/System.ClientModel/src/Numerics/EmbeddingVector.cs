// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.ClientModel.Primitives;

#pragma warning disable CS1591 // public XML comments
public readonly struct EmbeddingVector
{
    private readonly object _vector;

    private EmbeddingVector(EmbeddingType type, object vector)
    {
        Type = type;
        _vector = vector;
    }

    public EmbeddingType Type { get; }

    public static EmbeddingVector FromInt8(ReadOnlyMemory<byte> vector)
        => new(EmbeddingType.Byte, vector);

    public static EmbeddingVector FromInt16(ReadOnlyMemory<short> vector)
        => new(EmbeddingType.Short, vector);

    public static EmbeddingVector FromFloat32(ReadOnlyMemory<float> vector)
        => new(EmbeddingType.Single, vector);

    public ReadOnlyMemory<byte> ToInt8Memory()
    {
        if (Type != EmbeddingType.Byte)
        {
            throw new InvalidOperationException("Cannot convert to ReadOnlyMemory<byte>.");
        }

        return (_vector as byte[]) ?? (ReadOnlyMemory<byte>)_vector;
    }

    public ReadOnlyMemory<short> ToInt16Memory()
    {
        if (Type != EmbeddingType.Short)
        {
            throw new InvalidOperationException("Cannot convert to ReadOnlyMemory<short>.");
        }

        return (_vector as short[]) ?? (ReadOnlyMemory<short>)_vector;
    }

    public ReadOnlyMemory<float> ToFloat32Memory()
    {
        if (Type != EmbeddingType.Single)
        {
            throw new InvalidOperationException("Cannot convert to ReadOnlyMemory<float>.");
        }

        return (_vector as float[]) ?? (ReadOnlyMemory<float>)_vector;
    }
}
#pragma warning restore CS1591 // public XML comments
