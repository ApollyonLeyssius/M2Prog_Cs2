using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_classes
{
    internal class Auto
    {
        internal bool automaat;
        internal string merk;
        internal string kenteken;
        internal int kilometerStand;

        Auto auto1 = new Auto()
        {
            automaat = true,
            kenteken = "AA824H",
            kilometerStand = 20567,
            merk = "Volkswagen"
        };

        Auto auto2 = new Auto()
        {
            automaat = false,
            kenteken = "KU786G",
            kilometerStand = 65739,
            merk = "Volvo",
        };
    }

}
