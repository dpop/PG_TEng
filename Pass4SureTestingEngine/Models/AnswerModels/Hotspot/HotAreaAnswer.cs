using System;
using System.Collections.Generic;
using System.Linq;

namespace Pass4SureTestingEngine.Models.AnswerModels.Hotspot
{
    [Serializable]
    class HotAreaAnswer 
    {
        public List<CustomRectangle> SelectedRectangles;

        public bool IsCorrect(HotAreaAnswer correctAnswer)
        {
            var isCorrect = true;
            if (correctAnswer != null)
            {
                foreach (var correctRectangle in correctAnswer.SelectedRectangles)
                {
                    isCorrect = isCorrect && SelectedRectangles.Any(x => x.Location.X == correctRectangle.Location.X &&
                                                                         x.Location.Y == correctRectangle.Location.Y &&
                                                                         x.Size.Height == correctRectangle.Size.Height &&
                                                                         x.Size.Width == correctRectangle.Size.Width);
                }
            }

            return isCorrect;
        }
    }
}
 