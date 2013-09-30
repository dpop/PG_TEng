using System;
using System.Collections.Generic;

namespace Pass4SureTestingEngine.Models
{
     [Serializable]
    public class ExamBook
    {
        public ExamBook()
        {
            Exams = new List<Exam>();
            Title = "New Ëxam";
            Number = "000-000";
            FileVersion = "1.0";
            PassingScore = 1000;
            ShowDescription = true;
            Description = @"This is a blank exam";
        }


        public List<Exam> Exams { get; set; }
        public string Title { get; set; }
        public string Number { get; set; }
        public string FileVersion { get; set; }
        public int PassingScore { get; set; }
        public int TimeLimitMinutes { get; set; }
        public bool ShowDescription { get; set; }
        public string Description { get; set; }

    }
}
