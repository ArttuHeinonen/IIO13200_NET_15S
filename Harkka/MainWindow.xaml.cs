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

        }

        private void buttonHarvest_Click(object sender, RoutedEventArgs e)
        {
            if (!res.doesResourceExist("Food"))
            {
                res.CreateResource("Food", 500); 
            }
            else
            {
                res.IncrementResource("Food", 1);
            }
            
            dataGrid.ItemsSource = res.res;
        }
    }
}
