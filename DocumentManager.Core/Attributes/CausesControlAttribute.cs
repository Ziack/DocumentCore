using DocumentManager.Core.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.Core.Attributes
{
    public class CausesControlAttribute : Attribute
    {
        public String Cause { get; private set; }

        public CausesControlAttribute(String cause)
        {
            this.Cause = cause;
        }

        public static void Apply(Configuration configuration, ref List<Attribute> attributes)
        {
            if (!String.IsNullOrEmpty(configuration.Cause))
            {
                attributes.Add(new CausesControlAttribute(configuration.Cause));
                return;
            }
        }
    }
}
