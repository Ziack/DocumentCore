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

namespace DocumentManager.UI.Controls.FieldTemplates.Mobile
{
    public partial class Sesion_EditField : FieldUserControl
    {
        #region WebControls

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = Session[Column.Attributes.OfType<ConstantAttribute>().SingleOrDefault().Value].ToString();
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
    }
}
