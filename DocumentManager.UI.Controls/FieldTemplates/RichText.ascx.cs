using DocumentManager.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DocumentManager.UI.Controls.FieldTemplates
{
    public partial class RichText : FieldUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected override void OnDataBinding(EventArgs e)
        {
            
        }

        public override Control DataControl
        {
            get
            {
                return TextBox1;
            }
        }
    }
}