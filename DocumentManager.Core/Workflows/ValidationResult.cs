using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.Core.Workflows
{
    [DataContract(Namespace = "http://schemas.facturecolombia.com/ContentRepository/Workflow")]
    [Serializable]
    public class ValidationResult : MarshalByRefObject
    {
        [DataMember]
        public List<String> ErrorMessages { get; set; }

        [DataMember]
        public Boolean IsValid { get; set; }        
    }
}
