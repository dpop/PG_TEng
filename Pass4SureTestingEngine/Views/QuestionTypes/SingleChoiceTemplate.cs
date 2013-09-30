using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Pass4SureTestingEngine.Extensions;
using Pass4SureTestingEngine.Logic;
using Pass4SureTestingEngine.Models.QuestionTypes;

namespace Pass4SureTestingEngine.Views.QuestionTypes
{
    public partial class SingleChoiceTemplate : Form
    {
        private readonly SingleChoiceQuestion _question;

        public SingleChoiceTemplate()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            _question = (SingleChoiceQuestion)ExamManager.GetInstance().GetSelectedQuestion();

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
            foreach (var answer in _question.AvailableAnswers)
            {
                /*copy container */

                var answerItemContainer = pnlAnswerItemContainer.Clone();
                answerItemContainer.Name = string.Format("answerItemContainer{0}", index);
                answerItemContainer.Tag = index;
                answerItemContainer.Visible = true;

                /* initialize check box*/
                var answerCb = btnChoice1.Clone();
                answerCb.Text = answer.Letter.ToString(CultureInfo.InvariantCulture);
                answerCb.Visible = true;
                answerCb.Name = string.Format("answerRadioButton{0}", index);
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
        }

        private void AnswerTextChanged(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;
            var size = TextRenderer.MeasureText(textbox.Text, textbox.Font);
            textbox.Height = size.Height + textbox.Margin.Top + textbox.Margin.Bottom + textbox.Padding.Top + textbox.Padding.Bottom;
            var index = (int)textbox.Parent.Tag;
            _question.AvailableAnswers[index].AnswerText = textbox.Text;

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
            var radiobutton = (RadioButton)sender;

            //deselect all other radio buttons
            if (radiobutton.Checked)
            {
                for (var answerIndex = 0; answerIndex < _question.AvailableAnswers.Count; answerIndex++ )
                {
                    if (answerIndex != (int)radiobutton.Parent.Tag)
                    {
                        var rbOtherName = string.Format("answerRadioButton{0}", answerIndex);
                        var rbOther = (RadioButton)pnlAnswerContainer.Controls.Find(rbOtherName, true)[0];
                        rbOther.Checked = false;
                    }
                }

                var index = (int)radiobutton.Parent.Tag;
                _question.CorrectAnswer = _question.AvailableAnswers[index];
            }
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
            foreach (var answer in _question.AvailableAnswers)
            {
                /*copy container */

                /* initialize radio button*/
                var answerRadioButtonName = string.Format("previewAnswerRadioButton{0}", index);
                var answerRb = (RadioButton) pnlPreviewAnswerContainer.Controls.Find(answerRadioButtonName, true)[0];
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
            foreach (var answer in _question.AvailableAnswers)
            {
                var answerRadioButtonName = string.Format("previewAnswerRadioButton{0}", index);
                var radiobutton = pnlPreviewAnswerContainer.Controls.Find(answerRadioButtonName, true)[0];
                var answerLabelName = string.Format("previewAnswerText{0}", index);
                var answerLbl = (Label)pnlPreviewAnswerContainer.Controls.Find(answerLabelName, true)[0];
                var isCorrect = answer.IsCorrect(_question.CorrectAnswer);
             //   radiobutton.Enabled = false;
                radiobutton.ForeColor = isCorrect ? Color.Green : Color.DarkRed;
             //   answerLbl.Enabled = false;
                answerLbl.ForeColor = isCorrect ? Color.Green : Color.DarkRed;
                index++;
            }

            pnlPreviewAnswerDetails.Visible = true;
        }

        private void ChangePreviewSelectedAnswer(object sender, EventArgs e)
        {
            var radiobutton = (RadioButton)sender;

            //deselect all other radio buttons
            if (radiobutton.Checked)
            {
                for (var answerIndex = 0; answerIndex < _question.AvailableAnswers.Count; answerIndex++)
                {
                    if (answerIndex != (int)radiobutton.Parent.Tag)
                    {
                        var rbOtherName = string.Format("previewAnswerRadioButton{0}", answerIndex);
                        var rbOther = (RadioButton)pnlPreviewAnswerContainer.Controls.Find(rbOtherName, true)[0];
                        rbOther.Checked = false;
                    }
                }
            }
        }

        private void InitializePreview()
        {
            var itemIndex = ExamManager.GetInstance().GetSelectedExam().Questions.IndexOf(_question);
            var count = ExamManager.GetInstance().GetSelectedExam().Questions.Count;

            lblItemPaging.Text = string.Format(lblItemPaging.Text, itemIndex + 1, count);
            rtbPreviewDescription.Rtf = _question.Description;

            var index = 0;
            pnlPreviewAnswerContainer.Controls.Clear();
            foreach (var answer in _question.AvailableAnswers)
            {
                /*copy container */
                var answerItemContainer = pnlAnswerItemContainer.Clone();
                answerItemContainer.Name = string.Format("answerPreviewItemContainer{0}", index);
                answerItemContainer.Tag = index;
                answerItemContainer.BackColor = SystemColors.Window;
                answerItemContainer.Visible = true;

                /* initialize radio button*/
                var answerRb = rbPreviewAnswerItemTemplate.Clone();
                answerRb.BackColor = SystemColors.Window;
                answerRb.Text = answer.Letter.ToString(CultureInfo.InvariantCulture);
                answerRb.Visible = true;
                answerRb.Name = string.Format("previewAnswerRadioButton{0}", index);
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

        private void SingleChoiceTemplate_Load(object sender, EventArgs e)
        { 
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
