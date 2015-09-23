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
using System.Xml.Linq;
using System.Xml.XPath;
using System.Data;

namespace Tehtava4
{
    /// <summary>
    /// Interaction logic for ViinikellariXDoc.xaml
    /// </summary>
    public partial class ViinikellariXDoc : Window
    {

        private ObservableCollection<string> maat = new ObservableCollection<string>();
        private string fileName = Tehtava4.Properties.Settings.Default.filePath.ToString();
        private XDocument doc;
        public ViinikellariXDoc()
        {
            InitializeComponent();
            loadCountries();
        }

        private void loadCountries()
        {
            doc = XDocument.Load(@fileName);
            var parser = from p in doc.Descendants("wine")
                         select new
                         {
                             maa = p.Element("maa").Value
                         };
            foreach (var p in parser)
            {
                string country = p.maa;
                if (!maat.Contains(country))
                {
                    maat.Add(country);
                }
            }

            comboBox.ItemsSource = maat;
            statusText.Text = fileName;
            comboBox.SelectedIndex = 0;
        }

        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            string country = comboBox.SelectedValue.ToString();
            var parser = (from p in doc.Root.Descendants("wine")
                          where (p.Element("maa").Value == country || country == "")
                          select new
                          {
                              Viini = p.Element("nimi").Value,
                              Maa = p.Element("maa").Value,
                              Pisteet = p.Element("arvio").Value,
                          }).Distinct();
            DataTable table = new DataTable();
            table.Columns.Add("Viini", typeof(string));
            table.Columns.Add("Maa", typeof(string));
            table.Columns.Add("Pisteet", typeof(string));

            foreach(var p in parser)
            {
                table.Rows.Add(p.Viini, p.Maa, p.Pisteet);
            }
            dataGrid.DataContext = null;
            dataGrid.DataContext = table;
        }
    }
}
