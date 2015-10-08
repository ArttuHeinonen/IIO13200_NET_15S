using System;
using System.Collections.Generic;
using System.Collections;
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

/*
* Copyleft NN
*
* This file is part of the BLLotto project.
*
* Created: not date
* Authors: Nicke Nackenström
*/ 


namespace WinLotto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Variables
        JAMK.IT.WinLotto.Lotto Lottery = new JAMK.IT.WinLotto.Lotto();
        #endregion

        #region Constructors

        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods (GUI Events)

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                uint rows = Convert.ToUInt32(txtboxDraws.Text);
                GenerateLotteryNumbersVerOld(rows);
            }

            catch (FormatException fex)
            {
                MessageBox.Show("Amount of lottery rows to draw needs to be a number!");
                txtboxDraws.Text = "";
            }

            catch (OverflowException ofex)
            {
                MessageBox.Show("Amount of lottery rows to draw can't be negative!");
                txtboxDraws.Text = "";
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtboxNumbers.Text = "";
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        #endregion

        #region Methods (Lottery)

        private void GenerateLotteryNumbersVerOld(uint rows)
        {
            string numberString = "";
            for (int j = 0; j < rows; j++)
            {
                //ArrayList list;
                List<int> lista;
                Lottery.LotteryType = cmbSelection.SelectedValue.ToString();
                lista = Lottery.ArvoRivi();
                numberString += "Row " + (j + 1) + ":  ";
                for (int i = 0; i < lista.Count; i++)
                {
                    numberString += lista[i].ToString();
                    numberString += " ";
                }
                numberString += Environment.NewLine;
            }
             txtboxNumbers.Text = numberString;
         }
    #endregion

    private void btnGetWeek_Click(object sender, RoutedEventArgs e)
    {
      //veikkaus announce week in format "ww/yyyy" for example "41/2015"
      string resu = "";

      MessageBox.Show(resu);
    }
  }
}
