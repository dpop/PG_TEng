using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Pass4SureTestingEngine.Extensions;
using Pass4SureTestingEngine.Logic;
using Pass4SureTestingEngine.Models.AnswerModels;
using System.Linq;
using Pass4SureTestingEngine.Models.AnswerModels.MultipleChoice;
using Pass4SureTestingEngine.Models.QuestionTypes;

namespace Pass4SureTestingEngine.Views.QuestionTypes
{
    public partial class MultipleChoiceTemplate : Form
    {

        private readonly MultipleChoiceQuestion _question;
        private MultipleChoiceAnswer _answer;

        public MultipleChoiceTemplate()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            _question = (MultipleChoiceQuestion)ExamManager.GetInstance().GetSelectedQuestion();

            InitializeNewQuestion();

            InitializePreview();
             rtbPreviewDescription.MakeResizeable();
        }



        #region Question Build

        private void DescriptionChanged(object sender, EventArgs e)
        {
            rtbQuestionText.MakeResizeable();
            _question.Description = rtbQuestionText.Rtf;
        }

        private void InitializeNewQuestion()
        {
            rtbQuestionText.Rtf = _question.Description;

            var index = 0;
            foreach (var answer in _question.AvailableAnswer.GetAnswers())
            {
                /*copy container */

                var answerItemContainer = pnlAnswerItemContainer.Clone();
                answerItemContainer.Name = string.Format("answerItemContainer{0}", index);
                answerItemContainer.Tag = index;
                answerItemContainer.Visible = true;

                /* initialize check box*/
                var answerCb = cbAnswerItemTemplate.Clone();
                answerCb.Text = answer.Letter.ToString(CultureInfo.InvariantCulture);
                answerCb.Visible = true;
                answerCb.Name = string.Format("answerCheckBox{0}", index);
                //select the first answer
                if (index == 0)
                {
                    answerCb.Checked = true;
                }
                answerCb.CheckedChanged += ChangeSelectedAnswer;
                answerItemContainer.Controls.Add(answerCb);

                /* initialize text box*/
                var answerTb = tbAnswerText1.Clone();
                answerTb.Text = answer.AnswerText;
                answerTb.Name = string.Format("answerTextBox{0}", index);
                answerTb.Visible = true;
                answerTb.TextChanged += AnswerTextChanged;
                answerItemContainer.Controls.Add(answerTb);
                pnlAnswerContainer.Controls.Add(answerItemContainer);
                answerItemContainer.BringToFront();
                index++;
            }

            _answer = _question.CorrectAnswer as MultipleChoiceAnswer;
        }

        private void AnswerTextChanged(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;
            var size = TextRenderer.MeasureText(textbox.Text, textbox.Font);
            textbox.Height = size.Height + textbox.Margin.Top + textbox.Margin.Bottom + textbox.Padding.Top + textbox.Padding.Bottom;
            var index = (int)textbox.Parent.Tag;
            var currentAnswer = _question.AvailableAnswer.GetAnswer(index);
            currentAnswer.AnswerText = textbox.Text;
            _question.AvailableAnswer.UpdateItem(index, currentAnswer);

        }

        private void AdditionaInfoTextChange(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;
            var size = TextRenderer.MeasureText(textbox.Text, textbox.Font);
            textbox.Height = size.Height + textbox.Margin.Top + textbox.Margin.Bottom + textbox.Padding.Top + textbox.Padding.Bottom;
            _question.AnswerAdditionalInfo = tbAditionalInfo.Text;
        }

        private void ChangeSelectedAnswer(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;

            var index = (int)checkBox.Parent.Tag;
            var selectedAnswer = _question.AvailableAnswer.GetAnswer(index);
            if (checkBox.Checked)
            {
                _answer.AddAnswer(selectedAnswer);
            }
            else
            {
                _answer.RemoveAnswer(selectedAnswer);
            }

            _question.CorrectAnswer = _answer;

        }

        #endregion

        #region Question Preview

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            PopulatePreview();
        }

        private void PopulatePreview()
        {
            rtbPreviewDescription.Rtf = _question.Description;
            var index = 0;
            foreach (var answer in _question.AvailableAnswer.GetAnswers())
            {
                /*copy container */

                /* initialize radio button*/
                var answerCheckBoxName = string.Format("previewAnswerCheckBox{0}", index);
                var answerRb = (CheckBox)pnlPreviewAnswerContainer.Controls.Find(answerCheckBoxName, true)[0];
                //select the first answer
                if (index == 0)
                {
                    answerRb.Checked = true;
                }

                /* initialize label*/
                var answerLabelName = string.Format("previewAnswerText{0}", index);
                var answerLbl = (Label)pnlPreviewAnswerContainer.Controls.Find(answerLabelName, true)[0];
                answerLbl.Text = answer.AnswerText;

                index++;
            }

            lblPreviewAditionalInfo.Text = _question.AnswerAdditionalInfo;
        }


        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            // get all radio buttons 
            var index = 0;
            foreach (var answer in _question.AvailableAnswer.GetAnswers())
            {
                var answerCheckBoxName = string.Format("previewAnswerCheckBox{0}", index);
                var checkBox = pnlPreviewAnswerContainer.Controls.Find(answerCheckBoxName, true)[0];
                var answerLabelName = string.Format("previewAnswerText{0}", index);
                var answerLbl = (Label)pnlPreviewAnswerContainer.Controls.Find(answerLabelName, true)[0];
                var isCorrect = _answer.GetAnswers().Any(x => x.IsCorrect(answer));
                //   radiobutton.Enabled = false;
                checkBox.ForeColor = isCorrect ? Color.Green : Color.DarkRed;
                //   answerLbl.Enabled = false;
                answerLbl.ForeColor = isCorrect ? Color.Green : Color.DarkRed;
                index++;
            }

            pnlPreviewAnswerDetails.Visible = true;
        }

        private void ChangePreviewSelectedAnswer(object sender, EventArgs e)
        {
        }

        private void InitializePreview()
        {
            var itemIndex = ExamManager.GetInstance().GetSelectedExam().Questions.IndexOf(_question);
            var count = ExamManager.GetInstance().GetSelectedExam().Questions.Count;

            lblItemPaging.Text = string.Format(lblItemPaging.Text, itemIndex + 1, count);
            rtbPreviewDescription.Rtf = _question.Description;

            var index = 0;
            pnlPreviewAnswerContainer.Controls.Clear();
            foreach (var answer in _question.AvailableAnswer.GetAnswers())
            {
                /*copy container */
                var answerItemContainer = pnlAnswerItemContainer.Clone();
                answerItemContainer.Name = string.Format("answerPreviewItemContainer{0}", index);
                answerItemContainer.Tag = index;
                answerItemContainer.BackColor = SystemColors.Window;
                answerItemContainer.Visible = true;

                /* initialize radio button*/
                var answerRb = cbPreviewAnswerItemTemplate.Clone();
                answerRb.BackColor = SystemColors.Window;
                answerRb.Text = answer.Letter.ToString(CultureInfo.InvariantCulture);
                answerRb.Visible = true;
                answerRb.Name = string.Format("previewAnswerCheckBox{0}", index);
                answerRb.CheckedChanged += ChangePreviewSelectedAnswer;
                answerItemContainer.Controls.Add(answerRb);

                /* initialize label*/
                var answerLbl = lblPreviewAnswerTextTemplate.Clone();
                answerLbl.BackColor = SystemColors.Window;
                answerLbl.Text = answer.AnswerText;
                answerLbl.Name = string.Format("previewAnswerText{0}", index);
                answerLbl.Visible = true;

                answerItemContainer.Controls.Add(answerLbl);

                pnlPreviewAnswerContainer.Controls.Add(answerItemContainer);
                answerItemContainer.BringToFront();
                index++;
            }
        }

        [DllImport("User32", CharSet = CharSet.Auto, ExactSpelling = true)]
        internal static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndParent);

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = System.Diagnostics.Process.Start("calc.exe");
            if (proc != null)
            {
                proc.WaitForInputIdle();
                SetParent(proc.MainWindowHandle, Handle);
            }
        }
        #endregion
    }
}
