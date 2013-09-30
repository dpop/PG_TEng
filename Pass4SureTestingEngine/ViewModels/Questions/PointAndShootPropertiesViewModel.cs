using System;
using System.Collections.Generic;
using System.Drawing;

namespace Pass4SureTestingEngine.ViewModels.Questions
{
    [Serializable]
    class PointAndShootPropertiesViewModel
    {
        private int _complexity = 5;
        public int Complexity
        {
            get { return _complexity; }
            set { _complexity = value; }
        }

        private string _section = string.Empty;
        public string Section
        {
            get { return _section; }
            set { _section = value; }
        }

        private Image _backgroundimage = null;
        public Image BackgroundImage
        {
            get { return _backgroundimage; }
            set { _backgroundimage = value; }
        }
    }
}
