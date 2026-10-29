using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 射精 : Ele
	{
		public 射精(double DisUnit, 配色指定 配色指定, 主人公配色 体配色, Med Med, 射精D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.カ\u30FCソル["射精"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_精液 = pars["精液"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_精液 = pars["精液"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_精液 = pars["精液"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_精液 = pars["精液"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_精液 = pars["精液"].ToPar();
			pars = this.本体[0][5];
			this.X0Y5_精液 = pars["精液"].ToPar();
			pars = this.本体[0][6];
			this.X0Y6_精液 = pars["精液"].ToPar();
			pars = this.本体[1][0];
			this.X1Y0_精液 = pars["精液"].ToPar();
			pars = this.本体[1][1];
			this.X1Y1_精液 = pars["精液"].ToPar();
			pars = this.本体[1][2];
			this.X1Y2_精液 = pars["精液"].ToPar();
			pars = this.本体[1][3];
			this.X1Y3_精液 = pars["精液"].ToPar();
			pars = this.本体[1][4];
			this.X1Y4_精液 = pars["精液"].ToPar();
			pars = this.本体[1][5];
			this.X1Y5_精液 = pars["精液"].ToPar();
			pars = this.本体[1][6];
			this.X1Y6_精液 = pars["精液"].ToPar();
			pars = this.本体[1][7];
			this.X1Y7_精液 = pars["精液"].ToPar();
			pars = this.本体[1][8];
			this.X1Y8_精液掛け = pars["精液掛け"].ToPar();
			this.X1Y8_精液 = pars["精液"].ToPar();
			pars = this.本体[1][9];
			this.X1Y9_精液掛け = pars["精液掛け"].ToPar();
			this.X1Y9_精液 = pars["精液"].ToPar();
			pars = this.本体[1][10];
			this.X1Y10_精液掛け = pars["精液掛け"].ToPar();
			this.X1Y10_精液 = pars["精液"].ToPar();
			pars = this.本体[1][11];
			this.X1Y11_精液掛け = pars["精液掛け"].ToPar();
			this.X1Y11_精液 = pars["精液"].ToPar();
			pars = this.本体[1][12];
			this.X1Y12_精液掛け = pars["精液掛け"].ToPar();
			this.X1Y12_精液 = pars["精液"].ToPar();
			pars = this.本体[1][13];
			this.X1Y13_精液掛け = pars["精液掛け"].ToPar();
			this.X1Y13_精液 = pars["精液"].ToPar();
			pars = this.本体[1][14];
			this.X1Y14_精液 = pars["精液"].ToPar();
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
			this.精液_表示 = e.精液_表示;
			this.精液掛け_表示 = e.精液掛け_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_精液CP = new ColorP(this.X0Y0_精液, this.精液CD, DisUnit, true);
			this.X0Y1_精液CP = new ColorP(this.X0Y1_精液, this.精液CD, DisUnit, true);
			this.X0Y2_精液CP = new ColorP(this.X0Y2_精液, this.精液CD, DisUnit, true);
			this.X0Y3_精液CP = new ColorP(this.X0Y3_精液, this.精液CD, DisUnit, true);
			this.X0Y4_精液CP = new ColorP(this.X0Y4_精液, this.精液CD, DisUnit, true);
			this.X0Y5_精液CP = new ColorP(this.X0Y5_精液, this.精液CD, DisUnit, true);
			this.X0Y6_精液CP = new ColorP(this.X0Y6_精液, this.精液CD, DisUnit, true);
			this.X1Y0_精液CP = new ColorP(this.X1Y0_精液, this.精液CD, DisUnit, true);
			this.X1Y1_精液CP = new ColorP(this.X1Y1_精液, this.精液CD, DisUnit, true);
			this.X1Y2_精液CP = new ColorP(this.X1Y2_精液, this.精液CD, DisUnit, true);
			this.X1Y3_精液CP = new ColorP(this.X1Y3_精液, this.精液CD, DisUnit, true);
			this.X1Y4_精液CP = new ColorP(this.X1Y4_精液, this.精液CD, DisUnit, true);
			this.X1Y5_精液CP = new ColorP(this.X1Y5_精液, this.精液CD, DisUnit, true);
			this.X1Y6_精液CP = new ColorP(this.X1Y6_精液, this.精液CD, DisUnit, true);
			this.X1Y7_精液CP = new ColorP(this.X1Y7_精液, this.精液CD, DisUnit, true);
			this.X1Y8_精液掛けCP = new ColorP(this.X1Y8_精液掛け, this.精液掛けCD, DisUnit, true);
			this.X1Y8_精液CP = new ColorP(this.X1Y8_精液, this.精液CD, DisUnit, true);
			this.X1Y9_精液掛けCP = new ColorP(this.X1Y9_精液掛け, this.精液掛けCD, DisUnit, true);
			this.X1Y9_精液CP = new ColorP(this.X1Y9_精液, this.精液CD, DisUnit, true);
			this.X1Y10_精液掛けCP = new ColorP(this.X1Y10_精液掛け, this.精液掛けCD, DisUnit, true);
			this.X1Y10_精液CP = new ColorP(this.X1Y10_精液, this.精液CD, DisUnit, true);
			this.X1Y11_精液掛けCP = new ColorP(this.X1Y11_精液掛け, this.精液掛けCD, DisUnit, true);
			this.X1Y11_精液CP = new ColorP(this.X1Y11_精液, this.精液CD, DisUnit, true);
			this.X1Y12_精液掛けCP = new ColorP(this.X1Y12_精液掛け, this.精液掛けCD, DisUnit, true);
			this.X1Y12_精液CP = new ColorP(this.X1Y12_精液, this.精液CD, DisUnit, true);
			this.X1Y13_精液掛けCP = new ColorP(this.X1Y13_精液掛け, this.精液掛けCD, DisUnit, true);
			this.X1Y13_精液CP = new ColorP(this.X1Y13_精液, this.精液CD, DisUnit, true);
			this.X1Y14_精液CP = new ColorP(this.X1Y14_精液, this.精液CD, DisUnit, true);
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

		public bool 精液_表示
		{
			get
			{
				return this.X0Y0_精液.Dra;
			}
			set
			{
				this.X0Y0_精液.Dra = value;
				this.X0Y1_精液.Dra = value;
				this.X0Y2_精液.Dra = value;
				this.X0Y3_精液.Dra = value;
				this.X0Y4_精液.Dra = value;
				this.X0Y5_精液.Dra = value;
				this.X0Y6_精液.Dra = value;
				this.X1Y0_精液.Dra = value;
				this.X1Y1_精液.Dra = value;
				this.X1Y2_精液.Dra = value;
				this.X1Y3_精液.Dra = value;
				this.X1Y4_精液.Dra = value;
				this.X1Y5_精液.Dra = value;
				this.X1Y6_精液.Dra = value;
				this.X1Y7_精液.Dra = value;
				this.X1Y8_精液.Dra = value;
				this.X1Y9_精液.Dra = value;
				this.X1Y10_精液.Dra = value;
				this.X1Y11_精液.Dra = value;
				this.X1Y12_精液.Dra = value;
				this.X1Y13_精液.Dra = value;
				this.X1Y14_精液.Dra = value;
				this.X0Y0_精液.Hit = value;
				this.X0Y1_精液.Hit = value;
				this.X0Y2_精液.Hit = value;
				this.X0Y3_精液.Hit = value;
				this.X0Y4_精液.Hit = value;
				this.X0Y5_精液.Hit = value;
				this.X0Y6_精液.Hit = value;
				this.X1Y0_精液.Hit = value;
				this.X1Y1_精液.Hit = value;
				this.X1Y2_精液.Hit = value;
				this.X1Y3_精液.Hit = value;
				this.X1Y4_精液.Hit = value;
				this.X1Y5_精液.Hit = value;
				this.X1Y6_精液.Hit = value;
				this.X1Y7_精液.Hit = value;
				this.X1Y8_精液.Hit = value;
				this.X1Y9_精液.Hit = value;
				this.X1Y10_精液.Hit = value;
				this.X1Y11_精液.Hit = value;
				this.X1Y12_精液.Hit = value;
				this.X1Y13_精液.Hit = value;
				this.X1Y14_精液.Hit = value;
			}
		}

		public bool 精液掛け_表示
		{
			get
			{
				return this.X1Y8_精液掛け.Dra;
			}
			set
			{
				this.X1Y8_精液掛け.Dra = value;
				this.X1Y9_精液掛け.Dra = value;
				this.X1Y10_精液掛け.Dra = value;
				this.X1Y11_精液掛け.Dra = value;
				this.X1Y12_精液掛け.Dra = value;
				this.X1Y13_精液掛け.Dra = value;
				this.X1Y8_精液掛け.Hit = value;
				this.X1Y9_精液掛け.Hit = value;
				this.X1Y10_精液掛け.Hit = value;
				this.X1Y11_精液掛け.Hit = value;
				this.X1Y12_精液掛け.Hit = value;
				this.X1Y13_精液掛け.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.精液_表示;
			}
			set
			{
				this.精液_表示 = value;
				this.精液掛け_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.精液掛けCD.不透明度;
			}
			set
			{
				this.精液掛けCD.不透明度 = value;
				this.精液CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			if (this.本体.IndexX == 0)
			{
				switch (this.本体.IndexY)
				{
				case 0:
					this.X0Y0_精液CP.Update();
					return;
				case 1:
					this.X0Y1_精液CP.Update();
					return;
				case 2:
					this.X0Y2_精液CP.Update();
					return;
				case 3:
					this.X0Y3_精液CP.Update();
					return;
				case 4:
					this.X0Y4_精液CP.Update();
					return;
				case 5:
					this.X0Y5_精液CP.Update();
					return;
				default:
					this.X0Y6_精液CP.Update();
					return;
				}
			}
			else
			{
				switch (this.本体.IndexY)
				{
				case 0:
					this.X1Y0_精液CP.Update();
					return;
				case 1:
					this.X1Y1_精液CP.Update();
					return;
				case 2:
					this.X1Y2_精液CP.Update();
					return;
				case 3:
					this.X1Y3_精液CP.Update();
					return;
				case 4:
					this.X1Y4_精液CP.Update();
					return;
				case 5:
					this.X1Y5_精液CP.Update();
					return;
				case 6:
					this.X1Y6_精液CP.Update();
					return;
				case 7:
					this.X1Y7_精液CP.Update();
					return;
				case 8:
					this.X1Y8_精液掛けCP.Update();
					this.X1Y8_精液CP.Update();
					return;
				case 9:
					this.X1Y9_精液掛けCP.Update();
					this.X1Y9_精液CP.Update();
					return;
				case 10:
					this.X1Y10_精液掛けCP.Update();
					this.X1Y10_精液CP.Update();
					return;
				case 11:
					this.X1Y11_精液掛けCP.Update();
					this.X1Y11_精液CP.Update();
					return;
				case 12:
					this.X1Y12_精液掛けCP.Update();
					this.X1Y12_精液CP.Update();
					return;
				case 13:
					this.X1Y13_精液掛けCP.Update();
					this.X1Y13_精液CP.Update();
					return;
				default:
					this.X1Y14_精液CP.Update();
					return;
				}
			}
		}

		private void 配色(主人公配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(主人公配色 体配色)
		{
			this.精液掛けCD = new ColorD(ref 体配色.精線, ref 体配色.精液ぶっかけ);
			this.精液CD = new ColorD(ref 体配色.精線, ref 体配色.精液ぶっかけ);
		}

		public Par X0Y0_精液;

		public Par X0Y1_精液;

		public Par X0Y2_精液;

		public Par X0Y3_精液;

		public Par X0Y4_精液;

		public Par X0Y5_精液;

		public Par X0Y6_精液;

		public Par X1Y0_精液;

		public Par X1Y1_精液;

		public Par X1Y2_精液;

		public Par X1Y3_精液;

		public Par X1Y4_精液;

		public Par X1Y5_精液;

		public Par X1Y6_精液;

		public Par X1Y7_精液;

		public Par X1Y8_精液掛け;

		public Par X1Y8_精液;

		public Par X1Y9_精液掛け;

		public Par X1Y9_精液;

		public Par X1Y10_精液掛け;

		public Par X1Y10_精液;

		public Par X1Y11_精液掛け;

		public Par X1Y11_精液;

		public Par X1Y12_精液掛け;

		public Par X1Y12_精液;

		public Par X1Y13_精液掛け;

		public Par X1Y13_精液;

		public Par X1Y14_精液;

		public ColorD 精液掛けCD;

		public ColorD 精液CD;

		public ColorP X0Y0_精液CP;

		public ColorP X0Y1_精液CP;

		public ColorP X0Y2_精液CP;

		public ColorP X0Y3_精液CP;

		public ColorP X0Y4_精液CP;

		public ColorP X0Y5_精液CP;

		public ColorP X0Y6_精液CP;

		public ColorP X1Y0_精液CP;

		public ColorP X1Y1_精液CP;

		public ColorP X1Y2_精液CP;

		public ColorP X1Y3_精液CP;

		public ColorP X1Y4_精液CP;

		public ColorP X1Y5_精液CP;

		public ColorP X1Y6_精液CP;

		public ColorP X1Y7_精液CP;

		public ColorP X1Y8_精液掛けCP;

		public ColorP X1Y8_精液CP;

		public ColorP X1Y9_精液掛けCP;

		public ColorP X1Y9_精液CP;

		public ColorP X1Y10_精液掛けCP;

		public ColorP X1Y10_精液CP;

		public ColorP X1Y11_精液掛けCP;

		public ColorP X1Y11_精液CP;

		public ColorP X1Y12_精液掛けCP;

		public ColorP X1Y12_精液CP;

		public ColorP X1Y13_精液掛けCP;

		public ColorP X1Y13_精液CP;

		public ColorP X1Y14_精液CP;
	}
}
