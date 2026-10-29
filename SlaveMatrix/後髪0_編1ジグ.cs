using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 後髪0_編1ジグ : お下げ1
	{
		public 後髪0_編1ジグ(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 後髪0_編1ジグD e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "編み1ジグ";
			dif.Add(new Pars(Sta.胴体["後髪0"][0][12]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_髪基 = pars["髪基"].ToPar();
			Pars pars2 = pars["お下げ"].ToPars();
			Pars pars3 = pars2["編節1"].ToPars();
			this.X0Y0_お下げ_編節1_髪節 = pars3["髪節"].ToPar();
			this.X0Y0_お下げ_編節1_髪編目 = pars3["髪編目"].ToPar();
			pars3 = pars2["編節2"].ToPars();
			this.X0Y0_お下げ_編節2_髪節 = pars3["髪節"].ToPar();
			this.X0Y0_お下げ_編節2_髪編目 = pars3["髪編目"].ToPar();
			pars3 = pars2["編節3"].ToPars();
			this.X0Y0_お下げ_編節3_髪節 = pars3["髪節"].ToPar();
			this.X0Y0_お下げ_編節3_髪編目 = pars3["髪編目"].ToPar();
			pars3 = pars2["編節4"].ToPars();
			this.X0Y0_お下げ_編節4_髪節 = pars3["髪節"].ToPar();
			this.X0Y0_お下げ_編節4_髪編目 = pars3["髪編目"].ToPar();
			pars3 = pars2["編節5"].ToPars();
			this.X0Y0_お下げ_編節5_髪節 = pars3["髪節"].ToPar();
			this.X0Y0_お下げ_編節5_髪編目 = pars3["髪編目"].ToPar();
			pars3 = pars2["編節6"].ToPars();
			this.X0Y0_お下げ_編節6_髪節 = pars3["髪節"].ToPar();
			this.X0Y0_お下げ_編節6_髪編目 = pars3["髪編目"].ToPar();
			pars3 = pars2["編節7"].ToPars();
			this.X0Y0_お下げ_編節7_髪節 = pars3["髪節"].ToPar();
			this.X0Y0_お下げ_編節7_髪編目 = pars3["髪編目"].ToPar();
			pars3 = pars2["編節8"].ToPars();
			this.X0Y0_お下げ_編節8_髪節 = pars3["髪節"].ToPar();
			this.X0Y0_お下げ_編節8_髪編目 = pars3["髪編目"].ToPar();
			this.X0Y0_お下げ_髪縛1 = pars2["髪縛1"].ToPar();
			this.X0Y0_お下げ_髪縛2 = pars2["髪縛2"].ToPar();
			this.X0Y0_お下げ_髪左1 = pars2["髪左1"].ToPar();
			this.X0Y0_お下げ_髪右1 = pars2["髪右1"].ToPar();
			this.X0Y0_お下げ_髪根 = pars2["髪根"].ToPar();
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
			this.お下げ_編節1_髪節_表示 = e.お下げ_編節1_髪節_表示;
			this.お下げ_編節1_髪編目_表示 = e.お下げ_編節1_髪編目_表示;
			this.お下げ_編節2_髪節_表示 = e.お下げ_編節2_髪節_表示;
			this.お下げ_編節2_髪編目_表示 = e.お下げ_編節2_髪編目_表示;
			this.お下げ_編節3_髪節_表示 = e.お下げ_編節3_髪節_表示;
			this.お下げ_編節3_髪編目_表示 = e.お下げ_編節3_髪編目_表示;
			this.お下げ_編節4_髪節_表示 = e.お下げ_編節4_髪節_表示;
			this.お下げ_編節4_髪編目_表示 = e.お下げ_編節4_髪編目_表示;
			this.お下げ_編節5_髪節_表示 = e.お下げ_編節5_髪節_表示;
			this.お下げ_編節5_髪編目_表示 = e.お下げ_編節5_髪編目_表示;
			this.お下げ_編節6_髪節_表示 = e.お下げ_編節6_髪節_表示;
			this.お下げ_編節6_髪編目_表示 = e.お下げ_編節6_髪編目_表示;
			this.お下げ_編節7_髪節_表示 = e.お下げ_編節7_髪節_表示;
			this.お下げ_編節7_髪編目_表示 = e.お下げ_編節7_髪編目_表示;
			this.お下げ_編節8_髪節_表示 = e.お下げ_編節8_髪節_表示;
			this.お下げ_編節8_髪編目_表示 = e.お下げ_編節8_髪編目_表示;
			this.お下げ_髪縛1_表示 = e.お下げ_髪縛1_表示;
			this.お下げ_髪縛2_表示 = e.お下げ_髪縛2_表示;
			this.お下げ_髪左1_表示 = e.お下げ_髪左1_表示;
			this.お下げ_髪右1_表示 = e.お下げ_髪右1_表示;
			this.お下げ_髪根_表示 = e.お下げ_髪根_表示;
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
			this.X0Y0_お下げ_編節1_髪節CP = new ColorP(this.X0Y0_お下げ_編節1_髪節, this.お下げ_編節1_髪節CD, DisUnit, false);
			this.X0Y0_お下げ_編節1_髪編目CP = new ColorP(this.X0Y0_お下げ_編節1_髪編目, this.お下げ_編節1_髪編目CD, DisUnit, false);
			this.X0Y0_お下げ_編節2_髪節CP = new ColorP(this.X0Y0_お下げ_編節2_髪節, this.お下げ_編節2_髪節CD, DisUnit, false);
			this.X0Y0_お下げ_編節2_髪編目CP = new ColorP(this.X0Y0_お下げ_編節2_髪編目, this.お下げ_編節2_髪編目CD, DisUnit, false);
			this.X0Y0_お下げ_編節3_髪節CP = new ColorP(this.X0Y0_お下げ_編節3_髪節, this.お下げ_編節3_髪節CD, DisUnit, false);
			this.X0Y0_お下げ_編節3_髪編目CP = new ColorP(this.X0Y0_お下げ_編節3_髪編目, this.お下げ_編節3_髪編目CD, DisUnit, false);
			this.X0Y0_お下げ_編節4_髪節CP = new ColorP(this.X0Y0_お下げ_編節4_髪節, this.お下げ_編節4_髪節CD, DisUnit, false);
			this.X0Y0_お下げ_編節4_髪編目CP = new ColorP(this.X0Y0_お下げ_編節4_髪編目, this.お下げ_編節4_髪編目CD, DisUnit, false);
			this.X0Y0_お下げ_編節5_髪節CP = new ColorP(this.X0Y0_お下げ_編節5_髪節, this.お下げ_編節5_髪節CD, DisUnit, false);
			this.X0Y0_お下げ_編節5_髪編目CP = new ColorP(this.X0Y0_お下げ_編節5_髪編目, this.お下げ_編節5_髪編目CD, DisUnit, false);
			this.X0Y0_お下げ_編節6_髪節CP = new ColorP(this.X0Y0_お下げ_編節6_髪節, this.お下げ_編節6_髪節CD, DisUnit, false);
			this.X0Y0_お下げ_編節6_髪編目CP = new ColorP(this.X0Y0_お下げ_編節6_髪編目, this.お下げ_編節6_髪編目CD, DisUnit, false);
			this.X0Y0_お下げ_編節7_髪節CP = new ColorP(this.X0Y0_お下げ_編節7_髪節, this.お下げ_編節7_髪節CD, DisUnit, false);
			this.X0Y0_お下げ_編節7_髪編目CP = new ColorP(this.X0Y0_お下げ_編節7_髪編目, this.お下げ_編節7_髪編目CD, DisUnit, false);
			this.X0Y0_お下げ_編節8_髪節CP = new ColorP(this.X0Y0_お下げ_編節8_髪節, this.お下げ_編節8_髪節CD, DisUnit, false);
			this.X0Y0_お下げ_編節8_髪編目CP = new ColorP(this.X0Y0_お下げ_編節8_髪編目, this.お下げ_編節8_髪編目CD, DisUnit, false);
			this.X0Y0_お下げ_髪縛1CP = new ColorP(this.X0Y0_お下げ_髪縛1, this.お下げ_髪縛1CD, DisUnit, true);
			this.X0Y0_お下げ_髪縛2CP = new ColorP(this.X0Y0_お下げ_髪縛2, this.お下げ_髪縛2CD, DisUnit, true);
			this.X0Y0_お下げ_髪左1CP = new ColorP(this.X0Y0_お下げ_髪左1, this.お下げ_髪左1CD, DisUnit, false);
			this.X0Y0_お下げ_髪右1CP = new ColorP(this.X0Y0_お下げ_髪右1, this.お下げ_髪右1CD, DisUnit, false);
			this.X0Y0_お下げ_髪根CP = new ColorP(this.X0Y0_お下げ_髪根, this.お下げ_髪根CD, DisUnit, false);
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

		public bool お下げ_編節1_髪節_表示
		{
			get
			{
				return this.X0Y0_お下げ_編節1_髪節.Dra;
			}
			set
			{
				this.X0Y0_お下げ_編節1_髪節.Dra = value;
				this.X0Y0_お下げ_編節1_髪節.Hit = value;
			}
		}

		public bool お下げ_編節1_髪編目_表示
		{
			get
			{
				return this.X0Y0_お下げ_編節1_髪編目.Dra;
			}
			set
			{
				this.X0Y0_お下げ_編節1_髪編目.Dra = value;
				this.X0Y0_お下げ_編節1_髪編目.Hit = value;
			}
		}

		public bool お下げ_編節2_髪節_表示
		{
			get
			{
				return this.X0Y0_お下げ_編節2_髪節.Dra;
			}
			set
			{
				this.X0Y0_お下げ_編節2_髪節.Dra = value;
				this.X0Y0_お下げ_編節2_髪節.Hit = value;
			}
		}

		public bool お下げ_編節2_髪編目_表示
		{
			get
			{
				return this.X0Y0_お下げ_編節2_髪編目.Dra;
			}
			set
			{
				this.X0Y0_お下げ_編節2_髪編目.Dra = value;
				this.X0Y0_お下げ_編節2_髪編目.Hit = value;
			}
		}

		public bool お下げ_編節3_髪節_表示
		{
			get
			{
				return this.X0Y0_お下げ_編節3_髪節.Dra;
			}
			set
			{
				this.X0Y0_お下げ_編節3_髪節.Dra = value;
				this.X0Y0_お下げ_編節3_髪節.Hit = value;
			}
		}

		public bool お下げ_編節3_髪編目_表示
		{
			get
			{
				return this.X0Y0_お下げ_編節3_髪編目.Dra;
			}
			set
			{
				this.X0Y0_お下げ_編節3_髪編目.Dra = value;
				this.X0Y0_お下げ_編節3_髪編目.Hit = value;
			}
		}

		public bool お下げ_編節4_髪節_表示
		{
			get
			{
				return this.X0Y0_お下げ_編節4_髪節.Dra;
			}
			set
			{
				this.X0Y0_お下げ_編節4_髪節.Dra = value;
				this.X0Y0_お下げ_編節4_髪節.Hit = value;
			}
		}

		public bool お下げ_編節4_髪編目_表示
		{
			get
			{
				return this.X0Y0_お下げ_編節4_髪編目.Dra;
			}
			set
			{
				this.X0Y0_お下げ_編節4_髪編目.Dra = value;
				this.X0Y0_お下げ_編節4_髪編目.Hit = value;
			}
		}

		public bool お下げ_編節5_髪節_表示
		{
			get
			{
				return this.X0Y0_お下げ_編節5_髪節.Dra;
			}
			set
			{
				this.X0Y0_お下げ_編節5_髪節.Dra = value;
				this.X0Y0_お下げ_編節5_髪節.Hit = value;
			}
		}

		public bool お下げ_編節5_髪編目_表示
		{
			get
			{
				return this.X0Y0_お下げ_編節5_髪編目.Dra;
			}
			set
			{
				this.X0Y0_お下げ_編節5_髪編目.Dra = value;
				this.X0Y0_お下げ_編節5_髪編目.Hit = value;
			}
		}

		public bool お下げ_編節6_髪節_表示
		{
			get
			{
				return this.X0Y0_お下げ_編節6_髪節.Dra;
			}
			set
			{
				this.X0Y0_お下げ_編節6_髪節.Dra = value;
				this.X0Y0_お下げ_編節6_髪節.Hit = value;
			}
		}

		public bool お下げ_編節6_髪編目_表示
		{
			get
			{
				return this.X0Y0_お下げ_編節6_髪編目.Dra;
			}
			set
			{
				this.X0Y0_お下げ_編節6_髪編目.Dra = value;
				this.X0Y0_お下げ_編節6_髪編目.Hit = value;
			}
		}

		public bool お下げ_編節7_髪節_表示
		{
			get
			{
				return this.X0Y0_お下げ_編節7_髪節.Dra;
			}
			set
			{
				this.X0Y0_お下げ_編節7_髪節.Dra = value;
				this.X0Y0_お下げ_編節7_髪節.Hit = value;
			}
		}

		public bool お下げ_編節7_髪編目_表示
		{
			get
			{
				return this.X0Y0_お下げ_編節7_髪編目.Dra;
			}
			set
			{
				this.X0Y0_お下げ_編節7_髪編目.Dra = value;
				this.X0Y0_お下げ_編節7_髪編目.Hit = value;
			}
		}

		public bool お下げ_編節8_髪節_表示
		{
			get
			{
				return this.X0Y0_お下げ_編節8_髪節.Dra;
			}
			set
			{
				this.X0Y0_お下げ_編節8_髪節.Dra = value;
				this.X0Y0_お下げ_編節8_髪節.Hit = value;
			}
		}

		public bool お下げ_編節8_髪編目_表示
		{
			get
			{
				return this.X0Y0_お下げ_編節8_髪編目.Dra;
			}
			set
			{
				this.X0Y0_お下げ_編節8_髪編目.Dra = value;
				this.X0Y0_お下げ_編節8_髪編目.Hit = value;
			}
		}

		public override bool お下げ_髪縛1_表示
		{
			get
			{
				return this.X0Y0_お下げ_髪縛1.Dra;
			}
			set
			{
				this.X0Y0_お下げ_髪縛1.Dra = value;
				this.X0Y0_お下げ_髪縛1.Hit = value;
			}
		}

		public override bool お下げ_髪縛2_表示
		{
			get
			{
				return this.X0Y0_お下げ_髪縛2.Dra;
			}
			set
			{
				this.X0Y0_お下げ_髪縛2.Dra = value;
				this.X0Y0_お下げ_髪縛2.Hit = value;
			}
		}

		public bool お下げ_髪左1_表示
		{
			get
			{
				return this.X0Y0_お下げ_髪左1.Dra;
			}
			set
			{
				this.X0Y0_お下げ_髪左1.Dra = value;
				this.X0Y0_お下げ_髪左1.Hit = value;
			}
		}

		public bool お下げ_髪右1_表示
		{
			get
			{
				return this.X0Y0_お下げ_髪右1.Dra;
			}
			set
			{
				this.X0Y0_お下げ_髪右1.Dra = value;
				this.X0Y0_お下げ_髪右1.Hit = value;
			}
		}

		public bool お下げ_髪根_表示
		{
			get
			{
				return this.X0Y0_お下げ_髪根.Dra;
			}
			set
			{
				this.X0Y0_お下げ_髪根.Dra = value;
				this.X0Y0_お下げ_髪根.Hit = value;
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
				this.お下げ_編節1_髪節_表示 = value;
				this.お下げ_編節1_髪編目_表示 = value;
				this.お下げ_編節2_髪節_表示 = value;
				this.お下げ_編節2_髪編目_表示 = value;
				this.お下げ_編節3_髪節_表示 = value;
				this.お下げ_編節3_髪編目_表示 = value;
				this.お下げ_編節4_髪節_表示 = value;
				this.お下げ_編節4_髪編目_表示 = value;
				this.お下げ_編節5_髪節_表示 = value;
				this.お下げ_編節5_髪編目_表示 = value;
				this.お下げ_編節6_髪節_表示 = value;
				this.お下げ_編節6_髪編目_表示 = value;
				this.お下げ_編節7_髪節_表示 = value;
				this.お下げ_編節7_髪編目_表示 = value;
				this.お下げ_編節8_髪節_表示 = value;
				this.お下げ_編節8_髪編目_表示 = value;
				this.お下げ_髪縛1_表示 = value;
				this.お下げ_髪縛2_表示 = value;
				this.お下げ_髪左1_表示 = value;
				this.お下げ_髪右1_表示 = value;
				this.お下げ_髪根_表示 = value;
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
				this.お下げ_編節1_髪節CD.不透明度 = value;
				this.お下げ_編節1_髪編目CD.不透明度 = value;
				this.お下げ_編節2_髪節CD.不透明度 = value;
				this.お下げ_編節2_髪編目CD.不透明度 = value;
				this.お下げ_編節3_髪節CD.不透明度 = value;
				this.お下げ_編節3_髪編目CD.不透明度 = value;
				this.お下げ_編節4_髪節CD.不透明度 = value;
				this.お下げ_編節4_髪編目CD.不透明度 = value;
				this.お下げ_編節5_髪節CD.不透明度 = value;
				this.お下げ_編節5_髪編目CD.不透明度 = value;
				this.お下げ_編節6_髪節CD.不透明度 = value;
				this.お下げ_編節6_髪編目CD.不透明度 = value;
				this.お下げ_編節7_髪節CD.不透明度 = value;
				this.お下げ_編節7_髪編目CD.不透明度 = value;
				this.お下げ_編節8_髪節CD.不透明度 = value;
				this.お下げ_編節8_髪編目CD.不透明度 = value;
				this.お下げ_髪縛1CD.不透明度 = value;
				this.お下げ_髪縛2CD.不透明度 = value;
				this.お下げ_髪左1CD.不透明度 = value;
				this.お下げ_髪右1CD.不透明度 = value;
				this.お下げ_髪根CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			double maxAngle = 25.0;
			this.X0Y0_お下げ_編節1_髪節.AngleBase = num * maxAngle.GetRanAngle();
			this.X0Y0_お下げ_編節2_髪節.AngleBase = num * maxAngle.GetRanAngle();
			this.X0Y0_お下げ_編節3_髪節.AngleBase = num * maxAngle.GetRanAngle();
			this.X0Y0_お下げ_編節4_髪節.AngleBase = num * maxAngle.GetRanAngle();
			this.X0Y0_お下げ_編節5_髪節.AngleBase = num * maxAngle.GetRanAngle();
			this.X0Y0_お下げ_編節6_髪節.AngleBase = num * maxAngle.GetRanAngle();
			this.X0Y0_お下げ_編節7_髪節.AngleBase = num * maxAngle.GetRanAngle();
			this.X0Y0_お下げ_髪根.AngleBase = num * maxAngle.GetRanAngle();
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
				this.X0Y0_お下げ_編節1_髪節.SizeYBase *= num;
				this.X0Y0_お下げ_編節1_髪編目.SizeYBase *= num;
				this.X0Y0_お下げ_編節2_髪節.SizeYBase *= num;
				this.X0Y0_お下げ_編節2_髪編目.SizeYBase *= num;
				this.X0Y0_お下げ_編節3_髪節.SizeYBase *= num;
				this.X0Y0_お下げ_編節3_髪編目.SizeYBase *= num;
				this.X0Y0_お下げ_編節4_髪節.SizeYBase *= num;
				this.X0Y0_お下げ_編節4_髪編目.SizeYBase *= num;
				this.X0Y0_お下げ_編節5_髪節.SizeYBase *= num;
				this.X0Y0_お下げ_編節5_髪編目.SizeYBase *= num;
				this.X0Y0_お下げ_編節6_髪節.SizeYBase *= num;
				this.X0Y0_お下げ_編節6_髪編目.SizeYBase *= num;
				this.X0Y0_お下げ_編節7_髪節.SizeYBase *= num;
				this.X0Y0_お下げ_編節7_髪編目.SizeYBase *= num;
				this.X0Y0_お下げ_編節8_髪節.SizeYBase *= num;
				this.X0Y0_お下げ_編節8_髪編目.SizeYBase *= num;
				this.X0Y0_お下げ_髪左1.SizeYBase *= num;
				this.X0Y0_お下げ_髪右1.SizeYBase *= num;
				this.X0Y0_お下げ_髪根.SizeYBase *= num;
			}
		}

		public double 毛量
		{
			set
			{
				double num = 1.0 + 0.5 * value;
				this.X0Y0_お下げ_編節1_髪節.SizeXBase *= num;
				this.X0Y0_お下げ_編節1_髪編目.SizeXBase *= num;
				this.X0Y0_お下げ_編節2_髪節.SizeXBase *= num;
				this.X0Y0_お下げ_編節2_髪編目.SizeXBase *= num;
				this.X0Y0_お下げ_編節3_髪節.SizeXBase *= num;
				this.X0Y0_お下げ_編節3_髪編目.SizeXBase *= num;
				this.X0Y0_お下げ_編節4_髪節.SizeXBase *= num;
				this.X0Y0_お下げ_編節4_髪編目.SizeXBase *= num;
				this.X0Y0_お下げ_編節5_髪節.SizeXBase *= num;
				this.X0Y0_お下げ_編節5_髪編目.SizeXBase *= num;
				this.X0Y0_お下げ_編節6_髪節.SizeXBase *= num;
				this.X0Y0_お下げ_編節6_髪編目.SizeXBase *= num;
				this.X0Y0_お下げ_編節7_髪節.SizeXBase *= num;
				this.X0Y0_お下げ_編節7_髪編目.SizeXBase *= num;
				this.X0Y0_お下げ_編節8_髪節.SizeXBase *= num;
				this.X0Y0_お下げ_編節8_髪編目.SizeXBase *= num;
				this.X0Y0_お下げ_髪縛1.SizeBase *= num;
				this.X0Y0_お下げ_髪縛2.SizeBase *= num;
				this.X0Y0_お下げ_髪左1.SizeXBase *= num;
				this.X0Y0_お下げ_髪右1.SizeXBase *= num;
				this.X0Y0_お下げ_髪根.SizeXBase *= num;
			}
		}

		public double 広がり
		{
			set
			{
				this.X0Y0_お下げ_髪左1.AngleBase = 3.0 * value;
				this.X0Y0_お下げ_髪右1.AngleBase = -3.0 * value;
			}
		}

		public void スライム()
		{
			this.X0Y0_髪基.OP[this.右 ? 1 : 0].Outline = false;
			this.X0Y0_髪基.OP[this.右 ? 0 : 1].Outline = false;
			this.X0Y0_お下げ_編節1_髪節.OP[this.右 ? 4 : 0].Outline = false;
			this.X0Y0_お下げ_編節1_髪節.OP[this.右 ? 3 : 1].Outline = false;
			this.X0Y0_お下げ_編節1_髪節.OP[this.右 ? 2 : 2].Outline = false;
			this.X0Y0_お下げ_編節1_髪節.OP[this.右 ? 1 : 3].Outline = false;
			this.X0Y0_お下げ_編節1_髪節.OP[this.右 ? 0 : 4].Outline = false;
			this.X0Y0_お下げ_編節1_髪編目.OP[this.右 ? 0 : 0].Outline = false;
			this.X0Y0_お下げ_編節2_髪節.OP[this.右 ? 4 : 0].Outline = false;
			this.X0Y0_お下げ_編節2_髪節.OP[this.右 ? 3 : 1].Outline = false;
			this.X0Y0_お下げ_編節2_髪節.OP[this.右 ? 2 : 2].Outline = false;
			this.X0Y0_お下げ_編節2_髪節.OP[this.右 ? 1 : 3].Outline = false;
			this.X0Y0_お下げ_編節2_髪節.OP[this.右 ? 0 : 4].Outline = false;
			this.X0Y0_お下げ_編節2_髪編目.OP[this.右 ? 0 : 0].Outline = false;
			this.X0Y0_お下げ_編節3_髪節.OP[this.右 ? 4 : 0].Outline = false;
			this.X0Y0_お下げ_編節3_髪節.OP[this.右 ? 3 : 1].Outline = false;
			this.X0Y0_お下げ_編節3_髪節.OP[this.右 ? 2 : 2].Outline = false;
			this.X0Y0_お下げ_編節3_髪節.OP[this.右 ? 1 : 3].Outline = false;
			this.X0Y0_お下げ_編節3_髪節.OP[this.右 ? 0 : 4].Outline = false;
			this.X0Y0_お下げ_編節3_髪編目.OP[this.右 ? 0 : 0].Outline = false;
			this.X0Y0_お下げ_編節4_髪節.OP[this.右 ? 4 : 0].Outline = false;
			this.X0Y0_お下げ_編節4_髪節.OP[this.右 ? 3 : 1].Outline = false;
			this.X0Y0_お下げ_編節4_髪節.OP[this.右 ? 2 : 2].Outline = false;
			this.X0Y0_お下げ_編節4_髪節.OP[this.右 ? 1 : 3].Outline = false;
			this.X0Y0_お下げ_編節4_髪節.OP[this.右 ? 0 : 4].Outline = false;
			this.X0Y0_お下げ_編節4_髪編目.OP[this.右 ? 0 : 0].Outline = false;
			this.X0Y0_お下げ_編節5_髪節.OP[this.右 ? 4 : 0].Outline = false;
			this.X0Y0_お下げ_編節5_髪節.OP[this.右 ? 3 : 1].Outline = false;
			this.X0Y0_お下げ_編節5_髪節.OP[this.右 ? 2 : 2].Outline = false;
			this.X0Y0_お下げ_編節5_髪節.OP[this.右 ? 1 : 3].Outline = false;
			this.X0Y0_お下げ_編節5_髪節.OP[this.右 ? 0 : 4].Outline = false;
			this.X0Y0_お下げ_編節5_髪編目.OP[this.右 ? 0 : 0].Outline = false;
			this.X0Y0_お下げ_編節6_髪節.OP[this.右 ? 4 : 0].Outline = false;
			this.X0Y0_お下げ_編節6_髪節.OP[this.右 ? 3 : 1].Outline = false;
			this.X0Y0_お下げ_編節6_髪節.OP[this.右 ? 2 : 2].Outline = false;
			this.X0Y0_お下げ_編節6_髪節.OP[this.右 ? 1 : 3].Outline = false;
			this.X0Y0_お下げ_編節6_髪節.OP[this.右 ? 0 : 4].Outline = false;
			this.X0Y0_お下げ_編節6_髪編目.OP[this.右 ? 0 : 0].Outline = false;
			this.X0Y0_お下げ_編節7_髪節.OP[this.右 ? 4 : 0].Outline = false;
			this.X0Y0_お下げ_編節7_髪節.OP[this.右 ? 3 : 1].Outline = false;
			this.X0Y0_お下げ_編節7_髪節.OP[this.右 ? 2 : 2].Outline = false;
			this.X0Y0_お下げ_編節7_髪節.OP[this.右 ? 1 : 3].Outline = false;
			this.X0Y0_お下げ_編節7_髪節.OP[this.右 ? 0 : 4].Outline = false;
			this.X0Y0_お下げ_編節7_髪編目.OP[this.右 ? 0 : 0].Outline = false;
			this.X0Y0_お下げ_編節8_髪節.OP[this.右 ? 4 : 0].Outline = false;
			this.X0Y0_お下げ_編節8_髪節.OP[this.右 ? 3 : 1].Outline = false;
			this.X0Y0_お下げ_編節8_髪節.OP[this.右 ? 2 : 2].Outline = false;
			this.X0Y0_お下げ_編節8_髪節.OP[this.右 ? 1 : 3].Outline = false;
			this.X0Y0_お下げ_編節8_髪節.OP[this.右 ? 0 : 4].Outline = false;
			this.X0Y0_お下げ_編節8_髪編目.OP[this.右 ? 0 : 0].Outline = false;
			this.X0Y0_お下げ_髪縛1.OP[this.右 ? 0 : 0].Outline = false;
			this.X0Y0_お下げ_髪縛2.OP[this.右 ? 0 : 0].Outline = false;
			this.X0Y0_お下げ_髪左1.OP[this.右 ? 4 : 0].Outline = false;
			this.X0Y0_お下げ_髪左1.OP[this.右 ? 3 : 1].Outline = false;
			this.X0Y0_お下げ_髪左1.OP[this.右 ? 2 : 2].Outline = false;
			this.X0Y0_お下げ_髪左1.OP[this.右 ? 1 : 3].Outline = false;
			this.X0Y0_お下げ_髪左1.OP[this.右 ? 0 : 4].Outline = false;
			this.X0Y0_お下げ_髪右1.OP[this.右 ? 4 : 0].Outline = false;
			this.X0Y0_お下げ_髪右1.OP[this.右 ? 3 : 1].Outline = false;
			this.X0Y0_お下げ_髪右1.OP[this.右 ? 2 : 2].Outline = false;
			this.X0Y0_お下げ_髪右1.OP[this.右 ? 1 : 3].Outline = false;
			this.X0Y0_お下げ_髪右1.OP[this.右 ? 0 : 4].Outline = false;
			this.X0Y0_お下げ_髪根.OP[this.右 ? 4 : 0].Outline = false;
			this.X0Y0_お下げ_髪根.OP[this.右 ? 3 : 1].Outline = false;
			this.X0Y0_お下げ_髪根.OP[this.右 ? 2 : 2].Outline = false;
			this.X0Y0_お下げ_髪根.OP[this.右 ? 1 : 3].Outline = false;
			this.X0Y0_お下げ_髪根.OP[this.右 ? 0 : 4].Outline = false;
		}

		public override bool Is布(Par p)
		{
			return p == this.X0Y0_お下げ_髪縛1 || p == this.X0Y0_お下げ_髪縛2;
		}

		public override void 色更新()
		{
			this.X0Y0_髪基CP.Update();
			this.X0Y0_お下げ_編節1_髪節CP.Update();
			this.X0Y0_お下げ_編節1_髪編目CP.Update();
			this.X0Y0_お下げ_編節2_髪節CP.Update();
			this.X0Y0_お下げ_編節2_髪編目CP.Update();
			this.X0Y0_お下げ_編節3_髪節CP.Update();
			this.X0Y0_お下げ_編節3_髪編目CP.Update();
			this.X0Y0_お下げ_編節4_髪節CP.Update();
			this.X0Y0_お下げ_編節4_髪編目CP.Update();
			this.X0Y0_お下げ_編節5_髪節CP.Update();
			this.X0Y0_お下げ_編節5_髪編目CP.Update();
			this.X0Y0_お下げ_編節6_髪節CP.Update();
			this.X0Y0_お下げ_編節6_髪編目CP.Update();
			this.X0Y0_お下げ_編節7_髪節CP.Update();
			this.X0Y0_お下げ_編節7_髪編目CP.Update();
			this.X0Y0_お下げ_編節8_髪節CP.Update();
			this.X0Y0_お下げ_編節8_髪編目CP.Update();
			this.X0Y0_お下げ_髪縛1CP.Update();
			this.X0Y0_お下げ_髪縛2CP.Update();
			this.X0Y0_お下げ_髪左1CP.Update();
			this.X0Y0_お下げ_髪右1CP.Update();
			this.X0Y0_お下げ_髪根CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.髪基CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ_編節1_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ_編節1_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ_編節2_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ_編節2_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ_編節3_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ_編節3_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ_編節4_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ_編節4_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ_編節5_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ_編節5_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ_編節6_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ_編節6_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ_編節7_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ_編節7_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ_編節8_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ_編節8_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ_髪縛1CD = new ColorD();
			this.お下げ_髪縛2CD = new ColorD();
			this.お下げ_髪左1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ_髪右1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.お下げ_髪根CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		}

		public override void 髪留配色(髪留色 配色)
		{
			this.お下げ_髪縛1CD.色 = 配色.髪留1色;
			this.お下げ_髪縛2CD.色 = 配色.髪留2色;
		}

		public Par X0Y0_髪基;

		public Par X0Y0_お下げ_編節1_髪節;

		public Par X0Y0_お下げ_編節1_髪編目;

		public Par X0Y0_お下げ_編節2_髪節;

		public Par X0Y0_お下げ_編節2_髪編目;

		public Par X0Y0_お下げ_編節3_髪節;

		public Par X0Y0_お下げ_編節3_髪編目;

		public Par X0Y0_お下げ_編節4_髪節;

		public Par X0Y0_お下げ_編節4_髪編目;

		public Par X0Y0_お下げ_編節5_髪節;

		public Par X0Y0_お下げ_編節5_髪編目;

		public Par X0Y0_お下げ_編節6_髪節;

		public Par X0Y0_お下げ_編節6_髪編目;

		public Par X0Y0_お下げ_編節7_髪節;

		public Par X0Y0_お下げ_編節7_髪編目;

		public Par X0Y0_お下げ_編節8_髪節;

		public Par X0Y0_お下げ_編節8_髪編目;

		public Par X0Y0_お下げ_髪縛1;

		public Par X0Y0_お下げ_髪縛2;

		public Par X0Y0_お下げ_髪左1;

		public Par X0Y0_お下げ_髪右1;

		public Par X0Y0_お下げ_髪根;

		public ColorD 髪基CD;

		public ColorD お下げ_編節1_髪節CD;

		public ColorD お下げ_編節1_髪編目CD;

		public ColorD お下げ_編節2_髪節CD;

		public ColorD お下げ_編節2_髪編目CD;

		public ColorD お下げ_編節3_髪節CD;

		public ColorD お下げ_編節3_髪編目CD;

		public ColorD お下げ_編節4_髪節CD;

		public ColorD お下げ_編節4_髪編目CD;

		public ColorD お下げ_編節5_髪節CD;

		public ColorD お下げ_編節5_髪編目CD;

		public ColorD お下げ_編節6_髪節CD;

		public ColorD お下げ_編節6_髪編目CD;

		public ColorD お下げ_編節7_髪節CD;

		public ColorD お下げ_編節7_髪編目CD;

		public ColorD お下げ_編節8_髪節CD;

		public ColorD お下げ_編節8_髪編目CD;

		public ColorD お下げ_髪縛1CD;

		public ColorD お下げ_髪縛2CD;

		public ColorD お下げ_髪左1CD;

		public ColorD お下げ_髪右1CD;

		public ColorD お下げ_髪根CD;

		public ColorP X0Y0_髪基CP;

		public ColorP X0Y0_お下げ_編節1_髪節CP;

		public ColorP X0Y0_お下げ_編節1_髪編目CP;

		public ColorP X0Y0_お下げ_編節2_髪節CP;

		public ColorP X0Y0_お下げ_編節2_髪編目CP;

		public ColorP X0Y0_お下げ_編節3_髪節CP;

		public ColorP X0Y0_お下げ_編節3_髪編目CP;

		public ColorP X0Y0_お下げ_編節4_髪節CP;

		public ColorP X0Y0_お下げ_編節4_髪編目CP;

		public ColorP X0Y0_お下げ_編節5_髪節CP;

		public ColorP X0Y0_お下げ_編節5_髪編目CP;

		public ColorP X0Y0_お下げ_編節6_髪節CP;

		public ColorP X0Y0_お下げ_編節6_髪編目CP;

		public ColorP X0Y0_お下げ_編節7_髪節CP;

		public ColorP X0Y0_お下げ_編節7_髪編目CP;

		public ColorP X0Y0_お下げ_編節8_髪節CP;

		public ColorP X0Y0_お下げ_編節8_髪編目CP;

		public ColorP X0Y0_お下げ_髪縛1CP;

		public ColorP X0Y0_お下げ_髪縛2CP;

		public ColorP X0Y0_お下げ_髪左1CP;

		public ColorP X0Y0_お下げ_髪右1CP;

		public ColorP X0Y0_お下げ_髪根CP;
	}
}
