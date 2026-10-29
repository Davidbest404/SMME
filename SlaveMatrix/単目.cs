using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 単目 : Ele
	{
		public 単目(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 単目D e)
		{
			単目.<>c__DisplayClass18_0 CS$<>8__locals1 = new 単目.<>c__DisplayClass18_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["単眼目"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_白目 = pars["白目"].ToPar();
			Pars pars2 = pars["黒目"].ToPars();
			this.X0Y0_黒目_黒目 = pars2["黒目"].ToPar();
			this.X0Y0_黒目_瞳孔 = pars2["瞳孔"].ToPar();
			this.X0Y0_黒目_ハイライト上 = pars2["ハイライト上"].ToPar();
			this.X0Y0_黒目_ハイライト下 = pars2["ハイライト下"].ToPar();
			this.X0Y0_黒目_ハ\u30FCト = pars2["ハート"].ToPar();
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
			this.白目_表示 = e.白目_表示;
			this.黒目_黒目_表示 = e.黒目_黒目_表示;
			this.黒目_瞳孔_表示 = e.黒目_瞳孔_表示;
			this.黒目_ハイライト上_表示 = e.黒目_ハイライト上_表示;
			this.黒目_ハイライト下_表示 = e.黒目_ハイライト下_表示;
			this.黒目_ハ\u30FCト_表示 = e.黒目_ハ\u30FCト_表示;
			if (e.猫目)
			{
				this.猫目();
			}
			if (e.蛸目)
			{
				this.蛸目();
			}
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.瞼_接続.Count > 0)
			{
				Ele f;
				this.瞼_接続 = e.瞼_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.単目_瞼_接続;
					f.接続(CS$<>8__locals1.<>4__this.瞼_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_白目CP = new ColorP(this.X0Y0_白目, this.白目CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_黒目_黒目CP = new ColorP(this.X0Y0_黒目_黒目, this.黒目_黒目CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_黒目_瞳孔CP = new ColorP(this.X0Y0_黒目_瞳孔, this.黒目_瞳孔CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_黒目_ハイライト上CP = new ColorP(this.X0Y0_黒目_ハイライト上, this.黒目_ハイライト上CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_黒目_ハイライト下CP = new ColorP(this.X0Y0_黒目_ハイライト下, this.黒目_ハイライト下CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_黒目_ハ\u30FCトCP = new ColorP(this.X0Y0_黒目_ハ\u30FCト, this.黒目_ハ\u30FCトCD, CS$<>8__locals1.DisUnit, true);
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

		public bool 白目_表示
		{
			get
			{
				return this.X0Y0_白目.Dra;
			}
			set
			{
				this.X0Y0_白目.Dra = value;
				this.X0Y0_白目.Hit = value;
			}
		}

		public bool 黒目_黒目_表示
		{
			get
			{
				return this.X0Y0_黒目_黒目.Dra;
			}
			set
			{
				this.X0Y0_黒目_黒目.Dra = value;
				this.X0Y0_黒目_黒目.Hit = value;
			}
		}

		public bool 黒目_瞳孔_表示
		{
			get
			{
				return this.X0Y0_黒目_瞳孔.Dra;
			}
			set
			{
				this.X0Y0_黒目_瞳孔.Dra = value;
				this.X0Y0_黒目_瞳孔.Hit = value;
			}
		}

		public bool 黒目_ハイライト上_表示
		{
			get
			{
				return this.X0Y0_黒目_ハイライト上.Dra;
			}
			set
			{
				this.X0Y0_黒目_ハイライト上.Dra = value;
				this.X0Y0_黒目_ハイライト上.Hit = value;
			}
		}

		public bool 黒目_ハイライト下_表示
		{
			get
			{
				return this.X0Y0_黒目_ハイライト下.Dra;
			}
			set
			{
				this.X0Y0_黒目_ハイライト下.Dra = value;
				this.X0Y0_黒目_ハイライト下.Hit = value;
			}
		}

		public bool 黒目_ハ\u30FCト_表示
		{
			get
			{
				return this.X0Y0_黒目_ハ\u30FCト.Dra;
			}
			set
			{
				this.X0Y0_黒目_ハ\u30FCト.Dra = value;
				this.X0Y0_黒目_ハ\u30FCト.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.白目_表示;
			}
			set
			{
				this.白目_表示 = value;
				this.黒目_黒目_表示 = value;
				this.黒目_瞳孔_表示 = value;
				this.黒目_ハイライト上_表示 = value;
				this.黒目_ハイライト下_表示 = value;
				this.黒目_ハ\u30FCト_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.白目CD.不透明度;
			}
			set
			{
				this.白目CD.不透明度 = value;
				this.黒目_黒目CD.不透明度 = value;
				this.黒目_瞳孔CD.不透明度 = value;
				this.黒目_ハイライト上CD.不透明度 = value;
				this.黒目_ハイライト下CD.不透明度 = value;
				this.黒目_ハ\u30FCトCD.不透明度 = value;
			}
		}

		public Vector2D 視線
		{
			get
			{
				return this.X0Y0_黒目_黒目.PositionCont;
			}
			set
			{
				this.X0Y0_黒目_黒目.PositionCont = value;
				this.X0Y0_黒目_瞳孔.PositionCont = value;
				this.X0Y0_黒目_ハ\u30FCト.PositionCont = value;
			}
		}

		public void 猫目()
		{
			this.X0Y0_黒目_瞳孔.SizeXBase *= 0.25;
			this.X0Y0_黒目_瞳孔.SizeYBase *= 1.5;
		}

		public void 蛸目()
		{
			this.X0Y0_黒目_瞳孔.SizeXBase *= 2.0;
			this.X0Y0_黒目_瞳孔.SizeYBase *= 0.5;
		}

		public override double 肥大
		{
			set
			{
			}
		}

		public override double 身長
		{
			set
			{
			}
		}

		public JointS 瞼_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_白目, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_白目CP.Update();
			this.X0Y0_黒目_黒目CP.Update();
			this.X0Y0_黒目_瞳孔CP.Update();
			this.X0Y0_黒目_ハイライト上CP.Update();
			this.X0Y0_黒目_ハイライト下CP.Update();
			this.X0Y0_黒目_ハ\u30FCトCP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.白目CD = new ColorD(ref Col.Empty, ref 体配色.白部O);
			this.黒目_黒目CD = new ColorD(ref Col.Black, ref 体配色.目左O);
			this.黒目_瞳孔CD = new ColorD(ref Col.Black, ref 体配色.瞳孔);
			this.黒目_ハイライト上CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.黒目_ハイライト下CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.黒目_ハ\u30FCトCD = new ColorD(ref Col.Empty, ref 体配色.ハ\u30FCトO);
		}

		public Par X0Y0_白目;

		public Par X0Y0_黒目_黒目;

		public Par X0Y0_黒目_瞳孔;

		public Par X0Y0_黒目_ハイライト上;

		public Par X0Y0_黒目_ハイライト下;

		public Par X0Y0_黒目_ハ\u30FCト;

		public ColorD 白目CD;

		public ColorD 黒目_黒目CD;

		public ColorD 黒目_瞳孔CD;

		public ColorD 黒目_ハイライト上CD;

		public ColorD 黒目_ハイライト下CD;

		public ColorD 黒目_ハ\u30FCトCD;

		public ColorP X0Y0_白目CP;

		public ColorP X0Y0_黒目_黒目CP;

		public ColorP X0Y0_黒目_瞳孔CP;

		public ColorP X0Y0_黒目_ハイライト上CP;

		public ColorP X0Y0_黒目_ハイライト下CP;

		public ColorP X0Y0_黒目_ハ\u30FCトCP;

		public Ele[] 瞼_接続;
	}
}
