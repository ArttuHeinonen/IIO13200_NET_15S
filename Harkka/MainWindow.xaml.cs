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
using System.Windows.Threading;

namespace Harkka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        BLResource res = new BLResource();
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            res.IncrementResource("Food");
            updateDataGrid();
        }

        private void buttonHarvest_Click(object sender, RoutedEventArgs e)
        {
            if (!res.doesResourceExist("Food"))
            {
                //Don't hide resource
            }
            else
            {
                res.AddResource("Food", 1);
                res.AddResource("Wood", 0.5f);
            }
            updateDataGrid();
        }

        private void buttonHut_Click(object sender, RoutedEventArgs e)
        {

        }

        private void updateDataGrid()
        {
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = res.res;
        }
    }
}
