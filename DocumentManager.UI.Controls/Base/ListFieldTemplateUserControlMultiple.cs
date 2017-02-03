using System;
using System.Linq;
using Insight.Database;
using System.Data;
using System.Web.UI.WebControls;
using DocumentManager.Core.Attributes;
using DocumentManager.UI.Controls.Helpers;
using DocumentManager.Core;

namespace DocumentManager.UI.Controls.FieldTemplates.Mobile.Helpers.TemplatesUserControl
{
    /// <summary>
    /// Clase que crea dinamicamente una Lista de radioButtons o DropDownList
    /// </summary>
    public abstract class ListFieldTemplateUserControlMultiple : FieldUserControl
    {
        /// <summary>
        /// Propiedades del detalle
        /// </summary>
        protected DataTable DataSource;
        protected String DataTextField;
        protected String DataValueField;
        protected RepeatDirection repeatDirection;

        /// <summary>
        /// Propiedades del Maestro
        /// </summary>
        protected DataTable DataSourceMaster;
        protected String DataTextFieldMaster;
        protected String DataValueFieldMaster;

        public virtual void Page_Load(object sender, EventArgs e)
        {
            var selecListAttribute = this.Column.Attributes.OfType<SelectListAttributeMultiple>().SingleOrDefault();

            if (selecListAttribute == null)
            {
                throw new ArgumentNullException("Attribute SelectListAttribute is missing");
            }

            //Ejecuta el procedimiento del detalle
            string origenDatosDetail = selecListAttribute.StoredProcedureName;
            Data.Current.Query(sql: origenDatosDetail, parameters: null, commandType: System.Data.CommandType.StoredProcedure, read: delegate(IDataReader reader)
            {
                DataSource = DynamicToStatic.ToStatic(reader.AsEnumerable<dynamic>().ToList<dynamic>());
            });
            DataTextField = selecListAttribute.DataTextField;
            DataValueField = selecListAttribute.DataValueField;
            repeatDirection = selecListAttribute.RepeatDirection;

            //Ejecuta el procedimiento de la master
            string origenDatosMaster = selecListAttribute.StoredProcedureNameMaster;
            Data.Current.Query(sql: origenDatosMaster, parameters: null, commandType: System.Data.CommandType.StoredProcedure, read: delegate(IDataReader reader)
            {
                DataSourceMaster = DynamicToStatic.ToStatic(reader.AsEnumerable<dynamic>().ToList<dynamic>());
            });
            DataTextFieldMaster = selecListAttribute.DataTextFieldMaster;
            DataValueFieldMaster = selecListAttribute.DataValueFieldMaster;
        }
    }
}