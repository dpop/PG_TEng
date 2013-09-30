using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Pass4SureTestingEngine.Enumerables;
using Pass4SureTestingEngine.Logic;
using Pass4SureTestingEngine.ViewModels.Questions;
using PropertyGridEx;

namespace Pass4SureTestingEngine.Views.PropertyWindowTemplates
{
    public partial class ExhibitsView : Form
    {
        private readonly List<Exhibit> _exhibits;
        private readonly CustomProperty _item;
        private readonly PropertyGridEx.PropertyGridEx _container;

        public ExhibitsView(CustomProperty item,  Control container)
        {
            InitializeComponent();
            _container = (PropertyGridEx.PropertyGridEx) container.Controls[0];
            _item = item;
            _exhibits = new List<Exhibit>(ExamManager.GetInstance().GetSelectedQuestion().Exhibits);
            DisplayExhibitList(_exhibits.FirstOrDefault());
            SelectButtons();
            
        }

        private void ExhibitsView_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var exhibit = new Exhibit();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    exhibit.Sample = new Bitmap(openFileDialog1.FileName);
                }
                catch (Exception)
                {

                    MessageBox.Show(@"Not a valid image format");
                }
               

                exhibit.Resolution = string.Format("{0} x {1}", exhibit.Sample.HorizontalResolution,
                                                   exhibit.Sample.VerticalResolution);
                var fileLength = new FileInfo(openFileDialog1.FileName).Length;
                exhibit.Size = string.Format("{0} KB", fileLength/1024);

                if (exhibit.Sample.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg))
                {
                    exhibit.Type = "JPEG";
                }
                else if (exhibit.Sample.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Gif))
                {
                    exhibit.Type = "GIF";
                }

                exhibit.Title = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);

                _exhibits.Add(exhibit);
                
                DisplayExhibitList(exhibit);

                

                SelectButtons();
            }
        }

        private void DisplayExhibitList(Exhibit selectedExhibit = null)
        {
            listView1.Items.Clear();
            foreach (var exhibit in _exhibits)
            {
                string[] row = {exhibit.Title, exhibit.Resolution, exhibit.Type, exhibit.Size};
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                if (selectedExhibit != null && exhibit.Title == selectedExhibit.Title && exhibit.Size == selectedExhibit.Size)
                {
                    listView1.Items[listView1.Items.Count - 1].Selected = true;
                    listView1.Select();
                }
            }
        }

        private void SelectButtons()
        {
            btnRemove.Enabled = listView1.SelectedItems.Count > 0;
            btnRename.Enabled = listView1.SelectedItems.Count > 0;
            btnSaveAs.Enabled = listView1.SelectedItems.Count > 0;
            btnPreview.Enabled = listView1.Items.Count > 0;
            btnUp.Enabled = listView1.SelectedItems.Count > 0  && listView1.SelectedItems[0] != listView1.Items[0];
            btnDown.Enabled = listView1.SelectedItems.Count > 0 && listView1.SelectedItems[0] != listView1.Items[listView1.Items.Count - 1];
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            var selectedExhibit = MoveExhibit(Direction.Up);
            DisplayExhibitList(selectedExhibit);
            SelectButtons();
        }


        private Exhibit MoveExhibit(Direction direction)
        {
            var quota = direction == Direction.Up ? -1 : 1;
            var index = listView1.Items.IndexOf(listView1.SelectedItems[0]);
            var selectedExhibit = _exhibits[index];
            _exhibits.Remove(selectedExhibit);
            var newIndex = index + quota;

            _exhibits.Insert(newIndex, selectedExhibit);

            return selectedExhibit;
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
            var index = listView1.Items.IndexOf(listView1.SelectedItems[0]);
            _exhibits.Remove(_exhibits[index]);
            DisplayExhibitList();
            SelectButtons();
        }

        private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            var index = listView1.Items.IndexOf(listView1.SelectedItems[0]);
            _exhibits[index].Title = listView1.SelectedItems[0].Text;
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var index = listView1.Items.IndexOf(listView1.SelectedItems[0]);
            _exhibits[index].Sample.Save(saveFileDialog1.FileName);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            var previewWindow = new ExhibitPreview(this);
            var exhibitContainer = new TabControl();
            exhibitContainer.Width = previewWindow.Width - 20;
            exhibitContainer.Height = previewWindow.Height - 90;
            foreach (var exhibit in _exhibits)
            {
                var tabPage = new TabPage(exhibit.Title);
                tabPage.AutoScroll = true;
                tabPage.Controls.Add(new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.AutoSize,
                        Image = exhibit.Sample,               
                    });
                
                exhibitContainer.Controls.Add(tabPage);
            }
            previewWindow.Controls.Add(exhibitContainer);

            previewWindow.Show();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            var selectedExhibit = MoveExhibit(Direction.Down);
            DisplayExhibitList(selectedExhibit);
            SelectButtons();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            SelectButtons();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var selectedQuestion = ExamManager.GetInstance().GetSelectedQuestion();

            selectedQuestion.Exhibits.Clear();

            foreach (var exhibit in _exhibits)
            {
                selectedQuestion.Exhibits.Add(exhibit);
            }

            _item.Value =_exhibits.Count > 0 ? "(collection)" : "empty";

            _container.Refresh();
            Close();
        }
    }
}
