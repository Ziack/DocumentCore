using DocumentManager.Core;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DocumentManager.UI.Controls.FieldTemplates
{
    public partial class Hidden_Edit : FieldUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected override void ExtractValues(IOrderedDictionary dictionary)
        {
            dictionary[Column.Name] = HiddenField.Value;
        }
        
        protected override void OnDataBinding(EventArgs e)
        {
            base.OnDataBinding(e);

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