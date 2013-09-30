using Pass4SureTestingEngine.Enumerables;
using Pass4SureTestingEngine.Models;

namespace Pass4SureTestingEngine.Logic.Filters
{
    public class QuestionFilter
    {
        public QuestionType QuestionType { get; set; }

        // a must
        public Exam Exam { get; set; }
    }
}
