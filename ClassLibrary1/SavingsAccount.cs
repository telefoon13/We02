using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SavingsAccount : Account
    {
        public double LoyaltyBonus { get; protected set; }
        public override string AccountType { get; }
        public SavingsAccount(string IBAN, double Balance, DateTime Creationdate, double Intrest, Klant Klant, double LoyaltyBonus) : base( IBAN,  Balance,  Creationdate,  Intrest, Klant)
        {
            this.LoyaltyBonus = LoyaltyBonus;
            this.AccountType = "Savings Account";
        }

        public override string ToString()
        {
            return base.ToString() + LoyaltyBonus;
        }
    }
}
