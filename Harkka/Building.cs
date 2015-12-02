using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harkka
{
    public class Building
    {
        public string name { get; set; }
        public int amount { get; set; }
        public List<ReqResource> requirements { get; set; }

        public Building(string name, List<ReqResource> requirements)
        {
            this.name = name;
            this.requirements = new List<ReqResource>(requirements);
        }
    }

    public class ReqResource
    {
        public String resName { get; set; }
        public float value { get; set; }
        public float inc { get; set; }

        public ReqResource(String resName, float value, float inc)
        {
            this.resName = resName;
            this.value = value;
            this.inc = inc;
        }
    }
}
