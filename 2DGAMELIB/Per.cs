using System;

namespace _2DGAMELIB
{
	public static class Per
	{
		public static double Percent(this double Target, double Standard)
		{
			return Target / Standard * 100.0;
		}

		public static double Target(this double Standard, double Percent)
		{
			return Standard * (Percent / 100.0);
		}

		public static double Standard(this double Target, double Percent)
		{
			return Target / Percent * 100.0;
		}

		public static double ToRate(this double Percent)
		{
			return Percent / 100.0;
		}

		public static double ToPercent(this double Rate)
		{
			return Rate * 100.0;
		}
	}
}
