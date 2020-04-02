using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d8
{
    public class JsonConstructorAttributeDemo
    {
        public static void ShowJsonConstructorAttribute()
        {
            Console.Clear();
            Console.WriteLine("*** [JsonConstructor] ***");

            string authorJson = @"{ 
                                'authorName': 'Xavier Morera As Parameter'
                                }";

            AuthorConstructor xavierNoAttribute = JsonConvert.DeserializeObject<AuthorConstructor>(authorJson);
            Console.WriteLine(xavierNoAttribute.author);

            AuthorConstructorAttribute xavierWithAttribute = JsonConvert.DeserializeObject<AuthorConstructorAttribute>(authorJson);
            Console.WriteLine(xavierWithAttribute.author);
        }
    }
}
