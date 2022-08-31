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
        public Opilane(string nimi, int synniaasta, Sugu sugu, string koolinimi, int klass, string spets)// : base(nimi, synniaasta)
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
            Console.WriteLine($"Age: {arvutaVanus()}");
            Console.WriteLine($"Koolinimi: {koolinimi}");
            Console.WriteLine($"Klass: {klass}");
            Console.WriteLine($"Spetsialiseerumine: {spets}");
        }
    }
}
