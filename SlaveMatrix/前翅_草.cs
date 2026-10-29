using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 前翅_草 : 前翅
	{
		public 前翅_草(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 前翅_草D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.肢左["前翅"][3]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0]["前翅"].ToPars();
			this.X0Y0_前翅_前翅1 = pars["前翅1"].ToPar();
			this.X0Y0_前翅_翅脈線1 = pars["翅脈線1"].ToPar();
			this.X0Y0_前翅_翅脈線2 = pars["翅脈線2"].ToPar();
			this.X0Y0_前翅_翅脈線3 = pars["翅脈線3"].ToPar();
			this.X0Y0_前翅_翅脈線4 = pars["翅脈線4"].ToPar();
			this.X0Y0_前翅_翅脈線5 = pars["翅脈線5"].ToPar();
			this.X0Y0_前翅_翅脈線6 = pars["翅脈線6"].ToPar();
			this.X0Y0_前翅_翅脈線7 = pars["翅脈線7"].ToPar();
			this.X0Y0_前翅_翅脈線8 = pars["翅脈線8"].ToPar();
			this.X0Y0_前翅_前翅2 = pars["前翅2"].ToPar();
			this.X0Y0_前翅_紋1 = pars["紋1"].ToPar();
			this.X0Y0_前翅_紋2 = pars["紋2"].ToPar();
			pars = this.本体[0][1]["前翅"].ToPars();
			this.X0Y1_前翅_前翅1 = pars["前翅1"].ToPar();
			this.X0Y1_前翅_翅脈線1 = pars["翅脈線1"].ToPar();
			this.X0Y1_前翅_翅脈線2 = pars["翅脈線2"].ToPar();
			this.X0Y1_前翅_翅脈線3 = pars["翅脈線3"].ToPar();
			this.X0Y1_前翅_翅脈線4 = pars["翅脈線4"].ToPar();
			this.X0Y1_前翅_翅脈線5 = pars["翅脈線5"].ToPar();
			this.X0Y1_前翅_翅脈線6 = pars["翅脈線6"].ToPar();
			this.X0Y1_前翅_翅脈線7 = pars["翅脈線7"].ToPar();
			this.X0Y1_前翅_翅脈線8 = pars["翅脈線8"].ToPar();
			this.X0Y1_前翅_前翅2 = pars["前翅2"].ToPar();
			this.X0Y1_前翅_紋1 = pars["紋1"].ToPar();
			this.X0Y1_前翅_紋2 = pars["紋2"].ToPar();
			this.Xasix = false;
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
			this.前翅_前翅1_表示 = e.前翅_前翅1_表示;
			this.前翅_翅脈線1_表示 = e.前翅_翅脈線1_表示;
			this.前翅_翅脈線2_表示 = e.前翅_翅脈線2_表示;
			this.前翅_翅脈線3_表示 = e.前翅_翅脈線3_表示;
			this.前翅_翅脈線4_表示 = e.前翅_翅脈線4_表示;
			this.前翅_翅脈線5_表示 = e.前翅_翅脈線5_表示;
			this.前翅_翅脈線6_表示 = e.前翅_翅脈線6_表示;
			this.前翅_翅脈線7_表示 = e.前翅_翅脈線7_表示;
			this.前翅_翅脈線8_表示 = e.前翅_翅脈線8_表示;
			this.前翅_前翅2_表示 = e.前翅_前翅2_表示;
			this.前翅_紋1_表示 = e.前翅_紋1_表示;
			this.前翅_紋2_表示 = e.前翅_紋2_表示;
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
			this.X0Y0_前翅_前翅1CP = new ColorP(this.X0Y0_前翅_前翅1, this.前翅_前翅1CD, DisUnit, true);
			this.X0Y0_前翅_翅脈線1CP = new ColorP(this.X0Y0_前翅_翅脈線1, this.前翅_翅脈線1CD, DisUnit, true);
			this.X0Y0_前翅_翅脈線2CP = new ColorP(this.X0Y0_前翅_翅脈線2, this.前翅_翅脈線2CD, DisUnit, true);
			this.X0Y0_前翅_翅脈線3CP = new ColorP(this.X0Y0_前翅_翅脈線3, this.前翅_翅脈線3CD, DisUnit, true);
			this.X0Y0_前翅_翅脈線4CP = new ColorP(this.X0Y0_前翅_翅脈線4, this.前翅_翅脈線4CD, DisUnit, true);
			this.X0Y0_前翅_翅脈線5CP = new ColorP(this.X0Y0_前翅_翅脈線5, this.前翅_翅脈線5CD, DisUnit, true);
			this.X0Y0_前翅_翅脈線6CP = new ColorP(this.X0Y0_前翅_翅脈線6, this.前翅_翅脈線6CD, DisUnit, true);
			this.X0Y0_前翅_翅脈線7CP = new ColorP(this.X0Y0_前翅_翅脈線7, this.前翅_翅脈線7CD, DisUnit, true);
			this.X0Y0_前翅_翅脈線8CP = new ColorP(this.X0Y0_前翅_翅脈線8, this.前翅_翅脈線8CD, DisUnit, true);
			this.X0Y0_前翅_前翅2CP = new ColorP(this.X0Y0_前翅_前翅2, this.前翅_前翅2CD, DisUnit, true);
			this.X0Y0_前翅_紋1CP = new ColorP(this.X0Y0_前翅_紋1, this.前翅_紋1CD, DisUnit, true);
			this.X0Y0_前翅_紋2CP = new ColorP(this.X0Y0_前翅_紋2, this.前翅_紋2CD, DisUnit, true);
			this.X0Y1_前翅_前翅1CP = new ColorP(this.X0Y1_前翅_前翅1, this.前翅_前翅1CD, DisUnit, true);
			this.X0Y1_前翅_翅脈線1CP = new ColorP(this.X0Y1_前翅_翅脈線1, this.前翅_翅脈線1CD, DisUnit, true);
			this.X0Y1_前翅_翅脈線2CP = new ColorP(this.X0Y1_前翅_翅脈線2, this.前翅_翅脈線2CD, DisUnit, true);
			this.X0Y1_前翅_翅脈線3CP = new ColorP(this.X0Y1_前翅_翅脈線3, this.前翅_翅脈線3CD, DisUnit, true);
			this.X0Y1_前翅_翅脈線4CP = new ColorP(this.X0Y1_前翅_翅脈線4, this.前翅_翅脈線4CD, DisUnit, true);
			this.X0Y1_前翅_翅脈線5CP = new ColorP(this.X0Y1_前翅_翅脈線5, this.前翅_翅脈線5CD, DisUnit, true);
			this.X0Y1_前翅_翅脈線6CP = new ColorP(this.X0Y1_前翅_翅脈線6, this.前翅_翅脈線6CD, DisUnit, true);
			this.X0Y1_前翅_翅脈線7CP = new ColorP(this.X0Y1_前翅_翅脈線7, this.前翅_翅脈線7CD, DisUnit, true);
			this.X0Y1_前翅_翅脈線8CP = new ColorP(this.X0Y1_前翅_翅脈線8, this.前翅_翅脈線8CD, DisUnit, true);
			this.X0Y1_前翅_前翅2CP = new ColorP(this.X0Y1_前翅_前翅2, this.前翅_前翅2CD, DisUnit, true);
			this.X0Y1_前翅_紋1CP = new ColorP(this.X0Y1_前翅_紋1, this.前翅_紋1CD, DisUnit, true);
			this.X0Y1_前翅_紋2CP = new ColorP(this.X0Y1_前翅_紋2, this.前翅_紋2CD, DisUnit, true);
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

		public bool 前翅_前翅1_表示
		{
			get
			{
				return this.X0Y0_前翅_前翅1.Dra;
			}
			set
			{
				this.X0Y0_前翅_前翅1.Dra = value;
				this.X0Y1_前翅_前翅1.Dra = value;
				this.X0Y0_前翅_前翅1.Hit = value;
				this.X0Y1_前翅_前翅1.Hit = value;
			}
		}

		public bool 前翅_翅脈線1_表示
		{
			get
			{
				return this.X0Y0_前翅_翅脈線1.Dra;
			}
			set
			{
				this.X0Y0_前翅_翅脈線1.Dra = value;
				this.X0Y1_前翅_翅脈線1.Dra = value;
				this.X0Y0_前翅_翅脈線1.Hit = value;
				this.X0Y1_前翅_翅脈線1.Hit = value;
			}
		}

		public bool 前翅_翅脈線2_表示
		{
			get
			{
				return this.X0Y0_前翅_翅脈線2.Dra;
			}
			set
			{
				this.X0Y0_前翅_翅脈線2.Dra = value;
				this.X0Y1_前翅_翅脈線2.Dra = value;
				this.X0Y0_前翅_翅脈線2.Hit = value;
				this.X0Y1_前翅_翅脈線2.Hit = value;
			}
		}

		public bool 前翅_翅脈線3_表示
		{
			get
			{
				return this.X0Y0_前翅_翅脈線3.Dra;
			}
			set
			{
				this.X0Y0_前翅_翅脈線3.Dra = value;
				this.X0Y1_前翅_翅脈線3.Dra = value;
				this.X0Y0_前翅_翅脈線3.Hit = value;
				this.X0Y1_前翅_翅脈線3.Hit = value;
			}
		}

		public bool 前翅_翅脈線4_表示
		{
			get
			{
				return this.X0Y0_前翅_翅脈線4.Dra;
			}
			set
			{
				this.X0Y0_前翅_翅脈線4.Dra = value;
				this.X0Y1_前翅_翅脈線4.Dra = value;
				this.X0Y0_前翅_翅脈線4.Hit = value;
				this.X0Y1_前翅_翅脈線4.Hit = value;
			}
		}

		public bool 前翅_翅脈線5_表示
		{
			get
			{
				return this.X0Y0_前翅_翅脈線5.Dra;
			}
			set
			{
				this.X0Y0_前翅_翅脈線5.Dra = value;
				this.X0Y1_前翅_翅脈線5.Dra = value;
				this.X0Y0_前翅_翅脈線5.Hit = value;
				this.X0Y1_前翅_翅脈線5.Hit = value;
			}
		}

		public bool 前翅_翅脈線6_表示
		{
			get
			{
				return this.X0Y0_前翅_翅脈線6.Dra;
			}
			set
			{
				this.X0Y0_前翅_翅脈線6.Dra = value;
				this.X0Y1_前翅_翅脈線6.Dra = value;
				this.X0Y0_前翅_翅脈線6.Hit = value;
				this.X0Y1_前翅_翅脈線6.Hit = value;
			}
		}

		public bool 前翅_翅脈線7_表示
		{
			get
			{
				return this.X0Y0_前翅_翅脈線7.Dra;
			}
			set
			{
				this.X0Y0_前翅_翅脈線7.Dra = value;
				this.X0Y1_前翅_翅脈線7.Dra = value;
				this.X0Y0_前翅_翅脈線7.Hit = value;
				this.X0Y1_前翅_翅脈線7.Hit = value;
			}
		}

		public bool 前翅_翅脈線8_表示
		{
			get
			{
				return this.X0Y0_前翅_翅脈線8.Dra;
			}
			set
			{
				this.X0Y0_前翅_翅脈線8.Dra = value;
				this.X0Y1_前翅_翅脈線8.Dra = value;
				this.X0Y0_前翅_翅脈線8.Hit = value;
				this.X0Y1_前翅_翅脈線8.Hit = value;
			}
		}

		public bool 前翅_前翅2_表示
		{
			get
			{
				return this.X0Y0_前翅_前翅2.Dra;
			}
			set
			{
				this.X0Y0_前翅_前翅2.Dra = value;
				this.X0Y1_前翅_前翅2.Dra = value;
				this.X0Y0_前翅_前翅2.Hit = value;
				this.X0Y1_前翅_前翅2.Hit = value;
			}
		}

		public bool 前翅_紋1_表示
		{
			get
			{
				return this.X0Y0_前翅_紋1.Dra;
			}
			set
			{
				this.X0Y0_前翅_紋1.Dra = value;
				this.X0Y1_前翅_紋1.Dra = value;
				this.X0Y0_前翅_紋1.Hit = value;
				this.X0Y1_前翅_紋1.Hit = value;
			}
		}

		public bool 前翅_紋2_表示
		{
			get
			{
				return this.X0Y0_前翅_紋2.Dra;
			}
			set
			{
				this.X0Y0_前翅_紋2.Dra = value;
				this.X0Y1_前翅_紋2.Dra = value;
				this.X0Y0_前翅_紋2.Hit = value;
				this.X0Y1_前翅_紋2.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.前翅_前翅1_表示;
			}
			set
			{
				this.前翅_前翅1_表示 = value;
				this.前翅_翅脈線1_表示 = value;
				this.前翅_翅脈線2_表示 = value;
				this.前翅_翅脈線3_表示 = value;
				this.前翅_翅脈線4_表示 = value;
				this.前翅_翅脈線5_表示 = value;
				this.前翅_翅脈線6_表示 = value;
				this.前翅_翅脈線7_表示 = value;
				this.前翅_翅脈線8_表示 = value;
				this.前翅_前翅2_表示 = value;
				this.前翅_紋1_表示 = value;
				this.前翅_紋2_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.前翅_前翅1CD.不透明度;
			}
			set
			{
				this.前翅_前翅1CD.不透明度 = value;
				this.前翅_翅脈線1CD.不透明度 = value;
				this.前翅_翅脈線2CD.不透明度 = value;
				this.前翅_翅脈線3CD.不透明度 = value;
				this.前翅_翅脈線4CD.不透明度 = value;
				this.前翅_翅脈線5CD.不透明度 = value;
				this.前翅_翅脈線6CD.不透明度 = value;
				this.前翅_翅脈線7CD.不透明度 = value;
				this.前翅_翅脈線8CD.不透明度 = value;
				this.前翅_前翅2CD.不透明度 = value;
				this.前翅_紋1CD.不透明度 = value;
				this.前翅_紋2CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_前翅_前翅1.AngleBase = num * 10.0;
			this.X0Y1_前翅_前翅1.AngleBase = num * 10.0;
			this.本体.JoinPAall();
		}

		public double 展開
		{
			set
			{
				double num = value.Inverse();
				double num2 = this.右 ? -1.0 : 1.0;
				this.X0Y0_前翅_前翅1.AngleCont = num2 * -102.15 * num;
				this.X0Y1_前翅_前翅1.AngleCont = num2 * -102.15 * num;
			}
		}

		public override void 色更新()
		{
			if (this.本体.IndexY == 0)
			{
				this.X0Y0_前翅_前翅1CP.Update();
				this.X0Y0_前翅_翅脈線1CP.Update();
				this.X0Y0_前翅_翅脈線2CP.Update();
				this.X0Y0_前翅_翅脈線3CP.Update();
				this.X0Y0_前翅_翅脈線4CP.Update();
				this.X0Y0_前翅_翅脈線5CP.Update();
				this.X0Y0_前翅_翅脈線6CP.Update();
				this.X0Y0_前翅_翅脈線7CP.Update();
				this.X0Y0_前翅_翅脈線8CP.Update();
				this.X0Y0_前翅_前翅2CP.Update();
				this.X0Y0_前翅_紋1CP.Update();
				this.X0Y0_前翅_紋2CP.Update();
				return;
			}
			this.X0Y1_前翅_前翅1CP.Update();
			this.X0Y1_前翅_翅脈線1CP.Update();
			this.X0Y1_前翅_翅脈線2CP.Update();
			this.X0Y1_前翅_翅脈線3CP.Update();
			this.X0Y1_前翅_翅脈線4CP.Update();
			this.X0Y1_前翅_翅脈線5CP.Update();
			this.X0Y1_前翅_翅脈線6CP.Update();
			this.X0Y1_前翅_翅脈線7CP.Update();
			this.X0Y1_前翅_翅脈線8CP.Update();
			this.X0Y1_前翅_前翅2CP.Update();
			this.X0Y1_前翅_紋1CP.Update();
			this.X0Y1_前翅_紋2CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			Color2 color;
			Col.Alpha(ref 体配色.体0O, 128, out color);
			this.前翅_前翅1CD = new ColorD(ref Col.Black, ref color);
			this.前翅_翅脈線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.前翅_翅脈線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.前翅_翅脈線3CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.前翅_翅脈線4CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.前翅_翅脈線5CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.前翅_翅脈線6CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.前翅_翅脈線7CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.前翅_翅脈線8CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.前翅_前翅2CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.前翅_紋1CD = new ColorD(ref Col.Black, ref 体配色.紋R);
			this.前翅_紋2CD = new ColorD(ref Col.Black, ref 体配色.紋R);
		}

		public Par X0Y0_前翅_前翅1;

		public Par X0Y0_前翅_翅脈線1;

		public Par X0Y0_前翅_翅脈線2;

		public Par X0Y0_前翅_翅脈線3;

		public Par X0Y0_前翅_翅脈線4;

		public Par X0Y0_前翅_翅脈線5;

		public Par X0Y0_前翅_翅脈線6;

		public Par X0Y0_前翅_翅脈線7;

		public Par X0Y0_前翅_翅脈線8;

		public Par X0Y0_前翅_前翅2;

		public Par X0Y0_前翅_紋1;

		public Par X0Y0_前翅_紋2;

		public Par X0Y1_前翅_前翅1;

		public Par X0Y1_前翅_翅脈線1;

		public Par X0Y1_前翅_翅脈線2;

		public Par X0Y1_前翅_翅脈線3;

		public Par X0Y1_前翅_翅脈線4;

		public Par X0Y1_前翅_翅脈線5;

		public Par X0Y1_前翅_翅脈線6;

		public Par X0Y1_前翅_翅脈線7;

		public Par X0Y1_前翅_翅脈線8;

		public Par X0Y1_前翅_前翅2;

		public Par X0Y1_前翅_紋1;

		public Par X0Y1_前翅_紋2;

		public ColorD 前翅_前翅1CD;

		public ColorD 前翅_翅脈線1CD;

		public ColorD 前翅_翅脈線2CD;

		public ColorD 前翅_翅脈線3CD;

		public ColorD 前翅_翅脈線4CD;

		public ColorD 前翅_翅脈線5CD;

		public ColorD 前翅_翅脈線6CD;

		public ColorD 前翅_翅脈線7CD;

		public ColorD 前翅_翅脈線8CD;

		public ColorD 前翅_前翅2CD;

		public ColorD 前翅_紋1CD;

		public ColorD 前翅_紋2CD;

		public ColorP X0Y0_前翅_前翅1CP;

		public ColorP X0Y0_前翅_翅脈線1CP;

		public ColorP X0Y0_前翅_翅脈線2CP;

		public ColorP X0Y0_前翅_翅脈線3CP;

		public ColorP X0Y0_前翅_翅脈線4CP;

		public ColorP X0Y0_前翅_翅脈線5CP;

		public ColorP X0Y0_前翅_翅脈線6CP;

		public ColorP X0Y0_前翅_翅脈線7CP;

		public ColorP X0Y0_前翅_翅脈線8CP;

		public ColorP X0Y0_前翅_前翅2CP;

		public ColorP X0Y0_前翅_紋1CP;

		public ColorP X0Y0_前翅_紋2CP;

		public ColorP X0Y1_前翅_前翅1CP;

		public ColorP X0Y1_前翅_翅脈線1CP;

		public ColorP X0Y1_前翅_翅脈線2CP;

		public ColorP X0Y1_前翅_翅脈線3CP;

		public ColorP X0Y1_前翅_翅脈線4CP;

		public ColorP X0Y1_前翅_翅脈線5CP;

		public ColorP X0Y1_前翅_翅脈線6CP;

		public ColorP X0Y1_前翅_翅脈線7CP;

		public ColorP X0Y1_前翅_翅脈線8CP;

		public ColorP X0Y1_前翅_前翅2CP;

		public ColorP X0Y1_前翅_紋1CP;

		public ColorP X0Y1_前翅_紋2CP;
	}
}
