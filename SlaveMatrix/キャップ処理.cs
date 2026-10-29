using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class キャップ処理 : 処理B
	{
		public void 吸着(Ele 対象)
		{
			this.調教UI.擬音キュ\u30FC.Enqueue(delegate(Are a)
			{
				this.調教UI.擬音.Sound(a, 対象.位置.GetAreaPoint(0.01), Sta.吸着.GetVal(1.0, 1.0), new Font("MS Gothic", 1f), Col.Black, 0.2, true);
			});
		}

		public void 吸脱(Ele 対象)
		{
			this.調教UI.擬音キュ\u30FC.Enqueue(delegate(Are a)
			{
				this.調教UI.擬音.Sound(a, 対象.位置.GetAreaPoint(0.01), Sta.吸脱.GetVal(1.0, 1.0), new Font("MS Gothic", 1f), Col.Black, 0.2, true);
			});
		}

		public void 振動(Ele 対象)
		{
			if ((対象 is キャップ1 && this.CP中.GetFlag(0.2)) || (対象 is キャップ2 && !対象.右 && this.CP左.GetFlag(0.2)) || (対象 is キャップ2 && 対象.右 && this.CP右.GetFlag(0.2)))
			{
				this.調教UI.擬音キュ\u30FC.Enqueue(delegate(Are a)
				{
					this.調教UI.擬音.Sound(a, 対象.位置.GetAreaPoint(0.02), Sta.振動.GetVal(1.0, 1.0), new Font("MS Gothic", 1f), Col.Black, 0.15, true);
				});
			}
		}

		public bool Is仮着
		{
			get
			{
				return (!this.キャップ中着 && this.Isキャップ1着()) || (!this.キャップ左着 && this.Isキャップ2左着()) || (!this.キャップ右着 && this.Isキャップ2右着());
			}
		}

		public bool キャップ中
		{
			get
			{
				return this.キャップ中_;
			}
			set
			{
				this.キャップ中_ = value;
				if (!this.キャップ中_)
				{
					this.Bod.キャップ1.位置C = Dat.Vec2DZero;
				}
				if (this.キャップ中_ || this.キャップ左_ || this.キャップ右_)
				{
					this.キャップ振動.Sta();
					return;
				}
				this.キャップ振動.End();
			}
		}

		public bool キャップ左
		{
			get
			{
				return this.キャップ左_;
			}
			set
			{
				this.キャップ左_ = value;
				if (!this.キャップ左_)
				{
					this.Bod.キャップ1.位置C = Dat.Vec2DZero;
				}
				if (this.キャップ中_ || this.キャップ左_ || this.キャップ右_)
				{
					this.キャップ振動.Sta();
					return;
				}
				this.キャップ振動.End();
			}
		}

		public bool キャップ右
		{
			get
			{
				return this.キャップ右_;
			}
			set
			{
				this.キャップ右_ = value;
				if (!this.キャップ右_)
				{
					this.Bod.キャップ1.位置C = Dat.Vec2DZero;
				}
				if (this.キャップ中_ || this.キャップ左_ || this.キャップ右_)
				{
					this.キャップ振動.Sta();
					return;
				}
				this.キャップ振動.End();
			}
		}

		public bool Isキャップ1着()
		{
			return this.Bod.Setキャップ1.Equals(this.キャップ着);
		}

		public bool Isキャップ2左着()
		{
			return this.Bod.Setキャップ2左.Equals(this.キャップ着);
		}

		public bool Isキャップ2右着()
		{
			return this.Bod.Setキャップ2右.Equals(this.キャップ着);
		}

		private void 切替時(bool 対象)
		{
			if (Sta.GameData.ガイド)
			{
				this.ip.SubInfoIm = "MCl:" + (対象 ? tex.停止 : tex.作動) + "\r\nLCl:" + tex.外す;
			}
		}

		private void 装着時()
		{
			if (Sta.GameData.ガイド)
			{
				this.ip.SubInfoIm = "LCl:" + tex.装着;
			}
		}

		private void 待機時()
		{
			if (Sta.GameData.ガイド)
			{
				if (this.ハンドf)
				{
					this.ip.SubInfoIm = "";
					return;
				}
				this.ip.SubInfoIm = "RCl:" + tex.放す;
			}
		}

		private void SetFocus(Vector2D p)
		{
			if (this.調教UI.Focus == this.キャップ1)
			{
				if (this.キャップ2.Show)
				{
					this.調教UI.Focus = this.キャップ2;
				}
				else if (this.キャップ3.Show)
				{
					this.調教UI.Focus = this.キャップ3;
				}
				else
				{
					this.ハンドf = true;
				}
				this.キャップ1.Show = false;
				this.キャップ1.使用状態 = 使用状態.装着;
			}
			else if (this.調教UI.Focus == this.キャップ2)
			{
				if (this.キャップ1.Show)
				{
					this.調教UI.Focus = this.キャップ1;
				}
				else if (this.キャップ3.Show)
				{
					this.調教UI.Focus = this.キャップ3;
				}
				else
				{
					this.ハンドf = true;
				}
				this.キャップ2.Show = false;
				this.キャップ2.使用状態 = 使用状態.装着;
			}
			else if (this.調教UI.Focus == this.キャップ3)
			{
				if (this.キャップ1.Show)
				{
					this.調教UI.Focus = this.キャップ1;
				}
				else if (this.キャップ2.Show)
				{
					this.調教UI.Focus = this.キャップ2;
				}
				else
				{
					this.ハンドf = true;
				}
				this.キャップ3.Show = false;
				this.キャップ3.使用状態 = 使用状態.装着;
			}
			this.調教UI.Focus.Ele.位置B = p;
			if (!this.ハンドf)
			{
				this.調教UI.Set持ち手();
			}
		}

		public void キャップ中外し()
		{
			if (this.キャップ中着)
			{
				this.キャップ中 = false;
				this.Bod.Setキャップ1 = this.キャップ脱;
				if (this.キャップ.ContainsKey(this.Bod.キャップ1))
				{
					this.キャップ[this.Bod.キャップ1].Show = true;
					this.キャップ[this.Bod.キャップ1].DraShow = true;
					this.キャップ[this.Bod.キャップ1].StaShow = true;
					this.キャップ[this.Bod.キャップ1].描画Show = true;
					this.キャップ[this.Bod.キャップ1].Ele.濃度 = 0.5;
					this.キャップ[this.Bod.キャップ1].使用状態 = 使用状態.待機;
					this.キャップ.Remove(this.Bod.キャップ1);
				}
				this.キャップ中着 = false;
			}
		}

		public void Move(ref MouseButtons mb, ref Vector2D cp, ref Vector2D op, ref Color hc, ref 接触D cd)
		{
			if (this.調教UI.Focus == this.調教UI.ハンド右CM)
			{
				if (!this.調教UI.ハンド処理.Isモ\u30FCド)
				{
					if (this.キャップ中着 && (cd.e is キャップ1 || cd.c == 接触.核))
					{
						this.調教UI.ハンド右.本体.IndexX = 5;
						this.調教UI.Set_キャップ中(this.調教UI.ハンド右);
						this.切替時(this.キャップ中);
					}
					else if (this.キャップ左着 && (cd.e is キャップ2 || cd.c == 接触.乳) && !cd.e.右)
					{
						this.調教UI.ハンド右CM.Show = false;
						this.調教UI.ハンド左表示 = true;
						this.調教UI.ハンド左.位置B = cp;
						this.調教UI.ハンド左.本体.IndexX = 5;
						this.調教UI.Set_キャップ左(this.調教UI.ハンド左);
						this.切替時(this.キャップ左);
					}
					else if (this.キャップ右着 && (cd.e is キャップ2 || cd.c == 接触.乳) && cd.e.右)
					{
						this.調教UI.ハンド右.本体.IndexX = 5;
						this.調教UI.Set_キャップ右(this.調教UI.ハンド右);
						this.切替時(this.キャップ右);
					}
					else if (cd.c != 接触.乳 && (this.キャップ中着 || this.キャップ左着 || this.キャップ右着) && (this.調教UI.ハンド右.本体.IndexX == 5 || this.調教UI.ハンド左.本体.IndexX == 5))
					{
						this.調教UI.ハンド左表示 = false;
						this.調教UI.ハンド右CM.Show = true;
						this.調教UI.ハンド右.本体.IndexX = 0;
						this.調教UI.ハンド左.本体.IndexX = 0;
					}
				}
			}
			else if (this.調教UI.Focus == this.キャップ1 || this.調教UI.Focus == this.キャップ2 || this.調教UI.Focus == this.キャップ3)
			{
				if (!this.キャップ中着 && (cd.e is キャップ1 || cd.c == 接触.核) && (this.Cha.ChaD.股施術 || (!this.Cha.Bod.Is蠍 && (!this.Cha.Bod.Is蛇 || !this.Cha.Bod.蛇.ガ\u30FCド))))
				{
					this.調教UI.押し(ref cd);
					this.調教UI.Focus.DraShow = false;
					this.Bod.Setキャップ1 = this.キャップ着;
					this.調教UI.Set_キャップ中(this.調教UI.ハンド右);
					this.装着時();
				}
				else if (!this.キャップ左着 && (cd.e is キャップ2 || cd.c == 接触.乳) && !cd.e.右)
				{
					this.調教UI.押し(ref cd);
					this.調教UI.Focus.DraShow = false;
					this.Bod.Setキャップ2左 = this.キャップ着;
					this.調教UI.Set_キャップ左(this.調教UI.ハンド右);
					this.装着時();
				}
				else if (!this.キャップ右着 && (cd.e is キャップ2 || cd.c == 接触.乳) && cd.e.右)
				{
					this.調教UI.押し(ref cd);
					this.調教UI.Focus.DraShow = false;
					this.Bod.Setキャップ2右 = this.キャップ着;
					this.調教UI.Set_キャップ右(this.調教UI.ハンド右);
					this.装着時();
				}
				else
				{
					if (!this.キャップ中着 && this.Isキャップ1着())
					{
						this.Bod.Setキャップ1 = this.キャップ脱;
						this.調教UI.Focus.DraShow = true;
						this.調教UI.放し();
					}
					else if (!this.キャップ左着 && this.Isキャップ2左着())
					{
						this.Bod.Setキャップ2左 = this.キャップ脱;
						this.調教UI.Focus.DraShow = true;
						this.調教UI.放し();
					}
					else if (!this.キャップ右着 && this.Isキャップ2右着())
					{
						this.Bod.Setキャップ2右 = this.キャップ脱;
						this.調教UI.Focus.DraShow = true;
						this.調教UI.放し();
					}
					this.待機時();
				}
			}
			if (this.ハンドf)
			{
				this.調教UI.Focus = this.調教UI.ハンド右CM;
				this.調教UI.Set持ち手();
				this.ハンドf = false;
			}
		}

		public void Down(ref MouseButtons mb, ref Vector2D cp, ref Vector2D op, ref Color hc, ref 接触D cd)
		{
			if (this.調教UI.Focus.Ele.濃度 == 1.0)
			{
				if (this.ハンドf)
				{
					this.調教UI.Focus = this.調教UI.ハンド右CM;
					this.ハンドf = false;
				}
				if (this.調教UI.Focus == this.調教UI.ハンド右CM)
				{
					if (this.キャップ中着 && (cd.e is キャップ1 || cd.c == 接触.核))
					{
						this.調教UI.押し(ref cd);
						if (mb == MouseButtons.Middle)
						{
							this.調教UI.Set_キャップ中(this.調教UI.ハンド右);
							this.キャップ中 = !this.キャップ中;
							this.切替時(this.キャップ中);
							if (this.キャップ中)
							{
								this.調教UI.Action(接触.核, アクション情報.核捏, タイミング情報.開始, アイテム情報.キャプ, 0, 1, false, false);
								Act.奴体力消費小();
								Act.主精力消費小();
								return;
							}
							this.調教UI.Action(接触.核, アクション情報.核捏, タイミング情報.終了, アイテム情報.キャプ, 0, 1, false, false);
							Act.奴体力消費小();
							Act.主精力消費小();
							return;
						}
						else if (!this.調教UI.ハンド処理.Is乳繰り && mb == MouseButtons.Left)
						{
							this.調教UI.Action(接触.核, アクション情報.吸引, タイミング情報.終了, アイテム情報.キャプ, 0, 1, false, false);
							Act.奴体力消費小();
							Act.主精力消費小();
							this.吸脱(this.Bod.キャップ1);
							this.切替時(this.キャップ中);
							this.キャップ中 = false;
							this.Bod.Setキャップ1 = this.キャップ脱;
							this.キャップ[this.Bod.キャップ1].Show = true;
							this.キャップ[this.Bod.キャップ1].DraShow = true;
							this.キャップ[this.Bod.キャップ1].StaShow = true;
							this.キャップ[this.Bod.キャップ1].描画Show = true;
							this.キャップ[this.Bod.キャップ1].Ele.濃度 = 0.5;
							this.キャップ[this.Bod.キャップ1].使用状態 = 使用状態.待機;
							this.キャップ.Remove(this.Bod.キャップ1);
							this.キャップ中着 = false;
							return;
						}
					}
					else if (this.キャップ左着 && (cd.e is キャップ2 || cd.c == 接触.乳) && !cd.e.右)
					{
						this.調教UI.押し(ref cd);
						if (mb == MouseButtons.Middle)
						{
							this.調教UI.Set_キャップ左(this.調教UI.ハンド左);
							this.キャップ左 = !this.キャップ左;
							this.切替時(this.キャップ左);
							if (this.キャップ左)
							{
								this.調教UI.Action(接触.乳, アクション情報.乳繰, タイミング情報.開始, アイテム情報.キャプ, 0, 1, false, false);
								Act.奴体力消費小();
								Act.主精力消費小();
								return;
							}
							this.調教UI.Action(接触.乳, アクション情報.乳繰, タイミング情報.終了, アイテム情報.キャプ, 0, 1, false, false);
							Act.奴体力消費小();
							Act.主精力消費小();
							return;
						}
						else if (!this.調教UI.ハンド処理.Is乳繰り && mb == MouseButtons.Left)
						{
							this.調教UI.Action(接触.乳, アクション情報.吸引, タイミング情報.終了, アイテム情報.キャプ, 0, 1, false, false);
							Act.奴体力消費小();
							Act.主精力消費小();
							this.吸脱(this.Bod.キャップ2左);
							this.切替時(this.キャップ左);
							this.キャップ左 = false;
							this.Bod.Setキャップ2左 = this.キャップ脱;
							this.キャップ[this.Bod.キャップ2左].Show = true;
							this.キャップ[this.Bod.キャップ2左].DraShow = true;
							this.キャップ[this.Bod.キャップ2左].StaShow = true;
							this.キャップ[this.Bod.キャップ2左].描画Show = true;
							this.キャップ[this.Bod.キャップ2左].Ele.濃度 = 0.5;
							this.キャップ[this.Bod.キャップ2左].使用状態 = 使用状態.待機;
							this.キャップ.Remove(this.Bod.キャップ2左);
							this.キャップ左着 = false;
							return;
						}
					}
					else if (this.キャップ右着 && (cd.e is キャップ2 || cd.c == 接触.乳) && cd.e.右)
					{
						this.調教UI.押し(ref cd);
						if (mb == MouseButtons.Middle)
						{
							this.調教UI.Set_キャップ右(this.調教UI.ハンド右);
							this.キャップ右 = !this.キャップ右;
							this.切替時(this.キャップ右);
							if (this.キャップ右)
							{
								this.調教UI.Action(接触.乳, アクション情報.乳繰, タイミング情報.開始, アイテム情報.キャプ, 0, 1, false, false);
								Act.奴体力消費小();
								Act.主精力消費小();
								return;
							}
							this.調教UI.Action(接触.乳, アクション情報.乳繰, タイミング情報.終了, アイテム情報.キャプ, 0, 1, false, false);
							Act.奴体力消費小();
							Act.主精力消費小();
							return;
						}
						else if (!this.調教UI.ハンド処理.Is乳繰り && mb == MouseButtons.Left)
						{
							this.調教UI.Action(接触.乳, アクション情報.吸引, タイミング情報.終了, アイテム情報.キャプ, 0, 1, false, false);
							Act.奴体力消費小();
							Act.主精力消費小();
							this.吸脱(this.Bod.キャップ2右);
							this.切替時(this.キャップ右);
							this.キャップ右 = false;
							this.Bod.Setキャップ2右 = this.キャップ脱;
							this.キャップ[this.Bod.キャップ2右].Show = true;
							this.キャップ[this.Bod.キャップ2右].DraShow = true;
							this.キャップ[this.Bod.キャップ2右].StaShow = true;
							this.キャップ[this.Bod.キャップ2右].描画Show = true;
							this.キャップ[this.Bod.キャップ2右].Ele.濃度 = 0.5;
							this.キャップ[this.Bod.キャップ2右].使用状態 = 使用状態.待機;
							this.キャップ.Remove(this.Bod.キャップ2右);
							this.キャップ右着 = false;
							return;
						}
					}
				}
				else if (this.調教UI.Focus == this.キャップ1 || this.調教UI.Focus == this.キャップ2 || this.調教UI.Focus == this.キャップ3)
				{
					if (mb == MouseButtons.Left)
					{
						if (!this.キャップ中着 && (cd.c == 接触.核 || cd.e == this.Bod.キャップ1) && (this.Cha.ChaD.股施術 || (!this.Cha.Bod.Is蠍 && (!this.Cha.Bod.Is蛇 || !this.Cha.Bod.蛇.ガ\u30FCド))))
						{
							this.Bod.Setキャップ1 = this.キャップ着;
							this.キャップ.Add(this.Bod.キャップ1, this.調教UI.Focus);
							this.キャップ中着 = true;
							this.SetFocus(this.Bod.キャップ1.位置);
							this.調教UI.Action(接触.核, アクション情報.吸引, タイミング情報.開始, アイテム情報.キャプ, 0, 1, false, false);
							Act.奴体力消費小();
							Act.主精力消費小();
							this.吸着(this.Bod.キャップ1);
						}
						else if (!this.キャップ左着 && (cd.c == 接触.乳 || cd.e == this.Bod.キャップ2左) && !cd.e.右)
						{
							this.Bod.Setキャップ2左 = this.キャップ着;
							this.キャップ.Add(this.Bod.キャップ2左, this.調教UI.Focus);
							this.キャップ左着 = true;
							this.SetFocus(this.Bod.キャップ2左.位置);
							this.調教UI.Action(接触.乳, アクション情報.吸引, タイミング情報.開始, アイテム情報.キャプ, 0, 1, false, false);
							Act.奴体力消費小();
							Act.主精力消費小();
							this.吸着(this.Bod.キャップ2左);
						}
						else if (!this.キャップ右着 && (cd.c == 接触.乳 || cd.e == this.Bod.キャップ2右) && cd.e.右)
						{
							this.Bod.Setキャップ2右 = this.キャップ着;
							this.キャップ.Add(this.Bod.キャップ2右, this.調教UI.Focus);
							this.キャップ右着 = true;
							this.SetFocus(this.Bod.キャップ2右.位置);
							this.調教UI.Action(接触.乳, アクション情報.吸引, タイミング情報.開始, アイテム情報.キャプ, 0, 1, false, false);
							Act.奴体力消費小();
							Act.主精力消費小();
							this.吸着(this.Bod.キャップ2右);
						}
					}
					else if (mb == MouseButtons.Right && !this.Is仮着)
					{
						this.調教UI.通常放し();
					}
					this.待機時();
					return;
				}
			}
			else if ((this.調教UI.Focus == this.キャップ1 || this.調教UI.Focus == this.キャップ2 || this.調教UI.Focus == this.キャップ3) && mb == MouseButtons.Right)
			{
				this.調教UI.通常放し();
			}
		}

		public void Up(ref MouseButtons mb, ref Vector2D cp, ref Color hc)
		{
			if (this.調教UI.Focus == this.調教UI.ハンド右CM)
			{
				this.調教UI.放し();
			}
		}

		public void Leave(ref MouseButtons mb, ref Vector2D cp, ref Color hc)
		{
		}

		public void Wheel(ref MouseButtons mb, ref Vector2D cp, ref int dt, ref Color hc)
		{
		}

		public キャップ処理(調教UI 調教UI)
		{
			キャップ処理.<>c__DisplayClass44_0 CS$<>8__locals1 = new キャップ処理.<>c__DisplayClass44_0();
			CS$<>8__locals1.調教UI = 調教UI;
			base..ctor(CS$<>8__locals1.調教UI);
			CS$<>8__locals1.<>4__this = this;
			double disUnit = CS$<>8__locals1.調教UI.Are.DisUnit;
			this.キャップ着.SetDefault();
			キャップ1D e = new キャップ1D();
			e.SetValuesD("表示", true);
			this.キャップ1 = new CM(this.Med, CS$<>8__locals1.調教UI, CS$<>8__locals1.調教UI.キャップ1 = new キャップ1(disUnit, 配色指定.N0, null, this.Med, e));
			this.キャップ2 = new CM(this.Med, CS$<>8__locals1.調教UI, CS$<>8__locals1.調教UI.キャップ2 = new キャップ1(disUnit, 配色指定.N0, null, this.Med, e));
			this.キャップ3 = new CM(this.Med, CS$<>8__locals1.調教UI, CS$<>8__locals1.調教UI.キャップ3 = new キャップ1(disUnit, 配色指定.N0, null, this.Med, e));
			キャップ色 配色 = default(キャップ色);
			配色.SetDefault();
			CS$<>8__locals1.調教UI.キャップ1.配色(配色);
			CS$<>8__locals1.調教UI.キャップ2.配色(配色);
			CS$<>8__locals1.調教UI.キャップ3.配色(配色);
			CS$<>8__locals1.調教UI.キャップ1.濃度 = 0.5;
			CS$<>8__locals1.調教UI.キャップ2.濃度 = 0.5;
			CS$<>8__locals1.調教UI.キャップ3.濃度 = 0.5;
			CS$<>8__locals1.調教UI.キャップ1CM = this.キャップ1;
			CS$<>8__locals1.調教UI.キャップ2CM = this.キャップ2;
			CS$<>8__locals1.調教UI.キャップ3CM = this.キャップ3;
			double d = 0.0005;
			Vector2D p = Dat.Vec2DZero;
			Mot mot = new Mot(-1.0, 1.0);
			mot.BaseSpeed = double.MaxValue;
			mot.Staing = delegate(Mot m)
			{
			};
			mot.Runing = delegate(Mot m)
			{
				if (CS$<>8__locals1.<>4__this.キャップ左_)
				{
					p.X = m.Value * d;
					p.Y = -p.X;
					CS$<>8__locals1.<>4__this.Bod.キャップ2左.位置C = p;
					CS$<>8__locals1.調教UI.Action(接触.乳, アクション情報.乳繰, タイミング情報.継続, アイテム情報.キャプ, 0, 1, true, false);
					Act.奴体力消費小();
					CS$<>8__locals1.<>4__this.振動(CS$<>8__locals1.<>4__this.Bod.キャップ2左);
				}
				if (CS$<>8__locals1.<>4__this.キャップ右_)
				{
					p.X = -m.Value * d;
					p.Y = p.X;
					CS$<>8__locals1.<>4__this.Bod.キャップ2右.位置C = p;
					CS$<>8__locals1.調教UI.Action(接触.乳, アクション情報.乳繰, タイミング情報.継続, アイテム情報.キャプ, 0, 1, true, false);
					Act.奴体力消費小();
					CS$<>8__locals1.<>4__this.振動(CS$<>8__locals1.<>4__this.Bod.キャップ2右);
				}
				if (CS$<>8__locals1.<>4__this.キャップ中_)
				{
					p.X = m.Value * d * 1.44;
					p.Y = 0.0;
					CS$<>8__locals1.<>4__this.Bod.キャップ1.位置C = p;
					CS$<>8__locals1.調教UI.Action(接触.核, アクション情報.核捏, タイミング情報.継続, アイテム情報.キャプ, 0, 1, true, false);
					Act.奴体力消費小();
					CS$<>8__locals1.<>4__this.振動(CS$<>8__locals1.<>4__this.Bod.キャップ1);
				}
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
				CS$<>8__locals1.<>4__this.Bod.キャップ2左.位置C = Dat.Vec2DZero;
				CS$<>8__locals1.<>4__this.Bod.キャップ2右.位置C = Dat.Vec2DZero;
				CS$<>8__locals1.<>4__this.Bod.キャップ1.位置C = Dat.Vec2DZero;
			};
			this.キャップ振動 = mot;
			CS$<>8__locals1.調教UI.Mots.Add(this.キャップ振動.GetHashCode().ToString(), this.キャップ振動);
		}

		public void SetCha(Cha Cha)
		{
			this.Cha = Cha;
			this.Bod = Cha.Bod;
		}

		public new void Reset()
		{
			if (this.キャップ中着)
			{
				this.キャップ中 = false;
				this.Bod.Setキャップ1 = this.キャップ脱;
				if (this.キャップ.ContainsKey(this.Bod.キャップ1))
				{
					this.キャップ.Remove(this.Bod.キャップ1);
				}
				this.キャップ中着 = false;
			}
			if (this.キャップ左着)
			{
				this.キャップ左 = false;
				this.Bod.Setキャップ2左 = this.キャップ脱;
				if (this.キャップ.ContainsKey(this.Bod.キャップ2左))
				{
					this.キャップ.Remove(this.Bod.キャップ2左);
				}
				this.キャップ左着 = false;
			}
			if (this.キャップ右着)
			{
				this.キャップ右 = false;
				this.Bod.Setキャップ2右 = this.キャップ脱;
				if (this.キャップ.ContainsKey(this.Bod.キャップ2右))
				{
					this.キャップ.Remove(this.Bod.キャップ2右);
				}
				this.キャップ右着 = false;
			}
			this.キャップ1.Show = true;
			this.キャップ1.DraShow = true;
			this.キャップ1.StaShow = true;
			this.キャップ1.描画Show = true;
			this.キャップ1.Ele.濃度 = 0.5;
			this.キャップ1.使用状態 = 使用状態.待機;
			this.キャップ2.Show = true;
			this.キャップ2.DraShow = true;
			this.キャップ2.StaShow = true;
			this.キャップ2.描画Show = true;
			this.キャップ2.Ele.濃度 = 0.5;
			this.キャップ2.使用状態 = 使用状態.待機;
			this.キャップ3.Show = true;
			this.キャップ3.DraShow = true;
			this.キャップ3.StaShow = true;
			this.キャップ3.描画Show = true;
			this.キャップ3.Ele.濃度 = 0.5;
			this.キャップ3.使用状態 = 使用状態.待機;
			base.Reset();
			this.CP中.Reset();
			this.CP左.Reset();
			this.CP右.Reset();
			this.キャップ.Clear();
			this.キャップ着 = default(キャップ情報);
			this.キャップ脱 = default(キャップ情報);
			this.キャップ中着 = false;
			this.キャップ左着 = false;
			this.キャップ右着 = false;
			this.ハンドf = false;
			Mot mot = this.キャップ振動;
			if (mot != null)
			{
				mot.End();
			}
			this.キャップ中_ = false;
			this.キャップ左_ = false;
			this.キャップ右_ = false;
			this.キャップ中 = false;
			this.キャップ左 = false;
			this.キャップ右 = false;
			this.キャップ着.SetDefault();
			this.調教UI.キャップ1.濃度 = 0.5;
			this.調教UI.キャップ2.濃度 = 0.5;
			this.調教UI.キャップ3.濃度 = 0.5;
		}

		public ConstProp CP中 = new ConstProp();

		public ConstProp CP左 = new ConstProp();

		public ConstProp CP右 = new ConstProp();

		public CM キャップ1;

		public CM キャップ2;

		public CM キャップ3;

		private Dictionary<Ele, CM> キャップ = new Dictionary<Ele, CM>();

		private キャップ情報 キャップ着;

		private キャップ情報 キャップ脱;

		public bool キャップ中着;

		public bool キャップ左着;

		public bool キャップ右着;

		private bool ハンドf;

		private Mot キャップ振動;

		private bool キャップ中_;

		private bool キャップ左_;

		private bool キャップ右_;
	}
}
