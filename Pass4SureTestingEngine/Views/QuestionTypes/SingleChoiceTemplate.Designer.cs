namespace Pass4SureTestingEngine.Views.QuestionTypes
{
    partial class SingleChoiceTemplate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {   
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.tabQandA = new System.Windows.Forms.TabPage();
            this.pnlExplanation = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAditionalInfo = new System.Windows.Forms.TextBox();
            this.pnlAnswerContainer = new System.Windows.Forms.Panel();
            this.pnlAnswerItemContainer = new System.Windows.Forms.Panel();
            this.tbAnswerText1 = new System.Windows.Forms.TextBox();
            this.btnChoice1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.rtbQuestionText = new System.Windows.Forms.RichTextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlPreviewAnswerContainer = new System.Windows.Forms.Panel();
            this.pnlAnswerPreviewItemContainer = new System.Windows.Forms.Panel();
            this.lblPreviewAnswerTextTemplate = new System.Windows.Forms.Label();
            this.rbPreviewAnswerItemTemplate = new System.Windows.Forms.RadioButton();
            this.rtbPreviewDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnShowAnswer = new System.Windows.Forms.Button();
            this.lblItemPaging = new System.Windows.Forms.Label();
            this.pnlPreviewTopContainer = new System.Windows.Forms.Panel();
            this.pnlPreviewDescriptionContainer = new System.Windows.Forms.Panel();
            this.pnlPreviewAnswerDetails = new System.Windows.Forms.Panel();
            this.lblPreviewAditionalInfo = new System.Windows.Forms.Label();
            this.tabContainer.SuspendLayout();
            this.tabQandA.SuspendLayout();
            this.pnlExplanation.SuspendLayout();
            this.pnlAnswerContainer.SuspendLayout();
            this.pnlAnswerItemContainer.SuspendLayout();
            this.pnlDescription.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlPreviewAnswerContainer.SuspendLayout();
            this.pnlAnswerPreviewItemContainer.SuspendLayout();
            this.pnlPreviewTopContainer.SuspendLayout();
            this.pnlPreviewDescriptionContainer.SuspendLayout();
            this.pnlPreviewAnswerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            this.tabContainer.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabContainer.Controls.Add(this.tabQandA);
            this.tabContainer.Controls.Add(this.tabPage2);
            this.tabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContainer.Location = new System.Drawing.Point(0, 0);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(684, 429);
            this.tabContainer.TabIndex = 0;
            // 
            // tabQandA
            // 
            this.tabQandA.AutoScroll = true;
            this.tabQandA.Controls.Add(this.pnlExplanation);
            this.tabQandA.Controls.Add(this.pnlAnswerContainer);
            this.tabQandA.Controls.Add(this.pnlDescription);
            this.tabQandA.Location = new System.Drawing.Point(4, 4);
            this.tabQandA.Name = "tabQandA";
            this.tabQandA.Padding = new System.Windows.Forms.Padding(4);
            this.tabQandA.Size = new System.Drawing.Size(676, 403);
            this.tabQandA.TabIndex = 0;
            this.tabQandA.Text = "Questions and Answers";
            this.tabQandA.UseVisualStyleBackColor = true;
            // 
            // pnlExplanation
            // 
            this.pnlExplanation.AutoSize = true;
            this.pnlExplanation.Controls.Add(this.label2);
            this.pnlExplanation.Controls.Add(this.tbAditionalInfo);
            this.pnlExplanation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExplanation.Location = new System.Drawing.Point(4, 133);
            this.pnlExplanation.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.pnlExplanation.Name = "pnlExplanation";
            this.pnlExplanation.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.pnlExplanation.Size = new System.Drawing.Size(668, 71);
            this.pnlExplanation.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(0, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4);
            this.label2.Size = new System.Drawing.Size(668, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Explanation/Referance";
            // 
            // tbAditionalInfo
            // 
            this.tbAditionalInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAditionalInfo.Location = new System.Drawing.Point(3, 42);
            this.tbAditionalInfo.Multiline = true;
            this.tbAditionalInfo.Name = "tbAditionalInfo";
            this.tbAditionalInfo.Size = new System.Drawing.Size(662, 20);
            this.tbAditionalInfo.TabIndex = 1;
            this.tbAditionalInfo.TextChanged += new System.EventHandler(this.AdditionaInfoTextChange);
            // 
            // pnlAnswerContainer
            // 
            this.pnlAnswerContainer.AutoSize = true;
            this.pnlAnswerContainer.Controls.Add(this.pnlAnswerItemContainer);
            this.pnlAnswerContainer.Controls.Add(this.label1);
            this.pnlAnswerContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAnswerContainer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlAnswerContainer.Location = new System.Drawing.Point(4, 59);
            this.pnlAnswerContainer.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.pnlAnswerContainer.Name = "pnlAnswerContainer";
            this.pnlAnswerContainer.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.pnlAnswerContainer.Size = new System.Drawing.Size(668, 74);
            this.pnlAnswerContainer.TabIndex = 19;
            // 
            // pnlAnswerItemContainer
            // 
            this.pnlAnswerItemContainer.AutoSize = true;
            this.pnlAnswerItemContainer.Controls.Add(this.tbAnswerText1);
            this.pnlAnswerItemContainer.Controls.Add(this.btnChoice1);
            this.pnlAnswerItemContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAnswerItemContainer.Location = new System.Drawing.Point(0, 31);
            this.pnlAnswerItemContainer.Name = "pnlAnswerItemContainer";
            this.pnlAnswerItemContainer.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnlAnswerItemContainer.Size = new System.Drawing.Size(668, 37);
            this.pnlAnswerItemContainer.TabIndex = 20;
            this.pnlAnswerItemContainer.Visible = false;
            // 
            // tbAnswerText1
            // 
            this.tbAnswerText1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAnswerText1.Location = new System.Drawing.Point(44, 9);
            this.tbAnswerText1.Multiline = true;
            this.tbAnswerText1.Name = "tbAnswerText1";
            this.tbAnswerText1.Size = new System.Drawing.Size(621, 20);
            this.tbAnswerText1.TabIndex = 3;
            this.tbAnswerText1.Visible = false;
            // 
            // btnChoice1
            // 
            this.btnChoice1.AutoSize = true;
            this.btnChoice1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnChoice1.Location = new System.Drawing.Point(3, 10);
            this.btnChoice1.Name = "btnChoice1";
            this.btnChoice1.Size = new System.Drawing.Size(35, 17);
            this.btnChoice1.TabIndex = 2;
            this.btnChoice1.TabStop = true;
            this.btnChoice1.Text = "A.";
            this.btnChoice1.UseVisualStyleBackColor = true;
            this.btnChoice1.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(668, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Available Choices (select all choices that are correct)";
            // 
            // pnlDescription
            // 
            this.pnlDescription.AutoSize = true;
            this.pnlDescription.Controls.Add(this.rtbQuestionText);
            this.pnlDescription.Controls.Add(this.lblQuestion);
            this.pnlDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDescription.Location = new System.Drawing.Point(4, 4);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(668, 55);
            this.pnlDescription.TabIndex = 17;
            // 
            // rtbQuestionText
            // 
            this.rtbQuestionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbQuestionText.Location = new System.Drawing.Point(-1, 33);
            this.rtbQuestionText.Name = "rtbQuestionText";
            this.rtbQuestionText.Size = new System.Drawing.Size(666, 19);
            this.rtbQuestionText.TabIndex = 8;
            this.rtbQuestionText.Text = "";
            this.rtbQuestionText.TextChanged += new System.EventHandler(this.DescriptionChanged);
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Gray;
            this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblQuestion.Location = new System.Drawing.Point(0, 0);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Padding = new System.Windows.Forms.Padding(4);
            this.lblQuestion.Size = new System.Drawing.Size(668, 25);
            this.lblQuestion.TabIndex = 9;
            this.lblQuestion.Text = "Question:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlPreviewAnswerDetails);
            this.tabPage2.Controls.Add(this.pnlPreviewAnswerContainer);
            this.tabPage2.Controls.Add(this.pnlPreviewDescriptionContainer);
            this.tabPage2.Controls.Add(this.pnlPreviewTopContainer);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(676, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Preview";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // pnlPreviewAnswerContainer
            // 
            this.pnlPreviewAnswerContainer.AutoSize = true;
            this.pnlPreviewAnswerContainer.Controls.Add(this.pnlAnswerPreviewItemContainer);
            this.pnlPreviewAnswerContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPreviewAnswerContainer.Location = new System.Drawing.Point(3, 79);
            this.pnlPreviewAnswerContainer.Name = "pnlPreviewAnswerContainer";
            this.pnlPreviewAnswerContainer.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnlPreviewAnswerContainer.Size = new System.Drawing.Size(670, 37);
            this.pnlPreviewAnswerContainer.TabIndex = 5;
            // 
            // pnlAnswerPreviewItemContainer
            // 
            this.pnlAnswerPreviewItemContainer.AutoSize = true;
            this.pnlAnswerPreviewItemContainer.Controls.Add(this.lblPreviewAnswerTextTemplate);
            this.pnlAnswerPreviewItemContainer.Controls.Add(this.rbPreviewAnswerItemTemplate);
            this.pnlAnswerPreviewItemContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAnswerPreviewItemContainer.Location = new System.Drawing.Point(3, 0);
            this.pnlAnswerPreviewItemContainer.Name = "pnlAnswerPreviewItemContainer";
            this.pnlAnswerPreviewItemContainer.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnlAnswerPreviewItemContainer.Size = new System.Drawing.Size(667, 37);
            this.pnlAnswerPreviewItemContainer.TabIndex = 3;
            this.pnlAnswerPreviewItemContainer.Visible = false;
            // 
            // lblPreviewAnswerTextTemplate
            // 
            this.lblPreviewAnswerTextTemplate.AutoSize = true;
            this.lblPreviewAnswerTextTemplate.Location = new System.Drawing.Point(46, 12);
            this.lblPreviewAnswerTextTemplate.Name = "lblPreviewAnswerTextTemplate";
            this.lblPreviewAnswerTextTemplate.Size = new System.Drawing.Size(35, 13);
            this.lblPreviewAnswerTextTemplate.TabIndex = 4;
            this.lblPreviewAnswerTextTemplate.Text = "label3";
            this.lblPreviewAnswerTextTemplate.Visible = false;
            // 
            // rbPreviewAnswerItemTemplate
            // 
            this.rbPreviewAnswerItemTemplate.AutoSize = true;
            this.rbPreviewAnswerItemTemplate.Location = new System.Drawing.Point(5, 12);
            this.rbPreviewAnswerItemTemplate.Name = "rbPreviewAnswerItemTemplate";
            this.rbPreviewAnswerItemTemplate.Size = new System.Drawing.Size(35, 17);
            this.rbPreviewAnswerItemTemplate.TabIndex = 3;
            this.rbPreviewAnswerItemTemplate.TabStop = true;
            this.rbPreviewAnswerItemTemplate.Text = "A.";
            this.rbPreviewAnswerItemTemplate.UseVisualStyleBackColor = true;
            this.rbPreviewAnswerItemTemplate.Visible = false;
            // 
            // rtbPreviewDescription
            // 
            this.rtbPreviewDescription.BackColor = System.Drawing.SystemColors.Window;
            this.rtbPreviewDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPreviewDescription.Location = new System.Drawing.Point(2, 3);
            this.rtbPreviewDescription.Name = "rtbPreviewDescription";
            this.rtbPreviewDescription.ReadOnly = true;
            this.rtbPreviewDescription.Size = new System.Drawing.Size(665, 17);
            this.rtbPreviewDescription.TabIndex = 4;
            this.rtbPreviewDescription.Text = "";
            this.rtbPreviewDescription.TextChanged += new System.EventHandler(this.rtbDescription_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(5, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(670, 2);
            this.label4.TabIndex = 3;
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(587, 5);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(75, 23);
            this.btnCalculator.TabIndex = 2;
            this.btnCalculator.Text = "Calculator";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // btnShowAnswer
            // 
            this.btnShowAnswer.Location = new System.Drawing.Point(490, 5);
            this.btnShowAnswer.Name = "btnShowAnswer";
            this.btnShowAnswer.Size = new System.Drawing.Size(91, 23);
            this.btnShowAnswer.TabIndex = 1;
            this.btnShowAnswer.Text = "Show Answer";
            this.btnShowAnswer.UseVisualStyleBackColor = true;
            this.btnShowAnswer.Click += new System.EventHandler(this.btnShowAnswer_Click);
            // 
            // lblItemPaging
            // 
            this.lblItemPaging.AutoSize = true;
            this.lblItemPaging.Location = new System.Drawing.Point(2, 10);
            this.lblItemPaging.Name = "lblItemPaging";
            this.lblItemPaging.Size = new System.Drawing.Size(73, 13);
            this.lblItemPaging.TabIndex = 0;
            this.lblItemPaging.Text = "Item {0} of {1}";
            // 
            // pnlPreviewTopContainer
            // 
            this.pnlPreviewTopContainer.Controls.Add(this.lblItemPaging);
            this.pnlPreviewTopContainer.Controls.Add(this.btnShowAnswer);
            this.pnlPreviewTopContainer.Controls.Add(this.btnCalculator);
            this.pnlPreviewTopContainer.Controls.Add(this.label4);
            this.pnlPreviewTopContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPreviewTopContainer.Location = new System.Drawing.Point(3, 3);
            this.pnlPreviewTopContainer.Name = "pnlPreviewTopContainer";
            this.pnlPreviewTopContainer.Size = new System.Drawing.Size(670, 53);
            this.pnlPreviewTopContainer.TabIndex = 6;
            // 
            // pnlPreviewDescriptionContainer
            // 
            this.pnlPreviewDescriptionContainer.AutoSize = true;
            this.pnlPreviewDescriptionContainer.Controls.Add(this.rtbPreviewDescription);
            this.pnlPreviewDescriptionContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPreviewDescriptionContainer.Location = new System.Drawing.Point(3, 56);
            this.pnlPreviewDescriptionContainer.Name = "pnlPreviewDescriptionContainer";
            this.pnlPreviewDescriptionContainer.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnlPreviewDescriptionContainer.Size = new System.Drawing.Size(670, 23);
            this.pnlPreviewDescriptionContainer.TabIndex = 7;
            // 
            // pnlPreviewAnswerDetails
            // 
            this.pnlPreviewAnswerDetails.AutoSize = true;
            this.pnlPreviewAnswerDetails.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pnlPreviewAnswerDetails.Controls.Add(this.lblPreviewAditionalInfo);
            this.pnlPreviewAnswerDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPreviewAnswerDetails.Location = new System.Drawing.Point(3, 116);
            this.pnlPreviewAnswerDetails.MinimumSize = new System.Drawing.Size(0, 100);
            this.pnlPreviewAnswerDetails.Name = "pnlPreviewAnswerDetails";
            this.pnlPreviewAnswerDetails.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnlPreviewAnswerDetails.Size = new System.Drawing.Size(670, 100);
            this.pnlPreviewAnswerDetails.TabIndex = 8;
            this.pnlPreviewAnswerDetails.Visible = false;
            // 
            // lblPreviewAditionalInfo
            // 
            this.lblPreviewAditionalInfo.AutoSize = true;
            this.lblPreviewAditionalInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblPreviewAditionalInfo.Location = new System.Drawing.Point(8, 3);
            this.lblPreviewAditionalInfo.Name = "lblPreviewAditionalInfo";
            this.lblPreviewAditionalInfo.Size = new System.Drawing.Size(35, 13);
            this.lblPreviewAditionalInfo.TabIndex = 0;
            this.lblPreviewAditionalInfo.Text = "label3";
            // 
            // SingleChoiceTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 429);
            this.Controls.Add(this.tabContainer);
            this.Name = "SingleChoiceTemplate";
            this.Text = "SingleChoiceTemplate";
            this.Load += new System.EventHandler(this.SingleChoiceTemplate_Load);
            this.tabContainer.ResumeLayout(false);
            this.tabQandA.ResumeLayout(false);
            this.tabQandA.PerformLayout();
            this.pnlExplanation.ResumeLayout(false);
            this.pnlExplanation.PerformLayout();
            this.pnlAnswerContainer.ResumeLayout(false);
            this.pnlAnswerContainer.PerformLayout();
            this.pnlAnswerItemContainer.ResumeLayout(false);
            this.pnlAnswerItemContainer.PerformLayout();
            this.pnlDescription.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pnlPreviewAnswerContainer.ResumeLayout(false);
            this.pnlPreviewAnswerContainer.PerformLayout();
            this.pnlAnswerPreviewItemContainer.ResumeLayout(false);
            this.pnlAnswerPreviewItemContainer.PerformLayout();
            this.pnlPreviewTopContainer.ResumeLayout(false);
            this.pnlPreviewTopContainer.PerformLayout();
            this.pnlPreviewDescriptionContainer.ResumeLayout(false);
            this.pnlPreviewAnswerDetails.ResumeLayout(false);
            this.pnlPreviewAnswerDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabQandA;
        private System.Windows.Forms.Panel pnlDescription;
        private System.Windows.Forms.RichTextBox rtbQuestionText;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Panel pnlExplanation;
        private System.Windows.Forms.TextBox tbAditionalInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlAnswerContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblItemPaging;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnShowAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbPreviewDescription;
        private System.Windows.Forms.Panel pnlPreviewAnswerContainer;
        private System.Windows.Forms.Panel pnlAnswerItemContainer;
        private System.Windows.Forms.TextBox tbAnswerText1;
        private System.Windows.Forms.RadioButton btnChoice1;
        private System.Windows.Forms.Panel pnlAnswerPreviewItemContainer;
        private System.Windows.Forms.Label lblPreviewAnswerTextTemplate;
        private System.Windows.Forms.RadioButton rbPreviewAnswerItemTemplate;
        private System.Windows.Forms.Panel pnlPreviewTopContainer;
        private System.Windows.Forms.Panel pnlPreviewDescriptionContainer;
        private System.Windows.Forms.Panel pnlPreviewAnswerDetails;
        private System.Windows.Forms.Label lblPreviewAditionalInfo;
    }
}