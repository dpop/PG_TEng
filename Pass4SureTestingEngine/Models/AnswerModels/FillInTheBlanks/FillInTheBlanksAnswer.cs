using System;

namespace Pass4SureTestingEngine.Models.AnswerModels
{
    [Serializable]
    class FillInTheBlanksAnswer 
    {
        public bool IsCorrect(FillInTheBlanksAnswer correctAnswer)
        {
            return correctAnswer != null && Answer.Equals(correctAnswer.Answer);
        }

        public string Answer { get; set; }
    }
}
