using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;
using interopWord = Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Word;
using Microsoft.Office.Core;

namespace XMLReader_Add_In
{
    public partial class XMLBrowserForm : Form
    {
        #region Variables
        
        private Microsoft.Office.Tools.Word.PlainTextContentControl plainTextControl1;
        #endregion
        public XMLBrowserForm()
        {
            InitializeComponent();
            initTreeView();
            InitializeListView();
            ListViewXMLParts.MouseUp += new MouseEventHandler(ListViewXMLParts_MouseEvent);
        }

        private void initTreeView()
        {
            XDocument XMLFileRoot = Globals.ThisAddIn.XML_ProjectInfo;
            XElement XMLRoot = XMLFileRoot.Root;
            TreeNode RootNode = new TreeNode();
            RootNode.Tag = XMLFileRoot.Root;
            RootNode.Text = XMLFileRoot.Root.Name.ToString();
            treeView1.Nodes.Add(RootNode);
            foreach (XElement rootChild in XMLRoot.Elements())
            {
                BuildNodes(RootNode, rootChild);
            }
        }

        ///<summary>
        ///Gets all the content controls in the active documet
        /// </summary>
        private void GetAllControls()
        {
            interopWord.ContentControls ccList =
                Globals.ThisAddIn.currentDocument.ContentControls;
            foreach (interopWord.ContentControl cc in ccList)
            {
                Debug.WriteLine(cc.Type);
            }
        }

        /// <summary>
        /// Populates the ListViewXMLParts
        /// </summary>
        private void InitializeListView()
        {
            XElement XMLRoot = Globals.ThisAddIn.XML_ProjectInfo.Root;
            IEnumerable<XElement> UIKeys = XMLRoot.Descendants("UIKey");

            foreach (XElement UIKey in UIKeys)
            {
                
                ListViewItem UIKeyItem = new ListViewItem(UIKey.Value);
                XElement keyValueElement = UIKey.Parent.Element("value");

                UIKeyItem.SubItems.Add(keyValueElement.Value);
                UIKeyItem.Tag = keyValueElement;
                UIKeyItem.SubItems.Add(UIKeyItem.Tag.ToString());

                ListViewXMLParts.Items.Add(UIKeyItem);
                
            }
         
            //CustomXMLParts cc = Globals.ThisAddIn.currentDocument.CustomXMLParts;
            //foreach (CustomXMLPart item in cc)
            //{
            //    ListViewXMLParts.Items.Add(new ListViewItem(item.NamespaceURI.ToString()));

            //}
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

       

        
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //TODO Add selection for all content controls in document
            switch ((e.Action))
            {
                case TreeViewAction.ByMouse:
                    
                    XElement selectedNodeTagElement = e.Node.Tag as XElement;
                    
                    XMLNodeValueLabel.Text = Utils.ReturnXPath(selectedNodeTagElement);
                    break;
            }
        }

        private void InsertContentControlButton_Click(object sender, System.EventArgs e)
        {
            Globals.ThisAddIn.currentDocument.Select();
            Document extendedDocument = Globals.Factory.GetVstoObject(Globals.ThisAddIn.currentDocument);
            plainTextControl1 = extendedDocument.Controls.AddPlainTextContentControl("adada");
            GetAllControls();
        }
        private void ListViewXMLParts_MouseEvent(object sender, MouseEventArgs e)
        {

            Debug.WriteLine($"Mouse button {e.Button} pressed");
            // Reset the label text.
            XMLNodeValueLabel.Text = "None";
        }

        private void ListViewXMLParts_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}
