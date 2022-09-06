using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjutus_Klassid
{
    abstract class Isik
    {
        public string nimi;
        public int synniaasta;
        public enum Sugu { naine, mees };
        public Sugu sugu;
        public string indeks;
        public string konna;
        public double kaal;
        public double pikkus;
        public string bindeks;

        public Isik() { }
        public Isik(string nimi, int synniaasta, Sugu sugu, string indeks, string konna, double kaal, double pikkus)
        {
            this.nimi = nimi;
            this.synniaasta = synniaasta;
            this.sugu = sugu;
            this.indeks = indeks;
            this.konna = konna;
            this.kaal = kaal;
            this.pikkus = pikkus;
        }

        public abstract void printInfo();
        public int arvutaVanus()
        {
            int age = DateTime.Now.Year - synniaasta;
            return age;
        }
        public void muudaNimi(string uusNimi)
        {
            nimi = uusNimi;
        }
        public string arvutaKonna()
        {
            int ad = Int32.Parse(indeks);
            while (ad >= 10)
            {
                ad = ad / 10;
            }
            if (ad == 1)
            {
                konna = "Tallinn";
            }
            else if (ad == 2)
            {
                konna = "Narva, Narva-Jõesuu";
            }
            else if (ad == 3)
            {
                konna = "Kohtla-Järve";
            }
            else if (ad == 4)
            {
                konna = "Ida-Virumaa, Lääne-Virumaa, Jõgevamaa";
            }
            else if (ad == 5)
            {
                konna = "Tartu linn";
            }
            else if (ad == 6)
            {
                konna = "Tartumaa, Põlvamaa, Võrumaa, Valgamaa, Viljandimaa";
            }
            else if (ad == 7)
            {
                konna = "Viljandimaa, Järvamaa, Harjumaa, Raplamaa";
            }
            else if (ad == 8)
            {
                konna = "Pärnumaa";
            }
            else if (ad == 9)
            {
                konna = "Läänemaa, Hiiumaa, Saaremaa";
            }
            return konna;
        }
        public string KMI()
        {
            double kehamassiindeks = kaal / (pikkus * 2);
            if (kehamassiindeks <= 16.5)
            {
                bindeks = $"Äärmuslik kaalupuudus: {kehamassiindeks}";
            }
            else if (kehamassiindeks >= 16.4 && kehamassiindeks <= 18.5)
            {
                bindeks = $"Nalakaaluline: {kehamassiindeks}";
            }
            else if (kehamassiindeks >= 18.5 && kehamassiindeks <= 25)
            {
                bindeks = $"Normalne: {kehamassiindeks}";
            }
            else if (kehamassiindeks >= 25 && kehamassiindeks <= 30.1)
            {
                bindeks = $"Ülekaaluline: {kehamassiindeks}";
            }
            else if (kehamassiindeks >= 30.1 && kehamassiindeks <= 35)
            {
                bindeks = $"Rasvumine (I klass): {kehamassiindeks}";
            }
            else if (kehamassiindeks >= 35 && kehamassiindeks <= 40.1)
            {
                bindeks = $"Rasvumine (II klass): {kehamassiindeks}";
            }
            else if (kehamassiindeks >= 40)
            {
                bindeks = $"Rasvumine (III klass): {kehamassiindeks}";
            }
            return bindeks;
        }
    }
}
