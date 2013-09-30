using System;
using System.Collections.Generic;
using Pass4SureTestingEngine.Utils;

namespace Pass4SureTestingEngine.Models
{
    [Serializable]
    public class Exam
    {
        
        public Exam()
        {
            Questions = new List<Question>();
            ExamName = Constants.ExamDefaultTitle;
            Sections = new List<string>();
        }

        public List<Question> Questions { get; set; }
        public List<string> Sections { get; set; }
        public string ExamName { get; set; }

        public override string ToString()
        {
            return ExamName;
        }
    }
}
 