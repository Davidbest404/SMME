using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 瞼_宇 : 双瞼
	{
		public 瞼_宇(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 瞼_宇D e)
		{
			瞼_宇.<>c__DisplayClass33_0 CS$<>8__locals1 = new 瞼_宇.<>c__DisplayClass33_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["エイリアン目左"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_目 = pars["目"].ToPar();
			this.X0Y0_ハイライト = pars["ハイライト"].ToPar();
			this.X0Y0_瞬膜 = pars["瞬膜"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_目 = pars["目"].ToPar();
			this.X0Y1_ハイライト = pars["ハイライト"].ToPar();
			this.X0Y1_瞬膜 = pars["瞬膜"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_目 = pars["目"].ToPar();
			this.X0Y2_ハイライト = pars["ハイライト"].ToPar();
			this.X0Y2_瞬膜 = pars["瞬膜"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_目 = pars["目"].ToPar();
			this.X0Y3_ハイライト = pars["ハイライト"].ToPar();
			this.X0Y3_瞬膜 = pars["瞬膜"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_目 = pars["目"].ToPar();
			this.X0Y4_ハイライト = pars["ハイライト"].ToPar();
			this.X0Y4_瞬膜 = pars["瞬膜"].ToPar();
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
			this.目_表示 = e.目_表示;
			this.ハイライト_表示 = e.ハイライト_表示;
			this.瞬膜_表示 = e.瞬膜_表示;
			base.傾き = e.傾き;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.涙_接続.Count > 0)
			{
				Ele f;
				this.涙_接続 = e.涙_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.瞼_宇_涙_接続;
					f.接続(CS$<>8__locals1.<>4__this.涙_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_目CP = new ColorP(this.X0Y0_目, this.目CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ハイライトCP = new ColorP(this.X0Y0_ハイライト, this.ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_瞬膜CP = new ColorP(this.X0Y0_瞬膜, this.瞬膜CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_目CP = new ColorP(this.X0Y1_目, this.目CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ハイライトCP = new ColorP(this.X0Y1_ハイライト, this.ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_瞬膜CP = new ColorP(this.X0Y1_瞬膜, this.瞬膜CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_目CP = new ColorP(this.X0Y2_目, this.目CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_ハイライトCP = new ColorP(this.X0Y2_ハイライト, this.ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_瞬膜CP = new ColorP(this.X0Y2_瞬膜, this.瞬膜CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_目CP = new ColorP(this.X0Y3_目, this.目CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_ハイライトCP = new ColorP(this.X0Y3_ハイライト, this.ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_瞬膜CP = new ColorP(this.X0Y3_瞬膜, this.瞬膜CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_目CP = new ColorP(this.X0Y4_目, this.目CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_ハイライトCP = new ColorP(this.X0Y4_ハイライト, this.ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_瞬膜CP = new ColorP(this.X0Y4_瞬膜, this.瞬膜CD, CS$<>8__locals1.DisUnit, true);
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

		public bool 目_表示
		{
			get
			{
				return this.X0Y0_目.Dra;
			}
			set
			{
				this.X0Y0_目.Dra = value;
				this.X0Y1_目.Dra = value;
				this.X0Y2_目.Dra = value;
				this.X0Y3_目.Dra = value;
				this.X0Y4_目.Dra = value;
				this.X0Y0_目.Hit = value;
				this.X0Y1_目.Hit = value;
				this.X0Y2_目.Hit = value;
				this.X0Y3_目.Hit = value;
				this.X0Y4_目.Hit = value;
			}
		}

		public bool ハイライト_表示
		{
			get
			{
				return this.X0Y0_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_ハイライト.Dra = value;
				this.X0Y1_ハイライト.Dra = value;
				this.X0Y2_ハイライト.Dra = value;
				this.X0Y3_ハイライト.Dra = value;
				this.X0Y4_ハイライト.Dra = value;
				this.X0Y0_ハイライト.Hit = value;
				this.X0Y1_ハイライト.Hit = value;
				this.X0Y2_ハイライト.Hit = value;
				this.X0Y3_ハイライト.Hit = value;
				this.X0Y4_ハイライト.Hit = value;
			}
		}

		public bool 瞬膜_表示
		{
			get
			{
				return this.X0Y0_瞬膜.Dra;
			}
			set
			{
				this.X0Y0_瞬膜.Dra = value;
				this.X0Y1_瞬膜.Dra = value;
				this.X0Y2_瞬膜.Dra = value;
				this.X0Y3_瞬膜.Dra = value;
				this.X0Y4_瞬膜.Dra = value;
				this.X0Y0_瞬膜.Hit = value;
				this.X0Y1_瞬膜.Hit = value;
				this.X0Y2_瞬膜.Hit = value;
				this.X0Y3_瞬膜.Hit = value;
				this.X0Y4_瞬膜.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.目_表示;
			}
			set
			{
				this.目_表示 = value;
				this.ハイライト_表示 = value;
				this.瞬膜_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.目CD.不透明度;
			}
			set
			{
				this.目CD.不透明度 = value;
				this.ハイライトCD.不透明度 = value;
				this.瞬膜CD.不透明度 = value;
			}
		}

		public JointS 涙_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_目, 2);
			}
		}

		public override void 色更新()
		{
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_目CP.Update();
				this.X0Y0_ハイライトCP.Update();
				this.X0Y0_瞬膜CP.Update();
				return;
			case 1:
				this.X0Y1_目CP.Update();
				this.X0Y1_ハイライトCP.Update();
				this.X0Y1_瞬膜CP.Update();
				return;
			case 2:
				this.X0Y2_目CP.Update();
				this.X0Y2_ハイライトCP.Update();
				this.X0Y2_瞬膜CP.Update();
				return;
			case 3:
				this.X0Y3_目CP.Update();
				this.X0Y3_ハイライトCP.Update();
				this.X0Y3_瞬膜CP.Update();
				return;
			default:
				this.X0Y4_目CP.Update();
				this.X0Y4_ハイライトCP.Update();
				this.X0Y4_瞬膜CP.Update();
				return;
			}
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.目CD = new ColorD(ref Col.Black, ref 体配色.目左O);
			this.ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.瞬膜CD = new ColorD(ref Col.Black, ref 体配色.白部O);
		}

		public Par X0Y0_目;

		public Par X0Y0_ハイライト;

		public Par X0Y0_瞬膜;

		public Par X0Y1_目;

		public Par X0Y1_ハイライト;

		public Par X0Y1_瞬膜;

		public Par X0Y2_目;

		public Par X0Y2_ハイライト;

		public Par X0Y2_瞬膜;

		public Par X0Y3_目;

		public Par X0Y3_ハイライト;

		public Par X0Y3_瞬膜;

		public Par X0Y4_目;

		public Par X0Y4_ハイライト;

		public Par X0Y4_瞬膜;

		public ColorD 目CD;

		public ColorD ハイライトCD;

		public ColorD 瞬膜CD;

		public ColorP X0Y0_目CP;

		public ColorP X0Y0_ハイライトCP;

		public ColorP X0Y0_瞬膜CP;

		public ColorP X0Y1_目CP;

		public ColorP X0Y1_ハイライトCP;

		public ColorP X0Y1_瞬膜CP;

		public ColorP X0Y2_目CP;

		public ColorP X0Y2_ハイライトCP;

		public ColorP X0Y2_瞬膜CP;

		public ColorP X0Y3_目CP;

		public ColorP X0Y3_ハイライトCP;

		public ColorP X0Y3_瞬膜CP;

		public ColorP X0Y4_目CP;

		public ColorP X0Y4_ハイライトCP;

		public ColorP X0Y4_瞬膜CP;

		public Ele[] 涙_接続;
	}
}
