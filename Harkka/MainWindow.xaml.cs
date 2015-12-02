using System;
using System.Collections.Generic;
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
using System.Windows.Threading;
using System.Xml.Serialization;

namespace Harkka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BLResource res = new BLResource();
        BLBuilding building = new BLBuilding();
        BLPopulation pop;

        public MainWindow()
        {
            InitializeComponent();
            pop = new BLPopulation((int)res.GetResource("Population").maxValue);
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            res.IncrementAllResources(pop);
            updateDataGrid();
        }

        private void buttonHarvest_Click(object sender, RoutedEventArgs e)
        {
            res.AddResource("Wood", 1);
            updateDataGrid();
        }

        private void buttonHunt_Click(object sender, RoutedEventArgs e)
        {
            res.AddResource("Food", res.GetResource("Population").value * 1);
            updateDataGrid();
        }

        private void updateDataGrid()
        {
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = res.res;
        }

        private void updateButtons()
        {
            buttonHut.Content = "Hut (" + building.GetBuilding("Hut").amount + ")";
            buttonTrap.Content = "Trap (" + building.GetBuilding("Trap").amount + ")";
        }

        private void updatePopulationLabels()
        {
            labelThinker.Content = "Thinkers (" + pop.pop.thinkers + ")";
            labelWoodcutter.Content = "Woodcutters (" + pop.pop.woodcutters + ")";
            labelForager.Content = "Foragers (" + pop.pop.foragers + ")";
            labelMiner.Content = "Miners (" + pop.pop.miners + ")";
        }

        private void updateToolTip(String buildingName, String description, String requirements)
        {
            labelToolTip.Content = buildingName + "\n\n" + description + "\n" + requirements;
        }


        private void buttonWoodcutterPlus_Click(object sender, RoutedEventArgs e)
        {
            pop.AddWoodcutter();
            updatePopulationLabels();
        }

        private void buttonWoodcutterMinus_Click(object sender, RoutedEventArgs e)
        {
            pop.SubWoodcutter();
            updatePopulationLabels();
        }

        private void buttonForagerPlus_Click(object sender, RoutedEventArgs e)
        {
            pop.AddForager();
            updatePopulationLabels();
        }

        private void buttonForagerMinus_Click(object sender, RoutedEventArgs e)
        {
            pop.SubForager();
            updatePopulationLabels();
        }

        private void buttonMinerPlus_Click(object sender, RoutedEventArgs e)
        {
            pop.AddMiner();
            updatePopulationLabels();
        }

        private void buttonMinerMinus_Click(object sender, RoutedEventArgs e)
        {
            pop.SubMiner();
            updatePopulationLabels();
        }

        private void buttonHut_Click(object sender, RoutedEventArgs e)
        {
            if (building.IsRequirementsMetForBuilding("Hut", res))
            {
                building.BuyBuilding("Hut", res);
                res.AddMaxResource("Population", 2);
                res.AddResource("Population", 2);
                pop.pop.maxPopulation = (int)res.GetResource("Population").maxValue;
                pop.pop.thinkers += 2;
                updateDataGrid();
                updateButtons();
                updatePopulationLabels();
            }
        }

        private void buttonTrap_Click(object sender, RoutedEventArgs e)
        {
            if (building.IsRequirementsMetForBuilding("Trap", res))
            {
                building.BuyBuilding("Trap", res);
                updateDataGrid();
                updateButtons();
            }
        }

        private void buttonShrine_Click(object sender, RoutedEventArgs e)
        {
            if(building.IsRequirementsMetForBuilding("Shrine", res))
            {
                building.BuyBuilding("Shrine", res);
                updateDataGrid();
                updateButtons();
            }
        }

        private void buttonMine_Click(object sender, RoutedEventArgs e)
        {
            if(building.IsRequirementsMetForBuilding("Mine", res))
            {
                building.BuyBuilding("Mine", res);
                updateDataGrid();
                updateButtons();
            }
        }

        private void buttonHut_MouseEnter(object sender, MouseEventArgs e)
        {
            updateToolTip("Hut", "Comfty wooden hut for two.", building.GetRequirementsAsString("Hut"));
        }
        
        private void buttonTrap_MouseEnter(object sender, MouseEventArgs e)
        {
            updateToolTip("Trap", "Tool for catching food.", building.GetRequirementsAsString("Trap"));
        }

        private void buttonShrine_MouseEnter(object sender, MouseEventArgs e)
        {
            updateToolTip("Shrine", "Place of worship and prayer.", building.GetRequirementsAsString("Shrine"));
        }

        private void buttonMine_MouseEnter(object sender, MouseEventArgs e)
        {
            updateToolTip("Mine", "Mine where miner mine.", building.GetRequirementsAsString("Mine"));
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Resource));
                StreamWriter sw = new StreamWriter("save.xml");
                serializer.Serialize(sw, res.res);
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        private void buttonReset_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
