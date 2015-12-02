using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarkkaASP
{
    public class BLBuilding
    {
        public List<Building> buildings = new List<Building>();
        List<ReqResource> hutReq = new List<ReqResource>();
        List<ReqResource> outpostReq = new List<ReqResource>();

        public BLBuilding()
        {
            CreateBuilding("Hut", hutReq);
            CreateBuilding("Hunt copse", outpostReq);
        }

        private void CreateBuilding(string name, List<ReqResource> req)
        {
            buildings.Add(new Building(name, req));
        }

        private void InitializeBuildingRequirements()
        {
            hutReq.Add(new ReqResource("Wood", 20, 1.2f));
            outpostReq.Add(new ReqResource("Wood", 30, 1.1f));
            outpostReq.Add(new ReqResource("Food", 10, 1.3f));
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
                if(!(req.value >= resources.GetResource(req.resName).value))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
