using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harkka
{
    class Building
    {
        public string name { get; set; }
        public float requirement { get; set; }

        public Building(string name, float req)
        {
            this.name = name;
            this.requirement = req;
        }
    }
}
