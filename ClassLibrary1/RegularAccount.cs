using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class RegularAccount : Account
    {
        public List<string> Cards { get; protected set; }
        public override string AccountType { get; }

        public RegularAccount(string IBAN, double Balance, DateTime Creationdate, double Intrest, Klant Klant, List<string> Cards) : base(IBAN, Balance, Creationdate, Intrest, Klant)
        {
            this.Cards = Cards;
            this.AccountType = "Regular Account";
        }

        public override string ToString()
        {
            return base.ToString() + Cards.ToString(); ;
        }
    }
}
