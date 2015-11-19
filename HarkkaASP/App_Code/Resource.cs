using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarkkaASP
{
    public class Resource
    {
        public string name { get; set; }
        public float value { get; set; }
        public float maxValue { get; set; }
        public float increment { get; set; }
        public bool isAvailable { get; set; }

        public Resource(string name, float value, float maxValue, float inc, bool isAvailable)
        {
            this.name = name;
            this.value = value;
            this.maxValue = maxValue;
            this.increment = inc;
            this.isAvailable = isAvailable;
        }
    }
}
