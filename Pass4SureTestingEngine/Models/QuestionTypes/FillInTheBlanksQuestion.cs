using System;
using Pass4SureTestingEngine.Models.AnswerModels;
using Pass4SureTestingEngine.ViewModels.Questions;

namespace Pass4SureTestingEngine.Models.QuestionTypes
{
    [Serializable]
    class FillInTheBlanksQuestion : Question
    {
        public FillInTheBlanksQuestion()
        {
            Properties = new FillInTheBlanksPropertiesViewModel();
            CorrectAnswer = new FillInTheBlanksAnswer();
        }

        public FillInTheBlanksAnswer CorrectAnswer { get; set; }

        public FillInTheBlanksPropertiesViewModel Properties { get; set; }
    }
}
