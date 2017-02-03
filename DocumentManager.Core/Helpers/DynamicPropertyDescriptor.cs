using DocumentManager.Core.Schema;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.Core.Helpers
{
    public class DynamicPropertyDescriptor : PropertyDescriptor
    {
        private DictionaryEntry dictionaryEntry;

        private Field field;

        public DynamicPropertyDescriptor(DictionaryEntry dictionaryEntry, Field field = null)
            : base(Convert.ToString(dictionaryEntry.Key), new List<Attribute>().ToArray())
        {
            this.dictionaryEntry = dictionaryEntry;
            this.field = field;
        }

        public override bool CanResetValue(object component)
        {
            return false;
        }

        public override Type ComponentType
        {
            get
            {
                return typeof(DynamicTypeDescriptor);
            }
        }

        public override object GetValue(object component)
        {
            if (this.PropertyType == typeof(Object))
                return dictionaryEntry.Value;
            
            return Convert.ChangeType(dictionaryEntry.Value, this.PropertyType);
        }

        public override bool IsReadOnly
        {
            get
            {
                //TODO: Change this!
                return false;
            }
        }

        public override Type PropertyType
        {
            get
            {
                if(field == null)
                    return typeof(Object);

                if (!String.IsNullOrEmpty(field.Configuration.BindType))
                    return Type.GetType(field.Configuration.BindType);

                return typeof(Object);
            }
        }

        public override void ResetValue(object component)
        {
            
        }

        public override void SetValue(object component, object value)
        {
            
        }

        public override bool ShouldSerializeValue(object component)
        {
            return false;
        }
    }
}
