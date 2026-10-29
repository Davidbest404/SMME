using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using _2DGAMELIB;

namespace SlaveMatrix
{
	[Serializable]
	public class ColorP
	{
		public ColorP(Par Par, ColorD ColorD, double Unit, bool abj)
		{
			this.Par = Par;
			this.ColorD = ColorD;
			this.Unit = Unit;
			this.abj = abj;
			this.Setting();
		}

		public void Setting()
		{
			this.Par.Brush = new SolidBrush(Color.LightGray);
			this.u0 = this.Unit * 0.99009900990099;
			this.u1 = this.Unit * 1.01;
			if (this.ColorD.線 == Col.Empty)
			{
				this.Par.Pen = null;
				this.p = delegate()
				{
				};
			}
			else
			{
				if (this.abj)
				{
					int alpha;
					this.Par.GetAlpha(out alpha);
					this.ColorD.線 = Color.FromArgb(alpha, this.ColorD.線);
				}
				this.p = delegate()
				{
					this.Par.PenColor = this.ColorD.線;
				};
				this.UpdateLine();
			}
			if (this.ColorD.色.Col1 == Col.Empty)
			{
				this.Par.Brush = null;
				this.b = delegate()
				{
				};
			}
			else
			{
				if (this.ColorD.色.Col2 == Col.Empty)
				{
					this.b = delegate()
					{
						this.Par.BrushColor = this.ColorD.色.Col1;
					};
				}
				else
				{
					Vector2D[] MM;
					float f0;
					float f1;
					this.b = delegate()
					{
						this.Par.GetMiY_MaY(out MM);
						f0 = (float)(MM[0].Y * this.u0);
						f1 = (float)(MM[1].Y * this.u1);
						if (f0 >= 0f || f1 >= 0f)
						{
							this.LGB = new LinearGradientBrush(new PointF(0f, f0), new PointF(0f, f1), this.ColorD.色.Col1, this.ColorD.色.Col2);
							this.LGB.GammaCorrection = true;
							this.Par.Brush = this.LGB;
						}
					};
				}
				this.UpdateColor();
			}
			if (this.Par.Pen == null && this.Par.Brush == null)
			{
				this.Par.Dra = false;
				this.Par.Hit = false;
			}
		}

		public void UpdateLine()
		{
			this.p();
		}

		public void UpdateColor()
		{
			this.b();
		}

		public void Update()
		{
			if (this.Par.Dra)
			{
				this.p();
				this.b();
			}
		}

		public void Update(Vector2D[] mm)
		{
			if (this.Par.Dra)
			{
				this.p();
				this.f0 = (float)(mm[0].Y * this.u0);
				this.f1 = (float)(mm[1].Y * this.u1);
				if (this.f0 >= 0f || this.f1 >= 0f)
				{
					this.LGB = new LinearGradientBrush(new PointF(0f, this.f0), new PointF(0f, this.f1), this.ColorD.色.Col1, this.ColorD.色.Col2);
					this.LGB.GammaCorrection = true;
					this.Par.Brush = this.LGB;
				}
			}
		}

		public Par Par;

		public ColorD ColorD;

		public double Unit;

		public bool abj;

		private Action p;

		private Action b;

		private LinearGradientBrush LGB;

		private double u0;

		private double u1;

		private float f0;

		private float f1;
	}
}
