using DocumentManager.Core.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.Core.Attributes
{
    public class ArinControlKeyAttribute: Attribute
    {
         public String ControlKey { get; private set; }

         public ArinControlKeyAttribute(String controlKey)
        {
            this.ControlKey = controlKey;
        }

         public static void Apply(Configuration configuration, ref List<Attribute> attributes)
         {
             if (!String.IsNullOrEmpty(configuration.ControlKey))
             {
                 attributes.Add(new ArinControlKeyAttribute(configuration.ControlKey));                 
                 return;
             }
         }
    }
}
