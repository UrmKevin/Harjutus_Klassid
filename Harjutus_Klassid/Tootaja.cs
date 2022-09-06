using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjutus_Klassid
{
    class Tootaja : Isik
    {
        public string asutus;
        public string amet;
        public double tootasu;

        public Tootaja() { }
        public Tootaja(string nimi, int synniaasta, Sugu sugu, string indeks, string konna, string asutus, string amet, double tootasu) : base(nimi, synniaasta, sugu, indeks, konna)
        {
            this.asutus = asutus;
            this.amet = amet;
            this.tootasu = tootasu;
        }

        public double arvatuSissetulek(double maksuvaba, double tulumaks)
        {
            double netopalk = ((tootasu - maksuvaba) * (tulumaks / 100)) + maksuvaba;
            return netopalk;
        }
        public override void printInfo()
        {
            Console.WriteLine($"Nimi: {nimi}");
            Console.WriteLine($"Sünniaasta: {synniaasta}");
            Console.WriteLine($"Sugu: {sugu}");
            Console.WriteLine($"Sihtnumber: {indeks}");
            Console.WriteLine($"Suuremad postipiirkonna: {arvutaKonna()}");
            Console.WriteLine($"Age: {arvutaVanus()}");
            Console.WriteLine($"Asutus: {asutus}");
            Console.WriteLine($"Amet: {amet}");
            Console.WriteLine($"Netopalk: {arvatuSissetulek(500,20)}");
        }
    }
}
