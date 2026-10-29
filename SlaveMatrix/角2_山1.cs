using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 角2_山1 : 角2
	{
		public 角2_山1(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 角2_山1D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.肢左["角"][0]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_根 = pars["根"].ToPar();
			this.X0Y0_凸1 = pars["凸1"].ToPar();
			this.X0Y0_凸2 = pars["凸2"].ToPar();
			this.X0Y0_凸3 = pars["凸3"].ToPar();
			this.X0Y0_凸4 = pars["凸4"].ToPar();
			this.X0Y0_凸5 = pars["凸5"].ToPar();
			this.X0Y0_凸6 = pars["凸6"].ToPar();
			this.X0Y0_凸7 = pars["凸7"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_根 = pars["根"].ToPar();
			this.X0Y1_折線 = pars["折線"].ToPar();
			this.X0Y1_凸1 = pars["凸1"].ToPar();
			this.X0Y1_凸2 = pars["凸2"].ToPar();
			this.X0Y1_凸3 = pars["凸3"].ToPar();
			this.X0Y1_凸4 = pars["凸4"].ToPar();
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
			this.凸1_表示 = e.凸1_表示;
			this.凸2_表示 = e.凸2_表示;
			this.凸3_表示 = e.凸3_表示;
			this.凸4_表示 = e.凸4_表示;
			this.凸5_表示 = e.凸5_表示;
			this.凸6_表示 = e.凸6_表示;
			this.凸7_表示 = e.凸7_表示;
			this.折線_表示 = e.折線_表示;
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
			this.X0Y0_凸1CP = new ColorP(this.X0Y0_凸1, this.凸1CD, DisUnit, true);
			this.X0Y0_凸2CP = new ColorP(this.X0Y0_凸2, this.凸2CD, DisUnit, true);
			this.X0Y0_凸3CP = new ColorP(this.X0Y0_凸3, this.凸3CD, DisUnit, true);
			this.X0Y0_凸4CP = new ColorP(this.X0Y0_凸4, this.凸4CD, DisUnit, true);
			this.X0Y0_凸5CP = new ColorP(this.X0Y0_凸5, this.凸5CD, DisUnit, true);
			this.X0Y0_凸6CP = new ColorP(this.X0Y0_凸6, this.凸6CD, DisUnit, true);
			this.X0Y0_凸7CP = new ColorP(this.X0Y0_凸7, this.凸7CD, DisUnit, true);
			this.X0Y1_根CP = new ColorP(this.X0Y1_根, this.根CD, DisUnit, true);
			this.X0Y1_折線CP = new ColorP(this.X0Y1_折線, this.折線CD, DisUnit, true);
			this.X0Y1_凸1CP = new ColorP(this.X0Y1_凸1, this.凸1CD, DisUnit, true);
			this.X0Y1_凸2CP = new ColorP(this.X0Y1_凸2, this.凸2CD, DisUnit, true);
			this.X0Y1_凸3CP = new ColorP(this.X0Y1_凸3, this.凸3CD, DisUnit, true);
			this.X0Y1_凸4CP = new ColorP(this.X0Y1_凸4, this.凸4CD, DisUnit, true);
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

		public bool 凸1_表示
		{
			get
			{
				return this.X0Y0_凸1.Dra;
			}
			set
			{
				this.X0Y0_凸1.Dra = value;
				this.X0Y1_凸1.Dra = value;
				this.X0Y0_凸1.Hit = value;
				this.X0Y1_凸1.Hit = value;
			}
		}

		public bool 凸2_表示
		{
			get
			{
				return this.X0Y0_凸2.Dra;
			}
			set
			{
				this.X0Y0_凸2.Dra = value;
				this.X0Y1_凸2.Dra = value;
				this.X0Y0_凸2.Hit = value;
				this.X0Y1_凸2.Hit = value;
			}
		}

		public bool 凸3_表示
		{
			get
			{
				return this.X0Y0_凸3.Dra;
			}
			set
			{
				this.X0Y0_凸3.Dra = value;
				this.X0Y1_凸3.Dra = value;
				this.X0Y0_凸3.Hit = value;
				this.X0Y1_凸3.Hit = value;
			}
		}

		public bool 凸4_表示
		{
			get
			{
				return this.X0Y0_凸4.Dra;
			}
			set
			{
				this.X0Y0_凸4.Dra = value;
				this.X0Y1_凸4.Dra = value;
				this.X0Y0_凸4.Hit = value;
				this.X0Y1_凸4.Hit = value;
			}
		}

		public bool 凸5_表示
		{
			get
			{
				return this.X0Y0_凸5.Dra;
			}
			set
			{
				this.X0Y0_凸5.Dra = value;
				this.X0Y0_凸5.Hit = value;
			}
		}

		public bool 凸6_表示
		{
			get
			{
				return this.X0Y0_凸6.Dra;
			}
			set
			{
				this.X0Y0_凸6.Dra = value;
				this.X0Y0_凸6.Hit = value;
			}
		}

		public bool 凸7_表示
		{
			get
			{
				return this.X0Y0_凸7.Dra;
			}
			set
			{
				this.X0Y0_凸7.Dra = value;
				this.X0Y0_凸7.Hit = value;
			}
		}

		public bool 折線_表示
		{
			get
			{
				return this.X0Y1_折線.Dra;
			}
			set
			{
				this.X0Y1_折線.Dra = value;
				this.X0Y1_折線.Hit = value;
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
				this.凸1_表示 = value;
				this.凸2_表示 = value;
				this.凸3_表示 = value;
				this.凸4_表示 = value;
				this.凸5_表示 = value;
				this.凸6_表示 = value;
				this.凸7_表示 = value;
				this.折線_表示 = value;
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
				this.凸1CD.不透明度 = value;
				this.凸2CD.不透明度 = value;
				this.凸3CD.不透明度 = value;
				this.凸4CD.不透明度 = value;
				this.凸5CD.不透明度 = value;
				this.凸6CD.不透明度 = value;
				this.凸7CD.不透明度 = value;
				this.折線CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_根.AngleBase = num * -47.9999999999999;
			this.X0Y1_根.AngleBase = num * -47.9999999999999;
			this.本体.JoinPAall();
		}

		public override void 色更新()
		{
			if (this.本体.IndexY == 0)
			{
				this.X0Y0_根CP.Update();
				this.X0Y0_凸1CP.Update();
				this.X0Y0_凸2CP.Update();
				this.X0Y0_凸3CP.Update();
				this.X0Y0_凸4CP.Update();
				this.X0Y0_凸5CP.Update();
				this.X0Y0_凸6CP.Update();
				this.X0Y0_凸7CP.Update();
				return;
			}
			this.X0Y1_根CP.Update();
			this.X0Y1_折線CP.Update();
			this.X0Y1_凸1CP.Update();
			this.X0Y1_凸2CP.Update();
			this.X0Y1_凸3CP.Update();
			this.X0Y1_凸4CP.Update();
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
			this.凸1CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凸2CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凸3CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凸4CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凸5CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凸6CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凸7CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.折線CD = new ColorD(ref Col.Black, ref Color2.Empty);
		}

		private void 配色T0(体配色 体配色)
		{
			this.根CD = new ColorD(ref Col.Black, ref 体配色.角0O);
			this.凸1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.凸2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.凸3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.凸4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.凸5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.凸6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.凸7CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.折線CD = new ColorD(ref Col.Black, ref Color2.Empty);
		}

		private void 配色T1(体配色 体配色)
		{
			this.根CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.凸1CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凸2CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凸3CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凸4CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凸5CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凸6CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.凸7CD = new ColorD(ref Col.Black, ref 体配色.角1O);
			this.折線CD = new ColorD(ref Col.Black, ref Color2.Empty);
		}

		public Par X0Y0_根;

		public Par X0Y0_凸1;

		public Par X0Y0_凸2;

		public Par X0Y0_凸3;

		public Par X0Y0_凸4;

		public Par X0Y0_凸5;

		public Par X0Y0_凸6;

		public Par X0Y0_凸7;

		public Par X0Y1_根;

		public Par X0Y1_折線;

		public Par X0Y1_凸1;

		public Par X0Y1_凸2;

		public Par X0Y1_凸3;

		public Par X0Y1_凸4;

		public ColorD 根CD;

		public ColorD 凸1CD;

		public ColorD 凸2CD;

		public ColorD 凸3CD;

		public ColorD 凸4CD;

		public ColorD 凸5CD;

		public ColorD 凸6CD;

		public ColorD 凸7CD;

		public ColorD 折線CD;

		public ColorP X0Y0_根CP;

		public ColorP X0Y0_凸1CP;

		public ColorP X0Y0_凸2CP;

		public ColorP X0Y0_凸3CP;

		public ColorP X0Y0_凸4CP;

		public ColorP X0Y0_凸5CP;

		public ColorP X0Y0_凸6CP;

		public ColorP X0Y0_凸7CP;

		public ColorP X0Y1_根CP;

		public ColorP X0Y1_折線CP;

		public ColorP X0Y1_凸1CP;

		public ColorP X0Y1_凸2CP;

		public ColorP X0Y1_凸3CP;

		public ColorP X0Y1_凸4CP;
	}
}
