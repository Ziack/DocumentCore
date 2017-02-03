using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentManager.Core.Schema;

namespace DocumentManager.Core.Attributes
{
    public class ConstantAttribute : Attribute
    {
        public string Value { get; private set; }

        public ConstantAttribute(String value)
        {
            this.Value = value;
        }

        public static void Apply(Configuration configuration, ref List<Attribute> attributes)
        {
            if (configuration.Value != null)
            {
                attributes.Add(new ConstantAttribute(configuration.Value));
                return;
            }

        }
    }
}