using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 挿入処理 : 処理B
	{
		private static void sound口()
		{
			if ((0.1 * Act.口挿入度).Lot())
			{
				int num = OthN.XS.Next(2);
				if (num == 0)
				{
					Sou.挿抜口1.Play();
					return;
				}
				if (num != 1)
				{
					return;
				}
				Sou.挿抜口2.Play();
			}
		}

		private static void sound膣()
		{
			if ((0.1 * Act.膣挿入度 * Act.緊張.Inverse()).Lot())
			{
				int num = OthN.XS.Next(2);
				if (num == 0)
				{
					Sou.挿抜前1.Play();
					return;
				}
				if (num != 1)
				{
					return;
				}
				Sou.挿抜前2.Play();
			}
		}

		private static void sound肛()
		{
			if (!(0.1 * Act.肛挿入度 * Act.緊張.Inverse()).Lot())
			{
				return;
			}
			switch (Oth.GetRandomIndex(new double[]
			{
				4.0,
				4.0,
				1.0,
				1.0
			}))
			{
			case 0:
				Sou.挿抜前3.Play();
				return;
			case 1:
				Sou.挿抜前4.Play();
				return;
			case 2:
				if (Sta.NoFarting)
				{
					Sou.挿抜前3.Play();
					return;
				}
				Sou.挿抜後1.Play();
				return;
			case 3:
				if (Sta.NoFarting)
				{
					Sou.挿抜前4.Play();
					return;
				}
				Sou.挿抜後2.Play();
				return;
			default:
				return;
			}
		}

		private static void sound糸()
		{
			if ((0.1 * Act.糸挿入度 * Act.緊張.Inverse()).Lot())
			{
				int num = OthN.XS.Next(2);
				if (num == 0)
				{
					Sou.挿抜糸1.Play();
					return;
				}
				if (num != 1)
				{
					return;
				}
				Sou.挿抜糸2.Play();
			}
		}

		private double clip(double v)
		{
			return (v - 0.35) / 0.65;
		}

		public void 口開始()
		{
			if (Act.変化V_口 > 0.35)
			{
				this.調教UI.擬音キュ\u30FC.Enqueue(delegate(Are a)
				{
					this.調教UI.擬音.Sound(a, this.Bod.口腔位置.GetAreaPoint(0.05), Sta.口挿.GetVal(this.clip(Act.変化V_口), Act.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.HotPink.S(Act.変化V_口.LimitM(0.5, 1.0)), 0.2 + 0.2 * OthN.XS.NextDouble() * Act.変化V_口, true);
				});
			}
		}

		public void 口継続()
		{
			if (Act.変化V_口 > 0.35 && this.CP挿入.GetFlag(0.1 + 0.1 * Act.変化V_口 * 0.8))
			{
				this.調教UI.擬音キュ\u30FC.Enqueue(delegate(Are a)
				{
					this.調教UI.擬音.Sound(a, this.Bod.口腔位置.GetAreaPoint(0.05), Sta.口中.GetVal(this.clip(Act.変化V_口), Act.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.HotPink.S(Act.変化V_口.LimitM(0.5, 1.0)), 0.2 + 0.2 * OthN.XS.NextDouble() * Act.変化V_口, true);
				});
			}
		}

		public void 口終了()
		{
			if (Act.変化V_口 > 0.35)
			{
				this.調教UI.擬音キュ\u30FC.Enqueue(delegate(Are a)
				{
					this.調教UI.擬音.Sound(a, this.Bod.口腔位置.GetAreaPoint(0.05), Sta.口抜.GetVal(this.clip(Act.変化V_口), Act.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.HotPink.S(Act.変化V_口.LimitM(0.5, 1.0)), 0.2 + 0.2 * OthN.XS.NextDouble() * Act.変化V_口, true);
				});
			}
		}

		public void 膣開始()
		{
			if (Act.変化V_膣 > 0.35)
			{
				this.調教UI.擬音キュ\u30FC.Enqueue(delegate(Are a)
				{
					this.調教UI.擬音.Sound(a, this.Bod.膣口位置.GetAreaPoint(0.04), Sta.膣挿.GetVal(this.clip(Act.変化V_膣), Act.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.DeepPink.S(Act.変化V_膣.LimitM(0.5, 1.0)), 0.2 + 0.2 * OthN.XS.NextDouble() * Act.変化V_膣, true);
				});
			}
		}

		public void 膣継続()
		{
			if (Act.変化V_膣 > 0.35 && this.CP挿入.GetFlag(0.1 + 0.1 * Act.変化V_膣 * 0.8))
			{
				this.調教UI.擬音キュ\u30FC.Enqueue(delegate(Are a)
				{
					this.調教UI.擬音.Sound(a, this.Bod.膣口位置.GetAreaPoint(0.04), Sta.膣中.GetVal(this.clip(Act.変化V_膣), Act.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.DeepPink.S(Act.変化V_膣.LimitM(0.5, 1.0)), 0.2 + 0.2 * OthN.XS.NextDouble() * Act.変化V_膣, true);
				});
			}
		}

		public void 膣終了()
		{
			if (Act.変化V_膣 > 0.35)
			{
				this.調教UI.擬音キュ\u30FC.Enqueue(delegate(Are a)
				{
					this.調教UI.擬音.Sound(a, this.Bod.膣口位置.GetAreaPoint(0.04), Sta.膣抜.GetVal(this.clip(Act.変化V_膣), Act.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.DeepPink.S(Act.変化V_膣.LimitM(0.5, 1.0)), 0.2 + 0.2 * OthN.XS.NextDouble() * Act.変化V_膣, true);
				});
			}
		}

		public void 肛開始()
		{
			if (Act.変化V_肛 > 0.35)
			{
				this.調教UI.擬音キュ\u30FC.Enqueue(delegate(Are a)
				{
					this.調教UI.擬音.Sound(a, this.Bod.肛門位置.GetAreaPoint(0.04), Sta.肛挿.GetVal(this.clip(Act.変化V_肛), Act.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.Coral.S(Act.変化V_肛.LimitM(0.5, 1.0)), 0.2 + 0.2 * OthN.XS.NextDouble() * Act.変化V_肛, true);
				});
			}
		}

		public void 肛継続()
		{
			if (Act.変化V_肛 > 0.35 && this.CP挿入.GetFlag(0.1 + 0.1 * Act.変化V_肛 * 0.8))
			{
				this.調教UI.擬音キュ\u30FC.Enqueue(delegate(Are a)
				{
					this.調教UI.擬音.Sound(a, this.Bod.肛門位置.GetAreaPoint(0.04), Sta.肛中.GetVal(this.clip(Act.変化V_肛), Act.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.Coral.S(Act.変化V_肛.LimitM(0.5, 1.0)), 0.2 + 0.2 * OthN.XS.NextDouble() * Act.変化V_肛, true);
				});
			}
		}

		public void 肛終了()
		{
			if (Act.変化V_肛 > 0.35)
			{
				this.調教UI.擬音キュ\u30FC.Enqueue(delegate(Are a)
				{
					this.調教UI.擬音.Sound(a, this.Bod.肛門位置.GetAreaPoint(0.04), Sta.肛抜.GetVal(this.clip(Act.変化V_肛), Act.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.Coral.S(Act.変化V_肛.LimitM(0.5, 1.0)), 0.2 + 0.2 * OthN.XS.NextDouble() * Act.変化V_肛, true);
				});
			}
		}

		public void 糸開始()
		{
			if (Act.変化V_糸 > 0.35)
			{
				this.調教UI.擬音キュ\u30FC.Enqueue(delegate(Are a)
				{
					this.調教UI.擬音.Sound(a, this.Bod.出糸位置.GetAreaPoint(0.04), Sta.糸挿.GetVal(this.clip(Act.変化V_糸), Act.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.MediumOrchid.S(Act.変化V_糸.LimitM(0.5, 1.0)), 0.2 + 0.2 * OthN.XS.NextDouble() * Act.変化V_糸, true);
				});
			}
		}

		public void 糸継続()
		{
			if (Act.変化V_糸 > 0.35 && this.CP挿入.GetFlag(0.1 + 0.1 * Act.変化V_糸 * 0.8))
			{
				this.調教UI.擬音キュ\u30FC.Enqueue(delegate(Are a)
				{
					this.調教UI.擬音.Sound(a, this.Bod.出糸位置.GetAreaPoint(0.04), Sta.糸中.GetVal(this.clip(Act.変化V_糸), Act.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.MediumOrchid.S(Act.変化V_糸.LimitM(0.5, 1.0)), 0.2 + 0.2 * OthN.XS.NextDouble() * Act.変化V_糸, true);
				});
			}
		}

		public void 糸終了()
		{
			if (Act.変化V_糸 > 0.35)
			{
				this.調教UI.擬音キュ\u30FC.Enqueue(delegate(Are a)
				{
					this.調教UI.擬音.Sound(a, this.Bod.出糸位置.GetAreaPoint(0.04), Sta.糸抜.GetVal(this.clip(Act.変化V_糸), Act.変化V_固有値乱数), new Font("MS Gothic", 1f), Color.MediumOrchid.S(Act.変化V_糸.LimitM(0.5, 1.0)), 0.2 + 0.2 * OthN.XS.NextDouble() * Act.変化V_糸, true);
				});
			}
		}

		public void 振動_()
		{
			if (this.CP振動.GetFlag(0.1 + 0.1 * base.強度))
			{
				this.調教UI.擬音キュ\u30FC.Enqueue(delegate(Are a)
				{
					this.調教UI.擬音.Sound(a, this.対象.Ele.位置.GetAreaPoint(0.04), Sta.振動.GetVal(1.0, 1.0), new Font("MS Gothic", 1f), Col.Black, 0.1 + 0.1 * base.強度, true);
				});
			}
		}

		public bool Is口
		{
			get
			{
				return this.挿入箇所 == 接触.口;
			}
		}

		public bool Is膣
		{
			get
			{
				return this.挿入箇所 == 接触.膣;
			}
		}

		public bool Is肛
		{
			get
			{
				return this.挿入箇所 == 接触.肛;
			}
		}

		public bool Is糸
		{
			get
			{
				return this.挿入箇所 == 接触.糸;
			}
		}

		public bool Isモ\u30FCド
		{
			get
			{
				return this.Is押付 || this.Is挿入;
			}
		}

		public bool 振動
		{
			get
			{
				return this.振動機能 && this.振動モ\u30FCション.Run;
			}
			set
			{
				if (this.振動機能)
				{
					if (value)
					{
						this.振動モ\u30FCション.Sta();
						return;
					}
					this.振動モ\u30FCション.End();
				}
			}
		}

		public bool 回転
		{
			get
			{
				return this.回転機能 && this.回転モ\u30FCション.Run;
			}
			set
			{
				if (this.回転機能)
				{
					if (value)
					{
						this.回転モ\u30FCション.Sta();
						return;
					}
					this.回転モ\u30FCション.End();
				}
			}
		}

		private double 排出
		{
			get
			{
				if (this.Is口)
				{
					return this.口排出度 * 2.0 * (this.振動 ? (2.0 * base.強度) : 1.0) * (this.回転 ? (0.9 * base.強度) : 1.0);
				}
				if (this.Is膣)
				{
					return this.膣排出度 * 1.0 * (this.振動 ? (2.0 * base.強度) : 1.0) * (this.回転 ? (0.9 * base.強度) : 1.0);
				}
				if (this.Is肛)
				{
					return this.肛排出度 * 1.0 * (this.振動 ? (2.0 * base.強度) : 1.0) * (this.回転 ? (0.9 * base.強度) : 1.0);
				}
				if (this.Is糸)
				{
					return this.糸排出度 * 0.8 * (this.振動 ? (2.0 * base.強度) : 1.0) * (this.回転 ? (0.9 * base.強度) : 1.0);
				}
				return 0.0;
			}
		}

		private double 口挿抜
		{
			set
			{
				if (this.対象.Ele is バイブ_アナル)
				{
					this.対象.Ele.Yv = (this.対象.Ele.Yv + value).LimitM(0.0, this.Bod.Is獣 ? 挿入処理.A通常獣最大v : 挿入処理.A通常人最大v);
					return;
				}
				if (this.対象.Ele is パ\u30FCル)
				{
					this.対象.Ele.Yv = (this.対象.Ele.Yv + value).LimitM(0.0, this.Bod.Is獣 ? 挿入処理.P通常獣最大v : 挿入処理.P通常人最大v);
					return;
				}
				this.対象.Ele.Yv = (this.対象.Ele.Yv + value).LimitM(0.0, 1.0);
			}
		}

		private double 膣挿抜
		{
			set
			{
				if (this.Bod.断面_表示)
				{
					this.dv = (this.dv + value).LimitM(0.0, 1.0);
					this.dy = ((this.dv >= 1.0) ? (this.対象.Ele.本体.CountY - 1) : ((int)((double)this.対象.Ele.本体.CountY * this.dv)));
					if (this.対象.Ele is バイブ_アナル)
					{
						this.dy = this.dy.Limit(0, this.Bod.Is獣 ? 挿入処理.A断面獣最大i : 挿入処理.A断面人最大i);
					}
					else if (this.対象.Ele is パ\u30FCル)
					{
						this.dy = this.dy.Limit(0, this.Bod.Is獣 ? 挿入処理.P断面獣最大i : 挿入処理.P断面人最大i);
					}
					if ((!(this.対象.Ele is ハンド) || (this.対象.Ele.Xi != 6 && this.対象.Ele.Xi != 7)) && !(this.対象.Ele is マウス) && (!this.Bod.Is獣 || (!(this.対象.Ele is パ\u30FCル) && !(this.対象.Ele is ロ\u30FCタ))))
					{
						if (this.対象.Ele is バイブ_デンマ)
						{
							this.Bod.断面.Yv = this.dv.LimitM(挿入処理.断面単位v, 挿入処理.断面単位v3);
						}
						else if (this.対象.Ele is ロ\u30FCタ || this.対象.Ele is ハンド)
						{
							this.Bod.断面.Yv = this.dv.LimitM(0.0, 挿入処理.断面単位v2);
						}
						else
						{
							this.Bod.断面.Yv = this.dv.LimitM(0.0, 1.0);
						}
					}
					if (!this.Bod.Is獣 && !(this.対象.Ele is バイブ_デンマ) && !(this.対象.Ele is ハンド) && !(this.対象.Ele is マウス) && !(this.対象.Ele is ロ\u30FCタ))
					{
						this.Bod.断面.膣サイズY = 1.0 + 0.2 * this.dv.LimitM(0.0, 1.0);
						this.Bod.膣内精液.尺度YC = this.Bod.断面.膣サイズY;
						this.Bod.膣基.尺度YC = this.Bod.断面.膣サイズY;
					}
					if (!(this.対象.Ele is ハンド) || (this.対象.Ele.Xi != 6 && this.対象.Ele.Xi != 7))
					{
						this.Bod.性器.Yv = this.dv.LimitM(挿入処理.性器単位v, 1.0);
						return;
					}
				}
				else
				{
					if (this.対象.Ele is バイブ_アナル)
					{
						this.対象.Ele.Yv = (this.対象.Ele.Yv + value).LimitM(0.0, this.Bod.Is獣 ? 挿入処理.A通常獣最大v : 挿入処理.A通常人最大v);
					}
					else if (this.対象.Ele is パ\u30FCル)
					{
						this.対象.Ele.Yv = (this.対象.Ele.Yv + value).LimitM(0.0, this.Bod.Is獣 ? 挿入処理.P通常獣最大v : 挿入処理.P通常人最大v);
					}
					else
					{
						this.対象.Ele.Yv = (this.対象.Ele.Yv + value).LimitM(0.0, 1.0);
					}
					if (!(this.対象.Ele is ハンド) || (this.対象.Ele.Xi != 6 && this.対象.Ele.Xi != 7))
					{
						this.Bod.性器.Yv = this.対象.Ele.Yv.LimitM(挿入処理.性器単位v, 1.0);
					}
				}
			}
		}

		private double 肛挿抜
		{
			set
			{
				this.対象.Ele.Yv = (this.対象.Ele.Yv + value).LimitM(0.0, 1.0);
			}
		}

		private double 糸挿抜
		{
			set
			{
				if (this.対象.Ele is バイブ_アナル)
				{
					this.対象.Ele.Yv = (this.対象.Ele.Yv + value).LimitM(0.0, 挿入処理.A通常人最大v);
					return;
				}
				if (this.対象.Ele is パ\u30FCル)
				{
					this.対象.Ele.Yv = (this.対象.Ele.Yv + value).LimitM(0.0, 挿入処理.P通常人最大v);
					return;
				}
				this.対象.Ele.Yv = (this.対象.Ele.Yv + value).LimitM(0.0, 1.0);
			}
		}

		public double Insert
		{
			get
			{
				if (!this.Is膣 || !this.Bod.断面_表示)
				{
					return this.対象.Ele.Yv;
				}
				return this.dv;
			}
			set
			{
				if (this.Is口)
				{
					this.口挿抜 = value;
					return;
				}
				if (this.Is膣)
				{
					this.膣挿抜 = value;
					return;
				}
				if (this.Is肛)
				{
					this.肛挿抜 = value;
					return;
				}
				if (this.Is糸)
				{
					this.糸挿抜 = value;
				}
			}
		}

		public void MoveR(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref 接触D cd)
		{
			if (this.調教UI.SubFocus.Contains(this))
			{
				this.vr = Cursor.Position.ToVector2D();
				this.xr = (this.or.X - this.vr.X) * -0.008;
				this.yr = (this.or.Y - this.vr.Y) * -0.008;
				if (this.挿入箇所 == 接触.膣)
				{
					this.膣挿抜 = this.yr * Act.膣挿入度;
					this.調教UI.Action(接触.膣, アクション情報.挿入, タイミング情報.継続, this.アイテム情報, this.対象.Ele.Yi, 1, false, false);
					Act.奴体力消費小();
					Act.主精力消費小();
					this.膣継続();
				}
				else if (this.挿入箇所 == 接触.肛)
				{
					this.肛挿抜 = this.yr * Act.肛挿入度;
					this.調教UI.Action(接触.肛, アクション情報.挿入, タイミング情報.継続, this.アイテム情報, this.対象.Ele.Yi, 1, false, false);
					Act.奴体力消費小();
					Act.主精力消費小();
					this.肛継続();
				}
				this.対象.Ele.角度C = (100.0 * this.xr).LimitM(-5.0, 5.0);
				this.or = this.vr;
			}
		}

		public void SetPosition()
		{
			if (this.Is挿入)
			{
				if (this.Is口)
				{
					this.a = this.対象.Ele.角度C;
					this.調教UI.Set_口(this.対象.Ele);
					this.対象.Ele.角度C = this.a;
					return;
				}
				if (this.Is膣)
				{
					if (!this.Bod.断面_表示)
					{
						this.a = this.対象.Ele.角度C;
						this.調教UI.Set_膣口(this.対象.Ele);
						this.対象.Ele.角度C = this.a;
						return;
					}
					this.Bod.性器.接続PA();
					this.対象.Ele.位置B = this.Bod.性器.本体.Current.EnumAllPar().First((Par p_) => p_.Tag.Contains("膣口")).Position;
					this.p0 = this.対象.Ele.本体.pr[this.対象.Ele.本体[this.対象.Ele.本体.IndexX][0]];
					this.py = this.対象.Ele.本体.pr[this.対象.Ele.本体[this.対象.Ele.本体.IndexX][this.dy]];
					if (this.pn)
					{
						this.bp = this.py.PositionBase;
						this.py.PositionBase = this.対象.Ele.位置B;
						this.y0 = this.py.ToGlobal(this.py.OP[0].ps[this.psi]).Y;
						this.py.PositionBase = this.bp;
					}
					else
					{
						this.y0 = this.py.ToGlobal(this.py.OP[0].ps[this.psi]).Y;
					}
					this.対象.Ele.位置B = this.対象.Ele.位置B.AddY(this.p0.BasePointBase.Y - this.py.BasePointBase.Y);
					if (this.pn)
					{
						this.bp = this.p0.PositionBase;
						this.p0.PositionBase = this.対象.Ele.位置B;
						this.対象.Ele.位置B = this.対象.Ele.位置B.AddY(this.y0 - this.p0.ToGlobal(this.p0.OP[0].ps[this.psi]).Y);
						this.p0.PositionBase = this.bp;
						return;
					}
					this.対象.Ele.位置B = this.対象.Ele.位置B.AddY(this.y0 - this.p0.ToGlobal(this.p0.OP[0].ps[this.psi]).Y);
					return;
				}
				else
				{
					if (this.Is肛)
					{
						this.a = this.対象.Ele.角度C;
						this.調教UI.Set_肛門(this.対象.Ele);
						this.対象.Ele.角度C = this.a;
						return;
					}
					if (this.Is糸)
					{
						this.a = this.対象.Ele.角度C;
						this.調教UI.Set_出糸(this.対象.Ele);
						this.対象.Ele.角度C = this.a;
					}
				}
			}
		}

		public void 解除()
		{
			this.Is挿入 = false;
			if (this.Is口)
			{
				this.Bod.口i = 9;
			}
			else if (this.Is膣)
			{
				this.Bod.性器.Xi = 1;
				this.Bod.性器.Yi = 0;
				if (!(this.対象.Ele is ハンド) || this.対象.Ele.Xi != 7)
				{
					this.Bod.性器.くぱぁ = this.くぱぁ;
				}
				if (this.Bod.断面_表示)
				{
					this.Insert = 0.0;
					this.Bod.断面.Yi = 0;
					this.dv = 0.0;
					this.dy = 0;
				}
				this.対象.Under = false;
			}
			else if (this.Is肛)
			{
				this.対象.Under = false;
			}
			else
			{
				bool is糸 = this.Is糸;
			}
			this.挿入箇所 = 接触.none;
			this.対象.Ele.角度C = 0.0;
			if (this.対象.Ele is ペニス)
			{
				this.対象.Ele.Xi = 0;
			}
			this.対象.Ele.Yi = 0;
			if (this.調教UI.挿入処理s != null)
			{
				this.調教UI.挿入処理s.対象.Ele.角度C = 0.0;
				this.調教UI.挿入処理s.Insert = 1.0;
			}
			this.調教UI.放し();
		}

		private string 挿入中0()
		{
			object[] array = new object[8];
			array[0] = "\r\nMCl:";
			array[1] = (this.振動 ? tex.停止 : tex.作動);
			array[2] = "\r\nWh:";
			array[3] = tex.強さL;
			array[4] = this.強さ;
			int num = 5;
			bool is口 = this.Is口;
			array[num] = "\r\nRCl:" + tex.放す;
			array[6] = "\r\nLUp&Mo↓:";
			array[7] = tex.引抜く;
			return string.Concat(array);
		}

		private void 挿入中1(string str)
		{
			if (Sta.GameData.ガイド)
			{
				if (this.振動機能)
				{
					this.ip.SubInfoIm = str + this.挿入中0();
					return;
				}
				if (!this.挿抜モ\u30FCション.Run)
				{
					情報パネル ip = this.ip;
					string[] array = new string[6];
					array[0] = str;
					array[1] = "\r\n";
					int num = 2;
					string text;
					if (this.対象 != this.調教UI.ハンド右CM && this.対象 != this.調教UI.マウスCM && this.対象 != this.調教UI.ペニスCM)
					{
						bool is口 = this.Is口;
						text = "RCl:" + tex.放す + "\r\n";
					}
					else
					{
						text = "";
					}
					array[num] = text;
					array[3] = "LUp&Mo↓:";
					array[4] = tex.引抜く;
					array[5] = "\r\n";
					ip.SubInfoIm = string.Concat(array);
				}
			}
		}

		private string 待機時0()
		{
			return string.Concat(new object[]
			{
				"MCl:",
				this.振動 ? tex.停止 : tex.作動,
				"\r\nWh:",
				tex.強さL,
				this.強さ,
				"\r\nRCl:",
				tex.放す
			});
		}

		private void 待機時1()
		{
			if (Sta.GameData.ガイド)
			{
				if (this.振動機能)
				{
					this.ip.SubInfoIm = this.待機時0();
					return;
				}
				if (this.対象 == this.調教UI.パ\u30FCルCM)
				{
					this.ip.SubInfoIm = "RCl:" + tex.放す;
					return;
				}
				this.ip.SubInfoIm = "";
			}
		}

		private void 押付時(ref 接触D cd)
		{
			if (Sta.GameData.ガイド)
			{
				if (this.振動機能)
				{
					this.ip.SubInfoIm = (this.Is押付 ? ("LUp:" + tex.離す + "\r\n") : (this.調教UI.IsHitCha(ref cd) ? ("LDo:" + tex.押付け + "\r\n") : "")) + this.待機時0();
					return;
				}
				if (this.対象 == this.調教UI.ペニスCM)
				{
					this.ip.SubInfoIm = (this.Is押付 ? ("LUp:" + tex.離す) : (this.調教UI.IsHitCha(ref cd) ? ("LDo:" + tex.押付け) : ""));
					return;
				}
				if (this.対象 == this.調教UI.パ\u30FCルCM)
				{
					this.ip.SubInfoIm = "RCl:" + tex.放す;
					return;
				}
				this.ip.SubInfoIm = "";
			}
		}

		private void 挿入時(string str)
		{
			if (Sta.GameData.ガイド)
			{
				this.ip.SubInfoIm = str + "\r\nLDo&Mo↑:" + tex.挿入;
			}
		}

		public void 断面切替(double v)
		{
			if (this.Bod.断面_表示)
			{
				this.対象.Ele.Yi = 0;
				this.Bod.性器.Xi = 3;
				this.dv = v;
				this.dy = ((this.dv >= 1.0) ? (this.対象.Ele.本体.CountY - 1) : ((int)((double)this.対象.Ele.本体.CountY * this.dv)));
				if (this.対象.Ele is バイブ_アナル)
				{
					this.dy = this.dy.Limit(0, this.Bod.Is獣 ? 挿入処理.A断面獣最大i : 挿入処理.A断面人最大i);
				}
				else if (this.対象.Ele is パ\u30FCル)
				{
					this.dy = this.dy.Limit(0, this.Bod.Is獣 ? 挿入処理.P断面獣最大i : 挿入処理.P断面人最大i);
				}
				if ((!(this.対象.Ele is ハンド) || (this.対象.Ele.Xi != 6 && this.対象.Ele.Xi != 7)) && !(this.対象.Ele is マウス) && (!this.Bod.Is獣 || (!(this.対象.Ele is パ\u30FCル) && !(this.対象.Ele is ロ\u30FCタ))))
				{
					if (this.対象.Ele is バイブ_デンマ)
					{
						this.Bod.断面.Yv = this.dv.LimitM(挿入処理.断面単位v, 挿入処理.断面単位v3);
					}
					else if (this.対象.Ele is ロ\u30FCタ || this.対象.Ele is ハンド)
					{
						this.Bod.断面.Yv = this.dv.LimitM(0.0, 挿入処理.断面単位v2);
					}
					else
					{
						this.Bod.断面.Yv = this.dv.LimitM(0.0, 1.0);
					}
				}
				if (!this.Bod.Is獣 && !(this.対象.Ele is バイブ_デンマ) && !(this.対象.Ele is ハンド) && !(this.対象.Ele is マウス) && !(this.対象.Ele is ロ\u30FCタ))
				{
					this.Bod.断面.膣サイズY = 1.0 + 0.2 * this.dv.LimitM(0.0, 1.0);
					this.Bod.膣内精液.尺度YC = this.Bod.断面.膣サイズY;
					this.Bod.膣基.尺度YC = this.Bod.断面.膣サイズY;
				}
				if (!(this.対象.Ele is ハンド) || (this.対象.Ele.Xi != 6 && this.対象.Ele.Xi != 7))
				{
					this.Bod.性器.Yv = this.dv.LimitM(挿入処理.性器単位v, 1.0);
					return;
				}
			}
			else
			{
				this.Bod.性器.Xi = 2;
				if (this.対象.Ele is バイブ_アナル)
				{
					this.対象.Ele.Yv = v.LimitM(0.0, this.Bod.Is獣 ? 挿入処理.A通常獣最大v : 挿入処理.A通常人最大v);
				}
				else if (this.対象.Ele is パ\u30FCル)
				{
					this.対象.Ele.Yv = v.LimitM(0.0, this.Bod.Is獣 ? 挿入処理.P通常獣最大v : 挿入処理.P通常人最大v);
				}
				else
				{
					this.対象.Ele.Yv = v.LimitM(0.0, 1.0);
				}
				if (!(this.対象.Ele is ハンド) || (this.対象.Ele.Xi != 6 && this.対象.Ele.Xi != 7))
				{
					this.Bod.性器.Yv = this.対象.Ele.Yv.LimitM(挿入処理.性器単位v, 1.0);
				}
			}
		}

		public void 突き上げ()
		{
			if (this.対象.Ele is ペニス && this.Insert > this.oi && this.Insert > 0.8)
			{
				this.Cha.体揺れ.Sta();
			}
			this.oi = this.Insert;
		}

		public void Move(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref 接触D cd)
		{
			if (!this.挿抜モ\u30FCション.Run)
			{
				this.MoveO(ref mb, ref cp, ref hc, ref cd);
			}
		}

		public void MoveO(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref 接触D cd)
		{
			this.cd = cd;
			if (this.調教UI.Focus == this.対象 || this.調教UI.SubFocus.Contains(this) || this.挿抜モ\u30FCション.Run)
			{
				this.v = (this.挿抜モ\u30FCション.Run ? cp : Cursor.Position.ToVector2D());
				if (this.調教UI.Focus == this.対象 || this.挿抜モ\u30FCション.Run)
				{
					if (this.Isモ\u30FCド)
					{
						this.x = (this.o.X - this.v.X) * 0.008;
						this.y = (this.o.Y - this.v.Y) * 0.008;
						if (this.Is挿入)
						{
							this.対象.Ele.角度C = (100.0 * this.x).LimitM(-5.0, 5.0);
							if (this.Is口)
							{
								this.挿入中1(tex.口腔);
								this.口挿抜 = this.y * Act.口挿入度;
								this.調教UI.Action(接触.口, アクション情報.挿入, タイミング情報.継続, this.アイテム情報, this.対象.Ele.Yi, 1, false, false);
								Act.奴体力消費小();
								Act.主精力消費小();
								this.口継続();
								if (mb != MouseButtons.Left && this.対象.Ele.Yi == 0 && this.o.Y < this.v.Y && !this.挿抜モ\u30FCション.Run)
								{
									this.調教UI.Action(接触.口, アクション情報.挿入, タイミング情報.終了, this.アイテム情報, 0, 1, false, false);
									Act.奴体力消費小();
									Act.主精力消費小();
									this.口終了();
									this.解除();
									Cursor.Position = this.Med.BaseControlC.PointToScreen(this.Med.FromBasePosition(this.対象.Ele.位置B));
									this.待機時1();
									if (this.調教UI.ペニス処理.フェラ.Run)
									{
										this.調教UI.ペニス処理.フェラ.End();
									}
									if (this.調教UI.ペニス処理.中出し)
									{
										if (this.Cha.ChaD.技巧度 > 0.5 * Sta.GameData.調教対象.技巧最大値 && this.Cha.ChaD.情愛度 > 0.6 && this.Cha.ChaD.欲望度 > 0.5)
										{
											this.Cha.ごっくん.Sta();
										}
										else
										{
											this.Cha.口腔精液垂れ.Sta();
										}
										this.調教UI.ペニス処理.中出しCount = 0;
										this.調教UI.ペニス処理.中出し = false;
									}
									this.挿抜モ\u30FCション.End();
								}
								if (Act.潤滑 > 0.5 && Act.挿入Lvn > Act.挿入Lvo)
								{
									挿入処理.sound口();
								}
							}
							else if (this.Is肛)
							{
								this.挿入中1(tex.肛門);
								this.肛挿抜 = this.y * Act.肛挿入度;
								this.調教UI.Action(接触.肛, アクション情報.挿入, タイミング情報.継続, this.アイテム情報, this.対象.Ele.Yi, 1, false, false);
								Act.奴体力消費小();
								Act.主精力消費小();
								this.肛継続();
								if (mb != MouseButtons.Left && this.対象.Ele.Yi == 0 && this.o.Y < this.v.Y && !this.挿抜モ\u30FCション.Run)
								{
									this.調教UI.Action(接触.肛, アクション情報.挿入, タイミング情報.終了, this.アイテム情報, 0, 1, false, false);
									Act.奴体力消費小();
									Act.主精力消費小();
									this.肛終了();
									this.解除();
									Cursor.Position = this.Med.BaseControlC.PointToScreen(this.Med.FromBasePosition(this.対象.Ele.位置B));
									this.待機時1();
									if (this.調教UI.ペニス処理.中出し)
									{
										this.Cha.肛門精液垂れ.Sta();
										this.調教UI.ペニス処理.中出しCount = 0;
										this.調教UI.ペニス処理.中出し = false;
									}
									this.挿抜モ\u30FCション.End();
								}
								if (Act.潤滑 > 0.5 && Act.挿入Lvn > Act.挿入Lvo)
								{
									挿入処理.sound肛();
								}
								this.突き上げ();
							}
							else if (this.Is膣)
							{
								this.挿入中1(tex.膣腔);
								this.膣挿抜 = this.y * Act.膣挿入度;
								this.調教UI.Action(接触.膣, アクション情報.挿入, タイミング情報.継続, this.アイテム情報, ((int)(this.Insert * 5.0)).LimitM(0, 4), 1, false, false);
								Act.奴体力消費小();
								Act.主精力消費小();
								this.膣継続();
								if (mb != MouseButtons.Left && (this.Bod.断面_表示 ? (this.dy == 0) : (this.対象.Ele.Yi == 0)) && this.o.Y < this.v.Y && !this.挿抜モ\u30FCション.Run)
								{
									this.調教UI.Action(接触.膣, アクション情報.挿入, タイミング情報.終了, this.アイテム情報, 0, 1, false, false);
									Act.奴体力消費小();
									Act.主精力消費小();
									this.膣終了();
									this.解除();
									Cursor.Position = this.Med.BaseControlC.PointToScreen(this.Med.FromBasePosition(this.対象.Ele.位置B));
									this.待機時1();
									if (this.調教UI.ペニス処理.中出し)
									{
										this.Cha.性器精液垂れ.Sta();
										this.調教UI.ペニス処理.中出しCount = 0;
										this.調教UI.ペニス処理.中出し = false;
									}
									this.挿抜モ\u30FCション.End();
								}
								if (Act.潤滑 > 0.5 && Act.挿入Lvn > Act.挿入Lvo)
								{
									挿入処理.sound膣();
								}
								this.突き上げ();
							}
							else if (this.Is糸)
							{
								this.挿入中1(tex.出糸);
								this.糸挿抜 = this.y * Act.糸挿入度;
								this.調教UI.Action(接触.糸, アクション情報.挿入, タイミング情報.継続, this.アイテム情報, this.対象.Ele.Yi, 1, false, false);
								Act.奴体力消費小();
								Act.主精力消費小();
								this.糸継続();
								if (mb != MouseButtons.Left && this.対象.Ele.Yi == 0 && this.o.Y < this.v.Y && !this.挿抜モ\u30FCション.Run)
								{
									this.調教UI.Action(接触.糸, アクション情報.挿入, タイミング情報.終了, this.アイテム情報, 0, 1, false, false);
									Act.奴体力消費小();
									Act.主精力消費小();
									this.糸終了();
									this.解除();
									Cursor.Position = this.Med.BaseControlC.PointToScreen(this.Med.FromBasePosition(this.対象.Ele.位置B));
									this.待機時1();
									if (this.調教UI.ペニス処理.中出し)
									{
										this.Cha.出糸精液垂れ.Sta();
										this.調教UI.ペニス処理.中出しCount = 0;
										this.調教UI.ペニス処理.中出し = false;
									}
									this.挿抜モ\u30FCション.End();
								}
								if (Act.潤滑 > 0.5 && Act.挿入Lvn > Act.挿入Lvo)
								{
									挿入処理.sound糸();
								}
							}
						}
						else if (this.Is押付)
						{
							if (this.調教UI.IsHitCha(ref cd))
							{
								if (!this.調教UI.押し状態)
								{
									this.調教UI.押し(ref cd);
									this.調教UI.Action(cd.c, アクション情報.接触, タイミング情報.開始, this.アイテム情報, 0, 1, false, false);
									Act.奴体力消費小();
									Act.主精力消費小();
								}
								if (this.対象 == this.調教UI.ペニスCM)
								{
									this.対象.Ele.角度C = (100.0 * this.x).LimitM(-4.0, 4.0);
								}
								else
								{
									this.対象.Ele.角度C = (100.0 * this.x).LimitM(-11.0, 11.0);
								}
								this.調教UI.Action(cd.c, アクション情報.接触, タイミング情報.継続, this.アイテム情報, 0, 1, false, false);
								Act.奴体力消費小();
								Act.主精力消費小();
							}
							else if (this.調教UI.押し状態)
							{
								this.調教UI.Action(cd.c, アクション情報.接触, タイミング情報.終了, this.アイテム情報, 0, 1, false, false);
								Act.奴体力消費小();
								Act.主精力消費小();
								this.対象.Ele.角度C = 0.0;
								this.調教UI.放し();
							}
							this.押付時(ref cd);
						}
					}
					else
					{
						if (Act.フェラ1 && cd.c == 接触.口)
						{
							if (!this.調教UI.SubFocus.Any((挿入処理 e) => e.Is口))
							{
								this.調教UI.Set_口(this.対象.Ele);
								this.挿入時(tex.口腔);
								goto IL_B2B;
							}
						}
						if (cd.c == 接触.肛)
						{
							if (!this.調教UI.SubFocus.Any((挿入処理 e) => e.Is肛))
							{
								this.調教UI.Set_肛門(this.対象.Ele);
								this.挿入時(tex.肛門);
								goto IL_B2B;
							}
						}
						if (cd.c == 接触.膣)
						{
							if (!this.調教UI.SubFocus.Any((挿入処理 e) => e.Is膣))
							{
								this.調教UI.Set_膣口(this.対象.Ele);
								this.挿入時(tex.膣腔);
								goto IL_B2B;
							}
						}
						if (cd.c == 接触.糸)
						{
							if (!this.調教UI.SubFocus.Any((挿入処理 e) => e.Is糸))
							{
								this.調教UI.Set_出糸(this.対象.Ele);
								this.挿入時(tex.出糸);
								goto IL_B2B;
							}
						}
						if (this.押し付け)
						{
							this.押付時(ref cd);
						}
						else
						{
							this.待機時1();
						}
					}
				}
				IL_B2B:
				this.o = this.v;
			}
		}

		private void 差し置き()
		{
			if (this.調教UI.Focus == this.調教UI.ペニスCM || this.調教UI.Focus == this.調教UI.マウスCM)
			{
				this.調教UI.挿入放し();
				this.対象.Ele.角度C = 0.0;
				if (this.調教UI.挿入処理s != null)
				{
					this.調教UI.挿入処理s.対象.Ele.角度C = 0.0;
					this.調教UI.挿入処理s.Insert = 1.0;
				}
				this.調教UI.放し();
			}
		}

		public void Down(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref 接触D cd)
		{
			if (this.調教UI.Focus == this.対象)
			{
				if (mb == MouseButtons.Left)
				{
					if (!this.Isモ\u30FCド)
					{
						if (Act.フェラ1 && cd.c == 接触.口)
						{
							if (!this.調教UI.SubFocus.Any((挿入処理 e) => e.Is口))
							{
								this.調教UI.押し(ref cd);
								this.Is挿入 = true;
								this.挿入箇所 = cd.c;
								if (this.対象.Ele is ペニス)
								{
									this.対象.Ele.Xi = 1;
								}
								this.対象.Ele.Yi = 0;
								this.Bod.口i = 13;
								if (Act.フェラ2)
								{
									this.調教UI.ペニス処理.フェラ.Sta();
								}
								this.調教UI.Action(接触.口, アクション情報.挿入, タイミング情報.開始, this.アイテム情報, 0, 1, false, false);
								Act.奴体力消費小();
								Act.主精力消費小();
								this.口開始();
								this.調教UI.口腔演出();
								this.調教UI.腕修正();
								this.調教UI.大顎修正();
								return;
							}
						}
						if (cd.c == 接触.肛)
						{
							if (!this.調教UI.SubFocus.Any((挿入処理 e) => e.Is肛))
							{
								this.調教UI.押し(ref cd);
								this.Is挿入 = true;
								this.挿入箇所 = cd.c;
								if (this.対象.Ele is ペニス)
								{
									this.対象.Ele.Xi = 1;
								}
								this.対象.Ele.Yi = 0;
								this.対象.Under = true;
								this.調教UI.Action(接触.肛, アクション情報.挿入, タイミング情報.開始, this.アイテム情報, 0, 1, false, false);
								Act.奴体力消費小();
								Act.主精力消費小();
								this.肛開始();
								this.調教UI.肛門演出();
								this.調教UI.脚修正();
								return;
							}
						}
						if (cd.c == 接触.膣)
						{
							if (!this.調教UI.SubFocus.Any((挿入処理 e) => e.Is膣))
							{
								this.調教UI.押し(ref cd);
								this.Is挿入 = true;
								this.挿入箇所 = cd.c;
								if (this.対象.Ele is ペニス)
								{
									this.対象.Ele.Xi = 1;
								}
								this.対象.Ele.Yi = 0;
								this.対象.Under = true;
								if (this.Bod.断面_表示)
								{
									this.Bod.性器.Xi = 3;
								}
								else
								{
									this.Bod.性器.Xi = 2;
								}
								this.Bod.性器.Yi = 1;
								if ((!(this.対象.Ele is ハンド) || this.対象.Ele.Xi != 7) && !(this.対象.Ele is マウス))
								{
									this.くぱぁ = this.Bod.性器.くぱぁ;
									this.Bod.性器.くぱぁ = 1.0;
								}
								this.調教UI.Action(接触.膣, アクション情報.挿入, タイミング情報.開始, this.アイテム情報, 0, 1, false, false);
								Act.奴体力消費小();
								Act.主精力消費小();
								this.膣開始();
								this.調教UI.膣腔演出();
								this.調教UI.脚修正();
								return;
							}
						}
						if (cd.c == 接触.糸)
						{
							if (!this.調教UI.SubFocus.Any((挿入処理 e) => e.Is糸))
							{
								this.調教UI.押し(ref cd);
								this.Is挿入 = true;
								this.挿入箇所 = cd.c;
								if (this.対象.Ele is ペニス)
								{
									this.対象.Ele.Xi = 1;
								}
								this.対象.Ele.Yi = 0;
								this.調教UI.Action(接触.糸, アクション情報.挿入, タイミング情報.開始, this.アイテム情報, 0, 1, false, false);
								Act.奴体力消費小();
								Act.主精力消費小();
								this.糸開始();
								this.調教UI.出糸演出();
								this.調教UI.脚修正();
								return;
							}
						}
						if (this.押し付け && !this.Is押付 && this.調教UI.IsHitCha(ref cd))
						{
							this.調教UI.押し(ref cd);
							this.Is押付 = true;
							this.押付時(ref cd);
							this.調教UI.Action(cd.c, アクション情報.接触, タイミング情報.開始, this.アイテム情報, 0, 1, false, false);
							Act.奴体力消費小();
							Act.主精力消費小();
							this.調教UI.肌体演出();
							return;
						}
					}
					else if ((this.調教UI.Focus == this.調教UI.マウスCM && this.Is口) || (this.調教UI.Focus != this.調教UI.マウスCM && this.調教UI.Focus != this.調教UI.ハンド右CM))
					{
						if (this.挿抜フラグ)
						{
							this.挿抜フラグ = false;
							return;
						}
						if (this.挿抜モ\u30FCション.Run)
						{
							this.挿抜モ\u30FCション.End();
							return;
						}
						this.挿抜モ\u30FCション.Sta();
						this.差し置き();
						return;
					}
				}
				else if (mb == MouseButtons.Middle)
				{
					if (this.振動機能)
					{
						this.振動 = !this.振動;
						if (this.回転機能)
						{
							this.回転 = !this.回転;
						}
						if (!this.Is挿入)
						{
							this.押付時(ref cd);
							return;
						}
						if (Sta.GameData.ガイド)
						{
							if (this.Is口)
							{
								this.ip.SubInfoIm = tex.口腔 + this.挿入中0();
								return;
							}
							if (this.Is肛)
							{
								this.ip.SubInfoIm = tex.肛門 + this.挿入中0();
								return;
							}
							if (this.Is膣)
							{
								this.ip.SubInfoIm = tex.膣腔 + this.挿入中0();
								return;
							}
							if (this.Is糸)
							{
								this.ip.SubInfoIm = tex.出糸 + this.挿入中0();
								return;
							}
						}
					}
				}
				else if (mb == MouseButtons.Right && !this.調教UI.コキ)
				{
					bool is口 = this.Is口;
					if (this.Is挿入 && ((!this.Is膣 && this.対象.Ele.Yi > 0) || (this.Is膣 && this.Bod.断面_表示 && this.dy > 0) || (!this.Bod.断面_表示 && this.対象.Ele.Yi > 0)))
					{
						if (this.調教UI.Focus != this.調教UI.ハンド右CM && this.調教UI.Focus != this.調教UI.マウスCM && this.調教UI.Focus != this.調教UI.ペニスCM)
						{
							this.挿抜モ\u30FCション.End();
							this.調教UI.挿入放し();
							this.対象.Ele.角度C = 0.0;
							if (this.調教UI.挿入処理s != null)
							{
								this.調教UI.挿入処理s.対象.Ele.角度C = 0.0;
								this.調教UI.挿入処理s.Insert = 1.0;
							}
							this.調教UI.放し();
							return;
						}
					}
					else if (this.調教UI.Focus != this.調教UI.ハンド右CM && !this.Isモ\u30FCド)
					{
						this.解除();
						Cursor.Position = this.Med.BaseControlC.PointToScreen(this.Med.FromBasePosition(this.対象.Ele.位置B));
						this.調教UI.通常放し();
					}
				}
			}
		}

		public void Up(ref MouseButtons mb, ref Vector2D cp, ref Color hc, ref 接触D cd)
		{
			if (this.調教UI.Focus == this.対象 && mb == MouseButtons.Left && this.押し付け && this.Is押付)
			{
				this.調教UI.Action(cd.c, アクション情報.接触, タイミング情報.終了, this.アイテム情報, 0, 1, false, false);
				Act.奴体力消費小();
				Act.主精力消費小();
				this.調教UI.放し();
				this.対象.Ele.角度C = 0.0;
				this.Is押付 = false;
				if (this.調教UI.IsHitCha(ref cd))
				{
					this.押付時(ref cd);
					return;
				}
				this.待機時1();
			}
		}

		public void Leave(ref MouseButtons mb, ref Vector2D cp, ref Color hc)
		{
		}

		public void Wheel(ref MouseButtons mb, ref Vector2D cp, ref int dt, ref Color hc, ref 接触D cd)
		{
			if (this.調教UI.Focus == this.対象 && this.振動機能)
			{
				this.強さ = (this.強さ + dt.Sign()).LimitM(1, 3);
				if (this.回転機能)
				{
					this.回転モ\u30FCション.BaseSpeed = 10.0 * base.強度;
				}
				if (!Sta.GameData.ガイド)
				{
					this.ip.SubInfoIm = "Wh:" + tex.強さL + this.強さ;
					return;
				}
				if (this.Is挿入)
				{
					if (Sta.GameData.ガイド)
					{
						if (this.挿入箇所 == 接触.口)
						{
							this.ip.SubInfoIm = tex.口腔 + this.挿入中0();
							return;
						}
						if (this.挿入箇所 == 接触.肛)
						{
							this.ip.SubInfoIm = tex.肛門 + this.挿入中0();
							return;
						}
						if (this.挿入箇所 == 接触.膣)
						{
							this.ip.SubInfoIm = tex.膣腔 + this.挿入中0();
							return;
						}
						if (this.挿入箇所 == 接触.糸)
						{
							this.ip.SubInfoIm = tex.出糸 + this.挿入中0();
							return;
						}
					}
				}
				else
				{
					this.押付時(ref cd);
				}
			}
		}

		public 挿入処理(調教UI 調教UI, CM 対象)
		{
			挿入処理.<>c__DisplayClass116_0 CS$<>8__locals1 = new 挿入処理.<>c__DisplayClass116_0();
			CS$<>8__locals1.対象 = 対象;
			CS$<>8__locals1.調教UI = 調教UI;
			base..ctor(CS$<>8__locals1.調教UI, CS$<>8__locals1.対象);
			CS$<>8__locals1.<>4__this = this;
			this.振動機能 = (!(CS$<>8__locals1.対象.Ele is ペニス) && !(CS$<>8__locals1.対象.Ele is マウス) && !(CS$<>8__locals1.対象.Ele is ハンド) && !(CS$<>8__locals1.対象.Ele is パ\u30FCル));
			if (this.振動機能)
			{
				double d = 0.0005;
				if (CS$<>8__locals1.対象.Ele is ロ\u30FCタ)
				{
					d *= 1.0;
				}
				else if (CS$<>8__locals1.対象.Ele is バイブ_ディル)
				{
					d *= 1.1;
				}
				else if (CS$<>8__locals1.対象.Ele is バイブ_コモン)
				{
					d *= 1.2;
				}
				else if (CS$<>8__locals1.対象.Ele is バイブ_ドリル)
				{
					d *= 1.2;
				}
				else if (CS$<>8__locals1.対象.Ele is バイブ_アナル)
				{
					d *= 1.1;
				}
				else if (CS$<>8__locals1.対象.Ele is バイブ_デンマ)
				{
					d *= 1.5;
				}
				Vector2D p = Dat.Vec2DZero;
				bool f = !(CS$<>8__locals1.対象.Ele is ロ\u30FCタ);
				bool v = CS$<>8__locals1.対象.Ele is バイブ_ディル || CS$<>8__locals1.対象.Ele is バイブ_コモン || CS$<>8__locals1.対象.Ele is バイブ_ドリル || CS$<>8__locals1.対象.Ele is バイブ_アナル || CS$<>8__locals1.対象.Ele is バイブ_デンマ;
				Mot mot = new Mot(-1.0, 1.0);
				mot.BaseSpeed = double.MaxValue;
				mot.Staing = delegate(Mot m)
				{
				};
				mot.Runing = delegate(Mot m)
				{
					p.X = m.Value * d * CS$<>8__locals1.<>4__this.強度;
					if (v)
					{
						CS$<>8__locals1.対象.Ele.位置C = p.MulX(0.5);
						CS$<>8__locals1.対象.Ele.本体.Current.EnumAllPar().First((Par e) => e.Tag.Contains("ヘッド")).PositionCont = p;
					}
					else
					{
						CS$<>8__locals1.対象.Ele.位置C = p;
					}
					if (f && CS$<>8__locals1.<>4__this.Is挿入)
					{
						if (CS$<>8__locals1.<>4__this.dy > 3)
						{
							p.X *= 0.5;
							CS$<>8__locals1.<>4__this.Bod.断面.位置C = p;
						}
						else if (CS$<>8__locals1.<>4__this.dy > 2)
						{
							p.X *= 0.25;
							CS$<>8__locals1.<>4__this.Bod.断面.位置C = p;
						}
					}
					if (CS$<>8__locals1.<>4__this.Is挿入)
					{
						CS$<>8__locals1.調教UI.Action(CS$<>8__locals1.<>4__this.挿入箇所, アクション情報.挿入, タイミング情報.継続, CS$<>8__locals1.<>4__this.アイテム情報, CS$<>8__locals1.対象.Ele.Yi, CS$<>8__locals1.<>4__this.強さ, true, false);
						Act.奴体力消費小();
					}
					else if (CS$<>8__locals1.<>4__this.Is押付 && CS$<>8__locals1.調教UI.押し状態)
					{
						CS$<>8__locals1.調教UI.Action(CS$<>8__locals1.<>4__this.cd.c, アクション情報.擽り, タイミング情報.継続, CS$<>8__locals1.<>4__this.アイテム情報, 0, CS$<>8__locals1.<>4__this.強さ, true, false);
						Act.奴体力消費小();
					}
					CS$<>8__locals1.<>4__this.振動_();
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
					foreach (Par par in CS$<>8__locals1.対象.Ele.本体.EnumAllPar())
					{
						par.PositionCont = Dat.Vec2DZero;
					}
					CS$<>8__locals1.<>4__this.Bod.断面.位置C = Dat.Vec2DZero;
				};
				this.振動モ\u30FCション = mot;
				CS$<>8__locals1.調教UI.Mots.Add(this.振動モ\u30FCション.GetHashCode().ToString(), this.振動モ\u30FCション);
			}
			this.回転機能 = (CS$<>8__locals1.対象.Ele is バイブ_ドリル);
			if (this.回転機能)
			{
				Mot mot2 = new Mot(0.0, 1.0);
				mot2.BaseSpeed = 10.0 * base.強度;
				mot2.Staing = delegate(Mot m)
				{
					CS$<>8__locals1.対象.Ele.Xv = 0.0;
				};
				mot2.Runing = delegate(Mot m)
				{
					CS$<>8__locals1.対象.Ele.Xv = m.Value;
					CS$<>8__locals1.対象.Ele.本体.JoinPA();
					if (CS$<>8__locals1.<>4__this.Is挿入)
					{
						CS$<>8__locals1.調教UI.Action(CS$<>8__locals1.<>4__this.挿入箇所, アクション情報.挿入, タイミング情報.継続, CS$<>8__locals1.<>4__this.アイテム情報, CS$<>8__locals1.対象.Ele.Yi, CS$<>8__locals1.<>4__this.強さ, true, false);
						Act.奴体力消費小();
					}
					else if (CS$<>8__locals1.<>4__this.Is押付 && CS$<>8__locals1.調教UI.押し状態)
					{
						CS$<>8__locals1.調教UI.Action(CS$<>8__locals1.<>4__this.cd.c, アクション情報.擽り, タイミング情報.継続, CS$<>8__locals1.<>4__this.アイテム情報, 0, CS$<>8__locals1.<>4__this.強さ, true, false);
						Act.奴体力消費小();
					}
					CS$<>8__locals1.<>4__this.振動_();
				};
				mot2.Reaing = delegate(Mot m)
				{
					m.ResetValue();
				};
				mot2.Rouing = delegate(Mot m)
				{
				};
				mot2.Ending = delegate(Mot m)
				{
					m.ResetValue();
					CS$<>8__locals1.対象.Ele.Xv = 0.0;
				};
				this.回転モ\u30FCション = mot2;
				CS$<>8__locals1.調教UI.Mots.Add(this.回転モ\u30FCション.GetHashCode().ToString(), this.回転モ\u30FCション);
			}
			Mot mot3 = new Mot(0.0, 1.0);
			mot3.BaseSpeed = 1.0;
			mot3.Staing = delegate(Mot m)
			{
			};
			mot3.Runing = delegate(Mot m)
			{
				CS$<>8__locals1.<>4__this.Insert = (-0.01 - 0.04 * CS$<>8__locals1.<>4__this.Insert.Inverse()) * CS$<>8__locals1.<>4__this.排出;
				if (CS$<>8__locals1.<>4__this.Insert == 0.0)
				{
					CS$<>8__locals1.調教UI.Action(CS$<>8__locals1.<>4__this.挿入箇所, アクション情報.挿入, タイミング情報.終了, CS$<>8__locals1.<>4__this.アイテム情報, 0, 1, false, false);
					Act.奴体力消費小();
					接触 接触 = CS$<>8__locals1.<>4__this.挿入箇所;
					if (接触 != 接触.口)
					{
						switch (接触)
						{
						case 接触.膣:
							CS$<>8__locals1.<>4__this.膣終了();
							break;
						case 接触.肛:
							CS$<>8__locals1.<>4__this.肛終了();
							break;
						case 接触.糸:
							CS$<>8__locals1.<>4__this.糸終了();
							break;
						}
					}
					else
					{
						CS$<>8__locals1.<>4__this.口終了();
					}
					CS$<>8__locals1.<>4__this.解除();
					CS$<>8__locals1.対象.Ele.濃度 = 0.5;
					CS$<>8__locals1.対象.StaShow = true;
					CS$<>8__locals1.対象.使用状態 = 使用状態.待機;
					CS$<>8__locals1.対象.Ele.右 = false;
					CS$<>8__locals1.対象.Ele.位置B = CS$<>8__locals1.対象.bp;
					CS$<>8__locals1.対象.Ele.位置C = Dat.Vec2DZero;
					CS$<>8__locals1.対象.Ele.角度B = 0.0;
					CS$<>8__locals1.対象.Ele.角度C = 0.0;
					CS$<>8__locals1.対象.Ele.Xi = 0;
					CS$<>8__locals1.対象.Ele.Yi = 0;
					if (CS$<>8__locals1.<>4__this.振動機能)
					{
						CS$<>8__locals1.<>4__this.振動 = false;
					}
					if (CS$<>8__locals1.<>4__this.回転機能)
					{
						CS$<>8__locals1.<>4__this.回転 = false;
					}
					CS$<>8__locals1.<>4__this.選択 = false;
					CS$<>8__locals1.対象.Ele.尺度C = 1.09;
					CS$<>8__locals1.調教UI.SubFocus.Remove(CS$<>8__locals1.<>4__this);
					m.End();
				}
			};
			mot3.Reaing = delegate(Mot m)
			{
			};
			mot3.Rouing = delegate(Mot m)
			{
			};
			mot3.Ending = delegate(Mot m)
			{
				m.ResetValue();
			};
			this.抜け落ち = mot3;
			CS$<>8__locals1.調教UI.Mots.Add(this.抜け落ち.GetHashCode().ToString(), this.抜け落ち);
			this.押し付け = (this.振動機能 || CS$<>8__locals1.対象.Ele is ペニス);
			挿入処理.A断面獣最大i = 5;
			挿入処理.A断面人最大i = 挿入処理.A断面獣最大i - 1;
			double num = 1.0 / (double)CS$<>8__locals1.調教UI.アナル.本体.CountY;
			挿入処理.A通常獣最大v = num * (double)(挿入処理.A断面獣最大i - 1);
			挿入処理.A通常人最大v = num * (double)(挿入処理.A断面人最大i - 1);
			挿入処理.P断面獣最大i = 11;
			挿入処理.P断面人最大i = 挿入処理.P断面獣最大i - 1;
			double num2 = 1.0 / (double)CS$<>8__locals1.調教UI.パ\u30FCル.本体.CountY;
			挿入処理.P通常獣最大v = num2 * (double)(挿入処理.P断面獣最大i - 1);
			挿入処理.P通常人最大v = num2 * (double)(挿入処理.P断面人最大i - 1);
			this.psi = ((CS$<>8__locals1.対象.Ele is ロ\u30FCタ) ? 2 : 0);
			this.pn = (CS$<>8__locals1.対象.Ele is ペニス);
			MouseButtons mb_ = MouseButtons.None;
			Vector2D cp_ = default(Vector2D);
			Color hc_ = default(Color);
			Mot mot4 = new Mot(0.0, 1.0);
			mot4.BaseSpeed = 1.0 + 3.0 * Act.主興奮;
			mot4.Staing = delegate(Mot m)
			{
			};
			mot4.Runing = delegate(Mot m)
			{
				m.BaseSpeed = 1.0 + 3.0 * Act.主興奮;
				cp_ = new Vector2D(0.0, 100.0 * m.Value);
				CS$<>8__locals1.<>4__this.MoveO(ref mb_, ref cp_, ref hc_, ref CS$<>8__locals1.<>4__this.cd);
			};
			mot4.Reaing = delegate(Mot m)
			{
			};
			mot4.Rouing = delegate(Mot m)
			{
			};
			mot4.Ending = delegate(Mot m)
			{
			};
			this.挿抜モ\u30FCション = mot4;
			CS$<>8__locals1.調教UI.Mots.Add(this.挿抜モ\u30FCション.GetHashCode().ToString(), this.挿抜モ\u30FCション);
		}

		public void SetCha(Cha Cha)
		{
			this.Cha = Cha;
			this.Bod = Cha.Bod;
			挿入処理.性器単位v = 1.0 / (double)this.Bod.性器.本体.CountY;
			挿入処理.断面単位v = 1.0 / (double)this.Bod.断面.本体.CountY;
			挿入処理.断面単位v2 = 挿入処理.断面単位v * 2.0;
			挿入処理.断面単位v3 = 挿入処理.断面単位v * 3.0;
		}

		public new void Reset()
		{
			if (this.Is挿入)
			{
				接触 接触 = this.挿入箇所;
				if (接触 != 接触.口)
				{
					switch (接触)
					{
					case 接触.膣:
						this.膣終了();
						break;
					case 接触.肛:
						this.肛終了();
						break;
					case 接触.糸:
						this.糸終了();
						break;
					}
				}
				else
				{
					this.口終了();
				}
				this.解除();
				this.対象.Ele.濃度 = 0.5;
				this.対象.StaShow = true;
				this.対象.使用状態 = 使用状態.待機;
				this.対象.Ele.右 = false;
				this.対象.Ele.位置B = this.対象.bp;
				this.対象.Ele.位置C = Dat.Vec2DZero;
				this.対象.Ele.角度B = 0.0;
				this.対象.Ele.角度C = 0.0;
				this.対象.Ele.Xi = 0;
				this.対象.Ele.Yi = 0;
				if (this.振動機能)
				{
					this.振動 = false;
				}
				if (this.回転機能)
				{
					this.回転 = false;
				}
				this.選択 = false;
				this.対象.Ele.尺度C = 1.09;
				this.調教UI.SubFocus.Remove(this);
			}
			base.Reset();
			this.CP挿入.Reset();
			this.CP振動.Reset();
			this.挿入箇所 = 接触.none;
			this.くぱぁ = 0.0;
			this.Is押付 = false;
			this.Is挿入 = false;
			Mot 振動モ_u30FCション = this.振動モ\u30FCション;
			if (振動モ_u30FCション != null)
			{
				振動モ_u30FCション.End();
			}
			this.振動 = false;
			Mot 回転モ_u30FCション = this.回転モ\u30FCション;
			if (回転モ_u30FCション != null)
			{
				回転モ_u30FCション.End();
			}
			this.回転 = false;
			Mot mot = this.抜け落ち;
			if (mot != null)
			{
				mot.End();
			}
			Mot 挿抜モ_u30FCション = this.挿抜モ\u30FCション;
			if (挿抜モ_u30FCション != null)
			{
				挿抜モ_u30FCション.End();
			}
			this.挿抜フラグ = false;
			this.口排出度 = 1.0;
			this.膣排出度 = 1.0;
			this.肛排出度 = 1.0;
			this.糸排出度 = 1.0;
			this.dv = 0.0;
			this.dy = 0;
			this.口挿抜 = 0.0;
			this.膣挿抜 = 0.0;
			this.肛挿抜 = 0.0;
			this.糸挿抜 = 0.0;
			this.vr = default(Vector2D);
			this.or = default(Vector2D);
			this.xr = 0.0;
			this.yr = 0.0;
			this.a = 0.0;
			this.y0 = 0.0;
			this.p0 = null;
			this.py = null;
			this.bp = default(Vector2D);
			this.解除();
			this.oi = 0.0;
			this.cd = default(接触D);
			this.v = default(Vector2D);
			this.o = default(Vector2D);
			this.x = 0.0;
			this.y = 0.0;
		}

		public アイテム情報 アイテム情報
		{
			get
			{
				if (this.対象.Ele is ハンド)
				{
					return アイテム情報.ハンド;
				}
				if (this.対象.Ele is マウス)
				{
					return アイテム情報.マウス;
				}
				if (this.対象.Ele is ペニス)
				{
					return アイテム情報.ペニス;
				}
				if (this.対象.Ele is バイブ_ディル)
				{
					return アイテム情報.ディル;
				}
				if (this.対象.Ele is バイブ_コモン)
				{
					return アイテム情報.コモン;
				}
				if (this.対象.Ele is バイブ_ドリル)
				{
					return アイテム情報.ドリル;
				}
				if (this.対象.Ele is バイブ_デンマ)
				{
					return アイテム情報.デンマ;
				}
				if (this.対象.Ele is バイブ_アナル)
				{
					return アイテム情報.アナル;
				}
				if (this.対象.Ele is ロ\u30FCタ)
				{
					return アイテム情報.ロ\u30FCタ;
				}
				if (this.対象.Ele is パ\u30FCル)
				{
					return アイテム情報.パ\u30FCル;
				}
				return アイテム情報.none;
			}
		}

		public const bool 口置き = true;

		public ConstProp CP挿入 = new ConstProp();

		public ConstProp CP振動 = new ConstProp();

		private const double mi = 0.35;

		private 接触 挿入箇所;

		private double くぱぁ;

		private static int P断面人最大i;

		private static int A断面人最大i;

		private static int P断面獣最大i;

		private static int A断面獣最大i;

		private static double 性器単位v;

		private static double A通常人最大v;

		private static double P通常人最大v;

		private static double A通常獣最大v;

		private static double P通常獣最大v;

		private static double 断面単位v;

		private static double 断面単位v2;

		private static double 断面単位v3;

		public bool Is押付;

		public bool Is挿入;

		public bool 振動機能;

		public bool 回転機能;

		private bool 押し付け;

		private Mot 振動モ\u30FCション;

		private Mot 回転モ\u30FCション;

		public Mot 抜け落ち;

		public double 口排出度 = 1.0;

		public double 膣排出度 = 1.0;

		public double 肛排出度 = 1.0;

		public double 糸排出度 = 1.0;

		public Mot 挿抜モ\u30FCション;

		public bool 挿抜フラグ;

		private double dv;

		private int dy;

		private Vector2D vr;

		private Vector2D or;

		private double xr;

		private double yr;

		private double a;

		private double y0;

		private Par p0;

		private Par py;

		private Vector2D bp;

		private int psi;

		private bool pn;

		private double oi;

		private 接触D cd;

		private Vector2D v;

		private Vector2D o;

		private double x;

		private double y;
	}
}
