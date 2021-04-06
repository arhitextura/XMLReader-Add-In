
namespace XMLReader_Add_In.Forms
{
    partial class RemapForm
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
            this.customXMLPartTreeView = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.customXMLComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // customXMLPartTreeView
            // 
            this.customXMLPartTreeView.Location = new System.Drawing.Point(12, 39);
            this.customXMLPartTreeView.Name = "customXMLPartTreeView";
            this.customXMLPartTreeView.Size = new System.Drawing.Size(265, 476);
            this.customXMLPartTreeView.TabIndex = 0;
            this.customXMLPartTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.customXMLPartTreeView_AfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Remap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 521);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // customXMLComboBox
            // 
            this.customXMLComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customXMLComboBox.FormattingEnabled = true;
            this.customXMLComboBox.Location = new System.Drawing.Point(12, 12);
            this.customXMLComboBox.Name = "customXMLComboBox";
            this.customXMLComboBox.Size = new System.Drawing.Size(265, 21);
            this.customXMLComboBox.TabIndex = 3;
            this.customXMLComboBox.SelectedIndexChanged += new System.EventHandler(this.customXMLComboBox_SelectedIndexChanged);
            // 
            // RemapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 556);
            this.Controls.Add(this.customXMLComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customXMLPartTreeView);
            this.Name = "RemapForm";
            this.Text = "Remap ...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView customXMLPartTreeView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox customXMLComboBox;
    }
}