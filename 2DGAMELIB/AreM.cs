using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2DGAMELIB
{
	public class AreM : Are
	{
		public double Strength
		{
			get
			{
				return this.strength;
			}
		}

		public double UnitS
		{
			get
			{
				return this.unitS;
			}
		}

		public AreM()
		{
		}

		public AreM(double Unit, double XRatio, double YRatio, double Size, double DisMag, double HitMag, double Strength)
		{
			this.Setting(Unit, XRatio, YRatio, Size, DisMag, HitMag, Strength);
		}

		public AreM(double Unit, double XRatio, double YRatio, double Size, double DisMag, double Strength)
		{
			this.Setting(Unit, XRatio, YRatio, Size, DisMag, Strength);
		}

		public AreM(Med Med, bool Hit, double Strength)
		{
			if (Hit)
			{
				this.Setting(Med.Unit, Med.Base.XRatio, Med.Base.YRatio, Med.Base.Size, Med.DisQuality, Med.HitAccuracy, Strength);
				return;
			}
			this.Setting(Med.Unit, Med.Base.XRatio, Med.Base.YRatio, Med.Base.Size, Med.DisQuality, Strength);
		}

		private void Setting(double Unit, double XRatio, double YRatio, double Size, double DisMag, double HitMag, double Strength)
		{
			base.SetXYRatio(XRatio, YRatio);
			this.Size = Size;
			this.unit = Unit;
			this.strength = Strength;
			this.disUnit = Unit * DisMag;
			double num = 1.0 - Strength;
			this.unitS = this.disUnit * num;
			this.WH.Width = (int)(base.LocalWidth * Unit);
			this.WH.Height = (int)(base.LocalHeight * Unit);
			this.WHA.Width = (int)(base.LocalWidth * this.disUnit);
			this.WHA.Height = (int)(base.LocalHeight * this.disUnit);
			this.Dis = new Bitmap((int)((double)this.WH.Width * DisMag * num), (int)((double)this.WH.Height * DisMag * num));
			this.gd = Graphics.FromImage(this.Dis);
			this.gd.SmoothingMode = SmoothingMode.None;
			this.gd.PixelOffsetMode = PixelOffsetMode.None;
			this.hitUnit = Unit * HitMag;
			this.WHH.Width = (int)(base.LocalWidth * this.hitUnit);
			this.WHH.Height = (int)(base.LocalHeight * this.hitUnit);
			this.Hit = new Bitmap(this.WHH.Width, this.WHH.Height);
			this.gh = Graphics.FromImage(this.Hit);
			this.gh.SmoothingMode = SmoothingMode.None;
			this.gh.PixelOffsetMode = PixelOffsetMode.None;
		}

		private void Setting(double Unit, double XRatio, double YRatio, double Size, double DisMag, double Strength)
		{
			base.SetXYRatio(XRatio, YRatio);
			this.Size = Size;
			this.unit = Unit;
			this.strength = Strength;
			this.disUnit = Unit * DisMag;
			double num = 1.0 - Strength;
			this.unitS = this.disUnit * num;
			this.WH.Width = (int)(base.LocalWidth * Unit);
			this.WH.Height = (int)(base.LocalHeight * Unit);
			this.WHA.Width = (int)(base.LocalWidth * this.disUnit);
			this.WHA.Height = (int)(base.LocalHeight * this.disUnit);
			this.Dis = new Bitmap((int)((double)this.WH.Width * DisMag * num), (int)((double)this.WH.Height * DisMag * num));
			this.gd = Graphics.FromImage(this.Dis);
			this.gd.SmoothingMode = SmoothingMode.None;
			this.gd.PixelOffsetMode = PixelOffsetMode.None;
		}

		public new void Draw(Par Par)
		{
			Par.Draw(this.unitS, this.gd);
			if (this.gh != null)
			{
				Par.DrawH(this.hitUnit, this.gh);
			}
		}

		public new void Draw(ParT ParT)
		{
			ParT.Draw(this.unitS, this.gd);
			if (this.gh != null)
			{
				ParT.DrawH(this.hitUnit, this.gh);
			}
		}

		public new void Draw(Pars Pars)
		{
			Pars.Draw(this.unitS, this.gd);
			if (this.gh != null)
			{
				Pars.DrawH(this.hitUnit, this.gh);
			}
		}

		public new void DrawCycle(Pen DisPen, Pen HitPen, double PenWidth, double X, double Y, double Radius)
		{
			DisPen.Width = (float)(this.unitS * PenWidth);
			HitPen.Width = (float)(this.hitUnit * PenWidth);
			double num = Radius * 2.0;
			double num2 = X - Radius;
			double num3 = Y - Radius;
			float num4 = (float)(num * this.unitS);
			this.gd.DrawEllipse(DisPen, (float)(num2 * this.unitS), (float)(num3 * this.unitS), num4, num4);
			num4 = (float)(num * this.hitUnit);
			if (this.gh != null)
			{
				this.gh.DrawEllipse(HitPen, (float)(num2 * this.hitUnit), (float)(num3 * this.hitUnit), num4, num4);
			}
		}

		public new void FillCycle(Brush DisBrush, Brush HitBrush, double X, double Y, double Radius)
		{
			double num = Radius * 2.0;
			double num2 = X - Radius;
			double num3 = Y - Radius;
			float num4 = (float)(num * this.unitS);
			this.gd.FillEllipse(DisBrush, (float)(num2 * this.unitS), (float)(num3 * this.unitS), num4, num4);
			num4 = (float)(num * this.hitUnit);
			if (this.gh != null)
			{
				this.gh.FillEllipse(HitBrush, (float)(num2 * this.hitUnit), (float)(num3 * this.hitUnit), num4, num4);
			}
		}

		public new void DrawRect(Pen DisPen, Pen HitPen, double PenWidth, double StaX, double StaY, double EndX, double EndY)
		{
			DisPen.Width = (float)(this.unitS * PenWidth);
			HitPen.Width = (float)(this.hitUnit * PenWidth);
			double num = EndX - StaX;
			double num2 = EndY - StaY;
			this.gd.DrawRectangle(DisPen, (float)(StaX * this.unitS), (float)(StaY * this.unitS), (float)(num * this.unitS), (float)(num2 * this.unitS));
			if (this.gh != null)
			{
				this.gh.DrawRectangle(HitPen, (float)(StaX * this.hitUnit), (float)(StaY * this.hitUnit), (float)(num * this.hitUnit), (float)(num2 * this.hitUnit));
			}
		}

		public new void FillRect(Brush DisBrush, Brush HitBrush, double StaX, double StaY, double EndX, double EndY)
		{
			double num = EndX - StaX;
			double num2 = EndY - StaY;
			this.gd.FillRectangle(DisBrush, (float)(StaX * this.unitS), (float)(StaY * this.unitS), (float)(num * this.unitS), (float)(num2 * this.unitS));
			if (this.gh != null)
			{
				this.gh.FillRectangle(HitBrush, (float)(StaX * this.hitUnit), (float)(StaY * this.hitUnit), (float)(num * this.hitUnit), (float)(num2 * this.hitUnit));
			}
		}

		public new void Draw(Graphics GD)
		{
			this.im = GD.InterpolationMode;
			GD.InterpolationMode = InterpolationMode.NearestNeighbor;
			this.p = base.GetPosition();
			GD.DrawImage(this.Dis, (int)(this.p.X * this.unit), (int)(this.p.Y * this.unit), this.WH.Width, this.WH.Height);
			GD.InterpolationMode = this.im;
		}

		public new void Draw(Graphics GD, double Opacity)
		{
			this.im = GD.InterpolationMode;
			GD.InterpolationMode = InterpolationMode.NearestNeighbor;
			this.cm.Matrix33 = (float)Opacity;
			this.ia.SetColorMatrix(this.cm);
			this.p = base.GetPosition();
			this.r.X = (int)(this.p.X * this.unit);
			this.r.Y = (int)(this.p.Y * this.unit);
			this.r.Width = this.WH.Width;
			this.r.Height = this.WH.Height;
			GD.DrawImage(this.Dis, this.r, 0, 0, this.Dis.Width, this.Dis.Height, GraphicsUnit.Pixel, this.ia);
			GD.InterpolationMode = this.im;
		}

		public new void Draw(Graphics GD, Graphics GH)
		{
			this.im = GD.InterpolationMode;
			GD.InterpolationMode = InterpolationMode.NearestNeighbor;
			this.p = base.GetPosition();
			GD.DrawImage(this.Dis, (int)(this.p.X * this.unit), (int)(this.p.Y * this.unit), this.WH.Width, this.WH.Height);
			if (this.gh != null)
			{
				GH.DrawImage(this.Hit, (int)(this.p.X * this.hitUnit), (int)(this.p.Y * this.hitUnit), this.WHH.Width, this.WHH.Height);
			}
			GD.InterpolationMode = this.im;
		}

		public new void Draw(Graphics GD, Graphics GH, double Opacity)
		{
			this.im = GD.InterpolationMode;
			GD.InterpolationMode = InterpolationMode.NearestNeighbor;
			this.cm.Matrix33 = (float)Opacity;
			this.ia.SetColorMatrix(this.cm);
			this.p = base.GetPosition();
			this.r.X = (int)(this.p.X * this.unit);
			this.r.Y = (int)(this.p.Y * this.unit);
			this.r.Width = this.WH.Width;
			this.r.Height = this.WH.Height;
			GD.DrawImage(this.Dis, this.r, 0, 0, this.Dis.Width, this.Dis.Height, GraphicsUnit.Pixel, this.ia);
			if (this.gh != null)
			{
				GH.DrawImage(this.Hit, (int)(this.p.X * this.hitUnit), (int)(this.p.Y * this.hitUnit), this.WHH.Width, this.WHH.Height);
			}
			GD.InterpolationMode = this.im;
		}

		private double strength;

		private double unitS;
	}
}
