// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Describes an available API Management SKU. </summary>
    internal partial class ResourceSku
    {
        /// <summary> Initializes a new instance of ResourceSku. </summary>
        internal ResourceSku()
        {
        }

        /// <summary> Initializes a new instance of ResourceSku. </summary>
        /// <param name="name"> Name of the Sku. </param>
        internal ResourceSku(ApiManagementServiceSkuType? name)
        {
            Name = name;
        }

        /// <summary> Name of the Sku. </summary>
        public ApiManagementServiceSkuType? Name { get; }
    }
}
