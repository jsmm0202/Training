using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m2.d6
{
  public  static class ConversionErrorsDemo
    {
        public static void ShowConversionErrors()
        {
            Console.Clear();
            Console.WriteLine("*** Conversion Errors with Delegate ***");
            List<string> errors = new List<string>();

            JsonSerializerSettings jSS = new JsonSerializerSettings
            {
                Error = delegate(object sender, ErrorEventArgs errorArgs)
                {
                    errors.Add(errorArgs.ErrorContext.Error.Message);
                    errorArgs.ErrorContext.Handled = true;
                },
                Converters = { new IsoDateTimeConverter() }
            };

            List<DateTime> deserializedDates = JsonConvert.DeserializeObject<List<DateTime>>(@"[
                                                                            '1978-10-30T00:00:00Z',
                                                                            '1978-30-10T00:00:00Z',
                                                                            'Error in the making',
                                                                            [1],
                                                                            '1979-08-26T00:00:00Z',
                                                                            null
                                                                            ]", jSS);

            Console.WriteLine("Dates:");
            foreach (DateTime date in deserializedDates)
            {
                Console.WriteLine(date.ToShortDateString());
            }

            Console.WriteLine("Errors:");
            foreach (var err in errors)
            {
                Console.WriteLine(err);
            }
        }
    }
}
