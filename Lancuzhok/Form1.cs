using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lancuzhok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BankHandler h1 = null;
        BankHandler h2 = null;
        BankHandler h3 = null;
        BankHandler h4 = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            h1 = new PrivatBankHandler();
            h2 = new SavingBankHandler();
            h3 = new SenseBankHandler();
            h4 = new SenseBankHandler();
            h1.setNext(h2);
            h2.setNext(h3);
            h3.setNext(h4);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            h1.request(new Card(1));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            h1.request(new Card(2));
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            h1.request(new Card(3));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            h1.request(new Card(4));
        }
    }
}
