using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 頬瞼 : Ele
	{
		public 頬瞼(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 頬瞼D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["頬瞼左"]);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["瞼左"].ToPars();
			this.X0Y0_瞼左_瞼 = pars2["瞼"].ToPar();
			this.X0Y0_瞼左_睫毛1 = pars2["睫毛1"].ToPar();
			this.X0Y0_瞼左_睫毛2 = pars2["睫毛2"].ToPar();
			pars2 = pars["瞼右"].ToPars();
			this.X0Y0_瞼右_瞼 = pars2["瞼"].ToPar();
			this.X0Y0_瞼右_睫毛1 = pars2["睫毛1"].ToPar();
			this.X0Y0_瞼右_睫毛2 = pars2["睫毛2"].ToPar();
			Pars pars3 = this.本体[0][1];
			pars2 = pars3["瞼左"].ToPars();
			this.X0Y1_瞼左_瞼 = pars2["瞼"].ToPar();
			this.X0Y1_瞼左_睫毛1 = pars2["睫毛1"].ToPar();
			this.X0Y1_瞼左_睫毛2 = pars2["睫毛2"].ToPar();
			pars2 = pars3["瞼右"].ToPars();
			this.X0Y1_瞼右_瞼 = pars2["瞼"].ToPar();
			this.X0Y1_瞼右_睫毛1 = pars2["睫毛1"].ToPar();
			this.X0Y1_瞼右_睫毛2 = pars2["睫毛2"].ToPar();
			Pars pars4 = this.本体[0][2];
			pars2 = pars4["瞼左"].ToPars();
			this.X0Y2_瞼左_瞼 = pars2["瞼"].ToPar();
			this.X0Y2_瞼左_睫毛1 = pars2["睫毛1"].ToPar();
			this.X0Y2_瞼左_睫毛2 = pars2["睫毛2"].ToPar();
			pars2 = pars4["瞼右"].ToPars();
			this.X0Y2_瞼右_瞼 = pars2["瞼"].ToPar();
			this.X0Y2_瞼右_睫毛1 = pars2["睫毛1"].ToPar();
			this.X0Y2_瞼右_睫毛2 = pars2["睫毛2"].ToPar();
			Pars pars5 = this.本体[0][3];
			pars2 = pars5["瞼左"].ToPars();
			this.X0Y3_瞼左_瞼 = pars2["瞼"].ToPar();
			this.X0Y3_瞼左_睫毛1 = pars2["睫毛1"].ToPar();
			this.X0Y3_瞼左_睫毛2 = pars2["睫毛2"].ToPar();
			pars2 = pars5["瞼右"].ToPars();
			this.X0Y3_瞼右_瞼 = pars2["瞼"].ToPar();
			this.X0Y3_瞼右_睫毛1 = pars2["睫毛1"].ToPar();
			this.X0Y3_瞼右_睫毛2 = pars2["睫毛2"].ToPar();
			Pars pars6 = this.本体[0][4];
			pars2 = pars6["瞼左"].ToPars();
			this.X0Y4_瞼左_瞼 = pars2["瞼"].ToPar();
			this.X0Y4_瞼左_睫毛1 = pars2["睫毛1"].ToPar();
			this.X0Y4_瞼左_睫毛2 = pars2["睫毛2"].ToPar();
			pars2 = pars6["瞼右"].ToPars();
			this.X0Y4_瞼右_瞼 = pars2["瞼"].ToPar();
			this.X0Y4_瞼右_睫毛1 = pars2["睫毛1"].ToPar();
			this.X0Y4_瞼右_睫毛2 = pars2["睫毛2"].ToPar();
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
			this.瞼左_瞼_表示 = e.瞼左_瞼_表示;
			this.瞼左_睫毛1_表示 = e.瞼左_睫毛1_表示;
			this.瞼左_睫毛2_表示 = e.瞼左_睫毛2_表示;
			this.瞼右_瞼_表示 = e.瞼右_瞼_表示;
			this.瞼右_睫毛1_表示 = e.瞼右_睫毛1_表示;
			this.瞼右_睫毛2_表示 = e.瞼右_睫毛2_表示;
			this.外線 = e.外線;
			this.瞼左_睫毛1_長さ = e.瞼左_睫毛1_長さ;
			this.瞼左_睫毛2_長さ = e.瞼左_睫毛2_長さ;
			this.瞼右_睫毛1_長さ = e.瞼右_睫毛1_長さ;
			this.瞼右_睫毛2_長さ = e.瞼右_睫毛2_長さ;
			this.傾き = e.傾き;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_瞼左_瞼CP = new ColorP(this.X0Y0_瞼左_瞼, this.瞼左_瞼CD, DisUnit, true);
			this.X0Y0_瞼左_睫毛1CP = new ColorP(this.X0Y0_瞼左_睫毛1, this.瞼左_睫毛1CD, DisUnit, true);
			this.X0Y0_瞼左_睫毛2CP = new ColorP(this.X0Y0_瞼左_睫毛2, this.瞼左_睫毛2CD, DisUnit, true);
			this.X0Y0_瞼右_瞼CP = new ColorP(this.X0Y0_瞼右_瞼, this.瞼右_瞼CD, DisUnit, true);
			this.X0Y0_瞼右_睫毛1CP = new ColorP(this.X0Y0_瞼右_睫毛1, this.瞼右_睫毛1CD, DisUnit, true);
			this.X0Y0_瞼右_睫毛2CP = new ColorP(this.X0Y0_瞼右_睫毛2, this.瞼右_睫毛2CD, DisUnit, true);
			this.X0Y1_瞼左_瞼CP = new ColorP(this.X0Y1_瞼左_瞼, this.瞼左_瞼CD, DisUnit, true);
			this.X0Y1_瞼左_睫毛1CP = new ColorP(this.X0Y1_瞼左_睫毛1, this.瞼左_睫毛1CD, DisUnit, true);
			this.X0Y1_瞼左_睫毛2CP = new ColorP(this.X0Y1_瞼左_睫毛2, this.瞼左_睫毛2CD, DisUnit, true);
			this.X0Y1_瞼右_瞼CP = new ColorP(this.X0Y1_瞼右_瞼, this.瞼右_瞼CD, DisUnit, true);
			this.X0Y1_瞼右_睫毛1CP = new ColorP(this.X0Y1_瞼右_睫毛1, this.瞼右_睫毛1CD, DisUnit, true);
			this.X0Y1_瞼右_睫毛2CP = new ColorP(this.X0Y1_瞼右_睫毛2, this.瞼右_睫毛2CD, DisUnit, true);
			this.X0Y2_瞼左_瞼CP = new ColorP(this.X0Y2_瞼左_瞼, this.瞼左_瞼CD, DisUnit, true);
			this.X0Y2_瞼左_睫毛1CP = new ColorP(this.X0Y2_瞼左_睫毛1, this.瞼左_睫毛1CD, DisUnit, true);
			this.X0Y2_瞼左_睫毛2CP = new ColorP(this.X0Y2_瞼左_睫毛2, this.瞼左_睫毛2CD, DisUnit, true);
			this.X0Y2_瞼右_瞼CP = new ColorP(this.X0Y2_瞼右_瞼, this.瞼右_瞼CD, DisUnit, true);
			this.X0Y2_瞼右_睫毛1CP = new ColorP(this.X0Y2_瞼右_睫毛1, this.瞼右_睫毛1CD, DisUnit, true);
			this.X0Y2_瞼右_睫毛2CP = new ColorP(this.X0Y2_瞼右_睫毛2, this.瞼右_睫毛2CD, DisUnit, true);
			this.X0Y3_瞼左_瞼CP = new ColorP(this.X0Y3_瞼左_瞼, this.瞼左_瞼CD, DisUnit, true);
			this.X0Y3_瞼左_睫毛1CP = new ColorP(this.X0Y3_瞼左_睫毛1, this.瞼左_睫毛1CD, DisUnit, true);
			this.X0Y3_瞼左_睫毛2CP = new ColorP(this.X0Y3_瞼左_睫毛2, this.瞼左_睫毛2CD, DisUnit, true);
			this.X0Y3_瞼右_瞼CP = new ColorP(this.X0Y3_瞼右_瞼, this.瞼右_瞼CD, DisUnit, true);
			this.X0Y3_瞼右_睫毛1CP = new ColorP(this.X0Y3_瞼右_睫毛1, this.瞼右_睫毛1CD, DisUnit, true);
			this.X0Y3_瞼右_睫毛2CP = new ColorP(this.X0Y3_瞼右_睫毛2, this.瞼右_睫毛2CD, DisUnit, true);
			this.X0Y4_瞼左_瞼CP = new ColorP(this.X0Y4_瞼左_瞼, this.瞼左_瞼CD, DisUnit, true);
			this.X0Y4_瞼左_睫毛1CP = new ColorP(this.X0Y4_瞼左_睫毛1, this.瞼左_睫毛1CD, DisUnit, true);
			this.X0Y4_瞼左_睫毛2CP = new ColorP(this.X0Y4_瞼左_睫毛2, this.瞼左_睫毛2CD, DisUnit, true);
			this.X0Y4_瞼右_瞼CP = new ColorP(this.X0Y4_瞼右_瞼, this.瞼右_瞼CD, DisUnit, true);
			this.X0Y4_瞼右_睫毛1CP = new ColorP(this.X0Y4_瞼右_睫毛1, this.瞼右_睫毛1CD, DisUnit, true);
			this.X0Y4_瞼右_睫毛2CP = new ColorP(this.X0Y4_瞼右_睫毛2, this.瞼右_睫毛2CD, DisUnit, true);
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

		public bool 瞼左_瞼_表示
		{
			get
			{
				return this.X0Y0_瞼左_瞼.Dra;
			}
			set
			{
				this.X0Y0_瞼左_瞼.Dra = value;
				this.X0Y1_瞼左_瞼.Dra = value;
				this.X0Y2_瞼左_瞼.Dra = value;
				this.X0Y3_瞼左_瞼.Dra = value;
				this.X0Y4_瞼左_瞼.Dra = value;
				this.X0Y0_瞼左_瞼.Hit = value;
				this.X0Y1_瞼左_瞼.Hit = value;
				this.X0Y2_瞼左_瞼.Hit = value;
				this.X0Y3_瞼左_瞼.Hit = value;
				this.X0Y4_瞼左_瞼.Hit = value;
			}
		}

		public bool 瞼左_睫毛1_表示
		{
			get
			{
				return this.X0Y0_瞼左_睫毛1.Dra;
			}
			set
			{
				this.X0Y0_瞼左_睫毛1.Dra = value;
				this.X0Y1_瞼左_睫毛1.Dra = value;
				this.X0Y2_瞼左_睫毛1.Dra = value;
				this.X0Y3_瞼左_睫毛1.Dra = value;
				this.X0Y4_瞼左_睫毛1.Dra = value;
				this.X0Y0_瞼左_睫毛1.Hit = value;
				this.X0Y1_瞼左_睫毛1.Hit = value;
				this.X0Y2_瞼左_睫毛1.Hit = value;
				this.X0Y3_瞼左_睫毛1.Hit = value;
				this.X0Y4_瞼左_睫毛1.Hit = value;
			}
		}

		public bool 瞼左_睫毛2_表示
		{
			get
			{
				return this.X0Y0_瞼左_睫毛2.Dra;
			}
			set
			{
				this.X0Y0_瞼左_睫毛2.Dra = value;
				this.X0Y1_瞼左_睫毛2.Dra = value;
				this.X0Y2_瞼左_睫毛2.Dra = value;
				this.X0Y3_瞼左_睫毛2.Dra = value;
				this.X0Y4_瞼左_睫毛2.Dra = value;
				this.X0Y0_瞼左_睫毛2.Hit = value;
				this.X0Y1_瞼左_睫毛2.Hit = value;
				this.X0Y2_瞼左_睫毛2.Hit = value;
				this.X0Y3_瞼左_睫毛2.Hit = value;
				this.X0Y4_瞼左_睫毛2.Hit = value;
			}
		}

		public bool 瞼右_瞼_表示
		{
			get
			{
				return this.X0Y0_瞼右_瞼.Dra;
			}
			set
			{
				this.X0Y0_瞼右_瞼.Dra = value;
				this.X0Y1_瞼右_瞼.Dra = value;
				this.X0Y2_瞼右_瞼.Dra = value;
				this.X0Y3_瞼右_瞼.Dra = value;
				this.X0Y4_瞼右_瞼.Dra = value;
				this.X0Y0_瞼右_瞼.Hit = value;
				this.X0Y1_瞼右_瞼.Hit = value;
				this.X0Y2_瞼右_瞼.Hit = value;
				this.X0Y3_瞼右_瞼.Hit = value;
				this.X0Y4_瞼右_瞼.Hit = value;
			}
		}

		public bool 瞼右_睫毛1_表示
		{
			get
			{
				return this.X0Y0_瞼右_睫毛1.Dra;
			}
			set
			{
				this.X0Y0_瞼右_睫毛1.Dra = value;
				this.X0Y1_瞼右_睫毛1.Dra = value;
				this.X0Y2_瞼右_睫毛1.Dra = value;
				this.X0Y3_瞼右_睫毛1.Dra = value;
				this.X0Y4_瞼右_睫毛1.Dra = value;
				this.X0Y0_瞼右_睫毛1.Hit = value;
				this.X0Y1_瞼右_睫毛1.Hit = value;
				this.X0Y2_瞼右_睫毛1.Hit = value;
				this.X0Y3_瞼右_睫毛1.Hit = value;
				this.X0Y4_瞼右_睫毛1.Hit = value;
			}
		}

		public bool 瞼右_睫毛2_表示
		{
			get
			{
				return this.X0Y0_瞼右_睫毛2.Dra;
			}
			set
			{
				this.X0Y0_瞼右_睫毛2.Dra = value;
				this.X0Y1_瞼右_睫毛2.Dra = value;
				this.X0Y2_瞼右_睫毛2.Dra = value;
				this.X0Y3_瞼右_睫毛2.Dra = value;
				this.X0Y4_瞼右_睫毛2.Dra = value;
				this.X0Y0_瞼右_睫毛2.Hit = value;
				this.X0Y1_瞼右_睫毛2.Hit = value;
				this.X0Y2_瞼右_睫毛2.Hit = value;
				this.X0Y3_瞼右_睫毛2.Hit = value;
				this.X0Y4_瞼右_睫毛2.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.瞼左_瞼_表示;
			}
			set
			{
				this.瞼左_瞼_表示 = value;
				this.瞼左_睫毛1_表示 = value;
				this.瞼左_睫毛2_表示 = value;
				this.瞼右_瞼_表示 = value;
				this.瞼右_睫毛1_表示 = value;
				this.瞼右_睫毛2_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.瞼左_瞼CD.不透明度;
			}
			set
			{
				this.瞼左_瞼CD.不透明度 = value;
				this.瞼左_睫毛1CD.不透明度 = value;
				this.瞼左_睫毛2CD.不透明度 = value;
				this.瞼右_瞼CD.不透明度 = value;
				this.瞼右_睫毛1CD.不透明度 = value;
				this.瞼右_睫毛2CD.不透明度 = value;
			}
		}

		public double 外線
		{
			set
			{
				double num = 0.9 + 0.55 * value;
				this.X0Y0_瞼左_瞼.PenWidth *= num;
				this.X0Y0_瞼右_瞼.PenWidth *= num;
				this.X0Y1_瞼左_瞼.PenWidth *= num;
				this.X0Y1_瞼右_瞼.PenWidth *= num;
				this.X0Y2_瞼左_瞼.PenWidth *= num;
				this.X0Y2_瞼右_瞼.PenWidth *= num;
				this.X0Y3_瞼左_瞼.PenWidth *= num;
				this.X0Y3_瞼右_瞼.PenWidth *= num;
				this.X0Y4_瞼左_瞼.PenWidth *= num;
				this.X0Y4_瞼右_瞼.PenWidth *= num;
			}
		}

		private void 睫毛長さ(Par p, double d)
		{
			double num = 0.0;
			double num2 = 2.0;
			Vector2D value = p.BasePointBase + (p.OP[0].ps[0] - p.BasePointBase) * (num + (num2 - num) * d);
			p.OP[2].ps[2] = value;
			p.OP[0].ps[0] = value;
		}

		public double 瞼左_睫毛1_長さ
		{
			set
			{
				this.睫毛長さ(this.X0Y0_瞼左_睫毛1, value);
				this.睫毛長さ(this.X0Y1_瞼左_睫毛1, value);
				this.睫毛長さ(this.X0Y2_瞼左_睫毛1, value);
				this.睫毛長さ(this.X0Y3_瞼左_睫毛1, value);
				this.睫毛長さ(this.X0Y4_瞼左_睫毛1, value);
			}
		}

		public double 瞼左_睫毛2_長さ
		{
			set
			{
				this.睫毛長さ(this.X0Y0_瞼左_睫毛2, value);
				this.睫毛長さ(this.X0Y1_瞼左_睫毛2, value);
				this.睫毛長さ(this.X0Y2_瞼左_睫毛2, value);
				this.睫毛長さ(this.X0Y3_瞼左_睫毛2, value);
				this.睫毛長さ(this.X0Y4_瞼左_睫毛2, value);
			}
		}

		public double 瞼右_睫毛1_長さ
		{
			set
			{
				this.睫毛長さ(this.X0Y0_瞼右_睫毛1, value);
				this.睫毛長さ(this.X0Y1_瞼右_睫毛1, value);
				this.睫毛長さ(this.X0Y2_瞼右_睫毛1, value);
				this.睫毛長さ(this.X0Y3_瞼右_睫毛1, value);
				this.睫毛長さ(this.X0Y4_瞼右_睫毛1, value);
			}
		}

		public double 瞼右_睫毛2_長さ
		{
			set
			{
				this.睫毛長さ(this.X0Y0_瞼右_睫毛2, value);
				this.睫毛長さ(this.X0Y1_瞼右_睫毛2, value);
				this.睫毛長さ(this.X0Y2_瞼右_睫毛2, value);
				this.睫毛長さ(this.X0Y3_瞼右_睫毛2, value);
				this.睫毛長さ(this.X0Y4_瞼右_睫毛2, value);
			}
		}

		public double 傾き
		{
			set
			{
				double num = this.右 ? -1.0 : 1.0;
				double num2 = -10.0 + 18.5 * value;
				this.角度B = num * num2;
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
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_瞼左_瞼CP.Update();
				this.X0Y0_瞼左_睫毛1CP.Update();
				this.X0Y0_瞼左_睫毛2CP.Update();
				this.X0Y0_瞼右_瞼CP.Update();
				this.X0Y0_瞼右_睫毛1CP.Update();
				this.X0Y0_瞼右_睫毛2CP.Update();
				return;
			case 1:
				this.X0Y1_瞼左_瞼CP.Update();
				this.X0Y1_瞼左_睫毛1CP.Update();
				this.X0Y1_瞼左_睫毛2CP.Update();
				this.X0Y1_瞼右_瞼CP.Update();
				this.X0Y1_瞼右_睫毛1CP.Update();
				this.X0Y1_瞼右_睫毛2CP.Update();
				return;
			case 2:
				this.X0Y2_瞼左_瞼CP.Update();
				this.X0Y2_瞼左_睫毛1CP.Update();
				this.X0Y2_瞼左_睫毛2CP.Update();
				this.X0Y2_瞼右_瞼CP.Update();
				this.X0Y2_瞼右_睫毛1CP.Update();
				this.X0Y2_瞼右_睫毛2CP.Update();
				return;
			case 3:
				this.X0Y3_瞼左_瞼CP.Update();
				this.X0Y3_瞼左_睫毛1CP.Update();
				this.X0Y3_瞼左_睫毛2CP.Update();
				this.X0Y3_瞼右_瞼CP.Update();
				this.X0Y3_瞼右_睫毛1CP.Update();
				this.X0Y3_瞼右_睫毛2CP.Update();
				return;
			default:
				this.X0Y4_瞼左_瞼CP.Update();
				this.X0Y4_瞼左_睫毛1CP.Update();
				this.X0Y4_瞼左_睫毛2CP.Update();
				this.X0Y4_瞼右_瞼CP.Update();
				this.X0Y4_瞼右_睫毛1CP.Update();
				this.X0Y4_瞼右_睫毛2CP.Update();
				return;
			}
		}

		public override void 色更新(Vector2D[] mm)
		{
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_瞼左_瞼CP.Update(mm);
				this.X0Y0_瞼左_睫毛1CP.Update();
				this.X0Y0_瞼左_睫毛2CP.Update();
				this.X0Y0_瞼右_瞼CP.Update(mm);
				this.X0Y0_瞼右_睫毛1CP.Update();
				this.X0Y0_瞼右_睫毛2CP.Update();
				return;
			case 1:
				this.X0Y1_瞼左_瞼CP.Update(mm);
				this.X0Y1_瞼左_睫毛1CP.Update();
				this.X0Y1_瞼左_睫毛2CP.Update();
				this.X0Y1_瞼右_瞼CP.Update(mm);
				this.X0Y1_瞼右_睫毛1CP.Update();
				this.X0Y1_瞼右_睫毛2CP.Update();
				return;
			case 2:
				this.X0Y2_瞼左_瞼CP.Update(mm);
				this.X0Y2_瞼左_睫毛1CP.Update();
				this.X0Y2_瞼左_睫毛2CP.Update();
				this.X0Y2_瞼右_瞼CP.Update(mm);
				this.X0Y2_瞼右_睫毛1CP.Update();
				this.X0Y2_瞼右_睫毛2CP.Update();
				return;
			case 3:
				this.X0Y3_瞼左_瞼CP.Update(mm);
				this.X0Y3_瞼左_睫毛1CP.Update();
				this.X0Y3_瞼左_睫毛2CP.Update();
				this.X0Y3_瞼右_瞼CP.Update(mm);
				this.X0Y3_瞼右_睫毛1CP.Update();
				this.X0Y3_瞼右_睫毛2CP.Update();
				return;
			default:
				this.X0Y4_瞼左_瞼CP.Update(mm);
				this.X0Y4_瞼左_睫毛1CP.Update();
				this.X0Y4_瞼左_睫毛2CP.Update();
				this.X0Y4_瞼右_瞼CP.Update(mm);
				this.X0Y4_瞼右_睫毛1CP.Update();
				this.X0Y4_瞼右_睫毛2CP.Update();
				return;
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.瞼左_瞼CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.人肌O);
			this.瞼左_睫毛1CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.睫毛);
			this.瞼左_睫毛2CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.睫毛);
			this.瞼右_瞼CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.人肌O);
			this.瞼右_睫毛1CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.睫毛);
			this.瞼右_睫毛2CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.睫毛);
		}

		public Par X0Y0_瞼左_瞼;

		public Par X0Y0_瞼左_睫毛1;

		public Par X0Y0_瞼左_睫毛2;

		public Par X0Y0_瞼右_瞼;

		public Par X0Y0_瞼右_睫毛1;

		public Par X0Y0_瞼右_睫毛2;

		public Par X0Y1_瞼左_瞼;

		public Par X0Y1_瞼左_睫毛1;

		public Par X0Y1_瞼左_睫毛2;

		public Par X0Y1_瞼右_瞼;

		public Par X0Y1_瞼右_睫毛1;

		public Par X0Y1_瞼右_睫毛2;

		public Par X0Y2_瞼左_瞼;

		public Par X0Y2_瞼左_睫毛1;

		public Par X0Y2_瞼左_睫毛2;

		public Par X0Y2_瞼右_瞼;

		public Par X0Y2_瞼右_睫毛1;

		public Par X0Y2_瞼右_睫毛2;

		public Par X0Y3_瞼左_瞼;

		public Par X0Y3_瞼左_睫毛1;

		public Par X0Y3_瞼左_睫毛2;

		public Par X0Y3_瞼右_瞼;

		public Par X0Y3_瞼右_睫毛1;

		public Par X0Y3_瞼右_睫毛2;

		public Par X0Y4_瞼左_瞼;

		public Par X0Y4_瞼左_睫毛1;

		public Par X0Y4_瞼左_睫毛2;

		public Par X0Y4_瞼右_瞼;

		public Par X0Y4_瞼右_睫毛1;

		public Par X0Y4_瞼右_睫毛2;

		public ColorD 瞼左_瞼CD;

		public ColorD 瞼左_睫毛1CD;

		public ColorD 瞼左_睫毛2CD;

		public ColorD 瞼右_瞼CD;

		public ColorD 瞼右_睫毛1CD;

		public ColorD 瞼右_睫毛2CD;

		public ColorP X0Y0_瞼左_瞼CP;

		public ColorP X0Y0_瞼左_睫毛1CP;

		public ColorP X0Y0_瞼左_睫毛2CP;

		public ColorP X0Y0_瞼右_瞼CP;

		public ColorP X0Y0_瞼右_睫毛1CP;

		public ColorP X0Y0_瞼右_睫毛2CP;

		public ColorP X0Y1_瞼左_瞼CP;

		public ColorP X0Y1_瞼左_睫毛1CP;

		public ColorP X0Y1_瞼左_睫毛2CP;

		public ColorP X0Y1_瞼右_瞼CP;

		public ColorP X0Y1_瞼右_睫毛1CP;

		public ColorP X0Y1_瞼右_睫毛2CP;

		public ColorP X0Y2_瞼左_瞼CP;

		public ColorP X0Y2_瞼左_睫毛1CP;

		public ColorP X0Y2_瞼左_睫毛2CP;

		public ColorP X0Y2_瞼右_瞼CP;

		public ColorP X0Y2_瞼右_睫毛1CP;

		public ColorP X0Y2_瞼右_睫毛2CP;

		public ColorP X0Y3_瞼左_瞼CP;

		public ColorP X0Y3_瞼左_睫毛1CP;

		public ColorP X0Y3_瞼左_睫毛2CP;

		public ColorP X0Y3_瞼右_瞼CP;

		public ColorP X0Y3_瞼右_睫毛1CP;

		public ColorP X0Y3_瞼右_睫毛2CP;

		public ColorP X0Y4_瞼左_瞼CP;

		public ColorP X0Y4_瞼左_睫毛1CP;

		public ColorP X0Y4_瞼左_睫毛2CP;

		public ColorP X0Y4_瞼右_瞼CP;

		public ColorP X0Y4_瞼右_睫毛1CP;

		public ColorP X0Y4_瞼右_睫毛2CP;
	}
}
