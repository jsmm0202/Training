using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d8
{
    public class AuthorJsonExtension
    {
        public string author { get; set; }

        public DateTime since { get; set; }

        public bool happy { get; set; }

        [JsonExtensionData]
        public IDictionary<string, JToken> unMappedFields;
    }
}
