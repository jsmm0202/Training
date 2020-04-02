using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m6.d21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create test data
            string courseViews = CreateCourseViews();

            JsonValuesLinqDemo.GetJsonValues();

            ReadJSONValuesLINQDemo.ReadJSONValuesLINQ(courseViews);

            QueryingJSONWithLINQDemo.QueryingJSONWithLINQ(courseViews);
        }








        private static string CreateCourseViews()
        {
            int numberOfViews = 100;
            List<CourseView> courseViews = new List<CourseView>();
            List<string> courses = new List<string>() { "Solr", "dotTrace", "JIRA" };
            Random randomGenerator = new Random();

            for (int i = 0; i < numberOfViews; i++)
            {
                int generatedId = randomGenerator.Next(0, 10000);
                CourseView courseView = new CourseView()
                {
                    userId = generatedId,
                    user = "user_" + generatedId,
                    course = courses[randomGenerator.Next(courses.Count())],
                    watchedDate = new DateTime(2015, 07, randomGenerator.Next(1, 28)),
                    secondsWatched = randomGenerator.Next(0, 1000)
                };

                courseViews.Add(courseView);
            }

            return JsonConvert.SerializeObject(courseViews, Formatting.Indented);
        }
    }
}
