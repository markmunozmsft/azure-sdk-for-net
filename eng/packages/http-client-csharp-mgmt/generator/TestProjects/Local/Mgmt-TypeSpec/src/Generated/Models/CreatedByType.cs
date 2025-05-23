// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using MgmtTypeSpec;

namespace MgmtTypeSpec.Models
{
    /// <summary> The kind of entity that created the resource. </summary>
    public readonly partial struct CreatedByType : IEquatable<CreatedByType>
    {
        private readonly string _value;
        /// <summary> The entity was created by a user. </summary>
        private const string UserValue = "User";
        /// <summary> The entity was created by an application. </summary>
        private const string ApplicationValue = "Application";
        /// <summary> The entity was created by a managed identity. </summary>
        private const string ManagedIdentityValue = "ManagedIdentity";
        /// <summary> The entity was created by a key. </summary>
        private const string KeyValue = "Key";

        /// <summary> Initializes a new instance of <see cref="CreatedByType"/>. </summary>
        /// <param name="value"> The value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CreatedByType(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        /// <summary> The entity was created by a user. </summary>
        public static CreatedByType User { get; } = new CreatedByType(UserValue);

        /// <summary> The entity was created by an application. </summary>
        public static CreatedByType Application { get; } = new CreatedByType(ApplicationValue);

        /// <summary> The entity was created by a managed identity. </summary>
        public static CreatedByType ManagedIdentity { get; } = new CreatedByType(ManagedIdentityValue);

        /// <summary> The entity was created by a key. </summary>
        public static CreatedByType Key { get; } = new CreatedByType(KeyValue);

        /// <summary> Determines if two <see cref="CreatedByType"/> values are the same. </summary>
        /// <param name="left"> The left value to compare. </param>
        /// <param name="right"> The right value to compare. </param>
        public static bool operator ==(CreatedByType left, CreatedByType right) => left.Equals(right);

        /// <summary> Determines if two <see cref="CreatedByType"/> values are not the same. </summary>
        /// <param name="left"> The left value to compare. </param>
        /// <param name="right"> The right value to compare. </param>
        public static bool operator !=(CreatedByType left, CreatedByType right) => !left.Equals(right);

        /// <summary> Converts a string to a <see cref="CreatedByType"/>. </summary>
        /// <param name="value"> The value. </param>
        public static implicit operator CreatedByType(string value) => new CreatedByType(value);

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CreatedByType other && Equals(other);

        /// <inheritdoc/>
        public bool Equals(CreatedByType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        /// <inheritdoc/>
        public override string ToString() => _value;
    }
}
