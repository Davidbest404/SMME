using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 上着ボトム_クロス後 : 上着ボトム
	{
		public 上着ボトム_クロス後(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 上着ボトム_クロス後D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["上着ボトム後"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_下地 = pars["下地"].ToPar();
			Pars pars2 = pars["染み"].ToPars();
			this.X0Y0_染み_染み2 = pars2["染み2"].ToPar();
			this.X0Y0_染み_染み1 = pars2["染み1"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_下地 = pars["下地"].ToPar();
			pars2 = pars["染み"].ToPars();
			this.X0Y1_染み_染み2 = pars2["染み2"].ToPar();
			this.X0Y1_染み_染み1 = pars2["染み1"].ToPar();
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
			this.下地_表示 = e.下地_表示;
			this.染み_染み2_表示 = e.染み_染み2_表示;
			this.染み_染み1_表示 = e.染み_染み1_表示;
			this.染み表示 = e.染み表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_下地CP = new ColorP(this.X0Y0_下地, this.下地CD, DisUnit, true);
			this.X0Y0_染み_染み2CP = new ColorP(this.X0Y0_染み_染み2, this.染み_染み2CD, DisUnit, true);
			this.X0Y0_染み_染み1CP = new ColorP(this.X0Y0_染み_染み1, this.染み_染み1CD, DisUnit, true);
			this.X0Y1_下地CP = new ColorP(this.X0Y1_下地, this.下地CD, DisUnit, true);
			this.X0Y1_染み_染み2CP = new ColorP(this.X0Y1_染み_染み2, this.染み_染み2CD, DisUnit, true);
			this.X0Y1_染み_染み1CP = new ColorP(this.X0Y1_染み_染み1, this.染み_染み1CD, DisUnit, true);
			this.染み濃度 = e.染み濃度;
			this.濃度 = e.濃度;
			this.尺度XB = 1.01;
			this.尺度YB = 0.95;
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

		public bool 下地_表示
		{
			get
			{
				return this.X0Y0_下地.Dra;
			}
			set
			{
				this.X0Y0_下地.Dra = value;
				this.X0Y1_下地.Dra = value;
				this.X0Y0_下地.Hit = false;
				this.X0Y1_下地.Hit = false;
			}
		}

		public bool 染み_染み2_表示
		{
			get
			{
				return this.X0Y0_染み_染み2.Dra;
			}
			set
			{
				this.X0Y0_染み_染み2.Dra = value;
				this.X0Y1_染み_染み2.Dra = value;
				this.X0Y0_染み_染み2.Hit = false;
				this.X0Y1_染み_染み2.Hit = false;
			}
		}

		public bool 染み_染み1_表示
		{
			get
			{
				return this.X0Y0_染み_染み1.Dra;
			}
			set
			{
				this.X0Y0_染み_染み1.Dra = value;
				this.X0Y1_染み_染み1.Dra = value;
				this.X0Y0_染み_染み1.Hit = false;
				this.X0Y1_染み_染み1.Hit = false;
			}
		}

		public bool 染み表示
		{
			get
			{
				return this.染み_染み2_表示;
			}
			set
			{
				this.染み_染み2_表示 = value;
				this.染み_染み1_表示 = value;
			}
		}

		public double 染み濃度
		{
			get
			{
				return this.染み_染み2CD.不透明度;
			}
			set
			{
				this.染み_染み2CD.不透明度 = value;
				this.染み_染み1CD.不透明度 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.下地_表示;
			}
			set
			{
				this.下地_表示 = value;
				this.染み_染み2_表示 = value;
				this.染み_染み1_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.下地CD.不透明度;
			}
			set
			{
				this.下地CD.不透明度 = value;
				this.染み_染み2CD.不透明度 = value;
				this.染み_染み1CD.不透明度 = value;
			}
		}

		public override bool Is布(Par p)
		{
			return p == this.X0Y0_下地 || p == this.X0Y0_染み_染み2 || p == this.X0Y0_染み_染み1 || p == this.X0Y1_下地 || p == this.X0Y1_染み_染み2 || p == this.X0Y1_染み_染み1;
		}

		public override void 色更新()
		{
			if (this.本体.IndexY == 0)
			{
				this.X0Y0_下地CP.Update();
				this.X0Y0_染み_染み2CP.Update();
				this.X0Y0_染み_染み1CP.Update();
				return;
			}
			this.X0Y1_下地CP.Update();
			this.X0Y1_染み_染み2CP.Update();
			this.X0Y1_染み_染み1CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.下地CD = new ColorD();
			this.染み_染み2CD = new ColorD(ref Col.Empty, ref 体配色.染み);
			this.染み_染み1CD = new ColorD(ref Col.Empty, ref 体配色.染み);
		}

		public void 配色(クロスB色 配色)
		{
			this.下地CD.色 = 配色.生地1色;
		}

		public Par X0Y0_下地;

		public Par X0Y0_染み_染み2;

		public Par X0Y0_染み_染み1;

		public Par X0Y1_下地;

		public Par X0Y1_染み_染み2;

		public Par X0Y1_染み_染み1;

		public ColorD 下地CD;

		public ColorD 染み_染み2CD;

		public ColorD 染み_染み1CD;

		public ColorP X0Y0_下地CP;

		public ColorP X0Y0_染み_染み2CP;

		public ColorP X0Y0_染み_染み1CP;

		public ColorP X0Y1_下地CP;

		public ColorP X0Y1_染み_染み2CP;

		public ColorP X0Y1_染み_染み1CP;
	}
}
