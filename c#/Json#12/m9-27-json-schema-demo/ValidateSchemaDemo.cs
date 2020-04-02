using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m9.d26
{
  public static  class ValidateSchemaDemo
    {
        public static void ValidatingJSON(string xavierAuthor, string manualJSONSchema, string generatedJSONSchema)
        {
            JObject author = JObject.Parse(xavierAuthor);

            JSchema manualSchema = JSchema.Parse(manualJSONSchema);
            JSchema generatedSchema = JSchema.Parse(generatedJSONSchema);
          
            bool validateGenerated = author.IsValid(generatedSchema);

            IList<string> why;
            bool validateManual = author.IsValid(manualSchema, out why);

        }
    }
}
