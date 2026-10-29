using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class ペニス処理 : 処理B
	{
		public void 射精_()
		{
			this.調教UI.擬音キュ\u30FC.Enqueue(delegate(Are a)
			{
				this.調教UI.擬音.Sound(a, Sta.GetAreaPoint(ref this.調教UI.ペニス.AreM.Position, 0.02), Sta.射精.GetVal(Act.変化V_射精, 1.0), new Font("MS Gothic", 1f), Color.White, 0.2 + 0.2 * OthN.XS.NextDouble() * Act.変化V_射精, true);
			});
		}

		public bool Isモ\u30FCド
		{
			get
			{
				return this.Is手コキ || this.Is足コキ || this.Isパイズリ || this.調教UI.ペニス挿入.Is押付 || this.調教UI.ペニス挿入.Is挿入;
			}
		}

		private void パイズリ時()
		{
			if (Sta.GameData.ガイド)
			{
				if (this.Isパイズリ他動)
				{
					this.ip.SubInfoIm = "LDo:" + tex.放す;
					return;
				}
				this.ip.SubInfoIm = "Mo↑↓:" + tex.擦る + "\r\nLUp:" + tex.放す;
			}
		}

		private void 胸オ\u30FCバ\u30FC時()
		{
			if (Sta.GameData.ガイド)
			{
				if (this.Isパイズリ他動)
				{
					this.ip.SubInfoIm = "LDo:" + tex.挟ませる;
					return;
				}
				this.ip.SubInfoIm = "LDo:" + tex.挟む;
			}
		}

		private void コキ時()
		{
			if (Sta.GameData.ガイド)
			{
				this.ip.SubInfoIm = "LDo:" + tex.やめさせる;
			}
		}

		private void 手オ\u30FCバ\u30FC時()
		{
			if (Sta.GameData.ガイド)
			{
				this.ip.SubInfoIm = "LDo:" + tex.手コキ;
			}
		}

		private void 足オ\u30FCバ\u30FC時()
		{
			if (Sta.GameData.ガイド)
			{
				this.ip.SubInfoIm = "LDo:" + tex.足コキ;
			}
		}

		private void 扱き時()
		{
			if (Sta.GameData.ガイド)
			{
				情報パネル ip = this.ip;
				ip.SubInfoIm = ip.SubInfoIm + "\r\nWh:" + tex.扱く;
			}
		}

		private string si()
		{
			if (!this.Isモ\u30FCド)
			{
				return (this.調教UI.マウス挿入.挿抜モ\u30FCション.Run ? "" : ("MCl:" + tex.マウス切替 + "\r\n")) + "RCl:" + tex.ハンド切替;
			}
			return "";
		}

		private bool 持ち手
		{
			get
			{
				return this.調教UI.持ち手;
			}
			set
			{
				this.調教UI.持ち手 = value;
				if (value)
				{
					this.調教UI.ハンド右.Xi = 13;
					this.調教UI.ハンド右.濃度 = this.調教UI.ペニス.濃度;
					this.調教UI.ハンド右.角度C = 0.0;
				}
				else
				{
					this.調教UI.Set持ち手();
					this.調教UI.ハンド右.位置B = this.調教UI.ハンド右CM.bp;
					this.調教UI.ハンド右.濃度 = 0.5;
					this.調教UI.ハンド右.位置C = Dat.Vec2DZero;
					this.調教UI.放し();
				}
				this.調教UI.ハンド右.濃度 = 1.0;
			}
		}

		public void Move(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref 接触D cd)
		{
			if (this.調教UI.Focus == this.対象)
			{
				this.v = Cursor.Position.ToVector2D();
				this.x = (this.o.X - this.v.X) * 0.008;
				this.y = (this.o.Y - this.v.Y) * 0.008;
				if (this.Isモ\u30FCド)
				{
					if (this.調教UI.ペニス挿入.Is挿入)
					{
						this.持ち手 = false;
					}
					if (this.Isパイズリ)
					{
						if (this.Isパイズリ他動)
						{
							this.持ち手 = false;
							this.調教UI.ハンド右.濃度 = 0.5;
						}
						else
						{
							this.Bod.乳房右.接続P();
							this.Bod.乳房左.接続P();
							this.調教UI.ハンド右.位置B = this.Bod.乳房右.位置;
							this.調教UI.ハンド左.位置B = this.Bod.乳房左.位置;
						}
						this.yi = this.Bod.乳房左.Yi;
						this.d = (this.d + this.y).LimitM(0.0, 1.0);
						this.調教UI.ペニス.位置B = this.Bod.胸部位置.AddY(-0.03 * this.d);
						this.Bod.乳房左.Yv = 0.2 + 0.4 * this.d;
						this.Bod.乳房右.Yv = 0.2 + 0.4 * this.d;
						this.vc.Y = -0.002 * this.d;
						this.Bod.胸毛_人.位置C = this.vc;
						this.対象.Ele.角度C = (100.0 * this.x).LimitM(-5.0, 5.0);
						if (this.yi != this.Bod.乳房左.Yi && this.Bod.乳房左.Yi == 1)
						{
							this.Bod.胸左右前後 = !this.Bod.胸左右前後;
						}
						this.パイズリ時();
						this.調教UI.Action(接触.胸, アクション情報.パイ, タイミング情報.継続, アイテム情報.ペニス, 0, 1, false, false);
						Act.奴体力消費小();
						Act.主精力消費小();
					}
					else
					{
						this.調教UI.ペニス挿入.Move(ref mb, ref cp, ref hc, ref cd);
						if (!this.調教UI.ペニス挿入.Is挿入)
						{
							this.挿入箇所 = 接触.none;
						}
					}
				}
				else if (this.Bod.Is胸部())
				{
					this.Isパイズリ他動 = Act.パイズリ1;
					this.胸オ\u30FCバ\u30FC時();
				}
				else if (Act.手コキ && cd.c == 接触.手)
				{
					this.手オ\u30FCバ\u30FC時();
				}
				else if (Act.足コキ && cd.c == 接触.足)
				{
					this.足オ\u30FCバ\u30FC時();
				}
				else
				{
					this.調教UI.ペニス挿入.Move(ref mb, ref cp, ref hc, ref cd);
					if (Sta.GameData.ガイド)
					{
						if (string.IsNullOrWhiteSpace(this.ip.SubInfoIm))
						{
							情報パネル ip = this.ip;
							ip.SubInfoIm += this.si();
						}
						else if (this.ip.SubInfoIm == "LDo:" + tex.押付け)
						{
							this.扱き時();
						}
					}
				}
				this.o = this.v;
			}
		}

		public void Down(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref 接触D cd)
		{
			if (this.調教UI.Focus == this.対象)
			{
				if (!this.選択)
				{
					this.選択 = true;
					return;
				}
				if (mb == MouseButtons.Left)
				{
					if (this.Bod.Is胸部())
					{
						this.手コキ.End();
						this.足コキ.End();
						if (Act.パイズリ2)
						{
							this.パイズリ.Sta();
						}
						this.Isパイズリ相互 = (Act.パイズリ3 && OthN.XS.NextBool());
						this.Isパイズリ = true;
						this.調教UI.ペニス.位置B = this.Bod.胸部位置;
						this.d = 0.0;
						this.Bod.乳房左.Yi = 1;
						this.Bod.乳房右.Yi = 1;
						if (this.Isパイズリ他動)
						{
							this.持ち手 = true;
							if (this.調教UI.押し状態)
							{
								this.調教UI.ハンド右.位置C = new Vector2D(0.0, 0.02);
							}
							else
							{
								this.調教UI.ハンド右.位置C = new Vector2D(0.0, 0.021800000000000003);
							}
							this.Cha.両腕_人_パイズリ(0, false, false);
							if (this.Bod.Is腕前)
							{
								this.Bod.EI腕前.Updatef = true;
							}
						}
						else
						{
							this.持ち手 = false;
							this.Bod.乳房右.接続P();
							this.Bod.乳房左.接続P();
							this.調教UI.ハンド右.位置B = this.Bod.乳房右.位置;
							this.調教UI.ハンド左.位置B = this.Bod.乳房左.位置;
							this.調教UI.ハンド右.位置C = new Vector2D(0.011, 0.001);
							this.調教UI.ハンド左.位置C = new Vector2D(-0.011, 0.001);
							this.調教UI.ハンド右.Xi = 4;
							this.調教UI.ハンド左.Xi = 4;
							this.調教UI.ハンド右CM.使用状態 = 使用状態.使用;
							this.調教UI.ハンド右.濃度 = 1.0;
							this.調教UI.ハンド左表示 = true;
							this.調教UI.押し(ref cd);
							this.調教UI.腕修正();
						}
						this.パイズリ時();
						this.調教UI.Action(接触.胸, アクション情報.パイ, タイミング情報.開始, アイテム情報.ペニス, 0, 1, false, false);
						Act.奴体力消費小();
						Act.主精力消費小();
						this.調教UI.乳房演出();
						this.調教UI.脚修正();
						return;
					}
					if (!this.手コキ.Run && Act.手コキ && cd.c == 接触.手)
					{
						this.パイズリ.End();
						this.足コキ.End();
						this.Is手コキ = true;
						this.調教UI.腕修正();
						this.手コキ左 = !cd.e.右;
						this.手コキ.Sta();
						this.コキ時();
						this.調教UI.脚修正();
						return;
					}
					if (this.手コキ.Run)
					{
						this.手コキ.End();
						this.Is手コキ = false;
						return;
					}
					if (!this.足コキ.Run && Act.足コキ && cd.c == 接触.足)
					{
						this.パイズリ.End();
						this.手コキ.End();
						this.Is足コキ = true;
						this.足コキ.Sta();
						this.コキ時();
						return;
					}
					if (this.足コキ.Run)
					{
						this.足コキ.End();
						this.Is足コキ = false;
						return;
					}
					if (!this.調教UI.ペニス挿入.Is挿入)
					{
						this.持ち手 = true;
						if (this.調教UI.押し状態)
						{
							this.調教UI.ハンド右.位置C = new Vector2D(0.0, 0.02);
						}
						else
						{
							this.調教UI.ハンド右.位置C = new Vector2D(0.0, 0.021800000000000003);
						}
					}
					this.調教UI.ペニス挿入.Down(ref mb, ref cp, ref hc, ref cd);
					if (this.調教UI.ペニス挿入.Is口)
					{
						this.挿入箇所 = 接触.口;
						return;
					}
					if (this.調教UI.ペニス挿入.Is膣)
					{
						this.挿入箇所 = 接触.膣;
						return;
					}
					if (this.調教UI.ペニス挿入.Is肛)
					{
						this.挿入箇所 = 接触.肛;
						return;
					}
					if (this.調教UI.ペニス挿入.Is糸)
					{
						this.挿入箇所 = 接触.糸;
						return;
					}
				}
				else if (mb == MouseButtons.Right && !this.手コキ.Run && !this.パイズリ.Run && !this.足コキ.Run)
				{
					if (!this.Isモ\u30FCド)
					{
						if (!this.調教UI.ハンド挿入.Is挿入)
						{
							this.持ち手 = false;
							this.調教UI.Focus.Ele.濃度 = 0.5;
							this.調教UI.Focus = this.調教UI.ハンド右CM;
							this.調教UI.ハンド右.位置B = cp;
							this.調教UI.ハンド処理.切り替え = true;
							this.調教UI.ハンド処理.Move(ref mb, ref cp, ref hc, ref cd);
							return;
						}
					}
					else if (this.調教UI.ペニス挿入.Is挿入)
					{
						this.調教UI.ペニス挿入.Down(ref mb, ref cp, ref hc, ref cd);
						return;
					}
				}
				else if (mb == MouseButtons.Middle && !this.手コキ.Run && !this.パイズリ.Run && !this.足コキ.Run && !this.Isモ\u30FCド && !this.調教UI.マウス挿入.Is挿入)
				{
					this.持ち手 = false;
					this.調教UI.Focus.Ele.濃度 = 0.5;
					this.調教UI.Focus = this.調教UI.マウスCM;
					this.調教UI.マウスCM.Ele.位置B = cp;
					this.調教UI.マウス処理.切り替え = true;
					this.調教UI.マウス処理.Move(ref mb, ref cp, ref hc, ref cd);
				}
			}
		}

		public void Up(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref 接触D cd)
		{
			if (this.調教UI.Focus == this.対象 && this.Isモ\u30FCド)
			{
				if (this.持ち手)
				{
					this.調教UI.ハンド右.位置C = new Vector2D(0.0, 0.021800000000000003);
				}
				if (this.Isパイズリ && mb == MouseButtons.Left)
				{
					this.調教UI.Action(接触.胸, アクション情報.パイ, タイミング情報.終了, アイテム情報.ペニス, 0, 1, false, false);
					Act.奴体力消費小();
					Act.主精力消費小();
					if (this.パイズリ.Run)
					{
						this.パイズリ.End();
					}
					Cursor.Position = this.Med.BaseControlC.PointToScreen(this.Med.FromBasePosition(this.対象.Ele.位置B));
					this.調教UI.ハンド処理.バスト初期化.Sta();
					this.vc = Dat.Vec2DZero;
					this.Bod.胸毛_人.位置C = this.vc;
					this.調教UI.ハンド左表示 = false;
					this.調教UI.ハンド右.位置C = Dat.Vec2DZero;
					this.調教UI.ハンド左.位置C = Dat.Vec2DZero;
					this.対象.Ele.角度C = 0.0;
					this.持ち手 = false;
					this.Isパイズリ = false;
					this.調教UI.放し();
					this.胸オ\u30FCバ\u30FC時();
					return;
				}
				this.調教UI.ペニス挿入.Up(ref mb, ref cp, ref hc, ref cd);
				if (Sta.GameData.ガイド)
				{
					if (string.IsNullOrWhiteSpace(this.ip.SubInfoIm))
					{
						情報パネル ip = this.ip;
						ip.SubInfoIm += this.si();
						return;
					}
					if (this.ip.SubInfoIm == "LDo:" + tex.押付け)
					{
						this.扱き時();
					}
				}
			}
		}

		public void Leave(ref MouseButtons mb, ref Vector2D cp, ref Color hc)
		{
		}

		public void Wheel(ref MouseButtons mb, ref Vector2D cp, ref int dt, ref Color hc, ref 接触D cd)
		{
			if (this.調教UI.Focus == this.対象 && !this.Isモ\u30FCド && !this.調教UI.コキ)
			{
				if (!this.持ち手)
				{
					this.持ち手 = true;
				}
				this.扱き = (this.扱き + 0.5 * (double)(-(double)dt.Sign())).LimitM(0.3, 1.0);
				this.調教UI.ハンド右.位置C = new Vector2D(0.0, 0.02 * this.扱き);
				Act.自コキ処理();
				Act.主精力消費小();
			}
		}

		public void 精液発射()
		{
			if (!this.調教UI.ペニス挿入.Is挿入)
			{
				this.チンピク.Sta();
			}
			this.射精.Sta();
		}

		public ペニス処理(調教UI 調教UI, CM ペニス)
		{
			ペニス処理.<>c__DisplayClass47_0 CS$<>8__locals1 = new ペニス処理.<>c__DisplayClass47_0();
			CS$<>8__locals1.調教UI = 調教UI;
			CS$<>8__locals1.ペニス = ペニス;
			base..ctor(CS$<>8__locals1.調教UI, CS$<>8__locals1.ペニス);
			CS$<>8__locals1.<>4__this = this;
			double d = CS$<>8__locals1.調教UI.ペニス.X0Y4_陰嚢.BasePointBase.Y - CS$<>8__locals1.調教UI.ペニス.X0Y0_陰嚢.BasePointBase.Y;
			Vector2D v = new Vector2D(this.対象.Ele.位置C.X, d);
			Mot mot = new Mot(0.0, 1.0);
			mot.BaseSpeed = 4.0;
			mot.Staing = delegate(Mot m)
			{
				CS$<>8__locals1.<>4__this.対象.Ele.Yi = 0;
			};
			mot.Runing = delegate(Mot m)
			{
				CS$<>8__locals1.<>4__this.対象.Ele.Yv = m.Value;
				v.Y = d * m.Value;
				CS$<>8__locals1.<>4__this.対象.Ele.位置C = v;
			};
			mot.Reaing = delegate(Mot m)
			{
			};
			mot.Rouing = delegate(Mot m)
			{
				m.End();
			};
			mot.Ending = delegate(Mot m)
			{
				m.ResetValue();
				CS$<>8__locals1.<>4__this.対象.Ele.Yi = 0;
				CS$<>8__locals1.<>4__this.対象.Ele.位置C = Dat.Vec2DZero;
			};
			this.チンピク = mot;
			CS$<>8__locals1.調教UI.Mots.Add(this.チンピク.GetHashCode().ToString(), this.チンピク);
			Mot mot2 = new Mot(0.0, 1.0);
			mot2.BaseSpeed = 0.2 - 0.18 * this.射精時間;
			mot2.Staing = delegate(Mot m)
			{
				m.BaseSpeed = 0.2 - 0.18 * CS$<>8__locals1.<>4__this.射精時間;
			};
			mot2.Runing = delegate(Mot m)
			{
				Act.射精処理();
			};
			mot2.Reaing = delegate(Mot m)
			{
				m.End();
			};
			mot2.Rouing = delegate(Mot m)
			{
			};
			mot2.Ending = delegate(Mot m)
			{
				CS$<>8__locals1.<>4__this.射精.End();
				Act.射精終了処理();
			};
			this.射精終了 = mot2;
			CS$<>8__locals1.調教UI.Mots.Add(this.射精終了.GetHashCode().ToString(), this.射精終了);
			Mot mot3 = new Mot(0.0, 1.0);
			mot3.BaseSpeed = 4.0;
			mot3.Staing = delegate(Mot m)
			{
			};
			double xc;
			mot3.Runing = delegate(Mot m)
			{
				xc = 1.0 + 0.2 * m.Value;
				foreach (Par par in CS$<>8__locals1.調教UI.ペニス.本体.EnumAllPar())
				{
					if (par.Tag != "陰嚢")
					{
						par.SizeXCont = xc;
					}
				}
				CS$<>8__locals1.調教UI.ペニス.位置C = Oth.GetRandomVector() * 0.001;
				CS$<>8__locals1.調教UI.射精.位置C = CS$<>8__locals1.調教UI.ペニス.位置C;
			};
			mot3.Reaing = delegate(Mot m)
			{
				CS$<>8__locals1.<>4__this.放精.Sta();
				CS$<>8__locals1.<>4__this.中出し = CS$<>8__locals1.調教UI.ペニス挿入.Is挿入;
				if (CS$<>8__locals1.<>4__this.中出し)
				{
					CS$<>8__locals1.<>4__this.中出しCount = CS$<>8__locals1.<>4__this.中出しCount + 1;
				}
				Act.射精中処理();
				Act.主精力消費大();
				m.End();
			};
			mot3.Rouing = delegate(Mot m)
			{
			};
			mot3.Ending = delegate(Mot m)
			{
				CS$<>8__locals1.<>4__this.対象.Ele.尺度XC = 1.0;
				CS$<>8__locals1.調教UI.ペニス.位置C = Dat.Vec2DZero;
				CS$<>8__locals1.調教UI.射精.位置C = Dat.Vec2DZero;
				m.ResetValue();
			};
			this.射精 = mot3;
			CS$<>8__locals1.調教UI.Mots.Add(this.射精.GetHashCode().ToString(), this.射精);
			bool 外出し = false;
			bool 断面 = false;
			Mot mot4 = new Mot(0.0, 1.0);
			mot4.BaseSpeed = 3.0;
			mot4.Staing = delegate(Mot m)
			{
				Sou.射精.Play();
				CS$<>8__locals1.<>4__this.射精_();
				if (外出し = !CS$<>8__locals1.調教UI.ペニス挿入.Is挿入)
				{
					CS$<>8__locals1.調教UI.射精.表示 = true;
					CS$<>8__locals1.調教UI.射精.Yi = 0;
					return;
				}
				bool flag = 断面 = (CS$<>8__locals1.<>4__this.Bod.断面_表示 && CS$<>8__locals1.<>4__this.挿入箇所 == 接触.膣);
			};
			Par p;
			Vector2D cp;
			Color hc;
			接触 c;
			mot4.Runing = delegate(Mot m)
			{
				if (外出し)
				{
					CS$<>8__locals1.調教UI.射精.位置B = CS$<>8__locals1.調教UI.ペニス.位置B;
					CS$<>8__locals1.調教UI.射精.Yv = m.Value;
					if (CS$<>8__locals1.調教UI.射精.Yv >= 0.65 && CS$<>8__locals1.調教UI.Focus == CS$<>8__locals1.ペニス)
					{
						p = CS$<>8__locals1.調教UI.射精.本体.Current.EnumAllPar().First<Par>();
						cp = p.ToGlobal(p.OP.GetCenter() + Oth.GetRandomVector() * 0.0025);
						hc = CS$<>8__locals1.<>4__this.Med.GetHitColor(CS$<>8__locals1.<>4__this.Med.FromBasePosition(cp));
						CS$<>8__locals1.<>4__this.Bod.Addぶっかけ(cp, hc);
						CS$<>8__locals1.調教UI.Action(c = CS$<>8__locals1.<>4__this.Cha.GetContact(ref hc).c, アクション情報.接触, タイミング情報.開始, アイテム情報.ペニス, 0, 1, false, true);
						if (c != 接触.none)
						{
							Act.ぶっかけ処理();
							return;
						}
					}
				}
				else
				{
					if (断面 && CS$<>8__locals1.<>4__this.挿入箇所 == 接触.膣)
					{
						CS$<>8__locals1.<>4__this.Bod.膣内精液.精液濃度 = (CS$<>8__locals1.<>4__this.Bod.膣内精液.精液濃度 + 0.05).LimitM(0.0, 1.0);
						CS$<>8__locals1.<>4__this.Bod.断面.精液濃度 = (CS$<>8__locals1.<>4__this.Bod.断面.精液濃度 + 0.025).LimitM(0.0, 1.0);
					}
					CS$<>8__locals1.調教UI.Action(CS$<>8__locals1.<>4__this.挿入箇所, アクション情報.挿入, タイミング情報.開始, アイテム情報.ペニス, 0, 1, false, true);
					Act.中出し処理();
				}
			};
			mot4.Reaing = delegate(Mot m)
			{
				m.End();
			};
			mot4.Rouing = delegate(Mot m)
			{
			};
			mot4.Ending = delegate(Mot m)
			{
				if (外出し)
				{
					CS$<>8__locals1.調教UI.射精.表示 = false;
					CS$<>8__locals1.調教UI.射精.Yi = 0;
					return;
				}
				if (断面)
				{
					接触 接触 = CS$<>8__locals1.<>4__this.挿入箇所;
				}
			};
			this.放精 = mot4;
			CS$<>8__locals1.調教UI.Mots.Add(this.放精.GetHashCode().ToString(), this.放精);
			double 下腕XC2 = 0.0;
			double s2 = 1.0;
			Mot mot5 = new Mot(0.0, 1.0);
			mot5.BaseSpeed = 1.0;
			mot5.Staing = delegate(Mot m)
			{
				s2 = (CS$<>8__locals1.<>4__this.手コキ左 ? 1.0 : -1.0);
				CS$<>8__locals1.<>4__this.持ち手 = false;
				CS$<>8__locals1.調教UI.コキ = true;
				if (CS$<>8__locals1.<>4__this.手コキ左)
				{
					CS$<>8__locals1.<>4__this.Cha.腕_人_手コキ左(0, 0.0, 0.0, 0.0, 0.0);
				}
				else
				{
					CS$<>8__locals1.<>4__this.Cha.腕_人_手コキ右(0, 0.0, 0.0, 0.0, 0.0);
				}
				CS$<>8__locals1.<>4__this.手固定 = true;
				CS$<>8__locals1.<>4__this.肩 = (CS$<>8__locals1.<>4__this.手コキ左 ? CS$<>8__locals1.<>4__this.肩左 : CS$<>8__locals1.<>4__this.肩右);
				CS$<>8__locals1.<>4__this.上腕 = (CS$<>8__locals1.<>4__this.手コキ左 ? CS$<>8__locals1.<>4__this.上腕左 : CS$<>8__locals1.<>4__this.上腕右);
				CS$<>8__locals1.<>4__this.下腕 = (CS$<>8__locals1.<>4__this.手コキ左 ? CS$<>8__locals1.<>4__this.下腕左 : CS$<>8__locals1.<>4__this.下腕右);
				CS$<>8__locals1.<>4__this.手 = (CS$<>8__locals1.<>4__this.手コキ左 ? CS$<>8__locals1.<>4__this.手左 : CS$<>8__locals1.<>4__this.手右);
				if (CS$<>8__locals1.<>4__this.下腕 != null)
				{
					下腕XC2 = CS$<>8__locals1.<>4__this.下腕.尺度XC;
				}
				CS$<>8__locals1.調教UI.ペニス.位置B = CS$<>8__locals1.<>4__this.Bod.首.位置.AddY(0.01);
				CS$<>8__locals1.調教UI.Action(接触.手, アクション情報.手コ, タイミング情報.開始, アイテム情報.ペニス, 0, 1, false, false);
				Act.主精力消費小();
				Act.奴体力消費小();
			};
			mot5.Runing = delegate(Mot m)
			{
				if (CS$<>8__locals1.<>4__this.肩 != null)
				{
					CS$<>8__locals1.<>4__this.肩.角度C = s2 * 5.0 * m.Value;
				}
				if (CS$<>8__locals1.<>4__this.下腕 != null)
				{
					CS$<>8__locals1.<>4__this.下腕.角度C = s2 * 30.0 * m.Value;
					CS$<>8__locals1.<>4__this.下腕.尺度XC = 下腕XC2 * (0.9 + 0.1 * m.Value.Inverse());
					if (CS$<>8__locals1.<>4__this.下腕.虫鎌_接続 != null)
					{
						Ele[] 虫鎌_接続 = CS$<>8__locals1.<>4__this.下腕.虫鎌_接続;
						for (int i = 0; i < 虫鎌_接続.Length; i++)
						{
							虫鎌_接続[i].尺度XC = CS$<>8__locals1.<>4__this.下腕.尺度XC;
						}
					}
				}
				if (CS$<>8__locals1.<>4__this.手 != null)
				{
					CS$<>8__locals1.<>4__this.手.角度C = s2 * -30.0 * m.Value;
				}
				if (CS$<>8__locals1.<>4__this.Bod.EI腕前 != null)
				{
					CS$<>8__locals1.<>4__this.Bod.EI腕前.Updatef = true;
				}
				CS$<>8__locals1.調教UI.Action(接触.手, アクション情報.手コ, タイミング情報.継続, アイテム情報.ペニス, 0, 1, false, false);
				Act.主精力消費小();
				Act.奴体力消費小();
			};
			mot5.Reaing = delegate(Mot m)
			{
			};
			mot5.Rouing = delegate(Mot m)
			{
			};
			mot5.Ending = delegate(Mot m)
			{
				CS$<>8__locals1.<>4__this.手固定 = false;
				CS$<>8__locals1.調教UI.コキ = false;
				if (CS$<>8__locals1.<>4__this.肩 != null)
				{
					CS$<>8__locals1.<>4__this.肩.角度C = 0.0;
				}
				if (CS$<>8__locals1.<>4__this.下腕 != null)
				{
					CS$<>8__locals1.<>4__this.下腕.角度C = 0.0;
				}
				if (CS$<>8__locals1.<>4__this.手 != null)
				{
					CS$<>8__locals1.<>4__this.手.角度C = 0.0;
				}
				if (CS$<>8__locals1.<>4__this.Bod.EI腕前 != null)
				{
					CS$<>8__locals1.<>4__this.Bod.EI腕前.Updatef = true;
				}
				CS$<>8__locals1.調教UI.Action(接触.手, アクション情報.手コ, タイミング情報.終了, アイテム情報.ペニス, 0, 1, false, false);
				Act.主精力消費小();
				Act.奴体力消費小();
			};
			this.手コキ = mot5;
			CS$<>8__locals1.調教UI.Mots.Add(this.手コキ.GetHashCode().ToString(), this.手コキ);
			Vector2D vec2DZero = Dat.Vec2DZero;
			double s3 = 0.0;
			Mot mot6 = new Mot(0.0, 1.0);
			mot6.BaseSpeed = 1.0;
			mot6.Staing = delegate(Mot m)
			{
				CS$<>8__locals1.<>4__this.Bod.頬濃度 = 0.0;
				CS$<>8__locals1.<>4__this.Bod.口.Yi = 13;
				CS$<>8__locals1.<>4__this.Bod.舌_表示 = true;
				s3 = (double)OthN.XS.NextSign();
				CS$<>8__locals1.調教UI.Action(接触.口, アクション情報.挿入, タイミング情報.開始, アイテム情報.ペニス, 0, 1, false, false);
				Act.奴体力消費小();
				Act.主精力消費小();
			};
			double t;
			double d1;
			double d2;
			mot6.Runing = delegate(Mot m)
			{
				t = CS$<>8__locals1.<>4__this.Cha.ChaD.技巧度 / Sta.GameData.調教対象.技巧最大値 * 0.4;
				d1 = m.Value.Sin() * CS$<>8__locals1.調教UI.ペニス.Yv.Inverse() * t;
				d2 = m.Value * CS$<>8__locals1.調教UI.ペニス.Yv * t;
				CS$<>8__locals1.<>4__this.Bod.頬濃度 = d1;
				CS$<>8__locals1.<>4__this.Bod.頭.角度C = s3 * 5.0 * d2;
				CS$<>8__locals1.<>4__this.Bod.舌.角度C = s3 * -60.0 * d2;
				CS$<>8__locals1.調教UI.Action(接触.口, アクション情報.挿入, タイミング情報.継続, アイテム情報.ペニス, 0, 1, false, false);
				Act.奴体力消費小();
				Act.主精力消費小();
			};
			mot6.Reaing = delegate(Mot m)
			{
			};
			mot6.Rouing = delegate(Mot m)
			{
				s3 = (double)OthN.XS.NextSign();
			};
			mot6.Ending = delegate(Mot m)
			{
				m.ResetValue();
				CS$<>8__locals1.<>4__this.Bod.舌_表示 = false;
				CS$<>8__locals1.<>4__this.Bod.頬濃度 = 0.0;
				CS$<>8__locals1.<>4__this.Bod.頭.角度C = 0.0;
				CS$<>8__locals1.<>4__this.Bod.舌.角度C = 0.0;
				CS$<>8__locals1.調教UI.Action(接触.口, アクション情報.挿入, タイミング情報.終了, アイテム情報.ペニス, 0, 1, false, false);
				Act.奴体力消費小();
				Act.主精力消費小();
			};
			this.フェラ = mot6;
			CS$<>8__locals1.調教UI.Mots.Add(this.フェラ.GetHashCode().ToString(), this.フェラ);
			double s = 0.0;
			double 下腕XC = 0.0;
			Vector2D vc = Dat.Vec2DZero;
			bool sb = false;
			Mot mot7 = new Mot(0.0, 1.0);
			mot7.BaseSpeed = 1.0;
			mot7.Staing = delegate(Mot m)
			{
				CS$<>8__locals1.<>4__this.Cha.両腕_人_パイズリ(0, false, false);
				CS$<>8__locals1.<>4__this.手固定 = true;
				if (CS$<>8__locals1.<>4__this.下腕左 != null)
				{
					下腕XC = CS$<>8__locals1.<>4__this.下腕左.尺度XC;
				}
				vc = Dat.Vec2DZero;
				sb = OthN.XS.NextBool();
				s = (sb ? -1.0 : 1.0);
				CS$<>8__locals1.調教UI.Action(接触.胸, アクション情報.パイ, タイミング情報.開始, アイテム情報.ペニス, 0, 1, false, false);
				Act.主精力消費小();
				Act.奴体力消費小();
			};
			double vl;
			double vr;
			mot7.Runing = delegate(Mot m)
			{
				vl = (CS$<>8__locals1.<>4__this.Isパイズリ相互 ? (sb ? m.Value : m.Value.Inverse()) : m.Value);
				vr = (CS$<>8__locals1.<>4__this.Isパイズリ相互 ? (sb ? m.Value.Inverse() : m.Value) : m.Value);
				if (CS$<>8__locals1.<>4__this.肩左 != null)
				{
					CS$<>8__locals1.<>4__this.肩左.角度C = 5.0 * vl;
				}
				if (CS$<>8__locals1.<>4__this.下腕左 != null)
				{
					CS$<>8__locals1.<>4__this.下腕左.角度C = -20.0 * vl;
					CS$<>8__locals1.<>4__this.下腕左.尺度XC = 下腕XC + 0.2 * vl;
					if (CS$<>8__locals1.<>4__this.下腕左.虫鎌_接続 != null)
					{
						Ele[] 虫鎌_接続 = CS$<>8__locals1.<>4__this.下腕左.虫鎌_接続;
						for (int i = 0; i < 虫鎌_接続.Length; i++)
						{
							虫鎌_接続[i].尺度XC = CS$<>8__locals1.<>4__this.下腕左.尺度XC;
						}
					}
				}
				if (CS$<>8__locals1.<>4__this.手左 != null)
				{
					CS$<>8__locals1.<>4__this.手左.角度C = 30.0 * vl;
				}
				if (CS$<>8__locals1.<>4__this.肩右 != null)
				{
					CS$<>8__locals1.<>4__this.肩右.角度C = -5.0 * vr;
				}
				if (CS$<>8__locals1.<>4__this.下腕右 != null)
				{
					CS$<>8__locals1.<>4__this.下腕右.角度C = 20.0 * vr;
					CS$<>8__locals1.<>4__this.下腕右.尺度XC = 下腕XC + 0.2 * vr;
					if (CS$<>8__locals1.<>4__this.下腕右.虫鎌_接続 != null)
					{
						Ele[] 虫鎌_接続 = CS$<>8__locals1.<>4__this.下腕右.虫鎌_接続;
						for (int i = 0; i < 虫鎌_接続.Length; i++)
						{
							虫鎌_接続[i].尺度XC = CS$<>8__locals1.<>4__this.下腕右.尺度XC;
						}
					}
				}
				if (CS$<>8__locals1.<>4__this.手右 != null)
				{
					CS$<>8__locals1.<>4__this.手右.角度C = -30.0 * vr;
				}
				CS$<>8__locals1.<>4__this.Bod.乳房左.Yv = 0.2 + 0.5 * vl;
				CS$<>8__locals1.<>4__this.Bod.乳房右.Yv = 0.2 + 0.5 * vr;
				if (CS$<>8__locals1.<>4__this.Bod.胸毛_人 != null)
				{
					if (CS$<>8__locals1.<>4__this.Isパイズリ相互)
					{
						CS$<>8__locals1.<>4__this.Bod.胸毛_人.角度C = s * -2.5 + s * 5.0 * vl;
					}
					else
					{
						vc.Y = -0.002 * vl;
						CS$<>8__locals1.<>4__this.Bod.胸毛_人.位置C = vc;
					}
				}
				if (CS$<>8__locals1.<>4__this.Bod.EI腕前 != null)
				{
					CS$<>8__locals1.<>4__this.Bod.EI腕前.Updatef = true;
				}
				CS$<>8__locals1.調教UI.Action(接触.胸, アクション情報.パイ, タイミング情報.継続, アイテム情報.ペニス, 0, 1, false, false);
				Act.主精力消費小();
				Act.奴体力消費小();
			};
			mot7.Reaing = delegate(Mot m)
			{
			};
			mot7.Rouing = delegate(Mot m)
			{
			};
			mot7.Ending = delegate(Mot m)
			{
				CS$<>8__locals1.<>4__this.手固定 = false;
				CS$<>8__locals1.調教UI.ハンド処理.バスト初期化.Sta();
				CS$<>8__locals1.<>4__this.Bod.胸毛_人.角度C = 0.0;
				CS$<>8__locals1.<>4__this.Bod.胸毛_人.位置C = Dat.Vec2DZero;
				if (CS$<>8__locals1.<>4__this.肩左 != null)
				{
					CS$<>8__locals1.<>4__this.肩左.角度C = 0.0;
				}
				if (CS$<>8__locals1.<>4__this.下腕左 != null)
				{
					CS$<>8__locals1.<>4__this.下腕左.角度C = 0.0;
				}
				if (CS$<>8__locals1.<>4__this.手左 != null)
				{
					CS$<>8__locals1.<>4__this.手左.角度C = 0.0;
				}
				if (CS$<>8__locals1.<>4__this.肩右 != null)
				{
					CS$<>8__locals1.<>4__this.肩右.角度C = 0.0;
				}
				if (CS$<>8__locals1.<>4__this.下腕右 != null)
				{
					CS$<>8__locals1.<>4__this.下腕右.角度C = 0.0;
				}
				if (CS$<>8__locals1.<>4__this.手右 != null)
				{
					CS$<>8__locals1.<>4__this.手右.角度C = 0.0;
				}
				if (CS$<>8__locals1.<>4__this.Bod.EI腕前 != null)
				{
					CS$<>8__locals1.<>4__this.Bod.EI腕前.Updatef = true;
				}
				m.ResetValue();
				CS$<>8__locals1.調教UI.Action(接触.胸, アクション情報.パイ, タイミング情報.終了, アイテム情報.ペニス, 0, 1, false, false);
				Act.主精力消費小();
				Act.奴体力消費小();
			};
			this.パイズリ = mot7;
			CS$<>8__locals1.調教UI.Mots.Add(this.パイズリ.GetHashCode().ToString(), this.パイズリ);
			Mot mot8 = new Mot(0.0, 1.0);
			mot8.BaseSpeed = 1.0;
			mot8.Staing = delegate(Mot m)
			{
				CS$<>8__locals1.<>4__this.持ち手 = false;
				CS$<>8__locals1.調教UI.コキ = true;
				CS$<>8__locals1.<>4__this.Bod.腰振り_人v = 1.0;
				CS$<>8__locals1.調教UI.ペニス.位置B = CS$<>8__locals1.<>4__this.Bod.局部位置.AddY(0.035);
				CS$<>8__locals1.<>4__this.Cha.両脚_人_足コキ(0);
				CS$<>8__locals1.<>4__this.足固定 = true;
				CS$<>8__locals1.調教UI.Action(接触.足, アクション情報.足コ, タイミング情報.開始, アイテム情報.ペニス, 0, 1, false, false);
				Act.主精力消費小();
				Act.奴体力消費小();
			};
			mot8.Runing = delegate(Mot m)
			{
				if (CS$<>8__locals1.<>4__this.腿左 != null)
				{
					CS$<>8__locals1.<>4__this.腿左.角度C = 11.0 * m.Value;
				}
				if (CS$<>8__locals1.<>4__this.腿右 != null)
				{
					CS$<>8__locals1.<>4__this.腿右.角度C = -11.0 * m.Value;
				}
				if (CS$<>8__locals1.<>4__this.脚左 != null)
				{
					CS$<>8__locals1.<>4__this.脚左.角度C = -15.0 * m.Value;
				}
				if (CS$<>8__locals1.<>4__this.脚右 != null)
				{
					CS$<>8__locals1.<>4__this.脚右.角度C = 15.0 * m.Value;
				}
				if (CS$<>8__locals1.<>4__this.足左 != null)
				{
					CS$<>8__locals1.<>4__this.足左.角度C = 5.0 * m.Value;
				}
				if (CS$<>8__locals1.<>4__this.足右 != null)
				{
					CS$<>8__locals1.<>4__this.足右.角度C = -5.0 * m.Value;
				}
				if (CS$<>8__locals1.<>4__this.Bod.EI腿 != null)
				{
					CS$<>8__locals1.<>4__this.Bod.EI腿.Updatef = true;
				}
				CS$<>8__locals1.調教UI.Action(接触.足, アクション情報.足コ, タイミング情報.継続, アイテム情報.ペニス, 0, 1, false, false);
				Act.主精力消費小();
				Act.奴体力消費小();
			};
			mot8.Reaing = delegate(Mot m)
			{
			};
			mot8.Rouing = delegate(Mot m)
			{
			};
			mot8.Ending = delegate(Mot m)
			{
				CS$<>8__locals1.<>4__this.足固定 = false;
				CS$<>8__locals1.調教UI.コキ = false;
				if (CS$<>8__locals1.<>4__this.腿左 != null)
				{
					CS$<>8__locals1.<>4__this.腿左.角度C = 0.0;
				}
				if (CS$<>8__locals1.<>4__this.腿右 != null)
				{
					CS$<>8__locals1.<>4__this.腿右.角度C = 0.0;
				}
				if (CS$<>8__locals1.<>4__this.脚左 != null)
				{
					CS$<>8__locals1.<>4__this.脚左.角度C = 0.0;
				}
				if (CS$<>8__locals1.<>4__this.脚右 != null)
				{
					CS$<>8__locals1.<>4__this.脚右.角度C = 0.0;
				}
				if (CS$<>8__locals1.<>4__this.足左 != null)
				{
					CS$<>8__locals1.<>4__this.足左.角度C = 0.0;
				}
				if (CS$<>8__locals1.<>4__this.足右 != null)
				{
					CS$<>8__locals1.<>4__this.足右.角度C = 0.0;
				}
				if (CS$<>8__locals1.<>4__this.Bod.EI腿 != null)
				{
					CS$<>8__locals1.<>4__this.Bod.EI腿.Updatef = true;
				}
				CS$<>8__locals1.調教UI.Action(接触.足, アクション情報.足コ, タイミング情報.終了, アイテム情報.ペニス, 0, 1, false, false);
				Act.主精力消費小();
				Act.奴体力消費小();
			};
			this.足コキ = mot8;
			CS$<>8__locals1.調教UI.Mots.Add(this.足コキ.GetHashCode().ToString(), this.足コキ);
		}

		public void SetCha(Cha Cha)
		{
			this.Cha = Cha;
			this.Bod = Cha.Bod;
			if (this.Bod.腕人n > 0)
			{
				this.肩左 = this.Bod.腕人左[0].肩;
				this.上腕左 = this.Bod.腕人左[0].上腕;
				this.下腕左 = this.Bod.腕人左[0].下腕;
				this.手左 = this.Bod.腕人左[0].手;
				this.肩右 = this.Bod.腕人右[0].肩;
				this.上腕右 = this.Bod.腕人右[0].上腕;
				this.下腕右 = this.Bod.腕人右[0].下腕;
				this.手右 = this.Bod.腕人右[0].手;
			}
			if (this.Bod.脚人n > 0)
			{
				this.腿左 = this.Bod.脚人左[0].腿;
				this.脚左 = this.Bod.脚人左[0].脚;
				this.足左 = this.Bod.脚人左[0].足;
				this.腿右 = this.Bod.脚人右[0].腿;
				this.脚右 = this.Bod.脚人右[0].脚;
				this.足右 = this.Bod.脚人右[0].足;
			}
		}

		public new void Reset()
		{
			base.Reset();
			this.Is手コキ = false;
			this.Is足コキ = false;
			this.Isパイズリ = false;
			this.中出し = false;
			this.手固定 = false;
			this.足固定 = false;
			Mot mot = this.チンピク;
			if (mot != null)
			{
				mot.End();
			}
			this.射精時間 = 0.0;
			Mot mot2 = this.射精終了;
			if (mot2 != null)
			{
				mot2.End();
			}
			Mot mot3 = this.射精;
			if (mot3 != null)
			{
				mot3.End();
			}
			Mot mot4 = this.放精;
			if (mot4 != null)
			{
				mot4.End();
			}
			this.中出しCount = 0;
			Mot mot5 = this.手コキ;
			if (mot5 != null)
			{
				mot5.End();
			}
			this.手コキ左 = false;
			Mot mot6 = this.フェラ;
			if (mot6 != null)
			{
				mot6.End();
			}
			Mot mot7 = this.パイズリ;
			if (mot7 != null)
			{
				mot7.End();
			}
			this.Isパイズリ相互 = false;
			this.Isパイズリ他動 = false;
			Mot mot8 = this.足コキ;
			if (mot8 != null)
			{
				mot8.End();
			}
			this.持ち手 = false;
			this.扱き = 1.0;
			this.yi = 0;
			this.x = 0.0;
			this.y = 0.0;
			this.d = 0.0;
			this.v = default(Vector2D);
			this.o = default(Vector2D);
			this.vc = Dat.Vec2DZero;
			this.挿入箇所 = 接触.none;
		}

		public bool Is手コキ;

		public bool Is足コキ;

		public bool Isパイズリ;

		public bool 中出し;

		public bool 手固定;

		public bool 足固定;

		public Mot チンピク;

		public double 射精時間;

		public Mot 射精終了;

		public Mot 射精;

		private Mot 放精;

		public int 中出しCount;

		public Mot 手コキ;

		public bool 手コキ左;

		public Mot フェラ;

		public Mot パイズリ;

		public bool Isパイズリ相互;

		public bool Isパイズリ他動;

		public Mot 足コキ;

		private double 扱き = 1.0;

		private int yi;

		private double x;

		private double y;

		private double d;

		private Vector2D v;

		private Vector2D o;

		private Vector2D vc = Dat.Vec2DZero;

		private 接触 挿入箇所;

		private 肩 肩;

		private 肩 肩左;

		private 肩 肩右;

		private 上腕_人 上腕;

		private 上腕_人 上腕左;

		private 上腕_人 上腕右;

		private 下腕_人 下腕;

		private 下腕_人 下腕左;

		private 下腕_人 下腕右;

		private 手_人 手;

		private 手_人 手左;

		private 手_人 手右;

		private 腿_人 腿左;

		private 腿_人 腿右;

		private 脚_人 脚左;

		private 脚_人 脚右;

		private 足_人 足左;

		private 足_人 足右;
	}
}
