using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Web.DynamicData;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Linq;
using DocumentManager.Core.Attributes;
using DocumentManager.Core;
using Newtonsoft.Json.Linq;

namespace DocumentManager.UI.Controls.FieldTemplates
{
    public partial class Constante_EditField : FieldUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = Column.Attributes.OfType<ConstantAttribute>().SingleOrDefault().Value;
        }

        protected override void OnDataBinding(EventArgs e)
        {
            base.OnDataBinding(e);
        }

        protected override void ExtractValues(IOrderedDictionary dictionary)
        {
            dictionary[Column.Name] = ConvertEditedValue(Label2.Text);
        }

        public override Control DataControl
        {
            get
            {
                return Label2;
            }
        }

        public override void SetUp(JToken value)
        {
            if (value == null)
                return;

            this.Label2.Text = value.Value<String>();
        }

    }
}
