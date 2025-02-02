// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace Azure.Communication.JobRouter
{
    public partial class RouterJobItem
    {
        internal static RouterJobItem DeserializeRouterJobItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RouterJob job = default;
            string etag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("job"u8))
                {
                    job = RouterJob.DeserializeRouterJob(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
            }
            return new RouterJobItem(job, etag);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RouterJobItem FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRouterJobItem(document.RootElement);
        }
    }
}
