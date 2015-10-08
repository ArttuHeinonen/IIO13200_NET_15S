using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harkka
{
    public class Resource
    {
        public string name { get; set; }
        public float value { get; set; }
        public float maxValue { get; set; }
        public Resource(string name, float value, float maxValue)
        {
            this.name = name;
            this.value = value;
            this.maxValue = maxValue;
        }
    }
}
