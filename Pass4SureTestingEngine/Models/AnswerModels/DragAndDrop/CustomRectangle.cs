using System;
using System.Drawing;

namespace Pass4SureTestingEngine.Models
{
    [Serializable]
    class CustomRectangle
    {
        public Point Location { get; set; }
        public Size Size { get; set; }
        public int Identifier { get; set; }
    }
}
