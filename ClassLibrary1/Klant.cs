using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Klant
    {
        public string VoorNaam { get; protected set; }
        public string AchterNaam { get; protected set; }

        public Klant(string voorNaam, string achterNaam)
        {
            VoorNaam = voorNaam;
            AchterNaam = achterNaam;
        }

        public override string ToString()
        {
            return VoorNaam + " " + AchterNaam;
        }

    }
}
