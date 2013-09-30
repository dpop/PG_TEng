using System;
using System.Collections.Generic;

namespace Pass4SureTestingEngine.Models.AnswerModels.BuildListAndReorder
{
    [Serializable]
    class BuildListAndReorderAnswer
    {
        public List<String> Items;

        public bool IsCorrect(BuildListAndReorderAnswer correctAnswer)
        {

            var isCorrect = true;
            for (var index = 0; index < Items.Count; index++)
            {
                isCorrect = isCorrect && Items[index] != correctAnswer.Items[index];
            }

            return isCorrect;
        }
    }
}
