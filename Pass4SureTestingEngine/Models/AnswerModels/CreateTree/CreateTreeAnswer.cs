using System;
using System.Collections.Generic;
using System.Linq;

namespace Pass4SureTestingEngine.Models.AnswerModels.CreateTree
{
    [Serializable]
    class CreateTreeAnswer
    {
        public ExamTreeNode Root { get; set; }

        public bool IsCorrect(CreateTreeAnswer correctAnswer)
        {
            return Equals(correctAnswer.Root);
        }


        public bool Equals(ExamTreeNode examTreeNode)
        {
            return RecursiveEquals(examTreeNode, Root) && RecursiveEquals(Root, examTreeNode);
        }

        private bool RecursiveEquals(ExamTreeNode firstExamTreeNode, ExamTreeNode secondExamTreeNode)
        {
            if (firstExamTreeNode.Children == null && secondExamTreeNode.Children == null)
            {
                return true;
            }
            if (firstExamTreeNode.Children == null || secondExamTreeNode.Children == null)
            {
                return false;
            }

            var isEqualTillNow = CompareChildren(firstExamTreeNode.Children, secondExamTreeNode.Children);

            foreach (var treeViewNode in firstExamTreeNode.Children)
            {
                var secondNode = secondExamTreeNode.Children.FirstOrDefault(x => x.Text == treeViewNode.Text);

                return isEqualTillNow && RecursiveEquals(treeViewNode, secondNode);
            }

            return isEqualTillNow;
        }
        private bool CompareChildren(IEnumerable<ExamTreeNode> firstChildList, IEnumerable<ExamTreeNode> secondChildsList)
        {
            var isEqual = true;

            foreach (var examTreeNode in secondChildsList)
            {
                isEqual = isEqual && firstChildList.ToList().Any(x => x.Text == examTreeNode.Text);
            }

            return isEqual;
        }
    }
}
