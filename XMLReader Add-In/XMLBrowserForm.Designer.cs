
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
            System.Windows.Forms.Label XMLDescription;
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Root");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XMLBrowserForm));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.openXML = new System.Windows.Forms.Button();
            XMLDescription = new System.Windows.Forms.Label();
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
            this.treeView1.Location = new System.Drawing.Point(15, 30);
            this.treeView1.Name = "treeView1";
            //treeNode1.Name = "XML_Tree";
            //treeNode1.Text = "Root";
            //this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            //treeNode1});
            this.treeView1.Size = new System.Drawing.Size(565, 349);
            this.treeView1.TabIndex = 0;
            // 
            // openXML
            // 
            this.openXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openXML.Location = new System.Drawing.Point(586, 30);
            this.openXML.Name = "openXML";
            this.openXML.Size = new System.Drawing.Size(75, 23);
            this.openXML.TabIndex = 1;
            this.openXML.Text = "Open XML ...";
            this.openXML.UseVisualStyleBackColor = true;
            // 
            // XMLBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(673, 418);
            this.Controls.Add(XMLDescription);
            this.Controls.Add(this.openXML);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XMLBrowserForm";
            this.Text = "XML Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button openXML;
    }
}