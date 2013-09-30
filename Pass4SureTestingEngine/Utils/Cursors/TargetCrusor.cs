using System;
using System.Drawing;
using System.Windows.Forms;
using Pass4SureTestingEngine.Extensions;
using Trestan;

namespace Pass4SureTestingEngine.Utils.Cursors
{
    class TargetCrusor : ICursor
    {
        private readonly PictureBox _canvas;
        private readonly Bitmap _originalImage;
        private int _x0 = -1;
        private int _y0 = -1;
        private int _x1 = -1;
        private int _y1 = -1;
        private bool _selectingArea;
        private Bitmap _selectedImage;
        private Graphics _selectedGraphics;

        public TargetCrusor(PictureBox canvas)
        {
            _canvas = canvas;
            _originalImage = new Bitmap(canvas.Image);
        }

        public Rectangle Click(MouseEventArgs args)
        {
            _selectingArea = true;
            _x0 = args.X;
            _y0 = args.Y;

            // Make the selected image.
            _selectedImage = new Bitmap(_originalImage);
            _selectedGraphics = Graphics.FromImage(_selectedImage);
            _canvas.Image = _selectedImage;
            return new Rectangle();
        }

        public Rectangle Drag(MouseEventArgs args)
        {
            if (!_selectingArea) return new Rectangle();

            // Generate the new image with the selection rectangle.
            _x1 = args.X;
            _y1 = args.Y;

            // Copy the original image.
            _selectedGraphics.DrawImage(_originalImage, 0, 0);

            // Draw the selection rectangle.
            using (var selectPen = new Pen(Color.Red, 3))
            {
                selectPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                Rectangle rect = MakeRectangle(_x0, _y0, _x1, _y1);
                _selectedGraphics.DrawRectangle(selectPen, rect);
            }

            _canvas.Refresh();
            return new Rectangle();
        }

        public Rectangle EndDrag(EventHandler locationChangedDelegate = null)
        {
            // Do nothing if we're not selecting an area.
            if (!_selectingArea) return new Rectangle();
            _selectingArea = false;

            // Stop selecting.
            _selectedImage = null;
            _selectedGraphics = null;
            _canvas.Image = _originalImage;
            _canvas.Refresh();

            // Convert the points into a Rectangle.
            Rectangle rect = MakeRectangle(_x0, _y0, _x1, _y1);
            if ((rect.Width > 0) && (rect.Height > 0))
            {
                CreatePictureBoxFromRectangle(rect, _canvas, locationChangedDelegate);
                return rect;
            }
            return new Rectangle();
        }

        public static void CreatePictureBoxFromRectangle(Rectangle rect, Control canvas, EventHandler locationChangedDelegate = null)
        {
            var pictureBox = new PictureBox
            {
                Location = new Point(rect.Location.X, rect.Location.Y),
                Size = new Size(rect.Size.Width, rect.Size.Height)
            };
            pictureBox.Paint += pictureBox_Paint;
            pictureBox.Resize += delegate
            {
                pictureBox.Invalidate();
            };
            pictureBox.Click += delegate
            {
                if (pictureBox.Controls.Count > 0)
                {
                    pictureBox.Controls.Clear();
                }
                else
                {
                    // ReSharper disable ObjectCreationAsStatement
                    new TcResize(pictureBox);
                    // ReSharper restore ObjectCreationAsStatement
                }
            };
            pictureBox.MakeDraggable(true);

            if (locationChangedDelegate != null)
            {
                pictureBox.LocationChanged += locationChangedDelegate;
            }
            pictureBox.BackColor = Color.Transparent;

            canvas.Controls.Add(pictureBox);
        }

        public Rectangle GetSelectedRectangle()
        {
            return new Rectangle();
        }

        public Color GetColor()
        {
            return Color.Red;
        }

        private Rectangle MakeRectangle(int x0, int y0, int x1, int y1)
        {
            return new Rectangle(
                Math.Min(x0, x1),
                Math.Min(y0, y1),
                Math.Abs(x0 - x1),
                Math.Abs(y0 - y1));
        }

        private static void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            var pictureBox = (PictureBox)sender;
            var ee = new Rectangle(0, 0, pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);
            using (var pen = new Pen(Color.Red, 3))
            {
                e.Graphics.DrawRectangle(pen, ee);
            }
        }

    }
}
