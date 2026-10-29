using System;
using System.Drawing;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 情報パネル
	{
		public 情報パネル(Med Med, Are Are)
		{
			this.Med = Med;
			this.Are = Are;
			double num = 0.015;
			double num2 = 0.1;
			double num3 = Are.LocalWidth * 0.6 / num2;
			double num4 = Are.LocalHeight * 0.16666666666666666 / num2;
			Vector2D vector2D = Are.GetPosition(0.2, 1.0 - num4 * num2 / Are.LocalHeight).AddY(-num);
			double y = 1.01;
			double textSize = 0.08;
			if (Sta.BigWindow && !Sta.NoScaling)
			{
				textSize = 0.105;
			}
			this.MaiB = new Par();
			this.MaiB.BasePointBase = Dat.Vec2DZero;
			this.MaiB.PositionBase = vector2D;
			this.MaiB.SizeBase = num2;
			this.MaiB.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			this.MaiB.OP.ScalingX(this.MaiB.BasePointBase, num3);
			this.MaiB.OP.ScalingY(this.MaiB.BasePointBase, num4);
			this.MaiB.Closed = true;
			this.MaiB.BrushColor = Color.FromArgb(160, Col.Black);
			this.MaiB.Hit = false;
			this.MaiB.JP.Add(new Joi(this.MaiB.OP.GetCenter()));
			this.Mai = new Tex("Tex1", vector2D, num2, num3 * 0.98, num4 * 0.91, new Font("MS Gothic", 1f), textSize, 0, " ", Col.White, Col.Black, Color.Transparent, 19.0, Col.White, delegate(Tex sp)
			{
				sp.Text = sp.Text;
			});
			this.Mai.ParT.BasePointBase = this.Mai.ParT.OP.GetCenter().MulY(y);
			this.Mai.Position = this.MaiB.ToGlobal(this.MaiB.JP[0].Joint);
			this.Mai.Feed.OP.OutlineFalse();
			double num5 = num4 * 4.53;
			this.Mai2B = new Par();
			this.Mai2B.BasePointBase = Dat.Vec2DZero;
			this.Mai2B.PositionBase = new Vector2D(vector2D.X, 0.01);
			this.Mai2B.SizeBase = num2;
			this.Mai2B.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			this.Mai2B.OP.ScalingX(this.Mai2B.BasePointBase, num3);
			this.Mai2B.OP.ScalingY(this.Mai2B.BasePointBase, num5);
			this.Mai2B.Closed = true;
			this.Mai2B.BrushColor = Color.FromArgb(160, Col.Black);
			this.Mai2B.Hit = false;
			this.Mai2B.JP.Add(new Joi(this.Mai2B.OP.GetCenter()));
			this.Mai2 = new Tex("Tex3", vector2D, num2, num3 * 0.98, num5 * 0.97, new Font("MS Gothic", 1f), textSize, 0, " ", Col.White, Col.Black, Color.Transparent, 19.0, Col.White, delegate(Tex sp)
			{
				sp.Text = sp.Text;
			});
			this.Mai2.ParT.BasePointBase = this.Mai2.ParT.OP.GetCenter().MulY(y);
			this.Mai2.Position = this.Mai2B.ToGlobal(this.Mai2B.JP[0].Joint);
			this.Mai2.Feed.OP.OutlineFalse();
			num3 = Are.LocalWidth * 0.19 / num2;
			vector2D = Are.GetPosition(1.0 - (num3 * num2 / Are.LocalWidth + 0.005), 1.0 - num4 * num2 / Are.LocalHeight).AddY(-num);
			this.SubB = new Par();
			this.SubB.BasePointBase = Dat.Vec2DZero;
			this.SubB.PositionBase = vector2D;
			this.SubB.SizeBase = num2;
			this.SubB.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			this.SubB.OP.ScalingX(this.SubB.BasePointBase, num3);
			this.SubB.OP.ScalingY(this.SubB.BasePointBase, num4);
			this.SubB.Closed = true;
			this.SubB.BrushColor = Color.FromArgb(160, Col.Black);
			this.SubB.Hit = false;
			this.SubB.JP.Add(new Joi(this.SubB.OP.GetCenter()));
			textSize = 0.07;
			if (Sta.BigWindow && !Sta.NoScaling)
			{
				textSize = 0.095;
			}
			this.Sub = new Tex("Tex4", vector2D, num2 * 1.01, num3 * 0.98, num4 * 0.91, new Font("MS Gothic", 1f), textSize, 0, " ", Col.White, Col.Black, Color.Transparent, 15.0);
			this.Sub.ParT.BasePointBase = this.Sub.ParT.OP.GetCenter().MulY(y);
			this.Sub.Position = this.SubB.ToGlobal(this.SubB.JP[0].Joint);
			this.SubInnfo_l = new Lab(Med, Are, "SubInfo", vector2D, num2, 1.0, new Font("MS Gothic", 1f), 0.07, "Sub Info.", Col.White, Col.Black, Color.FromArgb(160, Col.Black), Col.Empty, false);
			this.SubInnfo_l.ParT.PositionBase = this.SubInnfo_l.ParT.PositionBase.AddY(-this.SubInnfo_l.ParT.OP[0].ps[3].Y * this.SubInnfo_l.ParT.SizeBase);
			this.Sub2B = new Par();
			this.Sub2B.BasePointBase = Dat.Vec2DZero;
			this.Sub2B.PositionBase = new Vector2D(0.0025, vector2D.Y);
			this.Sub2B.SizeBase = num2;
			this.Sub2B.OP.AddRange(new Out[]
			{
				Shas.Get正方形()
			});
			this.Sub2B.OP.ScalingX(this.Sub2B.BasePointBase, num3);
			this.Sub2B.OP.ScalingY(this.Sub2B.BasePointBase, num4);
			this.Sub2B.Closed = true;
			this.Sub2B.BrushColor = Color.FromArgb(160, Col.Black);
			this.Sub2B.Hit = false;
			this.Sub2B.JP.Add(new Joi(this.SubB.OP.GetCenter()));
			this.Sub2 = new Tex("Tex3", this.Sub2B.PositionBase, num2 * 1.01, num3 * 0.98, num4 * 0.91, new Font("MS Gothic", 1f), textSize, 0, "", Col.White, Col.Black, Color.Transparent, 15.0);
			this.Sub2.ParT.BasePointBase = this.Sub2.ParT.OP.GetCenter().MulY(y);
			this.Sub2.Position = this.Sub2B.ToGlobal(this.Sub2B.JP[0].Joint);
			double num6 = 0.0;
			int num7 = 1;
			if (Sta.BigWindow && !Sta.NoScaling)
			{
				num6 = 0.2;
				num7 = 0;
			}
			this.yp = new ParT();
			this.yp.Text = "・" + tex.はい;
			this.yp.SizeBase = this.Mai.ParT.SizeBase;
			this.yp.Font = new Font("MS Gothic", 1f);
			this.yp.FontSize = this.Mai.ParT.FontSize;
			this.yp.SetStringRectOutline(Are.Unit, Are.GD);
			this.yp.RectSize = new Vector2D(this.yp.OP[0].ps[1].X + num6, this.yp.OP[0].ps[2].Y);
			this.yp.OP.ScalingY(this.yp.BasePointBase, 0.9);
			this.yp.OP.OutlineFalse();
			this.yp.Closed = true;
			this.yp.TextColor = Col.White;
			this.yp.BrushColor = Color.FromArgb(0, Col.Black);
			this.yp.ShadBrush = new SolidBrush(Col.Black);
			this.yp.StringFormat.Alignment = (StringAlignment)num7;
			this.yp.StringFormat.LineAlignment = (StringAlignment)num7;
			this.yp.PositionBase = new Vector2D(this.MaiB.Position.X + 0.001, this.MaiB.Position.Y);
			this.yp.Dra = false;
			this.yb = new But1(this.yp, delegate(But a)
			{
			});
			this.np = new ParT();
			this.np.Text = "・" + tex.いいえ;
			this.np.SizeBase = this.Mai.ParT.SizeBase;
			this.np.Font = new Font("MS Gothic", 1f);
			this.np.FontSize = this.Mai.ParT.FontSize;
			this.np.SetStringRectOutline(Are.Unit, Are.GD);
			this.np.RectSize = new Vector2D(this.np.OP[0].ps[1].X + num6, this.np.OP[0].ps[2].Y);
			this.np.OP.ScalingY(this.np.BasePointBase, 0.9);
			this.np.OP.OutlineFalse();
			this.np.Closed = true;
			this.np.TextColor = Col.White;
			this.np.BrushColor = Color.FromArgb(0, Col.Black);
			this.np.ShadBrush = new SolidBrush(Col.Black);
			this.np.StringFormat.Alignment = (StringAlignment)num7;
			this.np.StringFormat.LineAlignment = (StringAlignment)num7;
			this.np.PositionBase = new Vector2D(this.MaiB.Position.X + 0.001, this.MaiB.Position.Y);
			this.np.Dra = false;
			this.nb = new But1(this.np, delegate(But a)
			{
			});
		}

		public Color GetHitColor
		{
			get
			{
				return this.Mai.ParT.HitColor;
			}
		}

		public void SetHitColor(Med Med)
		{
			this.Mai.SetHitColor(Med);
			this.Sub.SetHitColor(Med);
			this.SubInnfo_l.SetHitColor(Med);
			this.Mai2.SetHitColor(Med);
			this.Sub2.SetHitColor(Med);
			this.yb.SetHitColor(Med);
			this.nb.SetHitColor(Med);
		}

		public bool IsHit(ref Color hc)
		{
			return this.Mai.ParT.HitColor == hc || this.Sub.ParT.HitColor == hc || this.Mai2.ParT.HitColor == hc || this.Sub2.ParT.HitColor == hc;
		}

		public string TextIm
		{
			get
			{
				return this.Mai.TextIm;
			}
			set
			{
				this.Mai.TextIm = value;
			}
		}

		public string Text
		{
			get
			{
				return this.Mai.Text;
			}
			set
			{
				this.Mai.Text = value;
			}
		}

		public string Mai2Im
		{
			get
			{
				return this.Mai2.TextIm;
			}
			set
			{
				this.Mai2.TextIm = value;
			}
		}

		public string SubInfoIm
		{
			get
			{
				return this.Sub.TextIm;
			}
			set
			{
				this.Sub.TextIm = value;
			}
		}

		public string SubInfo
		{
			get
			{
				return this.Sub.Text;
			}
			set
			{
				this.Sub.Text = value;
			}
		}

		public string Sub2Im
		{
			get
			{
				return this.Sub2.TextIm;
			}
			set
			{
				this.Sub2.TextIm = value;
			}
		}

		public void UpdateSub2()
		{
			this.Sub2.TextIm = string.Concat(new object[]
			{
				tex.所持金,
				"\r\n",
				Sta.GameData.所持金.ToString("#,0"),
				"\r\n",
				tex.借金,
				"\r\n",
				Sta.GameData.借金.ToString("#,0"),
				"\r\n",
				Sta.GameData.日数,
				tex.日目,
				"/",
				Sta.GameData.時間帯
			});
		}

		public double Speed
		{
			get
			{
				return this.Mai.Speed;
			}
			set
			{
				this.Mai.Speed = value;
			}
		}

		public double SubSpeed
		{
			get
			{
				return this.Sub.Speed;
			}
			set
			{
				this.Sub.Speed = value;
			}
		}

		public bool 選択肢表示
		{
			get
			{
				return this.yp.Dra;
			}
			set
			{
				this.SetButPos();
				this.yp.Dra = value;
				this.np.Dra = value;
			}
		}

		public Action<But> 選択yAct
		{
			set
			{
				this.yb.Action = delegate(But a)
				{
					value(a);
				};
			}
		}

		public Action<But> 選択nAct
		{
			set
			{
				this.nb.Action = delegate(But a)
				{
					value(a);
				};
			}
		}

		private void SetButPos()
		{
			this.yp.PositionBase = new Vector2D(this.yp.PositionBase.X, this.Mai.ParT.ToGlobal(this.Mai.ParT.GetStringRect(this.Are.Unit, this.Are.GD).v2).Y + 0.0025);
			this.np.PositionBase = new Vector2D(this.np.PositionBase.X, this.yp.ToGlobal(this.yp.OP.Last<Out>().ps.Last<Vector2D>()).Y + 0.0025);
		}

		public void Move(ref Color HitColor)
		{
			this.yb.Move(ref HitColor);
			this.nb.Move(ref HitColor);
		}

		public void Down(ref Color HitColor)
		{
			this.Sub.Down(ref HitColor);
			this.yb.Down(ref HitColor);
			this.nb.Down(ref HitColor);
		}

		public void DownB(ref Color HitColor)
		{
			this.yb.Down(ref HitColor);
			this.nb.Down(ref HitColor);
		}

		public void Up(ref Color HitColor)
		{
			this.Sub.Up(ref HitColor);
			this.yb.Up(ref HitColor);
			this.nb.Up(ref HitColor);
		}

		public void Draw(Are Are, FPS FPS)
		{
			if (this.MaiShow)
			{
				Are.Draw(this.MaiB);
				this.Mai.Progression(FPS);
				Are.Draw(this.Mai.Pars);
			}
			if (this.Mai2Show)
			{
				Are.Draw(this.Mai2B);
				Are.Draw(this.Mai2.Pars);
			}
			if (this.SubShow)
			{
				Are.Draw(this.SubB);
				this.Sub.Progression(FPS);
				Are.Draw(this.Sub.Pars);
				Are.Draw(this.SubInnfo_l.ParT);
			}
			if (this.Sub2Show)
			{
				Are.Draw(this.Sub2B);
				Are.Draw(this.Sub2.Pars);
			}
			if (this.yp.Dra)
			{
				Are.Draw(this.yp);
			}
			if (this.np.Dra)
			{
				Are.Draw(this.np);
			}
		}

		public void Dispose()
		{
			this.MaiB.Dispose();
			this.Mai.Dispose();
			this.Mai2B.Dispose();
			this.Mai2.Dispose();
			this.SubB.Dispose();
			this.Sub.Dispose();
			this.SubInnfo_l.Dispose();
			this.Sub2B.Dispose();
			this.Sub2.Dispose();
		}

		public Are Are;

		private Med Med;

		public Par MaiB;

		public Tex Mai;

		public Par Mai2B;

		public Tex Mai2;

		public Par SubB;

		public Tex Sub;

		public Par Sub2B;

		public Tex Sub2;

		private Lab SubInnfo_l;

		public bool MaiShow = true;

		public bool Mai2Show = true;

		public bool SubShow = true;

		public bool Sub2Show = true;

		private ParT yp;

		private ParT np;

		public But1 yb;

		public But1 nb;
	}
}
