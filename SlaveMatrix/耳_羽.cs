using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 耳_羽 : 耳
	{
		public 耳_羽(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 耳_羽D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs();
			this.本体.Tag = "羽";
			this.本体.Add(new Dif(Sta.肢左["耳"][8]));
			this.本体.Add(new Dif(Sta.肢左["耳"][9]));
			Pars pars = this.本体[0][0];
			this.X0Y0_羽2 = pars["羽2"].ToPar();
			this.X0Y0_羽1 = pars["羽1"].ToPar();
			this.X0Y0_耳 = pars["耳"].ToPar();
			this.X0Y0_耳線1 = pars["耳線1"].ToPar();
			this.X0Y0_耳線2 = pars["耳線2"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_羽2 = pars["羽2"].ToPar();
			this.X0Y1_羽1 = pars["羽1"].ToPar();
			this.X0Y1_耳 = pars["耳"].ToPar();
			this.X0Y1_耳線1 = pars["耳線1"].ToPar();
			this.X0Y1_耳線2 = pars["耳線2"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_羽2 = pars["羽2"].ToPar();
			this.X0Y2_羽1 = pars["羽1"].ToPar();
			this.X0Y2_耳 = pars["耳"].ToPar();
			this.X0Y2_耳線1 = pars["耳線1"].ToPar();
			this.X0Y2_耳線2 = pars["耳線2"].ToPar();
			pars = this.本体[1][0];
			this.X1Y0_羽2 = pars["羽2"].ToPar();
			this.X1Y0_羽1 = pars["羽1"].ToPar();
			this.X1Y0_耳 = pars["耳"].ToPar();
			this.X1Y0_耳線1 = pars["耳線1"].ToPar();
			this.X1Y0_耳線2 = pars["耳線2"].ToPar();
			pars = this.本体[1][1];
			this.X1Y1_羽2 = pars["羽2"].ToPar();
			this.X1Y1_羽1 = pars["羽1"].ToPar();
			this.X1Y1_耳 = pars["耳"].ToPar();
			this.X1Y1_耳線1 = pars["耳線1"].ToPar();
			this.X1Y1_耳線2 = pars["耳線2"].ToPar();
			pars = this.本体[1][2];
			this.X1Y2_羽2 = pars["羽2"].ToPar();
			this.X1Y2_羽1 = pars["羽1"].ToPar();
			this.X1Y2_耳 = pars["耳"].ToPar();
			this.X1Y2_耳線1 = pars["耳線1"].ToPar();
			this.X1Y2_耳線2 = pars["耳線2"].ToPar();
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
			this.羽2_表示 = e.羽2_表示;
			this.羽1_表示 = e.羽1_表示;
			this.耳_表示 = e.耳_表示;
			this.耳線1_表示 = e.耳線1_表示;
			this.耳線2_表示 = e.耳線2_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_羽2CP = new ColorP(this.X0Y0_羽2, this.羽2CD, DisUnit, true);
			this.X0Y0_羽1CP = new ColorP(this.X0Y0_羽1, this.羽1CD, DisUnit, true);
			this.X0Y0_耳CP = new ColorP(this.X0Y0_耳, this.耳CD, DisUnit, true);
			this.X0Y0_耳線1CP = new ColorP(this.X0Y0_耳線1, this.耳線1CD, DisUnit, true);
			this.X0Y0_耳線2CP = new ColorP(this.X0Y0_耳線2, this.耳線2CD, DisUnit, true);
			this.X0Y1_羽2CP = new ColorP(this.X0Y1_羽2, this.羽2CD, DisUnit, true);
			this.X0Y1_羽1CP = new ColorP(this.X0Y1_羽1, this.羽1CD, DisUnit, true);
			this.X0Y1_耳CP = new ColorP(this.X0Y1_耳, this.耳CD, DisUnit, true);
			this.X0Y1_耳線1CP = new ColorP(this.X0Y1_耳線1, this.耳線1CD, DisUnit, true);
			this.X0Y1_耳線2CP = new ColorP(this.X0Y1_耳線2, this.耳線2CD, DisUnit, true);
			this.X0Y2_羽2CP = new ColorP(this.X0Y2_羽2, this.羽2CD, DisUnit, true);
			this.X0Y2_羽1CP = new ColorP(this.X0Y2_羽1, this.羽1CD, DisUnit, true);
			this.X0Y2_耳CP = new ColorP(this.X0Y2_耳, this.耳CD, DisUnit, true);
			this.X0Y2_耳線1CP = new ColorP(this.X0Y2_耳線1, this.耳線1CD, DisUnit, true);
			this.X0Y2_耳線2CP = new ColorP(this.X0Y2_耳線2, this.耳線2CD, DisUnit, true);
			this.X1Y0_羽2CP = new ColorP(this.X1Y0_羽2, this.羽2CD, DisUnit, true);
			this.X1Y0_羽1CP = new ColorP(this.X1Y0_羽1, this.羽1CD, DisUnit, true);
			this.X1Y0_耳CP = new ColorP(this.X1Y0_耳, this.耳CD, DisUnit, true);
			this.X1Y0_耳線1CP = new ColorP(this.X1Y0_耳線1, this.耳線1CD, DisUnit, true);
			this.X1Y0_耳線2CP = new ColorP(this.X1Y0_耳線2, this.耳線2CD, DisUnit, true);
			this.X1Y1_羽2CP = new ColorP(this.X1Y1_羽2, this.羽2CD, DisUnit, true);
			this.X1Y1_羽1CP = new ColorP(this.X1Y1_羽1, this.羽1CD, DisUnit, true);
			this.X1Y1_耳CP = new ColorP(this.X1Y1_耳, this.耳CD, DisUnit, true);
			this.X1Y1_耳線1CP = new ColorP(this.X1Y1_耳線1, this.耳線1CD, DisUnit, true);
			this.X1Y1_耳線2CP = new ColorP(this.X1Y1_耳線2, this.耳線2CD, DisUnit, true);
			this.X1Y2_羽2CP = new ColorP(this.X1Y2_羽2, this.羽2CD, DisUnit, true);
			this.X1Y2_羽1CP = new ColorP(this.X1Y2_羽1, this.羽1CD, DisUnit, true);
			this.X1Y2_耳CP = new ColorP(this.X1Y2_耳, this.耳CD, DisUnit, true);
			this.X1Y2_耳線1CP = new ColorP(this.X1Y2_耳線1, this.耳線1CD, DisUnit, true);
			this.X1Y2_耳線2CP = new ColorP(this.X1Y2_耳線2, this.耳線2CD, DisUnit, true);
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

		public bool 羽2_表示
		{
			get
			{
				return this.X0Y0_羽2.Dra;
			}
			set
			{
				this.X0Y0_羽2.Dra = value;
				this.X0Y1_羽2.Dra = value;
				this.X0Y2_羽2.Dra = value;
				this.X1Y0_羽2.Dra = value;
				this.X1Y1_羽2.Dra = value;
				this.X1Y2_羽2.Dra = value;
				this.X0Y0_羽2.Hit = value;
				this.X0Y1_羽2.Hit = value;
				this.X0Y2_羽2.Hit = value;
				this.X1Y0_羽2.Hit = value;
				this.X1Y1_羽2.Hit = value;
				this.X1Y2_羽2.Hit = value;
			}
		}

		public bool 羽1_表示
		{
			get
			{
				return this.X0Y0_羽1.Dra;
			}
			set
			{
				this.X0Y0_羽1.Dra = value;
				this.X0Y1_羽1.Dra = value;
				this.X0Y2_羽1.Dra = value;
				this.X1Y0_羽1.Dra = value;
				this.X1Y1_羽1.Dra = value;
				this.X1Y2_羽1.Dra = value;
				this.X0Y0_羽1.Hit = value;
				this.X0Y1_羽1.Hit = value;
				this.X0Y2_羽1.Hit = value;
				this.X1Y0_羽1.Hit = value;
				this.X1Y1_羽1.Hit = value;
				this.X1Y2_羽1.Hit = value;
			}
		}

		public bool 耳_表示
		{
			get
			{
				return this.X0Y0_耳.Dra;
			}
			set
			{
				this.X0Y0_耳.Dra = value;
				this.X0Y1_耳.Dra = value;
				this.X0Y2_耳.Dra = value;
				this.X1Y0_耳.Dra = value;
				this.X1Y1_耳.Dra = value;
				this.X1Y2_耳.Dra = value;
				this.X0Y0_耳.Hit = value;
				this.X0Y1_耳.Hit = value;
				this.X0Y2_耳.Hit = value;
				this.X1Y0_耳.Hit = value;
				this.X1Y1_耳.Hit = value;
				this.X1Y2_耳.Hit = value;
			}
		}

		public bool 耳線1_表示
		{
			get
			{
				return this.X0Y0_耳線1.Dra;
			}
			set
			{
				this.X0Y0_耳線1.Dra = value;
				this.X0Y1_耳線1.Dra = value;
				this.X0Y2_耳線1.Dra = value;
				this.X1Y0_耳線1.Dra = value;
				this.X1Y1_耳線1.Dra = value;
				this.X1Y2_耳線1.Dra = value;
				this.X0Y0_耳線1.Hit = value;
				this.X0Y1_耳線1.Hit = value;
				this.X0Y2_耳線1.Hit = value;
				this.X1Y0_耳線1.Hit = value;
				this.X1Y1_耳線1.Hit = value;
				this.X1Y2_耳線1.Hit = value;
			}
		}

		public bool 耳線2_表示
		{
			get
			{
				return this.X0Y0_耳線2.Dra;
			}
			set
			{
				this.X0Y0_耳線2.Dra = value;
				this.X0Y1_耳線2.Dra = value;
				this.X0Y2_耳線2.Dra = value;
				this.X1Y0_耳線2.Dra = value;
				this.X1Y1_耳線2.Dra = value;
				this.X1Y2_耳線2.Dra = value;
				this.X0Y0_耳線2.Hit = value;
				this.X0Y1_耳線2.Hit = value;
				this.X0Y2_耳線2.Hit = value;
				this.X1Y0_耳線2.Hit = value;
				this.X1Y1_耳線2.Hit = value;
				this.X1Y2_耳線2.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.羽2_表示;
			}
			set
			{
				this.羽2_表示 = value;
				this.羽1_表示 = value;
				this.耳_表示 = value;
				this.耳線1_表示 = value;
				this.耳線2_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.羽2CD.不透明度;
			}
			set
			{
				this.羽2CD.不透明度 = value;
				this.羽1CD.不透明度 = value;
				this.耳CD.不透明度 = value;
				this.耳線1CD.不透明度 = value;
				this.耳線2CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_耳.AngleBase = num * -314.0;
			this.X0Y0_羽1.AngleBase = num * -31.0;
			this.X0Y0_羽2.AngleBase = num * 291.0;
			this.X0Y1_耳.AngleBase = num * -333.0;
			this.X0Y1_羽1.AngleBase = num * -20.9999999999999;
			this.X0Y1_羽2.AngleBase = num * 313.0;
			this.X0Y2_耳.AngleBase = num * 0.0;
			this.X0Y2_羽1.AngleBase = num * -2.49999999999986;
			this.X0Y2_羽2.AngleBase = num * -16.0000000000001;
			this.X1Y0_耳.AngleBase = num * -314.0;
			this.X1Y0_羽1.AngleBase = num * -31.0;
			this.X1Y0_羽2.AngleBase = num * 291.0;
			this.X1Y1_耳.AngleBase = num * -333.0;
			this.X1Y1_羽1.AngleBase = num * -20.9999999999999;
			this.X1Y1_羽2.AngleBase = num * 313.0;
			this.X1Y2_耳.AngleBase = num * 0.0;
			this.X1Y2_羽1.AngleBase = num * -2.49999999999986;
			this.X1Y2_羽2.AngleBase = num * -16.0000000000001;
			this.本体.JoinPAall();
		}

		public override void 色更新()
		{
			if (this.本体.IndexX == 0)
			{
				int indexY = this.本体.IndexY;
				if (indexY == 0)
				{
					this.X0Y0_羽2CP.Update();
					this.X0Y0_羽1CP.Update();
					this.X0Y0_耳CP.Update();
					this.X0Y0_耳線1CP.Update();
					this.X0Y0_耳線2CP.Update();
					return;
				}
				if (indexY != 1)
				{
					this.X0Y2_羽2CP.Update();
					this.X0Y2_羽1CP.Update();
					this.X0Y2_耳CP.Update();
					this.X0Y2_耳線1CP.Update();
					this.X0Y2_耳線2CP.Update();
					return;
				}
				this.X0Y1_羽2CP.Update();
				this.X0Y1_羽1CP.Update();
				this.X0Y1_耳CP.Update();
				this.X0Y1_耳線1CP.Update();
				this.X0Y1_耳線2CP.Update();
				return;
			}
			else
			{
				int indexY = this.本体.IndexY;
				if (indexY == 0)
				{
					this.X1Y0_羽2CP.Update();
					this.X1Y0_羽1CP.Update();
					this.X1Y0_耳CP.Update();
					this.X1Y0_耳線1CP.Update();
					this.X1Y0_耳線2CP.Update();
					return;
				}
				if (indexY != 1)
				{
					this.X1Y2_羽2CP.Update();
					this.X1Y2_羽1CP.Update();
					this.X1Y2_耳CP.Update();
					this.X1Y2_耳線1CP.Update();
					this.X1Y2_耳線2CP.Update();
					return;
				}
				this.X1Y1_羽2CP.Update();
				this.X1Y1_羽1CP.Update();
				this.X1Y1_耳CP.Update();
				this.X1Y1_耳線1CP.Update();
				this.X1Y1_耳線2CP.Update();
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
			this.羽2CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.羽1CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.耳CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.耳線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.耳線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
		}

		private void 配色T0(体配色 体配色)
		{
			this.羽2CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.羽1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.耳CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.耳線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.耳線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
		}

		private void 配色T1(体配色 体配色)
		{
			this.羽2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.羽1CD = new ColorD(ref Col.Black, ref 体配色.羽0O);
			this.耳CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.耳線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.耳線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
		}

		public Par X0Y0_羽2;

		public Par X0Y0_羽1;

		public Par X0Y0_耳;

		public Par X0Y0_耳線1;

		public Par X0Y0_耳線2;

		public Par X0Y1_羽2;

		public Par X0Y1_羽1;

		public Par X0Y1_耳;

		public Par X0Y1_耳線1;

		public Par X0Y1_耳線2;

		public Par X0Y2_羽2;

		public Par X0Y2_羽1;

		public Par X0Y2_耳;

		public Par X0Y2_耳線1;

		public Par X0Y2_耳線2;

		public Par X1Y0_羽2;

		public Par X1Y0_羽1;

		public Par X1Y0_耳;

		public Par X1Y0_耳線1;

		public Par X1Y0_耳線2;

		public Par X1Y1_羽2;

		public Par X1Y1_羽1;

		public Par X1Y1_耳;

		public Par X1Y1_耳線1;

		public Par X1Y1_耳線2;

		public Par X1Y2_羽2;

		public Par X1Y2_羽1;

		public Par X1Y2_耳;

		public Par X1Y2_耳線1;

		public Par X1Y2_耳線2;

		public ColorD 羽2CD;

		public ColorD 羽1CD;

		public ColorD 耳CD;

		public ColorD 耳線1CD;

		public ColorD 耳線2CD;

		public ColorP X0Y0_羽2CP;

		public ColorP X0Y0_羽1CP;

		public ColorP X0Y0_耳CP;

		public ColorP X0Y0_耳線1CP;

		public ColorP X0Y0_耳線2CP;

		public ColorP X0Y1_羽2CP;

		public ColorP X0Y1_羽1CP;

		public ColorP X0Y1_耳CP;

		public ColorP X0Y1_耳線1CP;

		public ColorP X0Y1_耳線2CP;

		public ColorP X0Y2_羽2CP;

		public ColorP X0Y2_羽1CP;

		public ColorP X0Y2_耳CP;

		public ColorP X0Y2_耳線1CP;

		public ColorP X0Y2_耳線2CP;

		public ColorP X1Y0_羽2CP;

		public ColorP X1Y0_羽1CP;

		public ColorP X1Y0_耳CP;

		public ColorP X1Y0_耳線1CP;

		public ColorP X1Y0_耳線2CP;

		public ColorP X1Y1_羽2CP;

		public ColorP X1Y1_羽1CP;

		public ColorP X1Y1_耳CP;

		public ColorP X1Y1_耳線1CP;

		public ColorP X1Y1_耳線2CP;

		public ColorP X1Y2_羽2CP;

		public ColorP X1Y2_羽1CP;

		public ColorP X1Y2_耳CP;

		public ColorP X1Y2_耳線1CP;

		public ColorP X1Y2_耳線2CP;
	}
}
