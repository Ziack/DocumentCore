using DocumentManager.UI.Controls.FieldTemplates.Mobile.Helpers.TemplatesUserControl;
using System;
using System.Collections.Specialized;
using System.ComponentModel.Composition;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web.DynamicData;

namespace DocumentManager.UI.Controls.FieldTemplates
{
    public partial class DropDownList_Edit : ListFieldTemplateUserControl
    {
        public override void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            if (IsPostBack)
            {
                DropDownList1.SelectedValue = Request.Form[DropDownList1.UniqueID];
            }

            SetUpValidator(RequiredFieldValidator1);
            SetUpValidator(DynamicValidator1);

            if(Column.IsRequired) RequiredFieldValidator1.ErrorMessage = Column.ErrorMessage();
        }

        protected override void ExtractValues(IOrderedDictionary dictionary)
        {
            string value = DropDownList1.SelectedValue;
            if (value == String.Empty)
            {
                value = null;
            }
            dictionary[Column.Name] = ConvertEditedValue(value);
        }

        public override Control DataControl
        {
            get
            {
                return DropDownList1;
            }
        }

        protected override void OnDataBinding(EventArgs e)
        {
            base.OnDataBinding(e);

            if (Mode == DataBoundControlMode.Edit && FieldValue != null)
            {
                string selectedValueString = FieldValue.ToString();
                if (selectedValueString != null)
                {
                    DropDownList1.SelectedValue = selectedValueString;
                }
            }
        }

    }
}