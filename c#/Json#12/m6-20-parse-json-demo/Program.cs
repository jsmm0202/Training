using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m6.d20
{
    class Program
    {
        static void Main(string[] args)
        {
           FromStringDemo.ParseJSONFromString();
           FromStreamDemo.ParseJSONFromStream();
        }
    }
}
