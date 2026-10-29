using System;
using System.Drawing;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 紅潮 : Ele
	{
		public 紅潮(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 紅潮D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["紅潮"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_紅潮0 = pars["紅潮0"].ToPar();
			this.X0Y0_紅潮1 = pars["紅潮1"].ToPar();
			this.X0Y0_紅潮右 = pars["紅潮右"].ToPar();
			this.X0Y0_紅潮左 = pars["紅潮左"].ToPar();
			this.X0Y0_紅潮線左 = pars["紅潮線左"].ToPar();
			this.X0Y0_紅潮線右 = pars["紅潮線右"].ToPar();
			this.X0Y0_紅潮弱左 = pars["紅潮弱左"].ToPar();
			this.X0Y0_紅潮弱右 = pars["紅潮弱右"].ToPar();
			this.X0Y0_紅潮線弱左 = pars["紅潮線弱左"].ToPar();
			this.X0Y0_紅潮線弱右 = pars["紅潮線弱右"].ToPar();
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
			this.紅潮0_表示 = e.紅潮0_表示;
			this.紅潮1_表示 = e.紅潮1_表示;
			this.紅潮右_表示 = e.紅潮右_表示;
			this.紅潮左_表示 = e.紅潮左_表示;
			this.紅潮線左_表示 = e.紅潮線左_表示;
			this.紅潮線右_表示 = e.紅潮線右_表示;
			this.紅潮弱左_表示 = e.紅潮弱左_表示;
			this.紅潮弱右_表示 = e.紅潮弱右_表示;
			this.紅潮線弱左_表示 = e.紅潮線弱左_表示;
			this.紅潮線弱右_表示 = e.紅潮線弱右_表示;
			this.紅潮表示 = e.紅潮表示;
			this.紅潮左右表示 = e.紅潮左右表示;
			this.紅潮線左右表示 = e.紅潮線左右表示;
			this.紅潮弱左右表示 = e.紅潮弱左右表示;
			this.紅潮線弱左右表示 = e.紅潮線弱左右表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_紅潮0CP = new ColorP(this.X0Y0_紅潮0, this.紅潮0CD, DisUnit, true);
			this.X0Y0_紅潮1CP = new ColorP(this.X0Y0_紅潮1, this.紅潮1CD, DisUnit, true);
			this.X0Y0_紅潮右CP = new ColorP(this.X0Y0_紅潮右, this.紅潮右CD, DisUnit, true);
			this.X0Y0_紅潮左CP = new ColorP(this.X0Y0_紅潮左, this.紅潮左CD, DisUnit, true);
			this.X0Y0_紅潮線左CP = new ColorP(this.X0Y0_紅潮線左, this.紅潮線左CD, DisUnit, true);
			this.X0Y0_紅潮線右CP = new ColorP(this.X0Y0_紅潮線右, this.紅潮線右CD, DisUnit, true);
			this.X0Y0_紅潮弱左CP = new ColorP(this.X0Y0_紅潮弱左, this.紅潮弱左CD, DisUnit, true);
			this.X0Y0_紅潮弱右CP = new ColorP(this.X0Y0_紅潮弱右, this.紅潮弱右CD, DisUnit, true);
			this.X0Y0_紅潮線弱左CP = new ColorP(this.X0Y0_紅潮線弱左, this.紅潮線弱左CD, DisUnit, true);
			this.X0Y0_紅潮線弱右CP = new ColorP(this.X0Y0_紅潮線弱右, this.紅潮線弱右CD, DisUnit, true);
			this.紅潮濃度 = e.紅潮濃度;
			this.紅潮左右濃度 = e.紅潮左右濃度;
			this.紅潮線左右濃度 = e.紅潮線左右濃度;
			this.紅潮弱左右濃度 = e.紅潮弱左右濃度;
			this.紅潮線弱左右濃度 = e.紅潮線弱左右濃度;
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

		public bool 紅潮0_表示
		{
			get
			{
				return this.X0Y0_紅潮0.Dra;
			}
			set
			{
				this.X0Y0_紅潮0.Dra = value;
				this.X0Y0_紅潮0.Hit = value;
			}
		}

		public bool 紅潮1_表示
		{
			get
			{
				return this.X0Y0_紅潮1.Dra;
			}
			set
			{
				this.X0Y0_紅潮1.Dra = value;
				this.X0Y0_紅潮1.Hit = value;
			}
		}

		public bool 紅潮右_表示
		{
			get
			{
				return this.X0Y0_紅潮右.Dra;
			}
			set
			{
				this.X0Y0_紅潮右.Dra = value;
				this.X0Y0_紅潮右.Hit = value;
			}
		}

		public bool 紅潮左_表示
		{
			get
			{
				return this.X0Y0_紅潮左.Dra;
			}
			set
			{
				this.X0Y0_紅潮左.Dra = value;
				this.X0Y0_紅潮左.Hit = value;
			}
		}

		public bool 紅潮線左_表示
		{
			get
			{
				return this.X0Y0_紅潮線左.Dra;
			}
			set
			{
				this.X0Y0_紅潮線左.Dra = value;
				this.X0Y0_紅潮線左.Hit = value;
			}
		}

		public bool 紅潮線右_表示
		{
			get
			{
				return this.X0Y0_紅潮線右.Dra;
			}
			set
			{
				this.X0Y0_紅潮線右.Dra = value;
				this.X0Y0_紅潮線右.Hit = value;
			}
		}

		public bool 紅潮弱左_表示
		{
			get
			{
				return this.X0Y0_紅潮弱左.Dra;
			}
			set
			{
				this.X0Y0_紅潮弱左.Dra = value;
				this.X0Y0_紅潮弱左.Hit = value;
			}
		}

		public bool 紅潮弱右_表示
		{
			get
			{
				return this.X0Y0_紅潮弱右.Dra;
			}
			set
			{
				this.X0Y0_紅潮弱右.Dra = value;
				this.X0Y0_紅潮弱右.Hit = value;
			}
		}

		public bool 紅潮線弱左_表示
		{
			get
			{
				return this.X0Y0_紅潮線弱左.Dra;
			}
			set
			{
				this.X0Y0_紅潮線弱左.Dra = value;
				this.X0Y0_紅潮線弱左.Hit = value;
			}
		}

		public bool 紅潮線弱右_表示
		{
			get
			{
				return this.X0Y0_紅潮線弱右.Dra;
			}
			set
			{
				this.X0Y0_紅潮線弱右.Dra = value;
				this.X0Y0_紅潮線弱右.Hit = value;
			}
		}

		public bool 紅潮表示
		{
			get
			{
				return this.紅潮0_表示;
			}
			set
			{
				this.紅潮0_表示 = value;
				this.紅潮1_表示 = value;
			}
		}

		public bool 紅潮左右表示
		{
			get
			{
				return this.紅潮右_表示;
			}
			set
			{
				this.紅潮右_表示 = value;
				this.紅潮左_表示 = value;
			}
		}

		public bool 紅潮線左右表示
		{
			get
			{
				return this.紅潮線左_表示;
			}
			set
			{
				this.紅潮線左_表示 = value;
				this.紅潮線右_表示 = value;
			}
		}

		public bool 紅潮弱左右表示
		{
			get
			{
				return this.紅潮弱左_表示;
			}
			set
			{
				this.紅潮弱左_表示 = value;
				this.紅潮弱右_表示 = value;
			}
		}

		public bool 紅潮線弱左右表示
		{
			get
			{
				return this.紅潮線弱左_表示;
			}
			set
			{
				this.紅潮線弱左_表示 = value;
				this.紅潮線弱右_表示 = value;
			}
		}

		public double 紅潮濃度
		{
			get
			{
				return this.紅潮0CD.不透明度;
			}
			set
			{
				this.紅潮0CD.不透明度 = value;
				this.紅潮1CD.不透明度 = value;
			}
		}

		public double 紅潮左右濃度
		{
			get
			{
				return this.紅潮右CD.不透明度;
			}
			set
			{
				this.紅潮右CD.不透明度 = value;
				this.紅潮左CD.不透明度 = value;
			}
		}

		public double 紅潮線左右濃度
		{
			get
			{
				return this.紅潮線左CD.不透明度;
			}
			set
			{
				this.紅潮線左CD.不透明度 = value;
				this.紅潮線右CD.不透明度 = value;
			}
		}

		public double 紅潮弱左右濃度
		{
			get
			{
				return this.紅潮弱左CD.不透明度;
			}
			set
			{
				this.紅潮弱左CD.不透明度 = value;
				this.紅潮弱右CD.不透明度 = value;
			}
		}

		public double 紅潮線弱左右濃度
		{
			get
			{
				return this.紅潮線弱左CD.不透明度;
			}
			set
			{
				this.紅潮線弱左CD.不透明度 = value;
				this.紅潮線弱右CD.不透明度 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.紅潮0_表示;
			}
			set
			{
				this.紅潮0_表示 = value;
				this.紅潮1_表示 = value;
				this.紅潮右_表示 = value;
				this.紅潮左_表示 = value;
				this.紅潮線左_表示 = value;
				this.紅潮線右_表示 = value;
				this.紅潮弱左_表示 = value;
				this.紅潮弱右_表示 = value;
				this.紅潮線弱左_表示 = value;
				this.紅潮線弱右_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.紅潮0CD.不透明度;
			}
			set
			{
				this.紅潮0CD.不透明度 = value;
				this.紅潮1CD.不透明度 = value;
				this.紅潮右CD.不透明度 = value;
				this.紅潮左CD.不透明度 = value;
				this.紅潮線左CD.不透明度 = value;
				this.紅潮線右CD.不透明度 = value;
				this.紅潮弱左CD.不透明度 = value;
				this.紅潮弱右CD.不透明度 = value;
				this.紅潮線弱左CD.不透明度 = value;
				this.紅潮線弱右CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			this.X0Y0_紅潮0CP.Update();
			this.X0Y0_紅潮1CP.Update();
			this.X0Y0_紅潮右CP.Update();
			this.X0Y0_紅潮左CP.Update();
			this.X0Y0_紅潮線左CP.Update();
			this.X0Y0_紅潮線右CP.Update();
			this.X0Y0_紅潮弱左CP.Update();
			this.X0Y0_紅潮弱右CP.Update();
			this.X0Y0_紅潮線弱左CP.Update();
			this.X0Y0_紅潮線弱右CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			Color color = Color.FromArgb((int)((double)体配色.紅潮.Col1.A * 0.7), 体配色.紅潮.Col1);
			this.紅潮0CD = new ColorD();
			this.紅潮0CD.線 = Col.Empty;
			this.紅潮0CD.色 = new Color2(ref color, ref Col.Empty);
			this.紅潮1CD = new ColorD(ref Col.Empty, ref 体配色.紅潮);
			this.紅潮右CD = new ColorD(ref Col.Empty, ref 体配色.紅潮);
			this.紅潮左CD = new ColorD(ref Col.Empty, ref 体配色.紅潮);
			this.紅潮線左CD = new ColorD(ref 体配色.紅潮線, ref 体配色.紅潮);
			this.紅潮線右CD = new ColorD(ref 体配色.紅潮線, ref 体配色.紅潮);
			this.紅潮弱左CD = new ColorD(ref Col.Empty, ref 体配色.紅潮);
			this.紅潮弱右CD = new ColorD(ref Col.Empty, ref 体配色.紅潮);
			this.紅潮線弱左CD = new ColorD(ref 体配色.紅潮線, ref 体配色.紅潮);
			this.紅潮線弱右CD = new ColorD(ref 体配色.紅潮線, ref 体配色.紅潮);
		}

		public Par X0Y0_紅潮0;

		public Par X0Y0_紅潮1;

		public Par X0Y0_紅潮右;

		public Par X0Y0_紅潮左;

		public Par X0Y0_紅潮線左;

		public Par X0Y0_紅潮線右;

		public Par X0Y0_紅潮弱左;

		public Par X0Y0_紅潮弱右;

		public Par X0Y0_紅潮線弱左;

		public Par X0Y0_紅潮線弱右;

		public ColorD 紅潮0CD;

		public ColorD 紅潮1CD;

		public ColorD 紅潮右CD;

		public ColorD 紅潮左CD;

		public ColorD 紅潮線左CD;

		public ColorD 紅潮線右CD;

		public ColorD 紅潮弱左CD;

		public ColorD 紅潮弱右CD;

		public ColorD 紅潮線弱左CD;

		public ColorD 紅潮線弱右CD;

		public ColorP X0Y0_紅潮0CP;

		public ColorP X0Y0_紅潮1CP;

		public ColorP X0Y0_紅潮右CP;

		public ColorP X0Y0_紅潮左CP;

		public ColorP X0Y0_紅潮線左CP;

		public ColorP X0Y0_紅潮線右CP;

		public ColorP X0Y0_紅潮弱左CP;

		public ColorP X0Y0_紅潮弱右CP;

		public ColorP X0Y0_紅潮線弱左CP;

		public ColorP X0Y0_紅潮線弱右CP;
	}
}
