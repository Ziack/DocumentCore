using DocumentManager.Core.Attributes;
using DocumentManager.Core.Extensions;
using DocumentManager.Core.Helpers.Utilities;
using DocumentManager.Core.Schema;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web.DynamicData.ModelProviders;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DocumentManager.Core.Helpers.DynamicData
{
    public class DynamicTableProvider : TableProvider
    {
        private readonly ReadOnlyCollection<ColumnProvider> columns;

        public DynamicTableProvider(DynamicModelProvider dataModelProvider)
            : base(dataModelProvider)
        {
            this.EntityType = typeof(String);
            var _columns = new List<ColumnProvider>();
            var contentType = XmlSerializerHelpers.Deserialize<ContentType>(dataModelProvider.Form);

            foreach (var field in contentType.Fields)
            {
                var attribute = new List<Attribute>();

                attribute.Add(new UIHintAttribute(field.Type));
                attribute.Add(new DescriptionAttribute(field.Description));
                attribute.Add(new DisplayAttribute { Name = field.DisplayName });
                attribute.Add(new FieldInfoAttribute(dataModelProvider.AdditionalInfo));
                attribute.Add(new ContentTypeAttribute(contentType));                
                
                if(field.Configuration.MaxLength.HasValue)
                    attribute.Add(new MaxLengthAttribute(field.Configuration.MaxLength.Value));

                if (field.Configuration.Required)
                {
                    var RequiredAttribute = new RequiredAttribute();
                    if (!String.IsNullOrEmpty(field.Configuration.ErrorMessage))
                    {
                        RequiredAttribute.ErrorMessage = field.Configuration.ErrorMessage;
                    }
                    attribute.Add(RequiredAttribute);
                }

                F4ConfigurationAttribute.Apply(field.Configuration, ref attribute);

                UploadFileAttributes.Apply(field.Configuration, ref attribute);

                SelectListAttribute.Apply(field.Configuration, ref attribute);

                SelectListAttributeMultiple.Apply(field.Configuration, ref attribute);

                SelectListStaticAttribute.Apply(field.Configuration, ref attribute);

                ConstantAttribute.Apply(field.Configuration, ref attribute);

                DataPickerRadComboBoxAttribute.Apply(field.Configuration, ref attribute);

                RelatedFieldAttribute.Apply(field.Configuration, ref attribute);

                NumericConfigurationAttributes.Apply(field.Configuration, ref attribute);

                ModuleUrlAttribute.Apply(field.Configuration, ref attribute);

                TypeAttribute.Apply(field.Configuration, ref attribute);

                DocTypeAttribute.Apply(field.Configuration, ref attribute);

                GateNeedsModalAttribute.Apply(field.Configuration, ref attribute);

                ParametersAttribute.Apply(field.Configuration, ref attribute);

                ControlDependencyAttribute.Apply(field.Configuration, ref attribute);

                IsBlockingAttribute.Apply(field.Configuration, ref attribute);

                CausesControlAttribute.Apply(field.Configuration, ref attribute);

                DocumentManager.Core.Attributes.EditableAttribute.Apply(field.Configuration, ref attribute);

                TextBoxMode textBoxMode = default(TextBoxMode);
                if (!String.IsNullOrEmpty(field.Configuration.TextMode))
                {
                    textBoxMode = EnumsExtensions.FromString<TextBoxMode>(field.Configuration.TextMode);
                    attribute.Add(new DateTimeAttributes(textMode: textBoxMode));
                }

                if (!String.IsNullOrEmpty(field.Configuration.EndpointAddress) && !String.IsNullOrEmpty(field.Configuration.MethodName) &&
                    !String.IsNullOrEmpty(field.Configuration.ContractName) && !String.IsNullOrEmpty(field.Configuration.@Namespace))
                {
                    attribute.Add(new InputWeightAttribute(endpointAddress: field.Configuration.EndpointAddress,
                                                            methodName: field.Configuration.MethodName,
                                                            contractName: field.Configuration.ContractName,
                                                            @namespace: field.Configuration.@Namespace));
                }

                var atrributeCollection = new AttributeCollection(attribute.ToArray());
                var column = new DynamicColumnProvider(this, typeof(string), field.Name, false, atrributeCollection);
                _columns.Add(column);
            }

            this.columns = _columns.ToList().AsReadOnly();
            this.Name = contentType.Name;
        }

        public override IQueryable GetQuery(object context)
        {
            return null;
        }

        public override System.Collections.ObjectModel.ReadOnlyCollection<ColumnProvider> Columns
        {
            get { return this.columns; }
        }
    }
}