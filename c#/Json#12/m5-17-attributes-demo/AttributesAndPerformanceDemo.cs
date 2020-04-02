using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m5.d17
{
    public static class AttributesAndPerformanceDemo
    {
        public static void ShowAttributesAndPerformance()
        {
            Console.Clear();
            Console.WriteLine("*** Attributes && Performance ***");
            List<UserInteraction> userLogs = GetTestData();
            List<UserInteractionNoAttributes> userLogsNoAttributes;
            userLogsNoAttributes = CopyTestData(userLogs);

            Console.WriteLine("- SerializeObject() with JsonIgnoreAttribute");
            Stopwatch watch = new Stopwatch();
            watch.Start();
            string userLogsJSON = JsonConvert.SerializeObject(userLogs);
            watch.Stop();
            Console.WriteLine("Time with attributes: " + watch.ElapsedMilliseconds);

            Console.WriteLine("- SerializeObject() with out attributes");
            Stopwatch watchNoAttributes = new Stopwatch();
            watchNoAttributes.Start();
            string userLogsJSONNoAttributes = JsonConvert.SerializeObject(userLogsNoAttributes);
            watchNoAttributes.Stop();
            Console.WriteLine("Time without attributes: " + watchNoAttributes.ElapsedMilliseconds);

            Console.WriteLine("");
            userLogs = new List<UserInteraction>();
            userLogsNoAttributes = new List<UserInteractionNoAttributes>();

            Console.WriteLine("- DeserializeObject() with JsonIgnoreAttribute");
            watch.Reset();
            watch.Start();
            userLogs = JsonConvert.DeserializeObject<List<UserInteraction>>(userLogsJSON);
            watch.Stop();
            Console.WriteLine("Time with attributes: " + watch.ElapsedMilliseconds);

            Console.WriteLine("- DeserializeObject() without attributes");
            watchNoAttributes.Reset();
            watchNoAttributes.Start();
            userLogsNoAttributes = JsonConvert.DeserializeObject<List<UserInteractionNoAttributes>>(userLogsJSONNoAttributes);
            watchNoAttributes.Stop();
            Console.WriteLine("Time without attributes: " + watchNoAttributes.ElapsedMilliseconds);
        }

        private static List<UserInteractionNoAttributes> CopyTestData(List<UserInteraction> userLogs)
        {
            List<UserInteractionNoAttributes> userLogsNoAttribute = new List<UserInteractionNoAttributes>();
            foreach (UserInteraction uI in userLogs)
            {
                UserInteractionNoAttributes uIn = new UserInteractionNoAttributes()
                {
                    ip = uI.ip,
                    cookie = uI.cookie,
                    userAgent = uI.userAgent,
                    acceptLanguage = uI.acceptLanguage,
                    processedBy = uI.processedBy.ToList(),
                    courseView = new CourseViewNoAttributes()
                        {
                            userId = uI.courseView.userId,
                            user = uI.courseView.user,
                            course = uI.courseView.course,
                            watchedDate = uI.courseView.watchedDate,
                            secondsWatched = uI.courseView.secondsWatched
                        },
                    privateImportantData = uI.privateImportantData
                };
                userLogsNoAttribute.Add(uIn);
            }

            return userLogsNoAttribute;
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
