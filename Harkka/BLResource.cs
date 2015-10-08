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

        

        public void CreateResource(string name, float maxValue)
        {
            res.Add(new Resource(name, 1, maxValue));
        }

        public void IncrementResource(string name, float inc)
        {
            foreach (Resource r in res)
            {
                if (r.name == name)
                {
                    r.value += inc;
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
