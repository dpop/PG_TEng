using System;
using System.Drawing;

namespace Pass4SureTestingEngine.ViewModels.Questions
{
    [Serializable]
    public class Exhibit
    {
        public string Title { get; set; }

        public string Resolution { get; set; }

        public string Type { get; set; }

        public string Size { get; set; }

        public Image Sample { get; set; }
    }
}
