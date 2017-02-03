using DocumentManager.Core.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.Core.Attributes
{
    public class EditableAttribute: Attribute
    {
         public Boolean? Enabled { get; private set; }

         public EditableAttribute(Boolean? enabled)
        {
            this.Enabled = enabled;
        }

         public static void Apply(Configuration configuration, ref List<Attribute> attributes)
         {
             if (configuration.Editable.HasValue)
             {
                 attributes.Add(new EditableAttribute(configuration.Editable));
                 attributes.Add(new ReadOnlyAttribute(isReadOnly: !configuration.Editable.Value));                 
                 return;
             }
         }
    }
}
