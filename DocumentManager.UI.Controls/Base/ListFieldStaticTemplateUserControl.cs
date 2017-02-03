using System;
using System.Linq;
using System.Web.UI.WebControls;
using DocumentManager.Core.Attributes;
using DocumentManager.Core;

namespace DocumentManager.UI.Controls.FieldTemplates.Mobile.Helpers.TemplatesUserControl
{
    /// <summary>
    /// Clase que crea dinamicamente una Lista de radioButtons o DropDownList
    /// </summary>
    public abstract class ListFieldStaticTemplateUserControl : FieldUserControl
    {
        protected String DataSource;
        protected RepeatDirection repeatDirection;

        public virtual void Page_Load(object sender, EventArgs e)
        {
            var selecListAttribute = this.Column.Attributes.OfType<SelectListStaticAttribute>().SingleOrDefault();

            if (selecListAttribute == null)
            {
                throw new ArgumentNullException("Attribute SelectListAttribute is missing");
            }

            DataSource = selecListAttribute.DataSource;
            repeatDirection = selecListAttribute.RepeatDirection;

        }
    }
}