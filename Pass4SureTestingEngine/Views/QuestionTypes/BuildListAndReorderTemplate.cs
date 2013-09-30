using System.Windows.Forms;
using Pass4SureTestingEngine.Logic;
using Pass4SureTestingEngine.Extensions;
using Pass4SureTestingEngine.Models.QuestionTypes;

namespace Pass4SureTestingEngine.Views.QuestionTypes
{
    public partial class BuildListAndReorderTemplate : Form
    {
        private BuildListAndReorderQuestion _question;

        public BuildListAndReorderTemplate()
        {
            InitializeComponent();
            _question = (BuildListAndReorderQuestion) ExamManager.GetInstance().GetSelectedQuestion();
            rtbQuestionDescription.MakeResizeable();
            rtbQuestionExplanation.MakeResizeable();
        }
    }
}
