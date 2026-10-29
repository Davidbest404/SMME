using System;

namespace _2DGAMELIB
{
	public class MotV
	{
		public double Min
		{
			get
			{
				return this.min;
			}
			set
			{
				this.min = value;
				this.SetFrame();
			}
		}

		public double Max
		{
			get
			{
				return this.max;
			}
			set
			{
				this.max = value;
				this.SetFrame();
			}
		}

		public MotV(double Min, double Max)
		{
			this.min = Min;
			this.max = Max;
			this.SetFrame();
			this.ResetValue();
		}

		private void SetFrame()
		{
			this.Frame = this.max - this.min;
			this.FrameHalf = this.Frame * 0.5;
			this.MinFrameHalf = this.Min + this.FrameHalf;
		}

		public void ResetValue()
		{
			this.Value = this.min;
		}

		private void Count(FPS FPS)
		{
			this.m = this.Frame / FPS.Value;
			this.Value += (this.m * this.d + this.m * this.LowestIncrease) * this.BaseSpeed * ((this.s > 0) ? this.GotoSpeed : this.RetuSpeed) * (double)this.s;
		}

		public void GetValue(FPS FPS)
		{
			if ((double)(FPS.sw.ElapsedMilliseconds - this.st) >= this.Interval && FPS.Value > 0.0)
			{
				this.d = (this.MinFrameHalf - this.Value) / this.FrameHalf;
				this.d *= (double)this.d.Sign();
				this.d = this.d.Inverse();
				this.Count(FPS);
				if (this.Value >= this.max)
				{
					this.Value = this.max;
					this.s = -this.s;
					return;
				}
				if (this.Value <= this.min)
				{
					this.Value = this.min;
					this.s = -this.s;
					this.st = FPS.sw.ElapsedMilliseconds;
				}
			}
		}

		public double Value;

		protected double min = -1.0;

		protected double max = 1.0;

		private double Frame;

		private double FrameHalf;

		private double MinFrameHalf;

		public double BaseSpeed = 1.0;

		public double GotoSpeed = 1.0;

		public double RetuSpeed = 1.0;

		public double Interval;

		private long st;

		public double LowestIncrease = 1.0;

		private int s = 1;

		private double d;

		private double m;
	}
}
