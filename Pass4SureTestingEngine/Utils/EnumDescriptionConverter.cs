using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace Pass4SureTestingEngine.Utils
{
    class EnumDescriptionConverter : EnumConverter
    {
        private readonly Type _enumType;

        /// <summary />Initializing instance
        /// <param type="">
        ///     <name></name>
        /// </param>
        /// <param name="type">type</param>
        /// type Enum
        /// this is only one function, that you must
        /// change. All another functions for enums
        /// you can use by Ctrl+C/Ctrl+V
        public EnumDescriptionConverter(Type type)
            : base(type)
        {
            _enumType = type;
        }

        public override bool CanConvertTo(ITypeDescriptorContext context,
            Type destType)
        {
            return destType == typeof(string);
        }

        public override object ConvertTo(ITypeDescriptorContext context,
            CultureInfo culture,
            object value, Type destType)
        {
            if (value != null)
            {
                FieldInfo fi = _enumType.GetField(Enum.GetName(_enumType, value));
                var dna = (DescriptionAttribute)Attribute.GetCustomAttribute(fi, typeof(DescriptionAttribute));

                if (dna != null)
                    return dna.Description;
            }

            return value.ToString();
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context,
            Type srcType)
        {
            return srcType == typeof(string);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            foreach (FieldInfo fi in _enumType.GetFields())
            {
                var dna = (DescriptionAttribute)Attribute.GetCustomAttribute(fi, typeof(DescriptionAttribute));

                if ((dna != null) && ((string)value == dna.Description))
                    return Enum.Parse(_enumType, fi.Name);
            }
            return Enum.Parse(_enumType, (string)value);
        }
    }
}
