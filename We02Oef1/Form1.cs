using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace We02Oef1
{
    public partial class Form1 : Form
    {
        public Account account { get; set; }
        public List<Account> accounts { get; set; }
        public List<Klant> klanten { get; set; }
        public Form1()
        {
            accounts = new List<Account>();
            klanten = new List<Klant>();
            if (account == null)
            {
                Account acdcount = new RegularAccount("TEST-ACCOUNT", 1000.50d, DateTime.Now, 0.2d, new Klant("Test", "Von Tester"), new List<string> { "TEST-CARD-0", "TEST-CARD-1" });
                this.account = acdcount;
            }

            
            Klant klant1 = new Klant("Mike", "Dhoore");
            klanten.Add(klant1);
            Klant klant2 = new Klant("Mikea", "Dhoore");
            klanten.Add(klant2);
            Klant klant3 = new Klant("Mikeb", "Dhoore");
            klanten.Add(klant3);
            Klant klant4 = new Klant("Mikec", "Dhoore");
            klanten.Add(klant4);

            InitializeComponent();
            makeLabels();
        }

        public void makeLabels()
        {
            label2.Text = String.Format("€ {0:N2}", account.Balance);
            label4.Text = account.AccountType;
            label6.Text = account.Creationdate.ToShortDateString();
            label8.Text = account.Intrest.ToString() + " %";
            label10.Text = account.IBAN;
            label14.Text = account.Klant.ToString();

            accountsToolStripMenuItem.DropDownItems.Clear();
            foreach (Account a in accounts)
            {
                ToolStripItem toolStripItem = new ToolStripMenuItem();
                toolStripItem.Text = a.IBAN;
                toolStripItem.Click += ToolStripItem_Click;
                accountsToolStripMenuItem.DropDownItems.Add(toolStripItem);
            }

            customersToolStripMenuItem.DropDownItems.Clear();
            foreach (Klant k in klanten)
            {
                ToolStripItem toolStripItem = new ToolStripMenuItem();
                toolStripItem.Text = k.ToString();
                toolStripItem.Click += ToolStripItem_Click;
                customersToolStripMenuItem.DropDownItems.Add(toolStripItem);
            }

        }

        private void ToolStripItem_Click(object sender, EventArgs e)
        {
            foreach (Account a in accounts)
            {
                ToolStripMenuItem toolStripItema = (ToolStripMenuItem)sender;
                if (a.IBAN == toolStripItema.Text)
                {
                    account = a;
                }

            }

            makeLabels();
        }

        public void AddAccountToAccounts(Account accountA)
        {
            accounts.Add(accountA);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                account.deposit((double)numericUpDown1.Value);
                label2.Text = "€ " + account.Balance;
                label12.Text = "";
            }
            else
            {
                label12.Text = "Gelieven meer dan 0 in te geven";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                try
                {
                    account.withdraw((double)numericUpDown1.Value);
                    label2.Text = "€ " + account.Balance;
                    label12.Text = "";
                }
                catch (Exception ex)
                {
                    label12.Text = "Onvoldoende krediet om deze bewerking uit te voeren";
                }
            }
            else
            {
                label12.Text = "Gelieven meer dan 0 in te geven";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newAccount = new Form2(this);
            newAccount.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            label2.Refresh();
            label4.Refresh();
            label6.Refresh();
            label8.Refresh();
            label10.Refresh();
        }
    }
}
