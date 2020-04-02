using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pluralsight.json.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string incompatibleXml = GenerateIncompatibleXML();

            XDocument xDoc = XDocument.Parse(incompatibleXml);

            string authorsJSON = JsonConvert.SerializeXNode(xDoc, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine(authorsJSON);

            XDocument xDocFromJson = JsonConvert.DeserializeXNode(authorsJSON);
            Console.WriteLine(xDocFromJson.ToString());
        }

        private static string GenerateIncompatibleXML()
        {
            return @"<?xml version='1.0'?>
 <mainnode>

</mainnode>";
        }
    }
}
