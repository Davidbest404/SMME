using System;
using System.Drawing;
using System.IO;
using System.Linq;

namespace _2DGAMELIB
{
	public class Tex
	{
		public Pars Pars
		{
			get
			{
				return this.pars;
			}
		}

		public ParT ParT
		{
			get
			{
				return this.parT;
			}
		}

		public Par Feed
		{
			get
			{
				return this.feed;
			}
		}

		public string TextIm
		{
			get
			{
				return this.text.Substring(this.Space, this.text.Length - this.Space);
			}
			set
			{
				if (this.feed != null)
				{
					this.a0 = this.feed.BrushColor.A;
					this.a1 = this.feed.PenColor.A;
					this.feed.BrushColor = Color.FromArgb(0, this.feed.BrushColor);
					this.feed.PenColor = Color.FromArgb(0, this.feed.PenColor);
				}
				this.text = new string(' ', this.Space) + value;
				this.Max = this.text.Length;
				this.Count = (double)this.Max;
				this.f1 = false;
				if (this.parT != null)
				{
					this.parT.Text = this.text;
				}
			}
		}

		public string Text
		{
			get
			{
				return this.text.Substring(this.Space, this.text.Length - this.Space);
			}
			set
			{
				if (this.feed != null)
				{
					this.a0 = this.feed.BrushColor.A;
					this.a1 = this.feed.PenColor.A;
					this.feed.BrushColor = Color.FromArgb(0, this.feed.BrushColor);
					this.feed.PenColor = Color.FromArgb(0, this.feed.PenColor);
				}
				this.text = new string(' ', this.Space) + value;
				this.Max = this.text.Length;
				this.Count = (double)this.Space;
				this.f1 = false;
			}
		}

		public double Speed
		{
			get
			{
				return this.ConV.Speed;
			}
			set
			{
				this.ConV.Speed = value;
				this.speed = value;
			}
		}

		public Vector2D Position
		{
			get
			{
				return this.parT.PositionBase;
			}
			set
			{
				this.parT.PositionBase = value;
				if (this.feed != null)
				{
					this.feed.PositionBase = this.parT.ToGlobal(this.parT.OP[0].ps[2] * 0.95);
				}
			}
		}

		public bool IsPlaing
		{
			get
			{
				return !this.f1;
			}
		}

		public Tex(string Name, ref Vector2D Position, double Size, double Width, double Height, Font Font, double TextSize, int Space, string Text, ref Color TextColor, ref Color ShadColor, ref Color BackColor, double Speed, ref Color FeedColor, Action<Tex> Action)
		{
			try
			{
				if (!File.Exists(this.ConfigPath))
				{
					this.Speed = Speed;
					this.speed = Speed;
				}
				else
				{
					string[] source = this.ConfigPath.ReadLines();
					this.FastText = (source.First((string s) => s.StartsWith("FastText:")).Last<char>() == '1');
				}
			}
			catch
			{
				this.Speed = Speed;
				this.speed = Speed;
			}
			if (this.FastText)
			{
				this.Speed = 50.0;
				this.speed = 50.0;
			}
			else
			{
				this.Speed = Speed;
				this.speed = Speed;
			}
			this.Space = Space;
			this.Text = Text;
			this.Action = Action;
			this.SetParT(Name, ref Position, Size, Width, Height, Font, TextSize, Text, ref TextColor, ref ShadColor, ref BackColor);
			this.SetFeed(Name, Size, ref FeedColor);
			this.mv = new MotV(0.0, 255.0);
			this.mv.BaseSpeed = 2.0;
		}

		public Tex(string Name, Vector2D Position, double Size, double Width, double Height, Font Font, double TextSize, int Space, string Text, Color TextColor, Color ShadColor, Color BackColor, double Speed, Color FeedColor, Action<Tex> Action)
		{
			try
			{
				if (!File.Exists(this.ConfigPath))
				{
					this.Speed = Speed;
					this.speed = Speed;
				}
				else
				{
					string[] source = this.ConfigPath.ReadLines();
					this.FastText = (source.First((string s) => s.StartsWith("FastText:")).Last<char>() == '1');
				}
			}
			catch
			{
				this.Speed = Speed;
				this.speed = Speed;
			}
			if (this.FastText)
			{
				this.Speed = 50.0;
				this.speed = 50.0;
			}
			else
			{
				this.Speed = Speed;
				this.speed = Speed;
			}
			this.Space = Space;
			this.Text = Text;
			this.Action = Action;
			this.SetParT(Name, ref Position, Size, Width, Height, Font, TextSize, Text, ref TextColor, ref ShadColor, ref BackColor);
			this.SetFeed(Name, Size, ref FeedColor);
			this.mv = new MotV(0.0, 255.0);
			this.mv.BaseSpeed = 2.0;
		}

		public Tex(string Name, ref Vector2D Position, double Size, double Width, double Height, Font Font, double TextSize, int Space, string Text, ref Color TextColor, ref Color ShadColor, ref Color BackColor, double Speed)
		{
			try
			{
				if (!File.Exists(this.ConfigPath))
				{
					this.Speed = Speed;
					this.speed = Speed;
				}
				else
				{
					string[] source = this.ConfigPath.ReadLines();
					this.FastText = (source.First((string s) => s.StartsWith("FastText:")).Last<char>() == '1');
				}
			}
			catch
			{
				this.Speed = Speed;
				this.speed = Speed;
			}
			if (this.FastText)
			{
				this.Speed = 50.0;
				this.speed = 50.0;
			}
			else
			{
				this.Speed = Speed;
				this.speed = Speed;
			}
			this.Space = Space;
			this.Text = Text;
			this.SetParT(Name, ref Position, Size, Width, Height, Font, TextSize, Text, ref TextColor, ref ShadColor, ref BackColor);
		}

		public Tex(string Name, Vector2D Position, double Size, double Width, double Height, Font Font, double TextSize, int Space, string Text, Color TextColor, Color ShadColor, Color BackColor, double Speed)
		{
			try
			{
				if (!File.Exists(this.ConfigPath))
				{
					this.Speed = Speed;
					this.speed = Speed;
				}
				else
				{
					string[] source = this.ConfigPath.ReadLines();
					this.FastText = (source.First((string s) => s.StartsWith("FastText:")).Last<char>() == '1');
				}
			}
			catch
			{
				this.Speed = Speed;
				this.speed = Speed;
			}
			if (this.FastText)
			{
				this.Speed = 50.0;
				this.speed = 50.0;
			}
			else
			{
				this.Speed = Speed;
				this.speed = Speed;
			}
			this.Space = Space;
			this.Text = Text;
			this.SetParT(Name, ref Position, Size, Width, Height, Font, TextSize, Text, ref TextColor, ref ShadColor, ref BackColor);
		}

		private void SetParT(string Name, ref Vector2D Position, double Size, double Width, double Height, Font Font, double TextSize, string Text, ref Color TextColor, ref Color ShadColor, ref Color BackColor)
		{
			this.pars = new Pars();
			Out[] array = new Out[]
			{
				Shas.Get正方形()
			};
			array.OutlineFalse();
			this.parT = new ParT
			{
				Tag = Name,
				InitializeOP = array,
				PositionBase = Position,
				SizeBase = Size,
				Closed = true,
				BrushColor = BackColor,
				Font = Font,
				FontSize = TextSize,
				TextColor = TextColor,
				RectSize = new Vector2D(Width, Height),
				Text = Text
			};
			this.ParT.OP.ScalingX(this.ParT.BasePointBase, Width);
			this.ParT.OP.ScalingY(this.ParT.BasePointBase, Height);
			if (ShadColor != Color.Empty)
			{
				this.parT.ShadBrush = new SolidBrush(ShadColor);
			}
			this.pars.Add(this.parT.Tag, this.parT);
		}

		private void SetFeed(string Name, double Size, ref Color FeedColor)
		{
			Out[] array = new Out[]
			{
				Shas.Get三角形()
			};
			this.feed = new Par
			{
				Tag = Name + "_Feed",
				InitializeOP = array,
				BasePointBase = array.GetCenter(),
				PositionBase = this.parT.ToGlobal(this.parT.OP[0].ps[2] * 0.96),
				SizeBase = Size * 0.07,
				SizeYBase = 0.9,
				Closed = true,
				PenColor = Color.FromArgb(0, Color.Black),
				BrushColor = Color.FromArgb(0, FeedColor),
				Hit = false
			};
			this.feed.OP.ReverseY(this.feed.BasePointBase);
			this.pars.Add(this.feed.Tag, this.feed);
		}

		public void SetHitColor(Med Med)
		{
			if (this.parT.HitColor != Color.Transparent)
			{
				Med.RemUniqueColor(this.parT.HitColor);
			}
			this.parT.HitColor = Med.GetUniqueColor();
		}

		public void Progression(FPS FPS)
		{
			if (!this.f1)
			{
				this.Count += this.ConV.GetValue(FPS);
				int num = (int)this.Count;
				if (num <= this.Max)
				{
					this.parT.Text = this.text.Substring(0, num);
					return;
				}
				this.parT.Text = this.text;
				this.f1 = true;
				if (this.feed != null)
				{
					this.feed.BrushColor = Color.FromArgb((int)this.a0, this.feed.BrushColor);
					this.feed.PenColor = Color.FromArgb((int)this.a1, this.feed.PenColor);
				}
				if (this.Done != null)
				{
					this.Done(this);
					this.Done = null;
					return;
				}
			}
			else if (this.feed != null && this.feed.Dra)
			{
				this.mv.GetValue(FPS);
				this.feed.BrushColor = Color.FromArgb((int)this.mv.Value, this.feed.BrushColor);
				this.feed.PenColor = Color.FromArgb((int)this.feed.BrushColor.A, this.feed.PenColor);
			}
		}

		public bool Down(ref Color HitColor)
		{
			if (this.parT.HitColor == HitColor)
			{
				this.f2 = true;
				if (!this.f1 && this.Speed == this.speed)
				{
					this.ConV.Speed *= 10.0;
					return true;
				}
			}
			return false;
		}

		public bool Up(ref Color HitColor)
		{
			if (this.f1 && this.f2 && this.parT.HitColor == HitColor && this.Speed == this.speed)
			{
				this.f1 = false;
				this.f2 = false;
				if (this.feed != null)
				{
					this.feed.BrushColor = Color.FromArgb(0, this.feed.BrushColor);
					this.feed.PenColor = Color.FromArgb((int)this.feed.BrushColor.A, this.feed.PenColor);
					this.mv.ResetValue();
				}
				this.Action(this);
				return true;
			}
			this.Speed = this.speed;
			this.f2 = false;
			return false;
		}

		public void Dispose()
		{
			this.pars.Dispose();
		}

		private Pars pars;

		private ParT parT;

		private Par feed;

		public int Space;

		private string text;

		private ConV ConV = new ConV();

		private Action<Tex> Action = delegate(Tex p)
		{
		};

		private MotV mv;

		private double speed;

		private bool f1;

		private bool f2;

		private double Count;

		private int Max;

		public Action<Tex> Done;

		private byte a0;

		private byte a1;

		private string ConfigPath = Directory.GetCurrentDirectory() + "\\Config.ini";

		private bool FastText;
	}
}
