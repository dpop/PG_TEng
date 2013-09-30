using System.Windows.Forms;

namespace Pass4SureTestingEngine.Utils
{
    class TransparentForm : Form
    {
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //empty implementation<
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            OnPaintBackground(e);
        }
    }
}
