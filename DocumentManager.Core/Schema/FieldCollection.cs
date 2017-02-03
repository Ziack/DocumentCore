using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DocumentManager.Core.Schema
{
    [Serializable]
    [XmlRootAttribute("Fields", Namespace = "", IsNullable = false)]
    public class FieldCollection : List<Field>
    {
    }
}
