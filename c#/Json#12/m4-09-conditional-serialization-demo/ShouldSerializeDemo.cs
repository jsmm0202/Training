using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m4.d9
{
    public static class ShouldSerializeDemo
    {
        public static void ShowShouldSerialize()
        {
            Console.Clear();
            Console.WriteLine("*** ShouldSerialize ***");

            AuthorSS xavier = new AuthorSS()
            {
                Name = "Xavier Morera",
                Courses = new string[] { "Solr", "dotTrace", "Jira" }
            };

            xavier.IsActive = true;
            string xavierActiveTrue = JsonConvert.SerializeObject(xavier, Formatting.Indented);
            Console.WriteLine(xavierActiveTrue);

            xavier.IsActive = false;
            string xavierActiveFalse = JsonConvert.SerializeObject(xavier, Formatting.Indented);
            Console.WriteLine(xavierActiveFalse);
        }
    }
}
