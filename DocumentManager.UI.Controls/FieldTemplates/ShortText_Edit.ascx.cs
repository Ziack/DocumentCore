using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Web.DynamicData;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DocumentManager.Core;
using DocumentManager.UI.Helpers;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace DocumentManager.UI.Controls.FieldTemplates
{
    public partial class ShortText_Edit : FieldUserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.ToolTip = Column.Description;

            SetUpValidator(RequiredFieldValidator1);
            SetUpValidator(RegularExpressionValidator1);
            SetUpValidator(DynamicValidator1);
            Boolean? enabled = true;
            var maxLengthAttribute = Column.Attributes.OfType<MaxLengthAttribute>().SingleOrDefault();
            if(Column.Attributes.OfType<DocumentManager.Core.Attributes.EditableAttribute>().Count() > 0)
                enabled = Column.Attributes.OfType<DocumentManager.Core.Attributes.EditableAttribute>().SingleOrDefault().Enabled;
            
            TextBox1.Enabled = enabled.Value;

            if (maxLengthAttribute != null)
                TextBox1.MaxLength = maxLengthAttribute.Length;

            if(Column.IsRequired) RequiredFieldValidator1.ErrorMessage = Column.ErrorMessage();
        }

        protected override void OnDataBinding(EventArgs e)
        {
            base.OnDataBinding(e);
            if (Column.MaxLength > 0)
            {
                TextBox1.MaxLength = Math.Max(FieldValueEditString.Length, Column.MaxLength);
            }

            TextBox1.Text = FieldValueEditString;
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
            if (value == null)
                return;


            this.TextBox1.Text = value.Value<String>();
        }


    }
}
