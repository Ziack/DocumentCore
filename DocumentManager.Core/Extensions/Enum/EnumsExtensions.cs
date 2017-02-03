using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace DocumentManager.Core.Extensions
{
    public static class EnumsExtensions
    {
        public static string GetEnumDescription(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }

        public static IEnumerable<dynamic> ToDataSource<TEnum>() where TEnum : struct, IConvertible
        {
            var values = Enum.GetValues(typeof(TEnum)).Cast<object>();
            return from value in values
                   select new
                   {
                       Value = value,
                       Description = value.GetType()
                           .GetMember(value.ToString())[0]
                           .GetCustomAttributes(true)
                           .OfType<DisplayAttribute>()
                           .First()
                           .Name
                   };
        }

        public static string Display(this Enum value)
        {
            if (value.ToString() == "0")
                return String.Empty;

            var description = value.GetType()
                           .GetMember(value.ToString())[0]
                           .GetCustomAttributes(true)
                           .OfType<DisplayAttribute>()
                           .First()
                           .Name;

            return description;
        }

        public static TEnum FromDataTypeName<TEnum>(string dataTypeName) 
            where TEnum : struct, IConvertible
        {
            if (String.IsNullOrEmpty(dataTypeName))
                throw new ArgumentNullException("dataTypeName");

            var values = from value in Enum.GetValues(typeof(TEnum)).Cast<object>()
                           select new
                           {
                               Value = value,
                               DataTypeName = value.GetType()
                                   .GetMember(value.ToString())[0]
                                   .GetCustomAttributes(true)
                                   .OfType<DataTypeAttribute>()
                                   .First()
                                   .CustomDataType
                           };

            var result = values.SingleOrDefault(t => t.DataTypeName == dataTypeName);

            return (TEnum)result.Value;
        }

        public static TEnum FromInt<TEnum>(int value) where TEnum : struct, IConvertible
        {
            return (TEnum)Enum.Parse(typeof(TEnum), value.ToString());
        }

        public static TEnum FromString<TEnum>(string value)
        {
            return (TEnum)Enum.Parse(typeof(TEnum), value);
        }
    }
}