using System;
using System.Collections.Specialized;
using System.Web.UI;
using System.Web.UI.WebControls;
using DocumentManager.Core;
using System.ComponentModel.Composition;
using System.Web;
using Newtonsoft.Json.Linq;

namespace DocumentManager.UI.Controls.FieldTemplates
{
    public partial class Boolean_Insert : FieldUserControl
    {
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

        public override void SetUp(JToken value)
        {
            
        }
    }
}
