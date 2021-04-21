using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.VisualStudio.Tools.Applications.Runtime;


namespace XMLReader_Add_In
{
    public partial class ThisAddIn
    {

        public Office.CustomXMLPart existingprojectInfoXmlPart;
        public Form XMLBrowserForm;
        

        #region GLOBALS
        public Word.Document currentDocument;
        private string XMLFilePath = string.Empty;
        private XDocument _XML_ProjectInfo;
        public XDocument XML_ProjectInfo { get => _XML_ProjectInfo; set => _XML_ProjectInfo = value; }
        public XNamespace DEFAULT_NAMESPACE = Settings.Default.nameSpaceURI;
        #endregion

        /// <summary>
        /// Toggle the XML Open file dialog and loads an xml file to
        /// </summary>
        internal void ToggleOpenFileDialog()
        {
            
            currentDocument = Globals.ThisAddIn.Application.ActiveDocument;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;
                
                if(_XML_ProjectInfo == null)
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        XMLFilePath = openFileDialog.FileName;

                        MessageBox.Show(XMLFilePath);

                        this.XML_ProjectInfo = XDocument.Load(XMLFilePath);
                        try
                        {
                            XML_ProjectInfo.Root.Name =
                                DEFAULT_NAMESPACE + XML_ProjectInfo.Root.Name.LocalName;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.ToString());
                        }
                        this.XMLBrowserForm = new XMLBrowserForm();
                        XMLBrowserForm.Text = ($"{XMLBrowserForm.Name} - {currentDocument.Name}");

                        //TO-DO make it appear in fron of all windows
                        this.XMLBrowserForm.Show();
                    }
                } else
                {
                    this.XMLBrowserForm = new XMLBrowserForm();
                    XMLBrowserForm.Text = ($"{XMLBrowserForm.Name} - {currentDocument.Name}");
                    this.XMLBrowserForm.Show();
                }
                
            }
        }

        internal void AddCustomXML()
        {
            if (XML_ProjectInfo == null)
            {
                MessageBox.Show("Please load an XML File before you proceed adding the custom xml.");
                ToggleOpenFileDialog();
            } else
            {
                if(currentDocument.CustomXMLParts.SelectByNamespace(DEFAULT_NAMESPACE.ToString()).Count < 1)
                {
                   
                    string xmlString = XML_ProjectInfo.ToString();
                    Office.CustomXMLPart customXML = currentDocument.CustomXMLParts.Add(xmlString);
                    customXML.NamespaceManager.AddNamespace("ns", @"http://consoft.ro/ProjectInfo-v1.xml");
                    if (currentDocument.Variables["XML_ID"] == null)
                    {
                        currentDocument.Variables.Add("XML_ID", customXML.Id);
                    } else
                    {
                        currentDocument.Variables["XML_ID"].Value = customXML.Id;
                    }
                    
                    
                }
            }
        }

        #region Event handling functions
        void SetCurrentDocument(Word.Document doc)
        {
            currentDocument = Globals.ThisAddIn.Application.ActiveDocument;
        }
        void SetCurrentDocument(Word.Document doc, Word.Window wn)
        {
            currentDocument = Globals.ThisAddIn.Application.ActiveDocument;
        }
        void SelectExistingXMLPart(Word.Document doc)
        {
            try
            {
                string _customXMLPartID = doc.Variables["XML_ID"].Value;
                existingprojectInfoXmlPart = doc.CustomXMLParts.SelectByID(_customXMLPartID);
            }
            catch (Exception)
            {
                MessageBox.Show("No custom XML Part found that was imported from Archicad.");
                //throw new KeyNotFoundException("No custom XML part found in this document");
            }
        }
        void DocumentBeforeClose(Word.Document doc, ref bool Cancel) 
        {
            if (this.XMLBrowserForm != null)
            {
                this.XMLBrowserForm.TopMost = false;    
            }
        }
        #endregion

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            this.Application.DocumentOpen +=
            new Word.ApplicationEvents4_DocumentOpenEventHandler(SetCurrentDocument);
            this.Application.DocumentOpen +=
            new Word.ApplicationEvents4_DocumentOpenEventHandler(SelectExistingXMLPart);

            ((Word.ApplicationEvents4_Event)this.Application).NewDocument +=
                new Word.ApplicationEvents4_NewDocumentEventHandler(SetCurrentDocument);

            this.Application.WindowActivate += new Word.ApplicationEvents4_WindowActivateEventHandler(SetCurrentDocument);
            this.Application.DocumentBeforeClose += new Word.ApplicationEvents4_DocumentBeforeCloseEventHandler(DocumentBeforeClose);
        }
        

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {

        }

        
        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
            
        }
        
        #endregion
    }
}
