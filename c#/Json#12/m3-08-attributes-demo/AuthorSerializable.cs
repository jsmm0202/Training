using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d8
{
   
    public class AuthorSerializable
    {
        public string name;

        [JsonProperty]
        public string fieldA;

        [JsonIgnore]
        public string fieldB { get; set; }

        //[Serializable]
        public string fieldC { get; set; }

        //[NonSerialized]
        public string fieldyD { get; set; }

        public string fieldE { get; set; }

        public string fieldF { get; set; }

        public string fieldG { get; set; }
    }

   
}
