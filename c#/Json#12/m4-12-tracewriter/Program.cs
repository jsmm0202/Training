using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Diagnostics;

namespace pluralsight.json.net.m4.d12
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryTraceWriterDemo.ShowMemoryTraceWriter();
            CustomTraceWriterDemo.ShowCustomTraceWriter();
        }
    }
}
