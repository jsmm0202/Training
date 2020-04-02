using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m9.d26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Json.NET Schema ***");
            Console.Clear();

            string manualSchema = ManualSchemaDemo.ManuallyCreateSchema();
             
            string xavierAuthor = CreateAuthorJSON();

            Author xavierAuthorObject = JsonConvert.DeserializeObject<Author>(xavierAuthor);

            string generatedSchema = GenerateSchemaDemo.AutomaticallyGenerateSchema(xavierAuthorObject, xavierAuthor);

            ValidateSchemaDemo.ValidatingJSON(xavierAuthor, manualSchema, generatedSchema);
        }


        private static string CreateAuthorJSON()
        {
            return @"{
  'name': 'Xavier Morera',
  'courses': [
    'Solr',
    'dotTrace'
  ],
  'since': '2014-01-14T00:00:00',
  'happy': true,
  'issues': null
}";
        }
    }
}
