using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pass4SureTestingEngine.Utils.Cursors
{
    public interface ICursor
    {
        Rectangle Click(MouseEventArgs args);
        Rectangle Drag(MouseEventArgs args);
        Rectangle EndDrag(EventHandler locationChangedDelegate = null);
        Rectangle GetSelectedRectangle();
        Color GetColor();
    }
}
