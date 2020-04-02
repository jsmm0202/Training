using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m6.d19
{
    public class FromObjectDemo
    {
        public static void FromObjectCreateJSON()
        {
            Console.Clear();
            Console.WriteLine("*** From Object ***");

            List<string> courseList = new List<string>() { "Solr", "Jira", "dotTrace", "Kanban" };

            dynamic xavierDynamic = new ExpandoObject();
            xavierDynamic.name = "Xavier Morera";
            xavierDynamic.courses = from c in courseList
                                    orderby c
                                    select new JValue(c);
            xavierDynamic.since = new DateTime(2015, 01, 14);
            xavierDynamic.happy = true;

            JObject xavierAuthor = JObject.FromObject(xavierDynamic);

            Console.WriteLine(xavierAuthor.ToString());
        }
    }
}
