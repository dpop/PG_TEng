using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Pass4SureTestingEngine.Logic;
using Pass4SureTestingEngine.Models;
using Pass4SureTestingEngine.Properties;
using Pass4SureTestingEngine.Serialization;
using Pass4SureTestingEngine.ViewEngines;


namespace Pass4SureTestingEngine
{
    public partial class Form1 : Form
    {

        private readonly Parser.Parser _parser;
        private readonly ViewManager _viewManager;
        private List<string> _currentQuestions;
        private string _serializedObject;

        public Form1()
        {
            InitializeComponent();
            var richTextBox = new RichTextBox
                {
                    Visible = false
                };
            _parser = new Parser.Parser(richTextBox);

            _viewManager = new ViewManager(this);
            _viewManager.InitWindows(pnlMainContainer);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = importFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = importFileDialog.FileName;
                try
                {
                    const string pattern = "QUESTION: {0}";
                    _currentQuestions = _parser.GetContentFromFile(file, pattern);
                    var questions = _parser.ParseFile(file, pattern);
                    CreateNavigationTree(_currentQuestions);

                }
                catch (Exception)
                {
                }
            }
        }

        #region Logic

        private void CreateNavigationTree(IEnumerable<string> questions)
        {
            //treeView1.Nodes.Clear();
            //var root = new TreeNode("Exam") {Tag = 0};
            //var enumerable = questions as string[] ?? questions.ToArray();
            //for (var index = 1; index <= enumerable.Count(); index++ )
            //{
            //    var questionNode = new TreeNode(string.Format("Question {0}", index.ToString(CultureInfo.InvariantCulture))) { Tag = index };
            //    root.Nodes.Add(questionNode);
            //}
            //treeView1.Nodes.Add(root);
            //treeView1.AfterSelect += treeView1_AfterSelect;
        }
        #endregion

        private void pnlMainContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlLeftContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlExplorer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMainQuestionContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ExamManager.GetInstance().Path))
            {
                var bytes = Serializer.BinarySerializeObject(ExamManager.GetInstance().ExamBook);
                File.WriteAllBytes(ExamManager.GetInstance().Path, bytes);
            }
            else
            {
                saveAsToolStripMenuItem_Click(sender,e);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgOpenFile.Filter = Resources.PGCustomFileFormatDescription;
            dlgOpenFile.FilterIndex = 0;

            // Process input if the user clicked OK.
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                // Open the selected file to read.
                var bytes = File.ReadAllBytes(dlgOpenFile.FileName);

                try
                {
                    var book = Serializer.BinaryDeserializeObject<ExamBook>(bytes);
                    ExamManager.GetInstance().ExamBook = book;
                    _viewManager.RefreshExplorer();
                }
                catch (Exception)
                {
                    MessageBox.Show(Resources.CoruptedFileMessage);
                }
                
            }
        }

        private void importFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bytes = Serializer.BinarySerializeObject(ExamManager.GetInstance().ExamBook);
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = Resources.PGCustomFileFormatDescription;
                dialog.FilterIndex = 2;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(dialog.FileName,bytes);
                    ExamManager.GetInstance().Path = dialog.FileName;
                    ExamManager.GetInstance().ExamBook.Title =
                        Path.GetFileNameWithoutExtension(dialog.FileName);
                    _viewManager.RefreshExplorer();
                }
            }
        }

    }
}
