using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d8
{
    public class AuthorNoConverterAttribute
    {
        public string author { get; set; }

        public Relationship relationship { get; set; }

        public DateTime since { get; set; }
    }


    public class AuthorWithConverterAttribute
    {
        public string author { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Relationship relationship { get; set; }

        [JsonConverter(typeof(JavaScriptDateTimeConverter))]
        public DateTime since { get; set; }
    }
 
    public enum Relationship
    {
        EmployeeAuthor,
        IndependentAuthor
    }
}
