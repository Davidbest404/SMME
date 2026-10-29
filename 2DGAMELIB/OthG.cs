using System;

namespace _2DGAMELIB
{
	public static class OthG
	{
		public static double ToRadian(this double Degree)
		{
			return 3.141592653589793 * Degree / 180.0;
		}

		public static double ToDegree(this double Radian)
		{
			return Radian * 180.0 / 3.141592653589793;
		}
	}
}
