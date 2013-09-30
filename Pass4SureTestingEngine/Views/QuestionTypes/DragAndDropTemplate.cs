using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Pass4SureTestingEngine.Extensions;
using Pass4SureTestingEngine.Enumerables;
using Pass4SureTestingEngine.Logic;
using Pass4SureTestingEngine.Models.AnswerModels;
using Pass4SureTestingEngine.Models.QuestionTypes;
using Pass4SureTestingEngine.Utils.Cursors;

namespace Pass4SureTestingEngine.Views.QuestionTypes
{
    public partial class DragAndDropTemplate : Form
    {
        private readonly DragAndDropQuestion _question;
        private ICursor _cursor;
        private CursorType _cursorType;
        private Image _originalImage;
        private readonly DragAndDropAnswer _answer;

        public DragAndDropTemplate()
        {
            InitializeComponent();
            _question = (DragAndDropQuestion)ExamManager.GetInstance().GetSelectedQuestion();
            _cursorType = CursorType.Select;
            _cursor = new SelectCursor(pbAnswerTemplate);
            _answer = _question.CorrectAnswer;
            InitQuestionBuild();
        }

        #region QuestionBuild
        private void InitQuestionBuild()
        {
            rtbQuestionDescription.Rtf = _question.Description;
            rtbQuestionExplanation.Rtf = _question.AnswerAdditionalInfo;
            rtbQuestionDescription.MakeResizeable();
            rtbQuestionExplanation.MakeResizeable();
            if (_question.Properties.BackgroundImage != null)
            {
                pbAnswerTemplate.Image = _question.Properties.BackgroundImage;
                _originalImage = pbAnswerTemplate.Image;
                foreach (var rectangle in _answer.Sources)
                {
                    SourceCursor.CreatePictureBoxFromRectangle(rectangle, pbAnswerTemplate, OverlayMouseMove);
                }

                foreach (var rectangle in _answer.Targets)
                {
                    TargetCrusor.CreatePictureBoxFromRectangle(rectangle, pbAnswerTemplate, OverlayMouseMove);
                }
                tbDefaultCursor.CheckState = CheckState.Checked;
                tbZoom1x.CheckState = CheckState.Checked;
                EnableToolBoxItems(true);
            }
            else
            {
                EnableToolBoxItems(false);
            }
        }


        private void EnableToolBoxItems(bool enabled)
        {
            tbDefaultCursor.Enabled = enabled;
            tbSourceObject.Enabled = enabled;
            tbTargetObject.Enabled = enabled;
            tbZoom1x.Enabled = enabled;
            tbZoom2x.Enabled = enabled;
            tbZoom4x.Enabled = enabled;
            tbZoom6x.Enabled = enabled;
            tbZoom8x.Enabled = enabled;
            tlblZoom.Enabled = enabled;
        }

        private void CursorClick(object sender, EventArgs e)
        {
            var toolButton = (ToolStripButton) sender;

            var cursorNumber = Convert.ToInt32(toolButton.Tag);
            _cursorType = (CursorType)Enum.ToObject(typeof(CursorType), cursorNumber);
            SelectCursor(_cursorType);
        }

        private void SelectCursor(CursorType cursorType)
        {
            switch (cursorType)
            {
                case CursorType.Select:
                    tbSourceObject.CheckState = CheckState.Unchecked;
                    tbTargetObject.CheckState = CheckState.Unchecked;
                    tbDefaultCursor.CheckState = CheckState.Checked;
                    _cursor = new SelectCursor(pbAnswerTemplate);
                    _cursorType = CursorType.Select;
                    break;
                case CursorType.Source:
                    tbSourceObject.CheckState = CheckState.Checked;
                    tbTargetObject.CheckState = CheckState.Unchecked;
                    tbDefaultCursor.CheckState = CheckState.Unchecked;
                    _cursor = new SourceCursor(pbAnswerTemplate);
                    _cursorType = CursorType.Source;
                    break;
                case CursorType.Target:
                    tbSourceObject.CheckState = CheckState.Unchecked;
                    tbTargetObject.CheckState = CheckState.Checked;
                    tbDefaultCursor.CheckState = CheckState.Unchecked;
                    _cursor = new TargetCrusor(pbAnswerTemplate);
                    _cursorType = CursorType.Target;
                    break;
            }
        }

        private void ZoomClick(object sender, EventArgs e)
        {
            var toolButton = (ToolStripButton)sender;
            var zoomFactor = Convert.ToInt32(toolButton.Tag);
            switch (zoomFactor)
            {
                case 1:
                    tbZoom1x.CheckState = CheckState.Checked;
                    tbZoom2x.CheckState = CheckState.Unchecked;
                    tbZoom4x.CheckState = CheckState.Unchecked;
                    tbZoom6x.CheckState = CheckState.Unchecked;
                    tbZoom8x.CheckState = CheckState.Unchecked;
                    break;
                case 2:
                    tbZoom1x.CheckState = CheckState.Unchecked;
                    tbZoom2x.CheckState = CheckState.Checked;
                    tbZoom4x.CheckState = CheckState.Unchecked;
                    tbZoom6x.CheckState = CheckState.Unchecked;
                    tbZoom8x.CheckState = CheckState.Unchecked;
                    break;
                case 4:
                    tbZoom1x.CheckState = CheckState.Unchecked;
                    tbZoom2x.CheckState = CheckState.Unchecked;
                    tbZoom4x.CheckState = CheckState.Checked;
                    tbZoom6x.CheckState = CheckState.Unchecked;
                    tbZoom8x.CheckState = CheckState.Unchecked;
                    break;
                case 6:
                    tbZoom1x.CheckState = CheckState.Unchecked;
                    tbZoom2x.CheckState = CheckState.Unchecked;
                    tbZoom4x.CheckState = CheckState.Unchecked;
                    tbZoom6x.CheckState = CheckState.Checked;
                    tbZoom8x.CheckState = CheckState.Unchecked;
                    break;
                case 8:
                    tbZoom1x.CheckState = CheckState.Unchecked;
                    tbZoom2x.CheckState = CheckState.Unchecked;
                    tbZoom4x.CheckState = CheckState.Unchecked;
                    tbZoom6x.CheckState = CheckState.Unchecked;
                    tbZoom8x.CheckState = CheckState.Checked;
                    break;
            }

            pbAnswerTemplate.Image = PictureBoxZoom(_originalImage,new Size(zoomFactor,zoomFactor));
        }

        private void CanvasClick(object sender, MouseEventArgs e)
        {
            _cursor.Click(e); 
        }
       
        private void CanvasMouseMove(object sender, MouseEventArgs e)
        {
            _cursor.Drag(e);
        }
        
        private void CanvasMouseUp(object sender, MouseEventArgs e)
        {
            var currentRect = _cursor.EndDrag(OverlayMouseMove);
            switch (_cursorType)
            {
                case CursorType.Source:
                    _answer.Sources.Add(currentRect);
                    break;
                case CursorType.Target:
                    _answer.Targets.Add(currentRect);
                    break;
            }
            _question.CorrectAnswer = _answer;
            SelectCursor(CursorType.Select);
        }

        private Image PictureBoxZoom(Image img, Size size)
        {
            var newWidth = img.Width*size.Width;
            var newHeight = img.Height*size.Height;
            if (newWidth < 3500 && newHeight < 3500)
            {
                var bm = new Bitmap(img, Convert.ToInt32(newWidth), Convert.ToInt32(newHeight));
                var grap = Graphics.FromImage(bm);
                grap.InterpolationMode = InterpolationMode.HighQualityBicubic;
                return bm;
            }
            return _originalImage;
        }

       

        #endregion

        #region AnswerBuild

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            InitializeAnswer();
        }

        private void InitializeAnswer()
        {
            var backgroundImage = new Bitmap(_originalImage);
            var index = 0;
            foreach (var rectangle in _answer.Sources)
            {
                var graphics = Graphics.FromImage(backgroundImage);
                var rectangleImage = CropImage(new Bitmap(_originalImage), rectangle);
                
                var pictureBox = new PictureBox
                    {
                        BackColor = Color.Transparent,
                        Width = rectangle.Width,
                        Height = rectangle.Height,
                        Tag = index
                    };
                pictureBox.MakeDraggable(true);
                pictureBox.Image = rectangleImage;
                pictureBox.Location = rectangle.Location;
                pictureBox.MouseUp += control_MouseUp;
                pictureBox.LocationChanged += AnswerRectangleLocationChange;
                
                pbAnswerBuild.Controls.Add(pictureBox);
                
                graphics.FillRectangle(new SolidBrush(Color.White),rectangle);
                graphics.Save();
                index++;
            }


            foreach (var rectangle in _answer.Targets)
            {
                var pictureBox = new PictureBox
                    {
                        BackColor = Color.Transparent,
                        Width = rectangle.Width,
                        Height = rectangle.Height,
                        Tag = index,
                        Location = rectangle.Location
                    };
                pictureBox.SendToBack();
                pbAnswerBuild.Controls.Add(pictureBox);
                index++;
            }
            
            pbAnswerBuild.Image = backgroundImage;

        }

        private void control_MouseUp(object sender, MouseEventArgs e)
        {
            var currentBox = (PictureBox)sender;
            var pictureBoxList = currentBox.Parent.Controls.OfType<PictureBox>().ToList();
            foreach (var pictureBox in pictureBoxList)
            {
                if (((int)pictureBox.Tag != (int)currentBox.Tag) && AreOverlaping(currentBox, pictureBox))
                {
                    currentBox.Location = pictureBox.Location;
                    currentBox.BringToFront();
                    pictureBox.SendToBack();
                }
                else
                {
                    currentBox.Location = _answer.Sources[(int) currentBox.Tag].Location;
                }
            }
        }

        private bool AreOverlaping(PictureBox firstPictureBox, PictureBox secondPictureBox)
        {
            var firstRectangle = new Rectangle
                {
                    Location = firstPictureBox.Location,
                    Width = firstPictureBox.Width,
                    Height = firstPictureBox.Height
                };

            var secondRectangle = new Rectangle
                {
                    Location = secondPictureBox.Location,
                    Width = secondPictureBox.Width,
                    Height = secondPictureBox.Height
                };
            return firstRectangle.IntersectsWith(secondRectangle);
        }

        private void DescriptionTextChanged(object sender, EventArgs e)
        {
            _question.Description = rtbQuestionDescription.Rtf;
        }

        private void ExplanationTextChanged(object sender, EventArgs e)
        {
            _question.AnswerAdditionalInfo = rtbQuestionExplanation.Rtf;
        }

        private void AnswerRectangleLocationChange(object sender, EventArgs e)
        {
            var currentBox = (PictureBox)sender;
            var index = (int)currentBox.Tag;
            var pictureBoxList = currentBox.Parent.Controls.OfType<PictureBox>().ToList();
            foreach (var pictureBox in pictureBoxList)
            {
                if (((int)pictureBox.Tag != index) && AreOverlaping(currentBox, pictureBox))
                {
                    if (pictureBox.Controls.Count == 0)
                    {
                        var borderPb = new PictureBox
                        {
                            Dock = DockStyle.Fill,
                            BackColor = Color.Transparent
                        };
                        pictureBox.Controls.Add(borderPb);
                        var graphics = borderPb.CreateGraphics();
                        var borderRectangle = new Rectangle(0, 0, pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);
                        using (var pen = new Pen(Color.Red, 3))
                        {
                            graphics.DrawRectangle(pen, borderRectangle);
                        }
                    }
                }
                else
                {
                    pictureBox.Controls.Clear();
                }
            }
        }

        #endregion

        #region QuestionPreview
        #endregion

        #region Usefull

        private static Image CropImage(Image img, Rectangle cropArea)
        {
            var bmpImage = new Bitmap(img);
            var bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);
            return bmpCrop;
        }

  
        private void OverlayMouseMove(object sender, EventArgs e)
        {
            var currentBox = (PictureBox) sender;
            var index = (int)currentBox.Tag;
            var sourceRectangle = (index >= 0 && index<_answer.Sources.Count) ?_answer.Sources[index] : new Rectangle();
            if (sourceRectangle.Width != 0 && sourceRectangle.Height != 0)
            {
                var newX = currentBox.Location.X;
                var newY = currentBox.Location.Y;
                sourceRectangle.Location = new Point(newX,newY);
                _answer.Sources[index] = sourceRectangle;
            }
            else
            {
                var targetRectangle = (index > 0 && index < _answer.Targets.Count) ? _answer.Targets[index] : new Rectangle();
                if (targetRectangle.Width == 0 && targetRectangle.Height == 0)
                {
                    var newX = currentBox.Location.X;
                    var newY = currentBox.Location.Y;
                    targetRectangle.Location = new Point(newX, newY);
                    _answer.Targets[index] = targetRectangle;
                }
            }
        }
        #endregion

     

    }
}
