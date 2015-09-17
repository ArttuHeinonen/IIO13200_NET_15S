using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using System.Xml;

namespace Tehtava4
{
    /// <summary>
    /// Interaction logic for ViinikellariXDoc.xaml
    /// </summary>
    public partial class ViinikellariXDoc : Window
    {

        private ObservableCollection<String> maat = new ObservableCollection<String>();
        XmlDocument doc = new XmlDocument();
        String fileName = Tehtava4.Properties.Settings.Default.filePath.ToString();

        public ViinikellariXDoc()
        {
            InitializeComponent();
            comboBox.ItemsSource = maat;
        }

        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            doc.LoadXml("D:\\viinit1.xml");
            foreach (var XmlNode in doc.SelectNodes("viinikellari/wine/maa"))
            {
                
            }
        }
    }
}
