using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace pluralsight.json.net.m7.d24
{
    public static class ToAndFromDemo
    {
        public static void ShowToAndFrom()
        {
            Console.Clear();
            Console.WriteLine("*** XML and JSON ***");

            string authorsSourceXml = GenerateXMLSampleOne();
            Console.WriteLine(authorsSourceXml);

            XmlDocument xDoc = new XmlDocument();
            xDoc.LoadXml(authorsSourceXml);

            string authorsJSON = JsonConvert.SerializeXmlNode(xDoc, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine(authorsJSON);

            XmlDocument authorAgainXMLDocument = JsonConvert.DeserializeXmlNode(authorsJSON);
            Console.WriteLine(authorAgainXMLDocument.InnerXml);
            
            XDocument authorAgainXMLDoc = JsonConvert.DeserializeXNode(authorsJSON);
            Console.WriteLine(authorAgainXMLDoc.ToString());
        }

        private static string GenerateXMLSampleOne()
        {
            return @"<?xml version='1.0'?>
 <authors>
	<author>
		<name>Peter Shaw</name>
		<course>HTML 5 Layouts</course>
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
