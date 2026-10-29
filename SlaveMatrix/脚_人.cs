using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 脚_人 : 脚
	{
		public 脚_人(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 脚_人D e)
		{
			脚_人.<>c__DisplayClass992_0 CS$<>8__locals1 = new 脚_人.<>c__DisplayClass992_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.脚左["脚"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_脚 = pars["脚"].ToPar();
			this.X0Y0_筋 = pars["筋"].ToPar();
			Pars pars2 = pars["淫タトゥ"].ToPars();
			Pars pars3 = pars2["足首"].ToPars();
			this.X0Y0_淫タトゥ_足首_タトゥ = pars3["タトゥ"].ToPar();
			Pars pars4 = pars3["ハート1"].ToPars();
			this.X0Y0_淫タトゥ_足首_ハ\u30FCト1_タトゥ左 = pars4["タトゥ左"].ToPar();
			this.X0Y0_淫タトゥ_足首_ハ\u30FCト1_タトゥ右 = pars4["タトゥ右"].ToPar();
			pars4 = pars3["ハート3"].ToPars();
			this.X0Y0_淫タトゥ_足首_ハ\u30FCト3_タトゥ左 = pars4["タトゥ左"].ToPar();
			this.X0Y0_淫タトゥ_足首_ハ\u30FCト3_タトゥ右 = pars4["タトゥ右"].ToPar();
			pars4 = pars3["ハート2"].ToPars();
			this.X0Y0_淫タトゥ_足首_ハ\u30FCト2_タトゥ左 = pars4["タトゥ左"].ToPar();
			this.X0Y0_淫タトゥ_足首_ハ\u30FCト2_タトゥ右 = pars4["タトゥ右"].ToPar();
			pars3 = pars2["ハート"].ToPars();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左 = pars3["タトゥ左"].ToPar();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右 = pars3["タトゥ右"].ToPar();
			this.X0Y0_淫タトゥ_タトゥ左 = pars2["タトゥ左"].ToPar();
			this.X0Y0_淫タトゥ_タトゥ右 = pars2["タトゥ右"].ToPar();
			pars2 = pars["悪タトゥ"].ToPars();
			pars3 = pars2["文字1"].ToPars();
			pars4 = pars3["文字a"].ToPars();
			this.X0Y0_悪タトゥ_文字1_文字a_枠 = pars4["枠"].ToPar();
			this.X0Y0_悪タトゥ_文字1_文字a_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_文字1_文字a_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字b"].ToPars();
			this.X0Y0_悪タトゥ_文字1_文字b_枠 = pars4["枠"].ToPar();
			this.X0Y0_悪タトゥ_文字1_文字b_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_文字1_文字b_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字c"].ToPars();
			this.X0Y0_悪タトゥ_文字1_文字c_枠 = pars4["枠"].ToPar();
			this.X0Y0_悪タトゥ_文字1_文字c_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_文字1_文字c_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字d"].ToPars();
			this.X0Y0_悪タトゥ_文字1_文字d_枠 = pars4["枠"].ToPar();
			this.X0Y0_悪タトゥ_文字1_文字d_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_文字1_文字d_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字e"].ToPars();
			this.X0Y0_悪タトゥ_文字1_文字e_枠 = pars4["枠"].ToPar();
			this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ3 = pars4["文字タトゥ3"].ToPar();
			pars3 = pars2["文字2"].ToPars();
			pars4 = pars3["文字a"].ToPars();
			this.X0Y0_悪タトゥ_文字2_文字a_枠 = pars4["枠"].ToPar();
			this.X0Y0_悪タトゥ_文字2_文字a_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_文字2_文字a_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字b"].ToPars();
			this.X0Y0_悪タトゥ_文字2_文字b_枠 = pars4["枠"].ToPar();
			this.X0Y0_悪タトゥ_文字2_文字b_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_文字2_文字b_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字c"].ToPars();
			this.X0Y0_悪タトゥ_文字2_文字c_枠 = pars4["枠"].ToPar();
			this.X0Y0_悪タトゥ_文字2_文字c_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_文字2_文字c_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字d"].ToPars();
			this.X0Y0_悪タトゥ_文字2_文字d_枠 = pars4["枠"].ToPar();
			this.X0Y0_悪タトゥ_文字2_文字d_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_文字2_文字d_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字e"].ToPars();
			this.X0Y0_悪タトゥ_文字2_文字e_枠 = pars4["枠"].ToPar();
			this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ3 = pars4["文字タトゥ3"].ToPar();
			this.X0Y0_悪タトゥ_タトゥ1 = pars2["タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_タトゥ2 = pars2["タトゥ2"].ToPar();
			pars3 = pars2["逆十字"].ToPars();
			this.X0Y0_悪タトゥ_逆十字_逆十字1 = pars3["逆十字1"].ToPar();
			this.X0Y0_悪タトゥ_逆十字_逆十字2 = pars3["逆十字2"].ToPar();
			this.X0Y0_悪タトゥ_タトゥ左 = pars2["タトゥ左"].ToPar();
			this.X0Y0_悪タトゥ_タトゥ右 = pars2["タトゥ右"].ToPar();
			pars2 = pars["紋柄"].ToPars();
			this.X0Y0_紋柄_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_紋柄_紋2 = pars2["紋2"].ToPar();
			this.X0Y0_紋柄_紋3 = pars2["紋3"].ToPar();
			this.X0Y0_紋柄_紋4 = pars2["紋4"].ToPar();
			pars2 = pars["獣性"].ToPars();
			this.X0Y0_獣性_獣毛1 = pars2["獣毛1"].ToPar();
			this.X0Y0_獣性_獣毛2 = pars2["獣毛2"].ToPar();
			this.X0Y0_獣性_獣毛3 = pars2["獣毛3"].ToPar();
			this.X0Y0_獣性_獣毛4 = pars2["獣毛4"].ToPar();
			this.X0Y0_獣性_獣毛5 = pars2["獣毛5"].ToPar();
			pars2 = pars["竜性"].ToPars();
			pars3 = pars2["鱗"].ToPars();
			this.X0Y0_竜性_鱗_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_竜性_鱗_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_竜性_鱗_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_竜性_鱗_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_竜性_鱗_鱗5 = pars3["鱗5"].ToPar();
			this.X0Y0_竜性_鱗_鱗6 = pars3["鱗6"].ToPar();
			this.X0Y0_竜性_鱗_鱗7 = pars3["鱗7"].ToPar();
			pars3 = pars2["刺"].ToPars();
			this.X0Y0_竜性_棘_棘1 = pars3["刺1"].ToPar();
			this.X0Y0_竜性_棘_棘2 = pars3["刺2"].ToPar();
			this.X0Y0_竜性_棘_棘3 = pars3["刺3"].ToPar();
			this.X0Y0_竜性_棘_棘4 = pars3["刺4"].ToPar();
			this.X0Y0_竜性_棘_棘5 = pars3["刺5"].ToPar();
			this.X0Y0_竜性_棘_棘6 = pars3["刺6"].ToPar();
			pars2 = pars["虫性"].ToPars();
			pars3 = pars2["刺"].ToPars();
			this.X0Y0_虫性_棘_棘1 = pars3["刺1"].ToPar();
			this.X0Y0_虫性_棘_棘2 = pars3["刺2"].ToPar();
			this.X0Y0_虫性_棘_棘3 = pars3["刺3"].ToPar();
			this.X0Y0_虫性_膝 = pars2["膝"].ToPar();
			this.X0Y0_虫性_線 = pars2["線"].ToPar();
			this.X0Y0_傷X1 = pars["傷X1"].ToPar();
			this.X0Y0_傷X2 = pars["傷X2"].ToPar();
			this.X0Y0_傷I1 = pars["傷I1"].ToPar();
			this.X0Y0_傷I2 = pars["傷I2"].ToPar();
			this.X0Y0_傷I3 = pars["傷I3"].ToPar();
			this.X0Y0_傷I4 = pars["傷I4"].ToPar();
			this.X0Y0_傷I5 = pars["傷I5"].ToPar();
			this.X0Y0_ハイライト1 = pars["ハイライト1"].ToPar();
			this.X0Y0_ハイライト2 = pars["ハイライト2"].ToPar();
			pars2 = pars["パンスト"].ToPars();
			this.X0Y0_パンスト_パンスト = pars2["パンスト"].ToPar();
			this.X0Y0_パンスト_ハイライト1 = pars2["ハイライト1"].ToPar();
			this.X0Y0_パンスト_ハイライト2 = pars2["ハイライト2"].ToPar();
			pars2 = pars["ソックス"].ToPars();
			this.X0Y0_ソックス_ソックス = pars2["ソックス"].ToPar();
			this.X0Y0_ソックス_ハイライト1 = pars2["ハイライト1"].ToPar();
			this.X0Y0_ソックス_ハイライト2 = pars2["ハイライト2"].ToPar();
			pars2 = pars["ブーツ"].ToPars();
			pars3 = pars2["タン"].ToPars();
			this.X0Y0_ブ\u30FCツ_タン_タン = pars3["タン"].ToPar();
			pars4 = pars3["縁"].ToPars();
			this.X0Y0_ブ\u30FCツ_タン_縁_縁1 = pars4["縁1"].ToPar();
			this.X0Y0_ブ\u30FCツ_タン_縁_縁2 = pars4["縁2"].ToPar();
			pars3 = pars2["ブーツ"].ToPars();
			this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツ = pars3["ブーツ"].ToPar();
			pars4 = pars3["皺"].ToPars();
			this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_皺_皺1 = pars4["皺1"].ToPar();
			this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_皺_皺2 = pars4["皺2"].ToPar();
			pars4 = pars3["縁"].ToPars();
			this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁1 = pars4["縁1"].ToPar();
			this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁2 = pars4["縁2"].ToPar();
			this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁3 = pars4["縁3"].ToPar();
			this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁4 = pars4["縁4"].ToPar();
			this.X0Y0_ブ\u30FCツ_柄 = pars2["柄"].ToPar();
			pars3 = pars2["紐"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_紐 = pars3["紐"].ToPar();
			pars4 = pars3["紐1"].ToPars();
			Pars pars5 = pars4["紐下"].ToPars();
			Pars pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐2"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐3"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐4"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐5"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐6"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐7"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐8"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐9"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐10"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐11"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["結び"].ToPars();
			pars5 = pars4["紐左"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐3 = pars5["紐3"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐2 = pars5["紐2"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐1 = pars5["紐1"].ToPar();
			pars5 = pars4["紐右"].ToPars();
			this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐3 = pars5["紐3"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐2 = pars5["紐2"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐1 = pars5["紐1"].ToPar();
			this.X0Y0_ブ\u30FCツ_紐_結び_結び目 = pars4["結び目"].ToPar();
			pars2 = pars["アーマ"].ToPars();
			this.X0Y0_ア\u30FCマ_ベ\u30FCス = pars2["ベース"].ToPar();
			pars3 = pars2["脛当"].ToPars();
			this.X0Y0_ア\u30FCマ_脛当_脛当1 = pars3["脛当1"].ToPar();
			this.X0Y0_ア\u30FCマ_脛当_脛当2 = pars3["脛当2"].ToPar();
			this.X0Y0_ア\u30FCマ_膝当 = pars2["膝当"].ToPar();
			pars3 = pars2["穴"].ToPars();
			this.X0Y0_ア\u30FCマ_穴_穴1 = pars3["穴1"].ToPar();
			this.X0Y0_ア\u30FCマ_穴_穴2 = pars3["穴2"].ToPar();
			this.X0Y0_ア\u30FCマ_穴_穴3 = pars3["穴3"].ToPar();
			this.X0Y0_ア\u30FCマ_穴_穴4 = pars3["穴4"].ToPar();
			pars2 = pars["脚輪上"].ToPars();
			this.X0Y0_脚輪上_革 = pars2["革"].ToPar();
			this.X0Y0_脚輪上_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_脚輪上_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_脚輪上_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_脚輪上_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_脚輪上_金具右 = pars2["金具右"].ToPar();
			pars2 = pars["脚輪下"].ToPars();
			this.X0Y0_脚輪下_革 = pars2["革"].ToPar();
			this.X0Y0_脚輪下_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_脚輪下_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_脚輪下_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_脚輪下_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_脚輪下_金具右 = pars2["金具右"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_脚 = pars["脚"].ToPar();
			this.X0Y1_筋 = pars["筋"].ToPar();
			pars2 = pars["淫タトゥ"].ToPars();
			pars3 = pars2["足首"].ToPars();
			this.X0Y1_淫タトゥ_足首_タトゥ = pars3["タトゥ"].ToPar();
			pars4 = pars3["ハート1"].ToPars();
			this.X0Y1_淫タトゥ_足首_ハ\u30FCト1_タトゥ左 = pars4["タトゥ左"].ToPar();
			this.X0Y1_淫タトゥ_足首_ハ\u30FCト1_タトゥ右 = pars4["タトゥ右"].ToPar();
			pars4 = pars3["ハート3"].ToPars();
			this.X0Y1_淫タトゥ_足首_ハ\u30FCト3_タトゥ左 = pars4["タトゥ左"].ToPar();
			this.X0Y1_淫タトゥ_足首_ハ\u30FCト3_タトゥ右 = pars4["タトゥ右"].ToPar();
			pars4 = pars3["ハート2"].ToPars();
			this.X0Y1_淫タトゥ_足首_ハ\u30FCト2_タトゥ左 = pars4["タトゥ左"].ToPar();
			this.X0Y1_淫タトゥ_足首_ハ\u30FCト2_タトゥ右 = pars4["タトゥ右"].ToPar();
			pars3 = pars2["ハート"].ToPars();
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左 = pars3["タトゥ左"].ToPar();
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右 = pars3["タトゥ右"].ToPar();
			this.X0Y1_淫タトゥ_タトゥ左 = pars2["タトゥ左"].ToPar();
			this.X0Y1_淫タトゥ_タトゥ右 = pars2["タトゥ右"].ToPar();
			pars2 = pars["悪タトゥ"].ToPars();
			pars3 = pars2["文字1"].ToPars();
			pars4 = pars3["文字a"].ToPars();
			this.X0Y1_悪タトゥ_文字1_文字a_枠 = pars4["枠"].ToPar();
			this.X0Y1_悪タトゥ_文字1_文字a_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y1_悪タトゥ_文字1_文字a_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字b"].ToPars();
			this.X0Y1_悪タトゥ_文字1_文字b_枠 = pars4["枠"].ToPar();
			this.X0Y1_悪タトゥ_文字1_文字b_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y1_悪タトゥ_文字1_文字b_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字c"].ToPars();
			this.X0Y1_悪タトゥ_文字1_文字c_枠 = pars4["枠"].ToPar();
			this.X0Y1_悪タトゥ_文字1_文字c_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y1_悪タトゥ_文字1_文字c_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字d"].ToPars();
			this.X0Y1_悪タトゥ_文字1_文字d_枠 = pars4["枠"].ToPar();
			this.X0Y1_悪タトゥ_文字1_文字d_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y1_悪タトゥ_文字1_文字d_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字e"].ToPars();
			this.X0Y1_悪タトゥ_文字1_文字e_枠 = pars4["枠"].ToPar();
			this.X0Y1_悪タトゥ_文字1_文字e_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y1_悪タトゥ_文字1_文字e_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			this.X0Y1_悪タトゥ_文字1_文字e_文字タトゥ3 = pars4["文字タトゥ3"].ToPar();
			pars3 = pars2["文字2"].ToPars();
			pars4 = pars3["文字a"].ToPars();
			this.X0Y1_悪タトゥ_文字2_文字a_枠 = pars4["枠"].ToPar();
			this.X0Y1_悪タトゥ_文字2_文字a_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y1_悪タトゥ_文字2_文字a_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字b"].ToPars();
			this.X0Y1_悪タトゥ_文字2_文字b_枠 = pars4["枠"].ToPar();
			this.X0Y1_悪タトゥ_文字2_文字b_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y1_悪タトゥ_文字2_文字b_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字c"].ToPars();
			this.X0Y1_悪タトゥ_文字2_文字c_枠 = pars4["枠"].ToPar();
			this.X0Y1_悪タトゥ_文字2_文字c_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y1_悪タトゥ_文字2_文字c_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字d"].ToPars();
			this.X0Y1_悪タトゥ_文字2_文字d_枠 = pars4["枠"].ToPar();
			this.X0Y1_悪タトゥ_文字2_文字d_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y1_悪タトゥ_文字2_文字d_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字e"].ToPars();
			this.X0Y1_悪タトゥ_文字2_文字e_枠 = pars4["枠"].ToPar();
			this.X0Y1_悪タトゥ_文字2_文字e_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y1_悪タトゥ_文字2_文字e_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			this.X0Y1_悪タトゥ_文字2_文字e_文字タトゥ3 = pars4["文字タトゥ3"].ToPar();
			this.X0Y1_悪タトゥ_タトゥ1 = pars2["タトゥ1"].ToPar();
			this.X0Y1_悪タトゥ_タトゥ2 = pars2["タトゥ2"].ToPar();
			pars3 = pars2["逆十字"].ToPars();
			this.X0Y1_悪タトゥ_逆十字_逆十字1 = pars3["逆十字1"].ToPar();
			this.X0Y1_悪タトゥ_逆十字_逆十字2 = pars3["逆十字2"].ToPar();
			this.X0Y1_悪タトゥ_タトゥ左 = pars2["タトゥ左"].ToPar();
			this.X0Y1_悪タトゥ_タトゥ右 = pars2["タトゥ右"].ToPar();
			pars2 = pars["紋柄"].ToPars();
			this.X0Y1_紋柄_紋1 = pars2["紋1"].ToPar();
			this.X0Y1_紋柄_紋2 = pars2["紋2"].ToPar();
			this.X0Y1_紋柄_紋3 = pars2["紋3"].ToPar();
			this.X0Y1_紋柄_紋4 = pars2["紋4"].ToPar();
			pars2 = pars["獣性"].ToPars();
			this.X0Y1_獣性_獣毛1 = pars2["獣毛1"].ToPar();
			this.X0Y1_獣性_獣毛2 = pars2["獣毛2"].ToPar();
			this.X0Y1_獣性_獣毛3 = pars2["獣毛3"].ToPar();
			this.X0Y1_獣性_獣毛4 = pars2["獣毛4"].ToPar();
			this.X0Y1_獣性_獣毛5 = pars2["獣毛5"].ToPar();
			pars2 = pars["竜性"].ToPars();
			pars3 = pars2["鱗"].ToPars();
			this.X0Y1_竜性_鱗_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y1_竜性_鱗_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y1_竜性_鱗_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y1_竜性_鱗_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y1_竜性_鱗_鱗5 = pars3["鱗5"].ToPar();
			this.X0Y1_竜性_鱗_鱗6 = pars3["鱗6"].ToPar();
			this.X0Y1_竜性_鱗_鱗7 = pars3["鱗7"].ToPar();
			pars3 = pars2["刺"].ToPars();
			this.X0Y1_竜性_棘_棘1 = pars3["刺1"].ToPar();
			this.X0Y1_竜性_棘_棘2 = pars3["刺2"].ToPar();
			this.X0Y1_竜性_棘_棘3 = pars3["刺3"].ToPar();
			this.X0Y1_竜性_棘_棘4 = pars3["刺4"].ToPar();
			this.X0Y1_竜性_棘_棘5 = pars3["刺5"].ToPar();
			this.X0Y1_竜性_棘_棘6 = pars3["刺6"].ToPar();
			pars2 = pars["虫性"].ToPars();
			pars3 = pars2["刺"].ToPars();
			this.X0Y1_虫性_棘_棘1 = pars3["刺1"].ToPar();
			this.X0Y1_虫性_棘_棘2 = pars3["刺2"].ToPar();
			this.X0Y1_虫性_棘_棘3 = pars3["刺3"].ToPar();
			this.X0Y1_虫性_膝 = pars2["膝"].ToPar();
			this.X0Y1_虫性_線 = pars2["線"].ToPar();
			this.X0Y1_傷X1 = pars["傷X1"].ToPar();
			this.X0Y1_傷X2 = pars["傷X2"].ToPar();
			this.X0Y1_傷I1 = pars["傷I1"].ToPar();
			this.X0Y1_傷I2 = pars["傷I2"].ToPar();
			this.X0Y1_傷I3 = pars["傷I3"].ToPar();
			this.X0Y1_傷I4 = pars["傷I4"].ToPar();
			this.X0Y1_傷I5 = pars["傷I5"].ToPar();
			this.X0Y1_ハイライト1 = pars["ハイライト1"].ToPar();
			this.X0Y1_ハイライト2 = pars["ハイライト2"].ToPar();
			pars2 = pars["パンスト"].ToPars();
			this.X0Y1_パンスト_パンスト = pars2["パンスト"].ToPar();
			this.X0Y1_パンスト_ハイライト1 = pars2["ハイライト1"].ToPar();
			this.X0Y1_パンスト_ハイライト2 = pars2["ハイライト2"].ToPar();
			pars2 = pars["ソックス"].ToPars();
			this.X0Y1_ソックス_ソックス = pars2["ソックス"].ToPar();
			this.X0Y1_ソックス_ハイライト1 = pars2["ハイライト1"].ToPar();
			this.X0Y1_ソックス_ハイライト2 = pars2["ハイライト2"].ToPar();
			pars2 = pars["ブーツ"].ToPars();
			pars3 = pars2["タン"].ToPars();
			this.X0Y1_ブ\u30FCツ_タン_タン = pars3["タン"].ToPar();
			pars4 = pars3["縁"].ToPars();
			this.X0Y1_ブ\u30FCツ_タン_縁_縁1 = pars4["縁1"].ToPar();
			this.X0Y1_ブ\u30FCツ_タン_縁_縁2 = pars4["縁2"].ToPar();
			pars3 = pars2["ブーツ"].ToPars();
			this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツ = pars3["ブーツ"].ToPar();
			pars4 = pars3["皺"].ToPars();
			this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_皺_皺1 = pars4["皺1"].ToPar();
			this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_皺_皺2 = pars4["皺2"].ToPar();
			pars4 = pars3["縁"].ToPars();
			this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁1 = pars4["縁1"].ToPar();
			this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁2 = pars4["縁2"].ToPar();
			this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁3 = pars4["縁3"].ToPar();
			this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁4 = pars4["縁4"].ToPar();
			this.X0Y1_ブ\u30FCツ_柄 = pars2["柄"].ToPar();
			pars3 = pars2["紐"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_紐 = pars3["紐"].ToPar();
			pars4 = pars3["紐1"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐2"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐3"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐4"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐5"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐6"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐7"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐8"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐9"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐10"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["紐11"].ToPars();
			pars5 = pars4["紐下"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_紐 = pars5["紐"].ToPar();
			pars5 = pars4["紐上"].ToPars();
			pars6 = pars5["金具上"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_金具上_金具 = pars6["金具"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_金具上_穴 = pars6["穴"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_紐 = pars5["紐"].ToPar();
			pars4 = pars3["結び"].ToPars();
			pars5 = pars4["紐左"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐3 = pars5["紐3"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐2 = pars5["紐2"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐1 = pars5["紐1"].ToPar();
			pars5 = pars4["紐右"].ToPars();
			this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐3 = pars5["紐3"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐2 = pars5["紐2"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐1 = pars5["紐1"].ToPar();
			this.X0Y1_ブ\u30FCツ_紐_結び_結び目 = pars4["結び目"].ToPar();
			pars2 = pars["アーマ"].ToPars();
			this.X0Y1_ア\u30FCマ_ベ\u30FCス = pars2["ベース"].ToPar();
			pars3 = pars2["脛当"].ToPars();
			this.X0Y1_ア\u30FCマ_脛当_脛当1 = pars3["脛当1"].ToPar();
			this.X0Y1_ア\u30FCマ_脛当_脛当2 = pars3["脛当2"].ToPar();
			this.X0Y1_ア\u30FCマ_膝当 = pars2["膝当"].ToPar();
			pars3 = pars2["穴"].ToPars();
			this.X0Y1_ア\u30FCマ_穴_穴1 = pars3["穴1"].ToPar();
			this.X0Y1_ア\u30FCマ_穴_穴2 = pars3["穴2"].ToPar();
			this.X0Y1_ア\u30FCマ_穴_穴3 = pars3["穴3"].ToPar();
			this.X0Y1_ア\u30FCマ_穴_穴4 = pars3["穴4"].ToPar();
			pars2 = pars["脚輪上"].ToPars();
			this.X0Y1_脚輪上_革 = pars2["革"].ToPar();
			this.X0Y1_脚輪上_金具1 = pars2["金具1"].ToPar();
			this.X0Y1_脚輪上_金具2 = pars2["金具2"].ToPar();
			this.X0Y1_脚輪上_金具3 = pars2["金具3"].ToPar();
			this.X0Y1_脚輪上_金具左 = pars2["金具左"].ToPar();
			this.X0Y1_脚輪上_金具右 = pars2["金具右"].ToPar();
			pars2 = pars["脚輪下"].ToPars();
			this.X0Y1_脚輪下_革 = pars2["革"].ToPar();
			this.X0Y1_脚輪下_金具1 = pars2["金具1"].ToPar();
			this.X0Y1_脚輪下_金具2 = pars2["金具2"].ToPar();
			this.X0Y1_脚輪下_金具3 = pars2["金具3"].ToPar();
			this.X0Y1_脚輪下_金具左 = pars2["金具左"].ToPar();
			this.X0Y1_脚輪下_金具右 = pars2["金具右"].ToPar();
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
			this.脚_表示 = e.脚_表示;
			this.筋_表示 = e.筋_表示;
			this.淫タトゥ_足首_タトゥ_表示 = e.淫タトゥ_足首_タトゥ_表示;
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ左_表示 = e.淫タトゥ_足首_ハ\u30FCト1_タトゥ左_表示;
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ右_表示 = e.淫タトゥ_足首_ハ\u30FCト1_タトゥ右_表示;
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ左_表示 = e.淫タトゥ_足首_ハ\u30FCト3_タトゥ左_表示;
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ右_表示 = e.淫タトゥ_足首_ハ\u30FCト3_タトゥ右_表示;
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ左_表示 = e.淫タトゥ_足首_ハ\u30FCト2_タトゥ左_表示;
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ右_表示 = e.淫タトゥ_足首_ハ\u30FCト2_タトゥ右_表示;
			this.淫タトゥ_ハ\u30FCト_タトゥ左_表示 = e.淫タトゥ_ハ\u30FCト_タトゥ左_表示;
			this.淫タトゥ_ハ\u30FCト_タトゥ右_表示 = e.淫タトゥ_ハ\u30FCト_タトゥ右_表示;
			this.淫タトゥ_タトゥ左_表示 = e.淫タトゥ_タトゥ左_表示;
			this.淫タトゥ_タトゥ右_表示 = e.淫タトゥ_タトゥ右_表示;
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
			this.悪タトゥ_タトゥ左_表示 = e.悪タトゥ_タトゥ左_表示;
			this.悪タトゥ_タトゥ右_表示 = e.悪タトゥ_タトゥ右_表示;
			this.紋柄_紋1_表示 = e.紋柄_紋1_表示;
			this.紋柄_紋2_表示 = e.紋柄_紋2_表示;
			this.紋柄_紋3_表示 = e.紋柄_紋3_表示;
			this.紋柄_紋4_表示 = e.紋柄_紋4_表示;
			this.獣性_獣毛1_表示 = e.獣性_獣毛1_表示;
			this.獣性_獣毛2_表示 = e.獣性_獣毛2_表示;
			this.獣性_獣毛3_表示 = e.獣性_獣毛3_表示;
			this.獣性_獣毛4_表示 = e.獣性_獣毛4_表示;
			this.獣性_獣毛5_表示 = e.獣性_獣毛5_表示;
			this.竜性_鱗_鱗1_表示 = e.竜性_鱗_鱗1_表示;
			this.竜性_鱗_鱗2_表示 = e.竜性_鱗_鱗2_表示;
			this.竜性_鱗_鱗3_表示 = e.竜性_鱗_鱗3_表示;
			this.竜性_鱗_鱗4_表示 = e.竜性_鱗_鱗4_表示;
			this.竜性_鱗_鱗5_表示 = e.竜性_鱗_鱗5_表示;
			this.竜性_鱗_鱗6_表示 = e.竜性_鱗_鱗6_表示;
			this.竜性_鱗_鱗7_表示 = e.竜性_鱗_鱗7_表示;
			this.竜性_棘_棘1_表示 = e.竜性_棘_棘1_表示;
			this.竜性_棘_棘2_表示 = e.竜性_棘_棘2_表示;
			this.竜性_棘_棘3_表示 = e.竜性_棘_棘3_表示;
			this.竜性_棘_棘4_表示 = e.竜性_棘_棘4_表示;
			this.竜性_棘_棘5_表示 = e.竜性_棘_棘5_表示;
			this.竜性_棘_棘6_表示 = e.竜性_棘_棘6_表示;
			this.虫性_棘_棘1_表示 = e.虫性_棘_棘1_表示;
			this.虫性_棘_棘2_表示 = e.虫性_棘_棘2_表示;
			this.虫性_棘_棘3_表示 = e.虫性_棘_棘3_表示;
			this.虫性_膝_表示 = e.虫性_膝_表示;
			this.虫性_線_表示 = e.虫性_線_表示;
			this.傷X1_表示 = e.傷X1_表示;
			this.傷X2_表示 = e.傷X2_表示;
			this.傷I1_表示 = e.傷I1_表示;
			this.傷I2_表示 = e.傷I2_表示;
			this.傷I3_表示 = e.傷I3_表示;
			this.傷I4_表示 = e.傷I4_表示;
			this.傷I5_表示 = e.傷I5_表示;
			this.ハイライト1_表示 = e.ハイライト1_表示;
			this.ハイライト2_表示 = e.ハイライト2_表示;
			this.パンスト_パンスト_表示 = e.パンスト_パンスト_表示;
			this.パンスト_ハイライト1_表示 = e.パンスト_ハイライト1_表示;
			this.パンスト_ハイライト2_表示 = e.パンスト_ハイライト2_表示;
			this.ソックス_ソックス_表示 = e.ソックス_ソックス_表示;
			this.ソックス_ハイライト1_表示 = e.ソックス_ハイライト1_表示;
			this.ソックス_ハイライト2_表示 = e.ソックス_ハイライト2_表示;
			this.ブ\u30FCツ_タン_タン_表示 = e.ブ\u30FCツ_タン_タン_表示;
			this.ブ\u30FCツ_タン_縁_縁1_表示 = e.ブ\u30FCツ_タン_縁_縁1_表示;
			this.ブ\u30FCツ_タン_縁_縁2_表示 = e.ブ\u30FCツ_タン_縁_縁2_表示;
			this.ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツ_表示 = e.ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツ_表示;
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺1_表示 = e.ブ\u30FCツ_ブ\u30FCツ_皺_皺1_表示;
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺2_表示 = e.ブ\u30FCツ_ブ\u30FCツ_皺_皺2_表示;
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁1_表示 = e.ブ\u30FCツ_ブ\u30FCツ_縁_縁1_表示;
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁2_表示 = e.ブ\u30FCツ_ブ\u30FCツ_縁_縁2_表示;
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁3_表示 = e.ブ\u30FCツ_ブ\u30FCツ_縁_縁3_表示;
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁4_表示 = e.ブ\u30FCツ_ブ\u30FCツ_縁_縁4_表示;
			this.ブ\u30FCツ_柄_表示 = e.ブ\u30FCツ_柄_表示;
			this.ブ\u30FCツ_紐_紐_表示 = e.ブ\u30FCツ_紐_紐_表示;
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具_表示 = e.ブ\u30FCツ_紐_紐1_紐下_金具上_金具_表示;
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴_表示 = e.ブ\u30FCツ_紐_紐1_紐下_金具上_穴_表示;
			this.ブ\u30FCツ_紐_紐1_紐下_紐_表示 = e.ブ\u30FCツ_紐_紐1_紐下_紐_表示;
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_金具_表示 = e.ブ\u30FCツ_紐_紐1_紐上_金具上_金具_表示;
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_穴_表示 = e.ブ\u30FCツ_紐_紐1_紐上_金具上_穴_表示;
			this.ブ\u30FCツ_紐_紐1_紐上_紐_表示 = e.ブ\u30FCツ_紐_紐1_紐上_紐_表示;
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_金具_表示 = e.ブ\u30FCツ_紐_紐2_紐下_金具上_金具_表示;
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_穴_表示 = e.ブ\u30FCツ_紐_紐2_紐下_金具上_穴_表示;
			this.ブ\u30FCツ_紐_紐2_紐下_紐_表示 = e.ブ\u30FCツ_紐_紐2_紐下_紐_表示;
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_金具_表示 = e.ブ\u30FCツ_紐_紐2_紐上_金具上_金具_表示;
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_穴_表示 = e.ブ\u30FCツ_紐_紐2_紐上_金具上_穴_表示;
			this.ブ\u30FCツ_紐_紐2_紐上_紐_表示 = e.ブ\u30FCツ_紐_紐2_紐上_紐_表示;
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_金具_表示 = e.ブ\u30FCツ_紐_紐3_紐下_金具上_金具_表示;
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_穴_表示 = e.ブ\u30FCツ_紐_紐3_紐下_金具上_穴_表示;
			this.ブ\u30FCツ_紐_紐3_紐下_紐_表示 = e.ブ\u30FCツ_紐_紐3_紐下_紐_表示;
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_金具_表示 = e.ブ\u30FCツ_紐_紐3_紐上_金具上_金具_表示;
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_穴_表示 = e.ブ\u30FCツ_紐_紐3_紐上_金具上_穴_表示;
			this.ブ\u30FCツ_紐_紐3_紐上_紐_表示 = e.ブ\u30FCツ_紐_紐3_紐上_紐_表示;
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_金具_表示 = e.ブ\u30FCツ_紐_紐4_紐下_金具上_金具_表示;
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_穴_表示 = e.ブ\u30FCツ_紐_紐4_紐下_金具上_穴_表示;
			this.ブ\u30FCツ_紐_紐4_紐下_紐_表示 = e.ブ\u30FCツ_紐_紐4_紐下_紐_表示;
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_金具_表示 = e.ブ\u30FCツ_紐_紐4_紐上_金具上_金具_表示;
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_穴_表示 = e.ブ\u30FCツ_紐_紐4_紐上_金具上_穴_表示;
			this.ブ\u30FCツ_紐_紐4_紐上_紐_表示 = e.ブ\u30FCツ_紐_紐4_紐上_紐_表示;
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_金具_表示 = e.ブ\u30FCツ_紐_紐5_紐下_金具上_金具_表示;
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_穴_表示 = e.ブ\u30FCツ_紐_紐5_紐下_金具上_穴_表示;
			this.ブ\u30FCツ_紐_紐5_紐下_紐_表示 = e.ブ\u30FCツ_紐_紐5_紐下_紐_表示;
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_金具_表示 = e.ブ\u30FCツ_紐_紐5_紐上_金具上_金具_表示;
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_穴_表示 = e.ブ\u30FCツ_紐_紐5_紐上_金具上_穴_表示;
			this.ブ\u30FCツ_紐_紐5_紐上_紐_表示 = e.ブ\u30FCツ_紐_紐5_紐上_紐_表示;
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_金具_表示 = e.ブ\u30FCツ_紐_紐6_紐下_金具上_金具_表示;
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_穴_表示 = e.ブ\u30FCツ_紐_紐6_紐下_金具上_穴_表示;
			this.ブ\u30FCツ_紐_紐6_紐下_紐_表示 = e.ブ\u30FCツ_紐_紐6_紐下_紐_表示;
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_金具_表示 = e.ブ\u30FCツ_紐_紐6_紐上_金具上_金具_表示;
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_穴_表示 = e.ブ\u30FCツ_紐_紐6_紐上_金具上_穴_表示;
			this.ブ\u30FCツ_紐_紐6_紐上_紐_表示 = e.ブ\u30FCツ_紐_紐6_紐上_紐_表示;
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_金具_表示 = e.ブ\u30FCツ_紐_紐7_紐下_金具上_金具_表示;
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_穴_表示 = e.ブ\u30FCツ_紐_紐7_紐下_金具上_穴_表示;
			this.ブ\u30FCツ_紐_紐7_紐下_紐_表示 = e.ブ\u30FCツ_紐_紐7_紐下_紐_表示;
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_金具_表示 = e.ブ\u30FCツ_紐_紐7_紐上_金具上_金具_表示;
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_穴_表示 = e.ブ\u30FCツ_紐_紐7_紐上_金具上_穴_表示;
			this.ブ\u30FCツ_紐_紐7_紐上_紐_表示 = e.ブ\u30FCツ_紐_紐7_紐上_紐_表示;
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_金具_表示 = e.ブ\u30FCツ_紐_紐8_紐下_金具上_金具_表示;
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_穴_表示 = e.ブ\u30FCツ_紐_紐8_紐下_金具上_穴_表示;
			this.ブ\u30FCツ_紐_紐8_紐下_紐_表示 = e.ブ\u30FCツ_紐_紐8_紐下_紐_表示;
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_金具_表示 = e.ブ\u30FCツ_紐_紐8_紐上_金具上_金具_表示;
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_穴_表示 = e.ブ\u30FCツ_紐_紐8_紐上_金具上_穴_表示;
			this.ブ\u30FCツ_紐_紐8_紐上_紐_表示 = e.ブ\u30FCツ_紐_紐8_紐上_紐_表示;
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_金具_表示 = e.ブ\u30FCツ_紐_紐9_紐下_金具上_金具_表示;
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_穴_表示 = e.ブ\u30FCツ_紐_紐9_紐下_金具上_穴_表示;
			this.ブ\u30FCツ_紐_紐9_紐下_紐_表示 = e.ブ\u30FCツ_紐_紐9_紐下_紐_表示;
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_金具_表示 = e.ブ\u30FCツ_紐_紐9_紐上_金具上_金具_表示;
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_穴_表示 = e.ブ\u30FCツ_紐_紐9_紐上_金具上_穴_表示;
			this.ブ\u30FCツ_紐_紐9_紐上_紐_表示 = e.ブ\u30FCツ_紐_紐9_紐上_紐_表示;
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_金具_表示 = e.ブ\u30FCツ_紐_紐10_紐下_金具上_金具_表示;
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_穴_表示 = e.ブ\u30FCツ_紐_紐10_紐下_金具上_穴_表示;
			this.ブ\u30FCツ_紐_紐10_紐下_紐_表示 = e.ブ\u30FCツ_紐_紐10_紐下_紐_表示;
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_金具_表示 = e.ブ\u30FCツ_紐_紐10_紐上_金具上_金具_表示;
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_穴_表示 = e.ブ\u30FCツ_紐_紐10_紐上_金具上_穴_表示;
			this.ブ\u30FCツ_紐_紐10_紐上_紐_表示 = e.ブ\u30FCツ_紐_紐10_紐上_紐_表示;
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_金具_表示 = e.ブ\u30FCツ_紐_紐11_紐下_金具上_金具_表示;
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_穴_表示 = e.ブ\u30FCツ_紐_紐11_紐下_金具上_穴_表示;
			this.ブ\u30FCツ_紐_紐11_紐下_紐_表示 = e.ブ\u30FCツ_紐_紐11_紐下_紐_表示;
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_金具_表示 = e.ブ\u30FCツ_紐_紐11_紐上_金具上_金具_表示;
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_穴_表示 = e.ブ\u30FCツ_紐_紐11_紐上_金具上_穴_表示;
			this.ブ\u30FCツ_紐_紐11_紐上_紐_表示 = e.ブ\u30FCツ_紐_紐11_紐上_紐_表示;
			this.ブ\u30FCツ_紐_結び_紐左_紐3_表示 = e.ブ\u30FCツ_紐_結び_紐左_紐3_表示;
			this.ブ\u30FCツ_紐_結び_紐左_紐2_表示 = e.ブ\u30FCツ_紐_結び_紐左_紐2_表示;
			this.ブ\u30FCツ_紐_結び_紐左_紐1_表示 = e.ブ\u30FCツ_紐_結び_紐左_紐1_表示;
			this.ブ\u30FCツ_紐_結び_紐右_紐3_表示 = e.ブ\u30FCツ_紐_結び_紐右_紐3_表示;
			this.ブ\u30FCツ_紐_結び_紐右_紐2_表示 = e.ブ\u30FCツ_紐_結び_紐右_紐2_表示;
			this.ブ\u30FCツ_紐_結び_紐右_紐1_表示 = e.ブ\u30FCツ_紐_結び_紐右_紐1_表示;
			this.ブ\u30FCツ_紐_結び_結び目_表示 = e.ブ\u30FCツ_紐_結び_結び目_表示;
			this.ア\u30FCマ_ベ\u30FCス_表示 = e.ア\u30FCマ_ベ\u30FCス_表示;
			this.ア\u30FCマ_脛当_脛当1_表示 = e.ア\u30FCマ_脛当_脛当1_表示;
			this.ア\u30FCマ_脛当_脛当2_表示 = e.ア\u30FCマ_脛当_脛当2_表示;
			this.ア\u30FCマ_膝当_表示 = e.ア\u30FCマ_膝当_表示;
			this.ア\u30FCマ_穴_穴1_表示 = e.ア\u30FCマ_穴_穴1_表示;
			this.ア\u30FCマ_穴_穴2_表示 = e.ア\u30FCマ_穴_穴2_表示;
			this.ア\u30FCマ_穴_穴3_表示 = e.ア\u30FCマ_穴_穴3_表示;
			this.ア\u30FCマ_穴_穴4_表示 = e.ア\u30FCマ_穴_穴4_表示;
			this.脚輪上_革_表示 = e.脚輪上_革_表示;
			this.脚輪上_金具1_表示 = e.脚輪上_金具1_表示;
			this.脚輪上_金具2_表示 = e.脚輪上_金具2_表示;
			this.脚輪上_金具3_表示 = e.脚輪上_金具3_表示;
			this.脚輪上_金具左_表示 = e.脚輪上_金具左_表示;
			this.脚輪上_金具右_表示 = e.脚輪上_金具右_表示;
			this.脚輪下_革_表示 = e.脚輪下_革_表示;
			this.脚輪下_金具1_表示 = e.脚輪下_金具1_表示;
			this.脚輪下_金具2_表示 = e.脚輪下_金具2_表示;
			this.脚輪下_金具3_表示 = e.脚輪下_金具3_表示;
			this.脚輪下_金具左_表示 = e.脚輪下_金具左_表示;
			this.脚輪下_金具右_表示 = e.脚輪下_金具右_表示;
			this.ハイライト表示 = e.ハイライト表示;
			this.脚輪上表示 = e.脚輪上表示;
			this.脚輪下表示 = e.脚輪下表示;
			if (e.虫性)
			{
				this.虫性();
			}
			this.パンスト表示 = e.パンスト表示;
			this.ニ\u30FCハイ表示 = e.ニ\u30FCハイ表示;
			this.ブ\u30FCツ表示 = e.ブ\u30FCツ表示;
			this.メイル表示 = e.メイル表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.足_接続.Count > 0)
			{
				Ele f;
				this.足_接続 = e.足_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.脚_人_足_接続;
					f.接続(CS$<>8__locals1.<>4__this.足_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.脚輪下_接続.Count > 0)
			{
				Ele f;
				this.脚輪下_接続 = e.脚輪下_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.脚_人_脚輪下_接続;
					f.接続(CS$<>8__locals1.<>4__this.脚輪下_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.脚輪上_接続.Count > 0)
			{
				Ele f;
				this.脚輪上_接続 = e.脚輪上_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.脚_人_脚輪上_接続;
					f.接続(CS$<>8__locals1.<>4__this.脚輪上_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_脚CP = new ColorP(this.X0Y0_脚, this.脚CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_筋CP = new ColorP(this.X0Y0_筋, this.筋CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_淫タトゥ_足首_タトゥCP = new ColorP(this.X0Y0_淫タトゥ_足首_タトゥ, this.淫タトゥ_足首_タトゥCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_足首_ハ\u30FCト1_タトゥ左CP = new ColorP(this.X0Y0_淫タトゥ_足首_ハ\u30FCト1_タトゥ左, this.淫タトゥ_足首_ハ\u30FCト1_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_足首_ハ\u30FCト1_タトゥ右CP = new ColorP(this.X0Y0_淫タトゥ_足首_ハ\u30FCト1_タトゥ右, this.淫タトゥ_足首_ハ\u30FCト1_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_足首_ハ\u30FCト3_タトゥ左CP = new ColorP(this.X0Y0_淫タトゥ_足首_ハ\u30FCト3_タトゥ左, this.淫タトゥ_足首_ハ\u30FCト3_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_足首_ハ\u30FCト3_タトゥ右CP = new ColorP(this.X0Y0_淫タトゥ_足首_ハ\u30FCト3_タトゥ右, this.淫タトゥ_足首_ハ\u30FCト3_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_足首_ハ\u30FCト2_タトゥ左CP = new ColorP(this.X0Y0_淫タトゥ_足首_ハ\u30FCト2_タトゥ左, this.淫タトゥ_足首_ハ\u30FCト2_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_足首_ハ\u30FCト2_タトゥ右CP = new ColorP(this.X0Y0_淫タトゥ_足首_ハ\u30FCト2_タトゥ右, this.淫タトゥ_足首_ハ\u30FCト2_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左CP = new ColorP(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左, this.淫タトゥ_ハ\u30FCト_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右CP = new ColorP(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右, this.淫タトゥ_ハ\u30FCト_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ左CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ左, this.淫タトゥ_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ右CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ右, this.淫タトゥ_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字1_文字a_枠CP = new ColorP(this.X0Y0_悪タトゥ_文字1_文字a_枠, this.悪タトゥ_文字1_文字a_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字1_文字a_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_文字1_文字a_文字タトゥ1, this.悪タトゥ_文字1_文字a_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字1_文字a_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_文字1_文字a_文字タトゥ2, this.悪タトゥ_文字1_文字a_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字1_文字b_枠CP = new ColorP(this.X0Y0_悪タトゥ_文字1_文字b_枠, this.悪タトゥ_文字1_文字b_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字1_文字b_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_文字1_文字b_文字タトゥ1, this.悪タトゥ_文字1_文字b_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字1_文字b_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_文字1_文字b_文字タトゥ2, this.悪タトゥ_文字1_文字b_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字1_文字c_枠CP = new ColorP(this.X0Y0_悪タトゥ_文字1_文字c_枠, this.悪タトゥ_文字1_文字c_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字1_文字c_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_文字1_文字c_文字タトゥ1, this.悪タトゥ_文字1_文字c_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字1_文字c_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_文字1_文字c_文字タトゥ2, this.悪タトゥ_文字1_文字c_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字1_文字d_枠CP = new ColorP(this.X0Y0_悪タトゥ_文字1_文字d_枠, this.悪タトゥ_文字1_文字d_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字1_文字d_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_文字1_文字d_文字タトゥ1, this.悪タトゥ_文字1_文字d_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字1_文字d_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_文字1_文字d_文字タトゥ2, this.悪タトゥ_文字1_文字d_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字1_文字e_枠CP = new ColorP(this.X0Y0_悪タトゥ_文字1_文字e_枠, this.悪タトゥ_文字1_文字e_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ1, this.悪タトゥ_文字1_文字e_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ2, this.悪タトゥ_文字1_文字e_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ3CP = new ColorP(this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ3, this.悪タトゥ_文字1_文字e_文字タトゥ3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字2_文字a_枠CP = new ColorP(this.X0Y0_悪タトゥ_文字2_文字a_枠, this.悪タトゥ_文字2_文字a_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字2_文字a_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_文字2_文字a_文字タトゥ1, this.悪タトゥ_文字2_文字a_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字2_文字a_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_文字2_文字a_文字タトゥ2, this.悪タトゥ_文字2_文字a_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字2_文字b_枠CP = new ColorP(this.X0Y0_悪タトゥ_文字2_文字b_枠, this.悪タトゥ_文字2_文字b_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字2_文字b_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_文字2_文字b_文字タトゥ1, this.悪タトゥ_文字2_文字b_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字2_文字b_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_文字2_文字b_文字タトゥ2, this.悪タトゥ_文字2_文字b_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字2_文字c_枠CP = new ColorP(this.X0Y0_悪タトゥ_文字2_文字c_枠, this.悪タトゥ_文字2_文字c_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字2_文字c_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_文字2_文字c_文字タトゥ1, this.悪タトゥ_文字2_文字c_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字2_文字c_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_文字2_文字c_文字タトゥ2, this.悪タトゥ_文字2_文字c_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字2_文字d_枠CP = new ColorP(this.X0Y0_悪タトゥ_文字2_文字d_枠, this.悪タトゥ_文字2_文字d_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字2_文字d_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_文字2_文字d_文字タトゥ1, this.悪タトゥ_文字2_文字d_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字2_文字d_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_文字2_文字d_文字タトゥ2, this.悪タトゥ_文字2_文字d_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字2_文字e_枠CP = new ColorP(this.X0Y0_悪タトゥ_文字2_文字e_枠, this.悪タトゥ_文字2_文字e_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ1, this.悪タトゥ_文字2_文字e_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ2, this.悪タトゥ_文字2_文字e_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ3CP = new ColorP(this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ3, this.悪タトゥ_文字2_文字e_文字タトゥ3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ_タトゥ1, this.悪タトゥ_タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_タトゥ2, this.悪タトゥ_タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_逆十字_逆十字1CP = new ColorP(this.X0Y0_悪タトゥ_逆十字_逆十字1, this.悪タトゥ_逆十字_逆十字1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_逆十字_逆十字2CP = new ColorP(this.X0Y0_悪タトゥ_逆十字_逆十字2, this.悪タトゥ_逆十字_逆十字2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_タトゥ左CP = new ColorP(this.X0Y0_悪タトゥ_タトゥ左, this.悪タトゥ_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ_タトゥ右CP = new ColorP(this.X0Y0_悪タトゥ_タトゥ右, this.悪タトゥ_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋1CP = new ColorP(this.X0Y0_紋柄_紋1, this.紋柄_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋2CP = new ColorP(this.X0Y0_紋柄_紋2, this.紋柄_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋3CP = new ColorP(this.X0Y0_紋柄_紋3, this.紋柄_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋4CP = new ColorP(this.X0Y0_紋柄_紋4, this.紋柄_紋4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_獣性_獣毛1CP = new ColorP(this.X0Y0_獣性_獣毛1, this.獣性_獣毛1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_獣性_獣毛2CP = new ColorP(this.X0Y0_獣性_獣毛2, this.獣性_獣毛2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_獣性_獣毛3CP = new ColorP(this.X0Y0_獣性_獣毛3, this.獣性_獣毛3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_獣性_獣毛4CP = new ColorP(this.X0Y0_獣性_獣毛4, this.獣性_獣毛4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_獣性_獣毛5CP = new ColorP(this.X0Y0_獣性_獣毛5, this.獣性_獣毛5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗_鱗1CP = new ColorP(this.X0Y0_竜性_鱗_鱗1, this.竜性_鱗_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗_鱗2CP = new ColorP(this.X0Y0_竜性_鱗_鱗2, this.竜性_鱗_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗_鱗3CP = new ColorP(this.X0Y0_竜性_鱗_鱗3, this.竜性_鱗_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗_鱗4CP = new ColorP(this.X0Y0_竜性_鱗_鱗4, this.竜性_鱗_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗_鱗5CP = new ColorP(this.X0Y0_竜性_鱗_鱗5, this.竜性_鱗_鱗5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗_鱗6CP = new ColorP(this.X0Y0_竜性_鱗_鱗6, this.竜性_鱗_鱗6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗_鱗7CP = new ColorP(this.X0Y0_竜性_鱗_鱗7, this.竜性_鱗_鱗7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_棘_棘1CP = new ColorP(this.X0Y0_竜性_棘_棘1, this.竜性_棘_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_棘_棘2CP = new ColorP(this.X0Y0_竜性_棘_棘2, this.竜性_棘_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_棘_棘3CP = new ColorP(this.X0Y0_竜性_棘_棘3, this.竜性_棘_棘3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_棘_棘4CP = new ColorP(this.X0Y0_竜性_棘_棘4, this.竜性_棘_棘4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_棘_棘5CP = new ColorP(this.X0Y0_竜性_棘_棘5, this.竜性_棘_棘5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_棘_棘6CP = new ColorP(this.X0Y0_竜性_棘_棘6, this.竜性_棘_棘6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_棘_棘1CP = new ColorP(this.X0Y0_虫性_棘_棘1, this.虫性_棘_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_棘_棘2CP = new ColorP(this.X0Y0_虫性_棘_棘2, this.虫性_棘_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_棘_棘3CP = new ColorP(this.X0Y0_虫性_棘_棘3, this.虫性_棘_棘3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_膝CP = new ColorP(this.X0Y0_虫性_膝, this.虫性_膝CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_線CP = new ColorP(this.X0Y0_虫性_線, this.虫性_線CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷X1CP = new ColorP(this.X0Y0_傷X1, this.傷X1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷X2CP = new ColorP(this.X0Y0_傷X2, this.傷X2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷I1CP = new ColorP(this.X0Y0_傷I1, this.傷I1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷I2CP = new ColorP(this.X0Y0_傷I2, this.傷I2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷I3CP = new ColorP(this.X0Y0_傷I3, this.傷I3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷I4CP = new ColorP(this.X0Y0_傷I4, this.傷I4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷I5CP = new ColorP(this.X0Y0_傷I5, this.傷I5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ハイライト1CP = new ColorP(this.X0Y0_ハイライト1, this.ハイライト1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ハイライト2CP = new ColorP(this.X0Y0_ハイライト2, this.ハイライト2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_パンスト_パンストCP = new ColorP(this.X0Y0_パンスト_パンスト, this.パンスト_パンストCD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_パンスト_ハイライト1CP = new ColorP(this.X0Y0_パンスト_ハイライト1, this.パンスト_ハイライト1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_パンスト_ハイライト2CP = new ColorP(this.X0Y0_パンスト_ハイライト2, this.パンスト_ハイライト2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ソックス_ソックスCP = new ColorP(this.X0Y0_ソックス_ソックス, this.ソックス_ソックスCD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_ソックス_ハイライト1CP = new ColorP(this.X0Y0_ソックス_ハイライト1, this.ソックス_ハイライト1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ソックス_ハイライト2CP = new ColorP(this.X0Y0_ソックス_ハイライト2, this.ソックス_ハイライト2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_タン_タンCP = new ColorP(this.X0Y0_ブ\u30FCツ_タン_タン, this.ブ\u30FCツ_タン_タンCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_タン_縁_縁1CP = new ColorP(this.X0Y0_ブ\u30FCツ_タン_縁_縁1, this.ブ\u30FCツ_タン_縁_縁1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_タン_縁_縁2CP = new ColorP(this.X0Y0_ブ\u30FCツ_タン_縁_縁2, this.ブ\u30FCツ_タン_縁_縁2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCP = new ColorP(this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツ, this.ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_皺_皺1CP = new ColorP(this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_皺_皺1, this.ブ\u30FCツ_ブ\u30FCツ_皺_皺1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_皺_皺2CP = new ColorP(this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_皺_皺2, this.ブ\u30FCツ_ブ\u30FCツ_皺_皺2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁1CP = new ColorP(this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁1, this.ブ\u30FCツ_ブ\u30FCツ_縁_縁1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁2CP = new ColorP(this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁2, this.ブ\u30FCツ_ブ\u30FCツ_縁_縁2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁3CP = new ColorP(this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁3, this.ブ\u30FCツ_ブ\u30FCツ_縁_縁3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁4CP = new ColorP(this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁4, this.ブ\u30FCツ_ブ\u30FCツ_縁_縁4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_柄CP = new ColorP(this.X0Y0_ブ\u30FCツ_柄, this.ブ\u30FCツ_柄CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐, this.ブ\u30FCツ_紐_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_金具上_金具, this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_金具上_穴, this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_紐, this.ブ\u30FCツ_紐_紐1_紐下_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_金具上_金具, this.ブ\u30FCツ_紐_紐1_紐上_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_金具上_穴, this.ブ\u30FCツ_紐_紐1_紐上_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_紐, this.ブ\u30FCツ_紐_紐1_紐上_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_金具上_金具, this.ブ\u30FCツ_紐_紐2_紐下_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_金具上_穴, this.ブ\u30FCツ_紐_紐2_紐下_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_紐, this.ブ\u30FCツ_紐_紐2_紐下_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_金具上_金具, this.ブ\u30FCツ_紐_紐2_紐上_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_金具上_穴, this.ブ\u30FCツ_紐_紐2_紐上_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_紐, this.ブ\u30FCツ_紐_紐2_紐上_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_金具上_金具, this.ブ\u30FCツ_紐_紐3_紐下_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_金具上_穴, this.ブ\u30FCツ_紐_紐3_紐下_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_紐, this.ブ\u30FCツ_紐_紐3_紐下_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_金具上_金具, this.ブ\u30FCツ_紐_紐3_紐上_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_金具上_穴, this.ブ\u30FCツ_紐_紐3_紐上_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_紐, this.ブ\u30FCツ_紐_紐3_紐上_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_金具上_金具, this.ブ\u30FCツ_紐_紐4_紐下_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_金具上_穴, this.ブ\u30FCツ_紐_紐4_紐下_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_紐, this.ブ\u30FCツ_紐_紐4_紐下_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_金具上_金具, this.ブ\u30FCツ_紐_紐4_紐上_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_金具上_穴, this.ブ\u30FCツ_紐_紐4_紐上_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_紐, this.ブ\u30FCツ_紐_紐4_紐上_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_金具上_金具, this.ブ\u30FCツ_紐_紐5_紐下_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_金具上_穴, this.ブ\u30FCツ_紐_紐5_紐下_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_紐, this.ブ\u30FCツ_紐_紐5_紐下_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_金具上_金具, this.ブ\u30FCツ_紐_紐5_紐上_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_金具上_穴, this.ブ\u30FCツ_紐_紐5_紐上_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_紐, this.ブ\u30FCツ_紐_紐5_紐上_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_金具上_金具, this.ブ\u30FCツ_紐_紐6_紐下_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_金具上_穴, this.ブ\u30FCツ_紐_紐6_紐下_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_紐, this.ブ\u30FCツ_紐_紐6_紐下_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_金具上_金具, this.ブ\u30FCツ_紐_紐6_紐上_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_金具上_穴, this.ブ\u30FCツ_紐_紐6_紐上_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_紐, this.ブ\u30FCツ_紐_紐6_紐上_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_金具上_金具, this.ブ\u30FCツ_紐_紐7_紐下_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_金具上_穴, this.ブ\u30FCツ_紐_紐7_紐下_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_紐, this.ブ\u30FCツ_紐_紐7_紐下_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_金具上_金具, this.ブ\u30FCツ_紐_紐7_紐上_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_金具上_穴, this.ブ\u30FCツ_紐_紐7_紐上_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_紐, this.ブ\u30FCツ_紐_紐7_紐上_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_金具上_金具, this.ブ\u30FCツ_紐_紐8_紐下_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_金具上_穴, this.ブ\u30FCツ_紐_紐8_紐下_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_紐, this.ブ\u30FCツ_紐_紐8_紐下_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_金具上_金具, this.ブ\u30FCツ_紐_紐8_紐上_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_金具上_穴, this.ブ\u30FCツ_紐_紐8_紐上_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_紐, this.ブ\u30FCツ_紐_紐8_紐上_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_金具上_金具, this.ブ\u30FCツ_紐_紐9_紐下_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_金具上_穴, this.ブ\u30FCツ_紐_紐9_紐下_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_紐, this.ブ\u30FCツ_紐_紐9_紐下_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_金具上_金具, this.ブ\u30FCツ_紐_紐9_紐上_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_金具上_穴, this.ブ\u30FCツ_紐_紐9_紐上_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_紐, this.ブ\u30FCツ_紐_紐9_紐上_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_金具上_金具, this.ブ\u30FCツ_紐_紐10_紐下_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_金具上_穴, this.ブ\u30FCツ_紐_紐10_紐下_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_紐, this.ブ\u30FCツ_紐_紐10_紐下_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_金具上_金具, this.ブ\u30FCツ_紐_紐10_紐上_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_金具上_穴, this.ブ\u30FCツ_紐_紐10_紐上_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_紐, this.ブ\u30FCツ_紐_紐10_紐上_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_金具上_金具, this.ブ\u30FCツ_紐_紐11_紐下_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_金具上_穴, this.ブ\u30FCツ_紐_紐11_紐下_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_紐, this.ブ\u30FCツ_紐_紐11_紐下_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_金具上_金具CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_金具上_金具, this.ブ\u30FCツ_紐_紐11_紐上_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_金具上_穴CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_金具上_穴, this.ブ\u30FCツ_紐_紐11_紐上_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_紐CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_紐, this.ブ\u30FCツ_紐_紐11_紐上_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐3CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐3, this.ブ\u30FCツ_紐_結び_紐左_紐3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐2CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐2, this.ブ\u30FCツ_紐_結び_紐左_紐2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐1CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐1, this.ブ\u30FCツ_紐_結び_紐左_紐1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐3CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐3, this.ブ\u30FCツ_紐_結び_紐右_紐3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐2CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐2, this.ブ\u30FCツ_紐_結び_紐右_紐2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐1CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐1, this.ブ\u30FCツ_紐_結び_紐右_紐1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ブ\u30FCツ_紐_結び_結び目CP = new ColorP(this.X0Y0_ブ\u30FCツ_紐_結び_結び目, this.ブ\u30FCツ_紐_結び_結び目CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ア\u30FCマ_ベ\u30FCスCP = new ColorP(this.X0Y0_ア\u30FCマ_ベ\u30FCス, this.ア\u30FCマ_ベ\u30FCスCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ア\u30FCマ_脛当_脛当1CP = new ColorP(this.X0Y0_ア\u30FCマ_脛当_脛当1, this.ア\u30FCマ_脛当_脛当1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ア\u30FCマ_脛当_脛当2CP = new ColorP(this.X0Y0_ア\u30FCマ_脛当_脛当2, this.ア\u30FCマ_脛当_脛当2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ア\u30FCマ_膝当CP = new ColorP(this.X0Y0_ア\u30FCマ_膝当, this.ア\u30FCマ_膝当CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ア\u30FCマ_穴_穴1CP = new ColorP(this.X0Y0_ア\u30FCマ_穴_穴1, this.ア\u30FCマ_穴_穴1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ア\u30FCマ_穴_穴2CP = new ColorP(this.X0Y0_ア\u30FCマ_穴_穴2, this.ア\u30FCマ_穴_穴2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ア\u30FCマ_穴_穴3CP = new ColorP(this.X0Y0_ア\u30FCマ_穴_穴3, this.ア\u30FCマ_穴_穴3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ア\u30FCマ_穴_穴4CP = new ColorP(this.X0Y0_ア\u30FCマ_穴_穴4, this.ア\u30FCマ_穴_穴4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚輪上_革CP = new ColorP(this.X0Y0_脚輪上_革, this.脚輪上_革CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚輪上_金具1CP = new ColorP(this.X0Y0_脚輪上_金具1, this.脚輪上_金具1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚輪上_金具2CP = new ColorP(this.X0Y0_脚輪上_金具2, this.脚輪上_金具2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚輪上_金具3CP = new ColorP(this.X0Y0_脚輪上_金具3, this.脚輪上_金具3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚輪上_金具左CP = new ColorP(this.X0Y0_脚輪上_金具左, this.脚輪上_金具左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚輪上_金具右CP = new ColorP(this.X0Y0_脚輪上_金具右, this.脚輪上_金具右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚輪下_革CP = new ColorP(this.X0Y0_脚輪下_革, this.脚輪下_革CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚輪下_金具1CP = new ColorP(this.X0Y0_脚輪下_金具1, this.脚輪下_金具1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚輪下_金具2CP = new ColorP(this.X0Y0_脚輪下_金具2, this.脚輪下_金具2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚輪下_金具3CP = new ColorP(this.X0Y0_脚輪下_金具3, this.脚輪下_金具3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚輪下_金具左CP = new ColorP(this.X0Y0_脚輪下_金具左, this.脚輪下_金具左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚輪下_金具右CP = new ColorP(this.X0Y0_脚輪下_金具右, this.脚輪下_金具右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_脚CP = new ColorP(this.X0Y1_脚, this.脚CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_筋CP = new ColorP(this.X0Y1_筋, this.筋CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y1_淫タトゥ_足首_タトゥCP = new ColorP(this.X0Y1_淫タトゥ_足首_タトゥ, this.淫タトゥ_足首_タトゥCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_足首_ハ\u30FCト1_タトゥ左CP = new ColorP(this.X0Y1_淫タトゥ_足首_ハ\u30FCト1_タトゥ左, this.淫タトゥ_足首_ハ\u30FCト1_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_足首_ハ\u30FCト1_タトゥ右CP = new ColorP(this.X0Y1_淫タトゥ_足首_ハ\u30FCト1_タトゥ右, this.淫タトゥ_足首_ハ\u30FCト1_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_足首_ハ\u30FCト3_タトゥ左CP = new ColorP(this.X0Y1_淫タトゥ_足首_ハ\u30FCト3_タトゥ左, this.淫タトゥ_足首_ハ\u30FCト3_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_足首_ハ\u30FCト3_タトゥ右CP = new ColorP(this.X0Y1_淫タトゥ_足首_ハ\u30FCト3_タトゥ右, this.淫タトゥ_足首_ハ\u30FCト3_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_足首_ハ\u30FCト2_タトゥ左CP = new ColorP(this.X0Y1_淫タトゥ_足首_ハ\u30FCト2_タトゥ左, this.淫タトゥ_足首_ハ\u30FCト2_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_足首_ハ\u30FCト2_タトゥ右CP = new ColorP(this.X0Y1_淫タトゥ_足首_ハ\u30FCト2_タトゥ右, this.淫タトゥ_足首_ハ\u30FCト2_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左CP = new ColorP(this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左, this.淫タトゥ_ハ\u30FCト_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右CP = new ColorP(this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右, this.淫タトゥ_ハ\u30FCト_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_タトゥ左CP = new ColorP(this.X0Y1_淫タトゥ_タトゥ左, this.淫タトゥ_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_タトゥ右CP = new ColorP(this.X0Y1_淫タトゥ_タトゥ右, this.淫タトゥ_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字1_文字a_枠CP = new ColorP(this.X0Y1_悪タトゥ_文字1_文字a_枠, this.悪タトゥ_文字1_文字a_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字1_文字a_文字タトゥ1CP = new ColorP(this.X0Y1_悪タトゥ_文字1_文字a_文字タトゥ1, this.悪タトゥ_文字1_文字a_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字1_文字a_文字タトゥ2CP = new ColorP(this.X0Y1_悪タトゥ_文字1_文字a_文字タトゥ2, this.悪タトゥ_文字1_文字a_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字1_文字b_枠CP = new ColorP(this.X0Y1_悪タトゥ_文字1_文字b_枠, this.悪タトゥ_文字1_文字b_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字1_文字b_文字タトゥ1CP = new ColorP(this.X0Y1_悪タトゥ_文字1_文字b_文字タトゥ1, this.悪タトゥ_文字1_文字b_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字1_文字b_文字タトゥ2CP = new ColorP(this.X0Y1_悪タトゥ_文字1_文字b_文字タトゥ2, this.悪タトゥ_文字1_文字b_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字1_文字c_枠CP = new ColorP(this.X0Y1_悪タトゥ_文字1_文字c_枠, this.悪タトゥ_文字1_文字c_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字1_文字c_文字タトゥ1CP = new ColorP(this.X0Y1_悪タトゥ_文字1_文字c_文字タトゥ1, this.悪タトゥ_文字1_文字c_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字1_文字c_文字タトゥ2CP = new ColorP(this.X0Y1_悪タトゥ_文字1_文字c_文字タトゥ2, this.悪タトゥ_文字1_文字c_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字1_文字d_枠CP = new ColorP(this.X0Y1_悪タトゥ_文字1_文字d_枠, this.悪タトゥ_文字1_文字d_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字1_文字d_文字タトゥ1CP = new ColorP(this.X0Y1_悪タトゥ_文字1_文字d_文字タトゥ1, this.悪タトゥ_文字1_文字d_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字1_文字d_文字タトゥ2CP = new ColorP(this.X0Y1_悪タトゥ_文字1_文字d_文字タトゥ2, this.悪タトゥ_文字1_文字d_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字1_文字e_枠CP = new ColorP(this.X0Y1_悪タトゥ_文字1_文字e_枠, this.悪タトゥ_文字1_文字e_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字1_文字e_文字タトゥ1CP = new ColorP(this.X0Y1_悪タトゥ_文字1_文字e_文字タトゥ1, this.悪タトゥ_文字1_文字e_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字1_文字e_文字タトゥ2CP = new ColorP(this.X0Y1_悪タトゥ_文字1_文字e_文字タトゥ2, this.悪タトゥ_文字1_文字e_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字1_文字e_文字タトゥ3CP = new ColorP(this.X0Y1_悪タトゥ_文字1_文字e_文字タトゥ3, this.悪タトゥ_文字1_文字e_文字タトゥ3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字2_文字a_枠CP = new ColorP(this.X0Y1_悪タトゥ_文字2_文字a_枠, this.悪タトゥ_文字2_文字a_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字2_文字a_文字タトゥ1CP = new ColorP(this.X0Y1_悪タトゥ_文字2_文字a_文字タトゥ1, this.悪タトゥ_文字2_文字a_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字2_文字a_文字タトゥ2CP = new ColorP(this.X0Y1_悪タトゥ_文字2_文字a_文字タトゥ2, this.悪タトゥ_文字2_文字a_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字2_文字b_枠CP = new ColorP(this.X0Y1_悪タトゥ_文字2_文字b_枠, this.悪タトゥ_文字2_文字b_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字2_文字b_文字タトゥ1CP = new ColorP(this.X0Y1_悪タトゥ_文字2_文字b_文字タトゥ1, this.悪タトゥ_文字2_文字b_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字2_文字b_文字タトゥ2CP = new ColorP(this.X0Y1_悪タトゥ_文字2_文字b_文字タトゥ2, this.悪タトゥ_文字2_文字b_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字2_文字c_枠CP = new ColorP(this.X0Y1_悪タトゥ_文字2_文字c_枠, this.悪タトゥ_文字2_文字c_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字2_文字c_文字タトゥ1CP = new ColorP(this.X0Y1_悪タトゥ_文字2_文字c_文字タトゥ1, this.悪タトゥ_文字2_文字c_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字2_文字c_文字タトゥ2CP = new ColorP(this.X0Y1_悪タトゥ_文字2_文字c_文字タトゥ2, this.悪タトゥ_文字2_文字c_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字2_文字d_枠CP = new ColorP(this.X0Y1_悪タトゥ_文字2_文字d_枠, this.悪タトゥ_文字2_文字d_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字2_文字d_文字タトゥ1CP = new ColorP(this.X0Y1_悪タトゥ_文字2_文字d_文字タトゥ1, this.悪タトゥ_文字2_文字d_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字2_文字d_文字タトゥ2CP = new ColorP(this.X0Y1_悪タトゥ_文字2_文字d_文字タトゥ2, this.悪タトゥ_文字2_文字d_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字2_文字e_枠CP = new ColorP(this.X0Y1_悪タトゥ_文字2_文字e_枠, this.悪タトゥ_文字2_文字e_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字2_文字e_文字タトゥ1CP = new ColorP(this.X0Y1_悪タトゥ_文字2_文字e_文字タトゥ1, this.悪タトゥ_文字2_文字e_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字2_文字e_文字タトゥ2CP = new ColorP(this.X0Y1_悪タトゥ_文字2_文字e_文字タトゥ2, this.悪タトゥ_文字2_文字e_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_文字2_文字e_文字タトゥ3CP = new ColorP(this.X0Y1_悪タトゥ_文字2_文字e_文字タトゥ3, this.悪タトゥ_文字2_文字e_文字タトゥ3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_タトゥ1CP = new ColorP(this.X0Y1_悪タトゥ_タトゥ1, this.悪タトゥ_タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_タトゥ2CP = new ColorP(this.X0Y1_悪タトゥ_タトゥ2, this.悪タトゥ_タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_逆十字_逆十字1CP = new ColorP(this.X0Y1_悪タトゥ_逆十字_逆十字1, this.悪タトゥ_逆十字_逆十字1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_逆十字_逆十字2CP = new ColorP(this.X0Y1_悪タトゥ_逆十字_逆十字2, this.悪タトゥ_逆十字_逆十字2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_タトゥ左CP = new ColorP(this.X0Y1_悪タトゥ_タトゥ左, this.悪タトゥ_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ_タトゥ右CP = new ColorP(this.X0Y1_悪タトゥ_タトゥ右, this.悪タトゥ_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_紋柄_紋1CP = new ColorP(this.X0Y1_紋柄_紋1, this.紋柄_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_紋柄_紋2CP = new ColorP(this.X0Y1_紋柄_紋2, this.紋柄_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_紋柄_紋3CP = new ColorP(this.X0Y1_紋柄_紋3, this.紋柄_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_紋柄_紋4CP = new ColorP(this.X0Y1_紋柄_紋4, this.紋柄_紋4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_獣性_獣毛1CP = new ColorP(this.X0Y1_獣性_獣毛1, this.獣性_獣毛1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_獣性_獣毛2CP = new ColorP(this.X0Y1_獣性_獣毛2, this.獣性_獣毛2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_獣性_獣毛3CP = new ColorP(this.X0Y1_獣性_獣毛3, this.獣性_獣毛3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_獣性_獣毛4CP = new ColorP(this.X0Y1_獣性_獣毛4, this.獣性_獣毛4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_獣性_獣毛5CP = new ColorP(this.X0Y1_獣性_獣毛5, this.獣性_獣毛5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_鱗_鱗1CP = new ColorP(this.X0Y1_竜性_鱗_鱗1, this.竜性_鱗_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_鱗_鱗2CP = new ColorP(this.X0Y1_竜性_鱗_鱗2, this.竜性_鱗_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_鱗_鱗3CP = new ColorP(this.X0Y1_竜性_鱗_鱗3, this.竜性_鱗_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_鱗_鱗4CP = new ColorP(this.X0Y1_竜性_鱗_鱗4, this.竜性_鱗_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_鱗_鱗5CP = new ColorP(this.X0Y1_竜性_鱗_鱗5, this.竜性_鱗_鱗5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_鱗_鱗6CP = new ColorP(this.X0Y1_竜性_鱗_鱗6, this.竜性_鱗_鱗6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_鱗_鱗7CP = new ColorP(this.X0Y1_竜性_鱗_鱗7, this.竜性_鱗_鱗7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_棘_棘1CP = new ColorP(this.X0Y1_竜性_棘_棘1, this.竜性_棘_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_棘_棘2CP = new ColorP(this.X0Y1_竜性_棘_棘2, this.竜性_棘_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_棘_棘3CP = new ColorP(this.X0Y1_竜性_棘_棘3, this.竜性_棘_棘3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_棘_棘4CP = new ColorP(this.X0Y1_竜性_棘_棘4, this.竜性_棘_棘4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_棘_棘5CP = new ColorP(this.X0Y1_竜性_棘_棘5, this.竜性_棘_棘5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_竜性_棘_棘6CP = new ColorP(this.X0Y1_竜性_棘_棘6, this.竜性_棘_棘6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_虫性_棘_棘1CP = new ColorP(this.X0Y1_虫性_棘_棘1, this.虫性_棘_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_虫性_棘_棘2CP = new ColorP(this.X0Y1_虫性_棘_棘2, this.虫性_棘_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_虫性_棘_棘3CP = new ColorP(this.X0Y1_虫性_棘_棘3, this.虫性_棘_棘3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_虫性_膝CP = new ColorP(this.X0Y1_虫性_膝, this.虫性_膝CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_虫性_線CP = new ColorP(this.X0Y1_虫性_線, this.虫性_線CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_傷X1CP = new ColorP(this.X0Y1_傷X1, this.傷X1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_傷X2CP = new ColorP(this.X0Y1_傷X2, this.傷X2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_傷I1CP = new ColorP(this.X0Y1_傷I1, this.傷I1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_傷I2CP = new ColorP(this.X0Y1_傷I2, this.傷I2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_傷I3CP = new ColorP(this.X0Y1_傷I3, this.傷I3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_傷I4CP = new ColorP(this.X0Y1_傷I4, this.傷I4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_傷I5CP = new ColorP(this.X0Y1_傷I5, this.傷I5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ハイライト1CP = new ColorP(this.X0Y1_ハイライト1, this.ハイライト1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ハイライト2CP = new ColorP(this.X0Y1_ハイライト2, this.ハイライト2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_パンスト_パンストCP = new ColorP(this.X0Y1_パンスト_パンスト, this.パンスト_パンストCD, CS$<>8__locals1.DisUnit, false);
			this.X0Y1_パンスト_ハイライト1CP = new ColorP(this.X0Y1_パンスト_ハイライト1, this.パンスト_ハイライト1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_パンスト_ハイライト2CP = new ColorP(this.X0Y1_パンスト_ハイライト2, this.パンスト_ハイライト2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ソックス_ソックスCP = new ColorP(this.X0Y1_ソックス_ソックス, this.ソックス_ソックスCD, CS$<>8__locals1.DisUnit, false);
			this.X0Y1_ソックス_ハイライト1CP = new ColorP(this.X0Y1_ソックス_ハイライト1, this.ソックス_ハイライト1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ソックス_ハイライト2CP = new ColorP(this.X0Y1_ソックス_ハイライト2, this.ソックス_ハイライト2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_タン_タンCP = new ColorP(this.X0Y1_ブ\u30FCツ_タン_タン, this.ブ\u30FCツ_タン_タンCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_タン_縁_縁1CP = new ColorP(this.X0Y1_ブ\u30FCツ_タン_縁_縁1, this.ブ\u30FCツ_タン_縁_縁1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_タン_縁_縁2CP = new ColorP(this.X0Y1_ブ\u30FCツ_タン_縁_縁2, this.ブ\u30FCツ_タン_縁_縁2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCP = new ColorP(this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツ, this.ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_皺_皺1CP = new ColorP(this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_皺_皺1, this.ブ\u30FCツ_ブ\u30FCツ_皺_皺1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_皺_皺2CP = new ColorP(this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_皺_皺2, this.ブ\u30FCツ_ブ\u30FCツ_皺_皺2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁1CP = new ColorP(this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁1, this.ブ\u30FCツ_ブ\u30FCツ_縁_縁1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁2CP = new ColorP(this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁2, this.ブ\u30FCツ_ブ\u30FCツ_縁_縁2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁3CP = new ColorP(this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁3, this.ブ\u30FCツ_ブ\u30FCツ_縁_縁3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁4CP = new ColorP(this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁4, this.ブ\u30FCツ_ブ\u30FCツ_縁_縁4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_柄CP = new ColorP(this.X0Y1_ブ\u30FCツ_柄, this.ブ\u30FCツ_柄CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐, this.ブ\u30FCツ_紐_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_金具上_金具, this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_金具上_穴, this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_紐, this.ブ\u30FCツ_紐_紐1_紐下_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_金具上_金具, this.ブ\u30FCツ_紐_紐1_紐上_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_金具上_穴, this.ブ\u30FCツ_紐_紐1_紐上_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_紐, this.ブ\u30FCツ_紐_紐1_紐上_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_金具上_金具, this.ブ\u30FCツ_紐_紐2_紐下_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_金具上_穴, this.ブ\u30FCツ_紐_紐2_紐下_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_紐, this.ブ\u30FCツ_紐_紐2_紐下_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_金具上_金具, this.ブ\u30FCツ_紐_紐2_紐上_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_金具上_穴, this.ブ\u30FCツ_紐_紐2_紐上_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_紐, this.ブ\u30FCツ_紐_紐2_紐上_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_金具上_金具, this.ブ\u30FCツ_紐_紐3_紐下_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_金具上_穴, this.ブ\u30FCツ_紐_紐3_紐下_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_紐, this.ブ\u30FCツ_紐_紐3_紐下_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_金具上_金具, this.ブ\u30FCツ_紐_紐3_紐上_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_金具上_穴, this.ブ\u30FCツ_紐_紐3_紐上_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_紐, this.ブ\u30FCツ_紐_紐3_紐上_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_金具上_金具, this.ブ\u30FCツ_紐_紐4_紐下_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_金具上_穴, this.ブ\u30FCツ_紐_紐4_紐下_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_紐, this.ブ\u30FCツ_紐_紐4_紐下_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_金具上_金具, this.ブ\u30FCツ_紐_紐4_紐上_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_金具上_穴, this.ブ\u30FCツ_紐_紐4_紐上_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_紐, this.ブ\u30FCツ_紐_紐4_紐上_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_金具上_金具, this.ブ\u30FCツ_紐_紐5_紐下_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_金具上_穴, this.ブ\u30FCツ_紐_紐5_紐下_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_紐, this.ブ\u30FCツ_紐_紐5_紐下_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_金具上_金具, this.ブ\u30FCツ_紐_紐5_紐上_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_金具上_穴, this.ブ\u30FCツ_紐_紐5_紐上_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_紐, this.ブ\u30FCツ_紐_紐5_紐上_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_金具上_金具, this.ブ\u30FCツ_紐_紐6_紐下_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_金具上_穴, this.ブ\u30FCツ_紐_紐6_紐下_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_紐, this.ブ\u30FCツ_紐_紐6_紐下_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_金具上_金具, this.ブ\u30FCツ_紐_紐6_紐上_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_金具上_穴, this.ブ\u30FCツ_紐_紐6_紐上_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_紐, this.ブ\u30FCツ_紐_紐6_紐上_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_金具上_金具, this.ブ\u30FCツ_紐_紐7_紐下_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_金具上_穴, this.ブ\u30FCツ_紐_紐7_紐下_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_紐, this.ブ\u30FCツ_紐_紐7_紐下_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_金具上_金具, this.ブ\u30FCツ_紐_紐7_紐上_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_金具上_穴, this.ブ\u30FCツ_紐_紐7_紐上_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_紐, this.ブ\u30FCツ_紐_紐7_紐上_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_金具上_金具, this.ブ\u30FCツ_紐_紐8_紐下_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_金具上_穴, this.ブ\u30FCツ_紐_紐8_紐下_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_紐, this.ブ\u30FCツ_紐_紐8_紐下_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_金具上_金具, this.ブ\u30FCツ_紐_紐8_紐上_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_金具上_穴, this.ブ\u30FCツ_紐_紐8_紐上_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_紐, this.ブ\u30FCツ_紐_紐8_紐上_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_金具上_金具, this.ブ\u30FCツ_紐_紐9_紐下_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_金具上_穴, this.ブ\u30FCツ_紐_紐9_紐下_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_紐, this.ブ\u30FCツ_紐_紐9_紐下_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_金具上_金具, this.ブ\u30FCツ_紐_紐9_紐上_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_金具上_穴, this.ブ\u30FCツ_紐_紐9_紐上_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_紐, this.ブ\u30FCツ_紐_紐9_紐上_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_金具上_金具, this.ブ\u30FCツ_紐_紐10_紐下_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_金具上_穴, this.ブ\u30FCツ_紐_紐10_紐下_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_紐, this.ブ\u30FCツ_紐_紐10_紐下_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_金具上_金具, this.ブ\u30FCツ_紐_紐10_紐上_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_金具上_穴, this.ブ\u30FCツ_紐_紐10_紐上_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_紐, this.ブ\u30FCツ_紐_紐10_紐上_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_金具上_金具, this.ブ\u30FCツ_紐_紐11_紐下_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_金具上_穴, this.ブ\u30FCツ_紐_紐11_紐下_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_紐, this.ブ\u30FCツ_紐_紐11_紐下_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_金具上_金具CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_金具上_金具, this.ブ\u30FCツ_紐_紐11_紐上_金具上_金具CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_金具上_穴CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_金具上_穴, this.ブ\u30FCツ_紐_紐11_紐上_金具上_穴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_紐CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_紐, this.ブ\u30FCツ_紐_紐11_紐上_紐CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐3CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐3, this.ブ\u30FCツ_紐_結び_紐左_紐3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐2CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐2, this.ブ\u30FCツ_紐_結び_紐左_紐2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐1CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐1, this.ブ\u30FCツ_紐_結び_紐左_紐1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐3CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐3, this.ブ\u30FCツ_紐_結び_紐右_紐3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐2CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐2, this.ブ\u30FCツ_紐_結び_紐右_紐2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐1CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐1, this.ブ\u30FCツ_紐_結び_紐右_紐1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ブ\u30FCツ_紐_結び_結び目CP = new ColorP(this.X0Y1_ブ\u30FCツ_紐_結び_結び目, this.ブ\u30FCツ_紐_結び_結び目CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ア\u30FCマ_ベ\u30FCスCP = new ColorP(this.X0Y1_ア\u30FCマ_ベ\u30FCス, this.ア\u30FCマ_ベ\u30FCスCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ア\u30FCマ_脛当_脛当1CP = new ColorP(this.X0Y1_ア\u30FCマ_脛当_脛当1, this.ア\u30FCマ_脛当_脛当1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ア\u30FCマ_脛当_脛当2CP = new ColorP(this.X0Y1_ア\u30FCマ_脛当_脛当2, this.ア\u30FCマ_脛当_脛当2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ア\u30FCマ_膝当CP = new ColorP(this.X0Y1_ア\u30FCマ_膝当, this.ア\u30FCマ_膝当CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ア\u30FCマ_穴_穴1CP = new ColorP(this.X0Y1_ア\u30FCマ_穴_穴1, this.ア\u30FCマ_穴_穴1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ア\u30FCマ_穴_穴2CP = new ColorP(this.X0Y1_ア\u30FCマ_穴_穴2, this.ア\u30FCマ_穴_穴2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ア\u30FCマ_穴_穴3CP = new ColorP(this.X0Y1_ア\u30FCマ_穴_穴3, this.ア\u30FCマ_穴_穴3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ア\u30FCマ_穴_穴4CP = new ColorP(this.X0Y1_ア\u30FCマ_穴_穴4, this.ア\u30FCマ_穴_穴4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_脚輪上_革CP = new ColorP(this.X0Y1_脚輪上_革, this.脚輪上_革CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_脚輪上_金具1CP = new ColorP(this.X0Y1_脚輪上_金具1, this.脚輪上_金具1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_脚輪上_金具2CP = new ColorP(this.X0Y1_脚輪上_金具2, this.脚輪上_金具2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_脚輪上_金具3CP = new ColorP(this.X0Y1_脚輪上_金具3, this.脚輪上_金具3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_脚輪上_金具左CP = new ColorP(this.X0Y1_脚輪上_金具左, this.脚輪上_金具左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_脚輪上_金具右CP = new ColorP(this.X0Y1_脚輪上_金具右, this.脚輪上_金具右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_脚輪下_革CP = new ColorP(this.X0Y1_脚輪下_革, this.脚輪下_革CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_脚輪下_金具1CP = new ColorP(this.X0Y1_脚輪下_金具1, this.脚輪下_金具1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_脚輪下_金具2CP = new ColorP(this.X0Y1_脚輪下_金具2, this.脚輪下_金具2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_脚輪下_金具3CP = new ColorP(this.X0Y1_脚輪下_金具3, this.脚輪下_金具3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_脚輪下_金具左CP = new ColorP(this.X0Y1_脚輪下_金具左, this.脚輪下_金具左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_脚輪下_金具右CP = new ColorP(this.X0Y1_脚輪下_金具右, this.脚輪下_金具右CD, CS$<>8__locals1.DisUnit, true);
			this.筋肉濃度 = e.筋肉濃度;
			this.傷X1濃度 = e.傷X1濃度;
			this.傷X2濃度 = e.傷X2濃度;
			this.傷I1濃度 = e.傷I1濃度;
			this.傷I2濃度 = e.傷I2濃度;
			this.傷I3濃度 = e.傷I3濃度;
			this.傷I4濃度 = e.傷I4濃度;
			this.傷I5濃度 = e.傷I5濃度;
			this.ハイライト濃度 = e.ハイライト濃度;
			this.濃度 = e.濃度;
			this.鎖1 = new 拘束鎖(CS$<>8__locals1.DisUnit, this.右, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖3 = new 拘束鎖(CS$<>8__locals1.DisUnit, this.右, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖1.接続(this.鎖1_接続点);
			this.鎖3.接続(this.鎖3_接続点);
			int num = this.右 ? -10 : 10;
			this.鎖1.角度B += (double)num;
			this.鎖3.角度B -= (double)num;
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
				this.筋_表示 = this.筋肉_;
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
				this.脚輪上表示 = this.拘束_;
				this.脚輪下表示 = this.拘束_;
			}
		}

		public bool 脚_表示
		{
			get
			{
				return this.X0Y0_脚.Dra;
			}
			set
			{
				this.X0Y0_脚.Dra = value;
				this.X0Y1_脚.Dra = value;
				this.X0Y0_脚.Hit = value;
				this.X0Y1_脚.Hit = value;
			}
		}

		public bool 筋_表示
		{
			get
			{
				return this.X0Y0_筋.Dra;
			}
			set
			{
				this.X0Y0_筋.Dra = value;
				this.X0Y1_筋.Dra = value;
				this.X0Y0_筋.Hit = value;
				this.X0Y1_筋.Hit = value;
			}
		}

		public bool 淫タトゥ_足首_タトゥ_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_足首_タトゥ.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_足首_タトゥ.Dra = value;
				this.X0Y1_淫タトゥ_足首_タトゥ.Dra = value;
				this.X0Y0_淫タトゥ_足首_タトゥ.Hit = value;
				this.X0Y1_淫タトゥ_足首_タトゥ.Hit = value;
			}
		}

		public bool 淫タトゥ_足首_ハ\u30FCト1_タトゥ左_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_足首_ハ\u30FCト1_タトゥ左.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_足首_ハ\u30FCト1_タトゥ左.Dra = value;
				this.X0Y1_淫タトゥ_足首_ハ\u30FCト1_タトゥ左.Dra = value;
				this.X0Y0_淫タトゥ_足首_ハ\u30FCト1_タトゥ左.Hit = value;
				this.X0Y1_淫タトゥ_足首_ハ\u30FCト1_タトゥ左.Hit = value;
			}
		}

		public bool 淫タトゥ_足首_ハ\u30FCト1_タトゥ右_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_足首_ハ\u30FCト1_タトゥ右.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_足首_ハ\u30FCト1_タトゥ右.Dra = value;
				this.X0Y1_淫タトゥ_足首_ハ\u30FCト1_タトゥ右.Dra = value;
				this.X0Y0_淫タトゥ_足首_ハ\u30FCト1_タトゥ右.Hit = value;
				this.X0Y1_淫タトゥ_足首_ハ\u30FCト1_タトゥ右.Hit = value;
			}
		}

		public bool 淫タトゥ_足首_ハ\u30FCト3_タトゥ左_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_足首_ハ\u30FCト3_タトゥ左.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_足首_ハ\u30FCト3_タトゥ左.Dra = value;
				this.X0Y1_淫タトゥ_足首_ハ\u30FCト3_タトゥ左.Dra = value;
				this.X0Y0_淫タトゥ_足首_ハ\u30FCト3_タトゥ左.Hit = value;
				this.X0Y1_淫タトゥ_足首_ハ\u30FCト3_タトゥ左.Hit = value;
			}
		}

		public bool 淫タトゥ_足首_ハ\u30FCト3_タトゥ右_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_足首_ハ\u30FCト3_タトゥ右.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_足首_ハ\u30FCト3_タトゥ右.Dra = value;
				this.X0Y1_淫タトゥ_足首_ハ\u30FCト3_タトゥ右.Dra = value;
				this.X0Y0_淫タトゥ_足首_ハ\u30FCト3_タトゥ右.Hit = value;
				this.X0Y1_淫タトゥ_足首_ハ\u30FCト3_タトゥ右.Hit = value;
			}
		}

		public bool 淫タトゥ_足首_ハ\u30FCト2_タトゥ左_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_足首_ハ\u30FCト2_タトゥ左.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_足首_ハ\u30FCト2_タトゥ左.Dra = value;
				this.X0Y1_淫タトゥ_足首_ハ\u30FCト2_タトゥ左.Dra = value;
				this.X0Y0_淫タトゥ_足首_ハ\u30FCト2_タトゥ左.Hit = value;
				this.X0Y1_淫タトゥ_足首_ハ\u30FCト2_タトゥ左.Hit = value;
			}
		}

		public bool 淫タトゥ_足首_ハ\u30FCト2_タトゥ右_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_足首_ハ\u30FCト2_タトゥ右.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_足首_ハ\u30FCト2_タトゥ右.Dra = value;
				this.X0Y1_淫タトゥ_足首_ハ\u30FCト2_タトゥ右.Dra = value;
				this.X0Y0_淫タトゥ_足首_ハ\u30FCト2_タトゥ右.Hit = value;
				this.X0Y1_淫タトゥ_足首_ハ\u30FCト2_タトゥ右.Hit = value;
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
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左.Dra = value;
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左.Hit = value;
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左.Hit = value;
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
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右.Dra = value;
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右.Hit = value;
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右.Hit = value;
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
				this.X0Y1_淫タトゥ_タトゥ左.Dra = value;
				this.X0Y0_淫タトゥ_タトゥ左.Hit = value;
				this.X0Y1_淫タトゥ_タトゥ左.Hit = value;
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
				this.X0Y1_淫タトゥ_タトゥ右.Dra = value;
				this.X0Y0_淫タトゥ_タトゥ右.Hit = value;
				this.X0Y1_淫タトゥ_タトゥ右.Hit = value;
			}
		}

		public bool 悪タトゥ_文字1_文字a_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字1_文字a_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字1_文字a_枠.Dra = value;
				this.X0Y1_悪タトゥ_文字1_文字a_枠.Dra = value;
				this.X0Y0_悪タトゥ_文字1_文字a_枠.Hit = value;
				this.X0Y1_悪タトゥ_文字1_文字a_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_文字1_文字a_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字1_文字a_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字1_文字a_文字タトゥ1.Dra = value;
				this.X0Y1_悪タトゥ_文字1_文字a_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_文字1_文字a_文字タトゥ1.Hit = value;
				this.X0Y1_悪タトゥ_文字1_文字a_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_文字1_文字a_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字1_文字a_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字1_文字a_文字タトゥ2.Dra = value;
				this.X0Y1_悪タトゥ_文字1_文字a_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_文字1_文字a_文字タトゥ2.Hit = value;
				this.X0Y1_悪タトゥ_文字1_文字a_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_文字1_文字b_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字1_文字b_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字1_文字b_枠.Dra = value;
				this.X0Y1_悪タトゥ_文字1_文字b_枠.Dra = value;
				this.X0Y0_悪タトゥ_文字1_文字b_枠.Hit = value;
				this.X0Y1_悪タトゥ_文字1_文字b_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_文字1_文字b_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字1_文字b_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字1_文字b_文字タトゥ1.Dra = value;
				this.X0Y1_悪タトゥ_文字1_文字b_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_文字1_文字b_文字タトゥ1.Hit = value;
				this.X0Y1_悪タトゥ_文字1_文字b_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_文字1_文字b_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字1_文字b_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字1_文字b_文字タトゥ2.Dra = value;
				this.X0Y1_悪タトゥ_文字1_文字b_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_文字1_文字b_文字タトゥ2.Hit = value;
				this.X0Y1_悪タトゥ_文字1_文字b_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_文字1_文字c_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字1_文字c_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字1_文字c_枠.Dra = value;
				this.X0Y1_悪タトゥ_文字1_文字c_枠.Dra = value;
				this.X0Y0_悪タトゥ_文字1_文字c_枠.Hit = value;
				this.X0Y1_悪タトゥ_文字1_文字c_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_文字1_文字c_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字1_文字c_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字1_文字c_文字タトゥ1.Dra = value;
				this.X0Y1_悪タトゥ_文字1_文字c_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_文字1_文字c_文字タトゥ1.Hit = value;
				this.X0Y1_悪タトゥ_文字1_文字c_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_文字1_文字c_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字1_文字c_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字1_文字c_文字タトゥ2.Dra = value;
				this.X0Y1_悪タトゥ_文字1_文字c_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_文字1_文字c_文字タトゥ2.Hit = value;
				this.X0Y1_悪タトゥ_文字1_文字c_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_文字1_文字d_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字1_文字d_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字1_文字d_枠.Dra = value;
				this.X0Y1_悪タトゥ_文字1_文字d_枠.Dra = value;
				this.X0Y0_悪タトゥ_文字1_文字d_枠.Hit = value;
				this.X0Y1_悪タトゥ_文字1_文字d_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_文字1_文字d_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字1_文字d_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字1_文字d_文字タトゥ1.Dra = value;
				this.X0Y1_悪タトゥ_文字1_文字d_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_文字1_文字d_文字タトゥ1.Hit = value;
				this.X0Y1_悪タトゥ_文字1_文字d_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_文字1_文字d_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字1_文字d_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字1_文字d_文字タトゥ2.Dra = value;
				this.X0Y1_悪タトゥ_文字1_文字d_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_文字1_文字d_文字タトゥ2.Hit = value;
				this.X0Y1_悪タトゥ_文字1_文字d_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_文字1_文字e_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字1_文字e_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字1_文字e_枠.Dra = value;
				this.X0Y1_悪タトゥ_文字1_文字e_枠.Dra = value;
				this.X0Y0_悪タトゥ_文字1_文字e_枠.Hit = value;
				this.X0Y1_悪タトゥ_文字1_文字e_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_文字1_文字e_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ1.Dra = value;
				this.X0Y1_悪タトゥ_文字1_文字e_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ1.Hit = value;
				this.X0Y1_悪タトゥ_文字1_文字e_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_文字1_文字e_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ2.Dra = value;
				this.X0Y1_悪タトゥ_文字1_文字e_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ2.Hit = value;
				this.X0Y1_悪タトゥ_文字1_文字e_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_文字1_文字e_文字タトゥ3_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ3.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ3.Dra = value;
				this.X0Y1_悪タトゥ_文字1_文字e_文字タトゥ3.Dra = value;
				this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ3.Hit = value;
				this.X0Y1_悪タトゥ_文字1_文字e_文字タトゥ3.Hit = value;
			}
		}

		public bool 悪タトゥ_文字2_文字a_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字2_文字a_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字2_文字a_枠.Dra = value;
				this.X0Y1_悪タトゥ_文字2_文字a_枠.Dra = value;
				this.X0Y0_悪タトゥ_文字2_文字a_枠.Hit = value;
				this.X0Y1_悪タトゥ_文字2_文字a_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_文字2_文字a_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字2_文字a_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字2_文字a_文字タトゥ1.Dra = value;
				this.X0Y1_悪タトゥ_文字2_文字a_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_文字2_文字a_文字タトゥ1.Hit = value;
				this.X0Y1_悪タトゥ_文字2_文字a_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_文字2_文字a_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字2_文字a_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字2_文字a_文字タトゥ2.Dra = value;
				this.X0Y1_悪タトゥ_文字2_文字a_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_文字2_文字a_文字タトゥ2.Hit = value;
				this.X0Y1_悪タトゥ_文字2_文字a_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_文字2_文字b_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字2_文字b_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字2_文字b_枠.Dra = value;
				this.X0Y1_悪タトゥ_文字2_文字b_枠.Dra = value;
				this.X0Y0_悪タトゥ_文字2_文字b_枠.Hit = value;
				this.X0Y1_悪タトゥ_文字2_文字b_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_文字2_文字b_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字2_文字b_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字2_文字b_文字タトゥ1.Dra = value;
				this.X0Y1_悪タトゥ_文字2_文字b_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_文字2_文字b_文字タトゥ1.Hit = value;
				this.X0Y1_悪タトゥ_文字2_文字b_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_文字2_文字b_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字2_文字b_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字2_文字b_文字タトゥ2.Dra = value;
				this.X0Y1_悪タトゥ_文字2_文字b_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_文字2_文字b_文字タトゥ2.Hit = value;
				this.X0Y1_悪タトゥ_文字2_文字b_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_文字2_文字c_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字2_文字c_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字2_文字c_枠.Dra = value;
				this.X0Y1_悪タトゥ_文字2_文字c_枠.Dra = value;
				this.X0Y0_悪タトゥ_文字2_文字c_枠.Hit = value;
				this.X0Y1_悪タトゥ_文字2_文字c_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_文字2_文字c_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字2_文字c_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字2_文字c_文字タトゥ1.Dra = value;
				this.X0Y1_悪タトゥ_文字2_文字c_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_文字2_文字c_文字タトゥ1.Hit = value;
				this.X0Y1_悪タトゥ_文字2_文字c_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_文字2_文字c_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字2_文字c_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字2_文字c_文字タトゥ2.Dra = value;
				this.X0Y1_悪タトゥ_文字2_文字c_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_文字2_文字c_文字タトゥ2.Hit = value;
				this.X0Y1_悪タトゥ_文字2_文字c_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_文字2_文字d_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字2_文字d_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字2_文字d_枠.Dra = value;
				this.X0Y1_悪タトゥ_文字2_文字d_枠.Dra = value;
				this.X0Y0_悪タトゥ_文字2_文字d_枠.Hit = value;
				this.X0Y1_悪タトゥ_文字2_文字d_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_文字2_文字d_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字2_文字d_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字2_文字d_文字タトゥ1.Dra = value;
				this.X0Y1_悪タトゥ_文字2_文字d_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_文字2_文字d_文字タトゥ1.Hit = value;
				this.X0Y1_悪タトゥ_文字2_文字d_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_文字2_文字d_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字2_文字d_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字2_文字d_文字タトゥ2.Dra = value;
				this.X0Y1_悪タトゥ_文字2_文字d_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_文字2_文字d_文字タトゥ2.Hit = value;
				this.X0Y1_悪タトゥ_文字2_文字d_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_文字2_文字e_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字2_文字e_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字2_文字e_枠.Dra = value;
				this.X0Y1_悪タトゥ_文字2_文字e_枠.Dra = value;
				this.X0Y0_悪タトゥ_文字2_文字e_枠.Hit = value;
				this.X0Y1_悪タトゥ_文字2_文字e_枠.Hit = value;
			}
		}

		public bool 悪タトゥ_文字2_文字e_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ1.Dra = value;
				this.X0Y1_悪タトゥ_文字2_文字e_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ1.Hit = value;
				this.X0Y1_悪タトゥ_文字2_文字e_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_文字2_文字e_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ2.Dra = value;
				this.X0Y1_悪タトゥ_文字2_文字e_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ2.Hit = value;
				this.X0Y1_悪タトゥ_文字2_文字e_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_文字2_文字e_文字タトゥ3_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ3.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ3.Dra = value;
				this.X0Y1_悪タトゥ_文字2_文字e_文字タトゥ3.Dra = value;
				this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ3.Hit = value;
				this.X0Y1_悪タトゥ_文字2_文字e_文字タトゥ3.Hit = value;
			}
		}

		public bool 悪タトゥ_タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_タトゥ1.Dra = value;
				this.X0Y1_悪タトゥ_タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ_タトゥ1.Hit = value;
				this.X0Y1_悪タトゥ_タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ_タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_タトゥ2.Dra = value;
				this.X0Y1_悪タトゥ_タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_タトゥ2.Hit = value;
				this.X0Y1_悪タトゥ_タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ_逆十字_逆十字1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_逆十字_逆十字1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_逆十字_逆十字1.Dra = value;
				this.X0Y1_悪タトゥ_逆十字_逆十字1.Dra = value;
				this.X0Y0_悪タトゥ_逆十字_逆十字1.Hit = value;
				this.X0Y1_悪タトゥ_逆十字_逆十字1.Hit = value;
			}
		}

		public bool 悪タトゥ_逆十字_逆十字2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_逆十字_逆十字2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_逆十字_逆十字2.Dra = value;
				this.X0Y1_悪タトゥ_逆十字_逆十字2.Dra = value;
				this.X0Y0_悪タトゥ_逆十字_逆十字2.Hit = value;
				this.X0Y1_悪タトゥ_逆十字_逆十字2.Hit = value;
			}
		}

		public bool 悪タトゥ_タトゥ左_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_タトゥ左.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_タトゥ左.Dra = value;
				this.X0Y1_悪タトゥ_タトゥ左.Dra = value;
				this.X0Y0_悪タトゥ_タトゥ左.Hit = value;
				this.X0Y1_悪タトゥ_タトゥ左.Hit = value;
			}
		}

		public bool 悪タトゥ_タトゥ右_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_タトゥ右.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_タトゥ右.Dra = value;
				this.X0Y1_悪タトゥ_タトゥ右.Dra = value;
				this.X0Y0_悪タトゥ_タトゥ右.Hit = value;
				this.X0Y1_悪タトゥ_タトゥ右.Hit = value;
			}
		}

		public bool 紋柄_紋1_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋1.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋1.Dra = value;
				this.X0Y1_紋柄_紋1.Dra = value;
				this.X0Y0_紋柄_紋1.Hit = value;
				this.X0Y1_紋柄_紋1.Hit = value;
			}
		}

		public bool 紋柄_紋2_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋2.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋2.Dra = value;
				this.X0Y1_紋柄_紋2.Dra = value;
				this.X0Y0_紋柄_紋2.Hit = value;
				this.X0Y1_紋柄_紋2.Hit = value;
			}
		}

		public bool 紋柄_紋3_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋3.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋3.Dra = value;
				this.X0Y1_紋柄_紋3.Dra = value;
				this.X0Y0_紋柄_紋3.Hit = value;
				this.X0Y1_紋柄_紋3.Hit = value;
			}
		}

		public bool 紋柄_紋4_表示
		{
			get
			{
				return this.X0Y0_紋柄_紋4.Dra;
			}
			set
			{
				this.X0Y0_紋柄_紋4.Dra = value;
				this.X0Y1_紋柄_紋4.Dra = value;
				this.X0Y0_紋柄_紋4.Hit = value;
				this.X0Y1_紋柄_紋4.Hit = value;
			}
		}

		public bool 獣性_獣毛1_表示
		{
			get
			{
				return this.X0Y0_獣性_獣毛1.Dra;
			}
			set
			{
				this.X0Y0_獣性_獣毛1.Dra = value;
				this.X0Y1_獣性_獣毛1.Dra = value;
				this.X0Y0_獣性_獣毛1.Hit = value;
				this.X0Y1_獣性_獣毛1.Hit = value;
			}
		}

		public bool 獣性_獣毛2_表示
		{
			get
			{
				return this.X0Y0_獣性_獣毛2.Dra;
			}
			set
			{
				this.X0Y0_獣性_獣毛2.Dra = value;
				this.X0Y1_獣性_獣毛2.Dra = value;
				this.X0Y0_獣性_獣毛2.Hit = value;
				this.X0Y1_獣性_獣毛2.Hit = value;
			}
		}

		public bool 獣性_獣毛3_表示
		{
			get
			{
				return this.X0Y0_獣性_獣毛3.Dra;
			}
			set
			{
				this.X0Y0_獣性_獣毛3.Dra = value;
				this.X0Y1_獣性_獣毛3.Dra = value;
				this.X0Y0_獣性_獣毛3.Hit = value;
				this.X0Y1_獣性_獣毛3.Hit = value;
			}
		}

		public bool 獣性_獣毛4_表示
		{
			get
			{
				return this.X0Y0_獣性_獣毛4.Dra;
			}
			set
			{
				this.X0Y0_獣性_獣毛4.Dra = value;
				this.X0Y1_獣性_獣毛4.Dra = value;
				this.X0Y0_獣性_獣毛4.Hit = value;
				this.X0Y1_獣性_獣毛4.Hit = value;
			}
		}

		public bool 獣性_獣毛5_表示
		{
			get
			{
				return this.X0Y0_獣性_獣毛5.Dra;
			}
			set
			{
				this.X0Y0_獣性_獣毛5.Dra = value;
				this.X0Y1_獣性_獣毛5.Dra = value;
				this.X0Y0_獣性_獣毛5.Hit = value;
				this.X0Y1_獣性_獣毛5.Hit = value;
			}
		}

		public bool 竜性_鱗_鱗1_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗_鱗1.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗_鱗1.Dra = value;
				this.X0Y1_竜性_鱗_鱗1.Dra = value;
				this.X0Y0_竜性_鱗_鱗1.Hit = value;
				this.X0Y1_竜性_鱗_鱗1.Hit = value;
			}
		}

		public bool 竜性_鱗_鱗2_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗_鱗2.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗_鱗2.Dra = value;
				this.X0Y1_竜性_鱗_鱗2.Dra = value;
				this.X0Y0_竜性_鱗_鱗2.Hit = value;
				this.X0Y1_竜性_鱗_鱗2.Hit = value;
			}
		}

		public bool 竜性_鱗_鱗3_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗_鱗3.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗_鱗3.Dra = value;
				this.X0Y1_竜性_鱗_鱗3.Dra = value;
				this.X0Y0_竜性_鱗_鱗3.Hit = value;
				this.X0Y1_竜性_鱗_鱗3.Hit = value;
			}
		}

		public bool 竜性_鱗_鱗4_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗_鱗4.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗_鱗4.Dra = value;
				this.X0Y1_竜性_鱗_鱗4.Dra = value;
				this.X0Y0_竜性_鱗_鱗4.Hit = value;
				this.X0Y1_竜性_鱗_鱗4.Hit = value;
			}
		}

		public bool 竜性_鱗_鱗5_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗_鱗5.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗_鱗5.Dra = value;
				this.X0Y1_竜性_鱗_鱗5.Dra = value;
				this.X0Y0_竜性_鱗_鱗5.Hit = value;
				this.X0Y1_竜性_鱗_鱗5.Hit = value;
			}
		}

		public bool 竜性_鱗_鱗6_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗_鱗6.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗_鱗6.Dra = value;
				this.X0Y1_竜性_鱗_鱗6.Dra = value;
				this.X0Y0_竜性_鱗_鱗6.Hit = value;
				this.X0Y1_竜性_鱗_鱗6.Hit = value;
			}
		}

		public bool 竜性_鱗_鱗7_表示
		{
			get
			{
				return this.X0Y0_竜性_鱗_鱗7.Dra;
			}
			set
			{
				this.X0Y0_竜性_鱗_鱗7.Dra = value;
				this.X0Y1_竜性_鱗_鱗7.Dra = value;
				this.X0Y0_竜性_鱗_鱗7.Hit = value;
				this.X0Y1_竜性_鱗_鱗7.Hit = value;
			}
		}

		public bool 竜性_棘_棘1_表示
		{
			get
			{
				return this.X0Y0_竜性_棘_棘1.Dra;
			}
			set
			{
				this.X0Y0_竜性_棘_棘1.Dra = value;
				this.X0Y1_竜性_棘_棘1.Dra = value;
				this.X0Y0_竜性_棘_棘1.Hit = value;
				this.X0Y1_竜性_棘_棘1.Hit = value;
			}
		}

		public bool 竜性_棘_棘2_表示
		{
			get
			{
				return this.X0Y0_竜性_棘_棘2.Dra;
			}
			set
			{
				this.X0Y0_竜性_棘_棘2.Dra = value;
				this.X0Y1_竜性_棘_棘2.Dra = value;
				this.X0Y0_竜性_棘_棘2.Hit = value;
				this.X0Y1_竜性_棘_棘2.Hit = value;
			}
		}

		public bool 竜性_棘_棘3_表示
		{
			get
			{
				return this.X0Y0_竜性_棘_棘3.Dra;
			}
			set
			{
				this.X0Y0_竜性_棘_棘3.Dra = value;
				this.X0Y1_竜性_棘_棘3.Dra = value;
				this.X0Y0_竜性_棘_棘3.Hit = value;
				this.X0Y1_竜性_棘_棘3.Hit = value;
			}
		}

		public bool 竜性_棘_棘4_表示
		{
			get
			{
				return this.X0Y0_竜性_棘_棘4.Dra;
			}
			set
			{
				this.X0Y0_竜性_棘_棘4.Dra = value;
				this.X0Y1_竜性_棘_棘4.Dra = value;
				this.X0Y0_竜性_棘_棘4.Hit = value;
				this.X0Y1_竜性_棘_棘4.Hit = value;
			}
		}

		public bool 竜性_棘_棘5_表示
		{
			get
			{
				return this.X0Y0_竜性_棘_棘5.Dra;
			}
			set
			{
				this.X0Y0_竜性_棘_棘5.Dra = value;
				this.X0Y1_竜性_棘_棘5.Dra = value;
				this.X0Y0_竜性_棘_棘5.Hit = value;
				this.X0Y1_竜性_棘_棘5.Hit = value;
			}
		}

		public bool 竜性_棘_棘6_表示
		{
			get
			{
				return this.X0Y0_竜性_棘_棘6.Dra;
			}
			set
			{
				this.X0Y0_竜性_棘_棘6.Dra = value;
				this.X0Y1_竜性_棘_棘6.Dra = value;
				this.X0Y0_竜性_棘_棘6.Hit = value;
				this.X0Y1_竜性_棘_棘6.Hit = value;
			}
		}

		public bool 虫性_棘_棘1_表示
		{
			get
			{
				return this.X0Y0_虫性_棘_棘1.Dra;
			}
			set
			{
				this.X0Y0_虫性_棘_棘1.Dra = value;
				this.X0Y1_虫性_棘_棘1.Dra = value;
				this.X0Y0_虫性_棘_棘1.Hit = value;
				this.X0Y1_虫性_棘_棘1.Hit = value;
			}
		}

		public bool 虫性_棘_棘2_表示
		{
			get
			{
				return this.X0Y0_虫性_棘_棘2.Dra;
			}
			set
			{
				this.X0Y0_虫性_棘_棘2.Dra = value;
				this.X0Y1_虫性_棘_棘2.Dra = value;
				this.X0Y0_虫性_棘_棘2.Hit = value;
				this.X0Y1_虫性_棘_棘2.Hit = value;
			}
		}

		public bool 虫性_棘_棘3_表示
		{
			get
			{
				return this.X0Y0_虫性_棘_棘3.Dra;
			}
			set
			{
				this.X0Y0_虫性_棘_棘3.Dra = value;
				this.X0Y1_虫性_棘_棘3.Dra = value;
				this.X0Y0_虫性_棘_棘3.Hit = value;
				this.X0Y1_虫性_棘_棘3.Hit = value;
			}
		}

		public bool 虫性_膝_表示
		{
			get
			{
				return this.X0Y0_虫性_膝.Dra;
			}
			set
			{
				this.X0Y0_虫性_膝.Dra = value;
				this.X0Y1_虫性_膝.Dra = value;
				this.X0Y0_虫性_膝.Hit = value;
				this.X0Y1_虫性_膝.Hit = value;
			}
		}

		public bool 虫性_線_表示
		{
			get
			{
				return this.X0Y0_虫性_線.Dra;
			}
			set
			{
				this.X0Y0_虫性_線.Dra = value;
				this.X0Y1_虫性_線.Dra = value;
				this.X0Y0_虫性_線.Hit = value;
				this.X0Y1_虫性_線.Hit = value;
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
				this.X0Y1_傷X1.Dra = value;
				this.X0Y0_傷X1.Hit = value;
				this.X0Y1_傷X1.Hit = value;
			}
		}

		public bool 傷X2_表示
		{
			get
			{
				return this.X0Y0_傷X2.Dra;
			}
			set
			{
				this.X0Y0_傷X2.Dra = value;
				this.X0Y1_傷X2.Dra = value;
				this.X0Y0_傷X2.Hit = value;
				this.X0Y1_傷X2.Hit = value;
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
				this.X0Y1_傷I1.Dra = value;
				this.X0Y0_傷I1.Hit = value;
				this.X0Y1_傷I1.Hit = value;
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
				this.X0Y1_傷I2.Dra = value;
				this.X0Y0_傷I2.Hit = value;
				this.X0Y1_傷I2.Hit = value;
			}
		}

		public bool 傷I3_表示
		{
			get
			{
				return this.X0Y0_傷I3.Dra;
			}
			set
			{
				this.X0Y0_傷I3.Dra = value;
				this.X0Y1_傷I3.Dra = value;
				this.X0Y0_傷I3.Hit = value;
				this.X0Y1_傷I3.Hit = value;
			}
		}

		public bool 傷I4_表示
		{
			get
			{
				return this.X0Y0_傷I4.Dra;
			}
			set
			{
				this.X0Y0_傷I4.Dra = value;
				this.X0Y1_傷I4.Dra = value;
				this.X0Y0_傷I4.Hit = value;
				this.X0Y1_傷I4.Hit = value;
			}
		}

		public bool 傷I5_表示
		{
			get
			{
				return this.X0Y0_傷I5.Dra;
			}
			set
			{
				this.X0Y0_傷I5.Dra = value;
				this.X0Y1_傷I5.Dra = value;
				this.X0Y0_傷I5.Hit = value;
				this.X0Y1_傷I5.Hit = value;
			}
		}

		public bool ハイライト1_表示
		{
			get
			{
				return this.X0Y0_ハイライト1.Dra;
			}
			set
			{
				this.X0Y0_ハイライト1.Dra = value;
				this.X0Y1_ハイライト1.Dra = value;
				this.X0Y0_ハイライト1.Hit = value;
				this.X0Y1_ハイライト1.Hit = value;
			}
		}

		public bool ハイライト2_表示
		{
			get
			{
				return this.X0Y0_ハイライト2.Dra;
			}
			set
			{
				this.X0Y0_ハイライト2.Dra = value;
				this.X0Y1_ハイライト2.Dra = value;
				this.X0Y0_ハイライト2.Hit = value;
				this.X0Y1_ハイライト2.Hit = value;
			}
		}

		public bool パンスト_パンスト_表示
		{
			get
			{
				return this.X0Y0_パンスト_パンスト.Dra;
			}
			set
			{
				this.X0Y0_パンスト_パンスト.Dra = value;
				this.X0Y1_パンスト_パンスト.Dra = value;
				this.X0Y0_パンスト_パンスト.Hit = value;
				this.X0Y1_パンスト_パンスト.Hit = value;
			}
		}

		public bool パンスト_ハイライト1_表示
		{
			get
			{
				return this.X0Y0_パンスト_ハイライト1.Dra;
			}
			set
			{
				this.X0Y0_パンスト_ハイライト1.Dra = value;
				this.X0Y1_パンスト_ハイライト1.Dra = value;
				this.X0Y0_パンスト_ハイライト1.Hit = value;
				this.X0Y1_パンスト_ハイライト1.Hit = value;
			}
		}

		public bool パンスト_ハイライト2_表示
		{
			get
			{
				return this.X0Y0_パンスト_ハイライト2.Dra;
			}
			set
			{
				this.X0Y0_パンスト_ハイライト2.Dra = value;
				this.X0Y1_パンスト_ハイライト2.Dra = value;
				this.X0Y0_パンスト_ハイライト2.Hit = value;
				this.X0Y1_パンスト_ハイライト2.Hit = value;
			}
		}

		public bool ソックス_ソックス_表示
		{
			get
			{
				return this.X0Y0_ソックス_ソックス.Dra;
			}
			set
			{
				this.X0Y0_ソックス_ソックス.Dra = value;
				this.X0Y1_ソックス_ソックス.Dra = value;
				this.X0Y0_ソックス_ソックス.Hit = value;
				this.X0Y1_ソックス_ソックス.Hit = value;
			}
		}

		public bool ソックス_ハイライト1_表示
		{
			get
			{
				return this.X0Y0_ソックス_ハイライト1.Dra;
			}
			set
			{
				this.X0Y0_ソックス_ハイライト1.Dra = value;
				this.X0Y1_ソックス_ハイライト1.Dra = value;
				this.X0Y0_ソックス_ハイライト1.Hit = value;
				this.X0Y1_ソックス_ハイライト1.Hit = value;
			}
		}

		public bool ソックス_ハイライト2_表示
		{
			get
			{
				return this.X0Y0_ソックス_ハイライト2.Dra;
			}
			set
			{
				this.X0Y0_ソックス_ハイライト2.Dra = value;
				this.X0Y1_ソックス_ハイライト2.Dra = value;
				this.X0Y0_ソックス_ハイライト2.Hit = value;
				this.X0Y1_ソックス_ハイライト2.Hit = value;
			}
		}

		public bool ブ\u30FCツ_タン_タン_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_タン_タン.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_タン_タン.Dra = value;
				this.X0Y1_ブ\u30FCツ_タン_タン.Dra = value;
				this.X0Y0_ブ\u30FCツ_タン_タン.Hit = value;
				this.X0Y1_ブ\u30FCツ_タン_タン.Hit = value;
			}
		}

		public bool ブ\u30FCツ_タン_縁_縁1_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_タン_縁_縁1.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_タン_縁_縁1.Dra = value;
				this.X0Y1_ブ\u30FCツ_タン_縁_縁1.Dra = value;
				this.X0Y0_ブ\u30FCツ_タン_縁_縁1.Hit = value;
				this.X0Y1_ブ\u30FCツ_タン_縁_縁1.Hit = value;
			}
		}

		public bool ブ\u30FCツ_タン_縁_縁2_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_タン_縁_縁2.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_タン_縁_縁2.Dra = value;
				this.X0Y1_ブ\u30FCツ_タン_縁_縁2.Dra = value;
				this.X0Y0_ブ\u30FCツ_タン_縁_縁2.Hit = value;
				this.X0Y1_ブ\u30FCツ_タン_縁_縁2.Hit = value;
			}
		}

		public bool ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツ_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツ.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツ.Dra = value;
				this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツ.Dra = value;
				this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツ.Hit = value;
				this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツ.Hit = value;
			}
		}

		public bool ブ\u30FCツ_ブ\u30FCツ_皺_皺1_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_皺_皺1.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_皺_皺1.Dra = value;
				this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_皺_皺1.Dra = value;
				this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_皺_皺1.Hit = value;
				this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_皺_皺1.Hit = value;
			}
		}

		public bool ブ\u30FCツ_ブ\u30FCツ_皺_皺2_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_皺_皺2.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_皺_皺2.Dra = value;
				this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_皺_皺2.Dra = value;
				this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_皺_皺2.Hit = value;
				this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_皺_皺2.Hit = value;
			}
		}

		public bool ブ\u30FCツ_ブ\u30FCツ_縁_縁1_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁1.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁1.Dra = value;
				this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁1.Dra = value;
				this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁1.Hit = value;
				this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁1.Hit = value;
			}
		}

		public bool ブ\u30FCツ_ブ\u30FCツ_縁_縁2_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁2.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁2.Dra = value;
				this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁2.Dra = value;
				this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁2.Hit = value;
				this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁2.Hit = value;
			}
		}

		public bool ブ\u30FCツ_ブ\u30FCツ_縁_縁3_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁3.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁3.Dra = value;
				this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁3.Dra = value;
				this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁3.Hit = value;
				this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁3.Hit = value;
			}
		}

		public bool ブ\u30FCツ_ブ\u30FCツ_縁_縁4_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁4.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁4.Dra = value;
				this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁4.Dra = value;
				this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁4.Hit = value;
				this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁4.Hit = value;
			}
		}

		public bool ブ\u30FCツ_柄_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_柄.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_柄.Dra = value;
				this.X0Y1_ブ\u30FCツ_柄.Dra = value;
				this.X0Y0_ブ\u30FCツ_柄.Hit = value;
				this.X0Y1_ブ\u30FCツ_柄.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐1_紐下_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐1_紐下_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐1_紐下_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐1_紐上_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐1_紐上_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐1_紐上_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐2_紐下_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐2_紐下_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐2_紐下_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐2_紐上_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐2_紐上_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐2_紐上_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐3_紐下_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐3_紐下_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐3_紐下_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐3_紐上_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐3_紐上_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐3_紐上_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐4_紐下_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐4_紐下_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐4_紐下_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐4_紐上_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐4_紐上_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐4_紐上_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐5_紐下_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐5_紐下_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐5_紐下_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐5_紐上_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐5_紐上_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐5_紐上_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐6_紐下_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐6_紐下_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐6_紐下_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐6_紐上_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐6_紐上_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐6_紐上_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐7_紐下_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐7_紐下_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐7_紐下_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐7_紐上_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐7_紐上_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐7_紐上_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐8_紐下_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐8_紐下_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐8_紐下_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐8_紐上_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐8_紐上_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐8_紐上_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐9_紐下_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐9_紐下_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐9_紐下_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐9_紐上_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐9_紐上_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐9_紐上_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐10_紐下_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐10_紐下_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐10_紐下_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐10_紐上_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐10_紐上_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐10_紐上_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐11_紐下_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐11_紐下_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐11_紐下_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐11_紐上_金具上_金具_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_金具上_金具.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_金具上_金具.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_金具上_金具.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_金具上_金具.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_金具上_金具.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐11_紐上_金具上_穴_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_金具上_穴.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_金具上_穴.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_金具上_穴.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_金具上_穴.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_金具上_穴.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_紐11_紐上_紐_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_紐.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_紐.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_紐.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_紐.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_紐.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_結び_紐左_紐3_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐3.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐3.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐3.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐3.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐3.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_結び_紐左_紐2_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐2.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐2.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐2.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐2.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐2.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_結び_紐左_紐1_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐1.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐1.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐1.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐1.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐1.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_結び_紐右_紐3_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐3.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐3.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐3.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐3.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐3.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_結び_紐右_紐2_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐2.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐2.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐2.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐2.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐2.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_結び_紐右_紐1_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐1.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐1.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐1.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐1.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐1.Hit = value;
			}
		}

		public bool ブ\u30FCツ_紐_結び_結び目_表示
		{
			get
			{
				return this.X0Y0_ブ\u30FCツ_紐_結び_結び目.Dra;
			}
			set
			{
				this.X0Y0_ブ\u30FCツ_紐_結び_結び目.Dra = value;
				this.X0Y1_ブ\u30FCツ_紐_結び_結び目.Dra = value;
				this.X0Y0_ブ\u30FCツ_紐_結び_結び目.Hit = value;
				this.X0Y1_ブ\u30FCツ_紐_結び_結び目.Hit = value;
			}
		}

		public bool ア\u30FCマ_ベ\u30FCス_表示
		{
			get
			{
				return this.X0Y0_ア\u30FCマ_ベ\u30FCス.Dra;
			}
			set
			{
				this.X0Y0_ア\u30FCマ_ベ\u30FCス.Dra = value;
				this.X0Y1_ア\u30FCマ_ベ\u30FCス.Dra = value;
				this.X0Y0_ア\u30FCマ_ベ\u30FCス.Hit = value;
				this.X0Y1_ア\u30FCマ_ベ\u30FCス.Hit = value;
			}
		}

		public bool ア\u30FCマ_脛当_脛当1_表示
		{
			get
			{
				return this.X0Y0_ア\u30FCマ_脛当_脛当1.Dra;
			}
			set
			{
				this.X0Y0_ア\u30FCマ_脛当_脛当1.Dra = value;
				this.X0Y1_ア\u30FCマ_脛当_脛当1.Dra = value;
				this.X0Y0_ア\u30FCマ_脛当_脛当1.Hit = value;
				this.X0Y1_ア\u30FCマ_脛当_脛当1.Hit = value;
			}
		}

		public bool ア\u30FCマ_脛当_脛当2_表示
		{
			get
			{
				return this.X0Y0_ア\u30FCマ_脛当_脛当2.Dra;
			}
			set
			{
				this.X0Y0_ア\u30FCマ_脛当_脛当2.Dra = value;
				this.X0Y1_ア\u30FCマ_脛当_脛当2.Dra = value;
				this.X0Y0_ア\u30FCマ_脛当_脛当2.Hit = value;
				this.X0Y1_ア\u30FCマ_脛当_脛当2.Hit = value;
			}
		}

		public bool ア\u30FCマ_膝当_表示
		{
			get
			{
				return this.X0Y0_ア\u30FCマ_膝当.Dra;
			}
			set
			{
				this.X0Y0_ア\u30FCマ_膝当.Dra = value;
				this.X0Y1_ア\u30FCマ_膝当.Dra = value;
				this.X0Y0_ア\u30FCマ_膝当.Hit = value;
				this.X0Y1_ア\u30FCマ_膝当.Hit = value;
			}
		}

		public bool ア\u30FCマ_穴_穴1_表示
		{
			get
			{
				return this.X0Y0_ア\u30FCマ_穴_穴1.Dra;
			}
			set
			{
				this.X0Y0_ア\u30FCマ_穴_穴1.Dra = value;
				this.X0Y1_ア\u30FCマ_穴_穴1.Dra = value;
				this.X0Y0_ア\u30FCマ_穴_穴1.Hit = value;
				this.X0Y1_ア\u30FCマ_穴_穴1.Hit = value;
			}
		}

		public bool ア\u30FCマ_穴_穴2_表示
		{
			get
			{
				return this.X0Y0_ア\u30FCマ_穴_穴2.Dra;
			}
			set
			{
				this.X0Y0_ア\u30FCマ_穴_穴2.Dra = value;
				this.X0Y1_ア\u30FCマ_穴_穴2.Dra = value;
				this.X0Y0_ア\u30FCマ_穴_穴2.Hit = value;
				this.X0Y1_ア\u30FCマ_穴_穴2.Hit = value;
			}
		}

		public bool ア\u30FCマ_穴_穴3_表示
		{
			get
			{
				return this.X0Y0_ア\u30FCマ_穴_穴3.Dra;
			}
			set
			{
				this.X0Y0_ア\u30FCマ_穴_穴3.Dra = value;
				this.X0Y1_ア\u30FCマ_穴_穴3.Dra = value;
				this.X0Y0_ア\u30FCマ_穴_穴3.Hit = value;
				this.X0Y1_ア\u30FCマ_穴_穴3.Hit = value;
			}
		}

		public bool ア\u30FCマ_穴_穴4_表示
		{
			get
			{
				return this.X0Y0_ア\u30FCマ_穴_穴4.Dra;
			}
			set
			{
				this.X0Y0_ア\u30FCマ_穴_穴4.Dra = value;
				this.X0Y1_ア\u30FCマ_穴_穴4.Dra = value;
				this.X0Y0_ア\u30FCマ_穴_穴4.Hit = value;
				this.X0Y1_ア\u30FCマ_穴_穴4.Hit = value;
			}
		}

		public bool 脚輪上_革_表示
		{
			get
			{
				return this.X0Y0_脚輪上_革.Dra;
			}
			set
			{
				this.X0Y0_脚輪上_革.Dra = value;
				this.X0Y1_脚輪上_革.Dra = value;
				this.X0Y0_脚輪上_革.Hit = value;
				this.X0Y1_脚輪上_革.Hit = value;
			}
		}

		public bool 脚輪上_金具1_表示
		{
			get
			{
				return this.X0Y0_脚輪上_金具1.Dra;
			}
			set
			{
				this.X0Y0_脚輪上_金具1.Dra = value;
				this.X0Y1_脚輪上_金具1.Dra = value;
				this.X0Y0_脚輪上_金具1.Hit = value;
				this.X0Y1_脚輪上_金具1.Hit = value;
			}
		}

		public bool 脚輪上_金具2_表示
		{
			get
			{
				return this.X0Y0_脚輪上_金具2.Dra;
			}
			set
			{
				this.X0Y0_脚輪上_金具2.Dra = value;
				this.X0Y1_脚輪上_金具2.Dra = value;
				this.X0Y0_脚輪上_金具2.Hit = value;
				this.X0Y1_脚輪上_金具2.Hit = value;
			}
		}

		public bool 脚輪上_金具3_表示
		{
			get
			{
				return this.X0Y0_脚輪上_金具3.Dra;
			}
			set
			{
				this.X0Y0_脚輪上_金具3.Dra = value;
				this.X0Y1_脚輪上_金具3.Dra = value;
				this.X0Y0_脚輪上_金具3.Hit = value;
				this.X0Y1_脚輪上_金具3.Hit = value;
			}
		}

		public bool 脚輪上_金具左_表示
		{
			get
			{
				return this.X0Y0_脚輪上_金具左.Dra;
			}
			set
			{
				this.X0Y0_脚輪上_金具左.Dra = value;
				this.X0Y1_脚輪上_金具左.Dra = value;
				this.X0Y0_脚輪上_金具左.Hit = value;
				this.X0Y1_脚輪上_金具左.Hit = value;
			}
		}

		public bool 脚輪上_金具右_表示
		{
			get
			{
				return this.X0Y0_脚輪上_金具右.Dra;
			}
			set
			{
				this.X0Y0_脚輪上_金具右.Dra = value;
				this.X0Y1_脚輪上_金具右.Dra = value;
				this.X0Y0_脚輪上_金具右.Hit = value;
				this.X0Y1_脚輪上_金具右.Hit = value;
			}
		}

		public bool 脚輪下_革_表示
		{
			get
			{
				return this.X0Y0_脚輪下_革.Dra;
			}
			set
			{
				this.X0Y0_脚輪下_革.Dra = value;
				this.X0Y1_脚輪下_革.Dra = value;
				this.X0Y0_脚輪下_革.Hit = value;
				this.X0Y1_脚輪下_革.Hit = value;
			}
		}

		public bool 脚輪下_金具1_表示
		{
			get
			{
				return this.X0Y0_脚輪下_金具1.Dra;
			}
			set
			{
				this.X0Y0_脚輪下_金具1.Dra = value;
				this.X0Y1_脚輪下_金具1.Dra = value;
				this.X0Y0_脚輪下_金具1.Hit = value;
				this.X0Y1_脚輪下_金具1.Hit = value;
			}
		}

		public bool 脚輪下_金具2_表示
		{
			get
			{
				return this.X0Y0_脚輪下_金具2.Dra;
			}
			set
			{
				this.X0Y0_脚輪下_金具2.Dra = value;
				this.X0Y1_脚輪下_金具2.Dra = value;
				this.X0Y0_脚輪下_金具2.Hit = value;
				this.X0Y1_脚輪下_金具2.Hit = value;
			}
		}

		public bool 脚輪下_金具3_表示
		{
			get
			{
				return this.X0Y0_脚輪下_金具3.Dra;
			}
			set
			{
				this.X0Y0_脚輪下_金具3.Dra = value;
				this.X0Y1_脚輪下_金具3.Dra = value;
				this.X0Y0_脚輪下_金具3.Hit = value;
				this.X0Y1_脚輪下_金具3.Hit = value;
			}
		}

		public bool 脚輪下_金具左_表示
		{
			get
			{
				return this.X0Y0_脚輪下_金具左.Dra;
			}
			set
			{
				this.X0Y0_脚輪下_金具左.Dra = value;
				this.X0Y1_脚輪下_金具左.Dra = value;
				this.X0Y0_脚輪下_金具左.Hit = value;
				this.X0Y1_脚輪下_金具左.Hit = value;
			}
		}

		public bool 脚輪下_金具右_表示
		{
			get
			{
				return this.X0Y0_脚輪下_金具右.Dra;
			}
			set
			{
				this.X0Y0_脚輪下_金具右.Dra = value;
				this.X0Y1_脚輪下_金具右.Dra = value;
				this.X0Y0_脚輪下_金具右.Hit = value;
				this.X0Y1_脚輪下_金具右.Hit = value;
			}
		}

		public bool ハイライト表示
		{
			get
			{
				return this.ハイライト1_表示;
			}
			set
			{
				this.ハイライト1_表示 = value;
				this.ハイライト2_表示 = value;
			}
		}

		public double 筋肉濃度
		{
			get
			{
				return this.筋CD.不透明度;
			}
			set
			{
				this.筋CD.不透明度 = value;
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

		public double 傷X2濃度
		{
			get
			{
				return this.傷X2CD.不透明度;
			}
			set
			{
				this.傷X2CD.不透明度 = value;
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

		public double 傷I3濃度
		{
			get
			{
				return this.傷I3CD.不透明度;
			}
			set
			{
				this.傷I3CD.不透明度 = value;
			}
		}

		public double 傷I4濃度
		{
			get
			{
				return this.傷I4CD.不透明度;
			}
			set
			{
				this.傷I4CD.不透明度 = value;
			}
		}

		public double 傷I5濃度
		{
			get
			{
				return this.傷I5CD.不透明度;
			}
			set
			{
				this.傷I5CD.不透明度 = value;
			}
		}

		public double ハイライト濃度
		{
			get
			{
				return this.ハイライト1CD.不透明度;
			}
			set
			{
				this.ハイライト1CD.不透明度 = value;
				this.ハイライト2CD.不透明度 = value;
			}
		}

		public bool 脚輪上表示
		{
			get
			{
				return this.脚輪上_革_表示;
			}
			set
			{
				this.脚輪上_革_表示 = value;
				this.脚輪上_金具1_表示 = value;
				this.脚輪上_金具2_表示 = value;
				this.脚輪上_金具3_表示 = value;
				this.脚輪上_金具左_表示 = value;
				this.脚輪上_金具右_表示 = value;
			}
		}

		public bool 脚輪下表示
		{
			get
			{
				return this.脚輪下_革_表示;
			}
			set
			{
				this.脚輪下_革_表示 = value;
				this.脚輪下_金具1_表示 = value;
				this.脚輪下_金具2_表示 = value;
				this.脚輪下_金具3_表示 = value;
				this.脚輪下_金具左_表示 = value;
				this.脚輪下_金具右_表示 = value;
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
				this.鎖3.表示 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.脚_表示;
			}
			set
			{
				this.脚_表示 = value;
				this.筋_表示 = value;
				this.淫タトゥ_足首_タトゥ_表示 = value;
				this.淫タトゥ_足首_ハ\u30FCト1_タトゥ左_表示 = value;
				this.淫タトゥ_足首_ハ\u30FCト1_タトゥ右_表示 = value;
				this.淫タトゥ_足首_ハ\u30FCト3_タトゥ左_表示 = value;
				this.淫タトゥ_足首_ハ\u30FCト3_タトゥ右_表示 = value;
				this.淫タトゥ_足首_ハ\u30FCト2_タトゥ左_表示 = value;
				this.淫タトゥ_足首_ハ\u30FCト2_タトゥ右_表示 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ左_表示 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ右_表示 = value;
				this.淫タトゥ_タトゥ左_表示 = value;
				this.淫タトゥ_タトゥ右_表示 = value;
				this.悪タトゥ_文字1_文字a_枠_表示 = value;
				this.悪タトゥ_文字1_文字a_文字タトゥ1_表示 = value;
				this.悪タトゥ_文字1_文字a_文字タトゥ2_表示 = value;
				this.悪タトゥ_文字1_文字b_枠_表示 = value;
				this.悪タトゥ_文字1_文字b_文字タトゥ1_表示 = value;
				this.悪タトゥ_文字1_文字b_文字タトゥ2_表示 = value;
				this.悪タトゥ_文字1_文字c_枠_表示 = value;
				this.悪タトゥ_文字1_文字c_文字タトゥ1_表示 = value;
				this.悪タトゥ_文字1_文字c_文字タトゥ2_表示 = value;
				this.悪タトゥ_文字1_文字d_枠_表示 = value;
				this.悪タトゥ_文字1_文字d_文字タトゥ1_表示 = value;
				this.悪タトゥ_文字1_文字d_文字タトゥ2_表示 = value;
				this.悪タトゥ_文字1_文字e_枠_表示 = value;
				this.悪タトゥ_文字1_文字e_文字タトゥ1_表示 = value;
				this.悪タトゥ_文字1_文字e_文字タトゥ2_表示 = value;
				this.悪タトゥ_文字1_文字e_文字タトゥ3_表示 = value;
				this.悪タトゥ_文字2_文字a_枠_表示 = value;
				this.悪タトゥ_文字2_文字a_文字タトゥ1_表示 = value;
				this.悪タトゥ_文字2_文字a_文字タトゥ2_表示 = value;
				this.悪タトゥ_文字2_文字b_枠_表示 = value;
				this.悪タトゥ_文字2_文字b_文字タトゥ1_表示 = value;
				this.悪タトゥ_文字2_文字b_文字タトゥ2_表示 = value;
				this.悪タトゥ_文字2_文字c_枠_表示 = value;
				this.悪タトゥ_文字2_文字c_文字タトゥ1_表示 = value;
				this.悪タトゥ_文字2_文字c_文字タトゥ2_表示 = value;
				this.悪タトゥ_文字2_文字d_枠_表示 = value;
				this.悪タトゥ_文字2_文字d_文字タトゥ1_表示 = value;
				this.悪タトゥ_文字2_文字d_文字タトゥ2_表示 = value;
				this.悪タトゥ_文字2_文字e_枠_表示 = value;
				this.悪タトゥ_文字2_文字e_文字タトゥ1_表示 = value;
				this.悪タトゥ_文字2_文字e_文字タトゥ2_表示 = value;
				this.悪タトゥ_文字2_文字e_文字タトゥ3_表示 = value;
				this.悪タトゥ_タトゥ1_表示 = value;
				this.悪タトゥ_タトゥ2_表示 = value;
				this.悪タトゥ_逆十字_逆十字1_表示 = value;
				this.悪タトゥ_逆十字_逆十字2_表示 = value;
				this.悪タトゥ_タトゥ左_表示 = value;
				this.悪タトゥ_タトゥ右_表示 = value;
				this.紋柄_紋1_表示 = value;
				this.紋柄_紋2_表示 = value;
				this.紋柄_紋3_表示 = value;
				this.紋柄_紋4_表示 = value;
				this.獣性_獣毛1_表示 = value;
				this.獣性_獣毛2_表示 = value;
				this.獣性_獣毛3_表示 = value;
				this.獣性_獣毛4_表示 = value;
				this.獣性_獣毛5_表示 = value;
				this.竜性_鱗_鱗1_表示 = value;
				this.竜性_鱗_鱗2_表示 = value;
				this.竜性_鱗_鱗3_表示 = value;
				this.竜性_鱗_鱗4_表示 = value;
				this.竜性_鱗_鱗5_表示 = value;
				this.竜性_鱗_鱗6_表示 = value;
				this.竜性_鱗_鱗7_表示 = value;
				this.竜性_棘_棘1_表示 = value;
				this.竜性_棘_棘2_表示 = value;
				this.竜性_棘_棘3_表示 = value;
				this.竜性_棘_棘4_表示 = value;
				this.竜性_棘_棘5_表示 = value;
				this.竜性_棘_棘6_表示 = value;
				this.虫性_棘_棘1_表示 = value;
				this.虫性_棘_棘2_表示 = value;
				this.虫性_棘_棘3_表示 = value;
				this.虫性_膝_表示 = value;
				this.虫性_線_表示 = value;
				this.傷X1_表示 = value;
				this.傷X2_表示 = value;
				this.傷I1_表示 = value;
				this.傷I2_表示 = value;
				this.傷I3_表示 = value;
				this.傷I4_表示 = value;
				this.傷I5_表示 = value;
				this.ハイライト1_表示 = value;
				this.ハイライト2_表示 = value;
				this.パンスト_パンスト_表示 = value;
				this.パンスト_ハイライト1_表示 = value;
				this.パンスト_ハイライト2_表示 = value;
				this.ソックス_ソックス_表示 = value;
				this.ソックス_ハイライト1_表示 = value;
				this.ソックス_ハイライト2_表示 = value;
				this.ブ\u30FCツ_タン_タン_表示 = value;
				this.ブ\u30FCツ_タン_縁_縁1_表示 = value;
				this.ブ\u30FCツ_タン_縁_縁2_表示 = value;
				this.ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツ_表示 = value;
				this.ブ\u30FCツ_ブ\u30FCツ_皺_皺1_表示 = value;
				this.ブ\u30FCツ_ブ\u30FCツ_皺_皺2_表示 = value;
				this.ブ\u30FCツ_ブ\u30FCツ_縁_縁1_表示 = value;
				this.ブ\u30FCツ_ブ\u30FCツ_縁_縁2_表示 = value;
				this.ブ\u30FCツ_ブ\u30FCツ_縁_縁3_表示 = value;
				this.ブ\u30FCツ_ブ\u30FCツ_縁_縁4_表示 = value;
				this.ブ\u30FCツ_柄_表示 = value;
				this.ブ\u30FCツ_紐_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐1_紐下_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐1_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐1_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐1_紐上_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐2_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐2_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐2_紐下_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐2_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐2_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐2_紐上_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐3_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐3_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐3_紐下_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐3_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐3_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐3_紐上_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐4_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐4_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐4_紐下_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐4_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐4_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐4_紐上_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐5_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐5_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐5_紐下_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐5_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐5_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐5_紐上_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐6_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐6_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐6_紐下_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐6_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐6_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐6_紐上_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐7_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐7_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐7_紐下_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐7_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐7_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐7_紐上_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐8_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐8_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐8_紐下_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐8_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐8_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐8_紐上_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐9_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐9_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐9_紐下_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐9_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐9_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐9_紐上_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐10_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐10_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐10_紐下_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐10_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐10_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐10_紐上_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐11_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐11_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐11_紐下_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐11_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐11_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐11_紐上_紐_表示 = value;
				this.ブ\u30FCツ_紐_結び_紐左_紐3_表示 = value;
				this.ブ\u30FCツ_紐_結び_紐左_紐2_表示 = value;
				this.ブ\u30FCツ_紐_結び_紐左_紐1_表示 = value;
				this.ブ\u30FCツ_紐_結び_紐右_紐3_表示 = value;
				this.ブ\u30FCツ_紐_結び_紐右_紐2_表示 = value;
				this.ブ\u30FCツ_紐_結び_紐右_紐1_表示 = value;
				this.ブ\u30FCツ_紐_結び_結び目_表示 = value;
				this.ア\u30FCマ_ベ\u30FCス_表示 = value;
				this.ア\u30FCマ_脛当_脛当1_表示 = value;
				this.ア\u30FCマ_脛当_脛当2_表示 = value;
				this.ア\u30FCマ_膝当_表示 = value;
				this.ア\u30FCマ_穴_穴1_表示 = value;
				this.ア\u30FCマ_穴_穴2_表示 = value;
				this.ア\u30FCマ_穴_穴3_表示 = value;
				this.ア\u30FCマ_穴_穴4_表示 = value;
				this.脚輪上_革_表示 = value;
				this.脚輪上_金具1_表示 = value;
				this.脚輪上_金具2_表示 = value;
				this.脚輪上_金具3_表示 = value;
				this.脚輪上_金具左_表示 = value;
				this.脚輪上_金具右_表示 = value;
				this.脚輪下_革_表示 = value;
				this.脚輪下_金具1_表示 = value;
				this.脚輪下_金具2_表示 = value;
				this.脚輪下_金具3_表示 = value;
				this.脚輪下_金具左_表示 = value;
				this.脚輪下_金具右_表示 = value;
				this.鎖1.表示 = value;
				this.鎖3.表示 = value;
			}
		}

		public override void Dispose()
		{
			base.Dispose();
			this.鎖1.Dispose();
			this.鎖3.Dispose();
		}

		public override double 濃度
		{
			get
			{
				return this.脚CD.不透明度;
			}
			set
			{
				this.脚CD.不透明度 = value;
				this.筋CD.不透明度 = value;
				this.淫タトゥ_足首_タトゥCD.不透明度 = value;
				this.淫タトゥ_足首_ハ\u30FCト1_タトゥ左CD.不透明度 = value;
				this.淫タトゥ_足首_ハ\u30FCト1_タトゥ右CD.不透明度 = value;
				this.淫タトゥ_足首_ハ\u30FCト3_タトゥ左CD.不透明度 = value;
				this.淫タトゥ_足首_ハ\u30FCト3_タトゥ右CD.不透明度 = value;
				this.淫タトゥ_足首_ハ\u30FCト2_タトゥ左CD.不透明度 = value;
				this.淫タトゥ_足首_ハ\u30FCト2_タトゥ右CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ左CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ右CD.不透明度 = value;
				this.淫タトゥ_タトゥ左CD.不透明度 = value;
				this.淫タトゥ_タトゥ右CD.不透明度 = value;
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
				this.悪タトゥ_タトゥ左CD.不透明度 = value;
				this.悪タトゥ_タトゥ右CD.不透明度 = value;
				this.紋柄_紋1CD.不透明度 = value;
				this.紋柄_紋2CD.不透明度 = value;
				this.紋柄_紋3CD.不透明度 = value;
				this.紋柄_紋4CD.不透明度 = value;
				this.獣性_獣毛1CD.不透明度 = value;
				this.獣性_獣毛2CD.不透明度 = value;
				this.獣性_獣毛3CD.不透明度 = value;
				this.獣性_獣毛4CD.不透明度 = value;
				this.獣性_獣毛5CD.不透明度 = value;
				this.竜性_鱗_鱗1CD.不透明度 = value;
				this.竜性_鱗_鱗2CD.不透明度 = value;
				this.竜性_鱗_鱗3CD.不透明度 = value;
				this.竜性_鱗_鱗4CD.不透明度 = value;
				this.竜性_鱗_鱗5CD.不透明度 = value;
				this.竜性_鱗_鱗6CD.不透明度 = value;
				this.竜性_鱗_鱗7CD.不透明度 = value;
				this.竜性_棘_棘1CD.不透明度 = value;
				this.竜性_棘_棘2CD.不透明度 = value;
				this.竜性_棘_棘3CD.不透明度 = value;
				this.竜性_棘_棘4CD.不透明度 = value;
				this.竜性_棘_棘5CD.不透明度 = value;
				this.竜性_棘_棘6CD.不透明度 = value;
				this.虫性_棘_棘1CD.不透明度 = value;
				this.虫性_棘_棘2CD.不透明度 = value;
				this.虫性_棘_棘3CD.不透明度 = value;
				this.虫性_膝CD.不透明度 = value;
				this.虫性_線CD.不透明度 = value;
				this.傷X1CD.不透明度 = value;
				this.傷X2CD.不透明度 = value;
				this.傷I1CD.不透明度 = value;
				this.傷I2CD.不透明度 = value;
				this.傷I3CD.不透明度 = value;
				this.傷I4CD.不透明度 = value;
				this.傷I5CD.不透明度 = value;
				this.ハイライト1CD.不透明度 = value;
				this.ハイライト2CD.不透明度 = value;
				this.パンスト_パンストCD.不透明度 = value;
				this.パンスト_ハイライト1CD.不透明度 = value;
				this.パンスト_ハイライト2CD.不透明度 = value;
				this.ソックス_ソックスCD.不透明度 = value;
				this.ソックス_ハイライト1CD.不透明度 = value;
				this.ソックス_ハイライト2CD.不透明度 = value;
				this.ブ\u30FCツ_タン_タンCD.不透明度 = value;
				this.ブ\u30FCツ_タン_縁_縁1CD.不透明度 = value;
				this.ブ\u30FCツ_タン_縁_縁2CD.不透明度 = value;
				this.ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCD.不透明度 = value;
				this.ブ\u30FCツ_ブ\u30FCツ_皺_皺1CD.不透明度 = value;
				this.ブ\u30FCツ_ブ\u30FCツ_皺_皺2CD.不透明度 = value;
				this.ブ\u30FCツ_ブ\u30FCツ_縁_縁1CD.不透明度 = value;
				this.ブ\u30FCツ_ブ\u30FCツ_縁_縁2CD.不透明度 = value;
				this.ブ\u30FCツ_ブ\u30FCツ_縁_縁3CD.不透明度 = value;
				this.ブ\u30FCツ_ブ\u30FCツ_縁_縁4CD.不透明度 = value;
				this.ブ\u30FCツ_柄CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐1_紐下_紐CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐1_紐上_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐1_紐上_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐1_紐上_紐CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐2_紐下_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐2_紐下_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐2_紐下_紐CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐2_紐上_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐2_紐上_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐2_紐上_紐CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐3_紐下_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐3_紐下_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐3_紐下_紐CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐3_紐上_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐3_紐上_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐3_紐上_紐CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐4_紐下_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐4_紐下_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐4_紐下_紐CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐4_紐上_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐4_紐上_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐4_紐上_紐CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐5_紐下_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐5_紐下_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐5_紐下_紐CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐5_紐上_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐5_紐上_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐5_紐上_紐CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐6_紐下_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐6_紐下_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐6_紐下_紐CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐6_紐上_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐6_紐上_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐6_紐上_紐CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐7_紐下_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐7_紐下_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐7_紐下_紐CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐7_紐上_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐7_紐上_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐7_紐上_紐CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐8_紐下_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐8_紐下_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐8_紐下_紐CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐8_紐上_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐8_紐上_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐8_紐上_紐CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐9_紐下_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐9_紐下_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐9_紐下_紐CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐9_紐上_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐9_紐上_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐9_紐上_紐CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐10_紐下_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐10_紐下_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐10_紐下_紐CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐10_紐上_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐10_紐上_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐10_紐上_紐CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐11_紐下_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐11_紐下_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐11_紐下_紐CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐11_紐上_金具上_金具CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐11_紐上_金具上_穴CD.不透明度 = value;
				this.ブ\u30FCツ_紐_紐11_紐上_紐CD.不透明度 = value;
				this.ブ\u30FCツ_紐_結び_紐左_紐3CD.不透明度 = value;
				this.ブ\u30FCツ_紐_結び_紐左_紐2CD.不透明度 = value;
				this.ブ\u30FCツ_紐_結び_紐左_紐1CD.不透明度 = value;
				this.ブ\u30FCツ_紐_結び_紐右_紐3CD.不透明度 = value;
				this.ブ\u30FCツ_紐_結び_紐右_紐2CD.不透明度 = value;
				this.ブ\u30FCツ_紐_結び_紐右_紐1CD.不透明度 = value;
				this.ブ\u30FCツ_紐_結び_結び目CD.不透明度 = value;
				this.ア\u30FCマ_ベ\u30FCスCD.不透明度 = value;
				this.ア\u30FCマ_脛当_脛当1CD.不透明度 = value;
				this.ア\u30FCマ_脛当_脛当2CD.不透明度 = value;
				this.ア\u30FCマ_膝当CD.不透明度 = value;
				this.ア\u30FCマ_穴_穴1CD.不透明度 = value;
				this.ア\u30FCマ_穴_穴2CD.不透明度 = value;
				this.ア\u30FCマ_穴_穴3CD.不透明度 = value;
				this.ア\u30FCマ_穴_穴4CD.不透明度 = value;
				this.脚輪上_革CD.不透明度 = value;
				this.脚輪上_金具1CD.不透明度 = value;
				this.脚輪上_金具2CD.不透明度 = value;
				this.脚輪上_金具3CD.不透明度 = value;
				this.脚輪上_金具左CD.不透明度 = value;
				this.脚輪上_金具右CD.不透明度 = value;
				this.脚輪下_革CD.不透明度 = value;
				this.脚輪下_金具1CD.不透明度 = value;
				this.脚輪下_金具2CD.不透明度 = value;
				this.脚輪下_金具3CD.不透明度 = value;
				this.脚輪下_金具左CD.不透明度 = value;
				this.脚輪下_金具右CD.不透明度 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			if (this.本体.IndexY == 0)
			{
				Are.Draw(this.X0Y0_脚);
				Are.Draw(this.X0Y0_筋);
				Are.Draw(this.X0Y0_獣性_獣毛1);
				Are.Draw(this.X0Y0_獣性_獣毛2);
				Are.Draw(this.X0Y0_獣性_獣毛3);
				Are.Draw(this.X0Y0_獣性_獣毛4);
				Are.Draw(this.X0Y0_獣性_獣毛5);
				Are.Draw(this.X0Y0_竜性_鱗_鱗1);
				Are.Draw(this.X0Y0_竜性_鱗_鱗2);
				Are.Draw(this.X0Y0_竜性_鱗_鱗3);
				Are.Draw(this.X0Y0_竜性_鱗_鱗4);
				Are.Draw(this.X0Y0_竜性_鱗_鱗5);
				Are.Draw(this.X0Y0_竜性_鱗_鱗6);
				Are.Draw(this.X0Y0_竜性_鱗_鱗7);
				Are.Draw(this.X0Y0_淫タトゥ_足首_タトゥ);
				Are.Draw(this.X0Y0_淫タトゥ_足首_ハ\u30FCト1_タトゥ左);
				Are.Draw(this.X0Y0_淫タトゥ_足首_ハ\u30FCト1_タトゥ右);
				Are.Draw(this.X0Y0_淫タトゥ_足首_ハ\u30FCト3_タトゥ左);
				Are.Draw(this.X0Y0_淫タトゥ_足首_ハ\u30FCト3_タトゥ右);
				Are.Draw(this.X0Y0_淫タトゥ_足首_ハ\u30FCト2_タトゥ左);
				Are.Draw(this.X0Y0_淫タトゥ_足首_ハ\u30FCト2_タトゥ右);
				Are.Draw(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左);
				Are.Draw(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右);
				Are.Draw(this.X0Y0_淫タトゥ_タトゥ左);
				Are.Draw(this.X0Y0_淫タトゥ_タトゥ右);
				Are.Draw(this.X0Y0_悪タトゥ_文字1_文字a_枠);
				Are.Draw(this.X0Y0_悪タトゥ_文字1_文字a_文字タトゥ1);
				Are.Draw(this.X0Y0_悪タトゥ_文字1_文字a_文字タトゥ2);
				Are.Draw(this.X0Y0_悪タトゥ_文字1_文字b_枠);
				Are.Draw(this.X0Y0_悪タトゥ_文字1_文字b_文字タトゥ1);
				Are.Draw(this.X0Y0_悪タトゥ_文字1_文字b_文字タトゥ2);
				Are.Draw(this.X0Y0_悪タトゥ_文字1_文字c_枠);
				Are.Draw(this.X0Y0_悪タトゥ_文字1_文字c_文字タトゥ1);
				Are.Draw(this.X0Y0_悪タトゥ_文字1_文字c_文字タトゥ2);
				Are.Draw(this.X0Y0_悪タトゥ_文字1_文字d_枠);
				Are.Draw(this.X0Y0_悪タトゥ_文字1_文字d_文字タトゥ1);
				Are.Draw(this.X0Y0_悪タトゥ_文字1_文字d_文字タトゥ2);
				Are.Draw(this.X0Y0_悪タトゥ_文字1_文字e_枠);
				Are.Draw(this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ1);
				Are.Draw(this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ2);
				Are.Draw(this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ3);
				Are.Draw(this.X0Y0_悪タトゥ_文字2_文字a_枠);
				Are.Draw(this.X0Y0_悪タトゥ_文字2_文字a_文字タトゥ1);
				Are.Draw(this.X0Y0_悪タトゥ_文字2_文字a_文字タトゥ2);
				Are.Draw(this.X0Y0_悪タトゥ_文字2_文字b_枠);
				Are.Draw(this.X0Y0_悪タトゥ_文字2_文字b_文字タトゥ1);
				Are.Draw(this.X0Y0_悪タトゥ_文字2_文字b_文字タトゥ2);
				Are.Draw(this.X0Y0_悪タトゥ_文字2_文字c_枠);
				Are.Draw(this.X0Y0_悪タトゥ_文字2_文字c_文字タトゥ1);
				Are.Draw(this.X0Y0_悪タトゥ_文字2_文字c_文字タトゥ2);
				Are.Draw(this.X0Y0_悪タトゥ_文字2_文字d_枠);
				Are.Draw(this.X0Y0_悪タトゥ_文字2_文字d_文字タトゥ1);
				Are.Draw(this.X0Y0_悪タトゥ_文字2_文字d_文字タトゥ2);
				Are.Draw(this.X0Y0_悪タトゥ_文字2_文字e_枠);
				Are.Draw(this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ1);
				Are.Draw(this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ2);
				Are.Draw(this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ3);
				Are.Draw(this.X0Y0_悪タトゥ_タトゥ1);
				Are.Draw(this.X0Y0_悪タトゥ_タトゥ2);
				Are.Draw(this.X0Y0_悪タトゥ_逆十字_逆十字1);
				Are.Draw(this.X0Y0_悪タトゥ_逆十字_逆十字2);
				Are.Draw(this.X0Y0_悪タトゥ_タトゥ左);
				Are.Draw(this.X0Y0_悪タトゥ_タトゥ右);
				Are.Draw(this.X0Y0_虫性_棘_棘1);
				Are.Draw(this.X0Y0_虫性_棘_棘2);
				Are.Draw(this.X0Y0_虫性_棘_棘3);
				Are.Draw(this.X0Y0_虫性_膝);
				Are.Draw(this.X0Y0_虫性_線);
				Are.Draw(this.X0Y0_竜性_棘_棘1);
				Are.Draw(this.X0Y0_紋柄_紋1);
				Are.Draw(this.X0Y0_紋柄_紋2);
				Are.Draw(this.X0Y0_紋柄_紋3);
				Are.Draw(this.X0Y0_紋柄_紋4);
				Are.Draw(this.X0Y0_竜性_棘_棘2);
				Are.Draw(this.X0Y0_竜性_棘_棘3);
				Are.Draw(this.X0Y0_竜性_棘_棘4);
				Are.Draw(this.X0Y0_竜性_棘_棘5);
				Are.Draw(this.X0Y0_竜性_棘_棘6);
				Are.Draw(this.X0Y0_傷X1);
				Are.Draw(this.X0Y0_傷X2);
				Are.Draw(this.X0Y0_傷I1);
				Are.Draw(this.X0Y0_傷I2);
				Are.Draw(this.X0Y0_傷I3);
				Are.Draw(this.X0Y0_傷I4);
				Are.Draw(this.X0Y0_傷I5);
				this.キスマ\u30FCク.Draw(Are);
				this.鞭痕.Draw(Are);
				Are.Draw(this.X0Y0_ハイライト1);
				Are.Draw(this.X0Y0_ハイライト2);
				Are.Draw(this.X0Y0_パンスト_パンスト);
				Are.Draw(this.X0Y0_パンスト_ハイライト1);
				Are.Draw(this.X0Y0_パンスト_ハイライト2);
				Are.Draw(this.X0Y0_ソックス_ソックス);
				Are.Draw(this.X0Y0_ソックス_ハイライト1);
				Are.Draw(this.X0Y0_ソックス_ハイライト2);
				return;
			}
			Are.Draw(this.X0Y1_脚);
			Are.Draw(this.X0Y1_筋);
			Are.Draw(this.X0Y1_獣性_獣毛1);
			Are.Draw(this.X0Y1_獣性_獣毛2);
			Are.Draw(this.X0Y1_獣性_獣毛3);
			Are.Draw(this.X0Y1_獣性_獣毛4);
			Are.Draw(this.X0Y1_獣性_獣毛5);
			Are.Draw(this.X0Y1_竜性_鱗_鱗1);
			Are.Draw(this.X0Y1_竜性_鱗_鱗2);
			Are.Draw(this.X0Y1_竜性_鱗_鱗3);
			Are.Draw(this.X0Y1_竜性_鱗_鱗4);
			Are.Draw(this.X0Y1_竜性_鱗_鱗5);
			Are.Draw(this.X0Y1_竜性_鱗_鱗6);
			Are.Draw(this.X0Y1_竜性_鱗_鱗7);
			Are.Draw(this.X0Y1_淫タトゥ_足首_タトゥ);
			Are.Draw(this.X0Y1_淫タトゥ_足首_ハ\u30FCト1_タトゥ左);
			Are.Draw(this.X0Y1_淫タトゥ_足首_ハ\u30FCト1_タトゥ右);
			Are.Draw(this.X0Y1_淫タトゥ_足首_ハ\u30FCト3_タトゥ左);
			Are.Draw(this.X0Y1_淫タトゥ_足首_ハ\u30FCト3_タトゥ右);
			Are.Draw(this.X0Y1_淫タトゥ_足首_ハ\u30FCト2_タトゥ左);
			Are.Draw(this.X0Y1_淫タトゥ_足首_ハ\u30FCト2_タトゥ右);
			Are.Draw(this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左);
			Are.Draw(this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右);
			Are.Draw(this.X0Y1_淫タトゥ_タトゥ左);
			Are.Draw(this.X0Y1_淫タトゥ_タトゥ右);
			Are.Draw(this.X0Y1_悪タトゥ_文字1_文字a_枠);
			Are.Draw(this.X0Y1_悪タトゥ_文字1_文字a_文字タトゥ1);
			Are.Draw(this.X0Y1_悪タトゥ_文字1_文字a_文字タトゥ2);
			Are.Draw(this.X0Y1_悪タトゥ_文字1_文字b_枠);
			Are.Draw(this.X0Y1_悪タトゥ_文字1_文字b_文字タトゥ1);
			Are.Draw(this.X0Y1_悪タトゥ_文字1_文字b_文字タトゥ2);
			Are.Draw(this.X0Y1_悪タトゥ_文字1_文字c_枠);
			Are.Draw(this.X0Y1_悪タトゥ_文字1_文字c_文字タトゥ1);
			Are.Draw(this.X0Y1_悪タトゥ_文字1_文字c_文字タトゥ2);
			Are.Draw(this.X0Y1_悪タトゥ_文字1_文字d_枠);
			Are.Draw(this.X0Y1_悪タトゥ_文字1_文字d_文字タトゥ1);
			Are.Draw(this.X0Y1_悪タトゥ_文字1_文字d_文字タトゥ2);
			Are.Draw(this.X0Y1_悪タトゥ_文字1_文字e_枠);
			Are.Draw(this.X0Y1_悪タトゥ_文字1_文字e_文字タトゥ1);
			Are.Draw(this.X0Y1_悪タトゥ_文字1_文字e_文字タトゥ2);
			Are.Draw(this.X0Y1_悪タトゥ_文字1_文字e_文字タトゥ3);
			Are.Draw(this.X0Y1_悪タトゥ_文字2_文字a_枠);
			Are.Draw(this.X0Y1_悪タトゥ_文字2_文字a_文字タトゥ1);
			Are.Draw(this.X0Y1_悪タトゥ_文字2_文字a_文字タトゥ2);
			Are.Draw(this.X0Y1_悪タトゥ_文字2_文字b_枠);
			Are.Draw(this.X0Y1_悪タトゥ_文字2_文字b_文字タトゥ1);
			Are.Draw(this.X0Y1_悪タトゥ_文字2_文字b_文字タトゥ2);
			Are.Draw(this.X0Y1_悪タトゥ_文字2_文字c_枠);
			Are.Draw(this.X0Y1_悪タトゥ_文字2_文字c_文字タトゥ1);
			Are.Draw(this.X0Y1_悪タトゥ_文字2_文字c_文字タトゥ2);
			Are.Draw(this.X0Y1_悪タトゥ_文字2_文字d_枠);
			Are.Draw(this.X0Y1_悪タトゥ_文字2_文字d_文字タトゥ1);
			Are.Draw(this.X0Y1_悪タトゥ_文字2_文字d_文字タトゥ2);
			Are.Draw(this.X0Y1_悪タトゥ_文字2_文字e_枠);
			Are.Draw(this.X0Y1_悪タトゥ_文字2_文字e_文字タトゥ1);
			Are.Draw(this.X0Y1_悪タトゥ_文字2_文字e_文字タトゥ2);
			Are.Draw(this.X0Y1_悪タトゥ_文字2_文字e_文字タトゥ3);
			Are.Draw(this.X0Y1_悪タトゥ_タトゥ1);
			Are.Draw(this.X0Y1_悪タトゥ_タトゥ2);
			Are.Draw(this.X0Y1_悪タトゥ_逆十字_逆十字1);
			Are.Draw(this.X0Y1_悪タトゥ_逆十字_逆十字2);
			Are.Draw(this.X0Y1_悪タトゥ_タトゥ左);
			Are.Draw(this.X0Y1_悪タトゥ_タトゥ右);
			Are.Draw(this.X0Y1_虫性_棘_棘1);
			Are.Draw(this.X0Y1_虫性_棘_棘2);
			Are.Draw(this.X0Y1_虫性_棘_棘3);
			Are.Draw(this.X0Y1_虫性_膝);
			Are.Draw(this.X0Y1_虫性_線);
			Are.Draw(this.X0Y1_竜性_棘_棘1);
			Are.Draw(this.X0Y1_紋柄_紋1);
			Are.Draw(this.X0Y1_紋柄_紋2);
			Are.Draw(this.X0Y1_紋柄_紋3);
			Are.Draw(this.X0Y1_紋柄_紋4);
			Are.Draw(this.X0Y1_竜性_棘_棘2);
			Are.Draw(this.X0Y1_竜性_棘_棘3);
			Are.Draw(this.X0Y1_竜性_棘_棘4);
			Are.Draw(this.X0Y1_竜性_棘_棘5);
			Are.Draw(this.X0Y1_竜性_棘_棘6);
			Are.Draw(this.X0Y1_傷X1);
			Are.Draw(this.X0Y1_傷X2);
			Are.Draw(this.X0Y1_傷I1);
			Are.Draw(this.X0Y1_傷I2);
			Are.Draw(this.X0Y1_傷I3);
			Are.Draw(this.X0Y1_傷I4);
			Are.Draw(this.X0Y1_傷I5);
			this.キスマ\u30FCク.Draw(Are);
			this.鞭痕.Draw(Are);
			Are.Draw(this.X0Y1_ハイライト1);
			Are.Draw(this.X0Y1_ハイライト2);
			Are.Draw(this.X0Y1_パンスト_パンスト);
			Are.Draw(this.X0Y1_パンスト_ハイライト1);
			Are.Draw(this.X0Y1_パンスト_ハイライト2);
			Are.Draw(this.X0Y1_ソックス_ソックス);
			Are.Draw(this.X0Y1_ソックス_ハイライト1);
			Are.Draw(this.X0Y1_ソックス_ハイライト2);
		}

		public void 外描画(Are Are)
		{
			if (this.本体.IndexY == 0)
			{
				Are.Draw(this.X0Y0_ブ\u30FCツ_タン_タン);
				Are.Draw(this.X0Y0_ブ\u30FCツ_タン_縁_縁1);
				Are.Draw(this.X0Y0_ブ\u30FCツ_タン_縁_縁2);
				Are.Draw(this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツ);
				Are.Draw(this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_皺_皺1);
				Are.Draw(this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_皺_皺2);
				Are.Draw(this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁1);
				Are.Draw(this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁2);
				Are.Draw(this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁3);
				Are.Draw(this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁4);
				Are.Draw(this.X0Y0_ブ\u30FCツ_柄);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_金具上_金具);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_金具上_穴);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_紐);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐3);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐2);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐1);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐3);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐2);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐1);
				Are.Draw(this.X0Y0_ブ\u30FCツ_紐_結び_結び目);
				Are.Draw(this.X0Y0_ア\u30FCマ_ベ\u30FCス);
				Are.Draw(this.X0Y0_ア\u30FCマ_脛当_脛当1);
				Are.Draw(this.X0Y0_ア\u30FCマ_脛当_脛当2);
				Are.Draw(this.X0Y0_ア\u30FCマ_膝当);
				Are.Draw(this.X0Y0_ア\u30FCマ_穴_穴1);
				Are.Draw(this.X0Y0_ア\u30FCマ_穴_穴2);
				Are.Draw(this.X0Y0_ア\u30FCマ_穴_穴3);
				Are.Draw(this.X0Y0_ア\u30FCマ_穴_穴4);
				Are.Draw(this.X0Y0_脚輪上_革);
				Are.Draw(this.X0Y0_脚輪上_金具1);
				Are.Draw(this.X0Y0_脚輪上_金具2);
				Are.Draw(this.X0Y0_脚輪上_金具3);
				Are.Draw(this.X0Y0_脚輪上_金具左);
				Are.Draw(this.X0Y0_脚輪上_金具右);
				this.鎖1.描画0(Are);
				Are.Draw(this.X0Y0_脚輪下_革);
				Are.Draw(this.X0Y0_脚輪下_金具1);
				Are.Draw(this.X0Y0_脚輪下_金具2);
				Are.Draw(this.X0Y0_脚輪下_金具3);
				Are.Draw(this.X0Y0_脚輪下_金具左);
				Are.Draw(this.X0Y0_脚輪下_金具右);
				this.鎖3.描画0(Are);
				return;
			}
			Are.Draw(this.X0Y1_ブ\u30FCツ_タン_タン);
			Are.Draw(this.X0Y1_ブ\u30FCツ_タン_縁_縁1);
			Are.Draw(this.X0Y1_ブ\u30FCツ_タン_縁_縁2);
			Are.Draw(this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツ);
			Are.Draw(this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_皺_皺1);
			Are.Draw(this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_皺_皺2);
			Are.Draw(this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁1);
			Are.Draw(this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁2);
			Are.Draw(this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁3);
			Are.Draw(this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁4);
			Are.Draw(this.X0Y1_ブ\u30FCツ_柄);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_金具上_金具);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_金具上_穴);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_紐);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐3);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐2);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐1);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐3);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐2);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐1);
			Are.Draw(this.X0Y1_ブ\u30FCツ_紐_結び_結び目);
			Are.Draw(this.X0Y1_ア\u30FCマ_ベ\u30FCス);
			Are.Draw(this.X0Y1_ア\u30FCマ_脛当_脛当1);
			Are.Draw(this.X0Y1_ア\u30FCマ_脛当_脛当2);
			Are.Draw(this.X0Y1_ア\u30FCマ_膝当);
			Are.Draw(this.X0Y1_ア\u30FCマ_穴_穴1);
			Are.Draw(this.X0Y1_ア\u30FCマ_穴_穴2);
			Are.Draw(this.X0Y1_ア\u30FCマ_穴_穴3);
			Are.Draw(this.X0Y1_ア\u30FCマ_穴_穴4);
			Are.Draw(this.X0Y1_脚輪上_革);
			Are.Draw(this.X0Y1_脚輪上_金具1);
			Are.Draw(this.X0Y1_脚輪上_金具2);
			Are.Draw(this.X0Y1_脚輪上_金具3);
			Are.Draw(this.X0Y1_脚輪上_金具左);
			Are.Draw(this.X0Y1_脚輪上_金具右);
			this.鎖1.描画0(Are);
			Are.Draw(this.X0Y1_脚輪下_革);
			Are.Draw(this.X0Y1_脚輪下_金具1);
			Are.Draw(this.X0Y1_脚輪下_金具2);
			Are.Draw(this.X0Y1_脚輪下_金具3);
			Are.Draw(this.X0Y1_脚輪下_金具左);
			Are.Draw(this.X0Y1_脚輪下_金具右);
			this.鎖3.描画0(Are);
		}

		public void 虫性()
		{
			this.X0Y0_脚.OP[this.右 ? 0 : 6].Outline = true;
			this.X0Y1_脚.OP[this.右 ? 0 : 6].Outline = true;
		}

		public void 開脚(腿_人 腿)
		{
			if (腿.本体.IndexY == 0 || 腿.本体.IndexY == 4)
			{
				this.本体.IndexY = 0;
				return;
			}
			if (腿.本体.IndexY == 1 || 腿.本体.IndexY == 2 || 腿.本体.IndexY == 3)
			{
				this.本体.IndexY = 1;
			}
		}

		public bool パンスト表示
		{
			get
			{
				return this.パンスト_パンスト_表示;
			}
			set
			{
				this.パンスト_パンスト_表示 = value;
				this.パンスト_ハイライト1_表示 = value;
				this.パンスト_ハイライト2_表示 = value;
			}
		}

		public bool ニ\u30FCハイ表示
		{
			get
			{
				return this.ソックス_ソックス_表示;
			}
			set
			{
				this.ソックス_ソックス_表示 = value;
				this.ソックス_ハイライト1_表示 = value;
				this.ソックス_ハイライト2_表示 = value;
			}
		}

		public bool ブ\u30FCツ表示
		{
			get
			{
				return this.ブ\u30FCツ_タン_タン_表示;
			}
			set
			{
				this.ブ\u30FCツ_タン_タン_表示 = value;
				this.ブ\u30FCツ_タン_縁_縁1_表示 = value;
				this.ブ\u30FCツ_タン_縁_縁2_表示 = value;
				this.ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツ_表示 = value;
				this.ブ\u30FCツ_ブ\u30FCツ_皺_皺1_表示 = value;
				this.ブ\u30FCツ_ブ\u30FCツ_皺_皺2_表示 = value;
				this.ブ\u30FCツ_ブ\u30FCツ_縁_縁1_表示 = value;
				this.ブ\u30FCツ_ブ\u30FCツ_縁_縁2_表示 = value;
				this.ブ\u30FCツ_ブ\u30FCツ_縁_縁3_表示 = value;
				this.ブ\u30FCツ_ブ\u30FCツ_縁_縁4_表示 = value;
				this.ブ\u30FCツ_柄_表示 = value;
				this.ブ\u30FCツ_紐_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐1_紐下_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐1_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐1_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐1_紐上_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐2_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐2_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐2_紐下_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐2_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐2_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐2_紐上_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐3_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐3_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐3_紐下_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐3_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐3_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐3_紐上_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐4_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐4_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐4_紐下_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐4_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐4_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐4_紐上_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐5_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐5_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐5_紐下_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐5_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐5_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐5_紐上_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐6_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐6_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐6_紐下_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐6_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐6_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐6_紐上_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐7_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐7_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐7_紐下_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐7_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐7_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐7_紐上_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐8_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐8_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐8_紐下_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐8_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐8_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐8_紐上_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐9_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐9_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐9_紐下_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐9_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐9_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐9_紐上_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐10_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐10_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐10_紐下_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐10_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐10_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐10_紐上_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐11_紐下_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐11_紐下_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐11_紐下_紐_表示 = value;
				this.ブ\u30FCツ_紐_紐11_紐上_金具上_金具_表示 = value;
				this.ブ\u30FCツ_紐_紐11_紐上_金具上_穴_表示 = value;
				this.ブ\u30FCツ_紐_紐11_紐上_紐_表示 = value;
				this.ブ\u30FCツ_紐_結び_紐左_紐3_表示 = value;
				this.ブ\u30FCツ_紐_結び_紐左_紐2_表示 = value;
				this.ブ\u30FCツ_紐_結び_紐左_紐1_表示 = value;
				this.ブ\u30FCツ_紐_結び_紐右_紐3_表示 = value;
				this.ブ\u30FCツ_紐_結び_紐右_紐2_表示 = value;
				this.ブ\u30FCツ_紐_結び_紐右_紐1_表示 = value;
				this.ブ\u30FCツ_紐_結び_結び目_表示 = value;
			}
		}

		public bool メイル表示
		{
			get
			{
				return this.ア\u30FCマ_ベ\u30FCス_表示;
			}
			set
			{
				this.ア\u30FCマ_ベ\u30FCス_表示 = value;
				this.ア\u30FCマ_脛当_脛当1_表示 = value;
				this.ア\u30FCマ_脛当_脛当2_表示 = value;
				this.ア\u30FCマ_膝当_表示 = value;
				this.ア\u30FCマ_穴_穴1_表示 = value;
				this.ア\u30FCマ_穴_穴2_表示 = value;
				this.ア\u30FCマ_穴_穴3_表示 = value;
				this.ア\u30FCマ_穴_穴4_表示 = value;
			}
		}

		public override bool Is布(Par p)
		{
			return p == this.X0Y0_パンスト_パンスト || p == this.X0Y0_パンスト_ハイライト1 || p == this.X0Y0_パンスト_ハイライト2 || p == this.X0Y0_ソックス_ソックス || p == this.X0Y0_ソックス_ハイライト1 || p == this.X0Y0_ソックス_ハイライト2 || p == this.X0Y1_パンスト_パンスト || p == this.X0Y1_パンスト_ハイライト1 || p == this.X0Y1_パンスト_ハイライト2 || p == this.X0Y1_ソックス_ソックス || p == this.X0Y1_ソックス_ハイライト1 || p == this.X0Y1_ソックス_ハイライト2;
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_ブ\u30FCツ_タン_タン || p == this.X0Y0_ブ\u30FCツ_タン_縁_縁1 || p == this.X0Y0_ブ\u30FCツ_タン_縁_縁2 || p == this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツ || p == this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_皺_皺1 || p == this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_皺_皺2 || p == this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁1 || p == this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁2 || p == this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁3 || p == this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁4 || p == this.X0Y0_ブ\u30FCツ_柄 || p == this.X0Y0_ブ\u30FCツ_紐_紐 || p == this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_金具上_金具 || p == this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_金具上_穴 || p == this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_紐 || p == this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_金具上_金具 || p == this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_金具上_穴 || p == this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_紐 || p == this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_金具上_金具 || p == this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_金具上_穴 || p == this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_紐 || p == this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_金具上_金具 || p == this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_金具上_穴 || p == this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_紐 || p == this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_金具上_金具 || p == this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_金具上_穴 || p == this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_紐 || p == this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_金具上_金具 || p == this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_金具上_穴 || p == this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_紐 || p == this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_金具上_金具 || p == this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_金具上_穴 || p == this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_紐 || p == this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_金具上_金具 || p == this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_金具上_穴 || p == this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_紐 || p == this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_金具上_金具 || p == this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_金具上_穴 || p == this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_紐 || p == this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_金具上_金具 || p == this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_金具上_穴 || p == this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_紐 || p == this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_金具上_金具 || p == this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_金具上_穴 || p == this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_紐 || p == this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_金具上_金具 || p == this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_金具上_穴 || p == this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_紐 || p == this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_金具上_金具 || p == this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_金具上_穴 || p == this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_紐 || p == this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_金具上_金具 || p == this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_金具上_穴 || p == this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_紐 || p == this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_金具上_金具 || p == this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_金具上_穴 || p == this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_紐 || p == this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_金具上_金具 || p == this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_金具上_穴 || p == this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_紐 || p == this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_金具上_金具 || p == this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_金具上_穴 || p == this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_紐 || p == this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_金具上_金具 || p == this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_金具上_穴 || p == this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_紐 || p == this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_金具上_金具 || p == this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_金具上_穴 || p == this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_紐 || p == this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_金具上_金具 || p == this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_金具上_穴 || p == this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_紐 || p == this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_金具上_金具 || p == this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_金具上_穴 || p == this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_紐 || p == this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_金具上_金具 || p == this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_金具上_穴 || p == this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_紐 || p == this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐3 || p == this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐2 || p == this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐1 || p == this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐3 || p == this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐2 || p == this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐1 || p == this.X0Y0_ブ\u30FCツ_紐_結び_結び目 || p == this.X0Y0_脚輪上_革 || p == this.X0Y0_脚輪上_金具1 || p == this.X0Y0_脚輪上_金具2 || p == this.X0Y0_脚輪上_金具3 || p == this.X0Y0_脚輪上_金具左 || p == this.X0Y0_脚輪上_金具右 || p == this.X0Y0_脚輪下_革 || p == this.X0Y0_脚輪下_金具1 || p == this.X0Y0_脚輪下_金具2 || p == this.X0Y0_脚輪下_金具3 || p == this.X0Y0_脚輪下_金具左 || p == this.X0Y0_脚輪下_金具右 || p == this.X0Y1_ブ\u30FCツ_タン_タン || p == this.X0Y1_ブ\u30FCツ_タン_縁_縁1 || p == this.X0Y1_ブ\u30FCツ_タン_縁_縁2 || p == this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツ || p == this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_皺_皺1 || p == this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_皺_皺2 || p == this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁1 || p == this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁2 || p == this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁3 || p == this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁4 || p == this.X0Y1_ブ\u30FCツ_柄 || p == this.X0Y1_ブ\u30FCツ_紐_紐 || p == this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_金具上_金具 || p == this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_金具上_穴 || p == this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_紐 || p == this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_金具上_金具 || p == this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_金具上_穴 || p == this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_紐 || p == this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_金具上_金具 || p == this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_金具上_穴 || p == this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_紐 || p == this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_金具上_金具 || p == this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_金具上_穴 || p == this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_紐 || p == this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_金具上_金具 || p == this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_金具上_穴 || p == this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_紐 || p == this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_金具上_金具 || p == this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_金具上_穴 || p == this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_紐 || p == this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_金具上_金具 || p == this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_金具上_穴 || p == this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_紐 || p == this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_金具上_金具 || p == this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_金具上_穴 || p == this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_紐 || p == this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_金具上_金具 || p == this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_金具上_穴 || p == this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_紐 || p == this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_金具上_金具 || p == this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_金具上_穴 || p == this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_紐 || p == this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_金具上_金具 || p == this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_金具上_穴 || p == this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_紐 || p == this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_金具上_金具 || p == this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_金具上_穴 || p == this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_紐 || p == this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_金具上_金具 || p == this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_金具上_穴 || p == this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_紐 || p == this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_金具上_金具 || p == this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_金具上_穴 || p == this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_紐 || p == this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_金具上_金具 || p == this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_金具上_穴 || p == this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_紐 || p == this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_金具上_金具 || p == this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_金具上_穴 || p == this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_紐 || p == this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_金具上_金具 || p == this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_金具上_穴 || p == this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_紐 || p == this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_金具上_金具 || p == this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_金具上_穴 || p == this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_紐 || p == this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_金具上_金具 || p == this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_金具上_穴 || p == this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_紐 || p == this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_金具上_金具 || p == this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_金具上_穴 || p == this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_紐 || p == this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_金具上_金具 || p == this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_金具上_穴 || p == this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_紐 || p == this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_金具上_金具 || p == this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_金具上_穴 || p == this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_紐 || p == this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐3 || p == this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐2 || p == this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐1 || p == this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐3 || p == this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐2 || p == this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐1 || p == this.X0Y1_ブ\u30FCツ_紐_結び_結び目 || p == this.X0Y1_脚輪上_革 || p == this.X0Y1_脚輪上_金具1 || p == this.X0Y1_脚輪上_金具2 || p == this.X0Y1_脚輪上_金具3 || p == this.X0Y1_脚輪上_金具左 || p == this.X0Y1_脚輪上_金具右 || p == this.X0Y1_脚輪下_革 || p == this.X0Y1_脚輪下_金具1 || p == this.X0Y1_脚輪下_金具2 || p == this.X0Y1_脚輪下_金具3 || p == this.X0Y1_脚輪下_金具左 || p == this.X0Y1_脚輪下_金具右;
		}

		public override bool Is鉄(Par p)
		{
			return p == this.X0Y0_ア\u30FCマ_ベ\u30FCス || p == this.X0Y0_ア\u30FCマ_脛当_脛当1 || p == this.X0Y0_ア\u30FCマ_脛当_脛当2 || p == this.X0Y0_ア\u30FCマ_膝当 || p == this.X0Y0_ア\u30FCマ_穴_穴1 || p == this.X0Y0_ア\u30FCマ_穴_穴2 || p == this.X0Y0_ア\u30FCマ_穴_穴3 || p == this.X0Y0_ア\u30FCマ_穴_穴4 || p == this.X0Y1_ア\u30FCマ_ベ\u30FCス || p == this.X0Y1_ア\u30FCマ_脛当_脛当1 || p == this.X0Y1_ア\u30FCマ_脛当_脛当2 || p == this.X0Y1_ア\u30FCマ_膝当 || p == this.X0Y1_ア\u30FCマ_穴_穴1 || p == this.X0Y1_ア\u30FCマ_穴_穴2 || p == this.X0Y1_ア\u30FCマ_穴_穴3 || p == this.X0Y1_ア\u30FCマ_穴_穴4;
		}

		public JointS 足_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_脚, 0);
			}
		}

		public JointS 脚輪下_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_脚, 2);
			}
		}

		public JointS 脚輪上_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_脚, 3);
			}
		}

		public JointS 鎖1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_脚輪上_金具左, 0);
			}
		}

		public JointS 鎖2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_脚輪上_金具右, 0);
			}
		}

		public JointS 鎖3_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_脚輪下_金具左, 0);
			}
		}

		public JointS 鎖4_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_脚輪下_金具右, 0);
			}
		}

		public override void 色更新()
		{
			if (this.本体.IndexY == 0)
			{
				this.X0Y0_脚CP.Update();
				this.X0Y0_筋CP.Update();
				this.X0Y0_淫タトゥ_足首_タトゥCP.Update();
				this.X0Y0_淫タトゥ_足首_ハ\u30FCト1_タトゥ左CP.Update();
				this.X0Y0_淫タトゥ_足首_ハ\u30FCト1_タトゥ右CP.Update();
				this.X0Y0_淫タトゥ_足首_ハ\u30FCト3_タトゥ左CP.Update();
				this.X0Y0_淫タトゥ_足首_ハ\u30FCト3_タトゥ右CP.Update();
				this.X0Y0_淫タトゥ_足首_ハ\u30FCト2_タトゥ左CP.Update();
				this.X0Y0_淫タトゥ_足首_ハ\u30FCト2_タトゥ右CP.Update();
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左CP.Update();
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右CP.Update();
				this.X0Y0_淫タトゥ_タトゥ左CP.Update();
				this.X0Y0_淫タトゥ_タトゥ右CP.Update();
				this.X0Y0_悪タトゥ_文字1_文字a_枠CP.Update();
				this.X0Y0_悪タトゥ_文字1_文字a_文字タトゥ1CP.Update();
				this.X0Y0_悪タトゥ_文字1_文字a_文字タトゥ2CP.Update();
				this.X0Y0_悪タトゥ_文字1_文字b_枠CP.Update();
				this.X0Y0_悪タトゥ_文字1_文字b_文字タトゥ1CP.Update();
				this.X0Y0_悪タトゥ_文字1_文字b_文字タトゥ2CP.Update();
				this.X0Y0_悪タトゥ_文字1_文字c_枠CP.Update();
				this.X0Y0_悪タトゥ_文字1_文字c_文字タトゥ1CP.Update();
				this.X0Y0_悪タトゥ_文字1_文字c_文字タトゥ2CP.Update();
				this.X0Y0_悪タトゥ_文字1_文字d_枠CP.Update();
				this.X0Y0_悪タトゥ_文字1_文字d_文字タトゥ1CP.Update();
				this.X0Y0_悪タトゥ_文字1_文字d_文字タトゥ2CP.Update();
				this.X0Y0_悪タトゥ_文字1_文字e_枠CP.Update();
				this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ1CP.Update();
				this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ2CP.Update();
				this.X0Y0_悪タトゥ_文字1_文字e_文字タトゥ3CP.Update();
				this.X0Y0_悪タトゥ_文字2_文字a_枠CP.Update();
				this.X0Y0_悪タトゥ_文字2_文字a_文字タトゥ1CP.Update();
				this.X0Y0_悪タトゥ_文字2_文字a_文字タトゥ2CP.Update();
				this.X0Y0_悪タトゥ_文字2_文字b_枠CP.Update();
				this.X0Y0_悪タトゥ_文字2_文字b_文字タトゥ1CP.Update();
				this.X0Y0_悪タトゥ_文字2_文字b_文字タトゥ2CP.Update();
				this.X0Y0_悪タトゥ_文字2_文字c_枠CP.Update();
				this.X0Y0_悪タトゥ_文字2_文字c_文字タトゥ1CP.Update();
				this.X0Y0_悪タトゥ_文字2_文字c_文字タトゥ2CP.Update();
				this.X0Y0_悪タトゥ_文字2_文字d_枠CP.Update();
				this.X0Y0_悪タトゥ_文字2_文字d_文字タトゥ1CP.Update();
				this.X0Y0_悪タトゥ_文字2_文字d_文字タトゥ2CP.Update();
				this.X0Y0_悪タトゥ_文字2_文字e_枠CP.Update();
				this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ1CP.Update();
				this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ2CP.Update();
				this.X0Y0_悪タトゥ_文字2_文字e_文字タトゥ3CP.Update();
				this.X0Y0_悪タトゥ_タトゥ1CP.Update();
				this.X0Y0_悪タトゥ_タトゥ2CP.Update();
				this.X0Y0_悪タトゥ_逆十字_逆十字1CP.Update();
				this.X0Y0_悪タトゥ_逆十字_逆十字2CP.Update();
				this.X0Y0_悪タトゥ_タトゥ左CP.Update();
				this.X0Y0_悪タトゥ_タトゥ右CP.Update();
				this.X0Y0_紋柄_紋1CP.Update();
				this.X0Y0_紋柄_紋2CP.Update();
				this.X0Y0_紋柄_紋3CP.Update();
				this.X0Y0_紋柄_紋4CP.Update();
				this.X0Y0_獣性_獣毛1CP.Update();
				this.X0Y0_獣性_獣毛2CP.Update();
				this.X0Y0_獣性_獣毛3CP.Update();
				this.X0Y0_獣性_獣毛4CP.Update();
				this.X0Y0_獣性_獣毛5CP.Update();
				this.X0Y0_竜性_鱗_鱗1CP.Update();
				this.X0Y0_竜性_鱗_鱗2CP.Update();
				this.X0Y0_竜性_鱗_鱗3CP.Update();
				this.X0Y0_竜性_鱗_鱗4CP.Update();
				this.X0Y0_竜性_鱗_鱗5CP.Update();
				this.X0Y0_竜性_鱗_鱗6CP.Update();
				this.X0Y0_竜性_鱗_鱗7CP.Update();
				this.X0Y0_竜性_棘_棘1CP.Update();
				this.X0Y0_竜性_棘_棘2CP.Update();
				this.X0Y0_竜性_棘_棘3CP.Update();
				this.X0Y0_竜性_棘_棘4CP.Update();
				this.X0Y0_竜性_棘_棘5CP.Update();
				this.X0Y0_竜性_棘_棘6CP.Update();
				this.X0Y0_虫性_棘_棘1CP.Update();
				this.X0Y0_虫性_棘_棘2CP.Update();
				this.X0Y0_虫性_棘_棘3CP.Update();
				this.X0Y0_虫性_膝CP.Update();
				this.X0Y0_虫性_線CP.Update();
				this.X0Y0_傷X1CP.Update();
				this.X0Y0_傷X2CP.Update();
				this.X0Y0_傷I1CP.Update();
				this.X0Y0_傷I2CP.Update();
				this.X0Y0_傷I3CP.Update();
				this.X0Y0_傷I4CP.Update();
				this.X0Y0_傷I5CP.Update();
				this.X0Y0_ハイライト1CP.Update();
				this.X0Y0_ハイライト2CP.Update();
				this.X0Y0_パンスト_パンストCP.Update();
				this.X0Y0_パンスト_ハイライト1CP.Update();
				this.X0Y0_パンスト_ハイライト2CP.Update();
				this.X0Y0_ソックス_ソックスCP.Update();
				this.X0Y0_ソックス_ハイライト1CP.Update();
				this.X0Y0_ソックス_ハイライト2CP.Update();
				this.X0Y0_ブ\u30FCツ_タン_タンCP.Update();
				this.X0Y0_ブ\u30FCツ_タン_縁_縁1CP.Update();
				this.X0Y0_ブ\u30FCツ_タン_縁_縁2CP.Update();
				this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCP.Update();
				this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_皺_皺1CP.Update();
				this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_皺_皺2CP.Update();
				this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁1CP.Update();
				this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁2CP.Update();
				this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁3CP.Update();
				this.X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁4CP.Update();
				this.X0Y0_ブ\u30FCツ_柄CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐1_紐下_紐CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐1_紐上_紐CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐2_紐下_紐CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐2_紐上_紐CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐3_紐下_紐CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐3_紐上_紐CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐4_紐下_紐CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐4_紐上_紐CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐5_紐下_紐CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐5_紐上_紐CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐6_紐下_紐CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐6_紐上_紐CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐7_紐下_紐CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐7_紐上_紐CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐8_紐下_紐CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐8_紐上_紐CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐9_紐下_紐CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐9_紐上_紐CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐10_紐下_紐CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐10_紐上_紐CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐11_紐下_紐CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_金具上_金具CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_金具上_穴CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_紐11_紐上_紐CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐3CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐2CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_結び_紐左_紐1CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐3CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐2CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_結び_紐右_紐1CP.Update();
				this.X0Y0_ブ\u30FCツ_紐_結び_結び目CP.Update();
				this.X0Y0_ア\u30FCマ_ベ\u30FCスCP.Update();
				this.X0Y0_ア\u30FCマ_脛当_脛当1CP.Update();
				this.X0Y0_ア\u30FCマ_脛当_脛当2CP.Update();
				this.X0Y0_ア\u30FCマ_膝当CP.Update();
				this.X0Y0_ア\u30FCマ_穴_穴1CP.Update();
				this.X0Y0_ア\u30FCマ_穴_穴2CP.Update();
				this.X0Y0_ア\u30FCマ_穴_穴3CP.Update();
				this.X0Y0_ア\u30FCマ_穴_穴4CP.Update();
				this.X0Y0_脚輪上_革CP.Update();
				this.X0Y0_脚輪上_金具1CP.Update();
				this.X0Y0_脚輪上_金具2CP.Update();
				this.X0Y0_脚輪上_金具3CP.Update();
				this.X0Y0_脚輪上_金具左CP.Update();
				this.X0Y0_脚輪上_金具右CP.Update();
				this.X0Y0_脚輪下_革CP.Update();
				this.X0Y0_脚輪下_金具1CP.Update();
				this.X0Y0_脚輪下_金具2CP.Update();
				this.X0Y0_脚輪下_金具3CP.Update();
				this.X0Y0_脚輪下_金具左CP.Update();
				this.X0Y0_脚輪下_金具右CP.Update();
			}
			else
			{
				this.X0Y1_脚CP.Update();
				this.X0Y1_筋CP.Update();
				this.X0Y1_淫タトゥ_足首_タトゥCP.Update();
				this.X0Y1_淫タトゥ_足首_ハ\u30FCト1_タトゥ左CP.Update();
				this.X0Y1_淫タトゥ_足首_ハ\u30FCト1_タトゥ右CP.Update();
				this.X0Y1_淫タトゥ_足首_ハ\u30FCト3_タトゥ左CP.Update();
				this.X0Y1_淫タトゥ_足首_ハ\u30FCト3_タトゥ右CP.Update();
				this.X0Y1_淫タトゥ_足首_ハ\u30FCト2_タトゥ左CP.Update();
				this.X0Y1_淫タトゥ_足首_ハ\u30FCト2_タトゥ右CP.Update();
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左CP.Update();
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右CP.Update();
				this.X0Y1_淫タトゥ_タトゥ左CP.Update();
				this.X0Y1_淫タトゥ_タトゥ右CP.Update();
				this.X0Y1_悪タトゥ_文字1_文字a_枠CP.Update();
				this.X0Y1_悪タトゥ_文字1_文字a_文字タトゥ1CP.Update();
				this.X0Y1_悪タトゥ_文字1_文字a_文字タトゥ2CP.Update();
				this.X0Y1_悪タトゥ_文字1_文字b_枠CP.Update();
				this.X0Y1_悪タトゥ_文字1_文字b_文字タトゥ1CP.Update();
				this.X0Y1_悪タトゥ_文字1_文字b_文字タトゥ2CP.Update();
				this.X0Y1_悪タトゥ_文字1_文字c_枠CP.Update();
				this.X0Y1_悪タトゥ_文字1_文字c_文字タトゥ1CP.Update();
				this.X0Y1_悪タトゥ_文字1_文字c_文字タトゥ2CP.Update();
				this.X0Y1_悪タトゥ_文字1_文字d_枠CP.Update();
				this.X0Y1_悪タトゥ_文字1_文字d_文字タトゥ1CP.Update();
				this.X0Y1_悪タトゥ_文字1_文字d_文字タトゥ2CP.Update();
				this.X0Y1_悪タトゥ_文字1_文字e_枠CP.Update();
				this.X0Y1_悪タトゥ_文字1_文字e_文字タトゥ1CP.Update();
				this.X0Y1_悪タトゥ_文字1_文字e_文字タトゥ2CP.Update();
				this.X0Y1_悪タトゥ_文字1_文字e_文字タトゥ3CP.Update();
				this.X0Y1_悪タトゥ_文字2_文字a_枠CP.Update();
				this.X0Y1_悪タトゥ_文字2_文字a_文字タトゥ1CP.Update();
				this.X0Y1_悪タトゥ_文字2_文字a_文字タトゥ2CP.Update();
				this.X0Y1_悪タトゥ_文字2_文字b_枠CP.Update();
				this.X0Y1_悪タトゥ_文字2_文字b_文字タトゥ1CP.Update();
				this.X0Y1_悪タトゥ_文字2_文字b_文字タトゥ2CP.Update();
				this.X0Y1_悪タトゥ_文字2_文字c_枠CP.Update();
				this.X0Y1_悪タトゥ_文字2_文字c_文字タトゥ1CP.Update();
				this.X0Y1_悪タトゥ_文字2_文字c_文字タトゥ2CP.Update();
				this.X0Y1_悪タトゥ_文字2_文字d_枠CP.Update();
				this.X0Y1_悪タトゥ_文字2_文字d_文字タトゥ1CP.Update();
				this.X0Y1_悪タトゥ_文字2_文字d_文字タトゥ2CP.Update();
				this.X0Y1_悪タトゥ_文字2_文字e_枠CP.Update();
				this.X0Y1_悪タトゥ_文字2_文字e_文字タトゥ1CP.Update();
				this.X0Y1_悪タトゥ_文字2_文字e_文字タトゥ2CP.Update();
				this.X0Y1_悪タトゥ_文字2_文字e_文字タトゥ3CP.Update();
				this.X0Y1_悪タトゥ_タトゥ1CP.Update();
				this.X0Y1_悪タトゥ_タトゥ2CP.Update();
				this.X0Y1_悪タトゥ_逆十字_逆十字1CP.Update();
				this.X0Y1_悪タトゥ_逆十字_逆十字2CP.Update();
				this.X0Y1_悪タトゥ_タトゥ左CP.Update();
				this.X0Y1_悪タトゥ_タトゥ右CP.Update();
				this.X0Y1_紋柄_紋1CP.Update();
				this.X0Y1_紋柄_紋2CP.Update();
				this.X0Y1_紋柄_紋3CP.Update();
				this.X0Y1_紋柄_紋4CP.Update();
				this.X0Y1_獣性_獣毛1CP.Update();
				this.X0Y1_獣性_獣毛2CP.Update();
				this.X0Y1_獣性_獣毛3CP.Update();
				this.X0Y1_獣性_獣毛4CP.Update();
				this.X0Y1_獣性_獣毛5CP.Update();
				this.X0Y1_竜性_鱗_鱗1CP.Update();
				this.X0Y1_竜性_鱗_鱗2CP.Update();
				this.X0Y1_竜性_鱗_鱗3CP.Update();
				this.X0Y1_竜性_鱗_鱗4CP.Update();
				this.X0Y1_竜性_鱗_鱗5CP.Update();
				this.X0Y1_竜性_鱗_鱗6CP.Update();
				this.X0Y1_竜性_鱗_鱗7CP.Update();
				this.X0Y1_竜性_棘_棘1CP.Update();
				this.X0Y1_竜性_棘_棘2CP.Update();
				this.X0Y1_竜性_棘_棘3CP.Update();
				this.X0Y1_竜性_棘_棘4CP.Update();
				this.X0Y1_竜性_棘_棘5CP.Update();
				this.X0Y1_竜性_棘_棘6CP.Update();
				this.X0Y1_虫性_棘_棘1CP.Update();
				this.X0Y1_虫性_棘_棘2CP.Update();
				this.X0Y1_虫性_棘_棘3CP.Update();
				this.X0Y1_虫性_膝CP.Update();
				this.X0Y1_虫性_線CP.Update();
				this.X0Y1_傷X1CP.Update();
				this.X0Y1_傷X2CP.Update();
				this.X0Y1_傷I1CP.Update();
				this.X0Y1_傷I2CP.Update();
				this.X0Y1_傷I3CP.Update();
				this.X0Y1_傷I4CP.Update();
				this.X0Y1_傷I5CP.Update();
				this.X0Y1_ハイライト1CP.Update();
				this.X0Y1_ハイライト2CP.Update();
				this.X0Y1_パンスト_パンストCP.Update();
				this.X0Y1_パンスト_ハイライト1CP.Update();
				this.X0Y1_パンスト_ハイライト2CP.Update();
				this.X0Y1_ソックス_ソックスCP.Update();
				this.X0Y1_ソックス_ハイライト1CP.Update();
				this.X0Y1_ソックス_ハイライト2CP.Update();
				this.X0Y1_ブ\u30FCツ_タン_タンCP.Update();
				this.X0Y1_ブ\u30FCツ_タン_縁_縁1CP.Update();
				this.X0Y1_ブ\u30FCツ_タン_縁_縁2CP.Update();
				this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCP.Update();
				this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_皺_皺1CP.Update();
				this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_皺_皺2CP.Update();
				this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁1CP.Update();
				this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁2CP.Update();
				this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁3CP.Update();
				this.X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁4CP.Update();
				this.X0Y1_ブ\u30FCツ_柄CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_金具上_金具CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_金具上_穴CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐1_紐下_紐CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_金具上_金具CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_金具上_穴CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐1_紐上_紐CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_金具上_金具CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_金具上_穴CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐2_紐下_紐CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_金具上_金具CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_金具上_穴CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐2_紐上_紐CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_金具上_金具CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_金具上_穴CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐3_紐下_紐CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_金具上_金具CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_金具上_穴CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐3_紐上_紐CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_金具上_金具CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_金具上_穴CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐4_紐下_紐CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_金具上_金具CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_金具上_穴CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐4_紐上_紐CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_金具上_金具CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_金具上_穴CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐5_紐下_紐CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_金具上_金具CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_金具上_穴CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐5_紐上_紐CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_金具上_金具CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_金具上_穴CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐6_紐下_紐CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_金具上_金具CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_金具上_穴CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐6_紐上_紐CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_金具上_金具CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_金具上_穴CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐7_紐下_紐CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_金具上_金具CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_金具上_穴CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐7_紐上_紐CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_金具上_金具CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_金具上_穴CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐8_紐下_紐CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_金具上_金具CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_金具上_穴CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐8_紐上_紐CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_金具上_金具CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_金具上_穴CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐9_紐下_紐CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_金具上_金具CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_金具上_穴CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐9_紐上_紐CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_金具上_金具CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_金具上_穴CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐10_紐下_紐CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_金具上_金具CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_金具上_穴CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐10_紐上_紐CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_金具上_金具CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_金具上_穴CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐11_紐下_紐CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_金具上_金具CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_金具上_穴CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_紐11_紐上_紐CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐3CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐2CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_結び_紐左_紐1CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐3CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐2CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_結び_紐右_紐1CP.Update();
				this.X0Y1_ブ\u30FCツ_紐_結び_結び目CP.Update();
				this.X0Y1_ア\u30FCマ_ベ\u30FCスCP.Update();
				this.X0Y1_ア\u30FCマ_脛当_脛当1CP.Update();
				this.X0Y1_ア\u30FCマ_脛当_脛当2CP.Update();
				this.X0Y1_ア\u30FCマ_膝当CP.Update();
				this.X0Y1_ア\u30FCマ_穴_穴1CP.Update();
				this.X0Y1_ア\u30FCマ_穴_穴2CP.Update();
				this.X0Y1_ア\u30FCマ_穴_穴3CP.Update();
				this.X0Y1_ア\u30FCマ_穴_穴4CP.Update();
				this.X0Y1_脚輪上_革CP.Update();
				this.X0Y1_脚輪上_金具1CP.Update();
				this.X0Y1_脚輪上_金具2CP.Update();
				this.X0Y1_脚輪上_金具3CP.Update();
				this.X0Y1_脚輪上_金具左CP.Update();
				this.X0Y1_脚輪上_金具右CP.Update();
				this.X0Y1_脚輪下_革CP.Update();
				this.X0Y1_脚輪下_金具1CP.Update();
				this.X0Y1_脚輪下_金具2CP.Update();
				this.X0Y1_脚輪下_金具3CP.Update();
				this.X0Y1_脚輪下_金具左CP.Update();
				this.X0Y1_脚輪下_金具右CP.Update();
			}
			this.鎖1.接続PA();
			this.鎖3.接続PA();
			this.鎖1.色更新();
			this.鎖3.色更新();
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
			case 配色指定.C0:
				this.配色C0(体配色);
				return;
			case 配色指定.CT0:
				this.配色CT0(体配色);
				return;
			case 配色指定.CT1:
				this.配色CT1(体配色);
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
			this.脚CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.淫タトゥ_足首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.獣性_獣毛1CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛5CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.虫性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_膝CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_線CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷X2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I3CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I4CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I5CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2R);
			this.パンスト_パンストCD = new ColorD();
			this.パンスト_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.パンスト_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ソックスCD = new ColorD();
			this.ソックス_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ブ\u30FCツ_タン_タンCD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁3CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁4CD = new ColorD();
			this.ブ\u30FCツ_柄CD = new ColorD();
			this.ブ\u30FCツ_紐_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_結び目CD = new ColorD();
			this.ア\u30FCマ_ベ\u30FCスCD = new ColorD();
			this.ア\u30FCマ_脛当_脛当1CD = new ColorD();
			this.ア\u30FCマ_脛当_脛当2CD = new ColorD();
			this.ア\u30FCマ_膝当CD = new ColorD();
			this.ア\u30FCマ_穴_穴1CD = new ColorD();
			this.ア\u30FCマ_穴_穴2CD = new ColorD();
			this.ア\u30FCマ_穴_穴3CD = new ColorD();
			this.ア\u30FCマ_穴_穴4CD = new ColorD();
			this.脚輪上_革CD = new ColorD();
			this.脚輪上_金具1CD = new ColorD();
			this.脚輪上_金具2CD = new ColorD();
			this.脚輪上_金具3CD = new ColorD();
			this.脚輪上_金具左CD = new ColorD();
			this.脚輪上_金具右CD = new ColorD();
			this.脚輪下_革CD = new ColorD();
			this.脚輪下_金具1CD = new ColorD();
			this.脚輪下_金具2CD = new ColorD();
			this.脚輪下_金具3CD = new ColorD();
			this.脚輪下_金具左CD = new ColorD();
			this.脚輪下_金具右CD = new ColorD();
		}

		private void 配色T1(体配色 体配色)
		{
			this.脚CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.淫タトゥ_足首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.獣性_獣毛1CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛5CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_膝CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_線CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷X2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I3CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I4CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I5CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2R);
			this.パンスト_パンストCD = new ColorD();
			this.パンスト_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.パンスト_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ソックスCD = new ColorD();
			this.ソックス_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ブ\u30FCツ_タン_タンCD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁3CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁4CD = new ColorD();
			this.ブ\u30FCツ_柄CD = new ColorD();
			this.ブ\u30FCツ_紐_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_結び目CD = new ColorD();
			this.ア\u30FCマ_ベ\u30FCスCD = new ColorD();
			this.ア\u30FCマ_脛当_脛当1CD = new ColorD();
			this.ア\u30FCマ_脛当_脛当2CD = new ColorD();
			this.ア\u30FCマ_膝当CD = new ColorD();
			this.ア\u30FCマ_穴_穴1CD = new ColorD();
			this.ア\u30FCマ_穴_穴2CD = new ColorD();
			this.ア\u30FCマ_穴_穴3CD = new ColorD();
			this.ア\u30FCマ_穴_穴4CD = new ColorD();
			this.脚輪上_革CD = new ColorD();
			this.脚輪上_金具1CD = new ColorD();
			this.脚輪上_金具2CD = new ColorD();
			this.脚輪上_金具3CD = new ColorD();
			this.脚輪上_金具左CD = new ColorD();
			this.脚輪上_金具右CD = new ColorD();
			this.脚輪下_革CD = new ColorD();
			this.脚輪下_金具1CD = new ColorD();
			this.脚輪下_金具2CD = new ColorD();
			this.脚輪下_金具3CD = new ColorD();
			this.脚輪下_金具左CD = new ColorD();
			this.脚輪下_金具右CD = new ColorD();
		}

		private void 配色T0(体配色 体配色)
		{
			this.脚CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.淫タトゥ_足首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.獣性_獣毛1CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛5CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_棘_棘6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.虫性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性_膝CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_線CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷X2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I3CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I4CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I5CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2R);
			this.パンスト_パンストCD = new ColorD();
			this.パンスト_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.パンスト_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ソックスCD = new ColorD();
			this.ソックス_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ブ\u30FCツ_タン_タンCD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁3CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁4CD = new ColorD();
			this.ブ\u30FCツ_柄CD = new ColorD();
			this.ブ\u30FCツ_紐_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_結び目CD = new ColorD();
			this.ア\u30FCマ_ベ\u30FCスCD = new ColorD();
			this.ア\u30FCマ_脛当_脛当1CD = new ColorD();
			this.ア\u30FCマ_脛当_脛当2CD = new ColorD();
			this.ア\u30FCマ_膝当CD = new ColorD();
			this.ア\u30FCマ_穴_穴1CD = new ColorD();
			this.ア\u30FCマ_穴_穴2CD = new ColorD();
			this.ア\u30FCマ_穴_穴3CD = new ColorD();
			this.ア\u30FCマ_穴_穴4CD = new ColorD();
			this.脚輪上_革CD = new ColorD();
			this.脚輪上_金具1CD = new ColorD();
			this.脚輪上_金具2CD = new ColorD();
			this.脚輪上_金具3CD = new ColorD();
			this.脚輪上_金具左CD = new ColorD();
			this.脚輪上_金具右CD = new ColorD();
			this.脚輪下_革CD = new ColorD();
			this.脚輪下_金具1CD = new ColorD();
			this.脚輪下_金具2CD = new ColorD();
			this.脚輪下_金具3CD = new ColorD();
			this.脚輪下_金具左CD = new ColorD();
			this.脚輪下_金具右CD = new ColorD();
		}

		private void 配色B0(体配色 体配色)
		{
			this.脚CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.淫タトゥ_足首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.獣性_獣毛1CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛5CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.虫性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_膝CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_線CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷X2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I3CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I4CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I5CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2R);
			this.パンスト_パンストCD = new ColorD();
			this.パンスト_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.パンスト_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ソックスCD = new ColorD();
			this.ソックス_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ブ\u30FCツ_タン_タンCD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁3CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁4CD = new ColorD();
			this.ブ\u30FCツ_柄CD = new ColorD();
			this.ブ\u30FCツ_紐_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_結び目CD = new ColorD();
			this.ア\u30FCマ_ベ\u30FCスCD = new ColorD();
			this.ア\u30FCマ_脛当_脛当1CD = new ColorD();
			this.ア\u30FCマ_脛当_脛当2CD = new ColorD();
			this.ア\u30FCマ_膝当CD = new ColorD();
			this.ア\u30FCマ_穴_穴1CD = new ColorD();
			this.ア\u30FCマ_穴_穴2CD = new ColorD();
			this.ア\u30FCマ_穴_穴3CD = new ColorD();
			this.ア\u30FCマ_穴_穴4CD = new ColorD();
			this.脚輪上_革CD = new ColorD();
			this.脚輪上_金具1CD = new ColorD();
			this.脚輪上_金具2CD = new ColorD();
			this.脚輪上_金具3CD = new ColorD();
			this.脚輪上_金具左CD = new ColorD();
			this.脚輪上_金具右CD = new ColorD();
			this.脚輪下_革CD = new ColorD();
			this.脚輪下_金具1CD = new ColorD();
			this.脚輪下_金具2CD = new ColorD();
			this.脚輪下_金具3CD = new ColorD();
			this.脚輪下_金具左CD = new ColorD();
			this.脚輪下_金具右CD = new ColorD();
		}

		private void 配色BT1(体配色 体配色)
		{
			this.脚CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.淫タトゥ_足首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.獣性_獣毛1CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛5CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_膝CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_線CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷X2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I3CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I4CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I5CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2R);
			this.パンスト_パンストCD = new ColorD();
			this.パンスト_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.パンスト_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ソックスCD = new ColorD();
			this.ソックス_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ブ\u30FCツ_タン_タンCD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁3CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁4CD = new ColorD();
			this.ブ\u30FCツ_柄CD = new ColorD();
			this.ブ\u30FCツ_紐_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_結び目CD = new ColorD();
			this.ア\u30FCマ_ベ\u30FCスCD = new ColorD();
			this.ア\u30FCマ_脛当_脛当1CD = new ColorD();
			this.ア\u30FCマ_脛当_脛当2CD = new ColorD();
			this.ア\u30FCマ_膝当CD = new ColorD();
			this.ア\u30FCマ_穴_穴1CD = new ColorD();
			this.ア\u30FCマ_穴_穴2CD = new ColorD();
			this.ア\u30FCマ_穴_穴3CD = new ColorD();
			this.ア\u30FCマ_穴_穴4CD = new ColorD();
			this.脚輪上_革CD = new ColorD();
			this.脚輪上_金具1CD = new ColorD();
			this.脚輪上_金具2CD = new ColorD();
			this.脚輪上_金具3CD = new ColorD();
			this.脚輪上_金具左CD = new ColorD();
			this.脚輪上_金具右CD = new ColorD();
			this.脚輪下_革CD = new ColorD();
			this.脚輪下_金具1CD = new ColorD();
			this.脚輪下_金具2CD = new ColorD();
			this.脚輪下_金具3CD = new ColorD();
			this.脚輪下_金具左CD = new ColorD();
			this.脚輪下_金具右CD = new ColorD();
		}

		private void 配色BT0(体配色 体配色)
		{
			this.脚CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.淫タトゥ_足首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.獣性_獣毛1CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛5CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_棘_棘6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.虫性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性_膝CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_線CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷X2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I3CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I4CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I5CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2R);
			this.パンスト_パンストCD = new ColorD();
			this.パンスト_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.パンスト_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ソックスCD = new ColorD();
			this.ソックス_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ブ\u30FCツ_タン_タンCD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁3CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁4CD = new ColorD();
			this.ブ\u30FCツ_柄CD = new ColorD();
			this.ブ\u30FCツ_紐_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_結び目CD = new ColorD();
			this.ア\u30FCマ_ベ\u30FCスCD = new ColorD();
			this.ア\u30FCマ_脛当_脛当1CD = new ColorD();
			this.ア\u30FCマ_脛当_脛当2CD = new ColorD();
			this.ア\u30FCマ_膝当CD = new ColorD();
			this.ア\u30FCマ_穴_穴1CD = new ColorD();
			this.ア\u30FCマ_穴_穴2CD = new ColorD();
			this.ア\u30FCマ_穴_穴3CD = new ColorD();
			this.ア\u30FCマ_穴_穴4CD = new ColorD();
			this.脚輪上_革CD = new ColorD();
			this.脚輪上_金具1CD = new ColorD();
			this.脚輪上_金具2CD = new ColorD();
			this.脚輪上_金具3CD = new ColorD();
			this.脚輪上_金具左CD = new ColorD();
			this.脚輪上_金具右CD = new ColorD();
			this.脚輪下_革CD = new ColorD();
			this.脚輪下_金具1CD = new ColorD();
			this.脚輪下_金具2CD = new ColorD();
			this.脚輪下_金具3CD = new ColorD();
			this.脚輪下_金具左CD = new ColorD();
			this.脚輪下_金具右CD = new ColorD();
		}

		private void 配色C0(体配色 体配色)
		{
			this.脚CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.淫タトゥ_足首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.獣性_獣毛1CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛5CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.虫性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_膝CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_線CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷X2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I3CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I4CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I5CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2R);
			this.パンスト_パンストCD = new ColorD();
			this.パンスト_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.パンスト_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ソックスCD = new ColorD();
			this.ソックス_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ブ\u30FCツ_タン_タンCD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁3CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁4CD = new ColorD();
			this.ブ\u30FCツ_柄CD = new ColorD();
			this.ブ\u30FCツ_紐_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_結び目CD = new ColorD();
			this.ア\u30FCマ_ベ\u30FCスCD = new ColorD();
			this.ア\u30FCマ_脛当_脛当1CD = new ColorD();
			this.ア\u30FCマ_脛当_脛当2CD = new ColorD();
			this.ア\u30FCマ_膝当CD = new ColorD();
			this.ア\u30FCマ_穴_穴1CD = new ColorD();
			this.ア\u30FCマ_穴_穴2CD = new ColorD();
			this.ア\u30FCマ_穴_穴3CD = new ColorD();
			this.ア\u30FCマ_穴_穴4CD = new ColorD();
			this.脚輪上_革CD = new ColorD();
			this.脚輪上_金具1CD = new ColorD();
			this.脚輪上_金具2CD = new ColorD();
			this.脚輪上_金具3CD = new ColorD();
			this.脚輪上_金具左CD = new ColorD();
			this.脚輪上_金具右CD = new ColorD();
			this.脚輪下_革CD = new ColorD();
			this.脚輪下_金具1CD = new ColorD();
			this.脚輪下_金具2CD = new ColorD();
			this.脚輪下_金具3CD = new ColorD();
			this.脚輪下_金具左CD = new ColorD();
			this.脚輪下_金具右CD = new ColorD();
		}

		private void 配色CT1(体配色 体配色)
		{
			this.脚CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.淫タトゥ_足首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.獣性_獣毛1CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛5CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_膝CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_線CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷X2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I3CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I4CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I5CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2R);
			this.パンスト_パンストCD = new ColorD();
			this.パンスト_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.パンスト_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ソックスCD = new ColorD();
			this.ソックス_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ブ\u30FCツ_タン_タンCD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁3CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁4CD = new ColorD();
			this.ブ\u30FCツ_柄CD = new ColorD();
			this.ブ\u30FCツ_紐_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_結び目CD = new ColorD();
			this.ア\u30FCマ_ベ\u30FCスCD = new ColorD();
			this.ア\u30FCマ_脛当_脛当1CD = new ColorD();
			this.ア\u30FCマ_脛当_脛当2CD = new ColorD();
			this.ア\u30FCマ_膝当CD = new ColorD();
			this.ア\u30FCマ_穴_穴1CD = new ColorD();
			this.ア\u30FCマ_穴_穴2CD = new ColorD();
			this.ア\u30FCマ_穴_穴3CD = new ColorD();
			this.ア\u30FCマ_穴_穴4CD = new ColorD();
			this.脚輪上_革CD = new ColorD();
			this.脚輪上_金具1CD = new ColorD();
			this.脚輪上_金具2CD = new ColorD();
			this.脚輪上_金具3CD = new ColorD();
			this.脚輪上_金具左CD = new ColorD();
			this.脚輪上_金具右CD = new ColorD();
			this.脚輪下_革CD = new ColorD();
			this.脚輪下_金具1CD = new ColorD();
			this.脚輪下_金具2CD = new ColorD();
			this.脚輪下_金具3CD = new ColorD();
			this.脚輪下_金具左CD = new ColorD();
			this.脚輪下_金具右CD = new ColorD();
		}

		private void 配色CT0(体配色 体配色)
		{
			this.脚CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.淫タトゥ_足首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.獣性_獣毛1CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛5CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_棘_棘6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.虫性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性_膝CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_線CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷X2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I3CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I4CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I5CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2R);
			this.パンスト_パンストCD = new ColorD();
			this.パンスト_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.パンスト_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ソックスCD = new ColorD();
			this.ソックス_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ブ\u30FCツ_タン_タンCD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁3CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁4CD = new ColorD();
			this.ブ\u30FCツ_柄CD = new ColorD();
			this.ブ\u30FCツ_紐_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_結び目CD = new ColorD();
			this.ア\u30FCマ_ベ\u30FCスCD = new ColorD();
			this.ア\u30FCマ_脛当_脛当1CD = new ColorD();
			this.ア\u30FCマ_脛当_脛当2CD = new ColorD();
			this.ア\u30FCマ_膝当CD = new ColorD();
			this.ア\u30FCマ_穴_穴1CD = new ColorD();
			this.ア\u30FCマ_穴_穴2CD = new ColorD();
			this.ア\u30FCマ_穴_穴3CD = new ColorD();
			this.ア\u30FCマ_穴_穴4CD = new ColorD();
			this.脚輪上_革CD = new ColorD();
			this.脚輪上_金具1CD = new ColorD();
			this.脚輪上_金具2CD = new ColorD();
			this.脚輪上_金具3CD = new ColorD();
			this.脚輪上_金具左CD = new ColorD();
			this.脚輪上_金具右CD = new ColorD();
			this.脚輪下_革CD = new ColorD();
			this.脚輪下_金具1CD = new ColorD();
			this.脚輪下_金具2CD = new ColorD();
			this.脚輪下_金具3CD = new ColorD();
			this.脚輪下_金具左CD = new ColorD();
			this.脚輪下_金具右CD = new ColorD();
		}

		private void 配色L0(体配色 体配色)
		{
			this.脚CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.淫タトゥ_足首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.獣性_獣毛1CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛5CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.虫性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_膝CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_線CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷X2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I3CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I4CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I5CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2R);
			this.パンスト_パンストCD = new ColorD();
			this.パンスト_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.パンスト_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ソックスCD = new ColorD();
			this.ソックス_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ブ\u30FCツ_タン_タンCD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁3CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁4CD = new ColorD();
			this.ブ\u30FCツ_柄CD = new ColorD();
			this.ブ\u30FCツ_紐_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_結び目CD = new ColorD();
			this.ア\u30FCマ_ベ\u30FCスCD = new ColorD();
			this.ア\u30FCマ_脛当_脛当1CD = new ColorD();
			this.ア\u30FCマ_脛当_脛当2CD = new ColorD();
			this.ア\u30FCマ_膝当CD = new ColorD();
			this.ア\u30FCマ_穴_穴1CD = new ColorD();
			this.ア\u30FCマ_穴_穴2CD = new ColorD();
			this.ア\u30FCマ_穴_穴3CD = new ColorD();
			this.ア\u30FCマ_穴_穴4CD = new ColorD();
			this.脚輪上_革CD = new ColorD();
			this.脚輪上_金具1CD = new ColorD();
			this.脚輪上_金具2CD = new ColorD();
			this.脚輪上_金具3CD = new ColorD();
			this.脚輪上_金具左CD = new ColorD();
			this.脚輪上_金具右CD = new ColorD();
			this.脚輪下_革CD = new ColorD();
			this.脚輪下_金具1CD = new ColorD();
			this.脚輪下_金具2CD = new ColorD();
			this.脚輪下_金具3CD = new ColorD();
			this.脚輪下_金具左CD = new ColorD();
			this.脚輪下_金具右CD = new ColorD();
		}

		private void 配色LT1(体配色 体配色)
		{
			this.脚CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.淫タトゥ_足首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.獣性_獣毛1CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛5CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_膝CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_線CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷X2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I3CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I4CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I5CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2R);
			this.パンスト_パンストCD = new ColorD();
			this.パンスト_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.パンスト_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ソックスCD = new ColorD();
			this.ソックス_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ブ\u30FCツ_タン_タンCD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁3CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁4CD = new ColorD();
			this.ブ\u30FCツ_柄CD = new ColorD();
			this.ブ\u30FCツ_紐_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_結び目CD = new ColorD();
			this.ア\u30FCマ_ベ\u30FCスCD = new ColorD();
			this.ア\u30FCマ_脛当_脛当1CD = new ColorD();
			this.ア\u30FCマ_脛当_脛当2CD = new ColorD();
			this.ア\u30FCマ_膝当CD = new ColorD();
			this.ア\u30FCマ_穴_穴1CD = new ColorD();
			this.ア\u30FCマ_穴_穴2CD = new ColorD();
			this.ア\u30FCマ_穴_穴3CD = new ColorD();
			this.ア\u30FCマ_穴_穴4CD = new ColorD();
			this.脚輪上_革CD = new ColorD();
			this.脚輪上_金具1CD = new ColorD();
			this.脚輪上_金具2CD = new ColorD();
			this.脚輪上_金具3CD = new ColorD();
			this.脚輪上_金具左CD = new ColorD();
			this.脚輪上_金具右CD = new ColorD();
			this.脚輪下_革CD = new ColorD();
			this.脚輪下_金具1CD = new ColorD();
			this.脚輪下_金具2CD = new ColorD();
			this.脚輪下_金具3CD = new ColorD();
			this.脚輪下_金具左CD = new ColorD();
			this.脚輪下_金具右CD = new ColorD();
		}

		private void 配色LT0(体配色 体配色)
		{
			this.脚CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.淫タトゥ_足首_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト1_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト3_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_足首_ハ\u30FCト2_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_文字1_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字1_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字1_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_文字2_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_文字2_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青O);
			this.悪タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.獣性_獣毛1CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛5CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_鱗_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.竜性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_棘_棘4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_棘_棘5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_棘_棘6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.虫性_棘_棘1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性_棘_棘2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性_棘_棘3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性_膝CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.虫性_線CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.傷X1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷X2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I3CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I4CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I5CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2R);
			this.パンスト_パンストCD = new ColorD();
			this.パンスト_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.パンスト_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ソックスCD = new ColorD();
			this.ソックス_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ソックス_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ブ\u30FCツ_タン_タンCD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_タン_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁1CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁2CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁3CD = new ColorD();
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁4CD = new ColorD();
			this.ブ\u30FCツ_柄CD = new ColorD();
			this.ブ\u30FCツ_紐_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐1_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐2_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐3_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐4_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐5_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐6_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐7_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐8_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐9_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐10_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐下_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_金具CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_穴CD = new ColorD();
			this.ブ\u30FCツ_紐_紐11_紐上_紐CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐左_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐3CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐2CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_紐右_紐1CD = new ColorD();
			this.ブ\u30FCツ_紐_結び_結び目CD = new ColorD();
			this.ア\u30FCマ_ベ\u30FCスCD = new ColorD();
			this.ア\u30FCマ_脛当_脛当1CD = new ColorD();
			this.ア\u30FCマ_脛当_脛当2CD = new ColorD();
			this.ア\u30FCマ_膝当CD = new ColorD();
			this.ア\u30FCマ_穴_穴1CD = new ColorD();
			this.ア\u30FCマ_穴_穴2CD = new ColorD();
			this.ア\u30FCマ_穴_穴3CD = new ColorD();
			this.ア\u30FCマ_穴_穴4CD = new ColorD();
			this.脚輪上_革CD = new ColorD();
			this.脚輪上_金具1CD = new ColorD();
			this.脚輪上_金具2CD = new ColorD();
			this.脚輪上_金具3CD = new ColorD();
			this.脚輪上_金具左CD = new ColorD();
			this.脚輪上_金具右CD = new ColorD();
			this.脚輪下_革CD = new ColorD();
			this.脚輪下_金具1CD = new ColorD();
			this.脚輪下_金具2CD = new ColorD();
			this.脚輪下_金具3CD = new ColorD();
			this.脚輪下_金具左CD = new ColorD();
			this.脚輪下_金具右CD = new ColorD();
		}

		public void ブ\u30FCツ配色(ブ\u30FCツ色 配色)
		{
			this.ブ\u30FCツ_タン_タンCD.色 = 配色.生地2色;
			this.ブ\u30FCツ_タン_縁_縁1CD.色 = 配色.縁色;
			this.ブ\u30FCツ_タン_縁_縁2CD.色 = this.ブ\u30FCツ_タン_縁_縁1CD.色;
			this.ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCD.色 = 配色.生地1色;
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺1CD.色 = this.ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCD.色;
			this.ブ\u30FCツ_ブ\u30FCツ_皺_皺2CD.色 = this.ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCD.色;
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁1CD.色 = this.ブ\u30FCツ_タン_縁_縁1CD.色;
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁2CD.色 = this.ブ\u30FCツ_タン_縁_縁1CD.色;
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁3CD.色 = this.ブ\u30FCツ_タン_縁_縁1CD.色;
			this.ブ\u30FCツ_ブ\u30FCツ_縁_縁4CD.色 = this.ブ\u30FCツ_タン_縁_縁1CD.色;
			this.ブ\u30FCツ_柄CD.色 = 配色.柄色;
			this.ブ\u30FCツ_紐_紐CD.色 = 配色.紐色;
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD.色 = 配色.金具色;
			Color2 色;
			Col.GetGrad(ref 配色.穴, out 色);
			色.GetRep(out 色);
			this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD.色 = 色;
			this.ブ\u30FCツ_紐_紐1_紐下_紐CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_金具CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ_紐_紐1_紐上_金具上_穴CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ_紐_紐1_紐上_紐CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_金具CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ_紐_紐2_紐下_金具上_穴CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ_紐_紐2_紐下_紐CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_金具CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ_紐_紐2_紐上_金具上_穴CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ_紐_紐2_紐上_紐CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_金具CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ_紐_紐3_紐下_金具上_穴CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ_紐_紐3_紐下_紐CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_金具CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ_紐_紐3_紐上_金具上_穴CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ_紐_紐3_紐上_紐CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_金具CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ_紐_紐4_紐下_金具上_穴CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ_紐_紐4_紐下_紐CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_金具CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ_紐_紐4_紐上_金具上_穴CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ_紐_紐4_紐上_紐CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_金具CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ_紐_紐5_紐下_金具上_穴CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ_紐_紐5_紐下_紐CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_金具CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ_紐_紐5_紐上_金具上_穴CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ_紐_紐5_紐上_紐CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_金具CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ_紐_紐6_紐下_金具上_穴CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ_紐_紐6_紐下_紐CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_金具CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ_紐_紐6_紐上_金具上_穴CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ_紐_紐6_紐上_紐CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_金具CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ_紐_紐7_紐下_金具上_穴CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ_紐_紐7_紐下_紐CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_金具CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ_紐_紐7_紐上_金具上_穴CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ_紐_紐7_紐上_紐CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_金具CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ_紐_紐8_紐下_金具上_穴CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ_紐_紐8_紐下_紐CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_金具CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ_紐_紐8_紐上_金具上_穴CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ_紐_紐8_紐上_紐CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_金具CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ_紐_紐9_紐下_金具上_穴CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ_紐_紐9_紐下_紐CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_金具CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ_紐_紐9_紐上_金具上_穴CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ_紐_紐9_紐上_紐CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_金具CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ_紐_紐10_紐下_金具上_穴CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ_紐_紐10_紐下_紐CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_金具CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ_紐_紐10_紐上_金具上_穴CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ_紐_紐10_紐上_紐CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_金具CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ_紐_紐11_紐下_金具上_穴CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ_紐_紐11_紐下_紐CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_金具CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD.色;
			this.ブ\u30FCツ_紐_紐11_紐上_金具上_穴CD.色 = this.ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD.色;
			this.ブ\u30FCツ_紐_紐11_紐上_紐CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_結び_紐左_紐3CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_結び_紐左_紐2CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_結び_紐左_紐1CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_結び_紐右_紐3CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_結び_紐右_紐2CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_結び_紐右_紐1CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
			this.ブ\u30FCツ_紐_結び_結び目CD.色 = this.ブ\u30FCツ_紐_紐CD.色;
		}

		public void 脚輪1配色(拘束具色 配色)
		{
			this.脚輪上_革CD.色 = 配色.革部色;
			this.脚輪上_金具1CD.色 = 配色.金具色;
			this.脚輪上_金具2CD.色 = this.脚輪上_金具1CD.色;
			this.脚輪上_金具3CD.色 = this.脚輪上_金具1CD.色;
			this.脚輪上_金具左CD.色 = this.脚輪上_金具1CD.色;
			this.脚輪上_金具右CD.色 = this.脚輪上_金具1CD.色;
		}

		public void 脚輪2配色(拘束具色 配色)
		{
			this.脚輪下_革CD.色 = 配色.革部色;
			this.脚輪下_金具1CD.色 = 配色.金具色;
			this.脚輪下_金具2CD.色 = this.脚輪下_金具1CD.色;
			this.脚輪下_金具3CD.色 = this.脚輪下_金具1CD.色;
			this.脚輪下_金具左CD.色 = this.脚輪下_金具1CD.色;
			this.脚輪下_金具右CD.色 = this.脚輪下_金具1CD.色;
		}

		public void 鎖配色(鎖色 配色)
		{
			this.鎖1.配色鎖(配色);
			this.鎖3.配色鎖(配色);
		}

		public Par X0Y0_脚;

		public Par X0Y0_筋;

		public Par X0Y0_淫タトゥ_足首_タトゥ;

		public Par X0Y0_淫タトゥ_足首_ハ\u30FCト1_タトゥ左;

		public Par X0Y0_淫タトゥ_足首_ハ\u30FCト1_タトゥ右;

		public Par X0Y0_淫タトゥ_足首_ハ\u30FCト3_タトゥ左;

		public Par X0Y0_淫タトゥ_足首_ハ\u30FCト3_タトゥ右;

		public Par X0Y0_淫タトゥ_足首_ハ\u30FCト2_タトゥ左;

		public Par X0Y0_淫タトゥ_足首_ハ\u30FCト2_タトゥ右;

		public Par X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左;

		public Par X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右;

		public Par X0Y0_淫タトゥ_タトゥ左;

		public Par X0Y0_淫タトゥ_タトゥ右;

		public Par X0Y0_悪タトゥ_文字1_文字a_枠;

		public Par X0Y0_悪タトゥ_文字1_文字a_文字タトゥ1;

		public Par X0Y0_悪タトゥ_文字1_文字a_文字タトゥ2;

		public Par X0Y0_悪タトゥ_文字1_文字b_枠;

		public Par X0Y0_悪タトゥ_文字1_文字b_文字タトゥ1;

		public Par X0Y0_悪タトゥ_文字1_文字b_文字タトゥ2;

		public Par X0Y0_悪タトゥ_文字1_文字c_枠;

		public Par X0Y0_悪タトゥ_文字1_文字c_文字タトゥ1;

		public Par X0Y0_悪タトゥ_文字1_文字c_文字タトゥ2;

		public Par X0Y0_悪タトゥ_文字1_文字d_枠;

		public Par X0Y0_悪タトゥ_文字1_文字d_文字タトゥ1;

		public Par X0Y0_悪タトゥ_文字1_文字d_文字タトゥ2;

		public Par X0Y0_悪タトゥ_文字1_文字e_枠;

		public Par X0Y0_悪タトゥ_文字1_文字e_文字タトゥ1;

		public Par X0Y0_悪タトゥ_文字1_文字e_文字タトゥ2;

		public Par X0Y0_悪タトゥ_文字1_文字e_文字タトゥ3;

		public Par X0Y0_悪タトゥ_文字2_文字a_枠;

		public Par X0Y0_悪タトゥ_文字2_文字a_文字タトゥ1;

		public Par X0Y0_悪タトゥ_文字2_文字a_文字タトゥ2;

		public Par X0Y0_悪タトゥ_文字2_文字b_枠;

		public Par X0Y0_悪タトゥ_文字2_文字b_文字タトゥ1;

		public Par X0Y0_悪タトゥ_文字2_文字b_文字タトゥ2;

		public Par X0Y0_悪タトゥ_文字2_文字c_枠;

		public Par X0Y0_悪タトゥ_文字2_文字c_文字タトゥ1;

		public Par X0Y0_悪タトゥ_文字2_文字c_文字タトゥ2;

		public Par X0Y0_悪タトゥ_文字2_文字d_枠;

		public Par X0Y0_悪タトゥ_文字2_文字d_文字タトゥ1;

		public Par X0Y0_悪タトゥ_文字2_文字d_文字タトゥ2;

		public Par X0Y0_悪タトゥ_文字2_文字e_枠;

		public Par X0Y0_悪タトゥ_文字2_文字e_文字タトゥ1;

		public Par X0Y0_悪タトゥ_文字2_文字e_文字タトゥ2;

		public Par X0Y0_悪タトゥ_文字2_文字e_文字タトゥ3;

		public Par X0Y0_悪タトゥ_タトゥ1;

		public Par X0Y0_悪タトゥ_タトゥ2;

		public Par X0Y0_悪タトゥ_逆十字_逆十字1;

		public Par X0Y0_悪タトゥ_逆十字_逆十字2;

		public Par X0Y0_悪タトゥ_タトゥ左;

		public Par X0Y0_悪タトゥ_タトゥ右;

		public Par X0Y0_紋柄_紋1;

		public Par X0Y0_紋柄_紋2;

		public Par X0Y0_紋柄_紋3;

		public Par X0Y0_紋柄_紋4;

		public Par X0Y0_獣性_獣毛1;

		public Par X0Y0_獣性_獣毛2;

		public Par X0Y0_獣性_獣毛3;

		public Par X0Y0_獣性_獣毛4;

		public Par X0Y0_獣性_獣毛5;

		public Par X0Y0_竜性_鱗_鱗1;

		public Par X0Y0_竜性_鱗_鱗2;

		public Par X0Y0_竜性_鱗_鱗3;

		public Par X0Y0_竜性_鱗_鱗4;

		public Par X0Y0_竜性_鱗_鱗5;

		public Par X0Y0_竜性_鱗_鱗6;

		public Par X0Y0_竜性_鱗_鱗7;

		public Par X0Y0_竜性_棘_棘1;

		public Par X0Y0_竜性_棘_棘2;

		public Par X0Y0_竜性_棘_棘3;

		public Par X0Y0_竜性_棘_棘4;

		public Par X0Y0_竜性_棘_棘5;

		public Par X0Y0_竜性_棘_棘6;

		public Par X0Y0_虫性_棘_棘1;

		public Par X0Y0_虫性_棘_棘2;

		public Par X0Y0_虫性_棘_棘3;

		public Par X0Y0_虫性_膝;

		public Par X0Y0_虫性_線;

		public Par X0Y0_傷X1;

		public Par X0Y0_傷X2;

		public Par X0Y0_傷I1;

		public Par X0Y0_傷I2;

		public Par X0Y0_傷I3;

		public Par X0Y0_傷I4;

		public Par X0Y0_傷I5;

		public Par X0Y0_ハイライト1;

		public Par X0Y0_ハイライト2;

		public Par X0Y0_パンスト_パンスト;

		public Par X0Y0_パンスト_ハイライト1;

		public Par X0Y0_パンスト_ハイライト2;

		public Par X0Y0_ソックス_ソックス;

		public Par X0Y0_ソックス_ハイライト1;

		public Par X0Y0_ソックス_ハイライト2;

		public Par X0Y0_ブ\u30FCツ_タン_タン;

		public Par X0Y0_ブ\u30FCツ_タン_縁_縁1;

		public Par X0Y0_ブ\u30FCツ_タン_縁_縁2;

		public Par X0Y0_ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツ;

		public Par X0Y0_ブ\u30FCツ_ブ\u30FCツ_皺_皺1;

		public Par X0Y0_ブ\u30FCツ_ブ\u30FCツ_皺_皺2;

		public Par X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁1;

		public Par X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁2;

		public Par X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁3;

		public Par X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁4;

		public Par X0Y0_ブ\u30FCツ_柄;

		public Par X0Y0_ブ\u30FCツ_紐_紐;

		public Par X0Y0_ブ\u30FCツ_紐_紐1_紐下_金具上_金具;

		public Par X0Y0_ブ\u30FCツ_紐_紐1_紐下_金具上_穴;

		public Par X0Y0_ブ\u30FCツ_紐_紐1_紐下_紐;

		public Par X0Y0_ブ\u30FCツ_紐_紐1_紐上_金具上_金具;

		public Par X0Y0_ブ\u30FCツ_紐_紐1_紐上_金具上_穴;

		public Par X0Y0_ブ\u30FCツ_紐_紐1_紐上_紐;

		public Par X0Y0_ブ\u30FCツ_紐_紐2_紐下_金具上_金具;

		public Par X0Y0_ブ\u30FCツ_紐_紐2_紐下_金具上_穴;

		public Par X0Y0_ブ\u30FCツ_紐_紐2_紐下_紐;

		public Par X0Y0_ブ\u30FCツ_紐_紐2_紐上_金具上_金具;

		public Par X0Y0_ブ\u30FCツ_紐_紐2_紐上_金具上_穴;

		public Par X0Y0_ブ\u30FCツ_紐_紐2_紐上_紐;

		public Par X0Y0_ブ\u30FCツ_紐_紐3_紐下_金具上_金具;

		public Par X0Y0_ブ\u30FCツ_紐_紐3_紐下_金具上_穴;

		public Par X0Y0_ブ\u30FCツ_紐_紐3_紐下_紐;

		public Par X0Y0_ブ\u30FCツ_紐_紐3_紐上_金具上_金具;

		public Par X0Y0_ブ\u30FCツ_紐_紐3_紐上_金具上_穴;

		public Par X0Y0_ブ\u30FCツ_紐_紐3_紐上_紐;

		public Par X0Y0_ブ\u30FCツ_紐_紐4_紐下_金具上_金具;

		public Par X0Y0_ブ\u30FCツ_紐_紐4_紐下_金具上_穴;

		public Par X0Y0_ブ\u30FCツ_紐_紐4_紐下_紐;

		public Par X0Y0_ブ\u30FCツ_紐_紐4_紐上_金具上_金具;

		public Par X0Y0_ブ\u30FCツ_紐_紐4_紐上_金具上_穴;

		public Par X0Y0_ブ\u30FCツ_紐_紐4_紐上_紐;

		public Par X0Y0_ブ\u30FCツ_紐_紐5_紐下_金具上_金具;

		public Par X0Y0_ブ\u30FCツ_紐_紐5_紐下_金具上_穴;

		public Par X0Y0_ブ\u30FCツ_紐_紐5_紐下_紐;

		public Par X0Y0_ブ\u30FCツ_紐_紐5_紐上_金具上_金具;

		public Par X0Y0_ブ\u30FCツ_紐_紐5_紐上_金具上_穴;

		public Par X0Y0_ブ\u30FCツ_紐_紐5_紐上_紐;

		public Par X0Y0_ブ\u30FCツ_紐_紐6_紐下_金具上_金具;

		public Par X0Y0_ブ\u30FCツ_紐_紐6_紐下_金具上_穴;

		public Par X0Y0_ブ\u30FCツ_紐_紐6_紐下_紐;

		public Par X0Y0_ブ\u30FCツ_紐_紐6_紐上_金具上_金具;

		public Par X0Y0_ブ\u30FCツ_紐_紐6_紐上_金具上_穴;

		public Par X0Y0_ブ\u30FCツ_紐_紐6_紐上_紐;

		public Par X0Y0_ブ\u30FCツ_紐_紐7_紐下_金具上_金具;

		public Par X0Y0_ブ\u30FCツ_紐_紐7_紐下_金具上_穴;

		public Par X0Y0_ブ\u30FCツ_紐_紐7_紐下_紐;

		public Par X0Y0_ブ\u30FCツ_紐_紐7_紐上_金具上_金具;

		public Par X0Y0_ブ\u30FCツ_紐_紐7_紐上_金具上_穴;

		public Par X0Y0_ブ\u30FCツ_紐_紐7_紐上_紐;

		public Par X0Y0_ブ\u30FCツ_紐_紐8_紐下_金具上_金具;

		public Par X0Y0_ブ\u30FCツ_紐_紐8_紐下_金具上_穴;

		public Par X0Y0_ブ\u30FCツ_紐_紐8_紐下_紐;

		public Par X0Y0_ブ\u30FCツ_紐_紐8_紐上_金具上_金具;

		public Par X0Y0_ブ\u30FCツ_紐_紐8_紐上_金具上_穴;

		public Par X0Y0_ブ\u30FCツ_紐_紐8_紐上_紐;

		public Par X0Y0_ブ\u30FCツ_紐_紐9_紐下_金具上_金具;

		public Par X0Y0_ブ\u30FCツ_紐_紐9_紐下_金具上_穴;

		public Par X0Y0_ブ\u30FCツ_紐_紐9_紐下_紐;

		public Par X0Y0_ブ\u30FCツ_紐_紐9_紐上_金具上_金具;

		public Par X0Y0_ブ\u30FCツ_紐_紐9_紐上_金具上_穴;

		public Par X0Y0_ブ\u30FCツ_紐_紐9_紐上_紐;

		public Par X0Y0_ブ\u30FCツ_紐_紐10_紐下_金具上_金具;

		public Par X0Y0_ブ\u30FCツ_紐_紐10_紐下_金具上_穴;

		public Par X0Y0_ブ\u30FCツ_紐_紐10_紐下_紐;

		public Par X0Y0_ブ\u30FCツ_紐_紐10_紐上_金具上_金具;

		public Par X0Y0_ブ\u30FCツ_紐_紐10_紐上_金具上_穴;

		public Par X0Y0_ブ\u30FCツ_紐_紐10_紐上_紐;

		public Par X0Y0_ブ\u30FCツ_紐_紐11_紐下_金具上_金具;

		public Par X0Y0_ブ\u30FCツ_紐_紐11_紐下_金具上_穴;

		public Par X0Y0_ブ\u30FCツ_紐_紐11_紐下_紐;

		public Par X0Y0_ブ\u30FCツ_紐_紐11_紐上_金具上_金具;

		public Par X0Y0_ブ\u30FCツ_紐_紐11_紐上_金具上_穴;

		public Par X0Y0_ブ\u30FCツ_紐_紐11_紐上_紐;

		public Par X0Y0_ブ\u30FCツ_紐_結び_紐左_紐3;

		public Par X0Y0_ブ\u30FCツ_紐_結び_紐左_紐2;

		public Par X0Y0_ブ\u30FCツ_紐_結び_紐左_紐1;

		public Par X0Y0_ブ\u30FCツ_紐_結び_紐右_紐3;

		public Par X0Y0_ブ\u30FCツ_紐_結び_紐右_紐2;

		public Par X0Y0_ブ\u30FCツ_紐_結び_紐右_紐1;

		public Par X0Y0_ブ\u30FCツ_紐_結び_結び目;

		public Par X0Y0_ア\u30FCマ_ベ\u30FCス;

		public Par X0Y0_ア\u30FCマ_脛当_脛当1;

		public Par X0Y0_ア\u30FCマ_脛当_脛当2;

		public Par X0Y0_ア\u30FCマ_膝当;

		public Par X0Y0_ア\u30FCマ_穴_穴1;

		public Par X0Y0_ア\u30FCマ_穴_穴2;

		public Par X0Y0_ア\u30FCマ_穴_穴3;

		public Par X0Y0_ア\u30FCマ_穴_穴4;

		public Par X0Y0_脚輪上_革;

		public Par X0Y0_脚輪上_金具1;

		public Par X0Y0_脚輪上_金具2;

		public Par X0Y0_脚輪上_金具3;

		public Par X0Y0_脚輪上_金具左;

		public Par X0Y0_脚輪上_金具右;

		public Par X0Y0_脚輪下_革;

		public Par X0Y0_脚輪下_金具1;

		public Par X0Y0_脚輪下_金具2;

		public Par X0Y0_脚輪下_金具3;

		public Par X0Y0_脚輪下_金具左;

		public Par X0Y0_脚輪下_金具右;

		public Par X0Y1_脚;

		public Par X0Y1_筋;

		public Par X0Y1_淫タトゥ_足首_タトゥ;

		public Par X0Y1_淫タトゥ_足首_ハ\u30FCト1_タトゥ左;

		public Par X0Y1_淫タトゥ_足首_ハ\u30FCト1_タトゥ右;

		public Par X0Y1_淫タトゥ_足首_ハ\u30FCト3_タトゥ左;

		public Par X0Y1_淫タトゥ_足首_ハ\u30FCト3_タトゥ右;

		public Par X0Y1_淫タトゥ_足首_ハ\u30FCト2_タトゥ左;

		public Par X0Y1_淫タトゥ_足首_ハ\u30FCト2_タトゥ右;

		public Par X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左;

		public Par X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右;

		public Par X0Y1_淫タトゥ_タトゥ左;

		public Par X0Y1_淫タトゥ_タトゥ右;

		public Par X0Y1_悪タトゥ_文字1_文字a_枠;

		public Par X0Y1_悪タトゥ_文字1_文字a_文字タトゥ1;

		public Par X0Y1_悪タトゥ_文字1_文字a_文字タトゥ2;

		public Par X0Y1_悪タトゥ_文字1_文字b_枠;

		public Par X0Y1_悪タトゥ_文字1_文字b_文字タトゥ1;

		public Par X0Y1_悪タトゥ_文字1_文字b_文字タトゥ2;

		public Par X0Y1_悪タトゥ_文字1_文字c_枠;

		public Par X0Y1_悪タトゥ_文字1_文字c_文字タトゥ1;

		public Par X0Y1_悪タトゥ_文字1_文字c_文字タトゥ2;

		public Par X0Y1_悪タトゥ_文字1_文字d_枠;

		public Par X0Y1_悪タトゥ_文字1_文字d_文字タトゥ1;

		public Par X0Y1_悪タトゥ_文字1_文字d_文字タトゥ2;

		public Par X0Y1_悪タトゥ_文字1_文字e_枠;

		public Par X0Y1_悪タトゥ_文字1_文字e_文字タトゥ1;

		public Par X0Y1_悪タトゥ_文字1_文字e_文字タトゥ2;

		public Par X0Y1_悪タトゥ_文字1_文字e_文字タトゥ3;

		public Par X0Y1_悪タトゥ_文字2_文字a_枠;

		public Par X0Y1_悪タトゥ_文字2_文字a_文字タトゥ1;

		public Par X0Y1_悪タトゥ_文字2_文字a_文字タトゥ2;

		public Par X0Y1_悪タトゥ_文字2_文字b_枠;

		public Par X0Y1_悪タトゥ_文字2_文字b_文字タトゥ1;

		public Par X0Y1_悪タトゥ_文字2_文字b_文字タトゥ2;

		public Par X0Y1_悪タトゥ_文字2_文字c_枠;

		public Par X0Y1_悪タトゥ_文字2_文字c_文字タトゥ1;

		public Par X0Y1_悪タトゥ_文字2_文字c_文字タトゥ2;

		public Par X0Y1_悪タトゥ_文字2_文字d_枠;

		public Par X0Y1_悪タトゥ_文字2_文字d_文字タトゥ1;

		public Par X0Y1_悪タトゥ_文字2_文字d_文字タトゥ2;

		public Par X0Y1_悪タトゥ_文字2_文字e_枠;

		public Par X0Y1_悪タトゥ_文字2_文字e_文字タトゥ1;

		public Par X0Y1_悪タトゥ_文字2_文字e_文字タトゥ2;

		public Par X0Y1_悪タトゥ_文字2_文字e_文字タトゥ3;

		public Par X0Y1_悪タトゥ_タトゥ1;

		public Par X0Y1_悪タトゥ_タトゥ2;

		public Par X0Y1_悪タトゥ_逆十字_逆十字1;

		public Par X0Y1_悪タトゥ_逆十字_逆十字2;

		public Par X0Y1_悪タトゥ_タトゥ左;

		public Par X0Y1_悪タトゥ_タトゥ右;

		public Par X0Y1_紋柄_紋1;

		public Par X0Y1_紋柄_紋2;

		public Par X0Y1_紋柄_紋3;

		public Par X0Y1_紋柄_紋4;

		public Par X0Y1_獣性_獣毛1;

		public Par X0Y1_獣性_獣毛2;

		public Par X0Y1_獣性_獣毛3;

		public Par X0Y1_獣性_獣毛4;

		public Par X0Y1_獣性_獣毛5;

		public Par X0Y1_竜性_鱗_鱗1;

		public Par X0Y1_竜性_鱗_鱗2;

		public Par X0Y1_竜性_鱗_鱗3;

		public Par X0Y1_竜性_鱗_鱗4;

		public Par X0Y1_竜性_鱗_鱗5;

		public Par X0Y1_竜性_鱗_鱗6;

		public Par X0Y1_竜性_鱗_鱗7;

		public Par X0Y1_竜性_棘_棘1;

		public Par X0Y1_竜性_棘_棘2;

		public Par X0Y1_竜性_棘_棘3;

		public Par X0Y1_竜性_棘_棘4;

		public Par X0Y1_竜性_棘_棘5;

		public Par X0Y1_竜性_棘_棘6;

		public Par X0Y1_虫性_棘_棘1;

		public Par X0Y1_虫性_棘_棘2;

		public Par X0Y1_虫性_棘_棘3;

		public Par X0Y1_虫性_膝;

		public Par X0Y1_虫性_線;

		public Par X0Y1_傷X1;

		public Par X0Y1_傷X2;

		public Par X0Y1_傷I1;

		public Par X0Y1_傷I2;

		public Par X0Y1_傷I3;

		public Par X0Y1_傷I4;

		public Par X0Y1_傷I5;

		public Par X0Y1_ハイライト1;

		public Par X0Y1_ハイライト2;

		public Par X0Y1_パンスト_パンスト;

		public Par X0Y1_パンスト_ハイライト1;

		public Par X0Y1_パンスト_ハイライト2;

		public Par X0Y1_ソックス_ソックス;

		public Par X0Y1_ソックス_ハイライト1;

		public Par X0Y1_ソックス_ハイライト2;

		public Par X0Y1_ブ\u30FCツ_タン_タン;

		public Par X0Y1_ブ\u30FCツ_タン_縁_縁1;

		public Par X0Y1_ブ\u30FCツ_タン_縁_縁2;

		public Par X0Y1_ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツ;

		public Par X0Y1_ブ\u30FCツ_ブ\u30FCツ_皺_皺1;

		public Par X0Y1_ブ\u30FCツ_ブ\u30FCツ_皺_皺2;

		public Par X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁1;

		public Par X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁2;

		public Par X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁3;

		public Par X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁4;

		public Par X0Y1_ブ\u30FCツ_柄;

		public Par X0Y1_ブ\u30FCツ_紐_紐;

		public Par X0Y1_ブ\u30FCツ_紐_紐1_紐下_金具上_金具;

		public Par X0Y1_ブ\u30FCツ_紐_紐1_紐下_金具上_穴;

		public Par X0Y1_ブ\u30FCツ_紐_紐1_紐下_紐;

		public Par X0Y1_ブ\u30FCツ_紐_紐1_紐上_金具上_金具;

		public Par X0Y1_ブ\u30FCツ_紐_紐1_紐上_金具上_穴;

		public Par X0Y1_ブ\u30FCツ_紐_紐1_紐上_紐;

		public Par X0Y1_ブ\u30FCツ_紐_紐2_紐下_金具上_金具;

		public Par X0Y1_ブ\u30FCツ_紐_紐2_紐下_金具上_穴;

		public Par X0Y1_ブ\u30FCツ_紐_紐2_紐下_紐;

		public Par X0Y1_ブ\u30FCツ_紐_紐2_紐上_金具上_金具;

		public Par X0Y1_ブ\u30FCツ_紐_紐2_紐上_金具上_穴;

		public Par X0Y1_ブ\u30FCツ_紐_紐2_紐上_紐;

		public Par X0Y1_ブ\u30FCツ_紐_紐3_紐下_金具上_金具;

		public Par X0Y1_ブ\u30FCツ_紐_紐3_紐下_金具上_穴;

		public Par X0Y1_ブ\u30FCツ_紐_紐3_紐下_紐;

		public Par X0Y1_ブ\u30FCツ_紐_紐3_紐上_金具上_金具;

		public Par X0Y1_ブ\u30FCツ_紐_紐3_紐上_金具上_穴;

		public Par X0Y1_ブ\u30FCツ_紐_紐3_紐上_紐;

		public Par X0Y1_ブ\u30FCツ_紐_紐4_紐下_金具上_金具;

		public Par X0Y1_ブ\u30FCツ_紐_紐4_紐下_金具上_穴;

		public Par X0Y1_ブ\u30FCツ_紐_紐4_紐下_紐;

		public Par X0Y1_ブ\u30FCツ_紐_紐4_紐上_金具上_金具;

		public Par X0Y1_ブ\u30FCツ_紐_紐4_紐上_金具上_穴;

		public Par X0Y1_ブ\u30FCツ_紐_紐4_紐上_紐;

		public Par X0Y1_ブ\u30FCツ_紐_紐5_紐下_金具上_金具;

		public Par X0Y1_ブ\u30FCツ_紐_紐5_紐下_金具上_穴;

		public Par X0Y1_ブ\u30FCツ_紐_紐5_紐下_紐;

		public Par X0Y1_ブ\u30FCツ_紐_紐5_紐上_金具上_金具;

		public Par X0Y1_ブ\u30FCツ_紐_紐5_紐上_金具上_穴;

		public Par X0Y1_ブ\u30FCツ_紐_紐5_紐上_紐;

		public Par X0Y1_ブ\u30FCツ_紐_紐6_紐下_金具上_金具;

		public Par X0Y1_ブ\u30FCツ_紐_紐6_紐下_金具上_穴;

		public Par X0Y1_ブ\u30FCツ_紐_紐6_紐下_紐;

		public Par X0Y1_ブ\u30FCツ_紐_紐6_紐上_金具上_金具;

		public Par X0Y1_ブ\u30FCツ_紐_紐6_紐上_金具上_穴;

		public Par X0Y1_ブ\u30FCツ_紐_紐6_紐上_紐;

		public Par X0Y1_ブ\u30FCツ_紐_紐7_紐下_金具上_金具;

		public Par X0Y1_ブ\u30FCツ_紐_紐7_紐下_金具上_穴;

		public Par X0Y1_ブ\u30FCツ_紐_紐7_紐下_紐;

		public Par X0Y1_ブ\u30FCツ_紐_紐7_紐上_金具上_金具;

		public Par X0Y1_ブ\u30FCツ_紐_紐7_紐上_金具上_穴;

		public Par X0Y1_ブ\u30FCツ_紐_紐7_紐上_紐;

		public Par X0Y1_ブ\u30FCツ_紐_紐8_紐下_金具上_金具;

		public Par X0Y1_ブ\u30FCツ_紐_紐8_紐下_金具上_穴;

		public Par X0Y1_ブ\u30FCツ_紐_紐8_紐下_紐;

		public Par X0Y1_ブ\u30FCツ_紐_紐8_紐上_金具上_金具;

		public Par X0Y1_ブ\u30FCツ_紐_紐8_紐上_金具上_穴;

		public Par X0Y1_ブ\u30FCツ_紐_紐8_紐上_紐;

		public Par X0Y1_ブ\u30FCツ_紐_紐9_紐下_金具上_金具;

		public Par X0Y1_ブ\u30FCツ_紐_紐9_紐下_金具上_穴;

		public Par X0Y1_ブ\u30FCツ_紐_紐9_紐下_紐;

		public Par X0Y1_ブ\u30FCツ_紐_紐9_紐上_金具上_金具;

		public Par X0Y1_ブ\u30FCツ_紐_紐9_紐上_金具上_穴;

		public Par X0Y1_ブ\u30FCツ_紐_紐9_紐上_紐;

		public Par X0Y1_ブ\u30FCツ_紐_紐10_紐下_金具上_金具;

		public Par X0Y1_ブ\u30FCツ_紐_紐10_紐下_金具上_穴;

		public Par X0Y1_ブ\u30FCツ_紐_紐10_紐下_紐;

		public Par X0Y1_ブ\u30FCツ_紐_紐10_紐上_金具上_金具;

		public Par X0Y1_ブ\u30FCツ_紐_紐10_紐上_金具上_穴;

		public Par X0Y1_ブ\u30FCツ_紐_紐10_紐上_紐;

		public Par X0Y1_ブ\u30FCツ_紐_紐11_紐下_金具上_金具;

		public Par X0Y1_ブ\u30FCツ_紐_紐11_紐下_金具上_穴;

		public Par X0Y1_ブ\u30FCツ_紐_紐11_紐下_紐;

		public Par X0Y1_ブ\u30FCツ_紐_紐11_紐上_金具上_金具;

		public Par X0Y1_ブ\u30FCツ_紐_紐11_紐上_金具上_穴;

		public Par X0Y1_ブ\u30FCツ_紐_紐11_紐上_紐;

		public Par X0Y1_ブ\u30FCツ_紐_結び_紐左_紐3;

		public Par X0Y1_ブ\u30FCツ_紐_結び_紐左_紐2;

		public Par X0Y1_ブ\u30FCツ_紐_結び_紐左_紐1;

		public Par X0Y1_ブ\u30FCツ_紐_結び_紐右_紐3;

		public Par X0Y1_ブ\u30FCツ_紐_結び_紐右_紐2;

		public Par X0Y1_ブ\u30FCツ_紐_結び_紐右_紐1;

		public Par X0Y1_ブ\u30FCツ_紐_結び_結び目;

		public Par X0Y1_ア\u30FCマ_ベ\u30FCス;

		public Par X0Y1_ア\u30FCマ_脛当_脛当1;

		public Par X0Y1_ア\u30FCマ_脛当_脛当2;

		public Par X0Y1_ア\u30FCマ_膝当;

		public Par X0Y1_ア\u30FCマ_穴_穴1;

		public Par X0Y1_ア\u30FCマ_穴_穴2;

		public Par X0Y1_ア\u30FCマ_穴_穴3;

		public Par X0Y1_ア\u30FCマ_穴_穴4;

		public Par X0Y1_脚輪上_革;

		public Par X0Y1_脚輪上_金具1;

		public Par X0Y1_脚輪上_金具2;

		public Par X0Y1_脚輪上_金具3;

		public Par X0Y1_脚輪上_金具左;

		public Par X0Y1_脚輪上_金具右;

		public Par X0Y1_脚輪下_革;

		public Par X0Y1_脚輪下_金具1;

		public Par X0Y1_脚輪下_金具2;

		public Par X0Y1_脚輪下_金具3;

		public Par X0Y1_脚輪下_金具左;

		public Par X0Y1_脚輪下_金具右;

		public ColorD 脚CD;

		public ColorD 筋CD;

		public ColorD 淫タトゥ_足首_タトゥCD;

		public ColorD 淫タトゥ_足首_ハ\u30FCト1_タトゥ左CD;

		public ColorD 淫タトゥ_足首_ハ\u30FCト1_タトゥ右CD;

		public ColorD 淫タトゥ_足首_ハ\u30FCト3_タトゥ左CD;

		public ColorD 淫タトゥ_足首_ハ\u30FCト3_タトゥ右CD;

		public ColorD 淫タトゥ_足首_ハ\u30FCト2_タトゥ左CD;

		public ColorD 淫タトゥ_足首_ハ\u30FCト2_タトゥ右CD;

		public ColorD 淫タトゥ_ハ\u30FCト_タトゥ左CD;

		public ColorD 淫タトゥ_ハ\u30FCト_タトゥ右CD;

		public ColorD 淫タトゥ_タトゥ左CD;

		public ColorD 淫タトゥ_タトゥ右CD;

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

		public ColorD 悪タトゥ_タトゥ左CD;

		public ColorD 悪タトゥ_タトゥ右CD;

		public ColorD 紋柄_紋1CD;

		public ColorD 紋柄_紋2CD;

		public ColorD 紋柄_紋3CD;

		public ColorD 紋柄_紋4CD;

		public ColorD 獣性_獣毛1CD;

		public ColorD 獣性_獣毛2CD;

		public ColorD 獣性_獣毛3CD;

		public ColorD 獣性_獣毛4CD;

		public ColorD 獣性_獣毛5CD;

		public ColorD 竜性_鱗_鱗1CD;

		public ColorD 竜性_鱗_鱗2CD;

		public ColorD 竜性_鱗_鱗3CD;

		public ColorD 竜性_鱗_鱗4CD;

		public ColorD 竜性_鱗_鱗5CD;

		public ColorD 竜性_鱗_鱗6CD;

		public ColorD 竜性_鱗_鱗7CD;

		public ColorD 竜性_棘_棘1CD;

		public ColorD 竜性_棘_棘2CD;

		public ColorD 竜性_棘_棘3CD;

		public ColorD 竜性_棘_棘4CD;

		public ColorD 竜性_棘_棘5CD;

		public ColorD 竜性_棘_棘6CD;

		public ColorD 虫性_棘_棘1CD;

		public ColorD 虫性_棘_棘2CD;

		public ColorD 虫性_棘_棘3CD;

		public ColorD 虫性_膝CD;

		public ColorD 虫性_線CD;

		public ColorD 傷X1CD;

		public ColorD 傷X2CD;

		public ColorD 傷I1CD;

		public ColorD 傷I2CD;

		public ColorD 傷I3CD;

		public ColorD 傷I4CD;

		public ColorD 傷I5CD;

		public ColorD ハイライト1CD;

		public ColorD ハイライト2CD;

		public ColorD パンスト_パンストCD;

		public ColorD パンスト_ハイライト1CD;

		public ColorD パンスト_ハイライト2CD;

		public ColorD ソックス_ソックスCD;

		public ColorD ソックス_ハイライト1CD;

		public ColorD ソックス_ハイライト2CD;

		public ColorD ブ\u30FCツ_タン_タンCD;

		public ColorD ブ\u30FCツ_タン_縁_縁1CD;

		public ColorD ブ\u30FCツ_タン_縁_縁2CD;

		public ColorD ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCD;

		public ColorD ブ\u30FCツ_ブ\u30FCツ_皺_皺1CD;

		public ColorD ブ\u30FCツ_ブ\u30FCツ_皺_皺2CD;

		public ColorD ブ\u30FCツ_ブ\u30FCツ_縁_縁1CD;

		public ColorD ブ\u30FCツ_ブ\u30FCツ_縁_縁2CD;

		public ColorD ブ\u30FCツ_ブ\u30FCツ_縁_縁3CD;

		public ColorD ブ\u30FCツ_ブ\u30FCツ_縁_縁4CD;

		public ColorD ブ\u30FCツ_柄CD;

		public ColorD ブ\u30FCツ_紐_紐CD;

		public ColorD ブ\u30FCツ_紐_紐1_紐下_金具上_金具CD;

		public ColorD ブ\u30FCツ_紐_紐1_紐下_金具上_穴CD;

		public ColorD ブ\u30FCツ_紐_紐1_紐下_紐CD;

		public ColorD ブ\u30FCツ_紐_紐1_紐上_金具上_金具CD;

		public ColorD ブ\u30FCツ_紐_紐1_紐上_金具上_穴CD;

		public ColorD ブ\u30FCツ_紐_紐1_紐上_紐CD;

		public ColorD ブ\u30FCツ_紐_紐2_紐下_金具上_金具CD;

		public ColorD ブ\u30FCツ_紐_紐2_紐下_金具上_穴CD;

		public ColorD ブ\u30FCツ_紐_紐2_紐下_紐CD;

		public ColorD ブ\u30FCツ_紐_紐2_紐上_金具上_金具CD;

		public ColorD ブ\u30FCツ_紐_紐2_紐上_金具上_穴CD;

		public ColorD ブ\u30FCツ_紐_紐2_紐上_紐CD;

		public ColorD ブ\u30FCツ_紐_紐3_紐下_金具上_金具CD;

		public ColorD ブ\u30FCツ_紐_紐3_紐下_金具上_穴CD;

		public ColorD ブ\u30FCツ_紐_紐3_紐下_紐CD;

		public ColorD ブ\u30FCツ_紐_紐3_紐上_金具上_金具CD;

		public ColorD ブ\u30FCツ_紐_紐3_紐上_金具上_穴CD;

		public ColorD ブ\u30FCツ_紐_紐3_紐上_紐CD;

		public ColorD ブ\u30FCツ_紐_紐4_紐下_金具上_金具CD;

		public ColorD ブ\u30FCツ_紐_紐4_紐下_金具上_穴CD;

		public ColorD ブ\u30FCツ_紐_紐4_紐下_紐CD;

		public ColorD ブ\u30FCツ_紐_紐4_紐上_金具上_金具CD;

		public ColorD ブ\u30FCツ_紐_紐4_紐上_金具上_穴CD;

		public ColorD ブ\u30FCツ_紐_紐4_紐上_紐CD;

		public ColorD ブ\u30FCツ_紐_紐5_紐下_金具上_金具CD;

		public ColorD ブ\u30FCツ_紐_紐5_紐下_金具上_穴CD;

		public ColorD ブ\u30FCツ_紐_紐5_紐下_紐CD;

		public ColorD ブ\u30FCツ_紐_紐5_紐上_金具上_金具CD;

		public ColorD ブ\u30FCツ_紐_紐5_紐上_金具上_穴CD;

		public ColorD ブ\u30FCツ_紐_紐5_紐上_紐CD;

		public ColorD ブ\u30FCツ_紐_紐6_紐下_金具上_金具CD;

		public ColorD ブ\u30FCツ_紐_紐6_紐下_金具上_穴CD;

		public ColorD ブ\u30FCツ_紐_紐6_紐下_紐CD;

		public ColorD ブ\u30FCツ_紐_紐6_紐上_金具上_金具CD;

		public ColorD ブ\u30FCツ_紐_紐6_紐上_金具上_穴CD;

		public ColorD ブ\u30FCツ_紐_紐6_紐上_紐CD;

		public ColorD ブ\u30FCツ_紐_紐7_紐下_金具上_金具CD;

		public ColorD ブ\u30FCツ_紐_紐7_紐下_金具上_穴CD;

		public ColorD ブ\u30FCツ_紐_紐7_紐下_紐CD;

		public ColorD ブ\u30FCツ_紐_紐7_紐上_金具上_金具CD;

		public ColorD ブ\u30FCツ_紐_紐7_紐上_金具上_穴CD;

		public ColorD ブ\u30FCツ_紐_紐7_紐上_紐CD;

		public ColorD ブ\u30FCツ_紐_紐8_紐下_金具上_金具CD;

		public ColorD ブ\u30FCツ_紐_紐8_紐下_金具上_穴CD;

		public ColorD ブ\u30FCツ_紐_紐8_紐下_紐CD;

		public ColorD ブ\u30FCツ_紐_紐8_紐上_金具上_金具CD;

		public ColorD ブ\u30FCツ_紐_紐8_紐上_金具上_穴CD;

		public ColorD ブ\u30FCツ_紐_紐8_紐上_紐CD;

		public ColorD ブ\u30FCツ_紐_紐9_紐下_金具上_金具CD;

		public ColorD ブ\u30FCツ_紐_紐9_紐下_金具上_穴CD;

		public ColorD ブ\u30FCツ_紐_紐9_紐下_紐CD;

		public ColorD ブ\u30FCツ_紐_紐9_紐上_金具上_金具CD;

		public ColorD ブ\u30FCツ_紐_紐9_紐上_金具上_穴CD;

		public ColorD ブ\u30FCツ_紐_紐9_紐上_紐CD;

		public ColorD ブ\u30FCツ_紐_紐10_紐下_金具上_金具CD;

		public ColorD ブ\u30FCツ_紐_紐10_紐下_金具上_穴CD;

		public ColorD ブ\u30FCツ_紐_紐10_紐下_紐CD;

		public ColorD ブ\u30FCツ_紐_紐10_紐上_金具上_金具CD;

		public ColorD ブ\u30FCツ_紐_紐10_紐上_金具上_穴CD;

		public ColorD ブ\u30FCツ_紐_紐10_紐上_紐CD;

		public ColorD ブ\u30FCツ_紐_紐11_紐下_金具上_金具CD;

		public ColorD ブ\u30FCツ_紐_紐11_紐下_金具上_穴CD;

		public ColorD ブ\u30FCツ_紐_紐11_紐下_紐CD;

		public ColorD ブ\u30FCツ_紐_紐11_紐上_金具上_金具CD;

		public ColorD ブ\u30FCツ_紐_紐11_紐上_金具上_穴CD;

		public ColorD ブ\u30FCツ_紐_紐11_紐上_紐CD;

		public ColorD ブ\u30FCツ_紐_結び_紐左_紐3CD;

		public ColorD ブ\u30FCツ_紐_結び_紐左_紐2CD;

		public ColorD ブ\u30FCツ_紐_結び_紐左_紐1CD;

		public ColorD ブ\u30FCツ_紐_結び_紐右_紐3CD;

		public ColorD ブ\u30FCツ_紐_結び_紐右_紐2CD;

		public ColorD ブ\u30FCツ_紐_結び_紐右_紐1CD;

		public ColorD ブ\u30FCツ_紐_結び_結び目CD;

		public ColorD ア\u30FCマ_ベ\u30FCスCD;

		public ColorD ア\u30FCマ_脛当_脛当1CD;

		public ColorD ア\u30FCマ_脛当_脛当2CD;

		public ColorD ア\u30FCマ_膝当CD;

		public ColorD ア\u30FCマ_穴_穴1CD;

		public ColorD ア\u30FCマ_穴_穴2CD;

		public ColorD ア\u30FCマ_穴_穴3CD;

		public ColorD ア\u30FCマ_穴_穴4CD;

		public ColorD 脚輪上_革CD;

		public ColorD 脚輪上_金具1CD;

		public ColorD 脚輪上_金具2CD;

		public ColorD 脚輪上_金具3CD;

		public ColorD 脚輪上_金具左CD;

		public ColorD 脚輪上_金具右CD;

		public ColorD 脚輪下_革CD;

		public ColorD 脚輪下_金具1CD;

		public ColorD 脚輪下_金具2CD;

		public ColorD 脚輪下_金具3CD;

		public ColorD 脚輪下_金具左CD;

		public ColorD 脚輪下_金具右CD;

		public ColorP X0Y0_脚CP;

		public ColorP X0Y0_筋CP;

		public ColorP X0Y0_淫タトゥ_足首_タトゥCP;

		public ColorP X0Y0_淫タトゥ_足首_ハ\u30FCト1_タトゥ左CP;

		public ColorP X0Y0_淫タトゥ_足首_ハ\u30FCト1_タトゥ右CP;

		public ColorP X0Y0_淫タトゥ_足首_ハ\u30FCト3_タトゥ左CP;

		public ColorP X0Y0_淫タトゥ_足首_ハ\u30FCト3_タトゥ右CP;

		public ColorP X0Y0_淫タトゥ_足首_ハ\u30FCト2_タトゥ左CP;

		public ColorP X0Y0_淫タトゥ_足首_ハ\u30FCト2_タトゥ右CP;

		public ColorP X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左CP;

		public ColorP X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右CP;

		public ColorP X0Y0_淫タトゥ_タトゥ左CP;

		public ColorP X0Y0_淫タトゥ_タトゥ右CP;

		public ColorP X0Y0_悪タトゥ_文字1_文字a_枠CP;

		public ColorP X0Y0_悪タトゥ_文字1_文字a_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_文字1_文字a_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_文字1_文字b_枠CP;

		public ColorP X0Y0_悪タトゥ_文字1_文字b_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_文字1_文字b_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_文字1_文字c_枠CP;

		public ColorP X0Y0_悪タトゥ_文字1_文字c_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_文字1_文字c_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_文字1_文字d_枠CP;

		public ColorP X0Y0_悪タトゥ_文字1_文字d_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_文字1_文字d_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_文字1_文字e_枠CP;

		public ColorP X0Y0_悪タトゥ_文字1_文字e_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_文字1_文字e_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_文字1_文字e_文字タトゥ3CP;

		public ColorP X0Y0_悪タトゥ_文字2_文字a_枠CP;

		public ColorP X0Y0_悪タトゥ_文字2_文字a_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_文字2_文字a_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_文字2_文字b_枠CP;

		public ColorP X0Y0_悪タトゥ_文字2_文字b_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_文字2_文字b_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_文字2_文字c_枠CP;

		public ColorP X0Y0_悪タトゥ_文字2_文字c_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_文字2_文字c_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_文字2_文字d_枠CP;

		public ColorP X0Y0_悪タトゥ_文字2_文字d_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_文字2_文字d_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_文字2_文字e_枠CP;

		public ColorP X0Y0_悪タトゥ_文字2_文字e_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_文字2_文字e_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_文字2_文字e_文字タトゥ3CP;

		public ColorP X0Y0_悪タトゥ_タトゥ1CP;

		public ColorP X0Y0_悪タトゥ_タトゥ2CP;

		public ColorP X0Y0_悪タトゥ_逆十字_逆十字1CP;

		public ColorP X0Y0_悪タトゥ_逆十字_逆十字2CP;

		public ColorP X0Y0_悪タトゥ_タトゥ左CP;

		public ColorP X0Y0_悪タトゥ_タトゥ右CP;

		public ColorP X0Y0_紋柄_紋1CP;

		public ColorP X0Y0_紋柄_紋2CP;

		public ColorP X0Y0_紋柄_紋3CP;

		public ColorP X0Y0_紋柄_紋4CP;

		public ColorP X0Y0_獣性_獣毛1CP;

		public ColorP X0Y0_獣性_獣毛2CP;

		public ColorP X0Y0_獣性_獣毛3CP;

		public ColorP X0Y0_獣性_獣毛4CP;

		public ColorP X0Y0_獣性_獣毛5CP;

		public ColorP X0Y0_竜性_鱗_鱗1CP;

		public ColorP X0Y0_竜性_鱗_鱗2CP;

		public ColorP X0Y0_竜性_鱗_鱗3CP;

		public ColorP X0Y0_竜性_鱗_鱗4CP;

		public ColorP X0Y0_竜性_鱗_鱗5CP;

		public ColorP X0Y0_竜性_鱗_鱗6CP;

		public ColorP X0Y0_竜性_鱗_鱗7CP;

		public ColorP X0Y0_竜性_棘_棘1CP;

		public ColorP X0Y0_竜性_棘_棘2CP;

		public ColorP X0Y0_竜性_棘_棘3CP;

		public ColorP X0Y0_竜性_棘_棘4CP;

		public ColorP X0Y0_竜性_棘_棘5CP;

		public ColorP X0Y0_竜性_棘_棘6CP;

		public ColorP X0Y0_虫性_棘_棘1CP;

		public ColorP X0Y0_虫性_棘_棘2CP;

		public ColorP X0Y0_虫性_棘_棘3CP;

		public ColorP X0Y0_虫性_膝CP;

		public ColorP X0Y0_虫性_線CP;

		public ColorP X0Y0_傷X1CP;

		public ColorP X0Y0_傷X2CP;

		public ColorP X0Y0_傷I1CP;

		public ColorP X0Y0_傷I2CP;

		public ColorP X0Y0_傷I3CP;

		public ColorP X0Y0_傷I4CP;

		public ColorP X0Y0_傷I5CP;

		public ColorP X0Y0_ハイライト1CP;

		public ColorP X0Y0_ハイライト2CP;

		public ColorP X0Y0_パンスト_パンストCP;

		public ColorP X0Y0_パンスト_ハイライト1CP;

		public ColorP X0Y0_パンスト_ハイライト2CP;

		public ColorP X0Y0_ソックス_ソックスCP;

		public ColorP X0Y0_ソックス_ハイライト1CP;

		public ColorP X0Y0_ソックス_ハイライト2CP;

		public ColorP X0Y0_ブ\u30FCツ_タン_タンCP;

		public ColorP X0Y0_ブ\u30FCツ_タン_縁_縁1CP;

		public ColorP X0Y0_ブ\u30FCツ_タン_縁_縁2CP;

		public ColorP X0Y0_ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCP;

		public ColorP X0Y0_ブ\u30FCツ_ブ\u30FCツ_皺_皺1CP;

		public ColorP X0Y0_ブ\u30FCツ_ブ\u30FCツ_皺_皺2CP;

		public ColorP X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁1CP;

		public ColorP X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁2CP;

		public ColorP X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁3CP;

		public ColorP X0Y0_ブ\u30FCツ_ブ\u30FCツ_縁_縁4CP;

		public ColorP X0Y0_ブ\u30FCツ_柄CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐1_紐下_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐1_紐下_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐1_紐下_紐CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐1_紐上_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐1_紐上_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐1_紐上_紐CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐2_紐下_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐2_紐下_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐2_紐下_紐CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐2_紐上_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐2_紐上_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐2_紐上_紐CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐3_紐下_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐3_紐下_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐3_紐下_紐CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐3_紐上_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐3_紐上_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐3_紐上_紐CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐4_紐下_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐4_紐下_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐4_紐下_紐CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐4_紐上_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐4_紐上_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐4_紐上_紐CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐5_紐下_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐5_紐下_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐5_紐下_紐CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐5_紐上_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐5_紐上_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐5_紐上_紐CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐6_紐下_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐6_紐下_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐6_紐下_紐CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐6_紐上_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐6_紐上_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐6_紐上_紐CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐7_紐下_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐7_紐下_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐7_紐下_紐CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐7_紐上_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐7_紐上_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐7_紐上_紐CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐8_紐下_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐8_紐下_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐8_紐下_紐CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐8_紐上_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐8_紐上_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐8_紐上_紐CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐9_紐下_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐9_紐下_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐9_紐下_紐CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐9_紐上_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐9_紐上_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐9_紐上_紐CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐10_紐下_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐10_紐下_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐10_紐下_紐CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐10_紐上_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐10_紐上_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐10_紐上_紐CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐11_紐下_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐11_紐下_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐11_紐下_紐CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐11_紐上_金具上_金具CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐11_紐上_金具上_穴CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_紐11_紐上_紐CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_結び_紐左_紐3CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_結び_紐左_紐2CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_結び_紐左_紐1CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_結び_紐右_紐3CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_結び_紐右_紐2CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_結び_紐右_紐1CP;

		public ColorP X0Y0_ブ\u30FCツ_紐_結び_結び目CP;

		public ColorP X0Y0_ア\u30FCマ_ベ\u30FCスCP;

		public ColorP X0Y0_ア\u30FCマ_脛当_脛当1CP;

		public ColorP X0Y0_ア\u30FCマ_脛当_脛当2CP;

		public ColorP X0Y0_ア\u30FCマ_膝当CP;

		public ColorP X0Y0_ア\u30FCマ_穴_穴1CP;

		public ColorP X0Y0_ア\u30FCマ_穴_穴2CP;

		public ColorP X0Y0_ア\u30FCマ_穴_穴3CP;

		public ColorP X0Y0_ア\u30FCマ_穴_穴4CP;

		public ColorP X0Y0_脚輪上_革CP;

		public ColorP X0Y0_脚輪上_金具1CP;

		public ColorP X0Y0_脚輪上_金具2CP;

		public ColorP X0Y0_脚輪上_金具3CP;

		public ColorP X0Y0_脚輪上_金具左CP;

		public ColorP X0Y0_脚輪上_金具右CP;

		public ColorP X0Y0_脚輪下_革CP;

		public ColorP X0Y0_脚輪下_金具1CP;

		public ColorP X0Y0_脚輪下_金具2CP;

		public ColorP X0Y0_脚輪下_金具3CP;

		public ColorP X0Y0_脚輪下_金具左CP;

		public ColorP X0Y0_脚輪下_金具右CP;

		public ColorP X0Y1_脚CP;

		public ColorP X0Y1_筋CP;

		public ColorP X0Y1_淫タトゥ_足首_タトゥCP;

		public ColorP X0Y1_淫タトゥ_足首_ハ\u30FCト1_タトゥ左CP;

		public ColorP X0Y1_淫タトゥ_足首_ハ\u30FCト1_タトゥ右CP;

		public ColorP X0Y1_淫タトゥ_足首_ハ\u30FCト3_タトゥ左CP;

		public ColorP X0Y1_淫タトゥ_足首_ハ\u30FCト3_タトゥ右CP;

		public ColorP X0Y1_淫タトゥ_足首_ハ\u30FCト2_タトゥ左CP;

		public ColorP X0Y1_淫タトゥ_足首_ハ\u30FCト2_タトゥ右CP;

		public ColorP X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左CP;

		public ColorP X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右CP;

		public ColorP X0Y1_淫タトゥ_タトゥ左CP;

		public ColorP X0Y1_淫タトゥ_タトゥ右CP;

		public ColorP X0Y1_悪タトゥ_文字1_文字a_枠CP;

		public ColorP X0Y1_悪タトゥ_文字1_文字a_文字タトゥ1CP;

		public ColorP X0Y1_悪タトゥ_文字1_文字a_文字タトゥ2CP;

		public ColorP X0Y1_悪タトゥ_文字1_文字b_枠CP;

		public ColorP X0Y1_悪タトゥ_文字1_文字b_文字タトゥ1CP;

		public ColorP X0Y1_悪タトゥ_文字1_文字b_文字タトゥ2CP;

		public ColorP X0Y1_悪タトゥ_文字1_文字c_枠CP;

		public ColorP X0Y1_悪タトゥ_文字1_文字c_文字タトゥ1CP;

		public ColorP X0Y1_悪タトゥ_文字1_文字c_文字タトゥ2CP;

		public ColorP X0Y1_悪タトゥ_文字1_文字d_枠CP;

		public ColorP X0Y1_悪タトゥ_文字1_文字d_文字タトゥ1CP;

		public ColorP X0Y1_悪タトゥ_文字1_文字d_文字タトゥ2CP;

		public ColorP X0Y1_悪タトゥ_文字1_文字e_枠CP;

		public ColorP X0Y1_悪タトゥ_文字1_文字e_文字タトゥ1CP;

		public ColorP X0Y1_悪タトゥ_文字1_文字e_文字タトゥ2CP;

		public ColorP X0Y1_悪タトゥ_文字1_文字e_文字タトゥ3CP;

		public ColorP X0Y1_悪タトゥ_文字2_文字a_枠CP;

		public ColorP X0Y1_悪タトゥ_文字2_文字a_文字タトゥ1CP;

		public ColorP X0Y1_悪タトゥ_文字2_文字a_文字タトゥ2CP;

		public ColorP X0Y1_悪タトゥ_文字2_文字b_枠CP;

		public ColorP X0Y1_悪タトゥ_文字2_文字b_文字タトゥ1CP;

		public ColorP X0Y1_悪タトゥ_文字2_文字b_文字タトゥ2CP;

		public ColorP X0Y1_悪タトゥ_文字2_文字c_枠CP;

		public ColorP X0Y1_悪タトゥ_文字2_文字c_文字タトゥ1CP;

		public ColorP X0Y1_悪タトゥ_文字2_文字c_文字タトゥ2CP;

		public ColorP X0Y1_悪タトゥ_文字2_文字d_枠CP;

		public ColorP X0Y1_悪タトゥ_文字2_文字d_文字タトゥ1CP;

		public ColorP X0Y1_悪タトゥ_文字2_文字d_文字タトゥ2CP;

		public ColorP X0Y1_悪タトゥ_文字2_文字e_枠CP;

		public ColorP X0Y1_悪タトゥ_文字2_文字e_文字タトゥ1CP;

		public ColorP X0Y1_悪タトゥ_文字2_文字e_文字タトゥ2CP;

		public ColorP X0Y1_悪タトゥ_文字2_文字e_文字タトゥ3CP;

		public ColorP X0Y1_悪タトゥ_タトゥ1CP;

		public ColorP X0Y1_悪タトゥ_タトゥ2CP;

		public ColorP X0Y1_悪タトゥ_逆十字_逆十字1CP;

		public ColorP X0Y1_悪タトゥ_逆十字_逆十字2CP;

		public ColorP X0Y1_悪タトゥ_タトゥ左CP;

		public ColorP X0Y1_悪タトゥ_タトゥ右CP;

		public ColorP X0Y1_紋柄_紋1CP;

		public ColorP X0Y1_紋柄_紋2CP;

		public ColorP X0Y1_紋柄_紋3CP;

		public ColorP X0Y1_紋柄_紋4CP;

		public ColorP X0Y1_獣性_獣毛1CP;

		public ColorP X0Y1_獣性_獣毛2CP;

		public ColorP X0Y1_獣性_獣毛3CP;

		public ColorP X0Y1_獣性_獣毛4CP;

		public ColorP X0Y1_獣性_獣毛5CP;

		public ColorP X0Y1_竜性_鱗_鱗1CP;

		public ColorP X0Y1_竜性_鱗_鱗2CP;

		public ColorP X0Y1_竜性_鱗_鱗3CP;

		public ColorP X0Y1_竜性_鱗_鱗4CP;

		public ColorP X0Y1_竜性_鱗_鱗5CP;

		public ColorP X0Y1_竜性_鱗_鱗6CP;

		public ColorP X0Y1_竜性_鱗_鱗7CP;

		public ColorP X0Y1_竜性_棘_棘1CP;

		public ColorP X0Y1_竜性_棘_棘2CP;

		public ColorP X0Y1_竜性_棘_棘3CP;

		public ColorP X0Y1_竜性_棘_棘4CP;

		public ColorP X0Y1_竜性_棘_棘5CP;

		public ColorP X0Y1_竜性_棘_棘6CP;

		public ColorP X0Y1_虫性_棘_棘1CP;

		public ColorP X0Y1_虫性_棘_棘2CP;

		public ColorP X0Y1_虫性_棘_棘3CP;

		public ColorP X0Y1_虫性_膝CP;

		public ColorP X0Y1_虫性_線CP;

		public ColorP X0Y1_傷X1CP;

		public ColorP X0Y1_傷X2CP;

		public ColorP X0Y1_傷I1CP;

		public ColorP X0Y1_傷I2CP;

		public ColorP X0Y1_傷I3CP;

		public ColorP X0Y1_傷I4CP;

		public ColorP X0Y1_傷I5CP;

		public ColorP X0Y1_ハイライト1CP;

		public ColorP X0Y1_ハイライト2CP;

		public ColorP X0Y1_パンスト_パンストCP;

		public ColorP X0Y1_パンスト_ハイライト1CP;

		public ColorP X0Y1_パンスト_ハイライト2CP;

		public ColorP X0Y1_ソックス_ソックスCP;

		public ColorP X0Y1_ソックス_ハイライト1CP;

		public ColorP X0Y1_ソックス_ハイライト2CP;

		public ColorP X0Y1_ブ\u30FCツ_タン_タンCP;

		public ColorP X0Y1_ブ\u30FCツ_タン_縁_縁1CP;

		public ColorP X0Y1_ブ\u30FCツ_タン_縁_縁2CP;

		public ColorP X0Y1_ブ\u30FCツ_ブ\u30FCツ_ブ\u30FCツCP;

		public ColorP X0Y1_ブ\u30FCツ_ブ\u30FCツ_皺_皺1CP;

		public ColorP X0Y1_ブ\u30FCツ_ブ\u30FCツ_皺_皺2CP;

		public ColorP X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁1CP;

		public ColorP X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁2CP;

		public ColorP X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁3CP;

		public ColorP X0Y1_ブ\u30FCツ_ブ\u30FCツ_縁_縁4CP;

		public ColorP X0Y1_ブ\u30FCツ_柄CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐1_紐下_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐1_紐下_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐1_紐下_紐CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐1_紐上_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐1_紐上_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐1_紐上_紐CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐2_紐下_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐2_紐下_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐2_紐下_紐CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐2_紐上_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐2_紐上_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐2_紐上_紐CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐3_紐下_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐3_紐下_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐3_紐下_紐CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐3_紐上_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐3_紐上_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐3_紐上_紐CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐4_紐下_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐4_紐下_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐4_紐下_紐CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐4_紐上_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐4_紐上_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐4_紐上_紐CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐5_紐下_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐5_紐下_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐5_紐下_紐CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐5_紐上_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐5_紐上_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐5_紐上_紐CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐6_紐下_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐6_紐下_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐6_紐下_紐CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐6_紐上_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐6_紐上_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐6_紐上_紐CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐7_紐下_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐7_紐下_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐7_紐下_紐CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐7_紐上_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐7_紐上_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐7_紐上_紐CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐8_紐下_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐8_紐下_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐8_紐下_紐CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐8_紐上_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐8_紐上_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐8_紐上_紐CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐9_紐下_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐9_紐下_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐9_紐下_紐CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐9_紐上_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐9_紐上_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐9_紐上_紐CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐10_紐下_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐10_紐下_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐10_紐下_紐CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐10_紐上_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐10_紐上_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐10_紐上_紐CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐11_紐下_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐11_紐下_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐11_紐下_紐CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐11_紐上_金具上_金具CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐11_紐上_金具上_穴CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_紐11_紐上_紐CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_結び_紐左_紐3CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_結び_紐左_紐2CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_結び_紐左_紐1CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_結び_紐右_紐3CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_結び_紐右_紐2CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_結び_紐右_紐1CP;

		public ColorP X0Y1_ブ\u30FCツ_紐_結び_結び目CP;

		public ColorP X0Y1_ア\u30FCマ_ベ\u30FCスCP;

		public ColorP X0Y1_ア\u30FCマ_脛当_脛当1CP;

		public ColorP X0Y1_ア\u30FCマ_脛当_脛当2CP;

		public ColorP X0Y1_ア\u30FCマ_膝当CP;

		public ColorP X0Y1_ア\u30FCマ_穴_穴1CP;

		public ColorP X0Y1_ア\u30FCマ_穴_穴2CP;

		public ColorP X0Y1_ア\u30FCマ_穴_穴3CP;

		public ColorP X0Y1_ア\u30FCマ_穴_穴4CP;

		public ColorP X0Y1_脚輪上_革CP;

		public ColorP X0Y1_脚輪上_金具1CP;

		public ColorP X0Y1_脚輪上_金具2CP;

		public ColorP X0Y1_脚輪上_金具3CP;

		public ColorP X0Y1_脚輪上_金具左CP;

		public ColorP X0Y1_脚輪上_金具右CP;

		public ColorP X0Y1_脚輪下_革CP;

		public ColorP X0Y1_脚輪下_金具1CP;

		public ColorP X0Y1_脚輪下_金具2CP;

		public ColorP X0Y1_脚輪下_金具3CP;

		public ColorP X0Y1_脚輪下_金具左CP;

		public ColorP X0Y1_脚輪下_金具右CP;

		public 拘束鎖 鎖1;

		public 拘束鎖 鎖3;

		public スタンプK キスマ\u30FCク;

		public スタンプW 鞭痕;

		public Ele[] 脚輪下_接続;

		public Ele[] 脚輪上_接続;
	}
}
