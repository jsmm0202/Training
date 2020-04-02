using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d7
{
    public class AuthorObjectCreationHandling
    {
        public AuthorObjectCreationHandling()
        {
            courses = new List<string> { "course 1", "course 2", "course 3" };
        }

        public string name { get; set; }

        public List<string> courses { get; set; }
    }
}
