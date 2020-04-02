using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m6.d20
{
    public static class FromStreamDemo
    {
        public static void ParseJSONFromStream()
        {
            Console.Clear();
            Console.WriteLine("***  Parse JSON From Stream ***");

            JObject xavier;
            using (StreamReader reader = new StreamReader(@".\..\..\xavier.json"))
            {
                xavier = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
            }

            Console.WriteLine(xavier.First);
            Console.WriteLine(xavier.SelectToken("name"));
        }
    }
}
