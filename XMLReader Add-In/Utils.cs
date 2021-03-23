using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordInterop = Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XMLReader_Add_In
{
    public class Utils
    {
       public static void showMessageBox(string message)
        {
            MessageBox.Show(message);
        }

       public static string ReturnXPath(XElement el)
        {
            
            string pathString = "/";
            List<XElement> ancestorsList = el.Ancestors().ToList();
            ancestorsList.Reverse();
            
            foreach(XElement ancestor in ancestorsList)
            {
                pathString += ancestor.Name.ToString() + "/";
            }
            pathString += el.Name.ToString();
            return pathString;
        }
    }
}
