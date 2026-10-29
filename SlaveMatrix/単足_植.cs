using System;
using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 単足_植 : 半身
	{
		public 単足_植(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 単足_植D e)
		{
			単足_植.<>c__DisplayClass116_0 CS$<>8__locals1 = new 単足_植.<>c__DisplayClass116_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "植";
			dif.Add(new Pars(Sta.半身["単足"][0][0]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_幹上 = pars["幹上"].ToPar();
			this.X0Y0_幹下 = pars["幹下"].ToPar();
			this.X0Y0_葉左 = pars["葉左"].ToPar();
			this.X0Y0_葉右 = pars["葉右"].ToPar();
			this.X0Y0_脈上1 = pars["脈上1"].ToPar();
			this.X0Y0_脈上2 = pars["脈上2"].ToPar();
			this.X0Y0_脈下1 = pars["脈下1"].ToPar();
			this.X0Y0_脈下2 = pars["脈下2"].ToPar();
			Pars pars2 = pars["虫食"].ToPars();
			Pars pars3 = pars2["左"].ToPars();
			this.X0Y0_虫食_左_虫食1 = pars3["虫食1"].ToPar();
			this.X0Y0_虫食_左_虫食2 = pars3["虫食2"].ToPar();
			this.X0Y0_虫食_左_虫食3 = pars3["虫食3"].ToPar();
			this.X0Y0_虫食_左_虫食4 = pars3["虫食4"].ToPar();
			this.X0Y0_虫食_左_虫食5 = pars3["虫食5"].ToPar();
			this.X0Y0_虫食_左_虫食6 = pars3["虫食6"].ToPar();
			this.X0Y0_虫食_左_虫食7 = pars3["虫食7"].ToPar();
			this.X0Y0_虫食_左_虫食8 = pars3["虫食8"].ToPar();
			this.X0Y0_虫食_左_虫食9 = pars3["虫食9"].ToPar();
			this.X0Y0_虫食_左_虫食10 = pars3["虫食10"].ToPar();
			this.X0Y0_虫食_左_虫食11 = pars3["虫食11"].ToPar();
			this.X0Y0_虫食_左_虫食12 = pars3["虫食12"].ToPar();
			pars3 = pars2["右"].ToPars();
			this.X0Y0_虫食_右_虫食1 = pars3["虫食1"].ToPar();
			this.X0Y0_虫食_右_虫食2 = pars3["虫食2"].ToPar();
			this.X0Y0_虫食_右_虫食3 = pars3["虫食3"].ToPar();
			this.X0Y0_虫食_右_虫食4 = pars3["虫食4"].ToPar();
			this.X0Y0_虫食_右_虫食5 = pars3["虫食5"].ToPar();
			this.X0Y0_虫食_右_虫食6 = pars3["虫食6"].ToPar();
			this.X0Y0_虫食_右_虫食7 = pars3["虫食7"].ToPar();
			this.X0Y0_虫食_右_虫食8 = pars3["虫食8"].ToPar();
			this.X0Y0_虫食_右_虫食9 = pars3["虫食9"].ToPar();
			this.X0Y0_虫食_右_虫食10 = pars3["虫食10"].ToPar();
			this.X0Y0_虫食_右_虫食11 = pars3["虫食11"].ToPar();
			this.X0Y0_虫食_右_虫食12 = pars3["虫食12"].ToPar();
			pars2 = pars["脚輪"].ToPars();
			this.X0Y0_脚輪_革 = pars2["革"].ToPar();
			this.X0Y0_脚輪_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_脚輪_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_脚輪_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_脚輪_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_脚輪_金具右 = pars2["金具右"].ToPar();
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
			this.幹上_表示 = e.幹上_表示;
			this.幹下_表示 = e.幹下_表示;
			this.葉左_表示 = e.葉左_表示;
			this.葉右_表示 = e.葉右_表示;
			this.脈上1_表示 = e.脈上1_表示;
			this.脈上2_表示 = e.脈上2_表示;
			this.脈下1_表示 = e.脈下1_表示;
			this.脈下2_表示 = e.脈下2_表示;
			this.虫食_左_虫食1_表示 = e.虫食_左_虫食1_表示;
			this.虫食_左_虫食2_表示 = e.虫食_左_虫食2_表示;
			this.虫食_左_虫食3_表示 = e.虫食_左_虫食3_表示;
			this.虫食_左_虫食4_表示 = e.虫食_左_虫食4_表示;
			this.虫食_左_虫食5_表示 = e.虫食_左_虫食5_表示;
			this.虫食_左_虫食6_表示 = e.虫食_左_虫食6_表示;
			this.虫食_左_虫食7_表示 = e.虫食_左_虫食7_表示;
			this.虫食_左_虫食8_表示 = e.虫食_左_虫食8_表示;
			this.虫食_左_虫食9_表示 = e.虫食_左_虫食9_表示;
			this.虫食_左_虫食10_表示 = e.虫食_左_虫食10_表示;
			this.虫食_左_虫食11_表示 = e.虫食_左_虫食11_表示;
			this.虫食_左_虫食12_表示 = e.虫食_左_虫食12_表示;
			this.虫食_右_虫食1_表示 = e.虫食_右_虫食1_表示;
			this.虫食_右_虫食2_表示 = e.虫食_右_虫食2_表示;
			this.虫食_右_虫食3_表示 = e.虫食_右_虫食3_表示;
			this.虫食_右_虫食4_表示 = e.虫食_右_虫食4_表示;
			this.虫食_右_虫食5_表示 = e.虫食_右_虫食5_表示;
			this.虫食_右_虫食6_表示 = e.虫食_右_虫食6_表示;
			this.虫食_右_虫食7_表示 = e.虫食_右_虫食7_表示;
			this.虫食_右_虫食8_表示 = e.虫食_右_虫食8_表示;
			this.虫食_右_虫食9_表示 = e.虫食_右_虫食9_表示;
			this.虫食_右_虫食10_表示 = e.虫食_右_虫食10_表示;
			this.虫食_右_虫食11_表示 = e.虫食_右_虫食11_表示;
			this.虫食_右_虫食12_表示 = e.虫食_右_虫食12_表示;
			this.脚輪_革_表示 = e.脚輪_革_表示;
			this.脚輪_金具1_表示 = e.脚輪_金具1_表示;
			this.脚輪_金具2_表示 = e.脚輪_金具2_表示;
			this.脚輪_金具3_表示 = e.脚輪_金具3_表示;
			this.脚輪_金具左_表示 = e.脚輪_金具左_表示;
			this.脚輪_金具右_表示 = e.脚輪_金具右_表示;
			this.脚輪表示 = e.脚輪表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.根外左_接続.Count > 0)
			{
				Ele f;
				this.根外左_接続 = e.根外左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.単足_植_根外左_接続;
					f.接続(CS$<>8__locals1.<>4__this.根外左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.根内左_接続.Count > 0)
			{
				Ele f;
				this.根内左_接続 = e.根内左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.単足_植_根内左_接続;
					f.接続(CS$<>8__locals1.<>4__this.根内左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.根中央_接続.Count > 0)
			{
				Ele f;
				this.根中央_接続 = e.根中央_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.単足_植_根中央_接続;
					f.接続(CS$<>8__locals1.<>4__this.根中央_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.根内右_接続.Count > 0)
			{
				Ele f;
				this.根内右_接続 = e.根内右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.単足_植_根内右_接続;
					f.接続(CS$<>8__locals1.<>4__this.根内右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.根外右_接続.Count > 0)
			{
				Ele f;
				this.根外右_接続 = e.根外右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.単足_植_根外右_接続;
					f.接続(CS$<>8__locals1.<>4__this.根外右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_幹上CP = new ColorP(this.X0Y0_幹上, this.幹上CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_幹下CP = new ColorP(this.X0Y0_幹下, this.幹下CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_葉左CP = new ColorP(this.X0Y0_葉左, this.葉左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_葉右CP = new ColorP(this.X0Y0_葉右, this.葉右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脈上1CP = new ColorP(this.X0Y0_脈上1, this.脈上1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脈上2CP = new ColorP(this.X0Y0_脈上2, this.脈上2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脈下1CP = new ColorP(this.X0Y0_脈下1, this.脈下1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脈下2CP = new ColorP(this.X0Y0_脈下2, this.脈下2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_左_虫食1CP = new ColorP(this.X0Y0_虫食_左_虫食1, this.虫食_左_虫食1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_左_虫食2CP = new ColorP(this.X0Y0_虫食_左_虫食2, this.虫食_左_虫食2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_左_虫食3CP = new ColorP(this.X0Y0_虫食_左_虫食3, this.虫食_左_虫食3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_左_虫食4CP = new ColorP(this.X0Y0_虫食_左_虫食4, this.虫食_左_虫食4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_左_虫食5CP = new ColorP(this.X0Y0_虫食_左_虫食5, this.虫食_左_虫食5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_左_虫食6CP = new ColorP(this.X0Y0_虫食_左_虫食6, this.虫食_左_虫食6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_左_虫食7CP = new ColorP(this.X0Y0_虫食_左_虫食7, this.虫食_左_虫食7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_左_虫食8CP = new ColorP(this.X0Y0_虫食_左_虫食8, this.虫食_左_虫食8CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_左_虫食9CP = new ColorP(this.X0Y0_虫食_左_虫食9, this.虫食_左_虫食9CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_左_虫食10CP = new ColorP(this.X0Y0_虫食_左_虫食10, this.虫食_左_虫食10CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_左_虫食11CP = new ColorP(this.X0Y0_虫食_左_虫食11, this.虫食_左_虫食11CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_左_虫食12CP = new ColorP(this.X0Y0_虫食_左_虫食12, this.虫食_左_虫食12CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_右_虫食1CP = new ColorP(this.X0Y0_虫食_右_虫食1, this.虫食_右_虫食1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_右_虫食2CP = new ColorP(this.X0Y0_虫食_右_虫食2, this.虫食_右_虫食2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_右_虫食3CP = new ColorP(this.X0Y0_虫食_右_虫食3, this.虫食_右_虫食3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_右_虫食4CP = new ColorP(this.X0Y0_虫食_右_虫食4, this.虫食_右_虫食4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_右_虫食5CP = new ColorP(this.X0Y0_虫食_右_虫食5, this.虫食_右_虫食5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_右_虫食6CP = new ColorP(this.X0Y0_虫食_右_虫食6, this.虫食_右_虫食6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_右_虫食7CP = new ColorP(this.X0Y0_虫食_右_虫食7, this.虫食_右_虫食7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_右_虫食8CP = new ColorP(this.X0Y0_虫食_右_虫食8, this.虫食_右_虫食8CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_右_虫食9CP = new ColorP(this.X0Y0_虫食_右_虫食9, this.虫食_右_虫食9CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_右_虫食10CP = new ColorP(this.X0Y0_虫食_右_虫食10, this.虫食_右_虫食10CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_右_虫食11CP = new ColorP(this.X0Y0_虫食_右_虫食11, this.虫食_右_虫食11CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫食_右_虫食12CP = new ColorP(this.X0Y0_虫食_右_虫食12, this.虫食_右_虫食12CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚輪_革CP = new ColorP(this.X0Y0_脚輪_革, this.脚輪_革CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚輪_金具1CP = new ColorP(this.X0Y0_脚輪_金具1, this.脚輪_金具1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚輪_金具2CP = new ColorP(this.X0Y0_脚輪_金具2, this.脚輪_金具2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚輪_金具3CP = new ColorP(this.X0Y0_脚輪_金具3, this.脚輪_金具3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚輪_金具左CP = new ColorP(this.X0Y0_脚輪_金具左, this.脚輪_金具左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚輪_金具右CP = new ColorP(this.X0Y0_脚輪_金具右, this.脚輪_金具右CD, CS$<>8__locals1.DisUnit, true);
			this.濃度 = e.濃度;
			this.鎖1 = new 拘束鎖(CS$<>8__locals1.DisUnit, this.右, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖2 = new 拘束鎖(CS$<>8__locals1.DisUnit, !this.右, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖1.接続(this.鎖1_接続点);
			this.鎖2.接続(this.鎖2_接続点);
			int num = this.右 ? -10 : 10;
			this.鎖1.角度B -= (double)num;
			this.鎖2.角度B += (double)num;
			this.鎖表示 = e.鎖表示;
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
				this.脚輪表示 = value;
			}
		}

		public bool 幹上_表示
		{
			get
			{
				return this.X0Y0_幹上.Dra;
			}
			set
			{
				this.X0Y0_幹上.Dra = value;
				this.X0Y0_幹上.Hit = value;
			}
		}

		public bool 幹下_表示
		{
			get
			{
				return this.X0Y0_幹下.Dra;
			}
			set
			{
				this.X0Y0_幹下.Dra = value;
				this.X0Y0_幹下.Hit = value;
			}
		}

		public bool 葉左_表示
		{
			get
			{
				return this.X0Y0_葉左.Dra;
			}
			set
			{
				this.X0Y0_葉左.Dra = value;
				this.X0Y0_葉左.Hit = value;
			}
		}

		public bool 葉右_表示
		{
			get
			{
				return this.X0Y0_葉右.Dra;
			}
			set
			{
				this.X0Y0_葉右.Dra = value;
				this.X0Y0_葉右.Hit = value;
			}
		}

		public bool 脈上1_表示
		{
			get
			{
				return this.X0Y0_脈上1.Dra;
			}
			set
			{
				this.X0Y0_脈上1.Dra = value;
				this.X0Y0_脈上1.Hit = value;
			}
		}

		public bool 脈上2_表示
		{
			get
			{
				return this.X0Y0_脈上2.Dra;
			}
			set
			{
				this.X0Y0_脈上2.Dra = value;
				this.X0Y0_脈上2.Hit = value;
			}
		}

		public bool 脈下1_表示
		{
			get
			{
				return this.X0Y0_脈下1.Dra;
			}
			set
			{
				this.X0Y0_脈下1.Dra = value;
				this.X0Y0_脈下1.Hit = value;
			}
		}

		public bool 脈下2_表示
		{
			get
			{
				return this.X0Y0_脈下2.Dra;
			}
			set
			{
				this.X0Y0_脈下2.Dra = value;
				this.X0Y0_脈下2.Hit = value;
			}
		}

		public bool 虫食_左_虫食1_表示
		{
			get
			{
				return this.X0Y0_虫食_左_虫食1.Dra;
			}
			set
			{
				this.X0Y0_虫食_左_虫食1.Dra = value;
				this.X0Y0_虫食_左_虫食1.Hit = value;
			}
		}

		public bool 虫食_左_虫食2_表示
		{
			get
			{
				return this.X0Y0_虫食_左_虫食2.Dra;
			}
			set
			{
				this.X0Y0_虫食_左_虫食2.Dra = value;
				this.X0Y0_虫食_左_虫食2.Hit = value;
			}
		}

		public bool 虫食_左_虫食3_表示
		{
			get
			{
				return this.X0Y0_虫食_左_虫食3.Dra;
			}
			set
			{
				this.X0Y0_虫食_左_虫食3.Dra = value;
				this.X0Y0_虫食_左_虫食3.Hit = value;
			}
		}

		public bool 虫食_左_虫食4_表示
		{
			get
			{
				return this.X0Y0_虫食_左_虫食4.Dra;
			}
			set
			{
				this.X0Y0_虫食_左_虫食4.Dra = value;
				this.X0Y0_虫食_左_虫食4.Hit = value;
			}
		}

		public bool 虫食_左_虫食5_表示
		{
			get
			{
				return this.X0Y0_虫食_左_虫食5.Dra;
			}
			set
			{
				this.X0Y0_虫食_左_虫食5.Dra = value;
				this.X0Y0_虫食_左_虫食5.Hit = value;
			}
		}

		public bool 虫食_左_虫食6_表示
		{
			get
			{
				return this.X0Y0_虫食_左_虫食6.Dra;
			}
			set
			{
				this.X0Y0_虫食_左_虫食6.Dra = value;
				this.X0Y0_虫食_左_虫食6.Hit = value;
			}
		}

		public bool 虫食_左_虫食7_表示
		{
			get
			{
				return this.X0Y0_虫食_左_虫食7.Dra;
			}
			set
			{
				this.X0Y0_虫食_左_虫食7.Dra = value;
				this.X0Y0_虫食_左_虫食7.Hit = value;
			}
		}

		public bool 虫食_左_虫食8_表示
		{
			get
			{
				return this.X0Y0_虫食_左_虫食8.Dra;
			}
			set
			{
				this.X0Y0_虫食_左_虫食8.Dra = value;
				this.X0Y0_虫食_左_虫食8.Hit = value;
			}
		}

		public bool 虫食_左_虫食9_表示
		{
			get
			{
				return this.X0Y0_虫食_左_虫食9.Dra;
			}
			set
			{
				this.X0Y0_虫食_左_虫食9.Dra = value;
				this.X0Y0_虫食_左_虫食9.Hit = value;
			}
		}

		public bool 虫食_左_虫食10_表示
		{
			get
			{
				return this.X0Y0_虫食_左_虫食10.Dra;
			}
			set
			{
				this.X0Y0_虫食_左_虫食10.Dra = value;
				this.X0Y0_虫食_左_虫食10.Hit = value;
			}
		}

		public bool 虫食_左_虫食11_表示
		{
			get
			{
				return this.X0Y0_虫食_左_虫食11.Dra;
			}
			set
			{
				this.X0Y0_虫食_左_虫食11.Dra = value;
				this.X0Y0_虫食_左_虫食11.Hit = value;
			}
		}

		public bool 虫食_左_虫食12_表示
		{
			get
			{
				return this.X0Y0_虫食_左_虫食12.Dra;
			}
			set
			{
				this.X0Y0_虫食_左_虫食12.Dra = value;
				this.X0Y0_虫食_左_虫食12.Hit = value;
			}
		}

		public bool 虫食_右_虫食1_表示
		{
			get
			{
				return this.X0Y0_虫食_右_虫食1.Dra;
			}
			set
			{
				this.X0Y0_虫食_右_虫食1.Dra = value;
				this.X0Y0_虫食_右_虫食1.Hit = value;
			}
		}

		public bool 虫食_右_虫食2_表示
		{
			get
			{
				return this.X0Y0_虫食_右_虫食2.Dra;
			}
			set
			{
				this.X0Y0_虫食_右_虫食2.Dra = value;
				this.X0Y0_虫食_右_虫食2.Hit = value;
			}
		}

		public bool 虫食_右_虫食3_表示
		{
			get
			{
				return this.X0Y0_虫食_右_虫食3.Dra;
			}
			set
			{
				this.X0Y0_虫食_右_虫食3.Dra = value;
				this.X0Y0_虫食_右_虫食3.Hit = value;
			}
		}

		public bool 虫食_右_虫食4_表示
		{
			get
			{
				return this.X0Y0_虫食_右_虫食4.Dra;
			}
			set
			{
				this.X0Y0_虫食_右_虫食4.Dra = value;
				this.X0Y0_虫食_右_虫食4.Hit = value;
			}
		}

		public bool 虫食_右_虫食5_表示
		{
			get
			{
				return this.X0Y0_虫食_右_虫食5.Dra;
			}
			set
			{
				this.X0Y0_虫食_右_虫食5.Dra = value;
				this.X0Y0_虫食_右_虫食5.Hit = value;
			}
		}

		public bool 虫食_右_虫食6_表示
		{
			get
			{
				return this.X0Y0_虫食_右_虫食6.Dra;
			}
			set
			{
				this.X0Y0_虫食_右_虫食6.Dra = value;
				this.X0Y0_虫食_右_虫食6.Hit = value;
			}
		}

		public bool 虫食_右_虫食7_表示
		{
			get
			{
				return this.X0Y0_虫食_右_虫食7.Dra;
			}
			set
			{
				this.X0Y0_虫食_右_虫食7.Dra = value;
				this.X0Y0_虫食_右_虫食7.Hit = value;
			}
		}

		public bool 虫食_右_虫食8_表示
		{
			get
			{
				return this.X0Y0_虫食_右_虫食8.Dra;
			}
			set
			{
				this.X0Y0_虫食_右_虫食8.Dra = value;
				this.X0Y0_虫食_右_虫食8.Hit = value;
			}
		}

		public bool 虫食_右_虫食9_表示
		{
			get
			{
				return this.X0Y0_虫食_右_虫食9.Dra;
			}
			set
			{
				this.X0Y0_虫食_右_虫食9.Dra = value;
				this.X0Y0_虫食_右_虫食9.Hit = value;
			}
		}

		public bool 虫食_右_虫食10_表示
		{
			get
			{
				return this.X0Y0_虫食_右_虫食10.Dra;
			}
			set
			{
				this.X0Y0_虫食_右_虫食10.Dra = value;
				this.X0Y0_虫食_右_虫食10.Hit = value;
			}
		}

		public bool 虫食_右_虫食11_表示
		{
			get
			{
				return this.X0Y0_虫食_右_虫食11.Dra;
			}
			set
			{
				this.X0Y0_虫食_右_虫食11.Dra = value;
				this.X0Y0_虫食_右_虫食11.Hit = value;
			}
		}

		public bool 虫食_右_虫食12_表示
		{
			get
			{
				return this.X0Y0_虫食_右_虫食12.Dra;
			}
			set
			{
				this.X0Y0_虫食_右_虫食12.Dra = value;
				this.X0Y0_虫食_右_虫食12.Hit = value;
			}
		}

		public bool 脚輪_革_表示
		{
			get
			{
				return this.X0Y0_脚輪_革.Dra;
			}
			set
			{
				this.X0Y0_脚輪_革.Dra = value;
				this.X0Y0_脚輪_革.Hit = value;
			}
		}

		public bool 脚輪_金具1_表示
		{
			get
			{
				return this.X0Y0_脚輪_金具1.Dra;
			}
			set
			{
				this.X0Y0_脚輪_金具1.Dra = value;
				this.X0Y0_脚輪_金具1.Hit = value;
			}
		}

		public bool 脚輪_金具2_表示
		{
			get
			{
				return this.X0Y0_脚輪_金具2.Dra;
			}
			set
			{
				this.X0Y0_脚輪_金具2.Dra = value;
				this.X0Y0_脚輪_金具2.Hit = value;
			}
		}

		public bool 脚輪_金具3_表示
		{
			get
			{
				return this.X0Y0_脚輪_金具3.Dra;
			}
			set
			{
				this.X0Y0_脚輪_金具3.Dra = value;
				this.X0Y0_脚輪_金具3.Hit = value;
			}
		}

		public bool 脚輪_金具左_表示
		{
			get
			{
				return this.X0Y0_脚輪_金具左.Dra;
			}
			set
			{
				this.X0Y0_脚輪_金具左.Dra = value;
				this.X0Y0_脚輪_金具左.Hit = value;
			}
		}

		public bool 脚輪_金具右_表示
		{
			get
			{
				return this.X0Y0_脚輪_金具右.Dra;
			}
			set
			{
				this.X0Y0_脚輪_金具右.Dra = value;
				this.X0Y0_脚輪_金具右.Hit = value;
			}
		}

		public bool 脚輪表示
		{
			get
			{
				return this.脚輪_革_表示;
			}
			set
			{
				this.脚輪_革_表示 = value;
				this.脚輪_金具1_表示 = value;
				this.脚輪_金具2_表示 = value;
				this.脚輪_金具3_表示 = value;
				this.脚輪_金具左_表示 = value;
				this.脚輪_金具右_表示 = value;
			}
		}

		public bool 鎖表示
		{
			get
			{
				return this.鎖1.表示;
			}
			set
			{
				this.鎖1.表示 = value;
				this.鎖2.表示 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.幹上_表示;
			}
			set
			{
				this.幹上_表示 = value;
				this.幹下_表示 = value;
				this.葉左_表示 = value;
				this.葉右_表示 = value;
				this.脈上1_表示 = value;
				this.脈上2_表示 = value;
				this.脈下1_表示 = value;
				this.脈下2_表示 = value;
				this.虫食_左_虫食1_表示 = value;
				this.虫食_左_虫食2_表示 = value;
				this.虫食_左_虫食3_表示 = value;
				this.虫食_左_虫食4_表示 = value;
				this.虫食_左_虫食5_表示 = value;
				this.虫食_左_虫食6_表示 = value;
				this.虫食_左_虫食7_表示 = value;
				this.虫食_左_虫食8_表示 = value;
				this.虫食_左_虫食9_表示 = value;
				this.虫食_左_虫食10_表示 = value;
				this.虫食_左_虫食11_表示 = value;
				this.虫食_左_虫食12_表示 = value;
				this.虫食_右_虫食1_表示 = value;
				this.虫食_右_虫食2_表示 = value;
				this.虫食_右_虫食3_表示 = value;
				this.虫食_右_虫食4_表示 = value;
				this.虫食_右_虫食5_表示 = value;
				this.虫食_右_虫食6_表示 = value;
				this.虫食_右_虫食7_表示 = value;
				this.虫食_右_虫食8_表示 = value;
				this.虫食_右_虫食9_表示 = value;
				this.虫食_右_虫食10_表示 = value;
				this.虫食_右_虫食11_表示 = value;
				this.虫食_右_虫食12_表示 = value;
				this.脚輪_革_表示 = value;
				this.脚輪_金具1_表示 = value;
				this.脚輪_金具2_表示 = value;
				this.脚輪_金具3_表示 = value;
				this.脚輪_金具左_表示 = value;
				this.脚輪_金具右_表示 = value;
				this.鎖1.表示 = value;
				this.鎖2.表示 = value;
			}
		}

		public override void Dispose()
		{
			base.Dispose();
			this.鎖1.Dispose();
			this.鎖2.Dispose();
		}

		public override double 濃度
		{
			get
			{
				return this.幹上CD.不透明度;
			}
			set
			{
				this.幹上CD.不透明度 = value;
				this.幹下CD.不透明度 = value;
				this.葉左CD.不透明度 = value;
				this.葉右CD.不透明度 = value;
				this.脈上1CD.不透明度 = value;
				this.脈上2CD.不透明度 = value;
				this.脈下1CD.不透明度 = value;
				this.脈下2CD.不透明度 = value;
				this.虫食_左_虫食1CD.不透明度 = value;
				this.虫食_左_虫食2CD.不透明度 = value;
				this.虫食_左_虫食3CD.不透明度 = value;
				this.虫食_左_虫食4CD.不透明度 = value;
				this.虫食_左_虫食5CD.不透明度 = value;
				this.虫食_左_虫食6CD.不透明度 = value;
				this.虫食_左_虫食7CD.不透明度 = value;
				this.虫食_左_虫食8CD.不透明度 = value;
				this.虫食_左_虫食9CD.不透明度 = value;
				this.虫食_左_虫食10CD.不透明度 = value;
				this.虫食_左_虫食11CD.不透明度 = value;
				this.虫食_左_虫食12CD.不透明度 = value;
				this.虫食_右_虫食1CD.不透明度 = value;
				this.虫食_右_虫食2CD.不透明度 = value;
				this.虫食_右_虫食3CD.不透明度 = value;
				this.虫食_右_虫食4CD.不透明度 = value;
				this.虫食_右_虫食5CD.不透明度 = value;
				this.虫食_右_虫食6CD.不透明度 = value;
				this.虫食_右_虫食7CD.不透明度 = value;
				this.虫食_右_虫食8CD.不透明度 = value;
				this.虫食_右_虫食9CD.不透明度 = value;
				this.虫食_右_虫食10CD.不透明度 = value;
				this.虫食_右_虫食11CD.不透明度 = value;
				this.虫食_右_虫食12CD.不透明度 = value;
				this.脚輪_革CD.不透明度 = value;
				this.脚輪_金具1CD.不透明度 = value;
				this.脚輪_金具2CD.不透明度 = value;
				this.脚輪_金具3CD.不透明度 = value;
				this.脚輪_金具左CD.不透明度 = value;
				this.脚輪_金具右CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			bool 右 = this.右;
			this.X0Y0_幹下.AngleBase = 10.0.GetRanAngle();
			this.本体.JoinPAall();
		}

		public override void 描画0(Are Are)
		{
			this.本体.Draw(Are);
			this.鎖1.描画0(Are);
			this.鎖2.描画0(Are);
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_脚輪_革 || p == this.X0Y0_脚輪_金具1 || p == this.X0Y0_脚輪_金具2 || p == this.X0Y0_脚輪_金具3 || p == this.X0Y0_脚輪_金具左 || p == this.X0Y0_脚輪_金具右;
		}

		public JointS 根外左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_幹下, 0);
			}
		}

		public JointS 根内左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_幹下, 1);
			}
		}

		public JointS 根中央_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_幹下, 2);
			}
		}

		public JointS 根内右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_幹下, 3);
			}
		}

		public JointS 根外右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_幹下, 4);
			}
		}

		public JointS 鎖1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_脚輪_金具左, 0);
			}
		}

		public JointS 鎖2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_脚輪_金具右, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_幹上CP.Update();
			this.X0Y0_幹下CP.Update();
			this.X0Y0_葉左CP.Update();
			this.X0Y0_葉右CP.Update();
			this.X0Y0_脈上1CP.Update();
			this.X0Y0_脈上2CP.Update();
			this.X0Y0_脈下1CP.Update();
			this.X0Y0_脈下2CP.Update();
			this.X0Y0_虫食_左_虫食1CP.Update();
			this.X0Y0_虫食_左_虫食2CP.Update();
			this.X0Y0_虫食_左_虫食3CP.Update();
			this.X0Y0_虫食_左_虫食4CP.Update();
			this.X0Y0_虫食_左_虫食5CP.Update();
			this.X0Y0_虫食_左_虫食6CP.Update();
			this.X0Y0_虫食_左_虫食7CP.Update();
			this.X0Y0_虫食_左_虫食8CP.Update();
			this.X0Y0_虫食_左_虫食9CP.Update();
			this.X0Y0_虫食_左_虫食10CP.Update();
			this.X0Y0_虫食_左_虫食11CP.Update();
			this.X0Y0_虫食_左_虫食12CP.Update();
			this.X0Y0_虫食_右_虫食1CP.Update();
			this.X0Y0_虫食_右_虫食2CP.Update();
			this.X0Y0_虫食_右_虫食3CP.Update();
			this.X0Y0_虫食_右_虫食4CP.Update();
			this.X0Y0_虫食_右_虫食5CP.Update();
			this.X0Y0_虫食_右_虫食6CP.Update();
			this.X0Y0_虫食_右_虫食7CP.Update();
			this.X0Y0_虫食_右_虫食8CP.Update();
			this.X0Y0_虫食_右_虫食9CP.Update();
			this.X0Y0_虫食_右_虫食10CP.Update();
			this.X0Y0_虫食_右_虫食11CP.Update();
			this.X0Y0_虫食_右_虫食12CP.Update();
			this.X0Y0_脚輪_革CP.Update();
			this.X0Y0_脚輪_金具1CP.Update();
			this.X0Y0_脚輪_金具2CP.Update();
			this.X0Y0_脚輪_金具3CP.Update();
			this.X0Y0_脚輪_金具左CP.Update();
			this.X0Y0_脚輪_金具右CP.Update();
			this.鎖1.接続P();
			this.鎖2.接続P();
			this.鎖1.色更新();
			this.鎖2.色更新();
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
			this.幹上CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.幹下CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.葉左CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.葉右CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.脈上1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.脈上2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.脈下1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.脈下2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.虫食_左_虫食1CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.虫食_左_虫食2CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.虫食_左_虫食3CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.虫食_左_虫食4CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.虫食_左_虫食5CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.虫食_左_虫食6CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.虫食_左_虫食7CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.虫食_左_虫食8CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.虫食_左_虫食9CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.虫食_左_虫食10CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.虫食_左_虫食11CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.虫食_左_虫食12CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.虫食_右_虫食1CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.虫食_右_虫食2CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.虫食_右_虫食3CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.虫食_右_虫食4CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.虫食_右_虫食5CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.虫食_右_虫食6CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.虫食_右_虫食7CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.虫食_右_虫食8CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.虫食_右_虫食9CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.虫食_右_虫食10CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.虫食_右_虫食11CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.虫食_右_虫食12CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.脚輪_革CD = new ColorD();
			this.脚輪_金具1CD = new ColorD();
			this.脚輪_金具2CD = new ColorD();
			this.脚輪_金具3CD = new ColorD();
			this.脚輪_金具左CD = new ColorD();
			this.脚輪_金具右CD = new ColorD();
		}

		private void 配色T1(体配色 体配色)
		{
			this.幹上CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.幹下CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.葉左CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.葉右CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.脈上1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.脈上2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.脈下1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.脈下2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.虫食_左_虫食1CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_左_虫食2CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_左_虫食3CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_左_虫食4CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_左_虫食5CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_左_虫食6CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_左_虫食7CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_左_虫食8CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_左_虫食9CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_左_虫食10CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_左_虫食11CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_左_虫食12CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食1CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食2CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食3CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食4CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食5CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食6CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食7CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食8CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食9CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食10CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食11CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食12CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.脚輪_革CD = new ColorD();
			this.脚輪_金具1CD = new ColorD();
			this.脚輪_金具2CD = new ColorD();
			this.脚輪_金具3CD = new ColorD();
			this.脚輪_金具左CD = new ColorD();
			this.脚輪_金具右CD = new ColorD();
		}

		private void 配色T0(体配色 体配色)
		{
			this.幹上CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.幹下CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.葉左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.葉右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脈上1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.脈上2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.脈下1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.脈下2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.虫食_左_虫食1CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_左_虫食2CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_左_虫食3CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_左_虫食4CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_左_虫食5CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_左_虫食6CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_左_虫食7CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_左_虫食8CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_左_虫食9CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_左_虫食10CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_左_虫食11CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_左_虫食12CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食1CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食2CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食3CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食4CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食5CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食6CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食7CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食8CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食9CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食10CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食11CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.虫食_右_虫食12CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.脚輪_革CD = new ColorD();
			this.脚輪_金具1CD = new ColorD();
			this.脚輪_金具2CD = new ColorD();
			this.脚輪_金具3CD = new ColorD();
			this.脚輪_金具左CD = new ColorD();
			this.脚輪_金具右CD = new ColorD();
		}

		public void 脚輪配色(拘束具色 配色)
		{
			this.脚輪_革CD.色 = 配色.革部色;
			this.脚輪_金具1CD.色 = 配色.金具色;
			this.脚輪_金具2CD.色 = this.脚輪_金具1CD.色;
			this.脚輪_金具3CD.色 = this.脚輪_金具1CD.色;
			this.脚輪_金具左CD.色 = this.脚輪_金具1CD.色;
			this.脚輪_金具右CD.色 = this.脚輪_金具1CD.色;
		}

		public void 鎖配色(鎖色 配色)
		{
			this.鎖1.配色鎖(配色);
			this.鎖2.配色鎖(配色);
		}

		public override IEnumerable<Ele> EnumEle()
		{
			yield return this;
			if (this.根外左_接続 != null)
			{
				foreach (Ele ele in (from e in this.根外左_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.根外右_接続 != null)
			{
				foreach (Ele ele2 in (from e in this.根外右_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele2;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.根内左_接続 != null)
			{
				foreach (Ele ele3 in (from e in this.根内左_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele3;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.根内右_接続 != null)
			{
				foreach (Ele ele4 in (from e in this.根内右_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele4;
				}
				IEnumerator<Ele> enumerator = null;
			}
			if (this.根中央_接続 != null)
			{
				foreach (Ele ele5 in (from e in this.根中央_接続
				select e.EnumEle()).JoinEnum<Ele>())
				{
					yield return ele5;
				}
				IEnumerator<Ele> enumerator = null;
			}
			yield break;
			yield break;
		}

		public Par X0Y0_幹上;

		public Par X0Y0_幹下;

		public Par X0Y0_葉左;

		public Par X0Y0_葉右;

		public Par X0Y0_脈上1;

		public Par X0Y0_脈上2;

		public Par X0Y0_脈下1;

		public Par X0Y0_脈下2;

		public Par X0Y0_虫食_左_虫食1;

		public Par X0Y0_虫食_左_虫食2;

		public Par X0Y0_虫食_左_虫食3;

		public Par X0Y0_虫食_左_虫食4;

		public Par X0Y0_虫食_左_虫食5;

		public Par X0Y0_虫食_左_虫食6;

		public Par X0Y0_虫食_左_虫食7;

		public Par X0Y0_虫食_左_虫食8;

		public Par X0Y0_虫食_左_虫食9;

		public Par X0Y0_虫食_左_虫食10;

		public Par X0Y0_虫食_左_虫食11;

		public Par X0Y0_虫食_左_虫食12;

		public Par X0Y0_虫食_右_虫食1;

		public Par X0Y0_虫食_右_虫食2;

		public Par X0Y0_虫食_右_虫食3;

		public Par X0Y0_虫食_右_虫食4;

		public Par X0Y0_虫食_右_虫食5;

		public Par X0Y0_虫食_右_虫食6;

		public Par X0Y0_虫食_右_虫食7;

		public Par X0Y0_虫食_右_虫食8;

		public Par X0Y0_虫食_右_虫食9;

		public Par X0Y0_虫食_右_虫食10;

		public Par X0Y0_虫食_右_虫食11;

		public Par X0Y0_虫食_右_虫食12;

		public Par X0Y0_脚輪_革;

		public Par X0Y0_脚輪_金具1;

		public Par X0Y0_脚輪_金具2;

		public Par X0Y0_脚輪_金具3;

		public Par X0Y0_脚輪_金具左;

		public Par X0Y0_脚輪_金具右;

		public ColorD 幹上CD;

		public ColorD 幹下CD;

		public ColorD 葉左CD;

		public ColorD 葉右CD;

		public ColorD 脈上1CD;

		public ColorD 脈上2CD;

		public ColorD 脈下1CD;

		public ColorD 脈下2CD;

		public ColorD 虫食_左_虫食1CD;

		public ColorD 虫食_左_虫食2CD;

		public ColorD 虫食_左_虫食3CD;

		public ColorD 虫食_左_虫食4CD;

		public ColorD 虫食_左_虫食5CD;

		public ColorD 虫食_左_虫食6CD;

		public ColorD 虫食_左_虫食7CD;

		public ColorD 虫食_左_虫食8CD;

		public ColorD 虫食_左_虫食9CD;

		public ColorD 虫食_左_虫食10CD;

		public ColorD 虫食_左_虫食11CD;

		public ColorD 虫食_左_虫食12CD;

		public ColorD 虫食_右_虫食1CD;

		public ColorD 虫食_右_虫食2CD;

		public ColorD 虫食_右_虫食3CD;

		public ColorD 虫食_右_虫食4CD;

		public ColorD 虫食_右_虫食5CD;

		public ColorD 虫食_右_虫食6CD;

		public ColorD 虫食_右_虫食7CD;

		public ColorD 虫食_右_虫食8CD;

		public ColorD 虫食_右_虫食9CD;

		public ColorD 虫食_右_虫食10CD;

		public ColorD 虫食_右_虫食11CD;

		public ColorD 虫食_右_虫食12CD;

		public ColorD 脚輪_革CD;

		public ColorD 脚輪_金具1CD;

		public ColorD 脚輪_金具2CD;

		public ColorD 脚輪_金具3CD;

		public ColorD 脚輪_金具左CD;

		public ColorD 脚輪_金具右CD;

		public ColorP X0Y0_幹上CP;

		public ColorP X0Y0_幹下CP;

		public ColorP X0Y0_葉左CP;

		public ColorP X0Y0_葉右CP;

		public ColorP X0Y0_脈上1CP;

		public ColorP X0Y0_脈上2CP;

		public ColorP X0Y0_脈下1CP;

		public ColorP X0Y0_脈下2CP;

		public ColorP X0Y0_虫食_左_虫食1CP;

		public ColorP X0Y0_虫食_左_虫食2CP;

		public ColorP X0Y0_虫食_左_虫食3CP;

		public ColorP X0Y0_虫食_左_虫食4CP;

		public ColorP X0Y0_虫食_左_虫食5CP;

		public ColorP X0Y0_虫食_左_虫食6CP;

		public ColorP X0Y0_虫食_左_虫食7CP;

		public ColorP X0Y0_虫食_左_虫食8CP;

		public ColorP X0Y0_虫食_左_虫食9CP;

		public ColorP X0Y0_虫食_左_虫食10CP;

		public ColorP X0Y0_虫食_左_虫食11CP;

		public ColorP X0Y0_虫食_左_虫食12CP;

		public ColorP X0Y0_虫食_右_虫食1CP;

		public ColorP X0Y0_虫食_右_虫食2CP;

		public ColorP X0Y0_虫食_右_虫食3CP;

		public ColorP X0Y0_虫食_右_虫食4CP;

		public ColorP X0Y0_虫食_右_虫食5CP;

		public ColorP X0Y0_虫食_右_虫食6CP;

		public ColorP X0Y0_虫食_右_虫食7CP;

		public ColorP X0Y0_虫食_右_虫食8CP;

		public ColorP X0Y0_虫食_右_虫食9CP;

		public ColorP X0Y0_虫食_右_虫食10CP;

		public ColorP X0Y0_虫食_右_虫食11CP;

		public ColorP X0Y0_虫食_右_虫食12CP;

		public ColorP X0Y0_脚輪_革CP;

		public ColorP X0Y0_脚輪_金具1CP;

		public ColorP X0Y0_脚輪_金具2CP;

		public ColorP X0Y0_脚輪_金具3CP;

		public ColorP X0Y0_脚輪_金具左CP;

		public ColorP X0Y0_脚輪_金具右CP;

		public 拘束鎖 鎖1;

		public 拘束鎖 鎖2;

		public Ele[] 根外左_接続;

		public Ele[] 根内左_接続;

		public Ele[] 根中央_接続;

		public Ele[] 根内右_接続;

		public Ele[] 根外右_接続;
	}
}
