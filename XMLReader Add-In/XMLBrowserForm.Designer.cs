
namespace XMLReader_Add_In
{
    partial class XMLBrowserForm
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
            System.Windows.Forms.Label XMLDescription;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XMLBrowserForm));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.XMLNodeValueLabel = new System.Windows.Forms.Label();
            this.InsertContentControlButton = new System.Windows.Forms.Button();
            this.ListViewXMLParts = new System.Windows.Forms.ListView();
            this.columnNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValueHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTagHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ccListView = new System.Windows.Forms.ListView();
            this.contentControlHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mappingHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ccListView_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ccRemapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentControlValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            XMLDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ccListView_ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // XMLDescription
            // 
            XMLDescription.AutoSize = true;
            XMLDescription.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            XMLDescription.Location = new System.Drawing.Point(12, 9);
            XMLDescription.Name = "XMLDescription";
            XMLDescription.Size = new System.Drawing.Size(126, 18);
            XMLDescription.TabIndex = 2;
            XMLDescription.Text = "Project Info XML ...";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(437, 526);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // XMLNodeValueLabel
            // 
            this.XMLNodeValueLabel.AutoSize = true;
            this.XMLNodeValueLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XMLNodeValueLabel.Location = new System.Drawing.Point(180, 47);
            this.XMLNodeValueLabel.Name = "XMLNodeValueLabel";
            this.XMLNodeValueLabel.Size = new System.Drawing.Size(173, 18);
            this.XMLNodeValueLabel.TabIndex = 3;
            this.XMLNodeValueLabel.Text = "Valoare preluata din XML";
            // 
            // InsertContentControlButton
            // 
            this.InsertContentControlButton.Location = new System.Drawing.Point(12, 45);
            this.InsertContentControlButton.Name = "InsertContentControlButton";
            this.InsertContentControlButton.Size = new System.Drawing.Size(162, 23);
            this.InsertContentControlButton.TabIndex = 4;
            this.InsertContentControlButton.Text = "Insert Content Control";
            this.InsertContentControlButton.UseVisualStyleBackColor = true;
            this.InsertContentControlButton.Click += new System.EventHandler(this.InsertContentControlButton_Click);
            // 
            // ListViewXMLParts
            // 
            this.ListViewXMLParts.AllowDrop = true;
            this.ListViewXMLParts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewXMLParts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewXMLParts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameHeader,
            this.columnValueHeader,
            this.columnTagHeader});
            this.ListViewXMLParts.FullRowSelect = true;
            this.ListViewXMLParts.GridLines = true;
            this.ListViewXMLParts.HideSelection = false;
            this.ListViewXMLParts.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ListViewXMLParts.Location = new System.Drawing.Point(0, 0);
            this.ListViewXMLParts.Name = "ListViewXMLParts";
            this.ListViewXMLParts.Size = new System.Drawing.Size(484, 526);
            this.ListViewXMLParts.TabIndex = 5;
            this.ListViewXMLParts.TileSize = new System.Drawing.Size(50, 50);
            this.ListViewXMLParts.UseCompatibleStateImageBehavior = false;
            this.ListViewXMLParts.View = System.Windows.Forms.View.Details;
            // 
            // columnNameHeader
            // 
            this.columnNameHeader.Text = "Parameter name";
            this.columnNameHeader.Width = 115;
            // 
            // columnValueHeader
            // 
            this.columnValueHeader.Text = "Value";
            this.columnValueHeader.Width = 127;
            // 
            // columnTagHeader
            // 
            this.columnTagHeader.Text = "Tag";
            this.columnTagHeader.Width = 172;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 74);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ListViewXMLParts);
            this.splitContainer1.Size = new System.Drawing.Size(939, 526);
            this.splitContainer1.SplitterDistance = 440;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 6;
            // 
            // ccListView
            // 
            this.ccListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ccListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.contentControlHeader,
            this.mappingHeader,
            this.contentControlValue});
            this.ccListView.FullRowSelect = true;
            this.ccListView.GridLines = true;
            this.ccListView.HideSelection = false;
            this.ccListView.Location = new System.Drawing.Point(957, 74);
            this.ccListView.Name = "ccListView";
            this.ccListView.Size = new System.Drawing.Size(455, 526);
            this.ccListView.TabIndex = 7;
            this.ccListView.UseCompatibleStateImageBehavior = false;
            this.ccListView.View = System.Windows.Forms.View.Details;
            // 
            // contentControlHeader
            // 
            this.contentControlHeader.Text = "Title";
            this.contentControlHeader.Width = 104;
            // 
            // mappingHeader
            // 
            this.mappingHeader.Text = "Mapping";
            this.mappingHeader.Width = 84;
            // 
            // ccListView_ContextMenuStrip
            // 
            this.ccListView_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ccRemapMenuItem});
            this.ccListView_ContextMenuStrip.Name = "ccListView_ContextMenuStrip";
            this.ccListView_ContextMenuStrip.ShowImageMargin = false;
            this.ccListView_ContextMenuStrip.Size = new System.Drawing.Size(140, 26);
            this.ccListView_ContextMenuStrip.Text = "Options";
            // 
            // ccRemapMenuItem
            // 
            this.ccRemapMenuItem.AutoSize = false;
            this.ccRemapMenuItem.Checked = true;
            this.ccRemapMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ccRemapMenuItem.Image = global::XMLReader_Add_In.Properties.Resources.link_16px_16px;
            this.ccRemapMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ccRemapMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.ccRemapMenuItem.Name = "ccRemapMenuItem";
            this.ccRemapMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.ccRemapMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ccRemapMenuItem.Text = "Remap ...";
            this.ccRemapMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ccRemapMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ccRemapMenuItem.Click += new System.EventHandler(this.ccRemapMenuItem_Click);
            // 
            // contentControlValue
            // 
            this.contentControlValue.Text = "Value";
            this.contentControlValue.Width = 253;
            // 
            // XMLBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1424, 612);
            this.Controls.Add(this.ccListView);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.InsertContentControlButton);
            this.Controls.Add(this.XMLNodeValueLabel);
            this.Controls.Add(XMLDescription);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XMLBrowserForm";
            this.Text = "XML Browser";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ccListView_ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label XMLNodeValueLabel;
        private System.Windows.Forms.Button InsertContentControlButton;
        private System.Windows.Forms.ListView ListViewXMLParts;
        private System.Windows.Forms.ColumnHeader columnNameHeader;
        private System.Windows.Forms.ColumnHeader columnValueHeader;
        private System.Windows.Forms.ColumnHeader columnTagHeader;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView ccListView;
        private System.Windows.Forms.ColumnHeader contentControlHeader;
        private System.Windows.Forms.ColumnHeader mappingHeader;
        private System.Windows.Forms.ContextMenuStrip ccListView_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ccRemapMenuItem;
        private System.Windows.Forms.ColumnHeader contentControlValue;
    }
}