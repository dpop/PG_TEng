using System;
using Pass4SureTestingEngine.Models.AnswerModels;
using Pass4SureTestingEngine.Models.AnswerModels.BuildListAndReorder;
using Pass4SureTestingEngine.ViewModels.Questions;

namespace Pass4SureTestingEngine.Models.QuestionTypes
{
    [Serializable]
    class DragAndDropQuestion : Question
    {
        public DragAndDropQuestion()
        {
            Properties = new DragAndDropPropertiesViewModel();
            CorrectAnswer = new DragAndDropAnswer();
            AvailableAnswer = new DragAndDropAnswer();
        }

        public DragAndDropAnswer CorrectAnswer { get; set; }

        public DragAndDropAnswer AvailableAnswer { get; set; }

        public DragAndDropPropertiesViewModel Properties { get; set; }
    }
}
