using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Banking_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Account As = new SavingAccount(10, .05);
            Account Ac = new ChequingAccount(10, .05);
            GlobalSavingsAccount Ag = new GlobalSavingsAccount(10, .05);

            string opt;

            Console.WriteLine("-- Welcome to Arnold's Bank of trust --");
            do
            {
                Console.WriteLine("-- General Page -- \nA. Savings \nB. Checking \nC. Global Savings \nQ. Exit");

                opt = Console.ReadLine().ToUpper();

                switch (opt)
                {
                    case "A":
                        MenuSaving(As);
                        break;

                    case "B":
                        MenuChequing(Ac);
                        break;

                    case "C":
                        MenuGlobalSavings(Ag);
                        break;

                    case "Q":
                        Console.WriteLine("Thank your for using Arnold's Bank! See ya! ;)");
                        Environment.Exit(0);
                        break;

                    default:
                        throw new InvalidOperationException("Please enter a valid character...");
                }
            } while (opt != "Q");
        }
        public static void MenuSaving(Account savingAccount)
        {
            string optSaving;
            Regex checkInput = new Regex(@"\d\.\d+");

            do
            {
                Console.WriteLine("-- Savings Menu -- \nA. Deposit \nB. Withdraw \nC. Close + Report \nR. Go Back");
                optSaving = Console.ReadLine().ToUpper();

                switch (optSaving)
                {
                    case "A":
                        Console.WriteLine("Enter the amount of the deposit:");
                        string ammountDeposit = Console.ReadLine();

                        if (!(checkInput.IsMatch(ammountDeposit)))
                        {
                            throw new FormatException("The number you entered is not valid");
                        }

                        double.TryParse(ammountDeposit, out double userAmountDeposit);
                        savingAccount.MakeDeposit(userAmountDeposit);
                        break;

                    case "B":
                        Console.WriteLine("Enter the amount of the withdrawl:");
                        string ammountWitdraw = Console.ReadLine();

                        if (!(checkInput.IsMatch(ammountWitdraw)))
                        {
                            throw new FormatException("The number you entered is not valid");
                        }

                        double.TryParse(ammountWitdraw, out double userAmountWithdraw);
                        savingAccount.MakeWithdrawl(userAmountWithdraw);
                        break;

                    case "C":
                        Console.WriteLine(savingAccount.CloseAndReport());
                        Console.WriteLine("Your account has {0:F2}% than at the beginning of the month!", savingAccount.GetPercentageChange());
                        break;

                    case "R":
                        break;

                    default:
                        throw new InvalidOperationException("Please enter a valid character...");
                }

            } while (optSaving != "R");
        }

        public static void MenuChequing(Account chequingAccount)
        {
            string optChequing;
            Regex checkInput = new Regex(@"\d\.\d+");

            do
            {
                Console.WriteLine("-- Savings Menu -- \nA. Deposit \nB. Withdraw \nC. Close + Report \nR. Go Back");
                optChequing = Console.ReadLine().ToUpper();

                switch (optChequing)
                {
                    case "A":
                        Console.WriteLine("Enter the amount of the deposit:");
                        string ammountDeposit = Console.ReadLine();

                        if (!(checkInput.IsMatch(ammountDeposit)))
                        {
                            throw new FormatException("The number you entered is not valid");
                        }

                        double.TryParse(ammountDeposit, out double userAmountDeposit);
                        chequingAccount.MakeDeposit(userAmountDeposit);
                        break;

                    case "B":
                        Console.WriteLine("Enter the amount of the withdrawl:");
                        string ammountWitdraw = Console.ReadLine();

                        if (!(checkInput.IsMatch(ammountWitdraw)))
                        {
                            throw new FormatException("The number you entered is not valid");
                        }

                        double.TryParse(ammountWitdraw, out double userAmountWithdraw);
                        chequingAccount.MakeWithdrawl(userAmountWithdraw);
                        break;

                    case "C":
                        Console.WriteLine(chequingAccount.CloseAndReport());
                        Console.WriteLine("Your account has {0:F2}% than at the beginning of the month!", chequingAccount.GetPercentageChange());
                        break;

                    case "R":
                        break;

                    default:
                        throw new InvalidOperationException("Please enter a valid character...");
                }

            } while (optChequing != "R");
        }

        public static void MenuGlobalSavings(Account globalSavingsAccount)
        {
            string optChequing;
            Regex checkInput = new Regex(@"\d\.\d+");
            
            do
            {
                Console.WriteLine("-- Savings Menu -- \nA. Deposit \nB. Withdraw \nC. Close + Report \nR. Go Back");
                optChequing = Console.ReadLine().ToUpper();

                switch (optChequing)
                {
                    case "A":
                        Console.WriteLine("Enter the amount of the deposit:");
                        string ammountDeposit = Console.ReadLine();

                        if (!(checkInput.IsMatch(ammountDeposit)))
                        {
                            throw new FormatException("The number you entered is not valid");
                        }

                        double.TryParse(ammountDeposit, out double userAmountDeposit);
                        globalSavingsAccount.MakeDeposit(userAmountDeposit);
                        break;

                    case "B":
                        Console.WriteLine("Enter the amount of the withdrawl:");
                        string ammountWitdraw = Console.ReadLine();

                        if (!(checkInput.IsMatch(ammountWitdraw)))
                        {
                            throw new FormatException("The number you entered is not valid");
                        }

                        double.TryParse(ammountWitdraw, out double userAmountWithdraw);
                        globalSavingsAccount.MakeWithdrawl(userAmountWithdraw);
                        break;

                    case "C":
                        Console.WriteLine(globalSavingsAccount.CloseAndReport());
                        Console.WriteLine("Your account has {0:F2}% than at the beginning of the month!", globalSavingsAccount.GetPercentageChange());
                        break;

                    case "R":
                        break;

                    default:
                        throw new InvalidOperationException("Please enter a valid character...");
                }

            } while (optChequing != "R");
        }
    }
}