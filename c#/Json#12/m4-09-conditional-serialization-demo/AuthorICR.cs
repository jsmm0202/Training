using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m4.d9
{
    public class AuthorICR
    {
        public string Name { get; set; }

        public string[] Courses { get; set; }

        public DateTime Since { get; set; }

        public bool Happy { get; set; }

        public object Issues { get; set; }

        public Car Car { get; set; }
    }

    public class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
    }
}

