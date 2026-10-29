using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace _2DGAMELIB
{
	public class Sce
	{
		public Sce(int Width, int Height)
		{
			this.w = Width;
			this.h = Height;
			this.Sta = new Bitmap(this.w, this.h);
			this.GS = Graphics.FromImage(this.Sta);
			this.End = new Bitmap(this.w, this.h);
			this.GE = Graphics.FromImage(this.End);
			this.r = new Rectangle(0, 0, this.w, this.h);
		}

		public void SlideR(Graphics Graphics, double Rate)
		{
			this.o = (int)((double)this.w * Rate);
			Graphics.DrawImage(this.Sta, this.o, 0);
			Graphics.DrawImage(this.End, this.o - this.w, 0);
		}

		public void SlideL(Graphics Graphics, double Rate)
		{
			this.o = -(int)((double)this.w * Rate);
			Graphics.DrawImage(this.Sta, this.o, 0);
			Graphics.DrawImage(this.End, this.o + this.w, 0);
		}

		public void SlideD(Graphics Graphics, double Rate)
		{
			this.o = (int)((double)this.h * Rate);
			Graphics.DrawImage(this.Sta, 0, this.o);
			Graphics.DrawImage(this.End, 0, this.o - this.h);
		}

		public void SlideU(Graphics Graphics, double Rate)
		{
			this.o = -(int)((double)this.h * Rate);
			Graphics.DrawImage(this.Sta, 0, this.o);
			Graphics.DrawImage(this.End, 0, this.o + this.h);
		}

		public void TransA(Graphics Graphics, double Rate)
		{
			Graphics.DrawImage(this.Sta, 0, 0);
			this.cm.Matrix33 = (float)Rate;
			this.ia.SetColorMatrix(this.cm);
			Graphics.DrawImage(this.End, this.r, 0, 0, this.w, this.h, GraphicsUnit.Pixel, this.ia);
		}

		public void TransD(Graphics Graphics, double Rate)
		{
			Graphics.DrawImage(this.End, 0, 0);
			this.cm.Matrix33 = (float)Rate.Inverse();
			this.ia.SetColorMatrix(this.cm);
			Graphics.DrawImage(this.Sta, this.r, 0, 0, this.w, this.h, GraphicsUnit.Pixel, this.ia);
		}

		public void DrawSta(Are Are)
		{
			Are.Draw(this.GS);
		}

		public void DrawSta(Are Are, double Opacity)
		{
			Are.Draw(this.GS, Opacity);
		}

		public void DrawEnd(Are Are)
		{
			Are.Draw(this.GE);
		}

		public void DrawEnd(Are Are, double Opacity)
		{
			Are.Draw(this.GE, Opacity);
		}

		public void DrawSta(AreM AreM)
		{
			AreM.Draw(this.GS);
		}

		public void DrawSta(AreM AreM, double Opacity)
		{
			AreM.Draw(this.GS, Opacity);
		}

		public void DrawEnd(AreM AreM)
		{
			AreM.Draw(this.GE);
		}

		public void DrawEnd(AreM AreM, double Opacity)
		{
			AreM.Draw(this.GE, Opacity);
		}

		public void ClearSta(Color ClearColor)
		{
			this.GS.Clear(ClearColor);
		}

		public void ClearSta(ref Color ClearColor)
		{
			this.GS.Clear(ClearColor);
		}

		public void ClearEnd(Color ClearColor)
		{
			this.GE.Clear(ClearColor);
		}

		public void ClearEnd(ref Color ClearColor)
		{
			this.GE.Clear(ClearColor);
		}

		public void Dispose()
		{
			this.Sta.Dispose();
			this.GS.Dispose();
			this.End.Dispose();
			this.GE.Dispose();
			this.ia.Dispose();
		}

		private Bitmap Sta;

		private Graphics GS;

		private Bitmap End;

		private Graphics GE;

		private int w;

		private int h;

		private int o;

		private Rectangle r;

		private ColorMatrix cm = new ColorMatrix();

		private ImageAttributes ia = new ImageAttributes();
	}
}
