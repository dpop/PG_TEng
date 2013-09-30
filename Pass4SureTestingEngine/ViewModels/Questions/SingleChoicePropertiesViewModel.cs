using System;
using System.Collections.Generic;
using Pass4SureTestingEngine.Enumerables;

namespace Pass4SureTestingEngine.ViewModels.Questions
{
    [Serializable]
    class SingleChoicePropertiesViewModel
    {
        private int _complexity = 5;
        public int Complexity {
            get { return _complexity; }
            set { _complexity = value; } 
        }

        private AnswerType _answerType = AnswerType.SingleSelect;
        public AnswerType AnswerType
        {
            get { return _answerType; }
            set { _answerType = value; }
        }


        private string _sections = string.Empty;
        public string Section
        {
            get { return _sections; }
            set { _sections = value; }
        }


        private bool _allowShuffle = true;
        public bool AllowShuffleChoice
        {
            get { return _allowShuffle; }
            set { _allowShuffle = value; }
        }

        private bool _checkNumberOfSelected = true;
        public bool CheckNumberOfSelected
        {
            get { return _checkNumberOfSelected; }
            set { _checkNumberOfSelected = value; }
        }

        private int _numberOfChoices = 4;
        public int NumberOfChoices
        {
            get { return _numberOfChoices; }
            set { _numberOfChoices = value; }
        }


        private char _lastChoiceLetter = 'D';
        public char LastChoiceLetter
        {
            get { return _lastChoiceLetter; }
            set { _lastChoiceLetter = value; }
        }
    }
}
