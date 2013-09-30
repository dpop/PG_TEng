namespace Pass4SureTestingEngine.Views.QuestionTypes
{
    partial class FillInTheBlanksTemplate
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
            this.pnlExplanationContainer = new System.Windows.Forms.Panel();
            this.rtbExplanation = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAnswerContainer = new System.Windows.Forms.Panel();
            this.tbCorrectAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QuestionTextContainer = new System.Windows.Forms.Panel();
            this.rtbQuestionDescription = new System.Windows.Forms.RichTextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlPreviewAnswerDetails = new System.Windows.Forms.Panel();
            this.rtbPreviewAnswer = new System.Windows.Forms.RichTextBox();
            this.pnlCorrectAnswer = new System.Windows.Forms.Panel();
            this.tbPreviewCorrectAnswer = new System.Windows.Forms.TextBox();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.pnlPreviewDescriptionContainer = new System.Windows.Forms.Panel();
            this.rtbPreviewDescription = new System.Windows.Forms.RichTextBox();
            this.pnlPreviewTopContainer = new System.Windows.Forms.Panel();
            this.lblItemPaging = new System.Windows.Forms.Label();
            this.btnShowAnswer = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabContainer.SuspendLayout();
            this.tabQandA.SuspendLayout();
            this.pnlExplanationContainer.SuspendLayout();
            this.pnlAnswerContainer.SuspendLayout();
            this.QuestionTextContainer.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlPreviewAnswerDetails.SuspendLayout();
            this.pnlCorrectAnswer.SuspendLayout();
            this.pnlPreviewDescriptionContainer.SuspendLayout();
            this.pnlPreviewTopContainer.SuspendLayout();
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
            this.tabContainer.Size = new System.Drawing.Size(687, 417);
            this.tabContainer.TabIndex = 2;
            // 
            // tabQandA
            // 
            this.tabQandA.AutoScroll = true;
            this.tabQandA.Controls.Add(this.pnlExplanationContainer);
            this.tabQandA.Controls.Add(this.pnlAnswerContainer);
            this.tabQandA.Controls.Add(this.QuestionTextContainer);
            this.tabQandA.Location = new System.Drawing.Point(4, 4);
            this.tabQandA.Name = "tabQandA";
            this.tabQandA.Padding = new System.Windows.Forms.Padding(8);
            this.tabQandA.Size = new System.Drawing.Size(679, 391);
            this.tabQandA.TabIndex = 0;
            this.tabQandA.Text = "Questions and Answers";
            this.tabQandA.UseVisualStyleBackColor = true;
            // 
            // pnlExplanationContainer
            // 
            this.pnlExplanationContainer.AutoSize = true;
            this.pnlExplanationContainer.Controls.Add(this.rtbExplanation);
            this.pnlExplanationContainer.Controls.Add(this.label2);
            this.pnlExplanationContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExplanationContainer.Location = new System.Drawing.Point(8, 122);
            this.pnlExplanationContainer.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.pnlExplanationContainer.Name = "pnlExplanationContainer";
            this.pnlExplanationContainer.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.pnlExplanationContainer.Size = new System.Drawing.Size(663, 57);
            this.pnlExplanationContainer.TabIndex = 5;
            // 
            // rtbExplanation
            // 
            this.rtbExplanation.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbExplanation.Location = new System.Drawing.Point(0, 31);
            this.rtbExplanation.Name = "rtbExplanation";
            this.rtbExplanation.Size = new System.Drawing.Size(663, 20);
            this.rtbExplanation.TabIndex = 6;
            this.rtbExplanation.Text = "";
            this.rtbExplanation.TextChanged += new System.EventHandler(this.ExplanationTextChanged);
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
            this.label2.Size = new System.Drawing.Size(663, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Explanation/Referance";
            // 
            // pnlAnswerContainer
            // 
            this.pnlAnswerContainer.AutoSize = true;
            this.pnlAnswerContainer.Controls.Add(this.tbCorrectAnswer);
            this.pnlAnswerContainer.Controls.Add(this.label1);
            this.pnlAnswerContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAnswerContainer.Location = new System.Drawing.Point(8, 65);
            this.pnlAnswerContainer.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.pnlAnswerContainer.Name = "pnlAnswerContainer";
            this.pnlAnswerContainer.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.pnlAnswerContainer.Size = new System.Drawing.Size(663, 57);
            this.pnlAnswerContainer.TabIndex = 3;
            // 
            // tbCorrectAnswer
            // 
            this.tbCorrectAnswer.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbCorrectAnswer.Location = new System.Drawing.Point(0, 31);
            this.tbCorrectAnswer.Multiline = true;
            this.tbCorrectAnswer.Name = "tbCorrectAnswer";
            this.tbCorrectAnswer.Size = new System.Drawing.Size(663, 20);
            this.tbCorrectAnswer.TabIndex = 3;
            this.tbCorrectAnswer.TextChanged += new System.EventHandler(this.CorrectAnswerTextChanged);
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
            this.label1.Size = new System.Drawing.Size(663, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Correct Answer(s)";
            // 
            // QuestionTextContainer
            // 
            this.QuestionTextContainer.AutoSize = true;
            this.QuestionTextContainer.Controls.Add(this.rtbQuestionDescription);
            this.QuestionTextContainer.Controls.Add(this.lblQuestion);
            this.QuestionTextContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.QuestionTextContainer.Location = new System.Drawing.Point(8, 8);
            this.QuestionTextContainer.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.QuestionTextContainer.Name = "QuestionTextContainer";
            this.QuestionTextContainer.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.QuestionTextContainer.Size = new System.Drawing.Size(663, 57);
            this.QuestionTextContainer.TabIndex = 1;
            // 
            // rtbQuestionDescription
            // 
            this.rtbQuestionDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbQuestionDescription.Location = new System.Drawing.Point(0, 31);
            this.rtbQuestionDescription.Name = "rtbQuestionDescription";
            this.rtbQuestionDescription.Size = new System.Drawing.Size(663, 20);
            this.rtbQuestionDescription.TabIndex = 4;
            this.rtbQuestionDescription.Text = "";
            this.rtbQuestionDescription.TextChanged += new System.EventHandler(this.DescriptionTextChanged);
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Gray;
            this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblQuestion.Location = new System.Drawing.Point(0, 6);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Padding = new System.Windows.Forms.Padding(4);
            this.lblQuestion.Size = new System.Drawing.Size(663, 25);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.Text = "Question:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlPreviewAnswerDetails);
            this.tabPage2.Controls.Add(this.pnlCorrectAnswer);
            this.tabPage2.Controls.Add(this.pnlPreviewDescriptionContainer);
            this.tabPage2.Controls.Add(this.pnlPreviewTopContainer);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(679, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Preview";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // pnlPreviewAnswerDetails
            // 
            this.pnlPreviewAnswerDetails.AutoSize = true;
            this.pnlPreviewAnswerDetails.BackColor = System.Drawing.SystemColors.Info;
            this.pnlPreviewAnswerDetails.Controls.Add(this.rtbPreviewAnswer);
            this.pnlPreviewAnswerDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPreviewAnswerDetails.Location = new System.Drawing.Point(3, 103);
            this.pnlPreviewAnswerDetails.Name = "pnlPreviewAnswerDetails";
            this.pnlPreviewAnswerDetails.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnlPreviewAnswerDetails.Size = new System.Drawing.Size(673, 100);
            this.pnlPreviewAnswerDetails.TabIndex = 10;
            this.pnlPreviewAnswerDetails.Visible = false;
            // 
            // rtbPreviewAnswer
            // 
            this.rtbPreviewAnswer.BackColor = System.Drawing.SystemColors.Info;
            this.rtbPreviewAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPreviewAnswer.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbPreviewAnswer.Location = new System.Drawing.Point(3, 0);
            this.rtbPreviewAnswer.MinimumSize = new System.Drawing.Size(0, 100);
            this.rtbPreviewAnswer.Name = "rtbPreviewAnswer";
            this.rtbPreviewAnswer.Size = new System.Drawing.Size(670, 100);
            this.rtbPreviewAnswer.TabIndex = 0;
            this.rtbPreviewAnswer.Text = "";
            // 
            // pnlCorrectAnswer
            // 
            this.pnlCorrectAnswer.AutoSize = true;
            this.pnlCorrectAnswer.Controls.Add(this.tbPreviewCorrectAnswer);
            this.pnlCorrectAnswer.Controls.Add(this.lblCorrectAnswer);
            this.pnlCorrectAnswer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCorrectAnswer.Location = new System.Drawing.Point(3, 73);
            this.pnlCorrectAnswer.Name = "pnlCorrectAnswer";
            this.pnlCorrectAnswer.Size = new System.Drawing.Size(673, 30);
            this.pnlCorrectAnswer.TabIndex = 11;
            // 
            // tbPreviewCorrectAnswer
            // 
            this.tbPreviewCorrectAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPreviewCorrectAnswer.Location = new System.Drawing.Point(123, 7);
            this.tbPreviewCorrectAnswer.Name = "tbPreviewCorrectAnswer";
            this.tbPreviewCorrectAnswer.Size = new System.Drawing.Size(544, 20);
            this.tbPreviewCorrectAnswer.TabIndex = 1;
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCorrectAnswer.Location = new System.Drawing.Point(4, 7);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(112, 17);
            this.lblCorrectAnswer.TabIndex = 0;
            this.lblCorrectAnswer.Text = "Your Response:";
            // 
            // pnlPreviewDescriptionContainer
            // 
            this.pnlPreviewDescriptionContainer.AutoSize = true;
            this.pnlPreviewDescriptionContainer.Controls.Add(this.rtbPreviewDescription);
            this.pnlPreviewDescriptionContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPreviewDescriptionContainer.Location = new System.Drawing.Point(3, 56);
            this.pnlPreviewDescriptionContainer.Name = "pnlPreviewDescriptionContainer";
            this.pnlPreviewDescriptionContainer.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pnlPreviewDescriptionContainer.Size = new System.Drawing.Size(673, 17);
            this.pnlPreviewDescriptionContainer.TabIndex = 9;
            // 
            // rtbPreviewDescription
            // 
            this.rtbPreviewDescription.BackColor = System.Drawing.SystemColors.Window;
            this.rtbPreviewDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPreviewDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbPreviewDescription.Location = new System.Drawing.Point(3, 0);
            this.rtbPreviewDescription.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rtbPreviewDescription.Name = "rtbPreviewDescription";
            this.rtbPreviewDescription.ReadOnly = true;
            this.rtbPreviewDescription.Size = new System.Drawing.Size(667, 17);
            this.rtbPreviewDescription.TabIndex = 4;
            this.rtbPreviewDescription.Text = "";
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
            this.pnlPreviewTopContainer.Size = new System.Drawing.Size(673, 53);
            this.pnlPreviewTopContainer.TabIndex = 8;
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
            // btnShowAnswer
            // 
            this.btnShowAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAnswer.Location = new System.Drawing.Point(490, 5);
            this.btnShowAnswer.Name = "btnShowAnswer";
            this.btnShowAnswer.Size = new System.Drawing.Size(91, 23);
            this.btnShowAnswer.TabIndex = 1;
            this.btnShowAnswer.Text = "Show Answer";
            this.btnShowAnswer.UseVisualStyleBackColor = true;
            this.btnShowAnswer.Click += new System.EventHandler(this.btnShowAnswer_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculator.Location = new System.Drawing.Point(587, 5);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(75, 23);
            this.btnCalculator.TabIndex = 2;
            this.btnCalculator.Text = "Calculator";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(5, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(673, 2);
            this.label4.TabIndex = 3;
            // 
            // FillInTheBlanksTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 417);
            this.Controls.Add(this.tabContainer);
            this.Name = "FillInTheBlanksTemplate";
            this.Text = "FillInTheBlanksTemplate";
            this.tabContainer.ResumeLayout(false);
            this.tabQandA.ResumeLayout(false);
            this.tabQandA.PerformLayout();
            this.pnlExplanationContainer.ResumeLayout(false);
            this.pnlAnswerContainer.ResumeLayout(false);
            this.pnlAnswerContainer.PerformLayout();
            this.QuestionTextContainer.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pnlPreviewAnswerDetails.ResumeLayout(false);
            this.pnlCorrectAnswer.ResumeLayout(false);
            this.pnlCorrectAnswer.PerformLayout();
            this.pnlPreviewDescriptionContainer.ResumeLayout(false);
            this.pnlPreviewTopContainer.ResumeLayout(false);
            this.pnlPreviewTopContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage tabQandA;
        private System.Windows.Forms.Panel pnlExplanationContainer;
        private System.Windows.Forms.Panel pnlAnswerContainer;
        private System.Windows.Forms.Panel QuestionTextContainer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbCorrectAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RichTextBox rtbQuestionDescription;
        private System.Windows.Forms.RichTextBox rtbExplanation;
        private System.Windows.Forms.Panel pnlPreviewTopContainer;
        private System.Windows.Forms.Label lblItemPaging;
        private System.Windows.Forms.Button btnShowAnswer;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlPreviewDescriptionContainer;
        private System.Windows.Forms.RichTextBox rtbPreviewDescription;
        private System.Windows.Forms.Panel pnlCorrectAnswer;
        private System.Windows.Forms.Panel pnlPreviewAnswerDetails;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.TextBox tbPreviewCorrectAnswer;
        private System.Windows.Forms.RichTextBox rtbPreviewAnswer;

    }
}