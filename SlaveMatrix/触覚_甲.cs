using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 触覚_甲 : 触覚
	{
		public 触覚_甲(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 触覚_甲D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "甲";
			dif.Add(new Pars(Sta.肢左["触覚"][0][2]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_節0 = pars["節0"].ToPar();
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
			this.節0_表示 = e.節0_表示;
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
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_節0CP = new ColorP(this.X0Y0_節0, this.節0CD, DisUnit, true);
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

		public bool 節0_表示
		{
			get
			{
				return this.X0Y0_節0.Dra;
			}
			set
			{
				this.X0Y0_節0.Dra = value;
				this.X0Y0_節0.Hit = value;
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

		public override bool 表示
		{
			get
			{
				return this.節0_表示;
			}
			set
			{
				this.節0_表示 = value;
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
			}
		}

		public override double 濃度
		{
			get
			{
				return this.節0CD.不透明度;
			}
			set
			{
				this.節0CD.不透明度 = value;
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
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			int num2 = -5;
			double num3 = 1.0;
			double num4 = 0.01;
			this.X0Y0_節0.AngleBase = num * -55.0;
			this.X0Y0_節1.AngleBase = num * 25.0;
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
			this.本体.JoinPAall();
		}

		public override IEnumerable<Par> Enum軸()
		{
			yield return this.X0Y0_節0;
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
			yield break;
		}

		public override void 色更新()
		{
			this.X0Y0_節0CP.Update();
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
			this.節0CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節5CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節6CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節7CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節8CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節9CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節10CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.配色T(0, "節", ref 体配色.甲0O, ref 体配色.刺青O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.配色T(1, "節", ref 体配色.甲0O, ref 体配色.刺青O);
		}

		public Par X0Y0_節0;

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

		public ColorD 節0CD;

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

		public ColorP X0Y0_節0CP;

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
	}
}
