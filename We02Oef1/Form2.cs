using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace We02Oef1
{
    public partial class Form2 : Form
    {

        private readonly Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

            comboBox1.DataSource = form1.klanten;
            comboBox1.DisplayMember = "Mike";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Account newAccount;
                if (radioButton1.Checked)
                {
                    newAccount = new RegularAccount(textBox1.Text, 0d, DateTime.Now, 0.2d, new Klant("Test", "Von Tester"), listBox1.Items.Cast<string>().ToList());
                    form1.accounts.Add(newAccount);
                    form1.account = newAccount;
                }
                else if (radioButton2.Checked)
                {
                    newAccount = new SavingsAccount(textBox1.Text, 0d, DateTime.Now, 0.5d, new Klant("Test", "Von Tester"), 1.5d);
                    form1.accounts.Add(newAccount);
                    form1.account = newAccount;
                }
                form1.makeLabels();
                this.Close();

            }
            catch (Exception ex)
            {
                label2.Text = "Fout";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            textBox2.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }
    }
}
