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

namespace Tehtava3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Pelaaja> pelaajat = new List<Pelaaja>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonUusi_Click(object sender, RoutedEventArgs e)
        {
            int hinta;

            if(textBoxEtunimi.Text == "" || textBoxSukunimi.Text == "" || (!int.TryParse(textBoxSiirtohinta.Text, out hinta)))
            {
                MessageBox.Show("Values missing!", "Error");
            }
            else if(isValueDublicate(textBoxEtunimi.Text + " " + textBoxSukunimi.Text + ", " + comboBoxSeura.Text))
            {
                MessageBox.Show("Duplicate value!", "Error");
            }
            else
            {
                pelaajat.Add(new Pelaaja(textBoxEtunimi.Text, textBoxSukunimi.Text, comboBoxSeura.Text, hinta));
                listBox.Items.Add(pelaajat.Last().Kokonimi);
            }
        }

        private void buttonLopeta_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for(int i = 0; i < pelaajat.Count; i++)
            {
                if(listBox.SelectedItem.ToString().Equals(pelaajat[i].Kokonimi, StringComparison.Ordinal))
                {
                    textBoxEtunimi.Text = pelaajat[i].Etunimi;
                    textBoxSukunimi.Text = pelaajat[i].Sukunimi;
                    textBoxSiirtohinta.Text = pelaajat[i].Siirtohinta.ToString();
                    comboBoxSeura.Text = pelaajat[i].Seura;
                }
            }

        }

        private Boolean isValueDublicate(String value)
        {
            for(int i = 0; i < pelaajat.Count; i++)
            {
                if (value.Equals(pelaajat[i].Kokonimi, StringComparison.Ordinal))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
