using DocumentManager.Core.Helpers.XmlToDynamic;
using DocumentManager.Core.Schema;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.Core.Helpers
{
    public class DynamicTypeDescriptor : CustomTypeDescriptor
    {
        private DynamicElement dynamicElement;

        private ContentType contentType;

        public Object this[String key]
        {
            get
            {
                if (key == "Valid")
                    return this.Valid();

                return dynamicElement.SubElements[key].InternalValue;
            }
        }

        public DynamicTypeDescriptor(DynamicElement dynamicElement, ContentType contentType = null)
        {
            this.dynamicElement = dynamicElement;
            this.contentType = contentType;
        }

        public override PropertyDescriptorCollection GetProperties()
        {
            List<DynamicPropertyDescriptor> props;

            if (contentType != null)
            {

                props = (from item in contentType.Fields
                        let field = dynamicElement.SubElements.SingleOrDefault( t => t.Key.Equals(item.Name, StringComparison.InvariantCultureIgnoreCase))
                        select new DynamicPropertyDescriptor(
                            new DictionaryEntry
                            {
                                Key = item.Name,
                                Value = field.Value
                            },
                            item
                        )).ToList();
                
            }
            else
            {

                props = (from item in dynamicElement.SubElements                        
                        select new DynamicPropertyDescriptor(
                            new DictionaryEntry
                            {
                                Key = item.Key,
                                Value = item.Value
                            },
                            null
                        )).ToList();

            }

            return new PropertyDescriptorCollection(props.ToArray());

        }

        public String Valid()
        {
            var IsValid = true;

            contentType.Fields.ForEach(field =>
                {
                    if (field.Configuration.Required)
                        IsValid = IsValid && dynamicElement.SubElements.ContainsKey(field.Name);
                });

            return Convert.ToString(IsValid);
        }
    }
}
