using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava2
{
    class Lotto
    {
        public String Tyyppi;
        private int SuurinNro, StarsNro;
        private int NumeroLkm;
        private Boolean UseStars = false;

        public Lotto(int suurinNro, int numeroLkm, Boolean useStars)
        {
            this.SuurinNro = suurinNro;
            this.NumeroLkm = numeroLkm;
            this.UseStars = useStars;
            this.StarsNro = 8;
        }

        public List<int> ArvoRivi(Random rnd)
        {
            List<int> luvut = new List<int>();

            for(int i = 0; i < NumeroLkm; i++)
            {
                luvut.Add(rnd.Next(1, SuurinNro + 1));
            }

            if (UseStars)
            {
                for (int i = 0; i < 2; i++)
                {
                    luvut.Add(rnd.Next(1, StarsNro + 1));
                }
            }

            return luvut;
        }
        public List<int> ArvoRivi(String Tyyppi)
        {
            return null;
        }

        public List<int> ArvoStartRivi(Random rnd)
        {
            List<int> luvut = new List<int>();

            return luvut;
        }
    }
}
