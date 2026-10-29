using System;

namespace _2DGAMELIB
{
	public class ConstProp
	{
		public bool GetFlag(double Proportion)
		{
			this.c++;
			return this.c % (int)(1.0 / Proportion) == 0;
		}

		public void Reset()
		{
			this.c = -1;
		}

		private int c = -1;
	}
}
