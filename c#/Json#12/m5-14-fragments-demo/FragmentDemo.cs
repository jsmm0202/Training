using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m5.d14
{
    public static class FragmentDemo
    {
        public static void ShowFragments()
        {
            Console.Clear();
            Console.WriteLine("*** JSON Fragments ***");
            //Extract courses and minutes viewed
            List<UserInteraction> userLogs = GetTestData();
            string bigLog = JsonConvert.SerializeObject(userLogs);

            //Used to generate sample file when required
            //System.IO.File.WriteAllText(@"..\..\..\m5-18-memory-demo\logs.json", bigLog);

            Console.WriteLine("- Deserialize with JSON fragments");
            JArray logs = JArray.Parse(bigLog);
            int fragmentCount = 0;
            foreach (JObject logEntry in logs)
            {
                CourseView course = logEntry["courseView"].ToObject<CourseView>();
                fragmentCount += course.secondsWatched;

                //Another way would be:
                //int secondsWatched = logEntry["courseView"]["secondsWatched"].Value<int>();
            }
            Console.Write("Total seconds watched:" + fragmentCount);
        }

        private static List<UserInteraction> GetTestData()
        {
            List<UserInteraction> userLogs = new List<UserInteraction>();
            for (int i = 0; i < 10000; i++)
            {
                UserInteraction uI = new UserInteraction();
                uI.GenerateFakeLog();
                userLogs.Add(uI);
            }
            return userLogs;
        }
    }
}
