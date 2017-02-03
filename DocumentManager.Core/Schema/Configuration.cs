using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
 
namespace DocumentManager.Core.Schema
{
    [Serializable]
    [XmlRootAttribute("Configuration")]
    [XmlType("Configuration")] 
    public class Configuration
    {
        private const String UNIQUE_FIELD_PARAMETER_NAME = "IsUnique";

        private const String PRIMARY_FIELD_PARAMETER_NAME = "IsPrimary";

        #region Commons

        [XmlElement(ElementName = "Required")]
        public bool Required { get; set; }

        [XmlElement(ElementName = "MethodName")]
        public String MethodName { get; set; }

        [XmlElement(ElementName = "Namespace")]
        public String @Namespace { get; set; }

        [XmlElement(ElementName = "ContractName")]
        public String ContractName { get; set; }

        [XmlElement(ElementName = "ErrorMessage")]
        public String ErrorMessage { get; set; }

        [XmlElement(ElementName = "VisibleEdit", IsNullable = true)]
        public Visibility? VisibleEdit { get; set; }

        [XmlElement(ElementName = "VisibleNew", IsNullable = true)]
        public Visibility? VisibleNew { get; set; }

        [XmlElement(ElementName = "VisibleBrowse", IsNullable = true)]
        public Visibility? VisibleBrowse { get; set; }  
      
        [XmlElement(ElementName = "HorizontalAlign", IsNullable = true)]
        public HorizontalAlign? HorizontalAlign { get; set; }          

        [XmlElement(ElementName = "BindType")]
        public String BindType { get; set; }

        [XmlElement(ElementName = "Editable", IsNullable = true)]
        public Boolean? Editable { get; set; }

        [XmlElement(ElementName = "IsBlocking", IsNullable = true)]
        public Boolean? IsBlocking { get; set; }

        [XmlElement(ElementName = "DocType", IsNullable = true)]
        public String DocType { get; set; }

        [XmlElement(ElementName = "Control", IsNullable = true)]
        public String Control { get; set; }

        [XmlIgnore]
        public Boolean IsUnique
        {
            get
            {
                var uniqueParameter = this.Parameters.Find(t => t.Key.Equals(Configuration.UNIQUE_FIELD_PARAMETER_NAME, StringComparison.InvariantCultureIgnoreCase));

                if (uniqueParameter == null)
                    return false;

                return Convert.ToBoolean(uniqueParameter.Value);
            }

            set
            {
                var existing = this.Parameters.Find(t => t.Key.Equals(Configuration.UNIQUE_FIELD_PARAMETER_NAME, StringComparison.InvariantCultureIgnoreCase));
                this.Parameters.Remove(existing);

                this.Parameters.Add(new Parameter
                {
                    Key = Configuration.UNIQUE_FIELD_PARAMETER_NAME,
                    Value = Convert.ToString(value),
                    Type = typeof(Boolean).FullName
                });
            }
        }

        [XmlIgnore]
        public Boolean IsPrimary
        {
            get
            {
                var primaryParameter = this.Parameters.Find(t => t.Key.Equals(Configuration.PRIMARY_FIELD_PARAMETER_NAME, StringComparison.InvariantCultureIgnoreCase));

                if (primaryParameter == null)
                    return false;

                return Convert.ToBoolean(primaryParameter.Value);
            }

            set
            {
                var existing = this.Parameters.Find(t => t.Key.Equals(Configuration.PRIMARY_FIELD_PARAMETER_NAME, StringComparison.InvariantCultureIgnoreCase));
                this.Parameters.Remove(existing);

                this.Parameters.Add(new Parameter
                {
                    Key = Configuration.PRIMARY_FIELD_PARAMETER_NAME,
                    Value = Convert.ToString(value),
                    Type = typeof(Boolean).FullName
                });
            }
        }

        [XmlIgnore]
        public bool VisibleEditSpecified
        {
            get { return this.VisibleEdit.HasValue; }
        }

        [XmlIgnore]
        public bool VisibleNewSpecified
        {
            get { return this.VisibleNew.HasValue; }
        }

        [XmlIgnore]
        public bool VisibleBrowseSpecified
        {
            get { return this.VisibleBrowse.HasValue; }
        }

        [XmlIgnore]
        public bool HorizontalAlignSpecified
        {
            get { return this.HorizontalAlign.HasValue; }
        }

        [XmlElement(ElementName = "DataFormatString")]
        public String DataFormatString { get; set; }        

        [XmlElement(ElementName = "RelatedField")]
        public String RelatedField { get; set; }

        [XmlElement(ElementName = "Operator")]
        public ValidationCompareOperator? Operator { get; set; }

        [XmlIgnore]
        public bool OperatorSpecified
        {
            get { return this.Operator.HasValue; }
        }

        [XmlElement(ElementName = "MaxLength")]
        public Int16? MaxLength { get; set; }

        [XmlIgnore]
        public bool MaxLenghtSpecified
        {
            get { return this.MaxLength.HasValue; }
        }

        [XmlElement(ElementName = "NeedsModal")]
        public bool NeedsModal { get; set; }


        #endregion

        #region F4XmlConfiguration

        [XmlElement(ElementName = "F4XmlConfiguration")]
        public String F4XmlConfiguration { get; set; }

        [XmlElement(ElementName = "F4Configuration")]
        public XElement F4Configuration { get; set; }

        [XmlElement(ElementName = "AutoPostBack", IsNullable = true)]
        public Boolean? AutoPostBack { get; set; }

        [XmlIgnore]
        public bool AutoPostBackSpecified
        {
            get { return this.AutoPostBack.HasValue; }
        }

        #endregion

        #region DropDownList
        [XmlElement(ElementName = "Value")]
        public String Value { get; set; }

        [XmlElement(ElementName = "StoredProcedure")]
        public String StoredProcedure { get; set; }

        [XmlElement(ElementName = "DataTextField")]
        public String DataTextField { get; set; }

        [XmlElement(ElementName = "DataValueField")]
        public String DataValueField { get; set; }
        #endregion

        #region DropDownListMaster
        [XmlElement(ElementName = "StoredProcedureMaster")]
        public string StoredProcedureMaster { get; set; }

        [XmlElement(ElementName = "DataTextFieldMaster")]
        public String DataTextFieldMaster { get; set; }

        [XmlElement(ElementName = "DataValueFieldMaster")]
        public String DataValueFieldMaster { get; set; }

        [XmlElement(ElementName = "SelectedValue")]
        public string SelectedValue { get; set; }

        [XmlElement(ElementName = "ShowTextDetail")]
        public string ShowTextDetail { get; set; }
        #endregion

        #region UploadFile

        [XmlElement(ElementName = "MultipleFile")]
        public Boolean? MultipleFile { get; set; }

        [XmlIgnore]
        public bool MultipleFileSpecified
        {
            get { return this.MultipleFile.HasValue; }
        }

        [XmlElement(ElementName = "MaxFiles")]
        public String MaxFiles { get; set; }

        [XmlElement(ElementName = "MaxFilesize")]
        public String MaxFilesize { get; set; }

        #endregion

        #region NumericTextBox

        [XmlElement(ElementName = "RoundRequired")]
        public Boolean? RoundRequired { get; set; }

        [XmlIgnore]
        public bool RoundRequiredSpecified
        {
            get { return this.RoundRequired.HasValue; }
        }

        [XmlElement(ElementName = "MaxValue")]
        public Int32? MaxValue { get; set; }

        [XmlIgnore]
        public bool MaxValueSpecified
        {
            get { return this.MaxValue.HasValue; }
        }

        [XmlElement(ElementName = "NumericType")]
        public String NumericType { get; set; }

        [XmlElement(ElementName = "DefaultValue")]
        public Double? DefaultValue { get; set; }

        [XmlIgnore]
        public bool DefaultValueSpecified
        {
            get { return this.DefaultValue.HasValue; }
        }

        [XmlElement(ElementName = "DecimalDigits")]
        public Int32? DecimalDigits { get; set; }

        [XmlIgnore]
        public bool DecimalDigitsSpecified
        {
            get { return this.DecimalDigits.HasValue; }
        }                
        
        [XmlElement(ElementName = "MinValue")]
        public Int32? MinValue { get; set; }

        [XmlIgnore]
        public bool MinValueSpecified
        {
            get { return this.MinValue.HasValue; }
        }

        #endregion

        [XmlElement(ElementName = "DataSource")]
        public XElement DataSource { get; set; }

        [XmlElement(ElementName = "RepeatDirection")]
        public String RepeatDirection { get; set; }

        [XmlElement(ElementName = "TextMode")]
        public String TextMode { get; set; }

        [XmlElement(ElementName = "EndpointAddress")]
        public String EndpointAddress { get; set; }

        [XmlElement(ElementName = "ConfigurationParameters")]
        public XElement ConfigurationParameters { get; set; }

        [XmlElement(ElementName = "Programado")]
        public string Programado;

        [XmlElement(ElementName = "ControlStartDate")]
        public string ControlStartDate { get; set; }

        [XmlArray("Parameters")]
        [XmlArrayItem("Parameter")]
        public ParametersCollection Parameters { get; set; }

        #region ModuleUrl

        [XmlElement(ElementName = "ModuleName")]
        public string ModuleName { get; set; }

        [XmlElement(ElementName = "ControlKey")]
        public string ControlKey { get; set; }

        [XmlElement(ElementName = "Cause")]
        public String Cause { get; set; }

        #endregion

        public Configuration()
        {
            this.Parameters = new ParametersCollection();
        }
    }
}
