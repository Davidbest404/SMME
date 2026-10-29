using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 頭頂_宇 : 頭頂
	{
		public 頭頂_宇(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 頭頂_宇D e)
		{
			頭頂_宇.<>c__DisplayClass243_0 CS$<>8__locals1 = new 頭頂_宇.<>c__DisplayClass243_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "エイリアン";
			dif.Add(new Pars(Sta.肢中["頭部前"][0][0]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			this.X0Y0_頭部 = pars["頭部"].ToPar();
			Pars pars2 = pars["頭頂部"].ToPars();
			Pars pars3 = pars2["透"].ToPars();
			this.X0Y0_頭頂部_透_基 = pars3["基"].ToPar();
			this.X0Y0_頭頂部_透_ハイライト1 = pars3["ハイライト1"].ToPar();
			this.X0Y0_頭頂部_透_ハイライト2 = pars3["ハイライト2"].ToPar();
			pars3 = pars2["鱗"].ToPars();
			this.X0Y0_頭頂部_鱗_鱗5 = pars3["鱗5"].ToPar();
			this.X0Y0_頭頂部_鱗_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_頭頂部_鱗_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_頭頂部_鱗_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_頭頂部_鱗_鱗1 = pars3["鱗1"].ToPar();
			pars2 = pars["左部"].ToPars();
			pars3 = pars2["鰓"].ToPars();
			this.X0Y0_左部_鰓_鰓11 = pars3["鰓11"].ToPar();
			this.X0Y0_左部_鰓_鰓10 = pars3["鰓10"].ToPar();
			this.X0Y0_左部_鰓_鰓9 = pars3["鰓9"].ToPar();
			this.X0Y0_左部_鰓_鰓8 = pars3["鰓8"].ToPar();
			this.X0Y0_左部_鰓_鰓7 = pars3["鰓7"].ToPar();
			this.X0Y0_左部_鰓_鰓6 = pars3["鰓6"].ToPar();
			this.X0Y0_左部_鰓_鰓5 = pars3["鰓5"].ToPar();
			this.X0Y0_左部_鰓_鰓4 = pars3["鰓4"].ToPar();
			this.X0Y0_左部_鰓_鰓3 = pars3["鰓3"].ToPar();
			this.X0Y0_左部_鰓_鰓2 = pars3["鰓2"].ToPar();
			this.X0Y0_左部_鰓_鰓1 = pars3["鰓1"].ToPar();
			pars3 = pars2["鱗"].ToPars();
			this.X0Y0_左部_鱗_鱗7 = pars3["鱗7"].ToPar();
			this.X0Y0_左部_鱗_鱗6 = pars3["鱗6"].ToPar();
			this.X0Y0_左部_鱗_鱗5 = pars3["鱗5"].ToPar();
			this.X0Y0_左部_鱗_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_左部_鱗_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_左部_鱗_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_左部_鱗_鱗1 = pars3["鱗1"].ToPar();
			pars2 = pars["右部"].ToPars();
			pars3 = pars2["鰓"].ToPars();
			this.X0Y0_右部_鰓_鰓11 = pars3["鰓11"].ToPar();
			this.X0Y0_右部_鰓_鰓10 = pars3["鰓10"].ToPar();
			this.X0Y0_右部_鰓_鰓9 = pars3["鰓9"].ToPar();
			this.X0Y0_右部_鰓_鰓8 = pars3["鰓8"].ToPar();
			this.X0Y0_右部_鰓_鰓7 = pars3["鰓7"].ToPar();
			this.X0Y0_右部_鰓_鰓6 = pars3["鰓6"].ToPar();
			this.X0Y0_右部_鰓_鰓5 = pars3["鰓5"].ToPar();
			this.X0Y0_右部_鰓_鰓4 = pars3["鰓4"].ToPar();
			this.X0Y0_右部_鰓_鰓3 = pars3["鰓3"].ToPar();
			this.X0Y0_右部_鰓_鰓2 = pars3["鰓2"].ToPar();
			this.X0Y0_右部_鰓_鰓1 = pars3["鰓1"].ToPar();
			pars3 = pars2["鱗"].ToPars();
			this.X0Y0_右部_鱗_鱗7 = pars3["鱗7"].ToPar();
			this.X0Y0_右部_鱗_鱗6 = pars3["鱗6"].ToPar();
			this.X0Y0_右部_鱗_鱗5 = pars3["鱗5"].ToPar();
			this.X0Y0_右部_鱗_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_右部_鱗_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_右部_鱗_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_右部_鱗_鱗1 = pars3["鱗1"].ToPar();
			pars2 = pars["鼻部"].ToPars();
			this.X0Y0_鼻部_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y0_鼻部_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_鼻部_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_鼻部_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y0_鼻部_鱗1 = pars2["鱗1"].ToPar();
			pars2 = pars["縁下"].ToPars();
			this.X0Y0_縁下_縁下 = pars2["縁下"].ToPar();
			pars3 = pars2["鱗"].ToPars();
			Pars pars4 = pars3["鱗左"].ToPars();
			this.X0Y0_縁下_鱗_鱗左_鱗7 = pars4["鱗7"].ToPar();
			this.X0Y0_縁下_鱗_鱗左_鱗6 = pars4["鱗6"].ToPar();
			this.X0Y0_縁下_鱗_鱗左_鱗5 = pars4["鱗5"].ToPar();
			this.X0Y0_縁下_鱗_鱗左_鱗4 = pars4["鱗4"].ToPar();
			this.X0Y0_縁下_鱗_鱗左_鱗3 = pars4["鱗3"].ToPar();
			this.X0Y0_縁下_鱗_鱗左_鱗2 = pars4["鱗2"].ToPar();
			this.X0Y0_縁下_鱗_鱗左_鱗1 = pars4["鱗1"].ToPar();
			pars4 = pars3["鱗右"].ToPars();
			this.X0Y0_縁下_鱗_鱗右_鱗7 = pars4["鱗7"].ToPar();
			this.X0Y0_縁下_鱗_鱗右_鱗6 = pars4["鱗6"].ToPar();
			this.X0Y0_縁下_鱗_鱗右_鱗5 = pars4["鱗5"].ToPar();
			this.X0Y0_縁下_鱗_鱗右_鱗4 = pars4["鱗4"].ToPar();
			this.X0Y0_縁下_鱗_鱗右_鱗3 = pars4["鱗3"].ToPar();
			this.X0Y0_縁下_鱗_鱗右_鱗2 = pars4["鱗2"].ToPar();
			this.X0Y0_縁下_鱗_鱗右_鱗1 = pars4["鱗1"].ToPar();
			this.X0Y0_縁下_鱗_鱗 = pars3["鱗"].ToPar();
			pars2 = pars["縁上"].ToPars();
			this.X0Y0_縁上_縁上 = pars2["縁上"].ToPar();
			pars3 = pars2["鱗"].ToPars();
			pars4 = pars3["鱗左"].ToPars();
			this.X0Y0_縁上_鱗_鱗左_鱗6 = pars4["鱗6"].ToPar();
			this.X0Y0_縁上_鱗_鱗左_鱗5 = pars4["鱗5"].ToPar();
			this.X0Y0_縁上_鱗_鱗左_鱗4 = pars4["鱗4"].ToPar();
			this.X0Y0_縁上_鱗_鱗左_鱗3 = pars4["鱗3"].ToPar();
			this.X0Y0_縁上_鱗_鱗左_鱗2 = pars4["鱗2"].ToPar();
			this.X0Y0_縁上_鱗_鱗左_鱗1 = pars4["鱗1"].ToPar();
			pars4 = pars3["鱗右"].ToPars();
			this.X0Y0_縁上_鱗_鱗右_鱗6 = pars4["鱗6"].ToPar();
			this.X0Y0_縁上_鱗_鱗右_鱗5 = pars4["鱗5"].ToPar();
			this.X0Y0_縁上_鱗_鱗右_鱗4 = pars4["鱗4"].ToPar();
			this.X0Y0_縁上_鱗_鱗右_鱗3 = pars4["鱗3"].ToPar();
			this.X0Y0_縁上_鱗_鱗右_鱗2 = pars4["鱗2"].ToPar();
			this.X0Y0_縁上_鱗_鱗右_鱗1 = pars4["鱗1"].ToPar();
			this.X0Y0_縁上_鱗_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_縁上_鱗_鱗2 = pars3["鱗2"].ToPar();
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
			this.頭部_表示 = e.頭部_表示;
			this.頭頂部_透_基_表示 = e.頭頂部_透_基_表示;
			this.頭頂部_透_ハイライト1_表示 = e.頭頂部_透_ハイライト1_表示;
			this.頭頂部_透_ハイライト2_表示 = e.頭頂部_透_ハイライト2_表示;
			this.頭頂部_鱗_鱗5_表示 = e.頭頂部_鱗_鱗5_表示;
			this.頭頂部_鱗_鱗4_表示 = e.頭頂部_鱗_鱗4_表示;
			this.頭頂部_鱗_鱗3_表示 = e.頭頂部_鱗_鱗3_表示;
			this.頭頂部_鱗_鱗2_表示 = e.頭頂部_鱗_鱗2_表示;
			this.頭頂部_鱗_鱗1_表示 = e.頭頂部_鱗_鱗1_表示;
			this.左部_鰓_鰓11_表示 = e.左部_鰓_鰓11_表示;
			this.左部_鰓_鰓10_表示 = e.左部_鰓_鰓10_表示;
			this.左部_鰓_鰓9_表示 = e.左部_鰓_鰓9_表示;
			this.左部_鰓_鰓8_表示 = e.左部_鰓_鰓8_表示;
			this.左部_鰓_鰓7_表示 = e.左部_鰓_鰓7_表示;
			this.左部_鰓_鰓6_表示 = e.左部_鰓_鰓6_表示;
			this.左部_鰓_鰓5_表示 = e.左部_鰓_鰓5_表示;
			this.左部_鰓_鰓4_表示 = e.左部_鰓_鰓4_表示;
			this.左部_鰓_鰓3_表示 = e.左部_鰓_鰓3_表示;
			this.左部_鰓_鰓2_表示 = e.左部_鰓_鰓2_表示;
			this.左部_鰓_鰓1_表示 = e.左部_鰓_鰓1_表示;
			this.左部_鱗_鱗7_表示 = e.左部_鱗_鱗7_表示;
			this.左部_鱗_鱗6_表示 = e.左部_鱗_鱗6_表示;
			this.左部_鱗_鱗5_表示 = e.左部_鱗_鱗5_表示;
			this.左部_鱗_鱗4_表示 = e.左部_鱗_鱗4_表示;
			this.左部_鱗_鱗3_表示 = e.左部_鱗_鱗3_表示;
			this.左部_鱗_鱗2_表示 = e.左部_鱗_鱗2_表示;
			this.左部_鱗_鱗1_表示 = e.左部_鱗_鱗1_表示;
			this.右部_鰓_鰓11_表示 = e.右部_鰓_鰓11_表示;
			this.右部_鰓_鰓10_表示 = e.右部_鰓_鰓10_表示;
			this.右部_鰓_鰓9_表示 = e.右部_鰓_鰓9_表示;
			this.右部_鰓_鰓8_表示 = e.右部_鰓_鰓8_表示;
			this.右部_鰓_鰓7_表示 = e.右部_鰓_鰓7_表示;
			this.右部_鰓_鰓6_表示 = e.右部_鰓_鰓6_表示;
			this.右部_鰓_鰓5_表示 = e.右部_鰓_鰓5_表示;
			this.右部_鰓_鰓4_表示 = e.右部_鰓_鰓4_表示;
			this.右部_鰓_鰓3_表示 = e.右部_鰓_鰓3_表示;
			this.右部_鰓_鰓2_表示 = e.右部_鰓_鰓2_表示;
			this.右部_鰓_鰓1_表示 = e.右部_鰓_鰓1_表示;
			this.右部_鱗_鱗7_表示 = e.右部_鱗_鱗7_表示;
			this.右部_鱗_鱗6_表示 = e.右部_鱗_鱗6_表示;
			this.右部_鱗_鱗5_表示 = e.右部_鱗_鱗5_表示;
			this.右部_鱗_鱗4_表示 = e.右部_鱗_鱗4_表示;
			this.右部_鱗_鱗3_表示 = e.右部_鱗_鱗3_表示;
			this.右部_鱗_鱗2_表示 = e.右部_鱗_鱗2_表示;
			this.右部_鱗_鱗1_表示 = e.右部_鱗_鱗1_表示;
			this.鼻部_鱗3_表示 = e.鼻部_鱗3_表示;
			this.鼻部_鱗左_表示 = e.鼻部_鱗左_表示;
			this.鼻部_鱗右_表示 = e.鼻部_鱗右_表示;
			this.鼻部_鱗2_表示 = e.鼻部_鱗2_表示;
			this.鼻部_鱗1_表示 = e.鼻部_鱗1_表示;
			this.縁下_縁下_表示 = e.縁下_縁下_表示;
			this.縁下_鱗_鱗左_鱗7_表示 = e.縁下_鱗_鱗左_鱗7_表示;
			this.縁下_鱗_鱗左_鱗6_表示 = e.縁下_鱗_鱗左_鱗6_表示;
			this.縁下_鱗_鱗左_鱗5_表示 = e.縁下_鱗_鱗左_鱗5_表示;
			this.縁下_鱗_鱗左_鱗4_表示 = e.縁下_鱗_鱗左_鱗4_表示;
			this.縁下_鱗_鱗左_鱗3_表示 = e.縁下_鱗_鱗左_鱗3_表示;
			this.縁下_鱗_鱗左_鱗2_表示 = e.縁下_鱗_鱗左_鱗2_表示;
			this.縁下_鱗_鱗左_鱗1_表示 = e.縁下_鱗_鱗左_鱗1_表示;
			this.縁下_鱗_鱗右_鱗7_表示 = e.縁下_鱗_鱗右_鱗7_表示;
			this.縁下_鱗_鱗右_鱗6_表示 = e.縁下_鱗_鱗右_鱗6_表示;
			this.縁下_鱗_鱗右_鱗5_表示 = e.縁下_鱗_鱗右_鱗5_表示;
			this.縁下_鱗_鱗右_鱗4_表示 = e.縁下_鱗_鱗右_鱗4_表示;
			this.縁下_鱗_鱗右_鱗3_表示 = e.縁下_鱗_鱗右_鱗3_表示;
			this.縁下_鱗_鱗右_鱗2_表示 = e.縁下_鱗_鱗右_鱗2_表示;
			this.縁下_鱗_鱗右_鱗1_表示 = e.縁下_鱗_鱗右_鱗1_表示;
			this.縁下_鱗_鱗_表示 = e.縁下_鱗_鱗_表示;
			this.縁上_縁上_表示 = e.縁上_縁上_表示;
			this.縁上_鱗_鱗左_鱗6_表示 = e.縁上_鱗_鱗左_鱗6_表示;
			this.縁上_鱗_鱗左_鱗5_表示 = e.縁上_鱗_鱗左_鱗5_表示;
			this.縁上_鱗_鱗左_鱗4_表示 = e.縁上_鱗_鱗左_鱗4_表示;
			this.縁上_鱗_鱗左_鱗3_表示 = e.縁上_鱗_鱗左_鱗3_表示;
			this.縁上_鱗_鱗左_鱗2_表示 = e.縁上_鱗_鱗左_鱗2_表示;
			this.縁上_鱗_鱗左_鱗1_表示 = e.縁上_鱗_鱗左_鱗1_表示;
			this.縁上_鱗_鱗右_鱗6_表示 = e.縁上_鱗_鱗右_鱗6_表示;
			this.縁上_鱗_鱗右_鱗5_表示 = e.縁上_鱗_鱗右_鱗5_表示;
			this.縁上_鱗_鱗右_鱗4_表示 = e.縁上_鱗_鱗右_鱗4_表示;
			this.縁上_鱗_鱗右_鱗3_表示 = e.縁上_鱗_鱗右_鱗3_表示;
			this.縁上_鱗_鱗右_鱗2_表示 = e.縁上_鱗_鱗右_鱗2_表示;
			this.縁上_鱗_鱗右_鱗1_表示 = e.縁上_鱗_鱗右_鱗1_表示;
			this.縁上_鱗_鱗1_表示 = e.縁上_鱗_鱗1_表示;
			this.縁上_鱗_鱗2_表示 = e.縁上_鱗_鱗2_表示;
			this.鱗 = e.鱗;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.頭部後_接続.Count > 0)
			{
				Ele f;
				this.頭部後_接続 = e.頭部後_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.頭頂_宇_頭部後_接続;
					f.接続(CS$<>8__locals1.<>4__this.頭部後_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_頭部CP = new ColorP(this.X0Y0_頭部, this.頭部CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭頂部_透_基CP = new ColorP(this.X0Y0_頭頂部_透_基, this.頭頂部_透_基CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭頂部_透_ハイライト1CP = new ColorP(this.X0Y0_頭頂部_透_ハイライト1, this.頭頂部_透_ハイライト1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭頂部_透_ハイライト2CP = new ColorP(this.X0Y0_頭頂部_透_ハイライト2, this.頭頂部_透_ハイライト2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭頂部_鱗_鱗5CP = new ColorP(this.X0Y0_頭頂部_鱗_鱗5, this.頭頂部_鱗_鱗5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭頂部_鱗_鱗4CP = new ColorP(this.X0Y0_頭頂部_鱗_鱗4, this.頭頂部_鱗_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭頂部_鱗_鱗3CP = new ColorP(this.X0Y0_頭頂部_鱗_鱗3, this.頭頂部_鱗_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭頂部_鱗_鱗2CP = new ColorP(this.X0Y0_頭頂部_鱗_鱗2, this.頭頂部_鱗_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭頂部_鱗_鱗1CP = new ColorP(this.X0Y0_頭頂部_鱗_鱗1, this.頭頂部_鱗_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左部_鰓_鰓11CP = new ColorP(this.X0Y0_左部_鰓_鰓11, this.左部_鰓_鰓11CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左部_鰓_鰓10CP = new ColorP(this.X0Y0_左部_鰓_鰓10, this.左部_鰓_鰓10CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左部_鰓_鰓9CP = new ColorP(this.X0Y0_左部_鰓_鰓9, this.左部_鰓_鰓9CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左部_鰓_鰓8CP = new ColorP(this.X0Y0_左部_鰓_鰓8, this.左部_鰓_鰓8CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左部_鰓_鰓7CP = new ColorP(this.X0Y0_左部_鰓_鰓7, this.左部_鰓_鰓7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左部_鰓_鰓6CP = new ColorP(this.X0Y0_左部_鰓_鰓6, this.左部_鰓_鰓6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左部_鰓_鰓5CP = new ColorP(this.X0Y0_左部_鰓_鰓5, this.左部_鰓_鰓5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左部_鰓_鰓4CP = new ColorP(this.X0Y0_左部_鰓_鰓4, this.左部_鰓_鰓4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左部_鰓_鰓3CP = new ColorP(this.X0Y0_左部_鰓_鰓3, this.左部_鰓_鰓3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左部_鰓_鰓2CP = new ColorP(this.X0Y0_左部_鰓_鰓2, this.左部_鰓_鰓2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左部_鰓_鰓1CP = new ColorP(this.X0Y0_左部_鰓_鰓1, this.左部_鰓_鰓1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左部_鱗_鱗7CP = new ColorP(this.X0Y0_左部_鱗_鱗7, this.左部_鱗_鱗7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左部_鱗_鱗6CP = new ColorP(this.X0Y0_左部_鱗_鱗6, this.左部_鱗_鱗6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左部_鱗_鱗5CP = new ColorP(this.X0Y0_左部_鱗_鱗5, this.左部_鱗_鱗5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左部_鱗_鱗4CP = new ColorP(this.X0Y0_左部_鱗_鱗4, this.左部_鱗_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左部_鱗_鱗3CP = new ColorP(this.X0Y0_左部_鱗_鱗3, this.左部_鱗_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左部_鱗_鱗2CP = new ColorP(this.X0Y0_左部_鱗_鱗2, this.左部_鱗_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_左部_鱗_鱗1CP = new ColorP(this.X0Y0_左部_鱗_鱗1, this.左部_鱗_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右部_鰓_鰓11CP = new ColorP(this.X0Y0_右部_鰓_鰓11, this.右部_鰓_鰓11CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右部_鰓_鰓10CP = new ColorP(this.X0Y0_右部_鰓_鰓10, this.右部_鰓_鰓10CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右部_鰓_鰓9CP = new ColorP(this.X0Y0_右部_鰓_鰓9, this.右部_鰓_鰓9CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右部_鰓_鰓8CP = new ColorP(this.X0Y0_右部_鰓_鰓8, this.右部_鰓_鰓8CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右部_鰓_鰓7CP = new ColorP(this.X0Y0_右部_鰓_鰓7, this.右部_鰓_鰓7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右部_鰓_鰓6CP = new ColorP(this.X0Y0_右部_鰓_鰓6, this.右部_鰓_鰓6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右部_鰓_鰓5CP = new ColorP(this.X0Y0_右部_鰓_鰓5, this.右部_鰓_鰓5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右部_鰓_鰓4CP = new ColorP(this.X0Y0_右部_鰓_鰓4, this.右部_鰓_鰓4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右部_鰓_鰓3CP = new ColorP(this.X0Y0_右部_鰓_鰓3, this.右部_鰓_鰓3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右部_鰓_鰓2CP = new ColorP(this.X0Y0_右部_鰓_鰓2, this.右部_鰓_鰓2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右部_鰓_鰓1CP = new ColorP(this.X0Y0_右部_鰓_鰓1, this.右部_鰓_鰓1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右部_鱗_鱗7CP = new ColorP(this.X0Y0_右部_鱗_鱗7, this.右部_鱗_鱗7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右部_鱗_鱗6CP = new ColorP(this.X0Y0_右部_鱗_鱗6, this.右部_鱗_鱗6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右部_鱗_鱗5CP = new ColorP(this.X0Y0_右部_鱗_鱗5, this.右部_鱗_鱗5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右部_鱗_鱗4CP = new ColorP(this.X0Y0_右部_鱗_鱗4, this.右部_鱗_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右部_鱗_鱗3CP = new ColorP(this.X0Y0_右部_鱗_鱗3, this.右部_鱗_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右部_鱗_鱗2CP = new ColorP(this.X0Y0_右部_鱗_鱗2, this.右部_鱗_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_右部_鱗_鱗1CP = new ColorP(this.X0Y0_右部_鱗_鱗1, this.右部_鱗_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_鼻部_鱗3CP = new ColorP(this.X0Y0_鼻部_鱗3, this.鼻部_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_鼻部_鱗左CP = new ColorP(this.X0Y0_鼻部_鱗左, this.鼻部_鱗左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_鼻部_鱗右CP = new ColorP(this.X0Y0_鼻部_鱗右, this.鼻部_鱗右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_鼻部_鱗2CP = new ColorP(this.X0Y0_鼻部_鱗2, this.鼻部_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_鼻部_鱗1CP = new ColorP(this.X0Y0_鼻部_鱗1, this.鼻部_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁下_縁下CP = new ColorP(this.X0Y0_縁下_縁下, this.縁下_縁下CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁下_鱗_鱗左_鱗7CP = new ColorP(this.X0Y0_縁下_鱗_鱗左_鱗7, this.縁下_鱗_鱗左_鱗7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁下_鱗_鱗左_鱗6CP = new ColorP(this.X0Y0_縁下_鱗_鱗左_鱗6, this.縁下_鱗_鱗左_鱗6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁下_鱗_鱗左_鱗5CP = new ColorP(this.X0Y0_縁下_鱗_鱗左_鱗5, this.縁下_鱗_鱗左_鱗5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁下_鱗_鱗左_鱗4CP = new ColorP(this.X0Y0_縁下_鱗_鱗左_鱗4, this.縁下_鱗_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁下_鱗_鱗左_鱗3CP = new ColorP(this.X0Y0_縁下_鱗_鱗左_鱗3, this.縁下_鱗_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁下_鱗_鱗左_鱗2CP = new ColorP(this.X0Y0_縁下_鱗_鱗左_鱗2, this.縁下_鱗_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁下_鱗_鱗左_鱗1CP = new ColorP(this.X0Y0_縁下_鱗_鱗左_鱗1, this.縁下_鱗_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁下_鱗_鱗右_鱗7CP = new ColorP(this.X0Y0_縁下_鱗_鱗右_鱗7, this.縁下_鱗_鱗右_鱗7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁下_鱗_鱗右_鱗6CP = new ColorP(this.X0Y0_縁下_鱗_鱗右_鱗6, this.縁下_鱗_鱗右_鱗6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁下_鱗_鱗右_鱗5CP = new ColorP(this.X0Y0_縁下_鱗_鱗右_鱗5, this.縁下_鱗_鱗右_鱗5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁下_鱗_鱗右_鱗4CP = new ColorP(this.X0Y0_縁下_鱗_鱗右_鱗4, this.縁下_鱗_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁下_鱗_鱗右_鱗3CP = new ColorP(this.X0Y0_縁下_鱗_鱗右_鱗3, this.縁下_鱗_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁下_鱗_鱗右_鱗2CP = new ColorP(this.X0Y0_縁下_鱗_鱗右_鱗2, this.縁下_鱗_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁下_鱗_鱗右_鱗1CP = new ColorP(this.X0Y0_縁下_鱗_鱗右_鱗1, this.縁下_鱗_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁下_鱗_鱗CP = new ColorP(this.X0Y0_縁下_鱗_鱗, this.縁下_鱗_鱗CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁上_縁上CP = new ColorP(this.X0Y0_縁上_縁上, this.縁上_縁上CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁上_鱗_鱗左_鱗6CP = new ColorP(this.X0Y0_縁上_鱗_鱗左_鱗6, this.縁上_鱗_鱗左_鱗6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁上_鱗_鱗左_鱗5CP = new ColorP(this.X0Y0_縁上_鱗_鱗左_鱗5, this.縁上_鱗_鱗左_鱗5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁上_鱗_鱗左_鱗4CP = new ColorP(this.X0Y0_縁上_鱗_鱗左_鱗4, this.縁上_鱗_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁上_鱗_鱗左_鱗3CP = new ColorP(this.X0Y0_縁上_鱗_鱗左_鱗3, this.縁上_鱗_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁上_鱗_鱗左_鱗2CP = new ColorP(this.X0Y0_縁上_鱗_鱗左_鱗2, this.縁上_鱗_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁上_鱗_鱗左_鱗1CP = new ColorP(this.X0Y0_縁上_鱗_鱗左_鱗1, this.縁上_鱗_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁上_鱗_鱗右_鱗6CP = new ColorP(this.X0Y0_縁上_鱗_鱗右_鱗6, this.縁上_鱗_鱗右_鱗6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁上_鱗_鱗右_鱗5CP = new ColorP(this.X0Y0_縁上_鱗_鱗右_鱗5, this.縁上_鱗_鱗右_鱗5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁上_鱗_鱗右_鱗4CP = new ColorP(this.X0Y0_縁上_鱗_鱗右_鱗4, this.縁上_鱗_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁上_鱗_鱗右_鱗3CP = new ColorP(this.X0Y0_縁上_鱗_鱗右_鱗3, this.縁上_鱗_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁上_鱗_鱗右_鱗2CP = new ColorP(this.X0Y0_縁上_鱗_鱗右_鱗2, this.縁上_鱗_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁上_鱗_鱗右_鱗1CP = new ColorP(this.X0Y0_縁上_鱗_鱗右_鱗1, this.縁上_鱗_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁上_鱗_鱗1CP = new ColorP(this.X0Y0_縁上_鱗_鱗1, this.縁上_鱗_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_縁上_鱗_鱗2CP = new ColorP(this.X0Y0_縁上_鱗_鱗2, this.縁上_鱗_鱗2CD, CS$<>8__locals1.DisUnit, true);
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

		public bool 頭部_表示
		{
			get
			{
				return this.X0Y0_頭部.Dra;
			}
			set
			{
				this.X0Y0_頭部.Dra = value;
				this.X0Y0_頭部.Hit = value;
			}
		}

		public bool 頭頂部_透_基_表示
		{
			get
			{
				return this.X0Y0_頭頂部_透_基.Dra;
			}
			set
			{
				this.X0Y0_頭頂部_透_基.Dra = value;
				this.X0Y0_頭頂部_透_基.Hit = value;
			}
		}

		public bool 頭頂部_透_ハイライト1_表示
		{
			get
			{
				return this.X0Y0_頭頂部_透_ハイライト1.Dra;
			}
			set
			{
				this.X0Y0_頭頂部_透_ハイライト1.Dra = value;
				this.X0Y0_頭頂部_透_ハイライト1.Hit = value;
			}
		}

		public bool 頭頂部_透_ハイライト2_表示
		{
			get
			{
				return this.X0Y0_頭頂部_透_ハイライト2.Dra;
			}
			set
			{
				this.X0Y0_頭頂部_透_ハイライト2.Dra = value;
				this.X0Y0_頭頂部_透_ハイライト2.Hit = value;
			}
		}

		public bool 頭頂部_鱗_鱗5_表示
		{
			get
			{
				return this.X0Y0_頭頂部_鱗_鱗5.Dra;
			}
			set
			{
				this.X0Y0_頭頂部_鱗_鱗5.Dra = value;
				this.X0Y0_頭頂部_鱗_鱗5.Hit = value;
			}
		}

		public bool 頭頂部_鱗_鱗4_表示
		{
			get
			{
				return this.X0Y0_頭頂部_鱗_鱗4.Dra;
			}
			set
			{
				this.X0Y0_頭頂部_鱗_鱗4.Dra = value;
				this.X0Y0_頭頂部_鱗_鱗4.Hit = value;
			}
		}

		public bool 頭頂部_鱗_鱗3_表示
		{
			get
			{
				return this.X0Y0_頭頂部_鱗_鱗3.Dra;
			}
			set
			{
				this.X0Y0_頭頂部_鱗_鱗3.Dra = value;
				this.X0Y0_頭頂部_鱗_鱗3.Hit = value;
			}
		}

		public bool 頭頂部_鱗_鱗2_表示
		{
			get
			{
				return this.X0Y0_頭頂部_鱗_鱗2.Dra;
			}
			set
			{
				this.X0Y0_頭頂部_鱗_鱗2.Dra = value;
				this.X0Y0_頭頂部_鱗_鱗2.Hit = value;
			}
		}

		public bool 頭頂部_鱗_鱗1_表示
		{
			get
			{
				return this.X0Y0_頭頂部_鱗_鱗1.Dra;
			}
			set
			{
				this.X0Y0_頭頂部_鱗_鱗1.Dra = value;
				this.X0Y0_頭頂部_鱗_鱗1.Hit = value;
			}
		}

		public bool 左部_鰓_鰓11_表示
		{
			get
			{
				return this.X0Y0_左部_鰓_鰓11.Dra;
			}
			set
			{
				this.X0Y0_左部_鰓_鰓11.Dra = value;
				this.X0Y0_左部_鰓_鰓11.Hit = value;
			}
		}

		public bool 左部_鰓_鰓10_表示
		{
			get
			{
				return this.X0Y0_左部_鰓_鰓10.Dra;
			}
			set
			{
				this.X0Y0_左部_鰓_鰓10.Dra = value;
				this.X0Y0_左部_鰓_鰓10.Hit = value;
			}
		}

		public bool 左部_鰓_鰓9_表示
		{
			get
			{
				return this.X0Y0_左部_鰓_鰓9.Dra;
			}
			set
			{
				this.X0Y0_左部_鰓_鰓9.Dra = value;
				this.X0Y0_左部_鰓_鰓9.Hit = value;
			}
		}

		public bool 左部_鰓_鰓8_表示
		{
			get
			{
				return this.X0Y0_左部_鰓_鰓8.Dra;
			}
			set
			{
				this.X0Y0_左部_鰓_鰓8.Dra = value;
				this.X0Y0_左部_鰓_鰓8.Hit = value;
			}
		}

		public bool 左部_鰓_鰓7_表示
		{
			get
			{
				return this.X0Y0_左部_鰓_鰓7.Dra;
			}
			set
			{
				this.X0Y0_左部_鰓_鰓7.Dra = value;
				this.X0Y0_左部_鰓_鰓7.Hit = value;
			}
		}

		public bool 左部_鰓_鰓6_表示
		{
			get
			{
				return this.X0Y0_左部_鰓_鰓6.Dra;
			}
			set
			{
				this.X0Y0_左部_鰓_鰓6.Dra = value;
				this.X0Y0_左部_鰓_鰓6.Hit = value;
			}
		}

		public bool 左部_鰓_鰓5_表示
		{
			get
			{
				return this.X0Y0_左部_鰓_鰓5.Dra;
			}
			set
			{
				this.X0Y0_左部_鰓_鰓5.Dra = value;
				this.X0Y0_左部_鰓_鰓5.Hit = value;
			}
		}

		public bool 左部_鰓_鰓4_表示
		{
			get
			{
				return this.X0Y0_左部_鰓_鰓4.Dra;
			}
			set
			{
				this.X0Y0_左部_鰓_鰓4.Dra = value;
				this.X0Y0_左部_鰓_鰓4.Hit = value;
			}
		}

		public bool 左部_鰓_鰓3_表示
		{
			get
			{
				return this.X0Y0_左部_鰓_鰓3.Dra;
			}
			set
			{
				this.X0Y0_左部_鰓_鰓3.Dra = value;
				this.X0Y0_左部_鰓_鰓3.Hit = value;
			}
		}

		public bool 左部_鰓_鰓2_表示
		{
			get
			{
				return this.X0Y0_左部_鰓_鰓2.Dra;
			}
			set
			{
				this.X0Y0_左部_鰓_鰓2.Dra = value;
				this.X0Y0_左部_鰓_鰓2.Hit = value;
			}
		}

		public bool 左部_鰓_鰓1_表示
		{
			get
			{
				return this.X0Y0_左部_鰓_鰓1.Dra;
			}
			set
			{
				this.X0Y0_左部_鰓_鰓1.Dra = value;
				this.X0Y0_左部_鰓_鰓1.Hit = value;
			}
		}

		public bool 左部_鱗_鱗7_表示
		{
			get
			{
				return this.X0Y0_左部_鱗_鱗7.Dra;
			}
			set
			{
				this.X0Y0_左部_鱗_鱗7.Dra = value;
				this.X0Y0_左部_鱗_鱗7.Hit = value;
			}
		}

		public bool 左部_鱗_鱗6_表示
		{
			get
			{
				return this.X0Y0_左部_鱗_鱗6.Dra;
			}
			set
			{
				this.X0Y0_左部_鱗_鱗6.Dra = value;
				this.X0Y0_左部_鱗_鱗6.Hit = value;
			}
		}

		public bool 左部_鱗_鱗5_表示
		{
			get
			{
				return this.X0Y0_左部_鱗_鱗5.Dra;
			}
			set
			{
				this.X0Y0_左部_鱗_鱗5.Dra = value;
				this.X0Y0_左部_鱗_鱗5.Hit = value;
			}
		}

		public bool 左部_鱗_鱗4_表示
		{
			get
			{
				return this.X0Y0_左部_鱗_鱗4.Dra;
			}
			set
			{
				this.X0Y0_左部_鱗_鱗4.Dra = value;
				this.X0Y0_左部_鱗_鱗4.Hit = value;
			}
		}

		public bool 左部_鱗_鱗3_表示
		{
			get
			{
				return this.X0Y0_左部_鱗_鱗3.Dra;
			}
			set
			{
				this.X0Y0_左部_鱗_鱗3.Dra = value;
				this.X0Y0_左部_鱗_鱗3.Hit = value;
			}
		}

		public bool 左部_鱗_鱗2_表示
		{
			get
			{
				return this.X0Y0_左部_鱗_鱗2.Dra;
			}
			set
			{
				this.X0Y0_左部_鱗_鱗2.Dra = value;
				this.X0Y0_左部_鱗_鱗2.Hit = value;
			}
		}

		public bool 左部_鱗_鱗1_表示
		{
			get
			{
				return this.X0Y0_左部_鱗_鱗1.Dra;
			}
			set
			{
				this.X0Y0_左部_鱗_鱗1.Dra = value;
				this.X0Y0_左部_鱗_鱗1.Hit = value;
			}
		}

		public bool 右部_鰓_鰓11_表示
		{
			get
			{
				return this.X0Y0_右部_鰓_鰓11.Dra;
			}
			set
			{
				this.X0Y0_右部_鰓_鰓11.Dra = value;
				this.X0Y0_右部_鰓_鰓11.Hit = value;
			}
		}

		public bool 右部_鰓_鰓10_表示
		{
			get
			{
				return this.X0Y0_右部_鰓_鰓10.Dra;
			}
			set
			{
				this.X0Y0_右部_鰓_鰓10.Dra = value;
				this.X0Y0_右部_鰓_鰓10.Hit = value;
			}
		}

		public bool 右部_鰓_鰓9_表示
		{
			get
			{
				return this.X0Y0_右部_鰓_鰓9.Dra;
			}
			set
			{
				this.X0Y0_右部_鰓_鰓9.Dra = value;
				this.X0Y0_右部_鰓_鰓9.Hit = value;
			}
		}

		public bool 右部_鰓_鰓8_表示
		{
			get
			{
				return this.X0Y0_右部_鰓_鰓8.Dra;
			}
			set
			{
				this.X0Y0_右部_鰓_鰓8.Dra = value;
				this.X0Y0_右部_鰓_鰓8.Hit = value;
			}
		}

		public bool 右部_鰓_鰓7_表示
		{
			get
			{
				return this.X0Y0_右部_鰓_鰓7.Dra;
			}
			set
			{
				this.X0Y0_右部_鰓_鰓7.Dra = value;
				this.X0Y0_右部_鰓_鰓7.Hit = value;
			}
		}

		public bool 右部_鰓_鰓6_表示
		{
			get
			{
				return this.X0Y0_右部_鰓_鰓6.Dra;
			}
			set
			{
				this.X0Y0_右部_鰓_鰓6.Dra = value;
				this.X0Y0_右部_鰓_鰓6.Hit = value;
			}
		}

		public bool 右部_鰓_鰓5_表示
		{
			get
			{
				return this.X0Y0_右部_鰓_鰓5.Dra;
			}
			set
			{
				this.X0Y0_右部_鰓_鰓5.Dra = value;
				this.X0Y0_右部_鰓_鰓5.Hit = value;
			}
		}

		public bool 右部_鰓_鰓4_表示
		{
			get
			{
				return this.X0Y0_右部_鰓_鰓4.Dra;
			}
			set
			{
				this.X0Y0_右部_鰓_鰓4.Dra = value;
				this.X0Y0_右部_鰓_鰓4.Hit = value;
			}
		}

		public bool 右部_鰓_鰓3_表示
		{
			get
			{
				return this.X0Y0_右部_鰓_鰓3.Dra;
			}
			set
			{
				this.X0Y0_右部_鰓_鰓3.Dra = value;
				this.X0Y0_右部_鰓_鰓3.Hit = value;
			}
		}

		public bool 右部_鰓_鰓2_表示
		{
			get
			{
				return this.X0Y0_右部_鰓_鰓2.Dra;
			}
			set
			{
				this.X0Y0_右部_鰓_鰓2.Dra = value;
				this.X0Y0_右部_鰓_鰓2.Hit = value;
			}
		}

		public bool 右部_鰓_鰓1_表示
		{
			get
			{
				return this.X0Y0_右部_鰓_鰓1.Dra;
			}
			set
			{
				this.X0Y0_右部_鰓_鰓1.Dra = value;
				this.X0Y0_右部_鰓_鰓1.Hit = value;
			}
		}

		public bool 右部_鱗_鱗7_表示
		{
			get
			{
				return this.X0Y0_右部_鱗_鱗7.Dra;
			}
			set
			{
				this.X0Y0_右部_鱗_鱗7.Dra = value;
				this.X0Y0_右部_鱗_鱗7.Hit = value;
			}
		}

		public bool 右部_鱗_鱗6_表示
		{
			get
			{
				return this.X0Y0_右部_鱗_鱗6.Dra;
			}
			set
			{
				this.X0Y0_右部_鱗_鱗6.Dra = value;
				this.X0Y0_右部_鱗_鱗6.Hit = value;
			}
		}

		public bool 右部_鱗_鱗5_表示
		{
			get
			{
				return this.X0Y0_右部_鱗_鱗5.Dra;
			}
			set
			{
				this.X0Y0_右部_鱗_鱗5.Dra = value;
				this.X0Y0_右部_鱗_鱗5.Hit = value;
			}
		}

		public bool 右部_鱗_鱗4_表示
		{
			get
			{
				return this.X0Y0_右部_鱗_鱗4.Dra;
			}
			set
			{
				this.X0Y0_右部_鱗_鱗4.Dra = value;
				this.X0Y0_右部_鱗_鱗4.Hit = value;
			}
		}

		public bool 右部_鱗_鱗3_表示
		{
			get
			{
				return this.X0Y0_右部_鱗_鱗3.Dra;
			}
			set
			{
				this.X0Y0_右部_鱗_鱗3.Dra = value;
				this.X0Y0_右部_鱗_鱗3.Hit = value;
			}
		}

		public bool 右部_鱗_鱗2_表示
		{
			get
			{
				return this.X0Y0_右部_鱗_鱗2.Dra;
			}
			set
			{
				this.X0Y0_右部_鱗_鱗2.Dra = value;
				this.X0Y0_右部_鱗_鱗2.Hit = value;
			}
		}

		public bool 右部_鱗_鱗1_表示
		{
			get
			{
				return this.X0Y0_右部_鱗_鱗1.Dra;
			}
			set
			{
				this.X0Y0_右部_鱗_鱗1.Dra = value;
				this.X0Y0_右部_鱗_鱗1.Hit = value;
			}
		}

		public bool 鼻部_鱗3_表示
		{
			get
			{
				return this.X0Y0_鼻部_鱗3.Dra;
			}
			set
			{
				this.X0Y0_鼻部_鱗3.Dra = value;
				this.X0Y0_鼻部_鱗3.Hit = value;
			}
		}

		public bool 鼻部_鱗左_表示
		{
			get
			{
				return this.X0Y0_鼻部_鱗左.Dra;
			}
			set
			{
				this.X0Y0_鼻部_鱗左.Dra = value;
				this.X0Y0_鼻部_鱗左.Hit = value;
			}
		}

		public bool 鼻部_鱗右_表示
		{
			get
			{
				return this.X0Y0_鼻部_鱗右.Dra;
			}
			set
			{
				this.X0Y0_鼻部_鱗右.Dra = value;
				this.X0Y0_鼻部_鱗右.Hit = value;
			}
		}

		public bool 鼻部_鱗2_表示
		{
			get
			{
				return this.X0Y0_鼻部_鱗2.Dra;
			}
			set
			{
				this.X0Y0_鼻部_鱗2.Dra = value;
				this.X0Y0_鼻部_鱗2.Hit = value;
			}
		}

		public bool 鼻部_鱗1_表示
		{
			get
			{
				return this.X0Y0_鼻部_鱗1.Dra;
			}
			set
			{
				this.X0Y0_鼻部_鱗1.Dra = value;
				this.X0Y0_鼻部_鱗1.Hit = value;
			}
		}

		public bool 縁下_縁下_表示
		{
			get
			{
				return this.X0Y0_縁下_縁下.Dra;
			}
			set
			{
				this.X0Y0_縁下_縁下.Dra = value;
				this.X0Y0_縁下_縁下.Hit = value;
			}
		}

		public bool 縁下_鱗_鱗左_鱗7_表示
		{
			get
			{
				return this.X0Y0_縁下_鱗_鱗左_鱗7.Dra;
			}
			set
			{
				this.X0Y0_縁下_鱗_鱗左_鱗7.Dra = value;
				this.X0Y0_縁下_鱗_鱗左_鱗7.Hit = value;
			}
		}

		public bool 縁下_鱗_鱗左_鱗6_表示
		{
			get
			{
				return this.X0Y0_縁下_鱗_鱗左_鱗6.Dra;
			}
			set
			{
				this.X0Y0_縁下_鱗_鱗左_鱗6.Dra = value;
				this.X0Y0_縁下_鱗_鱗左_鱗6.Hit = value;
			}
		}

		public bool 縁下_鱗_鱗左_鱗5_表示
		{
			get
			{
				return this.X0Y0_縁下_鱗_鱗左_鱗5.Dra;
			}
			set
			{
				this.X0Y0_縁下_鱗_鱗左_鱗5.Dra = value;
				this.X0Y0_縁下_鱗_鱗左_鱗5.Hit = value;
			}
		}

		public bool 縁下_鱗_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_縁下_鱗_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_縁下_鱗_鱗左_鱗4.Dra = value;
				this.X0Y0_縁下_鱗_鱗左_鱗4.Hit = value;
			}
		}

		public bool 縁下_鱗_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_縁下_鱗_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_縁下_鱗_鱗左_鱗3.Dra = value;
				this.X0Y0_縁下_鱗_鱗左_鱗3.Hit = value;
			}
		}

		public bool 縁下_鱗_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_縁下_鱗_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_縁下_鱗_鱗左_鱗2.Dra = value;
				this.X0Y0_縁下_鱗_鱗左_鱗2.Hit = value;
			}
		}

		public bool 縁下_鱗_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_縁下_鱗_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_縁下_鱗_鱗左_鱗1.Dra = value;
				this.X0Y0_縁下_鱗_鱗左_鱗1.Hit = value;
			}
		}

		public bool 縁下_鱗_鱗右_鱗7_表示
		{
			get
			{
				return this.X0Y0_縁下_鱗_鱗右_鱗7.Dra;
			}
			set
			{
				this.X0Y0_縁下_鱗_鱗右_鱗7.Dra = value;
				this.X0Y0_縁下_鱗_鱗右_鱗7.Hit = value;
			}
		}

		public bool 縁下_鱗_鱗右_鱗6_表示
		{
			get
			{
				return this.X0Y0_縁下_鱗_鱗右_鱗6.Dra;
			}
			set
			{
				this.X0Y0_縁下_鱗_鱗右_鱗6.Dra = value;
				this.X0Y0_縁下_鱗_鱗右_鱗6.Hit = value;
			}
		}

		public bool 縁下_鱗_鱗右_鱗5_表示
		{
			get
			{
				return this.X0Y0_縁下_鱗_鱗右_鱗5.Dra;
			}
			set
			{
				this.X0Y0_縁下_鱗_鱗右_鱗5.Dra = value;
				this.X0Y0_縁下_鱗_鱗右_鱗5.Hit = value;
			}
		}

		public bool 縁下_鱗_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_縁下_鱗_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_縁下_鱗_鱗右_鱗4.Dra = value;
				this.X0Y0_縁下_鱗_鱗右_鱗4.Hit = value;
			}
		}

		public bool 縁下_鱗_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_縁下_鱗_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_縁下_鱗_鱗右_鱗3.Dra = value;
				this.X0Y0_縁下_鱗_鱗右_鱗3.Hit = value;
			}
		}

		public bool 縁下_鱗_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_縁下_鱗_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_縁下_鱗_鱗右_鱗2.Dra = value;
				this.X0Y0_縁下_鱗_鱗右_鱗2.Hit = value;
			}
		}

		public bool 縁下_鱗_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_縁下_鱗_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_縁下_鱗_鱗右_鱗1.Dra = value;
				this.X0Y0_縁下_鱗_鱗右_鱗1.Hit = value;
			}
		}

		public bool 縁下_鱗_鱗_表示
		{
			get
			{
				return this.X0Y0_縁下_鱗_鱗.Dra;
			}
			set
			{
				this.X0Y0_縁下_鱗_鱗.Dra = value;
				this.X0Y0_縁下_鱗_鱗.Hit = value;
			}
		}

		public bool 縁上_縁上_表示
		{
			get
			{
				return this.X0Y0_縁上_縁上.Dra;
			}
			set
			{
				this.X0Y0_縁上_縁上.Dra = value;
				this.X0Y0_縁上_縁上.Hit = value;
			}
		}

		public bool 縁上_鱗_鱗左_鱗6_表示
		{
			get
			{
				return this.X0Y0_縁上_鱗_鱗左_鱗6.Dra;
			}
			set
			{
				this.X0Y0_縁上_鱗_鱗左_鱗6.Dra = value;
				this.X0Y0_縁上_鱗_鱗左_鱗6.Hit = value;
			}
		}

		public bool 縁上_鱗_鱗左_鱗5_表示
		{
			get
			{
				return this.X0Y0_縁上_鱗_鱗左_鱗5.Dra;
			}
			set
			{
				this.X0Y0_縁上_鱗_鱗左_鱗5.Dra = value;
				this.X0Y0_縁上_鱗_鱗左_鱗5.Hit = value;
			}
		}

		public bool 縁上_鱗_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_縁上_鱗_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_縁上_鱗_鱗左_鱗4.Dra = value;
				this.X0Y0_縁上_鱗_鱗左_鱗4.Hit = value;
			}
		}

		public bool 縁上_鱗_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_縁上_鱗_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_縁上_鱗_鱗左_鱗3.Dra = value;
				this.X0Y0_縁上_鱗_鱗左_鱗3.Hit = value;
			}
		}

		public bool 縁上_鱗_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_縁上_鱗_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_縁上_鱗_鱗左_鱗2.Dra = value;
				this.X0Y0_縁上_鱗_鱗左_鱗2.Hit = value;
			}
		}

		public bool 縁上_鱗_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_縁上_鱗_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_縁上_鱗_鱗左_鱗1.Dra = value;
				this.X0Y0_縁上_鱗_鱗左_鱗1.Hit = value;
			}
		}

		public bool 縁上_鱗_鱗右_鱗6_表示
		{
			get
			{
				return this.X0Y0_縁上_鱗_鱗右_鱗6.Dra;
			}
			set
			{
				this.X0Y0_縁上_鱗_鱗右_鱗6.Dra = value;
				this.X0Y0_縁上_鱗_鱗右_鱗6.Hit = value;
			}
		}

		public bool 縁上_鱗_鱗右_鱗5_表示
		{
			get
			{
				return this.X0Y0_縁上_鱗_鱗右_鱗5.Dra;
			}
			set
			{
				this.X0Y0_縁上_鱗_鱗右_鱗5.Dra = value;
				this.X0Y0_縁上_鱗_鱗右_鱗5.Hit = value;
			}
		}

		public bool 縁上_鱗_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_縁上_鱗_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_縁上_鱗_鱗右_鱗4.Dra = value;
				this.X0Y0_縁上_鱗_鱗右_鱗4.Hit = value;
			}
		}

		public bool 縁上_鱗_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_縁上_鱗_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_縁上_鱗_鱗右_鱗3.Dra = value;
				this.X0Y0_縁上_鱗_鱗右_鱗3.Hit = value;
			}
		}

		public bool 縁上_鱗_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_縁上_鱗_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_縁上_鱗_鱗右_鱗2.Dra = value;
				this.X0Y0_縁上_鱗_鱗右_鱗2.Hit = value;
			}
		}

		public bool 縁上_鱗_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_縁上_鱗_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_縁上_鱗_鱗右_鱗1.Dra = value;
				this.X0Y0_縁上_鱗_鱗右_鱗1.Hit = value;
			}
		}

		public bool 縁上_鱗_鱗1_表示
		{
			get
			{
				return this.X0Y0_縁上_鱗_鱗1.Dra;
			}
			set
			{
				this.X0Y0_縁上_鱗_鱗1.Dra = value;
				this.X0Y0_縁上_鱗_鱗1.Hit = value;
			}
		}

		public bool 縁上_鱗_鱗2_表示
		{
			get
			{
				return this.X0Y0_縁上_鱗_鱗2.Dra;
			}
			set
			{
				this.X0Y0_縁上_鱗_鱗2.Dra = value;
				this.X0Y0_縁上_鱗_鱗2.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.頭部_表示;
			}
			set
			{
				this.頭部_表示 = value;
				this.頭頂部_透_基_表示 = value;
				this.頭頂部_透_ハイライト1_表示 = value;
				this.頭頂部_透_ハイライト2_表示 = value;
				this.頭頂部_鱗_鱗5_表示 = value;
				this.頭頂部_鱗_鱗4_表示 = value;
				this.頭頂部_鱗_鱗3_表示 = value;
				this.頭頂部_鱗_鱗2_表示 = value;
				this.頭頂部_鱗_鱗1_表示 = value;
				this.左部_鰓_鰓11_表示 = value;
				this.左部_鰓_鰓10_表示 = value;
				this.左部_鰓_鰓9_表示 = value;
				this.左部_鰓_鰓8_表示 = value;
				this.左部_鰓_鰓7_表示 = value;
				this.左部_鰓_鰓6_表示 = value;
				this.左部_鰓_鰓5_表示 = value;
				this.左部_鰓_鰓4_表示 = value;
				this.左部_鰓_鰓3_表示 = value;
				this.左部_鰓_鰓2_表示 = value;
				this.左部_鰓_鰓1_表示 = value;
				this.左部_鱗_鱗7_表示 = value;
				this.左部_鱗_鱗6_表示 = value;
				this.左部_鱗_鱗5_表示 = value;
				this.左部_鱗_鱗4_表示 = value;
				this.左部_鱗_鱗3_表示 = value;
				this.左部_鱗_鱗2_表示 = value;
				this.左部_鱗_鱗1_表示 = value;
				this.右部_鰓_鰓11_表示 = value;
				this.右部_鰓_鰓10_表示 = value;
				this.右部_鰓_鰓9_表示 = value;
				this.右部_鰓_鰓8_表示 = value;
				this.右部_鰓_鰓7_表示 = value;
				this.右部_鰓_鰓6_表示 = value;
				this.右部_鰓_鰓5_表示 = value;
				this.右部_鰓_鰓4_表示 = value;
				this.右部_鰓_鰓3_表示 = value;
				this.右部_鰓_鰓2_表示 = value;
				this.右部_鰓_鰓1_表示 = value;
				this.右部_鱗_鱗7_表示 = value;
				this.右部_鱗_鱗6_表示 = value;
				this.右部_鱗_鱗5_表示 = value;
				this.右部_鱗_鱗4_表示 = value;
				this.右部_鱗_鱗3_表示 = value;
				this.右部_鱗_鱗2_表示 = value;
				this.右部_鱗_鱗1_表示 = value;
				this.鼻部_鱗3_表示 = value;
				this.鼻部_鱗左_表示 = value;
				this.鼻部_鱗右_表示 = value;
				this.鼻部_鱗2_表示 = value;
				this.鼻部_鱗1_表示 = value;
				this.縁下_縁下_表示 = value;
				this.縁下_鱗_鱗左_鱗7_表示 = value;
				this.縁下_鱗_鱗左_鱗6_表示 = value;
				this.縁下_鱗_鱗左_鱗5_表示 = value;
				this.縁下_鱗_鱗左_鱗4_表示 = value;
				this.縁下_鱗_鱗左_鱗3_表示 = value;
				this.縁下_鱗_鱗左_鱗2_表示 = value;
				this.縁下_鱗_鱗左_鱗1_表示 = value;
				this.縁下_鱗_鱗右_鱗7_表示 = value;
				this.縁下_鱗_鱗右_鱗6_表示 = value;
				this.縁下_鱗_鱗右_鱗5_表示 = value;
				this.縁下_鱗_鱗右_鱗4_表示 = value;
				this.縁下_鱗_鱗右_鱗3_表示 = value;
				this.縁下_鱗_鱗右_鱗2_表示 = value;
				this.縁下_鱗_鱗右_鱗1_表示 = value;
				this.縁下_鱗_鱗_表示 = value;
				this.縁上_縁上_表示 = value;
				this.縁上_鱗_鱗左_鱗6_表示 = value;
				this.縁上_鱗_鱗左_鱗5_表示 = value;
				this.縁上_鱗_鱗左_鱗4_表示 = value;
				this.縁上_鱗_鱗左_鱗3_表示 = value;
				this.縁上_鱗_鱗左_鱗2_表示 = value;
				this.縁上_鱗_鱗左_鱗1_表示 = value;
				this.縁上_鱗_鱗右_鱗6_表示 = value;
				this.縁上_鱗_鱗右_鱗5_表示 = value;
				this.縁上_鱗_鱗右_鱗4_表示 = value;
				this.縁上_鱗_鱗右_鱗3_表示 = value;
				this.縁上_鱗_鱗右_鱗2_表示 = value;
				this.縁上_鱗_鱗右_鱗1_表示 = value;
				this.縁上_鱗_鱗1_表示 = value;
				this.縁上_鱗_鱗2_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.頭部CD.不透明度;
			}
			set
			{
				this.頭部CD.不透明度 = value;
				this.頭頂部_透_基CD.不透明度 = value;
				this.頭頂部_透_ハイライト1CD.不透明度 = value;
				this.頭頂部_透_ハイライト2CD.不透明度 = value;
				this.頭頂部_鱗_鱗5CD.不透明度 = value;
				this.頭頂部_鱗_鱗4CD.不透明度 = value;
				this.頭頂部_鱗_鱗3CD.不透明度 = value;
				this.頭頂部_鱗_鱗2CD.不透明度 = value;
				this.頭頂部_鱗_鱗1CD.不透明度 = value;
				this.左部_鰓_鰓11CD.不透明度 = value;
				this.左部_鰓_鰓10CD.不透明度 = value;
				this.左部_鰓_鰓9CD.不透明度 = value;
				this.左部_鰓_鰓8CD.不透明度 = value;
				this.左部_鰓_鰓7CD.不透明度 = value;
				this.左部_鰓_鰓6CD.不透明度 = value;
				this.左部_鰓_鰓5CD.不透明度 = value;
				this.左部_鰓_鰓4CD.不透明度 = value;
				this.左部_鰓_鰓3CD.不透明度 = value;
				this.左部_鰓_鰓2CD.不透明度 = value;
				this.左部_鰓_鰓1CD.不透明度 = value;
				this.左部_鱗_鱗7CD.不透明度 = value;
				this.左部_鱗_鱗6CD.不透明度 = value;
				this.左部_鱗_鱗5CD.不透明度 = value;
				this.左部_鱗_鱗4CD.不透明度 = value;
				this.左部_鱗_鱗3CD.不透明度 = value;
				this.左部_鱗_鱗2CD.不透明度 = value;
				this.左部_鱗_鱗1CD.不透明度 = value;
				this.右部_鰓_鰓11CD.不透明度 = value;
				this.右部_鰓_鰓10CD.不透明度 = value;
				this.右部_鰓_鰓9CD.不透明度 = value;
				this.右部_鰓_鰓8CD.不透明度 = value;
				this.右部_鰓_鰓7CD.不透明度 = value;
				this.右部_鰓_鰓6CD.不透明度 = value;
				this.右部_鰓_鰓5CD.不透明度 = value;
				this.右部_鰓_鰓4CD.不透明度 = value;
				this.右部_鰓_鰓3CD.不透明度 = value;
				this.右部_鰓_鰓2CD.不透明度 = value;
				this.右部_鰓_鰓1CD.不透明度 = value;
				this.右部_鱗_鱗7CD.不透明度 = value;
				this.右部_鱗_鱗6CD.不透明度 = value;
				this.右部_鱗_鱗5CD.不透明度 = value;
				this.右部_鱗_鱗4CD.不透明度 = value;
				this.右部_鱗_鱗3CD.不透明度 = value;
				this.右部_鱗_鱗2CD.不透明度 = value;
				this.右部_鱗_鱗1CD.不透明度 = value;
				this.鼻部_鱗3CD.不透明度 = value;
				this.鼻部_鱗左CD.不透明度 = value;
				this.鼻部_鱗右CD.不透明度 = value;
				this.鼻部_鱗2CD.不透明度 = value;
				this.鼻部_鱗1CD.不透明度 = value;
				this.縁下_縁下CD.不透明度 = value;
				this.縁下_鱗_鱗左_鱗7CD.不透明度 = value;
				this.縁下_鱗_鱗左_鱗6CD.不透明度 = value;
				this.縁下_鱗_鱗左_鱗5CD.不透明度 = value;
				this.縁下_鱗_鱗左_鱗4CD.不透明度 = value;
				this.縁下_鱗_鱗左_鱗3CD.不透明度 = value;
				this.縁下_鱗_鱗左_鱗2CD.不透明度 = value;
				this.縁下_鱗_鱗左_鱗1CD.不透明度 = value;
				this.縁下_鱗_鱗右_鱗7CD.不透明度 = value;
				this.縁下_鱗_鱗右_鱗6CD.不透明度 = value;
				this.縁下_鱗_鱗右_鱗5CD.不透明度 = value;
				this.縁下_鱗_鱗右_鱗4CD.不透明度 = value;
				this.縁下_鱗_鱗右_鱗3CD.不透明度 = value;
				this.縁下_鱗_鱗右_鱗2CD.不透明度 = value;
				this.縁下_鱗_鱗右_鱗1CD.不透明度 = value;
				this.縁下_鱗_鱗CD.不透明度 = value;
				this.縁上_縁上CD.不透明度 = value;
				this.縁上_鱗_鱗左_鱗6CD.不透明度 = value;
				this.縁上_鱗_鱗左_鱗5CD.不透明度 = value;
				this.縁上_鱗_鱗左_鱗4CD.不透明度 = value;
				this.縁上_鱗_鱗左_鱗3CD.不透明度 = value;
				this.縁上_鱗_鱗左_鱗2CD.不透明度 = value;
				this.縁上_鱗_鱗左_鱗1CD.不透明度 = value;
				this.縁上_鱗_鱗右_鱗6CD.不透明度 = value;
				this.縁上_鱗_鱗右_鱗5CD.不透明度 = value;
				this.縁上_鱗_鱗右_鱗4CD.不透明度 = value;
				this.縁上_鱗_鱗右_鱗3CD.不透明度 = value;
				this.縁上_鱗_鱗右_鱗2CD.不透明度 = value;
				this.縁上_鱗_鱗右_鱗1CD.不透明度 = value;
				this.縁上_鱗_鱗1CD.不透明度 = value;
				this.縁上_鱗_鱗2CD.不透明度 = value;
			}
		}

		public bool 鱗
		{
			get
			{
				return this.鱗_;
			}
			set
			{
				this.鱗_ = value;
				this.頭頂部_透_基_表示 = !this.鱗_;
				this.頭頂部_透_ハイライト1_表示 = !this.鱗_;
				this.頭頂部_透_ハイライト2_表示 = !this.鱗_;
				this.頭頂部_鱗_鱗5_表示 = this.鱗_;
				this.頭頂部_鱗_鱗4_表示 = this.鱗_;
				this.頭頂部_鱗_鱗3_表示 = this.鱗_;
				this.頭頂部_鱗_鱗2_表示 = this.鱗_;
				this.頭頂部_鱗_鱗1_表示 = this.鱗_;
				this.左部_鰓_鰓11_表示 = !this.鱗_;
				this.左部_鰓_鰓10_表示 = !this.鱗_;
				this.左部_鰓_鰓9_表示 = !this.鱗_;
				this.左部_鰓_鰓8_表示 = !this.鱗_;
				this.左部_鰓_鰓7_表示 = !this.鱗_;
				this.左部_鰓_鰓6_表示 = !this.鱗_;
				this.左部_鰓_鰓5_表示 = !this.鱗_;
				this.左部_鰓_鰓4_表示 = !this.鱗_;
				this.左部_鰓_鰓3_表示 = !this.鱗_;
				this.左部_鰓_鰓2_表示 = !this.鱗_;
				this.左部_鰓_鰓1_表示 = !this.鱗_;
				this.左部_鱗_鱗7_表示 = this.鱗_;
				this.左部_鱗_鱗6_表示 = this.鱗_;
				this.左部_鱗_鱗5_表示 = this.鱗_;
				this.左部_鱗_鱗4_表示 = this.鱗_;
				this.左部_鱗_鱗3_表示 = this.鱗_;
				this.左部_鱗_鱗2_表示 = this.鱗_;
				this.左部_鱗_鱗1_表示 = this.鱗_;
				this.右部_鰓_鰓11_表示 = !this.鱗_;
				this.右部_鰓_鰓10_表示 = !this.鱗_;
				this.右部_鰓_鰓9_表示 = !this.鱗_;
				this.右部_鰓_鰓8_表示 = !this.鱗_;
				this.右部_鰓_鰓7_表示 = !this.鱗_;
				this.右部_鰓_鰓6_表示 = !this.鱗_;
				this.右部_鰓_鰓5_表示 = !this.鱗_;
				this.右部_鰓_鰓4_表示 = !this.鱗_;
				this.右部_鰓_鰓3_表示 = !this.鱗_;
				this.右部_鰓_鰓2_表示 = !this.鱗_;
				this.右部_鰓_鰓1_表示 = !this.鱗_;
				this.右部_鱗_鱗7_表示 = this.鱗_;
				this.右部_鱗_鱗6_表示 = this.鱗_;
				this.右部_鱗_鱗5_表示 = this.鱗_;
				this.右部_鱗_鱗4_表示 = this.鱗_;
				this.右部_鱗_鱗3_表示 = this.鱗_;
				this.右部_鱗_鱗2_表示 = this.鱗_;
				this.右部_鱗_鱗1_表示 = this.鱗_;
				this.縁下_鱗_鱗左_鱗7_表示 = this.鱗_;
				this.縁下_鱗_鱗左_鱗6_表示 = this.鱗_;
				this.縁下_鱗_鱗左_鱗5_表示 = this.鱗_;
				this.縁下_鱗_鱗左_鱗4_表示 = this.鱗_;
				this.縁下_鱗_鱗左_鱗3_表示 = this.鱗_;
				this.縁下_鱗_鱗左_鱗2_表示 = this.鱗_;
				this.縁下_鱗_鱗左_鱗1_表示 = this.鱗_;
				this.縁下_鱗_鱗右_鱗7_表示 = this.鱗_;
				this.縁下_鱗_鱗右_鱗6_表示 = this.鱗_;
				this.縁下_鱗_鱗右_鱗5_表示 = this.鱗_;
				this.縁下_鱗_鱗右_鱗4_表示 = this.鱗_;
				this.縁下_鱗_鱗右_鱗3_表示 = this.鱗_;
				this.縁下_鱗_鱗右_鱗2_表示 = this.鱗_;
				this.縁下_鱗_鱗右_鱗1_表示 = this.鱗_;
				this.縁下_鱗_鱗_表示 = this.鱗_;
				this.縁上_鱗_鱗左_鱗6_表示 = this.鱗_;
				this.縁上_鱗_鱗左_鱗5_表示 = this.鱗_;
				this.縁上_鱗_鱗左_鱗4_表示 = this.鱗_;
				this.縁上_鱗_鱗左_鱗3_表示 = this.鱗_;
				this.縁上_鱗_鱗左_鱗2_表示 = this.鱗_;
				this.縁上_鱗_鱗左_鱗1_表示 = this.鱗_;
				this.縁上_鱗_鱗右_鱗6_表示 = this.鱗_;
				this.縁上_鱗_鱗右_鱗5_表示 = this.鱗_;
				this.縁上_鱗_鱗右_鱗4_表示 = this.鱗_;
				this.縁上_鱗_鱗右_鱗3_表示 = this.鱗_;
				this.縁上_鱗_鱗右_鱗2_表示 = this.鱗_;
				this.縁上_鱗_鱗右_鱗1_表示 = this.鱗_;
				this.縁上_鱗_鱗1_表示 = this.鱗_;
				this.縁上_鱗_鱗2_表示 = this.鱗_;
			}
		}

		public JointS 頭部後_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_頭部, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_頭部CP.Update();
			this.X0Y0_頭頂部_透_基CP.Update();
			this.X0Y0_頭頂部_透_ハイライト1CP.Update();
			this.X0Y0_頭頂部_透_ハイライト2CP.Update();
			this.X0Y0_頭頂部_鱗_鱗5CP.Update();
			this.X0Y0_頭頂部_鱗_鱗4CP.Update();
			this.X0Y0_頭頂部_鱗_鱗3CP.Update();
			this.X0Y0_頭頂部_鱗_鱗2CP.Update();
			this.X0Y0_頭頂部_鱗_鱗1CP.Update();
			this.X0Y0_左部_鰓_鰓11CP.Update();
			this.X0Y0_左部_鰓_鰓10CP.Update();
			this.X0Y0_左部_鰓_鰓9CP.Update();
			this.X0Y0_左部_鰓_鰓8CP.Update();
			this.X0Y0_左部_鰓_鰓7CP.Update();
			this.X0Y0_左部_鰓_鰓6CP.Update();
			this.X0Y0_左部_鰓_鰓5CP.Update();
			this.X0Y0_左部_鰓_鰓4CP.Update();
			this.X0Y0_左部_鰓_鰓3CP.Update();
			this.X0Y0_左部_鰓_鰓2CP.Update();
			this.X0Y0_左部_鰓_鰓1CP.Update();
			this.X0Y0_左部_鱗_鱗7CP.Update();
			this.X0Y0_左部_鱗_鱗6CP.Update();
			this.X0Y0_左部_鱗_鱗5CP.Update();
			this.X0Y0_左部_鱗_鱗4CP.Update();
			this.X0Y0_左部_鱗_鱗3CP.Update();
			this.X0Y0_左部_鱗_鱗2CP.Update();
			this.X0Y0_左部_鱗_鱗1CP.Update();
			this.X0Y0_右部_鰓_鰓11CP.Update();
			this.X0Y0_右部_鰓_鰓10CP.Update();
			this.X0Y0_右部_鰓_鰓9CP.Update();
			this.X0Y0_右部_鰓_鰓8CP.Update();
			this.X0Y0_右部_鰓_鰓7CP.Update();
			this.X0Y0_右部_鰓_鰓6CP.Update();
			this.X0Y0_右部_鰓_鰓5CP.Update();
			this.X0Y0_右部_鰓_鰓4CP.Update();
			this.X0Y0_右部_鰓_鰓3CP.Update();
			this.X0Y0_右部_鰓_鰓2CP.Update();
			this.X0Y0_右部_鰓_鰓1CP.Update();
			this.X0Y0_右部_鱗_鱗7CP.Update();
			this.X0Y0_右部_鱗_鱗6CP.Update();
			this.X0Y0_右部_鱗_鱗5CP.Update();
			this.X0Y0_右部_鱗_鱗4CP.Update();
			this.X0Y0_右部_鱗_鱗3CP.Update();
			this.X0Y0_右部_鱗_鱗2CP.Update();
			this.X0Y0_右部_鱗_鱗1CP.Update();
			this.X0Y0_鼻部_鱗3CP.Update();
			this.X0Y0_鼻部_鱗左CP.Update();
			this.X0Y0_鼻部_鱗右CP.Update();
			this.X0Y0_鼻部_鱗2CP.Update();
			this.X0Y0_鼻部_鱗1CP.Update();
			this.X0Y0_縁下_縁下CP.Update();
			this.X0Y0_縁下_鱗_鱗左_鱗7CP.Update();
			this.X0Y0_縁下_鱗_鱗左_鱗6CP.Update();
			this.X0Y0_縁下_鱗_鱗左_鱗5CP.Update();
			this.X0Y0_縁下_鱗_鱗左_鱗4CP.Update();
			this.X0Y0_縁下_鱗_鱗左_鱗3CP.Update();
			this.X0Y0_縁下_鱗_鱗左_鱗2CP.Update();
			this.X0Y0_縁下_鱗_鱗左_鱗1CP.Update();
			this.X0Y0_縁下_鱗_鱗右_鱗7CP.Update();
			this.X0Y0_縁下_鱗_鱗右_鱗6CP.Update();
			this.X0Y0_縁下_鱗_鱗右_鱗5CP.Update();
			this.X0Y0_縁下_鱗_鱗右_鱗4CP.Update();
			this.X0Y0_縁下_鱗_鱗右_鱗3CP.Update();
			this.X0Y0_縁下_鱗_鱗右_鱗2CP.Update();
			this.X0Y0_縁下_鱗_鱗右_鱗1CP.Update();
			this.X0Y0_縁下_鱗_鱗CP.Update();
			this.X0Y0_縁上_縁上CP.Update();
			this.X0Y0_縁上_鱗_鱗左_鱗6CP.Update();
			this.X0Y0_縁上_鱗_鱗左_鱗5CP.Update();
			this.X0Y0_縁上_鱗_鱗左_鱗4CP.Update();
			this.X0Y0_縁上_鱗_鱗左_鱗3CP.Update();
			this.X0Y0_縁上_鱗_鱗左_鱗2CP.Update();
			this.X0Y0_縁上_鱗_鱗左_鱗1CP.Update();
			this.X0Y0_縁上_鱗_鱗右_鱗6CP.Update();
			this.X0Y0_縁上_鱗_鱗右_鱗5CP.Update();
			this.X0Y0_縁上_鱗_鱗右_鱗4CP.Update();
			this.X0Y0_縁上_鱗_鱗右_鱗3CP.Update();
			this.X0Y0_縁上_鱗_鱗右_鱗2CP.Update();
			this.X0Y0_縁上_鱗_鱗右_鱗1CP.Update();
			this.X0Y0_縁上_鱗_鱗1CP.Update();
			this.X0Y0_縁上_鱗_鱗2CP.Update();
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
			this.頭部CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭頂部_透_基CD = new ColorD(ref Col.Black, ref 体配色.コアO);
			this.頭頂部_透_ハイライト1CD = new ColorD(ref Col.Black, ref 体配色.ハイライト);
			this.頭頂部_透_ハイライト2CD = new ColorD(ref Col.Black, ref 体配色.ハイライト);
			this.頭頂部_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭頂部_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭頂部_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭頂部_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭頂部_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左部_鰓_鰓11CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓10CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓9CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓8CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓7CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓6CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左部_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左部_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左部_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左部_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左部_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左部_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右部_鰓_鰓11CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓10CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓9CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓8CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓7CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓6CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右部_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右部_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右部_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右部_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右部_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右部_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.鼻部_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.鼻部_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.鼻部_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.鼻部_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.鼻部_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.縁下_縁下CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.縁下_鱗_鱗左_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗左_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗左_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗右_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗右_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗右_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_縁上CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.縁上_鱗_鱗左_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗左_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗右_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗右_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.頭部CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭頂部_透_基CD = new ColorD(ref Col.Black, ref 体配色.コアO);
			this.頭頂部_透_ハイライト1CD = new ColorD(ref Col.Black, ref 体配色.ハイライト);
			this.頭頂部_透_ハイライト2CD = new ColorD(ref Col.Black, ref 体配色.ハイライト);
			this.頭頂部_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭頂部_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭頂部_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭頂部_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭頂部_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.左部_鰓_鰓11CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓10CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓9CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓8CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓7CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓6CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.左部_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左部_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.左部_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左部_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.左部_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左部_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.右部_鰓_鰓11CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓10CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓9CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓8CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓7CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓6CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.右部_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右部_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.右部_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右部_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.右部_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右部_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.鼻部_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.鼻部_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.鼻部_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.鼻部_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.鼻部_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.縁下_縁下CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁下_鱗_鱗左_鱗7CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁下_鱗_鱗左_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗左_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁下_鱗_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁下_鱗_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁下_鱗_鱗右_鱗7CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁下_鱗_鱗右_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗右_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁下_鱗_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁下_鱗_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁下_鱗_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_縁上CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁上_鱗_鱗左_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁上_鱗_鱗左_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁上_鱗_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁上_鱗_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗右_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁上_鱗_鱗右_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁上_鱗_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁上_鱗_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.頭部CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭頂部_透_基CD = new ColorD(ref Col.Black, ref 体配色.コアO);
			this.頭頂部_透_ハイライト1CD = new ColorD(ref Col.Black, ref 体配色.ハイライト);
			this.頭頂部_透_ハイライト2CD = new ColorD(ref Col.Black, ref 体配色.ハイライト);
			this.頭頂部_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭頂部_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭頂部_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭頂部_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭頂部_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左部_鰓_鰓11CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓10CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓9CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓8CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓7CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓6CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鰓_鰓1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.左部_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左部_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.左部_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左部_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.左部_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.左部_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.左部_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右部_鰓_鰓11CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓10CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓9CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓8CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓7CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓6CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鰓_鰓1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.右部_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右部_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.右部_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右部_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.右部_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.右部_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.右部_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.鼻部_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.鼻部_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.鼻部_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.鼻部_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.鼻部_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.縁下_縁下CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁下_鱗_鱗左_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗左_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁下_鱗_鱗左_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁下_鱗_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁下_鱗_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗右_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗右_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁下_鱗_鱗右_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁下_鱗_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁下_鱗_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁下_鱗_鱗CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁上_縁上CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁上_鱗_鱗左_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗左_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁上_鱗_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁上_鱗_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁上_鱗_鱗右_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗右_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁上_鱗_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁上_鱗_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.縁上_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.縁上_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
		}

		public Par X0Y0_頭部;

		public Par X0Y0_頭頂部_透_基;

		public Par X0Y0_頭頂部_透_ハイライト1;

		public Par X0Y0_頭頂部_透_ハイライト2;

		public Par X0Y0_頭頂部_鱗_鱗5;

		public Par X0Y0_頭頂部_鱗_鱗4;

		public Par X0Y0_頭頂部_鱗_鱗3;

		public Par X0Y0_頭頂部_鱗_鱗2;

		public Par X0Y0_頭頂部_鱗_鱗1;

		public Par X0Y0_左部_鰓_鰓11;

		public Par X0Y0_左部_鰓_鰓10;

		public Par X0Y0_左部_鰓_鰓9;

		public Par X0Y0_左部_鰓_鰓8;

		public Par X0Y0_左部_鰓_鰓7;

		public Par X0Y0_左部_鰓_鰓6;

		public Par X0Y0_左部_鰓_鰓5;

		public Par X0Y0_左部_鰓_鰓4;

		public Par X0Y0_左部_鰓_鰓3;

		public Par X0Y0_左部_鰓_鰓2;

		public Par X0Y0_左部_鰓_鰓1;

		public Par X0Y0_左部_鱗_鱗7;

		public Par X0Y0_左部_鱗_鱗6;

		public Par X0Y0_左部_鱗_鱗5;

		public Par X0Y0_左部_鱗_鱗4;

		public Par X0Y0_左部_鱗_鱗3;

		public Par X0Y0_左部_鱗_鱗2;

		public Par X0Y0_左部_鱗_鱗1;

		public Par X0Y0_右部_鰓_鰓11;

		public Par X0Y0_右部_鰓_鰓10;

		public Par X0Y0_右部_鰓_鰓9;

		public Par X0Y0_右部_鰓_鰓8;

		public Par X0Y0_右部_鰓_鰓7;

		public Par X0Y0_右部_鰓_鰓6;

		public Par X0Y0_右部_鰓_鰓5;

		public Par X0Y0_右部_鰓_鰓4;

		public Par X0Y0_右部_鰓_鰓3;

		public Par X0Y0_右部_鰓_鰓2;

		public Par X0Y0_右部_鰓_鰓1;

		public Par X0Y0_右部_鱗_鱗7;

		public Par X0Y0_右部_鱗_鱗6;

		public Par X0Y0_右部_鱗_鱗5;

		public Par X0Y0_右部_鱗_鱗4;

		public Par X0Y0_右部_鱗_鱗3;

		public Par X0Y0_右部_鱗_鱗2;

		public Par X0Y0_右部_鱗_鱗1;

		public Par X0Y0_鼻部_鱗3;

		public Par X0Y0_鼻部_鱗左;

		public Par X0Y0_鼻部_鱗右;

		public Par X0Y0_鼻部_鱗2;

		public Par X0Y0_鼻部_鱗1;

		public Par X0Y0_縁下_縁下;

		public Par X0Y0_縁下_鱗_鱗左_鱗7;

		public Par X0Y0_縁下_鱗_鱗左_鱗6;

		public Par X0Y0_縁下_鱗_鱗左_鱗5;

		public Par X0Y0_縁下_鱗_鱗左_鱗4;

		public Par X0Y0_縁下_鱗_鱗左_鱗3;

		public Par X0Y0_縁下_鱗_鱗左_鱗2;

		public Par X0Y0_縁下_鱗_鱗左_鱗1;

		public Par X0Y0_縁下_鱗_鱗右_鱗7;

		public Par X0Y0_縁下_鱗_鱗右_鱗6;

		public Par X0Y0_縁下_鱗_鱗右_鱗5;

		public Par X0Y0_縁下_鱗_鱗右_鱗4;

		public Par X0Y0_縁下_鱗_鱗右_鱗3;

		public Par X0Y0_縁下_鱗_鱗右_鱗2;

		public Par X0Y0_縁下_鱗_鱗右_鱗1;

		public Par X0Y0_縁下_鱗_鱗;

		public Par X0Y0_縁上_縁上;

		public Par X0Y0_縁上_鱗_鱗左_鱗6;

		public Par X0Y0_縁上_鱗_鱗左_鱗5;

		public Par X0Y0_縁上_鱗_鱗左_鱗4;

		public Par X0Y0_縁上_鱗_鱗左_鱗3;

		public Par X0Y0_縁上_鱗_鱗左_鱗2;

		public Par X0Y0_縁上_鱗_鱗左_鱗1;

		public Par X0Y0_縁上_鱗_鱗右_鱗6;

		public Par X0Y0_縁上_鱗_鱗右_鱗5;

		public Par X0Y0_縁上_鱗_鱗右_鱗4;

		public Par X0Y0_縁上_鱗_鱗右_鱗3;

		public Par X0Y0_縁上_鱗_鱗右_鱗2;

		public Par X0Y0_縁上_鱗_鱗右_鱗1;

		public Par X0Y0_縁上_鱗_鱗1;

		public Par X0Y0_縁上_鱗_鱗2;

		public ColorD 頭部CD;

		public ColorD 頭頂部_透_基CD;

		public ColorD 頭頂部_透_ハイライト1CD;

		public ColorD 頭頂部_透_ハイライト2CD;

		public ColorD 頭頂部_鱗_鱗5CD;

		public ColorD 頭頂部_鱗_鱗4CD;

		public ColorD 頭頂部_鱗_鱗3CD;

		public ColorD 頭頂部_鱗_鱗2CD;

		public ColorD 頭頂部_鱗_鱗1CD;

		public ColorD 左部_鰓_鰓11CD;

		public ColorD 左部_鰓_鰓10CD;

		public ColorD 左部_鰓_鰓9CD;

		public ColorD 左部_鰓_鰓8CD;

		public ColorD 左部_鰓_鰓7CD;

		public ColorD 左部_鰓_鰓6CD;

		public ColorD 左部_鰓_鰓5CD;

		public ColorD 左部_鰓_鰓4CD;

		public ColorD 左部_鰓_鰓3CD;

		public ColorD 左部_鰓_鰓2CD;

		public ColorD 左部_鰓_鰓1CD;

		public ColorD 左部_鱗_鱗7CD;

		public ColorD 左部_鱗_鱗6CD;

		public ColorD 左部_鱗_鱗5CD;

		public ColorD 左部_鱗_鱗4CD;

		public ColorD 左部_鱗_鱗3CD;

		public ColorD 左部_鱗_鱗2CD;

		public ColorD 左部_鱗_鱗1CD;

		public ColorD 右部_鰓_鰓11CD;

		public ColorD 右部_鰓_鰓10CD;

		public ColorD 右部_鰓_鰓9CD;

		public ColorD 右部_鰓_鰓8CD;

		public ColorD 右部_鰓_鰓7CD;

		public ColorD 右部_鰓_鰓6CD;

		public ColorD 右部_鰓_鰓5CD;

		public ColorD 右部_鰓_鰓4CD;

		public ColorD 右部_鰓_鰓3CD;

		public ColorD 右部_鰓_鰓2CD;

		public ColorD 右部_鰓_鰓1CD;

		public ColorD 右部_鱗_鱗7CD;

		public ColorD 右部_鱗_鱗6CD;

		public ColorD 右部_鱗_鱗5CD;

		public ColorD 右部_鱗_鱗4CD;

		public ColorD 右部_鱗_鱗3CD;

		public ColorD 右部_鱗_鱗2CD;

		public ColorD 右部_鱗_鱗1CD;

		public ColorD 鼻部_鱗3CD;

		public ColorD 鼻部_鱗左CD;

		public ColorD 鼻部_鱗右CD;

		public ColorD 鼻部_鱗2CD;

		public ColorD 鼻部_鱗1CD;

		public ColorD 縁下_縁下CD;

		public ColorD 縁下_鱗_鱗左_鱗7CD;

		public ColorD 縁下_鱗_鱗左_鱗6CD;

		public ColorD 縁下_鱗_鱗左_鱗5CD;

		public ColorD 縁下_鱗_鱗左_鱗4CD;

		public ColorD 縁下_鱗_鱗左_鱗3CD;

		public ColorD 縁下_鱗_鱗左_鱗2CD;

		public ColorD 縁下_鱗_鱗左_鱗1CD;

		public ColorD 縁下_鱗_鱗右_鱗7CD;

		public ColorD 縁下_鱗_鱗右_鱗6CD;

		public ColorD 縁下_鱗_鱗右_鱗5CD;

		public ColorD 縁下_鱗_鱗右_鱗4CD;

		public ColorD 縁下_鱗_鱗右_鱗3CD;

		public ColorD 縁下_鱗_鱗右_鱗2CD;

		public ColorD 縁下_鱗_鱗右_鱗1CD;

		public ColorD 縁下_鱗_鱗CD;

		public ColorD 縁上_縁上CD;

		public ColorD 縁上_鱗_鱗左_鱗6CD;

		public ColorD 縁上_鱗_鱗左_鱗5CD;

		public ColorD 縁上_鱗_鱗左_鱗4CD;

		public ColorD 縁上_鱗_鱗左_鱗3CD;

		public ColorD 縁上_鱗_鱗左_鱗2CD;

		public ColorD 縁上_鱗_鱗左_鱗1CD;

		public ColorD 縁上_鱗_鱗右_鱗6CD;

		public ColorD 縁上_鱗_鱗右_鱗5CD;

		public ColorD 縁上_鱗_鱗右_鱗4CD;

		public ColorD 縁上_鱗_鱗右_鱗3CD;

		public ColorD 縁上_鱗_鱗右_鱗2CD;

		public ColorD 縁上_鱗_鱗右_鱗1CD;

		public ColorD 縁上_鱗_鱗1CD;

		public ColorD 縁上_鱗_鱗2CD;

		public ColorP X0Y0_頭部CP;

		public ColorP X0Y0_頭頂部_透_基CP;

		public ColorP X0Y0_頭頂部_透_ハイライト1CP;

		public ColorP X0Y0_頭頂部_透_ハイライト2CP;

		public ColorP X0Y0_頭頂部_鱗_鱗5CP;

		public ColorP X0Y0_頭頂部_鱗_鱗4CP;

		public ColorP X0Y0_頭頂部_鱗_鱗3CP;

		public ColorP X0Y0_頭頂部_鱗_鱗2CP;

		public ColorP X0Y0_頭頂部_鱗_鱗1CP;

		public ColorP X0Y0_左部_鰓_鰓11CP;

		public ColorP X0Y0_左部_鰓_鰓10CP;

		public ColorP X0Y0_左部_鰓_鰓9CP;

		public ColorP X0Y0_左部_鰓_鰓8CP;

		public ColorP X0Y0_左部_鰓_鰓7CP;

		public ColorP X0Y0_左部_鰓_鰓6CP;

		public ColorP X0Y0_左部_鰓_鰓5CP;

		public ColorP X0Y0_左部_鰓_鰓4CP;

		public ColorP X0Y0_左部_鰓_鰓3CP;

		public ColorP X0Y0_左部_鰓_鰓2CP;

		public ColorP X0Y0_左部_鰓_鰓1CP;

		public ColorP X0Y0_左部_鱗_鱗7CP;

		public ColorP X0Y0_左部_鱗_鱗6CP;

		public ColorP X0Y0_左部_鱗_鱗5CP;

		public ColorP X0Y0_左部_鱗_鱗4CP;

		public ColorP X0Y0_左部_鱗_鱗3CP;

		public ColorP X0Y0_左部_鱗_鱗2CP;

		public ColorP X0Y0_左部_鱗_鱗1CP;

		public ColorP X0Y0_右部_鰓_鰓11CP;

		public ColorP X0Y0_右部_鰓_鰓10CP;

		public ColorP X0Y0_右部_鰓_鰓9CP;

		public ColorP X0Y0_右部_鰓_鰓8CP;

		public ColorP X0Y0_右部_鰓_鰓7CP;

		public ColorP X0Y0_右部_鰓_鰓6CP;

		public ColorP X0Y0_右部_鰓_鰓5CP;

		public ColorP X0Y0_右部_鰓_鰓4CP;

		public ColorP X0Y0_右部_鰓_鰓3CP;

		public ColorP X0Y0_右部_鰓_鰓2CP;

		public ColorP X0Y0_右部_鰓_鰓1CP;

		public ColorP X0Y0_右部_鱗_鱗7CP;

		public ColorP X0Y0_右部_鱗_鱗6CP;

		public ColorP X0Y0_右部_鱗_鱗5CP;

		public ColorP X0Y0_右部_鱗_鱗4CP;

		public ColorP X0Y0_右部_鱗_鱗3CP;

		public ColorP X0Y0_右部_鱗_鱗2CP;

		public ColorP X0Y0_右部_鱗_鱗1CP;

		public ColorP X0Y0_鼻部_鱗3CP;

		public ColorP X0Y0_鼻部_鱗左CP;

		public ColorP X0Y0_鼻部_鱗右CP;

		public ColorP X0Y0_鼻部_鱗2CP;

		public ColorP X0Y0_鼻部_鱗1CP;

		public ColorP X0Y0_縁下_縁下CP;

		public ColorP X0Y0_縁下_鱗_鱗左_鱗7CP;

		public ColorP X0Y0_縁下_鱗_鱗左_鱗6CP;

		public ColorP X0Y0_縁下_鱗_鱗左_鱗5CP;

		public ColorP X0Y0_縁下_鱗_鱗左_鱗4CP;

		public ColorP X0Y0_縁下_鱗_鱗左_鱗3CP;

		public ColorP X0Y0_縁下_鱗_鱗左_鱗2CP;

		public ColorP X0Y0_縁下_鱗_鱗左_鱗1CP;

		public ColorP X0Y0_縁下_鱗_鱗右_鱗7CP;

		public ColorP X0Y0_縁下_鱗_鱗右_鱗6CP;

		public ColorP X0Y0_縁下_鱗_鱗右_鱗5CP;

		public ColorP X0Y0_縁下_鱗_鱗右_鱗4CP;

		public ColorP X0Y0_縁下_鱗_鱗右_鱗3CP;

		public ColorP X0Y0_縁下_鱗_鱗右_鱗2CP;

		public ColorP X0Y0_縁下_鱗_鱗右_鱗1CP;

		public ColorP X0Y0_縁下_鱗_鱗CP;

		public ColorP X0Y0_縁上_縁上CP;

		public ColorP X0Y0_縁上_鱗_鱗左_鱗6CP;

		public ColorP X0Y0_縁上_鱗_鱗左_鱗5CP;

		public ColorP X0Y0_縁上_鱗_鱗左_鱗4CP;

		public ColorP X0Y0_縁上_鱗_鱗左_鱗3CP;

		public ColorP X0Y0_縁上_鱗_鱗左_鱗2CP;

		public ColorP X0Y0_縁上_鱗_鱗左_鱗1CP;

		public ColorP X0Y0_縁上_鱗_鱗右_鱗6CP;

		public ColorP X0Y0_縁上_鱗_鱗右_鱗5CP;

		public ColorP X0Y0_縁上_鱗_鱗右_鱗4CP;

		public ColorP X0Y0_縁上_鱗_鱗右_鱗3CP;

		public ColorP X0Y0_縁上_鱗_鱗右_鱗2CP;

		public ColorP X0Y0_縁上_鱗_鱗右_鱗1CP;

		public ColorP X0Y0_縁上_鱗_鱗1CP;

		public ColorP X0Y0_縁上_鱗_鱗2CP;

		private bool 鱗_;

		public Ele[] 頭部後_接続;
	}
}
