using System;
using System.Windows.Forms;
using System.Drawing;

namespace Trestan
{
    internal static class ControlExtension
    {
        public static int GetClientWidth(this Control theControl)
        {
            return theControl.Width - TcResize.Decoration;
        }

        public static int GetClientHeight(this Control theControl)
        {
            return theControl.Height - TcResize.Decoration;
        }

        public static Size GetClientSize(this Control theControl)
        {
            return new Size(theControl.GetClientWidth(), theControl.GetClientHeight());
        }

        public static void SetClientWidth(this Control theControl, int width)
        {
            theControl.Width = width + TcResize.Decoration;
        }

        public static void SetClientHeight(this Control theControl, int height)
        {
            theControl.Height = height + TcResize.Decoration;
        }

        public static void SetClientSize(this Control theControl, Size size)
        {
            theControl.SetClientWidth(size.Width);
            theControl.SetClientHeight(size.Height);
        }
    }

    public class TcResize
    {
        readonly Control _controltobeResized;
// ReSharper disable InconsistentNaming
        private const int decoration = 30;
// ReSharper restore InconsistentNaming

        public static int Decoration
        {
            get { return decoration; }
        }


        public TcResize(Control theControl)
        {
            _controltobeResized = theControl;
            InitializeComponent();
            _controltobeResized.Controls.Add(_topAnchor);
            _controltobeResized.Controls.Add(_bottomAnchor);
            _controltobeResized.Controls.Add(_leftAnchor);
            _controltobeResized.Controls.Add(_rightAnchor);
            _controltobeResized.Controls.Add(_topRightAnchor);
            _controltobeResized.Controls.Add(_topLeftAnchor);
            _controltobeResized.Controls.Add(_bottomLeftAnchor);
            _controltobeResized.Controls.Add(_bottomRightAnchor);
        //    theControl.Parent.Controls.Add(_label1);
        }

        private readonly PictureBox _topAnchor = new PictureBox();
        private readonly PictureBox _bottomAnchor = new PictureBox();
        private readonly PictureBox _leftAnchor = new PictureBox();
        private readonly PictureBox _rightAnchor = new PictureBox();
        private readonly PictureBox _topRightAnchor = new PictureBox();
        private readonly PictureBox _topLeftAnchor = new PictureBox();
        private readonly PictureBox _bottomLeftAnchor = new PictureBox();
        private readonly PictureBox _bottomRightAnchor = new PictureBox();
        private readonly Label _label1 = new Label();


        private void InitializeComponent()
        {
            // 
            // top
            // 
            _topAnchor.Anchor = AnchorStyles.Top;
            _topAnchor.BackColor = Color.White;
            _topAnchor.Cursor = Cursors.SizeNS;
            _topAnchor.Location = new Point(_controltobeResized.ClientSize.Width / 2, 0);
            _topAnchor.Name = "_topAnchor";
            _topAnchor.Size = new Size(5, 5);
            _topAnchor.TabIndex = 1;
            _topAnchor.TabStop = false;
            _topAnchor.MouseMove += TopAnchorMouseMove;
            _topAnchor.MouseLeave += pictureBox_MouseLeave;
            _topAnchor.MouseEnter += pictureBox_MouseEnter;
            // 
            // top right
            // 
            _topRightAnchor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _topRightAnchor.BackColor = Color.White;
            _topRightAnchor.Cursor = Cursors.SizeNESW;
            _topRightAnchor.Location = new Point(_controltobeResized.ClientSize.Width - 4, 0);
            _topRightAnchor.Name = "_topRightAnchor";
            _topRightAnchor.Size = new Size(5, 5);
            _topRightAnchor.TabIndex = 1;
            _topRightAnchor.TabStop = false;
            _topRightAnchor.MouseMove += TopRightAnchorMouseMove;
            _topRightAnchor.MouseLeave += pictureBox_MouseLeave;
            _topRightAnchor.MouseEnter += pictureBox_MouseEnter;

            // 
            // top left
            // 
            _topLeftAnchor.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            _topLeftAnchor.BackColor = Color.White;
            _topLeftAnchor.Cursor = Cursors.SizeNWSE;
            _topLeftAnchor.Location = new Point(0, 0);
            _topLeftAnchor.Name = "_topLeftAnchor";
            _topLeftAnchor.Size = new Size(5, 5);
            _topLeftAnchor.TabIndex = 1;
            _topLeftAnchor.TabStop = false;
            _topLeftAnchor.MouseMove += TopLeftAnchorMouseMove;
            _topLeftAnchor.MouseLeave += pictureBox_MouseLeave;
            _topLeftAnchor.MouseEnter += pictureBox_MouseEnter;
            
            // 
            // bottom
            // 
            _bottomAnchor.Anchor = AnchorStyles.Bottom;
            _bottomAnchor.BackColor = Color.White;
            _bottomAnchor.Cursor = Cursors.SizeNS;
            _bottomAnchor.Location = new Point(_controltobeResized.ClientSize.Width / 2, _controltobeResized.ClientSize.Height - 4);
            _bottomAnchor.Name = "_bottomAnchor";
            _bottomAnchor.Size = new Size(5, 5);
            _bottomAnchor.TabIndex = 2;
            _bottomAnchor.TabStop = false;
            _bottomAnchor.MouseMove += BottomAnchorMouseMove;
            _bottomAnchor.MouseLeave += pictureBox_MouseLeave;
            _bottomAnchor.MouseEnter += pictureBox_MouseEnter;

            // 
            // bottom left
            // 
            _bottomLeftAnchor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _bottomLeftAnchor.BackColor = Color.White;
            _bottomLeftAnchor.Cursor = Cursors.SizeNESW;
            _bottomLeftAnchor.Location = new Point(0, _controltobeResized.ClientSize.Height - 4);
            _bottomLeftAnchor.Name = "_bottomLeftAnchor";
            _bottomLeftAnchor.Size = new Size(5, 5);
            _bottomLeftAnchor.TabIndex = 2;
            _bottomLeftAnchor.TabStop = false;
            _bottomLeftAnchor.MouseMove += BottomLeftAnchorMouseMove;
            _bottomLeftAnchor.MouseLeave += pictureBox_MouseLeave;
            _bottomLeftAnchor.MouseEnter += pictureBox_MouseEnter;

            // 
            // bottom right
            // 
            _bottomRightAnchor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _bottomRightAnchor.BackColor = Color.White;
            _bottomRightAnchor.Cursor = Cursors.SizeNWSE;
            _bottomRightAnchor.Location = new Point(_controltobeResized.ClientSize.Width - 4, _controltobeResized.ClientSize.Height - 4);
            _bottomRightAnchor.Name = "_bottomRightAnchor";
            _bottomRightAnchor.Size = new Size(5, 5);
            _bottomRightAnchor.TabIndex = 2;
            _bottomRightAnchor.TabStop = false;
            _bottomRightAnchor.MouseMove += BottomRightAnchorMouseMove;
            _bottomRightAnchor.MouseLeave += pictureBox_MouseLeave;
            _bottomRightAnchor.MouseEnter += pictureBox_MouseEnter;

            // 
            // right
            // 
            _rightAnchor.Anchor = AnchorStyles.Right;
            _rightAnchor.BackColor = Color.White;
            _rightAnchor.Cursor = Cursors.SizeWE;
            _rightAnchor.Location = new Point(_controltobeResized.ClientSize.Width - 4, _controltobeResized.ClientSize.Height / 2);
            _rightAnchor.Name = "_rightAnchor";
            _rightAnchor.Size = new Size(5, 5);
            _rightAnchor.TabIndex = 3;
            _rightAnchor.TabStop = false;
            _rightAnchor.MouseMove += RightAnchorMouseMove;
            _rightAnchor.MouseLeave += pictureBox_MouseLeave;
            _rightAnchor.MouseEnter += pictureBox_MouseEnter;
            // 
            // left
            // 
            _leftAnchor.Anchor = AnchorStyles.Left;
            _leftAnchor.BackColor = Color.White;
            _leftAnchor.Cursor = Cursors.SizeWE;
            _leftAnchor.Location = new Point(0, _controltobeResized.ClientSize.Height / 2);
            _leftAnchor.Name = "_leftAnchor";
            _leftAnchor.Size = new Size(5, 5);
            _leftAnchor.TabIndex = 3;
            _leftAnchor.TabStop = false;
            _leftAnchor.MouseMove += LeftAnchorMouseMove;
            _leftAnchor.MouseLeave += pictureBox_MouseLeave;
            _leftAnchor.MouseEnter += pictureBox_MouseEnter;
            // 
            // label1
            // 
            _label1.AutoSize = true;
            _label1.Visible = false;
            _label1.BackColor = Color.Transparent;
            _label1.ForeColor = SystemColors.Desktop;
            _label1.Location = new Point(297, 293);
            _label1.Name = "_label1";
            _label1.Size = new Size(41, 12);
            _label1.TabIndex = 4;
        }

        void ShowTcTip()
        {
            InvalidateAll();
            _label1.Visible = true;
            _label1.Text = string.Format(@"Size:({0},{1})", _controltobeResized.GetClientWidth(), _controltobeResized.GetClientHeight());
            _label1.Top = _controltobeResized.Bottom + decoration;
            if (_label1.Width > _controltobeResized.Width)
            {
                _label1.Left = _controltobeResized.Left;
            }
            else
            {
                _label1.Left = _controltobeResized.Right - _label1.Width;
            }
            _label1.BringToFront();
        }

        private void TopAnchorMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var updatedYCoord = _controltobeResized.Location.Y + e.Y > 0
                                        ? _controltobeResized.Location.Y + e.Y
                                        : _controltobeResized.Location.Y;
                _controltobeResized.Height -= e.Y;
                if (_controltobeResized.Height < decoration)
                {
                    _controltobeResized.Height = decoration;
                }
                else
                {
                    _controltobeResized.Location = new Point(_controltobeResized.Location.X, updatedYCoord);
                }
                
    
                _topAnchor.Invalidate();
            }
            ShowTcTip();
        }

        private void TopRightAnchorMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var updatedYCoord = _controltobeResized.Location.Y + e.Y > 0
                                        ? _controltobeResized.Location.Y + e.Y
                                        : _controltobeResized.Location.Y;
                _controltobeResized.Height -= e.Y;
                _controltobeResized.Width += e.X;
                if (_controltobeResized.Height < decoration)
                {
                    _controltobeResized.Height = decoration;
                }
                else
                {
                    if (_controltobeResized.Width < decoration)
                    {
                        _controltobeResized.Width = decoration;
                    }
                    else
                    {
                        _controltobeResized.Location = new Point(_controltobeResized.Location.X, updatedYCoord);
                    }
                }


               
                _topAnchor.Invalidate();
            }
            ShowTcTip();
        }

        private void TopLeftAnchorMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var updatedYCoord = _controltobeResized.Location.Y + e.Y > 0
                                        ? _controltobeResized.Location.Y + e.Y
                                        : _controltobeResized.Location.Y;
                var updatedXCoord = _controltobeResized.Location.X + e.X > 0
                    ? _controltobeResized.Location.X + e.X
                    : _controltobeResized.Location.X;
                _controltobeResized.Height -= e.Y;
                _controltobeResized.Width -= e.X;
                if (_controltobeResized.Height < decoration)
                {
                    _controltobeResized.Height = decoration;
                }
                else
                {
                    if (_controltobeResized.Width < decoration)
                    {
                        _controltobeResized.Width = decoration;
                    }
                    else
                    {
                        _controltobeResized.Location = new Point(updatedXCoord, updatedYCoord);
                    }
                }



                _topAnchor.Invalidate();
            }
            ShowTcTip();
        }


        private void BottomLeftAnchorMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var updatedXCoord = _controltobeResized.Location.X + e.X > 0
                    ? _controltobeResized.Location.X + e.X
                    : _controltobeResized.Location.X;
                _controltobeResized.Height += e.Y;
                _controltobeResized.Width -= e.X;
                if (_controltobeResized.Height < decoration)
                {
                    _controltobeResized.Height = decoration;
                }
                else
                {
                    if (_controltobeResized.Width < decoration)
                    {
                        _controltobeResized.Width = decoration;
                    }
                    else
                    {
                        _controltobeResized.Location = new Point(updatedXCoord, _controltobeResized.Location.Y);
                    }
                }



                _topAnchor.Invalidate();
            }
            ShowTcTip();
        }

        private void BottomRightAnchorMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _controltobeResized.Height += e.Y;
                _controltobeResized.Width += e.X;
                if (_controltobeResized.Height < decoration)
                {
                    _controltobeResized.Height = decoration;
                }
                if (_controltobeResized.Width < decoration)
                {
                    _controltobeResized.Width = decoration;
                }

                _topAnchor.Invalidate();
            }
            ShowTcTip();
        }

        private void BottomAnchorMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _controltobeResized.Height += e.Y;
                if (_controltobeResized.Height < decoration)
                {
                    _controltobeResized.Height = decoration;
                }
            }

            ShowTcTip();
        }

        private void RightAnchorMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _controltobeResized.Width += e.X;
                if (_controltobeResized.Width < decoration)
                {
                    _controltobeResized.Width = decoration;
                }
            }
            ShowTcTip();
        }

        private void LeftAnchorMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var updatedXCoord = _controltobeResized.Location.X + e.X > 0
                        ? _controltobeResized.Location.X + e.X
                        : _controltobeResized.Location.X;
                _controltobeResized.Width -= e.X;
                if (_controltobeResized.Width < decoration)
                {
                    _controltobeResized.Width = decoration;

                }
                else
                {
                    _controltobeResized.Location = new Point(updatedXCoord, _controltobeResized.Location.Y);
                }
            }
            ShowTcTip();
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            ShowTcTip();
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            _label1.Visible = false;
        }

        private void InvalidateAll()
        {
            _bottomAnchor.Invalidate();
            _bottomLeftAnchor.Invalidate();
            _bottomRightAnchor.Invalidate();
            _leftAnchor.Invalidate();
            _rightAnchor.Invalidate();
            _topAnchor.Invalidate();
            _topLeftAnchor.Invalidate();
            _topRightAnchor.Invalidate();
        }
    }
}
