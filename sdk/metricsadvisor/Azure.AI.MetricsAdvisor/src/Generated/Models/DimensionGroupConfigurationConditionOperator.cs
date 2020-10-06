// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary>
    /// condition operator
    /// 
    /// 
    /// 
    /// should be specified when combining multiple detection conditions.
    /// </summary>
    internal readonly partial struct DimensionGroupConfigurationConditionOperator : IEquatable<DimensionGroupConfigurationConditionOperator>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DimensionGroupConfigurationConditionOperator"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DimensionGroupConfigurationConditionOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ANDValue = "AND";
        private const string ORValue = "OR";

        /// <summary> AND. </summary>
        public static DimensionGroupConfigurationConditionOperator AND { get; } = new DimensionGroupConfigurationConditionOperator(ANDValue);
        /// <summary> OR. </summary>
        public static DimensionGroupConfigurationConditionOperator OR { get; } = new DimensionGroupConfigurationConditionOperator(ORValue);
        /// <summary> Determines if two <see cref="DimensionGroupConfigurationConditionOperator"/> values are the same. </summary>
        public static bool operator ==(DimensionGroupConfigurationConditionOperator left, DimensionGroupConfigurationConditionOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DimensionGroupConfigurationConditionOperator"/> values are not the same. </summary>
        public static bool operator !=(DimensionGroupConfigurationConditionOperator left, DimensionGroupConfigurationConditionOperator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DimensionGroupConfigurationConditionOperator"/>. </summary>
        public static implicit operator DimensionGroupConfigurationConditionOperator(string value) => new DimensionGroupConfigurationConditionOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DimensionGroupConfigurationConditionOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DimensionGroupConfigurationConditionOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}