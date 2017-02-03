using DocumentManager.Core.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.Core.Attributes
{
    public class DocTypeAttribute: Attribute
    {
         public String Type { get; private set; }

         public DocTypeAttribute(String Type)
        {
            this.Type = Type;
        }

         public static void Apply(Configuration configuration, ref List<Attribute> attributes)
         {
             if (!String.IsNullOrEmpty(configuration.DocType))
             {
                 attributes.Add(new DocTypeAttribute(configuration.DocType));
                 return;
             }
         }
    }
}
