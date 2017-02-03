using DocumentManager.Core.Activities.Base;
using System;
using System.Activities;
using System.Collections.Generic;
using DocumentManager.Core.Schema;
using DocumentManager.Base;

namespace DocumentManager.Core.Activities
{
    public sealed class IssueDocumentActivity : DocumentActionActivity<DocumentContent>
    {
        public override DocumentContent Execute(ActivityContext context, ref IList<String> errorMessages, ref IList<Rules> rulesExecute)
        {
            return new DocumentContent(Handler.Issue());
        }
    }
}