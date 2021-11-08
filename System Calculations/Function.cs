using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace System_Calculations
{
    abstract public class Function
    {
        private static readonly string[] stringSeparators = new string[] { " + " };
        public static Func<double, double> FromStr(string fstr)
        {
            string[] strings = fstr.Split(stringSeparators, StringSplitOptions.None);
            return arg =>
            {
                double res = 0;
                foreach(string str in strings)
                {
                    res += SimpleFunction.FromStr(str)(arg);
                }
                return res;
            };
        }

    }
}
