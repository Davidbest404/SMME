using System;

namespace _2DGAMELIB
{
	public static class Ma
	{
		public static double E
		{
			get
			{
				return 2.718281828459045;
			}
		}

		public static double PI
		{
			get
			{
				return 3.141592653589793;
			}
		}

		public static double Exp(this double n)
		{
			return Math.Exp(n);
		}

		public static double Pow(this double x, double n)
		{
			return Math.Pow(x, n);
		}

		public static double Log(this double x)
		{
			return Math.Log(x);
		}

		public static double Log(this double x, double a)
		{
			return Math.Log(x, a);
		}

		public static double Log10(this double x)
		{
			return Math.Log10(x);
		}

		public static double Sin(this double θ)
		{
			return Math.Sin(θ);
		}

		public static double Cos(this double θ)
		{
			return Math.Cos(θ);
		}

		public static double Tan(this double θ)
		{
			return Math.Tan(θ);
		}

		public static double Sec(this double θ)
		{
			return 1.0 / Math.Cos(θ);
		}

		public static double Csc(this double θ)
		{
			return 1.0 / Math.Sin(θ);
		}

		public static double Ctan(this double θ)
		{
			return 1.0 / Math.Tan(θ);
		}

		public static double Asin(this double x)
		{
			return Math.Asin(x);
		}

		public static double Acos(this double x)
		{
			return Math.Acos(x);
		}

		public static double Atan(this double x)
		{
			return Math.Atan(x);
		}

		public static double Atan2(double x, double y)
		{
			return Math.Atan2(x, y);
		}

		public static double Asec(this double x)
		{
			return 2.0 * Math.Atan(1.0) - Math.Atan((double)Math.Sign(x) / Math.Sqrt(x * x - 1.0));
		}

		public static double Acsc(this double x)
		{
			return Math.Atan((double)Math.Sign(x) / Math.Sqrt(x * x - 1.0));
		}

		public static double Acot(this double x)
		{
			return 2.0 * Math.Atan(1.0) - Math.Atan(x);
		}

		public static double Sinh(this double x)
		{
			return Math.Sinh(x);
		}

		public static double Cosh(this double x)
		{
			return Math.Cosh(x);
		}

		public static double Tanh(this double x)
		{
			return Math.Tanh(x);
		}

		public static double Sech(this double x)
		{
			return 2.0 / (Math.Exp(x) + Math.Exp(-x));
		}

		public static double Csch(this double x)
		{
			return 2.0 / (Math.Exp(x) - Math.Exp(-x));
		}

		public static double Coth(this double x)
		{
			return (Math.Exp(x) + Math.Exp(-x)) / (Math.Exp(x) - Math.Exp(-x));
		}

		public static double Asinh(this double x)
		{
			return Math.Log(x + Math.Sqrt(x * x + 1.0));
		}

		public static double Acosh(this double x)
		{
			return Math.Log(x + Math.Sqrt(x * x - 1.0));
		}

		public static double Atanh(this double x)
		{
			return Math.Log((1.0 + x) / (1.0 - x)) / 2.0;
		}

		public static double Asech(this double x)
		{
			return Math.Log((Math.Sqrt(-x * x + 1.0) + 1.0) / x);
		}

		public static double Acsch(this double x)
		{
			return Math.Log(((double)Math.Sign(x) * Math.Sqrt(x * x + 1.0) + 1.0) / x);
		}

		public static double Acoth(this double x)
		{
			return Math.Log((x + 1.0) / (x - 1.0)) / 2.0;
		}

		public static decimal Truncate(this decimal x)
		{
			return Math.Truncate(x);
		}

		public static double Truncate(this double x)
		{
			return Math.Truncate(x);
		}

		public static decimal Floor(this decimal x)
		{
			return Math.Floor(x);
		}

		public static double Floor(this double x)
		{
			return Math.Floor(x);
		}

		public static decimal Ceiling(this decimal x)
		{
			return Math.Ceiling(x);
		}

		public static double Ceiling(this double x)
		{
			return Math.Ceiling(x);
		}

		public static decimal Round(this decimal x)
		{
			return Math.Round(x);
		}

		public static double Round(this double x)
		{
			return Math.Round(x);
		}

		public static decimal Round(this decimal x, MidpointRounding Mode)
		{
			return Math.Round(x, Mode);
		}

		public static double Round(this double x, MidpointRounding Mode)
		{
			return Math.Round(x, Mode);
		}

		public static decimal Round(this decimal x, int Digits, MidpointRounding Mode)
		{
			return Math.Round(x, Digits, Mode);
		}

		public static double Round(this double x, int Digits, MidpointRounding Mode)
		{
			return Math.Round(x, Digits, Mode);
		}

		public static decimal Abs(this decimal x)
		{
			return Math.Abs(x);
		}

		public static double Abs(this double x)
		{
			return Math.Abs(x);
		}

		public static short Abs(this short x)
		{
			return Math.Abs(x);
		}

		public static int Abs(this int x)
		{
			return Math.Abs(x);
		}

		public static long Abs(this long x)
		{
			return Math.Abs(x);
		}

		public static sbyte Abs(this sbyte x)
		{
			return Math.Abs(x);
		}

		public static float Abs(this float x)
		{
			return Math.Abs(x);
		}

		public static int Sign(this decimal x)
		{
			return Math.Sign(x);
		}

		public static int Sign(this double x)
		{
			return Math.Sign(x);
		}

		public static int Sign(this short x)
		{
			return Math.Sign(x);
		}

		public static int Sign(this int x)
		{
			return Math.Sign(x);
		}

		public static int Sign(this long x)
		{
			return Math.Sign(x);
		}

		public static int Sign(this sbyte x)
		{
			return Math.Sign(x);
		}

		public static int Sign(this float x)
		{
			return Math.Sign(x);
		}

		public static double Sqrt(this double x)
		{
			return Math.Sqrt(x);
		}

		public static double Root(this double x, double n)
		{
			return Math.Pow(x, 1.0 / n);
		}

		public static byte Max(this byte a, byte b)
		{
			return Math.Max(a, b);
		}

		public static decimal Max(this decimal a, decimal b)
		{
			return Math.Max(a, b);
		}

		public static double Max(this double a, double b)
		{
			return Math.Max(a, b);
		}

		public static short Max(this short a, short b)
		{
			return Math.Max(a, b);
		}

		public static int Max(this int a, int b)
		{
			return Math.Max(a, b);
		}

		public static long Max(this long a, long b)
		{
			return Math.Max(a, b);
		}

		public static sbyte Max(this sbyte a, sbyte b)
		{
			return Math.Max(a, b);
		}

		public static float Max(this float a, float b)
		{
			return Math.Max(a, b);
		}

		public static ushort Max(this ushort a, ushort b)
		{
			return Math.Max(a, b);
		}

		public static uint Max(this uint a, uint b)
		{
			return Math.Max(a, b);
		}

		public static ulong Max(this ulong a, ulong b)
		{
			return Math.Max(a, b);
		}

		public static byte Min(this byte a, byte b)
		{
			return Math.Min(a, b);
		}

		public static decimal Min(this decimal a, decimal b)
		{
			return Math.Min(a, b);
		}

		public static double Min(this double a, double b)
		{
			return Math.Min(a, b);
		}

		public static short Min(this short a, short b)
		{
			return Math.Min(a, b);
		}

		public static int Min(this int a, int b)
		{
			return Math.Min(a, b);
		}

		public static long Min(this long a, long b)
		{
			return Math.Min(a, b);
		}

		public static sbyte Min(this sbyte a, sbyte b)
		{
			return Math.Min(a, b);
		}

		public static float Min(this float a, float b)
		{
			return Math.Min(a, b);
		}

		public static ushort Min(this ushort a, ushort b)
		{
			return Math.Min(a, b);
		}

		public static uint Min(this uint a, uint b)
		{
			return Math.Min(a, b);
		}

		public static ulong Min(this ulong a, ulong b)
		{
			return Math.Min(a, b);
		}

		public static long BigMul(this int a, int b)
		{
			return Math.BigMul(a, b);
		}

		public static int DivRem(this int a, int b, out int r)
		{
			return Math.DivRem(a, b, out r);
		}

		public static long DivRem(this long a, long b, out long r)
		{
			return Math.DivRem(a, b, out r);
		}

		public static double IEEERemainder(this double a, double b)
		{
			return Math.IEEERemainder(a, b);
		}
	}
}
