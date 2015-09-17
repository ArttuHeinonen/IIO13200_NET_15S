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
using System.Windows.Shapes;
using System.Data;

namespace Tehtava4
{
    /// <summary>
    /// Interaction logic for ViinikellariDataset.xaml
    /// </summary>
    public partial class ViinikellariDataset : Window
    {

        private List<String> maat = new List<string>();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataView dv = new DataView();

        public ViinikellariDataset()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            //luetaan koko XML DataSettiin
            //DateSE in memory database
            try
            {
                String filu = "viinit1.xml";
                ds.ReadXml(filu);
                dt = ds.Tables[0];
                dv = dt.DefaultView;
                dataGrid.ItemsSource = dv;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dv.RowFilter = "maa LIKE " + comboBox.SelectedValue.ToString();
        }
    }
}
