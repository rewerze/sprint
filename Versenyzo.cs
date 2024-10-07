using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_Verseny
{
    internal class Versenyzo
    {
        public string Nev { get; set; }
        public int SzulEv { get; set; }
        public int Rajtszam { get; set; }
        public string Nem { get; set; }
        public string Kategoria { get; set; }
        public DateTime Uszas { get; set; }
        public DateTime DepoEgy { get; set; }
        public DateTime Kerekpar { get; set; }
        public DateTime DepoKetto { get; set; }
        public DateTime Futas { get; set; }

        public Versenyzo(string sor) {
            var darab = sor.Split(';');
            Nev = darab[0];
            SzulEv = int.Parse(darab[1]);
            Rajtszam = int.Parse(darab[2]);
            Nem = darab[3];
            Kategoria = darab[4];
            Uszas = DateTime.Parse(darab[5]);
            DepoEgy = DateTime.Parse(darab[6]);
            Kerekpar = DateTime.Parse(darab[7]);
            DepoKetto = DateTime.Parse(darab[8]);
            Futas = DateTime.Parse(darab[9]);

        }

        public override string ToString()
        {
            return $"{Nev}:\n\tKor: {DateTime.Now.Year - SzulEv}\n\tRajtszam: {Rajtszam}\n\tNem: {Nem}\n\tKategória: {Kategoria}";
        }
    }
}
