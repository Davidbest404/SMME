using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 尾_馬 : 尾
	{
		public 尾_馬(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 尾_馬D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "馬尾";
			dif.Add(new Pars(Sta.尻尾["尾"][0][3]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_尾0 = pars["尾0"].ToPar();
			this.X0Y0_尾1 = pars["尾1"].ToPar();
			this.X0Y0_尾2 = pars["尾2"].ToPar();
			this.X0Y0_尾3 = pars["尾3"].ToPar();
			this.X0Y0_尾4 = pars["尾4"].ToPar();
			Pars pars2 = pars["中央"].ToPars();
			this.X0Y0_中央_尾0 = pars2["尾0"].ToPar();
			this.X0Y0_中央_尾1 = pars2["尾1"].ToPar();
			this.X0Y0_中央_尾2 = pars2["尾2"].ToPar();
			this.X0Y0_中央_尾3 = pars2["尾3"].ToPar();
			this.X0Y0_中央_尾4 = pars2["尾4"].ToPar();
			this.X0Y0_中央_尾5 = pars2["尾5"].ToPar();
			this.X0Y0_中央_尾6 = pars2["尾6"].ToPar();
			pars2 = pars["左2"].ToPars();
			this.X0Y0_左2_尾0 = pars2["尾0"].ToPar();
			this.X0Y0_左2_尾1 = pars2["尾1"].ToPar();
			this.X0Y0_左2_尾2 = pars2["尾2"].ToPar();
			this.X0Y0_左2_尾3 = pars2["尾3"].ToPar();
			this.X0Y0_左2_尾4 = pars2["尾4"].ToPar();
			this.X0Y0_左2_尾5 = pars2["尾5"].ToPar();
			this.X0Y0_左2_尾6 = pars2["尾6"].ToPar();
			pars2 = pars["左1"].ToPars();
			this.X0Y0_左1_尾0 = pars2["尾0"].ToPar();
			this.X0Y0_左1_尾1 = pars2["尾1"].ToPar();
			this.X0Y0_左1_尾2 = pars2["尾2"].ToPar();
			this.X0Y0_左1_尾3 = pars2["尾3"].ToPar();
			this.X0Y0_左1_尾4 = pars2["尾4"].ToPar();
			this.X0Y0_左1_尾5 = pars2["尾5"].ToPar();
			this.X0Y0_左1_尾6 = pars2["尾6"].ToPar();
			pars2 = pars["右2"].ToPars();
			this.X0Y0_右2_尾0 = pars2["尾0"].ToPar();
			this.X0Y0_右2_尾1 = pars2["尾1"].ToPar();
			this.X0Y0_右2_尾2 = pars2["尾2"].ToPar();
			this.X0Y0_右2_尾3 = pars2["尾3"].ToPar();
			this.X0Y0_右2_尾4 = pars2["尾4"].ToPar();
			this.X0Y0_右2_尾5 = pars2["尾5"].ToPar();
			this.X0Y0_右2_尾6 = pars2["尾6"].ToPar();
			pars2 = pars["右1"].ToPars();
			this.X0Y0_右1_尾0 = pars2["尾0"].ToPar();
			this.X0Y0_右1_尾1 = pars2["尾1"].ToPar();
			this.X0Y0_右1_尾2 = pars2["尾2"].ToPar();
			this.X0Y0_右1_尾3 = pars2["尾3"].ToPar();
			this.X0Y0_右1_尾4 = pars2["尾4"].ToPar();
			this.X0Y0_右1_尾5 = pars2["尾5"].ToPar();
			this.X0Y0_右1_尾6 = pars2["尾6"].ToPar();
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
			this.尾0_表示 = e.尾0_表示;
			this.尾1_表示 = e.尾1_表示;
			this.尾2_表示 = e.尾2_表示;
			this.尾3_表示 = e.尾3_表示;
			this.尾4_表示 = e.尾4_表示;
			this.中央_尾0_表示 = e.中央_尾0_表示;
			this.中央_尾1_表示 = e.中央_尾1_表示;
			this.中央_尾2_表示 = e.中央_尾2_表示;
			this.中央_尾3_表示 = e.中央_尾3_表示;
			this.中央_尾4_表示 = e.中央_尾4_表示;
			this.中央_尾5_表示 = e.中央_尾5_表示;
			this.中央_尾6_表示 = e.中央_尾6_表示;
			this.左2_尾0_表示 = e.左2_尾0_表示;
			this.左2_尾1_表示 = e.左2_尾1_表示;
			this.左2_尾2_表示 = e.左2_尾2_表示;
			this.左2_尾3_表示 = e.左2_尾3_表示;
			this.左2_尾4_表示 = e.左2_尾4_表示;
			this.左2_尾5_表示 = e.左2_尾5_表示;
			this.左2_尾6_表示 = e.左2_尾6_表示;
			this.左1_尾0_表示 = e.左1_尾0_表示;
			this.左1_尾1_表示 = e.左1_尾1_表示;
			this.左1_尾2_表示 = e.左1_尾2_表示;
			this.左1_尾3_表示 = e.左1_尾3_表示;
			this.左1_尾4_表示 = e.左1_尾4_表示;
			this.左1_尾5_表示 = e.左1_尾5_表示;
			this.左1_尾6_表示 = e.左1_尾6_表示;
			this.右2_尾0_表示 = e.右2_尾0_表示;
			this.右2_尾1_表示 = e.右2_尾1_表示;
			this.右2_尾2_表示 = e.右2_尾2_表示;
			this.右2_尾3_表示 = e.右2_尾3_表示;
			this.右2_尾4_表示 = e.右2_尾4_表示;
			this.右2_尾5_表示 = e.右2_尾5_表示;
			this.右2_尾6_表示 = e.右2_尾6_表示;
			this.右1_尾0_表示 = e.右1_尾0_表示;
			this.右1_尾1_表示 = e.右1_尾1_表示;
			this.右1_尾2_表示 = e.右1_尾2_表示;
			this.右1_尾3_表示 = e.右1_尾3_表示;
			this.右1_尾4_表示 = e.右1_尾4_表示;
			this.右1_尾5_表示 = e.右1_尾5_表示;
			this.右1_尾6_表示 = e.右1_尾6_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.Pars = new Par[]
			{
				this.X0Y0_尾0,
				this.X0Y0_尾1,
				this.X0Y0_尾2,
				this.X0Y0_尾3,
				this.X0Y0_尾4,
				this.X0Y0_中央_尾0,
				this.X0Y0_中央_尾1,
				this.X0Y0_中央_尾2,
				this.X0Y0_中央_尾3,
				this.X0Y0_中央_尾4,
				this.X0Y0_中央_尾5,
				this.X0Y0_中央_尾6,
				this.X0Y0_左2_尾0,
				this.X0Y0_左2_尾1,
				this.X0Y0_左2_尾2,
				this.X0Y0_左2_尾3,
				this.X0Y0_左2_尾4,
				this.X0Y0_左2_尾5,
				this.X0Y0_左2_尾6,
				this.X0Y0_左1_尾0,
				this.X0Y0_左1_尾1,
				this.X0Y0_左1_尾2,
				this.X0Y0_左1_尾3,
				this.X0Y0_左1_尾4,
				this.X0Y0_左1_尾5,
				this.X0Y0_左1_尾6,
				this.X0Y0_右2_尾0,
				this.X0Y0_右2_尾1,
				this.X0Y0_右2_尾2,
				this.X0Y0_右2_尾3,
				this.X0Y0_右2_尾4,
				this.X0Y0_右2_尾5,
				this.X0Y0_右2_尾6,
				this.X0Y0_右1_尾0,
				this.X0Y0_右1_尾1,
				this.X0Y0_右1_尾2,
				this.X0Y0_右1_尾3,
				this.X0Y0_右1_尾4,
				this.X0Y0_右1_尾5,
				this.X0Y0_右1_尾6
			};
			this.X0Y0_尾0CP = new ColorP(this.X0Y0_尾0, this.尾0CD, DisUnit, true);
			this.X0Y0_尾1CP = new ColorP(this.X0Y0_尾1, this.尾1CD, DisUnit, true);
			this.X0Y0_尾2CP = new ColorP(this.X0Y0_尾2, this.尾2CD, DisUnit, true);
			this.X0Y0_尾3CP = new ColorP(this.X0Y0_尾3, this.尾3CD, DisUnit, true);
			this.X0Y0_尾4CP = new ColorP(this.X0Y0_尾4, this.尾4CD, DisUnit, true);
			this.X0Y0_中央_尾0CP = new ColorP(this.X0Y0_中央_尾0, this.中央_尾0CD, DisUnit, true);
			this.X0Y0_中央_尾1CP = new ColorP(this.X0Y0_中央_尾1, this.中央_尾1CD, DisUnit, true);
			this.X0Y0_中央_尾2CP = new ColorP(this.X0Y0_中央_尾2, this.中央_尾2CD, DisUnit, true);
			this.X0Y0_中央_尾3CP = new ColorP(this.X0Y0_中央_尾3, this.中央_尾3CD, DisUnit, true);
			this.X0Y0_中央_尾4CP = new ColorP(this.X0Y0_中央_尾4, this.中央_尾4CD, DisUnit, true);
			this.X0Y0_中央_尾5CP = new ColorP(this.X0Y0_中央_尾5, this.中央_尾5CD, DisUnit, true);
			this.X0Y0_中央_尾6CP = new ColorP(this.X0Y0_中央_尾6, this.中央_尾6CD, DisUnit, true);
			this.X0Y0_左2_尾0CP = new ColorP(this.X0Y0_左2_尾0, this.左2_尾0CD, DisUnit, true);
			this.X0Y0_左2_尾1CP = new ColorP(this.X0Y0_左2_尾1, this.左2_尾1CD, DisUnit, true);
			this.X0Y0_左2_尾2CP = new ColorP(this.X0Y0_左2_尾2, this.左2_尾2CD, DisUnit, true);
			this.X0Y0_左2_尾3CP = new ColorP(this.X0Y0_左2_尾3, this.左2_尾3CD, DisUnit, true);
			this.X0Y0_左2_尾4CP = new ColorP(this.X0Y0_左2_尾4, this.左2_尾4CD, DisUnit, true);
			this.X0Y0_左2_尾5CP = new ColorP(this.X0Y0_左2_尾5, this.左2_尾5CD, DisUnit, true);
			this.X0Y0_左2_尾6CP = new ColorP(this.X0Y0_左2_尾6, this.左2_尾6CD, DisUnit, true);
			this.X0Y0_左1_尾0CP = new ColorP(this.X0Y0_左1_尾0, this.左1_尾0CD, DisUnit, true);
			this.X0Y0_左1_尾1CP = new ColorP(this.X0Y0_左1_尾1, this.左1_尾1CD, DisUnit, true);
			this.X0Y0_左1_尾2CP = new ColorP(this.X0Y0_左1_尾2, this.左1_尾2CD, DisUnit, true);
			this.X0Y0_左1_尾3CP = new ColorP(this.X0Y0_左1_尾3, this.左1_尾3CD, DisUnit, true);
			this.X0Y0_左1_尾4CP = new ColorP(this.X0Y0_左1_尾4, this.左1_尾4CD, DisUnit, true);
			this.X0Y0_左1_尾5CP = new ColorP(this.X0Y0_左1_尾5, this.左1_尾5CD, DisUnit, true);
			this.X0Y0_左1_尾6CP = new ColorP(this.X0Y0_左1_尾6, this.左1_尾6CD, DisUnit, true);
			this.X0Y0_右2_尾0CP = new ColorP(this.X0Y0_右2_尾0, this.右2_尾0CD, DisUnit, true);
			this.X0Y0_右2_尾1CP = new ColorP(this.X0Y0_右2_尾1, this.右2_尾1CD, DisUnit, true);
			this.X0Y0_右2_尾2CP = new ColorP(this.X0Y0_右2_尾2, this.右2_尾2CD, DisUnit, true);
			this.X0Y0_右2_尾3CP = new ColorP(this.X0Y0_右2_尾3, this.右2_尾3CD, DisUnit, true);
			this.X0Y0_右2_尾4CP = new ColorP(this.X0Y0_右2_尾4, this.右2_尾4CD, DisUnit, true);
			this.X0Y0_右2_尾5CP = new ColorP(this.X0Y0_右2_尾5, this.右2_尾5CD, DisUnit, true);
			this.X0Y0_右2_尾6CP = new ColorP(this.X0Y0_右2_尾6, this.右2_尾6CD, DisUnit, true);
			this.X0Y0_右1_尾0CP = new ColorP(this.X0Y0_右1_尾0, this.右1_尾0CD, DisUnit, true);
			this.X0Y0_右1_尾1CP = new ColorP(this.X0Y0_右1_尾1, this.右1_尾1CD, DisUnit, true);
			this.X0Y0_右1_尾2CP = new ColorP(this.X0Y0_右1_尾2, this.右1_尾2CD, DisUnit, true);
			this.X0Y0_右1_尾3CP = new ColorP(this.X0Y0_右1_尾3, this.右1_尾3CD, DisUnit, true);
			this.X0Y0_右1_尾4CP = new ColorP(this.X0Y0_右1_尾4, this.右1_尾4CD, DisUnit, true);
			this.X0Y0_右1_尾5CP = new ColorP(this.X0Y0_右1_尾5, this.右1_尾5CD, DisUnit, true);
			this.X0Y0_右1_尾6CP = new ColorP(this.X0Y0_右1_尾6, this.右1_尾6CD, DisUnit, true);
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

		public bool 尾0_表示
		{
			get
			{
				return this.X0Y0_尾0.Dra;
			}
			set
			{
				this.X0Y0_尾0.Dra = value;
				this.X0Y0_尾0.Hit = value;
			}
		}

		public bool 尾1_表示
		{
			get
			{
				return this.X0Y0_尾1.Dra;
			}
			set
			{
				this.X0Y0_尾1.Dra = value;
				this.X0Y0_尾1.Hit = value;
			}
		}

		public bool 尾2_表示
		{
			get
			{
				return this.X0Y0_尾2.Dra;
			}
			set
			{
				this.X0Y0_尾2.Dra = value;
				this.X0Y0_尾2.Hit = value;
			}
		}

		public bool 尾3_表示
		{
			get
			{
				return this.X0Y0_尾3.Dra;
			}
			set
			{
				this.X0Y0_尾3.Dra = value;
				this.X0Y0_尾3.Hit = value;
			}
		}

		public bool 尾4_表示
		{
			get
			{
				return this.X0Y0_尾4.Dra;
			}
			set
			{
				this.X0Y0_尾4.Dra = value;
				this.X0Y0_尾4.Hit = value;
			}
		}

		public bool 中央_尾0_表示
		{
			get
			{
				return this.X0Y0_中央_尾0.Dra;
			}
			set
			{
				this.X0Y0_中央_尾0.Dra = value;
				this.X0Y0_中央_尾0.Hit = value;
			}
		}

		public bool 中央_尾1_表示
		{
			get
			{
				return this.X0Y0_中央_尾1.Dra;
			}
			set
			{
				this.X0Y0_中央_尾1.Dra = value;
				this.X0Y0_中央_尾1.Hit = value;
			}
		}

		public bool 中央_尾2_表示
		{
			get
			{
				return this.X0Y0_中央_尾2.Dra;
			}
			set
			{
				this.X0Y0_中央_尾2.Dra = value;
				this.X0Y0_中央_尾2.Hit = value;
			}
		}

		public bool 中央_尾3_表示
		{
			get
			{
				return this.X0Y0_中央_尾3.Dra;
			}
			set
			{
				this.X0Y0_中央_尾3.Dra = value;
				this.X0Y0_中央_尾3.Hit = value;
			}
		}

		public bool 中央_尾4_表示
		{
			get
			{
				return this.X0Y0_中央_尾4.Dra;
			}
			set
			{
				this.X0Y0_中央_尾4.Dra = value;
				this.X0Y0_中央_尾4.Hit = value;
			}
		}

		public bool 中央_尾5_表示
		{
			get
			{
				return this.X0Y0_中央_尾5.Dra;
			}
			set
			{
				this.X0Y0_中央_尾5.Dra = value;
				this.X0Y0_中央_尾5.Hit = value;
			}
		}

		public bool 中央_尾6_表示
		{
			get
			{
				return this.X0Y0_中央_尾6.Dra;
			}
			set
			{
				this.X0Y0_中央_尾6.Dra = value;
				this.X0Y0_中央_尾6.Hit = value;
			}
		}

		public bool 左2_尾0_表示
		{
			get
			{
				return this.X0Y0_左2_尾0.Dra;
			}
			set
			{
				this.X0Y0_左2_尾0.Dra = value;
				this.X0Y0_左2_尾0.Hit = value;
			}
		}

		public bool 左2_尾1_表示
		{
			get
			{
				return this.X0Y0_左2_尾1.Dra;
			}
			set
			{
				this.X0Y0_左2_尾1.Dra = value;
				this.X0Y0_左2_尾1.Hit = value;
			}
		}

		public bool 左2_尾2_表示
		{
			get
			{
				return this.X0Y0_左2_尾2.Dra;
			}
			set
			{
				this.X0Y0_左2_尾2.Dra = value;
				this.X0Y0_左2_尾2.Hit = value;
			}
		}

		public bool 左2_尾3_表示
		{
			get
			{
				return this.X0Y0_左2_尾3.Dra;
			}
			set
			{
				this.X0Y0_左2_尾3.Dra = value;
				this.X0Y0_左2_尾3.Hit = value;
			}
		}

		public bool 左2_尾4_表示
		{
			get
			{
				return this.X0Y0_左2_尾4.Dra;
			}
			set
			{
				this.X0Y0_左2_尾4.Dra = value;
				this.X0Y0_左2_尾4.Hit = value;
			}
		}

		public bool 左2_尾5_表示
		{
			get
			{
				return this.X0Y0_左2_尾5.Dra;
			}
			set
			{
				this.X0Y0_左2_尾5.Dra = value;
				this.X0Y0_左2_尾5.Hit = value;
			}
		}

		public bool 左2_尾6_表示
		{
			get
			{
				return this.X0Y0_左2_尾6.Dra;
			}
			set
			{
				this.X0Y0_左2_尾6.Dra = value;
				this.X0Y0_左2_尾6.Hit = value;
			}
		}

		public bool 左1_尾0_表示
		{
			get
			{
				return this.X0Y0_左1_尾0.Dra;
			}
			set
			{
				this.X0Y0_左1_尾0.Dra = value;
				this.X0Y0_左1_尾0.Hit = value;
			}
		}

		public bool 左1_尾1_表示
		{
			get
			{
				return this.X0Y0_左1_尾1.Dra;
			}
			set
			{
				this.X0Y0_左1_尾1.Dra = value;
				this.X0Y0_左1_尾1.Hit = value;
			}
		}

		public bool 左1_尾2_表示
		{
			get
			{
				return this.X0Y0_左1_尾2.Dra;
			}
			set
			{
				this.X0Y0_左1_尾2.Dra = value;
				this.X0Y0_左1_尾2.Hit = value;
			}
		}

		public bool 左1_尾3_表示
		{
			get
			{
				return this.X0Y0_左1_尾3.Dra;
			}
			set
			{
				this.X0Y0_左1_尾3.Dra = value;
				this.X0Y0_左1_尾3.Hit = value;
			}
		}

		public bool 左1_尾4_表示
		{
			get
			{
				return this.X0Y0_左1_尾4.Dra;
			}
			set
			{
				this.X0Y0_左1_尾4.Dra = value;
				this.X0Y0_左1_尾4.Hit = value;
			}
		}

		public bool 左1_尾5_表示
		{
			get
			{
				return this.X0Y0_左1_尾5.Dra;
			}
			set
			{
				this.X0Y0_左1_尾5.Dra = value;
				this.X0Y0_左1_尾5.Hit = value;
			}
		}

		public bool 左1_尾6_表示
		{
			get
			{
				return this.X0Y0_左1_尾6.Dra;
			}
			set
			{
				this.X0Y0_左1_尾6.Dra = value;
				this.X0Y0_左1_尾6.Hit = value;
			}
		}

		public bool 右2_尾0_表示
		{
			get
			{
				return this.X0Y0_右2_尾0.Dra;
			}
			set
			{
				this.X0Y0_右2_尾0.Dra = value;
				this.X0Y0_右2_尾0.Hit = value;
			}
		}

		public bool 右2_尾1_表示
		{
			get
			{
				return this.X0Y0_右2_尾1.Dra;
			}
			set
			{
				this.X0Y0_右2_尾1.Dra = value;
				this.X0Y0_右2_尾1.Hit = value;
			}
		}

		public bool 右2_尾2_表示
		{
			get
			{
				return this.X0Y0_右2_尾2.Dra;
			}
			set
			{
				this.X0Y0_右2_尾2.Dra = value;
				this.X0Y0_右2_尾2.Hit = value;
			}
		}

		public bool 右2_尾3_表示
		{
			get
			{
				return this.X0Y0_右2_尾3.Dra;
			}
			set
			{
				this.X0Y0_右2_尾3.Dra = value;
				this.X0Y0_右2_尾3.Hit = value;
			}
		}

		public bool 右2_尾4_表示
		{
			get
			{
				return this.X0Y0_右2_尾4.Dra;
			}
			set
			{
				this.X0Y0_右2_尾4.Dra = value;
				this.X0Y0_右2_尾4.Hit = value;
			}
		}

		public bool 右2_尾5_表示
		{
			get
			{
				return this.X0Y0_右2_尾5.Dra;
			}
			set
			{
				this.X0Y0_右2_尾5.Dra = value;
				this.X0Y0_右2_尾5.Hit = value;
			}
		}

		public bool 右2_尾6_表示
		{
			get
			{
				return this.X0Y0_右2_尾6.Dra;
			}
			set
			{
				this.X0Y0_右2_尾6.Dra = value;
				this.X0Y0_右2_尾6.Hit = value;
			}
		}

		public bool 右1_尾0_表示
		{
			get
			{
				return this.X0Y0_右1_尾0.Dra;
			}
			set
			{
				this.X0Y0_右1_尾0.Dra = value;
				this.X0Y0_右1_尾0.Hit = value;
			}
		}

		public bool 右1_尾1_表示
		{
			get
			{
				return this.X0Y0_右1_尾1.Dra;
			}
			set
			{
				this.X0Y0_右1_尾1.Dra = value;
				this.X0Y0_右1_尾1.Hit = value;
			}
		}

		public bool 右1_尾2_表示
		{
			get
			{
				return this.X0Y0_右1_尾2.Dra;
			}
			set
			{
				this.X0Y0_右1_尾2.Dra = value;
				this.X0Y0_右1_尾2.Hit = value;
			}
		}

		public bool 右1_尾3_表示
		{
			get
			{
				return this.X0Y0_右1_尾3.Dra;
			}
			set
			{
				this.X0Y0_右1_尾3.Dra = value;
				this.X0Y0_右1_尾3.Hit = value;
			}
		}

		public bool 右1_尾4_表示
		{
			get
			{
				return this.X0Y0_右1_尾4.Dra;
			}
			set
			{
				this.X0Y0_右1_尾4.Dra = value;
				this.X0Y0_右1_尾4.Hit = value;
			}
		}

		public bool 右1_尾5_表示
		{
			get
			{
				return this.X0Y0_右1_尾5.Dra;
			}
			set
			{
				this.X0Y0_右1_尾5.Dra = value;
				this.X0Y0_右1_尾5.Hit = value;
			}
		}

		public bool 右1_尾6_表示
		{
			get
			{
				return this.X0Y0_右1_尾6.Dra;
			}
			set
			{
				this.X0Y0_右1_尾6.Dra = value;
				this.X0Y0_右1_尾6.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.尾0_表示;
			}
			set
			{
				this.尾0_表示 = value;
				this.尾1_表示 = value;
				this.尾2_表示 = value;
				this.尾3_表示 = value;
				this.尾4_表示 = value;
				this.中央_尾0_表示 = value;
				this.中央_尾1_表示 = value;
				this.中央_尾2_表示 = value;
				this.中央_尾3_表示 = value;
				this.中央_尾4_表示 = value;
				this.中央_尾5_表示 = value;
				this.中央_尾6_表示 = value;
				this.左2_尾0_表示 = value;
				this.左2_尾1_表示 = value;
				this.左2_尾2_表示 = value;
				this.左2_尾3_表示 = value;
				this.左2_尾4_表示 = value;
				this.左2_尾5_表示 = value;
				this.左2_尾6_表示 = value;
				this.左1_尾0_表示 = value;
				this.左1_尾1_表示 = value;
				this.左1_尾2_表示 = value;
				this.左1_尾3_表示 = value;
				this.左1_尾4_表示 = value;
				this.左1_尾5_表示 = value;
				this.左1_尾6_表示 = value;
				this.右2_尾0_表示 = value;
				this.右2_尾1_表示 = value;
				this.右2_尾2_表示 = value;
				this.右2_尾3_表示 = value;
				this.右2_尾4_表示 = value;
				this.右2_尾5_表示 = value;
				this.右2_尾6_表示 = value;
				this.右1_尾0_表示 = value;
				this.右1_尾1_表示 = value;
				this.右1_尾2_表示 = value;
				this.右1_尾3_表示 = value;
				this.右1_尾4_表示 = value;
				this.右1_尾5_表示 = value;
				this.右1_尾6_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.尾0CD.不透明度;
			}
			set
			{
				this.尾0CD.不透明度 = value;
				this.尾1CD.不透明度 = value;
				this.尾2CD.不透明度 = value;
				this.尾3CD.不透明度 = value;
				this.尾4CD.不透明度 = value;
				this.中央_尾0CD.不透明度 = value;
				this.中央_尾1CD.不透明度 = value;
				this.中央_尾2CD.不透明度 = value;
				this.中央_尾3CD.不透明度 = value;
				this.中央_尾4CD.不透明度 = value;
				this.中央_尾5CD.不透明度 = value;
				this.中央_尾6CD.不透明度 = value;
				this.左2_尾0CD.不透明度 = value;
				this.左2_尾1CD.不透明度 = value;
				this.左2_尾2CD.不透明度 = value;
				this.左2_尾3CD.不透明度 = value;
				this.左2_尾4CD.不透明度 = value;
				this.左2_尾5CD.不透明度 = value;
				this.左2_尾6CD.不透明度 = value;
				this.左1_尾0CD.不透明度 = value;
				this.左1_尾1CD.不透明度 = value;
				this.左1_尾2CD.不透明度 = value;
				this.左1_尾3CD.不透明度 = value;
				this.左1_尾4CD.不透明度 = value;
				this.左1_尾5CD.不透明度 = value;
				this.左1_尾6CD.不透明度 = value;
				this.右2_尾0CD.不透明度 = value;
				this.右2_尾1CD.不透明度 = value;
				this.右2_尾2CD.不透明度 = value;
				this.右2_尾3CD.不透明度 = value;
				this.右2_尾4CD.不透明度 = value;
				this.右2_尾5CD.不透明度 = value;
				this.右2_尾6CD.不透明度 = value;
				this.右1_尾0CD.不透明度 = value;
				this.右1_尾1CD.不透明度 = value;
				this.右1_尾2CD.不透明度 = value;
				this.右1_尾3CD.不透明度 = value;
				this.右1_尾4CD.不透明度 = value;
				this.右1_尾5CD.不透明度 = value;
				this.右1_尾6CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			bool 右 = this.右;
			double maxAngle = 20.0;
			this.X0Y0_尾0.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾1.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾2.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾3.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾4.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_中央_尾0.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_中央_尾1.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_中央_尾2.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_中央_尾3.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_中央_尾4.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_中央_尾5.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_中央_尾6.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_左2_尾0.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_左2_尾1.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_左2_尾2.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_左2_尾3.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_左2_尾4.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_左2_尾5.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_左2_尾6.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_左1_尾0.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_左1_尾1.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_左1_尾2.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_左1_尾3.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_左1_尾4.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_左1_尾5.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_左1_尾6.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_右2_尾0.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_右2_尾1.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_右2_尾2.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_右2_尾3.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_右2_尾4.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_右2_尾5.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_右2_尾6.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_右1_尾0.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_右1_尾1.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_右1_尾2.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_右1_尾3.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_右1_尾4.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_右1_尾5.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_右1_尾6.AngleBase = maxAngle.GetRanAngle();
			this.本体.JoinPAall();
		}

		public override IEnumerable<Par> Enum軸()
		{
			yield return this.X0Y0_尾0;
			yield return this.X0Y0_尾1;
			yield return this.X0Y0_尾2;
			yield return this.X0Y0_尾3;
			yield return this.X0Y0_尾4;
			yield break;
		}

		public override void 色更新()
		{
			this.Pars.GetMiY_MaY(out this.mm);
			this.X0Y0_尾0CP.Update(this.mm);
			this.X0Y0_尾1CP.Update(this.mm);
			this.X0Y0_尾2CP.Update(this.mm);
			this.X0Y0_尾3CP.Update(this.mm);
			this.X0Y0_尾4CP.Update(this.mm);
			this.X0Y0_中央_尾0CP.Update(this.mm);
			this.X0Y0_中央_尾1CP.Update(this.mm);
			this.X0Y0_中央_尾2CP.Update(this.mm);
			this.X0Y0_中央_尾3CP.Update(this.mm);
			this.X0Y0_中央_尾4CP.Update(this.mm);
			this.X0Y0_中央_尾5CP.Update(this.mm);
			this.X0Y0_中央_尾6CP.Update(this.mm);
			this.X0Y0_左2_尾0CP.Update(this.mm);
			this.X0Y0_左2_尾1CP.Update(this.mm);
			this.X0Y0_左2_尾2CP.Update(this.mm);
			this.X0Y0_左2_尾3CP.Update(this.mm);
			this.X0Y0_左2_尾4CP.Update(this.mm);
			this.X0Y0_左2_尾5CP.Update(this.mm);
			this.X0Y0_左2_尾6CP.Update(this.mm);
			this.X0Y0_左1_尾0CP.Update(this.mm);
			this.X0Y0_左1_尾1CP.Update(this.mm);
			this.X0Y0_左1_尾2CP.Update(this.mm);
			this.X0Y0_左1_尾3CP.Update(this.mm);
			this.X0Y0_左1_尾4CP.Update(this.mm);
			this.X0Y0_左1_尾5CP.Update(this.mm);
			this.X0Y0_左1_尾6CP.Update(this.mm);
			this.X0Y0_右2_尾0CP.Update(this.mm);
			this.X0Y0_右2_尾1CP.Update(this.mm);
			this.X0Y0_右2_尾2CP.Update(this.mm);
			this.X0Y0_右2_尾3CP.Update(this.mm);
			this.X0Y0_右2_尾4CP.Update(this.mm);
			this.X0Y0_右2_尾5CP.Update(this.mm);
			this.X0Y0_右2_尾6CP.Update(this.mm);
			this.X0Y0_右1_尾0CP.Update(this.mm);
			this.X0Y0_右1_尾1CP.Update(this.mm);
			this.X0Y0_右1_尾2CP.Update(this.mm);
			this.X0Y0_右1_尾3CP.Update(this.mm);
			this.X0Y0_右1_尾4CP.Update(this.mm);
			this.X0Y0_右1_尾5CP.Update(this.mm);
			this.X0Y0_右1_尾6CP.Update(this.mm);
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.尾0CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.尾1CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.尾2CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.尾3CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.尾4CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中央_尾0CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中央_尾1CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中央_尾2CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中央_尾3CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中央_尾4CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中央_尾5CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.中央_尾6CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.左2_尾0CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.左2_尾1CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.左2_尾2CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.左2_尾3CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.左2_尾4CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.左2_尾5CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.左2_尾6CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.左1_尾0CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.左1_尾1CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.左1_尾2CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.左1_尾3CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.左1_尾4CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.左1_尾5CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.左1_尾6CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.右2_尾0CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.右2_尾1CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.右2_尾2CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.右2_尾3CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.右2_尾4CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.右2_尾5CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.右2_尾6CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.右1_尾0CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.右1_尾1CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.右1_尾2CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.右1_尾3CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.右1_尾4CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.右1_尾5CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
			this.右1_尾6CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
		}

		public Par X0Y0_尾0;

		public Par X0Y0_尾1;

		public Par X0Y0_尾2;

		public Par X0Y0_尾3;

		public Par X0Y0_尾4;

		public Par X0Y0_中央_尾0;

		public Par X0Y0_中央_尾1;

		public Par X0Y0_中央_尾2;

		public Par X0Y0_中央_尾3;

		public Par X0Y0_中央_尾4;

		public Par X0Y0_中央_尾5;

		public Par X0Y0_中央_尾6;

		public Par X0Y0_左2_尾0;

		public Par X0Y0_左2_尾1;

		public Par X0Y0_左2_尾2;

		public Par X0Y0_左2_尾3;

		public Par X0Y0_左2_尾4;

		public Par X0Y0_左2_尾5;

		public Par X0Y0_左2_尾6;

		public Par X0Y0_左1_尾0;

		public Par X0Y0_左1_尾1;

		public Par X0Y0_左1_尾2;

		public Par X0Y0_左1_尾3;

		public Par X0Y0_左1_尾4;

		public Par X0Y0_左1_尾5;

		public Par X0Y0_左1_尾6;

		public Par X0Y0_右2_尾0;

		public Par X0Y0_右2_尾1;

		public Par X0Y0_右2_尾2;

		public Par X0Y0_右2_尾3;

		public Par X0Y0_右2_尾4;

		public Par X0Y0_右2_尾5;

		public Par X0Y0_右2_尾6;

		public Par X0Y0_右1_尾0;

		public Par X0Y0_右1_尾1;

		public Par X0Y0_右1_尾2;

		public Par X0Y0_右1_尾3;

		public Par X0Y0_右1_尾4;

		public Par X0Y0_右1_尾5;

		public Par X0Y0_右1_尾6;

		public ColorD 尾0CD;

		public ColorD 尾1CD;

		public ColorD 尾2CD;

		public ColorD 尾3CD;

		public ColorD 尾4CD;

		public ColorD 中央_尾0CD;

		public ColorD 中央_尾1CD;

		public ColorD 中央_尾2CD;

		public ColorD 中央_尾3CD;

		public ColorD 中央_尾4CD;

		public ColorD 中央_尾5CD;

		public ColorD 中央_尾6CD;

		public ColorD 左2_尾0CD;

		public ColorD 左2_尾1CD;

		public ColorD 左2_尾2CD;

		public ColorD 左2_尾3CD;

		public ColorD 左2_尾4CD;

		public ColorD 左2_尾5CD;

		public ColorD 左2_尾6CD;

		public ColorD 左1_尾0CD;

		public ColorD 左1_尾1CD;

		public ColorD 左1_尾2CD;

		public ColorD 左1_尾3CD;

		public ColorD 左1_尾4CD;

		public ColorD 左1_尾5CD;

		public ColorD 左1_尾6CD;

		public ColorD 右2_尾0CD;

		public ColorD 右2_尾1CD;

		public ColorD 右2_尾2CD;

		public ColorD 右2_尾3CD;

		public ColorD 右2_尾4CD;

		public ColorD 右2_尾5CD;

		public ColorD 右2_尾6CD;

		public ColorD 右1_尾0CD;

		public ColorD 右1_尾1CD;

		public ColorD 右1_尾2CD;

		public ColorD 右1_尾3CD;

		public ColorD 右1_尾4CD;

		public ColorD 右1_尾5CD;

		public ColorD 右1_尾6CD;

		public ColorP X0Y0_尾0CP;

		public ColorP X0Y0_尾1CP;

		public ColorP X0Y0_尾2CP;

		public ColorP X0Y0_尾3CP;

		public ColorP X0Y0_尾4CP;

		public ColorP X0Y0_中央_尾0CP;

		public ColorP X0Y0_中央_尾1CP;

		public ColorP X0Y0_中央_尾2CP;

		public ColorP X0Y0_中央_尾3CP;

		public ColorP X0Y0_中央_尾4CP;

		public ColorP X0Y0_中央_尾5CP;

		public ColorP X0Y0_中央_尾6CP;

		public ColorP X0Y0_左2_尾0CP;

		public ColorP X0Y0_左2_尾1CP;

		public ColorP X0Y0_左2_尾2CP;

		public ColorP X0Y0_左2_尾3CP;

		public ColorP X0Y0_左2_尾4CP;

		public ColorP X0Y0_左2_尾5CP;

		public ColorP X0Y0_左2_尾6CP;

		public ColorP X0Y0_左1_尾0CP;

		public ColorP X0Y0_左1_尾1CP;

		public ColorP X0Y0_左1_尾2CP;

		public ColorP X0Y0_左1_尾3CP;

		public ColorP X0Y0_左1_尾4CP;

		public ColorP X0Y0_左1_尾5CP;

		public ColorP X0Y0_左1_尾6CP;

		public ColorP X0Y0_右2_尾0CP;

		public ColorP X0Y0_右2_尾1CP;

		public ColorP X0Y0_右2_尾2CP;

		public ColorP X0Y0_右2_尾3CP;

		public ColorP X0Y0_右2_尾4CP;

		public ColorP X0Y0_右2_尾5CP;

		public ColorP X0Y0_右2_尾6CP;

		public ColorP X0Y0_右1_尾0CP;

		public ColorP X0Y0_右1_尾1CP;

		public ColorP X0Y0_右1_尾2CP;

		public ColorP X0Y0_右1_尾3CP;

		public ColorP X0Y0_右1_尾4CP;

		public ColorP X0Y0_右1_尾5CP;

		public ColorP X0Y0_右1_尾6CP;

		public Par[] Pars;

		private Vector2D[] mm;
	}
}
