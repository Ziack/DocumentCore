using DocumentManager.Core.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.Core.Attributes
{
    public class ControlDependencyAttribute: Attribute
    {
         public String Control { get; private set; }

         public ControlDependencyAttribute(String control)
        {
            this.Control = control;
        }

         public static void Apply(Configuration configuration, ref List<Attribute> attributes)
         {
             if (!String.IsNullOrEmpty(configuration.Control))
             {
                 attributes.Add(new ControlDependencyAttribute(configuration.Control));
                 return;
             }
         }
    }
}
