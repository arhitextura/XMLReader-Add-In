using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using Word = Microsoft.Office.Interop.Word;

namespace XMLReader_Add_In
{
    interface IXMLHandler
    {
        string GetCustomXmlPartID(Word.Document document);
        CustomXMLPart GetCustomXMLPart(string ID, Word.Document document);
        
    }
}
