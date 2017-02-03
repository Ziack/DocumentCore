using DocumentManager.Core.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.Core.Attributes
{
    public class TypeAttribute: Attribute
    {
         public String Type { get; private set; }

         public TypeAttribute(String Type)
        {
            this.Type = Type;
        }

         public static void Apply(Configuration configuration, ref List<Attribute> attributes)
         {
             if (!String.IsNullOrEmpty(configuration.BindType))
             {
                 attributes.Add(new TypeAttribute(configuration.BindType));
                 return;
             }
         }
    }
}
