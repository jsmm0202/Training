using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m6.d22
{
    public static class SelectTokenDemo
    {
        public static void ShowSelectToken()
        {
            Console.Clear();
            Console.WriteLine("*** SelectToken ***");

            string xavierJson = CreateJson();

            string courseViews = CreateCourseViews();
            JObject courseViewsJObject = JObject.Parse(courseViews);

            //SelectToken on a property
            Console.WriteLine(courseViewsJObject.SelectToken("authorName"));

            //SelectToken on an array
            Console.WriteLine(courseViewsJObject.SelectToken("courses[0]"));

            //Get all values of an array using SelectToken
            foreach (string c in courseViewsJObject.SelectToken("courses").Select(c => (string)c).ToList())
            {
                Console.WriteLine(c);
            }

            //SelectToken on properties of members in an array
            Console.WriteLine(courseViewsJObject.SelectToken("views[0].watchedDate"));

            //And of course SelectToken with LINQ methods
            Console.WriteLine(courseViewsJObject.SelectToken("views").Sum(w => (int)w.SelectToken("secondsWatched")));

            //SelectToken with a more complex JSONPath, the last object
            Console.WriteLine(courseViewsJObject.SelectToken("$.views[-1:]"));

            //SelectToken with a condition
            IEnumerable<JToken> viewsJsonPathSelectTokens = courseViewsJObject.SelectTokens("$.views[?(@.course == 'Solr')]");
            Console.WriteLine(viewsJsonPathSelectTokens.Count());
            Console.WriteLine(viewsJsonPathSelectTokens.ElementAt(0).ToString());

            //SelectToken with recursive descent and wildcard
            foreach (JToken w in courseViewsJObject.SelectTokens("$.courses..*"))
            {
                Console.WriteLine(w.ToString());
            }

            //SelectToken for the first three seconds watched
            foreach (JToken cv in courseViewsJObject.SelectTokens("$.views[:3].secondsWatched"))
            {
                Console.WriteLine(cv.ToString());
            }

            //Combine SelectToken with LINQ
            foreach (JToken cv in courseViewsJObject.SelectTokens("$.views[:5]").Where(v => v["course"].Value<string>() == "Solr"))
            {
                Console.WriteLine(cv.ToString());
            }
        }

        private static string CreateJson()
        {
            return @"{
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

            dynamic authorCourseAndViews = new ExpandoObject();

            authorCourseAndViews.authorName = "Xavier Morera";
            authorCourseAndViews.courses = new List<string>() { "Solr", "Kanban", "JIRA" };
            authorCourseAndViews.views = courseViews;

            return JsonConvert.SerializeObject(authorCourseAndViews, Formatting.Indented);
        }
    }
}
