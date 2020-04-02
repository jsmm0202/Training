using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m9.d26
{
    public class Author
    {
        [JsonProperty("name", Required = Required.Always)]
        public string name { get; set; }

        [JsonProperty("courses", Required = Required.Default)]
        public string[] courses { get; set; }

        public DateTime since { get; set; }

        [JsonProperty("happy", Required = Required.Always)]
        public bool happy { get; set; }

        [JsonProperty("issues", Required = Required.AllowNull)]
        public object issues { get; set; }
    }

    public class Car
    {
        public string model { get; set; }
        public int year { get; set; }
    }
}

