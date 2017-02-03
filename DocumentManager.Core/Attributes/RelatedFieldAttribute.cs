using DocumentManager.Core.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace DocumentManager.Core.Attributes
{
    public class RelatedFieldAttribute: Attribute
    {
        public String RelatedField { get; private set; }
        public ValidationCompareOperator @Operator { get; private set; }

        public RelatedFieldAttribute(String relatedField, ValidationCompareOperator @operator)
        {
            this.RelatedField = relatedField;
            this.@Operator = @operator;
        }

        public static void Apply(Configuration configuration, ref List<Attribute> attributes)
        {
            if (!String.IsNullOrEmpty(configuration.RelatedField) && configuration.Operator != null)
            {
                attributes.Add(new RelatedFieldAttribute(relatedField: configuration.RelatedField, @operator: configuration.Operator.Value));
            }
        }
    }
}
