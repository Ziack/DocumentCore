using DocumentManager.Core.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.Core.Attributes
{
    public class GateNeedsModalAttribute: Attribute
    {
         public Boolean NeedsModal { get; private set; }

         public GateNeedsModalAttribute(Boolean NeedsModal)
        {
            this.NeedsModal = NeedsModal;
        }

         public static void Apply(Configuration configuration, ref List<Attribute> attributes)
         {
             if (configuration.NeedsModal != null)
             {
                 attributes.Add(new GateNeedsModalAttribute(configuration.NeedsModal));
                 return;
             }
         }
    }
}
