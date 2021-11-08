using System;
using System_Calculations;

namespace MMM_CLI
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double aa;
            if (!double.TryParse("aaa", out aa)){
                aa = 1;
            }


            var my_func = SimpleFunction.FromStr("-1.5*cos(PIt)");
            Console.WriteLine(my_func(10));

            var my_func2 = Function.FromStr("-1.5*cos(PIt)");
            Console.WriteLine(my_func2(10));

            try
            {
                SysData a = new SysData(1, 1, 1, 2, 5, 0.1, "-1.5*cos(PIt)");
            }
            catch (SysData.SysDataException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
