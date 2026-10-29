using System;
using System.Drawing;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 腿_人 : 腿
	{
		public 腿_人(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 腿_人D e)
		{
			腿_人.<>c__DisplayClass603_0 CS$<>8__locals1 = new 腿_人.<>c__DisplayClass603_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.脚左["腿"]);
			Pars pars = this.本体[0][0];
			this.X0Y0_腿 = pars["腿"].ToPar();
			this.X0Y0_筋 = pars["筋"].ToPar();
			Pars pars2 = pars["獣性"].ToPars();
			this.X0Y0_獣性_獣毛1 = pars2["獣毛1"].ToPar();
			this.X0Y0_獣性_獣毛2 = pars2["獣毛2"].ToPar();
			pars2 = pars["淫タトゥ"].ToPars();
			Pars pars3 = pars2["ハート"].ToPars();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左 = pars3["タトゥ左"].ToPar();
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右 = pars3["タトゥ右"].ToPar();
			this.X0Y0_淫タトゥ_タトゥ左1 = pars2["タトゥ左1"].ToPar();
			this.X0Y0_淫タトゥ_タトゥ右1 = pars2["タトゥ右1"].ToPar();
			this.X0Y0_淫タトゥ_タトゥ左2 = pars2["タトゥ左2"].ToPar();
			this.X0Y0_淫タトゥ_タトゥ右2 = pars2["タトゥ右2"].ToPar();
			pars2 = pars["悪タトゥ1"].ToPars();
			pars3 = pars2["文字"].ToPars();
			Pars pars4 = pars3["文字a"].ToPars();
			this.X0Y0_悪タトゥ1_文字_文字a_枠 = pars4["枠"].ToPar();
			this.X0Y0_悪タトゥ1_文字_文字a_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ1_文字_文字a_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字b"].ToPars();
			this.X0Y0_悪タトゥ1_文字_文字b_枠 = pars4["枠"].ToPar();
			this.X0Y0_悪タトゥ1_文字_文字b_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ1_文字_文字b_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字c"].ToPars();
			this.X0Y0_悪タトゥ1_文字_文字c_枠 = pars4["枠"].ToPar();
			this.X0Y0_悪タトゥ1_文字_文字c_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ1_文字_文字c_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字d"].ToPars();
			this.X0Y0_悪タトゥ1_文字_文字d_枠 = pars4["枠"].ToPar();
			this.X0Y0_悪タトゥ1_文字_文字d_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ1_文字_文字d_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字e"].ToPars();
			this.X0Y0_悪タトゥ1_文字_文字e_枠 = pars4["枠"].ToPar();
			this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ3 = pars4["文字タトゥ3"].ToPar();
			this.X0Y0_悪タトゥ1_タトゥ1 = pars2["タトゥ1"].ToPar();
			this.X0Y0_悪タトゥ1_タトゥ2 = pars2["タトゥ2"].ToPar();
			pars2 = pars["悪タトゥ2"].ToPars();
			pars3 = pars2["逆十字"].ToPars();
			this.X0Y0_悪タトゥ2_逆十字_逆十字1 = pars3["逆十字1"].ToPar();
			this.X0Y0_悪タトゥ2_逆十字_逆十字2 = pars3["逆十字2"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y0_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y0_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y0_竜性_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y0_竜性_鱗4 = pars2["鱗4"].ToPar();
			pars2 = pars["紋柄"].ToPars();
			this.X0Y0_紋柄_紋1 = pars2["紋1"].ToPar();
			this.X0Y0_紋柄_紋2 = pars2["紋2"].ToPar();
			this.X0Y0_紋柄_紋3 = pars2["紋3"].ToPar();
			this.X0Y0_紋柄_紋4 = pars2["紋4"].ToPar();
			pars2 = pars["植性"].ToPars();
			pars3 = pars2["通常"].ToPars();
			this.X0Y0_植性_通常_葉3 = pars3["葉3"].ToPar();
			this.X0Y0_植性_通常_葉2 = pars3["葉2"].ToPar();
			this.X0Y0_植性_通常_葉1 = pars3["葉1"].ToPar();
			pars3 = pars2["欠損"].ToPars();
			this.X0Y0_植性_欠損_葉3 = pars3["葉3"].ToPar();
			this.X0Y0_植性_欠損_葉2 = pars3["葉2"].ToPar();
			this.X0Y0_植性_欠損_葉1 = pars3["葉1"].ToPar();
			pars2 = pars["虫性"].ToPars();
			this.X0Y0_虫性_器官1 = pars2["器官1"].ToPar();
			this.X0Y0_虫性_器官2 = pars2["器官2"].ToPar();
			this.X0Y0_傷I1 = pars["傷I1"].ToPar();
			this.X0Y0_傷I2 = pars["傷I2"].ToPar();
			this.X0Y0_傷I3 = pars["傷I3"].ToPar();
			this.X0Y0_傷I4 = pars["傷I4"].ToPar();
			this.X0Y0_傷X = pars["傷X"].ToPar();
			this.X0Y0_ハイライト1 = pars["ハイライト1"].ToPar();
			this.X0Y0_ハイライト2 = pars["ハイライト2"].ToPar();
			pars2 = pars["パンスト"].ToPars();
			this.X0Y0_パンスト = pars2["パンスト"].ToPar();
			this.X0Y0_パンスト_ハイライト = pars2["ハイライト"].ToPar();
			pars2 = pars["ニーハイ"].ToPars();
			this.X0Y0_ニ\u30FCハイ_ニ\u30FCハイ1 = pars2["ニーハイ1"].ToPar();
			this.X0Y0_ニ\u30FCハイ_ニ\u30FCハイ2 = pars2["ニーハイ2"].ToPar();
			this.X0Y0_ニ\u30FCハイ_ハイライト = pars2["ハイライト"].ToPar();
			pars = this.本体[0][1];
			this.X0Y1_腿 = pars["腿"].ToPar();
			this.X0Y1_筋 = pars["筋"].ToPar();
			pars2 = pars["獣性"].ToPars();
			this.X0Y1_獣性_獣毛1 = pars2["獣毛1"].ToPar();
			this.X0Y1_獣性_獣毛2 = pars2["獣毛2"].ToPar();
			pars2 = pars["淫タトゥ"].ToPars();
			pars3 = pars2["ハート"].ToPars();
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左 = pars3["タトゥ左"].ToPar();
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右 = pars3["タトゥ右"].ToPar();
			this.X0Y1_淫タトゥ_タトゥ左1 = pars2["タトゥ左1"].ToPar();
			this.X0Y1_淫タトゥ_タトゥ右1 = pars2["タトゥ右1"].ToPar();
			this.X0Y1_淫タトゥ_タトゥ左2 = pars2["タトゥ左2"].ToPar();
			this.X0Y1_淫タトゥ_タトゥ右2 = pars2["タトゥ右2"].ToPar();
			pars2 = pars["悪タトゥ1"].ToPars();
			pars3 = pars2["文字"].ToPars();
			pars4 = pars3["文字a"].ToPars();
			this.X0Y1_悪タトゥ1_文字_文字a_枠 = pars4["枠"].ToPar();
			this.X0Y1_悪タトゥ1_文字_文字a_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y1_悪タトゥ1_文字_文字a_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字b"].ToPars();
			this.X0Y1_悪タトゥ1_文字_文字b_枠 = pars4["枠"].ToPar();
			this.X0Y1_悪タトゥ1_文字_文字b_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y1_悪タトゥ1_文字_文字b_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字c"].ToPars();
			this.X0Y1_悪タトゥ1_文字_文字c_枠 = pars4["枠"].ToPar();
			this.X0Y1_悪タトゥ1_文字_文字c_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y1_悪タトゥ1_文字_文字c_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字d"].ToPars();
			this.X0Y1_悪タトゥ1_文字_文字d_枠 = pars4["枠"].ToPar();
			this.X0Y1_悪タトゥ1_文字_文字d_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y1_悪タトゥ1_文字_文字d_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字e"].ToPars();
			this.X0Y1_悪タトゥ1_文字_文字e_枠 = pars4["枠"].ToPar();
			this.X0Y1_悪タトゥ1_文字_文字e_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y1_悪タトゥ1_文字_文字e_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			this.X0Y1_悪タトゥ1_文字_文字e_文字タトゥ3 = pars4["文字タトゥ3"].ToPar();
			this.X0Y1_悪タトゥ1_タトゥ1 = pars2["タトゥ1"].ToPar();
			this.X0Y1_悪タトゥ1_タトゥ2 = pars2["タトゥ2"].ToPar();
			pars2 = pars["悪タトゥ2"].ToPars();
			pars3 = pars2["逆十字"].ToPars();
			this.X0Y1_悪タトゥ2_逆十字_逆十字1 = pars3["逆十字1"].ToPar();
			this.X0Y1_悪タトゥ2_逆十字_逆十字2 = pars3["逆十字2"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y1_鱗_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y1_鱗_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y1_鱗_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y1_鱗_鱗4 = pars2["鱗4"].ToPar();
			pars2 = pars["紋柄"].ToPars();
			this.X0Y1_紋柄_紋1 = pars2["紋1"].ToPar();
			this.X0Y1_紋柄_紋2 = pars2["紋2"].ToPar();
			this.X0Y1_紋柄_紋3 = pars2["紋3"].ToPar();
			this.X0Y1_紋柄_紋4 = pars2["紋4"].ToPar();
			pars2 = pars["植性"].ToPars();
			pars3 = pars2["通常"].ToPars();
			this.X0Y1_植性_通常_葉3 = pars3["葉3"].ToPar();
			this.X0Y1_植性_通常_葉2 = pars3["葉2"].ToPar();
			this.X0Y1_植性_通常_葉1 = pars3["葉1"].ToPar();
			pars3 = pars2["欠損"].ToPars();
			this.X0Y1_植性_欠損_葉3 = pars3["葉3"].ToPar();
			this.X0Y1_植性_欠損_葉2 = pars3["葉2"].ToPar();
			this.X0Y1_植性_欠損_葉1 = pars3["葉1"].ToPar();
			pars2 = pars["虫性"].ToPars();
			this.X0Y1_虫性_器官1 = pars2["器官1"].ToPar();
			this.X0Y1_虫性_器官2 = pars2["器官2"].ToPar();
			this.X0Y1_傷I1 = pars["傷I1"].ToPar();
			this.X0Y1_傷I2 = pars["傷I2"].ToPar();
			this.X0Y1_傷I3 = pars["傷I3"].ToPar();
			this.X0Y1_傷I4 = pars["傷I4"].ToPar();
			this.X0Y1_傷X = pars["傷X"].ToPar();
			this.X0Y1_ハイライト1 = pars["ハイライト1"].ToPar();
			this.X0Y1_ハイライト2 = pars["ハイライト2"].ToPar();
			pars2 = pars["パンスト"].ToPars();
			this.X0Y1_パンスト = pars2["パンスト"].ToPar();
			this.X0Y1_パンスト_ハイライト = pars2["ハイライト"].ToPar();
			pars2 = pars["ニーハイ"].ToPars();
			this.X0Y1_ニ\u30FCハイ_ニ\u30FCハイ1 = pars2["ニーハイ1"].ToPar();
			this.X0Y1_ニ\u30FCハイ_ニ\u30FCハイ2 = pars2["ニーハイ2"].ToPar();
			this.X0Y1_ニ\u30FCハイ_ハイライト = pars2["ハイライト"].ToPar();
			pars = this.本体[0][2];
			this.X0Y2_腿 = pars["腿"].ToPar();
			this.X0Y2_筋 = pars["筋"].ToPar();
			pars2 = pars["獣性"].ToPars();
			this.X0Y2_獣性_獣毛1 = pars2["獣毛1"].ToPar();
			this.X0Y2_獣性_獣毛2 = pars2["獣毛2"].ToPar();
			pars2 = pars["淫タトゥ"].ToPars();
			pars3 = pars2["ハート"].ToPars();
			this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左 = pars3["タトゥ左"].ToPar();
			this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右 = pars3["タトゥ右"].ToPar();
			this.X0Y2_淫タトゥ_タトゥ右1 = pars2["タトゥ右1"].ToPar();
			this.X0Y2_淫タトゥ_タトゥ右2 = pars2["タトゥ右2"].ToPar();
			pars2 = pars["悪タトゥ1"].ToPars();
			pars3 = pars2["文字"].ToPars();
			pars4 = pars3["文字b"].ToPars();
			this.X0Y2_悪タトゥ1_文字_文字b_枠 = pars4["枠"].ToPar();
			this.X0Y2_悪タトゥ1_文字_文字b_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y2_悪タトゥ1_文字_文字b_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字c"].ToPars();
			this.X0Y2_悪タトゥ1_文字_文字c_枠 = pars4["枠"].ToPar();
			this.X0Y2_悪タトゥ1_文字_文字c_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y2_悪タトゥ1_文字_文字c_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字d"].ToPars();
			this.X0Y2_悪タトゥ1_文字_文字d_枠 = pars4["枠"].ToPar();
			this.X0Y2_悪タトゥ1_文字_文字d_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y2_悪タトゥ1_文字_文字d_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字e"].ToPars();
			this.X0Y2_悪タトゥ1_文字_文字e_枠 = pars4["枠"].ToPar();
			this.X0Y2_悪タトゥ1_文字_文字e_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y2_悪タトゥ1_文字_文字e_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			this.X0Y2_悪タトゥ1_文字_文字e_文字タトゥ3 = pars4["文字タトゥ3"].ToPar();
			pars4 = pars3["文字a"].ToPars();
			this.X0Y2_悪タトゥ1_文字_文字a_枠 = pars4["枠"].ToPar();
			this.X0Y2_悪タトゥ1_文字_文字a_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y2_悪タトゥ1_文字_文字a_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			this.X0Y2_悪タトゥ1_タトゥ1 = pars2["タトゥ1"].ToPar();
			this.X0Y2_悪タトゥ1_タトゥ2 = pars2["タトゥ2"].ToPar();
			pars2 = pars["悪タトゥ2"].ToPars();
			pars3 = pars2["逆十字"].ToPars();
			this.X0Y2_悪タトゥ2_逆十字_逆十字1 = pars3["逆十字1"].ToPar();
			this.X0Y2_悪タトゥ2_逆十字_逆十字2 = pars3["逆十字2"].ToPar();
			pars2 = pars["植性"].ToPars();
			pars3 = pars2["通常"].ToPars();
			this.X0Y2_植性_通常_葉3 = pars3["葉3"].ToPar();
			this.X0Y2_植性_通常_葉2 = pars3["葉2"].ToPar();
			this.X0Y2_植性_通常_葉1 = pars3["葉1"].ToPar();
			pars3 = pars2["欠損"].ToPars();
			this.X0Y2_植性_欠損_葉3 = pars3["葉3"].ToPar();
			this.X0Y2_植性_欠損_葉2 = pars3["葉2"].ToPar();
			this.X0Y2_植性_欠損_葉1 = pars3["葉1"].ToPar();
			this.X0Y2_傷I1 = pars["傷I1"].ToPar();
			this.X0Y2_傷I2 = pars["傷I2"].ToPar();
			this.X0Y2_傷I3 = pars["傷I3"].ToPar();
			this.X0Y2_ハイライト1 = pars["ハイライト1"].ToPar();
			this.X0Y2_ハイライト2 = pars["ハイライト2"].ToPar();
			pars2 = pars["パンスト"].ToPars();
			this.X0Y2_パンスト = pars2["パンスト"].ToPar();
			this.X0Y2_パンスト_ハイライト = pars2["ハイライト"].ToPar();
			pars2 = pars["ニーハイ"].ToPars();
			this.X0Y2_ニ\u30FCハイ_ニ\u30FCハイ1 = pars2["ニーハイ1"].ToPar();
			this.X0Y2_ニ\u30FCハイ_ニ\u30FCハイ2 = pars2["ニーハイ2"].ToPar();
			this.X0Y2_ニ\u30FCハイ_ハイライト = pars2["ハイライト"].ToPar();
			pars = this.本体[0][3];
			this.X0Y3_腿 = pars["腿"].ToPar();
			this.X0Y3_筋 = pars["筋"].ToPar();
			pars2 = pars["獣性"].ToPars();
			this.X0Y3_獣性_獣毛1 = pars2["獣毛1"].ToPar();
			this.X0Y3_獣性_獣毛2 = pars2["獣毛2"].ToPar();
			pars2 = pars["淫タトゥ"].ToPars();
			this.X0Y3_淫タトゥ_タトゥ左1 = pars2["タトゥ左1"].ToPar();
			this.X0Y3_淫タトゥ_タトゥ右1 = pars2["タトゥ右1"].ToPar();
			this.X0Y3_淫タトゥ_タトゥ左2 = pars2["タトゥ左2"].ToPar();
			this.X0Y3_淫タトゥ_タトゥ右2 = pars2["タトゥ右2"].ToPar();
			pars2 = pars["悪タトゥ1"].ToPars();
			pars3 = pars2["文字"].ToPars();
			pars4 = pars3["文字c"].ToPars();
			this.X0Y3_悪タトゥ1_文字_文字c_枠 = pars4["枠"].ToPar();
			this.X0Y3_悪タトゥ1_文字_文字c_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y3_悪タトゥ1_文字_文字c_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字d"].ToPars();
			this.X0Y3_悪タトゥ1_文字_文字d_枠 = pars4["枠"].ToPar();
			this.X0Y3_悪タトゥ1_文字_文字d_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y3_悪タトゥ1_文字_文字d_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字e"].ToPars();
			this.X0Y3_悪タトゥ1_文字_文字e_枠 = pars4["枠"].ToPar();
			this.X0Y3_悪タトゥ1_文字_文字e_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y3_悪タトゥ1_文字_文字e_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			this.X0Y3_悪タトゥ1_文字_文字e_文字タトゥ3 = pars4["文字タトゥ3"].ToPar();
			pars4 = pars3["文字a"].ToPars();
			this.X0Y3_悪タトゥ1_文字_文字a_枠 = pars4["枠"].ToPar();
			this.X0Y3_悪タトゥ1_文字_文字a_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y3_悪タトゥ1_文字_文字a_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字b"].ToPars();
			this.X0Y3_悪タトゥ1_文字_文字b_枠 = pars4["枠"].ToPar();
			this.X0Y3_悪タトゥ1_文字_文字b_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y3_悪タトゥ1_文字_文字b_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			this.X0Y3_悪タトゥ1_タトゥ1 = pars2["タトゥ1"].ToPar();
			this.X0Y3_悪タトゥ1_タトゥ2 = pars2["タトゥ2"].ToPar();
			pars2 = pars["悪タトゥ2"].ToPars();
			pars3 = pars2["逆十字"].ToPars();
			this.X0Y3_悪タトゥ2_逆十字_逆十字1 = pars3["逆十字1"].ToPar();
			this.X0Y3_悪タトゥ2_逆十字_逆十字2 = pars3["逆十字2"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y3_鱗_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y3_鱗_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y3_鱗_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y3_鱗_鱗4 = pars2["鱗4"].ToPar();
			pars2 = pars["紋柄"].ToPars();
			this.X0Y3_紋柄_紋1 = pars2["紋1"].ToPar();
			this.X0Y3_紋柄_紋2 = pars2["紋2"].ToPar();
			this.X0Y3_紋柄_紋3 = pars2["紋3"].ToPar();
			this.X0Y3_紋柄_紋4 = pars2["紋4"].ToPar();
			pars2 = pars["植性"].ToPars();
			pars3 = pars2["通常"].ToPars();
			this.X0Y3_植性_通常_葉3 = pars3["葉3"].ToPar();
			this.X0Y3_植性_通常_葉2 = pars3["葉2"].ToPar();
			this.X0Y3_植性_通常_葉1 = pars3["葉1"].ToPar();
			pars3 = pars2["欠損"].ToPars();
			this.X0Y3_植性_欠損_葉3 = pars3["葉3"].ToPar();
			this.X0Y3_植性_欠損_葉2 = pars3["葉2"].ToPar();
			this.X0Y3_植性_欠損_葉1 = pars3["葉1"].ToPar();
			this.X0Y3_傷I1 = pars["傷I1"].ToPar();
			this.X0Y3_傷I2 = pars["傷I2"].ToPar();
			this.X0Y3_傷I3 = pars["傷I3"].ToPar();
			this.X0Y3_傷X = pars["傷X"].ToPar();
			this.X0Y3_ハイライト1 = pars["ハイライト1"].ToPar();
			this.X0Y3_ハイライト2 = pars["ハイライト2"].ToPar();
			pars2 = pars["パンスト"].ToPars();
			this.X0Y3_パンスト = pars2["パンスト"].ToPar();
			this.X0Y3_パンスト_ハイライト = pars2["ハイライト"].ToPar();
			pars2 = pars["ニーハイ"].ToPars();
			this.X0Y3_ニ\u30FCハイ_ニ\u30FCハイ1 = pars2["ニーハイ1"].ToPar();
			this.X0Y3_ニ\u30FCハイ_ニ\u30FCハイ2 = pars2["ニーハイ2"].ToPar();
			this.X0Y3_ニ\u30FCハイ_ハイライト = pars2["ハイライト"].ToPar();
			pars = this.本体[0][4];
			this.X0Y4_腿 = pars["腿"].ToPar();
			this.X0Y4_筋 = pars["筋"].ToPar();
			pars2 = pars["獣性"].ToPars();
			this.X0Y4_獣性_獣毛1 = pars2["獣毛1"].ToPar();
			this.X0Y4_獣性_獣毛2 = pars2["獣毛2"].ToPar();
			pars2 = pars["淫タトゥ"].ToPars();
			this.X0Y4_淫タトゥ_タトゥ左1 = pars2["タトゥ左1"].ToPar();
			this.X0Y4_淫タトゥ_タトゥ右1 = pars2["タトゥ右1"].ToPar();
			this.X0Y4_淫タトゥ_タトゥ左2 = pars2["タトゥ左2"].ToPar();
			this.X0Y4_淫タトゥ_タトゥ右2 = pars2["タトゥ右2"].ToPar();
			pars2 = pars["悪タトゥ1"].ToPars();
			pars3 = pars2["文字"].ToPars();
			pars4 = pars3["文字d"].ToPars();
			this.X0Y4_悪タトゥ1_文字_文字d_枠 = pars4["枠"].ToPar();
			this.X0Y4_悪タトゥ1_文字_文字d_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y4_悪タトゥ1_文字_文字d_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字e"].ToPars();
			this.X0Y4_悪タトゥ1_文字_文字e_枠 = pars4["枠"].ToPar();
			this.X0Y4_悪タトゥ1_文字_文字e_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y4_悪タトゥ1_文字_文字e_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			this.X0Y4_悪タトゥ1_文字_文字e_文字タトゥ3 = pars4["文字タトゥ3"].ToPar();
			pars4 = pars3["文字a"].ToPars();
			this.X0Y4_悪タトゥ1_文字_文字a_枠 = pars4["枠"].ToPar();
			this.X0Y4_悪タトゥ1_文字_文字a_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y4_悪タトゥ1_文字_文字a_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字b"].ToPars();
			this.X0Y4_悪タトゥ1_文字_文字b_枠 = pars4["枠"].ToPar();
			this.X0Y4_悪タトゥ1_文字_文字b_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y4_悪タトゥ1_文字_文字b_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			pars4 = pars3["文字c"].ToPars();
			this.X0Y4_悪タトゥ1_文字_文字c_枠 = pars4["枠"].ToPar();
			this.X0Y4_悪タトゥ1_文字_文字c_文字タトゥ1 = pars4["文字タトゥ1"].ToPar();
			this.X0Y4_悪タトゥ1_文字_文字c_文字タトゥ2 = pars4["文字タトゥ2"].ToPar();
			this.X0Y4_悪タトゥ1_タトゥ1 = pars2["タトゥ1"].ToPar();
			this.X0Y4_悪タトゥ1_タトゥ2 = pars2["タトゥ2"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y4_鱗_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y4_鱗_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y4_鱗_鱗3 = pars2["鱗3"].ToPar();
			this.X0Y4_鱗_鱗4 = pars2["鱗4"].ToPar();
			pars2 = pars["紋柄"].ToPars();
			this.X0Y4_紋柄_紋1 = pars2["紋1"].ToPar();
			this.X0Y4_紋柄_紋2 = pars2["紋2"].ToPar();
			this.X0Y4_紋柄_紋3 = pars2["紋3"].ToPar();
			this.X0Y4_紋柄_紋4 = pars2["紋4"].ToPar();
			pars2 = pars["植性"].ToPars();
			pars3 = pars2["通常"].ToPars();
			this.X0Y4_植性_通常_葉3 = pars3["葉3"].ToPar();
			this.X0Y4_植性_通常_葉2 = pars3["葉2"].ToPar();
			this.X0Y4_植性_通常_葉1 = pars3["葉1"].ToPar();
			pars3 = pars2["欠損"].ToPars();
			this.X0Y4_植性_欠損_葉3 = pars3["葉3"].ToPar();
			this.X0Y4_植性_欠損_葉2 = pars3["葉2"].ToPar();
			this.X0Y4_植性_欠損_葉1 = pars3["葉1"].ToPar();
			this.X0Y4_傷I1 = pars["傷I1"].ToPar();
			this.X0Y4_傷X = pars["傷X"].ToPar();
			this.X0Y4_ハイライト1 = pars["ハイライト1"].ToPar();
			this.X0Y4_ハイライト2 = pars["ハイライト2"].ToPar();
			pars2 = pars["パンスト"].ToPars();
			this.X0Y4_パンスト = pars2["パンスト"].ToPar();
			this.X0Y4_パンスト_ハイライト = pars2["ハイライト"].ToPar();
			pars2 = pars["ニーハイ"].ToPars();
			this.X0Y4_ニ\u30FCハイ_ニ\u30FCハイ1 = pars2["ニーハイ1"].ToPar();
			this.X0Y4_ニ\u30FCハイ_ニ\u30FCハイ2 = pars2["ニーハイ2"].ToPar();
			this.X0Y4_ニ\u30FCハイ_ハイライト = pars2["ハイライト"].ToPar();
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
			this.腿_表示 = e.腿_表示;
			this.筋_表示 = e.筋_表示;
			this.獣性_獣毛1_表示 = e.獣性_獣毛1_表示;
			this.獣性_獣毛2_表示 = e.獣性_獣毛2_表示;
			this.淫タトゥ_ハ\u30FCト_タトゥ左_表示 = e.淫タトゥ_ハ\u30FCト_タトゥ左_表示;
			this.淫タトゥ_ハ\u30FCト_タトゥ右_表示 = e.淫タトゥ_ハ\u30FCト_タトゥ右_表示;
			this.淫タトゥ_タトゥ左1_表示 = e.淫タトゥ_タトゥ左1_表示;
			this.淫タトゥ_タトゥ右1_表示 = e.淫タトゥ_タトゥ右1_表示;
			this.淫タトゥ_タトゥ左2_表示 = e.淫タトゥ_タトゥ左2_表示;
			this.淫タトゥ_タトゥ右2_表示 = e.淫タトゥ_タトゥ右2_表示;
			this.悪タトゥ1_文字_文字a_枠_表示 = e.悪タトゥ1_文字_文字a_枠_表示;
			this.悪タトゥ1_文字_文字a_文字タトゥ1_表示 = e.悪タトゥ1_文字_文字a_文字タトゥ1_表示;
			this.悪タトゥ1_文字_文字a_文字タトゥ2_表示 = e.悪タトゥ1_文字_文字a_文字タトゥ2_表示;
			this.悪タトゥ1_文字_文字b_枠_表示 = e.悪タトゥ1_文字_文字b_枠_表示;
			this.悪タトゥ1_文字_文字b_文字タトゥ1_表示 = e.悪タトゥ1_文字_文字b_文字タトゥ1_表示;
			this.悪タトゥ1_文字_文字b_文字タトゥ2_表示 = e.悪タトゥ1_文字_文字b_文字タトゥ2_表示;
			this.悪タトゥ1_文字_文字c_枠_表示 = e.悪タトゥ1_文字_文字c_枠_表示;
			this.悪タトゥ1_文字_文字c_文字タトゥ1_表示 = e.悪タトゥ1_文字_文字c_文字タトゥ1_表示;
			this.悪タトゥ1_文字_文字c_文字タトゥ2_表示 = e.悪タトゥ1_文字_文字c_文字タトゥ2_表示;
			this.悪タトゥ1_文字_文字d_枠_表示 = e.悪タトゥ1_文字_文字d_枠_表示;
			this.悪タトゥ1_文字_文字d_文字タトゥ1_表示 = e.悪タトゥ1_文字_文字d_文字タトゥ1_表示;
			this.悪タトゥ1_文字_文字d_文字タトゥ2_表示 = e.悪タトゥ1_文字_文字d_文字タトゥ2_表示;
			this.悪タトゥ1_文字_文字e_枠_表示 = e.悪タトゥ1_文字_文字e_枠_表示;
			this.悪タトゥ1_文字_文字e_文字タトゥ1_表示 = e.悪タトゥ1_文字_文字e_文字タトゥ1_表示;
			this.悪タトゥ1_文字_文字e_文字タトゥ2_表示 = e.悪タトゥ1_文字_文字e_文字タトゥ2_表示;
			this.悪タトゥ1_文字_文字e_文字タトゥ3_表示 = e.悪タトゥ1_文字_文字e_文字タトゥ3_表示;
			this.悪タトゥ1_タトゥ1_表示 = e.悪タトゥ1_タトゥ1_表示;
			this.悪タトゥ1_タトゥ2_表示 = e.悪タトゥ1_タトゥ2_表示;
			this.悪タトゥ2_逆十字_逆十字1_表示 = e.悪タトゥ2_逆十字_逆十字1_表示;
			this.悪タトゥ2_逆十字_逆十字2_表示 = e.悪タトゥ2_逆十字_逆十字2_表示;
			this.竜性_鱗1_表示 = e.竜性_鱗1_表示;
			this.竜性_鱗2_表示 = e.竜性_鱗2_表示;
			this.竜性_鱗3_表示 = e.竜性_鱗3_表示;
			this.竜性_鱗4_表示 = e.竜性_鱗4_表示;
			this.紋柄_紋1_表示 = e.紋柄_紋1_表示;
			this.紋柄_紋2_表示 = e.紋柄_紋2_表示;
			this.紋柄_紋3_表示 = e.紋柄_紋3_表示;
			this.紋柄_紋4_表示 = e.紋柄_紋4_表示;
			this.植性_通常_葉3_表示 = e.植性_通常_葉3_表示;
			this.植性_通常_葉2_表示 = e.植性_通常_葉2_表示;
			this.植性_通常_葉1_表示 = e.植性_通常_葉1_表示;
			this.植性_欠損_葉3_表示 = e.植性_欠損_葉3_表示;
			this.植性_欠損_葉2_表示 = e.植性_欠損_葉2_表示;
			this.植性_欠損_葉1_表示 = e.植性_欠損_葉1_表示;
			this.虫性_器官1_表示 = e.虫性_器官1_表示;
			this.虫性_器官2_表示 = e.虫性_器官2_表示;
			this.傷I1_表示 = e.傷I1_表示;
			this.傷I2_表示 = e.傷I2_表示;
			this.傷I3_表示 = e.傷I3_表示;
			this.傷I4_表示 = e.傷I4_表示;
			this.傷X_表示 = e.傷X_表示;
			this.ハイライト1_表示 = e.ハイライト1_表示;
			this.ハイライト2_表示 = e.ハイライト2_表示;
			this.パンスト_表示 = e.パンスト_表示;
			this.ニ\u30FCハイ_ニ\u30FCハイ1_表示 = e.ニ\u30FCハイ_ニ\u30FCハイ1_表示;
			this.ニ\u30FCハイ_ニ\u30FCハイ2_表示 = e.ニ\u30FCハイ_ニ\u30FCハイ2_表示;
			this.ニ\u30FCハイ_ハイライト_表示 = e.ニ\u30FCハイ_ハイライト_表示;
			this.植性_葉3_表示 = e.植性_葉3_表示;
			this.植性_葉2_表示 = e.植性_葉2_表示;
			this.植性_葉1_表示 = e.植性_葉1_表示;
			this.ハイライト表示 = e.ハイライト表示;
			if (e.虫性)
			{
				this.虫性();
			}
			this.パンスト表示 = e.パンスト表示;
			this.ニ\u30FCハイ表示 = e.ニ\u30FCハイ表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.脚_接続.Count > 0)
			{
				Ele f;
				this.脚_接続 = e.脚_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.腿_人_脚_接続;
					f.接続(CS$<>8__locals1.<>4__this.脚_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_腿CP = new ColorP(this.X0Y0_腿, this.腿0CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_筋CP = new ColorP(this.X0Y0_筋, this.筋CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_獣性_獣毛1CP = new ColorP(this.X0Y0_獣性_獣毛1, this.獣性_獣毛1_0CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_獣性_獣毛2CP = new ColorP(this.X0Y0_獣性_獣毛2, this.獣性_獣毛2_0CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左CP = new ColorP(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左, this.淫タトゥ_ハ\u30FCト_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右CP = new ColorP(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右, this.淫タトゥ_ハ\u30FCト_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ左1CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ左1, this.淫タトゥ_タトゥ左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ右1CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ右1, this.淫タトゥ_タトゥ右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ左2CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ左2, this.淫タトゥ_タトゥ左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_淫タトゥ_タトゥ右2CP = new ColorP(this.X0Y0_淫タトゥ_タトゥ右2, this.淫タトゥ_タトゥ右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ1_文字_文字a_枠CP = new ColorP(this.X0Y0_悪タトゥ1_文字_文字a_枠, this.悪タトゥ1_文字_文字a_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ1_文字_文字a_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ1_文字_文字a_文字タトゥ1, this.悪タトゥ1_文字_文字a_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ1_文字_文字a_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ1_文字_文字a_文字タトゥ2, this.悪タトゥ1_文字_文字a_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ1_文字_文字b_枠CP = new ColorP(this.X0Y0_悪タトゥ1_文字_文字b_枠, this.悪タトゥ1_文字_文字b_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ1_文字_文字b_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ1_文字_文字b_文字タトゥ1, this.悪タトゥ1_文字_文字b_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ1_文字_文字b_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ1_文字_文字b_文字タトゥ2, this.悪タトゥ1_文字_文字b_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ1_文字_文字c_枠CP = new ColorP(this.X0Y0_悪タトゥ1_文字_文字c_枠, this.悪タトゥ1_文字_文字c_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ1_文字_文字c_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ1_文字_文字c_文字タトゥ1, this.悪タトゥ1_文字_文字c_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ1_文字_文字c_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ1_文字_文字c_文字タトゥ2, this.悪タトゥ1_文字_文字c_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ1_文字_文字d_枠CP = new ColorP(this.X0Y0_悪タトゥ1_文字_文字d_枠, this.悪タトゥ1_文字_文字d_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ1_文字_文字d_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ1_文字_文字d_文字タトゥ1, this.悪タトゥ1_文字_文字d_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ1_文字_文字d_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ1_文字_文字d_文字タトゥ2, this.悪タトゥ1_文字_文字d_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ1_文字_文字e_枠CP = new ColorP(this.X0Y0_悪タトゥ1_文字_文字e_枠, this.悪タトゥ1_文字_文字e_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ1, this.悪タトゥ1_文字_文字e_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ2, this.悪タトゥ1_文字_文字e_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ3CP = new ColorP(this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ3, this.悪タトゥ1_文字_文字e_文字タトゥ3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ1_タトゥ1CP = new ColorP(this.X0Y0_悪タトゥ1_タトゥ1, this.悪タトゥ1_タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ1_タトゥ2CP = new ColorP(this.X0Y0_悪タトゥ1_タトゥ2, this.悪タトゥ1_タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ2_逆十字_逆十字1CP = new ColorP(this.X0Y0_悪タトゥ2_逆十字_逆十字1, this.悪タトゥ2_逆十字_逆十字1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_悪タトゥ2_逆十字_逆十字2CP = new ColorP(this.X0Y0_悪タトゥ2_逆十字_逆十字2, this.悪タトゥ2_逆十字_逆十字2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗1CP = new ColorP(this.X0Y0_竜性_鱗1, this.竜性_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗2CP = new ColorP(this.X0Y0_竜性_鱗2, this.竜性_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗3CP = new ColorP(this.X0Y0_竜性_鱗3, this.竜性_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_竜性_鱗4CP = new ColorP(this.X0Y0_竜性_鱗4, this.竜性_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋1CP = new ColorP(this.X0Y0_紋柄_紋1, this.紋柄_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋2CP = new ColorP(this.X0Y0_紋柄_紋2, this.紋柄_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋3CP = new ColorP(this.X0Y0_紋柄_紋3, this.紋柄_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_紋柄_紋4CP = new ColorP(this.X0Y0_紋柄_紋4, this.紋柄_紋4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性_通常_葉3CP = new ColorP(this.X0Y0_植性_通常_葉3, this.植性_葉3_0CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性_通常_葉2CP = new ColorP(this.X0Y0_植性_通常_葉2, this.植性_葉2_0CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性_通常_葉1CP = new ColorP(this.X0Y0_植性_通常_葉1, this.植性_葉1_0CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性_欠損_葉3CP = new ColorP(this.X0Y0_植性_欠損_葉3, this.植性_葉3_0CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性_欠損_葉2CP = new ColorP(this.X0Y0_植性_欠損_葉2, this.植性_葉2_0CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_植性_欠損_葉1CP = new ColorP(this.X0Y0_植性_欠損_葉1, this.植性_葉1_0CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_器官1CP = new ColorP(this.X0Y0_虫性_器官1, this.虫性_器官1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_虫性_器官2CP = new ColorP(this.X0Y0_虫性_器官2, this.虫性_器官2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷I1CP = new ColorP(this.X0Y0_傷I1, this.傷I1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷I2CP = new ColorP(this.X0Y0_傷I2, this.傷I2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷I3CP = new ColorP(this.X0Y0_傷I3, this.傷I3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷I4CP = new ColorP(this.X0Y0_傷I4, this.傷I4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_傷XCP = new ColorP(this.X0Y0_傷X, this.傷XCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ハイライト1CP = new ColorP(this.X0Y0_ハイライト1, this.ハイライト1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ハイライト2CP = new ColorP(this.X0Y0_ハイライト2, this.ハイライト2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_パンストCP = new ColorP(this.X0Y0_パンスト, this.パンストCD, CS$<>8__locals1.DisUnit, false);
			this.X0Y0_パンスト_ハイライトCP = new ColorP(this.X0Y0_パンスト_ハイライト, this.パンスト_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ニ\u30FCハイ_ニ\u30FCハイ1CP = new ColorP(this.X0Y0_ニ\u30FCハイ_ニ\u30FCハイ1, this.ニ\u30FCハイ_ニ\u30FCハイ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ニ\u30FCハイ_ニ\u30FCハイ2CP = new ColorP(this.X0Y0_ニ\u30FCハイ_ニ\u30FCハイ2, this.ニ\u30FCハイ_ニ\u30FCハイ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_ニ\u30FCハイ_ハイライトCP = new ColorP(this.X0Y0_ニ\u30FCハイ_ハイライト, this.ニ\u30FCハイ_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_腿CP = new ColorP(this.X0Y1_腿, this.腿1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_筋CP = new ColorP(this.X0Y1_筋, this.筋CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y1_獣性_獣毛1CP = new ColorP(this.X0Y1_獣性_獣毛1, this.獣性_獣毛1_1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_獣性_獣毛2CP = new ColorP(this.X0Y1_獣性_獣毛2, this.獣性_獣毛2_1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左CP = new ColorP(this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左, this.淫タトゥ_ハ\u30FCト_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右CP = new ColorP(this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右, this.淫タトゥ_ハ\u30FCト_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_タトゥ左1CP = new ColorP(this.X0Y1_淫タトゥ_タトゥ左1, this.淫タトゥ_タトゥ左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_タトゥ右1CP = new ColorP(this.X0Y1_淫タトゥ_タトゥ右1, this.淫タトゥ_タトゥ右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_タトゥ左2CP = new ColorP(this.X0Y1_淫タトゥ_タトゥ左2, this.淫タトゥ_タトゥ左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_淫タトゥ_タトゥ右2CP = new ColorP(this.X0Y1_淫タトゥ_タトゥ右2, this.淫タトゥ_タトゥ右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ1_文字_文字a_枠CP = new ColorP(this.X0Y1_悪タトゥ1_文字_文字a_枠, this.悪タトゥ1_文字_文字a_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ1_文字_文字a_文字タトゥ1CP = new ColorP(this.X0Y1_悪タトゥ1_文字_文字a_文字タトゥ1, this.悪タトゥ1_文字_文字a_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ1_文字_文字a_文字タトゥ2CP = new ColorP(this.X0Y1_悪タトゥ1_文字_文字a_文字タトゥ2, this.悪タトゥ1_文字_文字a_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ1_文字_文字b_枠CP = new ColorP(this.X0Y1_悪タトゥ1_文字_文字b_枠, this.悪タトゥ1_文字_文字b_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ1_文字_文字b_文字タトゥ1CP = new ColorP(this.X0Y1_悪タトゥ1_文字_文字b_文字タトゥ1, this.悪タトゥ1_文字_文字b_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ1_文字_文字b_文字タトゥ2CP = new ColorP(this.X0Y1_悪タトゥ1_文字_文字b_文字タトゥ2, this.悪タトゥ1_文字_文字b_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ1_文字_文字c_枠CP = new ColorP(this.X0Y1_悪タトゥ1_文字_文字c_枠, this.悪タトゥ1_文字_文字c_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ1_文字_文字c_文字タトゥ1CP = new ColorP(this.X0Y1_悪タトゥ1_文字_文字c_文字タトゥ1, this.悪タトゥ1_文字_文字c_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ1_文字_文字c_文字タトゥ2CP = new ColorP(this.X0Y1_悪タトゥ1_文字_文字c_文字タトゥ2, this.悪タトゥ1_文字_文字c_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ1_文字_文字d_枠CP = new ColorP(this.X0Y1_悪タトゥ1_文字_文字d_枠, this.悪タトゥ1_文字_文字d_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ1_文字_文字d_文字タトゥ1CP = new ColorP(this.X0Y1_悪タトゥ1_文字_文字d_文字タトゥ1, this.悪タトゥ1_文字_文字d_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ1_文字_文字d_文字タトゥ2CP = new ColorP(this.X0Y1_悪タトゥ1_文字_文字d_文字タトゥ2, this.悪タトゥ1_文字_文字d_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ1_文字_文字e_枠CP = new ColorP(this.X0Y1_悪タトゥ1_文字_文字e_枠, this.悪タトゥ1_文字_文字e_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ1_文字_文字e_文字タトゥ1CP = new ColorP(this.X0Y1_悪タトゥ1_文字_文字e_文字タトゥ1, this.悪タトゥ1_文字_文字e_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ1_文字_文字e_文字タトゥ2CP = new ColorP(this.X0Y1_悪タトゥ1_文字_文字e_文字タトゥ2, this.悪タトゥ1_文字_文字e_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ1_文字_文字e_文字タトゥ3CP = new ColorP(this.X0Y1_悪タトゥ1_文字_文字e_文字タトゥ3, this.悪タトゥ1_文字_文字e_文字タトゥ3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ1_タトゥ1CP = new ColorP(this.X0Y1_悪タトゥ1_タトゥ1, this.悪タトゥ1_タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ1_タトゥ2CP = new ColorP(this.X0Y1_悪タトゥ1_タトゥ2, this.悪タトゥ1_タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ2_逆十字_逆十字1CP = new ColorP(this.X0Y1_悪タトゥ2_逆十字_逆十字1, this.悪タトゥ2_逆十字_逆十字1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_悪タトゥ2_逆十字_逆十字2CP = new ColorP(this.X0Y1_悪タトゥ2_逆十字_逆十字2, this.悪タトゥ2_逆十字_逆十字2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_鱗_鱗1CP = new ColorP(this.X0Y1_鱗_鱗1, this.竜性_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_鱗_鱗2CP = new ColorP(this.X0Y1_鱗_鱗2, this.竜性_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_鱗_鱗3CP = new ColorP(this.X0Y1_鱗_鱗3, this.竜性_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_鱗_鱗4CP = new ColorP(this.X0Y1_鱗_鱗4, this.竜性_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_紋柄_紋1CP = new ColorP(this.X0Y1_紋柄_紋1, this.紋柄_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_紋柄_紋2CP = new ColorP(this.X0Y1_紋柄_紋2, this.紋柄_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_紋柄_紋3CP = new ColorP(this.X0Y1_紋柄_紋3, this.紋柄_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_紋柄_紋4CP = new ColorP(this.X0Y1_紋柄_紋4, this.紋柄_紋4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_植性_通常_葉3CP = new ColorP(this.X0Y1_植性_通常_葉3, this.植性_葉3_1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_植性_通常_葉2CP = new ColorP(this.X0Y1_植性_通常_葉2, this.植性_葉2_1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_植性_通常_葉1CP = new ColorP(this.X0Y1_植性_通常_葉1, this.植性_葉1_1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_植性_欠損_葉3CP = new ColorP(this.X0Y1_植性_欠損_葉3, this.植性_葉3_1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_植性_欠損_葉2CP = new ColorP(this.X0Y1_植性_欠損_葉2, this.植性_葉2_1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_植性_欠損_葉1CP = new ColorP(this.X0Y1_植性_欠損_葉1, this.植性_葉1_1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_虫性_器官1CP = new ColorP(this.X0Y1_虫性_器官1, this.虫性_器官1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_虫性_器官2CP = new ColorP(this.X0Y1_虫性_器官2, this.虫性_器官2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_傷I1CP = new ColorP(this.X0Y1_傷I1, this.傷I1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_傷I2CP = new ColorP(this.X0Y1_傷I2, this.傷I2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_傷I3CP = new ColorP(this.X0Y1_傷I3, this.傷I3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_傷I4CP = new ColorP(this.X0Y1_傷I4, this.傷I4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_傷XCP = new ColorP(this.X0Y1_傷X, this.傷XCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ハイライト1CP = new ColorP(this.X0Y1_ハイライト1, this.ハイライト1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ハイライト2CP = new ColorP(this.X0Y1_ハイライト2, this.ハイライト2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_パンストCP = new ColorP(this.X0Y1_パンスト, this.パンストCD, CS$<>8__locals1.DisUnit, false);
			this.X0Y1_パンスト_ハイライトCP = new ColorP(this.X0Y1_パンスト_ハイライト, this.パンスト_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ニ\u30FCハイ_ニ\u30FCハイ1CP = new ColorP(this.X0Y1_ニ\u30FCハイ_ニ\u30FCハイ1, this.ニ\u30FCハイ_ニ\u30FCハイ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ニ\u30FCハイ_ニ\u30FCハイ2CP = new ColorP(this.X0Y1_ニ\u30FCハイ_ニ\u30FCハイ2, this.ニ\u30FCハイ_ニ\u30FCハイ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y1_ニ\u30FCハイ_ハイライトCP = new ColorP(this.X0Y1_ニ\u30FCハイ_ハイライト, this.ニ\u30FCハイ_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_腿CP = new ColorP(this.X0Y2_腿, this.腿2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_筋CP = new ColorP(this.X0Y2_筋, this.筋CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y2_獣性_獣毛1CP = new ColorP(this.X0Y2_獣性_獣毛1, this.獣性_獣毛1_2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_獣性_獣毛2CP = new ColorP(this.X0Y2_獣性_獣毛2, this.獣性_獣毛2_2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左CP = new ColorP(this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左, this.淫タトゥ_ハ\u30FCト_タトゥ左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右CP = new ColorP(this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右, this.淫タトゥ_ハ\u30FCト_タトゥ右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_淫タトゥ_タトゥ右1CP = new ColorP(this.X0Y2_淫タトゥ_タトゥ右1, this.淫タトゥ_タトゥ右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_淫タトゥ_タトゥ右2CP = new ColorP(this.X0Y2_淫タトゥ_タトゥ右2, this.淫タトゥ_タトゥ右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_悪タトゥ1_文字_文字b_枠CP = new ColorP(this.X0Y2_悪タトゥ1_文字_文字b_枠, this.悪タトゥ1_文字_文字b_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_悪タトゥ1_文字_文字b_文字タトゥ1CP = new ColorP(this.X0Y2_悪タトゥ1_文字_文字b_文字タトゥ1, this.悪タトゥ1_文字_文字b_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_悪タトゥ1_文字_文字b_文字タトゥ2CP = new ColorP(this.X0Y2_悪タトゥ1_文字_文字b_文字タトゥ2, this.悪タトゥ1_文字_文字b_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_悪タトゥ1_文字_文字c_枠CP = new ColorP(this.X0Y2_悪タトゥ1_文字_文字c_枠, this.悪タトゥ1_文字_文字c_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_悪タトゥ1_文字_文字c_文字タトゥ1CP = new ColorP(this.X0Y2_悪タトゥ1_文字_文字c_文字タトゥ1, this.悪タトゥ1_文字_文字c_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_悪タトゥ1_文字_文字c_文字タトゥ2CP = new ColorP(this.X0Y2_悪タトゥ1_文字_文字c_文字タトゥ2, this.悪タトゥ1_文字_文字c_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_悪タトゥ1_文字_文字d_枠CP = new ColorP(this.X0Y2_悪タトゥ1_文字_文字d_枠, this.悪タトゥ1_文字_文字d_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_悪タトゥ1_文字_文字d_文字タトゥ1CP = new ColorP(this.X0Y2_悪タトゥ1_文字_文字d_文字タトゥ1, this.悪タトゥ1_文字_文字d_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_悪タトゥ1_文字_文字d_文字タトゥ2CP = new ColorP(this.X0Y2_悪タトゥ1_文字_文字d_文字タトゥ2, this.悪タトゥ1_文字_文字d_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_悪タトゥ1_文字_文字e_枠CP = new ColorP(this.X0Y2_悪タトゥ1_文字_文字e_枠, this.悪タトゥ1_文字_文字e_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_悪タトゥ1_文字_文字e_文字タトゥ1CP = new ColorP(this.X0Y2_悪タトゥ1_文字_文字e_文字タトゥ1, this.悪タトゥ1_文字_文字e_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_悪タトゥ1_文字_文字e_文字タトゥ2CP = new ColorP(this.X0Y2_悪タトゥ1_文字_文字e_文字タトゥ2, this.悪タトゥ1_文字_文字e_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_悪タトゥ1_文字_文字e_文字タトゥ3CP = new ColorP(this.X0Y2_悪タトゥ1_文字_文字e_文字タトゥ3, this.悪タトゥ1_文字_文字e_文字タトゥ3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_悪タトゥ1_文字_文字a_枠CP = new ColorP(this.X0Y2_悪タトゥ1_文字_文字a_枠, this.悪タトゥ1_文字_文字a_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_悪タトゥ1_文字_文字a_文字タトゥ1CP = new ColorP(this.X0Y2_悪タトゥ1_文字_文字a_文字タトゥ1, this.悪タトゥ1_文字_文字a_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_悪タトゥ1_文字_文字a_文字タトゥ2CP = new ColorP(this.X0Y2_悪タトゥ1_文字_文字a_文字タトゥ2, this.悪タトゥ1_文字_文字a_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_悪タトゥ1_タトゥ1CP = new ColorP(this.X0Y2_悪タトゥ1_タトゥ1, this.悪タトゥ1_タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_悪タトゥ1_タトゥ2CP = new ColorP(this.X0Y2_悪タトゥ1_タトゥ2, this.悪タトゥ1_タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_悪タトゥ2_逆十字_逆十字1CP = new ColorP(this.X0Y2_悪タトゥ2_逆十字_逆十字1, this.悪タトゥ2_逆十字_逆十字1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_悪タトゥ2_逆十字_逆十字2CP = new ColorP(this.X0Y2_悪タトゥ2_逆十字_逆十字2, this.悪タトゥ2_逆十字_逆十字2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_植性_通常_葉3CP = new ColorP(this.X0Y2_植性_通常_葉3, this.植性_葉3_2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_植性_通常_葉2CP = new ColorP(this.X0Y2_植性_通常_葉2, this.植性_葉2_2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_植性_通常_葉1CP = new ColorP(this.X0Y2_植性_通常_葉1, this.植性_葉1_2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_植性_欠損_葉3CP = new ColorP(this.X0Y2_植性_欠損_葉3, this.植性_葉3_2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_植性_欠損_葉2CP = new ColorP(this.X0Y2_植性_欠損_葉2, this.植性_葉2_2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_植性_欠損_葉1CP = new ColorP(this.X0Y2_植性_欠損_葉1, this.植性_葉1_2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_傷I1CP = new ColorP(this.X0Y2_傷I1, this.傷I1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_傷I2CP = new ColorP(this.X0Y2_傷I2, this.傷I2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_傷I3CP = new ColorP(this.X0Y2_傷I3, this.傷I3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_ハイライト1CP = new ColorP(this.X0Y2_ハイライト1, this.ハイライト1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_ハイライト2CP = new ColorP(this.X0Y2_ハイライト2, this.ハイライト2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_パンストCP = new ColorP(this.X0Y2_パンスト, this.パンストCD, CS$<>8__locals1.DisUnit, false);
			this.X0Y2_パンスト_ハイライトCP = new ColorP(this.X0Y2_パンスト_ハイライト, this.パンスト_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_ニ\u30FCハイ_ニ\u30FCハイ1CP = new ColorP(this.X0Y2_ニ\u30FCハイ_ニ\u30FCハイ1, this.ニ\u30FCハイ_ニ\u30FCハイ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_ニ\u30FCハイ_ニ\u30FCハイ2CP = new ColorP(this.X0Y2_ニ\u30FCハイ_ニ\u30FCハイ2, this.ニ\u30FCハイ_ニ\u30FCハイ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y2_ニ\u30FCハイ_ハイライトCP = new ColorP(this.X0Y2_ニ\u30FCハイ_ハイライト, this.ニ\u30FCハイ_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_腿CP = new ColorP(this.X0Y3_腿, this.腿3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_筋CP = new ColorP(this.X0Y3_筋, this.筋CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y3_獣性_獣毛1CP = new ColorP(this.X0Y3_獣性_獣毛1, this.獣性_獣毛1_3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_獣性_獣毛2CP = new ColorP(this.X0Y3_獣性_獣毛2, this.獣性_獣毛2_3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_淫タトゥ_タトゥ左1CP = new ColorP(this.X0Y3_淫タトゥ_タトゥ左1, this.淫タトゥ_タトゥ左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_淫タトゥ_タトゥ右1CP = new ColorP(this.X0Y3_淫タトゥ_タトゥ右1, this.淫タトゥ_タトゥ右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_淫タトゥ_タトゥ左2CP = new ColorP(this.X0Y3_淫タトゥ_タトゥ左2, this.淫タトゥ_タトゥ左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_淫タトゥ_タトゥ右2CP = new ColorP(this.X0Y3_淫タトゥ_タトゥ右2, this.淫タトゥ_タトゥ右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_悪タトゥ1_文字_文字c_枠CP = new ColorP(this.X0Y3_悪タトゥ1_文字_文字c_枠, this.悪タトゥ1_文字_文字c_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_悪タトゥ1_文字_文字c_文字タトゥ1CP = new ColorP(this.X0Y3_悪タトゥ1_文字_文字c_文字タトゥ1, this.悪タトゥ1_文字_文字c_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_悪タトゥ1_文字_文字c_文字タトゥ2CP = new ColorP(this.X0Y3_悪タトゥ1_文字_文字c_文字タトゥ2, this.悪タトゥ1_文字_文字c_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_悪タトゥ1_文字_文字d_枠CP = new ColorP(this.X0Y3_悪タトゥ1_文字_文字d_枠, this.悪タトゥ1_文字_文字d_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_悪タトゥ1_文字_文字d_文字タトゥ1CP = new ColorP(this.X0Y3_悪タトゥ1_文字_文字d_文字タトゥ1, this.悪タトゥ1_文字_文字d_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_悪タトゥ1_文字_文字d_文字タトゥ2CP = new ColorP(this.X0Y3_悪タトゥ1_文字_文字d_文字タトゥ2, this.悪タトゥ1_文字_文字d_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_悪タトゥ1_文字_文字e_枠CP = new ColorP(this.X0Y3_悪タトゥ1_文字_文字e_枠, this.悪タトゥ1_文字_文字e_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_悪タトゥ1_文字_文字e_文字タトゥ1CP = new ColorP(this.X0Y3_悪タトゥ1_文字_文字e_文字タトゥ1, this.悪タトゥ1_文字_文字e_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_悪タトゥ1_文字_文字e_文字タトゥ2CP = new ColorP(this.X0Y3_悪タトゥ1_文字_文字e_文字タトゥ2, this.悪タトゥ1_文字_文字e_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_悪タトゥ1_文字_文字e_文字タトゥ3CP = new ColorP(this.X0Y3_悪タトゥ1_文字_文字e_文字タトゥ3, this.悪タトゥ1_文字_文字e_文字タトゥ3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_悪タトゥ1_文字_文字a_枠CP = new ColorP(this.X0Y3_悪タトゥ1_文字_文字a_枠, this.悪タトゥ1_文字_文字a_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_悪タトゥ1_文字_文字a_文字タトゥ1CP = new ColorP(this.X0Y3_悪タトゥ1_文字_文字a_文字タトゥ1, this.悪タトゥ1_文字_文字a_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_悪タトゥ1_文字_文字a_文字タトゥ2CP = new ColorP(this.X0Y3_悪タトゥ1_文字_文字a_文字タトゥ2, this.悪タトゥ1_文字_文字a_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_悪タトゥ1_文字_文字b_枠CP = new ColorP(this.X0Y3_悪タトゥ1_文字_文字b_枠, this.悪タトゥ1_文字_文字b_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_悪タトゥ1_文字_文字b_文字タトゥ1CP = new ColorP(this.X0Y3_悪タトゥ1_文字_文字b_文字タトゥ1, this.悪タトゥ1_文字_文字b_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_悪タトゥ1_文字_文字b_文字タトゥ2CP = new ColorP(this.X0Y3_悪タトゥ1_文字_文字b_文字タトゥ2, this.悪タトゥ1_文字_文字b_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_悪タトゥ1_タトゥ1CP = new ColorP(this.X0Y3_悪タトゥ1_タトゥ1, this.悪タトゥ1_タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_悪タトゥ1_タトゥ2CP = new ColorP(this.X0Y3_悪タトゥ1_タトゥ2, this.悪タトゥ1_タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_悪タトゥ2_逆十字_逆十字1CP = new ColorP(this.X0Y3_悪タトゥ2_逆十字_逆十字1, this.悪タトゥ2_逆十字_逆十字1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_悪タトゥ2_逆十字_逆十字2CP = new ColorP(this.X0Y3_悪タトゥ2_逆十字_逆十字2, this.悪タトゥ2_逆十字_逆十字2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_鱗_鱗1CP = new ColorP(this.X0Y3_鱗_鱗1, this.竜性_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_鱗_鱗2CP = new ColorP(this.X0Y3_鱗_鱗2, this.竜性_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_鱗_鱗3CP = new ColorP(this.X0Y3_鱗_鱗3, this.竜性_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_鱗_鱗4CP = new ColorP(this.X0Y3_鱗_鱗4, this.竜性_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_紋柄_紋1CP = new ColorP(this.X0Y3_紋柄_紋1, this.紋柄_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_紋柄_紋2CP = new ColorP(this.X0Y3_紋柄_紋2, this.紋柄_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_紋柄_紋3CP = new ColorP(this.X0Y3_紋柄_紋3, this.紋柄_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_紋柄_紋4CP = new ColorP(this.X0Y3_紋柄_紋4, this.紋柄_紋4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_植性_通常_葉3CP = new ColorP(this.X0Y3_植性_通常_葉3, this.植性_葉3_3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_植性_通常_葉2CP = new ColorP(this.X0Y3_植性_通常_葉2, this.植性_葉2_3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_植性_通常_葉1CP = new ColorP(this.X0Y3_植性_通常_葉1, this.植性_葉1_3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_植性_欠損_葉3CP = new ColorP(this.X0Y3_植性_欠損_葉3, this.植性_葉3_3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_植性_欠損_葉2CP = new ColorP(this.X0Y3_植性_欠損_葉2, this.植性_葉2_3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_植性_欠損_葉1CP = new ColorP(this.X0Y3_植性_欠損_葉1, this.植性_葉1_3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_傷I1CP = new ColorP(this.X0Y3_傷I1, this.傷I1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_傷I2CP = new ColorP(this.X0Y3_傷I2, this.傷I2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_傷I3CP = new ColorP(this.X0Y3_傷I3, this.傷I3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_傷XCP = new ColorP(this.X0Y3_傷X, this.傷XCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_ハイライト1CP = new ColorP(this.X0Y3_ハイライト1, this.ハイライト1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_ハイライト2CP = new ColorP(this.X0Y3_ハイライト2, this.ハイライト2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_パンストCP = new ColorP(this.X0Y3_パンスト, this.パンストCD, CS$<>8__locals1.DisUnit, false);
			this.X0Y3_パンスト_ハイライトCP = new ColorP(this.X0Y3_パンスト_ハイライト, this.パンスト_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_ニ\u30FCハイ_ニ\u30FCハイ1CP = new ColorP(this.X0Y3_ニ\u30FCハイ_ニ\u30FCハイ1, this.ニ\u30FCハイ_ニ\u30FCハイ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_ニ\u30FCハイ_ニ\u30FCハイ2CP = new ColorP(this.X0Y3_ニ\u30FCハイ_ニ\u30FCハイ2, this.ニ\u30FCハイ_ニ\u30FCハイ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y3_ニ\u30FCハイ_ハイライトCP = new ColorP(this.X0Y3_ニ\u30FCハイ_ハイライト, this.ニ\u30FCハイ_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_腿CP = new ColorP(this.X0Y4_腿, this.腿4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_筋CP = new ColorP(this.X0Y4_筋, this.筋CD, CS$<>8__locals1.DisUnit, false);
			this.X0Y4_獣性_獣毛1CP = new ColorP(this.X0Y4_獣性_獣毛1, this.獣性_獣毛1_4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_獣性_獣毛2CP = new ColorP(this.X0Y4_獣性_獣毛2, this.獣性_獣毛2_4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_淫タトゥ_タトゥ左1CP = new ColorP(this.X0Y4_淫タトゥ_タトゥ左1, this.淫タトゥ_タトゥ左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_淫タトゥ_タトゥ右1CP = new ColorP(this.X0Y4_淫タトゥ_タトゥ右1, this.淫タトゥ_タトゥ右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_淫タトゥ_タトゥ左2CP = new ColorP(this.X0Y4_淫タトゥ_タトゥ左2, this.淫タトゥ_タトゥ左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_淫タトゥ_タトゥ右2CP = new ColorP(this.X0Y4_淫タトゥ_タトゥ右2, this.淫タトゥ_タトゥ右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_悪タトゥ1_文字_文字d_枠CP = new ColorP(this.X0Y4_悪タトゥ1_文字_文字d_枠, this.悪タトゥ1_文字_文字d_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_悪タトゥ1_文字_文字d_文字タトゥ1CP = new ColorP(this.X0Y4_悪タトゥ1_文字_文字d_文字タトゥ1, this.悪タトゥ1_文字_文字d_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_悪タトゥ1_文字_文字d_文字タトゥ2CP = new ColorP(this.X0Y4_悪タトゥ1_文字_文字d_文字タトゥ2, this.悪タトゥ1_文字_文字d_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_悪タトゥ1_文字_文字e_枠CP = new ColorP(this.X0Y4_悪タトゥ1_文字_文字e_枠, this.悪タトゥ1_文字_文字e_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_悪タトゥ1_文字_文字e_文字タトゥ1CP = new ColorP(this.X0Y4_悪タトゥ1_文字_文字e_文字タトゥ1, this.悪タトゥ1_文字_文字e_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_悪タトゥ1_文字_文字e_文字タトゥ2CP = new ColorP(this.X0Y4_悪タトゥ1_文字_文字e_文字タトゥ2, this.悪タトゥ1_文字_文字e_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_悪タトゥ1_文字_文字e_文字タトゥ3CP = new ColorP(this.X0Y4_悪タトゥ1_文字_文字e_文字タトゥ3, this.悪タトゥ1_文字_文字e_文字タトゥ3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_悪タトゥ1_文字_文字a_枠CP = new ColorP(this.X0Y4_悪タトゥ1_文字_文字a_枠, this.悪タトゥ1_文字_文字a_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_悪タトゥ1_文字_文字a_文字タトゥ1CP = new ColorP(this.X0Y4_悪タトゥ1_文字_文字a_文字タトゥ1, this.悪タトゥ1_文字_文字a_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_悪タトゥ1_文字_文字a_文字タトゥ2CP = new ColorP(this.X0Y4_悪タトゥ1_文字_文字a_文字タトゥ2, this.悪タトゥ1_文字_文字a_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_悪タトゥ1_文字_文字b_枠CP = new ColorP(this.X0Y4_悪タトゥ1_文字_文字b_枠, this.悪タトゥ1_文字_文字b_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_悪タトゥ1_文字_文字b_文字タトゥ1CP = new ColorP(this.X0Y4_悪タトゥ1_文字_文字b_文字タトゥ1, this.悪タトゥ1_文字_文字b_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_悪タトゥ1_文字_文字b_文字タトゥ2CP = new ColorP(this.X0Y4_悪タトゥ1_文字_文字b_文字タトゥ2, this.悪タトゥ1_文字_文字b_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_悪タトゥ1_文字_文字c_枠CP = new ColorP(this.X0Y4_悪タトゥ1_文字_文字c_枠, this.悪タトゥ1_文字_文字c_枠CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_悪タトゥ1_文字_文字c_文字タトゥ1CP = new ColorP(this.X0Y4_悪タトゥ1_文字_文字c_文字タトゥ1, this.悪タトゥ1_文字_文字c_文字タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_悪タトゥ1_文字_文字c_文字タトゥ2CP = new ColorP(this.X0Y4_悪タトゥ1_文字_文字c_文字タトゥ2, this.悪タトゥ1_文字_文字c_文字タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_悪タトゥ1_タトゥ1CP = new ColorP(this.X0Y4_悪タトゥ1_タトゥ1, this.悪タトゥ1_タトゥ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_悪タトゥ1_タトゥ2CP = new ColorP(this.X0Y4_悪タトゥ1_タトゥ2, this.悪タトゥ1_タトゥ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_鱗_鱗1CP = new ColorP(this.X0Y4_鱗_鱗1, this.竜性_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_鱗_鱗2CP = new ColorP(this.X0Y4_鱗_鱗2, this.竜性_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_鱗_鱗3CP = new ColorP(this.X0Y4_鱗_鱗3, this.竜性_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_鱗_鱗4CP = new ColorP(this.X0Y4_鱗_鱗4, this.竜性_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_紋柄_紋1CP = new ColorP(this.X0Y4_紋柄_紋1, this.紋柄_紋1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_紋柄_紋2CP = new ColorP(this.X0Y4_紋柄_紋2, this.紋柄_紋2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_紋柄_紋3CP = new ColorP(this.X0Y4_紋柄_紋3, this.紋柄_紋3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_紋柄_紋4CP = new ColorP(this.X0Y4_紋柄_紋4, this.紋柄_紋4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_植性_通常_葉3CP = new ColorP(this.X0Y4_植性_通常_葉3, this.植性_葉3_4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_植性_通常_葉2CP = new ColorP(this.X0Y4_植性_通常_葉2, this.植性_葉2_4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_植性_通常_葉1CP = new ColorP(this.X0Y4_植性_通常_葉1, this.植性_葉1_4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_植性_欠損_葉3CP = new ColorP(this.X0Y4_植性_欠損_葉3, this.植性_葉3_4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_植性_欠損_葉2CP = new ColorP(this.X0Y4_植性_欠損_葉2, this.植性_葉2_4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_植性_欠損_葉1CP = new ColorP(this.X0Y4_植性_欠損_葉1, this.植性_葉1_4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_傷I1CP = new ColorP(this.X0Y4_傷I1, this.傷I1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_傷XCP = new ColorP(this.X0Y4_傷X, this.傷XCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_ハイライト1CP = new ColorP(this.X0Y4_ハイライト1, this.ハイライト1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_ハイライト2CP = new ColorP(this.X0Y4_ハイライト2, this.ハイライト2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_パンストCP = new ColorP(this.X0Y4_パンスト, this.パンストCD, CS$<>8__locals1.DisUnit, false);
			this.X0Y4_パンスト_ハイライトCP = new ColorP(this.X0Y4_パンスト_ハイライト, this.パンスト_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_ニ\u30FCハイ_ニ\u30FCハイ1CP = new ColorP(this.X0Y4_ニ\u30FCハイ_ニ\u30FCハイ1, this.ニ\u30FCハイ_ニ\u30FCハイ1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_ニ\u30FCハイ_ニ\u30FCハイ2CP = new ColorP(this.X0Y4_ニ\u30FCハイ_ニ\u30FCハイ2, this.ニ\u30FCハイ_ニ\u30FCハイ2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y4_ニ\u30FCハイ_ハイライトCP = new ColorP(this.X0Y4_ニ\u30FCハイ_ハイライト, this.ニ\u30FCハイ_ハイライトCD, CS$<>8__locals1.DisUnit, true);
			if (e.スライム)
			{
				this.スライム();
			}
			this.筋肉濃度 = e.筋肉濃度;
			this.傷I1濃度 = e.傷I1濃度;
			this.傷I2濃度 = e.傷I2濃度;
			this.傷I3濃度 = e.傷I3濃度;
			this.傷I4濃度 = e.傷I4濃度;
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
			}
		}

		public bool 腿_表示
		{
			get
			{
				return this.X0Y0_腿.Dra;
			}
			set
			{
				this.X0Y0_腿.Dra = value;
				this.X0Y1_腿.Dra = value;
				this.X0Y2_腿.Dra = value;
				this.X0Y3_腿.Dra = value;
				this.X0Y4_腿.Dra = value;
				this.X0Y0_腿.Hit = value;
				this.X0Y1_腿.Hit = value;
				this.X0Y2_腿.Hit = value;
				this.X0Y3_腿.Hit = value;
				this.X0Y4_腿.Hit = value;
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
				this.X0Y2_筋.Dra = value;
				this.X0Y3_筋.Dra = value;
				this.X0Y4_筋.Dra = value;
				this.X0Y0_筋.Hit = value;
				this.X0Y1_筋.Hit = value;
				this.X0Y2_筋.Hit = value;
				this.X0Y3_筋.Hit = value;
				this.X0Y4_筋.Hit = value;
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
				this.X0Y2_獣性_獣毛1.Dra = value;
				this.X0Y3_獣性_獣毛1.Dra = value;
				this.X0Y4_獣性_獣毛1.Dra = value;
				this.X0Y0_獣性_獣毛1.Hit = value;
				this.X0Y1_獣性_獣毛1.Hit = value;
				this.X0Y2_獣性_獣毛1.Hit = value;
				this.X0Y3_獣性_獣毛1.Hit = value;
				this.X0Y4_獣性_獣毛1.Hit = value;
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
				this.X0Y2_獣性_獣毛2.Dra = value;
				this.X0Y3_獣性_獣毛2.Dra = value;
				this.X0Y4_獣性_獣毛2.Dra = value;
				this.X0Y0_獣性_獣毛2.Hit = value;
				this.X0Y1_獣性_獣毛2.Hit = value;
				this.X0Y2_獣性_獣毛2.Hit = value;
				this.X0Y3_獣性_獣毛2.Hit = value;
				this.X0Y4_獣性_獣毛2.Hit = value;
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
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左.Dra = value;
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左.Hit = value;
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左.Hit = value;
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左.Hit = value;
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
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右.Dra = value;
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右.Hit = value;
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右.Hit = value;
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右.Hit = value;
			}
		}

		public bool 淫タトゥ_タトゥ左1_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_タトゥ左1.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_タトゥ左1.Dra = value;
				this.X0Y1_淫タトゥ_タトゥ左1.Dra = value;
				this.X0Y3_淫タトゥ_タトゥ左1.Dra = value;
				this.X0Y4_淫タトゥ_タトゥ左1.Dra = value;
				this.X0Y0_淫タトゥ_タトゥ左1.Hit = value;
				this.X0Y1_淫タトゥ_タトゥ左1.Hit = value;
				this.X0Y3_淫タトゥ_タトゥ左1.Hit = value;
				this.X0Y4_淫タトゥ_タトゥ左1.Hit = value;
			}
		}

		public bool 淫タトゥ_タトゥ右1_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_タトゥ右1.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_タトゥ右1.Dra = value;
				this.X0Y1_淫タトゥ_タトゥ右1.Dra = value;
				this.X0Y2_淫タトゥ_タトゥ右1.Dra = value;
				this.X0Y3_淫タトゥ_タトゥ右1.Dra = value;
				this.X0Y4_淫タトゥ_タトゥ右1.Dra = value;
				this.X0Y0_淫タトゥ_タトゥ右1.Hit = value;
				this.X0Y1_淫タトゥ_タトゥ右1.Hit = value;
				this.X0Y2_淫タトゥ_タトゥ右1.Hit = value;
				this.X0Y3_淫タトゥ_タトゥ右1.Hit = value;
				this.X0Y4_淫タトゥ_タトゥ右1.Hit = value;
			}
		}

		public bool 淫タトゥ_タトゥ左2_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_タトゥ左2.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_タトゥ左2.Dra = value;
				this.X0Y1_淫タトゥ_タトゥ左2.Dra = value;
				this.X0Y3_淫タトゥ_タトゥ左2.Dra = value;
				this.X0Y4_淫タトゥ_タトゥ左2.Dra = value;
				this.X0Y0_淫タトゥ_タトゥ左2.Hit = value;
				this.X0Y1_淫タトゥ_タトゥ左2.Hit = value;
				this.X0Y3_淫タトゥ_タトゥ左2.Hit = value;
				this.X0Y4_淫タトゥ_タトゥ左2.Hit = value;
			}
		}

		public bool 淫タトゥ_タトゥ右2_表示
		{
			get
			{
				return this.X0Y0_淫タトゥ_タトゥ右2.Dra;
			}
			set
			{
				this.X0Y0_淫タトゥ_タトゥ右2.Dra = value;
				this.X0Y1_淫タトゥ_タトゥ右2.Dra = value;
				this.X0Y2_淫タトゥ_タトゥ右2.Dra = value;
				this.X0Y3_淫タトゥ_タトゥ右2.Dra = value;
				this.X0Y4_淫タトゥ_タトゥ右2.Dra = value;
				this.X0Y0_淫タトゥ_タトゥ右2.Hit = value;
				this.X0Y1_淫タトゥ_タトゥ右2.Hit = value;
				this.X0Y2_淫タトゥ_タトゥ右2.Hit = value;
				this.X0Y3_淫タトゥ_タトゥ右2.Hit = value;
				this.X0Y4_淫タトゥ_タトゥ右2.Hit = value;
			}
		}

		public bool 悪タトゥ1_文字_文字a_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ1_文字_文字a_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ1_文字_文字a_枠.Dra = value;
				this.X0Y1_悪タトゥ1_文字_文字a_枠.Dra = value;
				this.X0Y2_悪タトゥ1_文字_文字a_枠.Dra = value;
				this.X0Y3_悪タトゥ1_文字_文字a_枠.Dra = value;
				this.X0Y4_悪タトゥ1_文字_文字a_枠.Dra = value;
				this.X0Y0_悪タトゥ1_文字_文字a_枠.Hit = value;
				this.X0Y1_悪タトゥ1_文字_文字a_枠.Hit = value;
				this.X0Y2_悪タトゥ1_文字_文字a_枠.Hit = value;
				this.X0Y3_悪タトゥ1_文字_文字a_枠.Hit = value;
				this.X0Y4_悪タトゥ1_文字_文字a_枠.Hit = value;
			}
		}

		public bool 悪タトゥ1_文字_文字a_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ1_文字_文字a_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ1_文字_文字a_文字タトゥ1.Dra = value;
				this.X0Y1_悪タトゥ1_文字_文字a_文字タトゥ1.Dra = value;
				this.X0Y2_悪タトゥ1_文字_文字a_文字タトゥ1.Dra = value;
				this.X0Y3_悪タトゥ1_文字_文字a_文字タトゥ1.Dra = value;
				this.X0Y4_悪タトゥ1_文字_文字a_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ1_文字_文字a_文字タトゥ1.Hit = value;
				this.X0Y1_悪タトゥ1_文字_文字a_文字タトゥ1.Hit = value;
				this.X0Y2_悪タトゥ1_文字_文字a_文字タトゥ1.Hit = value;
				this.X0Y3_悪タトゥ1_文字_文字a_文字タトゥ1.Hit = value;
				this.X0Y4_悪タトゥ1_文字_文字a_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ1_文字_文字a_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ1_文字_文字a_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ1_文字_文字a_文字タトゥ2.Dra = value;
				this.X0Y1_悪タトゥ1_文字_文字a_文字タトゥ2.Dra = value;
				this.X0Y2_悪タトゥ1_文字_文字a_文字タトゥ2.Dra = value;
				this.X0Y3_悪タトゥ1_文字_文字a_文字タトゥ2.Dra = value;
				this.X0Y4_悪タトゥ1_文字_文字a_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ1_文字_文字a_文字タトゥ2.Hit = value;
				this.X0Y1_悪タトゥ1_文字_文字a_文字タトゥ2.Hit = value;
				this.X0Y2_悪タトゥ1_文字_文字a_文字タトゥ2.Hit = value;
				this.X0Y3_悪タトゥ1_文字_文字a_文字タトゥ2.Hit = value;
				this.X0Y4_悪タトゥ1_文字_文字a_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ1_文字_文字b_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ1_文字_文字b_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ1_文字_文字b_枠.Dra = value;
				this.X0Y1_悪タトゥ1_文字_文字b_枠.Dra = value;
				this.X0Y2_悪タトゥ1_文字_文字b_枠.Dra = value;
				this.X0Y3_悪タトゥ1_文字_文字b_枠.Dra = value;
				this.X0Y4_悪タトゥ1_文字_文字b_枠.Dra = value;
				this.X0Y0_悪タトゥ1_文字_文字b_枠.Hit = value;
				this.X0Y1_悪タトゥ1_文字_文字b_枠.Hit = value;
				this.X0Y2_悪タトゥ1_文字_文字b_枠.Hit = value;
				this.X0Y3_悪タトゥ1_文字_文字b_枠.Hit = value;
				this.X0Y4_悪タトゥ1_文字_文字b_枠.Hit = value;
			}
		}

		public bool 悪タトゥ1_文字_文字b_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ1_文字_文字b_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ1_文字_文字b_文字タトゥ1.Dra = value;
				this.X0Y1_悪タトゥ1_文字_文字b_文字タトゥ1.Dra = value;
				this.X0Y2_悪タトゥ1_文字_文字b_文字タトゥ1.Dra = value;
				this.X0Y3_悪タトゥ1_文字_文字b_文字タトゥ1.Dra = value;
				this.X0Y4_悪タトゥ1_文字_文字b_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ1_文字_文字b_文字タトゥ1.Hit = value;
				this.X0Y1_悪タトゥ1_文字_文字b_文字タトゥ1.Hit = value;
				this.X0Y2_悪タトゥ1_文字_文字b_文字タトゥ1.Hit = value;
				this.X0Y3_悪タトゥ1_文字_文字b_文字タトゥ1.Hit = value;
				this.X0Y4_悪タトゥ1_文字_文字b_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ1_文字_文字b_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ1_文字_文字b_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ1_文字_文字b_文字タトゥ2.Dra = value;
				this.X0Y1_悪タトゥ1_文字_文字b_文字タトゥ2.Dra = value;
				this.X0Y2_悪タトゥ1_文字_文字b_文字タトゥ2.Dra = value;
				this.X0Y3_悪タトゥ1_文字_文字b_文字タトゥ2.Dra = value;
				this.X0Y4_悪タトゥ1_文字_文字b_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ1_文字_文字b_文字タトゥ2.Hit = value;
				this.X0Y1_悪タトゥ1_文字_文字b_文字タトゥ2.Hit = value;
				this.X0Y2_悪タトゥ1_文字_文字b_文字タトゥ2.Hit = value;
				this.X0Y3_悪タトゥ1_文字_文字b_文字タトゥ2.Hit = value;
				this.X0Y4_悪タトゥ1_文字_文字b_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ1_文字_文字c_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ1_文字_文字c_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ1_文字_文字c_枠.Dra = value;
				this.X0Y1_悪タトゥ1_文字_文字c_枠.Dra = value;
				this.X0Y2_悪タトゥ1_文字_文字c_枠.Dra = value;
				this.X0Y3_悪タトゥ1_文字_文字c_枠.Dra = value;
				this.X0Y4_悪タトゥ1_文字_文字c_枠.Dra = value;
				this.X0Y0_悪タトゥ1_文字_文字c_枠.Hit = value;
				this.X0Y1_悪タトゥ1_文字_文字c_枠.Hit = value;
				this.X0Y2_悪タトゥ1_文字_文字c_枠.Hit = value;
				this.X0Y3_悪タトゥ1_文字_文字c_枠.Hit = value;
				this.X0Y4_悪タトゥ1_文字_文字c_枠.Hit = value;
			}
		}

		public bool 悪タトゥ1_文字_文字c_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ1_文字_文字c_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ1_文字_文字c_文字タトゥ1.Dra = value;
				this.X0Y1_悪タトゥ1_文字_文字c_文字タトゥ1.Dra = value;
				this.X0Y2_悪タトゥ1_文字_文字c_文字タトゥ1.Dra = value;
				this.X0Y3_悪タトゥ1_文字_文字c_文字タトゥ1.Dra = value;
				this.X0Y4_悪タトゥ1_文字_文字c_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ1_文字_文字c_文字タトゥ1.Hit = value;
				this.X0Y1_悪タトゥ1_文字_文字c_文字タトゥ1.Hit = value;
				this.X0Y2_悪タトゥ1_文字_文字c_文字タトゥ1.Hit = value;
				this.X0Y3_悪タトゥ1_文字_文字c_文字タトゥ1.Hit = value;
				this.X0Y4_悪タトゥ1_文字_文字c_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ1_文字_文字c_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ1_文字_文字c_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ1_文字_文字c_文字タトゥ2.Dra = value;
				this.X0Y1_悪タトゥ1_文字_文字c_文字タトゥ2.Dra = value;
				this.X0Y2_悪タトゥ1_文字_文字c_文字タトゥ2.Dra = value;
				this.X0Y3_悪タトゥ1_文字_文字c_文字タトゥ2.Dra = value;
				this.X0Y4_悪タトゥ1_文字_文字c_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ1_文字_文字c_文字タトゥ2.Hit = value;
				this.X0Y1_悪タトゥ1_文字_文字c_文字タトゥ2.Hit = value;
				this.X0Y2_悪タトゥ1_文字_文字c_文字タトゥ2.Hit = value;
				this.X0Y3_悪タトゥ1_文字_文字c_文字タトゥ2.Hit = value;
				this.X0Y4_悪タトゥ1_文字_文字c_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ1_文字_文字d_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ1_文字_文字d_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ1_文字_文字d_枠.Dra = value;
				this.X0Y1_悪タトゥ1_文字_文字d_枠.Dra = value;
				this.X0Y2_悪タトゥ1_文字_文字d_枠.Dra = value;
				this.X0Y3_悪タトゥ1_文字_文字d_枠.Dra = value;
				this.X0Y4_悪タトゥ1_文字_文字d_枠.Dra = value;
				this.X0Y0_悪タトゥ1_文字_文字d_枠.Hit = value;
				this.X0Y1_悪タトゥ1_文字_文字d_枠.Hit = value;
				this.X0Y2_悪タトゥ1_文字_文字d_枠.Hit = value;
				this.X0Y3_悪タトゥ1_文字_文字d_枠.Hit = value;
				this.X0Y4_悪タトゥ1_文字_文字d_枠.Hit = value;
			}
		}

		public bool 悪タトゥ1_文字_文字d_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ1_文字_文字d_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ1_文字_文字d_文字タトゥ1.Dra = value;
				this.X0Y1_悪タトゥ1_文字_文字d_文字タトゥ1.Dra = value;
				this.X0Y2_悪タトゥ1_文字_文字d_文字タトゥ1.Dra = value;
				this.X0Y3_悪タトゥ1_文字_文字d_文字タトゥ1.Dra = value;
				this.X0Y4_悪タトゥ1_文字_文字d_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ1_文字_文字d_文字タトゥ1.Hit = value;
				this.X0Y1_悪タトゥ1_文字_文字d_文字タトゥ1.Hit = value;
				this.X0Y2_悪タトゥ1_文字_文字d_文字タトゥ1.Hit = value;
				this.X0Y3_悪タトゥ1_文字_文字d_文字タトゥ1.Hit = value;
				this.X0Y4_悪タトゥ1_文字_文字d_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ1_文字_文字d_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ1_文字_文字d_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ1_文字_文字d_文字タトゥ2.Dra = value;
				this.X0Y1_悪タトゥ1_文字_文字d_文字タトゥ2.Dra = value;
				this.X0Y2_悪タトゥ1_文字_文字d_文字タトゥ2.Dra = value;
				this.X0Y3_悪タトゥ1_文字_文字d_文字タトゥ2.Dra = value;
				this.X0Y4_悪タトゥ1_文字_文字d_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ1_文字_文字d_文字タトゥ2.Hit = value;
				this.X0Y1_悪タトゥ1_文字_文字d_文字タトゥ2.Hit = value;
				this.X0Y2_悪タトゥ1_文字_文字d_文字タトゥ2.Hit = value;
				this.X0Y3_悪タトゥ1_文字_文字d_文字タトゥ2.Hit = value;
				this.X0Y4_悪タトゥ1_文字_文字d_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ1_文字_文字e_枠_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ1_文字_文字e_枠.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ1_文字_文字e_枠.Dra = value;
				this.X0Y1_悪タトゥ1_文字_文字e_枠.Dra = value;
				this.X0Y2_悪タトゥ1_文字_文字e_枠.Dra = value;
				this.X0Y3_悪タトゥ1_文字_文字e_枠.Dra = value;
				this.X0Y4_悪タトゥ1_文字_文字e_枠.Dra = value;
				this.X0Y0_悪タトゥ1_文字_文字e_枠.Hit = value;
				this.X0Y1_悪タトゥ1_文字_文字e_枠.Hit = value;
				this.X0Y2_悪タトゥ1_文字_文字e_枠.Hit = value;
				this.X0Y3_悪タトゥ1_文字_文字e_枠.Hit = value;
				this.X0Y4_悪タトゥ1_文字_文字e_枠.Hit = value;
			}
		}

		public bool 悪タトゥ1_文字_文字e_文字タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ1.Dra = value;
				this.X0Y1_悪タトゥ1_文字_文字e_文字タトゥ1.Dra = value;
				this.X0Y2_悪タトゥ1_文字_文字e_文字タトゥ1.Dra = value;
				this.X0Y3_悪タトゥ1_文字_文字e_文字タトゥ1.Dra = value;
				this.X0Y4_悪タトゥ1_文字_文字e_文字タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ1.Hit = value;
				this.X0Y1_悪タトゥ1_文字_文字e_文字タトゥ1.Hit = value;
				this.X0Y2_悪タトゥ1_文字_文字e_文字タトゥ1.Hit = value;
				this.X0Y3_悪タトゥ1_文字_文字e_文字タトゥ1.Hit = value;
				this.X0Y4_悪タトゥ1_文字_文字e_文字タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ1_文字_文字e_文字タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ2.Dra = value;
				this.X0Y1_悪タトゥ1_文字_文字e_文字タトゥ2.Dra = value;
				this.X0Y2_悪タトゥ1_文字_文字e_文字タトゥ2.Dra = value;
				this.X0Y3_悪タトゥ1_文字_文字e_文字タトゥ2.Dra = value;
				this.X0Y4_悪タトゥ1_文字_文字e_文字タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ2.Hit = value;
				this.X0Y1_悪タトゥ1_文字_文字e_文字タトゥ2.Hit = value;
				this.X0Y2_悪タトゥ1_文字_文字e_文字タトゥ2.Hit = value;
				this.X0Y3_悪タトゥ1_文字_文字e_文字タトゥ2.Hit = value;
				this.X0Y4_悪タトゥ1_文字_文字e_文字タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ1_文字_文字e_文字タトゥ3_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ3.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ3.Dra = value;
				this.X0Y1_悪タトゥ1_文字_文字e_文字タトゥ3.Dra = value;
				this.X0Y2_悪タトゥ1_文字_文字e_文字タトゥ3.Dra = value;
				this.X0Y3_悪タトゥ1_文字_文字e_文字タトゥ3.Dra = value;
				this.X0Y4_悪タトゥ1_文字_文字e_文字タトゥ3.Dra = value;
				this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ3.Hit = value;
				this.X0Y1_悪タトゥ1_文字_文字e_文字タトゥ3.Hit = value;
				this.X0Y2_悪タトゥ1_文字_文字e_文字タトゥ3.Hit = value;
				this.X0Y3_悪タトゥ1_文字_文字e_文字タトゥ3.Hit = value;
				this.X0Y4_悪タトゥ1_文字_文字e_文字タトゥ3.Hit = value;
			}
		}

		public bool 悪タトゥ1_タトゥ1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ1_タトゥ1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ1_タトゥ1.Dra = value;
				this.X0Y1_悪タトゥ1_タトゥ1.Dra = value;
				this.X0Y2_悪タトゥ1_タトゥ1.Dra = value;
				this.X0Y3_悪タトゥ1_タトゥ1.Dra = value;
				this.X0Y4_悪タトゥ1_タトゥ1.Dra = value;
				this.X0Y0_悪タトゥ1_タトゥ1.Hit = value;
				this.X0Y1_悪タトゥ1_タトゥ1.Hit = value;
				this.X0Y2_悪タトゥ1_タトゥ1.Hit = value;
				this.X0Y3_悪タトゥ1_タトゥ1.Hit = value;
				this.X0Y4_悪タトゥ1_タトゥ1.Hit = value;
			}
		}

		public bool 悪タトゥ1_タトゥ2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ1_タトゥ2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ1_タトゥ2.Dra = value;
				this.X0Y1_悪タトゥ1_タトゥ2.Dra = value;
				this.X0Y2_悪タトゥ1_タトゥ2.Dra = value;
				this.X0Y3_悪タトゥ1_タトゥ2.Dra = value;
				this.X0Y4_悪タトゥ1_タトゥ2.Dra = value;
				this.X0Y0_悪タトゥ1_タトゥ2.Hit = value;
				this.X0Y1_悪タトゥ1_タトゥ2.Hit = value;
				this.X0Y2_悪タトゥ1_タトゥ2.Hit = value;
				this.X0Y3_悪タトゥ1_タトゥ2.Hit = value;
				this.X0Y4_悪タトゥ1_タトゥ2.Hit = value;
			}
		}

		public bool 悪タトゥ2_逆十字_逆十字1_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ2_逆十字_逆十字1.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ2_逆十字_逆十字1.Dra = value;
				this.X0Y1_悪タトゥ2_逆十字_逆十字1.Dra = value;
				this.X0Y2_悪タトゥ2_逆十字_逆十字1.Dra = value;
				this.X0Y3_悪タトゥ2_逆十字_逆十字1.Dra = value;
				this.X0Y0_悪タトゥ2_逆十字_逆十字1.Hit = value;
				this.X0Y1_悪タトゥ2_逆十字_逆十字1.Hit = value;
				this.X0Y2_悪タトゥ2_逆十字_逆十字1.Hit = value;
				this.X0Y3_悪タトゥ2_逆十字_逆十字1.Hit = value;
			}
		}

		public bool 悪タトゥ2_逆十字_逆十字2_表示
		{
			get
			{
				return this.X0Y0_悪タトゥ2_逆十字_逆十字2.Dra;
			}
			set
			{
				this.X0Y0_悪タトゥ2_逆十字_逆十字2.Dra = value;
				this.X0Y1_悪タトゥ2_逆十字_逆十字2.Dra = value;
				this.X0Y2_悪タトゥ2_逆十字_逆十字2.Dra = value;
				this.X0Y3_悪タトゥ2_逆十字_逆十字2.Dra = value;
				this.X0Y0_悪タトゥ2_逆十字_逆十字2.Hit = value;
				this.X0Y1_悪タトゥ2_逆十字_逆十字2.Hit = value;
				this.X0Y2_悪タトゥ2_逆十字_逆十字2.Hit = value;
				this.X0Y3_悪タトゥ2_逆十字_逆十字2.Hit = value;
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
				this.X0Y1_鱗_鱗1.Dra = value;
				this.X0Y3_鱗_鱗1.Dra = value;
				this.X0Y4_鱗_鱗1.Dra = value;
				this.X0Y0_竜性_鱗1.Hit = value;
				this.X0Y1_鱗_鱗1.Hit = value;
				this.X0Y3_鱗_鱗1.Hit = value;
				this.X0Y4_鱗_鱗1.Hit = value;
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
				this.X0Y1_鱗_鱗2.Dra = value;
				this.X0Y3_鱗_鱗2.Dra = value;
				this.X0Y4_鱗_鱗2.Dra = value;
				this.X0Y0_竜性_鱗2.Hit = value;
				this.X0Y1_鱗_鱗2.Hit = value;
				this.X0Y3_鱗_鱗2.Hit = value;
				this.X0Y4_鱗_鱗2.Hit = value;
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
				this.X0Y1_鱗_鱗3.Dra = value;
				this.X0Y3_鱗_鱗3.Dra = value;
				this.X0Y4_鱗_鱗3.Dra = value;
				this.X0Y0_竜性_鱗3.Hit = value;
				this.X0Y1_鱗_鱗3.Hit = value;
				this.X0Y3_鱗_鱗3.Hit = value;
				this.X0Y4_鱗_鱗3.Hit = value;
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
				this.X0Y1_鱗_鱗4.Dra = value;
				this.X0Y3_鱗_鱗4.Dra = value;
				this.X0Y4_鱗_鱗4.Dra = value;
				this.X0Y0_竜性_鱗4.Hit = value;
				this.X0Y1_鱗_鱗4.Hit = value;
				this.X0Y3_鱗_鱗4.Hit = value;
				this.X0Y4_鱗_鱗4.Hit = value;
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
				this.X0Y3_紋柄_紋1.Dra = value;
				this.X0Y4_紋柄_紋1.Dra = value;
				this.X0Y0_紋柄_紋1.Hit = value;
				this.X0Y1_紋柄_紋1.Hit = value;
				this.X0Y3_紋柄_紋1.Hit = value;
				this.X0Y4_紋柄_紋1.Hit = value;
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
				this.X0Y3_紋柄_紋2.Dra = value;
				this.X0Y4_紋柄_紋2.Dra = value;
				this.X0Y0_紋柄_紋2.Hit = value;
				this.X0Y1_紋柄_紋2.Hit = value;
				this.X0Y3_紋柄_紋2.Hit = value;
				this.X0Y4_紋柄_紋2.Hit = value;
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
				this.X0Y3_紋柄_紋3.Dra = value;
				this.X0Y4_紋柄_紋3.Dra = value;
				this.X0Y0_紋柄_紋3.Hit = value;
				this.X0Y1_紋柄_紋3.Hit = value;
				this.X0Y3_紋柄_紋3.Hit = value;
				this.X0Y4_紋柄_紋3.Hit = value;
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
				this.X0Y3_紋柄_紋4.Dra = value;
				this.X0Y4_紋柄_紋4.Dra = value;
				this.X0Y0_紋柄_紋4.Hit = value;
				this.X0Y1_紋柄_紋4.Hit = value;
				this.X0Y3_紋柄_紋4.Hit = value;
				this.X0Y4_紋柄_紋4.Hit = value;
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
				this.X0Y1_植性_通常_葉3.Dra = value;
				this.X0Y2_植性_通常_葉3.Dra = value;
				this.X0Y3_植性_通常_葉3.Dra = value;
				this.X0Y4_植性_通常_葉3.Dra = value;
				this.X0Y0_植性_通常_葉3.Hit = value;
				this.X0Y1_植性_通常_葉3.Hit = value;
				this.X0Y2_植性_通常_葉3.Hit = value;
				this.X0Y3_植性_通常_葉3.Hit = value;
				this.X0Y4_植性_通常_葉3.Hit = value;
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
				this.X0Y1_植性_通常_葉2.Dra = value;
				this.X0Y2_植性_通常_葉2.Dra = value;
				this.X0Y3_植性_通常_葉2.Dra = value;
				this.X0Y4_植性_通常_葉2.Dra = value;
				this.X0Y0_植性_通常_葉2.Hit = value;
				this.X0Y1_植性_通常_葉2.Hit = value;
				this.X0Y2_植性_通常_葉2.Hit = value;
				this.X0Y3_植性_通常_葉2.Hit = value;
				this.X0Y4_植性_通常_葉2.Hit = value;
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
				this.X0Y1_植性_通常_葉1.Dra = value;
				this.X0Y2_植性_通常_葉1.Dra = value;
				this.X0Y3_植性_通常_葉1.Dra = value;
				this.X0Y4_植性_通常_葉1.Dra = value;
				this.X0Y0_植性_通常_葉1.Hit = value;
				this.X0Y1_植性_通常_葉1.Hit = value;
				this.X0Y2_植性_通常_葉1.Hit = value;
				this.X0Y3_植性_通常_葉1.Hit = value;
				this.X0Y4_植性_通常_葉1.Hit = value;
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
				this.X0Y1_植性_欠損_葉3.Dra = value;
				this.X0Y2_植性_欠損_葉3.Dra = value;
				this.X0Y3_植性_欠損_葉3.Dra = value;
				this.X0Y4_植性_欠損_葉3.Dra = value;
				this.X0Y0_植性_欠損_葉3.Hit = value;
				this.X0Y1_植性_欠損_葉3.Hit = value;
				this.X0Y2_植性_欠損_葉3.Hit = value;
				this.X0Y3_植性_欠損_葉3.Hit = value;
				this.X0Y4_植性_欠損_葉3.Hit = value;
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
				this.X0Y1_植性_欠損_葉2.Dra = value;
				this.X0Y2_植性_欠損_葉2.Dra = value;
				this.X0Y3_植性_欠損_葉2.Dra = value;
				this.X0Y4_植性_欠損_葉2.Dra = value;
				this.X0Y0_植性_欠損_葉2.Hit = value;
				this.X0Y1_植性_欠損_葉2.Hit = value;
				this.X0Y2_植性_欠損_葉2.Hit = value;
				this.X0Y3_植性_欠損_葉2.Hit = value;
				this.X0Y4_植性_欠損_葉2.Hit = value;
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
				this.X0Y1_植性_欠損_葉1.Dra = value;
				this.X0Y2_植性_欠損_葉1.Dra = value;
				this.X0Y3_植性_欠損_葉1.Dra = value;
				this.X0Y4_植性_欠損_葉1.Dra = value;
				this.X0Y0_植性_欠損_葉1.Hit = value;
				this.X0Y1_植性_欠損_葉1.Hit = value;
				this.X0Y2_植性_欠損_葉1.Hit = value;
				this.X0Y3_植性_欠損_葉1.Hit = value;
				this.X0Y4_植性_欠損_葉1.Hit = value;
			}
		}

		public bool 虫性_器官1_表示
		{
			get
			{
				return this.X0Y0_虫性_器官1.Dra;
			}
			set
			{
				this.X0Y0_虫性_器官1.Dra = value;
				this.X0Y1_虫性_器官1.Dra = value;
				this.X0Y0_虫性_器官1.Hit = value;
				this.X0Y1_虫性_器官1.Hit = value;
			}
		}

		public bool 虫性_器官2_表示
		{
			get
			{
				return this.X0Y0_虫性_器官2.Dra;
			}
			set
			{
				this.X0Y0_虫性_器官2.Dra = value;
				this.X0Y1_虫性_器官2.Dra = value;
				this.X0Y0_虫性_器官2.Hit = value;
				this.X0Y1_虫性_器官2.Hit = value;
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
				this.X0Y2_傷I1.Dra = value;
				this.X0Y3_傷I1.Dra = value;
				this.X0Y4_傷I1.Dra = value;
				this.X0Y0_傷I1.Hit = value;
				this.X0Y1_傷I1.Hit = value;
				this.X0Y2_傷I1.Hit = value;
				this.X0Y3_傷I1.Hit = value;
				this.X0Y4_傷I1.Hit = value;
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
				this.X0Y2_傷I2.Dra = value;
				this.X0Y3_傷I2.Dra = value;
				this.X0Y0_傷I2.Hit = value;
				this.X0Y1_傷I2.Hit = value;
				this.X0Y2_傷I2.Hit = value;
				this.X0Y3_傷I2.Hit = value;
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
				this.X0Y2_傷I3.Dra = value;
				this.X0Y3_傷I3.Dra = value;
				this.X0Y0_傷I3.Hit = value;
				this.X0Y1_傷I3.Hit = value;
				this.X0Y2_傷I3.Hit = value;
				this.X0Y3_傷I3.Hit = value;
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

		public bool 傷X_表示
		{
			get
			{
				return this.X0Y0_傷X.Dra;
			}
			set
			{
				this.X0Y0_傷X.Dra = value;
				this.X0Y1_傷X.Dra = value;
				this.X0Y3_傷X.Dra = value;
				this.X0Y4_傷X.Dra = value;
				this.X0Y0_傷X.Hit = value;
				this.X0Y1_傷X.Hit = value;
				this.X0Y3_傷X.Hit = value;
				this.X0Y4_傷X.Hit = value;
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
				this.X0Y2_ハイライト1.Dra = value;
				this.X0Y3_ハイライト1.Dra = value;
				this.X0Y4_ハイライト1.Dra = value;
				this.X0Y0_ハイライト1.Hit = value;
				this.X0Y1_ハイライト1.Hit = value;
				this.X0Y2_ハイライト1.Hit = value;
				this.X0Y3_ハイライト1.Hit = value;
				this.X0Y4_ハイライト1.Hit = value;
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
				this.X0Y2_ハイライト2.Dra = value;
				this.X0Y3_ハイライト2.Dra = value;
				this.X0Y4_ハイライト2.Dra = value;
				this.X0Y0_ハイライト2.Hit = value;
				this.X0Y1_ハイライト2.Hit = value;
				this.X0Y2_ハイライト2.Hit = value;
				this.X0Y3_ハイライト2.Hit = value;
				this.X0Y4_ハイライト2.Hit = value;
			}
		}

		public bool パンスト_表示
		{
			get
			{
				return this.X0Y0_パンスト.Dra;
			}
			set
			{
				this.X0Y0_パンスト.Dra = value;
				this.X0Y1_パンスト.Dra = value;
				this.X0Y2_パンスト.Dra = value;
				this.X0Y3_パンスト.Dra = value;
				this.X0Y4_パンスト.Dra = value;
				this.X0Y0_パンスト.Hit = value;
				this.X0Y1_パンスト.Hit = value;
				this.X0Y2_パンスト.Hit = value;
				this.X0Y3_パンスト.Hit = value;
				this.X0Y4_パンスト.Hit = value;
			}
		}

		public bool パンスト_ハイライト_表示
		{
			get
			{
				return this.X0Y0_パンスト_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_パンスト_ハイライト.Dra = value;
				this.X0Y1_パンスト_ハイライト.Dra = value;
				this.X0Y2_パンスト_ハイライト.Dra = value;
				this.X0Y3_パンスト_ハイライト.Dra = value;
				this.X0Y4_パンスト_ハイライト.Dra = value;
				this.X0Y0_パンスト_ハイライト.Hit = value;
				this.X0Y1_パンスト_ハイライト.Hit = value;
				this.X0Y2_パンスト_ハイライト.Hit = value;
				this.X0Y3_パンスト_ハイライト.Hit = value;
				this.X0Y4_パンスト_ハイライト.Hit = value;
			}
		}

		public bool ニ\u30FCハイ_ニ\u30FCハイ1_表示
		{
			get
			{
				return this.X0Y0_ニ\u30FCハイ_ニ\u30FCハイ1.Dra;
			}
			set
			{
				this.X0Y0_ニ\u30FCハイ_ニ\u30FCハイ1.Dra = value;
				this.X0Y1_ニ\u30FCハイ_ニ\u30FCハイ1.Dra = value;
				this.X0Y2_ニ\u30FCハイ_ニ\u30FCハイ1.Dra = value;
				this.X0Y3_ニ\u30FCハイ_ニ\u30FCハイ1.Dra = value;
				this.X0Y4_ニ\u30FCハイ_ニ\u30FCハイ1.Dra = value;
				this.X0Y0_ニ\u30FCハイ_ニ\u30FCハイ1.Hit = value;
				this.X0Y1_ニ\u30FCハイ_ニ\u30FCハイ1.Hit = value;
				this.X0Y2_ニ\u30FCハイ_ニ\u30FCハイ1.Hit = value;
				this.X0Y3_ニ\u30FCハイ_ニ\u30FCハイ1.Hit = value;
				this.X0Y4_ニ\u30FCハイ_ニ\u30FCハイ1.Hit = value;
			}
		}

		public bool ニ\u30FCハイ_ニ\u30FCハイ2_表示
		{
			get
			{
				return this.X0Y0_ニ\u30FCハイ_ニ\u30FCハイ2.Dra;
			}
			set
			{
				this.X0Y0_ニ\u30FCハイ_ニ\u30FCハイ2.Dra = value;
				this.X0Y1_ニ\u30FCハイ_ニ\u30FCハイ2.Dra = value;
				this.X0Y2_ニ\u30FCハイ_ニ\u30FCハイ2.Dra = value;
				this.X0Y3_ニ\u30FCハイ_ニ\u30FCハイ2.Dra = value;
				this.X0Y4_ニ\u30FCハイ_ニ\u30FCハイ2.Dra = value;
				this.X0Y0_ニ\u30FCハイ_ニ\u30FCハイ2.Hit = value;
				this.X0Y1_ニ\u30FCハイ_ニ\u30FCハイ2.Hit = value;
				this.X0Y2_ニ\u30FCハイ_ニ\u30FCハイ2.Hit = value;
				this.X0Y3_ニ\u30FCハイ_ニ\u30FCハイ2.Hit = value;
				this.X0Y4_ニ\u30FCハイ_ニ\u30FCハイ2.Hit = value;
			}
		}

		public bool ニ\u30FCハイ_ハイライト_表示
		{
			get
			{
				return this.X0Y0_ニ\u30FCハイ_ハイライト.Dra;
			}
			set
			{
				this.X0Y0_ニ\u30FCハイ_ハイライト.Dra = value;
				this.X0Y1_ニ\u30FCハイ_ハイライト.Dra = value;
				this.X0Y2_ニ\u30FCハイ_ハイライト.Dra = value;
				this.X0Y3_ニ\u30FCハイ_ハイライト.Dra = value;
				this.X0Y4_ニ\u30FCハイ_ハイライト.Dra = value;
				this.X0Y0_ニ\u30FCハイ_ハイライト.Hit = value;
				this.X0Y1_ニ\u30FCハイ_ハイライト.Hit = value;
				this.X0Y2_ニ\u30FCハイ_ハイライト.Hit = value;
				this.X0Y3_ニ\u30FCハイ_ハイライト.Hit = value;
				this.X0Y4_ニ\u30FCハイ_ハイライト.Hit = value;
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
					this.植性_通常_葉3_表示 = false;
					this.植性_通常_葉3_表示 = false;
					this.植性_通常_葉3_表示 = false;
					this.植性_通常_葉3_表示 = false;
					this.植性_欠損_葉3_表示 = value;
					this.植性_欠損_葉3_表示 = value;
					this.植性_欠損_葉3_表示 = value;
					this.植性_欠損_葉3_表示 = value;
					this.植性_欠損_葉3_表示 = value;
					return;
				}
				this.植性_通常_葉3_表示 = value;
				this.植性_通常_葉3_表示 = value;
				this.植性_通常_葉3_表示 = value;
				this.植性_通常_葉3_表示 = value;
				this.植性_通常_葉3_表示 = value;
				this.植性_欠損_葉3_表示 = false;
				this.植性_欠損_葉3_表示 = false;
				this.植性_欠損_葉3_表示 = false;
				this.植性_欠損_葉3_表示 = false;
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
					this.植性_通常_葉2_表示 = false;
					this.植性_通常_葉2_表示 = false;
					this.植性_通常_葉2_表示 = false;
					this.植性_通常_葉2_表示 = false;
					this.植性_欠損_葉2_表示 = value;
					this.植性_欠損_葉2_表示 = value;
					this.植性_欠損_葉2_表示 = value;
					this.植性_欠損_葉2_表示 = value;
					this.植性_欠損_葉2_表示 = value;
					return;
				}
				this.植性_通常_葉2_表示 = value;
				this.植性_通常_葉2_表示 = value;
				this.植性_通常_葉2_表示 = value;
				this.植性_通常_葉2_表示 = value;
				this.植性_通常_葉2_表示 = value;
				this.植性_欠損_葉2_表示 = false;
				this.植性_欠損_葉2_表示 = false;
				this.植性_欠損_葉2_表示 = false;
				this.植性_欠損_葉2_表示 = false;
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
					this.植性_通常_葉1_表示 = false;
					this.植性_通常_葉1_表示 = false;
					this.植性_通常_葉1_表示 = false;
					this.植性_通常_葉1_表示 = false;
					this.植性_欠損_葉1_表示 = value;
					this.植性_欠損_葉1_表示 = value;
					this.植性_欠損_葉1_表示 = value;
					this.植性_欠損_葉1_表示 = value;
					this.植性_欠損_葉1_表示 = value;
					return;
				}
				this.植性_通常_葉1_表示 = value;
				this.植性_通常_葉1_表示 = value;
				this.植性_通常_葉1_表示 = value;
				this.植性_通常_葉1_表示 = value;
				this.植性_通常_葉1_表示 = value;
				this.植性_欠損_葉1_表示 = false;
				this.植性_欠損_葉1_表示 = false;
				this.植性_欠損_葉1_表示 = false;
				this.植性_欠損_葉1_表示 = false;
				this.植性_欠損_葉1_表示 = false;
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
				return this.ハイライト1CD.不透明度;
			}
			set
			{
				this.ハイライト1CD.不透明度 = value;
				this.ハイライト2CD.不透明度 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.腿_表示;
			}
			set
			{
				this.腿_表示 = value;
				this.筋_表示 = value;
				this.獣性_獣毛1_表示 = value;
				this.獣性_獣毛2_表示 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ左_表示 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ右_表示 = value;
				this.淫タトゥ_タトゥ左1_表示 = value;
				this.淫タトゥ_タトゥ右1_表示 = value;
				this.淫タトゥ_タトゥ左2_表示 = value;
				this.淫タトゥ_タトゥ右2_表示 = value;
				this.悪タトゥ1_文字_文字a_枠_表示 = value;
				this.悪タトゥ1_文字_文字a_文字タトゥ1_表示 = value;
				this.悪タトゥ1_文字_文字a_文字タトゥ2_表示 = value;
				this.悪タトゥ1_文字_文字b_枠_表示 = value;
				this.悪タトゥ1_文字_文字b_文字タトゥ1_表示 = value;
				this.悪タトゥ1_文字_文字b_文字タトゥ2_表示 = value;
				this.悪タトゥ1_文字_文字c_枠_表示 = value;
				this.悪タトゥ1_文字_文字c_文字タトゥ1_表示 = value;
				this.悪タトゥ1_文字_文字c_文字タトゥ2_表示 = value;
				this.悪タトゥ1_文字_文字d_枠_表示 = value;
				this.悪タトゥ1_文字_文字d_文字タトゥ1_表示 = value;
				this.悪タトゥ1_文字_文字d_文字タトゥ2_表示 = value;
				this.悪タトゥ1_文字_文字e_枠_表示 = value;
				this.悪タトゥ1_文字_文字e_文字タトゥ1_表示 = value;
				this.悪タトゥ1_文字_文字e_文字タトゥ2_表示 = value;
				this.悪タトゥ1_文字_文字e_文字タトゥ3_表示 = value;
				this.悪タトゥ1_タトゥ1_表示 = value;
				this.悪タトゥ1_タトゥ2_表示 = value;
				this.悪タトゥ2_逆十字_逆十字1_表示 = value;
				this.悪タトゥ2_逆十字_逆十字2_表示 = value;
				this.竜性_鱗1_表示 = value;
				this.竜性_鱗2_表示 = value;
				this.竜性_鱗3_表示 = value;
				this.竜性_鱗4_表示 = value;
				this.紋柄_紋1_表示 = value;
				this.紋柄_紋2_表示 = value;
				this.紋柄_紋3_表示 = value;
				this.紋柄_紋4_表示 = value;
				this.植性_通常_葉3_表示 = value;
				this.植性_通常_葉2_表示 = value;
				this.植性_通常_葉1_表示 = value;
				this.植性_欠損_葉3_表示 = value;
				this.植性_欠損_葉2_表示 = value;
				this.植性_欠損_葉1_表示 = value;
				this.虫性_器官1_表示 = value;
				this.虫性_器官2_表示 = value;
				this.傷I1_表示 = value;
				this.傷I2_表示 = value;
				this.傷I3_表示 = value;
				this.傷I4_表示 = value;
				this.傷X_表示 = value;
				this.ハイライト1_表示 = value;
				this.ハイライト2_表示 = value;
				this.パンスト_表示 = value;
				this.ニ\u30FCハイ_ニ\u30FCハイ1_表示 = value;
				this.ニ\u30FCハイ_ニ\u30FCハイ2_表示 = value;
				this.ニ\u30FCハイ_ハイライト_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.腿0CD.不透明度;
			}
			set
			{
				this.腿0CD.不透明度 = value;
				this.腿1CD.不透明度 = value;
				this.腿2CD.不透明度 = value;
				this.腿3CD.不透明度 = value;
				this.腿4CD.不透明度 = value;
				this.筋CD.不透明度 = value;
				this.獣性_獣毛1_0CD.不透明度 = value;
				this.獣性_獣毛2_0CD.不透明度 = value;
				this.獣性_獣毛1_1CD.不透明度 = value;
				this.獣性_獣毛2_1CD.不透明度 = value;
				this.獣性_獣毛1_2CD.不透明度 = value;
				this.獣性_獣毛2_2CD.不透明度 = value;
				this.獣性_獣毛1_3CD.不透明度 = value;
				this.獣性_獣毛2_3CD.不透明度 = value;
				this.獣性_獣毛1_4CD.不透明度 = value;
				this.獣性_獣毛2_4CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ左CD.不透明度 = value;
				this.淫タトゥ_ハ\u30FCト_タトゥ右CD.不透明度 = value;
				this.淫タトゥ_タトゥ左1CD.不透明度 = value;
				this.淫タトゥ_タトゥ右1CD.不透明度 = value;
				this.淫タトゥ_タトゥ左2CD.不透明度 = value;
				this.淫タトゥ_タトゥ右2CD.不透明度 = value;
				this.悪タトゥ1_文字_文字a_枠CD.不透明度 = value;
				this.悪タトゥ1_文字_文字a_文字タトゥ1CD.不透明度 = value;
				this.悪タトゥ1_文字_文字a_文字タトゥ2CD.不透明度 = value;
				this.悪タトゥ1_文字_文字b_枠CD.不透明度 = value;
				this.悪タトゥ1_文字_文字b_文字タトゥ1CD.不透明度 = value;
				this.悪タトゥ1_文字_文字b_文字タトゥ2CD.不透明度 = value;
				this.悪タトゥ1_文字_文字c_枠CD.不透明度 = value;
				this.悪タトゥ1_文字_文字c_文字タトゥ1CD.不透明度 = value;
				this.悪タトゥ1_文字_文字c_文字タトゥ2CD.不透明度 = value;
				this.悪タトゥ1_文字_文字d_枠CD.不透明度 = value;
				this.悪タトゥ1_文字_文字d_文字タトゥ1CD.不透明度 = value;
				this.悪タトゥ1_文字_文字d_文字タトゥ2CD.不透明度 = value;
				this.悪タトゥ1_文字_文字e_枠CD.不透明度 = value;
				this.悪タトゥ1_文字_文字e_文字タトゥ1CD.不透明度 = value;
				this.悪タトゥ1_文字_文字e_文字タトゥ2CD.不透明度 = value;
				this.悪タトゥ1_文字_文字e_文字タトゥ3CD.不透明度 = value;
				this.悪タトゥ1_タトゥ1CD.不透明度 = value;
				this.悪タトゥ1_タトゥ2CD.不透明度 = value;
				this.悪タトゥ2_逆十字_逆十字1CD.不透明度 = value;
				this.悪タトゥ2_逆十字_逆十字2CD.不透明度 = value;
				this.竜性_鱗1CD.不透明度 = value;
				this.竜性_鱗2CD.不透明度 = value;
				this.竜性_鱗3CD.不透明度 = value;
				this.竜性_鱗4CD.不透明度 = value;
				this.紋柄_紋1CD.不透明度 = value;
				this.紋柄_紋2CD.不透明度 = value;
				this.紋柄_紋3CD.不透明度 = value;
				this.紋柄_紋4CD.不透明度 = value;
				this.植性_葉3_0CD.不透明度 = value;
				this.植性_葉2_0CD.不透明度 = value;
				this.植性_葉1_0CD.不透明度 = value;
				this.植性_葉3_1CD.不透明度 = value;
				this.植性_葉2_1CD.不透明度 = value;
				this.植性_葉1_1CD.不透明度 = value;
				this.植性_葉3_2CD.不透明度 = value;
				this.植性_葉2_2CD.不透明度 = value;
				this.植性_葉1_2CD.不透明度 = value;
				this.植性_葉3_3CD.不透明度 = value;
				this.植性_葉2_3CD.不透明度 = value;
				this.植性_葉1_3CD.不透明度 = value;
				this.植性_葉3_4CD.不透明度 = value;
				this.植性_葉2_4CD.不透明度 = value;
				this.植性_葉1_4CD.不透明度 = value;
				this.虫性_器官1CD.不透明度 = value;
				this.虫性_器官2CD.不透明度 = value;
				this.傷I1CD.不透明度 = value;
				this.傷I2CD.不透明度 = value;
				this.傷I3CD.不透明度 = value;
				this.傷I4CD.不透明度 = value;
				this.傷XCD.不透明度 = value;
				this.ハイライト1CD.不透明度 = value;
				this.ハイライト2CD.不透明度 = value;
				this.パンストCD.不透明度 = value;
				this.ニ\u30FCハイ_ニ\u30FCハイ1CD.不透明度 = value;
				this.ニ\u30FCハイ_ニ\u30FCハイ2CD.不透明度 = value;
				this.ニ\u30FCハイ_ハイライトCD.不透明度 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			switch (this.本体.IndexY)
			{
			case 0:
				Are.Draw(this.X0Y0_腿);
				Are.Draw(this.X0Y0_筋);
				Are.Draw(this.X0Y0_悪タトゥ1_文字_文字a_枠);
				Are.Draw(this.X0Y0_悪タトゥ1_文字_文字a_文字タトゥ1);
				Are.Draw(this.X0Y0_悪タトゥ1_文字_文字a_文字タトゥ2);
				Are.Draw(this.X0Y0_悪タトゥ1_文字_文字b_枠);
				Are.Draw(this.X0Y0_悪タトゥ1_文字_文字b_文字タトゥ1);
				Are.Draw(this.X0Y0_悪タトゥ1_文字_文字b_文字タトゥ2);
				Are.Draw(this.X0Y0_悪タトゥ1_文字_文字c_枠);
				Are.Draw(this.X0Y0_悪タトゥ1_文字_文字c_文字タトゥ1);
				Are.Draw(this.X0Y0_悪タトゥ1_文字_文字c_文字タトゥ2);
				Are.Draw(this.X0Y0_悪タトゥ1_文字_文字d_枠);
				Are.Draw(this.X0Y0_悪タトゥ1_文字_文字d_文字タトゥ1);
				Are.Draw(this.X0Y0_悪タトゥ1_文字_文字d_文字タトゥ2);
				Are.Draw(this.X0Y0_悪タトゥ1_文字_文字e_枠);
				Are.Draw(this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ1);
				Are.Draw(this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ2);
				Are.Draw(this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ3);
				Are.Draw(this.X0Y0_悪タトゥ1_タトゥ1);
				Are.Draw(this.X0Y0_悪タトゥ1_タトゥ2);
				Are.Draw(this.X0Y0_獣性_獣毛1);
				Are.Draw(this.X0Y0_獣性_獣毛2);
				Are.Draw(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左);
				Are.Draw(this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右);
				Are.Draw(this.X0Y0_淫タトゥ_タトゥ左1);
				Are.Draw(this.X0Y0_淫タトゥ_タトゥ右1);
				Are.Draw(this.X0Y0_淫タトゥ_タトゥ左2);
				Are.Draw(this.X0Y0_淫タトゥ_タトゥ右2);
				Are.Draw(this.X0Y0_悪タトゥ2_逆十字_逆十字1);
				Are.Draw(this.X0Y0_悪タトゥ2_逆十字_逆十字2);
				Are.Draw(this.X0Y0_植性_通常_葉3);
				Are.Draw(this.X0Y0_植性_欠損_葉3);
				Are.Draw(this.X0Y0_植性_通常_葉2);
				Are.Draw(this.X0Y0_植性_欠損_葉2);
				Are.Draw(this.X0Y0_竜性_鱗1);
				Are.Draw(this.X0Y0_竜性_鱗2);
				Are.Draw(this.X0Y0_竜性_鱗3);
				Are.Draw(this.X0Y0_竜性_鱗4);
				Are.Draw(this.X0Y0_紋柄_紋1);
				Are.Draw(this.X0Y0_紋柄_紋2);
				Are.Draw(this.X0Y0_紋柄_紋3);
				Are.Draw(this.X0Y0_紋柄_紋4);
				Are.Draw(this.X0Y0_植性_通常_葉1);
				Are.Draw(this.X0Y0_植性_欠損_葉1);
				Are.Draw(this.X0Y0_虫性_器官1);
				Are.Draw(this.X0Y0_虫性_器官2);
				Are.Draw(this.X0Y0_傷I1);
				Are.Draw(this.X0Y0_傷I2);
				Are.Draw(this.X0Y0_傷I3);
				Are.Draw(this.X0Y0_傷I4);
				Are.Draw(this.X0Y0_傷X);
				this.キスマ\u30FCク.Draw(Are);
				this.鞭痕.Draw(Are);
				Are.Draw(this.X0Y0_ハイライト1);
				Are.Draw(this.X0Y0_ハイライト2);
				Are.Draw(this.X0Y0_パンスト);
				Are.Draw(this.X0Y0_パンスト_ハイライト);
				Are.Draw(this.X0Y0_ニ\u30FCハイ_ニ\u30FCハイ1);
				Are.Draw(this.X0Y0_ニ\u30FCハイ_ニ\u30FCハイ2);
				Are.Draw(this.X0Y0_ニ\u30FCハイ_ハイライト);
				return;
			case 1:
				Are.Draw(this.X0Y1_腿);
				Are.Draw(this.X0Y1_筋);
				Are.Draw(this.X0Y1_悪タトゥ1_文字_文字a_枠);
				Are.Draw(this.X0Y1_悪タトゥ1_文字_文字a_文字タトゥ1);
				Are.Draw(this.X0Y1_悪タトゥ1_文字_文字a_文字タトゥ2);
				Are.Draw(this.X0Y1_悪タトゥ1_文字_文字b_枠);
				Are.Draw(this.X0Y1_悪タトゥ1_文字_文字b_文字タトゥ1);
				Are.Draw(this.X0Y1_悪タトゥ1_文字_文字b_文字タトゥ2);
				Are.Draw(this.X0Y1_悪タトゥ1_文字_文字c_枠);
				Are.Draw(this.X0Y1_悪タトゥ1_文字_文字c_文字タトゥ1);
				Are.Draw(this.X0Y1_悪タトゥ1_文字_文字c_文字タトゥ2);
				Are.Draw(this.X0Y1_悪タトゥ1_文字_文字d_枠);
				Are.Draw(this.X0Y1_悪タトゥ1_文字_文字d_文字タトゥ1);
				Are.Draw(this.X0Y1_悪タトゥ1_文字_文字d_文字タトゥ2);
				Are.Draw(this.X0Y1_悪タトゥ1_文字_文字e_枠);
				Are.Draw(this.X0Y1_悪タトゥ1_文字_文字e_文字タトゥ1);
				Are.Draw(this.X0Y1_悪タトゥ1_文字_文字e_文字タトゥ2);
				Are.Draw(this.X0Y1_悪タトゥ1_文字_文字e_文字タトゥ3);
				Are.Draw(this.X0Y1_悪タトゥ1_タトゥ1);
				Are.Draw(this.X0Y1_悪タトゥ1_タトゥ2);
				Are.Draw(this.X0Y1_獣性_獣毛1);
				Are.Draw(this.X0Y1_獣性_獣毛2);
				Are.Draw(this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左);
				Are.Draw(this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右);
				Are.Draw(this.X0Y1_淫タトゥ_タトゥ左1);
				Are.Draw(this.X0Y1_淫タトゥ_タトゥ右1);
				Are.Draw(this.X0Y1_淫タトゥ_タトゥ左2);
				Are.Draw(this.X0Y1_淫タトゥ_タトゥ右2);
				Are.Draw(this.X0Y1_悪タトゥ2_逆十字_逆十字1);
				Are.Draw(this.X0Y1_悪タトゥ2_逆十字_逆十字2);
				Are.Draw(this.X0Y1_植性_通常_葉3);
				Are.Draw(this.X0Y1_植性_欠損_葉3);
				Are.Draw(this.X0Y1_植性_通常_葉2);
				Are.Draw(this.X0Y1_植性_欠損_葉2);
				Are.Draw(this.X0Y1_鱗_鱗1);
				Are.Draw(this.X0Y1_鱗_鱗2);
				Are.Draw(this.X0Y1_鱗_鱗3);
				Are.Draw(this.X0Y1_鱗_鱗4);
				Are.Draw(this.X0Y1_紋柄_紋1);
				Are.Draw(this.X0Y1_紋柄_紋2);
				Are.Draw(this.X0Y1_紋柄_紋3);
				Are.Draw(this.X0Y1_紋柄_紋4);
				Are.Draw(this.X0Y1_植性_通常_葉1);
				Are.Draw(this.X0Y1_植性_欠損_葉1);
				Are.Draw(this.X0Y1_虫性_器官1);
				Are.Draw(this.X0Y1_虫性_器官2);
				Are.Draw(this.X0Y1_傷I1);
				Are.Draw(this.X0Y1_傷I2);
				Are.Draw(this.X0Y1_傷I3);
				Are.Draw(this.X0Y1_傷I4);
				Are.Draw(this.X0Y1_傷X);
				this.キスマ\u30FCク.Draw(Are);
				this.鞭痕.Draw(Are);
				Are.Draw(this.X0Y1_ハイライト1);
				Are.Draw(this.X0Y1_ハイライト2);
				Are.Draw(this.X0Y1_パンスト);
				Are.Draw(this.X0Y1_パンスト_ハイライト);
				Are.Draw(this.X0Y1_ニ\u30FCハイ_ニ\u30FCハイ1);
				Are.Draw(this.X0Y1_ニ\u30FCハイ_ニ\u30FCハイ2);
				Are.Draw(this.X0Y1_ニ\u30FCハイ_ハイライト);
				return;
			case 2:
				Are.Draw(this.X0Y2_腿);
				Are.Draw(this.X0Y2_筋);
				Are.Draw(this.X0Y2_悪タトゥ1_文字_文字b_枠);
				Are.Draw(this.X0Y2_悪タトゥ1_文字_文字b_文字タトゥ1);
				Are.Draw(this.X0Y2_悪タトゥ1_文字_文字b_文字タトゥ2);
				Are.Draw(this.X0Y2_悪タトゥ1_文字_文字c_枠);
				Are.Draw(this.X0Y2_悪タトゥ1_文字_文字c_文字タトゥ1);
				Are.Draw(this.X0Y2_悪タトゥ1_文字_文字c_文字タトゥ2);
				Are.Draw(this.X0Y2_悪タトゥ1_文字_文字d_枠);
				Are.Draw(this.X0Y2_悪タトゥ1_文字_文字d_文字タトゥ1);
				Are.Draw(this.X0Y2_悪タトゥ1_文字_文字d_文字タトゥ2);
				Are.Draw(this.X0Y2_悪タトゥ1_文字_文字e_枠);
				Are.Draw(this.X0Y2_悪タトゥ1_文字_文字e_文字タトゥ1);
				Are.Draw(this.X0Y2_悪タトゥ1_文字_文字e_文字タトゥ2);
				Are.Draw(this.X0Y2_悪タトゥ1_文字_文字e_文字タトゥ3);
				Are.Draw(this.X0Y2_悪タトゥ1_文字_文字a_枠);
				Are.Draw(this.X0Y2_悪タトゥ1_文字_文字a_文字タトゥ1);
				Are.Draw(this.X0Y2_悪タトゥ1_文字_文字a_文字タトゥ2);
				Are.Draw(this.X0Y2_悪タトゥ1_タトゥ1);
				Are.Draw(this.X0Y2_悪タトゥ1_タトゥ2);
				Are.Draw(this.X0Y2_獣性_獣毛1);
				Are.Draw(this.X0Y2_獣性_獣毛2);
				Are.Draw(this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左);
				Are.Draw(this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右);
				Are.Draw(this.X0Y2_淫タトゥ_タトゥ右1);
				Are.Draw(this.X0Y2_淫タトゥ_タトゥ右2);
				Are.Draw(this.X0Y2_悪タトゥ2_逆十字_逆十字1);
				Are.Draw(this.X0Y2_悪タトゥ2_逆十字_逆十字2);
				Are.Draw(this.X0Y2_植性_通常_葉3);
				Are.Draw(this.X0Y2_植性_欠損_葉3);
				Are.Draw(this.X0Y2_植性_通常_葉2);
				Are.Draw(this.X0Y2_植性_欠損_葉2);
				Are.Draw(this.X0Y2_植性_通常_葉1);
				Are.Draw(this.X0Y2_植性_欠損_葉1);
				Are.Draw(this.X0Y2_傷I1);
				Are.Draw(this.X0Y2_傷I2);
				Are.Draw(this.X0Y2_傷I3);
				this.キスマ\u30FCク.Draw(Are);
				this.鞭痕.Draw(Are);
				Are.Draw(this.X0Y2_ハイライト1);
				Are.Draw(this.X0Y2_ハイライト2);
				Are.Draw(this.X0Y2_パンスト);
				Are.Draw(this.X0Y2_パンスト_ハイライト);
				Are.Draw(this.X0Y2_ニ\u30FCハイ_ニ\u30FCハイ1);
				Are.Draw(this.X0Y2_ニ\u30FCハイ_ニ\u30FCハイ2);
				Are.Draw(this.X0Y2_ニ\u30FCハイ_ハイライト);
				return;
			case 3:
				Are.Draw(this.X0Y3_腿);
				Are.Draw(this.X0Y3_筋);
				Are.Draw(this.X0Y3_悪タトゥ1_文字_文字c_枠);
				Are.Draw(this.X0Y3_悪タトゥ1_文字_文字c_文字タトゥ1);
				Are.Draw(this.X0Y3_悪タトゥ1_文字_文字c_文字タトゥ2);
				Are.Draw(this.X0Y3_悪タトゥ1_文字_文字d_枠);
				Are.Draw(this.X0Y3_悪タトゥ1_文字_文字d_文字タトゥ1);
				Are.Draw(this.X0Y3_悪タトゥ1_文字_文字d_文字タトゥ2);
				Are.Draw(this.X0Y3_悪タトゥ1_文字_文字e_枠);
				Are.Draw(this.X0Y3_悪タトゥ1_文字_文字e_文字タトゥ1);
				Are.Draw(this.X0Y3_悪タトゥ1_文字_文字e_文字タトゥ2);
				Are.Draw(this.X0Y3_悪タトゥ1_文字_文字e_文字タトゥ3);
				Are.Draw(this.X0Y3_悪タトゥ1_文字_文字a_枠);
				Are.Draw(this.X0Y3_悪タトゥ1_文字_文字a_文字タトゥ1);
				Are.Draw(this.X0Y3_悪タトゥ1_文字_文字a_文字タトゥ2);
				Are.Draw(this.X0Y3_悪タトゥ1_文字_文字b_枠);
				Are.Draw(this.X0Y3_悪タトゥ1_文字_文字b_文字タトゥ1);
				Are.Draw(this.X0Y3_悪タトゥ1_文字_文字b_文字タトゥ2);
				Are.Draw(this.X0Y3_悪タトゥ1_タトゥ1);
				Are.Draw(this.X0Y3_悪タトゥ1_タトゥ2);
				Are.Draw(this.X0Y3_獣性_獣毛1);
				Are.Draw(this.X0Y3_獣性_獣毛2);
				Are.Draw(this.X0Y3_淫タトゥ_タトゥ左1);
				Are.Draw(this.X0Y3_淫タトゥ_タトゥ右1);
				Are.Draw(this.X0Y3_淫タトゥ_タトゥ左2);
				Are.Draw(this.X0Y3_淫タトゥ_タトゥ右2);
				Are.Draw(this.X0Y3_悪タトゥ2_逆十字_逆十字1);
				Are.Draw(this.X0Y3_悪タトゥ2_逆十字_逆十字2);
				Are.Draw(this.X0Y3_植性_通常_葉3);
				Are.Draw(this.X0Y3_植性_欠損_葉3);
				Are.Draw(this.X0Y3_植性_通常_葉2);
				Are.Draw(this.X0Y3_植性_欠損_葉2);
				Are.Draw(this.X0Y3_鱗_鱗1);
				Are.Draw(this.X0Y3_鱗_鱗2);
				Are.Draw(this.X0Y3_鱗_鱗3);
				Are.Draw(this.X0Y3_鱗_鱗4);
				Are.Draw(this.X0Y3_紋柄_紋1);
				Are.Draw(this.X0Y3_紋柄_紋2);
				Are.Draw(this.X0Y3_紋柄_紋3);
				Are.Draw(this.X0Y3_紋柄_紋4);
				Are.Draw(this.X0Y3_植性_通常_葉1);
				Are.Draw(this.X0Y3_植性_欠損_葉1);
				Are.Draw(this.X0Y3_傷I1);
				Are.Draw(this.X0Y3_傷I2);
				Are.Draw(this.X0Y3_傷I3);
				Are.Draw(this.X0Y3_傷X);
				this.キスマ\u30FCク.Draw(Are);
				this.鞭痕.Draw(Are);
				Are.Draw(this.X0Y3_ハイライト1);
				Are.Draw(this.X0Y3_ハイライト2);
				Are.Draw(this.X0Y3_パンスト);
				Are.Draw(this.X0Y3_パンスト_ハイライト);
				Are.Draw(this.X0Y3_ニ\u30FCハイ_ニ\u30FCハイ1);
				Are.Draw(this.X0Y3_ニ\u30FCハイ_ニ\u30FCハイ2);
				Are.Draw(this.X0Y3_ニ\u30FCハイ_ハイライト);
				return;
			default:
				Are.Draw(this.X0Y4_腿);
				Are.Draw(this.X0Y4_筋);
				Are.Draw(this.X0Y4_悪タトゥ1_文字_文字d_枠);
				Are.Draw(this.X0Y4_悪タトゥ1_文字_文字d_文字タトゥ1);
				Are.Draw(this.X0Y4_悪タトゥ1_文字_文字d_文字タトゥ2);
				Are.Draw(this.X0Y4_悪タトゥ1_文字_文字e_枠);
				Are.Draw(this.X0Y4_悪タトゥ1_文字_文字e_文字タトゥ1);
				Are.Draw(this.X0Y4_悪タトゥ1_文字_文字e_文字タトゥ2);
				Are.Draw(this.X0Y4_悪タトゥ1_文字_文字e_文字タトゥ3);
				Are.Draw(this.X0Y4_悪タトゥ1_文字_文字a_枠);
				Are.Draw(this.X0Y4_悪タトゥ1_文字_文字a_文字タトゥ1);
				Are.Draw(this.X0Y4_悪タトゥ1_文字_文字a_文字タトゥ2);
				Are.Draw(this.X0Y4_悪タトゥ1_文字_文字b_枠);
				Are.Draw(this.X0Y4_悪タトゥ1_文字_文字b_文字タトゥ1);
				Are.Draw(this.X0Y4_悪タトゥ1_文字_文字b_文字タトゥ2);
				Are.Draw(this.X0Y4_悪タトゥ1_文字_文字c_枠);
				Are.Draw(this.X0Y4_悪タトゥ1_文字_文字c_文字タトゥ1);
				Are.Draw(this.X0Y4_悪タトゥ1_文字_文字c_文字タトゥ2);
				Are.Draw(this.X0Y4_悪タトゥ1_タトゥ1);
				Are.Draw(this.X0Y4_悪タトゥ1_タトゥ2);
				Are.Draw(this.X0Y4_獣性_獣毛1);
				Are.Draw(this.X0Y4_獣性_獣毛2);
				Are.Draw(this.X0Y4_淫タトゥ_タトゥ左1);
				Are.Draw(this.X0Y4_淫タトゥ_タトゥ右1);
				Are.Draw(this.X0Y4_淫タトゥ_タトゥ左2);
				Are.Draw(this.X0Y4_淫タトゥ_タトゥ右2);
				Are.Draw(this.X0Y4_植性_通常_葉3);
				Are.Draw(this.X0Y4_植性_欠損_葉3);
				Are.Draw(this.X0Y4_植性_通常_葉2);
				Are.Draw(this.X0Y4_植性_欠損_葉2);
				Are.Draw(this.X0Y4_鱗_鱗1);
				Are.Draw(this.X0Y4_鱗_鱗2);
				Are.Draw(this.X0Y4_鱗_鱗3);
				Are.Draw(this.X0Y4_鱗_鱗4);
				Are.Draw(this.X0Y4_紋柄_紋1);
				Are.Draw(this.X0Y4_紋柄_紋2);
				Are.Draw(this.X0Y4_紋柄_紋3);
				Are.Draw(this.X0Y4_紋柄_紋4);
				Are.Draw(this.X0Y4_植性_通常_葉1);
				Are.Draw(this.X0Y4_植性_欠損_葉1);
				Are.Draw(this.X0Y4_傷I1);
				Are.Draw(this.X0Y4_傷X);
				this.キスマ\u30FCク.Draw(Are);
				this.鞭痕.Draw(Are);
				Are.Draw(this.X0Y4_ハイライト1);
				Are.Draw(this.X0Y4_ハイライト2);
				Are.Draw(this.X0Y4_パンスト);
				Are.Draw(this.X0Y4_パンスト_ハイライト);
				Are.Draw(this.X0Y4_ニ\u30FCハイ_ニ\u30FCハイ1);
				Are.Draw(this.X0Y4_ニ\u30FCハイ_ニ\u30FCハイ2);
				Are.Draw(this.X0Y4_ニ\u30FCハイ_ハイライト);
				return;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_腿.AngleBase = num * -8.53773646251594E-07;
			this.X0Y1_腿.AngleBase = num * -313.0;
			this.X0Y2_腿.AngleBase = num * -271.0;
			this.X0Y3_腿.AngleBase = num * -222.0;
			this.X0Y4_腿.AngleBase = num * -182.0;
			this.本体.JoinPAall();
		}

		public void 虫性()
		{
			this.X0Y0_腿.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y1_腿.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y2_腿.OP[this.右 ? 4 : 0].Outline = true;
			this.X0Y3_腿.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y4_腿.OP[this.右 ? 4 : 0].Outline = true;
		}

		public void スライム()
		{
			this.X0Y0_腿.OP[this.右 ? 4 : 0].Outline = false;
			this.X0Y0_腿.OP[this.右 ? 3 : 1].Outline = false;
			this.X0Y0_腿.OP[this.右 ? 2 : 2].Outline = false;
			this.X0Y0_腿.OP[this.右 ? 1 : 3].Outline = false;
			this.X0Y1_腿.OP[this.右 ? 4 : 0].Outline = false;
			this.X0Y1_腿.OP[this.右 ? 3 : 1].Outline = false;
			this.X0Y1_腿.OP[this.右 ? 2 : 2].Outline = false;
			this.X0Y1_腿.OP[this.右 ? 1 : 3].Outline = false;
			this.X0Y2_腿.OP[this.右 ? 3 : 1].Outline = false;
			this.X0Y2_腿.OP[this.右 ? 2 : 2].Outline = false;
			this.X0Y2_腿.OP[this.右 ? 1 : 3].Outline = false;
			this.X0Y2_腿.OP[this.右 ? 0 : 4].Outline = false;
			this.X0Y3_腿.OP[this.右 ? 4 : 0].Outline = false;
			this.X0Y3_腿.OP[this.右 ? 3 : 1].Outline = false;
			this.X0Y3_腿.OP[this.右 ? 2 : 2].Outline = false;
			this.X0Y3_腿.OP[this.右 ? 1 : 3].Outline = false;
			this.X0Y4_腿.OP[this.右 ? 3 : 1].Outline = false;
			this.X0Y4_腿.OP[this.右 ? 2 : 2].Outline = false;
			this.X0Y4_腿.OP[this.右 ? 1 : 3].Outline = false;
			this.X0Y4_腿.OP[this.右 ? 0 : 4].Outline = false;
			Color color = Color.FromArgb(128, this.腿0CD.c2.Col2);
			this.腿0CD.色 = new Color2(ref this.腿0CD.c2.Col1, ref color);
			this.腿1CD.色 = new Color2(ref this.腿1CD.c2.Col1, ref color);
			this.腿2CD.色 = new Color2(ref this.腿2CD.c2.Col1, ref color);
			this.腿3CD.色 = new Color2(ref this.腿3CD.c2.Col1, ref color);
			this.腿4CD.色 = new Color2(ref this.腿4CD.c2.Col1, ref color);
		}

		public bool パンスト表示
		{
			get
			{
				return this.パンスト_表示;
			}
			set
			{
				this.パンスト_表示 = value;
				this.パンスト_ハイライト_表示 = value;
			}
		}

		public bool ニ\u30FCハイ表示
		{
			get
			{
				return this.ニ\u30FCハイ_ニ\u30FCハイ1_表示;
			}
			set
			{
				this.ニ\u30FCハイ_ニ\u30FCハイ1_表示 = value;
				this.ニ\u30FCハイ_ニ\u30FCハイ2_表示 = value;
				this.ニ\u30FCハイ_ハイライト_表示 = value;
			}
		}

		public override bool Is布(Par p)
		{
			return p == this.X0Y0_パンスト || p == this.X0Y0_パンスト_ハイライト || p == this.X0Y0_ニ\u30FCハイ_ニ\u30FCハイ1 || p == this.X0Y0_ニ\u30FCハイ_ニ\u30FCハイ2 || p == this.X0Y0_ニ\u30FCハイ_ハイライト || p == this.X0Y1_パンスト || p == this.X0Y1_パンスト_ハイライト || p == this.X0Y1_ニ\u30FCハイ_ニ\u30FCハイ1 || p == this.X0Y1_ニ\u30FCハイ_ニ\u30FCハイ2 || p == this.X0Y1_ニ\u30FCハイ_ハイライト || p == this.X0Y2_パンスト || p == this.X0Y2_パンスト_ハイライト || p == this.X0Y2_ニ\u30FCハイ_ニ\u30FCハイ1 || p == this.X0Y2_ニ\u30FCハイ_ニ\u30FCハイ2 || p == this.X0Y2_ニ\u30FCハイ_ハイライト || p == this.X0Y3_パンスト || p == this.X0Y3_パンスト_ハイライト || p == this.X0Y3_ニ\u30FCハイ_ニ\u30FCハイ1 || p == this.X0Y3_ニ\u30FCハイ_ニ\u30FCハイ2 || p == this.X0Y3_ニ\u30FCハイ_ハイライト || p == this.X0Y4_パンスト || p == this.X0Y4_パンスト_ハイライト || p == this.X0Y4_ニ\u30FCハイ_ニ\u30FCハイ1 || p == this.X0Y4_ニ\u30FCハイ_ニ\u30FCハイ2 || p == this.X0Y4_ニ\u30FCハイ_ハイライト;
		}

		public JointS 脚_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腿, 0);
			}
		}

		public override void 色更新()
		{
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_腿CP.Update();
				this.X0Y0_筋CP.Update();
				this.X0Y0_獣性_獣毛1CP.Update();
				this.X0Y0_獣性_獣毛2CP.Update();
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左CP.Update();
				this.X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右CP.Update();
				this.X0Y0_淫タトゥ_タトゥ左1CP.Update();
				this.X0Y0_淫タトゥ_タトゥ右1CP.Update();
				this.X0Y0_淫タトゥ_タトゥ左2CP.Update();
				this.X0Y0_淫タトゥ_タトゥ右2CP.Update();
				this.X0Y0_悪タトゥ1_文字_文字a_枠CP.Update();
				this.X0Y0_悪タトゥ1_文字_文字a_文字タトゥ1CP.Update();
				this.X0Y0_悪タトゥ1_文字_文字a_文字タトゥ2CP.Update();
				this.X0Y0_悪タトゥ1_文字_文字b_枠CP.Update();
				this.X0Y0_悪タトゥ1_文字_文字b_文字タトゥ1CP.Update();
				this.X0Y0_悪タトゥ1_文字_文字b_文字タトゥ2CP.Update();
				this.X0Y0_悪タトゥ1_文字_文字c_枠CP.Update();
				this.X0Y0_悪タトゥ1_文字_文字c_文字タトゥ1CP.Update();
				this.X0Y0_悪タトゥ1_文字_文字c_文字タトゥ2CP.Update();
				this.X0Y0_悪タトゥ1_文字_文字d_枠CP.Update();
				this.X0Y0_悪タトゥ1_文字_文字d_文字タトゥ1CP.Update();
				this.X0Y0_悪タトゥ1_文字_文字d_文字タトゥ2CP.Update();
				this.X0Y0_悪タトゥ1_文字_文字e_枠CP.Update();
				this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ1CP.Update();
				this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ2CP.Update();
				this.X0Y0_悪タトゥ1_文字_文字e_文字タトゥ3CP.Update();
				this.X0Y0_悪タトゥ1_タトゥ1CP.Update();
				this.X0Y0_悪タトゥ1_タトゥ2CP.Update();
				this.X0Y0_悪タトゥ2_逆十字_逆十字1CP.Update();
				this.X0Y0_悪タトゥ2_逆十字_逆十字2CP.Update();
				this.X0Y0_竜性_鱗1CP.Update();
				this.X0Y0_竜性_鱗2CP.Update();
				this.X0Y0_竜性_鱗3CP.Update();
				this.X0Y0_竜性_鱗4CP.Update();
				this.X0Y0_紋柄_紋1CP.Update();
				this.X0Y0_紋柄_紋2CP.Update();
				this.X0Y0_紋柄_紋3CP.Update();
				this.X0Y0_紋柄_紋4CP.Update();
				this.X0Y0_植性_通常_葉3CP.Update();
				this.X0Y0_植性_通常_葉2CP.Update();
				this.X0Y0_植性_通常_葉1CP.Update();
				this.X0Y0_植性_欠損_葉3CP.Update();
				this.X0Y0_植性_欠損_葉2CP.Update();
				this.X0Y0_植性_欠損_葉1CP.Update();
				this.X0Y0_虫性_器官1CP.Update();
				this.X0Y0_虫性_器官2CP.Update();
				this.X0Y0_傷I1CP.Update();
				this.X0Y0_傷I2CP.Update();
				this.X0Y0_傷I3CP.Update();
				this.X0Y0_傷I4CP.Update();
				this.X0Y0_傷XCP.Update();
				this.X0Y0_ハイライト1CP.Update();
				this.X0Y0_ハイライト2CP.Update();
				this.X0Y0_パンストCP.Update();
				this.X0Y0_パンスト_ハイライトCP.Update();
				this.X0Y0_ニ\u30FCハイ_ニ\u30FCハイ1CP.Update();
				this.X0Y0_ニ\u30FCハイ_ニ\u30FCハイ2CP.Update();
				this.X0Y0_ニ\u30FCハイ_ハイライトCP.Update();
				return;
			case 1:
				this.X0Y1_腿CP.Update();
				this.X0Y1_筋CP.Update();
				this.X0Y1_獣性_獣毛1CP.Update();
				this.X0Y1_獣性_獣毛2CP.Update();
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左CP.Update();
				this.X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右CP.Update();
				this.X0Y1_淫タトゥ_タトゥ左1CP.Update();
				this.X0Y1_淫タトゥ_タトゥ右1CP.Update();
				this.X0Y1_淫タトゥ_タトゥ左2CP.Update();
				this.X0Y1_淫タトゥ_タトゥ右2CP.Update();
				this.X0Y1_悪タトゥ1_文字_文字a_枠CP.Update();
				this.X0Y1_悪タトゥ1_文字_文字a_文字タトゥ1CP.Update();
				this.X0Y1_悪タトゥ1_文字_文字a_文字タトゥ2CP.Update();
				this.X0Y1_悪タトゥ1_文字_文字b_枠CP.Update();
				this.X0Y1_悪タトゥ1_文字_文字b_文字タトゥ1CP.Update();
				this.X0Y1_悪タトゥ1_文字_文字b_文字タトゥ2CP.Update();
				this.X0Y1_悪タトゥ1_文字_文字c_枠CP.Update();
				this.X0Y1_悪タトゥ1_文字_文字c_文字タトゥ1CP.Update();
				this.X0Y1_悪タトゥ1_文字_文字c_文字タトゥ2CP.Update();
				this.X0Y1_悪タトゥ1_文字_文字d_枠CP.Update();
				this.X0Y1_悪タトゥ1_文字_文字d_文字タトゥ1CP.Update();
				this.X0Y1_悪タトゥ1_文字_文字d_文字タトゥ2CP.Update();
				this.X0Y1_悪タトゥ1_文字_文字e_枠CP.Update();
				this.X0Y1_悪タトゥ1_文字_文字e_文字タトゥ1CP.Update();
				this.X0Y1_悪タトゥ1_文字_文字e_文字タトゥ2CP.Update();
				this.X0Y1_悪タトゥ1_文字_文字e_文字タトゥ3CP.Update();
				this.X0Y1_悪タトゥ1_タトゥ1CP.Update();
				this.X0Y1_悪タトゥ1_タトゥ2CP.Update();
				this.X0Y1_悪タトゥ2_逆十字_逆十字1CP.Update();
				this.X0Y1_悪タトゥ2_逆十字_逆十字2CP.Update();
				this.X0Y1_鱗_鱗1CP.Update();
				this.X0Y1_鱗_鱗2CP.Update();
				this.X0Y1_鱗_鱗3CP.Update();
				this.X0Y1_鱗_鱗4CP.Update();
				this.X0Y1_紋柄_紋1CP.Update();
				this.X0Y1_紋柄_紋2CP.Update();
				this.X0Y1_紋柄_紋3CP.Update();
				this.X0Y1_紋柄_紋4CP.Update();
				this.X0Y1_植性_通常_葉3CP.Update();
				this.X0Y1_植性_通常_葉2CP.Update();
				this.X0Y1_植性_通常_葉1CP.Update();
				this.X0Y1_植性_欠損_葉3CP.Update();
				this.X0Y1_植性_欠損_葉2CP.Update();
				this.X0Y1_植性_欠損_葉1CP.Update();
				this.X0Y1_虫性_器官1CP.Update();
				this.X0Y1_虫性_器官2CP.Update();
				this.X0Y1_傷I1CP.Update();
				this.X0Y1_傷I2CP.Update();
				this.X0Y1_傷I3CP.Update();
				this.X0Y1_傷I4CP.Update();
				this.X0Y1_傷XCP.Update();
				this.X0Y1_ハイライト1CP.Update();
				this.X0Y1_ハイライト2CP.Update();
				this.X0Y1_パンストCP.Update();
				this.X0Y1_パンスト_ハイライトCP.Update();
				this.X0Y1_ニ\u30FCハイ_ニ\u30FCハイ1CP.Update();
				this.X0Y1_ニ\u30FCハイ_ニ\u30FCハイ2CP.Update();
				this.X0Y1_ニ\u30FCハイ_ハイライトCP.Update();
				return;
			case 2:
				this.X0Y2_腿CP.Update();
				this.X0Y2_筋CP.Update();
				this.X0Y2_獣性_獣毛1CP.Update();
				this.X0Y2_獣性_獣毛2CP.Update();
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左CP.Update();
				this.X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右CP.Update();
				this.X0Y2_淫タトゥ_タトゥ右1CP.Update();
				this.X0Y2_淫タトゥ_タトゥ右2CP.Update();
				this.X0Y2_悪タトゥ1_文字_文字b_枠CP.Update();
				this.X0Y2_悪タトゥ1_文字_文字b_文字タトゥ1CP.Update();
				this.X0Y2_悪タトゥ1_文字_文字b_文字タトゥ2CP.Update();
				this.X0Y2_悪タトゥ1_文字_文字c_枠CP.Update();
				this.X0Y2_悪タトゥ1_文字_文字c_文字タトゥ1CP.Update();
				this.X0Y2_悪タトゥ1_文字_文字c_文字タトゥ2CP.Update();
				this.X0Y2_悪タトゥ1_文字_文字d_枠CP.Update();
				this.X0Y2_悪タトゥ1_文字_文字d_文字タトゥ1CP.Update();
				this.X0Y2_悪タトゥ1_文字_文字d_文字タトゥ2CP.Update();
				this.X0Y2_悪タトゥ1_文字_文字e_枠CP.Update();
				this.X0Y2_悪タトゥ1_文字_文字e_文字タトゥ1CP.Update();
				this.X0Y2_悪タトゥ1_文字_文字e_文字タトゥ2CP.Update();
				this.X0Y2_悪タトゥ1_文字_文字e_文字タトゥ3CP.Update();
				this.X0Y2_悪タトゥ1_文字_文字a_枠CP.Update();
				this.X0Y2_悪タトゥ1_文字_文字a_文字タトゥ1CP.Update();
				this.X0Y2_悪タトゥ1_文字_文字a_文字タトゥ2CP.Update();
				this.X0Y2_悪タトゥ1_タトゥ1CP.Update();
				this.X0Y2_悪タトゥ1_タトゥ2CP.Update();
				this.X0Y2_悪タトゥ2_逆十字_逆十字1CP.Update();
				this.X0Y2_悪タトゥ2_逆十字_逆十字2CP.Update();
				this.X0Y2_植性_通常_葉3CP.Update();
				this.X0Y2_植性_通常_葉2CP.Update();
				this.X0Y2_植性_通常_葉1CP.Update();
				this.X0Y2_植性_欠損_葉3CP.Update();
				this.X0Y2_植性_欠損_葉2CP.Update();
				this.X0Y2_植性_欠損_葉1CP.Update();
				this.X0Y2_傷I1CP.Update();
				this.X0Y2_傷I2CP.Update();
				this.X0Y2_傷I3CP.Update();
				this.X0Y2_ハイライト1CP.Update();
				this.X0Y2_ハイライト2CP.Update();
				this.X0Y2_パンストCP.Update();
				this.X0Y2_パンスト_ハイライトCP.Update();
				this.X0Y2_ニ\u30FCハイ_ニ\u30FCハイ1CP.Update();
				this.X0Y2_ニ\u30FCハイ_ニ\u30FCハイ2CP.Update();
				this.X0Y2_ニ\u30FCハイ_ハイライトCP.Update();
				return;
			case 3:
				this.X0Y3_腿CP.Update();
				this.X0Y3_筋CP.Update();
				this.X0Y3_獣性_獣毛1CP.Update();
				this.X0Y3_獣性_獣毛2CP.Update();
				this.X0Y3_淫タトゥ_タトゥ左1CP.Update();
				this.X0Y3_淫タトゥ_タトゥ右1CP.Update();
				this.X0Y3_淫タトゥ_タトゥ左2CP.Update();
				this.X0Y3_淫タトゥ_タトゥ右2CP.Update();
				this.X0Y3_悪タトゥ1_文字_文字c_枠CP.Update();
				this.X0Y3_悪タトゥ1_文字_文字c_文字タトゥ1CP.Update();
				this.X0Y3_悪タトゥ1_文字_文字c_文字タトゥ2CP.Update();
				this.X0Y3_悪タトゥ1_文字_文字d_枠CP.Update();
				this.X0Y3_悪タトゥ1_文字_文字d_文字タトゥ1CP.Update();
				this.X0Y3_悪タトゥ1_文字_文字d_文字タトゥ2CP.Update();
				this.X0Y3_悪タトゥ1_文字_文字e_枠CP.Update();
				this.X0Y3_悪タトゥ1_文字_文字e_文字タトゥ1CP.Update();
				this.X0Y3_悪タトゥ1_文字_文字e_文字タトゥ2CP.Update();
				this.X0Y3_悪タトゥ1_文字_文字e_文字タトゥ3CP.Update();
				this.X0Y3_悪タトゥ1_文字_文字a_枠CP.Update();
				this.X0Y3_悪タトゥ1_文字_文字a_文字タトゥ1CP.Update();
				this.X0Y3_悪タトゥ1_文字_文字a_文字タトゥ2CP.Update();
				this.X0Y3_悪タトゥ1_文字_文字b_枠CP.Update();
				this.X0Y3_悪タトゥ1_文字_文字b_文字タトゥ1CP.Update();
				this.X0Y3_悪タトゥ1_文字_文字b_文字タトゥ2CP.Update();
				this.X0Y3_悪タトゥ1_タトゥ1CP.Update();
				this.X0Y3_悪タトゥ1_タトゥ2CP.Update();
				this.X0Y3_悪タトゥ2_逆十字_逆十字1CP.Update();
				this.X0Y3_悪タトゥ2_逆十字_逆十字2CP.Update();
				this.X0Y3_鱗_鱗1CP.Update();
				this.X0Y3_鱗_鱗2CP.Update();
				this.X0Y3_鱗_鱗3CP.Update();
				this.X0Y3_鱗_鱗4CP.Update();
				this.X0Y3_紋柄_紋1CP.Update();
				this.X0Y3_紋柄_紋2CP.Update();
				this.X0Y3_紋柄_紋3CP.Update();
				this.X0Y3_紋柄_紋4CP.Update();
				this.X0Y3_植性_通常_葉3CP.Update();
				this.X0Y3_植性_通常_葉2CP.Update();
				this.X0Y3_植性_通常_葉1CP.Update();
				this.X0Y3_植性_欠損_葉3CP.Update();
				this.X0Y3_植性_欠損_葉2CP.Update();
				this.X0Y3_植性_欠損_葉1CP.Update();
				this.X0Y3_傷I1CP.Update();
				this.X0Y3_傷I2CP.Update();
				this.X0Y3_傷I3CP.Update();
				this.X0Y3_傷XCP.Update();
				this.X0Y3_ハイライト1CP.Update();
				this.X0Y3_ハイライト2CP.Update();
				this.X0Y3_パンストCP.Update();
				this.X0Y3_パンスト_ハイライトCP.Update();
				this.X0Y3_ニ\u30FCハイ_ニ\u30FCハイ1CP.Update();
				this.X0Y3_ニ\u30FCハイ_ニ\u30FCハイ2CP.Update();
				this.X0Y3_ニ\u30FCハイ_ハイライトCP.Update();
				return;
			default:
				this.X0Y4_腿CP.Update();
				this.X0Y4_筋CP.Update();
				this.X0Y4_獣性_獣毛1CP.Update();
				this.X0Y4_獣性_獣毛2CP.Update();
				this.X0Y4_淫タトゥ_タトゥ左1CP.Update();
				this.X0Y4_淫タトゥ_タトゥ右1CP.Update();
				this.X0Y4_淫タトゥ_タトゥ左2CP.Update();
				this.X0Y4_淫タトゥ_タトゥ右2CP.Update();
				this.X0Y4_悪タトゥ1_文字_文字d_枠CP.Update();
				this.X0Y4_悪タトゥ1_文字_文字d_文字タトゥ1CP.Update();
				this.X0Y4_悪タトゥ1_文字_文字d_文字タトゥ2CP.Update();
				this.X0Y4_悪タトゥ1_文字_文字e_枠CP.Update();
				this.X0Y4_悪タトゥ1_文字_文字e_文字タトゥ1CP.Update();
				this.X0Y4_悪タトゥ1_文字_文字e_文字タトゥ2CP.Update();
				this.X0Y4_悪タトゥ1_文字_文字e_文字タトゥ3CP.Update();
				this.X0Y4_悪タトゥ1_文字_文字a_枠CP.Update();
				this.X0Y4_悪タトゥ1_文字_文字a_文字タトゥ1CP.Update();
				this.X0Y4_悪タトゥ1_文字_文字a_文字タトゥ2CP.Update();
				this.X0Y4_悪タトゥ1_文字_文字b_枠CP.Update();
				this.X0Y4_悪タトゥ1_文字_文字b_文字タトゥ1CP.Update();
				this.X0Y4_悪タトゥ1_文字_文字b_文字タトゥ2CP.Update();
				this.X0Y4_悪タトゥ1_文字_文字c_枠CP.Update();
				this.X0Y4_悪タトゥ1_文字_文字c_文字タトゥ1CP.Update();
				this.X0Y4_悪タトゥ1_文字_文字c_文字タトゥ2CP.Update();
				this.X0Y4_悪タトゥ1_タトゥ1CP.Update();
				this.X0Y4_悪タトゥ1_タトゥ2CP.Update();
				this.X0Y4_鱗_鱗1CP.Update();
				this.X0Y4_鱗_鱗2CP.Update();
				this.X0Y4_鱗_鱗3CP.Update();
				this.X0Y4_鱗_鱗4CP.Update();
				this.X0Y4_紋柄_紋1CP.Update();
				this.X0Y4_紋柄_紋2CP.Update();
				this.X0Y4_紋柄_紋3CP.Update();
				this.X0Y4_紋柄_紋4CP.Update();
				this.X0Y4_植性_通常_葉3CP.Update();
				this.X0Y4_植性_通常_葉2CP.Update();
				this.X0Y4_植性_通常_葉1CP.Update();
				this.X0Y4_植性_欠損_葉3CP.Update();
				this.X0Y4_植性_欠損_葉2CP.Update();
				this.X0Y4_植性_欠損_葉1CP.Update();
				this.X0Y4_傷I1CP.Update();
				this.X0Y4_傷XCP.Update();
				this.X0Y4_ハイライト1CP.Update();
				this.X0Y4_ハイライト2CP.Update();
				this.X0Y4_パンストCP.Update();
				this.X0Y4_パンスト_ハイライトCP.Update();
				this.X0Y4_ニ\u30FCハイ_ニ\u30FCハイ1CP.Update();
				this.X0Y4_ニ\u30FCハイ_ニ\u30FCハイ2CP.Update();
				this.X0Y4_ニ\u30FCハイ_ハイライトCP.Update();
				return;
			}
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
			case 配色指定.C0:
				this.配色C0(体配色);
				return;
			case 配色指定.CT0:
				this.配色CT0(体配色);
				return;
			case 配色指定.CT1:
				this.配色CT1(体配色);
				return;
			}
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.腿0CD = new ColorD(ref Col.Black, ref 体配色.人肌R);
			this.腿1CD = new ColorD(ref Col.Black, ref 体配色.人肌R);
			this.腿2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.腿3CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.腿4CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.獣性_獣毛1_0CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛2_0CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛1_1CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛2_1CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛1_2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2_2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛1_3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2_3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛1_4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2_4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.淫タトゥ_ハ\u30FCト_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ1_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ2_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ2_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.植性_葉3_0CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉2_0CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉1_0CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉3_1CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉2_1CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉1_1CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉3_2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉2_2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉1_2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉3_3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉2_3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉1_3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉3_4CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉2_4CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉1_4CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.虫性_器官1CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.虫性_器官2CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I3CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I4CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷XCD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2R);
			this.パンストCD = new ColorD();
			this.パンスト_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ニ\u30FCハイ_ニ\u30FCハイ1CD = new ColorD();
			this.ニ\u30FCハイ_ニ\u30FCハイ2CD = new ColorD();
			this.ニ\u30FCハイ_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.腿0CD = new ColorD(ref Col.Black, ref 体配色.人肌R);
			this.腿1CD = new ColorD(ref Col.Black, ref 体配色.人肌R);
			this.腿2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.腿3CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.腿4CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.獣性_獣毛1_0CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛2_0CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛1_1CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛2_1CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛1_2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2_2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛1_3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2_3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛1_4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2_4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.淫タトゥ_ハ\u30FCト_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ1_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ2_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ2_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.植性_葉3_0CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉2_0CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.植性_葉1_0CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉3_1CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉2_1CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.植性_葉1_1CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉3_2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉2_2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性_葉1_2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉3_3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉2_3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性_葉1_3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉3_4CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉2_4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性_葉1_4CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.虫性_器官1CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.虫性_器官2CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I3CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I4CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷XCD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2R);
			this.パンストCD = new ColorD();
			this.パンスト_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ニ\u30FCハイ_ニ\u30FCハイ1CD = new ColorD();
			this.ニ\u30FCハイ_ニ\u30FCハイ2CD = new ColorD();
			this.ニ\u30FCハイ_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.腿0CD = new ColorD(ref Col.Black, ref 体配色.人肌R);
			this.腿1CD = new ColorD(ref Col.Black, ref 体配色.人肌R);
			this.腿2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.腿3CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.腿4CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.獣性_獣毛1_0CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛2_0CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛1_1CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛2_1CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛1_2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2_2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛1_3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2_3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛1_4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2_4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.淫タトゥ_ハ\u30FCト_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ1_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ2_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ2_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.植性_葉3_0CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.植性_葉2_0CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉1_0CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.植性_葉3_1CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.植性_葉2_1CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉1_1CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.植性_葉3_2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性_葉2_2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉1_2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性_葉3_3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性_葉2_3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉1_3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性_葉3_4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性_葉2_4CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉1_4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性_器官1CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.虫性_器官2CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I3CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I4CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷XCD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2R);
			this.パンストCD = new ColorD();
			this.パンスト_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ニ\u30FCハイ_ニ\u30FCハイ1CD = new ColorD();
			this.ニ\u30FCハイ_ニ\u30FCハイ2CD = new ColorD();
			this.ニ\u30FCハイ_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
		}

		private void 配色C0(体配色 体配色)
		{
			this.腿0CD = new ColorD(ref Col.Black, ref 体配色.甲0R);
			this.腿1CD = new ColorD(ref Col.Black, ref 体配色.甲0R);
			this.腿2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.腿3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.腿4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.獣性_獣毛1_0CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛2_0CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛1_1CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛2_1CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛1_2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2_2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛1_3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2_3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛1_4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2_4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.淫タトゥ_ハ\u30FCト_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ1_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ2_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ2_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.植性_葉3_0CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉2_0CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉1_0CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉3_1CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉2_1CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉1_1CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉3_2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉2_2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉1_2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉3_3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉2_3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉1_3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉3_4CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉2_4CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉1_4CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.虫性_器官1CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.虫性_器官2CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I3CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I4CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷XCD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2R);
			this.パンストCD = new ColorD();
			this.パンスト_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ニ\u30FCハイ_ニ\u30FCハイ1CD = new ColorD();
			this.ニ\u30FCハイ_ニ\u30FCハイ2CD = new ColorD();
			this.ニ\u30FCハイ_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
		}

		private void 配色CT1(体配色 体配色)
		{
			this.腿0CD = new ColorD(ref Col.Black, ref 体配色.甲0R);
			this.腿1CD = new ColorD(ref Col.Black, ref 体配色.甲0R);
			this.腿2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.腿3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.腿4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.獣性_獣毛1_0CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛2_0CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛1_1CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛2_1CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛1_2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2_2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛1_3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2_3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛1_4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2_4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.淫タトゥ_ハ\u30FCト_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ1_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ2_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ2_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.植性_葉3_0CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉2_0CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.植性_葉1_0CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉3_1CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉2_1CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.植性_葉1_1CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉3_2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉2_2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性_葉1_2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉3_3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉2_3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性_葉1_3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉3_4CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉2_4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性_葉1_4CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.虫性_器官1CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.虫性_器官2CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I3CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I4CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷XCD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2R);
			this.パンストCD = new ColorD();
			this.パンスト_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ニ\u30FCハイ_ニ\u30FCハイ1CD = new ColorD();
			this.ニ\u30FCハイ_ニ\u30FCハイ2CD = new ColorD();
			this.ニ\u30FCハイ_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
		}

		private void 配色CT0(体配色 体配色)
		{
			this.腿0CD = new ColorD(ref Col.Black, ref 体配色.甲0R);
			this.腿1CD = new ColorD(ref Col.Black, ref 体配色.甲0R);
			this.腿2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.腿3CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.腿4CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.筋CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
			this.獣性_獣毛1_0CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛2_0CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛1_1CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛2_1CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
			this.獣性_獣毛1_2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2_2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛1_3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2_3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛1_4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_獣毛2_4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.淫タトゥ_ハ\u30FCト_タトゥ左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_ハ\u30FCト_タトゥ右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ左2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.淫タトゥ_タトゥ右2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字a_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字a_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字a_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字b_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字b_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字b_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字c_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字c_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字c_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字d_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字d_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字d_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字e_枠CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ1_文字_文字e_文字タトゥ1CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字e_文字タトゥ2CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_文字_文字e_文字タトゥ3CD = new ColorD(ref 体配色.刺青.Col1, ref 体配色.刺青);
			this.悪タトゥ1_タトゥ1CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ1_タトゥ2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.悪タトゥ2_逆十字_逆十字1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ2_逆十字_逆十字2CD = new ColorD(ref Col.Black, ref 体配色.刺青);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.竜性_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.紋柄_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.紋柄_紋4CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.植性_葉3_0CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.植性_葉2_0CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉1_0CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.植性_葉3_1CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.植性_葉2_1CD = new ColorD(ref Col.Black, ref 体配色.植1R);
			this.植性_葉1_1CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.植性_葉3_2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性_葉2_2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉1_2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性_葉3_3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性_葉2_3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉1_3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性_葉3_4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.植性_葉2_4CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.植性_葉1_4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.虫性_器官1CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.虫性_器官2CD = new ColorD(ref Col.Black, ref 体配色.甲1R);
			this.傷I1CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I2CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I3CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷I4CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.傷XCD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
			this.ハイライト1CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ハイライト2CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2R);
			this.パンストCD = new ColorD();
			this.パンスト_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
			this.ニ\u30FCハイ_ニ\u30FCハイ1CD = new ColorD();
			this.ニ\u30FCハイ_ニ\u30FCハイ2CD = new ColorD();
			this.ニ\u30FCハイ_ハイライトCD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
		}

		public Par X0Y0_腿;

		public Par X0Y0_筋;

		public Par X0Y0_獣性_獣毛1;

		public Par X0Y0_獣性_獣毛2;

		public Par X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左;

		public Par X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右;

		public Par X0Y0_淫タトゥ_タトゥ左1;

		public Par X0Y0_淫タトゥ_タトゥ右1;

		public Par X0Y0_淫タトゥ_タトゥ左2;

		public Par X0Y0_淫タトゥ_タトゥ右2;

		public Par X0Y0_悪タトゥ1_文字_文字a_枠;

		public Par X0Y0_悪タトゥ1_文字_文字a_文字タトゥ1;

		public Par X0Y0_悪タトゥ1_文字_文字a_文字タトゥ2;

		public Par X0Y0_悪タトゥ1_文字_文字b_枠;

		public Par X0Y0_悪タトゥ1_文字_文字b_文字タトゥ1;

		public Par X0Y0_悪タトゥ1_文字_文字b_文字タトゥ2;

		public Par X0Y0_悪タトゥ1_文字_文字c_枠;

		public Par X0Y0_悪タトゥ1_文字_文字c_文字タトゥ1;

		public Par X0Y0_悪タトゥ1_文字_文字c_文字タトゥ2;

		public Par X0Y0_悪タトゥ1_文字_文字d_枠;

		public Par X0Y0_悪タトゥ1_文字_文字d_文字タトゥ1;

		public Par X0Y0_悪タトゥ1_文字_文字d_文字タトゥ2;

		public Par X0Y0_悪タトゥ1_文字_文字e_枠;

		public Par X0Y0_悪タトゥ1_文字_文字e_文字タトゥ1;

		public Par X0Y0_悪タトゥ1_文字_文字e_文字タトゥ2;

		public Par X0Y0_悪タトゥ1_文字_文字e_文字タトゥ3;

		public Par X0Y0_悪タトゥ1_タトゥ1;

		public Par X0Y0_悪タトゥ1_タトゥ2;

		public Par X0Y0_悪タトゥ2_逆十字_逆十字1;

		public Par X0Y0_悪タトゥ2_逆十字_逆十字2;

		public Par X0Y0_竜性_鱗1;

		public Par X0Y0_竜性_鱗2;

		public Par X0Y0_竜性_鱗3;

		public Par X0Y0_竜性_鱗4;

		public Par X0Y0_紋柄_紋1;

		public Par X0Y0_紋柄_紋2;

		public Par X0Y0_紋柄_紋3;

		public Par X0Y0_紋柄_紋4;

		public Par X0Y0_植性_通常_葉3;

		public Par X0Y0_植性_通常_葉2;

		public Par X0Y0_植性_通常_葉1;

		public Par X0Y0_植性_欠損_葉3;

		public Par X0Y0_植性_欠損_葉2;

		public Par X0Y0_植性_欠損_葉1;

		public Par X0Y0_虫性_器官1;

		public Par X0Y0_虫性_器官2;

		public Par X0Y0_傷I1;

		public Par X0Y0_傷I2;

		public Par X0Y0_傷I3;

		public Par X0Y0_傷I4;

		public Par X0Y0_傷X;

		public Par X0Y0_ハイライト1;

		public Par X0Y0_ハイライト2;

		public Par X0Y0_パンスト;

		public Par X0Y0_パンスト_ハイライト;

		public Par X0Y0_ニ\u30FCハイ_ニ\u30FCハイ1;

		public Par X0Y0_ニ\u30FCハイ_ニ\u30FCハイ2;

		public Par X0Y0_ニ\u30FCハイ_ハイライト;

		public Par X0Y1_腿;

		public Par X0Y1_筋;

		public Par X0Y1_獣性_獣毛1;

		public Par X0Y1_獣性_獣毛2;

		public Par X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左;

		public Par X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右;

		public Par X0Y1_淫タトゥ_タトゥ左1;

		public Par X0Y1_淫タトゥ_タトゥ右1;

		public Par X0Y1_淫タトゥ_タトゥ左2;

		public Par X0Y1_淫タトゥ_タトゥ右2;

		public Par X0Y1_悪タトゥ1_文字_文字a_枠;

		public Par X0Y1_悪タトゥ1_文字_文字a_文字タトゥ1;

		public Par X0Y1_悪タトゥ1_文字_文字a_文字タトゥ2;

		public Par X0Y1_悪タトゥ1_文字_文字b_枠;

		public Par X0Y1_悪タトゥ1_文字_文字b_文字タトゥ1;

		public Par X0Y1_悪タトゥ1_文字_文字b_文字タトゥ2;

		public Par X0Y1_悪タトゥ1_文字_文字c_枠;

		public Par X0Y1_悪タトゥ1_文字_文字c_文字タトゥ1;

		public Par X0Y1_悪タトゥ1_文字_文字c_文字タトゥ2;

		public Par X0Y1_悪タトゥ1_文字_文字d_枠;

		public Par X0Y1_悪タトゥ1_文字_文字d_文字タトゥ1;

		public Par X0Y1_悪タトゥ1_文字_文字d_文字タトゥ2;

		public Par X0Y1_悪タトゥ1_文字_文字e_枠;

		public Par X0Y1_悪タトゥ1_文字_文字e_文字タトゥ1;

		public Par X0Y1_悪タトゥ1_文字_文字e_文字タトゥ2;

		public Par X0Y1_悪タトゥ1_文字_文字e_文字タトゥ3;

		public Par X0Y1_悪タトゥ1_タトゥ1;

		public Par X0Y1_悪タトゥ1_タトゥ2;

		public Par X0Y1_悪タトゥ2_逆十字_逆十字1;

		public Par X0Y1_悪タトゥ2_逆十字_逆十字2;

		public Par X0Y1_鱗_鱗1;

		public Par X0Y1_鱗_鱗2;

		public Par X0Y1_鱗_鱗3;

		public Par X0Y1_鱗_鱗4;

		public Par X0Y1_紋柄_紋1;

		public Par X0Y1_紋柄_紋2;

		public Par X0Y1_紋柄_紋3;

		public Par X0Y1_紋柄_紋4;

		public Par X0Y1_植性_通常_葉3;

		public Par X0Y1_植性_通常_葉2;

		public Par X0Y1_植性_通常_葉1;

		public Par X0Y1_植性_欠損_葉3;

		public Par X0Y1_植性_欠損_葉2;

		public Par X0Y1_植性_欠損_葉1;

		public Par X0Y1_虫性_器官1;

		public Par X0Y1_虫性_器官2;

		public Par X0Y1_傷I1;

		public Par X0Y1_傷I2;

		public Par X0Y1_傷I3;

		public Par X0Y1_傷I4;

		public Par X0Y1_傷X;

		public Par X0Y1_ハイライト1;

		public Par X0Y1_ハイライト2;

		public Par X0Y1_パンスト;

		public Par X0Y1_パンスト_ハイライト;

		public Par X0Y1_ニ\u30FCハイ_ニ\u30FCハイ1;

		public Par X0Y1_ニ\u30FCハイ_ニ\u30FCハイ2;

		public Par X0Y1_ニ\u30FCハイ_ハイライト;

		public Par X0Y2_腿;

		public Par X0Y2_筋;

		public Par X0Y2_獣性_獣毛1;

		public Par X0Y2_獣性_獣毛2;

		public Par X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左;

		public Par X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右;

		public Par X0Y2_淫タトゥ_タトゥ右1;

		public Par X0Y2_淫タトゥ_タトゥ右2;

		public Par X0Y2_悪タトゥ1_文字_文字b_枠;

		public Par X0Y2_悪タトゥ1_文字_文字b_文字タトゥ1;

		public Par X0Y2_悪タトゥ1_文字_文字b_文字タトゥ2;

		public Par X0Y2_悪タトゥ1_文字_文字c_枠;

		public Par X0Y2_悪タトゥ1_文字_文字c_文字タトゥ1;

		public Par X0Y2_悪タトゥ1_文字_文字c_文字タトゥ2;

		public Par X0Y2_悪タトゥ1_文字_文字d_枠;

		public Par X0Y2_悪タトゥ1_文字_文字d_文字タトゥ1;

		public Par X0Y2_悪タトゥ1_文字_文字d_文字タトゥ2;

		public Par X0Y2_悪タトゥ1_文字_文字e_枠;

		public Par X0Y2_悪タトゥ1_文字_文字e_文字タトゥ1;

		public Par X0Y2_悪タトゥ1_文字_文字e_文字タトゥ2;

		public Par X0Y2_悪タトゥ1_文字_文字e_文字タトゥ3;

		public Par X0Y2_悪タトゥ1_文字_文字a_枠;

		public Par X0Y2_悪タトゥ1_文字_文字a_文字タトゥ1;

		public Par X0Y2_悪タトゥ1_文字_文字a_文字タトゥ2;

		public Par X0Y2_悪タトゥ1_タトゥ1;

		public Par X0Y2_悪タトゥ1_タトゥ2;

		public Par X0Y2_悪タトゥ2_逆十字_逆十字1;

		public Par X0Y2_悪タトゥ2_逆十字_逆十字2;

		public Par X0Y2_植性_通常_葉3;

		public Par X0Y2_植性_通常_葉2;

		public Par X0Y2_植性_通常_葉1;

		public Par X0Y2_植性_欠損_葉3;

		public Par X0Y2_植性_欠損_葉2;

		public Par X0Y2_植性_欠損_葉1;

		public Par X0Y2_傷I1;

		public Par X0Y2_傷I2;

		public Par X0Y2_傷I3;

		public Par X0Y2_ハイライト1;

		public Par X0Y2_ハイライト2;

		public Par X0Y2_パンスト;

		public Par X0Y2_パンスト_ハイライト;

		public Par X0Y2_ニ\u30FCハイ_ニ\u30FCハイ1;

		public Par X0Y2_ニ\u30FCハイ_ニ\u30FCハイ2;

		public Par X0Y2_ニ\u30FCハイ_ハイライト;

		public Par X0Y3_腿;

		public Par X0Y3_筋;

		public Par X0Y3_獣性_獣毛1;

		public Par X0Y3_獣性_獣毛2;

		public Par X0Y3_淫タトゥ_タトゥ左1;

		public Par X0Y3_淫タトゥ_タトゥ右1;

		public Par X0Y3_淫タトゥ_タトゥ左2;

		public Par X0Y3_淫タトゥ_タトゥ右2;

		public Par X0Y3_悪タトゥ1_文字_文字c_枠;

		public Par X0Y3_悪タトゥ1_文字_文字c_文字タトゥ1;

		public Par X0Y3_悪タトゥ1_文字_文字c_文字タトゥ2;

		public Par X0Y3_悪タトゥ1_文字_文字d_枠;

		public Par X0Y3_悪タトゥ1_文字_文字d_文字タトゥ1;

		public Par X0Y3_悪タトゥ1_文字_文字d_文字タトゥ2;

		public Par X0Y3_悪タトゥ1_文字_文字e_枠;

		public Par X0Y3_悪タトゥ1_文字_文字e_文字タトゥ1;

		public Par X0Y3_悪タトゥ1_文字_文字e_文字タトゥ2;

		public Par X0Y3_悪タトゥ1_文字_文字e_文字タトゥ3;

		public Par X0Y3_悪タトゥ1_文字_文字a_枠;

		public Par X0Y3_悪タトゥ1_文字_文字a_文字タトゥ1;

		public Par X0Y3_悪タトゥ1_文字_文字a_文字タトゥ2;

		public Par X0Y3_悪タトゥ1_文字_文字b_枠;

		public Par X0Y3_悪タトゥ1_文字_文字b_文字タトゥ1;

		public Par X0Y3_悪タトゥ1_文字_文字b_文字タトゥ2;

		public Par X0Y3_悪タトゥ1_タトゥ1;

		public Par X0Y3_悪タトゥ1_タトゥ2;

		public Par X0Y3_悪タトゥ2_逆十字_逆十字1;

		public Par X0Y3_悪タトゥ2_逆十字_逆十字2;

		public Par X0Y3_鱗_鱗1;

		public Par X0Y3_鱗_鱗2;

		public Par X0Y3_鱗_鱗3;

		public Par X0Y3_鱗_鱗4;

		public Par X0Y3_紋柄_紋1;

		public Par X0Y3_紋柄_紋2;

		public Par X0Y3_紋柄_紋3;

		public Par X0Y3_紋柄_紋4;

		public Par X0Y3_植性_通常_葉3;

		public Par X0Y3_植性_通常_葉2;

		public Par X0Y3_植性_通常_葉1;

		public Par X0Y3_植性_欠損_葉3;

		public Par X0Y3_植性_欠損_葉2;

		public Par X0Y3_植性_欠損_葉1;

		public Par X0Y3_傷I1;

		public Par X0Y3_傷I2;

		public Par X0Y3_傷I3;

		public Par X0Y3_傷X;

		public Par X0Y3_ハイライト1;

		public Par X0Y3_ハイライト2;

		public Par X0Y3_パンスト;

		public Par X0Y3_パンスト_ハイライト;

		public Par X0Y3_ニ\u30FCハイ_ニ\u30FCハイ1;

		public Par X0Y3_ニ\u30FCハイ_ニ\u30FCハイ2;

		public Par X0Y3_ニ\u30FCハイ_ハイライト;

		public Par X0Y4_腿;

		public Par X0Y4_筋;

		public Par X0Y4_獣性_獣毛1;

		public Par X0Y4_獣性_獣毛2;

		public Par X0Y4_淫タトゥ_タトゥ左1;

		public Par X0Y4_淫タトゥ_タトゥ右1;

		public Par X0Y4_淫タトゥ_タトゥ左2;

		public Par X0Y4_淫タトゥ_タトゥ右2;

		public Par X0Y4_悪タトゥ1_文字_文字d_枠;

		public Par X0Y4_悪タトゥ1_文字_文字d_文字タトゥ1;

		public Par X0Y4_悪タトゥ1_文字_文字d_文字タトゥ2;

		public Par X0Y4_悪タトゥ1_文字_文字e_枠;

		public Par X0Y4_悪タトゥ1_文字_文字e_文字タトゥ1;

		public Par X0Y4_悪タトゥ1_文字_文字e_文字タトゥ2;

		public Par X0Y4_悪タトゥ1_文字_文字e_文字タトゥ3;

		public Par X0Y4_悪タトゥ1_文字_文字a_枠;

		public Par X0Y4_悪タトゥ1_文字_文字a_文字タトゥ1;

		public Par X0Y4_悪タトゥ1_文字_文字a_文字タトゥ2;

		public Par X0Y4_悪タトゥ1_文字_文字b_枠;

		public Par X0Y4_悪タトゥ1_文字_文字b_文字タトゥ1;

		public Par X0Y4_悪タトゥ1_文字_文字b_文字タトゥ2;

		public Par X0Y4_悪タトゥ1_文字_文字c_枠;

		public Par X0Y4_悪タトゥ1_文字_文字c_文字タトゥ1;

		public Par X0Y4_悪タトゥ1_文字_文字c_文字タトゥ2;

		public Par X0Y4_悪タトゥ1_タトゥ1;

		public Par X0Y4_悪タトゥ1_タトゥ2;

		public Par X0Y4_鱗_鱗1;

		public Par X0Y4_鱗_鱗2;

		public Par X0Y4_鱗_鱗3;

		public Par X0Y4_鱗_鱗4;

		public Par X0Y4_紋柄_紋1;

		public Par X0Y4_紋柄_紋2;

		public Par X0Y4_紋柄_紋3;

		public Par X0Y4_紋柄_紋4;

		public Par X0Y4_植性_通常_葉3;

		public Par X0Y4_植性_通常_葉2;

		public Par X0Y4_植性_通常_葉1;

		public Par X0Y4_植性_欠損_葉3;

		public Par X0Y4_植性_欠損_葉2;

		public Par X0Y4_植性_欠損_葉1;

		public Par X0Y4_傷I1;

		public Par X0Y4_傷X;

		public Par X0Y4_ハイライト1;

		public Par X0Y4_ハイライト2;

		public Par X0Y4_パンスト;

		public Par X0Y4_パンスト_ハイライト;

		public Par X0Y4_ニ\u30FCハイ_ニ\u30FCハイ1;

		public Par X0Y4_ニ\u30FCハイ_ニ\u30FCハイ2;

		public Par X0Y4_ニ\u30FCハイ_ハイライト;

		public ColorD 腿0CD;

		public ColorD 腿1CD;

		public ColorD 腿2CD;

		public ColorD 腿3CD;

		public ColorD 腿4CD;

		public ColorD 筋CD;

		public ColorD 獣性_獣毛1_0CD;

		public ColorD 獣性_獣毛2_0CD;

		public ColorD 獣性_獣毛1_1CD;

		public ColorD 獣性_獣毛2_1CD;

		public ColorD 獣性_獣毛1_2CD;

		public ColorD 獣性_獣毛2_2CD;

		public ColorD 獣性_獣毛1_3CD;

		public ColorD 獣性_獣毛2_3CD;

		public ColorD 獣性_獣毛1_4CD;

		public ColorD 獣性_獣毛2_4CD;

		public ColorD 淫タトゥ_ハ\u30FCト_タトゥ左CD;

		public ColorD 淫タトゥ_ハ\u30FCト_タトゥ右CD;

		public ColorD 淫タトゥ_タトゥ左1CD;

		public ColorD 淫タトゥ_タトゥ右1CD;

		public ColorD 淫タトゥ_タトゥ左2CD;

		public ColorD 淫タトゥ_タトゥ右2CD;

		public ColorD 悪タトゥ1_文字_文字a_枠CD;

		public ColorD 悪タトゥ1_文字_文字a_文字タトゥ1CD;

		public ColorD 悪タトゥ1_文字_文字a_文字タトゥ2CD;

		public ColorD 悪タトゥ1_文字_文字b_枠CD;

		public ColorD 悪タトゥ1_文字_文字b_文字タトゥ1CD;

		public ColorD 悪タトゥ1_文字_文字b_文字タトゥ2CD;

		public ColorD 悪タトゥ1_文字_文字c_枠CD;

		public ColorD 悪タトゥ1_文字_文字c_文字タトゥ1CD;

		public ColorD 悪タトゥ1_文字_文字c_文字タトゥ2CD;

		public ColorD 悪タトゥ1_文字_文字d_枠CD;

		public ColorD 悪タトゥ1_文字_文字d_文字タトゥ1CD;

		public ColorD 悪タトゥ1_文字_文字d_文字タトゥ2CD;

		public ColorD 悪タトゥ1_文字_文字e_枠CD;

		public ColorD 悪タトゥ1_文字_文字e_文字タトゥ1CD;

		public ColorD 悪タトゥ1_文字_文字e_文字タトゥ2CD;

		public ColorD 悪タトゥ1_文字_文字e_文字タトゥ3CD;

		public ColorD 悪タトゥ1_タトゥ1CD;

		public ColorD 悪タトゥ1_タトゥ2CD;

		public ColorD 悪タトゥ2_逆十字_逆十字1CD;

		public ColorD 悪タトゥ2_逆十字_逆十字2CD;

		public ColorD 竜性_鱗1CD;

		public ColorD 竜性_鱗2CD;

		public ColorD 竜性_鱗3CD;

		public ColorD 竜性_鱗4CD;

		public ColorD 紋柄_紋1CD;

		public ColorD 紋柄_紋2CD;

		public ColorD 紋柄_紋3CD;

		public ColorD 紋柄_紋4CD;

		public ColorD 植性_葉3_0CD;

		public ColorD 植性_葉2_0CD;

		public ColorD 植性_葉1_0CD;

		public ColorD 植性_葉3_1CD;

		public ColorD 植性_葉2_1CD;

		public ColorD 植性_葉1_1CD;

		public ColorD 植性_葉3_2CD;

		public ColorD 植性_葉2_2CD;

		public ColorD 植性_葉1_2CD;

		public ColorD 植性_葉3_3CD;

		public ColorD 植性_葉2_3CD;

		public ColorD 植性_葉1_3CD;

		public ColorD 植性_葉3_4CD;

		public ColorD 植性_葉2_4CD;

		public ColorD 植性_葉1_4CD;

		public ColorD 虫性_器官1CD;

		public ColorD 虫性_器官2CD;

		public ColorD 傷I1CD;

		public ColorD 傷I2CD;

		public ColorD 傷I3CD;

		public ColorD 傷I4CD;

		public ColorD 傷XCD;

		public ColorD ハイライト1CD;

		public ColorD ハイライト2CD;

		public ColorD パンストCD;

		public ColorD パンスト_ハイライトCD;

		public ColorD ニ\u30FCハイ_ニ\u30FCハイ1CD;

		public ColorD ニ\u30FCハイ_ニ\u30FCハイ2CD;

		public ColorD ニ\u30FCハイ_ハイライトCD;

		public ColorP X0Y0_腿CP;

		public ColorP X0Y0_筋CP;

		public ColorP X0Y0_獣性_獣毛1CP;

		public ColorP X0Y0_獣性_獣毛2CP;

		public ColorP X0Y0_淫タトゥ_ハ\u30FCト_タトゥ左CP;

		public ColorP X0Y0_淫タトゥ_ハ\u30FCト_タトゥ右CP;

		public ColorP X0Y0_淫タトゥ_タトゥ左1CP;

		public ColorP X0Y0_淫タトゥ_タトゥ右1CP;

		public ColorP X0Y0_淫タトゥ_タトゥ左2CP;

		public ColorP X0Y0_淫タトゥ_タトゥ右2CP;

		public ColorP X0Y0_悪タトゥ1_文字_文字a_枠CP;

		public ColorP X0Y0_悪タトゥ1_文字_文字a_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ1_文字_文字a_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ1_文字_文字b_枠CP;

		public ColorP X0Y0_悪タトゥ1_文字_文字b_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ1_文字_文字b_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ1_文字_文字c_枠CP;

		public ColorP X0Y0_悪タトゥ1_文字_文字c_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ1_文字_文字c_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ1_文字_文字d_枠CP;

		public ColorP X0Y0_悪タトゥ1_文字_文字d_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ1_文字_文字d_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ1_文字_文字e_枠CP;

		public ColorP X0Y0_悪タトゥ1_文字_文字e_文字タトゥ1CP;

		public ColorP X0Y0_悪タトゥ1_文字_文字e_文字タトゥ2CP;

		public ColorP X0Y0_悪タトゥ1_文字_文字e_文字タトゥ3CP;

		public ColorP X0Y0_悪タトゥ1_タトゥ1CP;

		public ColorP X0Y0_悪タトゥ1_タトゥ2CP;

		public ColorP X0Y0_悪タトゥ2_逆十字_逆十字1CP;

		public ColorP X0Y0_悪タトゥ2_逆十字_逆十字2CP;

		public ColorP X0Y0_竜性_鱗1CP;

		public ColorP X0Y0_竜性_鱗2CP;

		public ColorP X0Y0_竜性_鱗3CP;

		public ColorP X0Y0_竜性_鱗4CP;

		public ColorP X0Y0_紋柄_紋1CP;

		public ColorP X0Y0_紋柄_紋2CP;

		public ColorP X0Y0_紋柄_紋3CP;

		public ColorP X0Y0_紋柄_紋4CP;

		public ColorP X0Y0_植性_通常_葉3CP;

		public ColorP X0Y0_植性_通常_葉2CP;

		public ColorP X0Y0_植性_通常_葉1CP;

		public ColorP X0Y0_植性_欠損_葉3CP;

		public ColorP X0Y0_植性_欠損_葉2CP;

		public ColorP X0Y0_植性_欠損_葉1CP;

		public ColorP X0Y0_虫性_器官1CP;

		public ColorP X0Y0_虫性_器官2CP;

		public ColorP X0Y0_傷I1CP;

		public ColorP X0Y0_傷I2CP;

		public ColorP X0Y0_傷I3CP;

		public ColorP X0Y0_傷I4CP;

		public ColorP X0Y0_傷XCP;

		public ColorP X0Y0_ハイライト1CP;

		public ColorP X0Y0_ハイライト2CP;

		public ColorP X0Y0_パンストCP;

		public ColorP X0Y0_パンスト_ハイライトCP;

		public ColorP X0Y0_ニ\u30FCハイ_ニ\u30FCハイ1CP;

		public ColorP X0Y0_ニ\u30FCハイ_ニ\u30FCハイ2CP;

		public ColorP X0Y0_ニ\u30FCハイ_ハイライトCP;

		public ColorP X0Y1_腿CP;

		public ColorP X0Y1_筋CP;

		public ColorP X0Y1_獣性_獣毛1CP;

		public ColorP X0Y1_獣性_獣毛2CP;

		public ColorP X0Y1_淫タトゥ_ハ\u30FCト_タトゥ左CP;

		public ColorP X0Y1_淫タトゥ_ハ\u30FCト_タトゥ右CP;

		public ColorP X0Y1_淫タトゥ_タトゥ左1CP;

		public ColorP X0Y1_淫タトゥ_タトゥ右1CP;

		public ColorP X0Y1_淫タトゥ_タトゥ左2CP;

		public ColorP X0Y1_淫タトゥ_タトゥ右2CP;

		public ColorP X0Y1_悪タトゥ1_文字_文字a_枠CP;

		public ColorP X0Y1_悪タトゥ1_文字_文字a_文字タトゥ1CP;

		public ColorP X0Y1_悪タトゥ1_文字_文字a_文字タトゥ2CP;

		public ColorP X0Y1_悪タトゥ1_文字_文字b_枠CP;

		public ColorP X0Y1_悪タトゥ1_文字_文字b_文字タトゥ1CP;

		public ColorP X0Y1_悪タトゥ1_文字_文字b_文字タトゥ2CP;

		public ColorP X0Y1_悪タトゥ1_文字_文字c_枠CP;

		public ColorP X0Y1_悪タトゥ1_文字_文字c_文字タトゥ1CP;

		public ColorP X0Y1_悪タトゥ1_文字_文字c_文字タトゥ2CP;

		public ColorP X0Y1_悪タトゥ1_文字_文字d_枠CP;

		public ColorP X0Y1_悪タトゥ1_文字_文字d_文字タトゥ1CP;

		public ColorP X0Y1_悪タトゥ1_文字_文字d_文字タトゥ2CP;

		public ColorP X0Y1_悪タトゥ1_文字_文字e_枠CP;

		public ColorP X0Y1_悪タトゥ1_文字_文字e_文字タトゥ1CP;

		public ColorP X0Y1_悪タトゥ1_文字_文字e_文字タトゥ2CP;

		public ColorP X0Y1_悪タトゥ1_文字_文字e_文字タトゥ3CP;

		public ColorP X0Y1_悪タトゥ1_タトゥ1CP;

		public ColorP X0Y1_悪タトゥ1_タトゥ2CP;

		public ColorP X0Y1_悪タトゥ2_逆十字_逆十字1CP;

		public ColorP X0Y1_悪タトゥ2_逆十字_逆十字2CP;

		public ColorP X0Y1_鱗_鱗1CP;

		public ColorP X0Y1_鱗_鱗2CP;

		public ColorP X0Y1_鱗_鱗3CP;

		public ColorP X0Y1_鱗_鱗4CP;

		public ColorP X0Y1_紋柄_紋1CP;

		public ColorP X0Y1_紋柄_紋2CP;

		public ColorP X0Y1_紋柄_紋3CP;

		public ColorP X0Y1_紋柄_紋4CP;

		public ColorP X0Y1_植性_通常_葉3CP;

		public ColorP X0Y1_植性_通常_葉2CP;

		public ColorP X0Y1_植性_通常_葉1CP;

		public ColorP X0Y1_植性_欠損_葉3CP;

		public ColorP X0Y1_植性_欠損_葉2CP;

		public ColorP X0Y1_植性_欠損_葉1CP;

		public ColorP X0Y1_虫性_器官1CP;

		public ColorP X0Y1_虫性_器官2CP;

		public ColorP X0Y1_傷I1CP;

		public ColorP X0Y1_傷I2CP;

		public ColorP X0Y1_傷I3CP;

		public ColorP X0Y1_傷I4CP;

		public ColorP X0Y1_傷XCP;

		public ColorP X0Y1_ハイライト1CP;

		public ColorP X0Y1_ハイライト2CP;

		public ColorP X0Y1_パンストCP;

		public ColorP X0Y1_パンスト_ハイライトCP;

		public ColorP X0Y1_ニ\u30FCハイ_ニ\u30FCハイ1CP;

		public ColorP X0Y1_ニ\u30FCハイ_ニ\u30FCハイ2CP;

		public ColorP X0Y1_ニ\u30FCハイ_ハイライトCP;

		public ColorP X0Y2_腿CP;

		public ColorP X0Y2_筋CP;

		public ColorP X0Y2_獣性_獣毛1CP;

		public ColorP X0Y2_獣性_獣毛2CP;

		public ColorP X0Y2_淫タトゥ_ハ\u30FCト_タトゥ左CP;

		public ColorP X0Y2_淫タトゥ_ハ\u30FCト_タトゥ右CP;

		public ColorP X0Y2_淫タトゥ_タトゥ右1CP;

		public ColorP X0Y2_淫タトゥ_タトゥ右2CP;

		public ColorP X0Y2_悪タトゥ1_文字_文字b_枠CP;

		public ColorP X0Y2_悪タトゥ1_文字_文字b_文字タトゥ1CP;

		public ColorP X0Y2_悪タトゥ1_文字_文字b_文字タトゥ2CP;

		public ColorP X0Y2_悪タトゥ1_文字_文字c_枠CP;

		public ColorP X0Y2_悪タトゥ1_文字_文字c_文字タトゥ1CP;

		public ColorP X0Y2_悪タトゥ1_文字_文字c_文字タトゥ2CP;

		public ColorP X0Y2_悪タトゥ1_文字_文字d_枠CP;

		public ColorP X0Y2_悪タトゥ1_文字_文字d_文字タトゥ1CP;

		public ColorP X0Y2_悪タトゥ1_文字_文字d_文字タトゥ2CP;

		public ColorP X0Y2_悪タトゥ1_文字_文字e_枠CP;

		public ColorP X0Y2_悪タトゥ1_文字_文字e_文字タトゥ1CP;

		public ColorP X0Y2_悪タトゥ1_文字_文字e_文字タトゥ2CP;

		public ColorP X0Y2_悪タトゥ1_文字_文字e_文字タトゥ3CP;

		public ColorP X0Y2_悪タトゥ1_文字_文字a_枠CP;

		public ColorP X0Y2_悪タトゥ1_文字_文字a_文字タトゥ1CP;

		public ColorP X0Y2_悪タトゥ1_文字_文字a_文字タトゥ2CP;

		public ColorP X0Y2_悪タトゥ1_タトゥ1CP;

		public ColorP X0Y2_悪タトゥ1_タトゥ2CP;

		public ColorP X0Y2_悪タトゥ2_逆十字_逆十字1CP;

		public ColorP X0Y2_悪タトゥ2_逆十字_逆十字2CP;

		public ColorP X0Y2_植性_通常_葉3CP;

		public ColorP X0Y2_植性_通常_葉2CP;

		public ColorP X0Y2_植性_通常_葉1CP;

		public ColorP X0Y2_植性_欠損_葉3CP;

		public ColorP X0Y2_植性_欠損_葉2CP;

		public ColorP X0Y2_植性_欠損_葉1CP;

		public ColorP X0Y2_傷I1CP;

		public ColorP X0Y2_傷I2CP;

		public ColorP X0Y2_傷I3CP;

		public ColorP X0Y2_ハイライト1CP;

		public ColorP X0Y2_ハイライト2CP;

		public ColorP X0Y2_パンストCP;

		public ColorP X0Y2_パンスト_ハイライトCP;

		public ColorP X0Y2_ニ\u30FCハイ_ニ\u30FCハイ1CP;

		public ColorP X0Y2_ニ\u30FCハイ_ニ\u30FCハイ2CP;

		public ColorP X0Y2_ニ\u30FCハイ_ハイライトCP;

		public ColorP X0Y3_腿CP;

		public ColorP X0Y3_筋CP;

		public ColorP X0Y3_獣性_獣毛1CP;

		public ColorP X0Y3_獣性_獣毛2CP;

		public ColorP X0Y3_淫タトゥ_タトゥ左1CP;

		public ColorP X0Y3_淫タトゥ_タトゥ右1CP;

		public ColorP X0Y3_淫タトゥ_タトゥ左2CP;

		public ColorP X0Y3_淫タトゥ_タトゥ右2CP;

		public ColorP X0Y3_悪タトゥ1_文字_文字c_枠CP;

		public ColorP X0Y3_悪タトゥ1_文字_文字c_文字タトゥ1CP;

		public ColorP X0Y3_悪タトゥ1_文字_文字c_文字タトゥ2CP;

		public ColorP X0Y3_悪タトゥ1_文字_文字d_枠CP;

		public ColorP X0Y3_悪タトゥ1_文字_文字d_文字タトゥ1CP;

		public ColorP X0Y3_悪タトゥ1_文字_文字d_文字タトゥ2CP;

		public ColorP X0Y3_悪タトゥ1_文字_文字e_枠CP;

		public ColorP X0Y3_悪タトゥ1_文字_文字e_文字タトゥ1CP;

		public ColorP X0Y3_悪タトゥ1_文字_文字e_文字タトゥ2CP;

		public ColorP X0Y3_悪タトゥ1_文字_文字e_文字タトゥ3CP;

		public ColorP X0Y3_悪タトゥ1_文字_文字a_枠CP;

		public ColorP X0Y3_悪タトゥ1_文字_文字a_文字タトゥ1CP;

		public ColorP X0Y3_悪タトゥ1_文字_文字a_文字タトゥ2CP;

		public ColorP X0Y3_悪タトゥ1_文字_文字b_枠CP;

		public ColorP X0Y3_悪タトゥ1_文字_文字b_文字タトゥ1CP;

		public ColorP X0Y3_悪タトゥ1_文字_文字b_文字タトゥ2CP;

		public ColorP X0Y3_悪タトゥ1_タトゥ1CP;

		public ColorP X0Y3_悪タトゥ1_タトゥ2CP;

		public ColorP X0Y3_悪タトゥ2_逆十字_逆十字1CP;

		public ColorP X0Y3_悪タトゥ2_逆十字_逆十字2CP;

		public ColorP X0Y3_鱗_鱗1CP;

		public ColorP X0Y3_鱗_鱗2CP;

		public ColorP X0Y3_鱗_鱗3CP;

		public ColorP X0Y3_鱗_鱗4CP;

		public ColorP X0Y3_紋柄_紋1CP;

		public ColorP X0Y3_紋柄_紋2CP;

		public ColorP X0Y3_紋柄_紋3CP;

		public ColorP X0Y3_紋柄_紋4CP;

		public ColorP X0Y3_植性_通常_葉3CP;

		public ColorP X0Y3_植性_通常_葉2CP;

		public ColorP X0Y3_植性_通常_葉1CP;

		public ColorP X0Y3_植性_欠損_葉3CP;

		public ColorP X0Y3_植性_欠損_葉2CP;

		public ColorP X0Y3_植性_欠損_葉1CP;

		public ColorP X0Y3_傷I1CP;

		public ColorP X0Y3_傷I2CP;

		public ColorP X0Y3_傷I3CP;

		public ColorP X0Y3_傷XCP;

		public ColorP X0Y3_ハイライト1CP;

		public ColorP X0Y3_ハイライト2CP;

		public ColorP X0Y3_パンストCP;

		public ColorP X0Y3_パンスト_ハイライトCP;

		public ColorP X0Y3_ニ\u30FCハイ_ニ\u30FCハイ1CP;

		public ColorP X0Y3_ニ\u30FCハイ_ニ\u30FCハイ2CP;

		public ColorP X0Y3_ニ\u30FCハイ_ハイライトCP;

		public ColorP X0Y4_腿CP;

		public ColorP X0Y4_筋CP;

		public ColorP X0Y4_獣性_獣毛1CP;

		public ColorP X0Y4_獣性_獣毛2CP;

		public ColorP X0Y4_淫タトゥ_タトゥ左1CP;

		public ColorP X0Y4_淫タトゥ_タトゥ右1CP;

		public ColorP X0Y4_淫タトゥ_タトゥ左2CP;

		public ColorP X0Y4_淫タトゥ_タトゥ右2CP;

		public ColorP X0Y4_悪タトゥ1_文字_文字d_枠CP;

		public ColorP X0Y4_悪タトゥ1_文字_文字d_文字タトゥ1CP;

		public ColorP X0Y4_悪タトゥ1_文字_文字d_文字タトゥ2CP;

		public ColorP X0Y4_悪タトゥ1_文字_文字e_枠CP;

		public ColorP X0Y4_悪タトゥ1_文字_文字e_文字タトゥ1CP;

		public ColorP X0Y4_悪タトゥ1_文字_文字e_文字タトゥ2CP;

		public ColorP X0Y4_悪タトゥ1_文字_文字e_文字タトゥ3CP;

		public ColorP X0Y4_悪タトゥ1_文字_文字a_枠CP;

		public ColorP X0Y4_悪タトゥ1_文字_文字a_文字タトゥ1CP;

		public ColorP X0Y4_悪タトゥ1_文字_文字a_文字タトゥ2CP;

		public ColorP X0Y4_悪タトゥ1_文字_文字b_枠CP;

		public ColorP X0Y4_悪タトゥ1_文字_文字b_文字タトゥ1CP;

		public ColorP X0Y4_悪タトゥ1_文字_文字b_文字タトゥ2CP;

		public ColorP X0Y4_悪タトゥ1_文字_文字c_枠CP;

		public ColorP X0Y4_悪タトゥ1_文字_文字c_文字タトゥ1CP;

		public ColorP X0Y4_悪タトゥ1_文字_文字c_文字タトゥ2CP;

		public ColorP X0Y4_悪タトゥ1_タトゥ1CP;

		public ColorP X0Y4_悪タトゥ1_タトゥ2CP;

		public ColorP X0Y4_鱗_鱗1CP;

		public ColorP X0Y4_鱗_鱗2CP;

		public ColorP X0Y4_鱗_鱗3CP;

		public ColorP X0Y4_鱗_鱗4CP;

		public ColorP X0Y4_紋柄_紋1CP;

		public ColorP X0Y4_紋柄_紋2CP;

		public ColorP X0Y4_紋柄_紋3CP;

		public ColorP X0Y4_紋柄_紋4CP;

		public ColorP X0Y4_植性_通常_葉3CP;

		public ColorP X0Y4_植性_通常_葉2CP;

		public ColorP X0Y4_植性_通常_葉1CP;

		public ColorP X0Y4_植性_欠損_葉3CP;

		public ColorP X0Y4_植性_欠損_葉2CP;

		public ColorP X0Y4_植性_欠損_葉1CP;

		public ColorP X0Y4_傷I1CP;

		public ColorP X0Y4_傷XCP;

		public ColorP X0Y4_ハイライト1CP;

		public ColorP X0Y4_ハイライト2CP;

		public ColorP X0Y4_パンストCP;

		public ColorP X0Y4_パンスト_ハイライトCP;

		public ColorP X0Y4_ニ\u30FCハイ_ニ\u30FCハイ1CP;

		public ColorP X0Y4_ニ\u30FCハイ_ニ\u30FCハイ2CP;

		public ColorP X0Y4_ニ\u30FCハイ_ハイライトCP;

		public スタンプK キスマ\u30FCク;

		public スタンプW 鞭痕;
	}
}
