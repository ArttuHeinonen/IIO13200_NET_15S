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

namespace Tehtava2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonDraw_Click(object sender, RoutedEventArgs e)
        {
            int SuurinNro, NumeroLkm;
            Boolean UseStars = false;
            List<Lotto> lotot = new List<Lotto>();
            List<int> luvut = new List<int>();
            String sarja = "";
            Random rnd = new Random();

            switch (ComboType.SelectedIndex)
            {
                case 0:
                    SuurinNro = 39;
                    NumeroLkm = 7;
                    break;
                case 1:
                    SuurinNro = 48;
                    NumeroLkm = 6;
                    break;
                case 2:
                    SuurinNro = 50;
                    NumeroLkm = 5;
                    UseStars = true;
                    break;
                default:
                    SuurinNro = 0;
                    NumeroLkm = 0;
                    break;
            }

            for (int i = 0; i < int.Parse(this.TxtDraws.Text); i++)
            {
                lotot.Add(new Lotto(SuurinNro, NumeroLkm, UseStars));
                luvut = lotot[i].ArvoRivi(rnd).ToList();
                for (int j = 0; j < luvut.Count; j++)
                {
                    sarja += luvut[j] + " ";
                }
                Result.Items.Add(sarja);
                sarja = "";
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            Result.Items.Clear();
        }
    }
}
