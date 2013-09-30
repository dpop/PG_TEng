using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pass4SureTestingEngine.Utils.Cursors
{
    class SelectCursor : ICursor
    {
        private PictureBox _canvas;
        private Rectangle _selectedRectangle;

        public SelectCursor(PictureBox canvas)
        {
            _canvas = canvas;
        }

        public Rectangle Drag(MouseEventArgs args)
        {
           return  new Rectangle();
        }

        public Rectangle EndDrag(EventHandler locationChangedDelegate = null)
        {
            return new Rectangle();
        }

        public Rectangle GetSelectedRectangle()
        {
            return _selectedRectangle;
        }

        public Color GetColor()
        {
            return Color.Transparent;
        }

        public Rectangle Click(MouseEventArgs args)
        {
            return _selectedRectangle;
        }

    }
}
