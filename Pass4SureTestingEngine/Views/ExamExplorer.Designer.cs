namespace Pass4SureTestingEngine.Views
{
    partial class ExamExplorer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Single Choice");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Multiple Choice");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Fill the blanks");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Drag And Drop");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Point and Shoot");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Hot Area");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Create a Tree");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Build List and reorder");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Drop And Connect");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Exam", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode11});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamExplorer));
            this.mnuRootContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExamContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCutExam = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyExam = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPasteExam = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteExam = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.trmiRenameExam = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestionContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveTo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiQuestionCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuestionCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuestionPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuestionDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewExam = new System.Windows.Forms.ToolStripButton();
            this.btnNewQuestion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMoveDown = new System.Windows.Forms.ToolStripButton();
            this.btnMoveUp = new System.Windows.Forms.ToolStripButton();
            this.mnuRootContextMenu.SuspendLayout();
            this.mnuExamContextMenu.SuspendLayout();
            this.mnuQuestionContextMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuRootContextMenu
            // 
            this.mnuRootContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newExamToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItem1});
            this.mnuRootContextMenu.Name = "mnuRootContextMenu";
            this.mnuRootContextMenu.Size = new System.Drawing.Size(130, 54);
            // 
            // newExamToolStripMenuItem
            // 
            this.newExamToolStripMenuItem.Name = "newExamToolStripMenuItem";
            this.newExamToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.newExamToolStripMenuItem.Text = "New Exam";
            this.newExamToolStripMenuItem.Click += new System.EventHandler(this.newExamToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(126, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.toolStripMenuItem1.Text = "Properties";
            // 
            // mnuExamContextMenu
            // 
            this.mnuExamContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripSeparator3,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripSeparator4,
            this.tsmiCutExam,
            this.tsmiCopyExam,
            this.tsmiPasteExam,
            this.tsmiDeleteExam,
            this.toolStripSeparator5,
            this.trmiRenameExam});
            this.mnuExamContextMenu.Name = "mnuExamContextMenu";
            this.mnuExamContextMenu.Size = new System.Drawing.Size(150, 198);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItem2.Text = "New Question";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(146, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItem3.Text = "Move Up";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItem4.Text = "Move Down";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(146, 6);
            // 
            // tsmiCutExam
            // 
            this.tsmiCutExam.Name = "tsmiCutExam";
            this.tsmiCutExam.Size = new System.Drawing.Size(149, 22);
            this.tsmiCutExam.Text = "Cut";
            this.tsmiCutExam.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // tsmiCopyExam
            // 
            this.tsmiCopyExam.Name = "tsmiCopyExam";
            this.tsmiCopyExam.Size = new System.Drawing.Size(149, 22);
            this.tsmiCopyExam.Text = "Copy";
            this.tsmiCopyExam.Click += new System.EventHandler(this.tsmiCopyExam_Click);
            // 
            // tsmiPasteExam
            // 
            this.tsmiPasteExam.Enabled = false;
            this.tsmiPasteExam.Name = "tsmiPasteExam";
            this.tsmiPasteExam.Size = new System.Drawing.Size(149, 22);
            this.tsmiPasteExam.Text = "Paste";
            this.tsmiPasteExam.Click += new System.EventHandler(this.tsmiPasteExam_Click);
            // 
            // tsmiDeleteExam
            // 
            this.tsmiDeleteExam.Name = "tsmiDeleteExam";
            this.tsmiDeleteExam.Size = new System.Drawing.Size(149, 22);
            this.tsmiDeleteExam.Text = "Delete";
            this.tsmiDeleteExam.Click += new System.EventHandler(this.tsmiDeleteExam_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(146, 6);
            // 
            // trmiRenameExam
            // 
            this.trmiRenameExam.Name = "trmiRenameExam";
            this.trmiRenameExam.Size = new System.Drawing.Size(149, 22);
            this.trmiRenameExam.Text = "Rename";
            this.trmiRenameExam.Click += new System.EventHandler(this.trmiRenameExam_Click);
            // 
            // mnuQuestionContextMenu
            // 
            this.mnuQuestionContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.tsmiMoveTo,
            this.toolStripSeparator7,
            this.tsmiQuestionCut,
            this.tsmiQuestionCopy,
            this.tsmiQuestionPaste,
            this.tsmiQuestionDelete,
            this.toolStripSeparator8,
            this.toolStripMenuItem17});
            this.mnuQuestionContextMenu.Name = "mnuExamContextMenu";
            this.mnuQuestionContextMenu.Size = new System.Drawing.Size(139, 192);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem11.Text = "Move Up";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem12.Text = "Move Down";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // tsmiMoveTo
            // 
            this.tsmiMoveTo.Name = "tsmiMoveTo";
            this.tsmiMoveTo.Size = new System.Drawing.Size(138, 22);
            this.tsmiMoveTo.Text = "Move To";
            this.tsmiMoveTo.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(135, 6);
            // 
            // tsmiQuestionCut
            // 
            this.tsmiQuestionCut.Name = "tsmiQuestionCut";
            this.tsmiQuestionCut.Size = new System.Drawing.Size(138, 22);
            this.tsmiQuestionCut.Text = "Cut";
            this.tsmiQuestionCut.Click += new System.EventHandler(this.tsmiQuestionCut_Click);
            // 
            // tsmiQuestionCopy
            // 
            this.tsmiQuestionCopy.Name = "tsmiQuestionCopy";
            this.tsmiQuestionCopy.Size = new System.Drawing.Size(138, 22);
            this.tsmiQuestionCopy.Text = "Copy";
            this.tsmiQuestionCopy.Click += new System.EventHandler(this.tsmiQuestionCopy_Click);
            // 
            // tsmiQuestionPaste
            // 
            this.tsmiQuestionPaste.Name = "tsmiQuestionPaste";
            this.tsmiQuestionPaste.Size = new System.Drawing.Size(138, 22);
            this.tsmiQuestionPaste.Text = "Paste";
            this.tsmiQuestionPaste.Click += new System.EventHandler(this.tsmiQuestionPaste_Click);
            // 
            // tsmiQuestionDelete
            // 
            this.tsmiQuestionDelete.Name = "tsmiQuestionDelete";
            this.tsmiQuestionDelete.Size = new System.Drawing.Size(138, 22);
            this.tsmiQuestionDelete.Text = "Delete";
            this.tsmiQuestionDelete.Click += new System.EventHandler(this.tsmiQuestionDelete_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(135, 6);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem17.Text = "Properties";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 259);
            this.panel1.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 25);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Single Choice";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Multiple Choice";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Fill the blanks";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Drag And Drop";
            treeNode5.Name = "Node2";
            treeNode5.Text = "Point and Shoot";
            treeNode6.Name = "Node3";
            treeNode6.Text = "Hot Area";
            treeNode7.Name = "Node4";
            treeNode7.Text = "Create a Tree";
            treeNode8.Name = "Node6";
            treeNode8.Text = "Build List and reorder";
            treeNode9.Name = "Node0";
            treeNode9.Text = "Drop And Connect";
            treeNode10.Name = "Node1";
            treeNode10.Text = "Node1";
            treeNode11.Name = "Node0";
            treeNode11.Text = "Node0";
            treeNode12.Name = "Node0";
            treeNode12.Text = "Exam";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(184, 234);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewExam,
            this.btnNewQuestion,
            this.toolStripSeparator1,
            this.btnMoveDown,
            this.btnMoveUp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(184, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewExam
            // 
            this.btnNewExam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewExam.Image = ((System.Drawing.Image)(resources.GetObject("btnNewExam.Image")));
            this.btnNewExam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewExam.Name = "btnNewExam";
            this.btnNewExam.Size = new System.Drawing.Size(23, 22);
            this.btnNewExam.Text = "toolStripButton1";
            this.btnNewExam.ToolTipText = "New Exam";
            this.btnNewExam.Click += new System.EventHandler(this.btnNewExam_Click);
            // 
            // btnNewQuestion
            // 
            this.btnNewQuestion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnNewQuestion.Image")));
            this.btnNewQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewQuestion.Name = "btnNewQuestion";
            this.btnNewQuestion.Size = new System.Drawing.Size(23, 22);
            this.btnNewQuestion.Text = "toolStripButton2";
            this.btnNewQuestion.ToolTipText = "New Question";
            this.btnNewQuestion.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveDown.Image")));
            this.btnMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(23, 22);
            this.btnMoveDown.Text = "toolStripButton3";
            this.btnMoveDown.ToolTipText = "Move Down";
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveUp.Image")));
            this.btnMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(23, 22);
            this.btnMoveUp.Text = "toolStripButton4";
            this.btnMoveUp.ToolTipText = "Move Up";
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // ExamExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 259);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "ExamExplorer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Exam Explorer";
            this.Load += new System.EventHandler(this.ExamExplorer_Load);
            this.mnuRootContextMenu.ResumeLayout(false);
            this.mnuExamContextMenu.ResumeLayout(false);
            this.mnuQuestionContextMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip mnuRootContextMenu;
        private System.Windows.Forms.ToolStripMenuItem newExamToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip mnuExamContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiCutExam;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyExam;
        private System.Windows.Forms.ToolStripMenuItem tsmiPasteExam;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteExam;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem trmiRenameExam;
        private System.Windows.Forms.ContextMenuStrip mnuQuestionContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuestionCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuestionCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuestionPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuestionDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveTo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNewExam;
        private System.Windows.Forms.ToolStripButton btnNewQuestion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnMoveDown;
        private System.Windows.Forms.ToolStripButton btnMoveUp;
    }
}