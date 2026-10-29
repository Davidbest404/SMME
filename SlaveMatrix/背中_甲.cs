using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 背中_甲 : 背中
	{
		public 背中_甲(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 背中_甲D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "甲羅";
			dif.Add(new Pars(Sta.肢中["背中"][0][1]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["左"].ToPars();
			this.X0Y0_左_甲羅1 = pars2["甲羅1"].ToPar();
			this.X0Y0_左_甲羅2 = pars2["甲羅2"].ToPar();
			Pars pars3 = pars2["鱗"].ToPars();
			this.X0Y0_左_鱗_鱗12 = pars3["鱗12"].ToPar();
			this.X0Y0_左_鱗_鱗11 = pars3["鱗11"].ToPar();
			this.X0Y0_左_鱗_鱗10 = pars3["鱗10"].ToPar();
			this.X0Y0_左_鱗_鱗9 = pars3["鱗9"].ToPar();
			this.X0Y0_左_鱗_鱗8 = pars3["鱗8"].ToPar();
			this.X0Y0_左_鱗_鱗7 = pars3["鱗7"].ToPar();
			this.X0Y0_左_鱗_鱗6 = pars3["鱗6"].ToPar();
			this.X0Y0_左_鱗_鱗5 = pars3["鱗5"].ToPar();
			this.X0Y0_左_鱗_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_左_鱗_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_左_鱗_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_左_鱗_鱗1 = pars3["鱗1"].ToPar();
			pars3 = pars2["側甲"].ToPars();
			this.X0Y0_左_側甲_側甲4 = pars3["側甲4"].ToPar();
			this.X0Y0_左_側甲_側甲3 = pars3["側甲3"].ToPar();
			this.X0Y0_左_側甲_側甲2 = pars3["側甲2"].ToPar();
			this.X0Y0_左_側甲_側甲1 = pars3["側甲1"].ToPar();
			pars2 = pars["右"].ToPars();
			this.X0Y0_右_甲羅1 = pars2["甲羅1"].ToPar();
			this.X0Y0_右_甲羅2 = pars2["甲羅2"].ToPar();
			pars3 = pars2["鱗"].ToPars();
			this.X0Y0_右_鱗_鱗12 = pars3["鱗12"].ToPar();
			this.X0Y0_右_鱗_鱗11 = pars3["鱗11"].ToPar();
			this.X0Y0_右_鱗_鱗10 = pars3["鱗10"].ToPar();
			this.X0Y0_右_鱗_鱗9 = pars3["鱗9"].ToPar();
			this.X0Y0_右_鱗_鱗8 = pars3["鱗8"].ToPar();
			this.X0Y0_右_鱗_鱗7 = pars3["鱗7"].ToPar();
			this.X0Y0_右_鱗_鱗6 = pars3["鱗6"].ToPar();
			this.X0Y0_右_鱗_鱗5 = pars3["鱗5"].ToPar();
			this.X0Y0_右_鱗_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_右_鱗_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_右_鱗_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_右_鱗_鱗1 = pars3["鱗1"].ToPar();
			pars3 = pars2["側甲"].ToPars();
			this.X0Y0_右_側甲_側甲4 = pars3["側甲4"].ToPar();
			this.X0Y0_右_側甲_側甲3 = pars3["側甲3"].ToPar();
			this.X0Y0_右_側甲_側甲2 = pars3["側甲2"].ToPar();
			this.X0Y0_右_側甲_側甲1 = pars3["側甲1"].ToPar();
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
			this.左_甲羅1_表示 = e.左_甲羅1_表示;
			this.左_甲羅2_表示 = e.左_甲羅2_表示;
			this.左_鱗_鱗12_表示 = e.左_鱗_鱗12_表示;
			this.左_鱗_鱗11_表示 = e.左_鱗_鱗11_表示;
			this.左_鱗_鱗10_表示 = e.左_鱗_鱗10_表示;
			this.左_鱗_鱗9_表示 = e.左_鱗_鱗9_表示;
			this.左_鱗_鱗8_表示 = e.左_鱗_鱗8_表示;
			this.左_鱗_鱗7_表示 = e.左_鱗_鱗7_表示;
			this.左_鱗_鱗6_表示 = e.左_鱗_鱗6_表示;
			this.左_鱗_鱗5_表示 = e.左_鱗_鱗5_表示;
			this.左_鱗_鱗4_表示 = e.左_鱗_鱗4_表示;
			this.左_鱗_鱗3_表示 = e.左_鱗_鱗3_表示;
			this.左_鱗_鱗2_表示 = e.左_鱗_鱗2_表示;
			this.左_鱗_鱗1_表示 = e.左_鱗_鱗1_表示;
			this.左_側甲_側甲4_表示 = e.左_側甲_側甲4_表示;
			this.左_側甲_側甲3_表示 = e.左_側甲_側甲3_表示;
			this.左_側甲_側甲2_表示 = e.左_側甲_側甲2_表示;
			this.左_側甲_側甲1_表示 = e.左_側甲_側甲1_表示;
			this.右_甲羅1_表示 = e.右_甲羅1_表示;
			this.右_甲羅2_表示 = e.右_甲羅2_表示;
			this.右_鱗_鱗12_表示 = e.右_鱗_鱗12_表示;
			this.右_鱗_鱗11_表示 = e.右_鱗_鱗11_表示;
			this.右_鱗_鱗10_表示 = e.右_鱗_鱗10_表示;
			this.右_鱗_鱗9_表示 = e.右_鱗_鱗9_表示;
			this.右_鱗_鱗8_表示 = e.右_鱗_鱗8_表示;
			this.右_鱗_鱗7_表示 = e.右_鱗_鱗7_表示;
			this.右_鱗_鱗6_表示 = e.右_鱗_鱗6_表示;
			this.右_鱗_鱗5_表示 = e.右_鱗_鱗5_表示;
			this.右_鱗_鱗4_表示 = e.右_鱗_鱗4_表示;
			this.右_鱗_鱗3_表示 = e.右_鱗_鱗3_表示;
			this.右_鱗_鱗2_表示 = e.右_鱗_鱗2_表示;
			this.右_鱗_鱗1_表示 = e.右_鱗_鱗1_表示;
			this.右_側甲_側甲4_表示 = e.右_側甲_側甲4_表示;
			this.右_側甲_側甲3_表示 = e.右_側甲_側甲3_表示;
			this.右_側甲_側甲2_表示 = e.右_側甲_側甲2_表示;
			this.右_側甲_側甲1_表示 = e.右_側甲_側甲1_表示;
			this.縁側角 = e.縁側角;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_左_甲羅1CP = new ColorP(this.X0Y0_左_甲羅1, this.左_甲羅1CD, DisUnit, true);
			this.X0Y0_左_甲羅2CP = new ColorP(this.X0Y0_左_甲羅2, this.左_甲羅2CD, DisUnit, true);
			this.X0Y0_左_鱗_鱗12CP = new ColorP(this.X0Y0_左_鱗_鱗12, this.左_鱗_鱗12CD, DisUnit, true);
			this.X0Y0_左_鱗_鱗11CP = new ColorP(this.X0Y0_左_鱗_鱗11, this.左_鱗_鱗11CD, DisUnit, true);
			this.X0Y0_左_鱗_鱗10CP = new ColorP(this.X0Y0_左_鱗_鱗10, this.左_鱗_鱗10CD, DisUnit, true);
			this.X0Y0_左_鱗_鱗9CP = new ColorP(this.X0Y0_左_鱗_鱗9, this.左_鱗_鱗9CD, DisUnit, true);
			this.X0Y0_左_鱗_鱗8CP = new ColorP(this.X0Y0_左_鱗_鱗8, this.左_鱗_鱗8CD, DisUnit, true);
			this.X0Y0_左_鱗_鱗7CP = new ColorP(this.X0Y0_左_鱗_鱗7, this.左_鱗_鱗7CD, DisUnit, true);
			this.X0Y0_左_鱗_鱗6CP = new ColorP(this.X0Y0_左_鱗_鱗6, this.左_鱗_鱗6CD, DisUnit, true);
			this.X0Y0_左_鱗_鱗5CP = new ColorP(this.X0Y0_左_鱗_鱗5, this.左_鱗_鱗5CD, DisUnit, true);
			this.X0Y0_左_鱗_鱗4CP = new ColorP(this.X0Y0_左_鱗_鱗4, this.左_鱗_鱗4CD, DisUnit, true);
			this.X0Y0_左_鱗_鱗3CP = new ColorP(this.X0Y0_左_鱗_鱗3, this.左_鱗_鱗3CD, DisUnit, true);
			this.X0Y0_左_鱗_鱗2CP = new ColorP(this.X0Y0_左_鱗_鱗2, this.左_鱗_鱗2CD, DisUnit, true);
			this.X0Y0_左_鱗_鱗1CP = new ColorP(this.X0Y0_左_鱗_鱗1, this.左_鱗_鱗1CD, DisUnit, true);
			this.X0Y0_左_側甲_側甲4CP = new ColorP(this.X0Y0_左_側甲_側甲4, this.左_側甲_側甲4CD, DisUnit, true);
			this.X0Y0_左_側甲_側甲3CP = new ColorP(this.X0Y0_左_側甲_側甲3, this.左_側甲_側甲3CD, DisUnit, true);
			this.X0Y0_左_側甲_側甲2CP = new ColorP(this.X0Y0_左_側甲_側甲2, this.左_側甲_側甲2CD, DisUnit, true);
			this.X0Y0_左_側甲_側甲1CP = new ColorP(this.X0Y0_左_側甲_側甲1, this.左_側甲_側甲1CD, DisUnit, true);
			this.X0Y0_右_甲羅1CP = new ColorP(this.X0Y0_右_甲羅1, this.右_甲羅1CD, DisUnit, true);
			this.X0Y0_右_甲羅2CP = new ColorP(this.X0Y0_右_甲羅2, this.右_甲羅2CD, DisUnit, true);
			this.X0Y0_右_鱗_鱗12CP = new ColorP(this.X0Y0_右_鱗_鱗12, this.右_鱗_鱗12CD, DisUnit, true);
			this.X0Y0_右_鱗_鱗11CP = new ColorP(this.X0Y0_右_鱗_鱗11, this.右_鱗_鱗11CD, DisUnit, true);
			this.X0Y0_右_鱗_鱗10CP = new ColorP(this.X0Y0_右_鱗_鱗10, this.右_鱗_鱗10CD, DisUnit, true);
			this.X0Y0_右_鱗_鱗9CP = new ColorP(this.X0Y0_右_鱗_鱗9, this.右_鱗_鱗9CD, DisUnit, true);
			this.X0Y0_右_鱗_鱗8CP = new ColorP(this.X0Y0_右_鱗_鱗8, this.右_鱗_鱗8CD, DisUnit, true);
			this.X0Y0_右_鱗_鱗7CP = new ColorP(this.X0Y0_右_鱗_鱗7, this.右_鱗_鱗7CD, DisUnit, true);
			this.X0Y0_右_鱗_鱗6CP = new ColorP(this.X0Y0_右_鱗_鱗6, this.右_鱗_鱗6CD, DisUnit, true);
			this.X0Y0_右_鱗_鱗5CP = new ColorP(this.X0Y0_右_鱗_鱗5, this.右_鱗_鱗5CD, DisUnit, true);
			this.X0Y0_右_鱗_鱗4CP = new ColorP(this.X0Y0_右_鱗_鱗4, this.右_鱗_鱗4CD, DisUnit, true);
			this.X0Y0_右_鱗_鱗3CP = new ColorP(this.X0Y0_右_鱗_鱗3, this.右_鱗_鱗3CD, DisUnit, true);
			this.X0Y0_右_鱗_鱗2CP = new ColorP(this.X0Y0_右_鱗_鱗2, this.右_鱗_鱗2CD, DisUnit, true);
			this.X0Y0_右_鱗_鱗1CP = new ColorP(this.X0Y0_右_鱗_鱗1, this.右_鱗_鱗1CD, DisUnit, true);
			this.X0Y0_右_側甲_側甲4CP = new ColorP(this.X0Y0_右_側甲_側甲4, this.右_側甲_側甲4CD, DisUnit, true);
			this.X0Y0_右_側甲_側甲3CP = new ColorP(this.X0Y0_右_側甲_側甲3, this.右_側甲_側甲3CD, DisUnit, true);
			this.X0Y0_右_側甲_側甲2CP = new ColorP(this.X0Y0_右_側甲_側甲2, this.右_側甲_側甲2CD, DisUnit, true);
			this.X0Y0_右_側甲_側甲1CP = new ColorP(this.X0Y0_右_側甲_側甲1, this.右_側甲_側甲1CD, DisUnit, true);
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

		public bool 左_甲羅1_表示
		{
			get
			{
				return this.X0Y0_左_甲羅1.Dra;
			}
			set
			{
				this.X0Y0_左_甲羅1.Dra = value;
				this.X0Y0_左_甲羅1.Hit = value;
			}
		}

		public bool 左_甲羅2_表示
		{
			get
			{
				return this.X0Y0_左_甲羅2.Dra;
			}
			set
			{
				this.X0Y0_左_甲羅2.Dra = value;
				this.X0Y0_左_甲羅2.Hit = value;
			}
		}

		public bool 左_鱗_鱗12_表示
		{
			get
			{
				return this.X0Y0_左_鱗_鱗12.Dra;
			}
			set
			{
				this.X0Y0_左_鱗_鱗12.Dra = value;
				this.X0Y0_左_鱗_鱗12.Hit = value;
			}
		}

		public bool 左_鱗_鱗11_表示
		{
			get
			{
				return this.X0Y0_左_鱗_鱗11.Dra;
			}
			set
			{
				this.X0Y0_左_鱗_鱗11.Dra = value;
				this.X0Y0_左_鱗_鱗11.Hit = value;
			}
		}

		public bool 左_鱗_鱗10_表示
		{
			get
			{
				return this.X0Y0_左_鱗_鱗10.Dra;
			}
			set
			{
				this.X0Y0_左_鱗_鱗10.Dra = value;
				this.X0Y0_左_鱗_鱗10.Hit = value;
			}
		}

		public bool 左_鱗_鱗9_表示
		{
			get
			{
				return this.X0Y0_左_鱗_鱗9.Dra;
			}
			set
			{
				this.X0Y0_左_鱗_鱗9.Dra = value;
				this.X0Y0_左_鱗_鱗9.Hit = value;
			}
		}

		public bool 左_鱗_鱗8_表示
		{
			get
			{
				return this.X0Y0_左_鱗_鱗8.Dra;
			}
			set
			{
				this.X0Y0_左_鱗_鱗8.Dra = value;
				this.X0Y0_左_鱗_鱗8.Hit = value;
			}
		}

		public bool 左_鱗_鱗7_表示
		{
			get
			{
				return this.X0Y0_左_鱗_鱗7.Dra;
			}
			set
			{
				this.X0Y0_左_鱗_鱗7.Dra = value;
				this.X0Y0_左_鱗_鱗7.Hit = value;
			}
		}

		public bool 左_鱗_鱗6_表示
		{
			get
			{
				return this.X0Y0_左_鱗_鱗6.Dra;
			}
			set
			{
				this.X0Y0_左_鱗_鱗6.Dra = value;
				this.X0Y0_左_鱗_鱗6.Hit = value;
			}
		}

		public bool 左_鱗_鱗5_表示
		{
			get
			{
				return this.X0Y0_左_鱗_鱗5.Dra;
			}
			set
			{
				this.X0Y0_左_鱗_鱗5.Dra = value;
				this.X0Y0_左_鱗_鱗5.Hit = value;
			}
		}

		public bool 左_鱗_鱗4_表示
		{
			get
			{
				return this.X0Y0_左_鱗_鱗4.Dra;
			}
			set
			{
				this.X0Y0_左_鱗_鱗4.Dra = value;
				this.X0Y0_左_鱗_鱗4.Hit = value;
			}
		}

		public bool 左_鱗_鱗3_表示
		{
			get
			{
				return this.X0Y0_左_鱗_鱗3.Dra;
			}
			set
			{
				this.X0Y0_左_鱗_鱗3.Dra = value;
				this.X0Y0_左_鱗_鱗3.Hit = value;
			}
		}

		public bool 左_鱗_鱗2_表示
		{
			get
			{
				return this.X0Y0_左_鱗_鱗2.Dra;
			}
			set
			{
				this.X0Y0_左_鱗_鱗2.Dra = value;
				this.X0Y0_左_鱗_鱗2.Hit = value;
			}
		}

		public bool 左_鱗_鱗1_表示
		{
			get
			{
				return this.X0Y0_左_鱗_鱗1.Dra;
			}
			set
			{
				this.X0Y0_左_鱗_鱗1.Dra = value;
				this.X0Y0_左_鱗_鱗1.Hit = value;
			}
		}

		public bool 左_側甲_側甲4_表示
		{
			get
			{
				return this.X0Y0_左_側甲_側甲4.Dra;
			}
			set
			{
				this.X0Y0_左_側甲_側甲4.Dra = value;
				this.X0Y0_左_側甲_側甲4.Hit = value;
			}
		}

		public bool 左_側甲_側甲3_表示
		{
			get
			{
				return this.X0Y0_左_側甲_側甲3.Dra;
			}
			set
			{
				this.X0Y0_左_側甲_側甲3.Dra = value;
				this.X0Y0_左_側甲_側甲3.Hit = value;
			}
		}

		public bool 左_側甲_側甲2_表示
		{
			get
			{
				return this.X0Y0_左_側甲_側甲2.Dra;
			}
			set
			{
				this.X0Y0_左_側甲_側甲2.Dra = value;
				this.X0Y0_左_側甲_側甲2.Hit = value;
			}
		}

		public bool 左_側甲_側甲1_表示
		{
			get
			{
				return this.X0Y0_左_側甲_側甲1.Dra;
			}
			set
			{
				this.X0Y0_左_側甲_側甲1.Dra = value;
				this.X0Y0_左_側甲_側甲1.Hit = value;
			}
		}

		public bool 右_甲羅1_表示
		{
			get
			{
				return this.X0Y0_右_甲羅1.Dra;
			}
			set
			{
				this.X0Y0_右_甲羅1.Dra = value;
				this.X0Y0_右_甲羅1.Hit = value;
			}
		}

		public bool 右_甲羅2_表示
		{
			get
			{
				return this.X0Y0_右_甲羅2.Dra;
			}
			set
			{
				this.X0Y0_右_甲羅2.Dra = value;
				this.X0Y0_右_甲羅2.Hit = value;
			}
		}

		public bool 右_鱗_鱗12_表示
		{
			get
			{
				return this.X0Y0_右_鱗_鱗12.Dra;
			}
			set
			{
				this.X0Y0_右_鱗_鱗12.Dra = value;
				this.X0Y0_右_鱗_鱗12.Hit = value;
			}
		}

		public bool 右_鱗_鱗11_表示
		{
			get
			{
				return this.X0Y0_右_鱗_鱗11.Dra;
			}
			set
			{
				this.X0Y0_右_鱗_鱗11.Dra = value;
				this.X0Y0_右_鱗_鱗11.Hit = value;
			}
		}

		public bool 右_鱗_鱗10_表示
		{
			get
			{
				return this.X0Y0_右_鱗_鱗10.Dra;
			}
			set
			{
				this.X0Y0_右_鱗_鱗10.Dra = value;
				this.X0Y0_右_鱗_鱗10.Hit = value;
			}
		}

		public bool 右_鱗_鱗9_表示
		{
			get
			{
				return this.X0Y0_右_鱗_鱗9.Dra;
			}
			set
			{
				this.X0Y0_右_鱗_鱗9.Dra = value;
				this.X0Y0_右_鱗_鱗9.Hit = value;
			}
		}

		public bool 右_鱗_鱗8_表示
		{
			get
			{
				return this.X0Y0_右_鱗_鱗8.Dra;
			}
			set
			{
				this.X0Y0_右_鱗_鱗8.Dra = value;
				this.X0Y0_右_鱗_鱗8.Hit = value;
			}
		}

		public bool 右_鱗_鱗7_表示
		{
			get
			{
				return this.X0Y0_右_鱗_鱗7.Dra;
			}
			set
			{
				this.X0Y0_右_鱗_鱗7.Dra = value;
				this.X0Y0_右_鱗_鱗7.Hit = value;
			}
		}

		public bool 右_鱗_鱗6_表示
		{
			get
			{
				return this.X0Y0_右_鱗_鱗6.Dra;
			}
			set
			{
				this.X0Y0_右_鱗_鱗6.Dra = value;
				this.X0Y0_右_鱗_鱗6.Hit = value;
			}
		}

		public bool 右_鱗_鱗5_表示
		{
			get
			{
				return this.X0Y0_右_鱗_鱗5.Dra;
			}
			set
			{
				this.X0Y0_右_鱗_鱗5.Dra = value;
				this.X0Y0_右_鱗_鱗5.Hit = value;
			}
		}

		public bool 右_鱗_鱗4_表示
		{
			get
			{
				return this.X0Y0_右_鱗_鱗4.Dra;
			}
			set
			{
				this.X0Y0_右_鱗_鱗4.Dra = value;
				this.X0Y0_右_鱗_鱗4.Hit = value;
			}
		}

		public bool 右_鱗_鱗3_表示
		{
			get
			{
				return this.X0Y0_右_鱗_鱗3.Dra;
			}
			set
			{
				this.X0Y0_右_鱗_鱗3.Dra = value;
				this.X0Y0_右_鱗_鱗3.Hit = value;
			}
		}

		public bool 右_鱗_鱗2_表示
		{
			get
			{
				return this.X0Y0_右_鱗_鱗2.Dra;
			}
			set
			{
				this.X0Y0_右_鱗_鱗2.Dra = value;
				this.X0Y0_右_鱗_鱗2.Hit = value;
			}
		}

		public bool 右_鱗_鱗1_表示
		{
			get
			{
				return this.X0Y0_右_鱗_鱗1.Dra;
			}
			set
			{
				this.X0Y0_右_鱗_鱗1.Dra = value;
				this.X0Y0_右_鱗_鱗1.Hit = value;
			}
		}

		public bool 右_側甲_側甲4_表示
		{
			get
			{
				return this.X0Y0_右_側甲_側甲4.Dra;
			}
			set
			{
				this.X0Y0_右_側甲_側甲4.Dra = value;
				this.X0Y0_右_側甲_側甲4.Hit = value;
			}
		}

		public bool 右_側甲_側甲3_表示
		{
			get
			{
				return this.X0Y0_右_側甲_側甲3.Dra;
			}
			set
			{
				this.X0Y0_右_側甲_側甲3.Dra = value;
				this.X0Y0_右_側甲_側甲3.Hit = value;
			}
		}

		public bool 右_側甲_側甲2_表示
		{
			get
			{
				return this.X0Y0_右_側甲_側甲2.Dra;
			}
			set
			{
				this.X0Y0_右_側甲_側甲2.Dra = value;
				this.X0Y0_右_側甲_側甲2.Hit = value;
			}
		}

		public bool 右_側甲_側甲1_表示
		{
			get
			{
				return this.X0Y0_右_側甲_側甲1.Dra;
			}
			set
			{
				this.X0Y0_右_側甲_側甲1.Dra = value;
				this.X0Y0_右_側甲_側甲1.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.左_甲羅1_表示;
			}
			set
			{
				this.左_甲羅1_表示 = value;
				this.左_甲羅2_表示 = value;
				this.左_鱗_鱗12_表示 = value;
				this.左_鱗_鱗11_表示 = value;
				this.左_鱗_鱗10_表示 = value;
				this.左_鱗_鱗9_表示 = value;
				this.左_鱗_鱗8_表示 = value;
				this.左_鱗_鱗7_表示 = value;
				this.左_鱗_鱗6_表示 = value;
				this.左_鱗_鱗5_表示 = value;
				this.左_鱗_鱗4_表示 = value;
				this.左_鱗_鱗3_表示 = value;
				this.左_鱗_鱗2_表示 = value;
				this.左_鱗_鱗1_表示 = value;
				this.左_側甲_側甲4_表示 = value;
				this.左_側甲_側甲3_表示 = value;
				this.左_側甲_側甲2_表示 = value;
				this.左_側甲_側甲1_表示 = value;
				this.右_甲羅1_表示 = value;
				this.右_甲羅2_表示 = value;
				this.右_鱗_鱗12_表示 = value;
				this.右_鱗_鱗11_表示 = value;
				this.右_鱗_鱗10_表示 = value;
				this.右_鱗_鱗9_表示 = value;
				this.右_鱗_鱗8_表示 = value;
				this.右_鱗_鱗7_表示 = value;
				this.右_鱗_鱗6_表示 = value;
				this.右_鱗_鱗5_表示 = value;
				this.右_鱗_鱗4_表示 = value;
				this.右_鱗_鱗3_表示 = value;
				this.右_鱗_鱗2_表示 = value;
				this.右_鱗_鱗1_表示 = value;
				this.右_側甲_側甲4_表示 = value;
				this.右_側甲_側甲3_表示 = value;
				this.右_側甲_側甲2_表示 = value;
				this.右_側甲_側甲1_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.左_甲羅1CD.不透明度;
			}
			set
			{
				this.左_甲羅1CD.不透明度 = value;
				this.左_甲羅2CD.不透明度 = value;
				this.左_鱗_鱗12CD.不透明度 = value;
				this.左_鱗_鱗11CD.不透明度 = value;
				this.左_鱗_鱗10CD.不透明度 = value;
				this.左_鱗_鱗9CD.不透明度 = value;
				this.左_鱗_鱗8CD.不透明度 = value;
				this.左_鱗_鱗7CD.不透明度 = value;
				this.左_鱗_鱗6CD.不透明度 = value;
				this.左_鱗_鱗5CD.不透明度 = value;
				this.左_鱗_鱗4CD.不透明度 = value;
				this.左_鱗_鱗3CD.不透明度 = value;
				this.左_鱗_鱗2CD.不透明度 = value;
				this.左_鱗_鱗1CD.不透明度 = value;
				this.左_側甲_側甲4CD.不透明度 = value;
				this.左_側甲_側甲3CD.不透明度 = value;
				this.左_側甲_側甲2CD.不透明度 = value;
				this.左_側甲_側甲1CD.不透明度 = value;
				this.右_甲羅1CD.不透明度 = value;
				this.右_甲羅2CD.不透明度 = value;
				this.右_鱗_鱗12CD.不透明度 = value;
				this.右_鱗_鱗11CD.不透明度 = value;
				this.右_鱗_鱗10CD.不透明度 = value;
				this.右_鱗_鱗9CD.不透明度 = value;
				this.右_鱗_鱗8CD.不透明度 = value;
				this.右_鱗_鱗7CD.不透明度 = value;
				this.右_鱗_鱗6CD.不透明度 = value;
				this.右_鱗_鱗5CD.不透明度 = value;
				this.右_鱗_鱗4CD.不透明度 = value;
				this.右_鱗_鱗3CD.不透明度 = value;
				this.右_鱗_鱗2CD.不透明度 = value;
				this.右_鱗_鱗1CD.不透明度 = value;
				this.右_側甲_側甲4CD.不透明度 = value;
				this.右_側甲_側甲3CD.不透明度 = value;
				this.右_側甲_側甲2CD.不透明度 = value;
				this.右_側甲_側甲1CD.不透明度 = value;
			}
		}

		public double 縁側角
		{
			set
			{
				double num = 15.0 * value;
				this.X0Y0_左_鱗_鱗12.AngleBase = num;
				this.X0Y0_左_鱗_鱗11.AngleBase = num;
				this.X0Y0_左_鱗_鱗10.AngleBase = num;
				this.X0Y0_左_鱗_鱗9.AngleBase = num;
				this.X0Y0_左_鱗_鱗8.AngleBase = num;
				this.X0Y0_左_鱗_鱗7.AngleBase = num;
				this.X0Y0_左_鱗_鱗6.AngleBase = num;
				this.X0Y0_右_鱗_鱗12.AngleBase = -num;
				this.X0Y0_右_鱗_鱗11.AngleBase = -num;
				this.X0Y0_右_鱗_鱗10.AngleBase = -num;
				this.X0Y0_右_鱗_鱗9.AngleBase = -num;
				this.X0Y0_右_鱗_鱗8.AngleBase = -num;
				this.X0Y0_右_鱗_鱗7.AngleBase = -num;
				this.X0Y0_右_鱗_鱗6.AngleBase = -num;
			}
		}

		public override double 肥大
		{
			set
			{
			}
		}

		public override double 身長
		{
			set
			{
			}
		}

		public override void 色更新()
		{
			this.X0Y0_左_甲羅1CP.Update();
			this.X0Y0_左_甲羅2CP.Update();
			this.X0Y0_左_鱗_鱗12CP.Update();
			this.X0Y0_左_鱗_鱗11CP.Update();
			this.X0Y0_左_鱗_鱗10CP.Update();
			this.X0Y0_左_鱗_鱗9CP.Update();
			this.X0Y0_左_鱗_鱗8CP.Update();
			this.X0Y0_左_鱗_鱗7CP.Update();
			this.X0Y0_左_鱗_鱗6CP.Update();
			this.X0Y0_左_鱗_鱗5CP.Update();
			this.X0Y0_左_鱗_鱗4CP.Update();
			this.X0Y0_左_鱗_鱗3CP.Update();
			this.X0Y0_左_鱗_鱗2CP.Update();
			this.X0Y0_左_鱗_鱗1CP.Update();
			this.X0Y0_左_側甲_側甲4CP.Update();
			this.X0Y0_左_側甲_側甲3CP.Update();
			this.X0Y0_左_側甲_側甲2CP.Update();
			this.X0Y0_左_側甲_側甲1CP.Update();
			this.X0Y0_右_甲羅1CP.Update();
			this.X0Y0_右_甲羅2CP.Update();
			this.X0Y0_右_鱗_鱗12CP.Update();
			this.X0Y0_右_鱗_鱗11CP.Update();
			this.X0Y0_右_鱗_鱗10CP.Update();
			this.X0Y0_右_鱗_鱗9CP.Update();
			this.X0Y0_右_鱗_鱗8CP.Update();
			this.X0Y0_右_鱗_鱗7CP.Update();
			this.X0Y0_右_鱗_鱗6CP.Update();
			this.X0Y0_右_鱗_鱗5CP.Update();
			this.X0Y0_右_鱗_鱗4CP.Update();
			this.X0Y0_右_鱗_鱗3CP.Update();
			this.X0Y0_右_鱗_鱗2CP.Update();
			this.X0Y0_右_鱗_鱗1CP.Update();
			this.X0Y0_右_側甲_側甲4CP.Update();
			this.X0Y0_右_側甲_側甲3CP.Update();
			this.X0Y0_右_側甲_側甲2CP.Update();
			this.X0Y0_右_側甲_側甲1CP.Update();
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
			this.左_甲羅1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_甲羅2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗12CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗11CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗10CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗9CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗8CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_側甲_側甲4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.左_側甲_側甲3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.左_側甲_側甲2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.左_側甲_側甲1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.右_甲羅1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_甲羅2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗12CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗11CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗10CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗9CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗8CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_側甲_側甲4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.右_側甲_側甲3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.右_側甲_側甲2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.右_側甲_側甲1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.左_甲羅1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_甲羅2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗12CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.左_鱗_鱗11CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗10CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.左_鱗_鱗9CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗8CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.左_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.左_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.左_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.左_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_側甲_側甲4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.左_側甲_側甲3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.左_側甲_側甲2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.左_側甲_側甲1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.右_甲羅1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_甲羅2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗12CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.右_鱗_鱗11CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗10CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.右_鱗_鱗9CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗8CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.右_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.右_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.右_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.右_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_側甲_側甲4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.右_側甲_側甲3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.右_側甲_側甲2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.右_側甲_側甲1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.左_甲羅1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_甲羅2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗12CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗11CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.左_鱗_鱗10CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗9CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.左_鱗_鱗8CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.左_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.左_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.左_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.左_側甲_側甲4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.左_側甲_側甲3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.左_側甲_側甲2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.左_側甲_側甲1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.右_甲羅1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_甲羅2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗12CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗11CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.右_鱗_鱗10CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗9CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.右_鱗_鱗8CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.右_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.右_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.右_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.右_側甲_側甲4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.右_側甲_側甲3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.右_側甲_側甲2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.右_側甲_側甲1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
		}

		public Par X0Y0_左_甲羅1;

		public Par X0Y0_左_甲羅2;

		public Par X0Y0_左_鱗_鱗12;

		public Par X0Y0_左_鱗_鱗11;

		public Par X0Y0_左_鱗_鱗10;

		public Par X0Y0_左_鱗_鱗9;

		public Par X0Y0_左_鱗_鱗8;

		public Par X0Y0_左_鱗_鱗7;

		public Par X0Y0_左_鱗_鱗6;

		public Par X0Y0_左_鱗_鱗5;

		public Par X0Y0_左_鱗_鱗4;

		public Par X0Y0_左_鱗_鱗3;

		public Par X0Y0_左_鱗_鱗2;

		public Par X0Y0_左_鱗_鱗1;

		public Par X0Y0_左_側甲_側甲4;

		public Par X0Y0_左_側甲_側甲3;

		public Par X0Y0_左_側甲_側甲2;

		public Par X0Y0_左_側甲_側甲1;

		public Par X0Y0_右_甲羅1;

		public Par X0Y0_右_甲羅2;

		public Par X0Y0_右_鱗_鱗12;

		public Par X0Y0_右_鱗_鱗11;

		public Par X0Y0_右_鱗_鱗10;

		public Par X0Y0_右_鱗_鱗9;

		public Par X0Y0_右_鱗_鱗8;

		public Par X0Y0_右_鱗_鱗7;

		public Par X0Y0_右_鱗_鱗6;

		public Par X0Y0_右_鱗_鱗5;

		public Par X0Y0_右_鱗_鱗4;

		public Par X0Y0_右_鱗_鱗3;

		public Par X0Y0_右_鱗_鱗2;

		public Par X0Y0_右_鱗_鱗1;

		public Par X0Y0_右_側甲_側甲4;

		public Par X0Y0_右_側甲_側甲3;

		public Par X0Y0_右_側甲_側甲2;

		public Par X0Y0_右_側甲_側甲1;

		public ColorD 左_甲羅1CD;

		public ColorD 左_甲羅2CD;

		public ColorD 左_鱗_鱗12CD;

		public ColorD 左_鱗_鱗11CD;

		public ColorD 左_鱗_鱗10CD;

		public ColorD 左_鱗_鱗9CD;

		public ColorD 左_鱗_鱗8CD;

		public ColorD 左_鱗_鱗7CD;

		public ColorD 左_鱗_鱗6CD;

		public ColorD 左_鱗_鱗5CD;

		public ColorD 左_鱗_鱗4CD;

		public ColorD 左_鱗_鱗3CD;

		public ColorD 左_鱗_鱗2CD;

		public ColorD 左_鱗_鱗1CD;

		public ColorD 左_側甲_側甲4CD;

		public ColorD 左_側甲_側甲3CD;

		public ColorD 左_側甲_側甲2CD;

		public ColorD 左_側甲_側甲1CD;

		public ColorD 右_甲羅1CD;

		public ColorD 右_甲羅2CD;

		public ColorD 右_鱗_鱗12CD;

		public ColorD 右_鱗_鱗11CD;

		public ColorD 右_鱗_鱗10CD;

		public ColorD 右_鱗_鱗9CD;

		public ColorD 右_鱗_鱗8CD;

		public ColorD 右_鱗_鱗7CD;

		public ColorD 右_鱗_鱗6CD;

		public ColorD 右_鱗_鱗5CD;

		public ColorD 右_鱗_鱗4CD;

		public ColorD 右_鱗_鱗3CD;

		public ColorD 右_鱗_鱗2CD;

		public ColorD 右_鱗_鱗1CD;

		public ColorD 右_側甲_側甲4CD;

		public ColorD 右_側甲_側甲3CD;

		public ColorD 右_側甲_側甲2CD;

		public ColorD 右_側甲_側甲1CD;

		public ColorP X0Y0_左_甲羅1CP;

		public ColorP X0Y0_左_甲羅2CP;

		public ColorP X0Y0_左_鱗_鱗12CP;

		public ColorP X0Y0_左_鱗_鱗11CP;

		public ColorP X0Y0_左_鱗_鱗10CP;

		public ColorP X0Y0_左_鱗_鱗9CP;

		public ColorP X0Y0_左_鱗_鱗8CP;

		public ColorP X0Y0_左_鱗_鱗7CP;

		public ColorP X0Y0_左_鱗_鱗6CP;

		public ColorP X0Y0_左_鱗_鱗5CP;

		public ColorP X0Y0_左_鱗_鱗4CP;

		public ColorP X0Y0_左_鱗_鱗3CP;

		public ColorP X0Y0_左_鱗_鱗2CP;

		public ColorP X0Y0_左_鱗_鱗1CP;

		public ColorP X0Y0_左_側甲_側甲4CP;

		public ColorP X0Y0_左_側甲_側甲3CP;

		public ColorP X0Y0_左_側甲_側甲2CP;

		public ColorP X0Y0_左_側甲_側甲1CP;

		public ColorP X0Y0_右_甲羅1CP;

		public ColorP X0Y0_右_甲羅2CP;

		public ColorP X0Y0_右_鱗_鱗12CP;

		public ColorP X0Y0_右_鱗_鱗11CP;

		public ColorP X0Y0_右_鱗_鱗10CP;

		public ColorP X0Y0_右_鱗_鱗9CP;

		public ColorP X0Y0_右_鱗_鱗8CP;

		public ColorP X0Y0_右_鱗_鱗7CP;

		public ColorP X0Y0_右_鱗_鱗6CP;

		public ColorP X0Y0_右_鱗_鱗5CP;

		public ColorP X0Y0_右_鱗_鱗4CP;

		public ColorP X0Y0_右_鱗_鱗3CP;

		public ColorP X0Y0_右_鱗_鱗2CP;

		public ColorP X0Y0_右_鱗_鱗1CP;

		public ColorP X0Y0_右_側甲_側甲4CP;

		public ColorP X0Y0_右_側甲_側甲3CP;

		public ColorP X0Y0_右_側甲_側甲2CP;

		public ColorP X0Y0_右_側甲_側甲1CP;
	}
}
