using System;

namespace _2DGAMELIB
{
	public class Mot : MotV
	{
		public bool Run
		{
			get
			{
				return this.run;
			}
		}

		public Mot(double Min, double Max) : base(Min, Max)
		{
		}

		public new void GetValue(FPS FPS)
		{
			if (this.run)
			{
				base.GetValue(FPS);
				if (this.Runing != null)
				{
					this.Runing(this);
				}
				if (this.Value == this.min)
				{
					if (this.rou && this.Rouing != null)
					{
						this.Rouing(this);
					}
					this.rou = false;
					return;
				}
				if (this.Value == this.max)
				{
					if (this.Reaing != null)
					{
						this.Reaing(this);
					}
					this.rou = true;
				}
			}
		}

		public void Sta()
		{
			if (this.Staing != null)
			{
				this.Staing(this);
			}
			this.run = true;
		}

		public void End()
		{
			this.run = false;
			if (this.Ending != null)
			{
				this.Ending(this);
			}
			base.ResetValue();
			this.rou = false;
		}

		public Action<Mot> Staing;

		public Action<Mot> Runing;

		public Action<Mot> Reaing;

		public Action<Mot> Rouing;

		public Action<Mot> Ending;

		private bool run;

		private bool rou;
	}
}
