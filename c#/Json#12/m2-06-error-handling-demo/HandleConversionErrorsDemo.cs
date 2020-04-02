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
    public static class HandleConversionErrorsDemo
    {
        public static void HandleConversionErrors()
        {
            List<string> errors = new List<string>();

            JsonSerializerSettings jSS = new JsonSerializerSettings
            {
                Error = HandleDeserializationError,
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
        }

        private static void HandleDeserializationError(object sender, ErrorEventArgs errorArgs)
        {
            var currentError = errorArgs.ErrorContext.Error.Message;
            //Test if data in other format
            errorArgs.ErrorContext.Handled = true;
        }
    }
}
