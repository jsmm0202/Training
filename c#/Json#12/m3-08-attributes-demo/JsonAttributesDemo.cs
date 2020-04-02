using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d8
{
    public class JsonAttributesDemo
    {
        public static void ShowAttributes()
        {
            Console.Clear();
            Console.WriteLine("*** [JsonObject] ***");

            Console.WriteLine("- No attribute");
            AuthorCoursesEnumerable xavierAuthor = new AuthorCoursesEnumerable();
            xavierAuthor.courses.Add(new Course() { courseName = "Solr", duration = 182 });
            xavierAuthor.courses.Add(new Course() { courseName = "dotTrace", duration = 183 });
            string xavierAuthorSerialized = JsonConvert.SerializeObject(xavierAuthor, Formatting.Indented);
            Console.WriteLine(xavierAuthorSerialized);

            Console.WriteLine("- With [JsonObject] attribute");
            AuthorCoursesEnumerableAttribute xavierAuthorAttribute = new AuthorCoursesEnumerableAttribute();
            xavierAuthorAttribute.courses.Add(new Course() { courseName = "Solr", duration = 180 });
            xavierAuthorAttribute.courses.Add(new Course() { courseName = "dotTrace", duration = 181 });
            string xavierAuthorSerializedAttribute = JsonConvert.SerializeObject(xavierAuthorAttribute, Formatting.Indented);
            Console.WriteLine(xavierAuthorSerializedAttribute);

            Console.WriteLine("- With [JsonArray] attribute");
            AuthorCoursesArray xavierAuthorArray = new AuthorCoursesArray();
            xavierAuthorArray.courses.Add(new Course() { courseName = "Solr", duration = 180 });
            xavierAuthorArray.courses.Add(new Course() { courseName = "dotTrace", duration = 181 });
            string xavierAuthorSerializedArray = JsonConvert.SerializeObject(xavierAuthorArray, Formatting.Indented);
            Console.WriteLine(xavierAuthorSerializedArray);

            Console.WriteLine("[JsonArray] and [JsonDictionary]");

            dictionaryWithDictionaryAttribute<string, string> dictionaryAttribute = new dictionaryWithDictionaryAttribute<string, string>();
            dictionaryWithArrayAttribute<string, string> arrayAttribute = new dictionaryWithArrayAttribute<string, string>();

            Console.WriteLine("- JsonDictionary");
            dictionaryAttribute.Add("key1", "value1");
            dictionaryAttribute.Add("key2", "value2");
            Console.WriteLine(JsonConvert.SerializeObject(dictionaryAttribute, Formatting.Indented));

            Console.WriteLine("- JsonArray");
            arrayAttribute.Add("key1", "value1");
            arrayAttribute.Add("key2", "value2");
            Console.WriteLine(JsonConvert.SerializeObject(arrayAttribute, Formatting.Indented));
        }

    }
}
