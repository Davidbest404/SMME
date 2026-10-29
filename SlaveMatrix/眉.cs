using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 眉 : Ele
	{
		public 眉(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 眉D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["眉左"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_眉 = pars["眉"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_眉 = pars["眉"].ToPar();
			this.X0Y1_眉間 = pars["眉間"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_眉 = pars["眉"].ToPar();
			this.X0Y2_眉間 = pars["眉間"].ToPar();
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
			this.眉_表示 = e.眉_表示;
			this.眉間_表示 = e.眉間_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_眉CP = new ColorP(this.X0Y0_眉, this.眉CD, DisUnit, true);
			this.X0Y1_眉CP = new ColorP(this.X0Y1_眉, this.眉CD, DisUnit, true);
			this.X0Y1_眉間CP = new ColorP(this.X0Y1_眉間, this.眉間CD, DisUnit, false);
			this.X0Y2_眉CP = new ColorP(this.X0Y2_眉, this.眉CD, DisUnit, true);
			this.X0Y2_眉間CP = new ColorP(this.X0Y2_眉間, this.眉間CD, DisUnit, false);
			this.濃度 = e.濃度;
			int num = this.右 ? 1 : -1;
			this.X0Y0_眉.BasePointBase = this.X0Y0_眉.BasePointBase.AddX((double)num * 0.0009);
			this.X0Y1_眉.BasePointBase = this.X0Y1_眉.BasePointBase.AddX((double)num * 0.0009);
			this.X0Y2_眉.BasePointBase = this.X0Y2_眉.BasePointBase.AddX((double)num * 0.0009);
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

		public bool 眉_表示
		{
			get
			{
				return this.X0Y0_眉.Dra;
			}
			set
			{
				this.X0Y0_眉.Dra = value;
				this.X0Y1_眉.Dra = value;
				this.X0Y2_眉.Dra = value;
				this.X0Y0_眉.Hit = value;
				this.X0Y1_眉.Hit = value;
				this.X0Y2_眉.Hit = value;
			}
		}

		public bool 眉間_表示
		{
			get
			{
				return this.X0Y1_眉間.Dra;
			}
			set
			{
				this.X0Y1_眉間.Dra = value;
				this.X0Y2_眉間.Dra = value;
				this.X0Y1_眉間.Hit = value;
				this.X0Y2_眉間.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.眉_表示;
			}
			set
			{
				this.眉_表示 = value;
				this.眉間_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.眉CD.不透明度;
			}
			set
			{
				this.眉CD.不透明度 = value;
				this.眉間CD.不透明度 = value;
			}
		}

		public override double サイズY
		{
			get
			{
				return this.サイズY_;
			}
			set
			{
				this.尺度YB = 0.5 + 1.1 * value;
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
			int indexY = this.本体.IndexY;
			if (indexY == 0)
			{
				this.X0Y0_眉CP.Update();
				return;
			}
			if (indexY != 1)
			{
				this.X0Y2_眉CP.Update();
				this.X0Y2_眉間CP.Update();
				return;
			}
			this.X0Y1_眉CP.Update();
			this.X0Y1_眉間CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.眉CD = new ColorD(ref Col.Black, ref 体配色.眉O);
			this.眉間CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
		}

		public Par X0Y0_眉;

		public Par X0Y1_眉;

		public Par X0Y1_眉間;

		public Par X0Y2_眉;

		public Par X0Y2_眉間;

		public ColorD 眉CD;

		public ColorD 眉間CD;

		public ColorP X0Y0_眉CP;

		public ColorP X0Y1_眉CP;

		public ColorP X0Y1_眉間CP;

		public ColorP X0Y2_眉CP;

		public ColorP X0Y2_眉間CP;
	}
}
