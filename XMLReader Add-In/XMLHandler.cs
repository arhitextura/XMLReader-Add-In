using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;


namespace XMLReader_Add_In
{
    public class XMLHandler
    {
        
        public static void BuildNodes(TreeNode treeNode, XElement element)
        {
            foreach (XElement child in element.Elements())
            {
                TreeNode childTreeNode = new TreeNode();
                childTreeNode.Tag = child;
                
                treeNode.Nodes.Add(childTreeNode);
                BuildNodes(childTreeNode, child);
            }
        }
        public static void BuildNodes(TreeNode treeNode, CustomXMLPart customXMLPart)
        {
            XDocument xDocOfCustomXMLPart = XDocument.Parse(customXMLPart.XML);
           
            
            foreach (XElement child in xDocOfCustomXMLPart.Elements())
            {
                //TODO Fix naming treenodes
                TreeNode childTreeNode = new TreeNode();
                childTreeNode.Tag = child;
                System.Diagnostics.Debug.WriteLine($"Count of childs: {child}");
                childTreeNode.Text = child.Name.ToString();
                treeNode.Nodes.Add(childTreeNode);
                BuildNodes(childTreeNode, child);
            }
        }
        public static void RemapCustomXMLPart(CustomXMLPart xmlPart)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {

                        XDocument tempXML = XDocument.Load(openFileDialog.FileName);
                        tempXML.Root.Name =
                                Globals.ThisAddIn.DEFAULT_NAMESPACE + tempXML.Root.Name.LocalName;
                        xmlPart.Delete();
                        Globals.ThisAddIn.currentDocument.CustomXMLParts.Add(tempXML.ToString());
                        
                    }
                }
            }
        }
        public static void RemapCustomXMLPart(ContentControl cc)
        {

        }
    }

}
