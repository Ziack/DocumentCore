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
    public partial class ContentID : FieldUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public override Control DataControl
        {
            get
            {
                return hidden;
            }
        }
    }
}