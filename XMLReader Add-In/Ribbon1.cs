using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using XMLReader_Add_In.Forms;
using Office = Microsoft.Office.Core;

namespace XMLReader_Add_In
{
    public partial class Ribbon1
    {
        private Form nameSpaceManagerForm;
        
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {   
            if(Globals.ThisAddIn.currentDocument.Variables["XML_ID"] == null)
            {
                //TODO Fix  the CustomXML part loader
                // If there is a custom XML part loaded in this document than load the XMLBrowserForm with 
                // this existing custom part
                Globals.ThisAddIn.ToggleOpenFileDialog();
            } else
            {
                Globals.ThisAddIn.XMLBrowserForm = new XMLBrowserForm();
                Globals.ThisAddIn.XMLBrowserForm.Show();
            }
            
        }
        
        private void viewCustomXMLParts (object sender, RibbonControlEventArgs ev)
        {
            this.nameSpaceManagerForm = new NameSpaceManagerForm();
            this.nameSpaceManagerForm.Show();
        }

        private void AddCustomXMLButton_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.AddCustomXML();
        }

        private void button1_Click_1(object sender, RibbonControlEventArgs e)
        {
            WPFSearchBar wpfSrc = new WPFSearchBar();
            wpfSrc.ShowDialog();
            
            System.Diagnostics.Debug.WriteLine(Globals.ThisAddIn.XML_ProjectInfo);
            try
            {
                MessageBox.Show(Globals.ThisAddIn.currentDocument.Variables["XML_ID"].Value);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
        }
    }
}
