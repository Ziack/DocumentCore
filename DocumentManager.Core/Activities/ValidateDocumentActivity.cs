using DocumentManager.Core.Activities.Base;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DocumentManager.Core.Schema;

namespace DocumentManager.Core.Activities
{
    public sealed class ValidateDocumentActivity : DocumentActionActivity<Boolean>
    {
        public OutArgument<List<String>> ErrorMessages { get; set; }

        public override bool Execute(ActivityContext context, ref IList<String> errorMessages, ref IList<Rules> rulesExecute)
        {
            var isValid = Handler.Validate(ref errorMessages, ref rulesExecute);
            ErrorMessages.Set(context, errorMessages);

            return isValid;
        }
    }
}
