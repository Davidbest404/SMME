using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 大顎基 : Ele
	{
		public 大顎基(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 大顎基D e)
		{
			大顎基.<>c__DisplayClass4_0 CS$<>8__locals1 = new 大顎基.<>c__DisplayClass4_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.大顎上 = new 大顎上(CS$<>8__locals1.DisUnit, 配色指定, CS$<>8__locals1.体配色);
			this.大顎上.Par = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.肢中["大顎基"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_甲殻下 = pars["甲殻下"].ToPar();
			this.大顎上.接続(this.大顎上_接続点);
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
			this.甲殻下_表示 = e.甲殻下_表示;
			this.甲殻_表示 = e.甲殻_表示;
			this.線左_表示 = e.線左_表示;
			this.線右_表示 = e.線右_表示;
			this.刺左_表示 = e.刺左_表示;
			this.刺右_表示 = e.刺右_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.顎左_接続.Count > 0)
			{
				Ele f;
				this.顎左_接続 = e.顎左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.大顎基_顎左_接続;
					f.接続(CS$<>8__locals1.<>4__this.顎左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.顎右_接続.Count > 0)
			{
				Ele f;
				this.顎右_接続 = e.顎右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.大顎基_顎右_接続;
					f.接続(CS$<>8__locals1.<>4__this.顎右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_甲殻下CP = new ColorP(this.X0Y0_甲殻下, this.甲殻下CD, CS$<>8__locals1.DisUnit, true);
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
				this.大顎上.欠損 = value;
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
				this.大顎上.筋肉 = value;
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
				this.大顎上.拘束 = value;
			}
		}

		public bool 甲殻下_表示
		{
			get
			{
				return this.X0Y0_甲殻下.Dra;
			}
			set
			{
				this.X0Y0_甲殻下.Dra = value;
				this.X0Y0_甲殻下.Hit = value;
			}
		}

		public bool 甲殻_表示
		{
			get
			{
				return this.大顎上.X0Y0_甲殻.Dra;
			}
			set
			{
				this.大顎上.X0Y0_甲殻.Dra = value;
				this.大顎上.X0Y0_甲殻.Hit = value;
			}
		}

		public bool 線左_表示
		{
			get
			{
				return this.大顎上.X0Y0_線左.Dra;
			}
			set
			{
				this.大顎上.X0Y0_線左.Dra = value;
				this.大顎上.X0Y0_線左.Hit = value;
			}
		}

		public bool 線右_表示
		{
			get
			{
				return this.大顎上.X0Y0_線右.Dra;
			}
			set
			{
				this.大顎上.X0Y0_線右.Dra = value;
				this.大顎上.X0Y0_線右.Hit = value;
			}
		}

		public bool 刺左_表示
		{
			get
			{
				return this.大顎上.X0Y0_棘左.Dra;
			}
			set
			{
				this.大顎上.X0Y0_棘左.Dra = value;
				this.大顎上.X0Y0_棘左.Hit = value;
			}
		}

		public bool 刺右_表示
		{
			get
			{
				return this.大顎上.X0Y0_棘右.Dra;
			}
			set
			{
				this.大顎上.X0Y0_棘右.Dra = value;
				this.大顎上.X0Y0_棘右.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.甲殻下_表示;
			}
			set
			{
				this.甲殻下_表示 = value;
				this.大顎上.表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.甲殻下CD.不透明度;
			}
			set
			{
				this.甲殻下CD.不透明度 = value;
				this.大顎上.濃度 = value;
			}
		}

		public double 展開
		{
			set
			{
				this.位置C = new Vector2D(this.位置C.X, -0.013 * value);
				foreach (Ele ele in this.EnumEle())
				{
					ele.尺度YC = 1.0 - 0.05 * value;
				}
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
				this.大顎上.尺度B = value;
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
				this.大顎上.尺度C = value;
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
				this.大顎上.尺度XB = value;
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
				this.大顎上.尺度XC = value;
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
				this.大顎上.尺度YB = value;
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
				this.大顎上.尺度YC = value;
			}
		}

		public override double 肥大
		{
			set
			{
				base.肥大 = value;
				this.大顎上.肥大 = value;
			}
		}

		public override double 身長
		{
			set
			{
				base.身長 = value;
				this.大顎上.身長 = value;
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
				this.大顎上.右 = value;
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
				this.大顎上.反転X = value;
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
				this.大顎上.反転Y = value;
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
				this.大顎上.Xv = value;
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
				this.大顎上.Yv = value;
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
				this.大顎上.Xi = value;
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
				this.大顎上.Yi = value;
			}
		}

		public override void Dispose()
		{
			base.Dispose();
			this.大顎上.Dispose();
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
				this.大顎上.サイズ = value;
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
				this.大顎上.サイズX = value;
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
				this.大顎上.サイズY = value;
			}
		}

		public override void 接続P()
		{
			this.接続根.JoinP();
			this.大顎上.接続P();
		}

		public override void 接続PA()
		{
			this.接続根.JoinPA();
			this.大顎上.接続PA();
		}

		public JointS 顎左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_甲殻下, 0);
			}
		}

		public JointS 顎右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_甲殻下, 1);
			}
		}

		public JointS 大顎上_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_甲殻下, 2);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_甲殻下CP.Update();
			this.大顎上.色更新();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.甲殻下CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
		}

		public Par X0Y0_甲殻下;

		public 大顎上 大顎上;

		public ColorD 甲殻下CD;

		public ColorP X0Y0_甲殻下CP;

		public Ele[] 顎左_接続;

		public Ele[] 顎右_接続;
	}
}
