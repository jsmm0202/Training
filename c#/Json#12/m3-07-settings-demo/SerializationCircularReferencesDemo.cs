using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d7
{
    public class SerializationCircularReferencesDemo
    {
        public static void ShowSerializationCircularReferences()
        {
            Console.Clear();
            Console.WriteLine("*** Circular References ***");

            AuthorFriendly xavier = new AuthorFriendly { name = "Xavier Morera" };
            AuthorFriendly jason = new AuthorFriendly { name = "Jason Alba" };
            AuthorFriendly simon = new AuthorFriendly { name = "Simon Robinson" };

            xavier.FellowAuthors = new List<AuthorFriendly>();
            xavier.FellowAuthors.Add(jason);
            xavier.FellowAuthors.Add(simon);
            xavier.FellowAuthors.Add(xavier);

            //***************************************************************************
            try
            {
                Console.WriteLine("- Serialize AuthorFriendly with circular reference");
                string xavierJson = JsonConvert.SerializeObject(xavier);
                Console.WriteLine(xavierJson);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //***************************************************************************
            Console.WriteLine("- Serialize AuthorFriendly with circular reference with ReferenceLoopHandling");
            string xavierJsonReferenceLoopHandling = JsonConvert.SerializeObject(xavier, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Formatting = Formatting.Indented
            });
            Console.WriteLine(xavierJsonReferenceLoopHandling);

            //***************************************************************************
            Console.WriteLine("- Serialize AuthorFriendly with circular reference with ReferenceLoopHandling");
            string xavierJsonPreserveReferencesHandling = JsonConvert.SerializeObject(xavier, new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.All,
                Formatting = Formatting.Indented
            });
            Console.WriteLine(xavierJsonPreserveReferencesHandling);
        }
    }
}
