using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m8.d25
{
   public static class BsonSerializationDemo
    {
       public static void ShowBsonSerialization()
        {
            Console.Clear();
            Console.WriteLine("*** BSON Serialization ***");

            string xavierJson = CreateTestJson();

            Author xavierObject = JsonConvert.DeserializeObject<Author>(xavierJson);

            MemoryStream bsonDataMemoryStream = new MemoryStream();
            using (BsonWriter bsonWriter = new BsonWriter(bsonDataMemoryStream))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                jsonSerializer.Serialize(bsonWriter, xavierObject);
            }

            string bsonDataString = Convert.ToBase64String(bsonDataMemoryStream.ToArray());

            Console.WriteLine(bsonDataString);

            //deserialize

            byte[] bsonDataFromString = Convert.FromBase64String(bsonDataString);

            MemoryStream bsonDataMemoryStreamTwo = new MemoryStream(bsonDataFromString);

            Author xavierDeserialized;
            using (BsonReader bsonReader = new BsonReader(bsonDataMemoryStreamTwo))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                xavierDeserialized = jsonSerializer.Deserialize<Author>(bsonReader);
            }

            Console.WriteLine(xavierDeserialized.name);
        }

        private static string CreateTestJson()
        {
            return @"{
  'name': 'Xavier Morera',
  'courses': [
    'Solr',
    'dotTrace'
  ],
  'since': '2014-01-14T00:00:00',
  'happy': true,
  'issues': null,
  'car': {
    'model': 'Land Rover Series III',
    'year': 1976
  }
}";
        }
    }
}
