using Newtonsoft.Json;
using OpenApiParser.Core.OpenApi;
using System;

namespace OpenApiParser.Core
{
    public static class Metadata
    {
        public static OpenApiMetadata ParseOpenApiJson(string jsonContent)
        {
            try
            {
                return JsonConvert.DeserializeObject<OpenApiMetadata>(jsonContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error parsing OpenAPI JSON: {ex.Message}");
                throw;
            }
        }

        public static void DisplayApiInfo(OpenApiMetadata apiMetadata)
        {
            if (apiMetadata != null)
            {
                Console.WriteLine("OpenAPI Version: " + apiMetadata.Openapi);
                Console.WriteLine("Title: " + apiMetadata.Info.Title);
                Console.WriteLine("Description: " + apiMetadata.Info.Description);
                Console.WriteLine("Contact: " + apiMetadata.Info.Contact.Name + " (" + apiMetadata.Info.Contact.Email + ")");
                Console.WriteLine("License: " + apiMetadata.Info.License.Name + " - " + apiMetadata.Info.License.Url);
                Console.WriteLine("Version: " + apiMetadata.Info.Version);
            }
        }

        public static void DisplayPaths(OpenApiMetadata apiMetadata)
        {
            if (apiMetadata?.Paths != null)
            {
                foreach (var path in apiMetadata.Paths)
                {
                    Console.WriteLine($"Path: {path.Key}");
                    var pathItem = path.Value;
                    Console.WriteLine($"  GET: {pathItem.Get?.Tags}");
                    Console.WriteLine($"  POST: {pathItem.Post?.Tags}");
                    Console.WriteLine($"  PUT: {pathItem.Put?.Tags}");
                }
            }
        }
    }
}
