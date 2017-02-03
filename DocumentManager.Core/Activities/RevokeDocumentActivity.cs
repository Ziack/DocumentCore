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
    public sealed class RevokeDocumentActivity : DocumentActionActivity
    {
        public OutArgument<String> ErrorMessage { get; set; }

        public OutArgument<dynamic> HandlerId { get; set; }

        public OutArgument<Boolean> IsSuccess { get; set; }

        public override void Execute(ActivityContext context, ref IList<String> errorMessages, ref IList<Rules> rulesExecute)
        {
            this.HandlerId.Set(context, Handler.Id);

            try
            {
                Handler.Revoke();
                IsSuccess.Set(context, true);
            }
            catch (Exception ex)
            {
                errorMessages.Add(ex.Message);
                ErrorMessage.Set(context, ex.Message);
                IsSuccess.Set(context, false);
            }

            Handler.Revoke();                       
        }
    }
}
