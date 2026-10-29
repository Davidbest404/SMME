using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 花_薔 : 花
	{
		public 花_薔(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 花_薔D e)
		{
			this.ThisType = base.GetType();
			Pars pars = new Pars();
			pars.Tag = "バラ";
			Pars pars2 = Sta.肢左["植"][0][0];
			pars.Add("バラ", new Pars(pars2["花"].ToPars()["バラ"].ToPars()));
			pars.Add("萼", new Pars(pars2["萼"].ToPars()));
			Dif dif = new Dif();
			dif.Tag = "花";
			dif.Add(new Pars(pars));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars3 = this.本体[0][0];
			Pars pars4 = pars3["バラ"].ToPars();
			Pars pars5 = pars4["通常"].ToPars();
			this.X0Y0_花_バラ_通常_花弁2 = pars5["花弁2"].ToPar();
			this.X0Y0_花_バラ_通常_花弁4 = pars5["花弁4"].ToPar();
			this.X0Y0_花_バラ_通常_花弁3 = pars5["花弁3"].ToPar();
			this.X0Y0_花_バラ_通常_花弁1 = pars5["花弁1"].ToPar();
			this.X0Y0_花_バラ_通常_花弁5 = pars5["花弁5"].ToPar();
			this.X0Y0_花_バラ_通常_花弁6 = pars5["花弁6"].ToPar();
			this.X0Y0_花_バラ_通常_花弁8 = pars5["花弁8"].ToPar();
			this.X0Y0_花_バラ_通常_花弁7 = pars5["花弁7"].ToPar();
			this.X0Y0_花_バラ_通常_花弁9 = pars5["花弁9"].ToPar();
			this.X0Y0_花_バラ_通常_花弁11 = pars5["花弁11"].ToPar();
			this.X0Y0_花_バラ_通常_花弁10 = pars5["花弁10"].ToPar();
			this.X0Y0_花_バラ_通常_花弁影 = pars5["花弁影"].ToPar();
			pars5 = pars4["欠損"].ToPars();
			this.X0Y0_花_バラ_欠損_花弁2 = pars5["花弁2"].ToPar();
			this.X0Y0_花_バラ_欠損_花弁4 = pars5["花弁4"].ToPar();
			this.X0Y0_花_バラ_欠損_花弁3 = pars5["花弁3"].ToPar();
			this.X0Y0_花_バラ_欠損_花弁1 = pars5["花弁1"].ToPar();
			this.X0Y0_花_バラ_欠損_花弁5 = pars5["花弁5"].ToPar();
			this.X0Y0_花_バラ_欠損_花弁6 = pars5["花弁6"].ToPar();
			this.X0Y0_花_バラ_欠損_花弁8 = pars5["花弁8"].ToPar();
			this.X0Y0_花_バラ_欠損_花弁7 = pars5["花弁7"].ToPar();
			this.X0Y0_花_バラ_欠損_花弁9 = pars5["花弁9"].ToPar();
			this.X0Y0_花_バラ_欠損_花弁11 = pars5["花弁11"].ToPar();
			this.X0Y0_花_バラ_欠損_花弁10 = pars5["花弁10"].ToPar();
			this.X0Y0_花_バラ_欠損_花弁影 = pars5["花弁影"].ToPar();
			Pars pars6 = pars3["萼"].ToPars();
			pars5 = pars6["通常"].ToPars();
			this.X0Y0_萼_通常_萼 = pars5["萼"].ToPar();
			pars5 = pars6["欠損"].ToPars();
			this.X0Y0_萼_欠損_萼 = pars5["萼"].ToPar();
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
			this.花_バラ_通常_花弁2_表示 = e.花_バラ_通常_花弁2_表示;
			this.花_バラ_通常_花弁4_表示 = e.花_バラ_通常_花弁4_表示;
			this.花_バラ_通常_花弁3_表示 = e.花_バラ_通常_花弁3_表示;
			this.花_バラ_通常_花弁1_表示 = e.花_バラ_通常_花弁1_表示;
			this.花_バラ_通常_花弁5_表示 = e.花_バラ_通常_花弁5_表示;
			this.花_バラ_通常_花弁6_表示 = e.花_バラ_通常_花弁6_表示;
			this.花_バラ_通常_花弁8_表示 = e.花_バラ_通常_花弁8_表示;
			this.花_バラ_通常_花弁7_表示 = e.花_バラ_通常_花弁7_表示;
			this.花_バラ_通常_花弁9_表示 = e.花_バラ_通常_花弁9_表示;
			this.花_バラ_通常_花弁11_表示 = e.花_バラ_通常_花弁11_表示;
			this.花_バラ_通常_花弁10_表示 = e.花_バラ_通常_花弁10_表示;
			this.花_バラ_通常_花弁影_表示 = e.花_バラ_通常_花弁影_表示;
			this.花_バラ_欠損_花弁2_表示 = e.花_バラ_欠損_花弁2_表示;
			this.花_バラ_欠損_花弁4_表示 = e.花_バラ_欠損_花弁4_表示;
			this.花_バラ_欠損_花弁3_表示 = e.花_バラ_欠損_花弁3_表示;
			this.花_バラ_欠損_花弁1_表示 = e.花_バラ_欠損_花弁1_表示;
			this.花_バラ_欠損_花弁5_表示 = e.花_バラ_欠損_花弁5_表示;
			this.花_バラ_欠損_花弁6_表示 = e.花_バラ_欠損_花弁6_表示;
			this.花_バラ_欠損_花弁8_表示 = e.花_バラ_欠損_花弁8_表示;
			this.花_バラ_欠損_花弁7_表示 = e.花_バラ_欠損_花弁7_表示;
			this.花_バラ_欠損_花弁9_表示 = e.花_バラ_欠損_花弁9_表示;
			this.花_バラ_欠損_花弁11_表示 = e.花_バラ_欠損_花弁11_表示;
			this.花_バラ_欠損_花弁10_表示 = e.花_バラ_欠損_花弁10_表示;
			this.花_バラ_欠損_花弁影_表示 = e.花_バラ_欠損_花弁影_表示;
			this.萼_通常_萼_表示 = e.萼_通常_萼_表示;
			this.萼_欠損_萼_表示 = e.萼_欠損_萼_表示;
			this.花_バラ_花弁2_表示 = e.花_バラ_花弁2_表示;
			this.花_バラ_花弁4_表示 = e.花_バラ_花弁4_表示;
			this.花_バラ_花弁3_表示 = e.花_バラ_花弁3_表示;
			this.花_バラ_花弁1_表示 = e.花_バラ_花弁1_表示;
			this.花_バラ_花弁5_表示 = e.花_バラ_花弁5_表示;
			this.花_バラ_花弁6_表示 = e.花_バラ_花弁6_表示;
			this.花_バラ_花弁8_表示 = e.花_バラ_花弁8_表示;
			this.花_バラ_花弁7_表示 = e.花_バラ_花弁7_表示;
			this.花_バラ_花弁9_表示 = e.花_バラ_花弁9_表示;
			this.花_バラ_花弁11_表示 = e.花_バラ_花弁11_表示;
			this.花_バラ_花弁10_表示 = e.花_バラ_花弁10_表示;
			this.花_バラ_花弁影_表示 = e.花_バラ_花弁影_表示;
			this.萼_萼_表示 = e.萼_萼_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_花_バラ_通常_花弁2CP = new ColorP(this.X0Y0_花_バラ_通常_花弁2, this.花_バラ_花弁2CD, DisUnit, true);
			this.X0Y0_花_バラ_通常_花弁4CP = new ColorP(this.X0Y0_花_バラ_通常_花弁4, this.花_バラ_花弁4CD, DisUnit, true);
			this.X0Y0_花_バラ_通常_花弁3CP = new ColorP(this.X0Y0_花_バラ_通常_花弁3, this.花_バラ_花弁3CD, DisUnit, true);
			this.X0Y0_花_バラ_通常_花弁1CP = new ColorP(this.X0Y0_花_バラ_通常_花弁1, this.花_バラ_花弁1CD, DisUnit, true);
			this.X0Y0_花_バラ_通常_花弁5CP = new ColorP(this.X0Y0_花_バラ_通常_花弁5, this.花_バラ_花弁5CD, DisUnit, true);
			this.X0Y0_花_バラ_通常_花弁6CP = new ColorP(this.X0Y0_花_バラ_通常_花弁6, this.花_バラ_花弁6CD, DisUnit, true);
			this.X0Y0_花_バラ_通常_花弁8CP = new ColorP(this.X0Y0_花_バラ_通常_花弁8, this.花_バラ_花弁8CD, DisUnit, true);
			this.X0Y0_花_バラ_通常_花弁7CP = new ColorP(this.X0Y0_花_バラ_通常_花弁7, this.花_バラ_花弁7CD, DisUnit, true);
			this.X0Y0_花_バラ_通常_花弁9CP = new ColorP(this.X0Y0_花_バラ_通常_花弁9, this.花_バラ_花弁9CD, DisUnit, true);
			this.X0Y0_花_バラ_通常_花弁11CP = new ColorP(this.X0Y0_花_バラ_通常_花弁11, this.花_バラ_花弁11CD, DisUnit, true);
			this.X0Y0_花_バラ_通常_花弁10CP = new ColorP(this.X0Y0_花_バラ_通常_花弁10, this.花_バラ_花弁10CD, DisUnit, true);
			this.X0Y0_花_バラ_通常_花弁影CP = new ColorP(this.X0Y0_花_バラ_通常_花弁影, this.花_バラ_花弁影CD, DisUnit, true);
			this.X0Y0_花_バラ_欠損_花弁2CP = new ColorP(this.X0Y0_花_バラ_欠損_花弁2, this.花_バラ_花弁2CD, DisUnit, true);
			this.X0Y0_花_バラ_欠損_花弁4CP = new ColorP(this.X0Y0_花_バラ_欠損_花弁4, this.花_バラ_花弁4CD, DisUnit, true);
			this.X0Y0_花_バラ_欠損_花弁3CP = new ColorP(this.X0Y0_花_バラ_欠損_花弁3, this.花_バラ_花弁3CD, DisUnit, true);
			this.X0Y0_花_バラ_欠損_花弁1CP = new ColorP(this.X0Y0_花_バラ_欠損_花弁1, this.花_バラ_花弁1CD, DisUnit, true);
			this.X0Y0_花_バラ_欠損_花弁5CP = new ColorP(this.X0Y0_花_バラ_欠損_花弁5, this.花_バラ_花弁5CD, DisUnit, true);
			this.X0Y0_花_バラ_欠損_花弁6CP = new ColorP(this.X0Y0_花_バラ_欠損_花弁6, this.花_バラ_花弁6CD, DisUnit, true);
			this.X0Y0_花_バラ_欠損_花弁8CP = new ColorP(this.X0Y0_花_バラ_欠損_花弁8, this.花_バラ_花弁8CD, DisUnit, true);
			this.X0Y0_花_バラ_欠損_花弁7CP = new ColorP(this.X0Y0_花_バラ_欠損_花弁7, this.花_バラ_花弁7CD, DisUnit, true);
			this.X0Y0_花_バラ_欠損_花弁9CP = new ColorP(this.X0Y0_花_バラ_欠損_花弁9, this.花_バラ_花弁9CD, DisUnit, true);
			this.X0Y0_花_バラ_欠損_花弁11CP = new ColorP(this.X0Y0_花_バラ_欠損_花弁11, this.花_バラ_花弁11CD, DisUnit, true);
			this.X0Y0_花_バラ_欠損_花弁10CP = new ColorP(this.X0Y0_花_バラ_欠損_花弁10, this.花_バラ_花弁10CD, DisUnit, true);
			this.X0Y0_花_バラ_欠損_花弁影CP = new ColorP(this.X0Y0_花_バラ_欠損_花弁影, this.花_バラ_花弁影CD, DisUnit, true);
			this.X0Y0_萼_通常_萼CP = new ColorP(this.X0Y0_萼_通常_萼, this.萼_萼CD, DisUnit, true);
			this.X0Y0_萼_欠損_萼CP = new ColorP(this.X0Y0_萼_欠損_萼, this.萼_萼CD, DisUnit, true);
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
				this.花_バラ_花弁2_表示 = this.花_バラ_花弁2_表示;
				this.花_バラ_花弁4_表示 = this.花_バラ_花弁4_表示;
				this.花_バラ_花弁3_表示 = this.花_バラ_花弁3_表示;
				this.花_バラ_花弁1_表示 = this.花_バラ_花弁1_表示;
				this.花_バラ_花弁5_表示 = this.花_バラ_花弁5_表示;
				this.花_バラ_花弁6_表示 = this.花_バラ_花弁6_表示;
				this.花_バラ_花弁8_表示 = this.花_バラ_花弁8_表示;
				this.花_バラ_花弁7_表示 = this.花_バラ_花弁7_表示;
				this.花_バラ_花弁9_表示 = this.花_バラ_花弁9_表示;
				this.花_バラ_花弁11_表示 = this.花_バラ_花弁11_表示;
				this.花_バラ_花弁10_表示 = this.花_バラ_花弁10_表示;
				this.花_バラ_花弁影_表示 = this.花_バラ_花弁影_表示;
				this.萼_萼_表示 = this.萼_萼_表示;
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

		public bool 花_バラ_通常_花弁2_表示
		{
			get
			{
				return this.X0Y0_花_バラ_通常_花弁2.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_通常_花弁2.Dra = value;
				this.X0Y0_花_バラ_通常_花弁2.Hit = value;
			}
		}

		public bool 花_バラ_通常_花弁4_表示
		{
			get
			{
				return this.X0Y0_花_バラ_通常_花弁4.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_通常_花弁4.Dra = value;
				this.X0Y0_花_バラ_通常_花弁4.Hit = value;
			}
		}

		public bool 花_バラ_通常_花弁3_表示
		{
			get
			{
				return this.X0Y0_花_バラ_通常_花弁3.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_通常_花弁3.Dra = value;
				this.X0Y0_花_バラ_通常_花弁3.Hit = value;
			}
		}

		public bool 花_バラ_通常_花弁1_表示
		{
			get
			{
				return this.X0Y0_花_バラ_通常_花弁1.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_通常_花弁1.Dra = value;
				this.X0Y0_花_バラ_通常_花弁1.Hit = value;
			}
		}

		public bool 花_バラ_通常_花弁5_表示
		{
			get
			{
				return this.X0Y0_花_バラ_通常_花弁5.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_通常_花弁5.Dra = value;
				this.X0Y0_花_バラ_通常_花弁5.Hit = value;
			}
		}

		public bool 花_バラ_通常_花弁6_表示
		{
			get
			{
				return this.X0Y0_花_バラ_通常_花弁6.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_通常_花弁6.Dra = value;
				this.X0Y0_花_バラ_通常_花弁6.Hit = value;
			}
		}

		public bool 花_バラ_通常_花弁8_表示
		{
			get
			{
				return this.X0Y0_花_バラ_通常_花弁8.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_通常_花弁8.Dra = value;
				this.X0Y0_花_バラ_通常_花弁8.Hit = value;
			}
		}

		public bool 花_バラ_通常_花弁7_表示
		{
			get
			{
				return this.X0Y0_花_バラ_通常_花弁7.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_通常_花弁7.Dra = value;
				this.X0Y0_花_バラ_通常_花弁7.Hit = value;
			}
		}

		public bool 花_バラ_通常_花弁9_表示
		{
			get
			{
				return this.X0Y0_花_バラ_通常_花弁9.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_通常_花弁9.Dra = value;
				this.X0Y0_花_バラ_通常_花弁9.Hit = value;
			}
		}

		public bool 花_バラ_通常_花弁11_表示
		{
			get
			{
				return this.X0Y0_花_バラ_通常_花弁11.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_通常_花弁11.Dra = value;
				this.X0Y0_花_バラ_通常_花弁11.Hit = value;
			}
		}

		public bool 花_バラ_通常_花弁10_表示
		{
			get
			{
				return this.X0Y0_花_バラ_通常_花弁10.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_通常_花弁10.Dra = value;
				this.X0Y0_花_バラ_通常_花弁10.Hit = value;
			}
		}

		public bool 花_バラ_通常_花弁影_表示
		{
			get
			{
				return this.X0Y0_花_バラ_通常_花弁影.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_通常_花弁影.Dra = value;
				this.X0Y0_花_バラ_通常_花弁影.Hit = value;
			}
		}

		public bool 花_バラ_欠損_花弁2_表示
		{
			get
			{
				return this.X0Y0_花_バラ_欠損_花弁2.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_欠損_花弁2.Dra = value;
				this.X0Y0_花_バラ_欠損_花弁2.Hit = value;
			}
		}

		public bool 花_バラ_欠損_花弁4_表示
		{
			get
			{
				return this.X0Y0_花_バラ_欠損_花弁4.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_欠損_花弁4.Dra = value;
				this.X0Y0_花_バラ_欠損_花弁4.Hit = value;
			}
		}

		public bool 花_バラ_欠損_花弁3_表示
		{
			get
			{
				return this.X0Y0_花_バラ_欠損_花弁3.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_欠損_花弁3.Dra = value;
				this.X0Y0_花_バラ_欠損_花弁3.Hit = value;
			}
		}

		public bool 花_バラ_欠損_花弁1_表示
		{
			get
			{
				return this.X0Y0_花_バラ_欠損_花弁1.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_欠損_花弁1.Dra = value;
				this.X0Y0_花_バラ_欠損_花弁1.Hit = value;
			}
		}

		public bool 花_バラ_欠損_花弁5_表示
		{
			get
			{
				return this.X0Y0_花_バラ_欠損_花弁5.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_欠損_花弁5.Dra = value;
				this.X0Y0_花_バラ_欠損_花弁5.Hit = value;
			}
		}

		public bool 花_バラ_欠損_花弁6_表示
		{
			get
			{
				return this.X0Y0_花_バラ_欠損_花弁6.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_欠損_花弁6.Dra = value;
				this.X0Y0_花_バラ_欠損_花弁6.Hit = value;
			}
		}

		public bool 花_バラ_欠損_花弁8_表示
		{
			get
			{
				return this.X0Y0_花_バラ_欠損_花弁8.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_欠損_花弁8.Dra = value;
				this.X0Y0_花_バラ_欠損_花弁8.Hit = value;
			}
		}

		public bool 花_バラ_欠損_花弁7_表示
		{
			get
			{
				return this.X0Y0_花_バラ_欠損_花弁7.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_欠損_花弁7.Dra = value;
				this.X0Y0_花_バラ_欠損_花弁7.Hit = value;
			}
		}

		public bool 花_バラ_欠損_花弁9_表示
		{
			get
			{
				return this.X0Y0_花_バラ_欠損_花弁9.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_欠損_花弁9.Dra = value;
				this.X0Y0_花_バラ_欠損_花弁9.Hit = value;
			}
		}

		public bool 花_バラ_欠損_花弁11_表示
		{
			get
			{
				return this.X0Y0_花_バラ_欠損_花弁11.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_欠損_花弁11.Dra = value;
				this.X0Y0_花_バラ_欠損_花弁11.Hit = value;
			}
		}

		public bool 花_バラ_欠損_花弁10_表示
		{
			get
			{
				return this.X0Y0_花_バラ_欠損_花弁10.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_欠損_花弁10.Dra = value;
				this.X0Y0_花_バラ_欠損_花弁10.Hit = value;
			}
		}

		public bool 花_バラ_欠損_花弁影_表示
		{
			get
			{
				return this.X0Y0_花_バラ_欠損_花弁影.Dra;
			}
			set
			{
				this.X0Y0_花_バラ_欠損_花弁影.Dra = value;
				this.X0Y0_花_バラ_欠損_花弁影.Hit = value;
			}
		}

		public bool 萼_通常_萼_表示
		{
			get
			{
				return this.X0Y0_萼_通常_萼.Dra;
			}
			set
			{
				this.X0Y0_萼_通常_萼.Dra = value;
				this.X0Y0_萼_通常_萼.Hit = value;
			}
		}

		public bool 萼_欠損_萼_表示
		{
			get
			{
				return this.X0Y0_萼_欠損_萼.Dra;
			}
			set
			{
				this.X0Y0_萼_欠損_萼.Dra = value;
				this.X0Y0_萼_欠損_萼.Hit = value;
			}
		}

		public bool 花_バラ_花弁2_表示
		{
			get
			{
				return this.花_バラ_通常_花弁2_表示 || this.花_バラ_欠損_花弁2_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_バラ_通常_花弁2_表示 = false;
					this.花_バラ_欠損_花弁2_表示 = value;
					return;
				}
				this.花_バラ_通常_花弁2_表示 = value;
				this.花_バラ_欠損_花弁2_表示 = false;
			}
		}

		public bool 花_バラ_花弁4_表示
		{
			get
			{
				return this.花_バラ_通常_花弁4_表示 || this.花_バラ_欠損_花弁4_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_バラ_通常_花弁4_表示 = false;
					this.花_バラ_欠損_花弁4_表示 = value;
					return;
				}
				this.花_バラ_通常_花弁4_表示 = value;
				this.花_バラ_欠損_花弁4_表示 = false;
			}
		}

		public bool 花_バラ_花弁3_表示
		{
			get
			{
				return this.花_バラ_通常_花弁3_表示 || this.花_バラ_欠損_花弁3_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_バラ_通常_花弁3_表示 = false;
					this.花_バラ_欠損_花弁3_表示 = value;
					return;
				}
				this.花_バラ_通常_花弁3_表示 = value;
				this.花_バラ_欠損_花弁3_表示 = false;
			}
		}

		public bool 花_バラ_花弁1_表示
		{
			get
			{
				return this.花_バラ_通常_花弁1_表示 || this.花_バラ_欠損_花弁1_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_バラ_通常_花弁1_表示 = false;
					this.花_バラ_欠損_花弁1_表示 = value;
					return;
				}
				this.花_バラ_通常_花弁1_表示 = value;
				this.花_バラ_欠損_花弁1_表示 = false;
			}
		}

		public bool 花_バラ_花弁5_表示
		{
			get
			{
				return this.花_バラ_通常_花弁5_表示 || this.花_バラ_欠損_花弁5_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_バラ_通常_花弁5_表示 = false;
					this.花_バラ_欠損_花弁5_表示 = value;
					return;
				}
				this.花_バラ_通常_花弁5_表示 = value;
				this.花_バラ_欠損_花弁5_表示 = false;
			}
		}

		public bool 花_バラ_花弁6_表示
		{
			get
			{
				return this.花_バラ_通常_花弁6_表示 || this.花_バラ_欠損_花弁6_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_バラ_通常_花弁6_表示 = false;
					this.花_バラ_欠損_花弁6_表示 = value;
					return;
				}
				this.花_バラ_通常_花弁6_表示 = value;
				this.花_バラ_欠損_花弁6_表示 = false;
			}
		}

		public bool 花_バラ_花弁8_表示
		{
			get
			{
				return this.花_バラ_通常_花弁8_表示 || this.花_バラ_欠損_花弁8_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_バラ_通常_花弁8_表示 = false;
					this.花_バラ_欠損_花弁8_表示 = value;
					return;
				}
				this.花_バラ_通常_花弁8_表示 = value;
				this.花_バラ_欠損_花弁8_表示 = false;
			}
		}

		public bool 花_バラ_花弁7_表示
		{
			get
			{
				return this.花_バラ_通常_花弁7_表示 || this.花_バラ_欠損_花弁7_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_バラ_通常_花弁7_表示 = false;
					this.花_バラ_欠損_花弁7_表示 = value;
					return;
				}
				this.花_バラ_通常_花弁7_表示 = value;
				this.花_バラ_欠損_花弁7_表示 = false;
			}
		}

		public bool 花_バラ_花弁9_表示
		{
			get
			{
				return this.花_バラ_通常_花弁9_表示 || this.花_バラ_欠損_花弁9_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_バラ_通常_花弁9_表示 = false;
					this.花_バラ_欠損_花弁9_表示 = value;
					return;
				}
				this.花_バラ_通常_花弁9_表示 = value;
				this.花_バラ_欠損_花弁9_表示 = false;
			}
		}

		public bool 花_バラ_花弁11_表示
		{
			get
			{
				return this.花_バラ_通常_花弁11_表示 || this.花_バラ_欠損_花弁11_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_バラ_通常_花弁11_表示 = false;
					this.花_バラ_欠損_花弁11_表示 = value;
					return;
				}
				this.花_バラ_通常_花弁11_表示 = value;
				this.花_バラ_欠損_花弁11_表示 = false;
			}
		}

		public bool 花_バラ_花弁10_表示
		{
			get
			{
				return this.花_バラ_通常_花弁10_表示 || this.花_バラ_欠損_花弁10_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_バラ_通常_花弁10_表示 = false;
					this.花_バラ_欠損_花弁10_表示 = value;
					return;
				}
				this.花_バラ_通常_花弁10_表示 = value;
				this.花_バラ_欠損_花弁10_表示 = false;
			}
		}

		public bool 花_バラ_花弁影_表示
		{
			get
			{
				return this.花_バラ_通常_花弁影_表示 || this.花_バラ_欠損_花弁影_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.花_バラ_通常_花弁影_表示 = false;
					this.花_バラ_欠損_花弁影_表示 = value;
					return;
				}
				this.花_バラ_通常_花弁影_表示 = value;
				this.花_バラ_欠損_花弁影_表示 = false;
			}
		}

		public bool 萼_萼_表示
		{
			get
			{
				return this.萼_通常_萼_表示 || this.萼_欠損_萼_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.萼_通常_萼_表示 = false;
					this.萼_欠損_萼_表示 = value;
					return;
				}
				this.萼_通常_萼_表示 = value;
				this.萼_欠損_萼_表示 = false;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.花_バラ_通常_花弁2_表示;
			}
			set
			{
				this.花_バラ_通常_花弁2_表示 = value;
				this.花_バラ_通常_花弁4_表示 = value;
				this.花_バラ_通常_花弁3_表示 = value;
				this.花_バラ_通常_花弁1_表示 = value;
				this.花_バラ_通常_花弁5_表示 = value;
				this.花_バラ_通常_花弁6_表示 = value;
				this.花_バラ_通常_花弁8_表示 = value;
				this.花_バラ_通常_花弁7_表示 = value;
				this.花_バラ_通常_花弁9_表示 = value;
				this.花_バラ_通常_花弁11_表示 = value;
				this.花_バラ_通常_花弁10_表示 = value;
				this.花_バラ_通常_花弁影_表示 = value;
				this.花_バラ_欠損_花弁2_表示 = value;
				this.花_バラ_欠損_花弁4_表示 = value;
				this.花_バラ_欠損_花弁3_表示 = value;
				this.花_バラ_欠損_花弁1_表示 = value;
				this.花_バラ_欠損_花弁5_表示 = value;
				this.花_バラ_欠損_花弁6_表示 = value;
				this.花_バラ_欠損_花弁8_表示 = value;
				this.花_バラ_欠損_花弁7_表示 = value;
				this.花_バラ_欠損_花弁9_表示 = value;
				this.花_バラ_欠損_花弁11_表示 = value;
				this.花_バラ_欠損_花弁10_表示 = value;
				this.花_バラ_欠損_花弁影_表示 = value;
				this.萼_通常_萼_表示 = value;
				this.萼_欠損_萼_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.花_バラ_花弁2CD.不透明度;
			}
			set
			{
				this.花_バラ_花弁2CD.不透明度 = value;
				this.花_バラ_花弁4CD.不透明度 = value;
				this.花_バラ_花弁3CD.不透明度 = value;
				this.花_バラ_花弁1CD.不透明度 = value;
				this.花_バラ_花弁5CD.不透明度 = value;
				this.花_バラ_花弁6CD.不透明度 = value;
				this.花_バラ_花弁8CD.不透明度 = value;
				this.花_バラ_花弁7CD.不透明度 = value;
				this.花_バラ_花弁9CD.不透明度 = value;
				this.花_バラ_花弁11CD.不透明度 = value;
				this.花_バラ_花弁10CD.不透明度 = value;
				this.花_バラ_花弁影CD.不透明度 = value;
				this.萼_萼CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_萼_通常_萼.AngleBase = num * -58.0;
			this.本体.JoinPAall();
		}

		public override void 色更新()
		{
			this.X0Y0_花_バラ_通常_花弁2CP.Update();
			this.X0Y0_花_バラ_通常_花弁4CP.Update();
			this.X0Y0_花_バラ_通常_花弁3CP.Update();
			this.X0Y0_花_バラ_通常_花弁1CP.Update();
			this.X0Y0_花_バラ_通常_花弁5CP.Update();
			this.X0Y0_花_バラ_通常_花弁6CP.Update();
			this.X0Y0_花_バラ_通常_花弁8CP.Update();
			this.X0Y0_花_バラ_通常_花弁7CP.Update();
			this.X0Y0_花_バラ_通常_花弁9CP.Update();
			this.X0Y0_花_バラ_通常_花弁11CP.Update();
			this.X0Y0_花_バラ_通常_花弁10CP.Update();
			this.X0Y0_花_バラ_通常_花弁影CP.Update();
			this.X0Y0_花_バラ_欠損_花弁2CP.Update();
			this.X0Y0_花_バラ_欠損_花弁4CP.Update();
			this.X0Y0_花_バラ_欠損_花弁3CP.Update();
			this.X0Y0_花_バラ_欠損_花弁1CP.Update();
			this.X0Y0_花_バラ_欠損_花弁5CP.Update();
			this.X0Y0_花_バラ_欠損_花弁6CP.Update();
			this.X0Y0_花_バラ_欠損_花弁8CP.Update();
			this.X0Y0_花_バラ_欠損_花弁7CP.Update();
			this.X0Y0_花_バラ_欠損_花弁9CP.Update();
			this.X0Y0_花_バラ_欠損_花弁11CP.Update();
			this.X0Y0_花_バラ_欠損_花弁10CP.Update();
			this.X0Y0_花_バラ_欠損_花弁影CP.Update();
			this.X0Y0_萼_通常_萼CP.Update();
			this.X0Y0_萼_欠損_萼CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			switch (this.配色指定)
			{
			case 配色指定.N0:
				this.配色N0(体配色);
				return;
			case 配色指定.T0:
				this.配色T0(体配色);
				return;
			case 配色指定.T1:
				this.配色T1(体配色);
				return;
			default:
				this.配色N0(体配色);
				return;
			}
		}

		private void 配色N0(体配色 体配色)
		{
			this.花_バラ_花弁2CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁4CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁3CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁1CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁5CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁6CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁8CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁7CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁9CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁11CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁10CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁影CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.萼_萼CD = new ColorD(ref Col.Black, ref 体配色.植1O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.花_バラ_花弁2CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁4CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁3CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁1CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁5CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁6CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁8CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁7CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁9CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁11CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁10CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁影CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.萼_萼CD = new ColorD(ref Col.Black, ref 体配色.植1O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.花_バラ_花弁2CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁4CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁3CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁1CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁5CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁6CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁8CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁7CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁9CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁11CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁10CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.花_バラ_花弁影CD = new ColorD(ref Col.Black, ref 体配色.薔O);
			this.萼_萼CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
		}

		public Par X0Y0_花_バラ_通常_花弁2;

		public Par X0Y0_花_バラ_通常_花弁4;

		public Par X0Y0_花_バラ_通常_花弁3;

		public Par X0Y0_花_バラ_通常_花弁1;

		public Par X0Y0_花_バラ_通常_花弁5;

		public Par X0Y0_花_バラ_通常_花弁6;

		public Par X0Y0_花_バラ_通常_花弁8;

		public Par X0Y0_花_バラ_通常_花弁7;

		public Par X0Y0_花_バラ_通常_花弁9;

		public Par X0Y0_花_バラ_通常_花弁11;

		public Par X0Y0_花_バラ_通常_花弁10;

		public Par X0Y0_花_バラ_通常_花弁影;

		public Par X0Y0_花_バラ_欠損_花弁2;

		public Par X0Y0_花_バラ_欠損_花弁4;

		public Par X0Y0_花_バラ_欠損_花弁3;

		public Par X0Y0_花_バラ_欠損_花弁1;

		public Par X0Y0_花_バラ_欠損_花弁5;

		public Par X0Y0_花_バラ_欠損_花弁6;

		public Par X0Y0_花_バラ_欠損_花弁8;

		public Par X0Y0_花_バラ_欠損_花弁7;

		public Par X0Y0_花_バラ_欠損_花弁9;

		public Par X0Y0_花_バラ_欠損_花弁11;

		public Par X0Y0_花_バラ_欠損_花弁10;

		public Par X0Y0_花_バラ_欠損_花弁影;

		public Par X0Y0_萼_通常_萼;

		public Par X0Y0_萼_欠損_萼;

		public ColorD 花_バラ_花弁2CD;

		public ColorD 花_バラ_花弁4CD;

		public ColorD 花_バラ_花弁3CD;

		public ColorD 花_バラ_花弁1CD;

		public ColorD 花_バラ_花弁5CD;

		public ColorD 花_バラ_花弁6CD;

		public ColorD 花_バラ_花弁8CD;

		public ColorD 花_バラ_花弁7CD;

		public ColorD 花_バラ_花弁9CD;

		public ColorD 花_バラ_花弁11CD;

		public ColorD 花_バラ_花弁10CD;

		public ColorD 花_バラ_花弁影CD;

		public ColorD 萼_萼CD;

		public ColorP X0Y0_花_バラ_通常_花弁2CP;

		public ColorP X0Y0_花_バラ_通常_花弁4CP;

		public ColorP X0Y0_花_バラ_通常_花弁3CP;

		public ColorP X0Y0_花_バラ_通常_花弁1CP;

		public ColorP X0Y0_花_バラ_通常_花弁5CP;

		public ColorP X0Y0_花_バラ_通常_花弁6CP;

		public ColorP X0Y0_花_バラ_通常_花弁8CP;

		public ColorP X0Y0_花_バラ_通常_花弁7CP;

		public ColorP X0Y0_花_バラ_通常_花弁9CP;

		public ColorP X0Y0_花_バラ_通常_花弁11CP;

		public ColorP X0Y0_花_バラ_通常_花弁10CP;

		public ColorP X0Y0_花_バラ_通常_花弁影CP;

		public ColorP X0Y0_花_バラ_欠損_花弁2CP;

		public ColorP X0Y0_花_バラ_欠損_花弁4CP;

		public ColorP X0Y0_花_バラ_欠損_花弁3CP;

		public ColorP X0Y0_花_バラ_欠損_花弁1CP;

		public ColorP X0Y0_花_バラ_欠損_花弁5CP;

		public ColorP X0Y0_花_バラ_欠損_花弁6CP;

		public ColorP X0Y0_花_バラ_欠損_花弁8CP;

		public ColorP X0Y0_花_バラ_欠損_花弁7CP;

		public ColorP X0Y0_花_バラ_欠損_花弁9CP;

		public ColorP X0Y0_花_バラ_欠損_花弁11CP;

		public ColorP X0Y0_花_バラ_欠損_花弁10CP;

		public ColorP X0Y0_花_バラ_欠損_花弁影CP;

		public ColorP X0Y0_萼_通常_萼CP;

		public ColorP X0Y0_萼_欠損_萼CP;
	}
}
