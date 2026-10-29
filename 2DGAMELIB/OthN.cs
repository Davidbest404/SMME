using System;
using System.Globalization;

namespace _2DGAMELIB
{
	public static class OthN
	{
		public static bool IsNumeric(this string str)
		{
			double num;
			return double.TryParse(str, NumberStyles.Any, null, out num);
		}

		public static bool IsNumeric(this object obj)
		{
			return obj.ToString().IsNumeric();
		}

		public static int NumberOfDigits(this float Value)
		{
			string text = Value.ToString("f99").Replace("-", "");
			int num = text.Length - 1;
			while (text[num] == '0')
			{
				num--;
			}
			return num - 1;
		}

		public static int NumberOfDigits(this double Value)
		{
			string text = Value.ToString("f99").Replace("-", "");
			int num = text.Length - 1;
			while (text[num] == '0')
			{
				num--;
			}
			return num - 1;
		}

		public static int NumberOfDigits(this decimal Value)
		{
			string text = Value.ToString("f99").Replace("-", "");
			int num = text.Length - 1;
			while (text[num] == '0')
			{
				num--;
			}
			return num - 1;
		}

		public static int NumberOfDigits(this sbyte Value)
		{
			return Value.ToString().Replace("-", "").Length - 1;
		}

		public static int NumberOfDigits(this byte Value)
		{
			return Value.ToString().Replace("-", "").Length - 1;
		}

		public static int NumberOfDigits(this short Value)
		{
			return Value.ToString().Replace("-", "").Length - 1;
		}

		public static int NumberOfDigits(this ushort Value)
		{
			return Value.ToString().Replace("-", "").Length - 1;
		}

		public static int NumberOfDigits(this int Value)
		{
			return Value.ToString().Replace("-", "").Length - 1;
		}

		public static int NumberOfDigits(this uint Value)
		{
			return Value.ToString().Replace("-", "").Length - 1;
		}

		public static int NumberOfDigits(this long Value)
		{
			return Value.ToString().Replace("-", "").Length - 1;
		}

		public static int NumberOfDigits(this ulong Value)
		{
			return Value.ToString().Replace("-", "").Length - 1;
		}

		public static bool IsErrorIdentity(double Value1, double Value2, double Error)
		{
			return Math.Abs(Value1 - Value2) <= Error;
		}

		public static int Cycle(this int Value, int Range)
		{
			return Value % Range;
		}

		public static bool IsPositive(this double n)
		{
			return n > 0.0;
		}

		public static bool IsNegative(this double n)
		{
			return n < 0.0;
		}

		public static bool IsOdd(this int n)
		{
			return n % 2 == 1;
		}

		public static bool IsEven(this int n)
		{
			return n % 2 == 0;
		}

		public static bool IsPrime(this int n)
		{
			if (n < 2)
			{
				return false;
			}
			if (n == 2)
			{
				return true;
			}
			if (n % 2 == 0)
			{
				return false;
			}
			for (int i = 3; i < n; i += 2)
			{
				if (n % i == 0)
				{
					return false;
				}
			}
			return true;
		}

		public static int LimitM(this int Value, int Min, int Max)
		{
			if (Value < Min)
			{
				return Min;
			}
			if (Value <= Max)
			{
				return Value;
			}
			return Max;
		}

		public static double LimitM(this double Value, double Min, double Max)
		{
			if (Value < Min)
			{
				return Min;
			}
			if (Value <= Max)
			{
				return Value;
			}
			return Max;
		}

		public static int Limit(this int Value, int Sta, int Les)
		{
			if (Value < Sta)
			{
				return Sta;
			}
			if (Value < Les)
			{
				return Value;
			}
			return Les - 1;
		}

		public static XS XS = new XS((uint)((long)Environment.TickCount + DateTime.Now.ToBinary()));
	}
}
