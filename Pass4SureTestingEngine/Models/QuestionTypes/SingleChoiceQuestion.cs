using System;
using System.Collections.Generic;
using Pass4SureTestingEngine.Models.AnswerModels;
using Pass4SureTestingEngine.ViewModels.Questions;

namespace Pass4SureTestingEngine.Models.QuestionTypes
{
    [Serializable]
    class SingleChoiceQuestion : Question
    {
        public SingleChoiceQuestion()
        {
            Properties = new SingleChoicePropertiesViewModel();    
            AvailableAnswers = new List<SingleChoiceAnswer>();
            CorrectAnswer = new SingleChoiceAnswer();
            InitAnswers();
        }

        public SingleChoicePropertiesViewModel Properties { get; set; }

        public SingleChoiceAnswer CorrectAnswer { get; set; }

        public List<SingleChoiceAnswer> AvailableAnswers { get; set; }

        private void InitAnswers()
        {
            AvailableAnswers.Add(new SingleChoiceAnswer
            {
                AnswerText = string.Empty,
                Letter = 'A'
            });
            AvailableAnswers.Add(new SingleChoiceAnswer
            {
                AnswerText = string.Empty,
                Letter = 'B'
            });
            AvailableAnswers.Add(new SingleChoiceAnswer
            {
                AnswerText = string.Empty,
                Letter = 'C'
            });
            AvailableAnswers.Add(new SingleChoiceAnswer
            {
                AnswerText = string.Empty,
                Letter = 'D'
            });
            Properties.LastChoiceLetter = 'D';
            Properties.NumberOfChoices = 4;
            ((SingleChoiceAnswer)CorrectAnswer).AnswerText = string.Empty;
            ((SingleChoiceAnswer)CorrectAnswer).Letter = 'A';
        }
    }
}
