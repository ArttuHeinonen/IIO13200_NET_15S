﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava3
{
    class Pelaaja
    {
        public String  Etunimi { get; set; }
        public String Sukunimi { get; set; }
        public String Seura { get; set; }
        public int Siirtohinta { get; set; }
        public String Kokonimi
        {
            get {return Etunimi + " " + Sukunimi + ", " + Seura; }
        }

        public Pelaaja(String etunimi, String sukunimi, String seura, int siirtohinta)
        {
            this.Etunimi = etunimi;
            this.Sukunimi = sukunimi;
            this.Seura = seura;
            this.Siirtohinta = siirtohinta;
        }

        public Pelaaja(String tiedot)
        {
            String[] word = tiedot.Split(',');
            this.Etunimi = word[0];
            this.Sukunimi = word[1];
            this.Seura = word[2];
            this.Siirtohinta = Int32.Parse(word[3]);
        }

        public void ChangeValues(String etunimi, String sukunimi, String seura, int siirtohinta)
        {
            this.Etunimi = etunimi;
            this.Sukunimi = sukunimi;
            this.Seura = seura;
            this.Siirtohinta = siirtohinta;
        }

    }
}
