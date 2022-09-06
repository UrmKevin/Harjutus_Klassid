using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjutus_Klassid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tootaja tootaja = new Tootaja("Ash", 1990, Isik.Sugu.naine, "31204", "31204", "asd", "amet", 2000);
            tootaja.printInfo();
            Console.WriteLine();

            Kutsekooliopilane kutsekooliopilane = new Kutsekooliopilane("Daniel", 1990, Isik.Sugu.mees, "12463", "12463", "Tartu Tehnikaülikool ", 3, "tarkvaraarendaja", "..");
            kutsekooliopilane.printInfo();
            Console.WriteLine();

            Opilane opilane = new Opilane("Marta", 1990, Isik.Sugu.naine, "13521" ,"13521", "TLVL", 9, "humanitaar");
            opilane.printInfo();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
