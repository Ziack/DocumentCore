using System;
using System.Collections.Generic;
using System.Data.Entity.Design.PluralizationServices;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DocumentManager.Core.Helpers.XmlToDynamic
{
    public static class XElementExtensions
    {
        public static dynamic ToDynamic(this XElement element)
        {
            var item = new DynamicElement(element.Name.LocalName);

            // Add sub-elements
            if (element.HasElements)
            {
                var arrayElements = element.Elements().Where(t => t.Name.LocalName.StartsWith("ArrayOf"));
                var uniqueElements = element.Elements().Except(arrayElements);


                foreach (var repeatedElementGroup in arrayElements.GroupBy(re => re.Name.LocalName).OrderBy(el => el.Key))
                {
                    var list = new List<dynamic>();
                    foreach (var repeatedElement in repeatedElementGroup.Elements())
                        list.Add(ToDynamic(repeatedElement));

                    item.SubElements.Add(repeatedElementGroup.Key.Replace("ArrayOf", String.Empty), list);
                }

                foreach (var uniqueElement in uniqueElements.OrderBy(el => el.Name.LocalName))
                {
                    item.SubElements
                        .Add(uniqueElement.Name.LocalName, ToDynamic(uniqueElement));
                }
            }

            // Add attributes, if any
            if (element.Attributes().Any())
            {
                foreach (var attribute in element.Attributes())
                    item[attribute.Name.LocalName] = attribute.Value;
            }

            // Add value
            item.InternalValue = element.Value;

            return item;
        }
    }
}
