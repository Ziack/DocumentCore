using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.DynamicData.ModelProviders;
using System.Web.UI.WebControls;

namespace DocumentManager.Core.Helpers.DynamicData
{
    public class DynamicMetaTable : MetaTable
    {
        public DynamicMetaTable(MetaModel metaModel, TableProvider tableProvider)
            : base(metaModel, tableProvider)
        {

        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override MetaColumn CreateColumn(ColumnProvider columnProvider)
        {
            return new DynamicMetaColumn(this, columnProvider);
        }

        protected override AttributeCollection BuildAttributeCollection()
        {
            return DynamicMetaColumn.AddDisplayName(Name, base.BuildAttributeCollection());
        }

        public override IEnumerable<MetaColumn> GetScaffoldColumns(DataBoundControlMode mode, ContainerType containerType)
        {
            return base.GetScaffoldColumns(mode, containerType).Where(column => IsScaffoldable(column));
        }

        private bool IsScaffoldable(MetaColumn column)
        {
            var childrenColumn = column as MetaChildrenColumn;
            if (childrenColumn != null)
                return childrenColumn.ChildTable.CanRead(HttpContext.Current.User);
            return true;
        }

        private bool IncludeField(MetaColumn column, DataBoundControlMode mode)
        {
            // Exclude bool columns in Insert mode (just to test custom filtering)
            if (mode == DataBoundControlMode.Insert && column.ColumnType == typeof(bool))
                return false;
            return true;
        }

        public override string GetDisplayString(object row)
        {
            return "CUSTOM_" + base.GetDisplayString(row);
        }
    }
}