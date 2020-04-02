using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d8
{
    public class JsonPropertyAttributeDemo
    {
        public static void ShowJsonPropertyAttribute()
        {
            Console.Clear();
            Console.WriteLine("*** JsonProperty ***");

            AuthorJsonProperty author = new AuthorJsonProperty();
            try
            {
                Console.WriteLine(JsonConvert.SerializeObject(author));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Serializing Object: " + ex.Message);
            }

            author.name = "Xavier Morera";
            Console.WriteLine(JsonConvert.SerializeObject(author, Formatting.Indented));

            author.location = "Costa Rica";
            Console.WriteLine(JsonConvert.SerializeObject(author, Formatting.Indented));
        }

    }
}
