using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m6.d21
{
    public static class QueryingJSONWithLINQDemo
    {
        public static void QueryingJSONWithLINQ(string courseViews)
        {
            Console.Clear();
            Console.WriteLine("*** LINQ to JSON Functions ***");

            JArray views = JArray.Parse(courseViews);

            //linq 
            List<int> secondsWatchedList = (from s in views select (int)s["secondsWatched"]).ToList();
            int sumWatchedList = 0;
            foreach (int s in secondsWatchedList)
            {
                sumWatchedList += s;
            }
            Console.WriteLine(sumWatchedList);

            //using functions
            int secondsWatchedSUM = views.Sum(sS => (int)sS["secondsWatched"]);
            Console.WriteLine(sumWatchedList);

            Console.WriteLine(views.Average(sS => (int)sS["secondsWatched"]));

            //linq querying and grouping
            var watchedByDay = from v in views
                               group v by v["course"] into vGroup
                               select new
                               {
                                   courseGrouping = vGroup.Key,
                                   courseCount = vGroup.Count()
                               };

            foreach (dynamic vD in watchedByDay)
            {
                Console.WriteLine(vD.courseGrouping + " " + vD.courseCount);
            }

            //build json using linq
            JArray solrEntries = new JArray(
                views.Where(c => c["course"].Value<string>() == "Solr").Select(v => new JObject{ 
                        {
                            "Course", v["course"].Value<string>()
                        },
                        {
                            "Date", v["watchedDate"].Value<DateTime>() 
                        },
                        {
                            "Seconds", v["secondsWatched"].Value<int>() 
                        }
                    }).Take(10)
                );
            Console.WriteLine(solrEntries.ToString());
        }
    }
}
