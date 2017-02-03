using DocumentManager.Base;
using System.ServiceModel;

namespace DocumentManager.Core.Workflows
{
    [ServiceContract(Namespace = "http://schemas.facturecolombia.com/ContentRepository/Workflow")]
    public interface IContentWorkflow
    {
        [OperationContract]
        void SaveDraft(DocumentContent document);

        [OperationContract]
        void Save(DocumentContent document);

        [OperationContract]
        void Planning(DocumentContent document);

        [OperationContract]
        ValidationResult Issue(DocumentContent document);

        [OperationContract(IsOneWay=true)]
        void Revoke(DocumentContent document);
    }
}
