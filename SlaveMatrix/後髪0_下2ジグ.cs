using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 後髪0_下2ジグ : お下げ2
	{
		public 後髪0_下2ジグ(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 後髪0_下2ジグD e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "下げ2ジグ";
			dif.Add(new Pars(Sta.胴体["後髪0"][0][8]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_髪基 = pars["髪基"].ToPar();
			Pars pars2 = pars["お下げ左"].ToPars();
			this.X0Y0_お下げ左_髪縛1 = pars2["髪縛1"].ToPar();
			this.X0Y0_お下げ左_髪縛2 = pars2["髪縛2"].ToPar();
			this.X0Y0_お下げ左_髪左 = pars2["髪左"].ToPar();
			this.X0Y0_お下げ左_髪右 = pars2["髪右"].ToPar();
			this.X0Y0_お下げ左_髪根 = pars2["髪根"].ToPar();
			pars2 = pars["お下げ右"].ToPars();
			this.X0Y0_お下げ右_髪縛1 = pars2["髪縛1"].ToPar();
			this.X0Y0_お下げ右_髪縛2 = pars2["髪縛2"].ToPar();
			this.X0Y0_お下げ右_髪右 = pars2["髪右"].ToPar();
			this.X0Y0_お下げ右_髪左 = pars2["髪左"].ToPar();
			this.X0Y0_お下げ右_髪根 = pars2["髪根"].ToPar();
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
			this.髪基_表示 = e.髪基_表示;
			this.お下げ左_髪縛1_表示 = e.お下げ左_髪縛1_表示;
			this.お下げ左_髪縛2_表示 = e.お下げ左_髪縛2_表示;
			this.お下げ左_髪左_表示 = e.お下げ左_髪左_表示;
			this.お下げ左_髪右_表示 = e.お下げ左_髪右_表示;
			this.お下げ左_髪根_表示 = e.お下げ左_髪根_表示;
			this.お下げ右_髪縛1_表示 = e.お下げ右_髪縛1_表示;
			this.お下げ右_髪縛2_表示 = e.お下げ右_髪縛2_表示;
			this.お下げ右_髪右_表示 = e.お下げ右_髪右_表示;
			this.お下げ右_髪左_表示 = e.お下げ右_髪左_表示;
			this.お下げ右_髪根_表示 = e.お下げ右_髪根_表示;
			this.髪長0 = e.髪長0;
			this.髪長1 = e.髪長1;
			this.毛量 = e.毛量;
			this.広がり = e.広がり;
			if (e.スライム)
			{
				this.スライム();
			}
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_髪基CP = new ColorP(this.X0Y0_髪基, this.髪基CD, DisUnit, false);
			this.X0Y0_お下げ左_髪縛1CP = new ColorP(this.X0Y0_お下げ左_髪縛1, this.お下げ左_髪縛1CD, DisUnit, true);
			this.X0Y0_お下げ左_髪縛2CP = new ColorP(this.X0Y0_お下げ左_髪縛2, this.お下げ左_髪縛2CD, DisUnit, true);
			this.X0Y0_お下げ左_髪左CP = new ColorP(this.X0Y0_お下げ左_髪左, this.お下げ左_髪左CD, DisUnit, false);
			this.X0Y0_お下げ左_髪右CP = new ColorP(this.X0Y0_お下げ左_髪右, this.お下げ左_髪右CD, DisUnit, false);
			this.X0Y0_お下げ左_髪根CP = new ColorP(this.X0Y0_お下げ左_髪根, this.お下げ左_髪根CD, DisUnit, false);
			this.X0Y0_お下げ右_髪縛1CP = new ColorP(this.X0Y0_お下げ右_髪縛1, this.お下げ右_髪縛1CD, DisUnit, true);
			this.X0Y0_お下げ右_髪縛2CP = new ColorP(this.X0Y0_お下げ右_髪縛2, this.お下げ右_髪縛2CD, DisUnit, true);
			this.X0Y0_お下げ右_髪右CP = new ColorP(this.X0Y0_お下げ右_髪右, this.お下げ右_髪右CD, DisUnit, false);
			this.X0Y0_お下げ右_髪左CP = new ColorP(this.X0Y0_お下げ右_髪左, this.お下げ右_髪左CD, DisUnit, false);
			this.X0Y0_お下げ右_髪根CP = new ColorP(this.X0Y0_お下げ右_髪根, this.お下げ右_髪根CD, DisUnit, false);
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

		public bool 髪基_表示
		{
			get
			{
				return this.X0Y0_髪基.Dra;
			}
			set
			{
				this.X0Y0_髪基.Dra = value;
				this.X0Y0_髪基.Hit = value;
			}
		}

		public override bool お下げ左_髪縛1_表示
		{
			get
			{
				return this.X0Y0_お下げ左_髪縛1.Dra;
			}
			set
			{
				this.X0Y0_お下げ左_髪縛1.Dra = value;
				this.X0Y0_お下げ左_髪縛1.Hit = value;
			}
		}

		public override bool お下げ左_髪縛2_表示
		{
			get
			{
				return this.X0Y0_お下げ左_髪縛2.Dra;
			}
			set
			{
				this.X0Y0_お下げ左_髪縛2.Dra = value;
				this.X0Y0_お下げ左_髪縛2.Hit = value;
			}
		}

		public bool お下げ左_髪左_表示
		{
			get
			{
				return this.X0Y0_お下げ左_髪左.Dra;
			}
			set
			{
				this.X0Y0_お下げ左_髪左.Dra = value;
				this.X0Y0_お下げ左_髪左.Hit = value;
			}
		}

		public bool お下げ左_髪右_表示
		{
			get
			{
				return this.X0Y0_お下げ左_髪右.Dra;
			}
			set
			{
				this.X0Y0_お下げ左_髪右.Dra = value;
				this.X0Y0_お下げ左_髪右.Hit = value;
			}
		}

		public bool お下げ左_髪根_表示
		{
			get
			{
				return this.X0Y0_お下げ左_髪根.Dra;
			}
			set
			{
				this.X0Y0_お下げ左_髪根.Dra = value;
				this.X0Y0_お下げ左_髪根.Hit = value;
			}
		}

		public override bool お下げ右_髪縛1_表示
		{
			get
			{
				return this.X0Y0_お下げ右_髪縛1.Dra;
			}
			set
			{
				this.X0Y0_お下げ右_髪縛1.Dra = value;
				this.X0Y0_お下げ右_髪縛1.Hit = value;
			}
		}

		public override bool お下げ右_髪縛2_表示
		{
			get
			{
				return this.X0Y0_お下げ右_髪縛2.Dra;
			}
			set
			{
				this.X0Y0_お下げ右_髪縛2.Dra = value;
				this.X0Y0_お下げ右_髪縛2.Hit = value;
			}
		}

		public bool お下げ右_髪右_表示
		{
			get
			{
				return this.X0Y0_お下げ右_髪右.Dra;
			}
			set
			{
				this.X0Y0_お下げ右_髪右.Dra = value;
				this.X0Y0_お下げ右_髪右.Hit = value;
			}
		}

		public bool お下げ右_髪左_表示
		{
			get
			{
				return this.X0Y0_お下げ右_髪左.Dra;
			}
			set
			{
				this.X0Y0_お下げ右_髪左.Dra = value;
				this.X0Y0_お下げ右_髪左.Hit = value;
			}
		}

		public bool お下げ右_髪根_表示
		{
			get
			{
				return this.X0Y0_お下げ右_髪根.Dra;
			}
			set
			{
				this.X0Y0_お下げ右_髪根.Dra = value;
				this.X0Y0_お下げ右_髪根.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.髪基_表示;
			}
			set
			{
				this.髪基_表示 = value;
				this.お下げ左_髪縛1_表示 = value;
				this.お下げ左_髪縛2_表示 = value;
				this.お下げ左_髪左_表示 = value;
				this.お下げ左_髪右_表示 = value;
				this.お下げ左_髪根_表示 = value;
				this.お下げ右_髪縛1_表示 = value;
				this.お下げ右_髪縛2_表示 = value;
				this.お下げ右_髪右_表示 = value;
				this.お下げ右_髪左_表示 = value;
				this.お下げ右_髪根_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.髪基CD.不透明度;
			}
			set
			{
				this.髪基CD.不透明度 = value;
				this.お下げ左_髪縛1CD.不透明度 = value;
				this.お下げ左_髪縛2CD.不透明度 = value;
				this.お下げ左_髪左CD.不透明度 = value;
				this.お下げ左_髪右CD.不透明度 = value;
				this.お下げ左_髪根CD.不透明度 = value;
				this.お下げ右_髪縛1CD.不透明度 = value;
				this.お下げ右_髪縛2CD.不透明度 = value;
				this.お下げ右_髪右CD.不透明度 = value;
				this.お下げ右_髪左CD.不透明度 = value;
				this.お下げ右_髪根CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_お下げ左_髪根.AngleBase = num * 10.0;
			this.X0Y0_お下げ右_髪根.AngleBase = num * -10.0;
			this.本体.JoinPAall();
		}

		public double 髪長0
		{
			set
			{
				double num = 0.7 + 0.3 * value;
				this.X0Y0_髪基.SizeYBase *= num;
			}
		}

		public double 髪長1
		{
			set
			{
				double num = 0.5 + 0.9 * value;
				this.X0Y0_お下げ左_髪左.SizeYBase *= num;
				this.X0Y0_お下げ左_髪右.SizeYBase *= num;
				this.X0Y0_お下げ左_髪根.SizeYBase *= num;
				this.X0Y0_お下げ右_髪右.SizeYBase *= num;
				this.X0Y0_お下げ右_髪左.SizeYBase *= num;
				this.X0Y0_お下げ右_髪根.SizeYBase *= num;
			}
		}

		public double 毛量
		{
			set
			{
				double num = 1.0 + 0.5 * value;
				this.X0Y0_お下げ左_髪縛1.SizeBase *= num;
				this.X0Y0_お下げ左_髪縛2.SizeBase *= num;
				this.X0Y0_お下げ左_髪左.SizeXBase *= num;
				this.X0Y0_お下げ左_髪右.SizeXBase *= num;
				this.X0Y0_お下げ左_髪根.SizeXBase *= num;
				this.X0Y0_お下げ右_髪縛1.SizeBase *= num;
				this.X0Y0_お下げ右_髪縛2.SizeBase *= num;
				this.X0Y0_お下げ右_髪右.SizeXBase *= num;
				this.X0Y0_お下げ右_髪左.SizeXBase *= num;
				this.X0Y0_お下げ右_髪根.SizeXBase *= num;
			}
		}

		public double 広がり
		{
			set
			{
				this.X0Y0_お下げ左_髪左.AngleBase = 3.0 * value;
				this.X0Y0_お下げ左_髪右.AngleBase = -3.0 * value;
				this.X0Y0_お下げ右_髪右.AngleBase = -3.0 * value;
				this.X0Y0_お下げ右_髪左.AngleBase = 3.0 * value;
			}
		}

		public void スライム()
		{
			this.X0Y0_髪基.OP[this.右 ? 1 : 0].Outline = false;
			this.X0Y0_髪基.OP[this.右 ? 0 : 1].Outline = false;
			this.X0Y0_お下げ左_髪縛1.OP[this.右 ? 0 : 0].Outline = false;
			this.X0Y0_お下げ左_髪縛2.OP[this.右 ? 0 : 0].Outline = false;
			this.X0Y0_お下げ左_髪左.OP[this.右 ? 4 : 0].Outline = false;
			this.X0Y0_お下げ左_髪左.OP[this.右 ? 3 : 1].Outline = false;
			this.X0Y0_お下げ左_髪左.OP[this.右 ? 2 : 2].Outline = false;
			this.X0Y0_お下げ左_髪左.OP[this.右 ? 1 : 3].Outline = false;
			this.X0Y0_お下げ左_髪左.OP[this.右 ? 0 : 4].Outline = false;
			this.X0Y0_お下げ左_髪右.OP[this.右 ? 4 : 0].Outline = false;
			this.X0Y0_お下げ左_髪右.OP[this.右 ? 3 : 1].Outline = false;
			this.X0Y0_お下げ左_髪右.OP[this.右 ? 2 : 2].Outline = false;
			this.X0Y0_お下げ左_髪右.OP[this.右 ? 1 : 3].Outline = false;
			this.X0Y0_お下げ左_髪右.OP[this.右 ? 0 : 4].Outline = false;
			this.X0Y0_お下げ左_髪根.OP[this.右 ? 4 : 0].Outline = false;
			this.X0Y0_お下げ左_髪根.OP[this.右 ? 3 : 1].Outline = false;
			this.X0Y0_お下げ左_髪根.OP[this.右 ? 2 : 2].Outline = false;
			this.X0Y0_お下げ左_髪根.OP[this.右 ? 1 : 3].Outline = false;
			this.X0Y0_お下げ左_髪根.OP[this.右 ? 0 : 4].Outline = false;
			this.X0Y0_お下げ右_髪縛1.OP[this.右 ? 0 : 0].Outline = false;
			this.X0Y0_お下げ右_髪縛2.OP[this.右 ? 0 : 0].Outline = false;
			this.X0Y0_お下げ右_髪右.OP[this.右 ? 4 : 0].Outline = false;
			this.X0Y0_お下げ右_髪右.OP[this.右 ? 3 : 1].Outline = false;
			this.X0Y0_お下げ右_髪右.OP[this.右 ? 2 : 2].Outline = false;
			this.X0Y0_お下げ右_髪右.OP[this.右 ? 1 : 3].Outline = false;
			this.X0Y0_お下げ右_髪右.OP[this.右 ? 0 : 4].Outline = false;
			this.X0Y0_お下げ右_髪左.OP[this.右 ? 4 : 0].Outline = false;
			this.X0Y0_お下げ右_髪左.OP[this.右 ? 3 : 1].Outline = false;
			this.X0Y0_お下げ右_髪左.OP[this.右 ? 2 : 2].Outline = false;
			this.X0Y0_お下げ右_髪左.OP[this.右 ? 1 : 3].Outline = false;
			this.X0Y0_お下げ右_髪左.OP[this.右 ? 0 : 4].Outline = false;
			this.X0Y0_お下げ右_髪根.OP[this.右 ? 4 : 0].Outline = false;
			this.X0Y0_お下げ右_髪根.OP[this.右 ? 3 : 1].Outline = false;
			this.X0Y0_お下げ右_髪根.OP[this.右 ? 2 : 2].Outline = false;
			this.X0Y0_お下げ右_髪根.OP[this.右 ? 1 : 3].Outline = false;
			this.X0Y0_お下げ右_髪根.OP[this.右 ? 0 : 4].Outline = false;
		}

		public override bool Is布(Par p)
		{
			return p == this.X0Y0_お下げ左_髪縛1 || p == this.X0Y0_お下げ左_髪縛2 || p == this.X0Y0_お下げ右_髪縛1 || p == this.X0Y0_お下げ右_髪縛2;
		}

		public override void 色更新()
		{
			this.X0Y0_髪基CP.Update();
			this.X0Y0_お下げ左_髪縛1CP.Update();
			this.X0Y0_お下げ左_髪縛2CP.Update();
			this.X0Y0_お下げ左_髪左CP.Update();
			this.X0Y0_お下げ左_髪右CP.Update();
			this.X0Y0_お下げ左_髪根CP.Update();
			this.X0Y0_お下げ右_髪縛1CP.Update();
			this.X0Y0_お下げ右_髪縛2CP.Update();
			this.X0Y0_お下げ右_髪右CP.Update();
			this.X0Y0_お下げ右_髪左CP.Update();
			this.X0Y0_お下げ右_髪根CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.髪基CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ左_髪縛1CD = new ColorD();
			this.お下げ左_髪縛2CD = new ColorD();
			this.お下げ左_髪左CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ左_髪右CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ左_髪根CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ右_髪縛1CD = new ColorD();
			this.お下げ右_髪縛2CD = new ColorD();
			this.お下げ右_髪右CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ右_髪左CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ右_髪根CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		}

		public override void 髪留配色(髪留色 配色左, 髪留色 配色右)
		{
			this.お下げ左_髪縛1CD.色 = 配色左.髪留1色;
			this.お下げ左_髪縛2CD.色 = 配色左.髪留2色;
			this.お下げ右_髪縛1CD.色 = 配色右.髪留1色;
			this.お下げ右_髪縛2CD.色 = 配色右.髪留2色;
		}

		public Par X0Y0_髪基;

		public Par X0Y0_お下げ左_髪縛1;

		public Par X0Y0_お下げ左_髪縛2;

		public Par X0Y0_お下げ左_髪左;

		public Par X0Y0_お下げ左_髪右;

		public Par X0Y0_お下げ左_髪根;

		public Par X0Y0_お下げ右_髪縛1;

		public Par X0Y0_お下げ右_髪縛2;

		public Par X0Y0_お下げ右_髪右;

		public Par X0Y0_お下げ右_髪左;

		public Par X0Y0_お下げ右_髪根;

		public ColorD 髪基CD;

		public ColorD お下げ左_髪縛1CD;

		public ColorD お下げ左_髪縛2CD;

		public ColorD お下げ左_髪左CD;

		public ColorD お下げ左_髪右CD;

		public ColorD お下げ左_髪根CD;

		public ColorD お下げ右_髪縛1CD;

		public ColorD お下げ右_髪縛2CD;

		public ColorD お下げ右_髪右CD;

		public ColorD お下げ右_髪左CD;

		public ColorD お下げ右_髪根CD;

		public ColorP X0Y0_髪基CP;

		public ColorP X0Y0_お下げ左_髪縛1CP;

		public ColorP X0Y0_お下げ左_髪縛2CP;

		public ColorP X0Y0_お下げ左_髪左CP;

		public ColorP X0Y0_お下げ左_髪右CP;

		public ColorP X0Y0_お下げ左_髪根CP;

		public ColorP X0Y0_お下げ右_髪縛1CP;

		public ColorP X0Y0_お下げ右_髪縛2CP;

		public ColorP X0Y0_お下げ右_髪右CP;

		public ColorP X0Y0_お下げ右_髪左CP;

		public ColorP X0Y0_お下げ右_髪根CP;
	}
}
