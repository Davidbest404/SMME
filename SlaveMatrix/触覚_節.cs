using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 触覚_節 : 触覚
	{
		public 触覚_節(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 触覚_節D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "節";
			dif.Add(new Pars(Sta.肢左["触覚"][0][1]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_節1 = pars["節1"].ToPar();
			this.X0Y0_節2 = pars["節2"].ToPar();
			this.X0Y0_節3 = pars["節3"].ToPar();
			this.X0Y0_節4 = pars["節4"].ToPar();
			this.X0Y0_節5 = pars["節5"].ToPar();
			this.X0Y0_節6 = pars["節6"].ToPar();
			this.X0Y0_節7 = pars["節7"].ToPar();
			this.X0Y0_節8 = pars["節8"].ToPar();
			this.X0Y0_節9 = pars["節9"].ToPar();
			this.X0Y0_節10 = pars["節10"].ToPar();
			this.X0Y0_節11 = pars["節11"].ToPar();
			this.X0Y0_節12 = pars["節12"].ToPar();
			this.X0Y0_節13 = pars["節13"].ToPar();
			this.X0Y0_節14 = pars["節14"].ToPar();
			this.X0Y0_節15 = pars["節15"].ToPar();
			this.X0Y0_節16 = pars["節16"].ToPar();
			this.X0Y0_節17 = pars["節17"].ToPar();
			this.X0Y0_節18 = pars["節18"].ToPar();
			this.X0Y0_節19 = pars["節19"].ToPar();
			this.X0Y0_節20 = pars["節20"].ToPar();
			this.X0Y0_節21 = pars["節21"].ToPar();
			this.X0Y0_節22 = pars["節22"].ToPar();
			this.X0Y0_節23 = pars["節23"].ToPar();
			this.X0Y0_節24 = pars["節24"].ToPar();
			this.X0Y0_節25 = pars["節25"].ToPar();
			this.X0Y0_節26 = pars["節26"].ToPar();
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
			this.節1_表示 = e.節1_表示;
			this.節2_表示 = e.節2_表示;
			this.節3_表示 = e.節3_表示;
			this.節4_表示 = e.節4_表示;
			this.節5_表示 = e.節5_表示;
			this.節6_表示 = e.節6_表示;
			this.節7_表示 = e.節7_表示;
			this.節8_表示 = e.節8_表示;
			this.節9_表示 = e.節9_表示;
			this.節10_表示 = e.節10_表示;
			this.節11_表示 = e.節11_表示;
			this.節12_表示 = e.節12_表示;
			this.節13_表示 = e.節13_表示;
			this.節14_表示 = e.節14_表示;
			this.節15_表示 = e.節15_表示;
			this.節16_表示 = e.節16_表示;
			this.節17_表示 = e.節17_表示;
			this.節18_表示 = e.節18_表示;
			this.節19_表示 = e.節19_表示;
			this.節20_表示 = e.節20_表示;
			this.節21_表示 = e.節21_表示;
			this.節22_表示 = e.節22_表示;
			this.節23_表示 = e.節23_表示;
			this.節24_表示 = e.節24_表示;
			this.節25_表示 = e.節25_表示;
			this.節26_表示 = e.節26_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_節1CP = new ColorP(this.X0Y0_節1, this.節1CD, DisUnit, true);
			this.X0Y0_節2CP = new ColorP(this.X0Y0_節2, this.節2CD, DisUnit, true);
			this.X0Y0_節3CP = new ColorP(this.X0Y0_節3, this.節3CD, DisUnit, true);
			this.X0Y0_節4CP = new ColorP(this.X0Y0_節4, this.節4CD, DisUnit, true);
			this.X0Y0_節5CP = new ColorP(this.X0Y0_節5, this.節5CD, DisUnit, true);
			this.X0Y0_節6CP = new ColorP(this.X0Y0_節6, this.節6CD, DisUnit, true);
			this.X0Y0_節7CP = new ColorP(this.X0Y0_節7, this.節7CD, DisUnit, true);
			this.X0Y0_節8CP = new ColorP(this.X0Y0_節8, this.節8CD, DisUnit, true);
			this.X0Y0_節9CP = new ColorP(this.X0Y0_節9, this.節9CD, DisUnit, true);
			this.X0Y0_節10CP = new ColorP(this.X0Y0_節10, this.節10CD, DisUnit, true);
			this.X0Y0_節11CP = new ColorP(this.X0Y0_節11, this.節11CD, DisUnit, true);
			this.X0Y0_節12CP = new ColorP(this.X0Y0_節12, this.節12CD, DisUnit, true);
			this.X0Y0_節13CP = new ColorP(this.X0Y0_節13, this.節13CD, DisUnit, true);
			this.X0Y0_節14CP = new ColorP(this.X0Y0_節14, this.節14CD, DisUnit, true);
			this.X0Y0_節15CP = new ColorP(this.X0Y0_節15, this.節15CD, DisUnit, true);
			this.X0Y0_節16CP = new ColorP(this.X0Y0_節16, this.節16CD, DisUnit, true);
			this.X0Y0_節17CP = new ColorP(this.X0Y0_節17, this.節17CD, DisUnit, true);
			this.X0Y0_節18CP = new ColorP(this.X0Y0_節18, this.節18CD, DisUnit, true);
			this.X0Y0_節19CP = new ColorP(this.X0Y0_節19, this.節19CD, DisUnit, true);
			this.X0Y0_節20CP = new ColorP(this.X0Y0_節20, this.節20CD, DisUnit, true);
			this.X0Y0_節21CP = new ColorP(this.X0Y0_節21, this.節21CD, DisUnit, true);
			this.X0Y0_節22CP = new ColorP(this.X0Y0_節22, this.節22CD, DisUnit, true);
			this.X0Y0_節23CP = new ColorP(this.X0Y0_節23, this.節23CD, DisUnit, true);
			this.X0Y0_節24CP = new ColorP(this.X0Y0_節24, this.節24CD, DisUnit, true);
			this.X0Y0_節25CP = new ColorP(this.X0Y0_節25, this.節25CD, DisUnit, true);
			this.X0Y0_節26CP = new ColorP(this.X0Y0_節26, this.節26CD, DisUnit, true);
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

		public bool 節1_表示
		{
			get
			{
				return this.X0Y0_節1.Dra;
			}
			set
			{
				this.X0Y0_節1.Dra = value;
				this.X0Y0_節1.Hit = value;
			}
		}

		public bool 節2_表示
		{
			get
			{
				return this.X0Y0_節2.Dra;
			}
			set
			{
				this.X0Y0_節2.Dra = value;
				this.X0Y0_節2.Hit = value;
			}
		}

		public bool 節3_表示
		{
			get
			{
				return this.X0Y0_節3.Dra;
			}
			set
			{
				this.X0Y0_節3.Dra = value;
				this.X0Y0_節3.Hit = value;
			}
		}

		public bool 節4_表示
		{
			get
			{
				return this.X0Y0_節4.Dra;
			}
			set
			{
				this.X0Y0_節4.Dra = value;
				this.X0Y0_節4.Hit = value;
			}
		}

		public bool 節5_表示
		{
			get
			{
				return this.X0Y0_節5.Dra;
			}
			set
			{
				this.X0Y0_節5.Dra = value;
				this.X0Y0_節5.Hit = value;
			}
		}

		public bool 節6_表示
		{
			get
			{
				return this.X0Y0_節6.Dra;
			}
			set
			{
				this.X0Y0_節6.Dra = value;
				this.X0Y0_節6.Hit = value;
			}
		}

		public bool 節7_表示
		{
			get
			{
				return this.X0Y0_節7.Dra;
			}
			set
			{
				this.X0Y0_節7.Dra = value;
				this.X0Y0_節7.Hit = value;
			}
		}

		public bool 節8_表示
		{
			get
			{
				return this.X0Y0_節8.Dra;
			}
			set
			{
				this.X0Y0_節8.Dra = value;
				this.X0Y0_節8.Hit = value;
			}
		}

		public bool 節9_表示
		{
			get
			{
				return this.X0Y0_節9.Dra;
			}
			set
			{
				this.X0Y0_節9.Dra = value;
				this.X0Y0_節9.Hit = value;
			}
		}

		public bool 節10_表示
		{
			get
			{
				return this.X0Y0_節10.Dra;
			}
			set
			{
				this.X0Y0_節10.Dra = value;
				this.X0Y0_節10.Hit = value;
			}
		}

		public bool 節11_表示
		{
			get
			{
				return this.X0Y0_節11.Dra;
			}
			set
			{
				this.X0Y0_節11.Dra = value;
				this.X0Y0_節11.Hit = value;
			}
		}

		public bool 節12_表示
		{
			get
			{
				return this.X0Y0_節12.Dra;
			}
			set
			{
				this.X0Y0_節12.Dra = value;
				this.X0Y0_節12.Hit = value;
			}
		}

		public bool 節13_表示
		{
			get
			{
				return this.X0Y0_節13.Dra;
			}
			set
			{
				this.X0Y0_節13.Dra = value;
				this.X0Y0_節13.Hit = value;
			}
		}

		public bool 節14_表示
		{
			get
			{
				return this.X0Y0_節14.Dra;
			}
			set
			{
				this.X0Y0_節14.Dra = value;
				this.X0Y0_節14.Hit = value;
			}
		}

		public bool 節15_表示
		{
			get
			{
				return this.X0Y0_節15.Dra;
			}
			set
			{
				this.X0Y0_節15.Dra = value;
				this.X0Y0_節15.Hit = value;
			}
		}

		public bool 節16_表示
		{
			get
			{
				return this.X0Y0_節16.Dra;
			}
			set
			{
				this.X0Y0_節16.Dra = value;
				this.X0Y0_節16.Hit = value;
			}
		}

		public bool 節17_表示
		{
			get
			{
				return this.X0Y0_節17.Dra;
			}
			set
			{
				this.X0Y0_節17.Dra = value;
				this.X0Y0_節17.Hit = value;
			}
		}

		public bool 節18_表示
		{
			get
			{
				return this.X0Y0_節18.Dra;
			}
			set
			{
				this.X0Y0_節18.Dra = value;
				this.X0Y0_節18.Hit = value;
			}
		}

		public bool 節19_表示
		{
			get
			{
				return this.X0Y0_節19.Dra;
			}
			set
			{
				this.X0Y0_節19.Dra = value;
				this.X0Y0_節19.Hit = value;
			}
		}

		public bool 節20_表示
		{
			get
			{
				return this.X0Y0_節20.Dra;
			}
			set
			{
				this.X0Y0_節20.Dra = value;
				this.X0Y0_節20.Hit = value;
			}
		}

		public bool 節21_表示
		{
			get
			{
				return this.X0Y0_節21.Dra;
			}
			set
			{
				this.X0Y0_節21.Dra = value;
				this.X0Y0_節21.Hit = value;
			}
		}

		public bool 節22_表示
		{
			get
			{
				return this.X0Y0_節22.Dra;
			}
			set
			{
				this.X0Y0_節22.Dra = value;
				this.X0Y0_節22.Hit = value;
			}
		}

		public bool 節23_表示
		{
			get
			{
				return this.X0Y0_節23.Dra;
			}
			set
			{
				this.X0Y0_節23.Dra = value;
				this.X0Y0_節23.Hit = value;
			}
		}

		public bool 節24_表示
		{
			get
			{
				return this.X0Y0_節24.Dra;
			}
			set
			{
				this.X0Y0_節24.Dra = value;
				this.X0Y0_節24.Hit = value;
			}
		}

		public bool 節25_表示
		{
			get
			{
				return this.X0Y0_節25.Dra;
			}
			set
			{
				this.X0Y0_節25.Dra = value;
				this.X0Y0_節25.Hit = value;
			}
		}

		public bool 節26_表示
		{
			get
			{
				return this.X0Y0_節26.Dra;
			}
			set
			{
				this.X0Y0_節26.Dra = value;
				this.X0Y0_節26.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.節1_表示;
			}
			set
			{
				this.節1_表示 = value;
				this.節2_表示 = value;
				this.節3_表示 = value;
				this.節4_表示 = value;
				this.節5_表示 = value;
				this.節6_表示 = value;
				this.節7_表示 = value;
				this.節8_表示 = value;
				this.節9_表示 = value;
				this.節10_表示 = value;
				this.節11_表示 = value;
				this.節12_表示 = value;
				this.節13_表示 = value;
				this.節14_表示 = value;
				this.節15_表示 = value;
				this.節16_表示 = value;
				this.節17_表示 = value;
				this.節18_表示 = value;
				this.節19_表示 = value;
				this.節20_表示 = value;
				this.節21_表示 = value;
				this.節22_表示 = value;
				this.節23_表示 = value;
				this.節24_表示 = value;
				this.節25_表示 = value;
				this.節26_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.節1CD.不透明度;
			}
			set
			{
				this.節1CD.不透明度 = value;
				this.節2CD.不透明度 = value;
				this.節3CD.不透明度 = value;
				this.節4CD.不透明度 = value;
				this.節5CD.不透明度 = value;
				this.節6CD.不透明度 = value;
				this.節7CD.不透明度 = value;
				this.節8CD.不透明度 = value;
				this.節9CD.不透明度 = value;
				this.節10CD.不透明度 = value;
				this.節11CD.不透明度 = value;
				this.節12CD.不透明度 = value;
				this.節13CD.不透明度 = value;
				this.節14CD.不透明度 = value;
				this.節15CD.不透明度 = value;
				this.節16CD.不透明度 = value;
				this.節17CD.不透明度 = value;
				this.節18CD.不透明度 = value;
				this.節19CD.不透明度 = value;
				this.節20CD.不透明度 = value;
				this.節21CD.不透明度 = value;
				this.節22CD.不透明度 = value;
				this.節23CD.不透明度 = value;
				this.節24CD.不透明度 = value;
				this.節25CD.不透明度 = value;
				this.節26CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			int num2 = -5;
			double num3 = 1.0;
			double num4 = 0.01;
			this.X0Y0_節1.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節2.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節3.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節4.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節5.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節6.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節7.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節8.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節9.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節10.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節11.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節12.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節13.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節14.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節15.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節16.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節17.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節18.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節19.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節20.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節21.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節22.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節23.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節24.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節25.AngleBase = num * (double)num2 * num3;
			num3 -= num4;
			this.X0Y0_節26.AngleBase = num * (double)num2 * num3;
			this.X0Y0_節1.AngleBase = num * -10.0;
			this.本体.JoinPAall();
		}

		public override IEnumerable<Par> Enum軸()
		{
			yield return this.X0Y0_節1;
			yield return this.X0Y0_節2;
			yield return this.X0Y0_節3;
			yield return this.X0Y0_節4;
			yield return this.X0Y0_節5;
			yield return this.X0Y0_節6;
			yield return this.X0Y0_節7;
			yield return this.X0Y0_節8;
			yield return this.X0Y0_節9;
			yield return this.X0Y0_節10;
			yield return this.X0Y0_節11;
			yield return this.X0Y0_節12;
			yield return this.X0Y0_節13;
			yield return this.X0Y0_節14;
			yield return this.X0Y0_節15;
			yield return this.X0Y0_節16;
			yield return this.X0Y0_節17;
			yield return this.X0Y0_節18;
			yield return this.X0Y0_節19;
			yield return this.X0Y0_節20;
			yield return this.X0Y0_節21;
			yield return this.X0Y0_節22;
			yield return this.X0Y0_節23;
			yield return this.X0Y0_節24;
			yield return this.X0Y0_節25;
			yield return this.X0Y0_節26;
			yield break;
		}

		public override void 色更新()
		{
			this.X0Y0_節1CP.Update();
			this.X0Y0_節2CP.Update();
			this.X0Y0_節3CP.Update();
			this.X0Y0_節4CP.Update();
			this.X0Y0_節5CP.Update();
			this.X0Y0_節6CP.Update();
			this.X0Y0_節7CP.Update();
			this.X0Y0_節8CP.Update();
			this.X0Y0_節9CP.Update();
			this.X0Y0_節10CP.Update();
			this.X0Y0_節11CP.Update();
			this.X0Y0_節12CP.Update();
			this.X0Y0_節13CP.Update();
			this.X0Y0_節14CP.Update();
			this.X0Y0_節15CP.Update();
			this.X0Y0_節16CP.Update();
			this.X0Y0_節17CP.Update();
			this.X0Y0_節18CP.Update();
			this.X0Y0_節19CP.Update();
			this.X0Y0_節20CP.Update();
			this.X0Y0_節21CP.Update();
			this.X0Y0_節22CP.Update();
			this.X0Y0_節23CP.Update();
			this.X0Y0_節24CP.Update();
			this.X0Y0_節25CP.Update();
			this.X0Y0_節26CP.Update();
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
			this.節1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節3CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節4CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節5CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節6CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節7CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節8CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節9CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節10CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節11CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節12CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節13CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節14CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節15CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節16CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節17CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節18CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節19CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節20CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節21CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節22CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節23CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節24CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節25CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.節26CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.配色T(0, "節", ref 体配色.甲1O, ref 体配色.刺青O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.配色T(1, "節", ref 体配色.甲1O, ref 体配色.刺青O);
		}

		public Par X0Y0_節1;

		public Par X0Y0_節2;

		public Par X0Y0_節3;

		public Par X0Y0_節4;

		public Par X0Y0_節5;

		public Par X0Y0_節6;

		public Par X0Y0_節7;

		public Par X0Y0_節8;

		public Par X0Y0_節9;

		public Par X0Y0_節10;

		public Par X0Y0_節11;

		public Par X0Y0_節12;

		public Par X0Y0_節13;

		public Par X0Y0_節14;

		public Par X0Y0_節15;

		public Par X0Y0_節16;

		public Par X0Y0_節17;

		public Par X0Y0_節18;

		public Par X0Y0_節19;

		public Par X0Y0_節20;

		public Par X0Y0_節21;

		public Par X0Y0_節22;

		public Par X0Y0_節23;

		public Par X0Y0_節24;

		public Par X0Y0_節25;

		public Par X0Y0_節26;

		public ColorD 節1CD;

		public ColorD 節2CD;

		public ColorD 節3CD;

		public ColorD 節4CD;

		public ColorD 節5CD;

		public ColorD 節6CD;

		public ColorD 節7CD;

		public ColorD 節8CD;

		public ColorD 節9CD;

		public ColorD 節10CD;

		public ColorD 節11CD;

		public ColorD 節12CD;

		public ColorD 節13CD;

		public ColorD 節14CD;

		public ColorD 節15CD;

		public ColorD 節16CD;

		public ColorD 節17CD;

		public ColorD 節18CD;

		public ColorD 節19CD;

		public ColorD 節20CD;

		public ColorD 節21CD;

		public ColorD 節22CD;

		public ColorD 節23CD;

		public ColorD 節24CD;

		public ColorD 節25CD;

		public ColorD 節26CD;

		public ColorP X0Y0_節1CP;

		public ColorP X0Y0_節2CP;

		public ColorP X0Y0_節3CP;

		public ColorP X0Y0_節4CP;

		public ColorP X0Y0_節5CP;

		public ColorP X0Y0_節6CP;

		public ColorP X0Y0_節7CP;

		public ColorP X0Y0_節8CP;

		public ColorP X0Y0_節9CP;

		public ColorP X0Y0_節10CP;

		public ColorP X0Y0_節11CP;

		public ColorP X0Y0_節12CP;

		public ColorP X0Y0_節13CP;

		public ColorP X0Y0_節14CP;

		public ColorP X0Y0_節15CP;

		public ColorP X0Y0_節16CP;

		public ColorP X0Y0_節17CP;

		public ColorP X0Y0_節18CP;

		public ColorP X0Y0_節19CP;

		public ColorP X0Y0_節20CP;

		public ColorP X0Y0_節21CP;

		public ColorP X0Y0_節22CP;

		public ColorP X0Y0_節23CP;

		public ColorP X0Y0_節24CP;

		public ColorP X0Y0_節25CP;

		public ColorP X0Y0_節26CP;
	}
}
