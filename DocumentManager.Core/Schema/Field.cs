using System;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DocumentManager.Core.Schema
{
    [Serializable]
    [XmlRootAttribute("Field", IsNullable = false)]
    [XmlType("Field")]
    public class Field
    {
        [XmlAttribute(AttributeName = "name")]
        public String Name { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public String Type { get; set; }

        [XmlElement(ElementName = "DisplayName")]
        public String DisplayName { get; set; }

        [XmlElement(ElementName = "Description")]
        public String Description { get; set; }

        [XmlElement(ElementName = "Configuration")]
        public Configuration Configuration { get; set; }  
    }
}
