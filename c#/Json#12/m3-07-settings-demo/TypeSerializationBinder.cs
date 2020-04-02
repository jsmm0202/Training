using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d7
{
  public  class TypeSerializationBinder: SerializationBinder
    {
            public string TypeFormat { get; private set; }

            public TypeSerializationBinder(string typeFormat)
            {
                TypeFormat = typeFormat;
            }

            public override void BindToName(Type serializedType, out string assemblyName, out string typeName)
            {
                assemblyName = null;
                typeName = serializedType.Name;
            }

            public override Type BindToType(string assemblyName, string typeName)
            {
                string resolvedTypeName = string.Format(TypeFormat, typeName);

                return Type.GetType(resolvedTypeName, true);
            }
        }
    }
 
