using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 前髪_上げ短2 : 前髪
	{
		public 前髪_上げ短2(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 前髪_上げ短2D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "上げ短2";
			dif.Add(new Pars(Sta.胴体["前髪"][0][13]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_髪基 = pars["髪基"].ToPar();
			this.X0Y0_髪左1 = pars["髪左1"].ToPar();
			this.X0Y0_髪左2 = pars["髪左2"].ToPar();
			this.X0Y0_ハイライト左 = pars["ハイライト左"].ToPar();
			this.X0Y0_髪右1 = pars["髪右1"].ToPar();
			this.X0Y0_髪右2 = pars["髪右2"].ToPar();
			this.X0Y0_ハイライト右 = pars["ハイライト右"].ToPar();
			this.X0Y0_髪左根1 = pars["髪左根1"].ToPar();
			this.X0Y0_髪左根2 = pars["髪左根2"].ToPar();
			Pars pars2 = pars["編み左"].ToPars();
			Pars pars3 = pars2["編節1"].ToPars();
			this.X0Y0_編み左_編節1_髪節 = pars3["髪節"].ToPar();
			this.X0Y0_編み左_編節1_髪編目 = pars3["髪編目"].ToPar();
			pars3 = pars2["編節2"].ToPars();
			this.X0Y0_編み左_編節2_髪節 = pars3["髪節"].ToPar();
			this.X0Y0_編み左_編節2_髪編目 = pars3["髪編目"].ToPar();
			pars3 = pars2["編節3"].ToPars();
			this.X0Y0_編み左_編節3_髪節 = pars3["髪節"].ToPar();
			this.X0Y0_編み左_編節3_髪編目 = pars3["髪編目"].ToPar();
			this.X0Y0_髪ハネ左 = pars["髪ハネ左"].ToPar();
			this.X0Y0_髪左3 = pars["髪左3"].ToPar();
			this.X0Y0_髪左4 = pars["髪左4"].ToPar();
			this.X0Y0_髪右根1 = pars["髪右根1"].ToPar();
			this.X0Y0_髪右根2 = pars["髪右根2"].ToPar();
			Pars pars4 = pars["編み右"].ToPars();
			pars3 = pars4["編節1"].ToPars();
			this.X0Y0_編み右_編節1_髪節 = pars3["髪節"].ToPar();
			this.X0Y0_編み右_編節1_髪編目 = pars3["髪編目"].ToPar();
			pars3 = pars4["編節2"].ToPars();
			this.X0Y0_編み右_編節2_髪節 = pars3["髪節"].ToPar();
			this.X0Y0_編み右_編節2_髪編目 = pars3["髪編目"].ToPar();
			pars3 = pars4["編節3"].ToPars();
			this.X0Y0_編み右_編節3_髪節 = pars3["髪節"].ToPar();
			this.X0Y0_編み右_編節3_髪編目 = pars3["髪編目"].ToPar();
			this.X0Y0_髪ハネ右 = pars["髪ハネ右"].ToPar();
			this.X0Y0_髪右3 = pars["髪右3"].ToPar();
			this.X0Y0_髪右4 = pars["髪右4"].ToPar();
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
			this.髪左1_表示 = e.髪左1_表示;
			this.髪左2_表示 = e.髪左2_表示;
			this.ハイライト左_表示 = e.ハイライト左_表示;
			this.髪右1_表示 = e.髪右1_表示;
			this.髪右2_表示 = e.髪右2_表示;
			this.ハイライト右_表示 = e.ハイライト右_表示;
			this.髪左根1_表示 = e.髪左根1_表示;
			this.髪左根2_表示 = e.髪左根2_表示;
			this.編み左_編節1_髪節_表示 = e.編み左_編節1_髪節_表示;
			this.編み左_編節1_髪編目_表示 = e.編み左_編節1_髪編目_表示;
			this.編み左_編節2_髪節_表示 = e.編み左_編節2_髪節_表示;
			this.編み左_編節2_髪編目_表示 = e.編み左_編節2_髪編目_表示;
			this.編み左_編節3_髪節_表示 = e.編み左_編節3_髪節_表示;
			this.編み左_編節3_髪編目_表示 = e.編み左_編節3_髪編目_表示;
			this.髪ハネ左_表示 = e.髪ハネ左_表示;
			this.髪左3_表示 = e.髪左3_表示;
			this.髪左4_表示 = e.髪左4_表示;
			this.髪右根1_表示 = e.髪右根1_表示;
			this.髪右根2_表示 = e.髪右根2_表示;
			this.編み右_編節1_髪節_表示 = e.編み右_編節1_髪節_表示;
			this.編み右_編節1_髪編目_表示 = e.編み右_編節1_髪編目_表示;
			this.編み右_編節2_髪節_表示 = e.編み右_編節2_髪節_表示;
			this.編み右_編節2_髪編目_表示 = e.編み右_編節2_髪編目_表示;
			this.編み右_編節3_髪節_表示 = e.編み右_編節3_髪節_表示;
			this.編み右_編節3_髪編目_表示 = e.編み右_編節3_髪編目_表示;
			this.髪ハネ右_表示 = e.髪ハネ右_表示;
			this.髪右3_表示 = e.髪右3_表示;
			this.髪右4_表示 = e.髪右4_表示;
			this.編み左表示 = e.編み左表示;
			this.編み右表示 = e.編み右表示;
			this.ハイライト表示 = e.ハイライト表示;
			this.髪長 = e.髪長;
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
			this.X0Y0_髪左1CP = new ColorP(this.X0Y0_髪左1, this.髪左1CD, DisUnit, false);
			this.X0Y0_髪左2CP = new ColorP(this.X0Y0_髪左2, this.髪左2CD, DisUnit, false);
			this.X0Y0_ハイライト左CP = new ColorP(this.X0Y0_ハイライト左, this.ハイライト左CD, DisUnit, false);
			this.X0Y0_髪右1CP = new ColorP(this.X0Y0_髪右1, this.髪右1CD, DisUnit, false);
			this.X0Y0_髪右2CP = new ColorP(this.X0Y0_髪右2, this.髪右2CD, DisUnit, false);
			this.X0Y0_ハイライト右CP = new ColorP(this.X0Y0_ハイライト右, this.ハイライト右CD, DisUnit, false);
			this.X0Y0_髪左根1CP = new ColorP(this.X0Y0_髪左根1, this.髪左根1CD, DisUnit, false);
			this.X0Y0_髪左根2CP = new ColorP(this.X0Y0_髪左根2, this.髪左根2CD, DisUnit, false);
			this.X0Y0_編み左_編節1_髪節CP = new ColorP(this.X0Y0_編み左_編節1_髪節, this.編み左_編節1_髪節CD, DisUnit, false);
			this.X0Y0_編み左_編節1_髪編目CP = new ColorP(this.X0Y0_編み左_編節1_髪編目, this.編み左_編節1_髪編目CD, DisUnit, false);
			this.X0Y0_編み左_編節2_髪節CP = new ColorP(this.X0Y0_編み左_編節2_髪節, this.編み左_編節2_髪節CD, DisUnit, false);
			this.X0Y0_編み左_編節2_髪編目CP = new ColorP(this.X0Y0_編み左_編節2_髪編目, this.編み左_編節2_髪編目CD, DisUnit, false);
			this.X0Y0_編み左_編節3_髪節CP = new ColorP(this.X0Y0_編み左_編節3_髪節, this.編み左_編節3_髪節CD, DisUnit, false);
			this.X0Y0_編み左_編節3_髪編目CP = new ColorP(this.X0Y0_編み左_編節3_髪編目, this.編み左_編節3_髪編目CD, DisUnit, false);
			this.X0Y0_髪ハネ左CP = new ColorP(this.X0Y0_髪ハネ左, this.髪ハネ左CD, DisUnit, false);
			this.X0Y0_髪左3CP = new ColorP(this.X0Y0_髪左3, this.髪左3CD, DisUnit, false);
			this.X0Y0_髪左4CP = new ColorP(this.X0Y0_髪左4, this.髪左4CD, DisUnit, false);
			this.X0Y0_髪右根1CP = new ColorP(this.X0Y0_髪右根1, this.髪右根1CD, DisUnit, false);
			this.X0Y0_髪右根2CP = new ColorP(this.X0Y0_髪右根2, this.髪右根2CD, DisUnit, false);
			this.X0Y0_編み右_編節1_髪節CP = new ColorP(this.X0Y0_編み右_編節1_髪節, this.編み右_編節1_髪節CD, DisUnit, false);
			this.X0Y0_編み右_編節1_髪編目CP = new ColorP(this.X0Y0_編み右_編節1_髪編目, this.編み右_編節1_髪編目CD, DisUnit, false);
			this.X0Y0_編み右_編節2_髪節CP = new ColorP(this.X0Y0_編み右_編節2_髪節, this.編み右_編節2_髪節CD, DisUnit, false);
			this.X0Y0_編み右_編節2_髪編目CP = new ColorP(this.X0Y0_編み右_編節2_髪編目, this.編み右_編節2_髪編目CD, DisUnit, false);
			this.X0Y0_編み右_編節3_髪節CP = new ColorP(this.X0Y0_編み右_編節3_髪節, this.編み右_編節3_髪節CD, DisUnit, false);
			this.X0Y0_編み右_編節3_髪編目CP = new ColorP(this.X0Y0_編み右_編節3_髪編目, this.編み右_編節3_髪編目CD, DisUnit, false);
			this.X0Y0_髪ハネ右CP = new ColorP(this.X0Y0_髪ハネ右, this.髪ハネ右CD, DisUnit, false);
			this.X0Y0_髪右3CP = new ColorP(this.X0Y0_髪右3, this.髪右3CD, DisUnit, false);
			this.X0Y0_髪右4CP = new ColorP(this.X0Y0_髪右4, this.髪右4CD, DisUnit, false);
			this.ハイライト濃度 = e.ハイライト濃度;
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

		public bool 髪左1_表示
		{
			get
			{
				return this.X0Y0_髪左1.Dra;
			}
			set
			{
				this.X0Y0_髪左1.Dra = value;
				this.X0Y0_髪左1.Hit = value;
			}
		}

		public bool 髪左2_表示
		{
			get
			{
				return this.X0Y0_髪左2.Dra;
			}
			set
			{
				this.X0Y0_髪左2.Dra = value;
				this.X0Y0_髪左2.Hit = value;
			}
		}

		public bool ハイライト左_表示
		{
			get
			{
				return this.X0Y0_ハイライト左.Dra;
			}
			set
			{
				this.X0Y0_ハイライト左.Dra = value;
				this.X0Y0_ハイライト左.Hit = value;
			}
		}

		public bool 髪右1_表示
		{
			get
			{
				return this.X0Y0_髪右1.Dra;
			}
			set
			{
				this.X0Y0_髪右1.Dra = value;
				this.X0Y0_髪右1.Hit = value;
			}
		}

		public bool 髪右2_表示
		{
			get
			{
				return this.X0Y0_髪右2.Dra;
			}
			set
			{
				this.X0Y0_髪右2.Dra = value;
				this.X0Y0_髪右2.Hit = value;
			}
		}

		public bool ハイライト右_表示
		{
			get
			{
				return this.X0Y0_ハイライト右.Dra;
			}
			set
			{
				this.X0Y0_ハイライト右.Dra = value;
				this.X0Y0_ハイライト右.Hit = value;
			}
		}

		public bool 髪左根1_表示
		{
			get
			{
				return this.X0Y0_髪左根1.Dra;
			}
			set
			{
				this.X0Y0_髪左根1.Dra = value;
				this.X0Y0_髪左根1.Hit = value;
			}
		}

		public bool 髪左根2_表示
		{
			get
			{
				return this.X0Y0_髪左根2.Dra;
			}
			set
			{
				this.X0Y0_髪左根2.Dra = value;
				this.X0Y0_髪左根2.Hit = value;
			}
		}

		public bool 編み左_編節1_髪節_表示
		{
			get
			{
				return this.X0Y0_編み左_編節1_髪節.Dra;
			}
			set
			{
				this.X0Y0_編み左_編節1_髪節.Dra = value;
				this.X0Y0_編み左_編節1_髪節.Hit = value;
			}
		}

		public bool 編み左_編節1_髪編目_表示
		{
			get
			{
				return this.X0Y0_編み左_編節1_髪編目.Dra;
			}
			set
			{
				this.X0Y0_編み左_編節1_髪編目.Dra = value;
				this.X0Y0_編み左_編節1_髪編目.Hit = value;
			}
		}

		public bool 編み左_編節2_髪節_表示
		{
			get
			{
				return this.X0Y0_編み左_編節2_髪節.Dra;
			}
			set
			{
				this.X0Y0_編み左_編節2_髪節.Dra = value;
				this.X0Y0_編み左_編節2_髪節.Hit = value;
			}
		}

		public bool 編み左_編節2_髪編目_表示
		{
			get
			{
				return this.X0Y0_編み左_編節2_髪編目.Dra;
			}
			set
			{
				this.X0Y0_編み左_編節2_髪編目.Dra = value;
				this.X0Y0_編み左_編節2_髪編目.Hit = value;
			}
		}

		public bool 編み左_編節3_髪節_表示
		{
			get
			{
				return this.X0Y0_編み左_編節3_髪節.Dra;
			}
			set
			{
				this.X0Y0_編み左_編節3_髪節.Dra = value;
				this.X0Y0_編み左_編節3_髪節.Hit = value;
			}
		}

		public bool 編み左_編節3_髪編目_表示
		{
			get
			{
				return this.X0Y0_編み左_編節3_髪編目.Dra;
			}
			set
			{
				this.X0Y0_編み左_編節3_髪編目.Dra = value;
				this.X0Y0_編み左_編節3_髪編目.Hit = value;
			}
		}

		public bool 髪ハネ左_表示
		{
			get
			{
				return this.X0Y0_髪ハネ左.Dra;
			}
			set
			{
				this.X0Y0_髪ハネ左.Dra = value;
				this.X0Y0_髪ハネ左.Hit = value;
			}
		}

		public bool 髪左3_表示
		{
			get
			{
				return this.X0Y0_髪左3.Dra;
			}
			set
			{
				this.X0Y0_髪左3.Dra = value;
				this.X0Y0_髪左3.Hit = value;
			}
		}

		public bool 髪左4_表示
		{
			get
			{
				return this.X0Y0_髪左4.Dra;
			}
			set
			{
				this.X0Y0_髪左4.Dra = value;
				this.X0Y0_髪左4.Hit = value;
			}
		}

		public bool 髪右根1_表示
		{
			get
			{
				return this.X0Y0_髪右根1.Dra;
			}
			set
			{
				this.X0Y0_髪右根1.Dra = value;
				this.X0Y0_髪右根1.Hit = value;
			}
		}

		public bool 髪右根2_表示
		{
			get
			{
				return this.X0Y0_髪右根2.Dra;
			}
			set
			{
				this.X0Y0_髪右根2.Dra = value;
				this.X0Y0_髪右根2.Hit = value;
			}
		}

		public bool 編み右_編節1_髪節_表示
		{
			get
			{
				return this.X0Y0_編み右_編節1_髪節.Dra;
			}
			set
			{
				this.X0Y0_編み右_編節1_髪節.Dra = value;
				this.X0Y0_編み右_編節1_髪節.Hit = value;
			}
		}

		public bool 編み右_編節1_髪編目_表示
		{
			get
			{
				return this.X0Y0_編み右_編節1_髪編目.Dra;
			}
			set
			{
				this.X0Y0_編み右_編節1_髪編目.Dra = value;
				this.X0Y0_編み右_編節1_髪編目.Hit = value;
			}
		}

		public bool 編み右_編節2_髪節_表示
		{
			get
			{
				return this.X0Y0_編み右_編節2_髪節.Dra;
			}
			set
			{
				this.X0Y0_編み右_編節2_髪節.Dra = value;
				this.X0Y0_編み右_編節2_髪節.Hit = value;
			}
		}

		public bool 編み右_編節2_髪編目_表示
		{
			get
			{
				return this.X0Y0_編み右_編節2_髪編目.Dra;
			}
			set
			{
				this.X0Y0_編み右_編節2_髪編目.Dra = value;
				this.X0Y0_編み右_編節2_髪編目.Hit = value;
			}
		}

		public bool 編み右_編節3_髪節_表示
		{
			get
			{
				return this.X0Y0_編み右_編節3_髪節.Dra;
			}
			set
			{
				this.X0Y0_編み右_編節3_髪節.Dra = value;
				this.X0Y0_編み右_編節3_髪節.Hit = value;
			}
		}

		public bool 編み右_編節3_髪編目_表示
		{
			get
			{
				return this.X0Y0_編み右_編節3_髪編目.Dra;
			}
			set
			{
				this.X0Y0_編み右_編節3_髪編目.Dra = value;
				this.X0Y0_編み右_編節3_髪編目.Hit = value;
			}
		}

		public bool 髪ハネ右_表示
		{
			get
			{
				return this.X0Y0_髪ハネ右.Dra;
			}
			set
			{
				this.X0Y0_髪ハネ右.Dra = value;
				this.X0Y0_髪ハネ右.Hit = value;
			}
		}

		public bool 髪右3_表示
		{
			get
			{
				return this.X0Y0_髪右3.Dra;
			}
			set
			{
				this.X0Y0_髪右3.Dra = value;
				this.X0Y0_髪右3.Hit = value;
			}
		}

		public bool 髪右4_表示
		{
			get
			{
				return this.X0Y0_髪右4.Dra;
			}
			set
			{
				this.X0Y0_髪右4.Dra = value;
				this.X0Y0_髪右4.Hit = value;
			}
		}

		public bool 編み左表示
		{
			get
			{
				return this.編み左_編節1_髪節_表示;
			}
			set
			{
				this.編み左_編節1_髪節_表示 = value;
				this.編み左_編節1_髪編目_表示 = value;
				this.編み左_編節2_髪節_表示 = value;
				this.編み左_編節2_髪編目_表示 = value;
				this.編み左_編節3_髪節_表示 = value;
				this.編み左_編節3_髪編目_表示 = value;
			}
		}

		public bool 編み右表示
		{
			get
			{
				return this.編み右_編節1_髪節_表示;
			}
			set
			{
				this.編み右_編節1_髪節_表示 = value;
				this.編み右_編節1_髪編目_表示 = value;
				this.編み右_編節2_髪節_表示 = value;
				this.編み右_編節2_髪編目_表示 = value;
				this.編み右_編節3_髪節_表示 = value;
				this.編み右_編節3_髪編目_表示 = value;
			}
		}

		public bool ハイライト表示
		{
			get
			{
				return this.ハイライト左_表示;
			}
			set
			{
				this.ハイライト左_表示 = value;
				this.ハイライト右_表示 = value;
			}
		}

		public double ハイライト濃度
		{
			get
			{
				return this.ハイライト左CD.不透明度;
			}
			set
			{
				this.ハイライト左CD.不透明度 = value;
				this.ハイライト右CD.不透明度 = value;
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
				this.髪左1_表示 = value;
				this.髪左2_表示 = value;
				this.ハイライト左_表示 = value;
				this.髪右1_表示 = value;
				this.髪右2_表示 = value;
				this.ハイライト右_表示 = value;
				this.髪左根1_表示 = value;
				this.髪左根2_表示 = value;
				this.編み左_編節1_髪節_表示 = value;
				this.編み左_編節1_髪編目_表示 = value;
				this.編み左_編節2_髪節_表示 = value;
				this.編み左_編節2_髪編目_表示 = value;
				this.編み左_編節3_髪節_表示 = value;
				this.編み左_編節3_髪編目_表示 = value;
				this.髪ハネ左_表示 = value;
				this.髪左3_表示 = value;
				this.髪左4_表示 = value;
				this.髪右根1_表示 = value;
				this.髪右根2_表示 = value;
				this.編み右_編節1_髪節_表示 = value;
				this.編み右_編節1_髪編目_表示 = value;
				this.編み右_編節2_髪節_表示 = value;
				this.編み右_編節2_髪編目_表示 = value;
				this.編み右_編節3_髪節_表示 = value;
				this.編み右_編節3_髪編目_表示 = value;
				this.髪ハネ右_表示 = value;
				this.髪右3_表示 = value;
				this.髪右4_表示 = value;
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
				this.髪左1CD.不透明度 = value;
				this.髪左2CD.不透明度 = value;
				this.ハイライト左CD.不透明度 = value;
				this.髪右1CD.不透明度 = value;
				this.髪右2CD.不透明度 = value;
				this.ハイライト右CD.不透明度 = value;
				this.髪左根1CD.不透明度 = value;
				this.髪左根2CD.不透明度 = value;
				this.編み左_編節1_髪節CD.不透明度 = value;
				this.編み左_編節1_髪編目CD.不透明度 = value;
				this.編み左_編節2_髪節CD.不透明度 = value;
				this.編み左_編節2_髪編目CD.不透明度 = value;
				this.編み左_編節3_髪節CD.不透明度 = value;
				this.編み左_編節3_髪編目CD.不透明度 = value;
				this.髪ハネ左CD.不透明度 = value;
				this.髪左3CD.不透明度 = value;
				this.髪左4CD.不透明度 = value;
				this.髪右根1CD.不透明度 = value;
				this.髪右根2CD.不透明度 = value;
				this.編み右_編節1_髪節CD.不透明度 = value;
				this.編み右_編節1_髪編目CD.不透明度 = value;
				this.編み右_編節2_髪節CD.不透明度 = value;
				this.編み右_編節2_髪編目CD.不透明度 = value;
				this.編み右_編節3_髪節CD.不透明度 = value;
				this.編み右_編節3_髪編目CD.不透明度 = value;
				this.髪ハネ右CD.不透明度 = value;
				this.髪右3CD.不透明度 = value;
				this.髪右4CD.不透明度 = value;
			}
		}

		public double 髪長
		{
			set
			{
				double num = 0.9 + 0.2 * value;
				this.X0Y0_髪左3.SizeYBase *= num;
				this.X0Y0_髪左4.SizeYBase *= num;
				this.X0Y0_髪右3.SizeYBase *= num;
				this.X0Y0_髪右4.SizeYBase *= num;
			}
		}

		public override void 色更新()
		{
			this.X0Y0_髪基CP.Update();
			this.X0Y0_髪左1CP.Update();
			this.X0Y0_髪左2CP.Update();
			this.X0Y0_ハイライト左CP.Update();
			this.X0Y0_髪右1CP.Update();
			this.X0Y0_髪右2CP.Update();
			this.X0Y0_ハイライト右CP.Update();
			this.X0Y0_髪左根1CP.Update();
			this.X0Y0_髪左根2CP.Update();
			this.X0Y0_編み左_編節1_髪節CP.Update();
			this.X0Y0_編み左_編節1_髪編目CP.Update();
			this.X0Y0_編み左_編節2_髪節CP.Update();
			this.X0Y0_編み左_編節2_髪編目CP.Update();
			this.X0Y0_編み左_編節3_髪節CP.Update();
			this.X0Y0_編み左_編節3_髪編目CP.Update();
			this.X0Y0_髪ハネ左CP.Update();
			this.X0Y0_髪左3CP.Update();
			this.X0Y0_髪左4CP.Update();
			this.X0Y0_髪右根1CP.Update();
			this.X0Y0_髪右根2CP.Update();
			this.X0Y0_編み右_編節1_髪節CP.Update();
			this.X0Y0_編み右_編節1_髪編目CP.Update();
			this.X0Y0_編み右_編節2_髪節CP.Update();
			this.X0Y0_編み右_編節2_髪編目CP.Update();
			this.X0Y0_編み右_編節3_髪節CP.Update();
			this.X0Y0_編み右_編節3_髪編目CP.Update();
			this.X0Y0_髪ハネ右CP.Update();
			this.X0Y0_髪右3CP.Update();
			this.X0Y0_髪右4CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.髪基CD = new ColorD(ref Col.Empty, ref Color2.Empty);
			this.髪左1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪左2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.ハイライト左CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.髪右1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪右2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.ハイライト右CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.髪左根1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪左根2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.編み左_編節1_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.編み左_編節1_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.編み左_編節2_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.編み左_編節2_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.編み左_編節3_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.編み左_編節3_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪ハネ左CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪左3CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪左4CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪右根1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪右根2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.編み右_編節1_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.編み右_編節1_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.編み右_編節2_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.編み右_編節2_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.編み右_編節3_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.編み右_編節3_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪ハネ右CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪右3CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
			this.髪右4CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		}

		public Par X0Y0_髪基;

		public Par X0Y0_髪左1;

		public Par X0Y0_髪左2;

		public Par X0Y0_ハイライト左;

		public Par X0Y0_髪右1;

		public Par X0Y0_髪右2;

		public Par X0Y0_ハイライト右;

		public Par X0Y0_髪左根1;

		public Par X0Y0_髪左根2;

		public Par X0Y0_編み左_編節1_髪節;

		public Par X0Y0_編み左_編節1_髪編目;

		public Par X0Y0_編み左_編節2_髪節;

		public Par X0Y0_編み左_編節2_髪編目;

		public Par X0Y0_編み左_編節3_髪節;

		public Par X0Y0_編み左_編節3_髪編目;

		public Par X0Y0_髪ハネ左;

		public Par X0Y0_髪左3;

		public Par X0Y0_髪左4;

		public Par X0Y0_髪右根1;

		public Par X0Y0_髪右根2;

		public Par X0Y0_編み右_編節1_髪節;

		public Par X0Y0_編み右_編節1_髪編目;

		public Par X0Y0_編み右_編節2_髪節;

		public Par X0Y0_編み右_編節2_髪編目;

		public Par X0Y0_編み右_編節3_髪節;

		public Par X0Y0_編み右_編節3_髪編目;

		public Par X0Y0_髪ハネ右;

		public Par X0Y0_髪右3;

		public Par X0Y0_髪右4;

		public ColorD 髪基CD;

		public ColorD 髪左1CD;

		public ColorD 髪左2CD;

		public ColorD ハイライト左CD;

		public ColorD 髪右1CD;

		public ColorD 髪右2CD;

		public ColorD ハイライト右CD;

		public ColorD 髪左根1CD;

		public ColorD 髪左根2CD;

		public ColorD 編み左_編節1_髪節CD;

		public ColorD 編み左_編節1_髪編目CD;

		public ColorD 編み左_編節2_髪節CD;

		public ColorD 編み左_編節2_髪編目CD;

		public ColorD 編み左_編節3_髪節CD;

		public ColorD 編み左_編節3_髪編目CD;

		public ColorD 髪ハネ左CD;

		public ColorD 髪左3CD;

		public ColorD 髪左4CD;

		public ColorD 髪右根1CD;

		public ColorD 髪右根2CD;

		public ColorD 編み右_編節1_髪節CD;

		public ColorD 編み右_編節1_髪編目CD;

		public ColorD 編み右_編節2_髪節CD;

		public ColorD 編み右_編節2_髪編目CD;

		public ColorD 編み右_編節3_髪節CD;

		public ColorD 編み右_編節3_髪編目CD;

		public ColorD 髪ハネ右CD;

		public ColorD 髪右3CD;

		public ColorD 髪右4CD;

		public ColorP X0Y0_髪基CP;

		public ColorP X0Y0_髪左1CP;

		public ColorP X0Y0_髪左2CP;

		public ColorP X0Y0_ハイライト左CP;

		public ColorP X0Y0_髪右1CP;

		public ColorP X0Y0_髪右2CP;

		public ColorP X0Y0_ハイライト右CP;

		public ColorP X0Y0_髪左根1CP;

		public ColorP X0Y0_髪左根2CP;

		public ColorP X0Y0_編み左_編節1_髪節CP;

		public ColorP X0Y0_編み左_編節1_髪編目CP;

		public ColorP X0Y0_編み左_編節2_髪節CP;

		public ColorP X0Y0_編み左_編節2_髪編目CP;

		public ColorP X0Y0_編み左_編節3_髪節CP;

		public ColorP X0Y0_編み左_編節3_髪編目CP;

		public ColorP X0Y0_髪ハネ左CP;

		public ColorP X0Y0_髪左3CP;

		public ColorP X0Y0_髪左4CP;

		public ColorP X0Y0_髪右根1CP;

		public ColorP X0Y0_髪右根2CP;

		public ColorP X0Y0_編み右_編節1_髪節CP;

		public ColorP X0Y0_編み右_編節1_髪編目CP;

		public ColorP X0Y0_編み右_編節2_髪節CP;

		public ColorP X0Y0_編み右_編節2_髪編目CP;

		public ColorP X0Y0_編み右_編節3_髪節CP;

		public ColorP X0Y0_編み右_編節3_髪編目CP;

		public ColorP X0Y0_髪ハネ右CP;

		public ColorP X0Y0_髪右3CP;

		public ColorP X0Y0_髪右4CP;
	}
}
