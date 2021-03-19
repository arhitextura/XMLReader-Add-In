﻿using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;
using interopWord = Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Word;

namespace XMLReader_Add_In
{
    public partial class XMLBrowserForm : Form
    {
        private Microsoft.Office.Tools.Word.PlainTextContentControl plainTextControl1;
        
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

        /*Gets all the content controls in the currentDocument 
         */
        private void GetAllControls()
        {
            //TODO Fix here
            ContentControl content;
                        
            Globals.ThisAddIn.currentDocument.Select();
            Document extendedDocument = Globals.Factory.GetVstoObject(Globals.ThisAddIn.currentDocument);
            interopWord.ContentControls ccList = Globals.ThisAddIn.currentDocument.ContentControls;
            foreach (interopWord.ContentControl cc in ccList)
            {
                System.Diagnostics.Debug.WriteLine(cc.Title);
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

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //TODO Add selection for all content controls in document
            switch ((e.Action))
            {
                case TreeViewAction.ByMouse:
                    
                    XElement selectedNodeTagElement = e.Node.Tag as XElement;
                    string s = string.Empty;
                    foreach(XElement el in selectedNodeTagElement.Ancestors())
                    {
                        s += el.Name.ToString() + "/";
                    }
                    XMLNodeValueLabel.Text = s;

                    //System.Diagnostics.Debug.Print(Utils.ReturnXPath(e.Node.Tag as XElement));
                    break;
            }
        }

        private void InsertContentControlButton_Click(object sender, System.EventArgs e)
        {
            Globals.ThisAddIn.currentDocument.Select();
            Document extendedDocument = Globals.Factory.GetVstoObject(Globals.ThisAddIn.currentDocument);
            //plainTextControl1 = extendedDocument.Controls.AddPlainTextContentControl("adada");
            GetAllControls();
        }
    }
}
