using System;

namespace Pass4SureTestingEngine.Models.AnswerModels
{
    [Serializable]
    class SingleChoiceAnswer 
    {
        public char Letter { get; set; }
        public string AnswerText { get; set; }

        public bool IsCorrect(SingleChoiceAnswer correctAnswer)
        {
            return correctAnswer != null && AnswerText.Equals(correctAnswer.AnswerText);
        }
    }
}
