using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 吹き出し
	{
		public 吹き出し(Are Are, bool 右, Font Font, double TextSize, string Text, Color TextColor, Color ShadColor, Color BackColor, double Speed, bool Dis, Color FeedColor, Action<Tex> Action)
		{
			this.吹出し = new 吹出し(Are.DisUnit);
			this.吹出し.SetHitFalse();
			this.吹出し.右 = 右;
			this.吹出し.吹出しCD.色 = new Color2(ref BackColor, ref Col.Empty);
			this.吹出し.X0Y0_吹出しCP.Setting();
			double num = 1.35;
			double num2 = 0.75;
			this.吹出し.位置C = Dat.Vec2DUnitY * 0.005;
			this.吹出し.尺度B = num * 1.1;
			this.吹出し.尺度YB = num2;
			this.Tex = new Tex("Tex", Dat.Vec2DZero, 0.1, this.吹出し.尺度B, 0.63 * num * num2, Font, TextSize, 25, Text, TextColor, ShadColor, Color.Transparent, Speed, FeedColor, Action);
			this.Tex.Feed.OP.OutlineFalse();
			this.Tex.ParT.BasePointBase = this.Tex.ParT.OP.GetCenter().AddY(0.04);
			this.Dis = Dis;
			if (Dis)
			{
				this.表示 = false;
				int pa = (int)this.吹出し.X0Y0_吹出し.PenColor.A;
				int ba = (int)this.吹出し.X0Y0_吹出し.BrushColor.A;
				int ta = (int)TextColor.A;
				int sa = (int)ShadColor.A;
				Mot mot = new Mot(0.0, 1.0);
				mot.BaseSpeed = 1.0;
				mot.Staing = delegate(Mot m)
				{
				};
				double v;
				mot.Runing = delegate(Mot m)
				{
					v = m.Value.Inverse();
					this.吹出し.X0Y0_吹出し.PenColor = Color.FromArgb((int)((double)pa * v), this.吹出し.X0Y0_吹出し.PenColor);
					this.吹出し.X0Y0_吹出し.BrushColor = Color.FromArgb((int)((double)ba * v), this.吹出し.X0Y0_吹出し.BrushColor);
					this.Tex.ParT.TextColor = Color.FromArgb((int)((double)ta * v), this.Tex.ParT.TextColor);
					this.Tex.ParT.ShadColor = Color.FromArgb((int)((double)sa * v), this.Tex.ParT.ShadColor);
				};
				mot.Reaing = delegate(Mot m)
				{
					m.End();
				};
				mot.Rouing = delegate(Mot m)
				{
				};
				mot.Ending = delegate(Mot m)
				{
					this.表示 = false;
					this.吹出し.X0Y0_吹出し.PenColor = Color.FromArgb(pa, this.吹出し.X0Y0_吹出し.PenColor);
					this.吹出し.X0Y0_吹出し.BrushColor = Color.FromArgb(ba, this.吹出し.X0Y0_吹出し.BrushColor);
					this.Tex.ParT.TextColor = Color.FromArgb(ta, this.Tex.ParT.TextColor);
					this.Tex.ParT.ShadColor = Color.FromArgb(sa, this.Tex.ParT.ShadColor);
				};
				this.消失 = mot;
			}
		}

		public 吹き出し(Are Are, bool 右, Font Font, double TextSize, string Text, Color TextColor, Color ShadColor, Color BackColor, double Speed, bool Dis)
		{
			this.吹出し = new 吹出し(Are.DisUnit);
			this.吹出し.SetHitFalse();
			this.吹出し.右 = 右;
			this.吹出し.吹出しCD.色 = new Color2(ref BackColor, ref Col.Empty);
			this.吹出し.X0Y0_吹出しCP.Setting();
			double num = 1.35;
			double num2 = 0.75;
			this.吹出し.位置C = Dat.Vec2DUnitY * 0.005;
			this.吹出し.尺度B = num * 1.1;
			this.吹出し.尺度YB = num2;
			this.Tex = new Tex("Tex", Dat.Vec2DZero, 0.1, this.吹出し.尺度B, 0.63 * num * num2, Font, TextSize, 25, Text, TextColor, ShadColor, Color.Transparent, Speed);
			this.Tex.ParT.BasePointBase = this.Tex.ParT.OP.GetCenter().AddY(0.04);
			this.Dis = Dis;
			if (Dis)
			{
				this.表示 = false;
				int pa = (int)this.吹出し.X0Y0_吹出し.PenColor.A;
				int ba = (int)this.吹出し.X0Y0_吹出し.BrushColor.A;
				int ta = (int)TextColor.A;
				int sa = (int)ShadColor.A;
				Mot mot = new Mot(0.0, 1.0);
				mot.BaseSpeed = 1.0;
				mot.Staing = delegate(Mot m)
				{
				};
				double v;
				mot.Runing = delegate(Mot m)
				{
					v = m.Value.Inverse();
					this.吹出し.X0Y0_吹出し.PenColor = Color.FromArgb((int)((double)pa * v), this.吹出し.X0Y0_吹出し.PenColor);
					this.吹出し.X0Y0_吹出し.BrushColor = Color.FromArgb((int)((double)ba * v), this.吹出し.X0Y0_吹出し.BrushColor);
					this.Tex.ParT.TextColor = Color.FromArgb((int)((double)ta * v), this.Tex.ParT.TextColor);
					this.Tex.ParT.ShadColor = Color.FromArgb((int)((double)sa * v), this.Tex.ParT.ShadColor);
				};
				mot.Reaing = delegate(Mot m)
				{
					m.End();
				};
				mot.Rouing = delegate(Mot m)
				{
				};
				mot.Ending = delegate(Mot m)
				{
					this.表示 = false;
					this.吹出し.X0Y0_吹出し.PenColor = Color.FromArgb(pa, this.吹出し.X0Y0_吹出し.PenColor);
					this.吹出し.X0Y0_吹出し.BrushColor = Color.FromArgb(ba, this.吹出し.X0Y0_吹出し.BrushColor);
					this.Tex.ParT.TextColor = Color.FromArgb(ta, this.Tex.ParT.TextColor);
					this.Tex.ParT.ShadColor = Color.FromArgb(sa, this.Tex.ParT.ShadColor);
				};
				this.消失 = mot;
			}
		}

		public Color GetHitColor
		{
			get
			{
				return this.Tex.ParT.HitColor;
			}
		}

		public void SetHitColor(Med Med)
		{
			this.Tex.SetHitColor(Med);
		}

		public string Text
		{
			get
			{
				return this.Tex.Text;
			}
			set
			{
				this.表示 = true;
				if (this.Dis)
				{
					Action <>9__1;
					this.Tex.Done = delegate(Tex t)
					{
						TaskFactory factory = Task.Factory;
						Action action;
						if ((action = <>9__1) == null)
						{
							action = (<>9__1 = delegate()
							{
								Thread.Sleep(value.Length * 125);
								this.消失.Sta();
							});
						}
						factory.StartNew(action);
					};
				}
				this.Tex.Text = value;
			}
		}

		public double Speed
		{
			get
			{
				return this.Tex.Speed;
			}
			set
			{
				this.Tex.Speed = value;
			}
		}

		public void 接続(JointS 接続元)
		{
			this.吹出し.接続(接続元);
			this.接続();
		}

		public void Down(Color HitColor)
		{
			this.Tex.Down(ref HitColor);
		}

		public void Down(ref Color HitColor)
		{
			this.Tex.Down(ref HitColor);
		}

		public void Up(Color HitColor)
		{
			this.Tex.Up(ref HitColor);
		}

		public void Up(ref Color HitColor)
		{
			this.Tex.Up(ref HitColor);
		}

		public void 接続()
		{
			this.吹出し.接続P();
			this.Tex.Position = this.吹出し.X0Y0_吹出し.ToGlobal(this.吹出し.X0Y0_吹出し.JP[0].Joint);
		}

		public void Draw(Are Are, FPS FPS)
		{
			this.Tex.Progression(FPS);
			if (this.Dis)
			{
				this.消失.GetValue(FPS);
			}
			if (this.表示)
			{
				this.吹出し.本体.Draw(Are);
				Are.Draw(this.Tex.Pars);
			}
		}

		public void Dispose()
		{
			this.吹出し.Dispose();
			this.Tex.Dispose();
		}

		public bool 表示 = true;

		public 吹出し 吹出し;

		public Tex Tex;

		public bool Dis;

		public Mot 消失;
	}
}
