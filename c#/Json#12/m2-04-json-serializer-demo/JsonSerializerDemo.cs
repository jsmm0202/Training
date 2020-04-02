using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m2.d4
{
    public class JsonSerializerDemo
    {
        public static void ShowJsonSerializer()
        {
            Console.Clear();
            Console.WriteLine("*** JsonSerializer Demo ***");

            Author author = new Author();
            author.name = "Xavier Morera";
            author.since = new DateTime(2014, 01, 15);

            JsonSerializer serializer;

            Console.WriteLine("- No settings");
            serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(@"..\..\1-noparameters.json"))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, author);
                }
            }

            Console.WriteLine("- Indent");
            serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            using (StreamWriter sw = new StreamWriter(@"..\..\2-indented.json"))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, author);
                }
            }
            //Difference in size with indentation?

            Console.WriteLine("- Ignore nulls");
            serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            serializer.Formatting = Formatting.Indented;
            using (StreamWriter sw = new StreamWriter(@"..\..\3-ignorenulls.json"))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, author);
                }
            }

            Console.WriteLine("Curious about size difference?");
        }
    }
}
