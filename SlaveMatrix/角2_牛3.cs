using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 角2_牛3 : 角2
	{
		public 角2_牛3(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 角2_牛3D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.肢左["角"][6]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_根 = pars["根"].ToPar();
			this.X0Y0_凹1 = pars["凹1"].ToPar();
			this.X0Y0_凹2 = pars["凹2"].ToPar();
			this.X0Y0_凹3 = pars["凹3"].ToPar();
			this.X0Y0_凹4 = pars["凹4"].ToPar();
			this.X0Y0_凹5 = pars["凹5"].ToPar();
			this.X0Y0_凹6 = pars["凹6"].ToPar();
			this.X0Y0_凹7 = pars["凹7"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_根 = pars["根"].ToPar();
			this.X0Y1_凹1 = pars["凹1"].ToPar();
			this.X0Y1_凹2 = pars["凹2"].ToPar();
			this.X0Y1_凹3 = pars["凹3"].ToPar();
			this.X0Y1_凹4 = pars["凹4"].ToPar();
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
			this.根_表示 = e.根_表示;
			this.凹1_表示 = e.凹1_表示;
			this.凹2_表示 = e.凹2_表示;
			this.凹3_表示 = e.凹3_表示;
			this.凹4_表示 = e.凹4_表示;
			this.凹5_表示 = e.凹5_表示;
			this.凹6_表示 = e.凹6_表示;
			this.凹7_表示 = e.凹7_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_根CP = new ColorP(this.X0Y0_根, this.根CD, DisUnit, true);
			this.X0Y0_凹1CP = new ColorP(this.X0Y0_凹1, this.凹1CD, DisUnit, true);
			this.X0Y0_凹2CP = new ColorP(this.X0Y0_凹2, this.凹2CD, DisUnit, true);
			this.X0Y0_凹3CP = new ColorP(this.X0Y0_凹3, this.凹3CD, DisUnit, true);
			this.X0Y0_凹4CP = new ColorP(this.X0Y0_凹4, this.凹4CD, DisUnit, true);
			this.X0Y0_凹5CP = new ColorP(this.X0Y0_凹5, this.凹5CD, DisUnit, true);
			this.X0Y0_凹6CP = new ColorP(this.X0Y0_凹6, this.凹6CD, DisUnit, true);
			this.X0Y0_凹7CP = new ColorP(this.X0Y0_凹7, this.凹7CD, DisUnit, true);
			this.X0Y1_根CP = new ColorP(this.X0Y1_根, this.根CD, DisUnit, true);
			this.X0Y1_凹1CP = new ColorP(this.X0Y1_凹1, this.凹1CD, DisUnit, true);
			this.X0Y1_凹2CP = new ColorP(this.X0Y1_凹2, this.凹2CD, DisUnit, true);
			this.X0Y1_凹3CP = new ColorP(this.X0Y1_凹3, this.凹3CD, DisUnit, true);
			this.X0Y1_凹4CP = new ColorP(this.X0Y1_凹4, this.凹4CD, DisUnit, true);
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

		public bool 根_表示
		{
			get
			{
				return this.X0Y0_根.Dra;
			}
			set
			{
				this.X0Y0_根.Dra = value;
				this.X0Y1_根.Dra = value;
				this.X0Y0_根.Hit = value;
				this.X0Y1_根.Hit = value;
			}
		}

		public bool 凹1_表示
		{
			get
			{
				return this.X0Y0_凹1.Dra;
			}
			set
			{
				this.X0Y0_凹1.Dra = value;
				this.X0Y1_凹1.Dra = value;
				this.X0Y0_凹1.Hit = value;
				this.X0Y1_凹1.Hit = value;
			}
		}

		public bool 凹2_表示
		{
			get
			{
				return this.X0Y0_凹2.Dra;
			}
			set
			{
				this.X0Y0_凹2.Dra = value;
				this.X0Y1_凹2.Dra = value;
				this.X0Y0_凹2.Hit = value;
				this.X0Y1_凹2.Hit = value;
			}
		}

		public bool 凹3_表示
		{
			get
			{
				return this.X0Y0_凹3.Dra;
			}
			set
			{
				this.X0Y0_凹3.Dra = value;
				this.X0Y1_凹3.Dra = value;
				this.X0Y0_凹3.Hit = value;
				this.X0Y1_凹3.Hit = value;
			}
		}

		public bool 凹4_表示
		{
			get
			{
				return this.X0Y0_凹4.Dra;
			}
			set
			{
				this.X0Y0_凹4.Dra = value;
				this.X0Y1_凹4.Dra = value;
				this.X0Y0_凹4.Hit = value;
				this.X0Y1_凹4.Hit = value;
			}
		}

		public bool 凹5_表示
		{
			get
			{
				return this.X0Y0_凹5.Dra;
			}
			set
			{
				this.X0Y0_凹5.Dra = value;
				this.X0Y0_凹5.Hit = value;
			}
		}

		public bool 凹6_表示
		{
			get
			{
				return this.X0Y0_凹6.Dra;
			}
			set
			{
				this.X0Y0_凹6.Dra = value;
				this.X0Y0_凹6.Hit = value;
			}
		}

		public bool 凹7_表示
		{
			get
			{
				return this.X0Y0_凹7.Dra;
			}
			set
			{
				this.X0Y0_凹7.Dra = value;
				this.X0Y0_凹7.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.根_表示;
			}
			set
			{
				this.根_表示 = value;
				this.凹1_表示 = value;
				this.凹2_表示 = value;
				this.凹3_表示 = value;
				this.凹4_表示 = value;
				this.凹5_表示 = value;
				this.凹6_表示 = value;
				this.凹7_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.根CD.不透明度;
			}
			set
			{
				this.根CD.不透明度 = value;
				this.凹1CD.不透明度 = value;
				this.凹2CD.不透明度 = value;
				this.凹3CD.不透明度 = value;
				this.凹4CD.不透明度 = value;
				this.凹5CD.不透明度 = value;
				this.凹6CD.不透明度 = value;
				this.凹7CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_根.AngleBase = num * -4.00000000000013;
			this.X0Y1_根.AngleBase = num * -4.00000000000013;
			this.本体.JoinPAall();
		}

		public override void 色更新()
		{
			if (this.本体.IndexY == 0)
			{
				this.X0Y0_根CP.Update();
				this.X0Y0_凹1CP.Update();
				this.X0Y0_凹2CP.Update();
				this.X0Y0_凹3CP.Update();
				this.X0Y0_凹4CP.Update();
				this.X0Y0_凹5CP.Update();
				this.X0Y0_凹6CP.Update();
				this.X0Y0_凹7CP.Update();
				return;
			}
			this.X0Y1_根CP.Update();
			this.X0Y1_凹1CP.Update();
			this.X0Y1_凹2CP.Update();
			this.X0Y1_凹3CP.Update();
			this.X0Y1_凹4CP.Update();
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
			this.根CD = new ColorD(ref Col.Black, ref 体配色.角0O);
			this.凹1CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凹2CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凹3CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凹4CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凹5CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凹6CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凹7CD = new ColorD(ref Col.Black, ref 体配色.角1O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.根CD = new ColorD(ref Col.Black, ref 体配色.角0O);
			this.凹1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.凹2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.凹3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.凹4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.凹5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.凹6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.凹7CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.根CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.凹1CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凹2CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凹3CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凹4CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凹5CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凹6CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凹7CD = new ColorD(ref Col.Black, ref 体配色.角1O);
		}

		public Par X0Y0_根;

		public Par X0Y0_凹1;

		public Par X0Y0_凹2;

		public Par X0Y0_凹3;

		public Par X0Y0_凹4;

		public Par X0Y0_凹5;

		public Par X0Y0_凹6;

		public Par X0Y0_凹7;

		public Par X0Y1_根;

		public Par X0Y1_凹1;

		public Par X0Y1_凹2;

		public Par X0Y1_凹3;

		public Par X0Y1_凹4;

		public ColorD 根CD;

		public ColorD 凹1CD;

		public ColorD 凹2CD;

		public ColorD 凹3CD;

		public ColorD 凹4CD;

		public ColorD 凹5CD;

		public ColorD 凹6CD;

		public ColorD 凹7CD;

		public ColorP X0Y0_根CP;

		public ColorP X0Y0_凹1CP;

		public ColorP X0Y0_凹2CP;

		public ColorP X0Y0_凹3CP;

		public ColorP X0Y0_凹4CP;

		public ColorP X0Y0_凹5CP;

		public ColorP X0Y0_凹6CP;

		public ColorP X0Y0_凹7CP;

		public ColorP X0Y1_根CP;

		public ColorP X0Y1_凹1CP;

		public ColorP X0Y1_凹2CP;

		public ColorP X0Y1_凹3CP;

		public ColorP X0Y1_凹4CP;
	}
}
