using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m2.d6
{
    class Program
    {
        static void Main(string[] args)
        {
            DeserializeErrorDemo.ShowDeserializeError();
            ConversionErrorsDemo.ShowConversionErrors();
            HandleConversionErrorsDemo.HandleConversionErrors();
        }
    }
}
