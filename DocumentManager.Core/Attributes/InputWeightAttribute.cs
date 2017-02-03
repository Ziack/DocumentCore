using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocumentManager.Core.Attributes{
    public class InputWeightAttribute : Attribute
    {
        public string EndpointAddress { get; private set; }
        public string MethodName { get; private set; }
        public string ContractName { get; private set; }
        public string Namespace { get; private set; }

        public InputWeightAttribute(string endpointAddress, string methodName, string contractName,  string @namespace)
        {
            this.EndpointAddress = endpointAddress;
            this.Namespace = @namespace;
            this.ContractName = contractName;
            this.MethodName = methodName;
        }
    }
}