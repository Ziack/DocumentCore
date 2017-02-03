using DocumentManager.Base;
using System;
using System.ServiceModel;

namespace DocumentManager.Core.Workflows.Interfaces
{
    public interface IContentDocumentWorkflow
    {
        //[RESTClient(workflowDefinitionName: "ArinReciboLiquido", scope: "1.0.0.0")]
        void SaveDraft(String guid, String document);

        //[RESTClient(workflowDefinitionName: "ArinReciboLiquido", stage: "SAVE", scope: "1.0.0.0")]
        void Save(String guid, String document);

        //[RESTClient(workflowDefinitionName: "ArinReciboLiquido", stage: "PLANNING", scope: "1.0.0.0")]
        void Planning(String guid, String document);

        //[RESTClient(workflowDefinitionName: "ArinReciboLiquido", stage: "ISSUE", scope: "1.0.0.0")]
        dynamic Issue(String guid, String document);

        //[RESTClient(workflowDefinitionName: "ArinReciboLiquido", stage: "REVOKE", scope: "1.0.0.0")]
        void Revoke(String guid, String document);
    }
}
