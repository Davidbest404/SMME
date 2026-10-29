using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 羽根箒 : Ele
	{
		public 羽根箒(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 羽根箒D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.カ\u30FCソル["羽根箒"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_羽根1 = pars["羽根1"].ToPar();
			this.X0Y0_羽根2 = pars["羽根2"].ToPar();
			this.X0Y0_羽根3 = pars["羽根3"].ToPar();
			this.X0Y0_羽根4 = pars["羽根4"].ToPar();
			this.X0Y0_羽根5 = pars["羽根5"].ToPar();
			this.X0Y0_羽根 = pars["羽根"].ToPar();
			this.X0Y0_柄 = pars["柄"].ToPar();
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
			this.羽根1_表示 = e.羽根1_表示;
			this.羽根2_表示 = e.羽根2_表示;
			this.羽根3_表示 = e.羽根3_表示;
			this.羽根4_表示 = e.羽根4_表示;
			this.羽根5_表示 = e.羽根5_表示;
			this.羽根_表示 = e.羽根_表示;
			this.柄_表示 = e.柄_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_羽根1CP = new ColorP(this.X0Y0_羽根1, this.羽根1CD, DisUnit, true);
			this.X0Y0_羽根2CP = new ColorP(this.X0Y0_羽根2, this.羽根2CD, DisUnit, true);
			this.X0Y0_羽根3CP = new ColorP(this.X0Y0_羽根3, this.羽根3CD, DisUnit, true);
			this.X0Y0_羽根4CP = new ColorP(this.X0Y0_羽根4, this.羽根4CD, DisUnit, true);
			this.X0Y0_羽根5CP = new ColorP(this.X0Y0_羽根5, this.羽根5CD, DisUnit, true);
			this.X0Y0_羽根CP = new ColorP(this.X0Y0_羽根, this.羽根CD, DisUnit, true);
			this.X0Y0_柄CP = new ColorP(this.X0Y0_柄, this.柄CD, DisUnit, true);
			this.濃度 = e.濃度;
			this.本体.JoinPAall();
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

		public bool 羽根1_表示
		{
			get
			{
				return this.X0Y0_羽根1.Dra;
			}
			set
			{
				this.X0Y0_羽根1.Dra = value;
				this.X0Y0_羽根1.Hit = value;
			}
		}

		public bool 羽根2_表示
		{
			get
			{
				return this.X0Y0_羽根2.Dra;
			}
			set
			{
				this.X0Y0_羽根2.Dra = value;
				this.X0Y0_羽根2.Hit = value;
			}
		}

		public bool 羽根3_表示
		{
			get
			{
				return this.X0Y0_羽根3.Dra;
			}
			set
			{
				this.X0Y0_羽根3.Dra = value;
				this.X0Y0_羽根3.Hit = value;
			}
		}

		public bool 羽根4_表示
		{
			get
			{
				return this.X0Y0_羽根4.Dra;
			}
			set
			{
				this.X0Y0_羽根4.Dra = value;
				this.X0Y0_羽根4.Hit = value;
			}
		}

		public bool 羽根5_表示
		{
			get
			{
				return this.X0Y0_羽根5.Dra;
			}
			set
			{
				this.X0Y0_羽根5.Dra = value;
				this.X0Y0_羽根5.Hit = value;
			}
		}

		public bool 羽根_表示
		{
			get
			{
				return this.X0Y0_羽根.Dra;
			}
			set
			{
				this.X0Y0_羽根.Dra = value;
				this.X0Y0_羽根.Hit = value;
			}
		}

		public bool 柄_表示
		{
			get
			{
				return this.X0Y0_柄.Dra;
			}
			set
			{
				this.X0Y0_柄.Dra = value;
				this.X0Y0_柄.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.羽根1_表示;
			}
			set
			{
				this.羽根1_表示 = value;
				this.羽根2_表示 = value;
				this.羽根3_表示 = value;
				this.羽根4_表示 = value;
				this.羽根5_表示 = value;
				this.羽根_表示 = value;
				this.柄_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.羽根1CD.不透明度;
			}
			set
			{
				this.羽根1CD.不透明度 = value;
				this.羽根2CD.不透明度 = value;
				this.羽根3CD.不透明度 = value;
				this.羽根4CD.不透明度 = value;
				this.羽根5CD.不透明度 = value;
				this.羽根CD.不透明度 = value;
				this.柄CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			this.X0Y0_羽根1CP.Update();
			this.X0Y0_羽根2CP.Update();
			this.X0Y0_羽根3CP.Update();
			this.X0Y0_羽根4CP.Update();
			this.X0Y0_羽根5CP.Update();
			this.X0Y0_羽根CP.Update();
			this.X0Y0_柄CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			Color2 color;
			Col.GetGrad(ref Col.White, out color);
			this.羽根1CD = new ColorD(ref Col.Black, ref color);
			this.羽根2CD = new ColorD(ref Col.Black, ref color);
			this.羽根3CD = new ColorD(ref Col.Black, ref color);
			this.羽根4CD = new ColorD(ref Col.Black, ref color);
			this.羽根5CD = new ColorD(ref Col.Black, ref color);
			Col.GetGrad(ref Col.White, out color);
			this.羽根CD = new ColorD(ref Col.Black, ref color);
			this.柄CD = new ColorD();
			this.柄CD.線 = Col.Black;
			this.柄CD.色 = new Color2(ref Col.Black, ref Col.Empty);
		}

		public Par X0Y0_羽根1;

		public Par X0Y0_羽根2;

		public Par X0Y0_羽根3;

		public Par X0Y0_羽根4;

		public Par X0Y0_羽根5;

		public Par X0Y0_羽根;

		public Par X0Y0_柄;

		public ColorD 羽根1CD;

		public ColorD 羽根2CD;

		public ColorD 羽根3CD;

		public ColorD 羽根4CD;

		public ColorD 羽根5CD;

		public ColorD 羽根CD;

		public ColorD 柄CD;

		public ColorP X0Y0_羽根1CP;

		public ColorP X0Y0_羽根2CP;

		public ColorP X0Y0_羽根3CP;

		public ColorP X0Y0_羽根4CP;

		public ColorP X0Y0_羽根5CP;

		public ColorP X0Y0_羽根CP;

		public ColorP X0Y0_柄CP;
	}
}
