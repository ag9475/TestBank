using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public abstract class Account
    {
        public static int ctr = 0;
        protected int AcNo;
        protected string Ac_Name;
        protected double Balance;
        public abstract int OpenAcnt(double Amt , string Name);
        public abstract bool Withdraw(double Amt);
        public virtual double Deposit(double Amt)
        {
            if (Amt > 0)
            {
                this.Balance += Amt;
                return Balance;
            }
            else
            {
                return 0;
            }
        }
        public double CheckBalance
        {
            get {
                return Balance;
            }
        }
        public string CloseAcnt()
        {
            return "Account Closed!";
        }
        public int Number
        {
            get{
                return AcNo;
            }
        }
    }
}
