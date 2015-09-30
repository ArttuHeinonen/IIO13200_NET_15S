﻿using System;
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

namespace Tehtava5
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

        private void buttonGetDataTable_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.DataContext = Tehtava5.DBDemoxOy.GetDataReal().DefaultView;
        }

        private void buttonGetDataView_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.DataContext = Tehtava5.DBDemoxOy.GetDataFiltered(textBox.Text);
        }

        private void buttonGetDataSet_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
