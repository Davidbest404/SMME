using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 上腕_蝙 : 翼上腕
	{
		public 上腕_蝙(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 上腕_蝙D e)
		{
			上腕_蝙.<>c__DisplayClass22_0 CS$<>8__locals1 = new 上腕_蝙.<>c__DisplayClass22_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.飛膜 = new 飛膜_根(CS$<>8__locals1.DisUnit, 配色指定, CS$<>8__locals1.体配色);
			this.飛膜.Par = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.腕左["獣翼上腕"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_獣翼上腕 = pars["獣翼上腕"].ToPar();
			Pars pars2 = pars["鱗"].ToPars();
			this.X0Y0_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y0_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y0_竜性_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y0_竜性_鱗4 = pars2["鱗4"].ToPar();
			this.X0Y0_竜性_鱗5 = pars2["鱗5"].ToPar();
			this.X0Y0_竜性_鱗6 = pars2["鱗6"].ToPar();
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
			this.獣翼上腕_表示 = e.獣翼上腕_表示;
			this.竜性_鱗1_表示 = e.竜性_鱗1_表示;
			this.竜性_鱗2_表示 = e.竜性_鱗2_表示;
			this.竜性_鱗3_表示 = e.竜性_鱗3_表示;
			this.竜性_鱗4_表示 = e.竜性_鱗4_表示;
			this.竜性_鱗5_表示 = e.竜性_鱗5_表示;
			this.竜性_鱗6_表示 = e.竜性_鱗6_表示;
			this.飛膜_表示 = e.飛膜_表示;
			this.展開 = e.展開;
			this.下部_外線 = e.下部_外線;
			this.接部_外線 = e.接部_外線;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.下腕_接続.Count > 0)
			{
				Ele f;
				this.下腕_接続 = e.下腕_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.上腕_蝙_下腕_接続;
					f.接続(CS$<>8__locals1.<>4__this.下腕_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_獣翼上腕CP = new ColorP(this.X0Y0_獣翼上腕, this.獣翼上腕CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗1CP = new ColorP(this.X0Y0_竜性_鱗1, this.竜性_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗2CP = new ColorP(this.X0Y0_竜性_鱗2, this.竜性_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗3CP = new ColorP(this.X0Y0_竜性_鱗3, this.竜性_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗4CP = new ColorP(this.X0Y0_竜性_鱗4, this.竜性_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗5CP = new ColorP(this.X0Y0_竜性_鱗5, this.竜性_鱗5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗6CP = new ColorP(this.X0Y0_竜性_鱗6, this.竜性_鱗6CD, CS$<>8__locals1.DisUnit, true);
			this.濃度 = e.濃度;
			this.尺度B = 1.02;
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
				this.飛膜.欠損 = value;
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
				this.飛膜.筋肉 = value;
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
				this.飛膜.筋肉 = value;
			}
		}

		public bool 獣翼上腕_表示
		{
			get
			{
				return this.X0Y0_獣翼上腕.Dra;
			}
			set
			{
				this.X0Y0_獣翼上腕.Dra = value;
				this.X0Y0_獣翼上腕.Hit = value;
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

		public bool 竜性_鱗4_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗4.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗4.Dra = value;
				this.X0Y0_竜性_鱗4.Hit = value;
			}
		}

		public bool 竜性_鱗5_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗5.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗5.Dra = value;
				this.X0Y0_竜性_鱗5.Hit = value;
			}
		}

		public bool 竜性_鱗6_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗6.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗6.Dra = value;
				this.X0Y0_竜性_鱗6.Hit = value;
			}
		}

		public bool 飛膜_表示
		{
			get
			{
				return this.飛膜.飛膜_表示;
			}
			set
			{
				this.飛膜.飛膜_表示 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.獣翼上腕_表示;
			}
			set
			{
				this.獣翼上腕_表示 = value;
				this.竜性_鱗1_表示 = value;
				this.竜性_鱗2_表示 = value;
				this.竜性_鱗3_表示 = value;
				this.竜性_鱗4_表示 = value;
				this.竜性_鱗5_表示 = value;
				this.竜性_鱗6_表示 = value;
				this.飛膜_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.獣翼上腕CD.不透明度;
			}
			set
			{
				this.獣翼上腕CD.不透明度 = value;
				this.竜性_鱗1CD.不透明度 = value;
				this.竜性_鱗2CD.不透明度 = value;
				this.竜性_鱗3CD.不透明度 = value;
				this.竜性_鱗4CD.不透明度 = value;
				this.竜性_鱗5CD.不透明度 = value;
				this.竜性_鱗6CD.不透明度 = value;
				this.飛膜.飛膜CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_獣翼上腕.AngleBase = num * 0.0;
			this.本体.JoinPAall();
		}

		public override double 展開
		{
			set
			{
				double num = value.Inverse();
				double num2 = this.右 ? -1.0 : 1.0;
				this.X0Y0_獣翼上腕.AngleCont = num2 * -68.0 * num;
			}
		}

		public bool 下部_外線
		{
			get
			{
				return this.X0Y0_獣翼上腕.OP[this.右 ? 3 : 0].Outline;
			}
			set
			{
				this.X0Y0_獣翼上腕.OP[this.右 ? 3 : 0].Outline = value;
				this.X0Y0_獣翼上腕.OP[this.右 ? 2 : 1].Outline = value;
			}
		}

		public bool 接部_外線
		{
			get
			{
				return this.飛膜.接部_外線;
			}
			set
			{
				this.飛膜.接部_外線 = value;
			}
		}

		public override double 尺度B
		{
			get
			{
				return base.尺度B;
			}
			set
			{
				base.尺度B = value;
				this.飛膜.尺度B = value;
			}
		}

		public override double 尺度C
		{
			get
			{
				return base.尺度C;
			}
			set
			{
				base.尺度C = value;
				this.飛膜.尺度C = value;
			}
		}

		public override double 尺度XB
		{
			get
			{
				return base.尺度XB;
			}
			set
			{
				base.尺度XB = value;
				this.飛膜.尺度XB = value;
			}
		}

		public override double 尺度XC
		{
			get
			{
				return base.尺度XC;
			}
			set
			{
				base.尺度XC = value;
				this.飛膜.尺度XC = value;
			}
		}

		public override double 尺度YB
		{
			get
			{
				return base.尺度YB;
			}
			set
			{
				base.尺度YB = value;
				this.飛膜.尺度YB = value;
			}
		}

		public override double 尺度YC
		{
			get
			{
				return base.尺度YC;
			}
			set
			{
				base.尺度YC = value;
				this.飛膜.尺度YC = value;
			}
		}

		public override double 肥大
		{
			set
			{
				base.肥大 = value;
				this.飛膜.肥大 = value;
			}
		}

		public override double 身長
		{
			set
			{
				base.身長 = value;
				this.飛膜.身長 = value;
			}
		}

		public override bool 右
		{
			get
			{
				return base.右;
			}
			set
			{
				base.右 = value;
				this.飛膜.右 = value;
			}
		}

		public override bool 反転X
		{
			get
			{
				return base.反転X;
			}
			set
			{
				base.反転X = value;
				this.飛膜.反転X = value;
			}
		}

		public override bool 反転Y
		{
			get
			{
				return base.反転Y;
			}
			set
			{
				base.反転Y = value;
				this.飛膜.反転Y = value;
			}
		}

		public override double Xv
		{
			get
			{
				return base.Xv;
			}
			set
			{
				base.Xv = value;
				this.飛膜.Xv = value;
			}
		}

		public override double Yv
		{
			get
			{
				return base.Yv;
			}
			set
			{
				base.Yv = value;
				this.飛膜.Yv = value;
			}
		}

		public override int Xi
		{
			get
			{
				return base.Xi;
			}
			set
			{
				base.Xi = value;
				this.飛膜.Xi = value;
			}
		}

		public override int Yi
		{
			get
			{
				return base.Yi;
			}
			set
			{
				base.Yi = value;
				this.飛膜.Yi = value;
			}
		}

		public override void Dispose()
		{
			base.Dispose();
			this.飛膜.Dispose();
		}

		public override double サイズ
		{
			get
			{
				return this.サイズ_;
			}
			set
			{
				base.サイズ = value;
				this.飛膜.サイズ = value;
			}
		}

		public override double サイズX
		{
			get
			{
				return this.サイズX_;
			}
			set
			{
				base.サイズX = value;
				this.飛膜.サイズX = value;
			}
		}

		public override double サイズY
		{
			get
			{
				return this.サイズY_;
			}
			set
			{
				base.サイズY = value;
				this.飛膜.サイズY = value;
			}
		}

		public void 接続(下腕_蝙 下腕, 手_蝙 手, Vector2D 接着点)
		{
			this.飛膜.接続(this, 下腕, 手, 接着点);
		}

		public Vector2D Get飛膜接続点()
		{
			return this.X0Y0_獣翼上腕.ToGlobal(this.右 ? this.X0Y0_獣翼上腕.OP[0].ps[1] : this.X0Y0_獣翼上腕.OP[3].ps[4]);
		}

		public bool 肘部_外線
		{
			get
			{
				return this.X0Y0_獣翼上腕.OP[this.右 ? 2 : 1].Outline;
			}
			set
			{
				this.X0Y0_獣翼上腕.OP[this.右 ? 2 : 1].Outline = value;
			}
		}

		public JointS 下腕_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_獣翼上腕, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_獣翼上腕CP.Update();
			this.X0Y0_竜性_鱗1CP.Update();
			this.X0Y0_竜性_鱗2CP.Update();
			this.X0Y0_竜性_鱗3CP.Update();
			this.X0Y0_竜性_鱗4CP.Update();
			this.X0Y0_竜性_鱗5CP.Update();
			this.X0Y0_竜性_鱗6CP.Update();
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
			this.獣翼上腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.獣翼上腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.獣翼上腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
		}

		public Par X0Y0_獣翼上腕;

		public Par X0Y0_竜性_鱗1;

		public Par X0Y0_竜性_鱗2;

		public Par X0Y0_竜性_鱗3;

		public Par X0Y0_竜性_鱗4;

		public Par X0Y0_竜性_鱗5;

		public Par X0Y0_竜性_鱗6;

		public 飛膜_根 飛膜;

		public ColorD 獣翼上腕CD;

		public ColorD 竜性_鱗1CD;

		public ColorD 竜性_鱗2CD;

		public ColorD 竜性_鱗3CD;

		public ColorD 竜性_鱗4CD;

		public ColorD 竜性_鱗5CD;

		public ColorD 竜性_鱗6CD;

		public ColorP X0Y0_獣翼上腕CP;

		public ColorP X0Y0_竜性_鱗1CP;

		public ColorP X0Y0_竜性_鱗2CP;

		public ColorP X0Y0_竜性_鱗3CP;

		public ColorP X0Y0_竜性_鱗4CP;

		public ColorP X0Y0_竜性_鱗5CP;

		public ColorP X0Y0_竜性_鱗6CP;

		public Func<Vector2D> 接着;
	}
}
