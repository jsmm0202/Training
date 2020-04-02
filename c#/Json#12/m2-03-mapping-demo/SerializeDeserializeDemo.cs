using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace pluralsight.json.net.m2.d3
{
    public static class SerializeDeserializeDemo
    {
        public static void ShowSerializeDeserialize()
        {
            Console.Clear();
            string xavierJson = @"{
                                    'name': 'Xavier Morera',
                                    'courses': [
                                        'Solr',
                                        'dotTrace'
                                        ],
                                    'since': '2014-01-14T00:00:00',
                                    'happy': true,
                                    'issues': null,
                                    'car': {
                                        'model': 'Land Rover Series III',
                                        'year': 1976
                                        },
                                    'authorRelationship': 1
                                }";

            Console.WriteLine("Step 1: Output JSON");
            Console.WriteLine(xavierJson);

            Console.WriteLine(Environment.NewLine + "Step 2: Output property Author.Name from deserialized class");
            Author xavierAuthor = JsonConvert.DeserializeObject<Author>(xavierJson);
            Console.WriteLine(xavierAuthor.name);

            Console.WriteLine(Environment.NewLine + "Step 3: Output serialized Author class");
            string xavierJsonSerialized = JsonConvert.SerializeObject(xavierAuthor);
            Console.WriteLine(xavierJsonSerialized);

            Console.WriteLine(Environment.NewLine + "Step 4: Output serialized Author class with indentation");
            string xavierJsonSerializedIndented = JsonConvert.SerializeObject(xavierAuthor, Formatting.Indented);
            Console.WriteLine(xavierJsonSerializedIndented);
        }

    }
}
