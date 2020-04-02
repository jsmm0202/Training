using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d7
{
  public  class BinderDemo
    {
        public static void ShowBinder()
        {
            Console.Clear();
            Console.WriteLine("*** Binder ***");

            TypeSerializationBinder binder = new TypeSerializationBinder("m3-07-settings-demo.{0}, m3-07-settings-demo");

            Author xavierBinder = new Author()
            {
                name = "Xavier Morera",
                courses = new string[] { "Solr", "dotTrace", "Jira" },
                happy = true,
                car = new Car
                {
                    model = "Land Rover",
                    year = 1976
                }
            };

            string json = JsonConvert.SerializeObject(xavierBinder, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                Binder = binder
            });

            Console.WriteLine(json);

        }
    }
}
