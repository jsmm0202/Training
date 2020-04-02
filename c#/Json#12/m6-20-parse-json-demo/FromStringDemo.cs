using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m6.d20
{
    public static class FromStringDemo
    {
        public static void ParseJSONFromString()
        {
            Console.Clear();
            Console.WriteLine("*** Parse JSON From String ***");

            string xavierJSON = @"{
  'name': 'Xavier Morera',
  'since': '2014-01-14T00:00:00',
  'happy': true,
  'issues': null,
  'car': {
    'model': 'Land Rover Series III',
    'year': 1976
  }
}
";

            string happyJSON = " { 'happy' : true }";

            string coursesJSON = @"[
    'Solr',
    'dotTrace',
    'JIRA',
    'Kanban',
]";

            JObject xavier = JObject.Parse(xavierJSON);
            JToken happy = JToken.Parse(happyJSON);
            JArray courses = JArray.Parse(coursesJSON);

            Console.WriteLine(xavier.Children().ElementAt(0));
            Console.WriteLine(xavier.Children().Last());

            Console.WriteLine((string)happy["happy"]);

            Console.WriteLine(courses.Count);
        }
    }
}
