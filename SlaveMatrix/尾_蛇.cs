using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 尾_蛇 : 尾
	{
		public 尾_蛇(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 尾_蛇D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "蛇尾";
			dif.Add(new Pars(Sta.尻尾["尾"][0][13]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["尾1"].ToPars();
			this.X0Y0_尾1_根 = pars2["根"].ToPar();
			this.X0Y0_尾1_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾1_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾1_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾1_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾2"].ToPars();
			this.X0Y0_尾2_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾2_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾2_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾2_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾3"].ToPars();
			this.X0Y0_尾3_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾3_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾3_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾3_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾4"].ToPars();
			this.X0Y0_尾4_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾4_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾4_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾4_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾5"].ToPars();
			this.X0Y0_尾5_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾5_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾5_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾5_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾6"].ToPars();
			this.X0Y0_尾6_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾6_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾6_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾6_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾7"].ToPars();
			this.X0Y0_尾7_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾7_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾7_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾7_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾8"].ToPars();
			this.X0Y0_尾8_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾8_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾8_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾8_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾9"].ToPars();
			this.X0Y0_尾9_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾9_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾9_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾9_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾10"].ToPars();
			this.X0Y0_尾10_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾10_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾10_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾10_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾11"].ToPars();
			this.X0Y0_尾11_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾11_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾11_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾11_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾12"].ToPars();
			this.X0Y0_尾12_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾12_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾12_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾12_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾13"].ToPars();
			this.X0Y0_尾13_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾13_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾13_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾13_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾14"].ToPars();
			this.X0Y0_尾14_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾14_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾14_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾14_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾15"].ToPars();
			this.X0Y0_尾15_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾15_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾15_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾15_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾16"].ToPars();
			this.X0Y0_尾16_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾16_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾16_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾16_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾17"].ToPars();
			this.X0Y0_尾17_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾17_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾17_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾17_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾18"].ToPars();
			this.X0Y0_尾18_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾18_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾18_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾18_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾19"].ToPars();
			this.X0Y0_尾19_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾19_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾19_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾19_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾20"].ToPars();
			this.X0Y0_尾20_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾20_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾20_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾20_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾21"].ToPars();
			this.X0Y0_尾21_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾21_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾21_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾21_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾22"].ToPars();
			this.X0Y0_尾22_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾22_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾22_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾22_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾23"].ToPars();
			this.X0Y0_尾23_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾23_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾23_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾23_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾24"].ToPars();
			this.X0Y0_尾24_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾24_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾24_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾24_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾25"].ToPars();
			this.X0Y0_尾25_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾25_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾25_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾25_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾26"].ToPars();
			this.X0Y0_尾26_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾26_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾26_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾26_尾 = pars2["尾"].ToPar();
			pars2 = pars["輪1"].ToPars();
			this.X0Y0_輪1_革 = pars2["革"].ToPar();
			this.X0Y0_輪1_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_輪1_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_輪1_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_輪1_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_輪1_金具右 = pars2["金具右"].ToPar();
			pars2 = pars["尾27"].ToPars();
			this.X0Y0_尾27_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾27_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾27_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾27_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾28"].ToPars();
			this.X0Y0_尾28_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾28_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾28_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾28_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾29"].ToPars();
			this.X0Y0_尾29_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾29_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾29_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾29_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾30"].ToPars();
			this.X0Y0_尾30_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾30_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾30_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾30_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾31"].ToPars();
			this.X0Y0_尾31_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾31_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾31_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾31_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾32"].ToPars();
			this.X0Y0_尾32_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾32_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾32_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾32_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾33"].ToPars();
			this.X0Y0_尾33_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾33_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾33_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾33_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾34"].ToPars();
			this.X0Y0_尾34_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾34_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾34_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾34_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾35"].ToPars();
			this.X0Y0_尾35_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾35_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾35_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾35_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾36"].ToPars();
			this.X0Y0_尾36_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾36_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾36_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾36_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾37"].ToPars();
			this.X0Y0_尾37_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾37_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾37_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾37_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾38"].ToPars();
			this.X0Y0_尾38_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾38_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾38_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾38_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾39"].ToPars();
			this.X0Y0_尾39_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾39_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾39_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾39_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾40"].ToPars();
			this.X0Y0_尾40_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾40_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾40_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾40_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾41"].ToPars();
			this.X0Y0_尾41_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾41_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾41_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾41_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾42"].ToPars();
			this.X0Y0_尾42_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾42_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾42_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾42_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾43"].ToPars();
			this.X0Y0_尾43_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾43_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾43_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾43_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾44"].ToPars();
			this.X0Y0_尾44_鱗 = pars2["鱗"].ToPar();
			this.X0Y0_尾44_鱗左 = pars2["鱗左"].ToPar();
			this.X0Y0_尾44_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾44_尾 = pars2["尾"].ToPar();
			pars2 = pars["頭"].ToPars();
			Pars pars3 = pars2["上顎"].ToPars();
			this.X0Y0_頭_上顎_顎基 = pars3["顎基"].ToPar();
			this.X0Y0_頭_上顎_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_頭_上顎_鱗左1 = pars3["鱗左1"].ToPar();
			this.X0Y0_頭_上顎_鱗右1 = pars3["鱗右1"].ToPar();
			this.X0Y0_頭_上顎_鱗左2 = pars3["鱗左2"].ToPar();
			this.X0Y0_頭_上顎_鱗右2 = pars3["鱗右2"].ToPar();
			this.X0Y0_頭_上顎_鱗左3 = pars3["鱗左3"].ToPar();
			this.X0Y0_頭_上顎_鱗右3 = pars3["鱗右3"].ToPar();
			this.X0Y0_頭_上顎_鱗左4 = pars3["鱗左4"].ToPar();
			this.X0Y0_頭_上顎_鱗右4 = pars3["鱗右4"].ToPar();
			this.X0Y0_頭_上顎_鱗左5 = pars3["鱗左5"].ToPar();
			this.X0Y0_頭_上顎_鱗右5 = pars3["鱗右5"].ToPar();
			this.X0Y0_頭_上顎_鱗左8 = pars3["鱗左8"].ToPar();
			this.X0Y0_頭_上顎_鱗右8 = pars3["鱗右8"].ToPar();
			this.X0Y0_頭_上顎_鱗左9 = pars3["鱗左9"].ToPar();
			this.X0Y0_頭_上顎_鱗右9 = pars3["鱗右9"].ToPar();
			this.X0Y0_頭_上顎_鱗左10 = pars3["鱗左10"].ToPar();
			this.X0Y0_頭_上顎_鱗右10 = pars3["鱗右10"].ToPar();
			this.X0Y0_頭_上顎_鱗左11 = pars3["鱗左11"].ToPar();
			this.X0Y0_頭_上顎_鱗右11 = pars3["鱗右11"].ToPar();
			pars3 = pars2["下顎"].ToPars();
			this.X0Y0_頭_下顎_顎基 = pars3["顎基"].ToPar();
			this.X0Y0_頭_下顎_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_頭_下顎_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_頭_下顎_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_頭_下顎_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_頭_下顎_鱗左1 = pars3["鱗左1"].ToPar();
			this.X0Y0_頭_下顎_鱗右1 = pars3["鱗右1"].ToPar();
			this.X0Y0_頭_下顎_鱗左2 = pars3["鱗左2"].ToPar();
			this.X0Y0_頭_下顎_鱗右2 = pars3["鱗右2"].ToPar();
			this.X0Y0_頭_下顎_鱗左3 = pars3["鱗左3"].ToPar();
			this.X0Y0_頭_下顎_鱗右3 = pars3["鱗右3"].ToPar();
			this.X0Y0_頭_下顎_鱗左4 = pars3["鱗左4"].ToPar();
			this.X0Y0_頭_下顎_鱗右4 = pars3["鱗右4"].ToPar();
			this.X0Y0_頭_下顎_鱗左5 = pars3["鱗左5"].ToPar();
			this.X0Y0_頭_下顎_鱗右5 = pars3["鱗右5"].ToPar();
			this.X0Y0_頭_下顎_鱗左6 = pars3["鱗左6"].ToPar();
			this.X0Y0_頭_下顎_鱗右6 = pars3["鱗右6"].ToPar();
			this.X0Y0_頭_下顎_鱗左7 = pars3["鱗左7"].ToPar();
			this.X0Y0_頭_下顎_鱗右7 = pars3["鱗右7"].ToPar();
			this.X0Y0_頭_下顎_鱗左8 = pars3["鱗左8"].ToPar();
			this.X0Y0_頭_下顎_鱗右8 = pars3["鱗右8"].ToPar();
			this.X0Y0_頭_下顎_鱗左9 = pars3["鱗左9"].ToPar();
			this.X0Y0_頭_下顎_鱗右9 = pars3["鱗右9"].ToPar();
			this.X0Y0_頭_下顎_鱗左10 = pars3["鱗左10"].ToPar();
			this.X0Y0_頭_下顎_鱗右10 = pars3["鱗右10"].ToPar();
			this.X0Y0_頭_下顎_鱗左11 = pars3["鱗左11"].ToPar();
			this.X0Y0_頭_下顎_鱗右11 = pars3["鱗右11"].ToPar();
			pars2 = pars["輪2"].ToPars();
			this.X0Y0_輪2_革 = pars2["革"].ToPar();
			this.X0Y0_輪2_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_輪2_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_輪2_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_輪2_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_輪2_金具右 = pars2["金具右"].ToPar();
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
			this.尾1_根_表示 = e.尾1_根_表示;
			this.尾1_鱗_表示 = e.尾1_鱗_表示;
			this.尾1_鱗左_表示 = e.尾1_鱗左_表示;
			this.尾1_鱗右_表示 = e.尾1_鱗右_表示;
			this.尾1_尾_表示 = e.尾1_尾_表示;
			this.尾2_鱗_表示 = e.尾2_鱗_表示;
			this.尾2_鱗左_表示 = e.尾2_鱗左_表示;
			this.尾2_鱗右_表示 = e.尾2_鱗右_表示;
			this.尾2_尾_表示 = e.尾2_尾_表示;
			this.尾3_鱗_表示 = e.尾3_鱗_表示;
			this.尾3_鱗左_表示 = e.尾3_鱗左_表示;
			this.尾3_鱗右_表示 = e.尾3_鱗右_表示;
			this.尾3_尾_表示 = e.尾3_尾_表示;
			this.尾4_鱗_表示 = e.尾4_鱗_表示;
			this.尾4_鱗左_表示 = e.尾4_鱗左_表示;
			this.尾4_鱗右_表示 = e.尾4_鱗右_表示;
			this.尾4_尾_表示 = e.尾4_尾_表示;
			this.尾5_鱗_表示 = e.尾5_鱗_表示;
			this.尾5_鱗左_表示 = e.尾5_鱗左_表示;
			this.尾5_鱗右_表示 = e.尾5_鱗右_表示;
			this.尾5_尾_表示 = e.尾5_尾_表示;
			this.尾6_鱗_表示 = e.尾6_鱗_表示;
			this.尾6_鱗左_表示 = e.尾6_鱗左_表示;
			this.尾6_鱗右_表示 = e.尾6_鱗右_表示;
			this.尾6_尾_表示 = e.尾6_尾_表示;
			this.尾7_鱗_表示 = e.尾7_鱗_表示;
			this.尾7_鱗左_表示 = e.尾7_鱗左_表示;
			this.尾7_鱗右_表示 = e.尾7_鱗右_表示;
			this.尾7_尾_表示 = e.尾7_尾_表示;
			this.尾8_鱗_表示 = e.尾8_鱗_表示;
			this.尾8_鱗左_表示 = e.尾8_鱗左_表示;
			this.尾8_鱗右_表示 = e.尾8_鱗右_表示;
			this.尾8_尾_表示 = e.尾8_尾_表示;
			this.尾9_鱗_表示 = e.尾9_鱗_表示;
			this.尾9_鱗左_表示 = e.尾9_鱗左_表示;
			this.尾9_鱗右_表示 = e.尾9_鱗右_表示;
			this.尾9_尾_表示 = e.尾9_尾_表示;
			this.尾10_鱗_表示 = e.尾10_鱗_表示;
			this.尾10_鱗左_表示 = e.尾10_鱗左_表示;
			this.尾10_鱗右_表示 = e.尾10_鱗右_表示;
			this.尾10_尾_表示 = e.尾10_尾_表示;
			this.尾11_鱗_表示 = e.尾11_鱗_表示;
			this.尾11_鱗左_表示 = e.尾11_鱗左_表示;
			this.尾11_鱗右_表示 = e.尾11_鱗右_表示;
			this.尾11_尾_表示 = e.尾11_尾_表示;
			this.尾12_鱗_表示 = e.尾12_鱗_表示;
			this.尾12_鱗左_表示 = e.尾12_鱗左_表示;
			this.尾12_鱗右_表示 = e.尾12_鱗右_表示;
			this.尾12_尾_表示 = e.尾12_尾_表示;
			this.尾13_鱗_表示 = e.尾13_鱗_表示;
			this.尾13_鱗左_表示 = e.尾13_鱗左_表示;
			this.尾13_鱗右_表示 = e.尾13_鱗右_表示;
			this.尾13_尾_表示 = e.尾13_尾_表示;
			this.尾14_鱗_表示 = e.尾14_鱗_表示;
			this.尾14_鱗左_表示 = e.尾14_鱗左_表示;
			this.尾14_鱗右_表示 = e.尾14_鱗右_表示;
			this.尾14_尾_表示 = e.尾14_尾_表示;
			this.尾15_鱗_表示 = e.尾15_鱗_表示;
			this.尾15_鱗左_表示 = e.尾15_鱗左_表示;
			this.尾15_鱗右_表示 = e.尾15_鱗右_表示;
			this.尾15_尾_表示 = e.尾15_尾_表示;
			this.尾16_鱗_表示 = e.尾16_鱗_表示;
			this.尾16_鱗左_表示 = e.尾16_鱗左_表示;
			this.尾16_鱗右_表示 = e.尾16_鱗右_表示;
			this.尾16_尾_表示 = e.尾16_尾_表示;
			this.尾17_鱗_表示 = e.尾17_鱗_表示;
			this.尾17_鱗左_表示 = e.尾17_鱗左_表示;
			this.尾17_鱗右_表示 = e.尾17_鱗右_表示;
			this.尾17_尾_表示 = e.尾17_尾_表示;
			this.尾18_鱗_表示 = e.尾18_鱗_表示;
			this.尾18_鱗左_表示 = e.尾18_鱗左_表示;
			this.尾18_鱗右_表示 = e.尾18_鱗右_表示;
			this.尾18_尾_表示 = e.尾18_尾_表示;
			this.尾19_鱗_表示 = e.尾19_鱗_表示;
			this.尾19_鱗左_表示 = e.尾19_鱗左_表示;
			this.尾19_鱗右_表示 = e.尾19_鱗右_表示;
			this.尾19_尾_表示 = e.尾19_尾_表示;
			this.尾20_鱗_表示 = e.尾20_鱗_表示;
			this.尾20_鱗左_表示 = e.尾20_鱗左_表示;
			this.尾20_鱗右_表示 = e.尾20_鱗右_表示;
			this.尾20_尾_表示 = e.尾20_尾_表示;
			this.尾21_鱗_表示 = e.尾21_鱗_表示;
			this.尾21_鱗左_表示 = e.尾21_鱗左_表示;
			this.尾21_鱗右_表示 = e.尾21_鱗右_表示;
			this.尾21_尾_表示 = e.尾21_尾_表示;
			this.尾22_鱗_表示 = e.尾22_鱗_表示;
			this.尾22_鱗左_表示 = e.尾22_鱗左_表示;
			this.尾22_鱗右_表示 = e.尾22_鱗右_表示;
			this.尾22_尾_表示 = e.尾22_尾_表示;
			this.尾23_鱗_表示 = e.尾23_鱗_表示;
			this.尾23_鱗左_表示 = e.尾23_鱗左_表示;
			this.尾23_鱗右_表示 = e.尾23_鱗右_表示;
			this.尾23_尾_表示 = e.尾23_尾_表示;
			this.尾24_鱗_表示 = e.尾24_鱗_表示;
			this.尾24_鱗左_表示 = e.尾24_鱗左_表示;
			this.尾24_鱗右_表示 = e.尾24_鱗右_表示;
			this.尾24_尾_表示 = e.尾24_尾_表示;
			this.尾25_鱗_表示 = e.尾25_鱗_表示;
			this.尾25_鱗左_表示 = e.尾25_鱗左_表示;
			this.尾25_鱗右_表示 = e.尾25_鱗右_表示;
			this.尾25_尾_表示 = e.尾25_尾_表示;
			this.尾26_鱗_表示 = e.尾26_鱗_表示;
			this.尾26_鱗左_表示 = e.尾26_鱗左_表示;
			this.尾26_鱗右_表示 = e.尾26_鱗右_表示;
			this.尾26_尾_表示 = e.尾26_尾_表示;
			this.輪1_革_表示 = e.輪1_革_表示;
			this.輪1_金具1_表示 = e.輪1_金具1_表示;
			this.輪1_金具2_表示 = e.輪1_金具2_表示;
			this.輪1_金具3_表示 = e.輪1_金具3_表示;
			this.輪1_金具左_表示 = e.輪1_金具左_表示;
			this.輪1_金具右_表示 = e.輪1_金具右_表示;
			this.尾27_鱗_表示 = e.尾27_鱗_表示;
			this.尾27_鱗左_表示 = e.尾27_鱗左_表示;
			this.尾27_鱗右_表示 = e.尾27_鱗右_表示;
			this.尾27_尾_表示 = e.尾27_尾_表示;
			this.尾28_鱗_表示 = e.尾28_鱗_表示;
			this.尾28_鱗左_表示 = e.尾28_鱗左_表示;
			this.尾28_鱗右_表示 = e.尾28_鱗右_表示;
			this.尾28_尾_表示 = e.尾28_尾_表示;
			this.尾29_鱗_表示 = e.尾29_鱗_表示;
			this.尾29_鱗左_表示 = e.尾29_鱗左_表示;
			this.尾29_鱗右_表示 = e.尾29_鱗右_表示;
			this.尾29_尾_表示 = e.尾29_尾_表示;
			this.尾30_鱗_表示 = e.尾30_鱗_表示;
			this.尾30_鱗左_表示 = e.尾30_鱗左_表示;
			this.尾30_鱗右_表示 = e.尾30_鱗右_表示;
			this.尾30_尾_表示 = e.尾30_尾_表示;
			this.尾31_鱗_表示 = e.尾31_鱗_表示;
			this.尾31_鱗左_表示 = e.尾31_鱗左_表示;
			this.尾31_鱗右_表示 = e.尾31_鱗右_表示;
			this.尾31_尾_表示 = e.尾31_尾_表示;
			this.尾32_鱗_表示 = e.尾32_鱗_表示;
			this.尾32_鱗左_表示 = e.尾32_鱗左_表示;
			this.尾32_鱗右_表示 = e.尾32_鱗右_表示;
			this.尾32_尾_表示 = e.尾32_尾_表示;
			this.尾33_鱗_表示 = e.尾33_鱗_表示;
			this.尾33_鱗左_表示 = e.尾33_鱗左_表示;
			this.尾33_鱗右_表示 = e.尾33_鱗右_表示;
			this.尾33_尾_表示 = e.尾33_尾_表示;
			this.尾34_鱗_表示 = e.尾34_鱗_表示;
			this.尾34_鱗左_表示 = e.尾34_鱗左_表示;
			this.尾34_鱗右_表示 = e.尾34_鱗右_表示;
			this.尾34_尾_表示 = e.尾34_尾_表示;
			this.尾35_鱗_表示 = e.尾35_鱗_表示;
			this.尾35_鱗左_表示 = e.尾35_鱗左_表示;
			this.尾35_鱗右_表示 = e.尾35_鱗右_表示;
			this.尾35_尾_表示 = e.尾35_尾_表示;
			this.尾36_鱗_表示 = e.尾36_鱗_表示;
			this.尾36_鱗左_表示 = e.尾36_鱗左_表示;
			this.尾36_鱗右_表示 = e.尾36_鱗右_表示;
			this.尾36_尾_表示 = e.尾36_尾_表示;
			this.尾37_鱗_表示 = e.尾37_鱗_表示;
			this.尾37_鱗左_表示 = e.尾37_鱗左_表示;
			this.尾37_鱗右_表示 = e.尾37_鱗右_表示;
			this.尾37_尾_表示 = e.尾37_尾_表示;
			this.尾38_鱗_表示 = e.尾38_鱗_表示;
			this.尾38_鱗左_表示 = e.尾38_鱗左_表示;
			this.尾38_鱗右_表示 = e.尾38_鱗右_表示;
			this.尾38_尾_表示 = e.尾38_尾_表示;
			this.尾39_鱗_表示 = e.尾39_鱗_表示;
			this.尾39_鱗左_表示 = e.尾39_鱗左_表示;
			this.尾39_鱗右_表示 = e.尾39_鱗右_表示;
			this.尾39_尾_表示 = e.尾39_尾_表示;
			this.尾40_鱗_表示 = e.尾40_鱗_表示;
			this.尾40_鱗左_表示 = e.尾40_鱗左_表示;
			this.尾40_鱗右_表示 = e.尾40_鱗右_表示;
			this.尾40_尾_表示 = e.尾40_尾_表示;
			this.尾41_鱗_表示 = e.尾41_鱗_表示;
			this.尾41_鱗左_表示 = e.尾41_鱗左_表示;
			this.尾41_鱗右_表示 = e.尾41_鱗右_表示;
			this.尾41_尾_表示 = e.尾41_尾_表示;
			this.尾42_鱗_表示 = e.尾42_鱗_表示;
			this.尾42_鱗左_表示 = e.尾42_鱗左_表示;
			this.尾42_鱗右_表示 = e.尾42_鱗右_表示;
			this.尾42_尾_表示 = e.尾42_尾_表示;
			this.尾43_鱗_表示 = e.尾43_鱗_表示;
			this.尾43_鱗左_表示 = e.尾43_鱗左_表示;
			this.尾43_鱗右_表示 = e.尾43_鱗右_表示;
			this.尾43_尾_表示 = e.尾43_尾_表示;
			this.尾44_鱗_表示 = e.尾44_鱗_表示;
			this.尾44_鱗左_表示 = e.尾44_鱗左_表示;
			this.尾44_鱗右_表示 = e.尾44_鱗右_表示;
			this.尾44_尾_表示 = e.尾44_尾_表示;
			this.頭_上顎_顎基_表示 = e.頭_上顎_顎基_表示;
			this.頭_上顎_鱗4_表示 = e.頭_上顎_鱗4_表示;
			this.頭_上顎_鱗左1_表示 = e.頭_上顎_鱗左1_表示;
			this.頭_上顎_鱗右1_表示 = e.頭_上顎_鱗右1_表示;
			this.頭_上顎_鱗左2_表示 = e.頭_上顎_鱗左2_表示;
			this.頭_上顎_鱗右2_表示 = e.頭_上顎_鱗右2_表示;
			this.頭_上顎_鱗左3_表示 = e.頭_上顎_鱗左3_表示;
			this.頭_上顎_鱗右3_表示 = e.頭_上顎_鱗右3_表示;
			this.頭_上顎_鱗左4_表示 = e.頭_上顎_鱗左4_表示;
			this.頭_上顎_鱗右4_表示 = e.頭_上顎_鱗右4_表示;
			this.頭_上顎_鱗左5_表示 = e.頭_上顎_鱗左5_表示;
			this.頭_上顎_鱗右5_表示 = e.頭_上顎_鱗右5_表示;
			this.頭_上顎_鱗左8_表示 = e.頭_上顎_鱗左8_表示;
			this.頭_上顎_鱗右8_表示 = e.頭_上顎_鱗右8_表示;
			this.頭_上顎_鱗左9_表示 = e.頭_上顎_鱗左9_表示;
			this.頭_上顎_鱗右9_表示 = e.頭_上顎_鱗右9_表示;
			this.頭_上顎_鱗左10_表示 = e.頭_上顎_鱗左10_表示;
			this.頭_上顎_鱗右10_表示 = e.頭_上顎_鱗右10_表示;
			this.頭_上顎_鱗左11_表示 = e.頭_上顎_鱗左11_表示;
			this.頭_上顎_鱗右11_表示 = e.頭_上顎_鱗右11_表示;
			this.頭_下顎_顎基_表示 = e.頭_下顎_顎基_表示;
			this.頭_下顎_鱗1_表示 = e.頭_下顎_鱗1_表示;
			this.頭_下顎_鱗2_表示 = e.頭_下顎_鱗2_表示;
			this.頭_下顎_鱗3_表示 = e.頭_下顎_鱗3_表示;
			this.頭_下顎_鱗4_表示 = e.頭_下顎_鱗4_表示;
			this.頭_下顎_鱗左1_表示 = e.頭_下顎_鱗左1_表示;
			this.頭_下顎_鱗右1_表示 = e.頭_下顎_鱗右1_表示;
			this.頭_下顎_鱗左2_表示 = e.頭_下顎_鱗左2_表示;
			this.頭_下顎_鱗右2_表示 = e.頭_下顎_鱗右2_表示;
			this.頭_下顎_鱗左3_表示 = e.頭_下顎_鱗左3_表示;
			this.頭_下顎_鱗右3_表示 = e.頭_下顎_鱗右3_表示;
			this.頭_下顎_鱗左4_表示 = e.頭_下顎_鱗左4_表示;
			this.頭_下顎_鱗右4_表示 = e.頭_下顎_鱗右4_表示;
			this.頭_下顎_鱗左5_表示 = e.頭_下顎_鱗左5_表示;
			this.頭_下顎_鱗右5_表示 = e.頭_下顎_鱗右5_表示;
			this.頭_下顎_鱗左6_表示 = e.頭_下顎_鱗左6_表示;
			this.頭_下顎_鱗右6_表示 = e.頭_下顎_鱗右6_表示;
			this.頭_下顎_鱗左7_表示 = e.頭_下顎_鱗左7_表示;
			this.頭_下顎_鱗右7_表示 = e.頭_下顎_鱗右7_表示;
			this.頭_下顎_鱗左8_表示 = e.頭_下顎_鱗左8_表示;
			this.頭_下顎_鱗右8_表示 = e.頭_下顎_鱗右8_表示;
			this.頭_下顎_鱗左9_表示 = e.頭_下顎_鱗左9_表示;
			this.頭_下顎_鱗右9_表示 = e.頭_下顎_鱗右9_表示;
			this.頭_下顎_鱗左10_表示 = e.頭_下顎_鱗左10_表示;
			this.頭_下顎_鱗右10_表示 = e.頭_下顎_鱗右10_表示;
			this.頭_下顎_鱗左11_表示 = e.頭_下顎_鱗左11_表示;
			this.頭_下顎_鱗右11_表示 = e.頭_下顎_鱗右11_表示;
			this.輪2_革_表示 = e.輪2_革_表示;
			this.輪2_金具1_表示 = e.輪2_金具1_表示;
			this.輪2_金具2_表示 = e.輪2_金具2_表示;
			this.輪2_金具3_表示 = e.輪2_金具3_表示;
			this.輪2_金具左_表示 = e.輪2_金具左_表示;
			this.輪2_金具右_表示 = e.輪2_金具右_表示;
			this.輪1表示 = e.輪1表示;
			this.輪2表示 = e.輪2表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_尾1_根CP = new ColorP(this.X0Y0_尾1_根, this.尾1_根CD, DisUnit, true);
			this.X0Y0_尾1_鱗CP = new ColorP(this.X0Y0_尾1_鱗, this.尾1_鱗CD, DisUnit, true);
			this.X0Y0_尾1_鱗左CP = new ColorP(this.X0Y0_尾1_鱗左, this.尾1_鱗左CD, DisUnit, true);
			this.X0Y0_尾1_鱗右CP = new ColorP(this.X0Y0_尾1_鱗右, this.尾1_鱗右CD, DisUnit, true);
			this.X0Y0_尾1_尾CP = new ColorP(this.X0Y0_尾1_尾, this.尾1_尾CD, DisUnit, true);
			this.X0Y0_尾2_鱗CP = new ColorP(this.X0Y0_尾2_鱗, this.尾2_鱗CD, DisUnit, true);
			this.X0Y0_尾2_鱗左CP = new ColorP(this.X0Y0_尾2_鱗左, this.尾2_鱗左CD, DisUnit, true);
			this.X0Y0_尾2_鱗右CP = new ColorP(this.X0Y0_尾2_鱗右, this.尾2_鱗右CD, DisUnit, true);
			this.X0Y0_尾2_尾CP = new ColorP(this.X0Y0_尾2_尾, this.尾2_尾CD, DisUnit, true);
			this.X0Y0_尾3_鱗CP = new ColorP(this.X0Y0_尾3_鱗, this.尾3_鱗CD, DisUnit, true);
			this.X0Y0_尾3_鱗左CP = new ColorP(this.X0Y0_尾3_鱗左, this.尾3_鱗左CD, DisUnit, true);
			this.X0Y0_尾3_鱗右CP = new ColorP(this.X0Y0_尾3_鱗右, this.尾3_鱗右CD, DisUnit, true);
			this.X0Y0_尾3_尾CP = new ColorP(this.X0Y0_尾3_尾, this.尾3_尾CD, DisUnit, true);
			this.X0Y0_尾4_鱗CP = new ColorP(this.X0Y0_尾4_鱗, this.尾4_鱗CD, DisUnit, true);
			this.X0Y0_尾4_鱗左CP = new ColorP(this.X0Y0_尾4_鱗左, this.尾4_鱗左CD, DisUnit, true);
			this.X0Y0_尾4_鱗右CP = new ColorP(this.X0Y0_尾4_鱗右, this.尾4_鱗右CD, DisUnit, true);
			this.X0Y0_尾4_尾CP = new ColorP(this.X0Y0_尾4_尾, this.尾4_尾CD, DisUnit, true);
			this.X0Y0_尾5_鱗CP = new ColorP(this.X0Y0_尾5_鱗, this.尾5_鱗CD, DisUnit, true);
			this.X0Y0_尾5_鱗左CP = new ColorP(this.X0Y0_尾5_鱗左, this.尾5_鱗左CD, DisUnit, true);
			this.X0Y0_尾5_鱗右CP = new ColorP(this.X0Y0_尾5_鱗右, this.尾5_鱗右CD, DisUnit, true);
			this.X0Y0_尾5_尾CP = new ColorP(this.X0Y0_尾5_尾, this.尾5_尾CD, DisUnit, true);
			this.X0Y0_尾6_鱗CP = new ColorP(this.X0Y0_尾6_鱗, this.尾6_鱗CD, DisUnit, true);
			this.X0Y0_尾6_鱗左CP = new ColorP(this.X0Y0_尾6_鱗左, this.尾6_鱗左CD, DisUnit, true);
			this.X0Y0_尾6_鱗右CP = new ColorP(this.X0Y0_尾6_鱗右, this.尾6_鱗右CD, DisUnit, true);
			this.X0Y0_尾6_尾CP = new ColorP(this.X0Y0_尾6_尾, this.尾6_尾CD, DisUnit, true);
			this.X0Y0_尾7_鱗CP = new ColorP(this.X0Y0_尾7_鱗, this.尾7_鱗CD, DisUnit, true);
			this.X0Y0_尾7_鱗左CP = new ColorP(this.X0Y0_尾7_鱗左, this.尾7_鱗左CD, DisUnit, true);
			this.X0Y0_尾7_鱗右CP = new ColorP(this.X0Y0_尾7_鱗右, this.尾7_鱗右CD, DisUnit, true);
			this.X0Y0_尾7_尾CP = new ColorP(this.X0Y0_尾7_尾, this.尾7_尾CD, DisUnit, true);
			this.X0Y0_尾8_鱗CP = new ColorP(this.X0Y0_尾8_鱗, this.尾8_鱗CD, DisUnit, true);
			this.X0Y0_尾8_鱗左CP = new ColorP(this.X0Y0_尾8_鱗左, this.尾8_鱗左CD, DisUnit, true);
			this.X0Y0_尾8_鱗右CP = new ColorP(this.X0Y0_尾8_鱗右, this.尾8_鱗右CD, DisUnit, true);
			this.X0Y0_尾8_尾CP = new ColorP(this.X0Y0_尾8_尾, this.尾8_尾CD, DisUnit, true);
			this.X0Y0_尾9_鱗CP = new ColorP(this.X0Y0_尾9_鱗, this.尾9_鱗CD, DisUnit, true);
			this.X0Y0_尾9_鱗左CP = new ColorP(this.X0Y0_尾9_鱗左, this.尾9_鱗左CD, DisUnit, true);
			this.X0Y0_尾9_鱗右CP = new ColorP(this.X0Y0_尾9_鱗右, this.尾9_鱗右CD, DisUnit, true);
			this.X0Y0_尾9_尾CP = new ColorP(this.X0Y0_尾9_尾, this.尾9_尾CD, DisUnit, true);
			this.X0Y0_尾10_鱗CP = new ColorP(this.X0Y0_尾10_鱗, this.尾10_鱗CD, DisUnit, true);
			this.X0Y0_尾10_鱗左CP = new ColorP(this.X0Y0_尾10_鱗左, this.尾10_鱗左CD, DisUnit, true);
			this.X0Y0_尾10_鱗右CP = new ColorP(this.X0Y0_尾10_鱗右, this.尾10_鱗右CD, DisUnit, true);
			this.X0Y0_尾10_尾CP = new ColorP(this.X0Y0_尾10_尾, this.尾10_尾CD, DisUnit, true);
			this.X0Y0_尾11_鱗CP = new ColorP(this.X0Y0_尾11_鱗, this.尾11_鱗CD, DisUnit, true);
			this.X0Y0_尾11_鱗左CP = new ColorP(this.X0Y0_尾11_鱗左, this.尾11_鱗左CD, DisUnit, true);
			this.X0Y0_尾11_鱗右CP = new ColorP(this.X0Y0_尾11_鱗右, this.尾11_鱗右CD, DisUnit, true);
			this.X0Y0_尾11_尾CP = new ColorP(this.X0Y0_尾11_尾, this.尾11_尾CD, DisUnit, true);
			this.X0Y0_尾12_鱗CP = new ColorP(this.X0Y0_尾12_鱗, this.尾12_鱗CD, DisUnit, true);
			this.X0Y0_尾12_鱗左CP = new ColorP(this.X0Y0_尾12_鱗左, this.尾12_鱗左CD, DisUnit, true);
			this.X0Y0_尾12_鱗右CP = new ColorP(this.X0Y0_尾12_鱗右, this.尾12_鱗右CD, DisUnit, true);
			this.X0Y0_尾12_尾CP = new ColorP(this.X0Y0_尾12_尾, this.尾12_尾CD, DisUnit, true);
			this.X0Y0_尾13_鱗CP = new ColorP(this.X0Y0_尾13_鱗, this.尾13_鱗CD, DisUnit, true);
			this.X0Y0_尾13_鱗左CP = new ColorP(this.X0Y0_尾13_鱗左, this.尾13_鱗左CD, DisUnit, true);
			this.X0Y0_尾13_鱗右CP = new ColorP(this.X0Y0_尾13_鱗右, this.尾13_鱗右CD, DisUnit, true);
			this.X0Y0_尾13_尾CP = new ColorP(this.X0Y0_尾13_尾, this.尾13_尾CD, DisUnit, true);
			this.X0Y0_尾14_鱗CP = new ColorP(this.X0Y0_尾14_鱗, this.尾14_鱗CD, DisUnit, true);
			this.X0Y0_尾14_鱗左CP = new ColorP(this.X0Y0_尾14_鱗左, this.尾14_鱗左CD, DisUnit, true);
			this.X0Y0_尾14_鱗右CP = new ColorP(this.X0Y0_尾14_鱗右, this.尾14_鱗右CD, DisUnit, true);
			this.X0Y0_尾14_尾CP = new ColorP(this.X0Y0_尾14_尾, this.尾14_尾CD, DisUnit, true);
			this.X0Y0_尾15_鱗CP = new ColorP(this.X0Y0_尾15_鱗, this.尾15_鱗CD, DisUnit, true);
			this.X0Y0_尾15_鱗左CP = new ColorP(this.X0Y0_尾15_鱗左, this.尾15_鱗左CD, DisUnit, true);
			this.X0Y0_尾15_鱗右CP = new ColorP(this.X0Y0_尾15_鱗右, this.尾15_鱗右CD, DisUnit, true);
			this.X0Y0_尾15_尾CP = new ColorP(this.X0Y0_尾15_尾, this.尾15_尾CD, DisUnit, true);
			this.X0Y0_尾16_鱗CP = new ColorP(this.X0Y0_尾16_鱗, this.尾16_鱗CD, DisUnit, true);
			this.X0Y0_尾16_鱗左CP = new ColorP(this.X0Y0_尾16_鱗左, this.尾16_鱗左CD, DisUnit, true);
			this.X0Y0_尾16_鱗右CP = new ColorP(this.X0Y0_尾16_鱗右, this.尾16_鱗右CD, DisUnit, true);
			this.X0Y0_尾16_尾CP = new ColorP(this.X0Y0_尾16_尾, this.尾16_尾CD, DisUnit, true);
			this.X0Y0_尾17_鱗CP = new ColorP(this.X0Y0_尾17_鱗, this.尾17_鱗CD, DisUnit, true);
			this.X0Y0_尾17_鱗左CP = new ColorP(this.X0Y0_尾17_鱗左, this.尾17_鱗左CD, DisUnit, true);
			this.X0Y0_尾17_鱗右CP = new ColorP(this.X0Y0_尾17_鱗右, this.尾17_鱗右CD, DisUnit, true);
			this.X0Y0_尾17_尾CP = new ColorP(this.X0Y0_尾17_尾, this.尾17_尾CD, DisUnit, true);
			this.X0Y0_尾18_鱗CP = new ColorP(this.X0Y0_尾18_鱗, this.尾18_鱗CD, DisUnit, true);
			this.X0Y0_尾18_鱗左CP = new ColorP(this.X0Y0_尾18_鱗左, this.尾18_鱗左CD, DisUnit, true);
			this.X0Y0_尾18_鱗右CP = new ColorP(this.X0Y0_尾18_鱗右, this.尾18_鱗右CD, DisUnit, true);
			this.X0Y0_尾18_尾CP = new ColorP(this.X0Y0_尾18_尾, this.尾18_尾CD, DisUnit, true);
			this.X0Y0_尾19_鱗CP = new ColorP(this.X0Y0_尾19_鱗, this.尾19_鱗CD, DisUnit, true);
			this.X0Y0_尾19_鱗左CP = new ColorP(this.X0Y0_尾19_鱗左, this.尾19_鱗左CD, DisUnit, true);
			this.X0Y0_尾19_鱗右CP = new ColorP(this.X0Y0_尾19_鱗右, this.尾19_鱗右CD, DisUnit, true);
			this.X0Y0_尾19_尾CP = new ColorP(this.X0Y0_尾19_尾, this.尾19_尾CD, DisUnit, true);
			this.X0Y0_尾20_鱗CP = new ColorP(this.X0Y0_尾20_鱗, this.尾20_鱗CD, DisUnit, true);
			this.X0Y0_尾20_鱗左CP = new ColorP(this.X0Y0_尾20_鱗左, this.尾20_鱗左CD, DisUnit, true);
			this.X0Y0_尾20_鱗右CP = new ColorP(this.X0Y0_尾20_鱗右, this.尾20_鱗右CD, DisUnit, true);
			this.X0Y0_尾20_尾CP = new ColorP(this.X0Y0_尾20_尾, this.尾20_尾CD, DisUnit, true);
			this.X0Y0_尾21_鱗CP = new ColorP(this.X0Y0_尾21_鱗, this.尾21_鱗CD, DisUnit, true);
			this.X0Y0_尾21_鱗左CP = new ColorP(this.X0Y0_尾21_鱗左, this.尾21_鱗左CD, DisUnit, true);
			this.X0Y0_尾21_鱗右CP = new ColorP(this.X0Y0_尾21_鱗右, this.尾21_鱗右CD, DisUnit, true);
			this.X0Y0_尾21_尾CP = new ColorP(this.X0Y0_尾21_尾, this.尾21_尾CD, DisUnit, true);
			this.X0Y0_尾22_鱗CP = new ColorP(this.X0Y0_尾22_鱗, this.尾22_鱗CD, DisUnit, true);
			this.X0Y0_尾22_鱗左CP = new ColorP(this.X0Y0_尾22_鱗左, this.尾22_鱗左CD, DisUnit, true);
			this.X0Y0_尾22_鱗右CP = new ColorP(this.X0Y0_尾22_鱗右, this.尾22_鱗右CD, DisUnit, true);
			this.X0Y0_尾22_尾CP = new ColorP(this.X0Y0_尾22_尾, this.尾22_尾CD, DisUnit, true);
			this.X0Y0_尾23_鱗CP = new ColorP(this.X0Y0_尾23_鱗, this.尾23_鱗CD, DisUnit, true);
			this.X0Y0_尾23_鱗左CP = new ColorP(this.X0Y0_尾23_鱗左, this.尾23_鱗左CD, DisUnit, true);
			this.X0Y0_尾23_鱗右CP = new ColorP(this.X0Y0_尾23_鱗右, this.尾23_鱗右CD, DisUnit, true);
			this.X0Y0_尾23_尾CP = new ColorP(this.X0Y0_尾23_尾, this.尾23_尾CD, DisUnit, true);
			this.X0Y0_尾24_鱗CP = new ColorP(this.X0Y0_尾24_鱗, this.尾24_鱗CD, DisUnit, true);
			this.X0Y0_尾24_鱗左CP = new ColorP(this.X0Y0_尾24_鱗左, this.尾24_鱗左CD, DisUnit, true);
			this.X0Y0_尾24_鱗右CP = new ColorP(this.X0Y0_尾24_鱗右, this.尾24_鱗右CD, DisUnit, true);
			this.X0Y0_尾24_尾CP = new ColorP(this.X0Y0_尾24_尾, this.尾24_尾CD, DisUnit, true);
			this.X0Y0_尾25_鱗CP = new ColorP(this.X0Y0_尾25_鱗, this.尾25_鱗CD, DisUnit, true);
			this.X0Y0_尾25_鱗左CP = new ColorP(this.X0Y0_尾25_鱗左, this.尾25_鱗左CD, DisUnit, true);
			this.X0Y0_尾25_鱗右CP = new ColorP(this.X0Y0_尾25_鱗右, this.尾25_鱗右CD, DisUnit, true);
			this.X0Y0_尾25_尾CP = new ColorP(this.X0Y0_尾25_尾, this.尾25_尾CD, DisUnit, true);
			this.X0Y0_尾26_鱗CP = new ColorP(this.X0Y0_尾26_鱗, this.尾26_鱗CD, DisUnit, true);
			this.X0Y0_尾26_鱗左CP = new ColorP(this.X0Y0_尾26_鱗左, this.尾26_鱗左CD, DisUnit, true);
			this.X0Y0_尾26_鱗右CP = new ColorP(this.X0Y0_尾26_鱗右, this.尾26_鱗右CD, DisUnit, true);
			this.X0Y0_尾26_尾CP = new ColorP(this.X0Y0_尾26_尾, this.尾26_尾CD, DisUnit, true);
			this.X0Y0_輪1_革CP = new ColorP(this.X0Y0_輪1_革, this.輪1_革CD, DisUnit, true);
			this.X0Y0_輪1_金具1CP = new ColorP(this.X0Y0_輪1_金具1, this.輪1_金具1CD, DisUnit, true);
			this.X0Y0_輪1_金具2CP = new ColorP(this.X0Y0_輪1_金具2, this.輪1_金具2CD, DisUnit, true);
			this.X0Y0_輪1_金具3CP = new ColorP(this.X0Y0_輪1_金具3, this.輪1_金具3CD, DisUnit, true);
			this.X0Y0_輪1_金具左CP = new ColorP(this.X0Y0_輪1_金具左, this.輪1_金具左CD, DisUnit, true);
			this.X0Y0_輪1_金具右CP = new ColorP(this.X0Y0_輪1_金具右, this.輪1_金具右CD, DisUnit, true);
			this.X0Y0_尾27_鱗CP = new ColorP(this.X0Y0_尾27_鱗, this.尾27_鱗CD, DisUnit, true);
			this.X0Y0_尾27_鱗左CP = new ColorP(this.X0Y0_尾27_鱗左, this.尾27_鱗左CD, DisUnit, true);
			this.X0Y0_尾27_鱗右CP = new ColorP(this.X0Y0_尾27_鱗右, this.尾27_鱗右CD, DisUnit, true);
			this.X0Y0_尾27_尾CP = new ColorP(this.X0Y0_尾27_尾, this.尾27_尾CD, DisUnit, true);
			this.X0Y0_尾28_鱗CP = new ColorP(this.X0Y0_尾28_鱗, this.尾28_鱗CD, DisUnit, true);
			this.X0Y0_尾28_鱗左CP = new ColorP(this.X0Y0_尾28_鱗左, this.尾28_鱗左CD, DisUnit, true);
			this.X0Y0_尾28_鱗右CP = new ColorP(this.X0Y0_尾28_鱗右, this.尾28_鱗右CD, DisUnit, true);
			this.X0Y0_尾28_尾CP = new ColorP(this.X0Y0_尾28_尾, this.尾28_尾CD, DisUnit, true);
			this.X0Y0_尾29_鱗CP = new ColorP(this.X0Y0_尾29_鱗, this.尾29_鱗CD, DisUnit, true);
			this.X0Y0_尾29_鱗左CP = new ColorP(this.X0Y0_尾29_鱗左, this.尾29_鱗左CD, DisUnit, true);
			this.X0Y0_尾29_鱗右CP = new ColorP(this.X0Y0_尾29_鱗右, this.尾29_鱗右CD, DisUnit, true);
			this.X0Y0_尾29_尾CP = new ColorP(this.X0Y0_尾29_尾, this.尾29_尾CD, DisUnit, true);
			this.X0Y0_尾30_鱗CP = new ColorP(this.X0Y0_尾30_鱗, this.尾30_鱗CD, DisUnit, true);
			this.X0Y0_尾30_鱗左CP = new ColorP(this.X0Y0_尾30_鱗左, this.尾30_鱗左CD, DisUnit, true);
			this.X0Y0_尾30_鱗右CP = new ColorP(this.X0Y0_尾30_鱗右, this.尾30_鱗右CD, DisUnit, true);
			this.X0Y0_尾30_尾CP = new ColorP(this.X0Y0_尾30_尾, this.尾30_尾CD, DisUnit, true);
			this.X0Y0_尾31_鱗CP = new ColorP(this.X0Y0_尾31_鱗, this.尾31_鱗CD, DisUnit, true);
			this.X0Y0_尾31_鱗左CP = new ColorP(this.X0Y0_尾31_鱗左, this.尾31_鱗左CD, DisUnit, true);
			this.X0Y0_尾31_鱗右CP = new ColorP(this.X0Y0_尾31_鱗右, this.尾31_鱗右CD, DisUnit, true);
			this.X0Y0_尾31_尾CP = new ColorP(this.X0Y0_尾31_尾, this.尾31_尾CD, DisUnit, true);
			this.X0Y0_尾32_鱗CP = new ColorP(this.X0Y0_尾32_鱗, this.尾32_鱗CD, DisUnit, true);
			this.X0Y0_尾32_鱗左CP = new ColorP(this.X0Y0_尾32_鱗左, this.尾32_鱗左CD, DisUnit, true);
			this.X0Y0_尾32_鱗右CP = new ColorP(this.X0Y0_尾32_鱗右, this.尾32_鱗右CD, DisUnit, true);
			this.X0Y0_尾32_尾CP = new ColorP(this.X0Y0_尾32_尾, this.尾32_尾CD, DisUnit, true);
			this.X0Y0_尾33_鱗CP = new ColorP(this.X0Y0_尾33_鱗, this.尾33_鱗CD, DisUnit, true);
			this.X0Y0_尾33_鱗左CP = new ColorP(this.X0Y0_尾33_鱗左, this.尾33_鱗左CD, DisUnit, true);
			this.X0Y0_尾33_鱗右CP = new ColorP(this.X0Y0_尾33_鱗右, this.尾33_鱗右CD, DisUnit, true);
			this.X0Y0_尾33_尾CP = new ColorP(this.X0Y0_尾33_尾, this.尾33_尾CD, DisUnit, true);
			this.X0Y0_尾34_鱗CP = new ColorP(this.X0Y0_尾34_鱗, this.尾34_鱗CD, DisUnit, true);
			this.X0Y0_尾34_鱗左CP = new ColorP(this.X0Y0_尾34_鱗左, this.尾34_鱗左CD, DisUnit, true);
			this.X0Y0_尾34_鱗右CP = new ColorP(this.X0Y0_尾34_鱗右, this.尾34_鱗右CD, DisUnit, true);
			this.X0Y0_尾34_尾CP = new ColorP(this.X0Y0_尾34_尾, this.尾34_尾CD, DisUnit, true);
			this.X0Y0_尾35_鱗CP = new ColorP(this.X0Y0_尾35_鱗, this.尾35_鱗CD, DisUnit, true);
			this.X0Y0_尾35_鱗左CP = new ColorP(this.X0Y0_尾35_鱗左, this.尾35_鱗左CD, DisUnit, true);
			this.X0Y0_尾35_鱗右CP = new ColorP(this.X0Y0_尾35_鱗右, this.尾35_鱗右CD, DisUnit, true);
			this.X0Y0_尾35_尾CP = new ColorP(this.X0Y0_尾35_尾, this.尾35_尾CD, DisUnit, true);
			this.X0Y0_尾36_鱗CP = new ColorP(this.X0Y0_尾36_鱗, this.尾36_鱗CD, DisUnit, true);
			this.X0Y0_尾36_鱗左CP = new ColorP(this.X0Y0_尾36_鱗左, this.尾36_鱗左CD, DisUnit, true);
			this.X0Y0_尾36_鱗右CP = new ColorP(this.X0Y0_尾36_鱗右, this.尾36_鱗右CD, DisUnit, true);
			this.X0Y0_尾36_尾CP = new ColorP(this.X0Y0_尾36_尾, this.尾36_尾CD, DisUnit, true);
			this.X0Y0_尾37_鱗CP = new ColorP(this.X0Y0_尾37_鱗, this.尾37_鱗CD, DisUnit, true);
			this.X0Y0_尾37_鱗左CP = new ColorP(this.X0Y0_尾37_鱗左, this.尾37_鱗左CD, DisUnit, true);
			this.X0Y0_尾37_鱗右CP = new ColorP(this.X0Y0_尾37_鱗右, this.尾37_鱗右CD, DisUnit, true);
			this.X0Y0_尾37_尾CP = new ColorP(this.X0Y0_尾37_尾, this.尾37_尾CD, DisUnit, true);
			this.X0Y0_尾38_鱗CP = new ColorP(this.X0Y0_尾38_鱗, this.尾38_鱗CD, DisUnit, true);
			this.X0Y0_尾38_鱗左CP = new ColorP(this.X0Y0_尾38_鱗左, this.尾38_鱗左CD, DisUnit, true);
			this.X0Y0_尾38_鱗右CP = new ColorP(this.X0Y0_尾38_鱗右, this.尾38_鱗右CD, DisUnit, true);
			this.X0Y0_尾38_尾CP = new ColorP(this.X0Y0_尾38_尾, this.尾38_尾CD, DisUnit, true);
			this.X0Y0_尾39_鱗CP = new ColorP(this.X0Y0_尾39_鱗, this.尾39_鱗CD, DisUnit, true);
			this.X0Y0_尾39_鱗左CP = new ColorP(this.X0Y0_尾39_鱗左, this.尾39_鱗左CD, DisUnit, true);
			this.X0Y0_尾39_鱗右CP = new ColorP(this.X0Y0_尾39_鱗右, this.尾39_鱗右CD, DisUnit, true);
			this.X0Y0_尾39_尾CP = new ColorP(this.X0Y0_尾39_尾, this.尾39_尾CD, DisUnit, true);
			this.X0Y0_尾40_鱗CP = new ColorP(this.X0Y0_尾40_鱗, this.尾40_鱗CD, DisUnit, true);
			this.X0Y0_尾40_鱗左CP = new ColorP(this.X0Y0_尾40_鱗左, this.尾40_鱗左CD, DisUnit, true);
			this.X0Y0_尾40_鱗右CP = new ColorP(this.X0Y0_尾40_鱗右, this.尾40_鱗右CD, DisUnit, true);
			this.X0Y0_尾40_尾CP = new ColorP(this.X0Y0_尾40_尾, this.尾40_尾CD, DisUnit, true);
			this.X0Y0_尾41_鱗CP = new ColorP(this.X0Y0_尾41_鱗, this.尾41_鱗CD, DisUnit, true);
			this.X0Y0_尾41_鱗左CP = new ColorP(this.X0Y0_尾41_鱗左, this.尾41_鱗左CD, DisUnit, true);
			this.X0Y0_尾41_鱗右CP = new ColorP(this.X0Y0_尾41_鱗右, this.尾41_鱗右CD, DisUnit, true);
			this.X0Y0_尾41_尾CP = new ColorP(this.X0Y0_尾41_尾, this.尾41_尾CD, DisUnit, true);
			this.X0Y0_尾42_鱗CP = new ColorP(this.X0Y0_尾42_鱗, this.尾42_鱗CD, DisUnit, true);
			this.X0Y0_尾42_鱗左CP = new ColorP(this.X0Y0_尾42_鱗左, this.尾42_鱗左CD, DisUnit, true);
			this.X0Y0_尾42_鱗右CP = new ColorP(this.X0Y0_尾42_鱗右, this.尾42_鱗右CD, DisUnit, true);
			this.X0Y0_尾42_尾CP = new ColorP(this.X0Y0_尾42_尾, this.尾42_尾CD, DisUnit, true);
			this.X0Y0_尾43_鱗CP = new ColorP(this.X0Y0_尾43_鱗, this.尾43_鱗CD, DisUnit, true);
			this.X0Y0_尾43_鱗左CP = new ColorP(this.X0Y0_尾43_鱗左, this.尾43_鱗左CD, DisUnit, true);
			this.X0Y0_尾43_鱗右CP = new ColorP(this.X0Y0_尾43_鱗右, this.尾43_鱗右CD, DisUnit, true);
			this.X0Y0_尾43_尾CP = new ColorP(this.X0Y0_尾43_尾, this.尾43_尾CD, DisUnit, true);
			this.X0Y0_尾44_鱗CP = new ColorP(this.X0Y0_尾44_鱗, this.尾44_鱗CD, DisUnit, true);
			this.X0Y0_尾44_鱗左CP = new ColorP(this.X0Y0_尾44_鱗左, this.尾44_鱗左CD, DisUnit, true);
			this.X0Y0_尾44_鱗右CP = new ColorP(this.X0Y0_尾44_鱗右, this.尾44_鱗右CD, DisUnit, true);
			this.X0Y0_尾44_尾CP = new ColorP(this.X0Y0_尾44_尾, this.尾44_尾CD, DisUnit, true);
			this.X0Y0_頭_上顎_顎基CP = new ColorP(this.X0Y0_頭_上顎_顎基, this.頭_上顎_顎基CD, DisUnit, true);
			this.X0Y0_頭_上顎_鱗4CP = new ColorP(this.X0Y0_頭_上顎_鱗4, this.頭_上顎_鱗4CD, DisUnit, true);
			this.X0Y0_頭_上顎_鱗左1CP = new ColorP(this.X0Y0_頭_上顎_鱗左1, this.頭_上顎_鱗左1CD, DisUnit, true);
			this.X0Y0_頭_上顎_鱗右1CP = new ColorP(this.X0Y0_頭_上顎_鱗右1, this.頭_上顎_鱗右1CD, DisUnit, true);
			this.X0Y0_頭_上顎_鱗左2CP = new ColorP(this.X0Y0_頭_上顎_鱗左2, this.頭_上顎_鱗左2CD, DisUnit, true);
			this.X0Y0_頭_上顎_鱗右2CP = new ColorP(this.X0Y0_頭_上顎_鱗右2, this.頭_上顎_鱗右2CD, DisUnit, true);
			this.X0Y0_頭_上顎_鱗左3CP = new ColorP(this.X0Y0_頭_上顎_鱗左3, this.頭_上顎_鱗左3CD, DisUnit, true);
			this.X0Y0_頭_上顎_鱗右3CP = new ColorP(this.X0Y0_頭_上顎_鱗右3, this.頭_上顎_鱗右3CD, DisUnit, true);
			this.X0Y0_頭_上顎_鱗左4CP = new ColorP(this.X0Y0_頭_上顎_鱗左4, this.頭_上顎_鱗左4CD, DisUnit, true);
			this.X0Y0_頭_上顎_鱗右4CP = new ColorP(this.X0Y0_頭_上顎_鱗右4, this.頭_上顎_鱗右4CD, DisUnit, true);
			this.X0Y0_頭_上顎_鱗左5CP = new ColorP(this.X0Y0_頭_上顎_鱗左5, this.頭_上顎_鱗左5CD, DisUnit, true);
			this.X0Y0_頭_上顎_鱗右5CP = new ColorP(this.X0Y0_頭_上顎_鱗右5, this.頭_上顎_鱗右5CD, DisUnit, true);
			this.X0Y0_頭_上顎_鱗左8CP = new ColorP(this.X0Y0_頭_上顎_鱗左8, this.頭_上顎_鱗左8CD, DisUnit, true);
			this.X0Y0_頭_上顎_鱗右8CP = new ColorP(this.X0Y0_頭_上顎_鱗右8, this.頭_上顎_鱗右8CD, DisUnit, true);
			this.X0Y0_頭_上顎_鱗左9CP = new ColorP(this.X0Y0_頭_上顎_鱗左9, this.頭_上顎_鱗左9CD, DisUnit, true);
			this.X0Y0_頭_上顎_鱗右9CP = new ColorP(this.X0Y0_頭_上顎_鱗右9, this.頭_上顎_鱗右9CD, DisUnit, true);
			this.X0Y0_頭_上顎_鱗左10CP = new ColorP(this.X0Y0_頭_上顎_鱗左10, this.頭_上顎_鱗左10CD, DisUnit, true);
			this.X0Y0_頭_上顎_鱗右10CP = new ColorP(this.X0Y0_頭_上顎_鱗右10, this.頭_上顎_鱗右10CD, DisUnit, true);
			this.X0Y0_頭_上顎_鱗左11CP = new ColorP(this.X0Y0_頭_上顎_鱗左11, this.頭_上顎_鱗左11CD, DisUnit, true);
			this.X0Y0_頭_上顎_鱗右11CP = new ColorP(this.X0Y0_頭_上顎_鱗右11, this.頭_上顎_鱗右11CD, DisUnit, true);
			this.X0Y0_頭_下顎_顎基CP = new ColorP(this.X0Y0_頭_下顎_顎基, this.頭_下顎_顎基CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗1CP = new ColorP(this.X0Y0_頭_下顎_鱗1, this.頭_下顎_鱗1CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗2CP = new ColorP(this.X0Y0_頭_下顎_鱗2, this.頭_下顎_鱗2CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗3CP = new ColorP(this.X0Y0_頭_下顎_鱗3, this.頭_下顎_鱗3CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗4CP = new ColorP(this.X0Y0_頭_下顎_鱗4, this.頭_下顎_鱗4CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗左1CP = new ColorP(this.X0Y0_頭_下顎_鱗左1, this.頭_下顎_鱗左1CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗右1CP = new ColorP(this.X0Y0_頭_下顎_鱗右1, this.頭_下顎_鱗右1CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗左2CP = new ColorP(this.X0Y0_頭_下顎_鱗左2, this.頭_下顎_鱗左2CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗右2CP = new ColorP(this.X0Y0_頭_下顎_鱗右2, this.頭_下顎_鱗右2CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗左3CP = new ColorP(this.X0Y0_頭_下顎_鱗左3, this.頭_下顎_鱗左3CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗右3CP = new ColorP(this.X0Y0_頭_下顎_鱗右3, this.頭_下顎_鱗右3CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗左4CP = new ColorP(this.X0Y0_頭_下顎_鱗左4, this.頭_下顎_鱗左4CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗右4CP = new ColorP(this.X0Y0_頭_下顎_鱗右4, this.頭_下顎_鱗右4CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗左5CP = new ColorP(this.X0Y0_頭_下顎_鱗左5, this.頭_下顎_鱗左5CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗右5CP = new ColorP(this.X0Y0_頭_下顎_鱗右5, this.頭_下顎_鱗右5CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗左6CP = new ColorP(this.X0Y0_頭_下顎_鱗左6, this.頭_下顎_鱗左6CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗右6CP = new ColorP(this.X0Y0_頭_下顎_鱗右6, this.頭_下顎_鱗右6CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗左7CP = new ColorP(this.X0Y0_頭_下顎_鱗左7, this.頭_下顎_鱗左7CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗右7CP = new ColorP(this.X0Y0_頭_下顎_鱗右7, this.頭_下顎_鱗右7CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗左8CP = new ColorP(this.X0Y0_頭_下顎_鱗左8, this.頭_下顎_鱗左8CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗右8CP = new ColorP(this.X0Y0_頭_下顎_鱗右8, this.頭_下顎_鱗右8CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗左9CP = new ColorP(this.X0Y0_頭_下顎_鱗左9, this.頭_下顎_鱗左9CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗右9CP = new ColorP(this.X0Y0_頭_下顎_鱗右9, this.頭_下顎_鱗右9CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗左10CP = new ColorP(this.X0Y0_頭_下顎_鱗左10, this.頭_下顎_鱗左10CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗右10CP = new ColorP(this.X0Y0_頭_下顎_鱗右10, this.頭_下顎_鱗右10CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗左11CP = new ColorP(this.X0Y0_頭_下顎_鱗左11, this.頭_下顎_鱗左11CD, DisUnit, true);
			this.X0Y0_頭_下顎_鱗右11CP = new ColorP(this.X0Y0_頭_下顎_鱗右11, this.頭_下顎_鱗右11CD, DisUnit, true);
			this.X0Y0_輪2_革CP = new ColorP(this.X0Y0_輪2_革, this.輪2_革CD, DisUnit, true);
			this.X0Y0_輪2_金具1CP = new ColorP(this.X0Y0_輪2_金具1, this.輪2_金具1CD, DisUnit, true);
			this.X0Y0_輪2_金具2CP = new ColorP(this.X0Y0_輪2_金具2, this.輪2_金具2CD, DisUnit, true);
			this.X0Y0_輪2_金具3CP = new ColorP(this.X0Y0_輪2_金具3, this.輪2_金具3CD, DisUnit, true);
			this.X0Y0_輪2_金具左CP = new ColorP(this.X0Y0_輪2_金具左, this.輪2_金具左CD, DisUnit, true);
			this.X0Y0_輪2_金具右CP = new ColorP(this.X0Y0_輪2_金具右, this.輪2_金具右CD, DisUnit, true);
			this.濃度 = e.濃度;
			this.鎖1 = new 拘束鎖(DisUnit, this.右, 配色指定, 体配色, this.Xasix);
			this.鎖2 = new 拘束鎖(DisUnit, !this.右, 配色指定, 体配色, this.Xasix);
			this.鎖3 = new 拘束鎖(DisUnit, this.右, 配色指定, 体配色, this.Xasix);
			this.鎖4 = new 拘束鎖(DisUnit, !this.右, 配色指定, 体配色, this.Xasix);
			this.鎖1.接続(this.鎖1_接続点);
			this.鎖2.接続(this.鎖2_接続点);
			this.鎖3.接続(this.鎖3_接続点);
			this.鎖4.接続(this.鎖4_接続点);
			int num = this.右 ? -10 : 10;
			this.鎖1.角度B -= (double)num;
			this.鎖2.角度B += (double)num;
			this.鎖3.角度B -= (double)num;
			this.鎖4.角度B += (double)num;
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
				this.輪1表示 = this.拘束_;
				this.輪2表示 = this.拘束_;
			}
		}

		public bool 尾1_根_表示
		{
			get
			{
				return this.X0Y0_尾1_根.Dra;
			}
			set
			{
				this.X0Y0_尾1_根.Dra = value;
				this.X0Y0_尾1_根.Hit = value;
			}
		}

		public bool 尾1_鱗_表示
		{
			get
			{
				return this.X0Y0_尾1_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾1_鱗.Dra = value;
				this.X0Y0_尾1_鱗.Hit = value;
			}
		}

		public bool 尾1_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾1_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾1_鱗左.Dra = value;
				this.X0Y0_尾1_鱗左.Hit = value;
			}
		}

		public bool 尾1_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾1_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾1_鱗右.Dra = value;
				this.X0Y0_尾1_鱗右.Hit = value;
			}
		}

		public bool 尾1_尾_表示
		{
			get
			{
				return this.X0Y0_尾1_尾.Dra;
			}
			set
			{
				this.X0Y0_尾1_尾.Dra = value;
				this.X0Y0_尾1_尾.Hit = value;
			}
		}

		public bool 尾2_鱗_表示
		{
			get
			{
				return this.X0Y0_尾2_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾2_鱗.Dra = value;
				this.X0Y0_尾2_鱗.Hit = value;
			}
		}

		public bool 尾2_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾2_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾2_鱗左.Dra = value;
				this.X0Y0_尾2_鱗左.Hit = value;
			}
		}

		public bool 尾2_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾2_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾2_鱗右.Dra = value;
				this.X0Y0_尾2_鱗右.Hit = value;
			}
		}

		public bool 尾2_尾_表示
		{
			get
			{
				return this.X0Y0_尾2_尾.Dra;
			}
			set
			{
				this.X0Y0_尾2_尾.Dra = value;
				this.X0Y0_尾2_尾.Hit = value;
			}
		}

		public bool 尾3_鱗_表示
		{
			get
			{
				return this.X0Y0_尾3_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾3_鱗.Dra = value;
				this.X0Y0_尾3_鱗.Hit = value;
			}
		}

		public bool 尾3_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾3_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾3_鱗左.Dra = value;
				this.X0Y0_尾3_鱗左.Hit = value;
			}
		}

		public bool 尾3_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾3_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾3_鱗右.Dra = value;
				this.X0Y0_尾3_鱗右.Hit = value;
			}
		}

		public bool 尾3_尾_表示
		{
			get
			{
				return this.X0Y0_尾3_尾.Dra;
			}
			set
			{
				this.X0Y0_尾3_尾.Dra = value;
				this.X0Y0_尾3_尾.Hit = value;
			}
		}

		public bool 尾4_鱗_表示
		{
			get
			{
				return this.X0Y0_尾4_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾4_鱗.Dra = value;
				this.X0Y0_尾4_鱗.Hit = value;
			}
		}

		public bool 尾4_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾4_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾4_鱗左.Dra = value;
				this.X0Y0_尾4_鱗左.Hit = value;
			}
		}

		public bool 尾4_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾4_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾4_鱗右.Dra = value;
				this.X0Y0_尾4_鱗右.Hit = value;
			}
		}

		public bool 尾4_尾_表示
		{
			get
			{
				return this.X0Y0_尾4_尾.Dra;
			}
			set
			{
				this.X0Y0_尾4_尾.Dra = value;
				this.X0Y0_尾4_尾.Hit = value;
			}
		}

		public bool 尾5_鱗_表示
		{
			get
			{
				return this.X0Y0_尾5_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾5_鱗.Dra = value;
				this.X0Y0_尾5_鱗.Hit = value;
			}
		}

		public bool 尾5_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾5_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾5_鱗左.Dra = value;
				this.X0Y0_尾5_鱗左.Hit = value;
			}
		}

		public bool 尾5_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾5_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾5_鱗右.Dra = value;
				this.X0Y0_尾5_鱗右.Hit = value;
			}
		}

		public bool 尾5_尾_表示
		{
			get
			{
				return this.X0Y0_尾5_尾.Dra;
			}
			set
			{
				this.X0Y0_尾5_尾.Dra = value;
				this.X0Y0_尾5_尾.Hit = value;
			}
		}

		public bool 尾6_鱗_表示
		{
			get
			{
				return this.X0Y0_尾6_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾6_鱗.Dra = value;
				this.X0Y0_尾6_鱗.Hit = value;
			}
		}

		public bool 尾6_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾6_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾6_鱗左.Dra = value;
				this.X0Y0_尾6_鱗左.Hit = value;
			}
		}

		public bool 尾6_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾6_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾6_鱗右.Dra = value;
				this.X0Y0_尾6_鱗右.Hit = value;
			}
		}

		public bool 尾6_尾_表示
		{
			get
			{
				return this.X0Y0_尾6_尾.Dra;
			}
			set
			{
				this.X0Y0_尾6_尾.Dra = value;
				this.X0Y0_尾6_尾.Hit = value;
			}
		}

		public bool 尾7_鱗_表示
		{
			get
			{
				return this.X0Y0_尾7_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾7_鱗.Dra = value;
				this.X0Y0_尾7_鱗.Hit = value;
			}
		}

		public bool 尾7_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾7_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾7_鱗左.Dra = value;
				this.X0Y0_尾7_鱗左.Hit = value;
			}
		}

		public bool 尾7_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾7_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾7_鱗右.Dra = value;
				this.X0Y0_尾7_鱗右.Hit = value;
			}
		}

		public bool 尾7_尾_表示
		{
			get
			{
				return this.X0Y0_尾7_尾.Dra;
			}
			set
			{
				this.X0Y0_尾7_尾.Dra = value;
				this.X0Y0_尾7_尾.Hit = value;
			}
		}

		public bool 尾8_鱗_表示
		{
			get
			{
				return this.X0Y0_尾8_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾8_鱗.Dra = value;
				this.X0Y0_尾8_鱗.Hit = value;
			}
		}

		public bool 尾8_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾8_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾8_鱗左.Dra = value;
				this.X0Y0_尾8_鱗左.Hit = value;
			}
		}

		public bool 尾8_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾8_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾8_鱗右.Dra = value;
				this.X0Y0_尾8_鱗右.Hit = value;
			}
		}

		public bool 尾8_尾_表示
		{
			get
			{
				return this.X0Y0_尾8_尾.Dra;
			}
			set
			{
				this.X0Y0_尾8_尾.Dra = value;
				this.X0Y0_尾8_尾.Hit = value;
			}
		}

		public bool 尾9_鱗_表示
		{
			get
			{
				return this.X0Y0_尾9_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾9_鱗.Dra = value;
				this.X0Y0_尾9_鱗.Hit = value;
			}
		}

		public bool 尾9_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾9_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾9_鱗左.Dra = value;
				this.X0Y0_尾9_鱗左.Hit = value;
			}
		}

		public bool 尾9_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾9_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾9_鱗右.Dra = value;
				this.X0Y0_尾9_鱗右.Hit = value;
			}
		}

		public bool 尾9_尾_表示
		{
			get
			{
				return this.X0Y0_尾9_尾.Dra;
			}
			set
			{
				this.X0Y0_尾9_尾.Dra = value;
				this.X0Y0_尾9_尾.Hit = value;
			}
		}

		public bool 尾10_鱗_表示
		{
			get
			{
				return this.X0Y0_尾10_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾10_鱗.Dra = value;
				this.X0Y0_尾10_鱗.Hit = value;
			}
		}

		public bool 尾10_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾10_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾10_鱗左.Dra = value;
				this.X0Y0_尾10_鱗左.Hit = value;
			}
		}

		public bool 尾10_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾10_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾10_鱗右.Dra = value;
				this.X0Y0_尾10_鱗右.Hit = value;
			}
		}

		public bool 尾10_尾_表示
		{
			get
			{
				return this.X0Y0_尾10_尾.Dra;
			}
			set
			{
				this.X0Y0_尾10_尾.Dra = value;
				this.X0Y0_尾10_尾.Hit = value;
			}
		}

		public bool 尾11_鱗_表示
		{
			get
			{
				return this.X0Y0_尾11_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾11_鱗.Dra = value;
				this.X0Y0_尾11_鱗.Hit = value;
			}
		}

		public bool 尾11_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾11_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾11_鱗左.Dra = value;
				this.X0Y0_尾11_鱗左.Hit = value;
			}
		}

		public bool 尾11_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾11_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾11_鱗右.Dra = value;
				this.X0Y0_尾11_鱗右.Hit = value;
			}
		}

		public bool 尾11_尾_表示
		{
			get
			{
				return this.X0Y0_尾11_尾.Dra;
			}
			set
			{
				this.X0Y0_尾11_尾.Dra = value;
				this.X0Y0_尾11_尾.Hit = value;
			}
		}

		public bool 尾12_鱗_表示
		{
			get
			{
				return this.X0Y0_尾12_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾12_鱗.Dra = value;
				this.X0Y0_尾12_鱗.Hit = value;
			}
		}

		public bool 尾12_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾12_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾12_鱗左.Dra = value;
				this.X0Y0_尾12_鱗左.Hit = value;
			}
		}

		public bool 尾12_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾12_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾12_鱗右.Dra = value;
				this.X0Y0_尾12_鱗右.Hit = value;
			}
		}

		public bool 尾12_尾_表示
		{
			get
			{
				return this.X0Y0_尾12_尾.Dra;
			}
			set
			{
				this.X0Y0_尾12_尾.Dra = value;
				this.X0Y0_尾12_尾.Hit = value;
			}
		}

		public bool 尾13_鱗_表示
		{
			get
			{
				return this.X0Y0_尾13_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾13_鱗.Dra = value;
				this.X0Y0_尾13_鱗.Hit = value;
			}
		}

		public bool 尾13_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾13_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾13_鱗左.Dra = value;
				this.X0Y0_尾13_鱗左.Hit = value;
			}
		}

		public bool 尾13_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾13_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾13_鱗右.Dra = value;
				this.X0Y0_尾13_鱗右.Hit = value;
			}
		}

		public bool 尾13_尾_表示
		{
			get
			{
				return this.X0Y0_尾13_尾.Dra;
			}
			set
			{
				this.X0Y0_尾13_尾.Dra = value;
				this.X0Y0_尾13_尾.Hit = value;
			}
		}

		public bool 尾14_鱗_表示
		{
			get
			{
				return this.X0Y0_尾14_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾14_鱗.Dra = value;
				this.X0Y0_尾14_鱗.Hit = value;
			}
		}

		public bool 尾14_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾14_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾14_鱗左.Dra = value;
				this.X0Y0_尾14_鱗左.Hit = value;
			}
		}

		public bool 尾14_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾14_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾14_鱗右.Dra = value;
				this.X0Y0_尾14_鱗右.Hit = value;
			}
		}

		public bool 尾14_尾_表示
		{
			get
			{
				return this.X0Y0_尾14_尾.Dra;
			}
			set
			{
				this.X0Y0_尾14_尾.Dra = value;
				this.X0Y0_尾14_尾.Hit = value;
			}
		}

		public bool 尾15_鱗_表示
		{
			get
			{
				return this.X0Y0_尾15_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾15_鱗.Dra = value;
				this.X0Y0_尾15_鱗.Hit = value;
			}
		}

		public bool 尾15_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾15_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾15_鱗左.Dra = value;
				this.X0Y0_尾15_鱗左.Hit = value;
			}
		}

		public bool 尾15_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾15_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾15_鱗右.Dra = value;
				this.X0Y0_尾15_鱗右.Hit = value;
			}
		}

		public bool 尾15_尾_表示
		{
			get
			{
				return this.X0Y0_尾15_尾.Dra;
			}
			set
			{
				this.X0Y0_尾15_尾.Dra = value;
				this.X0Y0_尾15_尾.Hit = value;
			}
		}

		public bool 尾16_鱗_表示
		{
			get
			{
				return this.X0Y0_尾16_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾16_鱗.Dra = value;
				this.X0Y0_尾16_鱗.Hit = value;
			}
		}

		public bool 尾16_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾16_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾16_鱗左.Dra = value;
				this.X0Y0_尾16_鱗左.Hit = value;
			}
		}

		public bool 尾16_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾16_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾16_鱗右.Dra = value;
				this.X0Y0_尾16_鱗右.Hit = value;
			}
		}

		public bool 尾16_尾_表示
		{
			get
			{
				return this.X0Y0_尾16_尾.Dra;
			}
			set
			{
				this.X0Y0_尾16_尾.Dra = value;
				this.X0Y0_尾16_尾.Hit = value;
			}
		}

		public bool 尾17_鱗_表示
		{
			get
			{
				return this.X0Y0_尾17_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾17_鱗.Dra = value;
				this.X0Y0_尾17_鱗.Hit = value;
			}
		}

		public bool 尾17_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾17_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾17_鱗左.Dra = value;
				this.X0Y0_尾17_鱗左.Hit = value;
			}
		}

		public bool 尾17_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾17_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾17_鱗右.Dra = value;
				this.X0Y0_尾17_鱗右.Hit = value;
			}
		}

		public bool 尾17_尾_表示
		{
			get
			{
				return this.X0Y0_尾17_尾.Dra;
			}
			set
			{
				this.X0Y0_尾17_尾.Dra = value;
				this.X0Y0_尾17_尾.Hit = value;
			}
		}

		public bool 尾18_鱗_表示
		{
			get
			{
				return this.X0Y0_尾18_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾18_鱗.Dra = value;
				this.X0Y0_尾18_鱗.Hit = value;
			}
		}

		public bool 尾18_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾18_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾18_鱗左.Dra = value;
				this.X0Y0_尾18_鱗左.Hit = value;
			}
		}

		public bool 尾18_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾18_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾18_鱗右.Dra = value;
				this.X0Y0_尾18_鱗右.Hit = value;
			}
		}

		public bool 尾18_尾_表示
		{
			get
			{
				return this.X0Y0_尾18_尾.Dra;
			}
			set
			{
				this.X0Y0_尾18_尾.Dra = value;
				this.X0Y0_尾18_尾.Hit = value;
			}
		}

		public bool 尾19_鱗_表示
		{
			get
			{
				return this.X0Y0_尾19_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾19_鱗.Dra = value;
				this.X0Y0_尾19_鱗.Hit = value;
			}
		}

		public bool 尾19_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾19_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾19_鱗左.Dra = value;
				this.X0Y0_尾19_鱗左.Hit = value;
			}
		}

		public bool 尾19_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾19_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾19_鱗右.Dra = value;
				this.X0Y0_尾19_鱗右.Hit = value;
			}
		}

		public bool 尾19_尾_表示
		{
			get
			{
				return this.X0Y0_尾19_尾.Dra;
			}
			set
			{
				this.X0Y0_尾19_尾.Dra = value;
				this.X0Y0_尾19_尾.Hit = value;
			}
		}

		public bool 尾20_鱗_表示
		{
			get
			{
				return this.X0Y0_尾20_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾20_鱗.Dra = value;
				this.X0Y0_尾20_鱗.Hit = value;
			}
		}

		public bool 尾20_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾20_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾20_鱗左.Dra = value;
				this.X0Y0_尾20_鱗左.Hit = value;
			}
		}

		public bool 尾20_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾20_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾20_鱗右.Dra = value;
				this.X0Y0_尾20_鱗右.Hit = value;
			}
		}

		public bool 尾20_尾_表示
		{
			get
			{
				return this.X0Y0_尾20_尾.Dra;
			}
			set
			{
				this.X0Y0_尾20_尾.Dra = value;
				this.X0Y0_尾20_尾.Hit = value;
			}
		}

		public bool 尾21_鱗_表示
		{
			get
			{
				return this.X0Y0_尾21_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾21_鱗.Dra = value;
				this.X0Y0_尾21_鱗.Hit = value;
			}
		}

		public bool 尾21_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾21_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾21_鱗左.Dra = value;
				this.X0Y0_尾21_鱗左.Hit = value;
			}
		}

		public bool 尾21_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾21_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾21_鱗右.Dra = value;
				this.X0Y0_尾21_鱗右.Hit = value;
			}
		}

		public bool 尾21_尾_表示
		{
			get
			{
				return this.X0Y0_尾21_尾.Dra;
			}
			set
			{
				this.X0Y0_尾21_尾.Dra = value;
				this.X0Y0_尾21_尾.Hit = value;
			}
		}

		public bool 尾22_鱗_表示
		{
			get
			{
				return this.X0Y0_尾22_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾22_鱗.Dra = value;
				this.X0Y0_尾22_鱗.Hit = value;
			}
		}

		public bool 尾22_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾22_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾22_鱗左.Dra = value;
				this.X0Y0_尾22_鱗左.Hit = value;
			}
		}

		public bool 尾22_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾22_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾22_鱗右.Dra = value;
				this.X0Y0_尾22_鱗右.Hit = value;
			}
		}

		public bool 尾22_尾_表示
		{
			get
			{
				return this.X0Y0_尾22_尾.Dra;
			}
			set
			{
				this.X0Y0_尾22_尾.Dra = value;
				this.X0Y0_尾22_尾.Hit = value;
			}
		}

		public bool 尾23_鱗_表示
		{
			get
			{
				return this.X0Y0_尾23_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾23_鱗.Dra = value;
				this.X0Y0_尾23_鱗.Hit = value;
			}
		}

		public bool 尾23_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾23_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾23_鱗左.Dra = value;
				this.X0Y0_尾23_鱗左.Hit = value;
			}
		}

		public bool 尾23_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾23_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾23_鱗右.Dra = value;
				this.X0Y0_尾23_鱗右.Hit = value;
			}
		}

		public bool 尾23_尾_表示
		{
			get
			{
				return this.X0Y0_尾23_尾.Dra;
			}
			set
			{
				this.X0Y0_尾23_尾.Dra = value;
				this.X0Y0_尾23_尾.Hit = value;
			}
		}

		public bool 尾24_鱗_表示
		{
			get
			{
				return this.X0Y0_尾24_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾24_鱗.Dra = value;
				this.X0Y0_尾24_鱗.Hit = value;
			}
		}

		public bool 尾24_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾24_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾24_鱗左.Dra = value;
				this.X0Y0_尾24_鱗左.Hit = value;
			}
		}

		public bool 尾24_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾24_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾24_鱗右.Dra = value;
				this.X0Y0_尾24_鱗右.Hit = value;
			}
		}

		public bool 尾24_尾_表示
		{
			get
			{
				return this.X0Y0_尾24_尾.Dra;
			}
			set
			{
				this.X0Y0_尾24_尾.Dra = value;
				this.X0Y0_尾24_尾.Hit = value;
			}
		}

		public bool 尾25_鱗_表示
		{
			get
			{
				return this.X0Y0_尾25_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾25_鱗.Dra = value;
				this.X0Y0_尾25_鱗.Hit = value;
			}
		}

		public bool 尾25_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾25_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾25_鱗左.Dra = value;
				this.X0Y0_尾25_鱗左.Hit = value;
			}
		}

		public bool 尾25_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾25_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾25_鱗右.Dra = value;
				this.X0Y0_尾25_鱗右.Hit = value;
			}
		}

		public bool 尾25_尾_表示
		{
			get
			{
				return this.X0Y0_尾25_尾.Dra;
			}
			set
			{
				this.X0Y0_尾25_尾.Dra = value;
				this.X0Y0_尾25_尾.Hit = value;
			}
		}

		public bool 尾26_鱗_表示
		{
			get
			{
				return this.X0Y0_尾26_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾26_鱗.Dra = value;
				this.X0Y0_尾26_鱗.Hit = value;
			}
		}

		public bool 尾26_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾26_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾26_鱗左.Dra = value;
				this.X0Y0_尾26_鱗左.Hit = value;
			}
		}

		public bool 尾26_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾26_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾26_鱗右.Dra = value;
				this.X0Y0_尾26_鱗右.Hit = value;
			}
		}

		public bool 尾26_尾_表示
		{
			get
			{
				return this.X0Y0_尾26_尾.Dra;
			}
			set
			{
				this.X0Y0_尾26_尾.Dra = value;
				this.X0Y0_尾26_尾.Hit = value;
			}
		}

		public bool 輪1_革_表示
		{
			get
			{
				return this.X0Y0_輪1_革.Dra;
			}
			set
			{
				this.X0Y0_輪1_革.Dra = value;
				this.X0Y0_輪1_革.Hit = value;
			}
		}

		public bool 輪1_金具1_表示
		{
			get
			{
				return this.X0Y0_輪1_金具1.Dra;
			}
			set
			{
				this.X0Y0_輪1_金具1.Dra = value;
				this.X0Y0_輪1_金具1.Hit = value;
			}
		}

		public bool 輪1_金具2_表示
		{
			get
			{
				return this.X0Y0_輪1_金具2.Dra;
			}
			set
			{
				this.X0Y0_輪1_金具2.Dra = value;
				this.X0Y0_輪1_金具2.Hit = value;
			}
		}

		public bool 輪1_金具3_表示
		{
			get
			{
				return this.X0Y0_輪1_金具3.Dra;
			}
			set
			{
				this.X0Y0_輪1_金具3.Dra = value;
				this.X0Y0_輪1_金具3.Hit = value;
			}
		}

		public bool 輪1_金具左_表示
		{
			get
			{
				return this.X0Y0_輪1_金具左.Dra;
			}
			set
			{
				this.X0Y0_輪1_金具左.Dra = value;
				this.X0Y0_輪1_金具左.Hit = value;
			}
		}

		public bool 輪1_金具右_表示
		{
			get
			{
				return this.X0Y0_輪1_金具右.Dra;
			}
			set
			{
				this.X0Y0_輪1_金具右.Dra = value;
				this.X0Y0_輪1_金具右.Hit = value;
			}
		}

		public bool 尾27_鱗_表示
		{
			get
			{
				return this.X0Y0_尾27_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾27_鱗.Dra = value;
				this.X0Y0_尾27_鱗.Hit = value;
			}
		}

		public bool 尾27_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾27_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾27_鱗左.Dra = value;
				this.X0Y0_尾27_鱗左.Hit = value;
			}
		}

		public bool 尾27_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾27_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾27_鱗右.Dra = value;
				this.X0Y0_尾27_鱗右.Hit = value;
			}
		}

		public bool 尾27_尾_表示
		{
			get
			{
				return this.X0Y0_尾27_尾.Dra;
			}
			set
			{
				this.X0Y0_尾27_尾.Dra = value;
				this.X0Y0_尾27_尾.Hit = value;
			}
		}

		public bool 尾28_鱗_表示
		{
			get
			{
				return this.X0Y0_尾28_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾28_鱗.Dra = value;
				this.X0Y0_尾28_鱗.Hit = value;
			}
		}

		public bool 尾28_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾28_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾28_鱗左.Dra = value;
				this.X0Y0_尾28_鱗左.Hit = value;
			}
		}

		public bool 尾28_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾28_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾28_鱗右.Dra = value;
				this.X0Y0_尾28_鱗右.Hit = value;
			}
		}

		public bool 尾28_尾_表示
		{
			get
			{
				return this.X0Y0_尾28_尾.Dra;
			}
			set
			{
				this.X0Y0_尾28_尾.Dra = value;
				this.X0Y0_尾28_尾.Hit = value;
			}
		}

		public bool 尾29_鱗_表示
		{
			get
			{
				return this.X0Y0_尾29_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾29_鱗.Dra = value;
				this.X0Y0_尾29_鱗.Hit = value;
			}
		}

		public bool 尾29_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾29_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾29_鱗左.Dra = value;
				this.X0Y0_尾29_鱗左.Hit = value;
			}
		}

		public bool 尾29_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾29_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾29_鱗右.Dra = value;
				this.X0Y0_尾29_鱗右.Hit = value;
			}
		}

		public bool 尾29_尾_表示
		{
			get
			{
				return this.X0Y0_尾29_尾.Dra;
			}
			set
			{
				this.X0Y0_尾29_尾.Dra = value;
				this.X0Y0_尾29_尾.Hit = value;
			}
		}

		public bool 尾30_鱗_表示
		{
			get
			{
				return this.X0Y0_尾30_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾30_鱗.Dra = value;
				this.X0Y0_尾30_鱗.Hit = value;
			}
		}

		public bool 尾30_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾30_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾30_鱗左.Dra = value;
				this.X0Y0_尾30_鱗左.Hit = value;
			}
		}

		public bool 尾30_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾30_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾30_鱗右.Dra = value;
				this.X0Y0_尾30_鱗右.Hit = value;
			}
		}

		public bool 尾30_尾_表示
		{
			get
			{
				return this.X0Y0_尾30_尾.Dra;
			}
			set
			{
				this.X0Y0_尾30_尾.Dra = value;
				this.X0Y0_尾30_尾.Hit = value;
			}
		}

		public bool 尾31_鱗_表示
		{
			get
			{
				return this.X0Y0_尾31_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾31_鱗.Dra = value;
				this.X0Y0_尾31_鱗.Hit = value;
			}
		}

		public bool 尾31_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾31_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾31_鱗左.Dra = value;
				this.X0Y0_尾31_鱗左.Hit = value;
			}
		}

		public bool 尾31_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾31_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾31_鱗右.Dra = value;
				this.X0Y0_尾31_鱗右.Hit = value;
			}
		}

		public bool 尾31_尾_表示
		{
			get
			{
				return this.X0Y0_尾31_尾.Dra;
			}
			set
			{
				this.X0Y0_尾31_尾.Dra = value;
				this.X0Y0_尾31_尾.Hit = value;
			}
		}

		public bool 尾32_鱗_表示
		{
			get
			{
				return this.X0Y0_尾32_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾32_鱗.Dra = value;
				this.X0Y0_尾32_鱗.Hit = value;
			}
		}

		public bool 尾32_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾32_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾32_鱗左.Dra = value;
				this.X0Y0_尾32_鱗左.Hit = value;
			}
		}

		public bool 尾32_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾32_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾32_鱗右.Dra = value;
				this.X0Y0_尾32_鱗右.Hit = value;
			}
		}

		public bool 尾32_尾_表示
		{
			get
			{
				return this.X0Y0_尾32_尾.Dra;
			}
			set
			{
				this.X0Y0_尾32_尾.Dra = value;
				this.X0Y0_尾32_尾.Hit = value;
			}
		}

		public bool 尾33_鱗_表示
		{
			get
			{
				return this.X0Y0_尾33_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾33_鱗.Dra = value;
				this.X0Y0_尾33_鱗.Hit = value;
			}
		}

		public bool 尾33_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾33_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾33_鱗左.Dra = value;
				this.X0Y0_尾33_鱗左.Hit = value;
			}
		}

		public bool 尾33_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾33_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾33_鱗右.Dra = value;
				this.X0Y0_尾33_鱗右.Hit = value;
			}
		}

		public bool 尾33_尾_表示
		{
			get
			{
				return this.X0Y0_尾33_尾.Dra;
			}
			set
			{
				this.X0Y0_尾33_尾.Dra = value;
				this.X0Y0_尾33_尾.Hit = value;
			}
		}

		public bool 尾34_鱗_表示
		{
			get
			{
				return this.X0Y0_尾34_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾34_鱗.Dra = value;
				this.X0Y0_尾34_鱗.Hit = value;
			}
		}

		public bool 尾34_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾34_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾34_鱗左.Dra = value;
				this.X0Y0_尾34_鱗左.Hit = value;
			}
		}

		public bool 尾34_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾34_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾34_鱗右.Dra = value;
				this.X0Y0_尾34_鱗右.Hit = value;
			}
		}

		public bool 尾34_尾_表示
		{
			get
			{
				return this.X0Y0_尾34_尾.Dra;
			}
			set
			{
				this.X0Y0_尾34_尾.Dra = value;
				this.X0Y0_尾34_尾.Hit = value;
			}
		}

		public bool 尾35_鱗_表示
		{
			get
			{
				return this.X0Y0_尾35_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾35_鱗.Dra = value;
				this.X0Y0_尾35_鱗.Hit = value;
			}
		}

		public bool 尾35_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾35_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾35_鱗左.Dra = value;
				this.X0Y0_尾35_鱗左.Hit = value;
			}
		}

		public bool 尾35_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾35_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾35_鱗右.Dra = value;
				this.X0Y0_尾35_鱗右.Hit = value;
			}
		}

		public bool 尾35_尾_表示
		{
			get
			{
				return this.X0Y0_尾35_尾.Dra;
			}
			set
			{
				this.X0Y0_尾35_尾.Dra = value;
				this.X0Y0_尾35_尾.Hit = value;
			}
		}

		public bool 尾36_鱗_表示
		{
			get
			{
				return this.X0Y0_尾36_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾36_鱗.Dra = value;
				this.X0Y0_尾36_鱗.Hit = value;
			}
		}

		public bool 尾36_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾36_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾36_鱗左.Dra = value;
				this.X0Y0_尾36_鱗左.Hit = value;
			}
		}

		public bool 尾36_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾36_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾36_鱗右.Dra = value;
				this.X0Y0_尾36_鱗右.Hit = value;
			}
		}

		public bool 尾36_尾_表示
		{
			get
			{
				return this.X0Y0_尾36_尾.Dra;
			}
			set
			{
				this.X0Y0_尾36_尾.Dra = value;
				this.X0Y0_尾36_尾.Hit = value;
			}
		}

		public bool 尾37_鱗_表示
		{
			get
			{
				return this.X0Y0_尾37_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾37_鱗.Dra = value;
				this.X0Y0_尾37_鱗.Hit = value;
			}
		}

		public bool 尾37_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾37_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾37_鱗左.Dra = value;
				this.X0Y0_尾37_鱗左.Hit = value;
			}
		}

		public bool 尾37_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾37_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾37_鱗右.Dra = value;
				this.X0Y0_尾37_鱗右.Hit = value;
			}
		}

		public bool 尾37_尾_表示
		{
			get
			{
				return this.X0Y0_尾37_尾.Dra;
			}
			set
			{
				this.X0Y0_尾37_尾.Dra = value;
				this.X0Y0_尾37_尾.Hit = value;
			}
		}

		public bool 尾38_鱗_表示
		{
			get
			{
				return this.X0Y0_尾38_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾38_鱗.Dra = value;
				this.X0Y0_尾38_鱗.Hit = value;
			}
		}

		public bool 尾38_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾38_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾38_鱗左.Dra = value;
				this.X0Y0_尾38_鱗左.Hit = value;
			}
		}

		public bool 尾38_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾38_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾38_鱗右.Dra = value;
				this.X0Y0_尾38_鱗右.Hit = value;
			}
		}

		public bool 尾38_尾_表示
		{
			get
			{
				return this.X0Y0_尾38_尾.Dra;
			}
			set
			{
				this.X0Y0_尾38_尾.Dra = value;
				this.X0Y0_尾38_尾.Hit = value;
			}
		}

		public bool 尾39_鱗_表示
		{
			get
			{
				return this.X0Y0_尾39_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾39_鱗.Dra = value;
				this.X0Y0_尾39_鱗.Hit = value;
			}
		}

		public bool 尾39_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾39_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾39_鱗左.Dra = value;
				this.X0Y0_尾39_鱗左.Hit = value;
			}
		}

		public bool 尾39_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾39_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾39_鱗右.Dra = value;
				this.X0Y0_尾39_鱗右.Hit = value;
			}
		}

		public bool 尾39_尾_表示
		{
			get
			{
				return this.X0Y0_尾39_尾.Dra;
			}
			set
			{
				this.X0Y0_尾39_尾.Dra = value;
				this.X0Y0_尾39_尾.Hit = value;
			}
		}

		public bool 尾40_鱗_表示
		{
			get
			{
				return this.X0Y0_尾40_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾40_鱗.Dra = value;
				this.X0Y0_尾40_鱗.Hit = value;
			}
		}

		public bool 尾40_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾40_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾40_鱗左.Dra = value;
				this.X0Y0_尾40_鱗左.Hit = value;
			}
		}

		public bool 尾40_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾40_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾40_鱗右.Dra = value;
				this.X0Y0_尾40_鱗右.Hit = value;
			}
		}

		public bool 尾40_尾_表示
		{
			get
			{
				return this.X0Y0_尾40_尾.Dra;
			}
			set
			{
				this.X0Y0_尾40_尾.Dra = value;
				this.X0Y0_尾40_尾.Hit = value;
			}
		}

		public bool 尾41_鱗_表示
		{
			get
			{
				return this.X0Y0_尾41_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾41_鱗.Dra = value;
				this.X0Y0_尾41_鱗.Hit = value;
			}
		}

		public bool 尾41_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾41_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾41_鱗左.Dra = value;
				this.X0Y0_尾41_鱗左.Hit = value;
			}
		}

		public bool 尾41_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾41_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾41_鱗右.Dra = value;
				this.X0Y0_尾41_鱗右.Hit = value;
			}
		}

		public bool 尾41_尾_表示
		{
			get
			{
				return this.X0Y0_尾41_尾.Dra;
			}
			set
			{
				this.X0Y0_尾41_尾.Dra = value;
				this.X0Y0_尾41_尾.Hit = value;
			}
		}

		public bool 尾42_鱗_表示
		{
			get
			{
				return this.X0Y0_尾42_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾42_鱗.Dra = value;
				this.X0Y0_尾42_鱗.Hit = value;
			}
		}

		public bool 尾42_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾42_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾42_鱗左.Dra = value;
				this.X0Y0_尾42_鱗左.Hit = value;
			}
		}

		public bool 尾42_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾42_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾42_鱗右.Dra = value;
				this.X0Y0_尾42_鱗右.Hit = value;
			}
		}

		public bool 尾42_尾_表示
		{
			get
			{
				return this.X0Y0_尾42_尾.Dra;
			}
			set
			{
				this.X0Y0_尾42_尾.Dra = value;
				this.X0Y0_尾42_尾.Hit = value;
			}
		}

		public bool 尾43_鱗_表示
		{
			get
			{
				return this.X0Y0_尾43_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾43_鱗.Dra = value;
				this.X0Y0_尾43_鱗.Hit = value;
			}
		}

		public bool 尾43_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾43_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾43_鱗左.Dra = value;
				this.X0Y0_尾43_鱗左.Hit = value;
			}
		}

		public bool 尾43_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾43_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾43_鱗右.Dra = value;
				this.X0Y0_尾43_鱗右.Hit = value;
			}
		}

		public bool 尾43_尾_表示
		{
			get
			{
				return this.X0Y0_尾43_尾.Dra;
			}
			set
			{
				this.X0Y0_尾43_尾.Dra = value;
				this.X0Y0_尾43_尾.Hit = value;
			}
		}

		public bool 尾44_鱗_表示
		{
			get
			{
				return this.X0Y0_尾44_鱗.Dra;
			}
			set
			{
				this.X0Y0_尾44_鱗.Dra = value;
				this.X0Y0_尾44_鱗.Hit = value;
			}
		}

		public bool 尾44_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾44_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾44_鱗左.Dra = value;
				this.X0Y0_尾44_鱗左.Hit = value;
			}
		}

		public bool 尾44_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾44_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾44_鱗右.Dra = value;
				this.X0Y0_尾44_鱗右.Hit = value;
			}
		}

		public bool 尾44_尾_表示
		{
			get
			{
				return this.X0Y0_尾44_尾.Dra;
			}
			set
			{
				this.X0Y0_尾44_尾.Dra = value;
				this.X0Y0_尾44_尾.Hit = value;
			}
		}

		public bool 頭_上顎_顎基_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_顎基.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_顎基.Dra = value;
				this.X0Y0_頭_上顎_顎基.Hit = value;
			}
		}

		public bool 頭_上顎_鱗4_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_鱗4.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_鱗4.Dra = value;
				this.X0Y0_頭_上顎_鱗4.Hit = value;
			}
		}

		public bool 頭_上顎_鱗左1_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_鱗左1.Dra = value;
				this.X0Y0_頭_上顎_鱗左1.Hit = value;
			}
		}

		public bool 頭_上顎_鱗右1_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_鱗右1.Dra = value;
				this.X0Y0_頭_上顎_鱗右1.Hit = value;
			}
		}

		public bool 頭_上顎_鱗左2_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_鱗左2.Dra = value;
				this.X0Y0_頭_上顎_鱗左2.Hit = value;
			}
		}

		public bool 頭_上顎_鱗右2_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_鱗右2.Dra = value;
				this.X0Y0_頭_上顎_鱗右2.Hit = value;
			}
		}

		public bool 頭_上顎_鱗左3_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_鱗左3.Dra = value;
				this.X0Y0_頭_上顎_鱗左3.Hit = value;
			}
		}

		public bool 頭_上顎_鱗右3_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_鱗右3.Dra = value;
				this.X0Y0_頭_上顎_鱗右3.Hit = value;
			}
		}

		public bool 頭_上顎_鱗左4_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_鱗左4.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_鱗左4.Dra = value;
				this.X0Y0_頭_上顎_鱗左4.Hit = value;
			}
		}

		public bool 頭_上顎_鱗右4_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_鱗右4.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_鱗右4.Dra = value;
				this.X0Y0_頭_上顎_鱗右4.Hit = value;
			}
		}

		public bool 頭_上顎_鱗左5_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_鱗左5.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_鱗左5.Dra = value;
				this.X0Y0_頭_上顎_鱗左5.Hit = value;
			}
		}

		public bool 頭_上顎_鱗右5_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_鱗右5.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_鱗右5.Dra = value;
				this.X0Y0_頭_上顎_鱗右5.Hit = value;
			}
		}

		public bool 頭_上顎_鱗左8_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_鱗左8.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_鱗左8.Dra = value;
				this.X0Y0_頭_上顎_鱗左8.Hit = value;
			}
		}

		public bool 頭_上顎_鱗右8_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_鱗右8.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_鱗右8.Dra = value;
				this.X0Y0_頭_上顎_鱗右8.Hit = value;
			}
		}

		public bool 頭_上顎_鱗左9_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_鱗左9.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_鱗左9.Dra = value;
				this.X0Y0_頭_上顎_鱗左9.Hit = value;
			}
		}

		public bool 頭_上顎_鱗右9_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_鱗右9.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_鱗右9.Dra = value;
				this.X0Y0_頭_上顎_鱗右9.Hit = value;
			}
		}

		public bool 頭_上顎_鱗左10_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_鱗左10.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_鱗左10.Dra = value;
				this.X0Y0_頭_上顎_鱗左10.Hit = value;
			}
		}

		public bool 頭_上顎_鱗右10_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_鱗右10.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_鱗右10.Dra = value;
				this.X0Y0_頭_上顎_鱗右10.Hit = value;
			}
		}

		public bool 頭_上顎_鱗左11_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_鱗左11.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_鱗左11.Dra = value;
				this.X0Y0_頭_上顎_鱗左11.Hit = value;
			}
		}

		public bool 頭_上顎_鱗右11_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_鱗右11.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_鱗右11.Dra = value;
				this.X0Y0_頭_上顎_鱗右11.Hit = value;
			}
		}

		public bool 頭_下顎_顎基_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_顎基.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_顎基.Dra = value;
				this.X0Y0_頭_下顎_顎基.Hit = value;
			}
		}

		public bool 頭_下顎_鱗1_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗1.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗1.Dra = value;
				this.X0Y0_頭_下顎_鱗1.Hit = value;
			}
		}

		public bool 頭_下顎_鱗2_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗2.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗2.Dra = value;
				this.X0Y0_頭_下顎_鱗2.Hit = value;
			}
		}

		public bool 頭_下顎_鱗3_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗3.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗3.Dra = value;
				this.X0Y0_頭_下顎_鱗3.Hit = value;
			}
		}

		public bool 頭_下顎_鱗4_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗4.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗4.Dra = value;
				this.X0Y0_頭_下顎_鱗4.Hit = value;
			}
		}

		public bool 頭_下顎_鱗左1_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗左1.Dra = value;
				this.X0Y0_頭_下顎_鱗左1.Hit = value;
			}
		}

		public bool 頭_下顎_鱗右1_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗右1.Dra = value;
				this.X0Y0_頭_下顎_鱗右1.Hit = value;
			}
		}

		public bool 頭_下顎_鱗左2_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗左2.Dra = value;
				this.X0Y0_頭_下顎_鱗左2.Hit = value;
			}
		}

		public bool 頭_下顎_鱗右2_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗右2.Dra = value;
				this.X0Y0_頭_下顎_鱗右2.Hit = value;
			}
		}

		public bool 頭_下顎_鱗左3_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗左3.Dra = value;
				this.X0Y0_頭_下顎_鱗左3.Hit = value;
			}
		}

		public bool 頭_下顎_鱗右3_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗右3.Dra = value;
				this.X0Y0_頭_下顎_鱗右3.Hit = value;
			}
		}

		public bool 頭_下顎_鱗左4_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗左4.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗左4.Dra = value;
				this.X0Y0_頭_下顎_鱗左4.Hit = value;
			}
		}

		public bool 頭_下顎_鱗右4_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗右4.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗右4.Dra = value;
				this.X0Y0_頭_下顎_鱗右4.Hit = value;
			}
		}

		public bool 頭_下顎_鱗左5_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗左5.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗左5.Dra = value;
				this.X0Y0_頭_下顎_鱗左5.Hit = value;
			}
		}

		public bool 頭_下顎_鱗右5_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗右5.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗右5.Dra = value;
				this.X0Y0_頭_下顎_鱗右5.Hit = value;
			}
		}

		public bool 頭_下顎_鱗左6_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗左6.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗左6.Dra = value;
				this.X0Y0_頭_下顎_鱗左6.Hit = value;
			}
		}

		public bool 頭_下顎_鱗右6_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗右6.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗右6.Dra = value;
				this.X0Y0_頭_下顎_鱗右6.Hit = value;
			}
		}

		public bool 頭_下顎_鱗左7_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗左7.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗左7.Dra = value;
				this.X0Y0_頭_下顎_鱗左7.Hit = value;
			}
		}

		public bool 頭_下顎_鱗右7_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗右7.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗右7.Dra = value;
				this.X0Y0_頭_下顎_鱗右7.Hit = value;
			}
		}

		public bool 頭_下顎_鱗左8_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗左8.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗左8.Dra = value;
				this.X0Y0_頭_下顎_鱗左8.Hit = value;
			}
		}

		public bool 頭_下顎_鱗右8_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗右8.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗右8.Dra = value;
				this.X0Y0_頭_下顎_鱗右8.Hit = value;
			}
		}

		public bool 頭_下顎_鱗左9_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗左9.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗左9.Dra = value;
				this.X0Y0_頭_下顎_鱗左9.Hit = value;
			}
		}

		public bool 頭_下顎_鱗右9_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗右9.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗右9.Dra = value;
				this.X0Y0_頭_下顎_鱗右9.Hit = value;
			}
		}

		public bool 頭_下顎_鱗左10_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗左10.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗左10.Dra = value;
				this.X0Y0_頭_下顎_鱗左10.Hit = value;
			}
		}

		public bool 頭_下顎_鱗右10_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗右10.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗右10.Dra = value;
				this.X0Y0_頭_下顎_鱗右10.Hit = value;
			}
		}

		public bool 頭_下顎_鱗左11_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗左11.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗左11.Dra = value;
				this.X0Y0_頭_下顎_鱗左11.Hit = value;
			}
		}

		public bool 頭_下顎_鱗右11_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_鱗右11.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_鱗右11.Dra = value;
				this.X0Y0_頭_下顎_鱗右11.Hit = value;
			}
		}

		public bool 輪2_革_表示
		{
			get
			{
				return this.X0Y0_輪2_革.Dra;
			}
			set
			{
				this.X0Y0_輪2_革.Dra = value;
				this.X0Y0_輪2_革.Hit = value;
			}
		}

		public bool 輪2_金具1_表示
		{
			get
			{
				return this.X0Y0_輪2_金具1.Dra;
			}
			set
			{
				this.X0Y0_輪2_金具1.Dra = value;
				this.X0Y0_輪2_金具1.Hit = value;
			}
		}

		public bool 輪2_金具2_表示
		{
			get
			{
				return this.X0Y0_輪2_金具2.Dra;
			}
			set
			{
				this.X0Y0_輪2_金具2.Dra = value;
				this.X0Y0_輪2_金具2.Hit = value;
			}
		}

		public bool 輪2_金具3_表示
		{
			get
			{
				return this.X0Y0_輪2_金具3.Dra;
			}
			set
			{
				this.X0Y0_輪2_金具3.Dra = value;
				this.X0Y0_輪2_金具3.Hit = value;
			}
		}

		public bool 輪2_金具左_表示
		{
			get
			{
				return this.X0Y0_輪2_金具左.Dra;
			}
			set
			{
				this.X0Y0_輪2_金具左.Dra = value;
				this.X0Y0_輪2_金具左.Hit = value;
			}
		}

		public bool 輪2_金具右_表示
		{
			get
			{
				return this.X0Y0_輪2_金具右.Dra;
			}
			set
			{
				this.X0Y0_輪2_金具右.Dra = value;
				this.X0Y0_輪2_金具右.Hit = value;
			}
		}

		public bool 輪1表示
		{
			get
			{
				return this.輪1_革_表示;
			}
			set
			{
				this.輪1_革_表示 = value;
				this.輪1_金具1_表示 = value;
				this.輪1_金具2_表示 = value;
				this.輪1_金具3_表示 = value;
				this.輪1_金具左_表示 = value;
				this.輪1_金具右_表示 = value;
			}
		}

		public bool 輪2表示
		{
			get
			{
				return this.輪2_革_表示;
			}
			set
			{
				this.輪2_革_表示 = value;
				this.輪2_金具1_表示 = value;
				this.輪2_金具2_表示 = value;
				this.輪2_金具3_表示 = value;
				this.輪2_金具左_表示 = value;
				this.輪2_金具右_表示 = value;
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
				this.鎖3.表示 = value;
				this.鎖4.表示 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.尾1_根_表示;
			}
			set
			{
				this.尾1_根_表示 = value;
				this.尾1_鱗_表示 = value;
				this.尾1_鱗左_表示 = value;
				this.尾1_鱗右_表示 = value;
				this.尾1_尾_表示 = value;
				this.尾2_鱗_表示 = value;
				this.尾2_鱗左_表示 = value;
				this.尾2_鱗右_表示 = value;
				this.尾2_尾_表示 = value;
				this.尾3_鱗_表示 = value;
				this.尾3_鱗左_表示 = value;
				this.尾3_鱗右_表示 = value;
				this.尾3_尾_表示 = value;
				this.尾4_鱗_表示 = value;
				this.尾4_鱗左_表示 = value;
				this.尾4_鱗右_表示 = value;
				this.尾4_尾_表示 = value;
				this.尾5_鱗_表示 = value;
				this.尾5_鱗左_表示 = value;
				this.尾5_鱗右_表示 = value;
				this.尾5_尾_表示 = value;
				this.尾6_鱗_表示 = value;
				this.尾6_鱗左_表示 = value;
				this.尾6_鱗右_表示 = value;
				this.尾6_尾_表示 = value;
				this.尾7_鱗_表示 = value;
				this.尾7_鱗左_表示 = value;
				this.尾7_鱗右_表示 = value;
				this.尾7_尾_表示 = value;
				this.尾8_鱗_表示 = value;
				this.尾8_鱗左_表示 = value;
				this.尾8_鱗右_表示 = value;
				this.尾8_尾_表示 = value;
				this.尾9_鱗_表示 = value;
				this.尾9_鱗左_表示 = value;
				this.尾9_鱗右_表示 = value;
				this.尾9_尾_表示 = value;
				this.尾10_鱗_表示 = value;
				this.尾10_鱗左_表示 = value;
				this.尾10_鱗右_表示 = value;
				this.尾10_尾_表示 = value;
				this.尾11_鱗_表示 = value;
				this.尾11_鱗左_表示 = value;
				this.尾11_鱗右_表示 = value;
				this.尾11_尾_表示 = value;
				this.尾12_鱗_表示 = value;
				this.尾12_鱗左_表示 = value;
				this.尾12_鱗右_表示 = value;
				this.尾12_尾_表示 = value;
				this.尾13_鱗_表示 = value;
				this.尾13_鱗左_表示 = value;
				this.尾13_鱗右_表示 = value;
				this.尾13_尾_表示 = value;
				this.尾14_鱗_表示 = value;
				this.尾14_鱗左_表示 = value;
				this.尾14_鱗右_表示 = value;
				this.尾14_尾_表示 = value;
				this.尾15_鱗_表示 = value;
				this.尾15_鱗左_表示 = value;
				this.尾15_鱗右_表示 = value;
				this.尾15_尾_表示 = value;
				this.尾16_鱗_表示 = value;
				this.尾16_鱗左_表示 = value;
				this.尾16_鱗右_表示 = value;
				this.尾16_尾_表示 = value;
				this.尾17_鱗_表示 = value;
				this.尾17_鱗左_表示 = value;
				this.尾17_鱗右_表示 = value;
				this.尾17_尾_表示 = value;
				this.尾18_鱗_表示 = value;
				this.尾18_鱗左_表示 = value;
				this.尾18_鱗右_表示 = value;
				this.尾18_尾_表示 = value;
				this.尾19_鱗_表示 = value;
				this.尾19_鱗左_表示 = value;
				this.尾19_鱗右_表示 = value;
				this.尾19_尾_表示 = value;
				this.尾20_鱗_表示 = value;
				this.尾20_鱗左_表示 = value;
				this.尾20_鱗右_表示 = value;
				this.尾20_尾_表示 = value;
				this.尾21_鱗_表示 = value;
				this.尾21_鱗左_表示 = value;
				this.尾21_鱗右_表示 = value;
				this.尾21_尾_表示 = value;
				this.尾22_鱗_表示 = value;
				this.尾22_鱗左_表示 = value;
				this.尾22_鱗右_表示 = value;
				this.尾22_尾_表示 = value;
				this.尾23_鱗_表示 = value;
				this.尾23_鱗左_表示 = value;
				this.尾23_鱗右_表示 = value;
				this.尾23_尾_表示 = value;
				this.尾24_鱗_表示 = value;
				this.尾24_鱗左_表示 = value;
				this.尾24_鱗右_表示 = value;
				this.尾24_尾_表示 = value;
				this.尾25_鱗_表示 = value;
				this.尾25_鱗左_表示 = value;
				this.尾25_鱗右_表示 = value;
				this.尾25_尾_表示 = value;
				this.尾26_鱗_表示 = value;
				this.尾26_鱗左_表示 = value;
				this.尾26_鱗右_表示 = value;
				this.尾26_尾_表示 = value;
				this.輪1_革_表示 = value;
				this.輪1_金具1_表示 = value;
				this.輪1_金具2_表示 = value;
				this.輪1_金具3_表示 = value;
				this.輪1_金具左_表示 = value;
				this.輪1_金具右_表示 = value;
				this.尾27_鱗_表示 = value;
				this.尾27_鱗左_表示 = value;
				this.尾27_鱗右_表示 = value;
				this.尾27_尾_表示 = value;
				this.尾28_鱗_表示 = value;
				this.尾28_鱗左_表示 = value;
				this.尾28_鱗右_表示 = value;
				this.尾28_尾_表示 = value;
				this.尾29_鱗_表示 = value;
				this.尾29_鱗左_表示 = value;
				this.尾29_鱗右_表示 = value;
				this.尾29_尾_表示 = value;
				this.尾30_鱗_表示 = value;
				this.尾30_鱗左_表示 = value;
				this.尾30_鱗右_表示 = value;
				this.尾30_尾_表示 = value;
				this.尾31_鱗_表示 = value;
				this.尾31_鱗左_表示 = value;
				this.尾31_鱗右_表示 = value;
				this.尾31_尾_表示 = value;
				this.尾32_鱗_表示 = value;
				this.尾32_鱗左_表示 = value;
				this.尾32_鱗右_表示 = value;
				this.尾32_尾_表示 = value;
				this.尾33_鱗_表示 = value;
				this.尾33_鱗左_表示 = value;
				this.尾33_鱗右_表示 = value;
				this.尾33_尾_表示 = value;
				this.尾34_鱗_表示 = value;
				this.尾34_鱗左_表示 = value;
				this.尾34_鱗右_表示 = value;
				this.尾34_尾_表示 = value;
				this.尾35_鱗_表示 = value;
				this.尾35_鱗左_表示 = value;
				this.尾35_鱗右_表示 = value;
				this.尾35_尾_表示 = value;
				this.尾36_鱗_表示 = value;
				this.尾36_鱗左_表示 = value;
				this.尾36_鱗右_表示 = value;
				this.尾36_尾_表示 = value;
				this.尾37_鱗_表示 = value;
				this.尾37_鱗左_表示 = value;
				this.尾37_鱗右_表示 = value;
				this.尾37_尾_表示 = value;
				this.尾38_鱗_表示 = value;
				this.尾38_鱗左_表示 = value;
				this.尾38_鱗右_表示 = value;
				this.尾38_尾_表示 = value;
				this.尾39_鱗_表示 = value;
				this.尾39_鱗左_表示 = value;
				this.尾39_鱗右_表示 = value;
				this.尾39_尾_表示 = value;
				this.尾40_鱗_表示 = value;
				this.尾40_鱗左_表示 = value;
				this.尾40_鱗右_表示 = value;
				this.尾40_尾_表示 = value;
				this.尾41_鱗_表示 = value;
				this.尾41_鱗左_表示 = value;
				this.尾41_鱗右_表示 = value;
				this.尾41_尾_表示 = value;
				this.尾42_鱗_表示 = value;
				this.尾42_鱗左_表示 = value;
				this.尾42_鱗右_表示 = value;
				this.尾42_尾_表示 = value;
				this.尾43_鱗_表示 = value;
				this.尾43_鱗左_表示 = value;
				this.尾43_鱗右_表示 = value;
				this.尾43_尾_表示 = value;
				this.尾44_鱗_表示 = value;
				this.尾44_鱗左_表示 = value;
				this.尾44_鱗右_表示 = value;
				this.尾44_尾_表示 = value;
				this.頭_上顎_顎基_表示 = value;
				this.頭_上顎_鱗4_表示 = value;
				this.頭_上顎_鱗左1_表示 = value;
				this.頭_上顎_鱗右1_表示 = value;
				this.頭_上顎_鱗左2_表示 = value;
				this.頭_上顎_鱗右2_表示 = value;
				this.頭_上顎_鱗左3_表示 = value;
				this.頭_上顎_鱗右3_表示 = value;
				this.頭_上顎_鱗左4_表示 = value;
				this.頭_上顎_鱗右4_表示 = value;
				this.頭_上顎_鱗左5_表示 = value;
				this.頭_上顎_鱗右5_表示 = value;
				this.頭_上顎_鱗左8_表示 = value;
				this.頭_上顎_鱗右8_表示 = value;
				this.頭_上顎_鱗左9_表示 = value;
				this.頭_上顎_鱗右9_表示 = value;
				this.頭_上顎_鱗左10_表示 = value;
				this.頭_上顎_鱗右10_表示 = value;
				this.頭_上顎_鱗左11_表示 = value;
				this.頭_上顎_鱗右11_表示 = value;
				this.頭_下顎_顎基_表示 = value;
				this.頭_下顎_鱗1_表示 = value;
				this.頭_下顎_鱗2_表示 = value;
				this.頭_下顎_鱗3_表示 = value;
				this.頭_下顎_鱗4_表示 = value;
				this.頭_下顎_鱗左1_表示 = value;
				this.頭_下顎_鱗右1_表示 = value;
				this.頭_下顎_鱗左2_表示 = value;
				this.頭_下顎_鱗右2_表示 = value;
				this.頭_下顎_鱗左3_表示 = value;
				this.頭_下顎_鱗右3_表示 = value;
				this.頭_下顎_鱗左4_表示 = value;
				this.頭_下顎_鱗右4_表示 = value;
				this.頭_下顎_鱗左5_表示 = value;
				this.頭_下顎_鱗右5_表示 = value;
				this.頭_下顎_鱗左6_表示 = value;
				this.頭_下顎_鱗右6_表示 = value;
				this.頭_下顎_鱗左7_表示 = value;
				this.頭_下顎_鱗右7_表示 = value;
				this.頭_下顎_鱗左8_表示 = value;
				this.頭_下顎_鱗右8_表示 = value;
				this.頭_下顎_鱗左9_表示 = value;
				this.頭_下顎_鱗右9_表示 = value;
				this.頭_下顎_鱗左10_表示 = value;
				this.頭_下顎_鱗右10_表示 = value;
				this.頭_下顎_鱗左11_表示 = value;
				this.頭_下顎_鱗右11_表示 = value;
				this.輪2_革_表示 = value;
				this.輪2_金具1_表示 = value;
				this.輪2_金具2_表示 = value;
				this.輪2_金具3_表示 = value;
				this.輪2_金具左_表示 = value;
				this.輪2_金具右_表示 = value;
				this.鎖1.表示 = value;
				this.鎖2.表示 = value;
				this.鎖3.表示 = value;
				this.鎖4.表示 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_尾1_根);
			Are.Draw(this.X0Y0_尾1_鱗);
			Are.Draw(this.X0Y0_尾1_鱗左);
			Are.Draw(this.X0Y0_尾1_鱗右);
			Are.Draw(this.X0Y0_尾1_尾);
			Are.Draw(this.X0Y0_尾2_鱗);
			Are.Draw(this.X0Y0_尾2_鱗左);
			Are.Draw(this.X0Y0_尾2_鱗右);
			Are.Draw(this.X0Y0_尾2_尾);
			Are.Draw(this.X0Y0_尾3_鱗);
			Are.Draw(this.X0Y0_尾3_鱗左);
			Are.Draw(this.X0Y0_尾3_鱗右);
			Are.Draw(this.X0Y0_尾3_尾);
			Are.Draw(this.X0Y0_尾4_鱗);
			Are.Draw(this.X0Y0_尾4_鱗左);
			Are.Draw(this.X0Y0_尾4_鱗右);
			Are.Draw(this.X0Y0_尾4_尾);
			Are.Draw(this.X0Y0_尾5_鱗);
			Are.Draw(this.X0Y0_尾5_鱗左);
			Are.Draw(this.X0Y0_尾5_鱗右);
			Are.Draw(this.X0Y0_尾5_尾);
			Are.Draw(this.X0Y0_尾6_鱗);
			Are.Draw(this.X0Y0_尾6_鱗左);
			Are.Draw(this.X0Y0_尾6_鱗右);
			Are.Draw(this.X0Y0_尾6_尾);
			Are.Draw(this.X0Y0_尾7_鱗);
			Are.Draw(this.X0Y0_尾7_鱗左);
			Are.Draw(this.X0Y0_尾7_鱗右);
			Are.Draw(this.X0Y0_尾7_尾);
			Are.Draw(this.X0Y0_尾8_鱗);
			Are.Draw(this.X0Y0_尾8_鱗左);
			Are.Draw(this.X0Y0_尾8_鱗右);
			Are.Draw(this.X0Y0_尾8_尾);
			Are.Draw(this.X0Y0_尾9_鱗);
			Are.Draw(this.X0Y0_尾9_鱗左);
			Are.Draw(this.X0Y0_尾9_鱗右);
			Are.Draw(this.X0Y0_尾9_尾);
			Are.Draw(this.X0Y0_尾10_鱗);
			Are.Draw(this.X0Y0_尾10_鱗左);
			Are.Draw(this.X0Y0_尾10_鱗右);
			Are.Draw(this.X0Y0_尾10_尾);
			Are.Draw(this.X0Y0_尾11_鱗);
			Are.Draw(this.X0Y0_尾11_鱗左);
			Are.Draw(this.X0Y0_尾11_鱗右);
			Are.Draw(this.X0Y0_尾11_尾);
			Are.Draw(this.X0Y0_尾12_鱗);
			Are.Draw(this.X0Y0_尾12_鱗左);
			Are.Draw(this.X0Y0_尾12_鱗右);
			Are.Draw(this.X0Y0_尾12_尾);
			Are.Draw(this.X0Y0_尾13_鱗);
			Are.Draw(this.X0Y0_尾13_鱗左);
			Are.Draw(this.X0Y0_尾13_鱗右);
			Are.Draw(this.X0Y0_尾13_尾);
			Are.Draw(this.X0Y0_尾14_鱗);
			Are.Draw(this.X0Y0_尾14_鱗左);
			Are.Draw(this.X0Y0_尾14_鱗右);
			Are.Draw(this.X0Y0_尾14_尾);
			Are.Draw(this.X0Y0_尾15_鱗);
			Are.Draw(this.X0Y0_尾15_鱗左);
			Are.Draw(this.X0Y0_尾15_鱗右);
			Are.Draw(this.X0Y0_尾15_尾);
			Are.Draw(this.X0Y0_尾16_鱗);
			Are.Draw(this.X0Y0_尾16_鱗左);
			Are.Draw(this.X0Y0_尾16_鱗右);
			Are.Draw(this.X0Y0_尾16_尾);
			Are.Draw(this.X0Y0_尾17_鱗);
			Are.Draw(this.X0Y0_尾17_鱗左);
			Are.Draw(this.X0Y0_尾17_鱗右);
			Are.Draw(this.X0Y0_尾17_尾);
			Are.Draw(this.X0Y0_尾18_鱗);
			Are.Draw(this.X0Y0_尾18_鱗左);
			Are.Draw(this.X0Y0_尾18_鱗右);
			Are.Draw(this.X0Y0_尾18_尾);
			Are.Draw(this.X0Y0_尾19_鱗);
			Are.Draw(this.X0Y0_尾19_鱗左);
			Are.Draw(this.X0Y0_尾19_鱗右);
			Are.Draw(this.X0Y0_尾19_尾);
			Are.Draw(this.X0Y0_尾20_鱗);
			Are.Draw(this.X0Y0_尾20_鱗左);
			Are.Draw(this.X0Y0_尾20_鱗右);
			Are.Draw(this.X0Y0_尾20_尾);
			Are.Draw(this.X0Y0_尾21_鱗);
			Are.Draw(this.X0Y0_尾21_鱗左);
			Are.Draw(this.X0Y0_尾21_鱗右);
			Are.Draw(this.X0Y0_尾21_尾);
			Are.Draw(this.X0Y0_尾22_鱗);
			Are.Draw(this.X0Y0_尾22_鱗左);
			Are.Draw(this.X0Y0_尾22_鱗右);
			Are.Draw(this.X0Y0_尾22_尾);
			Are.Draw(this.X0Y0_尾23_鱗);
			Are.Draw(this.X0Y0_尾23_鱗左);
			Are.Draw(this.X0Y0_尾23_鱗右);
			Are.Draw(this.X0Y0_尾23_尾);
			Are.Draw(this.X0Y0_尾24_鱗);
			Are.Draw(this.X0Y0_尾24_鱗左);
			Are.Draw(this.X0Y0_尾24_鱗右);
			Are.Draw(this.X0Y0_尾24_尾);
			Are.Draw(this.X0Y0_尾25_鱗);
			Are.Draw(this.X0Y0_尾25_鱗左);
			Are.Draw(this.X0Y0_尾25_鱗右);
			Are.Draw(this.X0Y0_尾25_尾);
			Are.Draw(this.X0Y0_尾26_鱗);
			Are.Draw(this.X0Y0_尾26_鱗左);
			Are.Draw(this.X0Y0_尾26_鱗右);
			Are.Draw(this.X0Y0_尾26_尾);
			Are.Draw(this.X0Y0_輪1_革);
			Are.Draw(this.X0Y0_輪1_金具1);
			Are.Draw(this.X0Y0_輪1_金具2);
			Are.Draw(this.X0Y0_輪1_金具3);
			Are.Draw(this.X0Y0_輪1_金具左);
			Are.Draw(this.X0Y0_輪1_金具右);
			this.鎖1.描画0(Are);
			this.鎖2.描画0(Are);
			Are.Draw(this.X0Y0_尾27_鱗);
			Are.Draw(this.X0Y0_尾27_鱗左);
			Are.Draw(this.X0Y0_尾27_鱗右);
			Are.Draw(this.X0Y0_尾27_尾);
			Are.Draw(this.X0Y0_尾28_鱗);
			Are.Draw(this.X0Y0_尾28_鱗左);
			Are.Draw(this.X0Y0_尾28_鱗右);
			Are.Draw(this.X0Y0_尾28_尾);
			Are.Draw(this.X0Y0_尾29_鱗);
			Are.Draw(this.X0Y0_尾29_鱗左);
			Are.Draw(this.X0Y0_尾29_鱗右);
			Are.Draw(this.X0Y0_尾29_尾);
			Are.Draw(this.X0Y0_尾30_鱗);
			Are.Draw(this.X0Y0_尾30_鱗左);
			Are.Draw(this.X0Y0_尾30_鱗右);
			Are.Draw(this.X0Y0_尾30_尾);
			Are.Draw(this.X0Y0_尾31_鱗);
			Are.Draw(this.X0Y0_尾31_鱗左);
			Are.Draw(this.X0Y0_尾31_鱗右);
			Are.Draw(this.X0Y0_尾31_尾);
			Are.Draw(this.X0Y0_尾32_鱗);
			Are.Draw(this.X0Y0_尾32_鱗左);
			Are.Draw(this.X0Y0_尾32_鱗右);
			Are.Draw(this.X0Y0_尾32_尾);
			Are.Draw(this.X0Y0_尾33_鱗);
			Are.Draw(this.X0Y0_尾33_鱗左);
			Are.Draw(this.X0Y0_尾33_鱗右);
			Are.Draw(this.X0Y0_尾33_尾);
			Are.Draw(this.X0Y0_尾34_鱗);
			Are.Draw(this.X0Y0_尾34_鱗左);
			Are.Draw(this.X0Y0_尾34_鱗右);
			Are.Draw(this.X0Y0_尾34_尾);
			Are.Draw(this.X0Y0_尾35_鱗);
			Are.Draw(this.X0Y0_尾35_鱗左);
			Are.Draw(this.X0Y0_尾35_鱗右);
			Are.Draw(this.X0Y0_尾35_尾);
			Are.Draw(this.X0Y0_尾36_鱗);
			Are.Draw(this.X0Y0_尾36_鱗左);
			Are.Draw(this.X0Y0_尾36_鱗右);
			Are.Draw(this.X0Y0_尾36_尾);
			Are.Draw(this.X0Y0_尾37_鱗);
			Are.Draw(this.X0Y0_尾37_鱗左);
			Are.Draw(this.X0Y0_尾37_鱗右);
			Are.Draw(this.X0Y0_尾37_尾);
			Are.Draw(this.X0Y0_尾38_鱗);
			Are.Draw(this.X0Y0_尾38_鱗左);
			Are.Draw(this.X0Y0_尾38_鱗右);
			Are.Draw(this.X0Y0_尾38_尾);
			Are.Draw(this.X0Y0_尾39_鱗);
			Are.Draw(this.X0Y0_尾39_鱗左);
			Are.Draw(this.X0Y0_尾39_鱗右);
			Are.Draw(this.X0Y0_尾39_尾);
			Are.Draw(this.X0Y0_尾40_鱗);
			Are.Draw(this.X0Y0_尾40_鱗左);
			Are.Draw(this.X0Y0_尾40_鱗右);
			Are.Draw(this.X0Y0_尾40_尾);
			Are.Draw(this.X0Y0_尾41_鱗);
			Are.Draw(this.X0Y0_尾41_鱗左);
			Are.Draw(this.X0Y0_尾41_鱗右);
			Are.Draw(this.X0Y0_尾41_尾);
			Are.Draw(this.X0Y0_尾42_鱗);
			Are.Draw(this.X0Y0_尾42_鱗左);
			Are.Draw(this.X0Y0_尾42_鱗右);
			Are.Draw(this.X0Y0_尾42_尾);
			Are.Draw(this.X0Y0_尾43_鱗);
			Are.Draw(this.X0Y0_尾43_鱗左);
			Are.Draw(this.X0Y0_尾43_鱗右);
			Are.Draw(this.X0Y0_尾43_尾);
			Are.Draw(this.X0Y0_尾44_鱗);
			Are.Draw(this.X0Y0_尾44_鱗左);
			Are.Draw(this.X0Y0_尾44_鱗右);
			Are.Draw(this.X0Y0_尾44_尾);
			Are.Draw(this.X0Y0_頭_上顎_顎基);
			Are.Draw(this.X0Y0_頭_上顎_鱗4);
			Are.Draw(this.X0Y0_頭_上顎_鱗左1);
			Are.Draw(this.X0Y0_頭_上顎_鱗右1);
			Are.Draw(this.X0Y0_頭_上顎_鱗左2);
			Are.Draw(this.X0Y0_頭_上顎_鱗右2);
			Are.Draw(this.X0Y0_頭_上顎_鱗左3);
			Are.Draw(this.X0Y0_頭_上顎_鱗右3);
			Are.Draw(this.X0Y0_頭_上顎_鱗左4);
			Are.Draw(this.X0Y0_頭_上顎_鱗右4);
			Are.Draw(this.X0Y0_頭_上顎_鱗左5);
			Are.Draw(this.X0Y0_頭_上顎_鱗右5);
			Are.Draw(this.X0Y0_頭_上顎_鱗左8);
			Are.Draw(this.X0Y0_頭_上顎_鱗右8);
			Are.Draw(this.X0Y0_頭_上顎_鱗左9);
			Are.Draw(this.X0Y0_頭_上顎_鱗右9);
			Are.Draw(this.X0Y0_頭_上顎_鱗左10);
			Are.Draw(this.X0Y0_頭_上顎_鱗右10);
			Are.Draw(this.X0Y0_頭_上顎_鱗左11);
			Are.Draw(this.X0Y0_頭_上顎_鱗右11);
			Are.Draw(this.X0Y0_頭_下顎_顎基);
			Are.Draw(this.X0Y0_頭_下顎_鱗1);
			Are.Draw(this.X0Y0_頭_下顎_鱗2);
			Are.Draw(this.X0Y0_頭_下顎_鱗3);
			Are.Draw(this.X0Y0_頭_下顎_鱗4);
			Are.Draw(this.X0Y0_頭_下顎_鱗左1);
			Are.Draw(this.X0Y0_頭_下顎_鱗右1);
			Are.Draw(this.X0Y0_頭_下顎_鱗左2);
			Are.Draw(this.X0Y0_頭_下顎_鱗右2);
			Are.Draw(this.X0Y0_頭_下顎_鱗左3);
			Are.Draw(this.X0Y0_頭_下顎_鱗右3);
			Are.Draw(this.X0Y0_頭_下顎_鱗左4);
			Are.Draw(this.X0Y0_頭_下顎_鱗右4);
			Are.Draw(this.X0Y0_頭_下顎_鱗左5);
			Are.Draw(this.X0Y0_頭_下顎_鱗右5);
			Are.Draw(this.X0Y0_頭_下顎_鱗左6);
			Are.Draw(this.X0Y0_頭_下顎_鱗右6);
			Are.Draw(this.X0Y0_頭_下顎_鱗左7);
			Are.Draw(this.X0Y0_頭_下顎_鱗右7);
			Are.Draw(this.X0Y0_頭_下顎_鱗左8);
			Are.Draw(this.X0Y0_頭_下顎_鱗右8);
			Are.Draw(this.X0Y0_頭_下顎_鱗左9);
			Are.Draw(this.X0Y0_頭_下顎_鱗右9);
			Are.Draw(this.X0Y0_頭_下顎_鱗左10);
			Are.Draw(this.X0Y0_頭_下顎_鱗右10);
			Are.Draw(this.X0Y0_頭_下顎_鱗左11);
			Are.Draw(this.X0Y0_頭_下顎_鱗右11);
			Are.Draw(this.X0Y0_輪2_革);
			Are.Draw(this.X0Y0_輪2_金具1);
			Are.Draw(this.X0Y0_輪2_金具2);
			Are.Draw(this.X0Y0_輪2_金具3);
			Are.Draw(this.X0Y0_輪2_金具左);
			Are.Draw(this.X0Y0_輪2_金具右);
			this.鎖3.描画0(Are);
			this.鎖4.描画0(Are);
		}

		public override void Dispose()
		{
			base.Dispose();
			this.鎖1.Dispose();
			this.鎖2.Dispose();
			this.鎖3.Dispose();
			this.鎖4.Dispose();
		}

		public override double 濃度
		{
			get
			{
				return this.尾1_根CD.不透明度;
			}
			set
			{
				this.尾1_根CD.不透明度 = value;
				this.尾1_鱗CD.不透明度 = value;
				this.尾1_鱗左CD.不透明度 = value;
				this.尾1_鱗右CD.不透明度 = value;
				this.尾1_尾CD.不透明度 = value;
				this.尾2_鱗CD.不透明度 = value;
				this.尾2_鱗左CD.不透明度 = value;
				this.尾2_鱗右CD.不透明度 = value;
				this.尾2_尾CD.不透明度 = value;
				this.尾3_鱗CD.不透明度 = value;
				this.尾3_鱗左CD.不透明度 = value;
				this.尾3_鱗右CD.不透明度 = value;
				this.尾3_尾CD.不透明度 = value;
				this.尾4_鱗CD.不透明度 = value;
				this.尾4_鱗左CD.不透明度 = value;
				this.尾4_鱗右CD.不透明度 = value;
				this.尾4_尾CD.不透明度 = value;
				this.尾5_鱗CD.不透明度 = value;
				this.尾5_鱗左CD.不透明度 = value;
				this.尾5_鱗右CD.不透明度 = value;
				this.尾5_尾CD.不透明度 = value;
				this.尾6_鱗CD.不透明度 = value;
				this.尾6_鱗左CD.不透明度 = value;
				this.尾6_鱗右CD.不透明度 = value;
				this.尾6_尾CD.不透明度 = value;
				this.尾7_鱗CD.不透明度 = value;
				this.尾7_鱗左CD.不透明度 = value;
				this.尾7_鱗右CD.不透明度 = value;
				this.尾7_尾CD.不透明度 = value;
				this.尾8_鱗CD.不透明度 = value;
				this.尾8_鱗左CD.不透明度 = value;
				this.尾8_鱗右CD.不透明度 = value;
				this.尾8_尾CD.不透明度 = value;
				this.尾9_鱗CD.不透明度 = value;
				this.尾9_鱗左CD.不透明度 = value;
				this.尾9_鱗右CD.不透明度 = value;
				this.尾9_尾CD.不透明度 = value;
				this.尾10_鱗CD.不透明度 = value;
				this.尾10_鱗左CD.不透明度 = value;
				this.尾10_鱗右CD.不透明度 = value;
				this.尾10_尾CD.不透明度 = value;
				this.尾11_鱗CD.不透明度 = value;
				this.尾11_鱗左CD.不透明度 = value;
				this.尾11_鱗右CD.不透明度 = value;
				this.尾11_尾CD.不透明度 = value;
				this.尾12_鱗CD.不透明度 = value;
				this.尾12_鱗左CD.不透明度 = value;
				this.尾12_鱗右CD.不透明度 = value;
				this.尾12_尾CD.不透明度 = value;
				this.尾13_鱗CD.不透明度 = value;
				this.尾13_鱗左CD.不透明度 = value;
				this.尾13_鱗右CD.不透明度 = value;
				this.尾13_尾CD.不透明度 = value;
				this.尾14_鱗CD.不透明度 = value;
				this.尾14_鱗左CD.不透明度 = value;
				this.尾14_鱗右CD.不透明度 = value;
				this.尾14_尾CD.不透明度 = value;
				this.尾15_鱗CD.不透明度 = value;
				this.尾15_鱗左CD.不透明度 = value;
				this.尾15_鱗右CD.不透明度 = value;
				this.尾15_尾CD.不透明度 = value;
				this.尾16_鱗CD.不透明度 = value;
				this.尾16_鱗左CD.不透明度 = value;
				this.尾16_鱗右CD.不透明度 = value;
				this.尾16_尾CD.不透明度 = value;
				this.尾17_鱗CD.不透明度 = value;
				this.尾17_鱗左CD.不透明度 = value;
				this.尾17_鱗右CD.不透明度 = value;
				this.尾17_尾CD.不透明度 = value;
				this.尾18_鱗CD.不透明度 = value;
				this.尾18_鱗左CD.不透明度 = value;
				this.尾18_鱗右CD.不透明度 = value;
				this.尾18_尾CD.不透明度 = value;
				this.尾19_鱗CD.不透明度 = value;
				this.尾19_鱗左CD.不透明度 = value;
				this.尾19_鱗右CD.不透明度 = value;
				this.尾19_尾CD.不透明度 = value;
				this.尾20_鱗CD.不透明度 = value;
				this.尾20_鱗左CD.不透明度 = value;
				this.尾20_鱗右CD.不透明度 = value;
				this.尾20_尾CD.不透明度 = value;
				this.尾21_鱗CD.不透明度 = value;
				this.尾21_鱗左CD.不透明度 = value;
				this.尾21_鱗右CD.不透明度 = value;
				this.尾21_尾CD.不透明度 = value;
				this.尾22_鱗CD.不透明度 = value;
				this.尾22_鱗左CD.不透明度 = value;
				this.尾22_鱗右CD.不透明度 = value;
				this.尾22_尾CD.不透明度 = value;
				this.尾23_鱗CD.不透明度 = value;
				this.尾23_鱗左CD.不透明度 = value;
				this.尾23_鱗右CD.不透明度 = value;
				this.尾23_尾CD.不透明度 = value;
				this.尾24_鱗CD.不透明度 = value;
				this.尾24_鱗左CD.不透明度 = value;
				this.尾24_鱗右CD.不透明度 = value;
				this.尾24_尾CD.不透明度 = value;
				this.尾25_鱗CD.不透明度 = value;
				this.尾25_鱗左CD.不透明度 = value;
				this.尾25_鱗右CD.不透明度 = value;
				this.尾25_尾CD.不透明度 = value;
				this.尾26_鱗CD.不透明度 = value;
				this.尾26_鱗左CD.不透明度 = value;
				this.尾26_鱗右CD.不透明度 = value;
				this.尾26_尾CD.不透明度 = value;
				this.尾27_鱗CD.不透明度 = value;
				this.尾27_鱗左CD.不透明度 = value;
				this.尾27_鱗右CD.不透明度 = value;
				this.尾27_尾CD.不透明度 = value;
				this.尾28_鱗CD.不透明度 = value;
				this.尾28_鱗左CD.不透明度 = value;
				this.尾28_鱗右CD.不透明度 = value;
				this.尾28_尾CD.不透明度 = value;
				this.尾29_鱗CD.不透明度 = value;
				this.尾29_鱗左CD.不透明度 = value;
				this.尾29_鱗右CD.不透明度 = value;
				this.尾29_尾CD.不透明度 = value;
				this.尾30_鱗CD.不透明度 = value;
				this.尾30_鱗左CD.不透明度 = value;
				this.尾30_鱗右CD.不透明度 = value;
				this.尾30_尾CD.不透明度 = value;
				this.尾31_鱗CD.不透明度 = value;
				this.尾31_鱗左CD.不透明度 = value;
				this.尾31_鱗右CD.不透明度 = value;
				this.尾31_尾CD.不透明度 = value;
				this.尾32_鱗CD.不透明度 = value;
				this.尾32_鱗左CD.不透明度 = value;
				this.尾32_鱗右CD.不透明度 = value;
				this.尾32_尾CD.不透明度 = value;
				this.尾33_鱗CD.不透明度 = value;
				this.尾33_鱗左CD.不透明度 = value;
				this.尾33_鱗右CD.不透明度 = value;
				this.尾33_尾CD.不透明度 = value;
				this.尾34_鱗CD.不透明度 = value;
				this.尾34_鱗左CD.不透明度 = value;
				this.尾34_鱗右CD.不透明度 = value;
				this.尾34_尾CD.不透明度 = value;
				this.尾35_鱗CD.不透明度 = value;
				this.尾35_鱗左CD.不透明度 = value;
				this.尾35_鱗右CD.不透明度 = value;
				this.尾35_尾CD.不透明度 = value;
				this.尾36_鱗CD.不透明度 = value;
				this.尾36_鱗左CD.不透明度 = value;
				this.尾36_鱗右CD.不透明度 = value;
				this.尾36_尾CD.不透明度 = value;
				this.尾37_鱗CD.不透明度 = value;
				this.尾37_鱗左CD.不透明度 = value;
				this.尾37_鱗右CD.不透明度 = value;
				this.尾37_尾CD.不透明度 = value;
				this.尾38_鱗CD.不透明度 = value;
				this.尾38_鱗左CD.不透明度 = value;
				this.尾38_鱗右CD.不透明度 = value;
				this.尾38_尾CD.不透明度 = value;
				this.尾39_鱗CD.不透明度 = value;
				this.尾39_鱗左CD.不透明度 = value;
				this.尾39_鱗右CD.不透明度 = value;
				this.尾39_尾CD.不透明度 = value;
				this.尾40_鱗CD.不透明度 = value;
				this.尾40_鱗左CD.不透明度 = value;
				this.尾40_鱗右CD.不透明度 = value;
				this.尾40_尾CD.不透明度 = value;
				this.尾41_鱗CD.不透明度 = value;
				this.尾41_鱗左CD.不透明度 = value;
				this.尾41_鱗右CD.不透明度 = value;
				this.尾41_尾CD.不透明度 = value;
				this.尾42_鱗CD.不透明度 = value;
				this.尾42_鱗左CD.不透明度 = value;
				this.尾42_鱗右CD.不透明度 = value;
				this.尾42_尾CD.不透明度 = value;
				this.尾43_鱗CD.不透明度 = value;
				this.尾43_鱗左CD.不透明度 = value;
				this.尾43_鱗右CD.不透明度 = value;
				this.尾43_尾CD.不透明度 = value;
				this.尾44_鱗CD.不透明度 = value;
				this.尾44_鱗左CD.不透明度 = value;
				this.尾44_鱗右CD.不透明度 = value;
				this.尾44_尾CD.不透明度 = value;
				this.頭_上顎_顎基CD.不透明度 = value;
				this.頭_上顎_鱗4CD.不透明度 = value;
				this.頭_上顎_鱗左1CD.不透明度 = value;
				this.頭_上顎_鱗右1CD.不透明度 = value;
				this.頭_上顎_鱗左2CD.不透明度 = value;
				this.頭_上顎_鱗右2CD.不透明度 = value;
				this.頭_上顎_鱗左3CD.不透明度 = value;
				this.頭_上顎_鱗右3CD.不透明度 = value;
				this.頭_上顎_鱗左4CD.不透明度 = value;
				this.頭_上顎_鱗右4CD.不透明度 = value;
				this.頭_上顎_鱗左5CD.不透明度 = value;
				this.頭_上顎_鱗右5CD.不透明度 = value;
				this.頭_上顎_鱗左8CD.不透明度 = value;
				this.頭_上顎_鱗右8CD.不透明度 = value;
				this.頭_上顎_鱗左9CD.不透明度 = value;
				this.頭_上顎_鱗右9CD.不透明度 = value;
				this.頭_上顎_鱗左10CD.不透明度 = value;
				this.頭_上顎_鱗右10CD.不透明度 = value;
				this.頭_上顎_鱗左11CD.不透明度 = value;
				this.頭_上顎_鱗右11CD.不透明度 = value;
				this.頭_下顎_顎基CD.不透明度 = value;
				this.頭_下顎_鱗1CD.不透明度 = value;
				this.頭_下顎_鱗2CD.不透明度 = value;
				this.頭_下顎_鱗3CD.不透明度 = value;
				this.頭_下顎_鱗4CD.不透明度 = value;
				this.頭_下顎_鱗左1CD.不透明度 = value;
				this.頭_下顎_鱗右1CD.不透明度 = value;
				this.頭_下顎_鱗左2CD.不透明度 = value;
				this.頭_下顎_鱗右2CD.不透明度 = value;
				this.頭_下顎_鱗左3CD.不透明度 = value;
				this.頭_下顎_鱗右3CD.不透明度 = value;
				this.頭_下顎_鱗左4CD.不透明度 = value;
				this.頭_下顎_鱗右4CD.不透明度 = value;
				this.頭_下顎_鱗左5CD.不透明度 = value;
				this.頭_下顎_鱗右5CD.不透明度 = value;
				this.頭_下顎_鱗左6CD.不透明度 = value;
				this.頭_下顎_鱗右6CD.不透明度 = value;
				this.頭_下顎_鱗左7CD.不透明度 = value;
				this.頭_下顎_鱗右7CD.不透明度 = value;
				this.頭_下顎_鱗左8CD.不透明度 = value;
				this.頭_下顎_鱗右8CD.不透明度 = value;
				this.頭_下顎_鱗左9CD.不透明度 = value;
				this.頭_下顎_鱗右9CD.不透明度 = value;
				this.頭_下顎_鱗左10CD.不透明度 = value;
				this.頭_下顎_鱗右10CD.不透明度 = value;
				this.頭_下顎_鱗左11CD.不透明度 = value;
				this.頭_下顎_鱗右11CD.不透明度 = value;
				this.輪1_革CD.不透明度 = value;
				this.輪1_金具1CD.不透明度 = value;
				this.輪1_金具2CD.不透明度 = value;
				this.輪1_金具3CD.不透明度 = value;
				this.輪1_金具左CD.不透明度 = value;
				this.輪1_金具右CD.不透明度 = value;
				this.輪2_革CD.不透明度 = value;
				this.輪2_金具1CD.不透明度 = value;
				this.輪2_金具2CD.不透明度 = value;
				this.輪2_金具3CD.不透明度 = value;
				this.輪2_金具左CD.不透明度 = value;
				this.輪2_金具右CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			bool 右 = this.右;
			double maxAngle = 20.0;
			this.X0Y0_尾1_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾2_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾3_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾4_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾5_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾6_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾7_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾8_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾9_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾10_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾11_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾12_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾13_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾14_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾15_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾16_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾17_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾18_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾19_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾20_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾21_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾22_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾23_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾24_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾25_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾26_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾27_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾28_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾29_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾30_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾31_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾32_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾33_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾34_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾35_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾36_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾37_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾38_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾39_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾40_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾41_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾42_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾43_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾44_尾.AngleBase = maxAngle.GetRanAngle();
			this.本体.JoinPAall();
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_輪1_革 || p == this.X0Y0_輪1_金具1 || p == this.X0Y0_輪1_金具2 || p == this.X0Y0_輪1_金具3 || p == this.X0Y0_輪1_金具左 || p == this.X0Y0_輪1_金具右 || p == this.X0Y0_輪2_革 || p == this.X0Y0_輪2_金具1 || p == this.X0Y0_輪2_金具2 || p == this.X0Y0_輪2_金具3 || p == this.X0Y0_輪2_金具左 || p == this.X0Y0_輪2_金具右;
		}

		public override IEnumerable<Par> Enum軸()
		{
			yield return this.X0Y0_尾1_尾;
			yield return this.X0Y0_尾2_尾;
			yield return this.X0Y0_尾3_尾;
			yield return this.X0Y0_尾4_尾;
			yield return this.X0Y0_尾5_尾;
			yield return this.X0Y0_尾6_尾;
			yield return this.X0Y0_尾7_尾;
			yield return this.X0Y0_尾8_尾;
			yield return this.X0Y0_尾9_尾;
			yield return this.X0Y0_尾10_尾;
			yield return this.X0Y0_尾11_尾;
			yield return this.X0Y0_尾12_尾;
			yield return this.X0Y0_尾13_尾;
			yield return this.X0Y0_尾14_尾;
			yield return this.X0Y0_尾15_尾;
			yield return this.X0Y0_尾16_尾;
			yield return this.X0Y0_尾17_尾;
			yield return this.X0Y0_尾18_尾;
			yield return this.X0Y0_尾19_尾;
			yield return this.X0Y0_尾20_尾;
			yield return this.X0Y0_尾21_尾;
			yield return this.X0Y0_尾22_尾;
			yield return this.X0Y0_尾23_尾;
			yield return this.X0Y0_尾24_尾;
			yield return this.X0Y0_尾25_尾;
			yield return this.X0Y0_尾26_尾;
			yield return this.X0Y0_尾27_尾;
			yield return this.X0Y0_尾28_尾;
			yield return this.X0Y0_尾29_尾;
			yield return this.X0Y0_尾30_尾;
			yield return this.X0Y0_尾31_尾;
			yield return this.X0Y0_尾32_尾;
			yield return this.X0Y0_尾33_尾;
			yield return this.X0Y0_尾34_尾;
			yield return this.X0Y0_尾35_尾;
			yield return this.X0Y0_尾36_尾;
			yield return this.X0Y0_尾37_尾;
			yield return this.X0Y0_尾38_尾;
			yield return this.X0Y0_尾39_尾;
			yield return this.X0Y0_尾40_尾;
			yield return this.X0Y0_尾41_尾;
			yield return this.X0Y0_尾42_尾;
			yield return this.X0Y0_尾43_尾;
			yield return this.X0Y0_尾44_尾;
			yield break;
		}

		public JointS 鎖1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_輪1_金具左, 0);
			}
		}

		public JointS 鎖2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_輪1_金具右, 0);
			}
		}

		public JointS 鎖3_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_輪2_金具左, 0);
			}
		}

		public JointS 鎖4_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_輪2_金具右, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_尾1_根CP.Update();
			this.X0Y0_尾1_鱗CP.Update();
			this.X0Y0_尾1_鱗左CP.Update();
			this.X0Y0_尾1_鱗右CP.Update();
			this.X0Y0_尾1_尾CP.Update();
			this.X0Y0_尾2_鱗CP.Update();
			this.X0Y0_尾2_鱗左CP.Update();
			this.X0Y0_尾2_鱗右CP.Update();
			this.X0Y0_尾2_尾CP.Update();
			this.X0Y0_尾3_鱗CP.Update();
			this.X0Y0_尾3_鱗左CP.Update();
			this.X0Y0_尾3_鱗右CP.Update();
			this.X0Y0_尾3_尾CP.Update();
			this.X0Y0_尾4_鱗CP.Update();
			this.X0Y0_尾4_鱗左CP.Update();
			this.X0Y0_尾4_鱗右CP.Update();
			this.X0Y0_尾4_尾CP.Update();
			this.X0Y0_尾5_鱗CP.Update();
			this.X0Y0_尾5_鱗左CP.Update();
			this.X0Y0_尾5_鱗右CP.Update();
			this.X0Y0_尾5_尾CP.Update();
			this.X0Y0_尾6_鱗CP.Update();
			this.X0Y0_尾6_鱗左CP.Update();
			this.X0Y0_尾6_鱗右CP.Update();
			this.X0Y0_尾6_尾CP.Update();
			this.X0Y0_尾7_鱗CP.Update();
			this.X0Y0_尾7_鱗左CP.Update();
			this.X0Y0_尾7_鱗右CP.Update();
			this.X0Y0_尾7_尾CP.Update();
			this.X0Y0_尾8_鱗CP.Update();
			this.X0Y0_尾8_鱗左CP.Update();
			this.X0Y0_尾8_鱗右CP.Update();
			this.X0Y0_尾8_尾CP.Update();
			this.X0Y0_尾9_鱗CP.Update();
			this.X0Y0_尾9_鱗左CP.Update();
			this.X0Y0_尾9_鱗右CP.Update();
			this.X0Y0_尾9_尾CP.Update();
			this.X0Y0_尾10_鱗CP.Update();
			this.X0Y0_尾10_鱗左CP.Update();
			this.X0Y0_尾10_鱗右CP.Update();
			this.X0Y0_尾10_尾CP.Update();
			this.X0Y0_尾11_鱗CP.Update();
			this.X0Y0_尾11_鱗左CP.Update();
			this.X0Y0_尾11_鱗右CP.Update();
			this.X0Y0_尾11_尾CP.Update();
			this.X0Y0_尾12_鱗CP.Update();
			this.X0Y0_尾12_鱗左CP.Update();
			this.X0Y0_尾12_鱗右CP.Update();
			this.X0Y0_尾12_尾CP.Update();
			this.X0Y0_尾13_鱗CP.Update();
			this.X0Y0_尾13_鱗左CP.Update();
			this.X0Y0_尾13_鱗右CP.Update();
			this.X0Y0_尾13_尾CP.Update();
			this.X0Y0_尾14_鱗CP.Update();
			this.X0Y0_尾14_鱗左CP.Update();
			this.X0Y0_尾14_鱗右CP.Update();
			this.X0Y0_尾14_尾CP.Update();
			this.X0Y0_尾15_鱗CP.Update();
			this.X0Y0_尾15_鱗左CP.Update();
			this.X0Y0_尾15_鱗右CP.Update();
			this.X0Y0_尾15_尾CP.Update();
			this.X0Y0_尾16_鱗CP.Update();
			this.X0Y0_尾16_鱗左CP.Update();
			this.X0Y0_尾16_鱗右CP.Update();
			this.X0Y0_尾16_尾CP.Update();
			this.X0Y0_尾17_鱗CP.Update();
			this.X0Y0_尾17_鱗左CP.Update();
			this.X0Y0_尾17_鱗右CP.Update();
			this.X0Y0_尾17_尾CP.Update();
			this.X0Y0_尾18_鱗CP.Update();
			this.X0Y0_尾18_鱗左CP.Update();
			this.X0Y0_尾18_鱗右CP.Update();
			this.X0Y0_尾18_尾CP.Update();
			this.X0Y0_尾19_鱗CP.Update();
			this.X0Y0_尾19_鱗左CP.Update();
			this.X0Y0_尾19_鱗右CP.Update();
			this.X0Y0_尾19_尾CP.Update();
			this.X0Y0_尾20_鱗CP.Update();
			this.X0Y0_尾20_鱗左CP.Update();
			this.X0Y0_尾20_鱗右CP.Update();
			this.X0Y0_尾20_尾CP.Update();
			this.X0Y0_尾21_鱗CP.Update();
			this.X0Y0_尾21_鱗左CP.Update();
			this.X0Y0_尾21_鱗右CP.Update();
			this.X0Y0_尾21_尾CP.Update();
			this.X0Y0_尾22_鱗CP.Update();
			this.X0Y0_尾22_鱗左CP.Update();
			this.X0Y0_尾22_鱗右CP.Update();
			this.X0Y0_尾22_尾CP.Update();
			this.X0Y0_尾23_鱗CP.Update();
			this.X0Y0_尾23_鱗左CP.Update();
			this.X0Y0_尾23_鱗右CP.Update();
			this.X0Y0_尾23_尾CP.Update();
			this.X0Y0_尾24_鱗CP.Update();
			this.X0Y0_尾24_鱗左CP.Update();
			this.X0Y0_尾24_鱗右CP.Update();
			this.X0Y0_尾24_尾CP.Update();
			this.X0Y0_尾25_鱗CP.Update();
			this.X0Y0_尾25_鱗左CP.Update();
			this.X0Y0_尾25_鱗右CP.Update();
			this.X0Y0_尾25_尾CP.Update();
			this.X0Y0_尾26_鱗CP.Update();
			this.X0Y0_尾26_鱗左CP.Update();
			this.X0Y0_尾26_鱗右CP.Update();
			this.X0Y0_尾26_尾CP.Update();
			this.X0Y0_輪1_革CP.Update();
			this.X0Y0_輪1_金具1CP.Update();
			this.X0Y0_輪1_金具2CP.Update();
			this.X0Y0_輪1_金具3CP.Update();
			this.X0Y0_輪1_金具左CP.Update();
			this.X0Y0_輪1_金具右CP.Update();
			this.X0Y0_尾27_鱗CP.Update();
			this.X0Y0_尾27_鱗左CP.Update();
			this.X0Y0_尾27_鱗右CP.Update();
			this.X0Y0_尾27_尾CP.Update();
			this.X0Y0_尾28_鱗CP.Update();
			this.X0Y0_尾28_鱗左CP.Update();
			this.X0Y0_尾28_鱗右CP.Update();
			this.X0Y0_尾28_尾CP.Update();
			this.X0Y0_尾29_鱗CP.Update();
			this.X0Y0_尾29_鱗左CP.Update();
			this.X0Y0_尾29_鱗右CP.Update();
			this.X0Y0_尾29_尾CP.Update();
			this.X0Y0_尾30_鱗CP.Update();
			this.X0Y0_尾30_鱗左CP.Update();
			this.X0Y0_尾30_鱗右CP.Update();
			this.X0Y0_尾30_尾CP.Update();
			this.X0Y0_尾31_鱗CP.Update();
			this.X0Y0_尾31_鱗左CP.Update();
			this.X0Y0_尾31_鱗右CP.Update();
			this.X0Y0_尾31_尾CP.Update();
			this.X0Y0_尾32_鱗CP.Update();
			this.X0Y0_尾32_鱗左CP.Update();
			this.X0Y0_尾32_鱗右CP.Update();
			this.X0Y0_尾32_尾CP.Update();
			this.X0Y0_尾33_鱗CP.Update();
			this.X0Y0_尾33_鱗左CP.Update();
			this.X0Y0_尾33_鱗右CP.Update();
			this.X0Y0_尾33_尾CP.Update();
			this.X0Y0_尾34_鱗CP.Update();
			this.X0Y0_尾34_鱗左CP.Update();
			this.X0Y0_尾34_鱗右CP.Update();
			this.X0Y0_尾34_尾CP.Update();
			this.X0Y0_尾35_鱗CP.Update();
			this.X0Y0_尾35_鱗左CP.Update();
			this.X0Y0_尾35_鱗右CP.Update();
			this.X0Y0_尾35_尾CP.Update();
			this.X0Y0_尾36_鱗CP.Update();
			this.X0Y0_尾36_鱗左CP.Update();
			this.X0Y0_尾36_鱗右CP.Update();
			this.X0Y0_尾36_尾CP.Update();
			this.X0Y0_尾37_鱗CP.Update();
			this.X0Y0_尾37_鱗左CP.Update();
			this.X0Y0_尾37_鱗右CP.Update();
			this.X0Y0_尾37_尾CP.Update();
			this.X0Y0_尾38_鱗CP.Update();
			this.X0Y0_尾38_鱗左CP.Update();
			this.X0Y0_尾38_鱗右CP.Update();
			this.X0Y0_尾38_尾CP.Update();
			this.X0Y0_尾39_鱗CP.Update();
			this.X0Y0_尾39_鱗左CP.Update();
			this.X0Y0_尾39_鱗右CP.Update();
			this.X0Y0_尾39_尾CP.Update();
			this.X0Y0_尾40_鱗CP.Update();
			this.X0Y0_尾40_鱗左CP.Update();
			this.X0Y0_尾40_鱗右CP.Update();
			this.X0Y0_尾40_尾CP.Update();
			this.X0Y0_尾41_鱗CP.Update();
			this.X0Y0_尾41_鱗左CP.Update();
			this.X0Y0_尾41_鱗右CP.Update();
			this.X0Y0_尾41_尾CP.Update();
			this.X0Y0_尾42_鱗CP.Update();
			this.X0Y0_尾42_鱗左CP.Update();
			this.X0Y0_尾42_鱗右CP.Update();
			this.X0Y0_尾42_尾CP.Update();
			this.X0Y0_尾43_鱗CP.Update();
			this.X0Y0_尾43_鱗左CP.Update();
			this.X0Y0_尾43_鱗右CP.Update();
			this.X0Y0_尾43_尾CP.Update();
			this.X0Y0_尾44_鱗CP.Update();
			this.X0Y0_尾44_鱗左CP.Update();
			this.X0Y0_尾44_鱗右CP.Update();
			this.X0Y0_尾44_尾CP.Update();
			this.X0Y0_頭_上顎_顎基CP.Update();
			this.X0Y0_頭_上顎_鱗4CP.Update();
			this.X0Y0_頭_上顎_鱗左1CP.Update();
			this.X0Y0_頭_上顎_鱗右1CP.Update();
			this.X0Y0_頭_上顎_鱗左2CP.Update();
			this.X0Y0_頭_上顎_鱗右2CP.Update();
			this.X0Y0_頭_上顎_鱗左3CP.Update();
			this.X0Y0_頭_上顎_鱗右3CP.Update();
			this.X0Y0_頭_上顎_鱗左4CP.Update();
			this.X0Y0_頭_上顎_鱗右4CP.Update();
			this.X0Y0_頭_上顎_鱗左5CP.Update();
			this.X0Y0_頭_上顎_鱗右5CP.Update();
			this.X0Y0_頭_上顎_鱗左8CP.Update();
			this.X0Y0_頭_上顎_鱗右8CP.Update();
			this.X0Y0_頭_上顎_鱗左9CP.Update();
			this.X0Y0_頭_上顎_鱗右9CP.Update();
			this.X0Y0_頭_上顎_鱗左10CP.Update();
			this.X0Y0_頭_上顎_鱗右10CP.Update();
			this.X0Y0_頭_上顎_鱗左11CP.Update();
			this.X0Y0_頭_上顎_鱗右11CP.Update();
			this.X0Y0_頭_下顎_顎基CP.Update();
			this.X0Y0_頭_下顎_鱗1CP.Update();
			this.X0Y0_頭_下顎_鱗2CP.Update();
			this.X0Y0_頭_下顎_鱗3CP.Update();
			this.X0Y0_頭_下顎_鱗4CP.Update();
			this.X0Y0_頭_下顎_鱗左1CP.Update();
			this.X0Y0_頭_下顎_鱗右1CP.Update();
			this.X0Y0_頭_下顎_鱗左2CP.Update();
			this.X0Y0_頭_下顎_鱗右2CP.Update();
			this.X0Y0_頭_下顎_鱗左3CP.Update();
			this.X0Y0_頭_下顎_鱗右3CP.Update();
			this.X0Y0_頭_下顎_鱗左4CP.Update();
			this.X0Y0_頭_下顎_鱗右4CP.Update();
			this.X0Y0_頭_下顎_鱗左5CP.Update();
			this.X0Y0_頭_下顎_鱗右5CP.Update();
			this.X0Y0_頭_下顎_鱗左6CP.Update();
			this.X0Y0_頭_下顎_鱗右6CP.Update();
			this.X0Y0_頭_下顎_鱗左7CP.Update();
			this.X0Y0_頭_下顎_鱗右7CP.Update();
			this.X0Y0_頭_下顎_鱗左8CP.Update();
			this.X0Y0_頭_下顎_鱗右8CP.Update();
			this.X0Y0_頭_下顎_鱗左9CP.Update();
			this.X0Y0_頭_下顎_鱗右9CP.Update();
			this.X0Y0_頭_下顎_鱗左10CP.Update();
			this.X0Y0_頭_下顎_鱗右10CP.Update();
			this.X0Y0_頭_下顎_鱗左11CP.Update();
			this.X0Y0_頭_下顎_鱗右11CP.Update();
			this.X0Y0_輪2_革CP.Update();
			this.X0Y0_輪2_金具1CP.Update();
			this.X0Y0_輪2_金具2CP.Update();
			this.X0Y0_輪2_金具3CP.Update();
			this.X0Y0_輪2_金具左CP.Update();
			this.X0Y0_輪2_金具右CP.Update();
			this.鎖1.接続PA();
			this.鎖2.接続PA();
			this.鎖3.接続PA();
			this.鎖4.接続PA();
			this.鎖1.色更新();
			this.鎖2.色更新();
			this.鎖3.色更新();
			this.鎖4.色更新();
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
			this.尾1_根CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾1_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾1_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾1_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾1_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾2_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾2_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾2_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾2_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾3_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾3_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾3_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾3_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾4_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾4_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾4_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾4_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾5_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾5_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾5_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾5_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾6_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾6_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾6_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾6_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾7_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾7_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾7_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾7_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾8_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾8_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾8_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾8_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾9_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾9_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾9_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾9_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾10_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾10_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾10_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾10_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾11_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾11_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾11_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾11_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾12_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾12_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾12_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾12_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾13_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾13_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾13_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾13_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾14_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾14_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾14_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾14_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾15_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾15_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾15_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾15_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾16_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾16_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾16_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾16_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾17_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾17_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾17_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾17_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾18_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾18_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾18_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾18_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾19_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾19_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾19_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾19_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾20_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾20_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾20_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾20_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾21_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾21_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾21_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾21_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾22_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾22_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾22_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾22_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾23_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾23_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾23_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾23_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾24_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾24_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾24_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾24_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾25_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾25_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾25_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾25_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾26_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾26_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾26_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾26_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾27_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾27_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾27_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾27_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾28_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾28_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾28_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾28_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾29_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾29_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾29_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾29_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾30_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾30_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾30_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾30_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾31_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾31_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾31_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾31_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾32_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾32_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾32_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾32_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾33_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾33_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾33_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾33_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾34_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾34_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾34_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾34_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾35_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾35_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾35_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾35_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾36_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾36_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾36_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾36_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾37_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾37_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾37_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾37_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾38_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾38_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾38_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾38_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾39_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾39_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾39_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾39_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾40_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾40_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾40_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾40_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾41_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾41_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾41_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾41_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾42_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾42_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾42_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾42_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾43_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾43_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾43_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾43_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾44_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾44_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾44_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾44_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_顎基CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗左4CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗右4CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗左5CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗右5CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗左8CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗右8CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗左9CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗右9CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗左10CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗右10CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗左11CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗右11CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_下顎_顎基CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_下顎_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_下顎_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左4CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右4CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左5CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右5CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左6CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右6CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左7CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右7CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左8CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右8CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左9CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右9CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左10CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右10CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左11CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右11CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.輪1_革CD = new ColorD();
			this.輪1_金具1CD = new ColorD();
			this.輪1_金具2CD = new ColorD();
			this.輪1_金具3CD = new ColorD();
			this.輪1_金具左CD = new ColorD();
			this.輪1_金具右CD = new ColorD();
			this.輪2_革CD = new ColorD();
			this.輪2_金具1CD = new ColorD();
			this.輪2_金具2CD = new ColorD();
			this.輪2_金具3CD = new ColorD();
			this.輪2_金具左CD = new ColorD();
			this.輪2_金具右CD = new ColorD();
		}

		private void 配色T0(体配色 体配色)
		{
			this.尾1_根CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾1_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾1_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾2_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾2_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾2_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾2_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾3_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾3_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾4_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾4_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾4_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾4_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾5_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾5_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾5_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾5_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾6_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾6_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾6_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾6_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾7_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾7_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾7_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾7_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾8_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾8_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾8_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾8_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾9_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾9_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾9_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾9_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾10_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾10_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾10_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾10_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾11_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾11_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾11_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾11_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾12_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾12_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾12_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾12_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾13_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾13_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾13_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾13_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾14_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾14_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾14_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾14_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾15_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾15_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾15_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾15_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾16_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾16_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾16_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾16_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾17_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾17_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾17_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾17_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾18_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾18_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾18_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾18_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾19_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾19_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾19_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾19_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾20_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾20_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾20_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾20_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾21_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾21_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾21_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾21_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾22_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾22_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾22_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾22_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾23_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾23_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾23_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾23_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾24_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾24_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾24_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾24_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾25_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾25_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾25_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾25_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾26_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾26_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾26_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾26_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾27_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾27_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾27_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾27_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾28_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾28_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾28_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾28_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾29_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾29_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾29_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾29_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾30_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾30_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾30_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾30_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾31_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾31_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾31_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾31_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾32_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾32_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾32_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾32_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾33_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾33_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾33_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾33_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾34_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾34_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾34_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾34_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾35_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾35_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾35_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾35_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾36_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾36_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾36_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾36_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾37_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾37_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾37_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾37_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾38_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾38_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾38_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾38_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾39_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾39_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾39_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾39_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾40_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾40_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾40_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾40_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾41_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾41_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾41_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾41_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾42_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾42_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾42_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾42_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾43_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾43_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾43_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾43_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾44_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾44_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾44_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾44_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_顎基CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗左4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_鱗右4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_鱗左5CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗右5CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗左8CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗右8CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗左9CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_鱗右9CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_鱗左10CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗右10CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗左11CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_鱗右11CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_下顎_顎基CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_下顎_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_下顎_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左4CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右4CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左5CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右5CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左6CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右6CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左7CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右7CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左8CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右8CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左9CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右9CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左10CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右10CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左11CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右11CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.輪1_革CD = new ColorD();
			this.輪1_金具1CD = new ColorD();
			this.輪1_金具2CD = new ColorD();
			this.輪1_金具3CD = new ColorD();
			this.輪1_金具左CD = new ColorD();
			this.輪1_金具右CD = new ColorD();
			this.輪2_革CD = new ColorD();
			this.輪2_金具1CD = new ColorD();
			this.輪2_金具2CD = new ColorD();
			this.輪2_金具3CD = new ColorD();
			this.輪2_金具左CD = new ColorD();
			this.輪2_金具右CD = new ColorD();
		}

		private void 配色T1(体配色 体配色)
		{
			this.尾1_根CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾1_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾1_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾1_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾1_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾2_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾2_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾3_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾3_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾3_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾3_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾4_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾4_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾5_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾5_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾5_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾5_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾6_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾6_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾6_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾6_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾7_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾7_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾7_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾7_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾8_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾8_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾8_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾8_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾9_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾9_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾9_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾9_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾10_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾10_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾10_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾10_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾11_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾11_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾11_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾11_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾12_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾12_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾12_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾12_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾13_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾13_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾13_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾13_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾14_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾14_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾14_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾14_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾15_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾15_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾15_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾15_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾16_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾16_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾16_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾16_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾17_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾17_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾17_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾17_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾18_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾18_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾18_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾18_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾19_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾19_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾19_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾19_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾20_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾20_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾20_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾20_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾21_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾21_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾21_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾21_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾22_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾22_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾22_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾22_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾23_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾23_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾23_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾23_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾24_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾24_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾24_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾24_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾25_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾25_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾25_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾25_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾26_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾26_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾26_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾26_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾27_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾27_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾27_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾27_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾28_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾28_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾28_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾28_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾29_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾29_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾29_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾29_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾30_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾30_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾30_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾30_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾31_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾31_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾31_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾31_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾32_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾32_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾32_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾32_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾33_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾33_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾33_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾33_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾34_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾34_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾34_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾34_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾35_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾35_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾35_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾35_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾36_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾36_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾36_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾36_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾37_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾37_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾37_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾37_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾38_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾38_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾38_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾38_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾39_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾39_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾39_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾39_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾40_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾40_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾40_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾40_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾41_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾41_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾41_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾41_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾42_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾42_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾42_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾42_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾43_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾43_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾43_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾43_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.尾44_鱗CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.尾44_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾44_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾44_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_顎基CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_鱗左4CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗右4CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗左5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_鱗右5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_鱗左8CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_鱗右8CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_鱗左9CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗右9CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗左10CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_鱗右10CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_鱗左11CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_上顎_鱗右11CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_下顎_顎基CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_下顎_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗0R);
			this.頭_下顎_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左4CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右4CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左5CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右5CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左6CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右6CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左7CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右7CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左8CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右8CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左9CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右9CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左10CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右10CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗左11CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.頭_下顎_鱗右11CD = new ColorD(ref Col.Black, ref 体配色.鱗1R);
			this.輪1_革CD = new ColorD();
			this.輪1_金具1CD = new ColorD();
			this.輪1_金具2CD = new ColorD();
			this.輪1_金具3CD = new ColorD();
			this.輪1_金具左CD = new ColorD();
			this.輪1_金具右CD = new ColorD();
			this.輪2_革CD = new ColorD();
			this.輪2_金具1CD = new ColorD();
			this.輪2_金具2CD = new ColorD();
			this.輪2_金具3CD = new ColorD();
			this.輪2_金具左CD = new ColorD();
			this.輪2_金具右CD = new ColorD();
		}

		public void 輪1配色(拘束具色 配色)
		{
			this.輪1_革CD.色 = 配色.革部色;
			this.輪1_金具1CD.色 = 配色.金具色;
			this.輪1_金具2CD.色 = this.輪1_金具1CD.色;
			this.輪1_金具3CD.色 = this.輪1_金具1CD.色;
			this.輪1_金具左CD.色 = this.輪1_金具1CD.色;
			this.輪1_金具右CD.色 = this.輪1_金具1CD.色;
		}

		public void 輪2配色(拘束具色 配色)
		{
			this.輪2_革CD.色 = 配色.革部色;
			this.輪2_金具1CD.色 = 配色.金具色;
			this.輪2_金具2CD.色 = this.輪2_金具1CD.色;
			this.輪2_金具3CD.色 = this.輪2_金具1CD.色;
			this.輪2_金具左CD.色 = this.輪2_金具1CD.色;
			this.輪2_金具右CD.色 = this.輪2_金具1CD.色;
		}

		public void 鎖配色(鎖色 配色)
		{
			this.鎖1.配色鎖(配色);
			this.鎖2.配色鎖(配色);
			this.鎖3.配色鎖(配色);
			this.鎖4.配色鎖(配色);
		}

		public Par X0Y0_尾1_根;

		public Par X0Y0_尾1_鱗;

		public Par X0Y0_尾1_鱗左;

		public Par X0Y0_尾1_鱗右;

		public Par X0Y0_尾1_尾;

		public Par X0Y0_尾2_鱗;

		public Par X0Y0_尾2_鱗左;

		public Par X0Y0_尾2_鱗右;

		public Par X0Y0_尾2_尾;

		public Par X0Y0_尾3_鱗;

		public Par X0Y0_尾3_鱗左;

		public Par X0Y0_尾3_鱗右;

		public Par X0Y0_尾3_尾;

		public Par X0Y0_尾4_鱗;

		public Par X0Y0_尾4_鱗左;

		public Par X0Y0_尾4_鱗右;

		public Par X0Y0_尾4_尾;

		public Par X0Y0_尾5_鱗;

		public Par X0Y0_尾5_鱗左;

		public Par X0Y0_尾5_鱗右;

		public Par X0Y0_尾5_尾;

		public Par X0Y0_尾6_鱗;

		public Par X0Y0_尾6_鱗左;

		public Par X0Y0_尾6_鱗右;

		public Par X0Y0_尾6_尾;

		public Par X0Y0_尾7_鱗;

		public Par X0Y0_尾7_鱗左;

		public Par X0Y0_尾7_鱗右;

		public Par X0Y0_尾7_尾;

		public Par X0Y0_尾8_鱗;

		public Par X0Y0_尾8_鱗左;

		public Par X0Y0_尾8_鱗右;

		public Par X0Y0_尾8_尾;

		public Par X0Y0_尾9_鱗;

		public Par X0Y0_尾9_鱗左;

		public Par X0Y0_尾9_鱗右;

		public Par X0Y0_尾9_尾;

		public Par X0Y0_尾10_鱗;

		public Par X0Y0_尾10_鱗左;

		public Par X0Y0_尾10_鱗右;

		public Par X0Y0_尾10_尾;

		public Par X0Y0_尾11_鱗;

		public Par X0Y0_尾11_鱗左;

		public Par X0Y0_尾11_鱗右;

		public Par X0Y0_尾11_尾;

		public Par X0Y0_尾12_鱗;

		public Par X0Y0_尾12_鱗左;

		public Par X0Y0_尾12_鱗右;

		public Par X0Y0_尾12_尾;

		public Par X0Y0_尾13_鱗;

		public Par X0Y0_尾13_鱗左;

		public Par X0Y0_尾13_鱗右;

		public Par X0Y0_尾13_尾;

		public Par X0Y0_尾14_鱗;

		public Par X0Y0_尾14_鱗左;

		public Par X0Y0_尾14_鱗右;

		public Par X0Y0_尾14_尾;

		public Par X0Y0_尾15_鱗;

		public Par X0Y0_尾15_鱗左;

		public Par X0Y0_尾15_鱗右;

		public Par X0Y0_尾15_尾;

		public Par X0Y0_尾16_鱗;

		public Par X0Y0_尾16_鱗左;

		public Par X0Y0_尾16_鱗右;

		public Par X0Y0_尾16_尾;

		public Par X0Y0_尾17_鱗;

		public Par X0Y0_尾17_鱗左;

		public Par X0Y0_尾17_鱗右;

		public Par X0Y0_尾17_尾;

		public Par X0Y0_尾18_鱗;

		public Par X0Y0_尾18_鱗左;

		public Par X0Y0_尾18_鱗右;

		public Par X0Y0_尾18_尾;

		public Par X0Y0_尾19_鱗;

		public Par X0Y0_尾19_鱗左;

		public Par X0Y0_尾19_鱗右;

		public Par X0Y0_尾19_尾;

		public Par X0Y0_尾20_鱗;

		public Par X0Y0_尾20_鱗左;

		public Par X0Y0_尾20_鱗右;

		public Par X0Y0_尾20_尾;

		public Par X0Y0_尾21_鱗;

		public Par X0Y0_尾21_鱗左;

		public Par X0Y0_尾21_鱗右;

		public Par X0Y0_尾21_尾;

		public Par X0Y0_尾22_鱗;

		public Par X0Y0_尾22_鱗左;

		public Par X0Y0_尾22_鱗右;

		public Par X0Y0_尾22_尾;

		public Par X0Y0_尾23_鱗;

		public Par X0Y0_尾23_鱗左;

		public Par X0Y0_尾23_鱗右;

		public Par X0Y0_尾23_尾;

		public Par X0Y0_尾24_鱗;

		public Par X0Y0_尾24_鱗左;

		public Par X0Y0_尾24_鱗右;

		public Par X0Y0_尾24_尾;

		public Par X0Y0_尾25_鱗;

		public Par X0Y0_尾25_鱗左;

		public Par X0Y0_尾25_鱗右;

		public Par X0Y0_尾25_尾;

		public Par X0Y0_尾26_鱗;

		public Par X0Y0_尾26_鱗左;

		public Par X0Y0_尾26_鱗右;

		public Par X0Y0_尾26_尾;

		public Par X0Y0_輪1_革;

		public Par X0Y0_輪1_金具1;

		public Par X0Y0_輪1_金具2;

		public Par X0Y0_輪1_金具3;

		public Par X0Y0_輪1_金具左;

		public Par X0Y0_輪1_金具右;

		public Par X0Y0_尾27_鱗;

		public Par X0Y0_尾27_鱗左;

		public Par X0Y0_尾27_鱗右;

		public Par X0Y0_尾27_尾;

		public Par X0Y0_尾28_鱗;

		public Par X0Y0_尾28_鱗左;

		public Par X0Y0_尾28_鱗右;

		public Par X0Y0_尾28_尾;

		public Par X0Y0_尾29_鱗;

		public Par X0Y0_尾29_鱗左;

		public Par X0Y0_尾29_鱗右;

		public Par X0Y0_尾29_尾;

		public Par X0Y0_尾30_鱗;

		public Par X0Y0_尾30_鱗左;

		public Par X0Y0_尾30_鱗右;

		public Par X0Y0_尾30_尾;

		public Par X0Y0_尾31_鱗;

		public Par X0Y0_尾31_鱗左;

		public Par X0Y0_尾31_鱗右;

		public Par X0Y0_尾31_尾;

		public Par X0Y0_尾32_鱗;

		public Par X0Y0_尾32_鱗左;

		public Par X0Y0_尾32_鱗右;

		public Par X0Y0_尾32_尾;

		public Par X0Y0_尾33_鱗;

		public Par X0Y0_尾33_鱗左;

		public Par X0Y0_尾33_鱗右;

		public Par X0Y0_尾33_尾;

		public Par X0Y0_尾34_鱗;

		public Par X0Y0_尾34_鱗左;

		public Par X0Y0_尾34_鱗右;

		public Par X0Y0_尾34_尾;

		public Par X0Y0_尾35_鱗;

		public Par X0Y0_尾35_鱗左;

		public Par X0Y0_尾35_鱗右;

		public Par X0Y0_尾35_尾;

		public Par X0Y0_尾36_鱗;

		public Par X0Y0_尾36_鱗左;

		public Par X0Y0_尾36_鱗右;

		public Par X0Y0_尾36_尾;

		public Par X0Y0_尾37_鱗;

		public Par X0Y0_尾37_鱗左;

		public Par X0Y0_尾37_鱗右;

		public Par X0Y0_尾37_尾;

		public Par X0Y0_尾38_鱗;

		public Par X0Y0_尾38_鱗左;

		public Par X0Y0_尾38_鱗右;

		public Par X0Y0_尾38_尾;

		public Par X0Y0_尾39_鱗;

		public Par X0Y0_尾39_鱗左;

		public Par X0Y0_尾39_鱗右;

		public Par X0Y0_尾39_尾;

		public Par X0Y0_尾40_鱗;

		public Par X0Y0_尾40_鱗左;

		public Par X0Y0_尾40_鱗右;

		public Par X0Y0_尾40_尾;

		public Par X0Y0_尾41_鱗;

		public Par X0Y0_尾41_鱗左;

		public Par X0Y0_尾41_鱗右;

		public Par X0Y0_尾41_尾;

		public Par X0Y0_尾42_鱗;

		public Par X0Y0_尾42_鱗左;

		public Par X0Y0_尾42_鱗右;

		public Par X0Y0_尾42_尾;

		public Par X0Y0_尾43_鱗;

		public Par X0Y0_尾43_鱗左;

		public Par X0Y0_尾43_鱗右;

		public Par X0Y0_尾43_尾;

		public Par X0Y0_尾44_鱗;

		public Par X0Y0_尾44_鱗左;

		public Par X0Y0_尾44_鱗右;

		public Par X0Y0_尾44_尾;

		public Par X0Y0_頭_上顎_顎基;

		public Par X0Y0_頭_上顎_鱗4;

		public Par X0Y0_頭_上顎_鱗左1;

		public Par X0Y0_頭_上顎_鱗右1;

		public Par X0Y0_頭_上顎_鱗左2;

		public Par X0Y0_頭_上顎_鱗右2;

		public Par X0Y0_頭_上顎_鱗左3;

		public Par X0Y0_頭_上顎_鱗右3;

		public Par X0Y0_頭_上顎_鱗左4;

		public Par X0Y0_頭_上顎_鱗右4;

		public Par X0Y0_頭_上顎_鱗左5;

		public Par X0Y0_頭_上顎_鱗右5;

		public Par X0Y0_頭_上顎_鱗左8;

		public Par X0Y0_頭_上顎_鱗右8;

		public Par X0Y0_頭_上顎_鱗左9;

		public Par X0Y0_頭_上顎_鱗右9;

		public Par X0Y0_頭_上顎_鱗左10;

		public Par X0Y0_頭_上顎_鱗右10;

		public Par X0Y0_頭_上顎_鱗左11;

		public Par X0Y0_頭_上顎_鱗右11;

		public Par X0Y0_頭_下顎_顎基;

		public Par X0Y0_頭_下顎_鱗1;

		public Par X0Y0_頭_下顎_鱗2;

		public Par X0Y0_頭_下顎_鱗3;

		public Par X0Y0_頭_下顎_鱗4;

		public Par X0Y0_頭_下顎_鱗左1;

		public Par X0Y0_頭_下顎_鱗右1;

		public Par X0Y0_頭_下顎_鱗左2;

		public Par X0Y0_頭_下顎_鱗右2;

		public Par X0Y0_頭_下顎_鱗左3;

		public Par X0Y0_頭_下顎_鱗右3;

		public Par X0Y0_頭_下顎_鱗左4;

		public Par X0Y0_頭_下顎_鱗右4;

		public Par X0Y0_頭_下顎_鱗左5;

		public Par X0Y0_頭_下顎_鱗右5;

		public Par X0Y0_頭_下顎_鱗左6;

		public Par X0Y0_頭_下顎_鱗右6;

		public Par X0Y0_頭_下顎_鱗左7;

		public Par X0Y0_頭_下顎_鱗右7;

		public Par X0Y0_頭_下顎_鱗左8;

		public Par X0Y0_頭_下顎_鱗右8;

		public Par X0Y0_頭_下顎_鱗左9;

		public Par X0Y0_頭_下顎_鱗右9;

		public Par X0Y0_頭_下顎_鱗左10;

		public Par X0Y0_頭_下顎_鱗右10;

		public Par X0Y0_頭_下顎_鱗左11;

		public Par X0Y0_頭_下顎_鱗右11;

		public Par X0Y0_輪2_革;

		public Par X0Y0_輪2_金具1;

		public Par X0Y0_輪2_金具2;

		public Par X0Y0_輪2_金具3;

		public Par X0Y0_輪2_金具左;

		public Par X0Y0_輪2_金具右;

		public ColorD 尾1_根CD;

		public ColorD 尾1_鱗CD;

		public ColorD 尾1_鱗左CD;

		public ColorD 尾1_鱗右CD;

		public ColorD 尾1_尾CD;

		public ColorD 尾2_鱗CD;

		public ColorD 尾2_鱗左CD;

		public ColorD 尾2_鱗右CD;

		public ColorD 尾2_尾CD;

		public ColorD 尾3_鱗CD;

		public ColorD 尾3_鱗左CD;

		public ColorD 尾3_鱗右CD;

		public ColorD 尾3_尾CD;

		public ColorD 尾4_鱗CD;

		public ColorD 尾4_鱗左CD;

		public ColorD 尾4_鱗右CD;

		public ColorD 尾4_尾CD;

		public ColorD 尾5_鱗CD;

		public ColorD 尾5_鱗左CD;

		public ColorD 尾5_鱗右CD;

		public ColorD 尾5_尾CD;

		public ColorD 尾6_鱗CD;

		public ColorD 尾6_鱗左CD;

		public ColorD 尾6_鱗右CD;

		public ColorD 尾6_尾CD;

		public ColorD 尾7_鱗CD;

		public ColorD 尾7_鱗左CD;

		public ColorD 尾7_鱗右CD;

		public ColorD 尾7_尾CD;

		public ColorD 尾8_鱗CD;

		public ColorD 尾8_鱗左CD;

		public ColorD 尾8_鱗右CD;

		public ColorD 尾8_尾CD;

		public ColorD 尾9_鱗CD;

		public ColorD 尾9_鱗左CD;

		public ColorD 尾9_鱗右CD;

		public ColorD 尾9_尾CD;

		public ColorD 尾10_鱗CD;

		public ColorD 尾10_鱗左CD;

		public ColorD 尾10_鱗右CD;

		public ColorD 尾10_尾CD;

		public ColorD 尾11_鱗CD;

		public ColorD 尾11_鱗左CD;

		public ColorD 尾11_鱗右CD;

		public ColorD 尾11_尾CD;

		public ColorD 尾12_鱗CD;

		public ColorD 尾12_鱗左CD;

		public ColorD 尾12_鱗右CD;

		public ColorD 尾12_尾CD;

		public ColorD 尾13_鱗CD;

		public ColorD 尾13_鱗左CD;

		public ColorD 尾13_鱗右CD;

		public ColorD 尾13_尾CD;

		public ColorD 尾14_鱗CD;

		public ColorD 尾14_鱗左CD;

		public ColorD 尾14_鱗右CD;

		public ColorD 尾14_尾CD;

		public ColorD 尾15_鱗CD;

		public ColorD 尾15_鱗左CD;

		public ColorD 尾15_鱗右CD;

		public ColorD 尾15_尾CD;

		public ColorD 尾16_鱗CD;

		public ColorD 尾16_鱗左CD;

		public ColorD 尾16_鱗右CD;

		public ColorD 尾16_尾CD;

		public ColorD 尾17_鱗CD;

		public ColorD 尾17_鱗左CD;

		public ColorD 尾17_鱗右CD;

		public ColorD 尾17_尾CD;

		public ColorD 尾18_鱗CD;

		public ColorD 尾18_鱗左CD;

		public ColorD 尾18_鱗右CD;

		public ColorD 尾18_尾CD;

		public ColorD 尾19_鱗CD;

		public ColorD 尾19_鱗左CD;

		public ColorD 尾19_鱗右CD;

		public ColorD 尾19_尾CD;

		public ColorD 尾20_鱗CD;

		public ColorD 尾20_鱗左CD;

		public ColorD 尾20_鱗右CD;

		public ColorD 尾20_尾CD;

		public ColorD 尾21_鱗CD;

		public ColorD 尾21_鱗左CD;

		public ColorD 尾21_鱗右CD;

		public ColorD 尾21_尾CD;

		public ColorD 尾22_鱗CD;

		public ColorD 尾22_鱗左CD;

		public ColorD 尾22_鱗右CD;

		public ColorD 尾22_尾CD;

		public ColorD 尾23_鱗CD;

		public ColorD 尾23_鱗左CD;

		public ColorD 尾23_鱗右CD;

		public ColorD 尾23_尾CD;

		public ColorD 尾24_鱗CD;

		public ColorD 尾24_鱗左CD;

		public ColorD 尾24_鱗右CD;

		public ColorD 尾24_尾CD;

		public ColorD 尾25_鱗CD;

		public ColorD 尾25_鱗左CD;

		public ColorD 尾25_鱗右CD;

		public ColorD 尾25_尾CD;

		public ColorD 尾26_鱗CD;

		public ColorD 尾26_鱗左CD;

		public ColorD 尾26_鱗右CD;

		public ColorD 尾26_尾CD;

		public ColorD 尾27_鱗CD;

		public ColorD 尾27_鱗左CD;

		public ColorD 尾27_鱗右CD;

		public ColorD 尾27_尾CD;

		public ColorD 尾28_鱗CD;

		public ColorD 尾28_鱗左CD;

		public ColorD 尾28_鱗右CD;

		public ColorD 尾28_尾CD;

		public ColorD 尾29_鱗CD;

		public ColorD 尾29_鱗左CD;

		public ColorD 尾29_鱗右CD;

		public ColorD 尾29_尾CD;

		public ColorD 尾30_鱗CD;

		public ColorD 尾30_鱗左CD;

		public ColorD 尾30_鱗右CD;

		public ColorD 尾30_尾CD;

		public ColorD 尾31_鱗CD;

		public ColorD 尾31_鱗左CD;

		public ColorD 尾31_鱗右CD;

		public ColorD 尾31_尾CD;

		public ColorD 尾32_鱗CD;

		public ColorD 尾32_鱗左CD;

		public ColorD 尾32_鱗右CD;

		public ColorD 尾32_尾CD;

		public ColorD 尾33_鱗CD;

		public ColorD 尾33_鱗左CD;

		public ColorD 尾33_鱗右CD;

		public ColorD 尾33_尾CD;

		public ColorD 尾34_鱗CD;

		public ColorD 尾34_鱗左CD;

		public ColorD 尾34_鱗右CD;

		public ColorD 尾34_尾CD;

		public ColorD 尾35_鱗CD;

		public ColorD 尾35_鱗左CD;

		public ColorD 尾35_鱗右CD;

		public ColorD 尾35_尾CD;

		public ColorD 尾36_鱗CD;

		public ColorD 尾36_鱗左CD;

		public ColorD 尾36_鱗右CD;

		public ColorD 尾36_尾CD;

		public ColorD 尾37_鱗CD;

		public ColorD 尾37_鱗左CD;

		public ColorD 尾37_鱗右CD;

		public ColorD 尾37_尾CD;

		public ColorD 尾38_鱗CD;

		public ColorD 尾38_鱗左CD;

		public ColorD 尾38_鱗右CD;

		public ColorD 尾38_尾CD;

		public ColorD 尾39_鱗CD;

		public ColorD 尾39_鱗左CD;

		public ColorD 尾39_鱗右CD;

		public ColorD 尾39_尾CD;

		public ColorD 尾40_鱗CD;

		public ColorD 尾40_鱗左CD;

		public ColorD 尾40_鱗右CD;

		public ColorD 尾40_尾CD;

		public ColorD 尾41_鱗CD;

		public ColorD 尾41_鱗左CD;

		public ColorD 尾41_鱗右CD;

		public ColorD 尾41_尾CD;

		public ColorD 尾42_鱗CD;

		public ColorD 尾42_鱗左CD;

		public ColorD 尾42_鱗右CD;

		public ColorD 尾42_尾CD;

		public ColorD 尾43_鱗CD;

		public ColorD 尾43_鱗左CD;

		public ColorD 尾43_鱗右CD;

		public ColorD 尾43_尾CD;

		public ColorD 尾44_鱗CD;

		public ColorD 尾44_鱗左CD;

		public ColorD 尾44_鱗右CD;

		public ColorD 尾44_尾CD;

		public ColorD 頭_上顎_顎基CD;

		public ColorD 頭_上顎_鱗4CD;

		public ColorD 頭_上顎_鱗左1CD;

		public ColorD 頭_上顎_鱗右1CD;

		public ColorD 頭_上顎_鱗左2CD;

		public ColorD 頭_上顎_鱗右2CD;

		public ColorD 頭_上顎_鱗左3CD;

		public ColorD 頭_上顎_鱗右3CD;

		public ColorD 頭_上顎_鱗左4CD;

		public ColorD 頭_上顎_鱗右4CD;

		public ColorD 頭_上顎_鱗左5CD;

		public ColorD 頭_上顎_鱗右5CD;

		public ColorD 頭_上顎_鱗左8CD;

		public ColorD 頭_上顎_鱗右8CD;

		public ColorD 頭_上顎_鱗左9CD;

		public ColorD 頭_上顎_鱗右9CD;

		public ColorD 頭_上顎_鱗左10CD;

		public ColorD 頭_上顎_鱗右10CD;

		public ColorD 頭_上顎_鱗左11CD;

		public ColorD 頭_上顎_鱗右11CD;

		public ColorD 頭_下顎_顎基CD;

		public ColorD 頭_下顎_鱗1CD;

		public ColorD 頭_下顎_鱗2CD;

		public ColorD 頭_下顎_鱗3CD;

		public ColorD 頭_下顎_鱗4CD;

		public ColorD 頭_下顎_鱗左1CD;

		public ColorD 頭_下顎_鱗右1CD;

		public ColorD 頭_下顎_鱗左2CD;

		public ColorD 頭_下顎_鱗右2CD;

		public ColorD 頭_下顎_鱗左3CD;

		public ColorD 頭_下顎_鱗右3CD;

		public ColorD 頭_下顎_鱗左4CD;

		public ColorD 頭_下顎_鱗右4CD;

		public ColorD 頭_下顎_鱗左5CD;

		public ColorD 頭_下顎_鱗右5CD;

		public ColorD 頭_下顎_鱗左6CD;

		public ColorD 頭_下顎_鱗右6CD;

		public ColorD 頭_下顎_鱗左7CD;

		public ColorD 頭_下顎_鱗右7CD;

		public ColorD 頭_下顎_鱗左8CD;

		public ColorD 頭_下顎_鱗右8CD;

		public ColorD 頭_下顎_鱗左9CD;

		public ColorD 頭_下顎_鱗右9CD;

		public ColorD 頭_下顎_鱗左10CD;

		public ColorD 頭_下顎_鱗右10CD;

		public ColorD 頭_下顎_鱗左11CD;

		public ColorD 頭_下顎_鱗右11CD;

		public ColorD 輪1_革CD;

		public ColorD 輪1_金具1CD;

		public ColorD 輪1_金具2CD;

		public ColorD 輪1_金具3CD;

		public ColorD 輪1_金具左CD;

		public ColorD 輪1_金具右CD;

		public ColorD 輪2_革CD;

		public ColorD 輪2_金具1CD;

		public ColorD 輪2_金具2CD;

		public ColorD 輪2_金具3CD;

		public ColorD 輪2_金具左CD;

		public ColorD 輪2_金具右CD;

		public ColorP X0Y0_尾1_根CP;

		public ColorP X0Y0_尾1_鱗CP;

		public ColorP X0Y0_尾1_鱗左CP;

		public ColorP X0Y0_尾1_鱗右CP;

		public ColorP X0Y0_尾1_尾CP;

		public ColorP X0Y0_尾2_鱗CP;

		public ColorP X0Y0_尾2_鱗左CP;

		public ColorP X0Y0_尾2_鱗右CP;

		public ColorP X0Y0_尾2_尾CP;

		public ColorP X0Y0_尾3_鱗CP;

		public ColorP X0Y0_尾3_鱗左CP;

		public ColorP X0Y0_尾3_鱗右CP;

		public ColorP X0Y0_尾3_尾CP;

		public ColorP X0Y0_尾4_鱗CP;

		public ColorP X0Y0_尾4_鱗左CP;

		public ColorP X0Y0_尾4_鱗右CP;

		public ColorP X0Y0_尾4_尾CP;

		public ColorP X0Y0_尾5_鱗CP;

		public ColorP X0Y0_尾5_鱗左CP;

		public ColorP X0Y0_尾5_鱗右CP;

		public ColorP X0Y0_尾5_尾CP;

		public ColorP X0Y0_尾6_鱗CP;

		public ColorP X0Y0_尾6_鱗左CP;

		public ColorP X0Y0_尾6_鱗右CP;

		public ColorP X0Y0_尾6_尾CP;

		public ColorP X0Y0_尾7_鱗CP;

		public ColorP X0Y0_尾7_鱗左CP;

		public ColorP X0Y0_尾7_鱗右CP;

		public ColorP X0Y0_尾7_尾CP;

		public ColorP X0Y0_尾8_鱗CP;

		public ColorP X0Y0_尾8_鱗左CP;

		public ColorP X0Y0_尾8_鱗右CP;

		public ColorP X0Y0_尾8_尾CP;

		public ColorP X0Y0_尾9_鱗CP;

		public ColorP X0Y0_尾9_鱗左CP;

		public ColorP X0Y0_尾9_鱗右CP;

		public ColorP X0Y0_尾9_尾CP;

		public ColorP X0Y0_尾10_鱗CP;

		public ColorP X0Y0_尾10_鱗左CP;

		public ColorP X0Y0_尾10_鱗右CP;

		public ColorP X0Y0_尾10_尾CP;

		public ColorP X0Y0_尾11_鱗CP;

		public ColorP X0Y0_尾11_鱗左CP;

		public ColorP X0Y0_尾11_鱗右CP;

		public ColorP X0Y0_尾11_尾CP;

		public ColorP X0Y0_尾12_鱗CP;

		public ColorP X0Y0_尾12_鱗左CP;

		public ColorP X0Y0_尾12_鱗右CP;

		public ColorP X0Y0_尾12_尾CP;

		public ColorP X0Y0_尾13_鱗CP;

		public ColorP X0Y0_尾13_鱗左CP;

		public ColorP X0Y0_尾13_鱗右CP;

		public ColorP X0Y0_尾13_尾CP;

		public ColorP X0Y0_尾14_鱗CP;

		public ColorP X0Y0_尾14_鱗左CP;

		public ColorP X0Y0_尾14_鱗右CP;

		public ColorP X0Y0_尾14_尾CP;

		public ColorP X0Y0_尾15_鱗CP;

		public ColorP X0Y0_尾15_鱗左CP;

		public ColorP X0Y0_尾15_鱗右CP;

		public ColorP X0Y0_尾15_尾CP;

		public ColorP X0Y0_尾16_鱗CP;

		public ColorP X0Y0_尾16_鱗左CP;

		public ColorP X0Y0_尾16_鱗右CP;

		public ColorP X0Y0_尾16_尾CP;

		public ColorP X0Y0_尾17_鱗CP;

		public ColorP X0Y0_尾17_鱗左CP;

		public ColorP X0Y0_尾17_鱗右CP;

		public ColorP X0Y0_尾17_尾CP;

		public ColorP X0Y0_尾18_鱗CP;

		public ColorP X0Y0_尾18_鱗左CP;

		public ColorP X0Y0_尾18_鱗右CP;

		public ColorP X0Y0_尾18_尾CP;

		public ColorP X0Y0_尾19_鱗CP;

		public ColorP X0Y0_尾19_鱗左CP;

		public ColorP X0Y0_尾19_鱗右CP;

		public ColorP X0Y0_尾19_尾CP;

		public ColorP X0Y0_尾20_鱗CP;

		public ColorP X0Y0_尾20_鱗左CP;

		public ColorP X0Y0_尾20_鱗右CP;

		public ColorP X0Y0_尾20_尾CP;

		public ColorP X0Y0_尾21_鱗CP;

		public ColorP X0Y0_尾21_鱗左CP;

		public ColorP X0Y0_尾21_鱗右CP;

		public ColorP X0Y0_尾21_尾CP;

		public ColorP X0Y0_尾22_鱗CP;

		public ColorP X0Y0_尾22_鱗左CP;

		public ColorP X0Y0_尾22_鱗右CP;

		public ColorP X0Y0_尾22_尾CP;

		public ColorP X0Y0_尾23_鱗CP;

		public ColorP X0Y0_尾23_鱗左CP;

		public ColorP X0Y0_尾23_鱗右CP;

		public ColorP X0Y0_尾23_尾CP;

		public ColorP X0Y0_尾24_鱗CP;

		public ColorP X0Y0_尾24_鱗左CP;

		public ColorP X0Y0_尾24_鱗右CP;

		public ColorP X0Y0_尾24_尾CP;

		public ColorP X0Y0_尾25_鱗CP;

		public ColorP X0Y0_尾25_鱗左CP;

		public ColorP X0Y0_尾25_鱗右CP;

		public ColorP X0Y0_尾25_尾CP;

		public ColorP X0Y0_尾26_鱗CP;

		public ColorP X0Y0_尾26_鱗左CP;

		public ColorP X0Y0_尾26_鱗右CP;

		public ColorP X0Y0_尾26_尾CP;

		public ColorP X0Y0_輪1_革CP;

		public ColorP X0Y0_輪1_金具1CP;

		public ColorP X0Y0_輪1_金具2CP;

		public ColorP X0Y0_輪1_金具3CP;

		public ColorP X0Y0_輪1_金具左CP;

		public ColorP X0Y0_輪1_金具右CP;

		public ColorP X0Y0_尾27_鱗CP;

		public ColorP X0Y0_尾27_鱗左CP;

		public ColorP X0Y0_尾27_鱗右CP;

		public ColorP X0Y0_尾27_尾CP;

		public ColorP X0Y0_尾28_鱗CP;

		public ColorP X0Y0_尾28_鱗左CP;

		public ColorP X0Y0_尾28_鱗右CP;

		public ColorP X0Y0_尾28_尾CP;

		public ColorP X0Y0_尾29_鱗CP;

		public ColorP X0Y0_尾29_鱗左CP;

		public ColorP X0Y0_尾29_鱗右CP;

		public ColorP X0Y0_尾29_尾CP;

		public ColorP X0Y0_尾30_鱗CP;

		public ColorP X0Y0_尾30_鱗左CP;

		public ColorP X0Y0_尾30_鱗右CP;

		public ColorP X0Y0_尾30_尾CP;

		public ColorP X0Y0_尾31_鱗CP;

		public ColorP X0Y0_尾31_鱗左CP;

		public ColorP X0Y0_尾31_鱗右CP;

		public ColorP X0Y0_尾31_尾CP;

		public ColorP X0Y0_尾32_鱗CP;

		public ColorP X0Y0_尾32_鱗左CP;

		public ColorP X0Y0_尾32_鱗右CP;

		public ColorP X0Y0_尾32_尾CP;

		public ColorP X0Y0_尾33_鱗CP;

		public ColorP X0Y0_尾33_鱗左CP;

		public ColorP X0Y0_尾33_鱗右CP;

		public ColorP X0Y0_尾33_尾CP;

		public ColorP X0Y0_尾34_鱗CP;

		public ColorP X0Y0_尾34_鱗左CP;

		public ColorP X0Y0_尾34_鱗右CP;

		public ColorP X0Y0_尾34_尾CP;

		public ColorP X0Y0_尾35_鱗CP;

		public ColorP X0Y0_尾35_鱗左CP;

		public ColorP X0Y0_尾35_鱗右CP;

		public ColorP X0Y0_尾35_尾CP;

		public ColorP X0Y0_尾36_鱗CP;

		public ColorP X0Y0_尾36_鱗左CP;

		public ColorP X0Y0_尾36_鱗右CP;

		public ColorP X0Y0_尾36_尾CP;

		public ColorP X0Y0_尾37_鱗CP;

		public ColorP X0Y0_尾37_鱗左CP;

		public ColorP X0Y0_尾37_鱗右CP;

		public ColorP X0Y0_尾37_尾CP;

		public ColorP X0Y0_尾38_鱗CP;

		public ColorP X0Y0_尾38_鱗左CP;

		public ColorP X0Y0_尾38_鱗右CP;

		public ColorP X0Y0_尾38_尾CP;

		public ColorP X0Y0_尾39_鱗CP;

		public ColorP X0Y0_尾39_鱗左CP;

		public ColorP X0Y0_尾39_鱗右CP;

		public ColorP X0Y0_尾39_尾CP;

		public ColorP X0Y0_尾40_鱗CP;

		public ColorP X0Y0_尾40_鱗左CP;

		public ColorP X0Y0_尾40_鱗右CP;

		public ColorP X0Y0_尾40_尾CP;

		public ColorP X0Y0_尾41_鱗CP;

		public ColorP X0Y0_尾41_鱗左CP;

		public ColorP X0Y0_尾41_鱗右CP;

		public ColorP X0Y0_尾41_尾CP;

		public ColorP X0Y0_尾42_鱗CP;

		public ColorP X0Y0_尾42_鱗左CP;

		public ColorP X0Y0_尾42_鱗右CP;

		public ColorP X0Y0_尾42_尾CP;

		public ColorP X0Y0_尾43_鱗CP;

		public ColorP X0Y0_尾43_鱗左CP;

		public ColorP X0Y0_尾43_鱗右CP;

		public ColorP X0Y0_尾43_尾CP;

		public ColorP X0Y0_尾44_鱗CP;

		public ColorP X0Y0_尾44_鱗左CP;

		public ColorP X0Y0_尾44_鱗右CP;

		public ColorP X0Y0_尾44_尾CP;

		public ColorP X0Y0_頭_上顎_顎基CP;

		public ColorP X0Y0_頭_上顎_鱗4CP;

		public ColorP X0Y0_頭_上顎_鱗左1CP;

		public ColorP X0Y0_頭_上顎_鱗右1CP;

		public ColorP X0Y0_頭_上顎_鱗左2CP;

		public ColorP X0Y0_頭_上顎_鱗右2CP;

		public ColorP X0Y0_頭_上顎_鱗左3CP;

		public ColorP X0Y0_頭_上顎_鱗右3CP;

		public ColorP X0Y0_頭_上顎_鱗左4CP;

		public ColorP X0Y0_頭_上顎_鱗右4CP;

		public ColorP X0Y0_頭_上顎_鱗左5CP;

		public ColorP X0Y0_頭_上顎_鱗右5CP;

		public ColorP X0Y0_頭_上顎_鱗左8CP;

		public ColorP X0Y0_頭_上顎_鱗右8CP;

		public ColorP X0Y0_頭_上顎_鱗左9CP;

		public ColorP X0Y0_頭_上顎_鱗右9CP;

		public ColorP X0Y0_頭_上顎_鱗左10CP;

		public ColorP X0Y0_頭_上顎_鱗右10CP;

		public ColorP X0Y0_頭_上顎_鱗左11CP;

		public ColorP X0Y0_頭_上顎_鱗右11CP;

		public ColorP X0Y0_頭_下顎_顎基CP;

		public ColorP X0Y0_頭_下顎_鱗1CP;

		public ColorP X0Y0_頭_下顎_鱗2CP;

		public ColorP X0Y0_頭_下顎_鱗3CP;

		public ColorP X0Y0_頭_下顎_鱗4CP;

		public ColorP X0Y0_頭_下顎_鱗左1CP;

		public ColorP X0Y0_頭_下顎_鱗右1CP;

		public ColorP X0Y0_頭_下顎_鱗左2CP;

		public ColorP X0Y0_頭_下顎_鱗右2CP;

		public ColorP X0Y0_頭_下顎_鱗左3CP;

		public ColorP X0Y0_頭_下顎_鱗右3CP;

		public ColorP X0Y0_頭_下顎_鱗左4CP;

		public ColorP X0Y0_頭_下顎_鱗右4CP;

		public ColorP X0Y0_頭_下顎_鱗左5CP;

		public ColorP X0Y0_頭_下顎_鱗右5CP;

		public ColorP X0Y0_頭_下顎_鱗左6CP;

		public ColorP X0Y0_頭_下顎_鱗右6CP;

		public ColorP X0Y0_頭_下顎_鱗左7CP;

		public ColorP X0Y0_頭_下顎_鱗右7CP;

		public ColorP X0Y0_頭_下顎_鱗左8CP;

		public ColorP X0Y0_頭_下顎_鱗右8CP;

		public ColorP X0Y0_頭_下顎_鱗左9CP;

		public ColorP X0Y0_頭_下顎_鱗右9CP;

		public ColorP X0Y0_頭_下顎_鱗左10CP;

		public ColorP X0Y0_頭_下顎_鱗右10CP;

		public ColorP X0Y0_頭_下顎_鱗左11CP;

		public ColorP X0Y0_頭_下顎_鱗右11CP;

		public ColorP X0Y0_輪2_革CP;

		public ColorP X0Y0_輪2_金具1CP;

		public ColorP X0Y0_輪2_金具2CP;

		public ColorP X0Y0_輪2_金具3CP;

		public ColorP X0Y0_輪2_金具左CP;

		public ColorP X0Y0_輪2_金具右CP;

		public 拘束鎖 鎖1;

		public 拘束鎖 鎖2;

		public 拘束鎖 鎖3;

		public 拘束鎖 鎖4;
	}
}
