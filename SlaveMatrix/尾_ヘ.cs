using System;
using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 尾_ヘ : 尾
	{
		public 尾_ヘ(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 尾_ヘD e)
		{
			尾_ヘ.<>c__DisplayClass784_0 CS$<>8__locals1 = new 尾_ヘ.<>c__DisplayClass784_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "ヘビ";
			dif.Add(new Pars(Sta.尻尾["尾"][0][16]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["尾35"].ToPars();
			this.X0Y0_尾35_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾35_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾35_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾35_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾35_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾35_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾35_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾34"].ToPars();
			this.X0Y0_尾34_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾34_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾34_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾34_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾34_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾34_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾34_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾33"].ToPars();
			this.X0Y0_尾33_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾33_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾33_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾33_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾33_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾33_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾33_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾32"].ToPars();
			this.X0Y0_尾32_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾32_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾32_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾32_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾32_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾32_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾32_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾31"].ToPars();
			this.X0Y0_尾31_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾31_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾31_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾31_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾31_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾31_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾31_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾30"].ToPars();
			this.X0Y0_尾30_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾30_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾30_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾30_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾30_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾30_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾30_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾29"].ToPars();
			this.X0Y0_尾29_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾29_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾29_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾29_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾29_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾29_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾29_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾28"].ToPars();
			this.X0Y0_尾28_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾28_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾28_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾28_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾28_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾28_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾28_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾27"].ToPars();
			this.X0Y0_尾27_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾27_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾27_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾27_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾27_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾27_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾27_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾26"].ToPars();
			this.X0Y0_尾26_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾26_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾26_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾26_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾26_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾26_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾26_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾25"].ToPars();
			this.X0Y0_尾25_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾25_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾25_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾25_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾25_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾25_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾25_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾24"].ToPars();
			this.X0Y0_尾24_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾24_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾24_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾24_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾24_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾24_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾24_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾23"].ToPars();
			this.X0Y0_尾23_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾23_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾23_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾23_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾23_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾23_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾23_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾22"].ToPars();
			this.X0Y0_尾22_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾22_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾22_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾22_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾22_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾22_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾22_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾21"].ToPars();
			this.X0Y0_尾21_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾21_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾21_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾21_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾21_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾21_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾21_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾20"].ToPars();
			this.X0Y0_尾20_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾20_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾20_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾20_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾20_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾20_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾20_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾19"].ToPars();
			this.X0Y0_尾19_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾19_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾19_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾19_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾19_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾19_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾19_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾18"].ToPars();
			this.X0Y0_尾18_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾18_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾18_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾18_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾18_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾18_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾18_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾17"].ToPars();
			this.X0Y0_尾17_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾17_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾17_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾17_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾17_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾17_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾17_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾16"].ToPars();
			this.X0Y0_尾16_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾16_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾16_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾16_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾16_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾16_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾16_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾15"].ToPars();
			this.X0Y0_尾15_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾15_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾15_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾15_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾15_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾15_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾15_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾14"].ToPars();
			this.X0Y0_尾14_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾14_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾14_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾14_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾14_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾14_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾14_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾13"].ToPars();
			this.X0Y0_尾13_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾13_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾13_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾13_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾13_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾13_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾13_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾12"].ToPars();
			this.X0Y0_尾12_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾12_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾12_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾12_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾12_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾12_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾12_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾11"].ToPars();
			this.X0Y0_尾11_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾11_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾11_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾11_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾11_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾11_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾11_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾10"].ToPars();
			this.X0Y0_尾10_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾10_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾10_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾10_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾10_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾10_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾10_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾9"].ToPars();
			this.X0Y0_尾9_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾9_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾9_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾9_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾9_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾9_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾9_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾8"].ToPars();
			this.X0Y0_尾8_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾8_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾8_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾8_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾8_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾8_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾8_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾7"].ToPars();
			this.X0Y0_尾7_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾7_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾7_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾7_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾7_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾7_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾7_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾6"].ToPars();
			this.X0Y0_尾6_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾6_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾6_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾6_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾6_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾6_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾6_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾5"].ToPars();
			this.X0Y0_尾5_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾5_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾5_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾5_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾5_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾5_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾5_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾4"].ToPars();
			this.X0Y0_尾4_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾4_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾4_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾4_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾4_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾4_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾4_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾3"].ToPars();
			this.X0Y0_尾3_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾3_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾3_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾3_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾3_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾3_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾3_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾2"].ToPars();
			this.X0Y0_尾2_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾2_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾2_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾2_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾2_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾2_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾2_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾1"].ToPars();
			this.X0Y0_尾1_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾1_鱗左3 = pars2["鱗左3"].ToPar();
			this.X0Y0_尾1_鱗右3 = pars2["鱗右3"].ToPar();
			this.X0Y0_尾1_鱗左2 = pars2["鱗左2"].ToPar();
			this.X0Y0_尾1_鱗右2 = pars2["鱗右2"].ToPar();
			this.X0Y0_尾1_鱗左1 = pars2["鱗左1"].ToPar();
			this.X0Y0_尾1_鱗右1 = pars2["鱗右1"].ToPar();
			pars2 = pars["尾0"].ToPars();
			this.X0Y0_尾0_尾 = pars2["尾"].ToPar();
			this.X0Y0_尾0_鱗右 = pars2["鱗右"].ToPar();
			this.X0Y0_尾0_鱗左 = pars2["鱗左"].ToPar();
			pars2 = pars["輪1"].ToPars();
			this.X0Y0_輪1_革 = pars2["革"].ToPar();
			this.X0Y0_輪1_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_輪1_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_輪1_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_輪1_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_輪1_金具右 = pars2["金具右"].ToPar();
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
			this.尾35_尾_表示 = e.尾35_尾_表示;
			this.尾35_鱗左3_表示 = e.尾35_鱗左3_表示;
			this.尾35_鱗右3_表示 = e.尾35_鱗右3_表示;
			this.尾35_鱗左2_表示 = e.尾35_鱗左2_表示;
			this.尾35_鱗右2_表示 = e.尾35_鱗右2_表示;
			this.尾35_鱗左1_表示 = e.尾35_鱗左1_表示;
			this.尾35_鱗右1_表示 = e.尾35_鱗右1_表示;
			this.尾34_尾_表示 = e.尾34_尾_表示;
			this.尾34_鱗左3_表示 = e.尾34_鱗左3_表示;
			this.尾34_鱗右3_表示 = e.尾34_鱗右3_表示;
			this.尾34_鱗左2_表示 = e.尾34_鱗左2_表示;
			this.尾34_鱗右2_表示 = e.尾34_鱗右2_表示;
			this.尾34_鱗左1_表示 = e.尾34_鱗左1_表示;
			this.尾34_鱗右1_表示 = e.尾34_鱗右1_表示;
			this.尾33_尾_表示 = e.尾33_尾_表示;
			this.尾33_鱗左3_表示 = e.尾33_鱗左3_表示;
			this.尾33_鱗右3_表示 = e.尾33_鱗右3_表示;
			this.尾33_鱗左2_表示 = e.尾33_鱗左2_表示;
			this.尾33_鱗右2_表示 = e.尾33_鱗右2_表示;
			this.尾33_鱗左1_表示 = e.尾33_鱗左1_表示;
			this.尾33_鱗右1_表示 = e.尾33_鱗右1_表示;
			this.尾32_尾_表示 = e.尾32_尾_表示;
			this.尾32_鱗左3_表示 = e.尾32_鱗左3_表示;
			this.尾32_鱗右3_表示 = e.尾32_鱗右3_表示;
			this.尾32_鱗左2_表示 = e.尾32_鱗左2_表示;
			this.尾32_鱗右2_表示 = e.尾32_鱗右2_表示;
			this.尾32_鱗左1_表示 = e.尾32_鱗左1_表示;
			this.尾32_鱗右1_表示 = e.尾32_鱗右1_表示;
			this.尾31_尾_表示 = e.尾31_尾_表示;
			this.尾31_鱗左3_表示 = e.尾31_鱗左3_表示;
			this.尾31_鱗右3_表示 = e.尾31_鱗右3_表示;
			this.尾31_鱗左2_表示 = e.尾31_鱗左2_表示;
			this.尾31_鱗右2_表示 = e.尾31_鱗右2_表示;
			this.尾31_鱗左1_表示 = e.尾31_鱗左1_表示;
			this.尾31_鱗右1_表示 = e.尾31_鱗右1_表示;
			this.尾30_尾_表示 = e.尾30_尾_表示;
			this.尾30_鱗左3_表示 = e.尾30_鱗左3_表示;
			this.尾30_鱗右3_表示 = e.尾30_鱗右3_表示;
			this.尾30_鱗左2_表示 = e.尾30_鱗左2_表示;
			this.尾30_鱗右2_表示 = e.尾30_鱗右2_表示;
			this.尾30_鱗左1_表示 = e.尾30_鱗左1_表示;
			this.尾30_鱗右1_表示 = e.尾30_鱗右1_表示;
			this.尾29_尾_表示 = e.尾29_尾_表示;
			this.尾29_鱗左3_表示 = e.尾29_鱗左3_表示;
			this.尾29_鱗右3_表示 = e.尾29_鱗右3_表示;
			this.尾29_鱗左2_表示 = e.尾29_鱗左2_表示;
			this.尾29_鱗右2_表示 = e.尾29_鱗右2_表示;
			this.尾29_鱗左1_表示 = e.尾29_鱗左1_表示;
			this.尾29_鱗右1_表示 = e.尾29_鱗右1_表示;
			this.尾28_尾_表示 = e.尾28_尾_表示;
			this.尾28_鱗左3_表示 = e.尾28_鱗左3_表示;
			this.尾28_鱗右3_表示 = e.尾28_鱗右3_表示;
			this.尾28_鱗左2_表示 = e.尾28_鱗左2_表示;
			this.尾28_鱗右2_表示 = e.尾28_鱗右2_表示;
			this.尾28_鱗左1_表示 = e.尾28_鱗左1_表示;
			this.尾28_鱗右1_表示 = e.尾28_鱗右1_表示;
			this.尾27_尾_表示 = e.尾27_尾_表示;
			this.尾27_鱗左3_表示 = e.尾27_鱗左3_表示;
			this.尾27_鱗右3_表示 = e.尾27_鱗右3_表示;
			this.尾27_鱗左2_表示 = e.尾27_鱗左2_表示;
			this.尾27_鱗右2_表示 = e.尾27_鱗右2_表示;
			this.尾27_鱗左1_表示 = e.尾27_鱗左1_表示;
			this.尾27_鱗右1_表示 = e.尾27_鱗右1_表示;
			this.尾26_尾_表示 = e.尾26_尾_表示;
			this.尾26_鱗左3_表示 = e.尾26_鱗左3_表示;
			this.尾26_鱗右3_表示 = e.尾26_鱗右3_表示;
			this.尾26_鱗左2_表示 = e.尾26_鱗左2_表示;
			this.尾26_鱗右2_表示 = e.尾26_鱗右2_表示;
			this.尾26_鱗左1_表示 = e.尾26_鱗左1_表示;
			this.尾26_鱗右1_表示 = e.尾26_鱗右1_表示;
			this.尾25_尾_表示 = e.尾25_尾_表示;
			this.尾25_鱗左3_表示 = e.尾25_鱗左3_表示;
			this.尾25_鱗右3_表示 = e.尾25_鱗右3_表示;
			this.尾25_鱗左2_表示 = e.尾25_鱗左2_表示;
			this.尾25_鱗右2_表示 = e.尾25_鱗右2_表示;
			this.尾25_鱗左1_表示 = e.尾25_鱗左1_表示;
			this.尾25_鱗右1_表示 = e.尾25_鱗右1_表示;
			this.尾24_尾_表示 = e.尾24_尾_表示;
			this.尾24_鱗左3_表示 = e.尾24_鱗左3_表示;
			this.尾24_鱗右3_表示 = e.尾24_鱗右3_表示;
			this.尾24_鱗左2_表示 = e.尾24_鱗左2_表示;
			this.尾24_鱗右2_表示 = e.尾24_鱗右2_表示;
			this.尾24_鱗左1_表示 = e.尾24_鱗左1_表示;
			this.尾24_鱗右1_表示 = e.尾24_鱗右1_表示;
			this.尾23_尾_表示 = e.尾23_尾_表示;
			this.尾23_鱗左3_表示 = e.尾23_鱗左3_表示;
			this.尾23_鱗右3_表示 = e.尾23_鱗右3_表示;
			this.尾23_鱗左2_表示 = e.尾23_鱗左2_表示;
			this.尾23_鱗右2_表示 = e.尾23_鱗右2_表示;
			this.尾23_鱗左1_表示 = e.尾23_鱗左1_表示;
			this.尾23_鱗右1_表示 = e.尾23_鱗右1_表示;
			this.尾22_尾_表示 = e.尾22_尾_表示;
			this.尾22_鱗左3_表示 = e.尾22_鱗左3_表示;
			this.尾22_鱗右3_表示 = e.尾22_鱗右3_表示;
			this.尾22_鱗左2_表示 = e.尾22_鱗左2_表示;
			this.尾22_鱗右2_表示 = e.尾22_鱗右2_表示;
			this.尾22_鱗左1_表示 = e.尾22_鱗左1_表示;
			this.尾22_鱗右1_表示 = e.尾22_鱗右1_表示;
			this.尾21_尾_表示 = e.尾21_尾_表示;
			this.尾21_鱗左3_表示 = e.尾21_鱗左3_表示;
			this.尾21_鱗右3_表示 = e.尾21_鱗右3_表示;
			this.尾21_鱗左2_表示 = e.尾21_鱗左2_表示;
			this.尾21_鱗右2_表示 = e.尾21_鱗右2_表示;
			this.尾21_鱗左1_表示 = e.尾21_鱗左1_表示;
			this.尾21_鱗右1_表示 = e.尾21_鱗右1_表示;
			this.尾20_尾_表示 = e.尾20_尾_表示;
			this.尾20_鱗左3_表示 = e.尾20_鱗左3_表示;
			this.尾20_鱗右3_表示 = e.尾20_鱗右3_表示;
			this.尾20_鱗左2_表示 = e.尾20_鱗左2_表示;
			this.尾20_鱗右2_表示 = e.尾20_鱗右2_表示;
			this.尾20_鱗左1_表示 = e.尾20_鱗左1_表示;
			this.尾20_鱗右1_表示 = e.尾20_鱗右1_表示;
			this.尾19_尾_表示 = e.尾19_尾_表示;
			this.尾19_鱗左3_表示 = e.尾19_鱗左3_表示;
			this.尾19_鱗右3_表示 = e.尾19_鱗右3_表示;
			this.尾19_鱗左2_表示 = e.尾19_鱗左2_表示;
			this.尾19_鱗右2_表示 = e.尾19_鱗右2_表示;
			this.尾19_鱗左1_表示 = e.尾19_鱗左1_表示;
			this.尾19_鱗右1_表示 = e.尾19_鱗右1_表示;
			this.尾18_尾_表示 = e.尾18_尾_表示;
			this.尾18_鱗左3_表示 = e.尾18_鱗左3_表示;
			this.尾18_鱗右3_表示 = e.尾18_鱗右3_表示;
			this.尾18_鱗左2_表示 = e.尾18_鱗左2_表示;
			this.尾18_鱗右2_表示 = e.尾18_鱗右2_表示;
			this.尾18_鱗左1_表示 = e.尾18_鱗左1_表示;
			this.尾18_鱗右1_表示 = e.尾18_鱗右1_表示;
			this.尾17_尾_表示 = e.尾17_尾_表示;
			this.尾17_鱗左3_表示 = e.尾17_鱗左3_表示;
			this.尾17_鱗右3_表示 = e.尾17_鱗右3_表示;
			this.尾17_鱗左2_表示 = e.尾17_鱗左2_表示;
			this.尾17_鱗右2_表示 = e.尾17_鱗右2_表示;
			this.尾17_鱗左1_表示 = e.尾17_鱗左1_表示;
			this.尾17_鱗右1_表示 = e.尾17_鱗右1_表示;
			this.尾16_尾_表示 = e.尾16_尾_表示;
			this.尾16_鱗左3_表示 = e.尾16_鱗左3_表示;
			this.尾16_鱗右3_表示 = e.尾16_鱗右3_表示;
			this.尾16_鱗左2_表示 = e.尾16_鱗左2_表示;
			this.尾16_鱗右2_表示 = e.尾16_鱗右2_表示;
			this.尾16_鱗左1_表示 = e.尾16_鱗左1_表示;
			this.尾16_鱗右1_表示 = e.尾16_鱗右1_表示;
			this.尾15_尾_表示 = e.尾15_尾_表示;
			this.尾15_鱗左3_表示 = e.尾15_鱗左3_表示;
			this.尾15_鱗右3_表示 = e.尾15_鱗右3_表示;
			this.尾15_鱗左2_表示 = e.尾15_鱗左2_表示;
			this.尾15_鱗右2_表示 = e.尾15_鱗右2_表示;
			this.尾15_鱗左1_表示 = e.尾15_鱗左1_表示;
			this.尾15_鱗右1_表示 = e.尾15_鱗右1_表示;
			this.尾14_尾_表示 = e.尾14_尾_表示;
			this.尾14_鱗左3_表示 = e.尾14_鱗左3_表示;
			this.尾14_鱗右3_表示 = e.尾14_鱗右3_表示;
			this.尾14_鱗左2_表示 = e.尾14_鱗左2_表示;
			this.尾14_鱗右2_表示 = e.尾14_鱗右2_表示;
			this.尾14_鱗左1_表示 = e.尾14_鱗左1_表示;
			this.尾14_鱗右1_表示 = e.尾14_鱗右1_表示;
			this.尾13_尾_表示 = e.尾13_尾_表示;
			this.尾13_鱗左3_表示 = e.尾13_鱗左3_表示;
			this.尾13_鱗右3_表示 = e.尾13_鱗右3_表示;
			this.尾13_鱗左2_表示 = e.尾13_鱗左2_表示;
			this.尾13_鱗右2_表示 = e.尾13_鱗右2_表示;
			this.尾13_鱗左1_表示 = e.尾13_鱗左1_表示;
			this.尾13_鱗右1_表示 = e.尾13_鱗右1_表示;
			this.尾12_尾_表示 = e.尾12_尾_表示;
			this.尾12_鱗左3_表示 = e.尾12_鱗左3_表示;
			this.尾12_鱗右3_表示 = e.尾12_鱗右3_表示;
			this.尾12_鱗左2_表示 = e.尾12_鱗左2_表示;
			this.尾12_鱗右2_表示 = e.尾12_鱗右2_表示;
			this.尾12_鱗左1_表示 = e.尾12_鱗左1_表示;
			this.尾12_鱗右1_表示 = e.尾12_鱗右1_表示;
			this.尾11_尾_表示 = e.尾11_尾_表示;
			this.尾11_鱗左3_表示 = e.尾11_鱗左3_表示;
			this.尾11_鱗右3_表示 = e.尾11_鱗右3_表示;
			this.尾11_鱗左2_表示 = e.尾11_鱗左2_表示;
			this.尾11_鱗右2_表示 = e.尾11_鱗右2_表示;
			this.尾11_鱗左1_表示 = e.尾11_鱗左1_表示;
			this.尾11_鱗右1_表示 = e.尾11_鱗右1_表示;
			this.尾10_尾_表示 = e.尾10_尾_表示;
			this.尾10_鱗左3_表示 = e.尾10_鱗左3_表示;
			this.尾10_鱗右3_表示 = e.尾10_鱗右3_表示;
			this.尾10_鱗左2_表示 = e.尾10_鱗左2_表示;
			this.尾10_鱗右2_表示 = e.尾10_鱗右2_表示;
			this.尾10_鱗左1_表示 = e.尾10_鱗左1_表示;
			this.尾10_鱗右1_表示 = e.尾10_鱗右1_表示;
			this.尾9_表示 = e.尾9_表示;
			this.尾9_鱗左3_表示 = e.尾9_鱗左3_表示;
			this.尾9_鱗右3_表示 = e.尾9_鱗右3_表示;
			this.尾9_鱗左2_表示 = e.尾9_鱗左2_表示;
			this.尾9_鱗右2_表示 = e.尾9_鱗右2_表示;
			this.尾9_鱗左1_表示 = e.尾9_鱗左1_表示;
			this.尾9_鱗右1_表示 = e.尾9_鱗右1_表示;
			this.尾8_表示 = e.尾8_表示;
			this.尾8_鱗左3_表示 = e.尾8_鱗左3_表示;
			this.尾8_鱗右3_表示 = e.尾8_鱗右3_表示;
			this.尾8_鱗左2_表示 = e.尾8_鱗左2_表示;
			this.尾8_鱗右2_表示 = e.尾8_鱗右2_表示;
			this.尾8_鱗左1_表示 = e.尾8_鱗左1_表示;
			this.尾8_鱗右1_表示 = e.尾8_鱗右1_表示;
			this.尾7_表示 = e.尾7_表示;
			this.尾7_鱗左3_表示 = e.尾7_鱗左3_表示;
			this.尾7_鱗右3_表示 = e.尾7_鱗右3_表示;
			this.尾7_鱗左2_表示 = e.尾7_鱗左2_表示;
			this.尾7_鱗右2_表示 = e.尾7_鱗右2_表示;
			this.尾7_鱗左1_表示 = e.尾7_鱗左1_表示;
			this.尾7_鱗右1_表示 = e.尾7_鱗右1_表示;
			this.尾6_表示 = e.尾6_表示;
			this.尾6_鱗左3_表示 = e.尾6_鱗左3_表示;
			this.尾6_鱗右3_表示 = e.尾6_鱗右3_表示;
			this.尾6_鱗左2_表示 = e.尾6_鱗左2_表示;
			this.尾6_鱗右2_表示 = e.尾6_鱗右2_表示;
			this.尾6_鱗左1_表示 = e.尾6_鱗左1_表示;
			this.尾6_鱗右1_表示 = e.尾6_鱗右1_表示;
			this.尾5_表示 = e.尾5_表示;
			this.尾5_鱗左3_表示 = e.尾5_鱗左3_表示;
			this.尾5_鱗右3_表示 = e.尾5_鱗右3_表示;
			this.尾5_鱗左2_表示 = e.尾5_鱗左2_表示;
			this.尾5_鱗右2_表示 = e.尾5_鱗右2_表示;
			this.尾5_鱗左1_表示 = e.尾5_鱗左1_表示;
			this.尾5_鱗右1_表示 = e.尾5_鱗右1_表示;
			this.尾4_表示 = e.尾4_表示;
			this.尾4_鱗左3_表示 = e.尾4_鱗左3_表示;
			this.尾4_鱗右3_表示 = e.尾4_鱗右3_表示;
			this.尾4_鱗左2_表示 = e.尾4_鱗左2_表示;
			this.尾4_鱗右2_表示 = e.尾4_鱗右2_表示;
			this.尾4_鱗左1_表示 = e.尾4_鱗左1_表示;
			this.尾4_鱗右1_表示 = e.尾4_鱗右1_表示;
			this.尾3_表示 = e.尾3_表示;
			this.尾3_鱗左3_表示 = e.尾3_鱗左3_表示;
			this.尾3_鱗右3_表示 = e.尾3_鱗右3_表示;
			this.尾3_鱗左2_表示 = e.尾3_鱗左2_表示;
			this.尾3_鱗右2_表示 = e.尾3_鱗右2_表示;
			this.尾3_鱗左1_表示 = e.尾3_鱗左1_表示;
			this.尾3_鱗右1_表示 = e.尾3_鱗右1_表示;
			this.尾2_表示 = e.尾2_表示;
			this.尾2_鱗左3_表示 = e.尾2_鱗左3_表示;
			this.尾2_鱗右3_表示 = e.尾2_鱗右3_表示;
			this.尾2_鱗左2_表示 = e.尾2_鱗左2_表示;
			this.尾2_鱗右2_表示 = e.尾2_鱗右2_表示;
			this.尾2_鱗左1_表示 = e.尾2_鱗左1_表示;
			this.尾2_鱗右1_表示 = e.尾2_鱗右1_表示;
			this.尾1_表示 = e.尾1_表示;
			this.尾1_鱗左3_表示 = e.尾1_鱗左3_表示;
			this.尾1_鱗右3_表示 = e.尾1_鱗右3_表示;
			this.尾1_鱗左2_表示 = e.尾1_鱗左2_表示;
			this.尾1_鱗右2_表示 = e.尾1_鱗右2_表示;
			this.尾1_鱗左1_表示 = e.尾1_鱗左1_表示;
			this.尾1_鱗右1_表示 = e.尾1_鱗右1_表示;
			this.尾0_表示 = e.尾0_表示;
			this.尾0_鱗右_表示 = e.尾0_鱗右_表示;
			this.尾0_鱗左_表示 = e.尾0_鱗左_表示;
			this.輪1_革_表示 = e.輪1_革_表示;
			this.輪1_金具1_表示 = e.輪1_金具1_表示;
			this.輪1_金具2_表示 = e.輪1_金具2_表示;
			this.輪1_金具3_表示 = e.輪1_金具3_表示;
			this.輪1_金具左_表示 = e.輪1_金具左_表示;
			this.輪1_金具右_表示 = e.輪1_金具右_表示;
			this.輪2_革_表示 = e.輪2_革_表示;
			this.輪2_金具1_表示 = e.輪2_金具1_表示;
			this.輪2_金具2_表示 = e.輪2_金具2_表示;
			this.輪2_金具3_表示 = e.輪2_金具3_表示;
			this.輪2_金具左_表示 = e.輪2_金具左_表示;
			this.輪2_金具右_表示 = e.輪2_金具右_表示;
			this.輪1表示 = e.輪1表示;
			this.輪2表示 = e.輪2表示;
			this.尾先表示 = e.尾先表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.尾先_接続.Count > 0)
			{
				Ele f;
				this.尾先_接続 = e.尾先_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_ヘ_尾先_接続;
					f.接続(CS$<>8__locals1.<>4__this.尾先_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_尾35_尾CP = new ColorP(this.X0Y0_尾35_尾, this.尾35_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾35_鱗左3CP = new ColorP(this.X0Y0_尾35_鱗左3, this.尾35_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾35_鱗右3CP = new ColorP(this.X0Y0_尾35_鱗右3, this.尾35_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾35_鱗左2CP = new ColorP(this.X0Y0_尾35_鱗左2, this.尾35_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾35_鱗右2CP = new ColorP(this.X0Y0_尾35_鱗右2, this.尾35_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾35_鱗左1CP = new ColorP(this.X0Y0_尾35_鱗左1, this.尾35_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾35_鱗右1CP = new ColorP(this.X0Y0_尾35_鱗右1, this.尾35_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾34_尾CP = new ColorP(this.X0Y0_尾34_尾, this.尾34_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾34_鱗左3CP = new ColorP(this.X0Y0_尾34_鱗左3, this.尾34_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾34_鱗右3CP = new ColorP(this.X0Y0_尾34_鱗右3, this.尾34_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾34_鱗左2CP = new ColorP(this.X0Y0_尾34_鱗左2, this.尾34_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾34_鱗右2CP = new ColorP(this.X0Y0_尾34_鱗右2, this.尾34_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾34_鱗左1CP = new ColorP(this.X0Y0_尾34_鱗左1, this.尾34_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾34_鱗右1CP = new ColorP(this.X0Y0_尾34_鱗右1, this.尾34_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾33_尾CP = new ColorP(this.X0Y0_尾33_尾, this.尾33_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾33_鱗左3CP = new ColorP(this.X0Y0_尾33_鱗左3, this.尾33_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾33_鱗右3CP = new ColorP(this.X0Y0_尾33_鱗右3, this.尾33_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾33_鱗左2CP = new ColorP(this.X0Y0_尾33_鱗左2, this.尾33_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾33_鱗右2CP = new ColorP(this.X0Y0_尾33_鱗右2, this.尾33_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾33_鱗左1CP = new ColorP(this.X0Y0_尾33_鱗左1, this.尾33_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾33_鱗右1CP = new ColorP(this.X0Y0_尾33_鱗右1, this.尾33_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾32_尾CP = new ColorP(this.X0Y0_尾32_尾, this.尾32_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾32_鱗左3CP = new ColorP(this.X0Y0_尾32_鱗左3, this.尾32_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾32_鱗右3CP = new ColorP(this.X0Y0_尾32_鱗右3, this.尾32_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾32_鱗左2CP = new ColorP(this.X0Y0_尾32_鱗左2, this.尾32_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾32_鱗右2CP = new ColorP(this.X0Y0_尾32_鱗右2, this.尾32_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾32_鱗左1CP = new ColorP(this.X0Y0_尾32_鱗左1, this.尾32_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾32_鱗右1CP = new ColorP(this.X0Y0_尾32_鱗右1, this.尾32_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾31_尾CP = new ColorP(this.X0Y0_尾31_尾, this.尾31_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾31_鱗左3CP = new ColorP(this.X0Y0_尾31_鱗左3, this.尾31_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾31_鱗右3CP = new ColorP(this.X0Y0_尾31_鱗右3, this.尾31_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾31_鱗左2CP = new ColorP(this.X0Y0_尾31_鱗左2, this.尾31_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾31_鱗右2CP = new ColorP(this.X0Y0_尾31_鱗右2, this.尾31_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾31_鱗左1CP = new ColorP(this.X0Y0_尾31_鱗左1, this.尾31_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾31_鱗右1CP = new ColorP(this.X0Y0_尾31_鱗右1, this.尾31_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾30_尾CP = new ColorP(this.X0Y0_尾30_尾, this.尾30_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾30_鱗左3CP = new ColorP(this.X0Y0_尾30_鱗左3, this.尾30_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾30_鱗右3CP = new ColorP(this.X0Y0_尾30_鱗右3, this.尾30_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾30_鱗左2CP = new ColorP(this.X0Y0_尾30_鱗左2, this.尾30_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾30_鱗右2CP = new ColorP(this.X0Y0_尾30_鱗右2, this.尾30_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾30_鱗左1CP = new ColorP(this.X0Y0_尾30_鱗左1, this.尾30_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾30_鱗右1CP = new ColorP(this.X0Y0_尾30_鱗右1, this.尾30_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾29_尾CP = new ColorP(this.X0Y0_尾29_尾, this.尾29_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾29_鱗左3CP = new ColorP(this.X0Y0_尾29_鱗左3, this.尾29_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾29_鱗右3CP = new ColorP(this.X0Y0_尾29_鱗右3, this.尾29_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾29_鱗左2CP = new ColorP(this.X0Y0_尾29_鱗左2, this.尾29_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾29_鱗右2CP = new ColorP(this.X0Y0_尾29_鱗右2, this.尾29_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾29_鱗左1CP = new ColorP(this.X0Y0_尾29_鱗左1, this.尾29_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾29_鱗右1CP = new ColorP(this.X0Y0_尾29_鱗右1, this.尾29_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾28_尾CP = new ColorP(this.X0Y0_尾28_尾, this.尾28_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾28_鱗左3CP = new ColorP(this.X0Y0_尾28_鱗左3, this.尾28_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾28_鱗右3CP = new ColorP(this.X0Y0_尾28_鱗右3, this.尾28_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾28_鱗左2CP = new ColorP(this.X0Y0_尾28_鱗左2, this.尾28_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾28_鱗右2CP = new ColorP(this.X0Y0_尾28_鱗右2, this.尾28_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾28_鱗左1CP = new ColorP(this.X0Y0_尾28_鱗左1, this.尾28_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾28_鱗右1CP = new ColorP(this.X0Y0_尾28_鱗右1, this.尾28_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾27_尾CP = new ColorP(this.X0Y0_尾27_尾, this.尾27_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾27_鱗左3CP = new ColorP(this.X0Y0_尾27_鱗左3, this.尾27_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾27_鱗右3CP = new ColorP(this.X0Y0_尾27_鱗右3, this.尾27_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾27_鱗左2CP = new ColorP(this.X0Y0_尾27_鱗左2, this.尾27_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾27_鱗右2CP = new ColorP(this.X0Y0_尾27_鱗右2, this.尾27_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾27_鱗左1CP = new ColorP(this.X0Y0_尾27_鱗左1, this.尾27_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾27_鱗右1CP = new ColorP(this.X0Y0_尾27_鱗右1, this.尾27_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾26_尾CP = new ColorP(this.X0Y0_尾26_尾, this.尾26_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾26_鱗左3CP = new ColorP(this.X0Y0_尾26_鱗左3, this.尾26_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾26_鱗右3CP = new ColorP(this.X0Y0_尾26_鱗右3, this.尾26_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾26_鱗左2CP = new ColorP(this.X0Y0_尾26_鱗左2, this.尾26_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾26_鱗右2CP = new ColorP(this.X0Y0_尾26_鱗右2, this.尾26_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾26_鱗左1CP = new ColorP(this.X0Y0_尾26_鱗左1, this.尾26_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾26_鱗右1CP = new ColorP(this.X0Y0_尾26_鱗右1, this.尾26_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾25_尾CP = new ColorP(this.X0Y0_尾25_尾, this.尾25_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾25_鱗左3CP = new ColorP(this.X0Y0_尾25_鱗左3, this.尾25_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾25_鱗右3CP = new ColorP(this.X0Y0_尾25_鱗右3, this.尾25_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾25_鱗左2CP = new ColorP(this.X0Y0_尾25_鱗左2, this.尾25_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾25_鱗右2CP = new ColorP(this.X0Y0_尾25_鱗右2, this.尾25_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾25_鱗左1CP = new ColorP(this.X0Y0_尾25_鱗左1, this.尾25_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾25_鱗右1CP = new ColorP(this.X0Y0_尾25_鱗右1, this.尾25_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾24_尾CP = new ColorP(this.X0Y0_尾24_尾, this.尾24_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾24_鱗左3CP = new ColorP(this.X0Y0_尾24_鱗左3, this.尾24_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾24_鱗右3CP = new ColorP(this.X0Y0_尾24_鱗右3, this.尾24_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾24_鱗左2CP = new ColorP(this.X0Y0_尾24_鱗左2, this.尾24_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾24_鱗右2CP = new ColorP(this.X0Y0_尾24_鱗右2, this.尾24_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾24_鱗左1CP = new ColorP(this.X0Y0_尾24_鱗左1, this.尾24_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾24_鱗右1CP = new ColorP(this.X0Y0_尾24_鱗右1, this.尾24_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾23_尾CP = new ColorP(this.X0Y0_尾23_尾, this.尾23_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾23_鱗左3CP = new ColorP(this.X0Y0_尾23_鱗左3, this.尾23_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾23_鱗右3CP = new ColorP(this.X0Y0_尾23_鱗右3, this.尾23_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾23_鱗左2CP = new ColorP(this.X0Y0_尾23_鱗左2, this.尾23_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾23_鱗右2CP = new ColorP(this.X0Y0_尾23_鱗右2, this.尾23_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾23_鱗左1CP = new ColorP(this.X0Y0_尾23_鱗左1, this.尾23_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾23_鱗右1CP = new ColorP(this.X0Y0_尾23_鱗右1, this.尾23_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾22_尾CP = new ColorP(this.X0Y0_尾22_尾, this.尾22_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾22_鱗左3CP = new ColorP(this.X0Y0_尾22_鱗左3, this.尾22_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾22_鱗右3CP = new ColorP(this.X0Y0_尾22_鱗右3, this.尾22_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾22_鱗左2CP = new ColorP(this.X0Y0_尾22_鱗左2, this.尾22_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾22_鱗右2CP = new ColorP(this.X0Y0_尾22_鱗右2, this.尾22_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾22_鱗左1CP = new ColorP(this.X0Y0_尾22_鱗左1, this.尾22_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾22_鱗右1CP = new ColorP(this.X0Y0_尾22_鱗右1, this.尾22_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾21_尾CP = new ColorP(this.X0Y0_尾21_尾, this.尾21_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾21_鱗左3CP = new ColorP(this.X0Y0_尾21_鱗左3, this.尾21_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾21_鱗右3CP = new ColorP(this.X0Y0_尾21_鱗右3, this.尾21_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾21_鱗左2CP = new ColorP(this.X0Y0_尾21_鱗左2, this.尾21_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾21_鱗右2CP = new ColorP(this.X0Y0_尾21_鱗右2, this.尾21_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾21_鱗左1CP = new ColorP(this.X0Y0_尾21_鱗左1, this.尾21_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾21_鱗右1CP = new ColorP(this.X0Y0_尾21_鱗右1, this.尾21_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾20_尾CP = new ColorP(this.X0Y0_尾20_尾, this.尾20_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾20_鱗左3CP = new ColorP(this.X0Y0_尾20_鱗左3, this.尾20_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾20_鱗右3CP = new ColorP(this.X0Y0_尾20_鱗右3, this.尾20_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾20_鱗左2CP = new ColorP(this.X0Y0_尾20_鱗左2, this.尾20_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾20_鱗右2CP = new ColorP(this.X0Y0_尾20_鱗右2, this.尾20_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾20_鱗左1CP = new ColorP(this.X0Y0_尾20_鱗左1, this.尾20_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾20_鱗右1CP = new ColorP(this.X0Y0_尾20_鱗右1, this.尾20_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾19_尾CP = new ColorP(this.X0Y0_尾19_尾, this.尾19_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾19_鱗左3CP = new ColorP(this.X0Y0_尾19_鱗左3, this.尾19_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾19_鱗右3CP = new ColorP(this.X0Y0_尾19_鱗右3, this.尾19_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾19_鱗左2CP = new ColorP(this.X0Y0_尾19_鱗左2, this.尾19_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾19_鱗右2CP = new ColorP(this.X0Y0_尾19_鱗右2, this.尾19_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾19_鱗左1CP = new ColorP(this.X0Y0_尾19_鱗左1, this.尾19_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾19_鱗右1CP = new ColorP(this.X0Y0_尾19_鱗右1, this.尾19_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾18_尾CP = new ColorP(this.X0Y0_尾18_尾, this.尾18_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾18_鱗左3CP = new ColorP(this.X0Y0_尾18_鱗左3, this.尾18_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾18_鱗右3CP = new ColorP(this.X0Y0_尾18_鱗右3, this.尾18_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾18_鱗左2CP = new ColorP(this.X0Y0_尾18_鱗左2, this.尾18_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾18_鱗右2CP = new ColorP(this.X0Y0_尾18_鱗右2, this.尾18_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾18_鱗左1CP = new ColorP(this.X0Y0_尾18_鱗左1, this.尾18_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾18_鱗右1CP = new ColorP(this.X0Y0_尾18_鱗右1, this.尾18_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾17_尾CP = new ColorP(this.X0Y0_尾17_尾, this.尾17_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾17_鱗左3CP = new ColorP(this.X0Y0_尾17_鱗左3, this.尾17_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾17_鱗右3CP = new ColorP(this.X0Y0_尾17_鱗右3, this.尾17_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾17_鱗左2CP = new ColorP(this.X0Y0_尾17_鱗左2, this.尾17_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾17_鱗右2CP = new ColorP(this.X0Y0_尾17_鱗右2, this.尾17_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾17_鱗左1CP = new ColorP(this.X0Y0_尾17_鱗左1, this.尾17_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾17_鱗右1CP = new ColorP(this.X0Y0_尾17_鱗右1, this.尾17_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾16_尾CP = new ColorP(this.X0Y0_尾16_尾, this.尾16_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾16_鱗左3CP = new ColorP(this.X0Y0_尾16_鱗左3, this.尾16_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾16_鱗右3CP = new ColorP(this.X0Y0_尾16_鱗右3, this.尾16_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾16_鱗左2CP = new ColorP(this.X0Y0_尾16_鱗左2, this.尾16_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾16_鱗右2CP = new ColorP(this.X0Y0_尾16_鱗右2, this.尾16_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾16_鱗左1CP = new ColorP(this.X0Y0_尾16_鱗左1, this.尾16_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾16_鱗右1CP = new ColorP(this.X0Y0_尾16_鱗右1, this.尾16_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾15_尾CP = new ColorP(this.X0Y0_尾15_尾, this.尾15_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾15_鱗左3CP = new ColorP(this.X0Y0_尾15_鱗左3, this.尾15_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾15_鱗右3CP = new ColorP(this.X0Y0_尾15_鱗右3, this.尾15_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾15_鱗左2CP = new ColorP(this.X0Y0_尾15_鱗左2, this.尾15_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾15_鱗右2CP = new ColorP(this.X0Y0_尾15_鱗右2, this.尾15_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾15_鱗左1CP = new ColorP(this.X0Y0_尾15_鱗左1, this.尾15_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾15_鱗右1CP = new ColorP(this.X0Y0_尾15_鱗右1, this.尾15_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾14_尾CP = new ColorP(this.X0Y0_尾14_尾, this.尾14_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾14_鱗左3CP = new ColorP(this.X0Y0_尾14_鱗左3, this.尾14_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾14_鱗右3CP = new ColorP(this.X0Y0_尾14_鱗右3, this.尾14_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾14_鱗左2CP = new ColorP(this.X0Y0_尾14_鱗左2, this.尾14_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾14_鱗右2CP = new ColorP(this.X0Y0_尾14_鱗右2, this.尾14_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾14_鱗左1CP = new ColorP(this.X0Y0_尾14_鱗左1, this.尾14_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾14_鱗右1CP = new ColorP(this.X0Y0_尾14_鱗右1, this.尾14_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾13_尾CP = new ColorP(this.X0Y0_尾13_尾, this.尾13_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾13_鱗左3CP = new ColorP(this.X0Y0_尾13_鱗左3, this.尾13_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾13_鱗右3CP = new ColorP(this.X0Y0_尾13_鱗右3, this.尾13_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾13_鱗左2CP = new ColorP(this.X0Y0_尾13_鱗左2, this.尾13_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾13_鱗右2CP = new ColorP(this.X0Y0_尾13_鱗右2, this.尾13_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾13_鱗左1CP = new ColorP(this.X0Y0_尾13_鱗左1, this.尾13_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾13_鱗右1CP = new ColorP(this.X0Y0_尾13_鱗右1, this.尾13_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾12_尾CP = new ColorP(this.X0Y0_尾12_尾, this.尾12_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾12_鱗左3CP = new ColorP(this.X0Y0_尾12_鱗左3, this.尾12_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾12_鱗右3CP = new ColorP(this.X0Y0_尾12_鱗右3, this.尾12_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾12_鱗左2CP = new ColorP(this.X0Y0_尾12_鱗左2, this.尾12_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾12_鱗右2CP = new ColorP(this.X0Y0_尾12_鱗右2, this.尾12_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾12_鱗左1CP = new ColorP(this.X0Y0_尾12_鱗左1, this.尾12_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾12_鱗右1CP = new ColorP(this.X0Y0_尾12_鱗右1, this.尾12_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾11_尾CP = new ColorP(this.X0Y0_尾11_尾, this.尾11_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾11_鱗左3CP = new ColorP(this.X0Y0_尾11_鱗左3, this.尾11_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾11_鱗右3CP = new ColorP(this.X0Y0_尾11_鱗右3, this.尾11_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾11_鱗左2CP = new ColorP(this.X0Y0_尾11_鱗左2, this.尾11_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾11_鱗右2CP = new ColorP(this.X0Y0_尾11_鱗右2, this.尾11_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾11_鱗左1CP = new ColorP(this.X0Y0_尾11_鱗左1, this.尾11_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾11_鱗右1CP = new ColorP(this.X0Y0_尾11_鱗右1, this.尾11_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾10_尾CP = new ColorP(this.X0Y0_尾10_尾, this.尾10_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾10_鱗左3CP = new ColorP(this.X0Y0_尾10_鱗左3, this.尾10_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾10_鱗右3CP = new ColorP(this.X0Y0_尾10_鱗右3, this.尾10_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾10_鱗左2CP = new ColorP(this.X0Y0_尾10_鱗左2, this.尾10_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾10_鱗右2CP = new ColorP(this.X0Y0_尾10_鱗右2, this.尾10_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾10_鱗左1CP = new ColorP(this.X0Y0_尾10_鱗左1, this.尾10_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾10_鱗右1CP = new ColorP(this.X0Y0_尾10_鱗右1, this.尾10_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾9_尾CP = new ColorP(this.X0Y0_尾9_尾, this.尾9_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾9_鱗左3CP = new ColorP(this.X0Y0_尾9_鱗左3, this.尾9_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾9_鱗右3CP = new ColorP(this.X0Y0_尾9_鱗右3, this.尾9_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾9_鱗左2CP = new ColorP(this.X0Y0_尾9_鱗左2, this.尾9_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾9_鱗右2CP = new ColorP(this.X0Y0_尾9_鱗右2, this.尾9_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾9_鱗左1CP = new ColorP(this.X0Y0_尾9_鱗左1, this.尾9_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾9_鱗右1CP = new ColorP(this.X0Y0_尾9_鱗右1, this.尾9_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾8_尾CP = new ColorP(this.X0Y0_尾8_尾, this.尾8_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾8_鱗左3CP = new ColorP(this.X0Y0_尾8_鱗左3, this.尾8_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾8_鱗右3CP = new ColorP(this.X0Y0_尾8_鱗右3, this.尾8_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾8_鱗左2CP = new ColorP(this.X0Y0_尾8_鱗左2, this.尾8_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾8_鱗右2CP = new ColorP(this.X0Y0_尾8_鱗右2, this.尾8_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾8_鱗左1CP = new ColorP(this.X0Y0_尾8_鱗左1, this.尾8_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾8_鱗右1CP = new ColorP(this.X0Y0_尾8_鱗右1, this.尾8_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾7_尾CP = new ColorP(this.X0Y0_尾7_尾, this.尾7_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾7_鱗左3CP = new ColorP(this.X0Y0_尾7_鱗左3, this.尾7_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾7_鱗右3CP = new ColorP(this.X0Y0_尾7_鱗右3, this.尾7_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾7_鱗左2CP = new ColorP(this.X0Y0_尾7_鱗左2, this.尾7_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾7_鱗右2CP = new ColorP(this.X0Y0_尾7_鱗右2, this.尾7_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾7_鱗左1CP = new ColorP(this.X0Y0_尾7_鱗左1, this.尾7_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾7_鱗右1CP = new ColorP(this.X0Y0_尾7_鱗右1, this.尾7_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾6_尾CP = new ColorP(this.X0Y0_尾6_尾, this.尾6_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾6_鱗左3CP = new ColorP(this.X0Y0_尾6_鱗左3, this.尾6_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾6_鱗右3CP = new ColorP(this.X0Y0_尾6_鱗右3, this.尾6_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾6_鱗左2CP = new ColorP(this.X0Y0_尾6_鱗左2, this.尾6_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾6_鱗右2CP = new ColorP(this.X0Y0_尾6_鱗右2, this.尾6_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾6_鱗左1CP = new ColorP(this.X0Y0_尾6_鱗左1, this.尾6_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾6_鱗右1CP = new ColorP(this.X0Y0_尾6_鱗右1, this.尾6_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾5_尾CP = new ColorP(this.X0Y0_尾5_尾, this.尾5_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾5_鱗左3CP = new ColorP(this.X0Y0_尾5_鱗左3, this.尾5_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾5_鱗右3CP = new ColorP(this.X0Y0_尾5_鱗右3, this.尾5_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾5_鱗左2CP = new ColorP(this.X0Y0_尾5_鱗左2, this.尾5_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾5_鱗右2CP = new ColorP(this.X0Y0_尾5_鱗右2, this.尾5_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾5_鱗左1CP = new ColorP(this.X0Y0_尾5_鱗左1, this.尾5_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾5_鱗右1CP = new ColorP(this.X0Y0_尾5_鱗右1, this.尾5_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_尾CP = new ColorP(this.X0Y0_尾4_尾, this.尾4_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_鱗左3CP = new ColorP(this.X0Y0_尾4_鱗左3, this.尾4_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_鱗右3CP = new ColorP(this.X0Y0_尾4_鱗右3, this.尾4_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_鱗左2CP = new ColorP(this.X0Y0_尾4_鱗左2, this.尾4_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_鱗右2CP = new ColorP(this.X0Y0_尾4_鱗右2, this.尾4_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_鱗左1CP = new ColorP(this.X0Y0_尾4_鱗左1, this.尾4_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_鱗右1CP = new ColorP(this.X0Y0_尾4_鱗右1, this.尾4_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_尾CP = new ColorP(this.X0Y0_尾3_尾, this.尾3_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_鱗左3CP = new ColorP(this.X0Y0_尾3_鱗左3, this.尾3_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_鱗右3CP = new ColorP(this.X0Y0_尾3_鱗右3, this.尾3_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_鱗左2CP = new ColorP(this.X0Y0_尾3_鱗左2, this.尾3_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_鱗右2CP = new ColorP(this.X0Y0_尾3_鱗右2, this.尾3_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_鱗左1CP = new ColorP(this.X0Y0_尾3_鱗左1, this.尾3_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_鱗右1CP = new ColorP(this.X0Y0_尾3_鱗右1, this.尾3_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_尾CP = new ColorP(this.X0Y0_尾2_尾, this.尾2_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_鱗左3CP = new ColorP(this.X0Y0_尾2_鱗左3, this.尾2_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_鱗右3CP = new ColorP(this.X0Y0_尾2_鱗右3, this.尾2_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_鱗左2CP = new ColorP(this.X0Y0_尾2_鱗左2, this.尾2_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_鱗右2CP = new ColorP(this.X0Y0_尾2_鱗右2, this.尾2_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_鱗左1CP = new ColorP(this.X0Y0_尾2_鱗左1, this.尾2_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_鱗右1CP = new ColorP(this.X0Y0_尾2_鱗右1, this.尾2_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_尾CP = new ColorP(this.X0Y0_尾1_尾, this.尾1_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_鱗左3CP = new ColorP(this.X0Y0_尾1_鱗左3, this.尾1_鱗左3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_鱗右3CP = new ColorP(this.X0Y0_尾1_鱗右3, this.尾1_鱗右3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_鱗左2CP = new ColorP(this.X0Y0_尾1_鱗左2, this.尾1_鱗左2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_鱗右2CP = new ColorP(this.X0Y0_尾1_鱗右2, this.尾1_鱗右2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_鱗左1CP = new ColorP(this.X0Y0_尾1_鱗左1, this.尾1_鱗左1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_鱗右1CP = new ColorP(this.X0Y0_尾1_鱗右1, this.尾1_鱗右1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾0_尾CP = new ColorP(this.X0Y0_尾0_尾, this.尾0_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾0_鱗右CP = new ColorP(this.X0Y0_尾0_鱗右, this.尾0_鱗右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾0_鱗左CP = new ColorP(this.X0Y0_尾0_鱗左, this.尾0_鱗左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪1_革CP = new ColorP(this.X0Y0_輪1_革, this.輪1_革CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪1_金具1CP = new ColorP(this.X0Y0_輪1_金具1, this.輪1_金具1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪1_金具2CP = new ColorP(this.X0Y0_輪1_金具2, this.輪1_金具2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪1_金具3CP = new ColorP(this.X0Y0_輪1_金具3, this.輪1_金具3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪1_金具左CP = new ColorP(this.X0Y0_輪1_金具左, this.輪1_金具左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪1_金具右CP = new ColorP(this.X0Y0_輪1_金具右, this.輪1_金具右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_革CP = new ColorP(this.X0Y0_輪2_革, this.輪2_革CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_金具1CP = new ColorP(this.X0Y0_輪2_金具1, this.輪2_金具1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_金具2CP = new ColorP(this.X0Y0_輪2_金具2, this.輪2_金具2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_金具3CP = new ColorP(this.X0Y0_輪2_金具3, this.輪2_金具3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_金具左CP = new ColorP(this.X0Y0_輪2_金具左, this.輪2_金具左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_金具右CP = new ColorP(this.X0Y0_輪2_金具右, this.輪2_金具右CD, CS$<>8__locals1.DisUnit, true);
			this.濃度 = e.濃度;
			this.鎖1 = new 拘束鎖(CS$<>8__locals1.DisUnit, this.右, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖2 = new 拘束鎖(CS$<>8__locals1.DisUnit, !this.右, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖3 = new 拘束鎖(CS$<>8__locals1.DisUnit, this.右, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖4 = new 拘束鎖(CS$<>8__locals1.DisUnit, !this.右, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
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

		public bool 尾35_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾35_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾35_鱗左3.Dra = value;
				this.X0Y0_尾35_鱗左3.Hit = value;
			}
		}

		public bool 尾35_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾35_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾35_鱗右3.Dra = value;
				this.X0Y0_尾35_鱗右3.Hit = value;
			}
		}

		public bool 尾35_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾35_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾35_鱗左2.Dra = value;
				this.X0Y0_尾35_鱗左2.Hit = value;
			}
		}

		public bool 尾35_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾35_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾35_鱗右2.Dra = value;
				this.X0Y0_尾35_鱗右2.Hit = value;
			}
		}

		public bool 尾35_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾35_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾35_鱗左1.Dra = value;
				this.X0Y0_尾35_鱗左1.Hit = value;
			}
		}

		public bool 尾35_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾35_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾35_鱗右1.Dra = value;
				this.X0Y0_尾35_鱗右1.Hit = value;
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

		public bool 尾34_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾34_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾34_鱗左3.Dra = value;
				this.X0Y0_尾34_鱗左3.Hit = value;
			}
		}

		public bool 尾34_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾34_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾34_鱗右3.Dra = value;
				this.X0Y0_尾34_鱗右3.Hit = value;
			}
		}

		public bool 尾34_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾34_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾34_鱗左2.Dra = value;
				this.X0Y0_尾34_鱗左2.Hit = value;
			}
		}

		public bool 尾34_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾34_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾34_鱗右2.Dra = value;
				this.X0Y0_尾34_鱗右2.Hit = value;
			}
		}

		public bool 尾34_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾34_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾34_鱗左1.Dra = value;
				this.X0Y0_尾34_鱗左1.Hit = value;
			}
		}

		public bool 尾34_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾34_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾34_鱗右1.Dra = value;
				this.X0Y0_尾34_鱗右1.Hit = value;
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

		public bool 尾33_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾33_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾33_鱗左3.Dra = value;
				this.X0Y0_尾33_鱗左3.Hit = value;
			}
		}

		public bool 尾33_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾33_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾33_鱗右3.Dra = value;
				this.X0Y0_尾33_鱗右3.Hit = value;
			}
		}

		public bool 尾33_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾33_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾33_鱗左2.Dra = value;
				this.X0Y0_尾33_鱗左2.Hit = value;
			}
		}

		public bool 尾33_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾33_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾33_鱗右2.Dra = value;
				this.X0Y0_尾33_鱗右2.Hit = value;
			}
		}

		public bool 尾33_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾33_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾33_鱗左1.Dra = value;
				this.X0Y0_尾33_鱗左1.Hit = value;
			}
		}

		public bool 尾33_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾33_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾33_鱗右1.Dra = value;
				this.X0Y0_尾33_鱗右1.Hit = value;
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

		public bool 尾32_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾32_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾32_鱗左3.Dra = value;
				this.X0Y0_尾32_鱗左3.Hit = value;
			}
		}

		public bool 尾32_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾32_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾32_鱗右3.Dra = value;
				this.X0Y0_尾32_鱗右3.Hit = value;
			}
		}

		public bool 尾32_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾32_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾32_鱗左2.Dra = value;
				this.X0Y0_尾32_鱗左2.Hit = value;
			}
		}

		public bool 尾32_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾32_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾32_鱗右2.Dra = value;
				this.X0Y0_尾32_鱗右2.Hit = value;
			}
		}

		public bool 尾32_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾32_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾32_鱗左1.Dra = value;
				this.X0Y0_尾32_鱗左1.Hit = value;
			}
		}

		public bool 尾32_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾32_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾32_鱗右1.Dra = value;
				this.X0Y0_尾32_鱗右1.Hit = value;
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

		public bool 尾31_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾31_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾31_鱗左3.Dra = value;
				this.X0Y0_尾31_鱗左3.Hit = value;
			}
		}

		public bool 尾31_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾31_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾31_鱗右3.Dra = value;
				this.X0Y0_尾31_鱗右3.Hit = value;
			}
		}

		public bool 尾31_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾31_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾31_鱗左2.Dra = value;
				this.X0Y0_尾31_鱗左2.Hit = value;
			}
		}

		public bool 尾31_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾31_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾31_鱗右2.Dra = value;
				this.X0Y0_尾31_鱗右2.Hit = value;
			}
		}

		public bool 尾31_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾31_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾31_鱗左1.Dra = value;
				this.X0Y0_尾31_鱗左1.Hit = value;
			}
		}

		public bool 尾31_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾31_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾31_鱗右1.Dra = value;
				this.X0Y0_尾31_鱗右1.Hit = value;
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

		public bool 尾30_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾30_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾30_鱗左3.Dra = value;
				this.X0Y0_尾30_鱗左3.Hit = value;
			}
		}

		public bool 尾30_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾30_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾30_鱗右3.Dra = value;
				this.X0Y0_尾30_鱗右3.Hit = value;
			}
		}

		public bool 尾30_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾30_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾30_鱗左2.Dra = value;
				this.X0Y0_尾30_鱗左2.Hit = value;
			}
		}

		public bool 尾30_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾30_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾30_鱗右2.Dra = value;
				this.X0Y0_尾30_鱗右2.Hit = value;
			}
		}

		public bool 尾30_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾30_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾30_鱗左1.Dra = value;
				this.X0Y0_尾30_鱗左1.Hit = value;
			}
		}

		public bool 尾30_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾30_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾30_鱗右1.Dra = value;
				this.X0Y0_尾30_鱗右1.Hit = value;
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

		public bool 尾29_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾29_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾29_鱗左3.Dra = value;
				this.X0Y0_尾29_鱗左3.Hit = value;
			}
		}

		public bool 尾29_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾29_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾29_鱗右3.Dra = value;
				this.X0Y0_尾29_鱗右3.Hit = value;
			}
		}

		public bool 尾29_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾29_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾29_鱗左2.Dra = value;
				this.X0Y0_尾29_鱗左2.Hit = value;
			}
		}

		public bool 尾29_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾29_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾29_鱗右2.Dra = value;
				this.X0Y0_尾29_鱗右2.Hit = value;
			}
		}

		public bool 尾29_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾29_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾29_鱗左1.Dra = value;
				this.X0Y0_尾29_鱗左1.Hit = value;
			}
		}

		public bool 尾29_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾29_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾29_鱗右1.Dra = value;
				this.X0Y0_尾29_鱗右1.Hit = value;
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

		public bool 尾28_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾28_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾28_鱗左3.Dra = value;
				this.X0Y0_尾28_鱗左3.Hit = value;
			}
		}

		public bool 尾28_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾28_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾28_鱗右3.Dra = value;
				this.X0Y0_尾28_鱗右3.Hit = value;
			}
		}

		public bool 尾28_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾28_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾28_鱗左2.Dra = value;
				this.X0Y0_尾28_鱗左2.Hit = value;
			}
		}

		public bool 尾28_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾28_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾28_鱗右2.Dra = value;
				this.X0Y0_尾28_鱗右2.Hit = value;
			}
		}

		public bool 尾28_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾28_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾28_鱗左1.Dra = value;
				this.X0Y0_尾28_鱗左1.Hit = value;
			}
		}

		public bool 尾28_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾28_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾28_鱗右1.Dra = value;
				this.X0Y0_尾28_鱗右1.Hit = value;
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

		public bool 尾27_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾27_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾27_鱗左3.Dra = value;
				this.X0Y0_尾27_鱗左3.Hit = value;
			}
		}

		public bool 尾27_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾27_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾27_鱗右3.Dra = value;
				this.X0Y0_尾27_鱗右3.Hit = value;
			}
		}

		public bool 尾27_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾27_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾27_鱗左2.Dra = value;
				this.X0Y0_尾27_鱗左2.Hit = value;
			}
		}

		public bool 尾27_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾27_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾27_鱗右2.Dra = value;
				this.X0Y0_尾27_鱗右2.Hit = value;
			}
		}

		public bool 尾27_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾27_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾27_鱗左1.Dra = value;
				this.X0Y0_尾27_鱗左1.Hit = value;
			}
		}

		public bool 尾27_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾27_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾27_鱗右1.Dra = value;
				this.X0Y0_尾27_鱗右1.Hit = value;
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

		public bool 尾26_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾26_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾26_鱗左3.Dra = value;
				this.X0Y0_尾26_鱗左3.Hit = value;
			}
		}

		public bool 尾26_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾26_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾26_鱗右3.Dra = value;
				this.X0Y0_尾26_鱗右3.Hit = value;
			}
		}

		public bool 尾26_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾26_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾26_鱗左2.Dra = value;
				this.X0Y0_尾26_鱗左2.Hit = value;
			}
		}

		public bool 尾26_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾26_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾26_鱗右2.Dra = value;
				this.X0Y0_尾26_鱗右2.Hit = value;
			}
		}

		public bool 尾26_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾26_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾26_鱗左1.Dra = value;
				this.X0Y0_尾26_鱗左1.Hit = value;
			}
		}

		public bool 尾26_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾26_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾26_鱗右1.Dra = value;
				this.X0Y0_尾26_鱗右1.Hit = value;
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

		public bool 尾25_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾25_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾25_鱗左3.Dra = value;
				this.X0Y0_尾25_鱗左3.Hit = value;
			}
		}

		public bool 尾25_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾25_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾25_鱗右3.Dra = value;
				this.X0Y0_尾25_鱗右3.Hit = value;
			}
		}

		public bool 尾25_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾25_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾25_鱗左2.Dra = value;
				this.X0Y0_尾25_鱗左2.Hit = value;
			}
		}

		public bool 尾25_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾25_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾25_鱗右2.Dra = value;
				this.X0Y0_尾25_鱗右2.Hit = value;
			}
		}

		public bool 尾25_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾25_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾25_鱗左1.Dra = value;
				this.X0Y0_尾25_鱗左1.Hit = value;
			}
		}

		public bool 尾25_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾25_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾25_鱗右1.Dra = value;
				this.X0Y0_尾25_鱗右1.Hit = value;
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

		public bool 尾24_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾24_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾24_鱗左3.Dra = value;
				this.X0Y0_尾24_鱗左3.Hit = value;
			}
		}

		public bool 尾24_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾24_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾24_鱗右3.Dra = value;
				this.X0Y0_尾24_鱗右3.Hit = value;
			}
		}

		public bool 尾24_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾24_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾24_鱗左2.Dra = value;
				this.X0Y0_尾24_鱗左2.Hit = value;
			}
		}

		public bool 尾24_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾24_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾24_鱗右2.Dra = value;
				this.X0Y0_尾24_鱗右2.Hit = value;
			}
		}

		public bool 尾24_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾24_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾24_鱗左1.Dra = value;
				this.X0Y0_尾24_鱗左1.Hit = value;
			}
		}

		public bool 尾24_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾24_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾24_鱗右1.Dra = value;
				this.X0Y0_尾24_鱗右1.Hit = value;
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

		public bool 尾23_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾23_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾23_鱗左3.Dra = value;
				this.X0Y0_尾23_鱗左3.Hit = value;
			}
		}

		public bool 尾23_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾23_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾23_鱗右3.Dra = value;
				this.X0Y0_尾23_鱗右3.Hit = value;
			}
		}

		public bool 尾23_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾23_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾23_鱗左2.Dra = value;
				this.X0Y0_尾23_鱗左2.Hit = value;
			}
		}

		public bool 尾23_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾23_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾23_鱗右2.Dra = value;
				this.X0Y0_尾23_鱗右2.Hit = value;
			}
		}

		public bool 尾23_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾23_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾23_鱗左1.Dra = value;
				this.X0Y0_尾23_鱗左1.Hit = value;
			}
		}

		public bool 尾23_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾23_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾23_鱗右1.Dra = value;
				this.X0Y0_尾23_鱗右1.Hit = value;
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

		public bool 尾22_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾22_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾22_鱗左3.Dra = value;
				this.X0Y0_尾22_鱗左3.Hit = value;
			}
		}

		public bool 尾22_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾22_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾22_鱗右3.Dra = value;
				this.X0Y0_尾22_鱗右3.Hit = value;
			}
		}

		public bool 尾22_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾22_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾22_鱗左2.Dra = value;
				this.X0Y0_尾22_鱗左2.Hit = value;
			}
		}

		public bool 尾22_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾22_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾22_鱗右2.Dra = value;
				this.X0Y0_尾22_鱗右2.Hit = value;
			}
		}

		public bool 尾22_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾22_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾22_鱗左1.Dra = value;
				this.X0Y0_尾22_鱗左1.Hit = value;
			}
		}

		public bool 尾22_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾22_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾22_鱗右1.Dra = value;
				this.X0Y0_尾22_鱗右1.Hit = value;
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

		public bool 尾21_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾21_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾21_鱗左3.Dra = value;
				this.X0Y0_尾21_鱗左3.Hit = value;
			}
		}

		public bool 尾21_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾21_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾21_鱗右3.Dra = value;
				this.X0Y0_尾21_鱗右3.Hit = value;
			}
		}

		public bool 尾21_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾21_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾21_鱗左2.Dra = value;
				this.X0Y0_尾21_鱗左2.Hit = value;
			}
		}

		public bool 尾21_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾21_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾21_鱗右2.Dra = value;
				this.X0Y0_尾21_鱗右2.Hit = value;
			}
		}

		public bool 尾21_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾21_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾21_鱗左1.Dra = value;
				this.X0Y0_尾21_鱗左1.Hit = value;
			}
		}

		public bool 尾21_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾21_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾21_鱗右1.Dra = value;
				this.X0Y0_尾21_鱗右1.Hit = value;
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

		public bool 尾20_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾20_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾20_鱗左3.Dra = value;
				this.X0Y0_尾20_鱗左3.Hit = value;
			}
		}

		public bool 尾20_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾20_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾20_鱗右3.Dra = value;
				this.X0Y0_尾20_鱗右3.Hit = value;
			}
		}

		public bool 尾20_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾20_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾20_鱗左2.Dra = value;
				this.X0Y0_尾20_鱗左2.Hit = value;
			}
		}

		public bool 尾20_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾20_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾20_鱗右2.Dra = value;
				this.X0Y0_尾20_鱗右2.Hit = value;
			}
		}

		public bool 尾20_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾20_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾20_鱗左1.Dra = value;
				this.X0Y0_尾20_鱗左1.Hit = value;
			}
		}

		public bool 尾20_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾20_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾20_鱗右1.Dra = value;
				this.X0Y0_尾20_鱗右1.Hit = value;
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

		public bool 尾19_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾19_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾19_鱗左3.Dra = value;
				this.X0Y0_尾19_鱗左3.Hit = value;
			}
		}

		public bool 尾19_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾19_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾19_鱗右3.Dra = value;
				this.X0Y0_尾19_鱗右3.Hit = value;
			}
		}

		public bool 尾19_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾19_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾19_鱗左2.Dra = value;
				this.X0Y0_尾19_鱗左2.Hit = value;
			}
		}

		public bool 尾19_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾19_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾19_鱗右2.Dra = value;
				this.X0Y0_尾19_鱗右2.Hit = value;
			}
		}

		public bool 尾19_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾19_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾19_鱗左1.Dra = value;
				this.X0Y0_尾19_鱗左1.Hit = value;
			}
		}

		public bool 尾19_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾19_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾19_鱗右1.Dra = value;
				this.X0Y0_尾19_鱗右1.Hit = value;
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

		public bool 尾18_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾18_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾18_鱗左3.Dra = value;
				this.X0Y0_尾18_鱗左3.Hit = value;
			}
		}

		public bool 尾18_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾18_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾18_鱗右3.Dra = value;
				this.X0Y0_尾18_鱗右3.Hit = value;
			}
		}

		public bool 尾18_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾18_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾18_鱗左2.Dra = value;
				this.X0Y0_尾18_鱗左2.Hit = value;
			}
		}

		public bool 尾18_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾18_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾18_鱗右2.Dra = value;
				this.X0Y0_尾18_鱗右2.Hit = value;
			}
		}

		public bool 尾18_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾18_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾18_鱗左1.Dra = value;
				this.X0Y0_尾18_鱗左1.Hit = value;
			}
		}

		public bool 尾18_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾18_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾18_鱗右1.Dra = value;
				this.X0Y0_尾18_鱗右1.Hit = value;
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

		public bool 尾17_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾17_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾17_鱗左3.Dra = value;
				this.X0Y0_尾17_鱗左3.Hit = value;
			}
		}

		public bool 尾17_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾17_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾17_鱗右3.Dra = value;
				this.X0Y0_尾17_鱗右3.Hit = value;
			}
		}

		public bool 尾17_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾17_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾17_鱗左2.Dra = value;
				this.X0Y0_尾17_鱗左2.Hit = value;
			}
		}

		public bool 尾17_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾17_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾17_鱗右2.Dra = value;
				this.X0Y0_尾17_鱗右2.Hit = value;
			}
		}

		public bool 尾17_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾17_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾17_鱗左1.Dra = value;
				this.X0Y0_尾17_鱗左1.Hit = value;
			}
		}

		public bool 尾17_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾17_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾17_鱗右1.Dra = value;
				this.X0Y0_尾17_鱗右1.Hit = value;
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

		public bool 尾16_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾16_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾16_鱗左3.Dra = value;
				this.X0Y0_尾16_鱗左3.Hit = value;
			}
		}

		public bool 尾16_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾16_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾16_鱗右3.Dra = value;
				this.X0Y0_尾16_鱗右3.Hit = value;
			}
		}

		public bool 尾16_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾16_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾16_鱗左2.Dra = value;
				this.X0Y0_尾16_鱗左2.Hit = value;
			}
		}

		public bool 尾16_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾16_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾16_鱗右2.Dra = value;
				this.X0Y0_尾16_鱗右2.Hit = value;
			}
		}

		public bool 尾16_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾16_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾16_鱗左1.Dra = value;
				this.X0Y0_尾16_鱗左1.Hit = value;
			}
		}

		public bool 尾16_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾16_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾16_鱗右1.Dra = value;
				this.X0Y0_尾16_鱗右1.Hit = value;
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

		public bool 尾15_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾15_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾15_鱗左3.Dra = value;
				this.X0Y0_尾15_鱗左3.Hit = value;
			}
		}

		public bool 尾15_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾15_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾15_鱗右3.Dra = value;
				this.X0Y0_尾15_鱗右3.Hit = value;
			}
		}

		public bool 尾15_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾15_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾15_鱗左2.Dra = value;
				this.X0Y0_尾15_鱗左2.Hit = value;
			}
		}

		public bool 尾15_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾15_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾15_鱗右2.Dra = value;
				this.X0Y0_尾15_鱗右2.Hit = value;
			}
		}

		public bool 尾15_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾15_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾15_鱗左1.Dra = value;
				this.X0Y0_尾15_鱗左1.Hit = value;
			}
		}

		public bool 尾15_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾15_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾15_鱗右1.Dra = value;
				this.X0Y0_尾15_鱗右1.Hit = value;
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

		public bool 尾14_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾14_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾14_鱗左3.Dra = value;
				this.X0Y0_尾14_鱗左3.Hit = value;
			}
		}

		public bool 尾14_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾14_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾14_鱗右3.Dra = value;
				this.X0Y0_尾14_鱗右3.Hit = value;
			}
		}

		public bool 尾14_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾14_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾14_鱗左2.Dra = value;
				this.X0Y0_尾14_鱗左2.Hit = value;
			}
		}

		public bool 尾14_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾14_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾14_鱗右2.Dra = value;
				this.X0Y0_尾14_鱗右2.Hit = value;
			}
		}

		public bool 尾14_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾14_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾14_鱗左1.Dra = value;
				this.X0Y0_尾14_鱗左1.Hit = value;
			}
		}

		public bool 尾14_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾14_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾14_鱗右1.Dra = value;
				this.X0Y0_尾14_鱗右1.Hit = value;
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

		public bool 尾13_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾13_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾13_鱗左3.Dra = value;
				this.X0Y0_尾13_鱗左3.Hit = value;
			}
		}

		public bool 尾13_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾13_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾13_鱗右3.Dra = value;
				this.X0Y0_尾13_鱗右3.Hit = value;
			}
		}

		public bool 尾13_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾13_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾13_鱗左2.Dra = value;
				this.X0Y0_尾13_鱗左2.Hit = value;
			}
		}

		public bool 尾13_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾13_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾13_鱗右2.Dra = value;
				this.X0Y0_尾13_鱗右2.Hit = value;
			}
		}

		public bool 尾13_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾13_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾13_鱗左1.Dra = value;
				this.X0Y0_尾13_鱗左1.Hit = value;
			}
		}

		public bool 尾13_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾13_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾13_鱗右1.Dra = value;
				this.X0Y0_尾13_鱗右1.Hit = value;
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

		public bool 尾12_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾12_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾12_鱗左3.Dra = value;
				this.X0Y0_尾12_鱗左3.Hit = value;
			}
		}

		public bool 尾12_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾12_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾12_鱗右3.Dra = value;
				this.X0Y0_尾12_鱗右3.Hit = value;
			}
		}

		public bool 尾12_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾12_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾12_鱗左2.Dra = value;
				this.X0Y0_尾12_鱗左2.Hit = value;
			}
		}

		public bool 尾12_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾12_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾12_鱗右2.Dra = value;
				this.X0Y0_尾12_鱗右2.Hit = value;
			}
		}

		public bool 尾12_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾12_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾12_鱗左1.Dra = value;
				this.X0Y0_尾12_鱗左1.Hit = value;
			}
		}

		public bool 尾12_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾12_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾12_鱗右1.Dra = value;
				this.X0Y0_尾12_鱗右1.Hit = value;
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

		public bool 尾11_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾11_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾11_鱗左3.Dra = value;
				this.X0Y0_尾11_鱗左3.Hit = value;
			}
		}

		public bool 尾11_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾11_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾11_鱗右3.Dra = value;
				this.X0Y0_尾11_鱗右3.Hit = value;
			}
		}

		public bool 尾11_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾11_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾11_鱗左2.Dra = value;
				this.X0Y0_尾11_鱗左2.Hit = value;
			}
		}

		public bool 尾11_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾11_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾11_鱗右2.Dra = value;
				this.X0Y0_尾11_鱗右2.Hit = value;
			}
		}

		public bool 尾11_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾11_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾11_鱗左1.Dra = value;
				this.X0Y0_尾11_鱗左1.Hit = value;
			}
		}

		public bool 尾11_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾11_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾11_鱗右1.Dra = value;
				this.X0Y0_尾11_鱗右1.Hit = value;
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

		public bool 尾10_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾10_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾10_鱗左3.Dra = value;
				this.X0Y0_尾10_鱗左3.Hit = value;
			}
		}

		public bool 尾10_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾10_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾10_鱗右3.Dra = value;
				this.X0Y0_尾10_鱗右3.Hit = value;
			}
		}

		public bool 尾10_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾10_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾10_鱗左2.Dra = value;
				this.X0Y0_尾10_鱗左2.Hit = value;
			}
		}

		public bool 尾10_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾10_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾10_鱗右2.Dra = value;
				this.X0Y0_尾10_鱗右2.Hit = value;
			}
		}

		public bool 尾10_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾10_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾10_鱗左1.Dra = value;
				this.X0Y0_尾10_鱗左1.Hit = value;
			}
		}

		public bool 尾10_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾10_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾10_鱗右1.Dra = value;
				this.X0Y0_尾10_鱗右1.Hit = value;
			}
		}

		public bool 尾9_表示
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

		public bool 尾9_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾9_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾9_鱗左3.Dra = value;
				this.X0Y0_尾9_鱗左3.Hit = value;
			}
		}

		public bool 尾9_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾9_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾9_鱗右3.Dra = value;
				this.X0Y0_尾9_鱗右3.Hit = value;
			}
		}

		public bool 尾9_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾9_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾9_鱗左2.Dra = value;
				this.X0Y0_尾9_鱗左2.Hit = value;
			}
		}

		public bool 尾9_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾9_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾9_鱗右2.Dra = value;
				this.X0Y0_尾9_鱗右2.Hit = value;
			}
		}

		public bool 尾9_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾9_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾9_鱗左1.Dra = value;
				this.X0Y0_尾9_鱗左1.Hit = value;
			}
		}

		public bool 尾9_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾9_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾9_鱗右1.Dra = value;
				this.X0Y0_尾9_鱗右1.Hit = value;
			}
		}

		public bool 尾8_表示
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

		public bool 尾8_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾8_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾8_鱗左3.Dra = value;
				this.X0Y0_尾8_鱗左3.Hit = value;
			}
		}

		public bool 尾8_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾8_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾8_鱗右3.Dra = value;
				this.X0Y0_尾8_鱗右3.Hit = value;
			}
		}

		public bool 尾8_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾8_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾8_鱗左2.Dra = value;
				this.X0Y0_尾8_鱗左2.Hit = value;
			}
		}

		public bool 尾8_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾8_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾8_鱗右2.Dra = value;
				this.X0Y0_尾8_鱗右2.Hit = value;
			}
		}

		public bool 尾8_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾8_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾8_鱗左1.Dra = value;
				this.X0Y0_尾8_鱗左1.Hit = value;
			}
		}

		public bool 尾8_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾8_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾8_鱗右1.Dra = value;
				this.X0Y0_尾8_鱗右1.Hit = value;
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

		public bool 尾7_表示
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

		public bool 尾7_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾7_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾7_鱗左3.Dra = value;
				this.X0Y0_尾7_鱗左3.Hit = value;
			}
		}

		public bool 尾7_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾7_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾7_鱗右3.Dra = value;
				this.X0Y0_尾7_鱗右3.Hit = value;
			}
		}

		public bool 尾7_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾7_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾7_鱗左2.Dra = value;
				this.X0Y0_尾7_鱗左2.Hit = value;
			}
		}

		public bool 尾7_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾7_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾7_鱗右2.Dra = value;
				this.X0Y0_尾7_鱗右2.Hit = value;
			}
		}

		public bool 尾7_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾7_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾7_鱗左1.Dra = value;
				this.X0Y0_尾7_鱗左1.Hit = value;
			}
		}

		public bool 尾7_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾7_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾7_鱗右1.Dra = value;
				this.X0Y0_尾7_鱗右1.Hit = value;
			}
		}

		public bool 尾6_表示
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

		public bool 尾6_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾6_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾6_鱗左3.Dra = value;
				this.X0Y0_尾6_鱗左3.Hit = value;
			}
		}

		public bool 尾6_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾6_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾6_鱗右3.Dra = value;
				this.X0Y0_尾6_鱗右3.Hit = value;
			}
		}

		public bool 尾6_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾6_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾6_鱗左2.Dra = value;
				this.X0Y0_尾6_鱗左2.Hit = value;
			}
		}

		public bool 尾6_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾6_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾6_鱗右2.Dra = value;
				this.X0Y0_尾6_鱗右2.Hit = value;
			}
		}

		public bool 尾6_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾6_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾6_鱗左1.Dra = value;
				this.X0Y0_尾6_鱗左1.Hit = value;
			}
		}

		public bool 尾6_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾6_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾6_鱗右1.Dra = value;
				this.X0Y0_尾6_鱗右1.Hit = value;
			}
		}

		public bool 尾5_表示
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

		public bool 尾5_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾5_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾5_鱗左3.Dra = value;
				this.X0Y0_尾5_鱗左3.Hit = value;
			}
		}

		public bool 尾5_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾5_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾5_鱗右3.Dra = value;
				this.X0Y0_尾5_鱗右3.Hit = value;
			}
		}

		public bool 尾5_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾5_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾5_鱗左2.Dra = value;
				this.X0Y0_尾5_鱗左2.Hit = value;
			}
		}

		public bool 尾5_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾5_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾5_鱗右2.Dra = value;
				this.X0Y0_尾5_鱗右2.Hit = value;
			}
		}

		public bool 尾5_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾5_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾5_鱗左1.Dra = value;
				this.X0Y0_尾5_鱗左1.Hit = value;
			}
		}

		public bool 尾5_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾5_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾5_鱗右1.Dra = value;
				this.X0Y0_尾5_鱗右1.Hit = value;
			}
		}

		public bool 尾4_表示
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

		public bool 尾4_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾4_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾4_鱗左3.Dra = value;
				this.X0Y0_尾4_鱗左3.Hit = value;
			}
		}

		public bool 尾4_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾4_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾4_鱗右3.Dra = value;
				this.X0Y0_尾4_鱗右3.Hit = value;
			}
		}

		public bool 尾4_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾4_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾4_鱗左2.Dra = value;
				this.X0Y0_尾4_鱗左2.Hit = value;
			}
		}

		public bool 尾4_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾4_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾4_鱗右2.Dra = value;
				this.X0Y0_尾4_鱗右2.Hit = value;
			}
		}

		public bool 尾4_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾4_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾4_鱗左1.Dra = value;
				this.X0Y0_尾4_鱗左1.Hit = value;
			}
		}

		public bool 尾4_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾4_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾4_鱗右1.Dra = value;
				this.X0Y0_尾4_鱗右1.Hit = value;
			}
		}

		public bool 尾3_表示
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

		public bool 尾3_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾3_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾3_鱗左3.Dra = value;
				this.X0Y0_尾3_鱗左3.Hit = value;
			}
		}

		public bool 尾3_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾3_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾3_鱗右3.Dra = value;
				this.X0Y0_尾3_鱗右3.Hit = value;
			}
		}

		public bool 尾3_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾3_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾3_鱗左2.Dra = value;
				this.X0Y0_尾3_鱗左2.Hit = value;
			}
		}

		public bool 尾3_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾3_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾3_鱗右2.Dra = value;
				this.X0Y0_尾3_鱗右2.Hit = value;
			}
		}

		public bool 尾3_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾3_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾3_鱗左1.Dra = value;
				this.X0Y0_尾3_鱗左1.Hit = value;
			}
		}

		public bool 尾3_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾3_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾3_鱗右1.Dra = value;
				this.X0Y0_尾3_鱗右1.Hit = value;
			}
		}

		public bool 尾2_表示
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

		public bool 尾2_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾2_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾2_鱗左3.Dra = value;
				this.X0Y0_尾2_鱗左3.Hit = value;
			}
		}

		public bool 尾2_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾2_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾2_鱗右3.Dra = value;
				this.X0Y0_尾2_鱗右3.Hit = value;
			}
		}

		public bool 尾2_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾2_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾2_鱗左2.Dra = value;
				this.X0Y0_尾2_鱗左2.Hit = value;
			}
		}

		public bool 尾2_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾2_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾2_鱗右2.Dra = value;
				this.X0Y0_尾2_鱗右2.Hit = value;
			}
		}

		public bool 尾2_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾2_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾2_鱗左1.Dra = value;
				this.X0Y0_尾2_鱗左1.Hit = value;
			}
		}

		public bool 尾2_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾2_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾2_鱗右1.Dra = value;
				this.X0Y0_尾2_鱗右1.Hit = value;
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

		public bool 尾1_表示
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

		public bool 尾1_鱗左3_表示
		{
			get
			{
				return this.X0Y0_尾1_鱗左3.Dra;
			}
			set
			{
				this.X0Y0_尾1_鱗左3.Dra = value;
				this.X0Y0_尾1_鱗左3.Hit = value;
			}
		}

		public bool 尾1_鱗右3_表示
		{
			get
			{
				return this.X0Y0_尾1_鱗右3.Dra;
			}
			set
			{
				this.X0Y0_尾1_鱗右3.Dra = value;
				this.X0Y0_尾1_鱗右3.Hit = value;
			}
		}

		public bool 尾1_鱗左2_表示
		{
			get
			{
				return this.X0Y0_尾1_鱗左2.Dra;
			}
			set
			{
				this.X0Y0_尾1_鱗左2.Dra = value;
				this.X0Y0_尾1_鱗左2.Hit = value;
			}
		}

		public bool 尾1_鱗右2_表示
		{
			get
			{
				return this.X0Y0_尾1_鱗右2.Dra;
			}
			set
			{
				this.X0Y0_尾1_鱗右2.Dra = value;
				this.X0Y0_尾1_鱗右2.Hit = value;
			}
		}

		public bool 尾1_鱗左1_表示
		{
			get
			{
				return this.X0Y0_尾1_鱗左1.Dra;
			}
			set
			{
				this.X0Y0_尾1_鱗左1.Dra = value;
				this.X0Y0_尾1_鱗左1.Hit = value;
			}
		}

		public bool 尾1_鱗右1_表示
		{
			get
			{
				return this.X0Y0_尾1_鱗右1.Dra;
			}
			set
			{
				this.X0Y0_尾1_鱗右1.Dra = value;
				this.X0Y0_尾1_鱗右1.Hit = value;
			}
		}

		public bool 尾0_表示
		{
			get
			{
				return this.X0Y0_尾0_尾.Dra;
			}
			set
			{
				this.X0Y0_尾0_尾.Dra = value;
				this.X0Y0_尾0_尾.Hit = value;
			}
		}

		public bool 尾0_鱗右_表示
		{
			get
			{
				return this.X0Y0_尾0_鱗右.Dra;
			}
			set
			{
				this.X0Y0_尾0_鱗右.Dra = value;
				this.X0Y0_尾0_鱗右.Hit = value;
			}
		}

		public bool 尾0_鱗左_表示
		{
			get
			{
				return this.X0Y0_尾0_鱗左.Dra;
			}
			set
			{
				this.X0Y0_尾0_鱗左.Dra = value;
				this.X0Y0_尾0_鱗左.Hit = value;
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

		public bool 尾先表示
		{
			get
			{
				return this.尾35_尾_表示;
			}
			set
			{
				this.尾35_尾_表示 = value;
				this.尾35_鱗左3_表示 = value;
				this.尾35_鱗右3_表示 = value;
				this.尾35_鱗左2_表示 = value;
				this.尾35_鱗右2_表示 = value;
				this.尾35_鱗左1_表示 = value;
				this.尾35_鱗右1_表示 = value;
				this.尾34_尾_表示 = value;
				this.尾34_鱗左3_表示 = value;
				this.尾34_鱗右3_表示 = value;
				this.尾34_鱗左2_表示 = value;
				this.尾34_鱗右2_表示 = value;
				this.尾34_鱗左1_表示 = value;
				this.尾34_鱗右1_表示 = value;
				this.尾33_尾_表示 = value;
				this.尾33_鱗左3_表示 = value;
				this.尾33_鱗右3_表示 = value;
				this.尾33_鱗左2_表示 = value;
				this.尾33_鱗右2_表示 = value;
				this.尾33_鱗左1_表示 = value;
				this.尾33_鱗右1_表示 = value;
				this.尾32_尾_表示 = value;
				this.尾32_鱗左3_表示 = value;
				this.尾32_鱗右3_表示 = value;
				this.尾32_鱗左2_表示 = value;
				this.尾32_鱗右2_表示 = value;
				this.尾32_鱗左1_表示 = value;
				this.尾32_鱗右1_表示 = value;
				this.尾31_尾_表示 = value;
				this.尾31_鱗左3_表示 = value;
				this.尾31_鱗右3_表示 = value;
				this.尾31_鱗左2_表示 = value;
				this.尾31_鱗右2_表示 = value;
				this.尾31_鱗左1_表示 = value;
				this.尾31_鱗右1_表示 = value;
				this.尾30_尾_表示 = value;
				this.尾30_鱗左3_表示 = value;
				this.尾30_鱗右3_表示 = value;
				this.尾30_鱗左2_表示 = value;
				this.尾30_鱗右2_表示 = value;
				this.尾30_鱗左1_表示 = value;
				this.尾30_鱗右1_表示 = value;
				this.尾29_尾_表示 = value;
				this.尾29_鱗左3_表示 = value;
				this.尾29_鱗右3_表示 = value;
				this.尾29_鱗左2_表示 = value;
				this.尾29_鱗右2_表示 = value;
				this.尾29_鱗左1_表示 = value;
				this.尾29_鱗右1_表示 = value;
				this.尾28_尾_表示 = value;
				this.尾28_鱗左3_表示 = value;
				this.尾28_鱗右3_表示 = value;
				this.尾28_鱗左2_表示 = value;
				this.尾28_鱗右2_表示 = value;
				this.尾28_鱗左1_表示 = value;
				this.尾28_鱗右1_表示 = value;
				this.尾27_尾_表示 = value;
				this.尾27_鱗左3_表示 = value;
				this.尾27_鱗右3_表示 = value;
				this.尾27_鱗左2_表示 = value;
				this.尾27_鱗右2_表示 = value;
				this.尾27_鱗左1_表示 = value;
				this.尾27_鱗右1_表示 = value;
				this.尾26_尾_表示 = value;
				this.尾26_鱗左3_表示 = value;
				this.尾26_鱗右3_表示 = value;
				this.尾26_鱗左2_表示 = value;
				this.尾26_鱗右2_表示 = value;
				this.尾26_鱗左1_表示 = value;
				this.尾26_鱗右1_表示 = value;
				this.尾25_尾_表示 = value;
				this.尾25_鱗左3_表示 = value;
				this.尾25_鱗右3_表示 = value;
				this.尾25_鱗左2_表示 = value;
				this.尾25_鱗右2_表示 = value;
				this.尾25_鱗左1_表示 = value;
				this.尾25_鱗右1_表示 = value;
				this.尾24_尾_表示 = value;
				this.尾24_鱗左3_表示 = value;
				this.尾24_鱗右3_表示 = value;
				this.尾24_鱗左2_表示 = value;
				this.尾24_鱗右2_表示 = value;
				this.尾24_鱗左1_表示 = value;
				this.尾24_鱗右1_表示 = value;
				this.尾23_尾_表示 = value;
				this.尾23_鱗左3_表示 = value;
				this.尾23_鱗右3_表示 = value;
				this.尾23_鱗左2_表示 = value;
				this.尾23_鱗右2_表示 = value;
				this.尾23_鱗左1_表示 = value;
				this.尾23_鱗右1_表示 = value;
				this.尾22_尾_表示 = value;
				this.尾22_鱗左3_表示 = value;
				this.尾22_鱗右3_表示 = value;
				this.尾22_鱗左2_表示 = value;
				this.尾22_鱗右2_表示 = value;
				this.尾22_鱗左1_表示 = value;
				this.尾22_鱗右1_表示 = value;
				this.尾21_尾_表示 = value;
				this.尾21_鱗左3_表示 = value;
				this.尾21_鱗右3_表示 = value;
				this.尾21_鱗左2_表示 = value;
				this.尾21_鱗右2_表示 = value;
				this.尾21_鱗左1_表示 = value;
				this.尾21_鱗右1_表示 = value;
				this.尾20_尾_表示 = value;
				this.尾20_鱗左3_表示 = value;
				this.尾20_鱗右3_表示 = value;
				this.尾20_鱗左2_表示 = value;
				this.尾20_鱗右2_表示 = value;
				this.尾20_鱗左1_表示 = value;
				this.尾20_鱗右1_表示 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.尾35_尾_表示;
			}
			set
			{
				this.尾35_尾_表示 = value;
				this.尾35_鱗左3_表示 = value;
				this.尾35_鱗右3_表示 = value;
				this.尾35_鱗左2_表示 = value;
				this.尾35_鱗右2_表示 = value;
				this.尾35_鱗左1_表示 = value;
				this.尾35_鱗右1_表示 = value;
				this.尾34_尾_表示 = value;
				this.尾34_鱗左3_表示 = value;
				this.尾34_鱗右3_表示 = value;
				this.尾34_鱗左2_表示 = value;
				this.尾34_鱗右2_表示 = value;
				this.尾34_鱗左1_表示 = value;
				this.尾34_鱗右1_表示 = value;
				this.尾33_尾_表示 = value;
				this.尾33_鱗左3_表示 = value;
				this.尾33_鱗右3_表示 = value;
				this.尾33_鱗左2_表示 = value;
				this.尾33_鱗右2_表示 = value;
				this.尾33_鱗左1_表示 = value;
				this.尾33_鱗右1_表示 = value;
				this.尾32_尾_表示 = value;
				this.尾32_鱗左3_表示 = value;
				this.尾32_鱗右3_表示 = value;
				this.尾32_鱗左2_表示 = value;
				this.尾32_鱗右2_表示 = value;
				this.尾32_鱗左1_表示 = value;
				this.尾32_鱗右1_表示 = value;
				this.尾31_尾_表示 = value;
				this.尾31_鱗左3_表示 = value;
				this.尾31_鱗右3_表示 = value;
				this.尾31_鱗左2_表示 = value;
				this.尾31_鱗右2_表示 = value;
				this.尾31_鱗左1_表示 = value;
				this.尾31_鱗右1_表示 = value;
				this.尾30_尾_表示 = value;
				this.尾30_鱗左3_表示 = value;
				this.尾30_鱗右3_表示 = value;
				this.尾30_鱗左2_表示 = value;
				this.尾30_鱗右2_表示 = value;
				this.尾30_鱗左1_表示 = value;
				this.尾30_鱗右1_表示 = value;
				this.尾29_尾_表示 = value;
				this.尾29_鱗左3_表示 = value;
				this.尾29_鱗右3_表示 = value;
				this.尾29_鱗左2_表示 = value;
				this.尾29_鱗右2_表示 = value;
				this.尾29_鱗左1_表示 = value;
				this.尾29_鱗右1_表示 = value;
				this.尾28_尾_表示 = value;
				this.尾28_鱗左3_表示 = value;
				this.尾28_鱗右3_表示 = value;
				this.尾28_鱗左2_表示 = value;
				this.尾28_鱗右2_表示 = value;
				this.尾28_鱗左1_表示 = value;
				this.尾28_鱗右1_表示 = value;
				this.尾27_尾_表示 = value;
				this.尾27_鱗左3_表示 = value;
				this.尾27_鱗右3_表示 = value;
				this.尾27_鱗左2_表示 = value;
				this.尾27_鱗右2_表示 = value;
				this.尾27_鱗左1_表示 = value;
				this.尾27_鱗右1_表示 = value;
				this.尾26_尾_表示 = value;
				this.尾26_鱗左3_表示 = value;
				this.尾26_鱗右3_表示 = value;
				this.尾26_鱗左2_表示 = value;
				this.尾26_鱗右2_表示 = value;
				this.尾26_鱗左1_表示 = value;
				this.尾26_鱗右1_表示 = value;
				this.尾25_尾_表示 = value;
				this.尾25_鱗左3_表示 = value;
				this.尾25_鱗右3_表示 = value;
				this.尾25_鱗左2_表示 = value;
				this.尾25_鱗右2_表示 = value;
				this.尾25_鱗左1_表示 = value;
				this.尾25_鱗右1_表示 = value;
				this.尾24_尾_表示 = value;
				this.尾24_鱗左3_表示 = value;
				this.尾24_鱗右3_表示 = value;
				this.尾24_鱗左2_表示 = value;
				this.尾24_鱗右2_表示 = value;
				this.尾24_鱗左1_表示 = value;
				this.尾24_鱗右1_表示 = value;
				this.尾23_尾_表示 = value;
				this.尾23_鱗左3_表示 = value;
				this.尾23_鱗右3_表示 = value;
				this.尾23_鱗左2_表示 = value;
				this.尾23_鱗右2_表示 = value;
				this.尾23_鱗左1_表示 = value;
				this.尾23_鱗右1_表示 = value;
				this.尾22_尾_表示 = value;
				this.尾22_鱗左3_表示 = value;
				this.尾22_鱗右3_表示 = value;
				this.尾22_鱗左2_表示 = value;
				this.尾22_鱗右2_表示 = value;
				this.尾22_鱗左1_表示 = value;
				this.尾22_鱗右1_表示 = value;
				this.尾21_尾_表示 = value;
				this.尾21_鱗左3_表示 = value;
				this.尾21_鱗右3_表示 = value;
				this.尾21_鱗左2_表示 = value;
				this.尾21_鱗右2_表示 = value;
				this.尾21_鱗左1_表示 = value;
				this.尾21_鱗右1_表示 = value;
				this.尾20_尾_表示 = value;
				this.尾20_鱗左3_表示 = value;
				this.尾20_鱗右3_表示 = value;
				this.尾20_鱗左2_表示 = value;
				this.尾20_鱗右2_表示 = value;
				this.尾20_鱗左1_表示 = value;
				this.尾20_鱗右1_表示 = value;
				this.尾19_尾_表示 = value;
				this.尾19_鱗左3_表示 = value;
				this.尾19_鱗右3_表示 = value;
				this.尾19_鱗左2_表示 = value;
				this.尾19_鱗右2_表示 = value;
				this.尾19_鱗左1_表示 = value;
				this.尾19_鱗右1_表示 = value;
				this.尾18_尾_表示 = value;
				this.尾18_鱗左3_表示 = value;
				this.尾18_鱗右3_表示 = value;
				this.尾18_鱗左2_表示 = value;
				this.尾18_鱗右2_表示 = value;
				this.尾18_鱗左1_表示 = value;
				this.尾18_鱗右1_表示 = value;
				this.尾17_尾_表示 = value;
				this.尾17_鱗左3_表示 = value;
				this.尾17_鱗右3_表示 = value;
				this.尾17_鱗左2_表示 = value;
				this.尾17_鱗右2_表示 = value;
				this.尾17_鱗左1_表示 = value;
				this.尾17_鱗右1_表示 = value;
				this.尾16_尾_表示 = value;
				this.尾16_鱗左3_表示 = value;
				this.尾16_鱗右3_表示 = value;
				this.尾16_鱗左2_表示 = value;
				this.尾16_鱗右2_表示 = value;
				this.尾16_鱗左1_表示 = value;
				this.尾16_鱗右1_表示 = value;
				this.尾15_尾_表示 = value;
				this.尾15_鱗左3_表示 = value;
				this.尾15_鱗右3_表示 = value;
				this.尾15_鱗左2_表示 = value;
				this.尾15_鱗右2_表示 = value;
				this.尾15_鱗左1_表示 = value;
				this.尾15_鱗右1_表示 = value;
				this.尾14_尾_表示 = value;
				this.尾14_鱗左3_表示 = value;
				this.尾14_鱗右3_表示 = value;
				this.尾14_鱗左2_表示 = value;
				this.尾14_鱗右2_表示 = value;
				this.尾14_鱗左1_表示 = value;
				this.尾14_鱗右1_表示 = value;
				this.尾13_尾_表示 = value;
				this.尾13_鱗左3_表示 = value;
				this.尾13_鱗右3_表示 = value;
				this.尾13_鱗左2_表示 = value;
				this.尾13_鱗右2_表示 = value;
				this.尾13_鱗左1_表示 = value;
				this.尾13_鱗右1_表示 = value;
				this.尾12_尾_表示 = value;
				this.尾12_鱗左3_表示 = value;
				this.尾12_鱗右3_表示 = value;
				this.尾12_鱗左2_表示 = value;
				this.尾12_鱗右2_表示 = value;
				this.尾12_鱗左1_表示 = value;
				this.尾12_鱗右1_表示 = value;
				this.尾11_尾_表示 = value;
				this.尾11_鱗左3_表示 = value;
				this.尾11_鱗右3_表示 = value;
				this.尾11_鱗左2_表示 = value;
				this.尾11_鱗右2_表示 = value;
				this.尾11_鱗左1_表示 = value;
				this.尾11_鱗右1_表示 = value;
				this.尾10_尾_表示 = value;
				this.尾10_鱗左3_表示 = value;
				this.尾10_鱗右3_表示 = value;
				this.尾10_鱗左2_表示 = value;
				this.尾10_鱗右2_表示 = value;
				this.尾10_鱗左1_表示 = value;
				this.尾10_鱗右1_表示 = value;
				this.尾9_表示 = value;
				this.尾9_鱗左3_表示 = value;
				this.尾9_鱗右3_表示 = value;
				this.尾9_鱗左2_表示 = value;
				this.尾9_鱗右2_表示 = value;
				this.尾9_鱗左1_表示 = value;
				this.尾9_鱗右1_表示 = value;
				this.尾8_表示 = value;
				this.尾8_鱗左3_表示 = value;
				this.尾8_鱗右3_表示 = value;
				this.尾8_鱗左2_表示 = value;
				this.尾8_鱗右2_表示 = value;
				this.尾8_鱗左1_表示 = value;
				this.尾8_鱗右1_表示 = value;
				this.尾7_表示 = value;
				this.尾7_鱗左3_表示 = value;
				this.尾7_鱗右3_表示 = value;
				this.尾7_鱗左2_表示 = value;
				this.尾7_鱗右2_表示 = value;
				this.尾7_鱗左1_表示 = value;
				this.尾7_鱗右1_表示 = value;
				this.尾6_表示 = value;
				this.尾6_鱗左3_表示 = value;
				this.尾6_鱗右3_表示 = value;
				this.尾6_鱗左2_表示 = value;
				this.尾6_鱗右2_表示 = value;
				this.尾6_鱗左1_表示 = value;
				this.尾6_鱗右1_表示 = value;
				this.尾5_表示 = value;
				this.尾5_鱗左3_表示 = value;
				this.尾5_鱗右3_表示 = value;
				this.尾5_鱗左2_表示 = value;
				this.尾5_鱗右2_表示 = value;
				this.尾5_鱗左1_表示 = value;
				this.尾5_鱗右1_表示 = value;
				this.尾4_表示 = value;
				this.尾4_鱗左3_表示 = value;
				this.尾4_鱗右3_表示 = value;
				this.尾4_鱗左2_表示 = value;
				this.尾4_鱗右2_表示 = value;
				this.尾4_鱗左1_表示 = value;
				this.尾4_鱗右1_表示 = value;
				this.尾3_表示 = value;
				this.尾3_鱗左3_表示 = value;
				this.尾3_鱗右3_表示 = value;
				this.尾3_鱗左2_表示 = value;
				this.尾3_鱗右2_表示 = value;
				this.尾3_鱗左1_表示 = value;
				this.尾3_鱗右1_表示 = value;
				this.尾2_表示 = value;
				this.尾2_鱗左3_表示 = value;
				this.尾2_鱗右3_表示 = value;
				this.尾2_鱗左2_表示 = value;
				this.尾2_鱗右2_表示 = value;
				this.尾2_鱗左1_表示 = value;
				this.尾2_鱗右1_表示 = value;
				this.尾1_表示 = value;
				this.尾1_鱗左3_表示 = value;
				this.尾1_鱗右3_表示 = value;
				this.尾1_鱗左2_表示 = value;
				this.尾1_鱗右2_表示 = value;
				this.尾1_鱗左1_表示 = value;
				this.尾1_鱗右1_表示 = value;
				this.尾0_表示 = value;
				this.尾0_鱗右_表示 = value;
				this.尾0_鱗左_表示 = value;
				this.輪1_革_表示 = value;
				this.輪1_金具1_表示 = value;
				this.輪1_金具2_表示 = value;
				this.輪1_金具3_表示 = value;
				this.輪1_金具左_表示 = value;
				this.輪1_金具右_表示 = value;
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
			Are.Draw(this.X0Y0_尾35_尾);
			Are.Draw(this.X0Y0_尾35_鱗左3);
			Are.Draw(this.X0Y0_尾35_鱗右3);
			Are.Draw(this.X0Y0_尾35_鱗左2);
			Are.Draw(this.X0Y0_尾35_鱗右2);
			Are.Draw(this.X0Y0_尾35_鱗左1);
			Are.Draw(this.X0Y0_尾35_鱗右1);
			Are.Draw(this.X0Y0_尾34_尾);
			Are.Draw(this.X0Y0_尾34_鱗左3);
			Are.Draw(this.X0Y0_尾34_鱗右3);
			Are.Draw(this.X0Y0_尾34_鱗左2);
			Are.Draw(this.X0Y0_尾34_鱗右2);
			Are.Draw(this.X0Y0_尾34_鱗左1);
			Are.Draw(this.X0Y0_尾34_鱗右1);
			Are.Draw(this.X0Y0_尾33_尾);
			Are.Draw(this.X0Y0_尾33_鱗左3);
			Are.Draw(this.X0Y0_尾33_鱗右3);
			Are.Draw(this.X0Y0_尾33_鱗左2);
			Are.Draw(this.X0Y0_尾33_鱗右2);
			Are.Draw(this.X0Y0_尾33_鱗左1);
			Are.Draw(this.X0Y0_尾33_鱗右1);
			Are.Draw(this.X0Y0_尾32_尾);
			Are.Draw(this.X0Y0_尾32_鱗左3);
			Are.Draw(this.X0Y0_尾32_鱗右3);
			Are.Draw(this.X0Y0_尾32_鱗左2);
			Are.Draw(this.X0Y0_尾32_鱗右2);
			Are.Draw(this.X0Y0_尾32_鱗左1);
			Are.Draw(this.X0Y0_尾32_鱗右1);
			Are.Draw(this.X0Y0_尾31_尾);
			Are.Draw(this.X0Y0_尾31_鱗左3);
			Are.Draw(this.X0Y0_尾31_鱗右3);
			Are.Draw(this.X0Y0_尾31_鱗左2);
			Are.Draw(this.X0Y0_尾31_鱗右2);
			Are.Draw(this.X0Y0_尾31_鱗左1);
			Are.Draw(this.X0Y0_尾31_鱗右1);
			Are.Draw(this.X0Y0_尾30_尾);
			Are.Draw(this.X0Y0_尾30_鱗左3);
			Are.Draw(this.X0Y0_尾30_鱗右3);
			Are.Draw(this.X0Y0_尾30_鱗左2);
			Are.Draw(this.X0Y0_尾30_鱗右2);
			Are.Draw(this.X0Y0_尾30_鱗左1);
			Are.Draw(this.X0Y0_尾30_鱗右1);
			Are.Draw(this.X0Y0_尾29_尾);
			Are.Draw(this.X0Y0_尾29_鱗左3);
			Are.Draw(this.X0Y0_尾29_鱗右3);
			Are.Draw(this.X0Y0_尾29_鱗左2);
			Are.Draw(this.X0Y0_尾29_鱗右2);
			Are.Draw(this.X0Y0_尾29_鱗左1);
			Are.Draw(this.X0Y0_尾29_鱗右1);
			Are.Draw(this.X0Y0_尾28_尾);
			Are.Draw(this.X0Y0_尾28_鱗左3);
			Are.Draw(this.X0Y0_尾28_鱗右3);
			Are.Draw(this.X0Y0_尾28_鱗左2);
			Are.Draw(this.X0Y0_尾28_鱗右2);
			Are.Draw(this.X0Y0_尾28_鱗左1);
			Are.Draw(this.X0Y0_尾28_鱗右1);
			Are.Draw(this.X0Y0_尾27_尾);
			Are.Draw(this.X0Y0_尾27_鱗左3);
			Are.Draw(this.X0Y0_尾27_鱗右3);
			Are.Draw(this.X0Y0_尾27_鱗左2);
			Are.Draw(this.X0Y0_尾27_鱗右2);
			Are.Draw(this.X0Y0_尾27_鱗左1);
			Are.Draw(this.X0Y0_尾27_鱗右1);
			Are.Draw(this.X0Y0_尾26_尾);
			Are.Draw(this.X0Y0_尾26_鱗左3);
			Are.Draw(this.X0Y0_尾26_鱗右3);
			Are.Draw(this.X0Y0_尾26_鱗左2);
			Are.Draw(this.X0Y0_尾26_鱗右2);
			Are.Draw(this.X0Y0_尾26_鱗左1);
			Are.Draw(this.X0Y0_尾26_鱗右1);
			Are.Draw(this.X0Y0_尾25_尾);
			Are.Draw(this.X0Y0_尾25_鱗左3);
			Are.Draw(this.X0Y0_尾25_鱗右3);
			Are.Draw(this.X0Y0_尾25_鱗左2);
			Are.Draw(this.X0Y0_尾25_鱗右2);
			Are.Draw(this.X0Y0_尾25_鱗左1);
			Are.Draw(this.X0Y0_尾25_鱗右1);
			Are.Draw(this.X0Y0_尾24_尾);
			Are.Draw(this.X0Y0_尾24_鱗左3);
			Are.Draw(this.X0Y0_尾24_鱗右3);
			Are.Draw(this.X0Y0_尾24_鱗左2);
			Are.Draw(this.X0Y0_尾24_鱗右2);
			Are.Draw(this.X0Y0_尾24_鱗左1);
			Are.Draw(this.X0Y0_尾24_鱗右1);
			Are.Draw(this.X0Y0_尾23_尾);
			Are.Draw(this.X0Y0_尾23_鱗左3);
			Are.Draw(this.X0Y0_尾23_鱗右3);
			Are.Draw(this.X0Y0_尾23_鱗左2);
			Are.Draw(this.X0Y0_尾23_鱗右2);
			Are.Draw(this.X0Y0_尾23_鱗左1);
			Are.Draw(this.X0Y0_尾23_鱗右1);
			Are.Draw(this.X0Y0_尾22_尾);
			Are.Draw(this.X0Y0_尾22_鱗左3);
			Are.Draw(this.X0Y0_尾22_鱗右3);
			Are.Draw(this.X0Y0_尾22_鱗左2);
			Are.Draw(this.X0Y0_尾22_鱗右2);
			Are.Draw(this.X0Y0_尾22_鱗左1);
			Are.Draw(this.X0Y0_尾22_鱗右1);
			Are.Draw(this.X0Y0_尾21_尾);
			Are.Draw(this.X0Y0_尾21_鱗左3);
			Are.Draw(this.X0Y0_尾21_鱗右3);
			Are.Draw(this.X0Y0_尾21_鱗左2);
			Are.Draw(this.X0Y0_尾21_鱗右2);
			Are.Draw(this.X0Y0_尾21_鱗左1);
			Are.Draw(this.X0Y0_尾21_鱗右1);
			Are.Draw(this.X0Y0_尾20_尾);
			Are.Draw(this.X0Y0_尾20_鱗左3);
			Are.Draw(this.X0Y0_尾20_鱗右3);
			Are.Draw(this.X0Y0_尾20_鱗左2);
			Are.Draw(this.X0Y0_尾20_鱗右2);
			Are.Draw(this.X0Y0_尾20_鱗左1);
			Are.Draw(this.X0Y0_尾20_鱗右1);
			Are.Draw(this.X0Y0_尾19_尾);
			Are.Draw(this.X0Y0_尾19_鱗左3);
			Are.Draw(this.X0Y0_尾19_鱗右3);
			Are.Draw(this.X0Y0_尾19_鱗左2);
			Are.Draw(this.X0Y0_尾19_鱗右2);
			Are.Draw(this.X0Y0_尾19_鱗左1);
			Are.Draw(this.X0Y0_尾19_鱗右1);
			Are.Draw(this.X0Y0_尾18_尾);
			Are.Draw(this.X0Y0_尾18_鱗左3);
			Are.Draw(this.X0Y0_尾18_鱗右3);
			Are.Draw(this.X0Y0_尾18_鱗左2);
			Are.Draw(this.X0Y0_尾18_鱗右2);
			Are.Draw(this.X0Y0_尾18_鱗左1);
			Are.Draw(this.X0Y0_尾18_鱗右1);
			Are.Draw(this.X0Y0_尾17_尾);
			Are.Draw(this.X0Y0_尾17_鱗左3);
			Are.Draw(this.X0Y0_尾17_鱗右3);
			Are.Draw(this.X0Y0_尾17_鱗左2);
			Are.Draw(this.X0Y0_尾17_鱗右2);
			Are.Draw(this.X0Y0_尾17_鱗左1);
			Are.Draw(this.X0Y0_尾17_鱗右1);
			Are.Draw(this.X0Y0_尾16_尾);
			Are.Draw(this.X0Y0_尾16_鱗左3);
			Are.Draw(this.X0Y0_尾16_鱗右3);
			Are.Draw(this.X0Y0_尾16_鱗左2);
			Are.Draw(this.X0Y0_尾16_鱗右2);
			Are.Draw(this.X0Y0_尾16_鱗左1);
			Are.Draw(this.X0Y0_尾16_鱗右1);
			Are.Draw(this.X0Y0_尾15_尾);
			Are.Draw(this.X0Y0_尾15_鱗左3);
			Are.Draw(this.X0Y0_尾15_鱗右3);
			Are.Draw(this.X0Y0_尾15_鱗左2);
			Are.Draw(this.X0Y0_尾15_鱗右2);
			Are.Draw(this.X0Y0_尾15_鱗左1);
			Are.Draw(this.X0Y0_尾15_鱗右1);
			Are.Draw(this.X0Y0_尾14_尾);
			Are.Draw(this.X0Y0_尾14_鱗左3);
			Are.Draw(this.X0Y0_尾14_鱗右3);
			Are.Draw(this.X0Y0_尾14_鱗左2);
			Are.Draw(this.X0Y0_尾14_鱗右2);
			Are.Draw(this.X0Y0_尾14_鱗左1);
			Are.Draw(this.X0Y0_尾14_鱗右1);
			Are.Draw(this.X0Y0_尾13_尾);
			Are.Draw(this.X0Y0_尾13_鱗左3);
			Are.Draw(this.X0Y0_尾13_鱗右3);
			Are.Draw(this.X0Y0_尾13_鱗左2);
			Are.Draw(this.X0Y0_尾13_鱗右2);
			Are.Draw(this.X0Y0_尾13_鱗左1);
			Are.Draw(this.X0Y0_尾13_鱗右1);
			Are.Draw(this.X0Y0_尾12_尾);
			Are.Draw(this.X0Y0_尾12_鱗左3);
			Are.Draw(this.X0Y0_尾12_鱗右3);
			Are.Draw(this.X0Y0_尾12_鱗左2);
			Are.Draw(this.X0Y0_尾12_鱗右2);
			Are.Draw(this.X0Y0_尾12_鱗左1);
			Are.Draw(this.X0Y0_尾12_鱗右1);
			Are.Draw(this.X0Y0_尾11_尾);
			Are.Draw(this.X0Y0_尾11_鱗左3);
			Are.Draw(this.X0Y0_尾11_鱗右3);
			Are.Draw(this.X0Y0_尾11_鱗左2);
			Are.Draw(this.X0Y0_尾11_鱗右2);
			Are.Draw(this.X0Y0_尾11_鱗左1);
			Are.Draw(this.X0Y0_尾11_鱗右1);
			Are.Draw(this.X0Y0_尾10_尾);
			Are.Draw(this.X0Y0_尾10_鱗左3);
			Are.Draw(this.X0Y0_尾10_鱗右3);
			Are.Draw(this.X0Y0_尾10_鱗左2);
			Are.Draw(this.X0Y0_尾10_鱗右2);
			Are.Draw(this.X0Y0_尾10_鱗左1);
			Are.Draw(this.X0Y0_尾10_鱗右1);
			Are.Draw(this.X0Y0_尾9_尾);
			Are.Draw(this.X0Y0_尾9_鱗左3);
			Are.Draw(this.X0Y0_尾9_鱗右3);
			Are.Draw(this.X0Y0_尾9_鱗左2);
			Are.Draw(this.X0Y0_尾9_鱗右2);
			Are.Draw(this.X0Y0_尾9_鱗左1);
			Are.Draw(this.X0Y0_尾9_鱗右1);
			Are.Draw(this.X0Y0_尾8_尾);
			Are.Draw(this.X0Y0_尾8_鱗左3);
			Are.Draw(this.X0Y0_尾8_鱗右3);
			Are.Draw(this.X0Y0_尾8_鱗左2);
			Are.Draw(this.X0Y0_尾8_鱗右2);
			Are.Draw(this.X0Y0_尾8_鱗左1);
			Are.Draw(this.X0Y0_尾8_鱗右1);
			Are.Draw(this.X0Y0_輪2_革);
			Are.Draw(this.X0Y0_輪2_金具1);
			Are.Draw(this.X0Y0_輪2_金具2);
			Are.Draw(this.X0Y0_輪2_金具3);
			Are.Draw(this.X0Y0_輪2_金具左);
			Are.Draw(this.X0Y0_輪2_金具右);
			this.鎖3.描画0(Are);
			this.鎖4.描画0(Are);
			Are.Draw(this.X0Y0_尾7_尾);
			Are.Draw(this.X0Y0_尾7_鱗左3);
			Are.Draw(this.X0Y0_尾7_鱗右3);
			Are.Draw(this.X0Y0_尾7_鱗左2);
			Are.Draw(this.X0Y0_尾7_鱗右2);
			Are.Draw(this.X0Y0_尾7_鱗左1);
			Are.Draw(this.X0Y0_尾7_鱗右1);
			Are.Draw(this.X0Y0_尾6_尾);
			Are.Draw(this.X0Y0_尾6_鱗左3);
			Are.Draw(this.X0Y0_尾6_鱗右3);
			Are.Draw(this.X0Y0_尾6_鱗左2);
			Are.Draw(this.X0Y0_尾6_鱗右2);
			Are.Draw(this.X0Y0_尾6_鱗左1);
			Are.Draw(this.X0Y0_尾6_鱗右1);
			Are.Draw(this.X0Y0_尾5_尾);
			Are.Draw(this.X0Y0_尾5_鱗左3);
			Are.Draw(this.X0Y0_尾5_鱗右3);
			Are.Draw(this.X0Y0_尾5_鱗左2);
			Are.Draw(this.X0Y0_尾5_鱗右2);
			Are.Draw(this.X0Y0_尾5_鱗左1);
			Are.Draw(this.X0Y0_尾5_鱗右1);
			Are.Draw(this.X0Y0_尾4_尾);
			Are.Draw(this.X0Y0_尾4_鱗左3);
			Are.Draw(this.X0Y0_尾4_鱗右3);
			Are.Draw(this.X0Y0_尾4_鱗左2);
			Are.Draw(this.X0Y0_尾4_鱗右2);
			Are.Draw(this.X0Y0_尾4_鱗左1);
			Are.Draw(this.X0Y0_尾4_鱗右1);
			Are.Draw(this.X0Y0_尾3_尾);
			Are.Draw(this.X0Y0_尾3_鱗左3);
			Are.Draw(this.X0Y0_尾3_鱗右3);
			Are.Draw(this.X0Y0_尾3_鱗左2);
			Are.Draw(this.X0Y0_尾3_鱗右2);
			Are.Draw(this.X0Y0_尾3_鱗左1);
			Are.Draw(this.X0Y0_尾3_鱗右1);
			Are.Draw(this.X0Y0_尾2_尾);
			Are.Draw(this.X0Y0_尾2_鱗左3);
			Are.Draw(this.X0Y0_尾2_鱗右3);
			Are.Draw(this.X0Y0_尾2_鱗左2);
			Are.Draw(this.X0Y0_尾2_鱗右2);
			Are.Draw(this.X0Y0_尾2_鱗左1);
			Are.Draw(this.X0Y0_尾2_鱗右1);
			Are.Draw(this.X0Y0_輪1_革);
			Are.Draw(this.X0Y0_輪1_金具1);
			Are.Draw(this.X0Y0_輪1_金具2);
			Are.Draw(this.X0Y0_輪1_金具3);
			Are.Draw(this.X0Y0_輪1_金具左);
			Are.Draw(this.X0Y0_輪1_金具右);
			this.鎖1.描画0(Are);
			this.鎖2.描画0(Are);
			Are.Draw(this.X0Y0_尾1_尾);
			Are.Draw(this.X0Y0_尾1_鱗左3);
			Are.Draw(this.X0Y0_尾1_鱗右3);
			Are.Draw(this.X0Y0_尾1_鱗左2);
			Are.Draw(this.X0Y0_尾1_鱗右2);
			Are.Draw(this.X0Y0_尾1_鱗左1);
			Are.Draw(this.X0Y0_尾1_鱗右1);
			Are.Draw(this.X0Y0_尾0_尾);
			Are.Draw(this.X0Y0_尾0_鱗右);
			Are.Draw(this.X0Y0_尾0_鱗左);
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
				return this.尾35_尾CD.不透明度;
			}
			set
			{
				this.尾35_尾CD.不透明度 = value;
				this.尾35_鱗左3CD.不透明度 = value;
				this.尾35_鱗右3CD.不透明度 = value;
				this.尾35_鱗左2CD.不透明度 = value;
				this.尾35_鱗右2CD.不透明度 = value;
				this.尾35_鱗左1CD.不透明度 = value;
				this.尾35_鱗右1CD.不透明度 = value;
				this.尾34_尾CD.不透明度 = value;
				this.尾34_鱗左3CD.不透明度 = value;
				this.尾34_鱗右3CD.不透明度 = value;
				this.尾34_鱗左2CD.不透明度 = value;
				this.尾34_鱗右2CD.不透明度 = value;
				this.尾34_鱗左1CD.不透明度 = value;
				this.尾34_鱗右1CD.不透明度 = value;
				this.尾33_尾CD.不透明度 = value;
				this.尾33_鱗左3CD.不透明度 = value;
				this.尾33_鱗右3CD.不透明度 = value;
				this.尾33_鱗左2CD.不透明度 = value;
				this.尾33_鱗右2CD.不透明度 = value;
				this.尾33_鱗左1CD.不透明度 = value;
				this.尾33_鱗右1CD.不透明度 = value;
				this.尾32_尾CD.不透明度 = value;
				this.尾32_鱗左3CD.不透明度 = value;
				this.尾32_鱗右3CD.不透明度 = value;
				this.尾32_鱗左2CD.不透明度 = value;
				this.尾32_鱗右2CD.不透明度 = value;
				this.尾32_鱗左1CD.不透明度 = value;
				this.尾32_鱗右1CD.不透明度 = value;
				this.尾31_尾CD.不透明度 = value;
				this.尾31_鱗左3CD.不透明度 = value;
				this.尾31_鱗右3CD.不透明度 = value;
				this.尾31_鱗左2CD.不透明度 = value;
				this.尾31_鱗右2CD.不透明度 = value;
				this.尾31_鱗左1CD.不透明度 = value;
				this.尾31_鱗右1CD.不透明度 = value;
				this.尾30_尾CD.不透明度 = value;
				this.尾30_鱗左3CD.不透明度 = value;
				this.尾30_鱗右3CD.不透明度 = value;
				this.尾30_鱗左2CD.不透明度 = value;
				this.尾30_鱗右2CD.不透明度 = value;
				this.尾30_鱗左1CD.不透明度 = value;
				this.尾30_鱗右1CD.不透明度 = value;
				this.尾29_尾CD.不透明度 = value;
				this.尾29_鱗左3CD.不透明度 = value;
				this.尾29_鱗右3CD.不透明度 = value;
				this.尾29_鱗左2CD.不透明度 = value;
				this.尾29_鱗右2CD.不透明度 = value;
				this.尾29_鱗左1CD.不透明度 = value;
				this.尾29_鱗右1CD.不透明度 = value;
				this.尾28_尾CD.不透明度 = value;
				this.尾28_鱗左3CD.不透明度 = value;
				this.尾28_鱗右3CD.不透明度 = value;
				this.尾28_鱗左2CD.不透明度 = value;
				this.尾28_鱗右2CD.不透明度 = value;
				this.尾28_鱗左1CD.不透明度 = value;
				this.尾28_鱗右1CD.不透明度 = value;
				this.尾27_尾CD.不透明度 = value;
				this.尾27_鱗左3CD.不透明度 = value;
				this.尾27_鱗右3CD.不透明度 = value;
				this.尾27_鱗左2CD.不透明度 = value;
				this.尾27_鱗右2CD.不透明度 = value;
				this.尾27_鱗左1CD.不透明度 = value;
				this.尾27_鱗右1CD.不透明度 = value;
				this.尾26_尾CD.不透明度 = value;
				this.尾26_鱗左3CD.不透明度 = value;
				this.尾26_鱗右3CD.不透明度 = value;
				this.尾26_鱗左2CD.不透明度 = value;
				this.尾26_鱗右2CD.不透明度 = value;
				this.尾26_鱗左1CD.不透明度 = value;
				this.尾26_鱗右1CD.不透明度 = value;
				this.尾25_尾CD.不透明度 = value;
				this.尾25_鱗左3CD.不透明度 = value;
				this.尾25_鱗右3CD.不透明度 = value;
				this.尾25_鱗左2CD.不透明度 = value;
				this.尾25_鱗右2CD.不透明度 = value;
				this.尾25_鱗左1CD.不透明度 = value;
				this.尾25_鱗右1CD.不透明度 = value;
				this.尾24_尾CD.不透明度 = value;
				this.尾24_鱗左3CD.不透明度 = value;
				this.尾24_鱗右3CD.不透明度 = value;
				this.尾24_鱗左2CD.不透明度 = value;
				this.尾24_鱗右2CD.不透明度 = value;
				this.尾24_鱗左1CD.不透明度 = value;
				this.尾24_鱗右1CD.不透明度 = value;
				this.尾23_尾CD.不透明度 = value;
				this.尾23_鱗左3CD.不透明度 = value;
				this.尾23_鱗右3CD.不透明度 = value;
				this.尾23_鱗左2CD.不透明度 = value;
				this.尾23_鱗右2CD.不透明度 = value;
				this.尾23_鱗左1CD.不透明度 = value;
				this.尾23_鱗右1CD.不透明度 = value;
				this.尾22_尾CD.不透明度 = value;
				this.尾22_鱗左3CD.不透明度 = value;
				this.尾22_鱗右3CD.不透明度 = value;
				this.尾22_鱗左2CD.不透明度 = value;
				this.尾22_鱗右2CD.不透明度 = value;
				this.尾22_鱗左1CD.不透明度 = value;
				this.尾22_鱗右1CD.不透明度 = value;
				this.尾21_尾CD.不透明度 = value;
				this.尾21_鱗左3CD.不透明度 = value;
				this.尾21_鱗右3CD.不透明度 = value;
				this.尾21_鱗左2CD.不透明度 = value;
				this.尾21_鱗右2CD.不透明度 = value;
				this.尾21_鱗左1CD.不透明度 = value;
				this.尾21_鱗右1CD.不透明度 = value;
				this.尾20_尾CD.不透明度 = value;
				this.尾20_鱗左3CD.不透明度 = value;
				this.尾20_鱗右3CD.不透明度 = value;
				this.尾20_鱗左2CD.不透明度 = value;
				this.尾20_鱗右2CD.不透明度 = value;
				this.尾20_鱗左1CD.不透明度 = value;
				this.尾20_鱗右1CD.不透明度 = value;
				this.尾19_尾CD.不透明度 = value;
				this.尾19_鱗左3CD.不透明度 = value;
				this.尾19_鱗右3CD.不透明度 = value;
				this.尾19_鱗左2CD.不透明度 = value;
				this.尾19_鱗右2CD.不透明度 = value;
				this.尾19_鱗左1CD.不透明度 = value;
				this.尾19_鱗右1CD.不透明度 = value;
				this.尾18_尾CD.不透明度 = value;
				this.尾18_鱗左3CD.不透明度 = value;
				this.尾18_鱗右3CD.不透明度 = value;
				this.尾18_鱗左2CD.不透明度 = value;
				this.尾18_鱗右2CD.不透明度 = value;
				this.尾18_鱗左1CD.不透明度 = value;
				this.尾18_鱗右1CD.不透明度 = value;
				this.尾17_尾CD.不透明度 = value;
				this.尾17_鱗左3CD.不透明度 = value;
				this.尾17_鱗右3CD.不透明度 = value;
				this.尾17_鱗左2CD.不透明度 = value;
				this.尾17_鱗右2CD.不透明度 = value;
				this.尾17_鱗左1CD.不透明度 = value;
				this.尾17_鱗右1CD.不透明度 = value;
				this.尾16_尾CD.不透明度 = value;
				this.尾16_鱗左3CD.不透明度 = value;
				this.尾16_鱗右3CD.不透明度 = value;
				this.尾16_鱗左2CD.不透明度 = value;
				this.尾16_鱗右2CD.不透明度 = value;
				this.尾16_鱗左1CD.不透明度 = value;
				this.尾16_鱗右1CD.不透明度 = value;
				this.尾15_尾CD.不透明度 = value;
				this.尾15_鱗左3CD.不透明度 = value;
				this.尾15_鱗右3CD.不透明度 = value;
				this.尾15_鱗左2CD.不透明度 = value;
				this.尾15_鱗右2CD.不透明度 = value;
				this.尾15_鱗左1CD.不透明度 = value;
				this.尾15_鱗右1CD.不透明度 = value;
				this.尾14_尾CD.不透明度 = value;
				this.尾14_鱗左3CD.不透明度 = value;
				this.尾14_鱗右3CD.不透明度 = value;
				this.尾14_鱗左2CD.不透明度 = value;
				this.尾14_鱗右2CD.不透明度 = value;
				this.尾14_鱗左1CD.不透明度 = value;
				this.尾14_鱗右1CD.不透明度 = value;
				this.尾13_尾CD.不透明度 = value;
				this.尾13_鱗左3CD.不透明度 = value;
				this.尾13_鱗右3CD.不透明度 = value;
				this.尾13_鱗左2CD.不透明度 = value;
				this.尾13_鱗右2CD.不透明度 = value;
				this.尾13_鱗左1CD.不透明度 = value;
				this.尾13_鱗右1CD.不透明度 = value;
				this.尾12_尾CD.不透明度 = value;
				this.尾12_鱗左3CD.不透明度 = value;
				this.尾12_鱗右3CD.不透明度 = value;
				this.尾12_鱗左2CD.不透明度 = value;
				this.尾12_鱗右2CD.不透明度 = value;
				this.尾12_鱗左1CD.不透明度 = value;
				this.尾12_鱗右1CD.不透明度 = value;
				this.尾11_尾CD.不透明度 = value;
				this.尾11_鱗左3CD.不透明度 = value;
				this.尾11_鱗右3CD.不透明度 = value;
				this.尾11_鱗左2CD.不透明度 = value;
				this.尾11_鱗右2CD.不透明度 = value;
				this.尾11_鱗左1CD.不透明度 = value;
				this.尾11_鱗右1CD.不透明度 = value;
				this.尾10_尾CD.不透明度 = value;
				this.尾10_鱗左3CD.不透明度 = value;
				this.尾10_鱗右3CD.不透明度 = value;
				this.尾10_鱗左2CD.不透明度 = value;
				this.尾10_鱗右2CD.不透明度 = value;
				this.尾10_鱗左1CD.不透明度 = value;
				this.尾10_鱗右1CD.不透明度 = value;
				this.尾9_尾CD.不透明度 = value;
				this.尾9_鱗左3CD.不透明度 = value;
				this.尾9_鱗右3CD.不透明度 = value;
				this.尾9_鱗左2CD.不透明度 = value;
				this.尾9_鱗右2CD.不透明度 = value;
				this.尾9_鱗左1CD.不透明度 = value;
				this.尾9_鱗右1CD.不透明度 = value;
				this.尾8_尾CD.不透明度 = value;
				this.尾8_鱗左3CD.不透明度 = value;
				this.尾8_鱗右3CD.不透明度 = value;
				this.尾8_鱗左2CD.不透明度 = value;
				this.尾8_鱗右2CD.不透明度 = value;
				this.尾8_鱗左1CD.不透明度 = value;
				this.尾8_鱗右1CD.不透明度 = value;
				this.尾7_尾CD.不透明度 = value;
				this.尾7_鱗左3CD.不透明度 = value;
				this.尾7_鱗右3CD.不透明度 = value;
				this.尾7_鱗左2CD.不透明度 = value;
				this.尾7_鱗右2CD.不透明度 = value;
				this.尾7_鱗左1CD.不透明度 = value;
				this.尾7_鱗右1CD.不透明度 = value;
				this.尾6_尾CD.不透明度 = value;
				this.尾6_鱗左3CD.不透明度 = value;
				this.尾6_鱗右3CD.不透明度 = value;
				this.尾6_鱗左2CD.不透明度 = value;
				this.尾6_鱗右2CD.不透明度 = value;
				this.尾6_鱗左1CD.不透明度 = value;
				this.尾6_鱗右1CD.不透明度 = value;
				this.尾5_尾CD.不透明度 = value;
				this.尾5_鱗左3CD.不透明度 = value;
				this.尾5_鱗右3CD.不透明度 = value;
				this.尾5_鱗左2CD.不透明度 = value;
				this.尾5_鱗右2CD.不透明度 = value;
				this.尾5_鱗左1CD.不透明度 = value;
				this.尾5_鱗右1CD.不透明度 = value;
				this.尾4_尾CD.不透明度 = value;
				this.尾4_鱗左3CD.不透明度 = value;
				this.尾4_鱗右3CD.不透明度 = value;
				this.尾4_鱗左2CD.不透明度 = value;
				this.尾4_鱗右2CD.不透明度 = value;
				this.尾4_鱗左1CD.不透明度 = value;
				this.尾4_鱗右1CD.不透明度 = value;
				this.尾3_尾CD.不透明度 = value;
				this.尾3_鱗左3CD.不透明度 = value;
				this.尾3_鱗右3CD.不透明度 = value;
				this.尾3_鱗左2CD.不透明度 = value;
				this.尾3_鱗右2CD.不透明度 = value;
				this.尾3_鱗左1CD.不透明度 = value;
				this.尾3_鱗右1CD.不透明度 = value;
				this.尾2_尾CD.不透明度 = value;
				this.尾2_鱗左3CD.不透明度 = value;
				this.尾2_鱗右3CD.不透明度 = value;
				this.尾2_鱗左2CD.不透明度 = value;
				this.尾2_鱗右2CD.不透明度 = value;
				this.尾2_鱗左1CD.不透明度 = value;
				this.尾2_鱗右1CD.不透明度 = value;
				this.尾1_尾CD.不透明度 = value;
				this.尾1_鱗左3CD.不透明度 = value;
				this.尾1_鱗右3CD.不透明度 = value;
				this.尾1_鱗左2CD.不透明度 = value;
				this.尾1_鱗右2CD.不透明度 = value;
				this.尾1_鱗左1CD.不透明度 = value;
				this.尾1_鱗右1CD.不透明度 = value;
				this.尾0_尾CD.不透明度 = value;
				this.尾0_鱗右CD.不透明度 = value;
				this.尾0_鱗左CD.不透明度 = value;
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
			this.X0Y0_尾35_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾34_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾33_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾32_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾31_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾30_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾29_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾28_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾27_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾26_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾25_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾24_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾23_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾22_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾21_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾20_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾19_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾18_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾17_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾16_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾15_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾14_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾13_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾12_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾11_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾10_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾9_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾8_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾7_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾6_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾5_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾4_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾3_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾2_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾1_尾.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_尾0_尾.AngleBase = maxAngle.GetRanAngle();
			this.本体.JoinPAall();
			if (this.尾先_接続 != null)
			{
				this.Set尾先角度();
			}
		}

		public override void Set尾先角度()
		{
			this.X0Y0_尾35_尾.AngleBase = 0.0;
			this.X0Y0_尾34_尾.AngleBase = 0.0;
			this.X0Y0_尾33_尾.AngleBase = 0.0;
			this.X0Y0_尾32_尾.AngleBase = 0.0;
			this.X0Y0_尾31_尾.AngleBase = 0.0;
			this.X0Y0_尾30_尾.AngleBase = 0.0;
			this.X0Y0_尾29_尾.AngleBase = 0.0;
			this.X0Y0_尾28_尾.AngleBase = 0.0;
			this.X0Y0_尾27_尾.AngleBase = 0.0;
			this.X0Y0_尾26_尾.AngleBase = 0.0;
			this.X0Y0_尾25_尾.AngleBase = 0.0;
			this.X0Y0_尾24_尾.AngleBase = 0.0;
			this.X0Y0_尾23_尾.AngleBase = 0.0;
			this.X0Y0_尾22_尾.AngleBase = 0.0;
			this.X0Y0_尾21_尾.AngleBase = 0.0;
			this.X0Y0_尾20_尾.AngleBase = 0.0;
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_輪2_革 || p == this.X0Y0_輪2_金具1 || p == this.X0Y0_輪2_金具2 || p == this.X0Y0_輪2_金具3 || p == this.X0Y0_輪2_金具左 || p == this.X0Y0_輪2_金具右 || p == this.X0Y0_輪1_革 || p == this.X0Y0_輪1_金具1 || p == this.X0Y0_輪1_金具2 || p == this.X0Y0_輪1_金具3 || p == this.X0Y0_輪1_金具左 || p == this.X0Y0_輪1_金具右;
		}

		public override IEnumerable<Par> Enum軸()
		{
			yield return this.X0Y0_尾0_尾;
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
			yield break;
		}

		public JointS 尾先_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾19_尾, 0);
			}
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
			this.X0Y0_尾35_尾CP.Update();
			this.X0Y0_尾35_鱗左3CP.Update();
			this.X0Y0_尾35_鱗右3CP.Update();
			this.X0Y0_尾35_鱗左2CP.Update();
			this.X0Y0_尾35_鱗右2CP.Update();
			this.X0Y0_尾35_鱗左1CP.Update();
			this.X0Y0_尾35_鱗右1CP.Update();
			this.X0Y0_尾34_尾CP.Update();
			this.X0Y0_尾34_鱗左3CP.Update();
			this.X0Y0_尾34_鱗右3CP.Update();
			this.X0Y0_尾34_鱗左2CP.Update();
			this.X0Y0_尾34_鱗右2CP.Update();
			this.X0Y0_尾34_鱗左1CP.Update();
			this.X0Y0_尾34_鱗右1CP.Update();
			this.X0Y0_尾33_尾CP.Update();
			this.X0Y0_尾33_鱗左3CP.Update();
			this.X0Y0_尾33_鱗右3CP.Update();
			this.X0Y0_尾33_鱗左2CP.Update();
			this.X0Y0_尾33_鱗右2CP.Update();
			this.X0Y0_尾33_鱗左1CP.Update();
			this.X0Y0_尾33_鱗右1CP.Update();
			this.X0Y0_尾32_尾CP.Update();
			this.X0Y0_尾32_鱗左3CP.Update();
			this.X0Y0_尾32_鱗右3CP.Update();
			this.X0Y0_尾32_鱗左2CP.Update();
			this.X0Y0_尾32_鱗右2CP.Update();
			this.X0Y0_尾32_鱗左1CP.Update();
			this.X0Y0_尾32_鱗右1CP.Update();
			this.X0Y0_尾31_尾CP.Update();
			this.X0Y0_尾31_鱗左3CP.Update();
			this.X0Y0_尾31_鱗右3CP.Update();
			this.X0Y0_尾31_鱗左2CP.Update();
			this.X0Y0_尾31_鱗右2CP.Update();
			this.X0Y0_尾31_鱗左1CP.Update();
			this.X0Y0_尾31_鱗右1CP.Update();
			this.X0Y0_尾30_尾CP.Update();
			this.X0Y0_尾30_鱗左3CP.Update();
			this.X0Y0_尾30_鱗右3CP.Update();
			this.X0Y0_尾30_鱗左2CP.Update();
			this.X0Y0_尾30_鱗右2CP.Update();
			this.X0Y0_尾30_鱗左1CP.Update();
			this.X0Y0_尾30_鱗右1CP.Update();
			this.X0Y0_尾29_尾CP.Update();
			this.X0Y0_尾29_鱗左3CP.Update();
			this.X0Y0_尾29_鱗右3CP.Update();
			this.X0Y0_尾29_鱗左2CP.Update();
			this.X0Y0_尾29_鱗右2CP.Update();
			this.X0Y0_尾29_鱗左1CP.Update();
			this.X0Y0_尾29_鱗右1CP.Update();
			this.X0Y0_尾28_尾CP.Update();
			this.X0Y0_尾28_鱗左3CP.Update();
			this.X0Y0_尾28_鱗右3CP.Update();
			this.X0Y0_尾28_鱗左2CP.Update();
			this.X0Y0_尾28_鱗右2CP.Update();
			this.X0Y0_尾28_鱗左1CP.Update();
			this.X0Y0_尾28_鱗右1CP.Update();
			this.X0Y0_尾27_尾CP.Update();
			this.X0Y0_尾27_鱗左3CP.Update();
			this.X0Y0_尾27_鱗右3CP.Update();
			this.X0Y0_尾27_鱗左2CP.Update();
			this.X0Y0_尾27_鱗右2CP.Update();
			this.X0Y0_尾27_鱗左1CP.Update();
			this.X0Y0_尾27_鱗右1CP.Update();
			this.X0Y0_尾26_尾CP.Update();
			this.X0Y0_尾26_鱗左3CP.Update();
			this.X0Y0_尾26_鱗右3CP.Update();
			this.X0Y0_尾26_鱗左2CP.Update();
			this.X0Y0_尾26_鱗右2CP.Update();
			this.X0Y0_尾26_鱗左1CP.Update();
			this.X0Y0_尾26_鱗右1CP.Update();
			this.X0Y0_尾25_尾CP.Update();
			this.X0Y0_尾25_鱗左3CP.Update();
			this.X0Y0_尾25_鱗右3CP.Update();
			this.X0Y0_尾25_鱗左2CP.Update();
			this.X0Y0_尾25_鱗右2CP.Update();
			this.X0Y0_尾25_鱗左1CP.Update();
			this.X0Y0_尾25_鱗右1CP.Update();
			this.X0Y0_尾24_尾CP.Update();
			this.X0Y0_尾24_鱗左3CP.Update();
			this.X0Y0_尾24_鱗右3CP.Update();
			this.X0Y0_尾24_鱗左2CP.Update();
			this.X0Y0_尾24_鱗右2CP.Update();
			this.X0Y0_尾24_鱗左1CP.Update();
			this.X0Y0_尾24_鱗右1CP.Update();
			this.X0Y0_尾23_尾CP.Update();
			this.X0Y0_尾23_鱗左3CP.Update();
			this.X0Y0_尾23_鱗右3CP.Update();
			this.X0Y0_尾23_鱗左2CP.Update();
			this.X0Y0_尾23_鱗右2CP.Update();
			this.X0Y0_尾23_鱗左1CP.Update();
			this.X0Y0_尾23_鱗右1CP.Update();
			this.X0Y0_尾22_尾CP.Update();
			this.X0Y0_尾22_鱗左3CP.Update();
			this.X0Y0_尾22_鱗右3CP.Update();
			this.X0Y0_尾22_鱗左2CP.Update();
			this.X0Y0_尾22_鱗右2CP.Update();
			this.X0Y0_尾22_鱗左1CP.Update();
			this.X0Y0_尾22_鱗右1CP.Update();
			this.X0Y0_尾21_尾CP.Update();
			this.X0Y0_尾21_鱗左3CP.Update();
			this.X0Y0_尾21_鱗右3CP.Update();
			this.X0Y0_尾21_鱗左2CP.Update();
			this.X0Y0_尾21_鱗右2CP.Update();
			this.X0Y0_尾21_鱗左1CP.Update();
			this.X0Y0_尾21_鱗右1CP.Update();
			this.X0Y0_尾20_尾CP.Update();
			this.X0Y0_尾20_鱗左3CP.Update();
			this.X0Y0_尾20_鱗右3CP.Update();
			this.X0Y0_尾20_鱗左2CP.Update();
			this.X0Y0_尾20_鱗右2CP.Update();
			this.X0Y0_尾20_鱗左1CP.Update();
			this.X0Y0_尾20_鱗右1CP.Update();
			this.X0Y0_尾19_尾CP.Update();
			this.X0Y0_尾19_鱗左3CP.Update();
			this.X0Y0_尾19_鱗右3CP.Update();
			this.X0Y0_尾19_鱗左2CP.Update();
			this.X0Y0_尾19_鱗右2CP.Update();
			this.X0Y0_尾19_鱗左1CP.Update();
			this.X0Y0_尾19_鱗右1CP.Update();
			this.X0Y0_尾18_尾CP.Update();
			this.X0Y0_尾18_鱗左3CP.Update();
			this.X0Y0_尾18_鱗右3CP.Update();
			this.X0Y0_尾18_鱗左2CP.Update();
			this.X0Y0_尾18_鱗右2CP.Update();
			this.X0Y0_尾18_鱗左1CP.Update();
			this.X0Y0_尾18_鱗右1CP.Update();
			this.X0Y0_尾17_尾CP.Update();
			this.X0Y0_尾17_鱗左3CP.Update();
			this.X0Y0_尾17_鱗右3CP.Update();
			this.X0Y0_尾17_鱗左2CP.Update();
			this.X0Y0_尾17_鱗右2CP.Update();
			this.X0Y0_尾17_鱗左1CP.Update();
			this.X0Y0_尾17_鱗右1CP.Update();
			this.X0Y0_尾16_尾CP.Update();
			this.X0Y0_尾16_鱗左3CP.Update();
			this.X0Y0_尾16_鱗右3CP.Update();
			this.X0Y0_尾16_鱗左2CP.Update();
			this.X0Y0_尾16_鱗右2CP.Update();
			this.X0Y0_尾16_鱗左1CP.Update();
			this.X0Y0_尾16_鱗右1CP.Update();
			this.X0Y0_尾15_尾CP.Update();
			this.X0Y0_尾15_鱗左3CP.Update();
			this.X0Y0_尾15_鱗右3CP.Update();
			this.X0Y0_尾15_鱗左2CP.Update();
			this.X0Y0_尾15_鱗右2CP.Update();
			this.X0Y0_尾15_鱗左1CP.Update();
			this.X0Y0_尾15_鱗右1CP.Update();
			this.X0Y0_尾14_尾CP.Update();
			this.X0Y0_尾14_鱗左3CP.Update();
			this.X0Y0_尾14_鱗右3CP.Update();
			this.X0Y0_尾14_鱗左2CP.Update();
			this.X0Y0_尾14_鱗右2CP.Update();
			this.X0Y0_尾14_鱗左1CP.Update();
			this.X0Y0_尾14_鱗右1CP.Update();
			this.X0Y0_尾13_尾CP.Update();
			this.X0Y0_尾13_鱗左3CP.Update();
			this.X0Y0_尾13_鱗右3CP.Update();
			this.X0Y0_尾13_鱗左2CP.Update();
			this.X0Y0_尾13_鱗右2CP.Update();
			this.X0Y0_尾13_鱗左1CP.Update();
			this.X0Y0_尾13_鱗右1CP.Update();
			this.X0Y0_尾12_尾CP.Update();
			this.X0Y0_尾12_鱗左3CP.Update();
			this.X0Y0_尾12_鱗右3CP.Update();
			this.X0Y0_尾12_鱗左2CP.Update();
			this.X0Y0_尾12_鱗右2CP.Update();
			this.X0Y0_尾12_鱗左1CP.Update();
			this.X0Y0_尾12_鱗右1CP.Update();
			this.X0Y0_尾11_尾CP.Update();
			this.X0Y0_尾11_鱗左3CP.Update();
			this.X0Y0_尾11_鱗右3CP.Update();
			this.X0Y0_尾11_鱗左2CP.Update();
			this.X0Y0_尾11_鱗右2CP.Update();
			this.X0Y0_尾11_鱗左1CP.Update();
			this.X0Y0_尾11_鱗右1CP.Update();
			this.X0Y0_尾10_尾CP.Update();
			this.X0Y0_尾10_鱗左3CP.Update();
			this.X0Y0_尾10_鱗右3CP.Update();
			this.X0Y0_尾10_鱗左2CP.Update();
			this.X0Y0_尾10_鱗右2CP.Update();
			this.X0Y0_尾10_鱗左1CP.Update();
			this.X0Y0_尾10_鱗右1CP.Update();
			this.X0Y0_尾9_尾CP.Update();
			this.X0Y0_尾9_鱗左3CP.Update();
			this.X0Y0_尾9_鱗右3CP.Update();
			this.X0Y0_尾9_鱗左2CP.Update();
			this.X0Y0_尾9_鱗右2CP.Update();
			this.X0Y0_尾9_鱗左1CP.Update();
			this.X0Y0_尾9_鱗右1CP.Update();
			this.X0Y0_尾8_尾CP.Update();
			this.X0Y0_尾8_鱗左3CP.Update();
			this.X0Y0_尾8_鱗右3CP.Update();
			this.X0Y0_尾8_鱗左2CP.Update();
			this.X0Y0_尾8_鱗右2CP.Update();
			this.X0Y0_尾8_鱗左1CP.Update();
			this.X0Y0_尾8_鱗右1CP.Update();
			this.X0Y0_尾7_尾CP.Update();
			this.X0Y0_尾7_鱗左3CP.Update();
			this.X0Y0_尾7_鱗右3CP.Update();
			this.X0Y0_尾7_鱗左2CP.Update();
			this.X0Y0_尾7_鱗右2CP.Update();
			this.X0Y0_尾7_鱗左1CP.Update();
			this.X0Y0_尾7_鱗右1CP.Update();
			this.X0Y0_尾6_尾CP.Update();
			this.X0Y0_尾6_鱗左3CP.Update();
			this.X0Y0_尾6_鱗右3CP.Update();
			this.X0Y0_尾6_鱗左2CP.Update();
			this.X0Y0_尾6_鱗右2CP.Update();
			this.X0Y0_尾6_鱗左1CP.Update();
			this.X0Y0_尾6_鱗右1CP.Update();
			this.X0Y0_尾5_尾CP.Update();
			this.X0Y0_尾5_鱗左3CP.Update();
			this.X0Y0_尾5_鱗右3CP.Update();
			this.X0Y0_尾5_鱗左2CP.Update();
			this.X0Y0_尾5_鱗右2CP.Update();
			this.X0Y0_尾5_鱗左1CP.Update();
			this.X0Y0_尾5_鱗右1CP.Update();
			this.X0Y0_尾4_尾CP.Update();
			this.X0Y0_尾4_鱗左3CP.Update();
			this.X0Y0_尾4_鱗右3CP.Update();
			this.X0Y0_尾4_鱗左2CP.Update();
			this.X0Y0_尾4_鱗右2CP.Update();
			this.X0Y0_尾4_鱗左1CP.Update();
			this.X0Y0_尾4_鱗右1CP.Update();
			this.X0Y0_尾3_尾CP.Update();
			this.X0Y0_尾3_鱗左3CP.Update();
			this.X0Y0_尾3_鱗右3CP.Update();
			this.X0Y0_尾3_鱗左2CP.Update();
			this.X0Y0_尾3_鱗右2CP.Update();
			this.X0Y0_尾3_鱗左1CP.Update();
			this.X0Y0_尾3_鱗右1CP.Update();
			this.X0Y0_尾2_尾CP.Update();
			this.X0Y0_尾2_鱗左3CP.Update();
			this.X0Y0_尾2_鱗右3CP.Update();
			this.X0Y0_尾2_鱗左2CP.Update();
			this.X0Y0_尾2_鱗右2CP.Update();
			this.X0Y0_尾2_鱗左1CP.Update();
			this.X0Y0_尾2_鱗右1CP.Update();
			this.X0Y0_尾1_尾CP.Update();
			this.X0Y0_尾1_鱗左3CP.Update();
			this.X0Y0_尾1_鱗右3CP.Update();
			this.X0Y0_尾1_鱗左2CP.Update();
			this.X0Y0_尾1_鱗右2CP.Update();
			this.X0Y0_尾1_鱗左1CP.Update();
			this.X0Y0_尾1_鱗右1CP.Update();
			this.X0Y0_尾0_尾CP.Update();
			this.X0Y0_尾0_鱗右CP.Update();
			this.X0Y0_尾0_鱗左CP.Update();
			this.X0Y0_輪1_革CP.Update();
			this.X0Y0_輪1_金具1CP.Update();
			this.X0Y0_輪1_金具2CP.Update();
			this.X0Y0_輪1_金具3CP.Update();
			this.X0Y0_輪1_金具左CP.Update();
			this.X0Y0_輪1_金具右CP.Update();
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
			this.尾35_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾35_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾35_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾35_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾35_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾35_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾35_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾34_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾34_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾34_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾34_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾34_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾34_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾34_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾33_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾33_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾33_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾33_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾33_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾33_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾33_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾32_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾32_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾32_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾32_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾32_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾32_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾32_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾31_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾31_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾31_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾31_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾31_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾31_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾31_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾30_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾30_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾30_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾30_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾30_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾30_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾30_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾29_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾29_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾29_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾29_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾29_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾29_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾29_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾28_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾28_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾28_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾28_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾28_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾28_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾28_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾27_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾27_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾27_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾27_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾27_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾27_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾27_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾26_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾26_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾26_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾26_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾26_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾26_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾26_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾25_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾25_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾25_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾25_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾25_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾25_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾25_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾24_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾24_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾24_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾24_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾24_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾24_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾24_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾23_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾23_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾23_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾23_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾23_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾23_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾23_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾22_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾22_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾22_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾22_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾22_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾22_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾22_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾21_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾21_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾21_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾21_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾21_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾21_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾21_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾20_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾20_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾20_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾20_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾20_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾20_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾20_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾19_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾19_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾19_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾19_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾19_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾19_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾19_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾18_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾18_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾18_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾18_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾18_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾18_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾18_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾17_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾17_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾17_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾17_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾17_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾17_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾17_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾16_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾16_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾16_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾16_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾16_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾16_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾16_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾15_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾15_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾15_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾15_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾15_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾15_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾15_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾14_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾14_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾14_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾14_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾14_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾14_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾14_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾13_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾13_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾13_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾13_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾13_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾13_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾13_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾12_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾12_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾12_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾12_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾12_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾12_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾12_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾11_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾11_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾11_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾11_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾11_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾11_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾11_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾10_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾10_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾10_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾10_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾10_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾10_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾10_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾9_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾9_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾9_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾9_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾9_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾9_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾9_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾8_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾8_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾8_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾8_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾8_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾8_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾8_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾7_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾7_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾7_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾7_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾7_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾7_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾7_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾6_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾6_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾6_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾6_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾6_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾6_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾6_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾5_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾5_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾5_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾5_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾5_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾5_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾5_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾4_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾4_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾4_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾4_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾4_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾4_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾4_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾3_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾3_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾3_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾3_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾3_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾3_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾3_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾2_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾2_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾2_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾2_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾2_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾2_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾2_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾1_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾1_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾1_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾1_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾1_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾1_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾1_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾0_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾0_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾0_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
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
			this.尾35_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾35_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾35_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾35_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾35_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾35_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾35_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾34_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾34_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾34_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾34_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾34_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾34_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾34_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾33_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾33_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾33_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾33_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾33_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾33_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾33_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾32_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾32_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾32_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾32_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾32_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾32_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾32_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾31_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾31_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾31_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾31_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾31_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾31_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾31_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾30_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾30_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾30_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾30_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾30_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾30_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾30_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾29_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾29_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾29_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾29_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾29_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾29_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾29_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾28_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾28_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾28_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾28_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾28_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾28_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾28_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾27_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾27_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾27_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾27_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾27_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾27_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾27_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾26_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾26_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾26_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾26_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾26_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾26_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾26_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾25_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾25_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾25_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾25_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾25_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾25_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾25_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾24_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾24_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾24_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾24_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾24_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾24_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾24_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾23_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾23_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾23_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾23_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾23_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾23_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾23_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾22_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾22_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾22_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾22_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾22_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾22_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾22_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾21_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾21_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾21_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾21_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾21_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾21_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾21_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾20_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾20_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾20_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾20_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾20_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾20_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾20_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾19_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾19_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾19_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾19_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾19_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾19_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾19_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾18_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾18_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾18_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾18_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾18_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾18_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾18_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾17_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾17_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾17_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾17_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾17_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾17_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾17_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾16_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾16_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾16_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾16_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾16_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾16_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾16_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾15_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾15_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾15_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾15_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾15_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾15_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾15_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾14_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾14_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾14_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾14_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾14_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾14_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾14_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾13_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾13_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾13_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾13_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾13_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾13_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾13_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾12_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾12_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾12_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾12_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾12_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾12_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾12_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾11_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾11_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾11_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾11_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾11_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾11_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾11_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾10_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾10_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾10_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾10_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾10_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾10_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾10_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾9_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾9_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾9_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾9_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾9_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾9_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾9_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾8_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾8_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾8_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾8_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾8_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾8_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾8_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾7_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾7_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾7_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾7_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾7_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾7_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾7_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾6_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾6_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾6_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾6_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾6_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾6_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾6_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾5_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾5_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾5_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾5_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾5_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾5_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾5_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾4_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾4_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾4_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾4_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾3_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾3_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾3_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾3_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾2_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾2_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾2_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾2_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾1_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾1_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾1_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾1_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾0_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾0_鱗右CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾0_鱗左CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
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
			this.尾35_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾35_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾35_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾35_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾35_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾35_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾35_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾34_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾34_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾34_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾34_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾34_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾34_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾34_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾33_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾33_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾33_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾33_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾33_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾33_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾33_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾32_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾32_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾32_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾32_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾32_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾32_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾32_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾31_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾31_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾31_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾31_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾31_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾31_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾31_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾30_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾30_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾30_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾30_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾30_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾30_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾30_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾29_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾29_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾29_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾29_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾29_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾29_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾29_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾28_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾28_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾28_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾28_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾28_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾28_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾28_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾27_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾27_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾27_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾27_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾27_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾27_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾27_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾26_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾26_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾26_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾26_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾26_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾26_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾26_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾25_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾25_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾25_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾25_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾25_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾25_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾25_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾24_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾24_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾24_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾24_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾24_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾24_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾24_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾23_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾23_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾23_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾23_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾23_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾23_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾23_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾22_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾22_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾22_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾22_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾22_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾22_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾22_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾21_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾21_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾21_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾21_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾21_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾21_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾21_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾20_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾20_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾20_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾20_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾20_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾20_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾20_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾19_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾19_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾19_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾19_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾19_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾19_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾19_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾18_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾18_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾18_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾18_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾18_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾18_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾18_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾17_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾17_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾17_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾17_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾17_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾17_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾17_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾16_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾16_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾16_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾16_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾16_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾16_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾16_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾15_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾15_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾15_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾15_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾15_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾15_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾15_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾14_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾14_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾14_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾14_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾14_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾14_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾14_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾13_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾13_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾13_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾13_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾13_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾13_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾13_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾12_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾12_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾12_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾12_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾12_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾12_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾12_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾11_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾11_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾11_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾11_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾11_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾11_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾11_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾10_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾10_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾10_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾10_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾10_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾10_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾10_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾9_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾9_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾9_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾9_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾9_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾9_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾9_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾8_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾8_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾8_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾8_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾8_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾8_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾8_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾7_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾7_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾7_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾7_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾7_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾7_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾7_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾6_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾6_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾6_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾6_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾6_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾6_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾6_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾5_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾5_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾5_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾5_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾5_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾5_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾5_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾4_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾4_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾4_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾3_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾3_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾3_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾2_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾2_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾2_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_鱗左3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾1_鱗右3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾1_鱗左2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_鱗右2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_鱗左1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾1_鱗右1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾0_尾CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾0_鱗右CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾0_鱗左CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
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

		public Par X0Y0_尾35_尾;

		public Par X0Y0_尾35_鱗左3;

		public Par X0Y0_尾35_鱗右3;

		public Par X0Y0_尾35_鱗左2;

		public Par X0Y0_尾35_鱗右2;

		public Par X0Y0_尾35_鱗左1;

		public Par X0Y0_尾35_鱗右1;

		public Par X0Y0_尾34_尾;

		public Par X0Y0_尾34_鱗左3;

		public Par X0Y0_尾34_鱗右3;

		public Par X0Y0_尾34_鱗左2;

		public Par X0Y0_尾34_鱗右2;

		public Par X0Y0_尾34_鱗左1;

		public Par X0Y0_尾34_鱗右1;

		public Par X0Y0_尾33_尾;

		public Par X0Y0_尾33_鱗左3;

		public Par X0Y0_尾33_鱗右3;

		public Par X0Y0_尾33_鱗左2;

		public Par X0Y0_尾33_鱗右2;

		public Par X0Y0_尾33_鱗左1;

		public Par X0Y0_尾33_鱗右1;

		public Par X0Y0_尾32_尾;

		public Par X0Y0_尾32_鱗左3;

		public Par X0Y0_尾32_鱗右3;

		public Par X0Y0_尾32_鱗左2;

		public Par X0Y0_尾32_鱗右2;

		public Par X0Y0_尾32_鱗左1;

		public Par X0Y0_尾32_鱗右1;

		public Par X0Y0_尾31_尾;

		public Par X0Y0_尾31_鱗左3;

		public Par X0Y0_尾31_鱗右3;

		public Par X0Y0_尾31_鱗左2;

		public Par X0Y0_尾31_鱗右2;

		public Par X0Y0_尾31_鱗左1;

		public Par X0Y0_尾31_鱗右1;

		public Par X0Y0_尾30_尾;

		public Par X0Y0_尾30_鱗左3;

		public Par X0Y0_尾30_鱗右3;

		public Par X0Y0_尾30_鱗左2;

		public Par X0Y0_尾30_鱗右2;

		public Par X0Y0_尾30_鱗左1;

		public Par X0Y0_尾30_鱗右1;

		public Par X0Y0_尾29_尾;

		public Par X0Y0_尾29_鱗左3;

		public Par X0Y0_尾29_鱗右3;

		public Par X0Y0_尾29_鱗左2;

		public Par X0Y0_尾29_鱗右2;

		public Par X0Y0_尾29_鱗左1;

		public Par X0Y0_尾29_鱗右1;

		public Par X0Y0_尾28_尾;

		public Par X0Y0_尾28_鱗左3;

		public Par X0Y0_尾28_鱗右3;

		public Par X0Y0_尾28_鱗左2;

		public Par X0Y0_尾28_鱗右2;

		public Par X0Y0_尾28_鱗左1;

		public Par X0Y0_尾28_鱗右1;

		public Par X0Y0_尾27_尾;

		public Par X0Y0_尾27_鱗左3;

		public Par X0Y0_尾27_鱗右3;

		public Par X0Y0_尾27_鱗左2;

		public Par X0Y0_尾27_鱗右2;

		public Par X0Y0_尾27_鱗左1;

		public Par X0Y0_尾27_鱗右1;

		public Par X0Y0_尾26_尾;

		public Par X0Y0_尾26_鱗左3;

		public Par X0Y0_尾26_鱗右3;

		public Par X0Y0_尾26_鱗左2;

		public Par X0Y0_尾26_鱗右2;

		public Par X0Y0_尾26_鱗左1;

		public Par X0Y0_尾26_鱗右1;

		public Par X0Y0_尾25_尾;

		public Par X0Y0_尾25_鱗左3;

		public Par X0Y0_尾25_鱗右3;

		public Par X0Y0_尾25_鱗左2;

		public Par X0Y0_尾25_鱗右2;

		public Par X0Y0_尾25_鱗左1;

		public Par X0Y0_尾25_鱗右1;

		public Par X0Y0_尾24_尾;

		public Par X0Y0_尾24_鱗左3;

		public Par X0Y0_尾24_鱗右3;

		public Par X0Y0_尾24_鱗左2;

		public Par X0Y0_尾24_鱗右2;

		public Par X0Y0_尾24_鱗左1;

		public Par X0Y0_尾24_鱗右1;

		public Par X0Y0_尾23_尾;

		public Par X0Y0_尾23_鱗左3;

		public Par X0Y0_尾23_鱗右3;

		public Par X0Y0_尾23_鱗左2;

		public Par X0Y0_尾23_鱗右2;

		public Par X0Y0_尾23_鱗左1;

		public Par X0Y0_尾23_鱗右1;

		public Par X0Y0_尾22_尾;

		public Par X0Y0_尾22_鱗左3;

		public Par X0Y0_尾22_鱗右3;

		public Par X0Y0_尾22_鱗左2;

		public Par X0Y0_尾22_鱗右2;

		public Par X0Y0_尾22_鱗左1;

		public Par X0Y0_尾22_鱗右1;

		public Par X0Y0_尾21_尾;

		public Par X0Y0_尾21_鱗左3;

		public Par X0Y0_尾21_鱗右3;

		public Par X0Y0_尾21_鱗左2;

		public Par X0Y0_尾21_鱗右2;

		public Par X0Y0_尾21_鱗左1;

		public Par X0Y0_尾21_鱗右1;

		public Par X0Y0_尾20_尾;

		public Par X0Y0_尾20_鱗左3;

		public Par X0Y0_尾20_鱗右3;

		public Par X0Y0_尾20_鱗左2;

		public Par X0Y0_尾20_鱗右2;

		public Par X0Y0_尾20_鱗左1;

		public Par X0Y0_尾20_鱗右1;

		public Par X0Y0_尾19_尾;

		public Par X0Y0_尾19_鱗左3;

		public Par X0Y0_尾19_鱗右3;

		public Par X0Y0_尾19_鱗左2;

		public Par X0Y0_尾19_鱗右2;

		public Par X0Y0_尾19_鱗左1;

		public Par X0Y0_尾19_鱗右1;

		public Par X0Y0_尾18_尾;

		public Par X0Y0_尾18_鱗左3;

		public Par X0Y0_尾18_鱗右3;

		public Par X0Y0_尾18_鱗左2;

		public Par X0Y0_尾18_鱗右2;

		public Par X0Y0_尾18_鱗左1;

		public Par X0Y0_尾18_鱗右1;

		public Par X0Y0_尾17_尾;

		public Par X0Y0_尾17_鱗左3;

		public Par X0Y0_尾17_鱗右3;

		public Par X0Y0_尾17_鱗左2;

		public Par X0Y0_尾17_鱗右2;

		public Par X0Y0_尾17_鱗左1;

		public Par X0Y0_尾17_鱗右1;

		public Par X0Y0_尾16_尾;

		public Par X0Y0_尾16_鱗左3;

		public Par X0Y0_尾16_鱗右3;

		public Par X0Y0_尾16_鱗左2;

		public Par X0Y0_尾16_鱗右2;

		public Par X0Y0_尾16_鱗左1;

		public Par X0Y0_尾16_鱗右1;

		public Par X0Y0_尾15_尾;

		public Par X0Y0_尾15_鱗左3;

		public Par X0Y0_尾15_鱗右3;

		public Par X0Y0_尾15_鱗左2;

		public Par X0Y0_尾15_鱗右2;

		public Par X0Y0_尾15_鱗左1;

		public Par X0Y0_尾15_鱗右1;

		public Par X0Y0_尾14_尾;

		public Par X0Y0_尾14_鱗左3;

		public Par X0Y0_尾14_鱗右3;

		public Par X0Y0_尾14_鱗左2;

		public Par X0Y0_尾14_鱗右2;

		public Par X0Y0_尾14_鱗左1;

		public Par X0Y0_尾14_鱗右1;

		public Par X0Y0_尾13_尾;

		public Par X0Y0_尾13_鱗左3;

		public Par X0Y0_尾13_鱗右3;

		public Par X0Y0_尾13_鱗左2;

		public Par X0Y0_尾13_鱗右2;

		public Par X0Y0_尾13_鱗左1;

		public Par X0Y0_尾13_鱗右1;

		public Par X0Y0_尾12_尾;

		public Par X0Y0_尾12_鱗左3;

		public Par X0Y0_尾12_鱗右3;

		public Par X0Y0_尾12_鱗左2;

		public Par X0Y0_尾12_鱗右2;

		public Par X0Y0_尾12_鱗左1;

		public Par X0Y0_尾12_鱗右1;

		public Par X0Y0_尾11_尾;

		public Par X0Y0_尾11_鱗左3;

		public Par X0Y0_尾11_鱗右3;

		public Par X0Y0_尾11_鱗左2;

		public Par X0Y0_尾11_鱗右2;

		public Par X0Y0_尾11_鱗左1;

		public Par X0Y0_尾11_鱗右1;

		public Par X0Y0_尾10_尾;

		public Par X0Y0_尾10_鱗左3;

		public Par X0Y0_尾10_鱗右3;

		public Par X0Y0_尾10_鱗左2;

		public Par X0Y0_尾10_鱗右2;

		public Par X0Y0_尾10_鱗左1;

		public Par X0Y0_尾10_鱗右1;

		public Par X0Y0_尾9_尾;

		public Par X0Y0_尾9_鱗左3;

		public Par X0Y0_尾9_鱗右3;

		public Par X0Y0_尾9_鱗左2;

		public Par X0Y0_尾9_鱗右2;

		public Par X0Y0_尾9_鱗左1;

		public Par X0Y0_尾9_鱗右1;

		public Par X0Y0_尾8_尾;

		public Par X0Y0_尾8_鱗左3;

		public Par X0Y0_尾8_鱗右3;

		public Par X0Y0_尾8_鱗左2;

		public Par X0Y0_尾8_鱗右2;

		public Par X0Y0_尾8_鱗左1;

		public Par X0Y0_尾8_鱗右1;

		public Par X0Y0_輪2_革;

		public Par X0Y0_輪2_金具1;

		public Par X0Y0_輪2_金具2;

		public Par X0Y0_輪2_金具3;

		public Par X0Y0_輪2_金具左;

		public Par X0Y0_輪2_金具右;

		public Par X0Y0_尾7_尾;

		public Par X0Y0_尾7_鱗左3;

		public Par X0Y0_尾7_鱗右3;

		public Par X0Y0_尾7_鱗左2;

		public Par X0Y0_尾7_鱗右2;

		public Par X0Y0_尾7_鱗左1;

		public Par X0Y0_尾7_鱗右1;

		public Par X0Y0_尾6_尾;

		public Par X0Y0_尾6_鱗左3;

		public Par X0Y0_尾6_鱗右3;

		public Par X0Y0_尾6_鱗左2;

		public Par X0Y0_尾6_鱗右2;

		public Par X0Y0_尾6_鱗左1;

		public Par X0Y0_尾6_鱗右1;

		public Par X0Y0_尾5_尾;

		public Par X0Y0_尾5_鱗左3;

		public Par X0Y0_尾5_鱗右3;

		public Par X0Y0_尾5_鱗左2;

		public Par X0Y0_尾5_鱗右2;

		public Par X0Y0_尾5_鱗左1;

		public Par X0Y0_尾5_鱗右1;

		public Par X0Y0_尾4_尾;

		public Par X0Y0_尾4_鱗左3;

		public Par X0Y0_尾4_鱗右3;

		public Par X0Y0_尾4_鱗左2;

		public Par X0Y0_尾4_鱗右2;

		public Par X0Y0_尾4_鱗左1;

		public Par X0Y0_尾4_鱗右1;

		public Par X0Y0_尾3_尾;

		public Par X0Y0_尾3_鱗左3;

		public Par X0Y0_尾3_鱗右3;

		public Par X0Y0_尾3_鱗左2;

		public Par X0Y0_尾3_鱗右2;

		public Par X0Y0_尾3_鱗左1;

		public Par X0Y0_尾3_鱗右1;

		public Par X0Y0_尾2_尾;

		public Par X0Y0_尾2_鱗左3;

		public Par X0Y0_尾2_鱗右3;

		public Par X0Y0_尾2_鱗左2;

		public Par X0Y0_尾2_鱗右2;

		public Par X0Y0_尾2_鱗左1;

		public Par X0Y0_尾2_鱗右1;

		public Par X0Y0_輪1_革;

		public Par X0Y0_輪1_金具1;

		public Par X0Y0_輪1_金具2;

		public Par X0Y0_輪1_金具3;

		public Par X0Y0_輪1_金具左;

		public Par X0Y0_輪1_金具右;

		public Par X0Y0_尾1_尾;

		public Par X0Y0_尾1_鱗左3;

		public Par X0Y0_尾1_鱗右3;

		public Par X0Y0_尾1_鱗左2;

		public Par X0Y0_尾1_鱗右2;

		public Par X0Y0_尾1_鱗左1;

		public Par X0Y0_尾1_鱗右1;

		public Par X0Y0_尾0_尾;

		public Par X0Y0_尾0_鱗右;

		public Par X0Y0_尾0_鱗左;

		public ColorD 尾35_尾CD;

		public ColorD 尾35_鱗左3CD;

		public ColorD 尾35_鱗右3CD;

		public ColorD 尾35_鱗左2CD;

		public ColorD 尾35_鱗右2CD;

		public ColorD 尾35_鱗左1CD;

		public ColorD 尾35_鱗右1CD;

		public ColorD 尾34_尾CD;

		public ColorD 尾34_鱗左3CD;

		public ColorD 尾34_鱗右3CD;

		public ColorD 尾34_鱗左2CD;

		public ColorD 尾34_鱗右2CD;

		public ColorD 尾34_鱗左1CD;

		public ColorD 尾34_鱗右1CD;

		public ColorD 尾33_尾CD;

		public ColorD 尾33_鱗左3CD;

		public ColorD 尾33_鱗右3CD;

		public ColorD 尾33_鱗左2CD;

		public ColorD 尾33_鱗右2CD;

		public ColorD 尾33_鱗左1CD;

		public ColorD 尾33_鱗右1CD;

		public ColorD 尾32_尾CD;

		public ColorD 尾32_鱗左3CD;

		public ColorD 尾32_鱗右3CD;

		public ColorD 尾32_鱗左2CD;

		public ColorD 尾32_鱗右2CD;

		public ColorD 尾32_鱗左1CD;

		public ColorD 尾32_鱗右1CD;

		public ColorD 尾31_尾CD;

		public ColorD 尾31_鱗左3CD;

		public ColorD 尾31_鱗右3CD;

		public ColorD 尾31_鱗左2CD;

		public ColorD 尾31_鱗右2CD;

		public ColorD 尾31_鱗左1CD;

		public ColorD 尾31_鱗右1CD;

		public ColorD 尾30_尾CD;

		public ColorD 尾30_鱗左3CD;

		public ColorD 尾30_鱗右3CD;

		public ColorD 尾30_鱗左2CD;

		public ColorD 尾30_鱗右2CD;

		public ColorD 尾30_鱗左1CD;

		public ColorD 尾30_鱗右1CD;

		public ColorD 尾29_尾CD;

		public ColorD 尾29_鱗左3CD;

		public ColorD 尾29_鱗右3CD;

		public ColorD 尾29_鱗左2CD;

		public ColorD 尾29_鱗右2CD;

		public ColorD 尾29_鱗左1CD;

		public ColorD 尾29_鱗右1CD;

		public ColorD 尾28_尾CD;

		public ColorD 尾28_鱗左3CD;

		public ColorD 尾28_鱗右3CD;

		public ColorD 尾28_鱗左2CD;

		public ColorD 尾28_鱗右2CD;

		public ColorD 尾28_鱗左1CD;

		public ColorD 尾28_鱗右1CD;

		public ColorD 尾27_尾CD;

		public ColorD 尾27_鱗左3CD;

		public ColorD 尾27_鱗右3CD;

		public ColorD 尾27_鱗左2CD;

		public ColorD 尾27_鱗右2CD;

		public ColorD 尾27_鱗左1CD;

		public ColorD 尾27_鱗右1CD;

		public ColorD 尾26_尾CD;

		public ColorD 尾26_鱗左3CD;

		public ColorD 尾26_鱗右3CD;

		public ColorD 尾26_鱗左2CD;

		public ColorD 尾26_鱗右2CD;

		public ColorD 尾26_鱗左1CD;

		public ColorD 尾26_鱗右1CD;

		public ColorD 尾25_尾CD;

		public ColorD 尾25_鱗左3CD;

		public ColorD 尾25_鱗右3CD;

		public ColorD 尾25_鱗左2CD;

		public ColorD 尾25_鱗右2CD;

		public ColorD 尾25_鱗左1CD;

		public ColorD 尾25_鱗右1CD;

		public ColorD 尾24_尾CD;

		public ColorD 尾24_鱗左3CD;

		public ColorD 尾24_鱗右3CD;

		public ColorD 尾24_鱗左2CD;

		public ColorD 尾24_鱗右2CD;

		public ColorD 尾24_鱗左1CD;

		public ColorD 尾24_鱗右1CD;

		public ColorD 尾23_尾CD;

		public ColorD 尾23_鱗左3CD;

		public ColorD 尾23_鱗右3CD;

		public ColorD 尾23_鱗左2CD;

		public ColorD 尾23_鱗右2CD;

		public ColorD 尾23_鱗左1CD;

		public ColorD 尾23_鱗右1CD;

		public ColorD 尾22_尾CD;

		public ColorD 尾22_鱗左3CD;

		public ColorD 尾22_鱗右3CD;

		public ColorD 尾22_鱗左2CD;

		public ColorD 尾22_鱗右2CD;

		public ColorD 尾22_鱗左1CD;

		public ColorD 尾22_鱗右1CD;

		public ColorD 尾21_尾CD;

		public ColorD 尾21_鱗左3CD;

		public ColorD 尾21_鱗右3CD;

		public ColorD 尾21_鱗左2CD;

		public ColorD 尾21_鱗右2CD;

		public ColorD 尾21_鱗左1CD;

		public ColorD 尾21_鱗右1CD;

		public ColorD 尾20_尾CD;

		public ColorD 尾20_鱗左3CD;

		public ColorD 尾20_鱗右3CD;

		public ColorD 尾20_鱗左2CD;

		public ColorD 尾20_鱗右2CD;

		public ColorD 尾20_鱗左1CD;

		public ColorD 尾20_鱗右1CD;

		public ColorD 尾19_尾CD;

		public ColorD 尾19_鱗左3CD;

		public ColorD 尾19_鱗右3CD;

		public ColorD 尾19_鱗左2CD;

		public ColorD 尾19_鱗右2CD;

		public ColorD 尾19_鱗左1CD;

		public ColorD 尾19_鱗右1CD;

		public ColorD 尾18_尾CD;

		public ColorD 尾18_鱗左3CD;

		public ColorD 尾18_鱗右3CD;

		public ColorD 尾18_鱗左2CD;

		public ColorD 尾18_鱗右2CD;

		public ColorD 尾18_鱗左1CD;

		public ColorD 尾18_鱗右1CD;

		public ColorD 尾17_尾CD;

		public ColorD 尾17_鱗左3CD;

		public ColorD 尾17_鱗右3CD;

		public ColorD 尾17_鱗左2CD;

		public ColorD 尾17_鱗右2CD;

		public ColorD 尾17_鱗左1CD;

		public ColorD 尾17_鱗右1CD;

		public ColorD 尾16_尾CD;

		public ColorD 尾16_鱗左3CD;

		public ColorD 尾16_鱗右3CD;

		public ColorD 尾16_鱗左2CD;

		public ColorD 尾16_鱗右2CD;

		public ColorD 尾16_鱗左1CD;

		public ColorD 尾16_鱗右1CD;

		public ColorD 尾15_尾CD;

		public ColorD 尾15_鱗左3CD;

		public ColorD 尾15_鱗右3CD;

		public ColorD 尾15_鱗左2CD;

		public ColorD 尾15_鱗右2CD;

		public ColorD 尾15_鱗左1CD;

		public ColorD 尾15_鱗右1CD;

		public ColorD 尾14_尾CD;

		public ColorD 尾14_鱗左3CD;

		public ColorD 尾14_鱗右3CD;

		public ColorD 尾14_鱗左2CD;

		public ColorD 尾14_鱗右2CD;

		public ColorD 尾14_鱗左1CD;

		public ColorD 尾14_鱗右1CD;

		public ColorD 尾13_尾CD;

		public ColorD 尾13_鱗左3CD;

		public ColorD 尾13_鱗右3CD;

		public ColorD 尾13_鱗左2CD;

		public ColorD 尾13_鱗右2CD;

		public ColorD 尾13_鱗左1CD;

		public ColorD 尾13_鱗右1CD;

		public ColorD 尾12_尾CD;

		public ColorD 尾12_鱗左3CD;

		public ColorD 尾12_鱗右3CD;

		public ColorD 尾12_鱗左2CD;

		public ColorD 尾12_鱗右2CD;

		public ColorD 尾12_鱗左1CD;

		public ColorD 尾12_鱗右1CD;

		public ColorD 尾11_尾CD;

		public ColorD 尾11_鱗左3CD;

		public ColorD 尾11_鱗右3CD;

		public ColorD 尾11_鱗左2CD;

		public ColorD 尾11_鱗右2CD;

		public ColorD 尾11_鱗左1CD;

		public ColorD 尾11_鱗右1CD;

		public ColorD 尾10_尾CD;

		public ColorD 尾10_鱗左3CD;

		public ColorD 尾10_鱗右3CD;

		public ColorD 尾10_鱗左2CD;

		public ColorD 尾10_鱗右2CD;

		public ColorD 尾10_鱗左1CD;

		public ColorD 尾10_鱗右1CD;

		public ColorD 尾9_尾CD;

		public ColorD 尾9_鱗左3CD;

		public ColorD 尾9_鱗右3CD;

		public ColorD 尾9_鱗左2CD;

		public ColorD 尾9_鱗右2CD;

		public ColorD 尾9_鱗左1CD;

		public ColorD 尾9_鱗右1CD;

		public ColorD 尾8_尾CD;

		public ColorD 尾8_鱗左3CD;

		public ColorD 尾8_鱗右3CD;

		public ColorD 尾8_鱗左2CD;

		public ColorD 尾8_鱗右2CD;

		public ColorD 尾8_鱗左1CD;

		public ColorD 尾8_鱗右1CD;

		public ColorD 輪2_革CD;

		public ColorD 輪2_金具1CD;

		public ColorD 輪2_金具2CD;

		public ColorD 輪2_金具3CD;

		public ColorD 輪2_金具左CD;

		public ColorD 輪2_金具右CD;

		public ColorD 尾7_尾CD;

		public ColorD 尾7_鱗左3CD;

		public ColorD 尾7_鱗右3CD;

		public ColorD 尾7_鱗左2CD;

		public ColorD 尾7_鱗右2CD;

		public ColorD 尾7_鱗左1CD;

		public ColorD 尾7_鱗右1CD;

		public ColorD 尾6_尾CD;

		public ColorD 尾6_鱗左3CD;

		public ColorD 尾6_鱗右3CD;

		public ColorD 尾6_鱗左2CD;

		public ColorD 尾6_鱗右2CD;

		public ColorD 尾6_鱗左1CD;

		public ColorD 尾6_鱗右1CD;

		public ColorD 尾5_尾CD;

		public ColorD 尾5_鱗左3CD;

		public ColorD 尾5_鱗右3CD;

		public ColorD 尾5_鱗左2CD;

		public ColorD 尾5_鱗右2CD;

		public ColorD 尾5_鱗左1CD;

		public ColorD 尾5_鱗右1CD;

		public ColorD 尾4_尾CD;

		public ColorD 尾4_鱗左3CD;

		public ColorD 尾4_鱗右3CD;

		public ColorD 尾4_鱗左2CD;

		public ColorD 尾4_鱗右2CD;

		public ColorD 尾4_鱗左1CD;

		public ColorD 尾4_鱗右1CD;

		public ColorD 尾3_尾CD;

		public ColorD 尾3_鱗左3CD;

		public ColorD 尾3_鱗右3CD;

		public ColorD 尾3_鱗左2CD;

		public ColorD 尾3_鱗右2CD;

		public ColorD 尾3_鱗左1CD;

		public ColorD 尾3_鱗右1CD;

		public ColorD 尾2_尾CD;

		public ColorD 尾2_鱗左3CD;

		public ColorD 尾2_鱗右3CD;

		public ColorD 尾2_鱗左2CD;

		public ColorD 尾2_鱗右2CD;

		public ColorD 尾2_鱗左1CD;

		public ColorD 尾2_鱗右1CD;

		public ColorD 輪1_革CD;

		public ColorD 輪1_金具1CD;

		public ColorD 輪1_金具2CD;

		public ColorD 輪1_金具3CD;

		public ColorD 輪1_金具左CD;

		public ColorD 輪1_金具右CD;

		public ColorD 尾1_尾CD;

		public ColorD 尾1_鱗左3CD;

		public ColorD 尾1_鱗右3CD;

		public ColorD 尾1_鱗左2CD;

		public ColorD 尾1_鱗右2CD;

		public ColorD 尾1_鱗左1CD;

		public ColorD 尾1_鱗右1CD;

		public ColorD 尾0_尾CD;

		public ColorD 尾0_鱗右CD;

		public ColorD 尾0_鱗左CD;

		public ColorP X0Y0_尾35_尾CP;

		public ColorP X0Y0_尾35_鱗左3CP;

		public ColorP X0Y0_尾35_鱗右3CP;

		public ColorP X0Y0_尾35_鱗左2CP;

		public ColorP X0Y0_尾35_鱗右2CP;

		public ColorP X0Y0_尾35_鱗左1CP;

		public ColorP X0Y0_尾35_鱗右1CP;

		public ColorP X0Y0_尾34_尾CP;

		public ColorP X0Y0_尾34_鱗左3CP;

		public ColorP X0Y0_尾34_鱗右3CP;

		public ColorP X0Y0_尾34_鱗左2CP;

		public ColorP X0Y0_尾34_鱗右2CP;

		public ColorP X0Y0_尾34_鱗左1CP;

		public ColorP X0Y0_尾34_鱗右1CP;

		public ColorP X0Y0_尾33_尾CP;

		public ColorP X0Y0_尾33_鱗左3CP;

		public ColorP X0Y0_尾33_鱗右3CP;

		public ColorP X0Y0_尾33_鱗左2CP;

		public ColorP X0Y0_尾33_鱗右2CP;

		public ColorP X0Y0_尾33_鱗左1CP;

		public ColorP X0Y0_尾33_鱗右1CP;

		public ColorP X0Y0_尾32_尾CP;

		public ColorP X0Y0_尾32_鱗左3CP;

		public ColorP X0Y0_尾32_鱗右3CP;

		public ColorP X0Y0_尾32_鱗左2CP;

		public ColorP X0Y0_尾32_鱗右2CP;

		public ColorP X0Y0_尾32_鱗左1CP;

		public ColorP X0Y0_尾32_鱗右1CP;

		public ColorP X0Y0_尾31_尾CP;

		public ColorP X0Y0_尾31_鱗左3CP;

		public ColorP X0Y0_尾31_鱗右3CP;

		public ColorP X0Y0_尾31_鱗左2CP;

		public ColorP X0Y0_尾31_鱗右2CP;

		public ColorP X0Y0_尾31_鱗左1CP;

		public ColorP X0Y0_尾31_鱗右1CP;

		public ColorP X0Y0_尾30_尾CP;

		public ColorP X0Y0_尾30_鱗左3CP;

		public ColorP X0Y0_尾30_鱗右3CP;

		public ColorP X0Y0_尾30_鱗左2CP;

		public ColorP X0Y0_尾30_鱗右2CP;

		public ColorP X0Y0_尾30_鱗左1CP;

		public ColorP X0Y0_尾30_鱗右1CP;

		public ColorP X0Y0_尾29_尾CP;

		public ColorP X0Y0_尾29_鱗左3CP;

		public ColorP X0Y0_尾29_鱗右3CP;

		public ColorP X0Y0_尾29_鱗左2CP;

		public ColorP X0Y0_尾29_鱗右2CP;

		public ColorP X0Y0_尾29_鱗左1CP;

		public ColorP X0Y0_尾29_鱗右1CP;

		public ColorP X0Y0_尾28_尾CP;

		public ColorP X0Y0_尾28_鱗左3CP;

		public ColorP X0Y0_尾28_鱗右3CP;

		public ColorP X0Y0_尾28_鱗左2CP;

		public ColorP X0Y0_尾28_鱗右2CP;

		public ColorP X0Y0_尾28_鱗左1CP;

		public ColorP X0Y0_尾28_鱗右1CP;

		public ColorP X0Y0_尾27_尾CP;

		public ColorP X0Y0_尾27_鱗左3CP;

		public ColorP X0Y0_尾27_鱗右3CP;

		public ColorP X0Y0_尾27_鱗左2CP;

		public ColorP X0Y0_尾27_鱗右2CP;

		public ColorP X0Y0_尾27_鱗左1CP;

		public ColorP X0Y0_尾27_鱗右1CP;

		public ColorP X0Y0_尾26_尾CP;

		public ColorP X0Y0_尾26_鱗左3CP;

		public ColorP X0Y0_尾26_鱗右3CP;

		public ColorP X0Y0_尾26_鱗左2CP;

		public ColorP X0Y0_尾26_鱗右2CP;

		public ColorP X0Y0_尾26_鱗左1CP;

		public ColorP X0Y0_尾26_鱗右1CP;

		public ColorP X0Y0_尾25_尾CP;

		public ColorP X0Y0_尾25_鱗左3CP;

		public ColorP X0Y0_尾25_鱗右3CP;

		public ColorP X0Y0_尾25_鱗左2CP;

		public ColorP X0Y0_尾25_鱗右2CP;

		public ColorP X0Y0_尾25_鱗左1CP;

		public ColorP X0Y0_尾25_鱗右1CP;

		public ColorP X0Y0_尾24_尾CP;

		public ColorP X0Y0_尾24_鱗左3CP;

		public ColorP X0Y0_尾24_鱗右3CP;

		public ColorP X0Y0_尾24_鱗左2CP;

		public ColorP X0Y0_尾24_鱗右2CP;

		public ColorP X0Y0_尾24_鱗左1CP;

		public ColorP X0Y0_尾24_鱗右1CP;

		public ColorP X0Y0_尾23_尾CP;

		public ColorP X0Y0_尾23_鱗左3CP;

		public ColorP X0Y0_尾23_鱗右3CP;

		public ColorP X0Y0_尾23_鱗左2CP;

		public ColorP X0Y0_尾23_鱗右2CP;

		public ColorP X0Y0_尾23_鱗左1CP;

		public ColorP X0Y0_尾23_鱗右1CP;

		public ColorP X0Y0_尾22_尾CP;

		public ColorP X0Y0_尾22_鱗左3CP;

		public ColorP X0Y0_尾22_鱗右3CP;

		public ColorP X0Y0_尾22_鱗左2CP;

		public ColorP X0Y0_尾22_鱗右2CP;

		public ColorP X0Y0_尾22_鱗左1CP;

		public ColorP X0Y0_尾22_鱗右1CP;

		public ColorP X0Y0_尾21_尾CP;

		public ColorP X0Y0_尾21_鱗左3CP;

		public ColorP X0Y0_尾21_鱗右3CP;

		public ColorP X0Y0_尾21_鱗左2CP;

		public ColorP X0Y0_尾21_鱗右2CP;

		public ColorP X0Y0_尾21_鱗左1CP;

		public ColorP X0Y0_尾21_鱗右1CP;

		public ColorP X0Y0_尾20_尾CP;

		public ColorP X0Y0_尾20_鱗左3CP;

		public ColorP X0Y0_尾20_鱗右3CP;

		public ColorP X0Y0_尾20_鱗左2CP;

		public ColorP X0Y0_尾20_鱗右2CP;

		public ColorP X0Y0_尾20_鱗左1CP;

		public ColorP X0Y0_尾20_鱗右1CP;

		public ColorP X0Y0_尾19_尾CP;

		public ColorP X0Y0_尾19_鱗左3CP;

		public ColorP X0Y0_尾19_鱗右3CP;

		public ColorP X0Y0_尾19_鱗左2CP;

		public ColorP X0Y0_尾19_鱗右2CP;

		public ColorP X0Y0_尾19_鱗左1CP;

		public ColorP X0Y0_尾19_鱗右1CP;

		public ColorP X0Y0_尾18_尾CP;

		public ColorP X0Y0_尾18_鱗左3CP;

		public ColorP X0Y0_尾18_鱗右3CP;

		public ColorP X0Y0_尾18_鱗左2CP;

		public ColorP X0Y0_尾18_鱗右2CP;

		public ColorP X0Y0_尾18_鱗左1CP;

		public ColorP X0Y0_尾18_鱗右1CP;

		public ColorP X0Y0_尾17_尾CP;

		public ColorP X0Y0_尾17_鱗左3CP;

		public ColorP X0Y0_尾17_鱗右3CP;

		public ColorP X0Y0_尾17_鱗左2CP;

		public ColorP X0Y0_尾17_鱗右2CP;

		public ColorP X0Y0_尾17_鱗左1CP;

		public ColorP X0Y0_尾17_鱗右1CP;

		public ColorP X0Y0_尾16_尾CP;

		public ColorP X0Y0_尾16_鱗左3CP;

		public ColorP X0Y0_尾16_鱗右3CP;

		public ColorP X0Y0_尾16_鱗左2CP;

		public ColorP X0Y0_尾16_鱗右2CP;

		public ColorP X0Y0_尾16_鱗左1CP;

		public ColorP X0Y0_尾16_鱗右1CP;

		public ColorP X0Y0_尾15_尾CP;

		public ColorP X0Y0_尾15_鱗左3CP;

		public ColorP X0Y0_尾15_鱗右3CP;

		public ColorP X0Y0_尾15_鱗左2CP;

		public ColorP X0Y0_尾15_鱗右2CP;

		public ColorP X0Y0_尾15_鱗左1CP;

		public ColorP X0Y0_尾15_鱗右1CP;

		public ColorP X0Y0_尾14_尾CP;

		public ColorP X0Y0_尾14_鱗左3CP;

		public ColorP X0Y0_尾14_鱗右3CP;

		public ColorP X0Y0_尾14_鱗左2CP;

		public ColorP X0Y0_尾14_鱗右2CP;

		public ColorP X0Y0_尾14_鱗左1CP;

		public ColorP X0Y0_尾14_鱗右1CP;

		public ColorP X0Y0_尾13_尾CP;

		public ColorP X0Y0_尾13_鱗左3CP;

		public ColorP X0Y0_尾13_鱗右3CP;

		public ColorP X0Y0_尾13_鱗左2CP;

		public ColorP X0Y0_尾13_鱗右2CP;

		public ColorP X0Y0_尾13_鱗左1CP;

		public ColorP X0Y0_尾13_鱗右1CP;

		public ColorP X0Y0_尾12_尾CP;

		public ColorP X0Y0_尾12_鱗左3CP;

		public ColorP X0Y0_尾12_鱗右3CP;

		public ColorP X0Y0_尾12_鱗左2CP;

		public ColorP X0Y0_尾12_鱗右2CP;

		public ColorP X0Y0_尾12_鱗左1CP;

		public ColorP X0Y0_尾12_鱗右1CP;

		public ColorP X0Y0_尾11_尾CP;

		public ColorP X0Y0_尾11_鱗左3CP;

		public ColorP X0Y0_尾11_鱗右3CP;

		public ColorP X0Y0_尾11_鱗左2CP;

		public ColorP X0Y0_尾11_鱗右2CP;

		public ColorP X0Y0_尾11_鱗左1CP;

		public ColorP X0Y0_尾11_鱗右1CP;

		public ColorP X0Y0_尾10_尾CP;

		public ColorP X0Y0_尾10_鱗左3CP;

		public ColorP X0Y0_尾10_鱗右3CP;

		public ColorP X0Y0_尾10_鱗左2CP;

		public ColorP X0Y0_尾10_鱗右2CP;

		public ColorP X0Y0_尾10_鱗左1CP;

		public ColorP X0Y0_尾10_鱗右1CP;

		public ColorP X0Y0_尾9_尾CP;

		public ColorP X0Y0_尾9_鱗左3CP;

		public ColorP X0Y0_尾9_鱗右3CP;

		public ColorP X0Y0_尾9_鱗左2CP;

		public ColorP X0Y0_尾9_鱗右2CP;

		public ColorP X0Y0_尾9_鱗左1CP;

		public ColorP X0Y0_尾9_鱗右1CP;

		public ColorP X0Y0_尾8_尾CP;

		public ColorP X0Y0_尾8_鱗左3CP;

		public ColorP X0Y0_尾8_鱗右3CP;

		public ColorP X0Y0_尾8_鱗左2CP;

		public ColorP X0Y0_尾8_鱗右2CP;

		public ColorP X0Y0_尾8_鱗左1CP;

		public ColorP X0Y0_尾8_鱗右1CP;

		public ColorP X0Y0_輪2_革CP;

		public ColorP X0Y0_輪2_金具1CP;

		public ColorP X0Y0_輪2_金具2CP;

		public ColorP X0Y0_輪2_金具3CP;

		public ColorP X0Y0_輪2_金具左CP;

		public ColorP X0Y0_輪2_金具右CP;

		public ColorP X0Y0_尾7_尾CP;

		public ColorP X0Y0_尾7_鱗左3CP;

		public ColorP X0Y0_尾7_鱗右3CP;

		public ColorP X0Y0_尾7_鱗左2CP;

		public ColorP X0Y0_尾7_鱗右2CP;

		public ColorP X0Y0_尾7_鱗左1CP;

		public ColorP X0Y0_尾7_鱗右1CP;

		public ColorP X0Y0_尾6_尾CP;

		public ColorP X0Y0_尾6_鱗左3CP;

		public ColorP X0Y0_尾6_鱗右3CP;

		public ColorP X0Y0_尾6_鱗左2CP;

		public ColorP X0Y0_尾6_鱗右2CP;

		public ColorP X0Y0_尾6_鱗左1CP;

		public ColorP X0Y0_尾6_鱗右1CP;

		public ColorP X0Y0_尾5_尾CP;

		public ColorP X0Y0_尾5_鱗左3CP;

		public ColorP X0Y0_尾5_鱗右3CP;

		public ColorP X0Y0_尾5_鱗左2CP;

		public ColorP X0Y0_尾5_鱗右2CP;

		public ColorP X0Y0_尾5_鱗左1CP;

		public ColorP X0Y0_尾5_鱗右1CP;

		public ColorP X0Y0_尾4_尾CP;

		public ColorP X0Y0_尾4_鱗左3CP;

		public ColorP X0Y0_尾4_鱗右3CP;

		public ColorP X0Y0_尾4_鱗左2CP;

		public ColorP X0Y0_尾4_鱗右2CP;

		public ColorP X0Y0_尾4_鱗左1CP;

		public ColorP X0Y0_尾4_鱗右1CP;

		public ColorP X0Y0_尾3_尾CP;

		public ColorP X0Y0_尾3_鱗左3CP;

		public ColorP X0Y0_尾3_鱗右3CP;

		public ColorP X0Y0_尾3_鱗左2CP;

		public ColorP X0Y0_尾3_鱗右2CP;

		public ColorP X0Y0_尾3_鱗左1CP;

		public ColorP X0Y0_尾3_鱗右1CP;

		public ColorP X0Y0_尾2_尾CP;

		public ColorP X0Y0_尾2_鱗左3CP;

		public ColorP X0Y0_尾2_鱗右3CP;

		public ColorP X0Y0_尾2_鱗左2CP;

		public ColorP X0Y0_尾2_鱗右2CP;

		public ColorP X0Y0_尾2_鱗左1CP;

		public ColorP X0Y0_尾2_鱗右1CP;

		public ColorP X0Y0_輪1_革CP;

		public ColorP X0Y0_輪1_金具1CP;

		public ColorP X0Y0_輪1_金具2CP;

		public ColorP X0Y0_輪1_金具3CP;

		public ColorP X0Y0_輪1_金具左CP;

		public ColorP X0Y0_輪1_金具右CP;

		public ColorP X0Y0_尾1_尾CP;

		public ColorP X0Y0_尾1_鱗左3CP;

		public ColorP X0Y0_尾1_鱗右3CP;

		public ColorP X0Y0_尾1_鱗左2CP;

		public ColorP X0Y0_尾1_鱗右2CP;

		public ColorP X0Y0_尾1_鱗左1CP;

		public ColorP X0Y0_尾1_鱗右1CP;

		public ColorP X0Y0_尾0_尾CP;

		public ColorP X0Y0_尾0_鱗右CP;

		public ColorP X0Y0_尾0_鱗左CP;

		public 拘束鎖 鎖1;

		public 拘束鎖 鎖2;

		public 拘束鎖 鎖3;

		public 拘束鎖 鎖4;

		public Ele[] 尾先_接続;
	}
}
