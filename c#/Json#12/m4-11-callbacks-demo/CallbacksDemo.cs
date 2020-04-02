using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m4.d11
{
    public static class CallbacksDemo
    {
        public static void ShowCallBacks()
        {
            Console.Clear();
            Console.WriteLine("*** Serialization Call Backs ***");

            string xavierJson = @"{
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
}
";

            Console.WriteLine("Deserialize");
            Author xavierAuthor = JsonConvert.DeserializeObject<Author>(xavierJson);
            Console.WriteLine(xavierAuthor.name);

            Console.WriteLine("Serialize");
            string xavierJsonSerialized = JsonConvert.SerializeObject(xavierAuthor);
            Console.WriteLine(xavierJsonSerialized);
        }
    }
}
