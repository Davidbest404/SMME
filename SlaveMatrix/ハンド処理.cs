using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class ハンド処理 : 処理B
	{
		public void くぱ()
		{
			this.調教UI.擬音キュ\u30FC.Enqueue(delegate(Are a)
			{
				this.調教UI.擬音.Sound(a, this.Bod.膣口位置.GetAreaPoint(0.01), Sta.くぱ.GetVal(Act.変化V_膣, Act.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.DeepPink.S(Act.変化V_膣.LimitM(0.5, 1.0)), 0.2 + 0.2 * OthN.XS.NextDouble() * Act.変化V_膣, true);
			});
		}

		public bool Isモ\u30FCド
		{
			get
			{
				return this.Is乳繰り || this.Is乳摘み || this.Is乳捏ね || this.Is核捏ね || this.Isくぱぁ || this.Is体撫で || this.調教UI.ハンド挿入.Is挿入;
			}
		}

		private void 乳繰りモ\u30FCド(ref 接触D cd)
		{
			this.Is乳繰り = true;
			this.箇所 = cd.c;
			this.調教UI.ハンド右CM.Show = true;
			this.調教UI.Set_乳首(this.調教UI.ハンド右, true);
			this.調教UI.Set_乳首(this.調教UI.ハンド左, false);
			this.乳繰りsi();
		}

		private void 乳繰り解除()
		{
			this.Is乳繰り = false;
			this.調教UI.ハンド右.Yi = 0;
			this.調教UI.ハンド左.Yi = 0;
		}

		private void 乳繰りsi()
		{
			if (Sta.GameData.ガイド)
			{
				this.ip.SubInfoIm = string.Concat(new string[]
				{
					tex.乳首,
					"\r\nLDo:",
					tex.摘む,
					"\r\nWh:",
					tex.繰る
				});
			}
		}

		private void 乳摘みモ\u30FCド(ref 接触D cd)
		{
			this.調教UI.ハンド右.Xi = 5;
			this.調教UI.ハンド右.Yi = 0;
			this.調教UI.ハンド左.Xi = 5;
			this.調教UI.ハンド左.Yi = 0;
			this.Is乳摘み = true;
			this.箇所 = cd.c;
			this.調教UI.ハンド右CM.Show = true;
			this.調教UI.Set_乳首(this.調教UI.ハンド右, true);
			this.調教UI.Set_乳首(this.調教UI.ハンド左, false);
			Vector2D 位置 = this.調教UI.ハンド右.位置;
			this.Addvl(ref 位置);
			this.乳摘みsi();
		}

		private void 乳摘み解除()
		{
			this.Is乳摘み = false;
			this.vl.Clear();
			this.調教UI.ハンド右.Yi = 0;
			this.調教UI.ハンド左.Yi = 0;
			this.Bod.乳房右.尺度XC = 1.0;
			this.Bod.乳房左.尺度XC = 1.0;
			this.調教UI.ハンド右.角度C = 0.0;
			this.調教UI.ハンド左.角度C = 0.0;
			if (this.Med.Mode == "調教")
			{
				Cursor.Position = this.Med.BaseControlC.PointToScreen(this.Med.FromBasePosition(this.対象.Ele.位置B));
			}
			this.バスト初期化.Sta();
			if (this.調教UI.ハンド右.Xi == 5)
			{
				this.乳繰りsi();
			}
		}

		private void 乳摘みsi()
		{
			if (Sta.GameData.ガイド)
			{
				this.ip.SubInfoIm = string.Concat(new string[]
				{
					tex.乳首,
					"\r\nMo:",
					tex.動かす,
					"\r\nLUp:",
					tex.放す
				});
			}
		}

		private void 乳捏ねモ\u30FCド(ref 接触D cd)
		{
			this.調教UI.ハンド右.Xi = 2;
			this.調教UI.ハンド右.Yi = 0;
			this.調教UI.ハンド左.Xi = 2;
			this.調教UI.ハンド左.Yi = 0;
			this.Is乳捏ね = true;
			this.箇所 = cd.c;
			this.調教UI.ハンド右CM.Show = true;
			this.調教UI.Set_乳房(this.調教UI.ハンド右, true);
			this.調教UI.Set_乳房(this.調教UI.ハンド左, false);
			Vector2D 位置 = this.調教UI.ハンド右.位置;
			this.Addvl(ref 位置);
			this.乳捏ねsi2();
		}

		private void 乳捏ね解除()
		{
			this.Is乳捏ね = false;
			this.vl.Clear();
			this.調教UI.ハンド右.Yi = 0;
			this.調教UI.ハンド左.Yi = 0;
			this.Bod.乳房右.尺度XC = 1.0;
			this.Bod.乳房左.尺度XC = 1.0;
			this.Bod.乳房右.尺度C = 1.0;
			this.Bod.乳房左.尺度C = 1.0;
			this.調教UI.ハンド右.角度C = 0.0;
			this.調教UI.ハンド左.角度C = 0.0;
			if (this.Med.Mode == "調教")
			{
				Cursor.Position = this.Med.BaseControlC.PointToScreen(this.Med.FromBasePosition(this.対象.Ele.位置B));
			}
			this.バスト初期化.Sta();
			if (this.調教UI.ハンド右.Xi == 2)
			{
				this.乳捏ねsi1();
			}
		}

		private void 乳捏ねsi1()
		{
			if (Sta.GameData.ガイド)
			{
				this.ip.SubInfoIm = tex.乳房 + "\r\nLDo:" + tex.掴む;
			}
		}

		private void 乳捏ねsi2()
		{
			if (Sta.GameData.ガイド)
			{
				this.ip.SubInfoIm = string.Concat(new string[]
				{
					tex.乳房,
					"\r\nMo:",
					tex.捏ねる,
					"\r\nLUp:",
					tex.放す
				});
			}
		}

		private void 核捏ねモ\u30FCド(ref 接触D cd)
		{
			this.調教UI.ハンド右.Xi = 6;
			this.調教UI.ハンド右.Yi = 0;
			this.Is核捏ね = true;
			this.箇所 = cd.c;
			Vector2D 陰核位置 = this.Bod.陰核位置;
			Vector2D 位置B = 陰核位置 + Dat.Vec2DUnitY * 0.0015;
			this.調教UI.ハンド右.位置B = 位置B;
			this.Addvl(ref 陰核位置);
			this.核捏ね初 = true;
			Cursor.Position = this.Med.BaseControlC.PointToScreen(this.Med.FromBasePosition(this.対象.Ele.位置B));
			this.核捏ねsi2();
		}

		private void 核捏ね解除()
		{
			this.Is核捏ね = false;
			this.vl.Clear();
			this.調教UI.ハンド右.Yi = 0;
			this.調教UI.ハンド右.角度C = 0.0;
			this.Bod.ピアス.位置C = Dat.Vec2DZero;
			if (this.Med.Mode == "調教")
			{
				Cursor.Position = this.Med.BaseControlC.PointToScreen(this.Med.FromBasePosition(this.対象.Ele.位置B));
			}
		}

		private void 核捏ねsi1()
		{
			if (Sta.GameData.ガイド)
			{
				this.ip.SubInfoIm = tex.陰核 + "\r\nLDo:" + tex.触れる;
			}
		}

		private void 核捏ねsi2()
		{
			if (Sta.GameData.ガイド)
			{
				this.ip.SubInfoIm = string.Concat(new string[]
				{
					tex.陰核,
					"\r\nMo:",
					tex.捏ねる,
					"\r\nLUp:",
					tex.離す
				});
			}
		}

		private void くぱぁモ\u30FCド(ref 接触D cd)
		{
			this.調教UI.ハンド右.Xi = 1;
			this.調教UI.ハンド右.Yi = 0;
			this.調教UI.ハンド左.Xi = 1;
			this.調教UI.ハンド左.Yi = 0;
			this.Isくぱぁ = true;
			this.箇所 = cd.c;
			this.調教UI.ハンド右CM.Show = true;
			this.調教UI.Set_くぱぁ(this.調教UI.ハンド右, true);
			this.調教UI.Set_くぱぁ(this.調教UI.ハンド左, false);
			this.くぱぁ = this.Bod.性器.くぱぁ;
			this.Bod.性器.くぱぁ = 1.0;
			this.くぱぁsi2();
		}

		private void くぱぁ解除(ref 接触D cd)
		{
			this.Bod.性器.くぱぁ = this.くぱぁ;
			this.Isくぱぁ = false;
			if (this.Med.Mode == "調教")
			{
				Cursor.Position = this.Med.BaseControlC.PointToScreen(this.Med.FromBasePosition(this.対象.Ele.位置B));
			}
			if (cd.c == 接触.股)
			{
				this.くぱぁsi1();
			}
		}

		private void くぱぁsi1()
		{
			if (Sta.GameData.ガイド)
			{
				this.ip.SubInfoIm = tex.陰唇 + "\r\nLDo:" + tex.広げる;
			}
		}

		private void くぱぁsi2()
		{
			if (Sta.GameData.ガイド)
			{
				this.ip.SubInfoIm = tex.陰唇 + "\r\nLUp:" + tex.やめる;
			}
		}

		private void 体撫でモ\u30FCド(ref 接触D cd)
		{
			this.Is体撫で = true;
			this.箇所 = cd.c;
			this.体撫でsi2();
		}

		private void 体撫で解除()
		{
			this.Is体撫で = false;
			this.調教UI.ハンド右.角度C = 0.0;
			if (this.調教UI.ハンド右.Xi == 3)
			{
				this.体撫でsi1();
			}
		}

		private void 体撫でsi1()
		{
			if (Sta.GameData.ガイド)
			{
				this.ip.SubInfoIm = "LDo:" + tex.触れる;
			}
		}

		private void 体撫でsi2()
		{
			if (Sta.GameData.ガイド)
			{
				this.ip.SubInfoIm = "Mo:" + tex.撫でる + "\r\nLUp:" + tex.離す;
			}
		}

		private string si()
		{
			if (!this.Isモ\u30FCド)
			{
				return (this.調教UI.マウス挿入.挿抜モ\u30FCション.Run ? "" : ("MCl:" + tex.マウス切替 + "\r\n")) + (this.調教UI.ペニス挿入.挿抜モ\u30FCション.Run ? "" : ("RCl:" + tex.ペニス切替));
			}
			return "";
		}

		private void 乳捏ね(ref Vector2D cp)
		{
			double num = (this.調教UI.ハンド右.位置B - this.GetCenter()).Angle02π(Dat.Vec2DUnitY).ToDegree();
			if (!double.IsNaN(num))
			{
				this.Bod.乳房右.Yi = (int)((360.0 - num) / this.u);
				this.Bod.乳房左.Yi = this.Bod.乳房右.Yi;
				if (this.Bod.乳房右.Yi == 1 || this.Bod.乳房右.Yi == 2)
				{
					this.Bod.乳房右.尺度XC = 0.95 + 0.05 * this.Bod.乳房右.バスト.Inverse();
					this.Bod.乳房左.尺度XC = this.Bod.乳房右.尺度XC;
					return;
				}
				this.Bod.乳房右.尺度XC = 1.0;
				this.Bod.乳房左.尺度XC = 1.0;
			}
		}

		private void 核捏ね(ref Vector2D cp)
		{
			double num = (this.o.X - this.v.X) * 0.008;
			Vector2D 陰核位置 = this.Bod.陰核位置;
			Vector2D coord = 陰核位置 + Dat.Vec2DUnitY * 0.0015;
			double num2 = Dat.Vec2DUnitY.Angle02π(this.調教UI.ハンド右.位置B - this.GetCenter());
			if (!double.IsNaN(num2))
			{
				this.調教UI.ハンド右.位置B = coord.TransformCoordinateBP(陰核位置, num2.RotationZ());
				this.Bod.ピアス.位置C = (this.調教UI.ハンド右.位置B - this.Bod.ピアス.位置B) * 0.3;
			}
			this.対象.Ele.角度C = (100.0 * num).LimitM(-5.0, 5.0);
		}

		private bool Is撫で()
		{
			return this.箇所 == 接触.頭 || this.箇所 == 接触.顔 || this.箇所 == 接触.耳 || this.箇所 == 接触.髪 || this.箇所 == 接触.首 || this.箇所 == 接触.肩 || this.箇所 == 接触.脇 || this.箇所 == 接触.腹 || this.箇所 == 接触.腿 || this.箇所 == 接触.足 || this.箇所 == 接触.手 || this.箇所 == 接触.覚 || this.箇所 == 接触.触 || this.箇所 == 接触.尾 || this.箇所 == 接触.翼 || this.箇所 == 接触.鰭 || this.箇所 == 接触.他;
		}

		private bool Is撫で(ref 接触D cd)
		{
			return cd.c == 接触.頭 || cd.c == 接触.顔 || cd.c == 接触.耳 || cd.c == 接触.髪 || cd.c == 接触.首 || cd.c == 接触.肩 || cd.c == 接触.脇 || cd.c == 接触.腹 || cd.c == 接触.腿 || cd.c == 接触.足 || cd.c == 接触.手 || cd.c == 接触.覚 || cd.c == 接触.触 || cd.c == 接触.尾 || cd.c == 接触.翼 || cd.c == 接触.鰭 || cd.c == 接触.他;
		}

		private void Addvl(ref Vector2D v)
		{
			this.vl.Add(v);
			if (this.vl.Count > 16)
			{
				this.vl.RemoveAt(0);
			}
		}

		private Vector2D GetCenter()
		{
			this.vs = Dat.Vec2DZero;
			foreach (Vector2D right in this.vl)
			{
				this.vs += right;
			}
			return this.vs / (double)this.vl.Count;
		}

		public void Move(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref 接触D cd)
		{
			if (this.調教UI.Focus == this.対象 && !this.バスト初期化.Run)
			{
				this.v = Cursor.Position.ToVector2D();
				this.x = (this.o.X - this.v.X) * 0.008;
				if (this.Isモ\u30FCド)
				{
					if (this.Is乳摘み)
					{
						this.yi = this.Bod.乳房左.Yi;
						this.乳捏ね(ref cp);
						this.調教UI.Set_乳首(this.調教UI.ハンド右, true);
						this.調教UI.Set_乳首(this.調教UI.ハンド左, false);
						this.Addvl(ref cp);
						this.調教UI.ハンド右.角度C = (100.0 * this.x).LimitM(-15.0, 5.0);
						this.調教UI.ハンド左.角度C = (-100.0 * this.x).LimitM(-5.0, 15.0);
						if (this.yi != this.Bod.乳房左.Yi && this.Bod.乳房左.Yi == 1)
						{
							this.Bod.胸左右前後 = !this.Bod.胸左右前後;
						}
						this.調教UI.Action(接触.乳, アクション情報.乳摘, タイミング情報.継続, アイテム情報.ハンド, 0, 1, false, false);
						Act.奴体力消費小();
						Act.主精力消費小();
					}
					else if (this.Is乳繰り)
					{
						this.調教UI.Set_乳首(this.調教UI.ハンド右, true);
						this.調教UI.Set_乳首(this.調教UI.ハンド左, false);
						if (cd.c != 接触.乳 && cd.c != 接触.胸)
						{
							this.乳繰り解除();
							this.調教UI.放し();
							this.調教UI.Action(接触.乳, アクション情報.乳繰, タイミング情報.終了, アイテム情報.ハンド, 0, 1, false, false);
							Act.奴体力消費小();
							Act.主精力消費小();
						}
					}
					else if (this.Is乳捏ね)
					{
						this.yi = this.Bod.乳房左.Yi;
						this.乳捏ね(ref cp);
						this.調教UI.Set_乳房(this.調教UI.ハンド右, true);
						this.調教UI.Set_乳房(this.調教UI.ハンド左, false);
						this.Addvl(ref cp);
						this.調教UI.ハンド右.角度C = (100.0 * this.x).LimitM(-15.0, 5.0);
						this.調教UI.ハンド左.角度C = (-100.0 * this.x).LimitM(-5.0, 15.0);
						if (this.yi != this.Bod.乳房左.Yi && this.Bod.乳房左.Yi == 1)
						{
							this.Bod.胸左右前後 = !this.Bod.胸左右前後;
						}
						this.調教UI.Action(接触.胸, アクション情報.乳捏, タイミング情報.継続, アイテム情報.ハンド, 0, 1, false, false);
						Act.奴体力消費小();
						Act.主精力消費小();
					}
					else if (this.Is核捏ね)
					{
						if (this.核捏ね初)
						{
							this.核捏ね初 = false;
						}
						else
						{
							this.核捏ね(ref cp);
							this.Addvl(ref cp);
							this.調教UI.Action(接触.核, アクション情報.核捏, タイミング情報.継続, アイテム情報.ハンド, 0, 1, false, false);
							Act.奴体力消費小();
							Act.主精力消費小();
						}
					}
					else if (this.Isくぱぁ)
					{
						this.調教UI.Set_くぱぁ(this.調教UI.ハンド右, true);
						this.調教UI.Set_くぱぁ(this.調教UI.ハンド左, false);
					}
					else if (this.Is体撫で)
					{
						this.調教UI.ハンド右CM.Show = true;
						this.調教UI.ハンド左表示 = false;
						this.調教UI.ハンド右.Xi = 3;
						this.調教UI.ハンド右.Yi = 0;
						if (this.調教UI.IsHitCha(ref cd))
						{
							this.調教UI.押し(ref cd);
							this.対象.Ele.角度C = (100.0 * this.x).LimitM(-45.0, 45.0);
							this.調教UI.Action(cd.c, アクション情報.接触, タイミング情報.継続, アイテム情報.ハンド, 0, 1, false, false);
							Act.奴体力消費小();
							Act.主精力消費小();
						}
						else if (this.調教UI.押し状態)
						{
							this.調教UI.Action(cd.c, アクション情報.接触, タイミング情報.継続, アイテム情報.ハンド, 0, 1, false, false);
							Act.奴体力消費小();
							Act.主精力消費小();
							this.対象.Ele.角度C = 0.0;
							this.調教UI.放し();
						}
						this.体撫でsi2();
					}
					else
					{
						this.調教UI.ハンド挿入.Move(ref mb, ref cp, ref hc, ref cd);
					}
				}
				else if (cd.c == 接触.乳)
				{
					this.調教UI.ハンド右CM.Show = cd.e.右;
					this.調教UI.ハンド左表示 = !cd.e.右;
					if (this.調教UI.ハンド左表示)
					{
						this.調教UI.ハンド左.位置B = cp;
					}
					this.調教UI.ハンド右.Xi = 5;
					this.調教UI.ハンド右.Yi = 0;
					this.調教UI.ハンド左.Xi = 5;
					this.調教UI.ハンド左.Yi = 0;
					this.調教UI.Set_乳首(this.調教UI.ハンド右, true);
					this.調教UI.Set_乳首(this.調教UI.ハンド左, false);
					this.乳繰りsi();
				}
				else if (cd.c == 接触.胸)
				{
					this.調教UI.ハンド右CM.Show = cd.e.右;
					this.調教UI.ハンド左表示 = !cd.e.右;
					if (this.調教UI.ハンド左表示)
					{
						this.調教UI.ハンド左.位置B = cp;
					}
					this.調教UI.ハンド右.Xi = 2;
					this.調教UI.ハンド右.Yi = 0;
					this.調教UI.ハンド左.Xi = 2;
					this.調教UI.ハンド左.Yi = 0;
					this.乳捏ねsi1();
				}
				else if (cd.c == 接触.核)
				{
					this.調教UI.ハンド右CM.Show = true;
					this.調教UI.ハンド左表示 = false;
					this.調教UI.ハンド右.Xi = 6;
					this.調教UI.ハンド右.Yi = 0;
					this.調教UI.Set_陰核(this.調教UI.ハンド右);
					this.核捏ねsi1();
				}
				else if ((Act.フェラ1 && cd.c == 接触.口 && !this.調教UI.Is口挿入) || (cd.c == 接触.膣 && !this.調教UI.Is膣挿入) || (cd.c == 接触.肛 && !this.調教UI.Is肛挿入) || (cd.c == 接触.糸 && !this.調教UI.Is糸挿入))
				{
					this.調教UI.ハンド右CM.Show = true;
					this.調教UI.ハンド左表示 = false;
					接触 c = cd.c;
					if (c != 接触.口)
					{
						switch (c)
						{
						case 接触.膣:
							if (Act.手膣)
							{
								this.調教UI.ハンド右.Xi = 8;
							}
							else
							{
								this.調教UI.ハンド右.Xi = 7;
							}
							break;
						case 接触.肛:
							if (Act.手肛)
							{
								this.調教UI.ハンド右.Xi = 8;
							}
							else
							{
								this.調教UI.ハンド右.Xi = 7;
							}
							break;
						case 接触.糸:
							if (Act.手糸)
							{
								this.調教UI.ハンド右.Xi = 8;
							}
							else
							{
								this.調教UI.ハンド右.Xi = 7;
							}
							break;
						}
					}
					else if (Act.手口)
					{
						this.調教UI.ハンド右.Xi = 8;
					}
					else
					{
						this.調教UI.ハンド右.Xi = 7;
					}
					this.調教UI.ハンド右.Yi = 0;
					this.調教UI.ハンド挿入.Move(ref mb, ref cp, ref hc, ref cd);
				}
				else if (cd.c == 接触.股)
				{
					this.くぱぁsi1();
				}
				else if (this.Is撫で(ref cd))
				{
					this.調教UI.ハンド右CM.Show = true;
					this.調教UI.ハンド左表示 = false;
					this.調教UI.ハンド右.Xi = 3;
					this.調教UI.ハンド右.Yi = 0;
					this.体撫でsi1();
				}
				else if (this.調教UI.ハンド右CM.Ele.Xi == 2 || this.調教UI.ハンド右CM.Ele.Xi == 3 || this.調教UI.ハンド右CM.Ele.Xi == 5 || this.調教UI.ハンド右CM.Ele.Xi == 6 || this.調教UI.ハンド右CM.Ele.Xi == 7 || this.調教UI.ハンド右CM.Ele.Xi == 8 || this.調教UI.ハンド右CM.Ele.Xi == 10)
				{
					this.調教UI.ハンド左表示 = false;
					this.調教UI.ハンド右CM.Show = true;
					if (cd.e == null)
					{
						this.調教UI.ハンド右.Xi = 0;
					}
					this.調教UI.ハンド右.Yi = 0;
					this.調教UI.ハンド左.Xi = 0;
					this.調教UI.ハンド左.Yi = 0;
					this.乳繰り解除();
					if (Sta.GameData.ガイド)
					{
						this.ip.SubInfoIm = this.si();
					}
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
					if (cd.c == 接触.乳 && ((!cd.e.右 && !this.調教UI.キャップ処理.キャップ左着) || (cd.e.右 && !this.調教UI.キャップ処理.キャップ右着)))
					{
						this.調教UI.押し(ref cd);
						this.乳摘みモ\u30FCド(ref cd);
						this.乳捏ね(ref cp);
						this.調教UI.Action(接触.乳, アクション情報.乳摘, タイミング情報.開始, アイテム情報.ハンド, 0, 1, false, false);
						Act.奴体力消費小();
						Act.主精力消費小();
						this.調教UI.乳首演出();
						this.調教UI.腕修正();
						this.調教UI.脚修正();
						return;
					}
					if (cd.c == 接触.胸)
					{
						this.調教UI.押し(ref cd);
						this.乳捏ねモ\u30FCド(ref cd);
						this.乳捏ね(ref cp);
						this.調教UI.Action(接触.胸, アクション情報.乳捏, タイミング情報.開始, アイテム情報.ハンド, 0, 1, false, false);
						Act.奴体力消費小();
						Act.主精力消費小();
						this.調教UI.乳房演出();
						this.調教UI.腕修正();
						this.調教UI.脚修正();
						return;
					}
					if (cd.c == 接触.核 && !this.調教UI.キャップ処理.キャップ中着)
					{
						this.調教UI.押し(ref cd);
						this.核捏ねモ\u30FCド(ref cd);
						this.核捏ね(ref cp);
						this.調教UI.Action(接触.核, アクション情報.核捏, タイミング情報.開始, アイテム情報.ハンド, 0, 1, false, false);
						Act.奴体力消費小();
						Act.主精力消費小();
						this.調教UI.陰核演出();
						this.調教UI.腕修正();
						this.調教UI.脚修正();
						return;
					}
					if (cd.c == 接触.股 && !this.Isモ\u30FCド)
					{
						this.調教UI.押し(ref cd);
						this.くぱぁモ\u30FCド(ref cd);
						this.調教UI.Action(接触.股, アクション情報.くぱ, タイミング情報.開始, アイテム情報.ハンド, 0, 1, false, false);
						Act.奴体力消費小();
						Act.主精力消費小();
						this.くぱ();
						if (OthN.XS.NextBool())
						{
							this.調教UI.陰核演出();
						}
						else
						{
							this.調教UI.膣腔演出();
						}
						this.くぱぁ中.Sta();
						this.調教UI.脚修正();
						return;
					}
					if (!this.調教UI.ハンド挿入.Is挿入 && this.Is撫で(ref cd))
					{
						this.調教UI.押し(ref cd);
						this.体撫でモ\u30FCド(ref cd);
						this.調教UI.Action(cd.c, アクション情報.接触, タイミング情報.開始, アイテム情報.ハンド, 0, 1, false, false);
						Act.奴体力消費小();
						Act.主精力消費小();
						this.調教UI.肌体演出();
						return;
					}
					this.箇所 = cd.c;
					this.調教UI.ハンド挿入.Down(ref mb, ref cp, ref hc, ref cd);
					return;
				}
				else if (mb == MouseButtons.Right)
				{
					if (!this.Isモ\u30FCド && !this.調教UI.ペニス挿入.Is挿入)
					{
						this.調教UI.ハンド左表示 = false;
						this.調教UI.ハンド右CM.Show = true;
						this.調教UI.ハンド右.Xi = 0;
						this.調教UI.ハンド右.Yi = 0;
						this.調教UI.ハンド左.Xi = 0;
						this.調教UI.ハンド左.Yi = 0;
						this.乳繰り解除();
						if (this.切り替え)
						{
							this.切り替え = false;
							return;
						}
						this.調教UI.Focus.Ele.濃度 = 0.5;
						this.調教UI.Focus = this.調教UI.ペニスCM;
						this.調教UI.ペニスCM.Ele.位置B = cp;
						this.調教UI.ペニス処理.選択 = true;
						this.調教UI.ペニス処理.Move(ref mb, ref cp, ref hc, ref cd);
						return;
					}
				}
				else if (mb == MouseButtons.Middle && !this.Isモ\u30FCド && !this.調教UI.マウス挿入.Is挿入 && (!this.調教UI.ハンド右CM.Show || this.調教UI.ハンド右.Xi != 5 || !this.調教UI.キャップ処理.キャップ右着) && (!this.調教UI.ハンド左表示 || this.調教UI.ハンド左.Xi != 5 || !this.調教UI.キャップ処理.キャップ左着) && (!this.調教UI.ハンド右CM.Show || this.調教UI.ハンド右.Xi != 5 || !this.調教UI.キャップ処理.キャップ中着))
				{
					this.調教UI.ハンド左表示 = false;
					this.調教UI.ハンド右CM.Show = true;
					this.調教UI.ハンド右.Xi = 0;
					this.調教UI.ハンド右.Yi = 0;
					this.調教UI.ハンド左.Xi = 0;
					this.調教UI.ハンド左.Yi = 0;
					this.乳繰り解除();
					if (this.切り替え)
					{
						this.切り替え = false;
						return;
					}
					this.調教UI.Focus.Ele.濃度 = 0.5;
					this.調教UI.Focus = this.調教UI.マウスCM;
					this.調教UI.マウスCM.Ele.位置B = cp;
					this.調教UI.マウス処理.Move(ref mb, ref cp, ref hc, ref cd);
				}
			}
		}

		public void Up(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref 接触D cd)
		{
			if (this.調教UI.Focus == this.対象 && mb == MouseButtons.Left && this.Isモ\u30FCド)
			{
				if (this.箇所 == 接触.乳)
				{
					if (this.Is乳摘み)
					{
						this.調教UI.Action(接触.乳, アクション情報.乳摘, タイミング情報.終了, アイテム情報.ハンド, 0, 1, false, false);
						Act.奴体力消費小();
						Act.主精力消費小();
					}
					if (this.Is乳繰り)
					{
						this.調教UI.Action(接触.乳, アクション情報.乳繰, タイミング情報.終了, アイテム情報.ハンド, 0, 1, false, false);
						Act.奴体力消費小();
						Act.主精力消費小();
					}
					this.乳摘み解除();
					this.乳繰り解除();
					this.調教UI.ハンド左表示 = true;
					this.調教UI.放し();
					return;
				}
				if (this.箇所 == 接触.胸)
				{
					this.調教UI.Action(接触.胸, アクション情報.乳捏, タイミング情報.終了, アイテム情報.ハンド, 0, 1, false, false);
					Act.奴体力消費小();
					Act.主精力消費小();
					this.乳捏ね解除();
					this.調教UI.ハンド左表示 = true;
					this.調教UI.放し();
					return;
				}
				if (this.箇所 == 接触.核)
				{
					this.調教UI.Action(接触.核, アクション情報.核捏, タイミング情報.終了, アイテム情報.ハンド, 0, 1, false, false);
					Act.奴体力消費小();
					Act.主精力消費小();
					this.核捏ね解除();
					this.調教UI.放し();
					return;
				}
				if (this.箇所 == 接触.股)
				{
					this.くぱぁ中.End();
					this.調教UI.Action(接触.股, アクション情報.くぱ, タイミング情報.終了, アイテム情報.ハンド, 0, 1, false, false);
					Act.奴体力消費小();
					Act.主精力消費小();
					this.くぱぁ解除(ref cd);
					this.調教UI.ハンド左表示 = true;
					this.調教UI.放し();
					return;
				}
				if (this.Is撫で())
				{
					this.調教UI.Action(cd.c, アクション情報.接触, タイミング情報.終了, アイテム情報.ハンド, 0, 1, false, false);
					Act.奴体力消費小();
					Act.主精力消費小();
					this.体撫で解除();
					this.調教UI.放し();
					if (Sta.GameData.ガイド)
					{
						if (this.調教UI.IsHitCha(ref cd))
						{
							this.体撫でsi1();
							return;
						}
						this.ip.SubInfoIm = this.si();
						return;
					}
				}
				else
				{
					this.調教UI.ハンド挿入.Up(ref mb, ref cp, ref hc, ref cd);
				}
			}
		}

		public void Leave(ref MouseButtons mb, ref Vector2D cp, ref Color hc)
		{
		}

		public void Wheel(ref MouseButtons mb, ref Vector2D cp, ref int dt, ref Color hc, ref 接触D cd)
		{
			if (this.調教UI.Focus == this.対象 && (cd.c == 接触.乳 || cd.c == 接触.胸) && !this.Is乳摘み && (this.調教UI.ハンド右.Xi == 5 || this.調教UI.ハンド左.Xi == 5))
			{
				if (!this.Is乳繰り)
				{
					this.調教UI.Action(接触.乳, アクション情報.乳繰, タイミング情報.開始, アイテム情報.ハンド, 0, 1, false, false);
					Act.奴体力消費小();
					Act.主精力消費小();
				}
				else
				{
					this.調教UI.Action(接触.乳, アクション情報.乳繰, タイミング情報.継続, アイテム情報.ハンド, 0, 1, false, false);
					Act.奴体力消費小();
					Act.主精力消費小();
				}
				this.調教UI.Set_乳首(this.調教UI.ハンド右, true);
				this.調教UI.Set_乳首(this.調教UI.ハンド左, false);
				this.調教UI.押し(ref cd);
				this.乳繰りモ\u30FCド(ref cd);
				this.調教UI.ハンド右.Yi = (this.調教UI.ハンド右.Yi + dt.Sign() * 2).LimitM(0, this.調教UI.ハンド右.本体.CountY);
				this.調教UI.ハンド左.Yi = (this.調教UI.ハンド左.Yi - dt.Sign() * 2).LimitM(0, this.調教UI.ハンド左.本体.CountY);
				this.乳繰りsi();
				this.調教UI.乳首演出();
			}
		}

		public ハンド処理(調教UI 調教UI, CM ハンド)
		{
			ハンド処理.<>c__DisplayClass56_0 CS$<>8__locals1 = new ハンド処理.<>c__DisplayClass56_0();
			CS$<>8__locals1.調教UI = 調教UI;
			base..ctor(CS$<>8__locals1.調教UI, ハンド);
			CS$<>8__locals1.<>4__this = this;
			double d = 1.0;
			bool f = false;
			Mot mot = new Mot(0.0, 1.0);
			mot.BaseSpeed = 1.0;
			mot.Staing = delegate(Mot m)
			{
				f = (CS$<>8__locals1.<>4__this.Bod.乳房右.Yi <= 2);
				d = CS$<>8__locals1.<>4__this.Bod.乳房右.Yv;
			};
			mot.Runing = delegate(Mot m)
			{
				if (f)
				{
					d -= m.Value;
					if (d < 0.0)
					{
						d = 0.0;
					}
					CS$<>8__locals1.<>4__this.Bod.乳房右.Yv = d;
					CS$<>8__locals1.<>4__this.Bod.乳房左.Yv = d;
					if (CS$<>8__locals1.<>4__this.Bod.乳房右.Yi == 0)
					{
						d = 0.0;
						m.End();
						return;
					}
				}
				else
				{
					d += m.Value;
					if (d > 1.0)
					{
						d = 0.0;
					}
					CS$<>8__locals1.<>4__this.Bod.乳房右.Yv = d;
					CS$<>8__locals1.<>4__this.Bod.乳房左.Yv = d;
					if (CS$<>8__locals1.<>4__this.Bod.乳房右.Yi == 0)
					{
						d = 0.0;
						m.End();
					}
				}
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
				m.ResetValue();
				CS$<>8__locals1.<>4__this.Bod.乳房右.Yi = 0;
				CS$<>8__locals1.<>4__this.Bod.乳房左.Yi = 0;
			};
			this.バスト初期化 = mot;
			CS$<>8__locals1.調教UI.Mots.Add(this.バスト初期化.GetHashCode().ToString(), this.バスト初期化);
			Mot mot2 = new Mot(0.0, 1.0);
			mot2.BaseSpeed = 1.0;
			mot2.Staing = delegate(Mot m)
			{
			};
			mot2.Runing = delegate(Mot m)
			{
				CS$<>8__locals1.調教UI.Action(接触.股, アクション情報.くぱ, タイミング情報.継続, アイテム情報.ハンド, 0, 1, false, false);
				Act.奴体力消費小();
			};
			mot2.Reaing = delegate(Mot m)
			{
			};
			mot2.Rouing = delegate(Mot m)
			{
			};
			mot2.Ending = delegate(Mot m)
			{
				m.ResetValue();
			};
			this.くぱぁ中 = mot2;
			CS$<>8__locals1.調教UI.Mots.Add(this.くぱぁ中.GetHashCode().ToString(), this.くぱぁ中);
		}

		public void SetCha(Cha Cha)
		{
			this.Cha = Cha;
			this.Bod = Cha.Bod;
		}

		public new void Reset()
		{
			base.Reset();
			this.Is乳繰り = false;
			this.Is乳摘み = false;
			this.Is乳捏ね = false;
			this.Is核捏ね = false;
			this.Isくぱぁ = false;
			this.Is体撫で = false;
			Mot mot = this.バスト初期化;
			if (mot != null)
			{
				mot.End();
			}
			Mot mot2 = this.くぱぁ中;
			if (mot2 != null)
			{
				mot2.End();
			}
			this.乳繰り解除();
			this.乳摘み解除();
			this.乳捏ね解除();
			this.核捏ね初 = false;
			this.核捏ね解除();
			接触D 接触D = default(接触D);
			this.くぱぁ解除(ref 接触D);
			this.体撫で解除();
			this.箇所 = 接触.none;
			this.vs = default(Vector2D);
			this.vl.Clear();
			this.x = 0.0;
			this.v = default(Vector2D);
			this.o = default(Vector2D);
			this.yi = 0;
			this.切り替え = false;
		}

		public bool Is乳繰り;

		public bool Is乳摘み;

		public bool Is乳捏ね;

		public bool Is核捏ね;

		public bool Isくぱぁ;

		public bool Is体撫で;

		public Mot バスト初期化;

		public Mot くぱぁ中;

		private bool 核捏ね初;

		private double くぱぁ;

		private 接触 箇所;

		private Vector2D vs;

		private List<Vector2D> vl = new List<Vector2D>();

		private double u = 72.0;

		private double x;

		private Vector2D v;

		private Vector2D o;

		private int yi;

		public bool 切り替え;
	}
}
