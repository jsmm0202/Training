using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m6.d21
{
    public static class ReadJSONValuesLINQDemo
    {
        public static void ReadJSONValuesLINQ(string courseViews)
        {
            Console.Clear();
            Console.WriteLine("*** Read JSON using LINQ to JSON ***");

            JArray views = JArray.Parse(courseViews);

            Console.WriteLine("- First course view:");
            Console.WriteLine(views[0].ToString());

            Console.WriteLine("- Get properties (JValue) of first view:");
            Console.WriteLine(views[0]["userId"]);
            Console.WriteLine(views[0]["user"].Value<string>());

            int seconds = (int)views[0]["secondsWatched"];
            int otherSeconds = views[0]["secondsWatched"].Value<int>();
            Console.WriteLine(seconds + " and " + otherSeconds);

            DateTime date = (DateTime)views[0]["watchedDate"];
            Console.WriteLine(date);

            if (views.HasValues)
            {
                Console.WriteLine("Total views: " + views.Count());
            }

            Console.WriteLine("Next " + views[0].Next["userId"]);
            Console.WriteLine("Last " + views.Last["userId"]);
        }
    }
}
