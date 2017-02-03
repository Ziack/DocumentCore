using System;
using System.Collections.Specialized;
using System.Dynamic;
using System.Linq.Expressions;

namespace DocumentManager.Core.Helpers.DictionaryObject
{
    public class DictionaryObject : DynamicObject
    {
        public IOrderedDictionary Dictionary { get; private set; }
        public String InternalName { get; private set; }
        public String Handler { get; private set; }

        public DictionaryObject() { }

        public DictionaryObject(IOrderedDictionary dictionary)
        {
            this.Dictionary = dictionary;
            InternalName = "id" + Guid.NewGuid().ToString();
        }

        public DictionaryObject(IOrderedDictionary dictionary, String internalName)
            : this(dictionary)
        {
            this.InternalName = internalName;
        }

        public DictionaryObject(IOrderedDictionary dictionary, String internalName, String handler)
            : this(dictionary, internalName)
        {
            this.Handler = handler;
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            Dictionary[binder.Name] = value;
            return true;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (Dictionary.Contains(binder.Name))
            {
                result = Dictionary[binder.Name];
                return true;
            }

            result = null;
            return false;
        }

        public override bool TryBinaryOperation(BinaryOperationBinder binder, object arg, out object result)
        {
            if (binder.Operation == ExpressionType.GreaterThan)
            {
                if (arg is FormatType)
                {
                    var formatType = (FormatType)arg;

                    switch(formatType)
                    {
                        case FormatType.Xml:
                            result = this.ToXElement();
                            return true;
                        case FormatType.Json:
                            result = this.ToJSON();
                            return true;

                    }
                    
                }
            }

            return base.TryBinaryOperation(binder, arg, out result);
        }
    }
}
