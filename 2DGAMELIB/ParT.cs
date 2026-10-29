using System;
using System.Drawing;

namespace _2DGAMELIB
{
	[Serializable]
	public class ParT : Par
	{
		public Font Font
		{
			get
			{
				return this.font;
			}
			set
			{
				if (this.font != value && this.font != null)
				{
					this.font.Dispose();
				}
				this.font = value;
				this.EditF = true;
			}
		}

		public double FontSize
		{
			get
			{
				return this.fontSize;
			}
			set
			{
				this.fontSize = value;
				this.EditF = true;
			}
		}

		public void SetFont(Font Font)
		{
			this.font = Font;
			this.EditF = true;
		}

		public Brush TextBrush
		{
			get
			{
				return this.brusht;
			}
			set
			{
				if (this.brusht != value && this.brusht != null)
				{
					this.brusht.Dispose();
				}
				this.brusht = value;
			}
		}

		public Color TextColor
		{
			get
			{
				return ((SolidBrush)this.brusht).Color;
			}
			set
			{
				((SolidBrush)this.brusht).Color = value;
			}
		}

		public void SetTextBrush(Brush Brush)
		{
			this.brusht = Brush;
		}

		public Brush ShadBrush
		{
			get
			{
				return this.brushs;
			}
			set
			{
				if (this.brushs != value && this.brushs != null)
				{
					this.brushs.Dispose();
				}
				this.brushs = value;
			}
		}

		public Color ShadColor
		{
			get
			{
				return ((SolidBrush)this.brushs).Color;
			}
			set
			{
				((SolidBrush)this.brushs).Color = value;
			}
		}

		public void SetShadBrush(Brush Brush)
		{
			this.brushs = Brush;
		}

		public StringFormat StringFormat
		{
			get
			{
				return this.stringformat;
			}
			set
			{
				if (this.stringformat != value && this.stringformat != null)
				{
					this.stringformat.Dispose();
				}
				this.stringformat = value;
			}
		}

		public void SetStringFormat(StringFormat StringFormat)
		{
			this.stringformat = StringFormat;
		}

		public Vector2D PositionT
		{
			get
			{
				return this.positionT;
			}
			set
			{
				this.positionT = value;
				this.EditT = true;
			}
		}

		public Vector2D RectSize
		{
			get
			{
				return this.rectSize;
			}
			set
			{
				this.rectSize = value;
				this.EditT = true;
			}
		}

		public new void SetDefault()
		{
			base.SetDefault();
			this.font = new Font("", 1f);
			this.brusht = new SolidBrush(Color.Black);
			this.brushs = null;
			this.stringformat = new StringFormat();
		}

		public ParT()
		{
		}

		public ParT(Par Par)
		{
			base.Copy(Par);
		}

		public ParT(ParT ParT)
		{
			this.CopyT(ParT);
		}

		private void CopyT(ParT ParT)
		{
			base.Copy(ParT);
			this.fontSize = ParT.fontSize;
			if (ParT.font != null)
			{
				this.Font = ParT.font.Copy();
			}
			if (ParT.brusht != null)
			{
				this.TextBrush = ParT.brusht.Copy();
			}
			if (ParT.brushs != null)
			{
				this.ShadBrush = ParT.brushs.Copy();
			}
			if (ParT.stringformat != null)
			{
				this.StringFormat = ParT.stringformat.Copy();
			}
			this.positionT = ParT.positionT;
			this.rectSize = ParT.rectSize;
			this.Text = ParT.Text;
		}

		public new void Draw(double Unit, Graphics Graphics)
		{
			if (this.Edit)
			{
				this.EditT = true;
			}
			if (this.EditS || this.EditPS)
			{
				this.EditTS = true;
			}
			base.Draw(Unit, Graphics);
			this.DrawString(Unit, Graphics);
		}

		private void Calculation(double Unit)
		{
			this.us = Unit * base.Size;
			this.usx = this.us * base.SizeX;
			this.usy = this.us * base.SizeY;
			this.bp = base.BasePoint;
			this.bp.X = this.bp.X * this.usx;
			this.bp.Y = this.bp.Y * this.usy;
			this.a0 = base.Angle;
			this.a1 = 3.141592653589793 * this.a0 / 180.0;
			this.M11 = Math.Cos(this.a1);
			this.M12 = Math.Sin(this.a1);
			this.v.X = this.bp.X * this.M11 + this.bp.Y * -this.M12;
			this.v.Y = this.bp.X * this.M12 + this.bp.Y * this.M11;
			this.p = base.Position;
			this.bp.X = this.p.X * Unit - this.v.X;
			this.bp.Y = this.p.Y * Unit - this.v.Y;
			this.rect.X = (float)(this.positionT.X * this.us);
			this.rect.Y = (float)(this.positionT.Y * this.us);
			this.rect.Width = (float)(this.rectSize.X * this.us);
			this.rect.Height = (float)(this.rectSize.Y * this.us);
		}

		private void DrawString(double Unit, Graphics Graphics)
		{
			if (this.EditT)
			{
				this.Calculation(Unit);
				this.EditT = false;
			}
			if (this.EditF || this.EditTS)
			{
				this.Font = new Font(this.font.FontFamily, (float)(this.us * this.fontSize * Med.DpiY));
				this.EditF = false;
				this.EditTS = false;
			}
			this.af = (float)this.a0;
			this.xf = (float)base.SizeX;
			this.yf = (float)base.SizeY;
			if (this.brushs != null)
			{
				Graphics.TranslateTransform((float)(this.bp.X + 1.0), (float)(this.bp.Y + 1.0));
				Graphics.RotateTransform(this.af);
				Graphics.ScaleTransform(this.xf, this.yf);
				Graphics.DrawString(this.Text, this.font, this.brushs, this.rect, this.stringformat);
				Graphics.ResetTransform();
			}
			Graphics.TranslateTransform((float)this.bp.X, (float)this.bp.Y);
			Graphics.RotateTransform(this.af);
			Graphics.ScaleTransform(this.xf, this.yf);
			Graphics.DrawString(this.Text, this.font, this.brusht, this.rect, this.stringformat);
			Graphics.ResetTransform();
		}

		public Vector2D_2 GetStringRect(double Unit, Graphics Graphics)
		{
			double num = Unit * base.Size;
			if (this.EditF || this.EditS || this.EditPS || this.EditTS)
			{
				this.Font = new Font(this.font.FontFamily, (float)(num * this.fontSize * Med.DpiY));
				this.EditF = false;
				this.EditTS = false;
			}
			this.crr[0] = new CharacterRange(0, this.Text.Length);
			this.stringformat.SetMeasurableCharacterRanges(this.crr);
			RectangleF bounds = Graphics.MeasureCharacterRanges(this.Text, this.font, new RectangleF((float)(this.positionT.X * num), (float)(this.positionT.Y * num), (float)(this.rectSize.X * num), (float)(this.rectSize.Y * num)), this.stringformat)[0].GetBounds(Graphics);
			return new Vector2D_2(new Vector2D((double)bounds.X / num, (double)bounds.Y / num), new Vector2D((double)bounds.Width / num, (double)bounds.Height / num));
		}

		public Vector2D GetStringEndPoint(double Unit, Graphics Graphics)
		{
			double num = Unit * base.Size;
			if (this.EditF || this.EditS || this.EditPS || this.EditTS)
			{
				this.Font = new Font(this.font.FontFamily, (float)(num * this.fontSize * Med.DpiY));
				this.EditF = false;
				this.EditTS = false;
			}
			this.cre[0] = new CharacterRange(this.Text.Length - 1, 1);
			this.stringformat.SetMeasurableCharacterRanges(this.cre);
			RectangleF bounds = Graphics.MeasureCharacterRanges(this.Text, this.font, new RectangleF((float)(this.positionT.X * num), (float)(this.positionT.Y * num), (float)(this.rectSize.X * num), (float)(this.rectSize.Y * num)), this.stringformat)[0].GetBounds(Graphics);
			return new Vector2D(((double)bounds.X + (double)bounds.Width) / num, (double)bounds.Y / num);
		}

		public Vector2D[] GetStringRectPoints(double Unit, Graphics Graphics)
		{
			Vector2D_2 stringRect = this.GetStringRect(Unit, Graphics);
			stringRect.v2.X = stringRect.v2.X * 1.07;
			return new Vector2D[]
			{
				stringRect.v1,
				new Vector2D(stringRect.v2.X, stringRect.v1.Y),
				stringRect.v2,
				new Vector2D(stringRect.v1.X, stringRect.v2.Y)
			};
		}

		public void SetStringRectOutline(double Unit, Graphics Graphics)
		{
			Vector2D[] stringRectPoints = this.GetStringRectPoints(Unit, Graphics);
			Out @out = new Out
			{
				Tension = 0f
			};
			Vector2D right = Dat.Vec2DZero - stringRectPoints[0];
			double x = 0.05;
			double num = 0.025;
			@out.ps.Add(stringRectPoints[0].AddY(-num) + right);
			@out.ps.Add(stringRectPoints[1].AddXY(x, -num) + right);
			@out.ps.Add(stringRectPoints[2].AddXY(x, num) + right);
			@out.ps.Add(stringRectPoints[3].AddY(num) + right);
			base.OP.Add(@out);
		}

		public ParT GetInter(ParT ParT)
		{
			ParT parT = new ParT(base.GetInter(ParT));
			parT.fontSize = (this.fontSize + ParT.fontSize) * 0.5;
			if (this.font != null)
			{
				parT.Font = this.font.Copy();
			}
			if (this.brusht != null)
			{
				parT.TextBrush = this.brusht.Copy();
			}
			if (this.brushs != null)
			{
				parT.ShadBrush = this.brushs.Copy();
			}
			if (this.stringformat != null)
			{
				parT.StringFormat = this.stringformat.Copy();
			}
			parT.positionT = (this.positionT + ParT.positionT) * 0.5;
			parT.rectSize = (this.rectSize + ParT.rectSize) * 0.5;
			parT.Text = ParT.Text;
			return parT;
		}

		public new void Dispose()
		{
			base.Dispose();
			if (this.font != null)
			{
				this.font.Dispose();
			}
			if (this.brusht != null)
			{
				this.brusht.Dispose();
			}
			if (this.brushs != null)
			{
				this.brushs.Dispose();
			}
			if (this.stringformat != null)
			{
				this.stringformat.Dispose();
			}
		}

		[NonSerialized]
		private Font font = new Font("", 1f);

		private double fontSize = 1.0;

		private bool EditF = true;

		[NonSerialized]
		private Brush brusht = new SolidBrush(Color.Black);

		private const double Shift = 1.0;

		[NonSerialized]
		private Brush brushs;

		[NonSerialized]
		private StringFormat stringformat = new StringFormat();

		private Vector2D positionT = Dat.Vec2DZero;

		private Vector2D rectSize = Dat.Vec2DOne;

		public string Text = "";

		private RectangleF rect;

		private double us;

		private double usx;

		private double usy;

		private Vector2D bp;

		private Vector2D p;

		private Vector2D v;

		private double a0;

		private double a1;

		private double M11;

		private double M12;

		private float af;

		private float xf;

		private float yf;

		private bool EditT = true;

		private bool EditTS = true;

		private CharacterRange[] crr = new CharacterRange[1];

		private CharacterRange[] cre = new CharacterRange[1];
	}
}
