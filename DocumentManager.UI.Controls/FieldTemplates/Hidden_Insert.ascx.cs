using DocumentManager.Core;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DocumentManager.UI.Controls.FieldTemplates
{
    [Export(typeof(FieldUserControl))]
    [ExportMetadata("type", "Hidden")]
    [ExportMetadata("title", "Hidden")]
    [ExportMetadata("description", "Propiedad Hidden")]
    public partial class Hidden_Insert : FieldUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected override void ExtractValues(IOrderedDictionary dictionary)
        {
            dictionary[Column.Name] = String.Empty;
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