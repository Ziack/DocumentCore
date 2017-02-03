using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using DocumentManager.Core.Activities.Base;
using System.Xml.Linq;
using DocumentManager.Core.Schema;

namespace DocumentManager.Core.Activities
{
    public sealed class SaveDocumentActivity : DocumentActionActivity
    {
        public override void Execute(ActivityContext context, ref IList<String> errorMessages, ref IList<Rules> rulesExecute)
        {
            Handler.Save();

            this.DocumentId.Set(context, Convert.ToInt64(Handler.Id));

            this.Content.Set(context, Convert.ToString(Handler.Document));
        }
    }
}
