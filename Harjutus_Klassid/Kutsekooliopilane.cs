using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjutus_Klassid
{
    class Kutsekooliopilane : Isik
    {
        public string oppeasutus;
        public int kursus;
        public string eriala;
        public string toetus;

        public Kutsekooliopilane() { }
        public Kutsekooliopilane(string nimi, int synniaasta, Sugu sugu, string indeks, string konna, string oppeasutus, int kursus, string eriala, string toetus) : base(nimi, synniaasta, sugu, indeks, konna)
        {
            this.oppeasutus = oppeasutus;
            this.kursus = kursus;
            this.eriala = eriala;
            this.toetus = toetus;
        }

        public override void printInfo()
        {
            Console.WriteLine($"Nimi: {nimi}");
            Console.WriteLine($"Sünniaasta: {synniaasta}");
            Console.WriteLine($"Sugu: {sugu}");
            Console.WriteLine($"Sihtnumber: {indeks}");
            Console.WriteLine($"Suuremad postipiirkonna: {arvutaKonna()}");
            Console.WriteLine($"Age: {arvutaVanus()}");
            Console.WriteLine($"Õppeasutus: {oppeasutus}");
            Console.WriteLine($"Kursus: {kursus}");
            Console.WriteLine($"Eriala: {eriala}");
        }
    }
}
