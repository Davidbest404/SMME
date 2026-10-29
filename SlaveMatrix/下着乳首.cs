using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 下着乳首 : Ele
	{
		public 下着乳首(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 下着乳首D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["下着乳首左"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_乳首 = pars["乳首"].ToPar();
			this.X0Y0_染み2 = pars["染み2"].ToPar();
			this.X0Y0_染み1 = pars["染み1"].ToPar();
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
			this.sb = this.尺度B;
			this.肥大 = e.肥大;
			this.身長 = e.身長;
			this.Xv = e.Xv;
			this.Yv = e.Yv;
			this.Xi = e.Xi;
			this.Yi = e.Yi;
			this.サイズ = e.サイズ;
			this.サイズX = e.サイズX;
			this.サイズY = e.サイズY;
			this.乳首_表示 = e.乳首_表示;
			this.染み2_表示 = e.染み2_表示;
			this.染み1_表示 = e.染み1_表示;
			this.染み表示 = e.染み表示;
			this.バスト = e.バスト;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_乳首CP = new ColorP(this.X0Y0_乳首, this.乳首CD, DisUnit, true);
			this.X0Y0_染み2CP = new ColorP(this.X0Y0_染み2, this.染み2CD, DisUnit, true);
			this.X0Y0_染み1CP = new ColorP(this.X0Y0_染み1, this.染み1CD, DisUnit, true);
			this.染み濃度 = e.染み濃度;
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

		public bool 乳首_表示
		{
			get
			{
				return this.X0Y0_乳首.Dra;
			}
			set
			{
				this.X0Y0_乳首.Dra = value;
				this.X0Y0_乳首.Hit = false;
			}
		}

		public bool 染み2_表示
		{
			get
			{
				return this.X0Y0_染み2.Dra;
			}
			set
			{
				this.X0Y0_染み2.Dra = value;
				this.X0Y0_染み2.Hit = false;
			}
		}

		public bool 染み1_表示
		{
			get
			{
				return this.X0Y0_染み1.Dra;
			}
			set
			{
				this.X0Y0_染み1.Dra = value;
				this.X0Y0_染み1.Hit = false;
			}
		}

		public bool 染み表示
		{
			get
			{
				return this.染み2_表示;
			}
			set
			{
				this.染み2_表示 = value;
				this.染み1_表示 = value;
			}
		}

		public double 染み濃度
		{
			get
			{
				return this.染み2CD.不透明度;
			}
			set
			{
				this.染み2CD.不透明度 = value;
				this.染み1CD.不透明度 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.乳首_表示;
			}
			set
			{
				this.乳首_表示 = value;
				this.染み2_表示 = value;
				this.染み1_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.乳首CD.不透明度;
			}
			set
			{
				this.乳首CD.不透明度 = value;
				this.染み2CD.不透明度 = value;
				this.染み1CD.不透明度 = value;
			}
		}

		public double バスト
		{
			set
			{
				this.尺度B_ = this.sb * (0.9 + 0.25 * value);
			}
		}

		public virtual double 尺度B_
		{
			get
			{
				return this.本体.CurJoinRoot.SizeBase;
			}
			set
			{
				foreach (Par par in this.本体.EnumAllPar())
				{
					par.SizeBase = value;
				}
				this.本体.JoinP();
			}
		}

		public override void 色更新()
		{
			this.X0Y0_乳首CP.Update();
			this.X0Y0_染み2CP.Update();
			this.X0Y0_染み1CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.乳首CD = new ColorD();
			this.染み2CD = new ColorD(ref Col.Empty, ref 体配色.染み);
			this.染み1CD = new ColorD(ref Col.Empty, ref 体配色.染み);
		}

		public void 配色(Color2 配色)
		{
			this.乳首CD.線 = Col.Black;
			this.乳首CD.色 = 配色;
			this.X0Y0_乳首CP.Setting();
		}

		public Par X0Y0_乳首;

		public Par X0Y0_染み2;

		public Par X0Y0_染み1;

		public ColorD 乳首CD;

		public ColorD 染み2CD;

		public ColorD 染み1CD;

		public ColorP X0Y0_乳首CP;

		public ColorP X0Y0_染み2CP;

		public ColorP X0Y0_染み1CP;

		private double sb;
	}
}
