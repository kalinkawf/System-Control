using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Globalization;

namespace System_Calculations
{
    public abstract class SimpleFunction
    {
        private static readonly Dictionary<string, Func<double, double>> str_to_func = new Dictionary<string, Func<double, double>>()
        {
            { "step", Heavyside },
            { "sin", Math.Sin },
            { "cos", Math.Cos },
            { "exp", Math.Exp },
            { "ramp", Ramp },
            { "square", Square },
            { "triangle", Triangle }
        };
        private static readonly CultureInfo enUS = new CultureInfo("en-US");
        private static readonly Regex pattern = new Regex(@"(\S?\d+[.,]?\d*)?(?:\*?(PI))?\*?([a-zA-Z]+)\((\S?\d+[.,]?\d*)?(?:\*?(PI))?\*?t\+?(\S?\d+[.,]?\d*)?(?:\*?(PI))?\)");

        public static Func<double, double> FromStr(string fstr)
        {
            Func<double, double> f;
            double A;
            double w;
            double t0;
            Match m = pattern.Match(fstr);
            A = (double.TryParse(m.Groups[1].Value, NumberStyles.Float, enUS, out A) ? A : 1) * (m.Groups[2].Success ? Math.PI : 1);
            w = (double.TryParse(m.Groups[4].Value, NumberStyles.Float, enUS, out w) ? w : 1) * (m.Groups[5].Success ? Math.PI : 1);
            t0 = (double.TryParse(m.Groups[6].Value, NumberStyles.Float, enUS, out t0) ? t0 : 0) * (m.Groups[7].Success ? Math.PI : 1); ;
            f = str_to_func[m.Groups[3].Value];
            return arg => A * f(w * arg + t0);
        }

        public static Func<double, double> FromStr2(string fstr)
        {
            Func<double, double> f;
            double A;
            double w;
            double t0;
            CultureInfo enUS = new CultureInfo("en-US");
            string pattern = @"(.?\d+[.,]?\d*)?(?:\*?(PI))?\*?([a-zA-Z]+)\((.?\d+[.,]?\d*)?(?:\*?(PI))?\*?t\+?(.?\d+[.,]?\d*)?(?:\*?(PI))?\)";
            Match m = Regex.Match(fstr, pattern);
            A = (double.TryParse(m.Groups[1].Value, NumberStyles.Float, enUS, out A) ? A : 1) * (m.Groups[2].Success ? Math.PI : 1);
            w = (double.TryParse(m.Groups[4].Value, NumberStyles.Float, enUS, out w) ? w : 1) * (m.Groups[5].Success ? Math.PI : 1);
            t0 = (double.TryParse(m.Groups[6].Value, NumberStyles.Float, enUS, out t0) ? t0 : 0) * (m.Groups[7].Success ? Math.PI : 1);
            switch (m.Groups[3].Value)
            {
                case "step":
                    f = Heavyside;
                    break;
                case "sin":
                    f = Math.Sin;
                    break;
                case "cos":
                    f = Math.Cos;
                    break;
                case "exp":
                    f = Math.Exp;
                    break;
                case "ramp":
                    f = Ramp;
                    break;
                case "square":
                    f = Square;
                    break;
                case "triangle":
                    f = Triangle;
                    break;
                default:
                    f = Heavyside;
                    break;
            }
            return arg => A * f(w * arg + t0);
        }

        private static double Heavyside(double t)
        {
            return t < 0 ? 0.0 : 1.0;
        }

        private static double Ramp(double t)
        {
            return Heavyside(t) * t;
        }

        private static double Square(double t)
        {
            return Math.Sign(Math.Sin(t));
        }

        private static double Triangle(double t)
        {
            return 2.0 / Math.PI * Math.Asin(Math.Sin(t));
        }

    }
}
