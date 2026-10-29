using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 植 : Ele
	{
		public 植(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 植D e)
		{
			植.<>c__DisplayClass81_0 CS$<>8__locals1 = new 植.<>c__DisplayClass81_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Pars pars = new Pars(Sta.肢左["植"][0][0]);
			pars.Remove("花");
			pars.Remove("萼");
			Dif dif = new Dif();
			dif.Tag = "植";
			dif.Add(pars);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars2 = this.本体[0][0];
			Pars pars3 = pars2["通常葉4"].ToPars();
			Pars pars4 = pars3["通常"].ToPars();
			this.X0Y0_披針葉4_通常_葉 = pars4["葉"].ToPar();
			this.X0Y0_披針葉4_通常_葉脈 = pars4["葉脈"].ToPar();
			pars4 = pars3["欠損"].ToPars();
			this.X0Y0_披針葉4_欠損_葉 = pars4["葉"].ToPar();
			this.X0Y0_披針葉4_欠損_葉脈 = pars4["葉脈"].ToPar();
			Pars pars5 = pars2["ハート葉4"].ToPars();
			pars4 = pars5["通常"].ToPars();
			this.X0Y0_心臓葉4_通常_葉 = pars4["葉"].ToPar();
			this.X0Y0_心臓葉4_通常_葉脈 = pars4["葉脈"].ToPar();
			pars4 = pars5["欠損"].ToPars();
			this.X0Y0_心臓葉4_欠損_葉 = pars4["葉"].ToPar();
			this.X0Y0_心臓葉4_欠損_葉脈 = pars4["葉脈"].ToPar();
			this.X0Y0_茎 = pars2["茎"].ToPar();
			this.X0Y0_根1 = pars2["根1"].ToPar();
			this.X0Y0_根2 = pars2["根2"].ToPar();
			Pars pars6 = pars2["通常葉1"].ToPars();
			pars4 = pars6["通常"].ToPars();
			this.X0Y0_披針葉1_通常_葉 = pars4["葉"].ToPar();
			this.X0Y0_披針葉1_通常_葉脈 = pars4["葉脈"].ToPar();
			pars4 = pars6["欠損"].ToPars();
			this.X0Y0_披針葉1_欠損_葉 = pars4["葉"].ToPar();
			this.X0Y0_披針葉1_欠損_葉脈 = pars4["葉脈"].ToPar();
			Pars pars7 = pars2["通常葉2"].ToPars();
			pars4 = pars7["通常"].ToPars();
			this.X0Y0_披針葉2_通常_葉 = pars4["葉"].ToPar();
			this.X0Y0_披針葉2_通常_葉脈 = pars4["葉脈"].ToPar();
			pars4 = pars7["欠損"].ToPars();
			this.X0Y0_披針葉2_欠損_葉 = pars4["葉"].ToPar();
			this.X0Y0_披針葉2_欠損_葉脈 = pars4["葉脈"].ToPar();
			Pars pars8 = pars2["通常葉3"].ToPars();
			pars4 = pars8["通常"].ToPars();
			this.X0Y0_披針葉3_通常_葉 = pars4["葉"].ToPar();
			this.X0Y0_披針葉3_通常_葉脈 = pars4["葉脈"].ToPar();
			pars4 = pars8["欠損"].ToPars();
			this.X0Y0_披針葉3_欠損_葉 = pars4["葉"].ToPar();
			this.X0Y0_披針葉3_欠損_葉脈 = pars4["葉脈"].ToPar();
			Pars pars9 = pars2["ハート葉1"].ToPars();
			pars4 = pars9["通常"].ToPars();
			this.X0Y0_心臓葉1_通常_葉 = pars4["葉"].ToPar();
			this.X0Y0_心臓葉1_通常_葉脈 = pars4["葉脈"].ToPar();
			pars4 = pars9["欠損"].ToPars();
			this.X0Y0_心臓葉1_欠損_葉 = pars4["葉"].ToPar();
			this.X0Y0_心臓葉1_欠損_葉脈 = pars4["葉脈"].ToPar();
			Pars pars10 = pars2["ハート葉2"].ToPars();
			pars4 = pars10["通常"].ToPars();
			this.X0Y0_心臓葉2_通常_葉 = pars4["葉"].ToPar();
			this.X0Y0_心臓葉2_通常_葉脈 = pars4["葉脈"].ToPar();
			pars4 = pars10["欠損"].ToPars();
			this.X0Y0_心臓葉2_欠損_葉 = pars4["葉"].ToPar();
			this.X0Y0_心臓葉2_欠損_葉脈 = pars4["葉脈"].ToPar();
			Pars pars11 = pars2["ハート葉3"].ToPars();
			pars4 = pars11["通常"].ToPars();
			this.X0Y0_心臓葉3_通常_葉 = pars4["葉"].ToPar();
			this.X0Y0_心臓葉3_通常_葉脈 = pars4["葉脈"].ToPar();
			pars4 = pars11["欠損"].ToPars();
			this.X0Y0_心臓葉3_欠損_葉 = pars4["葉"].ToPar();
			this.X0Y0_心臓葉3_欠損_葉脈 = pars4["葉脈"].ToPar();
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
			this.披針葉4_通常_葉_表示 = e.披針葉4_通常_葉_表示;
			this.披針葉4_通常_葉脈_表示 = e.披針葉4_通常_葉脈_表示;
			this.披針葉4_欠損_葉_表示 = e.披針葉4_欠損_葉_表示;
			this.披針葉4_欠損_葉脈_表示 = e.披針葉4_欠損_葉脈_表示;
			this.心臓葉4_通常_葉_表示 = e.心臓葉4_通常_葉_表示;
			this.心臓葉4_通常_葉脈_表示 = e.心臓葉4_通常_葉脈_表示;
			this.心臓葉4_欠損_葉_表示 = e.心臓葉4_欠損_葉_表示;
			this.心臓葉4_欠損_葉脈_表示 = e.心臓葉4_欠損_葉脈_表示;
			this.茎_表示 = e.茎_表示;
			this.根1_表示 = e.根1_表示;
			this.根2_表示 = e.根2_表示;
			this.披針葉1_通常_葉_表示 = e.披針葉1_通常_葉_表示;
			this.披針葉1_通常_葉脈_表示 = e.披針葉1_通常_葉脈_表示;
			this.披針葉1_欠損_葉_表示 = e.披針葉1_欠損_葉_表示;
			this.披針葉1_欠損_葉脈_表示 = e.披針葉1_欠損_葉脈_表示;
			this.披針葉2_通常_葉_表示 = e.披針葉2_通常_葉_表示;
			this.披針葉2_通常_葉脈_表示 = e.披針葉2_通常_葉脈_表示;
			this.披針葉2_欠損_葉_表示 = e.披針葉2_欠損_葉_表示;
			this.披針葉2_欠損_葉脈_表示 = e.披針葉2_欠損_葉脈_表示;
			this.披針葉3_通常_葉_表示 = e.披針葉3_通常_葉_表示;
			this.披針葉3_通常_葉脈_表示 = e.披針葉3_通常_葉脈_表示;
			this.披針葉3_欠損_葉_表示 = e.披針葉3_欠損_葉_表示;
			this.披針葉3_欠損_葉脈_表示 = e.披針葉3_欠損_葉脈_表示;
			this.心臓葉1_通常_葉_表示 = e.心臓葉1_通常_葉_表示;
			this.心臓葉1_通常_葉脈_表示 = e.心臓葉1_通常_葉脈_表示;
			this.心臓葉1_欠損_葉_表示 = e.心臓葉1_欠損_葉_表示;
			this.心臓葉1_欠損_葉脈_表示 = e.心臓葉1_欠損_葉脈_表示;
			this.心臓葉2_通常_葉_表示 = e.心臓葉2_通常_葉_表示;
			this.心臓葉2_通常_葉脈_表示 = e.心臓葉2_通常_葉脈_表示;
			this.心臓葉2_欠損_葉_表示 = e.心臓葉2_欠損_葉_表示;
			this.心臓葉2_欠損_葉脈_表示 = e.心臓葉2_欠損_葉脈_表示;
			this.心臓葉3_通常_葉_表示 = e.心臓葉3_通常_葉_表示;
			this.心臓葉3_通常_葉脈_表示 = e.心臓葉3_通常_葉脈_表示;
			this.心臓葉3_欠損_葉_表示 = e.心臓葉3_欠損_葉_表示;
			this.心臓葉3_欠損_葉脈_表示 = e.心臓葉3_欠損_葉脈_表示;
			this.披針葉4_葉_表示 = e.披針葉4_葉_表示;
			this.披針葉4_葉脈_表示 = e.披針葉4_葉脈_表示;
			this.心臓葉4_葉_表示 = e.心臓葉4_葉_表示;
			this.心臓葉4_葉脈_表示 = e.心臓葉4_葉脈_表示;
			this.披針葉1_葉_表示 = e.披針葉1_葉_表示;
			this.披針葉1_葉脈_表示 = e.披針葉1_葉脈_表示;
			this.披針葉2_葉_表示 = e.披針葉2_葉_表示;
			this.披針葉2_葉脈_表示 = e.披針葉2_葉脈_表示;
			this.披針葉3_葉_表示 = e.披針葉3_葉_表示;
			this.披針葉3_葉脈_表示 = e.披針葉3_葉脈_表示;
			this.心臓葉1_葉_表示 = e.心臓葉1_葉_表示;
			this.心臓葉1_葉脈_表示 = e.心臓葉1_葉脈_表示;
			this.心臓葉2_葉_表示 = e.心臓葉2_葉_表示;
			this.心臓葉2_葉脈_表示 = e.心臓葉2_葉脈_表示;
			this.心臓葉3_葉_表示 = e.心臓葉3_葉_表示;
			this.心臓葉3_葉脈_表示 = e.心臓葉3_葉脈_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.花_接続.Count > 0)
			{
				Ele f;
				this.花_接続 = e.花_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.植_花_接続;
					f.接続(CS$<>8__locals1.<>4__this.花_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_披針葉4_通常_葉CP = new ColorP(this.X0Y0_披針葉4_通常_葉, this.葉4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_披針葉4_通常_葉脈CP = new ColorP(this.X0Y0_披針葉4_通常_葉脈, this.葉脈4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_披針葉4_欠損_葉CP = new ColorP(this.X0Y0_披針葉4_欠損_葉, this.葉4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_披針葉4_欠損_葉脈CP = new ColorP(this.X0Y0_披針葉4_欠損_葉脈, this.葉脈4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_心臓葉4_通常_葉CP = new ColorP(this.X0Y0_心臓葉4_通常_葉, this.葉4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_心臓葉4_通常_葉脈CP = new ColorP(this.X0Y0_心臓葉4_通常_葉脈, this.葉脈4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_心臓葉4_欠損_葉CP = new ColorP(this.X0Y0_心臓葉4_欠損_葉, this.葉4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_心臓葉4_欠損_葉脈CP = new ColorP(this.X0Y0_心臓葉4_欠損_葉脈, this.葉脈4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_茎CP = new ColorP(this.X0Y0_茎, this.茎CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_根1CP = new ColorP(this.X0Y0_根1, this.根1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_根2CP = new ColorP(this.X0Y0_根2, this.根2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_披針葉1_通常_葉CP = new ColorP(this.X0Y0_披針葉1_通常_葉, this.葉1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_披針葉1_通常_葉脈CP = new ColorP(this.X0Y0_披針葉1_通常_葉脈, this.葉脈1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_披針葉1_欠損_葉CP = new ColorP(this.X0Y0_披針葉1_欠損_葉, this.葉1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_披針葉1_欠損_葉脈CP = new ColorP(this.X0Y0_披針葉1_欠損_葉脈, this.葉脈1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_披針葉2_通常_葉CP = new ColorP(this.X0Y0_披針葉2_通常_葉, this.葉2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_披針葉2_通常_葉脈CP = new ColorP(this.X0Y0_披針葉2_通常_葉脈, this.葉脈2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_披針葉2_欠損_葉CP = new ColorP(this.X0Y0_披針葉2_欠損_葉, this.葉2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_披針葉2_欠損_葉脈CP = new ColorP(this.X0Y0_披針葉2_欠損_葉脈, this.葉脈2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_披針葉3_通常_葉CP = new ColorP(this.X0Y0_披針葉3_通常_葉, this.葉3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_披針葉3_通常_葉脈CP = new ColorP(this.X0Y0_披針葉3_通常_葉脈, this.葉脈3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_披針葉3_欠損_葉CP = new ColorP(this.X0Y0_披針葉3_欠損_葉, this.葉3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_披針葉3_欠損_葉脈CP = new ColorP(this.X0Y0_披針葉3_欠損_葉脈, this.葉脈3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_心臓葉1_通常_葉CP = new ColorP(this.X0Y0_心臓葉1_通常_葉, this.葉1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_心臓葉1_通常_葉脈CP = new ColorP(this.X0Y0_心臓葉1_通常_葉脈, this.葉脈1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_心臓葉1_欠損_葉CP = new ColorP(this.X0Y0_心臓葉1_欠損_葉, this.葉1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_心臓葉1_欠損_葉脈CP = new ColorP(this.X0Y0_心臓葉1_欠損_葉脈, this.葉脈1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_心臓葉2_通常_葉CP = new ColorP(this.X0Y0_心臓葉2_通常_葉, this.葉2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_心臓葉2_通常_葉脈CP = new ColorP(this.X0Y0_心臓葉2_通常_葉脈, this.葉脈2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_心臓葉2_欠損_葉CP = new ColorP(this.X0Y0_心臓葉2_欠損_葉, this.葉2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_心臓葉2_欠損_葉脈CP = new ColorP(this.X0Y0_心臓葉2_欠損_葉脈, this.葉脈2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_心臓葉3_通常_葉CP = new ColorP(this.X0Y0_心臓葉3_通常_葉, this.葉3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_心臓葉3_通常_葉脈CP = new ColorP(this.X0Y0_心臓葉3_通常_葉脈, this.葉脈3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_心臓葉3_欠損_葉CP = new ColorP(this.X0Y0_心臓葉3_欠損_葉, this.葉3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_心臓葉3_欠損_葉脈CP = new ColorP(this.X0Y0_心臓葉3_欠損_葉脈, this.葉脈3CD, CS$<>8__locals1.DisUnit, true);
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
				this.披針葉4_葉_表示 = this.披針葉4_葉_表示;
				this.披針葉4_葉脈_表示 = this.披針葉4_葉脈_表示;
				this.心臓葉4_葉_表示 = this.心臓葉4_葉_表示;
				this.心臓葉4_葉脈_表示 = this.心臓葉4_葉脈_表示;
				this.披針葉1_葉_表示 = this.披針葉1_葉_表示;
				this.披針葉1_葉脈_表示 = this.披針葉1_葉脈_表示;
				this.披針葉2_葉_表示 = this.披針葉2_葉_表示;
				this.披針葉2_葉脈_表示 = this.披針葉2_葉脈_表示;
				this.披針葉3_葉_表示 = this.披針葉3_葉_表示;
				this.披針葉3_葉脈_表示 = this.披針葉3_葉脈_表示;
				this.心臓葉1_葉_表示 = this.心臓葉1_葉_表示;
				this.心臓葉1_葉脈_表示 = this.心臓葉1_葉脈_表示;
				this.心臓葉2_葉_表示 = this.心臓葉2_葉_表示;
				this.心臓葉2_葉脈_表示 = this.心臓葉2_葉脈_表示;
				this.心臓葉3_葉_表示 = this.心臓葉3_葉_表示;
				this.心臓葉3_葉脈_表示 = this.心臓葉3_葉脈_表示;
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

		public bool 披針葉4_通常_葉_表示
		{
			get
			{
				return this.X0Y0_披針葉4_通常_葉.Dra;
			}
			set
			{
				this.X0Y0_披針葉4_通常_葉.Dra = value;
				this.X0Y0_披針葉4_通常_葉.Hit = value;
			}
		}

		public bool 披針葉4_通常_葉脈_表示
		{
			get
			{
				return this.X0Y0_披針葉4_通常_葉脈.Dra;
			}
			set
			{
				this.X0Y0_披針葉4_通常_葉脈.Dra = value;
				this.X0Y0_披針葉4_通常_葉脈.Hit = value;
			}
		}

		public bool 披針葉4_欠損_葉_表示
		{
			get
			{
				return this.X0Y0_披針葉4_欠損_葉.Dra;
			}
			set
			{
				this.X0Y0_披針葉4_欠損_葉.Dra = value;
				this.X0Y0_披針葉4_欠損_葉.Hit = value;
			}
		}

		public bool 披針葉4_欠損_葉脈_表示
		{
			get
			{
				return this.X0Y0_披針葉4_欠損_葉脈.Dra;
			}
			set
			{
				this.X0Y0_披針葉4_欠損_葉脈.Dra = value;
				this.X0Y0_披針葉4_欠損_葉脈.Hit = value;
			}
		}

		public bool 心臓葉4_通常_葉_表示
		{
			get
			{
				return this.X0Y0_心臓葉4_通常_葉.Dra;
			}
			set
			{
				this.X0Y0_心臓葉4_通常_葉.Dra = value;
				this.X0Y0_心臓葉4_通常_葉.Hit = value;
			}
		}

		public bool 心臓葉4_通常_葉脈_表示
		{
			get
			{
				return this.X0Y0_心臓葉4_通常_葉脈.Dra;
			}
			set
			{
				this.X0Y0_心臓葉4_通常_葉脈.Dra = value;
				this.X0Y0_心臓葉4_通常_葉脈.Hit = value;
			}
		}

		public bool 心臓葉4_欠損_葉_表示
		{
			get
			{
				return this.X0Y0_心臓葉4_欠損_葉.Dra;
			}
			set
			{
				this.X0Y0_心臓葉4_欠損_葉.Dra = value;
				this.X0Y0_心臓葉4_欠損_葉.Hit = value;
			}
		}

		public bool 心臓葉4_欠損_葉脈_表示
		{
			get
			{
				return this.X0Y0_心臓葉4_欠損_葉脈.Dra;
			}
			set
			{
				this.X0Y0_心臓葉4_欠損_葉脈.Dra = value;
				this.X0Y0_心臓葉4_欠損_葉脈.Hit = value;
			}
		}

		public bool 茎_表示
		{
			get
			{
				return this.X0Y0_茎.Dra;
			}
			set
			{
				this.X0Y0_茎.Dra = value;
				this.X0Y0_茎.Hit = value;
			}
		}

		public bool 根1_表示
		{
			get
			{
				return this.X0Y0_根1.Dra;
			}
			set
			{
				this.X0Y0_根1.Dra = value;
				this.X0Y0_根1.Hit = value;
			}
		}

		public bool 根2_表示
		{
			get
			{
				return this.X0Y0_根2.Dra;
			}
			set
			{
				this.X0Y0_根2.Dra = value;
				this.X0Y0_根2.Hit = value;
			}
		}

		public bool 披針葉1_通常_葉_表示
		{
			get
			{
				return this.X0Y0_披針葉1_通常_葉.Dra;
			}
			set
			{
				this.X0Y0_披針葉1_通常_葉.Dra = value;
				this.X0Y0_披針葉1_通常_葉.Hit = value;
			}
		}

		public bool 披針葉1_通常_葉脈_表示
		{
			get
			{
				return this.X0Y0_披針葉1_通常_葉脈.Dra;
			}
			set
			{
				this.X0Y0_披針葉1_通常_葉脈.Dra = value;
				this.X0Y0_披針葉1_通常_葉脈.Hit = value;
			}
		}

		public bool 披針葉1_欠損_葉_表示
		{
			get
			{
				return this.X0Y0_披針葉1_欠損_葉.Dra;
			}
			set
			{
				this.X0Y0_披針葉1_欠損_葉.Dra = value;
				this.X0Y0_披針葉1_欠損_葉.Hit = value;
			}
		}

		public bool 披針葉1_欠損_葉脈_表示
		{
			get
			{
				return this.X0Y0_披針葉1_欠損_葉脈.Dra;
			}
			set
			{
				this.X0Y0_披針葉1_欠損_葉脈.Dra = value;
				this.X0Y0_披針葉1_欠損_葉脈.Hit = value;
			}
		}

		public bool 披針葉2_通常_葉_表示
		{
			get
			{
				return this.X0Y0_披針葉2_通常_葉.Dra;
			}
			set
			{
				this.X0Y0_披針葉2_通常_葉.Dra = value;
				this.X0Y0_披針葉2_通常_葉.Hit = value;
			}
		}

		public bool 披針葉2_通常_葉脈_表示
		{
			get
			{
				return this.X0Y0_披針葉2_通常_葉脈.Dra;
			}
			set
			{
				this.X0Y0_披針葉2_通常_葉脈.Dra = value;
				this.X0Y0_披針葉2_通常_葉脈.Hit = value;
			}
		}

		public bool 披針葉2_欠損_葉_表示
		{
			get
			{
				return this.X0Y0_披針葉2_欠損_葉.Dra;
			}
			set
			{
				this.X0Y0_披針葉2_欠損_葉.Dra = value;
				this.X0Y0_披針葉2_欠損_葉.Hit = value;
			}
		}

		public bool 披針葉2_欠損_葉脈_表示
		{
			get
			{
				return this.X0Y0_披針葉2_欠損_葉脈.Dra;
			}
			set
			{
				this.X0Y0_披針葉2_欠損_葉脈.Dra = value;
				this.X0Y0_披針葉2_欠損_葉脈.Hit = value;
			}
		}

		public bool 披針葉3_通常_葉_表示
		{
			get
			{
				return this.X0Y0_披針葉3_通常_葉.Dra;
			}
			set
			{
				this.X0Y0_披針葉3_通常_葉.Dra = value;
				this.X0Y0_披針葉3_通常_葉.Hit = value;
			}
		}

		public bool 披針葉3_通常_葉脈_表示
		{
			get
			{
				return this.X0Y0_披針葉3_通常_葉脈.Dra;
			}
			set
			{
				this.X0Y0_披針葉3_通常_葉脈.Dra = value;
				this.X0Y0_披針葉3_通常_葉脈.Hit = value;
			}
		}

		public bool 披針葉3_欠損_葉_表示
		{
			get
			{
				return this.X0Y0_披針葉3_欠損_葉.Dra;
			}
			set
			{
				this.X0Y0_披針葉3_欠損_葉.Dra = value;
				this.X0Y0_披針葉3_欠損_葉.Hit = value;
			}
		}

		public bool 披針葉3_欠損_葉脈_表示
		{
			get
			{
				return this.X0Y0_披針葉3_欠損_葉脈.Dra;
			}
			set
			{
				this.X0Y0_披針葉3_欠損_葉脈.Dra = value;
				this.X0Y0_披針葉3_欠損_葉脈.Hit = value;
			}
		}

		public bool 心臓葉1_通常_葉_表示
		{
			get
			{
				return this.X0Y0_心臓葉1_通常_葉.Dra;
			}
			set
			{
				this.X0Y0_心臓葉1_通常_葉.Dra = value;
				this.X0Y0_心臓葉1_通常_葉.Hit = value;
			}
		}

		public bool 心臓葉1_通常_葉脈_表示
		{
			get
			{
				return this.X0Y0_心臓葉1_通常_葉脈.Dra;
			}
			set
			{
				this.X0Y0_心臓葉1_通常_葉脈.Dra = value;
				this.X0Y0_心臓葉1_通常_葉脈.Hit = value;
			}
		}

		public bool 心臓葉1_欠損_葉_表示
		{
			get
			{
				return this.X0Y0_心臓葉1_欠損_葉.Dra;
			}
			set
			{
				this.X0Y0_心臓葉1_欠損_葉.Dra = value;
				this.X0Y0_心臓葉1_欠損_葉.Hit = value;
			}
		}

		public bool 心臓葉1_欠損_葉脈_表示
		{
			get
			{
				return this.X0Y0_心臓葉1_欠損_葉脈.Dra;
			}
			set
			{
				this.X0Y0_心臓葉1_欠損_葉脈.Dra = value;
				this.X0Y0_心臓葉1_欠損_葉脈.Hit = value;
			}
		}

		public bool 心臓葉2_通常_葉_表示
		{
			get
			{
				return this.X0Y0_心臓葉2_通常_葉.Dra;
			}
			set
			{
				this.X0Y0_心臓葉2_通常_葉.Dra = value;
				this.X0Y0_心臓葉2_通常_葉.Hit = value;
			}
		}

		public bool 心臓葉2_通常_葉脈_表示
		{
			get
			{
				return this.X0Y0_心臓葉2_通常_葉脈.Dra;
			}
			set
			{
				this.X0Y0_心臓葉2_通常_葉脈.Dra = value;
				this.X0Y0_心臓葉2_通常_葉脈.Hit = value;
			}
		}

		public bool 心臓葉2_欠損_葉_表示
		{
			get
			{
				return this.X0Y0_心臓葉2_欠損_葉.Dra;
			}
			set
			{
				this.X0Y0_心臓葉2_欠損_葉.Dra = value;
				this.X0Y0_心臓葉2_欠損_葉.Hit = value;
			}
		}

		public bool 心臓葉2_欠損_葉脈_表示
		{
			get
			{
				return this.X0Y0_心臓葉2_欠損_葉脈.Dra;
			}
			set
			{
				this.X0Y0_心臓葉2_欠損_葉脈.Dra = value;
				this.X0Y0_心臓葉2_欠損_葉脈.Hit = value;
			}
		}

		public bool 心臓葉3_通常_葉_表示
		{
			get
			{
				return this.X0Y0_心臓葉3_通常_葉.Dra;
			}
			set
			{
				this.X0Y0_心臓葉3_通常_葉.Dra = value;
				this.X0Y0_心臓葉3_通常_葉.Hit = value;
			}
		}

		public bool 心臓葉3_通常_葉脈_表示
		{
			get
			{
				return this.X0Y0_心臓葉3_通常_葉脈.Dra;
			}
			set
			{
				this.X0Y0_心臓葉3_通常_葉脈.Dra = value;
				this.X0Y0_心臓葉3_通常_葉脈.Hit = value;
			}
		}

		public bool 心臓葉3_欠損_葉_表示
		{
			get
			{
				return this.X0Y0_心臓葉3_欠損_葉.Dra;
			}
			set
			{
				this.X0Y0_心臓葉3_欠損_葉.Dra = value;
				this.X0Y0_心臓葉3_欠損_葉.Hit = value;
			}
		}

		public bool 心臓葉3_欠損_葉脈_表示
		{
			get
			{
				return this.X0Y0_心臓葉3_欠損_葉脈.Dra;
			}
			set
			{
				this.X0Y0_心臓葉3_欠損_葉脈.Dra = value;
				this.X0Y0_心臓葉3_欠損_葉脈.Hit = value;
			}
		}

		public bool 披針葉4_葉_表示
		{
			get
			{
				return this.披針葉4_通常_葉_表示 || this.披針葉4_欠損_葉_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.披針葉4_通常_葉_表示 = false;
					this.披針葉4_欠損_葉_表示 = value;
					return;
				}
				this.披針葉4_通常_葉_表示 = value;
				this.披針葉4_欠損_葉_表示 = false;
			}
		}

		public bool 披針葉4_葉脈_表示
		{
			get
			{
				return this.披針葉4_通常_葉脈_表示 || this.披針葉4_欠損_葉脈_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.披針葉4_通常_葉脈_表示 = false;
					this.披針葉4_欠損_葉脈_表示 = value;
					return;
				}
				this.披針葉4_通常_葉脈_表示 = value;
				this.披針葉4_欠損_葉脈_表示 = false;
			}
		}

		public bool 心臓葉4_葉_表示
		{
			get
			{
				return this.心臓葉4_通常_葉_表示 || this.心臓葉4_欠損_葉_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.心臓葉4_通常_葉_表示 = false;
					this.心臓葉4_欠損_葉_表示 = value;
					return;
				}
				this.心臓葉4_通常_葉_表示 = value;
				this.心臓葉4_欠損_葉_表示 = false;
			}
		}

		public bool 心臓葉4_葉脈_表示
		{
			get
			{
				return this.心臓葉4_通常_葉脈_表示 || this.心臓葉4_欠損_葉脈_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.心臓葉4_通常_葉脈_表示 = false;
					this.心臓葉4_欠損_葉脈_表示 = value;
					return;
				}
				this.心臓葉4_通常_葉脈_表示 = value;
				this.心臓葉4_欠損_葉脈_表示 = false;
			}
		}

		public bool 披針葉1_葉_表示
		{
			get
			{
				return this.披針葉1_通常_葉_表示 || this.披針葉1_欠損_葉_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.披針葉1_通常_葉_表示 = false;
					this.披針葉1_欠損_葉_表示 = value;
					return;
				}
				this.披針葉1_通常_葉_表示 = value;
				this.披針葉1_欠損_葉_表示 = false;
			}
		}

		public bool 披針葉1_葉脈_表示
		{
			get
			{
				return this.披針葉1_通常_葉脈_表示 || this.披針葉1_欠損_葉脈_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.披針葉1_通常_葉脈_表示 = false;
					this.披針葉1_欠損_葉脈_表示 = value;
					return;
				}
				this.披針葉1_通常_葉脈_表示 = value;
				this.披針葉1_欠損_葉脈_表示 = false;
			}
		}

		public bool 披針葉2_葉_表示
		{
			get
			{
				return this.披針葉2_通常_葉_表示 || this.披針葉2_欠損_葉_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.披針葉2_通常_葉_表示 = false;
					this.披針葉2_欠損_葉_表示 = value;
					return;
				}
				this.披針葉2_通常_葉_表示 = value;
				this.披針葉2_欠損_葉_表示 = false;
			}
		}

		public bool 披針葉2_葉脈_表示
		{
			get
			{
				return this.披針葉2_通常_葉脈_表示 || this.披針葉2_欠損_葉脈_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.披針葉2_通常_葉脈_表示 = false;
					this.披針葉2_欠損_葉脈_表示 = value;
					return;
				}
				this.披針葉2_通常_葉脈_表示 = value;
				this.披針葉2_欠損_葉脈_表示 = false;
			}
		}

		public bool 披針葉3_葉_表示
		{
			get
			{
				return this.披針葉3_通常_葉_表示 || this.披針葉3_欠損_葉_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.披針葉3_通常_葉_表示 = false;
					this.披針葉3_欠損_葉_表示 = value;
					return;
				}
				this.披針葉3_通常_葉_表示 = value;
				this.披針葉3_欠損_葉_表示 = false;
			}
		}

		public bool 披針葉3_葉脈_表示
		{
			get
			{
				return this.披針葉3_通常_葉脈_表示 || this.披針葉3_欠損_葉脈_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.披針葉3_通常_葉脈_表示 = false;
					this.披針葉3_欠損_葉脈_表示 = value;
					return;
				}
				this.披針葉3_通常_葉脈_表示 = value;
				this.披針葉3_欠損_葉脈_表示 = false;
			}
		}

		public bool 心臓葉1_葉_表示
		{
			get
			{
				return this.心臓葉1_通常_葉_表示 || this.心臓葉1_欠損_葉_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.心臓葉1_通常_葉_表示 = false;
					this.心臓葉1_欠損_葉_表示 = value;
					return;
				}
				this.心臓葉1_通常_葉_表示 = value;
				this.心臓葉1_欠損_葉_表示 = false;
			}
		}

		public bool 心臓葉1_葉脈_表示
		{
			get
			{
				return this.心臓葉1_通常_葉脈_表示 || this.心臓葉1_欠損_葉脈_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.心臓葉1_通常_葉脈_表示 = false;
					this.心臓葉1_欠損_葉脈_表示 = value;
					return;
				}
				this.心臓葉1_通常_葉脈_表示 = value;
				this.心臓葉1_欠損_葉脈_表示 = false;
			}
		}

		public bool 心臓葉2_葉_表示
		{
			get
			{
				return this.心臓葉2_通常_葉_表示 || this.心臓葉2_欠損_葉_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.心臓葉2_通常_葉_表示 = false;
					this.心臓葉2_欠損_葉_表示 = value;
					return;
				}
				this.心臓葉2_通常_葉_表示 = value;
				this.心臓葉2_欠損_葉_表示 = false;
			}
		}

		public bool 心臓葉2_葉脈_表示
		{
			get
			{
				return this.心臓葉2_通常_葉脈_表示 || this.心臓葉2_欠損_葉脈_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.心臓葉2_通常_葉脈_表示 = false;
					this.心臓葉2_欠損_葉脈_表示 = value;
					return;
				}
				this.心臓葉2_通常_葉脈_表示 = value;
				this.心臓葉2_欠損_葉脈_表示 = false;
			}
		}

		public bool 心臓葉3_葉_表示
		{
			get
			{
				return this.心臓葉3_通常_葉_表示 || this.心臓葉3_欠損_葉_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.心臓葉3_通常_葉_表示 = false;
					this.心臓葉3_欠損_葉_表示 = value;
					return;
				}
				this.心臓葉3_通常_葉_表示 = value;
				this.心臓葉3_欠損_葉_表示 = false;
			}
		}

		public bool 心臓葉3_葉脈_表示
		{
			get
			{
				return this.心臓葉3_通常_葉脈_表示 || this.心臓葉3_欠損_葉脈_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.心臓葉3_通常_葉脈_表示 = false;
					this.心臓葉3_欠損_葉脈_表示 = value;
					return;
				}
				this.心臓葉3_通常_葉脈_表示 = value;
				this.心臓葉3_欠損_葉脈_表示 = false;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.披針葉4_通常_葉_表示;
			}
			set
			{
				this.披針葉4_通常_葉_表示 = value;
				this.披針葉4_通常_葉脈_表示 = value;
				this.披針葉4_欠損_葉_表示 = value;
				this.披針葉4_欠損_葉脈_表示 = value;
				this.心臓葉4_通常_葉_表示 = value;
				this.心臓葉4_通常_葉脈_表示 = value;
				this.心臓葉4_欠損_葉_表示 = value;
				this.心臓葉4_欠損_葉脈_表示 = value;
				this.茎_表示 = value;
				this.根1_表示 = value;
				this.根2_表示 = value;
				this.披針葉1_通常_葉_表示 = value;
				this.披針葉1_通常_葉脈_表示 = value;
				this.披針葉1_欠損_葉_表示 = value;
				this.披針葉1_欠損_葉脈_表示 = value;
				this.披針葉2_通常_葉_表示 = value;
				this.披針葉2_通常_葉脈_表示 = value;
				this.披針葉2_欠損_葉_表示 = value;
				this.披針葉2_欠損_葉脈_表示 = value;
				this.披針葉3_通常_葉_表示 = value;
				this.披針葉3_通常_葉脈_表示 = value;
				this.披針葉3_欠損_葉_表示 = value;
				this.披針葉3_欠損_葉脈_表示 = value;
				this.心臓葉1_通常_葉_表示 = value;
				this.心臓葉1_通常_葉脈_表示 = value;
				this.心臓葉1_欠損_葉_表示 = value;
				this.心臓葉1_欠損_葉脈_表示 = value;
				this.心臓葉2_通常_葉_表示 = value;
				this.心臓葉2_通常_葉脈_表示 = value;
				this.心臓葉2_欠損_葉_表示 = value;
				this.心臓葉2_欠損_葉脈_表示 = value;
				this.心臓葉3_通常_葉_表示 = value;
				this.心臓葉3_通常_葉脈_表示 = value;
				this.心臓葉3_欠損_葉_表示 = value;
				this.心臓葉3_欠損_葉脈_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.葉4CD.不透明度;
			}
			set
			{
				this.葉4CD.不透明度 = value;
				this.葉脈4CD.不透明度 = value;
				this.茎CD.不透明度 = value;
				this.根1CD.不透明度 = value;
				this.根2CD.不透明度 = value;
				this.葉1CD.不透明度 = value;
				this.葉脈1CD.不透明度 = value;
				this.葉2CD.不透明度 = value;
				this.葉脈2CD.不透明度 = value;
				this.葉3CD.不透明度 = value;
				this.葉脈3CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_茎.AngleBase = num * -4.99999999999999;
			this.X0Y0_披針葉4_通常_葉脈.AngleBase = num * -52.0000000000001;
			this.X0Y0_披針葉4_欠損_葉脈.AngleBase = num * -52.0000000000001;
			this.X0Y0_心臓葉4_通常_葉脈.AngleBase = num * -60.9999999999999;
			this.X0Y0_心臓葉4_欠損_葉脈.AngleBase = num * -60.9999999999999;
			this.X0Y0_根1.AngleBase = num * -49.0;
			this.X0Y0_根2.AngleBase = num * -38.0;
			this.X0Y0_披針葉1_通常_葉脈.AngleBase = num * -24.0;
			this.X0Y0_披針葉1_欠損_葉脈.AngleBase = num * -24.0;
			this.X0Y0_披針葉2_通常_葉脈.AngleBase = num * -41.9999999999999;
			this.X0Y0_披針葉2_欠損_葉脈.AngleBase = num * -41.9999999999999;
			this.X0Y0_披針葉3_通常_葉脈.AngleBase = num * -66.0000000000002;
			this.X0Y0_披針葉3_欠損_葉脈.AngleBase = num * -66.0000000000002;
			this.X0Y0_心臓葉1_通常_葉脈.AngleBase = num * -23.0;
			this.X0Y0_心臓葉1_欠損_葉脈.AngleBase = num * -23.0;
			this.X0Y0_心臓葉2_通常_葉脈.AngleBase = num * -41.0;
			this.X0Y0_心臓葉2_欠損_葉脈.AngleBase = num * -41.0;
			this.X0Y0_心臓葉3_通常_葉脈.AngleBase = num * -64.9999999999998;
			this.X0Y0_心臓葉3_欠損_葉脈.AngleBase = num * -64.9999999999998;
			this.本体.JoinPAall();
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

		public JointS 花_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_茎, 6);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_披針葉4_通常_葉CP.Update();
			this.X0Y0_披針葉4_通常_葉脈CP.Update();
			this.X0Y0_披針葉4_欠損_葉CP.Update();
			this.X0Y0_披針葉4_欠損_葉脈CP.Update();
			this.X0Y0_心臓葉4_通常_葉CP.Update();
			this.X0Y0_心臓葉4_通常_葉脈CP.Update();
			this.X0Y0_心臓葉4_欠損_葉CP.Update();
			this.X0Y0_心臓葉4_欠損_葉脈CP.Update();
			this.X0Y0_茎CP.Update();
			this.X0Y0_根1CP.Update();
			this.X0Y0_根2CP.Update();
			this.X0Y0_披針葉1_通常_葉CP.Update();
			this.X0Y0_披針葉1_通常_葉脈CP.Update();
			this.X0Y0_披針葉1_欠損_葉CP.Update();
			this.X0Y0_披針葉1_欠損_葉脈CP.Update();
			this.X0Y0_披針葉2_通常_葉CP.Update();
			this.X0Y0_披針葉2_通常_葉脈CP.Update();
			this.X0Y0_披針葉2_欠損_葉CP.Update();
			this.X0Y0_披針葉2_欠損_葉脈CP.Update();
			this.X0Y0_披針葉3_通常_葉CP.Update();
			this.X0Y0_披針葉3_通常_葉脈CP.Update();
			this.X0Y0_披針葉3_欠損_葉CP.Update();
			this.X0Y0_披針葉3_欠損_葉脈CP.Update();
			this.X0Y0_心臓葉1_通常_葉CP.Update();
			this.X0Y0_心臓葉1_通常_葉脈CP.Update();
			this.X0Y0_心臓葉1_欠損_葉CP.Update();
			this.X0Y0_心臓葉1_欠損_葉脈CP.Update();
			this.X0Y0_心臓葉2_通常_葉CP.Update();
			this.X0Y0_心臓葉2_通常_葉脈CP.Update();
			this.X0Y0_心臓葉2_欠損_葉CP.Update();
			this.X0Y0_心臓葉2_欠損_葉脈CP.Update();
			this.X0Y0_心臓葉3_通常_葉CP.Update();
			this.X0Y0_心臓葉3_通常_葉脈CP.Update();
			this.X0Y0_心臓葉3_欠損_葉CP.Update();
			this.X0Y0_心臓葉3_欠損_葉脈CP.Update();
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
			this.葉4CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.葉脈4CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.茎CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.根1CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.根2CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.葉1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.葉脈1CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.葉2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.葉脈2CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.葉3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.葉脈3CD = new ColorD(ref Col.Black, ref 体配色.植0O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.葉4CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.葉脈4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.茎CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.根1CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.根2CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.葉1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.葉脈1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.葉2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.葉脈2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.葉3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.葉脈3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.葉4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.葉脈4CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.茎CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.根1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.根2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.葉1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.葉脈1CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.葉2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.葉脈2CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.葉3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.葉脈3CD = new ColorD(ref Col.Black, ref 体配色.植0O);
		}

		public Par X0Y0_披針葉4_通常_葉;

		public Par X0Y0_披針葉4_通常_葉脈;

		public Par X0Y0_披針葉4_欠損_葉;

		public Par X0Y0_披針葉4_欠損_葉脈;

		public Par X0Y0_心臓葉4_通常_葉;

		public Par X0Y0_心臓葉4_通常_葉脈;

		public Par X0Y0_心臓葉4_欠損_葉;

		public Par X0Y0_心臓葉4_欠損_葉脈;

		public Par X0Y0_茎;

		public Par X0Y0_根1;

		public Par X0Y0_根2;

		public Par X0Y0_披針葉1_通常_葉;

		public Par X0Y0_披針葉1_通常_葉脈;

		public Par X0Y0_披針葉1_欠損_葉;

		public Par X0Y0_披針葉1_欠損_葉脈;

		public Par X0Y0_披針葉2_通常_葉;

		public Par X0Y0_披針葉2_通常_葉脈;

		public Par X0Y0_披針葉2_欠損_葉;

		public Par X0Y0_披針葉2_欠損_葉脈;

		public Par X0Y0_披針葉3_通常_葉;

		public Par X0Y0_披針葉3_通常_葉脈;

		public Par X0Y0_披針葉3_欠損_葉;

		public Par X0Y0_披針葉3_欠損_葉脈;

		public Par X0Y0_心臓葉1_通常_葉;

		public Par X0Y0_心臓葉1_通常_葉脈;

		public Par X0Y0_心臓葉1_欠損_葉;

		public Par X0Y0_心臓葉1_欠損_葉脈;

		public Par X0Y0_心臓葉2_通常_葉;

		public Par X0Y0_心臓葉2_通常_葉脈;

		public Par X0Y0_心臓葉2_欠損_葉;

		public Par X0Y0_心臓葉2_欠損_葉脈;

		public Par X0Y0_心臓葉3_通常_葉;

		public Par X0Y0_心臓葉3_通常_葉脈;

		public Par X0Y0_心臓葉3_欠損_葉;

		public Par X0Y0_心臓葉3_欠損_葉脈;

		public ColorD 葉4CD;

		public ColorD 葉脈4CD;

		public ColorD 茎CD;

		public ColorD 根1CD;

		public ColorD 根2CD;

		public ColorD 葉1CD;

		public ColorD 葉脈1CD;

		public ColorD 葉2CD;

		public ColorD 葉脈2CD;

		public ColorD 葉3CD;

		public ColorD 葉脈3CD;

		public ColorP X0Y0_披針葉4_通常_葉CP;

		public ColorP X0Y0_披針葉4_通常_葉脈CP;

		public ColorP X0Y0_披針葉4_欠損_葉CP;

		public ColorP X0Y0_披針葉4_欠損_葉脈CP;

		public ColorP X0Y0_心臓葉4_通常_葉CP;

		public ColorP X0Y0_心臓葉4_通常_葉脈CP;

		public ColorP X0Y0_心臓葉4_欠損_葉CP;

		public ColorP X0Y0_心臓葉4_欠損_葉脈CP;

		public ColorP X0Y0_茎CP;

		public ColorP X0Y0_根1CP;

		public ColorP X0Y0_根2CP;

		public ColorP X0Y0_披針葉1_通常_葉CP;

		public ColorP X0Y0_披針葉1_通常_葉脈CP;

		public ColorP X0Y0_披針葉1_欠損_葉CP;

		public ColorP X0Y0_披針葉1_欠損_葉脈CP;

		public ColorP X0Y0_披針葉2_通常_葉CP;

		public ColorP X0Y0_披針葉2_通常_葉脈CP;

		public ColorP X0Y0_披針葉2_欠損_葉CP;

		public ColorP X0Y0_披針葉2_欠損_葉脈CP;

		public ColorP X0Y0_披針葉3_通常_葉CP;

		public ColorP X0Y0_披針葉3_通常_葉脈CP;

		public ColorP X0Y0_披針葉3_欠損_葉CP;

		public ColorP X0Y0_披針葉3_欠損_葉脈CP;

		public ColorP X0Y0_心臓葉1_通常_葉CP;

		public ColorP X0Y0_心臓葉1_通常_葉脈CP;

		public ColorP X0Y0_心臓葉1_欠損_葉CP;

		public ColorP X0Y0_心臓葉1_欠損_葉脈CP;

		public ColorP X0Y0_心臓葉2_通常_葉CP;

		public ColorP X0Y0_心臓葉2_通常_葉脈CP;

		public ColorP X0Y0_心臓葉2_欠損_葉CP;

		public ColorP X0Y0_心臓葉2_欠損_葉脈CP;

		public ColorP X0Y0_心臓葉3_通常_葉CP;

		public ColorP X0Y0_心臓葉3_通常_葉脈CP;

		public ColorP X0Y0_心臓葉3_欠損_葉CP;

		public ColorP X0Y0_心臓葉3_欠損_葉脈CP;

		public Ele[] 花_接続;
	}
}
