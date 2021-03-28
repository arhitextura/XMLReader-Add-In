using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace XMLReader_Add_In
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            
            Globals.ThisAddIn.ToggleOpenFileDialog();
            
            
        }
        private void ViewXMLLoadedXML (object sender, RibbonControlEventArgs e)
        {
            try
            {
                MessageBox.Show(Globals.ThisAddIn.currentDocument.Variables["CUSTOM_XML_ID"].Value);
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
                
            
            
        }

        private void AddCustomXMLButton_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.addCustomXML();
        }

        private void LoadContentButton_Click(object sender, RibbonControlEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(Globals.ThisAddIn.currentDocument.Name);
            
        }
    }
}
