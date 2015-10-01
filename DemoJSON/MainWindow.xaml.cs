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

namespace DemoJSON
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string JSON = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonGetJSON_Click(object sender, RoutedEventArgs e)
        {
            Demo2ASync();
        }

        #region Methods
        private void Demo1()
        {

            JSON = GetJSONFromURL("http://student.labranet.jamk.fi/~salesa/mat/JsonTest");

            List <Politic> politics = JsonConvert.DeserializeObject<List<Politic>>(JSON);
            textBoxJSON.Text = JSON;
            dataGrid.DataContext = politics;
        }
        private void Demo2()
        {
            JSON = GetJSONFromWeb();
            List<Politic> politics = JsonConvert.DeserializeObject<List<Politic>>(JSON);
            textBoxJSON.Text = JSON;
            dataGrid.DataContext = politics;
        }
        private void Demo2ASync()
        {
            //Haetaan JSON oikeasti webistä omassa threadissa

            new Thread(() =>
            {
                string result = GetJSONFromWeb();
                Dispatcher.BeginInvoke((Action)(() =>
                    {
                        textBoxJSON.Text = "Loading content from web...";
                        List<Politic> politics = JsonConvert.DeserializeObject<List<Politic>>(result);
                        dataGrid.DataContext = politics;
                    }));
            }).Start();
            textBoxJSON.Text = "Loading content from web...";
        }

        private string GetSimpleJSON()
        {
            return @"[
                        {'Name':'Olli Opiskelija', 'Gender':'Male', 'Birthday':'1995-12-24'},
                        {'Name':'Matti Mieskolainen', 'Gender':'Male', 'Birthday':'1955-02-14'}]";
        }
        private string GetJSONFromURL(string url)
        {
            try
            {

                return new WebClient().DownloadString(url);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string GetJSONFromWeb()
        {
            try
            {
                string url = string.Format("http://student.labranet.jamk.fi/~salesa/mat/JsonTest");
                using (WebClient wc = new WebClient())
                {
                    var json = wc.DownloadString(url);
                    return json;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
    }
}
