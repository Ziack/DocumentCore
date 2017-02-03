using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Data;
using System.ComponentModel.DataAnnotations;

    // Custom type descriptor that wraps the DataTable
    public class DataTableCustomTypeDescriptor : CustomTypeDescriptor {
        private DataTable _table;
        public DataTableCustomTypeDescriptor(DataTable table) {
            _table = table;
        }
        public override string GetClassName() {
            return _table.TableName;
        }

        public override PropertyDescriptorCollection GetProperties() {

            var props = _table.Columns.Cast<DataColumn>().Select(c => new DataColumnPropertyDescriptor(c)).ToArray();
            return new PropertyDescriptorCollection(props);
        }
    }

    public class DataColumnPropertyDescriptor : PropertyDescriptor {
        private DataColumn _column;
        public DataColumnPropertyDescriptor(DataColumn column)
            : base(column.ColumnName, ProcessColumnAttributes(column)) {
            _column = column;
        }

        private static Attribute[] ProcessColumnAttributes(DataColumn column) {
            List<Attribute> attributes = new List<Attribute>();
            if (column.MaxLength > 0) {
                if (column.DataType == typeof(string)) {
                    attributes.Add(new StringLengthAttribute(column.MaxLength));
                }
            }
            if (Array.IndexOf(column.Table.PrimaryKey, column) >= 0) {
                attributes.Add(new KeyAttribute());
            }
            attributes.Add(new DisplayAttribute() {
                Order = column.Ordinal,
                Name = column.Caption
            });

            if (column.ExtendedProperties.ContainsKey("Required")) {
                attributes.Add(new RequiredAttribute());
            }

            if (column.ExtendedProperties.ContainsKey("UIHint")) {
                string uiHint = (string)column.ExtendedProperties["UIHint"];
                attributes.Add(new UIHintAttribute(uiHint));
            }

            attributes.Add(new DefaultValueAttribute(column.DefaultValue));

            return attributes.ToArray();
        }


        public override bool CanResetValue(object component) {
            return false;
        }

        public override Type ComponentType {
            get {
                return typeof(DataTableCustomTypeDescriptor);
            }
        }

        public override object GetValue(object component) {
            return _column.Table.Rows[0][_column.ColumnName];
        }

        public override bool IsReadOnly {
            get {
                return _column.ReadOnly;
            }
        }

        public override Type PropertyType {
            get {
                if (_column.AllowDBNull && _column.DataType.IsValueType) {
                    // Make Nullable generic type
                    return typeof(Nullable<>).MakeGenericType(_column.DataType);
                }
                return _column.DataType;
            }
        }

        public override void ResetValue(object component) {

        }

        public override void SetValue(object component, object value) {

        }

        public override bool ShouldSerializeValue(object component) {
            return false;
        }
    }
