using System;
using System.Collections.Generic;
using System.Data;
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
    public partial class Viinikellari1 : Window
    {
        public String user { get; set; }
        private List<String> maat = new List<string>();
        public Viinikellari1()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
