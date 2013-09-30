using System;
using Pass4SureTestingEngine.Models.AnswerModels.BuildListAndReorder;
using Pass4SureTestingEngine.ViewModels.Questions;

namespace Pass4SureTestingEngine.Models.QuestionTypes
{
    [Serializable]
    class BuildListAndReorderQuestion : Question
    {
        public BuildListAndReorderQuestion()
        {
            Properties = new BuildListAndReorderPropertiesViewModel();
            CorrectAnswer = new BuildListAndReorderAnswer();
            AvailableAnswer = new BuildListAndReorderAnswer();
        }

        public BuildListAndReorderAnswer CorrectAnswer { get; set; }

        public BuildListAndReorderAnswer AvailableAnswer { get; set; }

        public BuildListAndReorderPropertiesViewModel Properties { get; set; }
    }
}
