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

namespace Tehtava4
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Viinikellari1 vk = new Viinikellari1();
            vk.user = "Arttu Heinonen";
            vk.ShowDialog();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ViinikellariDataset vd = new ViinikellariDataset();
            vd.ShowDialog();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ViinikellariXDoc vdoc = new ViinikellariXDoc();
            vdoc.ShowDialog();
        }
    }
}
