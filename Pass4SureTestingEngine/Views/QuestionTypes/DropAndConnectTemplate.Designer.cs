namespace Pass4SureTestingEngine.Views.QuestionTypes
{
    partial class DropAndConnectTemplate
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlObjectCreator = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbObjectContainer = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlQuestionContainer = new System.Windows.Forms.Panel();
            this.pnlQuestionExplanation = new System.Windows.Forms.Panel();
            this.rtbQuestionExplanation = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlQuestionDescription = new System.Windows.Forms.Panel();
            this.rtbQuestionDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tabContainer.SuspendLayout();
            this.tabQandA.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlObjectCreator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbObjectContainer)).BeginInit();
            this.pnlQuestionContainer.SuspendLayout();
            this.pnlQuestionExplanation.SuspendLayout();
            this.pnlQuestionDescription.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabContainer.Size = new System.Drawing.Size(514, 413);
            this.tabContainer.TabIndex = 7;
            // 
            // tabQandA
            // 
            this.tabQandA.AutoScroll = true;
            this.tabQandA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabQandA.Controls.Add(this.panel2);
            this.tabQandA.Controls.Add(this.splitter1);
            this.tabQandA.Controls.Add(this.pnlQuestionContainer);
            this.tabQandA.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabQandA.Location = new System.Drawing.Point(4, 4);
            this.tabQandA.Name = "tabQandA";
            this.tabQandA.Padding = new System.Windows.Forms.Padding(8);
            this.tabQandA.Size = new System.Drawing.Size(506, 387);
            this.tabQandA.TabIndex = 0;
            this.tabQandA.Text = "Questions and Answers";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pnlObjectCreator);
            this.panel2.Controls.Add(this.pbObjectContainer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(8, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 234);
            this.panel2.TabIndex = 2;
            // 
            // pnlObjectCreator
            // 
            this.pnlObjectCreator.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlObjectCreator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlObjectCreator.Controls.Add(this.listBox1);
            this.pnlObjectCreator.Controls.Add(this.label5);
            this.pnlObjectCreator.Location = new System.Drawing.Point(257, 17);
            this.pnlObjectCreator.Name = "pnlObjectCreator";
            this.pnlObjectCreator.Size = new System.Drawing.Size(159, 167);
            this.pnlObjectCreator.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(125, 121);
            this.listBox1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Connectors :";
            // 
            // pbObjectContainer
            // 
            this.pbObjectContainer.BackColor = System.Drawing.SystemColors.Window;
            this.pbObjectContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbObjectContainer.Location = new System.Drawing.Point(0, 0);
            this.pbObjectContainer.Name = "pbObjectContainer";
            this.pbObjectContainer.Size = new System.Drawing.Size(486, 230);
            this.pbObjectContainer.TabIndex = 0;
            this.pbObjectContainer.TabStop = false;
            this.pbObjectContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pbObjectContainer_Paint);
            this.pbObjectContainer.Resize += new System.EventHandler(this.pbObjectContainer_Resize);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(8, 143);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(490, 2);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnlQuestionContainer
            // 
            this.pnlQuestionContainer.AutoScroll = true;
            this.pnlQuestionContainer.BackColor = System.Drawing.SystemColors.Window;
            this.pnlQuestionContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlQuestionContainer.Controls.Add(this.pnlQuestionExplanation);
            this.pnlQuestionContainer.Controls.Add(this.pnlQuestionDescription);
            this.pnlQuestionContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuestionContainer.Location = new System.Drawing.Point(8, 8);
            this.pnlQuestionContainer.Name = "pnlQuestionContainer";
            this.pnlQuestionContainer.Size = new System.Drawing.Size(490, 135);
            this.pnlQuestionContainer.TabIndex = 0;
            // 
            // pnlQuestionExplanation
            // 
            this.pnlQuestionExplanation.AutoSize = true;
            this.pnlQuestionExplanation.Controls.Add(this.rtbQuestionExplanation);
            this.pnlQuestionExplanation.Controls.Add(this.label1);
            this.pnlQuestionExplanation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuestionExplanation.Location = new System.Drawing.Point(0, 45);
            this.pnlQuestionExplanation.Name = "pnlQuestionExplanation";
            this.pnlQuestionExplanation.Size = new System.Drawing.Size(486, 45);
            this.pnlQuestionExplanation.TabIndex = 18;
            // 
            // rtbQuestionExplanation
            // 
            this.rtbQuestionExplanation.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbQuestionExplanation.Location = new System.Drawing.Point(0, 25);
            this.rtbQuestionExplanation.Name = "rtbQuestionExplanation";
            this.rtbQuestionExplanation.Size = new System.Drawing.Size(486, 20);
            this.rtbQuestionExplanation.TabIndex = 17;
            this.rtbQuestionExplanation.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(486, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Explanation/Referance";
            // 
            // pnlQuestionDescription
            // 
            this.pnlQuestionDescription.AutoSize = true;
            this.pnlQuestionDescription.Controls.Add(this.rtbQuestionDescription);
            this.pnlQuestionDescription.Controls.Add(this.label4);
            this.pnlQuestionDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuestionDescription.Location = new System.Drawing.Point(0, 0);
            this.pnlQuestionDescription.Name = "pnlQuestionDescription";
            this.pnlQuestionDescription.Size = new System.Drawing.Size(486, 45);
            this.pnlQuestionDescription.TabIndex = 17;
            // 
            // rtbQuestionDescription
            // 
            this.rtbQuestionDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbQuestionDescription.Location = new System.Drawing.Point(0, 25);
            this.rtbQuestionDescription.Name = "rtbQuestionDescription";
            this.rtbQuestionDescription.Size = new System.Drawing.Size(486, 20);
            this.rtbQuestionDescription.TabIndex = 18;
            this.rtbQuestionDescription.Text = "";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(4);
            this.label4.Size = new System.Drawing.Size(486, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Question:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(506, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Preview";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4);
            this.label3.Size = new System.Drawing.Size(500, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Under Construction";
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
            this.lblQuestion.Size = new System.Drawing.Size(486, 25);
            this.lblQuestion.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox3.Location = new System.Drawing.Point(0, 25);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(486, 20);
            this.textBox3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(0, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4);
            this.label2.Size = new System.Drawing.Size(486, 25);
            this.label2.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox5.Location = new System.Drawing.Point(0, 70);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(486, 20);
            this.textBox5.TabIndex = 12;
            // 
            // DropAndConnectTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 413);
            this.Controls.Add(this.tabContainer);
            this.Name = "DropAndConnectTemplate";
            this.Text = "DropAndConnectTemplate";
            this.Load += new System.EventHandler(this.DropAndConnectTemplate_Load);
            this.tabContainer.ResumeLayout(false);
            this.tabQandA.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlObjectCreator.ResumeLayout(false);
            this.pnlObjectCreator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbObjectContainer)).EndInit();
            this.pnlQuestionContainer.ResumeLayout(false);
            this.pnlQuestionContainer.PerformLayout();
            this.pnlQuestionExplanation.ResumeLayout(false);
            this.pnlQuestionDescription.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage tabQandA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlQuestionContainer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Panel pnlObjectCreator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbObjectContainer;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel pnlQuestionDescription;
        private System.Windows.Forms.RichTextBox rtbQuestionDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlQuestionExplanation;
        private System.Windows.Forms.RichTextBox rtbQuestionExplanation;
        private System.Windows.Forms.Label label1;
    }
}