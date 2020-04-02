using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m5.d18
{
    static class OptimizeMemoryDemo
    {
        public static void ShowDemo()
        {
            Console.Clear();
            Console.WriteLine("*** Use Streams to Read JSON for Improved Memory Usage ***");
            string jsonUrl1 = @"http://pluralsight.xaviermorera.com/jsonnet/logs1.json";

            //********************************************************************
            HttpClient clientStream = new HttpClient();
            using (Stream stream = clientStream.GetStreamAsync(jsonUrl1).Result)
            {
                using (StreamReader streamReader = new StreamReader(stream))
                {
                    using (JsonReader jsonReader = new JsonTextReader(streamReader))
                    {
                        JsonSerializer jsonSerializer = new JsonSerializer();
                        List<UserInteraction> logsStream = jsonSerializer.Deserialize<List<UserInteraction>>(jsonReader);
                        Console.WriteLine("Total logs: " + logsStream.Count);
                    }
                }
            }
        }

    }
}
