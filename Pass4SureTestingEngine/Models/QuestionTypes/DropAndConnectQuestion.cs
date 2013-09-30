using System;
using Pass4SureTestingEngine.Models.AnswerModels.DropAndConnect;
using Pass4SureTestingEngine.ViewModels.Questions;

namespace Pass4SureTestingEngine.Models.QuestionTypes
{
    [Serializable]
    class DropAndConnectQuestion : Question
    {
        public DropAndConnectQuestion()
        {
            Properties = new DropAndConnectPropertiesViewModel();
            CorrectAnswer = new DropAndConnectAnswer();
            AvailableAnswer = new DropAndConnectAnswer();
        }

        public DropAndConnectAnswer CorrectAnswer { get; set; }

        public DropAndConnectAnswer AvailableAnswer { get; set; }

        public DropAndConnectPropertiesViewModel Properties { get; set; }
    }
}
