using DocumentManager.Core.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.Core.Attributes
{
    public class ContentTypeAttribute: Attribute
    {
        public String ContentType { get; private set; }

        public ContentTypeAttribute(ContentType contentType)
        {
            this.ContentType = contentType.Type;
        }        
    }
}
