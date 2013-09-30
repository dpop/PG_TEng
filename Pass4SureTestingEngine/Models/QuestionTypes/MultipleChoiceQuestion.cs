using System;
using Pass4SureTestingEngine.Models.AnswerModels;
using Pass4SureTestingEngine.Models.AnswerModels.MultipleChoice;
using Pass4SureTestingEngine.ViewModels.Questions;

namespace Pass4SureTestingEngine.Models.QuestionTypes
{
    [Serializable]
    class MultipleChoiceQuestion : Question
    {
        public MultipleChoiceQuestion()
        {
            Properties = new MultipleChoicePropertiesViewModel();
            AvailableAnswer = new MultipleChoiceAnswer();
            CorrectAnswer = new MultipleChoiceAnswer();
            Properties = new MultipleChoicePropertiesViewModel();
            InitAnswers();
        }

        public MultipleChoicePropertiesViewModel Properties { get; set; }

        public MultipleChoiceAnswer AvailableAnswer { get; set; }

        public MultipleChoiceAnswer CorrectAnswer { get; set; }
        

        private void InitAnswers()
        {
            AvailableAnswer.AddAnswer(new SingleChoiceAnswer
            {
                AnswerText = string.Empty,
                Letter = 'A'
            });
            AvailableAnswer.AddAnswer(new SingleChoiceAnswer
            {
                AnswerText = string.Empty,
                Letter = 'B'
            });
            AvailableAnswer.AddAnswer(new SingleChoiceAnswer
            {
                AnswerText = string.Empty,
                Letter = 'C'
            });
            AvailableAnswer.AddAnswer(new SingleChoiceAnswer
            {
                AnswerText = string.Empty,
                Letter = 'D'
            });
            Properties.LastChoiceLetter = 'D';
            Properties.NumberOfChoices = 4;
            ((MultipleChoiceAnswer)CorrectAnswer).AddAnswer(AvailableAnswer.GetAnswers()[0]);
        }

        
    }
}
