using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.ComponentModel;
using System.Dynamic;
using System.ComponentModel.DataAnnotations;

namespace DocumentManager.Core.Helpers
{
    
    public class DynamicTypeDescriptorWrapper : ICustomTypeDescriptor {
        private IDynamicMetaObjectProvider _dynamic;

        public DynamicTypeDescriptorWrapper(IDynamicMetaObjectProvider dynamicObject) {
            _dynamic = dynamicObject;
        }

        #region ICustomTypeDescriptor Members
        
        public AttributeCollection GetAttributes() {
            return new AttributeCollection();
        }

        public string GetClassName() {
            return "dynamic";
        }

        public string GetComponentName() {
            return "Dynamic";
        }

        public TypeConverter GetConverter() {
            return null;
        }

        public EventDescriptor GetDefaultEvent() {
            return null;
        }

        public PropertyDescriptor GetDefaultProperty() {
            return null;
        }

        public object GetEditor(Type editorBaseType) {
            return null;
        }

        public EventDescriptorCollection GetEvents(Attribute[] attributes) {
            return new EventDescriptorCollection(new EventDescriptor[] {});
        }

        public EventDescriptorCollection GetEvents() {
            return new EventDescriptorCollection(new EventDescriptor[] {});
        }

        public PropertyDescriptorCollection GetProperties(Attribute[] attributes) {
            return GetProperties();
        }

        public PropertyDescriptorCollection GetProperties() {
            var meta = _dynamic.GetMetaObject(Expression.Constant(_dynamic));
            var memberNames = meta.GetDynamicMemberNames();
            return new PropertyDescriptorCollection(
                (from memberName in memberNames
                 select new DynamicPropertyDescriptor(_dynamic, memberName)).ToArray());
        }

        public object GetPropertyOwner(PropertyDescriptor pd) {
            return _dynamic;
        }

        #endregion
    }
}
