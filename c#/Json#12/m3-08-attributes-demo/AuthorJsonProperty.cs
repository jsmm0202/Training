using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d8
{
    class AuthorJsonProperty
    {
        [JsonProperty(PropertyName = "AuthorName", Required = Required.Always, Order = 2)]
        public string name { get; set; }

        [JsonProperty("WhereInTheWorld", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue("Costa Rica")]
        public string location { get; set; }

        [JsonProperty(PropertyName = "AuthorCourses", Order = 3)]
        public string[] courses { get; set; }

        [JsonProperty(Order = -1)]
        public DateTime since { get; set; }

        [JsonProperty("HowIFeelToday", Order = 0)]
        public bool happy { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Include, Required = Required.AllowNull)]
        public object issues { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, ReferenceLoopHandling = ReferenceLoopHandling.Ignore)]
        public Car car { get; set; }

    }

    public class Car
    {
        public string model { get; set; }
        public int year { get; set; }
    }
}
