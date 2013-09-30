using System;
using System.Collections.Generic;
using System.Drawing;
using Pass4SureTestingEngine.ViewModels.Questions;

namespace Pass4SureTestingEngine.Models
{
    [Serializable]
    public class Question
    {
        public string Description { get; set; }
        public Dictionary<string, Image> Images { get; set; }
        public string AnswerAdditionalInfo { get; set; }
        public string Instructions { get; set; }
        public string SectionName { get; set; }

        private List<Exhibit> _exhibits = new List<Exhibit>();
        public List<Exhibit> Exhibits
        {
            get { return _exhibits; }
            set { _exhibits = value; }
        }
    }
}
