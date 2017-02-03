using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using DocumentManager.Core.Extensions;
using DocumentManager.Core.Schema;

namespace DocumentManager.Core.Attributes
{
    public class SelectListAttributeMultiple : Attribute
    {
        public string StoredProcedureName { get; private set; }
        public string DataTextField { get; private set; }
        public string DataValueField { get; private set; }
        public RepeatDirection RepeatDirection { get; private set; }

        public string StoredProcedureNameMaster { get; private set; }
        public string DataTextFieldMaster { get; private set; }
        public string DataValueFieldMaster { get; private set; }

        public string SelectedValue { get; private set; }
        public string ShowTextDetail { get; private set; }

        public SelectListAttributeMultiple(string storedProcedureName, string dataTextField, string dataValueField, RepeatDirection repeatDirection,
                                            string storedProcedureNameMaster, string dataTextFieldMaster, string dataValueFieldMaster,
                                            string selectedValue, string showTextDetail)
        {
            this.StoredProcedureName = storedProcedureName;
            this.DataTextField = dataTextField;
            this.DataValueField = dataValueField;
            this.RepeatDirection = repeatDirection;

            this.StoredProcedureNameMaster = storedProcedureNameMaster;
            this.DataTextFieldMaster = dataTextFieldMaster;
            this.DataValueFieldMaster = dataValueFieldMaster;
            this.SelectedValue = selectedValue;
            this.ShowTextDetail = showTextDetail;
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

                attributes.Add(new SelectListAttributeMultiple(storedProcedureName: configuration.StoredProcedure,
                                                                  dataTextField: configuration.DataTextField,
                                                                  dataValueField: configuration.DataValueField,
                                                                  repeatDirection: repeatDirection,
                                                                  storedProcedureNameMaster: configuration.StoredProcedureMaster,
                                                                  dataTextFieldMaster: configuration.DataTextFieldMaster,
                                                                  dataValueFieldMaster: configuration.DataValueFieldMaster,
                                                                  selectedValue: configuration.SelectedValue,
                                                                  showTextDetail: configuration.ShowTextDetail));
            }
        }

    }
}