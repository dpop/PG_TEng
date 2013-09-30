using System.Drawing;
using System.Globalization;
using System.Linq;
using Pass4SureTestingEngine.Enumerables;
using Pass4SureTestingEngine.Logic;
using Pass4SureTestingEngine.Logic.Filters;
using System;
using System.Windows.Forms;
using Pass4SureTestingEngine.Models;
using Pass4SureTestingEngine.Utils;
using Pass4SureTestingEngine.ViewEngines;
using WeifenLuo.WinFormsUI.Docking;

namespace Pass4SureTestingEngine.Views
{
    public partial class ExamExplorer : DockContent
    {
        private readonly ViewManager _viewManager;


        public ExamExplorer(    ViewManager viewManager)
        {
            _viewManager = viewManager;
            InitializeComponent();

            ToggleButtons(NodeType.Root);
        }


        public void RefreshTreeView(ExamBook examBook)
        {
            TreeNode selectedNode = null;
            if (treeView1.Nodes.Count > 0 && treeView1.SelectedNode != null)
            {
                selectedNode = treeView1.SelectedNode;
            }

            treeView1.Nodes.Clear();

            var root = new TreeNode(examBook.Title);

            foreach (var exam in examBook.Exams)
            {
                var examNode = new TreeNode(exam.ExamName);

                foreach (var question in exam.Questions)
                {
                    var questionNode = new TreeNode(string.Format("Question {0}", (exam.Questions.IndexOf(question) +1 ).ToString(CultureInfo.InvariantCulture)));
                    questionNode.Name = string.Format("{0}-{1}",exam.ExamName,questionNode.Text);
                    examNode.Nodes.Add(questionNode);
                }
                examNode.Name = examNode.Text;
                root.Nodes.Add(examNode);

            }
            root.Name = root.Text;
            treeView1.Nodes.Add(root);


            if (selectedNode != null)
            {
                var currentNode = treeView1.Nodes.Find(selectedNode.Name, true).FirstOrDefault();
                if (currentNode != default(TreeNode))
                {
                    treeView1.SelectedNode = currentNode;
                    treeView1.SelectedNode.Expand();

                    treeView1_AfterSelect(treeView1, new TreeViewEventArgs(currentNode));
                }

            }
        }
  
        private void ToggleButtons(NodeType selectedNodeType, TreeNode selectedNode = null)
        {
             btnNewExam.Enabled = false;
             btnNewQuestion.Enabled = false;
             btnMoveDown.Enabled = false;
             btnMoveUp.Enabled = false;

            if (selectedNodeType == NodeType.Root)
            {
                btnNewExam.Enabled = true;
            }
            else 
            {
                btnNewExam.Enabled = true;
                btnNewQuestion.Enabled = true;
                
                if (selectedNode != null && selectedNode.Parent.Nodes.Count > 1)
                {

                    btnMoveDown.Enabled = selectedNode.Parent.Nodes.IndexOf(selectedNode) < selectedNode.Parent.Nodes.Count - 1;
                    btnMoveUp.Enabled = selectedNode.Parent.Nodes.IndexOf(selectedNode) > 0;
                }
             
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AddQuestion();
        }

        private void ExamExplorer_Load(object sender, EventArgs e)
        {

        }

        protected override void WndProc(ref Message message)
        {
            const int wmSyscommand = 0x0112;
            const int scMove = 0xF010;

            switch (message.Msg)
            {
                case wmSyscommand:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == scMove)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
           
	        if (e.Button == MouseButtons.Right )
	        {
		        var p = new Point(e.X, e.Y);

		        TreeNode node= treeView1.GetNodeAt(p);
		        if (node != null)
		        {
		            treeView1.SelectedNode = node;
			        switch(node.Level)
			        {
				        case 0:
					        mnuRootContextMenu.Show(treeView1, p);
					        break;
                        case 1:
                            mnuExamContextMenu.Show(treeView1, p);
                            break;
				        case 2:
					        mnuQuestionContextMenu.Show(treeView1, p);
					        break;
			        }
		        }
	        }
        }

        private void btnNewExam_Click(object sender, EventArgs e)
        {
             ExamManager.GetInstance().AddExam(new Exam());

             _viewManager.RefreshExplorer();
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            MoveItem(Direction.Down);
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            MoveItem(Direction.Up);
        }

        private void MoveItem(Direction direction)
        {
            var selectedNode = treeView1.SelectedNode;

            var selectedNodeType = (NodeType)selectedNode.Level;
            if (selectedNodeType == NodeType.Question)
            {
                var examName = selectedNode.Parent.Name;

                var exam = ExamManager.GetInstance().GetExam(new ExamFilter { ExamName = examName });

                ExamManager.GetInstance().MoveQuestion(exam, exam.Questions[selectedNode.Index], direction);

                _viewManager.RefreshExplorer();


                treeView1.SelectedNode = direction == Direction.Up
                                             ? treeView1.SelectedNode.PrevNode
                                             : treeView1.SelectedNode.NextNode;

                treeView1.SelectedNode.Expand();

                treeView1_AfterSelect(treeView1, new TreeViewEventArgs(treeView1.SelectedNode));
            }
            else
            {
                var examName = selectedNode.Name;

                var exam = ExamManager.GetInstance().GetExam(new ExamFilter { ExamName = examName });

                ExamManager.GetInstance().MoveExam(exam,direction);

                _viewManager.RefreshExplorer();

              //  treeView1.SelectedNode = treeView1.Nodes[treeView1.SelectedNode.Index + 1];
            }
        }

        private void newExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExamManager.GetInstance().AddExam(new Exam());

            _viewManager.RefreshExplorer();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddQuestion();
        }

        private void AddQuestion()
        {
            var selectedNode = treeView1.SelectedNode;

            var selectedNodeType = (NodeType)selectedNode.Level;
            var examName = selectedNodeType == NodeType.Exam ? selectedNode.Text : selectedNode.Parent.Text;

            var newQuestionForm = new AddQuestionView(examName, _viewManager);
            newQuestionForm.Show(this);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MoveItem(Direction.Up);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MoveItem(Direction.Down);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            MoveItem(Direction.Up);
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            MoveItem(Direction.Down);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var selectedNode = treeView1.SelectedNode;

            var examName = selectedNode.Text;

            var exam = ExamManager.GetInstance().GetExam(new ExamFilter
                {
                    ExamName = examName
                });
            if (ExamManager.GetInstance().RemoveExam(exam))
            {
                ClipboardHelper.SetClipboardItem(exam, NodeType.Exam, ClipboardOperationType.Cut);
                _viewManager.RefreshExplorer();
                tsmiPasteExam.Enabled = true;
            }
         
        }

        private void tsmiPasteExam_Click(object sender, EventArgs e)
        {
            if (ClipboardHelper.GetClipboardType().HasValue && ClipboardHelper.GetClipboardType() == NodeType.Exam)
            {
                var exam = ClipboardHelper.GetClipboardExam();
                ExamManager.GetInstance().AddExam(exam);
                if (!ClipboardHelper.GetClipboardType().HasValue)
                {
                    ((ToolStripMenuItem)sender).Enabled = false;
                }

            }
            else
            {
                if (ClipboardHelper.GetClipboardType() == NodeType.Question)
                {
                        var selectedNode = treeView1.SelectedNode;
                        var question = ClipboardHelper.GetClipboardQuestion();
                        ExamManager.GetInstance().AddQuestion(selectedNode.Name, question);
                        if (!ClipboardHelper.GetClipboardType().HasValue)
                        {
                            ((ToolStripMenuItem)sender).Enabled = false;
                        }
                }
                else
                {
                    ((ToolStripMenuItem) sender).Enabled = false;
                }
                
            }

            _viewManager.RefreshExplorer();
        }

        private void tsmiCopyExam_Click(object sender, EventArgs e)
        {
            var selectedNode = treeView1.SelectedNode;

            var examName = selectedNode.Text;

            var exam = ExamManager.GetInstance().GetExam(new ExamFilter
            {
                ExamName = examName
            });
            ClipboardHelper.SetClipboardItem(exam, NodeType.Exam, ClipboardOperationType.Cut);
            tsmiPasteExam.Enabled = true;
        }

        private void tsmiDeleteExam_Click(object sender, EventArgs e)
        {
            var selectedNode = treeView1.SelectedNode;

            var examName = selectedNode.Text;

            var exam = ExamManager.GetInstance().GetExam(new ExamFilter
            {
                ExamName = examName
            });
            if (ExamManager.GetInstance().RemoveExam(exam))
            {
                _viewManager.RefreshExplorer();
            }
        }

        private void trmiRenameExam_Click(object sender, EventArgs e)
        {
            treeView1.LabelEdit = true;
            treeView1.SelectedNode.BeginEdit();
        }

        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            ExamManager.GetInstance().RenameExam(e.Label);
        }

        private void tsmiQuestionCut_Click(object sender, EventArgs e)
        {
            var question = ExamManager.GetInstance().GetSelectedQuestion();

            if (ExamManager.GetInstance().RemoveQuestion(ExamManager.GetInstance().GetSelectedQuestion()))
            {
                ClipboardHelper.SetClipboardItem(question, NodeType.Question, ClipboardOperationType.Cut);
                _viewManager.RefreshExplorer();
                tsmiPasteExam.Enabled = true;
            }
         
        }

        private void tsmiQuestionCopy_Click(object sender, EventArgs e)
        {
            var selectedNode = treeView1.SelectedNode;
            var examName = selectedNode.Parent.Text;
            var question = ExamManager.GetInstance().GetQuestion(examName, selectedNode.Index);

            ClipboardHelper.SetClipboardItem(question, NodeType.Question, ClipboardOperationType.Copy);
            _viewManager.RefreshExplorer();
            tsmiPasteExam.Enabled = true;
        }

        private void tsmiQuestionPaste_Click(object sender, EventArgs e)
        {
            var selectedNode = treeView1.SelectedNode;
            if (ClipboardHelper.GetClipboardType().HasValue && ClipboardHelper.GetClipboardType() == NodeType.Question)
            {
                var question = ClipboardHelper.GetClipboardQuestion();
                ExamManager.GetInstance().AddQuestion(selectedNode.Parent.Name, question);
                if (!ClipboardHelper.GetClipboardType().HasValue)
                {
                    ((ToolStripMenuItem)sender).Enabled = false;
                }

            }
            else
            {
                ((ToolStripMenuItem)sender).Enabled = false;
            }

            _viewManager.RefreshExplorer();
        }

        private void tsmiQuestionDelete_Click(object sender, EventArgs e)
        {
            var selectedNode = treeView1.SelectedNode;

            var examName = selectedNode.Parent.Text;

            var question = ExamManager.GetInstance().GetQuestion(examName, selectedNode.Index);
            if (ExamManager.GetInstance().RemoveQuestion(question))
            {
                _viewManager.RefreshExplorer();
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            var selectedNode = treeView1.SelectedNode;

            var examName = selectedNode.Parent.Text;

            var question = ExamManager.GetInstance().GetQuestion(examName, selectedNode.Index);
            var exam = ExamManager.GetInstance().GetExam(new ExamFilter {ExamName = examName});

            var frmMoveTo = new MoveToView(question, exam, _viewManager);
            frmMoveTo.Show(this);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedNode = ((TreeView)sender).SelectedNode;

            var selectedNodeType = (NodeType)selectedNode.Level;

            if (selectedNodeType == NodeType.Question)
            {
                var examName = selectedNode.Parent.Text;

                var question = ExamManager.GetInstance().GetQuestion(examName, selectedNode.Index);

                _viewManager.RefreshQuestionContent(question);
                _viewManager.RefreshQuestionProperties(question);
            }
            else if (selectedNodeType == NodeType.Exam)
            {
                var examName = selectedNode.Name;

                var exam = ExamManager.GetInstance().GetExam(new ExamFilter { ExamName = examName });

                _viewManager.RefreshExamContent(exam);
                _viewManager.RefreshExamProperties(exam);
            }
            else
            {

                _viewManager.RefreshExamBookContent(ExamManager.GetInstance().ExamBook);
                _viewManager.RefreshExamBookProperties(ExamManager.GetInstance().ExamBook);
            }

            ToggleButtons(selectedNodeType, selectedNode);
        }
    }
}
