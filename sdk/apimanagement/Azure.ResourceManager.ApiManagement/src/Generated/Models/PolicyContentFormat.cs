// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Format of the policyContent. </summary>
    public readonly partial struct PolicyContentFormat : IEquatable<PolicyContentFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PolicyContentFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PolicyContentFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string XmlValue = "xml";
        private const string XmlLinkValue = "xml-link";
        private const string RawXmlValue = "rawxml";
        private const string RawXmlLinkValue = "rawxml-link";

        /// <summary> The contents are inline and Content type is an XML document. </summary>
        public static PolicyContentFormat Xml { get; } = new PolicyContentFormat(XmlValue);
        /// <summary> The policy XML document is hosted on a http endpoint accessible from the API Management service. </summary>
        public static PolicyContentFormat XmlLink { get; } = new PolicyContentFormat(XmlLinkValue);
        /// <summary> The contents are inline and Content type is a non XML encoded policy document. </summary>
        public static PolicyContentFormat RawXml { get; } = new PolicyContentFormat(RawXmlValue);
        /// <summary> The policy document is not Xml encoded and is hosted on a http endpoint accessible from the API Management service. </summary>
        public static PolicyContentFormat RawXmlLink { get; } = new PolicyContentFormat(RawXmlLinkValue);
        /// <summary> Determines if two <see cref="PolicyContentFormat"/> values are the same. </summary>
        public static bool operator ==(PolicyContentFormat left, PolicyContentFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PolicyContentFormat"/> values are not the same. </summary>
        public static bool operator !=(PolicyContentFormat left, PolicyContentFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PolicyContentFormat"/>. </summary>
        public static implicit operator PolicyContentFormat(string value) => new PolicyContentFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PolicyContentFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PolicyContentFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
