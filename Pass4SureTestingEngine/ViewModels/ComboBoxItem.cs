using System;

namespace Pass4SureTestingEngine.ViewModels
{
    [Serializable]
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
