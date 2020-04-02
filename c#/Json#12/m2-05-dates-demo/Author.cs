using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m2.d5
{
    public class Author
    {
        public string name { get; set; }

        [JsonIgnore]
        public string[] courses { get; set; }

        public DateTime since { get; set; }

        [JsonIgnore]
        public bool happy { get; set; }

        [JsonIgnore]
        public object issues { get; set; }

        [JsonIgnore]
        public Car car { get; set; }
    }

    public class Car
    {
        public string model { get; set; }
        public int year { get; set; }
    }
}

