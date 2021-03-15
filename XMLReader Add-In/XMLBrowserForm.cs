using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml.Linq;

namespace XMLReader_Add_In
{
    public partial class XMLBrowserForm : Form
    {
        
        private void initTreeView()
        {
            XDocument XMLFileRoot = Globals.ThisAddIn.XML_ProjectInfo;
            IEnumerable<XElement> rootNode = XMLFileRoot.Root.Elements();
            //DialogResult msgBox;
            //msgBox = MessageBox.Show(XMLFileRoot.ToString());

            //init the Tree with Root Element
            TreeNode rootTreeNode = new TreeNode();
            rootTreeNode.Tag = XMLFileRoot.Root;
            rootTreeNode.Text = XMLFileRoot.Root.Name.ToString();
            treeView1.Nodes[0] = rootTreeNode;

            TreeNodeCollection currentNodeCollection = treeView1.Nodes;
            
            
            int i = 0;
            foreach(XElement element in rootNode)
            {
                TreeNode childNode = new TreeNode();
                childNode.Tag = element;
                childNode.Text = element.Name.ToString();
                currentNodeCollection.Add(childNode);

                if (element.HasElements)
                {
                    TreeNodeCollection childTree = treeView1.Nodes;
                    foreach(XElement child in element.Elements())
                    {
                        childTree.Add(new TreeNode(child.Name.ToString()));
                    }
                }
                i++;
            }



        }
        public XMLBrowserForm()
        {
            
            InitializeComponent();
            initTreeView();
        }
    }
}
