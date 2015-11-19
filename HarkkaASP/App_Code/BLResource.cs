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
                IsResourceMaxed(r);
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
        public DataTable GetResources()
        {
            DataTable dt = new DataTable();
            return dt;
        }
    }
}
