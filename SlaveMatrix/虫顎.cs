using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 虫顎 : Ele
	{
		public 虫顎(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 虫顎D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.肢左["虫顎"][0]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_顎 = pars["顎"].ToPar();
			this.X0Y0_節 = pars["節"].ToPar();
			Pars pars2 = pars["牙"].ToPars();
			this.X0Y0_牙_牙1 = pars2["牙1"].ToPar();
			this.X0Y0_牙_牙2 = pars2["牙2"].ToPar();
			this.X0Y0_牙_牙0 = pars2["牙0"].ToPar();
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
			this.顎_表示 = e.顎_表示;
			this.節_表示 = e.節_表示;
			this.牙_牙1_表示 = e.牙_牙1_表示;
			this.牙_牙2_表示 = e.牙_牙2_表示;
			this.牙_牙0_表示 = e.牙_牙0_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_顎CP = new ColorP(this.X0Y0_顎, this.顎CD, DisUnit, true);
			this.X0Y0_節CP = new ColorP(this.X0Y0_節, this.節CD, DisUnit, true);
			this.X0Y0_牙_牙1CP = new ColorP(this.X0Y0_牙_牙1, this.牙_牙1CD, DisUnit, true);
			this.X0Y0_牙_牙2CP = new ColorP(this.X0Y0_牙_牙2, this.牙_牙2CD, DisUnit, true);
			this.X0Y0_牙_牙0CP = new ColorP(this.X0Y0_牙_牙0, this.牙_牙0CD, DisUnit, true);
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

		public bool 顎_表示
		{
			get
			{
				return this.X0Y0_顎.Dra;
			}
			set
			{
				this.X0Y0_顎.Dra = value;
				this.X0Y0_顎.Hit = value;
			}
		}

		public bool 節_表示
		{
			get
			{
				return this.X0Y0_節.Dra;
			}
			set
			{
				this.X0Y0_節.Dra = value;
				this.X0Y0_節.Hit = value;
			}
		}

		public bool 牙_牙1_表示
		{
			get
			{
				return this.X0Y0_牙_牙1.Dra;
			}
			set
			{
				this.X0Y0_牙_牙1.Dra = value;
				this.X0Y0_牙_牙1.Hit = value;
			}
		}

		public bool 牙_牙2_表示
		{
			get
			{
				return this.X0Y0_牙_牙2.Dra;
			}
			set
			{
				this.X0Y0_牙_牙2.Dra = value;
				this.X0Y0_牙_牙2.Hit = value;
			}
		}

		public bool 牙_牙0_表示
		{
			get
			{
				return this.X0Y0_牙_牙0.Dra;
			}
			set
			{
				this.X0Y0_牙_牙0.Dra = value;
				this.X0Y0_牙_牙0.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.顎_表示;
			}
			set
			{
				this.顎_表示 = value;
				this.節_表示 = value;
				this.牙_牙1_表示 = value;
				this.牙_牙2_表示 = value;
				this.牙_牙0_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.顎CD.不透明度;
			}
			set
			{
				this.顎CD.不透明度 = value;
				this.節CD.不透明度 = value;
				this.牙_牙1CD.不透明度 = value;
				this.牙_牙2CD.不透明度 = value;
				this.牙_牙0CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_顎.AngleBase = num * -53.0;
			this.本体.JoinPAall();
		}

		public override void 色更新()
		{
			this.X0Y0_顎CP.Update();
			this.X0Y0_節CP.Update();
			this.X0Y0_牙_牙1CP.Update();
			this.X0Y0_牙_牙2CP.Update();
			this.X0Y0_牙_牙0CP.Update();
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
			this.顎CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.牙_牙1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.牙_牙2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.牙_牙0CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.顎CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.牙_牙1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.牙_牙2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.牙_牙0CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.顎CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.牙_牙1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.牙_牙2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.牙_牙0CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
		}

		public Par X0Y0_顎;

		public Par X0Y0_節;

		public Par X0Y0_牙_牙1;

		public Par X0Y0_牙_牙2;

		public Par X0Y0_牙_牙0;

		public ColorD 顎CD;

		public ColorD 節CD;

		public ColorD 牙_牙1CD;

		public ColorD 牙_牙2CD;

		public ColorD 牙_牙0CD;

		public ColorP X0Y0_顎CP;

		public ColorP X0Y0_節CP;

		public ColorP X0Y0_牙_牙1CP;

		public ColorP X0Y0_牙_牙2CP;

		public ColorP X0Y0_牙_牙0CP;
	}
}
