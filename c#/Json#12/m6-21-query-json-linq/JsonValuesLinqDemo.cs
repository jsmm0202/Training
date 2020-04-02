using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m6.d21
{
    public static class JsonValuesLinqDemo
    {
        public static void GetJsonValues()
        {
            Console.Clear();
            Console.WriteLine("*** LINQ to JSON ***");

            string xavierJSON = @"{
  'name': 'Xavier Morera',
  'since': '2014-01-14T00:00:00',
  'happy': true,
  'courses': [
    'Solr',
    'dotTrace',
    'JIRA',
    'Kanban',
    'Solr',
    'Solr'],
  'issues': null,
  'car': {
    'model': 'Land Rover Series III',
    'year': 1976
  }
}
";
            JObject xavierJObject = JObject.Parse(xavierJSON);

            Console.WriteLine(xavierJObject["name"]);

            Console.WriteLine(xavierJObject["since"]);

            Console.WriteLine(xavierJObject["issues"]);

            Console.WriteLine(xavierJObject["car"]["model"]);
        }
    }
}
