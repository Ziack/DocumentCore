using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DocumentManager.Core.Schema
{
    [Serializable]
    [XmlRoot("ContentType", Namespace = "http://schemas.facturecolombia.com/ContentRepository/ContentTypeDefinition", IsNullable = false)]
    [XmlType("ContentType")]
    public class ContentType
    {
        [XmlAttribute(AttributeName = "name")]
        public String Name { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public String Type { get; set; }

        [XmlAttribute(AttributeName = "parentType")]
        public String ParentType { get; set; }

        [XmlAttribute(AttributeName = "handler")]
        public String Handler { get; set; }

        [XmlElement(ElementName = "DisplayName")]
        public String DisplayName { get; set; }

        [XmlElement(ElementName = "Description")]
        public String Description { get; set; }

        [XmlArray("Fields")]
        [XmlArrayItem("Field")]
        public FieldCollection Fields { get; set; }

    }
}
