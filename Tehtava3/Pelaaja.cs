using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava3
{
    class Pelaaja
    {

        
        public String Kokonimi { get; }
        public String  Etunimi { get; }
        public String Sukunimi { get; }
        public String Seura { get; }
        public int Siirtohinta { get; }

        public Pelaaja(String etunimi, String sukunimi, String seura, int siirtohinta)
        {
            this.Etunimi = etunimi;
            this.Sukunimi = sukunimi;
            this.Seura = seura;
            this.Kokonimi = Etunimi + " " + Sukunimi + ", " + Seura;
            this.Siirtohinta = siirtohinta;
        }
    }
}
