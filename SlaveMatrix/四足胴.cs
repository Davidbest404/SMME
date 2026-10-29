using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 四足胴 : Ele
	{
		public 四足胴(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 四足胴D e)
		{
			四足胴.<>c__DisplayClass15_0 CS$<>8__locals1 = new 四足胴.<>c__DisplayClass15_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.半身["四足胴"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_胴 = pars["胴"].ToPar();
			Pars pars2 = pars["筋肉"].ToPars();
			this.X0Y0_筋肉_筋肉左 = pars2["筋肉左"].ToPar();
			this.X0Y0_筋肉_筋肉右 = pars2["筋肉右"].ToPar();
			pars2 = pars["獣性"].ToPars();
			this.X0Y0_獣性_獣毛左 = pars2["獣毛左"].ToPar();
			this.X0Y0_獣性_獣毛右 = pars2["獣毛右"].ToPar();
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
			this.胴_表示 = e.胴_表示;
			this.筋肉_筋肉左_表示 = e.筋肉_筋肉左_表示;
			this.筋肉_筋肉右_表示 = e.筋肉_筋肉右_表示;
			this.獣性_獣毛左_表示 = e.獣性_獣毛左_表示;
			this.獣性_獣毛右_表示 = e.獣性_獣毛右_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.腰_接続.Count > 0)
			{
				Ele f;
				this.腰_接続 = e.腰_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.四足胴_腰_接続;
					f.接続(CS$<>8__locals1.<>4__this.腰_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.肌_接続.Count > 0)
			{
				Ele f;
				this.肌_接続 = e.肌_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.四足胴_肌_接続;
					f.接続(CS$<>8__locals1.<>4__this.肌_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.翼左_接続.Count > 0)
			{
				Ele f;
				this.翼左_接続 = e.翼左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.四足胴_翼左_接続;
					f.接続(CS$<>8__locals1.<>4__this.翼左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.翼右_接続.Count > 0)
			{
				Ele f;
				this.翼右_接続 = e.翼右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.四足胴_翼右_接続;
					f.接続(CS$<>8__locals1.<>4__this.翼右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_胴CP = new ColorP(this.X0Y0_胴, this.胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_筋肉_筋肉左CP = new ColorP(this.X0Y0_筋肉_筋肉左, this.筋肉_筋肉左CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋肉右CP = new ColorP(this.X0Y0_筋肉_筋肉右, this.筋肉_筋肉右CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_獣性_獣毛左CP = new ColorP(this.X0Y0_獣性_獣毛左, this.獣性_獣毛左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_獣性_獣毛右CP = new ColorP(this.X0Y0_獣性_獣毛右, this.獣性_獣毛右CD, CS$<>8__locals1.DisUnit, true);
			this.筋肉濃度 = e.筋肉濃度;
			this.濃度 = e.濃度;
			this.尺度YB = 0.96;
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
				this.筋肉_筋肉左_表示 = this.筋肉_;
				this.筋肉_筋肉右_表示 = this.筋肉_;
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

		public bool 胴_表示
		{
			get
			{
				return this.X0Y0_胴.Dra;
			}
			set
			{
				this.X0Y0_胴.Dra = value;
				this.X0Y0_胴.Hit = value;
			}
		}

		public bool 筋肉_筋肉左_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋肉左.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋肉左.Dra = value;
				this.X0Y0_筋肉_筋肉左.Hit = value;
			}
		}

		public bool 筋肉_筋肉右_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋肉右.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋肉右.Dra = value;
				this.X0Y0_筋肉_筋肉右.Hit = value;
			}
		}

		public bool 獣性_獣毛左_表示
		{
			get
			{
				return this.X0Y0_獣性_獣毛左.Dra;
			}
			set
			{
				this.X0Y0_獣性_獣毛左.Dra = value;
				this.X0Y0_獣性_獣毛左.Hit = value;
			}
		}

		public bool 獣性_獣毛右_表示
		{
			get
			{
				return this.X0Y0_獣性_獣毛右.Dra;
			}
			set
			{
				this.X0Y0_獣性_獣毛右.Dra = value;
				this.X0Y0_獣性_獣毛右.Hit = value;
			}
		}

		public double 筋肉濃度
		{
			get
			{
				return this.筋肉_筋肉左CD.不透明度;
			}
			set
			{
				this.筋肉_筋肉左CD.不透明度 = value;
				this.筋肉_筋肉右CD.不透明度 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.胴_表示;
			}
			set
			{
				this.胴_表示 = value;
				this.筋肉_筋肉左_表示 = value;
				this.筋肉_筋肉右_表示 = value;
				this.獣性_獣毛左_表示 = value;
				this.獣性_獣毛右_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.胴CD.不透明度;
			}
			set
			{
				this.胴CD.不透明度 = value;
				this.筋肉_筋肉左CD.不透明度 = value;
				this.筋肉_筋肉右CD.不透明度 = value;
				this.獣性_獣毛左CD.不透明度 = value;
				this.獣性_獣毛右CD.不透明度 = value;
			}
		}

		public JointS 腰_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴, 4);
			}
		}

		public JointS 肌_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴, 5);
			}
		}

		public JointS 翼左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴, 0);
			}
		}

		public JointS 翼右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴, 1);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_胴CP.Update();
			this.X0Y0_筋肉_筋肉左CP.Update();
			this.X0Y0_筋肉_筋肉右CP.Update();
			this.X0Y0_獣性_獣毛左CP.Update();
			this.X0Y0_獣性_獣毛右CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.胴CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.筋肉_筋肉左CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋肉右CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.獣性_獣毛左CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛右CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
		}

		public Par X0Y0_胴;

		public Par X0Y0_筋肉_筋肉左;

		public Par X0Y0_筋肉_筋肉右;

		public Par X0Y0_獣性_獣毛左;

		public Par X0Y0_獣性_獣毛右;

		public ColorD 胴CD;

		public ColorD 筋肉_筋肉左CD;

		public ColorD 筋肉_筋肉右CD;

		public ColorD 獣性_獣毛左CD;

		public ColorD 獣性_獣毛右CD;

		public ColorP X0Y0_胴CP;

		public ColorP X0Y0_筋肉_筋肉左CP;

		public ColorP X0Y0_筋肉_筋肉右CP;

		public ColorP X0Y0_獣性_獣毛左CP;

		public ColorP X0Y0_獣性_獣毛右CP;

		public Ele[] 腰_接続;

		public Ele[] 肌_接続;

		public Ele[] 翼左_接続;

		public Ele[] 翼右_接続;
	}
}
