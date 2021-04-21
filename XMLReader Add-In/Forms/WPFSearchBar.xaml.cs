using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XMLReader_Add_In.Forms
{
    /// <summary>
    /// Interaction logic for WPFSearchBar.xaml
    /// </summary>
    public partial class WPFSearchBar : Window
    {
        public WPFSearchBar()
        {
            InitializeComponent();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void SearchBox_RTB_KeyDown(object sender, KeyEventArgs e)
        {
            FlowDocument flDoc = new FlowDocument();
            Paragraph p = new Paragraph();
            Span spanx = new Span();
            spanx.Foreground = Brushes.LightGray;
            spanx.Inlines.Add("AAA");
            p.Inlines.Add(spanx);
            flDoc.Blocks.Add(p);

            SearchBox_RTB.Document = flDoc;
            
        }
    }
}
