using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m4.d12
{
  public static  class CustomTraceWriterDemo
    {
        public static void ShowCustomTraceWriter()
        {
            Console.Clear();
            Console.WriteLine("*** Custom Trace Writer ***");

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

            Author xavierAuthor = JsonConvert.DeserializeObject<Author>(xavierJson);
            Console.WriteLine(xavierAuthor.car);

            ITraceWriter traceWriterOff = new FileLogTraceWriter(TraceLevel.Off, "TraceLevel.Off");
            xavierAuthor = JsonConvert.DeserializeObject<Author>(xavierJson, new JsonSerializerSettings
            {
                TraceWriter = traceWriterOff
            });

            ITraceWriter traceWriterVerbose = new FileLogTraceWriter(TraceLevel.Verbose, "TraceLevel.Verbose");
            xavierAuthor = JsonConvert.DeserializeObject<Author>(xavierJson, new JsonSerializerSettings
            {
                TraceWriter = traceWriterVerbose
            });

            ITraceWriter traceWriterErrors = new FileLogTraceWriter(TraceLevel.Error, "TraceLevel.Error");
            xavierAuthor = JsonConvert.DeserializeObject<Author>(xavierJson, new JsonSerializerSettings
            {
                TraceWriter = traceWriterErrors
            });

            ITraceWriter traceWriterErrorMissingMember = new FileLogTraceWriter(TraceLevel.Error, "TraceLevel.Error with MissingMemberHandling.Error");
            try
            {
                xavierAuthor = JsonConvert.DeserializeObject<Author>(xavierJson, new JsonSerializerSettings
                {
                    TraceWriter = traceWriterErrorMissingMember,
                    MissingMemberHandling = MissingMemberHandling.Error
                });
            }
            catch
            {
                Console.WriteLine("Error has been logged");
            }

        }
    }
}
