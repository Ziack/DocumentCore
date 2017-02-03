using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.DynamicData;

namespace DocumentManager.Core
{
    public abstract class FieldUserControl : FieldTemplateUserControl
    {
        public string Name { get; set; }
        public Type Type { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }

        public virtual void SetUp(JToken value) { }

        public virtual void CausesValidation(Boolean value) { }
    }
}
