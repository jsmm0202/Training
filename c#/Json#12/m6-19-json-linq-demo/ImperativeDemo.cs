using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m6.d19
{
    public static class ImperativeDemo
    {
        public static void ImperativeCreateJSON()
        {
            Console.Clear();
            Console.WriteLine("*** Imperative ***");

            JObject xavierAuthor = new JObject();

            xavierAuthor.Add("author", "Xavier Morera");

            JArray courses = new JArray();
            JValue solr = new JValue("Solr");
            JValue jira = new JValue("Jira");
            JValue dotTrace = new JValue("dotTrace");
            JValue kanban = new JValue("Kanban");
            courses.Add(solr);
            courses.Add(jira);
            jira.AddBeforeSelf(dotTrace);
            solr.Parent.Add(kanban);
            xavierAuthor.Add("courses", courses);

            //add properties as string
            JValue dateSince = new JValue(new DateTime(2015, 01, 14));
            xavierAuthor.Add("since", dateSince);

            Console.WriteLine(xavierAuthor.ToString());

            //dynamic properties: instead of xavierAuthor.Add("happy", true); you can use
            dynamic xavierDynamic = xavierAuthor;
            xavierDynamic.happy = true;
            xavierDynamic.issues = null;

            Console.WriteLine(xavierDynamic);
        }
    }
}
