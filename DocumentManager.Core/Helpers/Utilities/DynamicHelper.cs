using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using DocumentManager.Core.Helpers.Utilities;
using DocumentManager.Core.Schema;

namespace DocumentManager.Core.Helpers.Utilities
{
    public static class DynamicHelper
    {
        /// <summary>
        /// Defines the simple types that is directly writeable to XML.
        /// </summary>
        private readonly static Type[] _writeTypes = new[] { typeof(String), typeof(DateTime), typeof(Enum), typeof(Decimal), typeof(Guid), typeof(Boolean), typeof(Byte), typeof(Char), typeof(Int16), typeof(Int32), typeof(Int64), typeof(Single), typeof(Double) };

        /// <summary>
        /// Determines whether [is simple type] [the specified type].
        /// </summary>
        /// <param name="type">The type to check.</param>
        /// <returns>
        /// 	<c>true</c> if [is simple type] [the specified type]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsSimpleType(this Type type)
        {
            return type.IsPrimitive || _writeTypes.Contains(type);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="props"></param>
        /// <param name="contentTypeName"></param>
        /// <param name="handler"></param>
        /// <returns></returns>
        public static XElement ParseDocument(this IEnumerable<DictionaryEntry> props, ContentType contentType, string rootName = null)
        {
            var doc = String.IsNullOrEmpty(rootName) ? new XElement(contentType.Name) : new XElement(rootName);
            doc.SetAttributeValue("contentType", contentType.Type);

            var elements = from prop in props
                           let name = XmlConvert.EncodeName(Convert.ToString(prop.Key))
                           let value = prop.Value is IList ? GetArrayElement(Convert.ToString(prop.Key), (IList)prop.Value) :
                                        (IsSimpleType(prop.GetType()) ? new XElement(name, prop.Value) : XmlSerializerHelpers.Serialize(prop.Value, Convert.ToString(prop.Key)))
                           where value != null
                           select value;

            doc.Add(elements);

            return doc;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        private static XElement GetArrayElement(string propertyName, IList input)
        {
            var name = XmlConvert.EncodeName(propertyName);

            XElement rootElement = new XElement(String.Format("ArrayOf{0}", name));

            var arrayCount = input.Count;

            for (int i = 0; i < arrayCount; i++)
            {
                var val = input[i];
                XElement childElement = XmlSerializerHelpers.Serialize(val, String.Empty);

                rootElement.Add(childElement);
            }

            return rootElement;
        }
    }
}
