using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d8
{
    [JsonDictionary]
    public class dictionaryWithDictionaryAttribute<K, V> : Dictionary<K, V>
    {
        public string Name { get; set; }

    }

    [JsonArray]
    public class dictionaryWithArrayAttribute<K, V> : Dictionary<K, V>
    {
        public string Name { get; set; }

    }
}
