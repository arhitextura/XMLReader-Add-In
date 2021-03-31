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
       
        private Form XMLBrowserForm;

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

        internal void addCustomXML ()
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
                    Office.CustomXMLPart customXML = currentDocument.CustomXMLParts.Add(xmlString, missing);
                    string id = customXML.Id;
                    currentDocument.Variables.Add("XML_ID", id);
                    
                }
            }
        }

        #region Event handling functions
        void setCurrentDocument(Word.Document doc)
        {
            currentDocument = Globals.ThisAddIn.Application.ActiveDocument;
            
            
        }
        void setCurrentDocument(Word.Document doc, Word.Window wn)
        {
            currentDocument = Globals.ThisAddIn.Application.ActiveDocument;

        }
        #endregion

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            this.Application.DocumentOpen +=
            new Word.ApplicationEvents4_DocumentOpenEventHandler(setCurrentDocument);

            ((Word.ApplicationEvents4_Event)this.Application).NewDocument +=
                new Word.ApplicationEvents4_NewDocumentEventHandler(setCurrentDocument);
            this.Application.WindowActivate += new Word.ApplicationEvents4_WindowActivateEventHandler(setCurrentDocument);
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
