using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m6.d19
{
    public static class DeclarativeDemo
    {
        public static void DeclarativeCreateJSON()
        {
            Console.Clear();
            Console.WriteLine("*** Declarative ***");

            List<string> coursesForSorting = new List<string>() { "Solr", "Jira", "dotTrace", "Kanban" };

            JObject xavierAuthor = new JObject(
                new JProperty("name", "Xavier Morera"),
                new JProperty("courses", new JArray("Solr", "Jira", "dotTrace", "Kanban")),
                new JProperty("sorted", new JArray(
                    from c in coursesForSorting
                    orderby c
                    select new JValue(c))),
                    new JProperty("happy", true)
                );

            Console.WriteLine(xavierAuthor.ToString());
        }
    }
}
