using System;
using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 尾_魚 : 尾
	{
		public 尾_魚(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 尾_魚D e)
		{
			尾_魚.<>c__DisplayClass926_0 CS$<>8__locals1 = new 尾_魚.<>c__DisplayClass926_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "魚尾";
			dif.Add(new Pars(Sta.尻尾["尾"][0][19]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["尾33"].ToPars();
			Pars pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾33_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾33_鱗左_鱗3 = pars3["鱗3"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾33_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾33_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾33_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾32"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾32_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾32_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾32_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾32_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾32_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾32_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾32_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾32_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾32_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾31"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾31_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾31_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾31_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾31_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾31_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾31_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾31_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾31_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾31_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾30"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾30_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾30_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾30_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾30_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾30_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾30_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾30_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾30_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾30_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾29"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾29_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾29_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾29_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾29_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾29_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾29_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾29_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾29_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾29_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾28"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾28_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾28_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾28_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾28_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾28_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾28_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾28_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾28_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾28_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾27"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾27_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾27_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾27_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾27_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾27_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾27_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾27_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾27_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾27_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾26"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾26_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾26_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾26_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾26_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾26_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾26_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾26_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾26_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾26_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾25"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾25_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾25_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾25_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾25_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾25_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾25_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾25_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾25_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾25_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾24"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾24_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾24_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾24_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾24_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾24_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾24_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾24_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾24_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾24_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾23"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾23_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾23_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾23_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾23_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾23_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾23_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾23_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾23_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾23_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾22"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾22_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾22_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾22_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾22_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾22_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾22_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾22_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾22_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾22_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾21"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾21_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾21_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾21_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾21_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾21_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾21_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾21_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾21_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾21_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾20"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾20_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾20_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾20_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾20_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾20_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾20_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾20_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾20_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾20_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾19"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾19_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾19_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾19_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾19_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾19_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾19_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾19_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾19_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾19_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾18"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾18_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾18_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾18_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾18_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾18_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾18_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾18_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾18_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾18_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾17"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾17_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾17_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾17_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾17_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾17_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾17_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾17_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾17_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾17_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾16"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾16_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾16_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾16_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾16_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾16_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾16_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾16_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾16_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾16_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾15"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾15_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾15_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾15_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾15_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾15_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾15_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾15_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾15_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾15_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾14"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾14_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾14_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾14_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾14_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾14_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾14_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾14_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾14_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾14_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾13"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾13_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾13_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾13_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾13_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾13_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾13_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾13_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾13_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾13_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾12"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾12_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾12_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾12_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾12_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾12_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾12_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾12_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾12_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾12_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾11"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾11_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾11_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾11_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾11_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾11_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾11_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾11_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾11_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾11_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾10"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾10_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾10_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾10_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾10_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾10_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾10_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾10_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾10_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾10_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾9"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾9_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾9_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾9_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾9_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾9_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾9_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾9_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾9_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾9_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾8"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾8_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾8_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾8_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾8_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾8_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾8_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾8_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾8_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾8_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾7"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾7_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾7_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾7_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾7_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾7_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾7_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾7_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾7_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾7_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾6"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾6_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾6_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾6_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾6_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾6_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾6_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾6_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾6_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾6_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾5"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾5_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾5_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾5_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾5_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾5_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾5_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾5_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾5_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾5_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾4"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾4_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾4_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾4_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾4_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾4_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾4_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾4_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾4_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾4_尾 = pars2["尾"].ToPar();
			pars2 = pars["輪"].ToPars();
			this.X0Y0_輪_革 = pars2["革"].ToPar();
			this.X0Y0_輪_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_輪_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_輪_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_輪_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_輪_金具右 = pars2["金具右"].ToPar();
			pars2 = pars["尾3"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾3_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾3_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾3_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾3_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾3_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾3_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾3_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾3_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾3_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾2"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾2_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾2_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾2_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾2_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾2_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾2_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾2_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾2_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾2_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾1"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾1_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾1_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾1_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾1_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾1_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾1_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾1_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾1_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾1_尾 = pars2["尾"].ToPar();
			pars2 = pars["尾0"].ToPars();
			pars3 = pars2["鱗左"].ToPars();
			this.X0Y0_尾0_鱗左_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾0_鱗左_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾0_鱗左_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾0_鱗左_鱗4 = pars3["鱗4"].ToPar();
			pars3 = pars2["鱗右"].ToPars();
			this.X0Y0_尾0_鱗右_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_尾0_鱗右_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_尾0_鱗右_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_尾0_鱗右_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_尾0_尾 = pars2["尾"].ToPar();
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
			this.尾33_鱗左_鱗1_表示 = e.尾33_鱗左_鱗1_表示;
			this.尾33_鱗左_鱗3_表示 = e.尾33_鱗左_鱗3_表示;
			this.尾33_鱗右_鱗1_表示 = e.尾33_鱗右_鱗1_表示;
			this.尾33_鱗右_鱗3_表示 = e.尾33_鱗右_鱗3_表示;
			this.尾33_表示 = e.尾33_表示;
			this.尾32_鱗左_鱗1_表示 = e.尾32_鱗左_鱗1_表示;
			this.尾32_鱗左_鱗2_表示 = e.尾32_鱗左_鱗2_表示;
			this.尾32_鱗左_鱗3_表示 = e.尾32_鱗左_鱗3_表示;
			this.尾32_鱗左_鱗4_表示 = e.尾32_鱗左_鱗4_表示;
			this.尾32_鱗右_鱗1_表示 = e.尾32_鱗右_鱗1_表示;
			this.尾32_鱗右_鱗2_表示 = e.尾32_鱗右_鱗2_表示;
			this.尾32_鱗右_鱗3_表示 = e.尾32_鱗右_鱗3_表示;
			this.尾32_鱗右_鱗4_表示 = e.尾32_鱗右_鱗4_表示;
			this.尾32_表示 = e.尾32_表示;
			this.尾31_鱗左_鱗1_表示 = e.尾31_鱗左_鱗1_表示;
			this.尾31_鱗左_鱗2_表示 = e.尾31_鱗左_鱗2_表示;
			this.尾31_鱗左_鱗3_表示 = e.尾31_鱗左_鱗3_表示;
			this.尾31_鱗左_鱗4_表示 = e.尾31_鱗左_鱗4_表示;
			this.尾31_鱗右_鱗1_表示 = e.尾31_鱗右_鱗1_表示;
			this.尾31_鱗右_鱗2_表示 = e.尾31_鱗右_鱗2_表示;
			this.尾31_鱗右_鱗3_表示 = e.尾31_鱗右_鱗3_表示;
			this.尾31_鱗右_鱗4_表示 = e.尾31_鱗右_鱗4_表示;
			this.尾31_表示 = e.尾31_表示;
			this.尾30_鱗左_鱗1_表示 = e.尾30_鱗左_鱗1_表示;
			this.尾30_鱗左_鱗2_表示 = e.尾30_鱗左_鱗2_表示;
			this.尾30_鱗左_鱗3_表示 = e.尾30_鱗左_鱗3_表示;
			this.尾30_鱗左_鱗4_表示 = e.尾30_鱗左_鱗4_表示;
			this.尾30_鱗右_鱗1_表示 = e.尾30_鱗右_鱗1_表示;
			this.尾30_鱗右_鱗2_表示 = e.尾30_鱗右_鱗2_表示;
			this.尾30_鱗右_鱗3_表示 = e.尾30_鱗右_鱗3_表示;
			this.尾30_鱗右_鱗4_表示 = e.尾30_鱗右_鱗4_表示;
			this.尾30_表示 = e.尾30_表示;
			this.尾29_鱗左_鱗1_表示 = e.尾29_鱗左_鱗1_表示;
			this.尾29_鱗左_鱗2_表示 = e.尾29_鱗左_鱗2_表示;
			this.尾29_鱗左_鱗3_表示 = e.尾29_鱗左_鱗3_表示;
			this.尾29_鱗左_鱗4_表示 = e.尾29_鱗左_鱗4_表示;
			this.尾29_鱗右_鱗1_表示 = e.尾29_鱗右_鱗1_表示;
			this.尾29_鱗右_鱗2_表示 = e.尾29_鱗右_鱗2_表示;
			this.尾29_鱗右_鱗3_表示 = e.尾29_鱗右_鱗3_表示;
			this.尾29_鱗右_鱗4_表示 = e.尾29_鱗右_鱗4_表示;
			this.尾29_表示 = e.尾29_表示;
			this.尾28_鱗左_鱗1_表示 = e.尾28_鱗左_鱗1_表示;
			this.尾28_鱗左_鱗2_表示 = e.尾28_鱗左_鱗2_表示;
			this.尾28_鱗左_鱗3_表示 = e.尾28_鱗左_鱗3_表示;
			this.尾28_鱗左_鱗4_表示 = e.尾28_鱗左_鱗4_表示;
			this.尾28_鱗右_鱗1_表示 = e.尾28_鱗右_鱗1_表示;
			this.尾28_鱗右_鱗2_表示 = e.尾28_鱗右_鱗2_表示;
			this.尾28_鱗右_鱗3_表示 = e.尾28_鱗右_鱗3_表示;
			this.尾28_鱗右_鱗4_表示 = e.尾28_鱗右_鱗4_表示;
			this.尾28_表示 = e.尾28_表示;
			this.尾27_鱗左_鱗1_表示 = e.尾27_鱗左_鱗1_表示;
			this.尾27_鱗左_鱗2_表示 = e.尾27_鱗左_鱗2_表示;
			this.尾27_鱗左_鱗3_表示 = e.尾27_鱗左_鱗3_表示;
			this.尾27_鱗左_鱗4_表示 = e.尾27_鱗左_鱗4_表示;
			this.尾27_鱗右_鱗1_表示 = e.尾27_鱗右_鱗1_表示;
			this.尾27_鱗右_鱗2_表示 = e.尾27_鱗右_鱗2_表示;
			this.尾27_鱗右_鱗3_表示 = e.尾27_鱗右_鱗3_表示;
			this.尾27_鱗右_鱗4_表示 = e.尾27_鱗右_鱗4_表示;
			this.尾27_表示 = e.尾27_表示;
			this.尾26_鱗左_鱗1_表示 = e.尾26_鱗左_鱗1_表示;
			this.尾26_鱗左_鱗2_表示 = e.尾26_鱗左_鱗2_表示;
			this.尾26_鱗左_鱗3_表示 = e.尾26_鱗左_鱗3_表示;
			this.尾26_鱗左_鱗4_表示 = e.尾26_鱗左_鱗4_表示;
			this.尾26_鱗右_鱗1_表示 = e.尾26_鱗右_鱗1_表示;
			this.尾26_鱗右_鱗2_表示 = e.尾26_鱗右_鱗2_表示;
			this.尾26_鱗右_鱗3_表示 = e.尾26_鱗右_鱗3_表示;
			this.尾26_鱗右_鱗4_表示 = e.尾26_鱗右_鱗4_表示;
			this.尾26_表示 = e.尾26_表示;
			this.尾25_鱗左_鱗1_表示 = e.尾25_鱗左_鱗1_表示;
			this.尾25_鱗左_鱗2_表示 = e.尾25_鱗左_鱗2_表示;
			this.尾25_鱗左_鱗3_表示 = e.尾25_鱗左_鱗3_表示;
			this.尾25_鱗左_鱗4_表示 = e.尾25_鱗左_鱗4_表示;
			this.尾25_鱗右_鱗1_表示 = e.尾25_鱗右_鱗1_表示;
			this.尾25_鱗右_鱗2_表示 = e.尾25_鱗右_鱗2_表示;
			this.尾25_鱗右_鱗3_表示 = e.尾25_鱗右_鱗3_表示;
			this.尾25_鱗右_鱗4_表示 = e.尾25_鱗右_鱗4_表示;
			this.尾25_表示 = e.尾25_表示;
			this.尾24_鱗左_鱗1_表示 = e.尾24_鱗左_鱗1_表示;
			this.尾24_鱗左_鱗2_表示 = e.尾24_鱗左_鱗2_表示;
			this.尾24_鱗左_鱗3_表示 = e.尾24_鱗左_鱗3_表示;
			this.尾24_鱗左_鱗4_表示 = e.尾24_鱗左_鱗4_表示;
			this.尾24_鱗右_鱗1_表示 = e.尾24_鱗右_鱗1_表示;
			this.尾24_鱗右_鱗2_表示 = e.尾24_鱗右_鱗2_表示;
			this.尾24_鱗右_鱗3_表示 = e.尾24_鱗右_鱗3_表示;
			this.尾24_鱗右_鱗4_表示 = e.尾24_鱗右_鱗4_表示;
			this.尾24_表示 = e.尾24_表示;
			this.尾23_鱗左_鱗1_表示 = e.尾23_鱗左_鱗1_表示;
			this.尾23_鱗左_鱗2_表示 = e.尾23_鱗左_鱗2_表示;
			this.尾23_鱗左_鱗3_表示 = e.尾23_鱗左_鱗3_表示;
			this.尾23_鱗左_鱗4_表示 = e.尾23_鱗左_鱗4_表示;
			this.尾23_鱗右_鱗1_表示 = e.尾23_鱗右_鱗1_表示;
			this.尾23_鱗右_鱗2_表示 = e.尾23_鱗右_鱗2_表示;
			this.尾23_鱗右_鱗3_表示 = e.尾23_鱗右_鱗3_表示;
			this.尾23_鱗右_鱗4_表示 = e.尾23_鱗右_鱗4_表示;
			this.尾23_表示 = e.尾23_表示;
			this.尾22_鱗左_鱗1_表示 = e.尾22_鱗左_鱗1_表示;
			this.尾22_鱗左_鱗2_表示 = e.尾22_鱗左_鱗2_表示;
			this.尾22_鱗左_鱗3_表示 = e.尾22_鱗左_鱗3_表示;
			this.尾22_鱗左_鱗4_表示 = e.尾22_鱗左_鱗4_表示;
			this.尾22_鱗右_鱗1_表示 = e.尾22_鱗右_鱗1_表示;
			this.尾22_鱗右_鱗2_表示 = e.尾22_鱗右_鱗2_表示;
			this.尾22_鱗右_鱗3_表示 = e.尾22_鱗右_鱗3_表示;
			this.尾22_鱗右_鱗4_表示 = e.尾22_鱗右_鱗4_表示;
			this.尾22_表示 = e.尾22_表示;
			this.尾21_鱗左_鱗1_表示 = e.尾21_鱗左_鱗1_表示;
			this.尾21_鱗左_鱗2_表示 = e.尾21_鱗左_鱗2_表示;
			this.尾21_鱗左_鱗3_表示 = e.尾21_鱗左_鱗3_表示;
			this.尾21_鱗左_鱗4_表示 = e.尾21_鱗左_鱗4_表示;
			this.尾21_鱗右_鱗1_表示 = e.尾21_鱗右_鱗1_表示;
			this.尾21_鱗右_鱗2_表示 = e.尾21_鱗右_鱗2_表示;
			this.尾21_鱗右_鱗3_表示 = e.尾21_鱗右_鱗3_表示;
			this.尾21_鱗右_鱗4_表示 = e.尾21_鱗右_鱗4_表示;
			this.尾21_表示 = e.尾21_表示;
			this.尾20_鱗左_鱗1_表示 = e.尾20_鱗左_鱗1_表示;
			this.尾20_鱗左_鱗2_表示 = e.尾20_鱗左_鱗2_表示;
			this.尾20_鱗左_鱗3_表示 = e.尾20_鱗左_鱗3_表示;
			this.尾20_鱗左_鱗4_表示 = e.尾20_鱗左_鱗4_表示;
			this.尾20_鱗右_鱗1_表示 = e.尾20_鱗右_鱗1_表示;
			this.尾20_鱗右_鱗2_表示 = e.尾20_鱗右_鱗2_表示;
			this.尾20_鱗右_鱗3_表示 = e.尾20_鱗右_鱗3_表示;
			this.尾20_鱗右_鱗4_表示 = e.尾20_鱗右_鱗4_表示;
			this.尾20_表示 = e.尾20_表示;
			this.尾19_鱗左_鱗1_表示 = e.尾19_鱗左_鱗1_表示;
			this.尾19_鱗左_鱗2_表示 = e.尾19_鱗左_鱗2_表示;
			this.尾19_鱗左_鱗3_表示 = e.尾19_鱗左_鱗3_表示;
			this.尾19_鱗左_鱗4_表示 = e.尾19_鱗左_鱗4_表示;
			this.尾19_鱗右_鱗1_表示 = e.尾19_鱗右_鱗1_表示;
			this.尾19_鱗右_鱗2_表示 = e.尾19_鱗右_鱗2_表示;
			this.尾19_鱗右_鱗3_表示 = e.尾19_鱗右_鱗3_表示;
			this.尾19_鱗右_鱗4_表示 = e.尾19_鱗右_鱗4_表示;
			this.尾19_表示 = e.尾19_表示;
			this.尾18_鱗左_鱗1_表示 = e.尾18_鱗左_鱗1_表示;
			this.尾18_鱗左_鱗2_表示 = e.尾18_鱗左_鱗2_表示;
			this.尾18_鱗左_鱗3_表示 = e.尾18_鱗左_鱗3_表示;
			this.尾18_鱗左_鱗4_表示 = e.尾18_鱗左_鱗4_表示;
			this.尾18_鱗右_鱗1_表示 = e.尾18_鱗右_鱗1_表示;
			this.尾18_鱗右_鱗2_表示 = e.尾18_鱗右_鱗2_表示;
			this.尾18_鱗右_鱗3_表示 = e.尾18_鱗右_鱗3_表示;
			this.尾18_鱗右_鱗4_表示 = e.尾18_鱗右_鱗4_表示;
			this.尾18_表示 = e.尾18_表示;
			this.尾17_鱗左_鱗1_表示 = e.尾17_鱗左_鱗1_表示;
			this.尾17_鱗左_鱗2_表示 = e.尾17_鱗左_鱗2_表示;
			this.尾17_鱗左_鱗3_表示 = e.尾17_鱗左_鱗3_表示;
			this.尾17_鱗左_鱗4_表示 = e.尾17_鱗左_鱗4_表示;
			this.尾17_鱗右_鱗1_表示 = e.尾17_鱗右_鱗1_表示;
			this.尾17_鱗右_鱗2_表示 = e.尾17_鱗右_鱗2_表示;
			this.尾17_鱗右_鱗3_表示 = e.尾17_鱗右_鱗3_表示;
			this.尾17_鱗右_鱗4_表示 = e.尾17_鱗右_鱗4_表示;
			this.尾17_表示 = e.尾17_表示;
			this.尾16_鱗左_鱗1_表示 = e.尾16_鱗左_鱗1_表示;
			this.尾16_鱗左_鱗2_表示 = e.尾16_鱗左_鱗2_表示;
			this.尾16_鱗左_鱗3_表示 = e.尾16_鱗左_鱗3_表示;
			this.尾16_鱗左_鱗4_表示 = e.尾16_鱗左_鱗4_表示;
			this.尾16_鱗右_鱗1_表示 = e.尾16_鱗右_鱗1_表示;
			this.尾16_鱗右_鱗2_表示 = e.尾16_鱗右_鱗2_表示;
			this.尾16_鱗右_鱗3_表示 = e.尾16_鱗右_鱗3_表示;
			this.尾16_鱗右_鱗4_表示 = e.尾16_鱗右_鱗4_表示;
			this.尾16_表示 = e.尾16_表示;
			this.尾15_鱗左_鱗1_表示 = e.尾15_鱗左_鱗1_表示;
			this.尾15_鱗左_鱗2_表示 = e.尾15_鱗左_鱗2_表示;
			this.尾15_鱗左_鱗3_表示 = e.尾15_鱗左_鱗3_表示;
			this.尾15_鱗左_鱗4_表示 = e.尾15_鱗左_鱗4_表示;
			this.尾15_鱗右_鱗1_表示 = e.尾15_鱗右_鱗1_表示;
			this.尾15_鱗右_鱗2_表示 = e.尾15_鱗右_鱗2_表示;
			this.尾15_鱗右_鱗3_表示 = e.尾15_鱗右_鱗3_表示;
			this.尾15_鱗右_鱗4_表示 = e.尾15_鱗右_鱗4_表示;
			this.尾15_表示 = e.尾15_表示;
			this.尾14_鱗左_鱗1_表示 = e.尾14_鱗左_鱗1_表示;
			this.尾14_鱗左_鱗2_表示 = e.尾14_鱗左_鱗2_表示;
			this.尾14_鱗左_鱗3_表示 = e.尾14_鱗左_鱗3_表示;
			this.尾14_鱗左_鱗4_表示 = e.尾14_鱗左_鱗4_表示;
			this.尾14_鱗右_鱗1_表示 = e.尾14_鱗右_鱗1_表示;
			this.尾14_鱗右_鱗2_表示 = e.尾14_鱗右_鱗2_表示;
			this.尾14_鱗右_鱗3_表示 = e.尾14_鱗右_鱗3_表示;
			this.尾14_鱗右_鱗4_表示 = e.尾14_鱗右_鱗4_表示;
			this.尾14_表示 = e.尾14_表示;
			this.尾13_鱗左_鱗1_表示 = e.尾13_鱗左_鱗1_表示;
			this.尾13_鱗左_鱗2_表示 = e.尾13_鱗左_鱗2_表示;
			this.尾13_鱗左_鱗3_表示 = e.尾13_鱗左_鱗3_表示;
			this.尾13_鱗左_鱗4_表示 = e.尾13_鱗左_鱗4_表示;
			this.尾13_鱗右_鱗1_表示 = e.尾13_鱗右_鱗1_表示;
			this.尾13_鱗右_鱗2_表示 = e.尾13_鱗右_鱗2_表示;
			this.尾13_鱗右_鱗3_表示 = e.尾13_鱗右_鱗3_表示;
			this.尾13_鱗右_鱗4_表示 = e.尾13_鱗右_鱗4_表示;
			this.尾13_表示 = e.尾13_表示;
			this.尾12_鱗左_鱗1_表示 = e.尾12_鱗左_鱗1_表示;
			this.尾12_鱗左_鱗2_表示 = e.尾12_鱗左_鱗2_表示;
			this.尾12_鱗左_鱗3_表示 = e.尾12_鱗左_鱗3_表示;
			this.尾12_鱗左_鱗4_表示 = e.尾12_鱗左_鱗4_表示;
			this.尾12_鱗右_鱗1_表示 = e.尾12_鱗右_鱗1_表示;
			this.尾12_鱗右_鱗2_表示 = e.尾12_鱗右_鱗2_表示;
			this.尾12_鱗右_鱗3_表示 = e.尾12_鱗右_鱗3_表示;
			this.尾12_鱗右_鱗4_表示 = e.尾12_鱗右_鱗4_表示;
			this.尾12_表示 = e.尾12_表示;
			this.尾11_鱗左_鱗1_表示 = e.尾11_鱗左_鱗1_表示;
			this.尾11_鱗左_鱗2_表示 = e.尾11_鱗左_鱗2_表示;
			this.尾11_鱗左_鱗3_表示 = e.尾11_鱗左_鱗3_表示;
			this.尾11_鱗左_鱗4_表示 = e.尾11_鱗左_鱗4_表示;
			this.尾11_鱗右_鱗1_表示 = e.尾11_鱗右_鱗1_表示;
			this.尾11_鱗右_鱗2_表示 = e.尾11_鱗右_鱗2_表示;
			this.尾11_鱗右_鱗3_表示 = e.尾11_鱗右_鱗3_表示;
			this.尾11_鱗右_鱗4_表示 = e.尾11_鱗右_鱗4_表示;
			this.尾11_表示 = e.尾11_表示;
			this.尾10_鱗左_鱗1_表示 = e.尾10_鱗左_鱗1_表示;
			this.尾10_鱗左_鱗2_表示 = e.尾10_鱗左_鱗2_表示;
			this.尾10_鱗左_鱗3_表示 = e.尾10_鱗左_鱗3_表示;
			this.尾10_鱗左_鱗4_表示 = e.尾10_鱗左_鱗4_表示;
			this.尾10_鱗右_鱗1_表示 = e.尾10_鱗右_鱗1_表示;
			this.尾10_鱗右_鱗2_表示 = e.尾10_鱗右_鱗2_表示;
			this.尾10_鱗右_鱗3_表示 = e.尾10_鱗右_鱗3_表示;
			this.尾10_鱗右_鱗4_表示 = e.尾10_鱗右_鱗4_表示;
			this.尾10_表示 = e.尾10_表示;
			this.尾9_鱗左_鱗1_表示 = e.尾9_鱗左_鱗1_表示;
			this.尾9_鱗左_鱗2_表示 = e.尾9_鱗左_鱗2_表示;
			this.尾9_鱗左_鱗3_表示 = e.尾9_鱗左_鱗3_表示;
			this.尾9_鱗左_鱗4_表示 = e.尾9_鱗左_鱗4_表示;
			this.尾9_鱗右_鱗1_表示 = e.尾9_鱗右_鱗1_表示;
			this.尾9_鱗右_鱗2_表示 = e.尾9_鱗右_鱗2_表示;
			this.尾9_鱗右_鱗3_表示 = e.尾9_鱗右_鱗3_表示;
			this.尾9_鱗右_鱗4_表示 = e.尾9_鱗右_鱗4_表示;
			this.尾9_表示 = e.尾9_表示;
			this.尾8_鱗左_鱗1_表示 = e.尾8_鱗左_鱗1_表示;
			this.尾8_鱗左_鱗2_表示 = e.尾8_鱗左_鱗2_表示;
			this.尾8_鱗左_鱗3_表示 = e.尾8_鱗左_鱗3_表示;
			this.尾8_鱗左_鱗4_表示 = e.尾8_鱗左_鱗4_表示;
			this.尾8_鱗右_鱗1_表示 = e.尾8_鱗右_鱗1_表示;
			this.尾8_鱗右_鱗2_表示 = e.尾8_鱗右_鱗2_表示;
			this.尾8_鱗右_鱗3_表示 = e.尾8_鱗右_鱗3_表示;
			this.尾8_鱗右_鱗4_表示 = e.尾8_鱗右_鱗4_表示;
			this.尾8_表示 = e.尾8_表示;
			this.尾7_鱗左_鱗1_表示 = e.尾7_鱗左_鱗1_表示;
			this.尾7_鱗左_鱗2_表示 = e.尾7_鱗左_鱗2_表示;
			this.尾7_鱗左_鱗3_表示 = e.尾7_鱗左_鱗3_表示;
			this.尾7_鱗左_鱗4_表示 = e.尾7_鱗左_鱗4_表示;
			this.尾7_鱗右_鱗1_表示 = e.尾7_鱗右_鱗1_表示;
			this.尾7_鱗右_鱗2_表示 = e.尾7_鱗右_鱗2_表示;
			this.尾7_鱗右_鱗3_表示 = e.尾7_鱗右_鱗3_表示;
			this.尾7_鱗右_鱗4_表示 = e.尾7_鱗右_鱗4_表示;
			this.尾7_表示 = e.尾7_表示;
			this.尾6_鱗左_鱗1_表示 = e.尾6_鱗左_鱗1_表示;
			this.尾6_鱗左_鱗2_表示 = e.尾6_鱗左_鱗2_表示;
			this.尾6_鱗左_鱗3_表示 = e.尾6_鱗左_鱗3_表示;
			this.尾6_鱗左_鱗4_表示 = e.尾6_鱗左_鱗4_表示;
			this.尾6_鱗右_鱗1_表示 = e.尾6_鱗右_鱗1_表示;
			this.尾6_鱗右_鱗2_表示 = e.尾6_鱗右_鱗2_表示;
			this.尾6_鱗右_鱗3_表示 = e.尾6_鱗右_鱗3_表示;
			this.尾6_鱗右_鱗4_表示 = e.尾6_鱗右_鱗4_表示;
			this.尾6_表示 = e.尾6_表示;
			this.尾5_鱗左_鱗1_表示 = e.尾5_鱗左_鱗1_表示;
			this.尾5_鱗左_鱗2_表示 = e.尾5_鱗左_鱗2_表示;
			this.尾5_鱗左_鱗3_表示 = e.尾5_鱗左_鱗3_表示;
			this.尾5_鱗左_鱗4_表示 = e.尾5_鱗左_鱗4_表示;
			this.尾5_鱗右_鱗1_表示 = e.尾5_鱗右_鱗1_表示;
			this.尾5_鱗右_鱗2_表示 = e.尾5_鱗右_鱗2_表示;
			this.尾5_鱗右_鱗3_表示 = e.尾5_鱗右_鱗3_表示;
			this.尾5_鱗右_鱗4_表示 = e.尾5_鱗右_鱗4_表示;
			this.尾5_表示 = e.尾5_表示;
			this.尾4_鱗左_鱗1_表示 = e.尾4_鱗左_鱗1_表示;
			this.尾4_鱗左_鱗2_表示 = e.尾4_鱗左_鱗2_表示;
			this.尾4_鱗左_鱗3_表示 = e.尾4_鱗左_鱗3_表示;
			this.尾4_鱗左_鱗4_表示 = e.尾4_鱗左_鱗4_表示;
			this.尾4_鱗右_鱗1_表示 = e.尾4_鱗右_鱗1_表示;
			this.尾4_鱗右_鱗2_表示 = e.尾4_鱗右_鱗2_表示;
			this.尾4_鱗右_鱗3_表示 = e.尾4_鱗右_鱗3_表示;
			this.尾4_鱗右_鱗4_表示 = e.尾4_鱗右_鱗4_表示;
			this.尾4_表示 = e.尾4_表示;
			this.輪_革_表示 = e.輪_革_表示;
			this.輪_金具1_表示 = e.輪_金具1_表示;
			this.輪_金具2_表示 = e.輪_金具2_表示;
			this.輪_金具3_表示 = e.輪_金具3_表示;
			this.輪_金具左_表示 = e.輪_金具左_表示;
			this.輪_金具右_表示 = e.輪_金具右_表示;
			this.尾3_鱗左_鱗1_表示 = e.尾3_鱗左_鱗1_表示;
			this.尾3_鱗左_鱗2_表示 = e.尾3_鱗左_鱗2_表示;
			this.尾3_鱗左_鱗3_表示 = e.尾3_鱗左_鱗3_表示;
			this.尾3_鱗左_鱗4_表示 = e.尾3_鱗左_鱗4_表示;
			this.尾3_鱗右_鱗1_表示 = e.尾3_鱗右_鱗1_表示;
			this.尾3_鱗右_鱗2_表示 = e.尾3_鱗右_鱗2_表示;
			this.尾3_鱗右_鱗3_表示 = e.尾3_鱗右_鱗3_表示;
			this.尾3_鱗右_鱗4_表示 = e.尾3_鱗右_鱗4_表示;
			this.尾3_表示 = e.尾3_表示;
			this.尾2_鱗左_鱗1_表示 = e.尾2_鱗左_鱗1_表示;
			this.尾2_鱗左_鱗2_表示 = e.尾2_鱗左_鱗2_表示;
			this.尾2_鱗左_鱗3_表示 = e.尾2_鱗左_鱗3_表示;
			this.尾2_鱗左_鱗4_表示 = e.尾2_鱗左_鱗4_表示;
			this.尾2_鱗右_鱗1_表示 = e.尾2_鱗右_鱗1_表示;
			this.尾2_鱗右_鱗2_表示 = e.尾2_鱗右_鱗2_表示;
			this.尾2_鱗右_鱗3_表示 = e.尾2_鱗右_鱗3_表示;
			this.尾2_鱗右_鱗4_表示 = e.尾2_鱗右_鱗4_表示;
			this.尾2_表示 = e.尾2_表示;
			this.尾1_鱗左_鱗1_表示 = e.尾1_鱗左_鱗1_表示;
			this.尾1_鱗左_鱗2_表示 = e.尾1_鱗左_鱗2_表示;
			this.尾1_鱗左_鱗3_表示 = e.尾1_鱗左_鱗3_表示;
			this.尾1_鱗左_鱗4_表示 = e.尾1_鱗左_鱗4_表示;
			this.尾1_鱗右_鱗1_表示 = e.尾1_鱗右_鱗1_表示;
			this.尾1_鱗右_鱗2_表示 = e.尾1_鱗右_鱗2_表示;
			this.尾1_鱗右_鱗3_表示 = e.尾1_鱗右_鱗3_表示;
			this.尾1_鱗右_鱗4_表示 = e.尾1_鱗右_鱗4_表示;
			this.尾1_表示 = e.尾1_表示;
			this.尾0_鱗左_鱗1_表示 = e.尾0_鱗左_鱗1_表示;
			this.尾0_鱗左_鱗2_表示 = e.尾0_鱗左_鱗2_表示;
			this.尾0_鱗左_鱗3_表示 = e.尾0_鱗左_鱗3_表示;
			this.尾0_鱗左_鱗4_表示 = e.尾0_鱗左_鱗4_表示;
			this.尾0_鱗右_鱗1_表示 = e.尾0_鱗右_鱗1_表示;
			this.尾0_鱗右_鱗2_表示 = e.尾0_鱗右_鱗2_表示;
			this.尾0_鱗右_鱗3_表示 = e.尾0_鱗右_鱗3_表示;
			this.尾0_鱗右_鱗4_表示 = e.尾0_鱗右_鱗4_表示;
			this.尾0_表示 = e.尾0_表示;
			this.輪表示 = e.輪表示;
			this.尾先表示 = e.尾先表示;
			this.胴_外線 = e.胴_外線;
			this.Rパタ\u30FCン = e.Rパタ\u30FCン;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.左1_接続.Count > 0)
			{
				Ele f;
				this.左1_接続 = e.左1_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左1_接続;
					f.接続(CS$<>8__locals1.<>4__this.左1_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右1_接続.Count > 0)
			{
				Ele f;
				this.右1_接続 = e.右1_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右1_接続;
					f.接続(CS$<>8__locals1.<>4__this.右1_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左2_接続.Count > 0)
			{
				Ele f;
				this.左2_接続 = e.左2_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左2_接続;
					f.接続(CS$<>8__locals1.<>4__this.左2_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右2_接続.Count > 0)
			{
				Ele f;
				this.右2_接続 = e.右2_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右2_接続;
					f.接続(CS$<>8__locals1.<>4__this.右2_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左3_接続.Count > 0)
			{
				Ele f;
				this.左3_接続 = e.左3_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左3_接続;
					f.接続(CS$<>8__locals1.<>4__this.左3_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右3_接続.Count > 0)
			{
				Ele f;
				this.右3_接続 = e.右3_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右3_接続;
					f.接続(CS$<>8__locals1.<>4__this.右3_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左4_接続.Count > 0)
			{
				Ele f;
				this.左4_接続 = e.左4_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左4_接続;
					f.接続(CS$<>8__locals1.<>4__this.左4_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右4_接続.Count > 0)
			{
				Ele f;
				this.右4_接続 = e.右4_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右4_接続;
					f.接続(CS$<>8__locals1.<>4__this.右4_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左5_接続.Count > 0)
			{
				Ele f;
				this.左5_接続 = e.左5_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左5_接続;
					f.接続(CS$<>8__locals1.<>4__this.左5_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右5_接続.Count > 0)
			{
				Ele f;
				this.右5_接続 = e.右5_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右5_接続;
					f.接続(CS$<>8__locals1.<>4__this.右5_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左6_接続.Count > 0)
			{
				Ele f;
				this.左6_接続 = e.左6_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左6_接続;
					f.接続(CS$<>8__locals1.<>4__this.左6_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右6_接続.Count > 0)
			{
				Ele f;
				this.右6_接続 = e.右6_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右6_接続;
					f.接続(CS$<>8__locals1.<>4__this.右6_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左7_接続.Count > 0)
			{
				Ele f;
				this.左7_接続 = e.左7_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左7_接続;
					f.接続(CS$<>8__locals1.<>4__this.左7_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右7_接続.Count > 0)
			{
				Ele f;
				this.右7_接続 = e.右7_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右7_接続;
					f.接続(CS$<>8__locals1.<>4__this.右7_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左8_接続.Count > 0)
			{
				Ele f;
				this.左8_接続 = e.左8_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左8_接続;
					f.接続(CS$<>8__locals1.<>4__this.左8_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右8_接続.Count > 0)
			{
				Ele f;
				this.右8_接続 = e.右8_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右8_接続;
					f.接続(CS$<>8__locals1.<>4__this.右8_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左9_接続.Count > 0)
			{
				Ele f;
				this.左9_接続 = e.左9_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左9_接続;
					f.接続(CS$<>8__locals1.<>4__this.左9_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右9_接続.Count > 0)
			{
				Ele f;
				this.右9_接続 = e.右9_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右9_接続;
					f.接続(CS$<>8__locals1.<>4__this.右9_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左10_接続.Count > 0)
			{
				Ele f;
				this.左10_接続 = e.左10_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左10_接続;
					f.接続(CS$<>8__locals1.<>4__this.左10_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右10_接続.Count > 0)
			{
				Ele f;
				this.右10_接続 = e.右10_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右10_接続;
					f.接続(CS$<>8__locals1.<>4__this.右10_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左11_接続.Count > 0)
			{
				Ele f;
				this.左11_接続 = e.左11_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左11_接続;
					f.接続(CS$<>8__locals1.<>4__this.左11_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右11_接続.Count > 0)
			{
				Ele f;
				this.右11_接続 = e.右11_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右11_接続;
					f.接続(CS$<>8__locals1.<>4__this.右11_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左12_接続.Count > 0)
			{
				Ele f;
				this.左12_接続 = e.左12_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左12_接続;
					f.接続(CS$<>8__locals1.<>4__this.左12_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右12_接続.Count > 0)
			{
				Ele f;
				this.右12_接続 = e.右12_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右12_接続;
					f.接続(CS$<>8__locals1.<>4__this.右12_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左13_接続.Count > 0)
			{
				Ele f;
				this.左13_接続 = e.左13_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左13_接続;
					f.接続(CS$<>8__locals1.<>4__this.左13_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右13_接続.Count > 0)
			{
				Ele f;
				this.右13_接続 = e.右13_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右13_接続;
					f.接続(CS$<>8__locals1.<>4__this.右13_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左14_接続.Count > 0)
			{
				Ele f;
				this.左14_接続 = e.左14_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左14_接続;
					f.接続(CS$<>8__locals1.<>4__this.左14_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右14_接続.Count > 0)
			{
				Ele f;
				this.右14_接続 = e.右14_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右14_接続;
					f.接続(CS$<>8__locals1.<>4__this.右14_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左15_接続.Count > 0)
			{
				Ele f;
				this.左15_接続 = e.左15_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左15_接続;
					f.接続(CS$<>8__locals1.<>4__this.左15_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右15_接続.Count > 0)
			{
				Ele f;
				this.右15_接続 = e.右15_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右15_接続;
					f.接続(CS$<>8__locals1.<>4__this.右15_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左16_接続.Count > 0)
			{
				Ele f;
				this.左16_接続 = e.左16_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左16_接続;
					f.接続(CS$<>8__locals1.<>4__this.左16_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右16_接続.Count > 0)
			{
				Ele f;
				this.右16_接続 = e.右16_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右16_接続;
					f.接続(CS$<>8__locals1.<>4__this.右16_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左17_接続.Count > 0)
			{
				Ele f;
				this.左17_接続 = e.左17_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左17_接続;
					f.接続(CS$<>8__locals1.<>4__this.左17_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右17_接続.Count > 0)
			{
				Ele f;
				this.右17_接続 = e.右17_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右17_接続;
					f.接続(CS$<>8__locals1.<>4__this.右17_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左18_接続.Count > 0)
			{
				Ele f;
				this.左18_接続 = e.左18_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左18_接続;
					f.接続(CS$<>8__locals1.<>4__this.左18_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右18_接続.Count > 0)
			{
				Ele f;
				this.右18_接続 = e.右18_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右18_接続;
					f.接続(CS$<>8__locals1.<>4__this.右18_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左19_接続.Count > 0)
			{
				Ele f;
				this.左19_接続 = e.左19_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左19_接続;
					f.接続(CS$<>8__locals1.<>4__this.左19_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右19_接続.Count > 0)
			{
				Ele f;
				this.右19_接続 = e.右19_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右19_接続;
					f.接続(CS$<>8__locals1.<>4__this.右19_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左20_接続.Count > 0)
			{
				Ele f;
				this.左20_接続 = e.左20_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左20_接続;
					f.接続(CS$<>8__locals1.<>4__this.左20_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右20_接続.Count > 0)
			{
				Ele f;
				this.右20_接続 = e.右20_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右20_接続;
					f.接続(CS$<>8__locals1.<>4__this.右20_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左21_接続.Count > 0)
			{
				Ele f;
				this.左21_接続 = e.左21_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左21_接続;
					f.接続(CS$<>8__locals1.<>4__this.左21_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右21_接続.Count > 0)
			{
				Ele f;
				this.右21_接続 = e.右21_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右21_接続;
					f.接続(CS$<>8__locals1.<>4__this.右21_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左22_接続.Count > 0)
			{
				Ele f;
				this.左22_接続 = e.左22_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左22_接続;
					f.接続(CS$<>8__locals1.<>4__this.左22_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右22_接続.Count > 0)
			{
				Ele f;
				this.右22_接続 = e.右22_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右22_接続;
					f.接続(CS$<>8__locals1.<>4__this.右22_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左23_接続.Count > 0)
			{
				Ele f;
				this.左23_接続 = e.左23_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左23_接続;
					f.接続(CS$<>8__locals1.<>4__this.左23_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右23_接続.Count > 0)
			{
				Ele f;
				this.右23_接続 = e.右23_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右23_接続;
					f.接続(CS$<>8__locals1.<>4__this.右23_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左24_接続.Count > 0)
			{
				Ele f;
				this.左24_接続 = e.左24_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左24_接続;
					f.接続(CS$<>8__locals1.<>4__this.左24_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右24_接続.Count > 0)
			{
				Ele f;
				this.右24_接続 = e.右24_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右24_接続;
					f.接続(CS$<>8__locals1.<>4__this.右24_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左25_接続.Count > 0)
			{
				Ele f;
				this.左25_接続 = e.左25_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左25_接続;
					f.接続(CS$<>8__locals1.<>4__this.左25_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右25_接続.Count > 0)
			{
				Ele f;
				this.右25_接続 = e.右25_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右25_接続;
					f.接続(CS$<>8__locals1.<>4__this.右25_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左26_接続.Count > 0)
			{
				Ele f;
				this.左26_接続 = e.左26_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左26_接続;
					f.接続(CS$<>8__locals1.<>4__this.左26_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右26_接続.Count > 0)
			{
				Ele f;
				this.右26_接続 = e.右26_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右26_接続;
					f.接続(CS$<>8__locals1.<>4__this.右26_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左27_接続.Count > 0)
			{
				Ele f;
				this.左27_接続 = e.左27_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左27_接続;
					f.接続(CS$<>8__locals1.<>4__this.左27_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右27_接続.Count > 0)
			{
				Ele f;
				this.右27_接続 = e.右27_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右27_接続;
					f.接続(CS$<>8__locals1.<>4__this.右27_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左28_接続.Count > 0)
			{
				Ele f;
				this.左28_接続 = e.左28_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左28_接続;
					f.接続(CS$<>8__locals1.<>4__this.左28_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右28_接続.Count > 0)
			{
				Ele f;
				this.右28_接続 = e.右28_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右28_接続;
					f.接続(CS$<>8__locals1.<>4__this.右28_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左29_接続.Count > 0)
			{
				Ele f;
				this.左29_接続 = e.左29_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左29_接続;
					f.接続(CS$<>8__locals1.<>4__this.左29_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右29_接続.Count > 0)
			{
				Ele f;
				this.右29_接続 = e.右29_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右29_接続;
					f.接続(CS$<>8__locals1.<>4__this.右29_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左30_接続.Count > 0)
			{
				Ele f;
				this.左30_接続 = e.左30_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左30_接続;
					f.接続(CS$<>8__locals1.<>4__this.左30_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右30_接続.Count > 0)
			{
				Ele f;
				this.右30_接続 = e.右30_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右30_接続;
					f.接続(CS$<>8__locals1.<>4__this.右30_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左31_接続.Count > 0)
			{
				Ele f;
				this.左31_接続 = e.左31_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左31_接続;
					f.接続(CS$<>8__locals1.<>4__this.左31_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右31_接続.Count > 0)
			{
				Ele f;
				this.右31_接続 = e.右31_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右31_接続;
					f.接続(CS$<>8__locals1.<>4__this.右31_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左32_接続.Count > 0)
			{
				Ele f;
				this.左32_接続 = e.左32_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左32_接続;
					f.接続(CS$<>8__locals1.<>4__this.左32_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右32_接続.Count > 0)
			{
				Ele f;
				this.右32_接続 = e.右32_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右32_接続;
					f.接続(CS$<>8__locals1.<>4__this.右32_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左33_接続.Count > 0)
			{
				Ele f;
				this.左33_接続 = e.左33_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左33_接続;
					f.接続(CS$<>8__locals1.<>4__this.左33_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右33_接続.Count > 0)
			{
				Ele f;
				this.右33_接続 = e.右33_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右33_接続;
					f.接続(CS$<>8__locals1.<>4__this.右33_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.左34_接続.Count > 0)
			{
				Ele f;
				this.左34_接続 = e.左34_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_左34_接続;
					f.接続(CS$<>8__locals1.<>4__this.左34_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.右34_接続.Count > 0)
			{
				Ele f;
				this.右34_接続 = e.右34_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_右34_接続;
					f.接続(CS$<>8__locals1.<>4__this.右34_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.尾先_接続.Count > 0)
			{
				Ele f;
				this.尾先_接続 = e.尾先_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.尾_魚_尾先_接続;
					f.接続(CS$<>8__locals1.<>4__this.尾先_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_尾33_鱗左_鱗1CP = new ColorP(this.X0Y0_尾33_鱗左_鱗1, this.尾33_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾33_鱗左_鱗3CP = new ColorP(this.X0Y0_尾33_鱗左_鱗3, this.尾33_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾33_鱗右_鱗1CP = new ColorP(this.X0Y0_尾33_鱗右_鱗1, this.尾33_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾33_鱗右_鱗3CP = new ColorP(this.X0Y0_尾33_鱗右_鱗3, this.尾33_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾33_尾CP = new ColorP(this.X0Y0_尾33_尾, this.尾33_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾32_鱗左_鱗1CP = new ColorP(this.X0Y0_尾32_鱗左_鱗1, this.尾32_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾32_鱗左_鱗2CP = new ColorP(this.X0Y0_尾32_鱗左_鱗2, this.尾32_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾32_鱗左_鱗3CP = new ColorP(this.X0Y0_尾32_鱗左_鱗3, this.尾32_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾32_鱗左_鱗4CP = new ColorP(this.X0Y0_尾32_鱗左_鱗4, this.尾32_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾32_鱗右_鱗1CP = new ColorP(this.X0Y0_尾32_鱗右_鱗1, this.尾32_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾32_鱗右_鱗2CP = new ColorP(this.X0Y0_尾32_鱗右_鱗2, this.尾32_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾32_鱗右_鱗3CP = new ColorP(this.X0Y0_尾32_鱗右_鱗3, this.尾32_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾32_鱗右_鱗4CP = new ColorP(this.X0Y0_尾32_鱗右_鱗4, this.尾32_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾32_尾CP = new ColorP(this.X0Y0_尾32_尾, this.尾32_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾31_鱗左_鱗1CP = new ColorP(this.X0Y0_尾31_鱗左_鱗1, this.尾31_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾31_鱗左_鱗2CP = new ColorP(this.X0Y0_尾31_鱗左_鱗2, this.尾31_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾31_鱗左_鱗3CP = new ColorP(this.X0Y0_尾31_鱗左_鱗3, this.尾31_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾31_鱗左_鱗4CP = new ColorP(this.X0Y0_尾31_鱗左_鱗4, this.尾31_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾31_鱗右_鱗1CP = new ColorP(this.X0Y0_尾31_鱗右_鱗1, this.尾31_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾31_鱗右_鱗2CP = new ColorP(this.X0Y0_尾31_鱗右_鱗2, this.尾31_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾31_鱗右_鱗3CP = new ColorP(this.X0Y0_尾31_鱗右_鱗3, this.尾31_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾31_鱗右_鱗4CP = new ColorP(this.X0Y0_尾31_鱗右_鱗4, this.尾31_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾31_尾CP = new ColorP(this.X0Y0_尾31_尾, this.尾31_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾30_鱗左_鱗1CP = new ColorP(this.X0Y0_尾30_鱗左_鱗1, this.尾30_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾30_鱗左_鱗2CP = new ColorP(this.X0Y0_尾30_鱗左_鱗2, this.尾30_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾30_鱗左_鱗3CP = new ColorP(this.X0Y0_尾30_鱗左_鱗3, this.尾30_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾30_鱗左_鱗4CP = new ColorP(this.X0Y0_尾30_鱗左_鱗4, this.尾30_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾30_鱗右_鱗1CP = new ColorP(this.X0Y0_尾30_鱗右_鱗1, this.尾30_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾30_鱗右_鱗2CP = new ColorP(this.X0Y0_尾30_鱗右_鱗2, this.尾30_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾30_鱗右_鱗3CP = new ColorP(this.X0Y0_尾30_鱗右_鱗3, this.尾30_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾30_鱗右_鱗4CP = new ColorP(this.X0Y0_尾30_鱗右_鱗4, this.尾30_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾30_尾CP = new ColorP(this.X0Y0_尾30_尾, this.尾30_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾29_鱗左_鱗1CP = new ColorP(this.X0Y0_尾29_鱗左_鱗1, this.尾29_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾29_鱗左_鱗2CP = new ColorP(this.X0Y0_尾29_鱗左_鱗2, this.尾29_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾29_鱗左_鱗3CP = new ColorP(this.X0Y0_尾29_鱗左_鱗3, this.尾29_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾29_鱗左_鱗4CP = new ColorP(this.X0Y0_尾29_鱗左_鱗4, this.尾29_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾29_鱗右_鱗1CP = new ColorP(this.X0Y0_尾29_鱗右_鱗1, this.尾29_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾29_鱗右_鱗2CP = new ColorP(this.X0Y0_尾29_鱗右_鱗2, this.尾29_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾29_鱗右_鱗3CP = new ColorP(this.X0Y0_尾29_鱗右_鱗3, this.尾29_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾29_鱗右_鱗4CP = new ColorP(this.X0Y0_尾29_鱗右_鱗4, this.尾29_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾29_尾CP = new ColorP(this.X0Y0_尾29_尾, this.尾29_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾28_鱗左_鱗1CP = new ColorP(this.X0Y0_尾28_鱗左_鱗1, this.尾28_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾28_鱗左_鱗2CP = new ColorP(this.X0Y0_尾28_鱗左_鱗2, this.尾28_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾28_鱗左_鱗3CP = new ColorP(this.X0Y0_尾28_鱗左_鱗3, this.尾28_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾28_鱗左_鱗4CP = new ColorP(this.X0Y0_尾28_鱗左_鱗4, this.尾28_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾28_鱗右_鱗1CP = new ColorP(this.X0Y0_尾28_鱗右_鱗1, this.尾28_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾28_鱗右_鱗2CP = new ColorP(this.X0Y0_尾28_鱗右_鱗2, this.尾28_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾28_鱗右_鱗3CP = new ColorP(this.X0Y0_尾28_鱗右_鱗3, this.尾28_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾28_鱗右_鱗4CP = new ColorP(this.X0Y0_尾28_鱗右_鱗4, this.尾28_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾28_尾CP = new ColorP(this.X0Y0_尾28_尾, this.尾28_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾27_鱗左_鱗1CP = new ColorP(this.X0Y0_尾27_鱗左_鱗1, this.尾27_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾27_鱗左_鱗2CP = new ColorP(this.X0Y0_尾27_鱗左_鱗2, this.尾27_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾27_鱗左_鱗3CP = new ColorP(this.X0Y0_尾27_鱗左_鱗3, this.尾27_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾27_鱗左_鱗4CP = new ColorP(this.X0Y0_尾27_鱗左_鱗4, this.尾27_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾27_鱗右_鱗1CP = new ColorP(this.X0Y0_尾27_鱗右_鱗1, this.尾27_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾27_鱗右_鱗2CP = new ColorP(this.X0Y0_尾27_鱗右_鱗2, this.尾27_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾27_鱗右_鱗3CP = new ColorP(this.X0Y0_尾27_鱗右_鱗3, this.尾27_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾27_鱗右_鱗4CP = new ColorP(this.X0Y0_尾27_鱗右_鱗4, this.尾27_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾27_尾CP = new ColorP(this.X0Y0_尾27_尾, this.尾27_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾26_鱗左_鱗1CP = new ColorP(this.X0Y0_尾26_鱗左_鱗1, this.尾26_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾26_鱗左_鱗2CP = new ColorP(this.X0Y0_尾26_鱗左_鱗2, this.尾26_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾26_鱗左_鱗3CP = new ColorP(this.X0Y0_尾26_鱗左_鱗3, this.尾26_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾26_鱗左_鱗4CP = new ColorP(this.X0Y0_尾26_鱗左_鱗4, this.尾26_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾26_鱗右_鱗1CP = new ColorP(this.X0Y0_尾26_鱗右_鱗1, this.尾26_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾26_鱗右_鱗2CP = new ColorP(this.X0Y0_尾26_鱗右_鱗2, this.尾26_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾26_鱗右_鱗3CP = new ColorP(this.X0Y0_尾26_鱗右_鱗3, this.尾26_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾26_鱗右_鱗4CP = new ColorP(this.X0Y0_尾26_鱗右_鱗4, this.尾26_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾26_尾CP = new ColorP(this.X0Y0_尾26_尾, this.尾26_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾25_鱗左_鱗1CP = new ColorP(this.X0Y0_尾25_鱗左_鱗1, this.尾25_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾25_鱗左_鱗2CP = new ColorP(this.X0Y0_尾25_鱗左_鱗2, this.尾25_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾25_鱗左_鱗3CP = new ColorP(this.X0Y0_尾25_鱗左_鱗3, this.尾25_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾25_鱗左_鱗4CP = new ColorP(this.X0Y0_尾25_鱗左_鱗4, this.尾25_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾25_鱗右_鱗1CP = new ColorP(this.X0Y0_尾25_鱗右_鱗1, this.尾25_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾25_鱗右_鱗2CP = new ColorP(this.X0Y0_尾25_鱗右_鱗2, this.尾25_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾25_鱗右_鱗3CP = new ColorP(this.X0Y0_尾25_鱗右_鱗3, this.尾25_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾25_鱗右_鱗4CP = new ColorP(this.X0Y0_尾25_鱗右_鱗4, this.尾25_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾25_尾CP = new ColorP(this.X0Y0_尾25_尾, this.尾25_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾24_鱗左_鱗1CP = new ColorP(this.X0Y0_尾24_鱗左_鱗1, this.尾24_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾24_鱗左_鱗2CP = new ColorP(this.X0Y0_尾24_鱗左_鱗2, this.尾24_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾24_鱗左_鱗3CP = new ColorP(this.X0Y0_尾24_鱗左_鱗3, this.尾24_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾24_鱗左_鱗4CP = new ColorP(this.X0Y0_尾24_鱗左_鱗4, this.尾24_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾24_鱗右_鱗1CP = new ColorP(this.X0Y0_尾24_鱗右_鱗1, this.尾24_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾24_鱗右_鱗2CP = new ColorP(this.X0Y0_尾24_鱗右_鱗2, this.尾24_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾24_鱗右_鱗3CP = new ColorP(this.X0Y0_尾24_鱗右_鱗3, this.尾24_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾24_鱗右_鱗4CP = new ColorP(this.X0Y0_尾24_鱗右_鱗4, this.尾24_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾24_尾CP = new ColorP(this.X0Y0_尾24_尾, this.尾24_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾23_鱗左_鱗1CP = new ColorP(this.X0Y0_尾23_鱗左_鱗1, this.尾23_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾23_鱗左_鱗2CP = new ColorP(this.X0Y0_尾23_鱗左_鱗2, this.尾23_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾23_鱗左_鱗3CP = new ColorP(this.X0Y0_尾23_鱗左_鱗3, this.尾23_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾23_鱗左_鱗4CP = new ColorP(this.X0Y0_尾23_鱗左_鱗4, this.尾23_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾23_鱗右_鱗1CP = new ColorP(this.X0Y0_尾23_鱗右_鱗1, this.尾23_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾23_鱗右_鱗2CP = new ColorP(this.X0Y0_尾23_鱗右_鱗2, this.尾23_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾23_鱗右_鱗3CP = new ColorP(this.X0Y0_尾23_鱗右_鱗3, this.尾23_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾23_鱗右_鱗4CP = new ColorP(this.X0Y0_尾23_鱗右_鱗4, this.尾23_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾23_尾CP = new ColorP(this.X0Y0_尾23_尾, this.尾23_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾22_鱗左_鱗1CP = new ColorP(this.X0Y0_尾22_鱗左_鱗1, this.尾22_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾22_鱗左_鱗2CP = new ColorP(this.X0Y0_尾22_鱗左_鱗2, this.尾22_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾22_鱗左_鱗3CP = new ColorP(this.X0Y0_尾22_鱗左_鱗3, this.尾22_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾22_鱗左_鱗4CP = new ColorP(this.X0Y0_尾22_鱗左_鱗4, this.尾22_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾22_鱗右_鱗1CP = new ColorP(this.X0Y0_尾22_鱗右_鱗1, this.尾22_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾22_鱗右_鱗2CP = new ColorP(this.X0Y0_尾22_鱗右_鱗2, this.尾22_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾22_鱗右_鱗3CP = new ColorP(this.X0Y0_尾22_鱗右_鱗3, this.尾22_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾22_鱗右_鱗4CP = new ColorP(this.X0Y0_尾22_鱗右_鱗4, this.尾22_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾22_尾CP = new ColorP(this.X0Y0_尾22_尾, this.尾22_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾21_鱗左_鱗1CP = new ColorP(this.X0Y0_尾21_鱗左_鱗1, this.尾21_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾21_鱗左_鱗2CP = new ColorP(this.X0Y0_尾21_鱗左_鱗2, this.尾21_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾21_鱗左_鱗3CP = new ColorP(this.X0Y0_尾21_鱗左_鱗3, this.尾21_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾21_鱗左_鱗4CP = new ColorP(this.X0Y0_尾21_鱗左_鱗4, this.尾21_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾21_鱗右_鱗1CP = new ColorP(this.X0Y0_尾21_鱗右_鱗1, this.尾21_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾21_鱗右_鱗2CP = new ColorP(this.X0Y0_尾21_鱗右_鱗2, this.尾21_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾21_鱗右_鱗3CP = new ColorP(this.X0Y0_尾21_鱗右_鱗3, this.尾21_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾21_鱗右_鱗4CP = new ColorP(this.X0Y0_尾21_鱗右_鱗4, this.尾21_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾21_尾CP = new ColorP(this.X0Y0_尾21_尾, this.尾21_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾20_鱗左_鱗1CP = new ColorP(this.X0Y0_尾20_鱗左_鱗1, this.尾20_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾20_鱗左_鱗2CP = new ColorP(this.X0Y0_尾20_鱗左_鱗2, this.尾20_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾20_鱗左_鱗3CP = new ColorP(this.X0Y0_尾20_鱗左_鱗3, this.尾20_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾20_鱗左_鱗4CP = new ColorP(this.X0Y0_尾20_鱗左_鱗4, this.尾20_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾20_鱗右_鱗1CP = new ColorP(this.X0Y0_尾20_鱗右_鱗1, this.尾20_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾20_鱗右_鱗2CP = new ColorP(this.X0Y0_尾20_鱗右_鱗2, this.尾20_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾20_鱗右_鱗3CP = new ColorP(this.X0Y0_尾20_鱗右_鱗3, this.尾20_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾20_鱗右_鱗4CP = new ColorP(this.X0Y0_尾20_鱗右_鱗4, this.尾20_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾20_尾CP = new ColorP(this.X0Y0_尾20_尾, this.尾20_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾19_鱗左_鱗1CP = new ColorP(this.X0Y0_尾19_鱗左_鱗1, this.尾19_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾19_鱗左_鱗2CP = new ColorP(this.X0Y0_尾19_鱗左_鱗2, this.尾19_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾19_鱗左_鱗3CP = new ColorP(this.X0Y0_尾19_鱗左_鱗3, this.尾19_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾19_鱗左_鱗4CP = new ColorP(this.X0Y0_尾19_鱗左_鱗4, this.尾19_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾19_鱗右_鱗1CP = new ColorP(this.X0Y0_尾19_鱗右_鱗1, this.尾19_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾19_鱗右_鱗2CP = new ColorP(this.X0Y0_尾19_鱗右_鱗2, this.尾19_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾19_鱗右_鱗3CP = new ColorP(this.X0Y0_尾19_鱗右_鱗3, this.尾19_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾19_鱗右_鱗4CP = new ColorP(this.X0Y0_尾19_鱗右_鱗4, this.尾19_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾19_尾CP = new ColorP(this.X0Y0_尾19_尾, this.尾19_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾18_鱗左_鱗1CP = new ColorP(this.X0Y0_尾18_鱗左_鱗1, this.尾18_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾18_鱗左_鱗2CP = new ColorP(this.X0Y0_尾18_鱗左_鱗2, this.尾18_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾18_鱗左_鱗3CP = new ColorP(this.X0Y0_尾18_鱗左_鱗3, this.尾18_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾18_鱗左_鱗4CP = new ColorP(this.X0Y0_尾18_鱗左_鱗4, this.尾18_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾18_鱗右_鱗1CP = new ColorP(this.X0Y0_尾18_鱗右_鱗1, this.尾18_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾18_鱗右_鱗2CP = new ColorP(this.X0Y0_尾18_鱗右_鱗2, this.尾18_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾18_鱗右_鱗3CP = new ColorP(this.X0Y0_尾18_鱗右_鱗3, this.尾18_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾18_鱗右_鱗4CP = new ColorP(this.X0Y0_尾18_鱗右_鱗4, this.尾18_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾18_尾CP = new ColorP(this.X0Y0_尾18_尾, this.尾18_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾17_鱗左_鱗1CP = new ColorP(this.X0Y0_尾17_鱗左_鱗1, this.尾17_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾17_鱗左_鱗2CP = new ColorP(this.X0Y0_尾17_鱗左_鱗2, this.尾17_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾17_鱗左_鱗3CP = new ColorP(this.X0Y0_尾17_鱗左_鱗3, this.尾17_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾17_鱗左_鱗4CP = new ColorP(this.X0Y0_尾17_鱗左_鱗4, this.尾17_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾17_鱗右_鱗1CP = new ColorP(this.X0Y0_尾17_鱗右_鱗1, this.尾17_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾17_鱗右_鱗2CP = new ColorP(this.X0Y0_尾17_鱗右_鱗2, this.尾17_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾17_鱗右_鱗3CP = new ColorP(this.X0Y0_尾17_鱗右_鱗3, this.尾17_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾17_鱗右_鱗4CP = new ColorP(this.X0Y0_尾17_鱗右_鱗4, this.尾17_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾17_尾CP = new ColorP(this.X0Y0_尾17_尾, this.尾17_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾16_鱗左_鱗1CP = new ColorP(this.X0Y0_尾16_鱗左_鱗1, this.尾16_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾16_鱗左_鱗2CP = new ColorP(this.X0Y0_尾16_鱗左_鱗2, this.尾16_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾16_鱗左_鱗3CP = new ColorP(this.X0Y0_尾16_鱗左_鱗3, this.尾16_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾16_鱗左_鱗4CP = new ColorP(this.X0Y0_尾16_鱗左_鱗4, this.尾16_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾16_鱗右_鱗1CP = new ColorP(this.X0Y0_尾16_鱗右_鱗1, this.尾16_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾16_鱗右_鱗2CP = new ColorP(this.X0Y0_尾16_鱗右_鱗2, this.尾16_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾16_鱗右_鱗3CP = new ColorP(this.X0Y0_尾16_鱗右_鱗3, this.尾16_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾16_鱗右_鱗4CP = new ColorP(this.X0Y0_尾16_鱗右_鱗4, this.尾16_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾16_尾CP = new ColorP(this.X0Y0_尾16_尾, this.尾16_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾15_鱗左_鱗1CP = new ColorP(this.X0Y0_尾15_鱗左_鱗1, this.尾15_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾15_鱗左_鱗2CP = new ColorP(this.X0Y0_尾15_鱗左_鱗2, this.尾15_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾15_鱗左_鱗3CP = new ColorP(this.X0Y0_尾15_鱗左_鱗3, this.尾15_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾15_鱗左_鱗4CP = new ColorP(this.X0Y0_尾15_鱗左_鱗4, this.尾15_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾15_鱗右_鱗1CP = new ColorP(this.X0Y0_尾15_鱗右_鱗1, this.尾15_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾15_鱗右_鱗2CP = new ColorP(this.X0Y0_尾15_鱗右_鱗2, this.尾15_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾15_鱗右_鱗3CP = new ColorP(this.X0Y0_尾15_鱗右_鱗3, this.尾15_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾15_鱗右_鱗4CP = new ColorP(this.X0Y0_尾15_鱗右_鱗4, this.尾15_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾15_尾CP = new ColorP(this.X0Y0_尾15_尾, this.尾15_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾14_鱗左_鱗1CP = new ColorP(this.X0Y0_尾14_鱗左_鱗1, this.尾14_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾14_鱗左_鱗2CP = new ColorP(this.X0Y0_尾14_鱗左_鱗2, this.尾14_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾14_鱗左_鱗3CP = new ColorP(this.X0Y0_尾14_鱗左_鱗3, this.尾14_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾14_鱗左_鱗4CP = new ColorP(this.X0Y0_尾14_鱗左_鱗4, this.尾14_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾14_鱗右_鱗1CP = new ColorP(this.X0Y0_尾14_鱗右_鱗1, this.尾14_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾14_鱗右_鱗2CP = new ColorP(this.X0Y0_尾14_鱗右_鱗2, this.尾14_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾14_鱗右_鱗3CP = new ColorP(this.X0Y0_尾14_鱗右_鱗3, this.尾14_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾14_鱗右_鱗4CP = new ColorP(this.X0Y0_尾14_鱗右_鱗4, this.尾14_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾14_尾CP = new ColorP(this.X0Y0_尾14_尾, this.尾14_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾13_鱗左_鱗1CP = new ColorP(this.X0Y0_尾13_鱗左_鱗1, this.尾13_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾13_鱗左_鱗2CP = new ColorP(this.X0Y0_尾13_鱗左_鱗2, this.尾13_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾13_鱗左_鱗3CP = new ColorP(this.X0Y0_尾13_鱗左_鱗3, this.尾13_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾13_鱗左_鱗4CP = new ColorP(this.X0Y0_尾13_鱗左_鱗4, this.尾13_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾13_鱗右_鱗1CP = new ColorP(this.X0Y0_尾13_鱗右_鱗1, this.尾13_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾13_鱗右_鱗2CP = new ColorP(this.X0Y0_尾13_鱗右_鱗2, this.尾13_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾13_鱗右_鱗3CP = new ColorP(this.X0Y0_尾13_鱗右_鱗3, this.尾13_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾13_鱗右_鱗4CP = new ColorP(this.X0Y0_尾13_鱗右_鱗4, this.尾13_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾13_尾CP = new ColorP(this.X0Y0_尾13_尾, this.尾13_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾12_鱗左_鱗1CP = new ColorP(this.X0Y0_尾12_鱗左_鱗1, this.尾12_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾12_鱗左_鱗2CP = new ColorP(this.X0Y0_尾12_鱗左_鱗2, this.尾12_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾12_鱗左_鱗3CP = new ColorP(this.X0Y0_尾12_鱗左_鱗3, this.尾12_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾12_鱗左_鱗4CP = new ColorP(this.X0Y0_尾12_鱗左_鱗4, this.尾12_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾12_鱗右_鱗1CP = new ColorP(this.X0Y0_尾12_鱗右_鱗1, this.尾12_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾12_鱗右_鱗2CP = new ColorP(this.X0Y0_尾12_鱗右_鱗2, this.尾12_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾12_鱗右_鱗3CP = new ColorP(this.X0Y0_尾12_鱗右_鱗3, this.尾12_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾12_鱗右_鱗4CP = new ColorP(this.X0Y0_尾12_鱗右_鱗4, this.尾12_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾12_尾CP = new ColorP(this.X0Y0_尾12_尾, this.尾12_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾11_鱗左_鱗1CP = new ColorP(this.X0Y0_尾11_鱗左_鱗1, this.尾11_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾11_鱗左_鱗2CP = new ColorP(this.X0Y0_尾11_鱗左_鱗2, this.尾11_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾11_鱗左_鱗3CP = new ColorP(this.X0Y0_尾11_鱗左_鱗3, this.尾11_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾11_鱗左_鱗4CP = new ColorP(this.X0Y0_尾11_鱗左_鱗4, this.尾11_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾11_鱗右_鱗1CP = new ColorP(this.X0Y0_尾11_鱗右_鱗1, this.尾11_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾11_鱗右_鱗2CP = new ColorP(this.X0Y0_尾11_鱗右_鱗2, this.尾11_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾11_鱗右_鱗3CP = new ColorP(this.X0Y0_尾11_鱗右_鱗3, this.尾11_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾11_鱗右_鱗4CP = new ColorP(this.X0Y0_尾11_鱗右_鱗4, this.尾11_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾11_尾CP = new ColorP(this.X0Y0_尾11_尾, this.尾11_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾10_鱗左_鱗1CP = new ColorP(this.X0Y0_尾10_鱗左_鱗1, this.尾10_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾10_鱗左_鱗2CP = new ColorP(this.X0Y0_尾10_鱗左_鱗2, this.尾10_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾10_鱗左_鱗3CP = new ColorP(this.X0Y0_尾10_鱗左_鱗3, this.尾10_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾10_鱗左_鱗4CP = new ColorP(this.X0Y0_尾10_鱗左_鱗4, this.尾10_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾10_鱗右_鱗1CP = new ColorP(this.X0Y0_尾10_鱗右_鱗1, this.尾10_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾10_鱗右_鱗2CP = new ColorP(this.X0Y0_尾10_鱗右_鱗2, this.尾10_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾10_鱗右_鱗3CP = new ColorP(this.X0Y0_尾10_鱗右_鱗3, this.尾10_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾10_鱗右_鱗4CP = new ColorP(this.X0Y0_尾10_鱗右_鱗4, this.尾10_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾10_尾CP = new ColorP(this.X0Y0_尾10_尾, this.尾10_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾9_鱗左_鱗1CP = new ColorP(this.X0Y0_尾9_鱗左_鱗1, this.尾9_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾9_鱗左_鱗2CP = new ColorP(this.X0Y0_尾9_鱗左_鱗2, this.尾9_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾9_鱗左_鱗3CP = new ColorP(this.X0Y0_尾9_鱗左_鱗3, this.尾9_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾9_鱗左_鱗4CP = new ColorP(this.X0Y0_尾9_鱗左_鱗4, this.尾9_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾9_鱗右_鱗1CP = new ColorP(this.X0Y0_尾9_鱗右_鱗1, this.尾9_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾9_鱗右_鱗2CP = new ColorP(this.X0Y0_尾9_鱗右_鱗2, this.尾9_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾9_鱗右_鱗3CP = new ColorP(this.X0Y0_尾9_鱗右_鱗3, this.尾9_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾9_鱗右_鱗4CP = new ColorP(this.X0Y0_尾9_鱗右_鱗4, this.尾9_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾9_尾CP = new ColorP(this.X0Y0_尾9_尾, this.尾9_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾8_鱗左_鱗1CP = new ColorP(this.X0Y0_尾8_鱗左_鱗1, this.尾8_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾8_鱗左_鱗2CP = new ColorP(this.X0Y0_尾8_鱗左_鱗2, this.尾8_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾8_鱗左_鱗3CP = new ColorP(this.X0Y0_尾8_鱗左_鱗3, this.尾8_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾8_鱗左_鱗4CP = new ColorP(this.X0Y0_尾8_鱗左_鱗4, this.尾8_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾8_鱗右_鱗1CP = new ColorP(this.X0Y0_尾8_鱗右_鱗1, this.尾8_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾8_鱗右_鱗2CP = new ColorP(this.X0Y0_尾8_鱗右_鱗2, this.尾8_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾8_鱗右_鱗3CP = new ColorP(this.X0Y0_尾8_鱗右_鱗3, this.尾8_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾8_鱗右_鱗4CP = new ColorP(this.X0Y0_尾8_鱗右_鱗4, this.尾8_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾8_尾CP = new ColorP(this.X0Y0_尾8_尾, this.尾8_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾7_鱗左_鱗1CP = new ColorP(this.X0Y0_尾7_鱗左_鱗1, this.尾7_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾7_鱗左_鱗2CP = new ColorP(this.X0Y0_尾7_鱗左_鱗2, this.尾7_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾7_鱗左_鱗3CP = new ColorP(this.X0Y0_尾7_鱗左_鱗3, this.尾7_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾7_鱗左_鱗4CP = new ColorP(this.X0Y0_尾7_鱗左_鱗4, this.尾7_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾7_鱗右_鱗1CP = new ColorP(this.X0Y0_尾7_鱗右_鱗1, this.尾7_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾7_鱗右_鱗2CP = new ColorP(this.X0Y0_尾7_鱗右_鱗2, this.尾7_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾7_鱗右_鱗3CP = new ColorP(this.X0Y0_尾7_鱗右_鱗3, this.尾7_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾7_鱗右_鱗4CP = new ColorP(this.X0Y0_尾7_鱗右_鱗4, this.尾7_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾7_尾CP = new ColorP(this.X0Y0_尾7_尾, this.尾7_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾6_鱗左_鱗1CP = new ColorP(this.X0Y0_尾6_鱗左_鱗1, this.尾6_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾6_鱗左_鱗2CP = new ColorP(this.X0Y0_尾6_鱗左_鱗2, this.尾6_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾6_鱗左_鱗3CP = new ColorP(this.X0Y0_尾6_鱗左_鱗3, this.尾6_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾6_鱗左_鱗4CP = new ColorP(this.X0Y0_尾6_鱗左_鱗4, this.尾6_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾6_鱗右_鱗1CP = new ColorP(this.X0Y0_尾6_鱗右_鱗1, this.尾6_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾6_鱗右_鱗2CP = new ColorP(this.X0Y0_尾6_鱗右_鱗2, this.尾6_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾6_鱗右_鱗3CP = new ColorP(this.X0Y0_尾6_鱗右_鱗3, this.尾6_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾6_鱗右_鱗4CP = new ColorP(this.X0Y0_尾6_鱗右_鱗4, this.尾6_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾6_尾CP = new ColorP(this.X0Y0_尾6_尾, this.尾6_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾5_鱗左_鱗1CP = new ColorP(this.X0Y0_尾5_鱗左_鱗1, this.尾5_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾5_鱗左_鱗2CP = new ColorP(this.X0Y0_尾5_鱗左_鱗2, this.尾5_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾5_鱗左_鱗3CP = new ColorP(this.X0Y0_尾5_鱗左_鱗3, this.尾5_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾5_鱗左_鱗4CP = new ColorP(this.X0Y0_尾5_鱗左_鱗4, this.尾5_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾5_鱗右_鱗1CP = new ColorP(this.X0Y0_尾5_鱗右_鱗1, this.尾5_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾5_鱗右_鱗2CP = new ColorP(this.X0Y0_尾5_鱗右_鱗2, this.尾5_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾5_鱗右_鱗3CP = new ColorP(this.X0Y0_尾5_鱗右_鱗3, this.尾5_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾5_鱗右_鱗4CP = new ColorP(this.X0Y0_尾5_鱗右_鱗4, this.尾5_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾5_尾CP = new ColorP(this.X0Y0_尾5_尾, this.尾5_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_鱗左_鱗1CP = new ColorP(this.X0Y0_尾4_鱗左_鱗1, this.尾4_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_鱗左_鱗2CP = new ColorP(this.X0Y0_尾4_鱗左_鱗2, this.尾4_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_鱗左_鱗3CP = new ColorP(this.X0Y0_尾4_鱗左_鱗3, this.尾4_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_鱗左_鱗4CP = new ColorP(this.X0Y0_尾4_鱗左_鱗4, this.尾4_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_鱗右_鱗1CP = new ColorP(this.X0Y0_尾4_鱗右_鱗1, this.尾4_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_鱗右_鱗2CP = new ColorP(this.X0Y0_尾4_鱗右_鱗2, this.尾4_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_鱗右_鱗3CP = new ColorP(this.X0Y0_尾4_鱗右_鱗3, this.尾4_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_鱗右_鱗4CP = new ColorP(this.X0Y0_尾4_鱗右_鱗4, this.尾4_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾4_尾CP = new ColorP(this.X0Y0_尾4_尾, this.尾4_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪_革CP = new ColorP(this.X0Y0_輪_革, this.輪_革CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪_金具1CP = new ColorP(this.X0Y0_輪_金具1, this.輪_金具1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪_金具2CP = new ColorP(this.X0Y0_輪_金具2, this.輪_金具2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪_金具3CP = new ColorP(this.X0Y0_輪_金具3, this.輪_金具3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪_金具左CP = new ColorP(this.X0Y0_輪_金具左, this.輪_金具左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪_金具右CP = new ColorP(this.X0Y0_輪_金具右, this.輪_金具右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_鱗左_鱗1CP = new ColorP(this.X0Y0_尾3_鱗左_鱗1, this.尾3_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_鱗左_鱗2CP = new ColorP(this.X0Y0_尾3_鱗左_鱗2, this.尾3_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_鱗左_鱗3CP = new ColorP(this.X0Y0_尾3_鱗左_鱗3, this.尾3_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_鱗左_鱗4CP = new ColorP(this.X0Y0_尾3_鱗左_鱗4, this.尾3_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_鱗右_鱗1CP = new ColorP(this.X0Y0_尾3_鱗右_鱗1, this.尾3_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_鱗右_鱗2CP = new ColorP(this.X0Y0_尾3_鱗右_鱗2, this.尾3_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_鱗右_鱗3CP = new ColorP(this.X0Y0_尾3_鱗右_鱗3, this.尾3_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_鱗右_鱗4CP = new ColorP(this.X0Y0_尾3_鱗右_鱗4, this.尾3_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾3_尾CP = new ColorP(this.X0Y0_尾3_尾, this.尾3_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_鱗左_鱗1CP = new ColorP(this.X0Y0_尾2_鱗左_鱗1, this.尾2_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_鱗左_鱗2CP = new ColorP(this.X0Y0_尾2_鱗左_鱗2, this.尾2_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_鱗左_鱗3CP = new ColorP(this.X0Y0_尾2_鱗左_鱗3, this.尾2_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_鱗左_鱗4CP = new ColorP(this.X0Y0_尾2_鱗左_鱗4, this.尾2_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_鱗右_鱗1CP = new ColorP(this.X0Y0_尾2_鱗右_鱗1, this.尾2_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_鱗右_鱗2CP = new ColorP(this.X0Y0_尾2_鱗右_鱗2, this.尾2_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_鱗右_鱗3CP = new ColorP(this.X0Y0_尾2_鱗右_鱗3, this.尾2_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_鱗右_鱗4CP = new ColorP(this.X0Y0_尾2_鱗右_鱗4, this.尾2_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾2_尾CP = new ColorP(this.X0Y0_尾2_尾, this.尾2_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_鱗左_鱗1CP = new ColorP(this.X0Y0_尾1_鱗左_鱗1, this.尾1_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_鱗左_鱗2CP = new ColorP(this.X0Y0_尾1_鱗左_鱗2, this.尾1_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_鱗左_鱗3CP = new ColorP(this.X0Y0_尾1_鱗左_鱗3, this.尾1_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_鱗左_鱗4CP = new ColorP(this.X0Y0_尾1_鱗左_鱗4, this.尾1_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_鱗右_鱗1CP = new ColorP(this.X0Y0_尾1_鱗右_鱗1, this.尾1_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_鱗右_鱗2CP = new ColorP(this.X0Y0_尾1_鱗右_鱗2, this.尾1_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_鱗右_鱗3CP = new ColorP(this.X0Y0_尾1_鱗右_鱗3, this.尾1_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_鱗右_鱗4CP = new ColorP(this.X0Y0_尾1_鱗右_鱗4, this.尾1_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾1_尾CP = new ColorP(this.X0Y0_尾1_尾, this.尾1_尾CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾0_鱗左_鱗1CP = new ColorP(this.X0Y0_尾0_鱗左_鱗1, this.尾0_鱗左_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾0_鱗左_鱗2CP = new ColorP(this.X0Y0_尾0_鱗左_鱗2, this.尾0_鱗左_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾0_鱗左_鱗3CP = new ColorP(this.X0Y0_尾0_鱗左_鱗3, this.尾0_鱗左_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾0_鱗左_鱗4CP = new ColorP(this.X0Y0_尾0_鱗左_鱗4, this.尾0_鱗左_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾0_鱗右_鱗1CP = new ColorP(this.X0Y0_尾0_鱗右_鱗1, this.尾0_鱗右_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾0_鱗右_鱗2CP = new ColorP(this.X0Y0_尾0_鱗右_鱗2, this.尾0_鱗右_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾0_鱗右_鱗3CP = new ColorP(this.X0Y0_尾0_鱗右_鱗3, this.尾0_鱗右_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾0_鱗右_鱗4CP = new ColorP(this.X0Y0_尾0_鱗右_鱗4, this.尾0_鱗右_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_尾0_尾CP = new ColorP(this.X0Y0_尾0_尾, this.尾0_尾CD, CS$<>8__locals1.DisUnit, true);
			this.濃度 = e.濃度;
			this.鎖1 = new 拘束鎖(CS$<>8__locals1.DisUnit, this.右, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖2 = new 拘束鎖(CS$<>8__locals1.DisUnit, !this.右, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖1.接続(this.鎖1_接続点);
			this.鎖2.接続(this.鎖2_接続点);
			int num = this.右 ? -10 : 10;
			this.鎖1.角度B -= (double)num;
			this.鎖2.角度B += (double)num;
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
				this.輪表示 = this.拘束_;
			}
		}

		public bool 尾33_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾33_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾33_鱗左_鱗1.Dra = value;
				this.X0Y0_尾33_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾33_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾33_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾33_鱗左_鱗3.Dra = value;
				this.X0Y0_尾33_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾33_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾33_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾33_鱗右_鱗1.Dra = value;
				this.X0Y0_尾33_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾33_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾33_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾33_鱗右_鱗3.Dra = value;
				this.X0Y0_尾33_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾33_表示
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

		public bool 尾32_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾32_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾32_鱗左_鱗1.Dra = value;
				this.X0Y0_尾32_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾32_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾32_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾32_鱗左_鱗2.Dra = value;
				this.X0Y0_尾32_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾32_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾32_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾32_鱗左_鱗3.Dra = value;
				this.X0Y0_尾32_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾32_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾32_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾32_鱗左_鱗4.Dra = value;
				this.X0Y0_尾32_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾32_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾32_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾32_鱗右_鱗1.Dra = value;
				this.X0Y0_尾32_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾32_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾32_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾32_鱗右_鱗2.Dra = value;
				this.X0Y0_尾32_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾32_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾32_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾32_鱗右_鱗3.Dra = value;
				this.X0Y0_尾32_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾32_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾32_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾32_鱗右_鱗4.Dra = value;
				this.X0Y0_尾32_鱗右_鱗4.Hit = value;
			}
		}

		public bool 尾32_表示
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

		public bool 尾31_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾31_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾31_鱗左_鱗1.Dra = value;
				this.X0Y0_尾31_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾31_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾31_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾31_鱗左_鱗2.Dra = value;
				this.X0Y0_尾31_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾31_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾31_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾31_鱗左_鱗3.Dra = value;
				this.X0Y0_尾31_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾31_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾31_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾31_鱗左_鱗4.Dra = value;
				this.X0Y0_尾31_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾31_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾31_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾31_鱗右_鱗1.Dra = value;
				this.X0Y0_尾31_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾31_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾31_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾31_鱗右_鱗2.Dra = value;
				this.X0Y0_尾31_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾31_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾31_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾31_鱗右_鱗3.Dra = value;
				this.X0Y0_尾31_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾31_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾31_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾31_鱗右_鱗4.Dra = value;
				this.X0Y0_尾31_鱗右_鱗4.Hit = value;
			}
		}

		public bool 尾31_表示
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

		public bool 尾30_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾30_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾30_鱗左_鱗1.Dra = value;
				this.X0Y0_尾30_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾30_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾30_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾30_鱗左_鱗2.Dra = value;
				this.X0Y0_尾30_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾30_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾30_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾30_鱗左_鱗3.Dra = value;
				this.X0Y0_尾30_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾30_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾30_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾30_鱗左_鱗4.Dra = value;
				this.X0Y0_尾30_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾30_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾30_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾30_鱗右_鱗1.Dra = value;
				this.X0Y0_尾30_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾30_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾30_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾30_鱗右_鱗2.Dra = value;
				this.X0Y0_尾30_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾30_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾30_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾30_鱗右_鱗3.Dra = value;
				this.X0Y0_尾30_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾30_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾30_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾30_鱗右_鱗4.Dra = value;
				this.X0Y0_尾30_鱗右_鱗4.Hit = value;
			}
		}

		public bool 尾30_表示
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

		public bool 尾29_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾29_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾29_鱗左_鱗1.Dra = value;
				this.X0Y0_尾29_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾29_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾29_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾29_鱗左_鱗2.Dra = value;
				this.X0Y0_尾29_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾29_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾29_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾29_鱗左_鱗3.Dra = value;
				this.X0Y0_尾29_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾29_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾29_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾29_鱗左_鱗4.Dra = value;
				this.X0Y0_尾29_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾29_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾29_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾29_鱗右_鱗1.Dra = value;
				this.X0Y0_尾29_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾29_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾29_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾29_鱗右_鱗2.Dra = value;
				this.X0Y0_尾29_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾29_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾29_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾29_鱗右_鱗3.Dra = value;
				this.X0Y0_尾29_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾29_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾29_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾29_鱗右_鱗4.Dra = value;
				this.X0Y0_尾29_鱗右_鱗4.Hit = value;
			}
		}

		public bool 尾29_表示
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

		public bool 尾28_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾28_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾28_鱗左_鱗1.Dra = value;
				this.X0Y0_尾28_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾28_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾28_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾28_鱗左_鱗2.Dra = value;
				this.X0Y0_尾28_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾28_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾28_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾28_鱗左_鱗3.Dra = value;
				this.X0Y0_尾28_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾28_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾28_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾28_鱗左_鱗4.Dra = value;
				this.X0Y0_尾28_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾28_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾28_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾28_鱗右_鱗1.Dra = value;
				this.X0Y0_尾28_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾28_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾28_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾28_鱗右_鱗2.Dra = value;
				this.X0Y0_尾28_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾28_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾28_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾28_鱗右_鱗3.Dra = value;
				this.X0Y0_尾28_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾28_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾28_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾28_鱗右_鱗4.Dra = value;
				this.X0Y0_尾28_鱗右_鱗4.Hit = value;
			}
		}

		public bool 尾28_表示
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

		public bool 尾27_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾27_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾27_鱗左_鱗1.Dra = value;
				this.X0Y0_尾27_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾27_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾27_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾27_鱗左_鱗2.Dra = value;
				this.X0Y0_尾27_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾27_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾27_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾27_鱗左_鱗3.Dra = value;
				this.X0Y0_尾27_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾27_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾27_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾27_鱗左_鱗4.Dra = value;
				this.X0Y0_尾27_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾27_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾27_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾27_鱗右_鱗1.Dra = value;
				this.X0Y0_尾27_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾27_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾27_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾27_鱗右_鱗2.Dra = value;
				this.X0Y0_尾27_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾27_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾27_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾27_鱗右_鱗3.Dra = value;
				this.X0Y0_尾27_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾27_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾27_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾27_鱗右_鱗4.Dra = value;
				this.X0Y0_尾27_鱗右_鱗4.Hit = value;
			}
		}

		public bool 尾27_表示
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

		public bool 尾26_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾26_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾26_鱗左_鱗1.Dra = value;
				this.X0Y0_尾26_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾26_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾26_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾26_鱗左_鱗2.Dra = value;
				this.X0Y0_尾26_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾26_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾26_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾26_鱗左_鱗3.Dra = value;
				this.X0Y0_尾26_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾26_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾26_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾26_鱗左_鱗4.Dra = value;
				this.X0Y0_尾26_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾26_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾26_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾26_鱗右_鱗1.Dra = value;
				this.X0Y0_尾26_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾26_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾26_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾26_鱗右_鱗2.Dra = value;
				this.X0Y0_尾26_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾26_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾26_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾26_鱗右_鱗3.Dra = value;
				this.X0Y0_尾26_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾26_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾26_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾26_鱗右_鱗4.Dra = value;
				this.X0Y0_尾26_鱗右_鱗4.Hit = value;
			}
		}

		public bool 尾26_表示
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

		public bool 尾25_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾25_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾25_鱗左_鱗1.Dra = value;
				this.X0Y0_尾25_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾25_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾25_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾25_鱗左_鱗2.Dra = value;
				this.X0Y0_尾25_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾25_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾25_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾25_鱗左_鱗3.Dra = value;
				this.X0Y0_尾25_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾25_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾25_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾25_鱗左_鱗4.Dra = value;
				this.X0Y0_尾25_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾25_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾25_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾25_鱗右_鱗1.Dra = value;
				this.X0Y0_尾25_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾25_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾25_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾25_鱗右_鱗2.Dra = value;
				this.X0Y0_尾25_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾25_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾25_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾25_鱗右_鱗3.Dra = value;
				this.X0Y0_尾25_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾25_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾25_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾25_鱗右_鱗4.Dra = value;
				this.X0Y0_尾25_鱗右_鱗4.Hit = value;
			}
		}

		public bool 尾25_表示
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

		public bool 尾24_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾24_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾24_鱗左_鱗1.Dra = value;
				this.X0Y0_尾24_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾24_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾24_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾24_鱗左_鱗2.Dra = value;
				this.X0Y0_尾24_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾24_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾24_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾24_鱗左_鱗3.Dra = value;
				this.X0Y0_尾24_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾24_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾24_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾24_鱗左_鱗4.Dra = value;
				this.X0Y0_尾24_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾24_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾24_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾24_鱗右_鱗1.Dra = value;
				this.X0Y0_尾24_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾24_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾24_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾24_鱗右_鱗2.Dra = value;
				this.X0Y0_尾24_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾24_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾24_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾24_鱗右_鱗3.Dra = value;
				this.X0Y0_尾24_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾24_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾24_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾24_鱗右_鱗4.Dra = value;
				this.X0Y0_尾24_鱗右_鱗4.Hit = value;
			}
		}

		public bool 尾24_表示
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

		public bool 尾23_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾23_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾23_鱗左_鱗1.Dra = value;
				this.X0Y0_尾23_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾23_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾23_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾23_鱗左_鱗2.Dra = value;
				this.X0Y0_尾23_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾23_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾23_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾23_鱗左_鱗3.Dra = value;
				this.X0Y0_尾23_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾23_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾23_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾23_鱗左_鱗4.Dra = value;
				this.X0Y0_尾23_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾23_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾23_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾23_鱗右_鱗1.Dra = value;
				this.X0Y0_尾23_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾23_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾23_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾23_鱗右_鱗2.Dra = value;
				this.X0Y0_尾23_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾23_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾23_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾23_鱗右_鱗3.Dra = value;
				this.X0Y0_尾23_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾23_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾23_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾23_鱗右_鱗4.Dra = value;
				this.X0Y0_尾23_鱗右_鱗4.Hit = value;
			}
		}

		public bool 尾23_表示
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

		public bool 尾22_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾22_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾22_鱗左_鱗1.Dra = value;
				this.X0Y0_尾22_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾22_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾22_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾22_鱗左_鱗2.Dra = value;
				this.X0Y0_尾22_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾22_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾22_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾22_鱗左_鱗3.Dra = value;
				this.X0Y0_尾22_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾22_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾22_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾22_鱗左_鱗4.Dra = value;
				this.X0Y0_尾22_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾22_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾22_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾22_鱗右_鱗1.Dra = value;
				this.X0Y0_尾22_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾22_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾22_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾22_鱗右_鱗2.Dra = value;
				this.X0Y0_尾22_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾22_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾22_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾22_鱗右_鱗3.Dra = value;
				this.X0Y0_尾22_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾22_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾22_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾22_鱗右_鱗4.Dra = value;
				this.X0Y0_尾22_鱗右_鱗4.Hit = value;
			}
		}

		public bool 尾22_表示
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

		public bool 尾21_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾21_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾21_鱗左_鱗1.Dra = value;
				this.X0Y0_尾21_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾21_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾21_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾21_鱗左_鱗2.Dra = value;
				this.X0Y0_尾21_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾21_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾21_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾21_鱗左_鱗3.Dra = value;
				this.X0Y0_尾21_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾21_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾21_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾21_鱗左_鱗4.Dra = value;
				this.X0Y0_尾21_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾21_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾21_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾21_鱗右_鱗1.Dra = value;
				this.X0Y0_尾21_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾21_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾21_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾21_鱗右_鱗2.Dra = value;
				this.X0Y0_尾21_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾21_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾21_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾21_鱗右_鱗3.Dra = value;
				this.X0Y0_尾21_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾21_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾21_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾21_鱗右_鱗4.Dra = value;
				this.X0Y0_尾21_鱗右_鱗4.Hit = value;
			}
		}

		public bool 尾21_表示
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

		public bool 尾20_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾20_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾20_鱗左_鱗1.Dra = value;
				this.X0Y0_尾20_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾20_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾20_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾20_鱗左_鱗2.Dra = value;
				this.X0Y0_尾20_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾20_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾20_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾20_鱗左_鱗3.Dra = value;
				this.X0Y0_尾20_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾20_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾20_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾20_鱗左_鱗4.Dra = value;
				this.X0Y0_尾20_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾20_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾20_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾20_鱗右_鱗1.Dra = value;
				this.X0Y0_尾20_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾20_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾20_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾20_鱗右_鱗2.Dra = value;
				this.X0Y0_尾20_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾20_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾20_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾20_鱗右_鱗3.Dra = value;
				this.X0Y0_尾20_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾20_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾20_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾20_鱗右_鱗4.Dra = value;
				this.X0Y0_尾20_鱗右_鱗4.Hit = value;
			}
		}

		public bool 尾20_表示
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

		public bool 尾19_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾19_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾19_鱗左_鱗1.Dra = value;
				this.X0Y0_尾19_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾19_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾19_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾19_鱗左_鱗2.Dra = value;
				this.X0Y0_尾19_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾19_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾19_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾19_鱗左_鱗3.Dra = value;
				this.X0Y0_尾19_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾19_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾19_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾19_鱗左_鱗4.Dra = value;
				this.X0Y0_尾19_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾19_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾19_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾19_鱗右_鱗1.Dra = value;
				this.X0Y0_尾19_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾19_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾19_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾19_鱗右_鱗2.Dra = value;
				this.X0Y0_尾19_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾19_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾19_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾19_鱗右_鱗3.Dra = value;
				this.X0Y0_尾19_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾19_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾19_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾19_鱗右_鱗4.Dra = value;
				this.X0Y0_尾19_鱗右_鱗4.Hit = value;
			}
		}

		public bool 尾19_表示
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

		public bool 尾18_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾18_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾18_鱗左_鱗1.Dra = value;
				this.X0Y0_尾18_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾18_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾18_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾18_鱗左_鱗2.Dra = value;
				this.X0Y0_尾18_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾18_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾18_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾18_鱗左_鱗3.Dra = value;
				this.X0Y0_尾18_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾18_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾18_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾18_鱗左_鱗4.Dra = value;
				this.X0Y0_尾18_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾18_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾18_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾18_鱗右_鱗1.Dra = value;
				this.X0Y0_尾18_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾18_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾18_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾18_鱗右_鱗2.Dra = value;
				this.X0Y0_尾18_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾18_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾18_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾18_鱗右_鱗3.Dra = value;
				this.X0Y0_尾18_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾18_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾18_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾18_鱗右_鱗4.Dra = value;
				this.X0Y0_尾18_鱗右_鱗4.Hit = value;
			}
		}

		public bool 尾18_表示
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

		public bool 尾17_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾17_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾17_鱗左_鱗1.Dra = value;
				this.X0Y0_尾17_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾17_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾17_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾17_鱗左_鱗2.Dra = value;
				this.X0Y0_尾17_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾17_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾17_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾17_鱗左_鱗3.Dra = value;
				this.X0Y0_尾17_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾17_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾17_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾17_鱗左_鱗4.Dra = value;
				this.X0Y0_尾17_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾17_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾17_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾17_鱗右_鱗1.Dra = value;
				this.X0Y0_尾17_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾17_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾17_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾17_鱗右_鱗2.Dra = value;
				this.X0Y0_尾17_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾17_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾17_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾17_鱗右_鱗3.Dra = value;
				this.X0Y0_尾17_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾17_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾17_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾17_鱗右_鱗4.Dra = value;
				this.X0Y0_尾17_鱗右_鱗4.Hit = value;
			}
		}

		public bool 尾17_表示
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

		public bool 尾16_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾16_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾16_鱗左_鱗1.Dra = value;
				this.X0Y0_尾16_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾16_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾16_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾16_鱗左_鱗2.Dra = value;
				this.X0Y0_尾16_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾16_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾16_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾16_鱗左_鱗3.Dra = value;
				this.X0Y0_尾16_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾16_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾16_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾16_鱗左_鱗4.Dra = value;
				this.X0Y0_尾16_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾16_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾16_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾16_鱗右_鱗1.Dra = value;
				this.X0Y0_尾16_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾16_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾16_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾16_鱗右_鱗2.Dra = value;
				this.X0Y0_尾16_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾16_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾16_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾16_鱗右_鱗3.Dra = value;
				this.X0Y0_尾16_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾16_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾16_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾16_鱗右_鱗4.Dra = value;
				this.X0Y0_尾16_鱗右_鱗4.Hit = value;
			}
		}

		public bool 尾16_表示
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

		public bool 尾15_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾15_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾15_鱗左_鱗1.Dra = value;
				this.X0Y0_尾15_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾15_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾15_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾15_鱗左_鱗2.Dra = value;
				this.X0Y0_尾15_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾15_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾15_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾15_鱗左_鱗3.Dra = value;
				this.X0Y0_尾15_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾15_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾15_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾15_鱗左_鱗4.Dra = value;
				this.X0Y0_尾15_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾15_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾15_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾15_鱗右_鱗1.Dra = value;
				this.X0Y0_尾15_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾15_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾15_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾15_鱗右_鱗2.Dra = value;
				this.X0Y0_尾15_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾15_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾15_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾15_鱗右_鱗3.Dra = value;
				this.X0Y0_尾15_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾15_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾15_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾15_鱗右_鱗4.Dra = value;
				this.X0Y0_尾15_鱗右_鱗4.Hit = value;
			}
		}

		public bool 尾15_表示
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

		public bool 尾14_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾14_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾14_鱗左_鱗1.Dra = value;
				this.X0Y0_尾14_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾14_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾14_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾14_鱗左_鱗2.Dra = value;
				this.X0Y0_尾14_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾14_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾14_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾14_鱗左_鱗3.Dra = value;
				this.X0Y0_尾14_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾14_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾14_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾14_鱗左_鱗4.Dra = value;
				this.X0Y0_尾14_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾14_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾14_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾14_鱗右_鱗1.Dra = value;
				this.X0Y0_尾14_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾14_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾14_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾14_鱗右_鱗2.Dra = value;
				this.X0Y0_尾14_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾14_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾14_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾14_鱗右_鱗3.Dra = value;
				this.X0Y0_尾14_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾14_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾14_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾14_鱗右_鱗4.Dra = value;
				this.X0Y0_尾14_鱗右_鱗4.Hit = value;
			}
		}

		public bool 尾14_表示
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

		public bool 尾13_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾13_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾13_鱗左_鱗1.Dra = value;
				this.X0Y0_尾13_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾13_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾13_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾13_鱗左_鱗2.Dra = value;
				this.X0Y0_尾13_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾13_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾13_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾13_鱗左_鱗3.Dra = value;
				this.X0Y0_尾13_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾13_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾13_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾13_鱗左_鱗4.Dra = value;
				this.X0Y0_尾13_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾13_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾13_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾13_鱗右_鱗1.Dra = value;
				this.X0Y0_尾13_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾13_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾13_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾13_鱗右_鱗2.Dra = value;
				this.X0Y0_尾13_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾13_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾13_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾13_鱗右_鱗3.Dra = value;
				this.X0Y0_尾13_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾13_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾13_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾13_鱗右_鱗4.Dra = value;
				this.X0Y0_尾13_鱗右_鱗4.Hit = value;
			}
		}

		public bool 尾13_表示
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

		public bool 尾12_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾12_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾12_鱗左_鱗1.Dra = value;
				this.X0Y0_尾12_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾12_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾12_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾12_鱗左_鱗2.Dra = value;
				this.X0Y0_尾12_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾12_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾12_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾12_鱗左_鱗3.Dra = value;
				this.X0Y0_尾12_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾12_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾12_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾12_鱗左_鱗4.Dra = value;
				this.X0Y0_尾12_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾12_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾12_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾12_鱗右_鱗1.Dra = value;
				this.X0Y0_尾12_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾12_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾12_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾12_鱗右_鱗2.Dra = value;
				this.X0Y0_尾12_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾12_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾12_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾12_鱗右_鱗3.Dra = value;
				this.X0Y0_尾12_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾12_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾12_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾12_鱗右_鱗4.Dra = value;
				this.X0Y0_尾12_鱗右_鱗4.Hit = value;
			}
		}

		public bool 尾12_表示
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

		public bool 尾11_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾11_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾11_鱗左_鱗1.Dra = value;
				this.X0Y0_尾11_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾11_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾11_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾11_鱗左_鱗2.Dra = value;
				this.X0Y0_尾11_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾11_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾11_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾11_鱗左_鱗3.Dra = value;
				this.X0Y0_尾11_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾11_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾11_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾11_鱗左_鱗4.Dra = value;
				this.X0Y0_尾11_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾11_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾11_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾11_鱗右_鱗1.Dra = value;
				this.X0Y0_尾11_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾11_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾11_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾11_鱗右_鱗2.Dra = value;
				this.X0Y0_尾11_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾11_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾11_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾11_鱗右_鱗3.Dra = value;
				this.X0Y0_尾11_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾11_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾11_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾11_鱗右_鱗4.Dra = value;
				this.X0Y0_尾11_鱗右_鱗4.Hit = value;
			}
		}

		public bool 尾11_表示
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

		public bool 尾10_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾10_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾10_鱗左_鱗1.Dra = value;
				this.X0Y0_尾10_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾10_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾10_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾10_鱗左_鱗2.Dra = value;
				this.X0Y0_尾10_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾10_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾10_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾10_鱗左_鱗3.Dra = value;
				this.X0Y0_尾10_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾10_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾10_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾10_鱗左_鱗4.Dra = value;
				this.X0Y0_尾10_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾10_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾10_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾10_鱗右_鱗1.Dra = value;
				this.X0Y0_尾10_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾10_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾10_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾10_鱗右_鱗2.Dra = value;
				this.X0Y0_尾10_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾10_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾10_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾10_鱗右_鱗3.Dra = value;
				this.X0Y0_尾10_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾10_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾10_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾10_鱗右_鱗4.Dra = value;
				this.X0Y0_尾10_鱗右_鱗4.Hit = value;
			}
		}

		public bool 尾10_表示
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

		public bool 尾9_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾9_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾9_鱗左_鱗1.Dra = value;
				this.X0Y0_尾9_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾9_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾9_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾9_鱗左_鱗2.Dra = value;
				this.X0Y0_尾9_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾9_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾9_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾9_鱗左_鱗3.Dra = value;
				this.X0Y0_尾9_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾9_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾9_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾9_鱗左_鱗4.Dra = value;
				this.X0Y0_尾9_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾9_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾9_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾9_鱗右_鱗1.Dra = value;
				this.X0Y0_尾9_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾9_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾9_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾9_鱗右_鱗2.Dra = value;
				this.X0Y0_尾9_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾9_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾9_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾9_鱗右_鱗3.Dra = value;
				this.X0Y0_尾9_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾9_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾9_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾9_鱗右_鱗4.Dra = value;
				this.X0Y0_尾9_鱗右_鱗4.Hit = value;
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

		public bool 尾8_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾8_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾8_鱗左_鱗1.Dra = value;
				this.X0Y0_尾8_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾8_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾8_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾8_鱗左_鱗2.Dra = value;
				this.X0Y0_尾8_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾8_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾8_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾8_鱗左_鱗3.Dra = value;
				this.X0Y0_尾8_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾8_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾8_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾8_鱗左_鱗4.Dra = value;
				this.X0Y0_尾8_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾8_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾8_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾8_鱗右_鱗1.Dra = value;
				this.X0Y0_尾8_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾8_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾8_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾8_鱗右_鱗2.Dra = value;
				this.X0Y0_尾8_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾8_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾8_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾8_鱗右_鱗3.Dra = value;
				this.X0Y0_尾8_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾8_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾8_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾8_鱗右_鱗4.Dra = value;
				this.X0Y0_尾8_鱗右_鱗4.Hit = value;
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

		public bool 尾7_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾7_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾7_鱗左_鱗1.Dra = value;
				this.X0Y0_尾7_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾7_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾7_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾7_鱗左_鱗2.Dra = value;
				this.X0Y0_尾7_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾7_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾7_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾7_鱗左_鱗3.Dra = value;
				this.X0Y0_尾7_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾7_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾7_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾7_鱗左_鱗4.Dra = value;
				this.X0Y0_尾7_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾7_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾7_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾7_鱗右_鱗1.Dra = value;
				this.X0Y0_尾7_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾7_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾7_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾7_鱗右_鱗2.Dra = value;
				this.X0Y0_尾7_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾7_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾7_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾7_鱗右_鱗3.Dra = value;
				this.X0Y0_尾7_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾7_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾7_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾7_鱗右_鱗4.Dra = value;
				this.X0Y0_尾7_鱗右_鱗4.Hit = value;
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

		public bool 尾6_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾6_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾6_鱗左_鱗1.Dra = value;
				this.X0Y0_尾6_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾6_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾6_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾6_鱗左_鱗2.Dra = value;
				this.X0Y0_尾6_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾6_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾6_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾6_鱗左_鱗3.Dra = value;
				this.X0Y0_尾6_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾6_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾6_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾6_鱗左_鱗4.Dra = value;
				this.X0Y0_尾6_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾6_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾6_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾6_鱗右_鱗1.Dra = value;
				this.X0Y0_尾6_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾6_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾6_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾6_鱗右_鱗2.Dra = value;
				this.X0Y0_尾6_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾6_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾6_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾6_鱗右_鱗3.Dra = value;
				this.X0Y0_尾6_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾6_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾6_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾6_鱗右_鱗4.Dra = value;
				this.X0Y0_尾6_鱗右_鱗4.Hit = value;
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

		public bool 尾5_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾5_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾5_鱗左_鱗1.Dra = value;
				this.X0Y0_尾5_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾5_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾5_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾5_鱗左_鱗2.Dra = value;
				this.X0Y0_尾5_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾5_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾5_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾5_鱗左_鱗3.Dra = value;
				this.X0Y0_尾5_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾5_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾5_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾5_鱗左_鱗4.Dra = value;
				this.X0Y0_尾5_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾5_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾5_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾5_鱗右_鱗1.Dra = value;
				this.X0Y0_尾5_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾5_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾5_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾5_鱗右_鱗2.Dra = value;
				this.X0Y0_尾5_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾5_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾5_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾5_鱗右_鱗3.Dra = value;
				this.X0Y0_尾5_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾5_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾5_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾5_鱗右_鱗4.Dra = value;
				this.X0Y0_尾5_鱗右_鱗4.Hit = value;
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

		public bool 尾4_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾4_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾4_鱗左_鱗1.Dra = value;
				this.X0Y0_尾4_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾4_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾4_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾4_鱗左_鱗2.Dra = value;
				this.X0Y0_尾4_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾4_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾4_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾4_鱗左_鱗3.Dra = value;
				this.X0Y0_尾4_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾4_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾4_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾4_鱗左_鱗4.Dra = value;
				this.X0Y0_尾4_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾4_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾4_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾4_鱗右_鱗1.Dra = value;
				this.X0Y0_尾4_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾4_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾4_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾4_鱗右_鱗2.Dra = value;
				this.X0Y0_尾4_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾4_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾4_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾4_鱗右_鱗3.Dra = value;
				this.X0Y0_尾4_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾4_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾4_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾4_鱗右_鱗4.Dra = value;
				this.X0Y0_尾4_鱗右_鱗4.Hit = value;
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

		public bool 輪_革_表示
		{
			get
			{
				return this.X0Y0_輪_革.Dra;
			}
			set
			{
				this.X0Y0_輪_革.Dra = value;
				this.X0Y0_輪_革.Hit = value;
			}
		}

		public bool 輪_金具1_表示
		{
			get
			{
				return this.X0Y0_輪_金具1.Dra;
			}
			set
			{
				this.X0Y0_輪_金具1.Dra = value;
				this.X0Y0_輪_金具1.Hit = value;
			}
		}

		public bool 輪_金具2_表示
		{
			get
			{
				return this.X0Y0_輪_金具2.Dra;
			}
			set
			{
				this.X0Y0_輪_金具2.Dra = value;
				this.X0Y0_輪_金具2.Hit = value;
			}
		}

		public bool 輪_金具3_表示
		{
			get
			{
				return this.X0Y0_輪_金具3.Dra;
			}
			set
			{
				this.X0Y0_輪_金具3.Dra = value;
				this.X0Y0_輪_金具3.Hit = value;
			}
		}

		public bool 輪_金具左_表示
		{
			get
			{
				return this.X0Y0_輪_金具左.Dra;
			}
			set
			{
				this.X0Y0_輪_金具左.Dra = value;
				this.X0Y0_輪_金具左.Hit = value;
			}
		}

		public bool 輪_金具右_表示
		{
			get
			{
				return this.X0Y0_輪_金具右.Dra;
			}
			set
			{
				this.X0Y0_輪_金具右.Dra = value;
				this.X0Y0_輪_金具右.Hit = value;
			}
		}

		public bool 尾3_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾3_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾3_鱗左_鱗1.Dra = value;
				this.X0Y0_尾3_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾3_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾3_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾3_鱗左_鱗2.Dra = value;
				this.X0Y0_尾3_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾3_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾3_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾3_鱗左_鱗3.Dra = value;
				this.X0Y0_尾3_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾3_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾3_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾3_鱗左_鱗4.Dra = value;
				this.X0Y0_尾3_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾3_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾3_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾3_鱗右_鱗1.Dra = value;
				this.X0Y0_尾3_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾3_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾3_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾3_鱗右_鱗2.Dra = value;
				this.X0Y0_尾3_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾3_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾3_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾3_鱗右_鱗3.Dra = value;
				this.X0Y0_尾3_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾3_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾3_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾3_鱗右_鱗4.Dra = value;
				this.X0Y0_尾3_鱗右_鱗4.Hit = value;
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

		public bool 尾2_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾2_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾2_鱗左_鱗1.Dra = value;
				this.X0Y0_尾2_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾2_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾2_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾2_鱗左_鱗2.Dra = value;
				this.X0Y0_尾2_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾2_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾2_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾2_鱗左_鱗3.Dra = value;
				this.X0Y0_尾2_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾2_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾2_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾2_鱗左_鱗4.Dra = value;
				this.X0Y0_尾2_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾2_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾2_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾2_鱗右_鱗1.Dra = value;
				this.X0Y0_尾2_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾2_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾2_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾2_鱗右_鱗2.Dra = value;
				this.X0Y0_尾2_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾2_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾2_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾2_鱗右_鱗3.Dra = value;
				this.X0Y0_尾2_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾2_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾2_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾2_鱗右_鱗4.Dra = value;
				this.X0Y0_尾2_鱗右_鱗4.Hit = value;
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

		public bool 尾1_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾1_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾1_鱗左_鱗1.Dra = value;
				this.X0Y0_尾1_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾1_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾1_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾1_鱗左_鱗2.Dra = value;
				this.X0Y0_尾1_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾1_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾1_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾1_鱗左_鱗3.Dra = value;
				this.X0Y0_尾1_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾1_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾1_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾1_鱗左_鱗4.Dra = value;
				this.X0Y0_尾1_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾1_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾1_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾1_鱗右_鱗1.Dra = value;
				this.X0Y0_尾1_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾1_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾1_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾1_鱗右_鱗2.Dra = value;
				this.X0Y0_尾1_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾1_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾1_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾1_鱗右_鱗3.Dra = value;
				this.X0Y0_尾1_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾1_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾1_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾1_鱗右_鱗4.Dra = value;
				this.X0Y0_尾1_鱗右_鱗4.Hit = value;
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

		public bool 尾0_鱗左_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾0_鱗左_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾0_鱗左_鱗1.Dra = value;
				this.X0Y0_尾0_鱗左_鱗1.Hit = value;
			}
		}

		public bool 尾0_鱗左_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾0_鱗左_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾0_鱗左_鱗2.Dra = value;
				this.X0Y0_尾0_鱗左_鱗2.Hit = value;
			}
		}

		public bool 尾0_鱗左_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾0_鱗左_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾0_鱗左_鱗3.Dra = value;
				this.X0Y0_尾0_鱗左_鱗3.Hit = value;
			}
		}

		public bool 尾0_鱗左_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾0_鱗左_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾0_鱗左_鱗4.Dra = value;
				this.X0Y0_尾0_鱗左_鱗4.Hit = value;
			}
		}

		public bool 尾0_鱗右_鱗1_表示
		{
			get
			{
				return this.X0Y0_尾0_鱗右_鱗1.Dra;
			}
			set
			{
				this.X0Y0_尾0_鱗右_鱗1.Dra = value;
				this.X0Y0_尾0_鱗右_鱗1.Hit = value;
			}
		}

		public bool 尾0_鱗右_鱗2_表示
		{
			get
			{
				return this.X0Y0_尾0_鱗右_鱗2.Dra;
			}
			set
			{
				this.X0Y0_尾0_鱗右_鱗2.Dra = value;
				this.X0Y0_尾0_鱗右_鱗2.Hit = value;
			}
		}

		public bool 尾0_鱗右_鱗3_表示
		{
			get
			{
				return this.X0Y0_尾0_鱗右_鱗3.Dra;
			}
			set
			{
				this.X0Y0_尾0_鱗右_鱗3.Dra = value;
				this.X0Y0_尾0_鱗右_鱗3.Hit = value;
			}
		}

		public bool 尾0_鱗右_鱗4_表示
		{
			get
			{
				return this.X0Y0_尾0_鱗右_鱗4.Dra;
			}
			set
			{
				this.X0Y0_尾0_鱗右_鱗4.Dra = value;
				this.X0Y0_尾0_鱗右_鱗4.Hit = value;
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

		public bool 輪表示
		{
			get
			{
				return this.輪_革_表示;
			}
			set
			{
				this.輪_革_表示 = value;
				this.輪_金具1_表示 = value;
				this.輪_金具2_表示 = value;
				this.輪_金具3_表示 = value;
				this.輪_金具左_表示 = value;
				this.輪_金具右_表示 = value;
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

		public bool 尾先表示
		{
			get
			{
				return this.尾33_鱗左_鱗1_表示;
			}
			set
			{
				this.尾33_鱗左_鱗1_表示 = value;
				this.尾33_鱗左_鱗3_表示 = value;
				this.尾33_鱗右_鱗1_表示 = value;
				this.尾33_鱗右_鱗3_表示 = value;
				this.尾33_表示 = value;
				this.尾32_鱗左_鱗1_表示 = value;
				this.尾32_鱗左_鱗2_表示 = value;
				this.尾32_鱗左_鱗3_表示 = value;
				this.尾32_鱗左_鱗4_表示 = value;
				this.尾32_鱗右_鱗1_表示 = value;
				this.尾32_鱗右_鱗2_表示 = value;
				this.尾32_鱗右_鱗3_表示 = value;
				this.尾32_鱗右_鱗4_表示 = value;
				this.尾32_表示 = value;
				this.尾31_鱗左_鱗1_表示 = value;
				this.尾31_鱗左_鱗2_表示 = value;
				this.尾31_鱗左_鱗3_表示 = value;
				this.尾31_鱗左_鱗4_表示 = value;
				this.尾31_鱗右_鱗1_表示 = value;
				this.尾31_鱗右_鱗2_表示 = value;
				this.尾31_鱗右_鱗3_表示 = value;
				this.尾31_鱗右_鱗4_表示 = value;
				this.尾31_表示 = value;
				this.尾30_鱗左_鱗1_表示 = value;
				this.尾30_鱗左_鱗2_表示 = value;
				this.尾30_鱗左_鱗3_表示 = value;
				this.尾30_鱗左_鱗4_表示 = value;
				this.尾30_鱗右_鱗1_表示 = value;
				this.尾30_鱗右_鱗2_表示 = value;
				this.尾30_鱗右_鱗3_表示 = value;
				this.尾30_鱗右_鱗4_表示 = value;
				this.尾30_表示 = value;
				this.尾29_鱗左_鱗1_表示 = value;
				this.尾29_鱗左_鱗2_表示 = value;
				this.尾29_鱗左_鱗3_表示 = value;
				this.尾29_鱗左_鱗4_表示 = value;
				this.尾29_鱗右_鱗1_表示 = value;
				this.尾29_鱗右_鱗2_表示 = value;
				this.尾29_鱗右_鱗3_表示 = value;
				this.尾29_鱗右_鱗4_表示 = value;
				this.尾29_表示 = value;
				this.尾28_鱗左_鱗1_表示 = value;
				this.尾28_鱗左_鱗2_表示 = value;
				this.尾28_鱗左_鱗3_表示 = value;
				this.尾28_鱗左_鱗4_表示 = value;
				this.尾28_鱗右_鱗1_表示 = value;
				this.尾28_鱗右_鱗2_表示 = value;
				this.尾28_鱗右_鱗3_表示 = value;
				this.尾28_鱗右_鱗4_表示 = value;
				this.尾28_表示 = value;
				this.尾27_鱗左_鱗1_表示 = value;
				this.尾27_鱗左_鱗2_表示 = value;
				this.尾27_鱗左_鱗3_表示 = value;
				this.尾27_鱗左_鱗4_表示 = value;
				this.尾27_鱗右_鱗1_表示 = value;
				this.尾27_鱗右_鱗2_表示 = value;
				this.尾27_鱗右_鱗3_表示 = value;
				this.尾27_鱗右_鱗4_表示 = value;
				this.尾27_表示 = value;
				this.尾26_鱗左_鱗1_表示 = value;
				this.尾26_鱗左_鱗2_表示 = value;
				this.尾26_鱗左_鱗3_表示 = value;
				this.尾26_鱗左_鱗4_表示 = value;
				this.尾26_鱗右_鱗1_表示 = value;
				this.尾26_鱗右_鱗2_表示 = value;
				this.尾26_鱗右_鱗3_表示 = value;
				this.尾26_鱗右_鱗4_表示 = value;
				this.尾26_表示 = value;
				this.尾25_鱗左_鱗1_表示 = value;
				this.尾25_鱗左_鱗2_表示 = value;
				this.尾25_鱗左_鱗3_表示 = value;
				this.尾25_鱗左_鱗4_表示 = value;
				this.尾25_鱗右_鱗1_表示 = value;
				this.尾25_鱗右_鱗2_表示 = value;
				this.尾25_鱗右_鱗3_表示 = value;
				this.尾25_鱗右_鱗4_表示 = value;
				this.尾25_表示 = value;
				this.尾24_鱗左_鱗1_表示 = value;
				this.尾24_鱗左_鱗2_表示 = value;
				this.尾24_鱗左_鱗3_表示 = value;
				this.尾24_鱗左_鱗4_表示 = value;
				this.尾24_鱗右_鱗1_表示 = value;
				this.尾24_鱗右_鱗2_表示 = value;
				this.尾24_鱗右_鱗3_表示 = value;
				this.尾24_鱗右_鱗4_表示 = value;
				this.尾24_表示 = value;
				this.尾23_鱗左_鱗1_表示 = value;
				this.尾23_鱗左_鱗2_表示 = value;
				this.尾23_鱗左_鱗3_表示 = value;
				this.尾23_鱗左_鱗4_表示 = value;
				this.尾23_鱗右_鱗1_表示 = value;
				this.尾23_鱗右_鱗2_表示 = value;
				this.尾23_鱗右_鱗3_表示 = value;
				this.尾23_鱗右_鱗4_表示 = value;
				this.尾23_表示 = value;
				this.尾22_鱗左_鱗1_表示 = value;
				this.尾22_鱗左_鱗2_表示 = value;
				this.尾22_鱗左_鱗3_表示 = value;
				this.尾22_鱗左_鱗4_表示 = value;
				this.尾22_鱗右_鱗1_表示 = value;
				this.尾22_鱗右_鱗2_表示 = value;
				this.尾22_鱗右_鱗3_表示 = value;
				this.尾22_鱗右_鱗4_表示 = value;
				this.尾22_表示 = value;
				this.尾21_鱗左_鱗1_表示 = value;
				this.尾21_鱗左_鱗2_表示 = value;
				this.尾21_鱗左_鱗3_表示 = value;
				this.尾21_鱗左_鱗4_表示 = value;
				this.尾21_鱗右_鱗1_表示 = value;
				this.尾21_鱗右_鱗2_表示 = value;
				this.尾21_鱗右_鱗3_表示 = value;
				this.尾21_鱗右_鱗4_表示 = value;
				this.尾21_表示 = value;
				this.尾20_鱗左_鱗1_表示 = value;
				this.尾20_鱗左_鱗2_表示 = value;
				this.尾20_鱗左_鱗3_表示 = value;
				this.尾20_鱗左_鱗4_表示 = value;
				this.尾20_鱗右_鱗1_表示 = value;
				this.尾20_鱗右_鱗2_表示 = value;
				this.尾20_鱗右_鱗3_表示 = value;
				this.尾20_鱗右_鱗4_表示 = value;
				this.尾20_表示 = value;
				this.尾19_鱗左_鱗1_表示 = value;
				this.尾19_鱗左_鱗2_表示 = value;
				this.尾19_鱗左_鱗3_表示 = value;
				this.尾19_鱗左_鱗4_表示 = value;
				this.尾19_鱗右_鱗1_表示 = value;
				this.尾19_鱗右_鱗2_表示 = value;
				this.尾19_鱗右_鱗3_表示 = value;
				this.尾19_鱗右_鱗4_表示 = value;
				this.尾19_表示 = value;
				this.尾18_鱗左_鱗1_表示 = value;
				this.尾18_鱗左_鱗2_表示 = value;
				this.尾18_鱗左_鱗3_表示 = value;
				this.尾18_鱗左_鱗4_表示 = value;
				this.尾18_鱗右_鱗1_表示 = value;
				this.尾18_鱗右_鱗2_表示 = value;
				this.尾18_鱗右_鱗3_表示 = value;
				this.尾18_鱗右_鱗4_表示 = value;
				this.尾18_表示 = value;
				this.尾17_鱗左_鱗1_表示 = value;
				this.尾17_鱗左_鱗2_表示 = value;
				this.尾17_鱗左_鱗3_表示 = value;
				this.尾17_鱗左_鱗4_表示 = value;
				this.尾17_鱗右_鱗1_表示 = value;
				this.尾17_鱗右_鱗2_表示 = value;
				this.尾17_鱗右_鱗3_表示 = value;
				this.尾17_鱗右_鱗4_表示 = value;
				this.尾17_表示 = value;
				this.尾16_鱗左_鱗1_表示 = value;
				this.尾16_鱗左_鱗2_表示 = value;
				this.尾16_鱗左_鱗3_表示 = value;
				this.尾16_鱗左_鱗4_表示 = value;
				this.尾16_鱗右_鱗1_表示 = value;
				this.尾16_鱗右_鱗2_表示 = value;
				this.尾16_鱗右_鱗3_表示 = value;
				this.尾16_鱗右_鱗4_表示 = value;
				this.尾16_表示 = value;
				this.尾15_鱗左_鱗1_表示 = value;
				this.尾15_鱗左_鱗2_表示 = value;
				this.尾15_鱗左_鱗3_表示 = value;
				this.尾15_鱗左_鱗4_表示 = value;
				this.尾15_鱗右_鱗1_表示 = value;
				this.尾15_鱗右_鱗2_表示 = value;
				this.尾15_鱗右_鱗3_表示 = value;
				this.尾15_鱗右_鱗4_表示 = value;
				this.尾15_表示 = value;
				this.尾14_鱗左_鱗1_表示 = value;
				this.尾14_鱗左_鱗2_表示 = value;
				this.尾14_鱗左_鱗3_表示 = value;
				this.尾14_鱗左_鱗4_表示 = value;
				this.尾14_鱗右_鱗1_表示 = value;
				this.尾14_鱗右_鱗2_表示 = value;
				this.尾14_鱗右_鱗3_表示 = value;
				this.尾14_鱗右_鱗4_表示 = value;
				this.尾14_表示 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.尾33_鱗左_鱗1_表示;
			}
			set
			{
				this.尾33_鱗左_鱗1_表示 = value;
				this.尾33_鱗左_鱗3_表示 = value;
				this.尾33_鱗右_鱗1_表示 = value;
				this.尾33_鱗右_鱗3_表示 = value;
				this.尾33_表示 = value;
				this.尾32_鱗左_鱗1_表示 = value;
				this.尾32_鱗左_鱗2_表示 = value;
				this.尾32_鱗左_鱗3_表示 = value;
				this.尾32_鱗左_鱗4_表示 = value;
				this.尾32_鱗右_鱗1_表示 = value;
				this.尾32_鱗右_鱗2_表示 = value;
				this.尾32_鱗右_鱗3_表示 = value;
				this.尾32_鱗右_鱗4_表示 = value;
				this.尾32_表示 = value;
				this.尾31_鱗左_鱗1_表示 = value;
				this.尾31_鱗左_鱗2_表示 = value;
				this.尾31_鱗左_鱗3_表示 = value;
				this.尾31_鱗左_鱗4_表示 = value;
				this.尾31_鱗右_鱗1_表示 = value;
				this.尾31_鱗右_鱗2_表示 = value;
				this.尾31_鱗右_鱗3_表示 = value;
				this.尾31_鱗右_鱗4_表示 = value;
				this.尾31_表示 = value;
				this.尾30_鱗左_鱗1_表示 = value;
				this.尾30_鱗左_鱗2_表示 = value;
				this.尾30_鱗左_鱗3_表示 = value;
				this.尾30_鱗左_鱗4_表示 = value;
				this.尾30_鱗右_鱗1_表示 = value;
				this.尾30_鱗右_鱗2_表示 = value;
				this.尾30_鱗右_鱗3_表示 = value;
				this.尾30_鱗右_鱗4_表示 = value;
				this.尾30_表示 = value;
				this.尾29_鱗左_鱗1_表示 = value;
				this.尾29_鱗左_鱗2_表示 = value;
				this.尾29_鱗左_鱗3_表示 = value;
				this.尾29_鱗左_鱗4_表示 = value;
				this.尾29_鱗右_鱗1_表示 = value;
				this.尾29_鱗右_鱗2_表示 = value;
				this.尾29_鱗右_鱗3_表示 = value;
				this.尾29_鱗右_鱗4_表示 = value;
				this.尾29_表示 = value;
				this.尾28_鱗左_鱗1_表示 = value;
				this.尾28_鱗左_鱗2_表示 = value;
				this.尾28_鱗左_鱗3_表示 = value;
				this.尾28_鱗左_鱗4_表示 = value;
				this.尾28_鱗右_鱗1_表示 = value;
				this.尾28_鱗右_鱗2_表示 = value;
				this.尾28_鱗右_鱗3_表示 = value;
				this.尾28_鱗右_鱗4_表示 = value;
				this.尾28_表示 = value;
				this.尾27_鱗左_鱗1_表示 = value;
				this.尾27_鱗左_鱗2_表示 = value;
				this.尾27_鱗左_鱗3_表示 = value;
				this.尾27_鱗左_鱗4_表示 = value;
				this.尾27_鱗右_鱗1_表示 = value;
				this.尾27_鱗右_鱗2_表示 = value;
				this.尾27_鱗右_鱗3_表示 = value;
				this.尾27_鱗右_鱗4_表示 = value;
				this.尾27_表示 = value;
				this.尾26_鱗左_鱗1_表示 = value;
				this.尾26_鱗左_鱗2_表示 = value;
				this.尾26_鱗左_鱗3_表示 = value;
				this.尾26_鱗左_鱗4_表示 = value;
				this.尾26_鱗右_鱗1_表示 = value;
				this.尾26_鱗右_鱗2_表示 = value;
				this.尾26_鱗右_鱗3_表示 = value;
				this.尾26_鱗右_鱗4_表示 = value;
				this.尾26_表示 = value;
				this.尾25_鱗左_鱗1_表示 = value;
				this.尾25_鱗左_鱗2_表示 = value;
				this.尾25_鱗左_鱗3_表示 = value;
				this.尾25_鱗左_鱗4_表示 = value;
				this.尾25_鱗右_鱗1_表示 = value;
				this.尾25_鱗右_鱗2_表示 = value;
				this.尾25_鱗右_鱗3_表示 = value;
				this.尾25_鱗右_鱗4_表示 = value;
				this.尾25_表示 = value;
				this.尾24_鱗左_鱗1_表示 = value;
				this.尾24_鱗左_鱗2_表示 = value;
				this.尾24_鱗左_鱗3_表示 = value;
				this.尾24_鱗左_鱗4_表示 = value;
				this.尾24_鱗右_鱗1_表示 = value;
				this.尾24_鱗右_鱗2_表示 = value;
				this.尾24_鱗右_鱗3_表示 = value;
				this.尾24_鱗右_鱗4_表示 = value;
				this.尾24_表示 = value;
				this.尾23_鱗左_鱗1_表示 = value;
				this.尾23_鱗左_鱗2_表示 = value;
				this.尾23_鱗左_鱗3_表示 = value;
				this.尾23_鱗左_鱗4_表示 = value;
				this.尾23_鱗右_鱗1_表示 = value;
				this.尾23_鱗右_鱗2_表示 = value;
				this.尾23_鱗右_鱗3_表示 = value;
				this.尾23_鱗右_鱗4_表示 = value;
				this.尾23_表示 = value;
				this.尾22_鱗左_鱗1_表示 = value;
				this.尾22_鱗左_鱗2_表示 = value;
				this.尾22_鱗左_鱗3_表示 = value;
				this.尾22_鱗左_鱗4_表示 = value;
				this.尾22_鱗右_鱗1_表示 = value;
				this.尾22_鱗右_鱗2_表示 = value;
				this.尾22_鱗右_鱗3_表示 = value;
				this.尾22_鱗右_鱗4_表示 = value;
				this.尾22_表示 = value;
				this.尾21_鱗左_鱗1_表示 = value;
				this.尾21_鱗左_鱗2_表示 = value;
				this.尾21_鱗左_鱗3_表示 = value;
				this.尾21_鱗左_鱗4_表示 = value;
				this.尾21_鱗右_鱗1_表示 = value;
				this.尾21_鱗右_鱗2_表示 = value;
				this.尾21_鱗右_鱗3_表示 = value;
				this.尾21_鱗右_鱗4_表示 = value;
				this.尾21_表示 = value;
				this.尾20_鱗左_鱗1_表示 = value;
				this.尾20_鱗左_鱗2_表示 = value;
				this.尾20_鱗左_鱗3_表示 = value;
				this.尾20_鱗左_鱗4_表示 = value;
				this.尾20_鱗右_鱗1_表示 = value;
				this.尾20_鱗右_鱗2_表示 = value;
				this.尾20_鱗右_鱗3_表示 = value;
				this.尾20_鱗右_鱗4_表示 = value;
				this.尾20_表示 = value;
				this.尾19_鱗左_鱗1_表示 = value;
				this.尾19_鱗左_鱗2_表示 = value;
				this.尾19_鱗左_鱗3_表示 = value;
				this.尾19_鱗左_鱗4_表示 = value;
				this.尾19_鱗右_鱗1_表示 = value;
				this.尾19_鱗右_鱗2_表示 = value;
				this.尾19_鱗右_鱗3_表示 = value;
				this.尾19_鱗右_鱗4_表示 = value;
				this.尾19_表示 = value;
				this.尾18_鱗左_鱗1_表示 = value;
				this.尾18_鱗左_鱗2_表示 = value;
				this.尾18_鱗左_鱗3_表示 = value;
				this.尾18_鱗左_鱗4_表示 = value;
				this.尾18_鱗右_鱗1_表示 = value;
				this.尾18_鱗右_鱗2_表示 = value;
				this.尾18_鱗右_鱗3_表示 = value;
				this.尾18_鱗右_鱗4_表示 = value;
				this.尾18_表示 = value;
				this.尾17_鱗左_鱗1_表示 = value;
				this.尾17_鱗左_鱗2_表示 = value;
				this.尾17_鱗左_鱗3_表示 = value;
				this.尾17_鱗左_鱗4_表示 = value;
				this.尾17_鱗右_鱗1_表示 = value;
				this.尾17_鱗右_鱗2_表示 = value;
				this.尾17_鱗右_鱗3_表示 = value;
				this.尾17_鱗右_鱗4_表示 = value;
				this.尾17_表示 = value;
				this.尾16_鱗左_鱗1_表示 = value;
				this.尾16_鱗左_鱗2_表示 = value;
				this.尾16_鱗左_鱗3_表示 = value;
				this.尾16_鱗左_鱗4_表示 = value;
				this.尾16_鱗右_鱗1_表示 = value;
				this.尾16_鱗右_鱗2_表示 = value;
				this.尾16_鱗右_鱗3_表示 = value;
				this.尾16_鱗右_鱗4_表示 = value;
				this.尾16_表示 = value;
				this.尾15_鱗左_鱗1_表示 = value;
				this.尾15_鱗左_鱗2_表示 = value;
				this.尾15_鱗左_鱗3_表示 = value;
				this.尾15_鱗左_鱗4_表示 = value;
				this.尾15_鱗右_鱗1_表示 = value;
				this.尾15_鱗右_鱗2_表示 = value;
				this.尾15_鱗右_鱗3_表示 = value;
				this.尾15_鱗右_鱗4_表示 = value;
				this.尾15_表示 = value;
				this.尾14_鱗左_鱗1_表示 = value;
				this.尾14_鱗左_鱗2_表示 = value;
				this.尾14_鱗左_鱗3_表示 = value;
				this.尾14_鱗左_鱗4_表示 = value;
				this.尾14_鱗右_鱗1_表示 = value;
				this.尾14_鱗右_鱗2_表示 = value;
				this.尾14_鱗右_鱗3_表示 = value;
				this.尾14_鱗右_鱗4_表示 = value;
				this.尾14_表示 = value;
				this.尾13_鱗左_鱗1_表示 = value;
				this.尾13_鱗左_鱗2_表示 = value;
				this.尾13_鱗左_鱗3_表示 = value;
				this.尾13_鱗左_鱗4_表示 = value;
				this.尾13_鱗右_鱗1_表示 = value;
				this.尾13_鱗右_鱗2_表示 = value;
				this.尾13_鱗右_鱗3_表示 = value;
				this.尾13_鱗右_鱗4_表示 = value;
				this.尾13_表示 = value;
				this.尾12_鱗左_鱗1_表示 = value;
				this.尾12_鱗左_鱗2_表示 = value;
				this.尾12_鱗左_鱗3_表示 = value;
				this.尾12_鱗左_鱗4_表示 = value;
				this.尾12_鱗右_鱗1_表示 = value;
				this.尾12_鱗右_鱗2_表示 = value;
				this.尾12_鱗右_鱗3_表示 = value;
				this.尾12_鱗右_鱗4_表示 = value;
				this.尾12_表示 = value;
				this.尾11_鱗左_鱗1_表示 = value;
				this.尾11_鱗左_鱗2_表示 = value;
				this.尾11_鱗左_鱗3_表示 = value;
				this.尾11_鱗左_鱗4_表示 = value;
				this.尾11_鱗右_鱗1_表示 = value;
				this.尾11_鱗右_鱗2_表示 = value;
				this.尾11_鱗右_鱗3_表示 = value;
				this.尾11_鱗右_鱗4_表示 = value;
				this.尾11_表示 = value;
				this.尾10_鱗左_鱗1_表示 = value;
				this.尾10_鱗左_鱗2_表示 = value;
				this.尾10_鱗左_鱗3_表示 = value;
				this.尾10_鱗左_鱗4_表示 = value;
				this.尾10_鱗右_鱗1_表示 = value;
				this.尾10_鱗右_鱗2_表示 = value;
				this.尾10_鱗右_鱗3_表示 = value;
				this.尾10_鱗右_鱗4_表示 = value;
				this.尾10_表示 = value;
				this.尾9_鱗左_鱗1_表示 = value;
				this.尾9_鱗左_鱗2_表示 = value;
				this.尾9_鱗左_鱗3_表示 = value;
				this.尾9_鱗左_鱗4_表示 = value;
				this.尾9_鱗右_鱗1_表示 = value;
				this.尾9_鱗右_鱗2_表示 = value;
				this.尾9_鱗右_鱗3_表示 = value;
				this.尾9_鱗右_鱗4_表示 = value;
				this.尾9_表示 = value;
				this.尾8_鱗左_鱗1_表示 = value;
				this.尾8_鱗左_鱗2_表示 = value;
				this.尾8_鱗左_鱗3_表示 = value;
				this.尾8_鱗左_鱗4_表示 = value;
				this.尾8_鱗右_鱗1_表示 = value;
				this.尾8_鱗右_鱗2_表示 = value;
				this.尾8_鱗右_鱗3_表示 = value;
				this.尾8_鱗右_鱗4_表示 = value;
				this.尾8_表示 = value;
				this.尾7_鱗左_鱗1_表示 = value;
				this.尾7_鱗左_鱗2_表示 = value;
				this.尾7_鱗左_鱗3_表示 = value;
				this.尾7_鱗左_鱗4_表示 = value;
				this.尾7_鱗右_鱗1_表示 = value;
				this.尾7_鱗右_鱗2_表示 = value;
				this.尾7_鱗右_鱗3_表示 = value;
				this.尾7_鱗右_鱗4_表示 = value;
				this.尾7_表示 = value;
				this.尾6_鱗左_鱗1_表示 = value;
				this.尾6_鱗左_鱗2_表示 = value;
				this.尾6_鱗左_鱗3_表示 = value;
				this.尾6_鱗左_鱗4_表示 = value;
				this.尾6_鱗右_鱗1_表示 = value;
				this.尾6_鱗右_鱗2_表示 = value;
				this.尾6_鱗右_鱗3_表示 = value;
				this.尾6_鱗右_鱗4_表示 = value;
				this.尾6_表示 = value;
				this.尾5_鱗左_鱗1_表示 = value;
				this.尾5_鱗左_鱗2_表示 = value;
				this.尾5_鱗左_鱗3_表示 = value;
				this.尾5_鱗左_鱗4_表示 = value;
				this.尾5_鱗右_鱗1_表示 = value;
				this.尾5_鱗右_鱗2_表示 = value;
				this.尾5_鱗右_鱗3_表示 = value;
				this.尾5_鱗右_鱗4_表示 = value;
				this.尾5_表示 = value;
				this.尾4_鱗左_鱗1_表示 = value;
				this.尾4_鱗左_鱗2_表示 = value;
				this.尾4_鱗左_鱗3_表示 = value;
				this.尾4_鱗左_鱗4_表示 = value;
				this.尾4_鱗右_鱗1_表示 = value;
				this.尾4_鱗右_鱗2_表示 = value;
				this.尾4_鱗右_鱗3_表示 = value;
				this.尾4_鱗右_鱗4_表示 = value;
				this.尾4_表示 = value;
				this.輪_革_表示 = value;
				this.輪_金具1_表示 = value;
				this.輪_金具2_表示 = value;
				this.輪_金具3_表示 = value;
				this.輪_金具左_表示 = value;
				this.輪_金具右_表示 = value;
				this.尾3_鱗左_鱗1_表示 = value;
				this.尾3_鱗左_鱗2_表示 = value;
				this.尾3_鱗左_鱗3_表示 = value;
				this.尾3_鱗左_鱗4_表示 = value;
				this.尾3_鱗右_鱗1_表示 = value;
				this.尾3_鱗右_鱗2_表示 = value;
				this.尾3_鱗右_鱗3_表示 = value;
				this.尾3_鱗右_鱗4_表示 = value;
				this.尾3_表示 = value;
				this.尾2_鱗左_鱗1_表示 = value;
				this.尾2_鱗左_鱗2_表示 = value;
				this.尾2_鱗左_鱗3_表示 = value;
				this.尾2_鱗左_鱗4_表示 = value;
				this.尾2_鱗右_鱗1_表示 = value;
				this.尾2_鱗右_鱗2_表示 = value;
				this.尾2_鱗右_鱗3_表示 = value;
				this.尾2_鱗右_鱗4_表示 = value;
				this.尾2_表示 = value;
				this.尾1_鱗左_鱗1_表示 = value;
				this.尾1_鱗左_鱗2_表示 = value;
				this.尾1_鱗左_鱗3_表示 = value;
				this.尾1_鱗左_鱗4_表示 = value;
				this.尾1_鱗右_鱗1_表示 = value;
				this.尾1_鱗右_鱗2_表示 = value;
				this.尾1_鱗右_鱗3_表示 = value;
				this.尾1_鱗右_鱗4_表示 = value;
				this.尾1_表示 = value;
				this.尾0_鱗左_鱗1_表示 = value;
				this.尾0_鱗左_鱗2_表示 = value;
				this.尾0_鱗左_鱗3_表示 = value;
				this.尾0_鱗左_鱗4_表示 = value;
				this.尾0_鱗右_鱗1_表示 = value;
				this.尾0_鱗右_鱗2_表示 = value;
				this.尾0_鱗右_鱗3_表示 = value;
				this.尾0_鱗右_鱗4_表示 = value;
				this.尾0_表示 = value;
				this.鎖1.表示 = value;
				this.鎖2.表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.尾33_鱗左_鱗1CD.不透明度;
			}
			set
			{
				this.尾33_鱗左_鱗1CD.不透明度 = value;
				this.尾33_鱗左_鱗3CD.不透明度 = value;
				this.尾33_鱗右_鱗1CD.不透明度 = value;
				this.尾33_鱗右_鱗3CD.不透明度 = value;
				this.尾33_尾CD.不透明度 = value;
				this.尾32_鱗左_鱗1CD.不透明度 = value;
				this.尾32_鱗左_鱗2CD.不透明度 = value;
				this.尾32_鱗左_鱗3CD.不透明度 = value;
				this.尾32_鱗左_鱗4CD.不透明度 = value;
				this.尾32_鱗右_鱗1CD.不透明度 = value;
				this.尾32_鱗右_鱗2CD.不透明度 = value;
				this.尾32_鱗右_鱗3CD.不透明度 = value;
				this.尾32_鱗右_鱗4CD.不透明度 = value;
				this.尾32_尾CD.不透明度 = value;
				this.尾31_鱗左_鱗1CD.不透明度 = value;
				this.尾31_鱗左_鱗2CD.不透明度 = value;
				this.尾31_鱗左_鱗3CD.不透明度 = value;
				this.尾31_鱗左_鱗4CD.不透明度 = value;
				this.尾31_鱗右_鱗1CD.不透明度 = value;
				this.尾31_鱗右_鱗2CD.不透明度 = value;
				this.尾31_鱗右_鱗3CD.不透明度 = value;
				this.尾31_鱗右_鱗4CD.不透明度 = value;
				this.尾31_尾CD.不透明度 = value;
				this.尾30_鱗左_鱗1CD.不透明度 = value;
				this.尾30_鱗左_鱗2CD.不透明度 = value;
				this.尾30_鱗左_鱗3CD.不透明度 = value;
				this.尾30_鱗左_鱗4CD.不透明度 = value;
				this.尾30_鱗右_鱗1CD.不透明度 = value;
				this.尾30_鱗右_鱗2CD.不透明度 = value;
				this.尾30_鱗右_鱗3CD.不透明度 = value;
				this.尾30_鱗右_鱗4CD.不透明度 = value;
				this.尾30_尾CD.不透明度 = value;
				this.尾29_鱗左_鱗1CD.不透明度 = value;
				this.尾29_鱗左_鱗2CD.不透明度 = value;
				this.尾29_鱗左_鱗3CD.不透明度 = value;
				this.尾29_鱗左_鱗4CD.不透明度 = value;
				this.尾29_鱗右_鱗1CD.不透明度 = value;
				this.尾29_鱗右_鱗2CD.不透明度 = value;
				this.尾29_鱗右_鱗3CD.不透明度 = value;
				this.尾29_鱗右_鱗4CD.不透明度 = value;
				this.尾29_尾CD.不透明度 = value;
				this.尾28_鱗左_鱗1CD.不透明度 = value;
				this.尾28_鱗左_鱗2CD.不透明度 = value;
				this.尾28_鱗左_鱗3CD.不透明度 = value;
				this.尾28_鱗左_鱗4CD.不透明度 = value;
				this.尾28_鱗右_鱗1CD.不透明度 = value;
				this.尾28_鱗右_鱗2CD.不透明度 = value;
				this.尾28_鱗右_鱗3CD.不透明度 = value;
				this.尾28_鱗右_鱗4CD.不透明度 = value;
				this.尾28_尾CD.不透明度 = value;
				this.尾27_鱗左_鱗1CD.不透明度 = value;
				this.尾27_鱗左_鱗2CD.不透明度 = value;
				this.尾27_鱗左_鱗3CD.不透明度 = value;
				this.尾27_鱗左_鱗4CD.不透明度 = value;
				this.尾27_鱗右_鱗1CD.不透明度 = value;
				this.尾27_鱗右_鱗2CD.不透明度 = value;
				this.尾27_鱗右_鱗3CD.不透明度 = value;
				this.尾27_鱗右_鱗4CD.不透明度 = value;
				this.尾27_尾CD.不透明度 = value;
				this.尾26_鱗左_鱗1CD.不透明度 = value;
				this.尾26_鱗左_鱗2CD.不透明度 = value;
				this.尾26_鱗左_鱗3CD.不透明度 = value;
				this.尾26_鱗左_鱗4CD.不透明度 = value;
				this.尾26_鱗右_鱗1CD.不透明度 = value;
				this.尾26_鱗右_鱗2CD.不透明度 = value;
				this.尾26_鱗右_鱗3CD.不透明度 = value;
				this.尾26_鱗右_鱗4CD.不透明度 = value;
				this.尾26_尾CD.不透明度 = value;
				this.尾25_鱗左_鱗1CD.不透明度 = value;
				this.尾25_鱗左_鱗2CD.不透明度 = value;
				this.尾25_鱗左_鱗3CD.不透明度 = value;
				this.尾25_鱗左_鱗4CD.不透明度 = value;
				this.尾25_鱗右_鱗1CD.不透明度 = value;
				this.尾25_鱗右_鱗2CD.不透明度 = value;
				this.尾25_鱗右_鱗3CD.不透明度 = value;
				this.尾25_鱗右_鱗4CD.不透明度 = value;
				this.尾25_尾CD.不透明度 = value;
				this.尾24_鱗左_鱗1CD.不透明度 = value;
				this.尾24_鱗左_鱗2CD.不透明度 = value;
				this.尾24_鱗左_鱗3CD.不透明度 = value;
				this.尾24_鱗左_鱗4CD.不透明度 = value;
				this.尾24_鱗右_鱗1CD.不透明度 = value;
				this.尾24_鱗右_鱗2CD.不透明度 = value;
				this.尾24_鱗右_鱗3CD.不透明度 = value;
				this.尾24_鱗右_鱗4CD.不透明度 = value;
				this.尾24_尾CD.不透明度 = value;
				this.尾23_鱗左_鱗1CD.不透明度 = value;
				this.尾23_鱗左_鱗2CD.不透明度 = value;
				this.尾23_鱗左_鱗3CD.不透明度 = value;
				this.尾23_鱗左_鱗4CD.不透明度 = value;
				this.尾23_鱗右_鱗1CD.不透明度 = value;
				this.尾23_鱗右_鱗2CD.不透明度 = value;
				this.尾23_鱗右_鱗3CD.不透明度 = value;
				this.尾23_鱗右_鱗4CD.不透明度 = value;
				this.尾23_尾CD.不透明度 = value;
				this.尾22_鱗左_鱗1CD.不透明度 = value;
				this.尾22_鱗左_鱗2CD.不透明度 = value;
				this.尾22_鱗左_鱗3CD.不透明度 = value;
				this.尾22_鱗左_鱗4CD.不透明度 = value;
				this.尾22_鱗右_鱗1CD.不透明度 = value;
				this.尾22_鱗右_鱗2CD.不透明度 = value;
				this.尾22_鱗右_鱗3CD.不透明度 = value;
				this.尾22_鱗右_鱗4CD.不透明度 = value;
				this.尾22_尾CD.不透明度 = value;
				this.尾21_鱗左_鱗1CD.不透明度 = value;
				this.尾21_鱗左_鱗2CD.不透明度 = value;
				this.尾21_鱗左_鱗3CD.不透明度 = value;
				this.尾21_鱗左_鱗4CD.不透明度 = value;
				this.尾21_鱗右_鱗1CD.不透明度 = value;
				this.尾21_鱗右_鱗2CD.不透明度 = value;
				this.尾21_鱗右_鱗3CD.不透明度 = value;
				this.尾21_鱗右_鱗4CD.不透明度 = value;
				this.尾21_尾CD.不透明度 = value;
				this.尾20_鱗左_鱗1CD.不透明度 = value;
				this.尾20_鱗左_鱗2CD.不透明度 = value;
				this.尾20_鱗左_鱗3CD.不透明度 = value;
				this.尾20_鱗左_鱗4CD.不透明度 = value;
				this.尾20_鱗右_鱗1CD.不透明度 = value;
				this.尾20_鱗右_鱗2CD.不透明度 = value;
				this.尾20_鱗右_鱗3CD.不透明度 = value;
				this.尾20_鱗右_鱗4CD.不透明度 = value;
				this.尾20_尾CD.不透明度 = value;
				this.尾19_鱗左_鱗1CD.不透明度 = value;
				this.尾19_鱗左_鱗2CD.不透明度 = value;
				this.尾19_鱗左_鱗3CD.不透明度 = value;
				this.尾19_鱗左_鱗4CD.不透明度 = value;
				this.尾19_鱗右_鱗1CD.不透明度 = value;
				this.尾19_鱗右_鱗2CD.不透明度 = value;
				this.尾19_鱗右_鱗3CD.不透明度 = value;
				this.尾19_鱗右_鱗4CD.不透明度 = value;
				this.尾19_尾CD.不透明度 = value;
				this.尾18_鱗左_鱗1CD.不透明度 = value;
				this.尾18_鱗左_鱗2CD.不透明度 = value;
				this.尾18_鱗左_鱗3CD.不透明度 = value;
				this.尾18_鱗左_鱗4CD.不透明度 = value;
				this.尾18_鱗右_鱗1CD.不透明度 = value;
				this.尾18_鱗右_鱗2CD.不透明度 = value;
				this.尾18_鱗右_鱗3CD.不透明度 = value;
				this.尾18_鱗右_鱗4CD.不透明度 = value;
				this.尾18_尾CD.不透明度 = value;
				this.尾17_鱗左_鱗1CD.不透明度 = value;
				this.尾17_鱗左_鱗2CD.不透明度 = value;
				this.尾17_鱗左_鱗3CD.不透明度 = value;
				this.尾17_鱗左_鱗4CD.不透明度 = value;
				this.尾17_鱗右_鱗1CD.不透明度 = value;
				this.尾17_鱗右_鱗2CD.不透明度 = value;
				this.尾17_鱗右_鱗3CD.不透明度 = value;
				this.尾17_鱗右_鱗4CD.不透明度 = value;
				this.尾17_尾CD.不透明度 = value;
				this.尾16_鱗左_鱗1CD.不透明度 = value;
				this.尾16_鱗左_鱗2CD.不透明度 = value;
				this.尾16_鱗左_鱗3CD.不透明度 = value;
				this.尾16_鱗左_鱗4CD.不透明度 = value;
				this.尾16_鱗右_鱗1CD.不透明度 = value;
				this.尾16_鱗右_鱗2CD.不透明度 = value;
				this.尾16_鱗右_鱗3CD.不透明度 = value;
				this.尾16_鱗右_鱗4CD.不透明度 = value;
				this.尾16_尾CD.不透明度 = value;
				this.尾15_鱗左_鱗1CD.不透明度 = value;
				this.尾15_鱗左_鱗2CD.不透明度 = value;
				this.尾15_鱗左_鱗3CD.不透明度 = value;
				this.尾15_鱗左_鱗4CD.不透明度 = value;
				this.尾15_鱗右_鱗1CD.不透明度 = value;
				this.尾15_鱗右_鱗2CD.不透明度 = value;
				this.尾15_鱗右_鱗3CD.不透明度 = value;
				this.尾15_鱗右_鱗4CD.不透明度 = value;
				this.尾15_尾CD.不透明度 = value;
				this.尾14_鱗左_鱗1CD.不透明度 = value;
				this.尾14_鱗左_鱗2CD.不透明度 = value;
				this.尾14_鱗左_鱗3CD.不透明度 = value;
				this.尾14_鱗左_鱗4CD.不透明度 = value;
				this.尾14_鱗右_鱗1CD.不透明度 = value;
				this.尾14_鱗右_鱗2CD.不透明度 = value;
				this.尾14_鱗右_鱗3CD.不透明度 = value;
				this.尾14_鱗右_鱗4CD.不透明度 = value;
				this.尾14_尾CD.不透明度 = value;
				this.尾13_鱗左_鱗1CD.不透明度 = value;
				this.尾13_鱗左_鱗2CD.不透明度 = value;
				this.尾13_鱗左_鱗3CD.不透明度 = value;
				this.尾13_鱗左_鱗4CD.不透明度 = value;
				this.尾13_鱗右_鱗1CD.不透明度 = value;
				this.尾13_鱗右_鱗2CD.不透明度 = value;
				this.尾13_鱗右_鱗3CD.不透明度 = value;
				this.尾13_鱗右_鱗4CD.不透明度 = value;
				this.尾13_尾CD.不透明度 = value;
				this.尾12_鱗左_鱗1CD.不透明度 = value;
				this.尾12_鱗左_鱗2CD.不透明度 = value;
				this.尾12_鱗左_鱗3CD.不透明度 = value;
				this.尾12_鱗左_鱗4CD.不透明度 = value;
				this.尾12_鱗右_鱗1CD.不透明度 = value;
				this.尾12_鱗右_鱗2CD.不透明度 = value;
				this.尾12_鱗右_鱗3CD.不透明度 = value;
				this.尾12_鱗右_鱗4CD.不透明度 = value;
				this.尾12_尾CD.不透明度 = value;
				this.尾11_鱗左_鱗1CD.不透明度 = value;
				this.尾11_鱗左_鱗2CD.不透明度 = value;
				this.尾11_鱗左_鱗3CD.不透明度 = value;
				this.尾11_鱗左_鱗4CD.不透明度 = value;
				this.尾11_鱗右_鱗1CD.不透明度 = value;
				this.尾11_鱗右_鱗2CD.不透明度 = value;
				this.尾11_鱗右_鱗3CD.不透明度 = value;
				this.尾11_鱗右_鱗4CD.不透明度 = value;
				this.尾11_尾CD.不透明度 = value;
				this.尾10_鱗左_鱗1CD.不透明度 = value;
				this.尾10_鱗左_鱗2CD.不透明度 = value;
				this.尾10_鱗左_鱗3CD.不透明度 = value;
				this.尾10_鱗左_鱗4CD.不透明度 = value;
				this.尾10_鱗右_鱗1CD.不透明度 = value;
				this.尾10_鱗右_鱗2CD.不透明度 = value;
				this.尾10_鱗右_鱗3CD.不透明度 = value;
				this.尾10_鱗右_鱗4CD.不透明度 = value;
				this.尾10_尾CD.不透明度 = value;
				this.尾9_鱗左_鱗1CD.不透明度 = value;
				this.尾9_鱗左_鱗2CD.不透明度 = value;
				this.尾9_鱗左_鱗3CD.不透明度 = value;
				this.尾9_鱗左_鱗4CD.不透明度 = value;
				this.尾9_鱗右_鱗1CD.不透明度 = value;
				this.尾9_鱗右_鱗2CD.不透明度 = value;
				this.尾9_鱗右_鱗3CD.不透明度 = value;
				this.尾9_鱗右_鱗4CD.不透明度 = value;
				this.尾9_尾CD.不透明度 = value;
				this.尾8_鱗左_鱗1CD.不透明度 = value;
				this.尾8_鱗左_鱗2CD.不透明度 = value;
				this.尾8_鱗左_鱗3CD.不透明度 = value;
				this.尾8_鱗左_鱗4CD.不透明度 = value;
				this.尾8_鱗右_鱗1CD.不透明度 = value;
				this.尾8_鱗右_鱗2CD.不透明度 = value;
				this.尾8_鱗右_鱗3CD.不透明度 = value;
				this.尾8_鱗右_鱗4CD.不透明度 = value;
				this.尾8_尾CD.不透明度 = value;
				this.尾7_鱗左_鱗1CD.不透明度 = value;
				this.尾7_鱗左_鱗2CD.不透明度 = value;
				this.尾7_鱗左_鱗3CD.不透明度 = value;
				this.尾7_鱗左_鱗4CD.不透明度 = value;
				this.尾7_鱗右_鱗1CD.不透明度 = value;
				this.尾7_鱗右_鱗2CD.不透明度 = value;
				this.尾7_鱗右_鱗3CD.不透明度 = value;
				this.尾7_鱗右_鱗4CD.不透明度 = value;
				this.尾7_尾CD.不透明度 = value;
				this.尾6_鱗左_鱗1CD.不透明度 = value;
				this.尾6_鱗左_鱗2CD.不透明度 = value;
				this.尾6_鱗左_鱗3CD.不透明度 = value;
				this.尾6_鱗左_鱗4CD.不透明度 = value;
				this.尾6_鱗右_鱗1CD.不透明度 = value;
				this.尾6_鱗右_鱗2CD.不透明度 = value;
				this.尾6_鱗右_鱗3CD.不透明度 = value;
				this.尾6_鱗右_鱗4CD.不透明度 = value;
				this.尾6_尾CD.不透明度 = value;
				this.尾5_鱗左_鱗1CD.不透明度 = value;
				this.尾5_鱗左_鱗2CD.不透明度 = value;
				this.尾5_鱗左_鱗3CD.不透明度 = value;
				this.尾5_鱗左_鱗4CD.不透明度 = value;
				this.尾5_鱗右_鱗1CD.不透明度 = value;
				this.尾5_鱗右_鱗2CD.不透明度 = value;
				this.尾5_鱗右_鱗3CD.不透明度 = value;
				this.尾5_鱗右_鱗4CD.不透明度 = value;
				this.尾5_尾CD.不透明度 = value;
				this.尾4_鱗左_鱗1CD.不透明度 = value;
				this.尾4_鱗左_鱗2CD.不透明度 = value;
				this.尾4_鱗左_鱗3CD.不透明度 = value;
				this.尾4_鱗左_鱗4CD.不透明度 = value;
				this.尾4_鱗右_鱗1CD.不透明度 = value;
				this.尾4_鱗右_鱗2CD.不透明度 = value;
				this.尾4_鱗右_鱗3CD.不透明度 = value;
				this.尾4_鱗右_鱗4CD.不透明度 = value;
				this.尾4_尾CD.不透明度 = value;
				this.尾3_鱗左_鱗1CD.不透明度 = value;
				this.尾3_鱗左_鱗2CD.不透明度 = value;
				this.尾3_鱗左_鱗3CD.不透明度 = value;
				this.尾3_鱗左_鱗4CD.不透明度 = value;
				this.尾3_鱗右_鱗1CD.不透明度 = value;
				this.尾3_鱗右_鱗2CD.不透明度 = value;
				this.尾3_鱗右_鱗3CD.不透明度 = value;
				this.尾3_鱗右_鱗4CD.不透明度 = value;
				this.尾3_尾CD.不透明度 = value;
				this.尾2_鱗左_鱗1CD.不透明度 = value;
				this.尾2_鱗左_鱗2CD.不透明度 = value;
				this.尾2_鱗左_鱗3CD.不透明度 = value;
				this.尾2_鱗左_鱗4CD.不透明度 = value;
				this.尾2_鱗右_鱗1CD.不透明度 = value;
				this.尾2_鱗右_鱗2CD.不透明度 = value;
				this.尾2_鱗右_鱗3CD.不透明度 = value;
				this.尾2_鱗右_鱗4CD.不透明度 = value;
				this.尾2_尾CD.不透明度 = value;
				this.尾1_鱗左_鱗1CD.不透明度 = value;
				this.尾1_鱗左_鱗2CD.不透明度 = value;
				this.尾1_鱗左_鱗3CD.不透明度 = value;
				this.尾1_鱗左_鱗4CD.不透明度 = value;
				this.尾1_鱗右_鱗1CD.不透明度 = value;
				this.尾1_鱗右_鱗2CD.不透明度 = value;
				this.尾1_鱗右_鱗3CD.不透明度 = value;
				this.尾1_鱗右_鱗4CD.不透明度 = value;
				this.尾1_尾CD.不透明度 = value;
				this.尾0_鱗左_鱗1CD.不透明度 = value;
				this.尾0_鱗左_鱗2CD.不透明度 = value;
				this.尾0_鱗左_鱗3CD.不透明度 = value;
				this.尾0_鱗左_鱗4CD.不透明度 = value;
				this.尾0_鱗右_鱗1CD.不透明度 = value;
				this.尾0_鱗右_鱗2CD.不透明度 = value;
				this.尾0_鱗右_鱗3CD.不透明度 = value;
				this.尾0_鱗右_鱗4CD.不透明度 = value;
				this.尾0_尾CD.不透明度 = value;
				this.輪_革CD.不透明度 = value;
				this.輪_金具1CD.不透明度 = value;
				this.輪_金具2CD.不透明度 = value;
				this.輪_金具3CD.不透明度 = value;
				this.輪_金具左CD.不透明度 = value;
				this.輪_金具右CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			bool 右 = this.右;
			double maxAngle = 20.0;
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
			if (this.接続情報.ToString().Contains("腿"))
			{
				this.X0Y0_尾0_尾.AngleBase = 0.0;
			}
			else
			{
				this.X0Y0_尾0_尾.AngleBase = maxAngle.GetRanAngle();
			}
			this.本体.JoinPAall();
			if (this.尾先_接続 != null)
			{
				this.Set尾先角度();
			}
		}

		public override void Set尾先角度()
		{
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
			this.X0Y0_尾19_尾.AngleBase = 0.0;
			this.X0Y0_尾18_尾.AngleBase = 0.0;
			this.X0Y0_尾17_尾.AngleBase = 0.0;
			this.X0Y0_尾16_尾.AngleBase = 0.0;
			this.X0Y0_尾15_尾.AngleBase = 0.0;
			this.X0Y0_尾14_尾.AngleBase = 0.0;
		}

		public override void 描画0(Are Are)
		{
			if (this.Rパタ\u30FCン)
			{
				Are.Draw(this.X0Y0_尾33_尾);
				Are.Draw(this.X0Y0_尾33_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾33_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾33_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾33_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾32_尾);
				Are.Draw(this.X0Y0_尾32_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾32_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾32_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾32_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾32_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾32_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾32_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾32_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾31_尾);
				Are.Draw(this.X0Y0_尾31_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾31_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾31_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾31_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾31_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾31_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾31_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾31_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾30_尾);
				Are.Draw(this.X0Y0_尾30_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾30_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾30_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾30_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾30_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾30_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾30_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾30_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾29_尾);
				Are.Draw(this.X0Y0_尾29_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾29_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾29_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾29_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾29_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾29_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾29_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾29_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾28_尾);
				Are.Draw(this.X0Y0_尾28_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾28_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾28_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾28_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾28_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾28_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾28_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾28_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾27_尾);
				Are.Draw(this.X0Y0_尾27_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾27_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾27_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾27_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾27_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾27_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾27_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾27_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾26_尾);
				Are.Draw(this.X0Y0_尾26_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾26_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾26_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾26_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾26_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾26_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾26_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾26_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾25_尾);
				Are.Draw(this.X0Y0_尾25_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾25_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾25_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾25_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾25_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾25_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾25_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾25_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾24_尾);
				Are.Draw(this.X0Y0_尾24_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾24_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾24_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾24_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾24_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾24_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾24_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾24_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾23_尾);
				Are.Draw(this.X0Y0_尾23_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾23_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾23_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾23_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾23_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾23_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾23_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾23_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾22_尾);
				Are.Draw(this.X0Y0_尾22_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾22_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾22_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾22_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾22_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾22_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾22_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾22_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾21_尾);
				Are.Draw(this.X0Y0_尾21_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾21_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾21_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾21_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾21_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾21_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾21_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾21_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾20_尾);
				Are.Draw(this.X0Y0_尾20_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾20_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾20_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾20_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾20_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾20_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾20_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾20_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾19_尾);
				Are.Draw(this.X0Y0_尾19_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾19_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾19_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾19_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾19_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾19_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾19_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾19_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾18_尾);
				Are.Draw(this.X0Y0_尾18_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾18_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾18_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾18_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾18_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾18_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾18_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾18_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾17_尾);
				Are.Draw(this.X0Y0_尾17_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾17_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾17_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾17_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾17_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾17_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾17_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾17_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾16_尾);
				Are.Draw(this.X0Y0_尾16_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾16_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾16_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾16_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾16_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾16_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾16_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾16_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾15_尾);
				Are.Draw(this.X0Y0_尾15_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾15_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾15_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾15_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾15_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾15_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾15_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾15_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾14_尾);
				Are.Draw(this.X0Y0_尾14_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾14_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾14_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾14_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾14_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾14_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾14_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾14_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾13_尾);
				Are.Draw(this.X0Y0_尾13_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾13_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾13_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾13_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾13_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾13_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾13_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾13_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾12_尾);
				Are.Draw(this.X0Y0_尾12_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾12_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾12_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾12_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾12_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾12_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾12_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾12_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾11_尾);
				Are.Draw(this.X0Y0_尾11_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾11_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾11_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾11_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾11_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾11_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾11_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾11_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾10_尾);
				Are.Draw(this.X0Y0_尾10_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾10_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾10_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾10_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾10_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾10_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾10_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾10_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾9_尾);
				Are.Draw(this.X0Y0_尾9_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾9_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾9_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾9_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾9_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾9_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾9_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾9_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾8_尾);
				Are.Draw(this.X0Y0_尾8_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾8_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾8_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾8_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾8_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾8_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾8_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾8_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾7_尾);
				Are.Draw(this.X0Y0_尾7_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾7_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾7_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾7_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾7_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾7_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾7_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾7_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾6_尾);
				Are.Draw(this.X0Y0_尾6_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾6_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾6_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾6_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾6_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾6_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾6_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾6_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾5_尾);
				Are.Draw(this.X0Y0_尾5_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾5_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾5_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾5_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾5_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾5_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾5_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾5_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾4_尾);
				Are.Draw(this.X0Y0_尾4_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾4_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾4_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾4_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾4_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾4_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾4_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾4_鱗左_鱗1);
				Are.Draw(this.X0Y0_輪_革);
				Are.Draw(this.X0Y0_輪_金具1);
				Are.Draw(this.X0Y0_輪_金具2);
				Are.Draw(this.X0Y0_輪_金具3);
				Are.Draw(this.X0Y0_輪_金具左);
				Are.Draw(this.X0Y0_輪_金具右);
				this.鎖1.描画0(Are);
				this.鎖2.描画0(Are);
				Are.Draw(this.X0Y0_尾3_尾);
				Are.Draw(this.X0Y0_尾3_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾3_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾3_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾3_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾3_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾3_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾3_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾3_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾2_尾);
				Are.Draw(this.X0Y0_尾2_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾2_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾2_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾2_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾2_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾2_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾2_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾2_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾1_尾);
				Are.Draw(this.X0Y0_尾1_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾1_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾1_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾1_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾1_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾1_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾1_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾1_鱗左_鱗1);
				Are.Draw(this.X0Y0_尾0_尾);
				Are.Draw(this.X0Y0_尾0_鱗右_鱗4);
				Are.Draw(this.X0Y0_尾0_鱗右_鱗3);
				Are.Draw(this.X0Y0_尾0_鱗右_鱗2);
				Are.Draw(this.X0Y0_尾0_鱗右_鱗1);
				Are.Draw(this.X0Y0_尾0_鱗左_鱗4);
				Are.Draw(this.X0Y0_尾0_鱗左_鱗3);
				Are.Draw(this.X0Y0_尾0_鱗左_鱗2);
				Are.Draw(this.X0Y0_尾0_鱗左_鱗1);
				return;
			}
			Are.Draw(this.X0Y0_尾33_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾33_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾33_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾33_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾33_尾);
			Are.Draw(this.X0Y0_尾32_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾32_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾32_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾32_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾32_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾32_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾32_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾32_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾32_尾);
			Are.Draw(this.X0Y0_尾31_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾31_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾31_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾31_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾31_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾31_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾31_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾31_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾31_尾);
			Are.Draw(this.X0Y0_尾30_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾30_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾30_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾30_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾30_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾30_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾30_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾30_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾30_尾);
			Are.Draw(this.X0Y0_尾29_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾29_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾29_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾29_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾29_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾29_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾29_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾29_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾29_尾);
			Are.Draw(this.X0Y0_尾28_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾28_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾28_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾28_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾28_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾28_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾28_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾28_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾28_尾);
			Are.Draw(this.X0Y0_尾27_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾27_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾27_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾27_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾27_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾27_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾27_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾27_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾27_尾);
			Are.Draw(this.X0Y0_尾26_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾26_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾26_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾26_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾26_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾26_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾26_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾26_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾26_尾);
			Are.Draw(this.X0Y0_尾25_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾25_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾25_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾25_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾25_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾25_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾25_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾25_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾25_尾);
			Are.Draw(this.X0Y0_尾24_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾24_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾24_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾24_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾24_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾24_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾24_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾24_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾24_尾);
			Are.Draw(this.X0Y0_尾23_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾23_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾23_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾23_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾23_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾23_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾23_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾23_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾23_尾);
			Are.Draw(this.X0Y0_尾22_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾22_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾22_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾22_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾22_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾22_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾22_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾22_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾22_尾);
			Are.Draw(this.X0Y0_尾21_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾21_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾21_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾21_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾21_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾21_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾21_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾21_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾21_尾);
			Are.Draw(this.X0Y0_尾20_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾20_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾20_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾20_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾20_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾20_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾20_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾20_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾20_尾);
			Are.Draw(this.X0Y0_尾19_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾19_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾19_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾19_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾19_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾19_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾19_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾19_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾19_尾);
			Are.Draw(this.X0Y0_尾18_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾18_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾18_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾18_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾18_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾18_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾18_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾18_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾18_尾);
			Are.Draw(this.X0Y0_尾17_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾17_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾17_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾17_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾17_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾17_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾17_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾17_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾17_尾);
			Are.Draw(this.X0Y0_尾16_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾16_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾16_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾16_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾16_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾16_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾16_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾16_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾16_尾);
			Are.Draw(this.X0Y0_尾15_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾15_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾15_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾15_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾15_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾15_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾15_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾15_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾15_尾);
			Are.Draw(this.X0Y0_尾14_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾14_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾14_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾14_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾14_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾14_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾14_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾14_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾14_尾);
			Are.Draw(this.X0Y0_尾13_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾13_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾13_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾13_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾13_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾13_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾13_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾13_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾13_尾);
			Are.Draw(this.X0Y0_尾12_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾12_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾12_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾12_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾12_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾12_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾12_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾12_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾12_尾);
			Are.Draw(this.X0Y0_尾11_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾11_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾11_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾11_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾11_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾11_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾11_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾11_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾11_尾);
			Are.Draw(this.X0Y0_尾10_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾10_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾10_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾10_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾10_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾10_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾10_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾10_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾10_尾);
			Are.Draw(this.X0Y0_尾9_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾9_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾9_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾9_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾9_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾9_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾9_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾9_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾9_尾);
			Are.Draw(this.X0Y0_尾8_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾8_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾8_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾8_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾8_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾8_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾8_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾8_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾8_尾);
			Are.Draw(this.X0Y0_尾7_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾7_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾7_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾7_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾7_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾7_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾7_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾7_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾7_尾);
			Are.Draw(this.X0Y0_尾6_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾6_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾6_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾6_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾6_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾6_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾6_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾6_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾6_尾);
			Are.Draw(this.X0Y0_尾5_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾5_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾5_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾5_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾5_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾5_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾5_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾5_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾5_尾);
			Are.Draw(this.X0Y0_尾4_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾4_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾4_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾4_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾4_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾4_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾4_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾4_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾4_尾);
			Are.Draw(this.X0Y0_輪_革);
			Are.Draw(this.X0Y0_輪_金具1);
			Are.Draw(this.X0Y0_輪_金具2);
			Are.Draw(this.X0Y0_輪_金具3);
			Are.Draw(this.X0Y0_輪_金具左);
			Are.Draw(this.X0Y0_輪_金具右);
			this.鎖1.描画0(Are);
			this.鎖2.描画0(Are);
			Are.Draw(this.X0Y0_尾3_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾3_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾3_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾3_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾3_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾3_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾3_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾3_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾3_尾);
			Are.Draw(this.X0Y0_尾2_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾2_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾2_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾2_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾2_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾2_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾2_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾2_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾2_尾);
			Are.Draw(this.X0Y0_尾1_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾1_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾1_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾1_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾1_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾1_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾1_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾1_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾1_尾);
			Are.Draw(this.X0Y0_尾0_鱗左_鱗1);
			Are.Draw(this.X0Y0_尾0_鱗左_鱗2);
			Are.Draw(this.X0Y0_尾0_鱗左_鱗3);
			Are.Draw(this.X0Y0_尾0_鱗左_鱗4);
			Are.Draw(this.X0Y0_尾0_鱗右_鱗1);
			Are.Draw(this.X0Y0_尾0_鱗右_鱗2);
			Are.Draw(this.X0Y0_尾0_鱗右_鱗3);
			Are.Draw(this.X0Y0_尾0_鱗右_鱗4);
			Are.Draw(this.X0Y0_尾0_尾);
		}

		public override void Dispose()
		{
			base.Dispose();
			this.鎖1.Dispose();
			this.鎖2.Dispose();
		}

		public bool 胴_外線
		{
			get
			{
				return this.X0Y0_尾33_尾.OP[this.右 ? 2 : 3].Outline;
			}
			set
			{
				this.X0Y0_尾33_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾32_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾31_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾30_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾29_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾28_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾27_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾26_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾25_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾24_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾23_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾22_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾21_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾20_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾19_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾18_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾17_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾16_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾15_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾14_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾13_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾12_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾11_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾10_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾9_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾8_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾7_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾6_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾5_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾4_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾3_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾2_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾1_尾.OP[this.右 ? 2 : 3].Outline = value;
				this.X0Y0_尾0_尾.OP[this.右 ? 2 : 3].Outline = value;
			}
		}

		public bool 鱗1
		{
			get
			{
				return this.尾33_鱗左_鱗1_表示;
			}
			set
			{
				this.尾33_鱗左_鱗1_表示 = value;
				this.尾33_鱗右_鱗1_表示 = value;
				this.尾32_鱗左_鱗1_表示 = value;
				this.尾32_鱗右_鱗1_表示 = value;
				this.尾31_鱗左_鱗1_表示 = value;
				this.尾31_鱗右_鱗1_表示 = value;
				this.尾30_鱗左_鱗1_表示 = value;
				this.尾30_鱗右_鱗1_表示 = value;
				this.尾29_鱗左_鱗1_表示 = value;
				this.尾29_鱗右_鱗1_表示 = value;
				this.尾28_鱗左_鱗1_表示 = value;
				this.尾28_鱗右_鱗1_表示 = value;
				this.尾27_鱗左_鱗1_表示 = value;
				this.尾27_鱗右_鱗1_表示 = value;
				this.尾26_鱗左_鱗1_表示 = value;
				this.尾26_鱗右_鱗1_表示 = value;
				this.尾25_鱗左_鱗1_表示 = value;
				this.尾25_鱗右_鱗1_表示 = value;
				this.尾24_鱗左_鱗1_表示 = value;
				this.尾24_鱗右_鱗1_表示 = value;
				this.尾23_鱗左_鱗1_表示 = value;
				this.尾23_鱗右_鱗1_表示 = value;
				this.尾22_鱗左_鱗1_表示 = value;
				this.尾22_鱗右_鱗1_表示 = value;
				this.尾21_鱗左_鱗1_表示 = value;
				this.尾21_鱗右_鱗1_表示 = value;
				this.尾20_鱗左_鱗1_表示 = value;
				this.尾20_鱗右_鱗1_表示 = value;
				this.尾19_鱗左_鱗1_表示 = value;
				this.尾19_鱗右_鱗1_表示 = value;
				this.尾18_鱗左_鱗1_表示 = value;
				this.尾18_鱗右_鱗1_表示 = value;
				this.尾17_鱗左_鱗1_表示 = value;
				this.尾17_鱗右_鱗1_表示 = value;
				this.尾16_鱗左_鱗1_表示 = value;
				this.尾16_鱗右_鱗1_表示 = value;
				this.尾15_鱗左_鱗1_表示 = value;
				this.尾15_鱗右_鱗1_表示 = value;
				this.尾14_鱗左_鱗1_表示 = value;
				this.尾14_鱗右_鱗1_表示 = value;
				this.尾13_鱗左_鱗1_表示 = value;
				this.尾13_鱗右_鱗1_表示 = value;
				this.尾12_鱗左_鱗1_表示 = value;
				this.尾12_鱗右_鱗1_表示 = value;
				this.尾11_鱗左_鱗1_表示 = value;
				this.尾11_鱗右_鱗1_表示 = value;
				this.尾10_鱗左_鱗1_表示 = value;
				this.尾10_鱗右_鱗1_表示 = value;
				this.尾9_鱗左_鱗1_表示 = value;
				this.尾9_鱗右_鱗1_表示 = value;
				this.尾8_鱗左_鱗1_表示 = value;
				this.尾8_鱗右_鱗1_表示 = value;
				this.尾7_鱗左_鱗1_表示 = value;
				this.尾7_鱗右_鱗1_表示 = value;
				this.尾6_鱗左_鱗1_表示 = value;
				this.尾6_鱗右_鱗1_表示 = value;
				this.尾5_鱗左_鱗1_表示 = value;
				this.尾5_鱗右_鱗1_表示 = value;
				this.尾4_鱗左_鱗1_表示 = value;
				this.尾4_鱗右_鱗1_表示 = value;
				this.尾3_鱗左_鱗1_表示 = value;
				this.尾3_鱗右_鱗1_表示 = value;
				this.尾2_鱗左_鱗1_表示 = value;
				this.尾2_鱗右_鱗1_表示 = value;
				this.尾1_鱗左_鱗1_表示 = value;
				this.尾1_鱗右_鱗1_表示 = value;
				this.尾0_鱗左_鱗1_表示 = value;
				this.尾0_鱗右_鱗1_表示 = value;
			}
		}

		public bool 鱗2
		{
			get
			{
				return this.尾32_鱗左_鱗2_表示;
			}
			set
			{
				this.尾32_鱗左_鱗2_表示 = value;
				this.尾32_鱗右_鱗2_表示 = value;
				this.尾31_鱗左_鱗2_表示 = value;
				this.尾31_鱗右_鱗2_表示 = value;
				this.尾30_鱗左_鱗2_表示 = value;
				this.尾30_鱗右_鱗2_表示 = value;
				this.尾29_鱗左_鱗2_表示 = value;
				this.尾29_鱗右_鱗2_表示 = value;
				this.尾28_鱗左_鱗2_表示 = value;
				this.尾28_鱗右_鱗2_表示 = value;
				this.尾27_鱗左_鱗2_表示 = value;
				this.尾27_鱗右_鱗2_表示 = value;
				this.尾26_鱗左_鱗2_表示 = value;
				this.尾26_鱗右_鱗2_表示 = value;
				this.尾25_鱗左_鱗2_表示 = value;
				this.尾25_鱗右_鱗2_表示 = value;
				this.尾24_鱗左_鱗2_表示 = value;
				this.尾24_鱗右_鱗2_表示 = value;
				this.尾23_鱗左_鱗2_表示 = value;
				this.尾23_鱗右_鱗2_表示 = value;
				this.尾22_鱗左_鱗2_表示 = value;
				this.尾22_鱗右_鱗2_表示 = value;
				this.尾21_鱗左_鱗2_表示 = value;
				this.尾21_鱗右_鱗2_表示 = value;
				this.尾20_鱗左_鱗2_表示 = value;
				this.尾20_鱗右_鱗2_表示 = value;
				this.尾19_鱗左_鱗2_表示 = value;
				this.尾19_鱗右_鱗2_表示 = value;
				this.尾18_鱗左_鱗2_表示 = value;
				this.尾18_鱗右_鱗2_表示 = value;
				this.尾17_鱗左_鱗2_表示 = value;
				this.尾17_鱗右_鱗2_表示 = value;
				this.尾16_鱗左_鱗2_表示 = value;
				this.尾16_鱗右_鱗2_表示 = value;
				this.尾15_鱗左_鱗2_表示 = value;
				this.尾15_鱗右_鱗2_表示 = value;
				this.尾14_鱗左_鱗2_表示 = value;
				this.尾14_鱗右_鱗2_表示 = value;
				this.尾13_鱗左_鱗2_表示 = value;
				this.尾13_鱗右_鱗2_表示 = value;
				this.尾12_鱗左_鱗2_表示 = value;
				this.尾12_鱗右_鱗2_表示 = value;
				this.尾11_鱗左_鱗2_表示 = value;
				this.尾11_鱗右_鱗2_表示 = value;
				this.尾10_鱗左_鱗2_表示 = value;
				this.尾10_鱗右_鱗2_表示 = value;
				this.尾9_鱗左_鱗2_表示 = value;
				this.尾9_鱗右_鱗2_表示 = value;
				this.尾8_鱗左_鱗2_表示 = value;
				this.尾8_鱗右_鱗2_表示 = value;
				this.尾7_鱗左_鱗2_表示 = value;
				this.尾7_鱗右_鱗2_表示 = value;
				this.尾6_鱗左_鱗2_表示 = value;
				this.尾6_鱗右_鱗2_表示 = value;
				this.尾5_鱗左_鱗2_表示 = value;
				this.尾5_鱗右_鱗2_表示 = value;
				this.尾4_鱗左_鱗2_表示 = value;
				this.尾4_鱗右_鱗2_表示 = value;
				this.尾3_鱗左_鱗2_表示 = value;
				this.尾3_鱗右_鱗2_表示 = value;
				this.尾2_鱗左_鱗2_表示 = value;
				this.尾2_鱗右_鱗2_表示 = value;
				this.尾1_鱗左_鱗2_表示 = value;
				this.尾1_鱗右_鱗2_表示 = value;
				this.尾0_鱗左_鱗2_表示 = value;
				this.尾0_鱗右_鱗2_表示 = value;
			}
		}

		public bool 鱗3
		{
			get
			{
				return this.尾33_鱗左_鱗3_表示;
			}
			set
			{
				this.尾33_鱗左_鱗3_表示 = value;
				this.尾33_鱗右_鱗3_表示 = value;
				this.尾32_鱗左_鱗3_表示 = value;
				this.尾32_鱗右_鱗3_表示 = value;
				this.尾31_鱗左_鱗3_表示 = value;
				this.尾31_鱗右_鱗3_表示 = value;
				this.尾30_鱗左_鱗3_表示 = value;
				this.尾30_鱗右_鱗3_表示 = value;
				this.尾29_鱗左_鱗3_表示 = value;
				this.尾29_鱗右_鱗3_表示 = value;
				this.尾28_鱗左_鱗3_表示 = value;
				this.尾28_鱗右_鱗3_表示 = value;
				this.尾27_鱗左_鱗3_表示 = value;
				this.尾27_鱗右_鱗3_表示 = value;
				this.尾26_鱗左_鱗3_表示 = value;
				this.尾26_鱗右_鱗3_表示 = value;
				this.尾25_鱗左_鱗3_表示 = value;
				this.尾25_鱗右_鱗3_表示 = value;
				this.尾24_鱗左_鱗3_表示 = value;
				this.尾24_鱗右_鱗3_表示 = value;
				this.尾23_鱗左_鱗3_表示 = value;
				this.尾23_鱗右_鱗3_表示 = value;
				this.尾22_鱗左_鱗3_表示 = value;
				this.尾22_鱗右_鱗3_表示 = value;
				this.尾21_鱗左_鱗3_表示 = value;
				this.尾21_鱗右_鱗3_表示 = value;
				this.尾20_鱗左_鱗3_表示 = value;
				this.尾20_鱗右_鱗3_表示 = value;
				this.尾19_鱗左_鱗3_表示 = value;
				this.尾19_鱗右_鱗3_表示 = value;
				this.尾18_鱗左_鱗3_表示 = value;
				this.尾18_鱗右_鱗3_表示 = value;
				this.尾17_鱗左_鱗3_表示 = value;
				this.尾17_鱗右_鱗3_表示 = value;
				this.尾16_鱗左_鱗3_表示 = value;
				this.尾16_鱗右_鱗3_表示 = value;
				this.尾15_鱗左_鱗3_表示 = value;
				this.尾15_鱗右_鱗3_表示 = value;
				this.尾14_鱗左_鱗3_表示 = value;
				this.尾14_鱗右_鱗3_表示 = value;
				this.尾13_鱗左_鱗3_表示 = value;
				this.尾13_鱗右_鱗3_表示 = value;
				this.尾12_鱗左_鱗3_表示 = value;
				this.尾12_鱗右_鱗3_表示 = value;
				this.尾11_鱗左_鱗3_表示 = value;
				this.尾11_鱗右_鱗3_表示 = value;
				this.尾10_鱗左_鱗3_表示 = value;
				this.尾10_鱗右_鱗3_表示 = value;
				this.尾9_鱗左_鱗3_表示 = value;
				this.尾9_鱗右_鱗3_表示 = value;
				this.尾8_鱗左_鱗3_表示 = value;
				this.尾8_鱗右_鱗3_表示 = value;
				this.尾7_鱗左_鱗3_表示 = value;
				this.尾7_鱗右_鱗3_表示 = value;
				this.尾6_鱗左_鱗3_表示 = value;
				this.尾6_鱗右_鱗3_表示 = value;
				this.尾5_鱗左_鱗3_表示 = value;
				this.尾5_鱗右_鱗3_表示 = value;
				this.尾4_鱗左_鱗3_表示 = value;
				this.尾4_鱗右_鱗3_表示 = value;
				this.尾3_鱗左_鱗3_表示 = value;
				this.尾3_鱗右_鱗3_表示 = value;
				this.尾2_鱗左_鱗3_表示 = value;
				this.尾2_鱗右_鱗3_表示 = value;
				this.尾1_鱗左_鱗3_表示 = value;
				this.尾1_鱗右_鱗3_表示 = value;
				this.尾0_鱗左_鱗3_表示 = value;
				this.尾0_鱗右_鱗3_表示 = value;
			}
		}

		public bool 鱗4
		{
			get
			{
				return this.尾32_鱗左_鱗4_表示;
			}
			set
			{
				this.尾32_鱗左_鱗4_表示 = value;
				this.尾32_鱗右_鱗4_表示 = value;
				this.尾31_鱗左_鱗4_表示 = value;
				this.尾31_鱗右_鱗4_表示 = value;
				this.尾30_鱗左_鱗4_表示 = value;
				this.尾30_鱗右_鱗4_表示 = value;
				this.尾29_鱗左_鱗4_表示 = value;
				this.尾29_鱗右_鱗4_表示 = value;
				this.尾28_鱗左_鱗4_表示 = value;
				this.尾28_鱗右_鱗4_表示 = value;
				this.尾27_鱗左_鱗4_表示 = value;
				this.尾27_鱗右_鱗4_表示 = value;
				this.尾26_鱗左_鱗4_表示 = value;
				this.尾26_鱗右_鱗4_表示 = value;
				this.尾25_鱗左_鱗4_表示 = value;
				this.尾25_鱗右_鱗4_表示 = value;
				this.尾24_鱗左_鱗4_表示 = value;
				this.尾24_鱗右_鱗4_表示 = value;
				this.尾23_鱗左_鱗4_表示 = value;
				this.尾23_鱗右_鱗4_表示 = value;
				this.尾22_鱗左_鱗4_表示 = value;
				this.尾22_鱗右_鱗4_表示 = value;
				this.尾21_鱗左_鱗4_表示 = value;
				this.尾21_鱗右_鱗4_表示 = value;
				this.尾20_鱗左_鱗4_表示 = value;
				this.尾20_鱗右_鱗4_表示 = value;
				this.尾19_鱗左_鱗4_表示 = value;
				this.尾19_鱗右_鱗4_表示 = value;
				this.尾18_鱗左_鱗4_表示 = value;
				this.尾18_鱗右_鱗4_表示 = value;
				this.尾17_鱗左_鱗4_表示 = value;
				this.尾17_鱗右_鱗4_表示 = value;
				this.尾16_鱗左_鱗4_表示 = value;
				this.尾16_鱗右_鱗4_表示 = value;
				this.尾15_鱗左_鱗4_表示 = value;
				this.尾15_鱗右_鱗4_表示 = value;
				this.尾14_鱗左_鱗4_表示 = value;
				this.尾14_鱗右_鱗4_表示 = value;
				this.尾13_鱗左_鱗4_表示 = value;
				this.尾13_鱗右_鱗4_表示 = value;
				this.尾12_鱗左_鱗4_表示 = value;
				this.尾12_鱗右_鱗4_表示 = value;
				this.尾11_鱗左_鱗4_表示 = value;
				this.尾11_鱗右_鱗4_表示 = value;
				this.尾10_鱗左_鱗4_表示 = value;
				this.尾10_鱗右_鱗4_表示 = value;
				this.尾9_鱗左_鱗4_表示 = value;
				this.尾9_鱗右_鱗4_表示 = value;
				this.尾8_鱗左_鱗4_表示 = value;
				this.尾8_鱗右_鱗4_表示 = value;
				this.尾7_鱗左_鱗4_表示 = value;
				this.尾7_鱗右_鱗4_表示 = value;
				this.尾6_鱗左_鱗4_表示 = value;
				this.尾6_鱗右_鱗4_表示 = value;
				this.尾5_鱗左_鱗4_表示 = value;
				this.尾5_鱗右_鱗4_表示 = value;
				this.尾4_鱗左_鱗4_表示 = value;
				this.尾4_鱗右_鱗4_表示 = value;
				this.尾3_鱗左_鱗4_表示 = value;
				this.尾3_鱗右_鱗4_表示 = value;
				this.尾2_鱗左_鱗4_表示 = value;
				this.尾2_鱗右_鱗4_表示 = value;
				this.尾1_鱗左_鱗4_表示 = value;
				this.尾1_鱗右_鱗4_表示 = value;
				this.尾0_鱗左_鱗4_表示 = value;
				this.尾0_鱗右_鱗4_表示 = value;
			}
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_輪_革 || p == this.X0Y0_輪_金具1 || p == this.X0Y0_輪_金具2 || p == this.X0Y0_輪_金具3 || p == this.X0Y0_輪_金具左 || p == this.X0Y0_輪_金具右;
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
			yield break;
		}

		public JointS 左1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾0_尾, 0);
			}
		}

		public JointS 右1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾0_尾, 1);
			}
		}

		public JointS 左2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾1_尾, 0);
			}
		}

		public JointS 右2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾1_尾, 1);
			}
		}

		public JointS 左3_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾2_尾, 0);
			}
		}

		public JointS 右3_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾2_尾, 1);
			}
		}

		public JointS 左4_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾3_尾, 0);
			}
		}

		public JointS 右4_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾3_尾, 1);
			}
		}

		public JointS 左5_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾4_尾, 0);
			}
		}

		public JointS 右5_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾4_尾, 1);
			}
		}

		public JointS 左6_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾5_尾, 0);
			}
		}

		public JointS 右6_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾5_尾, 1);
			}
		}

		public JointS 左7_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾6_尾, 0);
			}
		}

		public JointS 右7_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾6_尾, 1);
			}
		}

		public JointS 左8_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾7_尾, 0);
			}
		}

		public JointS 右8_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾7_尾, 1);
			}
		}

		public JointS 左9_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾8_尾, 0);
			}
		}

		public JointS 右9_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾8_尾, 1);
			}
		}

		public JointS 左10_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾9_尾, 0);
			}
		}

		public JointS 右10_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾9_尾, 1);
			}
		}

		public JointS 左11_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾10_尾, 0);
			}
		}

		public JointS 右11_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾10_尾, 1);
			}
		}

		public JointS 左12_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾11_尾, 0);
			}
		}

		public JointS 右12_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾11_尾, 1);
			}
		}

		public JointS 左13_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾12_尾, 0);
			}
		}

		public JointS 右13_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾12_尾, 1);
			}
		}

		public JointS 左14_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾13_尾, 0);
			}
		}

		public JointS 右14_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾13_尾, 1);
			}
		}

		public JointS 左15_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾14_尾, 0);
			}
		}

		public JointS 右15_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾14_尾, 1);
			}
		}

		public JointS 左16_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾15_尾, 0);
			}
		}

		public JointS 右16_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾15_尾, 1);
			}
		}

		public JointS 左17_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾16_尾, 0);
			}
		}

		public JointS 右17_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾16_尾, 1);
			}
		}

		public JointS 左18_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾17_尾, 0);
			}
		}

		public JointS 右18_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾17_尾, 1);
			}
		}

		public JointS 左19_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾18_尾, 0);
			}
		}

		public JointS 右19_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾18_尾, 1);
			}
		}

		public JointS 左20_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾19_尾, 0);
			}
		}

		public JointS 右20_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾19_尾, 1);
			}
		}

		public JointS 左21_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾20_尾, 0);
			}
		}

		public JointS 右21_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾20_尾, 1);
			}
		}

		public JointS 左22_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾21_尾, 0);
			}
		}

		public JointS 右22_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾21_尾, 1);
			}
		}

		public JointS 左23_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾22_尾, 0);
			}
		}

		public JointS 右23_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾22_尾, 1);
			}
		}

		public JointS 左24_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾23_尾, 0);
			}
		}

		public JointS 右24_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾23_尾, 1);
			}
		}

		public JointS 左25_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾24_尾, 0);
			}
		}

		public JointS 右25_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾24_尾, 1);
			}
		}

		public JointS 左26_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾25_尾, 0);
			}
		}

		public JointS 右26_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾25_尾, 1);
			}
		}

		public JointS 左27_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾26_尾, 0);
			}
		}

		public JointS 右27_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾26_尾, 1);
			}
		}

		public JointS 左28_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾27_尾, 0);
			}
		}

		public JointS 右28_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾27_尾, 1);
			}
		}

		public JointS 左29_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾28_尾, 0);
			}
		}

		public JointS 右29_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾28_尾, 1);
			}
		}

		public JointS 左30_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾29_尾, 0);
			}
		}

		public JointS 右30_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾29_尾, 1);
			}
		}

		public JointS 左31_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾30_尾, 0);
			}
		}

		public JointS 右31_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾30_尾, 1);
			}
		}

		public JointS 左32_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾31_尾, 0);
			}
		}

		public JointS 右32_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾31_尾, 1);
			}
		}

		public JointS 左33_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾32_尾, 0);
			}
		}

		public JointS 右33_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾32_尾, 1);
			}
		}

		public JointS 左34_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾33_尾, 0);
			}
		}

		public JointS 右34_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾33_尾, 1);
			}
		}

		public JointS 尾先_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_尾13_尾, 2);
			}
		}

		public JointS 鎖1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_輪_金具左, 0);
			}
		}

		public JointS 鎖2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_輪_金具右, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_尾33_鱗左_鱗1CP.Update();
			this.X0Y0_尾33_鱗左_鱗3CP.Update();
			this.X0Y0_尾33_鱗右_鱗1CP.Update();
			this.X0Y0_尾33_鱗右_鱗3CP.Update();
			this.X0Y0_尾33_尾CP.Update();
			this.X0Y0_尾32_鱗左_鱗1CP.Update();
			this.X0Y0_尾32_鱗左_鱗2CP.Update();
			this.X0Y0_尾32_鱗左_鱗3CP.Update();
			this.X0Y0_尾32_鱗左_鱗4CP.Update();
			this.X0Y0_尾32_鱗右_鱗1CP.Update();
			this.X0Y0_尾32_鱗右_鱗2CP.Update();
			this.X0Y0_尾32_鱗右_鱗3CP.Update();
			this.X0Y0_尾32_鱗右_鱗4CP.Update();
			this.X0Y0_尾32_尾CP.Update();
			this.X0Y0_尾31_鱗左_鱗1CP.Update();
			this.X0Y0_尾31_鱗左_鱗2CP.Update();
			this.X0Y0_尾31_鱗左_鱗3CP.Update();
			this.X0Y0_尾31_鱗左_鱗4CP.Update();
			this.X0Y0_尾31_鱗右_鱗1CP.Update();
			this.X0Y0_尾31_鱗右_鱗2CP.Update();
			this.X0Y0_尾31_鱗右_鱗3CP.Update();
			this.X0Y0_尾31_鱗右_鱗4CP.Update();
			this.X0Y0_尾31_尾CP.Update();
			this.X0Y0_尾30_鱗左_鱗1CP.Update();
			this.X0Y0_尾30_鱗左_鱗2CP.Update();
			this.X0Y0_尾30_鱗左_鱗3CP.Update();
			this.X0Y0_尾30_鱗左_鱗4CP.Update();
			this.X0Y0_尾30_鱗右_鱗1CP.Update();
			this.X0Y0_尾30_鱗右_鱗2CP.Update();
			this.X0Y0_尾30_鱗右_鱗3CP.Update();
			this.X0Y0_尾30_鱗右_鱗4CP.Update();
			this.X0Y0_尾30_尾CP.Update();
			this.X0Y0_尾29_鱗左_鱗1CP.Update();
			this.X0Y0_尾29_鱗左_鱗2CP.Update();
			this.X0Y0_尾29_鱗左_鱗3CP.Update();
			this.X0Y0_尾29_鱗左_鱗4CP.Update();
			this.X0Y0_尾29_鱗右_鱗1CP.Update();
			this.X0Y0_尾29_鱗右_鱗2CP.Update();
			this.X0Y0_尾29_鱗右_鱗3CP.Update();
			this.X0Y0_尾29_鱗右_鱗4CP.Update();
			this.X0Y0_尾29_尾CP.Update();
			this.X0Y0_尾28_鱗左_鱗1CP.Update();
			this.X0Y0_尾28_鱗左_鱗2CP.Update();
			this.X0Y0_尾28_鱗左_鱗3CP.Update();
			this.X0Y0_尾28_鱗左_鱗4CP.Update();
			this.X0Y0_尾28_鱗右_鱗1CP.Update();
			this.X0Y0_尾28_鱗右_鱗2CP.Update();
			this.X0Y0_尾28_鱗右_鱗3CP.Update();
			this.X0Y0_尾28_鱗右_鱗4CP.Update();
			this.X0Y0_尾28_尾CP.Update();
			this.X0Y0_尾27_鱗左_鱗1CP.Update();
			this.X0Y0_尾27_鱗左_鱗2CP.Update();
			this.X0Y0_尾27_鱗左_鱗3CP.Update();
			this.X0Y0_尾27_鱗左_鱗4CP.Update();
			this.X0Y0_尾27_鱗右_鱗1CP.Update();
			this.X0Y0_尾27_鱗右_鱗2CP.Update();
			this.X0Y0_尾27_鱗右_鱗3CP.Update();
			this.X0Y0_尾27_鱗右_鱗4CP.Update();
			this.X0Y0_尾27_尾CP.Update();
			this.X0Y0_尾26_鱗左_鱗1CP.Update();
			this.X0Y0_尾26_鱗左_鱗2CP.Update();
			this.X0Y0_尾26_鱗左_鱗3CP.Update();
			this.X0Y0_尾26_鱗左_鱗4CP.Update();
			this.X0Y0_尾26_鱗右_鱗1CP.Update();
			this.X0Y0_尾26_鱗右_鱗2CP.Update();
			this.X0Y0_尾26_鱗右_鱗3CP.Update();
			this.X0Y0_尾26_鱗右_鱗4CP.Update();
			this.X0Y0_尾26_尾CP.Update();
			this.X0Y0_尾25_鱗左_鱗1CP.Update();
			this.X0Y0_尾25_鱗左_鱗2CP.Update();
			this.X0Y0_尾25_鱗左_鱗3CP.Update();
			this.X0Y0_尾25_鱗左_鱗4CP.Update();
			this.X0Y0_尾25_鱗右_鱗1CP.Update();
			this.X0Y0_尾25_鱗右_鱗2CP.Update();
			this.X0Y0_尾25_鱗右_鱗3CP.Update();
			this.X0Y0_尾25_鱗右_鱗4CP.Update();
			this.X0Y0_尾25_尾CP.Update();
			this.X0Y0_尾24_鱗左_鱗1CP.Update();
			this.X0Y0_尾24_鱗左_鱗2CP.Update();
			this.X0Y0_尾24_鱗左_鱗3CP.Update();
			this.X0Y0_尾24_鱗左_鱗4CP.Update();
			this.X0Y0_尾24_鱗右_鱗1CP.Update();
			this.X0Y0_尾24_鱗右_鱗2CP.Update();
			this.X0Y0_尾24_鱗右_鱗3CP.Update();
			this.X0Y0_尾24_鱗右_鱗4CP.Update();
			this.X0Y0_尾24_尾CP.Update();
			this.X0Y0_尾23_鱗左_鱗1CP.Update();
			this.X0Y0_尾23_鱗左_鱗2CP.Update();
			this.X0Y0_尾23_鱗左_鱗3CP.Update();
			this.X0Y0_尾23_鱗左_鱗4CP.Update();
			this.X0Y0_尾23_鱗右_鱗1CP.Update();
			this.X0Y0_尾23_鱗右_鱗2CP.Update();
			this.X0Y0_尾23_鱗右_鱗3CP.Update();
			this.X0Y0_尾23_鱗右_鱗4CP.Update();
			this.X0Y0_尾23_尾CP.Update();
			this.X0Y0_尾22_鱗左_鱗1CP.Update();
			this.X0Y0_尾22_鱗左_鱗2CP.Update();
			this.X0Y0_尾22_鱗左_鱗3CP.Update();
			this.X0Y0_尾22_鱗左_鱗4CP.Update();
			this.X0Y0_尾22_鱗右_鱗1CP.Update();
			this.X0Y0_尾22_鱗右_鱗2CP.Update();
			this.X0Y0_尾22_鱗右_鱗3CP.Update();
			this.X0Y0_尾22_鱗右_鱗4CP.Update();
			this.X0Y0_尾22_尾CP.Update();
			this.X0Y0_尾21_鱗左_鱗1CP.Update();
			this.X0Y0_尾21_鱗左_鱗2CP.Update();
			this.X0Y0_尾21_鱗左_鱗3CP.Update();
			this.X0Y0_尾21_鱗左_鱗4CP.Update();
			this.X0Y0_尾21_鱗右_鱗1CP.Update();
			this.X0Y0_尾21_鱗右_鱗2CP.Update();
			this.X0Y0_尾21_鱗右_鱗3CP.Update();
			this.X0Y0_尾21_鱗右_鱗4CP.Update();
			this.X0Y0_尾21_尾CP.Update();
			this.X0Y0_尾20_鱗左_鱗1CP.Update();
			this.X0Y0_尾20_鱗左_鱗2CP.Update();
			this.X0Y0_尾20_鱗左_鱗3CP.Update();
			this.X0Y0_尾20_鱗左_鱗4CP.Update();
			this.X0Y0_尾20_鱗右_鱗1CP.Update();
			this.X0Y0_尾20_鱗右_鱗2CP.Update();
			this.X0Y0_尾20_鱗右_鱗3CP.Update();
			this.X0Y0_尾20_鱗右_鱗4CP.Update();
			this.X0Y0_尾20_尾CP.Update();
			this.X0Y0_尾19_鱗左_鱗1CP.Update();
			this.X0Y0_尾19_鱗左_鱗2CP.Update();
			this.X0Y0_尾19_鱗左_鱗3CP.Update();
			this.X0Y0_尾19_鱗左_鱗4CP.Update();
			this.X0Y0_尾19_鱗右_鱗1CP.Update();
			this.X0Y0_尾19_鱗右_鱗2CP.Update();
			this.X0Y0_尾19_鱗右_鱗3CP.Update();
			this.X0Y0_尾19_鱗右_鱗4CP.Update();
			this.X0Y0_尾19_尾CP.Update();
			this.X0Y0_尾18_鱗左_鱗1CP.Update();
			this.X0Y0_尾18_鱗左_鱗2CP.Update();
			this.X0Y0_尾18_鱗左_鱗3CP.Update();
			this.X0Y0_尾18_鱗左_鱗4CP.Update();
			this.X0Y0_尾18_鱗右_鱗1CP.Update();
			this.X0Y0_尾18_鱗右_鱗2CP.Update();
			this.X0Y0_尾18_鱗右_鱗3CP.Update();
			this.X0Y0_尾18_鱗右_鱗4CP.Update();
			this.X0Y0_尾18_尾CP.Update();
			this.X0Y0_尾17_鱗左_鱗1CP.Update();
			this.X0Y0_尾17_鱗左_鱗2CP.Update();
			this.X0Y0_尾17_鱗左_鱗3CP.Update();
			this.X0Y0_尾17_鱗左_鱗4CP.Update();
			this.X0Y0_尾17_鱗右_鱗1CP.Update();
			this.X0Y0_尾17_鱗右_鱗2CP.Update();
			this.X0Y0_尾17_鱗右_鱗3CP.Update();
			this.X0Y0_尾17_鱗右_鱗4CP.Update();
			this.X0Y0_尾17_尾CP.Update();
			this.X0Y0_尾16_鱗左_鱗1CP.Update();
			this.X0Y0_尾16_鱗左_鱗2CP.Update();
			this.X0Y0_尾16_鱗左_鱗3CP.Update();
			this.X0Y0_尾16_鱗左_鱗4CP.Update();
			this.X0Y0_尾16_鱗右_鱗1CP.Update();
			this.X0Y0_尾16_鱗右_鱗2CP.Update();
			this.X0Y0_尾16_鱗右_鱗3CP.Update();
			this.X0Y0_尾16_鱗右_鱗4CP.Update();
			this.X0Y0_尾16_尾CP.Update();
			this.X0Y0_尾15_鱗左_鱗1CP.Update();
			this.X0Y0_尾15_鱗左_鱗2CP.Update();
			this.X0Y0_尾15_鱗左_鱗3CP.Update();
			this.X0Y0_尾15_鱗左_鱗4CP.Update();
			this.X0Y0_尾15_鱗右_鱗1CP.Update();
			this.X0Y0_尾15_鱗右_鱗2CP.Update();
			this.X0Y0_尾15_鱗右_鱗3CP.Update();
			this.X0Y0_尾15_鱗右_鱗4CP.Update();
			this.X0Y0_尾15_尾CP.Update();
			this.X0Y0_尾14_鱗左_鱗1CP.Update();
			this.X0Y0_尾14_鱗左_鱗2CP.Update();
			this.X0Y0_尾14_鱗左_鱗3CP.Update();
			this.X0Y0_尾14_鱗左_鱗4CP.Update();
			this.X0Y0_尾14_鱗右_鱗1CP.Update();
			this.X0Y0_尾14_鱗右_鱗2CP.Update();
			this.X0Y0_尾14_鱗右_鱗3CP.Update();
			this.X0Y0_尾14_鱗右_鱗4CP.Update();
			this.X0Y0_尾14_尾CP.Update();
			this.X0Y0_尾13_鱗左_鱗1CP.Update();
			this.X0Y0_尾13_鱗左_鱗2CP.Update();
			this.X0Y0_尾13_鱗左_鱗3CP.Update();
			this.X0Y0_尾13_鱗左_鱗4CP.Update();
			this.X0Y0_尾13_鱗右_鱗1CP.Update();
			this.X0Y0_尾13_鱗右_鱗2CP.Update();
			this.X0Y0_尾13_鱗右_鱗3CP.Update();
			this.X0Y0_尾13_鱗右_鱗4CP.Update();
			this.X0Y0_尾13_尾CP.Update();
			this.X0Y0_尾12_鱗左_鱗1CP.Update();
			this.X0Y0_尾12_鱗左_鱗2CP.Update();
			this.X0Y0_尾12_鱗左_鱗3CP.Update();
			this.X0Y0_尾12_鱗左_鱗4CP.Update();
			this.X0Y0_尾12_鱗右_鱗1CP.Update();
			this.X0Y0_尾12_鱗右_鱗2CP.Update();
			this.X0Y0_尾12_鱗右_鱗3CP.Update();
			this.X0Y0_尾12_鱗右_鱗4CP.Update();
			this.X0Y0_尾12_尾CP.Update();
			this.X0Y0_尾11_鱗左_鱗1CP.Update();
			this.X0Y0_尾11_鱗左_鱗2CP.Update();
			this.X0Y0_尾11_鱗左_鱗3CP.Update();
			this.X0Y0_尾11_鱗左_鱗4CP.Update();
			this.X0Y0_尾11_鱗右_鱗1CP.Update();
			this.X0Y0_尾11_鱗右_鱗2CP.Update();
			this.X0Y0_尾11_鱗右_鱗3CP.Update();
			this.X0Y0_尾11_鱗右_鱗4CP.Update();
			this.X0Y0_尾11_尾CP.Update();
			this.X0Y0_尾10_鱗左_鱗1CP.Update();
			this.X0Y0_尾10_鱗左_鱗2CP.Update();
			this.X0Y0_尾10_鱗左_鱗3CP.Update();
			this.X0Y0_尾10_鱗左_鱗4CP.Update();
			this.X0Y0_尾10_鱗右_鱗1CP.Update();
			this.X0Y0_尾10_鱗右_鱗2CP.Update();
			this.X0Y0_尾10_鱗右_鱗3CP.Update();
			this.X0Y0_尾10_鱗右_鱗4CP.Update();
			this.X0Y0_尾10_尾CP.Update();
			this.X0Y0_尾9_鱗左_鱗1CP.Update();
			this.X0Y0_尾9_鱗左_鱗2CP.Update();
			this.X0Y0_尾9_鱗左_鱗3CP.Update();
			this.X0Y0_尾9_鱗左_鱗4CP.Update();
			this.X0Y0_尾9_鱗右_鱗1CP.Update();
			this.X0Y0_尾9_鱗右_鱗2CP.Update();
			this.X0Y0_尾9_鱗右_鱗3CP.Update();
			this.X0Y0_尾9_鱗右_鱗4CP.Update();
			this.X0Y0_尾9_尾CP.Update();
			this.X0Y0_尾8_鱗左_鱗1CP.Update();
			this.X0Y0_尾8_鱗左_鱗2CP.Update();
			this.X0Y0_尾8_鱗左_鱗3CP.Update();
			this.X0Y0_尾8_鱗左_鱗4CP.Update();
			this.X0Y0_尾8_鱗右_鱗1CP.Update();
			this.X0Y0_尾8_鱗右_鱗2CP.Update();
			this.X0Y0_尾8_鱗右_鱗3CP.Update();
			this.X0Y0_尾8_鱗右_鱗4CP.Update();
			this.X0Y0_尾8_尾CP.Update();
			this.X0Y0_尾7_鱗左_鱗1CP.Update();
			this.X0Y0_尾7_鱗左_鱗2CP.Update();
			this.X0Y0_尾7_鱗左_鱗3CP.Update();
			this.X0Y0_尾7_鱗左_鱗4CP.Update();
			this.X0Y0_尾7_鱗右_鱗1CP.Update();
			this.X0Y0_尾7_鱗右_鱗2CP.Update();
			this.X0Y0_尾7_鱗右_鱗3CP.Update();
			this.X0Y0_尾7_鱗右_鱗4CP.Update();
			this.X0Y0_尾7_尾CP.Update();
			this.X0Y0_尾6_鱗左_鱗1CP.Update();
			this.X0Y0_尾6_鱗左_鱗2CP.Update();
			this.X0Y0_尾6_鱗左_鱗3CP.Update();
			this.X0Y0_尾6_鱗左_鱗4CP.Update();
			this.X0Y0_尾6_鱗右_鱗1CP.Update();
			this.X0Y0_尾6_鱗右_鱗2CP.Update();
			this.X0Y0_尾6_鱗右_鱗3CP.Update();
			this.X0Y0_尾6_鱗右_鱗4CP.Update();
			this.X0Y0_尾6_尾CP.Update();
			this.X0Y0_尾5_鱗左_鱗1CP.Update();
			this.X0Y0_尾5_鱗左_鱗2CP.Update();
			this.X0Y0_尾5_鱗左_鱗3CP.Update();
			this.X0Y0_尾5_鱗左_鱗4CP.Update();
			this.X0Y0_尾5_鱗右_鱗1CP.Update();
			this.X0Y0_尾5_鱗右_鱗2CP.Update();
			this.X0Y0_尾5_鱗右_鱗3CP.Update();
			this.X0Y0_尾5_鱗右_鱗4CP.Update();
			this.X0Y0_尾5_尾CP.Update();
			this.X0Y0_尾4_鱗左_鱗1CP.Update();
			this.X0Y0_尾4_鱗左_鱗2CP.Update();
			this.X0Y0_尾4_鱗左_鱗3CP.Update();
			this.X0Y0_尾4_鱗左_鱗4CP.Update();
			this.X0Y0_尾4_鱗右_鱗1CP.Update();
			this.X0Y0_尾4_鱗右_鱗2CP.Update();
			this.X0Y0_尾4_鱗右_鱗3CP.Update();
			this.X0Y0_尾4_鱗右_鱗4CP.Update();
			this.X0Y0_尾4_尾CP.Update();
			this.X0Y0_輪_革CP.Update();
			this.X0Y0_輪_金具1CP.Update();
			this.X0Y0_輪_金具2CP.Update();
			this.X0Y0_輪_金具3CP.Update();
			this.X0Y0_輪_金具左CP.Update();
			this.X0Y0_輪_金具右CP.Update();
			this.X0Y0_尾3_鱗左_鱗1CP.Update();
			this.X0Y0_尾3_鱗左_鱗2CP.Update();
			this.X0Y0_尾3_鱗左_鱗3CP.Update();
			this.X0Y0_尾3_鱗左_鱗4CP.Update();
			this.X0Y0_尾3_鱗右_鱗1CP.Update();
			this.X0Y0_尾3_鱗右_鱗2CP.Update();
			this.X0Y0_尾3_鱗右_鱗3CP.Update();
			this.X0Y0_尾3_鱗右_鱗4CP.Update();
			this.X0Y0_尾3_尾CP.Update();
			this.X0Y0_尾2_鱗左_鱗1CP.Update();
			this.X0Y0_尾2_鱗左_鱗2CP.Update();
			this.X0Y0_尾2_鱗左_鱗3CP.Update();
			this.X0Y0_尾2_鱗左_鱗4CP.Update();
			this.X0Y0_尾2_鱗右_鱗1CP.Update();
			this.X0Y0_尾2_鱗右_鱗2CP.Update();
			this.X0Y0_尾2_鱗右_鱗3CP.Update();
			this.X0Y0_尾2_鱗右_鱗4CP.Update();
			this.X0Y0_尾2_尾CP.Update();
			this.X0Y0_尾1_鱗左_鱗1CP.Update();
			this.X0Y0_尾1_鱗左_鱗2CP.Update();
			this.X0Y0_尾1_鱗左_鱗3CP.Update();
			this.X0Y0_尾1_鱗左_鱗4CP.Update();
			this.X0Y0_尾1_鱗右_鱗1CP.Update();
			this.X0Y0_尾1_鱗右_鱗2CP.Update();
			this.X0Y0_尾1_鱗右_鱗3CP.Update();
			this.X0Y0_尾1_鱗右_鱗4CP.Update();
			this.X0Y0_尾1_尾CP.Update();
			this.X0Y0_尾0_鱗左_鱗1CP.Update();
			this.X0Y0_尾0_鱗左_鱗2CP.Update();
			this.X0Y0_尾0_鱗左_鱗3CP.Update();
			this.X0Y0_尾0_鱗左_鱗4CP.Update();
			this.X0Y0_尾0_鱗右_鱗1CP.Update();
			this.X0Y0_尾0_鱗右_鱗2CP.Update();
			this.X0Y0_尾0_鱗右_鱗3CP.Update();
			this.X0Y0_尾0_鱗右_鱗4CP.Update();
			this.X0Y0_尾0_尾CP.Update();
			this.鎖1.接続PA();
			this.鎖2.接続PA();
			this.鎖1.色更新();
			this.鎖2.色更新();
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
			this.尾33_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾33_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾33_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾33_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾33_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾32_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾32_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾32_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾32_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾32_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾32_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾32_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾32_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾32_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾31_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾31_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾31_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾31_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾31_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾31_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾31_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾31_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾31_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾30_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾30_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾30_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾30_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾30_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾30_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾30_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾30_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾30_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾29_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾29_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾29_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾29_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾29_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾29_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾29_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾29_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾29_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾28_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾28_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾28_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾28_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾28_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾28_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾28_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾28_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾28_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾27_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾27_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾27_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾27_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾27_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾27_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾27_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾27_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾27_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾26_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾26_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾26_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾26_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾26_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾26_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾26_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾26_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾26_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾25_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾25_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾25_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾25_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾25_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾25_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾25_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾25_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾25_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾24_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾24_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾24_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾24_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾24_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾24_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾24_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾24_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾24_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾23_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾23_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾23_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾23_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾23_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾23_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾23_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾23_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾23_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾22_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾22_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾22_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾22_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾22_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾22_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾22_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾22_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾22_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾21_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾21_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾21_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾21_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾21_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾21_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾21_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾21_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾21_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾20_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾20_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾20_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾20_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾20_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾20_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾20_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾20_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾20_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾19_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾19_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾19_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾19_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾19_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾19_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾19_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾19_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾19_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾18_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾18_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾18_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾18_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾18_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾18_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾18_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾18_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾18_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾17_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾17_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾17_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾17_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾17_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾17_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾17_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾17_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾17_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾16_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾16_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾16_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾16_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾16_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾16_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾16_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾16_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾16_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾15_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾15_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾15_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾15_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾15_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾15_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾15_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾15_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾15_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾14_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾14_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾14_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾14_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾14_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾14_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾14_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾14_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾14_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾13_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾13_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾13_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾13_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾13_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾13_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾13_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾13_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾13_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾12_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾12_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾12_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾12_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾12_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾12_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾12_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾12_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾12_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾11_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾11_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾11_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾11_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾11_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾11_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾11_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾11_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾11_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾10_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾10_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾10_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾10_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾10_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾10_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾10_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾10_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾10_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾9_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾9_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾9_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾9_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾9_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾9_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾9_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾9_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾9_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾8_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾8_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾8_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾8_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾8_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾8_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾8_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾8_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾8_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾7_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾7_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾7_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾7_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾7_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾7_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾7_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾7_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾7_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾6_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾6_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾6_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾6_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾6_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾6_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾6_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾6_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾6_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾5_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾5_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾5_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾5_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾5_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾5_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾5_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾5_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾5_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾4_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾4_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾4_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾4_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾4_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾4_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾4_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾4_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾4_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾3_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾3_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾3_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾3_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾3_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾3_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾3_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾3_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾3_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾2_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾2_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾2_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾2_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾2_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾2_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾2_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾2_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾2_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾1_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾1_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾1_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾1_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾1_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾1_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾1_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾1_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾1_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾0_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾0_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾0_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾0_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾0_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾0_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾0_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾0_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾0_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.輪_革CD = new ColorD();
			this.輪_金具1CD = new ColorD();
			this.輪_金具2CD = new ColorD();
			this.輪_金具3CD = new ColorD();
			this.輪_金具左CD = new ColorD();
			this.輪_金具右CD = new ColorD();
		}

		private void 配色T0(体配色 体配色)
		{
			this.尾33_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾33_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾33_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾33_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾33_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾32_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾32_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾32_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾32_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾32_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾32_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾32_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾32_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾32_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾31_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾31_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾31_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾31_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾31_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾31_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾31_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾31_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾31_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾30_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾30_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾30_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾30_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾30_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾30_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾30_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾30_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾30_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾29_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾29_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾29_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾29_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾29_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾29_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾29_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾29_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾29_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾28_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾28_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾28_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾28_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾28_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾28_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾28_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾28_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾28_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾27_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾27_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾27_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾27_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾27_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾27_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾27_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾27_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾27_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾26_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾26_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾26_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾26_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾26_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾26_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾26_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾26_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾26_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾25_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾25_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾25_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾25_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾25_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾25_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾25_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾25_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾25_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾24_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾24_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾24_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾24_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾24_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾24_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾24_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾24_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾24_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾23_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾23_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾23_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾23_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾23_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾23_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾23_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾23_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾23_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾22_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾22_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾22_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾22_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾22_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾22_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾22_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾22_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾22_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾21_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾21_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾21_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾21_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾21_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾21_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾21_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾21_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾21_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾20_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾20_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾20_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾20_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾20_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾20_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾20_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾20_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾20_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾19_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾19_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾19_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾19_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾19_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾19_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾19_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾19_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾19_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾18_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾18_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾18_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾18_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾18_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾18_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾18_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾18_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾18_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾17_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾17_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾17_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾17_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾17_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾17_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾17_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾17_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾17_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾16_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾16_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾16_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾16_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾16_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾16_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾16_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾16_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾16_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾15_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾15_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾15_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾15_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾15_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾15_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾15_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾15_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾15_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾14_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾14_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾14_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾14_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾14_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾14_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾14_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾14_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾14_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾13_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾13_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾13_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾13_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾13_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾13_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾13_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾13_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾13_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾12_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾12_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾12_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾12_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾12_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾12_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾12_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾12_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾12_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾11_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾11_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾11_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾11_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾11_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾11_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾11_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾11_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾11_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾10_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾10_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾10_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾10_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾10_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾10_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾10_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾10_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾10_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾9_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾9_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾9_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾9_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾9_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾9_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾9_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾9_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾9_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾8_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾8_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾8_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾8_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾8_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾8_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾8_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾8_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾8_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾7_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾7_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾7_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾7_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾7_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾7_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾7_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾7_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾7_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾6_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾6_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾6_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾6_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾6_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾6_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾6_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾6_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾6_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾5_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾5_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾5_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾5_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾5_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾5_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾5_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾5_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾5_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾4_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾4_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾4_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾4_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾4_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾4_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾4_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾3_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾3_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾3_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾3_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾3_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾3_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾3_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾2_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾2_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾2_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾2_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾2_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾2_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾2_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾1_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾1_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾1_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾1_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾1_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾1_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾1_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾0_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾0_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾0_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾0_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾0_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾0_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾0_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾0_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾0_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.輪_革CD = new ColorD();
			this.輪_金具1CD = new ColorD();
			this.輪_金具2CD = new ColorD();
			this.輪_金具3CD = new ColorD();
			this.輪_金具左CD = new ColorD();
			this.輪_金具右CD = new ColorD();
		}

		private void 配色T1(体配色 体配色)
		{
			this.尾33_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾33_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾33_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾33_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾33_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾32_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾32_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾32_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾32_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾32_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾32_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾32_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾32_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾32_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾31_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾31_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾31_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾31_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾31_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾31_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾31_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾31_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾31_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾30_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾30_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾30_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾30_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾30_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾30_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾30_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾30_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾30_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾29_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾29_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾29_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾29_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾29_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾29_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾29_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾29_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾29_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾28_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾28_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾28_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾28_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾28_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾28_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾28_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾28_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾28_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾27_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾27_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾27_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾27_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾27_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾27_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾27_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾27_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾27_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾26_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾26_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾26_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾26_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾26_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾26_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾26_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾26_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾26_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾25_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾25_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾25_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾25_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾25_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾25_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾25_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾25_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾25_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾24_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾24_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾24_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾24_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾24_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾24_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾24_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾24_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾24_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾23_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾23_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾23_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾23_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾23_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾23_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾23_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾23_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾23_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾22_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾22_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾22_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾22_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾22_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾22_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾22_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾22_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾22_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾21_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾21_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾21_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾21_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾21_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾21_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾21_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾21_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾21_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾20_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾20_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾20_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾20_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾20_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾20_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾20_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾20_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾20_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾19_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾19_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾19_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾19_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾19_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾19_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾19_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾19_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾19_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾18_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾18_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾18_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾18_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾18_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾18_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾18_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾18_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾18_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾17_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾17_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾17_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾17_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾17_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾17_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾17_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾17_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾17_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾16_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾16_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾16_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾16_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾16_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾16_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾16_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾16_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾16_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾15_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾15_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾15_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾15_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾15_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾15_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾15_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾15_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾15_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾14_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾14_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾14_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾14_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾14_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾14_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾14_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾14_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾14_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾13_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾13_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾13_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾13_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾13_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾13_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾13_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾13_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾13_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾12_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾12_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾12_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾12_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾12_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾12_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾12_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾12_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾12_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾11_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾11_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾11_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾11_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾11_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾11_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾11_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾11_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾11_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾10_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾10_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾10_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾10_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾10_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾10_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾10_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾10_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾10_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾9_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾9_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾9_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾9_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾9_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾9_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾9_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾9_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾9_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾8_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾8_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾8_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾8_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾8_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾8_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾8_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾8_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾8_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾7_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾7_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾7_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾7_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾7_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾7_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾7_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾7_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾7_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾6_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾6_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾6_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾6_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾6_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾6_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾6_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾6_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾6_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾5_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾5_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾5_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾5_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾5_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾5_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾5_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾5_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾5_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾4_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾4_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾4_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾4_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾4_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾4_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾4_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾4_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾3_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾3_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾3_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾3_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾3_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾3_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾3_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾3_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾2_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾2_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾2_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾2_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾2_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾2_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾2_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾2_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾1_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾1_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾1_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾1_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾1_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾1_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾1_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾1_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.尾0_鱗左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾0_鱗左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾0_鱗左_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾0_鱗左_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾0_鱗右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.尾0_鱗右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾0_鱗右_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾0_鱗右_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.尾0_尾CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.輪_革CD = new ColorD();
			this.輪_金具1CD = new ColorD();
			this.輪_金具2CD = new ColorD();
			this.輪_金具3CD = new ColorD();
			this.輪_金具左CD = new ColorD();
			this.輪_金具右CD = new ColorD();
		}

		public void 輪配色(拘束具色 配色)
		{
			this.輪_革CD.色 = 配色.革部色;
			this.輪_金具1CD.色 = 配色.金具色;
			this.輪_金具2CD.色 = this.輪_金具1CD.色;
			this.輪_金具3CD.色 = this.輪_金具1CD.色;
			this.輪_金具左CD.色 = this.輪_金具1CD.色;
			this.輪_金具右CD.色 = this.輪_金具1CD.色;
		}

		public void 鎖配色(鎖色 配色)
		{
			this.鎖1.配色鎖(配色);
			this.鎖2.配色鎖(配色);
		}

		public Par X0Y0_尾33_鱗左_鱗1;

		public Par X0Y0_尾33_鱗左_鱗3;

		public Par X0Y0_尾33_鱗右_鱗1;

		public Par X0Y0_尾33_鱗右_鱗3;

		public Par X0Y0_尾33_尾;

		public Par X0Y0_尾32_鱗左_鱗1;

		public Par X0Y0_尾32_鱗左_鱗2;

		public Par X0Y0_尾32_鱗左_鱗3;

		public Par X0Y0_尾32_鱗左_鱗4;

		public Par X0Y0_尾32_鱗右_鱗1;

		public Par X0Y0_尾32_鱗右_鱗2;

		public Par X0Y0_尾32_鱗右_鱗3;

		public Par X0Y0_尾32_鱗右_鱗4;

		public Par X0Y0_尾32_尾;

		public Par X0Y0_尾31_鱗左_鱗1;

		public Par X0Y0_尾31_鱗左_鱗2;

		public Par X0Y0_尾31_鱗左_鱗3;

		public Par X0Y0_尾31_鱗左_鱗4;

		public Par X0Y0_尾31_鱗右_鱗1;

		public Par X0Y0_尾31_鱗右_鱗2;

		public Par X0Y0_尾31_鱗右_鱗3;

		public Par X0Y0_尾31_鱗右_鱗4;

		public Par X0Y0_尾31_尾;

		public Par X0Y0_尾30_鱗左_鱗1;

		public Par X0Y0_尾30_鱗左_鱗2;

		public Par X0Y0_尾30_鱗左_鱗3;

		public Par X0Y0_尾30_鱗左_鱗4;

		public Par X0Y0_尾30_鱗右_鱗1;

		public Par X0Y0_尾30_鱗右_鱗2;

		public Par X0Y0_尾30_鱗右_鱗3;

		public Par X0Y0_尾30_鱗右_鱗4;

		public Par X0Y0_尾30_尾;

		public Par X0Y0_尾29_鱗左_鱗1;

		public Par X0Y0_尾29_鱗左_鱗2;

		public Par X0Y0_尾29_鱗左_鱗3;

		public Par X0Y0_尾29_鱗左_鱗4;

		public Par X0Y0_尾29_鱗右_鱗1;

		public Par X0Y0_尾29_鱗右_鱗2;

		public Par X0Y0_尾29_鱗右_鱗3;

		public Par X0Y0_尾29_鱗右_鱗4;

		public Par X0Y0_尾29_尾;

		public Par X0Y0_尾28_鱗左_鱗1;

		public Par X0Y0_尾28_鱗左_鱗2;

		public Par X0Y0_尾28_鱗左_鱗3;

		public Par X0Y0_尾28_鱗左_鱗4;

		public Par X0Y0_尾28_鱗右_鱗1;

		public Par X0Y0_尾28_鱗右_鱗2;

		public Par X0Y0_尾28_鱗右_鱗3;

		public Par X0Y0_尾28_鱗右_鱗4;

		public Par X0Y0_尾28_尾;

		public Par X0Y0_尾27_鱗左_鱗1;

		public Par X0Y0_尾27_鱗左_鱗2;

		public Par X0Y0_尾27_鱗左_鱗3;

		public Par X0Y0_尾27_鱗左_鱗4;

		public Par X0Y0_尾27_鱗右_鱗1;

		public Par X0Y0_尾27_鱗右_鱗2;

		public Par X0Y0_尾27_鱗右_鱗3;

		public Par X0Y0_尾27_鱗右_鱗4;

		public Par X0Y0_尾27_尾;

		public Par X0Y0_尾26_鱗左_鱗1;

		public Par X0Y0_尾26_鱗左_鱗2;

		public Par X0Y0_尾26_鱗左_鱗3;

		public Par X0Y0_尾26_鱗左_鱗4;

		public Par X0Y0_尾26_鱗右_鱗1;

		public Par X0Y0_尾26_鱗右_鱗2;

		public Par X0Y0_尾26_鱗右_鱗3;

		public Par X0Y0_尾26_鱗右_鱗4;

		public Par X0Y0_尾26_尾;

		public Par X0Y0_尾25_鱗左_鱗1;

		public Par X0Y0_尾25_鱗左_鱗2;

		public Par X0Y0_尾25_鱗左_鱗3;

		public Par X0Y0_尾25_鱗左_鱗4;

		public Par X0Y0_尾25_鱗右_鱗1;

		public Par X0Y0_尾25_鱗右_鱗2;

		public Par X0Y0_尾25_鱗右_鱗3;

		public Par X0Y0_尾25_鱗右_鱗4;

		public Par X0Y0_尾25_尾;

		public Par X0Y0_尾24_鱗左_鱗1;

		public Par X0Y0_尾24_鱗左_鱗2;

		public Par X0Y0_尾24_鱗左_鱗3;

		public Par X0Y0_尾24_鱗左_鱗4;

		public Par X0Y0_尾24_鱗右_鱗1;

		public Par X0Y0_尾24_鱗右_鱗2;

		public Par X0Y0_尾24_鱗右_鱗3;

		public Par X0Y0_尾24_鱗右_鱗4;

		public Par X0Y0_尾24_尾;

		public Par X0Y0_尾23_鱗左_鱗1;

		public Par X0Y0_尾23_鱗左_鱗2;

		public Par X0Y0_尾23_鱗左_鱗3;

		public Par X0Y0_尾23_鱗左_鱗4;

		public Par X0Y0_尾23_鱗右_鱗1;

		public Par X0Y0_尾23_鱗右_鱗2;

		public Par X0Y0_尾23_鱗右_鱗3;

		public Par X0Y0_尾23_鱗右_鱗4;

		public Par X0Y0_尾23_尾;

		public Par X0Y0_尾22_鱗左_鱗1;

		public Par X0Y0_尾22_鱗左_鱗2;

		public Par X0Y0_尾22_鱗左_鱗3;

		public Par X0Y0_尾22_鱗左_鱗4;

		public Par X0Y0_尾22_鱗右_鱗1;

		public Par X0Y0_尾22_鱗右_鱗2;

		public Par X0Y0_尾22_鱗右_鱗3;

		public Par X0Y0_尾22_鱗右_鱗4;

		public Par X0Y0_尾22_尾;

		public Par X0Y0_尾21_鱗左_鱗1;

		public Par X0Y0_尾21_鱗左_鱗2;

		public Par X0Y0_尾21_鱗左_鱗3;

		public Par X0Y0_尾21_鱗左_鱗4;

		public Par X0Y0_尾21_鱗右_鱗1;

		public Par X0Y0_尾21_鱗右_鱗2;

		public Par X0Y0_尾21_鱗右_鱗3;

		public Par X0Y0_尾21_鱗右_鱗4;

		public Par X0Y0_尾21_尾;

		public Par X0Y0_尾20_鱗左_鱗1;

		public Par X0Y0_尾20_鱗左_鱗2;

		public Par X0Y0_尾20_鱗左_鱗3;

		public Par X0Y0_尾20_鱗左_鱗4;

		public Par X0Y0_尾20_鱗右_鱗1;

		public Par X0Y0_尾20_鱗右_鱗2;

		public Par X0Y0_尾20_鱗右_鱗3;

		public Par X0Y0_尾20_鱗右_鱗4;

		public Par X0Y0_尾20_尾;

		public Par X0Y0_尾19_鱗左_鱗1;

		public Par X0Y0_尾19_鱗左_鱗2;

		public Par X0Y0_尾19_鱗左_鱗3;

		public Par X0Y0_尾19_鱗左_鱗4;

		public Par X0Y0_尾19_鱗右_鱗1;

		public Par X0Y0_尾19_鱗右_鱗2;

		public Par X0Y0_尾19_鱗右_鱗3;

		public Par X0Y0_尾19_鱗右_鱗4;

		public Par X0Y0_尾19_尾;

		public Par X0Y0_尾18_鱗左_鱗1;

		public Par X0Y0_尾18_鱗左_鱗2;

		public Par X0Y0_尾18_鱗左_鱗3;

		public Par X0Y0_尾18_鱗左_鱗4;

		public Par X0Y0_尾18_鱗右_鱗1;

		public Par X0Y0_尾18_鱗右_鱗2;

		public Par X0Y0_尾18_鱗右_鱗3;

		public Par X0Y0_尾18_鱗右_鱗4;

		public Par X0Y0_尾18_尾;

		public Par X0Y0_尾17_鱗左_鱗1;

		public Par X0Y0_尾17_鱗左_鱗2;

		public Par X0Y0_尾17_鱗左_鱗3;

		public Par X0Y0_尾17_鱗左_鱗4;

		public Par X0Y0_尾17_鱗右_鱗1;

		public Par X0Y0_尾17_鱗右_鱗2;

		public Par X0Y0_尾17_鱗右_鱗3;

		public Par X0Y0_尾17_鱗右_鱗4;

		public Par X0Y0_尾17_尾;

		public Par X0Y0_尾16_鱗左_鱗1;

		public Par X0Y0_尾16_鱗左_鱗2;

		public Par X0Y0_尾16_鱗左_鱗3;

		public Par X0Y0_尾16_鱗左_鱗4;

		public Par X0Y0_尾16_鱗右_鱗1;

		public Par X0Y0_尾16_鱗右_鱗2;

		public Par X0Y0_尾16_鱗右_鱗3;

		public Par X0Y0_尾16_鱗右_鱗4;

		public Par X0Y0_尾16_尾;

		public Par X0Y0_尾15_鱗左_鱗1;

		public Par X0Y0_尾15_鱗左_鱗2;

		public Par X0Y0_尾15_鱗左_鱗3;

		public Par X0Y0_尾15_鱗左_鱗4;

		public Par X0Y0_尾15_鱗右_鱗1;

		public Par X0Y0_尾15_鱗右_鱗2;

		public Par X0Y0_尾15_鱗右_鱗3;

		public Par X0Y0_尾15_鱗右_鱗4;

		public Par X0Y0_尾15_尾;

		public Par X0Y0_尾14_鱗左_鱗1;

		public Par X0Y0_尾14_鱗左_鱗2;

		public Par X0Y0_尾14_鱗左_鱗3;

		public Par X0Y0_尾14_鱗左_鱗4;

		public Par X0Y0_尾14_鱗右_鱗1;

		public Par X0Y0_尾14_鱗右_鱗2;

		public Par X0Y0_尾14_鱗右_鱗3;

		public Par X0Y0_尾14_鱗右_鱗4;

		public Par X0Y0_尾14_尾;

		public Par X0Y0_尾13_鱗左_鱗1;

		public Par X0Y0_尾13_鱗左_鱗2;

		public Par X0Y0_尾13_鱗左_鱗3;

		public Par X0Y0_尾13_鱗左_鱗4;

		public Par X0Y0_尾13_鱗右_鱗1;

		public Par X0Y0_尾13_鱗右_鱗2;

		public Par X0Y0_尾13_鱗右_鱗3;

		public Par X0Y0_尾13_鱗右_鱗4;

		public Par X0Y0_尾13_尾;

		public Par X0Y0_尾12_鱗左_鱗1;

		public Par X0Y0_尾12_鱗左_鱗2;

		public Par X0Y0_尾12_鱗左_鱗3;

		public Par X0Y0_尾12_鱗左_鱗4;

		public Par X0Y0_尾12_鱗右_鱗1;

		public Par X0Y0_尾12_鱗右_鱗2;

		public Par X0Y0_尾12_鱗右_鱗3;

		public Par X0Y0_尾12_鱗右_鱗4;

		public Par X0Y0_尾12_尾;

		public Par X0Y0_尾11_鱗左_鱗1;

		public Par X0Y0_尾11_鱗左_鱗2;

		public Par X0Y0_尾11_鱗左_鱗3;

		public Par X0Y0_尾11_鱗左_鱗4;

		public Par X0Y0_尾11_鱗右_鱗1;

		public Par X0Y0_尾11_鱗右_鱗2;

		public Par X0Y0_尾11_鱗右_鱗3;

		public Par X0Y0_尾11_鱗右_鱗4;

		public Par X0Y0_尾11_尾;

		public Par X0Y0_尾10_鱗左_鱗1;

		public Par X0Y0_尾10_鱗左_鱗2;

		public Par X0Y0_尾10_鱗左_鱗3;

		public Par X0Y0_尾10_鱗左_鱗4;

		public Par X0Y0_尾10_鱗右_鱗1;

		public Par X0Y0_尾10_鱗右_鱗2;

		public Par X0Y0_尾10_鱗右_鱗3;

		public Par X0Y0_尾10_鱗右_鱗4;

		public Par X0Y0_尾10_尾;

		public Par X0Y0_尾9_鱗左_鱗1;

		public Par X0Y0_尾9_鱗左_鱗2;

		public Par X0Y0_尾9_鱗左_鱗3;

		public Par X0Y0_尾9_鱗左_鱗4;

		public Par X0Y0_尾9_鱗右_鱗1;

		public Par X0Y0_尾9_鱗右_鱗2;

		public Par X0Y0_尾9_鱗右_鱗3;

		public Par X0Y0_尾9_鱗右_鱗4;

		public Par X0Y0_尾9_尾;

		public Par X0Y0_尾8_鱗左_鱗1;

		public Par X0Y0_尾8_鱗左_鱗2;

		public Par X0Y0_尾8_鱗左_鱗3;

		public Par X0Y0_尾8_鱗左_鱗4;

		public Par X0Y0_尾8_鱗右_鱗1;

		public Par X0Y0_尾8_鱗右_鱗2;

		public Par X0Y0_尾8_鱗右_鱗3;

		public Par X0Y0_尾8_鱗右_鱗4;

		public Par X0Y0_尾8_尾;

		public Par X0Y0_尾7_鱗左_鱗1;

		public Par X0Y0_尾7_鱗左_鱗2;

		public Par X0Y0_尾7_鱗左_鱗3;

		public Par X0Y0_尾7_鱗左_鱗4;

		public Par X0Y0_尾7_鱗右_鱗1;

		public Par X0Y0_尾7_鱗右_鱗2;

		public Par X0Y0_尾7_鱗右_鱗3;

		public Par X0Y0_尾7_鱗右_鱗4;

		public Par X0Y0_尾7_尾;

		public Par X0Y0_尾6_鱗左_鱗1;

		public Par X0Y0_尾6_鱗左_鱗2;

		public Par X0Y0_尾6_鱗左_鱗3;

		public Par X0Y0_尾6_鱗左_鱗4;

		public Par X0Y0_尾6_鱗右_鱗1;

		public Par X0Y0_尾6_鱗右_鱗2;

		public Par X0Y0_尾6_鱗右_鱗3;

		public Par X0Y0_尾6_鱗右_鱗4;

		public Par X0Y0_尾6_尾;

		public Par X0Y0_尾5_鱗左_鱗1;

		public Par X0Y0_尾5_鱗左_鱗2;

		public Par X0Y0_尾5_鱗左_鱗3;

		public Par X0Y0_尾5_鱗左_鱗4;

		public Par X0Y0_尾5_鱗右_鱗1;

		public Par X0Y0_尾5_鱗右_鱗2;

		public Par X0Y0_尾5_鱗右_鱗3;

		public Par X0Y0_尾5_鱗右_鱗4;

		public Par X0Y0_尾5_尾;

		public Par X0Y0_尾4_鱗左_鱗1;

		public Par X0Y0_尾4_鱗左_鱗2;

		public Par X0Y0_尾4_鱗左_鱗3;

		public Par X0Y0_尾4_鱗左_鱗4;

		public Par X0Y0_尾4_鱗右_鱗1;

		public Par X0Y0_尾4_鱗右_鱗2;

		public Par X0Y0_尾4_鱗右_鱗3;

		public Par X0Y0_尾4_鱗右_鱗4;

		public Par X0Y0_尾4_尾;

		public Par X0Y0_輪_革;

		public Par X0Y0_輪_金具1;

		public Par X0Y0_輪_金具2;

		public Par X0Y0_輪_金具3;

		public Par X0Y0_輪_金具左;

		public Par X0Y0_輪_金具右;

		public Par X0Y0_尾3_鱗左_鱗1;

		public Par X0Y0_尾3_鱗左_鱗2;

		public Par X0Y0_尾3_鱗左_鱗3;

		public Par X0Y0_尾3_鱗左_鱗4;

		public Par X0Y0_尾3_鱗右_鱗1;

		public Par X0Y0_尾3_鱗右_鱗2;

		public Par X0Y0_尾3_鱗右_鱗3;

		public Par X0Y0_尾3_鱗右_鱗4;

		public Par X0Y0_尾3_尾;

		public Par X0Y0_尾2_鱗左_鱗1;

		public Par X0Y0_尾2_鱗左_鱗2;

		public Par X0Y0_尾2_鱗左_鱗3;

		public Par X0Y0_尾2_鱗左_鱗4;

		public Par X0Y0_尾2_鱗右_鱗1;

		public Par X0Y0_尾2_鱗右_鱗2;

		public Par X0Y0_尾2_鱗右_鱗3;

		public Par X0Y0_尾2_鱗右_鱗4;

		public Par X0Y0_尾2_尾;

		public Par X0Y0_尾1_鱗左_鱗1;

		public Par X0Y0_尾1_鱗左_鱗2;

		public Par X0Y0_尾1_鱗左_鱗3;

		public Par X0Y0_尾1_鱗左_鱗4;

		public Par X0Y0_尾1_鱗右_鱗1;

		public Par X0Y0_尾1_鱗右_鱗2;

		public Par X0Y0_尾1_鱗右_鱗3;

		public Par X0Y0_尾1_鱗右_鱗4;

		public Par X0Y0_尾1_尾;

		public Par X0Y0_尾0_鱗左_鱗1;

		public Par X0Y0_尾0_鱗左_鱗2;

		public Par X0Y0_尾0_鱗左_鱗3;

		public Par X0Y0_尾0_鱗左_鱗4;

		public Par X0Y0_尾0_鱗右_鱗1;

		public Par X0Y0_尾0_鱗右_鱗2;

		public Par X0Y0_尾0_鱗右_鱗3;

		public Par X0Y0_尾0_鱗右_鱗4;

		public Par X0Y0_尾0_尾;

		public ColorD 尾33_鱗左_鱗1CD;

		public ColorD 尾33_鱗左_鱗3CD;

		public ColorD 尾33_鱗右_鱗1CD;

		public ColorD 尾33_鱗右_鱗3CD;

		public ColorD 尾33_尾CD;

		public ColorD 尾32_鱗左_鱗1CD;

		public ColorD 尾32_鱗左_鱗2CD;

		public ColorD 尾32_鱗左_鱗3CD;

		public ColorD 尾32_鱗左_鱗4CD;

		public ColorD 尾32_鱗右_鱗1CD;

		public ColorD 尾32_鱗右_鱗2CD;

		public ColorD 尾32_鱗右_鱗3CD;

		public ColorD 尾32_鱗右_鱗4CD;

		public ColorD 尾32_尾CD;

		public ColorD 尾31_鱗左_鱗1CD;

		public ColorD 尾31_鱗左_鱗2CD;

		public ColorD 尾31_鱗左_鱗3CD;

		public ColorD 尾31_鱗左_鱗4CD;

		public ColorD 尾31_鱗右_鱗1CD;

		public ColorD 尾31_鱗右_鱗2CD;

		public ColorD 尾31_鱗右_鱗3CD;

		public ColorD 尾31_鱗右_鱗4CD;

		public ColorD 尾31_尾CD;

		public ColorD 尾30_鱗左_鱗1CD;

		public ColorD 尾30_鱗左_鱗2CD;

		public ColorD 尾30_鱗左_鱗3CD;

		public ColorD 尾30_鱗左_鱗4CD;

		public ColorD 尾30_鱗右_鱗1CD;

		public ColorD 尾30_鱗右_鱗2CD;

		public ColorD 尾30_鱗右_鱗3CD;

		public ColorD 尾30_鱗右_鱗4CD;

		public ColorD 尾30_尾CD;

		public ColorD 尾29_鱗左_鱗1CD;

		public ColorD 尾29_鱗左_鱗2CD;

		public ColorD 尾29_鱗左_鱗3CD;

		public ColorD 尾29_鱗左_鱗4CD;

		public ColorD 尾29_鱗右_鱗1CD;

		public ColorD 尾29_鱗右_鱗2CD;

		public ColorD 尾29_鱗右_鱗3CD;

		public ColorD 尾29_鱗右_鱗4CD;

		public ColorD 尾29_尾CD;

		public ColorD 尾28_鱗左_鱗1CD;

		public ColorD 尾28_鱗左_鱗2CD;

		public ColorD 尾28_鱗左_鱗3CD;

		public ColorD 尾28_鱗左_鱗4CD;

		public ColorD 尾28_鱗右_鱗1CD;

		public ColorD 尾28_鱗右_鱗2CD;

		public ColorD 尾28_鱗右_鱗3CD;

		public ColorD 尾28_鱗右_鱗4CD;

		public ColorD 尾28_尾CD;

		public ColorD 尾27_鱗左_鱗1CD;

		public ColorD 尾27_鱗左_鱗2CD;

		public ColorD 尾27_鱗左_鱗3CD;

		public ColorD 尾27_鱗左_鱗4CD;

		public ColorD 尾27_鱗右_鱗1CD;

		public ColorD 尾27_鱗右_鱗2CD;

		public ColorD 尾27_鱗右_鱗3CD;

		public ColorD 尾27_鱗右_鱗4CD;

		public ColorD 尾27_尾CD;

		public ColorD 尾26_鱗左_鱗1CD;

		public ColorD 尾26_鱗左_鱗2CD;

		public ColorD 尾26_鱗左_鱗3CD;

		public ColorD 尾26_鱗左_鱗4CD;

		public ColorD 尾26_鱗右_鱗1CD;

		public ColorD 尾26_鱗右_鱗2CD;

		public ColorD 尾26_鱗右_鱗3CD;

		public ColorD 尾26_鱗右_鱗4CD;

		public ColorD 尾26_尾CD;

		public ColorD 尾25_鱗左_鱗1CD;

		public ColorD 尾25_鱗左_鱗2CD;

		public ColorD 尾25_鱗左_鱗3CD;

		public ColorD 尾25_鱗左_鱗4CD;

		public ColorD 尾25_鱗右_鱗1CD;

		public ColorD 尾25_鱗右_鱗2CD;

		public ColorD 尾25_鱗右_鱗3CD;

		public ColorD 尾25_鱗右_鱗4CD;

		public ColorD 尾25_尾CD;

		public ColorD 尾24_鱗左_鱗1CD;

		public ColorD 尾24_鱗左_鱗2CD;

		public ColorD 尾24_鱗左_鱗3CD;

		public ColorD 尾24_鱗左_鱗4CD;

		public ColorD 尾24_鱗右_鱗1CD;

		public ColorD 尾24_鱗右_鱗2CD;

		public ColorD 尾24_鱗右_鱗3CD;

		public ColorD 尾24_鱗右_鱗4CD;

		public ColorD 尾24_尾CD;

		public ColorD 尾23_鱗左_鱗1CD;

		public ColorD 尾23_鱗左_鱗2CD;

		public ColorD 尾23_鱗左_鱗3CD;

		public ColorD 尾23_鱗左_鱗4CD;

		public ColorD 尾23_鱗右_鱗1CD;

		public ColorD 尾23_鱗右_鱗2CD;

		public ColorD 尾23_鱗右_鱗3CD;

		public ColorD 尾23_鱗右_鱗4CD;

		public ColorD 尾23_尾CD;

		public ColorD 尾22_鱗左_鱗1CD;

		public ColorD 尾22_鱗左_鱗2CD;

		public ColorD 尾22_鱗左_鱗3CD;

		public ColorD 尾22_鱗左_鱗4CD;

		public ColorD 尾22_鱗右_鱗1CD;

		public ColorD 尾22_鱗右_鱗2CD;

		public ColorD 尾22_鱗右_鱗3CD;

		public ColorD 尾22_鱗右_鱗4CD;

		public ColorD 尾22_尾CD;

		public ColorD 尾21_鱗左_鱗1CD;

		public ColorD 尾21_鱗左_鱗2CD;

		public ColorD 尾21_鱗左_鱗3CD;

		public ColorD 尾21_鱗左_鱗4CD;

		public ColorD 尾21_鱗右_鱗1CD;

		public ColorD 尾21_鱗右_鱗2CD;

		public ColorD 尾21_鱗右_鱗3CD;

		public ColorD 尾21_鱗右_鱗4CD;

		public ColorD 尾21_尾CD;

		public ColorD 尾20_鱗左_鱗1CD;

		public ColorD 尾20_鱗左_鱗2CD;

		public ColorD 尾20_鱗左_鱗3CD;

		public ColorD 尾20_鱗左_鱗4CD;

		public ColorD 尾20_鱗右_鱗1CD;

		public ColorD 尾20_鱗右_鱗2CD;

		public ColorD 尾20_鱗右_鱗3CD;

		public ColorD 尾20_鱗右_鱗4CD;

		public ColorD 尾20_尾CD;

		public ColorD 尾19_鱗左_鱗1CD;

		public ColorD 尾19_鱗左_鱗2CD;

		public ColorD 尾19_鱗左_鱗3CD;

		public ColorD 尾19_鱗左_鱗4CD;

		public ColorD 尾19_鱗右_鱗1CD;

		public ColorD 尾19_鱗右_鱗2CD;

		public ColorD 尾19_鱗右_鱗3CD;

		public ColorD 尾19_鱗右_鱗4CD;

		public ColorD 尾19_尾CD;

		public ColorD 尾18_鱗左_鱗1CD;

		public ColorD 尾18_鱗左_鱗2CD;

		public ColorD 尾18_鱗左_鱗3CD;

		public ColorD 尾18_鱗左_鱗4CD;

		public ColorD 尾18_鱗右_鱗1CD;

		public ColorD 尾18_鱗右_鱗2CD;

		public ColorD 尾18_鱗右_鱗3CD;

		public ColorD 尾18_鱗右_鱗4CD;

		public ColorD 尾18_尾CD;

		public ColorD 尾17_鱗左_鱗1CD;

		public ColorD 尾17_鱗左_鱗2CD;

		public ColorD 尾17_鱗左_鱗3CD;

		public ColorD 尾17_鱗左_鱗4CD;

		public ColorD 尾17_鱗右_鱗1CD;

		public ColorD 尾17_鱗右_鱗2CD;

		public ColorD 尾17_鱗右_鱗3CD;

		public ColorD 尾17_鱗右_鱗4CD;

		public ColorD 尾17_尾CD;

		public ColorD 尾16_鱗左_鱗1CD;

		public ColorD 尾16_鱗左_鱗2CD;

		public ColorD 尾16_鱗左_鱗3CD;

		public ColorD 尾16_鱗左_鱗4CD;

		public ColorD 尾16_鱗右_鱗1CD;

		public ColorD 尾16_鱗右_鱗2CD;

		public ColorD 尾16_鱗右_鱗3CD;

		public ColorD 尾16_鱗右_鱗4CD;

		public ColorD 尾16_尾CD;

		public ColorD 尾15_鱗左_鱗1CD;

		public ColorD 尾15_鱗左_鱗2CD;

		public ColorD 尾15_鱗左_鱗3CD;

		public ColorD 尾15_鱗左_鱗4CD;

		public ColorD 尾15_鱗右_鱗1CD;

		public ColorD 尾15_鱗右_鱗2CD;

		public ColorD 尾15_鱗右_鱗3CD;

		public ColorD 尾15_鱗右_鱗4CD;

		public ColorD 尾15_尾CD;

		public ColorD 尾14_鱗左_鱗1CD;

		public ColorD 尾14_鱗左_鱗2CD;

		public ColorD 尾14_鱗左_鱗3CD;

		public ColorD 尾14_鱗左_鱗4CD;

		public ColorD 尾14_鱗右_鱗1CD;

		public ColorD 尾14_鱗右_鱗2CD;

		public ColorD 尾14_鱗右_鱗3CD;

		public ColorD 尾14_鱗右_鱗4CD;

		public ColorD 尾14_尾CD;

		public ColorD 尾13_鱗左_鱗1CD;

		public ColorD 尾13_鱗左_鱗2CD;

		public ColorD 尾13_鱗左_鱗3CD;

		public ColorD 尾13_鱗左_鱗4CD;

		public ColorD 尾13_鱗右_鱗1CD;

		public ColorD 尾13_鱗右_鱗2CD;

		public ColorD 尾13_鱗右_鱗3CD;

		public ColorD 尾13_鱗右_鱗4CD;

		public ColorD 尾13_尾CD;

		public ColorD 尾12_鱗左_鱗1CD;

		public ColorD 尾12_鱗左_鱗2CD;

		public ColorD 尾12_鱗左_鱗3CD;

		public ColorD 尾12_鱗左_鱗4CD;

		public ColorD 尾12_鱗右_鱗1CD;

		public ColorD 尾12_鱗右_鱗2CD;

		public ColorD 尾12_鱗右_鱗3CD;

		public ColorD 尾12_鱗右_鱗4CD;

		public ColorD 尾12_尾CD;

		public ColorD 尾11_鱗左_鱗1CD;

		public ColorD 尾11_鱗左_鱗2CD;

		public ColorD 尾11_鱗左_鱗3CD;

		public ColorD 尾11_鱗左_鱗4CD;

		public ColorD 尾11_鱗右_鱗1CD;

		public ColorD 尾11_鱗右_鱗2CD;

		public ColorD 尾11_鱗右_鱗3CD;

		public ColorD 尾11_鱗右_鱗4CD;

		public ColorD 尾11_尾CD;

		public ColorD 尾10_鱗左_鱗1CD;

		public ColorD 尾10_鱗左_鱗2CD;

		public ColorD 尾10_鱗左_鱗3CD;

		public ColorD 尾10_鱗左_鱗4CD;

		public ColorD 尾10_鱗右_鱗1CD;

		public ColorD 尾10_鱗右_鱗2CD;

		public ColorD 尾10_鱗右_鱗3CD;

		public ColorD 尾10_鱗右_鱗4CD;

		public ColorD 尾10_尾CD;

		public ColorD 尾9_鱗左_鱗1CD;

		public ColorD 尾9_鱗左_鱗2CD;

		public ColorD 尾9_鱗左_鱗3CD;

		public ColorD 尾9_鱗左_鱗4CD;

		public ColorD 尾9_鱗右_鱗1CD;

		public ColorD 尾9_鱗右_鱗2CD;

		public ColorD 尾9_鱗右_鱗3CD;

		public ColorD 尾9_鱗右_鱗4CD;

		public ColorD 尾9_尾CD;

		public ColorD 尾8_鱗左_鱗1CD;

		public ColorD 尾8_鱗左_鱗2CD;

		public ColorD 尾8_鱗左_鱗3CD;

		public ColorD 尾8_鱗左_鱗4CD;

		public ColorD 尾8_鱗右_鱗1CD;

		public ColorD 尾8_鱗右_鱗2CD;

		public ColorD 尾8_鱗右_鱗3CD;

		public ColorD 尾8_鱗右_鱗4CD;

		public ColorD 尾8_尾CD;

		public ColorD 尾7_鱗左_鱗1CD;

		public ColorD 尾7_鱗左_鱗2CD;

		public ColorD 尾7_鱗左_鱗3CD;

		public ColorD 尾7_鱗左_鱗4CD;

		public ColorD 尾7_鱗右_鱗1CD;

		public ColorD 尾7_鱗右_鱗2CD;

		public ColorD 尾7_鱗右_鱗3CD;

		public ColorD 尾7_鱗右_鱗4CD;

		public ColorD 尾7_尾CD;

		public ColorD 尾6_鱗左_鱗1CD;

		public ColorD 尾6_鱗左_鱗2CD;

		public ColorD 尾6_鱗左_鱗3CD;

		public ColorD 尾6_鱗左_鱗4CD;

		public ColorD 尾6_鱗右_鱗1CD;

		public ColorD 尾6_鱗右_鱗2CD;

		public ColorD 尾6_鱗右_鱗3CD;

		public ColorD 尾6_鱗右_鱗4CD;

		public ColorD 尾6_尾CD;

		public ColorD 尾5_鱗左_鱗1CD;

		public ColorD 尾5_鱗左_鱗2CD;

		public ColorD 尾5_鱗左_鱗3CD;

		public ColorD 尾5_鱗左_鱗4CD;

		public ColorD 尾5_鱗右_鱗1CD;

		public ColorD 尾5_鱗右_鱗2CD;

		public ColorD 尾5_鱗右_鱗3CD;

		public ColorD 尾5_鱗右_鱗4CD;

		public ColorD 尾5_尾CD;

		public ColorD 尾4_鱗左_鱗1CD;

		public ColorD 尾4_鱗左_鱗2CD;

		public ColorD 尾4_鱗左_鱗3CD;

		public ColorD 尾4_鱗左_鱗4CD;

		public ColorD 尾4_鱗右_鱗1CD;

		public ColorD 尾4_鱗右_鱗2CD;

		public ColorD 尾4_鱗右_鱗3CD;

		public ColorD 尾4_鱗右_鱗4CD;

		public ColorD 尾4_尾CD;

		public ColorD 尾3_鱗左_鱗1CD;

		public ColorD 尾3_鱗左_鱗2CD;

		public ColorD 尾3_鱗左_鱗3CD;

		public ColorD 尾3_鱗左_鱗4CD;

		public ColorD 尾3_鱗右_鱗1CD;

		public ColorD 尾3_鱗右_鱗2CD;

		public ColorD 尾3_鱗右_鱗3CD;

		public ColorD 尾3_鱗右_鱗4CD;

		public ColorD 尾3_尾CD;

		public ColorD 尾2_鱗左_鱗1CD;

		public ColorD 尾2_鱗左_鱗2CD;

		public ColorD 尾2_鱗左_鱗3CD;

		public ColorD 尾2_鱗左_鱗4CD;

		public ColorD 尾2_鱗右_鱗1CD;

		public ColorD 尾2_鱗右_鱗2CD;

		public ColorD 尾2_鱗右_鱗3CD;

		public ColorD 尾2_鱗右_鱗4CD;

		public ColorD 尾2_尾CD;

		public ColorD 尾1_鱗左_鱗1CD;

		public ColorD 尾1_鱗左_鱗2CD;

		public ColorD 尾1_鱗左_鱗3CD;

		public ColorD 尾1_鱗左_鱗4CD;

		public ColorD 尾1_鱗右_鱗1CD;

		public ColorD 尾1_鱗右_鱗2CD;

		public ColorD 尾1_鱗右_鱗3CD;

		public ColorD 尾1_鱗右_鱗4CD;

		public ColorD 尾1_尾CD;

		public ColorD 尾0_鱗左_鱗1CD;

		public ColorD 尾0_鱗左_鱗2CD;

		public ColorD 尾0_鱗左_鱗3CD;

		public ColorD 尾0_鱗左_鱗4CD;

		public ColorD 尾0_鱗右_鱗1CD;

		public ColorD 尾0_鱗右_鱗2CD;

		public ColorD 尾0_鱗右_鱗3CD;

		public ColorD 尾0_鱗右_鱗4CD;

		public ColorD 尾0_尾CD;

		public ColorD 輪_革CD;

		public ColorD 輪_金具1CD;

		public ColorD 輪_金具2CD;

		public ColorD 輪_金具3CD;

		public ColorD 輪_金具左CD;

		public ColorD 輪_金具右CD;

		public ColorP X0Y0_尾33_鱗左_鱗1CP;

		public ColorP X0Y0_尾33_鱗左_鱗3CP;

		public ColorP X0Y0_尾33_鱗右_鱗1CP;

		public ColorP X0Y0_尾33_鱗右_鱗3CP;

		public ColorP X0Y0_尾33_尾CP;

		public ColorP X0Y0_尾32_鱗左_鱗1CP;

		public ColorP X0Y0_尾32_鱗左_鱗2CP;

		public ColorP X0Y0_尾32_鱗左_鱗3CP;

		public ColorP X0Y0_尾32_鱗左_鱗4CP;

		public ColorP X0Y0_尾32_鱗右_鱗1CP;

		public ColorP X0Y0_尾32_鱗右_鱗2CP;

		public ColorP X0Y0_尾32_鱗右_鱗3CP;

		public ColorP X0Y0_尾32_鱗右_鱗4CP;

		public ColorP X0Y0_尾32_尾CP;

		public ColorP X0Y0_尾31_鱗左_鱗1CP;

		public ColorP X0Y0_尾31_鱗左_鱗2CP;

		public ColorP X0Y0_尾31_鱗左_鱗3CP;

		public ColorP X0Y0_尾31_鱗左_鱗4CP;

		public ColorP X0Y0_尾31_鱗右_鱗1CP;

		public ColorP X0Y0_尾31_鱗右_鱗2CP;

		public ColorP X0Y0_尾31_鱗右_鱗3CP;

		public ColorP X0Y0_尾31_鱗右_鱗4CP;

		public ColorP X0Y0_尾31_尾CP;

		public ColorP X0Y0_尾30_鱗左_鱗1CP;

		public ColorP X0Y0_尾30_鱗左_鱗2CP;

		public ColorP X0Y0_尾30_鱗左_鱗3CP;

		public ColorP X0Y0_尾30_鱗左_鱗4CP;

		public ColorP X0Y0_尾30_鱗右_鱗1CP;

		public ColorP X0Y0_尾30_鱗右_鱗2CP;

		public ColorP X0Y0_尾30_鱗右_鱗3CP;

		public ColorP X0Y0_尾30_鱗右_鱗4CP;

		public ColorP X0Y0_尾30_尾CP;

		public ColorP X0Y0_尾29_鱗左_鱗1CP;

		public ColorP X0Y0_尾29_鱗左_鱗2CP;

		public ColorP X0Y0_尾29_鱗左_鱗3CP;

		public ColorP X0Y0_尾29_鱗左_鱗4CP;

		public ColorP X0Y0_尾29_鱗右_鱗1CP;

		public ColorP X0Y0_尾29_鱗右_鱗2CP;

		public ColorP X0Y0_尾29_鱗右_鱗3CP;

		public ColorP X0Y0_尾29_鱗右_鱗4CP;

		public ColorP X0Y0_尾29_尾CP;

		public ColorP X0Y0_尾28_鱗左_鱗1CP;

		public ColorP X0Y0_尾28_鱗左_鱗2CP;

		public ColorP X0Y0_尾28_鱗左_鱗3CP;

		public ColorP X0Y0_尾28_鱗左_鱗4CP;

		public ColorP X0Y0_尾28_鱗右_鱗1CP;

		public ColorP X0Y0_尾28_鱗右_鱗2CP;

		public ColorP X0Y0_尾28_鱗右_鱗3CP;

		public ColorP X0Y0_尾28_鱗右_鱗4CP;

		public ColorP X0Y0_尾28_尾CP;

		public ColorP X0Y0_尾27_鱗左_鱗1CP;

		public ColorP X0Y0_尾27_鱗左_鱗2CP;

		public ColorP X0Y0_尾27_鱗左_鱗3CP;

		public ColorP X0Y0_尾27_鱗左_鱗4CP;

		public ColorP X0Y0_尾27_鱗右_鱗1CP;

		public ColorP X0Y0_尾27_鱗右_鱗2CP;

		public ColorP X0Y0_尾27_鱗右_鱗3CP;

		public ColorP X0Y0_尾27_鱗右_鱗4CP;

		public ColorP X0Y0_尾27_尾CP;

		public ColorP X0Y0_尾26_鱗左_鱗1CP;

		public ColorP X0Y0_尾26_鱗左_鱗2CP;

		public ColorP X0Y0_尾26_鱗左_鱗3CP;

		public ColorP X0Y0_尾26_鱗左_鱗4CP;

		public ColorP X0Y0_尾26_鱗右_鱗1CP;

		public ColorP X0Y0_尾26_鱗右_鱗2CP;

		public ColorP X0Y0_尾26_鱗右_鱗3CP;

		public ColorP X0Y0_尾26_鱗右_鱗4CP;

		public ColorP X0Y0_尾26_尾CP;

		public ColorP X0Y0_尾25_鱗左_鱗1CP;

		public ColorP X0Y0_尾25_鱗左_鱗2CP;

		public ColorP X0Y0_尾25_鱗左_鱗3CP;

		public ColorP X0Y0_尾25_鱗左_鱗4CP;

		public ColorP X0Y0_尾25_鱗右_鱗1CP;

		public ColorP X0Y0_尾25_鱗右_鱗2CP;

		public ColorP X0Y0_尾25_鱗右_鱗3CP;

		public ColorP X0Y0_尾25_鱗右_鱗4CP;

		public ColorP X0Y0_尾25_尾CP;

		public ColorP X0Y0_尾24_鱗左_鱗1CP;

		public ColorP X0Y0_尾24_鱗左_鱗2CP;

		public ColorP X0Y0_尾24_鱗左_鱗3CP;

		public ColorP X0Y0_尾24_鱗左_鱗4CP;

		public ColorP X0Y0_尾24_鱗右_鱗1CP;

		public ColorP X0Y0_尾24_鱗右_鱗2CP;

		public ColorP X0Y0_尾24_鱗右_鱗3CP;

		public ColorP X0Y0_尾24_鱗右_鱗4CP;

		public ColorP X0Y0_尾24_尾CP;

		public ColorP X0Y0_尾23_鱗左_鱗1CP;

		public ColorP X0Y0_尾23_鱗左_鱗2CP;

		public ColorP X0Y0_尾23_鱗左_鱗3CP;

		public ColorP X0Y0_尾23_鱗左_鱗4CP;

		public ColorP X0Y0_尾23_鱗右_鱗1CP;

		public ColorP X0Y0_尾23_鱗右_鱗2CP;

		public ColorP X0Y0_尾23_鱗右_鱗3CP;

		public ColorP X0Y0_尾23_鱗右_鱗4CP;

		public ColorP X0Y0_尾23_尾CP;

		public ColorP X0Y0_尾22_鱗左_鱗1CP;

		public ColorP X0Y0_尾22_鱗左_鱗2CP;

		public ColorP X0Y0_尾22_鱗左_鱗3CP;

		public ColorP X0Y0_尾22_鱗左_鱗4CP;

		public ColorP X0Y0_尾22_鱗右_鱗1CP;

		public ColorP X0Y0_尾22_鱗右_鱗2CP;

		public ColorP X0Y0_尾22_鱗右_鱗3CP;

		public ColorP X0Y0_尾22_鱗右_鱗4CP;

		public ColorP X0Y0_尾22_尾CP;

		public ColorP X0Y0_尾21_鱗左_鱗1CP;

		public ColorP X0Y0_尾21_鱗左_鱗2CP;

		public ColorP X0Y0_尾21_鱗左_鱗3CP;

		public ColorP X0Y0_尾21_鱗左_鱗4CP;

		public ColorP X0Y0_尾21_鱗右_鱗1CP;

		public ColorP X0Y0_尾21_鱗右_鱗2CP;

		public ColorP X0Y0_尾21_鱗右_鱗3CP;

		public ColorP X0Y0_尾21_鱗右_鱗4CP;

		public ColorP X0Y0_尾21_尾CP;

		public ColorP X0Y0_尾20_鱗左_鱗1CP;

		public ColorP X0Y0_尾20_鱗左_鱗2CP;

		public ColorP X0Y0_尾20_鱗左_鱗3CP;

		public ColorP X0Y0_尾20_鱗左_鱗4CP;

		public ColorP X0Y0_尾20_鱗右_鱗1CP;

		public ColorP X0Y0_尾20_鱗右_鱗2CP;

		public ColorP X0Y0_尾20_鱗右_鱗3CP;

		public ColorP X0Y0_尾20_鱗右_鱗4CP;

		public ColorP X0Y0_尾20_尾CP;

		public ColorP X0Y0_尾19_鱗左_鱗1CP;

		public ColorP X0Y0_尾19_鱗左_鱗2CP;

		public ColorP X0Y0_尾19_鱗左_鱗3CP;

		public ColorP X0Y0_尾19_鱗左_鱗4CP;

		public ColorP X0Y0_尾19_鱗右_鱗1CP;

		public ColorP X0Y0_尾19_鱗右_鱗2CP;

		public ColorP X0Y0_尾19_鱗右_鱗3CP;

		public ColorP X0Y0_尾19_鱗右_鱗4CP;

		public ColorP X0Y0_尾19_尾CP;

		public ColorP X0Y0_尾18_鱗左_鱗1CP;

		public ColorP X0Y0_尾18_鱗左_鱗2CP;

		public ColorP X0Y0_尾18_鱗左_鱗3CP;

		public ColorP X0Y0_尾18_鱗左_鱗4CP;

		public ColorP X0Y0_尾18_鱗右_鱗1CP;

		public ColorP X0Y0_尾18_鱗右_鱗2CP;

		public ColorP X0Y0_尾18_鱗右_鱗3CP;

		public ColorP X0Y0_尾18_鱗右_鱗4CP;

		public ColorP X0Y0_尾18_尾CP;

		public ColorP X0Y0_尾17_鱗左_鱗1CP;

		public ColorP X0Y0_尾17_鱗左_鱗2CP;

		public ColorP X0Y0_尾17_鱗左_鱗3CP;

		public ColorP X0Y0_尾17_鱗左_鱗4CP;

		public ColorP X0Y0_尾17_鱗右_鱗1CP;

		public ColorP X0Y0_尾17_鱗右_鱗2CP;

		public ColorP X0Y0_尾17_鱗右_鱗3CP;

		public ColorP X0Y0_尾17_鱗右_鱗4CP;

		public ColorP X0Y0_尾17_尾CP;

		public ColorP X0Y0_尾16_鱗左_鱗1CP;

		public ColorP X0Y0_尾16_鱗左_鱗2CP;

		public ColorP X0Y0_尾16_鱗左_鱗3CP;

		public ColorP X0Y0_尾16_鱗左_鱗4CP;

		public ColorP X0Y0_尾16_鱗右_鱗1CP;

		public ColorP X0Y0_尾16_鱗右_鱗2CP;

		public ColorP X0Y0_尾16_鱗右_鱗3CP;

		public ColorP X0Y0_尾16_鱗右_鱗4CP;

		public ColorP X0Y0_尾16_尾CP;

		public ColorP X0Y0_尾15_鱗左_鱗1CP;

		public ColorP X0Y0_尾15_鱗左_鱗2CP;

		public ColorP X0Y0_尾15_鱗左_鱗3CP;

		public ColorP X0Y0_尾15_鱗左_鱗4CP;

		public ColorP X0Y0_尾15_鱗右_鱗1CP;

		public ColorP X0Y0_尾15_鱗右_鱗2CP;

		public ColorP X0Y0_尾15_鱗右_鱗3CP;

		public ColorP X0Y0_尾15_鱗右_鱗4CP;

		public ColorP X0Y0_尾15_尾CP;

		public ColorP X0Y0_尾14_鱗左_鱗1CP;

		public ColorP X0Y0_尾14_鱗左_鱗2CP;

		public ColorP X0Y0_尾14_鱗左_鱗3CP;

		public ColorP X0Y0_尾14_鱗左_鱗4CP;

		public ColorP X0Y0_尾14_鱗右_鱗1CP;

		public ColorP X0Y0_尾14_鱗右_鱗2CP;

		public ColorP X0Y0_尾14_鱗右_鱗3CP;

		public ColorP X0Y0_尾14_鱗右_鱗4CP;

		public ColorP X0Y0_尾14_尾CP;

		public ColorP X0Y0_尾13_鱗左_鱗1CP;

		public ColorP X0Y0_尾13_鱗左_鱗2CP;

		public ColorP X0Y0_尾13_鱗左_鱗3CP;

		public ColorP X0Y0_尾13_鱗左_鱗4CP;

		public ColorP X0Y0_尾13_鱗右_鱗1CP;

		public ColorP X0Y0_尾13_鱗右_鱗2CP;

		public ColorP X0Y0_尾13_鱗右_鱗3CP;

		public ColorP X0Y0_尾13_鱗右_鱗4CP;

		public ColorP X0Y0_尾13_尾CP;

		public ColorP X0Y0_尾12_鱗左_鱗1CP;

		public ColorP X0Y0_尾12_鱗左_鱗2CP;

		public ColorP X0Y0_尾12_鱗左_鱗3CP;

		public ColorP X0Y0_尾12_鱗左_鱗4CP;

		public ColorP X0Y0_尾12_鱗右_鱗1CP;

		public ColorP X0Y0_尾12_鱗右_鱗2CP;

		public ColorP X0Y0_尾12_鱗右_鱗3CP;

		public ColorP X0Y0_尾12_鱗右_鱗4CP;

		public ColorP X0Y0_尾12_尾CP;

		public ColorP X0Y0_尾11_鱗左_鱗1CP;

		public ColorP X0Y0_尾11_鱗左_鱗2CP;

		public ColorP X0Y0_尾11_鱗左_鱗3CP;

		public ColorP X0Y0_尾11_鱗左_鱗4CP;

		public ColorP X0Y0_尾11_鱗右_鱗1CP;

		public ColorP X0Y0_尾11_鱗右_鱗2CP;

		public ColorP X0Y0_尾11_鱗右_鱗3CP;

		public ColorP X0Y0_尾11_鱗右_鱗4CP;

		public ColorP X0Y0_尾11_尾CP;

		public ColorP X0Y0_尾10_鱗左_鱗1CP;

		public ColorP X0Y0_尾10_鱗左_鱗2CP;

		public ColorP X0Y0_尾10_鱗左_鱗3CP;

		public ColorP X0Y0_尾10_鱗左_鱗4CP;

		public ColorP X0Y0_尾10_鱗右_鱗1CP;

		public ColorP X0Y0_尾10_鱗右_鱗2CP;

		public ColorP X0Y0_尾10_鱗右_鱗3CP;

		public ColorP X0Y0_尾10_鱗右_鱗4CP;

		public ColorP X0Y0_尾10_尾CP;

		public ColorP X0Y0_尾9_鱗左_鱗1CP;

		public ColorP X0Y0_尾9_鱗左_鱗2CP;

		public ColorP X0Y0_尾9_鱗左_鱗3CP;

		public ColorP X0Y0_尾9_鱗左_鱗4CP;

		public ColorP X0Y0_尾9_鱗右_鱗1CP;

		public ColorP X0Y0_尾9_鱗右_鱗2CP;

		public ColorP X0Y0_尾9_鱗右_鱗3CP;

		public ColorP X0Y0_尾9_鱗右_鱗4CP;

		public ColorP X0Y0_尾9_尾CP;

		public ColorP X0Y0_尾8_鱗左_鱗1CP;

		public ColorP X0Y0_尾8_鱗左_鱗2CP;

		public ColorP X0Y0_尾8_鱗左_鱗3CP;

		public ColorP X0Y0_尾8_鱗左_鱗4CP;

		public ColorP X0Y0_尾8_鱗右_鱗1CP;

		public ColorP X0Y0_尾8_鱗右_鱗2CP;

		public ColorP X0Y0_尾8_鱗右_鱗3CP;

		public ColorP X0Y0_尾8_鱗右_鱗4CP;

		public ColorP X0Y0_尾8_尾CP;

		public ColorP X0Y0_尾7_鱗左_鱗1CP;

		public ColorP X0Y0_尾7_鱗左_鱗2CP;

		public ColorP X0Y0_尾7_鱗左_鱗3CP;

		public ColorP X0Y0_尾7_鱗左_鱗4CP;

		public ColorP X0Y0_尾7_鱗右_鱗1CP;

		public ColorP X0Y0_尾7_鱗右_鱗2CP;

		public ColorP X0Y0_尾7_鱗右_鱗3CP;

		public ColorP X0Y0_尾7_鱗右_鱗4CP;

		public ColorP X0Y0_尾7_尾CP;

		public ColorP X0Y0_尾6_鱗左_鱗1CP;

		public ColorP X0Y0_尾6_鱗左_鱗2CP;

		public ColorP X0Y0_尾6_鱗左_鱗3CP;

		public ColorP X0Y0_尾6_鱗左_鱗4CP;

		public ColorP X0Y0_尾6_鱗右_鱗1CP;

		public ColorP X0Y0_尾6_鱗右_鱗2CP;

		public ColorP X0Y0_尾6_鱗右_鱗3CP;

		public ColorP X0Y0_尾6_鱗右_鱗4CP;

		public ColorP X0Y0_尾6_尾CP;

		public ColorP X0Y0_尾5_鱗左_鱗1CP;

		public ColorP X0Y0_尾5_鱗左_鱗2CP;

		public ColorP X0Y0_尾5_鱗左_鱗3CP;

		public ColorP X0Y0_尾5_鱗左_鱗4CP;

		public ColorP X0Y0_尾5_鱗右_鱗1CP;

		public ColorP X0Y0_尾5_鱗右_鱗2CP;

		public ColorP X0Y0_尾5_鱗右_鱗3CP;

		public ColorP X0Y0_尾5_鱗右_鱗4CP;

		public ColorP X0Y0_尾5_尾CP;

		public ColorP X0Y0_尾4_鱗左_鱗1CP;

		public ColorP X0Y0_尾4_鱗左_鱗2CP;

		public ColorP X0Y0_尾4_鱗左_鱗3CP;

		public ColorP X0Y0_尾4_鱗左_鱗4CP;

		public ColorP X0Y0_尾4_鱗右_鱗1CP;

		public ColorP X0Y0_尾4_鱗右_鱗2CP;

		public ColorP X0Y0_尾4_鱗右_鱗3CP;

		public ColorP X0Y0_尾4_鱗右_鱗4CP;

		public ColorP X0Y0_尾4_尾CP;

		public ColorP X0Y0_輪_革CP;

		public ColorP X0Y0_輪_金具1CP;

		public ColorP X0Y0_輪_金具2CP;

		public ColorP X0Y0_輪_金具3CP;

		public ColorP X0Y0_輪_金具左CP;

		public ColorP X0Y0_輪_金具右CP;

		public ColorP X0Y0_尾3_鱗左_鱗1CP;

		public ColorP X0Y0_尾3_鱗左_鱗2CP;

		public ColorP X0Y0_尾3_鱗左_鱗3CP;

		public ColorP X0Y0_尾3_鱗左_鱗4CP;

		public ColorP X0Y0_尾3_鱗右_鱗1CP;

		public ColorP X0Y0_尾3_鱗右_鱗2CP;

		public ColorP X0Y0_尾3_鱗右_鱗3CP;

		public ColorP X0Y0_尾3_鱗右_鱗4CP;

		public ColorP X0Y0_尾3_尾CP;

		public ColorP X0Y0_尾2_鱗左_鱗1CP;

		public ColorP X0Y0_尾2_鱗左_鱗2CP;

		public ColorP X0Y0_尾2_鱗左_鱗3CP;

		public ColorP X0Y0_尾2_鱗左_鱗4CP;

		public ColorP X0Y0_尾2_鱗右_鱗1CP;

		public ColorP X0Y0_尾2_鱗右_鱗2CP;

		public ColorP X0Y0_尾2_鱗右_鱗3CP;

		public ColorP X0Y0_尾2_鱗右_鱗4CP;

		public ColorP X0Y0_尾2_尾CP;

		public ColorP X0Y0_尾1_鱗左_鱗1CP;

		public ColorP X0Y0_尾1_鱗左_鱗2CP;

		public ColorP X0Y0_尾1_鱗左_鱗3CP;

		public ColorP X0Y0_尾1_鱗左_鱗4CP;

		public ColorP X0Y0_尾1_鱗右_鱗1CP;

		public ColorP X0Y0_尾1_鱗右_鱗2CP;

		public ColorP X0Y0_尾1_鱗右_鱗3CP;

		public ColorP X0Y0_尾1_鱗右_鱗4CP;

		public ColorP X0Y0_尾1_尾CP;

		public ColorP X0Y0_尾0_鱗左_鱗1CP;

		public ColorP X0Y0_尾0_鱗左_鱗2CP;

		public ColorP X0Y0_尾0_鱗左_鱗3CP;

		public ColorP X0Y0_尾0_鱗左_鱗4CP;

		public ColorP X0Y0_尾0_鱗右_鱗1CP;

		public ColorP X0Y0_尾0_鱗右_鱗2CP;

		public ColorP X0Y0_尾0_鱗右_鱗3CP;

		public ColorP X0Y0_尾0_鱗右_鱗4CP;

		public ColorP X0Y0_尾0_尾CP;

		public 拘束鎖 鎖1;

		public 拘束鎖 鎖2;

		public bool Rパタ\u30FCン;

		public Ele[] 左1_接続;

		public Ele[] 右1_接続;

		public Ele[] 左2_接続;

		public Ele[] 右2_接続;

		public Ele[] 左3_接続;

		public Ele[] 右3_接続;

		public Ele[] 左4_接続;

		public Ele[] 右4_接続;

		public Ele[] 左5_接続;

		public Ele[] 右5_接続;

		public Ele[] 左6_接続;

		public Ele[] 右6_接続;

		public Ele[] 左7_接続;

		public Ele[] 右7_接続;

		public Ele[] 左8_接続;

		public Ele[] 右8_接続;

		public Ele[] 左9_接続;

		public Ele[] 右9_接続;

		public Ele[] 左10_接続;

		public Ele[] 右10_接続;

		public Ele[] 左11_接続;

		public Ele[] 右11_接続;

		public Ele[] 左12_接続;

		public Ele[] 右12_接続;

		public Ele[] 左13_接続;

		public Ele[] 右13_接続;

		public Ele[] 左14_接続;

		public Ele[] 右14_接続;

		public Ele[] 左15_接続;

		public Ele[] 右15_接続;

		public Ele[] 左16_接続;

		public Ele[] 右16_接続;

		public Ele[] 左17_接続;

		public Ele[] 右17_接続;

		public Ele[] 左18_接続;

		public Ele[] 右18_接続;

		public Ele[] 左19_接続;

		public Ele[] 右19_接続;

		public Ele[] 左20_接続;

		public Ele[] 右20_接続;

		public Ele[] 左21_接続;

		public Ele[] 右21_接続;

		public Ele[] 左22_接続;

		public Ele[] 右22_接続;

		public Ele[] 左23_接続;

		public Ele[] 右23_接続;

		public Ele[] 左24_接続;

		public Ele[] 右24_接続;

		public Ele[] 左25_接続;

		public Ele[] 右25_接続;

		public Ele[] 左26_接続;

		public Ele[] 右26_接続;

		public Ele[] 左27_接続;

		public Ele[] 右27_接続;

		public Ele[] 左28_接続;

		public Ele[] 右28_接続;

		public Ele[] 左29_接続;

		public Ele[] 右29_接続;

		public Ele[] 左30_接続;

		public Ele[] 右30_接続;

		public Ele[] 左31_接続;

		public Ele[] 右31_接続;

		public Ele[] 左32_接続;

		public Ele[] 右32_接続;

		public Ele[] 左33_接続;

		public Ele[] 右33_接続;

		public Ele[] 左34_接続;

		public Ele[] 右34_接続;

		public Ele[] 尾先_接続;
	}
}
