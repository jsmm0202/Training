using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d8
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonAttributesDemo.ShowAttributes();
            JsonOptInOptOutDemo.ShowJsonOptInOptOut();
            JsonPropertyAttributeDemo.ShowJsonPropertyAttribute();
            JsonConverterAttributeDemo.ShowJsonConverterAttribute();
            JsonConstructorAttributeDemo.ShowJsonConstructorAttribute();
            JsonExtensionDataAttributeDemo.ShowJsonExtensionDataAttribute();
        }
    }
}
