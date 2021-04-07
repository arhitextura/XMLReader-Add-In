
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
            this.RemapButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.customXMLPartsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // customXMLPartTreeView
            // 
            this.customXMLPartTreeView.Location = new System.Drawing.Point(12, 39);
            this.customXMLPartTreeView.Name = "customXMLPartTreeView";
            this.customXMLPartTreeView.Size = new System.Drawing.Size(265, 476);
            this.customXMLPartTreeView.TabIndex = 0;
            this.customXMLPartTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CustomXMLPartTreeView_AfterSelect);
            // 
            // RemapButton
            // 
            this.RemapButton.Location = new System.Drawing.Point(12, 521);
            this.RemapButton.Name = "RemapButton";
            this.RemapButton.Size = new System.Drawing.Size(75, 23);
            this.RemapButton.TabIndex = 1;
            this.RemapButton.Text = "Remap";
            this.RemapButton.UseVisualStyleBackColor = true;
            this.RemapButton.Click += new System.EventHandler(this.RemapButton_Click);
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
            // customXMLPartsComboBox
            // 
            this.customXMLPartsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customXMLPartsComboBox.FormattingEnabled = true;
            this.customXMLPartsComboBox.Location = new System.Drawing.Point(12, 12);
            this.customXMLPartsComboBox.Name = "customXMLPartsComboBox";
            this.customXMLPartsComboBox.Size = new System.Drawing.Size(265, 21);
            this.customXMLPartsComboBox.TabIndex = 3;
            this.customXMLPartsComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomXMLComboBox_SelectedIndexChanged);
            // 
            // RemapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 556);
            this.Controls.Add(this.customXMLPartsComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RemapButton);
            this.Controls.Add(this.customXMLPartTreeView);
            this.Name = "RemapForm";
            this.Text = "Remap ...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView customXMLPartTreeView;
        private System.Windows.Forms.Button RemapButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox customXMLPartsComboBox;
    }
}