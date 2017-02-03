using System;
using System.Collections.Specialized;
using System.Web.UI;
using System.Web.UI.WebControls;
using DocumentManager.Core;
using System.Web;

namespace DocumentManager.UI.Controls.FieldTemplates
{
    public partial class Boolean_Edit : FieldUserControl
    {
        protected override void OnDataBinding(EventArgs e)
        {
            base.OnDataBinding(e);

            if (FieldValue != null)
            {
                try
                {
                    int val = Convert.ToInt32(FieldValue.ToString());
                    CheckBox1.Checked = Convert.ToBoolean(val);
                }
                catch (Exception)
                {
                    if (FieldValue != null)
                    {
                        CheckBox1.Checked = Convert.ToBoolean(FieldValue);
                    }
                    else
                    {
                        CheckBox1.Checked = false;
                    }

                }

            }
        }


        protected void CheckBox1_Init(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            checkBox.Text = this.Column.DisplayName;
        }

        protected override void ExtractValues(IOrderedDictionary dictionary)
        {
            dictionary[Column.Name] = CheckBox1.Checked ? 1 : 0;
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
