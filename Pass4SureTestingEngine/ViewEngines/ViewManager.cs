using System.Linq;
using System.Windows.Forms;
using Pass4SureTestingEngine.Enumerables;
using Pass4SureTestingEngine.Logic;
using Pass4SureTestingEngine.Models;
using Pass4SureTestingEngine.Utils;
using Pass4SureTestingEngine.ViewEngines.ViewEngineImplementation;
using Pass4SureTestingEngine.Views;

namespace Pass4SureTestingEngine.ViewEngines
{
    public class ViewManager
    {
        private readonly Form1 _mainForm;
        private PropertiesWindow _propertiesWindow;
        private ExamExplorer _examExplorer;


        public ViewManager(Form1 form)
        {
            _mainForm = form;
        }

        public void RefreshQuestionProperties(Question selectedQuestion)
        {
            var engine = GetViewEngine(selectedQuestion);
            engine.UpdateProperties(_propertiesWindow, selectedQuestion);
        }

        public void RefreshQuestionContent(Question selectedQuestion)
        {
            var engine = GetViewEngine(selectedQuestion);
            engine.UpdateContent(_mainForm.Controls.Find(Constants.ContentContainerName, true).FirstOrDefault(), selectedQuestion);
        }

        public void RefreshExplorer()
        {
            _examExplorer.RefreshTreeView(ExamManager.GetInstance().ExamBook);
        }

        public void RefreshExamProperties(Exam exam)
        {
            var propertiesBox = _propertiesWindow.Controls[0] as PropertyGridEx.PropertyGridEx ?? new PropertyGridEx.PropertyGridEx();

            propertiesBox.Item.Clear();

            propertiesBox.Refresh();
        }

        public void RefreshExamContent(Exam exam)
        {
            var template = new ÈxamTemplate();

            var container = _mainForm.Controls.Find(Constants.ContentContainerName, true).FirstOrDefault();

            if (container != null)
            {
                container.Controls.Clear();

                container.Controls.Add(template.Controls[0]);
            }
        }

        public void RefreshExamBookProperties(ExamBook examBook)
        {
            var propertiesBox = _propertiesWindow.Controls[0] as PropertyGridEx.PropertyGridEx ?? new PropertyGridEx.PropertyGridEx();

            propertiesBox.Item.Clear();

            propertiesBox.Refresh();
        }

        public void RefreshExamBookContent(ExamBook examBook)
        {
            var template = new ExamBookTemplate();

            var container = _mainForm.Controls.Find(Constants.ContentContainerName, true).FirstOrDefault();

            if (container != null)
            {
                container.Controls.Clear();

                container.Controls.Add(template.Controls[0]);
            }
        }

        #region Initialization

        public void InitWindows(Panel container)
        {
            var examExplorer = new ExamExplorer(this);
            var examExplorerContainer = (Panel)container.Controls.Find("pnlExplorer", true).FirstOrDefault();
            examExplorer.TopLevel = false;
            examExplorer.AutoScroll = true;
            examExplorer.Dock = DockStyle.Fill;
            examExplorer.MinimizeBox = false;
            examExplorer.MaximizeBox = false;
            examExplorer.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            examExplorerContainer.Controls.Add(examExplorer);
            examExplorer.Show();
            _examExplorer = examExplorer;

            var propertiesWindow = new PropertiesWindow(this);
            var propertiesWindowContainer = (Panel)container.Controls.Find("pnlProperties", true).FirstOrDefault();
            propertiesWindow.TopLevel = false;
            propertiesWindow.AutoScroll = true;
            propertiesWindow.MaximizeBox = false;
            propertiesWindow.MinimizeBox = false;
            propertiesWindow.Dock = DockStyle.Fill;
            propertiesWindow.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            propertiesWindowContainer.Controls.Add(propertiesWindow);
            propertiesWindow.Show();
            _propertiesWindow = propertiesWindow;

            RefreshExplorer();
        }

        #endregion

        private IViewEngine GetViewEngine(Question question)
        {
            IViewEngine engine;
            switch (QuestionHelper.GetTypeFromQuestion(question))
            {
                case QuestionType.SingleChoice:
                    engine = new SingleChoiceViewEngine();
                    break;
                case QuestionType.MultipleChoice:
                    engine = new MultipleChoiceViewEngine();
                    break;
                case QuestionType.FillInTheBlanks:
                    engine = new FillInTheBlanksViewEngine();
                    break;
                case QuestionType.DragAndDrop:
                    engine = new DragAndDropViewEngine();
                    break;
                case QuestionType.PointAndShoot:
                    engine = new PointAndShootViewEngine();
                    break;
                case QuestionType.HotArea:
                    engine = new HotAreaViewEngine();
                    break;
                case QuestionType.CreateATree:
                    engine = new CreateATreeViewEngine();
                    break;
                case QuestionType.BuildListAndReorder:
                    engine = new BuildListAndReorderViewEngine();
                    break;
                case QuestionType.DropAndConnect:
                    engine = new DropAndConnectViewEngine();
                    break;
                default:
                    engine = new SingleChoiceViewEngine();
                    break;
            }

            return engine;
        }
    }
}
