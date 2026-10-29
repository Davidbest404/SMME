using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 下腕_蹄 : 獣下腕
	{
		public 下腕_蹄(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 下腕_蹄D e)
		{
			下腕_蹄.<>c__DisplayClass9_0 CS$<>8__locals1 = new 下腕_蹄.<>c__DisplayClass9_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.腕左["四足下腕"][1]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_下腕 = pars["下腕"].ToPar();
			Pars pars2 = pars["筋肉"].ToPars();
			this.X0Y0_筋肉_筋肉下 = pars2["筋肉下"].ToPar();
			this.X0Y0_筋肉_筋肉上 = pars2["筋肉上"].ToPar();
			this.Xasix = false;
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
			this.下腕_表示 = e.下腕_表示;
			this.筋肉_筋肉下_表示 = e.筋肉_筋肉下_表示;
			this.筋肉_筋肉上_表示 = e.筋肉_筋肉上_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.手_接続.Count > 0)
			{
				Ele f;
				this.手_接続 = e.手_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.下腕_蹄_手_接続;
					f.接続(CS$<>8__locals1.<>4__this.手_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_下腕CP = new ColorP(this.X0Y0_下腕, this.下腕CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_筋肉_筋肉下CP = new ColorP(this.X0Y0_筋肉_筋肉下, this.筋肉_筋肉下CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋肉上CP = new ColorP(this.X0Y0_筋肉_筋肉上, this.筋肉_筋肉上CD, CS$<>8__locals1.DisUnit, false);
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
				this.筋肉_筋肉下_表示 = this.筋肉_;
				this.筋肉_筋肉上_表示 = this.筋肉_;
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

		public bool 下腕_表示
		{
			get
			{
				return this.X0Y0_下腕.Dra;
			}
			set
			{
				this.X0Y0_下腕.Dra = value;
				this.X0Y0_下腕.Hit = value;
			}
		}

		public bool 筋肉_筋肉下_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋肉下.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋肉下.Dra = value;
				this.X0Y0_筋肉_筋肉下.Hit = value;
			}
		}

		public bool 筋肉_筋肉上_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋肉上.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋肉上.Dra = value;
				this.X0Y0_筋肉_筋肉上.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.下腕_表示;
			}
			set
			{
				this.下腕_表示 = value;
				this.筋肉_筋肉下_表示 = value;
				this.筋肉_筋肉上_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.下腕CD.不透明度;
			}
			set
			{
				this.下腕CD.不透明度 = value;
				this.筋肉_筋肉下CD.不透明度 = value;
				this.筋肉_筋肉上CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_下腕.AngleBase = num * 160.0;
			this.本体.JoinPAall();
		}

		public override bool 肘部_外線
		{
			get
			{
				return this.X0Y0_下腕.OP[this.右 ? 4 : 0].Outline;
			}
			set
			{
				this.X0Y0_下腕.OP[this.右 ? 4 : 0].Outline = value;
			}
		}

		public JointS 手_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_下腕, 2);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_下腕CP.Update();
			this.X0Y0_筋肉_筋肉下CP.Update();
			this.X0Y0_筋肉_筋肉上CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.下腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
		}

		public Par X0Y0_下腕;

		public Par X0Y0_筋肉_筋肉下;

		public Par X0Y0_筋肉_筋肉上;

		public ColorD 下腕CD;

		public ColorD 筋肉_筋肉下CD;

		public ColorD 筋肉_筋肉上CD;

		public ColorP X0Y0_下腕CP;

		public ColorP X0Y0_筋肉_筋肉下CP;

		public ColorP X0Y0_筋肉_筋肉上CP;
	}
}
