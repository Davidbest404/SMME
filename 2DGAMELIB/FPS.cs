using System;
using System.Diagnostics;

namespace _2DGAMELIB
{
	public class FPS
	{
		public FPS(double FPS)
		{
			this.Value = FPS;
			double num = (double)Stopwatch.Frequency / FPS;
			this.Int = Math.Truncate(num);
			this.Dec = num % 1.0;
			this.sw.Start();
		}

		public void FPSFixed(Action Action)
		{
			this.s0 = this.sw.ElapsedTicks;
			Action();
			if (this.sw.ElapsedTicks - this.s1 >= Stopwatch.Frequency)
			{
				this.Value = (double)Stopwatch.Frequency / ((double)this.sum / (double)this.count);
				this.count = 0;
				this.sum = 0L;
				this.s1 = this.sw.ElapsedTicks;
			}
			this.count++;
			this.wait = this.Int + Math.Truncate(this.frac += this.Dec);
			this.frac %= 1.0;
			while (this.wait > (double)(this.sw.ElapsedTicks - this.s0))
			{
			}
			this.sum += this.sw.ElapsedTicks - this.s0;
		}

		public Stopwatch sw = new Stopwatch();

		private long s0;

		private long s1;

		public double Value;

		private int count;

		private long sum;

		private double wait;

		private double Int;

		private double Dec;

		private double frac;
	}
}
