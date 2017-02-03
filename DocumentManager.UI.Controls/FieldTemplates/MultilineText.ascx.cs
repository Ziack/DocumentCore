using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Web.DynamicData;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DocumentManager.Core;
using System.ComponentModel.Composition;

namespace DocumentManager.UI.Controls.FieldTemplates {

    [Export(typeof(FieldUserControl))]
    [ExportMetadata("type", "MultilineText")]
    [ExportMetadata("title", "MultilineText")]
    [ExportMetadata("description", "MultilineText")]
    public partial class MultilineText : FieldUserControl
    {
        private const int MAX_DISPLAYLENGTH_IN_LIST = 25;

        #region WebControls

        private Literal Literal1;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public override string FieldValueString {
            get {
                string value = base.FieldValueString;
                if (ContainerType == ContainerType.List) {
                    if(value != null && value.Length > MAX_DISPLAYLENGTH_IN_LIST) {
                       value = value.Substring(0, MAX_DISPLAYLENGTH_IN_LIST - 3) + "...";
                    }
                }
                return value;
            }
        }
    
        public override Control DataControl {
            get {
                return Literal1;
            }
        }
    
    }
}
