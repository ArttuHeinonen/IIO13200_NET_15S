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
using System.Xml.Linq;

namespace Tehtava8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime today = DateTime.Today;
        private BLFeedback feedback = new BLFeedback();

        public MainWindow()
        {
            InitializeComponent();
            LoadFeedback();
            labelDate.Content = String.Format("{0:dd.MM.yyyy}", today);
        }

        private void LoadFeedback()
        {
            dataGrid.ItemsSource = feedback.getDataFromXML();
        }

        private void buttonSend_Click(object sender, RoutedEventArgs e)
        {
            if (!isFieldsEmpty())
            {
                sanitizeFields();
                feedback.pushDataToXML(today, textBoxName.Text, textBoxLearned.Text, textBoxWantToLearn.Text, textBoxGood.Text, textBoxImprovement.Text, textBoxOther.Text);
                dataGrid.ItemsSource = feedback.getDataFromXML();
            }
        }

        private void sanitizeFields()
        {

        }

        private Boolean isFieldsEmpty()
        {
            if(textBoxName.Text == "" || textBoxLearned.Text == "" || textBoxWantToLearn.Text == "" || textBoxGood.Text == "" || textBoxImprovement.Text == "")
            {
                return true;
            }
            return false;
        }
    }
}
