//using Newtonsoft.Json;

//namespace OpenApiParser.Core.OpenApi
//{
//    public class OpenApiMetadata
//    {
//        public string Openapi { get; set; }
//        public Info Info { get; set; }
//        public Dictionary<string, PathItem> Paths { get; set; }
//        public Components Components { get; set; }
//        public Security[] Security { get; set; }
//    }

//    public class Info
//    {
//        public string Title { get; set; }
//        public string Description { get; set; }
//        public Contact Contact { get; set; }
//        public License License { get; set; }
//        public string Version { get; set; }
//    }

//    public class Contact
//    {
//        public string Name { get; set; }
//        public string Email { get; set; }
//    }

//    public class License
//    {
//        public string Name { get; set; }
//        public string Url { get; set; }
//    }

//    public class PathItem
//    {
//        public Post Post { get; set; }
//        public Get Get { get; set; }
//        public Put Put { get; set; }
//    }

//    public class Post
//    {
//        public string[] Tags { get; set; }
//        public RequestBody RequestBody { get; set; }
//        public Responses Responses { get; set; }
//    }

//    public class Get
//    {
//        public string[] Tags { get; set; }
//        public Parameter[] Parameters { get; set; }
//        public Responses Responses { get; set; }
//    }

//    public class Put
//    {
//        public string[] Tags { get; set; }
//        public RequestBody RequestBody { get; set; }
//        public Responses Responses { get; set; }
//    }

//    public class RequestBody
//    {
//        public Content Content { get; set; }
//    }

//    public class Content
//    {
//        [JsonProperty("application/json")]
//        public Schema ApplicationJson { get; set; }

//        [JsonProperty("text/json")]
//        public Schema TextJson { get; set; }

//        [JsonProperty("application/*+json")]
//        public Schema ApplicationPlusJson { get; set; }
//    }

//    public class Schema
//    {
//        public string Ref { get; set; }
//    }

//    public class Responses
//    {
//        public ResponseItem Ok { get; set; }
//    }

//    public class ResponseItem
//    {
//        public string Description { get; set; }
//        public Content Content { get; set; }
//    }

//    public class Parameter
//    {
//        public string Name { get; set; }
//        public string In { get; set; }
//        public Schema Schema { get; set; }
//    }

//    public class Components
//    {
//        public Schemas Schemas { get; set; }
//    }

//    public class Schemas
//    {
//        public Schema CreateClienteRequest { get; set; }
//        public Schema DeleteClienteRequest { get; set; }
//        // Add other schema definitions as needed
//    }

//    public class Security
//    {
//        public string[] Bearer { get; set; }
//    }

//    public class OpenApiParser
//    {
//        public static OpenApiMetadata ParseOpenApiJson(string jsonContent)
//        {
//            try
//            {
//                return JsonConvert.DeserializeObject<OpenApiMetadata>(jsonContent);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Error parsing OpenAPI JSON: {ex.Message}");
//                return null;
//            }
//        }

//        public static void DisplayApiInfo(OpenApiMetadata apiMetadata)
//        {
//            if (apiMetadata != null)
//            {
//                Console.WriteLine("OpenAPI Version: " + apiMetadata.Openapi);
//                Console.WriteLine("Title: " + apiMetadata.Info.Title);
//                Console.WriteLine("Description: " + apiMetadata.Info.Description);
//                Console.WriteLine("Contact: " + apiMetadata.Info.Contact.Name + " (" + apiMetadata.Info.Contact.Email + ")");
//                Console.WriteLine("License: " + apiMetadata.Info.License.Name + " - " + apiMetadata.Info.License.Url);
//                Console.WriteLine("Version: " + apiMetadata.Info.Version);
//            }
//        }

//        public static void DisplayPaths(OpenApiMetadata apiMetadata)
//        {
//            if (apiMetadata?.Paths != null)
//            {
//                foreach (var path in apiMetadata.Paths)
//                {
//                    Console.WriteLine($"Path: {path.Key}");
//                    var pathItem = path.Value;
//                    Console.WriteLine($"  GET: {pathItem.Get?.Tags}");
//                    Console.WriteLine($"  POST: {pathItem.Post?.Tags}");
//                    Console.WriteLine($"  PUT: {pathItem.Put?.Tags}");
//                }
//            }
//        }
//    }
//}
