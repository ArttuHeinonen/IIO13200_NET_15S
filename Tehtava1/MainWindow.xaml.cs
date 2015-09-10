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

namespace IkkunanpintaAla
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int ala, piiri, karmiAla;

                ala = getIkkunanAla();
                piiri = getKarminPiiri();
                karmiAla = getKarminAla();


                this.textBox4.Text = ala.ToString();
                this.textBox5.Text = piiri.ToString();
                this.textBox6.Text = karmiAla.ToString();
            }
            catch (Exception ex)
            {
                this.textBox4.Text = "Error";
                this.textBox5.Text = "Error";
                this.textBox6.Text = "Error";
            }
        }

        private int getIkkunanLeveys()
        {
            return int.Parse(textBox1.Text);
        }
        private int getIkkunaKorkeus()
        {
            return int.Parse(textBox2.Text);
        }
        private int getKarminLeveys()
        {
            return int.Parse(textBox3.Text);
        }
        private int getIkkunanAla()
        {
            return getIkkunaKorkeus() * getIkkunanLeveys();
        }
        private int getKarminPiiri()
        {
            return (getIkkunanLeveys() + getKarminLeveys() * 2) * 2 + (getIkkunaKorkeus() + getKarminLeveys() * 2) * 2;
        }
        private int getKarminAla()
        {
            return (getIkkunanLeveys() + 2 * getKarminLeveys()) * (getIkkunaKorkeus() + 2 * getKarminLeveys()) - getIkkunanAla();
        }
    }
}
