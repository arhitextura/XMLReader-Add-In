using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;


namespace XMLReader_Add_In
{
    public class XMLHandler
    {
        
        public readonly XDocument xmlDocument;
        public XMLHandler(XDocument doc) => xmlDocument = doc;

        public bool HasNameSpace()
        {
            foreach (XNode item in xmlDocument.Nodes())
            {
                if (item.NodeType is XNamespace)
                {
                    return true;
                }
            }
            return false;
        }
        public XDocument PrettyXML()
        {
            
            XDocument prettyDoc = new XDocument();


            XElement UIvalue;
            IEnumerable<XElement> UIKeyElements;
            try
            {
                UIKeyElements = xmlDocument.Descendants("UIKey");
                foreach (XElement UIKeyElement in UIKeyElements)
                {
                    
                    UIvalue = UIKeyElement.Parent.Element("value");
                    UIKeyElement.Add(UIvalue);
                    prettyDoc.Root.Add(UIKeyElement);
                }
                System.Diagnostics.Debug.WriteLine(prettyDoc.ToString());
                return prettyDoc;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }
    }
    
}
