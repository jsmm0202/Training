using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d7
{
    public class AuthorConstructor
    {
        private AuthorConstructor()
        {
            //Private constructor
        }

        public AuthorConstructor(string authorName)
        {
            if (string.IsNullOrEmpty(authorName))
            {
                throw new ArgumentNullException("authorName is a required value");
            }
            //Public constructor
            name = authorName;
        }

        public string name { get; set; }

        public bool happy { get; set; }

    }


}
