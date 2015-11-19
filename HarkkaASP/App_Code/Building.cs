using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarkkaASP
{
    public class Building
    {
        public string name { get; set; }
        public String reqRes { get; set; }
        public float reqValue { get; set; }

        public Building(string name, String reqRes, float reqValue)
        {
            this.name = name;
            this.reqRes = reqRes;
            this.reqValue = reqValue;
        }
    }
}
