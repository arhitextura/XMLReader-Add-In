using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using XMLReader_Add_In.Forms;
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
            
            Globals.ThisAddIn.ToggleOpenFileDialog();
            
            
        }
        
        private void viewCustomXMLParts (object sender, RibbonControlEventArgs ev)
        {
            this.nameSpaceManagerForm = new NameSpaceManagerForm();
            this.nameSpaceManagerForm.Show();
        }

        private void AddCustomXMLButton_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.addCustomXML();
        }

        private void button1_Click_1(object sender, RibbonControlEventArgs e)
        {
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
