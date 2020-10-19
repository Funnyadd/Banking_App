using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    static class PercentageExtension
    {
        public static double GetPercentageChange(this Account a)
        {
            double percentage = (a.StartingBalance / a.CurrentBalance) * 100;

            return percentage;
        }
    }
}
