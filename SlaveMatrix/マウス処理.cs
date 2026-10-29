using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class マウス処理 : 処理B
	{
		public void 吸引()
		{
			this.調教UI.擬音キュ\u30FC.Enqueue(delegate(Are a)
			{
				this.調教UI.擬音.Sound(a, this.対象.Ele.位置.GetAreaPoint(0.01), Sta.吸引.GetVal(1.0, OthN.XS.NextDouble()), new Font("MS Gothic", 1f), Col.Black, 0.2, true);
			});
		}

		public bool Isモ\u30FCド
		{
			get
			{
				return this.Is吸付 || this.Is舐め || this.調教UI.マウス挿入.Is挿入;
			}
		}

		private void オ\u30FCバ\u30FC時(string str, ref 接触D cd)
		{
			if (Sta.GameData.ガイド)
			{
				this.ip.SubInfoIm = (this.調教UI.IsHitCha(ref cd) ? string.Concat(new string[]
				{
					str,
					"LDo:",
					tex.吸引,
					"\r\nWh:",
					tex.舐る,
					"\r\n"
				}) : this.si());
			}
		}

		private void 吸引時(string str)
		{
			if (Sta.GameData.ガイド)
			{
				this.ip.SubInfoIm = str + "LUp:" + tex.開放;
			}
		}

		private string si()
		{
			if (!this.Isモ\u30FCド)
			{
				return "MCl:" + tex.ハンド切替 + "\r\n" + (this.調教UI.ペニス挿入.挿抜モ\u30FCション.Run ? "" : ("RCl:" + tex.ペニス切替));
			}
			return "";
		}

		public void 舐め解除(ref 接触D cd)
		{
			this.調教UI.Action(cd.c, アクション情報.舐り, タイミング情報.終了, アイテム情報.マウス, 0, 1, false, false);
			Act.奴体力消費小();
			Act.主精力消費小();
			this.Is舐め = false;
			this.調教UI.放し();
		}

		public void Move(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref 接触D cd)
		{
			if (this.調教UI.Focus == this.対象)
			{
				this.v = Cursor.Position.ToVector2D();
				this.x = (this.o.X - this.v.X) * 0.008;
				if (this.Isモ\u30FCド)
				{
					if (this.Is吸付)
					{
						Cursor.Position = this.Med.BaseControlC.PointToScreen(this.Med.FromBasePosition(this.対象.Ele.位置));
					}
					else if (this.Is舐め)
					{
						if (cd.e == null)
						{
							this.舐め解除(ref cd);
						}
						else if (Sta.GameData.ガイド)
						{
							this.ip.SubInfoIm = "Wh:" + tex.舐る;
						}
					}
					else
					{
						this.調教UI.マウス挿入.Move(ref mb, ref cp, ref hc, ref cd);
					}
				}
				else if (cd.c == 接触.乳)
				{
					this.調教UI.マウス.Xi = 0;
					this.調教UI.Set_乳首(this.対象.Ele, cd.e.右);
					this.箇所 = cd;
					this.オ\u30FCバ\u30FC時(tex.乳首 + "\r\n", ref cd);
				}
				else if (cd.c == 接触.核)
				{
					this.調教UI.マウス.Xi = 0;
					this.調教UI.Set_陰核(this.対象.Ele);
					this.箇所 = cd;
					this.オ\u30FCバ\u30FC時(tex.陰核 + "\r\n", ref cd);
				}
				else if (Act.フェラ1 && cd.c == 接触.口)
				{
					this.箇所 = cd;
					this.対象.Ele.濃度 = 0.5;
					this.調教UI.マウス.Xi = 4;
					this.調教UI.マウス挿入.Move(ref mb, ref cp, ref hc, ref cd);
				}
				else if (cd.c == 接触.膣)
				{
					this.箇所 = cd;
					this.調教UI.マウス.Xi = 4;
					this.調教UI.マウス挿入.Move(ref mb, ref cp, ref hc, ref cd);
				}
				else if (cd.c == 接触.肛)
				{
					this.箇所 = cd;
					this.調教UI.マウス.Xi = 4;
					this.調教UI.マウス挿入.Move(ref mb, ref cp, ref hc, ref cd);
				}
				else if (cd.c == 接触.糸)
				{
					this.箇所 = cd;
					this.調教UI.マウス.Xi = 4;
					this.調教UI.マウス挿入.Move(ref mb, ref cp, ref hc, ref cd);
				}
				else
				{
					this.調教UI.マウス.Xi = 0;
					this.調教UI.マウス.Yi = 0;
					this.調教UI.放し();
					if (this.調教UI.X >= cp.X || cp.Y >= this.調教UI.Y)
					{
						this.対象.Ele.濃度 = 1.0;
					}
					this.オ\u30FCバ\u30FC時("", ref cd);
				}
				this.o = this.v;
			}
		}

		public void Down(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref 接触D cd)
		{
			if (this.調教UI.Focus == this.対象)
			{
				if (mb == MouseButtons.Left)
				{
					if (!this.調教UI.マウス挿入.Is挿入 && this.調教UI.マウス.Xi != 4 && this.調教UI.IsHitCha(ref cd))
					{
						this.舐め解除(ref cd);
						this.調教UI.マウス.Xi = 1;
						this.Is吸付 = true;
						this.箇所 = cd;
						if (cd.c == 接触.乳)
						{
							this.調教UI.Set_乳首(this.対象.Ele, cd.e.右);
							this.吸引時(tex.乳首 + "\r\n");
							this.調教UI.乳首演出();
						}
						else if (cd.c == 接触.核)
						{
							this.調教UI.Set_陰核(this.対象.Ele);
							this.吸引時(tex.陰核 + "\r\n");
							this.調教UI.陰核演出();
						}
						else if (cd.c == 接触.口)
						{
							this.対象.Ele.濃度 = 0.5;
							this.対象.Ele.角度C = (double)OthN.XS.NextSign() * 45.0;
							this.調教UI.Set_口(this.対象.Ele);
							this.吸引時(tex.口腔 + "\r\n");
							this.調教UI.口腔演出();
						}
						else if (cd.c == 接触.膣)
						{
							this.調教UI.Set_膣口(this.対象.Ele);
							this.吸引時(tex.膣腔 + "\r\n");
							this.調教UI.膣腔演出();
						}
						else if (cd.c == 接触.肛)
						{
							this.調教UI.Set_肛門(this.対象.Ele);
							this.吸引時(tex.肛門 + "\r\n");
							this.調教UI.肛門演出();
						}
						else if (cd.c == 接触.糸)
						{
							this.調教UI.Set_出糸(this.対象.Ele);
							this.吸引時(tex.出糸 + "\r\n");
							this.調教UI.出糸演出();
						}
						else
						{
							this.吸引時("");
						}
						this.調教UI.Action(this.箇所.c, アクション情報.吸引, タイミング情報.開始, アイテム情報.マウス, 0, 1, false, false);
						Act.奴体力消費小();
						Act.主精力消費小();
						this.キスモ\u30FCション.Sta();
						return;
					}
					this.調教UI.マウス挿入.Down(ref mb, ref cp, ref hc, ref cd);
					return;
				}
				else if (mb == MouseButtons.Right)
				{
					if (!this.Isモ\u30FCド && !this.調教UI.ペニス挿入.Is挿入)
					{
						this.調教UI.Focus.Ele.濃度 = 0.5;
						this.調教UI.Focus = this.調教UI.ペニスCM;
						this.調教UI.ペニスCM.Ele.位置B = cp;
						this.調教UI.ペニス処理.選択 = true;
						this.調教UI.ペニス処理.Move(ref mb, ref cp, ref hc, ref cd);
						return;
					}
				}
				else if (mb == MouseButtons.Middle && !this.Isモ\u30FCド && !this.調教UI.ハンド挿入.Is挿入)
				{
					if (this.切り替え)
					{
						this.切り替え = false;
						return;
					}
					this.調教UI.Focus.Ele.濃度 = 0.5;
					this.調教UI.Focus = this.調教UI.ハンド右CM;
					this.調教UI.ハンド右.位置B = cp;
					this.調教UI.ハンド処理.切り替え = true;
					this.調教UI.ハンド処理.Move(ref mb, ref cp, ref hc, ref cd);
				}
			}
		}

		public void Up(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref 接触D cd)
		{
			if (this.調教UI.Focus == this.対象 && mb == MouseButtons.Left && this.Is吸付)
			{
				this.調教UI.Action(this.箇所.c, アクション情報.吸引, タイミング情報.終了, アイテム情報.マウス, 0, 1, false, false);
				Act.奴体力消費小();
				Act.主精力消費小();
				this.調教UI.マウス.Xi = 0;
				this.Is吸付 = false;
				this.キスモ\u30FCション.End();
				this.対象.Ele.濃度 = 1.0;
				this.対象.Ele.角度C = 0.0;
				this.調教UI.放し();
				if (cd.c == 接触.口)
				{
					this.オ\u30FCバ\u30FC時(tex.口腔 + "\r\n", ref cd);
					return;
				}
				if (cd.c == 接触.乳)
				{
					this.オ\u30FCバ\u30FC時(tex.乳首 + "\r\n", ref cd);
					return;
				}
				if (cd.c == 接触.核)
				{
					this.オ\u30FCバ\u30FC時(tex.陰核 + "\r\n", ref cd);
					return;
				}
				if (cd.c == 接触.膣)
				{
					this.オ\u30FCバ\u30FC時(tex.膣腔 + "\r\n", ref cd);
					return;
				}
				if (cd.c == 接触.肛)
				{
					this.オ\u30FCバ\u30FC時(tex.肛門 + "\r\n", ref cd);
					return;
				}
				this.オ\u30FCバ\u30FC時("", ref cd);
			}
		}

		public void Leave(ref MouseButtons mb, ref Vector2D cp, ref Color hc)
		{
		}

		public void Wheel(ref MouseButtons mb, ref Vector2D cp, ref int dt, ref Color hc, ref 接触D cd)
		{
			if (this.調教UI.Focus == this.対象 && !this.Is吸付 && !this.調教UI.マウス挿入.Is挿入 && this.調教UI.IsHitCha(ref cd))
			{
				if (!this.Is舐め)
				{
					this.調教UI.Action(cd.c, アクション情報.舐り, タイミング情報.開始, アイテム情報.マウス, 0, 1, false, false);
					Act.奴体力消費小();
					Act.主精力消費小();
				}
				else
				{
					this.調教UI.Action(cd.c, アクション情報.舐り, タイミング情報.継続, アイテム情報.マウス, 0, 1, false, false);
					Act.奴体力消費小();
					Act.主精力消費小();
				}
				this.Is舐め = true;
				if (this.調教UI.IsHitCha(ref cd))
				{
					this.調教UI.押し(ref cd);
				}
				this.調教UI.マウス.Xi = 3;
				this.調教UI.マウス.Yi = (this.調教UI.マウス.Yi - dt.Sign() * 2).LimitM(0, this.調教UI.マウス.本体.CountY);
				if (cd.c == 接触.口)
				{
					this.対象.Ele.濃度 = 0.5;
				}
			}
		}

		public マウス処理(調教UI 調教UI, CM マウス)
		{
			マウス処理.<>c__DisplayClass20_0 CS$<>8__locals1 = new マウス処理.<>c__DisplayClass20_0();
			CS$<>8__locals1.調教UI = 調教UI;
			base..ctor(CS$<>8__locals1.調教UI, マウス);
			CS$<>8__locals1.<>4__this = this;
			double d = 0.0;
			double s = 0.0;
			bool f = true;
			Stopwatch sw = new Stopwatch();
			キスマ\u30FCク k = null;
			Mot mot = new Mot(0.0, 0.15);
			mot.BaseSpeed = 4.0;
			mot.Staing = delegate(Mot m)
			{
				f = true;
				sw.Restart();
				s = 1.09.Reciprocal();
				CS$<>8__locals1.<>4__this.吸引();
			};
			Vector2D cp;
			Color hc;
			mot.Runing = delegate(Mot m)
			{
				if (CS$<>8__locals1.<>4__this.箇所.c == 接触.乳)
				{
					CS$<>8__locals1.調教UI.Set_乳首(CS$<>8__locals1.<>4__this.対象.Ele, CS$<>8__locals1.<>4__this.箇所.e.右);
				}
				else if (CS$<>8__locals1.<>4__this.箇所.c == 接触.核)
				{
					CS$<>8__locals1.調教UI.Set_陰核(CS$<>8__locals1.<>4__this.対象.Ele);
				}
				if (f)
				{
					d = m.Value.Inverse();
					CS$<>8__locals1.<>4__this.対象.Ele.尺度C = s * d;
				}
				CS$<>8__locals1.<>4__this.対象.Ele.位置C = Oth.GetRandomVector() * d * 0.0005;
				CS$<>8__locals1.調教UI.マウス.X2Y0_舌.PositionCont = Oth.GetRandomVector() * d * 0.001;
				if (sw.IsRunning)
				{
					if (sw.ElapsedMilliseconds > 250L)
					{
						cp = CS$<>8__locals1.<>4__this.対象.Ele.位置B;
						hc = CS$<>8__locals1.<>4__this.Med.GetHitColor(CS$<>8__locals1.<>4__this.Med.FromBasePosition(cp));
						k = CS$<>8__locals1.<>4__this.Bod.Addキスマ\u30FCク(cp, hc);
						sw.Stop();
					}
				}
				else if (k != null)
				{
					k.濃度 = (k.濃度 + 0.05).LimitM(0.0, 1.0);
					if (CS$<>8__locals1.<>4__this.Bod.EI胸 != null)
					{
						CS$<>8__locals1.<>4__this.Bod.EI胸.Updatef = true;
					}
					if (CS$<>8__locals1.<>4__this.Bod.EI腕前 != null)
					{
						CS$<>8__locals1.<>4__this.Bod.EI腕前.Updatef = true;
					}
					if (CS$<>8__locals1.<>4__this.Bod.EI腿 != null)
					{
						CS$<>8__locals1.<>4__this.Bod.EI腿.Updatef = true;
					}
				}
				CS$<>8__locals1.調教UI.Action(CS$<>8__locals1.<>4__this.箇所.c, アクション情報.吸引, タイミング情報.継続, アイテム情報.マウス, 0, 1, false, false);
				Act.奴体力消費小();
				Act.主精力消費小();
				if (CS$<>8__locals1.<>4__this.Bod.噴乳左.母乳垂れ1_表示 && CS$<>8__locals1.<>4__this.箇所.c == 接触.乳 && CS$<>8__locals1.<>4__this.Cha.噴乳.Run)
				{
					Sta.GameData.精力 = (Sta.GameData.精力 + 0.02 * OthN.XS.NextDouble()).LimitM(0.0, 1.0);
				}
			};
			mot.Reaing = delegate(Mot m)
			{
				f = false;
				d = m.Value.Inverse();
			};
			mot.Rouing = delegate(Mot m)
			{
			};
			mot.Ending = delegate(Mot m)
			{
				m.ResetValue();
				CS$<>8__locals1.<>4__this.対象.Ele.尺度C = 1.0;
				CS$<>8__locals1.<>4__this.対象.Ele.位置C = Dat.Vec2DZero;
				CS$<>8__locals1.調教UI.マウス.X2Y0_舌.PositionCont = Dat.Vec2DZero;
			};
			this.キスモ\u30FCション = mot;
			CS$<>8__locals1.調教UI.Mots.Add(this.キスモ\u30FCション.GetHashCode().ToString(), this.キスモ\u30FCション);
		}

		public void SetCha(Cha Cha)
		{
			this.Cha = Cha;
			this.Bod = Cha.Bod;
		}

		public new void Reset()
		{
			base.Reset();
			this.Is吸付 = false;
			this.Is舐め = false;
			Mot キスモ_u30FCション = this.キスモ\u30FCション;
			if (キスモ_u30FCション != null)
			{
				キスモ_u30FCション.End();
			}
			this.箇所 = default(接触D);
			this.x = 0.0;
			this.v = default(Vector2D);
			this.o = default(Vector2D);
			this.切り替え = false;
		}

		public bool Is吸付;

		public bool Is舐め;

		private Mot キスモ\u30FCション;

		private 接触D 箇所;

		private double x;

		private Vector2D v;

		private Vector2D o;

		public bool 切り替え;
	}
}
