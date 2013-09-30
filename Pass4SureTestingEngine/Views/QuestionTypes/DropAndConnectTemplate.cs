using System;
using System.Drawing;
using System.Windows.Forms;
using Pass4SureTestingEngine.Extensions;
using Pass4SureTestingEngine.Logic;
using Pass4SureTestingEngine.Models.AnswerModels.DropAndConnect;
using Pass4SureTestingEngine.Models.PropertyModels;
using Pass4SureTestingEngine.Models.QuestionTypes;
using Pass4SureTestingEngine.Utils;

namespace Pass4SureTestingEngine.Views.QuestionTypes
{
    public partial class DropAndConnectTemplate : Form
    {
        private readonly DropAndConnectQuestion _question;
        private DropAndConnectAnswer _answer;
        private int _numberOfNoLocationElements;
        public DropAndConnectTemplate()
        {
            InitializeComponent();

            pnlObjectCreator.MakeDraggable(true);
            _question = (DropAndConnectQuestion) ExamManager.GetInstance().GetSelectedQuestion();
            _answer =  _question.CorrectAnswer;
            rtbQuestionDescription.MakeResizeable();
            rtbQuestionExplanation.MakeResizeable();
            _numberOfNoLocationElements = 0;
            IntiQuestionBuild();

        }

        #region Question Build

        private void IntiQuestionBuild()
        {
            rtbQuestionDescription.Rtf = _question.Description;
            rtbQuestionExplanation.Rtf = _question.AnswerAdditionalInfo;

            foreach (var dragObject in _question.CorrectAnswer.Objects)
            {
                PlaceObject(dragObject);
            }
            var enumerator = pbObjectContainer.Controls.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var currentControl = (Control)enumerator.Current;
                currentControl.MakeDraggable(true);
            }
        }

        #endregion

        private void PlaceObject(DragObject dragObject)
        {
            var panel = new Panel();
            var label = new TransparentLabel
                {
                    Text = dragObject.Caption,
                    Dock = DockStyle.Fill,
                    AutoSize =  false,
                    TextAlign = ContentAlignment.MiddleCenter,
                };
            panel.Controls.Add(label);
            panel.Width = 70;
            panel.Height = 70;
            panel.BackColor = SystemColors.ControlLight;
            panel.BorderStyle = BorderStyle.FixedSingle;
            if (dragObject.Location.HasValue)
            {
                panel.Location = dragObject.Location.Value;
            }
            else
            {
                var newLocation = new Point(30, 30 + 85*_numberOfNoLocationElements);
                _numberOfNoLocationElements++;
                dragObject.Location = newLocation;
                panel.Location = newLocation;
            }
            pbObjectContainer.Controls.Add(panel);
           
        }

        private void DropAndConnectTemplate_Load(object sender, EventArgs e)
        {
           
        }

        #region Utils
        
        private void pbObjectContainer_Paint(object sender, PaintEventArgs e)
        {
            var graphics = pbObjectContainer.CreateGraphics();
            graphics.Clear(Color.White);
            var pen = new Pen(Color.Black, 2);
            
            graphics.Save();
            foreach (var control in pbObjectContainer.Controls)
            {
                var pnlControl = (Panel) control;
                pnlControl.Invalidate();
            }
        }

        private void pbObjectContainer_Resize(object sender, EventArgs e)
        {
            ((PictureBox)sender).Invalidate();
        }

        private void DispalyAnswer(Panel container)
        {
            
        }

        #endregion
    }
}
