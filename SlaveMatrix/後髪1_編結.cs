using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 後髪1_編結 : アップ
	{
		public 後髪1_編結(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 後髪1_編結D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "編結";
			dif.Add(new Pars(Sta.胴体["後髪0"][0][20]));
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
			this.毛量 = e.毛量;
			this.高さ = e.高さ;
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
			}
		}

		public override void Set角度0()
		{
			bool 右 = this.右;
			this.本体.JoinPAall();
		}

		public double 毛量
		{
			set
			{
				double num = 0.8 + 0.4 * value;
				this.X0Y0_髪基.SizeBase *= num;
				this.X0Y0_お下げ_編節1_髪節.SizeBase *= num;
				this.X0Y0_お下げ_編節1_髪編目.SizeBase *= num;
				this.X0Y0_お下げ_編節2_髪節.SizeBase *= num;
				this.X0Y0_お下げ_編節2_髪編目.SizeBase *= num;
				this.X0Y0_お下げ_編節3_髪節.SizeBase *= num;
				this.X0Y0_お下げ_編節3_髪編目.SizeBase *= num;
				this.X0Y0_お下げ_編節4_髪節.SizeBase *= num;
				this.X0Y0_お下げ_編節4_髪編目.SizeBase *= num;
				this.X0Y0_お下げ_編節5_髪節.SizeBase *= num;
				this.X0Y0_お下げ_編節5_髪編目.SizeBase *= num;
				this.X0Y0_お下げ_編節6_髪節.SizeBase *= num;
				this.X0Y0_お下げ_編節6_髪編目.SizeBase *= num;
				this.X0Y0_お下げ_編節7_髪節.SizeBase *= num;
				this.X0Y0_お下げ_編節7_髪編目.SizeBase *= num;
			}
		}

		public double 高さ
		{
			set
			{
				this.X0Y0_髪基.PositionCont = new Vector2D(this.X0Y0_髪基.PositionCont.X, this.X0Y0_髪基.PositionCont.Y + 0.02 * value.Inverse());
			}
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
	}
}
