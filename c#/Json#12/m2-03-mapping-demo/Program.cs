using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Dynamic;
using Newtonsoft.Json;

namespace pluralsight.json.net.m2.d3
{
    class Program
    {
        static void Main(string[] args)
        {
            SerializeDeserializeDemo.ShowSerializeDeserialize();
            ObjectReferencesDemo.ShowObjectReferences();
            DynamicDemo.ShowDynamic();
            DifferentTypesDemo.ShowDifferentTypes();
        }
    }
}
