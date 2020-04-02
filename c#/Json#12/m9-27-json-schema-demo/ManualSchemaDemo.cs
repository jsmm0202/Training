using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m9.d26
{
  public static  class ManualSchemaDemo
    {
        public static string ManuallyCreateSchema()
        {
            Console.WriteLine("- Manually generated schema");

            JSchema schema = new JSchema
            {
                Type = JSchemaType.Object,
                Properties =    {
                    { "name", new JSchema { Type = JSchemaType.String } },
                    { "courses", new JSchema{
                         Type = JSchemaType.Array,
                         Items = { new JSchema { Type = JSchemaType.String } }
                        }
                    },
                    { "since", new JSchema { Type = JSchemaType.String } },
                    { "happy", new JSchema { Type = JSchemaType.Boolean } },
                    { "issues", new JSchema { Type = JSchemaType.Object } },
                }
            };

            Console.WriteLine(schema.ToString());

            return schema.ToString();
        }
    }
}
