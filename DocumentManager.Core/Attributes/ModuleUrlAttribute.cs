using DocumentManager.Core.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.Core.Attributes
{
    public class ModuleUrlAttribute : Attribute
    {
        public string ModuleName { get; set; }
        public string ControlKey { get; set; }
        public ParametersCollection Parameters { get; set; }

        public ModuleUrlAttribute(string moduleName, string controlKey, ParametersCollection parameters)
        {
            this.ModuleName = moduleName;
            this.ControlKey = controlKey;
            this.Parameters = parameters;
        }

        public static void Apply(Configuration configuration, ref List<Attribute> attributes)
        {
            if (!String.IsNullOrEmpty(configuration.ModuleName) && !String.IsNullOrEmpty(configuration.ControlKey))
            {
                attributes.Add(new ModuleUrlAttribute(moduleName: configuration.ModuleName,
                                                       controlKey: configuration.ControlKey,
                                                       parameters: configuration.Parameters));
                return;
            }

        }
    }
}
