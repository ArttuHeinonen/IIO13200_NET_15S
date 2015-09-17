using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
        Microsoft.Win32.SaveFileDialog dialog = new Microsoft.Win32.SaveFileDialog();

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
                statusText.Text = "Player added.";
            }
        }

        private void buttonLopeta_Click(object sender, RoutedEventArgs e)
        {
            statusText.Text = "Closing!";
            this.Close();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pelaaja temp = (Pelaaja)listBox.SelectedItem;
            try
            {
                textBoxEtunimi.Text = temp.Etunimi;
                textBoxSukunimi.Text = temp.Sukunimi;
                textBoxSiirtohinta.Text = temp.Siirtohinta.ToString();
                comboBoxSeura.Text = temp.Seura;
            }
            catch
            {
                emptyFields();
            }
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
                statusText.Text = "Error: Value missing!";
                return false;
            }
            else if (isValueDublicate(textBoxEtunimi.Text + " " + textBoxSukunimi.Text + ", " + comboBoxSeura.Text))
            {
                statusText.Text = "Error: Duplicate value!";
                return false;
            }
            return true;
        }

        private void emptyFields()
        {
            textBoxEtunimi.Text = "";
            textBoxSukunimi.Text = "";
            textBoxSiirtohinta.Text = "";
            comboBoxSeura.Text = "Blues";
        }

        private void buttonTallenna_Click(object sender, RoutedEventArgs e)
        {
            int index = listBox.Items.IndexOf(listBox.SelectedItem);
            if (validateFields())
            {
                pelaajat[index].ChangeValues(textBoxEtunimi.Text, textBoxSukunimi.Text, comboBoxSeura.Text, hinta);
                listBox.Items.Refresh();
            }
            statusText.Text = "Player added.";
        }

        private void buttonPoista_Click(object sender, RoutedEventArgs e)
        {
            Pelaaja temp = (Pelaaja)listBox.SelectedItem;
            emptyFields();
            pelaajat.Remove(temp);
            listBox.Items.Refresh();
            statusText.Text = "Player deleted.";
        }

        private void buttonKirjoita_Click(object sender, RoutedEventArgs e)
        {
            dialog.FileName = "Document";
            dialog.DefaultExt = ".dat";
            dialog.Filter = "Dat file mon (.dat)|*.dat";
            Nullable<bool> result = dialog.ShowDialog();

            if (result == true)
            {
                string filename = dialog.FileName;
                using (StreamWriter outfile = new StreamWriter(filename))
                {
                    foreach (Pelaaja pelaaja in pelaajat)
                    {
                        outfile.WriteLine(pelaaja.Kokonimi);
                    }
                }
                statusText.Text = "Player saved!";
            }
            else
            {
                statusText.Text = "Player not saved!";
            }
        }
    }
}
