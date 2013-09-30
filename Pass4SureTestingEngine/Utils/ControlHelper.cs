using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pass4SureTestingEngine.Utils
{
    public class ControlHelper
    {
        public static IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
    }
}
