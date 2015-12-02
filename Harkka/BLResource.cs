using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harkka
{
    public class BLResource
    {
        public List<Resource> res = new List<Resource>();

        public BLResource()
        {
            CreateResource("Population", 1, true);
            res[0].value = 1;
            CreateResource("Food", 500, true);
            CreateResource("Wood", 100, true);
            CreateResource("Stone", 25, true);
            CreateResource("Science", 200, true);
            CreateResource("Faith", 40, true);
            CreateResource("Gold", 120, true);
        }

        private void CreateResource(string name, float maxValue, bool isAvailable)
        {
            res.Add(new Resource(name, 0, maxValue, isAvailable));
        }
        public void IncrementAllResources(BLPopulation pop)
        {
            for (int i = 0; i < res.Count; i++)
            {
                if (res[i].isAvailable)
                {
                    switch (res[i].name)
                    {
                        case "Wood":
                            res[i].increment = pop.pop.woodcutters;
                            res[i].value += res[i].increment;
                            break;
                        case "Food":
                            res[i].increment = pop.pop.foragers * 1.5f;
                            res[i].value += res[i].increment;
                            break;
                        case "Science":
                            res[i].increment = pop.pop.thinkers;
                            res[i].value += res[i].increment;
                            break;
                        case "Stone":
                            res[i].increment = pop.pop.miners;
                            res[i].value += res[i].increment;
                            break;
                        default:
                            break;
                    }
                    IsResourceMaxed(res[i]);
                }
            }
        }
        public void IncrementResource(string name)
        {
            foreach (Resource r in res)
            {
                if (r.name == name)
                {
                    r.value += r.increment;
                    IsResourceMaxed(r);
                }
            }
        }

        public void ResetResourceValues()
        {
            foreach (Resource r in res)
            {
                r.value = 0;
            }
        }

        public void AddResource(String name, float amount)
        {
            foreach (Resource r in res)
            {
                if (r.name == name)
                {
                    r.value += amount;
                    IsResourceMaxed(r);
                }
            }
        }

        public void AddMaxResource(String name, float amount)
        {
            foreach (Resource r in res)
            {
                if (r.name == name)
                {
                    r.maxValue += amount;
                }
            }
        }
        public Boolean DoesResourceExist(string name)
        {
            foreach (Resource r in res)
            {
                if (r.name == name)
                {
                    return true;
                }
            }
            return false;
        }
        public Boolean IsResourceMaxed(Resource r)
        {
            if(r.value > r.maxValue)
            {
                r.value = r.maxValue; 
                return true;
            }
            return false;
        }
        public List<Resource> GetResources()
        {
            return res;
        }

        public Resource GetResource(String name)
        {
            foreach (Resource r in res)
            {
                if (r.name == name)
                {
                    return r;
                }
            }
            return null;
        }

        public List<Resource> GetAvailableResources()
        {
            List<Resource> tmp = new List<Resource>();
            foreach (Resource r in res)
            {
                if (r.isAvailable)
                {
                    tmp.Add(r);
                }
            }
            return tmp;
        }
    }
}
