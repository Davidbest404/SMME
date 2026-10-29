using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 手_獣 : 獣手
	{
		public 手_獣(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 手_獣D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "獣";
			dif.Add(new Pars(Sta.腕左["四足手"][0][0]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_手 = pars["手"].ToPar();
			Pars pars2 = pars["親指"].ToPars();
			this.X0Y0_親指_指 = pars2["指"].ToPar();
			this.X0Y0_親指_爪 = pars2["爪"].ToPar();
			pars2 = pars["小指"].ToPars();
			this.X0Y0_小指_指 = pars2["指"].ToPar();
			this.X0Y0_小指_爪 = pars2["爪"].ToPar();
			pars2 = pars["薬指"].ToPars();
			this.X0Y0_薬指_指 = pars2["指"].ToPar();
			this.X0Y0_薬指_爪 = pars2["爪"].ToPar();
			pars2 = pars["中指"].ToPars();
			this.X0Y0_中指_指 = pars2["指"].ToPar();
			this.X0Y0_中指_爪 = pars2["爪"].ToPar();
			pars2 = pars["人指"].ToPars();
			this.X0Y0_人指_指 = pars2["指"].ToPar();
			this.X0Y0_人指_爪 = pars2["爪"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y0_竜性_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y0_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y0_竜性_鱗1 = pars2["鱗1"].ToPar();
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
			this.手_表示 = e.手_表示;
			this.親指_指_表示 = e.親指_指_表示;
			this.親指_爪_表示 = e.親指_爪_表示;
			this.小指_指_表示 = e.小指_指_表示;
			this.小指_爪_表示 = e.小指_爪_表示;
			this.薬指_指_表示 = e.薬指_指_表示;
			this.薬指_爪_表示 = e.薬指_爪_表示;
			this.中指_指_表示 = e.中指_指_表示;
			this.中指_爪_表示 = e.中指_爪_表示;
			this.人指_指_表示 = e.人指_指_表示;
			this.人指_爪_表示 = e.人指_爪_表示;
			this.竜性_鱗3_表示 = e.竜性_鱗3_表示;
			this.竜性_鱗2_表示 = e.竜性_鱗2_表示;
			this.竜性_鱗1_表示 = e.竜性_鱗1_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_手CP = new ColorP(this.X0Y0_手, this.手CD, DisUnit, true);
			this.X0Y0_親指_指CP = new ColorP(this.X0Y0_親指_指, this.親指_指CD, DisUnit, true);
			this.X0Y0_親指_爪CP = new ColorP(this.X0Y0_親指_爪, this.親指_爪CD, DisUnit, true);
			this.X0Y0_小指_指CP = new ColorP(this.X0Y0_小指_指, this.小指_指CD, DisUnit, true);
			this.X0Y0_小指_爪CP = new ColorP(this.X0Y0_小指_爪, this.小指_爪CD, DisUnit, true);
			this.X0Y0_薬指_指CP = new ColorP(this.X0Y0_薬指_指, this.薬指_指CD, DisUnit, true);
			this.X0Y0_薬指_爪CP = new ColorP(this.X0Y0_薬指_爪, this.薬指_爪CD, DisUnit, true);
			this.X0Y0_中指_指CP = new ColorP(this.X0Y0_中指_指, this.中指_指CD, DisUnit, true);
			this.X0Y0_中指_爪CP = new ColorP(this.X0Y0_中指_爪, this.中指_爪CD, DisUnit, true);
			this.X0Y0_人指_指CP = new ColorP(this.X0Y0_人指_指, this.人指_指CD, DisUnit, true);
			this.X0Y0_人指_爪CP = new ColorP(this.X0Y0_人指_爪, this.人指_爪CD, DisUnit, true);
			this.X0Y0_竜性_鱗3CP = new ColorP(this.X0Y0_竜性_鱗3, this.竜性_鱗3CD, DisUnit, true);
			this.X0Y0_竜性_鱗2CP = new ColorP(this.X0Y0_竜性_鱗2, this.竜性_鱗2CD, DisUnit, true);
			this.X0Y0_竜性_鱗1CP = new ColorP(this.X0Y0_竜性_鱗1, this.竜性_鱗1CD, DisUnit, true);
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

		public bool 手_表示
		{
			get
			{
				return this.X0Y0_手.Dra;
			}
			set
			{
				this.X0Y0_手.Dra = value;
				this.X0Y0_手.Hit = value;
			}
		}

		public bool 親指_指_表示
		{
			get
			{
				return this.X0Y0_親指_指.Dra;
			}
			set
			{
				this.X0Y0_親指_指.Dra = value;
				this.X0Y0_親指_指.Hit = value;
			}
		}

		public bool 親指_爪_表示
		{
			get
			{
				return this.X0Y0_親指_爪.Dra;
			}
			set
			{
				this.X0Y0_親指_爪.Dra = value;
				this.X0Y0_親指_爪.Hit = value;
			}
		}

		public bool 小指_指_表示
		{
			get
			{
				return this.X0Y0_小指_指.Dra;
			}
			set
			{
				this.X0Y0_小指_指.Dra = value;
				this.X0Y0_小指_指.Hit = value;
			}
		}

		public bool 小指_爪_表示
		{
			get
			{
				return this.X0Y0_小指_爪.Dra;
			}
			set
			{
				this.X0Y0_小指_爪.Dra = value;
				this.X0Y0_小指_爪.Hit = value;
			}
		}

		public bool 薬指_指_表示
		{
			get
			{
				return this.X0Y0_薬指_指.Dra;
			}
			set
			{
				this.X0Y0_薬指_指.Dra = value;
				this.X0Y0_薬指_指.Hit = value;
			}
		}

		public bool 薬指_爪_表示
		{
			get
			{
				return this.X0Y0_薬指_爪.Dra;
			}
			set
			{
				this.X0Y0_薬指_爪.Dra = value;
				this.X0Y0_薬指_爪.Hit = value;
			}
		}

		public bool 中指_指_表示
		{
			get
			{
				return this.X0Y0_中指_指.Dra;
			}
			set
			{
				this.X0Y0_中指_指.Dra = value;
				this.X0Y0_中指_指.Hit = value;
			}
		}

		public bool 中指_爪_表示
		{
			get
			{
				return this.X0Y0_中指_爪.Dra;
			}
			set
			{
				this.X0Y0_中指_爪.Dra = value;
				this.X0Y0_中指_爪.Hit = value;
			}
		}

		public bool 人指_指_表示
		{
			get
			{
				return this.X0Y0_人指_指.Dra;
			}
			set
			{
				this.X0Y0_人指_指.Dra = value;
				this.X0Y0_人指_指.Hit = value;
			}
		}

		public bool 人指_爪_表示
		{
			get
			{
				return this.X0Y0_人指_爪.Dra;
			}
			set
			{
				this.X0Y0_人指_爪.Dra = value;
				this.X0Y0_人指_爪.Hit = value;
			}
		}

		public bool 竜性_鱗3_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗3.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗3.Dra = value;
				this.X0Y0_竜性_鱗3.Hit = value;
			}
		}

		public bool 竜性_鱗2_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗2.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗2.Dra = value;
				this.X0Y0_竜性_鱗2.Hit = value;
			}
		}

		public bool 竜性_鱗1_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗1.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗1.Dra = value;
				this.X0Y0_竜性_鱗1.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.手_表示;
			}
			set
			{
				this.手_表示 = value;
				this.親指_指_表示 = value;
				this.親指_爪_表示 = value;
				this.小指_指_表示 = value;
				this.小指_爪_表示 = value;
				this.薬指_指_表示 = value;
				this.薬指_爪_表示 = value;
				this.中指_指_表示 = value;
				this.中指_爪_表示 = value;
				this.人指_指_表示 = value;
				this.人指_爪_表示 = value;
				this.竜性_鱗3_表示 = value;
				this.竜性_鱗2_表示 = value;
				this.竜性_鱗1_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.手CD.不透明度;
			}
			set
			{
				this.手CD.不透明度 = value;
				this.親指_指CD.不透明度 = value;
				this.親指_爪CD.不透明度 = value;
				this.小指_指CD.不透明度 = value;
				this.小指_爪CD.不透明度 = value;
				this.薬指_指CD.不透明度 = value;
				this.薬指_爪CD.不透明度 = value;
				this.中指_指CD.不透明度 = value;
				this.中指_爪CD.不透明度 = value;
				this.人指_指CD.不透明度 = value;
				this.人指_爪CD.不透明度 = value;
				this.竜性_鱗3CD.不透明度 = value;
				this.竜性_鱗2CD.不透明度 = value;
				this.竜性_鱗1CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_手.AngleBase = num * 202.0;
			this.本体.JoinPAall();
		}

		public override void 色更新()
		{
			this.X0Y0_手CP.Update();
			this.X0Y0_親指_指CP.Update();
			this.X0Y0_親指_爪CP.Update();
			this.X0Y0_小指_指CP.Update();
			this.X0Y0_小指_爪CP.Update();
			this.X0Y0_薬指_指CP.Update();
			this.X0Y0_薬指_爪CP.Update();
			this.X0Y0_中指_指CP.Update();
			this.X0Y0_中指_爪CP.Update();
			this.X0Y0_人指_指CP.Update();
			this.X0Y0_人指_爪CP.Update();
			this.X0Y0_竜性_鱗3CP.Update();
			this.X0Y0_竜性_鱗2CP.Update();
			this.X0Y0_竜性_鱗1CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			switch (this.配色指定)
			{
			case 配色指定.N0:
				this.配色N0(体配色);
				return;
			case 配色指定.T0:
				this.配色T0(体配色);
				return;
			case 配色指定.T1:
				this.配色T1(体配色);
				return;
			default:
				this.配色N0(体配色);
				return;
			}
		}

		private void 配色N0(体配色 体配色)
		{
			this.手CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.親指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.親指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.小指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.小指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.薬指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.薬指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.中指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.中指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.人指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.人指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.手CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.親指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.親指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.小指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.小指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.薬指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.薬指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.中指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.中指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.人指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.人指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.手CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.親指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.親指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.小指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.小指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.薬指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.薬指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.中指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.中指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.人指_指CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.人指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
		}

		public Par X0Y0_手;

		public Par X0Y0_親指_指;

		public Par X0Y0_親指_爪;

		public Par X0Y0_小指_指;

		public Par X0Y0_小指_爪;

		public Par X0Y0_薬指_指;

		public Par X0Y0_薬指_爪;

		public Par X0Y0_中指_指;

		public Par X0Y0_中指_爪;

		public Par X0Y0_人指_指;

		public Par X0Y0_人指_爪;

		public Par X0Y0_竜性_鱗3;

		public Par X0Y0_竜性_鱗2;

		public Par X0Y0_竜性_鱗1;

		public ColorD 手CD;

		public ColorD 親指_指CD;

		public ColorD 親指_爪CD;

		public ColorD 小指_指CD;

		public ColorD 小指_爪CD;

		public ColorD 薬指_指CD;

		public ColorD 薬指_爪CD;

		public ColorD 中指_指CD;

		public ColorD 中指_爪CD;

		public ColorD 人指_指CD;

		public ColorD 人指_爪CD;

		public ColorD 竜性_鱗3CD;

		public ColorD 竜性_鱗2CD;

		public ColorD 竜性_鱗1CD;

		public ColorP X0Y0_手CP;

		public ColorP X0Y0_親指_指CP;

		public ColorP X0Y0_親指_爪CP;

		public ColorP X0Y0_小指_指CP;

		public ColorP X0Y0_小指_爪CP;

		public ColorP X0Y0_薬指_指CP;

		public ColorP X0Y0_薬指_爪CP;

		public ColorP X0Y0_中指_指CP;

		public ColorP X0Y0_中指_爪CP;

		public ColorP X0Y0_人指_指CP;

		public ColorP X0Y0_人指_爪CP;

		public ColorP X0Y0_竜性_鱗3CP;

		public ColorP X0Y0_竜性_鱗2CP;

		public ColorP X0Y0_竜性_鱗1CP;
	}
}
