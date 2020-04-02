using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m4.d12
{
    public class MemoryTraceWriterDemo
    {


        public static void ShowMemoryTraceWriter()
        {
            Console.Clear();
            Console.WriteLine("*** Memory Trace Writer ***");
            string xavierJson = @"{
            'name': 'Xavier Morera',
  'courses': [
    'Solr',
    'dotTrace'
  ],
  'since': '2014-01-14T00:00:00',
  'happy': true,
  'issues': null,
  'car ': {
    'model': 'Land Rover Series III',
    'year': 1976
  }
}
";

            Console.WriteLine("- Where does this error come from?");
            try
            {
                Author xavierAuthor = JsonConvert.DeserializeObject<Author>(xavierJson);
                Console.WriteLine(xavierAuthor.car.model);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("- Memory TraceWriter will tell you step by step");
            ITraceWriter traceWriter = new MemoryTraceWriter();
            Author xavierAuthorTraceWriter = JsonConvert.DeserializeObject<Author>(xavierJson, new JsonSerializerSettings
            {
                TraceWriter = traceWriter
            });
            Console.WriteLine(traceWriter);
        }
    }
}
