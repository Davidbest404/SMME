using System;
using System.Drawing;
using System.Windows.Forms;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 羽箒処理 : 処理B
	{
		private string 擽り時()
		{
			return string.Concat(new object[]
			{
				"LUp:",
				tex.やめる,
				"\r\nWh:",
				tex.強さL,
				this.強さ,
				"\r\nRCl:",
				tex.放す
			});
		}

		private string 待機時()
		{
			return string.Concat(new object[]
			{
				this.調教UI.Bod.IsHit(this.調教UI.羽根箒先端hc) ? ("LDo:" + tex.擽り + "\r\n") : "",
				"Wh:",
				tex.強さL,
				this.強さ,
				"\r\nRCl:",
				tex.放す
			});
		}

		private void 移動時()
		{
			if (Sta.GameData.ガイド)
			{
				if (this.Is擽り)
				{
					this.ip.SubInfoIm = this.擽り時();
					return;
				}
				this.ip.SubInfoIm = this.待機時();
			}
		}

		public void Move(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref 接触D cd)
		{
			if (this.調教UI.Focus == this.対象)
			{
				if (this.Is擽り)
				{
					Color 羽根箒先端hc = this.調教UI.羽根箒先端hc;
					if (this.調教UI.Bod.IsHit(羽根箒先端hc))
					{
						if (!this.調教UI.押し状態)
						{
							this.調教UI.押し(ref cd);
							this.調教UI.Action(this.Cha.GetContact(ref 羽根箒先端hc).c, アクション情報.接触, タイミング情報.開始, アイテム情報.羽根箒, 0, 1, false, false);
							Act.奴体力消費小();
							Act.主精力消費小();
						}
						this.擽りモ\u30FCション.Sta();
						this.調教UI.Action(this.Cha.GetContact(ref 羽根箒先端hc).c, アクション情報.接触, タイミング情報.継続, アイテム情報.羽根箒, 0, 1, false, false);
						Act.奴体力消費小();
						Act.主精力消費小();
					}
					else if (this.調教UI.押し状態)
					{
						this.調教UI.Action(this.Cha.GetContact(ref 羽根箒先端hc).c, アクション情報.接触, タイミング情報.終了, アイテム情報.羽根箒, 0, 1, false, false);
						Act.奴体力消費小();
						Act.主精力消費小();
						this.擽りモ\u30FCション.End();
						this.調教UI.放し();
					}
				}
				if (!this.対象.Ele.右 && cp.X < this.xc)
				{
					this.対象.Ele.右 = !this.対象.Ele.右;
					this.対象.Ele.本体.JoinPA();
					this.ハンド右.X11Y0_小指.ReverseX();
					this.ハンド右.X11Y0_薬指.ReverseX();
					this.ハンド右.X11Y0_中指.ReverseX();
					this.ハンド右.X11Y0_人指.ReverseX();
					this.ハンド右.X11Y0_手.ReverseX();
					this.ハンド右.X11Y0_親指.ReverseX();
					this.ハンド右.X11Y0_呪印_輪1_輪外.ReverseX();
					this.ハンド右.X11Y0_呪印_輪1_輪内.ReverseX();
					this.ハンド右.X11Y0_呪印_輪2_輪外.ReverseX();
					this.ハンド右.X11Y0_呪印_輪2_輪内.ReverseX();
					this.ハンド右.X11Y0_呪印_輪3_輪外.ReverseX();
					this.ハンド右.X11Y0_呪印_輪3_輪内.ReverseX();
					this.ハンド右.X11Y0_呪印_鎖1.ReverseX();
					this.ハンド右.X11Y0_呪印_鎖3.ReverseX();
					this.ハンド右.本体.JoinPA();
				}
				else if (this.対象.Ele.右 && cp.X > this.xc)
				{
					this.対象.Ele.右 = !this.対象.Ele.右;
					this.対象.Ele.本体.JoinPA();
					this.ハンド右.X11Y0_小指.ReverseX();
					this.ハンド右.X11Y0_薬指.ReverseX();
					this.ハンド右.X11Y0_中指.ReverseX();
					this.ハンド右.X11Y0_人指.ReverseX();
					this.ハンド右.X11Y0_手.ReverseX();
					this.ハンド右.X11Y0_親指.ReverseX();
					this.ハンド右.X11Y0_呪印_輪1_輪外.ReverseX();
					this.ハンド右.X11Y0_呪印_輪1_輪内.ReverseX();
					this.ハンド右.X11Y0_呪印_輪2_輪外.ReverseX();
					this.ハンド右.X11Y0_呪印_輪2_輪内.ReverseX();
					this.ハンド右.X11Y0_呪印_輪3_輪外.ReverseX();
					this.ハンド右.X11Y0_呪印_輪3_輪内.ReverseX();
					this.ハンド右.X11Y0_呪印_鎖1.ReverseX();
					this.ハンド右.X11Y0_呪印_鎖3.ReverseX();
					this.ハンド右.本体.JoinPA();
				}
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
				Color 羽根箒先端hc = this.調教UI.羽根箒先端hc;
				if (mb == MouseButtons.Left && this.調教UI.Bod.IsHit(羽根箒先端hc))
				{
					this.調教UI.押し(ref cd);
					this.擽りモ\u30FCション.Sta();
					this.Is擽り = true;
					if (Sta.GameData.ガイド)
					{
						this.ip.SubInfoIm = this.擽り時();
					}
					this.調教UI.Action(this.Cha.GetContact(ref 羽根箒先端hc).c, アクション情報.接触, タイミング情報.開始, アイテム情報.羽根箒, 0, 1, false, false);
					Act.奴体力消費小();
					Act.主精力消費小();
					return;
				}
				if (mb == MouseButtons.Right && !this.Is擽り)
				{
					this.Is擽り = false;
					this.擽りモ\u30FCション.End();
					if (this.対象.Ele.右)
					{
						this.ハンド右.X11Y0_小指.ReverseX();
						this.ハンド右.X11Y0_薬指.ReverseX();
						this.ハンド右.X11Y0_中指.ReverseX();
						this.ハンド右.X11Y0_人指.ReverseX();
						this.ハンド右.X11Y0_手.ReverseX();
						this.ハンド右.X11Y0_親指.ReverseX();
						this.ハンド右.X11Y0_呪印_輪1_輪外.ReverseX();
						this.ハンド右.X11Y0_呪印_輪1_輪内.ReverseX();
						this.ハンド右.X11Y0_呪印_輪2_輪外.ReverseX();
						this.ハンド右.X11Y0_呪印_輪2_輪内.ReverseX();
						this.ハンド右.X11Y0_呪印_輪3_輪外.ReverseX();
						this.ハンド右.X11Y0_呪印_輪3_輪内.ReverseX();
						this.ハンド右.X11Y0_呪印_鎖1.ReverseX();
						this.ハンド右.X11Y0_呪印_鎖3.ReverseX();
						this.ハンド右.本体.JoinPA();
					}
					this.調教UI.通常放し();
					if (Sta.GameData.ガイド)
					{
						this.ip.SubInfoIm = " ";
					}
				}
			}
		}

		public void Up(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref 接触D cd)
		{
			if (this.調教UI.Focus == this.対象 && mb == MouseButtons.Left && this.Is擽り)
			{
				Color 羽根箒先端hc = this.調教UI.羽根箒先端hc;
				this.調教UI.Action(this.Cha.GetContact(ref 羽根箒先端hc).c, アクション情報.接触, タイミング情報.終了, アイテム情報.羽根箒, 0, 1, false, false);
				Act.奴体力消費小();
				Act.主精力消費小();
				this.擽りモ\u30FCション.End();
				this.調教UI.放し();
				this.Is擽り = false;
				if (Sta.GameData.ガイド)
				{
					this.ip.SubInfoIm = this.待機時();
				}
			}
		}

		public void Leave(ref MouseButtons mb, ref Vector2D cp, ref Color hc)
		{
		}

		public void Wheel(ref MouseButtons mb, ref Vector2D cp, ref int dt, ref Color hc, ref 接触D cd)
		{
			if (this.調教UI.Focus == this.対象)
			{
				this.強さ = (this.強さ + dt.Sign()).LimitM(1, 3);
				this.擽りモ\u30FCション.BaseSpeed = 10.0 * base.強度;
				if (!Sta.GameData.ガイド)
				{
					this.ip.SubInfoIm = "Wh:" + tex.強さL + this.強さ;
					return;
				}
				this.移動時();
			}
		}

		public 羽箒処理(調教UI 調教UI, CM 羽根箒)
		{
			羽箒処理.<>c__DisplayClass12_0 CS$<>8__locals1 = new 羽箒処理.<>c__DisplayClass12_0();
			CS$<>8__locals1.羽根箒 = 羽根箒;
			CS$<>8__locals1.調教UI = 調教UI;
			base..ctor(CS$<>8__locals1.調教UI, CS$<>8__locals1.羽根箒);
			CS$<>8__locals1.<>4__this = this;
			this.ハンド右 = CS$<>8__locals1.調教UI.ハンド右;
			this.xc = this.Med.Base.LocalCenter.X;
			Mot mot = new Mot(0.0, 1.0);
			mot.BaseSpeed = 16.0 * base.強度;
			mot.Staing = delegate(Mot m)
			{
			};
			Color hc;
			mot.Runing = delegate(Mot m)
			{
				CS$<>8__locals1.羽根箒.Ele.角度C = 10.0 * m.Value;
				hc = CS$<>8__locals1.調教UI.羽根箒先端hc;
				CS$<>8__locals1.調教UI.Action(CS$<>8__locals1.<>4__this.Cha.GetContact(ref hc).c, アクション情報.擽り, タイミング情報.継続, アイテム情報.羽根箒, 0, CS$<>8__locals1.<>4__this.強さ, false, false);
				Act.奴体力消費小();
				Act.主精力消費小();
			};
			mot.Reaing = delegate(Mot m)
			{
			};
			mot.Rouing = delegate(Mot m)
			{
			};
			mot.Ending = delegate(Mot m)
			{
				m.ResetValue();
				CS$<>8__locals1.羽根箒.Ele.角度C = 0.0;
			};
			this.擽りモ\u30FCション = mot;
			CS$<>8__locals1.調教UI.Mots.Add(this.擽りモ\u30FCション.GetHashCode().ToString(), this.擽りモ\u30FCション);
		}

		public void SetCha(Cha Cha)
		{
			this.Cha = Cha;
			this.Bod = Cha.Bod;
		}

		public new void Reset()
		{
			base.Reset();
			this.Is擽り = false;
			Mot 擽りモ_u30FCション = this.擽りモ\u30FCション;
			if (擽りモ_u30FCション == null)
			{
				return;
			}
			擽りモ_u30FCション.End();
		}

		public bool Is擽り;

		private Mot 擽りモ\u30FCション;

		private ハンド ハンド右;

		private readonly double xc;
	}
}
