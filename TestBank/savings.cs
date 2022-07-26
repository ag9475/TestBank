using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp;

namespace TestBank
{
    public class savings : Account
    {
        public override int OpenAcnt(double Amt, string Name)
        {
            if (Amt > 1000)
            {
                ctr ++ ;
                AcNo = ctr;
                Ac_Name = Name;
                Balance = Amt;
                return AcNo;
            }
            else
            {
                return 0;
            }
        }
        public override bool Withdraw(double Amt)
        {
            if ((Balance - Amt) < 1000)
            {
                return false;
            }
            else
            {
                Balance -= Amt;
                return true;
            }
        }
    }
}
