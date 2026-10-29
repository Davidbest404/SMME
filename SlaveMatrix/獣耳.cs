using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 獣耳 : Ele
	{
		public 獣耳(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 獣耳D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.肢左["獣耳"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_獣耳外 = pars["獣耳外"].ToPar();
			this.X0Y0_獣耳内 = pars["獣耳内"].ToPar();
			this.X0Y0_耳毛 = pars["耳毛"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_獣耳外 = pars["獣耳外"].ToPar();
			this.X0Y1_獣耳内 = pars["獣耳内"].ToPar();
			this.X0Y1_耳毛 = pars["耳毛"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_獣耳外 = pars["獣耳外"].ToPar();
			this.X0Y2_獣耳内 = pars["獣耳内"].ToPar();
			this.X0Y2_耳毛 = pars["耳毛"].ToPar();
			pars = this.本体[1][0];
			this.X1Y0_獣耳外 = pars["獣耳外"].ToPar();
			this.X1Y0_獣耳内 = pars["獣耳内"].ToPar();
			this.X1Y0_耳毛 = pars["耳毛"].ToPar();
			pars = this.本体[1][1];
			this.X1Y1_獣耳外 = pars["獣耳外"].ToPar();
			this.X1Y1_獣耳内 = pars["獣耳内"].ToPar();
			this.X1Y1_耳毛 = pars["耳毛"].ToPar();
			pars = this.本体[1][2];
			this.X1Y2_獣耳外 = pars["獣耳外"].ToPar();
			this.X1Y2_獣耳内 = pars["獣耳内"].ToPar();
			this.X1Y2_耳毛 = pars["耳毛"].ToPar();
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
			this.獣耳外_表示 = e.獣耳外_表示;
			this.獣耳内_表示 = e.獣耳内_表示;
			this.耳毛_表示 = e.耳毛_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_獣耳外CP = new ColorP(this.X0Y0_獣耳外, this.獣耳外CD, DisUnit, true);
			this.X0Y0_獣耳内CP = new ColorP(this.X0Y0_獣耳内, this.獣耳内CD, DisUnit, true);
			this.X0Y0_耳毛CP = new ColorP(this.X0Y0_耳毛, this.耳毛CD, DisUnit, true);
			this.X0Y1_獣耳外CP = new ColorP(this.X0Y1_獣耳外, this.獣耳外CD, DisUnit, true);
			this.X0Y1_獣耳内CP = new ColorP(this.X0Y1_獣耳内, this.獣耳内CD, DisUnit, true);
			this.X0Y1_耳毛CP = new ColorP(this.X0Y1_耳毛, this.耳毛CD, DisUnit, true);
			this.X0Y2_獣耳外CP = new ColorP(this.X0Y2_獣耳外, this.獣耳外CD, DisUnit, true);
			this.X0Y2_獣耳内CP = new ColorP(this.X0Y2_獣耳内, this.獣耳内CD, DisUnit, true);
			this.X0Y2_耳毛CP = new ColorP(this.X0Y2_耳毛, this.耳毛CD, DisUnit, true);
			this.X1Y0_獣耳外CP = new ColorP(this.X1Y0_獣耳外, this.獣耳外CD, DisUnit, true);
			this.X1Y0_獣耳内CP = new ColorP(this.X1Y0_獣耳内, this.獣耳内CD, DisUnit, true);
			this.X1Y0_耳毛CP = new ColorP(this.X1Y0_耳毛, this.耳毛CD, DisUnit, true);
			this.X1Y1_獣耳外CP = new ColorP(this.X1Y1_獣耳外, this.獣耳外CD, DisUnit, true);
			this.X1Y1_獣耳内CP = new ColorP(this.X1Y1_獣耳内, this.獣耳内CD, DisUnit, true);
			this.X1Y1_耳毛CP = new ColorP(this.X1Y1_耳毛, this.耳毛CD, DisUnit, true);
			this.X1Y2_獣耳外CP = new ColorP(this.X1Y2_獣耳外, this.獣耳外CD, DisUnit, true);
			this.X1Y2_獣耳内CP = new ColorP(this.X1Y2_獣耳内, this.獣耳内CD, DisUnit, true);
			this.X1Y2_耳毛CP = new ColorP(this.X1Y2_耳毛, this.耳毛CD, DisUnit, true);
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
				this.本体.IndexX = (this.欠損_ ? 1 : 0);
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

		public bool 獣耳外_表示
		{
			get
			{
				return this.X0Y0_獣耳外.Dra;
			}
			set
			{
				this.X0Y0_獣耳外.Dra = value;
				this.X0Y1_獣耳外.Dra = value;
				this.X0Y2_獣耳外.Dra = value;
				this.X1Y0_獣耳外.Dra = value;
				this.X1Y1_獣耳外.Dra = value;
				this.X1Y2_獣耳外.Dra = value;
				this.X0Y0_獣耳外.Hit = value;
				this.X0Y1_獣耳外.Hit = value;
				this.X0Y2_獣耳外.Hit = value;
				this.X1Y0_獣耳外.Hit = value;
				this.X1Y1_獣耳外.Hit = value;
				this.X1Y2_獣耳外.Hit = value;
			}
		}

		public bool 獣耳内_表示
		{
			get
			{
				return this.X0Y0_獣耳内.Dra;
			}
			set
			{
				this.X0Y0_獣耳内.Dra = value;
				this.X0Y1_獣耳内.Dra = value;
				this.X0Y2_獣耳内.Dra = value;
				this.X1Y0_獣耳内.Dra = value;
				this.X1Y1_獣耳内.Dra = value;
				this.X1Y2_獣耳内.Dra = value;
				this.X0Y0_獣耳内.Hit = value;
				this.X0Y1_獣耳内.Hit = value;
				this.X0Y2_獣耳内.Hit = value;
				this.X1Y0_獣耳内.Hit = value;
				this.X1Y1_獣耳内.Hit = value;
				this.X1Y2_獣耳内.Hit = value;
			}
		}

		public bool 耳毛_表示
		{
			get
			{
				return this.X0Y0_耳毛.Dra;
			}
			set
			{
				this.X0Y0_耳毛.Dra = value;
				this.X0Y1_耳毛.Dra = value;
				this.X0Y2_耳毛.Dra = value;
				this.X1Y0_耳毛.Dra = value;
				this.X1Y1_耳毛.Dra = value;
				this.X1Y2_耳毛.Dra = value;
				this.X0Y0_耳毛.Hit = value;
				this.X0Y1_耳毛.Hit = value;
				this.X0Y2_耳毛.Hit = value;
				this.X1Y0_耳毛.Hit = value;
				this.X1Y1_耳毛.Hit = value;
				this.X1Y2_耳毛.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.獣耳外_表示;
			}
			set
			{
				this.獣耳外_表示 = value;
				this.獣耳内_表示 = value;
				this.耳毛_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.獣耳外CD.不透明度;
			}
			set
			{
				this.獣耳外CD.不透明度 = value;
				this.獣耳内CD.不透明度 = value;
				this.耳毛CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_獣耳外.AngleBase = num * -46.0;
			this.X0Y1_獣耳外.AngleBase = num * -64.0;
			this.X0Y2_獣耳外.AngleBase = num * -78.0;
			this.X1Y0_獣耳外.AngleBase = num * -46.0;
			this.X1Y1_獣耳外.AngleBase = num * -64.0;
			this.X1Y2_獣耳外.AngleBase = num * -78.0;
			this.本体.JoinPAall();
		}

		public override void 色更新()
		{
			if (this.本体.IndexX == 0)
			{
				int indexY = this.本体.IndexY;
				if (indexY == 0)
				{
					this.X0Y0_獣耳外CP.Update();
					this.X0Y0_獣耳内CP.Update();
					this.X0Y0_耳毛CP.Update();
					return;
				}
				if (indexY != 1)
				{
					this.X0Y2_獣耳外CP.Update();
					this.X0Y2_獣耳内CP.Update();
					this.X0Y2_耳毛CP.Update();
					return;
				}
				this.X0Y1_獣耳外CP.Update();
				this.X0Y1_獣耳内CP.Update();
				this.X0Y1_耳毛CP.Update();
				return;
			}
			else
			{
				int indexY = this.本体.IndexY;
				if (indexY == 0)
				{
					this.X1Y0_獣耳外CP.Update();
					this.X1Y0_獣耳内CP.Update();
					this.X1Y0_耳毛CP.Update();
					return;
				}
				if (indexY != 1)
				{
					this.X1Y2_獣耳外CP.Update();
					this.X1Y2_獣耳内CP.Update();
					this.X1Y2_耳毛CP.Update();
					return;
				}
				this.X1Y1_獣耳外CP.Update();
				this.X1Y1_獣耳内CP.Update();
				this.X1Y1_耳毛CP.Update();
				return;
			}
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
			this.獣耳外CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣耳内CD = new ColorD(ref Col.Black, ref 体配色.人肌R);
			this.耳毛CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.獣耳外CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.獣耳内CD = new ColorD(ref Col.Black, ref 体配色.人肌R);
			this.耳毛CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.獣耳外CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.獣耳内CD = new ColorD(ref Col.Black, ref 体配色.人肌R);
			this.耳毛CD = new ColorD(ref Col.Black, ref 体配色.毛1O);
		}

		public Par X0Y0_獣耳外;

		public Par X0Y0_獣耳内;

		public Par X0Y0_耳毛;

		public Par X0Y1_獣耳外;

		public Par X0Y1_獣耳内;

		public Par X0Y1_耳毛;

		public Par X0Y2_獣耳外;

		public Par X0Y2_獣耳内;

		public Par X0Y2_耳毛;

		public Par X1Y0_獣耳外;

		public Par X1Y0_獣耳内;

		public Par X1Y0_耳毛;

		public Par X1Y1_獣耳外;

		public Par X1Y1_獣耳内;

		public Par X1Y1_耳毛;

		public Par X1Y2_獣耳外;

		public Par X1Y2_獣耳内;

		public Par X1Y2_耳毛;

		public ColorD 獣耳外CD;

		public ColorD 獣耳内CD;

		public ColorD 耳毛CD;

		public ColorP X0Y0_獣耳外CP;

		public ColorP X0Y0_獣耳内CP;

		public ColorP X0Y0_耳毛CP;

		public ColorP X0Y1_獣耳外CP;

		public ColorP X0Y1_獣耳内CP;

		public ColorP X0Y1_耳毛CP;

		public ColorP X0Y2_獣耳外CP;

		public ColorP X0Y2_獣耳内CP;

		public ColorP X0Y2_耳毛CP;

		public ColorP X1Y0_獣耳外CP;

		public ColorP X1Y0_獣耳内CP;

		public ColorP X1Y0_耳毛CP;

		public ColorP X1Y1_獣耳外CP;

		public ColorP X1Y1_獣耳内CP;

		public ColorP X1Y1_耳毛CP;

		public ColorP X1Y2_獣耳外CP;

		public ColorP X1Y2_獣耳内CP;

		public ColorP X1Y2_耳毛CP;
	}
}
