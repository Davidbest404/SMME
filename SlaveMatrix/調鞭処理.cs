using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 調鞭処理 : 処理B
	{
		public void 振り()
		{
			this.調教UI.擬音キュ\u30FC.Enqueue(delegate(Are a)
			{
				this.調教UI.擬音.Sound(a, this.対象.Ele.位置.GetAreaPoint(0.05), Sta.鞭振.GetVal(this.強さ_, 1.0), new Font("MS Gothic", 1f), Col.White, 0.2 + 0.2 * this.強さ_, true);
			});
		}

		public void 打ち(Vector2D p)
		{
			this.調教UI.擬音キュ\u30FC.Enqueue(delegate(Are a)
			{
				this.調教UI.擬音.Sound(a, Sta.GetAreaPoint(ref p, 0.01), Sta.鞭打.GetVal(this.強さ_, OthN.XS.NextDouble()), new Font("MS Gothic", 1f), Color.Red.S(this.強さ_.LimitM(0.5, 1.0)), 0.2 + 0.1 * this.強さ_, true);
			});
		}

		private double 強さ_
		{
			get
			{
				return 0.35 + base.強度 * 0.65;
			}
		}

		private void 移動時()
		{
			if (Sta.GameData.ガイド)
			{
				this.ip.SubInfoIm = string.Concat(new object[]
				{
					"LCl:",
					tex.左打,
					"\r\nRCl:",
					tex.右打,
					"\r\nWh:",
					tex.強さL,
					this.強さ,
					"\r\nMCl:",
					tex.放す
				});
			}
		}

		public void Move(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref 接触D cd)
		{
			if (this.調教UI.Focus == this.対象)
			{
				this.調教UI.放し();
				this.v = Cursor.Position.ToVector2D();
				this.x = (this.o.X - this.v.X).Sign();
				this.o = this.v;
				this.対象.Ele.角度C = 0.0;
				this.対象.Ele.Xi = 0;
				this.対象.Ele.Yi = (this.対象.Ele.Yi + this.x).Limit(0, this.対象.Ele.本体.CountY);
				this.対象.Ele.本体.JoinPA();
				this.移動時();
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
				if (mb == MouseButtons.Left || mb == MouseButtons.Right)
				{
					this.調教UI.押し(ref cd);
					this.mb = mb;
					this.鞭撃モ\u30FCション.Sta();
					this.移動時();
					return;
				}
				if (mb == MouseButtons.Middle)
				{
					this.鞭撃モ\u30FCション.End();
					this.衝撃モ\u30FCション.End();
					this.調教UI.通常放し();
				}
			}
		}

		public void Up(ref MouseButtons mb, ref Vector2D cp, ref Color hc)
		{
		}

		public void Leave(ref MouseButtons mb, ref Vector2D cp, ref Color hc)
		{
		}

		public void Wheel(ref MouseButtons mb, ref Vector2D cp, ref int dt, ref Color hc)
		{
			if (this.調教UI.Focus == this.対象)
			{
				this.強さ = (this.強さ + dt.Sign()).LimitM(1, 3);
				this.鞭撃モ\u30FCション.BaseSpeed = 10.0 * this.強さ_;
				if (!Sta.GameData.ガイド)
				{
					this.ip.SubInfoIm = "Wh:" + tex.強さL + this.強さ;
					return;
				}
				this.移動時();
			}
		}

		public 調鞭処理(調教UI 調教UI, CM 調教鞭)
		{
			調鞭処理.<>c__DisplayClass17_0 CS$<>8__locals1 = new 調鞭処理.<>c__DisplayClass17_0();
			CS$<>8__locals1.調教UI = 調教UI;
			base..ctor(CS$<>8__locals1.調教UI, 調教鞭);
			CS$<>8__locals1.<>4__this = this;
			調教鞭 鞭 = CS$<>8__locals1.調教UI.調教鞭;
			bool l = false;
			Mot mot = new Mot(0.0, 1.0);
			mot.BaseSpeed = 10.0 * this.強さ_;
			mot.Staing = delegate(Mot m)
			{
				l = (CS$<>8__locals1.<>4__this.mb == MouseButtons.Left);
				鞭.Xi = 1;
				if (l)
				{
					鞭.Yi = 0;
				}
				else
				{
					鞭.Yi = 4;
				}
				鞭.鞭撃エフェクト1_表示 = true;
				鞭.鞭撃エフェクト2_表示 = true;
				鞭.鞭撃エフェクト1CD.不透明度 = CS$<>8__locals1.<>4__this.強度;
				鞭.鞭撃エフェクト2CD.不透明度 = CS$<>8__locals1.<>4__this.強度;
				CS$<>8__locals1.<>4__this.振り();
			};
			Par p;
			Vector2D cp;
			Color hc;
			mot.Runing = delegate(Mot m)
			{
				if (l)
				{
					鞭.角度C = 100.0 * m.Value;
				}
				else
				{
					鞭.角度C = -100.0 * m.Value;
				}
				p = 鞭.本体.Current.EnumAllPar().First((Par e) => e.Tag.Contains("先"));
				cp = p.ToGlobal(p.JP[0].Joint);
				hc = CS$<>8__locals1.<>4__this.Med.GetHitColor(CS$<>8__locals1.<>4__this.Med.FromBasePosition(cp));
				if (CS$<>8__locals1.調教UI.Bod.IsHit(hc))
				{
					CS$<>8__locals1.<>4__this.衝撃.位置B = cp;
					CS$<>8__locals1.<>4__this.衝撃モ\u30FCション.Sta();
					if (CS$<>8__locals1.<>4__this.強度 > 0.5)
					{
						CS$<>8__locals1.<>4__this.Bod.Add鞭痕(cp, hc);
					}
					CS$<>8__locals1.調教UI.Action(CS$<>8__locals1.<>4__this.Cha.GetContact(ref hc).c, アクション情報.鞭打, タイミング情報.開始, アイテム情報.調教鞭, 0, CS$<>8__locals1.<>4__this.強さ, false, false);
					if (0.5.Lot())
					{
						Act.奴体力消費大();
					}
					CS$<>8__locals1.<>4__this.打ち(cp);
				}
			};
			mot.Reaing = delegate(Mot m)
			{
				鞭.鞭撃エフェクト1_表示 = false;
				鞭.鞭撃エフェクト2_表示 = false;
				if (l)
				{
					鞭.Yi = 4;
				}
				else
				{
					鞭.Yi = 0;
				}
				鞭.本体.JoinPA();
				m.End();
			};
			mot.Rouing = delegate(Mot m)
			{
			};
			mot.Ending = delegate(Mot m)
			{
				m.ResetValue();
			};
			this.鞭撃モ\u30FCション = mot;
			CS$<>8__locals1.調教UI.Mots.Add(this.鞭撃モ\u30FCション.GetHashCode().ToString(), this.鞭撃モ\u30FCション);
			this.衝撃 = new 衝撃(this.Are.DisUnit, 配色指定.N0, null, this.Med, new 衝撃D
			{
				表示 = false
			});
			this.衝撃.尺度B = 1.2;
			Mot mot2 = new Mot(0.0, 1.0);
			mot2.BaseSpeed = 5.0;
			mot2.Staing = delegate(Mot m)
			{
				CS$<>8__locals1.<>4__this.衝撃.表示 = true;
				CS$<>8__locals1.<>4__this.衝撃.角度C = 360.0 * OthN.XS.NextDouble();
				CS$<>8__locals1.<>4__this.衝撃.尺度C = 0.0;
				Sou.鞭撃.Play();
			};
			mot2.Runing = delegate(Mot m)
			{
				CS$<>8__locals1.<>4__this.衝撃.尺度C = m.Value * CS$<>8__locals1.<>4__this.強さ_;
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
				CS$<>8__locals1.<>4__this.衝撃.表示 = false;
				m.ResetValue();
			};
			this.衝撃モ\u30FCション = mot2;
			CS$<>8__locals1.調教UI.Mots.Add(this.衝撃モ\u30FCション.GetHashCode().ToString(), this.衝撃モ\u30FCション);
		}

		public void SetCha(Cha Cha)
		{
			this.Cha = Cha;
			this.Bod = Cha.Bod;
		}

		public new void Reset()
		{
			base.Reset();
			Mot 鞭撃モ_u30FCション = this.鞭撃モ\u30FCション;
			if (鞭撃モ_u30FCション != null)
			{
				鞭撃モ_u30FCション.End();
			}
			Mot 衝撃モ_u30FCション = this.衝撃モ\u30FCション;
			if (衝撃モ_u30FCション != null)
			{
				衝撃モ_u30FCション.End();
			}
			this.v = default(Vector2D);
			this.o = default(Vector2D);
			this.x = 0;
			this.mb = MouseButtons.None;
		}

		public 衝撃 衝撃;

		public Mot 鞭撃モ\u30FCション;

		private Mot 衝撃モ\u30FCション;

		private Vector2D v;

		private Vector2D o;

		private int x;

		private MouseButtons mb;
	}
}
