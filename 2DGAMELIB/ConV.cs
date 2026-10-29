using System;

namespace _2DGAMELIB
{
	public class ConV
	{
		public ConV()
		{
		}

		public ConV(double Speed)
		{
			this.Speed = Speed;
		}

		public double GetValue(FPS FPS)
		{
			return this.Speed / FPS.Value;
		}

		public void GetValue(FPS FPS, out double o)
		{
			o = this.Speed / FPS.Value;
		}

		public double Speed = 1.0;
	}
}
