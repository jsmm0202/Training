using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d8
{
    public class AuthorConstructor
    {
        public AuthorConstructor()
        {
            author = "Xavier Morera In Constructor";
            happy = false;
        }

        AuthorConstructor(string authorName)
        {
            author = authorName;
            happy = true;
        }

        public string author { get; set; }

        public DateTime since { get; set; }

        public bool happy { get; set; }
    }

    public class AuthorConstructorAttribute
    {
        public AuthorConstructorAttribute()
        {
            author = "Xavier Morera in Constructor";
            happy = false;
        }

        [JsonConstructor]
        AuthorConstructorAttribute(string authorName)
        {
            author = authorName;
            happy = true;
        }

        public string author { get; set; }

        public DateTime since { get; set; }

        public bool happy { get; set; }
    }
}
