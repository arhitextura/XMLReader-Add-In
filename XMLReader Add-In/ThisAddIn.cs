using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word.Controls;




namespace XMLReader_Add_In
{
    public partial class ThisAddIn
    {
        private System.Windows.Forms.Form XMLBrowserForm;

        #region GLOBALS
        public Word.Document currentDocument;
        private string XMLFilePath = string.Empty;
        private XDocument _XML_ProjectInfo;
        public XDocument XML_ProjectInfo { get => _XML_ProjectInfo; set => _XML_ProjectInfo = value; }
        #endregion

        //Toggle the XML Open file dialog and loads an xml file to
        internal void ToggleOpenFileDialog()
        {
            currentDocument = Globals.ThisAddIn.Application.Application.ActiveDocument;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;
                
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    XMLFilePath = openFileDialog.FileName;
                    DialogResult msgBox;
                    msgBox = MessageBox.Show(XMLFilePath);

                    this.XML_ProjectInfo = XDocument.Load(XMLFilePath);
                    this.XMLBrowserForm = new XMLBrowserForm();
                    this.XMLBrowserForm.Show();
                }
            }
        }

        internal void addCustomXML ()
        {
            //currentDocument = Globals.ThisAddIn.Application.Application.ActiveDocument;
            string xmlString =
            "<?xml version=\"1.0\" encoding=\"utf-8\" ?>" +
                "<employees xmlns=\"Employees\">" +
                    "<employee>" +
                        "<name>Karina Leal</name>" +
                        "<hireDate>1999-04-01</hireDate>" +
                        "<title>Manager</title>" +
                    "</employee>" +
                "</employees>";
            Office.CustomXMLPart customXML = currentDocument.CustomXMLParts.Add(xmlString);
            DialogResult msgBox;
            msgBox = MessageBox.Show(currentDocument.CustomXMLParts.SelectByNamespace("Employees").ToString());
        }

        #region Event handling functions
        private void setCurrentDocument(Word.Document doc)
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
