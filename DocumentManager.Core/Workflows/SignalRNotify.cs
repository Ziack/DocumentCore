using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using Microsoft.AspNet.SignalR;
using Facture.WorkflowServer.Hubs;

namespace DocumentManager.Core.Workflows
{

    public sealed class SignalRNotify<TResult> : CodeActivity
    {
        [RequiredArgument]
        public InArgument<Boolean> Success { get; set; }

        public InArgument<TResult> Message { get; set; }

        public InArgument<dynamic> Id { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var message = context.GetValue(this.Message);
            var success = context.GetValue(this.Success);
            var id = context.GetValue(this.Id);

            var signalRContext = GlobalHost.ConnectionManager.GetHubContext<RevokeHub>();
            signalRContext.Clients.All.Notify(message: new 
            {
                message = message,
                success = success,
                id = id
            });
        }
    }
}
