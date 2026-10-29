using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 鰭_魚 : 鰭
	{
		public 鰭_魚(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 鰭_魚D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.肢左["鰭"][0]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["鰭2"].ToPars();
			this.X0Y0_鰭2_鰭膜 = pars2["鰭膜"].ToPar();
			this.X0Y0_鰭2_鰭条 = pars2["鰭条"].ToPar();
			pars2 = pars["鰭1"].ToPars();
			this.X0Y0_鰭1_鰭膜 = pars2["鰭膜"].ToPar();
			this.X0Y0_鰭1_鰭条 = pars2["鰭条"].ToPar();
			Pars pars3 = this.本体[0][1];
			pars2 = pars3["鰭2"].ToPars();
			this.X0Y1_鰭2_鰭膜 = pars2["鰭膜"].ToPar();
			this.X0Y1_鰭2_鰭条 = pars2["鰭条"].ToPar();
			pars2 = pars3["鰭1"].ToPars();
			this.X0Y1_鰭1_鰭膜 = pars2["鰭膜"].ToPar();
			this.X0Y1_鰭1_鰭条 = pars2["鰭条"].ToPar();
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
			this.鰭2_鰭膜_表示 = e.鰭2_鰭膜_表示;
			this.鰭2_鰭条_表示 = e.鰭2_鰭条_表示;
			this.鰭1_鰭膜_表示 = e.鰭1_鰭膜_表示;
			this.鰭1_鰭条_表示 = e.鰭1_鰭条_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_鰭2_鰭膜CP = new ColorP(this.X0Y0_鰭2_鰭膜, this.鰭2_鰭膜CD, DisUnit, true);
			this.X0Y0_鰭2_鰭条CP = new ColorP(this.X0Y0_鰭2_鰭条, this.鰭2_鰭条CD, DisUnit, true);
			this.X0Y0_鰭1_鰭膜CP = new ColorP(this.X0Y0_鰭1_鰭膜, this.鰭1_鰭膜CD, DisUnit, true);
			this.X0Y0_鰭1_鰭条CP = new ColorP(this.X0Y0_鰭1_鰭条, this.鰭1_鰭条CD, DisUnit, true);
			this.X0Y1_鰭2_鰭膜CP = new ColorP(this.X0Y1_鰭2_鰭膜, this.鰭2_鰭膜CD, DisUnit, true);
			this.X0Y1_鰭2_鰭条CP = new ColorP(this.X0Y1_鰭2_鰭条, this.鰭2_鰭条CD, DisUnit, true);
			this.X0Y1_鰭1_鰭膜CP = new ColorP(this.X0Y1_鰭1_鰭膜, this.鰭1_鰭膜CD, DisUnit, true);
			this.X0Y1_鰭1_鰭条CP = new ColorP(this.X0Y1_鰭1_鰭条, this.鰭1_鰭条CD, DisUnit, true);
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
				this.本体.IndexY = (this.欠損_ ? 1 : 0);
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

		public bool 鰭2_鰭膜_表示
		{
			get
			{
				return this.X0Y0_鰭2_鰭膜.Dra;
			}
			set
			{
				this.X0Y0_鰭2_鰭膜.Dra = value;
				this.X0Y1_鰭2_鰭膜.Dra = value;
				this.X0Y0_鰭2_鰭膜.Hit = value;
				this.X0Y1_鰭2_鰭膜.Hit = value;
			}
		}

		public bool 鰭2_鰭条_表示
		{
			get
			{
				return this.X0Y0_鰭2_鰭条.Dra;
			}
			set
			{
				this.X0Y0_鰭2_鰭条.Dra = value;
				this.X0Y1_鰭2_鰭条.Dra = value;
				this.X0Y0_鰭2_鰭条.Hit = value;
				this.X0Y1_鰭2_鰭条.Hit = value;
			}
		}

		public bool 鰭1_鰭膜_表示
		{
			get
			{
				return this.X0Y0_鰭1_鰭膜.Dra;
			}
			set
			{
				this.X0Y0_鰭1_鰭膜.Dra = value;
				this.X0Y1_鰭1_鰭膜.Dra = value;
				this.X0Y0_鰭1_鰭膜.Hit = value;
				this.X0Y1_鰭1_鰭膜.Hit = value;
			}
		}

		public bool 鰭1_鰭条_表示
		{
			get
			{
				return this.X0Y0_鰭1_鰭条.Dra;
			}
			set
			{
				this.X0Y0_鰭1_鰭条.Dra = value;
				this.X0Y1_鰭1_鰭条.Dra = value;
				this.X0Y0_鰭1_鰭条.Hit = value;
				this.X0Y1_鰭1_鰭条.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.鰭2_鰭膜_表示;
			}
			set
			{
				this.鰭2_鰭膜_表示 = value;
				this.鰭2_鰭条_表示 = value;
				this.鰭1_鰭膜_表示 = value;
				this.鰭1_鰭条_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.鰭2_鰭膜CD.不透明度;
			}
			set
			{
				this.鰭2_鰭膜CD.不透明度 = value;
				this.鰭2_鰭条CD.不透明度 = value;
				this.鰭1_鰭膜CD.不透明度 = value;
				this.鰭1_鰭条CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_鰭2_鰭膜.AngleBase = num * -25.0;
			this.X0Y0_鰭2_鰭条.AngleBase = 0.0;
			this.X0Y0_鰭1_鰭膜.AngleBase = 0.0;
			this.X0Y0_鰭1_鰭条.AngleBase = 0.0;
			this.X0Y1_鰭2_鰭膜.AngleBase = num * -25.0;
			this.X0Y1_鰭2_鰭条.AngleBase = 0.0;
			this.X0Y1_鰭1_鰭膜.AngleBase = 0.0;
			this.X0Y1_鰭1_鰭条.AngleBase = 0.0;
			this.本体.JoinPAall();
		}

		public override void 色更新()
		{
			if (this.本体.IndexY == 0)
			{
				this.X0Y0_鰭2_鰭膜CP.Update();
				this.X0Y0_鰭2_鰭条CP.Update();
				this.X0Y0_鰭1_鰭膜CP.Update();
				this.X0Y0_鰭1_鰭条CP.Update();
				return;
			}
			this.X0Y1_鰭2_鰭膜CP.Update();
			this.X0Y1_鰭2_鰭条CP.Update();
			this.X0Y1_鰭1_鰭膜CP.Update();
			this.X0Y1_鰭1_鰭条CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.鰭2_鰭膜CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.鰭2_鰭条CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.鰭1_鰭膜CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.鰭1_鰭条CD = new ColorD(ref Col.Black, ref 体配色.爪O);
		}

		public Par X0Y0_鰭2_鰭膜;

		public Par X0Y0_鰭2_鰭条;

		public Par X0Y0_鰭1_鰭膜;

		public Par X0Y0_鰭1_鰭条;

		public Par X0Y1_鰭2_鰭膜;

		public Par X0Y1_鰭2_鰭条;

		public Par X0Y1_鰭1_鰭膜;

		public Par X0Y1_鰭1_鰭条;

		public ColorD 鰭2_鰭膜CD;

		public ColorD 鰭2_鰭条CD;

		public ColorD 鰭1_鰭膜CD;

		public ColorD 鰭1_鰭条CD;

		public ColorP X0Y0_鰭2_鰭膜CP;

		public ColorP X0Y0_鰭2_鰭条CP;

		public ColorP X0Y0_鰭1_鰭膜CP;

		public ColorP X0Y0_鰭1_鰭条CP;

		public ColorP X0Y1_鰭2_鰭膜CP;

		public ColorP X0Y1_鰭2_鰭条CP;

		public ColorP X0Y1_鰭1_鰭膜CP;

		public ColorP X0Y1_鰭1_鰭条CP;
	}
}
