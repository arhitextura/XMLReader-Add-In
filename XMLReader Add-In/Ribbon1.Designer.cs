
namespace XMLReader_Add_In
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.XMLAddIn = this.Factory.CreateRibbonGroup();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.openXMLFileButton = this.Factory.CreateRibbonButton();
            this.settingsButton = this.Factory.CreateRibbonButton();
            this.AddCustomXMLButton = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.XMLAddIn.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.XMLAddIn);
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "XML Add-In";
            this.tab1.Name = "tab1";
            // 
            // XMLAddIn
            // 
            this.XMLAddIn.Items.Add(this.openXMLFileButton);
            this.XMLAddIn.Items.Add(this.AddCustomXMLButton);
            this.XMLAddIn.Label = "Controls";
            this.XMLAddIn.Name = "XMLAddIn";
            // 
            // group1
            // 
            this.group1.Items.Add(this.settingsButton);
            this.group1.Label = "Customize";
            this.group1.Name = "group1";
            // 
            // openXMLFileButton
            // 
            this.openXMLFileButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.openXMLFileButton.Image = global::XMLReader_Add_In.Properties.Resources.iconfinder_document_file_paper_page_26_2850884;
            this.openXMLFileButton.Label = "Load XML";
            this.openXMLFileButton.Name = "openXMLFileButton";
            this.openXMLFileButton.ShowImage = true;
            this.openXMLFileButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.settingsButton.Image = global::XMLReader_Add_In.Properties.Resources.settings_cogwheel_button_icon_icons_com_72559;
            this.settingsButton.Label = "Settings";
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.ShowImage = true;
            // 
            // AddCustomXMLButton
            // 
            this.AddCustomXMLButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.AddCustomXMLButton.Image = global::XMLReader_Add_In.Properties.Resources.add_insert_plus_icon_178023;
            this.AddCustomXMLButton.Label = "Add custom XML";
            this.AddCustomXMLButton.Name = "AddCustomXMLButton";
            this.AddCustomXMLButton.ShowImage = true;
            this.AddCustomXMLButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AddCustomXMLButton_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.XMLAddIn.ResumeLayout(false);
            this.XMLAddIn.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup XMLAddIn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton openXMLFileButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton AddCustomXMLButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton settingsButton;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
