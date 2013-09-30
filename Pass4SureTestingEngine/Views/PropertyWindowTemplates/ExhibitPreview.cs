using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass4SureTestingEngine.Views.PropertyWindowTemplates
{
    public partial class ExhibitPreview : Form
    {
        private ExhibitsView _parent;

        public ExhibitPreview(ExhibitsView parent)
        {
            _parent = parent;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExhibitPreview_Load(object sender, EventArgs e)
        {
            _parent.Enabled = false;
        }

        private void ExhibitPreview_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parent.Enabled = true;
        }
    }
}
