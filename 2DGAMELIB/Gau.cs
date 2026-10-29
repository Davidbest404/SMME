using System;
using System.Drawing;

namespace _2DGAMELIB
{
	public class Gau
	{
		public Pars Pars
		{
			get
			{
				return this.pars;
			}
		}

		public Par Base
		{
			get
			{
				return this.base_;
			}
		}

		public Par Frame1
		{
			get
			{
				return this.frame1;
			}
		}

		public Par Frame2
		{
			get
			{
				return this.frame2;
			}
		}

		public Par Gauge
		{
			get
			{
				return this.gauge;
			}
		}

		public Par Knob
		{
			get
			{
				return this.knob;
			}
		}

		public double Value
		{
			get
			{
				return this.val;
			}
			set
			{
				this.val = value;
				this.SetLimit();
				this.SetColor();
				this.SetValue();
			}
		}

		private void SetLimit()
		{
			if (this.Range == Range.ZeroOne)
			{
				this.val = this.val.LimitM(0.0, 1.0);
				return;
			}
			this.val = this.val.LimitM(-1.0, 1.0);
		}

		private void SetColor()
		{
			if (this.val > 0.0)
			{
				this.gauge.SetBrush(this.PlusBrush);
				return;
			}
			this.gauge.SetBrush(this.MinusBrush);
		}

		private void SetValue()
		{
			if (this.Open == Open.Top || this.Open == Open.Bot)
			{
				this.gauge.SizeYCont = this.val;
			}
			else if (this.Open == Open.Lef || this.Open == Open.Rig)
			{
				this.gauge.SizeXCont = this.val;
			}
			if (this.knob != null)
			{
				this.knob.PositionBase = this.GetKnobPosition();
			}
		}

		private Vector2D TL1
		{
			get
			{
				return this.frame1.OP[0].ps[0];
			}
		}

		private Vector2D TR1
		{
			get
			{
				return this.frame1.OP[0].ps[1];
			}
		}

		private Vector2D BR1
		{
			get
			{
				return this.frame1.OP[0].ps[2];
			}
		}

		private Vector2D BL1
		{
			get
			{
				return this.frame1.OP[0].ps[3];
			}
		}

		private Vector2D TL2
		{
			get
			{
				return this.frame2.OP[0].ps[0];
			}
		}

		private Vector2D TR2
		{
			get
			{
				return this.frame2.OP[0].ps[1];
			}
		}

		private Vector2D BR2
		{
			get
			{
				return this.frame2.OP[0].ps[2];
			}
		}

		private Vector2D BL2
		{
			get
			{
				return this.frame2.OP[0].ps[3];
			}
		}

		private Vector2D TLG
		{
			get
			{
				return this.gauge.OP[0].ps[0];
			}
		}

		private Vector2D TRG
		{
			get
			{
				return this.gauge.OP[0].ps[1];
			}
		}

		private Vector2D BRG
		{
			get
			{
				return this.gauge.OP[0].ps[2];
			}
		}

		private Vector2D BLG
		{
			get
			{
				return this.gauge.OP[0].ps[3];
			}
		}

		private Vector2D GetBasePoint1()
		{
			if (this.Range == Range.MinusPlus)
			{
				switch (this.Open)
				{
				case Open.Top:
					return (this.BL1 + this.BR1) * 0.5;
				case Open.Bot:
					return (this.TL1 + this.TR1) * 0.5;
				case Open.Lef:
					return (this.TR1 + this.BR1) * 0.5;
				case Open.Rig:
					return (this.TL1 + this.BL1) * 0.5;
				}
			}
			return this.frame1.OP.GetCenter();
		}

		private Vector2D GetBasePoint2()
		{
			if (this.Range == Range.MinusPlus)
			{
				switch (this.Open)
				{
				case Open.Top:
					return (this.TL2 + this.TR2) * 0.5;
				case Open.Bot:
					return (this.BL2 + this.BR2) * 0.5;
				case Open.Lef:
					return (this.TL2 + this.BL2) * 0.5;
				case Open.Rig:
					return (this.TR2 + this.BR2) * 0.5;
				}
			}
			return this.frame2.OP.GetCenter();
		}

		private Vector2D GetBasePoint()
		{
			if (this.Range == Range.ZeroOne)
			{
				switch (this.Open)
				{
				case Open.Top:
					return (this.BLG + this.BRG) * 0.5;
				case Open.Bot:
					return (this.TLG + this.TRG) * 0.5;
				case Open.Lef:
					return (this.TRG + this.BRG) * 0.5;
				case Open.Rig:
					return (this.TLG + this.BLG) * 0.5;
				}
			}
			return this.frame1.BasePoint;
		}

		private double GetWidthMag()
		{
			if (this.Range == Range.MinusPlus && (this.Open == Open.Lef || this.Open == Open.Rig))
			{
				return 0.5;
			}
			return 1.0;
		}

		private double GetHeightMag()
		{
			if (this.Range == Range.MinusPlus && (this.Open == Open.Top || this.Open == Open.Bot))
			{
				return 0.5;
			}
			return 1.0;
		}

		private double GetGaugeWidthMag(double Margin)
		{
			if (this.Open == Open.Top || this.Open == Open.Bot)
			{
				return (Margin * 2.0).Inverse();
			}
			return 1.0;
		}

		private double GetGaugeHeightMag(double Margin)
		{
			if (this.Open == Open.Lef || this.Open == Open.Rig)
			{
				return (Margin * 2.0).Inverse();
			}
			return 1.0;
		}

		private double GetKnobWidthMag(double Width)
		{
			if (this.Open == Open.Top || this.Open == Open.Bot)
			{
				return Width;
			}
			return 0.1;
		}

		private double GetKnobHeightMag(double Height)
		{
			if (this.Open == Open.Lef || this.Open == Open.Rig)
			{
				return Height;
			}
			return 0.1;
		}

		private Vector2D GetGaugePosition()
		{
			switch (this.Open)
			{
			case Open.Top:
				return this.frame1.ToGlobal((this.BL1 + this.BR1) * 0.5);
			case Open.Bot:
				return this.frame1.ToGlobal((this.TL1 + this.TR1) * 0.5);
			case Open.Lef:
				return this.frame1.ToGlobal((this.TR1 + this.BR1) * 0.5);
			case Open.Rig:
				return this.frame1.ToGlobal((this.TL1 + this.BL1) * 0.5);
			default:
				return Dat.Vec2DZero;
			}
		}

		private Vector2D GetKnobPosition()
		{
			switch (this.Open)
			{
			case Open.Top:
				return this.gauge.ToGlobal((this.TLG + this.TRG) * 0.5);
			case Open.Bot:
				return this.gauge.ToGlobal((this.BLG + this.BRG) * 0.5);
			case Open.Lef:
				return this.gauge.ToGlobal((this.TLG + this.BLG) * 0.5);
			case Open.Rig:
				return this.gauge.ToGlobal((this.TRG + this.BRG) * 0.5);
			default:
				return Dat.Vec2DZero;
			}
		}

		private void ParSetting(string Name, ref Vector2D Position, double Size, double Width, double Height, double Margin, ref Color BackColor, bool knob)
		{
			this.pars = new Pars();
			this.base_ = new Par
			{
				Tag = Name + "_ベース",
				InitializeOP = new Out[]
				{
					Shas.Get正方形()
				},
				PositionBase = Position,
				SizeBase = Size,
				SizeXBase = Width,
				SizeYBase = Height,
				Closed = true,
				Pen = null,
				BrushColor = BackColor
			};
			this.base_.BasePointBase = this.base_.OP.GetCenter();
			this.pars.Add(this.base_.Tag, this.base_);
			this.frame1 = new Par
			{
				Tag = Name + "_フレーム1",
				InitializeOP = new Out[]
				{
					Shas.Get正方形()
				},
				PositionBase = Position,
				SizeBase = Size,
				SizeXBase = Width * this.GetWidthMag(),
				SizeYBase = Height * this.GetHeightMag(),
				Closed = true,
				Brush = null
			};
			this.frame1.BasePointBase = this.GetBasePoint1();
			this.pars.Add(this.frame1.Tag, this.frame1);
			if (this.Range == Range.MinusPlus)
			{
				this.frame2 = new Par
				{
					Tag = Name + "_フレーム2",
					InitializeOP = new Out[]
					{
						Shas.Get正方形()
					},
					PositionBase = Position,
					SizeBase = Size,
					SizeXBase = Width * this.GetWidthMag(),
					SizeYBase = Height * this.GetHeightMag(),
					Closed = true,
					Brush = null
				};
				this.frame2.BasePointBase = this.GetBasePoint2();
				this.pars.Add(this.frame2.Tag, this.frame2);
			}
			this.gauge = new Par
			{
				Tag = Name + "_ゲージ",
				InitializeOP = new Out[]
				{
					Shas.Get正方形()
				},
				PositionBase = this.GetGaugePosition(),
				SizeBase = Size,
				SizeXBase = Width * this.GetWidthMag() * this.GetGaugeWidthMag(Margin),
				SizeYBase = Height * this.GetHeightMag() * this.GetGaugeHeightMag(Margin),
				Closed = true
			};
			this.gauge.BasePointBase = this.GetBasePoint();
			this.pars.Add(this.gauge.Tag, this.gauge);
			if (knob)
			{
				this.knob = new Par
				{
					Tag = Name + "_ノブ",
					InitializeOP = new Out[]
					{
						Shas.Get正方形()
					},
					SizeBase = Size,
					SizeXBase = this.GetKnobWidthMag(Width),
					SizeYBase = this.GetKnobHeightMag(Height),
					Closed = true,
					BrushColor = Color.FromArgb(128, Color.White)
				};
				this.knob.BasePointBase = this.knob.OP.GetCenter();
				this.pars.Add(this.knob.Tag, this.knob);
			}
		}

		public void SetHitColor(Med Med)
		{
			if (this.base_.HitColor != Color.Transparent)
			{
				Med.RemUniqueColor(this.base_.HitColor);
			}
			this.base_.HitColor = Med.GetUniqueColor();
			if (this.frame1.HitColor != Color.Transparent)
			{
				Med.RemUniqueColor(this.frame1.HitColor);
			}
			this.frame1.HitColor = Med.GetUniqueColor();
			if (this.Range == Range.MinusPlus)
			{
				if (this.frame2.HitColor != Color.Transparent)
				{
					Med.RemUniqueColor(this.frame2.HitColor);
				}
				this.frame2.HitColor = Med.GetUniqueColor();
			}
			if (this.gauge.HitColor != Color.Transparent)
			{
				Med.RemUniqueColor(this.gauge.HitColor);
			}
			this.gauge.HitColor = Med.GetUniqueColor();
			if (this.knob != null)
			{
				if (this.knob.HitColor != Color.Transparent)
				{
					Med.RemUniqueColor(this.knob.HitColor);
				}
				this.knob.HitColor = Med.GetUniqueColor();
			}
		}

		private void SetBrush(double Unit, ref Color PlusColor1, ref Color PlusColor2, ref Color MinusColor1, ref Color MinusColor2)
		{
			this.Unit = Unit;
			this.PlusColor1 = PlusColor1;
			this.PlusColor2 = PlusColor2;
			this.MinusColor1 = MinusColor1;
			this.MinusColor2 = MinusColor2;
			switch (this.Open)
			{
			case Open.Top:
			{
				Vector2D[] mm;
				this.frame1.GetMiY_MaY(out mm);
				this.PlusBrush = Oth.GetLGB(Unit, mm, ref PlusColor2, ref PlusColor1);
				if (this.Range == Range.MinusPlus)
				{
					Vector2D[] mm2;
					this.frame2.GetMiY_MaY(out mm2);
					this.MinusBrush = Oth.GetLGB(Unit, mm2, ref MinusColor1, ref MinusColor2);
					return;
				}
				break;
			}
			case Open.Bot:
			{
				Vector2D[] mm3;
				this.frame1.GetMaY_MiY(out mm3);
				this.PlusBrush = Oth.GetLGB(Unit, mm3, ref PlusColor2, ref PlusColor1);
				if (this.Range == Range.MinusPlus)
				{
					Vector2D[] mm4;
					this.frame2.GetMaY_MiY(out mm4);
					this.MinusBrush = Oth.GetLGB(Unit, mm4, ref MinusColor1, ref MinusColor2);
					return;
				}
				break;
			}
			case Open.Lef:
			{
				Vector2D[] mm5;
				this.frame1.GetMiX_MaX(out mm5);
				this.PlusBrush = Oth.GetLGB(Unit, mm5, ref PlusColor2, ref PlusColor1);
				if (this.Range == Range.MinusPlus)
				{
					Vector2D[] mm6;
					this.frame2.GetMiX_MaX(out mm6);
					this.MinusBrush = Oth.GetLGB(Unit, mm6, ref MinusColor1, ref MinusColor2);
				}
				break;
			}
			case Open.Rig:
			{
				Vector2D[] mm7;
				this.frame1.GetMaX_MiX(out mm7);
				this.PlusBrush = Oth.GetLGB(Unit, mm7, ref PlusColor2, ref PlusColor1);
				if (this.Range == Range.MinusPlus)
				{
					Vector2D[] mm8;
					this.frame2.GetMaX_MiX(out mm8);
					this.MinusBrush = Oth.GetLGB(Unit, mm8, ref MinusColor1, ref MinusColor2);
					return;
				}
				break;
			}
			default:
				return;
			}
		}

		public void SetAlphaG(double Alpha)
		{
			switch (this.Open)
			{
			case Open.Top:
			{
				this.PlusBrush.Dispose();
				Vector2D[] mm;
				this.frame1.GetMiY_MaY(out mm);
				this.PlusBrush = Oth.GetLGB(this.Unit, mm, Color.FromArgb((int)(255.0 * Alpha), this.PlusColor2), Color.FromArgb((int)(255.0 * Alpha), this.PlusColor1));
				if (this.Range == Range.MinusPlus)
				{
					this.MinusBrush.Dispose();
					Vector2D[] mm2;
					this.frame2.GetMiY_MaY(out mm2);
					this.MinusBrush = Oth.GetLGB(this.Unit, mm2, Color.FromArgb((int)(255.0 * Alpha), this.MinusColor1), Color.FromArgb((int)(255.0 * Alpha), this.MinusColor2));
					return;
				}
				break;
			}
			case Open.Bot:
			{
				this.PlusBrush.Dispose();
				Vector2D[] mm3;
				this.frame1.GetMaY_MiY(out mm3);
				this.PlusBrush = Oth.GetLGB(this.Unit, mm3, Color.FromArgb((int)(255.0 * Alpha), this.PlusColor2), Color.FromArgb((int)(255.0 * Alpha), this.PlusColor1));
				if (this.Range == Range.MinusPlus)
				{
					this.MinusBrush.Dispose();
					Vector2D[] mm4;
					this.frame2.GetMaY_MiY(out mm4);
					this.MinusBrush = Oth.GetLGB(this.Unit, mm4, Color.FromArgb((int)(255.0 * Alpha), this.MinusColor1), Color.FromArgb((int)(255.0 * Alpha), this.MinusColor2));
					return;
				}
				break;
			}
			case Open.Lef:
			{
				this.PlusBrush.Dispose();
				Vector2D[] mm5;
				this.frame1.GetMiX_MaX(out mm5);
				this.PlusBrush = Oth.GetLGB(this.Unit, mm5, Color.FromArgb((int)(255.0 * Alpha), this.PlusColor2), Color.FromArgb((int)(255.0 * Alpha), this.PlusColor1));
				if (this.Range == Range.MinusPlus)
				{
					this.MinusBrush.Dispose();
					Vector2D[] mm6;
					this.frame2.GetMiX_MaX(out mm6);
					this.MinusBrush = Oth.GetLGB(this.Unit, mm6, Color.FromArgb((int)(255.0 * Alpha), this.MinusColor1), Color.FromArgb((int)(255.0 * Alpha), this.MinusColor2));
				}
				break;
			}
			case Open.Rig:
			{
				this.PlusBrush.Dispose();
				Vector2D[] mm7;
				this.frame1.GetMaX_MiX(out mm7);
				this.PlusBrush = Oth.GetLGB(this.Unit, mm7, Color.FromArgb((int)(255.0 * Alpha), this.PlusColor2), Color.FromArgb((int)(255.0 * Alpha), this.PlusColor1));
				if (this.Range == Range.MinusPlus)
				{
					this.MinusBrush.Dispose();
					Vector2D[] mm8;
					this.frame2.GetMaX_MiX(out mm8);
					this.MinusBrush = Oth.GetLGB(this.Unit, mm8, Color.FromArgb((int)(255.0 * Alpha), this.MinusColor1), Color.FromArgb((int)(255.0 * Alpha), this.MinusColor2));
					return;
				}
				break;
			}
			default:
				return;
			}
		}

		private double GetMax()
		{
			switch (this.Open)
			{
			case Open.Top:
				return -this.gauge.SizeY * this.gauge.Size;
			case Open.Bot:
				return this.gauge.SizeY * this.gauge.Size;
			case Open.Lef:
				return -this.gauge.SizeX * this.gauge.Size;
			case Open.Rig:
				return this.gauge.SizeX * this.gauge.Size;
			default:
				return 0.0;
			}
		}

		private double GetDifference(ref Vector2D CursorPosition)
		{
			if (this.Open == Open.Top || this.Open == Open.Bot)
			{
				return CursorPosition.Y - this.op.Y;
			}
			if (this.Open == Open.Lef || this.Open == Open.Rig)
			{
				return CursorPosition.X - this.op.X;
			}
			return 0.0;
		}

		public Gau(string Name, ref Vector2D Position, double Size, double Width, double Height, double Margin, Open Open, Range Range, ref Color PlusColor, ref Color MinusColor, ref Color BackColor, bool Knob)
		{
			this.Open = Open;
			this.Range = Range;
			this.PlusBrush = new SolidBrush(PlusColor);
			this.MinusBrush = new SolidBrush(MinusColor);
			this.ParSetting(Name, ref Position, Size, Width, Height, Margin, ref BackColor, Knob);
			this.Max = this.GetMax();
			this.Value = 0.0;
		}

		public Gau(string Name, Vector2D Position, double Size, double Width, double Height, double Margin, Open Open, Range Range, Color PlusColor, Color MinusColor, Color BackColor, bool Knob)
		{
			this.Open = Open;
			this.Range = Range;
			this.PlusBrush = new SolidBrush(PlusColor);
			this.MinusBrush = new SolidBrush(MinusColor);
			this.ParSetting(Name, ref Position, Size, Width, Height, Margin, ref BackColor, Knob);
			this.Max = this.GetMax();
			this.Value = 0.0;
		}

		public Gau(string Name, ref Vector2D Position, double Size, double Width, double Height, double Margin, Open Open, Range Range, double DisUnit, ref Color PlusColor1, ref Color PlusColor2, ref Color MinusColor1, ref Color MinusColor2, ref Color BackColor, bool Knob)
		{
			this.Open = Open;
			this.Range = Range;
			this.ParSetting(Name, ref Position, Size, Width, Height, Margin, ref BackColor, Knob);
			this.SetBrush(DisUnit, ref PlusColor1, ref PlusColor2, ref MinusColor1, ref MinusColor2);
			this.Max = this.GetMax();
			this.Value = 0.0;
		}

		public Gau(string Name, Vector2D Position, double Size, double Width, double Height, double Margin, Open Open, Range Range, double DisUnit, Color PlusColor1, Color PlusColor2, Color MinusColor1, Color MinusColor2, Color BackColor, bool Knob)
		{
			this.Open = Open;
			this.Range = Range;
			this.ParSetting(Name, ref Position, Size, Width, Height, Margin, ref BackColor, Knob);
			this.SetBrush(DisUnit, ref PlusColor1, ref PlusColor2, ref MinusColor1, ref MinusColor2);
			this.Max = this.GetMax();
			this.Value = 0.0;
		}

		public bool Down(ref Color HitColor, ref Vector2D CursorPosition)
		{
			if (this.knob != null && this.knob.HitColor == HitColor)
			{
				this.Grip = true;
				this.op = CursorPosition;
				return true;
			}
			return false;
		}

		public bool Up()
		{
			if (this.Grip)
			{
				this.Grip = false;
				return true;
			}
			return false;
		}

		public bool Move(ref Vector2D CursorPosition)
		{
			if (this.Grip)
			{
				this.Value += this.GetDifference(ref CursorPosition) / this.Max;
				this.op = CursorPosition;
				return true;
			}
			return false;
		}

		public bool Leave()
		{
			if (this.Grip)
			{
				this.Grip = false;
				return true;
			}
			return false;
		}

		public void Dispose()
		{
			this.pars.Dispose();
			this.PlusBrush.Dispose();
			if (this.MinusBrush != null)
			{
				this.MinusBrush.Dispose();
			}
		}

		private Pars pars;

		private Par base_;

		private Par frame1;

		private Par frame2;

		private Par gauge;

		private Par knob;

		private double val;

		private Brush PlusBrush;

		private Brush MinusBrush;

		private Open Open;

		private Range Range;

		private double Max;

		private bool Grip;

		private Vector2D op;

		private double Unit;

		private Color PlusColor1;

		private Color PlusColor2;

		private Color MinusColor1;

		private Color MinusColor2;
	}
}
