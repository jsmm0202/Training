using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m6.d19
{
    class Program
    {
        static void Main(string[] args)
        {
            ImperativeDemo.ImperativeCreateJSON();
            DeclarativeDemo.DeclarativeCreateJSON();
            FromObjectDemo.FromObjectCreateJSON();
        }
    }
}
