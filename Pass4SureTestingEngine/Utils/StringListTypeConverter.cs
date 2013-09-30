using System.ComponentModel;

namespace Pass4SureTestingEngine.Utils
{
    class StringListTypeConverter : TypeConverter
    {

        public override bool
        GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true; // display drop
        }
        public override bool
        GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return true; // drop-down vs combo
        }
        public override StandardValuesCollection
        GetStandardValues(ITypeDescriptorContext context)
        {
            // note you can also look at context etc to build list
            return new StandardValuesCollection(new[] { "(none)"});
        }

    }
}
