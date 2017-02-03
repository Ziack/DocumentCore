using DocumentManager.UI.Controls.FieldTemplates.Mobile.Helpers.TemplatesUserControl;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DocumentManager.Core.Attributes;
using DocumentManager.UI.Helpers;
using System.ComponentModel.Composition;
using DocumentManager.Core;
using System.ComponentModel.DataAnnotations;
using System.Web.DynamicData;
using System.Xml;
using System.Data;

namespace DocumentManager.UI.Controls.FieldTemplates.Mobile.DynamicData.FieldTemplates
{
    [Export(typeof(FieldUserControl))]
    [ExportMetadata("type", "RadioButtonList")]
    [ExportMetadata("title", "RadioButtonList")]
    [ExportMetadata("description", "Propiedad RadioButtonList")]
    public partial class RadioButtonList_Edit : ListFieldStaticTemplateUserControl
    {
        public String SelectedValue { get { return (String)ViewState["SelectedValue"]; } set { ViewState["SelectedValue"] = value; } }

        public override void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            if (IsPostBack)
            {
                xmlDataSource.Data = Column.Attributes.OfType<SelectListStaticAttribute>().SingleOrDefault().DataSource;
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(new XmlNodeReader(xmlDataSource.GetXmlDocument()));
                DataTable TableSource = dataSet.Tables[0];
                RadioButtonList1.DataSource = TableSource;
                RadioButtonList1.SelectedValue = Request.Form[RadioButtonList1.UniqueID];
                RadioButtonList1.DataBind();
                
            }


            if (!IsPostBack)
            {
                RadioButtonList1.ClearSelection();
            }

            SetUpValidator(RequiredFieldValidator1);
            SetUpValidator(DynamicValidator1);

            if (Column.IsRequired) RequiredFieldValidator1.ErrorMessage = Column.ErrorMessage();
        }

        protected override void ExtractValues(IOrderedDictionary dictionary)
        {
            string value = RadioButtonList1.SelectedValue;
            string text = string.Empty;
            if (value == String.Empty)
            {
                value = null;
            }
            else
            {
                text = RadioButtonList1.SelectedItem.Text;
            }


            dictionary[Column.Name] = new SelectedItem
            {
                Value = ConvertEditedValue(value),
                Text = text
            };
        }

        public override Control DataControl
        {
            get
            {
                return RadioButtonList1;
            }
        }

        protected override void OnDataBinding(EventArgs e)
        {
            base.OnDataBinding(e);

            if (Mode == DataBoundControlMode.Edit && FieldValue != null)
            {
                this.SelectedValue = FieldValue.ToString();

                String value = (FieldValue as dynamic).Value.InternalValue;
                RadioButtonList1.SelectedValue = RadioButtonList1.Items.FindByValue(value).Value;
            }
        }

        protected void RadioButtonList1_DataBound(object sender, EventArgs e)
        {

        }

    }
}