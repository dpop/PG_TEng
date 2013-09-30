using System;
using Pass4SureTestingEngine.Models.AnswerModels.PointAndShoot;
using Pass4SureTestingEngine.ViewModels.Questions;

namespace Pass4SureTestingEngine.Models.QuestionTypes
{
    [Serializable]
    class PointAndShootQuestion : Question
    {
        public PointAndShootQuestion()
        {
            Properties = new PointAndShootPropertiesViewModel();
            CorrectAnswer = new PointAndShootAnswer();
        }

        public PointAndShootAnswer CorrectAnswer { get; set; }

        public PointAndShootPropertiesViewModel Properties { get; set; }
    }
}
