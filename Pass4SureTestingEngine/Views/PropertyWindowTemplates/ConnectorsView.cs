using System;
using System.Windows.Forms;
using Pass4SureTestingEngine.Enumerables;
using Pass4SureTestingEngine.Models;
using Pass4SureTestingEngine.Models.QuestionTypes;
using Pass4SureTestingEngine.Extensions;
using Pass4SureTestingEngine.Properties;
using Pass4SureTestingEngine.ViewModels;

namespace Pass4SureTestingEngine.Views.PropertyWindowTemplates
{
    public partial class ConnectorsView : Form
    {
        private readonly DropAndConnectQuestion _question;
        

        public ConnectorsView(Question question)
        {
            
            InitializeComponent();

            _question = (DropAndConnectQuestion)question;
            foreach (var connectorType in Enum.GetValues(typeof(ConnectorType)))
            {
                var enumValue = (ConnectorType)connectorType;
                var connectorTypeText = enumValue.GetDescription<ConnectorType>();
                var cbItem = new ComboBoxItem
                    {
                        Text = connectorTypeText,
                        Value = enumValue
                    };
                cbType.Items.Add(cbItem);
            }

            cbType.SelectedIndex = 0;
            cbType.Refresh();

            DisplayConnectors();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ConnectorsView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && cbType.SelectedItem != null)
            {
                var questionType = (ConnectorType)(cbType.SelectedItem as ComboBoxItem).Value;
                var index = listView1.SelectedIndices[0];
                var currentConnector = _question.Properties.Connectors[index];
                currentConnector.Type = questionType;

                if (questionType != ConnectorType.Undirected && questionType != ConnectorType.Directed)
                {
                    currentConnector.Title = questionType.GetDescription<ConnectorType>();
                }

                string[] row = { currentConnector.Title, currentConnector.Type.GetDescription<ConnectorType>() };
                var item = new ListViewItem(row);
                _question.Properties.Connectors[index] = currentConnector;
                listView1.Items[index] = item;

                listView1.SelectedIndices.Add(index);
                listView1.Refresh();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var type = (ConnectorType) (cbType.SelectedItem as ComboBoxItem).Value;
            var connector = new Connector
                {
                    Title = type.GetDescription<ConnectorType>(),
                    Type = type
                };
            _question.Properties.Connectors.Add(connector);

            DisplayConnectors();
        }

        private void DisplayConnectors()
        {
            listView1.Items.Clear();
            foreach (var connector in _question.Properties.Connectors)
            {
                string[] row = { connector.Title, connector.Type.GetDescription<ConnectorType>() };
                var item = new ListViewItem(row);
                listView1.Items.Add(item);
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var index = listView1.SelectedIndices[0];
                if (_question.Properties.Connectors[index].Type == ConnectorType.Undirected ||
                    _question.Properties.Connectors[index].Type == ConnectorType.Undirected)
                {
                    listView1.SelectedItems[0].BeginEdit();
                }
                else
                {
                    MessageBox.Show(Resources.ConnectorRenameMessage);
                }
                
            }
        }

        private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            var index = listView1.Items.IndexOf(listView1.SelectedItems[0]);
            if (_question.Properties.Connectors[index].Type == ConnectorType.Undirected ||
                _question.Properties.Connectors[index].Type == ConnectorType.Undirected)
            {
                _question.Properties.Connectors[index].Title = e.Label;
            }
            else
            {
                MessageBox.Show(Resources.ConnectorRenameMessage);
            }
        }



        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var index = listView1.SelectedIndices[0];
                _question.Properties.Connectors.Remove(_question.Properties.Connectors[index]);
                DisplayConnectors();
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
    }
}
