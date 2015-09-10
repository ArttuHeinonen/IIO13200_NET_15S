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
        private List<int> luvut = new List<int>();

        public Lotto(int suurinNro, int numeroLkm, Boolean useStars)
        {
            this.SuurinNro = suurinNro;
            this.NumeroLkm = numeroLkm;
            this.UseStars = useStars;
            this.StarsNro = 8;
        }

        public List<int> ArvoRivi(Random rnd)
        {

            for (int i = 0; i < NumeroLkm; i++)
            {
                LisaaLuku(SuurinNro, i, rnd);
            }

            if (UseStars)
            {
                for (int i = 0; i < 2; i++)
                {
                    LisaaLuku(StarsNro, i, rnd);
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

        private Boolean OnkoNumeroJoArvottu(int luku)
        {
            for (int i = 0; i < luvut.Count; i++)
            {
                if (luku == luvut[i])
                {
                    return true;
                }
            }
            return false;
        }

        private void LisaaLuku(int SuurinNro, int i, Random rnd)
        {
            luvut.Add(rnd.Next(1, SuurinNro + 1));
            if (OnkoNumeroJoArvottu(luvut[i]))
            {
                while (!OnkoNumeroJoArvottu(luvut[i]))
                {
                    luvut[i] = rnd.Next(1, SuurinNro + 1);
                }
            }
        }
    }
}
