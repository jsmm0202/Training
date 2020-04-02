using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m4.d9
{
    class Program
    {
        static void Main(string[] args)
        {
            ShouldSerializeDemo.ShowShouldSerialize();
            ShowIContractResolverDemo.ShowIContractResolver();
        }
    }
}
