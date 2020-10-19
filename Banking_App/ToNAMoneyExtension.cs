using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    static class ToNAMoneyExtension
    {
        public static string ToNAMoney(this double value, bool round)
        {

            string newValue;

            if (round == true)
            {
                Math.Round(value, MidpointRounding.ToEven);
            }
            else
            {
                Math.Floor(value);
            }

            if (value > 0)
            {
                newValue = String.Format("${0:F2}", value);
            }
            else
            {
                newValue = String.Format("(${0:F2})", value);
            }
          
            return newValue;
        }
    }
}
