using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.DynamicData.ModelProviders;

namespace DocumentManager.Core.Helpers.DynamicData
{
    public class DynamicColumnProvider : ColumnProvider
    {
        private AttributeCollection _Attributes;

        public DynamicColumnProvider(TableProvider table, Type columnType, string columnName, bool isPrimaryKey, AttributeCollection attributes)
            : base(table)
        {
            this._Attributes = attributes;
            this.IsPrimaryKey = isPrimaryKey;
            this.ColumnType = columnType;
            this.Name = columnName;
        }

        public override AttributeCollection Attributes
        {
            get
            {
                return _Attributes;
            }
        }
    }
}