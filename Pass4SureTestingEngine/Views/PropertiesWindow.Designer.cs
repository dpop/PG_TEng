namespace Pass4SureTestingEngine.Views
{
    partial class PropertiesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertiesWindow));
            this.pgxPropertyGrid = new PropertyGridEx.PropertyGridEx();
            this.SuspendLayout();
            // 
            // pgxPropertyGrid
            // 
            // 
            // 
            // 
            this.pgxPropertyGrid.DocCommentDescription.AccessibleName = "";
            this.pgxPropertyGrid.DocCommentDescription.AutoEllipsis = true;
            this.pgxPropertyGrid.DocCommentDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.pgxPropertyGrid.DocCommentDescription.Location = new System.Drawing.Point(3, 18);
            this.pgxPropertyGrid.DocCommentDescription.Name = "";
            this.pgxPropertyGrid.DocCommentDescription.Size = new System.Drawing.Size(178, 37);
            this.pgxPropertyGrid.DocCommentDescription.TabIndex = 1;
            this.pgxPropertyGrid.DocCommentImage = null;
            // 
            // 
            // 
            this.pgxPropertyGrid.DocCommentTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.pgxPropertyGrid.DocCommentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.pgxPropertyGrid.DocCommentTitle.Location = new System.Drawing.Point(3, 3);
            this.pgxPropertyGrid.DocCommentTitle.Name = "";
            this.pgxPropertyGrid.DocCommentTitle.Size = new System.Drawing.Size(178, 15);
            this.pgxPropertyGrid.DocCommentTitle.TabIndex = 0;
            this.pgxPropertyGrid.DocCommentTitle.UseMnemonic = false;
            this.pgxPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgxPropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.pgxPropertyGrid.Name = "pgxPropertyGrid";
            this.pgxPropertyGrid.SelectedObject = ((object)(resources.GetObject("pgxPropertyGrid.SelectedObject")));
            this.pgxPropertyGrid.ShowCustomProperties = true;
            this.pgxPropertyGrid.Size = new System.Drawing.Size(184, 246);
            this.pgxPropertyGrid.TabIndex = 1;
            // 
            // 
            // 
            this.pgxPropertyGrid.ToolStrip.AccessibleName = "ToolBar";
            this.pgxPropertyGrid.ToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.pgxPropertyGrid.ToolStrip.AllowMerge = false;
            this.pgxPropertyGrid.ToolStrip.AutoSize = false;
            this.pgxPropertyGrid.ToolStrip.CanOverflow = false;
            this.pgxPropertyGrid.ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.pgxPropertyGrid.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.pgxPropertyGrid.ToolStrip.Location = new System.Drawing.Point(0, 1);
            this.pgxPropertyGrid.ToolStrip.Name = "";
            this.pgxPropertyGrid.ToolStrip.Padding = new System.Windows.Forms.Padding(2, 0, 1, 0);
            this.pgxPropertyGrid.ToolStrip.Size = new System.Drawing.Size(184, 25);
            this.pgxPropertyGrid.ToolStrip.TabIndex = 1;
            this.pgxPropertyGrid.ToolStrip.TabStop = true;
            this.pgxPropertyGrid.ToolStrip.Text = "PropertyGridToolBar";
            this.pgxPropertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgxPropertyGrid_PropertyValueChanged);
            this.pgxPropertyGrid.SelectedGridItemChanged += new System.Windows.Forms.SelectedGridItemChangedEventHandler(this.pgxPropertyGrid_SelectedGridItemChanged);
            // 
            // PropertiesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 246);
            this.Controls.Add(this.pgxPropertyGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "PropertiesWindow";
            this.Text = "Properties";
            this.Load += new System.EventHandler(this.PropertiesWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PropertyGridEx.PropertyGridEx pgxPropertyGrid;


    }
}