using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 放尿_人 : 放尿
	{
		public 放尿_人(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 放尿_人D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.性器付["放尿"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_尿 = pars["尿"].ToPar();
			this.X0Y0_尿散り1 = pars["尿散り1"].ToPar();
			this.X0Y0_尿散り2 = pars["尿散り2"].ToPar();
			this.X0Y0_尿散り3 = pars["尿散り3"].ToPar();
			this.X0Y0_尿散り4 = pars["尿散り4"].ToPar();
			this.X0Y0_尿散り5 = pars["尿散り5"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_尿 = pars["尿"].ToPar();
			this.X0Y1_尿散り1 = pars["尿散り1"].ToPar();
			this.X0Y1_尿散り2 = pars["尿散り2"].ToPar();
			this.X0Y1_尿散り3 = pars["尿散り3"].ToPar();
			this.X0Y1_尿散り4 = pars["尿散り4"].ToPar();
			this.X0Y1_尿散り5 = pars["尿散り5"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_尿 = pars["尿"].ToPar();
			this.X0Y2_尿散り1 = pars["尿散り1"].ToPar();
			this.X0Y2_尿散り2 = pars["尿散り2"].ToPar();
			this.X0Y2_尿散り3 = pars["尿散り3"].ToPar();
			this.X0Y2_尿散り4 = pars["尿散り4"].ToPar();
			this.X0Y2_尿散り5 = pars["尿散り5"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_尿 = pars["尿"].ToPar();
			this.X0Y3_尿散り1 = pars["尿散り1"].ToPar();
			this.X0Y3_尿散り2 = pars["尿散り2"].ToPar();
			this.X0Y3_尿散り3 = pars["尿散り3"].ToPar();
			this.X0Y3_尿散り4 = pars["尿散り4"].ToPar();
			this.X0Y3_尿散り5 = pars["尿散り5"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_尿 = pars["尿"].ToPar();
			this.X0Y4_尿散り1 = pars["尿散り1"].ToPar();
			this.X0Y4_尿散り2 = pars["尿散り2"].ToPar();
			this.X0Y4_尿散り3 = pars["尿散り3"].ToPar();
			this.X0Y4_尿散り4 = pars["尿散り4"].ToPar();
			this.X0Y4_尿散り5 = pars["尿散り5"].ToPar();
			pars = this.本体[0][5];
			this.X0Y5_尿 = pars["尿"].ToPar();
			this.X0Y5_尿散り1 = pars["尿散り1"].ToPar();
			this.X0Y5_尿散り2 = pars["尿散り2"].ToPar();
			this.X0Y5_尿散り3 = pars["尿散り3"].ToPar();
			this.X0Y5_尿散り4 = pars["尿散り4"].ToPar();
			this.X0Y5_尿散り5 = pars["尿散り5"].ToPar();
			pars = this.本体[0][6];
			this.X0Y6_尿 = pars["尿"].ToPar();
			this.X0Y6_尿散り1 = pars["尿散り1"].ToPar();
			this.X0Y6_尿散り2 = pars["尿散り2"].ToPar();
			this.X0Y6_尿散り3 = pars["尿散り3"].ToPar();
			this.X0Y6_尿散り4 = pars["尿散り4"].ToPar();
			this.X0Y6_尿散り5 = pars["尿散り5"].ToPar();
			pars = this.本体[0][7];
			this.X0Y7_尿 = pars["尿"].ToPar();
			this.X0Y7_尿散り1 = pars["尿散り1"].ToPar();
			this.X0Y7_尿散り2 = pars["尿散り2"].ToPar();
			this.X0Y7_尿散り3 = pars["尿散り3"].ToPar();
			this.X0Y7_尿散り4 = pars["尿散り4"].ToPar();
			this.X0Y7_尿散り5 = pars["尿散り5"].ToPar();
			pars = this.本体[0][8];
			this.X0Y8_尿 = pars["尿"].ToPar();
			this.X0Y8_尿散り1 = pars["尿散り1"].ToPar();
			this.X0Y8_尿散り2 = pars["尿散り2"].ToPar();
			this.X0Y8_尿散り3 = pars["尿散り3"].ToPar();
			this.X0Y8_尿散り4 = pars["尿散り4"].ToPar();
			this.X0Y8_尿散り5 = pars["尿散り5"].ToPar();
			pars = this.本体[0][9];
			this.X0Y9_尿 = pars["尿"].ToPar();
			this.X0Y9_尿散り1 = pars["尿散り1"].ToPar();
			this.X0Y9_尿散り2 = pars["尿散り2"].ToPar();
			this.X0Y9_尿散り3 = pars["尿散り3"].ToPar();
			this.X0Y9_尿散り4 = pars["尿散り4"].ToPar();
			pars = this.本体[0][10];
			this.X0Y10_尿 = pars["尿"].ToPar();
			this.X0Y10_尿散り1 = pars["尿散り1"].ToPar();
			this.X0Y10_尿散り2 = pars["尿散り2"].ToPar();
			this.X0Y10_尿散り3 = pars["尿散り3"].ToPar();
			this.X0Y10_尿散り4 = pars["尿散り4"].ToPar();
			this.X0Y10_尿散り5 = pars["尿散り5"].ToPar();
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
			this.尿_表示 = e.尿_表示;
			this.尿散り1_表示 = e.尿散り1_表示;
			this.尿散り2_表示 = e.尿散り2_表示;
			this.尿散り3_表示 = e.尿散り3_表示;
			this.尿散り4_表示 = e.尿散り4_表示;
			this.尿散り5_表示 = e.尿散り5_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_尿CP = new ColorP(this.X0Y0_尿, this.尿CD, DisUnit, true);
			this.X0Y0_尿散り1CP = new ColorP(this.X0Y0_尿散り1, this.尿散り1CD, DisUnit, true);
			this.X0Y0_尿散り2CP = new ColorP(this.X0Y0_尿散り2, this.尿散り2CD, DisUnit, true);
			this.X0Y0_尿散り3CP = new ColorP(this.X0Y0_尿散り3, this.尿散り3CD, DisUnit, true);
			this.X0Y0_尿散り4CP = new ColorP(this.X0Y0_尿散り4, this.尿散り4CD, DisUnit, true);
			this.X0Y0_尿散り5CP = new ColorP(this.X0Y0_尿散り5, this.尿散り5CD, DisUnit, true);
			this.X0Y1_尿CP = new ColorP(this.X0Y1_尿, this.尿CD, DisUnit, true);
			this.X0Y1_尿散り1CP = new ColorP(this.X0Y1_尿散り1, this.尿散り1CD, DisUnit, true);
			this.X0Y1_尿散り2CP = new ColorP(this.X0Y1_尿散り2, this.尿散り2CD, DisUnit, true);
			this.X0Y1_尿散り3CP = new ColorP(this.X0Y1_尿散り3, this.尿散り3CD, DisUnit, true);
			this.X0Y1_尿散り4CP = new ColorP(this.X0Y1_尿散り4, this.尿散り4CD, DisUnit, true);
			this.X0Y1_尿散り5CP = new ColorP(this.X0Y1_尿散り5, this.尿散り5CD, DisUnit, true);
			this.X0Y2_尿CP = new ColorP(this.X0Y2_尿, this.尿CD, DisUnit, true);
			this.X0Y2_尿散り1CP = new ColorP(this.X0Y2_尿散り1, this.尿散り1CD, DisUnit, true);
			this.X0Y2_尿散り2CP = new ColorP(this.X0Y2_尿散り2, this.尿散り2CD, DisUnit, true);
			this.X0Y2_尿散り3CP = new ColorP(this.X0Y2_尿散り3, this.尿散り3CD, DisUnit, true);
			this.X0Y2_尿散り4CP = new ColorP(this.X0Y2_尿散り4, this.尿散り4CD, DisUnit, true);
			this.X0Y2_尿散り5CP = new ColorP(this.X0Y2_尿散り5, this.尿散り5CD, DisUnit, true);
			this.X0Y3_尿CP = new ColorP(this.X0Y3_尿, this.尿CD, DisUnit, true);
			this.X0Y3_尿散り1CP = new ColorP(this.X0Y3_尿散り1, this.尿散り1CD, DisUnit, true);
			this.X0Y3_尿散り2CP = new ColorP(this.X0Y3_尿散り2, this.尿散り2CD, DisUnit, true);
			this.X0Y3_尿散り3CP = new ColorP(this.X0Y3_尿散り3, this.尿散り3CD, DisUnit, true);
			this.X0Y3_尿散り4CP = new ColorP(this.X0Y3_尿散り4, this.尿散り4CD, DisUnit, true);
			this.X0Y3_尿散り5CP = new ColorP(this.X0Y3_尿散り5, this.尿散り5CD, DisUnit, true);
			this.X0Y4_尿CP = new ColorP(this.X0Y4_尿, this.尿CD, DisUnit, true);
			this.X0Y4_尿散り1CP = new ColorP(this.X0Y4_尿散り1, this.尿散り1CD, DisUnit, true);
			this.X0Y4_尿散り2CP = new ColorP(this.X0Y4_尿散り2, this.尿散り2CD, DisUnit, true);
			this.X0Y4_尿散り3CP = new ColorP(this.X0Y4_尿散り3, this.尿散り3CD, DisUnit, true);
			this.X0Y4_尿散り4CP = new ColorP(this.X0Y4_尿散り4, this.尿散り4CD, DisUnit, true);
			this.X0Y4_尿散り5CP = new ColorP(this.X0Y4_尿散り5, this.尿散り5CD, DisUnit, true);
			this.X0Y5_尿CP = new ColorP(this.X0Y5_尿, this.尿CD, DisUnit, true);
			this.X0Y5_尿散り1CP = new ColorP(this.X0Y5_尿散り1, this.尿散り1CD, DisUnit, true);
			this.X0Y5_尿散り2CP = new ColorP(this.X0Y5_尿散り2, this.尿散り2CD, DisUnit, true);
			this.X0Y5_尿散り3CP = new ColorP(this.X0Y5_尿散り3, this.尿散り3CD, DisUnit, true);
			this.X0Y5_尿散り4CP = new ColorP(this.X0Y5_尿散り4, this.尿散り4CD, DisUnit, true);
			this.X0Y5_尿散り5CP = new ColorP(this.X0Y5_尿散り5, this.尿散り5CD, DisUnit, true);
			this.X0Y6_尿CP = new ColorP(this.X0Y6_尿, this.尿CD, DisUnit, true);
			this.X0Y6_尿散り1CP = new ColorP(this.X0Y6_尿散り1, this.尿散り1CD, DisUnit, true);
			this.X0Y6_尿散り2CP = new ColorP(this.X0Y6_尿散り2, this.尿散り2CD, DisUnit, true);
			this.X0Y6_尿散り3CP = new ColorP(this.X0Y6_尿散り3, this.尿散り3CD, DisUnit, true);
			this.X0Y6_尿散り4CP = new ColorP(this.X0Y6_尿散り4, this.尿散り4CD, DisUnit, true);
			this.X0Y6_尿散り5CP = new ColorP(this.X0Y6_尿散り5, this.尿散り5CD, DisUnit, true);
			this.X0Y7_尿CP = new ColorP(this.X0Y7_尿, this.尿CD, DisUnit, true);
			this.X0Y7_尿散り1CP = new ColorP(this.X0Y7_尿散り1, this.尿散り1CD, DisUnit, true);
			this.X0Y7_尿散り2CP = new ColorP(this.X0Y7_尿散り2, this.尿散り2CD, DisUnit, true);
			this.X0Y7_尿散り3CP = new ColorP(this.X0Y7_尿散り3, this.尿散り3CD, DisUnit, true);
			this.X0Y7_尿散り4CP = new ColorP(this.X0Y7_尿散り4, this.尿散り4CD, DisUnit, true);
			this.X0Y7_尿散り5CP = new ColorP(this.X0Y7_尿散り5, this.尿散り5CD, DisUnit, true);
			this.X0Y8_尿CP = new ColorP(this.X0Y8_尿, this.尿CD, DisUnit, true);
			this.X0Y8_尿散り1CP = new ColorP(this.X0Y8_尿散り1, this.尿散り1CD, DisUnit, true);
			this.X0Y8_尿散り2CP = new ColorP(this.X0Y8_尿散り2, this.尿散り2CD, DisUnit, true);
			this.X0Y8_尿散り3CP = new ColorP(this.X0Y8_尿散り3, this.尿散り3CD, DisUnit, true);
			this.X0Y8_尿散り4CP = new ColorP(this.X0Y8_尿散り4, this.尿散り4CD, DisUnit, true);
			this.X0Y8_尿散り5CP = new ColorP(this.X0Y8_尿散り5, this.尿散り5CD, DisUnit, true);
			this.X0Y9_尿CP = new ColorP(this.X0Y9_尿, this.尿CD, DisUnit, true);
			this.X0Y9_尿散り1CP = new ColorP(this.X0Y9_尿散り1, this.尿散り1CD, DisUnit, true);
			this.X0Y9_尿散り2CP = new ColorP(this.X0Y9_尿散り2, this.尿散り2CD, DisUnit, true);
			this.X0Y9_尿散り3CP = new ColorP(this.X0Y9_尿散り3, this.尿散り3CD, DisUnit, true);
			this.X0Y9_尿散り4CP = new ColorP(this.X0Y9_尿散り4, this.尿散り4CD, DisUnit, true);
			this.X0Y10_尿CP = new ColorP(this.X0Y10_尿, this.尿CD, DisUnit, true);
			this.X0Y10_尿散り1CP = new ColorP(this.X0Y10_尿散り1, this.尿散り1CD, DisUnit, true);
			this.X0Y10_尿散り2CP = new ColorP(this.X0Y10_尿散り2, this.尿散り2CD, DisUnit, true);
			this.X0Y10_尿散り3CP = new ColorP(this.X0Y10_尿散り3, this.尿散り3CD, DisUnit, true);
			this.X0Y10_尿散り4CP = new ColorP(this.X0Y10_尿散り4, this.尿散り4CD, DisUnit, true);
			this.X0Y10_尿散り5CP = new ColorP(this.X0Y10_尿散り5, this.尿散り5CD, DisUnit, true);
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

		public bool 尿_表示
		{
			get
			{
				return this.X0Y0_尿.Dra;
			}
			set
			{
				this.X0Y0_尿.Dra = value;
				this.X0Y1_尿.Dra = value;
				this.X0Y2_尿.Dra = value;
				this.X0Y3_尿.Dra = value;
				this.X0Y4_尿.Dra = value;
				this.X0Y5_尿.Dra = value;
				this.X0Y6_尿.Dra = value;
				this.X0Y7_尿.Dra = value;
				this.X0Y8_尿.Dra = value;
				this.X0Y9_尿.Dra = value;
				this.X0Y10_尿.Dra = value;
				this.X0Y0_尿.Hit = value;
				this.X0Y1_尿.Hit = value;
				this.X0Y2_尿.Hit = value;
				this.X0Y3_尿.Hit = value;
				this.X0Y4_尿.Hit = value;
				this.X0Y5_尿.Hit = value;
				this.X0Y6_尿.Hit = value;
				this.X0Y7_尿.Hit = value;
				this.X0Y8_尿.Hit = value;
				this.X0Y9_尿.Hit = value;
				this.X0Y10_尿.Hit = value;
			}
		}

		public bool 尿散り1_表示
		{
			get
			{
				return this.X0Y0_尿散り1.Dra;
			}
			set
			{
				this.X0Y0_尿散り1.Dra = value;
				this.X0Y1_尿散り1.Dra = value;
				this.X0Y2_尿散り1.Dra = value;
				this.X0Y3_尿散り1.Dra = value;
				this.X0Y4_尿散り1.Dra = value;
				this.X0Y5_尿散り1.Dra = value;
				this.X0Y6_尿散り1.Dra = value;
				this.X0Y7_尿散り1.Dra = value;
				this.X0Y8_尿散り1.Dra = value;
				this.X0Y9_尿散り1.Dra = value;
				this.X0Y10_尿散り1.Dra = value;
				this.X0Y0_尿散り1.Hit = value;
				this.X0Y1_尿散り1.Hit = value;
				this.X0Y2_尿散り1.Hit = value;
				this.X0Y3_尿散り1.Hit = value;
				this.X0Y4_尿散り1.Hit = value;
				this.X0Y5_尿散り1.Hit = value;
				this.X0Y6_尿散り1.Hit = value;
				this.X0Y7_尿散り1.Hit = value;
				this.X0Y8_尿散り1.Hit = value;
				this.X0Y9_尿散り1.Hit = value;
				this.X0Y10_尿散り1.Hit = value;
			}
		}

		public bool 尿散り2_表示
		{
			get
			{
				return this.X0Y0_尿散り2.Dra;
			}
			set
			{
				this.X0Y0_尿散り2.Dra = value;
				this.X0Y1_尿散り2.Dra = value;
				this.X0Y2_尿散り2.Dra = value;
				this.X0Y3_尿散り2.Dra = value;
				this.X0Y4_尿散り2.Dra = value;
				this.X0Y5_尿散り2.Dra = value;
				this.X0Y6_尿散り2.Dra = value;
				this.X0Y7_尿散り2.Dra = value;
				this.X0Y8_尿散り2.Dra = value;
				this.X0Y9_尿散り2.Dra = value;
				this.X0Y10_尿散り2.Dra = value;
				this.X0Y0_尿散り2.Hit = value;
				this.X0Y1_尿散り2.Hit = value;
				this.X0Y2_尿散り2.Hit = value;
				this.X0Y3_尿散り2.Hit = value;
				this.X0Y4_尿散り2.Hit = value;
				this.X0Y5_尿散り2.Hit = value;
				this.X0Y6_尿散り2.Hit = value;
				this.X0Y7_尿散り2.Hit = value;
				this.X0Y8_尿散り2.Hit = value;
				this.X0Y9_尿散り2.Hit = value;
				this.X0Y10_尿散り2.Hit = value;
			}
		}

		public bool 尿散り3_表示
		{
			get
			{
				return this.X0Y0_尿散り3.Dra;
			}
			set
			{
				this.X0Y0_尿散り3.Dra = value;
				this.X0Y1_尿散り3.Dra = value;
				this.X0Y2_尿散り3.Dra = value;
				this.X0Y3_尿散り3.Dra = value;
				this.X0Y4_尿散り3.Dra = value;
				this.X0Y5_尿散り3.Dra = value;
				this.X0Y6_尿散り3.Dra = value;
				this.X0Y7_尿散り3.Dra = value;
				this.X0Y8_尿散り3.Dra = value;
				this.X0Y9_尿散り3.Dra = value;
				this.X0Y10_尿散り3.Dra = value;
				this.X0Y0_尿散り3.Hit = value;
				this.X0Y1_尿散り3.Hit = value;
				this.X0Y2_尿散り3.Hit = value;
				this.X0Y3_尿散り3.Hit = value;
				this.X0Y4_尿散り3.Hit = value;
				this.X0Y5_尿散り3.Hit = value;
				this.X0Y6_尿散り3.Hit = value;
				this.X0Y7_尿散り3.Hit = value;
				this.X0Y8_尿散り3.Hit = value;
				this.X0Y9_尿散り3.Hit = value;
				this.X0Y10_尿散り3.Hit = value;
			}
		}

		public bool 尿散り4_表示
		{
			get
			{
				return this.X0Y0_尿散り4.Dra;
			}
			set
			{
				this.X0Y0_尿散り4.Dra = value;
				this.X0Y1_尿散り4.Dra = value;
				this.X0Y2_尿散り4.Dra = value;
				this.X0Y3_尿散り4.Dra = value;
				this.X0Y4_尿散り4.Dra = value;
				this.X0Y5_尿散り4.Dra = value;
				this.X0Y6_尿散り4.Dra = value;
				this.X0Y7_尿散り4.Dra = value;
				this.X0Y8_尿散り4.Dra = value;
				this.X0Y9_尿散り4.Dra = value;
				this.X0Y10_尿散り4.Dra = value;
				this.X0Y0_尿散り4.Hit = value;
				this.X0Y1_尿散り4.Hit = value;
				this.X0Y2_尿散り4.Hit = value;
				this.X0Y3_尿散り4.Hit = value;
				this.X0Y4_尿散り4.Hit = value;
				this.X0Y5_尿散り4.Hit = value;
				this.X0Y6_尿散り4.Hit = value;
				this.X0Y7_尿散り4.Hit = value;
				this.X0Y8_尿散り4.Hit = value;
				this.X0Y9_尿散り4.Hit = value;
				this.X0Y10_尿散り4.Hit = value;
			}
		}

		public bool 尿散り5_表示
		{
			get
			{
				return this.X0Y0_尿散り5.Dra;
			}
			set
			{
				this.X0Y0_尿散り5.Dra = value;
				this.X0Y1_尿散り5.Dra = value;
				this.X0Y2_尿散り5.Dra = value;
				this.X0Y3_尿散り5.Dra = value;
				this.X0Y4_尿散り5.Dra = value;
				this.X0Y5_尿散り5.Dra = value;
				this.X0Y6_尿散り5.Dra = value;
				this.X0Y7_尿散り5.Dra = value;
				this.X0Y8_尿散り5.Dra = value;
				this.X0Y10_尿散り5.Dra = value;
				this.X0Y0_尿散り5.Hit = value;
				this.X0Y1_尿散り5.Hit = value;
				this.X0Y2_尿散り5.Hit = value;
				this.X0Y3_尿散り5.Hit = value;
				this.X0Y4_尿散り5.Hit = value;
				this.X0Y5_尿散り5.Hit = value;
				this.X0Y6_尿散り5.Hit = value;
				this.X0Y7_尿散り5.Hit = value;
				this.X0Y8_尿散り5.Hit = value;
				this.X0Y10_尿散り5.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.尿_表示;
			}
			set
			{
				this.尿_表示 = value;
				this.尿散り1_表示 = value;
				this.尿散り2_表示 = value;
				this.尿散り3_表示 = value;
				this.尿散り4_表示 = value;
				this.尿散り5_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.尿CD.不透明度;
			}
			set
			{
				this.尿CD.不透明度 = value;
				this.尿散り1CD.不透明度 = value;
				this.尿散り2CD.不透明度 = value;
				this.尿散り3CD.不透明度 = value;
				this.尿散り4CD.不透明度 = value;
				this.尿散り5CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_尿CP.Update();
				this.X0Y0_尿散り1CP.Update();
				this.X0Y0_尿散り2CP.Update();
				this.X0Y0_尿散り3CP.Update();
				this.X0Y0_尿散り4CP.Update();
				this.X0Y0_尿散り5CP.Update();
				return;
			case 1:
				this.X0Y1_尿CP.Update();
				this.X0Y1_尿散り1CP.Update();
				this.X0Y1_尿散り2CP.Update();
				this.X0Y1_尿散り3CP.Update();
				this.X0Y1_尿散り4CP.Update();
				this.X0Y1_尿散り5CP.Update();
				return;
			case 2:
				this.X0Y2_尿CP.Update();
				this.X0Y2_尿散り1CP.Update();
				this.X0Y2_尿散り2CP.Update();
				this.X0Y2_尿散り3CP.Update();
				this.X0Y2_尿散り4CP.Update();
				this.X0Y2_尿散り5CP.Update();
				return;
			case 3:
				this.X0Y3_尿CP.Update();
				this.X0Y3_尿散り1CP.Update();
				this.X0Y3_尿散り2CP.Update();
				this.X0Y3_尿散り3CP.Update();
				this.X0Y3_尿散り4CP.Update();
				this.X0Y3_尿散り5CP.Update();
				return;
			case 4:
				this.X0Y4_尿CP.Update();
				this.X0Y4_尿散り1CP.Update();
				this.X0Y4_尿散り2CP.Update();
				this.X0Y4_尿散り3CP.Update();
				this.X0Y4_尿散り4CP.Update();
				this.X0Y4_尿散り5CP.Update();
				return;
			case 5:
				this.X0Y5_尿CP.Update();
				this.X0Y5_尿散り1CP.Update();
				this.X0Y5_尿散り2CP.Update();
				this.X0Y5_尿散り3CP.Update();
				this.X0Y5_尿散り4CP.Update();
				this.X0Y5_尿散り5CP.Update();
				return;
			case 6:
				this.X0Y6_尿CP.Update();
				this.X0Y6_尿散り1CP.Update();
				this.X0Y6_尿散り2CP.Update();
				this.X0Y6_尿散り3CP.Update();
				this.X0Y6_尿散り4CP.Update();
				this.X0Y6_尿散り5CP.Update();
				return;
			case 7:
				this.X0Y7_尿CP.Update();
				this.X0Y7_尿散り1CP.Update();
				this.X0Y7_尿散り2CP.Update();
				this.X0Y7_尿散り3CP.Update();
				this.X0Y7_尿散り4CP.Update();
				this.X0Y7_尿散り5CP.Update();
				return;
			case 8:
				this.X0Y8_尿CP.Update();
				this.X0Y8_尿散り1CP.Update();
				this.X0Y8_尿散り2CP.Update();
				this.X0Y8_尿散り3CP.Update();
				this.X0Y8_尿散り4CP.Update();
				this.X0Y8_尿散り5CP.Update();
				return;
			case 9:
				this.X0Y9_尿CP.Update();
				this.X0Y9_尿散り1CP.Update();
				this.X0Y9_尿散り2CP.Update();
				this.X0Y9_尿散り3CP.Update();
				this.X0Y9_尿散り4CP.Update();
				return;
			default:
				this.X0Y10_尿CP.Update();
				this.X0Y10_尿散り1CP.Update();
				this.X0Y10_尿散り2CP.Update();
				this.X0Y10_尿散り3CP.Update();
				this.X0Y10_尿散り4CP.Update();
				this.X0Y10_尿散り5CP.Update();
				return;
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.尿CD = new ColorD(ref 体配色.尿線, ref 体配色.尿);
			this.尿散り1CD = new ColorD(ref 体配色.尿線, ref 体配色.尿);
			this.尿散り2CD = new ColorD(ref 体配色.尿線, ref 体配色.尿);
			this.尿散り3CD = new ColorD(ref 体配色.尿線, ref 体配色.尿);
			this.尿散り4CD = new ColorD(ref 体配色.尿線, ref 体配色.尿);
			this.尿散り5CD = new ColorD(ref 体配色.尿線, ref 体配色.尿);
		}

		public Par X0Y0_尿;

		public Par X0Y0_尿散り1;

		public Par X0Y0_尿散り2;

		public Par X0Y0_尿散り3;

		public Par X0Y0_尿散り4;

		public Par X0Y0_尿散り5;

		public Par X0Y1_尿;

		public Par X0Y1_尿散り1;

		public Par X0Y1_尿散り2;

		public Par X0Y1_尿散り3;

		public Par X0Y1_尿散り4;

		public Par X0Y1_尿散り5;

		public Par X0Y2_尿;

		public Par X0Y2_尿散り1;

		public Par X0Y2_尿散り2;

		public Par X0Y2_尿散り3;

		public Par X0Y2_尿散り4;

		public Par X0Y2_尿散り5;

		public Par X0Y3_尿;

		public Par X0Y3_尿散り1;

		public Par X0Y3_尿散り2;

		public Par X0Y3_尿散り3;

		public Par X0Y3_尿散り4;

		public Par X0Y3_尿散り5;

		public Par X0Y4_尿;

		public Par X0Y4_尿散り1;

		public Par X0Y4_尿散り2;

		public Par X0Y4_尿散り3;

		public Par X0Y4_尿散り4;

		public Par X0Y4_尿散り5;

		public Par X0Y5_尿;

		public Par X0Y5_尿散り1;

		public Par X0Y5_尿散り2;

		public Par X0Y5_尿散り3;

		public Par X0Y5_尿散り4;

		public Par X0Y5_尿散り5;

		public Par X0Y6_尿;

		public Par X0Y6_尿散り1;

		public Par X0Y6_尿散り2;

		public Par X0Y6_尿散り3;

		public Par X0Y6_尿散り4;

		public Par X0Y6_尿散り5;

		public Par X0Y7_尿;

		public Par X0Y7_尿散り1;

		public Par X0Y7_尿散り2;

		public Par X0Y7_尿散り3;

		public Par X0Y7_尿散り4;

		public Par X0Y7_尿散り5;

		public Par X0Y8_尿;

		public Par X0Y8_尿散り1;

		public Par X0Y8_尿散り2;

		public Par X0Y8_尿散り3;

		public Par X0Y8_尿散り4;

		public Par X0Y8_尿散り5;

		public Par X0Y9_尿;

		public Par X0Y9_尿散り1;

		public Par X0Y9_尿散り2;

		public Par X0Y9_尿散り3;

		public Par X0Y9_尿散り4;

		public Par X0Y10_尿;

		public Par X0Y10_尿散り1;

		public Par X0Y10_尿散り2;

		public Par X0Y10_尿散り3;

		public Par X0Y10_尿散り4;

		public Par X0Y10_尿散り5;

		public ColorD 尿CD;

		public ColorD 尿散り1CD;

		public ColorD 尿散り2CD;

		public ColorD 尿散り3CD;

		public ColorD 尿散り4CD;

		public ColorD 尿散り5CD;

		public ColorP X0Y0_尿CP;

		public ColorP X0Y0_尿散り1CP;

		public ColorP X0Y0_尿散り2CP;

		public ColorP X0Y0_尿散り3CP;

		public ColorP X0Y0_尿散り4CP;

		public ColorP X0Y0_尿散り5CP;

		public ColorP X0Y1_尿CP;

		public ColorP X0Y1_尿散り1CP;

		public ColorP X0Y1_尿散り2CP;

		public ColorP X0Y1_尿散り3CP;

		public ColorP X0Y1_尿散り4CP;

		public ColorP X0Y1_尿散り5CP;

		public ColorP X0Y2_尿CP;

		public ColorP X0Y2_尿散り1CP;

		public ColorP X0Y2_尿散り2CP;

		public ColorP X0Y2_尿散り3CP;

		public ColorP X0Y2_尿散り4CP;

		public ColorP X0Y2_尿散り5CP;

		public ColorP X0Y3_尿CP;

		public ColorP X0Y3_尿散り1CP;

		public ColorP X0Y3_尿散り2CP;

		public ColorP X0Y3_尿散り3CP;

		public ColorP X0Y3_尿散り4CP;

		public ColorP X0Y3_尿散り5CP;

		public ColorP X0Y4_尿CP;

		public ColorP X0Y4_尿散り1CP;

		public ColorP X0Y4_尿散り2CP;

		public ColorP X0Y4_尿散り3CP;

		public ColorP X0Y4_尿散り4CP;

		public ColorP X0Y4_尿散り5CP;

		public ColorP X0Y5_尿CP;

		public ColorP X0Y5_尿散り1CP;

		public ColorP X0Y5_尿散り2CP;

		public ColorP X0Y5_尿散り3CP;

		public ColorP X0Y5_尿散り4CP;

		public ColorP X0Y5_尿散り5CP;

		public ColorP X0Y6_尿CP;

		public ColorP X0Y6_尿散り1CP;

		public ColorP X0Y6_尿散り2CP;

		public ColorP X0Y6_尿散り3CP;

		public ColorP X0Y6_尿散り4CP;

		public ColorP X0Y6_尿散り5CP;

		public ColorP X0Y7_尿CP;

		public ColorP X0Y7_尿散り1CP;

		public ColorP X0Y7_尿散り2CP;

		public ColorP X0Y7_尿散り3CP;

		public ColorP X0Y7_尿散り4CP;

		public ColorP X0Y7_尿散り5CP;

		public ColorP X0Y8_尿CP;

		public ColorP X0Y8_尿散り1CP;

		public ColorP X0Y8_尿散り2CP;

		public ColorP X0Y8_尿散り3CP;

		public ColorP X0Y8_尿散り4CP;

		public ColorP X0Y8_尿散り5CP;

		public ColorP X0Y9_尿CP;

		public ColorP X0Y9_尿散り1CP;

		public ColorP X0Y9_尿散り2CP;

		public ColorP X0Y9_尿散り3CP;

		public ColorP X0Y9_尿散り4CP;

		public ColorP X0Y10_尿CP;

		public ColorP X0Y10_尿散り1CP;

		public ColorP X0Y10_尿散り2CP;

		public ColorP X0Y10_尿散り3CP;

		public ColorP X0Y10_尿散り4CP;

		public ColorP X0Y10_尿散り5CP;
	}
}
