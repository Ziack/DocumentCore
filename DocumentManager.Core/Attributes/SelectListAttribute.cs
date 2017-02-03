using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using DocumentManager.Core.Extensions;
using DocumentManager.Core.Schema;

namespace DocumentManager.Core.Attributes
{
    public class SelectListAttribute : Attribute
    {
        public string StoredProcedureName { get; private set; }
        public string DataTextField { get; private set; }
        public string DataValueField { get; private set; }
        public RepeatDirection RepeatDirection { get; private set; }
        public XElement ConfigurationParameters { get; private set; }

        public SelectListAttribute(string storedProcedureName, string dataTextField, string dataValueField, RepeatDirection repeatDirection, XElement configurationParameters)
        {
            this.StoredProcedureName = storedProcedureName;
            this.DataTextField = dataTextField;
            this.DataValueField = dataValueField;
            this.RepeatDirection = repeatDirection;
            this.ConfigurationParameters = configurationParameters;
        }

        public static void Apply(Configuration configuration, ref List<Attribute> attributes)
        {
            if (!String.IsNullOrEmpty(configuration.StoredProcedure) 
                && !String.IsNullOrEmpty(configuration.DataTextField) 
                && !String.IsNullOrEmpty(configuration.DataValueField))
            {
                var repeatDirection = RepeatDirection.Vertical;

                if (!String.IsNullOrEmpty(configuration.RepeatDirection))
                {
                    repeatDirection = EnumsExtensions.FromString<RepeatDirection>(configuration.RepeatDirection);
                }

                attributes.Add(new SelectListAttribute(storedProcedureName: configuration.StoredProcedure,
                                                  dataTextField: configuration.DataTextField,
                                                  dataValueField: configuration.DataValueField,
                                                  repeatDirection: repeatDirection,
                                                  configurationParameters: configuration.ConfigurationParameters));
            }
        }

    }
}