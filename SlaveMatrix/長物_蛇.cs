using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 長物_蛇 : 半身
	{
		public 長物_蛇(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 長物_蛇D e)
		{
			長物_蛇.<>c__DisplayClass27_0 CS$<>8__locals1 = new 長物_蛇.<>c__DisplayClass27_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Pars pars = new Pars();
			pars.Tag = "蛇";
			pars.Add(new Pars(Sta.半身["長物"][0][2]["胴1"].ToPars()));
			Dif dif = new Dif();
			dif.Tag = pars.Tag;
			dif.Add(pars);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars2 = this.本体[0][0]["胴1"].ToPars();
			this.X0Y0_胴1_胴 = pars2["胴"].ToPar();
			this.X0Y0_胴1_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y0_胴1_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_胴1_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_胴1_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y0_胴1_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_胴1_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_胴1_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_胴1_鱗右1 = pars2["鱗右1"].ToPar();
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
			this.胴1_表示 = e.胴1_表示;
			this.胴1_鱗2_表示 = e.胴1_鱗2_表示;
			this.胴1_鱗右_表示 = e.胴1_鱗右_表示;
			this.胴1_鱗左_表示 = e.胴1_鱗左_表示;
			this.胴1_鱗1_表示 = e.胴1_鱗1_表示;
			this.胴1_鱗左2_表示 = e.胴1_鱗左2_表示;
			this.胴1_鱗右2_表示 = e.胴1_鱗右2_表示;
			this.胴1_鱗左1_表示 = e.胴1_鱗左1_表示;
			this.胴1_鱗右1_表示 = e.胴1_鱗右1_表示;
			this.くぱぁ = e.くぱぁ;
			this.ガ\u30FCド = e.ガ\u30FCド;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.左_接続.Count > 0)
			{
				Ele f;
				this.左_接続 = e.左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.長物_蛇_左_接続;
					f.接続(CS$<>8__locals1.<>4__this.左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右_接続.Count > 0)
			{
				Ele f;
				this.右_接続 = e.右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.長物_蛇_右_接続;
					f.接続(CS$<>8__locals1.<>4__this.右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.胴_接続.Count > 0)
			{
				Ele f;
				this.胴_接続 = e.胴_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.長物_蛇_胴_接続;
					f.接続(CS$<>8__locals1.<>4__this.胴_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_胴1_胴CP = new ColorP(this.X0Y0_胴1_胴, this.胴1_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴1_鱗2CP = new ColorP(this.X0Y0_胴1_鱗2, this.胴1_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴1_鱗右CP = new ColorP(this.X0Y0_胴1_鱗右, this.胴1_鱗右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴1_鱗左CP = new ColorP(this.X0Y0_胴1_鱗左, this.胴1_鱗左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴1_鱗1CP = new ColorP(this.X0Y0_胴1_鱗1, this.胴1_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴1_鱗左2CP = new ColorP(this.X0Y0_胴1_鱗左2, this.胴1_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴1_鱗右2CP = new ColorP(this.X0Y0_胴1_鱗右2, this.胴1_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴1_鱗左1CP = new ColorP(this.X0Y0_胴1_鱗左1, this.胴1_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴1_鱗右1CP = new ColorP(this.X0Y0_胴1_鱗右1, this.胴1_鱗右1CD, CS$<>8__locals1.DisUnit, true);
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

		public bool 胴1_表示
		{
			get
			{
				return this.X0Y0_胴1_胴.Dra;
			}
			set
			{
				this.X0Y0_胴1_胴.Dra = value;
				this.X0Y0_胴1_胴.Hit = value;
			}
		}

		public bool 胴1_鱗2_表示
		{
			get
			{
				return this.X0Y0_胴1_鱗2.Dra;
			}
			set
			{
				this.X0Y0_胴1_鱗2.Dra = value;
				this.X0Y0_胴1_鱗2.Hit = value;
			}
		}

		public bool 胴1_鱗右_表示
		{
			get
			{
				return this.X0Y0_胴1_鱗右.Dra;
			}
			set
			{
				this.X0Y0_胴1_鱗右.Dra = value;
				this.X0Y0_胴1_鱗右.Hit = value;
			}
		}

		public bool 胴1_鱗左_表示
		{
			get
			{
				return this.X0Y0_胴1_鱗左.Dra;
			}
			set
			{
				this.X0Y0_胴1_鱗左.Dra = value;
				this.X0Y0_胴1_鱗左.Hit = value;
			}
		}

		public bool 胴1_鱗1_表示
		{
			get
			{
				return this.X0Y0_胴1_鱗1.Dra;
			}
			set
			{
				this.X0Y0_胴1_鱗1.Dra = value;
				this.X0Y0_胴1_鱗1.Hit = value;
			}
		}

		public bool 胴1_鱗左2_表示
		{
			get
			{
				return this.X0Y0_胴1_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_胴1_鱗左2.Dra = value;
				this.X0Y0_胴1_鱗左2.Hit = value;
			}
		}

		public bool 胴1_鱗右2_表示
		{
			get
			{
				return this.X0Y0_胴1_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_胴1_鱗右2.Dra = value;
				this.X0Y0_胴1_鱗右2.Hit = value;
			}
		}

		public bool 胴1_鱗左1_表示
		{
			get
			{
				return this.X0Y0_胴1_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_胴1_鱗左1.Dra = value;
				this.X0Y0_胴1_鱗左1.Hit = value;
			}
		}

		public bool 胴1_鱗右1_表示
		{
			get
			{
				return this.X0Y0_胴1_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_胴1_鱗右1.Dra = value;
				this.X0Y0_胴1_鱗右1.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.胴1_表示;
			}
			set
			{
				this.胴1_表示 = value;
				this.胴1_鱗2_表示 = value;
				this.胴1_鱗右_表示 = value;
				this.胴1_鱗左_表示 = value;
				this.胴1_鱗1_表示 = value;
				this.胴1_鱗左2_表示 = value;
				this.胴1_鱗右2_表示 = value;
				this.胴1_鱗左1_表示 = value;
				this.胴1_鱗右1_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.胴1_胴CD.不透明度;
			}
			set
			{
				this.胴1_胴CD.不透明度 = value;
				this.胴1_鱗2CD.不透明度 = value;
				this.胴1_鱗右CD.不透明度 = value;
				this.胴1_鱗左CD.不透明度 = value;
				this.胴1_鱗1CD.不透明度 = value;
				this.胴1_鱗左2CD.不透明度 = value;
				this.胴1_鱗右2CD.不透明度 = value;
				this.胴1_鱗左1CD.不透明度 = value;
				this.胴1_鱗右1CD.不透明度 = value;
			}
		}

		public double くぱぁ
		{
			get
			{
				return this.くぱぁ_;
			}
			set
			{
				if (this.sb == 0.0)
				{
					this.sb = this.X0Y0_胴1_鱗左.SizeXBase;
				}
				this.くぱぁ_ = value;
				this.X0Y0_胴1_鱗左.SizeXBase = this.sb * (1.0 - 0.35 * this.くぱぁ_);
				this.X0Y0_胴1_鱗右.SizeXBase = this.sb * (1.0 - 0.35 * this.くぱぁ_);
			}
		}

		public bool ガ\u30FCド
		{
			get
			{
				return this.ガ\u30FCド_;
			}
			set
			{
				this.ガ\u30FCド_ = value;
				this.胴1_鱗1_表示 = this.ガ\u30FCド_;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_胴1_鱗2);
			Are.Draw(this.X0Y0_胴1_鱗左2);
			Are.Draw(this.X0Y0_胴1_鱗右2);
			if (this.胴_接続 != null && this.胴_接続[0].拘束 && this.胴_接続[0] is 胴_蛇)
			{
				((胴_蛇)this.胴_接続[0]).拘束具描画(Are);
			}
			if (this.くぱぁ_ == 1.0)
			{
				Are.Draw(this.X0Y0_胴1_鱗右);
				Are.Draw(this.X0Y0_胴1_鱗左);
			}
		}

		public void 前描画(Are Are)
		{
			if (this.くぱぁ_ != 1.0)
			{
				Are.Draw(this.X0Y0_胴1_鱗右);
				Are.Draw(this.X0Y0_胴1_鱗左);
			}
			Are.Draw(this.X0Y0_胴1_鱗1);
			Are.Draw(this.X0Y0_胴1_鱗左1);
			Are.Draw(this.X0Y0_胴1_鱗右1);
		}

		public JointS 左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴1_胴, 2);
			}
		}

		public JointS 右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴1_胴, 3);
			}
		}

		public JointS 胴_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴1_胴, 1);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_胴1_胴CP.Update();
			this.X0Y0_胴1_鱗2CP.Update();
			this.X0Y0_胴1_鱗右CP.Update();
			this.X0Y0_胴1_鱗左CP.Update();
			this.X0Y0_胴1_鱗1CP.Update();
			this.X0Y0_胴1_鱗左2CP.Update();
			this.X0Y0_胴1_鱗右2CP.Update();
			this.X0Y0_胴1_鱗左1CP.Update();
			this.X0Y0_胴1_鱗右1CP.Update();
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
			this.胴1_胴CD = new ColorD(ref Col.Empty, ref Color2.Empty);
			this.胴1_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.胴1_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.胴1_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.胴1_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.胴1_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴1_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴1_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴1_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.胴1_胴CD = new ColorD(ref Col.Empty, ref Color2.Empty);
			this.胴1_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.胴1_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.胴1_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.胴1_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.胴1_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴1_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴1_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴1_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.胴1_胴CD = new ColorD(ref Col.Empty, ref Color2.Empty);
			this.胴1_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.胴1_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.胴1_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.胴1_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.胴1_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴1_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴1_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴1_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
		}

		public Par X0Y0_胴1_胴;

		public Par X0Y0_胴1_鱗2;

		public Par X0Y0_胴1_鱗右;

		public Par X0Y0_胴1_鱗左;

		public Par X0Y0_胴1_鱗1;

		public Par X0Y0_胴1_鱗左2;

		public Par X0Y0_胴1_鱗右2;

		public Par X0Y0_胴1_鱗左1;

		public Par X0Y0_胴1_鱗右1;

		public ColorD 胴1_胴CD;

		public ColorD 胴1_鱗2CD;

		public ColorD 胴1_鱗右CD;

		public ColorD 胴1_鱗左CD;

		public ColorD 胴1_鱗1CD;

		public ColorD 胴1_鱗左2CD;

		public ColorD 胴1_鱗右2CD;

		public ColorD 胴1_鱗左1CD;

		public ColorD 胴1_鱗右1CD;

		public ColorP X0Y0_胴1_胴CP;

		public ColorP X0Y0_胴1_鱗2CP;

		public ColorP X0Y0_胴1_鱗右CP;

		public ColorP X0Y0_胴1_鱗左CP;

		public ColorP X0Y0_胴1_鱗1CP;

		public ColorP X0Y0_胴1_鱗左2CP;

		public ColorP X0Y0_胴1_鱗右2CP;

		public ColorP X0Y0_胴1_鱗左1CP;

		public ColorP X0Y0_胴1_鱗右1CP;

		private double くぱぁ_;

		private double sb;

		private bool ガ\u30FCド_;

		public Ele[] 左_接続;

		public Ele[] 右_接続;

		public Ele[] 胴_接続;
	}
}
