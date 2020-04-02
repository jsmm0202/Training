using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace pluralsight.json.net.m2.d3
{
    public class ObjectReferencesDemo
    {
        public static void ShowObjectReferences()
        {
            Console.Clear();
            Console.Write("*** Object References Demo ***");
            Author xavier = new Author() { name = "Xavier Morera", courses = new string[] { "Solr", "dotTrace", "Jira" } };
            Author peter = new Author() { name = "Peter Shaw", courses = new string[] { "HTML5 Layouts" } };
            Author jason = new Author() { name = "Jason Alba", courses = new string[] { "Management 101", "Designing a Killer Job Search Strategy", "Leadership: Getting Started " } };
            Author simon = new Author() { name = "Simon Robinson", courses = new string[] { "C# Collections Fundamentals", "C# Concurrent Collections", "C# Equality and Comparisons" } };

            xavier.favoriteAuthors = new List<Author>() { xavier, jason, peter, simon, jason };
            string xavierJson = JsonConvert.SerializeObject(xavier, new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
            Console.WriteLine(xavierJson);
        }
    }
}
