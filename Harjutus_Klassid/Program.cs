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

            Tootaja Ash = new Tootaja("Ash", 1990, Isik.Sugu.naine, "31204", "31204", "asd", "amet", 2000, 79, 1.89);
            Console.WriteLine();

            Kutsekooliopilane Daniel = new Kutsekooliopilane("Daniel", 1990, Isik.Sugu.mees, "12463", "12463", "Tartu Tehnikaülikool ", 3, "tarkvaraarendaja", "..", 91, 2.01);
            Console.WriteLine();

            Opilane Marta = new Opilane("Marta", 1990, Isik.Sugu.naine, "13521" ,"13521", "TLVL", 9, "humanitaar", 65, 1.85);
            Console.WriteLine();

            people.Add(Ash);
            people.Add(Daniel);
            people.Add(Marta);

            StreamWriter sw = new StreamWriter(@"..\..\People.txt", false);
            foreach (Isik p in people)
            {
                p.printInfo();
                sw.WriteLine(p.nimi + ", " + p.arvutaVanus() + ", " + p.sugu + ", " + p.indeks + ", " + p.konna + ", " + p.kaal + ", " + p.pikkus + ";");
            }
            sw.Close();

            List<Opilane> opilased = new List<Opilane>();
            StreamReader sr = new StreamReader(@"..\..\People.txt");
            string text;
            while ((text = sr.ReadLine()) != null)
            {
                string[] rida = text.Split(' ');
                opilased.Add(new Opilane(rida[0], int.Parse(rida[1]), TextFailistEnumSugu(rida[2]), rida[3], rida[4]));//, rida[5], int.Parse(rida[6]), rida[7] , double.Parse(rida[8]), double.Parse(rida[9])
            }
            sr.Close();
            foreach(var opilane1 in opilased)
            {
                Console.WriteLine(opilane1.nimi + " " + opilane1.sugu);
            }
            Console.ReadLine();
            Isik.Sugu TextFailistEnumSugu(string andmed)
            {
                switch (andmed)
                {
                    case "naine":
                        return Isik.Sugu.naine;
                    default:
                        return Isik.Sugu.mees;
                }
            }

            Console.ReadKey();
        }
    }
}
