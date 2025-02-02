// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> An azure resource object. </summary>
    public partial class MyWorkbookResourceContent
    {
        /// <summary> Initializes a new instance of MyWorkbookResourceContent. </summary>
        public MyWorkbookResourceContent()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            ETag = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of MyWorkbookResourceContent. </summary>
        /// <param name="identity"> Identity used for BYOS. </param>
        /// <param name="id"> Azure resource Id. </param>
        /// <param name="name"> Azure resource name. </param>
        /// <param name="resourceType"> Azure resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> Resource etag. </param>
        internal MyWorkbookResourceContent(MyWorkbookManagedIdentity identity, string id, string name, string resourceType, AzureLocation? location, IDictionary<string, string> tags, IDictionary<string, string> etag)
        {
            Identity = identity;
            Id = id;
            Name = name;
            ResourceType = resourceType;
            Location = location;
            Tags = tags;
            ETag = etag;
        }

        /// <summary> Identity used for BYOS. </summary>
        public MyWorkbookManagedIdentity Identity { get; set; }
        /// <summary> Azure resource Id. </summary>
        public string Id { get; set; }
        /// <summary> Azure resource name. </summary>
        public string Name { get; set; }
        /// <summary> Azure resource type. </summary>
        public string ResourceType { get; set; }
        /// <summary> Resource location. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Resource etag. </summary>
        public IDictionary<string, string> ETag { get; }
    }
}
