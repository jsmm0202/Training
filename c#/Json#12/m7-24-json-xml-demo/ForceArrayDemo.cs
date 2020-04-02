using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pluralsight.json.net.m7.d24
{
    public static class ForceArrayDemo
    {
        public static void ShowForceArray()
        {
            Console.Clear();
            Console.WriteLine("*** Force Array ***");

            string authorsSourceXmlForceArray = GenerateXMLSampleTwoWithArray();

            XDocument xDoc = XDocument.Parse(authorsSourceXmlForceArray);

            string authorsJSON = JsonConvert.SerializeXNode(xDoc, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine(authorsJSON);

            XDocument xDocFromJson = JsonConvert.DeserializeXNode(authorsJSON);
            Console.WriteLine(xDocFromJson.ToString());

            //and show comparison

            XDocument xDocWithProperties = JsonConvert.DeserializeXNode(authorsJSON, "TestJsonXMLConversion");
            Console.WriteLine(xDocWithProperties.ToString());
        }

        private static string GenerateXMLSampleTwoWithArray()
        {
            return @"<?xml version='1.0'?>
 <authors xmlns:json='http://james.newtonking.com/projects/json'>
	<author>
		<name>Peter Shaw</name>
		<course json:Array='true'>HTML 5 Layouts</course>
		<totalcourses>1</totalcourses>
		<currentlyauthoring>false</currentlyauthoring>
	</author>
   	<author>
		<name>Xavier Morera</name>
		<course>Solr</course>
		<course>dotTrace</course>
		<course>JIRA</course>
		<totalcourses>3</totalcourses>
		<currentlyauthoring>true</currentlyauthoring>
	</author>
	<author>
	    <name>Jason Alba</name>
	    <courses>
		    <course>Management 101</course>
		    <course>Customer Service</course>
		    <course>Phone Skills</course>
	    </courses>
	    <totalcourses>17</totalcourses>
	    <currentlyauthoring>true</currentlyauthoring>
    </author>
</authors>";
        }
    }
}
