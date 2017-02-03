using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DocumentManager.Core.Helpers.Utilities
{
    public static class XmlSerializerHelpers
    {
        public static T Deserialize<T>(XContainer doc)
        {
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = XElement.Parse(Convert.ToString(doc)).Name.LocalName;
            xRoot.Namespace = XElement.Parse(Convert.ToString(doc)).Name.Namespace.NamespaceName;
            xRoot.IsNullable = true;

            var serializer = new XmlSerializer(typeof(T), xRoot);

            try
            {
                using (var reader = doc.CreateReader())
                {
                    return (T)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                throw new SerializationException(ex.InnerException.Message, ex);
            }
        }

        public static XContainer Serialize<T>(T value)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            var ns = Attribute.GetCustomAttribute(typeof(T), typeof(XmlRootAttribute)) as XmlRootAttribute;
            var doc = new XDocument();

            using (var writer = doc.CreateWriter())
            {
                var xmlNamespaces = new XmlSerializerNamespaces();
                xmlNamespaces.Add(String.Empty, ns.Namespace);
                xmlSerializer.Serialize(writer, value, xmlNamespaces);
            }

            return doc;
        }

        public static XElement Serialize(object target, string rootName = null)
        {
            if (target == null)
                target = "";

            var ns = new XmlSerializerNamespaces();
            ns.Add(String.Empty, String.Empty);

            var sb = new StringBuilder();
            var serializer = new XmlSerializer(target.GetType());

            using (TextWriter writer = new StringWriter(sb))
            {
                serializer.Serialize(writer, target, ns);
            }

            var xml = XElement.Parse(sb.ToString());
            xml = RemoveNamespace(xml);

            if (!String.IsNullOrEmpty(rootName))
                xml.Name = XName.Get(Convert.ToString(rootName), String.Empty);

            return xml;
        }

        /// <summary>
        /// Elimina los namespace que se agregan al modificar el xml
        /// </summary>
        private static XElement RemoveNamespace(XElement document)
        {
            foreach (XElement element in document.DescendantsAndSelf())
            {
                element.Name = XName.Get(element.Name.LocalName, String.Empty);
                element.RemoveAttributes();
            }

            return document;
        }
    }
}
