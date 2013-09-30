using System;
using System.Linq;
using System.Windows.Forms;
using Pass4SureTestingEngine.Enumerables;
using Pass4SureTestingEngine.Logic;
using Pass4SureTestingEngine.Utils;
using Pass4SureTestingEngine.ViewEngines;

namespace Pass4SureTestingEngine.Views
{
    public partial class AddQuestionView : Form
    {

        private string _examName;
        private ViewManager _viewManager;

        public AddQuestionView(string examName, ViewManager viewManager)
        {
            _examName = examName;
            _viewManager = viewManager;
            
            InitializeComponent();
            groupBox1.Controls.OfType<RadioButton>().First().Checked = true;
        }

        private void AddQuestionView_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var checkedRadioButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);

            if (checkedRadioButton != null)
            {
                var checkedText = checkedRadioButton.Text;
                var questionType = GetTypeFromUserInput(checkedText);

                var emptyQuestion = QuestionHelper.GetQuestionFromType(questionType);

                ExamManager.GetInstance().AddQuestion(_examName , emptyQuestion);

                _viewManager.RefreshExplorer();
                Close();
            }

        }

        private QuestionType GetTypeFromUserInput(string typeName)
        {
            var questionType = QuestionType.SingleChoice;
            switch (typeName)
            {
                case "Multiple Choice":
                    questionType = QuestionType.MultipleChoice;
                    break;
                case "Fill in the blanks":
                    questionType = QuestionType.FillInTheBlanks;
                    break;
                case "Drag and Drop":
                    questionType = QuestionType.DragAndDrop;
                    break;
                case "Point and Shoot":
                    questionType = QuestionType.PointAndShoot;
                    break;
                case "Hot Area":
                    questionType = QuestionType.HotArea;
                    break;
                case "Create a Tree":
                    questionType = QuestionType.CreateATree;
                    break;
                case "Build list and Reorder":
                    questionType = QuestionType.BuildListAndReorder;
                    break;
                case "Drop and Connect":
                    questionType = QuestionType.DropAndConnect;
                    break;

            }
            return questionType;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
