using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harkka
{
    public class BLBuilding
    {
        public List<Building> buildings = new List<Building>();

        public BLBuilding()
        {
            CreateBuilding("Hut", "Wood", 20);
        }

        private void CreateBuilding(string name, String reqRes, float reqValue)
        {
            buildings.Add(new Building(name, reqRes, reqValue));
        }
    }
}
