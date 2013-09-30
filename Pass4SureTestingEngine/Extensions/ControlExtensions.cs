using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace Pass4SureTestingEngine.Extensions
{
    public static class ControlExtensions
    {
        private static readonly Dictionary<Control, bool> Draggables = new Dictionary<Control, bool>();
        private static System.Drawing.Size _mouseOffset;

        /// <summary>
        /// Makes a control draggable, changing the cursor to hand while it's being dragged
        /// 
        ///  Warning: This extension uses the MouseDown, MouseUp, MouseMove events
        /// </summary>
        public static void MakeDraggable(this Control control, bool makeDraggable)
        {
            if (makeDraggable && !Draggables.ContainsKey(control))
            {

                Draggables.Add(control, false);

                control.MouseDown += control_MouseDown;
                control.MouseUp += control_MouseUp;
                control.MouseMove += control_MouseMove;
            }
            else
            {
                if (Draggables.ContainsKey(control) && !makeDraggable)
                {
                    control.MouseDown -= control_MouseDown;
                    control.MouseUp -= control_MouseUp;
                    control.MouseMove -= control_MouseMove;
                    Draggables.Remove(control);
                }
            }
        }

        static void control_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseOffset = new System.Drawing.Size(e.Location);
            ((Control) sender).Cursor = Cursors.Hand;
            Draggables[(Control)sender] = true;
        }

        static void control_MouseUp(object sender, MouseEventArgs e)
        {
            Draggables[(Control)sender] = false;
            ((Control)sender).Cursor = Cursors.Default;
        }

        static void control_MouseMove(object sender, MouseEventArgs e)
        {
            if (Draggables[(Control)sender])
            {
                System.Drawing.Point newLocationOffset = e.Location - _mouseOffset;
                ((Control)sender).Left += newLocationOffset.X;
                ((Control)sender).Top += newLocationOffset.Y;
            }
        }


        /// <summary>
        /// Clone a control,ignoring the control's properties ignoring reserved to the frameworks infrastructure
        /// </summary>
        public static T Clone<T>(this T controlToClone) where T : Control
        {
            var controlProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var instance = Activator.CreateInstance<T>();

            foreach (var propInfo in controlProperties)
            {
                if (propInfo.CanWrite)
                {
                    if (propInfo.Name != "WindowTarget")
                        propInfo.SetValue(instance, propInfo.GetValue(controlToClone, null), null);
                }
            }

            return instance;
        }


        /// <summary>
        /// Makes a richtextbox resizable by using the ContentResize event
        /// </summary>
        public static void MakeResizeable(this RichTextBox box)
        {
            box.ContentsResized += (sender, e) =>
            {
                var richTextBox = (RichTextBox)sender;
                var tempFont = richTextBox.Font;
                var margin = richTextBox.Bounds.Height - richTextBox.ClientSize.Height;
                var tempFontHeight = TextRenderer.MeasureText(" ", tempFont).Height + margin + 2;

                richTextBox.Width = e.NewRectangle.Width;
                var newHeight = richTextBox.Margin.Vertical + e.NewRectangle.Height;
                richTextBox.Height = e.NewRectangle.Height > tempFontHeight ? newHeight : tempFontHeight;
                richTextBox.Width += richTextBox.Margin.Horizontal + SystemInformation.HorizontalResizeBorderThickness;

            };
            box.ScrollBars = RichTextBoxScrollBars.None;
        }
    }
}
