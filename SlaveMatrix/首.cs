using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 首 : Ele
	{
		public 首(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 首D e)
		{
			首.<>c__DisplayClass149_0 CS$<>8__locals1 = new 首.<>c__DisplayClass149_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.胴体["首"]);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["植性"].ToPars();
			this.X0Y0_植性_蔦 = pars2["蔦"].ToPar();
			this.X0Y0_植性_棘左上 = pars2["刺左上"].ToPar();
			this.X0Y0_植性_棘左下 = pars2["刺左下"].ToPar();
			this.X0Y0_植性_棘右上 = pars2["刺右上"].ToPar();
			this.X0Y0_植性_棘右下 = pars2["刺右下"].ToPar();
			this.X0Y0_首 = pars["首"].ToPar();
			pars2 = pars["淫タトゥ"].ToPars();
			Pars pars3 = pars2["ハート"].ToPars();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左 = pars3["タトゥ左"].ToPar();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右 = pars3["タトゥ右"].ToPar();
			this.X0Y0_淫タトゥ_タトゥ左 = pars2["タトゥ左"].ToPar();
			this.X0Y0_淫タトゥ_タトゥ右 = pars2["タトゥ右"].ToPar();
			pars2 = pars["悪タトゥ"].ToPars();
			pars3 = pars2["文字"].ToPars();
			Pars pars4 = pars3["文字a"].ToPars();
			this.X0Y0_悪タトゥ_文字_文字a_枠 = pars4["枠"].ToPar();
			this.X0Y0_悪タトゥ_文字_文字a_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_文字_文字a_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字b"].ToPars();
			this.X0Y0_悪タトゥ_文字_文字b_枠 = pars4["枠"].ToPar();
			this.X0Y0_悪タトゥ_文字_文字b_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_文字_文字b_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字c"].ToPars();
			this.X0Y0_悪タトゥ_文字_文字c_枠 = pars4["枠"].ToPar();
			this.X0Y0_悪タトゥ_文字_文字c_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_文字_文字c_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字d"].ToPars();
			this.X0Y0_悪タトゥ_文字_文字d_枠 = pars4["枠"].ToPar();
			this.X0Y0_悪タトゥ_文字_文字d_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_文字_文字d_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字e"].ToPars();
			this.X0Y0_悪タトゥ_文字_文字e_枠 = pars4["枠"].ToPar();
			this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ3 = pars4["文字タトゥ3"].ToPar();
			this.X0Y0_悪タトゥ_タトゥ = pars2["タトゥ"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y0_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y0_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y0_竜性_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y0_竜性_鱗4 = pars2["鱗4"].ToPar();
			this.X0Y0_竜性_鱗5 = pars2["鱗5"].ToPar();
			this.X0Y0_竜性_鱗6 = pars2["鱗6"].ToPar();
			pars2 = pars["虫性"].ToPars();
			this.X0Y0_虫性_蛇腹4 = pars2["蛇腹4"].ToPar();
			this.X0Y0_虫性_蛇腹3 = pars2["蛇腹3"].ToPar();
			this.X0Y0_虫性_蛇腹2 = pars2["蛇腹2"].ToPar();
			this.X0Y0_虫性_蛇腹1 = pars2["蛇腹1"].ToPar();
			pars2 = pars["ヴィオラ"].ToPars();
			pars3 = pars2["左"].ToPars();
			this.X0Y0_ヴィオラ_左_襟 = pars3["襟"].ToPar();
			this.X0Y0_ヴィオラ_左_縁1 = pars3["縁1"].ToPar();
			this.X0Y0_ヴィオラ_左_縁2 = pars3["縁2"].ToPar();
			pars3 = pars2["右"].ToPars();
			this.X0Y0_ヴィオラ_右_襟 = pars3["襟"].ToPar();
			this.X0Y0_ヴィオラ_右_縁1 = pars3["縁1"].ToPar();
			this.X0Y0_ヴィオラ_右_縁2 = pars3["縁2"].ToPar();
			pars2 = pars["首輪"].ToPars();
			this.X0Y0_首輪_革 = pars2["革"].ToPar();
			this.X0Y0_首輪_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_首輪_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_首輪_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_首輪_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_首輪_金具右 = pars2["金具右"].ToPar();
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
			this.植性_蔦_表示 = e.植性_蔦_表示;
			this.植性_棘左上_表示 = e.植性_棘左上_表示;
			this.植性_棘左下_表示 = e.植性_棘左下_表示;
			this.植性_棘右上_表示 = e.植性_棘右上_表示;
			this.植性_棘右下_表示 = e.植性_棘右下_表示;
			this.首_表示 = e.首_表示;
			this.淫タトゥ_ハ\u30FCト_タトゥ左_表示 = e.淫タトゥ_ハ\u30FCト_タトゥ左_表示;
			this.淫タトゥ_ハ\u30FCト_タトゥ右_表示 = e.淫タトゥ_ハ\u30FCト_タトゥ右_表示;
			this.淫タトゥ_タトゥ左_表示 = e.淫タトゥ_タトゥ左_表示;
			this.淫タトゥ_タトゥ右_表示 = e.淫タトゥ_タトゥ右_表示;
			this.悪タトゥ_文字_文字a_枠_表示 = e.悪タトゥ_文字_文字a_枠_表示;
			this.悪タトゥ_文字_文字a_文字タトゥ1_表示 = e.悪タトゥ_文字_文字a_文字タトゥ1_表示;
			this.悪タトゥ_文字_文字a_文字タトゥ2_表示 = e.悪タトゥ_文字_文字a_文字タトゥ2_表示;
			this.悪タトゥ_文字_文字b_枠_表示 = e.悪タトゥ_文字_文字b_枠_表示;
			this.悪タトゥ_文字_文字b_文字タトゥ1_表示 = e.悪タトゥ_文字_文字b_文字タトゥ1_表示;
			this.悪タトゥ_文字_文字b_文字タトゥ2_表示 = e.悪タトゥ_文字_文字b_文字タトゥ2_表示;
			this.悪タトゥ_文字_文字c_枠_表示 = e.悪タトゥ_文字_文字c_枠_表示;
			this.悪タトゥ_文字_文字c_文字タトゥ1_表示 = e.悪タトゥ_文字_文字c_文字タトゥ1_表示;
			this.悪タトゥ_文字_文字c_文字タトゥ2_表示 = e.悪タトゥ_文字_文字c_文字タトゥ2_表示;
			this.悪タトゥ_文字_文字d_枠_表示 = e.悪タトゥ_文字_文字d_枠_表示;
			this.悪タトゥ_文字_文字d_文字タトゥ1_表示 = e.悪タトゥ_文字_文字d_文字タトゥ1_表示;
			this.悪タトゥ_文字_文字d_文字タトゥ2_表示 = e.悪タトゥ_文字_文字d_文字タトゥ2_表示;
			this.悪タトゥ_文字_文字e_枠_表示 = e.悪タトゥ_文字_文字e_枠_表示;
			this.悪タトゥ_文字_文字e_文字タトゥ1_表示 = e.悪タトゥ_文字_文字e_文字タトゥ1_表示;
			this.悪タトゥ_文字_文字e_文字タトゥ2_表示 = e.悪タトゥ_文字_文字e_文字タトゥ2_表示;
			this.悪タトゥ_文字_文字e_文字タトゥ3_表示 = e.悪タトゥ_文字_文字e_文字タトゥ3_表示;
			this.悪タトゥ_タトゥ_表示 = e.悪タトゥ_タトゥ_表示;
			this.竜性_鱗1_表示 = e.竜性_鱗1_表示;
			this.竜性_鱗2_表示 = e.竜性_鱗2_表示;
			this.竜性_鱗3_表示 = e.竜性_鱗3_表示;
			this.竜性_鱗4_表示 = e.竜性_鱗4_表示;
			this.竜性_鱗5_表示 = e.竜性_鱗5_表示;
			this.竜性_鱗6_表示 = e.竜性_鱗6_表示;
			this.虫性_蛇腹4_表示 = e.虫性_蛇腹4_表示;
			this.虫性_蛇腹3_表示 = e.虫性_蛇腹3_表示;
			this.虫性_蛇腹2_表示 = e.虫性_蛇腹2_表示;
			this.虫性_蛇腹1_表示 = e.虫性_蛇腹1_表示;
			this.ヴィオラ_左_襟_表示 = e.ヴィオラ_左_襟_表示;
			this.ヴィオラ_左_縁1_表示 = e.ヴィオラ_左_縁1_表示;
			this.ヴィオラ_左_縁2_表示 = e.ヴィオラ_左_縁2_表示;
			this.ヴィオラ_右_襟_表示 = e.ヴィオラ_右_襟_表示;
			this.ヴィオラ_右_縁1_表示 = e.ヴィオラ_右_縁1_表示;
			this.ヴィオラ_右_縁2_表示 = e.ヴィオラ_右_縁2_表示;
			this.首輪_革_表示 = e.首輪_革_表示;
			this.首輪_金具1_表示 = e.首輪_金具1_表示;
			this.首輪_金具2_表示 = e.首輪_金具2_表示;
			this.首輪_金具3_表示 = e.首輪_金具3_表示;
			this.首輪_金具左_表示 = e.首輪_金具左_表示;
			this.首輪_金具右_表示 = e.首輪_金具右_表示;
			this.首輪表示 = e.首輪表示;
			this.ヴィオラ襟ベ\u30FCス表示 = e.ヴィオラ襟ベ\u30FCス表示;
			this.ヴィオラ縁表示 = e.ヴィオラ縁表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.頭_接続.Count > 0)
			{
				Ele f;
				this.頭_接続 = e.頭_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.首_頭_接続;
					f.接続(CS$<>8__locals1.<>4__this.頭_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_植性_蔦CP = new ColorP(this.X0Y0_植性_蔦, this.植性_蔦CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性_棘左上CP = new ColorP(this.X0Y0_植性_棘左上, this.植性_棘左上CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性_棘左下CP = new ColorP(this.X0Y0_植性_棘左下, this.植性_棘左下CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性_棘右上CP = new ColorP(this.X0Y0_植性_棘右上, this.植性_棘右上CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性_棘右下CP = new ColorP(this.X0Y0_植性_棘右下, this.植性_棘右下CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_首CP = new ColorP(this.X0Y0_首, this.首CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左CP = new ColorP(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左, this.淫タトゥ_ハ\u30FCト_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右CP = new ColorP(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右, this.淫タトゥ_ハ\u30FCト_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ左CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ左, this.淫タトゥ_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ右CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ右, this.淫タトゥ_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字_文字a_枠CP = new ColorP(this.X0Y0_悪タトゥ_文字_文字a_枠, this.悪タトゥ_文字_文字a_枠CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_悪タトゥ_文字_文字a_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_文字_文字a_文字タトゥ1, this.悪タトゥ_文字_文字a_文字タトゥ1CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_悪タトゥ_文字_文字a_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_文字_文字a_文字タトゥ2, this.悪タトゥ_文字_文字a_文字タトゥ2CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_悪タトゥ_文字_文字b_枠CP = new ColorP(this.X0Y0_悪タトゥ_文字_文字b_枠, this.悪タトゥ_文字_文字b_枠CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_悪タトゥ_文字_文字b_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_文字_文字b_文字タトゥ1, this.悪タトゥ_文字_文字b_文字タトゥ1CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_悪タトゥ_文字_文字b_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_文字_文字b_文字タトゥ2, this.悪タトゥ_文字_文字b_文字タトゥ2CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_悪タトゥ_文字_文字c_枠CP = new ColorP(this.X0Y0_悪タトゥ_文字_文字c_枠, this.悪タトゥ_文字_文字c_枠CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_悪タトゥ_文字_文字c_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_文字_文字c_文字タトゥ1, this.悪タトゥ_文字_文字c_文字タトゥ1CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_悪タトゥ_文字_文字c_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_文字_文字c_文字タトゥ2, this.悪タトゥ_文字_文字c_文字タトゥ2CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_悪タトゥ_文字_文字d_枠CP = new ColorP(this.X0Y0_悪タトゥ_文字_文字d_枠, this.悪タトゥ_文字_文字d_枠CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_悪タトゥ_文字_文字d_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_文字_文字d_文字タトゥ1, this.悪タトゥ_文字_文字d_文字タトゥ1CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_悪タトゥ_文字_文字d_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_文字_文字d_文字タトゥ2, this.悪タトゥ_文字_文字d_文字タトゥ2CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_悪タトゥ_文字_文字e_枠CP = new ColorP(this.X0Y0_悪タトゥ_文字_文字e_枠, this.悪タトゥ_文字_文字e_枠CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ1, this.悪タトゥ_文字_文字e_文字タトゥ1CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ2, this.悪タトゥ_文字_文字e_文字タトゥ2CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ3CP = new ColorP(this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ3, this.悪タトゥ_文字_文字e_文字タトゥ3CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_悪タトゥ_タトゥCP = new ColorP(this.X0Y0_悪タトゥ_タトゥ, this.悪タトゥ_タトゥCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗1CP = new ColorP(this.X0Y0_竜性_鱗1, this.竜性_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗2CP = new ColorP(this.X0Y0_竜性_鱗2, this.竜性_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗3CP = new ColorP(this.X0Y0_竜性_鱗3, this.竜性_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗4CP = new ColorP(this.X0Y0_竜性_鱗4, this.竜性_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗5CP = new ColorP(this.X0Y0_竜性_鱗5, this.竜性_鱗5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗6CP = new ColorP(this.X0Y0_竜性_鱗6, this.竜性_鱗6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_蛇腹4CP = new ColorP(this.X0Y0_虫性_蛇腹4, this.虫性_蛇腹4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_蛇腹3CP = new ColorP(this.X0Y0_虫性_蛇腹3, this.虫性_蛇腹3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_蛇腹2CP = new ColorP(this.X0Y0_虫性_蛇腹2, this.虫性_蛇腹2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_蛇腹1CP = new ColorP(this.X0Y0_虫性_蛇腹1, this.虫性_蛇腹1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ヴィオラ_左_襟CP = new ColorP(this.X0Y0_ヴィオラ_左_襟, this.ヴィオラ_左_襟CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ヴィオラ_左_縁1CP = new ColorP(this.X0Y0_ヴィオラ_左_縁1, this.ヴィオラ_左_縁1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ヴィオラ_左_縁2CP = new ColorP(this.X0Y0_ヴィオラ_左_縁2, this.ヴィオラ_左_縁2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ヴィオラ_右_襟CP = new ColorP(this.X0Y0_ヴィオラ_右_襟, this.ヴィオラ_右_襟CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ヴィオラ_右_縁1CP = new ColorP(this.X0Y0_ヴィオラ_右_縁1, this.ヴィオラ_右_縁1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ヴィオラ_右_縁2CP = new ColorP(this.X0Y0_ヴィオラ_右_縁2, this.ヴィオラ_右_縁2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_首輪_革CP = new ColorP(this.X0Y0_首輪_革, this.首輪_革CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_首輪_金具1CP = new ColorP(this.X0Y0_首輪_金具1, this.首輪_金具1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_首輪_金具2CP = new ColorP(this.X0Y0_首輪_金具2, this.首輪_金具2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_首輪_金具3CP = new ColorP(this.X0Y0_首輪_金具3, this.首輪_金具3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_首輪_金具左CP = new ColorP(this.X0Y0_首輪_金具左, this.首輪_金具左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_首輪_金具右CP = new ColorP(this.X0Y0_首輪_金具右, this.首輪_金具右CD, CS$<>8__locals1.DisUnit, true);
			this.濃度 = e.濃度;
			this.鎖1 = new 拘束鎖(CS$<>8__locals1.DisUnit, this.右, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖2 = new 拘束鎖(CS$<>8__locals1.DisUnit, !this.右, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖1.接続(this.鎖1_接続点);
			this.鎖2.接続(this.鎖2_接続点);
			int num = this.右 ? -10 : 10;
			this.鎖1.角度B += (double)num;
			this.鎖2.角度B -= (double)num;
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
				this.首輪表示 = this.拘束_;
			}
		}

		public bool 植性_蔦_表示
		{
			get
			{
				return this.X0Y0_植性_蔦.Dra;
			}
			set
			{
				this.X0Y0_植性_蔦.Dra = value;
				this.X0Y0_植性_蔦.Hit = value;
			}
		}

		public bool 植性_棘左上_表示
		{
			get
			{
				return this.X0Y0_植性_棘左上.Dra;
			}
			set
			{
				this.X0Y0_植性_棘左上.Dra = value;
				this.X0Y0_植性_棘左上.Hit = value;
			}
		}

		public bool 植性_棘左下_表示
		{
			get
			{
				return this.X0Y0_植性_棘左下.Dra;
			}
			set
			{
				this.X0Y0_植性_棘左下.Dra = value;
				this.X0Y0_植性_棘左下.Hit = value;
			}
		}

		public bool 植性_棘右上_表示
		{
			get
			{
				return this.X0Y0_植性_棘右上.Dra;
			}
			set
			{
				this.X0Y0_植性_棘右上.Dra = value;
				this.X0Y0_植性_棘右上.Hit = value;
			}
		}

		public bool 植性_棘右下_表示
		{
			get
			{
				return this.X0Y0_植性_棘右下.Dra;
			}
			set
			{
				this.X0Y0_植性_棘右下.Dra = value;
				this.X0Y0_植性_棘右下.Hit = value;
			}
		}

		public bool 首_表示
		{
			get
			{
				return this.X0Y0_首.Dra;
			}
			set
			{
				this.X0Y0_首.Dra = value;
				this.X0Y0_首.Hit = value;
			}
		}

		public bool 淫タトゥ_ハ\u30FCト_タトゥ左_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左.Dra = value;
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左.Hit = value;
			}
		}

		public bool 淫タトゥ_ハ\u30FCト_タトゥ右_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右.Dra = value;
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右.Hit = value;
			}
		}

		public bool 淫タトゥ_タトゥ左_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_タトゥ左.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_タトゥ左.Dra = value;
				this.X0Y0_淫タトゥ_タトゥ左.Hit = value;
			}
		}

		public bool 淫タトゥ_タトゥ右_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_タトゥ右.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_タトゥ右.Dra = value;
				this.X0Y0_淫タトゥ_タトゥ右.Hit = value;
			}
		}

		public bool 悪タトゥ_文字_文字a_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字_文字a_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字_文字a_枠.Dra = value;
				this.X0Y0_悪タトゥ_文字_文字a_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_文字_文字a_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字_文字a_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字_文字a_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_文字_文字a_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_文字_文字a_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字_文字a_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字_文字a_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_文字_文字a_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_文字_文字b_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字_文字b_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字_文字b_枠.Dra = value;
				this.X0Y0_悪タトゥ_文字_文字b_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_文字_文字b_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字_文字b_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字_文字b_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_文字_文字b_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_文字_文字b_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字_文字b_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字_文字b_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_文字_文字b_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_文字_文字c_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字_文字c_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字_文字c_枠.Dra = value;
				this.X0Y0_悪タトゥ_文字_文字c_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_文字_文字c_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字_文字c_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字_文字c_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_文字_文字c_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_文字_文字c_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字_文字c_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字_文字c_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_文字_文字c_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_文字_文字d_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字_文字d_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字_文字d_枠.Dra = value;
				this.X0Y0_悪タトゥ_文字_文字d_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_文字_文字d_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字_文字d_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字_文字d_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_文字_文字d_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_文字_文字d_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字_文字d_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字_文字d_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_文字_文字d_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_文字_文字e_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字_文字e_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字_文字e_枠.Dra = value;
				this.X0Y0_悪タトゥ_文字_文字e_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_文字_文字e_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_文字_文字e_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_文字_文字e_文字タトゥ3_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ3.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ3.Dra = value;
				this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ3.Hit = value;
			}
		}

		public bool 悪タトゥ_タトゥ_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_タトゥ.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_タトゥ.Dra = value;
				this.X0Y0_悪タトゥ_タトゥ.Hit = value;
			}
		}

		public bool 竜性_鱗1_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗1.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗1.Dra = value;
				this.X0Y0_竜性_鱗1.Hit = value;
			}
		}

		public bool 竜性_鱗2_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗2.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗2.Dra = value;
				this.X0Y0_竜性_鱗2.Hit = value;
			}
		}

		public bool 竜性_鱗3_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗3.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗3.Dra = value;
				this.X0Y0_竜性_鱗3.Hit = value;
			}
		}

		public bool 竜性_鱗4_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗4.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗4.Dra = value;
				this.X0Y0_竜性_鱗4.Hit = value;
			}
		}

		public bool 竜性_鱗5_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗5.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗5.Dra = value;
				this.X0Y0_竜性_鱗5.Hit = value;
			}
		}

		public bool 竜性_鱗6_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗6.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗6.Dra = value;
				this.X0Y0_竜性_鱗6.Hit = value;
			}
		}

		public bool 虫性_蛇腹4_表示
		{
			get
			{
				return this.X0Y0_虫性_蛇腹4.Dra;
			}
			set
			{
				this.X0Y0_虫性_蛇腹4.Dra = value;
				this.X0Y0_虫性_蛇腹4.Hit = value;
			}
		}

		public bool 虫性_蛇腹3_表示
		{
			get
			{
				return this.X0Y0_虫性_蛇腹3.Dra;
			}
			set
			{
				this.X0Y0_虫性_蛇腹3.Dra = value;
				this.X0Y0_虫性_蛇腹3.Hit = value;
			}
		}

		public bool 虫性_蛇腹2_表示
		{
			get
			{
				return this.X0Y0_虫性_蛇腹2.Dra;
			}
			set
			{
				this.X0Y0_虫性_蛇腹2.Dra = value;
				this.X0Y0_虫性_蛇腹2.Hit = value;
			}
		}

		public bool 虫性_蛇腹1_表示
		{
			get
			{
				return this.X0Y0_虫性_蛇腹1.Dra;
			}
			set
			{
				this.X0Y0_虫性_蛇腹1.Dra = value;
				this.X0Y0_虫性_蛇腹1.Hit = value;
			}
		}

		public bool ヴィオラ_左_襟_表示
		{
			get
			{
				return this.X0Y0_ヴィオラ_左_襟.Dra;
			}
			set
			{
				this.X0Y0_ヴィオラ_左_襟.Dra = value;
				this.X0Y0_ヴィオラ_左_襟.Hit = value;
			}
		}

		public bool ヴィオラ_左_縁1_表示
		{
			get
			{
				return this.X0Y0_ヴィオラ_左_縁1.Dra;
			}
			set
			{
				this.X0Y0_ヴィオラ_左_縁1.Dra = value;
				this.X0Y0_ヴィオラ_左_縁1.Hit = value;
			}
		}

		public bool ヴィオラ_左_縁2_表示
		{
			get
			{
				return this.X0Y0_ヴィオラ_左_縁2.Dra;
			}
			set
			{
				this.X0Y0_ヴィオラ_左_縁2.Dra = value;
				this.X0Y0_ヴィオラ_左_縁2.Hit = value;
			}
		}

		public bool ヴィオラ_右_襟_表示
		{
			get
			{
				return this.X0Y0_ヴィオラ_右_襟.Dra;
			}
			set
			{
				this.X0Y0_ヴィオラ_右_襟.Dra = value;
				this.X0Y0_ヴィオラ_右_襟.Hit = value;
			}
		}

		public bool ヴィオラ_右_縁1_表示
		{
			get
			{
				return this.X0Y0_ヴィオラ_右_縁1.Dra;
			}
			set
			{
				this.X0Y0_ヴィオラ_右_縁1.Dra = value;
				this.X0Y0_ヴィオラ_右_縁1.Hit = value;
			}
		}

		public bool ヴィオラ_右_縁2_表示
		{
			get
			{
				return this.X0Y0_ヴィオラ_右_縁2.Dra;
			}
			set
			{
				this.X0Y0_ヴィオラ_右_縁2.Dra = value;
				this.X0Y0_ヴィオラ_右_縁2.Hit = value;
			}
		}

		public bool 首輪_革_表示
		{
			get
			{
				return this.X0Y0_首輪_革.Dra;
			}
			set
			{
				this.X0Y0_首輪_革.Dra = value;
				this.X0Y0_首輪_革.Hit = value;
			}
		}

		public bool 首輪_金具1_表示
		{
			get
			{
				return this.X0Y0_首輪_金具1.Dra;
			}
			set
			{
				this.X0Y0_首輪_金具1.Dra = value;
				this.X0Y0_首輪_金具1.Hit = value;
			}
		}

		public bool 首輪_金具2_表示
		{
			get
			{
				return this.X0Y0_首輪_金具2.Dra;
			}
			set
			{
				this.X0Y0_首輪_金具2.Dra = value;
				this.X0Y0_首輪_金具2.Hit = value;
			}
		}

		public bool 首輪_金具3_表示
		{
			get
			{
				return this.X0Y0_首輪_金具3.Dra;
			}
			set
			{
				this.X0Y0_首輪_金具3.Dra = value;
				this.X0Y0_首輪_金具3.Hit = value;
			}
		}

		public bool 首輪_金具左_表示
		{
			get
			{
				return this.X0Y0_首輪_金具左.Dra;
			}
			set
			{
				this.X0Y0_首輪_金具左.Dra = value;
				this.X0Y0_首輪_金具左.Hit = value;
			}
		}

		public bool 首輪_金具右_表示
		{
			get
			{
				return this.X0Y0_首輪_金具右.Dra;
			}
			set
			{
				this.X0Y0_首輪_金具右.Dra = value;
				this.X0Y0_首輪_金具右.Hit = value;
			}
		}

		public bool 首輪表示
		{
			get
			{
				return this.首輪_革_表示;
			}
			set
			{
				this.首輪_革_表示 = value;
				this.首輪_金具1_表示 = value;
				this.首輪_金具2_表示 = value;
				this.首輪_金具3_表示 = value;
				this.首輪_金具左_表示 = value;
				this.首輪_金具右_表示 = value;
			}
		}

		public bool ヴィオラ襟ベ\u30FCス表示
		{
			get
			{
				return this.ヴィオラ_左_襟_表示;
			}
			set
			{
				this.ヴィオラ_左_襟_表示 = value;
				this.ヴィオラ_右_襟_表示 = value;
			}
		}

		public bool ヴィオラ縁表示
		{
			get
			{
				return this.ヴィオラ_左_縁1_表示;
			}
			set
			{
				this.ヴィオラ_左_縁1_表示 = value;
				this.ヴィオラ_左_縁2_表示 = value;
				this.ヴィオラ_右_縁1_表示 = value;
				this.ヴィオラ_右_縁2_表示 = value;
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
				return this.植性_蔦_表示;
			}
			set
			{
				this.植性_蔦_表示 = value;
				this.植性_棘左上_表示 = value;
				this.植性_棘左下_表示 = value;
				this.植性_棘右上_表示 = value;
				this.植性_棘右下_表示 = value;
				this.首_表示 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ左_表示 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ右_表示 = value;
				this.淫タトゥ_タトゥ左_表示 = value;
				this.淫タトゥ_タトゥ右_表示 = value;
				this.悪タトゥ_文字_文字a_枠_表示 = value;
				this.悪タトゥ_文字_文字a_文字タトゥ1_表示 = value;
				this.悪タトゥ_文字_文字a_文字タトゥ2_表示 = value;
				this.悪タトゥ_文字_文字b_枠_表示 = value;
				this.悪タトゥ_文字_文字b_文字タトゥ1_表示 = value;
				this.悪タトゥ_文字_文字b_文字タトゥ2_表示 = value;
				this.悪タトゥ_文字_文字c_枠_表示 = value;
				this.悪タトゥ_文字_文字c_文字タトゥ1_表示 = value;
				this.悪タトゥ_文字_文字c_文字タトゥ2_表示 = value;
				this.悪タトゥ_文字_文字d_枠_表示 = value;
				this.悪タトゥ_文字_文字d_文字タトゥ1_表示 = value;
				this.悪タトゥ_文字_文字d_文字タトゥ2_表示 = value;
				this.悪タトゥ_文字_文字e_枠_表示 = value;
				this.悪タトゥ_文字_文字e_文字タトゥ1_表示 = value;
				this.悪タトゥ_文字_文字e_文字タトゥ2_表示 = value;
				this.悪タトゥ_文字_文字e_文字タトゥ3_表示 = value;
				this.悪タトゥ_タトゥ_表示 = value;
				this.竜性_鱗1_表示 = value;
				this.竜性_鱗2_表示 = value;
				this.竜性_鱗3_表示 = value;
				this.竜性_鱗4_表示 = value;
				this.竜性_鱗5_表示 = value;
				this.竜性_鱗6_表示 = value;
				this.虫性_蛇腹4_表示 = value;
				this.虫性_蛇腹3_表示 = value;
				this.虫性_蛇腹2_表示 = value;
				this.虫性_蛇腹1_表示 = value;
				this.ヴィオラ_左_襟_表示 = value;
				this.ヴィオラ_左_縁1_表示 = value;
				this.ヴィオラ_左_縁2_表示 = value;
				this.ヴィオラ_右_襟_表示 = value;
				this.ヴィオラ_右_縁1_表示 = value;
				this.ヴィオラ_右_縁2_表示 = value;
				this.首輪_革_表示 = value;
				this.首輪_金具1_表示 = value;
				this.首輪_金具2_表示 = value;
				this.首輪_金具3_表示 = value;
				this.首輪_金具左_表示 = value;
				this.首輪_金具右_表示 = value;
				this.鎖1.表示 = value;
				this.鎖2.表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.植性_蔦CD.不透明度;
			}
			set
			{
				this.植性_蔦CD.不透明度 = value;
				this.植性_棘左上CD.不透明度 = value;
				this.植性_棘左下CD.不透明度 = value;
				this.植性_棘右上CD.不透明度 = value;
				this.植性_棘右下CD.不透明度 = value;
				this.首CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ左CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ右CD.不透明度 = value;
				this.淫タトゥ_タトゥ左CD.不透明度 = value;
				this.淫タトゥ_タトゥ右CD.不透明度 = value;
				this.悪タトゥ_文字_文字a_枠CD.不透明度 = value;
				this.悪タトゥ_文字_文字a_文字タトゥ1CD.不透明度 = value;
				this.悪タトゥ_文字_文字a_文字タトゥ2CD.不透明度 = value;
				this.悪タトゥ_文字_文字b_枠CD.不透明度 = value;
				this.悪タトゥ_文字_文字b_文字タトゥ1CD.不透明度 = value;
				this.悪タトゥ_文字_文字b_文字タトゥ2CD.不透明度 = value;
				this.悪タトゥ_文字_文字c_枠CD.不透明度 = value;
				this.悪タトゥ_文字_文字c_文字タトゥ1CD.不透明度 = value;
				this.悪タトゥ_文字_文字c_文字タトゥ2CD.不透明度 = value;
				this.悪タトゥ_文字_文字d_枠CD.不透明度 = value;
				this.悪タトゥ_文字_文字d_文字タトゥ1CD.不透明度 = value;
				this.悪タトゥ_文字_文字d_文字タトゥ2CD.不透明度 = value;
				this.悪タトゥ_文字_文字e_枠CD.不透明度 = value;
				this.悪タトゥ_文字_文字e_文字タトゥ1CD.不透明度 = value;
				this.悪タトゥ_文字_文字e_文字タトゥ2CD.不透明度 = value;
				this.悪タトゥ_文字_文字e_文字タトゥ3CD.不透明度 = value;
				this.悪タトゥ_タトゥCD.不透明度 = value;
				this.竜性_鱗1CD.不透明度 = value;
				this.竜性_鱗2CD.不透明度 = value;
				this.竜性_鱗3CD.不透明度 = value;
				this.竜性_鱗4CD.不透明度 = value;
				this.竜性_鱗5CD.不透明度 = value;
				this.竜性_鱗6CD.不透明度 = value;
				this.虫性_蛇腹4CD.不透明度 = value;
				this.虫性_蛇腹3CD.不透明度 = value;
				this.虫性_蛇腹2CD.不透明度 = value;
				this.虫性_蛇腹1CD.不透明度 = value;
				this.ヴィオラ_左_襟CD.不透明度 = value;
				this.ヴィオラ_左_縁1CD.不透明度 = value;
				this.ヴィオラ_左_縁2CD.不透明度 = value;
				this.ヴィオラ_右_襟CD.不透明度 = value;
				this.ヴィオラ_右_縁1CD.不透明度 = value;
				this.ヴィオラ_右_縁2CD.不透明度 = value;
				this.首輪_革CD.不透明度 = value;
				this.首輪_金具1CD.不透明度 = value;
				this.首輪_金具2CD.不透明度 = value;
				this.首輪_金具3CD.不透明度 = value;
				this.首輪_金具左CD.不透明度 = value;
				this.首輪_金具右CD.不透明度 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_植性_蔦);
			Are.Draw(this.X0Y0_植性_棘左上);
			Are.Draw(this.X0Y0_植性_棘左下);
			Are.Draw(this.X0Y0_植性_棘右上);
			Are.Draw(this.X0Y0_植性_棘右下);
			Are.Draw(this.X0Y0_首);
			Are.Draw(this.X0Y0_虫性_蛇腹4);
			Are.Draw(this.X0Y0_虫性_蛇腹3);
			Are.Draw(this.X0Y0_虫性_蛇腹2);
			Are.Draw(this.X0Y0_虫性_蛇腹1);
			Are.Draw(this.X0Y0_竜性_鱗1);
			Are.Draw(this.X0Y0_竜性_鱗2);
			Are.Draw(this.X0Y0_竜性_鱗3);
			Are.Draw(this.X0Y0_竜性_鱗4);
			Are.Draw(this.X0Y0_竜性_鱗5);
			Are.Draw(this.X0Y0_竜性_鱗6);
			Are.Draw(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左);
			Are.Draw(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右);
			Are.Draw(this.X0Y0_淫タトゥ_タトゥ左);
			Are.Draw(this.X0Y0_淫タトゥ_タトゥ右);
			Are.Draw(this.X0Y0_悪タトゥ_文字_文字a_枠);
			Are.Draw(this.X0Y0_悪タトゥ_文字_文字a_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_文字_文字a_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_文字_文字b_枠);
			Are.Draw(this.X0Y0_悪タトゥ_文字_文字b_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_文字_文字b_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_文字_文字c_枠);
			Are.Draw(this.X0Y0_悪タトゥ_文字_文字c_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_文字_文字c_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_文字_文字d_枠);
			Are.Draw(this.X0Y0_悪タトゥ_文字_文字d_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_文字_文字d_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_文字_文字e_枠);
			Are.Draw(this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ3);
			Are.Draw(this.X0Y0_悪タトゥ_タトゥ);
			this.キスマ\u30FCク.Draw(Are);
			this.鞭痕.Draw(Are);
			Are.Draw(this.X0Y0_ヴィオラ_左_襟);
			Are.Draw(this.X0Y0_ヴィオラ_左_縁1);
			Are.Draw(this.X0Y0_ヴィオラ_左_縁2);
			Are.Draw(this.X0Y0_ヴィオラ_右_襟);
			Are.Draw(this.X0Y0_ヴィオラ_右_縁1);
			Are.Draw(this.X0Y0_ヴィオラ_右_縁2);
			Are.Draw(this.X0Y0_首輪_革);
			Are.Draw(this.X0Y0_首輪_金具1);
			Are.Draw(this.X0Y0_首輪_金具2);
			Are.Draw(this.X0Y0_首輪_金具3);
			Are.Draw(this.X0Y0_首輪_金具左);
			Are.Draw(this.X0Y0_首輪_金具右);
			this.鎖1.描画0(Are);
			this.鎖2.描画0(Are);
		}

		public override void Dispose()
		{
			base.Dispose();
			this.鎖1.Dispose();
			this.鎖2.Dispose();
		}

		public override bool Is布(Par p)
		{
			return p == this.X0Y0_ヴィオラ_左_襟 || p == this.X0Y0_ヴィオラ_左_縁1 || p == this.X0Y0_ヴィオラ_左_縁2 || p == this.X0Y0_ヴィオラ_右_襟 || p == this.X0Y0_ヴィオラ_右_縁1 || p == this.X0Y0_ヴィオラ_右_縁2;
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_首輪_革 || p == this.X0Y0_首輪_金具1 || p == this.X0Y0_首輪_金具2 || p == this.X0Y0_首輪_金具3 || p == this.X0Y0_首輪_金具左 || p == this.X0Y0_首輪_金具右;
		}

		public JointS 頭_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_首, 0);
			}
		}

		public JointS 鎖1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_首輪_金具左, 0);
			}
		}

		public JointS 鎖2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_首輪_金具右, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_植性_蔦CP.Update();
			this.X0Y0_植性_棘左上CP.Update();
			this.X0Y0_植性_棘左下CP.Update();
			this.X0Y0_植性_棘右上CP.Update();
			this.X0Y0_植性_棘右下CP.Update();
			this.X0Y0_首CP.Update();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左CP.Update();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右CP.Update();
			this.X0Y0_淫タトゥ_タトゥ左CP.Update();
			this.X0Y0_淫タトゥ_タトゥ右CP.Update();
			this.X0Y0_悪タトゥ_文字_文字a_枠CP.Update();
			this.X0Y0_悪タトゥ_文字_文字a_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_文字_文字a_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_文字_文字b_枠CP.Update();
			this.X0Y0_悪タトゥ_文字_文字b_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_文字_文字b_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_文字_文字c_枠CP.Update();
			this.X0Y0_悪タトゥ_文字_文字c_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_文字_文字c_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_文字_文字d_枠CP.Update();
			this.X0Y0_悪タトゥ_文字_文字d_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_文字_文字d_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_文字_文字e_枠CP.Update();
			this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_文字_文字e_文字タトゥ3CP.Update();
			this.X0Y0_悪タトゥ_タトゥCP.Update();
			this.X0Y0_竜性_鱗1CP.Update();
			this.X0Y0_竜性_鱗2CP.Update();
			this.X0Y0_竜性_鱗3CP.Update();
			this.X0Y0_竜性_鱗4CP.Update();
			this.X0Y0_竜性_鱗5CP.Update();
			this.X0Y0_竜性_鱗6CP.Update();
			this.X0Y0_虫性_蛇腹4CP.Update();
			this.X0Y0_虫性_蛇腹3CP.Update();
			this.X0Y0_虫性_蛇腹2CP.Update();
			this.X0Y0_虫性_蛇腹1CP.Update();
			this.X0Y0_ヴィオラ_左_襟CP.Update();
			this.X0Y0_ヴィオラ_左_縁1CP.Update();
			this.X0Y0_ヴィオラ_左_縁2CP.Update();
			this.X0Y0_ヴィオラ_右_襟CP.Update();
			this.X0Y0_ヴィオラ_右_縁1CP.Update();
			this.X0Y0_ヴィオラ_右_縁2CP.Update();
			this.X0Y0_首輪_革CP.Update();
			this.X0Y0_首輪_金具1CP.Update();
			this.X0Y0_首輪_金具2CP.Update();
			this.X0Y0_首輪_金具3CP.Update();
			this.X0Y0_首輪_金具左CP.Update();
			this.X0Y0_首輪_金具右CP.Update();
			this.鎖1.接続PA();
			this.鎖2.接続PA();
			this.鎖1.色更新();
			this.鎖2.色更新();
		}

		private void 配色(体配色 体配色)
		{
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.植性_蔦CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.植性_棘左上CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_棘左下CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_棘右上CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_棘右下CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.首CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.淫タトゥ_ハ\u30FCト_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_文字_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.虫性_蛇腹4CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_蛇腹3CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_蛇腹2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_蛇腹1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.ヴィオラ_左_襟CD = new ColorD();
			this.ヴィオラ_左_縁1CD = new ColorD();
			this.ヴィオラ_左_縁2CD = new ColorD();
			this.ヴィオラ_右_襟CD = new ColorD();
			this.ヴィオラ_右_縁1CD = new ColorD();
			this.ヴィオラ_右_縁2CD = new ColorD();
			this.首輪_革CD = new ColorD();
			this.首輪_金具1CD = new ColorD();
			this.首輪_金具2CD = new ColorD();
			this.首輪_金具3CD = new ColorD();
			this.首輪_金具左CD = new ColorD();
			this.首輪_金具右CD = new ColorD();
		}

		public void ドレス配色(ドレス首色 配色)
		{
			this.ヴィオラ_左_襟CD.色 = 配色.生地色;
			this.ヴィオラ_左_縁1CD.色 = 配色.縁色;
			this.ヴィオラ_左_縁2CD.色 = this.ヴィオラ_左_縁1CD.色;
			this.ヴィオラ_右_襟CD.色 = this.ヴィオラ_左_襟CD.色;
			this.ヴィオラ_右_縁1CD.色 = this.ヴィオラ_左_縁1CD.色;
			this.ヴィオラ_右_縁2CD.色 = this.ヴィオラ_左_縁1CD.色;
		}

		public void 首輪配色(拘束具色 配色)
		{
			this.首輪_革CD.色 = 配色.革部色;
			this.首輪_金具1CD.色 = 配色.金具色;
			this.首輪_金具2CD.色 = this.首輪_金具1CD.色;
			this.首輪_金具3CD.色 = this.首輪_金具1CD.色;
			this.首輪_金具左CD.色 = this.首輪_金具1CD.色;
			this.首輪_金具右CD.色 = this.首輪_金具1CD.色;
		}

		public void 鎖配色(鎖色 配色)
		{
			this.鎖1.配色鎖(配色);
			this.鎖2.配色鎖(配色);
		}

		public Par X0Y0_植性_蔦;

		public Par X0Y0_植性_棘左上;

		public Par X0Y0_植性_棘左下;

		public Par X0Y0_植性_棘右上;

		public Par X0Y0_植性_棘右下;

		public Par X0Y0_首;

		public Par X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左;

		public Par X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右;

		public Par X0Y0_淫タトゥ_タトゥ左;

		public Par X0Y0_淫タトゥ_タトゥ右;

		public Par X0Y0_悪タトゥ_文字_文字a_枠;

		public Par X0Y0_悪タトゥ_文字_文字a_文字タトゥ1;

		public Par X0Y0_悪タトゥ_文字_文字a_文字タトゥ2;

		public Par X0Y0_悪タトゥ_文字_文字b_枠;

		public Par X0Y0_悪タトゥ_文字_文字b_文字タトゥ1;

		public Par X0Y0_悪タトゥ_文字_文字b_文字タトゥ2;

		public Par X0Y0_悪タトゥ_文字_文字c_枠;

		public Par X0Y0_悪タトゥ_文字_文字c_文字タトゥ1;

		public Par X0Y0_悪タトゥ_文字_文字c_文字タトゥ2;

		public Par X0Y0_悪タトゥ_文字_文字d_枠;

		public Par X0Y0_悪タトゥ_文字_文字d_文字タトゥ1;

		public Par X0Y0_悪タトゥ_文字_文字d_文字タトゥ2;

		public Par X0Y0_悪タトゥ_文字_文字e_枠;

		public Par X0Y0_悪タトゥ_文字_文字e_文字タトゥ1;

		public Par X0Y0_悪タトゥ_文字_文字e_文字タトゥ2;

		public Par X0Y0_悪タトゥ_文字_文字e_文字タトゥ3;

		public Par X0Y0_悪タトゥ_タトゥ;

		public Par X0Y0_竜性_鱗1;

		public Par X0Y0_竜性_鱗2;

		public Par X0Y0_竜性_鱗3;

		public Par X0Y0_竜性_鱗4;

		public Par X0Y0_竜性_鱗5;

		public Par X0Y0_竜性_鱗6;

		public Par X0Y0_虫性_蛇腹4;

		public Par X0Y0_虫性_蛇腹3;

		public Par X0Y0_虫性_蛇腹2;

		public Par X0Y0_虫性_蛇腹1;

		public Par X0Y0_ヴィオラ_左_襟;

		public Par X0Y0_ヴィオラ_左_縁1;

		public Par X0Y0_ヴィオラ_左_縁2;

		public Par X0Y0_ヴィオラ_右_襟;

		public Par X0Y0_ヴィオラ_右_縁1;

		public Par X0Y0_ヴィオラ_右_縁2;

		public Par X0Y0_首輪_革;

		public Par X0Y0_首輪_金具1;

		public Par X0Y0_首輪_金具2;

		public Par X0Y0_首輪_金具3;

		public Par X0Y0_首輪_金具左;

		public Par X0Y0_首輪_金具右;

		public ColorD 植性_蔦CD;

		public ColorD 植性_棘左上CD;

		public ColorD 植性_棘左下CD;

		public ColorD 植性_棘右上CD;

		public ColorD 植性_棘右下CD;

		public ColorD 首CD;

		public ColorD 淫タトゥ_ハ\u30FCト_タトゥ左CD;

		public ColorD 淫タトゥ_ハ\u30FCト_タトゥ右CD;

		public ColorD 淫タトゥ_タトゥ左CD;

		public ColorD 淫タトゥ_タトゥ右CD;

		public ColorD 悪タトゥ_文字_文字a_枠CD;

		public ColorD 悪タトゥ_文字_文字a_文字タトゥ1CD;

		public ColorD 悪タトゥ_文字_文字a_文字タトゥ2CD;

		public ColorD 悪タトゥ_文字_文字b_枠CD;

		public ColorD 悪タトゥ_文字_文字b_文字タトゥ1CD;

		public ColorD 悪タトゥ_文字_文字b_文字タトゥ2CD;

		public ColorD 悪タトゥ_文字_文字c_枠CD;

		public ColorD 悪タトゥ_文字_文字c_文字タトゥ1CD;

		public ColorD 悪タトゥ_文字_文字c_文字タトゥ2CD;

		public ColorD 悪タトゥ_文字_文字d_枠CD;

		public ColorD 悪タトゥ_文字_文字d_文字タトゥ1CD;

		public ColorD 悪タトゥ_文字_文字d_文字タトゥ2CD;

		public ColorD 悪タトゥ_文字_文字e_枠CD;

		public ColorD 悪タトゥ_文字_文字e_文字タトゥ1CD;

		public ColorD 悪タトゥ_文字_文字e_文字タトゥ2CD;

		public ColorD 悪タトゥ_文字_文字e_文字タトゥ3CD;

		public ColorD 悪タトゥ_タトゥCD;

		public ColorD 竜性_鱗1CD;

		public ColorD 竜性_鱗2CD;

		public ColorD 竜性_鱗3CD;

		public ColorD 竜性_鱗4CD;

		public ColorD 竜性_鱗5CD;

		public ColorD 竜性_鱗6CD;

		public ColorD 虫性_蛇腹4CD;

		public ColorD 虫性_蛇腹3CD;

		public ColorD 虫性_蛇腹2CD;

		public ColorD 虫性_蛇腹1CD;

		public ColorD ヴィオラ_左_襟CD;

		public ColorD ヴィオラ_左_縁1CD;

		public ColorD ヴィオラ_左_縁2CD;

		public ColorD ヴィオラ_右_襟CD;

		public ColorD ヴィオラ_右_縁1CD;

		public ColorD ヴィオラ_右_縁2CD;

		public ColorD 首輪_革CD;

		public ColorD 首輪_金具1CD;

		public ColorD 首輪_金具2CD;

		public ColorD 首輪_金具3CD;

		public ColorD 首輪_金具左CD;

		public ColorD 首輪_金具右CD;

		public ColorP X0Y0_植性_蔦CP;

		public ColorP X0Y0_植性_棘左上CP;

		public ColorP X0Y0_植性_棘左下CP;

		public ColorP X0Y0_植性_棘右上CP;

		public ColorP X0Y0_植性_棘右下CP;

		public ColorP X0Y0_首CP;

		public ColorP X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左CP;

		public ColorP X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右CP;

		public ColorP X0Y0_淫タトゥ_タトゥ左CP;

		public ColorP X0Y0_淫タトゥ_タトゥ右CP;

		public ColorP X0Y0_悪タトゥ_文字_文字a_枠CP;

		public ColorP X0Y0_悪タトゥ_文字_文字a_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_文字_文字a_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_文字_文字b_枠CP;

		public ColorP X0Y0_悪タトゥ_文字_文字b_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_文字_文字b_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_文字_文字c_枠CP;

		public ColorP X0Y0_悪タトゥ_文字_文字c_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_文字_文字c_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_文字_文字d_枠CP;

		public ColorP X0Y0_悪タトゥ_文字_文字d_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_文字_文字d_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_文字_文字e_枠CP;

		public ColorP X0Y0_悪タトゥ_文字_文字e_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_文字_文字e_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_文字_文字e_文字タトゥ3CP;

		public ColorP X0Y0_悪タトゥ_タトゥCP;

		public ColorP X0Y0_竜性_鱗1CP;

		public ColorP X0Y0_竜性_鱗2CP;

		public ColorP X0Y0_竜性_鱗3CP;

		public ColorP X0Y0_竜性_鱗4CP;

		public ColorP X0Y0_竜性_鱗5CP;

		public ColorP X0Y0_竜性_鱗6CP;

		public ColorP X0Y0_虫性_蛇腹4CP;

		public ColorP X0Y0_虫性_蛇腹3CP;

		public ColorP X0Y0_虫性_蛇腹2CP;

		public ColorP X0Y0_虫性_蛇腹1CP;

		public ColorP X0Y0_ヴィオラ_左_襟CP;

		public ColorP X0Y0_ヴィオラ_左_縁1CP;

		public ColorP X0Y0_ヴィオラ_左_縁2CP;

		public ColorP X0Y0_ヴィオラ_右_襟CP;

		public ColorP X0Y0_ヴィオラ_右_縁1CP;

		public ColorP X0Y0_ヴィオラ_右_縁2CP;

		public ColorP X0Y0_首輪_革CP;

		public ColorP X0Y0_首輪_金具1CP;

		public ColorP X0Y0_首輪_金具2CP;

		public ColorP X0Y0_首輪_金具3CP;

		public ColorP X0Y0_首輪_金具左CP;

		public ColorP X0Y0_首輪_金具右CP;

		public 拘束鎖 鎖1;

		public 拘束鎖 鎖2;

		public スタンプK キスマ\u30FCク;

		public スタンプW 鞭痕;

		public Ele[] 頭_接続;
	}
}
