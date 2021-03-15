using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

namespace XMLReader_Add_In
{
    public partial class XMLBrowserForm : Form
    {
        
        private void initTreeView()
        {
            XDocument XMLFileRoot = Globals.ThisAddIn.XML_ProjectInfo;
            XElement XMLRoot = XMLFileRoot.Root;
            //DialogResult msgBox;
            //msgBox = MessageBox.Show(XMLFileRoot.ToString());

            //init the Tree with Root Element
            TreeNode RootNode = new TreeNode();
            RootNode.Tag = XMLFileRoot.Root;
            RootNode.Text = XMLFileRoot.Root.Name.ToString();
            treeView1.Nodes.Add(RootNode);
            foreach(XElement rootChild in XMLRoot.Elements())
            {
                BuildNodes(RootNode, rootChild);
            }
        }

        private void BuildNodes(TreeNode treeNode, XElement element)
            
        {
            
            foreach (XElement child in element.Elements())
            {
    
                TreeNode childTreeNode = new TreeNode();
                childTreeNode.Tag = child;
                if (child.Name.ToString().StartsWith("Fix") || child.Name.ToString().StartsWith("Custom"))
                {
                    childTreeNode.Text = child.Element("UIKey").Value.ToString();
                }
                else if(child.Name.ToString() == "UIKey")
                {
                    childTreeNode.Text = child.Value.ToString();
                } 
                else
                {
                    childTreeNode.Text = child.Name.ToString();
                }
                
                treeNode.Nodes.Add(childTreeNode);
                BuildNodes(childTreeNode, child);
            }
        }

        public XMLBrowserForm()
        {
            
            InitializeComponent();
            initTreeView();
        }
    }
}
