using System.Windows.Forms;

namespace Pass4SureTestingEngine.Utils
{
    public class RtfTextHelper
    {
        private static readonly RichTextBox _rtbAux = new RichTextBox();

        public static string StringToRtf(string text)
        {
            _rtbAux.Text = text;

            return _rtbAux.Rtf;
        }

    }
}
