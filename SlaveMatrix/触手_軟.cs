using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 触手_軟 : 触手
	{
		public 触手_軟(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 触手_軟D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "軟体";
			dif.Add(new Pars(Sta.肢左["触手"][0][0]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["節1"].ToPars();
			this.X0Y0_節1_節 = pars2["節"].ToPar();
			this.X0Y0_節1_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節1_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節1_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節1_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節1_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節1_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節1_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節2"].ToPars();
			this.X0Y0_節2_節 = pars2["節"].ToPar();
			this.X0Y0_節2_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節2_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節2_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節2_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節2_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節2_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節2_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節3"].ToPars();
			this.X0Y0_節3_節 = pars2["節"].ToPar();
			this.X0Y0_節3_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節3_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節3_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節3_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節3_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節3_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節3_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節4"].ToPars();
			this.X0Y0_節4_節 = pars2["節"].ToPar();
			this.X0Y0_節4_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節4_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節4_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節4_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節4_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節4_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節4_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節5"].ToPars();
			this.X0Y0_節5_節 = pars2["節"].ToPar();
			this.X0Y0_節5_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節5_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節5_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節5_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節5_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節5_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節5_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節6"].ToPars();
			this.X0Y0_節6_節 = pars2["節"].ToPar();
			this.X0Y0_節6_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節6_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節6_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節6_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節6_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節6_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節6_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節7"].ToPars();
			this.X0Y0_節7_節 = pars2["節"].ToPar();
			this.X0Y0_節7_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節7_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節7_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節7_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節7_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節7_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節7_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節8"].ToPars();
			this.X0Y0_節8_節 = pars2["節"].ToPar();
			this.X0Y0_節8_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節8_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節8_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節8_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節8_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節8_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節8_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["輪1"].ToPars();
			this.X0Y0_輪1_革 = pars2["革"].ToPar();
			this.X0Y0_輪1_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_輪1_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_輪1_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_輪1_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_輪1_金具右 = pars2["金具右"].ToPar();
			pars2 = pars["節9"].ToPars();
			this.X0Y0_節9_節 = pars2["節"].ToPar();
			this.X0Y0_節9_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節9_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節9_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節9_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節9_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節9_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節9_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節10"].ToPars();
			this.X0Y0_節10_節 = pars2["節"].ToPar();
			this.X0Y0_節10_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節10_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節10_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節10_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節10_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節10_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節10_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節11"].ToPars();
			this.X0Y0_節11_節 = pars2["節"].ToPar();
			this.X0Y0_節11_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節11_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節11_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節11_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節11_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節11_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節11_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節12"].ToPars();
			this.X0Y0_節12_節 = pars2["節"].ToPar();
			this.X0Y0_節12_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節12_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節12_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節12_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節12_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節12_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節12_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節13"].ToPars();
			this.X0Y0_節13_節 = pars2["節"].ToPar();
			this.X0Y0_節13_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節13_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節13_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節13_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節13_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節13_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節13_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節14"].ToPars();
			this.X0Y0_節14_節 = pars2["節"].ToPar();
			this.X0Y0_節14_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節14_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節14_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節14_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節14_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節14_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節14_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節15"].ToPars();
			this.X0Y0_節15_節 = pars2["節"].ToPar();
			this.X0Y0_節15_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節15_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節15_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節15_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節15_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節15_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節15_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節16"].ToPars();
			this.X0Y0_節16_節 = pars2["節"].ToPar();
			this.X0Y0_節16_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節16_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節16_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節16_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節16_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節16_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節16_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節17"].ToPars();
			this.X0Y0_節17_節 = pars2["節"].ToPar();
			this.X0Y0_節17_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節17_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節17_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節17_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節17_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節17_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節17_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節18"].ToPars();
			this.X0Y0_節18_節 = pars2["節"].ToPar();
			this.X0Y0_節18_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節18_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節18_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節18_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節18_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節18_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節18_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節19"].ToPars();
			this.X0Y0_節19_節 = pars2["節"].ToPar();
			this.X0Y0_節19_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節19_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節19_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節19_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節19_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節19_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節19_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["輪2"].ToPars();
			this.X0Y0_輪2_革 = pars2["革"].ToPar();
			this.X0Y0_輪2_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_輪2_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_輪2_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_輪2_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_輪2_金具右 = pars2["金具右"].ToPar();
			pars2 = pars["節20"].ToPars();
			this.X0Y0_節20_節 = pars2["節"].ToPar();
			this.X0Y0_節20_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節20_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節20_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節20_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節20_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節20_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節20_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節21"].ToPars();
			this.X0Y0_節21_節 = pars2["節"].ToPar();
			this.X0Y0_節21_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節21_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節21_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節21_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節21_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節21_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節21_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節22"].ToPars();
			this.X0Y0_節22_節 = pars2["節"].ToPar();
			this.X0Y0_節22_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節22_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節22_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節22_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節22_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節22_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節22_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節23"].ToPars();
			this.X0Y0_節23_節 = pars2["節"].ToPar();
			this.X0Y0_節23_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節23_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節23_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節23_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節23_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節23_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節23_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節24"].ToPars();
			this.X0Y0_節24_節 = pars2["節"].ToPar();
			this.X0Y0_節24_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節24_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節24_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節24_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節24_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節24_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節24_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節25"].ToPars();
			this.X0Y0_節25_節 = pars2["節"].ToPar();
			this.X0Y0_節25_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節25_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節25_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節25_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節25_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節25_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節25_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節26"].ToPars();
			this.X0Y0_節26_節 = pars2["節"].ToPar();
			this.X0Y0_節26_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節26_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節26_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節26_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節26_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節26_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節26_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節27"].ToPars();
			this.X0Y0_節27_節 = pars2["節"].ToPar();
			this.X0Y0_節27_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節27_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節27_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節27_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節27_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節27_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節27_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節28"].ToPars();
			this.X0Y0_節28_節 = pars2["節"].ToPar();
			this.X0Y0_節28_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節28_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節28_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節28_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節28_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節28_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節28_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節29"].ToPars();
			this.X0Y0_節29_節 = pars2["節"].ToPar();
			this.X0Y0_節29_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節29_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節29_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節29_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節29_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節29_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節29_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節30"].ToPars();
			this.X0Y0_節30_節 = pars2["節"].ToPar();
			this.X0Y0_節30_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節30_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節30_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節30_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節30_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節30_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節30_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節31"].ToPars();
			this.X0Y0_節31_節 = pars2["節"].ToPar();
			this.X0Y0_節31_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節31_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節31_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節31_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節31_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節31_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節31_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節32"].ToPars();
			this.X0Y0_節32_節 = pars2["節"].ToPar();
			this.X0Y0_節32_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節32_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節32_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節32_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節32_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節32_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節32_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節33"].ToPars();
			this.X0Y0_節33_節 = pars2["節"].ToPar();
			this.X0Y0_節33_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節33_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節33_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節33_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節33_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節33_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節33_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節34"].ToPars();
			this.X0Y0_節34_節 = pars2["節"].ToPar();
			this.X0Y0_節34_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節34_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節34_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節34_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節34_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節34_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節34_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節35"].ToPars();
			this.X0Y0_節35_節 = pars2["節"].ToPar();
			this.X0Y0_節35_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節35_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節35_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節35_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節35_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節35_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節35_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節36"].ToPars();
			this.X0Y0_節36_節 = pars2["節"].ToPar();
			this.X0Y0_節36_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節36_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節36_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節36_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節36_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節36_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節36_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節37"].ToPars();
			this.X0Y0_節37_節 = pars2["節"].ToPar();
			this.X0Y0_節37_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節37_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節37_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節37_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節37_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節37_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節37_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節38"].ToPars();
			this.X0Y0_節38_節 = pars2["節"].ToPar();
			this.X0Y0_節38_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節38_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節38_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節38_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節38_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節38_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節38_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節39"].ToPars();
			this.X0Y0_節39_節 = pars2["節"].ToPar();
			this.X0Y0_節39_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節39_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節39_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節39_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節39_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節39_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節39_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節40"].ToPars();
			this.X0Y0_節40_節 = pars2["節"].ToPar();
			this.X0Y0_節40_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節40_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節40_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節40_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節40_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節40_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節40_吸盤4 = pars2["吸盤4"].ToPar();
			pars2 = pars["節41"].ToPars();
			this.X0Y0_節41_節 = pars2["節"].ToPar();
			this.X0Y0_節41_紋柄1 = pars2["柄1"].ToPar();
			this.X0Y0_節41_紋柄2 = pars2["柄2"].ToPar();
			this.X0Y0_節41_鎧 = pars2["鎧"].ToPar();
			this.X0Y0_節41_吸盤1 = pars2["吸盤1"].ToPar();
			this.X0Y0_節41_吸盤2 = pars2["吸盤2"].ToPar();
			this.X0Y0_節41_吸盤3 = pars2["吸盤3"].ToPar();
			this.X0Y0_節41_吸盤4 = pars2["吸盤4"].ToPar();
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
			this.節1_節_表示 = e.節1_節_表示;
			this.節1_紋柄1_表示 = e.節1_紋柄1_表示;
			this.節1_紋柄2_表示 = e.節1_紋柄2_表示;
			this.節1_鎧_表示 = e.節1_鎧_表示;
			this.節1_吸盤1_表示 = e.節1_吸盤1_表示;
			this.節1_吸盤2_表示 = e.節1_吸盤2_表示;
			this.節1_吸盤3_表示 = e.節1_吸盤3_表示;
			this.節1_吸盤4_表示 = e.節1_吸盤4_表示;
			this.節2_節_表示 = e.節2_節_表示;
			this.節2_紋柄1_表示 = e.節2_紋柄1_表示;
			this.節2_紋柄2_表示 = e.節2_紋柄2_表示;
			this.節2_鎧_表示 = e.節2_鎧_表示;
			this.節2_吸盤1_表示 = e.節2_吸盤1_表示;
			this.節2_吸盤2_表示 = e.節2_吸盤2_表示;
			this.節2_吸盤3_表示 = e.節2_吸盤3_表示;
			this.節2_吸盤4_表示 = e.節2_吸盤4_表示;
			this.節3_節_表示 = e.節3_節_表示;
			this.節3_紋柄1_表示 = e.節3_紋柄1_表示;
			this.節3_紋柄2_表示 = e.節3_紋柄2_表示;
			this.節3_鎧_表示 = e.節3_鎧_表示;
			this.節3_吸盤1_表示 = e.節3_吸盤1_表示;
			this.節3_吸盤2_表示 = e.節3_吸盤2_表示;
			this.節3_吸盤3_表示 = e.節3_吸盤3_表示;
			this.節3_吸盤4_表示 = e.節3_吸盤4_表示;
			this.節4_節_表示 = e.節4_節_表示;
			this.節4_紋柄1_表示 = e.節4_紋柄1_表示;
			this.節4_紋柄2_表示 = e.節4_紋柄2_表示;
			this.節4_鎧_表示 = e.節4_鎧_表示;
			this.節4_吸盤1_表示 = e.節4_吸盤1_表示;
			this.節4_吸盤2_表示 = e.節4_吸盤2_表示;
			this.節4_吸盤3_表示 = e.節4_吸盤3_表示;
			this.節4_吸盤4_表示 = e.節4_吸盤4_表示;
			this.節5_節_表示 = e.節5_節_表示;
			this.節5_紋柄1_表示 = e.節5_紋柄1_表示;
			this.節5_紋柄2_表示 = e.節5_紋柄2_表示;
			this.節5_鎧_表示 = e.節5_鎧_表示;
			this.節5_吸盤1_表示 = e.節5_吸盤1_表示;
			this.節5_吸盤2_表示 = e.節5_吸盤2_表示;
			this.節5_吸盤3_表示 = e.節5_吸盤3_表示;
			this.節5_吸盤4_表示 = e.節5_吸盤4_表示;
			this.節6_節_表示 = e.節6_節_表示;
			this.節6_紋柄1_表示 = e.節6_紋柄1_表示;
			this.節6_紋柄2_表示 = e.節6_紋柄2_表示;
			this.節6_鎧_表示 = e.節6_鎧_表示;
			this.節6_吸盤1_表示 = e.節6_吸盤1_表示;
			this.節6_吸盤2_表示 = e.節6_吸盤2_表示;
			this.節6_吸盤3_表示 = e.節6_吸盤3_表示;
			this.節6_吸盤4_表示 = e.節6_吸盤4_表示;
			this.節7_節_表示 = e.節7_節_表示;
			this.節7_紋柄1_表示 = e.節7_紋柄1_表示;
			this.節7_紋柄2_表示 = e.節7_紋柄2_表示;
			this.節7_鎧_表示 = e.節7_鎧_表示;
			this.節7_吸盤1_表示 = e.節7_吸盤1_表示;
			this.節7_吸盤2_表示 = e.節7_吸盤2_表示;
			this.節7_吸盤3_表示 = e.節7_吸盤3_表示;
			this.節7_吸盤4_表示 = e.節7_吸盤4_表示;
			this.節8_節_表示 = e.節8_節_表示;
			this.節8_紋柄1_表示 = e.節8_紋柄1_表示;
			this.節8_紋柄2_表示 = e.節8_紋柄2_表示;
			this.節8_鎧_表示 = e.節8_鎧_表示;
			this.節8_吸盤1_表示 = e.節8_吸盤1_表示;
			this.節8_吸盤2_表示 = e.節8_吸盤2_表示;
			this.節8_吸盤3_表示 = e.節8_吸盤3_表示;
			this.節8_吸盤4_表示 = e.節8_吸盤4_表示;
			this.輪1_革_表示 = e.輪1_革_表示;
			this.輪1_金具1_表示 = e.輪1_金具1_表示;
			this.輪1_金具2_表示 = e.輪1_金具2_表示;
			this.輪1_金具3_表示 = e.輪1_金具3_表示;
			this.輪1_金具左_表示 = e.輪1_金具左_表示;
			this.輪1_金具右_表示 = e.輪1_金具右_表示;
			this.節9_節_表示 = e.節9_節_表示;
			this.節9_紋柄1_表示 = e.節9_紋柄1_表示;
			this.節9_紋柄2_表示 = e.節9_紋柄2_表示;
			this.節9_鎧_表示 = e.節9_鎧_表示;
			this.節9_吸盤1_表示 = e.節9_吸盤1_表示;
			this.節9_吸盤2_表示 = e.節9_吸盤2_表示;
			this.節9_吸盤3_表示 = e.節9_吸盤3_表示;
			this.節9_吸盤4_表示 = e.節9_吸盤4_表示;
			this.節10_節_表示 = e.節10_節_表示;
			this.節10_紋柄1_表示 = e.節10_紋柄1_表示;
			this.節10_紋柄2_表示 = e.節10_紋柄2_表示;
			this.節10_鎧_表示 = e.節10_鎧_表示;
			this.節10_吸盤1_表示 = e.節10_吸盤1_表示;
			this.節10_吸盤2_表示 = e.節10_吸盤2_表示;
			this.節10_吸盤3_表示 = e.節10_吸盤3_表示;
			this.節10_吸盤4_表示 = e.節10_吸盤4_表示;
			this.節11_節_表示 = e.節11_節_表示;
			this.節11_紋柄1_表示 = e.節11_紋柄1_表示;
			this.節11_紋柄2_表示 = e.節11_紋柄2_表示;
			this.節11_鎧_表示 = e.節11_鎧_表示;
			this.節11_吸盤1_表示 = e.節11_吸盤1_表示;
			this.節11_吸盤2_表示 = e.節11_吸盤2_表示;
			this.節11_吸盤3_表示 = e.節11_吸盤3_表示;
			this.節11_吸盤4_表示 = e.節11_吸盤4_表示;
			this.節12_節_表示 = e.節12_節_表示;
			this.節12_紋柄1_表示 = e.節12_紋柄1_表示;
			this.節12_紋柄2_表示 = e.節12_紋柄2_表示;
			this.節12_鎧_表示 = e.節12_鎧_表示;
			this.節12_吸盤1_表示 = e.節12_吸盤1_表示;
			this.節12_吸盤2_表示 = e.節12_吸盤2_表示;
			this.節12_吸盤3_表示 = e.節12_吸盤3_表示;
			this.節12_吸盤4_表示 = e.節12_吸盤4_表示;
			this.節13_節_表示 = e.節13_節_表示;
			this.節13_紋柄1_表示 = e.節13_紋柄1_表示;
			this.節13_紋柄2_表示 = e.節13_紋柄2_表示;
			this.節13_鎧_表示 = e.節13_鎧_表示;
			this.節13_吸盤1_表示 = e.節13_吸盤1_表示;
			this.節13_吸盤2_表示 = e.節13_吸盤2_表示;
			this.節13_吸盤3_表示 = e.節13_吸盤3_表示;
			this.節13_吸盤4_表示 = e.節13_吸盤4_表示;
			this.節14_節_表示 = e.節14_節_表示;
			this.節14_紋柄1_表示 = e.節14_紋柄1_表示;
			this.節14_紋柄2_表示 = e.節14_紋柄2_表示;
			this.節14_鎧_表示 = e.節14_鎧_表示;
			this.節14_吸盤1_表示 = e.節14_吸盤1_表示;
			this.節14_吸盤2_表示 = e.節14_吸盤2_表示;
			this.節14_吸盤3_表示 = e.節14_吸盤3_表示;
			this.節14_吸盤4_表示 = e.節14_吸盤4_表示;
			this.節15_節_表示 = e.節15_節_表示;
			this.節15_紋柄1_表示 = e.節15_紋柄1_表示;
			this.節15_紋柄2_表示 = e.節15_紋柄2_表示;
			this.節15_鎧_表示 = e.節15_鎧_表示;
			this.節15_吸盤1_表示 = e.節15_吸盤1_表示;
			this.節15_吸盤2_表示 = e.節15_吸盤2_表示;
			this.節15_吸盤3_表示 = e.節15_吸盤3_表示;
			this.節15_吸盤4_表示 = e.節15_吸盤4_表示;
			this.節16_節_表示 = e.節16_節_表示;
			this.節16_紋柄1_表示 = e.節16_紋柄1_表示;
			this.節16_紋柄2_表示 = e.節16_紋柄2_表示;
			this.節16_鎧_表示 = e.節16_鎧_表示;
			this.節16_吸盤1_表示 = e.節16_吸盤1_表示;
			this.節16_吸盤2_表示 = e.節16_吸盤2_表示;
			this.節16_吸盤3_表示 = e.節16_吸盤3_表示;
			this.節16_吸盤4_表示 = e.節16_吸盤4_表示;
			this.節17_節_表示 = e.節17_節_表示;
			this.節17_紋柄1_表示 = e.節17_紋柄1_表示;
			this.節17_紋柄2_表示 = e.節17_紋柄2_表示;
			this.節17_鎧_表示 = e.節17_鎧_表示;
			this.節17_吸盤1_表示 = e.節17_吸盤1_表示;
			this.節17_吸盤2_表示 = e.節17_吸盤2_表示;
			this.節17_吸盤3_表示 = e.節17_吸盤3_表示;
			this.節17_吸盤4_表示 = e.節17_吸盤4_表示;
			this.節18_節_表示 = e.節18_節_表示;
			this.節18_紋柄1_表示 = e.節18_紋柄1_表示;
			this.節18_紋柄2_表示 = e.節18_紋柄2_表示;
			this.節18_鎧_表示 = e.節18_鎧_表示;
			this.節18_吸盤1_表示 = e.節18_吸盤1_表示;
			this.節18_吸盤2_表示 = e.節18_吸盤2_表示;
			this.節18_吸盤3_表示 = e.節18_吸盤3_表示;
			this.節18_吸盤4_表示 = e.節18_吸盤4_表示;
			this.節19_節_表示 = e.節19_節_表示;
			this.節19_紋柄1_表示 = e.節19_紋柄1_表示;
			this.節19_紋柄2_表示 = e.節19_紋柄2_表示;
			this.節19_鎧_表示 = e.節19_鎧_表示;
			this.節19_吸盤1_表示 = e.節19_吸盤1_表示;
			this.節19_吸盤2_表示 = e.節19_吸盤2_表示;
			this.節19_吸盤3_表示 = e.節19_吸盤3_表示;
			this.節19_吸盤4_表示 = e.節19_吸盤4_表示;
			this.輪2_革_表示 = e.輪2_革_表示;
			this.輪2_金具1_表示 = e.輪2_金具1_表示;
			this.輪2_金具2_表示 = e.輪2_金具2_表示;
			this.輪2_金具3_表示 = e.輪2_金具3_表示;
			this.輪2_金具左_表示 = e.輪2_金具左_表示;
			this.輪2_金具右_表示 = e.輪2_金具右_表示;
			this.節20_節_表示 = e.節20_節_表示;
			this.節20_紋柄1_表示 = e.節20_紋柄1_表示;
			this.節20_紋柄2_表示 = e.節20_紋柄2_表示;
			this.節20_鎧_表示 = e.節20_鎧_表示;
			this.節20_吸盤1_表示 = e.節20_吸盤1_表示;
			this.節20_吸盤2_表示 = e.節20_吸盤2_表示;
			this.節20_吸盤3_表示 = e.節20_吸盤3_表示;
			this.節20_吸盤4_表示 = e.節20_吸盤4_表示;
			this.節21_節_表示 = e.節21_節_表示;
			this.節21_紋柄1_表示 = e.節21_紋柄1_表示;
			this.節21_紋柄2_表示 = e.節21_紋柄2_表示;
			this.節21_鎧_表示 = e.節21_鎧_表示;
			this.節21_吸盤1_表示 = e.節21_吸盤1_表示;
			this.節21_吸盤2_表示 = e.節21_吸盤2_表示;
			this.節21_吸盤3_表示 = e.節21_吸盤3_表示;
			this.節21_吸盤4_表示 = e.節21_吸盤4_表示;
			this.節22_節_表示 = e.節22_節_表示;
			this.節22_紋柄1_表示 = e.節22_紋柄1_表示;
			this.節22_紋柄2_表示 = e.節22_紋柄2_表示;
			this.節22_鎧_表示 = e.節22_鎧_表示;
			this.節22_吸盤1_表示 = e.節22_吸盤1_表示;
			this.節22_吸盤2_表示 = e.節22_吸盤2_表示;
			this.節22_吸盤3_表示 = e.節22_吸盤3_表示;
			this.節22_吸盤4_表示 = e.節22_吸盤4_表示;
			this.節23_節_表示 = e.節23_節_表示;
			this.節23_紋柄1_表示 = e.節23_紋柄1_表示;
			this.節23_紋柄2_表示 = e.節23_紋柄2_表示;
			this.節23_鎧_表示 = e.節23_鎧_表示;
			this.節23_吸盤1_表示 = e.節23_吸盤1_表示;
			this.節23_吸盤2_表示 = e.節23_吸盤2_表示;
			this.節23_吸盤3_表示 = e.節23_吸盤3_表示;
			this.節23_吸盤4_表示 = e.節23_吸盤4_表示;
			this.節24_節_表示 = e.節24_節_表示;
			this.節24_紋柄1_表示 = e.節24_紋柄1_表示;
			this.節24_紋柄2_表示 = e.節24_紋柄2_表示;
			this.節24_鎧_表示 = e.節24_鎧_表示;
			this.節24_吸盤1_表示 = e.節24_吸盤1_表示;
			this.節24_吸盤2_表示 = e.節24_吸盤2_表示;
			this.節24_吸盤3_表示 = e.節24_吸盤3_表示;
			this.節24_吸盤4_表示 = e.節24_吸盤4_表示;
			this.節25_節_表示 = e.節25_節_表示;
			this.節25_紋柄1_表示 = e.節25_紋柄1_表示;
			this.節25_紋柄2_表示 = e.節25_紋柄2_表示;
			this.節25_鎧_表示 = e.節25_鎧_表示;
			this.節25_吸盤1_表示 = e.節25_吸盤1_表示;
			this.節25_吸盤2_表示 = e.節25_吸盤2_表示;
			this.節25_吸盤3_表示 = e.節25_吸盤3_表示;
			this.節25_吸盤4_表示 = e.節25_吸盤4_表示;
			this.節26_節_表示 = e.節26_節_表示;
			this.節26_紋柄1_表示 = e.節26_紋柄1_表示;
			this.節26_紋柄2_表示 = e.節26_紋柄2_表示;
			this.節26_鎧_表示 = e.節26_鎧_表示;
			this.節26_吸盤1_表示 = e.節26_吸盤1_表示;
			this.節26_吸盤2_表示 = e.節26_吸盤2_表示;
			this.節26_吸盤3_表示 = e.節26_吸盤3_表示;
			this.節26_吸盤4_表示 = e.節26_吸盤4_表示;
			this.節27_節_表示 = e.節27_節_表示;
			this.節27_紋柄1_表示 = e.節27_紋柄1_表示;
			this.節27_紋柄2_表示 = e.節27_紋柄2_表示;
			this.節27_鎧_表示 = e.節27_鎧_表示;
			this.節27_吸盤1_表示 = e.節27_吸盤1_表示;
			this.節27_吸盤2_表示 = e.節27_吸盤2_表示;
			this.節27_吸盤3_表示 = e.節27_吸盤3_表示;
			this.節27_吸盤4_表示 = e.節27_吸盤4_表示;
			this.節28_節_表示 = e.節28_節_表示;
			this.節28_紋柄1_表示 = e.節28_紋柄1_表示;
			this.節28_紋柄2_表示 = e.節28_紋柄2_表示;
			this.節28_鎧_表示 = e.節28_鎧_表示;
			this.節28_吸盤1_表示 = e.節28_吸盤1_表示;
			this.節28_吸盤2_表示 = e.節28_吸盤2_表示;
			this.節28_吸盤3_表示 = e.節28_吸盤3_表示;
			this.節28_吸盤4_表示 = e.節28_吸盤4_表示;
			this.節29_節_表示 = e.節29_節_表示;
			this.節29_紋柄1_表示 = e.節29_紋柄1_表示;
			this.節29_紋柄2_表示 = e.節29_紋柄2_表示;
			this.節29_鎧_表示 = e.節29_鎧_表示;
			this.節29_吸盤1_表示 = e.節29_吸盤1_表示;
			this.節29_吸盤2_表示 = e.節29_吸盤2_表示;
			this.節29_吸盤3_表示 = e.節29_吸盤3_表示;
			this.節29_吸盤4_表示 = e.節29_吸盤4_表示;
			this.節30_節_表示 = e.節30_節_表示;
			this.節30_紋柄1_表示 = e.節30_紋柄1_表示;
			this.節30_紋柄2_表示 = e.節30_紋柄2_表示;
			this.節30_鎧_表示 = e.節30_鎧_表示;
			this.節30_吸盤1_表示 = e.節30_吸盤1_表示;
			this.節30_吸盤2_表示 = e.節30_吸盤2_表示;
			this.節30_吸盤3_表示 = e.節30_吸盤3_表示;
			this.節30_吸盤4_表示 = e.節30_吸盤4_表示;
			this.節31_節_表示 = e.節31_節_表示;
			this.節31_紋柄1_表示 = e.節31_紋柄1_表示;
			this.節31_紋柄2_表示 = e.節31_紋柄2_表示;
			this.節31_鎧_表示 = e.節31_鎧_表示;
			this.節31_吸盤1_表示 = e.節31_吸盤1_表示;
			this.節31_吸盤2_表示 = e.節31_吸盤2_表示;
			this.節31_吸盤3_表示 = e.節31_吸盤3_表示;
			this.節31_吸盤4_表示 = e.節31_吸盤4_表示;
			this.節32_節_表示 = e.節32_節_表示;
			this.節32_紋柄1_表示 = e.節32_紋柄1_表示;
			this.節32_紋柄2_表示 = e.節32_紋柄2_表示;
			this.節32_鎧_表示 = e.節32_鎧_表示;
			this.節32_吸盤1_表示 = e.節32_吸盤1_表示;
			this.節32_吸盤2_表示 = e.節32_吸盤2_表示;
			this.節32_吸盤3_表示 = e.節32_吸盤3_表示;
			this.節32_吸盤4_表示 = e.節32_吸盤4_表示;
			this.節33_節_表示 = e.節33_節_表示;
			this.節33_紋柄1_表示 = e.節33_紋柄1_表示;
			this.節33_紋柄2_表示 = e.節33_紋柄2_表示;
			this.節33_鎧_表示 = e.節33_鎧_表示;
			this.節33_吸盤1_表示 = e.節33_吸盤1_表示;
			this.節33_吸盤2_表示 = e.節33_吸盤2_表示;
			this.節33_吸盤3_表示 = e.節33_吸盤3_表示;
			this.節33_吸盤4_表示 = e.節33_吸盤4_表示;
			this.節34_節_表示 = e.節34_節_表示;
			this.節34_紋柄1_表示 = e.節34_紋柄1_表示;
			this.節34_紋柄2_表示 = e.節34_紋柄2_表示;
			this.節34_鎧_表示 = e.節34_鎧_表示;
			this.節34_吸盤1_表示 = e.節34_吸盤1_表示;
			this.節34_吸盤2_表示 = e.節34_吸盤2_表示;
			this.節34_吸盤3_表示 = e.節34_吸盤3_表示;
			this.節34_吸盤4_表示 = e.節34_吸盤4_表示;
			this.節35_節_表示 = e.節35_節_表示;
			this.節35_紋柄1_表示 = e.節35_紋柄1_表示;
			this.節35_紋柄2_表示 = e.節35_紋柄2_表示;
			this.節35_鎧_表示 = e.節35_鎧_表示;
			this.節35_吸盤1_表示 = e.節35_吸盤1_表示;
			this.節35_吸盤2_表示 = e.節35_吸盤2_表示;
			this.節35_吸盤3_表示 = e.節35_吸盤3_表示;
			this.節35_吸盤4_表示 = e.節35_吸盤4_表示;
			this.節36_節_表示 = e.節36_節_表示;
			this.節36_紋柄1_表示 = e.節36_紋柄1_表示;
			this.節36_紋柄2_表示 = e.節36_紋柄2_表示;
			this.節36_鎧_表示 = e.節36_鎧_表示;
			this.節36_吸盤1_表示 = e.節36_吸盤1_表示;
			this.節36_吸盤2_表示 = e.節36_吸盤2_表示;
			this.節36_吸盤3_表示 = e.節36_吸盤3_表示;
			this.節36_吸盤4_表示 = e.節36_吸盤4_表示;
			this.節37_節_表示 = e.節37_節_表示;
			this.節37_紋柄1_表示 = e.節37_紋柄1_表示;
			this.節37_紋柄2_表示 = e.節37_紋柄2_表示;
			this.節37_鎧_表示 = e.節37_鎧_表示;
			this.節37_吸盤1_表示 = e.節37_吸盤1_表示;
			this.節37_吸盤2_表示 = e.節37_吸盤2_表示;
			this.節37_吸盤3_表示 = e.節37_吸盤3_表示;
			this.節37_吸盤4_表示 = e.節37_吸盤4_表示;
			this.節38_節_表示 = e.節38_節_表示;
			this.節38_紋柄1_表示 = e.節38_紋柄1_表示;
			this.節38_紋柄2_表示 = e.節38_紋柄2_表示;
			this.節38_鎧_表示 = e.節38_鎧_表示;
			this.節38_吸盤1_表示 = e.節38_吸盤1_表示;
			this.節38_吸盤2_表示 = e.節38_吸盤2_表示;
			this.節38_吸盤3_表示 = e.節38_吸盤3_表示;
			this.節38_吸盤4_表示 = e.節38_吸盤4_表示;
			this.節39_節_表示 = e.節39_節_表示;
			this.節39_紋柄1_表示 = e.節39_紋柄1_表示;
			this.節39_紋柄2_表示 = e.節39_紋柄2_表示;
			this.節39_鎧_表示 = e.節39_鎧_表示;
			this.節39_吸盤1_表示 = e.節39_吸盤1_表示;
			this.節39_吸盤2_表示 = e.節39_吸盤2_表示;
			this.節39_吸盤3_表示 = e.節39_吸盤3_表示;
			this.節39_吸盤4_表示 = e.節39_吸盤4_表示;
			this.節40_節_表示 = e.節40_節_表示;
			this.節40_紋柄1_表示 = e.節40_紋柄1_表示;
			this.節40_紋柄2_表示 = e.節40_紋柄2_表示;
			this.節40_鎧_表示 = e.節40_鎧_表示;
			this.節40_吸盤1_表示 = e.節40_吸盤1_表示;
			this.節40_吸盤2_表示 = e.節40_吸盤2_表示;
			this.節40_吸盤3_表示 = e.節40_吸盤3_表示;
			this.節40_吸盤4_表示 = e.節40_吸盤4_表示;
			this.節41_節_表示 = e.節41_節_表示;
			this.節41_紋柄1_表示 = e.節41_紋柄1_表示;
			this.節41_紋柄2_表示 = e.節41_紋柄2_表示;
			this.節41_鎧_表示 = e.節41_鎧_表示;
			this.節41_吸盤1_表示 = e.節41_吸盤1_表示;
			this.節41_吸盤2_表示 = e.節41_吸盤2_表示;
			this.節41_吸盤3_表示 = e.節41_吸盤3_表示;
			this.節41_吸盤4_表示 = e.節41_吸盤4_表示;
			this.輪1表示 = e.輪1表示;
			this.輪2表示 = e.輪2表示;
			if (e.前足)
			{
				this.Set前足();
			}
			if (e.後足)
			{
				this.Set後足();
			}
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.Pars = new Par[]
			{
				this.X0Y0_節1_節,
				this.X0Y0_節2_節,
				this.X0Y0_節3_節,
				this.X0Y0_節4_節,
				this.X0Y0_節5_節,
				this.X0Y0_節6_節,
				this.X0Y0_節7_節,
				this.X0Y0_節8_節,
				this.X0Y0_節9_節,
				this.X0Y0_節10_節,
				this.X0Y0_節11_節,
				this.X0Y0_節12_節,
				this.X0Y0_節13_節,
				this.X0Y0_節14_節,
				this.X0Y0_節15_節,
				this.X0Y0_節16_節,
				this.X0Y0_節17_節,
				this.X0Y0_節18_節,
				this.X0Y0_節19_節,
				this.X0Y0_節20_節,
				this.X0Y0_節21_節,
				this.X0Y0_節22_節,
				this.X0Y0_節23_節,
				this.X0Y0_節24_節,
				this.X0Y0_節25_節,
				this.X0Y0_節26_節,
				this.X0Y0_節27_節,
				this.X0Y0_節28_節,
				this.X0Y0_節29_節,
				this.X0Y0_節30_節,
				this.X0Y0_節31_節,
				this.X0Y0_節32_節,
				this.X0Y0_節33_節,
				this.X0Y0_節34_節,
				this.X0Y0_節35_節,
				this.X0Y0_節36_節,
				this.X0Y0_節37_節,
				this.X0Y0_節38_節,
				this.X0Y0_節39_節,
				this.X0Y0_節40_節,
				this.X0Y0_節41_節
			};
			this.X0Y0_節1_節CP = new ColorP(this.X0Y0_節1_節, this.節1_節CD, DisUnit, true);
			this.X0Y0_節1_紋柄1CP = new ColorP(this.X0Y0_節1_紋柄1, this.節1_紋柄1CD, DisUnit, true);
			this.X0Y0_節1_紋柄2CP = new ColorP(this.X0Y0_節1_紋柄2, this.節1_紋柄2CD, DisUnit, true);
			this.X0Y0_節1_鎧CP = new ColorP(this.X0Y0_節1_鎧, this.節1_鎧CD, DisUnit, true);
			this.X0Y0_節1_吸盤1CP = new ColorP(this.X0Y0_節1_吸盤1, this.節1_吸盤1CD, DisUnit, true);
			this.X0Y0_節1_吸盤2CP = new ColorP(this.X0Y0_節1_吸盤2, this.節1_吸盤2CD, DisUnit, true);
			this.X0Y0_節1_吸盤3CP = new ColorP(this.X0Y0_節1_吸盤3, this.節1_吸盤3CD, DisUnit, true);
			this.X0Y0_節1_吸盤4CP = new ColorP(this.X0Y0_節1_吸盤4, this.節1_吸盤4CD, DisUnit, true);
			this.X0Y0_節2_節CP = new ColorP(this.X0Y0_節2_節, this.節2_節CD, DisUnit, true);
			this.X0Y0_節2_紋柄1CP = new ColorP(this.X0Y0_節2_紋柄1, this.節2_紋柄1CD, DisUnit, true);
			this.X0Y0_節2_紋柄2CP = new ColorP(this.X0Y0_節2_紋柄2, this.節2_紋柄2CD, DisUnit, true);
			this.X0Y0_節2_鎧CP = new ColorP(this.X0Y0_節2_鎧, this.節2_鎧CD, DisUnit, true);
			this.X0Y0_節2_吸盤1CP = new ColorP(this.X0Y0_節2_吸盤1, this.節2_吸盤1CD, DisUnit, true);
			this.X0Y0_節2_吸盤2CP = new ColorP(this.X0Y0_節2_吸盤2, this.節2_吸盤2CD, DisUnit, true);
			this.X0Y0_節2_吸盤3CP = new ColorP(this.X0Y0_節2_吸盤3, this.節2_吸盤3CD, DisUnit, true);
			this.X0Y0_節2_吸盤4CP = new ColorP(this.X0Y0_節2_吸盤4, this.節2_吸盤4CD, DisUnit, true);
			this.X0Y0_節3_節CP = new ColorP(this.X0Y0_節3_節, this.節3_節CD, DisUnit, true);
			this.X0Y0_節3_紋柄1CP = new ColorP(this.X0Y0_節3_紋柄1, this.節3_紋柄1CD, DisUnit, true);
			this.X0Y0_節3_紋柄2CP = new ColorP(this.X0Y0_節3_紋柄2, this.節3_紋柄2CD, DisUnit, true);
			this.X0Y0_節3_鎧CP = new ColorP(this.X0Y0_節3_鎧, this.節3_鎧CD, DisUnit, true);
			this.X0Y0_節3_吸盤1CP = new ColorP(this.X0Y0_節3_吸盤1, this.節3_吸盤1CD, DisUnit, true);
			this.X0Y0_節3_吸盤2CP = new ColorP(this.X0Y0_節3_吸盤2, this.節3_吸盤2CD, DisUnit, true);
			this.X0Y0_節3_吸盤3CP = new ColorP(this.X0Y0_節3_吸盤3, this.節3_吸盤3CD, DisUnit, true);
			this.X0Y0_節3_吸盤4CP = new ColorP(this.X0Y0_節3_吸盤4, this.節3_吸盤4CD, DisUnit, true);
			this.X0Y0_節4_節CP = new ColorP(this.X0Y0_節4_節, this.節4_節CD, DisUnit, true);
			this.X0Y0_節4_紋柄1CP = new ColorP(this.X0Y0_節4_紋柄1, this.節4_紋柄1CD, DisUnit, true);
			this.X0Y0_節4_紋柄2CP = new ColorP(this.X0Y0_節4_紋柄2, this.節4_紋柄2CD, DisUnit, true);
			this.X0Y0_節4_鎧CP = new ColorP(this.X0Y0_節4_鎧, this.節4_鎧CD, DisUnit, true);
			this.X0Y0_節4_吸盤1CP = new ColorP(this.X0Y0_節4_吸盤1, this.節4_吸盤1CD, DisUnit, true);
			this.X0Y0_節4_吸盤2CP = new ColorP(this.X0Y0_節4_吸盤2, this.節4_吸盤2CD, DisUnit, true);
			this.X0Y0_節4_吸盤3CP = new ColorP(this.X0Y0_節4_吸盤3, this.節4_吸盤3CD, DisUnit, true);
			this.X0Y0_節4_吸盤4CP = new ColorP(this.X0Y0_節4_吸盤4, this.節4_吸盤4CD, DisUnit, true);
			this.X0Y0_節5_節CP = new ColorP(this.X0Y0_節5_節, this.節5_節CD, DisUnit, true);
			this.X0Y0_節5_紋柄1CP = new ColorP(this.X0Y0_節5_紋柄1, this.節5_紋柄1CD, DisUnit, true);
			this.X0Y0_節5_紋柄2CP = new ColorP(this.X0Y0_節5_紋柄2, this.節5_紋柄2CD, DisUnit, true);
			this.X0Y0_節5_鎧CP = new ColorP(this.X0Y0_節5_鎧, this.節5_鎧CD, DisUnit, true);
			this.X0Y0_節5_吸盤1CP = new ColorP(this.X0Y0_節5_吸盤1, this.節5_吸盤1CD, DisUnit, true);
			this.X0Y0_節5_吸盤2CP = new ColorP(this.X0Y0_節5_吸盤2, this.節5_吸盤2CD, DisUnit, true);
			this.X0Y0_節5_吸盤3CP = new ColorP(this.X0Y0_節5_吸盤3, this.節5_吸盤3CD, DisUnit, true);
			this.X0Y0_節5_吸盤4CP = new ColorP(this.X0Y0_節5_吸盤4, this.節5_吸盤4CD, DisUnit, true);
			this.X0Y0_節6_節CP = new ColorP(this.X0Y0_節6_節, this.節6_節CD, DisUnit, true);
			this.X0Y0_節6_紋柄1CP = new ColorP(this.X0Y0_節6_紋柄1, this.節6_紋柄1CD, DisUnit, true);
			this.X0Y0_節6_紋柄2CP = new ColorP(this.X0Y0_節6_紋柄2, this.節6_紋柄2CD, DisUnit, true);
			this.X0Y0_節6_鎧CP = new ColorP(this.X0Y0_節6_鎧, this.節6_鎧CD, DisUnit, true);
			this.X0Y0_節6_吸盤1CP = new ColorP(this.X0Y0_節6_吸盤1, this.節6_吸盤1CD, DisUnit, true);
			this.X0Y0_節6_吸盤2CP = new ColorP(this.X0Y0_節6_吸盤2, this.節6_吸盤2CD, DisUnit, true);
			this.X0Y0_節6_吸盤3CP = new ColorP(this.X0Y0_節6_吸盤3, this.節6_吸盤3CD, DisUnit, true);
			this.X0Y0_節6_吸盤4CP = new ColorP(this.X0Y0_節6_吸盤4, this.節6_吸盤4CD, DisUnit, true);
			this.X0Y0_節7_節CP = new ColorP(this.X0Y0_節7_節, this.節7_節CD, DisUnit, true);
			this.X0Y0_節7_紋柄1CP = new ColorP(this.X0Y0_節7_紋柄1, this.節7_紋柄1CD, DisUnit, true);
			this.X0Y0_節7_紋柄2CP = new ColorP(this.X0Y0_節7_紋柄2, this.節7_紋柄2CD, DisUnit, true);
			this.X0Y0_節7_鎧CP = new ColorP(this.X0Y0_節7_鎧, this.節7_鎧CD, DisUnit, true);
			this.X0Y0_節7_吸盤1CP = new ColorP(this.X0Y0_節7_吸盤1, this.節7_吸盤1CD, DisUnit, true);
			this.X0Y0_節7_吸盤2CP = new ColorP(this.X0Y0_節7_吸盤2, this.節7_吸盤2CD, DisUnit, true);
			this.X0Y0_節7_吸盤3CP = new ColorP(this.X0Y0_節7_吸盤3, this.節7_吸盤3CD, DisUnit, true);
			this.X0Y0_節7_吸盤4CP = new ColorP(this.X0Y0_節7_吸盤4, this.節7_吸盤4CD, DisUnit, true);
			this.X0Y0_節8_節CP = new ColorP(this.X0Y0_節8_節, this.節8_節CD, DisUnit, true);
			this.X0Y0_節8_紋柄1CP = new ColorP(this.X0Y0_節8_紋柄1, this.節8_紋柄1CD, DisUnit, true);
			this.X0Y0_節8_紋柄2CP = new ColorP(this.X0Y0_節8_紋柄2, this.節8_紋柄2CD, DisUnit, true);
			this.X0Y0_節8_鎧CP = new ColorP(this.X0Y0_節8_鎧, this.節8_鎧CD, DisUnit, true);
			this.X0Y0_節8_吸盤1CP = new ColorP(this.X0Y0_節8_吸盤1, this.節8_吸盤1CD, DisUnit, true);
			this.X0Y0_節8_吸盤2CP = new ColorP(this.X0Y0_節8_吸盤2, this.節8_吸盤2CD, DisUnit, true);
			this.X0Y0_節8_吸盤3CP = new ColorP(this.X0Y0_節8_吸盤3, this.節8_吸盤3CD, DisUnit, true);
			this.X0Y0_節8_吸盤4CP = new ColorP(this.X0Y0_節8_吸盤4, this.節8_吸盤4CD, DisUnit, true);
			this.X0Y0_輪1_革CP = new ColorP(this.X0Y0_輪1_革, this.輪1_革CD, DisUnit, true);
			this.X0Y0_輪1_金具1CP = new ColorP(this.X0Y0_輪1_金具1, this.輪1_金具1CD, DisUnit, true);
			this.X0Y0_輪1_金具2CP = new ColorP(this.X0Y0_輪1_金具2, this.輪1_金具2CD, DisUnit, true);
			this.X0Y0_輪1_金具3CP = new ColorP(this.X0Y0_輪1_金具3, this.輪1_金具3CD, DisUnit, true);
			this.X0Y0_輪1_金具左CP = new ColorP(this.X0Y0_輪1_金具左, this.輪1_金具左CD, DisUnit, true);
			this.X0Y0_輪1_金具右CP = new ColorP(this.X0Y0_輪1_金具右, this.輪1_金具右CD, DisUnit, true);
			this.X0Y0_節9_節CP = new ColorP(this.X0Y0_節9_節, this.節9_節CD, DisUnit, true);
			this.X0Y0_節9_紋柄1CP = new ColorP(this.X0Y0_節9_紋柄1, this.節9_紋柄1CD, DisUnit, true);
			this.X0Y0_節9_紋柄2CP = new ColorP(this.X0Y0_節9_紋柄2, this.節9_紋柄2CD, DisUnit, true);
			this.X0Y0_節9_鎧CP = new ColorP(this.X0Y0_節9_鎧, this.節9_鎧CD, DisUnit, true);
			this.X0Y0_節9_吸盤1CP = new ColorP(this.X0Y0_節9_吸盤1, this.節9_吸盤1CD, DisUnit, true);
			this.X0Y0_節9_吸盤2CP = new ColorP(this.X0Y0_節9_吸盤2, this.節9_吸盤2CD, DisUnit, true);
			this.X0Y0_節9_吸盤3CP = new ColorP(this.X0Y0_節9_吸盤3, this.節9_吸盤3CD, DisUnit, true);
			this.X0Y0_節9_吸盤4CP = new ColorP(this.X0Y0_節9_吸盤4, this.節9_吸盤4CD, DisUnit, true);
			this.X0Y0_節10_節CP = new ColorP(this.X0Y0_節10_節, this.節10_節CD, DisUnit, true);
			this.X0Y0_節10_紋柄1CP = new ColorP(this.X0Y0_節10_紋柄1, this.節10_紋柄1CD, DisUnit, true);
			this.X0Y0_節10_紋柄2CP = new ColorP(this.X0Y0_節10_紋柄2, this.節10_紋柄2CD, DisUnit, true);
			this.X0Y0_節10_鎧CP = new ColorP(this.X0Y0_節10_鎧, this.節10_鎧CD, DisUnit, true);
			this.X0Y0_節10_吸盤1CP = new ColorP(this.X0Y0_節10_吸盤1, this.節10_吸盤1CD, DisUnit, true);
			this.X0Y0_節10_吸盤2CP = new ColorP(this.X0Y0_節10_吸盤2, this.節10_吸盤2CD, DisUnit, true);
			this.X0Y0_節10_吸盤3CP = new ColorP(this.X0Y0_節10_吸盤3, this.節10_吸盤3CD, DisUnit, true);
			this.X0Y0_節10_吸盤4CP = new ColorP(this.X0Y0_節10_吸盤4, this.節10_吸盤4CD, DisUnit, true);
			this.X0Y0_節11_節CP = new ColorP(this.X0Y0_節11_節, this.節11_節CD, DisUnit, true);
			this.X0Y0_節11_紋柄1CP = new ColorP(this.X0Y0_節11_紋柄1, this.節11_紋柄1CD, DisUnit, true);
			this.X0Y0_節11_紋柄2CP = new ColorP(this.X0Y0_節11_紋柄2, this.節11_紋柄2CD, DisUnit, true);
			this.X0Y0_節11_鎧CP = new ColorP(this.X0Y0_節11_鎧, this.節11_鎧CD, DisUnit, true);
			this.X0Y0_節11_吸盤1CP = new ColorP(this.X0Y0_節11_吸盤1, this.節11_吸盤1CD, DisUnit, true);
			this.X0Y0_節11_吸盤2CP = new ColorP(this.X0Y0_節11_吸盤2, this.節11_吸盤2CD, DisUnit, true);
			this.X0Y0_節11_吸盤3CP = new ColorP(this.X0Y0_節11_吸盤3, this.節11_吸盤3CD, DisUnit, true);
			this.X0Y0_節11_吸盤4CP = new ColorP(this.X0Y0_節11_吸盤4, this.節11_吸盤4CD, DisUnit, true);
			this.X0Y0_節12_節CP = new ColorP(this.X0Y0_節12_節, this.節12_節CD, DisUnit, true);
			this.X0Y0_節12_紋柄1CP = new ColorP(this.X0Y0_節12_紋柄1, this.節12_紋柄1CD, DisUnit, true);
			this.X0Y0_節12_紋柄2CP = new ColorP(this.X0Y0_節12_紋柄2, this.節12_紋柄2CD, DisUnit, true);
			this.X0Y0_節12_鎧CP = new ColorP(this.X0Y0_節12_鎧, this.節12_鎧CD, DisUnit, true);
			this.X0Y0_節12_吸盤1CP = new ColorP(this.X0Y0_節12_吸盤1, this.節12_吸盤1CD, DisUnit, true);
			this.X0Y0_節12_吸盤2CP = new ColorP(this.X0Y0_節12_吸盤2, this.節12_吸盤2CD, DisUnit, true);
			this.X0Y0_節12_吸盤3CP = new ColorP(this.X0Y0_節12_吸盤3, this.節12_吸盤3CD, DisUnit, true);
			this.X0Y0_節12_吸盤4CP = new ColorP(this.X0Y0_節12_吸盤4, this.節12_吸盤4CD, DisUnit, true);
			this.X0Y0_節13_節CP = new ColorP(this.X0Y0_節13_節, this.節13_節CD, DisUnit, true);
			this.X0Y0_節13_紋柄1CP = new ColorP(this.X0Y0_節13_紋柄1, this.節13_紋柄1CD, DisUnit, true);
			this.X0Y0_節13_紋柄2CP = new ColorP(this.X0Y0_節13_紋柄2, this.節13_紋柄2CD, DisUnit, true);
			this.X0Y0_節13_鎧CP = new ColorP(this.X0Y0_節13_鎧, this.節13_鎧CD, DisUnit, true);
			this.X0Y0_節13_吸盤1CP = new ColorP(this.X0Y0_節13_吸盤1, this.節13_吸盤1CD, DisUnit, true);
			this.X0Y0_節13_吸盤2CP = new ColorP(this.X0Y0_節13_吸盤2, this.節13_吸盤2CD, DisUnit, true);
			this.X0Y0_節13_吸盤3CP = new ColorP(this.X0Y0_節13_吸盤3, this.節13_吸盤3CD, DisUnit, true);
			this.X0Y0_節13_吸盤4CP = new ColorP(this.X0Y0_節13_吸盤4, this.節13_吸盤4CD, DisUnit, true);
			this.X0Y0_節14_節CP = new ColorP(this.X0Y0_節14_節, this.節14_節CD, DisUnit, true);
			this.X0Y0_節14_紋柄1CP = new ColorP(this.X0Y0_節14_紋柄1, this.節14_紋柄1CD, DisUnit, true);
			this.X0Y0_節14_紋柄2CP = new ColorP(this.X0Y0_節14_紋柄2, this.節14_紋柄2CD, DisUnit, true);
			this.X0Y0_節14_鎧CP = new ColorP(this.X0Y0_節14_鎧, this.節14_鎧CD, DisUnit, true);
			this.X0Y0_節14_吸盤1CP = new ColorP(this.X0Y0_節14_吸盤1, this.節14_吸盤1CD, DisUnit, true);
			this.X0Y0_節14_吸盤2CP = new ColorP(this.X0Y0_節14_吸盤2, this.節14_吸盤2CD, DisUnit, true);
			this.X0Y0_節14_吸盤3CP = new ColorP(this.X0Y0_節14_吸盤3, this.節14_吸盤3CD, DisUnit, true);
			this.X0Y0_節14_吸盤4CP = new ColorP(this.X0Y0_節14_吸盤4, this.節14_吸盤4CD, DisUnit, true);
			this.X0Y0_節15_節CP = new ColorP(this.X0Y0_節15_節, this.節15_節CD, DisUnit, true);
			this.X0Y0_節15_紋柄1CP = new ColorP(this.X0Y0_節15_紋柄1, this.節15_紋柄1CD, DisUnit, true);
			this.X0Y0_節15_紋柄2CP = new ColorP(this.X0Y0_節15_紋柄2, this.節15_紋柄2CD, DisUnit, true);
			this.X0Y0_節15_鎧CP = new ColorP(this.X0Y0_節15_鎧, this.節15_鎧CD, DisUnit, true);
			this.X0Y0_節15_吸盤1CP = new ColorP(this.X0Y0_節15_吸盤1, this.節15_吸盤1CD, DisUnit, true);
			this.X0Y0_節15_吸盤2CP = new ColorP(this.X0Y0_節15_吸盤2, this.節15_吸盤2CD, DisUnit, true);
			this.X0Y0_節15_吸盤3CP = new ColorP(this.X0Y0_節15_吸盤3, this.節15_吸盤3CD, DisUnit, true);
			this.X0Y0_節15_吸盤4CP = new ColorP(this.X0Y0_節15_吸盤4, this.節15_吸盤4CD, DisUnit, true);
			this.X0Y0_節16_節CP = new ColorP(this.X0Y0_節16_節, this.節16_節CD, DisUnit, true);
			this.X0Y0_節16_紋柄1CP = new ColorP(this.X0Y0_節16_紋柄1, this.節16_紋柄1CD, DisUnit, true);
			this.X0Y0_節16_紋柄2CP = new ColorP(this.X0Y0_節16_紋柄2, this.節16_紋柄2CD, DisUnit, true);
			this.X0Y0_節16_鎧CP = new ColorP(this.X0Y0_節16_鎧, this.節16_鎧CD, DisUnit, true);
			this.X0Y0_節16_吸盤1CP = new ColorP(this.X0Y0_節16_吸盤1, this.節16_吸盤1CD, DisUnit, true);
			this.X0Y0_節16_吸盤2CP = new ColorP(this.X0Y0_節16_吸盤2, this.節16_吸盤2CD, DisUnit, true);
			this.X0Y0_節16_吸盤3CP = new ColorP(this.X0Y0_節16_吸盤3, this.節16_吸盤3CD, DisUnit, true);
			this.X0Y0_節16_吸盤4CP = new ColorP(this.X0Y0_節16_吸盤4, this.節16_吸盤4CD, DisUnit, true);
			this.X0Y0_節17_節CP = new ColorP(this.X0Y0_節17_節, this.節17_節CD, DisUnit, true);
			this.X0Y0_節17_紋柄1CP = new ColorP(this.X0Y0_節17_紋柄1, this.節17_紋柄1CD, DisUnit, true);
			this.X0Y0_節17_紋柄2CP = new ColorP(this.X0Y0_節17_紋柄2, this.節17_紋柄2CD, DisUnit, true);
			this.X0Y0_節17_鎧CP = new ColorP(this.X0Y0_節17_鎧, this.節17_鎧CD, DisUnit, true);
			this.X0Y0_節17_吸盤1CP = new ColorP(this.X0Y0_節17_吸盤1, this.節17_吸盤1CD, DisUnit, true);
			this.X0Y0_節17_吸盤2CP = new ColorP(this.X0Y0_節17_吸盤2, this.節17_吸盤2CD, DisUnit, true);
			this.X0Y0_節17_吸盤3CP = new ColorP(this.X0Y0_節17_吸盤3, this.節17_吸盤3CD, DisUnit, true);
			this.X0Y0_節17_吸盤4CP = new ColorP(this.X0Y0_節17_吸盤4, this.節17_吸盤4CD, DisUnit, true);
			this.X0Y0_節18_節CP = new ColorP(this.X0Y0_節18_節, this.節18_節CD, DisUnit, true);
			this.X0Y0_節18_紋柄1CP = new ColorP(this.X0Y0_節18_紋柄1, this.節18_紋柄1CD, DisUnit, true);
			this.X0Y0_節18_紋柄2CP = new ColorP(this.X0Y0_節18_紋柄2, this.節18_紋柄2CD, DisUnit, true);
			this.X0Y0_節18_鎧CP = new ColorP(this.X0Y0_節18_鎧, this.節18_鎧CD, DisUnit, true);
			this.X0Y0_節18_吸盤1CP = new ColorP(this.X0Y0_節18_吸盤1, this.節18_吸盤1CD, DisUnit, true);
			this.X0Y0_節18_吸盤2CP = new ColorP(this.X0Y0_節18_吸盤2, this.節18_吸盤2CD, DisUnit, true);
			this.X0Y0_節18_吸盤3CP = new ColorP(this.X0Y0_節18_吸盤3, this.節18_吸盤3CD, DisUnit, true);
			this.X0Y0_節18_吸盤4CP = new ColorP(this.X0Y0_節18_吸盤4, this.節18_吸盤4CD, DisUnit, true);
			this.X0Y0_節19_節CP = new ColorP(this.X0Y0_節19_節, this.節19_節CD, DisUnit, true);
			this.X0Y0_節19_紋柄1CP = new ColorP(this.X0Y0_節19_紋柄1, this.節19_紋柄1CD, DisUnit, true);
			this.X0Y0_節19_紋柄2CP = new ColorP(this.X0Y0_節19_紋柄2, this.節19_紋柄2CD, DisUnit, true);
			this.X0Y0_節19_鎧CP = new ColorP(this.X0Y0_節19_鎧, this.節19_鎧CD, DisUnit, true);
			this.X0Y0_節19_吸盤1CP = new ColorP(this.X0Y0_節19_吸盤1, this.節19_吸盤1CD, DisUnit, true);
			this.X0Y0_節19_吸盤2CP = new ColorP(this.X0Y0_節19_吸盤2, this.節19_吸盤2CD, DisUnit, true);
			this.X0Y0_節19_吸盤3CP = new ColorP(this.X0Y0_節19_吸盤3, this.節19_吸盤3CD, DisUnit, true);
			this.X0Y0_節19_吸盤4CP = new ColorP(this.X0Y0_節19_吸盤4, this.節19_吸盤4CD, DisUnit, true);
			this.X0Y0_輪2_革CP = new ColorP(this.X0Y0_輪2_革, this.輪2_革CD, DisUnit, true);
			this.X0Y0_輪2_金具1CP = new ColorP(this.X0Y0_輪2_金具1, this.輪2_金具1CD, DisUnit, true);
			this.X0Y0_輪2_金具2CP = new ColorP(this.X0Y0_輪2_金具2, this.輪2_金具2CD, DisUnit, true);
			this.X0Y0_輪2_金具3CP = new ColorP(this.X0Y0_輪2_金具3, this.輪2_金具3CD, DisUnit, true);
			this.X0Y0_輪2_金具左CP = new ColorP(this.X0Y0_輪2_金具左, this.輪2_金具左CD, DisUnit, true);
			this.X0Y0_輪2_金具右CP = new ColorP(this.X0Y0_輪2_金具右, this.輪2_金具右CD, DisUnit, true);
			this.X0Y0_節20_節CP = new ColorP(this.X0Y0_節20_節, this.節20_節CD, DisUnit, true);
			this.X0Y0_節20_紋柄1CP = new ColorP(this.X0Y0_節20_紋柄1, this.節20_紋柄1CD, DisUnit, true);
			this.X0Y0_節20_紋柄2CP = new ColorP(this.X0Y0_節20_紋柄2, this.節20_紋柄2CD, DisUnit, true);
			this.X0Y0_節20_鎧CP = new ColorP(this.X0Y0_節20_鎧, this.節20_鎧CD, DisUnit, true);
			this.X0Y0_節20_吸盤1CP = new ColorP(this.X0Y0_節20_吸盤1, this.節20_吸盤1CD, DisUnit, true);
			this.X0Y0_節20_吸盤2CP = new ColorP(this.X0Y0_節20_吸盤2, this.節20_吸盤2CD, DisUnit, true);
			this.X0Y0_節20_吸盤3CP = new ColorP(this.X0Y0_節20_吸盤3, this.節20_吸盤3CD, DisUnit, true);
			this.X0Y0_節20_吸盤4CP = new ColorP(this.X0Y0_節20_吸盤4, this.節20_吸盤4CD, DisUnit, true);
			this.X0Y0_節21_節CP = new ColorP(this.X0Y0_節21_節, this.節21_節CD, DisUnit, true);
			this.X0Y0_節21_紋柄1CP = new ColorP(this.X0Y0_節21_紋柄1, this.節21_紋柄1CD, DisUnit, true);
			this.X0Y0_節21_紋柄2CP = new ColorP(this.X0Y0_節21_紋柄2, this.節21_紋柄2CD, DisUnit, true);
			this.X0Y0_節21_鎧CP = new ColorP(this.X0Y0_節21_鎧, this.節21_鎧CD, DisUnit, true);
			this.X0Y0_節21_吸盤1CP = new ColorP(this.X0Y0_節21_吸盤1, this.節21_吸盤1CD, DisUnit, true);
			this.X0Y0_節21_吸盤2CP = new ColorP(this.X0Y0_節21_吸盤2, this.節21_吸盤2CD, DisUnit, true);
			this.X0Y0_節21_吸盤3CP = new ColorP(this.X0Y0_節21_吸盤3, this.節21_吸盤3CD, DisUnit, true);
			this.X0Y0_節21_吸盤4CP = new ColorP(this.X0Y0_節21_吸盤4, this.節21_吸盤4CD, DisUnit, true);
			this.X0Y0_節22_節CP = new ColorP(this.X0Y0_節22_節, this.節22_節CD, DisUnit, true);
			this.X0Y0_節22_紋柄1CP = new ColorP(this.X0Y0_節22_紋柄1, this.節22_紋柄1CD, DisUnit, true);
			this.X0Y0_節22_紋柄2CP = new ColorP(this.X0Y0_節22_紋柄2, this.節22_紋柄2CD, DisUnit, true);
			this.X0Y0_節22_鎧CP = new ColorP(this.X0Y0_節22_鎧, this.節22_鎧CD, DisUnit, true);
			this.X0Y0_節22_吸盤1CP = new ColorP(this.X0Y0_節22_吸盤1, this.節22_吸盤1CD, DisUnit, true);
			this.X0Y0_節22_吸盤2CP = new ColorP(this.X0Y0_節22_吸盤2, this.節22_吸盤2CD, DisUnit, true);
			this.X0Y0_節22_吸盤3CP = new ColorP(this.X0Y0_節22_吸盤3, this.節22_吸盤3CD, DisUnit, true);
			this.X0Y0_節22_吸盤4CP = new ColorP(this.X0Y0_節22_吸盤4, this.節22_吸盤4CD, DisUnit, true);
			this.X0Y0_節23_節CP = new ColorP(this.X0Y0_節23_節, this.節23_節CD, DisUnit, true);
			this.X0Y0_節23_紋柄1CP = new ColorP(this.X0Y0_節23_紋柄1, this.節23_紋柄1CD, DisUnit, true);
			this.X0Y0_節23_紋柄2CP = new ColorP(this.X0Y0_節23_紋柄2, this.節23_紋柄2CD, DisUnit, true);
			this.X0Y0_節23_鎧CP = new ColorP(this.X0Y0_節23_鎧, this.節23_鎧CD, DisUnit, true);
			this.X0Y0_節23_吸盤1CP = new ColorP(this.X0Y0_節23_吸盤1, this.節23_吸盤1CD, DisUnit, true);
			this.X0Y0_節23_吸盤2CP = new ColorP(this.X0Y0_節23_吸盤2, this.節23_吸盤2CD, DisUnit, true);
			this.X0Y0_節23_吸盤3CP = new ColorP(this.X0Y0_節23_吸盤3, this.節23_吸盤3CD, DisUnit, true);
			this.X0Y0_節23_吸盤4CP = new ColorP(this.X0Y0_節23_吸盤4, this.節23_吸盤4CD, DisUnit, true);
			this.X0Y0_節24_節CP = new ColorP(this.X0Y0_節24_節, this.節24_節CD, DisUnit, true);
			this.X0Y0_節24_紋柄1CP = new ColorP(this.X0Y0_節24_紋柄1, this.節24_紋柄1CD, DisUnit, true);
			this.X0Y0_節24_紋柄2CP = new ColorP(this.X0Y0_節24_紋柄2, this.節24_紋柄2CD, DisUnit, true);
			this.X0Y0_節24_鎧CP = new ColorP(this.X0Y0_節24_鎧, this.節24_鎧CD, DisUnit, true);
			this.X0Y0_節24_吸盤1CP = new ColorP(this.X0Y0_節24_吸盤1, this.節24_吸盤1CD, DisUnit, true);
			this.X0Y0_節24_吸盤2CP = new ColorP(this.X0Y0_節24_吸盤2, this.節24_吸盤2CD, DisUnit, true);
			this.X0Y0_節24_吸盤3CP = new ColorP(this.X0Y0_節24_吸盤3, this.節24_吸盤3CD, DisUnit, true);
			this.X0Y0_節24_吸盤4CP = new ColorP(this.X0Y0_節24_吸盤4, this.節24_吸盤4CD, DisUnit, true);
			this.X0Y0_節25_節CP = new ColorP(this.X0Y0_節25_節, this.節25_節CD, DisUnit, true);
			this.X0Y0_節25_紋柄1CP = new ColorP(this.X0Y0_節25_紋柄1, this.節25_紋柄1CD, DisUnit, true);
			this.X0Y0_節25_紋柄2CP = new ColorP(this.X0Y0_節25_紋柄2, this.節25_紋柄2CD, DisUnit, true);
			this.X0Y0_節25_鎧CP = new ColorP(this.X0Y0_節25_鎧, this.節25_鎧CD, DisUnit, true);
			this.X0Y0_節25_吸盤1CP = new ColorP(this.X0Y0_節25_吸盤1, this.節25_吸盤1CD, DisUnit, true);
			this.X0Y0_節25_吸盤2CP = new ColorP(this.X0Y0_節25_吸盤2, this.節25_吸盤2CD, DisUnit, true);
			this.X0Y0_節25_吸盤3CP = new ColorP(this.X0Y0_節25_吸盤3, this.節25_吸盤3CD, DisUnit, true);
			this.X0Y0_節25_吸盤4CP = new ColorP(this.X0Y0_節25_吸盤4, this.節25_吸盤4CD, DisUnit, true);
			this.X0Y0_節26_節CP = new ColorP(this.X0Y0_節26_節, this.節26_節CD, DisUnit, true);
			this.X0Y0_節26_紋柄1CP = new ColorP(this.X0Y0_節26_紋柄1, this.節26_紋柄1CD, DisUnit, true);
			this.X0Y0_節26_紋柄2CP = new ColorP(this.X0Y0_節26_紋柄2, this.節26_紋柄2CD, DisUnit, true);
			this.X0Y0_節26_鎧CP = new ColorP(this.X0Y0_節26_鎧, this.節26_鎧CD, DisUnit, true);
			this.X0Y0_節26_吸盤1CP = new ColorP(this.X0Y0_節26_吸盤1, this.節26_吸盤1CD, DisUnit, true);
			this.X0Y0_節26_吸盤2CP = new ColorP(this.X0Y0_節26_吸盤2, this.節26_吸盤2CD, DisUnit, true);
			this.X0Y0_節26_吸盤3CP = new ColorP(this.X0Y0_節26_吸盤3, this.節26_吸盤3CD, DisUnit, true);
			this.X0Y0_節26_吸盤4CP = new ColorP(this.X0Y0_節26_吸盤4, this.節26_吸盤4CD, DisUnit, true);
			this.X0Y0_節27_節CP = new ColorP(this.X0Y0_節27_節, this.節27_節CD, DisUnit, true);
			this.X0Y0_節27_紋柄1CP = new ColorP(this.X0Y0_節27_紋柄1, this.節27_紋柄1CD, DisUnit, true);
			this.X0Y0_節27_紋柄2CP = new ColorP(this.X0Y0_節27_紋柄2, this.節27_紋柄2CD, DisUnit, true);
			this.X0Y0_節27_鎧CP = new ColorP(this.X0Y0_節27_鎧, this.節27_鎧CD, DisUnit, true);
			this.X0Y0_節27_吸盤1CP = new ColorP(this.X0Y0_節27_吸盤1, this.節27_吸盤1CD, DisUnit, true);
			this.X0Y0_節27_吸盤2CP = new ColorP(this.X0Y0_節27_吸盤2, this.節27_吸盤2CD, DisUnit, true);
			this.X0Y0_節27_吸盤3CP = new ColorP(this.X0Y0_節27_吸盤3, this.節27_吸盤3CD, DisUnit, true);
			this.X0Y0_節27_吸盤4CP = new ColorP(this.X0Y0_節27_吸盤4, this.節27_吸盤4CD, DisUnit, true);
			this.X0Y0_節28_節CP = new ColorP(this.X0Y0_節28_節, this.節28_節CD, DisUnit, true);
			this.X0Y0_節28_紋柄1CP = new ColorP(this.X0Y0_節28_紋柄1, this.節28_紋柄1CD, DisUnit, true);
			this.X0Y0_節28_紋柄2CP = new ColorP(this.X0Y0_節28_紋柄2, this.節28_紋柄2CD, DisUnit, true);
			this.X0Y0_節28_鎧CP = new ColorP(this.X0Y0_節28_鎧, this.節28_鎧CD, DisUnit, true);
			this.X0Y0_節28_吸盤1CP = new ColorP(this.X0Y0_節28_吸盤1, this.節28_吸盤1CD, DisUnit, true);
			this.X0Y0_節28_吸盤2CP = new ColorP(this.X0Y0_節28_吸盤2, this.節28_吸盤2CD, DisUnit, true);
			this.X0Y0_節28_吸盤3CP = new ColorP(this.X0Y0_節28_吸盤3, this.節28_吸盤3CD, DisUnit, true);
			this.X0Y0_節28_吸盤4CP = new ColorP(this.X0Y0_節28_吸盤4, this.節28_吸盤4CD, DisUnit, true);
			this.X0Y0_節29_節CP = new ColorP(this.X0Y0_節29_節, this.節29_節CD, DisUnit, true);
			this.X0Y0_節29_紋柄1CP = new ColorP(this.X0Y0_節29_紋柄1, this.節29_紋柄1CD, DisUnit, true);
			this.X0Y0_節29_紋柄2CP = new ColorP(this.X0Y0_節29_紋柄2, this.節29_紋柄2CD, DisUnit, true);
			this.X0Y0_節29_鎧CP = new ColorP(this.X0Y0_節29_鎧, this.節29_鎧CD, DisUnit, true);
			this.X0Y0_節29_吸盤1CP = new ColorP(this.X0Y0_節29_吸盤1, this.節29_吸盤1CD, DisUnit, true);
			this.X0Y0_節29_吸盤2CP = new ColorP(this.X0Y0_節29_吸盤2, this.節29_吸盤2CD, DisUnit, true);
			this.X0Y0_節29_吸盤3CP = new ColorP(this.X0Y0_節29_吸盤3, this.節29_吸盤3CD, DisUnit, true);
			this.X0Y0_節29_吸盤4CP = new ColorP(this.X0Y0_節29_吸盤4, this.節29_吸盤4CD, DisUnit, true);
			this.X0Y0_節30_節CP = new ColorP(this.X0Y0_節30_節, this.節30_節CD, DisUnit, true);
			this.X0Y0_節30_紋柄1CP = new ColorP(this.X0Y0_節30_紋柄1, this.節30_紋柄1CD, DisUnit, true);
			this.X0Y0_節30_紋柄2CP = new ColorP(this.X0Y0_節30_紋柄2, this.節30_紋柄2CD, DisUnit, true);
			this.X0Y0_節30_鎧CP = new ColorP(this.X0Y0_節30_鎧, this.節30_鎧CD, DisUnit, true);
			this.X0Y0_節30_吸盤1CP = new ColorP(this.X0Y0_節30_吸盤1, this.節30_吸盤1CD, DisUnit, true);
			this.X0Y0_節30_吸盤2CP = new ColorP(this.X0Y0_節30_吸盤2, this.節30_吸盤2CD, DisUnit, true);
			this.X0Y0_節30_吸盤3CP = new ColorP(this.X0Y0_節30_吸盤3, this.節30_吸盤3CD, DisUnit, true);
			this.X0Y0_節30_吸盤4CP = new ColorP(this.X0Y0_節30_吸盤4, this.節30_吸盤4CD, DisUnit, true);
			this.X0Y0_節31_節CP = new ColorP(this.X0Y0_節31_節, this.節31_節CD, DisUnit, true);
			this.X0Y0_節31_紋柄1CP = new ColorP(this.X0Y0_節31_紋柄1, this.節31_紋柄1CD, DisUnit, true);
			this.X0Y0_節31_紋柄2CP = new ColorP(this.X0Y0_節31_紋柄2, this.節31_紋柄2CD, DisUnit, true);
			this.X0Y0_節31_鎧CP = new ColorP(this.X0Y0_節31_鎧, this.節31_鎧CD, DisUnit, true);
			this.X0Y0_節31_吸盤1CP = new ColorP(this.X0Y0_節31_吸盤1, this.節31_吸盤1CD, DisUnit, true);
			this.X0Y0_節31_吸盤2CP = new ColorP(this.X0Y0_節31_吸盤2, this.節31_吸盤2CD, DisUnit, true);
			this.X0Y0_節31_吸盤3CP = new ColorP(this.X0Y0_節31_吸盤3, this.節31_吸盤3CD, DisUnit, true);
			this.X0Y0_節31_吸盤4CP = new ColorP(this.X0Y0_節31_吸盤4, this.節31_吸盤4CD, DisUnit, true);
			this.X0Y0_節32_節CP = new ColorP(this.X0Y0_節32_節, this.節32_節CD, DisUnit, true);
			this.X0Y0_節32_紋柄1CP = new ColorP(this.X0Y0_節32_紋柄1, this.節32_紋柄1CD, DisUnit, true);
			this.X0Y0_節32_紋柄2CP = new ColorP(this.X0Y0_節32_紋柄2, this.節32_紋柄2CD, DisUnit, true);
			this.X0Y0_節32_鎧CP = new ColorP(this.X0Y0_節32_鎧, this.節32_鎧CD, DisUnit, true);
			this.X0Y0_節32_吸盤1CP = new ColorP(this.X0Y0_節32_吸盤1, this.節32_吸盤1CD, DisUnit, true);
			this.X0Y0_節32_吸盤2CP = new ColorP(this.X0Y0_節32_吸盤2, this.節32_吸盤2CD, DisUnit, true);
			this.X0Y0_節32_吸盤3CP = new ColorP(this.X0Y0_節32_吸盤3, this.節32_吸盤3CD, DisUnit, true);
			this.X0Y0_節32_吸盤4CP = new ColorP(this.X0Y0_節32_吸盤4, this.節32_吸盤4CD, DisUnit, true);
			this.X0Y0_節33_節CP = new ColorP(this.X0Y0_節33_節, this.節33_節CD, DisUnit, true);
			this.X0Y0_節33_紋柄1CP = new ColorP(this.X0Y0_節33_紋柄1, this.節33_紋柄1CD, DisUnit, true);
			this.X0Y0_節33_紋柄2CP = new ColorP(this.X0Y0_節33_紋柄2, this.節33_紋柄2CD, DisUnit, true);
			this.X0Y0_節33_鎧CP = new ColorP(this.X0Y0_節33_鎧, this.節33_鎧CD, DisUnit, true);
			this.X0Y0_節33_吸盤1CP = new ColorP(this.X0Y0_節33_吸盤1, this.節33_吸盤1CD, DisUnit, true);
			this.X0Y0_節33_吸盤2CP = new ColorP(this.X0Y0_節33_吸盤2, this.節33_吸盤2CD, DisUnit, true);
			this.X0Y0_節33_吸盤3CP = new ColorP(this.X0Y0_節33_吸盤3, this.節33_吸盤3CD, DisUnit, true);
			this.X0Y0_節33_吸盤4CP = new ColorP(this.X0Y0_節33_吸盤4, this.節33_吸盤4CD, DisUnit, true);
			this.X0Y0_節34_節CP = new ColorP(this.X0Y0_節34_節, this.節34_節CD, DisUnit, true);
			this.X0Y0_節34_紋柄1CP = new ColorP(this.X0Y0_節34_紋柄1, this.節34_紋柄1CD, DisUnit, true);
			this.X0Y0_節34_紋柄2CP = new ColorP(this.X0Y0_節34_紋柄2, this.節34_紋柄2CD, DisUnit, true);
			this.X0Y0_節34_鎧CP = new ColorP(this.X0Y0_節34_鎧, this.節34_鎧CD, DisUnit, true);
			this.X0Y0_節34_吸盤1CP = new ColorP(this.X0Y0_節34_吸盤1, this.節34_吸盤1CD, DisUnit, true);
			this.X0Y0_節34_吸盤2CP = new ColorP(this.X0Y0_節34_吸盤2, this.節34_吸盤2CD, DisUnit, true);
			this.X0Y0_節34_吸盤3CP = new ColorP(this.X0Y0_節34_吸盤3, this.節34_吸盤3CD, DisUnit, true);
			this.X0Y0_節34_吸盤4CP = new ColorP(this.X0Y0_節34_吸盤4, this.節34_吸盤4CD, DisUnit, true);
			this.X0Y0_節35_節CP = new ColorP(this.X0Y0_節35_節, this.節35_節CD, DisUnit, true);
			this.X0Y0_節35_紋柄1CP = new ColorP(this.X0Y0_節35_紋柄1, this.節35_紋柄1CD, DisUnit, true);
			this.X0Y0_節35_紋柄2CP = new ColorP(this.X0Y0_節35_紋柄2, this.節35_紋柄2CD, DisUnit, true);
			this.X0Y0_節35_鎧CP = new ColorP(this.X0Y0_節35_鎧, this.節35_鎧CD, DisUnit, true);
			this.X0Y0_節35_吸盤1CP = new ColorP(this.X0Y0_節35_吸盤1, this.節35_吸盤1CD, DisUnit, true);
			this.X0Y0_節35_吸盤2CP = new ColorP(this.X0Y0_節35_吸盤2, this.節35_吸盤2CD, DisUnit, true);
			this.X0Y0_節35_吸盤3CP = new ColorP(this.X0Y0_節35_吸盤3, this.節35_吸盤3CD, DisUnit, true);
			this.X0Y0_節35_吸盤4CP = new ColorP(this.X0Y0_節35_吸盤4, this.節35_吸盤4CD, DisUnit, true);
			this.X0Y0_節36_節CP = new ColorP(this.X0Y0_節36_節, this.節36_節CD, DisUnit, true);
			this.X0Y0_節36_紋柄1CP = new ColorP(this.X0Y0_節36_紋柄1, this.節36_紋柄1CD, DisUnit, true);
			this.X0Y0_節36_紋柄2CP = new ColorP(this.X0Y0_節36_紋柄2, this.節36_紋柄2CD, DisUnit, true);
			this.X0Y0_節36_鎧CP = new ColorP(this.X0Y0_節36_鎧, this.節36_鎧CD, DisUnit, true);
			this.X0Y0_節36_吸盤1CP = new ColorP(this.X0Y0_節36_吸盤1, this.節36_吸盤1CD, DisUnit, true);
			this.X0Y0_節36_吸盤2CP = new ColorP(this.X0Y0_節36_吸盤2, this.節36_吸盤2CD, DisUnit, true);
			this.X0Y0_節36_吸盤3CP = new ColorP(this.X0Y0_節36_吸盤3, this.節36_吸盤3CD, DisUnit, true);
			this.X0Y0_節36_吸盤4CP = new ColorP(this.X0Y0_節36_吸盤4, this.節36_吸盤4CD, DisUnit, true);
			this.X0Y0_節37_節CP = new ColorP(this.X0Y0_節37_節, this.節37_節CD, DisUnit, true);
			this.X0Y0_節37_紋柄1CP = new ColorP(this.X0Y0_節37_紋柄1, this.節37_紋柄1CD, DisUnit, true);
			this.X0Y0_節37_紋柄2CP = new ColorP(this.X0Y0_節37_紋柄2, this.節37_紋柄2CD, DisUnit, true);
			this.X0Y0_節37_鎧CP = new ColorP(this.X0Y0_節37_鎧, this.節37_鎧CD, DisUnit, true);
			this.X0Y0_節37_吸盤1CP = new ColorP(this.X0Y0_節37_吸盤1, this.節37_吸盤1CD, DisUnit, true);
			this.X0Y0_節37_吸盤2CP = new ColorP(this.X0Y0_節37_吸盤2, this.節37_吸盤2CD, DisUnit, true);
			this.X0Y0_節37_吸盤3CP = new ColorP(this.X0Y0_節37_吸盤3, this.節37_吸盤3CD, DisUnit, true);
			this.X0Y0_節37_吸盤4CP = new ColorP(this.X0Y0_節37_吸盤4, this.節37_吸盤4CD, DisUnit, true);
			this.X0Y0_節38_節CP = new ColorP(this.X0Y0_節38_節, this.節38_節CD, DisUnit, true);
			this.X0Y0_節38_紋柄1CP = new ColorP(this.X0Y0_節38_紋柄1, this.節38_紋柄1CD, DisUnit, true);
			this.X0Y0_節38_紋柄2CP = new ColorP(this.X0Y0_節38_紋柄2, this.節38_紋柄2CD, DisUnit, true);
			this.X0Y0_節38_鎧CP = new ColorP(this.X0Y0_節38_鎧, this.節38_鎧CD, DisUnit, true);
			this.X0Y0_節38_吸盤1CP = new ColorP(this.X0Y0_節38_吸盤1, this.節38_吸盤1CD, DisUnit, true);
			this.X0Y0_節38_吸盤2CP = new ColorP(this.X0Y0_節38_吸盤2, this.節38_吸盤2CD, DisUnit, true);
			this.X0Y0_節38_吸盤3CP = new ColorP(this.X0Y0_節38_吸盤3, this.節38_吸盤3CD, DisUnit, true);
			this.X0Y0_節38_吸盤4CP = new ColorP(this.X0Y0_節38_吸盤4, this.節38_吸盤4CD, DisUnit, true);
			this.X0Y0_節39_節CP = new ColorP(this.X0Y0_節39_節, this.節39_節CD, DisUnit, true);
			this.X0Y0_節39_紋柄1CP = new ColorP(this.X0Y0_節39_紋柄1, this.節39_紋柄1CD, DisUnit, true);
			this.X0Y0_節39_紋柄2CP = new ColorP(this.X0Y0_節39_紋柄2, this.節39_紋柄2CD, DisUnit, true);
			this.X0Y0_節39_鎧CP = new ColorP(this.X0Y0_節39_鎧, this.節39_鎧CD, DisUnit, true);
			this.X0Y0_節39_吸盤1CP = new ColorP(this.X0Y0_節39_吸盤1, this.節39_吸盤1CD, DisUnit, true);
			this.X0Y0_節39_吸盤2CP = new ColorP(this.X0Y0_節39_吸盤2, this.節39_吸盤2CD, DisUnit, true);
			this.X0Y0_節39_吸盤3CP = new ColorP(this.X0Y0_節39_吸盤3, this.節39_吸盤3CD, DisUnit, true);
			this.X0Y0_節39_吸盤4CP = new ColorP(this.X0Y0_節39_吸盤4, this.節39_吸盤4CD, DisUnit, true);
			this.X0Y0_節40_節CP = new ColorP(this.X0Y0_節40_節, this.節40_節CD, DisUnit, true);
			this.X0Y0_節40_紋柄1CP = new ColorP(this.X0Y0_節40_紋柄1, this.節40_紋柄1CD, DisUnit, true);
			this.X0Y0_節40_紋柄2CP = new ColorP(this.X0Y0_節40_紋柄2, this.節40_紋柄2CD, DisUnit, true);
			this.X0Y0_節40_鎧CP = new ColorP(this.X0Y0_節40_鎧, this.節40_鎧CD, DisUnit, true);
			this.X0Y0_節40_吸盤1CP = new ColorP(this.X0Y0_節40_吸盤1, this.節40_吸盤1CD, DisUnit, true);
			this.X0Y0_節40_吸盤2CP = new ColorP(this.X0Y0_節40_吸盤2, this.節40_吸盤2CD, DisUnit, true);
			this.X0Y0_節40_吸盤3CP = new ColorP(this.X0Y0_節40_吸盤3, this.節40_吸盤3CD, DisUnit, true);
			this.X0Y0_節40_吸盤4CP = new ColorP(this.X0Y0_節40_吸盤4, this.節40_吸盤4CD, DisUnit, true);
			this.X0Y0_節41_節CP = new ColorP(this.X0Y0_節41_節, this.節41_節CD, DisUnit, true);
			this.X0Y0_節41_紋柄1CP = new ColorP(this.X0Y0_節41_紋柄1, this.節41_紋柄1CD, DisUnit, true);
			this.X0Y0_節41_紋柄2CP = new ColorP(this.X0Y0_節41_紋柄2, this.節41_紋柄2CD, DisUnit, true);
			this.X0Y0_節41_鎧CP = new ColorP(this.X0Y0_節41_鎧, this.節41_鎧CD, DisUnit, true);
			this.X0Y0_節41_吸盤1CP = new ColorP(this.X0Y0_節41_吸盤1, this.節41_吸盤1CD, DisUnit, true);
			this.X0Y0_節41_吸盤2CP = new ColorP(this.X0Y0_節41_吸盤2, this.節41_吸盤2CD, DisUnit, true);
			this.X0Y0_節41_吸盤3CP = new ColorP(this.X0Y0_節41_吸盤3, this.節41_吸盤3CD, DisUnit, true);
			this.X0Y0_節41_吸盤4CP = new ColorP(this.X0Y0_節41_吸盤4, this.節41_吸盤4CD, DisUnit, true);
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
			this.鎖1.角度B += (double)num;
			this.鎖2.角度B -= (double)num;
			this.鎖3.角度B -= (double)num;
			this.鎖4.角度B += (double)num;
			this.鎖表示 = e.鎖表示;
			this.節1_吸盤2_表示 = false;
			this.節1_吸盤4_表示 = false;
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

		public bool 節1_節_表示
		{
			get
			{
				return this.X0Y0_節1_節.Dra;
			}
			set
			{
				this.X0Y0_節1_節.Dra = value;
				this.X0Y0_節1_節.Hit = value;
			}
		}

		public bool 節1_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節1_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節1_紋柄1.Dra = value;
				this.X0Y0_節1_紋柄1.Hit = value;
			}
		}

		public bool 節1_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節1_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節1_紋柄2.Dra = value;
				this.X0Y0_節1_紋柄2.Hit = value;
			}
		}

		public bool 節1_鎧_表示
		{
			get
			{
				return this.X0Y0_節1_鎧.Dra;
			}
			set
			{
				this.X0Y0_節1_鎧.Dra = value;
				this.X0Y0_節1_鎧.Hit = value;
			}
		}

		public bool 節1_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節1_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節1_吸盤1.Dra = value;
				this.X0Y0_節1_吸盤1.Hit = value;
			}
		}

		public bool 節1_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節1_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節1_吸盤2.Dra = value;
				this.X0Y0_節1_吸盤2.Hit = value;
			}
		}

		public bool 節1_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節1_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節1_吸盤3.Dra = value;
				this.X0Y0_節1_吸盤3.Hit = value;
			}
		}

		public bool 節1_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節1_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節1_吸盤4.Dra = value;
				this.X0Y0_節1_吸盤4.Hit = value;
			}
		}

		public bool 節2_節_表示
		{
			get
			{
				return this.X0Y0_節2_節.Dra;
			}
			set
			{
				this.X0Y0_節2_節.Dra = value;
				this.X0Y0_節2_節.Hit = value;
			}
		}

		public bool 節2_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節2_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節2_紋柄1.Dra = value;
				this.X0Y0_節2_紋柄1.Hit = value;
			}
		}

		public bool 節2_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節2_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節2_紋柄2.Dra = value;
				this.X0Y0_節2_紋柄2.Hit = value;
			}
		}

		public bool 節2_鎧_表示
		{
			get
			{
				return this.X0Y0_節2_鎧.Dra;
			}
			set
			{
				this.X0Y0_節2_鎧.Dra = value;
				this.X0Y0_節2_鎧.Hit = value;
			}
		}

		public bool 節2_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節2_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節2_吸盤1.Dra = value;
				this.X0Y0_節2_吸盤1.Hit = value;
			}
		}

		public bool 節2_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節2_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節2_吸盤2.Dra = value;
				this.X0Y0_節2_吸盤2.Hit = value;
			}
		}

		public bool 節2_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節2_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節2_吸盤3.Dra = value;
				this.X0Y0_節2_吸盤3.Hit = value;
			}
		}

		public bool 節2_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節2_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節2_吸盤4.Dra = value;
				this.X0Y0_節2_吸盤4.Hit = value;
			}
		}

		public bool 節3_節_表示
		{
			get
			{
				return this.X0Y0_節3_節.Dra;
			}
			set
			{
				this.X0Y0_節3_節.Dra = value;
				this.X0Y0_節3_節.Hit = value;
			}
		}

		public bool 節3_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節3_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節3_紋柄1.Dra = value;
				this.X0Y0_節3_紋柄1.Hit = value;
			}
		}

		public bool 節3_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節3_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節3_紋柄2.Dra = value;
				this.X0Y0_節3_紋柄2.Hit = value;
			}
		}

		public bool 節3_鎧_表示
		{
			get
			{
				return this.X0Y0_節3_鎧.Dra;
			}
			set
			{
				this.X0Y0_節3_鎧.Dra = value;
				this.X0Y0_節3_鎧.Hit = value;
			}
		}

		public bool 節3_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節3_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節3_吸盤1.Dra = value;
				this.X0Y0_節3_吸盤1.Hit = value;
			}
		}

		public bool 節3_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節3_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節3_吸盤2.Dra = value;
				this.X0Y0_節3_吸盤2.Hit = value;
			}
		}

		public bool 節3_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節3_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節3_吸盤3.Dra = value;
				this.X0Y0_節3_吸盤3.Hit = value;
			}
		}

		public bool 節3_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節3_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節3_吸盤4.Dra = value;
				this.X0Y0_節3_吸盤4.Hit = value;
			}
		}

		public bool 節4_節_表示
		{
			get
			{
				return this.X0Y0_節4_節.Dra;
			}
			set
			{
				this.X0Y0_節4_節.Dra = value;
				this.X0Y0_節4_節.Hit = value;
			}
		}

		public bool 節4_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節4_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節4_紋柄1.Dra = value;
				this.X0Y0_節4_紋柄1.Hit = value;
			}
		}

		public bool 節4_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節4_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節4_紋柄2.Dra = value;
				this.X0Y0_節4_紋柄2.Hit = value;
			}
		}

		public bool 節4_鎧_表示
		{
			get
			{
				return this.X0Y0_節4_鎧.Dra;
			}
			set
			{
				this.X0Y0_節4_鎧.Dra = value;
				this.X0Y0_節4_鎧.Hit = value;
			}
		}

		public bool 節4_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節4_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節4_吸盤1.Dra = value;
				this.X0Y0_節4_吸盤1.Hit = value;
			}
		}

		public bool 節4_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節4_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節4_吸盤2.Dra = value;
				this.X0Y0_節4_吸盤2.Hit = value;
			}
		}

		public bool 節4_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節4_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節4_吸盤3.Dra = value;
				this.X0Y0_節4_吸盤3.Hit = value;
			}
		}

		public bool 節4_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節4_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節4_吸盤4.Dra = value;
				this.X0Y0_節4_吸盤4.Hit = value;
			}
		}

		public bool 節5_節_表示
		{
			get
			{
				return this.X0Y0_節5_節.Dra;
			}
			set
			{
				this.X0Y0_節5_節.Dra = value;
				this.X0Y0_節5_節.Hit = value;
			}
		}

		public bool 節5_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節5_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節5_紋柄1.Dra = value;
				this.X0Y0_節5_紋柄1.Hit = value;
			}
		}

		public bool 節5_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節5_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節5_紋柄2.Dra = value;
				this.X0Y0_節5_紋柄2.Hit = value;
			}
		}

		public bool 節5_鎧_表示
		{
			get
			{
				return this.X0Y0_節5_鎧.Dra;
			}
			set
			{
				this.X0Y0_節5_鎧.Dra = value;
				this.X0Y0_節5_鎧.Hit = value;
			}
		}

		public bool 節5_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節5_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節5_吸盤1.Dra = value;
				this.X0Y0_節5_吸盤1.Hit = value;
			}
		}

		public bool 節5_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節5_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節5_吸盤2.Dra = value;
				this.X0Y0_節5_吸盤2.Hit = value;
			}
		}

		public bool 節5_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節5_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節5_吸盤3.Dra = value;
				this.X0Y0_節5_吸盤3.Hit = value;
			}
		}

		public bool 節5_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節5_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節5_吸盤4.Dra = value;
				this.X0Y0_節5_吸盤4.Hit = value;
			}
		}

		public bool 節6_節_表示
		{
			get
			{
				return this.X0Y0_節6_節.Dra;
			}
			set
			{
				this.X0Y0_節6_節.Dra = value;
				this.X0Y0_節6_節.Hit = value;
			}
		}

		public bool 節6_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節6_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節6_紋柄1.Dra = value;
				this.X0Y0_節6_紋柄1.Hit = value;
			}
		}

		public bool 節6_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節6_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節6_紋柄2.Dra = value;
				this.X0Y0_節6_紋柄2.Hit = value;
			}
		}

		public bool 節6_鎧_表示
		{
			get
			{
				return this.X0Y0_節6_鎧.Dra;
			}
			set
			{
				this.X0Y0_節6_鎧.Dra = value;
				this.X0Y0_節6_鎧.Hit = value;
			}
		}

		public bool 節6_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節6_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節6_吸盤1.Dra = value;
				this.X0Y0_節6_吸盤1.Hit = value;
			}
		}

		public bool 節6_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節6_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節6_吸盤2.Dra = value;
				this.X0Y0_節6_吸盤2.Hit = value;
			}
		}

		public bool 節6_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節6_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節6_吸盤3.Dra = value;
				this.X0Y0_節6_吸盤3.Hit = value;
			}
		}

		public bool 節6_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節6_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節6_吸盤4.Dra = value;
				this.X0Y0_節6_吸盤4.Hit = value;
			}
		}

		public bool 節7_節_表示
		{
			get
			{
				return this.X0Y0_節7_節.Dra;
			}
			set
			{
				this.X0Y0_節7_節.Dra = value;
				this.X0Y0_節7_節.Hit = value;
			}
		}

		public bool 節7_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節7_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節7_紋柄1.Dra = value;
				this.X0Y0_節7_紋柄1.Hit = value;
			}
		}

		public bool 節7_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節7_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節7_紋柄2.Dra = value;
				this.X0Y0_節7_紋柄2.Hit = value;
			}
		}

		public bool 節7_鎧_表示
		{
			get
			{
				return this.X0Y0_節7_鎧.Dra;
			}
			set
			{
				this.X0Y0_節7_鎧.Dra = value;
				this.X0Y0_節7_鎧.Hit = value;
			}
		}

		public bool 節7_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節7_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節7_吸盤1.Dra = value;
				this.X0Y0_節7_吸盤1.Hit = value;
			}
		}

		public bool 節7_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節7_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節7_吸盤2.Dra = value;
				this.X0Y0_節7_吸盤2.Hit = value;
			}
		}

		public bool 節7_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節7_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節7_吸盤3.Dra = value;
				this.X0Y0_節7_吸盤3.Hit = value;
			}
		}

		public bool 節7_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節7_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節7_吸盤4.Dra = value;
				this.X0Y0_節7_吸盤4.Hit = value;
			}
		}

		public bool 節8_節_表示
		{
			get
			{
				return this.X0Y0_節8_節.Dra;
			}
			set
			{
				this.X0Y0_節8_節.Dra = value;
				this.X0Y0_節8_節.Hit = value;
			}
		}

		public bool 節8_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節8_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節8_紋柄1.Dra = value;
				this.X0Y0_節8_紋柄1.Hit = value;
			}
		}

		public bool 節8_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節8_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節8_紋柄2.Dra = value;
				this.X0Y0_節8_紋柄2.Hit = value;
			}
		}

		public bool 節8_鎧_表示
		{
			get
			{
				return this.X0Y0_節8_鎧.Dra;
			}
			set
			{
				this.X0Y0_節8_鎧.Dra = value;
				this.X0Y0_節8_鎧.Hit = value;
			}
		}

		public bool 節8_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節8_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節8_吸盤1.Dra = value;
				this.X0Y0_節8_吸盤1.Hit = value;
			}
		}

		public bool 節8_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節8_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節8_吸盤2.Dra = value;
				this.X0Y0_節8_吸盤2.Hit = value;
			}
		}

		public bool 節8_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節8_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節8_吸盤3.Dra = value;
				this.X0Y0_節8_吸盤3.Hit = value;
			}
		}

		public bool 節8_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節8_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節8_吸盤4.Dra = value;
				this.X0Y0_節8_吸盤4.Hit = value;
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

		public bool 節9_節_表示
		{
			get
			{
				return this.X0Y0_節9_節.Dra;
			}
			set
			{
				this.X0Y0_節9_節.Dra = value;
				this.X0Y0_節9_節.Hit = value;
			}
		}

		public bool 節9_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節9_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節9_紋柄1.Dra = value;
				this.X0Y0_節9_紋柄1.Hit = value;
			}
		}

		public bool 節9_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節9_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節9_紋柄2.Dra = value;
				this.X0Y0_節9_紋柄2.Hit = value;
			}
		}

		public bool 節9_鎧_表示
		{
			get
			{
				return this.X0Y0_節9_鎧.Dra;
			}
			set
			{
				this.X0Y0_節9_鎧.Dra = value;
				this.X0Y0_節9_鎧.Hit = value;
			}
		}

		public bool 節9_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節9_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節9_吸盤1.Dra = value;
				this.X0Y0_節9_吸盤1.Hit = value;
			}
		}

		public bool 節9_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節9_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節9_吸盤2.Dra = value;
				this.X0Y0_節9_吸盤2.Hit = value;
			}
		}

		public bool 節9_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節9_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節9_吸盤3.Dra = value;
				this.X0Y0_節9_吸盤3.Hit = value;
			}
		}

		public bool 節9_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節9_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節9_吸盤4.Dra = value;
				this.X0Y0_節9_吸盤4.Hit = value;
			}
		}

		public bool 節10_節_表示
		{
			get
			{
				return this.X0Y0_節10_節.Dra;
			}
			set
			{
				this.X0Y0_節10_節.Dra = value;
				this.X0Y0_節10_節.Hit = value;
			}
		}

		public bool 節10_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節10_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節10_紋柄1.Dra = value;
				this.X0Y0_節10_紋柄1.Hit = value;
			}
		}

		public bool 節10_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節10_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節10_紋柄2.Dra = value;
				this.X0Y0_節10_紋柄2.Hit = value;
			}
		}

		public bool 節10_鎧_表示
		{
			get
			{
				return this.X0Y0_節10_鎧.Dra;
			}
			set
			{
				this.X0Y0_節10_鎧.Dra = value;
				this.X0Y0_節10_鎧.Hit = value;
			}
		}

		public bool 節10_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節10_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節10_吸盤1.Dra = value;
				this.X0Y0_節10_吸盤1.Hit = value;
			}
		}

		public bool 節10_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節10_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節10_吸盤2.Dra = value;
				this.X0Y0_節10_吸盤2.Hit = value;
			}
		}

		public bool 節10_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節10_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節10_吸盤3.Dra = value;
				this.X0Y0_節10_吸盤3.Hit = value;
			}
		}

		public bool 節10_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節10_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節10_吸盤4.Dra = value;
				this.X0Y0_節10_吸盤4.Hit = value;
			}
		}

		public bool 節11_節_表示
		{
			get
			{
				return this.X0Y0_節11_節.Dra;
			}
			set
			{
				this.X0Y0_節11_節.Dra = value;
				this.X0Y0_節11_節.Hit = value;
			}
		}

		public bool 節11_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節11_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節11_紋柄1.Dra = value;
				this.X0Y0_節11_紋柄1.Hit = value;
			}
		}

		public bool 節11_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節11_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節11_紋柄2.Dra = value;
				this.X0Y0_節11_紋柄2.Hit = value;
			}
		}

		public bool 節11_鎧_表示
		{
			get
			{
				return this.X0Y0_節11_鎧.Dra;
			}
			set
			{
				this.X0Y0_節11_鎧.Dra = value;
				this.X0Y0_節11_鎧.Hit = value;
			}
		}

		public bool 節11_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節11_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節11_吸盤1.Dra = value;
				this.X0Y0_節11_吸盤1.Hit = value;
			}
		}

		public bool 節11_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節11_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節11_吸盤2.Dra = value;
				this.X0Y0_節11_吸盤2.Hit = value;
			}
		}

		public bool 節11_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節11_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節11_吸盤3.Dra = value;
				this.X0Y0_節11_吸盤3.Hit = value;
			}
		}

		public bool 節11_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節11_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節11_吸盤4.Dra = value;
				this.X0Y0_節11_吸盤4.Hit = value;
			}
		}

		public bool 節12_節_表示
		{
			get
			{
				return this.X0Y0_節12_節.Dra;
			}
			set
			{
				this.X0Y0_節12_節.Dra = value;
				this.X0Y0_節12_節.Hit = value;
			}
		}

		public bool 節12_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節12_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節12_紋柄1.Dra = value;
				this.X0Y0_節12_紋柄1.Hit = value;
			}
		}

		public bool 節12_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節12_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節12_紋柄2.Dra = value;
				this.X0Y0_節12_紋柄2.Hit = value;
			}
		}

		public bool 節12_鎧_表示
		{
			get
			{
				return this.X0Y0_節12_鎧.Dra;
			}
			set
			{
				this.X0Y0_節12_鎧.Dra = value;
				this.X0Y0_節12_鎧.Hit = value;
			}
		}

		public bool 節12_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節12_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節12_吸盤1.Dra = value;
				this.X0Y0_節12_吸盤1.Hit = value;
			}
		}

		public bool 節12_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節12_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節12_吸盤2.Dra = value;
				this.X0Y0_節12_吸盤2.Hit = value;
			}
		}

		public bool 節12_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節12_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節12_吸盤3.Dra = value;
				this.X0Y0_節12_吸盤3.Hit = value;
			}
		}

		public bool 節12_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節12_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節12_吸盤4.Dra = value;
				this.X0Y0_節12_吸盤4.Hit = value;
			}
		}

		public bool 節13_節_表示
		{
			get
			{
				return this.X0Y0_節13_節.Dra;
			}
			set
			{
				this.X0Y0_節13_節.Dra = value;
				this.X0Y0_節13_節.Hit = value;
			}
		}

		public bool 節13_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節13_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節13_紋柄1.Dra = value;
				this.X0Y0_節13_紋柄1.Hit = value;
			}
		}

		public bool 節13_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節13_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節13_紋柄2.Dra = value;
				this.X0Y0_節13_紋柄2.Hit = value;
			}
		}

		public bool 節13_鎧_表示
		{
			get
			{
				return this.X0Y0_節13_鎧.Dra;
			}
			set
			{
				this.X0Y0_節13_鎧.Dra = value;
				this.X0Y0_節13_鎧.Hit = value;
			}
		}

		public bool 節13_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節13_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節13_吸盤1.Dra = value;
				this.X0Y0_節13_吸盤1.Hit = value;
			}
		}

		public bool 節13_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節13_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節13_吸盤2.Dra = value;
				this.X0Y0_節13_吸盤2.Hit = value;
			}
		}

		public bool 節13_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節13_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節13_吸盤3.Dra = value;
				this.X0Y0_節13_吸盤3.Hit = value;
			}
		}

		public bool 節13_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節13_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節13_吸盤4.Dra = value;
				this.X0Y0_節13_吸盤4.Hit = value;
			}
		}

		public bool 節14_節_表示
		{
			get
			{
				return this.X0Y0_節14_節.Dra;
			}
			set
			{
				this.X0Y0_節14_節.Dra = value;
				this.X0Y0_節14_節.Hit = value;
			}
		}

		public bool 節14_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節14_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節14_紋柄1.Dra = value;
				this.X0Y0_節14_紋柄1.Hit = value;
			}
		}

		public bool 節14_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節14_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節14_紋柄2.Dra = value;
				this.X0Y0_節14_紋柄2.Hit = value;
			}
		}

		public bool 節14_鎧_表示
		{
			get
			{
				return this.X0Y0_節14_鎧.Dra;
			}
			set
			{
				this.X0Y0_節14_鎧.Dra = value;
				this.X0Y0_節14_鎧.Hit = value;
			}
		}

		public bool 節14_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節14_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節14_吸盤1.Dra = value;
				this.X0Y0_節14_吸盤1.Hit = value;
			}
		}

		public bool 節14_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節14_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節14_吸盤2.Dra = value;
				this.X0Y0_節14_吸盤2.Hit = value;
			}
		}

		public bool 節14_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節14_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節14_吸盤3.Dra = value;
				this.X0Y0_節14_吸盤3.Hit = value;
			}
		}

		public bool 節14_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節14_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節14_吸盤4.Dra = value;
				this.X0Y0_節14_吸盤4.Hit = value;
			}
		}

		public bool 節15_節_表示
		{
			get
			{
				return this.X0Y0_節15_節.Dra;
			}
			set
			{
				this.X0Y0_節15_節.Dra = value;
				this.X0Y0_節15_節.Hit = value;
			}
		}

		public bool 節15_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節15_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節15_紋柄1.Dra = value;
				this.X0Y0_節15_紋柄1.Hit = value;
			}
		}

		public bool 節15_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節15_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節15_紋柄2.Dra = value;
				this.X0Y0_節15_紋柄2.Hit = value;
			}
		}

		public bool 節15_鎧_表示
		{
			get
			{
				return this.X0Y0_節15_鎧.Dra;
			}
			set
			{
				this.X0Y0_節15_鎧.Dra = value;
				this.X0Y0_節15_鎧.Hit = value;
			}
		}

		public bool 節15_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節15_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節15_吸盤1.Dra = value;
				this.X0Y0_節15_吸盤1.Hit = value;
			}
		}

		public bool 節15_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節15_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節15_吸盤2.Dra = value;
				this.X0Y0_節15_吸盤2.Hit = value;
			}
		}

		public bool 節15_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節15_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節15_吸盤3.Dra = value;
				this.X0Y0_節15_吸盤3.Hit = value;
			}
		}

		public bool 節15_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節15_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節15_吸盤4.Dra = value;
				this.X0Y0_節15_吸盤4.Hit = value;
			}
		}

		public bool 節16_節_表示
		{
			get
			{
				return this.X0Y0_節16_節.Dra;
			}
			set
			{
				this.X0Y0_節16_節.Dra = value;
				this.X0Y0_節16_節.Hit = value;
			}
		}

		public bool 節16_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節16_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節16_紋柄1.Dra = value;
				this.X0Y0_節16_紋柄1.Hit = value;
			}
		}

		public bool 節16_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節16_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節16_紋柄2.Dra = value;
				this.X0Y0_節16_紋柄2.Hit = value;
			}
		}

		public bool 節16_鎧_表示
		{
			get
			{
				return this.X0Y0_節16_鎧.Dra;
			}
			set
			{
				this.X0Y0_節16_鎧.Dra = value;
				this.X0Y0_節16_鎧.Hit = value;
			}
		}

		public bool 節16_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節16_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節16_吸盤1.Dra = value;
				this.X0Y0_節16_吸盤1.Hit = value;
			}
		}

		public bool 節16_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節16_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節16_吸盤2.Dra = value;
				this.X0Y0_節16_吸盤2.Hit = value;
			}
		}

		public bool 節16_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節16_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節16_吸盤3.Dra = value;
				this.X0Y0_節16_吸盤3.Hit = value;
			}
		}

		public bool 節16_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節16_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節16_吸盤4.Dra = value;
				this.X0Y0_節16_吸盤4.Hit = value;
			}
		}

		public bool 節17_節_表示
		{
			get
			{
				return this.X0Y0_節17_節.Dra;
			}
			set
			{
				this.X0Y0_節17_節.Dra = value;
				this.X0Y0_節17_節.Hit = value;
			}
		}

		public bool 節17_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節17_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節17_紋柄1.Dra = value;
				this.X0Y0_節17_紋柄1.Hit = value;
			}
		}

		public bool 節17_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節17_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節17_紋柄2.Dra = value;
				this.X0Y0_節17_紋柄2.Hit = value;
			}
		}

		public bool 節17_鎧_表示
		{
			get
			{
				return this.X0Y0_節17_鎧.Dra;
			}
			set
			{
				this.X0Y0_節17_鎧.Dra = value;
				this.X0Y0_節17_鎧.Hit = value;
			}
		}

		public bool 節17_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節17_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節17_吸盤1.Dra = value;
				this.X0Y0_節17_吸盤1.Hit = value;
			}
		}

		public bool 節17_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節17_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節17_吸盤2.Dra = value;
				this.X0Y0_節17_吸盤2.Hit = value;
			}
		}

		public bool 節17_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節17_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節17_吸盤3.Dra = value;
				this.X0Y0_節17_吸盤3.Hit = value;
			}
		}

		public bool 節17_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節17_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節17_吸盤4.Dra = value;
				this.X0Y0_節17_吸盤4.Hit = value;
			}
		}

		public bool 節18_節_表示
		{
			get
			{
				return this.X0Y0_節18_節.Dra;
			}
			set
			{
				this.X0Y0_節18_節.Dra = value;
				this.X0Y0_節18_節.Hit = value;
			}
		}

		public bool 節18_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節18_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節18_紋柄1.Dra = value;
				this.X0Y0_節18_紋柄1.Hit = value;
			}
		}

		public bool 節18_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節18_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節18_紋柄2.Dra = value;
				this.X0Y0_節18_紋柄2.Hit = value;
			}
		}

		public bool 節18_鎧_表示
		{
			get
			{
				return this.X0Y0_節18_鎧.Dra;
			}
			set
			{
				this.X0Y0_節18_鎧.Dra = value;
				this.X0Y0_節18_鎧.Hit = value;
			}
		}

		public bool 節18_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節18_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節18_吸盤1.Dra = value;
				this.X0Y0_節18_吸盤1.Hit = value;
			}
		}

		public bool 節18_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節18_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節18_吸盤2.Dra = value;
				this.X0Y0_節18_吸盤2.Hit = value;
			}
		}

		public bool 節18_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節18_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節18_吸盤3.Dra = value;
				this.X0Y0_節18_吸盤3.Hit = value;
			}
		}

		public bool 節18_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節18_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節18_吸盤4.Dra = value;
				this.X0Y0_節18_吸盤4.Hit = value;
			}
		}

		public bool 節19_節_表示
		{
			get
			{
				return this.X0Y0_節19_節.Dra;
			}
			set
			{
				this.X0Y0_節19_節.Dra = value;
				this.X0Y0_節19_節.Hit = value;
			}
		}

		public bool 節19_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節19_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節19_紋柄1.Dra = value;
				this.X0Y0_節19_紋柄1.Hit = value;
			}
		}

		public bool 節19_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節19_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節19_紋柄2.Dra = value;
				this.X0Y0_節19_紋柄2.Hit = value;
			}
		}

		public bool 節19_鎧_表示
		{
			get
			{
				return this.X0Y0_節19_鎧.Dra;
			}
			set
			{
				this.X0Y0_節19_鎧.Dra = value;
				this.X0Y0_節19_鎧.Hit = value;
			}
		}

		public bool 節19_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節19_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節19_吸盤1.Dra = value;
				this.X0Y0_節19_吸盤1.Hit = value;
			}
		}

		public bool 節19_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節19_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節19_吸盤2.Dra = value;
				this.X0Y0_節19_吸盤2.Hit = value;
			}
		}

		public bool 節19_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節19_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節19_吸盤3.Dra = value;
				this.X0Y0_節19_吸盤3.Hit = value;
			}
		}

		public bool 節19_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節19_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節19_吸盤4.Dra = value;
				this.X0Y0_節19_吸盤4.Hit = value;
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

		public bool 節20_節_表示
		{
			get
			{
				return this.X0Y0_節20_節.Dra;
			}
			set
			{
				this.X0Y0_節20_節.Dra = value;
				this.X0Y0_節20_節.Hit = value;
			}
		}

		public bool 節20_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節20_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節20_紋柄1.Dra = value;
				this.X0Y0_節20_紋柄1.Hit = value;
			}
		}

		public bool 節20_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節20_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節20_紋柄2.Dra = value;
				this.X0Y0_節20_紋柄2.Hit = value;
			}
		}

		public bool 節20_鎧_表示
		{
			get
			{
				return this.X0Y0_節20_鎧.Dra;
			}
			set
			{
				this.X0Y0_節20_鎧.Dra = value;
				this.X0Y0_節20_鎧.Hit = value;
			}
		}

		public bool 節20_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節20_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節20_吸盤1.Dra = value;
				this.X0Y0_節20_吸盤1.Hit = value;
			}
		}

		public bool 節20_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節20_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節20_吸盤2.Dra = value;
				this.X0Y0_節20_吸盤2.Hit = value;
			}
		}

		public bool 節20_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節20_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節20_吸盤3.Dra = value;
				this.X0Y0_節20_吸盤3.Hit = value;
			}
		}

		public bool 節20_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節20_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節20_吸盤4.Dra = value;
				this.X0Y0_節20_吸盤4.Hit = value;
			}
		}

		public bool 節21_節_表示
		{
			get
			{
				return this.X0Y0_節21_節.Dra;
			}
			set
			{
				this.X0Y0_節21_節.Dra = value;
				this.X0Y0_節21_節.Hit = value;
			}
		}

		public bool 節21_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節21_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節21_紋柄1.Dra = value;
				this.X0Y0_節21_紋柄1.Hit = value;
			}
		}

		public bool 節21_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節21_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節21_紋柄2.Dra = value;
				this.X0Y0_節21_紋柄2.Hit = value;
			}
		}

		public bool 節21_鎧_表示
		{
			get
			{
				return this.X0Y0_節21_鎧.Dra;
			}
			set
			{
				this.X0Y0_節21_鎧.Dra = value;
				this.X0Y0_節21_鎧.Hit = value;
			}
		}

		public bool 節21_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節21_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節21_吸盤1.Dra = value;
				this.X0Y0_節21_吸盤1.Hit = value;
			}
		}

		public bool 節21_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節21_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節21_吸盤2.Dra = value;
				this.X0Y0_節21_吸盤2.Hit = value;
			}
		}

		public bool 節21_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節21_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節21_吸盤3.Dra = value;
				this.X0Y0_節21_吸盤3.Hit = value;
			}
		}

		public bool 節21_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節21_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節21_吸盤4.Dra = value;
				this.X0Y0_節21_吸盤4.Hit = value;
			}
		}

		public bool 節22_節_表示
		{
			get
			{
				return this.X0Y0_節22_節.Dra;
			}
			set
			{
				this.X0Y0_節22_節.Dra = value;
				this.X0Y0_節22_節.Hit = value;
			}
		}

		public bool 節22_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節22_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節22_紋柄1.Dra = value;
				this.X0Y0_節22_紋柄1.Hit = value;
			}
		}

		public bool 節22_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節22_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節22_紋柄2.Dra = value;
				this.X0Y0_節22_紋柄2.Hit = value;
			}
		}

		public bool 節22_鎧_表示
		{
			get
			{
				return this.X0Y0_節22_鎧.Dra;
			}
			set
			{
				this.X0Y0_節22_鎧.Dra = value;
				this.X0Y0_節22_鎧.Hit = value;
			}
		}

		public bool 節22_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節22_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節22_吸盤1.Dra = value;
				this.X0Y0_節22_吸盤1.Hit = value;
			}
		}

		public bool 節22_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節22_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節22_吸盤2.Dra = value;
				this.X0Y0_節22_吸盤2.Hit = value;
			}
		}

		public bool 節22_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節22_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節22_吸盤3.Dra = value;
				this.X0Y0_節22_吸盤3.Hit = value;
			}
		}

		public bool 節22_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節22_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節22_吸盤4.Dra = value;
				this.X0Y0_節22_吸盤4.Hit = value;
			}
		}

		public bool 節23_節_表示
		{
			get
			{
				return this.X0Y0_節23_節.Dra;
			}
			set
			{
				this.X0Y0_節23_節.Dra = value;
				this.X0Y0_節23_節.Hit = value;
			}
		}

		public bool 節23_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節23_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節23_紋柄1.Dra = value;
				this.X0Y0_節23_紋柄1.Hit = value;
			}
		}

		public bool 節23_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節23_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節23_紋柄2.Dra = value;
				this.X0Y0_節23_紋柄2.Hit = value;
			}
		}

		public bool 節23_鎧_表示
		{
			get
			{
				return this.X0Y0_節23_鎧.Dra;
			}
			set
			{
				this.X0Y0_節23_鎧.Dra = value;
				this.X0Y0_節23_鎧.Hit = value;
			}
		}

		public bool 節23_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節23_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節23_吸盤1.Dra = value;
				this.X0Y0_節23_吸盤1.Hit = value;
			}
		}

		public bool 節23_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節23_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節23_吸盤2.Dra = value;
				this.X0Y0_節23_吸盤2.Hit = value;
			}
		}

		public bool 節23_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節23_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節23_吸盤3.Dra = value;
				this.X0Y0_節23_吸盤3.Hit = value;
			}
		}

		public bool 節23_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節23_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節23_吸盤4.Dra = value;
				this.X0Y0_節23_吸盤4.Hit = value;
			}
		}

		public bool 節24_節_表示
		{
			get
			{
				return this.X0Y0_節24_節.Dra;
			}
			set
			{
				this.X0Y0_節24_節.Dra = value;
				this.X0Y0_節24_節.Hit = value;
			}
		}

		public bool 節24_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節24_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節24_紋柄1.Dra = value;
				this.X0Y0_節24_紋柄1.Hit = value;
			}
		}

		public bool 節24_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節24_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節24_紋柄2.Dra = value;
				this.X0Y0_節24_紋柄2.Hit = value;
			}
		}

		public bool 節24_鎧_表示
		{
			get
			{
				return this.X0Y0_節24_鎧.Dra;
			}
			set
			{
				this.X0Y0_節24_鎧.Dra = value;
				this.X0Y0_節24_鎧.Hit = value;
			}
		}

		public bool 節24_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節24_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節24_吸盤1.Dra = value;
				this.X0Y0_節24_吸盤1.Hit = value;
			}
		}

		public bool 節24_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節24_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節24_吸盤2.Dra = value;
				this.X0Y0_節24_吸盤2.Hit = value;
			}
		}

		public bool 節24_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節24_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節24_吸盤3.Dra = value;
				this.X0Y0_節24_吸盤3.Hit = value;
			}
		}

		public bool 節24_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節24_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節24_吸盤4.Dra = value;
				this.X0Y0_節24_吸盤4.Hit = value;
			}
		}

		public bool 節25_節_表示
		{
			get
			{
				return this.X0Y0_節25_節.Dra;
			}
			set
			{
				this.X0Y0_節25_節.Dra = value;
				this.X0Y0_節25_節.Hit = value;
			}
		}

		public bool 節25_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節25_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節25_紋柄1.Dra = value;
				this.X0Y0_節25_紋柄1.Hit = value;
			}
		}

		public bool 節25_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節25_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節25_紋柄2.Dra = value;
				this.X0Y0_節25_紋柄2.Hit = value;
			}
		}

		public bool 節25_鎧_表示
		{
			get
			{
				return this.X0Y0_節25_鎧.Dra;
			}
			set
			{
				this.X0Y0_節25_鎧.Dra = value;
				this.X0Y0_節25_鎧.Hit = value;
			}
		}

		public bool 節25_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節25_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節25_吸盤1.Dra = value;
				this.X0Y0_節25_吸盤1.Hit = value;
			}
		}

		public bool 節25_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節25_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節25_吸盤2.Dra = value;
				this.X0Y0_節25_吸盤2.Hit = value;
			}
		}

		public bool 節25_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節25_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節25_吸盤3.Dra = value;
				this.X0Y0_節25_吸盤3.Hit = value;
			}
		}

		public bool 節25_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節25_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節25_吸盤4.Dra = value;
				this.X0Y0_節25_吸盤4.Hit = value;
			}
		}

		public bool 節26_節_表示
		{
			get
			{
				return this.X0Y0_節26_節.Dra;
			}
			set
			{
				this.X0Y0_節26_節.Dra = value;
				this.X0Y0_節26_節.Hit = value;
			}
		}

		public bool 節26_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節26_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節26_紋柄1.Dra = value;
				this.X0Y0_節26_紋柄1.Hit = value;
			}
		}

		public bool 節26_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節26_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節26_紋柄2.Dra = value;
				this.X0Y0_節26_紋柄2.Hit = value;
			}
		}

		public bool 節26_鎧_表示
		{
			get
			{
				return this.X0Y0_節26_鎧.Dra;
			}
			set
			{
				this.X0Y0_節26_鎧.Dra = value;
				this.X0Y0_節26_鎧.Hit = value;
			}
		}

		public bool 節26_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節26_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節26_吸盤1.Dra = value;
				this.X0Y0_節26_吸盤1.Hit = value;
			}
		}

		public bool 節26_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節26_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節26_吸盤2.Dra = value;
				this.X0Y0_節26_吸盤2.Hit = value;
			}
		}

		public bool 節26_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節26_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節26_吸盤3.Dra = value;
				this.X0Y0_節26_吸盤3.Hit = value;
			}
		}

		public bool 節26_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節26_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節26_吸盤4.Dra = value;
				this.X0Y0_節26_吸盤4.Hit = value;
			}
		}

		public bool 節27_節_表示
		{
			get
			{
				return this.X0Y0_節27_節.Dra;
			}
			set
			{
				this.X0Y0_節27_節.Dra = value;
				this.X0Y0_節27_節.Hit = value;
			}
		}

		public bool 節27_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節27_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節27_紋柄1.Dra = value;
				this.X0Y0_節27_紋柄1.Hit = value;
			}
		}

		public bool 節27_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節27_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節27_紋柄2.Dra = value;
				this.X0Y0_節27_紋柄2.Hit = value;
			}
		}

		public bool 節27_鎧_表示
		{
			get
			{
				return this.X0Y0_節27_鎧.Dra;
			}
			set
			{
				this.X0Y0_節27_鎧.Dra = value;
				this.X0Y0_節27_鎧.Hit = value;
			}
		}

		public bool 節27_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節27_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節27_吸盤1.Dra = value;
				this.X0Y0_節27_吸盤1.Hit = value;
			}
		}

		public bool 節27_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節27_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節27_吸盤2.Dra = value;
				this.X0Y0_節27_吸盤2.Hit = value;
			}
		}

		public bool 節27_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節27_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節27_吸盤3.Dra = value;
				this.X0Y0_節27_吸盤3.Hit = value;
			}
		}

		public bool 節27_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節27_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節27_吸盤4.Dra = value;
				this.X0Y0_節27_吸盤4.Hit = value;
			}
		}

		public bool 節28_節_表示
		{
			get
			{
				return this.X0Y0_節28_節.Dra;
			}
			set
			{
				this.X0Y0_節28_節.Dra = value;
				this.X0Y0_節28_節.Hit = value;
			}
		}

		public bool 節28_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節28_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節28_紋柄1.Dra = value;
				this.X0Y0_節28_紋柄1.Hit = value;
			}
		}

		public bool 節28_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節28_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節28_紋柄2.Dra = value;
				this.X0Y0_節28_紋柄2.Hit = value;
			}
		}

		public bool 節28_鎧_表示
		{
			get
			{
				return this.X0Y0_節28_鎧.Dra;
			}
			set
			{
				this.X0Y0_節28_鎧.Dra = value;
				this.X0Y0_節28_鎧.Hit = value;
			}
		}

		public bool 節28_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節28_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節28_吸盤1.Dra = value;
				this.X0Y0_節28_吸盤1.Hit = value;
			}
		}

		public bool 節28_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節28_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節28_吸盤2.Dra = value;
				this.X0Y0_節28_吸盤2.Hit = value;
			}
		}

		public bool 節28_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節28_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節28_吸盤3.Dra = value;
				this.X0Y0_節28_吸盤3.Hit = value;
			}
		}

		public bool 節28_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節28_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節28_吸盤4.Dra = value;
				this.X0Y0_節28_吸盤4.Hit = value;
			}
		}

		public bool 節29_節_表示
		{
			get
			{
				return this.X0Y0_節29_節.Dra;
			}
			set
			{
				this.X0Y0_節29_節.Dra = value;
				this.X0Y0_節29_節.Hit = value;
			}
		}

		public bool 節29_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節29_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節29_紋柄1.Dra = value;
				this.X0Y0_節29_紋柄1.Hit = value;
			}
		}

		public bool 節29_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節29_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節29_紋柄2.Dra = value;
				this.X0Y0_節29_紋柄2.Hit = value;
			}
		}

		public bool 節29_鎧_表示
		{
			get
			{
				return this.X0Y0_節29_鎧.Dra;
			}
			set
			{
				this.X0Y0_節29_鎧.Dra = value;
				this.X0Y0_節29_鎧.Hit = value;
			}
		}

		public bool 節29_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節29_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節29_吸盤1.Dra = value;
				this.X0Y0_節29_吸盤1.Hit = value;
			}
		}

		public bool 節29_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節29_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節29_吸盤2.Dra = value;
				this.X0Y0_節29_吸盤2.Hit = value;
			}
		}

		public bool 節29_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節29_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節29_吸盤3.Dra = value;
				this.X0Y0_節29_吸盤3.Hit = value;
			}
		}

		public bool 節29_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節29_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節29_吸盤4.Dra = value;
				this.X0Y0_節29_吸盤4.Hit = value;
			}
		}

		public bool 節30_節_表示
		{
			get
			{
				return this.X0Y0_節30_節.Dra;
			}
			set
			{
				this.X0Y0_節30_節.Dra = value;
				this.X0Y0_節30_節.Hit = value;
			}
		}

		public bool 節30_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節30_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節30_紋柄1.Dra = value;
				this.X0Y0_節30_紋柄1.Hit = value;
			}
		}

		public bool 節30_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節30_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節30_紋柄2.Dra = value;
				this.X0Y0_節30_紋柄2.Hit = value;
			}
		}

		public bool 節30_鎧_表示
		{
			get
			{
				return this.X0Y0_節30_鎧.Dra;
			}
			set
			{
				this.X0Y0_節30_鎧.Dra = value;
				this.X0Y0_節30_鎧.Hit = value;
			}
		}

		public bool 節30_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節30_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節30_吸盤1.Dra = value;
				this.X0Y0_節30_吸盤1.Hit = value;
			}
		}

		public bool 節30_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節30_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節30_吸盤2.Dra = value;
				this.X0Y0_節30_吸盤2.Hit = value;
			}
		}

		public bool 節30_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節30_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節30_吸盤3.Dra = value;
				this.X0Y0_節30_吸盤3.Hit = value;
			}
		}

		public bool 節30_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節30_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節30_吸盤4.Dra = value;
				this.X0Y0_節30_吸盤4.Hit = value;
			}
		}

		public bool 節31_節_表示
		{
			get
			{
				return this.X0Y0_節31_節.Dra;
			}
			set
			{
				this.X0Y0_節31_節.Dra = value;
				this.X0Y0_節31_節.Hit = value;
			}
		}

		public bool 節31_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節31_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節31_紋柄1.Dra = value;
				this.X0Y0_節31_紋柄1.Hit = value;
			}
		}

		public bool 節31_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節31_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節31_紋柄2.Dra = value;
				this.X0Y0_節31_紋柄2.Hit = value;
			}
		}

		public bool 節31_鎧_表示
		{
			get
			{
				return this.X0Y0_節31_鎧.Dra;
			}
			set
			{
				this.X0Y0_節31_鎧.Dra = value;
				this.X0Y0_節31_鎧.Hit = value;
			}
		}

		public bool 節31_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節31_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節31_吸盤1.Dra = value;
				this.X0Y0_節31_吸盤1.Hit = value;
			}
		}

		public bool 節31_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節31_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節31_吸盤2.Dra = value;
				this.X0Y0_節31_吸盤2.Hit = value;
			}
		}

		public bool 節31_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節31_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節31_吸盤3.Dra = value;
				this.X0Y0_節31_吸盤3.Hit = value;
			}
		}

		public bool 節31_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節31_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節31_吸盤4.Dra = value;
				this.X0Y0_節31_吸盤4.Hit = value;
			}
		}

		public bool 節32_節_表示
		{
			get
			{
				return this.X0Y0_節32_節.Dra;
			}
			set
			{
				this.X0Y0_節32_節.Dra = value;
				this.X0Y0_節32_節.Hit = value;
			}
		}

		public bool 節32_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節32_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節32_紋柄1.Dra = value;
				this.X0Y0_節32_紋柄1.Hit = value;
			}
		}

		public bool 節32_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節32_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節32_紋柄2.Dra = value;
				this.X0Y0_節32_紋柄2.Hit = value;
			}
		}

		public bool 節32_鎧_表示
		{
			get
			{
				return this.X0Y0_節32_鎧.Dra;
			}
			set
			{
				this.X0Y0_節32_鎧.Dra = value;
				this.X0Y0_節32_鎧.Hit = value;
			}
		}

		public bool 節32_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節32_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節32_吸盤1.Dra = value;
				this.X0Y0_節32_吸盤1.Hit = value;
			}
		}

		public bool 節32_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節32_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節32_吸盤2.Dra = value;
				this.X0Y0_節32_吸盤2.Hit = value;
			}
		}

		public bool 節32_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節32_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節32_吸盤3.Dra = value;
				this.X0Y0_節32_吸盤3.Hit = value;
			}
		}

		public bool 節32_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節32_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節32_吸盤4.Dra = value;
				this.X0Y0_節32_吸盤4.Hit = value;
			}
		}

		public bool 節33_節_表示
		{
			get
			{
				return this.X0Y0_節33_節.Dra;
			}
			set
			{
				this.X0Y0_節33_節.Dra = value;
				this.X0Y0_節33_節.Hit = value;
			}
		}

		public bool 節33_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節33_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節33_紋柄1.Dra = value;
				this.X0Y0_節33_紋柄1.Hit = value;
			}
		}

		public bool 節33_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節33_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節33_紋柄2.Dra = value;
				this.X0Y0_節33_紋柄2.Hit = value;
			}
		}

		public bool 節33_鎧_表示
		{
			get
			{
				return this.X0Y0_節33_鎧.Dra;
			}
			set
			{
				this.X0Y0_節33_鎧.Dra = value;
				this.X0Y0_節33_鎧.Hit = value;
			}
		}

		public bool 節33_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節33_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節33_吸盤1.Dra = value;
				this.X0Y0_節33_吸盤1.Hit = value;
			}
		}

		public bool 節33_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節33_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節33_吸盤2.Dra = value;
				this.X0Y0_節33_吸盤2.Hit = value;
			}
		}

		public bool 節33_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節33_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節33_吸盤3.Dra = value;
				this.X0Y0_節33_吸盤3.Hit = value;
			}
		}

		public bool 節33_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節33_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節33_吸盤4.Dra = value;
				this.X0Y0_節33_吸盤4.Hit = value;
			}
		}

		public bool 節34_節_表示
		{
			get
			{
				return this.X0Y0_節34_節.Dra;
			}
			set
			{
				this.X0Y0_節34_節.Dra = value;
				this.X0Y0_節34_節.Hit = value;
			}
		}

		public bool 節34_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節34_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節34_紋柄1.Dra = value;
				this.X0Y0_節34_紋柄1.Hit = value;
			}
		}

		public bool 節34_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節34_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節34_紋柄2.Dra = value;
				this.X0Y0_節34_紋柄2.Hit = value;
			}
		}

		public bool 節34_鎧_表示
		{
			get
			{
				return this.X0Y0_節34_鎧.Dra;
			}
			set
			{
				this.X0Y0_節34_鎧.Dra = value;
				this.X0Y0_節34_鎧.Hit = value;
			}
		}

		public bool 節34_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節34_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節34_吸盤1.Dra = value;
				this.X0Y0_節34_吸盤1.Hit = value;
			}
		}

		public bool 節34_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節34_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節34_吸盤2.Dra = value;
				this.X0Y0_節34_吸盤2.Hit = value;
			}
		}

		public bool 節34_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節34_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節34_吸盤3.Dra = value;
				this.X0Y0_節34_吸盤3.Hit = value;
			}
		}

		public bool 節34_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節34_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節34_吸盤4.Dra = value;
				this.X0Y0_節34_吸盤4.Hit = value;
			}
		}

		public bool 節35_節_表示
		{
			get
			{
				return this.X0Y0_節35_節.Dra;
			}
			set
			{
				this.X0Y0_節35_節.Dra = value;
				this.X0Y0_節35_節.Hit = value;
			}
		}

		public bool 節35_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節35_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節35_紋柄1.Dra = value;
				this.X0Y0_節35_紋柄1.Hit = value;
			}
		}

		public bool 節35_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節35_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節35_紋柄2.Dra = value;
				this.X0Y0_節35_紋柄2.Hit = value;
			}
		}

		public bool 節35_鎧_表示
		{
			get
			{
				return this.X0Y0_節35_鎧.Dra;
			}
			set
			{
				this.X0Y0_節35_鎧.Dra = value;
				this.X0Y0_節35_鎧.Hit = value;
			}
		}

		public bool 節35_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節35_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節35_吸盤1.Dra = value;
				this.X0Y0_節35_吸盤1.Hit = value;
			}
		}

		public bool 節35_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節35_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節35_吸盤2.Dra = value;
				this.X0Y0_節35_吸盤2.Hit = value;
			}
		}

		public bool 節35_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節35_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節35_吸盤3.Dra = value;
				this.X0Y0_節35_吸盤3.Hit = value;
			}
		}

		public bool 節35_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節35_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節35_吸盤4.Dra = value;
				this.X0Y0_節35_吸盤4.Hit = value;
			}
		}

		public bool 節36_節_表示
		{
			get
			{
				return this.X0Y0_節36_節.Dra;
			}
			set
			{
				this.X0Y0_節36_節.Dra = value;
				this.X0Y0_節36_節.Hit = value;
			}
		}

		public bool 節36_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節36_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節36_紋柄1.Dra = value;
				this.X0Y0_節36_紋柄1.Hit = value;
			}
		}

		public bool 節36_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節36_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節36_紋柄2.Dra = value;
				this.X0Y0_節36_紋柄2.Hit = value;
			}
		}

		public bool 節36_鎧_表示
		{
			get
			{
				return this.X0Y0_節36_鎧.Dra;
			}
			set
			{
				this.X0Y0_節36_鎧.Dra = value;
				this.X0Y0_節36_鎧.Hit = value;
			}
		}

		public bool 節36_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節36_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節36_吸盤1.Dra = value;
				this.X0Y0_節36_吸盤1.Hit = value;
			}
		}

		public bool 節36_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節36_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節36_吸盤2.Dra = value;
				this.X0Y0_節36_吸盤2.Hit = value;
			}
		}

		public bool 節36_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節36_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節36_吸盤3.Dra = value;
				this.X0Y0_節36_吸盤3.Hit = value;
			}
		}

		public bool 節36_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節36_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節36_吸盤4.Dra = value;
				this.X0Y0_節36_吸盤4.Hit = value;
			}
		}

		public bool 節37_節_表示
		{
			get
			{
				return this.X0Y0_節37_節.Dra;
			}
			set
			{
				this.X0Y0_節37_節.Dra = value;
				this.X0Y0_節37_節.Hit = value;
			}
		}

		public bool 節37_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節37_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節37_紋柄1.Dra = value;
				this.X0Y0_節37_紋柄1.Hit = value;
			}
		}

		public bool 節37_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節37_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節37_紋柄2.Dra = value;
				this.X0Y0_節37_紋柄2.Hit = value;
			}
		}

		public bool 節37_鎧_表示
		{
			get
			{
				return this.X0Y0_節37_鎧.Dra;
			}
			set
			{
				this.X0Y0_節37_鎧.Dra = value;
				this.X0Y0_節37_鎧.Hit = value;
			}
		}

		public bool 節37_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節37_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節37_吸盤1.Dra = value;
				this.X0Y0_節37_吸盤1.Hit = value;
			}
		}

		public bool 節37_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節37_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節37_吸盤2.Dra = value;
				this.X0Y0_節37_吸盤2.Hit = value;
			}
		}

		public bool 節37_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節37_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節37_吸盤3.Dra = value;
				this.X0Y0_節37_吸盤3.Hit = value;
			}
		}

		public bool 節37_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節37_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節37_吸盤4.Dra = value;
				this.X0Y0_節37_吸盤4.Hit = value;
			}
		}

		public bool 節38_節_表示
		{
			get
			{
				return this.X0Y0_節38_節.Dra;
			}
			set
			{
				this.X0Y0_節38_節.Dra = value;
				this.X0Y0_節38_節.Hit = value;
			}
		}

		public bool 節38_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節38_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節38_紋柄1.Dra = value;
				this.X0Y0_節38_紋柄1.Hit = value;
			}
		}

		public bool 節38_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節38_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節38_紋柄2.Dra = value;
				this.X0Y0_節38_紋柄2.Hit = value;
			}
		}

		public bool 節38_鎧_表示
		{
			get
			{
				return this.X0Y0_節38_鎧.Dra;
			}
			set
			{
				this.X0Y0_節38_鎧.Dra = value;
				this.X0Y0_節38_鎧.Hit = value;
			}
		}

		public bool 節38_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節38_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節38_吸盤1.Dra = value;
				this.X0Y0_節38_吸盤1.Hit = value;
			}
		}

		public bool 節38_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節38_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節38_吸盤2.Dra = value;
				this.X0Y0_節38_吸盤2.Hit = value;
			}
		}

		public bool 節38_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節38_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節38_吸盤3.Dra = value;
				this.X0Y0_節38_吸盤3.Hit = value;
			}
		}

		public bool 節38_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節38_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節38_吸盤4.Dra = value;
				this.X0Y0_節38_吸盤4.Hit = value;
			}
		}

		public bool 節39_節_表示
		{
			get
			{
				return this.X0Y0_節39_節.Dra;
			}
			set
			{
				this.X0Y0_節39_節.Dra = value;
				this.X0Y0_節39_節.Hit = value;
			}
		}

		public bool 節39_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節39_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節39_紋柄1.Dra = value;
				this.X0Y0_節39_紋柄1.Hit = value;
			}
		}

		public bool 節39_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節39_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節39_紋柄2.Dra = value;
				this.X0Y0_節39_紋柄2.Hit = value;
			}
		}

		public bool 節39_鎧_表示
		{
			get
			{
				return this.X0Y0_節39_鎧.Dra;
			}
			set
			{
				this.X0Y0_節39_鎧.Dra = value;
				this.X0Y0_節39_鎧.Hit = value;
			}
		}

		public bool 節39_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節39_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節39_吸盤1.Dra = value;
				this.X0Y0_節39_吸盤1.Hit = value;
			}
		}

		public bool 節39_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節39_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節39_吸盤2.Dra = value;
				this.X0Y0_節39_吸盤2.Hit = value;
			}
		}

		public bool 節39_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節39_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節39_吸盤3.Dra = value;
				this.X0Y0_節39_吸盤3.Hit = value;
			}
		}

		public bool 節39_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節39_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節39_吸盤4.Dra = value;
				this.X0Y0_節39_吸盤4.Hit = value;
			}
		}

		public bool 節40_節_表示
		{
			get
			{
				return this.X0Y0_節40_節.Dra;
			}
			set
			{
				this.X0Y0_節40_節.Dra = value;
				this.X0Y0_節40_節.Hit = value;
			}
		}

		public bool 節40_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節40_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節40_紋柄1.Dra = value;
				this.X0Y0_節40_紋柄1.Hit = value;
			}
		}

		public bool 節40_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節40_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節40_紋柄2.Dra = value;
				this.X0Y0_節40_紋柄2.Hit = value;
			}
		}

		public bool 節40_鎧_表示
		{
			get
			{
				return this.X0Y0_節40_鎧.Dra;
			}
			set
			{
				this.X0Y0_節40_鎧.Dra = value;
				this.X0Y0_節40_鎧.Hit = value;
			}
		}

		public bool 節40_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節40_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節40_吸盤1.Dra = value;
				this.X0Y0_節40_吸盤1.Hit = value;
			}
		}

		public bool 節40_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節40_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節40_吸盤2.Dra = value;
				this.X0Y0_節40_吸盤2.Hit = value;
			}
		}

		public bool 節40_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節40_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節40_吸盤3.Dra = value;
				this.X0Y0_節40_吸盤3.Hit = value;
			}
		}

		public bool 節40_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節40_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節40_吸盤4.Dra = value;
				this.X0Y0_節40_吸盤4.Hit = value;
			}
		}

		public bool 節41_節_表示
		{
			get
			{
				return this.X0Y0_節41_節.Dra;
			}
			set
			{
				this.X0Y0_節41_節.Dra = value;
				this.X0Y0_節41_節.Hit = value;
			}
		}

		public bool 節41_紋柄1_表示
		{
			get
			{
				return this.X0Y0_節41_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_節41_紋柄1.Dra = value;
				this.X0Y0_節41_紋柄1.Hit = value;
			}
		}

		public bool 節41_紋柄2_表示
		{
			get
			{
				return this.X0Y0_節41_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_節41_紋柄2.Dra = value;
				this.X0Y0_節41_紋柄2.Hit = value;
			}
		}

		public bool 節41_鎧_表示
		{
			get
			{
				return this.X0Y0_節41_鎧.Dra;
			}
			set
			{
				this.X0Y0_節41_鎧.Dra = value;
				this.X0Y0_節41_鎧.Hit = value;
			}
		}

		public bool 節41_吸盤1_表示
		{
			get
			{
				return this.X0Y0_節41_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_節41_吸盤1.Dra = value;
				this.X0Y0_節41_吸盤1.Hit = value;
			}
		}

		public bool 節41_吸盤2_表示
		{
			get
			{
				return this.X0Y0_節41_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_節41_吸盤2.Dra = value;
				this.X0Y0_節41_吸盤2.Hit = value;
			}
		}

		public bool 節41_吸盤3_表示
		{
			get
			{
				return this.X0Y0_節41_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_節41_吸盤3.Dra = value;
				this.X0Y0_節41_吸盤3.Hit = value;
			}
		}

		public bool 節41_吸盤4_表示
		{
			get
			{
				return this.X0Y0_節41_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_節41_吸盤4.Dra = value;
				this.X0Y0_節41_吸盤4.Hit = value;
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
				return this.節1_節_表示;
			}
			set
			{
				this.節1_節_表示 = value;
				this.節1_紋柄1_表示 = value;
				this.節1_紋柄2_表示 = value;
				this.節1_鎧_表示 = value;
				this.節1_吸盤1_表示 = value;
				this.節1_吸盤2_表示 = value;
				this.節1_吸盤3_表示 = value;
				this.節1_吸盤4_表示 = value;
				this.節2_節_表示 = value;
				this.節2_紋柄1_表示 = value;
				this.節2_紋柄2_表示 = value;
				this.節2_鎧_表示 = value;
				this.節2_吸盤1_表示 = value;
				this.節2_吸盤2_表示 = value;
				this.節2_吸盤3_表示 = value;
				this.節2_吸盤4_表示 = value;
				this.節3_節_表示 = value;
				this.節3_紋柄1_表示 = value;
				this.節3_紋柄2_表示 = value;
				this.節3_鎧_表示 = value;
				this.節3_吸盤1_表示 = value;
				this.節3_吸盤2_表示 = value;
				this.節3_吸盤3_表示 = value;
				this.節3_吸盤4_表示 = value;
				this.節4_節_表示 = value;
				this.節4_紋柄1_表示 = value;
				this.節4_紋柄2_表示 = value;
				this.節4_鎧_表示 = value;
				this.節4_吸盤1_表示 = value;
				this.節4_吸盤2_表示 = value;
				this.節4_吸盤3_表示 = value;
				this.節4_吸盤4_表示 = value;
				this.節5_節_表示 = value;
				this.節5_紋柄1_表示 = value;
				this.節5_紋柄2_表示 = value;
				this.節5_鎧_表示 = value;
				this.節5_吸盤1_表示 = value;
				this.節5_吸盤2_表示 = value;
				this.節5_吸盤3_表示 = value;
				this.節5_吸盤4_表示 = value;
				this.節6_節_表示 = value;
				this.節6_紋柄1_表示 = value;
				this.節6_紋柄2_表示 = value;
				this.節6_鎧_表示 = value;
				this.節6_吸盤1_表示 = value;
				this.節6_吸盤2_表示 = value;
				this.節6_吸盤3_表示 = value;
				this.節6_吸盤4_表示 = value;
				this.節7_節_表示 = value;
				this.節7_紋柄1_表示 = value;
				this.節7_紋柄2_表示 = value;
				this.節7_鎧_表示 = value;
				this.節7_吸盤1_表示 = value;
				this.節7_吸盤2_表示 = value;
				this.節7_吸盤3_表示 = value;
				this.節7_吸盤4_表示 = value;
				this.節8_節_表示 = value;
				this.節8_紋柄1_表示 = value;
				this.節8_紋柄2_表示 = value;
				this.節8_鎧_表示 = value;
				this.節8_吸盤1_表示 = value;
				this.節8_吸盤2_表示 = value;
				this.節8_吸盤3_表示 = value;
				this.節8_吸盤4_表示 = value;
				this.輪1_革_表示 = value;
				this.輪1_金具1_表示 = value;
				this.輪1_金具2_表示 = value;
				this.輪1_金具3_表示 = value;
				this.輪1_金具左_表示 = value;
				this.輪1_金具右_表示 = value;
				this.節9_節_表示 = value;
				this.節9_紋柄1_表示 = value;
				this.節9_紋柄2_表示 = value;
				this.節9_鎧_表示 = value;
				this.節9_吸盤1_表示 = value;
				this.節9_吸盤2_表示 = value;
				this.節9_吸盤3_表示 = value;
				this.節9_吸盤4_表示 = value;
				this.節10_節_表示 = value;
				this.節10_紋柄1_表示 = value;
				this.節10_紋柄2_表示 = value;
				this.節10_鎧_表示 = value;
				this.節10_吸盤1_表示 = value;
				this.節10_吸盤2_表示 = value;
				this.節10_吸盤3_表示 = value;
				this.節10_吸盤4_表示 = value;
				this.節11_節_表示 = value;
				this.節11_紋柄1_表示 = value;
				this.節11_紋柄2_表示 = value;
				this.節11_鎧_表示 = value;
				this.節11_吸盤1_表示 = value;
				this.節11_吸盤2_表示 = value;
				this.節11_吸盤3_表示 = value;
				this.節11_吸盤4_表示 = value;
				this.節12_節_表示 = value;
				this.節12_紋柄1_表示 = value;
				this.節12_紋柄2_表示 = value;
				this.節12_鎧_表示 = value;
				this.節12_吸盤1_表示 = value;
				this.節12_吸盤2_表示 = value;
				this.節12_吸盤3_表示 = value;
				this.節12_吸盤4_表示 = value;
				this.節13_節_表示 = value;
				this.節13_紋柄1_表示 = value;
				this.節13_紋柄2_表示 = value;
				this.節13_鎧_表示 = value;
				this.節13_吸盤1_表示 = value;
				this.節13_吸盤2_表示 = value;
				this.節13_吸盤3_表示 = value;
				this.節13_吸盤4_表示 = value;
				this.節14_節_表示 = value;
				this.節14_紋柄1_表示 = value;
				this.節14_紋柄2_表示 = value;
				this.節14_鎧_表示 = value;
				this.節14_吸盤1_表示 = value;
				this.節14_吸盤2_表示 = value;
				this.節14_吸盤3_表示 = value;
				this.節14_吸盤4_表示 = value;
				this.節15_節_表示 = value;
				this.節15_紋柄1_表示 = value;
				this.節15_紋柄2_表示 = value;
				this.節15_鎧_表示 = value;
				this.節15_吸盤1_表示 = value;
				this.節15_吸盤2_表示 = value;
				this.節15_吸盤3_表示 = value;
				this.節15_吸盤4_表示 = value;
				this.節16_節_表示 = value;
				this.節16_紋柄1_表示 = value;
				this.節16_紋柄2_表示 = value;
				this.節16_鎧_表示 = value;
				this.節16_吸盤1_表示 = value;
				this.節16_吸盤2_表示 = value;
				this.節16_吸盤3_表示 = value;
				this.節16_吸盤4_表示 = value;
				this.節17_節_表示 = value;
				this.節17_紋柄1_表示 = value;
				this.節17_紋柄2_表示 = value;
				this.節17_鎧_表示 = value;
				this.節17_吸盤1_表示 = value;
				this.節17_吸盤2_表示 = value;
				this.節17_吸盤3_表示 = value;
				this.節17_吸盤4_表示 = value;
				this.節18_節_表示 = value;
				this.節18_紋柄1_表示 = value;
				this.節18_紋柄2_表示 = value;
				this.節18_鎧_表示 = value;
				this.節18_吸盤1_表示 = value;
				this.節18_吸盤2_表示 = value;
				this.節18_吸盤3_表示 = value;
				this.節18_吸盤4_表示 = value;
				this.節19_節_表示 = value;
				this.節19_紋柄1_表示 = value;
				this.節19_紋柄2_表示 = value;
				this.節19_鎧_表示 = value;
				this.節19_吸盤1_表示 = value;
				this.節19_吸盤2_表示 = value;
				this.節19_吸盤3_表示 = value;
				this.節19_吸盤4_表示 = value;
				this.輪2_革_表示 = value;
				this.輪2_金具1_表示 = value;
				this.輪2_金具2_表示 = value;
				this.輪2_金具3_表示 = value;
				this.輪2_金具左_表示 = value;
				this.輪2_金具右_表示 = value;
				this.節20_節_表示 = value;
				this.節20_紋柄1_表示 = value;
				this.節20_紋柄2_表示 = value;
				this.節20_鎧_表示 = value;
				this.節20_吸盤1_表示 = value;
				this.節20_吸盤2_表示 = value;
				this.節20_吸盤3_表示 = value;
				this.節20_吸盤4_表示 = value;
				this.節21_節_表示 = value;
				this.節21_紋柄1_表示 = value;
				this.節21_紋柄2_表示 = value;
				this.節21_鎧_表示 = value;
				this.節21_吸盤1_表示 = value;
				this.節21_吸盤2_表示 = value;
				this.節21_吸盤3_表示 = value;
				this.節21_吸盤4_表示 = value;
				this.節22_節_表示 = value;
				this.節22_紋柄1_表示 = value;
				this.節22_紋柄2_表示 = value;
				this.節22_鎧_表示 = value;
				this.節22_吸盤1_表示 = value;
				this.節22_吸盤2_表示 = value;
				this.節22_吸盤3_表示 = value;
				this.節22_吸盤4_表示 = value;
				this.節23_節_表示 = value;
				this.節23_紋柄1_表示 = value;
				this.節23_紋柄2_表示 = value;
				this.節23_鎧_表示 = value;
				this.節23_吸盤1_表示 = value;
				this.節23_吸盤2_表示 = value;
				this.節23_吸盤3_表示 = value;
				this.節23_吸盤4_表示 = value;
				this.節24_節_表示 = value;
				this.節24_紋柄1_表示 = value;
				this.節24_紋柄2_表示 = value;
				this.節24_鎧_表示 = value;
				this.節24_吸盤1_表示 = value;
				this.節24_吸盤2_表示 = value;
				this.節24_吸盤3_表示 = value;
				this.節24_吸盤4_表示 = value;
				this.節25_節_表示 = value;
				this.節25_紋柄1_表示 = value;
				this.節25_紋柄2_表示 = value;
				this.節25_鎧_表示 = value;
				this.節25_吸盤1_表示 = value;
				this.節25_吸盤2_表示 = value;
				this.節25_吸盤3_表示 = value;
				this.節25_吸盤4_表示 = value;
				this.節26_節_表示 = value;
				this.節26_紋柄1_表示 = value;
				this.節26_紋柄2_表示 = value;
				this.節26_鎧_表示 = value;
				this.節26_吸盤1_表示 = value;
				this.節26_吸盤2_表示 = value;
				this.節26_吸盤3_表示 = value;
				this.節26_吸盤4_表示 = value;
				this.節27_節_表示 = value;
				this.節27_紋柄1_表示 = value;
				this.節27_紋柄2_表示 = value;
				this.節27_鎧_表示 = value;
				this.節27_吸盤1_表示 = value;
				this.節27_吸盤2_表示 = value;
				this.節27_吸盤3_表示 = value;
				this.節27_吸盤4_表示 = value;
				this.節28_節_表示 = value;
				this.節28_紋柄1_表示 = value;
				this.節28_紋柄2_表示 = value;
				this.節28_鎧_表示 = value;
				this.節28_吸盤1_表示 = value;
				this.節28_吸盤2_表示 = value;
				this.節28_吸盤3_表示 = value;
				this.節28_吸盤4_表示 = value;
				this.節29_節_表示 = value;
				this.節29_紋柄1_表示 = value;
				this.節29_紋柄2_表示 = value;
				this.節29_鎧_表示 = value;
				this.節29_吸盤1_表示 = value;
				this.節29_吸盤2_表示 = value;
				this.節29_吸盤3_表示 = value;
				this.節29_吸盤4_表示 = value;
				this.節30_節_表示 = value;
				this.節30_紋柄1_表示 = value;
				this.節30_紋柄2_表示 = value;
				this.節30_鎧_表示 = value;
				this.節30_吸盤1_表示 = value;
				this.節30_吸盤2_表示 = value;
				this.節30_吸盤3_表示 = value;
				this.節30_吸盤4_表示 = value;
				this.節31_節_表示 = value;
				this.節31_紋柄1_表示 = value;
				this.節31_紋柄2_表示 = value;
				this.節31_鎧_表示 = value;
				this.節31_吸盤1_表示 = value;
				this.節31_吸盤2_表示 = value;
				this.節31_吸盤3_表示 = value;
				this.節31_吸盤4_表示 = value;
				this.節32_節_表示 = value;
				this.節32_紋柄1_表示 = value;
				this.節32_紋柄2_表示 = value;
				this.節32_鎧_表示 = value;
				this.節32_吸盤1_表示 = value;
				this.節32_吸盤2_表示 = value;
				this.節32_吸盤3_表示 = value;
				this.節32_吸盤4_表示 = value;
				this.節33_節_表示 = value;
				this.節33_紋柄1_表示 = value;
				this.節33_紋柄2_表示 = value;
				this.節33_鎧_表示 = value;
				this.節33_吸盤1_表示 = value;
				this.節33_吸盤2_表示 = value;
				this.節33_吸盤3_表示 = value;
				this.節33_吸盤4_表示 = value;
				this.節34_節_表示 = value;
				this.節34_紋柄1_表示 = value;
				this.節34_紋柄2_表示 = value;
				this.節34_鎧_表示 = value;
				this.節34_吸盤1_表示 = value;
				this.節34_吸盤2_表示 = value;
				this.節34_吸盤3_表示 = value;
				this.節34_吸盤4_表示 = value;
				this.節35_節_表示 = value;
				this.節35_紋柄1_表示 = value;
				this.節35_紋柄2_表示 = value;
				this.節35_鎧_表示 = value;
				this.節35_吸盤1_表示 = value;
				this.節35_吸盤2_表示 = value;
				this.節35_吸盤3_表示 = value;
				this.節35_吸盤4_表示 = value;
				this.節36_節_表示 = value;
				this.節36_紋柄1_表示 = value;
				this.節36_紋柄2_表示 = value;
				this.節36_鎧_表示 = value;
				this.節36_吸盤1_表示 = value;
				this.節36_吸盤2_表示 = value;
				this.節36_吸盤3_表示 = value;
				this.節36_吸盤4_表示 = value;
				this.節37_節_表示 = value;
				this.節37_紋柄1_表示 = value;
				this.節37_紋柄2_表示 = value;
				this.節37_鎧_表示 = value;
				this.節37_吸盤1_表示 = value;
				this.節37_吸盤2_表示 = value;
				this.節37_吸盤3_表示 = value;
				this.節37_吸盤4_表示 = value;
				this.節38_節_表示 = value;
				this.節38_紋柄1_表示 = value;
				this.節38_紋柄2_表示 = value;
				this.節38_鎧_表示 = value;
				this.節38_吸盤1_表示 = value;
				this.節38_吸盤2_表示 = value;
				this.節38_吸盤3_表示 = value;
				this.節38_吸盤4_表示 = value;
				this.節39_節_表示 = value;
				this.節39_紋柄1_表示 = value;
				this.節39_紋柄2_表示 = value;
				this.節39_鎧_表示 = value;
				this.節39_吸盤1_表示 = value;
				this.節39_吸盤2_表示 = value;
				this.節39_吸盤3_表示 = value;
				this.節39_吸盤4_表示 = value;
				this.節40_節_表示 = value;
				this.節40_紋柄1_表示 = value;
				this.節40_紋柄2_表示 = value;
				this.節40_鎧_表示 = value;
				this.節40_吸盤1_表示 = value;
				this.節40_吸盤2_表示 = value;
				this.節40_吸盤3_表示 = value;
				this.節40_吸盤4_表示 = value;
				this.節41_節_表示 = value;
				this.節41_紋柄1_表示 = value;
				this.節41_紋柄2_表示 = value;
				this.節41_鎧_表示 = value;
				this.節41_吸盤1_表示 = value;
				this.節41_吸盤2_表示 = value;
				this.節41_吸盤3_表示 = value;
				this.節41_吸盤4_表示 = value;
				this.鎖1.表示 = value;
				this.鎖2.表示 = value;
				this.鎖3.表示 = value;
				this.鎖4.表示 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_節1_節);
			Are.Draw(this.X0Y0_節1_紋柄1);
			Are.Draw(this.X0Y0_節1_紋柄2);
			Are.Draw(this.X0Y0_節1_鎧);
			Are.Draw(this.X0Y0_節1_吸盤1);
			Are.Draw(this.X0Y0_節1_吸盤2);
			Are.Draw(this.X0Y0_節1_吸盤3);
			Are.Draw(this.X0Y0_節1_吸盤4);
			Are.Draw(this.X0Y0_節2_節);
			Are.Draw(this.X0Y0_節2_紋柄1);
			Are.Draw(this.X0Y0_節2_紋柄2);
			Are.Draw(this.X0Y0_節2_鎧);
			Are.Draw(this.X0Y0_節2_吸盤1);
			Are.Draw(this.X0Y0_節2_吸盤2);
			Are.Draw(this.X0Y0_節2_吸盤3);
			Are.Draw(this.X0Y0_節2_吸盤4);
			Are.Draw(this.X0Y0_節3_節);
			Are.Draw(this.X0Y0_節3_紋柄1);
			Are.Draw(this.X0Y0_節3_紋柄2);
			Are.Draw(this.X0Y0_節3_鎧);
			Are.Draw(this.X0Y0_節3_吸盤1);
			Are.Draw(this.X0Y0_節3_吸盤2);
			Are.Draw(this.X0Y0_節3_吸盤3);
			Are.Draw(this.X0Y0_節3_吸盤4);
			Are.Draw(this.X0Y0_節4_節);
			Are.Draw(this.X0Y0_節4_紋柄1);
			Are.Draw(this.X0Y0_節4_紋柄2);
			Are.Draw(this.X0Y0_節4_鎧);
			Are.Draw(this.X0Y0_節4_吸盤1);
			Are.Draw(this.X0Y0_節4_吸盤2);
			Are.Draw(this.X0Y0_節4_吸盤3);
			Are.Draw(this.X0Y0_節4_吸盤4);
			Are.Draw(this.X0Y0_節5_節);
			Are.Draw(this.X0Y0_節5_紋柄1);
			Are.Draw(this.X0Y0_節5_紋柄2);
			Are.Draw(this.X0Y0_節5_鎧);
			Are.Draw(this.X0Y0_節5_吸盤1);
			Are.Draw(this.X0Y0_節5_吸盤2);
			Are.Draw(this.X0Y0_節5_吸盤3);
			Are.Draw(this.X0Y0_節5_吸盤4);
			Are.Draw(this.X0Y0_節6_節);
			Are.Draw(this.X0Y0_節6_紋柄1);
			Are.Draw(this.X0Y0_節6_紋柄2);
			Are.Draw(this.X0Y0_節6_鎧);
			Are.Draw(this.X0Y0_節6_吸盤1);
			Are.Draw(this.X0Y0_節6_吸盤2);
			Are.Draw(this.X0Y0_節6_吸盤3);
			Are.Draw(this.X0Y0_節6_吸盤4);
			Are.Draw(this.X0Y0_節7_節);
			Are.Draw(this.X0Y0_節7_紋柄1);
			Are.Draw(this.X0Y0_節7_紋柄2);
			Are.Draw(this.X0Y0_節7_鎧);
			Are.Draw(this.X0Y0_節7_吸盤1);
			Are.Draw(this.X0Y0_節7_吸盤2);
			Are.Draw(this.X0Y0_節7_吸盤3);
			Are.Draw(this.X0Y0_節7_吸盤4);
			Are.Draw(this.X0Y0_節8_節);
			Are.Draw(this.X0Y0_節8_紋柄1);
			Are.Draw(this.X0Y0_節8_紋柄2);
			Are.Draw(this.X0Y0_節8_鎧);
			Are.Draw(this.X0Y0_節8_吸盤1);
			Are.Draw(this.X0Y0_節8_吸盤2);
			Are.Draw(this.X0Y0_節8_吸盤3);
			Are.Draw(this.X0Y0_節8_吸盤4);
			Are.Draw(this.X0Y0_輪1_革);
			Are.Draw(this.X0Y0_輪1_金具1);
			Are.Draw(this.X0Y0_輪1_金具2);
			Are.Draw(this.X0Y0_輪1_金具3);
			Are.Draw(this.X0Y0_輪1_金具左);
			Are.Draw(this.X0Y0_輪1_金具右);
			this.鎖1.描画0(Are);
			this.鎖2.描画0(Are);
			Are.Draw(this.X0Y0_節9_節);
			Are.Draw(this.X0Y0_節9_紋柄1);
			Are.Draw(this.X0Y0_節9_紋柄2);
			Are.Draw(this.X0Y0_節9_鎧);
			Are.Draw(this.X0Y0_節9_吸盤1);
			Are.Draw(this.X0Y0_節9_吸盤2);
			Are.Draw(this.X0Y0_節9_吸盤3);
			Are.Draw(this.X0Y0_節9_吸盤4);
			Are.Draw(this.X0Y0_節10_節);
			Are.Draw(this.X0Y0_節10_紋柄1);
			Are.Draw(this.X0Y0_節10_紋柄2);
			Are.Draw(this.X0Y0_節10_鎧);
			Are.Draw(this.X0Y0_節10_吸盤1);
			Are.Draw(this.X0Y0_節10_吸盤2);
			Are.Draw(this.X0Y0_節10_吸盤3);
			Are.Draw(this.X0Y0_節10_吸盤4);
			Are.Draw(this.X0Y0_節11_節);
			Are.Draw(this.X0Y0_節11_紋柄1);
			Are.Draw(this.X0Y0_節11_紋柄2);
			Are.Draw(this.X0Y0_節11_鎧);
			Are.Draw(this.X0Y0_節11_吸盤1);
			Are.Draw(this.X0Y0_節11_吸盤2);
			Are.Draw(this.X0Y0_節11_吸盤3);
			Are.Draw(this.X0Y0_節11_吸盤4);
			Are.Draw(this.X0Y0_節12_節);
			Are.Draw(this.X0Y0_節12_紋柄1);
			Are.Draw(this.X0Y0_節12_紋柄2);
			Are.Draw(this.X0Y0_節12_鎧);
			Are.Draw(this.X0Y0_節12_吸盤1);
			Are.Draw(this.X0Y0_節12_吸盤2);
			Are.Draw(this.X0Y0_節12_吸盤3);
			Are.Draw(this.X0Y0_節12_吸盤4);
			Are.Draw(this.X0Y0_節13_節);
			Are.Draw(this.X0Y0_節13_紋柄1);
			Are.Draw(this.X0Y0_節13_紋柄2);
			Are.Draw(this.X0Y0_節13_鎧);
			Are.Draw(this.X0Y0_節13_吸盤1);
			Are.Draw(this.X0Y0_節13_吸盤2);
			Are.Draw(this.X0Y0_節13_吸盤3);
			Are.Draw(this.X0Y0_節13_吸盤4);
			Are.Draw(this.X0Y0_節14_節);
			Are.Draw(this.X0Y0_節14_紋柄1);
			Are.Draw(this.X0Y0_節14_紋柄2);
			Are.Draw(this.X0Y0_節14_鎧);
			Are.Draw(this.X0Y0_節14_吸盤1);
			Are.Draw(this.X0Y0_節14_吸盤2);
			Are.Draw(this.X0Y0_節14_吸盤3);
			Are.Draw(this.X0Y0_節14_吸盤4);
			Are.Draw(this.X0Y0_節15_節);
			Are.Draw(this.X0Y0_節15_紋柄1);
			Are.Draw(this.X0Y0_節15_紋柄2);
			Are.Draw(this.X0Y0_節15_鎧);
			Are.Draw(this.X0Y0_節15_吸盤1);
			Are.Draw(this.X0Y0_節15_吸盤2);
			Are.Draw(this.X0Y0_節15_吸盤3);
			Are.Draw(this.X0Y0_節15_吸盤4);
			Are.Draw(this.X0Y0_節16_節);
			Are.Draw(this.X0Y0_節16_紋柄1);
			Are.Draw(this.X0Y0_節16_紋柄2);
			Are.Draw(this.X0Y0_節16_鎧);
			Are.Draw(this.X0Y0_節16_吸盤1);
			Are.Draw(this.X0Y0_節16_吸盤2);
			Are.Draw(this.X0Y0_節16_吸盤3);
			Are.Draw(this.X0Y0_節16_吸盤4);
			Are.Draw(this.X0Y0_節17_節);
			Are.Draw(this.X0Y0_節17_紋柄1);
			Are.Draw(this.X0Y0_節17_紋柄2);
			Are.Draw(this.X0Y0_節17_鎧);
			Are.Draw(this.X0Y0_節17_吸盤1);
			Are.Draw(this.X0Y0_節17_吸盤2);
			Are.Draw(this.X0Y0_節17_吸盤3);
			Are.Draw(this.X0Y0_節17_吸盤4);
			Are.Draw(this.X0Y0_節18_節);
			Are.Draw(this.X0Y0_節18_紋柄1);
			Are.Draw(this.X0Y0_節18_紋柄2);
			Are.Draw(this.X0Y0_節18_鎧);
			Are.Draw(this.X0Y0_節18_吸盤1);
			Are.Draw(this.X0Y0_節18_吸盤2);
			Are.Draw(this.X0Y0_節18_吸盤3);
			Are.Draw(this.X0Y0_節18_吸盤4);
			Are.Draw(this.X0Y0_節19_節);
			Are.Draw(this.X0Y0_節19_紋柄1);
			Are.Draw(this.X0Y0_節19_紋柄2);
			Are.Draw(this.X0Y0_節19_鎧);
			Are.Draw(this.X0Y0_節19_吸盤1);
			Are.Draw(this.X0Y0_節19_吸盤2);
			Are.Draw(this.X0Y0_節19_吸盤3);
			Are.Draw(this.X0Y0_節19_吸盤4);
			Are.Draw(this.X0Y0_輪2_革);
			Are.Draw(this.X0Y0_輪2_金具1);
			Are.Draw(this.X0Y0_輪2_金具2);
			Are.Draw(this.X0Y0_輪2_金具3);
			Are.Draw(this.X0Y0_輪2_金具左);
			Are.Draw(this.X0Y0_輪2_金具右);
			this.鎖3.描画0(Are);
			this.鎖4.描画0(Are);
			Are.Draw(this.X0Y0_節20_節);
			Are.Draw(this.X0Y0_節20_紋柄1);
			Are.Draw(this.X0Y0_節20_紋柄2);
			Are.Draw(this.X0Y0_節20_鎧);
			Are.Draw(this.X0Y0_節20_吸盤1);
			Are.Draw(this.X0Y0_節20_吸盤2);
			Are.Draw(this.X0Y0_節20_吸盤3);
			Are.Draw(this.X0Y0_節20_吸盤4);
			Are.Draw(this.X0Y0_節21_節);
			Are.Draw(this.X0Y0_節21_紋柄1);
			Are.Draw(this.X0Y0_節21_紋柄2);
			Are.Draw(this.X0Y0_節21_鎧);
			Are.Draw(this.X0Y0_節21_吸盤1);
			Are.Draw(this.X0Y0_節21_吸盤2);
			Are.Draw(this.X0Y0_節21_吸盤3);
			Are.Draw(this.X0Y0_節21_吸盤4);
			Are.Draw(this.X0Y0_節22_節);
			Are.Draw(this.X0Y0_節22_紋柄1);
			Are.Draw(this.X0Y0_節22_紋柄2);
			Are.Draw(this.X0Y0_節22_鎧);
			Are.Draw(this.X0Y0_節22_吸盤1);
			Are.Draw(this.X0Y0_節22_吸盤2);
			Are.Draw(this.X0Y0_節22_吸盤3);
			Are.Draw(this.X0Y0_節22_吸盤4);
			Are.Draw(this.X0Y0_節23_節);
			Are.Draw(this.X0Y0_節23_紋柄1);
			Are.Draw(this.X0Y0_節23_紋柄2);
			Are.Draw(this.X0Y0_節23_鎧);
			Are.Draw(this.X0Y0_節23_吸盤1);
			Are.Draw(this.X0Y0_節23_吸盤2);
			Are.Draw(this.X0Y0_節23_吸盤3);
			Are.Draw(this.X0Y0_節23_吸盤4);
			Are.Draw(this.X0Y0_節24_節);
			Are.Draw(this.X0Y0_節24_紋柄1);
			Are.Draw(this.X0Y0_節24_紋柄2);
			Are.Draw(this.X0Y0_節24_鎧);
			Are.Draw(this.X0Y0_節24_吸盤1);
			Are.Draw(this.X0Y0_節24_吸盤2);
			Are.Draw(this.X0Y0_節24_吸盤3);
			Are.Draw(this.X0Y0_節24_吸盤4);
			Are.Draw(this.X0Y0_節25_節);
			Are.Draw(this.X0Y0_節25_紋柄1);
			Are.Draw(this.X0Y0_節25_紋柄2);
			Are.Draw(this.X0Y0_節25_鎧);
			Are.Draw(this.X0Y0_節25_吸盤1);
			Are.Draw(this.X0Y0_節25_吸盤2);
			Are.Draw(this.X0Y0_節25_吸盤3);
			Are.Draw(this.X0Y0_節25_吸盤4);
			Are.Draw(this.X0Y0_節26_節);
			Are.Draw(this.X0Y0_節26_紋柄1);
			Are.Draw(this.X0Y0_節26_紋柄2);
			Are.Draw(this.X0Y0_節26_鎧);
			Are.Draw(this.X0Y0_節26_吸盤1);
			Are.Draw(this.X0Y0_節26_吸盤2);
			Are.Draw(this.X0Y0_節26_吸盤3);
			Are.Draw(this.X0Y0_節26_吸盤4);
			Are.Draw(this.X0Y0_節27_節);
			Are.Draw(this.X0Y0_節27_紋柄1);
			Are.Draw(this.X0Y0_節27_紋柄2);
			Are.Draw(this.X0Y0_節27_鎧);
			Are.Draw(this.X0Y0_節27_吸盤1);
			Are.Draw(this.X0Y0_節27_吸盤2);
			Are.Draw(this.X0Y0_節27_吸盤3);
			Are.Draw(this.X0Y0_節27_吸盤4);
			Are.Draw(this.X0Y0_節28_節);
			Are.Draw(this.X0Y0_節28_紋柄1);
			Are.Draw(this.X0Y0_節28_紋柄2);
			Are.Draw(this.X0Y0_節28_鎧);
			Are.Draw(this.X0Y0_節28_吸盤1);
			Are.Draw(this.X0Y0_節28_吸盤2);
			Are.Draw(this.X0Y0_節28_吸盤3);
			Are.Draw(this.X0Y0_節28_吸盤4);
			Are.Draw(this.X0Y0_節29_節);
			Are.Draw(this.X0Y0_節29_紋柄1);
			Are.Draw(this.X0Y0_節29_紋柄2);
			Are.Draw(this.X0Y0_節29_鎧);
			Are.Draw(this.X0Y0_節29_吸盤1);
			Are.Draw(this.X0Y0_節29_吸盤2);
			Are.Draw(this.X0Y0_節29_吸盤3);
			Are.Draw(this.X0Y0_節29_吸盤4);
			Are.Draw(this.X0Y0_節30_節);
			Are.Draw(this.X0Y0_節30_紋柄1);
			Are.Draw(this.X0Y0_節30_紋柄2);
			Are.Draw(this.X0Y0_節30_鎧);
			Are.Draw(this.X0Y0_節30_吸盤1);
			Are.Draw(this.X0Y0_節30_吸盤2);
			Are.Draw(this.X0Y0_節30_吸盤3);
			Are.Draw(this.X0Y0_節30_吸盤4);
			Are.Draw(this.X0Y0_節31_節);
			Are.Draw(this.X0Y0_節31_紋柄1);
			Are.Draw(this.X0Y0_節31_紋柄2);
			Are.Draw(this.X0Y0_節31_鎧);
			Are.Draw(this.X0Y0_節31_吸盤1);
			Are.Draw(this.X0Y0_節31_吸盤2);
			Are.Draw(this.X0Y0_節31_吸盤3);
			Are.Draw(this.X0Y0_節31_吸盤4);
			Are.Draw(this.X0Y0_節32_節);
			Are.Draw(this.X0Y0_節32_紋柄1);
			Are.Draw(this.X0Y0_節32_紋柄2);
			Are.Draw(this.X0Y0_節32_鎧);
			Are.Draw(this.X0Y0_節32_吸盤1);
			Are.Draw(this.X0Y0_節32_吸盤2);
			Are.Draw(this.X0Y0_節32_吸盤3);
			Are.Draw(this.X0Y0_節32_吸盤4);
			Are.Draw(this.X0Y0_節33_節);
			Are.Draw(this.X0Y0_節33_紋柄1);
			Are.Draw(this.X0Y0_節33_紋柄2);
			Are.Draw(this.X0Y0_節33_鎧);
			Are.Draw(this.X0Y0_節33_吸盤1);
			Are.Draw(this.X0Y0_節33_吸盤2);
			Are.Draw(this.X0Y0_節33_吸盤3);
			Are.Draw(this.X0Y0_節33_吸盤4);
			Are.Draw(this.X0Y0_節34_節);
			Are.Draw(this.X0Y0_節34_紋柄1);
			Are.Draw(this.X0Y0_節34_紋柄2);
			Are.Draw(this.X0Y0_節34_鎧);
			Are.Draw(this.X0Y0_節34_吸盤1);
			Are.Draw(this.X0Y0_節34_吸盤2);
			Are.Draw(this.X0Y0_節34_吸盤3);
			Are.Draw(this.X0Y0_節34_吸盤4);
			Are.Draw(this.X0Y0_節35_節);
			Are.Draw(this.X0Y0_節35_紋柄1);
			Are.Draw(this.X0Y0_節35_紋柄2);
			Are.Draw(this.X0Y0_節35_鎧);
			Are.Draw(this.X0Y0_節35_吸盤1);
			Are.Draw(this.X0Y0_節35_吸盤2);
			Are.Draw(this.X0Y0_節35_吸盤3);
			Are.Draw(this.X0Y0_節35_吸盤4);
			Are.Draw(this.X0Y0_節36_節);
			Are.Draw(this.X0Y0_節36_紋柄1);
			Are.Draw(this.X0Y0_節36_紋柄2);
			Are.Draw(this.X0Y0_節36_鎧);
			Are.Draw(this.X0Y0_節36_吸盤1);
			Are.Draw(this.X0Y0_節36_吸盤2);
			Are.Draw(this.X0Y0_節36_吸盤3);
			Are.Draw(this.X0Y0_節36_吸盤4);
			Are.Draw(this.X0Y0_節37_節);
			Are.Draw(this.X0Y0_節37_紋柄1);
			Are.Draw(this.X0Y0_節37_紋柄2);
			Are.Draw(this.X0Y0_節37_鎧);
			Are.Draw(this.X0Y0_節37_吸盤1);
			Are.Draw(this.X0Y0_節37_吸盤2);
			Are.Draw(this.X0Y0_節37_吸盤3);
			Are.Draw(this.X0Y0_節37_吸盤4);
			Are.Draw(this.X0Y0_節38_節);
			Are.Draw(this.X0Y0_節38_紋柄1);
			Are.Draw(this.X0Y0_節38_紋柄2);
			Are.Draw(this.X0Y0_節38_鎧);
			Are.Draw(this.X0Y0_節38_吸盤1);
			Are.Draw(this.X0Y0_節38_吸盤2);
			Are.Draw(this.X0Y0_節38_吸盤3);
			Are.Draw(this.X0Y0_節38_吸盤4);
			Are.Draw(this.X0Y0_節39_節);
			Are.Draw(this.X0Y0_節39_紋柄1);
			Are.Draw(this.X0Y0_節39_紋柄2);
			Are.Draw(this.X0Y0_節39_鎧);
			Are.Draw(this.X0Y0_節39_吸盤1);
			Are.Draw(this.X0Y0_節39_吸盤2);
			Are.Draw(this.X0Y0_節39_吸盤3);
			Are.Draw(this.X0Y0_節39_吸盤4);
			Are.Draw(this.X0Y0_節40_節);
			Are.Draw(this.X0Y0_節40_紋柄1);
			Are.Draw(this.X0Y0_節40_紋柄2);
			Are.Draw(this.X0Y0_節40_鎧);
			Are.Draw(this.X0Y0_節40_吸盤1);
			Are.Draw(this.X0Y0_節40_吸盤2);
			Are.Draw(this.X0Y0_節40_吸盤3);
			Are.Draw(this.X0Y0_節40_吸盤4);
			Are.Draw(this.X0Y0_節41_節);
			Are.Draw(this.X0Y0_節41_紋柄1);
			Are.Draw(this.X0Y0_節41_紋柄2);
			Are.Draw(this.X0Y0_節41_鎧);
			Are.Draw(this.X0Y0_節41_吸盤1);
			Are.Draw(this.X0Y0_節41_吸盤2);
			Are.Draw(this.X0Y0_節41_吸盤3);
			Are.Draw(this.X0Y0_節41_吸盤4);
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
				return this.節1_節CD.不透明度;
			}
			set
			{
				this.節1_節CD.不透明度 = value;
				this.節1_紋柄1CD.不透明度 = value;
				this.節1_紋柄2CD.不透明度 = value;
				this.節1_鎧CD.不透明度 = value;
				this.節1_吸盤1CD.不透明度 = value;
				this.節1_吸盤2CD.不透明度 = value;
				this.節1_吸盤3CD.不透明度 = value;
				this.節1_吸盤4CD.不透明度 = value;
				this.節2_節CD.不透明度 = value;
				this.節2_紋柄1CD.不透明度 = value;
				this.節2_紋柄2CD.不透明度 = value;
				this.節2_鎧CD.不透明度 = value;
				this.節2_吸盤1CD.不透明度 = value;
				this.節2_吸盤2CD.不透明度 = value;
				this.節2_吸盤3CD.不透明度 = value;
				this.節2_吸盤4CD.不透明度 = value;
				this.節3_節CD.不透明度 = value;
				this.節3_紋柄1CD.不透明度 = value;
				this.節3_紋柄2CD.不透明度 = value;
				this.節3_鎧CD.不透明度 = value;
				this.節3_吸盤1CD.不透明度 = value;
				this.節3_吸盤2CD.不透明度 = value;
				this.節3_吸盤3CD.不透明度 = value;
				this.節3_吸盤4CD.不透明度 = value;
				this.節4_節CD.不透明度 = value;
				this.節4_紋柄1CD.不透明度 = value;
				this.節4_紋柄2CD.不透明度 = value;
				this.節4_鎧CD.不透明度 = value;
				this.節4_吸盤1CD.不透明度 = value;
				this.節4_吸盤2CD.不透明度 = value;
				this.節4_吸盤3CD.不透明度 = value;
				this.節4_吸盤4CD.不透明度 = value;
				this.節5_節CD.不透明度 = value;
				this.節5_紋柄1CD.不透明度 = value;
				this.節5_紋柄2CD.不透明度 = value;
				this.節5_鎧CD.不透明度 = value;
				this.節5_吸盤1CD.不透明度 = value;
				this.節5_吸盤2CD.不透明度 = value;
				this.節5_吸盤3CD.不透明度 = value;
				this.節5_吸盤4CD.不透明度 = value;
				this.節6_節CD.不透明度 = value;
				this.節6_紋柄1CD.不透明度 = value;
				this.節6_紋柄2CD.不透明度 = value;
				this.節6_鎧CD.不透明度 = value;
				this.節6_吸盤1CD.不透明度 = value;
				this.節6_吸盤2CD.不透明度 = value;
				this.節6_吸盤3CD.不透明度 = value;
				this.節6_吸盤4CD.不透明度 = value;
				this.節7_節CD.不透明度 = value;
				this.節7_紋柄1CD.不透明度 = value;
				this.節7_紋柄2CD.不透明度 = value;
				this.節7_鎧CD.不透明度 = value;
				this.節7_吸盤1CD.不透明度 = value;
				this.節7_吸盤2CD.不透明度 = value;
				this.節7_吸盤3CD.不透明度 = value;
				this.節7_吸盤4CD.不透明度 = value;
				this.節8_節CD.不透明度 = value;
				this.節8_紋柄1CD.不透明度 = value;
				this.節8_紋柄2CD.不透明度 = value;
				this.節8_鎧CD.不透明度 = value;
				this.節8_吸盤1CD.不透明度 = value;
				this.節8_吸盤2CD.不透明度 = value;
				this.節8_吸盤3CD.不透明度 = value;
				this.節8_吸盤4CD.不透明度 = value;
				this.節9_節CD.不透明度 = value;
				this.節9_紋柄1CD.不透明度 = value;
				this.節9_紋柄2CD.不透明度 = value;
				this.節9_鎧CD.不透明度 = value;
				this.節9_吸盤1CD.不透明度 = value;
				this.節9_吸盤2CD.不透明度 = value;
				this.節9_吸盤3CD.不透明度 = value;
				this.節9_吸盤4CD.不透明度 = value;
				this.節10_節CD.不透明度 = value;
				this.節10_紋柄1CD.不透明度 = value;
				this.節10_紋柄2CD.不透明度 = value;
				this.節10_鎧CD.不透明度 = value;
				this.節10_吸盤1CD.不透明度 = value;
				this.節10_吸盤2CD.不透明度 = value;
				this.節10_吸盤3CD.不透明度 = value;
				this.節10_吸盤4CD.不透明度 = value;
				this.節11_節CD.不透明度 = value;
				this.節11_紋柄1CD.不透明度 = value;
				this.節11_紋柄2CD.不透明度 = value;
				this.節11_鎧CD.不透明度 = value;
				this.節11_吸盤1CD.不透明度 = value;
				this.節11_吸盤2CD.不透明度 = value;
				this.節11_吸盤3CD.不透明度 = value;
				this.節11_吸盤4CD.不透明度 = value;
				this.節12_節CD.不透明度 = value;
				this.節12_紋柄1CD.不透明度 = value;
				this.節12_紋柄2CD.不透明度 = value;
				this.節12_鎧CD.不透明度 = value;
				this.節12_吸盤1CD.不透明度 = value;
				this.節12_吸盤2CD.不透明度 = value;
				this.節12_吸盤3CD.不透明度 = value;
				this.節12_吸盤4CD.不透明度 = value;
				this.節13_節CD.不透明度 = value;
				this.節13_紋柄1CD.不透明度 = value;
				this.節13_紋柄2CD.不透明度 = value;
				this.節13_鎧CD.不透明度 = value;
				this.節13_吸盤1CD.不透明度 = value;
				this.節13_吸盤2CD.不透明度 = value;
				this.節13_吸盤3CD.不透明度 = value;
				this.節13_吸盤4CD.不透明度 = value;
				this.節14_節CD.不透明度 = value;
				this.節14_紋柄1CD.不透明度 = value;
				this.節14_紋柄2CD.不透明度 = value;
				this.節14_鎧CD.不透明度 = value;
				this.節14_吸盤1CD.不透明度 = value;
				this.節14_吸盤2CD.不透明度 = value;
				this.節14_吸盤3CD.不透明度 = value;
				this.節14_吸盤4CD.不透明度 = value;
				this.節15_節CD.不透明度 = value;
				this.節15_紋柄1CD.不透明度 = value;
				this.節15_紋柄2CD.不透明度 = value;
				this.節15_鎧CD.不透明度 = value;
				this.節15_吸盤1CD.不透明度 = value;
				this.節15_吸盤2CD.不透明度 = value;
				this.節15_吸盤3CD.不透明度 = value;
				this.節15_吸盤4CD.不透明度 = value;
				this.節16_節CD.不透明度 = value;
				this.節16_紋柄1CD.不透明度 = value;
				this.節16_紋柄2CD.不透明度 = value;
				this.節16_鎧CD.不透明度 = value;
				this.節16_吸盤1CD.不透明度 = value;
				this.節16_吸盤2CD.不透明度 = value;
				this.節16_吸盤3CD.不透明度 = value;
				this.節16_吸盤4CD.不透明度 = value;
				this.節17_節CD.不透明度 = value;
				this.節17_紋柄1CD.不透明度 = value;
				this.節17_紋柄2CD.不透明度 = value;
				this.節17_鎧CD.不透明度 = value;
				this.節17_吸盤1CD.不透明度 = value;
				this.節17_吸盤2CD.不透明度 = value;
				this.節17_吸盤3CD.不透明度 = value;
				this.節17_吸盤4CD.不透明度 = value;
				this.節18_節CD.不透明度 = value;
				this.節18_紋柄1CD.不透明度 = value;
				this.節18_紋柄2CD.不透明度 = value;
				this.節18_鎧CD.不透明度 = value;
				this.節18_吸盤1CD.不透明度 = value;
				this.節18_吸盤2CD.不透明度 = value;
				this.節18_吸盤3CD.不透明度 = value;
				this.節18_吸盤4CD.不透明度 = value;
				this.節19_節CD.不透明度 = value;
				this.節19_紋柄1CD.不透明度 = value;
				this.節19_紋柄2CD.不透明度 = value;
				this.節19_鎧CD.不透明度 = value;
				this.節19_吸盤1CD.不透明度 = value;
				this.節19_吸盤2CD.不透明度 = value;
				this.節19_吸盤3CD.不透明度 = value;
				this.節19_吸盤4CD.不透明度 = value;
				this.節20_節CD.不透明度 = value;
				this.節20_紋柄1CD.不透明度 = value;
				this.節20_紋柄2CD.不透明度 = value;
				this.節20_鎧CD.不透明度 = value;
				this.節20_吸盤1CD.不透明度 = value;
				this.節20_吸盤2CD.不透明度 = value;
				this.節20_吸盤3CD.不透明度 = value;
				this.節20_吸盤4CD.不透明度 = value;
				this.節21_節CD.不透明度 = value;
				this.節21_紋柄1CD.不透明度 = value;
				this.節21_紋柄2CD.不透明度 = value;
				this.節21_鎧CD.不透明度 = value;
				this.節21_吸盤1CD.不透明度 = value;
				this.節21_吸盤2CD.不透明度 = value;
				this.節21_吸盤3CD.不透明度 = value;
				this.節21_吸盤4CD.不透明度 = value;
				this.節22_節CD.不透明度 = value;
				this.節22_紋柄1CD.不透明度 = value;
				this.節22_紋柄2CD.不透明度 = value;
				this.節22_鎧CD.不透明度 = value;
				this.節22_吸盤1CD.不透明度 = value;
				this.節22_吸盤2CD.不透明度 = value;
				this.節22_吸盤3CD.不透明度 = value;
				this.節22_吸盤4CD.不透明度 = value;
				this.節23_節CD.不透明度 = value;
				this.節23_紋柄1CD.不透明度 = value;
				this.節23_紋柄2CD.不透明度 = value;
				this.節23_鎧CD.不透明度 = value;
				this.節23_吸盤1CD.不透明度 = value;
				this.節23_吸盤2CD.不透明度 = value;
				this.節23_吸盤3CD.不透明度 = value;
				this.節23_吸盤4CD.不透明度 = value;
				this.節24_節CD.不透明度 = value;
				this.節24_紋柄1CD.不透明度 = value;
				this.節24_紋柄2CD.不透明度 = value;
				this.節24_鎧CD.不透明度 = value;
				this.節24_吸盤1CD.不透明度 = value;
				this.節24_吸盤2CD.不透明度 = value;
				this.節24_吸盤3CD.不透明度 = value;
				this.節24_吸盤4CD.不透明度 = value;
				this.節25_節CD.不透明度 = value;
				this.節25_紋柄1CD.不透明度 = value;
				this.節25_紋柄2CD.不透明度 = value;
				this.節25_鎧CD.不透明度 = value;
				this.節25_吸盤1CD.不透明度 = value;
				this.節25_吸盤2CD.不透明度 = value;
				this.節25_吸盤3CD.不透明度 = value;
				this.節25_吸盤4CD.不透明度 = value;
				this.節26_節CD.不透明度 = value;
				this.節26_紋柄1CD.不透明度 = value;
				this.節26_紋柄2CD.不透明度 = value;
				this.節26_鎧CD.不透明度 = value;
				this.節26_吸盤1CD.不透明度 = value;
				this.節26_吸盤2CD.不透明度 = value;
				this.節26_吸盤3CD.不透明度 = value;
				this.節26_吸盤4CD.不透明度 = value;
				this.節27_節CD.不透明度 = value;
				this.節27_紋柄1CD.不透明度 = value;
				this.節27_紋柄2CD.不透明度 = value;
				this.節27_鎧CD.不透明度 = value;
				this.節27_吸盤1CD.不透明度 = value;
				this.節27_吸盤2CD.不透明度 = value;
				this.節27_吸盤3CD.不透明度 = value;
				this.節27_吸盤4CD.不透明度 = value;
				this.節28_節CD.不透明度 = value;
				this.節28_紋柄1CD.不透明度 = value;
				this.節28_紋柄2CD.不透明度 = value;
				this.節28_鎧CD.不透明度 = value;
				this.節28_吸盤1CD.不透明度 = value;
				this.節28_吸盤2CD.不透明度 = value;
				this.節28_吸盤3CD.不透明度 = value;
				this.節28_吸盤4CD.不透明度 = value;
				this.節29_節CD.不透明度 = value;
				this.節29_紋柄1CD.不透明度 = value;
				this.節29_紋柄2CD.不透明度 = value;
				this.節29_鎧CD.不透明度 = value;
				this.節29_吸盤1CD.不透明度 = value;
				this.節29_吸盤2CD.不透明度 = value;
				this.節29_吸盤3CD.不透明度 = value;
				this.節29_吸盤4CD.不透明度 = value;
				this.節30_節CD.不透明度 = value;
				this.節30_紋柄1CD.不透明度 = value;
				this.節30_紋柄2CD.不透明度 = value;
				this.節30_鎧CD.不透明度 = value;
				this.節30_吸盤1CD.不透明度 = value;
				this.節30_吸盤2CD.不透明度 = value;
				this.節30_吸盤3CD.不透明度 = value;
				this.節30_吸盤4CD.不透明度 = value;
				this.節31_節CD.不透明度 = value;
				this.節31_紋柄1CD.不透明度 = value;
				this.節31_紋柄2CD.不透明度 = value;
				this.節31_鎧CD.不透明度 = value;
				this.節31_吸盤1CD.不透明度 = value;
				this.節31_吸盤2CD.不透明度 = value;
				this.節31_吸盤3CD.不透明度 = value;
				this.節31_吸盤4CD.不透明度 = value;
				this.節32_節CD.不透明度 = value;
				this.節32_紋柄1CD.不透明度 = value;
				this.節32_紋柄2CD.不透明度 = value;
				this.節32_鎧CD.不透明度 = value;
				this.節32_吸盤1CD.不透明度 = value;
				this.節32_吸盤2CD.不透明度 = value;
				this.節32_吸盤3CD.不透明度 = value;
				this.節32_吸盤4CD.不透明度 = value;
				this.節33_節CD.不透明度 = value;
				this.節33_紋柄1CD.不透明度 = value;
				this.節33_紋柄2CD.不透明度 = value;
				this.節33_鎧CD.不透明度 = value;
				this.節33_吸盤1CD.不透明度 = value;
				this.節33_吸盤2CD.不透明度 = value;
				this.節33_吸盤3CD.不透明度 = value;
				this.節33_吸盤4CD.不透明度 = value;
				this.節34_節CD.不透明度 = value;
				this.節34_紋柄1CD.不透明度 = value;
				this.節34_紋柄2CD.不透明度 = value;
				this.節34_鎧CD.不透明度 = value;
				this.節34_吸盤1CD.不透明度 = value;
				this.節34_吸盤2CD.不透明度 = value;
				this.節34_吸盤3CD.不透明度 = value;
				this.節34_吸盤4CD.不透明度 = value;
				this.節35_節CD.不透明度 = value;
				this.節35_紋柄1CD.不透明度 = value;
				this.節35_紋柄2CD.不透明度 = value;
				this.節35_鎧CD.不透明度 = value;
				this.節35_吸盤1CD.不透明度 = value;
				this.節35_吸盤2CD.不透明度 = value;
				this.節35_吸盤3CD.不透明度 = value;
				this.節35_吸盤4CD.不透明度 = value;
				this.節36_節CD.不透明度 = value;
				this.節36_紋柄1CD.不透明度 = value;
				this.節36_紋柄2CD.不透明度 = value;
				this.節36_鎧CD.不透明度 = value;
				this.節36_吸盤1CD.不透明度 = value;
				this.節36_吸盤2CD.不透明度 = value;
				this.節36_吸盤3CD.不透明度 = value;
				this.節36_吸盤4CD.不透明度 = value;
				this.節37_節CD.不透明度 = value;
				this.節37_紋柄1CD.不透明度 = value;
				this.節37_紋柄2CD.不透明度 = value;
				this.節37_鎧CD.不透明度 = value;
				this.節37_吸盤1CD.不透明度 = value;
				this.節37_吸盤2CD.不透明度 = value;
				this.節37_吸盤3CD.不透明度 = value;
				this.節37_吸盤4CD.不透明度 = value;
				this.節38_節CD.不透明度 = value;
				this.節38_紋柄1CD.不透明度 = value;
				this.節38_紋柄2CD.不透明度 = value;
				this.節38_鎧CD.不透明度 = value;
				this.節38_吸盤1CD.不透明度 = value;
				this.節38_吸盤2CD.不透明度 = value;
				this.節38_吸盤3CD.不透明度 = value;
				this.節38_吸盤4CD.不透明度 = value;
				this.節39_節CD.不透明度 = value;
				this.節39_紋柄1CD.不透明度 = value;
				this.節39_紋柄2CD.不透明度 = value;
				this.節39_鎧CD.不透明度 = value;
				this.節39_吸盤1CD.不透明度 = value;
				this.節39_吸盤2CD.不透明度 = value;
				this.節39_吸盤3CD.不透明度 = value;
				this.節39_吸盤4CD.不透明度 = value;
				this.節40_節CD.不透明度 = value;
				this.節40_紋柄1CD.不透明度 = value;
				this.節40_紋柄2CD.不透明度 = value;
				this.節40_鎧CD.不透明度 = value;
				this.節40_吸盤1CD.不透明度 = value;
				this.節40_吸盤2CD.不透明度 = value;
				this.節40_吸盤3CD.不透明度 = value;
				this.節40_吸盤4CD.不透明度 = value;
				this.節41_節CD.不透明度 = value;
				this.節41_紋柄1CD.不透明度 = value;
				this.節41_紋柄2CD.不透明度 = value;
				this.節41_鎧CD.不透明度 = value;
				this.節41_吸盤1CD.不透明度 = value;
				this.節41_吸盤2CD.不透明度 = value;
				this.節41_吸盤3CD.不透明度 = value;
				this.節41_吸盤4CD.不透明度 = value;
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
			double maxAngle = 25.0;
			this.X0Y0_節1_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節2_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節3_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節4_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節5_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節6_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節7_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節8_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節9_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節10_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節11_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節12_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節13_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節14_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節15_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節16_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節17_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節18_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節19_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節20_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節21_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節22_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節23_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節24_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節25_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節26_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節27_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節28_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節29_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節30_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節31_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節32_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節33_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節34_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節35_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節36_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節37_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節38_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節39_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節40_節.AngleBase = maxAngle.GetRanAngle();
			this.X0Y0_節41_節.AngleBase = maxAngle.GetRanAngle();
			this.本体.JoinPAall();
		}

		public void Set角度(触手_軟 軟)
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_節1_節.AngleBase = num * 軟.X0Y0_節1_節.AngleBase;
			this.X0Y0_節2_節.AngleBase = num * 軟.X0Y0_節2_節.AngleBase;
			this.X0Y0_節3_節.AngleBase = num * 軟.X0Y0_節3_節.AngleBase;
			this.X0Y0_節4_節.AngleBase = num * 軟.X0Y0_節4_節.AngleBase;
			this.X0Y0_節5_節.AngleBase = num * 軟.X0Y0_節5_節.AngleBase;
			this.X0Y0_節6_節.AngleBase = num * 軟.X0Y0_節6_節.AngleBase;
			this.X0Y0_節7_節.AngleBase = num * 軟.X0Y0_節7_節.AngleBase;
			this.X0Y0_節8_節.AngleBase = num * 軟.X0Y0_節8_節.AngleBase;
			this.X0Y0_節9_節.AngleBase = num * 軟.X0Y0_節9_節.AngleBase;
			this.X0Y0_節10_節.AngleBase = num * 軟.X0Y0_節10_節.AngleBase;
			this.X0Y0_節11_節.AngleBase = num * 軟.X0Y0_節11_節.AngleBase;
			this.X0Y0_節12_節.AngleBase = num * 軟.X0Y0_節12_節.AngleBase;
			this.X0Y0_節13_節.AngleBase = num * 軟.X0Y0_節13_節.AngleBase;
			this.X0Y0_節14_節.AngleBase = num * 軟.X0Y0_節14_節.AngleBase;
			this.X0Y0_節15_節.AngleBase = num * 軟.X0Y0_節15_節.AngleBase;
			this.X0Y0_節16_節.AngleBase = num * 軟.X0Y0_節16_節.AngleBase;
			this.X0Y0_節17_節.AngleBase = num * 軟.X0Y0_節17_節.AngleBase;
			this.X0Y0_節18_節.AngleBase = num * 軟.X0Y0_節18_節.AngleBase;
			this.X0Y0_節19_節.AngleBase = num * 軟.X0Y0_節19_節.AngleBase;
			this.X0Y0_節20_節.AngleBase = num * 軟.X0Y0_節20_節.AngleBase;
			this.X0Y0_節21_節.AngleBase = num * 軟.X0Y0_節21_節.AngleBase;
			this.X0Y0_節22_節.AngleBase = num * 軟.X0Y0_節22_節.AngleBase;
			this.X0Y0_節23_節.AngleBase = num * 軟.X0Y0_節23_節.AngleBase;
			this.X0Y0_節24_節.AngleBase = num * 軟.X0Y0_節24_節.AngleBase;
			this.X0Y0_節25_節.AngleBase = num * 軟.X0Y0_節25_節.AngleBase;
			this.X0Y0_節26_節.AngleBase = num * 軟.X0Y0_節26_節.AngleBase;
			this.X0Y0_節27_節.AngleBase = num * 軟.X0Y0_節27_節.AngleBase;
			this.X0Y0_節28_節.AngleBase = num * 軟.X0Y0_節28_節.AngleBase;
			this.X0Y0_節29_節.AngleBase = num * 軟.X0Y0_節29_節.AngleBase;
			this.X0Y0_節30_節.AngleBase = num * 軟.X0Y0_節30_節.AngleBase;
			this.X0Y0_節31_節.AngleBase = num * 軟.X0Y0_節31_節.AngleBase;
			this.X0Y0_節32_節.AngleBase = num * 軟.X0Y0_節32_節.AngleBase;
			this.X0Y0_節33_節.AngleBase = num * 軟.X0Y0_節33_節.AngleBase;
			this.X0Y0_節34_節.AngleBase = num * 軟.X0Y0_節34_節.AngleBase;
			this.X0Y0_節35_節.AngleBase = num * 軟.X0Y0_節35_節.AngleBase;
			this.X0Y0_節36_節.AngleBase = num * 軟.X0Y0_節36_節.AngleBase;
			this.X0Y0_節37_節.AngleBase = num * 軟.X0Y0_節37_節.AngleBase;
			this.X0Y0_節38_節.AngleBase = num * 軟.X0Y0_節38_節.AngleBase;
			this.X0Y0_節39_節.AngleBase = num * 軟.X0Y0_節39_節.AngleBase;
			this.X0Y0_節40_節.AngleBase = num * 軟.X0Y0_節40_節.AngleBase;
			this.X0Y0_節41_節.AngleBase = num * 軟.X0Y0_節41_節.AngleBase;
			this.本体.JoinPAall();
		}

		public void Set前足()
		{
			this.X0Y0_節1_吸盤1.Dra = false;
			this.X0Y0_節1_吸盤3.Dra = false;
			this.X0Y0_節2_吸盤1.Dra = false;
			this.X0Y0_節2_吸盤3.Dra = false;
			this.X0Y0_節3_吸盤1.Dra = false;
			this.X0Y0_節3_吸盤3.Dra = false;
			this.X0Y0_節4_吸盤1.Dra = false;
			this.X0Y0_節4_吸盤3.Dra = false;
			this.X0Y0_節5_吸盤1.Dra = false;
			this.X0Y0_節5_吸盤3.Dra = false;
			this.X0Y0_節6_吸盤1.Dra = false;
			this.X0Y0_節6_吸盤3.Dra = false;
			this.X0Y0_節7_吸盤1.Dra = false;
			this.X0Y0_節7_吸盤3.Dra = false;
			this.X0Y0_節8_吸盤1.Dra = false;
			this.X0Y0_節8_吸盤3.Dra = false;
			this.X0Y0_節9_吸盤1.Dra = false;
			this.X0Y0_節9_吸盤3.Dra = false;
			this.X0Y0_節10_吸盤1.Dra = false;
			this.X0Y0_節10_吸盤3.Dra = false;
			this.X0Y0_節11_吸盤1.Dra = false;
			this.X0Y0_節11_吸盤3.Dra = false;
			this.X0Y0_節12_吸盤1.Dra = false;
			this.X0Y0_節12_吸盤3.Dra = false;
			this.X0Y0_節13_吸盤1.Dra = false;
			this.X0Y0_節13_吸盤3.Dra = false;
			this.X0Y0_節14_吸盤1.Dra = false;
			this.X0Y0_節14_吸盤3.Dra = false;
			this.X0Y0_節15_吸盤1.Dra = false;
			this.X0Y0_節15_吸盤3.Dra = false;
			this.X0Y0_節16_吸盤1.Dra = false;
			this.X0Y0_節16_吸盤3.Dra = false;
			this.X0Y0_節17_吸盤1.Dra = false;
			this.X0Y0_節17_吸盤3.Dra = false;
			this.X0Y0_節18_吸盤1.Dra = false;
			this.X0Y0_節18_吸盤3.Dra = false;
			this.X0Y0_節19_吸盤1.Dra = false;
			this.X0Y0_節19_吸盤3.Dra = false;
			this.X0Y0_節20_吸盤1.Dra = false;
			this.X0Y0_節20_吸盤3.Dra = false;
			this.X0Y0_節21_吸盤1.Dra = false;
			this.X0Y0_節21_吸盤3.Dra = false;
			this.X0Y0_節22_吸盤1.Dra = false;
			this.X0Y0_節22_吸盤3.Dra = false;
			this.X0Y0_節23_吸盤1.Dra = false;
			this.X0Y0_節23_吸盤3.Dra = false;
			this.X0Y0_節24_吸盤1.Dra = false;
			this.X0Y0_節24_吸盤3.Dra = false;
			this.X0Y0_節25_吸盤1.Dra = false;
			this.X0Y0_節25_吸盤3.Dra = false;
			this.X0Y0_節26_吸盤1.Dra = false;
			this.X0Y0_節26_吸盤3.Dra = false;
			this.X0Y0_節27_吸盤1.Dra = false;
			this.X0Y0_節27_吸盤3.Dra = false;
			this.X0Y0_節28_吸盤1.Dra = false;
			this.X0Y0_節28_吸盤3.Dra = false;
			this.X0Y0_節29_吸盤1.Dra = false;
			this.X0Y0_節29_吸盤3.Dra = false;
			this.X0Y0_節30_吸盤1.Dra = false;
			this.X0Y0_節30_吸盤3.Dra = false;
			this.X0Y0_節31_吸盤1.Dra = false;
			this.X0Y0_節31_吸盤3.Dra = false;
			this.X0Y0_節32_吸盤1.Dra = false;
			this.X0Y0_節32_吸盤3.Dra = false;
			this.X0Y0_節33_吸盤1.Dra = false;
			this.X0Y0_節33_吸盤3.Dra = false;
			this.X0Y0_節34_吸盤1.Dra = false;
			this.X0Y0_節34_吸盤3.Dra = false;
			this.X0Y0_節35_吸盤1.Dra = false;
			this.X0Y0_節35_吸盤3.Dra = false;
			this.X0Y0_節36_吸盤1.Dra = false;
			this.X0Y0_節36_吸盤3.Dra = false;
			this.X0Y0_節37_吸盤1.Dra = false;
			this.X0Y0_節37_吸盤3.Dra = false;
			this.X0Y0_節38_吸盤1.Dra = false;
			this.X0Y0_節38_吸盤3.Dra = false;
			this.X0Y0_節39_吸盤1.Dra = false;
			this.X0Y0_節39_吸盤3.Dra = false;
			this.X0Y0_節40_吸盤1.Dra = false;
			this.X0Y0_節40_吸盤3.Dra = false;
			this.X0Y0_節41_吸盤1.Dra = false;
			this.X0Y0_節41_吸盤3.Dra = false;
			this.X0Y0_節1_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節1_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節2_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節2_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節3_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節3_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節4_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節4_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節5_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節5_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節6_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節6_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節7_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節7_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節8_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節8_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節9_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節9_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節10_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節10_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節11_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節11_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節12_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節12_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節13_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節13_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節14_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節14_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節15_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節15_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節16_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節16_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節17_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節17_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節18_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節18_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節19_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節19_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節20_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節20_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節21_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節21_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節22_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節22_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節23_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節23_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節24_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節24_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節25_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節25_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節26_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節26_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節27_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節27_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節28_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節28_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節29_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節29_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節30_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節30_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節31_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節31_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節32_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節32_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節33_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節33_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節34_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節34_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節35_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節35_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節36_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節36_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節37_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節37_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節38_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節38_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節39_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節39_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節40_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節40_吸盤4.SizeXBase *= 0.7;
			this.X0Y0_節41_吸盤2.SizeXBase *= 0.7;
			this.X0Y0_節41_吸盤4.SizeXBase *= 0.7;
			this.節1_吸盤2_表示 = false;
			this.節1_吸盤4_表示 = false;
		}

		public void Set後足()
		{
			this.X0Y0_節1_吸盤2.Dra = false;
			this.X0Y0_節1_吸盤4.Dra = false;
			this.節1_吸盤2_表示 = false;
			this.節1_吸盤4_表示 = false;
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_輪1_革 || p == this.X0Y0_輪1_金具1 || p == this.X0Y0_輪1_金具2 || p == this.X0Y0_輪1_金具3 || p == this.X0Y0_輪1_金具左 || p == this.X0Y0_輪1_金具右 || p == this.X0Y0_輪2_革 || p == this.X0Y0_輪2_金具1 || p == this.X0Y0_輪2_金具2 || p == this.X0Y0_輪2_金具3 || p == this.X0Y0_輪2_金具左 || p == this.X0Y0_輪2_金具右;
		}

		public override IEnumerable<Par> Enum軸()
		{
			yield return this.X0Y0_節1_節;
			yield return this.X0Y0_節2_節;
			yield return this.X0Y0_節3_節;
			yield return this.X0Y0_節4_節;
			yield return this.X0Y0_節5_節;
			yield return this.X0Y0_節6_節;
			yield return this.X0Y0_節7_節;
			yield return this.X0Y0_節8_節;
			yield return this.X0Y0_節9_節;
			yield return this.X0Y0_節10_節;
			yield return this.X0Y0_節11_節;
			yield return this.X0Y0_節12_節;
			yield return this.X0Y0_節13_節;
			yield return this.X0Y0_節14_節;
			yield return this.X0Y0_節15_節;
			yield return this.X0Y0_節16_節;
			yield return this.X0Y0_節17_節;
			yield return this.X0Y0_節18_節;
			yield return this.X0Y0_節19_節;
			yield return this.X0Y0_節20_節;
			yield return this.X0Y0_節21_節;
			yield return this.X0Y0_節22_節;
			yield return this.X0Y0_節23_節;
			yield return this.X0Y0_節24_節;
			yield return this.X0Y0_節25_節;
			yield return this.X0Y0_節26_節;
			yield return this.X0Y0_節27_節;
			yield return this.X0Y0_節28_節;
			yield return this.X0Y0_節29_節;
			yield return this.X0Y0_節30_節;
			yield return this.X0Y0_節31_節;
			yield return this.X0Y0_節32_節;
			yield return this.X0Y0_節33_節;
			yield return this.X0Y0_節34_節;
			yield return this.X0Y0_節35_節;
			yield return this.X0Y0_節36_節;
			yield return this.X0Y0_節37_節;
			yield return this.X0Y0_節38_節;
			yield return this.X0Y0_節39_節;
			yield return this.X0Y0_節40_節;
			yield return this.X0Y0_節41_節;
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
			this.Pars.GetMiY_MaY(out this.mm);
			this.X0Y0_節1_節CP.Update(this.mm);
			this.X0Y0_節1_紋柄1CP.Update();
			this.X0Y0_節1_紋柄2CP.Update();
			this.X0Y0_節1_鎧CP.Update();
			this.X0Y0_節1_吸盤1CP.Update();
			this.X0Y0_節1_吸盤2CP.Update();
			this.X0Y0_節1_吸盤3CP.Update();
			this.X0Y0_節1_吸盤4CP.Update();
			this.X0Y0_節2_節CP.Update(this.mm);
			this.X0Y0_節2_紋柄1CP.Update();
			this.X0Y0_節2_紋柄2CP.Update();
			this.X0Y0_節2_鎧CP.Update();
			this.X0Y0_節2_吸盤1CP.Update();
			this.X0Y0_節2_吸盤2CP.Update();
			this.X0Y0_節2_吸盤3CP.Update();
			this.X0Y0_節2_吸盤4CP.Update();
			this.X0Y0_節3_節CP.Update(this.mm);
			this.X0Y0_節3_紋柄1CP.Update();
			this.X0Y0_節3_紋柄2CP.Update();
			this.X0Y0_節3_鎧CP.Update();
			this.X0Y0_節3_吸盤1CP.Update();
			this.X0Y0_節3_吸盤2CP.Update();
			this.X0Y0_節3_吸盤3CP.Update();
			this.X0Y0_節3_吸盤4CP.Update();
			this.X0Y0_節4_節CP.Update(this.mm);
			this.X0Y0_節4_紋柄1CP.Update();
			this.X0Y0_節4_紋柄2CP.Update();
			this.X0Y0_節4_鎧CP.Update();
			this.X0Y0_節4_吸盤1CP.Update();
			this.X0Y0_節4_吸盤2CP.Update();
			this.X0Y0_節4_吸盤3CP.Update();
			this.X0Y0_節4_吸盤4CP.Update();
			this.X0Y0_節5_節CP.Update(this.mm);
			this.X0Y0_節5_紋柄1CP.Update();
			this.X0Y0_節5_紋柄2CP.Update();
			this.X0Y0_節5_鎧CP.Update();
			this.X0Y0_節5_吸盤1CP.Update();
			this.X0Y0_節5_吸盤2CP.Update();
			this.X0Y0_節5_吸盤3CP.Update();
			this.X0Y0_節5_吸盤4CP.Update();
			this.X0Y0_節6_節CP.Update(this.mm);
			this.X0Y0_節6_紋柄1CP.Update();
			this.X0Y0_節6_紋柄2CP.Update();
			this.X0Y0_節6_鎧CP.Update();
			this.X0Y0_節6_吸盤1CP.Update();
			this.X0Y0_節6_吸盤2CP.Update();
			this.X0Y0_節6_吸盤3CP.Update();
			this.X0Y0_節6_吸盤4CP.Update();
			this.X0Y0_節7_節CP.Update(this.mm);
			this.X0Y0_節7_紋柄1CP.Update();
			this.X0Y0_節7_紋柄2CP.Update();
			this.X0Y0_節7_鎧CP.Update();
			this.X0Y0_節7_吸盤1CP.Update();
			this.X0Y0_節7_吸盤2CP.Update();
			this.X0Y0_節7_吸盤3CP.Update();
			this.X0Y0_節7_吸盤4CP.Update();
			this.X0Y0_節8_節CP.Update(this.mm);
			this.X0Y0_節8_紋柄1CP.Update();
			this.X0Y0_節8_紋柄2CP.Update();
			this.X0Y0_節8_鎧CP.Update();
			this.X0Y0_節8_吸盤1CP.Update();
			this.X0Y0_節8_吸盤2CP.Update();
			this.X0Y0_節8_吸盤3CP.Update();
			this.X0Y0_節8_吸盤4CP.Update();
			this.X0Y0_輪1_革CP.Update();
			this.X0Y0_輪1_金具1CP.Update();
			this.X0Y0_輪1_金具2CP.Update();
			this.X0Y0_輪1_金具3CP.Update();
			this.X0Y0_輪1_金具左CP.Update();
			this.X0Y0_輪1_金具右CP.Update();
			this.X0Y0_節9_節CP.Update(this.mm);
			this.X0Y0_節9_紋柄1CP.Update();
			this.X0Y0_節9_紋柄2CP.Update();
			this.X0Y0_節9_鎧CP.Update();
			this.X0Y0_節9_吸盤1CP.Update();
			this.X0Y0_節9_吸盤2CP.Update();
			this.X0Y0_節9_吸盤3CP.Update();
			this.X0Y0_節9_吸盤4CP.Update();
			this.X0Y0_節10_節CP.Update(this.mm);
			this.X0Y0_節10_紋柄1CP.Update();
			this.X0Y0_節10_紋柄2CP.Update();
			this.X0Y0_節10_鎧CP.Update();
			this.X0Y0_節10_吸盤1CP.Update();
			this.X0Y0_節10_吸盤2CP.Update();
			this.X0Y0_節10_吸盤3CP.Update();
			this.X0Y0_節10_吸盤4CP.Update();
			this.X0Y0_節11_節CP.Update(this.mm);
			this.X0Y0_節11_紋柄1CP.Update();
			this.X0Y0_節11_紋柄2CP.Update();
			this.X0Y0_節11_鎧CP.Update();
			this.X0Y0_節11_吸盤1CP.Update();
			this.X0Y0_節11_吸盤2CP.Update();
			this.X0Y0_節11_吸盤3CP.Update();
			this.X0Y0_節11_吸盤4CP.Update();
			this.X0Y0_節12_節CP.Update(this.mm);
			this.X0Y0_節12_紋柄1CP.Update();
			this.X0Y0_節12_紋柄2CP.Update();
			this.X0Y0_節12_鎧CP.Update();
			this.X0Y0_節12_吸盤1CP.Update();
			this.X0Y0_節12_吸盤2CP.Update();
			this.X0Y0_節12_吸盤3CP.Update();
			this.X0Y0_節12_吸盤4CP.Update();
			this.X0Y0_節13_節CP.Update(this.mm);
			this.X0Y0_節13_紋柄1CP.Update();
			this.X0Y0_節13_紋柄2CP.Update();
			this.X0Y0_節13_鎧CP.Update();
			this.X0Y0_節13_吸盤1CP.Update();
			this.X0Y0_節13_吸盤2CP.Update();
			this.X0Y0_節13_吸盤3CP.Update();
			this.X0Y0_節13_吸盤4CP.Update();
			this.X0Y0_節14_節CP.Update(this.mm);
			this.X0Y0_節14_紋柄1CP.Update();
			this.X0Y0_節14_紋柄2CP.Update();
			this.X0Y0_節14_鎧CP.Update();
			this.X0Y0_節14_吸盤1CP.Update();
			this.X0Y0_節14_吸盤2CP.Update();
			this.X0Y0_節14_吸盤3CP.Update();
			this.X0Y0_節14_吸盤4CP.Update();
			this.X0Y0_節15_節CP.Update(this.mm);
			this.X0Y0_節15_紋柄1CP.Update();
			this.X0Y0_節15_紋柄2CP.Update();
			this.X0Y0_節15_鎧CP.Update();
			this.X0Y0_節15_吸盤1CP.Update();
			this.X0Y0_節15_吸盤2CP.Update();
			this.X0Y0_節15_吸盤3CP.Update();
			this.X0Y0_節15_吸盤4CP.Update();
			this.X0Y0_節16_節CP.Update(this.mm);
			this.X0Y0_節16_紋柄1CP.Update();
			this.X0Y0_節16_紋柄2CP.Update();
			this.X0Y0_節16_鎧CP.Update();
			this.X0Y0_節16_吸盤1CP.Update();
			this.X0Y0_節16_吸盤2CP.Update();
			this.X0Y0_節16_吸盤3CP.Update();
			this.X0Y0_節16_吸盤4CP.Update();
			this.X0Y0_節17_節CP.Update(this.mm);
			this.X0Y0_節17_紋柄1CP.Update();
			this.X0Y0_節17_紋柄2CP.Update();
			this.X0Y0_節17_鎧CP.Update();
			this.X0Y0_節17_吸盤1CP.Update();
			this.X0Y0_節17_吸盤2CP.Update();
			this.X0Y0_節17_吸盤3CP.Update();
			this.X0Y0_節17_吸盤4CP.Update();
			this.X0Y0_節18_節CP.Update(this.mm);
			this.X0Y0_節18_紋柄1CP.Update();
			this.X0Y0_節18_紋柄2CP.Update();
			this.X0Y0_節18_鎧CP.Update();
			this.X0Y0_節18_吸盤1CP.Update();
			this.X0Y0_節18_吸盤2CP.Update();
			this.X0Y0_節18_吸盤3CP.Update();
			this.X0Y0_節18_吸盤4CP.Update();
			this.X0Y0_節19_節CP.Update(this.mm);
			this.X0Y0_節19_紋柄1CP.Update();
			this.X0Y0_節19_紋柄2CP.Update();
			this.X0Y0_節19_鎧CP.Update();
			this.X0Y0_節19_吸盤1CP.Update();
			this.X0Y0_節19_吸盤2CP.Update();
			this.X0Y0_節19_吸盤3CP.Update();
			this.X0Y0_節19_吸盤4CP.Update();
			this.X0Y0_輪2_革CP.Update();
			this.X0Y0_輪2_金具1CP.Update();
			this.X0Y0_輪2_金具2CP.Update();
			this.X0Y0_輪2_金具3CP.Update();
			this.X0Y0_輪2_金具左CP.Update();
			this.X0Y0_輪2_金具右CP.Update();
			this.X0Y0_節20_節CP.Update(this.mm);
			this.X0Y0_節20_紋柄1CP.Update();
			this.X0Y0_節20_紋柄2CP.Update();
			this.X0Y0_節20_鎧CP.Update();
			this.X0Y0_節20_吸盤1CP.Update();
			this.X0Y0_節20_吸盤2CP.Update();
			this.X0Y0_節20_吸盤3CP.Update();
			this.X0Y0_節20_吸盤4CP.Update();
			this.X0Y0_節21_節CP.Update(this.mm);
			this.X0Y0_節21_紋柄1CP.Update();
			this.X0Y0_節21_紋柄2CP.Update();
			this.X0Y0_節21_鎧CP.Update();
			this.X0Y0_節21_吸盤1CP.Update();
			this.X0Y0_節21_吸盤2CP.Update();
			this.X0Y0_節21_吸盤3CP.Update();
			this.X0Y0_節21_吸盤4CP.Update();
			this.X0Y0_節22_節CP.Update(this.mm);
			this.X0Y0_節22_紋柄1CP.Update();
			this.X0Y0_節22_紋柄2CP.Update();
			this.X0Y0_節22_鎧CP.Update();
			this.X0Y0_節22_吸盤1CP.Update();
			this.X0Y0_節22_吸盤2CP.Update();
			this.X0Y0_節22_吸盤3CP.Update();
			this.X0Y0_節22_吸盤4CP.Update();
			this.X0Y0_節23_節CP.Update(this.mm);
			this.X0Y0_節23_紋柄1CP.Update();
			this.X0Y0_節23_紋柄2CP.Update();
			this.X0Y0_節23_鎧CP.Update();
			this.X0Y0_節23_吸盤1CP.Update();
			this.X0Y0_節23_吸盤2CP.Update();
			this.X0Y0_節23_吸盤3CP.Update();
			this.X0Y0_節23_吸盤4CP.Update();
			this.X0Y0_節24_節CP.Update(this.mm);
			this.X0Y0_節24_紋柄1CP.Update();
			this.X0Y0_節24_紋柄2CP.Update();
			this.X0Y0_節24_鎧CP.Update();
			this.X0Y0_節24_吸盤1CP.Update();
			this.X0Y0_節24_吸盤2CP.Update();
			this.X0Y0_節24_吸盤3CP.Update();
			this.X0Y0_節24_吸盤4CP.Update();
			this.X0Y0_節25_節CP.Update(this.mm);
			this.X0Y0_節25_紋柄1CP.Update();
			this.X0Y0_節25_紋柄2CP.Update();
			this.X0Y0_節25_鎧CP.Update();
			this.X0Y0_節25_吸盤1CP.Update();
			this.X0Y0_節25_吸盤2CP.Update();
			this.X0Y0_節25_吸盤3CP.Update();
			this.X0Y0_節25_吸盤4CP.Update();
			this.X0Y0_節26_節CP.Update(this.mm);
			this.X0Y0_節26_紋柄1CP.Update();
			this.X0Y0_節26_紋柄2CP.Update();
			this.X0Y0_節26_鎧CP.Update();
			this.X0Y0_節26_吸盤1CP.Update();
			this.X0Y0_節26_吸盤2CP.Update();
			this.X0Y0_節26_吸盤3CP.Update();
			this.X0Y0_節26_吸盤4CP.Update();
			this.X0Y0_節27_節CP.Update(this.mm);
			this.X0Y0_節27_紋柄1CP.Update();
			this.X0Y0_節27_紋柄2CP.Update();
			this.X0Y0_節27_鎧CP.Update();
			this.X0Y0_節27_吸盤1CP.Update();
			this.X0Y0_節27_吸盤2CP.Update();
			this.X0Y0_節27_吸盤3CP.Update();
			this.X0Y0_節27_吸盤4CP.Update();
			this.X0Y0_節28_節CP.Update(this.mm);
			this.X0Y0_節28_紋柄1CP.Update();
			this.X0Y0_節28_紋柄2CP.Update();
			this.X0Y0_節28_鎧CP.Update();
			this.X0Y0_節28_吸盤1CP.Update();
			this.X0Y0_節28_吸盤2CP.Update();
			this.X0Y0_節28_吸盤3CP.Update();
			this.X0Y0_節28_吸盤4CP.Update();
			this.X0Y0_節29_節CP.Update(this.mm);
			this.X0Y0_節29_紋柄1CP.Update();
			this.X0Y0_節29_紋柄2CP.Update();
			this.X0Y0_節29_鎧CP.Update();
			this.X0Y0_節29_吸盤1CP.Update();
			this.X0Y0_節29_吸盤2CP.Update();
			this.X0Y0_節29_吸盤3CP.Update();
			this.X0Y0_節29_吸盤4CP.Update();
			this.X0Y0_節30_節CP.Update(this.mm);
			this.X0Y0_節30_紋柄1CP.Update();
			this.X0Y0_節30_紋柄2CP.Update();
			this.X0Y0_節30_鎧CP.Update();
			this.X0Y0_節30_吸盤1CP.Update();
			this.X0Y0_節30_吸盤2CP.Update();
			this.X0Y0_節30_吸盤3CP.Update();
			this.X0Y0_節30_吸盤4CP.Update();
			this.X0Y0_節31_節CP.Update(this.mm);
			this.X0Y0_節31_紋柄1CP.Update();
			this.X0Y0_節31_紋柄2CP.Update();
			this.X0Y0_節31_鎧CP.Update();
			this.X0Y0_節31_吸盤1CP.Update();
			this.X0Y0_節31_吸盤2CP.Update();
			this.X0Y0_節31_吸盤3CP.Update();
			this.X0Y0_節31_吸盤4CP.Update();
			this.X0Y0_節32_節CP.Update(this.mm);
			this.X0Y0_節32_紋柄1CP.Update();
			this.X0Y0_節32_紋柄2CP.Update();
			this.X0Y0_節32_鎧CP.Update();
			this.X0Y0_節32_吸盤1CP.Update();
			this.X0Y0_節32_吸盤2CP.Update();
			this.X0Y0_節32_吸盤3CP.Update();
			this.X0Y0_節32_吸盤4CP.Update();
			this.X0Y0_節33_節CP.Update(this.mm);
			this.X0Y0_節33_紋柄1CP.Update();
			this.X0Y0_節33_紋柄2CP.Update();
			this.X0Y0_節33_鎧CP.Update();
			this.X0Y0_節33_吸盤1CP.Update();
			this.X0Y0_節33_吸盤2CP.Update();
			this.X0Y0_節33_吸盤3CP.Update();
			this.X0Y0_節33_吸盤4CP.Update();
			this.X0Y0_節34_節CP.Update(this.mm);
			this.X0Y0_節34_紋柄1CP.Update();
			this.X0Y0_節34_紋柄2CP.Update();
			this.X0Y0_節34_鎧CP.Update();
			this.X0Y0_節34_吸盤1CP.Update();
			this.X0Y0_節34_吸盤2CP.Update();
			this.X0Y0_節34_吸盤3CP.Update();
			this.X0Y0_節34_吸盤4CP.Update();
			this.X0Y0_節35_節CP.Update(this.mm);
			this.X0Y0_節35_紋柄1CP.Update();
			this.X0Y0_節35_紋柄2CP.Update();
			this.X0Y0_節35_鎧CP.Update();
			this.X0Y0_節35_吸盤1CP.Update();
			this.X0Y0_節35_吸盤2CP.Update();
			this.X0Y0_節35_吸盤3CP.Update();
			this.X0Y0_節35_吸盤4CP.Update();
			this.X0Y0_節36_節CP.Update(this.mm);
			this.X0Y0_節36_紋柄1CP.Update();
			this.X0Y0_節36_紋柄2CP.Update();
			this.X0Y0_節36_鎧CP.Update();
			this.X0Y0_節36_吸盤1CP.Update();
			this.X0Y0_節36_吸盤2CP.Update();
			this.X0Y0_節36_吸盤3CP.Update();
			this.X0Y0_節36_吸盤4CP.Update();
			this.X0Y0_節37_節CP.Update(this.mm);
			this.X0Y0_節37_紋柄1CP.Update();
			this.X0Y0_節37_紋柄2CP.Update();
			this.X0Y0_節37_鎧CP.Update();
			this.X0Y0_節37_吸盤1CP.Update();
			this.X0Y0_節37_吸盤2CP.Update();
			this.X0Y0_節37_吸盤3CP.Update();
			this.X0Y0_節37_吸盤4CP.Update();
			this.X0Y0_節38_節CP.Update(this.mm);
			this.X0Y0_節38_紋柄1CP.Update();
			this.X0Y0_節38_紋柄2CP.Update();
			this.X0Y0_節38_鎧CP.Update();
			this.X0Y0_節38_吸盤1CP.Update();
			this.X0Y0_節38_吸盤2CP.Update();
			this.X0Y0_節38_吸盤3CP.Update();
			this.X0Y0_節38_吸盤4CP.Update();
			this.X0Y0_節39_節CP.Update(this.mm);
			this.X0Y0_節39_紋柄1CP.Update();
			this.X0Y0_節39_紋柄2CP.Update();
			this.X0Y0_節39_鎧CP.Update();
			this.X0Y0_節39_吸盤1CP.Update();
			this.X0Y0_節39_吸盤2CP.Update();
			this.X0Y0_節39_吸盤3CP.Update();
			this.X0Y0_節39_吸盤4CP.Update();
			this.X0Y0_節40_節CP.Update(this.mm);
			this.X0Y0_節40_紋柄1CP.Update();
			this.X0Y0_節40_紋柄2CP.Update();
			this.X0Y0_節40_鎧CP.Update();
			this.X0Y0_節40_吸盤1CP.Update();
			this.X0Y0_節40_吸盤2CP.Update();
			this.X0Y0_節40_吸盤3CP.Update();
			this.X0Y0_節40_吸盤4CP.Update();
			this.X0Y0_節41_節CP.Update(this.mm);
			this.X0Y0_節41_紋柄1CP.Update();
			this.X0Y0_節41_紋柄2CP.Update();
			this.X0Y0_節41_鎧CP.Update();
			this.X0Y0_節41_吸盤1CP.Update();
			this.X0Y0_節41_吸盤2CP.Update();
			this.X0Y0_節41_吸盤3CP.Update();
			this.X0Y0_節41_吸盤4CP.Update();
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
			this.節1_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節1_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節1_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節1_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節1_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節1_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節1_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節1_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節2_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節2_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節2_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節2_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節2_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節2_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節2_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節2_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節3_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節3_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節3_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節3_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節3_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節3_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節3_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節3_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節4_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節4_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節4_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節4_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節4_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節4_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節4_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節4_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節5_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節5_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節5_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節5_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節5_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節5_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節5_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節5_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節6_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節6_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節6_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節6_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節6_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節6_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節6_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節6_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節7_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節7_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節7_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節7_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節7_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節7_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節7_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節7_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節8_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節8_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節8_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節8_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節8_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節8_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節8_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節8_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節9_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節9_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節9_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節9_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節9_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節9_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節9_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節9_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節10_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節10_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節10_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節10_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節10_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節10_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節10_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節10_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節11_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節11_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節11_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節11_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節11_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節11_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節11_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節11_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節12_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節12_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節12_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節12_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節12_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節12_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節12_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節12_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節13_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節13_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節13_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節13_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節13_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節13_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節13_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節13_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節14_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節14_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節14_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節14_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節14_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節14_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節14_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節14_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節15_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節15_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節15_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節15_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節15_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節15_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節15_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節15_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節16_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節16_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節16_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節16_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節16_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節16_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節16_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節16_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節17_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節17_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節17_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節17_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節17_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節17_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節17_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節17_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節18_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節18_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節18_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節18_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節18_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節18_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節18_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節18_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節19_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節19_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節19_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節19_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節19_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節19_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節19_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節19_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節20_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節20_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節20_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節20_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節20_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節20_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節20_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節20_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節21_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節21_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節21_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節21_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節21_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節21_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節21_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節21_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節22_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節22_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節22_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節22_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節22_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節22_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節22_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節22_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節23_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節23_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節23_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節23_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節23_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節23_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節23_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節23_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節24_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節24_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節24_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節24_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節24_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節24_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節24_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節24_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節25_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節25_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節25_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節25_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節25_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節25_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節25_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節25_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節26_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節26_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節26_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節26_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節26_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節26_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節26_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節26_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節27_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節27_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節27_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節27_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節27_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節27_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節27_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節27_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節28_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節28_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節28_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節28_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節28_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節28_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節28_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節28_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節29_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節29_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節29_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節29_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節29_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節29_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節29_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節29_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節30_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節30_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節30_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節30_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節30_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節30_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節30_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節30_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節31_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節31_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節31_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節31_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節31_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節31_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節31_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節31_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節32_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節32_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節32_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節32_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節32_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節32_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節32_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節32_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節33_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節33_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節33_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節33_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節33_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節33_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節33_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節33_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節34_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節34_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節34_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節34_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節34_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節34_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節34_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節34_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節35_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節35_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節35_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節35_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節35_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節35_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節35_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節35_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節36_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節36_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節36_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節36_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節36_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節36_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節36_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節36_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節37_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節37_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節37_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節37_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節37_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節37_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節37_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節37_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節38_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節38_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節38_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節38_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節38_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節38_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節38_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節38_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節39_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節39_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節39_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節39_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節39_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節39_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節39_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節39_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節40_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節40_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節40_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節40_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節40_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節40_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節40_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節40_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節41_節CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.節41_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節41_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節41_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節41_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節41_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節41_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節41_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
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
			this.配色T(0, "節CD", ref 体配色.体0O, ref 体配色.刺青O);
			this.節1_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節1_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節1_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節1_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節1_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節1_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節1_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節2_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節2_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節2_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節2_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節2_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節2_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節2_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節3_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節3_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節3_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節3_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節3_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節3_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節3_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節4_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節4_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節4_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節4_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節4_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節4_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節4_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節5_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節5_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節5_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節5_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節5_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節5_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節5_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節6_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節6_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節6_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節6_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節6_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節6_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節6_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節7_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節7_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節7_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節7_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節7_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節7_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節7_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節8_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節8_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節8_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節8_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節8_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節8_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節8_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節9_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節9_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節9_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節9_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節9_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節9_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節9_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節10_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節10_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節10_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節10_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節10_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節10_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節10_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節11_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節11_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節11_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節11_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節11_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節11_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節11_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節12_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節12_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節12_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節12_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節12_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節12_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節12_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節13_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節13_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節13_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節13_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節13_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節13_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節13_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節14_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節14_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節14_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節14_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節14_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節14_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節14_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節15_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節15_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節15_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節15_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節15_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節15_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節15_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節16_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節16_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節16_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節16_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節16_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節16_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節16_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節17_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節17_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節17_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節17_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節17_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節17_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節17_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節18_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節18_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節18_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節18_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節18_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節18_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節18_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節19_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節19_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節19_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節19_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節19_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節19_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節19_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節20_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節20_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節20_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節20_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節20_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節20_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節20_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節21_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節21_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節21_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節21_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節21_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節21_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節21_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節22_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節22_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節22_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節22_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節22_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節22_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節22_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節23_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節23_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節23_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節23_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節23_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節23_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節23_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節24_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節24_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節24_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節24_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節24_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節24_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節24_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節25_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節25_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節25_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節25_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節25_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節25_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節25_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節26_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節26_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節26_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節26_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節26_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節26_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節26_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節27_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節27_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節27_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節27_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節27_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節27_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節27_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節28_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節28_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節28_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節28_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節28_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節28_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節28_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節29_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節29_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節29_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節29_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節29_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節29_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節29_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節30_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節30_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節30_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節30_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節30_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節30_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節30_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節31_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節31_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節31_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節31_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節31_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節31_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節31_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節32_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節32_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節32_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節32_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節32_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節32_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節32_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節33_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節33_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節33_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節33_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節33_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節33_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節33_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節34_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節34_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節34_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節34_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節34_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節34_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節34_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節35_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節35_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節35_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節35_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節35_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節35_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節35_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節36_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節36_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節36_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節36_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節36_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節36_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節36_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節37_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節37_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節37_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節37_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節37_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節37_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節37_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節38_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節38_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節38_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節38_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節38_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節38_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節38_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節39_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節39_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節39_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節39_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節39_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節39_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節39_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節40_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節40_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節40_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節40_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節40_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節40_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節40_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節41_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節41_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節41_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節41_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節41_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節41_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節41_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
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
			this.配色T(1, "節CD", ref 体配色.体0O, ref 体配色.刺青O);
			this.節1_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節1_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節1_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節1_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節1_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節1_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節1_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節2_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節2_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節2_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節2_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節2_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節2_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節2_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節3_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節3_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節3_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節3_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節3_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節3_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節3_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節4_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節4_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節4_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節4_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節4_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節4_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節4_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節5_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節5_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節5_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節5_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節5_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節5_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節5_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節6_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節6_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節6_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節6_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節6_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節6_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節6_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節7_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節7_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節7_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節7_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節7_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節7_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節7_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節8_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節8_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節8_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節8_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節8_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節8_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節8_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節9_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節9_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節9_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節9_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節9_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節9_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節9_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節10_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節10_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節10_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節10_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節10_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節10_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節10_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節11_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節11_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節11_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節11_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節11_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節11_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節11_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節12_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節12_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節12_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節12_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節12_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節12_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節12_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節13_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節13_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節13_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節13_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節13_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節13_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節13_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節14_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節14_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節14_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節14_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節14_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節14_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節14_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節15_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節15_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節15_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節15_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節15_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節15_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節15_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節16_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節16_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節16_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節16_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節16_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節16_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節16_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節17_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節17_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節17_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節17_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節17_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節17_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節17_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節18_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節18_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節18_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節18_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節18_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節18_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節18_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節19_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節19_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節19_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節19_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節19_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節19_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節19_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節20_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節20_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節20_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節20_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節20_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節20_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節20_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節21_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節21_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節21_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節21_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節21_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節21_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節21_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節22_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節22_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節22_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節22_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節22_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節22_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節22_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節23_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節23_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節23_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節23_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節23_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節23_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節23_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節24_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節24_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節24_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節24_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節24_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節24_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節24_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節25_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節25_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節25_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節25_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節25_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節25_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節25_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節26_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節26_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節26_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節26_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節26_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節26_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節26_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節27_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節27_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節27_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節27_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節27_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節27_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節27_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節28_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節28_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節28_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節28_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節28_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節28_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節28_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節29_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節29_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節29_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節29_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節29_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節29_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節29_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節30_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節30_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節30_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節30_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節30_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節30_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節30_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節31_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節31_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節31_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節31_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節31_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節31_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節31_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節32_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節32_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節32_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節32_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節32_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節32_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節32_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節33_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節33_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節33_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節33_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節33_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節33_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節33_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節34_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節34_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節34_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節34_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節34_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節34_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節34_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節35_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節35_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節35_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節35_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節35_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節35_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節35_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節36_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節36_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節36_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節36_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節36_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節36_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節36_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節37_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節37_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節37_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節37_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節37_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節37_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節37_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節38_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節38_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節38_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節38_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節38_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節38_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節38_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節39_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節39_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節39_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節39_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節39_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節39_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節39_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節40_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節40_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節40_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節40_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節40_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節40_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節40_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節41_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節41_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.節41_鎧CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.節41_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節41_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.節41_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.節41_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
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

		public Par X0Y0_節1_節;

		public Par X0Y0_節1_紋柄1;

		public Par X0Y0_節1_紋柄2;

		public Par X0Y0_節1_鎧;

		public Par X0Y0_節1_吸盤1;

		public Par X0Y0_節1_吸盤2;

		public Par X0Y0_節1_吸盤3;

		public Par X0Y0_節1_吸盤4;

		public Par X0Y0_節2_節;

		public Par X0Y0_節2_紋柄1;

		public Par X0Y0_節2_紋柄2;

		public Par X0Y0_節2_鎧;

		public Par X0Y0_節2_吸盤1;

		public Par X0Y0_節2_吸盤2;

		public Par X0Y0_節2_吸盤3;

		public Par X0Y0_節2_吸盤4;

		public Par X0Y0_節3_節;

		public Par X0Y0_節3_紋柄1;

		public Par X0Y0_節3_紋柄2;

		public Par X0Y0_節3_鎧;

		public Par X0Y0_節3_吸盤1;

		public Par X0Y0_節3_吸盤2;

		public Par X0Y0_節3_吸盤3;

		public Par X0Y0_節3_吸盤4;

		public Par X0Y0_節4_節;

		public Par X0Y0_節4_紋柄1;

		public Par X0Y0_節4_紋柄2;

		public Par X0Y0_節4_鎧;

		public Par X0Y0_節4_吸盤1;

		public Par X0Y0_節4_吸盤2;

		public Par X0Y0_節4_吸盤3;

		public Par X0Y0_節4_吸盤4;

		public Par X0Y0_節5_節;

		public Par X0Y0_節5_紋柄1;

		public Par X0Y0_節5_紋柄2;

		public Par X0Y0_節5_鎧;

		public Par X0Y0_節5_吸盤1;

		public Par X0Y0_節5_吸盤2;

		public Par X0Y0_節5_吸盤3;

		public Par X0Y0_節5_吸盤4;

		public Par X0Y0_節6_節;

		public Par X0Y0_節6_紋柄1;

		public Par X0Y0_節6_紋柄2;

		public Par X0Y0_節6_鎧;

		public Par X0Y0_節6_吸盤1;

		public Par X0Y0_節6_吸盤2;

		public Par X0Y0_節6_吸盤3;

		public Par X0Y0_節6_吸盤4;

		public Par X0Y0_節7_節;

		public Par X0Y0_節7_紋柄1;

		public Par X0Y0_節7_紋柄2;

		public Par X0Y0_節7_鎧;

		public Par X0Y0_節7_吸盤1;

		public Par X0Y0_節7_吸盤2;

		public Par X0Y0_節7_吸盤3;

		public Par X0Y0_節7_吸盤4;

		public Par X0Y0_節8_節;

		public Par X0Y0_節8_紋柄1;

		public Par X0Y0_節8_紋柄2;

		public Par X0Y0_節8_鎧;

		public Par X0Y0_節8_吸盤1;

		public Par X0Y0_節8_吸盤2;

		public Par X0Y0_節8_吸盤3;

		public Par X0Y0_節8_吸盤4;

		public Par X0Y0_輪1_革;

		public Par X0Y0_輪1_金具1;

		public Par X0Y0_輪1_金具2;

		public Par X0Y0_輪1_金具3;

		public Par X0Y0_輪1_金具左;

		public Par X0Y0_輪1_金具右;

		public Par X0Y0_節9_節;

		public Par X0Y0_節9_紋柄1;

		public Par X0Y0_節9_紋柄2;

		public Par X0Y0_節9_鎧;

		public Par X0Y0_節9_吸盤1;

		public Par X0Y0_節9_吸盤2;

		public Par X0Y0_節9_吸盤3;

		public Par X0Y0_節9_吸盤4;

		public Par X0Y0_節10_節;

		public Par X0Y0_節10_紋柄1;

		public Par X0Y0_節10_紋柄2;

		public Par X0Y0_節10_鎧;

		public Par X0Y0_節10_吸盤1;

		public Par X0Y0_節10_吸盤2;

		public Par X0Y0_節10_吸盤3;

		public Par X0Y0_節10_吸盤4;

		public Par X0Y0_節11_節;

		public Par X0Y0_節11_紋柄1;

		public Par X0Y0_節11_紋柄2;

		public Par X0Y0_節11_鎧;

		public Par X0Y0_節11_吸盤1;

		public Par X0Y0_節11_吸盤2;

		public Par X0Y0_節11_吸盤3;

		public Par X0Y0_節11_吸盤4;

		public Par X0Y0_節12_節;

		public Par X0Y0_節12_紋柄1;

		public Par X0Y0_節12_紋柄2;

		public Par X0Y0_節12_鎧;

		public Par X0Y0_節12_吸盤1;

		public Par X0Y0_節12_吸盤2;

		public Par X0Y0_節12_吸盤3;

		public Par X0Y0_節12_吸盤4;

		public Par X0Y0_節13_節;

		public Par X0Y0_節13_紋柄1;

		public Par X0Y0_節13_紋柄2;

		public Par X0Y0_節13_鎧;

		public Par X0Y0_節13_吸盤1;

		public Par X0Y0_節13_吸盤2;

		public Par X0Y0_節13_吸盤3;

		public Par X0Y0_節13_吸盤4;

		public Par X0Y0_節14_節;

		public Par X0Y0_節14_紋柄1;

		public Par X0Y0_節14_紋柄2;

		public Par X0Y0_節14_鎧;

		public Par X0Y0_節14_吸盤1;

		public Par X0Y0_節14_吸盤2;

		public Par X0Y0_節14_吸盤3;

		public Par X0Y0_節14_吸盤4;

		public Par X0Y0_節15_節;

		public Par X0Y0_節15_紋柄1;

		public Par X0Y0_節15_紋柄2;

		public Par X0Y0_節15_鎧;

		public Par X0Y0_節15_吸盤1;

		public Par X0Y0_節15_吸盤2;

		public Par X0Y0_節15_吸盤3;

		public Par X0Y0_節15_吸盤4;

		public Par X0Y0_節16_節;

		public Par X0Y0_節16_紋柄1;

		public Par X0Y0_節16_紋柄2;

		public Par X0Y0_節16_鎧;

		public Par X0Y0_節16_吸盤1;

		public Par X0Y0_節16_吸盤2;

		public Par X0Y0_節16_吸盤3;

		public Par X0Y0_節16_吸盤4;

		public Par X0Y0_節17_節;

		public Par X0Y0_節17_紋柄1;

		public Par X0Y0_節17_紋柄2;

		public Par X0Y0_節17_鎧;

		public Par X0Y0_節17_吸盤1;

		public Par X0Y0_節17_吸盤2;

		public Par X0Y0_節17_吸盤3;

		public Par X0Y0_節17_吸盤4;

		public Par X0Y0_節18_節;

		public Par X0Y0_節18_紋柄1;

		public Par X0Y0_節18_紋柄2;

		public Par X0Y0_節18_鎧;

		public Par X0Y0_節18_吸盤1;

		public Par X0Y0_節18_吸盤2;

		public Par X0Y0_節18_吸盤3;

		public Par X0Y0_節18_吸盤4;

		public Par X0Y0_節19_節;

		public Par X0Y0_節19_紋柄1;

		public Par X0Y0_節19_紋柄2;

		public Par X0Y0_節19_鎧;

		public Par X0Y0_節19_吸盤1;

		public Par X0Y0_節19_吸盤2;

		public Par X0Y0_節19_吸盤3;

		public Par X0Y0_節19_吸盤4;

		public Par X0Y0_輪2_革;

		public Par X0Y0_輪2_金具1;

		public Par X0Y0_輪2_金具2;

		public Par X0Y0_輪2_金具3;

		public Par X0Y0_輪2_金具左;

		public Par X0Y0_輪2_金具右;

		public Par X0Y0_節20_節;

		public Par X0Y0_節20_紋柄1;

		public Par X0Y0_節20_紋柄2;

		public Par X0Y0_節20_鎧;

		public Par X0Y0_節20_吸盤1;

		public Par X0Y0_節20_吸盤2;

		public Par X0Y0_節20_吸盤3;

		public Par X0Y0_節20_吸盤4;

		public Par X0Y0_節21_節;

		public Par X0Y0_節21_紋柄1;

		public Par X0Y0_節21_紋柄2;

		public Par X0Y0_節21_鎧;

		public Par X0Y0_節21_吸盤1;

		public Par X0Y0_節21_吸盤2;

		public Par X0Y0_節21_吸盤3;

		public Par X0Y0_節21_吸盤4;

		public Par X0Y0_節22_節;

		public Par X0Y0_節22_紋柄1;

		public Par X0Y0_節22_紋柄2;

		public Par X0Y0_節22_鎧;

		public Par X0Y0_節22_吸盤1;

		public Par X0Y0_節22_吸盤2;

		public Par X0Y0_節22_吸盤3;

		public Par X0Y0_節22_吸盤4;

		public Par X0Y0_節23_節;

		public Par X0Y0_節23_紋柄1;

		public Par X0Y0_節23_紋柄2;

		public Par X0Y0_節23_鎧;

		public Par X0Y0_節23_吸盤1;

		public Par X0Y0_節23_吸盤2;

		public Par X0Y0_節23_吸盤3;

		public Par X0Y0_節23_吸盤4;

		public Par X0Y0_節24_節;

		public Par X0Y0_節24_紋柄1;

		public Par X0Y0_節24_紋柄2;

		public Par X0Y0_節24_鎧;

		public Par X0Y0_節24_吸盤1;

		public Par X0Y0_節24_吸盤2;

		public Par X0Y0_節24_吸盤3;

		public Par X0Y0_節24_吸盤4;

		public Par X0Y0_節25_節;

		public Par X0Y0_節25_紋柄1;

		public Par X0Y0_節25_紋柄2;

		public Par X0Y0_節25_鎧;

		public Par X0Y0_節25_吸盤1;

		public Par X0Y0_節25_吸盤2;

		public Par X0Y0_節25_吸盤3;

		public Par X0Y0_節25_吸盤4;

		public Par X0Y0_節26_節;

		public Par X0Y0_節26_紋柄1;

		public Par X0Y0_節26_紋柄2;

		public Par X0Y0_節26_鎧;

		public Par X0Y0_節26_吸盤1;

		public Par X0Y0_節26_吸盤2;

		public Par X0Y0_節26_吸盤3;

		public Par X0Y0_節26_吸盤4;

		public Par X0Y0_節27_節;

		public Par X0Y0_節27_紋柄1;

		public Par X0Y0_節27_紋柄2;

		public Par X0Y0_節27_鎧;

		public Par X0Y0_節27_吸盤1;

		public Par X0Y0_節27_吸盤2;

		public Par X0Y0_節27_吸盤3;

		public Par X0Y0_節27_吸盤4;

		public Par X0Y0_節28_節;

		public Par X0Y0_節28_紋柄1;

		public Par X0Y0_節28_紋柄2;

		public Par X0Y0_節28_鎧;

		public Par X0Y0_節28_吸盤1;

		public Par X0Y0_節28_吸盤2;

		public Par X0Y0_節28_吸盤3;

		public Par X0Y0_節28_吸盤4;

		public Par X0Y0_節29_節;

		public Par X0Y0_節29_紋柄1;

		public Par X0Y0_節29_紋柄2;

		public Par X0Y0_節29_鎧;

		public Par X0Y0_節29_吸盤1;

		public Par X0Y0_節29_吸盤2;

		public Par X0Y0_節29_吸盤3;

		public Par X0Y0_節29_吸盤4;

		public Par X0Y0_節30_節;

		public Par X0Y0_節30_紋柄1;

		public Par X0Y0_節30_紋柄2;

		public Par X0Y0_節30_鎧;

		public Par X0Y0_節30_吸盤1;

		public Par X0Y0_節30_吸盤2;

		public Par X0Y0_節30_吸盤3;

		public Par X0Y0_節30_吸盤4;

		public Par X0Y0_節31_節;

		public Par X0Y0_節31_紋柄1;

		public Par X0Y0_節31_紋柄2;

		public Par X0Y0_節31_鎧;

		public Par X0Y0_節31_吸盤1;

		public Par X0Y0_節31_吸盤2;

		public Par X0Y0_節31_吸盤3;

		public Par X0Y0_節31_吸盤4;

		public Par X0Y0_節32_節;

		public Par X0Y0_節32_紋柄1;

		public Par X0Y0_節32_紋柄2;

		public Par X0Y0_節32_鎧;

		public Par X0Y0_節32_吸盤1;

		public Par X0Y0_節32_吸盤2;

		public Par X0Y0_節32_吸盤3;

		public Par X0Y0_節32_吸盤4;

		public Par X0Y0_節33_節;

		public Par X0Y0_節33_紋柄1;

		public Par X0Y0_節33_紋柄2;

		public Par X0Y0_節33_鎧;

		public Par X0Y0_節33_吸盤1;

		public Par X0Y0_節33_吸盤2;

		public Par X0Y0_節33_吸盤3;

		public Par X0Y0_節33_吸盤4;

		public Par X0Y0_節34_節;

		public Par X0Y0_節34_紋柄1;

		public Par X0Y0_節34_紋柄2;

		public Par X0Y0_節34_鎧;

		public Par X0Y0_節34_吸盤1;

		public Par X0Y0_節34_吸盤2;

		public Par X0Y0_節34_吸盤3;

		public Par X0Y0_節34_吸盤4;

		public Par X0Y0_節35_節;

		public Par X0Y0_節35_紋柄1;

		public Par X0Y0_節35_紋柄2;

		public Par X0Y0_節35_鎧;

		public Par X0Y0_節35_吸盤1;

		public Par X0Y0_節35_吸盤2;

		public Par X0Y0_節35_吸盤3;

		public Par X0Y0_節35_吸盤4;

		public Par X0Y0_節36_節;

		public Par X0Y0_節36_紋柄1;

		public Par X0Y0_節36_紋柄2;

		public Par X0Y0_節36_鎧;

		public Par X0Y0_節36_吸盤1;

		public Par X0Y0_節36_吸盤2;

		public Par X0Y0_節36_吸盤3;

		public Par X0Y0_節36_吸盤4;

		public Par X0Y0_節37_節;

		public Par X0Y0_節37_紋柄1;

		public Par X0Y0_節37_紋柄2;

		public Par X0Y0_節37_鎧;

		public Par X0Y0_節37_吸盤1;

		public Par X0Y0_節37_吸盤2;

		public Par X0Y0_節37_吸盤3;

		public Par X0Y0_節37_吸盤4;

		public Par X0Y0_節38_節;

		public Par X0Y0_節38_紋柄1;

		public Par X0Y0_節38_紋柄2;

		public Par X0Y0_節38_鎧;

		public Par X0Y0_節38_吸盤1;

		public Par X0Y0_節38_吸盤2;

		public Par X0Y0_節38_吸盤3;

		public Par X0Y0_節38_吸盤4;

		public Par X0Y0_節39_節;

		public Par X0Y0_節39_紋柄1;

		public Par X0Y0_節39_紋柄2;

		public Par X0Y0_節39_鎧;

		public Par X0Y0_節39_吸盤1;

		public Par X0Y0_節39_吸盤2;

		public Par X0Y0_節39_吸盤3;

		public Par X0Y0_節39_吸盤4;

		public Par X0Y0_節40_節;

		public Par X0Y0_節40_紋柄1;

		public Par X0Y0_節40_紋柄2;

		public Par X0Y0_節40_鎧;

		public Par X0Y0_節40_吸盤1;

		public Par X0Y0_節40_吸盤2;

		public Par X0Y0_節40_吸盤3;

		public Par X0Y0_節40_吸盤4;

		public Par X0Y0_節41_節;

		public Par X0Y0_節41_紋柄1;

		public Par X0Y0_節41_紋柄2;

		public Par X0Y0_節41_鎧;

		public Par X0Y0_節41_吸盤1;

		public Par X0Y0_節41_吸盤2;

		public Par X0Y0_節41_吸盤3;

		public Par X0Y0_節41_吸盤4;

		public ColorD 節1_節CD;

		public ColorD 節1_紋柄1CD;

		public ColorD 節1_紋柄2CD;

		public ColorD 節1_鎧CD;

		public ColorD 節1_吸盤1CD;

		public ColorD 節1_吸盤2CD;

		public ColorD 節1_吸盤3CD;

		public ColorD 節1_吸盤4CD;

		public ColorD 節2_節CD;

		public ColorD 節2_紋柄1CD;

		public ColorD 節2_紋柄2CD;

		public ColorD 節2_鎧CD;

		public ColorD 節2_吸盤1CD;

		public ColorD 節2_吸盤2CD;

		public ColorD 節2_吸盤3CD;

		public ColorD 節2_吸盤4CD;

		public ColorD 節3_節CD;

		public ColorD 節3_紋柄1CD;

		public ColorD 節3_紋柄2CD;

		public ColorD 節3_鎧CD;

		public ColorD 節3_吸盤1CD;

		public ColorD 節3_吸盤2CD;

		public ColorD 節3_吸盤3CD;

		public ColorD 節3_吸盤4CD;

		public ColorD 節4_節CD;

		public ColorD 節4_紋柄1CD;

		public ColorD 節4_紋柄2CD;

		public ColorD 節4_鎧CD;

		public ColorD 節4_吸盤1CD;

		public ColorD 節4_吸盤2CD;

		public ColorD 節4_吸盤3CD;

		public ColorD 節4_吸盤4CD;

		public ColorD 節5_節CD;

		public ColorD 節5_紋柄1CD;

		public ColorD 節5_紋柄2CD;

		public ColorD 節5_鎧CD;

		public ColorD 節5_吸盤1CD;

		public ColorD 節5_吸盤2CD;

		public ColorD 節5_吸盤3CD;

		public ColorD 節5_吸盤4CD;

		public ColorD 節6_節CD;

		public ColorD 節6_紋柄1CD;

		public ColorD 節6_紋柄2CD;

		public ColorD 節6_鎧CD;

		public ColorD 節6_吸盤1CD;

		public ColorD 節6_吸盤2CD;

		public ColorD 節6_吸盤3CD;

		public ColorD 節6_吸盤4CD;

		public ColorD 節7_節CD;

		public ColorD 節7_紋柄1CD;

		public ColorD 節7_紋柄2CD;

		public ColorD 節7_鎧CD;

		public ColorD 節7_吸盤1CD;

		public ColorD 節7_吸盤2CD;

		public ColorD 節7_吸盤3CD;

		public ColorD 節7_吸盤4CD;

		public ColorD 節8_節CD;

		public ColorD 節8_紋柄1CD;

		public ColorD 節8_紋柄2CD;

		public ColorD 節8_鎧CD;

		public ColorD 節8_吸盤1CD;

		public ColorD 節8_吸盤2CD;

		public ColorD 節8_吸盤3CD;

		public ColorD 節8_吸盤4CD;

		public ColorD 節9_節CD;

		public ColorD 節9_紋柄1CD;

		public ColorD 節9_紋柄2CD;

		public ColorD 節9_鎧CD;

		public ColorD 節9_吸盤1CD;

		public ColorD 節9_吸盤2CD;

		public ColorD 節9_吸盤3CD;

		public ColorD 節9_吸盤4CD;

		public ColorD 節10_節CD;

		public ColorD 節10_紋柄1CD;

		public ColorD 節10_紋柄2CD;

		public ColorD 節10_鎧CD;

		public ColorD 節10_吸盤1CD;

		public ColorD 節10_吸盤2CD;

		public ColorD 節10_吸盤3CD;

		public ColorD 節10_吸盤4CD;

		public ColorD 節11_節CD;

		public ColorD 節11_紋柄1CD;

		public ColorD 節11_紋柄2CD;

		public ColorD 節11_鎧CD;

		public ColorD 節11_吸盤1CD;

		public ColorD 節11_吸盤2CD;

		public ColorD 節11_吸盤3CD;

		public ColorD 節11_吸盤4CD;

		public ColorD 節12_節CD;

		public ColorD 節12_紋柄1CD;

		public ColorD 節12_紋柄2CD;

		public ColorD 節12_鎧CD;

		public ColorD 節12_吸盤1CD;

		public ColorD 節12_吸盤2CD;

		public ColorD 節12_吸盤3CD;

		public ColorD 節12_吸盤4CD;

		public ColorD 節13_節CD;

		public ColorD 節13_紋柄1CD;

		public ColorD 節13_紋柄2CD;

		public ColorD 節13_鎧CD;

		public ColorD 節13_吸盤1CD;

		public ColorD 節13_吸盤2CD;

		public ColorD 節13_吸盤3CD;

		public ColorD 節13_吸盤4CD;

		public ColorD 節14_節CD;

		public ColorD 節14_紋柄1CD;

		public ColorD 節14_紋柄2CD;

		public ColorD 節14_鎧CD;

		public ColorD 節14_吸盤1CD;

		public ColorD 節14_吸盤2CD;

		public ColorD 節14_吸盤3CD;

		public ColorD 節14_吸盤4CD;

		public ColorD 節15_節CD;

		public ColorD 節15_紋柄1CD;

		public ColorD 節15_紋柄2CD;

		public ColorD 節15_鎧CD;

		public ColorD 節15_吸盤1CD;

		public ColorD 節15_吸盤2CD;

		public ColorD 節15_吸盤3CD;

		public ColorD 節15_吸盤4CD;

		public ColorD 節16_節CD;

		public ColorD 節16_紋柄1CD;

		public ColorD 節16_紋柄2CD;

		public ColorD 節16_鎧CD;

		public ColorD 節16_吸盤1CD;

		public ColorD 節16_吸盤2CD;

		public ColorD 節16_吸盤3CD;

		public ColorD 節16_吸盤4CD;

		public ColorD 節17_節CD;

		public ColorD 節17_紋柄1CD;

		public ColorD 節17_紋柄2CD;

		public ColorD 節17_鎧CD;

		public ColorD 節17_吸盤1CD;

		public ColorD 節17_吸盤2CD;

		public ColorD 節17_吸盤3CD;

		public ColorD 節17_吸盤4CD;

		public ColorD 節18_節CD;

		public ColorD 節18_紋柄1CD;

		public ColorD 節18_紋柄2CD;

		public ColorD 節18_鎧CD;

		public ColorD 節18_吸盤1CD;

		public ColorD 節18_吸盤2CD;

		public ColorD 節18_吸盤3CD;

		public ColorD 節18_吸盤4CD;

		public ColorD 節19_節CD;

		public ColorD 節19_紋柄1CD;

		public ColorD 節19_紋柄2CD;

		public ColorD 節19_鎧CD;

		public ColorD 節19_吸盤1CD;

		public ColorD 節19_吸盤2CD;

		public ColorD 節19_吸盤3CD;

		public ColorD 節19_吸盤4CD;

		public ColorD 節20_節CD;

		public ColorD 節20_紋柄1CD;

		public ColorD 節20_紋柄2CD;

		public ColorD 節20_鎧CD;

		public ColorD 節20_吸盤1CD;

		public ColorD 節20_吸盤2CD;

		public ColorD 節20_吸盤3CD;

		public ColorD 節20_吸盤4CD;

		public ColorD 節21_節CD;

		public ColorD 節21_紋柄1CD;

		public ColorD 節21_紋柄2CD;

		public ColorD 節21_鎧CD;

		public ColorD 節21_吸盤1CD;

		public ColorD 節21_吸盤2CD;

		public ColorD 節21_吸盤3CD;

		public ColorD 節21_吸盤4CD;

		public ColorD 節22_節CD;

		public ColorD 節22_紋柄1CD;

		public ColorD 節22_紋柄2CD;

		public ColorD 節22_鎧CD;

		public ColorD 節22_吸盤1CD;

		public ColorD 節22_吸盤2CD;

		public ColorD 節22_吸盤3CD;

		public ColorD 節22_吸盤4CD;

		public ColorD 節23_節CD;

		public ColorD 節23_紋柄1CD;

		public ColorD 節23_紋柄2CD;

		public ColorD 節23_鎧CD;

		public ColorD 節23_吸盤1CD;

		public ColorD 節23_吸盤2CD;

		public ColorD 節23_吸盤3CD;

		public ColorD 節23_吸盤4CD;

		public ColorD 節24_節CD;

		public ColorD 節24_紋柄1CD;

		public ColorD 節24_紋柄2CD;

		public ColorD 節24_鎧CD;

		public ColorD 節24_吸盤1CD;

		public ColorD 節24_吸盤2CD;

		public ColorD 節24_吸盤3CD;

		public ColorD 節24_吸盤4CD;

		public ColorD 節25_節CD;

		public ColorD 節25_紋柄1CD;

		public ColorD 節25_紋柄2CD;

		public ColorD 節25_鎧CD;

		public ColorD 節25_吸盤1CD;

		public ColorD 節25_吸盤2CD;

		public ColorD 節25_吸盤3CD;

		public ColorD 節25_吸盤4CD;

		public ColorD 節26_節CD;

		public ColorD 節26_紋柄1CD;

		public ColorD 節26_紋柄2CD;

		public ColorD 節26_鎧CD;

		public ColorD 節26_吸盤1CD;

		public ColorD 節26_吸盤2CD;

		public ColorD 節26_吸盤3CD;

		public ColorD 節26_吸盤4CD;

		public ColorD 節27_節CD;

		public ColorD 節27_紋柄1CD;

		public ColorD 節27_紋柄2CD;

		public ColorD 節27_鎧CD;

		public ColorD 節27_吸盤1CD;

		public ColorD 節27_吸盤2CD;

		public ColorD 節27_吸盤3CD;

		public ColorD 節27_吸盤4CD;

		public ColorD 節28_節CD;

		public ColorD 節28_紋柄1CD;

		public ColorD 節28_紋柄2CD;

		public ColorD 節28_鎧CD;

		public ColorD 節28_吸盤1CD;

		public ColorD 節28_吸盤2CD;

		public ColorD 節28_吸盤3CD;

		public ColorD 節28_吸盤4CD;

		public ColorD 節29_節CD;

		public ColorD 節29_紋柄1CD;

		public ColorD 節29_紋柄2CD;

		public ColorD 節29_鎧CD;

		public ColorD 節29_吸盤1CD;

		public ColorD 節29_吸盤2CD;

		public ColorD 節29_吸盤3CD;

		public ColorD 節29_吸盤4CD;

		public ColorD 節30_節CD;

		public ColorD 節30_紋柄1CD;

		public ColorD 節30_紋柄2CD;

		public ColorD 節30_鎧CD;

		public ColorD 節30_吸盤1CD;

		public ColorD 節30_吸盤2CD;

		public ColorD 節30_吸盤3CD;

		public ColorD 節30_吸盤4CD;

		public ColorD 節31_節CD;

		public ColorD 節31_紋柄1CD;

		public ColorD 節31_紋柄2CD;

		public ColorD 節31_鎧CD;

		public ColorD 節31_吸盤1CD;

		public ColorD 節31_吸盤2CD;

		public ColorD 節31_吸盤3CD;

		public ColorD 節31_吸盤4CD;

		public ColorD 節32_節CD;

		public ColorD 節32_紋柄1CD;

		public ColorD 節32_紋柄2CD;

		public ColorD 節32_鎧CD;

		public ColorD 節32_吸盤1CD;

		public ColorD 節32_吸盤2CD;

		public ColorD 節32_吸盤3CD;

		public ColorD 節32_吸盤4CD;

		public ColorD 節33_節CD;

		public ColorD 節33_紋柄1CD;

		public ColorD 節33_紋柄2CD;

		public ColorD 節33_鎧CD;

		public ColorD 節33_吸盤1CD;

		public ColorD 節33_吸盤2CD;

		public ColorD 節33_吸盤3CD;

		public ColorD 節33_吸盤4CD;

		public ColorD 節34_節CD;

		public ColorD 節34_紋柄1CD;

		public ColorD 節34_紋柄2CD;

		public ColorD 節34_鎧CD;

		public ColorD 節34_吸盤1CD;

		public ColorD 節34_吸盤2CD;

		public ColorD 節34_吸盤3CD;

		public ColorD 節34_吸盤4CD;

		public ColorD 節35_節CD;

		public ColorD 節35_紋柄1CD;

		public ColorD 節35_紋柄2CD;

		public ColorD 節35_鎧CD;

		public ColorD 節35_吸盤1CD;

		public ColorD 節35_吸盤2CD;

		public ColorD 節35_吸盤3CD;

		public ColorD 節35_吸盤4CD;

		public ColorD 節36_節CD;

		public ColorD 節36_紋柄1CD;

		public ColorD 節36_紋柄2CD;

		public ColorD 節36_鎧CD;

		public ColorD 節36_吸盤1CD;

		public ColorD 節36_吸盤2CD;

		public ColorD 節36_吸盤3CD;

		public ColorD 節36_吸盤4CD;

		public ColorD 節37_節CD;

		public ColorD 節37_紋柄1CD;

		public ColorD 節37_紋柄2CD;

		public ColorD 節37_鎧CD;

		public ColorD 節37_吸盤1CD;

		public ColorD 節37_吸盤2CD;

		public ColorD 節37_吸盤3CD;

		public ColorD 節37_吸盤4CD;

		public ColorD 節38_節CD;

		public ColorD 節38_紋柄1CD;

		public ColorD 節38_紋柄2CD;

		public ColorD 節38_鎧CD;

		public ColorD 節38_吸盤1CD;

		public ColorD 節38_吸盤2CD;

		public ColorD 節38_吸盤3CD;

		public ColorD 節38_吸盤4CD;

		public ColorD 節39_節CD;

		public ColorD 節39_紋柄1CD;

		public ColorD 節39_紋柄2CD;

		public ColorD 節39_鎧CD;

		public ColorD 節39_吸盤1CD;

		public ColorD 節39_吸盤2CD;

		public ColorD 節39_吸盤3CD;

		public ColorD 節39_吸盤4CD;

		public ColorD 節40_節CD;

		public ColorD 節40_紋柄1CD;

		public ColorD 節40_紋柄2CD;

		public ColorD 節40_鎧CD;

		public ColorD 節40_吸盤1CD;

		public ColorD 節40_吸盤2CD;

		public ColorD 節40_吸盤3CD;

		public ColorD 節40_吸盤4CD;

		public ColorD 節41_節CD;

		public ColorD 節41_紋柄1CD;

		public ColorD 節41_紋柄2CD;

		public ColorD 節41_鎧CD;

		public ColorD 節41_吸盤1CD;

		public ColorD 節41_吸盤2CD;

		public ColorD 節41_吸盤3CD;

		public ColorD 節41_吸盤4CD;

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

		public ColorP X0Y0_節1_節CP;

		public ColorP X0Y0_節1_紋柄1CP;

		public ColorP X0Y0_節1_紋柄2CP;

		public ColorP X0Y0_節1_鎧CP;

		public ColorP X0Y0_節1_吸盤1CP;

		public ColorP X0Y0_節1_吸盤2CP;

		public ColorP X0Y0_節1_吸盤3CP;

		public ColorP X0Y0_節1_吸盤4CP;

		public ColorP X0Y0_節2_節CP;

		public ColorP X0Y0_節2_紋柄1CP;

		public ColorP X0Y0_節2_紋柄2CP;

		public ColorP X0Y0_節2_鎧CP;

		public ColorP X0Y0_節2_吸盤1CP;

		public ColorP X0Y0_節2_吸盤2CP;

		public ColorP X0Y0_節2_吸盤3CP;

		public ColorP X0Y0_節2_吸盤4CP;

		public ColorP X0Y0_節3_節CP;

		public ColorP X0Y0_節3_紋柄1CP;

		public ColorP X0Y0_節3_紋柄2CP;

		public ColorP X0Y0_節3_鎧CP;

		public ColorP X0Y0_節3_吸盤1CP;

		public ColorP X0Y0_節3_吸盤2CP;

		public ColorP X0Y0_節3_吸盤3CP;

		public ColorP X0Y0_節3_吸盤4CP;

		public ColorP X0Y0_節4_節CP;

		public ColorP X0Y0_節4_紋柄1CP;

		public ColorP X0Y0_節4_紋柄2CP;

		public ColorP X0Y0_節4_鎧CP;

		public ColorP X0Y0_節4_吸盤1CP;

		public ColorP X0Y0_節4_吸盤2CP;

		public ColorP X0Y0_節4_吸盤3CP;

		public ColorP X0Y0_節4_吸盤4CP;

		public ColorP X0Y0_節5_節CP;

		public ColorP X0Y0_節5_紋柄1CP;

		public ColorP X0Y0_節5_紋柄2CP;

		public ColorP X0Y0_節5_鎧CP;

		public ColorP X0Y0_節5_吸盤1CP;

		public ColorP X0Y0_節5_吸盤2CP;

		public ColorP X0Y0_節5_吸盤3CP;

		public ColorP X0Y0_節5_吸盤4CP;

		public ColorP X0Y0_節6_節CP;

		public ColorP X0Y0_節6_紋柄1CP;

		public ColorP X0Y0_節6_紋柄2CP;

		public ColorP X0Y0_節6_鎧CP;

		public ColorP X0Y0_節6_吸盤1CP;

		public ColorP X0Y0_節6_吸盤2CP;

		public ColorP X0Y0_節6_吸盤3CP;

		public ColorP X0Y0_節6_吸盤4CP;

		public ColorP X0Y0_節7_節CP;

		public ColorP X0Y0_節7_紋柄1CP;

		public ColorP X0Y0_節7_紋柄2CP;

		public ColorP X0Y0_節7_鎧CP;

		public ColorP X0Y0_節7_吸盤1CP;

		public ColorP X0Y0_節7_吸盤2CP;

		public ColorP X0Y0_節7_吸盤3CP;

		public ColorP X0Y0_節7_吸盤4CP;

		public ColorP X0Y0_節8_節CP;

		public ColorP X0Y0_節8_紋柄1CP;

		public ColorP X0Y0_節8_紋柄2CP;

		public ColorP X0Y0_節8_鎧CP;

		public ColorP X0Y0_節8_吸盤1CP;

		public ColorP X0Y0_節8_吸盤2CP;

		public ColorP X0Y0_節8_吸盤3CP;

		public ColorP X0Y0_節8_吸盤4CP;

		public ColorP X0Y0_輪1_革CP;

		public ColorP X0Y0_輪1_金具1CP;

		public ColorP X0Y0_輪1_金具2CP;

		public ColorP X0Y0_輪1_金具3CP;

		public ColorP X0Y0_輪1_金具左CP;

		public ColorP X0Y0_輪1_金具右CP;

		public ColorP X0Y0_節9_節CP;

		public ColorP X0Y0_節9_紋柄1CP;

		public ColorP X0Y0_節9_紋柄2CP;

		public ColorP X0Y0_節9_鎧CP;

		public ColorP X0Y0_節9_吸盤1CP;

		public ColorP X0Y0_節9_吸盤2CP;

		public ColorP X0Y0_節9_吸盤3CP;

		public ColorP X0Y0_節9_吸盤4CP;

		public ColorP X0Y0_節10_節CP;

		public ColorP X0Y0_節10_紋柄1CP;

		public ColorP X0Y0_節10_紋柄2CP;

		public ColorP X0Y0_節10_鎧CP;

		public ColorP X0Y0_節10_吸盤1CP;

		public ColorP X0Y0_節10_吸盤2CP;

		public ColorP X0Y0_節10_吸盤3CP;

		public ColorP X0Y0_節10_吸盤4CP;

		public ColorP X0Y0_節11_節CP;

		public ColorP X0Y0_節11_紋柄1CP;

		public ColorP X0Y0_節11_紋柄2CP;

		public ColorP X0Y0_節11_鎧CP;

		public ColorP X0Y0_節11_吸盤1CP;

		public ColorP X0Y0_節11_吸盤2CP;

		public ColorP X0Y0_節11_吸盤3CP;

		public ColorP X0Y0_節11_吸盤4CP;

		public ColorP X0Y0_節12_節CP;

		public ColorP X0Y0_節12_紋柄1CP;

		public ColorP X0Y0_節12_紋柄2CP;

		public ColorP X0Y0_節12_鎧CP;

		public ColorP X0Y0_節12_吸盤1CP;

		public ColorP X0Y0_節12_吸盤2CP;

		public ColorP X0Y0_節12_吸盤3CP;

		public ColorP X0Y0_節12_吸盤4CP;

		public ColorP X0Y0_節13_節CP;

		public ColorP X0Y0_節13_紋柄1CP;

		public ColorP X0Y0_節13_紋柄2CP;

		public ColorP X0Y0_節13_鎧CP;

		public ColorP X0Y0_節13_吸盤1CP;

		public ColorP X0Y0_節13_吸盤2CP;

		public ColorP X0Y0_節13_吸盤3CP;

		public ColorP X0Y0_節13_吸盤4CP;

		public ColorP X0Y0_節14_節CP;

		public ColorP X0Y0_節14_紋柄1CP;

		public ColorP X0Y0_節14_紋柄2CP;

		public ColorP X0Y0_節14_鎧CP;

		public ColorP X0Y0_節14_吸盤1CP;

		public ColorP X0Y0_節14_吸盤2CP;

		public ColorP X0Y0_節14_吸盤3CP;

		public ColorP X0Y0_節14_吸盤4CP;

		public ColorP X0Y0_節15_節CP;

		public ColorP X0Y0_節15_紋柄1CP;

		public ColorP X0Y0_節15_紋柄2CP;

		public ColorP X0Y0_節15_鎧CP;

		public ColorP X0Y0_節15_吸盤1CP;

		public ColorP X0Y0_節15_吸盤2CP;

		public ColorP X0Y0_節15_吸盤3CP;

		public ColorP X0Y0_節15_吸盤4CP;

		public ColorP X0Y0_節16_節CP;

		public ColorP X0Y0_節16_紋柄1CP;

		public ColorP X0Y0_節16_紋柄2CP;

		public ColorP X0Y0_節16_鎧CP;

		public ColorP X0Y0_節16_吸盤1CP;

		public ColorP X0Y0_節16_吸盤2CP;

		public ColorP X0Y0_節16_吸盤3CP;

		public ColorP X0Y0_節16_吸盤4CP;

		public ColorP X0Y0_節17_節CP;

		public ColorP X0Y0_節17_紋柄1CP;

		public ColorP X0Y0_節17_紋柄2CP;

		public ColorP X0Y0_節17_鎧CP;

		public ColorP X0Y0_節17_吸盤1CP;

		public ColorP X0Y0_節17_吸盤2CP;

		public ColorP X0Y0_節17_吸盤3CP;

		public ColorP X0Y0_節17_吸盤4CP;

		public ColorP X0Y0_節18_節CP;

		public ColorP X0Y0_節18_紋柄1CP;

		public ColorP X0Y0_節18_紋柄2CP;

		public ColorP X0Y0_節18_鎧CP;

		public ColorP X0Y0_節18_吸盤1CP;

		public ColorP X0Y0_節18_吸盤2CP;

		public ColorP X0Y0_節18_吸盤3CP;

		public ColorP X0Y0_節18_吸盤4CP;

		public ColorP X0Y0_節19_節CP;

		public ColorP X0Y0_節19_紋柄1CP;

		public ColorP X0Y0_節19_紋柄2CP;

		public ColorP X0Y0_節19_鎧CP;

		public ColorP X0Y0_節19_吸盤1CP;

		public ColorP X0Y0_節19_吸盤2CP;

		public ColorP X0Y0_節19_吸盤3CP;

		public ColorP X0Y0_節19_吸盤4CP;

		public ColorP X0Y0_輪2_革CP;

		public ColorP X0Y0_輪2_金具1CP;

		public ColorP X0Y0_輪2_金具2CP;

		public ColorP X0Y0_輪2_金具3CP;

		public ColorP X0Y0_輪2_金具左CP;

		public ColorP X0Y0_輪2_金具右CP;

		public ColorP X0Y0_節20_節CP;

		public ColorP X0Y0_節20_紋柄1CP;

		public ColorP X0Y0_節20_紋柄2CP;

		public ColorP X0Y0_節20_鎧CP;

		public ColorP X0Y0_節20_吸盤1CP;

		public ColorP X0Y0_節20_吸盤2CP;

		public ColorP X0Y0_節20_吸盤3CP;

		public ColorP X0Y0_節20_吸盤4CP;

		public ColorP X0Y0_節21_節CP;

		public ColorP X0Y0_節21_紋柄1CP;

		public ColorP X0Y0_節21_紋柄2CP;

		public ColorP X0Y0_節21_鎧CP;

		public ColorP X0Y0_節21_吸盤1CP;

		public ColorP X0Y0_節21_吸盤2CP;

		public ColorP X0Y0_節21_吸盤3CP;

		public ColorP X0Y0_節21_吸盤4CP;

		public ColorP X0Y0_節22_節CP;

		public ColorP X0Y0_節22_紋柄1CP;

		public ColorP X0Y0_節22_紋柄2CP;

		public ColorP X0Y0_節22_鎧CP;

		public ColorP X0Y0_節22_吸盤1CP;

		public ColorP X0Y0_節22_吸盤2CP;

		public ColorP X0Y0_節22_吸盤3CP;

		public ColorP X0Y0_節22_吸盤4CP;

		public ColorP X0Y0_節23_節CP;

		public ColorP X0Y0_節23_紋柄1CP;

		public ColorP X0Y0_節23_紋柄2CP;

		public ColorP X0Y0_節23_鎧CP;

		public ColorP X0Y0_節23_吸盤1CP;

		public ColorP X0Y0_節23_吸盤2CP;

		public ColorP X0Y0_節23_吸盤3CP;

		public ColorP X0Y0_節23_吸盤4CP;

		public ColorP X0Y0_節24_節CP;

		public ColorP X0Y0_節24_紋柄1CP;

		public ColorP X0Y0_節24_紋柄2CP;

		public ColorP X0Y0_節24_鎧CP;

		public ColorP X0Y0_節24_吸盤1CP;

		public ColorP X0Y0_節24_吸盤2CP;

		public ColorP X0Y0_節24_吸盤3CP;

		public ColorP X0Y0_節24_吸盤4CP;

		public ColorP X0Y0_節25_節CP;

		public ColorP X0Y0_節25_紋柄1CP;

		public ColorP X0Y0_節25_紋柄2CP;

		public ColorP X0Y0_節25_鎧CP;

		public ColorP X0Y0_節25_吸盤1CP;

		public ColorP X0Y0_節25_吸盤2CP;

		public ColorP X0Y0_節25_吸盤3CP;

		public ColorP X0Y0_節25_吸盤4CP;

		public ColorP X0Y0_節26_節CP;

		public ColorP X0Y0_節26_紋柄1CP;

		public ColorP X0Y0_節26_紋柄2CP;

		public ColorP X0Y0_節26_鎧CP;

		public ColorP X0Y0_節26_吸盤1CP;

		public ColorP X0Y0_節26_吸盤2CP;

		public ColorP X0Y0_節26_吸盤3CP;

		public ColorP X0Y0_節26_吸盤4CP;

		public ColorP X0Y0_節27_節CP;

		public ColorP X0Y0_節27_紋柄1CP;

		public ColorP X0Y0_節27_紋柄2CP;

		public ColorP X0Y0_節27_鎧CP;

		public ColorP X0Y0_節27_吸盤1CP;

		public ColorP X0Y0_節27_吸盤2CP;

		public ColorP X0Y0_節27_吸盤3CP;

		public ColorP X0Y0_節27_吸盤4CP;

		public ColorP X0Y0_節28_節CP;

		public ColorP X0Y0_節28_紋柄1CP;

		public ColorP X0Y0_節28_紋柄2CP;

		public ColorP X0Y0_節28_鎧CP;

		public ColorP X0Y0_節28_吸盤1CP;

		public ColorP X0Y0_節28_吸盤2CP;

		public ColorP X0Y0_節28_吸盤3CP;

		public ColorP X0Y0_節28_吸盤4CP;

		public ColorP X0Y0_節29_節CP;

		public ColorP X0Y0_節29_紋柄1CP;

		public ColorP X0Y0_節29_紋柄2CP;

		public ColorP X0Y0_節29_鎧CP;

		public ColorP X0Y0_節29_吸盤1CP;

		public ColorP X0Y0_節29_吸盤2CP;

		public ColorP X0Y0_節29_吸盤3CP;

		public ColorP X0Y0_節29_吸盤4CP;

		public ColorP X0Y0_節30_節CP;

		public ColorP X0Y0_節30_紋柄1CP;

		public ColorP X0Y0_節30_紋柄2CP;

		public ColorP X0Y0_節30_鎧CP;

		public ColorP X0Y0_節30_吸盤1CP;

		public ColorP X0Y0_節30_吸盤2CP;

		public ColorP X0Y0_節30_吸盤3CP;

		public ColorP X0Y0_節30_吸盤4CP;

		public ColorP X0Y0_節31_節CP;

		public ColorP X0Y0_節31_紋柄1CP;

		public ColorP X0Y0_節31_紋柄2CP;

		public ColorP X0Y0_節31_鎧CP;

		public ColorP X0Y0_節31_吸盤1CP;

		public ColorP X0Y0_節31_吸盤2CP;

		public ColorP X0Y0_節31_吸盤3CP;

		public ColorP X0Y0_節31_吸盤4CP;

		public ColorP X0Y0_節32_節CP;

		public ColorP X0Y0_節32_紋柄1CP;

		public ColorP X0Y0_節32_紋柄2CP;

		public ColorP X0Y0_節32_鎧CP;

		public ColorP X0Y0_節32_吸盤1CP;

		public ColorP X0Y0_節32_吸盤2CP;

		public ColorP X0Y0_節32_吸盤3CP;

		public ColorP X0Y0_節32_吸盤4CP;

		public ColorP X0Y0_節33_節CP;

		public ColorP X0Y0_節33_紋柄1CP;

		public ColorP X0Y0_節33_紋柄2CP;

		public ColorP X0Y0_節33_鎧CP;

		public ColorP X0Y0_節33_吸盤1CP;

		public ColorP X0Y0_節33_吸盤2CP;

		public ColorP X0Y0_節33_吸盤3CP;

		public ColorP X0Y0_節33_吸盤4CP;

		public ColorP X0Y0_節34_節CP;

		public ColorP X0Y0_節34_紋柄1CP;

		public ColorP X0Y0_節34_紋柄2CP;

		public ColorP X0Y0_節34_鎧CP;

		public ColorP X0Y0_節34_吸盤1CP;

		public ColorP X0Y0_節34_吸盤2CP;

		public ColorP X0Y0_節34_吸盤3CP;

		public ColorP X0Y0_節34_吸盤4CP;

		public ColorP X0Y0_節35_節CP;

		public ColorP X0Y0_節35_紋柄1CP;

		public ColorP X0Y0_節35_紋柄2CP;

		public ColorP X0Y0_節35_鎧CP;

		public ColorP X0Y0_節35_吸盤1CP;

		public ColorP X0Y0_節35_吸盤2CP;

		public ColorP X0Y0_節35_吸盤3CP;

		public ColorP X0Y0_節35_吸盤4CP;

		public ColorP X0Y0_節36_節CP;

		public ColorP X0Y0_節36_紋柄1CP;

		public ColorP X0Y0_節36_紋柄2CP;

		public ColorP X0Y0_節36_鎧CP;

		public ColorP X0Y0_節36_吸盤1CP;

		public ColorP X0Y0_節36_吸盤2CP;

		public ColorP X0Y0_節36_吸盤3CP;

		public ColorP X0Y0_節36_吸盤4CP;

		public ColorP X0Y0_節37_節CP;

		public ColorP X0Y0_節37_紋柄1CP;

		public ColorP X0Y0_節37_紋柄2CP;

		public ColorP X0Y0_節37_鎧CP;

		public ColorP X0Y0_節37_吸盤1CP;

		public ColorP X0Y0_節37_吸盤2CP;

		public ColorP X0Y0_節37_吸盤3CP;

		public ColorP X0Y0_節37_吸盤4CP;

		public ColorP X0Y0_節38_節CP;

		public ColorP X0Y0_節38_紋柄1CP;

		public ColorP X0Y0_節38_紋柄2CP;

		public ColorP X0Y0_節38_鎧CP;

		public ColorP X0Y0_節38_吸盤1CP;

		public ColorP X0Y0_節38_吸盤2CP;

		public ColorP X0Y0_節38_吸盤3CP;

		public ColorP X0Y0_節38_吸盤4CP;

		public ColorP X0Y0_節39_節CP;

		public ColorP X0Y0_節39_紋柄1CP;

		public ColorP X0Y0_節39_紋柄2CP;

		public ColorP X0Y0_節39_鎧CP;

		public ColorP X0Y0_節39_吸盤1CP;

		public ColorP X0Y0_節39_吸盤2CP;

		public ColorP X0Y0_節39_吸盤3CP;

		public ColorP X0Y0_節39_吸盤4CP;

		public ColorP X0Y0_節40_節CP;

		public ColorP X0Y0_節40_紋柄1CP;

		public ColorP X0Y0_節40_紋柄2CP;

		public ColorP X0Y0_節40_鎧CP;

		public ColorP X0Y0_節40_吸盤1CP;

		public ColorP X0Y0_節40_吸盤2CP;

		public ColorP X0Y0_節40_吸盤3CP;

		public ColorP X0Y0_節40_吸盤4CP;

		public ColorP X0Y0_節41_節CP;

		public ColorP X0Y0_節41_紋柄1CP;

		public ColorP X0Y0_節41_紋柄2CP;

		public ColorP X0Y0_節41_鎧CP;

		public ColorP X0Y0_節41_吸盤1CP;

		public ColorP X0Y0_節41_吸盤2CP;

		public ColorP X0Y0_節41_吸盤3CP;

		public ColorP X0Y0_節41_吸盤4CP;

		public 拘束鎖 鎖1;

		public 拘束鎖 鎖2;

		public 拘束鎖 鎖3;

		public 拘束鎖 鎖4;

		public Par[] Pars;

		private Vector2D[] mm;
	}
}
