
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Root");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XMLBrowserForm));
            this.InsertContentControlButton = new System.Windows.Forms.Button();
            this.ccListView = new System.Windows.Forms.ListView();
            this.contentControlHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mappingHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contentControlValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ccListView_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ccRemapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.customXML_treeView = new System.Windows.Forms.TreeView();
            this.customXMLPartsComboBox = new System.Windows.Forms.ComboBox();
            this.isOnTop_CheckBox = new System.Windows.Forms.CheckBox();
            this.ccListView_ContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InsertContentControlButton
            // 
            this.InsertContentControlButton.Location = new System.Drawing.Point(12, 12);
            this.InsertContentControlButton.Name = "InsertContentControlButton";
            this.InsertContentControlButton.Size = new System.Drawing.Size(162, 23);
            this.InsertContentControlButton.TabIndex = 4;
            this.InsertContentControlButton.Text = "Insert Content Control";
            this.InsertContentControlButton.UseVisualStyleBackColor = true;
            this.InsertContentControlButton.Click += new System.EventHandler(this.InsertContentControlButton_Click);
            // 
            // ccListView
            // 
            this.ccListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ccListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.contentControlHeader,
            this.mappingHeader,
            this.contentControlValue});
            this.ccListView.FullRowSelect = true;
            this.ccListView.GridLines = true;
            this.ccListView.HideSelection = false;
            this.ccListView.Location = new System.Drawing.Point(3, 3);
            this.ccListView.Name = "ccListView";
            this.ccListView.Size = new System.Drawing.Size(725, 553);
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
            // contentControlValue
            // 
            this.contentControlValue.Text = "Value";
            this.contentControlValue.Width = 253;
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
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 41);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.customXML_treeView);
            this.splitContainer1.Panel1.Controls.Add(this.customXMLPartsComboBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ccListView);
            this.splitContainer1.Size = new System.Drawing.Size(1400, 559);
            this.splitContainer1.SplitterDistance = 653;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 6;
            // 
            // customXML_treeView
            // 
            this.customXML_treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customXML_treeView.Location = new System.Drawing.Point(3, 33);
            this.customXML_treeView.Name = "customXML_treeView";
            treeNode1.Name = "Root";
            treeNode1.Text = "Root";
            this.customXML_treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.customXML_treeView.Size = new System.Drawing.Size(647, 523);
            this.customXML_treeView.TabIndex = 7;
            // 
            // customXMLPartsComboBox
            // 
            this.customXMLPartsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customXMLPartsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customXMLPartsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customXMLPartsComboBox.FormattingEnabled = true;
            this.customXMLPartsComboBox.Location = new System.Drawing.Point(0, 3);
            this.customXMLPartsComboBox.Name = "customXMLPartsComboBox";
            this.customXMLPartsComboBox.Size = new System.Drawing.Size(650, 24);
            this.customXMLPartsComboBox.TabIndex = 6;
            this.customXMLPartsComboBox.SelectedIndexChanged += new System.EventHandler(this.customXMLPartsComboBox_SelectedIndexChanged);
            // 
            // isOnTop_CheckBox
            // 
            this.isOnTop_CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isOnTop_CheckBox.AutoSize = true;
            this.isOnTop_CheckBox.Location = new System.Drawing.Point(1320, 12);
            this.isOnTop_CheckBox.Name = "isOnTop_CheckBox";
            this.isOnTop_CheckBox.Size = new System.Drawing.Size(92, 17);
            this.isOnTop_CheckBox.TabIndex = 7;
            this.isOnTop_CheckBox.Text = "Always on top";
            this.isOnTop_CheckBox.UseVisualStyleBackColor = true;
            this.isOnTop_CheckBox.CheckedChanged += new System.EventHandler(this.isOnTop_CheckBox_CheckedChanged);
            // 
            // XMLBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1424, 612);
            this.Controls.Add(this.isOnTop_CheckBox);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.InsertContentControlButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "XMLBrowserForm";
            this.Text = "XML Browser";
            this.TopMost = true;
            this.ccListView_ContextMenuStrip.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button InsertContentControlButton;
        private System.Windows.Forms.ListView ccListView;
        private System.Windows.Forms.ColumnHeader contentControlHeader;
        private System.Windows.Forms.ColumnHeader mappingHeader;
        private System.Windows.Forms.ContextMenuStrip ccListView_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ccRemapMenuItem;
        private System.Windows.Forms.ColumnHeader contentControlValue;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox customXMLPartsComboBox;
        private System.Windows.Forms.CheckBox isOnTop_CheckBox;
        private System.Windows.Forms.TreeView customXML_treeView;
    }
}