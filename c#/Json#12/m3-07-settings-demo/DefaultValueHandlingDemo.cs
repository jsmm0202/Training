using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d7
{
    public class DefaultValueHandlingDemo
    {
        public static void ShowDefaultValueHandling()
        {
            Console.Clear();
            Console.WriteLine("*** Default Value Handling ***");

            AuthorDefaults author = new AuthorDefaults();

            author.name = "Xavier Morera"; // No default
            author.courses = 4; //Default is 4
            author.happy = true; //Default is true
            author.resting = false; //Default is true
            //'state' not set, but has a default of 'Passionate about teaching'

            Console.WriteLine("- Serialize with default values but no setting");
            string authorJsonDefaults = JsonConvert.SerializeObject(author, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            });
            Console.WriteLine(authorJsonDefaults);

            Console.WriteLine("- DefaultValueHandling.Ignore");
            string authorJsonDefaultsIgnore = JsonConvert.SerializeObject(author, new JsonSerializerSettings
            {
                DefaultValueHandling = DefaultValueHandling.Ignore,
                Formatting = Formatting.Indented
            });
            Console.WriteLine(authorJsonDefaultsIgnore);


            Console.WriteLine("- DefaultValueHandling.Populate");
            string authorOnlyName = "{'name': 'Xavier Morera'}";

            AuthorDefaults authorDVH = JsonConvert.DeserializeObject<AuthorDefaults>(authorOnlyName);
            Console.WriteLine(authorDVH.state);

            AuthorDefaults authorDVHPopulate = JsonConvert.DeserializeObject<AuthorDefaults>(authorOnlyName, new JsonSerializerSettings
             {
                 DefaultValueHandling = DefaultValueHandling.Populate
             });
            Console.WriteLine(authorDVHPopulate.state);

            //Populate and Ignore can be used together with IgnoreAndPopulate
        }
    }
}
