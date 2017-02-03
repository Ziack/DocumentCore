using DocumentManager.UI.Controls.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DocumentManager.UI.Controls.EntityTemplates
{
    public partial class PackingList_Insert : EntityTemplateUserControl
    {
        private MetaColumn currentColumn;

        protected override void OnLoad(EventArgs e)
        {

            foreach (MetaColumn column in Table.GetScaffoldColumns(Mode, ContainerType))
            {
                currentColumn = column;
                Control item = new NamingContainer();
                EntityTemplate1.ItemTemplate.InstantiateIn(item);
                (item.FindControl("DynamicControl") as DynamicControl).ValidationGroup = ValidationGroup;
                EntityTemplate1.Controls.Add(item);
            }
        }

        protected void Label_Init(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            if (currentColumn.DisplayName != "ContentID")
                label.Text = currentColumn.DisplayName;
        }

        protected void Label_PreRender(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            DynamicControl dynamicControl = (DynamicControl)label.FindControl("DynamicControl");
            FieldTemplateUserControl ftuc = dynamicControl.FieldTemplate as FieldTemplateUserControl;
            if (ftuc != null && ftuc.DataControl != null)
            {
                label.AssociatedControlID = ftuc.DataControl.GetUniqueIDRelativeTo(label);
            }
        }

        protected void DynamicControl_Init(object sender, EventArgs e)
        {
            DynamicControl dynamicControl = (DynamicControl)sender;
            dynamicControl.DataField = currentColumn.Name;
            dynamicControl.ValidationGroup = this.ValidationGroup;
        }

    }
}