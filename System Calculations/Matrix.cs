using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace System_Calculations
{
    public class Matrix : List<Vector>
    {
        public Matrix(IEnumerable<Vector> a) : base(a) { }
        public Matrix() : base() { }

        public static Matrix operator +(Matrix a, Matrix b)
        {
     
            return new Matrix(a.Zip(b, (val1, val2) => val1 + val2));
        }

        public static Matrix operator *(Matrix a, double b)
        {
            return new Matrix(a.Select(val1 => val1 * b));
        }

        public static Matrix operator *(double b, Matrix a)
        {
            return a * b;
        }

        public static Vector operator *(Matrix a, Vector b)
        {
            return new Vector(a.Select(val1 => val1 * b));
        }
    }
}
