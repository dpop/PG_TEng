using System;
using Pass4SureTestingEngine.Models.AnswerModels.Hotspot;
using Pass4SureTestingEngine.ViewModels.Questions;

namespace Pass4SureTestingEngine.Models.QuestionTypes
{
    [Serializable]
    class HotAreaQuestion : Question
    {
        public HotAreaQuestion()
        {
            Properties = new HotAreaPropertiesViewModel();
            CorrectAnswer = new HotAreaAnswer();
            AvailableAnswer = new HotAreaAnswer();
        }

        public HotAreaAnswer CorrectAnswer { get; set; }

        public HotAreaAnswer AvailableAnswer { get; set; }

        public HotAreaPropertiesViewModel Properties { get; set; }
    }
}
