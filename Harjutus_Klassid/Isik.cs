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

        public Isik() { }
        public Isik(string nimi, int synniaasta, Sugu sugu)
        {
            this.nimi = nimi;
            this.synniaasta = synniaasta;
            this.sugu = sugu;
        }

        public abstract void printInfo();
        public int arvutaVanus()
        {
            int  age = DateTime.Now.Year - synniaasta;
            return age;
        }
        //public abstract void muudaNimi();
    }
}
