using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harkka
{
    class BLResource
    {
        public List<Resource> res = new List<Resource>();

        public BLResource()
        {
            CreateResource("Food", 500, 1);
            CreateResource("Wood", 100, 0.5f);
            CreateResource("Stone", 25, 0.01f);
            CreateResource("Science", 200, 1f);
        }

        private void CreateResource(string name, float maxValue, float inc)
        {
            res.Add(new Resource(name, 0, maxValue, inc));
        }
        public void IncrementAllResources()
        {
            foreach (Resource r in res)
            {
                r.value += r.increment;
                isResourceMaxed(r);
            }
        }
        public void IncrementResource(string name)
        {
            foreach (Resource r in res)
            {
                if (r.name == name)
                {
                    r.value += r.increment;
                    isResourceMaxed(r);
                }
            }
        }

        public void AddResource(string name, float amount)
        {
            foreach (Resource r in res)
            {
                if (r.name == name)
                {
                    r.value += amount;
                    isResourceMaxed(r);
                }
            }
        }
        public Boolean doesResourceExist(string name)
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
        public Boolean isResourceMaxed(Resource r)
        {
            if(r.value > r.maxValue)
            {
                r.value = r.maxValue; 
                return true;
            }
            return false;
        }

    }
}
