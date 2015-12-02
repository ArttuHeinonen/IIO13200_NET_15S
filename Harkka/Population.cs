using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harkka
{
    public class Population
    {
        public int maxPopulation { get; set; }
        public int thinkers { get; set; }
        public int woodcutters { get; set; }
        public int foragers { get; set; }
        public int miners { get; set; }
        public int guards { get; set; }

        public Population(int maxPopulation)
        {
            this.maxPopulation = maxPopulation;
            this.thinkers = maxPopulation;
        }
    }
}
