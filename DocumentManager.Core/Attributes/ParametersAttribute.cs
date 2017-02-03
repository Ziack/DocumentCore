using DocumentManager.Core.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.Core.Attributes
{
    public class ParametersAttribute : Attribute
    {
        public ParametersCollection Parameters { get; set; }

        public ParametersAttribute(ParametersCollection parameters)
        {
            this.Parameters = parameters;
        }

        public static void Apply(Configuration configuration, ref List<Attribute> attributes)
        {
            attributes.Add(new ParametersAttribute(parameters: configuration.Parameters));            
        }
    }
}
