
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XMLBrowserForm));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.XMLNodeValueLabel = new System.Windows.Forms.Label();
            this.InsertContentControlButton = new System.Windows.Forms.Button();
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
            this.treeView1.Size = new System.Drawing.Size(504, 349);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // XMLNodeValueLabel
            // 
            this.XMLNodeValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XMLNodeValueLabel.AutoSize = true;
            this.XMLNodeValueLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XMLNodeValueLabel.Location = new System.Drawing.Point(525, 30);
            this.XMLNodeValueLabel.Name = "XMLNodeValueLabel";
            this.XMLNodeValueLabel.Size = new System.Drawing.Size(173, 18);
            this.XMLNodeValueLabel.TabIndex = 3;
            this.XMLNodeValueLabel.Text = "Valoare preluata din XML";
            // 
            // InsertContentControlButton
            // 
            this.InsertContentControlButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertContentControlButton.Location = new System.Drawing.Point(528, 52);
            this.InsertContentControlButton.Name = "InsertContentControlButton";
            this.InsertContentControlButton.Size = new System.Drawing.Size(230, 23);
            this.InsertContentControlButton.TabIndex = 4;
            this.InsertContentControlButton.Text = "Insert Content Control";
            this.InsertContentControlButton.UseVisualStyleBackColor = true;
            this.InsertContentControlButton.Click += new System.EventHandler(this.InsertContentControlButton_Click);
            // 
            // XMLBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(770, 418);
            this.Controls.Add(this.InsertContentControlButton);
            this.Controls.Add(this.XMLNodeValueLabel);
            this.Controls.Add(XMLDescription);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XMLBrowserForm";
            this.Text = "XML Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label XMLNodeValueLabel;
        private System.Windows.Forms.Button InsertContentControlButton;
    }
}