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
        List<ReqResource> hutReq = new List<ReqResource>();
        List<ReqResource> trapReq = new List<ReqResource>();
        List<ReqResource> shrineReq = new List<ReqResource>();
        List<ReqResource> mineReq = new List<ReqResource>();

        public BLBuilding()
        {
            InitializeBuildingRequirements();
            CreateBuilding("Hut", hutReq);
            CreateBuilding("Trap", trapReq);
            CreateBuilding("Shrine", shrineReq);
            CreateBuilding("Mine", shrineReq);
        }

        private void CreateBuilding(string name, List<ReqResource> req)
        {
            buildings.Add(new Building(name, req));
        }

        private void InitializeBuildingRequirements()
        {
            hutReq.Add(new ReqResource("Wood", 20, 1.2f));
            trapReq.Add(new ReqResource("Wood", 30, 1.1f));
            trapReq.Add(new ReqResource("Food", 10, 1.3f));
            shrineReq.Add(new ReqResource("Stone", 5, 1.1f));
            shrineReq.Add(new ReqResource("Gold", 50, 1.6f));
            mineReq.Add(new ReqResource("Wood", 50, 1.4f));
        }

        public Building GetBuilding(String name)
        {
            foreach (Building building in buildings)
            {
                if (building.name == name)
                {
                    return building;
                }
            }
            return null;
        }

        public String GetRequirementsAsString(String name)
        {
            Building building = GetBuilding(name);
            String text = "";

            foreach (ReqResource req in building.requirements)
            {
                text += "\n" + req.resName + "\t\t\t" + req.value;
            }
            return text;
        }

        public BLResource BuyBuilding(String name, BLResource resources)
        {
            Building building = GetBuilding(name);

            foreach (ReqResource req in building.requirements)
            {
                resources.GetResource(req.resName).value -= req.value;
            }
            IncrementBuildingPrice("Hut");
            return resources;
        }

        public void IncrementBuildingPrice(String buildingName)
        {
            foreach (Building building in buildings)
            {
                if (building.name == buildingName)
                {
                    building.amount++;
                    foreach (ReqResource req in building.requirements)
                    {
                        req.value *= req.inc;
                    }
                }
            }
        }

        public Boolean IsRequirementsMetForBuilding(String name, BLResource resources)
        {
            Building building = GetBuilding(name);

            foreach (ReqResource req in building.requirements)
            {
                if(req.value > resources.GetResource(req.resName).value)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
