using Pass4SureTestingEngine.Enumerables;
using Pass4SureTestingEngine.Models;

namespace Pass4SureTestingEngine.Utils
{
    public static class ClipboardHelper
    {
        private static Question _questionInstance;
        private static Exam _examInstance;
        private static ClipboardOperationType _currentOperationType = ClipboardOperationType.Copy;

        public static void SetClipboardItem(object item, NodeType type, ClipboardOperationType operationType)
        {
            _currentOperationType = operationType;
            if (NodeType.Exam == type)
            {
                _questionInstance = null;
                _examInstance = (Exam) item;
            }
            else
            {
                _questionInstance = (Question) item;
                _examInstance = null;
            }
        }


        public static NodeType? GetClipboardType()
        {
            if (_examInstance != null)
            {
                return NodeType.Exam;
            }

            if (_questionInstance != null)
            {
                return NodeType.Question;
            }

            return null;
        }


       public static Question GetClipboardQuestion()
       {
           var returnQuestion = _questionInstance;
           if (_currentOperationType == ClipboardOperationType.Cut)
           {
               _questionInstance = null;
               _examInstance = null;
           }

           return returnQuestion;
       }


       public static Exam GetClipboardExam()
       {
           var returnExam = _examInstance;
           if (_currentOperationType == ClipboardOperationType.Cut)
           {
               _questionInstance = null;
               _examInstance = null;
           }

           return returnExam;
       }
    }
}
