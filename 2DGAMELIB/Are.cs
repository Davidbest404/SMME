using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace _2DGAMELIB
{
	public class Are : Rec
	{
		public Graphics GD
		{
			get
			{
				return this.gd;
			}
		}

		public Graphics GH
		{
			get
			{
				return this.gh;
			}
		}

		public double Unit
		{
			get
			{
				return this.unit;
			}
		}

		public double DisUnit
		{
			get
			{
				return this.disUnit;
			}
		}

		public double HitUnit
		{
			get
			{
				return this.hitUnit;
			}
		}

		public Are()
		{
		}

		public Are(double Unit, double XRatio, double YRatio, double Size, double DisMag, double HitMag)
		{
			this.Setting(Unit, XRatio, YRatio, Size, DisMag, HitMag);
		}

		public Are(double Unit, double XRatio, double YRatio, double Size, double DisMag)
		{
			this.Setting(Unit, XRatio, YRatio, Size, DisMag);
		}

		public Are(Med Med, bool Hit)
		{
			if (Hit)
			{
				this.Setting(Med.Unit, Med.Base.XRatio, Med.Base.YRatio, Med.Base.Size, Med.DisQuality, Med.HitAccuracy);
				return;
			}
			this.Setting(Med.Unit, Med.Base.XRatio, Med.Base.YRatio, Med.Base.Size, Med.DisQuality);
		}

		private void Setting(double Unit, double XRatio, double YRatio, double Size, double DisMag, double HitMag)
		{
			base.SetXYRatio(XRatio, YRatio);
			this.Size = Size;
			this.unit = Unit;
			this.disUnit = Unit * DisMag;
			this.WH.Width = (int)(base.LocalWidth * Unit);
			this.WH.Height = (int)(base.LocalHeight * Unit);
			this.WHA.Width = (int)(base.LocalWidth * this.disUnit);
			this.WHA.Height = (int)(base.LocalHeight * this.disUnit);
			this.Dis = new Bitmap((int)((double)this.WH.Width * DisMag), (int)((double)this.WH.Height * DisMag));
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

		private void Setting(double Unit, double XRatio, double YRatio, double Size, double DisMag)
		{
			base.SetXYRatio(XRatio, YRatio);
			this.Size = Size;
			this.unit = Unit;
			this.disUnit = Unit * DisMag;
			this.WH.Width = (int)(base.LocalWidth * Unit);
			this.WH.Height = (int)(base.LocalHeight * Unit);
			this.WHA.Width = (int)(base.LocalWidth * this.disUnit);
			this.WHA.Height = (int)(base.LocalHeight * this.disUnit);
			this.Dis = new Bitmap((int)((double)this.WH.Width * DisMag), (int)((double)this.WH.Height * DisMag));
			this.gd = Graphics.FromImage(this.Dis);
			this.gd.SmoothingMode = SmoothingMode.None;
			this.gd.PixelOffsetMode = PixelOffsetMode.None;
		}

		public Vector2D GetPosition()
		{
			return new Vector2D(this.Position.X - this.BasePoint.X * this.XRatio * this.Size, this.Position.Y - this.BasePoint.Y * this.YRatio * this.Size);
		}

		public void Draw(Par Par)
		{
			Par.Draw(this.disUnit, this.gd);
			if (this.gh != null)
			{
				Par.DrawH(this.hitUnit, this.gh);
			}
		}

		public void Draw(ParT ParT)
		{
			ParT.Draw(this.disUnit, this.gd);
			if (this.gh != null)
			{
				ParT.DrawH(this.hitUnit, this.gh);
			}
		}

		public void Draw(Pars Pars)
		{
			Pars.Draw(this.disUnit, this.gd);
			if (this.gh != null)
			{
				Pars.DrawH(this.hitUnit, this.gh);
			}
		}

		public void DrawCycle(Pen DisPen, Pen HitPen, double PenWidth, double X, double Y, double Radius)
		{
			DisPen.Width = (float)(this.disUnit * PenWidth);
			HitPen.Width = (float)(this.hitUnit * PenWidth);
			double num = Radius * 2.0;
			double num2 = X - Radius;
			double num3 = Y - Radius;
			float num4 = (float)(num * this.disUnit);
			this.gd.DrawEllipse(DisPen, (float)(num2 * this.disUnit), (float)(num3 * this.disUnit), num4, num4);
			num4 = (float)(num * this.hitUnit);
			if (this.gh != null)
			{
				this.gh.DrawEllipse(HitPen, (float)(num2 * this.hitUnit), (float)(num3 * this.hitUnit), num4, num4);
			}
		}

		public void FillCycle(Brush DisBrush, Brush HitBrush, double X, double Y, double Radius)
		{
			double num = Radius * 2.0;
			double num2 = X - Radius;
			double num3 = Y - Radius;
			float num4 = (float)(num * this.disUnit);
			this.gd.FillEllipse(DisBrush, (float)(num2 * this.disUnit), (float)(num3 * this.disUnit), num4, num4);
			num4 = (float)(num * this.hitUnit);
			if (this.gh != null)
			{
				this.gh.FillEllipse(HitBrush, (float)(num2 * this.hitUnit), (float)(num3 * this.hitUnit), num4, num4);
			}
		}

		public void DrawRect(Pen DisPen, Pen HitPen, double PenWidth, double StaX, double StaY, double EndX, double EndY)
		{
			DisPen.Width = (float)(this.disUnit * PenWidth);
			HitPen.Width = (float)(this.hitUnit * PenWidth);
			double num = EndX - StaX;
			double num2 = EndY - StaY;
			this.gd.DrawRectangle(DisPen, (float)(StaX * this.disUnit), (float)(StaY * this.disUnit), (float)(num * this.disUnit), (float)(num2 * this.disUnit));
			if (this.gh != null)
			{
				this.gh.DrawRectangle(HitPen, (float)(StaX * this.hitUnit), (float)(StaY * this.hitUnit), (float)(num * this.hitUnit), (float)(num2 * this.hitUnit));
			}
		}

		public void FillRect(Brush DisBrush, Brush HitBrush, double StaX, double StaY, double EndX, double EndY)
		{
			double num = EndX - StaX;
			double num2 = EndY - StaY;
			this.gd.FillRectangle(DisBrush, (float)(StaX * this.disUnit), (float)(StaY * this.disUnit), (float)(num * this.disUnit), (float)(num2 * this.disUnit));
			if (this.gh != null)
			{
				this.gh.FillRectangle(HitBrush, (float)(StaX * this.hitUnit), (float)(StaY * this.hitUnit), (float)(num * this.hitUnit), (float)(num2 * this.hitUnit));
			}
		}

		public void Draw(Graphics GD)
		{
			this.p = this.GetPosition();
			GD.DrawImage(this.Dis, (int)(this.p.X * this.unit), (int)(this.p.Y * this.unit), this.WH.Width, this.WH.Height);
		}

		public void Draw(Graphics GD, double Opacity)
		{
			this.cm.Matrix33 = (float)Opacity;
			this.ia.SetColorMatrix(this.cm);
			this.p = this.GetPosition();
			this.r.X = (int)(this.p.X * this.unit);
			this.r.Y = (int)(this.p.Y * this.unit);
			this.r.Width = this.WH.Width;
			this.r.Height = this.WH.Height;
			GD.DrawImage(this.Dis, this.r, 0, 0, this.Dis.Width, this.Dis.Height, GraphicsUnit.Pixel, this.ia);
		}

		public void Draw(Graphics GD, Graphics GH)
		{
			this.p = this.GetPosition();
			GD.DrawImage(this.Dis, (int)(this.p.X * this.unit), (int)(this.p.Y * this.unit), this.WH.Width, this.WH.Height);
			if (this.gh != null)
			{
				GH.DrawImage(this.Hit, (int)(this.p.X * this.hitUnit), (int)(this.p.Y * this.hitUnit), this.WHH.Width, this.WHH.Height);
			}
		}

		public void Draw(Graphics GD, Graphics GH, double Opacity)
		{
			this.cm.Matrix33 = (float)Opacity;
			this.ia.SetColorMatrix(this.cm);
			this.p = this.GetPosition();
			this.r.X = (int)(this.p.X * this.unit);
			this.r.Y = (int)(this.p.Y * this.unit);
			this.r.Width = this.WH.Width;
			this.r.Height = this.WH.Height;
			GD.DrawImage(this.Dis, this.r, 0, 0, this.Dis.Width, this.Dis.Height, GraphicsUnit.Pixel, this.ia);
			if (this.gh != null)
			{
				GH.DrawImage(this.Hit, (int)(this.p.X * this.hitUnit), (int)(this.p.Y * this.hitUnit), this.WHH.Width, this.WHH.Height);
			}
		}

		public void Draw(Are Are)
		{
			this.p = Are.GetPosition();
			this.GD.DrawImage(Are.Dis, (float)(this.p.X * Are.disUnit), (float)(this.p.Y * Are.disUnit), (float)Are.WHA.Width, (float)Are.WHA.Height);
			if (Are.gh != null && this.GH != null)
			{
				this.GH.DrawImage(Are.Hit, (int)(this.p.X * Are.hitUnit), (int)(this.p.Y * Are.hitUnit), Are.WHH.Width, Are.WHH.Height);
			}
		}

		public void Draw(Are Are, double Opacity)
		{
			this.cm.Matrix33 = (float)Opacity;
			this.ia.SetColorMatrix(this.cm);
			this.p = Are.GetPosition();
			this.r.X = (int)(this.p.X * Are.disUnit);
			this.r.Y = (int)(this.p.Y * Are.disUnit);
			this.r.Width = Are.WHA.Width;
			this.r.Height = Are.WHA.Height;
			this.GD.DrawImage(Are.Dis, this.r, 0, 0, this.Dis.Width, this.Dis.Height, GraphicsUnit.Pixel, this.ia);
			if (Are.gh != null && this.GH != null)
			{
				this.GH.DrawImage(Are.Hit, (int)(this.p.X * Are.hitUnit), (int)(this.p.Y * Are.hitUnit), Are.WHH.Width, Are.WHH.Height);
			}
		}

		public void Draw(AreM AreM)
		{
			this.im = this.GD.InterpolationMode;
			this.GD.InterpolationMode = InterpolationMode.NearestNeighbor;
			this.p = AreM.GetPosition();
			this.GD.DrawImage(AreM.Dis, (float)(this.p.X * AreM.disUnit), (float)(this.p.Y * AreM.disUnit), (float)AreM.WHA.Width, (float)AreM.WHA.Height);
			if (AreM.gh != null && this.GH != null)
			{
				this.GH.DrawImage(AreM.Hit, (int)(this.p.X * AreM.hitUnit), (int)(this.p.Y * AreM.hitUnit), AreM.WHH.Width, AreM.WHH.Height);
			}
			this.GD.InterpolationMode = this.im;
		}

		public void Draw(AreM AreM, double Opacity)
		{
			this.im = this.GD.InterpolationMode;
			this.GD.InterpolationMode = InterpolationMode.NearestNeighbor;
			this.cm.Matrix33 = (float)Opacity;
			this.ia.SetColorMatrix(this.cm);
			this.p = AreM.GetPosition();
			this.r.X = (int)(this.p.X * AreM.disUnit);
			this.r.Y = (int)(this.p.Y * AreM.disUnit);
			this.r.Width = AreM.WHA.Width;
			this.r.Height = AreM.WHA.Height;
			this.GD.DrawImage(AreM.Dis, this.r, 0, 0, this.Dis.Width, this.Dis.Height, GraphicsUnit.Pixel, this.ia);
			if (AreM.gh != null && this.GH != null)
			{
				this.GH.DrawImage(AreM.Hit, (int)(this.p.X * AreM.hitUnit), (int)(this.p.Y * AreM.hitUnit), AreM.WHH.Width, AreM.WHH.Height);
			}
			this.GD.InterpolationMode = this.im;
		}

		public void Clear()
		{
			this.gd.Clear(this.ClearColor);
			if (this.gh != null)
			{
				this.gh.Clear(this.ClearColor);
			}
		}

		public void Clear(Color Color)
		{
			this.gd.Clear(Color);
			if (this.gh != null)
			{
				this.gh.Clear(this.ClearColor);
			}
		}

		public void Clear(ref Color Color)
		{
			this.gd.Clear(Color);
			if (this.gh != null)
			{
				this.gh.Clear(this.ClearColor);
			}
		}

		public void Dispose()
		{
			this.Dis.Dispose();
			this.gd.Dispose();
			if (this.Hit != null)
			{
				this.Hit.Dispose();
				this.gh.Dispose();
			}
		}

		public Bitmap Dis;

		protected Graphics gd;

		protected Bitmap Hit;

		protected Graphics gh;

		protected double unit;

		protected double disUnit;

		protected double hitUnit;

		protected Size WH = System.Drawing.Size.Empty;

		protected Size WHH = System.Drawing.Size.Empty;

		protected Size WHA = System.Drawing.Size.Empty;

		private Color ClearColor = Color.Transparent;

		public Vector2D BasePoint = Dat.Vec2DZero;

		public Vector2D Position = Dat.Vec2DZero;

		protected Vector2D p;

		protected Rectangle r;

		protected ColorMatrix cm = new ColorMatrix();

		protected ImageAttributes ia = new ImageAttributes();

		protected InterpolationMode im;
	}
}
