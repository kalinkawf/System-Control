using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace System_Calculations
{
	public class SysData
	{
		private readonly Dictionary<double, double> y;
		private readonly Dictionary<double, double> e;
		private readonly Dictionary<double, double> u;
		private readonly Dictionary<double, Vector> states;
		private readonly Dictionary<double, Vector> states_d;
		private readonly Matrix state_matrix;
		private readonly Vector input_matrix;
		private readonly Vector output_matrix;
		private readonly Func<double, double> input;


		public Dictionary<double, double> Y { get { return y; } }
		public Dictionary<double, double> E { get { return e; } }
		public Dictionary<double, double> U { get { return u; } } //e.Zip(y, (e, y) => new { e, y }).ToDictionary(x => x.e.Key, x => x.e.Value + x.y.Value)
		public Dictionary<double, double> X1 { get { return states.ToDictionary(x => x.Key, x => x.Value[0]); } }
		public Dictionary<double, double> X2 { get { return states.ToDictionary(x => x.Key, x => x.Value[1]); } }
		public bool IsStable { get; }
		public Dictionary<double, Vector> States { get { return states; } }

		public class SysDataException : Exception
		{
			public SysDataException(string aaaa) : base(aaaa)
			{
			}
		}


		public SysData(double m, double k, double A, double a, double time, double step, string fstr)
		{
			states = new Dictionary<double, Vector>();
			states_d = new Dictionary<double, Vector>();
			y = new Dictionary<double, double>();
			e = new Dictionary<double, double>();
			u = new Dictionary<double, double>();
			IsStable = a > 0 && m * k * A > 0;
			state_matrix = new Matrix { new Vector() { 0, 1 }, new Vector() { (-1.0 * m * k * A), (-1.0 * a) } };
			input_matrix = new Vector { 0.0, 1.0 };
			output_matrix = new Vector { k * A, 0 };
			input = Function.FromStr(fstr);
			try
			{
				Calculate(time, step);
			}
			catch (System.Collections.Generic.KeyNotFoundException)
			{
				throw new SysDataException("Undefined function!");
			}
			catch (ArgumentException e)
			{
				throw new SysDataException(e.Message);
			}
		}


		private void Calculate(double time, double step)
		{
			if (time <= 0)
			{
				throw new ArgumentException("Time must be a non-zero positive number!");
			}
			if (step <= 0)
			{
				throw new ArgumentException("Step must be a non-zero positive number!");
			}
			for (double i = 0; i <= time / step; i++)
			{
				double t = step * i;
				states[t] = t != 0.0 ? states[step * (i - 1)] + step * states_d[step * (i - 1)] : new Vector { 0.0, 0.0 };
				states_d[t] = state_matrix * states[t] + input_matrix * input(t);
				y[t] = output_matrix * states[t];
				e[t] = input(t) - y[t];
				u[t] = input(t);
			}
		}
	}
}
