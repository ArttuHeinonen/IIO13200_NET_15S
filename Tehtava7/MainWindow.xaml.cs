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
using Newtonsoft.Json;
using System.Net;
using System.Threading;

namespace Tehtava7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string JSON = "";
        DateTime day = DateTime.Today;

        public MainWindow()
        {
            InitializeComponent();
            PopulateComboBox();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            JSON = GetTrainsJSON();
            List<Train> trains = JsonConvert.DeserializeObject<List<Train>>(JSON);
            dataGrid.DataContext = trains;
        }
        private void PopulateComboBox()
        {
            new Thread(() =>
            {
                JSON = GetStationsJSON();
                Dispatcher.BeginInvoke((Action)(() =>
                {
                    List<Station> stations = JsonConvert.DeserializeObject<List<Station>>(JSON);
                    comboBox.DataContext = stations;
                }));
            }).Start();
        }
        private string GetTrainsJSON()
        {
            string station = (string)comboBox.SelectedValue;
            return GetJSON(string.Format("http://rata.digitraffic.fi/api/v1/live-trains?station=" + station));
        }

        private string GetStationsJSON()
        {
            return GetJSON(string.Format("http://rata.digitraffic.fi/api/v1/metadata/station"));
        }

        private string GetJSON(string url)
        {
            try
            { 
                using (WebClient wc = new WebClient())
                {
                    string json = wc.DownloadString(url);
                    return json;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
    }
}
