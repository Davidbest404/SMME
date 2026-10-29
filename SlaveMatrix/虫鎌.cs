using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 虫鎌 : Ele
	{
		public 虫鎌(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 虫鎌D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.肢左["虫鎌"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_虫鎌節 = pars["虫鎌節"].ToPar();
			this.X0Y0_虫棘1 = pars["虫棘1"].ToPar();
			this.X0Y0_虫棘2 = pars["虫棘2"].ToPar();
			this.X0Y0_虫棘3 = pars["虫棘3"].ToPar();
			this.X0Y0_虫棘4 = pars["虫棘4"].ToPar();
			this.X0Y0_虫鎌1 = pars["虫鎌1"].ToPar();
			this.X0Y0_虫鎌2 = pars["虫鎌2"].ToPar();
			this.X0Y0_虫鎌3 = pars["虫鎌3"].ToPar();
			this.X0Y0_虫孔1 = pars["虫孔1"].ToPar();
			this.X0Y0_虫孔2 = pars["虫孔2"].ToPar();
			Pars pars2 = pars["輪"].ToPars();
			this.X0Y0_輪_革 = pars2["革"].ToPar();
			this.X0Y0_輪_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_輪_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_輪_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_輪_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_輪_金具右 = pars2["金具右"].ToPar();
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
			this.虫鎌節_表示 = e.虫鎌節_表示;
			this.虫棘1_表示 = e.虫棘1_表示;
			this.虫棘2_表示 = e.虫棘2_表示;
			this.虫棘3_表示 = e.虫棘3_表示;
			this.虫棘4_表示 = e.虫棘4_表示;
			this.虫鎌1_表示 = e.虫鎌1_表示;
			this.虫鎌2_表示 = e.虫鎌2_表示;
			this.虫鎌3_表示 = e.虫鎌3_表示;
			this.虫孔1_表示 = e.虫孔1_表示;
			this.虫孔2_表示 = e.虫孔2_表示;
			this.輪_革_表示 = e.輪_革_表示;
			this.輪_金具1_表示 = e.輪_金具1_表示;
			this.輪_金具2_表示 = e.輪_金具2_表示;
			this.輪_金具3_表示 = e.輪_金具3_表示;
			this.輪_金具左_表示 = e.輪_金具左_表示;
			this.輪_金具右_表示 = e.輪_金具右_表示;
			this.輪表示 = e.輪表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_虫鎌節CP = new ColorP(this.X0Y0_虫鎌節, this.虫鎌節CD, DisUnit, true);
			this.X0Y0_虫棘1CP = new ColorP(this.X0Y0_虫棘1, this.虫棘1CD, DisUnit, true);
			this.X0Y0_虫棘2CP = new ColorP(this.X0Y0_虫棘2, this.虫棘2CD, DisUnit, true);
			this.X0Y0_虫棘3CP = new ColorP(this.X0Y0_虫棘3, this.虫棘3CD, DisUnit, true);
			this.X0Y0_虫棘4CP = new ColorP(this.X0Y0_虫棘4, this.虫棘4CD, DisUnit, true);
			this.X0Y0_虫鎌1CP = new ColorP(this.X0Y0_虫鎌1, this.虫鎌1CD, DisUnit, true);
			this.X0Y0_虫鎌2CP = new ColorP(this.X0Y0_虫鎌2, this.虫鎌2CD, DisUnit, true);
			this.X0Y0_虫鎌3CP = new ColorP(this.X0Y0_虫鎌3, this.虫鎌3CD, DisUnit, true);
			this.X0Y0_虫孔1CP = new ColorP(this.X0Y0_虫孔1, this.虫孔1CD, DisUnit, true);
			this.X0Y0_虫孔2CP = new ColorP(this.X0Y0_虫孔2, this.虫孔2CD, DisUnit, true);
			this.X0Y0_輪_革CP = new ColorP(this.X0Y0_輪_革, this.輪_革CD, DisUnit, true);
			this.X0Y0_輪_金具1CP = new ColorP(this.X0Y0_輪_金具1, this.輪_金具1CD, DisUnit, true);
			this.X0Y0_輪_金具2CP = new ColorP(this.X0Y0_輪_金具2, this.輪_金具2CD, DisUnit, true);
			this.X0Y0_輪_金具3CP = new ColorP(this.X0Y0_輪_金具3, this.輪_金具3CD, DisUnit, true);
			this.X0Y0_輪_金具左CP = new ColorP(this.X0Y0_輪_金具左, this.輪_金具左CD, DisUnit, true);
			this.X0Y0_輪_金具右CP = new ColorP(this.X0Y0_輪_金具右, this.輪_金具右CD, DisUnit, true);
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
				this.輪表示 = this.拘束_;
			}
		}

		public bool 虫鎌節_表示
		{
			get
			{
				return this.X0Y0_虫鎌節.Dra;
			}
			set
			{
				this.X0Y0_虫鎌節.Dra = value;
				this.X0Y0_虫鎌節.Hit = value;
			}
		}

		public bool 虫棘1_表示
		{
			get
			{
				return this.X0Y0_虫棘1.Dra;
			}
			set
			{
				this.X0Y0_虫棘1.Dra = value;
				this.X0Y0_虫棘1.Hit = value;
			}
		}

		public bool 虫棘2_表示
		{
			get
			{
				return this.X0Y0_虫棘2.Dra;
			}
			set
			{
				this.X0Y0_虫棘2.Dra = value;
				this.X0Y0_虫棘2.Hit = value;
			}
		}

		public bool 虫棘3_表示
		{
			get
			{
				return this.X0Y0_虫棘3.Dra;
			}
			set
			{
				this.X0Y0_虫棘3.Dra = value;
				this.X0Y0_虫棘3.Hit = value;
			}
		}

		public bool 虫棘4_表示
		{
			get
			{
				return this.X0Y0_虫棘4.Dra;
			}
			set
			{
				this.X0Y0_虫棘4.Dra = value;
				this.X0Y0_虫棘4.Hit = value;
			}
		}

		public bool 虫鎌1_表示
		{
			get
			{
				return this.X0Y0_虫鎌1.Dra;
			}
			set
			{
				this.X0Y0_虫鎌1.Dra = value;
				this.X0Y0_虫鎌1.Hit = value;
			}
		}

		public bool 虫鎌2_表示
		{
			get
			{
				return this.X0Y0_虫鎌2.Dra;
			}
			set
			{
				this.X0Y0_虫鎌2.Dra = value;
				this.X0Y0_虫鎌2.Hit = value;
			}
		}

		public bool 虫鎌3_表示
		{
			get
			{
				return this.X0Y0_虫鎌3.Dra;
			}
			set
			{
				this.X0Y0_虫鎌3.Dra = value;
				this.X0Y0_虫鎌3.Hit = value;
			}
		}

		public bool 虫孔1_表示
		{
			get
			{
				return this.X0Y0_虫孔1.Dra;
			}
			set
			{
				this.X0Y0_虫孔1.Dra = value;
				this.X0Y0_虫孔1.Hit = value;
			}
		}

		public bool 虫孔2_表示
		{
			get
			{
				return this.X0Y0_虫孔2.Dra;
			}
			set
			{
				this.X0Y0_虫孔2.Dra = value;
				this.X0Y0_虫孔2.Hit = value;
			}
		}

		public bool 輪_革_表示
		{
			get
			{
				return this.X0Y0_輪_革.Dra;
			}
			set
			{
				this.X0Y0_輪_革.Dra = value;
				this.X0Y0_輪_革.Hit = value;
			}
		}

		public bool 輪_金具1_表示
		{
			get
			{
				return this.X0Y0_輪_金具1.Dra;
			}
			set
			{
				this.X0Y0_輪_金具1.Dra = value;
				this.X0Y0_輪_金具1.Hit = value;
			}
		}

		public bool 輪_金具2_表示
		{
			get
			{
				return this.X0Y0_輪_金具2.Dra;
			}
			set
			{
				this.X0Y0_輪_金具2.Dra = value;
				this.X0Y0_輪_金具2.Hit = value;
			}
		}

		public bool 輪_金具3_表示
		{
			get
			{
				return this.X0Y0_輪_金具3.Dra;
			}
			set
			{
				this.X0Y0_輪_金具3.Dra = value;
				this.X0Y0_輪_金具3.Hit = value;
			}
		}

		public bool 輪_金具左_表示
		{
			get
			{
				return this.X0Y0_輪_金具左.Dra;
			}
			set
			{
				this.X0Y0_輪_金具左.Dra = value;
				this.X0Y0_輪_金具左.Hit = value;
			}
		}

		public bool 輪_金具右_表示
		{
			get
			{
				return this.X0Y0_輪_金具右.Dra;
			}
			set
			{
				this.X0Y0_輪_金具右.Dra = value;
				this.X0Y0_輪_金具右.Hit = value;
			}
		}

		public bool 輪表示
		{
			get
			{
				return this.輪_革_表示;
			}
			set
			{
				this.輪_革_表示 = value;
				this.輪_金具1_表示 = value;
				this.輪_金具2_表示 = value;
				this.輪_金具3_表示 = value;
				this.輪_金具左_表示 = value;
				this.輪_金具右_表示 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.虫鎌節_表示;
			}
			set
			{
				this.虫鎌節_表示 = value;
				this.虫棘1_表示 = value;
				this.虫棘2_表示 = value;
				this.虫棘3_表示 = value;
				this.虫棘4_表示 = value;
				this.虫鎌1_表示 = value;
				this.虫鎌2_表示 = value;
				this.虫鎌3_表示 = value;
				this.虫孔1_表示 = value;
				this.虫孔2_表示 = value;
				this.輪_革_表示 = value;
				this.輪_金具1_表示 = value;
				this.輪_金具2_表示 = value;
				this.輪_金具3_表示 = value;
				this.輪_金具左_表示 = value;
				this.輪_金具右_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.虫鎌節CD.不透明度;
			}
			set
			{
				this.虫鎌節CD.不透明度 = value;
				this.虫棘1CD.不透明度 = value;
				this.虫棘2CD.不透明度 = value;
				this.虫棘3CD.不透明度 = value;
				this.虫棘4CD.不透明度 = value;
				this.虫鎌1CD.不透明度 = value;
				this.虫鎌2CD.不透明度 = value;
				this.虫鎌3CD.不透明度 = value;
				this.虫孔1CD.不透明度 = value;
				this.虫孔2CD.不透明度 = value;
				this.輪_革CD.不透明度 = value;
				this.輪_金具1CD.不透明度 = value;
				this.輪_金具2CD.不透明度 = value;
				this.輪_金具3CD.不透明度 = value;
				this.輪_金具左CD.不透明度 = value;
				this.輪_金具右CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			num *= (this.反転Y ? -1.0 : 1.0);
			this.X0Y0_虫鎌1.AngleBase = num * -14.0;
			this.本体.JoinPAall();
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_輪_革 || p == this.X0Y0_輪_金具1 || p == this.X0Y0_輪_金具2 || p == this.X0Y0_輪_金具3 || p == this.X0Y0_輪_金具左 || p == this.X0Y0_輪_金具右;
		}

		public override bool 反転Y
		{
			get
			{
				return this.反転Y_;
			}
			set
			{
				if (this.反転Y_ != value)
				{
					this.本体.JoinPAall();
					this.本体.ReverseY();
					this.X0Y0_輪_革.ReverseY();
					this.X0Y0_輪_金具1.ReverseY();
					this.X0Y0_輪_金具2.ReverseY();
					this.X0Y0_輪_金具3.ReverseY();
					this.X0Y0_輪_金具左.ReverseY();
					this.X0Y0_輪_金具右.ReverseY();
					this.本体.JoinP();
				}
				this.反転Y_ = value;
			}
		}

		public override void 色更新()
		{
			this.X0Y0_虫鎌節CP.Update();
			this.X0Y0_虫棘1CP.Update();
			this.X0Y0_虫棘2CP.Update();
			this.X0Y0_虫棘3CP.Update();
			this.X0Y0_虫棘4CP.Update();
			this.X0Y0_虫鎌1CP.Update();
			this.X0Y0_虫鎌2CP.Update();
			this.X0Y0_虫鎌3CP.Update();
			this.X0Y0_虫孔1CP.Update();
			this.X0Y0_虫孔2CP.Update();
			this.X0Y0_輪_革CP.Update();
			this.X0Y0_輪_金具1CP.Update();
			this.X0Y0_輪_金具2CP.Update();
			this.X0Y0_輪_金具3CP.Update();
			this.X0Y0_輪_金具左CP.Update();
			this.X0Y0_輪_金具右CP.Update();
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
			this.虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫棘4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫鎌1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫鎌2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫鎌3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫孔1CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.虫孔2CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.輪_革CD = new ColorD();
			this.輪_金具1CD = new ColorD();
			this.輪_金具2CD = new ColorD();
			this.輪_金具3CD = new ColorD();
			this.輪_金具左CD = new ColorD();
			this.輪_金具右CD = new ColorD();
		}

		private void 配色T0(体配色 体配色)
		{
			this.虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫棘4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫鎌1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫鎌2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫鎌3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫孔1CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫孔2CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.輪_革CD = new ColorD();
			this.輪_金具1CD = new ColorD();
			this.輪_金具2CD = new ColorD();
			this.輪_金具3CD = new ColorD();
			this.輪_金具左CD = new ColorD();
			this.輪_金具右CD = new ColorD();
		}

		private void 配色T1(体配色 体配色)
		{
			this.虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫棘4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫鎌1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫鎌2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫鎌3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫孔1CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.虫孔2CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.輪_革CD = new ColorD();
			this.輪_金具1CD = new ColorD();
			this.輪_金具2CD = new ColorD();
			this.輪_金具3CD = new ColorD();
			this.輪_金具左CD = new ColorD();
			this.輪_金具右CD = new ColorD();
		}

		public void 輪配色(拘束具色 配色)
		{
			this.輪_革CD.色 = 配色.革部色;
			this.輪_金具1CD.色 = 配色.金具色;
			this.輪_金具2CD.色 = this.輪_金具1CD.色;
			this.輪_金具3CD.色 = this.輪_金具1CD.色;
			this.輪_金具左CD.色 = this.輪_金具1CD.色;
			this.輪_金具右CD.色 = this.輪_金具1CD.色;
		}

		public Par X0Y0_虫鎌節;

		public Par X0Y0_虫棘1;

		public Par X0Y0_虫棘2;

		public Par X0Y0_虫棘3;

		public Par X0Y0_虫棘4;

		public Par X0Y0_虫鎌1;

		public Par X0Y0_虫鎌2;

		public Par X0Y0_虫鎌3;

		public Par X0Y0_虫孔1;

		public Par X0Y0_虫孔2;

		public Par X0Y0_輪_革;

		public Par X0Y0_輪_金具1;

		public Par X0Y0_輪_金具2;

		public Par X0Y0_輪_金具3;

		public Par X0Y0_輪_金具左;

		public Par X0Y0_輪_金具右;

		public ColorD 虫鎌節CD;

		public ColorD 虫棘1CD;

		public ColorD 虫棘2CD;

		public ColorD 虫棘3CD;

		public ColorD 虫棘4CD;

		public ColorD 虫鎌1CD;

		public ColorD 虫鎌2CD;

		public ColorD 虫鎌3CD;

		public ColorD 虫孔1CD;

		public ColorD 虫孔2CD;

		public ColorD 輪_革CD;

		public ColorD 輪_金具1CD;

		public ColorD 輪_金具2CD;

		public ColorD 輪_金具3CD;

		public ColorD 輪_金具左CD;

		public ColorD 輪_金具右CD;

		public ColorP X0Y0_虫鎌節CP;

		public ColorP X0Y0_虫棘1CP;

		public ColorP X0Y0_虫棘2CP;

		public ColorP X0Y0_虫棘3CP;

		public ColorP X0Y0_虫棘4CP;

		public ColorP X0Y0_虫鎌1CP;

		public ColorP X0Y0_虫鎌2CP;

		public ColorP X0Y0_虫鎌3CP;

		public ColorP X0Y0_虫孔1CP;

		public ColorP X0Y0_虫孔2CP;

		public ColorP X0Y0_輪_革CP;

		public ColorP X0Y0_輪_金具1CP;

		public ColorP X0Y0_輪_金具2CP;

		public ColorP X0Y0_輪_金具3CP;

		public ColorP X0Y0_輪_金具左CP;

		public ColorP X0Y0_輪_金具右CP;
	}
}
