using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 調教UI : Ele
	{
		public void 発音(Vector2D p, string s, Color c, double d, bool b)
		{
			this.擬音キュ\u30FC.Enqueue(delegate(Are a)
			{
				this.擬音.Sound(a, p, s, new Font("MS Gothic", 1f), c, d, b);
			});
		}

		public void 潮吹()
		{
			this.擬音キュ\u30FC.Enqueue(delegate(Are a)
			{
				this.擬音.Sound(a, this.Bod.尿道位置.GetAreaPoint(0.04), Sta.潮吹.GetVal(Act.変化V_潮吹, Act.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.Azure, 0.2 + 0.2 * OthN.XS.NextDouble() * Act.変化V_潮吹, true);
			});
		}

		public void 放尿()
		{
			if (this.CP.GetFlag(0.1 + 0.1 * Act.変化V_放尿 * 0.8))
			{
				this.擬音キュ\u30FC.Enqueue(delegate(Are a)
				{
					this.擬音.Sound(a, this.Bod.尿道位置.GetAreaPoint(0.04), Sta.放尿.GetVal(Act.変化V_放尿, Act.変化V_固有値乱数), new Font("MS Gothic", 1f), Col.Black, 0.2 + 0.2 * OthN.XS.NextDouble() * Act.変化V_放尿, true);
				});
			}
		}

		public void 口腔演出()
		{
		}

		public void 肌体演出()
		{
		}

		public void 乳房演出()
		{
		}

		public void 乳首演出()
		{
		}

		public void 陰核演出()
		{
		}

		public void 膣腔演出()
		{
		}

		public void 肛門演出()
		{
		}

		public void 出糸演出()
		{
		}

		public IEnumerable<CM> EnumCM()
		{
			yield return this.ペニスCM;
			yield return this.マウスCM;
			yield return this.ハンド右CM;
			yield return this.ロ\u30FCタCM;
			yield return this.コモンCM;
			yield return this.ディルCM;
			yield return this.アナルCM;
			yield return this.デンマCM;
			yield return this.ドリルCM;
			yield return this.パ\u30FCルCM;
			yield return this.羽根箒CM;
			yield return this.調教鞭CM;
			yield return this.T剃刀CM;
			yield return this.キャップ1CM;
			yield return this.キャップ2CM;
			yield return this.キャップ3CM;
			yield break;
		}

		public void Set挿入Position()
		{
			this.ペニス挿入.SetPosition();
			this.マウス挿入.SetPosition();
			this.ハンド挿入.SetPosition();
			this.ロ\u30FCタ挿入.SetPosition();
			this.コモン挿入.SetPosition();
			this.ディル挿入.SetPosition();
			this.アナル挿入.SetPosition();
			this.デンマ挿入.SetPosition();
			this.ドリル挿入.SetPosition();
			this.パ\u30FCル挿入.SetPosition();
		}

		public Color 羽根箒先端hc
		{
			get
			{
				Par x0Y0_羽根 = this.羽根箒.X0Y0_羽根1;
				return this.Med.GetHitColor(this.Med.FromBasePosition(x0Y0_羽根.ToGlobal(x0Y0_羽根.JP[1].Joint)));
			}
		}

		private void Set_ペニス(Ele t)
		{
			t.位置B = this.ペニス.AreM.Position;
		}

		private void Set_ロ\u30FCタ(Ele t)
		{
			switch (this.ロ\u30FCタ.Yi)
			{
			case 0:
				t.位置B = this.ロ\u30FCタ.X0Y0_ロ\u30FCタ.ToGlobal_nc(this.ロ\u30FCタ.X0Y0_ロ\u30FCタ.JP[1].Joint.AddY(0.004));
				return;
			case 1:
				t.位置B = this.ロ\u30FCタ.X0Y1_ロ\u30FCタ.ToGlobal_nc(this.ロ\u30FCタ.X0Y1_ロ\u30FCタ.JP[1].Joint.AddY(0.004));
				return;
			case 2:
				t.位置B = this.ロ\u30FCタ.X0Y2_ロ\u30FCタ.ToGlobal_nc(this.ロ\u30FCタ.X0Y2_ロ\u30FCタ.JP[1].Joint.AddY(0.004));
				return;
			case 3:
				t.位置B = this.ロ\u30FCタ.X0Y3_ロ\u30FCタ.ToGlobal_nc(this.ロ\u30FCタ.X0Y3_ロ\u30FCタ.JP[0].Joint.AddY(0.004));
				return;
			default:
				t.位置B = this.ロ\u30FCタ.X0Y4_ロ\u30FCタ.ToGlobal_nc(this.ロ\u30FCタ.X0Y4_ロ\u30FCタ.JP[0].Joint.AddY(0.004));
				return;
			}
		}

		private void Set_コモン(Ele t)
		{
			switch (this.コモン.Yi)
			{
			case 0:
				t.位置B = this.コモン.X0Y0_ユニット_ユニット.ToGlobal_nc(this.コモン.X0Y0_ユニット_ユニット.JP[6].Joint);
				return;
			case 1:
				t.位置B = this.コモン.X0Y1_ユニット_ユニット.ToGlobal_nc(this.コモン.X0Y1_ユニット_ユニット.JP[6].Joint);
				return;
			case 2:
				t.位置B = this.コモン.X0Y2_ユニット_ユニット.ToGlobal_nc(this.コモン.X0Y2_ユニット_ユニット.JP[6].Joint);
				return;
			case 3:
				t.位置B = this.コモン.X0Y3_ユニット_ユニット.ToGlobal_nc(this.コモン.X0Y3_ユニット_ユニット.JP[6].Joint);
				return;
			default:
				t.位置B = this.コモン.X0Y4_ユニット_ユニット.ToGlobal_nc(this.コモン.X0Y4_ユニット_ユニット.JP[6].Joint);
				return;
			}
		}

		private void Set_ディル(Ele t)
		{
			switch (this.ディル.Yi)
			{
			case 0:
				t.位置B = this.ディル.X0Y0_ユニット_ユニット.ToGlobal_nc(this.ディル.X0Y0_ユニット_ユニット.JP[6].Joint);
				return;
			case 1:
				t.位置B = this.ディル.X0Y1_ユニット_ユニット.ToGlobal_nc(this.ディル.X0Y1_ユニット_ユニット.JP[6].Joint);
				return;
			case 2:
				t.位置B = this.ディル.X0Y2_ユニット_ユニット.ToGlobal_nc(this.ディル.X0Y2_ユニット_ユニット.JP[6].Joint);
				return;
			case 3:
				t.位置B = this.ディル.X0Y3_ユニット_ユニット.ToGlobal_nc(this.ディル.X0Y3_ユニット_ユニット.JP[6].Joint);
				return;
			default:
				t.位置B = this.ディル.X0Y4_ユニット_ユニット.ToGlobal_nc(this.ディル.X0Y4_ユニット_ユニット.JP[6].Joint);
				return;
			}
		}

		private void Set_アナル(Ele t)
		{
			switch (this.アナル.Yi)
			{
			case 0:
				t.位置B = this.アナル.X0Y0_ユニット_ユニット.ToGlobal_nc(this.アナル.X0Y0_ユニット_ユニット.JP[6].Joint);
				return;
			case 1:
				t.位置B = this.アナル.X0Y1_ユニット_ユニット.ToGlobal_nc(this.アナル.X0Y1_ユニット_ユニット.JP[6].Joint);
				return;
			case 2:
				t.位置B = this.アナル.X0Y2_ユニット_ユニット.ToGlobal_nc(this.アナル.X0Y2_ユニット_ユニット.JP[6].Joint);
				return;
			case 3:
				t.位置B = this.アナル.X0Y3_ユニット_ユニット.ToGlobal_nc(this.アナル.X0Y3_ユニット_ユニット.JP[6].Joint);
				return;
			default:
				t.位置B = this.アナル.X0Y4_ユニット_ユニット.ToGlobal_nc(this.アナル.X0Y4_ユニット_ユニット.JP[6].Joint);
				return;
			}
		}

		private void Set_デンマ(Ele t)
		{
			switch (this.デンマ.Yi)
			{
			case 0:
				t.位置B = this.デンマ.X0Y0_ユニット_ユニット.ToGlobal_nc(this.デンマ.X0Y0_ユニット_ユニット.JP[6].Joint);
				return;
			case 1:
				t.位置B = this.デンマ.X0Y1_ユニット_ユニット.ToGlobal_nc(this.デンマ.X0Y1_ユニット_ユニット.JP[6].Joint);
				return;
			case 2:
				t.位置B = this.デンマ.X0Y2_ユニット_ユニット.ToGlobal_nc(this.デンマ.X0Y2_ユニット_ユニット.JP[6].Joint);
				return;
			case 3:
				t.位置B = this.デンマ.X0Y3_ユニット_ユニット.ToGlobal_nc(this.デンマ.X0Y3_ユニット_ユニット.JP[6].Joint);
				return;
			default:
				t.位置B = this.デンマ.X0Y4_ユニット_ユニット.ToGlobal_nc(this.デンマ.X0Y4_ユニット_ユニット.JP[6].Joint);
				return;
			}
		}

		private void Set_ドリル(Ele t)
		{
			int xi = this.ドリル.Xi;
			if (xi != 0)
			{
				if (xi != 1)
				{
					switch (this.ドリル.Yi)
					{
					case 0:
						t.位置B = this.ドリル.X2Y0_ユニット_ユニット.ToGlobal_nc(this.ドリル.X2Y0_ユニット_ユニット.JP[6].Joint);
						return;
					case 1:
						t.位置B = this.ドリル.X2Y1_ユニット_ユニット.ToGlobal_nc(this.ドリル.X2Y1_ユニット_ユニット.JP[6].Joint);
						return;
					case 2:
						t.位置B = this.ドリル.X2Y2_ユニット_ユニット.ToGlobal_nc(this.ドリル.X2Y2_ユニット_ユニット.JP[6].Joint);
						return;
					case 3:
						t.位置B = this.ドリル.X2Y3_ユニット_ユニット.ToGlobal_nc(this.ドリル.X2Y3_ユニット_ユニット.JP[6].Joint);
						return;
					default:
						t.位置B = this.ドリル.X2Y4_ユニット_ユニット.ToGlobal_nc(this.ドリル.X2Y4_ユニット_ユニット.JP[6].Joint);
						return;
					}
				}
				else
				{
					switch (this.ドリル.Yi)
					{
					case 0:
						t.位置B = this.ドリル.X1Y0_ユニット_ユニット.ToGlobal_nc(this.ドリル.X1Y0_ユニット_ユニット.JP[6].Joint);
						return;
					case 1:
						t.位置B = this.ドリル.X1Y1_ユニット_ユニット.ToGlobal_nc(this.ドリル.X1Y1_ユニット_ユニット.JP[6].Joint);
						return;
					case 2:
						t.位置B = this.ドリル.X1Y2_ユニット_ユニット.ToGlobal_nc(this.ドリル.X1Y2_ユニット_ユニット.JP[6].Joint);
						return;
					case 3:
						t.位置B = this.ドリル.X1Y3_ユニット_ユニット.ToGlobal_nc(this.ドリル.X1Y3_ユニット_ユニット.JP[6].Joint);
						return;
					default:
						t.位置B = this.ドリル.X1Y4_ユニット_ユニット.ToGlobal_nc(this.ドリル.X1Y4_ユニット_ユニット.JP[6].Joint);
						return;
					}
				}
			}
			else
			{
				switch (this.ドリル.Yi)
				{
				case 0:
					t.位置B = this.ドリル.X0Y0_ユニット_ユニット.ToGlobal_nc(this.ドリル.X0Y0_ユニット_ユニット.JP[6].Joint);
					return;
				case 1:
					t.位置B = this.ドリル.X0Y1_ユニット_ユニット.ToGlobal_nc(this.ドリル.X0Y1_ユニット_ユニット.JP[6].Joint);
					return;
				case 2:
					t.位置B = this.ドリル.X0Y2_ユニット_ユニット.ToGlobal_nc(this.ドリル.X0Y2_ユニット_ユニット.JP[6].Joint);
					return;
				case 3:
					t.位置B = this.ドリル.X0Y3_ユニット_ユニット.ToGlobal_nc(this.ドリル.X0Y3_ユニット_ユニット.JP[6].Joint);
					return;
				default:
					t.位置B = this.ドリル.X0Y4_ユニット_ユニット.ToGlobal_nc(this.ドリル.X0Y4_ユニット_ユニット.JP[6].Joint);
					return;
				}
			}
		}

		private void Set_パ\u30FCル(Ele t)
		{
			switch (this.パ\u30FCル.Yi)
			{
			case 0:
				t.位置B = this.パ\u30FCル.X0Y0_輪下.ToGlobal_nc(this.パ\u30FCル.X0Y0_輪下.JP[0].Joint);
				return;
			case 1:
				t.位置B = this.パ\u30FCル.X0Y1_輪下.ToGlobal_nc(this.パ\u30FCル.X0Y1_輪下.JP[0].Joint);
				return;
			case 2:
				t.位置B = this.パ\u30FCル.X0Y2_輪下.ToGlobal_nc(this.パ\u30FCル.X0Y2_輪下.JP[0].Joint);
				return;
			case 3:
				t.位置B = this.パ\u30FCル.X0Y3_輪下.ToGlobal_nc(this.パ\u30FCル.X0Y3_輪下.JP[0].Joint);
				return;
			case 4:
				t.位置B = this.パ\u30FCル.X0Y4_輪下.ToGlobal_nc(this.パ\u30FCル.X0Y4_輪下.JP[0].Joint);
				return;
			case 5:
				t.位置B = this.パ\u30FCル.X0Y5_輪下.ToGlobal_nc(this.パ\u30FCル.X0Y5_輪下.JP[0].Joint);
				return;
			case 6:
				t.位置B = this.パ\u30FCル.X0Y6_輪下.ToGlobal_nc(this.パ\u30FCル.X0Y6_輪下.JP[0].Joint);
				return;
			case 7:
				t.位置B = this.パ\u30FCル.X0Y7_輪下.ToGlobal_nc(this.パ\u30FCル.X0Y7_輪下.JP[0].Joint);
				return;
			case 8:
				t.位置B = this.パ\u30FCル.X0Y8_輪下.ToGlobal_nc(this.パ\u30FCル.X0Y8_輪下.JP[0].Joint);
				return;
			case 9:
				t.位置B = this.パ\u30FCル.X0Y9_輪下.ToGlobal_nc(this.パ\u30FCル.X0Y9_輪下.JP[0].Joint);
				return;
			case 10:
				t.位置B = this.パ\u30FCル.X0Y10_輪下.ToGlobal_nc(this.パ\u30FCル.X0Y10_輪下.JP[0].Joint);
				return;
			case 11:
				t.位置B = this.パ\u30FCル.X0Y11_輪下.ToGlobal_nc(this.パ\u30FCル.X0Y11_輪下.JP[0].Joint);
				return;
			case 12:
				t.位置B = this.パ\u30FCル.X0Y12_輪下.ToGlobal_nc(this.パ\u30FCル.X0Y12_輪下.JP[0].Joint);
				return;
			case 13:
				t.位置B = this.パ\u30FCル.X0Y13_輪下.ToGlobal_nc(this.パ\u30FCル.X0Y13_輪下.JP[0].Joint);
				return;
			case 14:
				t.位置B = this.パ\u30FCル.X0Y14_輪下.ToGlobal_nc(this.パ\u30FCル.X0Y14_輪下.JP[0].Joint);
				return;
			case 15:
				t.位置B = this.パ\u30FCル.X0Y15_輪下.ToGlobal_nc(this.パ\u30FCル.X0Y15_輪下.JP[0].Joint);
				return;
			default:
				t.位置B = this.パ\u30FCル.X0Y16_輪下.ToGlobal_nc(this.パ\u30FCル.X0Y16_輪下.JP[0].Joint);
				return;
			}
		}

		private void Set_羽根箒(Ele t)
		{
			t.位置B = this.羽根箒.X0Y0_柄.ToGlobal_nc(this.羽根箒.X0Y0_柄.JP[1].Joint);
			t.角度C = this.羽根箒.X0Y0_柄.Angle;
		}

		private void Set_調教鞭(Ele t)
		{
			int num = -45;
			if (this.調教鞭.Xi == 0)
			{
				switch (this.調教鞭.Yi)
				{
				case 0:
					t.位置B = this.調教鞭.X0Y0_柄.ToGlobal_nc(this.調教鞭.X0Y0_柄.JP[1].Joint);
					t.角度C = this.調教鞭.X0Y0_柄.Angle;
					return;
				case 1:
					t.位置B = this.調教鞭.X0Y1_柄.ToGlobal_nc(this.調教鞭.X0Y1_柄.JP[1].Joint);
					t.角度C = this.調教鞭.X0Y1_柄.Angle;
					return;
				case 2:
					t.位置B = this.調教鞭.X0Y2_柄.ToGlobal_nc(this.調教鞭.X0Y2_柄.JP[1].Joint);
					t.角度C = this.調教鞭.X0Y2_柄.Angle;
					return;
				case 3:
					t.位置B = this.調教鞭.X0Y3_柄.ToGlobal_nc(this.調教鞭.X0Y3_柄.JP[1].Joint);
					t.角度C = this.調教鞭.X0Y3_柄.Angle;
					return;
				default:
					t.位置B = this.調教鞭.X0Y4_柄.ToGlobal_nc(this.調教鞭.X0Y4_柄.JP[1].Joint);
					t.角度C = this.調教鞭.X0Y4_柄.Angle;
					return;
				}
			}
			else
			{
				if (this.調教鞭.Yi == 0)
				{
					t.位置B = this.調教鞭.X1Y0_柄.ToGlobal_nc(this.調教鞭.X1Y0_柄.JP[1].Joint);
					t.角度C = (double)((this.調教鞭.Xi == 0) ? 0 : num) + this.調教鞭.X0Y0_柄.Angle;
					return;
				}
				t.位置B = this.調教鞭.X1Y4_柄.ToGlobal_nc(this.調教鞭.X1Y4_柄.JP[1].Joint);
				t.角度C = (double)((this.調教鞭.Xi == 0) ? 0 : (-(double)num)) + this.調教鞭.X0Y4_柄.Angle;
				return;
			}
		}

		private void Set_T剃刀(Ele t)
		{
			t.位置B = this.T剃刀.X0Y0_グリップ_グリップ4.ToGlobal_nc(this.T剃刀.X0Y0_グリップ_グリップ4.JP[0].Joint);
			t.角度C = this.T剃刀.X0Y0_グリップ_グリップ4.Angle;
		}

		public void Set_キャップ1(Ele t)
		{
			t.位置B = this.キャップ1.X0Y0_先端.ToGlobal_nc(this.キャップ1.X0Y0_先端.JP[0].Joint);
		}

		public void Set_キャップ2(Ele t)
		{
			t.位置B = this.キャップ2.X0Y0_先端.ToGlobal_nc(this.キャップ2.X0Y0_先端.JP[0].Joint);
		}

		public void Set_キャップ3(Ele t)
		{
			t.位置B = this.キャップ3.X0Y0_先端.ToGlobal_nc(this.キャップ3.X0Y0_先端.JP[0].Joint);
		}

		public void Set_キャップ左(Ele t)
		{
			キャップ2 キャップ2左 = this.Bod.キャップ2左;
			t.位置B = キャップ2左.X0Y0_先端.ToGlobal_nc(キャップ2左.X0Y0_先端.JP[0].Joint);
		}

		public void Set_キャップ右(Ele t)
		{
			キャップ2 キャップ2右 = this.Bod.キャップ2右;
			t.位置B = キャップ2右.X0Y0_先端.ToGlobal_nc(キャップ2右.X0Y0_先端.JP[0].Joint);
		}

		public void Set_キャップ中(Ele t)
		{
			キャップ1 キャップ = this.Bod.キャップ1;
			t.位置B = キャップ.X0Y0_先端.ToGlobal_nc(キャップ.X0Y0_先端.JP[0].Joint);
		}

		public void Set_口(Ele t)
		{
			Par par = this.Bod.口.本体.Current.EnumAllPar().First((Par e) => e.Tag == "口");
			this.Bod.口.接続PA();
			t.位置B = par.Position;
		}

		public void Set_乳首(Ele t, bool 右)
		{
			乳房 乳房 = 右 ? this.Bod.乳房右 : this.Bod.乳房左;
			乳房.接続PA();
			switch (乳房.Yi)
			{
			case 0:
				t.位置B = 乳房.X0Y0_乳首.ToGlobal_nc(乳房.X0Y0_乳首.JP[0].Joint);
				return;
			case 1:
				t.位置B = 乳房.X0Y1_乳首.ToGlobal_nc(乳房.X0Y1_乳首.JP[0].Joint);
				return;
			case 2:
				t.位置B = 乳房.X0Y2_乳首.ToGlobal_nc(乳房.X0Y2_乳首.JP[0].Joint);
				return;
			case 3:
				t.位置B = 乳房.X0Y3_乳首.ToGlobal_nc(乳房.X0Y3_乳首.JP[0].Joint);
				return;
			default:
				t.位置B = 乳房.X0Y4_乳首.ToGlobal_nc(乳房.X0Y4_乳首.JP[0].Joint);
				return;
			}
		}

		public void Set_乳房(Ele t, bool 右)
		{
			乳房 乳房 = 右 ? this.Bod.乳房右 : this.Bod.乳房左;
			乳房.接続PA();
			switch (乳房.Yi)
			{
			case 0:
				t.位置B = 乳房.X0Y0_乳房.ToGlobal_nc(乳房.X0Y0_乳房.OP.GetCenter());
				return;
			case 1:
				t.位置B = 乳房.X0Y1_乳房.ToGlobal_nc(乳房.X0Y1_乳房.OP.GetCenter());
				return;
			case 2:
				t.位置B = 乳房.X0Y2_乳房.ToGlobal_nc(乳房.X0Y2_乳房.OP.GetCenter());
				return;
			case 3:
				t.位置B = 乳房.X0Y3_乳房.ToGlobal_nc(乳房.X0Y3_乳房.OP.GetCenter());
				return;
			default:
				t.位置B = 乳房.X0Y4_乳房.ToGlobal_nc(乳房.X0Y4_乳房.OP.GetCenter());
				return;
			}
		}

		public void Set_陰核(Ele t)
		{
			Par par = this.Bod.性器.本体.Current.EnumAllPar().First((Par e) => e.Tag == "陰核");
			this.Bod.性器.接続PA();
			t.位置B = par.Position;
		}

		public void Set_膣口(Ele t)
		{
			Par par = this.Bod.性器.本体.Current.EnumAllPar().First((Par e) => e.Tag == "膣口");
			this.Bod.性器.接続PA();
			t.位置B = par.Position;
		}

		public void Set_肛門(Ele t)
		{
			this.Bod.肛門.接続PA();
			t.位置B = this.Bod.肛門.位置;
		}

		public void Set_出糸(Ele t)
		{
			this.Bod.蜘尾.接続PA();
			t.位置B = this.Bod.蜘尾.X0Y0_出糸突起後_出糸突起基.Position;
		}

		public void Set_くぱぁ(Ele t, bool 右)
		{
			Par par;
			if (!this.Bod.Is獣)
			{
				par = this.Bod.腰.本体.Current.EnumAllPar().First((Par e) => e.Tag == "股");
			}
			else
			{
				par = this.Bod.腰_獣.本体.Current.EnumAllPar().First((Par e) => e.Tag == "股");
			}
			Par par2 = par;
			this.Bod.腰.接続PA();
			if (右)
			{
				t.位置B = par2.Position.AddXY(0.018, 0.002);
				return;
			}
			t.位置B = par2.Position.AddXY(-0.018, 0.002);
		}

		public bool ToolIsHit(Color hc)
		{
			return this.ToolIsHit(ref hc);
		}

		public bool ToolIsHit(ref Color hc)
		{
			return this.ペニス.本体.IsHit(ref hc) || this.マウス.本体.IsHit(ref hc) || this.ハンド右.本体.IsHit(ref hc) || this.ロ\u30FCタ.本体.IsHit(ref hc) || this.コモン.本体.IsHit(ref hc) || this.ディル.本体.IsHit(ref hc) || this.アナル.本体.IsHit(ref hc) || this.デンマ.本体.IsHit(ref hc) || this.ドリル.本体.IsHit(ref hc) || this.パ\u30FCル.本体.IsHit(ref hc) || this.羽根箒.本体.IsHit(ref hc) || this.調教鞭.本体.IsHit(ref hc) || this.T剃刀.本体.IsHit(ref hc) || this.キャップ1.本体.IsHit(ref hc) || this.キャップ2.本体.IsHit(ref hc) || this.キャップ3.本体.IsHit(ref hc) || this.調教終了.Pars.IsHit(ref hc) || this.体力sゲ\u30FCジ.Pars.IsHit(ref hc) || this.絶頂sゲ\u30FCジ.Pars.IsHit(ref hc) || this.精力mゲ\u30FCジ.Pars.IsHit(ref hc) || this.射精mゲ\u30FCジ.Pars.IsHit(ref hc) || this.ip.IsHit(ref hc);
		}

		public bool IsHitCha(接触D cd)
		{
			return this.IsHitCha(ref cd);
		}

		public bool IsHitCha(ref 接触D cd)
		{
			return cd.e != null;
		}

		public bool Isバイブ(CM cm)
		{
			return this.コモンCM == cm || this.ディルCM == cm || this.アナルCM == cm || this.デンマCM == cm || this.ドリルCM == cm;
		}

		public bool Isキャップ(CM cm)
		{
			return this.キャップ1CM == cm || this.キャップ2CM == cm || this.キャップ3CM == cm;
		}

		public 挿入処理 Get挿入処理()
		{
			if (this.Focus == this.ペニスCM)
			{
				return this.ペニス挿入;
			}
			if (this.Focus == this.マウスCM)
			{
				return this.マウス挿入;
			}
			if (this.Focus == this.ハンド右CM)
			{
				return this.ハンド挿入;
			}
			if (this.Focus == this.ロ\u30FCタCM)
			{
				return this.ロ\u30FCタ挿入;
			}
			if (this.Focus == this.コモンCM)
			{
				return this.コモン挿入;
			}
			if (this.Focus == this.ディルCM)
			{
				return this.ディル挿入;
			}
			if (this.Focus == this.アナルCM)
			{
				return this.アナル挿入;
			}
			if (this.Focus == this.デンマCM)
			{
				return this.デンマ挿入;
			}
			if (this.Focus == this.ドリルCM)
			{
				return this.ドリル挿入;
			}
			if (this.Focus == this.パ\u30FCルCM)
			{
				return this.パ\u30FCル挿入;
			}
			return null;
		}

		private 挿入処理 Get挿入処理(ref Color hc)
		{
			if (this.ペニス.本体.IsHit(ref hc))
			{
				return this.ペニス挿入;
			}
			if (this.マウス.本体.IsHit(ref hc))
			{
				return this.マウス挿入;
			}
			if (this.ハンド右.本体.IsHit(ref hc))
			{
				return this.ハンド挿入;
			}
			if (this.ロ\u30FCタ.本体.IsHit(ref hc))
			{
				return this.ロ\u30FCタ挿入;
			}
			if (this.コモン.本体.IsHit(ref hc))
			{
				return this.コモン挿入;
			}
			if (this.ディル.本体.IsHit(ref hc))
			{
				return this.ディル挿入;
			}
			if (this.アナル.本体.IsHit(ref hc))
			{
				return this.アナル挿入;
			}
			if (this.デンマ.本体.IsHit(ref hc))
			{
				return this.デンマ挿入;
			}
			if (this.ドリル.本体.IsHit(ref hc))
			{
				return this.ドリル挿入;
			}
			if (this.パ\u30FCル.本体.IsHit(ref hc))
			{
				return this.パ\u30FCル挿入;
			}
			return null;
		}

		public bool Is挿入
		{
			get
			{
				return (this.focus == this.ペニスCM && this.ペニス挿入.Is挿入) || (this.focus == this.マウスCM && this.マウス挿入.Is挿入) || (this.focus == this.ハンド右CM && this.ハンド挿入.Is挿入) || (this.focus == this.ロ\u30FCタCM && this.ロ\u30FCタ挿入.Is挿入) || (this.focus == this.コモンCM && this.コモン挿入.Is挿入) || (this.focus == this.ディルCM && this.ディル挿入.Is挿入) || (this.focus == this.アナルCM && this.アナル挿入.Is挿入) || (this.focus == this.デンマCM && this.デンマ挿入.Is挿入) || (this.focus == this.ドリルCM && this.ドリル挿入.Is挿入) || (this.focus == this.パ\u30FCルCM && this.パ\u30FCル挿入.Is挿入);
			}
		}

		public bool Is脚修正1
		{
			get
			{
				return this.ペニス挿入.Is膣 || this.ペニス挿入.Is肛 || this.ペニス挿入.Is糸 || this.マウス挿入.Is膣 || this.マウス挿入.Is肛 || this.マウス挿入.Is糸 || this.ハンド挿入.Is膣 || this.ハンド挿入.Is肛 || this.ハンド挿入.Is糸 || this.ロ\u30FCタ挿入.Is膣 || this.ロ\u30FCタ挿入.Is肛 || this.ロ\u30FCタ挿入.Is糸 || this.コモン挿入.Is膣 || this.コモン挿入.Is肛 || this.コモン挿入.Is糸 || this.ディル挿入.Is膣 || this.ディル挿入.Is肛 || this.ディル挿入.Is糸 || this.アナル挿入.Is膣 || this.アナル挿入.Is肛 || this.アナル挿入.Is糸 || this.デンマ挿入.Is膣 || this.デンマ挿入.Is肛 || this.デンマ挿入.Is糸 || this.ドリル挿入.Is膣 || this.ドリル挿入.Is肛 || this.ドリル挿入.Is糸 || this.パ\u30FCル挿入.Is膣 || this.パ\u30FCル挿入.Is肛 || this.パ\u30FCル挿入.Is糸 || this.ハンド処理.Isくぱぁ || Act.Is性器接触 || this.Cha.Is放尿();
			}
		}

		public bool Is脚修正2
		{
			get
			{
				return this.ペニス処理.Isパイズリ || this.ハンド処理.Is乳繰り || this.ハンド処理.Is乳摘み || this.ハンド処理.Is乳捏ね || this.ペニス処理.手コキ.Run || Act.接触n == 接触.乳;
			}
		}

		public bool Isモ\u30FCド
		{
			get
			{
				return this.Is挿入 || (this.focus == this.ハンド右CM && this.ハンド処理.Isモ\u30FCド) || (this.focus == this.マウスCM && this.マウス処理.Isモ\u30FCド) || (this.focus == this.ペニスCM && this.ペニス処理.Isパイズリ) || this.コキ;
			}
		}

		public bool コキ
		{
			get
			{
				return this.コキ_;
			}
			set
			{
				this.コキ_ = value;
				this.ペニスCM.Under = value;
			}
		}

		public CM Focus
		{
			get
			{
				return this.focus;
			}
			set
			{
				this.FocusReset();
				this.Focus_nr = value;
				if (this.Med.Mode == "調教" && this.Cha != null && this.Cha.ChaD.欲望度 > 0.5 && OthN.XS.NextBool())
				{
					this.Cha.目_追い.Sta();
				}
			}
		}

		public CM Focus_nr
		{
			get
			{
				return this.focus;
			}
			set
			{
				this.focus = value;
				this.focus.StaShow = false;
				this.focus.使用状態 = 使用状態.使用;
				this.focus.Ele.濃度 = 1.0;
				if (this.focus == this.羽根箒CM)
				{
					this.羽根箒.角度B = -90.0;
				}
			}
		}

		public void FocusReset()
		{
			if (this.focus == this.ロ\u30FCタ挿入.対象)
			{
				this.ロ\u30FCタ挿入.振動 = false;
			}
			else if (this.focus == this.コモン挿入.対象)
			{
				this.コモン挿入.振動 = false;
			}
			else if (this.focus == this.ディル挿入.対象)
			{
				this.ディル挿入.振動 = false;
			}
			else if (this.focus == this.アナル挿入.対象)
			{
				this.アナル挿入.振動 = false;
			}
			else if (this.focus == this.デンマ挿入.対象)
			{
				this.デンマ挿入.振動 = false;
			}
			else if (this.focus == this.ドリル挿入.対象)
			{
				this.ドリル挿入.振動 = false;
				this.ドリル挿入.回転 = false;
			}
			this.ペニス処理.選択 = false;
			this.マウス処理.選択 = false;
			this.ハンド処理.選択 = false;
			this.ペニス挿入.選択 = false;
			this.マウス挿入.選択 = false;
			this.ハンド挿入.選択 = false;
			this.ロ\u30FCタ挿入.選択 = false;
			this.コモン挿入.選択 = false;
			this.ディル挿入.選択 = false;
			this.アナル挿入.選択 = false;
			this.デンマ挿入.選択 = false;
			this.ドリル挿入.選択 = false;
			this.パ\u30FCル挿入.選択 = false;
			this.キャップ処理.選択 = false;
			this.羽箒処理.選択 = false;
			this.剃刀処理.選択 = false;
			this.調鞭処理.選択 = false;
			this.放し();
			this.focus.StaShow = true;
			this.focus.使用状態 = 使用状態.待機;
			this.focus.Ele.Xi = 0;
			this.focus.Ele.Yi = 0;
			this.focus.Ele.位置B = this.focus.bp;
			this.focus.Ele.位置C = Dat.Vec2DZero;
			this.focus.Ele.角度B = 0.0;
			this.focus.Ele.角度C = 0.0;
			this.focus.Ele.右 = false;
			if (this.focus == this.調教鞭CM)
			{
				this.調教鞭.Yi = 2;
				this.focus.Ele.角度C = 0.0;
			}
			this.focus.Ele.本体.JoinPAall();
		}

		public bool 持ち手
		{
			get
			{
				return this.持ち手_;
			}
			set
			{
				this.持ち手_ = value;
				if (this.持ち手_)
				{
					this.ハンド右.SetHitFalse();
					this.ハンド右CM.使用状態 = 使用状態.使用;
					return;
				}
				if (this.Focus != this.ハンド右CM)
				{
					this.ハンド右.SetHitTrue();
					this.ハンド右CM.使用状態 = 使用状態.待機;
				}
			}
		}

		public void Set持ち手()
		{
			if (this.focus == this.ペニスCM || this.focus == this.マウスCM || this.focus == this.ハンド右CM)
			{
				this.持ち手 = false;
				this.ハンド右.位置C = Dat.Vec2DZero;
				this.ハンド右.角度B = 0.0;
				this.ハンド右.角度C = 0.0;
				this.ハンド右.Xi = 0;
				this.ハンド右.Yi = 0;
				this.ハンド右.本体.JoinPA();
				return;
			}
			this.持ち手 = true;
			this.ハンド右.位置C = Dat.Vec2DZero;
			this.ハンド右.角度B = 0.0;
			this.ハンド右.角度C = 0.0;
			if (this.focus == this.コモンCM || this.focus == this.ディルCM || this.focus == this.アナルCM || this.focus == this.デンマCM || this.focus == this.ドリルCM)
			{
				this.ハンド右.Xi = 13;
			}
			else if (this.focus == this.ロ\u30FCタCM || this.focus == this.パ\u30FCルCM || this.focus == this.羽根箒CM || this.focus == this.調教鞭CM || this.focus == this.T剃刀CM)
			{
				this.ハンド右.Xi = 11;
			}
			else if (this.focus == this.キャップ1CM)
			{
				this.ハンド右.Xi = 5;
				this.Set_キャップ1(this.ハンド右);
			}
			else if (this.focus == this.キャップ2CM)
			{
				this.ハンド右.Xi = 5;
				this.Set_キャップ2(this.ハンド右);
			}
			else if (this.focus == this.キャップ3CM)
			{
				this.ハンド右.Xi = 5;
				this.Set_キャップ3(this.ハンド右);
			}
			this.ハンド右.本体.JoinPA();
		}

		public void Joi持ち手()
		{
			if (this.持ち手)
			{
				if (this.focus == this.ペニスCM)
				{
					this.Set_ペニス(this.ハンド右);
					this.ハンド右.角度C = -this.ハンド右.角度C;
					return;
				}
				if (this.focus == this.ロ\u30FCタCM)
				{
					this.Set_ロ\u30FCタ(this.ハンド右);
					return;
				}
				if (this.focus == this.コモンCM)
				{
					this.Set_コモン(this.ハンド右);
					return;
				}
				if (this.focus == this.ディルCM)
				{
					this.Set_ディル(this.ハンド右);
					return;
				}
				if (this.focus == this.アナルCM)
				{
					this.Set_アナル(this.ハンド右);
					return;
				}
				if (this.focus == this.デンマCM)
				{
					this.Set_デンマ(this.ハンド右);
					return;
				}
				if (this.focus == this.ドリルCM)
				{
					this.Set_ドリル(this.ハンド右);
					return;
				}
				if (this.focus == this.パ\u30FCルCM)
				{
					this.Set_パ\u30FCル(this.ハンド右);
					return;
				}
				if (this.focus == this.羽根箒CM)
				{
					this.Set_羽根箒(this.ハンド右);
					return;
				}
				if (this.focus == this.調教鞭CM)
				{
					this.Set_調教鞭(this.ハンド右);
					return;
				}
				if (this.focus == this.T剃刀CM)
				{
					this.Set_T剃刀(this.ハンド右);
					return;
				}
				if (this.Focus == this.キャップ1CM)
				{
					this.Set_キャップ1(this.ハンド右);
					return;
				}
				if (this.Focus == this.キャップ2CM)
				{
					this.Set_キャップ2(this.ハンド右);
					return;
				}
				if (this.Focus == this.キャップ3CM)
				{
					this.Set_キャップ3(this.ハンド右);
				}
			}
		}

		public void In持ち手()
		{
			if (this.持ち手)
			{
				this.ハンド右.濃度 = 0.2;
			}
		}

		public void Out持ち手()
		{
			if (this.持ち手)
			{
				this.ハンド右.濃度 = 1.0;
			}
		}

		public void 持ち手下描画()
		{
			if (this.持ち手)
			{
				this.Joi持ち手();
				this.ハンド右.本体.JoinPA();
				this.ハンド右.色更新();
				if (this.ハンド右.Xi == 11)
				{
					this.Are.Draw(this.ハンド右.X11Y0_小指);
					this.Are.Draw(this.ハンド右.X11Y0_薬指);
					this.Are.Draw(this.ハンド右.X11Y0_中指);
					this.Are.Draw(this.ハンド右.X11Y0_人指);
				}
			}
		}

		public void 持ち手上描画()
		{
			if (this.持ち手)
			{
				int xi = this.ハンド右.Xi;
				if (xi != 5)
				{
					if (xi == 11)
					{
						this.Are.Draw(this.ハンド右.X11Y0_手);
						this.Are.Draw(this.ハンド右.X11Y0_親指);
						this.Are.Draw(this.ハンド右.X11Y0_呪印_輪1_輪外);
						this.Are.Draw(this.ハンド右.X11Y0_呪印_輪1_輪内);
						this.Are.Draw(this.ハンド右.X11Y0_呪印_輪2_輪外);
						this.Are.Draw(this.ハンド右.X11Y0_呪印_輪2_輪内);
						this.Are.Draw(this.ハンド右.X11Y0_呪印_輪3_輪外);
						this.Are.Draw(this.ハンド右.X11Y0_呪印_輪3_輪内);
						this.Are.Draw(this.ハンド右.X11Y0_呪印_鎖1);
						this.Are.Draw(this.ハンド右.X11Y0_呪印_鎖3);
						return;
					}
					if (xi != 13)
					{
						return;
					}
					this.Are.Draw(this.ハンド右.X13Y0_中指);
					this.Are.Draw(this.ハンド右.X13Y0_人指);
					this.Are.Draw(this.ハンド右.X13Y0_手);
					this.Are.Draw(this.ハンド右.X13Y0_親指);
					this.Are.Draw(this.ハンド右.X13Y0_呪印_輪1_輪外);
					this.Are.Draw(this.ハンド右.X13Y0_呪印_輪1_輪内);
					this.Are.Draw(this.ハンド右.X13Y0_呪印_輪2_輪外);
					this.Are.Draw(this.ハンド右.X13Y0_呪印_輪2_輪内);
					this.Are.Draw(this.ハンド右.X13Y0_呪印_輪3_輪外);
					this.Are.Draw(this.ハンド右.X13Y0_呪印_輪3_輪内);
					this.Are.Draw(this.ハンド右.X13Y0_呪印_鎖1);
					this.Are.Draw(this.ハンド右.X13Y0_呪印_鎖3);
				}
				else
				{
					switch (this.ハンド右.Yi)
					{
					case 0:
						this.Are.Draw(this.ハンド右.X5Y0_親指);
						this.Are.Draw(this.ハンド右.X5Y0_手);
						this.Are.Draw(this.ハンド右.X5Y0_小指);
						this.Are.Draw(this.ハンド右.X5Y0_薬指);
						this.Are.Draw(this.ハンド右.X5Y0_中指);
						this.Are.Draw(this.ハンド右.X5Y0_人指);
						this.Are.Draw(this.ハンド右.X5Y0_呪印_輪1_輪外);
						this.Are.Draw(this.ハンド右.X5Y0_呪印_輪1_輪内);
						this.Are.Draw(this.ハンド右.X5Y0_呪印_輪2_輪外);
						this.Are.Draw(this.ハンド右.X5Y0_呪印_輪2_輪内);
						this.Are.Draw(this.ハンド右.X5Y0_呪印_輪3_輪外);
						this.Are.Draw(this.ハンド右.X5Y0_呪印_輪3_輪内);
						this.Are.Draw(this.ハンド右.X5Y0_呪印_鎖1);
						this.Are.Draw(this.ハンド右.X5Y0_呪印_鎖2);
						this.Are.Draw(this.ハンド右.X5Y0_呪印_鎖3);
						return;
					case 1:
						this.Are.Draw(this.ハンド右.X5Y1_親指);
						this.Are.Draw(this.ハンド右.X5Y1_手);
						this.Are.Draw(this.ハンド右.X5Y1_小指);
						this.Are.Draw(this.ハンド右.X5Y1_薬指);
						this.Are.Draw(this.ハンド右.X5Y1_中指);
						this.Are.Draw(this.ハンド右.X5Y1_人指);
						this.Are.Draw(this.ハンド右.X5Y1_呪印_輪1_輪外);
						this.Are.Draw(this.ハンド右.X5Y1_呪印_輪1_輪内);
						this.Are.Draw(this.ハンド右.X5Y1_呪印_輪2_輪外);
						this.Are.Draw(this.ハンド右.X5Y1_呪印_輪2_輪内);
						this.Are.Draw(this.ハンド右.X5Y1_呪印_輪3_輪外);
						this.Are.Draw(this.ハンド右.X5Y1_呪印_輪3_輪内);
						this.Are.Draw(this.ハンド右.X5Y1_呪印_鎖1);
						this.Are.Draw(this.ハンド右.X5Y1_呪印_鎖2);
						this.Are.Draw(this.ハンド右.X5Y1_呪印_鎖3);
						return;
					case 2:
						this.Are.Draw(this.ハンド右.X5Y2_親指);
						this.Are.Draw(this.ハンド右.X5Y2_手);
						this.Are.Draw(this.ハンド右.X5Y2_小指);
						this.Are.Draw(this.ハンド右.X5Y2_薬指);
						this.Are.Draw(this.ハンド右.X5Y2_中指);
						this.Are.Draw(this.ハンド右.X5Y2_人指);
						this.Are.Draw(this.ハンド右.X5Y2_呪印_輪1_輪外);
						this.Are.Draw(this.ハンド右.X5Y2_呪印_輪1_輪内);
						this.Are.Draw(this.ハンド右.X5Y2_呪印_輪2_輪外);
						this.Are.Draw(this.ハンド右.X5Y2_呪印_輪2_輪内);
						this.Are.Draw(this.ハンド右.X5Y2_呪印_輪3_輪外);
						this.Are.Draw(this.ハンド右.X5Y2_呪印_輪3_輪内);
						this.Are.Draw(this.ハンド右.X5Y2_呪印_鎖1);
						this.Are.Draw(this.ハンド右.X5Y2_呪印_鎖2);
						this.Are.Draw(this.ハンド右.X5Y2_呪印_鎖3);
						return;
					case 3:
						this.Are.Draw(this.ハンド右.X5Y3_親指);
						this.Are.Draw(this.ハンド右.X5Y3_手);
						this.Are.Draw(this.ハンド右.X5Y3_小指);
						this.Are.Draw(this.ハンド右.X5Y3_薬指);
						this.Are.Draw(this.ハンド右.X5Y3_中指);
						this.Are.Draw(this.ハンド右.X5Y3_人指);
						this.Are.Draw(this.ハンド右.X5Y3_呪印_輪1_輪外);
						this.Are.Draw(this.ハンド右.X5Y3_呪印_輪1_輪内);
						this.Are.Draw(this.ハンド右.X5Y3_呪印_輪2_輪外);
						this.Are.Draw(this.ハンド右.X5Y3_呪印_輪2_輪内);
						this.Are.Draw(this.ハンド右.X5Y3_呪印_輪3_輪外);
						this.Are.Draw(this.ハンド右.X5Y3_呪印_輪3_輪内);
						this.Are.Draw(this.ハンド右.X5Y3_呪印_鎖1);
						this.Are.Draw(this.ハンド右.X5Y3_呪印_鎖2);
						this.Are.Draw(this.ハンド右.X5Y3_呪印_鎖3);
						return;
					default:
						this.Are.Draw(this.ハンド右.X5Y4_親指);
						this.Are.Draw(this.ハンド右.X5Y4_手);
						this.Are.Draw(this.ハンド右.X5Y4_小指);
						this.Are.Draw(this.ハンド右.X5Y4_薬指);
						this.Are.Draw(this.ハンド右.X5Y4_中指);
						this.Are.Draw(this.ハンド右.X5Y4_人指);
						this.Are.Draw(this.ハンド右.X5Y4_呪印_輪1_輪外);
						this.Are.Draw(this.ハンド右.X5Y4_呪印_輪1_輪内);
						this.Are.Draw(this.ハンド右.X5Y4_呪印_輪2_輪外);
						this.Are.Draw(this.ハンド右.X5Y4_呪印_輪2_輪内);
						this.Are.Draw(this.ハンド右.X5Y4_呪印_輪3_輪外);
						this.Are.Draw(this.ハンド右.X5Y4_呪印_輪3_輪内);
						this.Are.Draw(this.ハンド右.X5Y4_呪印_鎖1);
						this.Are.Draw(this.ハンド右.X5Y4_呪印_鎖2);
						this.Are.Draw(this.ハンド右.X5Y4_呪印_鎖3);
						return;
					}
				}
			}
		}

		public void 通常放し()
		{
			this.focus.Ele.濃度 = 0.5;
			this.Focus = this.ハンド右CM;
			if (this.Med.Mode == "調教")
			{
				Cursor.Position = this.Med.BaseControlC.PointToScreen(this.Med.FromBasePosition(this.ハンド右.位置B));
			}
			this.Set持ち手();
		}

		public void 挿入放し()
		{
			this.sf = false;
			if (this.膣i肛f)
			{
				if (this.Focus == this.ペニスCM)
				{
					this.SubFocus.Insert(0, this.ペニス挿入);
					this.ペニスCM.使用状態 = 使用状態.装着;
				}
				else if (this.Focus == this.マウスCM)
				{
					this.SubFocus.Insert(0, this.マウス挿入);
					this.マウスCM.使用状態 = 使用状態.装着;
				}
				else if (this.Focus == this.ハンド右CM)
				{
					this.SubFocus.Insert(0, this.ハンド挿入);
					this.ハンド右CM.使用状態 = 使用状態.装着;
				}
				else if (this.Focus == this.ロ\u30FCタCM)
				{
					this.SubFocus.Insert(0, this.ロ\u30FCタ挿入);
					this.ロ\u30FCタCM.使用状態 = 使用状態.装着;
				}
				else if (this.Focus == this.コモンCM)
				{
					this.SubFocus.Insert(0, this.コモン挿入);
					this.コモンCM.使用状態 = 使用状態.装着;
				}
				else if (this.Focus == this.ディルCM)
				{
					this.SubFocus.Insert(0, this.ディル挿入);
					this.ディルCM.使用状態 = 使用状態.装着;
				}
				else if (this.Focus == this.アナルCM)
				{
					this.SubFocus.Insert(0, this.アナル挿入);
					this.アナルCM.使用状態 = 使用状態.装着;
				}
				else if (this.Focus == this.デンマCM)
				{
					this.SubFocus.Insert(0, this.デンマ挿入);
					this.デンマCM.使用状態 = 使用状態.装着;
				}
				else if (this.Focus == this.ドリルCM)
				{
					this.SubFocus.Insert(0, this.ドリル挿入);
					this.ドリルCM.使用状態 = 使用状態.装着;
				}
				else if (this.Focus == this.パ\u30FCルCM)
				{
					this.SubFocus.Insert(0, this.パ\u30FCル挿入);
					this.パ\u30FCルCM.使用状態 = 使用状態.装着;
				}
			}
			else if (this.Focus == this.ペニスCM)
			{
				this.SubFocus.Add(this.ペニス挿入);
				this.ペニスCM.使用状態 = 使用状態.装着;
			}
			else if (this.Focus == this.マウスCM)
			{
				this.SubFocus.Add(this.マウス挿入);
				this.マウスCM.使用状態 = 使用状態.装着;
			}
			else if (this.Focus == this.ハンド右CM)
			{
				this.SubFocus.Add(this.ハンド挿入);
				this.ハンド右CM.使用状態 = 使用状態.装着;
			}
			else if (this.Focus == this.ロ\u30FCタCM)
			{
				this.SubFocus.Add(this.ロ\u30FCタ挿入);
				this.ロ\u30FCタCM.使用状態 = 使用状態.装着;
			}
			else if (this.Focus == this.コモンCM)
			{
				this.SubFocus.Add(this.コモン挿入);
				this.コモンCM.使用状態 = 使用状態.装着;
			}
			else if (this.Focus == this.ディルCM)
			{
				this.SubFocus.Add(this.ディル挿入);
				this.ディルCM.使用状態 = 使用状態.装着;
			}
			else if (this.Focus == this.アナルCM)
			{
				this.SubFocus.Add(this.アナル挿入);
				this.アナルCM.使用状態 = 使用状態.装着;
			}
			else if (this.Focus == this.デンマCM)
			{
				this.SubFocus.Add(this.デンマ挿入);
				this.デンマCM.使用状態 = 使用状態.装着;
			}
			else if (this.Focus == this.ドリルCM)
			{
				this.SubFocus.Add(this.ドリル挿入);
				this.ドリルCM.使用状態 = 使用状態.装着;
			}
			else if (this.Focus == this.パ\u30FCルCM)
			{
				this.SubFocus.Add(this.パ\u30FCル挿入);
				this.パ\u30FCルCM.使用状態 = 使用状態.装着;
			}
			this.Focus.Ele.SetHitTrue();
			this.Focus_nr = this.ハンド右CM;
			Cursor.Position = this.Med.BaseControlC.PointToScreen(this.Med.FromBasePosition(this.ハンド右.位置B));
			this.Set持ち手();
		}

		private void SetIs膣i肛f()
		{
			挿入処理 挿入処理 = this.Get挿入処理();
			this.肛f = (挿入処理 != null && 挿入処理.Is肛);
			bool flag;
			if (this.肛f)
			{
				flag = this.SubFocus.Any((挿入処理 e) => e.Is膣);
			}
			else
			{
				flag = false;
			}
			this.膣i肛f = flag;
		}

		public void Setハンド左(挿入処理 i)
		{
			if (i == this.ロ\u30FCタ挿入)
			{
				this.Set_ロ\u30FCタ(this.ハンド左);
			}
			else if (i == this.コモン挿入)
			{
				this.Set_コモン(this.ハンド左);
			}
			else if (i == this.ディル挿入)
			{
				this.Set_ディル(this.ハンド左);
			}
			else if (i == this.アナル挿入)
			{
				this.Set_アナル(this.ハンド左);
			}
			else if (i == this.デンマ挿入)
			{
				this.Set_デンマ(this.ハンド左);
			}
			else if (i == this.ドリル挿入)
			{
				this.Set_ドリル(this.ハンド左);
			}
			else if (i == this.パ\u30FCル挿入)
			{
				this.Set_パ\u30FCル(this.ハンド左);
			}
			this.ハンド左CM.Draws(this.Are);
		}

		public void 押し(ref 接触D cd)
		{
			if (this.IsHitCha(ref cd) || this.focus == this.羽根箒CM || this.focus == this.調教鞭CM)
			{
				this.focus.Ele.尺度C = 1.0;
				if (this.持ち手 || this.ペニス処理.Isパイズリ)
				{
					this.ハンド右.尺度C = 1.0;
				}
				this.ハンド左.尺度C = 1.0;
				this.押し状態 = true;
			}
		}

		public void 放し()
		{
			if (!this.Is挿入)
			{
				this.focus.Ele.尺度C = 1.09;
				if (this.持ち手 || this.ペニス処理.Isパイズリ)
				{
					this.ハンド右.尺度C = 1.09;
				}
				this.ハンド左.尺度C = 1.09;
				this.押し状態 = false;
			}
		}

		public void くぱぁ閉じ時()
		{
			if (this.ペニス挿入.Is膣 || this.ペニス挿入.Is肛)
			{
				this.ペニス挿入.抜け落ち.Sta();
			}
			if (this.マウス挿入.Is膣 || this.マウス挿入.Is肛)
			{
				this.マウス挿入.抜け落ち.Sta();
			}
			if (this.ハンド挿入.Is膣 || this.ハンド挿入.Is肛)
			{
				this.ハンド挿入.抜け落ち.Sta();
			}
			if (this.ロ\u30FCタ挿入.Is膣 || this.ロ\u30FCタ挿入.Is肛)
			{
				this.ロ\u30FCタ挿入.抜け落ち.Sta();
			}
			if (this.コモン挿入.Is膣 || this.コモン挿入.Is肛)
			{
				this.コモン挿入.抜け落ち.Sta();
			}
			if (this.ディル挿入.Is膣 || this.ディル挿入.Is肛)
			{
				this.ディル挿入.抜け落ち.Sta();
			}
			if (this.アナル挿入.Is膣 || this.アナル挿入.Is肛)
			{
				this.アナル挿入.抜け落ち.Sta();
			}
			if (this.デンマ挿入.Is膣 || this.デンマ挿入.Is肛)
			{
				this.デンマ挿入.抜け落ち.Sta();
			}
			if (this.ドリル挿入.Is膣 || this.ドリル挿入.Is肛)
			{
				this.ドリル挿入.抜け落ち.Sta();
			}
			if (this.パ\u30FCル挿入.Is膣 || this.パ\u30FCル挿入.Is肛)
			{
				this.パ\u30FCル挿入.抜け落ち.Sta();
			}
		}

		public bool Is乳弄り
		{
			get
			{
				return this.ハンド処理.Is乳捏ね || this.ハンド処理.Is乳摘み || this.ハンド処理.Is乳繰り || (this.ペニス処理.Isパイズリ && !this.ペニス処理.Isパイズリ他動) || this.ハンド処理.Is核捏ね || this.ハンド挿入.Is膣;
			}
		}

		public bool Is口挿入
		{
			get
			{
				return this.ペニス挿入.Is口 || this.マウス挿入.Is口 || this.ハンド挿入.Is口 || this.ロ\u30FCタ挿入.Is口 || this.コモン挿入.Is口 || this.ディル挿入.Is口 || this.アナル挿入.Is口 || this.デンマ挿入.Is口 || this.ドリル挿入.Is口 || this.パ\u30FCル挿入.Is口;
			}
		}

		public bool Is膣挿入
		{
			get
			{
				return this.ペニス挿入.Is膣 || this.マウス挿入.Is膣 || this.ハンド挿入.Is膣 || this.ロ\u30FCタ挿入.Is膣 || this.コモン挿入.Is膣 || this.ディル挿入.Is膣 || this.アナル挿入.Is膣 || this.デンマ挿入.Is膣 || this.ドリル挿入.Is膣 || this.パ\u30FCル挿入.Is膣;
			}
		}

		public bool Is肛挿入
		{
			get
			{
				return this.ペニス挿入.Is肛 || this.マウス挿入.Is肛 || this.ハンド挿入.Is肛 || this.ロ\u30FCタ挿入.Is肛 || this.コモン挿入.Is肛 || this.ディル挿入.Is肛 || this.アナル挿入.Is肛 || this.デンマ挿入.Is肛 || this.ドリル挿入.Is肛 || this.パ\u30FCル挿入.Is肛;
			}
		}

		public bool Is糸挿入
		{
			get
			{
				return this.ペニス挿入.Is糸 || this.マウス挿入.Is糸 || this.ハンド挿入.Is糸 || this.ロ\u30FCタ挿入.Is糸 || this.コモン挿入.Is糸 || this.ディル挿入.Is糸 || this.アナル挿入.Is糸 || this.デンマ挿入.Is糸 || this.ドリル挿入.Is糸 || this.パ\u30FCル挿入.Is糸;
			}
		}

		public bool Isフォ\u30FCカス糸挿入
		{
			get
			{
				return (this.focus == this.ペニスCM && this.ペニス挿入.Is糸) || (this.focus == this.マウスCM && this.マウス挿入.Is糸) || (this.focus == this.ハンド右CM && this.ハンド挿入.Is糸) || (this.focus == this.ロ\u30FCタCM && this.ロ\u30FCタ挿入.Is糸) || (this.focus == this.コモンCM && this.コモン挿入.Is糸) || (this.focus == this.ディルCM && this.ディル挿入.Is糸) || (this.focus == this.アナルCM && this.アナル挿入.Is糸) || (this.focus == this.デンマCM && this.デンマ挿入.Is糸) || (this.focus == this.ドリルCM && this.ドリル挿入.Is糸) || (this.focus == this.パ\u30FCルCM && this.パ\u30FCル挿入.Is糸);
			}
		}

		public bool IsSub糸挿入
		{
			get
			{
				return this.SubFocus.Any((挿入処理 e) => e.Is糸);
			}
		}

		public bool Isフォ\u30FCカス膣肛挿入
		{
			get
			{
				return (this.focus == this.ペニスCM && (this.ペニス挿入.Is膣 || this.ペニス挿入.Is肛)) || (this.focus == this.マウスCM && (this.マウス挿入.Is膣 || this.マウス挿入.Is肛)) || (this.focus == this.ハンド右CM && (this.ハンド挿入.Is膣 || this.ハンド挿入.Is肛)) || (this.focus == this.ロ\u30FCタCM && (this.ロ\u30FCタ挿入.Is膣 || this.ロ\u30FCタ挿入.Is肛)) || (this.focus == this.コモンCM && (this.コモン挿入.Is膣 || this.コモン挿入.Is肛)) || (this.focus == this.ディルCM && (this.ディル挿入.Is膣 || this.ディル挿入.Is肛)) || (this.focus == this.アナルCM && (this.アナル挿入.Is膣 || this.アナル挿入.Is肛)) || (this.focus == this.デンマCM && (this.デンマ挿入.Is膣 || this.デンマ挿入.Is肛)) || (this.focus == this.ドリルCM && (this.ドリル挿入.Is膣 || this.ドリル挿入.Is肛)) || (this.focus == this.パ\u30FCルCM && (this.パ\u30FCル挿入.Is膣 || this.パ\u30FCル挿入.Is肛));
			}
		}

		public bool Isフォ\u30FCカス膣挿入
		{
			get
			{
				return (this.focus == this.ペニスCM && this.ペニス挿入.Is膣) || (this.focus == this.マウスCM && this.マウス挿入.Is膣) || (this.focus == this.ハンド右CM && this.ハンド挿入.Is膣) || (this.focus == this.ロ\u30FCタCM && this.ロ\u30FCタ挿入.Is膣) || (this.focus == this.コモンCM && this.コモン挿入.Is膣) || (this.focus == this.ディルCM && this.ディル挿入.Is膣) || (this.focus == this.アナルCM && this.アナル挿入.Is膣) || (this.focus == this.デンマCM && this.デンマ挿入.Is膣) || (this.focus == this.ドリルCM && this.ドリル挿入.Is膣) || (this.focus == this.パ\u30FCルCM && this.パ\u30FCル挿入.Is膣);
			}
		}

		public void 脚修正()
		{
			if (!this.Bod.Is拘束 && this.Bod.脚人n > 0)
			{
				this.Cha.脚();
				this.Cha.Bod.腿Update();
			}
		}

		public void 腕修正()
		{
			if (!this.Bod.Is拘束 && this.Bod.腕人n > 0 && this.Bod.Is最前腕人)
			{
				this.Cha.腕();
				this.Cha.Bod.EI腕前.Updatef = true;
			}
		}

		public void 大顎修正()
		{
			if (!this.Bod.Is拘束 && this.Bod.大顎n > 0)
			{
				this.Cha.顎();
			}
		}

		private void SubInfoSet(ref MouseButtons mb, ref Vector2D cp, ref Vector2D op, ref Color hc, ref 接触D cd)
		{
			this.ペニス処理.Move(ref mb, ref cp, ref hc, ref cd);
			this.マウス処理.Move(ref mb, ref cp, ref hc, ref cd);
			this.ハンド処理.Move(ref mb, ref cp, ref hc, ref cd);
			this.ロ\u30FCタ挿入.Move(ref mb, ref cp, ref hc, ref cd);
			this.コモン挿入.Move(ref mb, ref cp, ref hc, ref cd);
			this.ディル挿入.Move(ref mb, ref cp, ref hc, ref cd);
			this.アナル挿入.Move(ref mb, ref cp, ref hc, ref cd);
			this.デンマ挿入.Move(ref mb, ref cp, ref hc, ref cd);
			this.ドリル挿入.Move(ref mb, ref cp, ref hc, ref cd);
			this.パ\u30FCル挿入.Move(ref mb, ref cp, ref hc, ref cd);
			this.キャップ処理.Move(ref mb, ref cp, ref op, ref hc, ref cd);
			this.羽箒処理.Move(ref mb, ref cp, ref hc, ref cd);
			this.剃刀処理.Move(ref mb, ref cp, ref op, ref hc, ref cd);
			this.調鞭処理.Move(ref mb, ref cp, ref hc, ref cd);
		}

		public void Move(ref MouseButtons mb, ref Vector2D cp, ref Vector2D op, ref Color hc, ref 接触D cd)
		{
			if (this.d == mb)
			{
				if (!this.Is挿入 && !this.ペニス処理.Isパイズリ && !this.マウス処理.Is吸付 && !this.コキ)
				{
					this.Focus.Ele.位置B = cp;
				}
				if (this.IsTool = (this.X < cp.X && cp.Y < this.Y && mb != MouseButtons.Left && !this.Isモ\u30FCド))
				{
					this.Med.CursorShow();
					if (this.focus.Ele.濃度 == 1.0)
					{
						this.Focus.Ele.濃度 = 0.2;
					}
					this.In持ち手();
					Color hc_ = hc;
					this.hcm = (from e in this.EnumCM()
					where e.使用状態 == 使用状態.待機
					select e).FirstOrDefault((CM e) => e.Ele.本体.IsHit(ref hc_));
					if (this.hcm != null)
					{
						foreach (CM cm in from e in this.EnumCM()
						where e.使用状態 == 使用状態.待機
						select e)
						{
							cm.Ele.濃度 = 0.5;
						}
						this.hcm.Ele.濃度 = 1.0;
						goto IL_446;
					}
					using (IEnumerator<CM> enumerator = (from e in this.EnumCM()
					where e.使用状態 == 使用状態.待機 && e.Ele.濃度 == 1.0
					select e).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							CM cm2 = enumerator.Current;
							cm2.Ele.濃度 = 0.5;
						}
						goto IL_446;
					}
				}
				if (this.ip.MaiShow)
				{
					this.Med.CursorShow();
				}
				else
				{
					this.Med.CursorHide();
				}
				if (this.focus.Ele.濃度 == 0.2)
				{
					this.Focus.Ele.濃度 = 1.0;
				}
				this.Out持ち手();
				foreach (CM cm3 in from e in this.EnumCM()
				where e.使用状態 == 使用状態.待機 && e.Ele.濃度 == 1.0
				select e)
				{
					cm3.Ele.濃度 = 0.5;
				}
				if (!this.Isモ\u30FCド)
				{
					this.調教終了.Move(ref hc);
					this.拘束具.Move(ref hc);
					this.目隠帯.Move(ref hc);
					this.玉口枷.Move(ref hc);
					this.断面.Move(ref hc);
					this.媚薬.Move(ref hc);
					this.撮影.Move(ref hc);
					this.SlaveStamina.Move(ref hc);
					this.PlayerStamina.Move(ref hc);
					if (this.調教終了.Pars.IsHit(ref hc) || this.拘束具.Pars.IsHit(ref hc) || this.目隠帯.Pars.IsHit(ref hc) || this.玉口枷.Pars.IsHit(ref hc) || this.断面.Pars.IsHit(ref hc) || this.媚薬.Pars.IsHit(ref hc) || this.撮影.Pars.IsHit(ref hc))
					{
						this.Med.CursorShow();
					}
					else if (this.ip.MaiShow)
					{
						this.Med.CursorShow();
					}
					else if (this.SlaveStamina.Pars.IsHit(ref hc) || this.PlayerStamina.Pars.IsHit(ref hc))
					{
						this.Med.CursorShow();
					}
					else
					{
						this.Med.CursorHide();
					}
				}
				IL_446:
				this.肛oh = false;
				this.ef = null;
				if (this.sf && !this.ハンド処理.Isモ\u30FCド && this.Focus == this.ハンド右CM && this.SubFocus.Count > 0)
				{
					bool flag = true;
					foreach (挿入処理 挿入処理 in this.SubFocus)
					{
						if (flag = 挿入処理.対象.Ele.本体.IsHit(ref hc))
						{
							if (挿入処理.対象 == this.ロ\u30FCタCM)
							{
								this.Set_ロ\u30FCタ(this.ハンド右);
								this.ハンド右.Xi = 11;
							}
							else if (挿入処理.対象 == this.コモンCM)
							{
								this.Set_コモン(this.ハンド右);
								this.ハンド右.Xi = 13;
							}
							else if (挿入処理.対象 == this.ディルCM)
							{
								this.Set_ディル(this.ハンド右);
								this.ハンド右.Xi = 13;
							}
							else if (挿入処理.対象 == this.アナルCM)
							{
								this.Set_アナル(this.ハンド右);
								this.ハンド右.Xi = 13;
							}
							else if (挿入処理.対象 == this.デンマCM)
							{
								this.Set_デンマ(this.ハンド右);
								this.ハンド右.Xi = 13;
							}
							else if (挿入処理.対象 == this.ドリルCM)
							{
								this.Set_ドリル(this.ハンド右);
								this.ハンド右.Xi = 13;
							}
							else if (挿入処理.対象 == this.パ\u30FCルCM)
							{
								this.Set_パ\u30FCル(this.ハンド右);
								this.ハンド右.Xi = 11;
							}
							else if (挿入処理.対象 == this.羽根箒CM)
							{
								this.Set_羽根箒(this.ハンド右);
								this.ハンド右.Xi = 11;
							}
							else if (挿入処理.対象 == this.調教鞭CM)
							{
								this.Set_調教鞭(this.ハンド右);
								this.ハンド右.Xi = 11;
							}
							else if (挿入処理.対象 == this.T剃刀CM)
							{
								this.Set_T剃刀(this.ハンド右);
								this.ハンド右.Xi = 11;
							}
							this.ef = 挿入処理;
							if (Sta.GameData.ガイド)
							{
								this.ip.SubInfoIm = ((挿入処理.対象 == this.ペニスCM) ? ("LCl:" + tex.選択) : ("LCl:" + tex.持つ));
							}
							挿入処理 挿入処理2 = this.Get挿入処理(ref hc);
							this.肛oh = (挿入処理2 != null && 挿入処理2.Is肛 && this.focus == this.ハンド右CM);
							break;
						}
					}
					if (!flag)
					{
						if (this.ハンド右.Xi == 11 || this.ハンド右.Xi == 13)
						{
							this.ハンド右.Xi = 0;
						}
						this.ef = null;
					}
				}
				else
				{
					this.sf = true;
				}
				if (!this.ペニス処理.手コキ.Run && !this.ペニス処理.足コキ.Run)
				{
					this.ペニス処理.Move(ref mb, ref cp, ref hc, ref cd);
					this.マウス処理.Move(ref mb, ref cp, ref hc, ref cd);
					this.ハンド処理.Move(ref mb, ref cp, ref hc, ref cd);
					this.ロ\u30FCタ挿入.Move(ref mb, ref cp, ref hc, ref cd);
					this.コモン挿入.Move(ref mb, ref cp, ref hc, ref cd);
					this.ディル挿入.Move(ref mb, ref cp, ref hc, ref cd);
					this.アナル挿入.Move(ref mb, ref cp, ref hc, ref cd);
					this.デンマ挿入.Move(ref mb, ref cp, ref hc, ref cd);
					this.ドリル挿入.Move(ref mb, ref cp, ref hc, ref cd);
					this.パ\u30FCル挿入.Move(ref mb, ref cp, ref hc, ref cd);
					this.キャップ処理.Move(ref mb, ref cp, ref op, ref hc, ref cd);
					this.羽箒処理.Move(ref mb, ref cp, ref hc, ref cd);
					this.剃刀処理.Move(ref mb, ref cp, ref op, ref hc, ref cd);
					this.調鞭処理.Move(ref mb, ref cp, ref hc, ref cd);
				}
				this.IsTB = false;
				this.挿入処理f = this.Get挿入処理();
				if (this.IsTB = (this.Isバイブ(this.focus) && this.挿入処理f != null && ((this.挿入処理f.Is膣 && this.SubFocus.Any((挿入処理 e) => e.Is肛 && this.Isバイブ(e.対象))) || (this.挿入処理f.Is肛 && this.SubFocus.Any((挿入処理 e) => e.Is膣 && this.Isバイブ(e.対象))))))
				{
					if (this.挿入処理f.Is膣)
					{
						(this.挿入処理s = this.SubFocus.First((挿入処理 e) => e.Is肛)).MoveR(ref mb, ref cp, ref hc, ref cd);
					}
					else if (this.挿入処理f.Is肛)
					{
						(this.挿入処理s = this.SubFocus.First((挿入処理 e) => e.Is膣)).MoveR(ref mb, ref cp, ref hc, ref cd);
					}
					this.挿入処理s.抜け落ち.End();
					if (this.挿入処理s == this.ロ\u30FCタ挿入)
					{
						this.Set_ロ\u30FCタ(this.ハンド左);
						this.ハンド左.Xi = 11;
					}
					else if (this.挿入処理s == this.コモン挿入)
					{
						this.Set_コモン(this.ハンド左);
						this.ハンド左.Xi = 13;
					}
					else if (this.挿入処理s == this.ディル挿入)
					{
						this.Set_ディル(this.ハンド左);
						this.ハンド左.Xi = 13;
					}
					else if (this.挿入処理s == this.アナル挿入)
					{
						this.Set_アナル(this.ハンド左);
						this.ハンド左.Xi = 13;
					}
					else if (this.挿入処理s == this.デンマ挿入)
					{
						this.Set_デンマ(this.ハンド左);
						this.ハンド左.Xi = 13;
					}
					else if (this.挿入処理s == this.ドリル挿入)
					{
						this.Set_ドリル(this.ハンド左);
						this.ハンド左.Xi = 13;
					}
					else if (this.挿入処理s == this.パ\u30FCル挿入)
					{
						this.Set_パ\u30FCル(this.ハンド左);
						this.ハンド左.Xi = 11;
					}
				}
				this.SetIs膣i肛f();
				if (Sta.GameData.ガイド && this.IsTool && this.hcm != null)
				{
					this.ip.SubInfoIm = ((this.hcm == this.ペニスCM || this.hcm == this.マウスCM || this.hcm == this.ハンド右CM) ? ("LCl:" + tex.選択) : ("LCl:" + tex.持つ));
				}
				if (this.拘束具.Pars.Values.First<object>().ToPar().HitColor == hc)
				{
					this.ip.SubInfoIm = tex.拘束状態を切換えます;
				}
				if (this.目隠帯.Pars.Values.First<object>().ToPar().HitColor == hc)
				{
					this.ip.SubInfoIm = tex.目隠状態を切換えます;
				}
				if (this.玉口枷.Pars.Values.First<object>().ToPar().HitColor == hc)
				{
					this.ip.SubInfoIm = tex.口枷状態を切換えます;
				}
				if (this.断面.Pars.Values.First<object>().ToPar().HitColor == hc)
				{
					this.ip.SubInfoIm = tex.断面表示を切換えます;
				}
				if (this.媚薬.Pars.Values.First<object>().ToPar().HitColor == hc)
				{
					this.ip.SubInfoIm = tex.発情状態になります + "(-" + this.媚薬投与価格.ToString("#,0") + ")";
				}
				if (this.SlaveStamina.Pars.Values.First<object>().ToPar().HitColor == hc)
				{
					this.ip.SubInfoIm = "Reset slave's stamina";
				}
				if (this.PlayerStamina.Pars.Values.First<object>().ToPar().HitColor == hc)
				{
					this.ip.SubInfoIm = "Reset player's stamina";
				}
				if (this.撮影.Pars.Values.First<object>().ToPar().HitColor == hc && this.ip.SubInfoIm != tex.撮影しました + "\r\n" + tex.写真はPhotoフォルダに保存されます)
				{
					this.ip.SubInfoIm = tex.撮影を行います;
				}
			}
		}

		public void Down(ref MouseButtons mb, ref Vector2D cp, ref Vector2D op, ref Color hc, ref 接触D cd)
		{
			if (this.d == MouseButtons.None)
			{
				if (Act.強制終了)
				{
					Act.強制終了 = false;
					this.調教終了.Action(this.調教終了);
					return;
				}
				if (this.X < cp.X && cp.Y < this.Y)
				{
					Color hc_ = hc;
					CM cm = (from e in this.EnumCM()
					where e.使用状態 == 使用状態.待機
					select e).FirstOrDefault((CM e) => e.Ele.本体.IsHit(ref hc_));
					if (cm != null)
					{
						this.Focus.Ele.濃度 = 0.5;
						this.Focus = cm;
						this.Focus.Ele.濃度 = 0.2;
						this.Focus.Ele.位置B = this.Med.CursorPosition;
						this.Set持ち手();
						if (this.持ち手)
						{
							this.ハンド右.濃度 = 0.2;
						}
						else
						{
							this.ハンド右.位置B = this.ハンド右CM.bp;
						}
						this.SubInfoSet(ref mb, ref cp, ref op, ref hc, ref cd);
					}
				}
				else
				{
					this.調教終了.Down(ref hc);
					this.拘束具.Down(ref hc);
					this.目隠帯.Down(ref hc);
					this.玉口枷.Down(ref hc);
					this.断面.Down(ref hc);
					this.媚薬.Down(ref hc);
					this.撮影.Down(ref hc);
					this.SlaveStamina.Down(ref hc);
					this.PlayerStamina.Down(ref hc);
				}
				if (this.Focus == this.ハンド右CM && this.SubFocus.Count > 0 && this.ef != null)
				{
					this.ef.抜け落ち.End();
					this.SubFocus.Remove(this.ef);
					this.Focus = this.ef.対象;
					this.ef.挿抜モ\u30FCション.End();
					if (this.ef != this.ペニス挿入)
					{
						this.ef.挿抜フラグ = true;
					}
					this.ef = null;
					this.Set持ち手();
				}
				this.ペニス処理.Down(ref mb, ref cp, ref hc, ref cd);
				this.マウス処理.Down(ref mb, ref cp, ref hc, ref cd);
				this.ハンド処理.Down(ref mb, ref cp, ref hc, ref cd);
				this.ロ\u30FCタ挿入.Down(ref mb, ref cp, ref hc, ref cd);
				this.コモン挿入.Down(ref mb, ref cp, ref hc, ref cd);
				this.ディル挿入.Down(ref mb, ref cp, ref hc, ref cd);
				this.アナル挿入.Down(ref mb, ref cp, ref hc, ref cd);
				this.デンマ挿入.Down(ref mb, ref cp, ref hc, ref cd);
				this.ドリル挿入.Down(ref mb, ref cp, ref hc, ref cd);
				this.パ\u30FCル挿入.Down(ref mb, ref cp, ref hc, ref cd);
				this.キャップ処理.Down(ref mb, ref cp, ref op, ref hc, ref cd);
				this.羽箒処理.Down(ref mb, ref cp, ref hc, ref cd);
				this.剃刀処理.Down(ref mb, ref cp, ref hc, ref cd);
				this.調鞭処理.Down(ref mb, ref cp, ref hc, ref cd);
				this.SetIs膣i肛f();
				this.d = mb;
			}
		}

		public void Up(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref 接触D cd)
		{
			if (this.d == mb)
			{
				this.調教終了.Up(ref hc);
				this.拘束具.Up(ref hc);
				this.目隠帯.Up(ref hc);
				this.玉口枷.Up(ref hc);
				this.断面.Up(ref hc);
				this.媚薬.Up(ref hc);
				this.撮影.Up(ref hc);
				this.SlaveStamina.Up(ref hc);
				this.PlayerStamina.Up(ref hc);
				this.ペニス処理.Up(ref mb, ref cp, ref hc, ref cd);
				this.マウス処理.Up(ref mb, ref cp, ref hc, ref cd);
				this.ハンド処理.Up(ref mb, ref cp, ref hc, ref cd);
				this.ロ\u30FCタ挿入.Up(ref mb, ref cp, ref hc, ref cd);
				this.コモン挿入.Up(ref mb, ref cp, ref hc, ref cd);
				this.ディル挿入.Up(ref mb, ref cp, ref hc, ref cd);
				this.アナル挿入.Up(ref mb, ref cp, ref hc, ref cd);
				this.デンマ挿入.Up(ref mb, ref cp, ref hc, ref cd);
				this.ドリル挿入.Up(ref mb, ref cp, ref hc, ref cd);
				this.パ\u30FCル挿入.Up(ref mb, ref cp, ref hc, ref cd);
				this.キャップ処理.Up(ref mb, ref cp, ref hc);
				this.羽箒処理.Up(ref mb, ref cp, ref hc, ref cd);
				this.剃刀処理.Up(ref mb, ref cp, ref hc, ref cd);
				this.d = MouseButtons.None;
			}
		}

		public void Wheel(ref MouseButtons mb, ref Vector2D cp, ref int dt, ref Color hc, ref 接触D cd)
		{
			this.ペニス処理.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
			this.マウス処理.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
			this.ハンド処理.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
			this.ロ\u30FCタ挿入.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
			this.コモン挿入.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
			this.ディル挿入.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
			this.アナル挿入.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
			this.デンマ挿入.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
			this.ドリル挿入.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
			this.パ\u30FCル挿入.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
			this.羽箒処理.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
			this.調鞭処理.Wheel(ref mb, ref cp, ref dt, ref hc);
		}

		public void Leave(ref MouseButtons mb, ref Vector2D cp, ref Color hc)
		{
			this.Med.CursorShow();
			this.調教終了.Leave();
			this.拘束具.Leave();
			this.目隠帯.Leave();
			this.玉口枷.Leave();
			this.断面.Leave();
			this.媚薬.Leave();
			this.撮影.Leave();
			this.SlaveStamina.Leave();
			this.PlayerStamina.Leave();
		}

		public 調教UI()
		{
		}

		public 調教UI(Med Med, Are Are, 情報パネル ip)
		{
			調教UI <>4__this = this;
			try
			{
				this.Med = Med;
				this.Are = Are;
				double disUnit = Are.DisUnit;
				this.ip = ip;
				this.ペニスCM = new CM(Med, this, this.ペニス = new ペニス(disUnit, 配色指定.N0, Sta.GameData.配色, Med, new ペニスD
				{
					濃度 = 0.5,
					尺度C = 1.09
				}));
				this.マウスCM = new CM(Med, this, this.マウス = new マウス(disUnit, 配色指定.N0, Sta.GameData.配色, Med, new マウスD
				{
					濃度 = 0.5,
					尺度C = 1.09
				}));
				this.ハンド右CM = new CM(Med, this, this.ハンド右 = new ハンド(disUnit, 配色指定.N0, Sta.GameData.配色, Med, new ハンドD
				{
					尺度C = 1.09,
					呪印_輪1_輪外_表示 = false,
					呪印_輪1_輪内_表示 = false,
					呪印_輪2_輪外_表示 = false,
					呪印_輪2_輪内_表示 = false,
					呪印_輪3_輪外_表示 = false,
					呪印_輪3_輪内_表示 = false,
					呪印_鎖1_表示 = false,
					呪印_鎖2_表示 = false,
					呪印_鎖3_表示 = false
				}));
				this.ハンド左CM = new CM(Med, this, this.ハンド左 = new ハンド(disUnit, 配色指定.N0, Sta.GameData.配色, Med, new ハンドD
				{
					尺度C = 1.09,
					呪印_輪1_輪外_表示 = false,
					呪印_輪1_輪内_表示 = false,
					呪印_輪2_輪外_表示 = false,
					呪印_輪2_輪内_表示 = false,
					呪印_輪3_輪外_表示 = false,
					呪印_輪3_輪内_表示 = false,
					呪印_鎖1_表示 = false,
					呪印_鎖2_表示 = false,
					呪印_鎖3_表示 = false,
					右 = true
				}));
				this.ハンド左.SetHitFalse();
				this.ロ\u30FCタCM = new CM(Med, this, this.ロ\u30FCタ = new ロ\u30FCタ(disUnit, 配色指定.N0, null, Med, new ロ\u30FCタD
				{
					濃度 = 0.5,
					尺度C = 1.09
				}));
				this.コモンCM = new CM(Med, this, this.コモン = new バイブ_コモン(disUnit, 配色指定.N0, null, Med, new バイブ_コモンD
				{
					濃度 = 0.5,
					尺度C = 1.09
				}));
				this.ディルCM = new CM(Med, this, this.ディル = new バイブ_ディル(disUnit, 配色指定.N0, null, Med, new バイブ_ディルD
				{
					濃度 = 0.5,
					尺度C = 1.09
				}));
				this.アナルCM = new CM(Med, this, this.アナル = new バイブ_アナル(disUnit, 配色指定.N0, null, Med, new バイブ_アナルD
				{
					濃度 = 0.5,
					尺度C = 1.09
				}));
				this.デンマCM = new CM(Med, this, this.デンマ = new バイブ_デンマ(disUnit, 配色指定.N0, null, Med, new バイブ_デンマD
				{
					濃度 = 0.5,
					尺度C = 1.09
				}));
				this.ドリルCM = new CM(Med, this, this.ドリル = new バイブ_ドリル(disUnit, 配色指定.N0, null, Med, new バイブ_ドリルD
				{
					濃度 = 0.5,
					尺度C = 1.09
				}));
				this.パ\u30FCルCM = new CM(Med, this, this.パ\u30FCル = new パ\u30FCル(disUnit, 配色指定.N0, null, Med, new パ\u30FCルD
				{
					濃度 = 0.5,
					尺度C = 1.09
				}));
				this.羽根箒CM = new CM(Med, this, this.羽根箒 = new 羽根箒(disUnit, 配色指定.N0, null, Med, new 羽根箒D
				{
					濃度 = 0.5,
					尺度C = 1.09
				}));
				this.調教鞭CM = new CM(Med, this, this.調教鞭 = new 調教鞭(disUnit, 配色指定.N0, null, Med, new 調教鞭D
				{
					濃度 = 0.5,
					尺度C = 1.09,
					Yi = 2
				}));
				this.T剃刀CM = new CM(Med, this, this.T剃刀 = new T剃刀(disUnit, 配色指定.N0, null, Med, new T剃刀D
				{
					濃度 = 0.5,
					尺度C = 1.09
				}));
				this.ペニス挿入 = new 挿入処理(this, this.ペニスCM);
				this.マウス挿入 = new 挿入処理(this, this.マウスCM);
				this.ハンド挿入 = new 挿入処理(this, this.ハンド右CM);
				this.ロ\u30FCタ挿入 = new 挿入処理(this, this.ロ\u30FCタCM);
				this.コモン挿入 = new 挿入処理(this, this.コモンCM);
				this.ディル挿入 = new 挿入処理(this, this.ディルCM);
				this.アナル挿入 = new 挿入処理(this, this.アナルCM);
				this.デンマ挿入 = new 挿入処理(this, this.デンマCM);
				this.ドリル挿入 = new 挿入処理(this, this.ドリルCM);
				this.パ\u30FCル挿入 = new 挿入処理(this, this.パ\u30FCルCM);
				this.ペニス処理 = new ペニス処理(this, this.ペニスCM);
				this.マウス処理 = new マウス処理(this, this.マウスCM);
				this.ハンド処理 = new ハンド処理(this, this.ハンド右CM);
				this.キャップ処理 = new キャップ処理(this);
				this.羽箒処理 = new 羽箒処理(this, this.羽根箒CM);
				this.剃刀処理 = new 剃刀処理(this, this.T剃刀CM);
				this.調鞭処理 = new 調鞭処理(this, this.調教鞭CM);
				this.射精 = new 射精(disUnit, 配色指定.N0, Sta.GameData.配色, Med, new 射精D
				{
					表示 = false,
					位置C = new Vector2D(0.0, 0.001)
				});
				this.射精.SetHitFalse();
				ParT parT = new ParT();
				parT.Text = tex.調教終了;
				parT.SizeBase = 0.095;
				parT.Font = new Font("MS Gothic", 1f);
				parT.FontSize = 0.07;
				parT.SetStringRectOutline(Are.Unit, Are.GD);
				parT.RectSize = new Vector2D(parT.OP[0].ps[1].X, parT.OP[0].ps[2].Y);
				parT.OP.ScalingY(parT.BasePointBase, 0.9);
				parT.Closed = true;
				parT.TextColor = Col.White;
				parT.BrushColor = Color.FromArgb(160, Col.Black);
				parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT.HitColor = Med.GetUniqueColor();
				parT.StringFormat.Alignment = StringAlignment.Center;
				parT.StringFormat.LineAlignment = StringAlignment.Center;
				parT.PositionBase = Are.GetPosition(1.0 - (parT.OP[0].ps[1].X * parT.SizeBase / Are.LocalWidth + 0.005), 1.0 - parT.OP[0].ps[2].Y * parT.SizeBase / Are.LocalHeight).AddY(-0.001);
				parT.PositionBase = new Vector2D(ip.SubB.PositionBase.X, parT.PositionBase.Y);
				this.調教終了 = new But1(parT, null);
				double sizeBase = 0.095;
				double y = 0.015;
				if (Sta.BigWindow && !Sta.NoScaling)
				{
					sizeBase = 0.12;
					y = 0.018;
				}
				ParT parT2 = new ParT();
				parT2.Text = tex.拘束;
				parT2.SizeBase = sizeBase;
				parT2.Font = new Font("MS Gothic", 1f);
				parT2.FontSize = 0.07;
				parT2.SetStringRectOutline(Are.Unit, Are.GD);
				parT2.RectSize = new Vector2D(parT2.OP[0].ps[1].X, parT2.OP[0].ps[2].Y);
				parT2.OP.ScalingY(parT2.BasePointBase, 0.9);
				parT2.Closed = true;
				parT2.TextColor = Col.White;
				parT2.BrushColor = Color.FromArgb(160, Col.Black);
				parT2.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT2.HitColor = Med.GetUniqueColor();
				parT2.StringFormat.Alignment = StringAlignment.Center;
				parT2.StringFormat.LineAlignment = StringAlignment.Center;
				parT2.PositionBase = Are.GetPosition(0.08, 0.7);
				this.拘束具 = new But1(parT2, delegate(But a)
				{
					if (<>4__this.拘束具sw.Flag)
					{
						Sou.変更2.Play();
					}
					else
					{
						Sou.変更1.Play();
					}
					<>4__this.拘束具sw.OnOff(a);
					Sta.GameData.拘束具 = <>4__this.拘束具sw.Flag;
					<>4__this.Bod.拘束具_表示 = Sta.GameData.拘束具;
					<>4__this.Bod.首輪_表示 = true;
					Act.入力反応1();
				});
				ParT parT3 = new ParT();
				parT3.Text = tex.目隠;
				parT3.SizeBase = sizeBase;
				parT3.Font = new Font("MS Gothic", 1f);
				parT3.FontSize = 0.07;
				parT3.SetStringRectOutline(Are.Unit, Are.GD);
				parT3.RectSize = new Vector2D(parT3.OP[0].ps[1].X, parT3.OP[0].ps[2].Y);
				parT3.OP.ScalingY(parT3.BasePointBase, 0.9);
				parT3.Closed = true;
				parT3.TextColor = Col.White;
				parT3.BrushColor = Color.FromArgb(160, Col.Black);
				parT3.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT3.HitColor = Med.GetUniqueColor();
				parT3.StringFormat.Alignment = StringAlignment.Center;
				parT3.StringFormat.LineAlignment = StringAlignment.Center;
				parT3.PositionBase = parT2.PositionBase.AddY(y);
				this.目隠帯 = new But1(parT3, delegate(But a)
				{
					<>4__this.目隠帯sw.OnOff(a);
					Sta.GameData.目隠帯 = <>4__this.目隠帯sw.Flag;
					<>4__this.Bod.目隠帯_表示 = Sta.GameData.目隠帯;
					Act.入力反応1();
				});
				ParT parT4 = new ParT();
				parT4.Text = tex.口枷;
				parT4.SizeBase = sizeBase;
				parT4.Font = new Font("MS Gothic", 1f);
				parT4.FontSize = 0.07;
				parT4.SetStringRectOutline(Are.Unit, Are.GD);
				parT4.RectSize = new Vector2D(parT4.OP[0].ps[1].X, parT4.OP[0].ps[2].Y);
				parT4.OP.ScalingY(parT4.BasePointBase, 0.9);
				parT4.Closed = true;
				parT4.TextColor = Col.White;
				parT4.BrushColor = Color.FromArgb(160, Col.Black);
				parT4.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT4.HitColor = Med.GetUniqueColor();
				parT4.StringFormat.Alignment = StringAlignment.Center;
				parT4.StringFormat.LineAlignment = StringAlignment.Center;
				parT4.PositionBase = parT3.PositionBase.AddY(y);
				this.玉口枷 = new But1(parT4, delegate(But a)
				{
					<>4__this.玉口枷sw.OnOff(a);
					Sta.GameData.玉口枷 = <>4__this.玉口枷sw.Flag;
					<>4__this.Bod.玉口枷_表示 = Sta.GameData.玉口枷;
					Act.入力反応1();
				});
				ParT parT5 = new ParT();
				parT5.Text = tex.断面;
				parT5.SizeBase = sizeBase;
				parT5.Font = new Font("MS Gothic", 1f);
				parT5.FontSize = 0.07;
				parT5.SetStringRectOutline(Are.Unit, Are.GD);
				parT5.RectSize = new Vector2D(parT5.OP[0].ps[1].X, parT5.OP[0].ps[2].Y);
				parT5.OP.ScalingY(parT5.BasePointBase, 0.9);
				parT5.Closed = true;
				parT5.TextColor = Col.White;
				parT5.BrushColor = Color.FromArgb(160, Col.Black);
				parT5.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT5.HitColor = Med.GetUniqueColor();
				parT5.StringFormat.Alignment = StringAlignment.Center;
				parT5.StringFormat.LineAlignment = StringAlignment.Center;
				parT5.PositionBase = parT4.PositionBase.AddY(y);
				this.断面 = new But1(parT5, delegate(But a)
				{
					double v = 0.0;
					if (<>4__this.ペニス挿入.Is膣)
					{
						v = <>4__this.ペニス挿入.Insert;
					}
					if (<>4__this.マウス挿入.Is膣)
					{
						v = <>4__this.マウス挿入.Insert;
					}
					if (<>4__this.ハンド挿入.Is膣)
					{
						v = <>4__this.ハンド挿入.Insert;
					}
					if (<>4__this.ロ\u30FCタ挿入.Is膣)
					{
						v = <>4__this.ロ\u30FCタ挿入.Insert;
					}
					if (<>4__this.コモン挿入.Is膣)
					{
						v = <>4__this.コモン挿入.Insert;
					}
					if (<>4__this.ディル挿入.Is膣)
					{
						v = <>4__this.ディル挿入.Insert;
					}
					if (<>4__this.アナル挿入.Is膣)
					{
						v = <>4__this.アナル挿入.Insert;
					}
					if (<>4__this.デンマ挿入.Is膣)
					{
						v = <>4__this.デンマ挿入.Insert;
					}
					if (<>4__this.ドリル挿入.Is膣)
					{
						v = <>4__this.ドリル挿入.Insert;
					}
					if (<>4__this.パ\u30FCル挿入.Is膣)
					{
						v = <>4__this.パ\u30FCル挿入.Insert;
					}
					<>4__this.断面sw.OnOff(a);
					Sta.GameData.断面 = <>4__this.断面sw.Flag;
					if (!<>4__this.Bod.Is粘)
					{
						<>4__this.Bod.断面_表示 = Sta.GameData.断面;
					}
					if (<>4__this.ペニス挿入.Is膣)
					{
						<>4__this.ペニス挿入.断面切替(v);
					}
					if (<>4__this.マウス挿入.Is膣)
					{
						<>4__this.マウス挿入.断面切替(v);
					}
					if (<>4__this.ハンド挿入.Is膣)
					{
						<>4__this.ハンド挿入.断面切替(v);
					}
					if (<>4__this.ロ\u30FCタ挿入.Is膣)
					{
						<>4__this.ロ\u30FCタ挿入.断面切替(v);
					}
					if (<>4__this.コモン挿入.Is膣)
					{
						<>4__this.コモン挿入.断面切替(v);
					}
					if (<>4__this.ディル挿入.Is膣)
					{
						<>4__this.ディル挿入.断面切替(v);
					}
					if (<>4__this.アナル挿入.Is膣)
					{
						<>4__this.アナル挿入.断面切替(v);
					}
					if (<>4__this.デンマ挿入.Is膣)
					{
						<>4__this.デンマ挿入.断面切替(v);
					}
					if (<>4__this.ドリル挿入.Is膣)
					{
						<>4__this.ドリル挿入.断面切替(v);
					}
					if (<>4__this.パ\u30FCル挿入.Is膣)
					{
						<>4__this.パ\u30FCル挿入.断面切替(v);
					}
				});
				ParT parT6 = new ParT();
				parT6.Text = tex.媚薬;
				parT6.SizeBase = sizeBase;
				parT6.Font = new Font("MS Gothic", 1f);
				parT6.FontSize = 0.07;
				parT6.SetStringRectOutline(Are.Unit, Are.GD);
				parT6.RectSize = new Vector2D(parT6.OP[0].ps[1].X, parT6.OP[0].ps[2].Y);
				parT6.OP.ScalingY(parT6.BasePointBase, 0.9);
				parT6.Closed = true;
				parT6.TextColor = Col.White;
				parT6.BrushColor = Color.FromArgb(160, Col.Black);
				parT6.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT6.HitColor = Med.GetUniqueColor();
				parT6.StringFormat.Alignment = StringAlignment.Center;
				parT6.StringFormat.LineAlignment = StringAlignment.Center;
				parT6.PositionBase = parT5.PositionBase.AddY(y);
				this.媚薬 = new But1(parT6, delegate(But a)
				{
					if (Sta.GameData.所持金 < <>4__this.媚薬投与価格)
					{
						ip.SubInfoIm = tex.所持金が足りません;
						return;
					}
					Sta.GameData.所持金 -= <>4__this.媚薬投与価格;
					Sou.精算.Play();
					ip.UpdateSub2();
					Sta.GameData.調教対象.発情フラグ = true;
					ip.SubInfoIm = tex.媚薬を打ち込んだ;
					Act.入力反応1();
					<>4__this.媚薬.Dra = false;
				});
				this.StaminaButtons(Are, Med, ip);
				ParT parT7 = new ParT();
				parT7.Text = tex.撮影;
				parT7.SizeBase = sizeBase;
				parT7.Font = new Font("MS Gothic", 1f);
				parT7.FontSize = 0.07;
				parT7.SetStringRectOutline(Are.Unit, Are.GD);
				parT7.RectSize = new Vector2D(parT7.OP[0].ps[1].X, parT7.OP[0].ps[2].Y);
				parT7.OP.ScalingY(parT7.BasePointBase, 0.9);
				parT7.Closed = true;
				parT7.TextColor = Col.White;
				parT7.BrushColor = Color.FromArgb(160, Col.Black);
				parT7.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
				parT7.HitColor = Med.GetUniqueColor();
				parT7.StringFormat.Alignment = StringAlignment.Center;
				parT7.StringFormat.LineAlignment = StringAlignment.Center;
				parT7.PositionBase = parT6.PositionBase.AddY(y);
				string Path = "photo";
				this.Film = new Are(Med, false);
				this.Film.Setting();
				Action<But> <>9__7;
				Action<But> <>9__8;
				Action<Tex> <>9__6;
				this.撮影 = new But1(parT7, delegate(But a)
				{
					Sou.撮影.Play();
					Med.フラッシュ();
					if (!Directory.Exists(Path))
					{
						Directory.CreateDirectory(Path);
					}
					DateTime now = DateTime.Now;
					Mods.撮影描画(<>4__this.Film, Med.FPSF);
					Font font = new Font("MS Gothic", (float)(10.0 * Med.DpiY));
					float x = 350f;
					float y2 = 365f;
					if (Sta.BigWindow && Sta.HighQuality)
					{
						x = 1215f;
						y2 = 1018f;
					}
					else if (Sta.BigWindow && !Sta.HighQuality)
					{
						x = 525f;
						y2 = 500f;
					}
					else if (Sta.HighQuality && !Sta.BigWindow)
					{
						x = 863f;
						y2 = 754f;
					}
					try
					{
						<>4__this.Film.GD.DrawString("Slave Matrix " + now.ToShortDateString().Replace("/", "."), font, Brushes.Coral, x, y2);
					}
					finally
					{
						if (font != null)
						{
							((IDisposable)font).Dispose();
						}
					}
					<>4__this.Film.Dis.Save(Path + "\\" + now.ToString("yyyy_MM_dd_HH_mm_ss") + ".png", ImageFormat.Png);
					ip.SubInfoIm = tex.撮影しました + "\r\n" + tex.写真はPhotoフォルダに保存されます;
					if (Sta.GameData.調教対象.調教済フラグ && !<>4__this.Cha.Bod.Is拘束 && <>4__this.Cha.Bod.Is腕人 && !Sta.GameData.調教対象.ChaD.撮影ピ\u30FCス経験)
					{
						ip.Text = tex.愛想が悪い + "\r\n" + tex.ダブルピ\u30FCスさせますか;
						Tex mai = ip.Mai;
						Action<Tex> done;
						if ((done = <>9__6) == null)
						{
							done = (<>9__6 = delegate(Tex t)
							{
								情報パネル 情報パネル = ip;
								Action<But> 選択yAct;
								if ((選択yAct = <>9__7) == null)
								{
									選択yAct = (<>9__7 = delegate(But t_)
									{
										Sou.操作.Play();
										Sta.GameData.調教対象.ChaD.撮影ピ\u30FCス経験 = true;
										<>4__this.Cha.Setダブルピ\u30FCス();
										<>4__this.Cha.Bod.Update();
										ip.選択肢表示 = false;
										ip.MaiShow = false;
									});
								}
								情報パネル.選択yAct = 選択yAct;
								情報パネル 情報パネル2 = ip;
								Action<But> 選択nAct;
								if ((選択nAct = <>9__8) == null)
								{
									選択nAct = (<>9__8 = delegate(But t_)
									{
										Sou.操作.Play();
										ip.選択肢表示 = false;
										ip.MaiShow = false;
									});
								}
								情報パネル2.選択nAct = 選択nAct;
								ip.選択肢表示 = true;
							});
						}
						mai.Done = done;
						ip.MaiShow = true;
					}
				});
				int alpha = 200;
				this.体力sゲ\u30FCジ = new Gau("体力", Are.GetPosition(new Vector2D(0.025, 0.5)), Are.Size, 0.025, Are.YRatio * 0.98, 0.02, Open.Top, Range.ZeroOne, disUnit, Color.FromArgb(alpha, Color.Red), Color.Yellow, Color.FromArgb(alpha, Color.Gray), Color.FromArgb(alpha, Color.Gray), Color.FromArgb(alpha, Col.Black), false);
				this.体力sゲ\u30FCジ.Frame1.Pen = null;
				this.絶頂sゲ\u30FCジ = new Gau("絶頂", Are.GetPosition(new Vector2D(0.060000000000000005, 0.5)), Are.Size, 0.01, Are.YRatio * 0.98, 0.02, Open.Top, Range.ZeroOne, disUnit, Color.FromArgb(alpha, Color.DeepPink), Col.White, Color.FromArgb(alpha, Color.Gray), Color.FromArgb(alpha, Color.Gray), Color.Transparent, false);
				this.絶頂sゲ\u30FCジ.Frame1.Pen = null;
				this.絶頂sゲ\u30FCジ.Gauge.Pen = null;
				this.興奮sゲ\u30FCジ = new Gau("興奮", Are.GetPosition(new Vector2D(0.060000000000000005, 0.5)), Are.Size, 0.025, Are.YRatio * 0.98, 0.02, Open.Top, Range.ZeroOne, disUnit, Color.FromArgb(180, Col.White), Color.FromArgb(180, Color.Red), Color.FromArgb(alpha, Color.Gray), Color.FromArgb(alpha, Color.Gray), Color.FromArgb(alpha, Col.Black), false);
				this.興奮sゲ\u30FCジ.Frame1.Pen = null;
				this.興奮sゲ\u30FCジ.Gauge.Pen = null;
				this.精力mゲ\u30FCジ = new Gau("精力", Are.GetPosition(new Vector2D(0.025.Inverse(), 0.5)), Are.Size, 0.025, Are.YRatio * 0.98, 0.02, Open.Top, Range.ZeroOne, disUnit, Color.FromArgb(alpha, Col.Yellow.Add(180, 0, 0)), Col.Red.Add(180, 0, 0), Color.FromArgb(alpha, Color.Gray), Color.FromArgb(alpha, Color.Gray), Color.FromArgb(alpha, Col.Black), false);
				this.精力mゲ\u30FCジ.Frame1.Pen = null;
				this.射精mゲ\u30FCジ = new Gau("射精", Are.GetPosition(new Vector2D(0.060000000000000005.Inverse(), 0.5)), Are.Size, 0.01, Are.YRatio * 0.98, 0.02, Open.Top, Range.ZeroOne, disUnit, Color.FromArgb(alpha, Col.DeepPink.Add(180, 0, 0)), Col.White.Add(180, 0, 0), Color.FromArgb(alpha, Color.Gray), Color.FromArgb(alpha, Color.Gray), Color.Transparent, false);
				this.射精mゲ\u30FCジ.Frame1.Pen = null;
				this.射精mゲ\u30FCジ.Gauge.Pen = null;
				this.興奮mゲ\u30FCジ = new Gau("興奮", Are.GetPosition(new Vector2D(0.060000000000000005.Inverse(), 0.5)), Are.Size, 0.025, Are.YRatio * 0.98, 0.02, Open.Top, Range.ZeroOne, disUnit, Color.FromArgb(180, Col.White), Color.FromArgb(180, Color.Red), Color.FromArgb(alpha, Color.Gray), Color.FromArgb(alpha, Color.Gray), Color.FromArgb(alpha, Col.Black), false);
				this.興奮mゲ\u30FCジ.Frame1.Pen = null;
				this.興奮mゲ\u30FCジ.Gauge.Pen = null;
				Color uniqueColor = Med.GetUniqueColor();
				foreach (Par par in this.体力sゲ\u30FCジ.Pars.EnumAllPar())
				{
					par.HitColor = uniqueColor;
				}
				Med.GetUniqueColor(out uniqueColor);
				foreach (Par par2 in this.絶頂sゲ\u30FCジ.Pars.EnumAllPar())
				{
					par2.HitColor = uniqueColor;
				}
				Med.GetUniqueColor(out uniqueColor);
				foreach (Par par3 in this.興奮sゲ\u30FCジ.Pars.EnumAllPar())
				{
					par3.HitColor = uniqueColor;
				}
				Med.GetUniqueColor(out uniqueColor);
				foreach (Par par4 in this.精力mゲ\u30FCジ.Pars.EnumAllPar())
				{
					par4.HitColor = uniqueColor;
				}
				Med.GetUniqueColor(out uniqueColor);
				foreach (Par par5 in this.射精mゲ\u30FCジ.Pars.EnumAllPar())
				{
					par5.HitColor = uniqueColor;
				}
				Med.GetUniqueColor(out uniqueColor);
				foreach (Par par6 in this.興奮mゲ\u30FCジ.Pars.EnumAllPar())
				{
					par6.HitColor = uniqueColor;
				}
				this.体力sゲ\u30FCジ.Value = 1.0;
				this.絶頂sゲ\u30FCジ.Value = 0.0;
				this.興奮sゲ\u30FCジ.Value = 0.0;
				this.精力mゲ\u30FCジ.Value = 1.0;
				this.射精mゲ\u30FCジ.Value = 0.0;
				this.興奮mゲ\u30FCジ.Value = 0.0;
				double num = 0.14;
				if (Sta.BigWindow)
				{
					num = 0.155;
				}
				Vector2D left = new Vector2D(Are.LocalWidth - num, Are.LocalHeight - (Are.LocalHeight - 0.005));
				this.アナル.位置B = (this.アナルCM.bp = left + new Vector2D(0, 0));
				this.デンマ.位置B = (this.デンマCM.bp = left + new Vector2D(0.019133333333333, 0.0));
				this.ドリル.位置B = (this.ドリルCM.bp = left + new Vector2D(0.038266666666666, 0.0));
				this.コモン.位置B = (this.コモンCM.bp = left + new Vector2D(0.0574, 0.0));
				this.ディル.位置B = (this.ディルCM.bp = left + new Vector2D(0.076533333333333, 0.0));
				this.パ\u30FCル.位置B = (this.パ\u30FCルCM.bp = left + new Vector2D(0.0574, 0.14175));
				this.ロ\u30FCタ.位置B = (this.ロ\u30FCタCM.bp = left + new Vector2D(0.076533333333333, 0.17325));
				this.キャップ1.位置B = (this.キャップ1CM.bp = left + new Vector2D(0.095666666666666, 0.1667));
				this.キャップ2.位置B = (this.キャップ2CM.bp = left + new Vector2D(0.095666666666666, 0.1807));
				this.キャップ3.位置B = (this.キャップ3CM.bp = left + new Vector2D(0.095666666666666, 0.1947));
				this.T剃刀.位置B = (this.T剃刀CM.bp = left + new Vector2D(0.0574, 0.091));
				this.羽根箒.位置B = (this.羽根箒CM.bp = left + new Vector2D(0.076533333333333, 0.116));
				this.調教鞭.位置B = (this.調教鞭CM.bp = left + new Vector2D(0.095666666666666, 0.11025));
				this.ハンド右.位置B = (this.ハンド右CM.bp = left + new Vector2D(0.0574, 0.22625));
				this.マウス.位置B = (this.マウスCM.bp = left + new Vector2D(0.076533333333333, 0.23675));
				this.ペニス.位置B = (this.ペニスCM.bp = left + new Vector2D(0.095666666666666, 0.20875));
				this.focus = this.ハンド右CM;
				this.Focus = this.ハンド右CM;
				this.Set持ち手();
				this.X = this.アナル.位置B.X - 0.006;
				this.Y = this.マウス.位置B.Y + 0.015;
				this.Mots.Add(Act.ゲ\u30FCジ降下処理.GetHashCode().ToString(), Act.ゲ\u30FCジ降下処理);
				Act.ゲ\u30FCジ降下処理.Sta();
				this.擬音 = new 擬音();
				this.AddBoxes();
				Mot mot = new Mot(0.0, 1.0);
				mot.BaseSpeed = 2.0;
				mot.Staing = delegate(Mot m)
				{
				};
				mot.Runing = delegate(Mot m)
				{
					<>4__this.絶頂sゲ\u30FCジ.SetAlphaG(m.Value);
				};
				mot.Reaing = delegate(Mot m)
				{
				};
				mot.Rouing = delegate(Mot m)
				{
				};
				mot.Ending = delegate(Mot m)
				{
					<>4__this.絶頂sゲ\u30FCジ.SetAlphaG(1.0);
				};
				this.絶頂ゲ\u30FCジ点滅 = mot;
				this.Mots.Add(this.絶頂ゲ\u30FCジ点滅.GetHashCode().ToString(), this.絶頂ゲ\u30FCジ点滅);
				Mot mot2 = new Mot(0.0, 1.0);
				mot2.BaseSpeed = 2.0;
				mot2.Staing = delegate(Mot m)
				{
				};
				mot2.Runing = delegate(Mot m)
				{
					<>4__this.射精mゲ\u30FCジ.SetAlphaG(m.Value);
				};
				mot2.Reaing = delegate(Mot m)
				{
				};
				mot2.Rouing = delegate(Mot m)
				{
				};
				mot2.Ending = delegate(Mot m)
				{
					<>4__this.射精mゲ\u30FCジ.SetAlphaG(1.0);
				};
				this.射精ゲ\u30FCジ点滅 = mot2;
				this.Mots.Add(this.射精ゲ\u30FCジ点滅.GetHashCode().ToString(), this.射精ゲ\u30FCジ点滅);
			}
			catch (Exception)
			{
			}
		}

		public void SetTarget(Unit Unit, Cha Cha)
		{
			if (this.Cha != null)
			{
				this.Cha.潮吹擬音 = null;
				this.Cha.放尿擬音 = null;
			}
			this.Uni = Unit;
			this.Cha = Cha;
			this.Bod = Cha.Bod;
			this.Bod.カ\u30FCソル = this;
			this.ペニス挿入.SetCha(Cha);
			this.マウス挿入.SetCha(Cha);
			this.ハンド挿入.SetCha(Cha);
			this.ロ\u30FCタ挿入.SetCha(Cha);
			this.コモン挿入.SetCha(Cha);
			this.ディル挿入.SetCha(Cha);
			this.アナル挿入.SetCha(Cha);
			this.デンマ挿入.SetCha(Cha);
			this.ドリル挿入.SetCha(Cha);
			this.パ\u30FCル挿入.SetCha(Cha);
			this.羽箒処理.SetCha(Cha);
			this.剃刀処理.SetCha(Cha);
			this.調鞭処理.SetCha(Cha);
			this.ハンド処理.SetCha(Cha);
			this.マウス処理.SetCha(Cha);
			this.ペニス処理.SetCha(Cha);
			this.キャップ処理.SetCha(Cha);
			this.Cha.潮吹擬音 = new Action(this.潮吹);
			this.Cha.放尿擬音 = new Action(this.放尿);
			this.CP.Reset();
			this.ペニス挿入.CP挿入.Reset();
			this.マウス挿入.CP挿入.Reset();
			this.ハンド挿入.CP挿入.Reset();
			this.ロ\u30FCタ挿入.CP挿入.Reset();
			this.コモン挿入.CP挿入.Reset();
			this.ディル挿入.CP挿入.Reset();
			this.アナル挿入.CP挿入.Reset();
			this.デンマ挿入.CP挿入.Reset();
			this.ドリル挿入.CP挿入.Reset();
			this.パ\u30FCル挿入.CP挿入.Reset();
			this.ペニス挿入.CP振動.Reset();
			this.マウス挿入.CP振動.Reset();
			this.ハンド挿入.CP振動.Reset();
			this.ロ\u30FCタ挿入.CP振動.Reset();
			this.コモン挿入.CP振動.Reset();
			this.ディル挿入.CP振動.Reset();
			this.アナル挿入.CP振動.Reset();
			this.デンマ挿入.CP振動.Reset();
			this.ドリル挿入.CP振動.Reset();
			this.パ\u30FCル挿入.CP振動.Reset();
			this.キャップ処理.CP中.Reset();
			this.キャップ処理.CP左.Reset();
			this.キャップ処理.CP右.Reset();
			this.発情bu = Sta.GameData.調教対象.発情フラグ;
			this.強制拘束 = false;
			this.拘束bu = Sta.GameData.拘束具;
			if (!Unit.調教済フラグ)
			{
				Sta.GameData.拘束具 = true;
				this.強制拘束 = true;
			}
			this.拘束具sw.SetFlag(this.拘束具, Sta.GameData.拘束具);
			this.Bod.拘束具_表示 = Sta.GameData.拘束具;
			this.目隠帯sw.SetFlag(this.目隠帯, Sta.GameData.目隠帯);
			this.Bod.目隠帯_表示 = Sta.GameData.目隠帯;
			this.玉口枷sw.SetFlag(this.玉口枷, Sta.GameData.玉口枷);
			this.Bod.玉口枷_表示 = Sta.GameData.玉口枷;
			this.断面sw.SetFlag(this.断面, Sta.GameData.断面);
			if (!this.Bod.Is粘)
			{
				this.Bod.断面_表示 = Sta.GameData.断面;
			}
			this.断面.Dra = Sta.GameData.心眼;
			this.媚薬.Dra = (Sta.GameData.媚薬 && !Cha.ChaD.タトゥ);
			this.拘束具.Dra = Unit.調教済フラグ;
			this.SlaveStamina.Dra = Sta.StaminaButton;
			this.PlayerStamina.Dra = Sta.StaminaButton;
		}

		public void Reset()
		{
			foreach (Mot mot in this.Mots.ms.Values)
			{
				if (mot != Act.ゲ\u30FCジ降下処理)
				{
					mot.End();
				}
			}
			if (this.羽根箒.右)
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
			this.Focus = this.ハンド右CM;
			this.通常放し();
			this.CP.Reset();
			this.擬音キュ\u30FC.Clear();
			this.コキ_ = false;
			this.ハンド左表示 = false;
			this.持ち手 = false;
			this.SubFocus.Clear();
			this.膣i肛f = false;
			this.肛f = false;
			this.肛oh = false;
			this.IsTB = false;
			this.放し();
			this.d = MouseButtons.None;
			this.IsTool = false;
			this.hcm = null;
			this.ef = null;
			this.sf = true;
			this.ペニスCM.Reset();
			this.マウスCM.Reset();
			this.ハンド右CM.Reset();
			this.ハンド左CM.Reset();
			this.ハンド左.濃度 = 1.0;
			this.ハンド左.SetHitFalse();
			this.ロ\u30FCタCM.Reset();
			this.コモンCM.Reset();
			this.ディルCM.Reset();
			this.アナルCM.Reset();
			this.デンマCM.Reset();
			this.ドリルCM.Reset();
			this.パ\u30FCルCM.Reset();
			this.羽根箒CM.Reset();
			this.調教鞭CM.Reset();
			this.調教鞭.Yi = 2;
			this.T剃刀CM.Reset();
			this.ペニス挿入.Reset();
			this.マウス挿入.Reset();
			this.ハンド挿入.Reset();
			this.ロ\u30FCタ挿入.Reset();
			this.コモン挿入.Reset();
			this.ディル挿入.Reset();
			this.アナル挿入.Reset();
			this.デンマ挿入.Reset();
			this.ドリル挿入.Reset();
			this.パ\u30FCル挿入.Reset();
			this.ペニス処理.Reset();
			this.マウス処理.Reset();
			this.ハンド処理.Reset();
			this.キャップ処理.Reset();
			this.羽箒処理.Reset();
			this.剃刀処理.Reset();
			this.調鞭処理.Reset();
			this.射精.表示 = false;
			this.射精.位置C = new Vector2D(0.0, 0.001);
			this.射精.SetHitFalse();
			double num = 0.14;
			if (Sta.BigWindow)
			{
				num = 0.155;
			}
			Vector2D left = new Vector2D(this.Are.LocalWidth - num, this.Are.LocalHeight - (this.Are.LocalHeight - 0.005));
			this.アナル.位置B = (this.アナルCM.bp = left + new Vector2D(0, 0));
			this.デンマ.位置B = (this.デンマCM.bp = left + new Vector2D(0.019133333333333, 0.0));
			this.ドリル.位置B = (this.ドリルCM.bp = left + new Vector2D(0.038266666666666, 0.0));
			this.コモン.位置B = (this.コモンCM.bp = left + new Vector2D(0.0574, 0.0));
			this.ディル.位置B = (this.ディルCM.bp = left + new Vector2D(0.076533333333333, 0.0));
			this.パ\u30FCル.位置B = (this.パ\u30FCルCM.bp = left + new Vector2D(0.0574, 0.14175));
			this.ロ\u30FCタ.位置B = (this.ロ\u30FCタCM.bp = left + new Vector2D(0.076533333333333, 0.17325));
			this.キャップ1.位置B = (this.キャップ1CM.bp = left + new Vector2D(0.095666666666666, 0.1667));
			this.キャップ2.位置B = (this.キャップ2CM.bp = left + new Vector2D(0.095666666666666, 0.1807));
			this.キャップ3.位置B = (this.キャップ3CM.bp = left + new Vector2D(0.095666666666666, 0.1947));
			this.T剃刀.位置B = (this.T剃刀CM.bp = left + new Vector2D(0.0574, 0.091));
			this.羽根箒.位置B = (this.羽根箒CM.bp = left + new Vector2D(0.076533333333333, 0.116));
			this.調教鞭.位置B = (this.調教鞭CM.bp = left + new Vector2D(0.095666666666666, 0.11025));
			this.ハンド右.位置B = (this.ハンド右CM.bp = left + new Vector2D(0.0574, 0.22625));
			this.マウス.位置B = (this.マウスCM.bp = left + new Vector2D(0.076533333333333, 0.23675));
			this.ペニス.位置B = (this.ペニスCM.bp = left + new Vector2D(0.095666666666666, 0.20875));
			this.focus = this.ハンド右CM;
			this.Focus = this.ハンド右CM;
			this.Set持ち手();
			this.X = this.アナル.位置B.X - 0.006;
			this.Y = this.マウス.位置B.Y + 0.015;
			this.擬音.Clear();
		}

		public void 描画糸(Are Are)
		{
			foreach (挿入処理 挿入処理 in this.SubFocus)
			{
				if (挿入処理.Is糸)
				{
					挿入処理.対象.Draws(Are);
				}
			}
		}

		public void 描画肛(Are Are)
		{
			if (this.膣i肛f)
			{
				this.focus.描画0(Are);
				this.focus.描画1(Are);
				if (!this.持ち手 || ((this.focus == this.キャップ1CM || this.focus == this.キャップ2CM || this.focus == this.キャップ3CM) && (this.キャップ処理.Isキャップ1着() || this.キャップ処理.Isキャップ2左着() || this.キャップ処理.Isキャップ2右着()) && !this.focus.DraShow))
				{
					this.ハンド右CM.待機描画(Are);
				}
			}
			foreach (挿入処理 挿入処理 in this.SubFocus)
			{
				if (挿入処理.Is肛)
				{
					挿入処理.対象.描画0s(Are);
					if (挿入処理 == this.マウス挿入)
					{
						挿入処理.対象.描画1s(Are);
					}
					if (this.肛oh)
					{
						this.focus.Draw(Are);
					}
					else if (!this.膣i肛f && this.IsTB)
					{
						this.Setハンド左(挿入処理);
					}
				}
			}
			if (!this.膣i肛f && this.肛f)
			{
				this.focus.描画0(Are);
			}
		}

		public override void 描画0(Are Are)
		{
			foreach (挿入処理 挿入処理 in this.SubFocus)
			{
				if (!挿入処理.Is肛)
				{
					挿入処理.対象.描画0s(Are);
					if (挿入処理 == this.マウス挿入)
					{
						挿入処理.対象.描画1s(Are);
					}
				}
			}
			if (!this.膣i肛f && !this.肛f)
			{
				this.focus.描画0(Are);
			}
		}

		public override void 描画1(Are Are)
		{
			if (!this.ハンド挿入.Is膣)
			{
				foreach (挿入処理 挿入処理 in this.SubFocus)
				{
					if (挿入処理 != this.マウス挿入)
					{
						挿入処理.対象.描画1s(Are);
					}
				}
				if (!this.膣i肛f)
				{
					this.focus.描画1(Are);
				}
			}
		}

		public override void 描画2(Are Are)
		{
			if (this.射精.表示)
			{
				this.射精.位置B = this.ペニス.位置B;
				this.射精.色更新();
				this.射精.本体.Draw(Are);
			}
			foreach (挿入処理 挿入処理 in this.SubFocus)
			{
				if (!挿入処理.Is糸)
				{
					挿入処理.対象.Draws(Are);
				}
			}
			if (!this.膣i肛f)
			{
				if (!this.肛oh)
				{
					this.focus.Draw(Are);
				}
			}
			else if (this.IsTB)
			{
				this.Setハンド左(this.挿入処理s);
			}
			if (this.ハンド左表示 || this.ハンド処理.Is乳繰り || this.ハンド処理.Is乳摘み || this.ハンド処理.Is乳捏ね || this.ハンド処理.Isくぱぁ)
			{
				this.ハンド左CM.Draws(Are);
				if (this.Is乳弄り)
				{
					this.ハンド右CM.待機描画(Are);
				}
			}
			if (this.ハンド挿入.Is膣)
			{
				foreach (挿入処理 挿入処理2 in this.SubFocus)
				{
					挿入処理2.対象.描画1s(Are);
				}
				if (!this.膣i肛f)
				{
					this.focus.描画1(Are);
				}
			}
		}

		public void StaDraw(Are Are, FPS FPS)
		{
			Act.表示ステ\u30FCト更新();
			Act.ModBox();
			Act.SensBox();
			Are.Draw(this.体力sゲ\u30FCジ.Pars);
			Are.Draw(this.興奮sゲ\u30FCジ.Pars);
			Are.Draw(this.絶頂sゲ\u30FCジ.Pars);
			Are.Draw(this.精力mゲ\u30FCジ.Pars);
			Are.Draw(this.興奮mゲ\u30FCジ.Pars);
			Are.Draw(this.射精mゲ\u30FCジ.Pars);
			if (!this.Is乳弄り && !this.Isフォ\u30FCカス糸挿入)
			{
				this.描画2(Are);
			}
			this.ペニスCM.待機描画(Are);
			this.マウスCM.待機描画(Are);
			if (!this.膣i肛f && !this.Is乳弄り && (!this.持ち手 || ((this.focus == this.キャップ1CM || this.focus == this.キャップ2CM || this.focus == this.キャップ3CM) && (this.キャップ処理.Isキャップ1着() || this.キャップ処理.Isキャップ2左着() || this.キャップ処理.Isキャップ2右着()) && !this.focus.DraShow)))
			{
				this.ハンド右CM.待機描画(Are);
			}
			this.ロ\u30FCタCM.待機描画(Are);
			this.コモンCM.待機描画(Are);
			this.ディルCM.待機描画(Are);
			this.アナルCM.待機描画(Are);
			this.デンマCM.待機描画(Are);
			this.ドリルCM.待機描画(Are);
			this.パ\u30FCルCM.待機描画(Are);
			this.羽根箒CM.待機描画(Are);
			this.調教鞭CM.待機描画(Are);
			this.T剃刀CM.待機描画(Are);
			this.キャップ1CM.待機描画(Are);
			this.キャップ2CM.待機描画(Are);
			this.キャップ3CM.待機描画(Are);
			this.調教終了.Draw(Are);
			this.拘束具.Draw(Are);
			this.目隠帯.Draw(Are);
			this.玉口枷.Draw(Are);
			this.断面.Draw(Are);
			this.媚薬.Draw(Are);
			this.撮影.Draw(Are);
			this.SlaveStamina.Draw(Are);
			this.PlayerStamina.Draw(Are);
			this.調鞭処理.衝撃.描画0(Are);
			while (this.擬音キュ\u30FC.Count > 0)
			{
				this.擬音キュ\u30FC.Dequeue()(Are);
			}
			this.擬音.Draw(FPS);
			if (this.ステ\u30FCト描画)
			{
				Are.Draw(this.ステ\u30FCト.Pars);
			}
			if (Injected.showSenses)
			{
				Are.Draw(this.InfoBox.Pars);
				Are.Draw(this.SensitivityBox.Pars);
			}
		}

		public void DrawState(Are Are)
		{
			Act.表示ステ\u30FCト更新();
			Act.ModBox();
			Act.SensBox();
			Are.Draw(this.体力sゲ\u30FCジ.Pars);
			Are.Draw(this.精力mゲ\u30FCジ.Pars);
			if (this.ステ\u30FCト描画)
			{
				Are.Draw(this.ステ\u30FCト.Pars);
			}
			if (Injected.showSenses)
			{
				Are.Draw(this.InfoBox.Pars);
				Are.Draw(this.SensitivityBox.Pars);
			}
		}

		public override void Dispose()
		{
			this.射精.Dispose();
			this.ペニス.Dispose();
			this.マウス.Dispose();
			this.ハンド右.Dispose();
			this.ハンド左.Dispose();
			this.ロ\u30FCタ.Dispose();
			this.コモン.Dispose();
			this.ディル.Dispose();
			this.アナル.Dispose();
			this.デンマ.Dispose();
			this.ドリル.Dispose();
			this.パ\u30FCル.Dispose();
			this.羽根箒.Dispose();
			this.調教鞭.Dispose();
			this.T剃刀.Dispose();
			this.キャップ1.Dispose();
			this.キャップ2.Dispose();
			this.キャップ3.Dispose();
			this.調鞭処理.衝撃.Dispose();
			this.調教終了.Dispose();
			this.拘束具.Dispose();
			this.目隠帯.Dispose();
			this.玉口枷.Dispose();
			this.断面.Dispose();
			this.媚薬.Dispose();
			this.撮影.Dispose();
			this.体力sゲ\u30FCジ.Dispose();
			this.絶頂sゲ\u30FCジ.Dispose();
			this.興奮sゲ\u30FCジ.Dispose();
			this.精力mゲ\u30FCジ.Dispose();
			this.射精mゲ\u30FCジ.Dispose();
			this.興奮mゲ\u30FCジ.Dispose();
			this.擬音.Dispose();
			this.ステ\u30FCト.Dispose();
			this.Film.Dispose();
			this.InfoBox.Dispose();
			this.SensitivityBox.Dispose();
			this.SlaveStamina.Dispose();
			this.PlayerStamina.Dispose();
		}

		public void Action(接触 接触, アクション情報 アクション情報, タイミング情報 タイミング情報, アイテム情報 アイテム情報, int 挿入Lv, int 強さ, bool 機械, bool 射精)
		{
			Act.アクション入力(接触, アクション情報, タイミング情報, アイテム情報, 挿入Lv, 強さ, 機械, 射精);
		}

		public void AddBoxes()
		{
			double num = 0.31;
			double width = 0.7;
			double size = 0.1;
			double textSize = 0.057;
			double width2 = 0.6;
			double num2 = 0.02;
			double height = 2.05;
			if (Program.biggerWindow)
			{
				num += 0.14;
				if (!Sta.NoScaling)
				{
					num -= 0.005;
					size = 0.125;
					textSize = 0.07;
					width2 = 0.9;
					num2 = 0.0;
					height = 2.55;
				}
			}
			if (Program.fixInfo)
			{
				width = 0.75;
			}
			this.ステ\u30FCト = new Tex("Tex", new Vector2D(this.Are.GetPosition(0.08, 0.7).X, 0.1), size, width, 1.15, new Font("MS Gothic", 1f), 0.07, 0, "", Col.White, Col.Black, Color.FromArgb(160, Col.Black), 15.0);
			this.InfoBox = new Tex("Info", new Vector2D(num, 0.005), 0.1, 0.9, 0.85, new Font("MS Gothic", 1f), 0.07, 0, "", Col.White, Col.Transparent, Color.FromArgb(0, Col.DarkMagenta), 100.0);
			this.SensitivityBox = new Tex("Sens", new Vector2D(num + num2, 0.08), 0.1, width2, height, new Font("MS Gothic", 1f), textSize, 0, "", Col.White, Col.Transparent, Color.FromArgb(0, Col.DarkMagenta), 100.0);
		}

		public void StaminaButtons(Are Are, Med Med, 情報パネル ip)
		{
			double sizeBase = 0.095;
			double y = 0.015;
			if (Sta.BigWindow && !Sta.NoScaling)
			{
				sizeBase = 0.12;
				y = 0.018;
			}
			ParT parT = new ParT();
			parT.Text = "SlaveStamina";
			parT.SizeBase = sizeBase;
			parT.Font = new Font("MS Gothic", 1f);
			parT.FontSize = 0.07;
			parT.SetStringRectOutline(Are.Unit, Are.GD);
			parT.RectSize = new Vector2D(parT.OP[0].ps[1].X, parT.OP[0].ps[2].Y);
			parT.OP.ScalingY(parT.BasePointBase, 0.9);
			parT.Closed = true;
			parT.TextColor = Col.White;
			parT.BrushColor = Color.FromArgb(160, Col.Black);
			parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT.HitColor = Med.GetUniqueColor();
			parT.StringFormat.Alignment = StringAlignment.Center;
			parT.StringFormat.LineAlignment = StringAlignment.Center;
			parT.PositionBase = Are.GetPosition(0.08, 0.1);
			this.SlaveStamina = new But1(parT, delegate(But a)
			{
				Sou.操作.Play();
				ip.UpdateSub2();
				Sta.GameData.調教対象.ChaD.体力 = 1.0;
			});
			ParT parT2 = new ParT();
			parT2.Text = "PlayerStamina";
			parT2.SizeBase = sizeBase;
			parT2.Font = new Font("MS Gothic", 1f);
			parT2.FontSize = 0.07;
			parT2.SetStringRectOutline(Are.Unit, Are.GD);
			parT2.RectSize = new Vector2D(parT2.OP[0].ps[1].X, parT2.OP[0].ps[2].Y);
			parT2.OP.ScalingY(parT2.BasePointBase, 0.9);
			parT2.Closed = true;
			parT2.TextColor = Col.White;
			parT2.BrushColor = Color.FromArgb(160, Col.Black);
			parT2.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT2.HitColor = Med.GetUniqueColor();
			parT2.StringFormat.Alignment = StringAlignment.Center;
			parT2.StringFormat.LineAlignment = StringAlignment.Center;
			parT2.PositionBase = parT.PositionBase.AddY(y);
			this.PlayerStamina = new But1(parT2, delegate(But a)
			{
				Sou.操作.Play();
				ip.UpdateSub2();
				Sta.GameData.精力 = 1.0;
			});
		}

		private ulong 媚薬投与価格 = 10000000UL;

		private ConstProp CP = new ConstProp();

		public const double 演出発生率 = 0.5;

		public const double 専用演出率 = 0.7;

		public Med Med;

		public Are Are;

		public Unit Uni;

		public Cha Cha;

		public Bod Bod;

		public 情報パネル ip;

		public ペニス ペニス;

		public マウス マウス;

		public ハンド ハンド右;

		public ハンド ハンド左;

		public ロ\u30FCタ ロ\u30FCタ;

		public バイブ_コモン コモン;

		public バイブ_ディル ディル;

		public バイブ_アナル アナル;

		public バイブ_デンマ デンマ;

		public バイブ_ドリル ドリル;

		public パ\u30FCル パ\u30FCル;

		public 羽根箒 羽根箒;

		public 調教鞭 調教鞭;

		public T剃刀 T剃刀;

		public キャップ1 キャップ1;

		public キャップ1 キャップ2;

		public キャップ1 キャップ3;

		public CM ペニスCM;

		public CM マウスCM;

		public CM ハンド右CM;

		public CM ハンド左CM;

		public CM ロ\u30FCタCM;

		public CM コモンCM;

		public CM ディルCM;

		public CM アナルCM;

		public CM デンマCM;

		public CM ドリルCM;

		public CM パ\u30FCルCM;

		public CM 羽根箒CM;

		public CM 調教鞭CM;

		public CM T剃刀CM;

		public CM キャップ1CM;

		public CM キャップ2CM;

		public CM キャップ3CM;

		public 挿入処理 ペニス挿入;

		public 挿入処理 マウス挿入;

		public 挿入処理 ハンド挿入;

		public 挿入処理 ロ\u30FCタ挿入;

		public 挿入処理 コモン挿入;

		public 挿入処理 ディル挿入;

		public 挿入処理 アナル挿入;

		public 挿入処理 デンマ挿入;

		public 挿入処理 ドリル挿入;

		public 挿入処理 パ\u30FCル挿入;

		public 羽箒処理 羽箒処理;

		public 剃刀処理 剃刀処理;

		public 調鞭処理 調鞭処理;

		public ハンド処理 ハンド処理;

		public マウス処理 マウス処理;

		public ペニス処理 ペニス処理;

		public キャップ処理 キャップ処理;

		public But 調教終了;

		public But 拘束具;

		public But 目隠帯;

		public But 玉口枷;

		public But 断面;

		public But 媚薬;

		public But 撮影;

		private Swi 拘束具sw = new Swi(Color.OrangeRed);

		private Swi 目隠帯sw = new Swi(Color.OrangeRed);

		private Swi 玉口枷sw = new Swi(Color.OrangeRed);

		private Swi 断面sw = new Swi(Color.OrangeRed);

		public Gau 体力sゲ\u30FCジ;

		public Gau 絶頂sゲ\u30FCジ;

		public Gau 興奮sゲ\u30FCジ;

		public Gau 精力mゲ\u30FCジ;

		public Gau 射精mゲ\u30FCジ;

		public Gau 興奮mゲ\u30FCジ;

		public Tex ステ\u30FCト;

		public bool ステ\u30FCト描画;

		public 射精 射精;

		public Mot 絶頂ゲ\u30FCジ点滅;

		public Mot 射精ゲ\u30FCジ点滅;

		public Mots Mots = new Mots();

		public 擬音 擬音;

		public Queue<Action<Are>> 擬音キュ\u30FC = new Queue<Action<Are>>();

		private Are Film;

		public bool コキ_;

		public bool ハンド左表示;

		private CM focus;

		private bool 持ち手_;

		public List<挿入処理> SubFocus = new List<挿入処理>();

		public bool 膣i肛f;

		public bool 肛f;

		public bool 肛oh;

		public bool IsTB;

		private 挿入処理 挿入処理f;

		public 挿入処理 挿入処理s;

		public const double cs = 1.09;

		public bool 押し状態;

		private MouseButtons d;

		private bool IsTool;

		private CM hcm;

		private 挿入処理 ef;

		private bool sf = true;

		public bool 強制拘束;

		public bool 拘束bu;

		public bool 発情bu;

		public double X;

		public double Y;

		public Tex InfoBox;

		public Tex SensitivityBox;

		public But SlaveStamina;

		public But PlayerStamina;
	}
}
