namespace Pass4SureTestingEngine.Views
{
    partial class MoveToView
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbExams = new System.Windows.Forms.ComboBox();
            this.cbTestlet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMove = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exam:";
            // 
            // cbExams
            // 
            this.cbExams.FormattingEnabled = true;
            this.cbExams.Location = new System.Drawing.Point(151, 18);
            this.cbExams.Name = "cbExams";
            this.cbExams.Size = new System.Drawing.Size(171, 21);
            this.cbExams.TabIndex = 1;
            // 
            // cbTestlet
            // 
            this.cbTestlet.Enabled = false;
            this.cbTestlet.FormattingEnabled = true;
            this.cbTestlet.Location = new System.Drawing.Point(151, 45);
            this.cbTestlet.Name = "cbTestlet";
            this.cbTestlet.Size = new System.Drawing.Size(171, 21);
            this.cbTestlet.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Testlet/question set";
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(151, 72);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(78, 23);
            this.btnMove.TabIndex = 4;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(244, 72);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(78, 23);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // MoveToView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 112);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.cbTestlet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbExams);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoveToView";
            this.Text = "Move To";
            this.Load += new System.EventHandler(this.MoveToView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbExams;
        private System.Windows.Forms.ComboBox cbTestlet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button BtnClose;
    }
}