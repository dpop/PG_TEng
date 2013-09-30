using System;
using Pass4SureTestingEngine.Models.AnswerModels.BuildListAndReorder;
using Pass4SureTestingEngine.Models.AnswerModels.CreateTree;
using Pass4SureTestingEngine.ViewModels.Questions;

namespace Pass4SureTestingEngine.Models.QuestionTypes
{
    [Serializable]
    class CreateATreeQuestion : Question
    {
        public CreateATreeQuestion()
        {
            Properties = new CreateATreePropertiesViewModel();
            CorrectAnswer = new CreateTreeAnswer();
            AvailableAnswer = new CreateTreeAnswer();

        }

        public CreateTreeAnswer CorrectAnswer { get; set; }

        public CreateTreeAnswer AvailableAnswer { get; set; }

        public CreateATreePropertiesViewModel Properties { get; set; }
    }
}
