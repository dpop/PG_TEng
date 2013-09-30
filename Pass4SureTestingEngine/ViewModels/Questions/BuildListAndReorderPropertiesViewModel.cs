using System;
using System.Collections.Generic;
using Pass4SureTestingEngine.Enumerables;

namespace Pass4SureTestingEngine.ViewModels.Questions
{
    [Serializable]
    class BuildListAndReorderPropertiesViewModel
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

        private string _orderListTitle = "Order List Title";
        public string OrderListTitle
        {
            get { return _orderListTitle; }
            set { _orderListTitle = value; }
        }

        private string _answerChoiceTitle = "Answer Choices Title";
        public string AnswerChoiceTitle
        {
            get { return _answerChoiceTitle; }
            set { _answerChoiceTitle = value; }
        }

        private bool _orderIsImportant = true;
        public bool OrderIsImportant
        {
            get { return _orderIsImportant; }
            set { _orderIsImportant = value; }
        }

        private bool _reorderOnly;
        public bool ReorderOnly
        {
            get { return _reorderOnly; }
            set { _reorderOnly = value; }
        }

    }
}
