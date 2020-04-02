using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;

namespace pluralsight.json.net.m5.d13
{
    public static class PerformanceDemo
    {
        static List<string> courses = new List<string>() { "Solr", "dotTrace", "Jira" };
        static Random randomGenerator = new Random();

        public static void ShowPerformance()
        {
            Console.Clear();
            Console.WriteLine("*** Performance Demo ***");

            int numberOfViews = 100000;
            string jsonWithViews1, jsonWithViews2;
            Console.WriteLine("Performance Test: " + numberOfViews + " Objects");

            Console.WriteLine("- Create course viewership data and serialize");
            jsonWithViews1 = CreateCourseViewsAndSerialize(numberOfViews);

            Console.WriteLine("- Create JSON manually");
            jsonWithViews2 = CreateCourseViewsAndManuallyWriteJSON(numberOfViews);

            Console.WriteLine();

            Console.WriteLine("- Deserialize using reflection");
            ReadCourseViewsDeserialize(jsonWithViews1);

            Console.WriteLine("- Deserialize manually");
            ReadCourseViewsManually(jsonWithViews1);
        }

        #region Serialize

        private static string CreateCourseViewsAndSerialize(int numberOfViews)
        {
            Stopwatch watch = new Stopwatch();

            watch.Start();
            List<CourseView> courseViews = new List<CourseView>();
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

            string jsonCourseViews = JsonConvert.SerializeObject(courseViews, Formatting.Indented);
            watch.Stop();
            Console.WriteLine("SerializeObject() took: " + watch.ElapsedMilliseconds + " ms");

            return jsonCourseViews;
        }

        private static string CreateCourseViewsAndManuallyWriteJSON(int numberOfViews)
        {
            Stopwatch watch = new Stopwatch();

            watch.Start();

            StringBuilder jsonCourseViews = new StringBuilder();
            StringWriter stringWriter = new StringWriter(jsonCourseViews);
            using (JsonWriter jsonWriter = new JsonTextWriter(stringWriter))
            {
                jsonWriter.Formatting = Formatting.Indented;
                jsonWriter.WriteStartArray();
                for (int i = 0; i < numberOfViews; i++)
                {
                    int generatedId = randomGenerator.Next(0, 10000);
                    jsonWriter.WriteStartObject();

                    jsonWriter.WritePropertyName("userId");
                    jsonWriter.WriteValue(generatedId);

                    jsonWriter.WritePropertyName("user");
                    jsonWriter.WriteValue("user_" + generatedId);

                    jsonWriter.WritePropertyName("course");
                    jsonWriter.WriteValue(courses[randomGenerator.Next(courses.Count())]);

                    jsonWriter.WritePropertyName("watchedDate");
                    jsonWriter.WriteValue(new DateTime(2015, 07, randomGenerator.Next(1, 28)));

                    jsonWriter.WritePropertyName("secondsWatched");
                    jsonWriter.WriteValue(randomGenerator.Next(1000));

                    jsonWriter.WriteEndObject();
                };
                jsonWriter.WriteEndArray();
            }

            watch.Stop();
            Console.WriteLine("Create JSON manually took: " + watch.ElapsedMilliseconds + " ms");
            //Console.WriteLine(jsonCourseViews.ToString());
            return jsonCourseViews.ToString();
        }

        #endregion

        #region Deserialize

        private static void ReadCourseViewsDeserialize(string jsonWithViews)
        {
            //Count number of minutes watched of Solr course
            Stopwatch watch = new Stopwatch();
            watch.Start();

            List<CourseView> courseViews = JsonConvert.DeserializeObject<List<CourseView>>(jsonWithViews);
            int secondsViewed = 0;

            foreach (CourseView courseView in courseViews)
            {
                if (courseView.course == "Solr")
                {
                    secondsViewed += courseView.secondsWatched;
                }
            }

            watch.Stop();
            Console.WriteLine("Calculation using Deserialize() took: " + watch.ElapsedMilliseconds + " ms. Total watched for Solr: " + secondsViewed);
        }

        private static void ReadCourseViewsManually(string jsonWithViews)
        {
            //Count number of minutes watched of Solr course
            Stopwatch watch = new Stopwatch();
            watch.Start();

            int secondsViewed = 0;
            string currentCourse = string.Empty;

            JsonTextReader reader = new JsonTextReader(new StringReader(jsonWithViews));
            while (reader.Read())
            {
                if (reader.Value != null)
                {
                    if (reader.TokenType == JsonToken.String && reader.Value.ToString() == "Solr")
                    {
                        currentCourse = "Solr";
                    }
                    if (currentCourse == "Solr" && reader.Value.ToString() == "secondsWatched")
                    {
                        reader.Read();
                        secondsViewed += int.Parse(reader.Value.ToString());
                    }
                    //Console.WriteLine("Token: {0}, Value: {1}", reader.TokenType, reader.Value);
                }
                else
                {
                    currentCourse = string.Empty;
                    //Console.WriteLine("Token: {0}", reader.TokenType);
                }

            }

            watch.Stop();
            Console.WriteLine("Calculation using JsonTextReader took: " + watch.ElapsedMilliseconds + " ms. Total watched for Solr: " + secondsViewed);

        }

        #endregion
    }
}
