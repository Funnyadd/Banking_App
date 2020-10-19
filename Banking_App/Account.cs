using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    abstract class Account : IAccount
    {
        public double StartingBalance { get; set; }
        public double CurrentBalance { get; set; }
        private double totalDeposit;
        private int counterDeposit;
        protected double totalWithdrawl;
        protected int counterWithdrawl;
        public double Interest { get; set; }
        protected double serviceCharge;
        protected AccountStatus accountStatus;

        public Account(double balance, double annualInterestRate)
        {
            this.StartingBalance = balance;
            this.Interest = annualInterestRate;
            this.CurrentBalance = this.StartingBalance;
            
        }

        public virtual void MakeDeposit(double ammount)
        {
            CurrentBalance += ammount;
            totalDeposit += ammount;
            counterDeposit++;
            Console.WriteLine("The new balance is: {0}", CurrentBalance.ToNAMoney(true));
        }

        public virtual void MakeWithdrawl(double ammount)
        {
            CurrentBalance -= ammount;
            totalWithdrawl += ammount;
            counterWithdrawl++;
            Console.WriteLine("The new balance is: {0}", CurrentBalance.ToNAMoney(true));
        }

        public void CalculateInterest()
        {
            double montlyInterestRate = Interest / 12;
            double montlyInterest = CurrentBalance * montlyInterestRate;
            CurrentBalance += montlyInterest;
            Console.WriteLine("The new balance is: {0}", CurrentBalance.ToNAMoney(true));
        }

        public virtual string CloseAndReport()
        {
            CurrentBalance -= serviceCharge;
            CalculateInterest();

            StringBuilder str = new StringBuilder();
            str.Append("This month's starting balance: " + string.Format("{0}", StartingBalance.ToNAMoney(true)) + "\n");
            str.Append("this month' final balance: " + string.Format("{0}", CurrentBalance.ToNAMoney(true)) + "\n");
            str.Append("This month's total deposits: " + string.Format("{0}", totalDeposit.ToNAMoney(true)) + "\n");
            str.Append("This month's total withdrawls: " + string.Format("{0}", totalWithdrawl.ToNAMoney(true)) + "\n");
            str.Append("This month's number of deposits: " + string.Format("{0}", counterDeposit) + "\n");
            str.Append("This month's number of withdrawls" + string.Format("{0}", counterWithdrawl) + "\n");
            str.Append("The interest for this month was: " + string.Format("{0}", (CurrentBalance * (Interest / 12)).ToNAMoney(true)) + "\n");

            counterWithdrawl = 0;
            counterDeposit = 0;
            serviceCharge = 0;


            return str.ToString();
        }
    }
}
