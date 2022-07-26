using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp;

namespace TestBank
{
    public class Current : Account
    {
        protected double ODA = 5000;
        public override int OpenAcnt(double Amt, string Name)
        {
            if (Amt > 5000)
            {
                ctr++;
                AcNo = ctr;
                Ac_Name = Name;
                Balance = Amt;
                return AcNo;
            }
            else
            {
                Console.WriteLine("Amount below minimum value!");
                return 0;
            }
        }
        public override bool Withdraw(double Amt)
        {
            if (Amt < (Balance + ODA))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
