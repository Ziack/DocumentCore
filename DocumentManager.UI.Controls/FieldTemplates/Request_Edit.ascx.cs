using DocumentManager.Core;
using DocumentManager.Core.Attributes;
using DocumentManager.Core.Schema;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DocumentManager.UI.Controls.FieldTemplates
{
    public partial class Request_Edit : FieldUserControl
    {
        private ParametersCollection Parameters;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Column.Attributes.OfType<ParametersAttribute>().SingleOrDefault() != null)
                this.Parameters = Column.Attributes.OfType<ParametersAttribute>().SingleOrDefault().Parameters;

            var parameter = this.Parameters.Find(t => t.Key.Equals("Request", StringComparison.InvariantCultureIgnoreCase));

            if (parameter != null)
                this.HiddenField.Value = Request[parameter.Value];
        }

        protected override void ExtractValues(IOrderedDictionary dictionary)
        {
            dictionary[Column.Name] = HiddenField.Value;
        }

        protected override void OnDataBinding(EventArgs e)
        {
            base.OnDataBinding(e);

            if (Mode == DataBoundControlMode.Edit)
                HiddenField.Value = FieldValueEditString;
        }

        public override Control DataControl
        {
            get
            {
                return HiddenField;
            }
        }
    }
}