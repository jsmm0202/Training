using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m4.d9
{
   public static class ShowIContractResolverDemo
    {
        public static void ShowIContractResolver()
        {
            Console.Clear();
            Console.WriteLine("*** ContractResolver ***");

            AuthorICR xavierAuthor = new AuthorICR();
            xavierAuthor.Name = "Xavier Morera";
            xavierAuthor.Courses = new string[] { "Solr", "dotTrace", "Jira" };
            xavierAuthor.Car = new Car() { Model = "Land Rover", Year = 1976 };
            xavierAuthor.Happy = true;
            xavierAuthor.Since = new DateTime(2014, 01, 15);
            xavierAuthor.Issues = null;


            List<string> propertiesToSerialize = new List<string>(new string[] { "Name", "Courses" });
            //Tip: view in Immediate Window

            // Create a contract resolver
            SelectiveContractResolver contractResolver = new SelectiveContractResolver(propertiesToSerialize);
            string xavierJson = JsonConvert.SerializeObject(xavierAuthor, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = contractResolver
            });
            Console.WriteLine(xavierJson);
        }
    }
}
