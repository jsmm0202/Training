using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d8
{
    public class JsonExtensionDataAttributeDemo
    {
        public static void ShowJsonExtensionDataAttribute()
        {
            Console.Clear();
            Console.WriteLine(" *** [JsonExtensionData] *** ");

            string authorJson = @"{
'authorName': 'Xavier Morera in JSON'
}";
           
            Console.WriteLine(authorJson);

            AuthorJsonExtension xavierJsonExtension = JsonConvert.DeserializeObject<AuthorJsonExtension>(authorJson);

            Console.WriteLine("author -> " + xavierJsonExtension.author);
            foreach (KeyValuePair<string, JToken> fld in xavierJsonExtension.unMappedFields)
            {
                Console.WriteLine("Unmapped field: " + fld.Key + " -> " + ((JValue)fld.Value).Value);
            }
        }

    }
}
