using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m2.d6
{
  public  class DeserializeErrorDemo
    {
        public static void ShowDeserializeError()
        {
            Console.Clear();
            Console.WriteLine("*** Deserialize Error ***");
            try
            {
                List<DateTime> deserializedDates = JsonConvert.DeserializeObject<List<DateTime>>(@"[
                                                                            '1978-10-30T00:00:00Z',
                                                                            '1978-30-10T00:00:00Z',
                                                                            'Error in the making',
                                                                            [1],
                                                                            '1979-08-26T00:00:00Z',
                                                                            null
                                                                            ]");
                Console.WriteLine(deserializedDates.Count());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to deserialize object: " + ex.Message);
            }
        }
    }
}
