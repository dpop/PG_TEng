using System;
using Pass4SureTestingEngine.Enumerables;

namespace Pass4SureTestingEngine.ViewModels.Questions
{
    [Serializable]
    class CreateATreePropertiesViewModel
    {
        private int _complexity = 5;
        public int Complexity
        {
            get { return _complexity; }
            set { _complexity = value; }
        }

        private string _section = string.Empty;
        public string Section
        {
            get { return _section; }
            set { _section = value; }
        }

        public DragType DragType { get; set; }

        private string _treeStructureTitle = "Tree Structure Title";
        public string TreeStructureTitle
        {
            get { return _treeStructureTitle; }
            set { _treeStructureTitle = value; }
        }

        private string _answerChoiceTitle = "Answer Choices Title";
        public string AnswerChoiceTitle
        {
            get { return _answerChoiceTitle; }
            set { _answerChoiceTitle = value; }
        }
    }
}
