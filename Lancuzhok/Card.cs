using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lancuzhok
{

    public class Card
    {
        public int type;
        public Card(int t)
        {
            type = t;
        }
    }
    public interface Bank
    {
        void setNext(Bank b);
        void request(Card c);
    }
    class BankHanler : Bank
    {
        protected Bank next;
        public List<Card> cards = new List<Card>();
        public void setNext(Bank b)
        {
            next = b;
        }
        public virtual void request(Card c)
        {
            if (next != null)
            {
                next.request(c);
            }
        }
    }
    class PrivatBankHandler : BankHanler
    {
        public override void request(Card c)
        {
            if (c.type == 1)
            {
                cards.Add(c);
                MessageBox.Show("Your request was successful. Your commission is equal to 2%");
            }
            else
            {
                base.request(c);
            }
        }
    }
    class SavingBankHandler : BankHanler
    {
        public override void request(Card c)
        {
            if (c.type == 2)
            {
                cards.Add(c);
                MessageBox.Show("Your request was successful. Your commission is equal to 5%");
            }
            else
            {
                base.request(c);
            }
        }
    }
    class SenseBankHandler : BankHanler
    {
        public override void request(Card c)
        {
            if (c.type == 3)
            {
                cards.Add(c);
                MessageBox.Show("Your request was successful. Your commission is equal to 20%");
            }
            else
            {
                base.request(c);
                MessageBox.Show("Your request was unsuccessful. Please, take your card again");
            }
        }
    }
    class MonoBankHandler : BankHanler
    {
        public override void request(Card c)
        {
            if (c.type == 3)
            {
                cards.Add(c);
                MessageBox.Show("Your request was successful. Have your salo and borsh, kozache");
            }
            else
            {
                base.request(c);
                MessageBox.Show("Your request was unsuccessful. Sprobyite todi, koly u vas zyiavliatsia mizku");
            }
        }
    }
}
