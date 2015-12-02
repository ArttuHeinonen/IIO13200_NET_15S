using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harkka
{
    public class BLPopulation
    {

        public Population pop;

        public BLPopulation(int maxPopulation)
        {
            this.pop = new Population(maxPopulation);
        }

        public void AddWoodcutter()
        {
            if(pop.thinkers > 0)
            {
                pop.thinkers--;
                pop.woodcutters++;
            }
        }

        public void SubWoodcutter()
        {
            if(pop.woodcutters > 0)
            {
                pop.woodcutters--;
                pop.thinkers++;
            }
        }

        public void AddForager()
        {
            if(pop.thinkers > 0)
            {
                pop.thinkers--;
                pop.foragers++;
            }
        }

        public void SubForager()
        {
            if(pop.foragers > 0)
            {
                pop.foragers--;
                pop.thinkers++;
            }
        }

        public void AddMiner()
        {
            if(pop.thinkers > 0)
            {
                pop.thinkers--;
                pop.miners++;
            }
        }

        public void SubMiner()
        {
            if(pop.miners > 0)
            {
                pop.miners--;
                pop.thinkers++;
            }
        }
    }
}
