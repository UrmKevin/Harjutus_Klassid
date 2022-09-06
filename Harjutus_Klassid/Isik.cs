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
        public enum Sugu { naine, mees};
        public Sugu sugu;
        public string indeks;
        public string konna;

        public Isik() { }
        public Isik(string nimi, int synniaasta, Sugu sugu, string indeks, string konna="")
        {
            this.nimi = nimi;
            this.synniaasta = synniaasta;
            this.sugu = sugu;
            this.indeks = indeks;
            this.konna = konna;
        }

        public abstract void printInfo();
        public int arvutaVanus()
        {
            int  age = DateTime.Now.Year - synniaasta;
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
                konna="Tallinn";
            }
            else if (ad == 2)
            {
                konna="Narva, Narva-Jõesuu";
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
    }
}
