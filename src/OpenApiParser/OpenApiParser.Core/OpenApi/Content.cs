using Newtonsoft.Json;

namespace OpenApiParser.Core.OpenApi
{
    public class Content
    {
        [JsonProperty("application/json")]
        public Schema ApplicationJson { get; set; }

        [JsonProperty("text/json")]
        public Schema TextJson { get; set; }

        [JsonProperty("application/*+json")]
        public Schema ApplicationPlusJson { get; set; }
    }
}
