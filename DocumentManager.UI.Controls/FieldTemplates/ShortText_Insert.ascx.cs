using DocumentManager.Core;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.DynamicData;
using Newtonsoft.Json.Linq;

namespace DocumentManager.UI.Controls.FieldTemplates
{
    public partial class ShortText_Insert : FieldUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.ToolTip = Column.Description;

            SetUpValidator(RequiredFieldValidator1);
            SetUpValidator(RegularExpressionValidator1);
            SetUpValidator(DynamicValidator1);

            var maxLengthAttribute = Column.Attributes.OfType<MaxLengthAttribute>().SingleOrDefault();

            if (maxLengthAttribute != null)
                TextBox1.MaxLength = maxLengthAttribute.Length;

            if(Column.IsRequired) RequiredFieldValidator1.ErrorMessage = Column.ErrorMessage();                       
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