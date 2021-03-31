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
using Microsoft.Office.Interop.Word;
namespace XMLReader_Add_In.Forms
{
    public partial class NameSpaceManagerForm : Form
    {
        ListViewItem focusedItem = null;
        public NameSpaceManagerForm()
        {

            InitializeComponent();
            PopulateFormWithCustomXMLParts();
            nameSpaceListView.MouseUp += new MouseEventHandler(nameSpaceListView_MouseEvent);
        }

        private void PopulateFormWithCustomXMLParts()
        {
            CustomXMLParts xmlPartsList = Globals.ThisAddIn.currentDocument.CustomXMLParts;
            foreach (CustomXMLPart part in xmlPartsList)
            {
                ListViewItem listItem = new ListViewItem( Text = part.NamespaceURI );
                listItem.Tag = part;
                nameSpaceListView.Items.Add(listItem);
            }
        }
        private void nameSpaceListView_MouseEvent(object sender, MouseEventArgs ev)
        {
            CustomXMLPart customXMLPart;
            switch (ev.Button)
            {
                case MouseButtons.Left:
                    break;
                case MouseButtons.None:
                    break;
                case MouseButtons.Right:
                    focusedItem = nameSpaceListView.FocusedItem;
                    if (focusedItem != null && focusedItem.Bounds.Contains(ev.Location))
                    {
                        nameSpaceContextMenuStrip.Show(Cursor.Position);
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

        private void remapXMlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(nameSpaceListView.FocusedItem != null)
            {
                XMLHandler.RemapCustomXMLPart(nameSpaceListView.FocusedItem.Tag as CustomXMLPart);
            }
        }
    }
   
}
