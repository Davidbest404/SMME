using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 腿_竜 : 獣腿
	{
		public 腿_竜(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 腿_竜D e)
		{
			腿_竜.<>c__DisplayClass36_0 CS$<>8__locals1 = new 腿_竜.<>c__DisplayClass36_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.脚左["四足腿"][3]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_腿 = pars["腿"].ToPar();
			Pars pars2 = pars["鱗下"].ToPars();
			this.X0Y0_竜性_鱗下_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y0_竜性_鱗下_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y0_竜性_鱗下_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y0_竜性_鱗下_鱗4 = pars2["鱗4"].ToPar();
			this.X0Y0_竜性_鱗下_鱗5 = pars2["鱗5"].ToPar();
			this.X0Y0_竜性_鱗下_鱗6 = pars2["鱗6"].ToPar();
			pars2 = pars["鱗上"].ToPars();
			this.X0Y0_竜性_鱗上_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y0_竜性_鱗上_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y0_竜性_鱗上_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y0_竜性_鱗上_鱗4 = pars2["鱗4"].ToPar();
			this.X0Y0_筋 = pars["筋"].ToPar();
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
			this.腿_表示 = e.腿_表示;
			this.竜性_鱗下_鱗1_表示 = e.竜性_鱗下_鱗1_表示;
			this.竜性_鱗下_鱗2_表示 = e.竜性_鱗下_鱗2_表示;
			this.竜性_鱗下_鱗3_表示 = e.竜性_鱗下_鱗3_表示;
			this.竜性_鱗下_鱗4_表示 = e.竜性_鱗下_鱗4_表示;
			this.竜性_鱗下_鱗5_表示 = e.竜性_鱗下_鱗5_表示;
			this.竜性_鱗下_鱗6_表示 = e.竜性_鱗下_鱗6_表示;
			this.竜性_鱗上_鱗1_表示 = e.竜性_鱗上_鱗1_表示;
			this.竜性_鱗上_鱗2_表示 = e.竜性_鱗上_鱗2_表示;
			this.竜性_鱗上_鱗3_表示 = e.竜性_鱗上_鱗3_表示;
			this.竜性_鱗上_鱗4_表示 = e.竜性_鱗上_鱗4_表示;
			this.筋_表示 = e.筋_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.脚_接続.Count > 0)
			{
				Ele f;
				this.脚_接続 = e.脚_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.腿_竜_脚_接続;
					f.接続(CS$<>8__locals1.<>4__this.脚_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_腿CP = new ColorP(this.X0Y0_腿, this.腿CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗下_鱗1CP = new ColorP(this.X0Y0_竜性_鱗下_鱗1, this.竜性_鱗下_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗下_鱗2CP = new ColorP(this.X0Y0_竜性_鱗下_鱗2, this.竜性_鱗下_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗下_鱗3CP = new ColorP(this.X0Y0_竜性_鱗下_鱗3, this.竜性_鱗下_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗下_鱗4CP = new ColorP(this.X0Y0_竜性_鱗下_鱗4, this.竜性_鱗下_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗下_鱗5CP = new ColorP(this.X0Y0_竜性_鱗下_鱗5, this.竜性_鱗下_鱗5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗下_鱗6CP = new ColorP(this.X0Y0_竜性_鱗下_鱗6, this.竜性_鱗下_鱗6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗上_鱗1CP = new ColorP(this.X0Y0_竜性_鱗上_鱗1, this.竜性_鱗上_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗上_鱗2CP = new ColorP(this.X0Y0_竜性_鱗上_鱗2, this.竜性_鱗上_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗上_鱗3CP = new ColorP(this.X0Y0_竜性_鱗上_鱗3, this.竜性_鱗上_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗上_鱗4CP = new ColorP(this.X0Y0_竜性_鱗上_鱗4, this.竜性_鱗上_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_筋CP = new ColorP(this.X0Y0_筋, this.筋CD, CS$<>8__locals1.DisUnit, false);
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
				this.筋_表示 = this.筋肉_;
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

		public bool 腿_表示
		{
			get
			{
				return this.X0Y0_腿.Dra;
			}
			set
			{
				this.X0Y0_腿.Dra = value;
				this.X0Y0_腿.Hit = value;
			}
		}

		public bool 竜性_鱗下_鱗1_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗下_鱗1.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗下_鱗1.Dra = value;
				this.X0Y0_竜性_鱗下_鱗1.Hit = value;
			}
		}

		public bool 竜性_鱗下_鱗2_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗下_鱗2.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗下_鱗2.Dra = value;
				this.X0Y0_竜性_鱗下_鱗2.Hit = value;
			}
		}

		public bool 竜性_鱗下_鱗3_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗下_鱗3.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗下_鱗3.Dra = value;
				this.X0Y0_竜性_鱗下_鱗3.Hit = value;
			}
		}

		public bool 竜性_鱗下_鱗4_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗下_鱗4.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗下_鱗4.Dra = value;
				this.X0Y0_竜性_鱗下_鱗4.Hit = value;
			}
		}

		public bool 竜性_鱗下_鱗5_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗下_鱗5.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗下_鱗5.Dra = value;
				this.X0Y0_竜性_鱗下_鱗5.Hit = value;
			}
		}

		public bool 竜性_鱗下_鱗6_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗下_鱗6.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗下_鱗6.Dra = value;
				this.X0Y0_竜性_鱗下_鱗6.Hit = value;
			}
		}

		public bool 竜性_鱗上_鱗1_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗上_鱗1.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗上_鱗1.Dra = value;
				this.X0Y0_竜性_鱗上_鱗1.Hit = value;
			}
		}

		public bool 竜性_鱗上_鱗2_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗上_鱗2.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗上_鱗2.Dra = value;
				this.X0Y0_竜性_鱗上_鱗2.Hit = value;
			}
		}

		public bool 竜性_鱗上_鱗3_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗上_鱗3.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗上_鱗3.Dra = value;
				this.X0Y0_竜性_鱗上_鱗3.Hit = value;
			}
		}

		public bool 竜性_鱗上_鱗4_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗上_鱗4.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗上_鱗4.Dra = value;
				this.X0Y0_竜性_鱗上_鱗4.Hit = value;
			}
		}

		public bool 筋_表示
		{
			get
			{
				return this.X0Y0_筋.Dra;
			}
			set
			{
				this.X0Y0_筋.Dra = value;
				this.X0Y0_筋.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.腿_表示;
			}
			set
			{
				this.腿_表示 = value;
				this.竜性_鱗下_鱗1_表示 = value;
				this.竜性_鱗下_鱗2_表示 = value;
				this.竜性_鱗下_鱗3_表示 = value;
				this.竜性_鱗下_鱗4_表示 = value;
				this.竜性_鱗下_鱗5_表示 = value;
				this.竜性_鱗下_鱗6_表示 = value;
				this.竜性_鱗上_鱗1_表示 = value;
				this.竜性_鱗上_鱗2_表示 = value;
				this.竜性_鱗上_鱗3_表示 = value;
				this.竜性_鱗上_鱗4_表示 = value;
				this.筋_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.腿CD.不透明度;
			}
			set
			{
				this.腿CD.不透明度 = value;
				this.竜性_鱗下_鱗1CD.不透明度 = value;
				this.竜性_鱗下_鱗2CD.不透明度 = value;
				this.竜性_鱗下_鱗3CD.不透明度 = value;
				this.竜性_鱗下_鱗4CD.不透明度 = value;
				this.竜性_鱗下_鱗5CD.不透明度 = value;
				this.竜性_鱗下_鱗6CD.不透明度 = value;
				this.竜性_鱗上_鱗1CD.不透明度 = value;
				this.竜性_鱗上_鱗2CD.不透明度 = value;
				this.竜性_鱗上_鱗3CD.不透明度 = value;
				this.竜性_鱗上_鱗4CD.不透明度 = value;
				this.筋CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_腿.AngleBase = num * 144.0;
			this.本体.JoinPAall();
		}

		public JointS 脚_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腿, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_腿CP.Update();
			this.X0Y0_竜性_鱗下_鱗1CP.Update();
			this.X0Y0_竜性_鱗下_鱗2CP.Update();
			this.X0Y0_竜性_鱗下_鱗3CP.Update();
			this.X0Y0_竜性_鱗下_鱗4CP.Update();
			this.X0Y0_竜性_鱗下_鱗5CP.Update();
			this.X0Y0_竜性_鱗下_鱗6CP.Update();
			this.X0Y0_竜性_鱗上_鱗1CP.Update();
			this.X0Y0_竜性_鱗上_鱗2CP.Update();
			this.X0Y0_竜性_鱗上_鱗3CP.Update();
			this.X0Y0_竜性_鱗上_鱗4CP.Update();
			this.X0Y0_筋CP.Update();
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
			this.腿CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗下_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗下_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗下_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗下_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗下_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗下_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗上_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗上_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗上_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗上_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.腿CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗下_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗下_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗下_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗下_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗下_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗下_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗上_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗上_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗上_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗上_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.腿CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗下_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗下_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗下_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗下_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗下_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗下_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗上_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗上_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗上_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗上_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
		}

		public Par X0Y0_腿;

		public Par X0Y0_竜性_鱗下_鱗1;

		public Par X0Y0_竜性_鱗下_鱗2;

		public Par X0Y0_竜性_鱗下_鱗3;

		public Par X0Y0_竜性_鱗下_鱗4;

		public Par X0Y0_竜性_鱗下_鱗5;

		public Par X0Y0_竜性_鱗下_鱗6;

		public Par X0Y0_竜性_鱗上_鱗1;

		public Par X0Y0_竜性_鱗上_鱗2;

		public Par X0Y0_竜性_鱗上_鱗3;

		public Par X0Y0_竜性_鱗上_鱗4;

		public Par X0Y0_筋;

		public ColorD 腿CD;

		public ColorD 竜性_鱗下_鱗1CD;

		public ColorD 竜性_鱗下_鱗2CD;

		public ColorD 竜性_鱗下_鱗3CD;

		public ColorD 竜性_鱗下_鱗4CD;

		public ColorD 竜性_鱗下_鱗5CD;

		public ColorD 竜性_鱗下_鱗6CD;

		public ColorD 竜性_鱗上_鱗1CD;

		public ColorD 竜性_鱗上_鱗2CD;

		public ColorD 竜性_鱗上_鱗3CD;

		public ColorD 竜性_鱗上_鱗4CD;

		public ColorD 筋CD;

		public ColorP X0Y0_腿CP;

		public ColorP X0Y0_竜性_鱗下_鱗1CP;

		public ColorP X0Y0_竜性_鱗下_鱗2CP;

		public ColorP X0Y0_竜性_鱗下_鱗3CP;

		public ColorP X0Y0_竜性_鱗下_鱗4CP;

		public ColorP X0Y0_竜性_鱗下_鱗5CP;

		public ColorP X0Y0_竜性_鱗下_鱗6CP;

		public ColorP X0Y0_竜性_鱗上_鱗1CP;

		public ColorP X0Y0_竜性_鱗上_鱗2CP;

		public ColorP X0Y0_竜性_鱗上_鱗3CP;

		public ColorP X0Y0_竜性_鱗上_鱗4CP;

		public ColorP X0Y0_筋CP;
	}
}
