using System;
using System.ComponentModel;

namespace Pass4SureTestingEngine.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDescription<TEnum>(this Enum enumValue) where TEnum : struct 
        {
            var type = typeof(TEnum);
            var name = Enum.GetName(type, enumValue);
            var field = type.GetField(name);
            var customAttribute = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return customAttribute.Length > 0 ? ((DescriptionAttribute)customAttribute[0]).Description : string.Empty;
        }
    }
}
