using System;
using System.Collections.Generic;
using System.Activities;
using System.Xml.Linq;
using DocumentManager.Core.Base.Handlers;
using System.Reflection;
using DocumentManager.Core.Schema;
using DocumentManager.Base;
using Facture.WorkflowServer.Extensions.Participants;
using System.Data;

namespace DocumentManager.Core.Activities.Base
{

    public abstract class DocumentActionActivity<TResult> : CodeActivity<TResult>
    {
        #region Arguments

        [RequiredArgument]
        public InArgument<DocumentContent> DocumentArgument { get; set; }

        #endregion

        private XContainer _document;

        protected ContentHandler Handler { get; private set; }

        protected override TResult Execute(CodeActivityContext context)
        {
            _document = context.GetValue(this.DocumentArgument).Content;

            var contentTypeName = (_document as XElement).Attribute("contentType").Value;

            Assembly handlerAssembly;
            var contentType = DocumentController.LoadFromAssembly(String.Format("{0}.xml", contentTypeName), out handlerAssembly);

            Type handlerType = handlerAssembly.GetType(contentType.Handler);

            this.Handler = (ContentHandler)Activator.CreateInstance(handlerType, new object[] { _document, contentType });

            IList<String> errorMessages = new List<String>();
            IList<Rules> rulesExecute = new List<Rules>();

            return Execute(context, ref errorMessages, ref rulesExecute);
        }

        public abstract TResult Execute(ActivityContext context, ref IList<String> errorMessages, ref IList<Rules> rulesExecute);
    }

    public abstract class DocumentActionActivity : CodeActivity
    {
        #region Arguments

        [RequiredArgument]
        public InArgument<DocumentContent> DocumentArgument { get; set; }


        public OutArgument<Int64> DocumentId { get; set; }

        public OutArgument<String> Content { get; set; }

        #endregion

        private XContainer _document;

        protected ContentHandler Handler { get; private set; }

        protected override void Execute(CodeActivityContext context)
        {
            _document = context.GetValue(this.DocumentArgument).Content;

            var contentTypeName = (_document as XElement).Attribute("contentType").Value;
            
            Assembly handlerAssembly;
            var contentType = DocumentController.LoadFromAssembly(String.Format("{0}.xml", contentTypeName), out handlerAssembly);

            Type handlerType = handlerAssembly.GetType(contentType.Handler);

            var connection = context.GetExtension<ConnectionManagerExtension>().Instance["FactureColombia.PuertoBahia"];

            this.Handler = (ContentHandler)Activator.CreateInstance(handlerType, new object[] { _document, contentType, connection });

            IList<String> errorMessages = new List<String>();
            IList<Rules> rulesExecute = new List<Rules>();            

            Execute(context, ref errorMessages, ref rulesExecute);
        }

        public abstract void Execute(ActivityContext context, ref IList<String> errorMessages, ref IList<Rules> rulesExecute);
    }
}
