using System;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;
using DocumentManager.Core;

namespace DocumentManager.UI.Controls.FieldTemplates {
    public partial class EnumerationField : FieldUserControl
    {
        public override Control DataControl {
            get {
                return Literal1;
            }
        }
    
        public string EnumFieldValueString {
            get {
                if (FieldValue == null) {
                    return FieldValueString;
                }
    
                Type enumType = Column.GetEnumType();
                if (enumType != null) {
                    object enumValue = System.Enum.ToObject(enumType, FieldValue);
                    return FormatFieldValue(enumValue);
                }
    
                return FieldValueString;
            }
        }
    
    }
}
