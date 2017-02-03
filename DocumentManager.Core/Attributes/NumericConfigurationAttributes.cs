using DocumentManager.Core.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.Core.Attributes
{
    public class NumericConfigurationAttributes: Attribute
    {
        public Boolean? RoundRequired { get; set; }

        public Int32? MaxValue { get; set; }

        public Int32? MinValue { get; set; }

        public String NumericType { get; set; }

        public Double? DefaultValue { get; set; }

        public Int32? DecimalDigits { get; set; }


        public NumericConfigurationAttributes(Boolean? roundrequired, Int32? maxValue = null, Int32? minValue = null, String numericType = null, Double? defaultValue = null, Int32? decimalDigits = null)
        {
            this.RoundRequired = roundrequired;
            this.MaxValue = maxValue;
            this.MinValue = minValue;
            this.NumericType = numericType;
            this.DefaultValue = defaultValue;
            this.DecimalDigits = decimalDigits;
        }

        public static void Apply(Configuration configuration, ref List<Attribute> attributes)
        {
            attributes.Add(new NumericConfigurationAttributes(roundrequired: configuration.RoundRequired, minValue: configuration.MinValue, maxValue: configuration.MaxValue, numericType: configuration.NumericType, defaultValue: configuration.DefaultValue, decimalDigits: configuration.DecimalDigits));                
            
        }
    }
}
