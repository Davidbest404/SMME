using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 四足胸 : 半身
	{
		public 四足胸(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 四足胸D e)
		{
			四足胸.<>c__DisplayClass96_0 CS$<>8__locals1 = new 四足胸.<>c__DisplayClass96_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.半身["四足胸郭"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_胸郭 = pars["胸郭"].ToPar();
			Pars pars2 = pars["筋肉"].ToPars();
			this.X0Y0_筋肉_筋肉左 = pars2["筋肉左"].ToPar();
			this.X0Y0_筋肉_筋肉右 = pars2["筋肉右"].ToPar();
			this.X0Y0_筋肉_筋肉中 = pars2["筋肉中"].ToPar();
			this.X0Y0_筋肉_筋肉左下 = pars2["筋肉左下"].ToPar();
			this.X0Y0_筋肉_筋肉左中 = pars2["筋肉左中"].ToPar();
			this.X0Y0_筋肉_筋肉左上 = pars2["筋肉左上"].ToPar();
			this.X0Y0_筋肉_筋肉右下 = pars2["筋肉右下"].ToPar();
			this.X0Y0_筋肉_筋肉右中 = pars2["筋肉右中"].ToPar();
			this.X0Y0_筋肉_筋肉右上 = pars2["筋肉右上"].ToPar();
			pars2 = pars["紋柄"].ToPars();
			Pars pars3 = pars2["紋左"].ToPars();
			this.X0Y0_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
			this.X0Y0_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
			this.X0Y0_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
			this.X0Y0_紋柄_紋左_紋4 = pars3["紋4"].ToPar();
			pars3 = pars2["紋右"].ToPars();
			this.X0Y0_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
			this.X0Y0_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
			this.X0Y0_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
			this.X0Y0_紋柄_紋右_紋4 = pars3["紋4"].ToPar();
			pars2 = pars["虎柄"].ToPars();
			pars3 = pars2["虎左"].ToPars();
			this.X0Y0_虎柄_虎左_虎1 = pars3["虎1"].ToPar();
			this.X0Y0_虎柄_虎左_虎2 = pars3["虎2"].ToPar();
			pars3 = pars2["虎右"].ToPars();
			this.X0Y0_虎柄_虎右_虎1 = pars3["虎1"].ToPar();
			this.X0Y0_虎柄_虎右_虎2 = pars3["虎2"].ToPar();
			pars2 = pars["鱗"].ToPars();
			pars3 = pars2["中"].ToPars();
			this.X0Y0_竜性_中_鱗左 = pars3["鱗左"].ToPar();
			this.X0Y0_竜性_中_鱗右 = pars3["鱗右"].ToPar();
			this.X0Y0_竜性_中_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_竜性_中_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["左"].ToPars();
			this.X0Y0_竜性_左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_竜性_左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_竜性_左_鱗3 = pars3["鱗3"].ToPar();
			pars3 = pars2["右"].ToPars();
			this.X0Y0_竜性_右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_竜性_右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_竜性_右_鱗3 = pars3["鱗3"].ToPar();
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
			this.胸郭_表示 = e.胸郭_表示;
			this.筋肉_筋肉左_表示 = e.筋肉_筋肉左_表示;
			this.筋肉_筋肉右_表示 = e.筋肉_筋肉右_表示;
			this.筋肉_筋肉中_表示 = e.筋肉_筋肉中_表示;
			this.筋肉_筋肉左下_表示 = e.筋肉_筋肉左下_表示;
			this.筋肉_筋肉左中_表示 = e.筋肉_筋肉左中_表示;
			this.筋肉_筋肉左上_表示 = e.筋肉_筋肉左上_表示;
			this.筋肉_筋肉右下_表示 = e.筋肉_筋肉右下_表示;
			this.筋肉_筋肉右中_表示 = e.筋肉_筋肉右中_表示;
			this.筋肉_筋肉右上_表示 = e.筋肉_筋肉右上_表示;
			this.紋柄_紋左_紋1_表示 = e.紋柄_紋左_紋1_表示;
			this.紋柄_紋左_紋2_表示 = e.紋柄_紋左_紋2_表示;
			this.紋柄_紋左_紋3_表示 = e.紋柄_紋左_紋3_表示;
			this.紋柄_紋左_紋4_表示 = e.紋柄_紋左_紋4_表示;
			this.紋柄_紋右_紋1_表示 = e.紋柄_紋右_紋1_表示;
			this.紋柄_紋右_紋2_表示 = e.紋柄_紋右_紋2_表示;
			this.紋柄_紋右_紋3_表示 = e.紋柄_紋右_紋3_表示;
			this.紋柄_紋右_紋4_表示 = e.紋柄_紋右_紋4_表示;
			this.虎柄_虎左_虎1_表示 = e.虎柄_虎左_虎1_表示;
			this.虎柄_虎左_虎2_表示 = e.虎柄_虎左_虎2_表示;
			this.虎柄_虎右_虎1_表示 = e.虎柄_虎右_虎1_表示;
			this.虎柄_虎右_虎2_表示 = e.虎柄_虎右_虎2_表示;
			this.竜性_中_鱗左_表示 = e.竜性_中_鱗左_表示;
			this.竜性_中_鱗右_表示 = e.竜性_中_鱗右_表示;
			this.竜性_中_鱗1_表示 = e.竜性_中_鱗1_表示;
			this.竜性_中_鱗2_表示 = e.竜性_中_鱗2_表示;
			this.竜性_左_鱗1_表示 = e.竜性_左_鱗1_表示;
			this.竜性_左_鱗2_表示 = e.竜性_左_鱗2_表示;
			this.竜性_左_鱗3_表示 = e.竜性_左_鱗3_表示;
			this.竜性_右_鱗1_表示 = e.竜性_右_鱗1_表示;
			this.竜性_右_鱗2_表示 = e.竜性_右_鱗2_表示;
			this.竜性_右_鱗3_表示 = e.竜性_右_鱗3_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.脇左_接続.Count > 0)
			{
				Ele f;
				this.脇左_接続 = e.脇左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.四足胸_脇左_接続;
					f.接続(CS$<>8__locals1.<>4__this.脇左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.脇右_接続.Count > 0)
			{
				Ele f;
				this.脇右_接続 = e.脇右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.四足胸_脇右_接続;
					f.接続(CS$<>8__locals1.<>4__this.脇右_接続点);
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
					f.接続情報 = 接続情報.四足胸_胴_接続;
					f.接続(CS$<>8__locals1.<>4__this.胴_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.胸左_接続.Count > 0)
			{
				Ele f;
				this.胸左_接続 = e.胸左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.四足胸_胸左_接続;
					f.接続(CS$<>8__locals1.<>4__this.胸左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.胸右_接続.Count > 0)
			{
				Ele f;
				this.胸右_接続 = e.胸右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.四足胸_胸右_接続;
					f.接続(CS$<>8__locals1.<>4__this.胸右_接続点);
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
					f.接続情報 = 接続情報.四足胸_肌_接続;
					f.接続(CS$<>8__locals1.<>4__this.肌_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.翼上左_接続.Count > 0)
			{
				Ele f;
				this.翼上左_接続 = e.翼上左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.四足胸_翼上左_接続;
					f.接続(CS$<>8__locals1.<>4__this.翼上左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.翼上右_接続.Count > 0)
			{
				Ele f;
				this.翼上右_接続 = e.翼上右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.四足胸_翼上右_接続;
					f.接続(CS$<>8__locals1.<>4__this.翼上右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.翼下左_接続.Count > 0)
			{
				Ele f;
				this.翼下左_接続 = e.翼下左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.四足胸_翼下左_接続;
					f.接続(CS$<>8__locals1.<>4__this.翼下左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.翼下右_接続.Count > 0)
			{
				Ele f;
				this.翼下右_接続 = e.翼下右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.四足胸_翼下右_接続;
					f.接続(CS$<>8__locals1.<>4__this.翼下右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.背中_接続.Count > 0)
			{
				Ele f;
				this.背中_接続 = e.背中_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.四足胸_背中_接続;
					f.接続(CS$<>8__locals1.<>4__this.背中_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_胸郭CP = new ColorP(this.X0Y0_胸郭, this.胸郭CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_筋肉_筋肉左CP = new ColorP(this.X0Y0_筋肉_筋肉左, this.筋肉_筋肉左CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋肉右CP = new ColorP(this.X0Y0_筋肉_筋肉右, this.筋肉_筋肉右CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋肉中CP = new ColorP(this.X0Y0_筋肉_筋肉中, this.筋肉_筋肉中CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋肉左下CP = new ColorP(this.X0Y0_筋肉_筋肉左下, this.筋肉_筋肉左下CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋肉左中CP = new ColorP(this.X0Y0_筋肉_筋肉左中, this.筋肉_筋肉左中CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋肉左上CP = new ColorP(this.X0Y0_筋肉_筋肉左上, this.筋肉_筋肉左上CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋肉右下CP = new ColorP(this.X0Y0_筋肉_筋肉右下, this.筋肉_筋肉右下CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋肉右中CP = new ColorP(this.X0Y0_筋肉_筋肉右中, this.筋肉_筋肉右中CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋肉右上CP = new ColorP(this.X0Y0_筋肉_筋肉右上, this.筋肉_筋肉右上CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_紋柄_紋左_紋1CP = new ColorP(this.X0Y0_紋柄_紋左_紋1, this.紋柄_紋左_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋左_紋2CP = new ColorP(this.X0Y0_紋柄_紋左_紋2, this.紋柄_紋左_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋左_紋3CP = new ColorP(this.X0Y0_紋柄_紋左_紋3, this.紋柄_紋左_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋左_紋4CP = new ColorP(this.X0Y0_紋柄_紋左_紋4, this.紋柄_紋左_紋4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋右_紋1CP = new ColorP(this.X0Y0_紋柄_紋右_紋1, this.紋柄_紋右_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋右_紋2CP = new ColorP(this.X0Y0_紋柄_紋右_紋2, this.紋柄_紋右_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋右_紋3CP = new ColorP(this.X0Y0_紋柄_紋右_紋3, this.紋柄_紋右_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋右_紋4CP = new ColorP(this.X0Y0_紋柄_紋右_紋4, this.紋柄_紋右_紋4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虎柄_虎左_虎1CP = new ColorP(this.X0Y0_虎柄_虎左_虎1, this.虎柄_虎左_虎1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虎柄_虎左_虎2CP = new ColorP(this.X0Y0_虎柄_虎左_虎2, this.虎柄_虎左_虎2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虎柄_虎右_虎1CP = new ColorP(this.X0Y0_虎柄_虎右_虎1, this.虎柄_虎右_虎1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虎柄_虎右_虎2CP = new ColorP(this.X0Y0_虎柄_虎右_虎2, this.虎柄_虎右_虎2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_中_鱗左CP = new ColorP(this.X0Y0_竜性_中_鱗左, this.竜性_中_鱗左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_中_鱗右CP = new ColorP(this.X0Y0_竜性_中_鱗右, this.竜性_中_鱗右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_中_鱗1CP = new ColorP(this.X0Y0_竜性_中_鱗1, this.竜性_中_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_中_鱗2CP = new ColorP(this.X0Y0_竜性_中_鱗2, this.竜性_中_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_左_鱗1CP = new ColorP(this.X0Y0_竜性_左_鱗1, this.竜性_左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_左_鱗2CP = new ColorP(this.X0Y0_竜性_左_鱗2, this.竜性_左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_左_鱗3CP = new ColorP(this.X0Y0_竜性_左_鱗3, this.竜性_左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_右_鱗1CP = new ColorP(this.X0Y0_竜性_右_鱗1, this.竜性_右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_右_鱗2CP = new ColorP(this.X0Y0_竜性_右_鱗2, this.竜性_右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_右_鱗3CP = new ColorP(this.X0Y0_竜性_右_鱗3, this.竜性_右_鱗3CD, CS$<>8__locals1.DisUnit, true);
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
				this.筋肉_筋肉中_表示 = this.筋肉_;
				this.筋肉_筋肉左下_表示 = this.筋肉_;
				this.筋肉_筋肉左中_表示 = this.筋肉_;
				this.筋肉_筋肉左上_表示 = this.筋肉_;
				this.筋肉_筋肉右下_表示 = this.筋肉_;
				this.筋肉_筋肉右中_表示 = this.筋肉_;
				this.筋肉_筋肉右上_表示 = this.筋肉_;
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

		public bool 胸郭_表示
		{
			get
			{
				return this.X0Y0_胸郭.Dra;
			}
			set
			{
				this.X0Y0_胸郭.Dra = value;
				this.X0Y0_胸郭.Hit = value;
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

		public bool 筋肉_筋肉中_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋肉中.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋肉中.Dra = value;
				this.X0Y0_筋肉_筋肉中.Hit = value;
			}
		}

		public bool 筋肉_筋肉左下_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋肉左下.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋肉左下.Dra = value;
				this.X0Y0_筋肉_筋肉左下.Hit = value;
			}
		}

		public bool 筋肉_筋肉左中_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋肉左中.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋肉左中.Dra = value;
				this.X0Y0_筋肉_筋肉左中.Hit = value;
			}
		}

		public bool 筋肉_筋肉左上_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋肉左上.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋肉左上.Dra = value;
				this.X0Y0_筋肉_筋肉左上.Hit = value;
			}
		}

		public bool 筋肉_筋肉右下_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋肉右下.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋肉右下.Dra = value;
				this.X0Y0_筋肉_筋肉右下.Hit = value;
			}
		}

		public bool 筋肉_筋肉右中_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋肉右中.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋肉右中.Dra = value;
				this.X0Y0_筋肉_筋肉右中.Hit = value;
			}
		}

		public bool 筋肉_筋肉右上_表示
		{
			get
			{
				return this.X0Y0_筋肉_筋肉右上.Dra;
			}
			set
			{
				this.X0Y0_筋肉_筋肉右上.Dra = value;
				this.X0Y0_筋肉_筋肉右上.Hit = value;
			}
		}

		public bool 紋柄_紋左_紋1_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋左_紋1.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋左_紋1.Dra = value;
				this.X0Y0_紋柄_紋左_紋1.Hit = value;
			}
		}

		public bool 紋柄_紋左_紋2_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋左_紋2.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋左_紋2.Dra = value;
				this.X0Y0_紋柄_紋左_紋2.Hit = value;
			}
		}

		public bool 紋柄_紋左_紋3_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋左_紋3.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋左_紋3.Dra = value;
				this.X0Y0_紋柄_紋左_紋3.Hit = value;
			}
		}

		public bool 紋柄_紋左_紋4_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋左_紋4.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋左_紋4.Dra = value;
				this.X0Y0_紋柄_紋左_紋4.Hit = value;
			}
		}

		public bool 紋柄_紋右_紋1_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋右_紋1.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋右_紋1.Dra = value;
				this.X0Y0_紋柄_紋右_紋1.Hit = value;
			}
		}

		public bool 紋柄_紋右_紋2_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋右_紋2.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋右_紋2.Dra = value;
				this.X0Y0_紋柄_紋右_紋2.Hit = value;
			}
		}

		public bool 紋柄_紋右_紋3_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋右_紋3.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋右_紋3.Dra = value;
				this.X0Y0_紋柄_紋右_紋3.Hit = value;
			}
		}

		public bool 紋柄_紋右_紋4_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋右_紋4.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋右_紋4.Dra = value;
				this.X0Y0_紋柄_紋右_紋4.Hit = value;
			}
		}

		public bool 虎柄_虎左_虎1_表示
		{
			get
			{
				return this.X0Y0_虎柄_虎左_虎1.Dra;
			}
			set
			{
				this.X0Y0_虎柄_虎左_虎1.Dra = value;
				this.X0Y0_虎柄_虎左_虎1.Hit = value;
			}
		}

		public bool 虎柄_虎左_虎2_表示
		{
			get
			{
				return this.X0Y0_虎柄_虎左_虎2.Dra;
			}
			set
			{
				this.X0Y0_虎柄_虎左_虎2.Dra = value;
				this.X0Y0_虎柄_虎左_虎2.Hit = value;
			}
		}

		public bool 虎柄_虎右_虎1_表示
		{
			get
			{
				return this.X0Y0_虎柄_虎右_虎1.Dra;
			}
			set
			{
				this.X0Y0_虎柄_虎右_虎1.Dra = value;
				this.X0Y0_虎柄_虎右_虎1.Hit = value;
			}
		}

		public bool 虎柄_虎右_虎2_表示
		{
			get
			{
				return this.X0Y0_虎柄_虎右_虎2.Dra;
			}
			set
			{
				this.X0Y0_虎柄_虎右_虎2.Dra = value;
				this.X0Y0_虎柄_虎右_虎2.Hit = value;
			}
		}

		public bool 竜性_中_鱗左_表示
		{
			get
			{
				return this.X0Y0_竜性_中_鱗左.Dra;
			}
			set
			{
				this.X0Y0_竜性_中_鱗左.Dra = value;
				this.X0Y0_竜性_中_鱗左.Hit = value;
			}
		}

		public bool 竜性_中_鱗右_表示
		{
			get
			{
				return this.X0Y0_竜性_中_鱗右.Dra;
			}
			set
			{
				this.X0Y0_竜性_中_鱗右.Dra = value;
				this.X0Y0_竜性_中_鱗右.Hit = value;
			}
		}

		public bool 竜性_中_鱗1_表示
		{
			get
			{
				return this.X0Y0_竜性_中_鱗1.Dra;
			}
			set
			{
				this.X0Y0_竜性_中_鱗1.Dra = value;
				this.X0Y0_竜性_中_鱗1.Hit = value;
			}
		}

		public bool 竜性_中_鱗2_表示
		{
			get
			{
				return this.X0Y0_竜性_中_鱗2.Dra;
			}
			set
			{
				this.X0Y0_竜性_中_鱗2.Dra = value;
				this.X0Y0_竜性_中_鱗2.Hit = value;
			}
		}

		public bool 竜性_左_鱗1_表示
		{
			get
			{
				return this.X0Y0_竜性_左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_竜性_左_鱗1.Dra = value;
				this.X0Y0_竜性_左_鱗1.Hit = value;
			}
		}

		public bool 竜性_左_鱗2_表示
		{
			get
			{
				return this.X0Y0_竜性_左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_竜性_左_鱗2.Dra = value;
				this.X0Y0_竜性_左_鱗2.Hit = value;
			}
		}

		public bool 竜性_左_鱗3_表示
		{
			get
			{
				return this.X0Y0_竜性_左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_竜性_左_鱗3.Dra = value;
				this.X0Y0_竜性_左_鱗3.Hit = value;
			}
		}

		public bool 竜性_右_鱗1_表示
		{
			get
			{
				return this.X0Y0_竜性_右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_竜性_右_鱗1.Dra = value;
				this.X0Y0_竜性_右_鱗1.Hit = value;
			}
		}

		public bool 竜性_右_鱗2_表示
		{
			get
			{
				return this.X0Y0_竜性_右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_竜性_右_鱗2.Dra = value;
				this.X0Y0_竜性_右_鱗2.Hit = value;
			}
		}

		public bool 竜性_右_鱗3_表示
		{
			get
			{
				return this.X0Y0_竜性_右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_竜性_右_鱗3.Dra = value;
				this.X0Y0_竜性_右_鱗3.Hit = value;
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
				this.筋肉_筋肉中CD.不透明度 = value;
				this.筋肉_筋肉左下CD.不透明度 = value;
				this.筋肉_筋肉左中CD.不透明度 = value;
				this.筋肉_筋肉左上CD.不透明度 = value;
				this.筋肉_筋肉右下CD.不透明度 = value;
				this.筋肉_筋肉右中CD.不透明度 = value;
				this.筋肉_筋肉右上CD.不透明度 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.胸郭_表示;
			}
			set
			{
				this.胸郭_表示 = value;
				this.筋肉_筋肉左_表示 = value;
				this.筋肉_筋肉右_表示 = value;
				this.筋肉_筋肉中_表示 = value;
				this.筋肉_筋肉左下_表示 = value;
				this.筋肉_筋肉左中_表示 = value;
				this.筋肉_筋肉左上_表示 = value;
				this.筋肉_筋肉右下_表示 = value;
				this.筋肉_筋肉右中_表示 = value;
				this.筋肉_筋肉右上_表示 = value;
				this.紋柄_紋左_紋1_表示 = value;
				this.紋柄_紋左_紋2_表示 = value;
				this.紋柄_紋左_紋3_表示 = value;
				this.紋柄_紋左_紋4_表示 = value;
				this.紋柄_紋右_紋1_表示 = value;
				this.紋柄_紋右_紋2_表示 = value;
				this.紋柄_紋右_紋3_表示 = value;
				this.紋柄_紋右_紋4_表示 = value;
				this.虎柄_虎左_虎1_表示 = value;
				this.虎柄_虎左_虎2_表示 = value;
				this.虎柄_虎右_虎1_表示 = value;
				this.虎柄_虎右_虎2_表示 = value;
				this.竜性_中_鱗左_表示 = value;
				this.竜性_中_鱗右_表示 = value;
				this.竜性_中_鱗1_表示 = value;
				this.竜性_中_鱗2_表示 = value;
				this.竜性_左_鱗1_表示 = value;
				this.竜性_左_鱗2_表示 = value;
				this.竜性_左_鱗3_表示 = value;
				this.竜性_右_鱗1_表示 = value;
				this.竜性_右_鱗2_表示 = value;
				this.竜性_右_鱗3_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.胸郭CD.不透明度;
			}
			set
			{
				this.胸郭CD.不透明度 = value;
				this.筋肉_筋肉左CD.不透明度 = value;
				this.筋肉_筋肉右CD.不透明度 = value;
				this.筋肉_筋肉中CD.不透明度 = value;
				this.筋肉_筋肉左下CD.不透明度 = value;
				this.筋肉_筋肉左中CD.不透明度 = value;
				this.筋肉_筋肉左上CD.不透明度 = value;
				this.筋肉_筋肉右下CD.不透明度 = value;
				this.筋肉_筋肉右中CD.不透明度 = value;
				this.筋肉_筋肉右上CD.不透明度 = value;
				this.紋柄_紋左_紋1CD.不透明度 = value;
				this.紋柄_紋左_紋2CD.不透明度 = value;
				this.紋柄_紋左_紋3CD.不透明度 = value;
				this.紋柄_紋左_紋4CD.不透明度 = value;
				this.紋柄_紋右_紋1CD.不透明度 = value;
				this.紋柄_紋右_紋2CD.不透明度 = value;
				this.紋柄_紋右_紋3CD.不透明度 = value;
				this.紋柄_紋右_紋4CD.不透明度 = value;
				this.虎柄_虎左_虎1CD.不透明度 = value;
				this.虎柄_虎左_虎2CD.不透明度 = value;
				this.虎柄_虎右_虎1CD.不透明度 = value;
				this.虎柄_虎右_虎2CD.不透明度 = value;
				this.竜性_中_鱗左CD.不透明度 = value;
				this.竜性_中_鱗右CD.不透明度 = value;
				this.竜性_中_鱗1CD.不透明度 = value;
				this.竜性_中_鱗2CD.不透明度 = value;
				this.竜性_左_鱗1CD.不透明度 = value;
				this.竜性_左_鱗2CD.不透明度 = value;
				this.竜性_左_鱗3CD.不透明度 = value;
				this.竜性_右_鱗1CD.不透明度 = value;
				this.竜性_右_鱗2CD.不透明度 = value;
				this.竜性_右_鱗3CD.不透明度 = value;
			}
		}

		public void 胸描画(Are Are)
		{
			Are.Draw(this.X0Y0_胸郭);
			Are.Draw(this.X0Y0_筋肉_筋肉左);
			Are.Draw(this.X0Y0_筋肉_筋肉右);
			Are.Draw(this.X0Y0_筋肉_筋肉中);
			Are.Draw(this.X0Y0_筋肉_筋肉左下);
			Are.Draw(this.X0Y0_筋肉_筋肉左中);
			Are.Draw(this.X0Y0_筋肉_筋肉左上);
			Are.Draw(this.X0Y0_筋肉_筋肉右下);
			Are.Draw(this.X0Y0_筋肉_筋肉右中);
			Are.Draw(this.X0Y0_筋肉_筋肉右上);
			Are.Draw(this.X0Y0_竜性_中_鱗左);
			Are.Draw(this.X0Y0_竜性_中_鱗右);
			Are.Draw(this.X0Y0_竜性_中_鱗1);
			Are.Draw(this.X0Y0_竜性_中_鱗2);
		}

		public void 肌描画(Are Are)
		{
			Are.Draw(this.X0Y0_紋柄_紋左_紋1);
			Are.Draw(this.X0Y0_紋柄_紋左_紋2);
			Are.Draw(this.X0Y0_紋柄_紋左_紋3);
			Are.Draw(this.X0Y0_紋柄_紋左_紋4);
			Are.Draw(this.X0Y0_紋柄_紋右_紋1);
			Are.Draw(this.X0Y0_紋柄_紋右_紋2);
			Are.Draw(this.X0Y0_紋柄_紋右_紋3);
			Are.Draw(this.X0Y0_紋柄_紋右_紋4);
			Are.Draw(this.X0Y0_虎柄_虎左_虎1);
			Are.Draw(this.X0Y0_虎柄_虎左_虎2);
			Are.Draw(this.X0Y0_虎柄_虎右_虎1);
			Are.Draw(this.X0Y0_虎柄_虎右_虎2);
			Are.Draw(this.X0Y0_竜性_左_鱗1);
			Are.Draw(this.X0Y0_竜性_左_鱗2);
			Are.Draw(this.X0Y0_竜性_左_鱗3);
			Are.Draw(this.X0Y0_竜性_右_鱗1);
			Are.Draw(this.X0Y0_竜性_右_鱗2);
			Are.Draw(this.X0Y0_竜性_右_鱗3);
		}

		public JointS 脇左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胸郭, 0);
			}
		}

		public JointS 脇右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胸郭, 1);
			}
		}

		public JointS 胴_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胸郭, 9);
			}
		}

		public JointS 胸左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胸郭, 2);
			}
		}

		public JointS 胸右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胸郭, 3);
			}
		}

		public JointS 肌_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胸郭, 10);
			}
		}

		public JointS 翼上左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胸郭, 7);
			}
		}

		public JointS 翼上右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胸郭, 8);
			}
		}

		public JointS 翼下左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胸郭, 11);
			}
		}

		public JointS 翼下右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胸郭, 12);
			}
		}

		public JointS 背中_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胸郭, 10);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_胸郭CP.Update();
			this.X0Y0_筋肉_筋肉左CP.Update();
			this.X0Y0_筋肉_筋肉右CP.Update();
			this.X0Y0_筋肉_筋肉中CP.Update();
			this.X0Y0_筋肉_筋肉左下CP.Update();
			this.X0Y0_筋肉_筋肉左中CP.Update();
			this.X0Y0_筋肉_筋肉左上CP.Update();
			this.X0Y0_筋肉_筋肉右下CP.Update();
			this.X0Y0_筋肉_筋肉右中CP.Update();
			this.X0Y0_筋肉_筋肉右上CP.Update();
			this.X0Y0_紋柄_紋左_紋1CP.Update();
			this.X0Y0_紋柄_紋左_紋2CP.Update();
			this.X0Y0_紋柄_紋左_紋3CP.Update();
			this.X0Y0_紋柄_紋左_紋4CP.Update();
			this.X0Y0_紋柄_紋右_紋1CP.Update();
			this.X0Y0_紋柄_紋右_紋2CP.Update();
			this.X0Y0_紋柄_紋右_紋3CP.Update();
			this.X0Y0_紋柄_紋右_紋4CP.Update();
			this.X0Y0_虎柄_虎左_虎1CP.Update();
			this.X0Y0_虎柄_虎左_虎2CP.Update();
			this.X0Y0_虎柄_虎右_虎1CP.Update();
			this.X0Y0_虎柄_虎右_虎2CP.Update();
			this.X0Y0_竜性_中_鱗左CP.Update();
			this.X0Y0_竜性_中_鱗右CP.Update();
			this.X0Y0_竜性_中_鱗1CP.Update();
			this.X0Y0_竜性_中_鱗2CP.Update();
			this.X0Y0_竜性_左_鱗1CP.Update();
			this.X0Y0_竜性_左_鱗2CP.Update();
			this.X0Y0_竜性_左_鱗3CP.Update();
			this.X0Y0_竜性_右_鱗1CP.Update();
			this.X0Y0_竜性_右_鱗2CP.Update();
			this.X0Y0_竜性_右_鱗3CP.Update();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.胸郭CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.筋肉_筋肉左CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋肉右CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋肉中CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋肉左下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋肉左中CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋肉左上CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋肉右下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋肉右中CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋肉右上CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.紋柄_紋左_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋左_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋右_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.虎柄_虎左_虎1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.虎柄_虎左_虎2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.虎柄_虎右_虎1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.虎柄_虎右_虎2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.竜性_中_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_中_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_中_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_中_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
		}

		public Par X0Y0_胸郭;

		public Par X0Y0_筋肉_筋肉左;

		public Par X0Y0_筋肉_筋肉右;

		public Par X0Y0_筋肉_筋肉中;

		public Par X0Y0_筋肉_筋肉左下;

		public Par X0Y0_筋肉_筋肉左中;

		public Par X0Y0_筋肉_筋肉左上;

		public Par X0Y0_筋肉_筋肉右下;

		public Par X0Y0_筋肉_筋肉右中;

		public Par X0Y0_筋肉_筋肉右上;

		public Par X0Y0_紋柄_紋左_紋1;

		public Par X0Y0_紋柄_紋左_紋2;

		public Par X0Y0_紋柄_紋左_紋3;

		public Par X0Y0_紋柄_紋左_紋4;

		public Par X0Y0_紋柄_紋右_紋1;

		public Par X0Y0_紋柄_紋右_紋2;

		public Par X0Y0_紋柄_紋右_紋3;

		public Par X0Y0_紋柄_紋右_紋4;

		public Par X0Y0_虎柄_虎左_虎1;

		public Par X0Y0_虎柄_虎左_虎2;

		public Par X0Y0_虎柄_虎右_虎1;

		public Par X0Y0_虎柄_虎右_虎2;

		public Par X0Y0_竜性_中_鱗左;

		public Par X0Y0_竜性_中_鱗右;

		public Par X0Y0_竜性_中_鱗1;

		public Par X0Y0_竜性_中_鱗2;

		public Par X0Y0_竜性_左_鱗1;

		public Par X0Y0_竜性_左_鱗2;

		public Par X0Y0_竜性_左_鱗3;

		public Par X0Y0_竜性_右_鱗1;

		public Par X0Y0_竜性_右_鱗2;

		public Par X0Y0_竜性_右_鱗3;

		public ColorD 胸郭CD;

		public ColorD 筋肉_筋肉左CD;

		public ColorD 筋肉_筋肉右CD;

		public ColorD 筋肉_筋肉中CD;

		public ColorD 筋肉_筋肉左下CD;

		public ColorD 筋肉_筋肉左中CD;

		public ColorD 筋肉_筋肉左上CD;

		public ColorD 筋肉_筋肉右下CD;

		public ColorD 筋肉_筋肉右中CD;

		public ColorD 筋肉_筋肉右上CD;

		public ColorD 紋柄_紋左_紋1CD;

		public ColorD 紋柄_紋左_紋2CD;

		public ColorD 紋柄_紋左_紋3CD;

		public ColorD 紋柄_紋左_紋4CD;

		public ColorD 紋柄_紋右_紋1CD;

		public ColorD 紋柄_紋右_紋2CD;

		public ColorD 紋柄_紋右_紋3CD;

		public ColorD 紋柄_紋右_紋4CD;

		public ColorD 虎柄_虎左_虎1CD;

		public ColorD 虎柄_虎左_虎2CD;

		public ColorD 虎柄_虎右_虎1CD;

		public ColorD 虎柄_虎右_虎2CD;

		public ColorD 竜性_中_鱗左CD;

		public ColorD 竜性_中_鱗右CD;

		public ColorD 竜性_中_鱗1CD;

		public ColorD 竜性_中_鱗2CD;

		public ColorD 竜性_左_鱗1CD;

		public ColorD 竜性_左_鱗2CD;

		public ColorD 竜性_左_鱗3CD;

		public ColorD 竜性_右_鱗1CD;

		public ColorD 竜性_右_鱗2CD;

		public ColorD 竜性_右_鱗3CD;

		public ColorP X0Y0_胸郭CP;

		public ColorP X0Y0_筋肉_筋肉左CP;

		public ColorP X0Y0_筋肉_筋肉右CP;

		public ColorP X0Y0_筋肉_筋肉中CP;

		public ColorP X0Y0_筋肉_筋肉左下CP;

		public ColorP X0Y0_筋肉_筋肉左中CP;

		public ColorP X0Y0_筋肉_筋肉左上CP;

		public ColorP X0Y0_筋肉_筋肉右下CP;

		public ColorP X0Y0_筋肉_筋肉右中CP;

		public ColorP X0Y0_筋肉_筋肉右上CP;

		public ColorP X0Y0_紋柄_紋左_紋1CP;

		public ColorP X0Y0_紋柄_紋左_紋2CP;

		public ColorP X0Y0_紋柄_紋左_紋3CP;

		public ColorP X0Y0_紋柄_紋左_紋4CP;

		public ColorP X0Y0_紋柄_紋右_紋1CP;

		public ColorP X0Y0_紋柄_紋右_紋2CP;

		public ColorP X0Y0_紋柄_紋右_紋3CP;

		public ColorP X0Y0_紋柄_紋右_紋4CP;

		public ColorP X0Y0_虎柄_虎左_虎1CP;

		public ColorP X0Y0_虎柄_虎左_虎2CP;

		public ColorP X0Y0_虎柄_虎右_虎1CP;

		public ColorP X0Y0_虎柄_虎右_虎2CP;

		public ColorP X0Y0_竜性_中_鱗左CP;

		public ColorP X0Y0_竜性_中_鱗右CP;

		public ColorP X0Y0_竜性_中_鱗1CP;

		public ColorP X0Y0_竜性_中_鱗2CP;

		public ColorP X0Y0_竜性_左_鱗1CP;

		public ColorP X0Y0_竜性_左_鱗2CP;

		public ColorP X0Y0_竜性_左_鱗3CP;

		public ColorP X0Y0_竜性_右_鱗1CP;

		public ColorP X0Y0_竜性_右_鱗2CP;

		public ColorP X0Y0_竜性_右_鱗3CP;

		public Ele[] 脇左_接続;

		public Ele[] 脇右_接続;

		public Ele[] 胴_接続;

		public Ele[] 胸左_接続;

		public Ele[] 胸右_接続;

		public Ele[] 肌_接続;

		public Ele[] 翼上左_接続;

		public Ele[] 翼上右_接続;

		public Ele[] 翼下左_接続;

		public Ele[] 翼下右_接続;

		public Ele[] 背中_接続;
	}
}
