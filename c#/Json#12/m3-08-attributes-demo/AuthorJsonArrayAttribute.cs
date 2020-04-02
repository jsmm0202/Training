using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net
{
    [JsonArray]
    public class AuthorJsonArrayAttribute
    {
        [JsonProperty]
        public string name { get; set; }

        public string[] courses { get; set; }

        public DateTime since;

        [NonSerialized]
        public bool happy;

        [JsonIgnoreAttribute]
        public object issues { get; set; }
    }

}

