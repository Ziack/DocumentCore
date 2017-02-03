using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace DocumentManager.Core.Attributes
{
    public class FieldInfoAttribute : Attribute
    {
        public XDocument AdditionalInfo { get; private set; }

        public FieldInfoAttribute(XDocument additionalInfo)
        {
            this.AdditionalInfo = additionalInfo;
        }        
    }
}
