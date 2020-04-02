using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d7
{
    public class SerializationNullValueHandlingDemo
    {
        public static void ShowSerializationNullValueHandling()
        {
            Console.Clear();
            Console.WriteLine("*** Null Value Handling ***");

            Author xavierPocoWithNullValue = new Author();

            xavierPocoWithNullValue.name = "Xavier Morera";
            xavierPocoWithNullValue.happy = true;

            JsonSerializerSettings jsonSettings = new JsonSerializerSettings { 
                Formatting = Formatting.Indented 
            };

            Console.WriteLine("- Serialize object with null values");
            string xavierNullValue = JsonConvert.SerializeObject(xavierPocoWithNullValue, jsonSettings);
            Console.WriteLine(xavierNullValue);

            Console.WriteLine("- Serialize object with setting to ignore null values");
            jsonSettings.NullValueHandling = NullValueHandling.Ignore;
            string xavierNullValueIgnore = JsonConvert.SerializeObject(xavierPocoWithNullValue, jsonSettings);
            Console.WriteLine(xavierNullValueIgnore);

        }
    }
}
