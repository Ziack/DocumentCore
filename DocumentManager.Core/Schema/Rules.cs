using System;
using System.Xml.Serialization;

namespace DocumentManager.Core.Schema
{
    [Serializable]
    [XmlRootAttribute("Rule", IsNullable = false)]
    [XmlType("Rule")]
    public class Rules
    {
        public long CheckListId { get; set; }

        public Boolean State { get; set; }

        public RulesRestricion StateName { get; set; }

        public RulesApplies Apply { get; set; }

        public String RuleName { get; set; }

        public string Driver { get; set; }

        public string Plate { get; set; }

        public string ErrorMessage { get; set; }

        public bool CanInvalidate { get; set; }
    }
}