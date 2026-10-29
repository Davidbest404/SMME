using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 後髪0_パツ : 下ろし
	{
		public 後髪0_パツ(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 後髪0_パツD e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "パツ";
			dif.Add(new Pars(Sta.胴体["後髪0"][0][2]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_髪基 = pars["髪基"].ToPar();
			this.X0Y0_髪中 = pars["髪中"].ToPar();
			this.X0Y0_髪左1 = pars["髪左1"].ToPar();
			this.X0Y0_髪左2 = pars["髪左2"].ToPar();
			this.X0Y0_髪左3 = pars["髪左3"].ToPar();
			this.X0Y0_髪左4 = pars["髪左4"].ToPar();
			this.X0Y0_髪左5 = pars["髪左5"].ToPar();
			this.X0Y0_髪右1 = pars["髪右1"].ToPar();
			this.X0Y0_髪右2 = pars["髪右2"].ToPar();
			this.X0Y0_髪右3 = pars["髪右3"].ToPar();
			this.X0Y0_髪右4 = pars["髪右4"].ToPar();
			this.X0Y0_髪右5 = pars["髪右5"].ToPar();
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
			this.髪基_表示 = e.髪基_表示;
			this.髪中_表示 = e.髪中_表示;
			this.髪左1_表示 = e.髪左1_表示;
			this.髪左2_表示 = e.髪左2_表示;
			this.髪左3_表示 = e.髪左3_表示;
			this.髪左4_表示 = e.髪左4_表示;
			this.髪左5_表示 = e.髪左5_表示;
			this.髪右1_表示 = e.髪右1_表示;
			this.髪右2_表示 = e.髪右2_表示;
			this.髪右3_表示 = e.髪右3_表示;
			this.髪右4_表示 = e.髪右4_表示;
			this.髪右5_表示 = e.髪右5_表示;
			this.髪長0 = e.髪長0;
			this.髪長1 = e.髪長1;
			this.毛量 = e.毛量;
			this.広がり = e.広がり;
			if (e.スライム)
			{
				this.スライム();
			}
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_髪基CP = new ColorP(this.X0Y0_髪基, this.髪基CD, DisUnit, false);
			this.X0Y0_髪中CP = new ColorP(this.X0Y0_髪中, this.髪中CD, DisUnit, false);
			this.X0Y0_髪左1CP = new ColorP(this.X0Y0_髪左1, this.髪左1CD, DisUnit, false);
			this.X0Y0_髪左2CP = new ColorP(this.X0Y0_髪左2, this.髪左2CD, DisUnit, false);
			this.X0Y0_髪左3CP = new ColorP(this.X0Y0_髪左3, this.髪左3CD, DisUnit, false);
			this.X0Y0_髪左4CP = new ColorP(this.X0Y0_髪左4, this.髪左4CD, DisUnit, false);
			this.X0Y0_髪左5CP = new ColorP(this.X0Y0_髪左5, this.髪左5CD, DisUnit, false);
			this.X0Y0_髪右1CP = new ColorP(this.X0Y0_髪右1, this.髪右1CD, DisUnit, false);
			this.X0Y0_髪右2CP = new ColorP(this.X0Y0_髪右2, this.髪右2CD, DisUnit, false);
			this.X0Y0_髪右3CP = new ColorP(this.X0Y0_髪右3, this.髪右3CD, DisUnit, false);
			this.X0Y0_髪右4CP = new ColorP(this.X0Y0_髪右4, this.髪右4CD, DisUnit, false);
			this.X0Y0_髪右5CP = new ColorP(this.X0Y0_髪右5, this.髪右5CD, DisUnit, false);
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

		public bool 髪基_表示
		{
			get
			{
				return this.X0Y0_髪基.Dra;
			}
			set
			{
				this.X0Y0_髪基.Dra = value;
				this.X0Y0_髪基.Hit = value;
			}
		}

		public bool 髪中_表示
		{
			get
			{
				return this.X0Y0_髪中.Dra;
			}
			set
			{
				this.X0Y0_髪中.Dra = value;
				this.X0Y0_髪中.Hit = value;
			}
		}

		public bool 髪左1_表示
		{
			get
			{
				return this.X0Y0_髪左1.Dra;
			}
			set
			{
				this.X0Y0_髪左1.Dra = value;
				this.X0Y0_髪左1.Hit = value;
			}
		}

		public bool 髪左2_表示
		{
			get
			{
				return this.X0Y0_髪左2.Dra;
			}
			set
			{
				this.X0Y0_髪左2.Dra = value;
				this.X0Y0_髪左2.Hit = value;
			}
		}

		public bool 髪左3_表示
		{
			get
			{
				return this.X0Y0_髪左3.Dra;
			}
			set
			{
				this.X0Y0_髪左3.Dra = value;
				this.X0Y0_髪左3.Hit = value;
			}
		}

		public bool 髪左4_表示
		{
			get
			{
				return this.X0Y0_髪左4.Dra;
			}
			set
			{
				this.X0Y0_髪左4.Dra = value;
				this.X0Y0_髪左4.Hit = value;
			}
		}

		public bool 髪左5_表示
		{
			get
			{
				return this.X0Y0_髪左5.Dra;
			}
			set
			{
				this.X0Y0_髪左5.Dra = value;
				this.X0Y0_髪左5.Hit = value;
			}
		}

		public bool 髪右1_表示
		{
			get
			{
				return this.X0Y0_髪右1.Dra;
			}
			set
			{
				this.X0Y0_髪右1.Dra = value;
				this.X0Y0_髪右1.Hit = value;
			}
		}

		public bool 髪右2_表示
		{
			get
			{
				return this.X0Y0_髪右2.Dra;
			}
			set
			{
				this.X0Y0_髪右2.Dra = value;
				this.X0Y0_髪右2.Hit = value;
			}
		}

		public bool 髪右3_表示
		{
			get
			{
				return this.X0Y0_髪右3.Dra;
			}
			set
			{
				this.X0Y0_髪右3.Dra = value;
				this.X0Y0_髪右3.Hit = value;
			}
		}

		public bool 髪右4_表示
		{
			get
			{
				return this.X0Y0_髪右4.Dra;
			}
			set
			{
				this.X0Y0_髪右4.Dra = value;
				this.X0Y0_髪右4.Hit = value;
			}
		}

		public bool 髪右5_表示
		{
			get
			{
				return this.X0Y0_髪右5.Dra;
			}
			set
			{
				this.X0Y0_髪右5.Dra = value;
				this.X0Y0_髪右5.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.髪基_表示;
			}
			set
			{
				this.髪基_表示 = value;
				this.髪中_表示 = value;
				this.髪左1_表示 = value;
				this.髪左2_表示 = value;
				this.髪左3_表示 = value;
				this.髪左4_表示 = value;
				this.髪左5_表示 = value;
				this.髪右1_表示 = value;
				this.髪右2_表示 = value;
				this.髪右3_表示 = value;
				this.髪右4_表示 = value;
				this.髪右5_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.髪基CD.不透明度;
			}
			set
			{
				this.髪基CD.不透明度 = value;
				this.髪中CD.不透明度 = value;
				this.髪左1CD.不透明度 = value;
				this.髪左2CD.不透明度 = value;
				this.髪左3CD.不透明度 = value;
				this.髪左4CD.不透明度 = value;
				this.髪左5CD.不透明度 = value;
				this.髪右1CD.不透明度 = value;
				this.髪右2CD.不透明度 = value;
				this.髪右3CD.不透明度 = value;
				this.髪右4CD.不透明度 = value;
				this.髪右5CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			bool 右 = this.右;
			this.本体.JoinPAall();
		}

		public double 髪長0
		{
			set
			{
				double num = 0.7 + 0.3 * value;
				this.X0Y0_髪基.SizeYBase *= num;
			}
		}

		public double 髪長1
		{
			set
			{
				double num = 0.4 + 0.91 * value;
				this.X0Y0_髪中.SizeYBase *= num;
				this.X0Y0_髪左1.SizeYBase *= num;
				this.X0Y0_髪左2.SizeYBase *= num;
				this.X0Y0_髪左3.SizeYBase *= num;
				this.X0Y0_髪左4.SizeYBase *= num;
				this.X0Y0_髪左5.SizeYBase *= num;
				this.X0Y0_髪右1.SizeYBase *= num;
				this.X0Y0_髪右2.SizeYBase *= num;
				this.X0Y0_髪右3.SizeYBase *= num;
				this.X0Y0_髪右4.SizeYBase *= num;
				this.X0Y0_髪右5.SizeYBase *= num;
			}
		}

		public double 毛量
		{
			set
			{
				double num = 1.0 + 0.5 * value;
				this.X0Y0_髪中.SizeXBase *= num;
				this.X0Y0_髪左1.SizeXBase *= num;
				this.X0Y0_髪左2.SizeXBase *= num;
				this.X0Y0_髪左3.SizeXBase *= num;
				this.X0Y0_髪左4.SizeXBase *= num;
				this.X0Y0_髪左5.SizeXBase *= num;
				this.X0Y0_髪右1.SizeXBase *= num;
				this.X0Y0_髪右2.SizeXBase *= num;
				this.X0Y0_髪右3.SizeXBase *= num;
				this.X0Y0_髪右4.SizeXBase *= num;
				this.X0Y0_髪右5.SizeXBase *= num;
			}
		}

		public double 広がり
		{
			set
			{
				this.X0Y0_髪左1.AngleBase = 1.5 * value;
				this.X0Y0_髪左2.AngleBase = 3.0 * value;
				this.X0Y0_髪左3.AngleBase = 4.5 * value;
				this.X0Y0_髪左4.AngleBase = 6.0 * value;
				this.X0Y0_髪左5.AngleBase = 7.5 * value;
				this.X0Y0_髪右1.AngleBase = -1.5 * value;
				this.X0Y0_髪右2.AngleBase = -3.0 * value;
				this.X0Y0_髪右3.AngleBase = -4.5 * value;
				this.X0Y0_髪右4.AngleBase = -6.0 * value;
				this.X0Y0_髪右5.AngleBase = -7.5 * value;
			}
		}

		public void スライム()
		{
			this.X0Y0_髪基.OP[this.右 ? 1 : 0].Outline = false;
			this.X0Y0_髪基.OP[this.右 ? 0 : 1].Outline = false;
			this.X0Y0_髪中.OP[this.右 ? 2 : 0].Outline = false;
			this.X0Y0_髪中.OP[this.右 ? 1 : 1].Outline = false;
			this.X0Y0_髪中.OP[this.右 ? 0 : 2].Outline = false;
			this.X0Y0_髪左1.OP[this.右 ? 2 : 0].Outline = false;
			this.X0Y0_髪左1.OP[this.右 ? 1 : 1].Outline = false;
			this.X0Y0_髪左1.OP[this.右 ? 0 : 2].Outline = false;
			this.X0Y0_髪左2.OP[this.右 ? 2 : 0].Outline = false;
			this.X0Y0_髪左2.OP[this.右 ? 1 : 1].Outline = false;
			this.X0Y0_髪左2.OP[this.右 ? 0 : 2].Outline = false;
			this.X0Y0_髪左3.OP[this.右 ? 2 : 0].Outline = false;
			this.X0Y0_髪左3.OP[this.右 ? 1 : 1].Outline = false;
			this.X0Y0_髪左3.OP[this.右 ? 0 : 2].Outline = false;
			this.X0Y0_髪左4.OP[this.右 ? 2 : 0].Outline = false;
			this.X0Y0_髪左4.OP[this.右 ? 1 : 1].Outline = false;
			this.X0Y0_髪左4.OP[this.右 ? 0 : 2].Outline = false;
			this.X0Y0_髪左5.OP[this.右 ? 2 : 0].Outline = false;
			this.X0Y0_髪左5.OP[this.右 ? 1 : 1].Outline = false;
			this.X0Y0_髪左5.OP[this.右 ? 0 : 2].Outline = false;
			this.X0Y0_髪右1.OP[this.右 ? 2 : 0].Outline = false;
			this.X0Y0_髪右1.OP[this.右 ? 1 : 1].Outline = false;
			this.X0Y0_髪右1.OP[this.右 ? 0 : 2].Outline = false;
			this.X0Y0_髪右2.OP[this.右 ? 2 : 0].Outline = false;
			this.X0Y0_髪右2.OP[this.右 ? 1 : 1].Outline = false;
			this.X0Y0_髪右2.OP[this.右 ? 0 : 2].Outline = false;
			this.X0Y0_髪右3.OP[this.右 ? 2 : 0].Outline = false;
			this.X0Y0_髪右3.OP[this.右 ? 1 : 1].Outline = false;
			this.X0Y0_髪右3.OP[this.右 ? 0 : 2].Outline = false;
			this.X0Y0_髪右4.OP[this.右 ? 2 : 0].Outline = false;
			this.X0Y0_髪右4.OP[this.右 ? 1 : 1].Outline = false;
			this.X0Y0_髪右4.OP[this.右 ? 0 : 2].Outline = false;
			this.X0Y0_髪右5.OP[this.右 ? 2 : 0].Outline = false;
			this.X0Y0_髪右5.OP[this.右 ? 1 : 1].Outline = false;
			this.X0Y0_髪右5.OP[this.右 ? 0 : 2].Outline = false;
		}

		public override void 色更新()
		{
			this.X0Y0_髪基CP.Update();
			this.X0Y0_髪中CP.Update();
			this.X0Y0_髪左1CP.Update();
			this.X0Y0_髪左2CP.Update();
			this.X0Y0_髪左3CP.Update();
			this.X0Y0_髪左4CP.Update();
			this.X0Y0_髪左5CP.Update();
			this.X0Y0_髪右1CP.Update();
			this.X0Y0_髪右2CP.Update();
			this.X0Y0_髪右3CP.Update();
			this.X0Y0_髪右4CP.Update();
			this.X0Y0_髪右5CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.髪基CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪中CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪左1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪左2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪左3CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪左4CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪左5CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪右1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪右2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪右3CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪右4CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪右5CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		}

		public Par X0Y0_髪基;

		public Par X0Y0_髪中;

		public Par X0Y0_髪左1;

		public Par X0Y0_髪左2;

		public Par X0Y0_髪左3;

		public Par X0Y0_髪左4;

		public Par X0Y0_髪左5;

		public Par X0Y0_髪右1;

		public Par X0Y0_髪右2;

		public Par X0Y0_髪右3;

		public Par X0Y0_髪右4;

		public Par X0Y0_髪右5;

		public ColorD 髪基CD;

		public ColorD 髪中CD;

		public ColorD 髪左1CD;

		public ColorD 髪左2CD;

		public ColorD 髪左3CD;

		public ColorD 髪左4CD;

		public ColorD 髪左5CD;

		public ColorD 髪右1CD;

		public ColorD 髪右2CD;

		public ColorD 髪右3CD;

		public ColorD 髪右4CD;

		public ColorD 髪右5CD;

		public ColorP X0Y0_髪基CP;

		public ColorP X0Y0_髪中CP;

		public ColorP X0Y0_髪左1CP;

		public ColorP X0Y0_髪左2CP;

		public ColorP X0Y0_髪左3CP;

		public ColorP X0Y0_髪左4CP;

		public ColorP X0Y0_髪左5CP;

		public ColorP X0Y0_髪右1CP;

		public ColorP X0Y0_髪右2CP;

		public ColorP X0Y0_髪右3CP;

		public ColorP X0Y0_髪右4CP;

		public ColorP X0Y0_髪右5CP;
	}
}
