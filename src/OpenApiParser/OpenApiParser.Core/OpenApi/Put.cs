using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenApiParser.Core.OpenApi
{
    public class Put
    {
        public string[] Tags { get; set; }
        public RequestBody RequestBody { get; set; }
        public Responses Responses { get; set; }
    }
}
