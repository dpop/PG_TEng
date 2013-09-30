using System;
using System.Collections.Generic;
using Pass4SureTestingEngine.Enumerables;
using Pass4SureTestingEngine.Models;
using Pass4SureTestingEngine.Models.QuestionTypes;

namespace Pass4SureTestingEngine.Utils
{
    public  static class QuestionHelper
    {

        private static readonly IDictionary<Type, QuestionType> TypeDictionary = new Dictionary<Type, QuestionType>
                {
                    {typeof (SingleChoiceQuestion), QuestionType.SingleChoice},
                    {typeof (MultipleChoiceQuestion), QuestionType.MultipleChoice},
                    {typeof (FillInTheBlanksQuestion), QuestionType.FillInTheBlanks},
                    {typeof (DragAndDropQuestion), QuestionType.DragAndDrop},
                    {typeof (PointAndShootQuestion), QuestionType.PointAndShoot},
                    {typeof (HotAreaQuestion), QuestionType.HotArea},
                    {typeof (CreateATreeQuestion), QuestionType.CreateATree},
                    {typeof (BuildListAndReorderQuestion), QuestionType.BuildListAndReorder},
                    {typeof (DropAndConnectQuestion), QuestionType.DropAndConnect},
                };

        public static Question GetQuestionFromType(QuestionType questionType)
       {
           Question question;
           switch (questionType)
           {
               case QuestionType.SingleChoice:
                   question = new SingleChoiceQuestion();
                   break;
               case QuestionType.MultipleChoice:
                   question = new MultipleChoiceQuestion();
                   break;
               case QuestionType.FillInTheBlanks:
                   question = new FillInTheBlanksQuestion();
                   break;
               case QuestionType.DragAndDrop:
                   question = new DragAndDropQuestion();
                   break;
               case QuestionType.PointAndShoot:
                   question = new PointAndShootQuestion();
                   break;
               case QuestionType.HotArea:
                   question = new HotAreaQuestion();
                   break;
               case QuestionType.CreateATree:
                   question = new CreateATreeQuestion();
                   break;
               case QuestionType.BuildListAndReorder:
                   question = new BuildListAndReorderQuestion();
                   break;
               case QuestionType.DropAndConnect:
                   question = new DropAndConnectQuestion();
                   break;
               default:
                   question = new SingleChoiceQuestion();
                   break;
           }

           return question;
       }

        public static QuestionType GetTypeFromQuestion(Question question)
        {
            var questionType = TypeDictionary[question.GetType()];
            return questionType;
        }
        
    }
}
