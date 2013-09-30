using System;
using System.Windows.Forms;
using Pass4SureTestingEngine.Models;
using Pass4SureTestingEngine.Models.PropertyModels;
using Pass4SureTestingEngine.Models.QuestionTypes;

namespace Pass4SureTestingEngine.Views.PropertyWindowTemplates
{
    public partial class ObjectView : Form
    {

        private readonly DropAndConnectQuestion _question;

        public ObjectView(Question question)
        {
            InitializeComponent();
            _question = (DropAndConnectQuestion)question;
            DisplayObjects();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _question.Properties.Objects.Add(new DragObject
                {
                    Caption =  string.Format("Object {0}",_question.Properties.Objects.Count + 1)
                });

            DisplayObjects();

            SelectItem(listView1.Items.Count - 1);         
            listView1.SelectedItems[0].BeginEdit();
        }

        private void DisplayObjects()
        {
            listView1.Items.Clear();
            foreach (var dragObject in _question.Properties.Objects)
            {
                string[] row = { dragObject.Caption };
                var item = new ListViewItem(row);
                listView1.Items.Add(item);
            }
        }

        private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            var index = listView1.Items.IndexOf(listView1.SelectedItems[0]);
            _question.Properties.Objects[index].Caption = e.Label;
            
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].BeginEdit();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var index = listView1.SelectedIndices[0];
                _question.Properties.Objects.Remove(_question.Properties.Objects[index]);
                DisplayObjects();
                if (listView1.Items.Count > 0)
                {
                    if (index < listView1.Items.Count)
                    {
                        SelectItem(index);
                    }
                    else
                    {
                        SelectItem(index - 1);
                    }
                }
            }
        }

        private void SelectItem(int index)
        {
            listView1.SelectedItems.Clear();
            listView1.SelectedIndices.Add(index);
            listView1.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
