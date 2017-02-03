using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.DynamicData;

namespace System.Web.DynamicData
{
    public static class MetaColumnExtensions
    {
        private const String REQUIRED_ERROR_MESSAGE = "El campo {0} es obligatorio.";

        public static String ErrorMessage(this MetaColumn Column)
        {
            var requiredAttibute = Column.Attributes.OfType<RequiredAttribute>().SingleOrDefault();

            if (requiredAttibute == null)
                return String.Empty;

            if (!String.IsNullOrEmpty(requiredAttibute.ErrorMessage))
                return requiredAttibute.ErrorMessage;

            requiredAttibute.ErrorMessage = String.Format(REQUIRED_ERROR_MESSAGE, Column.DisplayName.ToLower());

            return HttpUtility.HtmlEncode(String.Format(REQUIRED_ERROR_MESSAGE, Column.DisplayName.ToLower()));            
        }
    }
}
