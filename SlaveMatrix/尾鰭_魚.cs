using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 尾鰭_魚 : 尾鰭
	{
		public 尾鰭_魚(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 尾鰭_魚D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.肢中["尾"][0]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["鰭左2"].ToPars();
			this.X0Y0_鰭左2_鰭膜 = pars2["鰭膜"].ToPar();
			this.X0Y0_鰭左2_鰭条 = pars2["鰭条"].ToPar();
			pars2 = pars["鰭右2"].ToPars();
			this.X0Y0_鰭右2_鰭膜 = pars2["鰭膜"].ToPar();
			this.X0Y0_鰭右2_鰭条 = pars2["鰭条"].ToPar();
			pars2 = pars["鰭左1"].ToPars();
			this.X0Y0_鰭左1_鰭膜 = pars2["鰭膜"].ToPar();
			this.X0Y0_鰭左1_鰭条 = pars2["鰭条"].ToPar();
			pars2 = pars["鰭右1"].ToPars();
			this.X0Y0_鰭右1_鰭膜 = pars2["鰭膜"].ToPar();
			this.X0Y0_鰭右1_鰭条 = pars2["鰭条"].ToPar();
			pars2 = pars["尾"].ToPars();
			this.X0Y0_尾_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾_鱗右1 = pars2["鱗右1"].ToPar();
			this.X0Y0_尾_鱗左1 = pars2["鱗左1"].ToPar();
			Pars pars3 = this.本体[0][1];
			pars2 = pars3["鰭左2"].ToPars();
			this.X0Y1_鰭左2_鰭膜 = pars2["鰭膜"].ToPar();
			this.X0Y1_鰭左2_鰭条 = pars2["鰭条"].ToPar();
			pars2 = pars3["鰭右2"].ToPars();
			this.X0Y1_鰭右2_鰭膜 = pars2["鰭膜"].ToPar();
			this.X0Y1_鰭右2_鰭条 = pars2["鰭条"].ToPar();
			pars2 = pars3["鰭左1"].ToPars();
			this.X0Y1_鰭左1_鰭膜 = pars2["鰭膜"].ToPar();
			this.X0Y1_鰭左1_鰭条 = pars2["鰭条"].ToPar();
			pars2 = pars3["鰭右1"].ToPars();
			this.X0Y1_鰭右1_鰭膜 = pars2["鰭膜"].ToPar();
			this.X0Y1_鰭右1_鰭条 = pars2["鰭条"].ToPar();
			pars2 = pars3["尾"].ToPars();
			this.X0Y1_尾_尾 = pars2["尾"].ToPar();
			this.X0Y1_尾_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y1_尾_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y1_尾_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y1_尾_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y1_尾_鱗右1 = pars2["鱗右1"].ToPar();
			this.X0Y1_尾_鱗左1 = pars2["鱗左1"].ToPar();
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
			this.鰭左2_鰭膜_表示 = e.鰭左2_鰭膜_表示;
			this.鰭左2_鰭条_表示 = e.鰭左2_鰭条_表示;
			this.鰭右2_鰭膜_表示 = e.鰭右2_鰭膜_表示;
			this.鰭右2_鰭条_表示 = e.鰭右2_鰭条_表示;
			this.鰭左1_鰭膜_表示 = e.鰭左1_鰭膜_表示;
			this.鰭左1_鰭条_表示 = e.鰭左1_鰭条_表示;
			this.鰭右1_鰭膜_表示 = e.鰭右1_鰭膜_表示;
			this.鰭右1_鰭条_表示 = e.鰭右1_鰭条_表示;
			this.尾_尾_表示 = e.尾_尾_表示;
			this.尾_鱗右3_表示 = e.尾_鱗右3_表示;
			this.尾_鱗左3_表示 = e.尾_鱗左3_表示;
			this.尾_鱗右2_表示 = e.尾_鱗右2_表示;
			this.尾_鱗左2_表示 = e.尾_鱗左2_表示;
			this.尾_鱗右1_表示 = e.尾_鱗右1_表示;
			this.尾_鱗左1_表示 = e.尾_鱗左1_表示;
			this.展開 = e.展開;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_鰭左2_鰭膜CP = new ColorP(this.X0Y0_鰭左2_鰭膜, this.鰭左2_鰭膜CD, DisUnit, true);
			this.X0Y0_鰭左2_鰭条CP = new ColorP(this.X0Y0_鰭左2_鰭条, this.鰭左2_鰭条CD, DisUnit, true);
			this.X0Y0_鰭右2_鰭膜CP = new ColorP(this.X0Y0_鰭右2_鰭膜, this.鰭右2_鰭膜CD, DisUnit, true);
			this.X0Y0_鰭右2_鰭条CP = new ColorP(this.X0Y0_鰭右2_鰭条, this.鰭右2_鰭条CD, DisUnit, true);
			this.X0Y0_鰭左1_鰭膜CP = new ColorP(this.X0Y0_鰭左1_鰭膜, this.鰭左1_鰭膜CD, DisUnit, true);
			this.X0Y0_鰭左1_鰭条CP = new ColorP(this.X0Y0_鰭左1_鰭条, this.鰭左1_鰭条CD, DisUnit, true);
			this.X0Y0_鰭右1_鰭膜CP = new ColorP(this.X0Y0_鰭右1_鰭膜, this.鰭右1_鰭膜CD, DisUnit, true);
			this.X0Y0_鰭右1_鰭条CP = new ColorP(this.X0Y0_鰭右1_鰭条, this.鰭右1_鰭条CD, DisUnit, true);
			this.X0Y0_尾_尾CP = new ColorP(this.X0Y0_尾_尾, this.尾_尾CD, DisUnit, true);
			this.X0Y0_尾_鱗右3CP = new ColorP(this.X0Y0_尾_鱗右3, this.尾_鱗右3CD, DisUnit, true);
			this.X0Y0_尾_鱗左3CP = new ColorP(this.X0Y0_尾_鱗左3, this.尾_鱗左3CD, DisUnit, true);
			this.X0Y0_尾_鱗右2CP = new ColorP(this.X0Y0_尾_鱗右2, this.尾_鱗右2CD, DisUnit, true);
			this.X0Y0_尾_鱗左2CP = new ColorP(this.X0Y0_尾_鱗左2, this.尾_鱗左2CD, DisUnit, true);
			this.X0Y0_尾_鱗右1CP = new ColorP(this.X0Y0_尾_鱗右1, this.尾_鱗右1CD, DisUnit, true);
			this.X0Y0_尾_鱗左1CP = new ColorP(this.X0Y0_尾_鱗左1, this.尾_鱗左1CD, DisUnit, true);
			this.X0Y1_鰭左2_鰭膜CP = new ColorP(this.X0Y1_鰭左2_鰭膜, this.鰭左2_鰭膜CD, DisUnit, true);
			this.X0Y1_鰭左2_鰭条CP = new ColorP(this.X0Y1_鰭左2_鰭条, this.鰭左2_鰭条CD, DisUnit, true);
			this.X0Y1_鰭右2_鰭膜CP = new ColorP(this.X0Y1_鰭右2_鰭膜, this.鰭右2_鰭膜CD, DisUnit, true);
			this.X0Y1_鰭右2_鰭条CP = new ColorP(this.X0Y1_鰭右2_鰭条, this.鰭右2_鰭条CD, DisUnit, true);
			this.X0Y1_鰭左1_鰭膜CP = new ColorP(this.X0Y1_鰭左1_鰭膜, this.鰭左1_鰭膜CD, DisUnit, true);
			this.X0Y1_鰭左1_鰭条CP = new ColorP(this.X0Y1_鰭左1_鰭条, this.鰭左1_鰭条CD, DisUnit, true);
			this.X0Y1_鰭右1_鰭膜CP = new ColorP(this.X0Y1_鰭右1_鰭膜, this.鰭右1_鰭膜CD, DisUnit, true);
			this.X0Y1_鰭右1_鰭条CP = new ColorP(this.X0Y1_鰭右1_鰭条, this.鰭右1_鰭条CD, DisUnit, true);
			this.X0Y1_尾_尾CP = new ColorP(this.X0Y1_尾_尾, this.尾_尾CD, DisUnit, true);
			this.X0Y1_尾_鱗右3CP = new ColorP(this.X0Y1_尾_鱗右3, this.尾_鱗右3CD, DisUnit, true);
			this.X0Y1_尾_鱗左3CP = new ColorP(this.X0Y1_尾_鱗左3, this.尾_鱗左3CD, DisUnit, true);
			this.X0Y1_尾_鱗右2CP = new ColorP(this.X0Y1_尾_鱗右2, this.尾_鱗右2CD, DisUnit, true);
			this.X0Y1_尾_鱗左2CP = new ColorP(this.X0Y1_尾_鱗左2, this.尾_鱗左2CD, DisUnit, true);
			this.X0Y1_尾_鱗右1CP = new ColorP(this.X0Y1_尾_鱗右1, this.尾_鱗右1CD, DisUnit, true);
			this.X0Y1_尾_鱗左1CP = new ColorP(this.X0Y1_尾_鱗左1, this.尾_鱗左1CD, DisUnit, true);
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

		public bool 鰭左2_鰭膜_表示
		{
			get
			{
				return this.X0Y0_鰭左2_鰭膜.Dra;
			}
			set
			{
				this.X0Y0_鰭左2_鰭膜.Dra = value;
				this.X0Y1_鰭左2_鰭膜.Dra = value;
				this.X0Y0_鰭左2_鰭膜.Hit = value;
				this.X0Y1_鰭左2_鰭膜.Hit = value;
			}
		}

		public bool 鰭左2_鰭条_表示
		{
			get
			{
				return this.X0Y0_鰭左2_鰭条.Dra;
			}
			set
			{
				this.X0Y0_鰭左2_鰭条.Dra = value;
				this.X0Y1_鰭左2_鰭条.Dra = value;
				this.X0Y0_鰭左2_鰭条.Hit = value;
				this.X0Y1_鰭左2_鰭条.Hit = value;
			}
		}

		public bool 鰭右2_鰭膜_表示
		{
			get
			{
				return this.X0Y0_鰭右2_鰭膜.Dra;
			}
			set
			{
				this.X0Y0_鰭右2_鰭膜.Dra = value;
				this.X0Y1_鰭右2_鰭膜.Dra = value;
				this.X0Y0_鰭右2_鰭膜.Hit = value;
				this.X0Y1_鰭右2_鰭膜.Hit = value;
			}
		}

		public bool 鰭右2_鰭条_表示
		{
			get
			{
				return this.X0Y0_鰭右2_鰭条.Dra;
			}
			set
			{
				this.X0Y0_鰭右2_鰭条.Dra = value;
				this.X0Y1_鰭右2_鰭条.Dra = value;
				this.X0Y0_鰭右2_鰭条.Hit = value;
				this.X0Y1_鰭右2_鰭条.Hit = value;
			}
		}

		public bool 鰭左1_鰭膜_表示
		{
			get
			{
				return this.X0Y0_鰭左1_鰭膜.Dra;
			}
			set
			{
				this.X0Y0_鰭左1_鰭膜.Dra = value;
				this.X0Y1_鰭左1_鰭膜.Dra = value;
				this.X0Y0_鰭左1_鰭膜.Hit = value;
				this.X0Y1_鰭左1_鰭膜.Hit = value;
			}
		}

		public bool 鰭左1_鰭条_表示
		{
			get
			{
				return this.X0Y0_鰭左1_鰭条.Dra;
			}
			set
			{
				this.X0Y0_鰭左1_鰭条.Dra = value;
				this.X0Y1_鰭左1_鰭条.Dra = value;
				this.X0Y0_鰭左1_鰭条.Hit = value;
				this.X0Y1_鰭左1_鰭条.Hit = value;
			}
		}

		public bool 鰭右1_鰭膜_表示
		{
			get
			{
				return this.X0Y0_鰭右1_鰭膜.Dra;
			}
			set
			{
				this.X0Y0_鰭右1_鰭膜.Dra = value;
				this.X0Y1_鰭右1_鰭膜.Dra = value;
				this.X0Y0_鰭右1_鰭膜.Hit = value;
				this.X0Y1_鰭右1_鰭膜.Hit = value;
			}
		}

		public bool 鰭右1_鰭条_表示
		{
			get
			{
				return this.X0Y0_鰭右1_鰭条.Dra;
			}
			set
			{
				this.X0Y0_鰭右1_鰭条.Dra = value;
				this.X0Y1_鰭右1_鰭条.Dra = value;
				this.X0Y0_鰭右1_鰭条.Hit = value;
				this.X0Y1_鰭右1_鰭条.Hit = value;
			}
		}

		public bool 尾_尾_表示
		{
			get
			{
				return this.X0Y0_尾_尾.Dra;
			}
			set
			{
				this.X0Y0_尾_尾.Dra = value;
				this.X0Y1_尾_尾.Dra = value;
				this.X0Y0_尾_尾.Hit = value;
				this.X0Y1_尾_尾.Hit = value;
			}
		}

		public bool 尾_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾_鱗右3.Dra = value;
				this.X0Y1_尾_鱗右3.Dra = value;
				this.X0Y0_尾_鱗右3.Hit = value;
				this.X0Y1_尾_鱗右3.Hit = value;
			}
		}

		public bool 尾_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾_鱗左3.Dra = value;
				this.X0Y1_尾_鱗左3.Dra = value;
				this.X0Y0_尾_鱗左3.Hit = value;
				this.X0Y1_尾_鱗左3.Hit = value;
			}
		}

		public bool 尾_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾_鱗右2.Dra = value;
				this.X0Y1_尾_鱗右2.Dra = value;
				this.X0Y0_尾_鱗右2.Hit = value;
				this.X0Y1_尾_鱗右2.Hit = value;
			}
		}

		public bool 尾_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾_鱗左2.Dra = value;
				this.X0Y1_尾_鱗左2.Dra = value;
				this.X0Y0_尾_鱗左2.Hit = value;
				this.X0Y1_尾_鱗左2.Hit = value;
			}
		}

		public bool 尾_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾_鱗右1.Dra = value;
				this.X0Y1_尾_鱗右1.Dra = value;
				this.X0Y0_尾_鱗右1.Hit = value;
				this.X0Y1_尾_鱗右1.Hit = value;
			}
		}

		public bool 尾_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾_鱗左1.Dra = value;
				this.X0Y1_尾_鱗左1.Dra = value;
				this.X0Y0_尾_鱗左1.Hit = value;
				this.X0Y1_尾_鱗左1.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.鰭左2_鰭膜_表示;
			}
			set
			{
				this.鰭左2_鰭膜_表示 = value;
				this.鰭左2_鰭条_表示 = value;
				this.鰭右2_鰭膜_表示 = value;
				this.鰭右2_鰭条_表示 = value;
				this.鰭左1_鰭膜_表示 = value;
				this.鰭左1_鰭条_表示 = value;
				this.鰭右1_鰭膜_表示 = value;
				this.鰭右1_鰭条_表示 = value;
				this.尾_尾_表示 = value;
				this.尾_鱗右3_表示 = value;
				this.尾_鱗左3_表示 = value;
				this.尾_鱗右2_表示 = value;
				this.尾_鱗左2_表示 = value;
				this.尾_鱗右1_表示 = value;
				this.尾_鱗左1_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.鰭左2_鰭膜CD.不透明度;
			}
			set
			{
				this.鰭左2_鰭膜CD.不透明度 = value;
				this.鰭左2_鰭条CD.不透明度 = value;
				this.鰭右2_鰭膜CD.不透明度 = value;
				this.鰭右2_鰭条CD.不透明度 = value;
				this.鰭左1_鰭膜CD.不透明度 = value;
				this.鰭左1_鰭条CD.不透明度 = value;
				this.鰭右1_鰭膜CD.不透明度 = value;
				this.鰭右1_鰭条CD.不透明度 = value;
				this.尾_尾CD.不透明度 = value;
				this.尾_鱗右3CD.不透明度 = value;
				this.尾_鱗左3CD.不透明度 = value;
				this.尾_鱗右2CD.不透明度 = value;
				this.尾_鱗左2CD.不透明度 = value;
				this.尾_鱗右1CD.不透明度 = value;
				this.尾_鱗左1CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_鰭左2_鰭膜.AngleBase = num * 35.0;
			this.X0Y0_鰭右2_鰭膜.AngleBase = num * -35.0;
			this.X0Y0_鰭左1_鰭膜.AngleBase = num * 9.0;
			this.X0Y0_鰭右1_鰭膜.AngleBase = num * -9.0;
			this.X0Y1_鰭左2_鰭膜.AngleBase = num * 35.0;
			this.X0Y1_鰭右2_鰭膜.AngleBase = num * -35.0;
			this.X0Y1_鰭左1_鰭膜.AngleBase = num * 9.0;
			this.X0Y1_鰭右1_鰭膜.AngleBase = num * -9.0;
			this.本体.JoinPAall();
		}

		public double 展開
		{
			set
			{
				double num = value.Inverse();
				double num2 = this.右 ? -1.0 : 1.0;
				this.X0Y0_鰭左2_鰭膜.AngleCont = num2 * -35.0 * num;
				this.X0Y0_鰭右2_鰭膜.AngleCont = num2 * 35.0 * num;
				this.X0Y0_鰭左1_鰭膜.AngleCont = num2 * -15.0 * num;
				this.X0Y0_鰭右1_鰭膜.AngleCont = num2 * 15.0 * num;
				this.X0Y1_鰭左2_鰭膜.AngleCont = num2 * -35.0 * num;
				this.X0Y1_鰭右2_鰭膜.AngleCont = num2 * 35.0 * num;
				this.X0Y1_鰭左1_鰭膜.AngleCont = num2 * -15.0 * num;
				this.X0Y1_鰭右1_鰭膜.AngleCont = num2 * 15.0 * num;
			}
		}

		public override void 色更新()
		{
			if (this.本体.IndexY == 0)
			{
				this.X0Y0_鰭左2_鰭膜CP.Update();
				this.X0Y0_鰭左2_鰭条CP.Update();
				this.X0Y0_鰭右2_鰭膜CP.Update();
				this.X0Y0_鰭右2_鰭条CP.Update();
				this.X0Y0_鰭左1_鰭膜CP.Update();
				this.X0Y0_鰭左1_鰭条CP.Update();
				this.X0Y0_鰭右1_鰭膜CP.Update();
				this.X0Y0_鰭右1_鰭条CP.Update();
				this.X0Y0_尾_尾CP.Update();
				this.X0Y0_尾_鱗右3CP.Update();
				this.X0Y0_尾_鱗左3CP.Update();
				this.X0Y0_尾_鱗右2CP.Update();
				this.X0Y0_尾_鱗左2CP.Update();
				this.X0Y0_尾_鱗右1CP.Update();
				this.X0Y0_尾_鱗左1CP.Update();
				return;
			}
			this.X0Y1_鰭左2_鰭膜CP.Update();
			this.X0Y1_鰭左2_鰭条CP.Update();
			this.X0Y1_鰭右2_鰭膜CP.Update();
			this.X0Y1_鰭右2_鰭条CP.Update();
			this.X0Y1_鰭左1_鰭膜CP.Update();
			this.X0Y1_鰭左1_鰭条CP.Update();
			this.X0Y1_鰭右1_鰭膜CP.Update();
			this.X0Y1_鰭右1_鰭条CP.Update();
			this.X0Y1_尾_尾CP.Update();
			this.X0Y1_尾_鱗右3CP.Update();
			this.X0Y1_尾_鱗左3CP.Update();
			this.X0Y1_尾_鱗右2CP.Update();
			this.X0Y1_尾_鱗左2CP.Update();
			this.X0Y1_尾_鱗右1CP.Update();
			this.X0Y1_尾_鱗左1CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.鰭左2_鰭膜CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.鰭左2_鰭条CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.鰭右2_鰭膜CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.鰭右2_鰭条CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.鰭左1_鰭膜CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.鰭左1_鰭条CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.鰭右1_鰭膜CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.鰭右1_鰭条CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.尾_尾CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.尾_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
		}

		public Par X0Y0_鰭左2_鰭膜;

		public Par X0Y0_鰭左2_鰭条;

		public Par X0Y0_鰭右2_鰭膜;

		public Par X0Y0_鰭右2_鰭条;

		public Par X0Y0_鰭左1_鰭膜;

		public Par X0Y0_鰭左1_鰭条;

		public Par X0Y0_鰭右1_鰭膜;

		public Par X0Y0_鰭右1_鰭条;

		public Par X0Y0_尾_尾;

		public Par X0Y0_尾_鱗右3;

		public Par X0Y0_尾_鱗左3;

		public Par X0Y0_尾_鱗右2;

		public Par X0Y0_尾_鱗左2;

		public Par X0Y0_尾_鱗右1;

		public Par X0Y0_尾_鱗左1;

		public Par X0Y1_鰭左2_鰭膜;

		public Par X0Y1_鰭左2_鰭条;

		public Par X0Y1_鰭右2_鰭膜;

		public Par X0Y1_鰭右2_鰭条;

		public Par X0Y1_鰭左1_鰭膜;

		public Par X0Y1_鰭左1_鰭条;

		public Par X0Y1_鰭右1_鰭膜;

		public Par X0Y1_鰭右1_鰭条;

		public Par X0Y1_尾_尾;

		public Par X0Y1_尾_鱗右3;

		public Par X0Y1_尾_鱗左3;

		public Par X0Y1_尾_鱗右2;

		public Par X0Y1_尾_鱗左2;

		public Par X0Y1_尾_鱗右1;

		public Par X0Y1_尾_鱗左1;

		public ColorD 鰭左2_鰭膜CD;

		public ColorD 鰭左2_鰭条CD;

		public ColorD 鰭右2_鰭膜CD;

		public ColorD 鰭右2_鰭条CD;

		public ColorD 鰭左1_鰭膜CD;

		public ColorD 鰭左1_鰭条CD;

		public ColorD 鰭右1_鰭膜CD;

		public ColorD 鰭右1_鰭条CD;

		public ColorD 尾_尾CD;

		public ColorD 尾_鱗右3CD;

		public ColorD 尾_鱗左3CD;

		public ColorD 尾_鱗右2CD;

		public ColorD 尾_鱗左2CD;

		public ColorD 尾_鱗右1CD;

		public ColorD 尾_鱗左1CD;

		public ColorP X0Y0_鰭左2_鰭膜CP;

		public ColorP X0Y0_鰭左2_鰭条CP;

		public ColorP X0Y0_鰭右2_鰭膜CP;

		public ColorP X0Y0_鰭右2_鰭条CP;

		public ColorP X0Y0_鰭左1_鰭膜CP;

		public ColorP X0Y0_鰭左1_鰭条CP;

		public ColorP X0Y0_鰭右1_鰭膜CP;

		public ColorP X0Y0_鰭右1_鰭条CP;

		public ColorP X0Y0_尾_尾CP;

		public ColorP X0Y0_尾_鱗右3CP;

		public ColorP X0Y0_尾_鱗左3CP;

		public ColorP X0Y0_尾_鱗右2CP;

		public ColorP X0Y0_尾_鱗左2CP;

		public ColorP X0Y0_尾_鱗右1CP;

		public ColorP X0Y0_尾_鱗左1CP;

		public ColorP X0Y1_鰭左2_鰭膜CP;

		public ColorP X0Y1_鰭左2_鰭条CP;

		public ColorP X0Y1_鰭右2_鰭膜CP;

		public ColorP X0Y1_鰭右2_鰭条CP;

		public ColorP X0Y1_鰭左1_鰭膜CP;

		public ColorP X0Y1_鰭左1_鰭条CP;

		public ColorP X0Y1_鰭右1_鰭膜CP;

		public ColorP X0Y1_鰭右1_鰭条CP;

		public ColorP X0Y1_尾_尾CP;

		public ColorP X0Y1_尾_鱗右3CP;

		public ColorP X0Y1_尾_鱗左3CP;

		public ColorP X0Y1_尾_鱗右2CP;

		public ColorP X0Y1_尾_鱗左2CP;

		public ColorP X0Y1_尾_鱗右1CP;

		public ColorP X0Y1_尾_鱗左1CP;
	}
}
