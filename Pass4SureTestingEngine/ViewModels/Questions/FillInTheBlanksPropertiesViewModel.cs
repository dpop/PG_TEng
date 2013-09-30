using System;
using System.Collections.Generic;

namespace Pass4SureTestingEngine.ViewModels.Questions
{
    [Serializable]
    class FillInTheBlanksPropertiesViewModel
    {
        private int _complexity = 5;
        public int Complexity
        {
            get { return _complexity; }
            set { _complexity = value; }
        }

        private bool _caseSensitive = true;
        public bool CaseSensitive
        {
            get { return _caseSensitive; }
            set { _caseSensitive = value; }
        }


        private string _section = string.Empty;
        public string Section
        {
            get { return _section; }
            set { _section = value; }
        }


        private int _numberOfAnswers = 1;
        public int NumberOfAnswers
        {
            get { return _numberOfAnswers; }
            set { _numberOfAnswers = value; }
        }

        private bool _ignoreMultipleSpaces = true;
        public bool IgnoreMultipleSpaces
        {
            get { return _ignoreMultipleSpaces; }
            set { _ignoreMultipleSpaces = value; }
        }

        private bool _trimCandidateResponse = true;
        public bool TrimCandidateResponse
        {
            get { return _trimCandidateResponse; }
            set { _trimCandidateResponse = value; }
        }

       
    }
}
