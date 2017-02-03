using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace DocumentManager.Core.Attributes
{
    public class DateTimeAttributes : Attribute
    {
        public TextBoxMode TextMode { get; private set; }

        public DateTimeAttributes(TextBoxMode textMode)
        {
            this.TextMode = textMode;
        }
    }
}