using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 噴乳 : Ele
	{
		public 噴乳(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 噴乳D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["噴乳左"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_母乳垂れ1 = pars["母乳垂れ1"].ToPar();
			this.X0Y0_母乳垂れ2 = pars["母乳垂れ2"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_母乳1 = pars["母乳1"].ToPar();
			this.X0Y1_母乳2 = pars["母乳2"].ToPar();
			this.X0Y1_母乳3 = pars["母乳3"].ToPar();
			this.X0Y1_母乳4 = pars["母乳4"].ToPar();
			this.X0Y1_母乳垂れ1 = pars["母乳垂れ1"].ToPar();
			this.X0Y1_母乳垂れ2 = pars["母乳垂れ2"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_母乳1 = pars["母乳1"].ToPar();
			this.X0Y2_母乳2 = pars["母乳2"].ToPar();
			this.X0Y2_母乳3 = pars["母乳3"].ToPar();
			this.X0Y2_母乳4 = pars["母乳4"].ToPar();
			this.X0Y2_母乳垂れ1 = pars["母乳垂れ1"].ToPar();
			this.X0Y2_母乳垂れ2 = pars["母乳垂れ2"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_母乳1 = pars["母乳1"].ToPar();
			this.X0Y3_母乳2 = pars["母乳2"].ToPar();
			this.X0Y3_母乳3 = pars["母乳3"].ToPar();
			this.X0Y3_母乳4 = pars["母乳4"].ToPar();
			this.X0Y3_母乳垂れ1 = pars["母乳垂れ1"].ToPar();
			this.X0Y3_母乳垂れ2 = pars["母乳垂れ2"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_母乳1 = pars["母乳1"].ToPar();
			this.X0Y4_母乳2 = pars["母乳2"].ToPar();
			this.X0Y4_母乳3 = pars["母乳3"].ToPar();
			this.X0Y4_母乳4 = pars["母乳4"].ToPar();
			this.X0Y4_母乳垂れ1 = pars["母乳垂れ1"].ToPar();
			this.X0Y4_母乳垂れ2 = pars["母乳垂れ2"].ToPar();
			pars = this.本体[0][5];
			this.X0Y5_母乳1 = pars["母乳1"].ToPar();
			this.X0Y5_母乳2 = pars["母乳2"].ToPar();
			this.X0Y5_母乳3 = pars["母乳3"].ToPar();
			this.X0Y5_母乳4 = pars["母乳4"].ToPar();
			this.X0Y5_母乳垂れ1 = pars["母乳垂れ1"].ToPar();
			this.X0Y5_母乳垂れ2 = pars["母乳垂れ2"].ToPar();
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
			this.母乳垂れ1_表示 = e.母乳垂れ1_表示;
			this.母乳垂れ2_表示 = e.母乳垂れ2_表示;
			this.母乳1_表示 = e.母乳1_表示;
			this.母乳2_表示 = e.母乳2_表示;
			this.母乳3_表示 = e.母乳3_表示;
			this.母乳4_表示 = e.母乳4_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_母乳垂れ1CP = new ColorP(this.X0Y0_母乳垂れ1, this.母乳垂れ1CD, DisUnit, true);
			this.X0Y0_母乳垂れ2CP = new ColorP(this.X0Y0_母乳垂れ2, this.母乳垂れ2CD, DisUnit, true);
			this.X0Y1_母乳1CP = new ColorP(this.X0Y1_母乳1, this.母乳1CD, DisUnit, true);
			this.X0Y1_母乳2CP = new ColorP(this.X0Y1_母乳2, this.母乳2CD, DisUnit, true);
			this.X0Y1_母乳3CP = new ColorP(this.X0Y1_母乳3, this.母乳3CD, DisUnit, true);
			this.X0Y1_母乳4CP = new ColorP(this.X0Y1_母乳4, this.母乳4CD, DisUnit, true);
			this.X0Y1_母乳垂れ1CP = new ColorP(this.X0Y1_母乳垂れ1, this.母乳垂れ1CD, DisUnit, true);
			this.X0Y1_母乳垂れ2CP = new ColorP(this.X0Y1_母乳垂れ2, this.母乳垂れ2CD, DisUnit, true);
			this.X0Y2_母乳1CP = new ColorP(this.X0Y2_母乳1, this.母乳1CD, DisUnit, true);
			this.X0Y2_母乳2CP = new ColorP(this.X0Y2_母乳2, this.母乳2CD, DisUnit, true);
			this.X0Y2_母乳3CP = new ColorP(this.X0Y2_母乳3, this.母乳3CD, DisUnit, true);
			this.X0Y2_母乳4CP = new ColorP(this.X0Y2_母乳4, this.母乳4CD, DisUnit, true);
			this.X0Y2_母乳垂れ1CP = new ColorP(this.X0Y2_母乳垂れ1, this.母乳垂れ1CD, DisUnit, true);
			this.X0Y2_母乳垂れ2CP = new ColorP(this.X0Y2_母乳垂れ2, this.母乳垂れ2CD, DisUnit, true);
			this.X0Y3_母乳1CP = new ColorP(this.X0Y3_母乳1, this.母乳1CD, DisUnit, true);
			this.X0Y3_母乳2CP = new ColorP(this.X0Y3_母乳2, this.母乳2CD, DisUnit, true);
			this.X0Y3_母乳3CP = new ColorP(this.X0Y3_母乳3, this.母乳3CD, DisUnit, true);
			this.X0Y3_母乳4CP = new ColorP(this.X0Y3_母乳4, this.母乳4CD, DisUnit, true);
			this.X0Y3_母乳垂れ1CP = new ColorP(this.X0Y3_母乳垂れ1, this.母乳垂れ1CD, DisUnit, true);
			this.X0Y3_母乳垂れ2CP = new ColorP(this.X0Y3_母乳垂れ2, this.母乳垂れ2CD, DisUnit, true);
			this.X0Y4_母乳1CP = new ColorP(this.X0Y4_母乳1, this.母乳1CD, DisUnit, true);
			this.X0Y4_母乳2CP = new ColorP(this.X0Y4_母乳2, this.母乳2CD, DisUnit, true);
			this.X0Y4_母乳3CP = new ColorP(this.X0Y4_母乳3, this.母乳3CD, DisUnit, true);
			this.X0Y4_母乳4CP = new ColorP(this.X0Y4_母乳4, this.母乳4CD, DisUnit, true);
			this.X0Y4_母乳垂れ1CP = new ColorP(this.X0Y4_母乳垂れ1, this.母乳垂れ1CD, DisUnit, true);
			this.X0Y4_母乳垂れ2CP = new ColorP(this.X0Y4_母乳垂れ2, this.母乳垂れ2CD, DisUnit, true);
			this.X0Y5_母乳1CP = new ColorP(this.X0Y5_母乳1, this.母乳1CD, DisUnit, true);
			this.X0Y5_母乳2CP = new ColorP(this.X0Y5_母乳2, this.母乳2CD, DisUnit, true);
			this.X0Y5_母乳3CP = new ColorP(this.X0Y5_母乳3, this.母乳3CD, DisUnit, true);
			this.X0Y5_母乳4CP = new ColorP(this.X0Y5_母乳4, this.母乳4CD, DisUnit, true);
			this.X0Y5_母乳垂れ1CP = new ColorP(this.X0Y5_母乳垂れ1, this.母乳垂れ1CD, DisUnit, true);
			this.X0Y5_母乳垂れ2CP = new ColorP(this.X0Y5_母乳垂れ2, this.母乳垂れ2CD, DisUnit, true);
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

		public bool 母乳垂れ1_表示
		{
			get
			{
				return this.X0Y0_母乳垂れ1.Dra;
			}
			set
			{
				this.X0Y0_母乳垂れ1.Dra = value;
				this.X0Y1_母乳垂れ1.Dra = value;
				this.X0Y2_母乳垂れ1.Dra = value;
				this.X0Y3_母乳垂れ1.Dra = value;
				this.X0Y4_母乳垂れ1.Dra = value;
				this.X0Y5_母乳垂れ1.Dra = value;
				this.X0Y0_母乳垂れ1.Hit = value;
				this.X0Y1_母乳垂れ1.Hit = value;
				this.X0Y2_母乳垂れ1.Hit = value;
				this.X0Y3_母乳垂れ1.Hit = value;
				this.X0Y4_母乳垂れ1.Hit = value;
				this.X0Y5_母乳垂れ1.Hit = value;
			}
		}

		public bool 母乳垂れ2_表示
		{
			get
			{
				return this.X0Y0_母乳垂れ2.Dra;
			}
			set
			{
				this.X0Y0_母乳垂れ2.Dra = value;
				this.X0Y1_母乳垂れ2.Dra = value;
				this.X0Y2_母乳垂れ2.Dra = value;
				this.X0Y3_母乳垂れ2.Dra = value;
				this.X0Y4_母乳垂れ2.Dra = value;
				this.X0Y5_母乳垂れ2.Dra = value;
				this.X0Y0_母乳垂れ2.Hit = value;
				this.X0Y1_母乳垂れ2.Hit = value;
				this.X0Y2_母乳垂れ2.Hit = value;
				this.X0Y3_母乳垂れ2.Hit = value;
				this.X0Y4_母乳垂れ2.Hit = value;
				this.X0Y5_母乳垂れ2.Hit = value;
			}
		}

		public bool 母乳1_表示
		{
			get
			{
				return this.X0Y1_母乳1.Dra;
			}
			set
			{
				this.X0Y1_母乳1.Dra = value;
				this.X0Y2_母乳1.Dra = value;
				this.X0Y3_母乳1.Dra = value;
				this.X0Y4_母乳1.Dra = value;
				this.X0Y5_母乳1.Dra = value;
				this.X0Y1_母乳1.Hit = value;
				this.X0Y2_母乳1.Hit = value;
				this.X0Y3_母乳1.Hit = value;
				this.X0Y4_母乳1.Hit = value;
				this.X0Y5_母乳1.Hit = value;
			}
		}

		public bool 母乳2_表示
		{
			get
			{
				return this.X0Y1_母乳2.Dra;
			}
			set
			{
				this.X0Y1_母乳2.Dra = value;
				this.X0Y2_母乳2.Dra = value;
				this.X0Y3_母乳2.Dra = value;
				this.X0Y4_母乳2.Dra = value;
				this.X0Y5_母乳2.Dra = value;
				this.X0Y1_母乳2.Hit = value;
				this.X0Y2_母乳2.Hit = value;
				this.X0Y3_母乳2.Hit = value;
				this.X0Y4_母乳2.Hit = value;
				this.X0Y5_母乳2.Hit = value;
			}
		}

		public bool 母乳3_表示
		{
			get
			{
				return this.X0Y1_母乳3.Dra;
			}
			set
			{
				this.X0Y1_母乳3.Dra = value;
				this.X0Y2_母乳3.Dra = value;
				this.X0Y3_母乳3.Dra = value;
				this.X0Y4_母乳3.Dra = value;
				this.X0Y5_母乳3.Dra = value;
				this.X0Y1_母乳3.Hit = value;
				this.X0Y2_母乳3.Hit = value;
				this.X0Y3_母乳3.Hit = value;
				this.X0Y4_母乳3.Hit = value;
				this.X0Y5_母乳3.Hit = value;
			}
		}

		public bool 母乳4_表示
		{
			get
			{
				return this.X0Y1_母乳4.Dra;
			}
			set
			{
				this.X0Y1_母乳4.Dra = value;
				this.X0Y2_母乳4.Dra = value;
				this.X0Y3_母乳4.Dra = value;
				this.X0Y4_母乳4.Dra = value;
				this.X0Y5_母乳4.Dra = value;
				this.X0Y1_母乳4.Hit = value;
				this.X0Y2_母乳4.Hit = value;
				this.X0Y3_母乳4.Hit = value;
				this.X0Y4_母乳4.Hit = value;
				this.X0Y5_母乳4.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.母乳垂れ1_表示;
			}
			set
			{
				this.母乳垂れ1_表示 = value;
				this.母乳垂れ2_表示 = value;
				this.母乳1_表示 = value;
				this.母乳2_表示 = value;
				this.母乳3_表示 = value;
				this.母乳4_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.母乳1CD.不透明度;
			}
			set
			{
				this.母乳1CD.不透明度 = value;
				this.母乳2CD.不透明度 = value;
				this.母乳3CD.不透明度 = value;
				this.母乳4CD.不透明度 = value;
				this.母乳垂れ1CD.不透明度 = value;
				this.母乳垂れ2CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_母乳垂れ1CP.Update();
				this.X0Y0_母乳垂れ2CP.Update();
				return;
			case 1:
				this.X0Y1_母乳1CP.Update();
				this.X0Y1_母乳2CP.Update();
				this.X0Y1_母乳3CP.Update();
				this.X0Y1_母乳4CP.Update();
				this.X0Y1_母乳垂れ1CP.Update();
				this.X0Y1_母乳垂れ2CP.Update();
				return;
			case 2:
				this.X0Y2_母乳1CP.Update();
				this.X0Y2_母乳2CP.Update();
				this.X0Y2_母乳3CP.Update();
				this.X0Y2_母乳4CP.Update();
				this.X0Y2_母乳垂れ1CP.Update();
				this.X0Y2_母乳垂れ2CP.Update();
				return;
			case 3:
				this.X0Y3_母乳1CP.Update();
				this.X0Y3_母乳2CP.Update();
				this.X0Y3_母乳3CP.Update();
				this.X0Y3_母乳4CP.Update();
				this.X0Y3_母乳垂れ1CP.Update();
				this.X0Y3_母乳垂れ2CP.Update();
				return;
			case 4:
				this.X0Y4_母乳1CP.Update();
				this.X0Y4_母乳2CP.Update();
				this.X0Y4_母乳3CP.Update();
				this.X0Y4_母乳4CP.Update();
				this.X0Y4_母乳垂れ1CP.Update();
				this.X0Y4_母乳垂れ2CP.Update();
				return;
			default:
				this.X0Y5_母乳1CP.Update();
				this.X0Y5_母乳2CP.Update();
				this.X0Y5_母乳3CP.Update();
				this.X0Y5_母乳4CP.Update();
				this.X0Y5_母乳垂れ1CP.Update();
				this.X0Y5_母乳垂れ2CP.Update();
				return;
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.母乳1CD = new ColorD(ref 体配色.母乳線, ref 体配色.母乳);
			this.母乳2CD = new ColorD(ref 体配色.母乳線, ref 体配色.母乳);
			this.母乳3CD = new ColorD(ref 体配色.母乳線, ref 体配色.母乳);
			this.母乳4CD = new ColorD(ref 体配色.母乳線, ref 体配色.母乳);
			this.母乳垂れ1CD = new ColorD(ref 体配色.母乳線, ref 体配色.母乳);
			this.母乳垂れ2CD = new ColorD(ref 体配色.母乳線, ref 体配色.母乳);
		}

		public Par X0Y0_母乳垂れ1;

		public Par X0Y0_母乳垂れ2;

		public Par X0Y1_母乳1;

		public Par X0Y1_母乳2;

		public Par X0Y1_母乳3;

		public Par X0Y1_母乳4;

		public Par X0Y1_母乳垂れ1;

		public Par X0Y1_母乳垂れ2;

		public Par X0Y2_母乳1;

		public Par X0Y2_母乳2;

		public Par X0Y2_母乳3;

		public Par X0Y2_母乳4;

		public Par X0Y2_母乳垂れ1;

		public Par X0Y2_母乳垂れ2;

		public Par X0Y3_母乳1;

		public Par X0Y3_母乳2;

		public Par X0Y3_母乳3;

		public Par X0Y3_母乳4;

		public Par X0Y3_母乳垂れ1;

		public Par X0Y3_母乳垂れ2;

		public Par X0Y4_母乳1;

		public Par X0Y4_母乳2;

		public Par X0Y4_母乳3;

		public Par X0Y4_母乳4;

		public Par X0Y4_母乳垂れ1;

		public Par X0Y4_母乳垂れ2;

		public Par X0Y5_母乳1;

		public Par X0Y5_母乳2;

		public Par X0Y5_母乳3;

		public Par X0Y5_母乳4;

		public Par X0Y5_母乳垂れ1;

		public Par X0Y5_母乳垂れ2;

		public ColorD 母乳1CD;

		public ColorD 母乳2CD;

		public ColorD 母乳3CD;

		public ColorD 母乳4CD;

		public ColorD 母乳垂れ1CD;

		public ColorD 母乳垂れ2CD;

		public ColorP X0Y0_母乳垂れ1CP;

		public ColorP X0Y0_母乳垂れ2CP;

		public ColorP X0Y1_母乳1CP;

		public ColorP X0Y1_母乳2CP;

		public ColorP X0Y1_母乳3CP;

		public ColorP X0Y1_母乳4CP;

		public ColorP X0Y1_母乳垂れ1CP;

		public ColorP X0Y1_母乳垂れ2CP;

		public ColorP X0Y2_母乳1CP;

		public ColorP X0Y2_母乳2CP;

		public ColorP X0Y2_母乳3CP;

		public ColorP X0Y2_母乳4CP;

		public ColorP X0Y2_母乳垂れ1CP;

		public ColorP X0Y2_母乳垂れ2CP;

		public ColorP X0Y3_母乳1CP;

		public ColorP X0Y3_母乳2CP;

		public ColorP X0Y3_母乳3CP;

		public ColorP X0Y3_母乳4CP;

		public ColorP X0Y3_母乳垂れ1CP;

		public ColorP X0Y3_母乳垂れ2CP;

		public ColorP X0Y4_母乳1CP;

		public ColorP X0Y4_母乳2CP;

		public ColorP X0Y4_母乳3CP;

		public ColorP X0Y4_母乳4CP;

		public ColorP X0Y4_母乳垂れ1CP;

		public ColorP X0Y4_母乳垂れ2CP;

		public ColorP X0Y5_母乳1CP;

		public ColorP X0Y5_母乳2CP;

		public ColorP X0Y5_母乳3CP;

		public ColorP X0Y5_母乳4CP;

		public ColorP X0Y5_母乳垂れ1CP;

		public ColorP X0Y5_母乳垂れ2CP;
	}
}
