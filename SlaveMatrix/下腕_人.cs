using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 下腕_人 : 下腕
	{
		public 下腕_人(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 下腕_人D e)
		{
			下腕_人.<>c__DisplayClass405_0 CS$<>8__locals1 = new 下腕_人.<>c__DisplayClass405_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.腕左["下腕"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_下腕 = pars["下腕"].ToPar();
			Pars pars2 = pars["筋肉"].ToPars();
			this.X0Y0_筋肉_筋肉下 = pars2["筋肉下"].ToPar();
			this.X0Y0_筋肉_筋肉上 = pars2["筋肉上"].ToPar();
			pars2 = pars["植性1"].ToPars();
			Pars pars3 = pars2["通常"].ToPars();
			Pars pars4 = pars3["花弁"].ToPars();
			this.X0Y0_植性1_通常_花弁_花弁 = pars4["花弁"].ToPar();
			Pars pars5 = pars4["影"].ToPars();
			this.X0Y0_植性1_通常_花弁_影_花弁影1 = pars5["花弁影1"].ToPar();
			this.X0Y0_植性1_通常_花弁_影_花弁影2 = pars5["花弁影2"].ToPar();
			this.X0Y0_植性1_通常_花弁_影_花弁影3 = pars5["花弁影3"].ToPar();
			this.X0Y0_植性1_通常_花弁_影_花弁影4 = pars5["花弁影4"].ToPar();
			this.X0Y0_植性1_通常_花弁_影_花弁影5 = pars5["花弁影5"].ToPar();
			pars3 = pars2["欠損"].ToPars();
			pars4 = pars3["花弁"].ToPars();
			this.X0Y0_植性1_欠損_花弁_花弁 = pars4["花弁"].ToPar();
			pars5 = pars4["影"].ToPars();
			this.X0Y0_植性1_欠損_花弁_影_花弁影1 = pars5["花弁影1"].ToPar();
			this.X0Y0_植性1_欠損_花弁_影_花弁影2 = pars5["花弁影2"].ToPar();
			this.X0Y0_植性1_欠損_花弁_影_花弁影3 = pars5["花弁影3"].ToPar();
			this.X0Y0_植性1_欠損_花弁_影_花弁影4 = pars5["花弁影4"].ToPar();
			this.X0Y0_植性1_欠損_花弁_影_花弁影5 = pars5["花弁影5"].ToPar();
			pars2 = pars["獣性1"].ToPars();
			this.X0Y0_獣性1_獣腕 = pars2["獣腕"].ToPar();
			pars2 = pars["竜性1"].ToPars();
			pars3 = pars2["肘"].ToPars();
			this.X0Y0_竜性1_肘_肘1 = pars3["肘1"].ToPar();
			this.X0Y0_竜性1_肘_肘2 = pars3["肘2"].ToPar();
			pars3 = pars2["鱗"].ToPars();
			this.X0Y0_竜性1_鱗_鱗5 = pars3["鱗5"].ToPar();
			this.X0Y0_竜性1_鱗_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_竜性1_鱗_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_竜性1_鱗_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_竜性1_鱗_鱗1 = pars3["鱗1"].ToPar();
			pars3 = pars2["手首"].ToPars();
			this.X0Y0_竜性1_手首_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_竜性1_手首_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_竜性1_手首_鱗1 = pars3["鱗1"].ToPar();
			pars2 = pars["虫性1"].ToPars();
			this.X0Y0_虫性1_虫肘 = pars2["虫肘"].ToPar();
			this.X0Y0_虫性1_虫腕上 = pars2["虫腕上"].ToPar();
			pars2 = pars["淫タトゥ"].ToPars();
			pars3 = pars2["手首"].ToPars();
			this.X0Y0_淫タトゥ_手首_タトゥ = pars3["タトゥ"].ToPar();
			pars4 = pars3["ハート1"].ToPars();
			this.X0Y0_淫タトゥ_手首_ハ\u30FCト1_タトゥ左 = pars4["タトゥ左"].ToPar();
			this.X0Y0_淫タトゥ_手首_ハ\u30FCト1_タトゥ右 = pars4["タトゥ右"].ToPar();
			pars4 = pars3["ハート3"].ToPars();
			this.X0Y0_淫タトゥ_手首_ハ\u30FCト3_タトゥ左 = pars4["タトゥ左"].ToPar();
			this.X0Y0_淫タトゥ_手首_ハ\u30FCト3_タトゥ右 = pars4["タトゥ右"].ToPar();
			pars4 = pars3["ハート2"].ToPars();
			this.X0Y0_淫タトゥ_手首_ハ\u30FCト2_タトゥ左 = pars4["タトゥ左"].ToPar();
			this.X0Y0_淫タトゥ_手首_ハ\u30FCト2_タトゥ右 = pars4["タトゥ右"].ToPar();
			pars3 = pars2["通常"].ToPars();
			pars4 = pars3["ハート1"].ToPars();
			this.X0Y0_淫タトゥ_通常_ハ\u30FCト1_タトゥ左 = pars4["タトゥ左"].ToPar();
			this.X0Y0_淫タトゥ_通常_ハ\u30FCト1_タトゥ右 = pars4["タトゥ右"].ToPar();
			pars4 = pars3["ハート2"].ToPars();
			this.X0Y0_淫タトゥ_通常_ハ\u30FCト2_タトゥ左 = pars4["タトゥ左"].ToPar();
			this.X0Y0_淫タトゥ_通常_ハ\u30FCト2_タトゥ右 = pars4["タトゥ右"].ToPar();
			pars3 = pars2["筋肉"].ToPars();
			pars4 = pars3["ハート1"].ToPars();
			this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト1_タトゥ左 = pars4["タトゥ左"].ToPar();
			this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト1_タトゥ右 = pars4["タトゥ右"].ToPar();
			pars4 = pars3["ハート2"].ToPars();
			this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト2_タトゥ左 = pars4["タトゥ左"].ToPar();
			this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト2_タトゥ右 = pars4["タトゥ右"].ToPar();
			pars2 = pars["悪タトゥ"].ToPars();
			pars3 = pars2["通常"].ToPars();
			pars4 = pars3["文字1"].ToPars();
			pars5 = pars4["文字a"].ToPars();
			this.X0Y0_悪タトゥ_通常_文字1_文字a_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars4["文字b"].ToPars();
			this.X0Y0_悪タトゥ_通常_文字1_文字b_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars4["文字c"].ToPars();
			this.X0Y0_悪タトゥ_通常_文字1_文字c_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars4["文字d"].ToPars();
			this.X0Y0_悪タトゥ_通常_文字1_文字d_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars4["文字e"].ToPars();
			this.X0Y0_悪タトゥ_通常_文字1_文字e_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ3 = pars5["文字タトゥ3"].ToPar();
			pars4 = pars3["文字2"].ToPars();
			pars5 = pars4["文字a"].ToPars();
			this.X0Y0_悪タトゥ_通常_文字2_文字a_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars4["文字b"].ToPars();
			this.X0Y0_悪タトゥ_通常_文字2_文字b_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars4["文字c"].ToPars();
			this.X0Y0_悪タトゥ_通常_文字2_文字c_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars4["文字d"].ToPars();
			this.X0Y0_悪タトゥ_通常_文字2_文字d_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars4["文字e"].ToPars();
			this.X0Y0_悪タトゥ_通常_文字2_文字e_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ3 = pars5["文字タトゥ3"].ToPar();
			this.X0Y0_悪タトゥ_通常_タトゥ1 = pars3["タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_通常_タトゥ2 = pars3["タトゥ2"].ToPar();
			pars4 = pars3["逆十字"].ToPars();
			this.X0Y0_悪タトゥ_通常_逆十字_逆十字1 = pars4["逆十字1"].ToPar();
			this.X0Y0_悪タトゥ_通常_逆十字_逆十字2 = pars4["逆十字2"].ToPar();
			pars3 = pars2["筋肉"].ToPars();
			pars4 = pars3["文字1"].ToPars();
			pars5 = pars4["文字a"].ToPars();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字a_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars4["文字b"].ToPars();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字b_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars4["文字c"].ToPars();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字c_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars4["文字d"].ToPars();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字d_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars4["文字e"].ToPars();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字e_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ3 = pars5["文字タトゥ3"].ToPar();
			pars4 = pars3["文字2"].ToPars();
			pars5 = pars4["文字a"].ToPars();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字a_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars4["文字b"].ToPars();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字b_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars4["文字c"].ToPars();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字c_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars4["文字d"].ToPars();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字d_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars4["文字e"].ToPars();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字e_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ3 = pars5["文字タトゥ3"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_タトゥ1 = pars3["タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_タトゥ2 = pars3["タトゥ2"].ToPar();
			pars4 = pars3["逆十字"].ToPars();
			this.X0Y0_悪タトゥ_筋肉_逆十字_逆十字1 = pars4["逆十字1"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_逆十字_逆十字2 = pars4["逆十字2"].ToPar();
			pars2 = pars["植性2"].ToPars();
			pars3 = pars2["通常"].ToPars();
			pars4 = pars3["萼"].ToPars();
			this.X0Y0_植性2_通常_萼_萼上 = pars4["萼上"].ToPar();
			this.X0Y0_植性2_通常_萼_萼下 = pars4["萼下"].ToPar();
			this.X0Y0_植性2_通常_萼_萼中 = pars4["萼中"].ToPar();
			pars3 = pars2["欠損"].ToPars();
			pars4 = pars3["萼"].ToPars();
			this.X0Y0_植性2_欠損_萼_萼上 = pars4["萼上"].ToPar();
			this.X0Y0_植性2_欠損_萼_萼下 = pars4["萼下"].ToPar();
			this.X0Y0_植性2_欠損_萼_萼中 = pars4["萼中"].ToPar();
			pars2 = pars["獣性2"].ToPars();
			this.X0Y0_獣性2_獣毛 = pars2["獣毛"].ToPar();
			pars2 = pars["竜性2"].ToPars();
			pars3 = pars2["刺"].ToPars();
			this.X0Y0_竜性2_棘_棘5 = pars3["刺5"].ToPar();
			this.X0Y0_竜性2_棘_棘4 = pars3["刺4"].ToPar();
			this.X0Y0_竜性2_棘_棘3 = pars3["刺3"].ToPar();
			this.X0Y0_竜性2_棘_棘2 = pars3["刺2"].ToPar();
			this.X0Y0_竜性2_棘_棘1 = pars3["刺1"].ToPar();
			pars2 = pars["虫性2"].ToPars();
			this.X0Y0_虫性2_虫腕下 = pars2["虫腕下"].ToPar();
			this.X0Y0_虫性2_虫棘1 = pars2["虫棘1"].ToPar();
			this.X0Y0_虫性2_虫棘2 = pars2["虫棘2"].ToPar();
			this.X0Y0_虫性2_虫棘3 = pars2["虫棘3"].ToPar();
			this.X0Y0_虫性2_虫棘4 = pars2["虫棘4"].ToPar();
			this.X0Y0_虫性2_虫鎌節 = pars2["虫鎌節"].ToPar();
			this.X0Y0_傷X1 = pars["傷X1"].ToPar();
			this.X0Y0_傷I1 = pars["傷I1"].ToPar();
			this.X0Y0_傷I2 = pars["傷I2"].ToPar();
			this.X0Y0_ハイライト = pars["ハイライト"].ToPar();
			pars2 = pars["グローブ"].ToPars();
			pars3 = pars2["通常"].ToPars();
			this.X0Y0_グロ\u30FCブ_通常_グロ\u30FCブ = pars3["グローブ"].ToPar();
			this.X0Y0_グロ\u30FCブ_通常_縁 = pars3["縁"].ToPar();
			pars3 = pars2["筋肉"].ToPars();
			this.X0Y0_グロ\u30FCブ_筋肉_グロ\u30FCブ = pars3["グローブ"].ToPar();
			this.X0Y0_グロ\u30FCブ_筋肉_縁 = pars3["縁"].ToPar();
			pars2 = pars["鎧"].ToPars();
			pars3 = pars2["ベルト"].ToPars();
			this.X0Y0_鎧_ベルト_ベルト1 = pars3["ベルト1"].ToPar();
			pars4 = pars3["通常"].ToPars();
			this.X0Y0_鎧_ベルト_通常_ベルト2 = pars4["ベルト2"].ToPar();
			pars4 = pars3["筋肉"].ToPars();
			this.X0Y0_鎧_ベルト_筋肉_ベルト2 = pars4["ベルト2"].ToPar();
			pars3 = pars2["鎧"].ToPars();
			this.X0Y0_鎧_鎧_鎧2 = pars3["鎧2"].ToPar();
			this.X0Y0_鎧_鎧_鎧1 = pars3["鎧1"].ToPar();
			pars2 = pars["腕輪"].ToPars();
			this.X0Y0_腕輪_革 = pars2["革"].ToPar();
			this.X0Y0_腕輪_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_腕輪_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_腕輪_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_腕輪_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_腕輪_金具右 = pars2["金具右"].ToPar();
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
			this.植性1_通常_花弁_花弁_表示 = e.植性1_通常_花弁_花弁_表示;
			this.植性1_通常_花弁_影_花弁影1_表示 = e.植性1_通常_花弁_影_花弁影1_表示;
			this.植性1_通常_花弁_影_花弁影2_表示 = e.植性1_通常_花弁_影_花弁影2_表示;
			this.植性1_通常_花弁_影_花弁影3_表示 = e.植性1_通常_花弁_影_花弁影3_表示;
			this.植性1_通常_花弁_影_花弁影4_表示 = e.植性1_通常_花弁_影_花弁影4_表示;
			this.植性1_通常_花弁_影_花弁影5_表示 = e.植性1_通常_花弁_影_花弁影5_表示;
			this.植性1_欠損_花弁_花弁_表示 = e.植性1_欠損_花弁_花弁_表示;
			this.植性1_欠損_花弁_影_花弁影1_表示 = e.植性1_欠損_花弁_影_花弁影1_表示;
			this.植性1_欠損_花弁_影_花弁影2_表示 = e.植性1_欠損_花弁_影_花弁影2_表示;
			this.植性1_欠損_花弁_影_花弁影3_表示 = e.植性1_欠損_花弁_影_花弁影3_表示;
			this.植性1_欠損_花弁_影_花弁影4_表示 = e.植性1_欠損_花弁_影_花弁影4_表示;
			this.植性1_欠損_花弁_影_花弁影5_表示 = e.植性1_欠損_花弁_影_花弁影5_表示;
			this.獣性1_獣腕_表示 = e.獣性1_獣腕_表示;
			this.竜性1_肘_肘1_表示 = e.竜性1_肘_肘1_表示;
			this.竜性1_肘_肘2_表示 = e.竜性1_肘_肘2_表示;
			this.竜性1_鱗_鱗5_表示 = e.竜性1_鱗_鱗5_表示;
			this.竜性1_鱗_鱗4_表示 = e.竜性1_鱗_鱗4_表示;
			this.竜性1_鱗_鱗3_表示 = e.竜性1_鱗_鱗3_表示;
			this.竜性1_鱗_鱗2_表示 = e.竜性1_鱗_鱗2_表示;
			this.竜性1_鱗_鱗1_表示 = e.竜性1_鱗_鱗1_表示;
			this.竜性1_手首_鱗3_表示 = e.竜性1_手首_鱗3_表示;
			this.竜性1_手首_鱗2_表示 = e.竜性1_手首_鱗2_表示;
			this.竜性1_手首_鱗1_表示 = e.竜性1_手首_鱗1_表示;
			this.虫性1_虫肘_表示 = e.虫性1_虫肘_表示;
			this.虫性1_虫腕上_表示 = e.虫性1_虫腕上_表示;
			this.淫タトゥ_手首_タトゥ_表示 = e.淫タトゥ_手首_タトゥ_表示;
			this.淫タトゥ_手首_ハ\u30FCト1_タトゥ左_表示 = e.淫タトゥ_手首_ハ\u30FCト1_タトゥ左_表示;
			this.淫タトゥ_手首_ハ\u30FCト1_タトゥ右_表示 = e.淫タトゥ_手首_ハ\u30FCト1_タトゥ右_表示;
			this.淫タトゥ_手首_ハ\u30FCト3_タトゥ左_表示 = e.淫タトゥ_手首_ハ\u30FCト3_タトゥ左_表示;
			this.淫タトゥ_手首_ハ\u30FCト3_タトゥ右_表示 = e.淫タトゥ_手首_ハ\u30FCト3_タトゥ右_表示;
			this.淫タトゥ_手首_ハ\u30FCト2_タトゥ左_表示 = e.淫タトゥ_手首_ハ\u30FCト2_タトゥ左_表示;
			this.淫タトゥ_手首_ハ\u30FCト2_タトゥ右_表示 = e.淫タトゥ_手首_ハ\u30FCト2_タトゥ右_表示;
			this.淫タトゥ_通常_ハ\u30FCト1_タトゥ左_表示 = e.淫タトゥ_通常_ハ\u30FCト1_タトゥ左_表示;
			this.淫タトゥ_通常_ハ\u30FCト1_タトゥ右_表示 = e.淫タトゥ_通常_ハ\u30FCト1_タトゥ右_表示;
			this.淫タトゥ_通常_ハ\u30FCト2_タトゥ左_表示 = e.淫タトゥ_通常_ハ\u30FCト2_タトゥ左_表示;
			this.淫タトゥ_通常_ハ\u30FCト2_タトゥ右_表示 = e.淫タトゥ_通常_ハ\u30FCト2_タトゥ右_表示;
			this.淫タトゥ_筋肉_ハ\u30FCト1_タトゥ左_表示 = e.淫タトゥ_筋肉_ハ\u30FCト1_タトゥ左_表示;
			this.淫タトゥ_筋肉_ハ\u30FCト1_タトゥ右_表示 = e.淫タトゥ_筋肉_ハ\u30FCト1_タトゥ右_表示;
			this.淫タトゥ_筋肉_ハ\u30FCト2_タトゥ左_表示 = e.淫タトゥ_筋肉_ハ\u30FCト2_タトゥ左_表示;
			this.淫タトゥ_筋肉_ハ\u30FCト2_タトゥ右_表示 = e.淫タトゥ_筋肉_ハ\u30FCト2_タトゥ右_表示;
			this.悪タトゥ_通常_文字1_文字a_枠_表示 = e.悪タトゥ_通常_文字1_文字a_枠_表示;
			this.悪タトゥ_通常_文字1_文字a_文字タトゥ1_表示 = e.悪タトゥ_通常_文字1_文字a_文字タトゥ1_表示;
			this.悪タトゥ_通常_文字1_文字a_文字タトゥ2_表示 = e.悪タトゥ_通常_文字1_文字a_文字タトゥ2_表示;
			this.悪タトゥ_通常_文字1_文字b_枠_表示 = e.悪タトゥ_通常_文字1_文字b_枠_表示;
			this.悪タトゥ_通常_文字1_文字b_文字タトゥ1_表示 = e.悪タトゥ_通常_文字1_文字b_文字タトゥ1_表示;
			this.悪タトゥ_通常_文字1_文字b_文字タトゥ2_表示 = e.悪タトゥ_通常_文字1_文字b_文字タトゥ2_表示;
			this.悪タトゥ_通常_文字1_文字c_枠_表示 = e.悪タトゥ_通常_文字1_文字c_枠_表示;
			this.悪タトゥ_通常_文字1_文字c_文字タトゥ1_表示 = e.悪タトゥ_通常_文字1_文字c_文字タトゥ1_表示;
			this.悪タトゥ_通常_文字1_文字c_文字タトゥ2_表示 = e.悪タトゥ_通常_文字1_文字c_文字タトゥ2_表示;
			this.悪タトゥ_通常_文字1_文字d_枠_表示 = e.悪タトゥ_通常_文字1_文字d_枠_表示;
			this.悪タトゥ_通常_文字1_文字d_文字タトゥ1_表示 = e.悪タトゥ_通常_文字1_文字d_文字タトゥ1_表示;
			this.悪タトゥ_通常_文字1_文字d_文字タトゥ2_表示 = e.悪タトゥ_通常_文字1_文字d_文字タトゥ2_表示;
			this.悪タトゥ_通常_文字1_文字e_枠_表示 = e.悪タトゥ_通常_文字1_文字e_枠_表示;
			this.悪タトゥ_通常_文字1_文字e_文字タトゥ1_表示 = e.悪タトゥ_通常_文字1_文字e_文字タトゥ1_表示;
			this.悪タトゥ_通常_文字1_文字e_文字タトゥ2_表示 = e.悪タトゥ_通常_文字1_文字e_文字タトゥ2_表示;
			this.悪タトゥ_通常_文字1_文字e_文字タトゥ3_表示 = e.悪タトゥ_通常_文字1_文字e_文字タトゥ3_表示;
			this.悪タトゥ_通常_文字2_文字a_枠_表示 = e.悪タトゥ_通常_文字2_文字a_枠_表示;
			this.悪タトゥ_通常_文字2_文字a_文字タトゥ1_表示 = e.悪タトゥ_通常_文字2_文字a_文字タトゥ1_表示;
			this.悪タトゥ_通常_文字2_文字a_文字タトゥ2_表示 = e.悪タトゥ_通常_文字2_文字a_文字タトゥ2_表示;
			this.悪タトゥ_通常_文字2_文字b_枠_表示 = e.悪タトゥ_通常_文字2_文字b_枠_表示;
			this.悪タトゥ_通常_文字2_文字b_文字タトゥ1_表示 = e.悪タトゥ_通常_文字2_文字b_文字タトゥ1_表示;
			this.悪タトゥ_通常_文字2_文字b_文字タトゥ2_表示 = e.悪タトゥ_通常_文字2_文字b_文字タトゥ2_表示;
			this.悪タトゥ_通常_文字2_文字c_枠_表示 = e.悪タトゥ_通常_文字2_文字c_枠_表示;
			this.悪タトゥ_通常_文字2_文字c_文字タトゥ1_表示 = e.悪タトゥ_通常_文字2_文字c_文字タトゥ1_表示;
			this.悪タトゥ_通常_文字2_文字c_文字タトゥ2_表示 = e.悪タトゥ_通常_文字2_文字c_文字タトゥ2_表示;
			this.悪タトゥ_通常_文字2_文字d_枠_表示 = e.悪タトゥ_通常_文字2_文字d_枠_表示;
			this.悪タトゥ_通常_文字2_文字d_文字タトゥ1_表示 = e.悪タトゥ_通常_文字2_文字d_文字タトゥ1_表示;
			this.悪タトゥ_通常_文字2_文字d_文字タトゥ2_表示 = e.悪タトゥ_通常_文字2_文字d_文字タトゥ2_表示;
			this.悪タトゥ_通常_文字2_文字e_枠_表示 = e.悪タトゥ_通常_文字2_文字e_枠_表示;
			this.悪タトゥ_通常_文字2_文字e_文字タトゥ1_表示 = e.悪タトゥ_通常_文字2_文字e_文字タトゥ1_表示;
			this.悪タトゥ_通常_文字2_文字e_文字タトゥ2_表示 = e.悪タトゥ_通常_文字2_文字e_文字タトゥ2_表示;
			this.悪タトゥ_通常_文字2_文字e_文字タトゥ3_表示 = e.悪タトゥ_通常_文字2_文字e_文字タトゥ3_表示;
			this.悪タトゥ_通常_タトゥ1_表示 = e.悪タトゥ_通常_タトゥ1_表示;
			this.悪タトゥ_通常_タトゥ2_表示 = e.悪タトゥ_通常_タトゥ2_表示;
			this.悪タトゥ_通常_逆十字_逆十字1_表示 = e.悪タトゥ_通常_逆十字_逆十字1_表示;
			this.悪タトゥ_通常_逆十字_逆十字2_表示 = e.悪タトゥ_通常_逆十字_逆十字2_表示;
			this.悪タトゥ_筋肉_文字1_文字a_枠_表示 = e.悪タトゥ_筋肉_文字1_文字a_枠_表示;
			this.悪タトゥ_筋肉_文字1_文字a_文字タトゥ1_表示 = e.悪タトゥ_筋肉_文字1_文字a_文字タトゥ1_表示;
			this.悪タトゥ_筋肉_文字1_文字a_文字タトゥ2_表示 = e.悪タトゥ_筋肉_文字1_文字a_文字タトゥ2_表示;
			this.悪タトゥ_筋肉_文字1_文字b_枠_表示 = e.悪タトゥ_筋肉_文字1_文字b_枠_表示;
			this.悪タトゥ_筋肉_文字1_文字b_文字タトゥ1_表示 = e.悪タトゥ_筋肉_文字1_文字b_文字タトゥ1_表示;
			this.悪タトゥ_筋肉_文字1_文字b_文字タトゥ2_表示 = e.悪タトゥ_筋肉_文字1_文字b_文字タトゥ2_表示;
			this.悪タトゥ_筋肉_文字1_文字c_枠_表示 = e.悪タトゥ_筋肉_文字1_文字c_枠_表示;
			this.悪タトゥ_筋肉_文字1_文字c_文字タトゥ1_表示 = e.悪タトゥ_筋肉_文字1_文字c_文字タトゥ1_表示;
			this.悪タトゥ_筋肉_文字1_文字c_文字タトゥ2_表示 = e.悪タトゥ_筋肉_文字1_文字c_文字タトゥ2_表示;
			this.悪タトゥ_筋肉_文字1_文字d_枠_表示 = e.悪タトゥ_筋肉_文字1_文字d_枠_表示;
			this.悪タトゥ_筋肉_文字1_文字d_文字タトゥ1_表示 = e.悪タトゥ_筋肉_文字1_文字d_文字タトゥ1_表示;
			this.悪タトゥ_筋肉_文字1_文字d_文字タトゥ2_表示 = e.悪タトゥ_筋肉_文字1_文字d_文字タトゥ2_表示;
			this.悪タトゥ_筋肉_文字1_文字e_枠_表示 = e.悪タトゥ_筋肉_文字1_文字e_枠_表示;
			this.悪タトゥ_筋肉_文字1_文字e_文字タトゥ1_表示 = e.悪タトゥ_筋肉_文字1_文字e_文字タトゥ1_表示;
			this.悪タトゥ_筋肉_文字1_文字e_文字タトゥ2_表示 = e.悪タトゥ_筋肉_文字1_文字e_文字タトゥ2_表示;
			this.悪タトゥ_筋肉_文字1_文字e_文字タトゥ3_表示 = e.悪タトゥ_筋肉_文字1_文字e_文字タトゥ3_表示;
			this.悪タトゥ_筋肉_文字2_文字a_枠_表示 = e.悪タトゥ_筋肉_文字2_文字a_枠_表示;
			this.悪タトゥ_筋肉_文字2_文字a_文字タトゥ1_表示 = e.悪タトゥ_筋肉_文字2_文字a_文字タトゥ1_表示;
			this.悪タトゥ_筋肉_文字2_文字a_文字タトゥ2_表示 = e.悪タトゥ_筋肉_文字2_文字a_文字タトゥ2_表示;
			this.悪タトゥ_筋肉_文字2_文字b_枠_表示 = e.悪タトゥ_筋肉_文字2_文字b_枠_表示;
			this.悪タトゥ_筋肉_文字2_文字b_文字タトゥ1_表示 = e.悪タトゥ_筋肉_文字2_文字b_文字タトゥ1_表示;
			this.悪タトゥ_筋肉_文字2_文字b_文字タトゥ2_表示 = e.悪タトゥ_筋肉_文字2_文字b_文字タトゥ2_表示;
			this.悪タトゥ_筋肉_文字2_文字c_枠_表示 = e.悪タトゥ_筋肉_文字2_文字c_枠_表示;
			this.悪タトゥ_筋肉_文字2_文字c_文字タトゥ1_表示 = e.悪タトゥ_筋肉_文字2_文字c_文字タトゥ1_表示;
			this.悪タトゥ_筋肉_文字2_文字c_文字タトゥ2_表示 = e.悪タトゥ_筋肉_文字2_文字c_文字タトゥ2_表示;
			this.悪タトゥ_筋肉_文字2_文字d_枠_表示 = e.悪タトゥ_筋肉_文字2_文字d_枠_表示;
			this.悪タトゥ_筋肉_文字2_文字d_文字タトゥ1_表示 = e.悪タトゥ_筋肉_文字2_文字d_文字タトゥ1_表示;
			this.悪タトゥ_筋肉_文字2_文字d_文字タトゥ2_表示 = e.悪タトゥ_筋肉_文字2_文字d_文字タトゥ2_表示;
			this.悪タトゥ_筋肉_文字2_文字e_枠_表示 = e.悪タトゥ_筋肉_文字2_文字e_枠_表示;
			this.悪タトゥ_筋肉_文字2_文字e_文字タトゥ1_表示 = e.悪タトゥ_筋肉_文字2_文字e_文字タトゥ1_表示;
			this.悪タトゥ_筋肉_文字2_文字e_文字タトゥ2_表示 = e.悪タトゥ_筋肉_文字2_文字e_文字タトゥ2_表示;
			this.悪タトゥ_筋肉_文字2_文字e_文字タトゥ3_表示 = e.悪タトゥ_筋肉_文字2_文字e_文字タトゥ3_表示;
			this.悪タトゥ_筋肉_タトゥ1_表示 = e.悪タトゥ_筋肉_タトゥ1_表示;
			this.悪タトゥ_筋肉_タトゥ2_表示 = e.悪タトゥ_筋肉_タトゥ2_表示;
			this.悪タトゥ_筋肉_逆十字_逆十字1_表示 = e.悪タトゥ_筋肉_逆十字_逆十字1_表示;
			this.悪タトゥ_筋肉_逆十字_逆十字2_表示 = e.悪タトゥ_筋肉_逆十字_逆十字2_表示;
			this.植性2_通常_萼_萼上_表示 = e.植性2_通常_萼_萼上_表示;
			this.植性2_通常_萼_萼下_表示 = e.植性2_通常_萼_萼下_表示;
			this.植性2_通常_萼_萼中_表示 = e.植性2_通常_萼_萼中_表示;
			this.植性2_欠損_萼_萼上_表示 = e.植性2_欠損_萼_萼上_表示;
			this.植性2_欠損_萼_萼下_表示 = e.植性2_欠損_萼_萼下_表示;
			this.植性2_欠損_萼_萼中_表示 = e.植性2_欠損_萼_萼中_表示;
			this.獣性2_獣毛_表示 = e.獣性2_獣毛_表示;
			this.竜性2_棘_棘5_表示 = e.竜性2_棘_棘5_表示;
			this.竜性2_棘_棘4_表示 = e.竜性2_棘_棘4_表示;
			this.竜性2_棘_棘3_表示 = e.竜性2_棘_棘3_表示;
			this.竜性2_棘_棘2_表示 = e.竜性2_棘_棘2_表示;
			this.竜性2_棘_棘1_表示 = e.竜性2_棘_棘1_表示;
			this.虫性2_虫腕下_表示 = e.虫性2_虫腕下_表示;
			this.虫性2_虫棘1_表示 = e.虫性2_虫棘1_表示;
			this.虫性2_虫棘2_表示 = e.虫性2_虫棘2_表示;
			this.虫性2_虫棘3_表示 = e.虫性2_虫棘3_表示;
			this.虫性2_虫棘4_表示 = e.虫性2_虫棘4_表示;
			this.虫性2_虫鎌節_表示 = e.虫性2_虫鎌節_表示;
			this.傷X1_表示 = e.傷X1_表示;
			this.傷I1_表示 = e.傷I1_表示;
			this.傷I2_表示 = e.傷I2_表示;
			this.ハイライト_表示 = e.ハイライト_表示;
			this.グロ\u30FCブ_通常_グロ\u30FCブ_表示 = e.グロ\u30FCブ_通常_グロ\u30FCブ_表示;
			this.グロ\u30FCブ_通常_縁_表示 = e.グロ\u30FCブ_通常_縁_表示;
			this.グロ\u30FCブ_筋肉_グロ\u30FCブ_表示 = e.グロ\u30FCブ_筋肉_グロ\u30FCブ_表示;
			this.グロ\u30FCブ_筋肉_縁_表示 = e.グロ\u30FCブ_筋肉_縁_表示;
			this.鎧_ベルト_ベルト1_表示 = e.鎧_ベルト_ベルト1_表示;
			this.鎧_ベルト_通常_ベルト2_表示 = e.鎧_ベルト_通常_ベルト2_表示;
			this.鎧_ベルト_筋肉_ベルト2_表示 = e.鎧_ベルト_筋肉_ベルト2_表示;
			this.鎧_鎧_鎧2_表示 = e.鎧_鎧_鎧2_表示;
			this.鎧_鎧_鎧1_表示 = e.鎧_鎧_鎧1_表示;
			this.腕輪_革_表示 = e.腕輪_革_表示;
			this.腕輪_金具1_表示 = e.腕輪_金具1_表示;
			this.腕輪_金具2_表示 = e.腕輪_金具2_表示;
			this.腕輪_金具3_表示 = e.腕輪_金具3_表示;
			this.腕輪_金具左_表示 = e.腕輪_金具左_表示;
			this.腕輪_金具右_表示 = e.腕輪_金具右_表示;
			this.植性1_花弁_花弁_表示 = e.植性1_花弁_花弁_表示;
			this.植性1_花弁_影_花弁影1_表示 = e.植性1_花弁_影_花弁影1_表示;
			this.植性1_花弁_影_花弁影2_表示 = e.植性1_花弁_影_花弁影2_表示;
			this.植性1_花弁_影_花弁影3_表示 = e.植性1_花弁_影_花弁影3_表示;
			this.植性1_花弁_影_花弁影4_表示 = e.植性1_花弁_影_花弁影4_表示;
			this.植性1_花弁_影_花弁影5_表示 = e.植性1_花弁_影_花弁影5_表示;
			this.淫タトゥ_ハ\u30FCト1_タトゥ左_表示 = e.淫タトゥ_ハ\u30FCト1_タトゥ左_表示;
			this.淫タトゥ_ハ\u30FCト1_タトゥ右_表示 = e.淫タトゥ_ハ\u30FCト1_タトゥ右_表示;
			this.淫タトゥ_ハ\u30FCト2_タトゥ左_表示 = e.淫タトゥ_ハ\u30FCト2_タトゥ左_表示;
			this.淫タトゥ_ハ\u30FCト2_タトゥ右_表示 = e.淫タトゥ_ハ\u30FCト2_タトゥ右_表示;
			this.悪タトゥ_文字1_文字a_枠_表示 = e.悪タトゥ_文字1_文字a_枠_表示;
			this.悪タトゥ_文字1_文字a_文字タトゥ1_表示 = e.悪タトゥ_文字1_文字a_文字タトゥ1_表示;
			this.悪タトゥ_文字1_文字a_文字タトゥ2_表示 = e.悪タトゥ_文字1_文字a_文字タトゥ2_表示;
			this.悪タトゥ_文字1_文字b_枠_表示 = e.悪タトゥ_文字1_文字b_枠_表示;
			this.悪タトゥ_文字1_文字b_文字タトゥ1_表示 = e.悪タトゥ_文字1_文字b_文字タトゥ1_表示;
			this.悪タトゥ_文字1_文字b_文字タトゥ2_表示 = e.悪タトゥ_文字1_文字b_文字タトゥ2_表示;
			this.悪タトゥ_文字1_文字c_枠_表示 = e.悪タトゥ_文字1_文字c_枠_表示;
			this.悪タトゥ_文字1_文字c_文字タトゥ1_表示 = e.悪タトゥ_文字1_文字c_文字タトゥ1_表示;
			this.悪タトゥ_文字1_文字c_文字タトゥ2_表示 = e.悪タトゥ_文字1_文字c_文字タトゥ2_表示;
			this.悪タトゥ_文字1_文字d_枠_表示 = e.悪タトゥ_文字1_文字d_枠_表示;
			this.悪タトゥ_文字1_文字d_文字タトゥ1_表示 = e.悪タトゥ_文字1_文字d_文字タトゥ1_表示;
			this.悪タトゥ_文字1_文字d_文字タトゥ2_表示 = e.悪タトゥ_文字1_文字d_文字タトゥ2_表示;
			this.悪タトゥ_文字1_文字e_枠_表示 = e.悪タトゥ_文字1_文字e_枠_表示;
			this.悪タトゥ_文字1_文字e_文字タトゥ1_表示 = e.悪タトゥ_文字1_文字e_文字タトゥ1_表示;
			this.悪タトゥ_文字1_文字e_文字タトゥ2_表示 = e.悪タトゥ_文字1_文字e_文字タトゥ2_表示;
			this.悪タトゥ_文字1_文字e_文字タトゥ3_表示 = e.悪タトゥ_文字1_文字e_文字タトゥ3_表示;
			this.悪タトゥ_文字2_文字a_枠_表示 = e.悪タトゥ_文字2_文字a_枠_表示;
			this.悪タトゥ_文字2_文字a_文字タトゥ1_表示 = e.悪タトゥ_文字2_文字a_文字タトゥ1_表示;
			this.悪タトゥ_文字2_文字a_文字タトゥ2_表示 = e.悪タトゥ_文字2_文字a_文字タトゥ2_表示;
			this.悪タトゥ_文字2_文字b_枠_表示 = e.悪タトゥ_文字2_文字b_枠_表示;
			this.悪タトゥ_文字2_文字b_文字タトゥ1_表示 = e.悪タトゥ_文字2_文字b_文字タトゥ1_表示;
			this.悪タトゥ_文字2_文字b_文字タトゥ2_表示 = e.悪タトゥ_文字2_文字b_文字タトゥ2_表示;
			this.悪タトゥ_文字2_文字c_枠_表示 = e.悪タトゥ_文字2_文字c_枠_表示;
			this.悪タトゥ_文字2_文字c_文字タトゥ1_表示 = e.悪タトゥ_文字2_文字c_文字タトゥ1_表示;
			this.悪タトゥ_文字2_文字c_文字タトゥ2_表示 = e.悪タトゥ_文字2_文字c_文字タトゥ2_表示;
			this.悪タトゥ_文字2_文字d_枠_表示 = e.悪タトゥ_文字2_文字d_枠_表示;
			this.悪タトゥ_文字2_文字d_文字タトゥ1_表示 = e.悪タトゥ_文字2_文字d_文字タトゥ1_表示;
			this.悪タトゥ_文字2_文字d_文字タトゥ2_表示 = e.悪タトゥ_文字2_文字d_文字タトゥ2_表示;
			this.悪タトゥ_文字2_文字e_枠_表示 = e.悪タトゥ_文字2_文字e_枠_表示;
			this.悪タトゥ_文字2_文字e_文字タトゥ1_表示 = e.悪タトゥ_文字2_文字e_文字タトゥ1_表示;
			this.悪タトゥ_文字2_文字e_文字タトゥ2_表示 = e.悪タトゥ_文字2_文字e_文字タトゥ2_表示;
			this.悪タトゥ_文字2_文字e_文字タトゥ3_表示 = e.悪タトゥ_文字2_文字e_文字タトゥ3_表示;
			this.悪タトゥ_タトゥ1_表示 = e.悪タトゥ_タトゥ1_表示;
			this.悪タトゥ_タトゥ2_表示 = e.悪タトゥ_タトゥ2_表示;
			this.悪タトゥ_逆十字_逆十字1_表示 = e.悪タトゥ_逆十字_逆十字1_表示;
			this.悪タトゥ_逆十字_逆十字2_表示 = e.悪タトゥ_逆十字_逆十字2_表示;
			this.植性2_萼_萼上_表示 = e.植性2_萼_萼上_表示;
			this.植性2_萼_萼下_表示 = e.植性2_萼_萼下_表示;
			this.植性2_萼_萼中_表示 = e.植性2_萼_萼中_表示;
			this.グロ\u30FCブ_グロ\u30FCブ_表示 = e.グロ\u30FCブ_グロ\u30FCブ_表示;
			this.グロ\u30FCブ_縁_表示 = e.グロ\u30FCブ_縁_表示;
			this.鎧_ベルト_ベルト2_表示 = e.鎧_ベルト_ベルト2_表示;
			this.ハイライト表示 = e.ハイライト表示;
			this.腕輪表示 = e.腕輪表示;
			this.グロ\u30FCブ表示 = e.グロ\u30FCブ表示;
			this.メイル表示 = e.メイル表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.外腕_接続.Count > 0)
			{
				Ele f;
				this.外腕_接続 = e.外腕_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.下腕_人_外腕_接続;
					f.接続(CS$<>8__locals1.<>4__this.外腕_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.手_接続.Count > 0)
			{
				Ele f;
				this.手_接続 = e.手_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.下腕_人_手_接続;
					f.接続(CS$<>8__locals1.<>4__this.手_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.虫鎌_接続.Count > 0)
			{
				Ele f;
				this.虫鎌_接続 = e.虫鎌_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.下腕_人_虫鎌_接続;
					f.接続(CS$<>8__locals1.<>4__this.虫鎌_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_下腕CP = new ColorP(this.X0Y0_下腕, this.下腕CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_筋肉_筋肉下CP = new ColorP(this.X0Y0_筋肉_筋肉下, this.筋肉_筋肉下CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_筋肉_筋肉上CP = new ColorP(this.X0Y0_筋肉_筋肉上, this.筋肉_筋肉上CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_植性1_通常_花弁_花弁CP = new ColorP(this.X0Y0_植性1_通常_花弁_花弁, this.植性1_花弁_花弁CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性1_通常_花弁_影_花弁影1CP = new ColorP(this.X0Y0_植性1_通常_花弁_影_花弁影1, this.植性1_花弁_影_花弁影1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性1_通常_花弁_影_花弁影2CP = new ColorP(this.X0Y0_植性1_通常_花弁_影_花弁影2, this.植性1_花弁_影_花弁影2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性1_通常_花弁_影_花弁影3CP = new ColorP(this.X0Y0_植性1_通常_花弁_影_花弁影3, this.植性1_花弁_影_花弁影3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性1_通常_花弁_影_花弁影4CP = new ColorP(this.X0Y0_植性1_通常_花弁_影_花弁影4, this.植性1_花弁_影_花弁影4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性1_通常_花弁_影_花弁影5CP = new ColorP(this.X0Y0_植性1_通常_花弁_影_花弁影5, this.植性1_花弁_影_花弁影5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性1_欠損_花弁_花弁CP = new ColorP(this.X0Y0_植性1_欠損_花弁_花弁, this.植性1_花弁_花弁CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性1_欠損_花弁_影_花弁影1CP = new ColorP(this.X0Y0_植性1_欠損_花弁_影_花弁影1, this.植性1_花弁_影_花弁影1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性1_欠損_花弁_影_花弁影2CP = new ColorP(this.X0Y0_植性1_欠損_花弁_影_花弁影2, this.植性1_花弁_影_花弁影2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性1_欠損_花弁_影_花弁影3CP = new ColorP(this.X0Y0_植性1_欠損_花弁_影_花弁影3, this.植性1_花弁_影_花弁影3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性1_欠損_花弁_影_花弁影4CP = new ColorP(this.X0Y0_植性1_欠損_花弁_影_花弁影4, this.植性1_花弁_影_花弁影4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性1_欠損_花弁_影_花弁影5CP = new ColorP(this.X0Y0_植性1_欠損_花弁_影_花弁影5, this.植性1_花弁_影_花弁影5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_獣性1_獣腕CP = new ColorP(this.X0Y0_獣性1_獣腕, this.獣性1_獣腕CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性1_肘_肘1CP = new ColorP(this.X0Y0_竜性1_肘_肘1, this.竜性1_肘_肘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性1_肘_肘2CP = new ColorP(this.X0Y0_竜性1_肘_肘2, this.竜性1_肘_肘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性1_鱗_鱗5CP = new ColorP(this.X0Y0_竜性1_鱗_鱗5, this.竜性1_鱗_鱗5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性1_鱗_鱗4CP = new ColorP(this.X0Y0_竜性1_鱗_鱗4, this.竜性1_鱗_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性1_鱗_鱗3CP = new ColorP(this.X0Y0_竜性1_鱗_鱗3, this.竜性1_鱗_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性1_鱗_鱗2CP = new ColorP(this.X0Y0_竜性1_鱗_鱗2, this.竜性1_鱗_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性1_鱗_鱗1CP = new ColorP(this.X0Y0_竜性1_鱗_鱗1, this.竜性1_鱗_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性1_手首_鱗3CP = new ColorP(this.X0Y0_竜性1_手首_鱗3, this.竜性1_手首_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性1_手首_鱗2CP = new ColorP(this.X0Y0_竜性1_手首_鱗2, this.竜性1_手首_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性1_手首_鱗1CP = new ColorP(this.X0Y0_竜性1_手首_鱗1, this.竜性1_手首_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性1_虫肘CP = new ColorP(this.X0Y0_虫性1_虫肘, this.虫性1_虫肘CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性1_虫腕上CP = new ColorP(this.X0Y0_虫性1_虫腕上, this.虫性1_虫腕上CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_手首_タトゥCP = new ColorP(this.X0Y0_淫タトゥ_手首_タトゥ, this.淫タトゥ_手首_タトゥCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_手首_ハ\u30FCト1_タトゥ左CP = new ColorP(this.X0Y0_淫タトゥ_手首_ハ\u30FCト1_タトゥ左, this.淫タトゥ_手首_ハ\u30FCト1_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_手首_ハ\u30FCト1_タトゥ右CP = new ColorP(this.X0Y0_淫タトゥ_手首_ハ\u30FCト1_タトゥ右, this.淫タトゥ_手首_ハ\u30FCト1_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_手首_ハ\u30FCト3_タトゥ左CP = new ColorP(this.X0Y0_淫タトゥ_手首_ハ\u30FCト3_タトゥ左, this.淫タトゥ_手首_ハ\u30FCト3_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_手首_ハ\u30FCト3_タトゥ右CP = new ColorP(this.X0Y0_淫タトゥ_手首_ハ\u30FCト3_タトゥ右, this.淫タトゥ_手首_ハ\u30FCト3_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_手首_ハ\u30FCト2_タトゥ左CP = new ColorP(this.X0Y0_淫タトゥ_手首_ハ\u30FCト2_タトゥ左, this.淫タトゥ_手首_ハ\u30FCト2_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_手首_ハ\u30FCト2_タトゥ右CP = new ColorP(this.X0Y0_淫タトゥ_手首_ハ\u30FCト2_タトゥ右, this.淫タトゥ_手首_ハ\u30FCト2_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_通常_ハ\u30FCト1_タトゥ左CP = new ColorP(this.X0Y0_淫タトゥ_通常_ハ\u30FCト1_タトゥ左, this.淫タトゥ_ハ\u30FCト1_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_通常_ハ\u30FCト1_タトゥ右CP = new ColorP(this.X0Y0_淫タトゥ_通常_ハ\u30FCト1_タトゥ右, this.淫タトゥ_ハ\u30FCト1_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_通常_ハ\u30FCト2_タトゥ左CP = new ColorP(this.X0Y0_淫タトゥ_通常_ハ\u30FCト2_タトゥ左, this.淫タトゥ_ハ\u30FCト2_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_通常_ハ\u30FCト2_タトゥ右CP = new ColorP(this.X0Y0_淫タトゥ_通常_ハ\u30FCト2_タトゥ右, this.淫タトゥ_ハ\u30FCト2_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト1_タトゥ左CP = new ColorP(this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト1_タトゥ左, this.淫タトゥ_ハ\u30FCト1_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト1_タトゥ右CP = new ColorP(this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト1_タトゥ右, this.淫タトゥ_ハ\u30FCト1_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト2_タトゥ左CP = new ColorP(this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト2_タトゥ左, this.淫タトゥ_ハ\u30FCト2_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト2_タトゥ右CP = new ColorP(this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト2_タトゥ右, this.淫タトゥ_ハ\u30FCト2_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字1_文字a_枠CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字1_文字a_枠, this.悪タトゥ_文字1_文字a_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ1, this.悪タトゥ_文字1_文字a_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ2, this.悪タトゥ_文字1_文字a_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字1_文字b_枠CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字1_文字b_枠, this.悪タトゥ_文字1_文字b_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ1, this.悪タトゥ_文字1_文字b_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ2, this.悪タトゥ_文字1_文字b_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字1_文字c_枠CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字1_文字c_枠, this.悪タトゥ_文字1_文字c_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ1, this.悪タトゥ_文字1_文字c_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ2, this.悪タトゥ_文字1_文字c_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字1_文字d_枠CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字1_文字d_枠, this.悪タトゥ_文字1_文字d_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ1, this.悪タトゥ_文字1_文字d_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ2, this.悪タトゥ_文字1_文字d_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字1_文字e_枠CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字1_文字e_枠, this.悪タトゥ_文字1_文字e_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ1, this.悪タトゥ_文字1_文字e_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ2, this.悪タトゥ_文字1_文字e_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ3CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ3, this.悪タトゥ_文字1_文字e_文字タトゥ3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字2_文字a_枠CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字2_文字a_枠, this.悪タトゥ_文字2_文字a_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ1, this.悪タトゥ_文字2_文字a_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ2, this.悪タトゥ_文字2_文字a_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字2_文字b_枠CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字2_文字b_枠, this.悪タトゥ_文字2_文字b_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ1, this.悪タトゥ_文字2_文字b_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ2, this.悪タトゥ_文字2_文字b_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字2_文字c_枠CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字2_文字c_枠, this.悪タトゥ_文字2_文字c_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ1, this.悪タトゥ_文字2_文字c_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ2, this.悪タトゥ_文字2_文字c_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字2_文字d_枠CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字2_文字d_枠, this.悪タトゥ_文字2_文字d_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ1, this.悪タトゥ_文字2_文字d_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ2, this.悪タトゥ_文字2_文字d_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字2_文字e_枠CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字2_文字e_枠, this.悪タトゥ_文字2_文字e_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ1, this.悪タトゥ_文字2_文字e_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ2, this.悪タトゥ_文字2_文字e_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ3CP = new ColorP(this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ3, this.悪タトゥ_文字2_文字e_文字タトゥ3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_通常_タトゥ1, this.悪タトゥ_タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_通常_タトゥ2, this.悪タトゥ_タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_逆十字_逆十字1CP = new ColorP(this.X0Y0_悪タトゥ_通常_逆十字_逆十字1, this.悪タトゥ_逆十字_逆十字1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_通常_逆十字_逆十字2CP = new ColorP(this.X0Y0_悪タトゥ_通常_逆十字_逆十字2, this.悪タトゥ_逆十字_逆十字2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字1_文字a_枠CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字1_文字a_枠, this.悪タトゥ_文字1_文字a_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ1, this.悪タトゥ_文字1_文字a_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ2, this.悪タトゥ_文字1_文字a_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字1_文字b_枠CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字1_文字b_枠, this.悪タトゥ_文字1_文字b_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ1, this.悪タトゥ_文字1_文字b_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ2, this.悪タトゥ_文字1_文字b_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字1_文字c_枠CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字1_文字c_枠, this.悪タトゥ_文字1_文字c_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ1, this.悪タトゥ_文字1_文字c_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ2, this.悪タトゥ_文字1_文字c_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字1_文字d_枠CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字1_文字d_枠, this.悪タトゥ_文字1_文字d_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ1, this.悪タトゥ_文字1_文字d_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ2, this.悪タトゥ_文字1_文字d_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字1_文字e_枠CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字1_文字e_枠, this.悪タトゥ_文字1_文字e_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ1, this.悪タトゥ_文字1_文字e_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ2, this.悪タトゥ_文字1_文字e_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ3CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ3, this.悪タトゥ_文字1_文字e_文字タトゥ3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字2_文字a_枠CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字2_文字a_枠, this.悪タトゥ_文字2_文字a_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ1, this.悪タトゥ_文字2_文字a_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ2, this.悪タトゥ_文字2_文字a_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字2_文字b_枠CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字2_文字b_枠, this.悪タトゥ_文字2_文字b_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ1, this.悪タトゥ_文字2_文字b_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ2, this.悪タトゥ_文字2_文字b_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字2_文字c_枠CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字2_文字c_枠, this.悪タトゥ_文字2_文字c_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ1, this.悪タトゥ_文字2_文字c_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ2, this.悪タトゥ_文字2_文字c_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字2_文字d_枠CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字2_文字d_枠, this.悪タトゥ_文字2_文字d_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ1, this.悪タトゥ_文字2_文字d_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ2, this.悪タトゥ_文字2_文字d_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字2_文字e_枠CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字2_文字e_枠, this.悪タトゥ_文字2_文字e_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ1, this.悪タトゥ_文字2_文字e_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ2, this.悪タトゥ_文字2_文字e_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ3CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ3, this.悪タトゥ_文字2_文字e_文字タトゥ3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_タトゥ1, this.悪タトゥ_タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_タトゥ2, this.悪タトゥ_タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_逆十字_逆十字1CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_逆十字_逆十字1, this.悪タトゥ_逆十字_逆十字1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_筋肉_逆十字_逆十字2CP = new ColorP(this.X0Y0_悪タトゥ_筋肉_逆十字_逆十字2, this.悪タトゥ_逆十字_逆十字2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性2_通常_萼_萼上CP = new ColorP(this.X0Y0_植性2_通常_萼_萼上, this.植性2_萼_萼上CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性2_通常_萼_萼下CP = new ColorP(this.X0Y0_植性2_通常_萼_萼下, this.植性2_萼_萼下CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性2_通常_萼_萼中CP = new ColorP(this.X0Y0_植性2_通常_萼_萼中, this.植性2_萼_萼中CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性2_欠損_萼_萼上CP = new ColorP(this.X0Y0_植性2_欠損_萼_萼上, this.植性2_萼_萼上CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性2_欠損_萼_萼下CP = new ColorP(this.X0Y0_植性2_欠損_萼_萼下, this.植性2_萼_萼下CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性2_欠損_萼_萼中CP = new ColorP(this.X0Y0_植性2_欠損_萼_萼中, this.植性2_萼_萼中CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_獣性2_獣毛CP = new ColorP(this.X0Y0_獣性2_獣毛, this.獣性2_獣毛CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性2_棘_棘5CP = new ColorP(this.X0Y0_竜性2_棘_棘5, this.竜性2_棘_棘5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性2_棘_棘4CP = new ColorP(this.X0Y0_竜性2_棘_棘4, this.竜性2_棘_棘4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性2_棘_棘3CP = new ColorP(this.X0Y0_竜性2_棘_棘3, this.竜性2_棘_棘3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性2_棘_棘2CP = new ColorP(this.X0Y0_竜性2_棘_棘2, this.竜性2_棘_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性2_棘_棘1CP = new ColorP(this.X0Y0_竜性2_棘_棘1, this.竜性2_棘_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性2_虫腕下CP = new ColorP(this.X0Y0_虫性2_虫腕下, this.虫性2_虫腕下CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性2_虫棘1CP = new ColorP(this.X0Y0_虫性2_虫棘1, this.虫性2_虫棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性2_虫棘2CP = new ColorP(this.X0Y0_虫性2_虫棘2, this.虫性2_虫棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性2_虫棘3CP = new ColorP(this.X0Y0_虫性2_虫棘3, this.虫性2_虫棘3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性2_虫棘4CP = new ColorP(this.X0Y0_虫性2_虫棘4, this.虫性2_虫棘4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性2_虫鎌節CP = new ColorP(this.X0Y0_虫性2_虫鎌節, this.虫性2_虫鎌節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷X1CP = new ColorP(this.X0Y0_傷X1, this.傷X1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷I1CP = new ColorP(this.X0Y0_傷I1, this.傷I1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷I2CP = new ColorP(this.X0Y0_傷I2, this.傷I2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ハイライトCP = new ColorP(this.X0Y0_ハイライト, this.ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_グロ\u30FCブ_通常_グロ\u30FCブCP = new ColorP(this.X0Y0_グロ\u30FCブ_通常_グロ\u30FCブ, this.グロ\u30FCブ_グロ\u30FCブCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_グロ\u30FCブ_通常_縁CP = new ColorP(this.X0Y0_グロ\u30FCブ_通常_縁, this.グロ\u30FCブ_縁CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_グロ\u30FCブ_筋肉_グロ\u30FCブCP = new ColorP(this.X0Y0_グロ\u30FCブ_筋肉_グロ\u30FCブ, this.グロ\u30FCブ_グロ\u30FCブCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_グロ\u30FCブ_筋肉_縁CP = new ColorP(this.X0Y0_グロ\u30FCブ_筋肉_縁, this.グロ\u30FCブ_縁CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_鎧_ベルト_ベルト1CP = new ColorP(this.X0Y0_鎧_ベルト_ベルト1, this.鎧_ベルト_ベルト1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_鎧_ベルト_通常_ベルト2CP = new ColorP(this.X0Y0_鎧_ベルト_通常_ベルト2, this.鎧_ベルト_ベルト2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_鎧_ベルト_筋肉_ベルト2CP = new ColorP(this.X0Y0_鎧_ベルト_筋肉_ベルト2, this.鎧_ベルト_ベルト2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_鎧_鎧_鎧2CP = new ColorP(this.X0Y0_鎧_鎧_鎧2, this.鎧_鎧_鎧2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_鎧_鎧_鎧1CP = new ColorP(this.X0Y0_鎧_鎧_鎧1, this.鎧_鎧_鎧1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_腕輪_革CP = new ColorP(this.X0Y0_腕輪_革, this.腕輪_革CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_腕輪_金具1CP = new ColorP(this.X0Y0_腕輪_金具1, this.腕輪_金具1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_腕輪_金具2CP = new ColorP(this.X0Y0_腕輪_金具2, this.腕輪_金具2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_腕輪_金具3CP = new ColorP(this.X0Y0_腕輪_金具3, this.腕輪_金具3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_腕輪_金具左CP = new ColorP(this.X0Y0_腕輪_金具左, this.腕輪_金具左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_腕輪_金具右CP = new ColorP(this.X0Y0_腕輪_金具右, this.腕輪_金具右CD, CS$<>8__locals1.DisUnit, true);
			this.傷X1濃度 = e.傷X1濃度;
			this.傷I1濃度 = e.傷I1濃度;
			this.傷I2濃度 = e.傷I2濃度;
			this.ハイライト濃度 = e.ハイライト濃度;
			this.濃度 = e.濃度;
			this.鎖1 = new 拘束鎖(CS$<>8__locals1.DisUnit, false, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖1.接続(this.鎖1_接続点);
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
				this.植性1_花弁_花弁_表示 = this.植性1_花弁_花弁_表示;
				this.植性1_花弁_影_花弁影1_表示 = this.植性1_花弁_影_花弁影1_表示;
				this.植性1_花弁_影_花弁影2_表示 = this.植性1_花弁_影_花弁影2_表示;
				this.植性1_花弁_影_花弁影3_表示 = this.植性1_花弁_影_花弁影3_表示;
				this.植性1_花弁_影_花弁影4_表示 = this.植性1_花弁_影_花弁影4_表示;
				this.植性1_花弁_影_花弁影5_表示 = this.植性1_花弁_影_花弁影5_表示;
				this.植性2_萼_萼上_表示 = this.植性2_萼_萼上_表示;
				this.植性2_萼_萼下_表示 = this.植性2_萼_萼下_表示;
				this.植性2_萼_萼中_表示 = this.植性2_萼_萼中_表示;
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
				this.淫タトゥ_ハ\u30FCト1_タトゥ左_表示 = this.淫タトゥ_ハ\u30FCト1_タトゥ左_表示;
				this.淫タトゥ_ハ\u30FCト1_タトゥ右_表示 = this.淫タトゥ_ハ\u30FCト1_タトゥ右_表示;
				this.淫タトゥ_ハ\u30FCト2_タトゥ左_表示 = this.淫タトゥ_ハ\u30FCト2_タトゥ左_表示;
				this.淫タトゥ_ハ\u30FCト2_タトゥ右_表示 = this.淫タトゥ_ハ\u30FCト2_タトゥ右_表示;
				this.悪タトゥ_文字1_文字a_枠_表示 = this.悪タトゥ_文字1_文字a_枠_表示;
				this.悪タトゥ_文字1_文字a_文字タトゥ1_表示 = this.悪タトゥ_文字1_文字a_文字タトゥ1_表示;
				this.悪タトゥ_文字1_文字a_文字タトゥ2_表示 = this.悪タトゥ_文字1_文字a_文字タトゥ2_表示;
				this.悪タトゥ_文字1_文字b_枠_表示 = this.悪タトゥ_文字1_文字b_枠_表示;
				this.悪タトゥ_文字1_文字b_文字タトゥ1_表示 = this.悪タトゥ_文字1_文字b_文字タトゥ1_表示;
				this.悪タトゥ_文字1_文字b_文字タトゥ2_表示 = this.悪タトゥ_文字1_文字b_文字タトゥ2_表示;
				this.悪タトゥ_文字1_文字c_枠_表示 = this.悪タトゥ_文字1_文字c_枠_表示;
				this.悪タトゥ_文字1_文字c_文字タトゥ1_表示 = this.悪タトゥ_文字1_文字c_文字タトゥ1_表示;
				this.悪タトゥ_文字1_文字c_文字タトゥ2_表示 = this.悪タトゥ_文字1_文字c_文字タトゥ2_表示;
				this.悪タトゥ_文字1_文字d_枠_表示 = this.悪タトゥ_文字1_文字d_枠_表示;
				this.悪タトゥ_文字1_文字d_文字タトゥ1_表示 = this.悪タトゥ_文字1_文字d_文字タトゥ1_表示;
				this.悪タトゥ_文字1_文字d_文字タトゥ2_表示 = this.悪タトゥ_文字1_文字d_文字タトゥ2_表示;
				this.悪タトゥ_文字1_文字e_枠_表示 = this.悪タトゥ_文字1_文字e_枠_表示;
				this.悪タトゥ_文字1_文字e_文字タトゥ1_表示 = this.悪タトゥ_文字1_文字e_文字タトゥ1_表示;
				this.悪タトゥ_文字1_文字e_文字タトゥ2_表示 = this.悪タトゥ_文字1_文字e_文字タトゥ2_表示;
				this.悪タトゥ_文字1_文字e_文字タトゥ3_表示 = this.悪タトゥ_文字1_文字e_文字タトゥ3_表示;
				this.悪タトゥ_文字2_文字a_枠_表示 = this.悪タトゥ_文字2_文字a_枠_表示;
				this.悪タトゥ_文字2_文字a_文字タトゥ1_表示 = this.悪タトゥ_文字2_文字a_文字タトゥ1_表示;
				this.悪タトゥ_文字2_文字a_文字タトゥ2_表示 = this.悪タトゥ_文字2_文字a_文字タトゥ2_表示;
				this.悪タトゥ_文字2_文字b_枠_表示 = this.悪タトゥ_文字2_文字b_枠_表示;
				this.悪タトゥ_文字2_文字b_文字タトゥ1_表示 = this.悪タトゥ_文字2_文字b_文字タトゥ1_表示;
				this.悪タトゥ_文字2_文字b_文字タトゥ2_表示 = this.悪タトゥ_文字2_文字b_文字タトゥ2_表示;
				this.悪タトゥ_文字2_文字c_枠_表示 = this.悪タトゥ_文字2_文字c_枠_表示;
				this.悪タトゥ_文字2_文字c_文字タトゥ1_表示 = this.悪タトゥ_文字2_文字c_文字タトゥ1_表示;
				this.悪タトゥ_文字2_文字c_文字タトゥ2_表示 = this.悪タトゥ_文字2_文字c_文字タトゥ2_表示;
				this.悪タトゥ_文字2_文字d_枠_表示 = this.悪タトゥ_文字2_文字d_枠_表示;
				this.悪タトゥ_文字2_文字d_文字タトゥ1_表示 = this.悪タトゥ_文字2_文字d_文字タトゥ1_表示;
				this.悪タトゥ_文字2_文字d_文字タトゥ2_表示 = this.悪タトゥ_文字2_文字d_文字タトゥ2_表示;
				this.悪タトゥ_文字2_文字e_枠_表示 = this.悪タトゥ_文字2_文字e_枠_表示;
				this.悪タトゥ_文字2_文字e_文字タトゥ1_表示 = this.悪タトゥ_文字2_文字e_文字タトゥ1_表示;
				this.悪タトゥ_文字2_文字e_文字タトゥ2_表示 = this.悪タトゥ_文字2_文字e_文字タトゥ2_表示;
				this.悪タトゥ_文字2_文字e_文字タトゥ3_表示 = this.悪タトゥ_文字2_文字e_文字タトゥ3_表示;
				this.悪タトゥ_タトゥ1_表示 = this.悪タトゥ_タトゥ1_表示;
				this.悪タトゥ_タトゥ2_表示 = this.悪タトゥ_タトゥ2_表示;
				this.悪タトゥ_逆十字_逆十字1_表示 = this.悪タトゥ_逆十字_逆十字1_表示;
				this.悪タトゥ_逆十字_逆十字2_表示 = this.悪タトゥ_逆十字_逆十字2_表示;
				this.グロ\u30FCブ_グロ\u30FCブ_表示 = this.グロ\u30FCブ_グロ\u30FCブ_表示;
				this.グロ\u30FCブ_縁_表示 = this.グロ\u30FCブ_縁_表示;
				this.鎧_ベルト_ベルト2_表示 = this.鎧_ベルト_ベルト2_表示;
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
				this.腕輪表示 = this.拘束_;
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

		public bool 植性1_通常_花弁_花弁_表示
		{
			get
			{
				return this.X0Y0_植性1_通常_花弁_花弁.Dra;
			}
			set
			{
				this.X0Y0_植性1_通常_花弁_花弁.Dra = value;
				this.X0Y0_植性1_通常_花弁_花弁.Hit = value;
			}
		}

		public bool 植性1_通常_花弁_影_花弁影1_表示
		{
			get
			{
				return this.X0Y0_植性1_通常_花弁_影_花弁影1.Dra;
			}
			set
			{
				this.X0Y0_植性1_通常_花弁_影_花弁影1.Dra = value;
				this.X0Y0_植性1_通常_花弁_影_花弁影1.Hit = value;
			}
		}

		public bool 植性1_通常_花弁_影_花弁影2_表示
		{
			get
			{
				return this.X0Y0_植性1_通常_花弁_影_花弁影2.Dra;
			}
			set
			{
				this.X0Y0_植性1_通常_花弁_影_花弁影2.Dra = value;
				this.X0Y0_植性1_通常_花弁_影_花弁影2.Hit = value;
			}
		}

		public bool 植性1_通常_花弁_影_花弁影3_表示
		{
			get
			{
				return this.X0Y0_植性1_通常_花弁_影_花弁影3.Dra;
			}
			set
			{
				this.X0Y0_植性1_通常_花弁_影_花弁影3.Dra = value;
				this.X0Y0_植性1_通常_花弁_影_花弁影3.Hit = value;
			}
		}

		public bool 植性1_通常_花弁_影_花弁影4_表示
		{
			get
			{
				return this.X0Y0_植性1_通常_花弁_影_花弁影4.Dra;
			}
			set
			{
				this.X0Y0_植性1_通常_花弁_影_花弁影4.Dra = value;
				this.X0Y0_植性1_通常_花弁_影_花弁影4.Hit = value;
			}
		}

		public bool 植性1_通常_花弁_影_花弁影5_表示
		{
			get
			{
				return this.X0Y0_植性1_通常_花弁_影_花弁影5.Dra;
			}
			set
			{
				this.X0Y0_植性1_通常_花弁_影_花弁影5.Dra = value;
				this.X0Y0_植性1_通常_花弁_影_花弁影5.Hit = value;
			}
		}

		public bool 植性1_欠損_花弁_花弁_表示
		{
			get
			{
				return this.X0Y0_植性1_欠損_花弁_花弁.Dra;
			}
			set
			{
				this.X0Y0_植性1_欠損_花弁_花弁.Dra = value;
				this.X0Y0_植性1_欠損_花弁_花弁.Hit = value;
			}
		}

		public bool 植性1_欠損_花弁_影_花弁影1_表示
		{
			get
			{
				return this.X0Y0_植性1_欠損_花弁_影_花弁影1.Dra;
			}
			set
			{
				this.X0Y0_植性1_欠損_花弁_影_花弁影1.Dra = value;
				this.X0Y0_植性1_欠損_花弁_影_花弁影1.Hit = value;
			}
		}

		public bool 植性1_欠損_花弁_影_花弁影2_表示
		{
			get
			{
				return this.X0Y0_植性1_欠損_花弁_影_花弁影2.Dra;
			}
			set
			{
				this.X0Y0_植性1_欠損_花弁_影_花弁影2.Dra = value;
				this.X0Y0_植性1_欠損_花弁_影_花弁影2.Hit = value;
			}
		}

		public bool 植性1_欠損_花弁_影_花弁影3_表示
		{
			get
			{
				return this.X0Y0_植性1_欠損_花弁_影_花弁影3.Dra;
			}
			set
			{
				this.X0Y0_植性1_欠損_花弁_影_花弁影3.Dra = value;
				this.X0Y0_植性1_欠損_花弁_影_花弁影3.Hit = value;
			}
		}

		public bool 植性1_欠損_花弁_影_花弁影4_表示
		{
			get
			{
				return this.X0Y0_植性1_欠損_花弁_影_花弁影4.Dra;
			}
			set
			{
				this.X0Y0_植性1_欠損_花弁_影_花弁影4.Dra = value;
				this.X0Y0_植性1_欠損_花弁_影_花弁影4.Hit = value;
			}
		}

		public bool 植性1_欠損_花弁_影_花弁影5_表示
		{
			get
			{
				return this.X0Y0_植性1_欠損_花弁_影_花弁影5.Dra;
			}
			set
			{
				this.X0Y0_植性1_欠損_花弁_影_花弁影5.Dra = value;
				this.X0Y0_植性1_欠損_花弁_影_花弁影5.Hit = value;
			}
		}

		public bool 獣性1_獣腕_表示
		{
			get
			{
				return this.X0Y0_獣性1_獣腕.Dra;
			}
			set
			{
				this.X0Y0_獣性1_獣腕.Dra = value;
				this.X0Y0_獣性1_獣腕.Hit = value;
			}
		}

		public bool 竜性1_肘_肘1_表示
		{
			get
			{
				return this.X0Y0_竜性1_肘_肘1.Dra;
			}
			set
			{
				this.X0Y0_竜性1_肘_肘1.Dra = value;
				this.X0Y0_竜性1_肘_肘1.Hit = value;
			}
		}

		public bool 竜性1_肘_肘2_表示
		{
			get
			{
				return this.X0Y0_竜性1_肘_肘2.Dra;
			}
			set
			{
				this.X0Y0_竜性1_肘_肘2.Dra = value;
				this.X0Y0_竜性1_肘_肘2.Hit = value;
			}
		}

		public bool 竜性1_鱗_鱗5_表示
		{
			get
			{
				return this.X0Y0_竜性1_鱗_鱗5.Dra;
			}
			set
			{
				this.X0Y0_竜性1_鱗_鱗5.Dra = value;
				this.X0Y0_竜性1_鱗_鱗5.Hit = value;
			}
		}

		public bool 竜性1_鱗_鱗4_表示
		{
			get
			{
				return this.X0Y0_竜性1_鱗_鱗4.Dra;
			}
			set
			{
				this.X0Y0_竜性1_鱗_鱗4.Dra = value;
				this.X0Y0_竜性1_鱗_鱗4.Hit = value;
			}
		}

		public bool 竜性1_鱗_鱗3_表示
		{
			get
			{
				return this.X0Y0_竜性1_鱗_鱗3.Dra;
			}
			set
			{
				this.X0Y0_竜性1_鱗_鱗3.Dra = value;
				this.X0Y0_竜性1_鱗_鱗3.Hit = value;
			}
		}

		public bool 竜性1_鱗_鱗2_表示
		{
			get
			{
				return this.X0Y0_竜性1_鱗_鱗2.Dra;
			}
			set
			{
				this.X0Y0_竜性1_鱗_鱗2.Dra = value;
				this.X0Y0_竜性1_鱗_鱗2.Hit = value;
			}
		}

		public bool 竜性1_鱗_鱗1_表示
		{
			get
			{
				return this.X0Y0_竜性1_鱗_鱗1.Dra;
			}
			set
			{
				this.X0Y0_竜性1_鱗_鱗1.Dra = value;
				this.X0Y0_竜性1_鱗_鱗1.Hit = value;
			}
		}

		public bool 竜性1_手首_鱗3_表示
		{
			get
			{
				return this.X0Y0_竜性1_手首_鱗3.Dra;
			}
			set
			{
				this.X0Y0_竜性1_手首_鱗3.Dra = value;
				this.X0Y0_竜性1_手首_鱗3.Hit = value;
			}
		}

		public bool 竜性1_手首_鱗2_表示
		{
			get
			{
				return this.X0Y0_竜性1_手首_鱗2.Dra;
			}
			set
			{
				this.X0Y0_竜性1_手首_鱗2.Dra = value;
				this.X0Y0_竜性1_手首_鱗2.Hit = value;
			}
		}

		public bool 竜性1_手首_鱗1_表示
		{
			get
			{
				return this.X0Y0_竜性1_手首_鱗1.Dra;
			}
			set
			{
				this.X0Y0_竜性1_手首_鱗1.Dra = value;
				this.X0Y0_竜性1_手首_鱗1.Hit = value;
			}
		}

		public bool 虫性1_虫肘_表示
		{
			get
			{
				return this.X0Y0_虫性1_虫肘.Dra;
			}
			set
			{
				this.X0Y0_虫性1_虫肘.Dra = value;
				this.X0Y0_虫性1_虫肘.Hit = value;
			}
		}

		public bool 虫性1_虫腕上_表示
		{
			get
			{
				return this.X0Y0_虫性1_虫腕上.Dra;
			}
			set
			{
				this.X0Y0_虫性1_虫腕上.Dra = value;
				this.X0Y0_虫性1_虫腕上.Hit = value;
			}
		}

		public bool 淫タトゥ_手首_タトゥ_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_手首_タトゥ.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_手首_タトゥ.Dra = value;
				this.X0Y0_淫タトゥ_手首_タトゥ.Hit = value;
			}
		}

		public bool 淫タトゥ_手首_ハ\u30FCト1_タトゥ左_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_手首_ハ\u30FCト1_タトゥ左.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_手首_ハ\u30FCト1_タトゥ左.Dra = value;
				this.X0Y0_淫タトゥ_手首_ハ\u30FCト1_タトゥ左.Hit = value;
			}
		}

		public bool 淫タトゥ_手首_ハ\u30FCト1_タトゥ右_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_手首_ハ\u30FCト1_タトゥ右.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_手首_ハ\u30FCト1_タトゥ右.Dra = value;
				this.X0Y0_淫タトゥ_手首_ハ\u30FCト1_タトゥ右.Hit = value;
			}
		}

		public bool 淫タトゥ_手首_ハ\u30FCト3_タトゥ左_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_手首_ハ\u30FCト3_タトゥ左.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_手首_ハ\u30FCト3_タトゥ左.Dra = value;
				this.X0Y0_淫タトゥ_手首_ハ\u30FCト3_タトゥ左.Hit = value;
			}
		}

		public bool 淫タトゥ_手首_ハ\u30FCト3_タトゥ右_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_手首_ハ\u30FCト3_タトゥ右.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_手首_ハ\u30FCト3_タトゥ右.Dra = value;
				this.X0Y0_淫タトゥ_手首_ハ\u30FCト3_タトゥ右.Hit = value;
			}
		}

		public bool 淫タトゥ_手首_ハ\u30FCト2_タトゥ左_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_手首_ハ\u30FCト2_タトゥ左.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_手首_ハ\u30FCト2_タトゥ左.Dra = value;
				this.X0Y0_淫タトゥ_手首_ハ\u30FCト2_タトゥ左.Hit = value;
			}
		}

		public bool 淫タトゥ_手首_ハ\u30FCト2_タトゥ右_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_手首_ハ\u30FCト2_タトゥ右.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_手首_ハ\u30FCト2_タトゥ右.Dra = value;
				this.X0Y0_淫タトゥ_手首_ハ\u30FCト2_タトゥ右.Hit = value;
			}
		}

		public bool 淫タトゥ_通常_ハ\u30FCト1_タトゥ左_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_通常_ハ\u30FCト1_タトゥ左.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_通常_ハ\u30FCト1_タトゥ左.Dra = value;
				this.X0Y0_淫タトゥ_通常_ハ\u30FCト1_タトゥ左.Hit = value;
			}
		}

		public bool 淫タトゥ_通常_ハ\u30FCト1_タトゥ右_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_通常_ハ\u30FCト1_タトゥ右.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_通常_ハ\u30FCト1_タトゥ右.Dra = value;
				this.X0Y0_淫タトゥ_通常_ハ\u30FCト1_タトゥ右.Hit = value;
			}
		}

		public bool 淫タトゥ_通常_ハ\u30FCト2_タトゥ左_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_通常_ハ\u30FCト2_タトゥ左.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_通常_ハ\u30FCト2_タトゥ左.Dra = value;
				this.X0Y0_淫タトゥ_通常_ハ\u30FCト2_タトゥ左.Hit = value;
			}
		}

		public bool 淫タトゥ_通常_ハ\u30FCト2_タトゥ右_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_通常_ハ\u30FCト2_タトゥ右.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_通常_ハ\u30FCト2_タトゥ右.Dra = value;
				this.X0Y0_淫タトゥ_通常_ハ\u30FCト2_タトゥ右.Hit = value;
			}
		}

		public bool 淫タトゥ_筋肉_ハ\u30FCト1_タトゥ左_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト1_タトゥ左.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト1_タトゥ左.Dra = value;
				this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト1_タトゥ左.Hit = value;
			}
		}

		public bool 淫タトゥ_筋肉_ハ\u30FCト1_タトゥ右_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト1_タトゥ右.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト1_タトゥ右.Dra = value;
				this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト1_タトゥ右.Hit = value;
			}
		}

		public bool 淫タトゥ_筋肉_ハ\u30FCト2_タトゥ左_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト2_タトゥ左.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト2_タトゥ左.Dra = value;
				this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト2_タトゥ左.Hit = value;
			}
		}

		public bool 淫タトゥ_筋肉_ハ\u30FCト2_タトゥ右_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト2_タトゥ右.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト2_タトゥ右.Dra = value;
				this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト2_タトゥ右.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字1_文字a_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字1_文字a_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字1_文字a_枠.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字1_文字a_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字1_文字a_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字1_文字a_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字1_文字b_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字1_文字b_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字1_文字b_枠.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字1_文字b_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字1_文字b_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字1_文字b_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字1_文字c_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字1_文字c_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字1_文字c_枠.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字1_文字c_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字1_文字c_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字1_文字c_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字1_文字d_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字1_文字d_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字1_文字d_枠.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字1_文字d_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字1_文字d_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字1_文字d_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字1_文字e_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字1_文字e_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字1_文字e_枠.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字1_文字e_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字1_文字e_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字1_文字e_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字1_文字e_文字タトゥ3_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ3.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ3.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ3.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字2_文字a_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字2_文字a_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字2_文字a_枠.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字2_文字a_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字2_文字a_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字2_文字a_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字2_文字b_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字2_文字b_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字2_文字b_枠.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字2_文字b_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字2_文字b_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字2_文字b_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字2_文字c_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字2_文字c_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字2_文字c_枠.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字2_文字c_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字2_文字c_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字2_文字c_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字2_文字d_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字2_文字d_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字2_文字d_枠.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字2_文字d_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字2_文字d_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字2_文字d_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字2_文字e_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字2_文字e_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字2_文字e_枠.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字2_文字e_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字2_文字e_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字2_文字e_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_文字2_文字e_文字タトゥ3_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ3.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ3.Dra = value;
				this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ3.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_通常_タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_通常_タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_逆十字_逆十字1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_逆十字_逆十字1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_逆十字_逆十字1.Dra = value;
				this.X0Y0_悪タトゥ_通常_逆十字_逆十字1.Hit = value;
			}
		}

		public bool 悪タトゥ_通常_逆十字_逆十字2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_通常_逆十字_逆十字2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_通常_逆十字_逆十字2.Dra = value;
				this.X0Y0_悪タトゥ_通常_逆十字_逆十字2.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字1_文字a_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字1_文字a_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字1_文字a_枠.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字1_文字a_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字1_文字a_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字1_文字a_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字1_文字b_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字1_文字b_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字1_文字b_枠.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字1_文字b_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字1_文字b_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字1_文字b_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字1_文字c_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字1_文字c_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字1_文字c_枠.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字1_文字c_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字1_文字c_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字1_文字c_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字1_文字d_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字1_文字d_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字1_文字d_枠.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字1_文字d_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字1_文字d_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字1_文字d_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字1_文字e_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字1_文字e_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字1_文字e_枠.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字1_文字e_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字1_文字e_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字1_文字e_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字1_文字e_文字タトゥ3_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ3.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ3.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ3.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字2_文字a_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字2_文字a_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字2_文字a_枠.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字2_文字a_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字2_文字a_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字2_文字a_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字2_文字b_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字2_文字b_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字2_文字b_枠.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字2_文字b_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字2_文字b_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字2_文字b_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字2_文字c_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字2_文字c_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字2_文字c_枠.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字2_文字c_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字2_文字c_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字2_文字c_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字2_文字d_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字2_文字d_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字2_文字d_枠.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字2_文字d_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字2_文字d_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字2_文字d_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字2_文字e_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字2_文字e_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字2_文字e_枠.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字2_文字e_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字2_文字e_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字2_文字e_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_文字2_文字e_文字タトゥ3_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ3.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ3.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ3.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_逆十字_逆十字1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_逆十字_逆十字1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_逆十字_逆十字1.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_逆十字_逆十字1.Hit = value;
			}
		}

		public bool 悪タトゥ_筋肉_逆十字_逆十字2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_筋肉_逆十字_逆十字2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_筋肉_逆十字_逆十字2.Dra = value;
				this.X0Y0_悪タトゥ_筋肉_逆十字_逆十字2.Hit = value;
			}
		}

		public bool 植性2_通常_萼_萼上_表示
		{
			get
			{
				return this.X0Y0_植性2_通常_萼_萼上.Dra;
			}
			set
			{
				this.X0Y0_植性2_通常_萼_萼上.Dra = value;
				this.X0Y0_植性2_通常_萼_萼上.Hit = value;
			}
		}

		public bool 植性2_通常_萼_萼下_表示
		{
			get
			{
				return this.X0Y0_植性2_通常_萼_萼下.Dra;
			}
			set
			{
				this.X0Y0_植性2_通常_萼_萼下.Dra = value;
				this.X0Y0_植性2_通常_萼_萼下.Hit = value;
			}
		}

		public bool 植性2_通常_萼_萼中_表示
		{
			get
			{
				return this.X0Y0_植性2_通常_萼_萼中.Dra;
			}
			set
			{
				this.X0Y0_植性2_通常_萼_萼中.Dra = value;
				this.X0Y0_植性2_通常_萼_萼中.Hit = value;
			}
		}

		public bool 植性2_欠損_萼_萼上_表示
		{
			get
			{
				return this.X0Y0_植性2_欠損_萼_萼上.Dra;
			}
			set
			{
				this.X0Y0_植性2_欠損_萼_萼上.Dra = value;
				this.X0Y0_植性2_欠損_萼_萼上.Hit = value;
			}
		}

		public bool 植性2_欠損_萼_萼下_表示
		{
			get
			{
				return this.X0Y0_植性2_欠損_萼_萼下.Dra;
			}
			set
			{
				this.X0Y0_植性2_欠損_萼_萼下.Dra = value;
				this.X0Y0_植性2_欠損_萼_萼下.Hit = value;
			}
		}

		public bool 植性2_欠損_萼_萼中_表示
		{
			get
			{
				return this.X0Y0_植性2_欠損_萼_萼中.Dra;
			}
			set
			{
				this.X0Y0_植性2_欠損_萼_萼中.Dra = value;
				this.X0Y0_植性2_欠損_萼_萼中.Hit = value;
			}
		}

		public bool 獣性2_獣毛_表示
		{
			get
			{
				return this.X0Y0_獣性2_獣毛.Dra;
			}
			set
			{
				this.X0Y0_獣性2_獣毛.Dra = value;
				this.X0Y0_獣性2_獣毛.Hit = value;
			}
		}

		public bool 竜性2_棘_棘5_表示
		{
			get
			{
				return this.X0Y0_竜性2_棘_棘5.Dra;
			}
			set
			{
				this.X0Y0_竜性2_棘_棘5.Dra = value;
				this.X0Y0_竜性2_棘_棘5.Hit = value;
			}
		}

		public bool 竜性2_棘_棘4_表示
		{
			get
			{
				return this.X0Y0_竜性2_棘_棘4.Dra;
			}
			set
			{
				this.X0Y0_竜性2_棘_棘4.Dra = value;
				this.X0Y0_竜性2_棘_棘4.Hit = value;
			}
		}

		public bool 竜性2_棘_棘3_表示
		{
			get
			{
				return this.X0Y0_竜性2_棘_棘3.Dra;
			}
			set
			{
				this.X0Y0_竜性2_棘_棘3.Dra = value;
				this.X0Y0_竜性2_棘_棘3.Hit = value;
			}
		}

		public bool 竜性2_棘_棘2_表示
		{
			get
			{
				return this.X0Y0_竜性2_棘_棘2.Dra;
			}
			set
			{
				this.X0Y0_竜性2_棘_棘2.Dra = value;
				this.X0Y0_竜性2_棘_棘2.Hit = value;
			}
		}

		public bool 竜性2_棘_棘1_表示
		{
			get
			{
				return this.X0Y0_竜性2_棘_棘1.Dra;
			}
			set
			{
				this.X0Y0_竜性2_棘_棘1.Dra = value;
				this.X0Y0_竜性2_棘_棘1.Hit = value;
			}
		}

		public bool 虫性2_虫腕下_表示
		{
			get
			{
				return this.X0Y0_虫性2_虫腕下.Dra;
			}
			set
			{
				this.X0Y0_虫性2_虫腕下.Dra = value;
				this.X0Y0_虫性2_虫腕下.Hit = value;
			}
		}

		public bool 虫性2_虫棘1_表示
		{
			get
			{
				return this.X0Y0_虫性2_虫棘1.Dra;
			}
			set
			{
				this.X0Y0_虫性2_虫棘1.Dra = value;
				this.X0Y0_虫性2_虫棘1.Hit = value;
			}
		}

		public bool 虫性2_虫棘2_表示
		{
			get
			{
				return this.X0Y0_虫性2_虫棘2.Dra;
			}
			set
			{
				this.X0Y0_虫性2_虫棘2.Dra = value;
				this.X0Y0_虫性2_虫棘2.Hit = value;
			}
		}

		public bool 虫性2_虫棘3_表示
		{
			get
			{
				return this.X0Y0_虫性2_虫棘3.Dra;
			}
			set
			{
				this.X0Y0_虫性2_虫棘3.Dra = value;
				this.X0Y0_虫性2_虫棘3.Hit = value;
			}
		}

		public bool 虫性2_虫棘4_表示
		{
			get
			{
				return this.X0Y0_虫性2_虫棘4.Dra;
			}
			set
			{
				this.X0Y0_虫性2_虫棘4.Dra = value;
				this.X0Y0_虫性2_虫棘4.Hit = value;
			}
		}

		public bool 虫性2_虫鎌節_表示
		{
			get
			{
				return this.X0Y0_虫性2_虫鎌節.Dra;
			}
			set
			{
				this.X0Y0_虫性2_虫鎌節.Dra = value;
				this.X0Y0_虫性2_虫鎌節.Hit = value;
			}
		}

		public bool 傷X1_表示
		{
			get
			{
				return this.X0Y0_傷X1.Dra;
			}
			set
			{
				this.X0Y0_傷X1.Dra = value;
				this.X0Y0_傷X1.Hit = value;
			}
		}

		public bool 傷I1_表示
		{
			get
			{
				return this.X0Y0_傷I1.Dra;
			}
			set
			{
				this.X0Y0_傷I1.Dra = value;
				this.X0Y0_傷I1.Hit = value;
			}
		}

		public bool 傷I2_表示
		{
			get
			{
				return this.X0Y0_傷I2.Dra;
			}
			set
			{
				this.X0Y0_傷I2.Dra = value;
				this.X0Y0_傷I2.Hit = value;
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
				this.X0Y0_ハイライト.Hit = value;
			}
		}

		public bool グロ\u30FCブ_通常_グロ\u30FCブ_表示
		{
			get
			{
				return this.X0Y0_グロ\u30FCブ_通常_グロ\u30FCブ.Dra;
			}
			set
			{
				this.X0Y0_グロ\u30FCブ_通常_グロ\u30FCブ.Dra = value;
				this.X0Y0_グロ\u30FCブ_通常_グロ\u30FCブ.Hit = value;
			}
		}

		public bool グロ\u30FCブ_通常_縁_表示
		{
			get
			{
				return this.X0Y0_グロ\u30FCブ_通常_縁.Dra;
			}
			set
			{
				this.X0Y0_グロ\u30FCブ_通常_縁.Dra = value;
				this.X0Y0_グロ\u30FCブ_通常_縁.Hit = value;
			}
		}

		public bool グロ\u30FCブ_筋肉_グロ\u30FCブ_表示
		{
			get
			{
				return this.X0Y0_グロ\u30FCブ_筋肉_グロ\u30FCブ.Dra;
			}
			set
			{
				this.X0Y0_グロ\u30FCブ_筋肉_グロ\u30FCブ.Dra = value;
				this.X0Y0_グロ\u30FCブ_筋肉_グロ\u30FCブ.Hit = value;
			}
		}

		public bool グロ\u30FCブ_筋肉_縁_表示
		{
			get
			{
				return this.X0Y0_グロ\u30FCブ_筋肉_縁.Dra;
			}
			set
			{
				this.X0Y0_グロ\u30FCブ_筋肉_縁.Dra = value;
				this.X0Y0_グロ\u30FCブ_筋肉_縁.Hit = value;
			}
		}

		public bool 鎧_ベルト_ベルト1_表示
		{
			get
			{
				return this.X0Y0_鎧_ベルト_ベルト1.Dra;
			}
			set
			{
				this.X0Y0_鎧_ベルト_ベルト1.Dra = value;
				this.X0Y0_鎧_ベルト_ベルト1.Hit = value;
			}
		}

		public bool 鎧_ベルト_通常_ベルト2_表示
		{
			get
			{
				return this.X0Y0_鎧_ベルト_通常_ベルト2.Dra;
			}
			set
			{
				this.X0Y0_鎧_ベルト_通常_ベルト2.Dra = value;
				this.X0Y0_鎧_ベルト_通常_ベルト2.Hit = value;
			}
		}

		public bool 鎧_ベルト_筋肉_ベルト2_表示
		{
			get
			{
				return this.X0Y0_鎧_ベルト_筋肉_ベルト2.Dra;
			}
			set
			{
				this.X0Y0_鎧_ベルト_筋肉_ベルト2.Dra = value;
				this.X0Y0_鎧_ベルト_筋肉_ベルト2.Hit = value;
			}
		}

		public bool 鎧_鎧_鎧2_表示
		{
			get
			{
				return this.X0Y0_鎧_鎧_鎧2.Dra;
			}
			set
			{
				this.X0Y0_鎧_鎧_鎧2.Dra = value;
				this.X0Y0_鎧_鎧_鎧2.Hit = value;
			}
		}

		public bool 鎧_鎧_鎧1_表示
		{
			get
			{
				return this.X0Y0_鎧_鎧_鎧1.Dra;
			}
			set
			{
				this.X0Y0_鎧_鎧_鎧1.Dra = value;
				this.X0Y0_鎧_鎧_鎧1.Hit = value;
			}
		}

		public bool 腕輪_革_表示
		{
			get
			{
				return this.X0Y0_腕輪_革.Dra;
			}
			set
			{
				this.X0Y0_腕輪_革.Dra = value;
				this.X0Y0_腕輪_革.Hit = value;
			}
		}

		public bool 腕輪_金具1_表示
		{
			get
			{
				return this.X0Y0_腕輪_金具1.Dra;
			}
			set
			{
				this.X0Y0_腕輪_金具1.Dra = value;
				this.X0Y0_腕輪_金具1.Hit = value;
			}
		}

		public bool 腕輪_金具2_表示
		{
			get
			{
				return this.X0Y0_腕輪_金具2.Dra;
			}
			set
			{
				this.X0Y0_腕輪_金具2.Dra = value;
				this.X0Y0_腕輪_金具2.Hit = value;
			}
		}

		public bool 腕輪_金具3_表示
		{
			get
			{
				return this.X0Y0_腕輪_金具3.Dra;
			}
			set
			{
				this.X0Y0_腕輪_金具3.Dra = value;
				this.X0Y0_腕輪_金具3.Hit = value;
			}
		}

		public bool 腕輪_金具左_表示
		{
			get
			{
				return this.X0Y0_腕輪_金具左.Dra;
			}
			set
			{
				this.X0Y0_腕輪_金具左.Dra = value;
				this.X0Y0_腕輪_金具左.Hit = value;
			}
		}

		public bool 腕輪_金具右_表示
		{
			get
			{
				return this.X0Y0_腕輪_金具右.Dra;
			}
			set
			{
				this.X0Y0_腕輪_金具右.Dra = value;
				this.X0Y0_腕輪_金具右.Hit = value;
			}
		}

		public bool 植性1_花弁_花弁_表示
		{
			get
			{
				return this.植性1_通常_花弁_花弁_表示 || this.植性1_欠損_花弁_花弁_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.植性1_通常_花弁_花弁_表示 = false;
					this.植性1_欠損_花弁_花弁_表示 = value;
					return;
				}
				this.植性1_通常_花弁_花弁_表示 = value;
				this.植性1_欠損_花弁_花弁_表示 = false;
			}
		}

		public bool 植性1_花弁_影_花弁影1_表示
		{
			get
			{
				return this.植性1_通常_花弁_影_花弁影1_表示 || this.植性1_欠損_花弁_影_花弁影1_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.植性1_通常_花弁_影_花弁影1_表示 = false;
					this.植性1_欠損_花弁_影_花弁影1_表示 = value;
					return;
				}
				this.植性1_通常_花弁_影_花弁影1_表示 = value;
				this.植性1_欠損_花弁_影_花弁影1_表示 = false;
			}
		}

		public bool 植性1_花弁_影_花弁影2_表示
		{
			get
			{
				return this.植性1_通常_花弁_影_花弁影2_表示 || this.植性1_欠損_花弁_影_花弁影2_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.植性1_通常_花弁_影_花弁影2_表示 = false;
					this.植性1_欠損_花弁_影_花弁影2_表示 = value;
					return;
				}
				this.植性1_通常_花弁_影_花弁影2_表示 = value;
				this.植性1_欠損_花弁_影_花弁影2_表示 = false;
			}
		}

		public bool 植性1_花弁_影_花弁影3_表示
		{
			get
			{
				return this.植性1_通常_花弁_影_花弁影3_表示 || this.植性1_欠損_花弁_影_花弁影3_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.植性1_通常_花弁_影_花弁影3_表示 = false;
					this.植性1_欠損_花弁_影_花弁影3_表示 = value;
					return;
				}
				this.植性1_通常_花弁_影_花弁影3_表示 = value;
				this.植性1_欠損_花弁_影_花弁影3_表示 = false;
			}
		}

		public bool 植性1_花弁_影_花弁影4_表示
		{
			get
			{
				return this.植性1_通常_花弁_影_花弁影4_表示 || this.植性1_欠損_花弁_影_花弁影4_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.植性1_通常_花弁_影_花弁影4_表示 = false;
					this.植性1_欠損_花弁_影_花弁影4_表示 = value;
					return;
				}
				this.植性1_通常_花弁_影_花弁影4_表示 = value;
				this.植性1_欠損_花弁_影_花弁影4_表示 = false;
			}
		}

		public bool 植性1_花弁_影_花弁影5_表示
		{
			get
			{
				return this.植性1_通常_花弁_影_花弁影5_表示 || this.植性1_欠損_花弁_影_花弁影5_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.植性1_通常_花弁_影_花弁影5_表示 = false;
					this.植性1_欠損_花弁_影_花弁影5_表示 = value;
					return;
				}
				this.植性1_通常_花弁_影_花弁影5_表示 = value;
				this.植性1_欠損_花弁_影_花弁影5_表示 = false;
			}
		}

		public bool 淫タトゥ_ハ\u30FCト1_タトゥ左_表示
		{
			get
			{
				return this.淫タトゥ_通常_ハ\u30FCト1_タトゥ左_表示 || this.淫タトゥ_筋肉_ハ\u30FCト1_タトゥ左_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.淫タトゥ_通常_ハ\u30FCト1_タトゥ左_表示 = false;
					this.淫タトゥ_筋肉_ハ\u30FCト1_タトゥ左_表示 = value;
					return;
				}
				this.淫タトゥ_通常_ハ\u30FCト1_タトゥ左_表示 = value;
				this.淫タトゥ_筋肉_ハ\u30FCト1_タトゥ左_表示 = false;
			}
		}

		public bool 淫タトゥ_ハ\u30FCト1_タトゥ右_表示
		{
			get
			{
				return this.淫タトゥ_通常_ハ\u30FCト1_タトゥ右_表示 || this.淫タトゥ_筋肉_ハ\u30FCト1_タトゥ右_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.淫タトゥ_通常_ハ\u30FCト1_タトゥ右_表示 = false;
					this.淫タトゥ_筋肉_ハ\u30FCト1_タトゥ右_表示 = value;
					return;
				}
				this.淫タトゥ_通常_ハ\u30FCト1_タトゥ右_表示 = value;
				this.淫タトゥ_筋肉_ハ\u30FCト1_タトゥ右_表示 = false;
			}
		}

		public bool 淫タトゥ_ハ\u30FCト2_タトゥ左_表示
		{
			get
			{
				return this.淫タトゥ_通常_ハ\u30FCト2_タトゥ左_表示 || this.淫タトゥ_筋肉_ハ\u30FCト2_タトゥ左_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.淫タトゥ_通常_ハ\u30FCト2_タトゥ左_表示 = false;
					this.淫タトゥ_筋肉_ハ\u30FCト2_タトゥ左_表示 = value;
					return;
				}
				this.淫タトゥ_通常_ハ\u30FCト2_タトゥ左_表示 = value;
				this.淫タトゥ_筋肉_ハ\u30FCト2_タトゥ左_表示 = false;
			}
		}

		public bool 淫タトゥ_ハ\u30FCト2_タトゥ右_表示
		{
			get
			{
				return this.淫タトゥ_通常_ハ\u30FCト2_タトゥ右_表示 || this.淫タトゥ_筋肉_ハ\u30FCト2_タトゥ右_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.淫タトゥ_通常_ハ\u30FCト2_タトゥ右_表示 = false;
					this.淫タトゥ_筋肉_ハ\u30FCト2_タトゥ右_表示 = value;
					return;
				}
				this.淫タトゥ_通常_ハ\u30FCト2_タトゥ右_表示 = value;
				this.淫タトゥ_筋肉_ハ\u30FCト2_タトゥ右_表示 = false;
			}
		}

		public bool 悪タトゥ_文字1_文字a_枠_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字1_文字a_枠_表示 || this.悪タトゥ_筋肉_文字1_文字a_枠_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字1_文字a_枠_表示 = false;
					this.悪タトゥ_筋肉_文字1_文字a_枠_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字1_文字a_枠_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字a_枠_表示 = false;
			}
		}

		public bool 悪タトゥ_文字1_文字a_文字タトゥ1_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字1_文字a_文字タトゥ1_表示 || this.悪タトゥ_筋肉_文字1_文字a_文字タトゥ1_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字1_文字a_文字タトゥ1_表示 = false;
					this.悪タトゥ_筋肉_文字1_文字a_文字タトゥ1_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字1_文字a_文字タトゥ1_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字a_文字タトゥ1_表示 = false;
			}
		}

		public bool 悪タトゥ_文字1_文字a_文字タトゥ2_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字1_文字a_文字タトゥ2_表示 || this.悪タトゥ_筋肉_文字1_文字a_文字タトゥ2_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字1_文字a_文字タトゥ2_表示 = false;
					this.悪タトゥ_筋肉_文字1_文字a_文字タトゥ2_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字1_文字a_文字タトゥ2_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字a_文字タトゥ2_表示 = false;
			}
		}

		public bool 悪タトゥ_文字1_文字b_枠_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字1_文字b_枠_表示 || this.悪タトゥ_筋肉_文字1_文字b_枠_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字1_文字b_枠_表示 = false;
					this.悪タトゥ_筋肉_文字1_文字b_枠_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字1_文字b_枠_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字b_枠_表示 = false;
			}
		}

		public bool 悪タトゥ_文字1_文字b_文字タトゥ1_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字1_文字b_文字タトゥ1_表示 || this.悪タトゥ_筋肉_文字1_文字b_文字タトゥ1_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字1_文字b_文字タトゥ1_表示 = false;
					this.悪タトゥ_筋肉_文字1_文字b_文字タトゥ1_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字1_文字b_文字タトゥ1_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字b_文字タトゥ1_表示 = false;
			}
		}

		public bool 悪タトゥ_文字1_文字b_文字タトゥ2_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字1_文字b_文字タトゥ2_表示 || this.悪タトゥ_筋肉_文字1_文字b_文字タトゥ2_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字1_文字b_文字タトゥ2_表示 = false;
					this.悪タトゥ_筋肉_文字1_文字b_文字タトゥ2_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字1_文字b_文字タトゥ2_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字b_文字タトゥ2_表示 = false;
			}
		}

		public bool 悪タトゥ_文字1_文字c_枠_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字1_文字c_枠_表示 || this.悪タトゥ_筋肉_文字1_文字c_枠_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字1_文字c_枠_表示 = false;
					this.悪タトゥ_筋肉_文字1_文字c_枠_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字1_文字c_枠_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字c_枠_表示 = false;
			}
		}

		public bool 悪タトゥ_文字1_文字c_文字タトゥ1_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字1_文字c_文字タトゥ1_表示 || this.悪タトゥ_筋肉_文字1_文字c_文字タトゥ1_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字1_文字c_文字タトゥ1_表示 = false;
					this.悪タトゥ_筋肉_文字1_文字c_文字タトゥ1_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字1_文字c_文字タトゥ1_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字c_文字タトゥ1_表示 = false;
			}
		}

		public bool 悪タトゥ_文字1_文字c_文字タトゥ2_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字1_文字c_文字タトゥ2_表示 || this.悪タトゥ_筋肉_文字1_文字c_文字タトゥ2_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字1_文字c_文字タトゥ2_表示 = false;
					this.悪タトゥ_筋肉_文字1_文字c_文字タトゥ2_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字1_文字c_文字タトゥ2_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字c_文字タトゥ2_表示 = false;
			}
		}

		public bool 悪タトゥ_文字1_文字d_枠_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字1_文字d_枠_表示 || this.悪タトゥ_筋肉_文字1_文字d_枠_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字1_文字d_枠_表示 = false;
					this.悪タトゥ_筋肉_文字1_文字d_枠_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字1_文字d_枠_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字d_枠_表示 = false;
			}
		}

		public bool 悪タトゥ_文字1_文字d_文字タトゥ1_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字1_文字d_文字タトゥ1_表示 || this.悪タトゥ_筋肉_文字1_文字d_文字タトゥ1_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字1_文字d_文字タトゥ1_表示 = false;
					this.悪タトゥ_筋肉_文字1_文字d_文字タトゥ1_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字1_文字d_文字タトゥ1_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字d_文字タトゥ1_表示 = false;
			}
		}

		public bool 悪タトゥ_文字1_文字d_文字タトゥ2_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字1_文字d_文字タトゥ2_表示 || this.悪タトゥ_筋肉_文字1_文字d_文字タトゥ2_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字1_文字d_文字タトゥ2_表示 = false;
					this.悪タトゥ_筋肉_文字1_文字d_文字タトゥ2_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字1_文字d_文字タトゥ2_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字d_文字タトゥ2_表示 = false;
			}
		}

		public bool 悪タトゥ_文字1_文字e_枠_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字1_文字e_枠_表示 || this.悪タトゥ_筋肉_文字1_文字e_枠_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字1_文字e_枠_表示 = false;
					this.悪タトゥ_筋肉_文字1_文字e_枠_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字1_文字e_枠_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字e_枠_表示 = false;
			}
		}

		public bool 悪タトゥ_文字1_文字e_文字タトゥ1_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字1_文字e_文字タトゥ1_表示 || this.悪タトゥ_筋肉_文字1_文字e_文字タトゥ1_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字1_文字e_文字タトゥ1_表示 = false;
					this.悪タトゥ_筋肉_文字1_文字e_文字タトゥ1_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字1_文字e_文字タトゥ1_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字e_文字タトゥ1_表示 = false;
			}
		}

		public bool 悪タトゥ_文字1_文字e_文字タトゥ2_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字1_文字e_文字タトゥ2_表示 || this.悪タトゥ_筋肉_文字1_文字e_文字タトゥ2_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字1_文字e_文字タトゥ2_表示 = false;
					this.悪タトゥ_筋肉_文字1_文字e_文字タトゥ2_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字1_文字e_文字タトゥ2_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字e_文字タトゥ2_表示 = false;
			}
		}

		public bool 悪タトゥ_文字1_文字e_文字タトゥ3_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字1_文字e_文字タトゥ3_表示 || this.悪タトゥ_筋肉_文字1_文字e_文字タトゥ3_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字1_文字e_文字タトゥ3_表示 = false;
					this.悪タトゥ_筋肉_文字1_文字e_文字タトゥ3_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字1_文字e_文字タトゥ3_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字e_文字タトゥ3_表示 = false;
			}
		}

		public bool 悪タトゥ_文字2_文字a_枠_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字2_文字a_枠_表示 || this.悪タトゥ_筋肉_文字2_文字a_枠_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字2_文字a_枠_表示 = false;
					this.悪タトゥ_筋肉_文字2_文字a_枠_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字2_文字a_枠_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字a_枠_表示 = false;
			}
		}

		public bool 悪タトゥ_文字2_文字a_文字タトゥ1_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字2_文字a_文字タトゥ1_表示 || this.悪タトゥ_筋肉_文字2_文字a_文字タトゥ1_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字2_文字a_文字タトゥ1_表示 = false;
					this.悪タトゥ_筋肉_文字2_文字a_文字タトゥ1_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字2_文字a_文字タトゥ1_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字a_文字タトゥ1_表示 = false;
			}
		}

		public bool 悪タトゥ_文字2_文字a_文字タトゥ2_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字2_文字a_文字タトゥ2_表示 || this.悪タトゥ_筋肉_文字2_文字a_文字タトゥ2_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字2_文字a_文字タトゥ2_表示 = false;
					this.悪タトゥ_筋肉_文字2_文字a_文字タトゥ2_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字2_文字a_文字タトゥ2_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字a_文字タトゥ2_表示 = false;
			}
		}

		public bool 悪タトゥ_文字2_文字b_枠_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字2_文字b_枠_表示 || this.悪タトゥ_筋肉_文字2_文字b_枠_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字2_文字b_枠_表示 = false;
					this.悪タトゥ_筋肉_文字2_文字b_枠_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字2_文字b_枠_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字b_枠_表示 = false;
			}
		}

		public bool 悪タトゥ_文字2_文字b_文字タトゥ1_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字2_文字b_文字タトゥ1_表示 || this.悪タトゥ_筋肉_文字2_文字b_文字タトゥ1_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字2_文字b_文字タトゥ1_表示 = false;
					this.悪タトゥ_筋肉_文字2_文字b_文字タトゥ1_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字2_文字b_文字タトゥ1_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字b_文字タトゥ1_表示 = false;
			}
		}

		public bool 悪タトゥ_文字2_文字b_文字タトゥ2_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字2_文字b_文字タトゥ2_表示 || this.悪タトゥ_筋肉_文字2_文字b_文字タトゥ2_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字2_文字b_文字タトゥ2_表示 = false;
					this.悪タトゥ_筋肉_文字2_文字b_文字タトゥ2_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字2_文字b_文字タトゥ2_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字b_文字タトゥ2_表示 = false;
			}
		}

		public bool 悪タトゥ_文字2_文字c_枠_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字2_文字c_枠_表示 || this.悪タトゥ_筋肉_文字2_文字c_枠_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字2_文字c_枠_表示 = false;
					this.悪タトゥ_筋肉_文字2_文字c_枠_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字2_文字c_枠_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字c_枠_表示 = false;
			}
		}

		public bool 悪タトゥ_文字2_文字c_文字タトゥ1_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字2_文字c_文字タトゥ1_表示 || this.悪タトゥ_筋肉_文字2_文字c_文字タトゥ1_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字2_文字c_文字タトゥ1_表示 = false;
					this.悪タトゥ_筋肉_文字2_文字c_文字タトゥ1_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字2_文字c_文字タトゥ1_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字c_文字タトゥ1_表示 = false;
			}
		}

		public bool 悪タトゥ_文字2_文字c_文字タトゥ2_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字2_文字c_文字タトゥ2_表示 || this.悪タトゥ_筋肉_文字2_文字c_文字タトゥ2_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字2_文字c_文字タトゥ2_表示 = false;
					this.悪タトゥ_筋肉_文字2_文字c_文字タトゥ2_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字2_文字c_文字タトゥ2_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字c_文字タトゥ2_表示 = false;
			}
		}

		public bool 悪タトゥ_文字2_文字d_枠_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字2_文字d_枠_表示 || this.悪タトゥ_筋肉_文字2_文字d_枠_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字2_文字d_枠_表示 = false;
					this.悪タトゥ_筋肉_文字2_文字d_枠_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字2_文字d_枠_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字d_枠_表示 = false;
			}
		}

		public bool 悪タトゥ_文字2_文字d_文字タトゥ1_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字2_文字d_文字タトゥ1_表示 || this.悪タトゥ_筋肉_文字2_文字d_文字タトゥ1_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字2_文字d_文字タトゥ1_表示 = false;
					this.悪タトゥ_筋肉_文字2_文字d_文字タトゥ1_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字2_文字d_文字タトゥ1_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字d_文字タトゥ1_表示 = false;
			}
		}

		public bool 悪タトゥ_文字2_文字d_文字タトゥ2_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字2_文字d_文字タトゥ2_表示 || this.悪タトゥ_筋肉_文字2_文字d_文字タトゥ2_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字2_文字d_文字タトゥ2_表示 = false;
					this.悪タトゥ_筋肉_文字2_文字d_文字タトゥ2_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字2_文字d_文字タトゥ2_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字d_文字タトゥ2_表示 = false;
			}
		}

		public bool 悪タトゥ_文字2_文字e_枠_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字2_文字e_枠_表示 || this.悪タトゥ_筋肉_文字2_文字e_枠_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字2_文字e_枠_表示 = false;
					this.悪タトゥ_筋肉_文字2_文字e_枠_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字2_文字e_枠_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字e_枠_表示 = false;
			}
		}

		public bool 悪タトゥ_文字2_文字e_文字タトゥ1_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字2_文字e_文字タトゥ1_表示 || this.悪タトゥ_筋肉_文字2_文字e_文字タトゥ1_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字2_文字e_文字タトゥ1_表示 = false;
					this.悪タトゥ_筋肉_文字2_文字e_文字タトゥ1_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字2_文字e_文字タトゥ1_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字e_文字タトゥ1_表示 = false;
			}
		}

		public bool 悪タトゥ_文字2_文字e_文字タトゥ2_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字2_文字e_文字タトゥ2_表示 || this.悪タトゥ_筋肉_文字2_文字e_文字タトゥ2_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字2_文字e_文字タトゥ2_表示 = false;
					this.悪タトゥ_筋肉_文字2_文字e_文字タトゥ2_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字2_文字e_文字タトゥ2_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字e_文字タトゥ2_表示 = false;
			}
		}

		public bool 悪タトゥ_文字2_文字e_文字タトゥ3_表示
		{
			get
			{
				return this.悪タトゥ_通常_文字2_文字e_文字タトゥ3_表示 || this.悪タトゥ_筋肉_文字2_文字e_文字タトゥ3_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_文字2_文字e_文字タトゥ3_表示 = false;
					this.悪タトゥ_筋肉_文字2_文字e_文字タトゥ3_表示 = value;
					return;
				}
				this.悪タトゥ_通常_文字2_文字e_文字タトゥ3_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字e_文字タトゥ3_表示 = false;
			}
		}

		public bool 悪タトゥ_タトゥ1_表示
		{
			get
			{
				return this.悪タトゥ_通常_タトゥ1_表示 || this.悪タトゥ_筋肉_タトゥ1_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_タトゥ1_表示 = false;
					this.悪タトゥ_筋肉_タトゥ1_表示 = value;
					return;
				}
				this.悪タトゥ_通常_タトゥ1_表示 = value;
				this.悪タトゥ_筋肉_タトゥ1_表示 = false;
			}
		}

		public bool 悪タトゥ_タトゥ2_表示
		{
			get
			{
				return this.悪タトゥ_通常_タトゥ2_表示 || this.悪タトゥ_筋肉_タトゥ2_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_タトゥ2_表示 = false;
					this.悪タトゥ_筋肉_タトゥ2_表示 = value;
					return;
				}
				this.悪タトゥ_通常_タトゥ2_表示 = value;
				this.悪タトゥ_筋肉_タトゥ2_表示 = false;
			}
		}

		public bool 悪タトゥ_逆十字_逆十字1_表示
		{
			get
			{
				return this.悪タトゥ_通常_逆十字_逆十字1_表示 || this.悪タトゥ_筋肉_逆十字_逆十字1_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_逆十字_逆十字1_表示 = false;
					this.悪タトゥ_筋肉_逆十字_逆十字1_表示 = value;
					return;
				}
				this.悪タトゥ_通常_逆十字_逆十字1_表示 = value;
				this.悪タトゥ_筋肉_逆十字_逆十字1_表示 = false;
			}
		}

		public bool 悪タトゥ_逆十字_逆十字2_表示
		{
			get
			{
				return this.悪タトゥ_通常_逆十字_逆十字2_表示 || this.悪タトゥ_筋肉_逆十字_逆十字2_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.悪タトゥ_通常_逆十字_逆十字2_表示 = false;
					this.悪タトゥ_筋肉_逆十字_逆十字2_表示 = value;
					return;
				}
				this.悪タトゥ_通常_逆十字_逆十字2_表示 = value;
				this.悪タトゥ_筋肉_逆十字_逆十字2_表示 = false;
			}
		}

		public bool 植性2_萼_萼上_表示
		{
			get
			{
				return this.植性2_通常_萼_萼上_表示 || this.植性2_欠損_萼_萼上_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.植性2_通常_萼_萼上_表示 = false;
					this.植性2_欠損_萼_萼上_表示 = value;
					return;
				}
				this.植性2_通常_萼_萼上_表示 = value;
				this.植性2_欠損_萼_萼上_表示 = false;
			}
		}

		public bool 植性2_萼_萼下_表示
		{
			get
			{
				return this.植性2_通常_萼_萼下_表示 || this.植性2_欠損_萼_萼下_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.植性2_通常_萼_萼下_表示 = false;
					this.植性2_欠損_萼_萼下_表示 = value;
					return;
				}
				this.植性2_通常_萼_萼下_表示 = value;
				this.植性2_欠損_萼_萼下_表示 = false;
			}
		}

		public bool 植性2_萼_萼中_表示
		{
			get
			{
				return this.植性2_通常_萼_萼中_表示 || this.植性2_欠損_萼_萼中_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.植性2_通常_萼_萼中_表示 = false;
					this.植性2_欠損_萼_萼中_表示 = value;
					return;
				}
				this.植性2_通常_萼_萼中_表示 = value;
				this.植性2_欠損_萼_萼中_表示 = false;
			}
		}

		public bool グロ\u30FCブ_グロ\u30FCブ_表示
		{
			get
			{
				return this.グロ\u30FCブ_通常_グロ\u30FCブ_表示 || this.グロ\u30FCブ_筋肉_グロ\u30FCブ_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.グロ\u30FCブ_通常_グロ\u30FCブ_表示 = false;
					this.グロ\u30FCブ_筋肉_グロ\u30FCブ_表示 = value;
					return;
				}
				this.グロ\u30FCブ_通常_グロ\u30FCブ_表示 = value;
				this.グロ\u30FCブ_筋肉_グロ\u30FCブ_表示 = false;
			}
		}

		public bool グロ\u30FCブ_縁_表示
		{
			get
			{
				return this.グロ\u30FCブ_通常_縁_表示 || this.グロ\u30FCブ_筋肉_縁_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.グロ\u30FCブ_通常_縁_表示 = false;
					this.グロ\u30FCブ_筋肉_縁_表示 = value;
					return;
				}
				this.グロ\u30FCブ_通常_縁_表示 = value;
				this.グロ\u30FCブ_筋肉_縁_表示 = false;
			}
		}

		public bool 鎧_ベルト_ベルト2_表示
		{
			get
			{
				return this.鎧_ベルト_通常_ベルト2_表示 || this.鎧_ベルト_筋肉_ベルト2_表示;
			}
			set
			{
				if (this.筋肉フラグ)
				{
					this.鎧_ベルト_通常_ベルト2_表示 = false;
					this.鎧_ベルト_筋肉_ベルト2_表示 = value;
					return;
				}
				this.鎧_ベルト_通常_ベルト2_表示 = value;
				this.鎧_ベルト_筋肉_ベルト2_表示 = false;
			}
		}

		private bool 筋肉フラグ
		{
			get
			{
				return this.筋肉_ || this.筋肉_筋肉下_表示 || this.筋肉_筋肉上_表示 || this.竜性1_肘_肘1_表示 || this.竜性1_肘_肘2_表示 || this.竜性1_鱗_鱗5_表示 || this.竜性1_鱗_鱗4_表示 || this.竜性1_鱗_鱗3_表示 || this.竜性1_鱗_鱗2_表示 || this.竜性1_鱗_鱗1_表示 || this.竜性2_棘_棘5_表示 || this.竜性2_棘_棘4_表示 || this.竜性2_棘_棘3_表示 || this.竜性2_棘_棘2_表示 || this.竜性2_棘_棘1_表示 || this.竜性1_手首_鱗3_表示 || this.竜性1_手首_鱗2_表示 || this.竜性1_手首_鱗1_表示 || this.虫性1_虫肘_表示 || this.虫性2_虫腕下_表示 || this.虫性1_虫腕上_表示 || this.虫性2_虫棘1_表示 || this.虫性2_虫棘2_表示 || this.虫性2_虫棘3_表示 || this.虫性2_虫棘4_表示 || this.虫性2_虫鎌節_表示;
			}
		}

		public bool ハイライト表示
		{
			get
			{
				return this.ハイライト_表示;
			}
			set
			{
				this.ハイライト_表示 = value;
			}
		}

		public double 傷X1濃度
		{
			get
			{
				return this.傷X1CD.不透明度;
			}
			set
			{
				this.傷X1CD.不透明度 = value;
			}
		}

		public double 傷I1濃度
		{
			get
			{
				return this.傷I1CD.不透明度;
			}
			set
			{
				this.傷I1CD.不透明度 = value;
			}
		}

		public double 傷I2濃度
		{
			get
			{
				return this.傷I2CD.不透明度;
			}
			set
			{
				this.傷I2CD.不透明度 = value;
			}
		}

		public double ハイライト濃度
		{
			get
			{
				return this.ハイライトCD.不透明度;
			}
			set
			{
				this.ハイライトCD.不透明度 = value;
			}
		}

		public bool 腕輪表示
		{
			get
			{
				return this.腕輪_革_表示;
			}
			set
			{
				this.腕輪_革_表示 = value;
				this.腕輪_金具1_表示 = value;
				this.腕輪_金具2_表示 = value;
				this.腕輪_金具3_表示 = value;
				this.腕輪_金具左_表示 = value;
				this.腕輪_金具右_表示 = value;
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
			}
		}

		public override void Dispose()
		{
			base.Dispose();
			this.鎖1.Dispose();
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
				this.植性1_通常_花弁_花弁_表示 = value;
				this.植性1_通常_花弁_影_花弁影1_表示 = value;
				this.植性1_通常_花弁_影_花弁影2_表示 = value;
				this.植性1_通常_花弁_影_花弁影3_表示 = value;
				this.植性1_通常_花弁_影_花弁影4_表示 = value;
				this.植性1_通常_花弁_影_花弁影5_表示 = value;
				this.植性1_欠損_花弁_花弁_表示 = value;
				this.植性1_欠損_花弁_影_花弁影1_表示 = value;
				this.植性1_欠損_花弁_影_花弁影2_表示 = value;
				this.植性1_欠損_花弁_影_花弁影3_表示 = value;
				this.植性1_欠損_花弁_影_花弁影4_表示 = value;
				this.植性1_欠損_花弁_影_花弁影5_表示 = value;
				this.獣性1_獣腕_表示 = value;
				this.竜性1_肘_肘1_表示 = value;
				this.竜性1_肘_肘2_表示 = value;
				this.竜性1_鱗_鱗5_表示 = value;
				this.竜性1_鱗_鱗4_表示 = value;
				this.竜性1_鱗_鱗3_表示 = value;
				this.竜性1_鱗_鱗2_表示 = value;
				this.竜性1_鱗_鱗1_表示 = value;
				this.竜性1_手首_鱗3_表示 = value;
				this.竜性1_手首_鱗2_表示 = value;
				this.竜性1_手首_鱗1_表示 = value;
				this.虫性1_虫肘_表示 = value;
				this.虫性1_虫腕上_表示 = value;
				this.淫タトゥ_手首_タトゥ_表示 = value;
				this.淫タトゥ_手首_ハ\u30FCト1_タトゥ左_表示 = value;
				this.淫タトゥ_手首_ハ\u30FCト1_タトゥ右_表示 = value;
				this.淫タトゥ_手首_ハ\u30FCト3_タトゥ左_表示 = value;
				this.淫タトゥ_手首_ハ\u30FCト3_タトゥ右_表示 = value;
				this.淫タトゥ_手首_ハ\u30FCト2_タトゥ左_表示 = value;
				this.淫タトゥ_手首_ハ\u30FCト2_タトゥ右_表示 = value;
				this.淫タトゥ_通常_ハ\u30FCト1_タトゥ左_表示 = value;
				this.淫タトゥ_通常_ハ\u30FCト1_タトゥ右_表示 = value;
				this.淫タトゥ_通常_ハ\u30FCト2_タトゥ左_表示 = value;
				this.淫タトゥ_通常_ハ\u30FCト2_タトゥ右_表示 = value;
				this.淫タトゥ_筋肉_ハ\u30FCト1_タトゥ左_表示 = value;
				this.淫タトゥ_筋肉_ハ\u30FCト1_タトゥ右_表示 = value;
				this.淫タトゥ_筋肉_ハ\u30FCト2_タトゥ左_表示 = value;
				this.淫タトゥ_筋肉_ハ\u30FCト2_タトゥ右_表示 = value;
				this.悪タトゥ_通常_文字1_文字a_枠_表示 = value;
				this.悪タトゥ_通常_文字1_文字a_文字タトゥ1_表示 = value;
				this.悪タトゥ_通常_文字1_文字a_文字タトゥ2_表示 = value;
				this.悪タトゥ_通常_文字1_文字b_枠_表示 = value;
				this.悪タトゥ_通常_文字1_文字b_文字タトゥ1_表示 = value;
				this.悪タトゥ_通常_文字1_文字b_文字タトゥ2_表示 = value;
				this.悪タトゥ_通常_文字1_文字c_枠_表示 = value;
				this.悪タトゥ_通常_文字1_文字c_文字タトゥ1_表示 = value;
				this.悪タトゥ_通常_文字1_文字c_文字タトゥ2_表示 = value;
				this.悪タトゥ_通常_文字1_文字d_枠_表示 = value;
				this.悪タトゥ_通常_文字1_文字d_文字タトゥ1_表示 = value;
				this.悪タトゥ_通常_文字1_文字d_文字タトゥ2_表示 = value;
				this.悪タトゥ_通常_文字1_文字e_枠_表示 = value;
				this.悪タトゥ_通常_文字1_文字e_文字タトゥ1_表示 = value;
				this.悪タトゥ_通常_文字1_文字e_文字タトゥ2_表示 = value;
				this.悪タトゥ_通常_文字1_文字e_文字タトゥ3_表示 = value;
				this.悪タトゥ_通常_文字2_文字a_枠_表示 = value;
				this.悪タトゥ_通常_文字2_文字a_文字タトゥ1_表示 = value;
				this.悪タトゥ_通常_文字2_文字a_文字タトゥ2_表示 = value;
				this.悪タトゥ_通常_文字2_文字b_枠_表示 = value;
				this.悪タトゥ_通常_文字2_文字b_文字タトゥ1_表示 = value;
				this.悪タトゥ_通常_文字2_文字b_文字タトゥ2_表示 = value;
				this.悪タトゥ_通常_文字2_文字c_枠_表示 = value;
				this.悪タトゥ_通常_文字2_文字c_文字タトゥ1_表示 = value;
				this.悪タトゥ_通常_文字2_文字c_文字タトゥ2_表示 = value;
				this.悪タトゥ_通常_文字2_文字d_枠_表示 = value;
				this.悪タトゥ_通常_文字2_文字d_文字タトゥ1_表示 = value;
				this.悪タトゥ_通常_文字2_文字d_文字タトゥ2_表示 = value;
				this.悪タトゥ_通常_文字2_文字e_枠_表示 = value;
				this.悪タトゥ_通常_文字2_文字e_文字タトゥ1_表示 = value;
				this.悪タトゥ_通常_文字2_文字e_文字タトゥ2_表示 = value;
				this.悪タトゥ_通常_文字2_文字e_文字タトゥ3_表示 = value;
				this.悪タトゥ_通常_タトゥ1_表示 = value;
				this.悪タトゥ_通常_タトゥ2_表示 = value;
				this.悪タトゥ_通常_逆十字_逆十字1_表示 = value;
				this.悪タトゥ_通常_逆十字_逆十字2_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字a_枠_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字a_文字タトゥ1_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字a_文字タトゥ2_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字b_枠_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字b_文字タトゥ1_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字b_文字タトゥ2_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字c_枠_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字c_文字タトゥ1_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字c_文字タトゥ2_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字d_枠_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字d_文字タトゥ1_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字d_文字タトゥ2_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字e_枠_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字e_文字タトゥ1_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字e_文字タトゥ2_表示 = value;
				this.悪タトゥ_筋肉_文字1_文字e_文字タトゥ3_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字a_枠_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字a_文字タトゥ1_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字a_文字タトゥ2_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字b_枠_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字b_文字タトゥ1_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字b_文字タトゥ2_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字c_枠_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字c_文字タトゥ1_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字c_文字タトゥ2_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字d_枠_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字d_文字タトゥ1_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字d_文字タトゥ2_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字e_枠_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字e_文字タトゥ1_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字e_文字タトゥ2_表示 = value;
				this.悪タトゥ_筋肉_文字2_文字e_文字タトゥ3_表示 = value;
				this.悪タトゥ_筋肉_タトゥ1_表示 = value;
				this.悪タトゥ_筋肉_タトゥ2_表示 = value;
				this.悪タトゥ_筋肉_逆十字_逆十字1_表示 = value;
				this.悪タトゥ_筋肉_逆十字_逆十字2_表示 = value;
				this.植性2_通常_萼_萼上_表示 = value;
				this.植性2_通常_萼_萼下_表示 = value;
				this.植性2_通常_萼_萼中_表示 = value;
				this.植性2_欠損_萼_萼上_表示 = value;
				this.植性2_欠損_萼_萼下_表示 = value;
				this.植性2_欠損_萼_萼中_表示 = value;
				this.獣性2_獣毛_表示 = value;
				this.竜性2_棘_棘5_表示 = value;
				this.竜性2_棘_棘4_表示 = value;
				this.竜性2_棘_棘3_表示 = value;
				this.竜性2_棘_棘2_表示 = value;
				this.竜性2_棘_棘1_表示 = value;
				this.虫性2_虫腕下_表示 = value;
				this.虫性2_虫棘1_表示 = value;
				this.虫性2_虫棘2_表示 = value;
				this.虫性2_虫棘3_表示 = value;
				this.虫性2_虫棘4_表示 = value;
				this.虫性2_虫鎌節_表示 = value;
				this.傷X1_表示 = value;
				this.傷I1_表示 = value;
				this.傷I2_表示 = value;
				this.ハイライト_表示 = value;
				this.グロ\u30FCブ_通常_グロ\u30FCブ_表示 = value;
				this.グロ\u30FCブ_通常_縁_表示 = value;
				this.グロ\u30FCブ_筋肉_グロ\u30FCブ_表示 = value;
				this.グロ\u30FCブ_筋肉_縁_表示 = value;
				this.鎧_ベルト_ベルト1_表示 = value;
				this.鎧_ベルト_通常_ベルト2_表示 = value;
				this.鎧_ベルト_筋肉_ベルト2_表示 = value;
				this.鎧_鎧_鎧2_表示 = value;
				this.鎧_鎧_鎧1_表示 = value;
				this.腕輪_革_表示 = value;
				this.腕輪_金具1_表示 = value;
				this.腕輪_金具2_表示 = value;
				this.腕輪_金具3_表示 = value;
				this.腕輪_金具左_表示 = value;
				this.腕輪_金具右_表示 = value;
				this.鎖1.表示 = value;
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
				this.植性1_花弁_花弁CD.不透明度 = value;
				this.植性1_花弁_影_花弁影1CD.不透明度 = value;
				this.植性1_花弁_影_花弁影2CD.不透明度 = value;
				this.植性1_花弁_影_花弁影3CD.不透明度 = value;
				this.植性1_花弁_影_花弁影4CD.不透明度 = value;
				this.植性1_花弁_影_花弁影5CD.不透明度 = value;
				this.獣性1_獣腕CD.不透明度 = value;
				this.竜性1_肘_肘1CD.不透明度 = value;
				this.竜性1_肘_肘2CD.不透明度 = value;
				this.竜性1_鱗_鱗5CD.不透明度 = value;
				this.竜性1_鱗_鱗4CD.不透明度 = value;
				this.竜性1_鱗_鱗3CD.不透明度 = value;
				this.竜性1_鱗_鱗2CD.不透明度 = value;
				this.竜性1_鱗_鱗1CD.不透明度 = value;
				this.竜性1_手首_鱗3CD.不透明度 = value;
				this.竜性1_手首_鱗2CD.不透明度 = value;
				this.竜性1_手首_鱗1CD.不透明度 = value;
				this.虫性1_虫肘CD.不透明度 = value;
				this.虫性1_虫腕上CD.不透明度 = value;
				this.淫タトゥ_手首_タトゥCD.不透明度 = value;
				this.淫タトゥ_手首_ハ\u30FCト1_タトゥ左CD.不透明度 = value;
				this.淫タトゥ_手首_ハ\u30FCト1_タトゥ右CD.不透明度 = value;
				this.淫タトゥ_手首_ハ\u30FCト3_タトゥ左CD.不透明度 = value;
				this.淫タトゥ_手首_ハ\u30FCト3_タトゥ右CD.不透明度 = value;
				this.淫タトゥ_手首_ハ\u30FCト2_タトゥ左CD.不透明度 = value;
				this.淫タトゥ_手首_ハ\u30FCト2_タトゥ右CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト1_タトゥ左CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト1_タトゥ右CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト2_タトゥ左CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト2_タトゥ右CD.不透明度 = value;
				this.悪タトゥ_文字1_文字a_枠CD.不透明度 = value;
				this.悪タトゥ_文字1_文字a_文字タトゥ1CD.不透明度 = value;
				this.悪タトゥ_文字1_文字a_文字タトゥ2CD.不透明度 = value;
				this.悪タトゥ_文字1_文字b_枠CD.不透明度 = value;
				this.悪タトゥ_文字1_文字b_文字タトゥ1CD.不透明度 = value;
				this.悪タトゥ_文字1_文字b_文字タトゥ2CD.不透明度 = value;
				this.悪タトゥ_文字1_文字c_枠CD.不透明度 = value;
				this.悪タトゥ_文字1_文字c_文字タトゥ1CD.不透明度 = value;
				this.悪タトゥ_文字1_文字c_文字タトゥ2CD.不透明度 = value;
				this.悪タトゥ_文字1_文字d_枠CD.不透明度 = value;
				this.悪タトゥ_文字1_文字d_文字タトゥ1CD.不透明度 = value;
				this.悪タトゥ_文字1_文字d_文字タトゥ2CD.不透明度 = value;
				this.悪タトゥ_文字1_文字e_枠CD.不透明度 = value;
				this.悪タトゥ_文字1_文字e_文字タトゥ1CD.不透明度 = value;
				this.悪タトゥ_文字1_文字e_文字タトゥ2CD.不透明度 = value;
				this.悪タトゥ_文字1_文字e_文字タトゥ3CD.不透明度 = value;
				this.悪タトゥ_文字2_文字a_枠CD.不透明度 = value;
				this.悪タトゥ_文字2_文字a_文字タトゥ1CD.不透明度 = value;
				this.悪タトゥ_文字2_文字a_文字タトゥ2CD.不透明度 = value;
				this.悪タトゥ_文字2_文字b_枠CD.不透明度 = value;
				this.悪タトゥ_文字2_文字b_文字タトゥ1CD.不透明度 = value;
				this.悪タトゥ_文字2_文字b_文字タトゥ2CD.不透明度 = value;
				this.悪タトゥ_文字2_文字c_枠CD.不透明度 = value;
				this.悪タトゥ_文字2_文字c_文字タトゥ1CD.不透明度 = value;
				this.悪タトゥ_文字2_文字c_文字タトゥ2CD.不透明度 = value;
				this.悪タトゥ_文字2_文字d_枠CD.不透明度 = value;
				this.悪タトゥ_文字2_文字d_文字タトゥ1CD.不透明度 = value;
				this.悪タトゥ_文字2_文字d_文字タトゥ2CD.不透明度 = value;
				this.悪タトゥ_文字2_文字e_枠CD.不透明度 = value;
				this.悪タトゥ_文字2_文字e_文字タトゥ1CD.不透明度 = value;
				this.悪タトゥ_文字2_文字e_文字タトゥ2CD.不透明度 = value;
				this.悪タトゥ_文字2_文字e_文字タトゥ3CD.不透明度 = value;
				this.悪タトゥ_タトゥ1CD.不透明度 = value;
				this.悪タトゥ_タトゥ2CD.不透明度 = value;
				this.悪タトゥ_逆十字_逆十字1CD.不透明度 = value;
				this.悪タトゥ_逆十字_逆十字2CD.不透明度 = value;
				this.植性2_萼_萼上CD.不透明度 = value;
				this.植性2_萼_萼下CD.不透明度 = value;
				this.植性2_萼_萼中CD.不透明度 = value;
				this.獣性2_獣毛CD.不透明度 = value;
				this.竜性2_棘_棘5CD.不透明度 = value;
				this.竜性2_棘_棘4CD.不透明度 = value;
				this.竜性2_棘_棘3CD.不透明度 = value;
				this.竜性2_棘_棘2CD.不透明度 = value;
				this.竜性2_棘_棘1CD.不透明度 = value;
				this.虫性2_虫腕下CD.不透明度 = value;
				this.虫性2_虫棘1CD.不透明度 = value;
				this.虫性2_虫棘2CD.不透明度 = value;
				this.虫性2_虫棘3CD.不透明度 = value;
				this.虫性2_虫棘4CD.不透明度 = value;
				this.虫性2_虫鎌節CD.不透明度 = value;
				this.傷X1CD.不透明度 = value;
				this.傷I1CD.不透明度 = value;
				this.傷I2CD.不透明度 = value;
				this.ハイライトCD.不透明度 = value;
				this.グロ\u30FCブ_グロ\u30FCブCD.不透明度 = value;
				this.グロ\u30FCブ_縁CD.不透明度 = value;
				this.グロ\u30FCブ_グロ\u30FCブCD.不透明度 = value;
				this.グロ\u30FCブ_縁CD.不透明度 = value;
				this.鎧_ベルト_ベルト1CD.不透明度 = value;
				this.鎧_ベルト_ベルト2CD.不透明度 = value;
				this.鎧_ベルト_ベルト2CD.不透明度 = value;
				this.鎧_鎧_鎧2CD.不透明度 = value;
				this.鎧_鎧_鎧1CD.不透明度 = value;
				this.腕輪_革CD.不透明度 = value;
				this.腕輪_金具1CD.不透明度 = value;
				this.腕輪_金具2CD.不透明度 = value;
				this.腕輪_金具3CD.不透明度 = value;
				this.腕輪_金具左CD.不透明度 = value;
				this.腕輪_金具右CD.不透明度 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_下腕);
			Are.Draw(this.X0Y0_筋肉_筋肉下);
			Are.Draw(this.X0Y0_筋肉_筋肉上);
			this.キスマ\u30FCク.Draw(Are);
			Are.Draw(this.X0Y0_獣性1_獣腕);
			this.鞭痕.Draw(Are);
			Are.Draw(this.X0Y0_竜性1_肘_肘1);
			Are.Draw(this.X0Y0_竜性1_肘_肘2);
			Are.Draw(this.X0Y0_竜性1_鱗_鱗5);
			Are.Draw(this.X0Y0_竜性1_鱗_鱗4);
			Are.Draw(this.X0Y0_竜性1_鱗_鱗3);
			Are.Draw(this.X0Y0_竜性1_鱗_鱗2);
			Are.Draw(this.X0Y0_竜性1_鱗_鱗1);
			Are.Draw(this.X0Y0_竜性1_手首_鱗3);
			Are.Draw(this.X0Y0_竜性1_手首_鱗2);
			Are.Draw(this.X0Y0_竜性1_手首_鱗1);
		}

		public void 外腕描画(Are Are)
		{
			Are.Draw(this.X0Y0_植性1_通常_花弁_花弁);
			Are.Draw(this.X0Y0_植性1_通常_花弁_影_花弁影1);
			Are.Draw(this.X0Y0_植性1_通常_花弁_影_花弁影2);
			Are.Draw(this.X0Y0_植性1_通常_花弁_影_花弁影3);
			Are.Draw(this.X0Y0_植性1_通常_花弁_影_花弁影4);
			Are.Draw(this.X0Y0_植性1_通常_花弁_影_花弁影5);
			Are.Draw(this.X0Y0_植性1_欠損_花弁_花弁);
			Are.Draw(this.X0Y0_植性1_欠損_花弁_影_花弁影1);
			Are.Draw(this.X0Y0_植性1_欠損_花弁_影_花弁影2);
			Are.Draw(this.X0Y0_植性1_欠損_花弁_影_花弁影3);
			Are.Draw(this.X0Y0_植性1_欠損_花弁_影_花弁影4);
			Are.Draw(this.X0Y0_植性1_欠損_花弁_影_花弁影5);
			Are.Draw(this.X0Y0_虫性1_虫肘);
			Are.Draw(this.X0Y0_虫性1_虫腕上);
			Are.Draw(this.X0Y0_淫タトゥ_手首_タトゥ);
			Are.Draw(this.X0Y0_淫タトゥ_手首_ハ\u30FCト1_タトゥ左);
			Are.Draw(this.X0Y0_淫タトゥ_手首_ハ\u30FCト1_タトゥ右);
			Are.Draw(this.X0Y0_淫タトゥ_手首_ハ\u30FCト3_タトゥ左);
			Are.Draw(this.X0Y0_淫タトゥ_手首_ハ\u30FCト3_タトゥ右);
			Are.Draw(this.X0Y0_淫タトゥ_手首_ハ\u30FCト2_タトゥ左);
			Are.Draw(this.X0Y0_淫タトゥ_手首_ハ\u30FCト2_タトゥ右);
			Are.Draw(this.X0Y0_淫タトゥ_通常_ハ\u30FCト1_タトゥ左);
			Are.Draw(this.X0Y0_淫タトゥ_通常_ハ\u30FCト1_タトゥ右);
			Are.Draw(this.X0Y0_淫タトゥ_通常_ハ\u30FCト2_タトゥ左);
			Are.Draw(this.X0Y0_淫タトゥ_通常_ハ\u30FCト2_タトゥ右);
			Are.Draw(this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト1_タトゥ左);
			Are.Draw(this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト1_タトゥ右);
			Are.Draw(this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト2_タトゥ左);
			Are.Draw(this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト2_タトゥ右);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字1_文字a_枠);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字1_文字b_枠);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字1_文字c_枠);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字1_文字d_枠);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字1_文字e_枠);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ3);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字2_文字a_枠);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字2_文字b_枠);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字2_文字c_枠);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字2_文字d_枠);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字2_文字e_枠);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ3);
			Are.Draw(this.X0Y0_悪タトゥ_通常_タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_通常_タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_通常_逆十字_逆十字1);
			Are.Draw(this.X0Y0_悪タトゥ_通常_逆十字_逆十字2);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字1_文字a_枠);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字1_文字b_枠);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字1_文字c_枠);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字1_文字d_枠);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字1_文字e_枠);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ3);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字2_文字a_枠);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字2_文字b_枠);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字2_文字c_枠);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字2_文字d_枠);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字2_文字e_枠);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ3);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_タトゥ1);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_タトゥ2);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_逆十字_逆十字1);
			Are.Draw(this.X0Y0_悪タトゥ_筋肉_逆十字_逆十字2);
			Are.Draw(this.X0Y0_植性2_通常_萼_萼上);
			Are.Draw(this.X0Y0_植性2_通常_萼_萼下);
			Are.Draw(this.X0Y0_植性2_通常_萼_萼中);
			Are.Draw(this.X0Y0_植性2_欠損_萼_萼上);
			Are.Draw(this.X0Y0_植性2_欠損_萼_萼下);
			Are.Draw(this.X0Y0_植性2_欠損_萼_萼中);
			Are.Draw(this.X0Y0_獣性2_獣毛);
			Are.Draw(this.X0Y0_竜性2_棘_棘5);
			Are.Draw(this.X0Y0_竜性2_棘_棘4);
			Are.Draw(this.X0Y0_竜性2_棘_棘3);
			Are.Draw(this.X0Y0_竜性2_棘_棘2);
			Are.Draw(this.X0Y0_竜性2_棘_棘1);
			Are.Draw(this.X0Y0_虫性2_虫腕下);
			Are.Draw(this.X0Y0_虫性2_虫棘1);
			Are.Draw(this.X0Y0_虫性2_虫棘2);
			Are.Draw(this.X0Y0_虫性2_虫棘3);
			Are.Draw(this.X0Y0_虫性2_虫棘4);
			Are.Draw(this.X0Y0_虫性2_虫鎌節);
			Are.Draw(this.X0Y0_傷X1);
			Are.Draw(this.X0Y0_傷I1);
			Are.Draw(this.X0Y0_傷I2);
			Are.Draw(this.X0Y0_ハイライト);
			Are.Draw(this.X0Y0_グロ\u30FCブ_通常_グロ\u30FCブ);
			Are.Draw(this.X0Y0_グロ\u30FCブ_通常_縁);
			Are.Draw(this.X0Y0_グロ\u30FCブ_筋肉_グロ\u30FCブ);
			Are.Draw(this.X0Y0_グロ\u30FCブ_筋肉_縁);
			Are.Draw(this.X0Y0_鎧_ベルト_ベルト1);
			Are.Draw(this.X0Y0_鎧_ベルト_通常_ベルト2);
			Are.Draw(this.X0Y0_鎧_ベルト_筋肉_ベルト2);
			Are.Draw(this.X0Y0_鎧_鎧_鎧2);
			Are.Draw(this.X0Y0_鎧_鎧_鎧1);
			Are.Draw(this.X0Y0_腕輪_革);
			Are.Draw(this.X0Y0_腕輪_金具1);
			Are.Draw(this.X0Y0_腕輪_金具2);
			Are.Draw(this.X0Y0_腕輪_金具3);
			Are.Draw(this.X0Y0_腕輪_金具左);
			Are.Draw(this.X0Y0_腕輪_金具右);
			this.鎖1.描画0(Are);
		}

		public bool グロ\u30FCブ表示
		{
			get
			{
				return this.グロ\u30FCブ_グロ\u30FCブ_表示;
			}
			set
			{
				this.グロ\u30FCブ_グロ\u30FCブ_表示 = value;
				this.グロ\u30FCブ_縁_表示 = value;
			}
		}

		public bool メイル表示
		{
			get
			{
				return this.鎧_ベルト_ベルト1_表示;
			}
			set
			{
				this.鎧_ベルト_ベルト1_表示 = value;
				this.鎧_ベルト_ベルト2_表示 = value;
				this.鎧_鎧_鎧2_表示 = value;
				this.鎧_鎧_鎧1_表示 = value;
			}
		}

		public override void Set拘束角度()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_下腕.AngleBase = num * 130.0;
			this.本体.JoinPAall();
		}

		public void 腕輪尺度修正()
		{
			if (this.獣性1_獣腕_表示)
			{
				double num = 1.7;
				this.X0Y0_腕輪_革.SizeBase *= num;
				this.X0Y0_腕輪_金具1.SizeBase *= num;
				this.X0Y0_腕輪_金具2.SizeBase *= num;
				this.X0Y0_腕輪_金具3.SizeBase *= num;
				this.X0Y0_腕輪_金具左.SizeBase *= num;
				this.X0Y0_腕輪_金具右.SizeBase *= num;
			}
		}

		public override bool Is布(Par p)
		{
			return p == this.X0Y0_グロ\u30FCブ_通常_グロ\u30FCブ || p == this.X0Y0_グロ\u30FCブ_通常_縁 || p == this.X0Y0_グロ\u30FCブ_筋肉_グロ\u30FCブ || p == this.X0Y0_グロ\u30FCブ_筋肉_縁;
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_腕輪_革 || p == this.X0Y0_腕輪_金具1 || p == this.X0Y0_腕輪_金具2 || p == this.X0Y0_腕輪_金具3 || p == this.X0Y0_腕輪_金具左 || p == this.X0Y0_腕輪_金具右;
		}

		public override bool Is鉄(Par p)
		{
			return p == this.X0Y0_鎧_ベルト_ベルト1 || p == this.X0Y0_鎧_ベルト_通常_ベルト2 || p == this.X0Y0_鎧_ベルト_筋肉_ベルト2 || p == this.X0Y0_鎧_鎧_鎧2 || p == this.X0Y0_鎧_鎧_鎧1;
		}

		public override bool 肘部_外線
		{
			get
			{
				return this.X0Y0_下腕.OP[this.右 ? 3 : 0].Outline;
			}
			set
			{
				this.X0Y0_下腕.OP[this.右 ? 3 : 0].Outline = value;
				this.X0Y0_獣性1_獣腕.OP[this.右 ? 3 : 2].Outline = value;
				this.X0Y0_グロ\u30FCブ_通常_グロ\u30FCブ.OP[this.右 ? 3 : 0].Outline = value;
				this.X0Y0_グロ\u30FCブ_筋肉_グロ\u30FCブ.OP[this.右 ? 3 : 0].Outline = value;
			}
		}

		public JointS 外腕_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_下腕, 0);
			}
		}

		public JointS 手_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_下腕, 3);
			}
		}

		public JointS 虫鎌_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_下腕, 2);
			}
		}

		public JointS 鎖1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腕輪_金具左, 0);
			}
		}

		public JointS 鎖2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腕輪_金具右, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_下腕CP.Update();
			this.X0Y0_筋肉_筋肉下CP.Update();
			this.X0Y0_筋肉_筋肉上CP.Update();
			this.X0Y0_植性1_通常_花弁_花弁CP.Update();
			this.X0Y0_植性1_通常_花弁_影_花弁影1CP.Update();
			this.X0Y0_植性1_通常_花弁_影_花弁影2CP.Update();
			this.X0Y0_植性1_通常_花弁_影_花弁影3CP.Update();
			this.X0Y0_植性1_通常_花弁_影_花弁影4CP.Update();
			this.X0Y0_植性1_通常_花弁_影_花弁影5CP.Update();
			this.X0Y0_植性1_欠損_花弁_花弁CP.Update();
			this.X0Y0_植性1_欠損_花弁_影_花弁影1CP.Update();
			this.X0Y0_植性1_欠損_花弁_影_花弁影2CP.Update();
			this.X0Y0_植性1_欠損_花弁_影_花弁影3CP.Update();
			this.X0Y0_植性1_欠損_花弁_影_花弁影4CP.Update();
			this.X0Y0_植性1_欠損_花弁_影_花弁影5CP.Update();
			this.X0Y0_獣性1_獣腕CP.Update();
			this.X0Y0_竜性1_肘_肘1CP.Update();
			this.X0Y0_竜性1_肘_肘2CP.Update();
			this.X0Y0_竜性1_鱗_鱗5CP.Update();
			this.X0Y0_竜性1_鱗_鱗4CP.Update();
			this.X0Y0_竜性1_鱗_鱗3CP.Update();
			this.X0Y0_竜性1_鱗_鱗2CP.Update();
			this.X0Y0_竜性1_鱗_鱗1CP.Update();
			this.X0Y0_竜性1_手首_鱗3CP.Update();
			this.X0Y0_竜性1_手首_鱗2CP.Update();
			this.X0Y0_竜性1_手首_鱗1CP.Update();
			this.X0Y0_虫性1_虫肘CP.Update();
			this.X0Y0_虫性1_虫腕上CP.Update();
			this.X0Y0_淫タトゥ_手首_タトゥCP.Update();
			this.X0Y0_淫タトゥ_手首_ハ\u30FCト1_タトゥ左CP.Update();
			this.X0Y0_淫タトゥ_手首_ハ\u30FCト1_タトゥ右CP.Update();
			this.X0Y0_淫タトゥ_手首_ハ\u30FCト3_タトゥ左CP.Update();
			this.X0Y0_淫タトゥ_手首_ハ\u30FCト3_タトゥ右CP.Update();
			this.X0Y0_淫タトゥ_手首_ハ\u30FCト2_タトゥ左CP.Update();
			this.X0Y0_淫タトゥ_手首_ハ\u30FCト2_タトゥ右CP.Update();
			this.X0Y0_淫タトゥ_通常_ハ\u30FCト1_タトゥ左CP.Update();
			this.X0Y0_淫タトゥ_通常_ハ\u30FCト1_タトゥ右CP.Update();
			this.X0Y0_淫タトゥ_通常_ハ\u30FCト2_タトゥ左CP.Update();
			this.X0Y0_淫タトゥ_通常_ハ\u30FCト2_タトゥ右CP.Update();
			this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト1_タトゥ左CP.Update();
			this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト1_タトゥ右CP.Update();
			this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト2_タトゥ左CP.Update();
			this.X0Y0_淫タトゥ_筋肉_ハ\u30FCト2_タトゥ右CP.Update();
			this.X0Y0_悪タトゥ_通常_文字1_文字a_枠CP.Update();
			this.X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_通常_文字1_文字b_枠CP.Update();
			this.X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_通常_文字1_文字c_枠CP.Update();
			this.X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_通常_文字1_文字d_枠CP.Update();
			this.X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_通常_文字1_文字e_枠CP.Update();
			this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ3CP.Update();
			this.X0Y0_悪タトゥ_通常_文字2_文字a_枠CP.Update();
			this.X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_通常_文字2_文字b_枠CP.Update();
			this.X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_通常_文字2_文字c_枠CP.Update();
			this.X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_通常_文字2_文字d_枠CP.Update();
			this.X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_通常_文字2_文字e_枠CP.Update();
			this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ3CP.Update();
			this.X0Y0_悪タトゥ_通常_タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_通常_タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_通常_逆十字_逆十字1CP.Update();
			this.X0Y0_悪タトゥ_通常_逆十字_逆十字2CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字a_枠CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字b_枠CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字c_枠CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字d_枠CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字e_枠CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ3CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字a_枠CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字b_枠CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字c_枠CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字d_枠CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字e_枠CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ3CP.Update();
			this.X0Y0_悪タトゥ_筋肉_タトゥ1CP.Update();
			this.X0Y0_悪タトゥ_筋肉_タトゥ2CP.Update();
			this.X0Y0_悪タトゥ_筋肉_逆十字_逆十字1CP.Update();
			this.X0Y0_悪タトゥ_筋肉_逆十字_逆十字2CP.Update();
			this.X0Y0_植性2_通常_萼_萼上CP.Update();
			this.X0Y0_植性2_通常_萼_萼下CP.Update();
			this.X0Y0_植性2_通常_萼_萼中CP.Update();
			this.X0Y0_植性2_欠損_萼_萼上CP.Update();
			this.X0Y0_植性2_欠損_萼_萼下CP.Update();
			this.X0Y0_植性2_欠損_萼_萼中CP.Update();
			this.X0Y0_獣性2_獣毛CP.Update();
			this.X0Y0_竜性2_棘_棘5CP.Update();
			this.X0Y0_竜性2_棘_棘4CP.Update();
			this.X0Y0_竜性2_棘_棘3CP.Update();
			this.X0Y0_竜性2_棘_棘2CP.Update();
			this.X0Y0_竜性2_棘_棘1CP.Update();
			this.X0Y0_虫性2_虫腕下CP.Update();
			this.X0Y0_虫性2_虫棘1CP.Update();
			this.X0Y0_虫性2_虫棘2CP.Update();
			this.X0Y0_虫性2_虫棘3CP.Update();
			this.X0Y0_虫性2_虫棘4CP.Update();
			this.X0Y0_虫性2_虫鎌節CP.Update();
			this.X0Y0_傷X1CP.Update();
			this.X0Y0_傷I1CP.Update();
			this.X0Y0_傷I2CP.Update();
			this.X0Y0_ハイライトCP.Update();
			this.X0Y0_グロ\u30FCブ_通常_グロ\u30FCブCP.Update();
			this.X0Y0_グロ\u30FCブ_通常_縁CP.Update();
			this.X0Y0_グロ\u30FCブ_筋肉_グロ\u30FCブCP.Update();
			this.X0Y0_グロ\u30FCブ_筋肉_縁CP.Update();
			this.X0Y0_鎧_ベルト_ベルト1CP.Update();
			this.X0Y0_鎧_ベルト_通常_ベルト2CP.Update();
			this.X0Y0_鎧_ベルト_筋肉_ベルト2CP.Update();
			this.X0Y0_鎧_鎧_鎧2CP.Update();
			this.X0Y0_鎧_鎧_鎧1CP.Update();
			this.X0Y0_腕輪_革CP.Update();
			this.X0Y0_腕輪_金具1CP.Update();
			this.X0Y0_腕輪_金具2CP.Update();
			this.X0Y0_腕輪_金具3CP.Update();
			this.X0Y0_腕輪_金具左CP.Update();
			this.X0Y0_腕輪_金具右CP.Update();
			this.鎖1.接続PA();
			this.鎖1.色更新();
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
			case 配色指定.B0:
				this.配色B0(体配色);
				return;
			case 配色指定.BT0:
				this.配色BT0(体配色);
				return;
			case 配色指定.BT1:
				this.配色BT1(体配色);
				return;
			case 配色指定.L0:
				this.配色L0(体配色);
				return;
			case 配色指定.LT0:
				this.配色LT0(体配色);
				return;
			case 配色指定.LT1:
				this.配色LT1(体配色);
				return;
			}
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.下腕CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.植性1_花弁_花弁CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.獣性1_獣腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性1_肘_肘1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_肘_肘2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.竜性1_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.虫性1_虫肘CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性1_虫腕上CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.淫タトゥ_手首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植性2_萼_萼上CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性2_萼_萼下CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性2_萼_萼中CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.獣性2_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性2_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.虫性2_虫腕下CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.グロ\u30FCブ_グロ\u30FCブCD = new ColorD();
			this.グロ\u30FCブ_縁CD = new ColorD();
			this.鎧_ベルト_ベルト1CD = new ColorD();
			this.鎧_ベルト_ベルト2CD = new ColorD();
			this.鎧_鎧_鎧2CD = new ColorD();
			this.鎧_鎧_鎧1CD = new ColorD();
			this.腕輪_革CD = new ColorD();
			this.腕輪_金具1CD = new ColorD();
			this.腕輪_金具2CD = new ColorD();
			this.腕輪_金具3CD = new ColorD();
			this.腕輪_金具左CD = new ColorD();
			this.腕輪_金具右CD = new ColorD();
		}

		private void 配色T0(体配色 体配色)
		{
			this.下腕CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.植性1_花弁_花弁CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.獣性1_獣腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性1_肘_肘1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_肘_肘2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.竜性1_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.虫性1_虫肘CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性1_虫腕上CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.淫タトゥ_手首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植性2_萼_萼上CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性2_萼_萼下CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性2_萼_萼中CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.獣性2_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性2_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性2_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性2_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.虫性2_虫腕下CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性2_虫棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性2_虫棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性2_虫棘4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性2_虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.グロ\u30FCブ_グロ\u30FCブCD = new ColorD();
			this.グロ\u30FCブ_縁CD = new ColorD();
			this.鎧_ベルト_ベルト1CD = new ColorD();
			this.鎧_ベルト_ベルト2CD = new ColorD();
			this.鎧_鎧_鎧2CD = new ColorD();
			this.鎧_鎧_鎧1CD = new ColorD();
			this.腕輪_革CD = new ColorD();
			this.腕輪_金具1CD = new ColorD();
			this.腕輪_金具2CD = new ColorD();
			this.腕輪_金具3CD = new ColorD();
			this.腕輪_金具左CD = new ColorD();
			this.腕輪_金具右CD = new ColorD();
		}

		private void 配色T1(体配色 体配色)
		{
			this.下腕CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.植性1_花弁_花弁CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.獣性1_獣腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性1_肘_肘1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_肘_肘2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.竜性1_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.虫性1_虫肘CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性1_虫腕上CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.淫タトゥ_手首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植性2_萼_萼上CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性2_萼_萼下CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性2_萼_萼中CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.獣性2_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性2_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性2_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性2_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性2_虫腕下CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性2_虫棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.グロ\u30FCブ_グロ\u30FCブCD = new ColorD();
			this.グロ\u30FCブ_縁CD = new ColorD();
			this.鎧_ベルト_ベルト1CD = new ColorD();
			this.鎧_ベルト_ベルト2CD = new ColorD();
			this.鎧_鎧_鎧2CD = new ColorD();
			this.鎧_鎧_鎧1CD = new ColorD();
			this.腕輪_革CD = new ColorD();
			this.腕輪_金具1CD = new ColorD();
			this.腕輪_金具2CD = new ColorD();
			this.腕輪_金具3CD = new ColorD();
			this.腕輪_金具左CD = new ColorD();
			this.腕輪_金具右CD = new ColorD();
		}

		private void 配色B0(体配色 体配色)
		{
			this.下腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.植性1_花弁_花弁CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.獣性1_獣腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性1_肘_肘1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_肘_肘2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.竜性1_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.虫性1_虫肘CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性1_虫腕上CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.淫タトゥ_手首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植性2_萼_萼上CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性2_萼_萼下CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性2_萼_萼中CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.獣性2_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性2_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.虫性2_虫腕下CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.グロ\u30FCブ_グロ\u30FCブCD = new ColorD();
			this.グロ\u30FCブ_縁CD = new ColorD();
			this.鎧_ベルト_ベルト1CD = new ColorD();
			this.鎧_ベルト_ベルト2CD = new ColorD();
			this.鎧_鎧_鎧2CD = new ColorD();
			this.鎧_鎧_鎧1CD = new ColorD();
			this.腕輪_革CD = new ColorD();
			this.腕輪_金具1CD = new ColorD();
			this.腕輪_金具2CD = new ColorD();
			this.腕輪_金具3CD = new ColorD();
			this.腕輪_金具左CD = new ColorD();
			this.腕輪_金具右CD = new ColorD();
		}

		private void 配色BT0(体配色 体配色)
		{
			this.下腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.植性1_花弁_花弁CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.獣性1_獣腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性1_肘_肘1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_肘_肘2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.竜性1_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.虫性1_虫肘CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性1_虫腕上CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.淫タトゥ_手首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植性2_萼_萼上CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性2_萼_萼下CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性2_萼_萼中CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.獣性2_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性2_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性2_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性2_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.虫性2_虫腕下CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性2_虫棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性2_虫棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性2_虫棘4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性2_虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.グロ\u30FCブ_グロ\u30FCブCD = new ColorD();
			this.グロ\u30FCブ_縁CD = new ColorD();
			this.鎧_ベルト_ベルト1CD = new ColorD();
			this.鎧_ベルト_ベルト2CD = new ColorD();
			this.鎧_鎧_鎧2CD = new ColorD();
			this.鎧_鎧_鎧1CD = new ColorD();
			this.腕輪_革CD = new ColorD();
			this.腕輪_金具1CD = new ColorD();
			this.腕輪_金具2CD = new ColorD();
			this.腕輪_金具3CD = new ColorD();
			this.腕輪_金具左CD = new ColorD();
			this.腕輪_金具右CD = new ColorD();
		}

		private void 配色BT1(体配色 体配色)
		{
			this.下腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.筋肉_筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
			this.植性1_花弁_花弁CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.獣性1_獣腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性1_肘_肘1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_肘_肘2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.竜性1_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.虫性1_虫肘CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性1_虫腕上CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.淫タトゥ_手首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植性2_萼_萼上CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性2_萼_萼下CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性2_萼_萼中CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.獣性2_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性2_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性2_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性2_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性2_虫腕下CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性2_虫棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.グロ\u30FCブ_グロ\u30FCブCD = new ColorD();
			this.グロ\u30FCブ_縁CD = new ColorD();
			this.鎧_ベルト_ベルト1CD = new ColorD();
			this.鎧_ベルト_ベルト2CD = new ColorD();
			this.鎧_鎧_鎧2CD = new ColorD();
			this.鎧_鎧_鎧1CD = new ColorD();
			this.腕輪_革CD = new ColorD();
			this.腕輪_金具1CD = new ColorD();
			this.腕輪_金具2CD = new ColorD();
			this.腕輪_金具3CD = new ColorD();
			this.腕輪_金具左CD = new ColorD();
			this.腕輪_金具右CD = new ColorD();
		}

		private void 配色L0(体配色 体配色)
		{
			this.下腕CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.植性1_花弁_花弁CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.獣性1_獣腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性1_肘_肘1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_肘_肘2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.竜性1_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.虫性1_虫肘CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性1_虫腕上CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.淫タトゥ_手首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植性2_萼_萼上CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性2_萼_萼下CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性2_萼_萼中CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.獣性2_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性2_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.虫性2_虫腕下CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.グロ\u30FCブ_グロ\u30FCブCD = new ColorD();
			this.グロ\u30FCブ_縁CD = new ColorD();
			this.鎧_ベルト_ベルト1CD = new ColorD();
			this.鎧_ベルト_ベルト2CD = new ColorD();
			this.鎧_鎧_鎧2CD = new ColorD();
			this.鎧_鎧_鎧1CD = new ColorD();
			this.腕輪_革CD = new ColorD();
			this.腕輪_金具1CD = new ColorD();
			this.腕輪_金具2CD = new ColorD();
			this.腕輪_金具3CD = new ColorD();
			this.腕輪_金具左CD = new ColorD();
			this.腕輪_金具右CD = new ColorD();
		}

		private void 配色LT0(体配色 体配色)
		{
			this.下腕CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.植性1_花弁_花弁CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.獣性1_獣腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性1_肘_肘1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_肘_肘2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.竜性1_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.虫性1_虫肘CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性1_虫腕上CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.淫タトゥ_手首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植性2_萼_萼上CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性2_萼_萼下CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性2_萼_萼中CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.獣性2_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性2_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性2_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性2_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.虫性2_虫腕下CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性2_虫棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性2_虫棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性2_虫棘4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性2_虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.グロ\u30FCブ_グロ\u30FCブCD = new ColorD();
			this.グロ\u30FCブ_縁CD = new ColorD();
			this.鎧_ベルト_ベルト1CD = new ColorD();
			this.鎧_ベルト_ベルト2CD = new ColorD();
			this.鎧_鎧_鎧2CD = new ColorD();
			this.鎧_鎧_鎧1CD = new ColorD();
			this.腕輪_革CD = new ColorD();
			this.腕輪_金具1CD = new ColorD();
			this.腕輪_金具2CD = new ColorD();
			this.腕輪_金具3CD = new ColorD();
			this.腕輪_金具左CD = new ColorD();
			this.腕輪_金具右CD = new ColorD();
		}

		private void 配色LT1(体配色 体配色)
		{
			this.下腕CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.筋肉_筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.植性1_花弁_花弁CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影3CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影4CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.植性1_花弁_影_花弁影5CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.獣性1_獣腕CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性1_肘_肘1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_肘_肘2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.竜性1_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性1_手首_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.虫性1_虫肘CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性1_虫腕上CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.淫タトゥ_手首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_手首_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植性2_萼_萼上CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性2_萼_萼下CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性2_萼_萼中CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.獣性2_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性2_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性2_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性2_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性2_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性2_虫腕下CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性2_虫棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫棘4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性2_虫鎌節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.グロ\u30FCブ_グロ\u30FCブCD = new ColorD();
			this.グロ\u30FCブ_縁CD = new ColorD();
			this.鎧_ベルト_ベルト1CD = new ColorD();
			this.鎧_ベルト_ベルト2CD = new ColorD();
			this.鎧_鎧_鎧2CD = new ColorD();
			this.鎧_鎧_鎧1CD = new ColorD();
			this.腕輪_革CD = new ColorD();
			this.腕輪_金具1CD = new ColorD();
			this.腕輪_金具2CD = new ColorD();
			this.腕輪_金具3CD = new ColorD();
			this.腕輪_金具左CD = new ColorD();
			this.腕輪_金具右CD = new ColorD();
		}

		public void 腕輪配色(拘束具色 配色)
		{
			this.腕輪_革CD.色 = 配色.革部色;
			this.腕輪_金具1CD.色 = 配色.金具色;
			this.腕輪_金具2CD.色 = this.腕輪_金具1CD.色;
			this.腕輪_金具3CD.色 = this.腕輪_金具1CD.色;
			this.腕輪_金具左CD.色 = this.腕輪_金具1CD.色;
			this.腕輪_金具右CD.色 = this.腕輪_金具1CD.色;
		}

		public void 鎖配色(鎖色 配色)
		{
			this.鎖1.配色鎖(配色);
		}

		public Par X0Y0_下腕;

		public Par X0Y0_筋肉_筋肉下;

		public Par X0Y0_筋肉_筋肉上;

		public Par X0Y0_植性1_通常_花弁_花弁;

		public Par X0Y0_植性1_通常_花弁_影_花弁影1;

		public Par X0Y0_植性1_通常_花弁_影_花弁影2;

		public Par X0Y0_植性1_通常_花弁_影_花弁影3;

		public Par X0Y0_植性1_通常_花弁_影_花弁影4;

		public Par X0Y0_植性1_通常_花弁_影_花弁影5;

		public Par X0Y0_植性1_欠損_花弁_花弁;

		public Par X0Y0_植性1_欠損_花弁_影_花弁影1;

		public Par X0Y0_植性1_欠損_花弁_影_花弁影2;

		public Par X0Y0_植性1_欠損_花弁_影_花弁影3;

		public Par X0Y0_植性1_欠損_花弁_影_花弁影4;

		public Par X0Y0_植性1_欠損_花弁_影_花弁影5;

		public Par X0Y0_獣性1_獣腕;

		public Par X0Y0_竜性1_肘_肘1;

		public Par X0Y0_竜性1_肘_肘2;

		public Par X0Y0_竜性1_鱗_鱗5;

		public Par X0Y0_竜性1_鱗_鱗4;

		public Par X0Y0_竜性1_鱗_鱗3;

		public Par X0Y0_竜性1_鱗_鱗2;

		public Par X0Y0_竜性1_鱗_鱗1;

		public Par X0Y0_竜性1_手首_鱗3;

		public Par X0Y0_竜性1_手首_鱗2;

		public Par X0Y0_竜性1_手首_鱗1;

		public Par X0Y0_虫性1_虫肘;

		public Par X0Y0_虫性1_虫腕上;

		public Par X0Y0_淫タトゥ_手首_タトゥ;

		public Par X0Y0_淫タトゥ_手首_ハ\u30FCト1_タトゥ左;

		public Par X0Y0_淫タトゥ_手首_ハ\u30FCト1_タトゥ右;

		public Par X0Y0_淫タトゥ_手首_ハ\u30FCト3_タトゥ左;

		public Par X0Y0_淫タトゥ_手首_ハ\u30FCト3_タトゥ右;

		public Par X0Y0_淫タトゥ_手首_ハ\u30FCト2_タトゥ左;

		public Par X0Y0_淫タトゥ_手首_ハ\u30FCト2_タトゥ右;

		public Par X0Y0_淫タトゥ_通常_ハ\u30FCト1_タトゥ左;

		public Par X0Y0_淫タトゥ_通常_ハ\u30FCト1_タトゥ右;

		public Par X0Y0_淫タトゥ_通常_ハ\u30FCト2_タトゥ左;

		public Par X0Y0_淫タトゥ_通常_ハ\u30FCト2_タトゥ右;

		public Par X0Y0_淫タトゥ_筋肉_ハ\u30FCト1_タトゥ左;

		public Par X0Y0_淫タトゥ_筋肉_ハ\u30FCト1_タトゥ右;

		public Par X0Y0_淫タトゥ_筋肉_ハ\u30FCト2_タトゥ左;

		public Par X0Y0_淫タトゥ_筋肉_ハ\u30FCト2_タトゥ右;

		public Par X0Y0_悪タトゥ_通常_文字1_文字a_枠;

		public Par X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ1;

		public Par X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ2;

		public Par X0Y0_悪タトゥ_通常_文字1_文字b_枠;

		public Par X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ1;

		public Par X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ2;

		public Par X0Y0_悪タトゥ_通常_文字1_文字c_枠;

		public Par X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ1;

		public Par X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ2;

		public Par X0Y0_悪タトゥ_通常_文字1_文字d_枠;

		public Par X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ1;

		public Par X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ2;

		public Par X0Y0_悪タトゥ_通常_文字1_文字e_枠;

		public Par X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ1;

		public Par X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ2;

		public Par X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ3;

		public Par X0Y0_悪タトゥ_通常_文字2_文字a_枠;

		public Par X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ1;

		public Par X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ2;

		public Par X0Y0_悪タトゥ_通常_文字2_文字b_枠;

		public Par X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ1;

		public Par X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ2;

		public Par X0Y0_悪タトゥ_通常_文字2_文字c_枠;

		public Par X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ1;

		public Par X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ2;

		public Par X0Y0_悪タトゥ_通常_文字2_文字d_枠;

		public Par X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ1;

		public Par X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ2;

		public Par X0Y0_悪タトゥ_通常_文字2_文字e_枠;

		public Par X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ1;

		public Par X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ2;

		public Par X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ3;

		public Par X0Y0_悪タトゥ_通常_タトゥ1;

		public Par X0Y0_悪タトゥ_通常_タトゥ2;

		public Par X0Y0_悪タトゥ_通常_逆十字_逆十字1;

		public Par X0Y0_悪タトゥ_通常_逆十字_逆十字2;

		public Par X0Y0_悪タトゥ_筋肉_文字1_文字a_枠;

		public Par X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ1;

		public Par X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ2;

		public Par X0Y0_悪タトゥ_筋肉_文字1_文字b_枠;

		public Par X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ1;

		public Par X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ2;

		public Par X0Y0_悪タトゥ_筋肉_文字1_文字c_枠;

		public Par X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ1;

		public Par X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ2;

		public Par X0Y0_悪タトゥ_筋肉_文字1_文字d_枠;

		public Par X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ1;

		public Par X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ2;

		public Par X0Y0_悪タトゥ_筋肉_文字1_文字e_枠;

		public Par X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ1;

		public Par X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ2;

		public Par X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ3;

		public Par X0Y0_悪タトゥ_筋肉_文字2_文字a_枠;

		public Par X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ1;

		public Par X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ2;

		public Par X0Y0_悪タトゥ_筋肉_文字2_文字b_枠;

		public Par X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ1;

		public Par X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ2;

		public Par X0Y0_悪タトゥ_筋肉_文字2_文字c_枠;

		public Par X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ1;

		public Par X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ2;

		public Par X0Y0_悪タトゥ_筋肉_文字2_文字d_枠;

		public Par X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ1;

		public Par X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ2;

		public Par X0Y0_悪タトゥ_筋肉_文字2_文字e_枠;

		public Par X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ1;

		public Par X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ2;

		public Par X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ3;

		public Par X0Y0_悪タトゥ_筋肉_タトゥ1;

		public Par X0Y0_悪タトゥ_筋肉_タトゥ2;

		public Par X0Y0_悪タトゥ_筋肉_逆十字_逆十字1;

		public Par X0Y0_悪タトゥ_筋肉_逆十字_逆十字2;

		public Par X0Y0_植性2_通常_萼_萼上;

		public Par X0Y0_植性2_通常_萼_萼下;

		public Par X0Y0_植性2_通常_萼_萼中;

		public Par X0Y0_植性2_欠損_萼_萼上;

		public Par X0Y0_植性2_欠損_萼_萼下;

		public Par X0Y0_植性2_欠損_萼_萼中;

		public Par X0Y0_獣性2_獣毛;

		public Par X0Y0_竜性2_棘_棘5;

		public Par X0Y0_竜性2_棘_棘4;

		public Par X0Y0_竜性2_棘_棘3;

		public Par X0Y0_竜性2_棘_棘2;

		public Par X0Y0_竜性2_棘_棘1;

		public Par X0Y0_虫性2_虫腕下;

		public Par X0Y0_虫性2_虫棘1;

		public Par X0Y0_虫性2_虫棘2;

		public Par X0Y0_虫性2_虫棘3;

		public Par X0Y0_虫性2_虫棘4;

		public Par X0Y0_虫性2_虫鎌節;

		public Par X0Y0_傷X1;

		public Par X0Y0_傷I1;

		public Par X0Y0_傷I2;

		public Par X0Y0_ハイライト;

		public Par X0Y0_グロ\u30FCブ_通常_グロ\u30FCブ;

		public Par X0Y0_グロ\u30FCブ_通常_縁;

		public Par X0Y0_グロ\u30FCブ_筋肉_グロ\u30FCブ;

		public Par X0Y0_グロ\u30FCブ_筋肉_縁;

		public Par X0Y0_鎧_ベルト_ベルト1;

		public Par X0Y0_鎧_ベルト_通常_ベルト2;

		public Par X0Y0_鎧_ベルト_筋肉_ベルト2;

		public Par X0Y0_鎧_鎧_鎧2;

		public Par X0Y0_鎧_鎧_鎧1;

		public Par X0Y0_腕輪_革;

		public Par X0Y0_腕輪_金具1;

		public Par X0Y0_腕輪_金具2;

		public Par X0Y0_腕輪_金具3;

		public Par X0Y0_腕輪_金具左;

		public Par X0Y0_腕輪_金具右;

		public ColorD 下腕CD;

		public ColorD 筋肉_筋肉下CD;

		public ColorD 筋肉_筋肉上CD;

		public ColorD 植性1_花弁_花弁CD;

		public ColorD 植性1_花弁_影_花弁影1CD;

		public ColorD 植性1_花弁_影_花弁影2CD;

		public ColorD 植性1_花弁_影_花弁影3CD;

		public ColorD 植性1_花弁_影_花弁影4CD;

		public ColorD 植性1_花弁_影_花弁影5CD;

		public ColorD 獣性1_獣腕CD;

		public ColorD 竜性1_肘_肘1CD;

		public ColorD 竜性1_肘_肘2CD;

		public ColorD 竜性1_鱗_鱗5CD;

		public ColorD 竜性1_鱗_鱗4CD;

		public ColorD 竜性1_鱗_鱗3CD;

		public ColorD 竜性1_鱗_鱗2CD;

		public ColorD 竜性1_鱗_鱗1CD;

		public ColorD 竜性1_手首_鱗3CD;

		public ColorD 竜性1_手首_鱗2CD;

		public ColorD 竜性1_手首_鱗1CD;

		public ColorD 虫性1_虫肘CD;

		public ColorD 虫性1_虫腕上CD;

		public ColorD 淫タトゥ_手首_タトゥCD;

		public ColorD 淫タトゥ_手首_ハ\u30FCト1_タトゥ左CD;

		public ColorD 淫タトゥ_手首_ハ\u30FCト1_タトゥ右CD;

		public ColorD 淫タトゥ_手首_ハ\u30FCト3_タトゥ左CD;

		public ColorD 淫タトゥ_手首_ハ\u30FCト3_タトゥ右CD;

		public ColorD 淫タトゥ_手首_ハ\u30FCト2_タトゥ左CD;

		public ColorD 淫タトゥ_手首_ハ\u30FCト2_タトゥ右CD;

		public ColorD 淫タトゥ_ハ\u30FCト1_タトゥ左CD;

		public ColorD 淫タトゥ_ハ\u30FCト1_タトゥ右CD;

		public ColorD 淫タトゥ_ハ\u30FCト2_タトゥ左CD;

		public ColorD 淫タトゥ_ハ\u30FCト2_タトゥ右CD;

		public ColorD 悪タトゥ_文字1_文字a_枠CD;

		public ColorD 悪タトゥ_文字1_文字a_文字タトゥ1CD;

		public ColorD 悪タトゥ_文字1_文字a_文字タトゥ2CD;

		public ColorD 悪タトゥ_文字1_文字b_枠CD;

		public ColorD 悪タトゥ_文字1_文字b_文字タトゥ1CD;

		public ColorD 悪タトゥ_文字1_文字b_文字タトゥ2CD;

		public ColorD 悪タトゥ_文字1_文字c_枠CD;

		public ColorD 悪タトゥ_文字1_文字c_文字タトゥ1CD;

		public ColorD 悪タトゥ_文字1_文字c_文字タトゥ2CD;

		public ColorD 悪タトゥ_文字1_文字d_枠CD;

		public ColorD 悪タトゥ_文字1_文字d_文字タトゥ1CD;

		public ColorD 悪タトゥ_文字1_文字d_文字タトゥ2CD;

		public ColorD 悪タトゥ_文字1_文字e_枠CD;

		public ColorD 悪タトゥ_文字1_文字e_文字タトゥ1CD;

		public ColorD 悪タトゥ_文字1_文字e_文字タトゥ2CD;

		public ColorD 悪タトゥ_文字1_文字e_文字タトゥ3CD;

		public ColorD 悪タトゥ_文字2_文字a_枠CD;

		public ColorD 悪タトゥ_文字2_文字a_文字タトゥ1CD;

		public ColorD 悪タトゥ_文字2_文字a_文字タトゥ2CD;

		public ColorD 悪タトゥ_文字2_文字b_枠CD;

		public ColorD 悪タトゥ_文字2_文字b_文字タトゥ1CD;

		public ColorD 悪タトゥ_文字2_文字b_文字タトゥ2CD;

		public ColorD 悪タトゥ_文字2_文字c_枠CD;

		public ColorD 悪タトゥ_文字2_文字c_文字タトゥ1CD;

		public ColorD 悪タトゥ_文字2_文字c_文字タトゥ2CD;

		public ColorD 悪タトゥ_文字2_文字d_枠CD;

		public ColorD 悪タトゥ_文字2_文字d_文字タトゥ1CD;

		public ColorD 悪タトゥ_文字2_文字d_文字タトゥ2CD;

		public ColorD 悪タトゥ_文字2_文字e_枠CD;

		public ColorD 悪タトゥ_文字2_文字e_文字タトゥ1CD;

		public ColorD 悪タトゥ_文字2_文字e_文字タトゥ2CD;

		public ColorD 悪タトゥ_文字2_文字e_文字タトゥ3CD;

		public ColorD 悪タトゥ_タトゥ1CD;

		public ColorD 悪タトゥ_タトゥ2CD;

		public ColorD 悪タトゥ_逆十字_逆十字1CD;

		public ColorD 悪タトゥ_逆十字_逆十字2CD;

		public ColorD 植性2_萼_萼上CD;

		public ColorD 植性2_萼_萼下CD;

		public ColorD 植性2_萼_萼中CD;

		public ColorD 獣性2_獣毛CD;

		public ColorD 竜性2_棘_棘5CD;

		public ColorD 竜性2_棘_棘4CD;

		public ColorD 竜性2_棘_棘3CD;

		public ColorD 竜性2_棘_棘2CD;

		public ColorD 竜性2_棘_棘1CD;

		public ColorD 虫性2_虫腕下CD;

		public ColorD 虫性2_虫棘1CD;

		public ColorD 虫性2_虫棘2CD;

		public ColorD 虫性2_虫棘3CD;

		public ColorD 虫性2_虫棘4CD;

		public ColorD 虫性2_虫鎌節CD;

		public ColorD 傷X1CD;

		public ColorD 傷I1CD;

		public ColorD 傷I2CD;

		public ColorD ハイライトCD;

		public ColorD グロ\u30FCブ_グロ\u30FCブCD;

		public ColorD グロ\u30FCブ_縁CD;

		public ColorD 鎧_ベルト_ベルト1CD;

		public ColorD 鎧_ベルト_ベルト2CD;

		public ColorD 鎧_鎧_鎧2CD;

		public ColorD 鎧_鎧_鎧1CD;

		public ColorD 腕輪_革CD;

		public ColorD 腕輪_金具1CD;

		public ColorD 腕輪_金具2CD;

		public ColorD 腕輪_金具3CD;

		public ColorD 腕輪_金具左CD;

		public ColorD 腕輪_金具右CD;

		public ColorP X0Y0_下腕CP;

		public ColorP X0Y0_筋肉_筋肉下CP;

		public ColorP X0Y0_筋肉_筋肉上CP;

		public ColorP X0Y0_植性1_通常_花弁_花弁CP;

		public ColorP X0Y0_植性1_通常_花弁_影_花弁影1CP;

		public ColorP X0Y0_植性1_通常_花弁_影_花弁影2CP;

		public ColorP X0Y0_植性1_通常_花弁_影_花弁影3CP;

		public ColorP X0Y0_植性1_通常_花弁_影_花弁影4CP;

		public ColorP X0Y0_植性1_通常_花弁_影_花弁影5CP;

		public ColorP X0Y0_植性1_欠損_花弁_花弁CP;

		public ColorP X0Y0_植性1_欠損_花弁_影_花弁影1CP;

		public ColorP X0Y0_植性1_欠損_花弁_影_花弁影2CP;

		public ColorP X0Y0_植性1_欠損_花弁_影_花弁影3CP;

		public ColorP X0Y0_植性1_欠損_花弁_影_花弁影4CP;

		public ColorP X0Y0_植性1_欠損_花弁_影_花弁影5CP;

		public ColorP X0Y0_獣性1_獣腕CP;

		public ColorP X0Y0_竜性1_肘_肘1CP;

		public ColorP X0Y0_竜性1_肘_肘2CP;

		public ColorP X0Y0_竜性1_鱗_鱗5CP;

		public ColorP X0Y0_竜性1_鱗_鱗4CP;

		public ColorP X0Y0_竜性1_鱗_鱗3CP;

		public ColorP X0Y0_竜性1_鱗_鱗2CP;

		public ColorP X0Y0_竜性1_鱗_鱗1CP;

		public ColorP X0Y0_竜性1_手首_鱗3CP;

		public ColorP X0Y0_竜性1_手首_鱗2CP;

		public ColorP X0Y0_竜性1_手首_鱗1CP;

		public ColorP X0Y0_虫性1_虫肘CP;

		public ColorP X0Y0_虫性1_虫腕上CP;

		public ColorP X0Y0_淫タトゥ_手首_タトゥCP;

		public ColorP X0Y0_淫タトゥ_手首_ハ\u30FCト1_タトゥ左CP;

		public ColorP X0Y0_淫タトゥ_手首_ハ\u30FCト1_タトゥ右CP;

		public ColorP X0Y0_淫タトゥ_手首_ハ\u30FCト3_タトゥ左CP;

		public ColorP X0Y0_淫タトゥ_手首_ハ\u30FCト3_タトゥ右CP;

		public ColorP X0Y0_淫タトゥ_手首_ハ\u30FCト2_タトゥ左CP;

		public ColorP X0Y0_淫タトゥ_手首_ハ\u30FCト2_タトゥ右CP;

		public ColorP X0Y0_淫タトゥ_通常_ハ\u30FCト1_タトゥ左CP;

		public ColorP X0Y0_淫タトゥ_通常_ハ\u30FCト1_タトゥ右CP;

		public ColorP X0Y0_淫タトゥ_通常_ハ\u30FCト2_タトゥ左CP;

		public ColorP X0Y0_淫タトゥ_通常_ハ\u30FCト2_タトゥ右CP;

		public ColorP X0Y0_淫タトゥ_筋肉_ハ\u30FCト1_タトゥ左CP;

		public ColorP X0Y0_淫タトゥ_筋肉_ハ\u30FCト1_タトゥ右CP;

		public ColorP X0Y0_淫タトゥ_筋肉_ハ\u30FCト2_タトゥ左CP;

		public ColorP X0Y0_淫タトゥ_筋肉_ハ\u30FCト2_タトゥ右CP;

		public ColorP X0Y0_悪タトゥ_通常_文字1_文字a_枠CP;

		public ColorP X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_通常_文字1_文字a_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_通常_文字1_文字b_枠CP;

		public ColorP X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_通常_文字1_文字b_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_通常_文字1_文字c_枠CP;

		public ColorP X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_通常_文字1_文字c_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_通常_文字1_文字d_枠CP;

		public ColorP X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_通常_文字1_文字d_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_通常_文字1_文字e_枠CP;

		public ColorP X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_通常_文字1_文字e_文字タトゥ3CP;

		public ColorP X0Y0_悪タトゥ_通常_文字2_文字a_枠CP;

		public ColorP X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_通常_文字2_文字b_枠CP;

		public ColorP X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_通常_文字2_文字c_枠CP;

		public ColorP X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_通常_文字2_文字d_枠CP;

		public ColorP X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_通常_文字2_文字e_枠CP;

		public ColorP X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ3CP;

		public ColorP X0Y0_悪タトゥ_通常_タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_通常_タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_通常_逆十字_逆十字1CP;

		public ColorP X0Y0_悪タトゥ_通常_逆十字_逆十字2CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字a_枠CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字b_枠CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字c_枠CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字d_枠CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字e_枠CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ3CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字a_枠CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字b_枠CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字c_枠CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字d_枠CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字e_枠CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ3CP;

		public ColorP X0Y0_悪タトゥ_筋肉_タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_筋肉_タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_筋肉_逆十字_逆十字1CP;

		public ColorP X0Y0_悪タトゥ_筋肉_逆十字_逆十字2CP;

		public ColorP X0Y0_植性2_通常_萼_萼上CP;

		public ColorP X0Y0_植性2_通常_萼_萼下CP;

		public ColorP X0Y0_植性2_通常_萼_萼中CP;

		public ColorP X0Y0_植性2_欠損_萼_萼上CP;

		public ColorP X0Y0_植性2_欠損_萼_萼下CP;

		public ColorP X0Y0_植性2_欠損_萼_萼中CP;

		public ColorP X0Y0_獣性2_獣毛CP;

		public ColorP X0Y0_竜性2_棘_棘5CP;

		public ColorP X0Y0_竜性2_棘_棘4CP;

		public ColorP X0Y0_竜性2_棘_棘3CP;

		public ColorP X0Y0_竜性2_棘_棘2CP;

		public ColorP X0Y0_竜性2_棘_棘1CP;

		public ColorP X0Y0_虫性2_虫腕下CP;

		public ColorP X0Y0_虫性2_虫棘1CP;

		public ColorP X0Y0_虫性2_虫棘2CP;

		public ColorP X0Y0_虫性2_虫棘3CP;

		public ColorP X0Y0_虫性2_虫棘4CP;

		public ColorP X0Y0_虫性2_虫鎌節CP;

		public ColorP X0Y0_傷X1CP;

		public ColorP X0Y0_傷I1CP;

		public ColorP X0Y0_傷I2CP;

		public ColorP X0Y0_ハイライトCP;

		public ColorP X0Y0_グロ\u30FCブ_通常_グロ\u30FCブCP;

		public ColorP X0Y0_グロ\u30FCブ_通常_縁CP;

		public ColorP X0Y0_グロ\u30FCブ_筋肉_グロ\u30FCブCP;

		public ColorP X0Y0_グロ\u30FCブ_筋肉_縁CP;

		public ColorP X0Y0_鎧_ベルト_ベルト1CP;

		public ColorP X0Y0_鎧_ベルト_通常_ベルト2CP;

		public ColorP X0Y0_鎧_ベルト_筋肉_ベルト2CP;

		public ColorP X0Y0_鎧_鎧_鎧2CP;

		public ColorP X0Y0_鎧_鎧_鎧1CP;

		public ColorP X0Y0_腕輪_革CP;

		public ColorP X0Y0_腕輪_金具1CP;

		public ColorP X0Y0_腕輪_金具2CP;

		public ColorP X0Y0_腕輪_金具3CP;

		public ColorP X0Y0_腕輪_金具左CP;

		public ColorP X0Y0_腕輪_金具右CP;

		public 拘束鎖 鎖1;

		public スタンプK キスマ\u30FCク;

		public スタンプW 鞭痕;

		public Ele[] 外腕_接続;

		public Ele[] 虫鎌_接続;
	}
}
