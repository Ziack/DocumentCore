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
    public partial class ContentID_Edit : FieldUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected override void OnDataBinding(EventArgs e)
        {
            base.OnDataBinding(e);

            if (FieldValue != null)
            {
                ContentIdHidden.Value = Convert.ToString(FieldValue);
            }
        }

        protected override void ExtractValues(IOrderedDictionary dictionary) 
        {
            dictionary[Column.Name] = ContentIdHidden.Value;
        }
    }
}