using DocumentManager.Core.Helpers.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DocumentManager.Core.Helpers.DictionaryObject
{
    public static class DictionaryObjectExtensions
    {
        /// <summary>
        /// Defines the simple types that is directly writeable to XML.
        /// </summary>
        private static readonly Type[] _writeTypes = new[] { typeof(String), typeof(DateTime), typeof(Enum), typeof(Decimal), typeof(Guid), typeof(Boolean), typeof(Byte), typeof(Char), typeof(Int16), typeof(Int32), typeof(Int64), typeof(Single), typeof(Double) };
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
        /// Converts an DictionaryObject to XElement
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static XElement ToXElement(this DictionaryObject e)
        {
            return (dynamic)XElementFromElastic(e);
        }

        /// <summary>
        /// Converts an DictionaryObject to XElement
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static String ToJSON(this DictionaryObject e)
        {
            var jObject = new JObject();
            foreach (var element in e.Dictionary.OfType<DictionaryEntry>())
            {                
                jObject[element.Key] = JObject.FromObject(element.Value);                
            }
            
            return jObject.ToString();
        }

        /// <summary>
        /// Returns an XElement from an DictionaryObject
        /// </summary>
        /// <param name="elastic">An <see cref="T:DocumentManager.Core.Helpers.DictionaryObject.DictionaryObject" /> object that contains the elastic object.</param>
        /// <returns>An <see cref="T:System.Xml.Linq.XElement" /> object.</returns>
        public static XElement XElementFromElastic(DictionaryObject elastic)
        {

            var exp = new XElement(elastic.InternalName);

            if (!String.IsNullOrEmpty(elastic.Handler))
                exp.SetAttributeValue("handler", elastic.Handler);

            foreach (DictionaryEntry a in elastic.Dictionary)
            {
                if (a.Value != null)
                {
                    
                    //Obtiene los tipos de datos simple y los coloca como xml Campo Valor
                    if (a.Value.GetType().IsSimpleType())
                    {
                        exp.Add(new XElement(Convert.ToString(a.Key), Convert.ToString(a.Value)));
                        continue;
                    }

                    //TODO: Falta limpiar los NS de los XNodes
                    //Convierte los tipos de datos complejos a xml
                    var complexXmlElement = XmlSerializerHelpers.Serialize(a.Value, Convert.ToString(a.Key));
                    
                    exp.Add(complexXmlElement);
                }
            }

            return exp;
        }
    }
}
