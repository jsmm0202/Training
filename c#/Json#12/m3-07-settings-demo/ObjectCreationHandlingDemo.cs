using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d7
{
    public class ObjectCreationHandlingDemo
    {
        public static void ShowObjectCreationHandling()
        {
            Console.Clear();
            Console.WriteLine("*** ObjectCreationHandling ***");

            string xavierJson = "{ 'name': 'Xavier', 'courses': ['Solr', 'dotTrace', 'Jira']}";

            Console.WriteLine("- No setting");
            AuthorObjectCreationHandling xavierOBH = JsonConvert.DeserializeObject<AuthorObjectCreationHandling>(xavierJson);
            Console.WriteLine(xavierOBH.courses.Count());
            Console.WriteLine(string.Join(",", xavierOBH.courses));

            Console.WriteLine("- ObjectCreationHandling.Replace");
            AuthorObjectCreationHandling xavierOBHReplace = JsonConvert.DeserializeObject<AuthorObjectCreationHandling>(xavierJson, new JsonSerializerSettings
            {
                ObjectCreationHandling = ObjectCreationHandling.Replace
            });
            Console.WriteLine(xavierOBHReplace.courses.Count());
            Console.WriteLine(string.Join(",", xavierOBHReplace.courses));
        }
    }
}
