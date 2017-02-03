using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DocumentManager.Core.Schema
{
    [Serializable]
    [XmlRootAttribute("Parameters", Namespace = "", IsNullable = true)]
    public class ParametersCollection : List<Parameter>
    {
    }
}
