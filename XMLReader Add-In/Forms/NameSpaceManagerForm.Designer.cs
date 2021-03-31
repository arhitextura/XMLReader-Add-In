
namespace XMLReader_Add_In.Forms
{
    partial class NameSpaceManagerForm
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
            this.nameSpaceListView = new System.Windows.Forms.ListView();
            this.nameSpaceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameSpaceContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.remapXMlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.nameSpaceContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameSpaceListView
            // 
            this.nameSpaceListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameSpaceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameSpaceName});
            this.nameSpaceListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.nameSpaceListView.HideSelection = false;
            this.nameSpaceListView.Location = new System.Drawing.Point(12, 12);
            this.nameSpaceListView.Name = "nameSpaceListView";
            this.nameSpaceListView.Size = new System.Drawing.Size(641, 199);
            this.nameSpaceListView.TabIndex = 0;
            this.nameSpaceListView.UseCompatibleStateImageBehavior = false;
            this.nameSpaceListView.View = System.Windows.Forms.View.Details;
            // 
            // nameSpaceName
            // 
            this.nameSpaceName.Text = "Namespace";
            this.nameSpaceName.Width = 635;
            // 
            // nameSpaceContextMenuStrip
            // 
            this.nameSpaceContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remapXMlToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.nameSpaceContextMenuStrip.Name = "contextMenuStrip1";
            this.nameSpaceContextMenuStrip.Size = new System.Drawing.Size(152, 48);
            // 
            // remapXMlToolStripMenuItem
            // 
            this.remapXMlToolStripMenuItem.Name = "remapXMlToolStripMenuItem";
            this.remapXMlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.remapXMlToolStripMenuItem.Text = "Update XML ...";
            this.remapXMlToolStripMenuItem.Click += new System.EventHandler(this.remapXMlToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem.Text = "Remove ... ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NameSpaceManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 252);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameSpaceListView);
            this.Name = "NameSpaceManagerForm";
            this.Text = "Custom XML Parts";
            this.nameSpaceContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView nameSpaceListView;
        private System.Windows.Forms.ContextMenuStrip nameSpaceContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem remapXMlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader nameSpaceName;
        private System.Windows.Forms.Button button1;
    }
}