using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d7
{
    public class TypeNameHandlingDemo
    {
        public static void ShowTypeNameHandling()
        {
            Console.Clear();
            Console.WriteLine("*** TypeNameHandling ***");

            Author xavier = new Author();
            xavier.name = "Xavier Morera";
            xavier.courses = new string[] { "Solr", "dotTrace", "Jira" };
            xavier.car = new Car() { model = "Land Rover", year = 1976 };

            Console.WriteLine("- TypeNameHandling.All");
            string xavierTNHAll = JsonConvert.SerializeObject(xavier, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                Formatting = Formatting.Indented
            });
            Console.WriteLine(xavierTNHAll);

            Console.WriteLine("- TypeNameHandling.Arrays");
            string xavierTNHArrays = JsonConvert.SerializeObject(xavier, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Arrays,
                Formatting = Formatting.Indented
            });
            Console.WriteLine(xavierTNHArrays);

        }
    }
}
