using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m4.d9
{
    public class AuthorSS
    {
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public string[] Courses { get; set; }

        public bool ShouldSerializeCourses()
        {
            //If Author IsActive then Courses will be serialized
            return IsActive;
        }
    }
}

