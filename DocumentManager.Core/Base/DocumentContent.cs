using DocumentManager.Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DocumentManager.Base
{ 
    [DataContract]
    [KnownType(typeof(XElement))]
    [KnownType(typeof(XDocument))]
    [TypeConverter(typeof(DocumentContentTypeConverter))]
    public class DocumentContent
    {
        [DataMember]
        public XContainer Content { get; private set; }

        public DocumentContent(XContainer content)
        {
            this.Content = content;
        }

        [DataMember]
        public Guid Id
        {
            get
            {                
                if ((this.Content as XElement).Attribute("Id") != null)
                    return Guid.Parse((this.Content as XElement).Attribute("Id").Value);

                return Guid.Parse(this.Content.Element("Id").Value); 
            }

            set 
            {
                if ((this.Content as XElement).Attribute("Id") != null)
                    (this.Content as XElement).Attribute("Id").Value = Convert.ToString(value);
                else
                    this.Content.Element("Id").Value = Convert.ToString(value);
            }

        }

        public override string ToString()
        {
            return Convert.ToString(this.Content);
        }
    }
}
