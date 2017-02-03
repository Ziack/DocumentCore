using DocumentManager.Core.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.Core.Attributes
{
    public class IsBlockingAttribute: Attribute
    {
         public Boolean? IsBlocking { get; private set; }

         public IsBlockingAttribute(Boolean? isBlocking)
        {
            this.IsBlocking = isBlocking;
        }

         public static void Apply(Configuration configuration, ref List<Attribute> attributes)
         {
             if (configuration.IsBlocking.HasValue)
             {
                 attributes.Add(new IsBlockingAttribute(configuration.IsBlocking));                 
                 return;
             }
         }
    }
}
