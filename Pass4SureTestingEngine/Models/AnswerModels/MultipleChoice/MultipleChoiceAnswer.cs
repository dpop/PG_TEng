using System;
using System.Collections.Generic;
using System.Linq;
using Pass4SureTestingEngine.Utils;

namespace Pass4SureTestingEngine.Models.AnswerModels.MultipleChoice
{
    [Serializable]
    class MultipleChoiceAnswer 
    {
        public MultipleChoiceAnswer()
        {
            ItemList = new List<SingleChoiceAnswer>();
        }

        public List<SingleChoiceAnswer> ItemList { get; set; }

        public bool IsCorrect(MultipleChoiceAnswer correctAnswer)
        {
            bool isCorrect;
            try
            {
                var typedAnswer = correctAnswer;
                isCorrect = (typedAnswer.GetAnswers().Count == ItemList.Count);
                foreach (var singleChoiceAnswer in ItemList)
                {
                    isCorrect = isCorrect && typedAnswer.GetAnswers().Any(x => singleChoiceAnswer.IsCorrect(x));
                }
            }
            catch (Exception)
            {

                isCorrect = false;
            }

            return isCorrect;
        }

        public void RemoveAnswer(SingleChoiceAnswer answer)
        {
            ItemList.Remove(answer);
        }

        public void AddAnswer(SingleChoiceAnswer answer)
        {
            ItemList.Add(answer);
        }

        public List<SingleChoiceAnswer> GetAnswers()
        {
            return ItemList;
        }

        public SingleChoiceAnswer GetAnswer(int? index, string answerText = null, char? letter = null)
        {
            if (index.HasValue && IsValidIndex(index.Value))
            {
                return ItemList[index.Value];
            }

            if (answerText != null)
            {
                return ItemList.FirstOrDefault(x => x.AnswerText.Equals(answerText));
            }

            if (letter.HasValue && letter.Value < LetterHelper.LetterFromInt(ItemList.Count))
            {
                return ItemList.FirstOrDefault(x => x.Letter.Equals(letter.Value));
            }

            return null;
        }

        public bool UpdateItem(int index, SingleChoiceAnswer answer)
        {
            if (IsValidIndex(index))
            {
                ItemList[index] = answer;
            }
            return false;
        }

        private bool IsValidIndex(int index)
        {
            return index > 0 && index < ItemList.Count;
        }
    }
}
