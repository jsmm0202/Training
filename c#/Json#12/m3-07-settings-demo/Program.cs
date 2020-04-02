
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d7
{
    class Program
    {
        static void Main(string[] args)
        {
            DeserializationMissingMemberDemo.ShowDeserializationMissingMember();
            SerializationCircularReferencesDemo.ShowSerializationCircularReferences();
            SerializationNullValueHandlingDemo.ShowSerializationNullValueHandling();
            DefaultValueHandlingDemo.ShowDefaultValueHandling();
            ObjectCreationHandlingDemo.ShowObjectCreationHandling();
            TypeNameHandlingDemo.ShowTypeNameHandling();
            TypeNameAssemblyFormatDemo.ShowTypeNameAssemblyFormat();
            BinderDemo.ShowBinder();
            ConstructorHandlingDemo.ShowConstructorHandling();
            MetadataHandlingDemo.ShowMetadataHandling();
        }
    }
}
