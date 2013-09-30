using System;   
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Pass4SureTestingEngine.Models.AnswerModels
{
    [Serializable]
    class DragAndDropAnswer
    {
        public List<Rectangle> Sources { get; set; }
        public List<Rectangle> Targets { get; set; }
        public DragAndDropAnswer()
        {
            Sources = new List<Rectangle>();
            Targets = new List<Rectangle>();
        }

        public bool IsCorrect(DragAndDropAnswer correctAnswer)
        {
            var isCorrect = true;
            foreach (var rectangle in Targets)
            {
                isCorrect = isCorrect && Sources.Any(x => x.Location.X == rectangle.Location.X &&
                                                          x.Location.Y == rectangle.Location.Y &&
                                                          x.Width == rectangle.Width &&
                                                          x.Height == rectangle.Height);
            }

            return isCorrect;
        }
    }
}
