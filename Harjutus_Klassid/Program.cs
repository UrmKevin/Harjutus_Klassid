﻿using System;
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
            Opilane mees = new Opilane("Ashot", 1990, Isik.Sugu.naine,"TLVL", 8, "GG");

            mees.printInfo();

            Console.ReadKey();
        }
    }
}
