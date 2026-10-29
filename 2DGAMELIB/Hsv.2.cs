using System;
using System.Drawing;

namespace _2DGAMELIB
{
	public struct Hsv
	{
		public int Hue
		{
			get
			{
				return this.H;
			}
			set
			{
				this.H = value;
				this.HueLimit();
			}
		}

		public int Sat
		{
			get
			{
				return this.S;
			}
			set
			{
				this.S = value;
				this.SatLimit();
			}
		}

		public int Val
		{
			get
			{
				return this.V;
			}
			set
			{
				this.V = value;
				this.ValLimit();
			}
		}

		public Hsv(Color Color)
		{
			HSV.ToHSV((int)Color.R, (int)Color.G, (int)Color.B, out this.H, out this.S, out this.V);
		}

		public Hsv(ref Color Color)
		{
			HSV.ToHSV((int)Color.R, (int)Color.G, (int)Color.B, out this.H, out this.S, out this.V);
		}

		public Hsv(int Hue, int Sat, int Val)
		{
			this.H = Hue;
			this.S = Sat;
			this.V = Val;
		}

		private void HueLimit()
		{
			this.H %= 360;
		}

		private void SatLimit()
		{
			if (this.S > 255)
			{
				this.S = 255;
				return;
			}
			if (this.S < 0)
			{
				this.S = 0;
			}
		}

		private void ValLimit()
		{
			if (this.V > 255)
			{
				this.V = 255;
				return;
			}
			if (this.V < 0)
			{
				this.V = 0;
			}
		}

		public Color GetColor()
		{
			int red;
			int green;
			int blue;
			HSV.ToRGB(this.H, this.S, this.V, out red, out green, out blue);
			return Color.FromArgb(red, green, blue);
		}

		public Color GetColor(int a)
		{
			int red;
			int green;
			int blue;
			HSV.ToRGB(this.H, this.S, this.V, out red, out green, out blue);
			return Color.FromArgb(a, red, green, blue);
		}

		public void GetColor(out Color ret)
		{
			int red;
			int green;
			int blue;
			HSV.ToRGB(this.H, this.S, this.V, out red, out green, out blue);
			ret = Color.FromArgb(red, green, blue);
		}

		public void GetColor(int a, out Color ret)
		{
			int red;
			int green;
			int blue;
			HSV.ToRGB(this.H, this.S, this.V, out red, out green, out blue);
			ret = Color.FromArgb(a, red, green, blue);
		}

		public override string ToString()
		{
			return string.Concat(new object[]
			{
				"H : ",
				this.H,
				" S : ",
				this.S,
				" V : ",
				this.V
			});
		}

		public int H;

		public int S;

		public int V;
	}
}
