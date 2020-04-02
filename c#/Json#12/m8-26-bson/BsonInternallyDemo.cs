using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System.IO;

namespace pluralsight.json.net.m8.d25
{
    class BsonInternallyDemo
    {
        public static void ShowBsonInternally()
        {
            Console.Clear();
            Console.WriteLine("*** BSON Internally ***");

            //http://bsonspec.org/spec.html

            string simpleJson = @"{
                                    'name': 'Xavier',
                                    'total': 4,
                                    'courses': ['Solr', 'JIRA', 'dotTrace'],
                                    'happy': true,
                                    'tired': false,
                                    'since': '2014-01-14T00:00:00',
                                    'issues': null,
                                    'car': {
                                                'year': 1976,
                                                'model': 'Land Rover Series III'
                                            }
                                   }";

            var simpleObject = JsonConvert.DeserializeObject(simpleJson);

            JsonSerializer jsonSerializer = new JsonSerializer();
            MemoryStream bsonMemoryStream = new MemoryStream();

            using (BsonWriter bsonWriter = new BsonWriter(bsonMemoryStream))
            {
                jsonSerializer.Serialize(bsonWriter, simpleObject);
            }

            int i = 0;
            foreach (byte b in bsonMemoryStream.ToArray()) //X2 means two uppercase HEX chars
            {
                Console.WriteLine(i + ":" + b.ToString("X2") + "(" + b + ")" +
                    " -> " + System.Text.Encoding.ASCII.GetString(new byte[] { b }));
                i++;
            }

            Console.WriteLine(Encoding.ASCII.GetString(bsonMemoryStream.ToArray()));

            Console.WriteLine(Convert.ToBase64String(bsonMemoryStream.ToArray()));
        }
    }
}
