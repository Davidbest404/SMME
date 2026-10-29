using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 横髪_編み : 横髪
	{
		public 横髪_編み(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 横髪_編みD e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "編み";
			dif.Add(new Pars(Sta.胴体["横髪左"][0][4]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_髪 = pars["髪"].ToPar();
			Pars pars2 = pars["編節1"].ToPars();
			this.X0Y0_編節1_髪節 = pars2["髪節"].ToPar();
			this.X0Y0_編節1_髪編目 = pars2["髪編目"].ToPar();
			pars2 = pars["編節2"].ToPars();
			this.X0Y0_編節2_髪節 = pars2["髪節"].ToPar();
			this.X0Y0_編節2_髪編目 = pars2["髪編目"].ToPar();
			pars2 = pars["編節3"].ToPars();
			this.X0Y0_編節3_髪節 = pars2["髪節"].ToPar();
			this.X0Y0_編節3_髪編目 = pars2["髪編目"].ToPar();
			pars2 = pars["編節4"].ToPars();
			this.X0Y0_編節4_髪節 = pars2["髪節"].ToPar();
			this.X0Y0_編節4_髪編目 = pars2["髪編目"].ToPar();
			this.X0Y0_髪縛1 = pars["髪縛1"].ToPar();
			this.X0Y0_髪縛2 = pars["髪縛2"].ToPar();
			this.X0Y0_髪左 = pars["髪左"].ToPar();
			this.X0Y0_髪右 = pars["髪右"].ToPar();
			this.X0Y0_髪根 = pars["髪根"].ToPar();
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
			this.髪_表示 = e.髪_表示;
			this.編節1_髪節_表示 = e.編節1_髪節_表示;
			this.編節1_髪編目_表示 = e.編節1_髪編目_表示;
			this.編節2_髪節_表示 = e.編節2_髪節_表示;
			this.編節2_髪編目_表示 = e.編節2_髪編目_表示;
			this.編節3_髪節_表示 = e.編節3_髪節_表示;
			this.編節3_髪編目_表示 = e.編節3_髪編目_表示;
			this.編節4_髪節_表示 = e.編節4_髪節_表示;
			this.編節4_髪編目_表示 = e.編節4_髪編目_表示;
			this.髪縛1_表示 = e.髪縛1_表示;
			this.髪縛2_表示 = e.髪縛2_表示;
			this.髪左_表示 = e.髪左_表示;
			this.髪右_表示 = e.髪右_表示;
			this.髪根_表示 = e.髪根_表示;
			this.髪長1 = e.髪長1;
			this.髪長2 = e.髪長2;
			this.毛量 = e.毛量;
			this.広がり = e.広がり;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_髪CP = new ColorP(this.X0Y0_髪, this.髪CD, DisUnit, false);
			this.X0Y0_編節1_髪節CP = new ColorP(this.X0Y0_編節1_髪節, this.編節1_髪節CD, DisUnit, false);
			this.X0Y0_編節1_髪編目CP = new ColorP(this.X0Y0_編節1_髪編目, this.編節1_髪編目CD, DisUnit, false);
			this.X0Y0_編節2_髪節CP = new ColorP(this.X0Y0_編節2_髪節, this.編節2_髪節CD, DisUnit, false);
			this.X0Y0_編節2_髪編目CP = new ColorP(this.X0Y0_編節2_髪編目, this.編節2_髪編目CD, DisUnit, false);
			this.X0Y0_編節3_髪節CP = new ColorP(this.X0Y0_編節3_髪節, this.編節3_髪節CD, DisUnit, false);
			this.X0Y0_編節3_髪編目CP = new ColorP(this.X0Y0_編節3_髪編目, this.編節3_髪編目CD, DisUnit, false);
			this.X0Y0_編節4_髪節CP = new ColorP(this.X0Y0_編節4_髪節, this.編節4_髪節CD, DisUnit, false);
			this.X0Y0_編節4_髪編目CP = new ColorP(this.X0Y0_編節4_髪編目, this.編節4_髪編目CD, DisUnit, false);
			this.X0Y0_髪縛1CP = new ColorP(this.X0Y0_髪縛1, this.髪縛1CD, DisUnit, true);
			this.X0Y0_髪縛2CP = new ColorP(this.X0Y0_髪縛2, this.髪縛2CD, DisUnit, true);
			this.X0Y0_髪左CP = new ColorP(this.X0Y0_髪左, this.髪左CD, DisUnit, false);
			this.X0Y0_髪右CP = new ColorP(this.X0Y0_髪右, this.髪右CD, DisUnit, false);
			this.X0Y0_髪根CP = new ColorP(this.X0Y0_髪根, this.髪根CD, DisUnit, false);
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

		public bool 髪_表示
		{
			get
			{
				return this.X0Y0_髪.Dra;
			}
			set
			{
				this.X0Y0_髪.Dra = value;
				this.X0Y0_髪.Hit = value;
			}
		}

		public bool 編節1_髪節_表示
		{
			get
			{
				return this.X0Y0_編節1_髪節.Dra;
			}
			set
			{
				this.X0Y0_編節1_髪節.Dra = value;
				this.X0Y0_編節1_髪節.Hit = value;
			}
		}

		public bool 編節1_髪編目_表示
		{
			get
			{
				return this.X0Y0_編節1_髪編目.Dra;
			}
			set
			{
				this.X0Y0_編節1_髪編目.Dra = value;
				this.X0Y0_編節1_髪編目.Hit = value;
			}
		}

		public bool 編節2_髪節_表示
		{
			get
			{
				return this.X0Y0_編節2_髪節.Dra;
			}
			set
			{
				this.X0Y0_編節2_髪節.Dra = value;
				this.X0Y0_編節2_髪節.Hit = value;
			}
		}

		public bool 編節2_髪編目_表示
		{
			get
			{
				return this.X0Y0_編節2_髪編目.Dra;
			}
			set
			{
				this.X0Y0_編節2_髪編目.Dra = value;
				this.X0Y0_編節2_髪編目.Hit = value;
			}
		}

		public bool 編節3_髪節_表示
		{
			get
			{
				return this.X0Y0_編節3_髪節.Dra;
			}
			set
			{
				this.X0Y0_編節3_髪節.Dra = value;
				this.X0Y0_編節3_髪節.Hit = value;
			}
		}

		public bool 編節3_髪編目_表示
		{
			get
			{
				return this.X0Y0_編節3_髪編目.Dra;
			}
			set
			{
				this.X0Y0_編節3_髪編目.Dra = value;
				this.X0Y0_編節3_髪編目.Hit = value;
			}
		}

		public bool 編節4_髪節_表示
		{
			get
			{
				return this.X0Y0_編節4_髪節.Dra;
			}
			set
			{
				this.X0Y0_編節4_髪節.Dra = value;
				this.X0Y0_編節4_髪節.Hit = value;
			}
		}

		public bool 編節4_髪編目_表示
		{
			get
			{
				return this.X0Y0_編節4_髪編目.Dra;
			}
			set
			{
				this.X0Y0_編節4_髪編目.Dra = value;
				this.X0Y0_編節4_髪編目.Hit = value;
			}
		}

		public bool 髪縛1_表示
		{
			get
			{
				return this.X0Y0_髪縛1.Dra;
			}
			set
			{
				this.X0Y0_髪縛1.Dra = value;
				this.X0Y0_髪縛1.Hit = value;
			}
		}

		public bool 髪縛2_表示
		{
			get
			{
				return this.X0Y0_髪縛2.Dra;
			}
			set
			{
				this.X0Y0_髪縛2.Dra = value;
				this.X0Y0_髪縛2.Hit = value;
			}
		}

		public bool 髪左_表示
		{
			get
			{
				return this.X0Y0_髪左.Dra;
			}
			set
			{
				this.X0Y0_髪左.Dra = value;
				this.X0Y0_髪左.Hit = value;
			}
		}

		public bool 髪右_表示
		{
			get
			{
				return this.X0Y0_髪右.Dra;
			}
			set
			{
				this.X0Y0_髪右.Dra = value;
				this.X0Y0_髪右.Hit = value;
			}
		}

		public bool 髪根_表示
		{
			get
			{
				return this.X0Y0_髪根.Dra;
			}
			set
			{
				this.X0Y0_髪根.Dra = value;
				this.X0Y0_髪根.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.髪_表示;
			}
			set
			{
				this.髪_表示 = value;
				this.編節1_髪節_表示 = value;
				this.編節1_髪編目_表示 = value;
				this.編節2_髪節_表示 = value;
				this.編節2_髪編目_表示 = value;
				this.編節3_髪節_表示 = value;
				this.編節3_髪編目_表示 = value;
				this.編節4_髪節_表示 = value;
				this.編節4_髪編目_表示 = value;
				this.髪縛1_表示 = value;
				this.髪縛2_表示 = value;
				this.髪左_表示 = value;
				this.髪右_表示 = value;
				this.髪根_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.髪CD.不透明度;
			}
			set
			{
				this.髪CD.不透明度 = value;
				this.編節1_髪節CD.不透明度 = value;
				this.編節1_髪編目CD.不透明度 = value;
				this.編節2_髪節CD.不透明度 = value;
				this.編節2_髪編目CD.不透明度 = value;
				this.編節3_髪節CD.不透明度 = value;
				this.編節3_髪編目CD.不透明度 = value;
				this.編節4_髪節CD.不透明度 = value;
				this.編節4_髪編目CD.不透明度 = value;
				this.髪縛1CD.不透明度 = value;
				this.髪縛2CD.不透明度 = value;
				this.髪左CD.不透明度 = value;
				this.髪右CD.不透明度 = value;
				this.髪根CD.不透明度 = value;
			}
		}

		public double 髪長1
		{
			set
			{
				double num = 0.8 + 0.3 * value;
				this.X0Y0_編節1_髪節.SizeYBase *= num;
				this.X0Y0_編節1_髪編目.SizeYBase *= num;
				this.X0Y0_編節2_髪節.SizeYBase *= num;
				this.X0Y0_編節2_髪編目.SizeYBase *= num;
				this.X0Y0_編節3_髪節.SizeYBase *= num;
				this.X0Y0_編節3_髪編目.SizeYBase *= num;
				this.X0Y0_編節4_髪節.SizeYBase *= num;
				this.X0Y0_編節4_髪編目.SizeYBase *= num;
			}
		}

		public double 髪長2
		{
			set
			{
				double num = 0.8 + 0.3 * value;
				this.X0Y0_髪左.SizeYBase *= num;
				this.X0Y0_髪右.SizeYBase *= num;
				this.X0Y0_髪根.SizeYBase *= num;
			}
		}

		public double 毛量
		{
			set
			{
				double num = 1.0 + 0.5 * value;
				this.X0Y0_編節1_髪節.SizeXBase *= num;
				this.X0Y0_編節1_髪編目.SizeXBase *= num;
				this.X0Y0_編節2_髪節.SizeXBase *= num;
				this.X0Y0_編節2_髪編目.SizeXBase *= num;
				this.X0Y0_編節3_髪節.SizeXBase *= num;
				this.X0Y0_編節3_髪編目.SizeXBase *= num;
				this.X0Y0_編節4_髪節.SizeXBase *= num;
				this.X0Y0_編節4_髪編目.SizeXBase *= num;
				this.X0Y0_髪縛1.SizeXBase *= num;
				this.X0Y0_髪縛2.SizeXBase *= num;
				this.X0Y0_髪左.SizeXBase *= num;
				this.X0Y0_髪右.SizeXBase *= num;
				this.X0Y0_髪根.SizeXBase *= num;
			}
		}

		public double 広がり
		{
			set
			{
				double num = this.右 ? -1.0 : 1.0;
				this.X0Y0_髪左.AngleBase = num * 3.0 * value;
				this.X0Y0_髪右.AngleBase = num * -3.0 * value;
			}
		}

		public override bool Is布(Par p)
		{
			return p == this.X0Y0_髪縛1 || p == this.X0Y0_髪縛2;
		}

		public override void 色更新()
		{
			this.X0Y0_髪CP.Update();
			this.X0Y0_編節1_髪節CP.Update();
			this.X0Y0_編節1_髪編目CP.Update();
			this.X0Y0_編節2_髪節CP.Update();
			this.X0Y0_編節2_髪編目CP.Update();
			this.X0Y0_編節3_髪節CP.Update();
			this.X0Y0_編節3_髪編目CP.Update();
			this.X0Y0_編節4_髪節CP.Update();
			this.X0Y0_編節4_髪編目CP.Update();
			this.X0Y0_髪縛1CP.Update();
			this.X0Y0_髪縛2CP.Update();
			this.X0Y0_髪左CP.Update();
			this.X0Y0_髪右CP.Update();
			this.X0Y0_髪根CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.髪CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.編節1_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.編節1_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.編節2_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.編節2_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.編節3_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.編節3_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.編節4_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.編節4_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪縛1CD = new ColorD();
			this.髪縛2CD = new ColorD();
			this.髪左CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪右CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪根CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		}

		public void 髪留配色(髪留色 配色)
		{
			this.髪縛1CD.色 = 配色.髪留1色;
			this.髪縛2CD.色 = 配色.髪留2色;
		}

		public Par X0Y0_髪;

		public Par X0Y0_編節1_髪節;

		public Par X0Y0_編節1_髪編目;

		public Par X0Y0_編節2_髪節;

		public Par X0Y0_編節2_髪編目;

		public Par X0Y0_編節3_髪節;

		public Par X0Y0_編節3_髪編目;

		public Par X0Y0_編節4_髪節;

		public Par X0Y0_編節4_髪編目;

		public Par X0Y0_髪縛1;

		public Par X0Y0_髪縛2;

		public Par X0Y0_髪左;

		public Par X0Y0_髪右;

		public Par X0Y0_髪根;

		public ColorD 髪CD;

		public ColorD 編節1_髪節CD;

		public ColorD 編節1_髪編目CD;

		public ColorD 編節2_髪節CD;

		public ColorD 編節2_髪編目CD;

		public ColorD 編節3_髪節CD;

		public ColorD 編節3_髪編目CD;

		public ColorD 編節4_髪節CD;

		public ColorD 編節4_髪編目CD;

		public ColorD 髪縛1CD;

		public ColorD 髪縛2CD;

		public ColorD 髪左CD;

		public ColorD 髪右CD;

		public ColorD 髪根CD;

		public ColorP X0Y0_髪CP;

		public ColorP X0Y0_編節1_髪節CP;

		public ColorP X0Y0_編節1_髪編目CP;

		public ColorP X0Y0_編節2_髪節CP;

		public ColorP X0Y0_編節2_髪編目CP;

		public ColorP X0Y0_編節3_髪節CP;

		public ColorP X0Y0_編節3_髪編目CP;

		public ColorP X0Y0_編節4_髪節CP;

		public ColorP X0Y0_編節4_髪編目CP;

		public ColorP X0Y0_髪縛1CP;

		public ColorP X0Y0_髪縛2CP;

		public ColorP X0Y0_髪左CP;

		public ColorP X0Y0_髪右CP;

		public ColorP X0Y0_髪根CP;
	}
}
