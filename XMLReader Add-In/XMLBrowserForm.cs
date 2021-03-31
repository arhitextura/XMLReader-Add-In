using System;

using System.Windows.Forms;
using System.Drawing; 
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Xml.Linq;
using System.Linq;
using interopWord = Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Word;
using Microsoft.Office.Core;
using XMLReader_Add_In.Forms;

namespace XMLReader_Add_In
{

    public partial class XMLBrowserForm : Form
    {


        #region Variables
        Document extendedDocument = Globals.Factory.GetVstoObject(Globals.ThisAddIn.currentDocument);
        
        #endregion

        public XMLBrowserForm()
        {
            InitializeComponent();
            initTreeView();
            InitializeListView();
            InitializeContentControlListView();

            ListViewXMLParts.MouseUp += new MouseEventHandler(ListViewXMLParts_MouseEvent);
            extendedDocument.ActivateEvent += new WindowEventHandler(ThisDocument_ActivateEvent);
            ccListView.SelectedIndexChanged += new System.EventHandler(ccListView_SelectedIndexChanged);
            ccListView.MouseUp += new MouseEventHandler(ccListView_MouseEvent);           
  
        }

        private void ThisDocument_ActivateEvent(object sender, WindowEventArgs e)
        {
            Globals.ThisAddIn.currentDocument = Globals.ThisAddIn.Application.ActiveDocument;
            extendedDocument = Globals.Factory.GetVstoObject(Globals.ThisAddIn.currentDocument);
            InitializeContentControlListView();
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

        private void InitializeContentControlListView()
        {
            
            Color unmappedColor = ColorTranslator.FromHtml(Settings.Default.UnmappedCCForeColor);
            Color mappedColor = ColorTranslator.FromHtml(Settings.Default.MappedCCForeColor);
            
            ccListView.Items.Clear();
            interopWord.ContentControls ccList = Globals.ThisAddIn.currentDocument.ContentControls;
            foreach (interopWord.ContentControl cc in ccList)
            {
                ListViewItem ccListViewItem = new ListViewItem(cc.Title);
                ccListViewItem.Tag = cc;
                if (!cc.XMLMapping.IsMapped)
                {
                    ccListViewItem.ForeColor = unmappedColor;
                }
                else
                {
                    ccListViewItem.ForeColor = mappedColor;
                }
                ccListViewItem.SubItems.Add(cc.XMLMapping.XPath);
                
                ccListView.Items.Add(ccListViewItem);
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
        }

        /// <summary>
        /// Populates a Treeview with a given initial TreeNode
        /// </summary>
        /// <param name="treeNode">A tree node that is already created, ussualy a Root node </param>
        /// <param name="element">An XEleement which contains children, ussualy a Root XML element</param>
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
        
        private void InsertContentControl()
        {
            interopWord.Range sln = extendedDocument.Application.Selection.Range;
            try
            {
                interopWord.ContentControl plainTextControl = extendedDocument.ContentControls.Add(interopWord.WdContentControlType.wdContentControlText, sln);
                plainTextControl.Title = "Custom Title";

                InitializeContentControlListView();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }

        #region Events

        private void ccListView_MouseEvent(object sender, MouseEventArgs e)
        {
            interopWord.ContentControl focusedCC= null; 
            ListViewItem focusedItem = null;
           
            switch (e.Button)
            {
                case MouseButtons.Left:
                    focusedItem = ccListView.FocusedItem;
                    if(focusedItem != null)
                    {
                        focusedCC = focusedItem.Tag as interopWord.ContentControl;
                        interopWord.Range rng = focusedCC.Range;
                        rng.Select();
                    }
                    break;
                case MouseButtons.None:
                    break;
                case MouseButtons.Right:
                    focusedItem = ccListView.FocusedItem;
                    if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                    {
                        ccListView_ContextMenuStrip.Show(Cursor.Position);
                    }
                    break;
                case MouseButtons.Middle:
                    break;
                case MouseButtons.XButton1:
                    break;
                case MouseButtons.XButton2:
                    break;
                default:
                    break;
            }
        }
        private void ccListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            switch ((e.Action))
            {
                case TreeViewAction.ByMouse:
                    
                    XElement selectedNodeTagElement = e.Node.Tag as XElement;
                    
                    XMLNodeValueLabel.Text = Utils.ReturnXPath(selectedNodeTagElement);
                    break;
            }
        }

        private void InsertContentControlButton_Click(object sender, System.EventArgs ev)
        {
            InsertContentControl();
        }
        private void ListViewXMLParts_MouseEvent(object sender, MouseEventArgs e)
        {
            
            Debug.WriteLine($"Mouse button {e.Button} pressed");
            // Reset the label text.
            XMLNodeValueLabel.Text = "None";
        }


        #endregion

        private void ccRemapMenuItem_Click(object sender, EventArgs e)
        {
            RemapForm remapForm = new RemapForm();
            remapForm.Show();
            ContentControl selectedCC = ccListView.FocusedItem.Tag as ContentControl;
            //CustomXMLPart XMLPart = Globals.ThisAddIn.currentDocument.CustomXMLParts.SelectByNamespace
            MessageBox.Show(ccListView.FocusedItem.Tag.ToString());

        }
    }
}
