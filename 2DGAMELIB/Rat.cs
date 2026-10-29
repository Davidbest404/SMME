using System;

namespace _2DGAMELIB
{
	public static class Rat
	{
		public static double Inverse(this double Rate)
		{
			if (Rate == 0.0)
			{
				return 1.0;
			}
			return (double)Math.Sign(Rate) - Rate;
		}

		public static double Expansion(this double Rate)
		{
			if (Rate == 0.0)
			{
				return 1.0;
			}
			return (double)Math.Sign(Rate) + Rate;
		}

		public static double Reciprocal(this double Rate)
		{
			if (Rate == 0.0)
			{
				return 1.0;
			}
			return 1.0 / Rate;
		}

		public static double Ratio(this double Target, double Standard)
		{
			return Target / Standard;
		}

		public static double Target(this double Standard, double Ratio)
		{
			return Standard * Ratio;
		}

		public static double Standard(this double Target, double Ratio)
		{
			return Target / Ratio;
		}

		public static double Variation(this double Standard, double Voltility)
		{
			return Standard + Standard * Voltility;
		}

		public static double Volatility(this double Standard, double Variation)
		{
			return (Variation - Standard) / Standard;
		}
	}
}
