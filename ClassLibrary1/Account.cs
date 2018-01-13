using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Account
    {
        public string IBAN { get; protected set; }
        public double Balance { get; protected set; }
        public DateTime Creationdate { get; protected set; }
        public double Intrest { get; protected set; }
        public abstract string AccountType { get; }
        public Klant Klant { get; protected set; }

        public Account(string IBAN, double Balance, DateTime Creationdate, double Intrest, Klant Klant )
        {
            this.IBAN = IBAN;
            this.Balance = Balance;
            this.Creationdate = Creationdate;
            this.Intrest = Intrest;
            this.Klant = Klant;
        }

        public void deposit(double amount)
        {
            this.Balance += amount;
        }

        public void withdraw(double amount)
        {
            if (this.Balance+1000 >= amount)
            {
                this.Balance -= amount;
            } else
            {
                throw new Exception();
            }
        }

        public override string ToString()
        {
            return IBAN + " " + Balance + " " + Creationdate + " " + Intrest + " " + Klant + " ";
        }
    }
}
