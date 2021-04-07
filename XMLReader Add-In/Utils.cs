using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordInterop = Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Core;

namespace XMLReader_Add_In
{
    public class Utils
    {
       
        public static string ReturnXPath(XElement el)
        {
            string pathString = "/";
            List<XElement> ancestorsList = el.Ancestors().ToList();
            ancestorsList.Reverse();
            
            foreach(XElement ancestor in ancestorsList)
            {
                pathString += ancestor.Name.LocalName.ToString() + "/";
            }
            pathString += el.Name.LocalName;
            return pathString;
        }

    }

}
