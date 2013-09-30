using System;
using Pass4SureTestingEngine.Enumerables;
using Pass4SureTestingEngine.Models;

namespace Pass4SureTestingEngine.Parser
{
    public class QuestionParser
    {

        public Question ParseQuestion(string question, string pattern)
        {
            //try
            //{
            //    var resultQuestion = new Question();


            //    if ((resultQuestion.Number = GetQuestionNumber(pattern, ref question)) < 0)
            //    {
            //        return null;
            //    }

            //    resultQuestion.Type = GetQuestionType(pattern, ref question);

            //    resultQuestion.Description = GetQuestionDescription(pattern, resultQuestion.Type, ref question);

            //    return resultQuestion;
            //}
            //catch (Exception exp)
            //{

            //    return null;
            //}
            return null;

        }

        public int GetQuestionNumber(string pattern,ref string question)
        {
            var firstLine = question.Substring(0, question.IndexOf("\n") < 0 ? question.Length - 1 : question.IndexOf("\n"));
            var stringNumber = firstLine.Replace(pattern.Substring(0, pattern.IndexOf("{0}")), string.Empty);

            question = question.Replace(firstLine + "\n", string.Empty);

            int number;
            if (!int.TryParse(stringNumber, out number))
            {
                return -1;
            }

            return number;
        }

        public QuestionType GetQuestionType(string pattern, ref string question)
        {
            var firstLine = question.Substring(0, question.IndexOf("\n") < 0 ? question.Length - 1 : question.IndexOf("\n"));

            if (firstLine.Contains("Fill in the Blanks"))
            {
                question = question.Replace(firstLine + "\n", string.Empty);
                return QuestionType.FillInTheBlanks;
            }

            if (firstLine.Contains("DRAG DROP"))
            {
                question = question.Replace(firstLine + "\n", string.Empty);
                return QuestionType.DragAndDrop;
            }

            if (firstLine.Contains("Point and Shoot"))
            {
                question = question.Replace(firstLine + "\n", string.Empty);
                return QuestionType.PointAndShoot;
            }

            if (firstLine.Contains("HOTSPOT"))
            {
                question = question.Replace(firstLine + "\n", string.Empty);
                return QuestionType.HotArea;
            }

            if (firstLine.Contains("Build List and Reorder"))
            {
                question = question.Replace(firstLine + "\n", string.Empty);
                return QuestionType.BuildListAndReorder;
            }

            if (firstLine.Contains("Drop and Connect"))
            {
                question = question.Replace(firstLine + "\n", string.Empty);
                return QuestionType.DropAndConnect;
            }

            if (firstLine.Contains("Create A Tree"))
            {
                question = question.Replace(firstLine + "\n", string.Empty);
                return QuestionType.CreateATree;
            }

            var answerIndex = question.IndexOf("Answer: ");

            var answerLine = question.Substring(answerIndex, question.IndexOf("\n", answerIndex) < 0 ? question.Length - 1 : question.IndexOf("\n", answerIndex) - answerIndex);

            answerLine = answerLine.Replace("Answer: ", string.Empty);
            if (answerLine.Length > 1)
                return QuestionType.MultipleChoice;

            return QuestionType.SingleChoice;
            
            
        }

        public string GetQuestionDescription(string pattern, QuestionType questionType, ref string question)
        {
            var description = string.Empty;
            if (questionType == QuestionType.MultipleChoice || questionType == QuestionType.SingleChoice)
            {
                description = question.Substring(0, question.IndexOf("A. "));
            }
            else
            {
                description = question.Substring(0, question.IndexOf("Answer: "));
            }
            return description;
        }
    }
}
