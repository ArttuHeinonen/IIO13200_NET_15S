using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarkkaASP
{
    public class BLResource
    {
        public List<Resource> res = new List<Resource>();

        public BLResource()
        {
            CreateResource("Food", 500, 1, true);
            CreateResource("Wood", 100, 0.5f, true);
            CreateResource("Stone", 25, 0.01f, true);
            CreateResource("Science", 200, 1f, true);
        }

        private void CreateResource(string name, float maxValue, float inc, bool isAvailable)
        {
            res.Add(new Resource(name, 0, maxValue, inc, isAvailable));
        }
        public void IncrementAllResources()
        {
            for (int i = 0; i < res.Count; i++)
            {
                if (res[i].isAvailable)
                {
                    res[i].value += res[i].increment;
                    IsResourceMaxed(res[i]);
                }
            }
        }
        public void IncrementResource(string name, float inc)
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

        public void AddResource(string name, float amount)
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
