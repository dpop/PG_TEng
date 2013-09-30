using System;
using System.Drawing;

namespace Pass4SureTestingEngine.Models.PropertyModels
{
    [Serializable]
    public class DragObject
    {
        public DragObject()
        {
            Location = null;
        }

        public string Caption { get; set; }
        public Point? Location { get; set; }
    }
}
