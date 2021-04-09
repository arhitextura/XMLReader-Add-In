using System.Xml.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Controls;

namespace XMLReader_Add_In
{
    public class XMLHandler
    {

        /// <summary>
        /// Builds a tree view based on XML XDoc ant existing TreeView
        /// </summary>
        /// <param name="treeNode">The treeView root element that should be built</param>
        /// <param name="element">The Starting XElement in the XML</param>
        /// <example>BuildNodes(RootTreeNode, XMLElement)</example>
        public static void BuildNodes(TreeNode treeNode, XElement element)
        {
            TreeNode childTreeNode = new TreeNode();
            // If it is not a leaf element show the tag name
            if (element.HasElements)
            {
                childTreeNode.Text = element.Name.LocalName;
            }
            else
            {
                // It is a leaf because no it has no elements, show the value inside the tag
                if (element.Value.Equals(""))
                {
                    childTreeNode.Text = element.Name.LocalName;
                }
                else
                {
                    childTreeNode.NodeFont = new System.Drawing.Font(System.Windows.Forms.TreeView.DefaultFont, FontStyle.Bold);
                    childTreeNode.Text = element.Value;
                }
            }

            //Each treeNode indicates to the XDocument element, so later we can retrieve the XPath of that element
            childTreeNode.Tag = element;
            foreach (XElement child in element.Elements())
            {
                //The recursion
                BuildNodes(childTreeNode, child);
            }
            treeNode.Nodes.Add(childTreeNode);
        }

        /// <summary>
        /// Builds a tree view based on CustomXMLNode and an existing TreeView Node
        /// </summary>
        /// <param name="treeNode">The treeView root element that should be built</param>
        /// <param name="_customXmlNode">The Starting XElement in the XML</param>
        /// <example>BuildNodes(RootTreeNode, XMLElement)</example>
        public static void BuildNodes(TreeNode treeNode, CustomXMLNode _customXmlNode)
        {
            TreeNode childTreeNode = new TreeNode();
            
            if(_customXmlNode.NodeType == MsoCustomXMLNodeType.msoCustomXMLNodeCData)
            {
                //If it is a CDATA Type must be some sort of a value inside that node and will not have any childs
                childTreeNode.Text = _customXmlNode.NodeValue;
                childTreeNode.Tag = _customXmlNode.ParentNode;
                childTreeNode.ExpandAll();
                
            } else if (_customXmlNode.NodeType == MsoCustomXMLNodeType.msoCustomXMLNodeElement)
            {
                childTreeNode.Text = _customXmlNode.BaseName;
                childTreeNode.Tag = _customXmlNode;
                childTreeNode.ExpandAll();
            }
            
            foreach (CustomXMLNode item in _customXmlNode.ChildNodes)
            {
                if(item.NodeType == MsoCustomXMLNodeType.msoCustomXMLNodeText)
                {
                    continue;
                }
                BuildNodes(childTreeNode, item);
            }

            treeNode.Nodes.Add(childTreeNode);
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

        public static void Populate_customXMLComboBoxWithCustomXMLParts(System.Windows.Forms.ComboBox customXMLComboBox, bool autoselect = false)
        {
            customXMLComboBox.Items.Clear();
            foreach (CustomXMLPart part in Globals.ThisAddIn.currentDocument.CustomXMLParts)
            {
                ComboboxItem cbItem = new ComboboxItem();
                cbItem.Text = part.NamespaceURI;
                cbItem.Tag = part;
                customXMLComboBox.Items.Add(cbItem);
            }
            if (autoselect)
            {
                foreach (ComboboxItem item in customXMLComboBox.Items)
                {
                    if (item.Text == Globals.ThisAddIn.DEFAULT_NAMESPACE)
                    {
                        customXMLComboBox.SelectedItem = item;
                    }
                }
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
