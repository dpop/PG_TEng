using System;
using System.Windows.Forms;
using Pass4SureTestingEngine.Logic;
using Pass4SureTestingEngine.Logic.Filters;
using Pass4SureTestingEngine.Models;
using Pass4SureTestingEngine.ViewEngines;

namespace Pass4SureTestingEngine.Views
{
    public partial class MoveToView : Form
    {
        private Question _question;
        private Exam _exam;
        private ViewManager _viewManager;

        public MoveToView(Question question, Exam originExam, ViewManager viewManager)
        {
            InitializeComponent();

            _question = question;
            _exam = originExam;
            _viewManager = viewManager;
            PopulateDropdowns();
        }

        private void MoveToView_Load(object sender, EventArgs e)
        {

        }

        private void PopulateDropdowns()
        {
            var exams = ExamManager.GetInstance().ExamBook.Exams;

            foreach (var exam in exams)
            {
                cbExams.Items.Add(exam);
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            var destinationExam = ExamManager.GetInstance().GetExam(new ExamFilter { ExamIndex = cbExams.SelectedIndex });

            _exam.Questions.Remove(_question);

            destinationExam.Questions.Add(_question);

            _viewManager.RefreshExplorer();
            Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
