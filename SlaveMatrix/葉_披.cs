using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 葉_披 : 葉
	{
		public 葉_披(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 葉_披D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.肢左["葉"][0]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_通常_葉 = pars["葉"].ToPar();
			this.X0Y0_通常_葉脈 = pars["葉脈"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_欠損1_葉 = pars["葉"].ToPar();
			this.X0Y1_欠損1_葉脈 = pars["葉脈"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_欠損2_葉 = pars["葉"].ToPar();
			this.X0Y2_欠損2_葉脈 = pars["葉脈"].ToPar();
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
			this.欠損i = e.欠損i;
			this.葉_表示 = e.葉_表示;
			this.葉脈_表示 = e.葉脈_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_通常_葉CP = new ColorP(this.X0Y0_通常_葉, this.葉CD, DisUnit, true);
			this.X0Y0_通常_葉脈CP = new ColorP(this.X0Y0_通常_葉脈, this.葉脈CD, DisUnit, true);
			this.X0Y1_欠損1_葉CP = new ColorP(this.X0Y1_欠損1_葉, this.葉CD, DisUnit, true);
			this.X0Y1_欠損1_葉脈CP = new ColorP(this.X0Y1_欠損1_葉脈, this.葉脈CD, DisUnit, true);
			this.X0Y2_欠損2_葉CP = new ColorP(this.X0Y2_欠損2_葉, this.葉CD, DisUnit, true);
			this.X0Y2_欠損2_葉脈CP = new ColorP(this.X0Y2_欠損2_葉脈, this.葉脈CD, DisUnit, true);
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
				this.本体.IndexY = (this.欠損_ ? OthN.XS.NextM(1, 2) : 0);
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

		public int 欠損i
		{
			get
			{
				return this.本体.IndexY;
			}
			set
			{
				this.本体.IndexY = value;
				this.欠損_ = (this.本体.IndexY > 0);
			}
		}

		public bool 葉_表示
		{
			get
			{
				return this.X0Y0_通常_葉.Dra;
			}
			set
			{
				this.X0Y0_通常_葉.Dra = value;
				this.X0Y1_欠損1_葉.Dra = value;
				this.X0Y2_欠損2_葉.Dra = value;
				this.X0Y0_通常_葉.Hit = value;
				this.X0Y1_欠損1_葉.Hit = value;
				this.X0Y2_欠損2_葉.Hit = value;
			}
		}

		public bool 葉脈_表示
		{
			get
			{
				return this.X0Y0_通常_葉脈.Dra;
			}
			set
			{
				this.X0Y0_通常_葉脈.Dra = value;
				this.X0Y1_欠損1_葉脈.Dra = value;
				this.X0Y2_欠損2_葉脈.Dra = value;
				this.X0Y0_通常_葉脈.Hit = value;
				this.X0Y1_欠損1_葉脈.Hit = value;
				this.X0Y2_欠損2_葉脈.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.葉_表示;
			}
			set
			{
				this.葉_表示 = value;
				this.葉脈_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.葉CD.不透明度;
			}
			set
			{
				this.葉CD.不透明度 = value;
				this.葉脈CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			if (this.本体.IndexY == 0)
			{
				this.X0Y0_通常_葉CP.Update();
				this.X0Y0_通常_葉脈CP.Update();
				return;
			}
			if (this.本体.IndexY == 1)
			{
				this.X0Y1_欠損1_葉CP.Update();
				this.X0Y1_欠損1_葉脈CP.Update();
				return;
			}
			this.X0Y2_欠損2_葉CP.Update();
			this.X0Y2_欠損2_葉脈CP.Update();
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
			this.葉CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.葉脈CD = new ColorD(ref Col.Black, ref 体配色.植0O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.葉CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.葉脈CD = new ColorD(ref Col.Black, ref 体配色.植0O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.葉CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.葉脈CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
		}

		public Par X0Y0_通常_葉;

		public Par X0Y0_通常_葉脈;

		public Par X0Y1_欠損1_葉;

		public Par X0Y1_欠損1_葉脈;

		public Par X0Y2_欠損2_葉;

		public Par X0Y2_欠損2_葉脈;

		public ColorD 葉CD;

		public ColorD 葉脈CD;

		public ColorP X0Y0_通常_葉CP;

		public ColorP X0Y0_通常_葉脈CP;

		public ColorP X0Y1_欠損1_葉CP;

		public ColorP X0Y1_欠損1_葉脈CP;

		public ColorP X0Y2_欠損2_葉CP;

		public ColorP X0Y2_欠損2_葉脈CP;
	}
}
