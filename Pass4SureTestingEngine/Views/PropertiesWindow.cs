using System;
using System.Drawing;
using System.Windows.Forms;
using Pass4SureTestingEngine.Enumerables;
using Pass4SureTestingEngine.Logic;
using Pass4SureTestingEngine.Models.QuestionTypes;
using Pass4SureTestingEngine.Utils;
using Pass4SureTestingEngine.ViewEngines;
using WeifenLuo.WinFormsUI.Docking;

namespace Pass4SureTestingEngine.Views
{
    public partial class PropertiesWindow : DockContent
    {
        private readonly ViewManager _viewManager;
        public PropertiesWindow(ViewManager viewManager)
        {
            InitializeComponent();

            _viewManager = viewManager;
        }

        protected override void WndProc(ref Message message)
        {
            const int wmSyscommand = 0x0112;
            const int scMove = 0xF010;

            switch(message.Msg)
            {
                case wmSyscommand:
                   int command = message.WParam.ToInt32() & 0xfff0;
                   if (command == scMove)
                      return;
                   break;
            }

            base.WndProc(ref message);
        }

        private void PropertiesWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void pgxPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            

            var currentQuestion = ExamManager.GetInstance().GetSelectedQuestion();
            var refreshRequired = false;
            switch (QuestionHelper.GetTypeFromQuestion(currentQuestion))
            {
                case QuestionType.SingleChoice:
                    refreshRequired = UpdateSingleChoiceProperties((SingleChoiceQuestion)currentQuestion, e.ChangedItem);
                    break;
                case QuestionType.MultipleChoice:
                    refreshRequired = UpdateMultipleChoiceProperties((MultipleChoiceQuestion)currentQuestion, e.ChangedItem);
                    break;
                case QuestionType.FillInTheBlanks:
                    refreshRequired = UpdateFillInTheBlanksProperties((FillInTheBlanksQuestion) currentQuestion,
                                                                      e.ChangedItem);
                    break;
                case QuestionType.DragAndDrop:
                    refreshRequired = UpdateDragAndDropProperties((DragAndDropQuestion) currentQuestion, e.ChangedItem);
                    break;
                case QuestionType.HotArea:
                    refreshRequired = UpdateHotAreaProperties((HotAreaQuestion)currentQuestion, e.ChangedItem);
                    break;
                case QuestionType.PointAndShoot:
                    refreshRequired = UpdatePointAndShootProperties((PointAndShootQuestion)currentQuestion, e.ChangedItem);
                    break;
                case QuestionType.BuildListAndReorder:
                    refreshRequired = UpdateBuildListAndReodredProperties((BuildListAndReorderQuestion)currentQuestion, e.ChangedItem);
                    break;
                case QuestionType.CreateATree:
                    refreshRequired = UpdateCreateTreeProperties((CreateATreeQuestion)currentQuestion, e.ChangedItem);
                    break;
                case QuestionType.DropAndConnect:
                    refreshRequired = UpdateDropAndConnectProperties((DropAndConnectQuestion)currentQuestion, e.ChangedItem);
                    break;
            }

            if (refreshRequired)
            {
                _viewManager.RefreshQuestionContent(currentQuestion);
            }


        }

        private bool UpdateSingleChoiceProperties(SingleChoiceQuestion question, GridItem changedItem)
        {
            var refreshRequired = false;
            switch (changedItem.Label)
            {
                case "Allow Shuffle Choices":
                    question.Properties.AllowShuffleChoice = (bool) changedItem.Value;
                    break;
                case "Last Choice Letter":
                    question.Properties.LastChoiceLetter = (char) changedItem.Value;
                    refreshRequired = true;
                    break;
                case "Number of Choices":
                    question.Properties.NumberOfChoices = (int)changedItem.Value;
                    refreshRequired = true;
                    break;
                case "Answer Type":
                    question.Properties.AnswerType = (AnswerType)changedItem.Value;
                    refreshRequired = true;
                    break;
                case "Complexity":
                    question.Properties.Complexity = (int)changedItem.Value;
                    break;
                case "Section":
                    question.Properties.Section = (string)changedItem.Value;
                    break;
            }

            return refreshRequired;
        }

        private bool UpdateMultipleChoiceProperties(MultipleChoiceQuestion question, GridItem changedItem)
        {
            var refreshRequired = false;
            switch (changedItem.Label)
            {
                case "Allow Shuffle Choices":
                    question.Properties.AllowShuffleChoice = (bool)changedItem.Value;
                    break;
                case "Check Number of Selected":
                    question.Properties.CheckNumberOfSelected = (bool)changedItem.Value;
                    break;
                case "Last Choice Letter":
                    question.Properties.LastChoiceLetter = (char)changedItem.Value;
                    refreshRequired = true;
                    break;
                case "Number of Choices":
                    question.Properties.NumberOfChoices = (int)changedItem.Value;
                    refreshRequired = true;
                    break;
                case "Answer Type":
                    question.Properties.AnswerType = (AnswerType)changedItem.Value;
                    refreshRequired = true;
                    break;
                case "Complexity":
                    question.Properties.Complexity = (int)changedItem.Value;
                    break;
                case "Section":
                    question.Properties.Section = (string)changedItem.Value;
                    break;

            }

            return refreshRequired;
        }

        private bool UpdateFillInTheBlanksProperties(FillInTheBlanksQuestion question, GridItem changedItem)
        {
            switch (changedItem.Label)
            {
                case "Case Sensitive":
                    question.Properties.CaseSensitive = (bool)changedItem.Value;
                    break;
                case "Ignore Multiple Spaces":
                    question.Properties.IgnoreMultipleSpaces = (bool)changedItem.Value;
                    break;
                case "Trim Candidate's Response":
                    question.Properties.TrimCandidateResponse = (bool)changedItem.Value;
                    break;
                case "Number of Answers":
                    question.Properties.NumberOfAnswers = (int)changedItem.Value;
                    break;
                case "Complexity":
                    question.Properties.Complexity = (int)changedItem.Value;
                    break;
                case "Section":
                    question.Properties.Section = (string)changedItem.Value;
                    break;
            }

            return false;
        }

        private bool UpdateDragAndDropProperties(DragAndDropQuestion question, GridItem changedItem)
        {
            var refreshRequired = false;
            switch (changedItem.Label)
            {
                case "Background Image":
                    question.Properties.BackgroundImage = (Image)changedItem.Value;
                    refreshRequired = true;
                    break;       
                case "Drag Type":
                    question.Properties.DragType = (DragType)changedItem.Value;
                    refreshRequired = true;
                    break;
                case "Complexity":
                    question.Properties.Complexity = (int)changedItem.Value;
                    break;
                case "Section":
                    question.Properties.Section = (string)changedItem.Value;
                    break;
            }

            return refreshRequired;
        }

        private bool UpdateHotAreaProperties(HotAreaQuestion question, GridItem changedItem)
        {
            var refreshRequired = false;
            switch (changedItem.Label)
            {
                case "Background Image":
                    question.Properties.BackgroundImage = (Image)changedItem.Value;
                    refreshRequired = true;
                    break;
                case "Complexity":
                    question.Properties.Complexity = (int)changedItem.Value;
                    break;
                case "Section":
                    question.Properties.Section = (string)changedItem.Value;
                    break;
            }

            return refreshRequired;
        }

        private bool UpdatePointAndShootProperties(PointAndShootQuestion question, GridItem changedItem)
        {
            var refreshRequired = false;
            switch (changedItem.Label)
            {
                case "Background Image":
                    question.Properties.BackgroundImage = (Image)changedItem.Value;
                    refreshRequired = true;
                    break;
                case "Complexity":
                    question.Properties.Complexity = (int)changedItem.Value;
                    break;
                case "Section":
                    question.Properties.Section = (string)changedItem.Value;
                    break;
            }

            return refreshRequired;
        }

        private bool UpdateBuildListAndReodredProperties(BuildListAndReorderQuestion question, GridItem changedItem)
        {
            var refreshRequired = false;
            switch (changedItem.Label)
            {
                case "Answer Choices Title":
                    question.Properties.AnswerChoiceTitle = (string)changedItem.Value;
                    refreshRequired = true;
                    break;
                case "Order List Title":
                    question.Properties.OrderListTitle = (string)changedItem.Value;
                    refreshRequired = true;
                    break;
                case "Section":
                    question.Properties.Section = (string)changedItem.Value;
                    break;
                case "Complexity":
                    question.Properties.Complexity = (int)changedItem.Value;
                    break;
                case "Order Is Important":
                    question.Properties.OrderIsImportant = (bool) changedItem.Value;
                    break;
                case "Reorder Only":
                    question.Properties.ReorderOnly = (bool) changedItem.Value;
                    refreshRequired = true;
                    break;
            }

            return refreshRequired;
        }

        private bool UpdateCreateTreeProperties(CreateATreeQuestion question, GridItem changedItem)
        {
            var refreshRequired = false;
            switch (changedItem.Label)
            {
                case "Answer Choices Title":
                    question.Properties.AnswerChoiceTitle = (string)changedItem.Value;
                    refreshRequired = true;
                    break;
                case "Drag Type":
                    question.Properties.DragType = (DragType)changedItem.Value;
                    break;
                case "Section":
                    question.Properties.Section = (string)changedItem.Value;
                    break;
                case "Complexity":
                    question.Properties.Complexity = (int)changedItem.Value;
                    break;
                case "Tree Structure Title":
                    question.Properties.TreeStructureTitle = (string)changedItem.Value;
                    refreshRequired = true;
                    break;
            }

            return refreshRequired;
        }

        private bool UpdateDropAndConnectProperties(DropAndConnectQuestion question, GridItem changedItem)
        {
            var refreshRequired = false;
            switch (changedItem.Label)
            {
                case "Connectors Title":
                    question.Properties.ConnectorsTitle = (string)changedItem.Value;
                    refreshRequired = true;
                    break;
                case "Height":
                    question.Properties.Height = (double)changedItem.Value;
                    refreshRequired = true;
                    break;
                case "Width":
                    question.Properties.Width = (double)changedItem.Value;
                    refreshRequired = true;
                    break;
                case "Complexity":
                    question.Properties.Complexity = (int)changedItem.Value;
                    break;
                case "Section":
                    question.Properties.Section = (string)changedItem.Value;
                    break;
            }

            return refreshRequired;
        }

        private void pgxPropertyGrid_SelectedGridItemChanged(object sender, SelectedGridItemChangedEventArgs e)
        {
            //MessageBox.Show(e.NewSelection.Label);
        }
    }
}
