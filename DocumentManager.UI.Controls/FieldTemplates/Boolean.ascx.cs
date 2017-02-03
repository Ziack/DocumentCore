using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Web.DynamicData;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DocumentManager.Core;
using System.ComponentModel.Composition;

namespace DocumentManager.UI.Controls.FieldTemplates
{
    [Export(typeof(FieldUserControl))]
    [ExportMetadata("type", "BooleanField")]
    [ExportMetadata("title", "BooleanField")]
    [ExportMetadata("description", "Propiedad Boolean")]
    public partial class BooleanField : FieldUserControl
    {

        protected override void OnDataBinding(EventArgs e)
        {
            base.OnDataBinding(e);

            if (FieldValue != null)
            {
                var val = Convert.ToInt32(FieldValue.ToString());
                CheckBox1.Checked = Convert.ToBoolean(val);
            }
        }

        protected void CheckBox1_Init(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            checkBox.Text = this.Column.DisplayName;
        }

        public override Control DataControl
        {
            get
            {
                return CheckBox1;
            }
        }

    }
}
