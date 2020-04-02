using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m2.d4
{
    public class JsonTextWriterDemo
    {
        public static void ShowJsonTextWriter()
        {
            Console.Clear();
            Console.WriteLine("*** JsonTextWriter Demo ***");
            //Final JSON
            /*
                {
                "name": "Xavier Morera",
                "courses": [
                    "Solr",
                    "dotTrace"],
                "since": "2014-01-14T00:00:00",
                "happy": true,
                "issues": null,
                "car": {
                    "model": "Land Rover Series III",
                    "year": 1976}
                }
             */

            StringWriter sw = new StringWriter();
            JsonTextWriter writer = new JsonTextWriter(sw);

            writer.Formatting = Formatting.Indented; //try at the beginning and at the end

            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteValue("Xavier Morera");
            writer.WritePropertyName("courses");
            writer.WriteStartArray();
            writer.WriteValue("Solr");
            writer.WriteValue("dotTrace");
            writer.WriteEndArray();
            writer.WritePropertyName("since");
            writer.WriteValue(new DateTime(2014, 01, 14));
            writer.WritePropertyName("happy");
            writer.WriteValue(true);
            writer.WritePropertyName("issues");
            writer.WriteNull();
            writer.WritePropertyName("car"); // what happens if you forget this one? Exception!
            writer.WriteStartObject();
            writer.WritePropertyName("model");
            writer.WriteValue("Land Rover Series III");
            writer.WritePropertyName("year");
            writer.WriteValue(1976);
            writer.WriteEndObject();
            writer.WriteEndObject();
            writer.Flush();

            string jsonText = sw.GetStringBuilder().ToString();

            Console.WriteLine(jsonText);
        }
    }
}
