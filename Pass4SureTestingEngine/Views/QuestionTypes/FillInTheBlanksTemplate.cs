using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Pass4SureTestingEngine.Logic;
using Pass4SureTestingEngine.Models.AnswerModels;
using Pass4SureTestingEngine.Models.QuestionTypes;
using Pass4SureTestingEngine.Extensions;
using Pass4SureTestingEngine.Properties;

namespace Pass4SureTestingEngine.Views.QuestionTypes
{
    public partial class FillInTheBlanksTemplate : Form
    {
        private FillInTheBlanksQuestion _question;
        private FillInTheBlanksAnswer _answer;
        public FillInTheBlanksTemplate()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            _question = (FillInTheBlanksQuestion) ExamManager.GetInstance().GetSelectedQuestion();
            _answer =_question.CorrectAnswer;
            rtbQuestionDescription.MakeResizeable();
            rtbExplanation.MakeResizeable();
            InitQuestionBuildArea();
            InitQuestionPreviewArea();

        }

        #region Build Question
        private void InitQuestionBuildArea()
        {
            rtbQuestionDescription.Rtf = _question.Description;
            tbCorrectAnswer.Text = _answer.Answer;
            rtbExplanation.Text = string.Empty;
        }

        private void DescriptionTextChanged(object sender, EventArgs e)
        {
            _question.Description = rtbQuestionDescription.Rtf;
        }

        private void ExplanationTextChanged(object sender, EventArgs e)
        {
            _question.AnswerAdditionalInfo = rtbExplanation.Rtf;
        }

        private void CorrectAnswerTextChanged(object sender, EventArgs e)
        {
            _answer.Answer = tbCorrectAnswer.Text;
            _question.CorrectAnswer = _answer;
        }
        #endregion


        #region Question Preview
        private void InitQuestionPreviewArea()
        {
            var itemIndex = ExamManager.GetInstance().GetSelectedExam().Questions.IndexOf(_question);
            var count = ExamManager.GetInstance().GetSelectedExam().Questions.Count;

            lblItemPaging.Text = string.Format(lblItemPaging.Text, itemIndex + 1, count);
            rtbPreviewDescription.Rtf = _question.Description;
            rtbPreviewAnswer.Rtf = _question.AnswerAdditionalInfo;
            rtbPreviewDescription.MakeResizeable();
        }


        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            if (btnShowAnswer.Text.Contains("Show"))
            {
                tbPreviewCorrectAnswer.Enabled = false;
                pnlPreviewAnswerDetails.Visible = true;
                btnShowAnswer.Text = Resources.HideAnswerButtonText;
            }
            else
            {
                tbPreviewCorrectAnswer.Enabled = true;
                pnlPreviewAnswerDetails.Visible = false;
                btnShowAnswer.Text = Resources.ShowAnswerButtonText;
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

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            InitQuestionPreviewArea();
        }
    }
}
