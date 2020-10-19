using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    class ChequingAccount : Account
    {
        public ChequingAccount(double a, double i) : base(a, i) { }

        public override void MakeWithdrawl(double ammount)
        {
            if(base.CurrentBalance - ammount < 0)
            {
                Console.WriteLine("Writting a check of {0} will make your balance go below 0$, service charges of 15$ will be applied.", ammount.ToNAMoney(true));
                base.CurrentBalance -= 15;

                if(base.CurrentBalance < 0)
                {
                    Console.WriteLine("This account now owes money to the bank.");
                }
                base.MakeWithdrawl(ammount);
            }
            else
            {
                base.MakeWithdrawl(ammount);
            }
        }

        public override void MakeDeposit(double ammount)
        {
            base.MakeDeposit(ammount);
        }

        public override string CloseAndReport()
        {
            base.serviceCharge += 5;

            for (int i = 0; i <= base.CurrentBalance; i++)
            {
                base.serviceCharge += 0.10;
            }

            return base.CloseAndReport();
        }
    }
}
