using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DocumentManager.Core;

namespace DocumentManager.UI.Controls.FieldTemplates
{

    public partial class EmailAddressField : FieldUserControl
    {
       protected override void OnDataBinding(EventArgs e)
        {
            string url = FieldValueString;
            if (!url.StartsWith("mailto:", StringComparison.OrdinalIgnoreCase))
            {
                url = "mailto:" + url;
            }
            HyperLink1.NavigateUrl = url;
        }

        public override Control DataControl
        {
            get
            {
                return HyperLink1;
            }
        }

    }
}
