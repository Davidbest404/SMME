using System;
using System.Drawing;

namespace SlaveMatrix
{
	[Serializable]
	public class ColorD
	{
		public Color 線
		{
			get
			{
				return this.c;
			}
			set
			{
				this.c = value;
				this.Alpha_c = (int)this.c.A;
			}
		}

		public Color2 色
		{
			get
			{
				return this.c2;
			}
			set
			{
				this.c2 = value;
				this.Alpha_c1 = (int)this.c2.Col1.A;
				this.Alpha_c2 = (int)this.c2.Col2.A;
			}
		}

		public double 不透明度
		{
			get
			{
				return this.Alpha;
			}
			set
			{
				this.Alpha = value;
				if (this.Alpha_c > 0)
				{
					this.c = Color.FromArgb((int)((double)this.Alpha_c * this.Alpha), this.線);
				}
				if (this.Alpha_c1 > 0)
				{
					this.c2.Col1 = Color.FromArgb((int)((double)this.Alpha_c1 * this.Alpha), this.c2.Col1);
				}
				if (this.Alpha_c2 > 0)
				{
					this.c2.Col2 = Color.FromArgb((int)((double)this.Alpha_c2 * this.Alpha), this.c2.Col2);
				}
			}
		}

		public ColorD(ref Color 線, ref Color2 色)
		{
			this.線 = 線;
			this.色 = 色;
		}

		public ColorD()
		{
			this.線 = Col.Black;
			this.色 = new Color2(ref Col.White, ref Col.DarkGray);
		}

		public void SetBlack()
		{
			this.線 = Col.Black;
			this.色 = new Color2(ref Col.Black, ref Col.Black);
		}

		public Color c;

		public Color2 c2;

		private double Alpha = 1.0;

		private int Alpha_c;

		private int Alpha_c1;

		private int Alpha_c2;
	}
}
