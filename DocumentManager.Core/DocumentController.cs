using DocumentManager.Core.Base.Handlers;
using DocumentManager.Core.Helpers.Utilities;
using DocumentManager.Core.Schema;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using DocumentManager.Core.Schema.Behavior;
using System.Configuration;

namespace DocumentManager.Core
{
    public static class DocumentController
    {
        public static ContentType LoadFromAssembly(string resourceName)
        {
            Assembly contentTypeAssembly;            

            var xmlStream = GetResourceFromAnyAssembly(resourceName, out contentTypeAssembly);

            if (xmlStream == null)
                throw new ArgumentException(String.Empty, resourceName);

            var xmlForm = XDocument.Load(new StreamReader(xmlStream, UTF8Encoding.Default));
            var form = XmlSerializerHelpers.Deserialize<ContentType>(xmlForm);

            form.Fields = GetParentFields(form).Fields;

            return form;
        }

        public static ContentType LoadFromAssembly(string resourceName, out Assembly contentTypeAssembly)
        {
            var xmlStream = GetResourceFromAnyAssembly(resourceName, out contentTypeAssembly);            

            if (xmlStream == null)
                throw new ArgumentException(String.Empty, resourceName);

            var xmlForm = XDocument.Load(new StreamReader(xmlStream, UTF8Encoding.Default));
            var form = XmlSerializerHelpers.Deserialize<ContentType>(xmlForm);

            form.Fields = GetParentFields(form).Fields;

            return form;
        }

        public static ContentHandler GetHandler(String handlerName, XElement document, ContentType contentType)
        {
            Assembly handlerAssembly = null;

            var binAssemblies = LoadAllAssemblyInBin().ToList<Assembly>();

            AppDomain.CurrentDomain.GetAssemblies().ToList().ForEach(binAssemblies.Add);

            foreach (var assembly in binAssemblies)
            {
                var result = assembly.GetType(handlerName);

                if (result != null)                
                    handlerAssembly = assembly;                
            }

            if (handlerAssembly == null)
                throw new ArgumentOutOfRangeException(handlerName);

            Type handlerType = handlerAssembly.GetType(handlerName);

            return (ContentHandler)Activator.CreateInstance(handlerType, new object[] { document, contentType });
        }

        public static TResult GetHandler<TResult>(String handlerName, XElement document, ContentType contentType)     
            where TResult : class
        {
            return GetHandler(handlerName: handlerName, document: document, contentType: contentType) as TResult;
        }

        private static Stream GetResourceFromAnyAssembly(string resourceName, out Assembly contentTypeAssembly)
        {
            Stream resourceStream = null;
            contentTypeAssembly = null;

            var binAssemblies = LoadAllAssemblyInBin().ToList<Assembly>();

            AppDomain.CurrentDomain.GetAssemblies().ToList().ForEach(binAssemblies.Add);

            foreach (var assembly in binAssemblies)
            {
                if (!assembly.IsDynamic)
                {
                    var result = assembly.GetManifestResourceStream(resourceName);
                    if (result != null)
                    {
                        resourceStream = result;
                        contentTypeAssembly = assembly;
                    }
                }
            }            

            return resourceStream;
        }

        private static ContentType GetParentFields(ContentType contentType)
        {
            Assembly contentTypeAssembly;

            if (String.IsNullOrEmpty(contentType.ParentType))
                return contentType;

            Stream xmlParentStream = GetResourceFromAnyAssembly(String.Format("{0}.xml", contentType.ParentType), out contentTypeAssembly);
            
            if (xmlParentStream == null)
                return contentType;

            var xmlParentForm = XDocument.Load(new StreamReader(xmlParentStream, UTF8Encoding.Default));
            var parentForm = XmlSerializerHelpers.Deserialize<ContentType>(xmlParentForm);

            var fields = contentType.Fields;

            parentForm.Fields.ForEach(delegate(Field field)
            {
                if (!fields.Exists(t => t.Name == field.Name))
                    fields.Add(field);
            });

            parentForm.Fields = fields;

            return GetParentFields(parentForm);
        }

        /// <summary>
        /// 
        /// </summary>
        private static IEnumerable<Assembly> LoadAllAssemblyInBin()
        {
            string binPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            
            foreach (string dll in Directory.GetFiles(binPath, "*.dll"))
                yield return Assembly.LoadFile(dll);
         
            var handlersDirectory = ConfigurationManager.AppSettings["DocumentCore.HandlersDirectory"];

            if (!String.IsNullOrEmpty(handlersDirectory))
            {
                foreach (string dll in Directory.GetFiles(handlersDirectory, "*.dll"))
                    yield return Assembly.LoadFile(dll);
            }
        }
    }
}
