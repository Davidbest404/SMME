using System;

namespace _2DGAMELIB
{
	public class Rec
	{
		public double LocalWidth
		{
			get
			{
				return this.XRatio * this.Size;
			}
		}

		public double LocalHeight
		{
			get
			{
				return this.YRatio * this.Size;
			}
		}

		public Vector2D LocalCenter
		{
			get
			{
				return new Vector2D(this.LocalWidth * 0.5, this.LocalHeight * 0.5);
			}
		}

		public Rec()
		{
		}

		public Rec(double XRatio, double YRatio, double Size)
		{
			this.SetXYRatio(XRatio, YRatio);
			this.Size = Size;
		}

		public void SetXYRatio(double X, double Y)
		{
			this.XRatio = X / Y;
			this.YRatio = 1.0;
		}

		protected Vector2D XYScaling(ref Vector2D Local)
		{
			return new Vector2D(Local.X * this.XRatio, Local.Y * this.YRatio);
		}

		public Vector2D GetPosition(double X, double Y)
		{
			return new Vector2D(this.LocalWidth * X, this.LocalHeight * Y);
		}

		public Vector2D GetPosition(Vector2D p)
		{
			return new Vector2D(this.LocalWidth * p.X, this.LocalHeight * p.Y);
		}

		public Vector2D GetPosition(ref Vector2D p)
		{
			return new Vector2D(this.LocalWidth * p.X, this.LocalHeight * p.Y);
		}

		public double XRatio = 1.0;

		public double YRatio = 1.0;

		public double Size = 1.0;
	}
}
