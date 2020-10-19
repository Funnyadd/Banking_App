using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    class GlobalSavingsAccount : SavingAccount, IExchangeable
    {
        public GlobalSavingsAccount(double a, double i) : base(a, i) {  }

        public override void MakeDeposit(double ammount)
        {
            base.MakeDeposit(ammount);
        }

        public override void MakeWithdrawl(double ammount)
        {
            base.MakeWithdrawl(ammount);
        }

        public override string CloseAndReport()
        {
            return base.CloseAndReport();
        }

        public virtual double USValue(double rate)
        {
            double USBalance = base.CurrentBalance * rate;
            return USBalance;
        }
    }
}
