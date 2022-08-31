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
        public Tootaja(string asutus, string amet, double tootasu)
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
            Console.WriteLine($"Age: {arvutaVanus()}");
            Console.WriteLine($"Asutus: {asutus}");
            Console.WriteLine($"Amet: {amet}");
            Console.WriteLine($"Tootasu: {tootasu}");
        }
    }
}
