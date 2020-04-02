using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pluralsight.json.net.m7.d24
{
    public static class ComprehensiveDemo
    {
        public static void ShowComprehensive()
        {
            Console.Clear();
            Console.WriteLine("*** A more comprehensive demo ***");

            string moreComprehensiveXml = GenerateXMLMoreComprehensiveSampleThree();

            XDocument xDoc = XDocument.Parse(moreComprehensiveXml);

            string authorsJSON = JsonConvert.SerializeXNode(xDoc, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine(authorsJSON);

            XDocument xDocFromJson = JsonConvert.DeserializeXNode(authorsJSON);
            Console.WriteLine(xDocFromJson.ToString());
        }

        private static string GenerateXMLMoreComprehensiveSampleThree()
        {
            return @"<?xml version='1.0'?>
 <mainnode>
  <emptyvalue/>
	<text>
		Some text
	</text>
	<nodewithattributes myattribute='thisattribute' anotherattribute='otherattribute'>
		Some text with attributes and text
	</nodewithattributes>
	<differentsubnodes>
		<onedifferent></onedifferent>
		<twodifferent></twodifferent>
		<threedifferent></threedifferent>
	</differentsubnodes>
	<repeatedsubnodes>
		<onerepeated></onerepeated>
		<twodifferent></twodifferent>
		<onerepeated></onerepeated>
	</repeatedsubnodes>	
	<arrays>
		<arrayofone>
			value
		</arrayofone>
	</arrays>
	<otherarrays>
		<valueone/>
		<valueone>some value</valueone>
	</otherarrays>
	<mixedcontent>this is valid <emphasis>mixed</emphasis> content</mixedcontent>
	<unorderedlistwithchange>
		<c>b</c>
		<b>c</b>
		<a>a</a>
	</unorderedlistwithchange>
	<unorderedarray>
		<onenode>b</onenode>
		<onenode>c</onenode>
		<onenode>a</onenode>
	</unorderedarray>
</mainnode>";
        }
    }
}
