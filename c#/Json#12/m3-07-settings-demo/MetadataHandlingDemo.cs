using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d7
{
    public class MetadataHandlingDemo
    {
        public static void ShowMetadataHandling()
        {
            Console.Clear();
            Console.WriteLine("*** Metadata Handling ***");

            string xavierAuthor = @"{
  'name': 'Xavier Morera',
  '$type': 'pluralsight.json.net.m3.d7.Author, m3-07-settings-demo'
}";

            object xavierObjectNoSetting = JsonConvert.DeserializeObject(xavierAuthor);
            Console.WriteLine("- xavierObjectNoSetting is of type " 
                                + xavierObjectNoSetting.GetType().ToString());

            object xavierWithMetadataReadAhead = JsonConvert.DeserializeObject(xavierAuthor, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All,
                    // $type no longer needs to be first
                    MetadataPropertyHandling = MetadataPropertyHandling.ReadAhead
                });
            Console.WriteLine("- xavierWithMetadataReadAhead is of type " 
                                + xavierWithMetadataReadAhead.GetType().ToString());
        }
    }
}
