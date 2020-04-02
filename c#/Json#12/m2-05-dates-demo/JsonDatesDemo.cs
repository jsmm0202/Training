using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m2.d5
{
    public class JsonDatesDemo
    {
        public static void ShowDatesDemo()
        {
            Console.Clear();
            Console.WriteLine("*** Dates demo ***");

            Author author = new Author();
            author.name = "Xavier";
            author.since = new DateTime(2009, 07, 11, 23, 00, 00);

            Console.WriteLine("- Serialize object without specifying any date format (default)");
            string dateDefault = JsonConvert.SerializeObject(author, Formatting.Indented);
            Console.WriteLine(dateDefault);

            Console.WriteLine("- Serialize object specifying Microsoft Date - Default pre .NET 4.5");
            JsonSerializerSettings settingsMicrosoftDate = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
            };
            string dateMicrosoftOldDefault = JsonConvert.SerializeObject(author, Formatting.Indented, settingsMicrosoftDate);
            Console.WriteLine(dateMicrosoftOldDefault);

            Console.WriteLine("- Serialize object specifying to use Iso DateTime converter");
            string dateIso8601 = JsonConvert.SerializeObject(author, Formatting.Indented, new IsoDateTimeConverter());
            Console.WriteLine(dateIso8601);

            Console.WriteLine("- Serialize object specifying custom date format");
            JsonSerializerSettings settingsCustomDate = new JsonSerializerSettings
            {
                DateFormatString = "dd/MM/yyyy"
            };
            string dateCustom = JsonConvert.SerializeObject(author, Formatting.Indented, settingsCustomDate);
            Console.WriteLine(dateCustom);

            Console.WriteLine("- Serialize object specifying to use JavaScript DateTime converter");
            string dateJavaScript = JsonConvert.SerializeObject(author, Formatting.Indented, new JavaScriptDateTimeConverter());
            Console.WriteLine(dateJavaScript);
        }
    }
}
