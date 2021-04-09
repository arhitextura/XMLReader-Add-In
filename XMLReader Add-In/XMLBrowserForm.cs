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
        Forms.FloatingSearchBar searchBar;
        #endregion

        public XMLBrowserForm()
        {

            InitializeComponent();
            InitializeContentControlListView();
            XMLHandler.Populate_customXMLComboBoxWithCustomXMLParts(this.customXMLPartsComboBox);
            InitializeCustomXML_treeView();
            Initialize_isOnTop_CheckBox();
            
            extendedDocument.ActivateEvent += new WindowEventHandler(ThisDocument_ActivateEvent);
            ccListView.SelectedIndexChanged += new System.EventHandler(ccListView_SelectedIndexChanged);
            ccListView.MouseUp += new MouseEventHandler(ccListView_MouseEvent);
            extendedDocument.ContentControlBeforeStoreUpdate +=
                new interopWord.DocumentEvents2_ContentControlBeforeStoreUpdateEventHandler
                (ExtendedDocument_ContentControlBeforeStoreUpdate);
            this.Activated += new EventHandler(XMLBrowserFormActivate);
        }

       
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Space))
            {
                searchBar = new FloatingSearchBar();
                
                searchBar.Show();
                //MessageBox.Show("What the Ctrl+F?");

                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Initialize_isOnTop_CheckBox()
        {
            if (this.TopMost)
            {
                isOnTop_CheckBox.Checked = true;
            } else
            {
                isOnTop_CheckBox.Checked = false;
            }
        }
        public void InitializeContentControlListView()
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
                if (cc.XMLMapping.IsMapped)
                {
                    ccListViewItem.SubItems.Add(cc.XMLMapping.CustomXMLNode.Text);
                }
                else
                {
                    ccListViewItem.SubItems.Add(cc.Range.Text);
                }

                ccListView.Items.Add(ccListViewItem);
            }

        }
        public void InitializeCustomXML_treeView()
        {
            customXML_treeView.Nodes.Clear();
            customXML_treeView.Nodes.Add(new TreeNode("Root"));
            TreeNode root = customXML_treeView.Nodes[0];
            Debug.WriteLine(root.Text);
            if(customXMLPartsComboBox.SelectedItem != null)
            {
                CustomXMLPart customPart = ((System.Windows.Controls.ComboBoxItem)customXMLPartsComboBox.SelectedItem).Tag as CustomXMLPart;
                CustomXMLNode customNode = customPart.SelectSingleNode("/*");
                XMLHandler.BuildNodes(root, customNode);
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


        

        #region Events Handlers
        private void XMLBrowserFormActivate(object sender, EventArgs e)
        {
            InitializeContentControlListView();
            XMLHandler.Populate_customXMLComboBoxWithCustomXMLParts(this.customXMLPartsComboBox);
        }
        private void ThisDocument_ActivateEvent(object sender, WindowEventArgs e)
        {
            Globals.ThisAddIn.currentDocument = Globals.ThisAddIn.Application.ActiveDocument;
            extendedDocument = Globals.Factory.GetVstoObject(Globals.ThisAddIn.currentDocument);
            InitializeContentControlListView();
            
        }
        private void ccListView_MouseEvent(object sender, MouseEventArgs e)
        {
            interopWord.ContentControl focusedCC = null;
            ListViewItem focusedItem = null;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    focusedItem = ccListView.FocusedItem;
                    if (focusedItem != null)
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
        private void ExtendedDocument_ContentControlBeforeStoreUpdate(interopWord.ContentControl ContentControl, ref string Content)
        {
            Debug.WriteLine(ContentControl.Title);
            InitializeContentControlListView();
        }
        private void ccListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void InsertContentControlButton_Click(object sender, System.EventArgs ev)
        {
            InsertContentControl();
        }



        private void ccRemapMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.ContentControl selectedCC = ccListView.FocusedItem.Tag as Microsoft.Office.Interop.Word.ContentControl;
            RemapForm remapForm = new RemapForm(selectedCC);
            remapForm.ShowDialog();
            //CustomXMLPart XMLPart = Globals.ThisAddIn.currentDocument.CustomXMLParts.SelectByNamespace
            
        }

        private void customXMLPartsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customXMLPartsComboBox.SelectedItem != null)
            {
                InitializeCustomXML_treeView();
            }
        }

        private void isOnTop_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(isOnTop_CheckBox.Checked == true)
            {
                this.TopMost = true;
            } else
            {
                this.TopMost = false;
            }
            
        }
        #endregion
    }


}
