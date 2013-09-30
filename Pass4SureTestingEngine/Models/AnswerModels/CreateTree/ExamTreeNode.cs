using System;
using System.Collections.Generic;

namespace Pass4SureTestingEngine.Models.AnswerModels.CreateTree
{
    [Serializable]
    class ExamTreeNode
    {
        public String Text { get; set; }
        public List<ExamTreeNode> Children { get; set; }
    }
}
