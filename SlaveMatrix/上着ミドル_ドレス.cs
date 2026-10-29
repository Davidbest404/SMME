using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 上着ミドル_ドレス : 上着ミドル
	{
		public 上着ミドル_ドレス(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 上着ミドル_ドレスD e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.胴体["上着ミドル"][2]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_服 = pars["服"].ToPar();
			Pars pars2 = pars["縁"].ToPars();
			this.X0Y0_縁_縁左 = pars2["縁左"].ToPar();
			this.X0Y0_縁_縁右 = pars2["縁右"].ToPar();
			pars2 = pars["柄"].ToPars();
			Pars pars3 = pars2["柄左"].ToPars();
			this.X0Y0_柄_柄左_柄1 = pars3["柄1"].ToPar();
			Pars pars4 = pars3["柄2"].ToPars();
			this.X0Y0_柄_柄左_柄2_柄1 = pars4["柄1"].ToPar();
			this.X0Y0_柄_柄左_柄2_柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["柄右"].ToPars();
			this.X0Y0_柄_柄右_柄1 = pars3["柄1"].ToPar();
			pars4 = pars3["柄2"].ToPars();
			this.X0Y0_柄_柄右_柄2_柄1 = pars4["柄1"].ToPar();
			this.X0Y0_柄_柄右_柄2_柄2 = pars4["柄2"].ToPar();
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
			this.服_表示 = e.服_表示;
			this.縁_縁左_表示 = e.縁_縁左_表示;
			this.縁_縁右_表示 = e.縁_縁右_表示;
			this.柄_柄左_柄1_表示 = e.柄_柄左_柄1_表示;
			this.柄_柄左_柄2_柄1_表示 = e.柄_柄左_柄2_柄1_表示;
			this.柄_柄左_柄2_柄2_表示 = e.柄_柄左_柄2_柄2_表示;
			this.柄_柄右_柄1_表示 = e.柄_柄右_柄1_表示;
			this.柄_柄右_柄2_柄1_表示 = e.柄_柄右_柄2_柄1_表示;
			this.柄_柄右_柄2_柄2_表示 = e.柄_柄右_柄2_柄2_表示;
			this.ベ\u30FCス表示 = e.ベ\u30FCス表示;
			this.縁表示 = e.縁表示;
			this.柄1表示 = e.柄1表示;
			this.柄2表示 = e.柄2表示;
			this.柄3表示 = e.柄3表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_服CP = new ColorP(this.X0Y0_服, this.服CD, DisUnit, true);
			this.X0Y0_縁_縁左CP = new ColorP(this.X0Y0_縁_縁左, this.縁_縁左CD, DisUnit, true);
			this.X0Y0_縁_縁右CP = new ColorP(this.X0Y0_縁_縁右, this.縁_縁右CD, DisUnit, true);
			this.X0Y0_柄_柄左_柄1CP = new ColorP(this.X0Y0_柄_柄左_柄1, this.柄_柄左_柄1CD, DisUnit, true);
			this.柄左 = new Par[]
			{
				this.X0Y0_柄_柄左_柄2_柄1,
				this.X0Y0_柄_柄左_柄2_柄2
			};
			this.X0Y0_柄_柄左_柄2_柄1CP = new ColorP(this.X0Y0_柄_柄左_柄2_柄1, this.柄_柄左_柄2_柄1CD, DisUnit, true);
			this.X0Y0_柄_柄左_柄2_柄2CP = new ColorP(this.X0Y0_柄_柄左_柄2_柄2, this.柄_柄左_柄2_柄2CD, DisUnit, true);
			this.X0Y0_柄_柄右_柄1CP = new ColorP(this.X0Y0_柄_柄右_柄1, this.柄_柄右_柄1CD, DisUnit, true);
			this.柄右 = new Par[]
			{
				this.X0Y0_柄_柄右_柄2_柄1,
				this.X0Y0_柄_柄右_柄2_柄2
			};
			this.X0Y0_柄_柄右_柄2_柄1CP = new ColorP(this.X0Y0_柄_柄右_柄2_柄1, this.柄_柄右_柄2_柄1CD, DisUnit, true);
			this.X0Y0_柄_柄右_柄2_柄2CP = new ColorP(this.X0Y0_柄_柄右_柄2_柄2, this.柄_柄右_柄2_柄2CD, DisUnit, true);
			this.濃度 = e.濃度;
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

		public bool 服_表示
		{
			get
			{
				return this.X0Y0_服.Dra;
			}
			set
			{
				this.X0Y0_服.Dra = value;
				this.X0Y0_服.Hit = false;
			}
		}

		public bool 縁_縁左_表示
		{
			get
			{
				return this.X0Y0_縁_縁左.Dra;
			}
			set
			{
				this.X0Y0_縁_縁左.Dra = value;
				this.X0Y0_縁_縁左.Hit = false;
			}
		}

		public bool 縁_縁右_表示
		{
			get
			{
				return this.X0Y0_縁_縁右.Dra;
			}
			set
			{
				this.X0Y0_縁_縁右.Dra = value;
				this.X0Y0_縁_縁右.Hit = false;
			}
		}

		public bool 柄_柄左_柄1_表示
		{
			get
			{
				return this.X0Y0_柄_柄左_柄1.Dra;
			}
			set
			{
				this.X0Y0_柄_柄左_柄1.Dra = value;
				this.X0Y0_柄_柄左_柄1.Hit = false;
			}
		}

		public bool 柄_柄左_柄2_柄1_表示
		{
			get
			{
				return this.X0Y0_柄_柄左_柄2_柄1.Dra;
			}
			set
			{
				this.X0Y0_柄_柄左_柄2_柄1.Dra = value;
				this.X0Y0_柄_柄左_柄2_柄1.Hit = false;
			}
		}

		public bool 柄_柄左_柄2_柄2_表示
		{
			get
			{
				return this.X0Y0_柄_柄左_柄2_柄2.Dra;
			}
			set
			{
				this.X0Y0_柄_柄左_柄2_柄2.Dra = value;
				this.X0Y0_柄_柄左_柄2_柄2.Hit = false;
			}
		}

		public bool 柄_柄右_柄1_表示
		{
			get
			{
				return this.X0Y0_柄_柄右_柄1.Dra;
			}
			set
			{
				this.X0Y0_柄_柄右_柄1.Dra = value;
				this.X0Y0_柄_柄右_柄1.Hit = false;
			}
		}

		public bool 柄_柄右_柄2_柄1_表示
		{
			get
			{
				return this.X0Y0_柄_柄右_柄2_柄1.Dra;
			}
			set
			{
				this.X0Y0_柄_柄右_柄2_柄1.Dra = value;
				this.X0Y0_柄_柄右_柄2_柄1.Hit = false;
			}
		}

		public bool 柄_柄右_柄2_柄2_表示
		{
			get
			{
				return this.X0Y0_柄_柄右_柄2_柄2.Dra;
			}
			set
			{
				this.X0Y0_柄_柄右_柄2_柄2.Dra = value;
				this.X0Y0_柄_柄右_柄2_柄2.Hit = false;
			}
		}

		public bool ベ\u30FCス表示
		{
			get
			{
				return this.服_表示;
			}
			set
			{
				this.服_表示 = value;
			}
		}

		public bool 縁表示
		{
			get
			{
				return this.縁_縁左_表示;
			}
			set
			{
				this.縁_縁左_表示 = value;
				this.縁_縁右_表示 = value;
			}
		}

		public bool 柄1表示
		{
			get
			{
				return this.柄_柄左_柄1_表示;
			}
			set
			{
				this.柄_柄左_柄1_表示 = value;
				this.柄_柄右_柄1_表示 = value;
			}
		}

		public bool 柄2表示
		{
			get
			{
				return this.柄_柄左_柄2_柄1_表示;
			}
			set
			{
				this.柄_柄左_柄2_柄1_表示 = value;
				this.柄_柄右_柄2_柄1_表示 = value;
			}
		}

		public bool 柄3表示
		{
			get
			{
				return this.柄_柄左_柄2_柄2_表示;
			}
			set
			{
				this.柄_柄左_柄2_柄2_表示 = value;
				this.柄_柄右_柄2_柄2_表示 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.服_表示;
			}
			set
			{
				this.服_表示 = value;
				this.縁_縁左_表示 = value;
				this.縁_縁右_表示 = value;
				this.柄_柄左_柄1_表示 = value;
				this.柄_柄左_柄2_柄1_表示 = value;
				this.柄_柄左_柄2_柄2_表示 = value;
				this.柄_柄右_柄1_表示 = value;
				this.柄_柄右_柄2_柄1_表示 = value;
				this.柄_柄右_柄2_柄2_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.服CD.不透明度;
			}
			set
			{
				this.服CD.不透明度 = value;
				this.縁_縁左CD.不透明度 = value;
				this.縁_縁右CD.不透明度 = value;
				this.柄_柄左_柄1CD.不透明度 = value;
				this.柄_柄左_柄2_柄1CD.不透明度 = value;
				this.柄_柄左_柄2_柄2CD.不透明度 = value;
				this.柄_柄右_柄1CD.不透明度 = value;
				this.柄_柄右_柄2_柄1CD.不透明度 = value;
				this.柄_柄右_柄2_柄2CD.不透明度 = value;
			}
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_服 || p == this.X0Y0_縁_縁左 || p == this.X0Y0_縁_縁右 || p == this.X0Y0_柄_柄左_柄1 || p == this.X0Y0_柄_柄左_柄2_柄1 || p == this.X0Y0_柄_柄左_柄2_柄2 || p == this.X0Y0_柄_柄右_柄1 || p == this.X0Y0_柄_柄右_柄2_柄1 || p == this.X0Y0_柄_柄右_柄2_柄2;
		}

		public override void 色更新()
		{
			this.X0Y0_服CP.Update();
			this.X0Y0_縁_縁左CP.Update();
			this.X0Y0_縁_縁右CP.Update();
			this.X0Y0_柄_柄左_柄1CP.Update();
			this.柄左.GetMiY_MaY(out this.mm);
			this.X0Y0_柄_柄左_柄2_柄1CP.Update(this.mm);
			this.X0Y0_柄_柄左_柄2_柄2CP.Update(this.mm);
			this.X0Y0_柄_柄右_柄1CP.Update();
			this.柄右.GetMiY_MaY(out this.mm);
			this.X0Y0_柄_柄右_柄2_柄1CP.Update(this.mm);
			this.X0Y0_柄_柄右_柄2_柄2CP.Update(this.mm);
		}

		public void 色更新(Vector2D[] ドレス, Vector2D[] 縁左, Vector2D[] 縁右)
		{
			this.X0Y0_服CP.Update(ドレス);
			this.X0Y0_縁_縁左CP.Update(縁左);
			this.X0Y0_縁_縁右CP.Update(縁右);
			this.X0Y0_柄_柄左_柄1CP.Update();
			this.柄左.GetMiY_MaY(out this.mm);
			this.X0Y0_柄_柄左_柄2_柄1CP.Update(this.mm);
			this.X0Y0_柄_柄左_柄2_柄2CP.Update(this.mm);
			this.X0Y0_柄_柄右_柄1CP.Update();
			this.柄右.GetMiY_MaY(out this.mm);
			this.X0Y0_柄_柄右_柄2_柄1CP.Update(this.mm);
			this.X0Y0_柄_柄右_柄2_柄2CP.Update(this.mm);
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.服CD = new ColorD();
			this.縁_縁左CD = new ColorD();
			this.縁_縁右CD = new ColorD();
			this.柄_柄左_柄1CD = new ColorD();
			this.柄_柄左_柄2_柄1CD = new ColorD();
			this.柄_柄左_柄2_柄2CD = new ColorD();
			this.柄_柄右_柄1CD = new ColorD();
			this.柄_柄右_柄2_柄1CD = new ColorD();
			this.柄_柄右_柄2_柄2CD = new ColorD();
		}

		public void 配色(ドレス色 配色)
		{
			this.服CD.色 = 配色.生地色;
			this.縁_縁左CD.色 = 配色.縁色;
			this.縁_縁右CD.色 = this.縁_縁左CD.色;
			this.柄_柄左_柄1CD.色 = 配色.柄色;
			this.柄_柄左_柄2_柄1CD.色 = this.柄_柄左_柄1CD.色;
			this.柄_柄左_柄2_柄2CD.色 = this.柄_柄左_柄1CD.色;
			this.柄_柄右_柄1CD.色 = this.柄_柄左_柄1CD.色;
			this.柄_柄右_柄2_柄1CD.色 = this.柄_柄左_柄1CD.色;
			this.柄_柄右_柄2_柄2CD.色 = this.柄_柄左_柄1CD.色;
		}

		public Par X0Y0_服;

		public Par X0Y0_縁_縁左;

		public Par X0Y0_縁_縁右;

		public Par X0Y0_柄_柄左_柄1;

		public Par X0Y0_柄_柄左_柄2_柄1;

		public Par X0Y0_柄_柄左_柄2_柄2;

		public Par X0Y0_柄_柄右_柄1;

		public Par X0Y0_柄_柄右_柄2_柄1;

		public Par X0Y0_柄_柄右_柄2_柄2;

		public ColorD 服CD;

		public ColorD 縁_縁左CD;

		public ColorD 縁_縁右CD;

		public ColorD 柄_柄左_柄1CD;

		public ColorD 柄_柄左_柄2_柄1CD;

		public ColorD 柄_柄左_柄2_柄2CD;

		public ColorD 柄_柄右_柄1CD;

		public ColorD 柄_柄右_柄2_柄1CD;

		public ColorD 柄_柄右_柄2_柄2CD;

		public ColorP X0Y0_服CP;

		public ColorP X0Y0_縁_縁左CP;

		public ColorP X0Y0_縁_縁右CP;

		public ColorP X0Y0_柄_柄左_柄1CP;

		public ColorP X0Y0_柄_柄左_柄2_柄1CP;

		public ColorP X0Y0_柄_柄左_柄2_柄2CP;

		public ColorP X0Y0_柄_柄右_柄1CP;

		public ColorP X0Y0_柄_柄右_柄2_柄1CP;

		public ColorP X0Y0_柄_柄右_柄2_柄2CP;

		private Par[] 柄左;

		private Par[] 柄右;

		private Vector2D[] mm;
	}
}
