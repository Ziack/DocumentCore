using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.Core.Helpers.XmlToDynamic
{
    [Serializable]
    public class DynamicElement : DynamicObject, IConvertible
    {
        public String InternalName { get; private set; }

        private IDictionary<string, string> attributes = new Dictionary<string, string>();

        internal IDictionary<string, dynamic> SubElements = new Dictionary<string, dynamic>();


        public DynamicElement(String internalName)
        {
            this.InternalName = internalName;            
        }

        public string this[string key]
        {
            get { return SubElements.ContainsKey(key: key) ? Convert.ToString(SubElements[key]) : null; }
            set { SubElements[key] = value; }
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (SubElements.Where(t => t.Key == binder.Name).Count() == 0)
                throw new ArgumentOutOfRangeException(binder.Name, String.Format("The given property '{0}' was not present in the element {1}", binder.Name, InternalName));

            result = SubElements[binder.Name];
            return true;
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            if (SubElements.Where(t => t.Key == binder.Name).Count() == 0)
                throw new ArgumentOutOfRangeException(binder.Name, String.Format("The given property '{0}' was not present in the element {1}", binder.Name, InternalName));

            SubElements[binder.Name] = value as dynamic;
            return true;
        }

        public override bool TryUnaryOperation(System.Dynamic.UnaryOperationBinder binder, out object result)
        {
            if (binder.Operation == ExpressionType.Assign)
            {
                result = InternalValue;
                return true;
            }

            return base.TryUnaryOperation(binder, out result);
        }


        public override string ToString()
        {
            return InternalValue;
        }

        public string InternalValue { get; set; }

        public TypeCode GetTypeCode()
        {
            return TypeCode.Object;
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            return Convert.ToBoolean(InternalValue, provider);
        }

        public byte ToByte(IFormatProvider provider)
        {
            return Convert.ToByte(InternalValue, provider);
        }

        public char ToChar(IFormatProvider provider)
        {
            return Convert.ToChar(InternalValue, provider);
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            return Convert.ToDateTime(InternalValue, provider);
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal(InternalValue, provider);
        }

        public double ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble(InternalValue, provider);
        }

        public short ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16(InternalValue, provider);
        }

        public int ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32(InternalValue, provider);
        }

        public long ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64(InternalValue, provider);
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte(InternalValue, provider);
        }

        public float ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle(InternalValue, provider);
        }

        public string ToString(IFormatProvider provider)
        {
            return Convert.ToString(InternalValue, provider);
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            return Convert.ChangeType(InternalValue, conversionType, provider);
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16(InternalValue, provider);
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(InternalValue, provider);
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64(InternalValue, provider);
        }
    }
}
