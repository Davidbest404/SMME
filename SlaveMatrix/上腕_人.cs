using System;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 上腕_人 : 上腕
	{
		public 上腕_人(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 上腕_人D e)
		{
			上腕_人.<>c__DisplayClass301_0 CS$<>8__locals1 = new 上腕_人.<>c__DisplayClass301_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.腕左["上腕"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_筋肉上 = pars["筋肉上"].ToPar();
			this.X0Y0_上腕 = pars["上腕"].ToPar();
			this.X0Y0_筋肉下 = pars["筋肉下"].ToPar();
			Pars pars2 = pars["虫性"].ToPars();
			this.X0Y0_虫性_虫腕 = pars2["虫腕"].ToPar();
			this.X0Y0_虫性_筋肉下 = pars2["筋肉下"].ToPar();
			pars2 = pars["紋柄"].ToPars();
			this.X0Y0_紋柄_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_紋柄_紋2 = pars2["紋2"].ToPar();
			this.X0Y0_紋柄_紋3 = pars2["紋3"].ToPar();
			this.X0Y0_紋柄_紋4 = pars2["紋4"].ToPar();
			pars2 = pars["獣性"].ToPars();
			this.X0Y0_獣性_獣毛1 = pars2["獣毛1"].ToPar();
			this.X0Y0_獣性_獣毛2 = pars2["獣毛2"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y0_竜性_鱗4 = pars2["鱗4"].ToPar();
			this.X0Y0_竜性_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y0_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y0_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y0_竜性_鱗5 = pars2["鱗5"].ToPar();
			pars2 = pars["淫タトゥ"].ToPars();
			Pars pars3 = pars2["ハート"].ToPars();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左 = pars3["タトゥ左"].ToPar();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右 = pars3["タトゥ右"].ToPar();
			this.X0Y0_淫タトゥ_タトゥ1 = pars2["タトゥ1"].ToPar();
			this.X0Y0_淫タトゥ_タトゥ2 = pars2["タトゥ2"].ToPar();
			this.X0Y0_淫タトゥ_タトゥ3 = pars2["タトゥ3"].ToPar();
			this.X0Y0_淫タトゥ_タトゥ4 = pars2["タトゥ4"].ToPar();
			pars2 = pars["悪タトゥ"].ToPars();
			pars3 = pars2["通常"].ToPars();
			Pars pars4 = pars3["文字1"].ToPars();
			Pars pars5 = pars4["文字a"].ToPars();
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
			Pars pars6 = pars3["文字2"].ToPars();
			pars5 = pars6["文字a"].ToPars();
			this.X0Y0_悪タトゥ_通常_文字2_文字a_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字2_文字a_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars6["文字b"].ToPars();
			this.X0Y0_悪タトゥ_通常_文字2_文字b_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字2_文字b_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars6["文字c"].ToPars();
			this.X0Y0_悪タトゥ_通常_文字2_文字c_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字2_文字c_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars6["文字d"].ToPars();
			this.X0Y0_悪タトゥ_通常_文字2_文字d_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字2_文字d_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars6["文字e"].ToPars();
			this.X0Y0_悪タトゥ_通常_文字2_文字e_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			this.X0Y0_悪タトゥ_通常_文字2_文字e_文字タトゥ3 = pars5["文字タトゥ3"].ToPar();
			this.X0Y0_悪タトゥ_通常_タトゥ1 = pars3["タトゥ1"].ToPar();
			pars3 = pars2["筋肉"].ToPars();
			Pars pars7 = pars3["文字1"].ToPars();
			pars5 = pars7["文字a"].ToPars();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字a_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字a_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars7["文字b"].ToPars();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字b_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字b_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars7["文字c"].ToPars();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字c_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字c_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars7["文字d"].ToPars();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字d_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字d_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars7["文字e"].ToPars();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字e_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字1_文字e_文字タトゥ3 = pars5["文字タトゥ3"].ToPar();
			Pars pars8 = pars3["文字2"].ToPars();
			pars5 = pars8["文字a"].ToPars();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字a_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字a_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars8["文字b"].ToPars();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字b_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字b_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars8["文字c"].ToPars();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字c_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字c_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars8["文字d"].ToPars();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字d_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字d_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			pars5 = pars8["文字e"].ToPars();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字e_枠 = pars5["枠"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ1 = pars5["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ2 = pars5["文字タトゥ2"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_文字2_文字e_文字タトゥ3 = pars5["文字タトゥ3"].ToPar();
			this.X0Y0_悪タトゥ_筋肉_タトゥ1 = pars3["タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ_タトゥ2 = pars2["タトゥ2"].ToPar();
			pars2 = pars["植タトゥ"].ToPars();
			this.X0Y0_植タトゥ_タトゥ = pars2["タトゥ"].ToPar();
			pars2 = pars["植性"].ToPars();
			pars3 = pars2["通常"].ToPars();
			this.X0Y0_植性_通常_葉3 = pars3["葉3"].ToPar();
			this.X0Y0_植性_通常_葉2 = pars3["葉2"].ToPar();
			this.X0Y0_植性_通常_葉1 = pars3["葉1"].ToPar();
			pars3 = pars2["欠損"].ToPars();
			this.X0Y0_植性_欠損_葉3 = pars3["葉3"].ToPar();
			this.X0Y0_植性_欠損_葉2 = pars3["葉2"].ToPar();
			this.X0Y0_植性_欠損_葉1 = pars3["葉1"].ToPar();
			this.X0Y0_傷X = pars["傷X"].ToPar();
			pars2 = pars["ハイライト"].ToPars();
			this.X0Y0_ハイライト_ハイライト1 = pars2["ハイライト1"].ToPar();
			this.X0Y0_ハイライト_ハイライト2 = pars2["ハイライト2"].ToPar();
			pars2 = pars["グローブ"].ToPars();
			pars3 = pars2["通常"].ToPars();
			this.X0Y0_グロ\u30FCブ_通常_グロ\u30FCブ = pars3["グローブ"].ToPar();
			this.X0Y0_グロ\u30FCブ_通常_縁 = pars3["縁"].ToPar();
			pars3 = pars2["筋肉"].ToPars();
			this.X0Y0_グロ\u30FCブ_筋肉_グロ\u30FCブ = pars3["グローブ"].ToPar();
			this.X0Y0_グロ\u30FCブ_筋肉_縁 = pars3["縁"].ToPar();
			pars2 = pars["シャツ"].ToPars();
			this.X0Y0_シャツ_袖1 = pars2["袖1"].ToPar();
			this.X0Y0_シャツ_袖2 = pars2["袖2"].ToPar();
			this.X0Y0_シャツ_縁 = pars2["縁"].ToPar();
			pars2 = pars["ナース"].ToPars();
			this.X0Y0_ナ\u30FCス_袖1 = pars2["袖1"].ToPar();
			this.X0Y0_ナ\u30FCス_袖2 = pars2["袖2"].ToPar();
			this.X0Y0_ナ\u30FCス_縁 = pars2["縁"].ToPar();
			pars2 = pars["鎧"].ToPars();
			pars3 = pars2["ベルト"].ToPars();
			this.X0Y0_鎧_ベルト_ベルト1 = pars3["ベルト1"].ToPar();
			this.X0Y0_鎧_ベルト_ベルト2 = pars3["ベルト2"].ToPar();
			pars3 = pars2["鎧"].ToPars();
			this.X0Y0_鎧_鎧_鎧1 = pars3["鎧1"].ToPar();
			this.X0Y0_鎧_鎧_鎧2 = pars3["鎧2"].ToPar();
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
			this.筋肉上_表示 = e.筋肉上_表示;
			this.上腕_表示 = e.上腕_表示;
			this.虫性_虫腕_表示 = e.虫性_虫腕_表示;
			this.虫性_筋肉下_表示 = e.虫性_筋肉下_表示;
			this.筋肉下_表示 = e.筋肉下_表示;
			this.紋柄_紋1_表示 = e.紋柄_紋1_表示;
			this.紋柄_紋2_表示 = e.紋柄_紋2_表示;
			this.紋柄_紋3_表示 = e.紋柄_紋3_表示;
			this.紋柄_紋4_表示 = e.紋柄_紋4_表示;
			this.獣性_獣毛1_表示 = e.獣性_獣毛1_表示;
			this.獣性_獣毛2_表示 = e.獣性_獣毛2_表示;
			this.竜性_鱗4_表示 = e.竜性_鱗4_表示;
			this.竜性_鱗3_表示 = e.竜性_鱗3_表示;
			this.竜性_鱗2_表示 = e.竜性_鱗2_表示;
			this.竜性_鱗1_表示 = e.竜性_鱗1_表示;
			this.竜性_鱗5_表示 = e.竜性_鱗5_表示;
			this.淫タトゥ_ハ\u30FCト_タトゥ左_表示 = e.淫タトゥ_ハ\u30FCト_タトゥ左_表示;
			this.淫タトゥ_ハ\u30FCト_タトゥ右_表示 = e.淫タトゥ_ハ\u30FCト_タトゥ右_表示;
			this.淫タトゥ_タトゥ1_表示 = e.淫タトゥ_タトゥ1_表示;
			this.淫タトゥ_タトゥ2_表示 = e.淫タトゥ_タトゥ2_表示;
			this.淫タトゥ_タトゥ3_表示 = e.淫タトゥ_タトゥ3_表示;
			this.淫タトゥ_タトゥ4_表示 = e.淫タトゥ_タトゥ4_表示;
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
			this.悪タトゥ_タトゥ2_表示 = e.悪タトゥ_タトゥ2_表示;
			this.植タトゥ_タトゥ_表示 = e.植タトゥ_タトゥ_表示;
			this.植性_通常_葉3_表示 = e.植性_通常_葉3_表示;
			this.植性_通常_葉2_表示 = e.植性_通常_葉2_表示;
			this.植性_通常_葉1_表示 = e.植性_通常_葉1_表示;
			this.植性_欠損_葉3_表示 = e.植性_欠損_葉3_表示;
			this.植性_欠損_葉2_表示 = e.植性_欠損_葉2_表示;
			this.植性_欠損_葉1_表示 = e.植性_欠損_葉1_表示;
			this.傷X_表示 = e.傷X_表示;
			this.ハイライト_ハイライト1_表示 = e.ハイライト_ハイライト1_表示;
			this.ハイライト_ハイライト2_表示 = e.ハイライト_ハイライト2_表示;
			this.グロ\u30FCブ_通常_グロ\u30FCブ_表示 = e.グロ\u30FCブ_通常_グロ\u30FCブ_表示;
			this.グロ\u30FCブ_通常_縁_表示 = e.グロ\u30FCブ_通常_縁_表示;
			this.グロ\u30FCブ_筋肉_グロ\u30FCブ_表示 = e.グロ\u30FCブ_筋肉_グロ\u30FCブ_表示;
			this.グロ\u30FCブ_筋肉_縁_表示 = e.グロ\u30FCブ_筋肉_縁_表示;
			this.シャツ_袖1_表示 = e.シャツ_袖1_表示;
			this.シャツ_袖2_表示 = e.シャツ_袖2_表示;
			this.シャツ_縁_表示 = e.シャツ_縁_表示;
			this.ナ\u30FCス_袖1_表示 = e.ナ\u30FCス_袖1_表示;
			this.ナ\u30FCス_袖2_表示 = e.ナ\u30FCス_袖2_表示;
			this.ナ\u30FCス_縁_表示 = e.ナ\u30FCス_縁_表示;
			this.鎧_ベルト_ベルト1_表示 = e.鎧_ベルト_ベルト1_表示;
			this.鎧_ベルト_ベルト2_表示 = e.鎧_ベルト_ベルト2_表示;
			this.鎧_鎧_鎧1_表示 = e.鎧_鎧_鎧1_表示;
			this.鎧_鎧_鎧2_表示 = e.鎧_鎧_鎧2_表示;
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
			this.植性_葉3_表示 = e.植性_葉3_表示;
			this.植性_葉2_表示 = e.植性_葉2_表示;
			this.植性_葉1_表示 = e.植性_葉1_表示;
			this.グロ\u30FCブ_グロ\u30FCブ_表示 = e.グロ\u30FCブ_グロ\u30FCブ_表示;
			this.グロ\u30FCブ_縁_表示 = e.グロ\u30FCブ_縁_表示;
			this.ハイライト表示 = e.ハイライト表示;
			this.肘部_外線 = e.肘部_外線;
			this.グロ\u30FCブ表示 = e.グロ\u30FCブ表示;
			this.シャツ表示 = e.シャツ表示;
			this.ナ\u30FCス表示 = e.ナ\u30FCス表示;
			this.メイル表示 = e.メイル表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.下腕_接続.Count > 0)
			{
				Ele f;
				this.下腕_接続 = e.下腕_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.上腕_人_下腕_接続;
					f.接続(CS$<>8__locals1.<>4__this.下腕_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_筋肉上CP = new ColorP(this.X0Y0_筋肉上, this.筋肉上CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_上腕CP = new ColorP(this.X0Y0_上腕, this.上腕CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_筋肉下CP = new ColorP(this.X0Y0_筋肉下, this.筋肉下CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_虫性_虫腕CP = new ColorP(this.X0Y0_虫性_虫腕, this.虫性_虫腕CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_筋肉下CP = new ColorP(this.X0Y0_虫性_筋肉下, this.虫性_筋肉下CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋1CP = new ColorP(this.X0Y0_紋柄_紋1, this.紋柄_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋2CP = new ColorP(this.X0Y0_紋柄_紋2, this.紋柄_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋3CP = new ColorP(this.X0Y0_紋柄_紋3, this.紋柄_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋4CP = new ColorP(this.X0Y0_紋柄_紋4, this.紋柄_紋4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_獣性_獣毛1CP = new ColorP(this.X0Y0_獣性_獣毛1, this.獣性_獣毛1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_獣性_獣毛2CP = new ColorP(this.X0Y0_獣性_獣毛2, this.獣性_獣毛2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_鱗_鱗4CP = new ColorP(this.X0Y0_竜性_鱗4, this.竜性_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_鱗_鱗3CP = new ColorP(this.X0Y0_竜性_鱗3, this.竜性_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_鱗_鱗2CP = new ColorP(this.X0Y0_竜性_鱗2, this.竜性_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_鱗_鱗1CP = new ColorP(this.X0Y0_竜性_鱗1, this.竜性_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_鱗_鱗5CP = new ColorP(this.X0Y0_竜性_鱗5, this.竜性_鱗5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左CP = new ColorP(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左, this.淫タトゥ_ハ\u30FCト_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右CP = new ColorP(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右, this.淫タトゥ_ハ\u30FCト_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ1CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ1, this.淫タトゥ_タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ2CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ2, this.淫タトゥ_タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ3CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ3, this.淫タトゥ_タトゥ3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ4CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ4, this.淫タトゥ_タトゥ4CD, CS$<>8__locals1.DisUnit, true);
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
			this.X0Y0_悪タトゥ_タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ_タトゥ2, this.悪タトゥ_タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植タトゥ_タトゥCP = new ColorP(this.X0Y0_植タトゥ_タトゥ, this.植タトゥ_タトゥCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性_通常_葉3CP = new ColorP(this.X0Y0_植性_通常_葉3, this.植性_葉3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性_通常_葉2CP = new ColorP(this.X0Y0_植性_通常_葉2, this.植性_葉2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性_通常_葉1CP = new ColorP(this.X0Y0_植性_通常_葉1, this.植性_葉1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性_欠損_葉3CP = new ColorP(this.X0Y0_植性_欠損_葉3, this.植性_葉3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性_欠損_葉2CP = new ColorP(this.X0Y0_植性_欠損_葉2, this.植性_葉2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性_欠損_葉1CP = new ColorP(this.X0Y0_植性_欠損_葉1, this.植性_葉1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷XCP = new ColorP(this.X0Y0_傷X, this.傷XCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ハイライト_ハイライト1CP = new ColorP(this.X0Y0_ハイライト_ハイライト1, this.ハイライト_ハイライト1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ハイライト_ハイライト2CP = new ColorP(this.X0Y0_ハイライト_ハイライト2, this.ハイライト_ハイライト2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_グロ\u30FCブ_通常_グロ\u30FCブCP = new ColorP(this.X0Y0_グロ\u30FCブ_通常_グロ\u30FCブ, this.グロ\u30FCブ_グロ\u30FCブCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_グロ\u30FCブ_通常_縁CP = new ColorP(this.X0Y0_グロ\u30FCブ_通常_縁, this.グロ\u30FCブ_縁CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_グロ\u30FCブ_筋肉_グロ\u30FCブCP = new ColorP(this.X0Y0_グロ\u30FCブ_筋肉_グロ\u30FCブ, this.グロ\u30FCブ_グロ\u30FCブCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_グロ\u30FCブ_筋肉_縁CP = new ColorP(this.X0Y0_グロ\u30FCブ_筋肉_縁, this.グロ\u30FCブ_縁CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_シャツ_袖1CP = new ColorP(this.X0Y0_シャツ_袖1, this.シャツ_袖1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_シャツ_袖2CP = new ColorP(this.X0Y0_シャツ_袖2, this.シャツ_袖2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_シャツ_縁CP = new ColorP(this.X0Y0_シャツ_縁, this.シャツ_縁CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ナ\u30FCス_袖1CP = new ColorP(this.X0Y0_ナ\u30FCス_袖1, this.ナ\u30FCス_袖1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ナ\u30FCス_袖2CP = new ColorP(this.X0Y0_ナ\u30FCス_袖2, this.ナ\u30FCス_袖2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ナ\u30FCス_縁CP = new ColorP(this.X0Y0_ナ\u30FCス_縁, this.ナ\u30FCス_縁CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_鎧_ベルト_ベルト1CP = new ColorP(this.X0Y0_鎧_ベルト_ベルト1, this.鎧_ベルト_ベルト1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_鎧_ベルト_ベルト2CP = new ColorP(this.X0Y0_鎧_ベルト_ベルト2, this.鎧_ベルト_ベルト2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_鎧_鎧_鎧1CP = new ColorP(this.X0Y0_鎧_鎧_鎧1, this.鎧_鎧_鎧1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_鎧_鎧_鎧2CP = new ColorP(this.X0Y0_鎧_鎧_鎧2, this.鎧_鎧_鎧2CD, CS$<>8__locals1.DisUnit, true);
			this.傷X濃度 = e.傷X濃度;
			this.ハイライト濃度 = e.ハイライト濃度;
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
				this.植性_葉3_表示 = this.植性_葉3_表示;
				this.植性_葉2_表示 = this.植性_葉2_表示;
				this.植性_葉1_表示 = this.植性_葉1_表示;
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
				this.筋肉上_表示 = this.筋肉_;
				this.筋肉下_表示 = this.筋肉_;
				this.虫性_筋肉下_表示 = (this.虫性_虫腕_表示 && this.筋肉_);
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
				this.グロ\u30FCブ_グロ\u30FCブ_表示 = this.グロ\u30FCブ_グロ\u30FCブ_表示;
				this.グロ\u30FCブ_縁_表示 = this.グロ\u30FCブ_縁_表示;
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

		public bool 筋肉上_表示
		{
			get
			{
				return this.X0Y0_筋肉上.Dra;
			}
			set
			{
				this.X0Y0_筋肉上.Dra = value;
				this.X0Y0_筋肉上.Hit = value;
			}
		}

		public bool 上腕_表示
		{
			get
			{
				return this.X0Y0_上腕.Dra;
			}
			set
			{
				this.X0Y0_上腕.Dra = value;
				this.X0Y0_上腕.Hit = value;
			}
		}

		public bool 虫性_虫腕_表示
		{
			get
			{
				return this.X0Y0_虫性_虫腕.Dra;
			}
			set
			{
				this.X0Y0_虫性_虫腕.Dra = value;
				this.X0Y0_虫性_筋肉下.Dra = (this.筋肉フラグ && value);
				this.X0Y0_虫性_虫腕.Hit = value;
				this.X0Y0_虫性_筋肉下.Hit = (this.筋肉フラグ && value);
			}
		}

		public bool 虫性_筋肉下_表示
		{
			get
			{
				return this.X0Y0_虫性_筋肉下.Dra;
			}
			set
			{
				this.X0Y0_虫性_筋肉下.Dra = value;
				this.X0Y0_虫性_筋肉下.Hit = value;
			}
		}

		public bool 筋肉下_表示
		{
			get
			{
				return this.X0Y0_筋肉下.Dra;
			}
			set
			{
				this.X0Y0_筋肉下.Dra = value;
				this.X0Y0_筋肉下.Hit = value;
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
				this.X0Y0_紋柄_紋1.Hit = value;
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
				this.X0Y0_紋柄_紋2.Hit = value;
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
				this.X0Y0_紋柄_紋3.Hit = value;
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
				this.X0Y0_紋柄_紋4.Hit = value;
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
				this.X0Y0_獣性_獣毛1.Hit = value;
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
				this.X0Y0_獣性_獣毛2.Hit = value;
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

		public bool 淫タトゥ_タトゥ1_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_タトゥ1.Dra = value;
				this.X0Y0_淫タトゥ_タトゥ1.Hit = value;
			}
		}

		public bool 淫タトゥ_タトゥ2_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_タトゥ2.Dra = value;
				this.X0Y0_淫タトゥ_タトゥ2.Hit = value;
			}
		}

		public bool 淫タトゥ_タトゥ3_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_タトゥ3.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_タトゥ3.Dra = value;
				this.X0Y0_淫タトゥ_タトゥ3.Hit = value;
			}
		}

		public bool 淫タトゥ_タトゥ4_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_タトゥ4.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_タトゥ4.Dra = value;
				this.X0Y0_淫タトゥ_タトゥ4.Hit = value;
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

		public bool 悪タトゥ_タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ_タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ_タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ_タトゥ2.Hit = value;
			}
		}

		public bool 植タトゥ_タトゥ_表示
		{
			get
			{
				return this.X0Y0_植タトゥ_タトゥ.Dra;
			}
			set
			{
				this.X0Y0_植タトゥ_タトゥ.Dra = value;
				this.X0Y0_植タトゥ_タトゥ.Hit = value;
			}
		}

		public bool 植性_通常_葉3_表示
		{
			get
			{
				return this.X0Y0_植性_通常_葉3.Dra;
			}
			set
			{
				this.X0Y0_植性_通常_葉3.Dra = value;
				this.X0Y0_植性_通常_葉3.Hit = value;
			}
		}

		public bool 植性_通常_葉2_表示
		{
			get
			{
				return this.X0Y0_植性_通常_葉2.Dra;
			}
			set
			{
				this.X0Y0_植性_通常_葉2.Dra = value;
				this.X0Y0_植性_通常_葉2.Hit = value;
			}
		}

		public bool 植性_通常_葉1_表示
		{
			get
			{
				return this.X0Y0_植性_通常_葉1.Dra;
			}
			set
			{
				this.X0Y0_植性_通常_葉1.Dra = value;
				this.X0Y0_植性_通常_葉1.Hit = value;
			}
		}

		public bool 植性_欠損_葉3_表示
		{
			get
			{
				return this.X0Y0_植性_欠損_葉3.Dra;
			}
			set
			{
				this.X0Y0_植性_欠損_葉3.Dra = value;
				this.X0Y0_植性_欠損_葉3.Hit = value;
			}
		}

		public bool 植性_欠損_葉2_表示
		{
			get
			{
				return this.X0Y0_植性_欠損_葉2.Dra;
			}
			set
			{
				this.X0Y0_植性_欠損_葉2.Dra = value;
				this.X0Y0_植性_欠損_葉2.Hit = value;
			}
		}

		public bool 植性_欠損_葉1_表示
		{
			get
			{
				return this.X0Y0_植性_欠損_葉1.Dra;
			}
			set
			{
				this.X0Y0_植性_欠損_葉1.Dra = value;
				this.X0Y0_植性_欠損_葉1.Hit = value;
			}
		}

		public bool 傷X_表示
		{
			get
			{
				return this.X0Y0_傷X.Dra;
			}
			set
			{
				this.X0Y0_傷X.Dra = value;
				this.X0Y0_傷X.Hit = value;
			}
		}

		public bool ハイライト_ハイライト1_表示
		{
			get
			{
				return this.X0Y0_ハイライト_ハイライト1.Dra;
			}
			set
			{
				this.X0Y0_ハイライト_ハイライト1.Dra = value;
				this.X0Y0_ハイライト_ハイライト1.Hit = value;
			}
		}

		public bool ハイライト_ハイライト2_表示
		{
			get
			{
				return this.X0Y0_ハイライト_ハイライト2.Dra;
			}
			set
			{
				this.X0Y0_ハイライト_ハイライト2.Dra = value;
				this.X0Y0_ハイライト_ハイライト2.Hit = value;
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

		public bool シャツ_袖1_表示
		{
			get
			{
				return this.X0Y0_シャツ_袖1.Dra;
			}
			set
			{
				this.X0Y0_シャツ_袖1.Dra = value;
				this.X0Y0_シャツ_袖1.Hit = value;
			}
		}

		public bool シャツ_袖2_表示
		{
			get
			{
				return this.X0Y0_シャツ_袖2.Dra;
			}
			set
			{
				this.X0Y0_シャツ_袖2.Dra = value;
				this.X0Y0_シャツ_袖2.Hit = value;
			}
		}

		public bool シャツ_縁_表示
		{
			get
			{
				return this.X0Y0_シャツ_縁.Dra;
			}
			set
			{
				this.X0Y0_シャツ_縁.Dra = value;
				this.X0Y0_シャツ_縁.Hit = value;
			}
		}

		public bool ナ\u30FCス_袖1_表示
		{
			get
			{
				return this.X0Y0_ナ\u30FCス_袖1.Dra;
			}
			set
			{
				this.X0Y0_ナ\u30FCス_袖1.Dra = value;
				this.X0Y0_ナ\u30FCス_袖1.Hit = value;
			}
		}

		public bool ナ\u30FCス_袖2_表示
		{
			get
			{
				return this.X0Y0_ナ\u30FCス_袖2.Dra;
			}
			set
			{
				this.X0Y0_ナ\u30FCス_袖2.Dra = value;
				this.X0Y0_ナ\u30FCス_袖2.Hit = value;
			}
		}

		public bool ナ\u30FCス_縁_表示
		{
			get
			{
				return this.X0Y0_ナ\u30FCス_縁.Dra;
			}
			set
			{
				this.X0Y0_ナ\u30FCス_縁.Dra = value;
				this.X0Y0_ナ\u30FCス_縁.Hit = value;
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

		public bool 鎧_ベルト_ベルト2_表示
		{
			get
			{
				return this.X0Y0_鎧_ベルト_ベルト2.Dra;
			}
			set
			{
				this.X0Y0_鎧_ベルト_ベルト2.Dra = value;
				this.X0Y0_鎧_ベルト_ベルト2.Hit = value;
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

		public bool 植性_葉3_表示
		{
			get
			{
				return this.植性_通常_葉3_表示 || this.植性_欠損_葉3_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.植性_通常_葉3_表示 = false;
					this.植性_欠損_葉3_表示 = value;
					return;
				}
				this.植性_通常_葉3_表示 = value;
				this.植性_欠損_葉3_表示 = false;
			}
		}

		public bool 植性_葉2_表示
		{
			get
			{
				return this.植性_通常_葉2_表示 || this.植性_欠損_葉2_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.植性_通常_葉2_表示 = false;
					this.植性_欠損_葉2_表示 = value;
					return;
				}
				this.植性_通常_葉2_表示 = value;
				this.植性_欠損_葉2_表示 = false;
			}
		}

		public bool 植性_葉1_表示
		{
			get
			{
				return this.植性_通常_葉1_表示 || this.植性_欠損_葉1_表示;
			}
			set
			{
				if (this.欠損_)
				{
					this.植性_通常_葉1_表示 = false;
					this.植性_欠損_葉1_表示 = value;
					return;
				}
				this.植性_通常_葉1_表示 = value;
				this.植性_欠損_葉1_表示 = false;
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

		private bool 筋肉フラグ
		{
			get
			{
				return this.筋肉_ || this.筋肉上_表示 || this.筋肉下_表示 || this.虫性_筋肉下_表示;
			}
		}

		public bool ハイライト表示
		{
			get
			{
				return this.ハイライト_ハイライト1_表示;
			}
			set
			{
				this.ハイライト_ハイライト1_表示 = value;
				this.ハイライト_ハイライト2_表示 = value;
			}
		}

		public double 傷X濃度
		{
			get
			{
				return this.傷XCD.不透明度;
			}
			set
			{
				this.傷XCD.不透明度 = value;
			}
		}

		public double ハイライト濃度
		{
			get
			{
				return this.ハイライト_ハイライト1CD.不透明度;
			}
			set
			{
				this.ハイライト_ハイライト1CD.不透明度 = value;
				this.ハイライト_ハイライト2CD.不透明度 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.筋肉上_表示;
			}
			set
			{
				this.筋肉上_表示 = value;
				this.上腕_表示 = value;
				this.虫性_虫腕_表示 = value;
				this.虫性_筋肉下_表示 = value;
				this.筋肉下_表示 = value;
				this.紋柄_紋1_表示 = value;
				this.紋柄_紋2_表示 = value;
				this.紋柄_紋3_表示 = value;
				this.紋柄_紋4_表示 = value;
				this.獣性_獣毛1_表示 = value;
				this.獣性_獣毛2_表示 = value;
				this.竜性_鱗4_表示 = value;
				this.竜性_鱗3_表示 = value;
				this.竜性_鱗2_表示 = value;
				this.竜性_鱗1_表示 = value;
				this.竜性_鱗5_表示 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ左_表示 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ右_表示 = value;
				this.淫タトゥ_タトゥ1_表示 = value;
				this.淫タトゥ_タトゥ2_表示 = value;
				this.淫タトゥ_タトゥ3_表示 = value;
				this.淫タトゥ_タトゥ4_表示 = value;
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
				this.悪タトゥ_タトゥ2_表示 = value;
				this.植タトゥ_タトゥ_表示 = value;
				this.植性_通常_葉3_表示 = value;
				this.植性_通常_葉2_表示 = value;
				this.植性_通常_葉1_表示 = value;
				this.植性_欠損_葉3_表示 = value;
				this.植性_欠損_葉2_表示 = value;
				this.植性_欠損_葉1_表示 = value;
				this.傷X_表示 = value;
				this.ハイライト_ハイライト1_表示 = value;
				this.ハイライト_ハイライト2_表示 = value;
				this.グロ\u30FCブ_通常_グロ\u30FCブ_表示 = value;
				this.グロ\u30FCブ_通常_縁_表示 = value;
				this.グロ\u30FCブ_筋肉_グロ\u30FCブ_表示 = value;
				this.グロ\u30FCブ_筋肉_縁_表示 = value;
				this.シャツ_袖1_表示 = value;
				this.シャツ_袖2_表示 = value;
				this.シャツ_縁_表示 = value;
				this.ナ\u30FCス_袖1_表示 = value;
				this.ナ\u30FCス_袖2_表示 = value;
				this.ナ\u30FCス_縁_表示 = value;
				this.鎧_ベルト_ベルト1_表示 = value;
				this.鎧_ベルト_ベルト2_表示 = value;
				this.鎧_鎧_鎧1_表示 = value;
				this.鎧_鎧_鎧2_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.筋肉上CD.不透明度;
			}
			set
			{
				this.筋肉上CD.不透明度 = value;
				this.上腕CD.不透明度 = value;
				this.虫性_虫腕CD.不透明度 = value;
				this.虫性_筋肉下CD.不透明度 = value;
				this.筋肉下CD.不透明度 = value;
				this.紋柄_紋1CD.不透明度 = value;
				this.紋柄_紋2CD.不透明度 = value;
				this.紋柄_紋3CD.不透明度 = value;
				this.紋柄_紋4CD.不透明度 = value;
				this.獣性_獣毛1CD.不透明度 = value;
				this.獣性_獣毛2CD.不透明度 = value;
				this.竜性_鱗4CD.不透明度 = value;
				this.竜性_鱗3CD.不透明度 = value;
				this.竜性_鱗2CD.不透明度 = value;
				this.竜性_鱗1CD.不透明度 = value;
				this.竜性_鱗5CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ左CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ右CD.不透明度 = value;
				this.淫タトゥ_タトゥ1CD.不透明度 = value;
				this.淫タトゥ_タトゥ2CD.不透明度 = value;
				this.淫タトゥ_タトゥ3CD.不透明度 = value;
				this.淫タトゥ_タトゥ4CD.不透明度 = value;
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
				this.植タトゥ_タトゥCD.不透明度 = value;
				this.植性_葉3CD.不透明度 = value;
				this.植性_葉2CD.不透明度 = value;
				this.植性_葉1CD.不透明度 = value;
				this.傷XCD.不透明度 = value;
				this.ハイライト_ハイライト1CD.不透明度 = value;
				this.ハイライト_ハイライト2CD.不透明度 = value;
				this.グロ\u30FCブ_グロ\u30FCブCD.不透明度 = value;
				this.グロ\u30FCブ_縁CD.不透明度 = value;
				this.シャツ_袖1CD.不透明度 = value;
				this.シャツ_袖2CD.不透明度 = value;
				this.シャツ_縁CD.不透明度 = value;
				this.ナ\u30FCス_袖1CD.不透明度 = value;
				this.ナ\u30FCス_袖2CD.不透明度 = value;
				this.ナ\u30FCス_縁CD.不透明度 = value;
				this.鎧_ベルト_ベルト1CD.不透明度 = value;
				this.鎧_ベルト_ベルト2CD.不透明度 = value;
				this.鎧_鎧_鎧1CD.不透明度 = value;
				this.鎧_鎧_鎧2CD.不透明度 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_筋肉上);
			Are.Draw(this.X0Y0_上腕);
			Are.Draw(this.X0Y0_筋肉下);
			Are.Draw(this.X0Y0_紋柄_紋1);
			Are.Draw(this.X0Y0_紋柄_紋2);
			Are.Draw(this.X0Y0_紋柄_紋3);
			Are.Draw(this.X0Y0_紋柄_紋4);
			Are.Draw(this.X0Y0_虫性_虫腕);
			Are.Draw(this.X0Y0_虫性_筋肉下);
			Are.Draw(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左);
			Are.Draw(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右);
			Are.Draw(this.X0Y0_淫タトゥ_タトゥ1);
			Are.Draw(this.X0Y0_淫タトゥ_タトゥ2);
			Are.Draw(this.X0Y0_淫タトゥ_タトゥ3);
			Are.Draw(this.X0Y0_淫タトゥ_タトゥ4);
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
			Are.Draw(this.X0Y0_悪タトゥ_タトゥ2);
			Are.Draw(this.X0Y0_植タトゥ_タトゥ);
			Are.Draw(this.X0Y0_獣性_獣毛1);
			Are.Draw(this.X0Y0_獣性_獣毛2);
			Are.Draw(this.X0Y0_傷X);
			this.キスマ\u30FCク.Draw(Are);
			this.鞭痕.Draw(Are);
			Are.Draw(this.X0Y0_竜性_鱗4);
			Are.Draw(this.X0Y0_竜性_鱗3);
			Are.Draw(this.X0Y0_竜性_鱗2);
			Are.Draw(this.X0Y0_竜性_鱗1);
			Are.Draw(this.X0Y0_竜性_鱗5);
			Are.Draw(this.X0Y0_ハイライト_ハイライト1);
			Are.Draw(this.X0Y0_ハイライト_ハイライト2);
			Are.Draw(this.X0Y0_植性_通常_葉3);
			Are.Draw(this.X0Y0_植性_通常_葉2);
			Are.Draw(this.X0Y0_植性_通常_葉1);
			Are.Draw(this.X0Y0_植性_欠損_葉3);
			Are.Draw(this.X0Y0_植性_欠損_葉2);
			Are.Draw(this.X0Y0_植性_欠損_葉1);
		}

		public void 鎧描画(Are Are)
		{
			Are.Draw(this.X0Y0_鎧_ベルト_ベルト1);
			Are.Draw(this.X0Y0_鎧_ベルト_ベルト2);
			Are.Draw(this.X0Y0_鎧_鎧_鎧1);
			Are.Draw(this.X0Y0_鎧_鎧_鎧2);
		}

		public bool 肘部_外線
		{
			get
			{
				return this.X0Y0_上腕.OP[this.右 ? 2 : 1].Outline;
			}
			set
			{
				this.X0Y0_上腕.OP[this.右 ? 2 : 1].Outline = value;
				this.X0Y0_虫性_虫腕.OP[this.右 ? 1 : 4].Outline = value;
				this.X0Y0_獣性_獣毛1.OP[this.右 ? 3 : 7].Outline = value;
				this.X0Y0_グロ\u30FCブ_通常_グロ\u30FCブ.OP[this.右 ? 2 : 1].Outline = value;
				this.X0Y0_グロ\u30FCブ_筋肉_グロ\u30FCブ.OP[this.右 ? 2 : 1].Outline = value;
			}
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

		public bool シャツ表示
		{
			get
			{
				return this.シャツ_袖1_表示;
			}
			set
			{
				this.シャツ_袖1_表示 = value;
				this.シャツ_袖2_表示 = value;
				this.シャツ_縁_表示 = value;
			}
		}

		public bool ナ\u30FCス表示
		{
			get
			{
				return this.ナ\u30FCス_袖1_表示;
			}
			set
			{
				this.ナ\u30FCス_袖1_表示 = value;
				this.ナ\u30FCス_袖2_表示 = value;
				this.ナ\u30FCス_縁_表示 = value;
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
				this.鎧_鎧_鎧1_表示 = value;
				this.鎧_鎧_鎧2_表示 = value;
			}
		}

		public override void Set拘束角度()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_上腕.AngleBase = num * -30.0;
			this.尺度XC = 0.95;
			this.本体.JoinPAall();
		}

		public override bool Is布(Par p)
		{
			return p == this.X0Y0_グロ\u30FCブ_通常_グロ\u30FCブ || p == this.X0Y0_グロ\u30FCブ_通常_縁 || p == this.X0Y0_グロ\u30FCブ_筋肉_グロ\u30FCブ || p == this.X0Y0_グロ\u30FCブ_筋肉_縁 || p == this.X0Y0_シャツ_袖1 || p == this.X0Y0_シャツ_袖2 || p == this.X0Y0_シャツ_縁 || p == this.X0Y0_ナ\u30FCス_袖1 || p == this.X0Y0_ナ\u30FCス_袖2 || p == this.X0Y0_ナ\u30FCス_縁;
		}

		public override bool Is鉄(Par p)
		{
			return p == this.X0Y0_鎧_ベルト_ベルト1 || p == this.X0Y0_鎧_ベルト_ベルト2 || p == this.X0Y0_鎧_鎧_鎧1 || p == this.X0Y0_鎧_鎧_鎧2;
		}

		public JointS 下腕_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_上腕, 1);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_筋肉上CP.Update();
			this.X0Y0_上腕CP.Update();
			this.X0Y0_虫性_虫腕CP.Update();
			this.X0Y0_虫性_筋肉下CP.Update();
			this.X0Y0_筋肉下CP.Update();
			this.X0Y0_紋柄_紋1CP.Update();
			this.X0Y0_紋柄_紋2CP.Update();
			this.X0Y0_紋柄_紋3CP.Update();
			this.X0Y0_紋柄_紋4CP.Update();
			this.X0Y0_獣性_獣毛1CP.Update();
			this.X0Y0_獣性_獣毛2CP.Update();
			this.X0Y0_鱗_鱗4CP.Update();
			this.X0Y0_鱗_鱗3CP.Update();
			this.X0Y0_鱗_鱗2CP.Update();
			this.X0Y0_鱗_鱗1CP.Update();
			this.X0Y0_鱗_鱗5CP.Update();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左CP.Update();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右CP.Update();
			this.X0Y0_淫タトゥ_タトゥ1CP.Update();
			this.X0Y0_淫タトゥ_タトゥ2CP.Update();
			this.X0Y0_淫タトゥ_タトゥ3CP.Update();
			this.X0Y0_淫タトゥ_タトゥ4CP.Update();
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
			this.X0Y0_悪タトゥ_タトゥ2CP.Update();
			this.X0Y0_植タトゥ_タトゥCP.Update();
			this.X0Y0_植性_通常_葉3CP.Update();
			this.X0Y0_植性_通常_葉2CP.Update();
			this.X0Y0_植性_通常_葉1CP.Update();
			this.X0Y0_植性_欠損_葉3CP.Update();
			this.X0Y0_植性_欠損_葉2CP.Update();
			this.X0Y0_植性_欠損_葉1CP.Update();
			this.X0Y0_傷XCP.Update();
			this.X0Y0_ハイライト_ハイライト1CP.Update();
			this.X0Y0_ハイライト_ハイライト2CP.Update();
			this.X0Y0_グロ\u30FCブ_通常_グロ\u30FCブCP.Update();
			this.X0Y0_グロ\u30FCブ_通常_縁CP.Update();
			this.X0Y0_グロ\u30FCブ_筋肉_グロ\u30FCブCP.Update();
			this.X0Y0_グロ\u30FCブ_筋肉_縁CP.Update();
			this.X0Y0_シャツ_袖1CP.Update();
			this.X0Y0_シャツ_袖2CP.Update();
			this.X0Y0_シャツ_縁CP.Update();
			this.X0Y0_ナ\u30FCス_袖1CP.Update();
			this.X0Y0_ナ\u30FCス_袖2CP.Update();
			this.X0Y0_ナ\u30FCス_縁CP.Update();
			this.X0Y0_鎧_ベルト_ベルト1CP.Update();
			this.X0Y0_鎧_ベルト_ベルト2CP.Update();
			this.X0Y0_鎧_鎧_鎧1CP.Update();
			this.X0Y0_鎧_鎧_鎧2CP.Update();
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
			this.筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.上腕CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.虫性_虫腕CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_筋肉下CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.獣性_獣毛1CD = new ColorD();
			this.獣性_獣毛1CD.c = Col.Black;
			this.獣性_獣毛1CD.c2.Col1 = 体配色.毛0O.Col1;
			this.獣性_獣毛1CD.c2.Col2 = 体配色.毛0O.Col1;
			this.獣性_獣毛2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.淫タトゥ_ハ\u30FCト_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ3CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ4CD = new ColorD(ref Col.Black, ref 体配色.刺青);
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
			this.植タトゥ_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植性_葉3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.傷XCD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライト_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.グロ\u30FCブ_グロ\u30FCブCD = new ColorD();
			this.グロ\u30FCブ_縁CD = new ColorD();
			this.シャツ_袖1CD = new ColorD();
			this.シャツ_袖2CD = new ColorD();
			this.シャツ_縁CD = new ColorD();
			this.ナ\u30FCス_袖1CD = new ColorD();
			this.ナ\u30FCス_袖2CD = new ColorD();
			this.ナ\u30FCス_縁CD = new ColorD();
			this.鎧_ベルト_ベルト1CD = new ColorD();
			this.鎧_ベルト_ベルト2CD = new ColorD();
			this.鎧_鎧_鎧1CD = new ColorD();
			this.鎧_鎧_鎧2CD = new ColorD();
		}

		private void 配色T0(体配色 体配色)
		{
			this.筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.上腕CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.虫性_虫腕CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_筋肉下CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.獣性_獣毛1CD = new ColorD();
			this.獣性_獣毛1CD.c = Col.Black;
			this.獣性_獣毛1CD.c2.Col1 = 体配色.毛0O.Col1;
			this.獣性_獣毛1CD.c2.Col2 = 体配色.毛0O.Col1;
			this.獣性_獣毛2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.淫タトゥ_ハ\u30FCト_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ3CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ4CD = new ColorD(ref Col.Black, ref 体配色.刺青);
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
			this.植タトゥ_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植性_葉3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性_葉2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.傷XCD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライト_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.グロ\u30FCブ_グロ\u30FCブCD = new ColorD();
			this.グロ\u30FCブ_縁CD = new ColorD();
			this.シャツ_袖1CD = new ColorD();
			this.シャツ_袖2CD = new ColorD();
			this.シャツ_縁CD = new ColorD();
			this.ナ\u30FCス_袖1CD = new ColorD();
			this.ナ\u30FCス_袖2CD = new ColorD();
			this.ナ\u30FCス_縁CD = new ColorD();
			this.鎧_ベルト_ベルト1CD = new ColorD();
			this.鎧_ベルト_ベルト2CD = new ColorD();
			this.鎧_鎧_鎧1CD = new ColorD();
			this.鎧_鎧_鎧2CD = new ColorD();
		}

		private void 配色T1(体配色 体配色)
		{
			this.筋肉上CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.上腕CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.人肌O);
			this.虫性_虫腕CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.虫性_筋肉下CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.獣性_獣毛1CD = new ColorD();
			this.獣性_獣毛1CD.c = Col.Black;
			this.獣性_獣毛1CD.c2.Col1 = 体配色.毛0O.Col1;
			this.獣性_獣毛1CD.c2.Col2 = 体配色.毛0O.Col1;
			this.獣性_獣毛2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.淫タトゥ_ハ\u30FCト_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ3CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ4CD = new ColorD(ref Col.Black, ref 体配色.刺青);
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
			this.植タトゥ_タトゥCD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.植性_葉3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性_葉1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.傷XCD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライト_ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト_ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.グロ\u30FCブ_グロ\u30FCブCD = new ColorD();
			this.グロ\u30FCブ_縁CD = new ColorD();
			this.シャツ_袖1CD = new ColorD();
			this.シャツ_袖2CD = new ColorD();
			this.シャツ_縁CD = new ColorD();
			this.ナ\u30FCス_袖1CD = new ColorD();
			this.ナ\u30FCス_袖2CD = new ColorD();
			this.ナ\u30FCス_縁CD = new ColorD();
			this.鎧_ベルト_ベルト1CD = new ColorD();
			this.鎧_ベルト_ベルト2CD = new ColorD();
			this.鎧_鎧_鎧1CD = new ColorD();
			this.鎧_鎧_鎧2CD = new ColorD();
		}

		public Par X0Y0_筋肉上;

		public Par X0Y0_上腕;

		public Par X0Y0_筋肉下;

		public Par X0Y0_虫性_虫腕;

		public Par X0Y0_虫性_筋肉下;

		public Par X0Y0_紋柄_紋1;

		public Par X0Y0_紋柄_紋2;

		public Par X0Y0_紋柄_紋3;

		public Par X0Y0_紋柄_紋4;

		public Par X0Y0_獣性_獣毛1;

		public Par X0Y0_獣性_獣毛2;

		public Par X0Y0_竜性_鱗4;

		public Par X0Y0_竜性_鱗3;

		public Par X0Y0_竜性_鱗2;

		public Par X0Y0_竜性_鱗1;

		public Par X0Y0_竜性_鱗5;

		public Par X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左;

		public Par X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右;

		public Par X0Y0_淫タトゥ_タトゥ1;

		public Par X0Y0_淫タトゥ_タトゥ2;

		public Par X0Y0_淫タトゥ_タトゥ3;

		public Par X0Y0_淫タトゥ_タトゥ4;

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

		public Par X0Y0_悪タトゥ_タトゥ2;

		public Par X0Y0_植タトゥ_タトゥ;

		public Par X0Y0_植性_通常_葉3;

		public Par X0Y0_植性_通常_葉2;

		public Par X0Y0_植性_通常_葉1;

		public Par X0Y0_植性_欠損_葉3;

		public Par X0Y0_植性_欠損_葉2;

		public Par X0Y0_植性_欠損_葉1;

		public Par X0Y0_傷X;

		public Par X0Y0_ハイライト_ハイライト1;

		public Par X0Y0_ハイライト_ハイライト2;

		public Par X0Y0_グロ\u30FCブ_通常_グロ\u30FCブ;

		public Par X0Y0_グロ\u30FCブ_通常_縁;

		public Par X0Y0_グロ\u30FCブ_筋肉_グロ\u30FCブ;

		public Par X0Y0_グロ\u30FCブ_筋肉_縁;

		public Par X0Y0_シャツ_袖1;

		public Par X0Y0_シャツ_袖2;

		public Par X0Y0_シャツ_縁;

		public Par X0Y0_ナ\u30FCス_袖1;

		public Par X0Y0_ナ\u30FCス_袖2;

		public Par X0Y0_ナ\u30FCス_縁;

		public Par X0Y0_鎧_ベルト_ベルト1;

		public Par X0Y0_鎧_ベルト_ベルト2;

		public Par X0Y0_鎧_鎧_鎧1;

		public Par X0Y0_鎧_鎧_鎧2;

		public ColorD 筋肉上CD;

		public ColorD 上腕CD;

		public ColorD 筋肉下CD;

		public ColorD 虫性_虫腕CD;

		public ColorD 虫性_筋肉下CD;

		public ColorD 紋柄_紋1CD;

		public ColorD 紋柄_紋2CD;

		public ColorD 紋柄_紋3CD;

		public ColorD 紋柄_紋4CD;

		public ColorD 獣性_獣毛1CD;

		public ColorD 獣性_獣毛2CD;

		public ColorD 竜性_鱗4CD;

		public ColorD 竜性_鱗3CD;

		public ColorD 竜性_鱗2CD;

		public ColorD 竜性_鱗1CD;

		public ColorD 竜性_鱗5CD;

		public ColorD 淫タトゥ_ハ\u30FCト_タトゥ左CD;

		public ColorD 淫タトゥ_ハ\u30FCト_タトゥ右CD;

		public ColorD 淫タトゥ_タトゥ1CD;

		public ColorD 淫タトゥ_タトゥ2CD;

		public ColorD 淫タトゥ_タトゥ3CD;

		public ColorD 淫タトゥ_タトゥ4CD;

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

		public ColorD 植タトゥ_タトゥCD;

		public ColorD 植性_葉3CD;

		public ColorD 植性_葉2CD;

		public ColorD 植性_葉1CD;

		public ColorD 傷XCD;

		public ColorD ハイライト_ハイライト1CD;

		public ColorD ハイライト_ハイライト2CD;

		public ColorD グロ\u30FCブ_グロ\u30FCブCD;

		public ColorD グロ\u30FCブ_縁CD;

		public ColorD シャツ_袖1CD;

		public ColorD シャツ_袖2CD;

		public ColorD シャツ_縁CD;

		public ColorD ナ\u30FCス_袖1CD;

		public ColorD ナ\u30FCス_袖2CD;

		public ColorD ナ\u30FCス_縁CD;

		public ColorD 鎧_ベルト_ベルト1CD;

		public ColorD 鎧_ベルト_ベルト2CD;

		public ColorD 鎧_鎧_鎧1CD;

		public ColorD 鎧_鎧_鎧2CD;

		public ColorP X0Y0_筋肉上CP;

		public ColorP X0Y0_上腕CP;

		public ColorP X0Y0_筋肉下CP;

		public ColorP X0Y0_虫性_虫腕CP;

		public ColorP X0Y0_虫性_筋肉下CP;

		public ColorP X0Y0_紋柄_紋1CP;

		public ColorP X0Y0_紋柄_紋2CP;

		public ColorP X0Y0_紋柄_紋3CP;

		public ColorP X0Y0_紋柄_紋4CP;

		public ColorP X0Y0_獣性_獣毛1CP;

		public ColorP X0Y0_獣性_獣毛2CP;

		public ColorP X0Y0_鱗_鱗4CP;

		public ColorP X0Y0_鱗_鱗3CP;

		public ColorP X0Y0_鱗_鱗2CP;

		public ColorP X0Y0_鱗_鱗1CP;

		public ColorP X0Y0_鱗_鱗5CP;

		public ColorP X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左CP;

		public ColorP X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右CP;

		public ColorP X0Y0_淫タトゥ_タトゥ1CP;

		public ColorP X0Y0_淫タトゥ_タトゥ2CP;

		public ColorP X0Y0_淫タトゥ_タトゥ3CP;

		public ColorP X0Y0_淫タトゥ_タトゥ4CP;

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

		public ColorP X0Y0_悪タトゥ_タトゥ2CP;

		public ColorP X0Y0_植タトゥ_タトゥCP;

		public ColorP X0Y0_植性_通常_葉3CP;

		public ColorP X0Y0_植性_通常_葉2CP;

		public ColorP X0Y0_植性_通常_葉1CP;

		public ColorP X0Y0_植性_欠損_葉3CP;

		public ColorP X0Y0_植性_欠損_葉2CP;

		public ColorP X0Y0_植性_欠損_葉1CP;

		public ColorP X0Y0_傷XCP;

		public ColorP X0Y0_ハイライト_ハイライト1CP;

		public ColorP X0Y0_ハイライト_ハイライト2CP;

		public ColorP X0Y0_グロ\u30FCブ_通常_グロ\u30FCブCP;

		public ColorP X0Y0_グロ\u30FCブ_通常_縁CP;

		public ColorP X0Y0_グロ\u30FCブ_筋肉_グロ\u30FCブCP;

		public ColorP X0Y0_グロ\u30FCブ_筋肉_縁CP;

		public ColorP X0Y0_シャツ_袖1CP;

		public ColorP X0Y0_シャツ_袖2CP;

		public ColorP X0Y0_シャツ_縁CP;

		public ColorP X0Y0_ナ\u30FCス_袖1CP;

		public ColorP X0Y0_ナ\u30FCス_袖2CP;

		public ColorP X0Y0_ナ\u30FCス_縁CP;

		public ColorP X0Y0_鎧_ベルト_ベルト1CP;

		public ColorP X0Y0_鎧_ベルト_ベルト2CP;

		public ColorP X0Y0_鎧_鎧_鎧1CP;

		public ColorP X0Y0_鎧_鎧_鎧2CP;

		public スタンプK キスマ\u30FCク;

		public スタンプW 鞭痕;
	}
}
