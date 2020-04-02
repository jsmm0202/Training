using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m9.d26
{
  public static  class GenerateSchemaDemo
    {
        public static string AutomaticallyGenerateSchema(Author xavierAuthorObject, string xavierAuthor)
        {
            Console.WriteLine("- Automatically generated schema");

            JSchemaGenerator jsonSchemaGenerator = new JSchemaGenerator();
            JSchema schema = jsonSchemaGenerator.Generate(typeof(Author));

            Console.WriteLine(schema.ToString());

            return schema.ToString();
        }
    }
}
