using System;
using System.Drawing;
using System.Windows.Forms;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 剃刀処理 : 処理B
	{
		public void 剃り()
		{
			if (this.CP.GetFlag(0.1 * this.Cha.ChaD.現陰毛))
			{
				this.調教UI.擬音キュ\u30FC.Enqueue(delegate(Are a)
				{
					this.調教UI.擬音.Sound(a, this.対象.Ele.位置.GetAreaPoint(0.01), Sta.剃り.GetVal(this.Cha.ChaD.現陰毛, OthN.XS.NextDouble()), new Font("MS Gothic", 1f), Col.Black, 0.1 + 0.1 * OthN.XS.NextDouble(), true);
				});
			}
		}

		private void 待機時()
		{
			if (Sta.GameData.ガイド)
			{
				this.ip.SubInfoIm = "RCl:" + tex.放す;
			}
		}

		private void 押し当て時()
		{
			if (Sta.GameData.ガイド)
			{
				this.ip.SubInfoIm = "LUp:" + tex.離す + "\r\nMo:" + tex.剃る;
			}
		}

		private void オ\u30FCバ\u30FC時()
		{
			if (Sta.GameData.ガイド)
			{
				this.ip.SubInfoIm = "LDo:" + tex.当てる;
			}
		}

		private void 移動時(ref Color hc)
		{
			this.p = null;
			if (this.Bod.腰肌_人 != null && this.Bod.腰肌_人.本体.IsHit(ref hc))
			{
				this.p = this.Bod.腰肌_人.本体.GetHitPar_(hc);
			}
			if (this.p != null && (this.p.Tag == "獣毛" || this.p.Tag == "陰毛"))
			{
				this.オ\u30FCバ\u30FC時();
				return;
			}
			this.待機時();
		}

		public void Move(ref MouseButtons mb, ref Vector2D cp, ref Vector2D op, ref Color hc, ref 接触D cd)
		{
			if (this.調教UI.Focus == this.対象)
			{
				if (mb == MouseButtons.Left && this.Is剃り)
				{
					if (this.調教UI.IsHitCha(ref cd))
					{
						this.調教UI.押し(ref cd);
						this.v = op - cp;
						this.a = -this.v.Angle02π(-Dat.Vec2DUnitY).ToDegree();
						if (!double.IsNaN(this.a))
						{
							this.対象.Ele.角度C = this.a;
						}
						this.調教UI.Action(cd.c, アクション情報.剃り, タイミング情報.継続, アイテム情報.Ｔ剃刀, 0, 1, false, false);
						Act.奴体力消費小();
						Act.主精力消費小();
						this.剃り();
						this.Cha.ChaD.現陰毛 = (this.Cha.ChaD.現陰毛 - 0.01).LimitM(0.0, 1.0);
						this.Cha.Bod.腰肌_人.陰毛CD.不透明度 = this.Cha.ChaD.現陰毛 * this.Cha.ChaD.最陰毛濃度;
						this.Cha.Bod.腰肌_人.獣性_獣毛CD.不透明度 = this.Cha.ChaD.現陰毛;
						this.Cha.Bod.腰肌_人.陰毛_ハ\u30FCトCD.不透明度 = this.Cha.ChaD.現陰毛.Inverse() * this.Cha.ChaD.最陰毛濃度;
					}
					else if (this.調教UI.押し状態)
					{
						this.調教UI.Action(cd.c, アクション情報.剃り, タイミング情報.終了, アイテム情報.Ｔ剃刀, 0, 1, false, false);
						Act.奴体力消費小();
						Act.主精力消費小();
						this.対象.Ele.角度C = 0.0;
						this.調教UI.放し();
					}
					this.押し当て時();
					return;
				}
				this.移動時(ref hc);
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
				this.p = null;
				if (this.Bod.腰肌_人 != null && this.Bod.腰肌_人.本体.IsHit(ref hc))
				{
					this.p = this.Bod.腰肌_人.本体.GetHitPar_(hc);
				}
				if (mb == MouseButtons.Left && this.p != null && (this.p.Tag == "獣毛" || this.p.Tag == "陰毛"))
				{
					this.調教UI.押し(ref cd);
					this.Is剃り = true;
					this.押し当て時();
					this.調教UI.Action(cd.c, アクション情報.剃り, タイミング情報.開始, アイテム情報.Ｔ剃刀, 0, 1, false, false);
					Act.奴体力消費小();
					Act.主精力消費小();
					return;
				}
				if (mb == MouseButtons.Right && !this.Is剃り)
				{
					this.Is剃り = false;
					this.対象.Ele.角度C = 0.0;
					this.調教UI.通常放し();
				}
			}
		}

		public void Up(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref 接触D cd)
		{
			if (this.調教UI.Focus == this.対象 && mb == MouseButtons.Left && this.Is剃り)
			{
				this.調教UI.Action(cd.c, アクション情報.剃り, タイミング情報.終了, アイテム情報.Ｔ剃刀, 0, 1, false, false);
				Act.奴体力消費小();
				Act.主精力消費小();
				this.調教UI.放し();
				this.対象.Ele.角度C = 0.0;
				this.Is剃り = false;
				this.移動時(ref hc);
			}
		}

		public void Leave(ref MouseButtons mb, ref Vector2D cp, ref Color hc)
		{
		}

		public void Wheel(ref MouseButtons mb, ref Vector2D cp, ref int dt, ref Color hc)
		{
		}

		public 剃刀処理(調教UI 調教UI, CM T剃刀) : base(調教UI, T剃刀)
		{
		}

		public void SetCha(Cha Cha)
		{
			this.Cha = Cha;
			this.Bod = Cha.Bod;
		}

		public new void Reset()
		{
			base.Reset();
			this.CP.Reset();
			this.Is剃り = false;
			this.v = default(Vector2D);
			this.a = 0.0;
			this.p = null;
		}

		public ConstProp CP = new ConstProp();

		private bool Is剃り;

		private Vector2D v;

		private double a;

		private Par p;
	}
}
