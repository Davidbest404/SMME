using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 肩 : Ele
	{
		public 肩(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 肩D e)
		{
			肩.<>c__DisplayClass33_0 CS$<>8__locals1 = new 肩.<>c__DisplayClass33_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.肩左["肩"]);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["脇"].ToPars();
			this.X0Y0_脇_脇 = pars2["脇"].ToPar();
			this.X0Y0_脇_筋肉 = pars2["筋肉"].ToPar();
			pars2 = pars["肩"].ToPars();
			this.X0Y0_肩_肩 = pars2["肩"].ToPar();
			Pars pars3 = pars2["虫性"].ToPars();
			this.X0Y0_肩_虫性_甲殻1 = pars3["甲殻1"].ToPar();
			this.X0Y0_肩_虫性_甲殻2 = pars3["甲殻2"].ToPar();
			this.X0Y0_肩_傷I1 = pars2["傷I1"].ToPar();
			this.X0Y0_肩_傷I2 = pars2["傷I2"].ToPar();
			this.X0Y0_肩_傷I3 = pars2["傷I3"].ToPar();
			this.X0Y0_肩_傷I4 = pars2["傷I4"].ToPar();
			this.X0Y0_肩_シャツ = pars2["シャツ"].ToPar();
			this.X0Y0_肩_ナ\u30FCス = pars2["ナース"].ToPar();
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
			this.脇_脇_表示 = e.脇_脇_表示;
			this.脇_筋肉_表示 = e.脇_筋肉_表示;
			this.肩_表示 = e.肩_表示;
			this.肩_虫性_甲殻1_表示 = e.肩_虫性_甲殻1_表示;
			this.肩_虫性_甲殻2_表示 = e.肩_虫性_甲殻2_表示;
			this.肩_傷I1_表示 = e.肩_傷I1_表示;
			this.肩_傷I2_表示 = e.肩_傷I2_表示;
			this.肩_傷I3_表示 = e.肩_傷I3_表示;
			this.肩_傷I4_表示 = e.肩_傷I4_表示;
			this.肩_シャツ_表示 = e.肩_シャツ_表示;
			this.肩_ナ\u30FCス_表示 = e.肩_ナ\u30FCス_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.上腕_接続.Count > 0)
			{
				Ele f;
				this.上腕_接続 = e.上腕_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.肩_上腕_接続;
					f.接続(CS$<>8__locals1.<>4__this.上腕_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_脇_脇CP = new ColorP(this.X0Y0_脇_脇, this.脇_脇CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脇_筋肉CP = new ColorP(this.X0Y0_脇_筋肉, this.脇_筋肉CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_肩_肩CP = new ColorP(this.X0Y0_肩_肩, this.肩_肩CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_肩_虫性_甲殻1CP = new ColorP(this.X0Y0_肩_虫性_甲殻1, this.肩_虫性_甲殻1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_肩_虫性_甲殻2CP = new ColorP(this.X0Y0_肩_虫性_甲殻2, this.肩_虫性_甲殻2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_肩_傷I1CP = new ColorP(this.X0Y0_肩_傷I1, this.肩_傷I1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_肩_傷I2CP = new ColorP(this.X0Y0_肩_傷I2, this.肩_傷I2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_肩_傷I3CP = new ColorP(this.X0Y0_肩_傷I3, this.肩_傷I3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_肩_傷I4CP = new ColorP(this.X0Y0_肩_傷I4, this.肩_傷I4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_肩_シャツCP = new ColorP(this.X0Y0_肩_シャツ, this.肩_シャツCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_肩_ナ\u30FCスCP = new ColorP(this.X0Y0_肩_ナ\u30FCス, this.肩_ナ\u30FCスCD, CS$<>8__locals1.DisUnit, true);
			this.濃度 = e.濃度;
			this.X0Y0_脇_脇.BasePointBase = this.X0Y0_脇_脇.BasePointBase.AddY(-0.001);
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
				this.脇_筋肉_表示 = this.筋肉_;
				this.X0Y0_脇_脇.OP.ExpansionXY(this.X0Y0_脇_脇.OP.GetCenter(), 0.0005);
				this.X0Y0_脇_脇.JP.ExpansionXY(this.X0Y0_脇_脇.JP.GetCenter(), 0.0005);
				this.X0Y0_肩_肩.OP.ExpansionXY(this.X0Y0_肩_肩.OP.GetCenter(), 0.0005);
				this.X0Y0_肩_肩.JP.ExpansionXY(this.X0Y0_肩_肩.JP.GetCenter(), 0.0005);
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

		public bool 脇_脇_表示
		{
			get
			{
				return this.X0Y0_脇_脇.Dra;
			}
			set
			{
				this.X0Y0_脇_脇.Dra = value;
				this.X0Y0_脇_脇.Hit = value;
			}
		}

		public bool 脇_筋肉_表示
		{
			get
			{
				return this.X0Y0_脇_筋肉.Dra;
			}
			set
			{
				this.X0Y0_脇_筋肉.Dra = value;
				this.X0Y0_脇_筋肉.Hit = value;
			}
		}

		public bool 肩_表示
		{
			get
			{
				return this.X0Y0_肩_肩.Dra;
			}
			set
			{
				this.X0Y0_肩_肩.Dra = value;
				this.X0Y0_肩_肩.Hit = value;
			}
		}

		public bool 肩_虫性_甲殻1_表示
		{
			get
			{
				return this.X0Y0_肩_虫性_甲殻1.Dra;
			}
			set
			{
				this.X0Y0_肩_虫性_甲殻1.Dra = value;
				this.X0Y0_肩_虫性_甲殻1.Hit = value;
			}
		}

		public bool 肩_虫性_甲殻2_表示
		{
			get
			{
				return this.X0Y0_肩_虫性_甲殻2.Dra;
			}
			set
			{
				this.X0Y0_肩_虫性_甲殻2.Dra = value;
				this.X0Y0_肩_虫性_甲殻2.Hit = value;
			}
		}

		public bool 肩_傷I1_表示
		{
			get
			{
				return this.X0Y0_肩_傷I1.Dra;
			}
			set
			{
				this.X0Y0_肩_傷I1.Dra = value;
				this.X0Y0_肩_傷I1.Hit = value;
			}
		}

		public bool 肩_傷I2_表示
		{
			get
			{
				return this.X0Y0_肩_傷I2.Dra;
			}
			set
			{
				this.X0Y0_肩_傷I2.Dra = value;
				this.X0Y0_肩_傷I2.Hit = value;
			}
		}

		public bool 肩_傷I3_表示
		{
			get
			{
				return this.X0Y0_肩_傷I3.Dra;
			}
			set
			{
				this.X0Y0_肩_傷I3.Dra = value;
				this.X0Y0_肩_傷I3.Hit = value;
			}
		}

		public bool 肩_傷I4_表示
		{
			get
			{
				return this.X0Y0_肩_傷I4.Dra;
			}
			set
			{
				this.X0Y0_肩_傷I4.Dra = value;
				this.X0Y0_肩_傷I4.Hit = value;
			}
		}

		public bool 肩_シャツ_表示
		{
			get
			{
				return this.X0Y0_肩_シャツ.Dra;
			}
			set
			{
				this.X0Y0_肩_シャツ.Dra = value;
				this.X0Y0_肩_シャツ.Hit = value;
			}
		}

		public bool 肩_ナ\u30FCス_表示
		{
			get
			{
				return this.X0Y0_肩_ナ\u30FCス.Dra;
			}
			set
			{
				this.X0Y0_肩_ナ\u30FCス.Dra = value;
				this.X0Y0_肩_ナ\u30FCス.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.脇_脇_表示;
			}
			set
			{
				this.脇_脇_表示 = value;
				this.脇_筋肉_表示 = value;
				this.肩_表示 = value;
				this.肩_虫性_甲殻1_表示 = value;
				this.肩_虫性_甲殻2_表示 = value;
				this.肩_傷I1_表示 = value;
				this.肩_傷I2_表示 = value;
				this.肩_傷I3_表示 = value;
				this.肩_傷I4_表示 = value;
				this.肩_シャツ_表示 = value;
				this.肩_ナ\u30FCス_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.脇_脇CD.不透明度;
			}
			set
			{
				this.脇_脇CD.不透明度 = value;
				this.脇_筋肉CD.不透明度 = value;
				this.肩_肩CD.不透明度 = value;
				this.肩_虫性_甲殻1CD.不透明度 = value;
				this.肩_虫性_甲殻2CD.不透明度 = value;
				this.肩_傷I1CD.不透明度 = value;
				this.肩_傷I2CD.不透明度 = value;
				this.肩_傷I3CD.不透明度 = value;
				this.肩_傷I4CD.不透明度 = value;
				this.肩_シャツCD.不透明度 = value;
				this.肩_ナ\u30FCスCD.不透明度 = value;
			}
		}

		public void 脇描画(Are Are)
		{
			Are.Draw(this.X0Y0_脇_脇);
			Are.Draw(this.X0Y0_脇_筋肉);
		}

		public void 服描画(Are Are)
		{
			Are.Draw(this.X0Y0_肩_シャツ);
			Are.Draw(this.X0Y0_肩_ナ\u30FCス);
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_肩_肩);
			Are.Draw(this.X0Y0_肩_傷I1);
			Are.Draw(this.X0Y0_肩_傷I2);
			Are.Draw(this.X0Y0_肩_傷I3);
			Are.Draw(this.X0Y0_肩_傷I4);
			this.キスマ\u30FCク.Draw(Are);
			this.鞭痕.Draw(Are);
			Are.Draw(this.X0Y0_肩_虫性_甲殻1);
			Are.Draw(this.X0Y0_肩_虫性_甲殻2);
		}

		public override bool Is布(Par p)
		{
			return p == this.X0Y0_肩_シャツ || p == this.X0Y0_肩_ナ\u30FCス;
		}

		public JointS 上腕_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_肩_肩, 1);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_脇_脇CP.Update();
			this.X0Y0_脇_筋肉CP.Update();
			this.X0Y0_肩_肩CP.Update();
			this.X0Y0_肩_虫性_甲殻1CP.Update();
			this.X0Y0_肩_虫性_甲殻2CP.Update();
			this.X0Y0_肩_傷I1CP.Update();
			this.X0Y0_肩_傷I2CP.Update();
			this.X0Y0_肩_傷I3CP.Update();
			this.X0Y0_肩_傷I4CP.Update();
		}

		public void シャツ色更新(Vector2D[] シャツ)
		{
			this.X0Y0_肩_シャツCP.Update(シャツ);
		}

		public void ナ\u30FCス色更新(Vector2D[] ナ\u30FCス)
		{
			this.X0Y0_肩_ナ\u30FCスCP.Update(ナ\u30FCス);
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.脇_脇CD = new ColorD(ref Col.Black, ref 体配色.人肌R);
			this.脇_筋肉CD = new ColorD(ref Col.Black, ref 体配色.人肌R);
			this.肩_肩CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.肩_虫性_甲殻1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.肩_虫性_甲殻2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.肩_傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.肩_傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.肩_傷I3CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.肩_傷I4CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.肩_シャツCD = new ColorD();
			this.肩_ナ\u30FCスCD = new ColorD();
		}

		public Par X0Y0_脇_脇;

		public Par X0Y0_脇_筋肉;

		public Par X0Y0_肩_肩;

		public Par X0Y0_肩_虫性_甲殻1;

		public Par X0Y0_肩_虫性_甲殻2;

		public Par X0Y0_肩_傷I1;

		public Par X0Y0_肩_傷I2;

		public Par X0Y0_肩_傷I3;

		public Par X0Y0_肩_傷I4;

		public Par X0Y0_肩_シャツ;

		public Par X0Y0_肩_ナ\u30FCス;

		public ColorD 脇_脇CD;

		public ColorD 脇_筋肉CD;

		public ColorD 肩_肩CD;

		public ColorD 肩_虫性_甲殻1CD;

		public ColorD 肩_虫性_甲殻2CD;

		public ColorD 肩_傷I1CD;

		public ColorD 肩_傷I2CD;

		public ColorD 肩_傷I3CD;

		public ColorD 肩_傷I4CD;

		public ColorD 肩_シャツCD;

		public ColorD 肩_ナ\u30FCスCD;

		public ColorP X0Y0_脇_脇CP;

		public ColorP X0Y0_脇_筋肉CP;

		public ColorP X0Y0_肩_肩CP;

		public ColorP X0Y0_肩_虫性_甲殻1CP;

		public ColorP X0Y0_肩_虫性_甲殻2CP;

		public ColorP X0Y0_肩_傷I1CP;

		public ColorP X0Y0_肩_傷I2CP;

		public ColorP X0Y0_肩_傷I3CP;

		public ColorP X0Y0_肩_傷I4CP;

		public ColorP X0Y0_肩_シャツCP;

		public ColorP X0Y0_肩_ナ\u30FCスCP;

		public スタンプK キスマ\u30FCク;

		public スタンプW 鞭痕;

		public Ele[] 上腕_接続;
	}
}
