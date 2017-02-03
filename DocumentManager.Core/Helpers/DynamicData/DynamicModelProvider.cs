using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web.DynamicData.ModelProviders;
using System.Xml.Linq;

namespace DocumentManager.Core.Helpers.DynamicData
{
    public class DynamicModelProvider : DataModelProvider
    {
        public readonly XDocument Form;
        public readonly XDocument AdditionalInfo;

        private readonly ReadOnlyCollection<TableProvider> tables;

        public DynamicModelProvider(XDocument form, XDocument additionalInfo = null)
        {
            this.Form = form;
            this.AdditionalInfo = additionalInfo;
            this.ContextType = typeof(XDocument);

            var _tables = new List<TableProvider>();
            _tables.Add(new DynamicTableProvider(this));

            this.tables = _tables.ToList().AsReadOnly();
        }

        public override object CreateContext()
        {
            return new object { };
        }

        public override System.Collections.ObjectModel.ReadOnlyCollection<TableProvider> Tables
        {
            get { return this.tables; }
        }
    }
}