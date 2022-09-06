using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Harjutus_Klassid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Isik> people = new List<Isik>();

            Tootaja tootaja = new Tootaja("Ash", 1990, Isik.Sugu.naine, "31204", "31204", "asd", "amet", 2000, 79, 1.89);
            tootaja.printInfo();
            Console.WriteLine();

            Kutsekooliopilane kutsekooliopilane = new Kutsekooliopilane("Daniel", 1990, Isik.Sugu.mees, "12463", "12463", "Tartu Tehnikaülikool ", 3, "tarkvaraarendaja", "..", 91, 2.01);
            kutsekooliopilane.printInfo();
            Console.WriteLine();

            Opilane opilane = new Opilane("Marta", 1990, Isik.Sugu.naine, "13521" ,"13521", "TLVL", 9, "humanitaar", 65, 1.85);
            opilane.printInfo();
            Console.WriteLine();

            people.Add(tootaja);
            people.Add(kutsekooliopilane);
            people.Add(opilane);

            StreamWriter to_file = new StreamWriter(@"..\..\People.txt", false);
            foreach (Isik p in people)
            {
                p.printInfo();
                to_file.WriteLine(p.nimi + ", " + p.arvutaVanus() + ", " + p.sugu + ";");
            }
            to_file.Close();
            StreamReader from_file = new StreamReader(@"..\..\People.txt");
            List<string> lines = new List<string>();
            int n = from_file.ReadToEnd().Split(new char[] { '\n' }).Length;
            Console.WriteLine("-----" + n +"-----");
            Console.ReadKey();
        }
    }
}
