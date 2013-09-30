using System;
using System.Drawing;

namespace Pass4SureTestingEngine.Models.AnswerModels.PointAndShoot
{
    [Serializable]
    class PointAndShootAnswer 
    {
        public Rectangle ShootingArea { get; set; }

        public bool IsCorrect(PointAndShootAnswer correctAnswer)
        {
            return false;
        }

        public bool IsCorrect(Point point)
        {
            return ShootingArea.Contains(point);
        }
    }
}
