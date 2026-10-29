using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 前翅_蝶 : 前翅
	{
		public 前翅_蝶(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 前翅_蝶D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.肢左["前翅"][2]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0]["前翅"].ToPars();
			this.X0Y0_前翅_前翅 = pars["前翅"].ToPar();
			Pars pars2 = pars["水青"].ToPars();
			this.X0Y0_前翅_水青_柄 = pars2["柄"].ToPar();
			this.X0Y0_前翅_水青_縁柄 = pars2["縁柄"].ToPar();
			this.X0Y0_前翅_水青_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_前翅_水青_紋2 = pars2["紋2"].ToPar();
			pars2 = pars["揚羽"].ToPars();
			this.X0Y0_前翅_揚羽_柄1 = pars2["柄1"].ToPar();
			this.X0Y0_前翅_揚羽_柄2 = pars2["柄2"].ToPar();
			this.X0Y0_前翅_揚羽_柄3 = pars2["柄3"].ToPar();
			this.X0Y0_前翅_揚羽_柄4 = pars2["柄4"].ToPar();
			this.X0Y0_前翅_揚羽_柄5 = pars2["柄5"].ToPar();
			this.X0Y0_前翅_揚羽_柄6 = pars2["柄6"].ToPar();
			this.X0Y0_前翅_揚羽_柄7 = pars2["柄7"].ToPar();
			this.X0Y0_前翅_揚羽_柄8 = pars2["柄8"].ToPar();
			this.X0Y0_前翅_揚羽_柄9 = pars2["柄9"].ToPar();
			this.X0Y0_前翅_揚羽_柄10 = pars2["柄10"].ToPar();
			this.X0Y0_前翅_揚羽_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_前翅_揚羽_紋2 = pars2["紋2"].ToPar();
			this.X0Y0_前翅_揚羽_紋3 = pars2["紋3"].ToPar();
			this.X0Y0_前翅_揚羽_紋4 = pars2["紋4"].ToPar();
			this.X0Y0_前翅_揚羽_紋5 = pars2["紋5"].ToPar();
			this.X0Y0_前翅_揚羽_紋6 = pars2["紋6"].ToPar();
			pars = this.本体[0][1]["前翅"].ToPars();
			this.X0Y1_前翅_前翅 = pars["前翅"].ToPar();
			pars2 = pars["水青"].ToPars();
			this.X0Y1_前翅_水青_柄 = pars2["柄"].ToPar();
			this.X0Y1_前翅_水青_縁柄 = pars2["縁柄"].ToPar();
			this.X0Y1_前翅_水青_紋1 = pars2["紋1"].ToPar();
			this.X0Y1_前翅_水青_紋2 = pars2["紋2"].ToPar();
			pars2 = pars["揚羽"].ToPars();
			this.X0Y1_前翅_揚羽_柄1 = pars2["柄1"].ToPar();
			this.X0Y1_前翅_揚羽_柄2 = pars2["柄2"].ToPar();
			this.X0Y1_前翅_揚羽_柄3 = pars2["柄3"].ToPar();
			this.X0Y1_前翅_揚羽_柄4 = pars2["柄4"].ToPar();
			this.X0Y1_前翅_揚羽_柄5 = pars2["柄5"].ToPar();
			this.X0Y1_前翅_揚羽_柄6 = pars2["柄6"].ToPar();
			this.X0Y1_前翅_揚羽_柄7 = pars2["柄7"].ToPar();
			this.X0Y1_前翅_揚羽_柄8 = pars2["柄8"].ToPar();
			this.X0Y1_前翅_揚羽_柄9 = pars2["柄9"].ToPar();
			this.X0Y1_前翅_揚羽_柄10 = pars2["柄10"].ToPar();
			this.X0Y1_前翅_揚羽_紋1 = pars2["紋1"].ToPar();
			this.X0Y1_前翅_揚羽_紋2 = pars2["紋2"].ToPar();
			this.X0Y1_前翅_揚羽_紋3 = pars2["紋3"].ToPar();
			this.X0Y1_前翅_揚羽_紋4 = pars2["紋4"].ToPar();
			this.X0Y1_前翅_揚羽_紋5 = pars2["紋5"].ToPar();
			this.X0Y1_前翅_揚羽_紋6 = pars2["紋6"].ToPar();
			this.Xasix = false;
			this.本体.SetJoints();
			this.接続根 = new JointD(this.本体);
			this.右 = e.右;
			this.反転X = e.反転X;
			this.反転Y = e.反転Y;
			this.基準C = e.基準C;
			this.位置C = e.位置C;
			this.角度B = e.角度B;
			this.角度C = e.角度C;
			this.尺度B = e.尺度B;
			this.尺度C = e.尺度C;
			this.尺度XB = e.尺度XB;
			this.尺度XC = e.尺度XC;
			this.尺度YB = e.尺度YB;
			this.尺度YC = e.尺度YC;
			this.肥大 = e.肥大;
			this.身長 = e.身長;
			this.Xv = e.Xv;
			this.Yv = e.Yv;
			this.Xi = e.Xi;
			this.Yi = e.Yi;
			this.サイズ = e.サイズ;
			this.サイズX = e.サイズX;
			this.サイズY = e.サイズY;
			this.前翅_前翅_表示 = e.前翅_前翅_表示;
			this.前翅_水青_柄_表示 = e.前翅_水青_柄_表示;
			this.前翅_水青_縁柄_表示 = e.前翅_水青_縁柄_表示;
			this.前翅_水青_紋1_表示 = e.前翅_水青_紋1_表示;
			this.前翅_水青_紋2_表示 = e.前翅_水青_紋2_表示;
			this.前翅_揚羽_柄1_表示 = e.前翅_揚羽_柄1_表示;
			this.前翅_揚羽_柄2_表示 = e.前翅_揚羽_柄2_表示;
			this.前翅_揚羽_柄3_表示 = e.前翅_揚羽_柄3_表示;
			this.前翅_揚羽_柄4_表示 = e.前翅_揚羽_柄4_表示;
			this.前翅_揚羽_柄5_表示 = e.前翅_揚羽_柄5_表示;
			this.前翅_揚羽_柄6_表示 = e.前翅_揚羽_柄6_表示;
			this.前翅_揚羽_柄7_表示 = e.前翅_揚羽_柄7_表示;
			this.前翅_揚羽_柄8_表示 = e.前翅_揚羽_柄8_表示;
			this.前翅_揚羽_柄9_表示 = e.前翅_揚羽_柄9_表示;
			this.前翅_揚羽_柄10_表示 = e.前翅_揚羽_柄10_表示;
			this.前翅_揚羽_紋1_表示 = e.前翅_揚羽_紋1_表示;
			this.前翅_揚羽_紋2_表示 = e.前翅_揚羽_紋2_表示;
			this.前翅_揚羽_紋3_表示 = e.前翅_揚羽_紋3_表示;
			this.前翅_揚羽_紋4_表示 = e.前翅_揚羽_紋4_表示;
			this.前翅_揚羽_紋5_表示 = e.前翅_揚羽_紋5_表示;
			this.前翅_揚羽_紋6_表示 = e.前翅_揚羽_紋6_表示;
			this.水青 = e.水青;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_前翅_前翅CP = new ColorP(this.X0Y0_前翅_前翅, this.前翅_前翅CD, DisUnit, true);
			this.X0Y0_前翅_水青_柄CP = new ColorP(this.X0Y0_前翅_水青_柄, this.前翅_水青_柄CD, DisUnit, true);
			this.X0Y0_前翅_水青_縁柄CP = new ColorP(this.X0Y0_前翅_水青_縁柄, this.前翅_水青_縁柄CD, DisUnit, true);
			this.X0Y0_前翅_水青_紋1CP = new ColorP(this.X0Y0_前翅_水青_紋1, this.前翅_水青_紋1CD, DisUnit, true);
			this.X0Y0_前翅_水青_紋2CP = new ColorP(this.X0Y0_前翅_水青_紋2, this.前翅_水青_紋2CD, DisUnit, true);
			this.X0Y0_前翅_揚羽_柄1CP = new ColorP(this.X0Y0_前翅_揚羽_柄1, this.前翅_揚羽_柄1CD, DisUnit, true);
			this.X0Y0_前翅_揚羽_柄2CP = new ColorP(this.X0Y0_前翅_揚羽_柄2, this.前翅_揚羽_柄2CD, DisUnit, true);
			this.X0Y0_前翅_揚羽_柄3CP = new ColorP(this.X0Y0_前翅_揚羽_柄3, this.前翅_揚羽_柄3CD, DisUnit, true);
			this.X0Y0_前翅_揚羽_柄4CP = new ColorP(this.X0Y0_前翅_揚羽_柄4, this.前翅_揚羽_柄4CD, DisUnit, true);
			this.X0Y0_前翅_揚羽_柄5CP = new ColorP(this.X0Y0_前翅_揚羽_柄5, this.前翅_揚羽_柄5CD, DisUnit, true);
			this.X0Y0_前翅_揚羽_柄6CP = new ColorP(this.X0Y0_前翅_揚羽_柄6, this.前翅_揚羽_柄6CD, DisUnit, true);
			this.X0Y0_前翅_揚羽_柄7CP = new ColorP(this.X0Y0_前翅_揚羽_柄7, this.前翅_揚羽_柄7CD, DisUnit, true);
			this.X0Y0_前翅_揚羽_柄8CP = new ColorP(this.X0Y0_前翅_揚羽_柄8, this.前翅_揚羽_柄8CD, DisUnit, true);
			this.X0Y0_前翅_揚羽_柄9CP = new ColorP(this.X0Y0_前翅_揚羽_柄9, this.前翅_揚羽_柄9CD, DisUnit, true);
			this.X0Y0_前翅_揚羽_柄10CP = new ColorP(this.X0Y0_前翅_揚羽_柄10, this.前翅_揚羽_柄10CD, DisUnit, true);
			this.X0Y0_前翅_揚羽_紋1CP = new ColorP(this.X0Y0_前翅_揚羽_紋1, this.前翅_揚羽_紋1CD, DisUnit, true);
			this.X0Y0_前翅_揚羽_紋2CP = new ColorP(this.X0Y0_前翅_揚羽_紋2, this.前翅_揚羽_紋2CD, DisUnit, true);
			this.X0Y0_前翅_揚羽_紋3CP = new ColorP(this.X0Y0_前翅_揚羽_紋3, this.前翅_揚羽_紋3CD, DisUnit, true);
			this.X0Y0_前翅_揚羽_紋4CP = new ColorP(this.X0Y0_前翅_揚羽_紋4, this.前翅_揚羽_紋4CD, DisUnit, true);
			this.X0Y0_前翅_揚羽_紋5CP = new ColorP(this.X0Y0_前翅_揚羽_紋5, this.前翅_揚羽_紋5CD, DisUnit, true);
			this.X0Y0_前翅_揚羽_紋6CP = new ColorP(this.X0Y0_前翅_揚羽_紋6, this.前翅_揚羽_紋6CD, DisUnit, true);
			this.X0Y1_前翅_前翅CP = new ColorP(this.X0Y1_前翅_前翅, this.前翅_前翅CD, DisUnit, true);
			this.X0Y1_前翅_水青_柄CP = new ColorP(this.X0Y1_前翅_水青_柄, this.前翅_水青_柄CD, DisUnit, true);
			this.X0Y1_前翅_水青_縁柄CP = new ColorP(this.X0Y1_前翅_水青_縁柄, this.前翅_水青_縁柄CD, DisUnit, true);
			this.X0Y1_前翅_水青_紋1CP = new ColorP(this.X0Y1_前翅_水青_紋1, this.前翅_水青_紋1CD, DisUnit, true);
			this.X0Y1_前翅_水青_紋2CP = new ColorP(this.X0Y1_前翅_水青_紋2, this.前翅_水青_紋2CD, DisUnit, true);
			this.X0Y1_前翅_揚羽_柄1CP = new ColorP(this.X0Y1_前翅_揚羽_柄1, this.前翅_揚羽_柄1CD, DisUnit, true);
			this.X0Y1_前翅_揚羽_柄2CP = new ColorP(this.X0Y1_前翅_揚羽_柄2, this.前翅_揚羽_柄2CD, DisUnit, true);
			this.X0Y1_前翅_揚羽_柄3CP = new ColorP(this.X0Y1_前翅_揚羽_柄3, this.前翅_揚羽_柄3CD, DisUnit, true);
			this.X0Y1_前翅_揚羽_柄4CP = new ColorP(this.X0Y1_前翅_揚羽_柄4, this.前翅_揚羽_柄4CD, DisUnit, true);
			this.X0Y1_前翅_揚羽_柄5CP = new ColorP(this.X0Y1_前翅_揚羽_柄5, this.前翅_揚羽_柄5CD, DisUnit, true);
			this.X0Y1_前翅_揚羽_柄6CP = new ColorP(this.X0Y1_前翅_揚羽_柄6, this.前翅_揚羽_柄6CD, DisUnit, true);
			this.X0Y1_前翅_揚羽_柄7CP = new ColorP(this.X0Y1_前翅_揚羽_柄7, this.前翅_揚羽_柄7CD, DisUnit, true);
			this.X0Y1_前翅_揚羽_柄8CP = new ColorP(this.X0Y1_前翅_揚羽_柄8, this.前翅_揚羽_柄8CD, DisUnit, true);
			this.X0Y1_前翅_揚羽_柄9CP = new ColorP(this.X0Y1_前翅_揚羽_柄9, this.前翅_揚羽_柄9CD, DisUnit, true);
			this.X0Y1_前翅_揚羽_柄10CP = new ColorP(this.X0Y1_前翅_揚羽_柄10, this.前翅_揚羽_柄10CD, DisUnit, true);
			this.X0Y1_前翅_揚羽_紋1CP = new ColorP(this.X0Y1_前翅_揚羽_紋1, this.前翅_揚羽_紋1CD, DisUnit, true);
			this.X0Y1_前翅_揚羽_紋2CP = new ColorP(this.X0Y1_前翅_揚羽_紋2, this.前翅_揚羽_紋2CD, DisUnit, true);
			this.X0Y1_前翅_揚羽_紋3CP = new ColorP(this.X0Y1_前翅_揚羽_紋3, this.前翅_揚羽_紋3CD, DisUnit, true);
			this.X0Y1_前翅_揚羽_紋4CP = new ColorP(this.X0Y1_前翅_揚羽_紋4, this.前翅_揚羽_紋4CD, DisUnit, true);
			this.X0Y1_前翅_揚羽_紋5CP = new ColorP(this.X0Y1_前翅_揚羽_紋5, this.前翅_揚羽_紋5CD, DisUnit, true);
			this.X0Y1_前翅_揚羽_紋6CP = new ColorP(this.X0Y1_前翅_揚羽_紋6, this.前翅_揚羽_紋6CD, DisUnit, true);
			this.濃度 = e.濃度;
		}

		public override bool 欠損
		{
			get
			{
				return this.欠損_;
			}
			set
			{
				this.欠損_ = value;
				this.本体.IndexY = (this.欠損_ ? 1 : 0);
			}
		}

		public override bool 筋肉
		{
			get
			{
				return this.筋肉_;
			}
			set
			{
				this.筋肉_ = value;
			}
		}

		public override bool 拘束
		{
			get
			{
				return this.拘束_;
			}
			set
			{
				this.拘束_ = value;
			}
		}

		public bool 前翅_前翅_表示
		{
			get
			{
				return this.X0Y0_前翅_前翅.Dra;
			}
			set
			{
				this.X0Y0_前翅_前翅.Dra = value;
				this.X0Y1_前翅_前翅.Dra = value;
				this.X0Y0_前翅_前翅.Hit = value;
				this.X0Y1_前翅_前翅.Hit = value;
			}
		}

		public bool 前翅_水青_柄_表示
		{
			get
			{
				return this.X0Y0_前翅_水青_柄.Dra;
			}
			set
			{
				this.X0Y0_前翅_水青_柄.Dra = value;
				this.X0Y1_前翅_水青_柄.Dra = value;
				this.X0Y0_前翅_水青_柄.Hit = value;
				this.X0Y1_前翅_水青_柄.Hit = value;
			}
		}

		public bool 前翅_水青_縁柄_表示
		{
			get
			{
				return this.X0Y0_前翅_水青_縁柄.Dra;
			}
			set
			{
				this.X0Y0_前翅_水青_縁柄.Dra = value;
				this.X0Y1_前翅_水青_縁柄.Dra = value;
				this.X0Y0_前翅_水青_縁柄.Hit = value;
				this.X0Y1_前翅_水青_縁柄.Hit = value;
			}
		}

		public bool 前翅_水青_紋1_表示
		{
			get
			{
				return this.X0Y0_前翅_水青_紋1.Dra;
			}
			set
			{
				this.X0Y0_前翅_水青_紋1.Dra = value;
				this.X0Y1_前翅_水青_紋1.Dra = value;
				this.X0Y0_前翅_水青_紋1.Hit = value;
				this.X0Y1_前翅_水青_紋1.Hit = value;
			}
		}

		public bool 前翅_水青_紋2_表示
		{
			get
			{
				return this.X0Y0_前翅_水青_紋2.Dra;
			}
			set
			{
				this.X0Y0_前翅_水青_紋2.Dra = value;
				this.X0Y1_前翅_水青_紋2.Dra = value;
				this.X0Y0_前翅_水青_紋2.Hit = value;
				this.X0Y1_前翅_水青_紋2.Hit = value;
			}
		}

		public bool 前翅_揚羽_柄1_表示
		{
			get
			{
				return this.X0Y0_前翅_揚羽_柄1.Dra;
			}
			set
			{
				this.X0Y0_前翅_揚羽_柄1.Dra = value;
				this.X0Y1_前翅_揚羽_柄1.Dra = value;
				this.X0Y0_前翅_揚羽_柄1.Hit = value;
				this.X0Y1_前翅_揚羽_柄1.Hit = value;
			}
		}

		public bool 前翅_揚羽_柄2_表示
		{
			get
			{
				return this.X0Y0_前翅_揚羽_柄2.Dra;
			}
			set
			{
				this.X0Y0_前翅_揚羽_柄2.Dra = value;
				this.X0Y1_前翅_揚羽_柄2.Dra = value;
				this.X0Y0_前翅_揚羽_柄2.Hit = value;
				this.X0Y1_前翅_揚羽_柄2.Hit = value;
			}
		}

		public bool 前翅_揚羽_柄3_表示
		{
			get
			{
				return this.X0Y0_前翅_揚羽_柄3.Dra;
			}
			set
			{
				this.X0Y0_前翅_揚羽_柄3.Dra = value;
				this.X0Y1_前翅_揚羽_柄3.Dra = value;
				this.X0Y0_前翅_揚羽_柄3.Hit = value;
				this.X0Y1_前翅_揚羽_柄3.Hit = value;
			}
		}

		public bool 前翅_揚羽_柄4_表示
		{
			get
			{
				return this.X0Y0_前翅_揚羽_柄4.Dra;
			}
			set
			{
				this.X0Y0_前翅_揚羽_柄4.Dra = value;
				this.X0Y1_前翅_揚羽_柄4.Dra = value;
				this.X0Y0_前翅_揚羽_柄4.Hit = value;
				this.X0Y1_前翅_揚羽_柄4.Hit = value;
			}
		}

		public bool 前翅_揚羽_柄5_表示
		{
			get
			{
				return this.X0Y0_前翅_揚羽_柄5.Dra;
			}
			set
			{
				this.X0Y0_前翅_揚羽_柄5.Dra = value;
				this.X0Y1_前翅_揚羽_柄5.Dra = value;
				this.X0Y0_前翅_揚羽_柄5.Hit = value;
				this.X0Y1_前翅_揚羽_柄5.Hit = value;
			}
		}

		public bool 前翅_揚羽_柄6_表示
		{
			get
			{
				return this.X0Y0_前翅_揚羽_柄6.Dra;
			}
			set
			{
				this.X0Y0_前翅_揚羽_柄6.Dra = value;
				this.X0Y1_前翅_揚羽_柄6.Dra = value;
				this.X0Y0_前翅_揚羽_柄6.Hit = value;
				this.X0Y1_前翅_揚羽_柄6.Hit = value;
			}
		}

		public bool 前翅_揚羽_柄7_表示
		{
			get
			{
				return this.X0Y0_前翅_揚羽_柄7.Dra;
			}
			set
			{
				this.X0Y0_前翅_揚羽_柄7.Dra = value;
				this.X0Y1_前翅_揚羽_柄7.Dra = value;
				this.X0Y0_前翅_揚羽_柄7.Hit = value;
				this.X0Y1_前翅_揚羽_柄7.Hit = value;
			}
		}

		public bool 前翅_揚羽_柄8_表示
		{
			get
			{
				return this.X0Y0_前翅_揚羽_柄8.Dra;
			}
			set
			{
				this.X0Y0_前翅_揚羽_柄8.Dra = value;
				this.X0Y1_前翅_揚羽_柄8.Dra = value;
				this.X0Y0_前翅_揚羽_柄8.Hit = value;
				this.X0Y1_前翅_揚羽_柄8.Hit = value;
			}
		}

		public bool 前翅_揚羽_柄9_表示
		{
			get
			{
				return this.X0Y0_前翅_揚羽_柄9.Dra;
			}
			set
			{
				this.X0Y0_前翅_揚羽_柄9.Dra = value;
				this.X0Y1_前翅_揚羽_柄9.Dra = value;
				this.X0Y0_前翅_揚羽_柄9.Hit = value;
				this.X0Y1_前翅_揚羽_柄9.Hit = value;
			}
		}

		public bool 前翅_揚羽_柄10_表示
		{
			get
			{
				return this.X0Y0_前翅_揚羽_柄10.Dra;
			}
			set
			{
				this.X0Y0_前翅_揚羽_柄10.Dra = value;
				this.X0Y1_前翅_揚羽_柄10.Dra = value;
				this.X0Y0_前翅_揚羽_柄10.Hit = value;
				this.X0Y1_前翅_揚羽_柄10.Hit = value;
			}
		}

		public bool 前翅_揚羽_紋1_表示
		{
			get
			{
				return this.X0Y0_前翅_揚羽_紋1.Dra;
			}
			set
			{
				this.X0Y0_前翅_揚羽_紋1.Dra = value;
				this.X0Y1_前翅_揚羽_紋1.Dra = value;
				this.X0Y0_前翅_揚羽_紋1.Hit = value;
				this.X0Y1_前翅_揚羽_紋1.Hit = value;
			}
		}

		public bool 前翅_揚羽_紋2_表示
		{
			get
			{
				return this.X0Y0_前翅_揚羽_紋2.Dra;
			}
			set
			{
				this.X0Y0_前翅_揚羽_紋2.Dra = value;
				this.X0Y1_前翅_揚羽_紋2.Dra = value;
				this.X0Y0_前翅_揚羽_紋2.Hit = value;
				this.X0Y1_前翅_揚羽_紋2.Hit = value;
			}
		}

		public bool 前翅_揚羽_紋3_表示
		{
			get
			{
				return this.X0Y0_前翅_揚羽_紋3.Dra;
			}
			set
			{
				this.X0Y0_前翅_揚羽_紋3.Dra = value;
				this.X0Y1_前翅_揚羽_紋3.Dra = value;
				this.X0Y0_前翅_揚羽_紋3.Hit = value;
				this.X0Y1_前翅_揚羽_紋3.Hit = value;
			}
		}

		public bool 前翅_揚羽_紋4_表示
		{
			get
			{
				return this.X0Y0_前翅_揚羽_紋4.Dra;
			}
			set
			{
				this.X0Y0_前翅_揚羽_紋4.Dra = value;
				this.X0Y1_前翅_揚羽_紋4.Dra = value;
				this.X0Y0_前翅_揚羽_紋4.Hit = value;
				this.X0Y1_前翅_揚羽_紋4.Hit = value;
			}
		}

		public bool 前翅_揚羽_紋5_表示
		{
			get
			{
				return this.X0Y0_前翅_揚羽_紋5.Dra;
			}
			set
			{
				this.X0Y0_前翅_揚羽_紋5.Dra = value;
				this.X0Y1_前翅_揚羽_紋5.Dra = value;
				this.X0Y0_前翅_揚羽_紋5.Hit = value;
				this.X0Y1_前翅_揚羽_紋5.Hit = value;
			}
		}

		public bool 前翅_揚羽_紋6_表示
		{
			get
			{
				return this.X0Y0_前翅_揚羽_紋6.Dra;
			}
			set
			{
				this.X0Y0_前翅_揚羽_紋6.Dra = value;
				this.X0Y1_前翅_揚羽_紋6.Dra = value;
				this.X0Y0_前翅_揚羽_紋6.Hit = value;
				this.X0Y1_前翅_揚羽_紋6.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.前翅_前翅_表示;
			}
			set
			{
				this.前翅_前翅_表示 = value;
				this.前翅_水青_柄_表示 = value;
				this.前翅_水青_縁柄_表示 = value;
				this.前翅_水青_紋1_表示 = value;
				this.前翅_水青_紋2_表示 = value;
				this.前翅_揚羽_柄1_表示 = value;
				this.前翅_揚羽_柄2_表示 = value;
				this.前翅_揚羽_柄3_表示 = value;
				this.前翅_揚羽_柄4_表示 = value;
				this.前翅_揚羽_柄5_表示 = value;
				this.前翅_揚羽_柄6_表示 = value;
				this.前翅_揚羽_柄7_表示 = value;
				this.前翅_揚羽_柄8_表示 = value;
				this.前翅_揚羽_柄9_表示 = value;
				this.前翅_揚羽_柄10_表示 = value;
				this.前翅_揚羽_紋1_表示 = value;
				this.前翅_揚羽_紋2_表示 = value;
				this.前翅_揚羽_紋3_表示 = value;
				this.前翅_揚羽_紋4_表示 = value;
				this.前翅_揚羽_紋5_表示 = value;
				this.前翅_揚羽_紋6_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.前翅_前翅CD.不透明度;
			}
			set
			{
				this.前翅_前翅CD.不透明度 = value;
				this.前翅_水青_柄CD.不透明度 = value;
				this.前翅_水青_縁柄CD.不透明度 = value;
				this.前翅_水青_紋1CD.不透明度 = value;
				this.前翅_水青_紋2CD.不透明度 = value;
				this.前翅_揚羽_柄1CD.不透明度 = value;
				this.前翅_揚羽_柄2CD.不透明度 = value;
				this.前翅_揚羽_柄3CD.不透明度 = value;
				this.前翅_揚羽_柄4CD.不透明度 = value;
				this.前翅_揚羽_柄5CD.不透明度 = value;
				this.前翅_揚羽_柄6CD.不透明度 = value;
				this.前翅_揚羽_柄7CD.不透明度 = value;
				this.前翅_揚羽_柄8CD.不透明度 = value;
				this.前翅_揚羽_柄9CD.不透明度 = value;
				this.前翅_揚羽_柄10CD.不透明度 = value;
				this.前翅_揚羽_紋1CD.不透明度 = value;
				this.前翅_揚羽_紋2CD.不透明度 = value;
				this.前翅_揚羽_紋3CD.不透明度 = value;
				this.前翅_揚羽_紋4CD.不透明度 = value;
				this.前翅_揚羽_紋5CD.不透明度 = value;
				this.前翅_揚羽_紋6CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_前翅_前翅.AngleBase = num * 29.0;
			this.X0Y1_前翅_前翅.AngleBase = num * 29.0;
			this.本体.JoinPAall();
		}

		public bool 水青
		{
			get
			{
				return this.水青_;
			}
			set
			{
				this.水青_ = value;
				this.前翅_水青_柄_表示 = this.水青_;
				this.前翅_水青_縁柄_表示 = this.水青_;
				this.前翅_水青_紋1_表示 = this.水青_;
				this.前翅_水青_紋2_表示 = this.水青_;
				this.前翅_揚羽_柄1_表示 = !this.水青_;
				this.前翅_揚羽_柄2_表示 = !this.水青_;
				this.前翅_揚羽_柄3_表示 = !this.水青_;
				this.前翅_揚羽_柄4_表示 = !this.水青_;
				this.前翅_揚羽_柄5_表示 = !this.水青_;
				this.前翅_揚羽_柄6_表示 = !this.水青_;
				this.前翅_揚羽_柄7_表示 = !this.水青_;
				this.前翅_揚羽_柄8_表示 = !this.水青_;
				this.前翅_揚羽_柄9_表示 = !this.水青_;
				this.前翅_揚羽_柄10_表示 = !this.水青_;
				this.前翅_揚羽_紋1_表示 = !this.水青_;
				this.前翅_揚羽_紋2_表示 = !this.水青_;
				this.前翅_揚羽_紋3_表示 = !this.水青_;
				this.前翅_揚羽_紋4_表示 = !this.水青_;
				this.前翅_揚羽_紋5_表示 = !this.水青_;
				this.前翅_揚羽_紋6_表示 = !this.水青_;
			}
		}

		public override void 色更新()
		{
			if (this.本体.IndexY == 0)
			{
				this.X0Y0_前翅_前翅CP.Update();
				this.X0Y0_前翅_水青_柄CP.Update();
				this.X0Y0_前翅_水青_縁柄CP.Update();
				this.X0Y0_前翅_水青_紋1CP.Update();
				this.X0Y0_前翅_水青_紋2CP.Update();
				this.X0Y0_前翅_揚羽_柄1CP.Update();
				this.X0Y0_前翅_揚羽_柄2CP.Update();
				this.X0Y0_前翅_揚羽_柄3CP.Update();
				this.X0Y0_前翅_揚羽_柄4CP.Update();
				this.X0Y0_前翅_揚羽_柄5CP.Update();
				this.X0Y0_前翅_揚羽_柄6CP.Update();
				this.X0Y0_前翅_揚羽_柄7CP.Update();
				this.X0Y0_前翅_揚羽_柄8CP.Update();
				this.X0Y0_前翅_揚羽_柄9CP.Update();
				this.X0Y0_前翅_揚羽_柄10CP.Update();
				this.X0Y0_前翅_揚羽_紋1CP.Update();
				this.X0Y0_前翅_揚羽_紋2CP.Update();
				this.X0Y0_前翅_揚羽_紋3CP.Update();
				this.X0Y0_前翅_揚羽_紋4CP.Update();
				this.X0Y0_前翅_揚羽_紋5CP.Update();
				this.X0Y0_前翅_揚羽_紋6CP.Update();
				return;
			}
			this.X0Y1_前翅_前翅CP.Update();
			this.X0Y1_前翅_水青_柄CP.Update();
			this.X0Y1_前翅_水青_縁柄CP.Update();
			this.X0Y1_前翅_水青_紋1CP.Update();
			this.X0Y1_前翅_水青_紋2CP.Update();
			this.X0Y1_前翅_揚羽_柄1CP.Update();
			this.X0Y1_前翅_揚羽_柄2CP.Update();
			this.X0Y1_前翅_揚羽_柄3CP.Update();
			this.X0Y1_前翅_揚羽_柄4CP.Update();
			this.X0Y1_前翅_揚羽_柄5CP.Update();
			this.X0Y1_前翅_揚羽_柄6CP.Update();
			this.X0Y1_前翅_揚羽_柄7CP.Update();
			this.X0Y1_前翅_揚羽_柄8CP.Update();
			this.X0Y1_前翅_揚羽_柄9CP.Update();
			this.X0Y1_前翅_揚羽_柄10CP.Update();
			this.X0Y1_前翅_揚羽_紋1CP.Update();
			this.X0Y1_前翅_揚羽_紋2CP.Update();
			this.X0Y1_前翅_揚羽_紋3CP.Update();
			this.X0Y1_前翅_揚羽_紋4CP.Update();
			this.X0Y1_前翅_揚羽_紋5CP.Update();
			this.X0Y1_前翅_揚羽_紋6CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.前翅_前翅CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.前翅_水青_柄CD = new ColorD(ref Col.Empty, ref 体配色.柄O);
			this.前翅_水青_縁柄CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.前翅_水青_紋1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.前翅_水青_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.前翅_揚羽_柄1CD = new ColorD(ref Col.Black, ref 体配色.柄O);
			this.前翅_揚羽_柄2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.前翅_揚羽_柄3CD = new ColorD(ref Col.Black, ref 体配色.柄O);
			this.前翅_揚羽_柄4CD = new ColorD(ref Col.Black, ref 体配色.柄O);
			this.前翅_揚羽_柄5CD = new ColorD(ref Col.Black, ref 体配色.柄O);
			this.前翅_揚羽_柄6CD = new ColorD(ref Col.Black, ref 体配色.柄O);
			this.前翅_揚羽_柄7CD = new ColorD(ref Col.Black, ref 体配色.柄O);
			this.前翅_揚羽_柄8CD = new ColorD(ref Col.Black, ref 体配色.柄O);
			this.前翅_揚羽_柄9CD = new ColorD(ref Col.Black, ref 体配色.柄O);
			this.前翅_揚羽_柄10CD = new ColorD(ref Col.Black, ref 体配色.柄O);
			this.前翅_揚羽_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.前翅_揚羽_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.前翅_揚羽_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.前翅_揚羽_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.前翅_揚羽_紋5CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.前翅_揚羽_紋6CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
		}

		public Par X0Y0_前翅_前翅;

		public Par X0Y0_前翅_水青_柄;

		public Par X0Y0_前翅_水青_縁柄;

		public Par X0Y0_前翅_水青_紋1;

		public Par X0Y0_前翅_水青_紋2;

		public Par X0Y0_前翅_揚羽_柄1;

		public Par X0Y0_前翅_揚羽_柄2;

		public Par X0Y0_前翅_揚羽_柄3;

		public Par X0Y0_前翅_揚羽_柄4;

		public Par X0Y0_前翅_揚羽_柄5;

		public Par X0Y0_前翅_揚羽_柄6;

		public Par X0Y0_前翅_揚羽_柄7;

		public Par X0Y0_前翅_揚羽_柄8;

		public Par X0Y0_前翅_揚羽_柄9;

		public Par X0Y0_前翅_揚羽_柄10;

		public Par X0Y0_前翅_揚羽_紋1;

		public Par X0Y0_前翅_揚羽_紋2;

		public Par X0Y0_前翅_揚羽_紋3;

		public Par X0Y0_前翅_揚羽_紋4;

		public Par X0Y0_前翅_揚羽_紋5;

		public Par X0Y0_前翅_揚羽_紋6;

		public Par X0Y1_前翅_前翅;

		public Par X0Y1_前翅_水青_柄;

		public Par X0Y1_前翅_水青_縁柄;

		public Par X0Y1_前翅_水青_紋1;

		public Par X0Y1_前翅_水青_紋2;

		public Par X0Y1_前翅_揚羽_柄1;

		public Par X0Y1_前翅_揚羽_柄2;

		public Par X0Y1_前翅_揚羽_柄3;

		public Par X0Y1_前翅_揚羽_柄4;

		public Par X0Y1_前翅_揚羽_柄5;

		public Par X0Y1_前翅_揚羽_柄6;

		public Par X0Y1_前翅_揚羽_柄7;

		public Par X0Y1_前翅_揚羽_柄8;

		public Par X0Y1_前翅_揚羽_柄9;

		public Par X0Y1_前翅_揚羽_柄10;

		public Par X0Y1_前翅_揚羽_紋1;

		public Par X0Y1_前翅_揚羽_紋2;

		public Par X0Y1_前翅_揚羽_紋3;

		public Par X0Y1_前翅_揚羽_紋4;

		public Par X0Y1_前翅_揚羽_紋5;

		public Par X0Y1_前翅_揚羽_紋6;

		public ColorD 前翅_前翅CD;

		public ColorD 前翅_水青_柄CD;

		public ColorD 前翅_水青_縁柄CD;

		public ColorD 前翅_水青_紋1CD;

		public ColorD 前翅_水青_紋2CD;

		public ColorD 前翅_揚羽_柄1CD;

		public ColorD 前翅_揚羽_柄2CD;

		public ColorD 前翅_揚羽_柄3CD;

		public ColorD 前翅_揚羽_柄4CD;

		public ColorD 前翅_揚羽_柄5CD;

		public ColorD 前翅_揚羽_柄6CD;

		public ColorD 前翅_揚羽_柄7CD;

		public ColorD 前翅_揚羽_柄8CD;

		public ColorD 前翅_揚羽_柄9CD;

		public ColorD 前翅_揚羽_柄10CD;

		public ColorD 前翅_揚羽_紋1CD;

		public ColorD 前翅_揚羽_紋2CD;

		public ColorD 前翅_揚羽_紋3CD;

		public ColorD 前翅_揚羽_紋4CD;

		public ColorD 前翅_揚羽_紋5CD;

		public ColorD 前翅_揚羽_紋6CD;

		public ColorP X0Y0_前翅_前翅CP;

		public ColorP X0Y0_前翅_水青_柄CP;

		public ColorP X0Y0_前翅_水青_縁柄CP;

		public ColorP X0Y0_前翅_水青_紋1CP;

		public ColorP X0Y0_前翅_水青_紋2CP;

		public ColorP X0Y0_前翅_揚羽_柄1CP;

		public ColorP X0Y0_前翅_揚羽_柄2CP;

		public ColorP X0Y0_前翅_揚羽_柄3CP;

		public ColorP X0Y0_前翅_揚羽_柄4CP;

		public ColorP X0Y0_前翅_揚羽_柄5CP;

		public ColorP X0Y0_前翅_揚羽_柄6CP;

		public ColorP X0Y0_前翅_揚羽_柄7CP;

		public ColorP X0Y0_前翅_揚羽_柄8CP;

		public ColorP X0Y0_前翅_揚羽_柄9CP;

		public ColorP X0Y0_前翅_揚羽_柄10CP;

		public ColorP X0Y0_前翅_揚羽_紋1CP;

		public ColorP X0Y0_前翅_揚羽_紋2CP;

		public ColorP X0Y0_前翅_揚羽_紋3CP;

		public ColorP X0Y0_前翅_揚羽_紋4CP;

		public ColorP X0Y0_前翅_揚羽_紋5CP;

		public ColorP X0Y0_前翅_揚羽_紋6CP;

		public ColorP X0Y1_前翅_前翅CP;

		public ColorP X0Y1_前翅_水青_柄CP;

		public ColorP X0Y1_前翅_水青_縁柄CP;

		public ColorP X0Y1_前翅_水青_紋1CP;

		public ColorP X0Y1_前翅_水青_紋2CP;

		public ColorP X0Y1_前翅_揚羽_柄1CP;

		public ColorP X0Y1_前翅_揚羽_柄2CP;

		public ColorP X0Y1_前翅_揚羽_柄3CP;

		public ColorP X0Y1_前翅_揚羽_柄4CP;

		public ColorP X0Y1_前翅_揚羽_柄5CP;

		public ColorP X0Y1_前翅_揚羽_柄6CP;

		public ColorP X0Y1_前翅_揚羽_柄7CP;

		public ColorP X0Y1_前翅_揚羽_柄8CP;

		public ColorP X0Y1_前翅_揚羽_柄9CP;

		public ColorP X0Y1_前翅_揚羽_柄10CP;

		public ColorP X0Y1_前翅_揚羽_紋1CP;

		public ColorP X0Y1_前翅_揚羽_紋2CP;

		public ColorP X0Y1_前翅_揚羽_紋3CP;

		public ColorP X0Y1_前翅_揚羽_紋4CP;

		public ColorP X0Y1_前翅_揚羽_紋5CP;

		public ColorP X0Y1_前翅_揚羽_紋6CP;

		private bool 水青_;
	}
}
