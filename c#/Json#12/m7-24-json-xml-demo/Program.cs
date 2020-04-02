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
    class Program
    {
        static void Main(string[] args)
        {
            ToAndFromDemo.ShowToAndFrom();
            ForceArrayDemo.ShowForceArray();
            ComprehensiveDemo.ShowComprehensive();
        }
    }
}
