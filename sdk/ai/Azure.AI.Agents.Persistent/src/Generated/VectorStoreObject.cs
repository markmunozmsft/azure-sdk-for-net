// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Agents.Persistent
{
    /// <summary> The VectorStore_object. </summary>
    public readonly partial struct VectorStoreObject : IEquatable<VectorStoreObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VectorStoreObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VectorStoreObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string VectorStoreValue = "vector_store";

        /// <summary> vector_store. </summary>
        public static VectorStoreObject VectorStore { get; } = new VectorStoreObject(VectorStoreValue);
        /// <summary> Determines if two <see cref="VectorStoreObject"/> values are the same. </summary>
        public static bool operator ==(VectorStoreObject left, VectorStoreObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VectorStoreObject"/> values are not the same. </summary>
        public static bool operator !=(VectorStoreObject left, VectorStoreObject right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VectorStoreObject"/>. </summary>
        public static implicit operator VectorStoreObject(string value) => new VectorStoreObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VectorStoreObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VectorStoreObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
