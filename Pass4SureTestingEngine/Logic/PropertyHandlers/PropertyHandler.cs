using System.Windows.Forms;
using Pass4SureTestingEngine.Enumerables;
using Pass4SureTestingEngine.Models;
using Pass4SureTestingEngine.Models.QuestionTypes;
using Pass4SureTestingEngine.Views.PropertyWindowTemplates;
using PropertyGridEx;
using System.Drawing;

namespace Pass4SureTestingEngine.Logic.PropertyHandlers
{


    /* this was a shitty idea */ 
    class PropertyHandler
    {

        public static CustomPropertyCollection GetItems(QuestionType type, Question question, Control container)
        {

            CustomPropertyCollection item;

            switch (type)
            {
                case QuestionType.SingleChoice:
                    item = GetChoiceItems(question, container, true);
                    break;
                case QuestionType.MultipleChoice:
                    item = GetMultipleChoiceItems(question, container, false);
                    break;
                case QuestionType.FillInTheBlanks:
                    item = GetFillInTheBlankItems(question, container);
                    break;
                case QuestionType.DragAndDrop:
                    item = GetDragAndDropItems(question, container);
                    break;
                case QuestionType.PointAndShoot:
                    item = GetPointAndShootItems(question, container);
                    break;
                case QuestionType.HotArea:
                    item = GetHotSpotItems(question, container);
                    break;
                case QuestionType.CreateATree:
                    item = GetCreateATreeItems(question, container);
                    break;
                case QuestionType.BuildListAndReorder:
                    item = GetBuildListItems(question, container);
                    break; 
                case QuestionType.DropAndConnect:
                    item = GetDropAndConnectItems(question, container);
                    break;
                default :
                    item = GetDefaultChoicesItems();
                    break;
            }

            return item;
        }

        private static CustomPropertyCollection GetChoiceItems(Question question, Control container, bool isSingle)
        {

            var typedQuestion = (SingleChoiceQuestion) question;

            var questionProperties = typedQuestion.Properties;
            var item = new CustomPropertyCollection
                {
                    {
                        "Answer Type", questionProperties.AnswerType, false, "Question",
                        @"Defines the number of choices the candidate can select when answering the question(one or several).  "
                        , true
                    },
                    {
                        "Complexity", questionProperties.Complexity, false, "Question",
                        @"Defines the complexity level of a question. The minimum complexity level is 1, 
                     the maximum complexity level is 10. This property is used to weight questions based on difficulty "
                        , true
                    }
                };
            item[item.Count - 2].Tag = "AnswerType";
            item[item.Count - 1].Tag = "Complexity";
            var exam = ExamManager.GetInstance().GetSelectedExam();
            var sectionNames = exam.Sections;

            item.Add("Sections", questionProperties.Section, false, "Question",
                    @"Defines the number of choices the candidate can select when answering the question(one or several). ",
                    true);
            item[item.Count - 1].Tag = "Section";
            item[item.Count - 1].Datasource = sectionNames;
            item[item.Count - 1].IsDropdownResizable = true;

            item.Add("Exhibits", question.Exhibits.Count == 0 ? "empty" : "(collection)", false, "Question",
                    @"The collection of exhibits associated with this question. ",
                    true);

            item[item.Count - 1].OnClick += (sender, args) => {
                var customPropertyDescriptor = (CustomProperty.CustomPropertyDescriptor)sender;
                var exhibit = new ExhibitsView((CustomProperty)customPropertyDescriptor.CustomProperty, container);
                exhibit.Show(container);
                return question.Exhibits.Count == 0 ? "empty" : "(collection)";
            };

            item.Add("Allow Shuffle Choices", questionProperties.AllowShuffleChoice, false, "Choice",
                     @"Defines if choice randomization is allowed.If FALSE, the order of the choices will always stay 
                      like the original. ",
                     true);
            item[item.Count - 1].Tag = "AllowShuffleChoice";

            item.Add("Check Number of Selected", questionProperties.CheckNumberOfSelected, isSingle, "Choice",
                    @"Used with questions that have the Answer Type property set to Multiple Select. If true the 
                     number of choices the candidate can select will be limited to the number of correct choices",
                    true);
            item[item.Count - 1].Tag = "CheckNumberOfSelected";

            item.Add("Number of Choices", questionProperties.NumberOfChoices, false, "Choice",
                   @"Defines the number of choices. To specify the number of choices, you can use either the Number of Choices 
                       or the Last Choice Letter property.",
                   true);
            item[item.Count - 1].Tag = "NumberOfChoices";

            item.Add("Last Choice Letter", questionProperties.LastChoiceLetter, false, "Choice",
                   @"Defines the number of choices using the last choice letter property. For example, the letter D means 4 choices .To specify the number of choices, you can use either the Number of Choices 
                       or the Last Choice Letter  property. ",
                   true);
            item[item.Count - 1].Tag = "LastChoiceLetter";

            return item;
        }

        private static CustomPropertyCollection GetMultipleChoiceItems(Question question, Control container, bool isSingle)
        {

            var typedQuestion = (MultipleChoiceQuestion)question;

            var questionProperties = typedQuestion.Properties;
            var item = new CustomPropertyCollection
                {
                    {
                        "Answer Type", questionProperties.AnswerType, false, "Question",
                        @"Defines the number of choices the candidate can select when answering the question(one or several).  "
                        , true
                    },
                    {
                        "Complexity", questionProperties.Complexity, false, "Question",
                        @"Defines the complexity level of a question. The minimum complexity level is 1, 
                     the maximum complexity level is 10. This property is used to weight questions based on difficulty "
                        , true
                    }
                };
            item[item.Count - 2].Tag = "AnswerType";
            item[item.Count - 1].Tag = "Complexity";
            var exam = ExamManager.GetInstance().GetSelectedExam();
            var sectionNames = exam.Sections;

            item.Add("Sections", questionProperties.Section, false, "Question",
                    @"Defines the number of choices the candidate can select when answering the question(one or several). ",
                    true);
            item[item.Count - 1].Datasource = sectionNames;
            item[item.Count - 1].IsDropdownResizable = true;
            item[item.Count - 1].Tag = "Section";

            item.Add("Exhibits", question.Exhibits.Count == 0 ? "empty" : "(collection)", false, "Question",
                    @"The collection of exhibits associated with this question. ",
                    true);

            item[item.Count - 1].OnClick += (sender, args) =>
            {
                var customPropertyDescriptor = (CustomProperty.CustomPropertyDescriptor)sender;
                var exhibit = new ExhibitsView((CustomProperty)customPropertyDescriptor.CustomProperty, container);
                exhibit.Show(container);
                return question.Exhibits.Count == 0 ? "empty" : "(collection)";
            };
            item[item.Count - 1].Tag = "Exhibits";

            item.Add("Allow Shuffle Choices", questionProperties.AllowShuffleChoice, false, "Choice",
                     @"Defines if choice randomization is allowed.If FALSE, the order of the choices will always stay 
                      like the original. ",
                     true);
            item[item.Count - 1].Tag = "AllowShuffleChoice";

            item.Add("Check Number of Selected", questionProperties.CheckNumberOfSelected, isSingle, "Choice",
                    @"Used with questions that have the Answer Type property set to Multiple Select. If true the 
                     number of choices the candidate can select will be limited to the number of correct choices",
                    true);
            item[item.Count - 1].Tag = "CheckNumberOfSelected";

            item.Add("Number of Choices", questionProperties.NumberOfChoices, false, "Choice",
                   @"Defines the number of choices. To specify the number of choices, you can use either the Number of Choices 
                       or the Last Choice Letter property.",
                   true);
            item[item.Count - 1].Tag = "NumberOfChoices";

            item.Add("Last Choice Letter", questionProperties.LastChoiceLetter, false, "Choice",
                   @"Defines the number of choices using the last choice letter property. For example, the letter D means 4 choices .To specify the number of choices, you can use either the Number of Choices 
                       or the Last Choice Letter  property. ",
                   true);
            item[item.Count - 1].Tag = "LastChoiceLetter";

            return item;
        }

        private static CustomPropertyCollection GetFillInTheBlankItems(Question question, Control container)
        {
            var typedQuestion = (FillInTheBlanksQuestion)question;

            var questionProperties = typedQuestion.Properties;
            var item = new CustomPropertyCollection
                {
                    {
                        "Complexity", questionProperties.Complexity, false, "Question",
                        @"Defines the complexity level of a question. The minimum complexity level is 1, 
                     the maximum complexity level is 10. This property is used to weight questions based on difficulty "
                        , true
                    }
                };
            item[item.Count - 1].Tag = "Complexity";
            var exam = ExamManager.GetInstance().GetSelectedExam();
            var sectionNames = exam.Sections;

            item.Add("Sections", questionProperties.Section, false, "Question",
                    @"Defines the number of choices the candidate can select when answering the question(one or several). ",
                    true);
            item[item.Count - 1].Datasource = sectionNames;
            item[item.Count - 1].IsDropdownResizable = true;
            item[item.Count - 1].Tag = "Section";

            item.Add("Exhibits", question.Exhibits.Count == 0 ? "empty" : "(collection)", false, "Question",
                    @"The collection of exhibits associated with this question. ",
                    true);

            item[item.Count - 1].OnClick += (sender, args) =>
            {
                var customPropertyDescriptor = (CustomProperty.CustomPropertyDescriptor)sender;
                var exhibit = new ExhibitsView((CustomProperty)customPropertyDescriptor.CustomProperty, container);
                exhibit.Show(container);
                return question.Exhibits.Count == 0 ? "empty" : "(collection)";
            };
            item[item.Count - 1].Tag = "Exhibits";

            item.Add("Case Sensitive", questionProperties.CaseSensitive, false, "Answer",
                     @"Defines the method of comparing the candidate's response with the correct answer(s). If True, the comparison in case sensitive.",
                     true);
            item[item.Count - 1].Tag = "CaseSensitive";

            item.Add("Ignore Multiple Spaces", questionProperties.IgnoreMultipleSpaces, false, "Answer",
                    @"Defines the method of comparing the candidate's response with the correct answer(s). If True, multiple spaces are equal to a single space",
                    true);
            item[item.Count - 1].Tag = "IgnoreMultipleSpaces";

            item.Add("Number of answers", questionProperties.NumberOfAnswers, false, "Answer",
                   @"Defines the number of correct answers. If the candidate's response coincides with one of the correct answers, it is considered to be correct. ",
                   true);
            item[item.Count - 1].Tag = "NumberOfAnswers";

            item.Add("Trim Candidate's Response", questionProperties.TrimCandidateResponse, false, "Answer",
                   @"Defines the necessity of trimming leading and trailing spaces in the character response before comparing it with the correct answer(s) ",
                   true);
            item[item.Count - 1].Tag = "Section";

            return item;
        }

        private static CustomPropertyCollection GetDragAndDropItems(Question question, Control container)
        {
            var typedQuestion = (DragAndDropQuestion)question;

            var questionProperties = typedQuestion.Properties;
            var item = new CustomPropertyCollection
                {
                    {
                        "Complexity", questionProperties.Complexity, false, "Question",
                        @"Defines the complexity level of a question. The minimum complexity level is 1, 
                     the maximum complexity level is 10. This property is used to weight questions based on difficulty "
                        , true
                    }
                };
            var exam = ExamManager.GetInstance().GetSelectedExam();
            var sectionNames = exam.Sections;

            item.Add("Sections", questionProperties.Section, false, "Question",
                    @"Defines the number of choices the candidate can select when answering the question(one or several). ",
                    true);
            item[item.Count - 1].Datasource = sectionNames;
            item[item.Count - 1].IsDropdownResizable = true;

            item.Add("Exhibits", question.Exhibits.Count == 0 ? "empty" : "(collection)", false, "Question",
                    @"The collection of exhibits associated with this question. ",
                    true);

            item[item.Count - 1].OnClick += (sender, args) =>
                {
                    var customPropertyDescriptor = (CustomProperty.CustomPropertyDescriptor) sender;
                    var exhibit = new ExhibitsView((CustomProperty)customPropertyDescriptor.CustomProperty, container);
                    exhibit.Show(container);
                    return question.Exhibits.Count == 0 ? "empty" : "(collection)";
            };
            object image = container.Controls[0];
            item.Add("Background Image", ref image, "DocCommentImage", false, "Question",
                     @"Allows you to specify the background image.The background image is a compulsory item that defines the question content.",
                     true);
            item[item.Count - 1].DefaultType = typeof(Image);
            item[item.Count - 1].DefaultValue = null;

            item.Add("Drag Type", questionProperties.DragType, false, "Question",
                    @"Defines the logic of item dragging. If Multiple Instance, each dragged item can be used more than once.",
                    true);

          

            return item;
        }

        private static CustomPropertyCollection GetPointAndShootItems(Question question, Control container)
        {
            var typedQuestion = (PointAndShootQuestion)question;

            var questionProperties = typedQuestion.Properties;
            var item = new CustomPropertyCollection
                {
                    {
                        "Complexity", questionProperties.Complexity, false, "Question",
                        @"Defines the complexity level of a question. The minimum complexity level is 1, 
                     the maximum complexity level is 10. This property is used to weight questions based on difficulty "
                        , true
                    }
                };
            var exam = ExamManager.GetInstance().GetSelectedExam();
            var sectionNames = exam.Sections;

            item.Add("Sections", questionProperties.Section, false, "Question",
                    @"Defines the number of choices the candidate can select when answering the question(one or several). ",
                    true);
            item[item.Count - 1].Datasource = sectionNames;
            item[item.Count - 1].IsDropdownResizable = true;

            item.Add("Exhibits", question.Exhibits.Count == 0 ? "empty" : "(collection)", false, "Question",
                    @"The collection of exhibits associated with this question. ",
                    true);

            item[item.Count - 1].OnClick += (sender, args) =>
            {
                var customPropertyDescriptor = (CustomProperty.CustomPropertyDescriptor)sender;
                var exhibit = new ExhibitsView((CustomProperty)customPropertyDescriptor.CustomProperty, container);
                exhibit.Show(container);
                return question.Exhibits.Count == 0 ? "empty" : "(collection)";
            };
            object image = container.Controls[0];
            item.Add("Background Image", ref image, "DocCommentImage", false, "Question",
                     @"Allows you to specify the background image.The background image is a compulsory item that defines the question content.",
                     true);
            item[item.Count - 1].DefaultType = typeof(Image);
            item[item.Count - 1].DefaultValue = null;

            return item;
        }

        private static CustomPropertyCollection GetHotSpotItems(Question question, Control container)
        {
            var typedQuestion = (HotAreaQuestion)question;

            var questionProperties = typedQuestion.Properties;
            var item = new CustomPropertyCollection
                {
                    {
                        "Complexity", questionProperties.Complexity, false, "Question",
                        @"Defines the complexity level of a question. The minimum complexity level is 1, 
                     the maximum complexity level is 10. This property is used to weight questions based on difficulty "
                        , true
                    }
                };
            var exam = ExamManager.GetInstance().GetSelectedExam();
            var sectionNames = exam.Sections;

            item.Add("Sections", questionProperties.Section, false, "Question",
                    @"Defines the number of choices the candidate can select when answering the question(one or several). ",
                    true);
            item[item.Count - 1].Datasource = sectionNames;
            item[item.Count - 1].IsDropdownResizable = true;

            item.Add("Exhibits", question.Exhibits.Count == 0 ? "empty" : "(collection)", false, "Question",
                    @"The collection of exhibits associated with this question. ",
                    true);

            item[item.Count - 1].OnClick += (sender, args) =>
            {
                var customPropertyDescriptor = (CustomProperty.CustomPropertyDescriptor)sender;
                var exhibit = new ExhibitsView((CustomProperty)customPropertyDescriptor.CustomProperty, container);
                exhibit.Show(container);
                return question.Exhibits.Count == 0 ? "empty" : "(collection)";
            };
            object image = container.Controls[0];
            item.Add("Background Image", ref image, "DocCommentImage", false, "Question",
                     @"Allows you to specify the background image.The background image is a compulsory item that defines the question content.",
                     true);
            item[item.Count - 1].DefaultType = typeof(Image);
            item[item.Count - 1].DefaultValue = null;

            return item;
        }

        private static CustomPropertyCollection GetCreateATreeItems(Question question, Control container)
        {
            var typedQuestion = (CreateATreeQuestion)question;

            var questionProperties = typedQuestion.Properties;
            var item = new CustomPropertyCollection
                {
                    {
                        "Complexity", questionProperties.Complexity, false, "Question",
                        @"Defines the complexity level of a question. The minimum complexity level is 1, 
                     the maximum complexity level is 10. This property is used to weight questions based on difficulty "
                        , true
                    }
                };
            var exam = ExamManager.GetInstance().GetSelectedExam();
            var sectionNames = exam.Sections;

            item.Add("Sections", questionProperties.Section, false, "Question",
                    @"Defines the number of choices the candidate can select when answering the question(one or several). ",
                    true);
            item[item.Count - 1].Datasource = sectionNames;
            item[item.Count - 1].IsDropdownResizable = true;

            item.Add("Exhibits", question.Exhibits.Count == 0 ? "empty" : "(collection)", false, "Question",
                    @"The collection of exhibits associated with this question. ",
                    true);

            item[item.Count - 1].OnClick += (sender, args) =>
            {
                var customPropertyDescriptor = (CustomProperty.CustomPropertyDescriptor)sender;
                var exhibit = new ExhibitsView((CustomProperty)customPropertyDescriptor.CustomProperty, container);
                exhibit.Show(container);
                return question.Exhibits.Count == 0 ? "empty" : "(collection)";
            };

            item.Add("Drag Type", questionProperties.DragType, false, "Question",
                    @"Defines the logic of item dragging. If Multiple Instance, each dragged item can be used more than once.",
                    true);

            item.Add("Answer Choices Title", questionProperties.AnswerChoiceTitle, false, "Question",
                    @"Defines the title above the list of choices ",
                    true);
            item.Add("Tree Structure Title", questionProperties.TreeStructureTitle, false, "Question",
                   @"Defines the title above the tree structure ",
                   true);

            return item;
        }

        private static CustomPropertyCollection GetBuildListItems(Question question, Control container)
        {
            var typedQuestion = (BuildListAndReorderQuestion)question;

            var questionProperties = typedQuestion.Properties;
            var item = new CustomPropertyCollection
                {
                    {
                        "Complexity", questionProperties.Complexity, false, "Question",
                        @"Defines the complexity level of a question. The minimum complexity level is 1, 
                     the maximum complexity level is 10. This property is used to weight questions based on difficulty "
                        , true
                    }
                };
            var exam = ExamManager.GetInstance().GetSelectedExam();
            var sectionNames = exam.Sections;

            item.Add("Sections", questionProperties.Section, false, "Question",
                    @"Defines the number of choices the candidate can select when answering the question(one or several). ",
                    true);
            item[item.Count - 1].Datasource = sectionNames;
            item[item.Count - 1].IsDropdownResizable = true;

            item.Add("Exhibits", question.Exhibits.Count == 0 ? "empty" : "(collection)", false, "Question",
                    @"The collection of exhibits associated with this question. ",
                    true);

            item[item.Count - 1].OnClick += (sender, args) =>
            {
                var customPropertyDescriptor = (CustomProperty.CustomPropertyDescriptor)sender;
                var exhibit = new ExhibitsView((CustomProperty)customPropertyDescriptor.CustomProperty, container);
                exhibit.Show(container);
                return question.Exhibits.Count == 0 ? "empty" : "(collection)";
            };

            item.Add("Reorder Only", questionProperties.ReorderOnly, false, "Question",
                    @"Defines the question subtype. If True, the question requires only reordering the given list of choices",
                    true);

            item.Add("Order Is Important", questionProperties.OrderIsImportant, false, "Question",
                    @"Defines whether the order of the choices should be taken into consideration when estimating the candidate's score.",
                    true);

            item.Add("Answer Choices Title", questionProperties.AnswerChoiceTitle, false, "Question",
                    @"Defines the title above the list of choices ",
                    true);

            item.Add("Order List Title", questionProperties.OrderListTitle, false, "Question",
                 @"Defines the title above the ordered list ",
                 true);

            return item;
        }

        private static CustomPropertyCollection GetDropAndConnectItems(Question question, Control container)
        {
            var typedQuestion = (DropAndConnectQuestion)question;

            var questionProperties = typedQuestion.Properties;
            var item = new CustomPropertyCollection
                {
                    {
                        "Complexity", questionProperties.Complexity, false, "Question",
                        @"Defines the complexity level of a question. The minimum complexity level is 1, 
                     the maximum complexity level is 10. This property is used to weight questions based on difficulty "
                        , true
                    }
                };
            var exam = ExamManager.GetInstance().GetSelectedExam();
            var sectionNames = exam.Sections;

            item.Add("Sections", questionProperties.Section, false, "Question",
                    @"Defines the number of choices the candidate can select when answering the question(one or several). ",
                    true);
            item[item.Count - 1].Datasource = sectionNames;
            item[item.Count - 1].IsDropdownResizable = true;

            item.Add("Exhibits", question.Exhibits.Count == 0 ? "empty" : "(collection)", false, "Question",
                    @"The collection of exhibits associated with this question. ",
                    true);

            item[item.Count - 1].OnClick += (sender, args) =>
            {
                var customPropertyDescriptor = (CustomProperty.CustomPropertyDescriptor)sender;
                var exhibit = new ExhibitsView((CustomProperty)customPropertyDescriptor.CustomProperty, container);
                exhibit.Show(container);
                return question.Exhibits.Count == 0 ? "empty" : "(collection)";
            };

            item.Add("Connectors", questionProperties.Connectors.Count == 0 ? "empty" : "(collection)", false, "Question",
                   @"The collection of connectors used for creating relationships between objects. ",
                   true);
            item[item.Count - 1].OnClick += (sender, args) =>
                {
                    var exhibit = new ConnectorsView(question);
                    exhibit.Show(container);
                  
                    return question.Exhibits.Count == 0 ? "empty" : "(collection)";
                };

            item.Add("Objects", questionProperties.Objects.Count == 0 ? "empty" : "(collection)", false, "Question",
                   @"The collection of objects between which this relationships should be established. ",
                   true);

            item[item.Count - 1].OnClick += (sender, args) =>
            {
                var exhibit = new ObjectView(question);
                exhibit.Show(container);
                return question.Exhibits.Count == 0 ? "empty" : "(collection)";
            };


            item.Add("Connectors Title", questionProperties.ConnectorsTitle, false, "Question",
                 @"Defines the caption of the window that contains the list of connectors ",
                 true);

            item.Add("Width", questionProperties.Width, false, "Object",
                 @"Defines the object width in pixels ",
                 true);

            item.Add("Height", questionProperties.Height, false, "Object",
                 @"Defines the object height in pixels ",
                 true);
            return item;
        }

        private static CustomPropertyCollection GetDefaultChoicesItems()
        {
            var item = new CustomPropertyCollection
                {
                    {"test property", 132, false, "Question", "this is just a test int property", true},
                    {"test property", false, false, "Choice", "this is just a test bool property", true}
                };

            return item;
        }
    }
}
