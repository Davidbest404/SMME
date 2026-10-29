using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 瞼_中 : 双瞼
	{
		public 瞼_中(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 瞼_中D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["魔性中瞼左"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_瞼 = pars["瞼"].ToPar();
			this.X0Y0_二重 = pars["二重"].ToPar();
			Pars pars2 = pars["睫毛"].ToPars();
			this.X0Y0_睫毛_睫毛3 = pars2["睫毛3"].ToPar();
			this.X0Y0_睫毛_睫毛4 = pars2["睫毛4"].ToPar();
			this.X0Y0_睫毛_睫毛1 = pars2["睫毛1"].ToPar();
			this.X0Y0_睫毛_睫毛2 = pars2["睫毛2"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_瞼 = pars["瞼"].ToPar();
			this.X0Y1_二重 = pars["二重"].ToPar();
			pars2 = pars["睫毛"].ToPars();
			this.X0Y1_睫毛_睫毛3 = pars2["睫毛3"].ToPar();
			this.X0Y1_睫毛_睫毛4 = pars2["睫毛4"].ToPar();
			this.X0Y1_睫毛_睫毛1 = pars2["睫毛1"].ToPar();
			this.X0Y1_睫毛_睫毛2 = pars2["睫毛2"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_瞼 = pars["瞼"].ToPar();
			this.X0Y2_二重 = pars["二重"].ToPar();
			pars2 = pars["睫毛"].ToPars();
			this.X0Y2_睫毛_睫毛3 = pars2["睫毛3"].ToPar();
			this.X0Y2_睫毛_睫毛4 = pars2["睫毛4"].ToPar();
			this.X0Y2_睫毛_睫毛1 = pars2["睫毛1"].ToPar();
			this.X0Y2_睫毛_睫毛2 = pars2["睫毛2"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_瞼 = pars["瞼"].ToPar();
			this.X0Y3_二重 = pars["二重"].ToPar();
			pars2 = pars["睫毛"].ToPars();
			this.X0Y3_睫毛_睫毛3 = pars2["睫毛3"].ToPar();
			this.X0Y3_睫毛_睫毛4 = pars2["睫毛4"].ToPar();
			this.X0Y3_睫毛_睫毛1 = pars2["睫毛1"].ToPar();
			this.X0Y3_睫毛_睫毛2 = pars2["睫毛2"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_瞼 = pars["瞼"].ToPar();
			this.X0Y4_二重 = pars["二重"].ToPar();
			pars2 = pars["睫毛"].ToPars();
			this.X0Y4_睫毛_睫毛3 = pars2["睫毛3"].ToPar();
			this.X0Y4_睫毛_睫毛4 = pars2["睫毛4"].ToPar();
			this.X0Y4_睫毛_睫毛1 = pars2["睫毛1"].ToPar();
			this.X0Y4_睫毛_睫毛2 = pars2["睫毛2"].ToPar();
			pars = this.本体[1][0];
			this.X1Y0_瞼 = pars["瞼"].ToPar();
			this.X1Y0_二重 = pars["二重"].ToPar();
			pars2 = pars["睫毛"].ToPars();
			this.X1Y0_睫毛_睫毛3 = pars2["睫毛3"].ToPar();
			this.X1Y0_睫毛_睫毛4 = pars2["睫毛4"].ToPar();
			this.X1Y0_睫毛_睫毛1 = pars2["睫毛1"].ToPar();
			this.X1Y0_睫毛_睫毛2 = pars2["睫毛2"].ToPar();
			pars = this.本体[1][1];
			this.X1Y1_瞼 = pars["瞼"].ToPar();
			this.X1Y1_二重 = pars["二重"].ToPar();
			pars2 = pars["睫毛"].ToPars();
			this.X1Y1_睫毛_睫毛3 = pars2["睫毛3"].ToPar();
			this.X1Y1_睫毛_睫毛4 = pars2["睫毛4"].ToPar();
			this.X1Y1_睫毛_睫毛1 = pars2["睫毛1"].ToPar();
			this.X1Y1_睫毛_睫毛2 = pars2["睫毛2"].ToPar();
			pars = this.本体[1][2];
			this.X1Y2_瞼 = pars["瞼"].ToPar();
			this.X1Y2_二重 = pars["二重"].ToPar();
			pars2 = pars["睫毛"].ToPars();
			this.X1Y2_睫毛_睫毛3 = pars2["睫毛3"].ToPar();
			this.X1Y2_睫毛_睫毛4 = pars2["睫毛4"].ToPar();
			this.X1Y2_睫毛_睫毛1 = pars2["睫毛1"].ToPar();
			this.X1Y2_睫毛_睫毛2 = pars2["睫毛2"].ToPar();
			pars = this.本体[1][3];
			this.X1Y3_瞼 = pars["瞼"].ToPar();
			this.X1Y3_二重 = pars["二重"].ToPar();
			pars2 = pars["睫毛"].ToPars();
			this.X1Y3_睫毛_睫毛3 = pars2["睫毛3"].ToPar();
			this.X1Y3_睫毛_睫毛4 = pars2["睫毛4"].ToPar();
			this.X1Y3_睫毛_睫毛1 = pars2["睫毛1"].ToPar();
			this.X1Y3_睫毛_睫毛2 = pars2["睫毛2"].ToPar();
			pars = this.本体[1][4];
			this.X1Y4_瞼 = pars["瞼"].ToPar();
			this.X1Y4_二重 = pars["二重"].ToPar();
			pars2 = pars["睫毛"].ToPars();
			this.X1Y4_睫毛_睫毛3 = pars2["睫毛3"].ToPar();
			this.X1Y4_睫毛_睫毛4 = pars2["睫毛4"].ToPar();
			this.X1Y4_睫毛_睫毛1 = pars2["睫毛1"].ToPar();
			this.X1Y4_睫毛_睫毛2 = pars2["睫毛2"].ToPar();
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
			this.瞼_表示 = e.瞼_表示;
			this.二重_表示 = e.二重_表示;
			this.睫毛_睫毛3_表示 = e.睫毛_睫毛3_表示;
			this.睫毛_睫毛4_表示 = e.睫毛_睫毛4_表示;
			this.睫毛_睫毛1_表示 = e.睫毛_睫毛1_表示;
			this.睫毛_睫毛2_表示 = e.睫毛_睫毛2_表示;
			this.外線 = e.外線;
			this.睫毛_睫毛3_長さ = e.睫毛_睫毛3_長さ;
			this.睫毛_睫毛4_長さ = e.睫毛_睫毛4_長さ;
			this.睫毛_睫毛1_長さ = e.睫毛_睫毛1_長さ;
			this.睫毛_睫毛2_長さ = e.睫毛_睫毛2_長さ;
			base.傾き = e.傾き;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_瞼CP = new ColorP(this.X0Y0_瞼, this.瞼CD, DisUnit, true);
			this.X0Y0_二重CP = new ColorP(this.X0Y0_二重, this.二重CD, DisUnit, true);
			this.X0Y0_睫毛_睫毛3CP = new ColorP(this.X0Y0_睫毛_睫毛3, this.睫毛_睫毛3CD, DisUnit, true);
			this.X0Y0_睫毛_睫毛4CP = new ColorP(this.X0Y0_睫毛_睫毛4, this.睫毛_睫毛4CD, DisUnit, true);
			this.X0Y0_睫毛_睫毛1CP = new ColorP(this.X0Y0_睫毛_睫毛1, this.睫毛_睫毛1CD, DisUnit, true);
			this.X0Y0_睫毛_睫毛2CP = new ColorP(this.X0Y0_睫毛_睫毛2, this.睫毛_睫毛2CD, DisUnit, true);
			this.X0Y1_瞼CP = new ColorP(this.X0Y1_瞼, this.瞼CD, DisUnit, true);
			this.X0Y1_二重CP = new ColorP(this.X0Y1_二重, this.二重CD, DisUnit, true);
			this.X0Y1_睫毛_睫毛3CP = new ColorP(this.X0Y1_睫毛_睫毛3, this.睫毛_睫毛3CD, DisUnit, true);
			this.X0Y1_睫毛_睫毛4CP = new ColorP(this.X0Y1_睫毛_睫毛4, this.睫毛_睫毛4CD, DisUnit, true);
			this.X0Y1_睫毛_睫毛1CP = new ColorP(this.X0Y1_睫毛_睫毛1, this.睫毛_睫毛1CD, DisUnit, true);
			this.X0Y1_睫毛_睫毛2CP = new ColorP(this.X0Y1_睫毛_睫毛2, this.睫毛_睫毛2CD, DisUnit, true);
			this.X0Y2_瞼CP = new ColorP(this.X0Y2_瞼, this.瞼CD, DisUnit, true);
			this.X0Y2_二重CP = new ColorP(this.X0Y2_二重, this.二重CD, DisUnit, true);
			this.X0Y2_睫毛_睫毛3CP = new ColorP(this.X0Y2_睫毛_睫毛3, this.睫毛_睫毛3CD, DisUnit, true);
			this.X0Y2_睫毛_睫毛4CP = new ColorP(this.X0Y2_睫毛_睫毛4, this.睫毛_睫毛4CD, DisUnit, true);
			this.X0Y2_睫毛_睫毛1CP = new ColorP(this.X0Y2_睫毛_睫毛1, this.睫毛_睫毛1CD, DisUnit, true);
			this.X0Y2_睫毛_睫毛2CP = new ColorP(this.X0Y2_睫毛_睫毛2, this.睫毛_睫毛2CD, DisUnit, true);
			this.X0Y3_瞼CP = new ColorP(this.X0Y3_瞼, this.瞼CD, DisUnit, true);
			this.X0Y3_二重CP = new ColorP(this.X0Y3_二重, this.二重CD, DisUnit, true);
			this.X0Y3_睫毛_睫毛3CP = new ColorP(this.X0Y3_睫毛_睫毛3, this.睫毛_睫毛3CD, DisUnit, true);
			this.X0Y3_睫毛_睫毛4CP = new ColorP(this.X0Y3_睫毛_睫毛4, this.睫毛_睫毛4CD, DisUnit, true);
			this.X0Y3_睫毛_睫毛1CP = new ColorP(this.X0Y3_睫毛_睫毛1, this.睫毛_睫毛1CD, DisUnit, true);
			this.X0Y3_睫毛_睫毛2CP = new ColorP(this.X0Y3_睫毛_睫毛2, this.睫毛_睫毛2CD, DisUnit, true);
			this.X0Y4_瞼CP = new ColorP(this.X0Y4_瞼, this.瞼CD, DisUnit, true);
			this.X0Y4_二重CP = new ColorP(this.X0Y4_二重, this.二重CD, DisUnit, true);
			this.X0Y4_睫毛_睫毛3CP = new ColorP(this.X0Y4_睫毛_睫毛3, this.睫毛_睫毛3CD, DisUnit, true);
			this.X0Y4_睫毛_睫毛4CP = new ColorP(this.X0Y4_睫毛_睫毛4, this.睫毛_睫毛4CD, DisUnit, true);
			this.X0Y4_睫毛_睫毛1CP = new ColorP(this.X0Y4_睫毛_睫毛1, this.睫毛_睫毛1CD, DisUnit, true);
			this.X0Y4_睫毛_睫毛2CP = new ColorP(this.X0Y4_睫毛_睫毛2, this.睫毛_睫毛2CD, DisUnit, true);
			this.X1Y0_瞼CP = new ColorP(this.X1Y0_瞼, this.瞼CD, DisUnit, true);
			this.X1Y0_二重CP = new ColorP(this.X1Y0_二重, this.二重CD, DisUnit, true);
			this.X1Y0_睫毛_睫毛3CP = new ColorP(this.X1Y0_睫毛_睫毛3, this.睫毛_睫毛3CD, DisUnit, true);
			this.X1Y0_睫毛_睫毛4CP = new ColorP(this.X1Y0_睫毛_睫毛4, this.睫毛_睫毛4CD, DisUnit, true);
			this.X1Y0_睫毛_睫毛1CP = new ColorP(this.X1Y0_睫毛_睫毛1, this.睫毛_睫毛1CD, DisUnit, true);
			this.X1Y0_睫毛_睫毛2CP = new ColorP(this.X1Y0_睫毛_睫毛2, this.睫毛_睫毛2CD, DisUnit, true);
			this.X1Y1_瞼CP = new ColorP(this.X1Y1_瞼, this.瞼CD, DisUnit, true);
			this.X1Y1_二重CP = new ColorP(this.X1Y1_二重, this.二重CD, DisUnit, true);
			this.X1Y1_睫毛_睫毛3CP = new ColorP(this.X1Y1_睫毛_睫毛3, this.睫毛_睫毛3CD, DisUnit, true);
			this.X1Y1_睫毛_睫毛4CP = new ColorP(this.X1Y1_睫毛_睫毛4, this.睫毛_睫毛4CD, DisUnit, true);
			this.X1Y1_睫毛_睫毛1CP = new ColorP(this.X1Y1_睫毛_睫毛1, this.睫毛_睫毛1CD, DisUnit, true);
			this.X1Y1_睫毛_睫毛2CP = new ColorP(this.X1Y1_睫毛_睫毛2, this.睫毛_睫毛2CD, DisUnit, true);
			this.X1Y2_瞼CP = new ColorP(this.X1Y2_瞼, this.瞼CD, DisUnit, true);
			this.X1Y2_二重CP = new ColorP(this.X1Y2_二重, this.二重CD, DisUnit, true);
			this.X1Y2_睫毛_睫毛3CP = new ColorP(this.X1Y2_睫毛_睫毛3, this.睫毛_睫毛3CD, DisUnit, true);
			this.X1Y2_睫毛_睫毛4CP = new ColorP(this.X1Y2_睫毛_睫毛4, this.睫毛_睫毛4CD, DisUnit, true);
			this.X1Y2_睫毛_睫毛1CP = new ColorP(this.X1Y2_睫毛_睫毛1, this.睫毛_睫毛1CD, DisUnit, true);
			this.X1Y2_睫毛_睫毛2CP = new ColorP(this.X1Y2_睫毛_睫毛2, this.睫毛_睫毛2CD, DisUnit, true);
			this.X1Y3_瞼CP = new ColorP(this.X1Y3_瞼, this.瞼CD, DisUnit, true);
			this.X1Y3_二重CP = new ColorP(this.X1Y3_二重, this.二重CD, DisUnit, true);
			this.X1Y3_睫毛_睫毛3CP = new ColorP(this.X1Y3_睫毛_睫毛3, this.睫毛_睫毛3CD, DisUnit, true);
			this.X1Y3_睫毛_睫毛4CP = new ColorP(this.X1Y3_睫毛_睫毛4, this.睫毛_睫毛4CD, DisUnit, true);
			this.X1Y3_睫毛_睫毛1CP = new ColorP(this.X1Y3_睫毛_睫毛1, this.睫毛_睫毛1CD, DisUnit, true);
			this.X1Y3_睫毛_睫毛2CP = new ColorP(this.X1Y3_睫毛_睫毛2, this.睫毛_睫毛2CD, DisUnit, true);
			this.X1Y4_瞼CP = new ColorP(this.X1Y4_瞼, this.瞼CD, DisUnit, true);
			this.X1Y4_二重CP = new ColorP(this.X1Y4_二重, this.二重CD, DisUnit, true);
			this.X1Y4_睫毛_睫毛3CP = new ColorP(this.X1Y4_睫毛_睫毛3, this.睫毛_睫毛3CD, DisUnit, true);
			this.X1Y4_睫毛_睫毛4CP = new ColorP(this.X1Y4_睫毛_睫毛4, this.睫毛_睫毛4CD, DisUnit, true);
			this.X1Y4_睫毛_睫毛1CP = new ColorP(this.X1Y4_睫毛_睫毛1, this.睫毛_睫毛1CD, DisUnit, true);
			this.X1Y4_睫毛_睫毛2CP = new ColorP(this.X1Y4_睫毛_睫毛2, this.睫毛_睫毛2CD, DisUnit, true);
			this.濃度 = e.濃度;
			this.尺度XB = 0.99;
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

		public bool 瞼_表示
		{
			get
			{
				return this.X0Y0_瞼.Dra;
			}
			set
			{
				this.X0Y0_瞼.Dra = value;
				this.X0Y1_瞼.Dra = value;
				this.X0Y2_瞼.Dra = value;
				this.X0Y3_瞼.Dra = value;
				this.X0Y4_瞼.Dra = value;
				this.X1Y0_瞼.Dra = value;
				this.X1Y1_瞼.Dra = value;
				this.X1Y2_瞼.Dra = value;
				this.X1Y3_瞼.Dra = value;
				this.X1Y4_瞼.Dra = value;
				this.X0Y0_瞼.Hit = value;
				this.X0Y1_瞼.Hit = value;
				this.X0Y2_瞼.Hit = value;
				this.X0Y3_瞼.Hit = value;
				this.X0Y4_瞼.Hit = value;
				this.X1Y0_瞼.Hit = value;
				this.X1Y1_瞼.Hit = value;
				this.X1Y2_瞼.Hit = value;
				this.X1Y3_瞼.Hit = value;
				this.X1Y4_瞼.Hit = value;
			}
		}

		public bool 二重_表示
		{
			get
			{
				return this.X0Y0_二重.Dra;
			}
			set
			{
				this.X0Y0_二重.Dra = value;
				this.X0Y1_二重.Dra = value;
				this.X0Y2_二重.Dra = value;
				this.X0Y3_二重.Dra = value;
				this.X0Y4_二重.Dra = value;
				this.X1Y0_二重.Dra = value;
				this.X1Y1_二重.Dra = value;
				this.X1Y2_二重.Dra = value;
				this.X1Y3_二重.Dra = value;
				this.X1Y4_二重.Dra = value;
				this.X0Y0_二重.Hit = value;
				this.X0Y1_二重.Hit = value;
				this.X0Y2_二重.Hit = value;
				this.X0Y3_二重.Hit = value;
				this.X0Y4_二重.Hit = value;
				this.X1Y0_二重.Hit = value;
				this.X1Y1_二重.Hit = value;
				this.X1Y2_二重.Hit = value;
				this.X1Y3_二重.Hit = value;
				this.X1Y4_二重.Hit = value;
			}
		}

		public bool 睫毛_睫毛3_表示
		{
			get
			{
				return this.X0Y0_睫毛_睫毛3.Dra;
			}
			set
			{
				this.X0Y0_睫毛_睫毛3.Dra = value;
				this.X0Y1_睫毛_睫毛3.Dra = value;
				this.X0Y2_睫毛_睫毛3.Dra = value;
				this.X0Y3_睫毛_睫毛3.Dra = value;
				this.X0Y4_睫毛_睫毛3.Dra = value;
				this.X1Y0_睫毛_睫毛3.Dra = value;
				this.X1Y1_睫毛_睫毛3.Dra = value;
				this.X1Y2_睫毛_睫毛3.Dra = value;
				this.X1Y3_睫毛_睫毛3.Dra = value;
				this.X1Y4_睫毛_睫毛3.Dra = value;
				this.X0Y0_睫毛_睫毛3.Hit = value;
				this.X0Y1_睫毛_睫毛3.Hit = value;
				this.X0Y2_睫毛_睫毛3.Hit = value;
				this.X0Y3_睫毛_睫毛3.Hit = value;
				this.X0Y4_睫毛_睫毛3.Hit = value;
				this.X1Y0_睫毛_睫毛3.Hit = value;
				this.X1Y1_睫毛_睫毛3.Hit = value;
				this.X1Y2_睫毛_睫毛3.Hit = value;
				this.X1Y3_睫毛_睫毛3.Hit = value;
				this.X1Y4_睫毛_睫毛3.Hit = value;
			}
		}

		public bool 睫毛_睫毛4_表示
		{
			get
			{
				return this.X0Y0_睫毛_睫毛4.Dra;
			}
			set
			{
				this.X0Y0_睫毛_睫毛4.Dra = value;
				this.X0Y1_睫毛_睫毛4.Dra = value;
				this.X0Y2_睫毛_睫毛4.Dra = value;
				this.X0Y3_睫毛_睫毛4.Dra = value;
				this.X0Y4_睫毛_睫毛4.Dra = value;
				this.X1Y0_睫毛_睫毛4.Dra = value;
				this.X1Y1_睫毛_睫毛4.Dra = value;
				this.X1Y2_睫毛_睫毛4.Dra = value;
				this.X1Y3_睫毛_睫毛4.Dra = value;
				this.X1Y4_睫毛_睫毛4.Dra = value;
				this.X0Y0_睫毛_睫毛4.Hit = value;
				this.X0Y1_睫毛_睫毛4.Hit = value;
				this.X0Y2_睫毛_睫毛4.Hit = value;
				this.X0Y3_睫毛_睫毛4.Hit = value;
				this.X0Y4_睫毛_睫毛4.Hit = value;
				this.X1Y0_睫毛_睫毛4.Hit = value;
				this.X1Y1_睫毛_睫毛4.Hit = value;
				this.X1Y2_睫毛_睫毛4.Hit = value;
				this.X1Y3_睫毛_睫毛4.Hit = value;
				this.X1Y4_睫毛_睫毛4.Hit = value;
			}
		}

		public bool 睫毛_睫毛1_表示
		{
			get
			{
				return this.X0Y0_睫毛_睫毛1.Dra;
			}
			set
			{
				this.X0Y0_睫毛_睫毛1.Dra = value;
				this.X0Y1_睫毛_睫毛1.Dra = value;
				this.X0Y2_睫毛_睫毛1.Dra = value;
				this.X0Y3_睫毛_睫毛1.Dra = value;
				this.X0Y4_睫毛_睫毛1.Dra = value;
				this.X1Y0_睫毛_睫毛1.Dra = value;
				this.X1Y1_睫毛_睫毛1.Dra = value;
				this.X1Y2_睫毛_睫毛1.Dra = value;
				this.X1Y3_睫毛_睫毛1.Dra = value;
				this.X1Y4_睫毛_睫毛1.Dra = value;
				this.X0Y0_睫毛_睫毛1.Hit = value;
				this.X0Y1_睫毛_睫毛1.Hit = value;
				this.X0Y2_睫毛_睫毛1.Hit = value;
				this.X0Y3_睫毛_睫毛1.Hit = value;
				this.X0Y4_睫毛_睫毛1.Hit = value;
				this.X1Y0_睫毛_睫毛1.Hit = value;
				this.X1Y1_睫毛_睫毛1.Hit = value;
				this.X1Y2_睫毛_睫毛1.Hit = value;
				this.X1Y3_睫毛_睫毛1.Hit = value;
				this.X1Y4_睫毛_睫毛1.Hit = value;
			}
		}

		public bool 睫毛_睫毛2_表示
		{
			get
			{
				return this.X0Y0_睫毛_睫毛2.Dra;
			}
			set
			{
				this.X0Y0_睫毛_睫毛2.Dra = value;
				this.X0Y1_睫毛_睫毛2.Dra = value;
				this.X0Y2_睫毛_睫毛2.Dra = value;
				this.X0Y3_睫毛_睫毛2.Dra = value;
				this.X0Y4_睫毛_睫毛2.Dra = value;
				this.X1Y0_睫毛_睫毛2.Dra = value;
				this.X1Y1_睫毛_睫毛2.Dra = value;
				this.X1Y2_睫毛_睫毛2.Dra = value;
				this.X1Y3_睫毛_睫毛2.Dra = value;
				this.X1Y4_睫毛_睫毛2.Dra = value;
				this.X0Y0_睫毛_睫毛2.Hit = value;
				this.X0Y1_睫毛_睫毛2.Hit = value;
				this.X0Y2_睫毛_睫毛2.Hit = value;
				this.X0Y3_睫毛_睫毛2.Hit = value;
				this.X0Y4_睫毛_睫毛2.Hit = value;
				this.X1Y0_睫毛_睫毛2.Hit = value;
				this.X1Y1_睫毛_睫毛2.Hit = value;
				this.X1Y2_睫毛_睫毛2.Hit = value;
				this.X1Y3_睫毛_睫毛2.Hit = value;
				this.X1Y4_睫毛_睫毛2.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.瞼_表示;
			}
			set
			{
				this.瞼_表示 = value;
				this.二重_表示 = value;
				this.睫毛_睫毛3_表示 = value;
				this.睫毛_睫毛4_表示 = value;
				this.睫毛_睫毛1_表示 = value;
				this.睫毛_睫毛2_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.瞼CD.不透明度;
			}
			set
			{
				this.瞼CD.不透明度 = value;
				this.二重CD.不透明度 = value;
				this.睫毛_睫毛3CD.不透明度 = value;
				this.睫毛_睫毛4CD.不透明度 = value;
				this.睫毛_睫毛1CD.不透明度 = value;
				this.睫毛_睫毛2CD.不透明度 = value;
			}
		}

		public double 外線
		{
			set
			{
				double num = 0.9 + 0.55 * value;
				this.X0Y0_瞼.PenWidth *= num;
				this.X0Y1_瞼.PenWidth *= num;
				this.X0Y2_瞼.PenWidth *= num;
				this.X0Y3_瞼.PenWidth *= num;
				this.X0Y4_瞼.PenWidth *= num;
				this.X1Y0_瞼.PenWidth *= num;
				this.X1Y1_瞼.PenWidth *= num;
				this.X1Y2_瞼.PenWidth *= num;
				this.X1Y3_瞼.PenWidth *= num;
				this.X1Y4_瞼.PenWidth *= num;
			}
		}

		private void 睫毛長さ(Par p, double d)
		{
			double num = 0.0;
			double num2 = 1.5;
			Vector2D value = p.BasePointBase + (p.OP[0].ps[0] - p.BasePointBase) * (num + (num2 - num) * d);
			p.OP[2].ps[2] = value;
			p.OP[0].ps[0] = value;
		}

		public double 睫毛_睫毛3_長さ
		{
			set
			{
				this.睫毛長さ(this.X0Y0_睫毛_睫毛3, value);
				this.睫毛長さ(this.X0Y1_睫毛_睫毛3, value);
				this.睫毛長さ(this.X0Y2_睫毛_睫毛3, value);
				this.睫毛長さ(this.X0Y3_睫毛_睫毛3, value);
				this.睫毛長さ(this.X0Y4_睫毛_睫毛3, value);
				this.睫毛長さ(this.X1Y0_睫毛_睫毛3, value);
				this.睫毛長さ(this.X1Y1_睫毛_睫毛3, value);
				this.睫毛長さ(this.X1Y2_睫毛_睫毛3, value);
				this.睫毛長さ(this.X1Y3_睫毛_睫毛3, value);
				this.睫毛長さ(this.X1Y4_睫毛_睫毛3, value);
			}
		}

		public double 睫毛_睫毛4_長さ
		{
			set
			{
				this.睫毛長さ(this.X0Y0_睫毛_睫毛4, value);
				this.睫毛長さ(this.X0Y1_睫毛_睫毛4, value);
				this.睫毛長さ(this.X0Y2_睫毛_睫毛4, value);
				this.睫毛長さ(this.X0Y3_睫毛_睫毛4, value);
				this.睫毛長さ(this.X0Y4_睫毛_睫毛4, value);
				this.睫毛長さ(this.X1Y0_睫毛_睫毛4, value);
				this.睫毛長さ(this.X1Y1_睫毛_睫毛4, value);
				this.睫毛長さ(this.X1Y2_睫毛_睫毛4, value);
				this.睫毛長さ(this.X1Y3_睫毛_睫毛4, value);
				this.睫毛長さ(this.X1Y4_睫毛_睫毛4, value);
			}
		}

		public double 睫毛_睫毛1_長さ
		{
			set
			{
				this.睫毛長さ(this.X0Y0_睫毛_睫毛1, value);
				this.睫毛長さ(this.X0Y1_睫毛_睫毛1, value);
				this.睫毛長さ(this.X0Y2_睫毛_睫毛1, value);
				this.睫毛長さ(this.X0Y3_睫毛_睫毛1, value);
				this.睫毛長さ(this.X0Y4_睫毛_睫毛1, value);
				this.睫毛長さ(this.X1Y0_睫毛_睫毛1, value);
				this.睫毛長さ(this.X1Y1_睫毛_睫毛1, value);
				this.睫毛長さ(this.X1Y2_睫毛_睫毛1, value);
				this.睫毛長さ(this.X1Y3_睫毛_睫毛1, value);
				this.睫毛長さ(this.X1Y4_睫毛_睫毛1, value);
			}
		}

		public double 睫毛_睫毛2_長さ
		{
			set
			{
				this.睫毛長さ(this.X0Y0_睫毛_睫毛2, value);
				this.睫毛長さ(this.X0Y1_睫毛_睫毛2, value);
				this.睫毛長さ(this.X0Y2_睫毛_睫毛2, value);
				this.睫毛長さ(this.X0Y3_睫毛_睫毛2, value);
				this.睫毛長さ(this.X0Y4_睫毛_睫毛2, value);
				this.睫毛長さ(this.X1Y0_睫毛_睫毛2, value);
				this.睫毛長さ(this.X1Y1_睫毛_睫毛2, value);
				this.睫毛長さ(this.X1Y2_睫毛_睫毛2, value);
				this.睫毛長さ(this.X1Y3_睫毛_睫毛2, value);
				this.睫毛長さ(this.X1Y4_睫毛_睫毛2, value);
			}
		}

		public override void 色更新()
		{
			if (this.本体.IndexX == 0)
			{
				switch (this.本体.IndexY)
				{
				case 0:
					this.X0Y0_瞼CP.Update();
					this.X0Y0_二重CP.Update();
					this.X0Y0_睫毛_睫毛3CP.Update();
					this.X0Y0_睫毛_睫毛4CP.Update();
					this.X0Y0_睫毛_睫毛1CP.Update();
					this.X0Y0_睫毛_睫毛2CP.Update();
					return;
				case 1:
					this.X0Y1_瞼CP.Update();
					this.X0Y1_二重CP.Update();
					this.X0Y1_睫毛_睫毛3CP.Update();
					this.X0Y1_睫毛_睫毛4CP.Update();
					this.X0Y1_睫毛_睫毛1CP.Update();
					this.X0Y1_睫毛_睫毛2CP.Update();
					return;
				case 2:
					this.X0Y2_瞼CP.Update();
					this.X0Y2_二重CP.Update();
					this.X0Y2_睫毛_睫毛3CP.Update();
					this.X0Y2_睫毛_睫毛4CP.Update();
					this.X0Y2_睫毛_睫毛1CP.Update();
					this.X0Y2_睫毛_睫毛2CP.Update();
					return;
				case 3:
					this.X0Y3_瞼CP.Update();
					this.X0Y3_二重CP.Update();
					this.X0Y3_睫毛_睫毛3CP.Update();
					this.X0Y3_睫毛_睫毛4CP.Update();
					this.X0Y3_睫毛_睫毛1CP.Update();
					this.X0Y3_睫毛_睫毛2CP.Update();
					return;
				default:
					this.X0Y4_瞼CP.Update();
					this.X0Y4_二重CP.Update();
					this.X0Y4_睫毛_睫毛3CP.Update();
					this.X0Y4_睫毛_睫毛4CP.Update();
					this.X0Y4_睫毛_睫毛1CP.Update();
					this.X0Y4_睫毛_睫毛2CP.Update();
					return;
				}
			}
			else
			{
				switch (this.本体.IndexY)
				{
				case 0:
					this.X1Y0_瞼CP.Update();
					this.X1Y0_二重CP.Update();
					this.X1Y0_睫毛_睫毛3CP.Update();
					this.X1Y0_睫毛_睫毛4CP.Update();
					this.X1Y0_睫毛_睫毛1CP.Update();
					this.X1Y0_睫毛_睫毛2CP.Update();
					return;
				case 1:
					this.X1Y1_瞼CP.Update();
					this.X1Y1_二重CP.Update();
					this.X1Y1_睫毛_睫毛3CP.Update();
					this.X1Y1_睫毛_睫毛4CP.Update();
					this.X1Y1_睫毛_睫毛1CP.Update();
					this.X1Y1_睫毛_睫毛2CP.Update();
					return;
				case 2:
					this.X1Y2_瞼CP.Update();
					this.X1Y2_二重CP.Update();
					this.X1Y2_睫毛_睫毛3CP.Update();
					this.X1Y2_睫毛_睫毛4CP.Update();
					this.X1Y2_睫毛_睫毛1CP.Update();
					this.X1Y2_睫毛_睫毛2CP.Update();
					return;
				case 3:
					this.X1Y3_瞼CP.Update();
					this.X1Y3_二重CP.Update();
					this.X1Y3_睫毛_睫毛3CP.Update();
					this.X1Y3_睫毛_睫毛4CP.Update();
					this.X1Y3_睫毛_睫毛1CP.Update();
					this.X1Y3_睫毛_睫毛2CP.Update();
					return;
				default:
					this.X1Y4_瞼CP.Update();
					this.X1Y4_二重CP.Update();
					this.X1Y4_睫毛_睫毛3CP.Update();
					this.X1Y4_睫毛_睫毛4CP.Update();
					this.X1Y4_睫毛_睫毛1CP.Update();
					this.X1Y4_睫毛_睫毛2CP.Update();
					return;
				}
			}
		}

		public override void 色更新(Vector2D[] mm)
		{
			if (this.本体.IndexX == 0)
			{
				switch (this.本体.IndexY)
				{
				case 0:
					this.X0Y0_瞼CP.Update(mm);
					this.X0Y0_二重CP.Update();
					this.X0Y0_睫毛_睫毛3CP.Update();
					this.X0Y0_睫毛_睫毛4CP.Update();
					this.X0Y0_睫毛_睫毛1CP.Update();
					this.X0Y0_睫毛_睫毛2CP.Update();
					return;
				case 1:
					this.X0Y1_瞼CP.Update(mm);
					this.X0Y1_二重CP.Update();
					this.X0Y1_睫毛_睫毛3CP.Update();
					this.X0Y1_睫毛_睫毛4CP.Update();
					this.X0Y1_睫毛_睫毛1CP.Update();
					this.X0Y1_睫毛_睫毛2CP.Update();
					return;
				case 2:
					this.X0Y2_瞼CP.Update(mm);
					this.X0Y2_二重CP.Update();
					this.X0Y2_睫毛_睫毛3CP.Update();
					this.X0Y2_睫毛_睫毛4CP.Update();
					this.X0Y2_睫毛_睫毛1CP.Update();
					this.X0Y2_睫毛_睫毛2CP.Update();
					return;
				case 3:
					this.X0Y3_瞼CP.Update(mm);
					this.X0Y3_二重CP.Update();
					this.X0Y3_睫毛_睫毛3CP.Update();
					this.X0Y3_睫毛_睫毛4CP.Update();
					this.X0Y3_睫毛_睫毛1CP.Update();
					this.X0Y3_睫毛_睫毛2CP.Update();
					return;
				default:
					this.X0Y4_瞼CP.Update(mm);
					this.X0Y4_二重CP.Update();
					this.X0Y4_睫毛_睫毛3CP.Update();
					this.X0Y4_睫毛_睫毛4CP.Update();
					this.X0Y4_睫毛_睫毛1CP.Update();
					this.X0Y4_睫毛_睫毛2CP.Update();
					return;
				}
			}
			else
			{
				switch (this.本体.IndexY)
				{
				case 0:
					this.X1Y0_瞼CP.Update(mm);
					this.X1Y0_二重CP.Update();
					this.X1Y0_睫毛_睫毛3CP.Update();
					this.X1Y0_睫毛_睫毛4CP.Update();
					this.X1Y0_睫毛_睫毛1CP.Update();
					this.X1Y0_睫毛_睫毛2CP.Update();
					return;
				case 1:
					this.X1Y1_瞼CP.Update(mm);
					this.X1Y1_二重CP.Update();
					this.X1Y1_睫毛_睫毛3CP.Update();
					this.X1Y1_睫毛_睫毛4CP.Update();
					this.X1Y1_睫毛_睫毛1CP.Update();
					this.X1Y1_睫毛_睫毛2CP.Update();
					return;
				case 2:
					this.X1Y2_瞼CP.Update(mm);
					this.X1Y2_二重CP.Update();
					this.X1Y2_睫毛_睫毛3CP.Update();
					this.X1Y2_睫毛_睫毛4CP.Update();
					this.X1Y2_睫毛_睫毛1CP.Update();
					this.X1Y2_睫毛_睫毛2CP.Update();
					return;
				case 3:
					this.X1Y3_瞼CP.Update(mm);
					this.X1Y3_二重CP.Update();
					this.X1Y3_睫毛_睫毛3CP.Update();
					this.X1Y3_睫毛_睫毛4CP.Update();
					this.X1Y3_睫毛_睫毛1CP.Update();
					this.X1Y3_睫毛_睫毛2CP.Update();
					return;
				default:
					this.X1Y4_瞼CP.Update(mm);
					this.X1Y4_二重CP.Update();
					this.X1Y4_睫毛_睫毛3CP.Update();
					this.X1Y4_睫毛_睫毛4CP.Update();
					this.X1Y4_睫毛_睫毛1CP.Update();
					this.X1Y4_睫毛_睫毛2CP.Update();
					return;
				}
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.瞼CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.人肌O);
			this.二重CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.睫毛_睫毛3CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.睫毛);
			this.睫毛_睫毛4CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.睫毛);
			this.睫毛_睫毛1CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.睫毛);
			this.睫毛_睫毛2CD = new ColorD(ref 体配色.睫毛.Col1, ref 体配色.睫毛);
		}

		public Par X0Y0_瞼;

		public Par X0Y0_二重;

		public Par X0Y0_睫毛_睫毛3;

		public Par X0Y0_睫毛_睫毛4;

		public Par X0Y0_睫毛_睫毛1;

		public Par X0Y0_睫毛_睫毛2;

		public Par X0Y1_瞼;

		public Par X0Y1_二重;

		public Par X0Y1_睫毛_睫毛3;

		public Par X0Y1_睫毛_睫毛4;

		public Par X0Y1_睫毛_睫毛1;

		public Par X0Y1_睫毛_睫毛2;

		public Par X0Y2_瞼;

		public Par X0Y2_二重;

		public Par X0Y2_睫毛_睫毛3;

		public Par X0Y2_睫毛_睫毛4;

		public Par X0Y2_睫毛_睫毛1;

		public Par X0Y2_睫毛_睫毛2;

		public Par X0Y3_瞼;

		public Par X0Y3_二重;

		public Par X0Y3_睫毛_睫毛3;

		public Par X0Y3_睫毛_睫毛4;

		public Par X0Y3_睫毛_睫毛1;

		public Par X0Y3_睫毛_睫毛2;

		public Par X0Y4_瞼;

		public Par X0Y4_二重;

		public Par X0Y4_睫毛_睫毛3;

		public Par X0Y4_睫毛_睫毛4;

		public Par X0Y4_睫毛_睫毛1;

		public Par X0Y4_睫毛_睫毛2;

		public Par X1Y0_瞼;

		public Par X1Y0_二重;

		public Par X1Y0_睫毛_睫毛3;

		public Par X1Y0_睫毛_睫毛4;

		public Par X1Y0_睫毛_睫毛1;

		public Par X1Y0_睫毛_睫毛2;

		public Par X1Y1_瞼;

		public Par X1Y1_二重;

		public Par X1Y1_睫毛_睫毛3;

		public Par X1Y1_睫毛_睫毛4;

		public Par X1Y1_睫毛_睫毛1;

		public Par X1Y1_睫毛_睫毛2;

		public Par X1Y2_瞼;

		public Par X1Y2_二重;

		public Par X1Y2_睫毛_睫毛3;

		public Par X1Y2_睫毛_睫毛4;

		public Par X1Y2_睫毛_睫毛1;

		public Par X1Y2_睫毛_睫毛2;

		public Par X1Y3_瞼;

		public Par X1Y3_二重;

		public Par X1Y3_睫毛_睫毛3;

		public Par X1Y3_睫毛_睫毛4;

		public Par X1Y3_睫毛_睫毛1;

		public Par X1Y3_睫毛_睫毛2;

		public Par X1Y4_瞼;

		public Par X1Y4_二重;

		public Par X1Y4_睫毛_睫毛3;

		public Par X1Y4_睫毛_睫毛4;

		public Par X1Y4_睫毛_睫毛1;

		public Par X1Y4_睫毛_睫毛2;

		public ColorD 瞼CD;

		public ColorD 二重CD;

		public ColorD 睫毛_睫毛3CD;

		public ColorD 睫毛_睫毛4CD;

		public ColorD 睫毛_睫毛1CD;

		public ColorD 睫毛_睫毛2CD;

		public ColorP X0Y0_瞼CP;

		public ColorP X0Y0_二重CP;

		public ColorP X0Y0_睫毛_睫毛3CP;

		public ColorP X0Y0_睫毛_睫毛4CP;

		public ColorP X0Y0_睫毛_睫毛1CP;

		public ColorP X0Y0_睫毛_睫毛2CP;

		public ColorP X0Y1_瞼CP;

		public ColorP X0Y1_二重CP;

		public ColorP X0Y1_睫毛_睫毛3CP;

		public ColorP X0Y1_睫毛_睫毛4CP;

		public ColorP X0Y1_睫毛_睫毛1CP;

		public ColorP X0Y1_睫毛_睫毛2CP;

		public ColorP X0Y2_瞼CP;

		public ColorP X0Y2_二重CP;

		public ColorP X0Y2_睫毛_睫毛3CP;

		public ColorP X0Y2_睫毛_睫毛4CP;

		public ColorP X0Y2_睫毛_睫毛1CP;

		public ColorP X0Y2_睫毛_睫毛2CP;

		public ColorP X0Y3_瞼CP;

		public ColorP X0Y3_二重CP;

		public ColorP X0Y3_睫毛_睫毛3CP;

		public ColorP X0Y3_睫毛_睫毛4CP;

		public ColorP X0Y3_睫毛_睫毛1CP;

		public ColorP X0Y3_睫毛_睫毛2CP;

		public ColorP X0Y4_瞼CP;

		public ColorP X0Y4_二重CP;

		public ColorP X0Y4_睫毛_睫毛3CP;

		public ColorP X0Y4_睫毛_睫毛4CP;

		public ColorP X0Y4_睫毛_睫毛1CP;

		public ColorP X0Y4_睫毛_睫毛2CP;

		public ColorP X1Y0_瞼CP;

		public ColorP X1Y0_二重CP;

		public ColorP X1Y0_睫毛_睫毛3CP;

		public ColorP X1Y0_睫毛_睫毛4CP;

		public ColorP X1Y0_睫毛_睫毛1CP;

		public ColorP X1Y0_睫毛_睫毛2CP;

		public ColorP X1Y1_瞼CP;

		public ColorP X1Y1_二重CP;

		public ColorP X1Y1_睫毛_睫毛3CP;

		public ColorP X1Y1_睫毛_睫毛4CP;

		public ColorP X1Y1_睫毛_睫毛1CP;

		public ColorP X1Y1_睫毛_睫毛2CP;

		public ColorP X1Y2_瞼CP;

		public ColorP X1Y2_二重CP;

		public ColorP X1Y2_睫毛_睫毛3CP;

		public ColorP X1Y2_睫毛_睫毛4CP;

		public ColorP X1Y2_睫毛_睫毛1CP;

		public ColorP X1Y2_睫毛_睫毛2CP;

		public ColorP X1Y3_瞼CP;

		public ColorP X1Y3_二重CP;

		public ColorP X1Y3_睫毛_睫毛3CP;

		public ColorP X1Y3_睫毛_睫毛4CP;

		public ColorP X1Y3_睫毛_睫毛1CP;

		public ColorP X1Y3_睫毛_睫毛2CP;

		public ColorP X1Y4_瞼CP;

		public ColorP X1Y4_二重CP;

		public ColorP X1Y4_睫毛_睫毛3CP;

		public ColorP X1Y4_睫毛_睫毛4CP;

		public ColorP X1Y4_睫毛_睫毛1CP;

		public ColorP X1Y4_睫毛_睫毛2CP;
	}
}
