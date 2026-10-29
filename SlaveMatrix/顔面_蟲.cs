using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 顔面_蟲 : 顔面
	{
		public 顔面_蟲(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 顔面_蟲D e)
		{
			顔面_蟲.<>c__DisplayClass105_0 CS$<>8__locals1 = new 顔面_蟲.<>c__DisplayClass105_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.肢中["顔面"][2]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_面 = pars["面"].ToPar();
			Pars pars2 = pars["眼左"].ToPars();
			Pars pars3 = pars2["眼1"].ToPars();
			this.X0Y0_眼左_眼1_基 = pars3["基"].ToPar();
			this.X0Y0_眼左_眼1_眼 = pars3["眼"].ToPar();
			this.X0Y0_眼左_眼1_ハイライト = pars3["ハイライト"].ToPar();
			pars3 = pars2["眼2"].ToPars();
			this.X0Y0_眼左_眼2_基 = pars3["基"].ToPar();
			this.X0Y0_眼左_眼2_眼 = pars3["眼"].ToPar();
			this.X0Y0_眼左_眼2_ハイライト = pars3["ハイライト"].ToPar();
			pars3 = pars2["眼3"].ToPars();
			this.X0Y0_眼左_眼3_基 = pars3["基"].ToPar();
			this.X0Y0_眼左_眼3_眼 = pars3["眼"].ToPar();
			this.X0Y0_眼左_眼3_ハイライト = pars3["ハイライト"].ToPar();
			pars3 = pars2["眼4"].ToPars();
			this.X0Y0_眼左_眼4_基 = pars3["基"].ToPar();
			this.X0Y0_眼左_眼4_眼 = pars3["眼"].ToPar();
			this.X0Y0_眼左_眼4_ハイライト = pars3["ハイライト"].ToPar();
			pars3 = pars2["眼5"].ToPars();
			this.X0Y0_眼左_眼5_基 = pars3["基"].ToPar();
			this.X0Y0_眼左_眼5_眼 = pars3["眼"].ToPar();
			this.X0Y0_眼左_眼5_ハイライト = pars3["ハイライト"].ToPar();
			pars2 = pars["眼右"].ToPars();
			pars3 = pars2["眼1"].ToPars();
			this.X0Y0_眼右_眼1_基 = pars3["基"].ToPar();
			this.X0Y0_眼右_眼1_眼 = pars3["眼"].ToPar();
			this.X0Y0_眼右_眼1_ハイライト = pars3["ハイライト"].ToPar();
			pars3 = pars2["眼2"].ToPars();
			this.X0Y0_眼右_眼2_基 = pars3["基"].ToPar();
			this.X0Y0_眼右_眼2_眼 = pars3["眼"].ToPar();
			this.X0Y0_眼右_眼2_ハイライト = pars3["ハイライト"].ToPar();
			pars3 = pars2["眼3"].ToPars();
			this.X0Y0_眼右_眼3_基 = pars3["基"].ToPar();
			this.X0Y0_眼右_眼3_眼 = pars3["眼"].ToPar();
			this.X0Y0_眼右_眼3_ハイライト = pars3["ハイライト"].ToPar();
			pars3 = pars2["眼4"].ToPars();
			this.X0Y0_眼右_眼4_基 = pars3["基"].ToPar();
			this.X0Y0_眼右_眼4_眼 = pars3["眼"].ToPar();
			this.X0Y0_眼右_眼4_ハイライト = pars3["ハイライト"].ToPar();
			pars3 = pars2["眼5"].ToPars();
			this.X0Y0_眼右_眼5_基 = pars3["基"].ToPar();
			this.X0Y0_眼右_眼5_眼 = pars3["眼"].ToPar();
			this.X0Y0_眼右_眼5_ハイライト = pars3["ハイライト"].ToPar();
			pars2 = pars["角左"].ToPars();
			this.X0Y0_角左_角左1 = pars2["角左1"].ToPar();
			this.X0Y0_角左_角左2 = pars2["角左2"].ToPar();
			pars2 = pars["角右"].ToPars();
			this.X0Y0_角右_角右1 = pars2["角右1"].ToPar();
			this.X0Y0_角右_角右2 = pars2["角右2"].ToPar();
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
			this.面_表示 = e.面_表示;
			this.眼左_眼1_基_表示 = e.眼左_眼1_基_表示;
			this.眼左_眼1_眼_表示 = e.眼左_眼1_眼_表示;
			this.眼左_眼1_ハイライト_表示 = e.眼左_眼1_ハイライト_表示;
			this.眼左_眼2_基_表示 = e.眼左_眼2_基_表示;
			this.眼左_眼2_眼_表示 = e.眼左_眼2_眼_表示;
			this.眼左_眼2_ハイライト_表示 = e.眼左_眼2_ハイライト_表示;
			this.眼左_眼3_基_表示 = e.眼左_眼3_基_表示;
			this.眼左_眼3_眼_表示 = e.眼左_眼3_眼_表示;
			this.眼左_眼3_ハイライト_表示 = e.眼左_眼3_ハイライト_表示;
			this.眼左_眼4_基_表示 = e.眼左_眼4_基_表示;
			this.眼左_眼4_眼_表示 = e.眼左_眼4_眼_表示;
			this.眼左_眼4_ハイライト_表示 = e.眼左_眼4_ハイライト_表示;
			this.眼左_眼5_基_表示 = e.眼左_眼5_基_表示;
			this.眼左_眼5_眼_表示 = e.眼左_眼5_眼_表示;
			this.眼左_眼5_ハイライト_表示 = e.眼左_眼5_ハイライト_表示;
			this.眼右_眼1_基_表示 = e.眼右_眼1_基_表示;
			this.眼右_眼1_眼_表示 = e.眼右_眼1_眼_表示;
			this.眼右_眼1_ハイライト_表示 = e.眼右_眼1_ハイライト_表示;
			this.眼右_眼2_基_表示 = e.眼右_眼2_基_表示;
			this.眼右_眼2_眼_表示 = e.眼右_眼2_眼_表示;
			this.眼右_眼2_ハイライト_表示 = e.眼右_眼2_ハイライト_表示;
			this.眼右_眼3_基_表示 = e.眼右_眼3_基_表示;
			this.眼右_眼3_眼_表示 = e.眼右_眼3_眼_表示;
			this.眼右_眼3_ハイライト_表示 = e.眼右_眼3_ハイライト_表示;
			this.眼右_眼4_基_表示 = e.眼右_眼4_基_表示;
			this.眼右_眼4_眼_表示 = e.眼右_眼4_眼_表示;
			this.眼右_眼4_ハイライト_表示 = e.眼右_眼4_ハイライト_表示;
			this.眼右_眼5_基_表示 = e.眼右_眼5_基_表示;
			this.眼右_眼5_眼_表示 = e.眼右_眼5_眼_表示;
			this.眼右_眼5_ハイライト_表示 = e.眼右_眼5_ハイライト_表示;
			this.角左_角左1_表示 = e.角左_角左1_表示;
			this.角左_角左2_表示 = e.角左_角左2_表示;
			this.角右_角右1_表示 = e.角右_角右1_表示;
			this.角右_角右2_表示 = e.角右_角右2_表示;
			base.展開0 = e.展開0;
			this.触覚部眼表示 = e.触覚部眼表示;
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
					f.接続情報 = 接続情報.顔面_蟲_触覚左_接続;
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
					f.接続情報 = 接続情報.顔面_蟲_触覚右_接続;
					f.接続(CS$<>8__locals1.<>4__this.触覚右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_面CP = new ColorP(this.X0Y0_面, this.面CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼左_眼1_基CP = new ColorP(this.X0Y0_眼左_眼1_基, this.眼左_眼1_基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼左_眼1_眼CP = new ColorP(this.X0Y0_眼左_眼1_眼, this.眼左_眼1_眼CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼左_眼1_ハイライトCP = new ColorP(this.X0Y0_眼左_眼1_ハイライト, this.眼左_眼1_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼左_眼2_基CP = new ColorP(this.X0Y0_眼左_眼2_基, this.眼左_眼2_基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼左_眼2_眼CP = new ColorP(this.X0Y0_眼左_眼2_眼, this.眼左_眼2_眼CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼左_眼2_ハイライトCP = new ColorP(this.X0Y0_眼左_眼2_ハイライト, this.眼左_眼2_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼左_眼3_基CP = new ColorP(this.X0Y0_眼左_眼3_基, this.眼左_眼3_基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼左_眼3_眼CP = new ColorP(this.X0Y0_眼左_眼3_眼, this.眼左_眼3_眼CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼左_眼3_ハイライトCP = new ColorP(this.X0Y0_眼左_眼3_ハイライト, this.眼左_眼3_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼左_眼4_基CP = new ColorP(this.X0Y0_眼左_眼4_基, this.眼左_眼4_基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼左_眼4_眼CP = new ColorP(this.X0Y0_眼左_眼4_眼, this.眼左_眼4_眼CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼左_眼4_ハイライトCP = new ColorP(this.X0Y0_眼左_眼4_ハイライト, this.眼左_眼4_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼左_眼5_基CP = new ColorP(this.X0Y0_眼左_眼5_基, this.眼左_眼5_基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼左_眼5_眼CP = new ColorP(this.X0Y0_眼左_眼5_眼, this.眼左_眼5_眼CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼左_眼5_ハイライトCP = new ColorP(this.X0Y0_眼左_眼5_ハイライト, this.眼左_眼5_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼右_眼1_基CP = new ColorP(this.X0Y0_眼右_眼1_基, this.眼右_眼1_基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼右_眼1_眼CP = new ColorP(this.X0Y0_眼右_眼1_眼, this.眼右_眼1_眼CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼右_眼1_ハイライトCP = new ColorP(this.X0Y0_眼右_眼1_ハイライト, this.眼右_眼1_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼右_眼2_基CP = new ColorP(this.X0Y0_眼右_眼2_基, this.眼右_眼2_基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼右_眼2_眼CP = new ColorP(this.X0Y0_眼右_眼2_眼, this.眼右_眼2_眼CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼右_眼2_ハイライトCP = new ColorP(this.X0Y0_眼右_眼2_ハイライト, this.眼右_眼2_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼右_眼3_基CP = new ColorP(this.X0Y0_眼右_眼3_基, this.眼右_眼3_基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼右_眼3_眼CP = new ColorP(this.X0Y0_眼右_眼3_眼, this.眼右_眼3_眼CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼右_眼3_ハイライトCP = new ColorP(this.X0Y0_眼右_眼3_ハイライト, this.眼右_眼3_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼右_眼4_基CP = new ColorP(this.X0Y0_眼右_眼4_基, this.眼右_眼4_基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼右_眼4_眼CP = new ColorP(this.X0Y0_眼右_眼4_眼, this.眼右_眼4_眼CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼右_眼4_ハイライトCP = new ColorP(this.X0Y0_眼右_眼4_ハイライト, this.眼右_眼4_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼右_眼5_基CP = new ColorP(this.X0Y0_眼右_眼5_基, this.眼右_眼5_基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼右_眼5_眼CP = new ColorP(this.X0Y0_眼右_眼5_眼, this.眼右_眼5_眼CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_眼右_眼5_ハイライトCP = new ColorP(this.X0Y0_眼右_眼5_ハイライト, this.眼右_眼5_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_角左_角左1CP = new ColorP(this.X0Y0_角左_角左1, this.角左_角左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_角左_角左2CP = new ColorP(this.X0Y0_角左_角左2, this.角左_角左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_角右_角右1CP = new ColorP(this.X0Y0_角右_角右1, this.角右_角右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_角右_角右2CP = new ColorP(this.X0Y0_角右_角右2, this.角右_角右2CD, CS$<>8__locals1.DisUnit, true);
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

		public bool 面_表示
		{
			get
			{
				return this.X0Y0_面.Dra;
			}
			set
			{
				this.X0Y0_面.Dra = value;
				this.X0Y0_面.Hit = value;
			}
		}

		public bool 眼左_眼1_基_表示
		{
			get
			{
				return this.X0Y0_眼左_眼1_基.Dra;
			}
			set
			{
				this.X0Y0_眼左_眼1_基.Dra = value;
				this.X0Y0_眼左_眼1_基.Hit = value;
			}
		}

		public bool 眼左_眼1_眼_表示
		{
			get
			{
				return this.X0Y0_眼左_眼1_眼.Dra;
			}
			set
			{
				this.X0Y0_眼左_眼1_眼.Dra = value;
				this.X0Y0_眼左_眼1_眼.Hit = value;
			}
		}

		public bool 眼左_眼1_ハイライト_表示
		{
			get
			{
				return this.X0Y0_眼左_眼1_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_眼左_眼1_ハイライト.Dra = value;
				this.X0Y0_眼左_眼1_ハイライト.Hit = value;
			}
		}

		public bool 眼左_眼2_基_表示
		{
			get
			{
				return this.X0Y0_眼左_眼2_基.Dra;
			}
			set
			{
				this.X0Y0_眼左_眼2_基.Dra = value;
				this.X0Y0_眼左_眼2_基.Hit = value;
			}
		}

		public bool 眼左_眼2_眼_表示
		{
			get
			{
				return this.X0Y0_眼左_眼2_眼.Dra;
			}
			set
			{
				this.X0Y0_眼左_眼2_眼.Dra = value;
				this.X0Y0_眼左_眼2_眼.Hit = value;
			}
		}

		public bool 眼左_眼2_ハイライト_表示
		{
			get
			{
				return this.X0Y0_眼左_眼2_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_眼左_眼2_ハイライト.Dra = value;
				this.X0Y0_眼左_眼2_ハイライト.Hit = value;
			}
		}

		public bool 眼左_眼3_基_表示
		{
			get
			{
				return this.X0Y0_眼左_眼3_基.Dra;
			}
			set
			{
				this.X0Y0_眼左_眼3_基.Dra = value;
				this.X0Y0_眼左_眼3_基.Hit = value;
			}
		}

		public bool 眼左_眼3_眼_表示
		{
			get
			{
				return this.X0Y0_眼左_眼3_眼.Dra;
			}
			set
			{
				this.X0Y0_眼左_眼3_眼.Dra = value;
				this.X0Y0_眼左_眼3_眼.Hit = value;
			}
		}

		public bool 眼左_眼3_ハイライト_表示
		{
			get
			{
				return this.X0Y0_眼左_眼3_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_眼左_眼3_ハイライト.Dra = value;
				this.X0Y0_眼左_眼3_ハイライト.Hit = value;
			}
		}

		public bool 眼左_眼4_基_表示
		{
			get
			{
				return this.X0Y0_眼左_眼4_基.Dra;
			}
			set
			{
				this.X0Y0_眼左_眼4_基.Dra = value;
				this.X0Y0_眼左_眼4_基.Hit = value;
			}
		}

		public bool 眼左_眼4_眼_表示
		{
			get
			{
				return this.X0Y0_眼左_眼4_眼.Dra;
			}
			set
			{
				this.X0Y0_眼左_眼4_眼.Dra = value;
				this.X0Y0_眼左_眼4_眼.Hit = value;
			}
		}

		public bool 眼左_眼4_ハイライト_表示
		{
			get
			{
				return this.X0Y0_眼左_眼4_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_眼左_眼4_ハイライト.Dra = value;
				this.X0Y0_眼左_眼4_ハイライト.Hit = value;
			}
		}

		public bool 眼左_眼5_基_表示
		{
			get
			{
				return this.X0Y0_眼左_眼5_基.Dra;
			}
			set
			{
				this.X0Y0_眼左_眼5_基.Dra = value;
				this.X0Y0_眼左_眼5_基.Hit = value;
			}
		}

		public bool 眼左_眼5_眼_表示
		{
			get
			{
				return this.X0Y0_眼左_眼5_眼.Dra;
			}
			set
			{
				this.X0Y0_眼左_眼5_眼.Dra = value;
				this.X0Y0_眼左_眼5_眼.Hit = value;
			}
		}

		public bool 眼左_眼5_ハイライト_表示
		{
			get
			{
				return this.X0Y0_眼左_眼5_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_眼左_眼5_ハイライト.Dra = value;
				this.X0Y0_眼左_眼5_ハイライト.Hit = value;
			}
		}

		public bool 眼右_眼1_基_表示
		{
			get
			{
				return this.X0Y0_眼右_眼1_基.Dra;
			}
			set
			{
				this.X0Y0_眼右_眼1_基.Dra = value;
				this.X0Y0_眼右_眼1_基.Hit = value;
			}
		}

		public bool 眼右_眼1_眼_表示
		{
			get
			{
				return this.X0Y0_眼右_眼1_眼.Dra;
			}
			set
			{
				this.X0Y0_眼右_眼1_眼.Dra = value;
				this.X0Y0_眼右_眼1_眼.Hit = value;
			}
		}

		public bool 眼右_眼1_ハイライト_表示
		{
			get
			{
				return this.X0Y0_眼右_眼1_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_眼右_眼1_ハイライト.Dra = value;
				this.X0Y0_眼右_眼1_ハイライト.Hit = value;
			}
		}

		public bool 眼右_眼2_基_表示
		{
			get
			{
				return this.X0Y0_眼右_眼2_基.Dra;
			}
			set
			{
				this.X0Y0_眼右_眼2_基.Dra = value;
				this.X0Y0_眼右_眼2_基.Hit = value;
			}
		}

		public bool 眼右_眼2_眼_表示
		{
			get
			{
				return this.X0Y0_眼右_眼2_眼.Dra;
			}
			set
			{
				this.X0Y0_眼右_眼2_眼.Dra = value;
				this.X0Y0_眼右_眼2_眼.Hit = value;
			}
		}

		public bool 眼右_眼2_ハイライト_表示
		{
			get
			{
				return this.X0Y0_眼右_眼2_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_眼右_眼2_ハイライト.Dra = value;
				this.X0Y0_眼右_眼2_ハイライト.Hit = value;
			}
		}

		public bool 眼右_眼3_基_表示
		{
			get
			{
				return this.X0Y0_眼右_眼3_基.Dra;
			}
			set
			{
				this.X0Y0_眼右_眼3_基.Dra = value;
				this.X0Y0_眼右_眼3_基.Hit = value;
			}
		}

		public bool 眼右_眼3_眼_表示
		{
			get
			{
				return this.X0Y0_眼右_眼3_眼.Dra;
			}
			set
			{
				this.X0Y0_眼右_眼3_眼.Dra = value;
				this.X0Y0_眼右_眼3_眼.Hit = value;
			}
		}

		public bool 眼右_眼3_ハイライト_表示
		{
			get
			{
				return this.X0Y0_眼右_眼3_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_眼右_眼3_ハイライト.Dra = value;
				this.X0Y0_眼右_眼3_ハイライト.Hit = value;
			}
		}

		public bool 眼右_眼4_基_表示
		{
			get
			{
				return this.X0Y0_眼右_眼4_基.Dra;
			}
			set
			{
				this.X0Y0_眼右_眼4_基.Dra = value;
				this.X0Y0_眼右_眼4_基.Hit = value;
			}
		}

		public bool 眼右_眼4_眼_表示
		{
			get
			{
				return this.X0Y0_眼右_眼4_眼.Dra;
			}
			set
			{
				this.X0Y0_眼右_眼4_眼.Dra = value;
				this.X0Y0_眼右_眼4_眼.Hit = value;
			}
		}

		public bool 眼右_眼4_ハイライト_表示
		{
			get
			{
				return this.X0Y0_眼右_眼4_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_眼右_眼4_ハイライト.Dra = value;
				this.X0Y0_眼右_眼4_ハイライト.Hit = value;
			}
		}

		public bool 眼右_眼5_基_表示
		{
			get
			{
				return this.X0Y0_眼右_眼5_基.Dra;
			}
			set
			{
				this.X0Y0_眼右_眼5_基.Dra = value;
				this.X0Y0_眼右_眼5_基.Hit = value;
			}
		}

		public bool 眼右_眼5_眼_表示
		{
			get
			{
				return this.X0Y0_眼右_眼5_眼.Dra;
			}
			set
			{
				this.X0Y0_眼右_眼5_眼.Dra = value;
				this.X0Y0_眼右_眼5_眼.Hit = value;
			}
		}

		public bool 眼右_眼5_ハイライト_表示
		{
			get
			{
				return this.X0Y0_眼右_眼5_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_眼右_眼5_ハイライト.Dra = value;
				this.X0Y0_眼右_眼5_ハイライト.Hit = value;
			}
		}

		public bool 角左_角左1_表示
		{
			get
			{
				return this.X0Y0_角左_角左1.Dra;
			}
			set
			{
				this.X0Y0_角左_角左1.Dra = value;
				this.X0Y0_角左_角左1.Hit = value;
			}
		}

		public bool 角左_角左2_表示
		{
			get
			{
				return this.X0Y0_角左_角左2.Dra;
			}
			set
			{
				this.X0Y0_角左_角左2.Dra = value;
				this.X0Y0_角左_角左2.Hit = value;
			}
		}

		public bool 角右_角右1_表示
		{
			get
			{
				return this.X0Y0_角右_角右1.Dra;
			}
			set
			{
				this.X0Y0_角右_角右1.Dra = value;
				this.X0Y0_角右_角右1.Hit = value;
			}
		}

		public bool 角右_角右2_表示
		{
			get
			{
				return this.X0Y0_角右_角右2.Dra;
			}
			set
			{
				this.X0Y0_角右_角右2.Dra = value;
				this.X0Y0_角右_角右2.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.面_表示;
			}
			set
			{
				this.面_表示 = value;
				this.眼左_眼1_基_表示 = value;
				this.眼左_眼1_眼_表示 = value;
				this.眼左_眼1_ハイライト_表示 = value;
				this.眼左_眼2_基_表示 = value;
				this.眼左_眼2_眼_表示 = value;
				this.眼左_眼2_ハイライト_表示 = value;
				this.眼左_眼3_基_表示 = value;
				this.眼左_眼3_眼_表示 = value;
				this.眼左_眼3_ハイライト_表示 = value;
				this.眼左_眼4_基_表示 = value;
				this.眼左_眼4_眼_表示 = value;
				this.眼左_眼4_ハイライト_表示 = value;
				this.眼左_眼5_基_表示 = value;
				this.眼左_眼5_眼_表示 = value;
				this.眼左_眼5_ハイライト_表示 = value;
				this.眼右_眼1_基_表示 = value;
				this.眼右_眼1_眼_表示 = value;
				this.眼右_眼1_ハイライト_表示 = value;
				this.眼右_眼2_基_表示 = value;
				this.眼右_眼2_眼_表示 = value;
				this.眼右_眼2_ハイライト_表示 = value;
				this.眼右_眼3_基_表示 = value;
				this.眼右_眼3_眼_表示 = value;
				this.眼右_眼3_ハイライト_表示 = value;
				this.眼右_眼4_基_表示 = value;
				this.眼右_眼4_眼_表示 = value;
				this.眼右_眼4_ハイライト_表示 = value;
				this.眼右_眼5_基_表示 = value;
				this.眼右_眼5_眼_表示 = value;
				this.眼右_眼5_ハイライト_表示 = value;
				this.角左_角左1_表示 = value;
				this.角左_角左2_表示 = value;
				this.角右_角右1_表示 = value;
				this.角右_角右2_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.面CD.不透明度;
			}
			set
			{
				this.面CD.不透明度 = value;
				this.眼左_眼1_基CD.不透明度 = value;
				this.眼左_眼1_眼CD.不透明度 = value;
				this.眼左_眼1_ハイライトCD.不透明度 = value;
				this.眼左_眼2_基CD.不透明度 = value;
				this.眼左_眼2_眼CD.不透明度 = value;
				this.眼左_眼2_ハイライトCD.不透明度 = value;
				this.眼左_眼3_基CD.不透明度 = value;
				this.眼左_眼3_眼CD.不透明度 = value;
				this.眼左_眼3_ハイライトCD.不透明度 = value;
				this.眼左_眼4_基CD.不透明度 = value;
				this.眼左_眼4_眼CD.不透明度 = value;
				this.眼左_眼4_ハイライトCD.不透明度 = value;
				this.眼左_眼5_基CD.不透明度 = value;
				this.眼左_眼5_眼CD.不透明度 = value;
				this.眼左_眼5_ハイライトCD.不透明度 = value;
				this.眼右_眼1_基CD.不透明度 = value;
				this.眼右_眼1_眼CD.不透明度 = value;
				this.眼右_眼1_ハイライトCD.不透明度 = value;
				this.眼右_眼2_基CD.不透明度 = value;
				this.眼右_眼2_眼CD.不透明度 = value;
				this.眼右_眼2_ハイライトCD.不透明度 = value;
				this.眼右_眼3_基CD.不透明度 = value;
				this.眼右_眼3_眼CD.不透明度 = value;
				this.眼右_眼3_ハイライトCD.不透明度 = value;
				this.眼右_眼4_基CD.不透明度 = value;
				this.眼右_眼4_眼CD.不透明度 = value;
				this.眼右_眼4_ハイライトCD.不透明度 = value;
				this.眼右_眼5_基CD.不透明度 = value;
				this.眼右_眼5_眼CD.不透明度 = value;
				this.眼右_眼5_ハイライトCD.不透明度 = value;
				this.角左_角左1CD.不透明度 = value;
				this.角左_角左2CD.不透明度 = value;
				this.角右_角右1CD.不透明度 = value;
				this.角右_角右2CD.不透明度 = value;
			}
		}

		public bool 触覚部眼表示
		{
			get
			{
				return this.眼左_眼1_基_表示;
			}
			set
			{
				this.眼左_眼1_基_表示 = value;
				this.眼左_眼1_眼_表示 = value;
				this.眼左_眼1_ハイライト_表示 = value;
				this.眼右_眼1_基_表示 = value;
				this.眼右_眼1_眼_表示 = value;
				this.眼右_眼1_ハイライト_表示 = value;
			}
		}

		public JointS 触覚左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_面, 0);
			}
		}

		public JointS 触覚右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_面, 1);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_面CP.Update();
			this.X0Y0_眼左_眼1_基CP.Update();
			this.X0Y0_眼左_眼1_眼CP.Update();
			this.X0Y0_眼左_眼1_ハイライトCP.Update();
			this.X0Y0_眼左_眼2_基CP.Update();
			this.X0Y0_眼左_眼2_眼CP.Update();
			this.X0Y0_眼左_眼2_ハイライトCP.Update();
			this.X0Y0_眼左_眼3_基CP.Update();
			this.X0Y0_眼左_眼3_眼CP.Update();
			this.X0Y0_眼左_眼3_ハイライトCP.Update();
			this.X0Y0_眼左_眼4_基CP.Update();
			this.X0Y0_眼左_眼4_眼CP.Update();
			this.X0Y0_眼左_眼4_ハイライトCP.Update();
			this.X0Y0_眼左_眼5_基CP.Update();
			this.X0Y0_眼左_眼5_眼CP.Update();
			this.X0Y0_眼左_眼5_ハイライトCP.Update();
			this.X0Y0_眼右_眼1_基CP.Update();
			this.X0Y0_眼右_眼1_眼CP.Update();
			this.X0Y0_眼右_眼1_ハイライトCP.Update();
			this.X0Y0_眼右_眼2_基CP.Update();
			this.X0Y0_眼右_眼2_眼CP.Update();
			this.X0Y0_眼右_眼2_ハイライトCP.Update();
			this.X0Y0_眼右_眼3_基CP.Update();
			this.X0Y0_眼右_眼3_眼CP.Update();
			this.X0Y0_眼右_眼3_ハイライトCP.Update();
			this.X0Y0_眼右_眼4_基CP.Update();
			this.X0Y0_眼右_眼4_眼CP.Update();
			this.X0Y0_眼右_眼4_ハイライトCP.Update();
			this.X0Y0_眼右_眼5_基CP.Update();
			this.X0Y0_眼右_眼5_眼CP.Update();
			this.X0Y0_眼右_眼5_ハイライトCP.Update();
			this.X0Y0_角左_角左1CP.Update();
			this.X0Y0_角左_角左2CP.Update();
			this.X0Y0_角右_角右1CP.Update();
			this.X0Y0_角右_角右2CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.面CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.眼左_眼1_基CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.眼左_眼1_眼CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.眼左_眼1_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.眼左_眼2_基CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.眼左_眼2_眼CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.眼左_眼2_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.眼左_眼3_基CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.眼左_眼3_眼CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.眼左_眼3_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.眼左_眼4_基CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.眼左_眼4_眼CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.眼左_眼4_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.眼左_眼5_基CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.眼左_眼5_眼CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.眼左_眼5_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.眼右_眼1_基CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.眼右_眼1_眼CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.眼右_眼1_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.眼右_眼2_基CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.眼右_眼2_眼CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.眼右_眼2_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.眼右_眼3_基CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.眼右_眼3_眼CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.眼右_眼3_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.眼右_眼4_基CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.眼右_眼4_眼CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.眼右_眼4_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.眼右_眼5_基CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.眼右_眼5_眼CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.眼右_眼5_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.角左_角左1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.角左_角左2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.角右_角右1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.角右_角右2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
		}

		public Par X0Y0_面;

		public Par X0Y0_眼左_眼1_基;

		public Par X0Y0_眼左_眼1_眼;

		public Par X0Y0_眼左_眼1_ハイライト;

		public Par X0Y0_眼左_眼2_基;

		public Par X0Y0_眼左_眼2_眼;

		public Par X0Y0_眼左_眼2_ハイライト;

		public Par X0Y0_眼左_眼3_基;

		public Par X0Y0_眼左_眼3_眼;

		public Par X0Y0_眼左_眼3_ハイライト;

		public Par X0Y0_眼左_眼4_基;

		public Par X0Y0_眼左_眼4_眼;

		public Par X0Y0_眼左_眼4_ハイライト;

		public Par X0Y0_眼左_眼5_基;

		public Par X0Y0_眼左_眼5_眼;

		public Par X0Y0_眼左_眼5_ハイライト;

		public Par X0Y0_眼右_眼1_基;

		public Par X0Y0_眼右_眼1_眼;

		public Par X0Y0_眼右_眼1_ハイライト;

		public Par X0Y0_眼右_眼2_基;

		public Par X0Y0_眼右_眼2_眼;

		public Par X0Y0_眼右_眼2_ハイライト;

		public Par X0Y0_眼右_眼3_基;

		public Par X0Y0_眼右_眼3_眼;

		public Par X0Y0_眼右_眼3_ハイライト;

		public Par X0Y0_眼右_眼4_基;

		public Par X0Y0_眼右_眼4_眼;

		public Par X0Y0_眼右_眼4_ハイライト;

		public Par X0Y0_眼右_眼5_基;

		public Par X0Y0_眼右_眼5_眼;

		public Par X0Y0_眼右_眼5_ハイライト;

		public Par X0Y0_角左_角左1;

		public Par X0Y0_角左_角左2;

		public Par X0Y0_角右_角右1;

		public Par X0Y0_角右_角右2;

		public ColorD 面CD;

		public ColorD 眼左_眼1_基CD;

		public ColorD 眼左_眼1_眼CD;

		public ColorD 眼左_眼1_ハイライトCD;

		public ColorD 眼左_眼2_基CD;

		public ColorD 眼左_眼2_眼CD;

		public ColorD 眼左_眼2_ハイライトCD;

		public ColorD 眼左_眼3_基CD;

		public ColorD 眼左_眼3_眼CD;

		public ColorD 眼左_眼3_ハイライトCD;

		public ColorD 眼左_眼4_基CD;

		public ColorD 眼左_眼4_眼CD;

		public ColorD 眼左_眼4_ハイライトCD;

		public ColorD 眼左_眼5_基CD;

		public ColorD 眼左_眼5_眼CD;

		public ColorD 眼左_眼5_ハイライトCD;

		public ColorD 眼右_眼1_基CD;

		public ColorD 眼右_眼1_眼CD;

		public ColorD 眼右_眼1_ハイライトCD;

		public ColorD 眼右_眼2_基CD;

		public ColorD 眼右_眼2_眼CD;

		public ColorD 眼右_眼2_ハイライトCD;

		public ColorD 眼右_眼3_基CD;

		public ColorD 眼右_眼3_眼CD;

		public ColorD 眼右_眼3_ハイライトCD;

		public ColorD 眼右_眼4_基CD;

		public ColorD 眼右_眼4_眼CD;

		public ColorD 眼右_眼4_ハイライトCD;

		public ColorD 眼右_眼5_基CD;

		public ColorD 眼右_眼5_眼CD;

		public ColorD 眼右_眼5_ハイライトCD;

		public ColorD 角左_角左1CD;

		public ColorD 角左_角左2CD;

		public ColorD 角右_角右1CD;

		public ColorD 角右_角右2CD;

		public ColorP X0Y0_面CP;

		public ColorP X0Y0_眼左_眼1_基CP;

		public ColorP X0Y0_眼左_眼1_眼CP;

		public ColorP X0Y0_眼左_眼1_ハイライトCP;

		public ColorP X0Y0_眼左_眼2_基CP;

		public ColorP X0Y0_眼左_眼2_眼CP;

		public ColorP X0Y0_眼左_眼2_ハイライトCP;

		public ColorP X0Y0_眼左_眼3_基CP;

		public ColorP X0Y0_眼左_眼3_眼CP;

		public ColorP X0Y0_眼左_眼3_ハイライトCP;

		public ColorP X0Y0_眼左_眼4_基CP;

		public ColorP X0Y0_眼左_眼4_眼CP;

		public ColorP X0Y0_眼左_眼4_ハイライトCP;

		public ColorP X0Y0_眼左_眼5_基CP;

		public ColorP X0Y0_眼左_眼5_眼CP;

		public ColorP X0Y0_眼左_眼5_ハイライトCP;

		public ColorP X0Y0_眼右_眼1_基CP;

		public ColorP X0Y0_眼右_眼1_眼CP;

		public ColorP X0Y0_眼右_眼1_ハイライトCP;

		public ColorP X0Y0_眼右_眼2_基CP;

		public ColorP X0Y0_眼右_眼2_眼CP;

		public ColorP X0Y0_眼右_眼2_ハイライトCP;

		public ColorP X0Y0_眼右_眼3_基CP;

		public ColorP X0Y0_眼右_眼3_眼CP;

		public ColorP X0Y0_眼右_眼3_ハイライトCP;

		public ColorP X0Y0_眼右_眼4_基CP;

		public ColorP X0Y0_眼右_眼4_眼CP;

		public ColorP X0Y0_眼右_眼4_ハイライトCP;

		public ColorP X0Y0_眼右_眼5_基CP;

		public ColorP X0Y0_眼右_眼5_眼CP;

		public ColorP X0Y0_眼右_眼5_ハイライトCP;

		public ColorP X0Y0_角左_角左1CP;

		public ColorP X0Y0_角左_角左2CP;

		public ColorP X0Y0_角右_角右1CP;

		public ColorP X0Y0_角右_角右2CP;
	}
}
