using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d7
{
   public class TypeNameAssemblyFormatDemo
    {
       public static void ShowTypeNameAssemblyFormat()
       {
           Console.Clear();
           Console.WriteLine("*** TypeNameAssemblyFormat ***");

           Author xavier = new Author();
           xavier.name = "Xavier Morera";
           xavier.courses = new string[] { "Solr", "dotTrace", "Jira" };
           xavier.car = new Car() { model = "Land Rover", year = 1976 };

           Console.WriteLine("- TypeNameAssemblyFormat.Simple");
           string xavierTNAS = JsonConvert.SerializeObject(xavier, new JsonSerializerSettings
           {
               TypeNameHandling = TypeNameHandling.All,
               TypeNameAssemblyFormat = FormatterAssemblyStyle.Simple,
               Formatting = Formatting.Indented
           });
           Console.WriteLine(xavierTNAS);

           Console.WriteLine("- TypeNameAssemblyFormat.Full");
           string xavierTNAF = JsonConvert.SerializeObject(xavier, new JsonSerializerSettings
           {
               TypeNameHandling = TypeNameHandling.All,
               TypeNameAssemblyFormat = FormatterAssemblyStyle.Full,
               Formatting = Formatting.Indented
           });
           Console.WriteLine(xavierTNAF);
       }
    }
}
