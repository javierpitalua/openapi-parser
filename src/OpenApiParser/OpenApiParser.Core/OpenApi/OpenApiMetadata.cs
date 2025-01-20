using System;
using System.Collections.Generic;

namespace OpenApiParser.Core.OpenApi
{
    public class OpenApiMetadata
    {
        public string Openapi { get; set; }
        public Info Info { get; set; }
        public Dictionary<string, PathItem> Paths { get; set; }
        public Components Components { get; set; }
        public Security[] Security { get; set; }
    }
}
