using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 顔面_虫 : 顔面
	{
		public 顔面_虫(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 顔面_虫D e)
		{
			顔面_虫.<>c__DisplayClass78_0 CS$<>8__locals1 = new 顔面_虫.<>c__DisplayClass78_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.肢中["顔面"][1]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_面基 = pars["面基"].ToPar();
			Pars pars2 = pars["複眼左"].ToPars();
			this.X0Y0_複眼左_複眼1 = pars2["複眼1"].ToPar();
			this.X0Y0_複眼左_複眼2 = pars2["複眼2"].ToPar();
			this.X0Y0_複眼左_ハイライト = pars2["ハイライト"].ToPar();
			pars2 = pars["複眼右"].ToPars();
			this.X0Y0_複眼右_複眼1 = pars2["複眼1"].ToPar();
			this.X0Y0_複眼右_複眼2 = pars2["複眼2"].ToPar();
			this.X0Y0_複眼右_ハイライト = pars2["ハイライト"].ToPar();
			pars2 = pars["面下"].ToPars();
			this.X0Y0_面下_面 = pars2["面"].ToPar();
			this.X0Y0_面下_器官左上 = pars2["器官左上"].ToPar();
			this.X0Y0_面下_器官左下 = pars2["器官左下"].ToPar();
			this.X0Y0_面下_器官右上 = pars2["器官右上"].ToPar();
			this.X0Y0_面下_器官右下 = pars2["器官右下"].ToPar();
			this.X0Y0_面上 = pars["面上"].ToPar();
			pars2 = pars["付根左"].ToPars();
			this.X0Y0_付根左_付根1 = pars2["付根1"].ToPar();
			this.X0Y0_付根左_付根2 = pars2["付根2"].ToPar();
			pars2 = pars["付根右"].ToPars();
			this.X0Y0_付根右_付根1 = pars2["付根1"].ToPar();
			this.X0Y0_付根右_付根2 = pars2["付根2"].ToPar();
			pars2 = pars["単眼"].ToPars();
			Pars pars3 = pars2["眼中"].ToPars();
			this.X0Y0_単眼_眼中_基 = pars3["基"].ToPar();
			this.X0Y0_単眼_眼中_眼 = pars3["眼"].ToPar();
			this.X0Y0_単眼_眼中_ハイライト = pars3["ハイライト"].ToPar();
			pars3 = pars2["眼左"].ToPars();
			this.X0Y0_単眼_眼左_基 = pars3["基"].ToPar();
			this.X0Y0_単眼_眼左_眼 = pars3["眼"].ToPar();
			this.X0Y0_単眼_眼左_ハイライト = pars3["ハイライト"].ToPar();
			pars3 = pars2["眼右"].ToPars();
			this.X0Y0_単眼_眼右_基 = pars3["基"].ToPar();
			this.X0Y0_単眼_眼右_眼 = pars3["眼"].ToPar();
			this.X0Y0_単眼_眼右_ハイライト = pars3["ハイライト"].ToPar();
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
			this.面基_表示 = e.面基_表示;
			this.複眼左_複眼1_表示 = e.複眼左_複眼1_表示;
			this.複眼左_複眼2_表示 = e.複眼左_複眼2_表示;
			this.複眼左_ハイライト_表示 = e.複眼左_ハイライト_表示;
			this.複眼右_複眼1_表示 = e.複眼右_複眼1_表示;
			this.複眼右_複眼2_表示 = e.複眼右_複眼2_表示;
			this.複眼右_ハイライト_表示 = e.複眼右_ハイライト_表示;
			this.面下_面_表示 = e.面下_面_表示;
			this.面下_器官左上_表示 = e.面下_器官左上_表示;
			this.面下_器官左下_表示 = e.面下_器官左下_表示;
			this.面下_器官右上_表示 = e.面下_器官右上_表示;
			this.面下_器官右下_表示 = e.面下_器官右下_表示;
			this.面上_表示 = e.面上_表示;
			this.付根左_付根1_表示 = e.付根左_付根1_表示;
			this.付根左_付根2_表示 = e.付根左_付根2_表示;
			this.付根右_付根1_表示 = e.付根右_付根1_表示;
			this.付根右_付根2_表示 = e.付根右_付根2_表示;
			this.単眼_眼中_基_表示 = e.単眼_眼中_基_表示;
			this.単眼_眼中_眼_表示 = e.単眼_眼中_眼_表示;
			this.単眼_眼中_ハイライト_表示 = e.単眼_眼中_ハイライト_表示;
			this.単眼_眼左_基_表示 = e.単眼_眼左_基_表示;
			this.単眼_眼左_眼_表示 = e.単眼_眼左_眼_表示;
			this.単眼_眼左_ハイライト_表示 = e.単眼_眼左_ハイライト_表示;
			this.単眼_眼右_基_表示 = e.単眼_眼右_基_表示;
			this.単眼_眼右_眼_表示 = e.単眼_眼右_眼_表示;
			this.単眼_眼右_ハイライト_表示 = e.単眼_眼右_ハイライト_表示;
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
					f.接続情報 = 接続情報.顔面_虫_触覚左_接続;
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
					f.接続情報 = 接続情報.顔面_虫_触覚右_接続;
					f.接続(CS$<>8__locals1.<>4__this.触覚右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_面基CP = new ColorP(this.X0Y0_面基, this.面基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_複眼左_複眼1CP = new ColorP(this.X0Y0_複眼左_複眼1, this.複眼左_複眼1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_複眼左_複眼2CP = new ColorP(this.X0Y0_複眼左_複眼2, this.複眼左_複眼2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_複眼左_ハイライトCP = new ColorP(this.X0Y0_複眼左_ハイライト, this.複眼左_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_複眼右_複眼1CP = new ColorP(this.X0Y0_複眼右_複眼1, this.複眼右_複眼1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_複眼右_複眼2CP = new ColorP(this.X0Y0_複眼右_複眼2, this.複眼右_複眼2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_複眼右_ハイライトCP = new ColorP(this.X0Y0_複眼右_ハイライト, this.複眼右_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面下_面CP = new ColorP(this.X0Y0_面下_面, this.面下_面CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面下_器官左上CP = new ColorP(this.X0Y0_面下_器官左上, this.面下_器官左上CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面下_器官左下CP = new ColorP(this.X0Y0_面下_器官左下, this.面下_器官左下CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面下_器官右上CP = new ColorP(this.X0Y0_面下_器官右上, this.面下_器官右上CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面下_器官右下CP = new ColorP(this.X0Y0_面下_器官右下, this.面下_器官右下CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_面上CP = new ColorP(this.X0Y0_面上, this.面上CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_付根左_付根1CP = new ColorP(this.X0Y0_付根左_付根1, this.付根左_付根1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_付根左_付根2CP = new ColorP(this.X0Y0_付根左_付根2, this.付根左_付根2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_付根右_付根1CP = new ColorP(this.X0Y0_付根右_付根1, this.付根右_付根1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_付根右_付根2CP = new ColorP(this.X0Y0_付根右_付根2, this.付根右_付根2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_単眼_眼中_基CP = new ColorP(this.X0Y0_単眼_眼中_基, this.単眼_眼中_基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_単眼_眼中_眼CP = new ColorP(this.X0Y0_単眼_眼中_眼, this.単眼_眼中_眼CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_単眼_眼中_ハイライトCP = new ColorP(this.X0Y0_単眼_眼中_ハイライト, this.単眼_眼中_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_単眼_眼左_基CP = new ColorP(this.X0Y0_単眼_眼左_基, this.単眼_眼左_基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_単眼_眼左_眼CP = new ColorP(this.X0Y0_単眼_眼左_眼, this.単眼_眼左_眼CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_単眼_眼左_ハイライトCP = new ColorP(this.X0Y0_単眼_眼左_ハイライト, this.単眼_眼左_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_単眼_眼右_基CP = new ColorP(this.X0Y0_単眼_眼右_基, this.単眼_眼右_基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_単眼_眼右_眼CP = new ColorP(this.X0Y0_単眼_眼右_眼, this.単眼_眼右_眼CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_単眼_眼右_ハイライトCP = new ColorP(this.X0Y0_単眼_眼右_ハイライト, this.単眼_眼右_ハイライトCD, CS$<>8__locals1.DisUnit, true);
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

		public bool 面基_表示
		{
			get
			{
				return this.X0Y0_面基.Dra;
			}
			set
			{
				this.X0Y0_面基.Dra = value;
				this.X0Y0_面基.Hit = value;
			}
		}

		public bool 複眼左_複眼1_表示
		{
			get
			{
				return this.X0Y0_複眼左_複眼1.Dra;
			}
			set
			{
				this.X0Y0_複眼左_複眼1.Dra = value;
				this.X0Y0_複眼左_複眼1.Hit = value;
			}
		}

		public bool 複眼左_複眼2_表示
		{
			get
			{
				return this.X0Y0_複眼左_複眼2.Dra;
			}
			set
			{
				this.X0Y0_複眼左_複眼2.Dra = value;
				this.X0Y0_複眼左_複眼2.Hit = value;
			}
		}

		public bool 複眼左_ハイライト_表示
		{
			get
			{
				return this.X0Y0_複眼左_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_複眼左_ハイライト.Dra = value;
				this.X0Y0_複眼左_ハイライト.Hit = value;
			}
		}

		public bool 複眼右_複眼1_表示
		{
			get
			{
				return this.X0Y0_複眼右_複眼1.Dra;
			}
			set
			{
				this.X0Y0_複眼右_複眼1.Dra = value;
				this.X0Y0_複眼右_複眼1.Hit = value;
			}
		}

		public bool 複眼右_複眼2_表示
		{
			get
			{
				return this.X0Y0_複眼右_複眼2.Dra;
			}
			set
			{
				this.X0Y0_複眼右_複眼2.Dra = value;
				this.X0Y0_複眼右_複眼2.Hit = value;
			}
		}

		public bool 複眼右_ハイライト_表示
		{
			get
			{
				return this.X0Y0_複眼右_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_複眼右_ハイライト.Dra = value;
				this.X0Y0_複眼右_ハイライト.Hit = value;
			}
		}

		public bool 面下_面_表示
		{
			get
			{
				return this.X0Y0_面下_面.Dra;
			}
			set
			{
				this.X0Y0_面下_面.Dra = value;
				this.X0Y0_面下_面.Hit = value;
			}
		}

		public bool 面下_器官左上_表示
		{
			get
			{
				return this.X0Y0_面下_器官左上.Dra;
			}
			set
			{
				this.X0Y0_面下_器官左上.Dra = value;
				this.X0Y0_面下_器官左上.Hit = value;
			}
		}

		public bool 面下_器官左下_表示
		{
			get
			{
				return this.X0Y0_面下_器官左下.Dra;
			}
			set
			{
				this.X0Y0_面下_器官左下.Dra = value;
				this.X0Y0_面下_器官左下.Hit = value;
			}
		}

		public bool 面下_器官右上_表示
		{
			get
			{
				return this.X0Y0_面下_器官右上.Dra;
			}
			set
			{
				this.X0Y0_面下_器官右上.Dra = value;
				this.X0Y0_面下_器官右上.Hit = value;
			}
		}

		public bool 面下_器官右下_表示
		{
			get
			{
				return this.X0Y0_面下_器官右下.Dra;
			}
			set
			{
				this.X0Y0_面下_器官右下.Dra = value;
				this.X0Y0_面下_器官右下.Hit = value;
			}
		}

		public bool 面上_表示
		{
			get
			{
				return this.X0Y0_面上.Dra;
			}
			set
			{
				this.X0Y0_面上.Dra = value;
				this.X0Y0_面上.Hit = value;
			}
		}

		public bool 付根左_付根1_表示
		{
			get
			{
				return this.X0Y0_付根左_付根1.Dra;
			}
			set
			{
				this.X0Y0_付根左_付根1.Dra = value;
				this.X0Y0_付根左_付根1.Hit = value;
			}
		}

		public bool 付根左_付根2_表示
		{
			get
			{
				return this.X0Y0_付根左_付根2.Dra;
			}
			set
			{
				this.X0Y0_付根左_付根2.Dra = value;
				this.X0Y0_付根左_付根2.Hit = value;
			}
		}

		public bool 付根右_付根1_表示
		{
			get
			{
				return this.X0Y0_付根右_付根1.Dra;
			}
			set
			{
				this.X0Y0_付根右_付根1.Dra = value;
				this.X0Y0_付根右_付根1.Hit = value;
			}
		}

		public bool 付根右_付根2_表示
		{
			get
			{
				return this.X0Y0_付根右_付根2.Dra;
			}
			set
			{
				this.X0Y0_付根右_付根2.Dra = value;
				this.X0Y0_付根右_付根2.Hit = value;
			}
		}

		public bool 単眼_眼中_基_表示
		{
			get
			{
				return this.X0Y0_単眼_眼中_基.Dra;
			}
			set
			{
				this.X0Y0_単眼_眼中_基.Dra = value;
				this.X0Y0_単眼_眼中_基.Hit = value;
			}
		}

		public bool 単眼_眼中_眼_表示
		{
			get
			{
				return this.X0Y0_単眼_眼中_眼.Dra;
			}
			set
			{
				this.X0Y0_単眼_眼中_眼.Dra = value;
				this.X0Y0_単眼_眼中_眼.Hit = value;
			}
		}

		public bool 単眼_眼中_ハイライト_表示
		{
			get
			{
				return this.X0Y0_単眼_眼中_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_単眼_眼中_ハイライト.Dra = value;
				this.X0Y0_単眼_眼中_ハイライト.Hit = value;
			}
		}

		public bool 単眼_眼左_基_表示
		{
			get
			{
				return this.X0Y0_単眼_眼左_基.Dra;
			}
			set
			{
				this.X0Y0_単眼_眼左_基.Dra = value;
				this.X0Y0_単眼_眼左_基.Hit = value;
			}
		}

		public bool 単眼_眼左_眼_表示
		{
			get
			{
				return this.X0Y0_単眼_眼左_眼.Dra;
			}
			set
			{
				this.X0Y0_単眼_眼左_眼.Dra = value;
				this.X0Y0_単眼_眼左_眼.Hit = value;
			}
		}

		public bool 単眼_眼左_ハイライト_表示
		{
			get
			{
				return this.X0Y0_単眼_眼左_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_単眼_眼左_ハイライト.Dra = value;
				this.X0Y0_単眼_眼左_ハイライト.Hit = value;
			}
		}

		public bool 単眼_眼右_基_表示
		{
			get
			{
				return this.X0Y0_単眼_眼右_基.Dra;
			}
			set
			{
				this.X0Y0_単眼_眼右_基.Dra = value;
				this.X0Y0_単眼_眼右_基.Hit = value;
			}
		}

		public bool 単眼_眼右_眼_表示
		{
			get
			{
				return this.X0Y0_単眼_眼右_眼.Dra;
			}
			set
			{
				this.X0Y0_単眼_眼右_眼.Dra = value;
				this.X0Y0_単眼_眼右_眼.Hit = value;
			}
		}

		public bool 単眼_眼右_ハイライト_表示
		{
			get
			{
				return this.X0Y0_単眼_眼右_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_単眼_眼右_ハイライト.Dra = value;
				this.X0Y0_単眼_眼右_ハイライト.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.面基_表示;
			}
			set
			{
				this.面基_表示 = value;
				this.複眼左_複眼1_表示 = value;
				this.複眼左_複眼2_表示 = value;
				this.複眼左_ハイライト_表示 = value;
				this.複眼右_複眼1_表示 = value;
				this.複眼右_複眼2_表示 = value;
				this.複眼右_ハイライト_表示 = value;
				this.面下_面_表示 = value;
				this.面下_器官左上_表示 = value;
				this.面下_器官左下_表示 = value;
				this.面下_器官右上_表示 = value;
				this.面下_器官右下_表示 = value;
				this.面上_表示 = value;
				this.付根左_付根1_表示 = value;
				this.付根左_付根2_表示 = value;
				this.付根右_付根1_表示 = value;
				this.付根右_付根2_表示 = value;
				this.単眼_眼中_基_表示 = value;
				this.単眼_眼中_眼_表示 = value;
				this.単眼_眼中_ハイライト_表示 = value;
				this.単眼_眼左_基_表示 = value;
				this.単眼_眼左_眼_表示 = value;
				this.単眼_眼左_ハイライト_表示 = value;
				this.単眼_眼右_基_表示 = value;
				this.単眼_眼右_眼_表示 = value;
				this.単眼_眼右_ハイライト_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.面基CD.不透明度;
			}
			set
			{
				this.面基CD.不透明度 = value;
				this.複眼左_複眼1CD.不透明度 = value;
				this.複眼左_複眼2CD.不透明度 = value;
				this.複眼左_ハイライトCD.不透明度 = value;
				this.複眼右_複眼1CD.不透明度 = value;
				this.複眼右_複眼2CD.不透明度 = value;
				this.複眼右_ハイライトCD.不透明度 = value;
				this.面下_面CD.不透明度 = value;
				this.面下_器官左上CD.不透明度 = value;
				this.面下_器官左下CD.不透明度 = value;
				this.面下_器官右上CD.不透明度 = value;
				this.面下_器官右下CD.不透明度 = value;
				this.面上CD.不透明度 = value;
				this.付根左_付根1CD.不透明度 = value;
				this.付根左_付根2CD.不透明度 = value;
				this.付根右_付根1CD.不透明度 = value;
				this.付根右_付根2CD.不透明度 = value;
				this.単眼_眼中_基CD.不透明度 = value;
				this.単眼_眼中_眼CD.不透明度 = value;
				this.単眼_眼中_ハイライトCD.不透明度 = value;
				this.単眼_眼左_基CD.不透明度 = value;
				this.単眼_眼左_眼CD.不透明度 = value;
				this.単眼_眼左_ハイライトCD.不透明度 = value;
				this.単眼_眼右_基CD.不透明度 = value;
				this.単眼_眼右_眼CD.不透明度 = value;
				this.単眼_眼右_ハイライトCD.不透明度 = value;
			}
		}

		public override double 展開1
		{
			set
			{
				double num = 15.0 * value;
				this.X0Y0_複眼左_複眼1.AngleCont = num;
				this.X0Y0_複眼左_複眼2.AngleCont = num;
				this.X0Y0_複眼左_ハイライト.AngleCont = num;
				this.X0Y0_複眼左_複眼1.PositionCont = new Vector2D(0.0, -0.0045 * value);
				this.X0Y0_複眼左_複眼2.PositionCont = this.X0Y0_複眼左_複眼1.PositionCont;
				this.X0Y0_複眼左_ハイライト.PositionCont = this.X0Y0_複眼左_複眼1.PositionCont;
				num = -num;
				this.X0Y0_複眼右_複眼1.AngleCont = num;
				this.X0Y0_複眼右_複眼2.AngleCont = num;
				this.X0Y0_複眼右_ハイライト.AngleCont = num;
				this.X0Y0_複眼右_複眼1.PositionCont = this.X0Y0_複眼左_複眼1.PositionCont;
				this.X0Y0_複眼右_複眼2.PositionCont = this.X0Y0_複眼左_複眼1.PositionCont;
				this.X0Y0_複眼右_ハイライト.PositionCont = this.X0Y0_複眼左_複眼1.PositionCont;
				this.X0Y0_面下_面.PositionCont = (this.X0Y0_面下_面.OP[0].ps[0] - this.X0Y0_面下_面.OP[2].ps[2]) * 0.7 * value;
			}
		}

		public JointS 触覚左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_付根左_付根2, 0);
			}
		}

		public JointS 触覚右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_付根右_付根2, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_面基CP.Update();
			this.X0Y0_複眼左_複眼1CP.Update();
			this.X0Y0_複眼左_複眼2CP.Update();
			this.X0Y0_複眼左_ハイライトCP.Update();
			this.X0Y0_複眼右_複眼1CP.Update();
			this.X0Y0_複眼右_複眼2CP.Update();
			this.X0Y0_複眼右_ハイライトCP.Update();
			this.X0Y0_面下_面CP.Update();
			this.X0Y0_面下_器官左上CP.Update();
			this.X0Y0_面下_器官左下CP.Update();
			this.X0Y0_面下_器官右上CP.Update();
			this.X0Y0_面下_器官右下CP.Update();
			this.X0Y0_面上CP.Update();
			this.X0Y0_付根左_付根1CP.Update();
			this.X0Y0_付根左_付根2CP.Update();
			this.X0Y0_付根右_付根1CP.Update();
			this.X0Y0_付根右_付根2CP.Update();
			this.X0Y0_単眼_眼中_基CP.Update();
			this.X0Y0_単眼_眼中_眼CP.Update();
			this.X0Y0_単眼_眼中_ハイライトCP.Update();
			this.X0Y0_単眼_眼左_基CP.Update();
			this.X0Y0_単眼_眼左_眼CP.Update();
			this.X0Y0_単眼_眼左_ハイライトCP.Update();
			this.X0Y0_単眼_眼右_基CP.Update();
			this.X0Y0_単眼_眼右_眼CP.Update();
			this.X0Y0_単眼_眼右_ハイライトCP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.面基CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.複眼左_複眼1CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.複眼左_複眼2CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.複眼左_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.複眼右_複眼1CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.複眼右_複眼2CD = new ColorD(ref Col.Black, ref 体配色.眼0O);
			this.複眼右_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.面下_面CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.面下_器官左上CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.面下_器官左下CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.面下_器官右上CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.面下_器官右下CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.面上CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.付根左_付根1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.付根左_付根2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.付根右_付根1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.付根右_付根2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.単眼_眼中_基CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
			this.単眼_眼中_眼CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
			this.単眼_眼中_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.単眼_眼左_基CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
			this.単眼_眼左_眼CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
			this.単眼_眼左_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
			this.単眼_眼右_基CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
			this.単眼_眼右_眼CD = new ColorD(ref Col.Black, ref 体配色.眼1O);
			this.単眼_眼右_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト);
		}

		public Par X0Y0_面基;

		public Par X0Y0_複眼左_複眼1;

		public Par X0Y0_複眼左_複眼2;

		public Par X0Y0_複眼左_ハイライト;

		public Par X0Y0_複眼右_複眼1;

		public Par X0Y0_複眼右_複眼2;

		public Par X0Y0_複眼右_ハイライト;

		public Par X0Y0_面下_面;

		public Par X0Y0_面下_器官左上;

		public Par X0Y0_面下_器官左下;

		public Par X0Y0_面下_器官右上;

		public Par X0Y0_面下_器官右下;

		public Par X0Y0_面上;

		public Par X0Y0_付根左_付根1;

		public Par X0Y0_付根左_付根2;

		public Par X0Y0_付根右_付根1;

		public Par X0Y0_付根右_付根2;

		public Par X0Y0_単眼_眼中_基;

		public Par X0Y0_単眼_眼中_眼;

		public Par X0Y0_単眼_眼中_ハイライト;

		public Par X0Y0_単眼_眼左_基;

		public Par X0Y0_単眼_眼左_眼;

		public Par X0Y0_単眼_眼左_ハイライト;

		public Par X0Y0_単眼_眼右_基;

		public Par X0Y0_単眼_眼右_眼;

		public Par X0Y0_単眼_眼右_ハイライト;

		public ColorD 面基CD;

		public ColorD 複眼左_複眼1CD;

		public ColorD 複眼左_複眼2CD;

		public ColorD 複眼左_ハイライトCD;

		public ColorD 複眼右_複眼1CD;

		public ColorD 複眼右_複眼2CD;

		public ColorD 複眼右_ハイライトCD;

		public ColorD 面下_面CD;

		public ColorD 面下_器官左上CD;

		public ColorD 面下_器官左下CD;

		public ColorD 面下_器官右上CD;

		public ColorD 面下_器官右下CD;

		public ColorD 面上CD;

		public ColorD 付根左_付根1CD;

		public ColorD 付根左_付根2CD;

		public ColorD 付根右_付根1CD;

		public ColorD 付根右_付根2CD;

		public ColorD 単眼_眼中_基CD;

		public ColorD 単眼_眼中_眼CD;

		public ColorD 単眼_眼中_ハイライトCD;

		public ColorD 単眼_眼左_基CD;

		public ColorD 単眼_眼左_眼CD;

		public ColorD 単眼_眼左_ハイライトCD;

		public ColorD 単眼_眼右_基CD;

		public ColorD 単眼_眼右_眼CD;

		public ColorD 単眼_眼右_ハイライトCD;

		public ColorP X0Y0_面基CP;

		public ColorP X0Y0_複眼左_複眼1CP;

		public ColorP X0Y0_複眼左_複眼2CP;

		public ColorP X0Y0_複眼左_ハイライトCP;

		public ColorP X0Y0_複眼右_複眼1CP;

		public ColorP X0Y0_複眼右_複眼2CP;

		public ColorP X0Y0_複眼右_ハイライトCP;

		public ColorP X0Y0_面下_面CP;

		public ColorP X0Y0_面下_器官左上CP;

		public ColorP X0Y0_面下_器官左下CP;

		public ColorP X0Y0_面下_器官右上CP;

		public ColorP X0Y0_面下_器官右下CP;

		public ColorP X0Y0_面上CP;

		public ColorP X0Y0_付根左_付根1CP;

		public ColorP X0Y0_付根左_付根2CP;

		public ColorP X0Y0_付根右_付根1CP;

		public ColorP X0Y0_付根右_付根2CP;

		public ColorP X0Y0_単眼_眼中_基CP;

		public ColorP X0Y0_単眼_眼中_眼CP;

		public ColorP X0Y0_単眼_眼中_ハイライトCP;

		public ColorP X0Y0_単眼_眼左_基CP;

		public ColorP X0Y0_単眼_眼左_眼CP;

		public ColorP X0Y0_単眼_眼左_ハイライトCP;

		public ColorP X0Y0_単眼_眼右_基CP;

		public ColorP X0Y0_単眼_眼右_眼CP;

		public ColorP X0Y0_単眼_眼右_ハイライトCP;
	}
}
