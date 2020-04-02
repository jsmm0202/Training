using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d7
{
public    class ConstructorHandlingDemo
    {
    public static void ShowConstructorHandling()
    {
        Console.Clear();
        Console.WriteLine("*** Constructor Handling ***");

        string jsonConstructor = "{'name': 'Xavier Morera', 'happy': true }";

        try
        {
            Console.WriteLine("- Deserialize normally");
            AuthorConstructor author = JsonConvert.DeserializeObject<AuthorConstructor>(jsonConstructor);
            Console.WriteLine(author.name);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("- Deserialize with AllowNonPublicDefaultConstructor");
        AuthorConstructor authorConstructorHandling = JsonConvert.DeserializeObject<AuthorConstructor>(jsonConstructor, new JsonSerializerSettings
        {
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
        });
        Console.WriteLine(authorConstructorHandling.name);

    }
    }
}
