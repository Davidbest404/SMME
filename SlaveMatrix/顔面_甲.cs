using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 顔面_甲 : 顔面
	{
		public 顔面_甲(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 顔面_甲D e)
		{
			顔面_甲.<>c__DisplayClass60_0 CS$<>8__locals1 = new 顔面_甲.<>c__DisplayClass60_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.肢中["顔面"][0]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_面額 = pars["面額"].ToPar();
			Pars pars2 = pars["面左下"].ToPars();
			this.X0Y0_面左下_面目 = pars2["面目"].ToPar();
			this.X0Y0_面左下_面 = pars2["面"].ToPar();
			pars2 = pars["面右下"].ToPars();
			this.X0Y0_面右下_面目 = pars2["面目"].ToPar();
			this.X0Y0_面右下_面 = pars2["面"].ToPar();
			this.X0Y0_面左外 = pars["面左外"].ToPar();
			this.X0Y0_面右外 = pars["面右外"].ToPar();
			pars2 = pars["面左上"].ToPars();
			this.X0Y0_面左上_面目 = pars2["面目"].ToPar();
			this.X0Y0_面左上_面 = pars2["面"].ToPar();
			pars2 = pars["面右上"].ToPars();
			this.X0Y0_面右上_面目 = pars2["面目"].ToPar();
			this.X0Y0_面右上_面 = pars2["面"].ToPar();
			pars2 = pars["面中0"].ToPars();
			this.X0Y0_面中0_面中 = pars2["面中"].ToPar();
			Pars pars3 = pars2["付根左"].ToPars();
			this.X0Y0_面中0_付根左_付根1 = pars3["付根1"].ToPar();
			this.X0Y0_面中0_付根左_付根2 = pars3["付根2"].ToPar();
			pars3 = pars2["付根右"].ToPars();
			this.X0Y0_面中0_付根右_付根1 = pars3["付根1"].ToPar();
			this.X0Y0_面中0_付根右_付根2 = pars3["付根2"].ToPar();
			pars2 = pars["面中2"].ToPars();
			this.X0Y0_面中2_面中 = pars2["面中"].ToPar();
			this.X0Y0_面中2_面中下 = pars2["面中下"].ToPar();
			pars2 = pars["面中1"].ToPars();
			this.X0Y0_面中1_面中 = pars2["面中"].ToPar();
			this.X0Y0_面中1_面中下 = pars2["面中下"].ToPar();
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
			this.面額_表示 = e.面額_表示;
			this.面左下_面目_表示 = e.面左下_面目_表示;
			this.面左下_面_表示 = e.面左下_面_表示;
			this.面右下_面目_表示 = e.面右下_面目_表示;
			this.面右下_面_表示 = e.面右下_面_表示;
			this.面左外_表示 = e.面左外_表示;
			this.面右外_表示 = e.面右外_表示;
			this.面左上_面目_表示 = e.面左上_面目_表示;
			this.面左上_面_表示 = e.面左上_面_表示;
			this.面右上_面目_表示 = e.面右上_面目_表示;
			this.面右上_面_表示 = e.面右上_面_表示;
			this.面中0_面中_表示 = e.面中0_面中_表示;
			this.面中0_付根左_付根1_表示 = e.面中0_付根左_付根1_表示;
			this.面中0_付根左_付根2_表示 = e.面中0_付根左_付根2_表示;
			this.面中0_付根右_付根1_表示 = e.面中0_付根右_付根1_表示;
			this.面中0_付根右_付根2_表示 = e.面中0_付根右_付根2_表示;
			this.面中2_面中_表示 = e.面中2_面中_表示;
			this.面中2_面中下_表示 = e.面中2_面中下_表示;
			this.面中1_面中_表示 = e.面中1_面中_表示;
			this.面中1_面中下_表示 = e.面中1_面中下_表示;
			base.展開0 = e.展開0;
			this.展開1 = e.展開1;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.触覚左_接続.Count > 0)
			{
				Ele f;
				this.触覚左_接続 = e.触覚左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.顔面_甲_触覚左_接続;
					f.接続(CS$<>8__locals1.<>4__this.触覚左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.触覚右_接続.Count > 0)
			{
				Ele f;
				this.触覚右_接続 = e.触覚右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.顔面_甲_触覚右_接続;
					f.接続(CS$<>8__locals1.<>4__this.触覚右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_面額CP = new ColorP(this.X0Y0_面額, this.面額CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面左下_面目CP = new ColorP(this.X0Y0_面左下_面目, this.面左下_面目CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面左下_面CP = new ColorP(this.X0Y0_面左下_面, this.面左下_面CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面右下_面目CP = new ColorP(this.X0Y0_面右下_面目, this.面右下_面目CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面右下_面CP = new ColorP(this.X0Y0_面右下_面, this.面右下_面CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面左外CP = new ColorP(this.X0Y0_面左外, this.面左外CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面右外CP = new ColorP(this.X0Y0_面右外, this.面右外CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面左上_面目CP = new ColorP(this.X0Y0_面左上_面目, this.面左上_面目CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面左上_面CP = new ColorP(this.X0Y0_面左上_面, this.面左上_面CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面右上_面目CP = new ColorP(this.X0Y0_面右上_面目, this.面右上_面目CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面右上_面CP = new ColorP(this.X0Y0_面右上_面, this.面右上_面CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面中0_面中CP = new ColorP(this.X0Y0_面中0_面中, this.面中0_面中CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面中0_付根左_付根1CP = new ColorP(this.X0Y0_面中0_付根左_付根1, this.面中0_付根左_付根1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面中0_付根左_付根2CP = new ColorP(this.X0Y0_面中0_付根左_付根2, this.面中0_付根左_付根2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面中0_付根右_付根1CP = new ColorP(this.X0Y0_面中0_付根右_付根1, this.面中0_付根右_付根1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面中0_付根右_付根2CP = new ColorP(this.X0Y0_面中0_付根右_付根2, this.面中0_付根右_付根2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面中2_面中CP = new ColorP(this.X0Y0_面中2_面中, this.面中2_面中CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面中2_面中下CP = new ColorP(this.X0Y0_面中2_面中下, this.面中2_面中下CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面中1_面中CP = new ColorP(this.X0Y0_面中1_面中, this.面中1_面中CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面中1_面中下CP = new ColorP(this.X0Y0_面中1_面中下, this.面中1_面中下CD, CS$<>8__locals1.DisUnit, true);
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

		public bool 面額_表示
		{
			get
			{
				return this.X0Y0_面額.Dra;
			}
			set
			{
				this.X0Y0_面額.Dra = value;
				this.X0Y0_面額.Hit = value;
			}
		}

		public bool 面左下_面目_表示
		{
			get
			{
				return this.X0Y0_面左下_面目.Dra;
			}
			set
			{
				this.X0Y0_面左下_面目.Dra = value;
				this.X0Y0_面左下_面目.Hit = value;
			}
		}

		public bool 面左下_面_表示
		{
			get
			{
				return this.X0Y0_面左下_面.Dra;
			}
			set
			{
				this.X0Y0_面左下_面.Dra = value;
				this.X0Y0_面左下_面.Hit = value;
			}
		}

		public bool 面右下_面目_表示
		{
			get
			{
				return this.X0Y0_面右下_面目.Dra;
			}
			set
			{
				this.X0Y0_面右下_面目.Dra = value;
				this.X0Y0_面右下_面目.Hit = value;
			}
		}

		public bool 面右下_面_表示
		{
			get
			{
				return this.X0Y0_面右下_面.Dra;
			}
			set
			{
				this.X0Y0_面右下_面.Dra = value;
				this.X0Y0_面右下_面.Hit = value;
			}
		}

		public bool 面左外_表示
		{
			get
			{
				return this.X0Y0_面左外.Dra;
			}
			set
			{
				this.X0Y0_面左外.Dra = value;
				this.X0Y0_面左外.Hit = value;
			}
		}

		public bool 面右外_表示
		{
			get
			{
				return this.X0Y0_面右外.Dra;
			}
			set
			{
				this.X0Y0_面右外.Dra = value;
				this.X0Y0_面右外.Hit = value;
			}
		}

		public bool 面左上_面目_表示
		{
			get
			{
				return this.X0Y0_面左上_面目.Dra;
			}
			set
			{
				this.X0Y0_面左上_面目.Dra = value;
				this.X0Y0_面左上_面目.Hit = value;
			}
		}

		public bool 面左上_面_表示
		{
			get
			{
				return this.X0Y0_面左上_面.Dra;
			}
			set
			{
				this.X0Y0_面左上_面.Dra = value;
				this.X0Y0_面左上_面.Hit = value;
			}
		}

		public bool 面右上_面目_表示
		{
			get
			{
				return this.X0Y0_面右上_面目.Dra;
			}
			set
			{
				this.X0Y0_面右上_面目.Dra = value;
				this.X0Y0_面右上_面目.Hit = value;
			}
		}

		public bool 面右上_面_表示
		{
			get
			{
				return this.X0Y0_面右上_面.Dra;
			}
			set
			{
				this.X0Y0_面右上_面.Dra = value;
				this.X0Y0_面右上_面.Hit = value;
			}
		}

		public bool 面中0_面中_表示
		{
			get
			{
				return this.X0Y0_面中0_面中.Dra;
			}
			set
			{
				this.X0Y0_面中0_面中.Dra = value;
				this.X0Y0_面中0_面中.Hit = value;
			}
		}

		public bool 面中0_付根左_付根1_表示
		{
			get
			{
				return this.X0Y0_面中0_付根左_付根1.Dra;
			}
			set
			{
				this.X0Y0_面中0_付根左_付根1.Dra = value;
				this.X0Y0_面中0_付根左_付根1.Hit = value;
			}
		}

		public bool 面中0_付根左_付根2_表示
		{
			get
			{
				return this.X0Y0_面中0_付根左_付根2.Dra;
			}
			set
			{
				this.X0Y0_面中0_付根左_付根2.Dra = value;
				this.X0Y0_面中0_付根左_付根2.Hit = value;
			}
		}

		public bool 面中0_付根右_付根1_表示
		{
			get
			{
				return this.X0Y0_面中0_付根右_付根1.Dra;
			}
			set
			{
				this.X0Y0_面中0_付根右_付根1.Dra = value;
				this.X0Y0_面中0_付根右_付根1.Hit = value;
			}
		}

		public bool 面中0_付根右_付根2_表示
		{
			get
			{
				return this.X0Y0_面中0_付根右_付根2.Dra;
			}
			set
			{
				this.X0Y0_面中0_付根右_付根2.Dra = value;
				this.X0Y0_面中0_付根右_付根2.Hit = value;
			}
		}

		public bool 面中2_面中_表示
		{
			get
			{
				return this.X0Y0_面中2_面中.Dra;
			}
			set
			{
				this.X0Y0_面中2_面中.Dra = value;
				this.X0Y0_面中2_面中.Hit = value;
			}
		}

		public bool 面中2_面中下_表示
		{
			get
			{
				return this.X0Y0_面中2_面中下.Dra;
			}
			set
			{
				this.X0Y0_面中2_面中下.Dra = value;
				this.X0Y0_面中2_面中下.Hit = value;
			}
		}

		public bool 面中1_面中_表示
		{
			get
			{
				return this.X0Y0_面中1_面中.Dra;
			}
			set
			{
				this.X0Y0_面中1_面中.Dra = value;
				this.X0Y0_面中1_面中.Hit = value;
			}
		}

		public bool 面中1_面中下_表示
		{
			get
			{
				return this.X0Y0_面中1_面中下.Dra;
			}
			set
			{
				this.X0Y0_面中1_面中下.Dra = value;
				this.X0Y0_面中1_面中下.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.面額_表示;
			}
			set
			{
				this.面額_表示 = value;
				this.面左下_面目_表示 = value;
				this.面左下_面_表示 = value;
				this.面右下_面目_表示 = value;
				this.面右下_面_表示 = value;
				this.面左外_表示 = value;
				this.面右外_表示 = value;
				this.面左上_面目_表示 = value;
				this.面左上_面_表示 = value;
				this.面右上_面目_表示 = value;
				this.面右上_面_表示 = value;
				this.面中0_面中_表示 = value;
				this.面中0_付根左_付根1_表示 = value;
				this.面中0_付根左_付根2_表示 = value;
				this.面中0_付根右_付根1_表示 = value;
				this.面中0_付根右_付根2_表示 = value;
				this.面中2_面中_表示 = value;
				this.面中2_面中下_表示 = value;
				this.面中1_面中_表示 = value;
				this.面中1_面中下_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.面額CD.不透明度;
			}
			set
			{
				this.面額CD.不透明度 = value;
				this.面左下_面目CD.不透明度 = value;
				this.面左下_面CD.不透明度 = value;
				this.面右下_面目CD.不透明度 = value;
				this.面右下_面CD.不透明度 = value;
				this.面左外CD.不透明度 = value;
				this.面右外CD.不透明度 = value;
				this.面左上_面目CD.不透明度 = value;
				this.面左上_面CD.不透明度 = value;
				this.面右上_面目CD.不透明度 = value;
				this.面右上_面CD.不透明度 = value;
				this.面中0_面中CD.不透明度 = value;
				this.面中0_付根左_付根1CD.不透明度 = value;
				this.面中0_付根左_付根2CD.不透明度 = value;
				this.面中0_付根右_付根1CD.不透明度 = value;
				this.面中0_付根右_付根2CD.不透明度 = value;
				this.面中2_面中CD.不透明度 = value;
				this.面中2_面中下CD.不透明度 = value;
				this.面中1_面中CD.不透明度 = value;
				this.面中1_面中下CD.不透明度 = value;
			}
		}

		public override double 展開1
		{
			set
			{
				Vector2D positionCont = (this.X0Y0_面左下_面.OP[1].ps[2] - this.X0Y0_面左下_面.OP[2].ps[2]) * value;
				this.X0Y0_面左上_面目.PositionCont = positionCont;
				this.X0Y0_面左下_面目.PositionCont = positionCont;
				this.X0Y0_面左下_面.PositionCont = positionCont;
				this.X0Y0_面左外.PositionCont = positionCont;
				positionCont = (this.X0Y0_面右下_面.OP[3].ps[2] - this.X0Y0_面右下_面.OP[2].ps[2]) * value;
				this.X0Y0_面右上_面目.PositionCont = positionCont;
				this.X0Y0_面右下_面目.PositionCont = positionCont;
				this.X0Y0_面右下_面.PositionCont = positionCont;
				this.X0Y0_面右外.PositionCont = positionCont;
				this.X0Y0_面中2_面中.PositionCont = (this.X0Y0_面中2_面中.OP[2].ps[1] - this.X0Y0_面中2_面中.OP[0].ps[0]) * 0.35 * value;
			}
		}

		public JointS 触覚左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_面中0_付根左_付根2, 0);
			}
		}

		public JointS 触覚右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_面中0_付根右_付根2, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_面額CP.Update();
			this.X0Y0_面左下_面目CP.Update();
			this.X0Y0_面左下_面CP.Update();
			this.X0Y0_面右下_面目CP.Update();
			this.X0Y0_面右下_面CP.Update();
			this.X0Y0_面左外CP.Update();
			this.X0Y0_面右外CP.Update();
			this.X0Y0_面左上_面目CP.Update();
			this.X0Y0_面左上_面CP.Update();
			this.X0Y0_面右上_面目CP.Update();
			this.X0Y0_面右上_面CP.Update();
			this.X0Y0_面中0_面中CP.Update();
			this.X0Y0_面中0_付根左_付根1CP.Update();
			this.X0Y0_面中0_付根左_付根2CP.Update();
			this.X0Y0_面中0_付根右_付根1CP.Update();
			this.X0Y0_面中0_付根右_付根2CP.Update();
			this.X0Y0_面中2_面中CP.Update();
			this.X0Y0_面中2_面中下CP.Update();
			this.X0Y0_面中1_面中CP.Update();
			this.X0Y0_面中1_面中下CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.面額CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.面左下_面目CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.面左下_面CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.面右下_面目CD = this.面左下_面目CD;
			this.面右下_面CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.面左外CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.面右外CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.面左上_面目CD = this.面左下_面目CD;
			this.面左上_面CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.面右上_面目CD = this.面左下_面目CD;
			this.面右上_面CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.面中0_面中CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.面中0_付根左_付根1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.面中0_付根左_付根2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.面中0_付根右_付根1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.面中0_付根右_付根2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.面中2_面中CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.面中2_面中下CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.面中1_面中CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.面中1_面中下CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
		}

		public Par X0Y0_面額;

		public Par X0Y0_面左下_面目;

		public Par X0Y0_面左下_面;

		public Par X0Y0_面右下_面目;

		public Par X0Y0_面右下_面;

		public Par X0Y0_面左外;

		public Par X0Y0_面右外;

		public Par X0Y0_面左上_面目;

		public Par X0Y0_面左上_面;

		public Par X0Y0_面右上_面目;

		public Par X0Y0_面右上_面;

		public Par X0Y0_面中0_面中;

		public Par X0Y0_面中0_付根左_付根1;

		public Par X0Y0_面中0_付根左_付根2;

		public Par X0Y0_面中0_付根右_付根1;

		public Par X0Y0_面中0_付根右_付根2;

		public Par X0Y0_面中2_面中;

		public Par X0Y0_面中2_面中下;

		public Par X0Y0_面中1_面中;

		public Par X0Y0_面中1_面中下;

		public ColorD 面額CD;

		public ColorD 面左下_面目CD;

		public ColorD 面左下_面CD;

		public ColorD 面右下_面目CD;

		public ColorD 面右下_面CD;

		public ColorD 面左外CD;

		public ColorD 面右外CD;

		public ColorD 面左上_面目CD;

		public ColorD 面左上_面CD;

		public ColorD 面右上_面目CD;

		public ColorD 面右上_面CD;

		public ColorD 面中0_面中CD;

		public ColorD 面中0_付根左_付根1CD;

		public ColorD 面中0_付根左_付根2CD;

		public ColorD 面中0_付根右_付根1CD;

		public ColorD 面中0_付根右_付根2CD;

		public ColorD 面中2_面中CD;

		public ColorD 面中2_面中下CD;

		public ColorD 面中1_面中CD;

		public ColorD 面中1_面中下CD;

		public ColorP X0Y0_面額CP;

		public ColorP X0Y0_面左下_面目CP;

		public ColorP X0Y0_面左下_面CP;

		public ColorP X0Y0_面右下_面目CP;

		public ColorP X0Y0_面右下_面CP;

		public ColorP X0Y0_面左外CP;

		public ColorP X0Y0_面右外CP;

		public ColorP X0Y0_面左上_面目CP;

		public ColorP X0Y0_面左上_面CP;

		public ColorP X0Y0_面右上_面目CP;

		public ColorP X0Y0_面右上_面CP;

		public ColorP X0Y0_面中0_面中CP;

		public ColorP X0Y0_面中0_付根左_付根1CP;

		public ColorP X0Y0_面中0_付根左_付根2CP;

		public ColorP X0Y0_面中0_付根右_付根1CP;

		public ColorP X0Y0_面中0_付根右_付根2CP;

		public ColorP X0Y0_面中2_面中CP;

		public ColorP X0Y0_面中2_面中下CP;

		public ColorP X0Y0_面中1_面中CP;

		public ColorP X0Y0_面中1_面中下CP;
	}
}
