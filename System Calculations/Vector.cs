using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace System_Calculations
{

    public class Vector: List<double>
    {
        public Vector(IEnumerable<double> a) : base(a) { }
        public Vector() : base() { }

        public static Vector operator+(Vector a, Vector b)
        {
            return new Vector(a.Zip(b, (val1, val2) => val1 + val2));
        }

        public static Vector operator*(Vector a, double b)
        {
            return new Vector(a.Select(val1 => val1 * b));
        }

        public static Vector operator *(double b, Vector a)
        {
            return a * b;
        }

        public static double operator *(Vector a, Vector b)
        {
            return a.Zip(b, (val1, val2) => val1 * val2).Aggregate(0.0, (val1, val2) => val1 + val2);
        }
    }

}
