using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;
using System.Diagnostics;
using System.Windows.Controls;

namespace XMLReader_Add_In.Forms
{

    public partial class RemapForm : Form
    {
        
        public RemapForm()
        {
            InitializeComponent();
            Populate_customXMLComboBox();
            Populate_customXMLPartTreeView();
        }
        private void Populate_customXMLComboBox()
        {
            foreach (CustomXMLPart part in Globals.ThisAddIn.currentDocument.CustomXMLParts)
            {
                ComboboxItem cbItem = new ComboboxItem();
                cbItem.Text = part.NamespaceURI;
                cbItem.Tag = part;
                customXMLComboBox.Items.Add(cbItem);
                
            }
            foreach (ComboboxItem item in customXMLComboBox.Items)
            {
                if (item.Text == Globals.ThisAddIn.DEFAULT_NAMESPACE)
                {
                    
                    customXMLComboBox.SelectedItem = item;
                }
            }

        }
        private void Populate_customXMLPartTreeView()
        {
            
            
        }
        private void customXMLComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (customXMLComboBox.SelectedItem != null)
            {
                customXMLPartTreeView.Nodes.Clear();
                TreeNode RootNode = new TreeNode();
                RootNode.Text = "Root";
                customXMLPartTreeView.Nodes.Add(RootNode);
                var customXMLPart = ((ComboBoxItem)customXMLComboBox.SelectedItem).Tag as CustomXMLPart;
                Debug.WriteLine(customXMLPart.XML);
                XMLHandler.BuildNodes(RootNode, customXMLPart);
            }

        }
    }
    public class ComboboxItem : ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
