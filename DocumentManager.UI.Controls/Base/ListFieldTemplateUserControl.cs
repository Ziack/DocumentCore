using System;
using System.Collections.Generic;
using System.Linq;
using Insight.Database;
using System.Data;
using System.Web.UI.WebControls;
using DocumentManager.Core.Attributes;
using System.Xml.Linq;
using System.Data.SqlClient;
using DocumentManager.UI.Controls.Helpers;
using DocumentManager.Core;
using Newtonsoft.Json;

namespace DocumentManager.UI.Controls.FieldTemplates.Mobile.Helpers.TemplatesUserControl
{
    /// <summary>
    /// Clase que crea dinamicamente una Lista de radioButtons o DropDownList
    /// </summary>
    public abstract class ListFieldTemplateUserControl : FieldUserControl
    {
        protected DataTable DataSource;
        protected String DataTextField;
        protected String DataValueField;
        protected RepeatDirection repeatDirection;

        public virtual void Page_Load(object sender, EventArgs e)
        {
            var selecListAttribute = this.Column.Attributes.OfType<SelectListAttribute>().SingleOrDefault();

            if (selecListAttribute == null)
                return;

            var origenDatos = selecListAttribute.StoredProcedureName;
            var command = Data.Current.CreateCommand(sql: origenDatos, commandType: CommandType.StoredProcedure);
            command.Connection.Open();

            //verifica si se adicionaron parametros en el xml de configuración
            if (selecListAttribute.ConfigurationParameters != null)
            {
                //Quita el namespace del xml
                foreach (XElement element in selecListAttribute.ConfigurationParameters.DescendantsAndSelf())
                {
                    element.Name = XName.Get(element.Name.LocalName, String.Empty);
                }
            }


            var reader = command.ExecuteReader();
            DataSource = DynamicToStatic.ToStatic(reader.AsEnumerable<dynamic>().ToList<dynamic>());          

            DataTextField = selecListAttribute.DataTextField;
            DataValueField = selecListAttribute.DataValueField;
            repeatDirection = selecListAttribute.RepeatDirection;            
        }

        /// <summary>
        /// COnvierte el diccionario a un objeto anonimo
        /// </summary>
        public object DictionaryToAnonymous(IDictionary<string, object> dicParametros)
        {
            //Valida si el dicionario se encuentra vacio
            if (dicParametros != null)
            {
                var eo = new System.Dynamic.ExpandoObject();
                var eoColl = (ICollection<KeyValuePair<string, object>>)eo;

                foreach (var kvp in dicParametros)
                {
                    eoColl.Add(kvp);
                }

                dynamic eoDynamic = eo;

                return eoDynamic;
            }
            else
            {
                return null;
            }
        }
    }
}