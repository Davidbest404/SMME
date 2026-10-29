using System;
using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 尾_蜘 : 尾
	{
		public 尾_蜘(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 尾_蜘D e)
		{
			尾_蜘.<>c__DisplayClass51_0 CS$<>8__locals1 = new 尾_蜘.<>c__DisplayClass51_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "蜘尾";
			dif.Add(new Pars(Sta.尻尾["尾"][0][11]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_尾0 = pars["尾0"].ToPar();
			this.X0Y0_柄0 = pars["柄0"].ToPar();
			this.X0Y0_柄左1 = pars["柄左1"].ToPar();
			this.X0Y0_柄左2 = pars["柄左2"].ToPar();
			this.X0Y0_柄右1 = pars["柄右1"].ToPar();
			this.X0Y0_柄右2 = pars["柄右2"].ToPar();
			Pars pars2 = pars["出糸突起後"].ToPars();
			this.X0Y0_出糸突起後_出糸突起基 = pars2["出糸突起基"].ToPar();
			this.X0Y0_出糸突起後_出糸突起中 = pars2["出糸突起中"].ToPar();
			this.X0Y0_出糸突起後_出糸突起左 = pars2["出糸突起左"].ToPar();
			this.X0Y0_出糸突起後_出糸突起右 = pars2["出糸突起右"].ToPar();
			pars2 = pars["出糸突起左"].ToPars();
			this.X0Y0_出糸突起左_出糸突起1 = pars2["出糸突起1"].ToPar();
			this.X0Y0_出糸突起左_出糸突起2 = pars2["出糸突起2"].ToPar();
			pars2 = pars["出糸突起右"].ToPars();
			this.X0Y0_出糸突起右_出糸突起1 = pars2["出糸突起1"].ToPar();
			this.X0Y0_出糸突起右_出糸突起2 = pars2["出糸突起2"].ToPar();
			pars2 = pars["出糸突起前"].ToPars();
			this.X0Y0_出糸突起前_出糸突起左 = pars2["出糸突起左"].ToPar();
			this.X0Y0_出糸突起前_出糸突起右 = pars2["出糸突起右"].ToPar();
			this.X0Y0_付根線 = pars["付根線"].ToPar();
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
			this.尾0_表示 = e.尾0_表示;
			this.柄0_表示 = e.柄0_表示;
			this.柄左1_表示 = e.柄左1_表示;
			this.柄左2_表示 = e.柄左2_表示;
			this.柄右1_表示 = e.柄右1_表示;
			this.柄右2_表示 = e.柄右2_表示;
			this.出糸突起後_出糸突起基_表示 = e.出糸突起後_出糸突起基_表示;
			this.出糸突起後_出糸突起中_表示 = e.出糸突起後_出糸突起中_表示;
			this.出糸突起後_出糸突起左_表示 = e.出糸突起後_出糸突起左_表示;
			this.出糸突起後_出糸突起右_表示 = e.出糸突起後_出糸突起右_表示;
			this.出糸突起左_出糸突起1_表示 = e.出糸突起左_出糸突起1_表示;
			this.出糸突起左_出糸突起2_表示 = e.出糸突起左_出糸突起2_表示;
			this.出糸突起右_出糸突起1_表示 = e.出糸突起右_出糸突起1_表示;
			this.出糸突起右_出糸突起2_表示 = e.出糸突起右_出糸突起2_表示;
			this.出糸突起前_出糸突起左_表示 = e.出糸突起前_出糸突起左_表示;
			this.出糸突起前_出糸突起右_表示 = e.出糸突起前_出糸突起右_表示;
			this.付根線_表示 = e.付根線_表示;
			this.出糸 = e.出糸;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.出糸_接続.Count > 0)
			{
				Ele f;
				this.出糸_接続 = e.出糸_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_蜘_出糸_接続;
					f.接続(CS$<>8__locals1.<>4__this.出糸_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_尾0CP = new ColorP(this.X0Y0_尾0, this.尾0CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_柄0CP = new ColorP(this.X0Y0_柄0, this.柄0CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_柄左1CP = new ColorP(this.X0Y0_柄左1, this.柄左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_柄左2CP = new ColorP(this.X0Y0_柄左2, this.柄左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_柄右1CP = new ColorP(this.X0Y0_柄右1, this.柄右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_柄右2CP = new ColorP(this.X0Y0_柄右2, this.柄右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_出糸突起後_出糸突起基CP = new ColorP(this.X0Y0_出糸突起後_出糸突起基, this.出糸突起後_出糸突起基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_出糸突起後_出糸突起中CP = new ColorP(this.X0Y0_出糸突起後_出糸突起中, this.出糸突起後_出糸突起中CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_出糸突起後_出糸突起左CP = new ColorP(this.X0Y0_出糸突起後_出糸突起左, this.出糸突起後_出糸突起左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_出糸突起後_出糸突起右CP = new ColorP(this.X0Y0_出糸突起後_出糸突起右, this.出糸突起後_出糸突起右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_出糸突起左_出糸突起1CP = new ColorP(this.X0Y0_出糸突起左_出糸突起1, this.出糸突起左_出糸突起1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_出糸突起左_出糸突起2CP = new ColorP(this.X0Y0_出糸突起左_出糸突起2, this.出糸突起左_出糸突起2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_出糸突起右_出糸突起1CP = new ColorP(this.X0Y0_出糸突起右_出糸突起1, this.出糸突起右_出糸突起1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_出糸突起右_出糸突起2CP = new ColorP(this.X0Y0_出糸突起右_出糸突起2, this.出糸突起右_出糸突起2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_出糸突起前_出糸突起左CP = new ColorP(this.X0Y0_出糸突起前_出糸突起左, this.出糸突起前_出糸突起左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_出糸突起前_出糸突起右CP = new ColorP(this.X0Y0_出糸突起前_出糸突起右, this.出糸突起前_出糸突起右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_付根線CP = new ColorP(this.X0Y0_付根線, this.付根線CD, CS$<>8__locals1.DisUnit, true);
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

		public bool 尾0_表示
		{
			get
			{
				return this.X0Y0_尾0.Dra;
			}
			set
			{
				this.X0Y0_尾0.Dra = value;
				this.X0Y0_尾0.Hit = value;
			}
		}

		public bool 柄0_表示
		{
			get
			{
				return this.X0Y0_柄0.Dra;
			}
			set
			{
				this.X0Y0_柄0.Dra = value;
				this.X0Y0_柄0.Hit = value;
			}
		}

		public bool 柄左1_表示
		{
			get
			{
				return this.X0Y0_柄左1.Dra;
			}
			set
			{
				this.X0Y0_柄左1.Dra = value;
				this.X0Y0_柄左1.Hit = value;
			}
		}

		public bool 柄左2_表示
		{
			get
			{
				return this.X0Y0_柄左2.Dra;
			}
			set
			{
				this.X0Y0_柄左2.Dra = value;
				this.X0Y0_柄左2.Hit = value;
			}
		}

		public bool 柄右1_表示
		{
			get
			{
				return this.X0Y0_柄右1.Dra;
			}
			set
			{
				this.X0Y0_柄右1.Dra = value;
				this.X0Y0_柄右1.Hit = value;
			}
		}

		public bool 柄右2_表示
		{
			get
			{
				return this.X0Y0_柄右2.Dra;
			}
			set
			{
				this.X0Y0_柄右2.Dra = value;
				this.X0Y0_柄右2.Hit = value;
			}
		}

		public bool 出糸突起後_出糸突起基_表示
		{
			get
			{
				return this.X0Y0_出糸突起後_出糸突起基.Dra;
			}
			set
			{
				this.X0Y0_出糸突起後_出糸突起基.Dra = value;
				this.X0Y0_出糸突起後_出糸突起基.Hit = value;
			}
		}

		public bool 出糸突起後_出糸突起中_表示
		{
			get
			{
				return this.X0Y0_出糸突起後_出糸突起中.Dra;
			}
			set
			{
				this.X0Y0_出糸突起後_出糸突起中.Dra = value;
				this.X0Y0_出糸突起後_出糸突起中.Hit = value;
			}
		}

		public bool 出糸突起後_出糸突起左_表示
		{
			get
			{
				return this.X0Y0_出糸突起後_出糸突起左.Dra;
			}
			set
			{
				this.X0Y0_出糸突起後_出糸突起左.Dra = value;
				this.X0Y0_出糸突起後_出糸突起左.Hit = value;
			}
		}

		public bool 出糸突起後_出糸突起右_表示
		{
			get
			{
				return this.X0Y0_出糸突起後_出糸突起右.Dra;
			}
			set
			{
				this.X0Y0_出糸突起後_出糸突起右.Dra = value;
				this.X0Y0_出糸突起後_出糸突起右.Hit = value;
			}
		}

		public bool 出糸突起左_出糸突起1_表示
		{
			get
			{
				return this.X0Y0_出糸突起左_出糸突起1.Dra;
			}
			set
			{
				this.X0Y0_出糸突起左_出糸突起1.Dra = value;
				this.X0Y0_出糸突起左_出糸突起1.Hit = value;
			}
		}

		public bool 出糸突起左_出糸突起2_表示
		{
			get
			{
				return this.X0Y0_出糸突起左_出糸突起2.Dra;
			}
			set
			{
				this.X0Y0_出糸突起左_出糸突起2.Dra = value;
				this.X0Y0_出糸突起左_出糸突起2.Hit = value;
			}
		}

		public bool 出糸突起右_出糸突起1_表示
		{
			get
			{
				return this.X0Y0_出糸突起右_出糸突起1.Dra;
			}
			set
			{
				this.X0Y0_出糸突起右_出糸突起1.Dra = value;
				this.X0Y0_出糸突起右_出糸突起1.Hit = value;
			}
		}

		public bool 出糸突起右_出糸突起2_表示
		{
			get
			{
				return this.X0Y0_出糸突起右_出糸突起2.Dra;
			}
			set
			{
				this.X0Y0_出糸突起右_出糸突起2.Dra = value;
				this.X0Y0_出糸突起右_出糸突起2.Hit = value;
			}
		}

		public bool 出糸突起前_出糸突起左_表示
		{
			get
			{
				return this.X0Y0_出糸突起前_出糸突起左.Dra;
			}
			set
			{
				this.X0Y0_出糸突起前_出糸突起左.Dra = value;
				this.X0Y0_出糸突起前_出糸突起左.Hit = value;
			}
		}

		public bool 出糸突起前_出糸突起右_表示
		{
			get
			{
				return this.X0Y0_出糸突起前_出糸突起右.Dra;
			}
			set
			{
				this.X0Y0_出糸突起前_出糸突起右.Dra = value;
				this.X0Y0_出糸突起前_出糸突起右.Hit = value;
			}
		}

		public bool 付根線_表示
		{
			get
			{
				return this.X0Y0_付根線.Dra;
			}
			set
			{
				this.X0Y0_付根線.Dra = value;
				this.X0Y0_付根線.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.尾0_表示;
			}
			set
			{
				this.尾0_表示 = value;
				this.柄0_表示 = value;
				this.柄左1_表示 = value;
				this.柄左2_表示 = value;
				this.柄右1_表示 = value;
				this.柄右2_表示 = value;
				this.出糸突起後_出糸突起基_表示 = value;
				this.出糸突起後_出糸突起中_表示 = value;
				this.出糸突起後_出糸突起左_表示 = value;
				this.出糸突起後_出糸突起右_表示 = value;
				this.出糸突起左_出糸突起1_表示 = value;
				this.出糸突起左_出糸突起2_表示 = value;
				this.出糸突起右_出糸突起1_表示 = value;
				this.出糸突起右_出糸突起2_表示 = value;
				this.出糸突起前_出糸突起左_表示 = value;
				this.出糸突起前_出糸突起右_表示 = value;
				this.付根線_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.尾0CD.不透明度;
			}
			set
			{
				this.尾0CD.不透明度 = value;
				this.柄0CD.不透明度 = value;
				this.柄左1CD.不透明度 = value;
				this.柄左2CD.不透明度 = value;
				this.柄右1CD.不透明度 = value;
				this.柄右2CD.不透明度 = value;
				this.出糸突起後_出糸突起基CD.不透明度 = value;
				this.出糸突起後_出糸突起中CD.不透明度 = value;
				this.出糸突起後_出糸突起左CD.不透明度 = value;
				this.出糸突起後_出糸突起右CD.不透明度 = value;
				this.出糸突起左_出糸突起1CD.不透明度 = value;
				this.出糸突起左_出糸突起2CD.不透明度 = value;
				this.出糸突起右_出糸突起1CD.不透明度 = value;
				this.出糸突起右_出糸突起2CD.不透明度 = value;
				this.出糸突起前_出糸突起左CD.不透明度 = value;
				this.出糸突起前_出糸突起右CD.不透明度 = value;
				this.付根線CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			bool 右 = this.右;
			this.本体.JoinPAall();
		}

		public bool 出糸
		{
			get
			{
				return this.出糸_;
			}
			set
			{
				this.出糸_ = value;
				this.出糸突起後_出糸突起左_表示 = !this.出糸_;
				this.出糸突起後_出糸突起右_表示 = !this.出糸_;
				this.出糸突起左_出糸突起1_表示 = this.出糸_;
				this.出糸突起左_出糸突起2_表示 = this.出糸_;
				this.出糸突起右_出糸突起1_表示 = this.出糸_;
				this.出糸突起右_出糸突起2_表示 = this.出糸_;
			}
		}

		public override IEnumerable<Par> Enum軸()
		{
			yield return this.X0Y0_尾0;
			yield break;
		}

		public JointS 出糸_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾0, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_尾0CP.Update();
			this.X0Y0_柄0CP.Par.GetMiY_MaY(out this.mm);
			this.X0Y0_柄0CP.Update(this.mm);
			this.X0Y0_柄左1CP.Update(this.mm);
			this.X0Y0_柄左2CP.Update(this.mm);
			this.X0Y0_柄右1CP.Update(this.mm);
			this.X0Y0_柄右2CP.Update(this.mm);
			this.X0Y0_出糸突起後_出糸突起基CP.Update();
			this.X0Y0_出糸突起後_出糸突起中CP.Update();
			this.X0Y0_出糸突起後_出糸突起左CP.Update();
			this.X0Y0_出糸突起後_出糸突起右CP.Update();
			this.X0Y0_出糸突起左_出糸突起1CP.Update();
			this.X0Y0_出糸突起左_出糸突起2CP.Update();
			this.X0Y0_出糸突起右_出糸突起1CP.Update();
			this.X0Y0_出糸突起右_出糸突起2CP.Update();
			this.X0Y0_出糸突起前_出糸突起左CP.Update();
			this.X0Y0_出糸突起前_出糸突起右CP.Update();
			this.X0Y0_付根線CP.Update();
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
			this.尾0CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.柄0CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.柄左1CD = new ColorD(ref Col.Black, ref 体配色.柄O);
			this.柄左2CD = new ColorD(ref Col.Black, ref 体配色.柄O);
			this.柄右1CD = new ColorD(ref Col.Black, ref 体配色.柄O);
			this.柄右2CD = new ColorD(ref Col.Black, ref 体配色.柄O);
			this.出糸突起後_出糸突起基CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.出糸突起後_出糸突起中CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.出糸突起後_出糸突起左CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.出糸突起後_出糸突起右CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.出糸突起左_出糸突起1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.出糸突起左_出糸突起2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.出糸突起右_出糸突起1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.出糸突起右_出糸突起2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.出糸突起前_出糸突起左CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.出糸突起前_出糸突起右CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.付根線CD = new ColorD(ref Col.Black, ref Color2.Empty);
		}

		private void 配色T0(体配色 体配色)
		{
			this.尾0CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.柄0CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.柄左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.柄左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.柄右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.柄右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.出糸突起後_出糸突起基CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.出糸突起後_出糸突起中CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.出糸突起後_出糸突起左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.出糸突起後_出糸突起右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.出糸突起左_出糸突起1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.出糸突起左_出糸突起2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.出糸突起右_出糸突起1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.出糸突起右_出糸突起2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.出糸突起前_出糸突起左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.出糸突起前_出糸突起右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.付根線CD = new ColorD(ref Col.Black, ref Color2.Empty);
		}

		private void 配色T1(体配色 体配色)
		{
			this.尾0CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.柄0CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.柄左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.柄左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.柄右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.柄右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.出糸突起後_出糸突起基CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.出糸突起後_出糸突起中CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.出糸突起後_出糸突起左CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.出糸突起後_出糸突起右CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.出糸突起左_出糸突起1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.出糸突起左_出糸突起2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.出糸突起右_出糸突起1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.出糸突起右_出糸突起2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.出糸突起前_出糸突起左CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.出糸突起前_出糸突起右CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.付根線CD = new ColorD(ref Col.Black, ref Color2.Empty);
		}

		public Par X0Y0_尾0;

		public Par X0Y0_柄0;

		public Par X0Y0_柄左1;

		public Par X0Y0_柄左2;

		public Par X0Y0_柄右1;

		public Par X0Y0_柄右2;

		public Par X0Y0_出糸突起後_出糸突起基;

		public Par X0Y0_出糸突起後_出糸突起中;

		public Par X0Y0_出糸突起後_出糸突起左;

		public Par X0Y0_出糸突起後_出糸突起右;

		public Par X0Y0_出糸突起左_出糸突起1;

		public Par X0Y0_出糸突起左_出糸突起2;

		public Par X0Y0_出糸突起右_出糸突起1;

		public Par X0Y0_出糸突起右_出糸突起2;

		public Par X0Y0_出糸突起前_出糸突起左;

		public Par X0Y0_出糸突起前_出糸突起右;

		public Par X0Y0_付根線;

		public ColorD 尾0CD;

		public ColorD 柄0CD;

		public ColorD 柄左1CD;

		public ColorD 柄左2CD;

		public ColorD 柄右1CD;

		public ColorD 柄右2CD;

		public ColorD 出糸突起後_出糸突起基CD;

		public ColorD 出糸突起後_出糸突起中CD;

		public ColorD 出糸突起後_出糸突起左CD;

		public ColorD 出糸突起後_出糸突起右CD;

		public ColorD 出糸突起左_出糸突起1CD;

		public ColorD 出糸突起左_出糸突起2CD;

		public ColorD 出糸突起右_出糸突起1CD;

		public ColorD 出糸突起右_出糸突起2CD;

		public ColorD 出糸突起前_出糸突起左CD;

		public ColorD 出糸突起前_出糸突起右CD;

		public ColorD 付根線CD;

		public ColorP X0Y0_尾0CP;

		public ColorP X0Y0_柄0CP;

		public ColorP X0Y0_柄左1CP;

		public ColorP X0Y0_柄左2CP;

		public ColorP X0Y0_柄右1CP;

		public ColorP X0Y0_柄右2CP;

		public ColorP X0Y0_出糸突起後_出糸突起基CP;

		public ColorP X0Y0_出糸突起後_出糸突起中CP;

		public ColorP X0Y0_出糸突起後_出糸突起左CP;

		public ColorP X0Y0_出糸突起後_出糸突起右CP;

		public ColorP X0Y0_出糸突起左_出糸突起1CP;

		public ColorP X0Y0_出糸突起左_出糸突起2CP;

		public ColorP X0Y0_出糸突起右_出糸突起1CP;

		public ColorP X0Y0_出糸突起右_出糸突起2CP;

		public ColorP X0Y0_出糸突起前_出糸突起左CP;

		public ColorP X0Y0_出糸突起前_出糸突起右CP;

		public ColorP X0Y0_付根線CP;

		private bool 出糸_;

		public Ele[] 出糸_接続;

		private Vector2D[] mm;
	}
}
