using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m4.d10
{
    public static class CustomJsonConverterDemo
    {
        public static void ShowCustomJsonConverter()
        {
            Console.Clear();
            Console.WriteLine("*** Custom JsonConverter ***");

            Author xavierAuthor = new Author()
            {
                name = "Xavier Morera",
                courses = new string[] { "Solr",
                    "JIRA", 
                    "dotTrace" 
                },
                happy = true,
                issues = null
            };

            string xavierJson = JsonConvert.SerializeObject(xavierAuthor, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                Converters = new List<JsonConverter>(new JsonConverter[]{
                    new RemoveNullsJsonConverter(typeof(Author))})
            });
            Console.WriteLine(xavierJson);

        }
    }
}
