using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DocumentManager.Core.Schema
{
    [Serializable]
    [XmlRoot("Parameter", IsNullable = false)]
    [XmlType("Parameter")]
    public class Parameter
    {
        [XmlElement(ElementName = "Key")]
        public String Key { get; set; }

        [XmlElement(ElementName = "Value")]
        public String Value { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public String Type { get; set; }

        [XmlAttribute(AttributeName = "usage")]
        public String Usage { get; set; }
    }
}
