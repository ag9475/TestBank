using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp;

namespace TestBank
{
    public class Fixed : Account
    {
        DateTime OpenDate;
        DateTime MatDate;
        public override int OpenAcnt(double Amt, string Name)
        {
            if(Amt > 1000)
            {
                ctr++;
                AcNo = ctr;
                Ac_Name = Name;
                Balance = Amt;
                OpenDate = DateTime.Now;               
                MatDate = OpenDate.AddYears(3);
                return AcNo;
            }
            else
            {
                return 0;
        }
        }
        public override bool Withdraw (double Amt)
        {
            if (DateTime.Compare(DateTime.Now , MatDate) > 0 & Amt < Balance)
            {
                Balance -= Amt;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
