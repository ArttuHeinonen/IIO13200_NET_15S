using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        ObservableCollection<Pelaaja> pelaajat = new ObservableCollection<Pelaaja>();
        int hinta;

        public MainWindow()
        {
            InitializeComponent();
            listBox.ItemsSource = pelaajat;
            listBox.DisplayMemberPath = "Kokonimi";
        }

        private void buttonUusi_Click(object sender, RoutedEventArgs e)
        { 
            if (validateFields())
            {
                pelaajat.Add(new Pelaaja(textBoxEtunimi.Text, textBoxSukunimi.Text, comboBoxSeura.Text, hinta));
            }
        }

        private void buttonLopeta_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pelaaja temp = (Pelaaja)listBox.SelectedItem;
            textBoxEtunimi.Text = temp.Etunimi;
            textBoxSukunimi.Text = temp.Sukunimi;
            textBoxSiirtohinta.Text = temp.Siirtohinta.ToString();
            comboBoxSeura.Text = temp.Seura;

        }

        private Boolean isValueDublicate(String kokonimi)
        {
            for(int i = 0; i < pelaajat.Count; i++)
            {
                if (kokonimi.Equals(pelaajat[i].Kokonimi, StringComparison.Ordinal))
                {
                    return true;
                }
            }
            return false;
        }

        private Boolean validateFields()
        {
            if (textBoxEtunimi.Text == "" || textBoxSukunimi.Text == "" || (!int.TryParse(textBoxSiirtohinta.Text, out hinta)))
            {
                MessageBox.Show("Values missing!", "Error");
                return false;
            }
            else if (isValueDublicate(textBoxEtunimi.Text + " " + textBoxSukunimi.Text + ", " + comboBoxSeura.Text))
            {
                MessageBox.Show("Duplicate value!", "Error");
                return false;
            }
            return true;
        }

        private void buttonTallenna_Click(object sender, RoutedEventArgs e)
        {
            Pelaaja temp = (Pelaaja)listBox.SelectedItem;
            if (validateFields())
            {
                temp.ChangeValues(textBoxEtunimi.Text, textBoxSukunimi.Text, comboBoxSeura.Text, hinta);
                pelaajat[listBox.Items.IndexOf(listBox.SelectedItem)].ChangeValues(textBoxEtunimi.Text, textBoxSukunimi.Text, comboBoxSeura.Text, hinta);
            }
        }
    }
}
