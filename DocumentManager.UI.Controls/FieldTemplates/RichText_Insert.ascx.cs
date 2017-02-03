using DocumentManager.Core;
using Newtonsoft.Json.Linq;
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
    public partial class RichText_Insert : FieldUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected override void ExtractValues(IOrderedDictionary dictionary)
        {
            dictionary[Column.Name] = TextBox1.Text;
        }

        public override Control DataControl
        {
            get
            {
                return TextBox1;
            }
        }

        public override void SetUp(JToken value)
        {
            if(value == null)
                return;

            this.TextBox1.Text = value.Value<string>();
        }
    }
}