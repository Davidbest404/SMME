using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class T剃刀 : Ele
	{
		public T剃刀(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, T剃刀D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.カ\u30FCソル["T字剃刀"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_ヘッド = pars["ヘッド"].ToPar();
			Pars pars2 = pars["刃"].ToPars();
			this.X0Y0_刃_刃1 = pars2["刃1"].ToPar();
			this.X0Y0_刃_刃2 = pars2["刃2"].ToPar();
			this.X0Y0_首 = pars["首"].ToPar();
			pars2 = pars["グリップ"].ToPars();
			this.X0Y0_グリップ_グリップ0 = pars2["グリップ0"].ToPar();
			this.X0Y0_グリップ_グリップ1 = pars2["グリップ1"].ToPar();
			this.X0Y0_グリップ_グリップ2 = pars2["グリップ2"].ToPar();
			this.X0Y0_グリップ_グリップ3 = pars2["グリップ3"].ToPar();
			this.X0Y0_グリップ_グリップ4 = pars2["グリップ4"].ToPar();
			this.X0Y0_グリップ_グリップ5 = pars2["グリップ5"].ToPar();
			this.X0Y0_グリップ_グリップ6 = pars2["グリップ6"].ToPar();
			this.X0Y0_グリップ_グリップ7 = pars2["グリップ7"].ToPar();
			this.X0Y0_グリップ_グリップ8 = pars2["グリップ8"].ToPar();
			this.X0Y0_グリップ_グリップ9 = pars2["グリップ9"].ToPar();
			this.X0Y0_グリップ_グリップ10 = pars2["グリップ10"].ToPar();
			this.X0Y0_グリップ_グリップ11 = pars2["グリップ11"].ToPar();
			this.X0Y0_グリップ_グリップ12 = pars2["グリップ12"].ToPar();
			this.X0Y0_グリップ_グリップ13 = pars2["グリップ13"].ToPar();
			this.X0Y0_グリップ_グリップ14 = pars2["グリップ14"].ToPar();
			this.X0Y0_グリップ_グリップ15 = pars2["グリップ15"].ToPar();
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
			this.ヘッド_表示 = e.ヘッド_表示;
			this.刃_刃1_表示 = e.刃_刃1_表示;
			this.刃_刃2_表示 = e.刃_刃2_表示;
			this.首_表示 = e.首_表示;
			this.グリップ_グリップ0_表示 = e.グリップ_グリップ0_表示;
			this.グリップ_グリップ1_表示 = e.グリップ_グリップ1_表示;
			this.グリップ_グリップ2_表示 = e.グリップ_グリップ2_表示;
			this.グリップ_グリップ3_表示 = e.グリップ_グリップ3_表示;
			this.グリップ_グリップ4_表示 = e.グリップ_グリップ4_表示;
			this.グリップ_グリップ5_表示 = e.グリップ_グリップ5_表示;
			this.グリップ_グリップ6_表示 = e.グリップ_グリップ6_表示;
			this.グリップ_グリップ7_表示 = e.グリップ_グリップ7_表示;
			this.グリップ_グリップ8_表示 = e.グリップ_グリップ8_表示;
			this.グリップ_グリップ9_表示 = e.グリップ_グリップ9_表示;
			this.グリップ_グリップ10_表示 = e.グリップ_グリップ10_表示;
			this.グリップ_グリップ11_表示 = e.グリップ_グリップ11_表示;
			this.グリップ_グリップ12_表示 = e.グリップ_グリップ12_表示;
			this.グリップ_グリップ13_表示 = e.グリップ_グリップ13_表示;
			this.グリップ_グリップ14_表示 = e.グリップ_グリップ14_表示;
			this.グリップ_グリップ15_表示 = e.グリップ_グリップ15_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_ヘッドCP = new ColorP(this.X0Y0_ヘッド, this.ヘッドCD, DisUnit, true);
			this.X0Y0_刃_刃1CP = new ColorP(this.X0Y0_刃_刃1, this.刃_刃1CD, DisUnit, true);
			this.X0Y0_刃_刃2CP = new ColorP(this.X0Y0_刃_刃2, this.刃_刃2CD, DisUnit, true);
			this.X0Y0_首CP = new ColorP(this.X0Y0_首, this.首CD, DisUnit, true);
			this.X0Y0_グリップ_グリップ0CP = new ColorP(this.X0Y0_グリップ_グリップ0, this.グリップ_グリップ0CD, DisUnit, true);
			this.X0Y0_グリップ_グリップ1CP = new ColorP(this.X0Y0_グリップ_グリップ1, this.グリップ_グリップ1CD, DisUnit, true);
			this.X0Y0_グリップ_グリップ2CP = new ColorP(this.X0Y0_グリップ_グリップ2, this.グリップ_グリップ2CD, DisUnit, true);
			this.X0Y0_グリップ_グリップ3CP = new ColorP(this.X0Y0_グリップ_グリップ3, this.グリップ_グリップ3CD, DisUnit, true);
			this.X0Y0_グリップ_グリップ4CP = new ColorP(this.X0Y0_グリップ_グリップ4, this.グリップ_グリップ4CD, DisUnit, true);
			this.X0Y0_グリップ_グリップ5CP = new ColorP(this.X0Y0_グリップ_グリップ5, this.グリップ_グリップ5CD, DisUnit, true);
			this.X0Y0_グリップ_グリップ6CP = new ColorP(this.X0Y0_グリップ_グリップ6, this.グリップ_グリップ6CD, DisUnit, true);
			this.X0Y0_グリップ_グリップ7CP = new ColorP(this.X0Y0_グリップ_グリップ7, this.グリップ_グリップ7CD, DisUnit, true);
			this.X0Y0_グリップ_グリップ8CP = new ColorP(this.X0Y0_グリップ_グリップ8, this.グリップ_グリップ8CD, DisUnit, true);
			this.X0Y0_グリップ_グリップ9CP = new ColorP(this.X0Y0_グリップ_グリップ9, this.グリップ_グリップ9CD, DisUnit, true);
			this.X0Y0_グリップ_グリップ10CP = new ColorP(this.X0Y0_グリップ_グリップ10, this.グリップ_グリップ10CD, DisUnit, true);
			this.X0Y0_グリップ_グリップ11CP = new ColorP(this.X0Y0_グリップ_グリップ11, this.グリップ_グリップ11CD, DisUnit, true);
			this.X0Y0_グリップ_グリップ12CP = new ColorP(this.X0Y0_グリップ_グリップ12, this.グリップ_グリップ12CD, DisUnit, true);
			this.X0Y0_グリップ_グリップ13CP = new ColorP(this.X0Y0_グリップ_グリップ13, this.グリップ_グリップ13CD, DisUnit, true);
			this.X0Y0_グリップ_グリップ14CP = new ColorP(this.X0Y0_グリップ_グリップ14, this.グリップ_グリップ14CD, DisUnit, true);
			this.X0Y0_グリップ_グリップ15CP = new ColorP(this.X0Y0_グリップ_グリップ15, this.グリップ_グリップ15CD, DisUnit, true);
			this.濃度 = e.濃度;
			Vector2D local = this.X0Y0_刃_刃1.OP[0].ps[1];
			foreach (Par par in this.本体.EnumJoinRoot)
			{
				par.BasePointBase = par.ToLocal(this.X0Y0_刃_刃1.ToGlobal(local));
			}
			this.尺度B = 1.08;
			this.本体.JoinPAall();
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

		public bool ヘッド_表示
		{
			get
			{
				return this.X0Y0_ヘッド.Dra;
			}
			set
			{
				this.X0Y0_ヘッド.Dra = value;
				this.X0Y0_ヘッド.Hit = value;
			}
		}

		public bool 刃_刃1_表示
		{
			get
			{
				return this.X0Y0_刃_刃1.Dra;
			}
			set
			{
				this.X0Y0_刃_刃1.Dra = value;
				this.X0Y0_刃_刃1.Hit = value;
			}
		}

		public bool 刃_刃2_表示
		{
			get
			{
				return this.X0Y0_刃_刃2.Dra;
			}
			set
			{
				this.X0Y0_刃_刃2.Dra = value;
				this.X0Y0_刃_刃2.Hit = value;
			}
		}

		public bool 首_表示
		{
			get
			{
				return this.X0Y0_首.Dra;
			}
			set
			{
				this.X0Y0_首.Dra = value;
				this.X0Y0_首.Hit = value;
			}
		}

		public bool グリップ_グリップ0_表示
		{
			get
			{
				return this.X0Y0_グリップ_グリップ0.Dra;
			}
			set
			{
				this.X0Y0_グリップ_グリップ0.Dra = value;
				this.X0Y0_グリップ_グリップ0.Hit = value;
			}
		}

		public bool グリップ_グリップ1_表示
		{
			get
			{
				return this.X0Y0_グリップ_グリップ1.Dra;
			}
			set
			{
				this.X0Y0_グリップ_グリップ1.Dra = value;
				this.X0Y0_グリップ_グリップ1.Hit = value;
			}
		}

		public bool グリップ_グリップ2_表示
		{
			get
			{
				return this.X0Y0_グリップ_グリップ2.Dra;
			}
			set
			{
				this.X0Y0_グリップ_グリップ2.Dra = value;
				this.X0Y0_グリップ_グリップ2.Hit = value;
			}
		}

		public bool グリップ_グリップ3_表示
		{
			get
			{
				return this.X0Y0_グリップ_グリップ3.Dra;
			}
			set
			{
				this.X0Y0_グリップ_グリップ3.Dra = value;
				this.X0Y0_グリップ_グリップ3.Hit = value;
			}
		}

		public bool グリップ_グリップ4_表示
		{
			get
			{
				return this.X0Y0_グリップ_グリップ4.Dra;
			}
			set
			{
				this.X0Y0_グリップ_グリップ4.Dra = value;
				this.X0Y0_グリップ_グリップ4.Hit = value;
			}
		}

		public bool グリップ_グリップ5_表示
		{
			get
			{
				return this.X0Y0_グリップ_グリップ5.Dra;
			}
			set
			{
				this.X0Y0_グリップ_グリップ5.Dra = value;
				this.X0Y0_グリップ_グリップ5.Hit = value;
			}
		}

		public bool グリップ_グリップ6_表示
		{
			get
			{
				return this.X0Y0_グリップ_グリップ6.Dra;
			}
			set
			{
				this.X0Y0_グリップ_グリップ6.Dra = value;
				this.X0Y0_グリップ_グリップ6.Hit = value;
			}
		}

		public bool グリップ_グリップ7_表示
		{
			get
			{
				return this.X0Y0_グリップ_グリップ7.Dra;
			}
			set
			{
				this.X0Y0_グリップ_グリップ7.Dra = value;
				this.X0Y0_グリップ_グリップ7.Hit = value;
			}
		}

		public bool グリップ_グリップ8_表示
		{
			get
			{
				return this.X0Y0_グリップ_グリップ8.Dra;
			}
			set
			{
				this.X0Y0_グリップ_グリップ8.Dra = value;
				this.X0Y0_グリップ_グリップ8.Hit = value;
			}
		}

		public bool グリップ_グリップ9_表示
		{
			get
			{
				return this.X0Y0_グリップ_グリップ9.Dra;
			}
			set
			{
				this.X0Y0_グリップ_グリップ9.Dra = value;
				this.X0Y0_グリップ_グリップ9.Hit = value;
			}
		}

		public bool グリップ_グリップ10_表示
		{
			get
			{
				return this.X0Y0_グリップ_グリップ10.Dra;
			}
			set
			{
				this.X0Y0_グリップ_グリップ10.Dra = value;
				this.X0Y0_グリップ_グリップ10.Hit = value;
			}
		}

		public bool グリップ_グリップ11_表示
		{
			get
			{
				return this.X0Y0_グリップ_グリップ11.Dra;
			}
			set
			{
				this.X0Y0_グリップ_グリップ11.Dra = value;
				this.X0Y0_グリップ_グリップ11.Hit = value;
			}
		}

		public bool グリップ_グリップ12_表示
		{
			get
			{
				return this.X0Y0_グリップ_グリップ12.Dra;
			}
			set
			{
				this.X0Y0_グリップ_グリップ12.Dra = value;
				this.X0Y0_グリップ_グリップ12.Hit = value;
			}
		}

		public bool グリップ_グリップ13_表示
		{
			get
			{
				return this.X0Y0_グリップ_グリップ13.Dra;
			}
			set
			{
				this.X0Y0_グリップ_グリップ13.Dra = value;
				this.X0Y0_グリップ_グリップ13.Hit = value;
			}
		}

		public bool グリップ_グリップ14_表示
		{
			get
			{
				return this.X0Y0_グリップ_グリップ14.Dra;
			}
			set
			{
				this.X0Y0_グリップ_グリップ14.Dra = value;
				this.X0Y0_グリップ_グリップ14.Hit = value;
			}
		}

		public bool グリップ_グリップ15_表示
		{
			get
			{
				return this.X0Y0_グリップ_グリップ15.Dra;
			}
			set
			{
				this.X0Y0_グリップ_グリップ15.Dra = value;
				this.X0Y0_グリップ_グリップ15.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.ヘッド_表示;
			}
			set
			{
				this.ヘッド_表示 = value;
				this.刃_刃1_表示 = value;
				this.刃_刃2_表示 = value;
				this.首_表示 = value;
				this.グリップ_グリップ0_表示 = value;
				this.グリップ_グリップ1_表示 = value;
				this.グリップ_グリップ2_表示 = value;
				this.グリップ_グリップ3_表示 = value;
				this.グリップ_グリップ4_表示 = value;
				this.グリップ_グリップ5_表示 = value;
				this.グリップ_グリップ6_表示 = value;
				this.グリップ_グリップ7_表示 = value;
				this.グリップ_グリップ8_表示 = value;
				this.グリップ_グリップ9_表示 = value;
				this.グリップ_グリップ10_表示 = value;
				this.グリップ_グリップ11_表示 = value;
				this.グリップ_グリップ12_表示 = value;
				this.グリップ_グリップ13_表示 = value;
				this.グリップ_グリップ14_表示 = value;
				this.グリップ_グリップ15_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.ヘッドCD.不透明度;
			}
			set
			{
				this.ヘッドCD.不透明度 = value;
				this.刃_刃1CD.不透明度 = value;
				this.刃_刃2CD.不透明度 = value;
				this.首CD.不透明度 = value;
				this.グリップ_グリップ0CD.不透明度 = value;
				this.グリップ_グリップ1CD.不透明度 = value;
				this.グリップ_グリップ2CD.不透明度 = value;
				this.グリップ_グリップ3CD.不透明度 = value;
				this.グリップ_グリップ4CD.不透明度 = value;
				this.グリップ_グリップ5CD.不透明度 = value;
				this.グリップ_グリップ6CD.不透明度 = value;
				this.グリップ_グリップ7CD.不透明度 = value;
				this.グリップ_グリップ8CD.不透明度 = value;
				this.グリップ_グリップ9CD.不透明度 = value;
				this.グリップ_グリップ10CD.不透明度 = value;
				this.グリップ_グリップ11CD.不透明度 = value;
				this.グリップ_グリップ12CD.不透明度 = value;
				this.グリップ_グリップ13CD.不透明度 = value;
				this.グリップ_グリップ14CD.不透明度 = value;
				this.グリップ_グリップ15CD.不透明度 = value;
			}
		}

		public override void 色更新()
		{
			this.X0Y0_ヘッドCP.Update();
			this.X0Y0_刃_刃1CP.Update();
			this.X0Y0_刃_刃2CP.Update();
			this.X0Y0_首CP.Update();
			this.X0Y0_グリップ_グリップ0CP.Update();
			this.X0Y0_グリップ_グリップ1CP.Update();
			this.X0Y0_グリップ_グリップ2CP.Update();
			this.X0Y0_グリップ_グリップ3CP.Update();
			this.X0Y0_グリップ_グリップ4CP.Update();
			this.X0Y0_グリップ_グリップ5CP.Update();
			this.X0Y0_グリップ_グリップ6CP.Update();
			this.X0Y0_グリップ_グリップ7CP.Update();
			this.X0Y0_グリップ_グリップ8CP.Update();
			this.X0Y0_グリップ_グリップ9CP.Update();
			this.X0Y0_グリップ_グリップ10CP.Update();
			this.X0Y0_グリップ_グリップ11CP.Update();
			this.X0Y0_グリップ_グリップ12CP.Update();
			this.X0Y0_グリップ_グリップ13CP.Update();
			this.X0Y0_グリップ_グリップ14CP.Update();
			this.X0Y0_グリップ_グリップ15CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.ヘッドCD = new ColorD();
			this.ヘッドCD.線 = Col.Black;
			this.ヘッドCD.色 = new Color2(ref Col.Black, ref Col.Empty);
			Color2 color;
			Col.GetGrad(ref Col.DarkGray, out color);
			this.刃_刃1CD = new ColorD(ref Col.Black, ref color);
			this.刃_刃2CD = new ColorD(ref Col.Black, ref color);
			this.首CD = new ColorD(ref Col.Black, ref color);
			color = new Color2(ref Col.DimGray, ref Col.Black);
			this.グリップ_グリップ0CD = new ColorD(ref Col.Black, ref color);
			this.グリップ_グリップ1CD = new ColorD(ref Col.Black, ref color);
			this.グリップ_グリップ2CD = new ColorD(ref Col.Black, ref color);
			this.グリップ_グリップ3CD = new ColorD(ref Col.Black, ref color);
			this.グリップ_グリップ4CD = new ColorD(ref Col.Black, ref color);
			this.グリップ_グリップ5CD = new ColorD(ref Col.Black, ref color);
			this.グリップ_グリップ6CD = new ColorD(ref Col.Black, ref color);
			this.グリップ_グリップ7CD = new ColorD(ref Col.Black, ref color);
			this.グリップ_グリップ8CD = new ColorD(ref Col.Black, ref color);
			this.グリップ_グリップ9CD = new ColorD(ref Col.Black, ref color);
			this.グリップ_グリップ10CD = new ColorD(ref Col.Black, ref color);
			this.グリップ_グリップ11CD = new ColorD(ref Col.Black, ref color);
			this.グリップ_グリップ12CD = new ColorD(ref Col.Black, ref color);
			this.グリップ_グリップ13CD = new ColorD(ref Col.Black, ref color);
			this.グリップ_グリップ14CD = new ColorD(ref Col.Black, ref color);
			this.グリップ_グリップ15CD = new ColorD(ref Col.Black, ref color);
		}

		public Par X0Y0_ヘッド;

		public Par X0Y0_刃_刃1;

		public Par X0Y0_刃_刃2;

		public Par X0Y0_首;

		public Par X0Y0_グリップ_グリップ0;

		public Par X0Y0_グリップ_グリップ1;

		public Par X0Y0_グリップ_グリップ2;

		public Par X0Y0_グリップ_グリップ3;

		public Par X0Y0_グリップ_グリップ4;

		public Par X0Y0_グリップ_グリップ5;

		public Par X0Y0_グリップ_グリップ6;

		public Par X0Y0_グリップ_グリップ7;

		public Par X0Y0_グリップ_グリップ8;

		public Par X0Y0_グリップ_グリップ9;

		public Par X0Y0_グリップ_グリップ10;

		public Par X0Y0_グリップ_グリップ11;

		public Par X0Y0_グリップ_グリップ12;

		public Par X0Y0_グリップ_グリップ13;

		public Par X0Y0_グリップ_グリップ14;

		public Par X0Y0_グリップ_グリップ15;

		public ColorD ヘッドCD;

		public ColorD 刃_刃1CD;

		public ColorD 刃_刃2CD;

		public ColorD 首CD;

		public ColorD グリップ_グリップ0CD;

		public ColorD グリップ_グリップ1CD;

		public ColorD グリップ_グリップ2CD;

		public ColorD グリップ_グリップ3CD;

		public ColorD グリップ_グリップ4CD;

		public ColorD グリップ_グリップ5CD;

		public ColorD グリップ_グリップ6CD;

		public ColorD グリップ_グリップ7CD;

		public ColorD グリップ_グリップ8CD;

		public ColorD グリップ_グリップ9CD;

		public ColorD グリップ_グリップ10CD;

		public ColorD グリップ_グリップ11CD;

		public ColorD グリップ_グリップ12CD;

		public ColorD グリップ_グリップ13CD;

		public ColorD グリップ_グリップ14CD;

		public ColorD グリップ_グリップ15CD;

		public ColorP X0Y0_ヘッドCP;

		public ColorP X0Y0_刃_刃1CP;

		public ColorP X0Y0_刃_刃2CP;

		public ColorP X0Y0_首CP;

		public ColorP X0Y0_グリップ_グリップ0CP;

		public ColorP X0Y0_グリップ_グリップ1CP;

		public ColorP X0Y0_グリップ_グリップ2CP;

		public ColorP X0Y0_グリップ_グリップ3CP;

		public ColorP X0Y0_グリップ_グリップ4CP;

		public ColorP X0Y0_グリップ_グリップ5CP;

		public ColorP X0Y0_グリップ_グリップ6CP;

		public ColorP X0Y0_グリップ_グリップ7CP;

		public ColorP X0Y0_グリップ_グリップ8CP;

		public ColorP X0Y0_グリップ_グリップ9CP;

		public ColorP X0Y0_グリップ_グリップ10CP;

		public ColorP X0Y0_グリップ_グリップ11CP;

		public ColorP X0Y0_グリップ_グリップ12CP;

		public ColorP X0Y0_グリップ_グリップ13CP;

		public ColorP X0Y0_グリップ_グリップ14CP;

		public ColorP X0Y0_グリップ_グリップ15CP;
	}
}
