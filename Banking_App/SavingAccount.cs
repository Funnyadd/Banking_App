using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    class SavingAccount : Account
    {
        public SavingAccount(double a, double i) : base(a, i) { }

        public override void MakeWithdrawl(double ammount)
        {
            base.accountStatus = AccountStatus.Inactive;

            if (base.CurrentBalance >= 25)
            {
                base.accountStatus = AccountStatus.Active;
            }

            if (base.accountStatus == AccountStatus.Inactive)
            {
                Console.WriteLine("Your account balance is below 25$, therefore the withdrawl cannot be done. \nCurrent balance is :" + CurrentBalance.ToNAMoney(true));
            } 
            else
            {
                base.MakeWithdrawl(ammount);
                if (base.CurrentBalance < 25)
                {
                    Console.WriteLine("The current balance is {0}$ and is now inactive. \nTo make any other withdrawls, your account balance needs to be higher than 25$", CurrentBalance.ToNAMoney(true));
                }
            }
        }

        public override void MakeDeposit(double ammount)
        {
            base.accountStatus = AccountStatus.Inactive;

            if(base.CurrentBalance >= 25)
            {
                base.accountStatus = AccountStatus.Active;
            }

            if(base.accountStatus == AccountStatus.Inactive)
            {
                Console.WriteLine("Your account balance is below 25$, therefore you must make a big enough deposit to make it active again. \nCurrent balance is: " + CurrentBalance.ToNAMoney(true));
                base.MakeDeposit(ammount);
                if(base.CurrentBalance >= 25)
                {
                    Console.WriteLine("With the new deposit you made, your account is now active with a balance of: " + CurrentBalance.ToNAMoney(true));
                } else
                {
                    Console.WriteLine("Even with the new deposit, your account is still below 25$ and this results in your account still being inactive \nCurrent balance: " + CurrentBalance.ToNAMoney(true));
                }
            } 
            else
            {
                base.MakeDeposit(ammount);
            }
        }

        public override string CloseAndReport()
        {
            int sc = counterWithdrawl - 4;

            if(base.counterWithdrawl >= 4)
            {

                Console.WriteLine("This account has withdrawn money {0} times and this will result in a service charge of {1}$", counterWithdrawl, string.Format("{0}", sc));
            }
            return base.CloseAndReport();
        }
    }
}
