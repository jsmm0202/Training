using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m4.d11
{
    public class Author
    {
        private Stopwatch timer = new Stopwatch();

        public string country;
        public int age;
        public string name { get; set; }
        public string[] courses { get; set; }
        public DateTime since { get; set; }
        public bool happy { get; set; }
        public object issues { get; set; }
        public Car car { get; set; }

        [OnSerializing]
        internal void OnSerializingMethod(StreamingContext context)
        {
            timer.Reset();
            timer.Start();
            Console.WriteLine("OnSerializing: started serialization process");
        }

        [OnSerialized]
        internal void OnSerializedMethod(StreamingContext context)
        {
            timer.Stop();
            Console.WriteLine("OnSerialized: finished serialization in " + timer.ElapsedMilliseconds + " ms");
        }

        [OnDeserializing]
        internal void OnDeserializingMethod(StreamingContext context)
        {
            timer.Reset();
            timer.Start();
            Console.WriteLine("OnDeserializing: started deserialization process");
        }

        [OnDeserialized]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            timer.Stop();
            Console.WriteLine("OnDeserialized: finished deserialization in " + timer.ElapsedMilliseconds + " ms");
        }
    }
    public class Car
    {
        public string model { get; set; }
        public int year { get; set; }
    }
}

