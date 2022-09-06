using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Harjutus_Klassid
{
    class Opilane : Isik
    {
        public string koolinimi;
        public int klass;
        public string spets;

        public Opilane() { }
        public Opilane(string nimi, int synniaasta, Sugu sugu, string indeks, string konna, string koolinimi, int klass, string spets) : base(nimi, synniaasta, sugu, indeks, konna)
        {
            this.koolinimi = koolinimi;
            this.klass = klass;
            this.spets = spets;
        }

        public override void printInfo()
        {
            Console.WriteLine($"Nimi: {nimi}");
            Console.WriteLine($"Sünniaasta: {synniaasta}");
            Console.WriteLine($"Sugu: {sugu}");
            Console.WriteLine($"Sihtnumber: {indeks}");
            Console.WriteLine($"Suuremad postipiirkonna: {arvutaKonna()}");
            Console.WriteLine($"Age: {arvutaVanus()}");
            Console.WriteLine($"Koolinimi: {koolinimi}");
            Console.WriteLine($"Klass: {klass}");
            Console.WriteLine($"Spetsialiseerumine: {spets}");
        }
    }
}
