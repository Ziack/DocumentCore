using DocumentManager.Core.Helpers.Utilities;
using DocumentManager.Core.Schema;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DocumentManager.Core.Base.Handlers
{
    public abstract class ContentHandler
    {
        /// <summary>
        /// Defines the simple types that is directly writeable to XML.
        /// </summary>
        private readonly Type[] _writeTypes = new[] { typeof(String), typeof(DateTime), typeof(Enum), typeof(Decimal), typeof(Guid), typeof(Boolean), typeof(Byte), typeof(Char), typeof(Int16), typeof(Int32), typeof(Int64), typeof(Single), typeof(Double)};

        public XContainer Document { get; set; }

        protected ContentType ContentType { get; set; }

        protected IDbConnection Repository { get; set; }

        public ContentHandler(XContainer document, ContentType contentType)
        {
            this.ContentType = contentType;
            this.Document = document;
        }

        public ContentHandler(XContainer document, ContentType contentType, IDbConnection connection)
            : this(document: document, contentType: contentType )
        {
            this.Repository = connection;
        }

        public abstract dynamic Id { get; set; }

        public abstract void Save();

        public abstract void SaveDraft();

        public abstract XContainer LoadDraft();

        public abstract XContainer Issue();

        public abstract bool Validate(ref IList<String> errorMessages, ref IList<Rules> rulesExecute);

        public abstract void Revoke();

        #region Helpers

        public TResult GetField<TResult>(XName fieldName)
        {
            if (Document.Nodes().OfType<XElement>().Count(t => t.Name == fieldName) != 1)
                throw new ArgumentOutOfRangeException(String.Format("El documento no contiene ningún elemento con el nombre {0}", fieldName));
            
            var node = Document.Nodes().OfType<XElement>().Single(t => t.Name == fieldName);
            var tempNode = XElement.Parse(node.ToString());

            string rootName = GetRootName(typeof(TResult));

            if (!typeof(TResult).GetInterfaces().Contains(typeof(IList)))
                tempNode.Name = XName.Get(rootName);

            return XmlSerializerHelpers.Deserialize<TResult>(tempNode);
        }

        public Object GetField(XName fieldName)
        {
            if (Document.Nodes().OfType<XElement>().Count(t => t.Name == fieldName) != 1)
                throw new ArgumentOutOfRangeException(String.Format("El documento no contiene ningún elemento con el nombre {0}", fieldName));

            var node = Document.Nodes().OfType<XElement>().Single(t => t.Name == fieldName);
            var tempNode = XElement.Parse(node.ToString());

            string rootName = GetRootName(typeof(Object));

            if (!typeof(Object).GetInterfaces().Contains(typeof(IList)))
                tempNode.Name = XName.Get(rootName);

            return XmlSerializerHelpers.Deserialize<Object>(tempNode);
        }

        public bool ContainField(XName fieldName)
        {
            return Document.Nodes().OfType<XElement>().Count(t => t.Name == fieldName) >= 1;
        }

        public bool FieldIsNullOrEmpty(XName fieldName)
        {
            if (!ContainField(fieldName))
                return true;

            var node = Document.Nodes().OfType<XElement>().Single(t => t.Name == fieldName);

            return String.IsNullOrEmpty(node.Value);
        }

        private string GetRootName(Type nodeType)
        {
            return _writeTypes.Contains(nodeType) ? Char.ToLowerInvariant(nodeType.Name[0]) + nodeType.Name.Substring(1) : nodeType.Name;
        }

        #endregion
    }
}