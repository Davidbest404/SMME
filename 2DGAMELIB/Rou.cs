using System;

namespace _2DGAMELIB
{
	public static class Rou
	{
		public static double RoundUp(this double Value, int Digits)
		{
			double num = Math.Pow(10.0, (double)Digits);
			if (Value <= 0.0)
			{
				return Math.Floor(Value * num) / num;
			}
			return Math.Ceiling(Value * num) / num;
		}

		public static decimal RoundUp(this decimal Value, int Digits)
		{
			decimal d = (decimal)Math.Pow(10.0, (double)Digits);
			if (!(Value > 0m))
			{
				return Math.Floor(Value * d) / d;
			}
			return Math.Ceiling(Value * d) / d;
		}

		public static double RoundDown(this double Value, int Digits)
		{
			double num = Math.Pow(10.0, (double)Digits);
			if (Value <= 0.0)
			{
				return Math.Ceiling(Value * num) / num;
			}
			return Math.Floor(Value * num) / num;
		}

		public static decimal RoundDown(this decimal Value, int Digits)
		{
			decimal d = (decimal)Math.Pow(10.0, (double)Digits);
			if (!(Value > 0m))
			{
				return Math.Ceiling(Value * d) / d;
			}
			return Math.Floor(Value * d) / d;
		}

		public static double Round(this double Value, int Digits)
		{
			return Math.Round(Value, Digits);
		}

		public static decimal Round(this decimal Value, int Digits)
		{
			return Math.Round(Value, Digits);
		}

		public static double Round45(this double Value, int Digits)
		{
			return Math.Round(Value, Digits, MidpointRounding.AwayFromZero);
		}

		public static decimal Round45(this decimal Value, int Digits)
		{
			return Math.Round(Value, Digits, MidpointRounding.AwayFromZero);
		}

		public static double RoundOptional(this double Value, int Digits, int Up)
		{
			double num = 1.0 - (double)Up * 0.1;
			double num2 = Math.Pow(10.0, (double)Digits);
			if (Value <= 0.0)
			{
				return Math.Ceiling(Value * num2 - num) / num2;
			}
			return Math.Floor(Value * num2 + num) / num2;
		}

		public static decimal RoundOptional(this decimal Value, int Digits, int Up)
		{
			decimal d = (decimal)(1.0 - (double)Up * 0.1);
			decimal d2 = (decimal)Math.Pow(10.0, (double)Digits);
			if (!(Value > 0m))
			{
				return Math.Ceiling(Value * d2 - d) / d2;
			}
			return Math.Floor(Value * d2 + d) / d2;
		}
	}
}
