using System;
using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 触手_犬 : 触手
	{
		public 触手_犬(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 触手_犬D e)
		{
			触手_犬.<>c__DisplayClass837_0 CS$<>8__locals1 = new 触手_犬.<>c__DisplayClass837_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "スキュラ";
			dif.Add(new Pars(Sta.肢左["触手"][0][2]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["脚後"].ToPars();
			Pars pars3 = pars2["鰭"].ToPars();
			this.X0Y0_脚後_鰭_鰭膜1 = pars3["鰭膜1"].ToPar();
			this.X0Y0_脚後_鰭_鰭条1 = pars3["鰭条1"].ToPar();
			this.X0Y0_脚後_鰭_鰭膜2 = pars3["鰭膜2"].ToPar();
			this.X0Y0_脚後_鰭_鰭条2 = pars3["鰭条2"].ToPar();
			this.X0Y0_脚後_鰭_鰭膜3 = pars3["鰭膜3"].ToPar();
			this.X0Y0_脚後_上腕 = pars2["上腕"].ToPar();
			this.X0Y0_脚後_下腕 = pars2["下腕"].ToPar();
			pars3 = pars2["手"].ToPars();
			this.X0Y0_脚後_手_手 = pars3["手"].ToPar();
			Pars pars4 = pars3["小指"].ToPars();
			this.X0Y0_脚後_手_小指_指 = pars4["指"].ToPar();
			this.X0Y0_脚後_手_小指_爪 = pars4["爪"].ToPar();
			Pars pars5 = pars4["鱗"].ToPars();
			this.X0Y0_脚後_手_小指_鱗_鱗4 = pars5["鱗4"].ToPar();
			this.X0Y0_脚後_手_小指_鱗_鱗3 = pars5["鱗3"].ToPar();
			this.X0Y0_脚後_手_小指_鱗_鱗2 = pars5["鱗2"].ToPar();
			this.X0Y0_脚後_手_小指_鱗_鱗1 = pars5["鱗1"].ToPar();
			this.X0Y0_脚後_手_小指_水掻 = pars4["水掻"].ToPar();
			pars4 = pars3["薬指"].ToPars();
			this.X0Y0_脚後_手_薬指_指 = pars4["指"].ToPar();
			this.X0Y0_脚後_手_薬指_爪 = pars4["爪"].ToPar();
			pars5 = pars4["鱗"].ToPars();
			this.X0Y0_脚後_手_薬指_水掻 = pars4["水掻"].ToPar();
			this.X0Y0_脚後_手_薬指_鱗_鱗4 = pars5["鱗4"].ToPar();
			this.X0Y0_脚後_手_薬指_鱗_鱗3 = pars5["鱗3"].ToPar();
			this.X0Y0_脚後_手_薬指_鱗_鱗2 = pars5["鱗2"].ToPar();
			this.X0Y0_脚後_手_薬指_鱗_鱗1 = pars5["鱗1"].ToPar();
			pars4 = pars3["中指"].ToPars();
			this.X0Y0_脚後_手_中指_指 = pars4["指"].ToPar();
			this.X0Y0_脚後_手_中指_爪 = pars4["爪"].ToPar();
			pars5 = pars4["鱗"].ToPars();
			this.X0Y0_脚後_手_中指_水掻 = pars4["水掻"].ToPar();
			this.X0Y0_脚後_手_中指_鱗_鱗4 = pars5["鱗4"].ToPar();
			this.X0Y0_脚後_手_中指_鱗_鱗3 = pars5["鱗3"].ToPar();
			this.X0Y0_脚後_手_中指_鱗_鱗2 = pars5["鱗2"].ToPar();
			this.X0Y0_脚後_手_中指_鱗_鱗1 = pars5["鱗1"].ToPar();
			pars4 = pars3["人指"].ToPars();
			this.X0Y0_脚後_手_人指_指 = pars4["指"].ToPar();
			this.X0Y0_脚後_手_人指_爪 = pars4["爪"].ToPar();
			pars5 = pars4["鱗"].ToPars();
			this.X0Y0_脚後_手_人指_鱗_鱗4 = pars5["鱗4"].ToPar();
			this.X0Y0_脚後_手_人指_鱗_鱗3 = pars5["鱗3"].ToPar();
			this.X0Y0_脚後_手_人指_鱗_鱗2 = pars5["鱗2"].ToPar();
			this.X0Y0_脚後_手_人指_鱗_鱗1 = pars5["鱗1"].ToPar();
			pars4 = pars3["鱗"].ToPars();
			this.X0Y0_脚後_手_鱗_鱗3 = pars4["鱗3"].ToPar();
			this.X0Y0_脚後_手_鱗_鱗2 = pars4["鱗2"].ToPar();
			this.X0Y0_脚後_手_鱗_鱗1 = pars4["鱗1"].ToPar();
			pars4 = pars3["親指"].ToPars();
			this.X0Y0_脚後_手_親指_爪 = pars4["爪"].ToPar();
			pars3 = pars2["下腕鱗"].ToPars();
			pars4 = pars3["鱗小"].ToPars();
			this.X0Y0_脚後_下腕鱗_鱗小_鱗9 = pars4["鱗9"].ToPar();
			this.X0Y0_脚後_下腕鱗_鱗小_鱗8 = pars4["鱗8"].ToPar();
			this.X0Y0_脚後_下腕鱗_鱗小_鱗7 = pars4["鱗7"].ToPar();
			this.X0Y0_脚後_下腕鱗_鱗小_鱗6 = pars4["鱗6"].ToPar();
			this.X0Y0_脚後_下腕鱗_鱗小_鱗5 = pars4["鱗5"].ToPar();
			this.X0Y0_脚後_下腕鱗_鱗小_鱗4 = pars4["鱗4"].ToPar();
			this.X0Y0_脚後_下腕鱗_鱗小_鱗3 = pars4["鱗3"].ToPar();
			this.X0Y0_脚後_下腕鱗_鱗小_鱗2 = pars4["鱗2"].ToPar();
			this.X0Y0_脚後_下腕鱗_鱗小_鱗1 = pars4["鱗1"].ToPar();
			pars4 = pars3["鱗大"].ToPars();
			this.X0Y0_脚後_下腕鱗_鱗大_鱗9 = pars4["鱗9"].ToPar();
			this.X0Y0_脚後_下腕鱗_鱗大_鱗8 = pars4["鱗8"].ToPar();
			this.X0Y0_脚後_下腕鱗_鱗大_鱗7 = pars4["鱗7"].ToPar();
			this.X0Y0_脚後_下腕鱗_鱗大_鱗6 = pars4["鱗6"].ToPar();
			this.X0Y0_脚後_下腕鱗_鱗大_鱗5 = pars4["鱗5"].ToPar();
			this.X0Y0_脚後_下腕鱗_鱗大_鱗4 = pars4["鱗4"].ToPar();
			this.X0Y0_脚後_下腕鱗_鱗大_鱗3 = pars4["鱗3"].ToPar();
			this.X0Y0_脚後_下腕鱗_鱗大_鱗2 = pars4["鱗2"].ToPar();
			this.X0Y0_脚後_下腕鱗_鱗大_鱗1 = pars4["鱗1"].ToPar();
			pars3 = pars2["上腕鱗"].ToPars();
			this.X0Y0_脚後_上腕鱗_鱗5 = pars3["鱗5"].ToPar();
			this.X0Y0_脚後_上腕鱗_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_脚後_上腕鱗_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_脚後_上腕鱗_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_脚後_上腕鱗_鱗1 = pars3["鱗1"].ToPar();
			pars3 = pars2["輪"].ToPars();
			this.X0Y0_脚後_輪_革 = pars3["革"].ToPar();
			this.X0Y0_脚後_輪_金具1 = pars3["金具1"].ToPar();
			this.X0Y0_脚後_輪_金具2 = pars3["金具2"].ToPar();
			this.X0Y0_脚後_輪_金具3 = pars3["金具3"].ToPar();
			this.X0Y0_脚後_輪_金具左 = pars3["金具左"].ToPar();
			this.X0Y0_脚後_輪_金具右 = pars3["金具右"].ToPar();
			pars2 = pars["上顎頭部後"].ToPars();
			this.X0Y0_上顎頭部後_頭2 = pars2["頭2"].ToPar();
			this.X0Y0_上顎頭部後_頭1 = pars2["頭1"].ToPar();
			pars2 = pars["下顎頭部後"].ToPars();
			this.X0Y0_下顎頭部後_頭2 = pars2["頭2"].ToPar();
			this.X0Y0_下顎頭部後_頭1 = pars2["頭1"].ToPar();
			pars2 = pars["胴"].ToPars();
			pars3 = pars2["節1"].ToPars();
			this.X0Y0_胴_節1_胴 = pars3["胴"].ToPar();
			this.X0Y0_胴_節1_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_胴_節1_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_胴_節1_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["節2"].ToPars();
			this.X0Y0_胴_節2_胴 = pars3["胴"].ToPar();
			this.X0Y0_胴_節2_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_胴_節2_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_胴_節2_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["節3"].ToPars();
			this.X0Y0_胴_節3_胴 = pars3["胴"].ToPar();
			this.X0Y0_胴_節3_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_胴_節3_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_胴_節3_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["節4"].ToPars();
			this.X0Y0_胴_節4_胴 = pars3["胴"].ToPar();
			this.X0Y0_胴_節4_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_胴_節4_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_胴_節4_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["節5"].ToPars();
			this.X0Y0_胴_節5_胴 = pars3["胴"].ToPar();
			this.X0Y0_胴_節5_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_胴_節5_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_胴_節5_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["節6"].ToPars();
			this.X0Y0_胴_節6_胴 = pars3["胴"].ToPar();
			this.X0Y0_胴_節6_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_胴_節6_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_胴_節6_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["節7"].ToPars();
			this.X0Y0_胴_節7_胴 = pars3["胴"].ToPar();
			this.X0Y0_胴_節7_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_胴_節7_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_胴_節7_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["節8"].ToPars();
			this.X0Y0_胴_節8_胴 = pars3["胴"].ToPar();
			this.X0Y0_胴_節8_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_胴_節8_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_胴_節8_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["節9"].ToPars();
			this.X0Y0_胴_節9_胴 = pars3["胴"].ToPar();
			this.X0Y0_胴_節9_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_胴_節9_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_胴_節9_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["節10"].ToPars();
			this.X0Y0_胴_節10_胴 = pars3["胴"].ToPar();
			this.X0Y0_胴_節10_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_胴_節10_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_胴_節10_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["節11"].ToPars();
			this.X0Y0_胴_節11_胴 = pars3["胴"].ToPar();
			this.X0Y0_胴_節11_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_胴_節11_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_胴_節11_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["節12"].ToPars();
			this.X0Y0_胴_節12_胴 = pars3["胴"].ToPar();
			this.X0Y0_胴_節12_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_胴_節12_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_胴_節12_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["節13"].ToPars();
			this.X0Y0_胴_節13_胴 = pars3["胴"].ToPar();
			this.X0Y0_胴_節13_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_胴_節13_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_胴_節13_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["節14"].ToPars();
			this.X0Y0_胴_節14_胴 = pars3["胴"].ToPar();
			this.X0Y0_胴_節14_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_胴_節14_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_胴_節14_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["節15"].ToPars();
			this.X0Y0_胴_節15_胴 = pars3["胴"].ToPar();
			this.X0Y0_胴_節15_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_胴_節15_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_胴_節15_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["節16"].ToPars();
			this.X0Y0_胴_節16_胴 = pars3["胴"].ToPar();
			this.X0Y0_胴_節16_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_胴_節16_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_胴_節16_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["輪"].ToPars();
			this.X0Y0_胴_輪_革 = pars3["革"].ToPar();
			this.X0Y0_胴_輪_金具1 = pars3["金具1"].ToPar();
			this.X0Y0_胴_輪_金具2 = pars3["金具2"].ToPar();
			this.X0Y0_胴_輪_金具3 = pars3["金具3"].ToPar();
			this.X0Y0_胴_輪_金具左 = pars3["金具左"].ToPar();
			this.X0Y0_胴_輪_金具右 = pars3["金具右"].ToPar();
			pars3 = pars2["節17"].ToPars();
			this.X0Y0_胴_節17_胴 = pars3["胴"].ToPar();
			this.X0Y0_胴_節17_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_胴_節17_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_胴_節17_鱗2 = pars3["鱗2"].ToPar();
			pars3 = pars2["節18"].ToPars();
			this.X0Y0_胴_節18_胴 = pars3["胴"].ToPar();
			this.X0Y0_胴_節18_鱗1 = pars3["鱗1"].ToPar();
			this.X0Y0_胴_節18_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_胴_節18_鱗2 = pars3["鱗2"].ToPar();
			pars2 = pars["頭"].ToPars();
			pars3 = pars2["口膜"].ToPars();
			this.X0Y0_頭_口膜_口膜1 = pars3["口膜1"].ToPar();
			this.X0Y0_頭_口膜_口膜2 = pars3["口膜2"].ToPar();
			this.X0Y0_頭_口膜_口膜3 = pars3["口膜3"].ToPar();
			this.X0Y0_頭_口膜_口膜4 = pars3["口膜4"].ToPar();
			this.X0Y0_頭_口膜_口膜5 = pars3["口膜5"].ToPar();
			this.X0Y0_頭_口膜_口膜6 = pars3["口膜6"].ToPar();
			this.X0Y0_頭_口膜_口膜7 = pars3["口膜7"].ToPar();
			this.X0Y0_頭_口膜_口膜8 = pars3["口膜8"].ToPar();
			pars3 = pars2["上顎歯後"].ToPars();
			this.X0Y0_頭_上顎歯後_歯1 = pars3["歯1"].ToPar();
			this.X0Y0_頭_上顎歯後_歯2 = pars3["歯2"].ToPar();
			this.X0Y0_頭_上顎歯後_歯3 = pars3["歯3"].ToPar();
			pars3 = pars2["下顎"].ToPars();
			pars4 = pars3["歯"].ToPars();
			pars5 = pars4["後"].ToPars();
			this.X0Y0_頭_下顎_歯_後_歯1 = pars5["歯1"].ToPar();
			this.X0Y0_頭_下顎_歯_後_歯2 = pars5["歯2"].ToPar();
			this.X0Y0_頭_下顎_歯_後_歯3 = pars5["歯3"].ToPar();
			pars5 = pars4["前"].ToPars();
			this.X0Y0_頭_下顎_歯_前_歯1 = pars5["歯1"].ToPar();
			this.X0Y0_頭_下顎_歯_前_歯2 = pars5["歯2"].ToPar();
			this.X0Y0_頭_下顎_歯_前_歯3 = pars5["歯3"].ToPar();
			this.X0Y0_頭_下顎_眼孔1 = pars3["眼孔1"].ToPar();
			this.X0Y0_頭_下顎_眼孔2 = pars3["眼孔2"].ToPar();
			pars4 = pars3["眼"].ToPars();
			pars5 = pars4["眼1"].ToPars();
			this.X0Y0_頭_下顎_眼_眼1_眼2 = pars5["眼2"].ToPar();
			this.X0Y0_頭_下顎_眼_眼1_眼1 = pars5["眼1"].ToPar();
			pars5 = pars4["眼2"].ToPars();
			this.X0Y0_頭_下顎_眼_眼2_眼2 = pars5["眼2"].ToPar();
			this.X0Y0_頭_下顎_眼_眼2_眼1 = pars5["眼1"].ToPar();
			pars4 = pars3["眼下"].ToPars();
			this.X0Y0_頭_下顎_眼下_眼下 = pars4["眼下"].ToPar();
			this.X0Y0_頭_下顎_眼下_線 = pars4["線"].ToPar();
			pars4 = pars3["頭部"].ToPars();
			pars5 = pars4["前"].ToPars();
			this.X0Y0_頭_下顎_頭部_前_頭9 = pars5["頭9"].ToPar();
			this.X0Y0_頭_下顎_頭部_前_頭8 = pars5["頭8"].ToPar();
			this.X0Y0_頭_下顎_頭部_前_頭7 = pars5["頭7"].ToPar();
			this.X0Y0_頭_下顎_頭部_前_頭6 = pars5["頭6"].ToPar();
			this.X0Y0_頭_下顎_頭部_前_頭5 = pars5["頭5"].ToPar();
			this.X0Y0_頭_下顎_頭部_前_頭4 = pars5["頭4"].ToPar();
			this.X0Y0_頭_下顎_頭部_前_頭3 = pars5["頭3"].ToPar();
			this.X0Y0_頭_下顎_頭部_前_頭2 = pars5["頭2"].ToPar();
			this.X0Y0_頭_下顎_頭部_前_頭1 = pars5["頭1"].ToPar();
			pars3 = pars2["上顎"].ToPars();
			pars4 = pars3["歯"].ToPars();
			pars5 = pars4["前"].ToPars();
			this.X0Y0_頭_上顎_歯_前_歯1 = pars5["歯1"].ToPar();
			this.X0Y0_頭_上顎_歯_前_歯2 = pars5["歯2"].ToPar();
			this.X0Y0_頭_上顎_歯_前_歯3 = pars5["歯3"].ToPar();
			this.X0Y0_頭_上顎_眼孔1 = pars3["眼孔1"].ToPar();
			this.X0Y0_頭_上顎_眼孔2 = pars3["眼孔2"].ToPar();
			pars4 = pars3["眼"].ToPars();
			pars5 = pars4["眼1"].ToPars();
			this.X0Y0_頭_上顎_眼_眼1_眼2 = pars5["眼2"].ToPar();
			this.X0Y0_頭_上顎_眼_眼1_眼1 = pars5["眼1"].ToPar();
			pars5 = pars4["眼2"].ToPars();
			this.X0Y0_頭_上顎_眼_眼2_眼2 = pars5["眼2"].ToPar();
			this.X0Y0_頭_上顎_眼_眼2_眼1 = pars5["眼1"].ToPar();
			pars4 = pars3["眼下"].ToPars();
			this.X0Y0_頭_上顎_眼下_眼下 = pars4["眼下"].ToPar();
			this.X0Y0_頭_上顎_眼下_線 = pars4["線"].ToPar();
			pars4 = pars3["頭部"].ToPars();
			pars5 = pars4["前"].ToPars();
			this.X0Y0_頭_上顎_頭部_前_頭9 = pars5["頭9"].ToPar();
			this.X0Y0_頭_上顎_頭部_前_頭8 = pars5["頭8"].ToPar();
			this.X0Y0_頭_上顎_頭部_前_頭7 = pars5["頭7"].ToPar();
			this.X0Y0_頭_上顎_頭部_前_頭6 = pars5["頭6"].ToPar();
			this.X0Y0_頭_上顎_頭部_前_頭5 = pars5["頭5"].ToPar();
			this.X0Y0_頭_上顎_頭部_前_頭4 = pars5["頭4"].ToPar();
			this.X0Y0_頭_上顎_頭部_前_頭3 = pars5["頭3"].ToPar();
			this.X0Y0_頭_上顎_頭部_前_頭2 = pars5["頭2"].ToPar();
			this.X0Y0_頭_上顎_頭部_前_頭1 = pars5["頭1"].ToPar();
			pars3 = pars2["輪"].ToPars();
			this.X0Y0_頭_輪_革 = pars3["革"].ToPar();
			this.X0Y0_頭_輪_金具1 = pars3["金具1"].ToPar();
			this.X0Y0_頭_輪_金具2 = pars3["金具2"].ToPar();
			this.X0Y0_頭_輪_金具3 = pars3["金具3"].ToPar();
			this.X0Y0_頭_輪_金具左 = pars3["金具左"].ToPar();
			this.X0Y0_頭_輪_金具右 = pars3["金具右"].ToPar();
			pars2 = pars["脚前"].ToPars();
			this.X0Y0_脚前_上腕 = pars2["上腕"].ToPar();
			this.X0Y0_脚前_下腕 = pars2["下腕"].ToPar();
			pars3 = pars2["手"].ToPars();
			pars4 = pars3["親指"].ToPars();
			this.X0Y0_脚前_手_親指_爪 = pars4["爪"].ToPar();
			this.X0Y0_脚前_手_手 = pars3["手"].ToPar();
			pars4 = pars3["人指"].ToPars();
			this.X0Y0_脚前_手_人指_指 = pars4["指"].ToPar();
			this.X0Y0_脚前_手_人指_爪 = pars4["爪"].ToPar();
			pars5 = pars4["鱗"].ToPars();
			this.X0Y0_脚前_手_人指_水掻 = pars4["水掻"].ToPar();
			pars5 = pars4["鱗"].ToPars();
			this.X0Y0_脚前_手_人指_鱗_鱗4 = pars5["鱗4"].ToPar();
			this.X0Y0_脚前_手_人指_鱗_鱗3 = pars5["鱗3"].ToPar();
			this.X0Y0_脚前_手_人指_鱗_鱗2 = pars5["鱗2"].ToPar();
			this.X0Y0_脚前_手_人指_鱗_鱗1 = pars5["鱗1"].ToPar();
			pars4 = pars3["中指"].ToPars();
			this.X0Y0_脚前_手_中指_指 = pars4["指"].ToPar();
			this.X0Y0_脚前_手_中指_爪 = pars4["爪"].ToPar();
			pars5 = pars4["鱗"].ToPars();
			this.X0Y0_脚前_手_中指_水掻 = pars4["水掻"].ToPar();
			this.X0Y0_脚前_手_中指_鱗_鱗4 = pars5["鱗4"].ToPar();
			this.X0Y0_脚前_手_中指_鱗_鱗3 = pars5["鱗3"].ToPar();
			this.X0Y0_脚前_手_中指_鱗_鱗2 = pars5["鱗2"].ToPar();
			this.X0Y0_脚前_手_中指_鱗_鱗1 = pars5["鱗1"].ToPar();
			pars4 = pars3["薬指"].ToPars();
			this.X0Y0_脚前_手_薬指_指 = pars4["指"].ToPar();
			this.X0Y0_脚前_手_薬指_爪 = pars4["爪"].ToPar();
			pars5 = pars4["鱗"].ToPars();
			this.X0Y0_脚前_手_薬指_水掻 = pars4["水掻"].ToPar();
			this.X0Y0_脚前_手_薬指_鱗_鱗4 = pars5["鱗4"].ToPar();
			this.X0Y0_脚前_手_薬指_鱗_鱗3 = pars5["鱗3"].ToPar();
			this.X0Y0_脚前_手_薬指_鱗_鱗2 = pars5["鱗2"].ToPar();
			this.X0Y0_脚前_手_薬指_鱗_鱗1 = pars5["鱗1"].ToPar();
			pars4 = pars3["小指"].ToPars();
			this.X0Y0_脚前_手_小指_指 = pars4["指"].ToPar();
			this.X0Y0_脚前_手_小指_爪 = pars4["爪"].ToPar();
			pars5 = pars4["鱗"].ToPars();
			this.X0Y0_脚前_手_小指_鱗_鱗4 = pars5["鱗4"].ToPar();
			this.X0Y0_脚前_手_小指_鱗_鱗3 = pars5["鱗3"].ToPar();
			this.X0Y0_脚前_手_小指_鱗_鱗2 = pars5["鱗2"].ToPar();
			this.X0Y0_脚前_手_小指_鱗_鱗1 = pars5["鱗1"].ToPar();
			pars4 = pars3["鱗"].ToPars();
			this.X0Y0_脚前_手_鱗_鱗3 = pars4["鱗3"].ToPar();
			this.X0Y0_脚前_手_鱗_鱗2 = pars4["鱗2"].ToPar();
			this.X0Y0_脚前_手_鱗_鱗1 = pars4["鱗1"].ToPar();
			pars3 = pars2["下腕鱗"].ToPars();
			pars4 = pars3["鱗小"].ToPars();
			this.X0Y0_脚前_下腕鱗_鱗小_鱗9 = pars4["鱗9"].ToPar();
			this.X0Y0_脚前_下腕鱗_鱗小_鱗8 = pars4["鱗8"].ToPar();
			this.X0Y0_脚前_下腕鱗_鱗小_鱗7 = pars4["鱗7"].ToPar();
			this.X0Y0_脚前_下腕鱗_鱗小_鱗6 = pars4["鱗6"].ToPar();
			this.X0Y0_脚前_下腕鱗_鱗小_鱗5 = pars4["鱗5"].ToPar();
			this.X0Y0_脚前_下腕鱗_鱗小_鱗4 = pars4["鱗4"].ToPar();
			this.X0Y0_脚前_下腕鱗_鱗小_鱗3 = pars4["鱗3"].ToPar();
			this.X0Y0_脚前_下腕鱗_鱗小_鱗2 = pars4["鱗2"].ToPar();
			this.X0Y0_脚前_下腕鱗_鱗小_鱗1 = pars4["鱗1"].ToPar();
			pars4 = pars3["鱗大"].ToPars();
			this.X0Y0_脚前_下腕鱗_鱗大_鱗9 = pars4["鱗9"].ToPar();
			this.X0Y0_脚前_下腕鱗_鱗大_鱗8 = pars4["鱗8"].ToPar();
			this.X0Y0_脚前_下腕鱗_鱗大_鱗7 = pars4["鱗7"].ToPar();
			this.X0Y0_脚前_下腕鱗_鱗大_鱗6 = pars4["鱗6"].ToPar();
			this.X0Y0_脚前_下腕鱗_鱗大_鱗5 = pars4["鱗5"].ToPar();
			this.X0Y0_脚前_下腕鱗_鱗大_鱗4 = pars4["鱗4"].ToPar();
			this.X0Y0_脚前_下腕鱗_鱗大_鱗3 = pars4["鱗3"].ToPar();
			this.X0Y0_脚前_下腕鱗_鱗大_鱗2 = pars4["鱗2"].ToPar();
			this.X0Y0_脚前_下腕鱗_鱗大_鱗1 = pars4["鱗1"].ToPar();
			pars3 = pars2["上腕鱗"].ToPars();
			this.X0Y0_脚前_上腕鱗_鱗5 = pars3["鱗5"].ToPar();
			this.X0Y0_脚前_上腕鱗_鱗4 = pars3["鱗4"].ToPar();
			this.X0Y0_脚前_上腕鱗_鱗3 = pars3["鱗3"].ToPar();
			this.X0Y0_脚前_上腕鱗_鱗2 = pars3["鱗2"].ToPar();
			this.X0Y0_脚前_上腕鱗_鱗1 = pars3["鱗1"].ToPar();
			pars3 = pars2["鰭"].ToPars();
			this.X0Y0_脚前_鰭_鰭膜1 = pars3["鰭膜1"].ToPar();
			this.X0Y0_脚前_鰭_鰭条1 = pars3["鰭条1"].ToPar();
			this.X0Y0_脚前_鰭_鰭膜2 = pars3["鰭膜2"].ToPar();
			this.X0Y0_脚前_鰭_鰭条2 = pars3["鰭条2"].ToPar();
			this.X0Y0_脚前_鰭_鰭膜3 = pars3["鰭膜3"].ToPar();
			pars3 = pars2["輪"].ToPars();
			this.X0Y0_脚前_輪_革 = pars3["革"].ToPar();
			this.X0Y0_脚前_輪_金具1 = pars3["金具1"].ToPar();
			this.X0Y0_脚前_輪_金具2 = pars3["金具2"].ToPar();
			this.X0Y0_脚前_輪_金具3 = pars3["金具3"].ToPar();
			this.X0Y0_脚前_輪_金具左 = pars3["金具左"].ToPar();
			this.X0Y0_脚前_輪_金具右 = pars3["金具右"].ToPar();
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
			this.脚後_鰭_鰭膜1_表示 = e.脚後_鰭_鰭膜1_表示;
			this.脚後_鰭_鰭条1_表示 = e.脚後_鰭_鰭条1_表示;
			this.脚後_鰭_鰭膜2_表示 = e.脚後_鰭_鰭膜2_表示;
			this.脚後_鰭_鰭条2_表示 = e.脚後_鰭_鰭条2_表示;
			this.脚後_鰭_鰭膜3_表示 = e.脚後_鰭_鰭膜3_表示;
			this.脚後_上腕_表示 = e.脚後_上腕_表示;
			this.脚後_下腕_表示 = e.脚後_下腕_表示;
			this.脚後_手_手_表示 = e.脚後_手_手_表示;
			this.脚後_手_小指_指_表示 = e.脚後_手_小指_指_表示;
			this.脚後_手_小指_爪_表示 = e.脚後_手_小指_爪_表示;
			this.脚後_手_小指_鱗_鱗4_表示 = e.脚後_手_小指_鱗_鱗4_表示;
			this.脚後_手_小指_鱗_鱗3_表示 = e.脚後_手_小指_鱗_鱗3_表示;
			this.脚後_手_小指_鱗_鱗2_表示 = e.脚後_手_小指_鱗_鱗2_表示;
			this.脚後_手_小指_鱗_鱗1_表示 = e.脚後_手_小指_鱗_鱗1_表示;
			this.脚後_手_小指_水掻_表示 = e.脚後_手_小指_水掻_表示;
			this.脚後_手_薬指_指_表示 = e.脚後_手_薬指_指_表示;
			this.脚後_手_薬指_爪_表示 = e.脚後_手_薬指_爪_表示;
			this.脚後_手_薬指_水掻_表示 = e.脚後_手_薬指_水掻_表示;
			this.脚後_手_薬指_鱗_鱗4_表示 = e.脚後_手_薬指_鱗_鱗4_表示;
			this.脚後_手_薬指_鱗_鱗3_表示 = e.脚後_手_薬指_鱗_鱗3_表示;
			this.脚後_手_薬指_鱗_鱗2_表示 = e.脚後_手_薬指_鱗_鱗2_表示;
			this.脚後_手_薬指_鱗_鱗1_表示 = e.脚後_手_薬指_鱗_鱗1_表示;
			this.脚後_手_中指_指_表示 = e.脚後_手_中指_指_表示;
			this.脚後_手_中指_爪_表示 = e.脚後_手_中指_爪_表示;
			this.脚後_手_中指_水掻_表示 = e.脚後_手_中指_水掻_表示;
			this.脚後_手_中指_鱗_鱗4_表示 = e.脚後_手_中指_鱗_鱗4_表示;
			this.脚後_手_中指_鱗_鱗3_表示 = e.脚後_手_中指_鱗_鱗3_表示;
			this.脚後_手_中指_鱗_鱗2_表示 = e.脚後_手_中指_鱗_鱗2_表示;
			this.脚後_手_中指_鱗_鱗1_表示 = e.脚後_手_中指_鱗_鱗1_表示;
			this.脚後_手_人指_指_表示 = e.脚後_手_人指_指_表示;
			this.脚後_手_人指_爪_表示 = e.脚後_手_人指_爪_表示;
			this.脚後_手_人指_鱗_鱗4_表示 = e.脚後_手_人指_鱗_鱗4_表示;
			this.脚後_手_人指_鱗_鱗3_表示 = e.脚後_手_人指_鱗_鱗3_表示;
			this.脚後_手_人指_鱗_鱗2_表示 = e.脚後_手_人指_鱗_鱗2_表示;
			this.脚後_手_人指_鱗_鱗1_表示 = e.脚後_手_人指_鱗_鱗1_表示;
			this.脚後_手_鱗_鱗3_表示 = e.脚後_手_鱗_鱗3_表示;
			this.脚後_手_鱗_鱗2_表示 = e.脚後_手_鱗_鱗2_表示;
			this.脚後_手_鱗_鱗1_表示 = e.脚後_手_鱗_鱗1_表示;
			this.脚後_手_親指_爪_表示 = e.脚後_手_親指_爪_表示;
			this.脚後_下腕鱗_鱗小_鱗9_表示 = e.脚後_下腕鱗_鱗小_鱗9_表示;
			this.脚後_下腕鱗_鱗小_鱗8_表示 = e.脚後_下腕鱗_鱗小_鱗8_表示;
			this.脚後_下腕鱗_鱗小_鱗7_表示 = e.脚後_下腕鱗_鱗小_鱗7_表示;
			this.脚後_下腕鱗_鱗小_鱗6_表示 = e.脚後_下腕鱗_鱗小_鱗6_表示;
			this.脚後_下腕鱗_鱗小_鱗5_表示 = e.脚後_下腕鱗_鱗小_鱗5_表示;
			this.脚後_下腕鱗_鱗小_鱗4_表示 = e.脚後_下腕鱗_鱗小_鱗4_表示;
			this.脚後_下腕鱗_鱗小_鱗3_表示 = e.脚後_下腕鱗_鱗小_鱗3_表示;
			this.脚後_下腕鱗_鱗小_鱗2_表示 = e.脚後_下腕鱗_鱗小_鱗2_表示;
			this.脚後_下腕鱗_鱗小_鱗1_表示 = e.脚後_下腕鱗_鱗小_鱗1_表示;
			this.脚後_下腕鱗_鱗大_鱗9_表示 = e.脚後_下腕鱗_鱗大_鱗9_表示;
			this.脚後_下腕鱗_鱗大_鱗8_表示 = e.脚後_下腕鱗_鱗大_鱗8_表示;
			this.脚後_下腕鱗_鱗大_鱗7_表示 = e.脚後_下腕鱗_鱗大_鱗7_表示;
			this.脚後_下腕鱗_鱗大_鱗6_表示 = e.脚後_下腕鱗_鱗大_鱗6_表示;
			this.脚後_下腕鱗_鱗大_鱗5_表示 = e.脚後_下腕鱗_鱗大_鱗5_表示;
			this.脚後_下腕鱗_鱗大_鱗4_表示 = e.脚後_下腕鱗_鱗大_鱗4_表示;
			this.脚後_下腕鱗_鱗大_鱗3_表示 = e.脚後_下腕鱗_鱗大_鱗3_表示;
			this.脚後_下腕鱗_鱗大_鱗2_表示 = e.脚後_下腕鱗_鱗大_鱗2_表示;
			this.脚後_下腕鱗_鱗大_鱗1_表示 = e.脚後_下腕鱗_鱗大_鱗1_表示;
			this.脚後_上腕鱗_鱗5_表示 = e.脚後_上腕鱗_鱗5_表示;
			this.脚後_上腕鱗_鱗4_表示 = e.脚後_上腕鱗_鱗4_表示;
			this.脚後_上腕鱗_鱗3_表示 = e.脚後_上腕鱗_鱗3_表示;
			this.脚後_上腕鱗_鱗2_表示 = e.脚後_上腕鱗_鱗2_表示;
			this.脚後_上腕鱗_鱗1_表示 = e.脚後_上腕鱗_鱗1_表示;
			this.脚後_輪_革_表示 = e.脚後_輪_革_表示;
			this.脚後_輪_金具1_表示 = e.脚後_輪_金具1_表示;
			this.脚後_輪_金具2_表示 = e.脚後_輪_金具2_表示;
			this.脚後_輪_金具3_表示 = e.脚後_輪_金具3_表示;
			this.脚後_輪_金具左_表示 = e.脚後_輪_金具左_表示;
			this.脚後_輪_金具右_表示 = e.脚後_輪_金具右_表示;
			this.上顎頭部後_頭2_表示 = e.上顎頭部後_頭2_表示;
			this.上顎頭部後_頭1_表示 = e.上顎頭部後_頭1_表示;
			this.下顎頭部後_頭2_表示 = e.下顎頭部後_頭2_表示;
			this.下顎頭部後_頭1_表示 = e.下顎頭部後_頭1_表示;
			this.胴_節1_胴_表示 = e.胴_節1_胴_表示;
			this.胴_節1_鱗1_表示 = e.胴_節1_鱗1_表示;
			this.胴_節1_鱗3_表示 = e.胴_節1_鱗3_表示;
			this.胴_節1_鱗2_表示 = e.胴_節1_鱗2_表示;
			this.胴_節2_胴_表示 = e.胴_節2_胴_表示;
			this.胴_節2_鱗1_表示 = e.胴_節2_鱗1_表示;
			this.胴_節2_鱗3_表示 = e.胴_節2_鱗3_表示;
			this.胴_節2_鱗2_表示 = e.胴_節2_鱗2_表示;
			this.胴_節3_胴_表示 = e.胴_節3_胴_表示;
			this.胴_節3_鱗1_表示 = e.胴_節3_鱗1_表示;
			this.胴_節3_鱗3_表示 = e.胴_節3_鱗3_表示;
			this.胴_節3_鱗2_表示 = e.胴_節3_鱗2_表示;
			this.胴_節4_胴_表示 = e.胴_節4_胴_表示;
			this.胴_節4_鱗1_表示 = e.胴_節4_鱗1_表示;
			this.胴_節4_鱗3_表示 = e.胴_節4_鱗3_表示;
			this.胴_節4_鱗2_表示 = e.胴_節4_鱗2_表示;
			this.胴_節5_胴_表示 = e.胴_節5_胴_表示;
			this.胴_節5_鱗1_表示 = e.胴_節5_鱗1_表示;
			this.胴_節5_鱗3_表示 = e.胴_節5_鱗3_表示;
			this.胴_節5_鱗2_表示 = e.胴_節5_鱗2_表示;
			this.胴_節6_胴_表示 = e.胴_節6_胴_表示;
			this.胴_節6_鱗1_表示 = e.胴_節6_鱗1_表示;
			this.胴_節6_鱗3_表示 = e.胴_節6_鱗3_表示;
			this.胴_節6_鱗2_表示 = e.胴_節6_鱗2_表示;
			this.胴_節7_胴_表示 = e.胴_節7_胴_表示;
			this.胴_節7_鱗1_表示 = e.胴_節7_鱗1_表示;
			this.胴_節7_鱗3_表示 = e.胴_節7_鱗3_表示;
			this.胴_節7_鱗2_表示 = e.胴_節7_鱗2_表示;
			this.胴_節8_胴_表示 = e.胴_節8_胴_表示;
			this.胴_節8_鱗1_表示 = e.胴_節8_鱗1_表示;
			this.胴_節8_鱗3_表示 = e.胴_節8_鱗3_表示;
			this.胴_節8_鱗2_表示 = e.胴_節8_鱗2_表示;
			this.胴_節9_胴_表示 = e.胴_節9_胴_表示;
			this.胴_節9_鱗1_表示 = e.胴_節9_鱗1_表示;
			this.胴_節9_鱗3_表示 = e.胴_節9_鱗3_表示;
			this.胴_節9_鱗2_表示 = e.胴_節9_鱗2_表示;
			this.胴_節10_胴_表示 = e.胴_節10_胴_表示;
			this.胴_節10_鱗1_表示 = e.胴_節10_鱗1_表示;
			this.胴_節10_鱗3_表示 = e.胴_節10_鱗3_表示;
			this.胴_節10_鱗2_表示 = e.胴_節10_鱗2_表示;
			this.胴_節11_胴_表示 = e.胴_節11_胴_表示;
			this.胴_節11_鱗1_表示 = e.胴_節11_鱗1_表示;
			this.胴_節11_鱗3_表示 = e.胴_節11_鱗3_表示;
			this.胴_節11_鱗2_表示 = e.胴_節11_鱗2_表示;
			this.胴_節12_胴_表示 = e.胴_節12_胴_表示;
			this.胴_節12_鱗1_表示 = e.胴_節12_鱗1_表示;
			this.胴_節12_鱗3_表示 = e.胴_節12_鱗3_表示;
			this.胴_節12_鱗2_表示 = e.胴_節12_鱗2_表示;
			this.胴_節13_胴_表示 = e.胴_節13_胴_表示;
			this.胴_節13_鱗1_表示 = e.胴_節13_鱗1_表示;
			this.胴_節13_鱗3_表示 = e.胴_節13_鱗3_表示;
			this.胴_節13_鱗2_表示 = e.胴_節13_鱗2_表示;
			this.胴_節14_胴_表示 = e.胴_節14_胴_表示;
			this.胴_節14_鱗1_表示 = e.胴_節14_鱗1_表示;
			this.胴_節14_鱗3_表示 = e.胴_節14_鱗3_表示;
			this.胴_節14_鱗2_表示 = e.胴_節14_鱗2_表示;
			this.胴_節15_胴_表示 = e.胴_節15_胴_表示;
			this.胴_節15_鱗1_表示 = e.胴_節15_鱗1_表示;
			this.胴_節15_鱗3_表示 = e.胴_節15_鱗3_表示;
			this.胴_節15_鱗2_表示 = e.胴_節15_鱗2_表示;
			this.胴_節16_胴_表示 = e.胴_節16_胴_表示;
			this.胴_節16_鱗1_表示 = e.胴_節16_鱗1_表示;
			this.胴_節16_鱗3_表示 = e.胴_節16_鱗3_表示;
			this.胴_節16_鱗2_表示 = e.胴_節16_鱗2_表示;
			this.胴_輪_革_表示 = e.胴_輪_革_表示;
			this.胴_輪_金具1_表示 = e.胴_輪_金具1_表示;
			this.胴_輪_金具2_表示 = e.胴_輪_金具2_表示;
			this.胴_輪_金具3_表示 = e.胴_輪_金具3_表示;
			this.胴_輪_金具左_表示 = e.胴_輪_金具左_表示;
			this.胴_輪_金具右_表示 = e.胴_輪_金具右_表示;
			this.胴_節17_胴_表示 = e.胴_節17_胴_表示;
			this.胴_節17_鱗1_表示 = e.胴_節17_鱗1_表示;
			this.胴_節17_鱗3_表示 = e.胴_節17_鱗3_表示;
			this.胴_節17_鱗2_表示 = e.胴_節17_鱗2_表示;
			this.胴_節18_胴_表示 = e.胴_節18_胴_表示;
			this.胴_節18_鱗1_表示 = e.胴_節18_鱗1_表示;
			this.胴_節18_鱗3_表示 = e.胴_節18_鱗3_表示;
			this.胴_節18_鱗2_表示 = e.胴_節18_鱗2_表示;
			this.頭_口膜_口膜1_表示 = e.頭_口膜_口膜1_表示;
			this.頭_口膜_口膜2_表示 = e.頭_口膜_口膜2_表示;
			this.頭_口膜_口膜3_表示 = e.頭_口膜_口膜3_表示;
			this.頭_口膜_口膜4_表示 = e.頭_口膜_口膜4_表示;
			this.頭_口膜_口膜5_表示 = e.頭_口膜_口膜5_表示;
			this.頭_口膜_口膜6_表示 = e.頭_口膜_口膜6_表示;
			this.頭_口膜_口膜7_表示 = e.頭_口膜_口膜7_表示;
			this.頭_口膜_口膜8_表示 = e.頭_口膜_口膜8_表示;
			this.頭_上顎歯後_歯1_表示 = e.頭_上顎歯後_歯1_表示;
			this.頭_上顎歯後_歯2_表示 = e.頭_上顎歯後_歯2_表示;
			this.頭_上顎歯後_歯3_表示 = e.頭_上顎歯後_歯3_表示;
			this.頭_下顎_歯_後_歯1_表示 = e.頭_下顎_歯_後_歯1_表示;
			this.頭_下顎_歯_後_歯2_表示 = e.頭_下顎_歯_後_歯2_表示;
			this.頭_下顎_歯_後_歯3_表示 = e.頭_下顎_歯_後_歯3_表示;
			this.頭_下顎_歯_前_歯1_表示 = e.頭_下顎_歯_前_歯1_表示;
			this.頭_下顎_歯_前_歯2_表示 = e.頭_下顎_歯_前_歯2_表示;
			this.頭_下顎_歯_前_歯3_表示 = e.頭_下顎_歯_前_歯3_表示;
			this.頭_下顎_眼孔1_表示 = e.頭_下顎_眼孔1_表示;
			this.頭_下顎_眼孔2_表示 = e.頭_下顎_眼孔2_表示;
			this.頭_下顎_眼_眼1_眼2_表示 = e.頭_下顎_眼_眼1_眼2_表示;
			this.頭_下顎_眼_眼1_眼1_表示 = e.頭_下顎_眼_眼1_眼1_表示;
			this.頭_下顎_眼_眼2_眼2_表示 = e.頭_下顎_眼_眼2_眼2_表示;
			this.頭_下顎_眼_眼2_眼1_表示 = e.頭_下顎_眼_眼2_眼1_表示;
			this.頭_下顎_眼下_眼下_表示 = e.頭_下顎_眼下_眼下_表示;
			this.頭_下顎_眼下_線_表示 = e.頭_下顎_眼下_線_表示;
			this.頭_下顎_頭部_前_頭9_表示 = e.頭_下顎_頭部_前_頭9_表示;
			this.頭_下顎_頭部_前_頭8_表示 = e.頭_下顎_頭部_前_頭8_表示;
			this.頭_下顎_頭部_前_頭7_表示 = e.頭_下顎_頭部_前_頭7_表示;
			this.頭_下顎_頭部_前_頭6_表示 = e.頭_下顎_頭部_前_頭6_表示;
			this.頭_下顎_頭部_前_頭5_表示 = e.頭_下顎_頭部_前_頭5_表示;
			this.頭_下顎_頭部_前_頭4_表示 = e.頭_下顎_頭部_前_頭4_表示;
			this.頭_下顎_頭部_前_頭3_表示 = e.頭_下顎_頭部_前_頭3_表示;
			this.頭_下顎_頭部_前_頭2_表示 = e.頭_下顎_頭部_前_頭2_表示;
			this.頭_下顎_頭部_前_頭1_表示 = e.頭_下顎_頭部_前_頭1_表示;
			this.頭_上顎_歯_前_歯1_表示 = e.頭_上顎_歯_前_歯1_表示;
			this.頭_上顎_歯_前_歯2_表示 = e.頭_上顎_歯_前_歯2_表示;
			this.頭_上顎_歯_前_歯3_表示 = e.頭_上顎_歯_前_歯3_表示;
			this.頭_上顎_眼孔1_表示 = e.頭_上顎_眼孔1_表示;
			this.頭_上顎_眼孔2_表示 = e.頭_上顎_眼孔2_表示;
			this.頭_上顎_眼_眼1_眼2_表示 = e.頭_上顎_眼_眼1_眼2_表示;
			this.頭_上顎_眼_眼1_眼1_表示 = e.頭_上顎_眼_眼1_眼1_表示;
			this.頭_上顎_眼_眼2_眼2_表示 = e.頭_上顎_眼_眼2_眼2_表示;
			this.頭_上顎_眼_眼2_眼1_表示 = e.頭_上顎_眼_眼2_眼1_表示;
			this.頭_上顎_眼下_眼下_表示 = e.頭_上顎_眼下_眼下_表示;
			this.頭_上顎_眼下_線_表示 = e.頭_上顎_眼下_線_表示;
			this.頭_上顎_頭部_前_頭9_表示 = e.頭_上顎_頭部_前_頭9_表示;
			this.頭_上顎_頭部_前_頭8_表示 = e.頭_上顎_頭部_前_頭8_表示;
			this.頭_上顎_頭部_前_頭7_表示 = e.頭_上顎_頭部_前_頭7_表示;
			this.頭_上顎_頭部_前_頭6_表示 = e.頭_上顎_頭部_前_頭6_表示;
			this.頭_上顎_頭部_前_頭5_表示 = e.頭_上顎_頭部_前_頭5_表示;
			this.頭_上顎_頭部_前_頭4_表示 = e.頭_上顎_頭部_前_頭4_表示;
			this.頭_上顎_頭部_前_頭3_表示 = e.頭_上顎_頭部_前_頭3_表示;
			this.頭_上顎_頭部_前_頭2_表示 = e.頭_上顎_頭部_前_頭2_表示;
			this.頭_上顎_頭部_前_頭1_表示 = e.頭_上顎_頭部_前_頭1_表示;
			this.頭_輪_革_表示 = e.頭_輪_革_表示;
			this.頭_輪_金具1_表示 = e.頭_輪_金具1_表示;
			this.頭_輪_金具2_表示 = e.頭_輪_金具2_表示;
			this.頭_輪_金具3_表示 = e.頭_輪_金具3_表示;
			this.頭_輪_金具左_表示 = e.頭_輪_金具左_表示;
			this.頭_輪_金具右_表示 = e.頭_輪_金具右_表示;
			this.脚前_上腕_表示 = e.脚前_上腕_表示;
			this.脚前_下腕_表示 = e.脚前_下腕_表示;
			this.脚前_手_親指_爪_表示 = e.脚前_手_親指_爪_表示;
			this.脚前_手_手_表示 = e.脚前_手_手_表示;
			this.脚前_手_人指_指_表示 = e.脚前_手_人指_指_表示;
			this.脚前_手_人指_爪_表示 = e.脚前_手_人指_爪_表示;
			this.脚前_手_人指_水掻_表示 = e.脚前_手_人指_水掻_表示;
			this.脚前_手_人指_鱗_鱗4_表示 = e.脚前_手_人指_鱗_鱗4_表示;
			this.脚前_手_人指_鱗_鱗3_表示 = e.脚前_手_人指_鱗_鱗3_表示;
			this.脚前_手_人指_鱗_鱗2_表示 = e.脚前_手_人指_鱗_鱗2_表示;
			this.脚前_手_人指_鱗_鱗1_表示 = e.脚前_手_人指_鱗_鱗1_表示;
			this.脚前_手_中指_指_表示 = e.脚前_手_中指_指_表示;
			this.脚前_手_中指_爪_表示 = e.脚前_手_中指_爪_表示;
			this.脚前_手_中指_水掻_表示 = e.脚前_手_中指_水掻_表示;
			this.脚前_手_中指_鱗_鱗4_表示 = e.脚前_手_中指_鱗_鱗4_表示;
			this.脚前_手_中指_鱗_鱗3_表示 = e.脚前_手_中指_鱗_鱗3_表示;
			this.脚前_手_中指_鱗_鱗2_表示 = e.脚前_手_中指_鱗_鱗2_表示;
			this.脚前_手_中指_鱗_鱗1_表示 = e.脚前_手_中指_鱗_鱗1_表示;
			this.脚前_手_薬指_指_表示 = e.脚前_手_薬指_指_表示;
			this.脚前_手_薬指_爪_表示 = e.脚前_手_薬指_爪_表示;
			this.脚前_手_薬指_水掻_表示 = e.脚前_手_薬指_水掻_表示;
			this.脚前_手_薬指_鱗_鱗4_表示 = e.脚前_手_薬指_鱗_鱗4_表示;
			this.脚前_手_薬指_鱗_鱗3_表示 = e.脚前_手_薬指_鱗_鱗3_表示;
			this.脚前_手_薬指_鱗_鱗2_表示 = e.脚前_手_薬指_鱗_鱗2_表示;
			this.脚前_手_薬指_鱗_鱗1_表示 = e.脚前_手_薬指_鱗_鱗1_表示;
			this.脚前_手_小指_指_表示 = e.脚前_手_小指_指_表示;
			this.脚前_手_小指_爪_表示 = e.脚前_手_小指_爪_表示;
			this.脚前_手_小指_鱗_鱗4_表示 = e.脚前_手_小指_鱗_鱗4_表示;
			this.脚前_手_小指_鱗_鱗3_表示 = e.脚前_手_小指_鱗_鱗3_表示;
			this.脚前_手_小指_鱗_鱗2_表示 = e.脚前_手_小指_鱗_鱗2_表示;
			this.脚前_手_小指_鱗_鱗1_表示 = e.脚前_手_小指_鱗_鱗1_表示;
			this.脚前_手_鱗_鱗3_表示 = e.脚前_手_鱗_鱗3_表示;
			this.脚前_手_鱗_鱗2_表示 = e.脚前_手_鱗_鱗2_表示;
			this.脚前_手_鱗_鱗1_表示 = e.脚前_手_鱗_鱗1_表示;
			this.脚前_下腕鱗_鱗小_鱗9_表示 = e.脚前_下腕鱗_鱗小_鱗9_表示;
			this.脚前_下腕鱗_鱗小_鱗8_表示 = e.脚前_下腕鱗_鱗小_鱗8_表示;
			this.脚前_下腕鱗_鱗小_鱗7_表示 = e.脚前_下腕鱗_鱗小_鱗7_表示;
			this.脚前_下腕鱗_鱗小_鱗6_表示 = e.脚前_下腕鱗_鱗小_鱗6_表示;
			this.脚前_下腕鱗_鱗小_鱗5_表示 = e.脚前_下腕鱗_鱗小_鱗5_表示;
			this.脚前_下腕鱗_鱗小_鱗4_表示 = e.脚前_下腕鱗_鱗小_鱗4_表示;
			this.脚前_下腕鱗_鱗小_鱗3_表示 = e.脚前_下腕鱗_鱗小_鱗3_表示;
			this.脚前_下腕鱗_鱗小_鱗2_表示 = e.脚前_下腕鱗_鱗小_鱗2_表示;
			this.脚前_下腕鱗_鱗小_鱗1_表示 = e.脚前_下腕鱗_鱗小_鱗1_表示;
			this.脚前_下腕鱗_鱗大_鱗9_表示 = e.脚前_下腕鱗_鱗大_鱗9_表示;
			this.脚前_下腕鱗_鱗大_鱗8_表示 = e.脚前_下腕鱗_鱗大_鱗8_表示;
			this.脚前_下腕鱗_鱗大_鱗7_表示 = e.脚前_下腕鱗_鱗大_鱗7_表示;
			this.脚前_下腕鱗_鱗大_鱗6_表示 = e.脚前_下腕鱗_鱗大_鱗6_表示;
			this.脚前_下腕鱗_鱗大_鱗5_表示 = e.脚前_下腕鱗_鱗大_鱗5_表示;
			this.脚前_下腕鱗_鱗大_鱗4_表示 = e.脚前_下腕鱗_鱗大_鱗4_表示;
			this.脚前_下腕鱗_鱗大_鱗3_表示 = e.脚前_下腕鱗_鱗大_鱗3_表示;
			this.脚前_下腕鱗_鱗大_鱗2_表示 = e.脚前_下腕鱗_鱗大_鱗2_表示;
			this.脚前_下腕鱗_鱗大_鱗1_表示 = e.脚前_下腕鱗_鱗大_鱗1_表示;
			this.脚前_上腕鱗_鱗5_表示 = e.脚前_上腕鱗_鱗5_表示;
			this.脚前_上腕鱗_鱗4_表示 = e.脚前_上腕鱗_鱗4_表示;
			this.脚前_上腕鱗_鱗3_表示 = e.脚前_上腕鱗_鱗3_表示;
			this.脚前_上腕鱗_鱗2_表示 = e.脚前_上腕鱗_鱗2_表示;
			this.脚前_上腕鱗_鱗1_表示 = e.脚前_上腕鱗_鱗1_表示;
			this.脚前_鰭_鰭膜1_表示 = e.脚前_鰭_鰭膜1_表示;
			this.脚前_鰭_鰭条1_表示 = e.脚前_鰭_鰭条1_表示;
			this.脚前_鰭_鰭膜2_表示 = e.脚前_鰭_鰭膜2_表示;
			this.脚前_鰭_鰭条2_表示 = e.脚前_鰭_鰭条2_表示;
			this.脚前_鰭_鰭膜3_表示 = e.脚前_鰭_鰭膜3_表示;
			this.脚前_輪_革_表示 = e.脚前_輪_革_表示;
			this.脚前_輪_金具1_表示 = e.脚前_輪_金具1_表示;
			this.脚前_輪_金具2_表示 = e.脚前_輪_金具2_表示;
			this.脚前_輪_金具3_表示 = e.脚前_輪_金具3_表示;
			this.脚前_輪_金具左_表示 = e.脚前_輪_金具左_表示;
			this.脚前_輪_金具右_表示 = e.脚前_輪_金具右_表示;
			this.頭部鱗 = e.頭部鱗;
			this.輪1表示 = e.輪1表示;
			this.輪2表示 = e.輪2表示;
			this.輪3表示 = e.輪3表示;
			this.輪4表示 = e.輪4表示;
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
					f.接続情報 = 接続情報.触手_犬_頭_接続;
					f.接続(CS$<>8__locals1.<>4__this.頭_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.上腕左_接続.Count > 0)
			{
				Ele f;
				this.上腕左_接続 = e.上腕左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_犬_上腕左_接続;
					f.接続(CS$<>8__locals1.<>4__this.上腕左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.上腕右_接続.Count > 0)
			{
				Ele f;
				this.上腕右_接続 = e.上腕右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_犬_上腕右_接続;
					f.接続(CS$<>8__locals1.<>4__this.上腕右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.下腕左_接続.Count > 0)
			{
				Ele f;
				this.下腕左_接続 = e.下腕左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_犬_下腕左_接続;
					f.接続(CS$<>8__locals1.<>4__this.下腕左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.下腕右_接続.Count > 0)
			{
				Ele f;
				this.下腕右_接続 = e.下腕右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_犬_下腕右_接続;
					f.接続(CS$<>8__locals1.<>4__this.下腕右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.手左_接続.Count > 0)
			{
				Ele f;
				this.手左_接続 = e.手左_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_犬_手左_接続;
					f.接続(CS$<>8__locals1.<>4__this.手左_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.手右_接続.Count > 0)
			{
				Ele f;
				this.手右_接続 = e.手右_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_犬_手右_接続;
					f.接続(CS$<>8__locals1.<>4__this.手右_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
			this.X0Y0_脚後_鰭_鰭膜1CP = new ColorP(this.X0Y0_脚後_鰭_鰭膜1, this.脚後_鰭_鰭膜1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_鰭_鰭条1CP = new ColorP(this.X0Y0_脚後_鰭_鰭条1, this.脚後_鰭_鰭条1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_鰭_鰭膜2CP = new ColorP(this.X0Y0_脚後_鰭_鰭膜2, this.脚後_鰭_鰭膜2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_鰭_鰭条2CP = new ColorP(this.X0Y0_脚後_鰭_鰭条2, this.脚後_鰭_鰭条2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_鰭_鰭膜3CP = new ColorP(this.X0Y0_脚後_鰭_鰭膜3, this.脚後_鰭_鰭膜3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_上腕CP = new ColorP(this.X0Y0_脚後_上腕, this.脚後_上腕CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_下腕CP = new ColorP(this.X0Y0_脚後_下腕, this.脚後_下腕CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_手CP = new ColorP(this.X0Y0_脚後_手_手, this.脚後_手_手CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_小指_指CP = new ColorP(this.X0Y0_脚後_手_小指_指, this.脚後_手_小指_指CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_小指_爪CP = new ColorP(this.X0Y0_脚後_手_小指_爪, this.脚後_手_小指_爪CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_小指_鱗_鱗4CP = new ColorP(this.X0Y0_脚後_手_小指_鱗_鱗4, this.脚後_手_小指_鱗_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_小指_鱗_鱗3CP = new ColorP(this.X0Y0_脚後_手_小指_鱗_鱗3, this.脚後_手_小指_鱗_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_小指_鱗_鱗2CP = new ColorP(this.X0Y0_脚後_手_小指_鱗_鱗2, this.脚後_手_小指_鱗_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_小指_鱗_鱗1CP = new ColorP(this.X0Y0_脚後_手_小指_鱗_鱗1, this.脚後_手_小指_鱗_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_小指_水掻CP = new ColorP(this.X0Y0_脚後_手_小指_水掻, this.脚後_手_小指_水掻CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_薬指_指CP = new ColorP(this.X0Y0_脚後_手_薬指_指, this.脚後_手_薬指_指CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_薬指_爪CP = new ColorP(this.X0Y0_脚後_手_薬指_爪, this.脚後_手_薬指_爪CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_薬指_水掻CP = new ColorP(this.X0Y0_脚後_手_薬指_水掻, this.脚後_手_薬指_水掻CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_薬指_鱗_鱗4CP = new ColorP(this.X0Y0_脚後_手_薬指_鱗_鱗4, this.脚後_手_薬指_鱗_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_薬指_鱗_鱗3CP = new ColorP(this.X0Y0_脚後_手_薬指_鱗_鱗3, this.脚後_手_薬指_鱗_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_薬指_鱗_鱗2CP = new ColorP(this.X0Y0_脚後_手_薬指_鱗_鱗2, this.脚後_手_薬指_鱗_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_薬指_鱗_鱗1CP = new ColorP(this.X0Y0_脚後_手_薬指_鱗_鱗1, this.脚後_手_薬指_鱗_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_中指_指CP = new ColorP(this.X0Y0_脚後_手_中指_指, this.脚後_手_中指_指CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_中指_爪CP = new ColorP(this.X0Y0_脚後_手_中指_爪, this.脚後_手_中指_爪CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_中指_水掻CP = new ColorP(this.X0Y0_脚後_手_中指_水掻, this.脚後_手_中指_水掻CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_中指_鱗_鱗4CP = new ColorP(this.X0Y0_脚後_手_中指_鱗_鱗4, this.脚後_手_中指_鱗_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_中指_鱗_鱗3CP = new ColorP(this.X0Y0_脚後_手_中指_鱗_鱗3, this.脚後_手_中指_鱗_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_中指_鱗_鱗2CP = new ColorP(this.X0Y0_脚後_手_中指_鱗_鱗2, this.脚後_手_中指_鱗_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_中指_鱗_鱗1CP = new ColorP(this.X0Y0_脚後_手_中指_鱗_鱗1, this.脚後_手_中指_鱗_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_人指_指CP = new ColorP(this.X0Y0_脚後_手_人指_指, this.脚後_手_人指_指CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_人指_爪CP = new ColorP(this.X0Y0_脚後_手_人指_爪, this.脚後_手_人指_爪CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_人指_鱗_鱗4CP = new ColorP(this.X0Y0_脚後_手_人指_鱗_鱗4, this.脚後_手_人指_鱗_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_人指_鱗_鱗3CP = new ColorP(this.X0Y0_脚後_手_人指_鱗_鱗3, this.脚後_手_人指_鱗_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_人指_鱗_鱗2CP = new ColorP(this.X0Y0_脚後_手_人指_鱗_鱗2, this.脚後_手_人指_鱗_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_人指_鱗_鱗1CP = new ColorP(this.X0Y0_脚後_手_人指_鱗_鱗1, this.脚後_手_人指_鱗_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_鱗_鱗3CP = new ColorP(this.X0Y0_脚後_手_鱗_鱗3, this.脚後_手_鱗_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_鱗_鱗2CP = new ColorP(this.X0Y0_脚後_手_鱗_鱗2, this.脚後_手_鱗_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_鱗_鱗1CP = new ColorP(this.X0Y0_脚後_手_鱗_鱗1, this.脚後_手_鱗_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_手_親指_爪CP = new ColorP(this.X0Y0_脚後_手_親指_爪, this.脚後_手_親指_爪CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_下腕鱗_鱗小_鱗9CP = new ColorP(this.X0Y0_脚後_下腕鱗_鱗小_鱗9, this.脚後_下腕鱗_鱗小_鱗9CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_下腕鱗_鱗小_鱗8CP = new ColorP(this.X0Y0_脚後_下腕鱗_鱗小_鱗8, this.脚後_下腕鱗_鱗小_鱗8CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_下腕鱗_鱗小_鱗7CP = new ColorP(this.X0Y0_脚後_下腕鱗_鱗小_鱗7, this.脚後_下腕鱗_鱗小_鱗7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_下腕鱗_鱗小_鱗6CP = new ColorP(this.X0Y0_脚後_下腕鱗_鱗小_鱗6, this.脚後_下腕鱗_鱗小_鱗6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_下腕鱗_鱗小_鱗5CP = new ColorP(this.X0Y0_脚後_下腕鱗_鱗小_鱗5, this.脚後_下腕鱗_鱗小_鱗5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_下腕鱗_鱗小_鱗4CP = new ColorP(this.X0Y0_脚後_下腕鱗_鱗小_鱗4, this.脚後_下腕鱗_鱗小_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_下腕鱗_鱗小_鱗3CP = new ColorP(this.X0Y0_脚後_下腕鱗_鱗小_鱗3, this.脚後_下腕鱗_鱗小_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_下腕鱗_鱗小_鱗2CP = new ColorP(this.X0Y0_脚後_下腕鱗_鱗小_鱗2, this.脚後_下腕鱗_鱗小_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_下腕鱗_鱗小_鱗1CP = new ColorP(this.X0Y0_脚後_下腕鱗_鱗小_鱗1, this.脚後_下腕鱗_鱗小_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_下腕鱗_鱗大_鱗9CP = new ColorP(this.X0Y0_脚後_下腕鱗_鱗大_鱗9, this.脚後_下腕鱗_鱗大_鱗9CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_下腕鱗_鱗大_鱗8CP = new ColorP(this.X0Y0_脚後_下腕鱗_鱗大_鱗8, this.脚後_下腕鱗_鱗大_鱗8CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_下腕鱗_鱗大_鱗7CP = new ColorP(this.X0Y0_脚後_下腕鱗_鱗大_鱗7, this.脚後_下腕鱗_鱗大_鱗7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_下腕鱗_鱗大_鱗6CP = new ColorP(this.X0Y0_脚後_下腕鱗_鱗大_鱗6, this.脚後_下腕鱗_鱗大_鱗6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_下腕鱗_鱗大_鱗5CP = new ColorP(this.X0Y0_脚後_下腕鱗_鱗大_鱗5, this.脚後_下腕鱗_鱗大_鱗5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_下腕鱗_鱗大_鱗4CP = new ColorP(this.X0Y0_脚後_下腕鱗_鱗大_鱗4, this.脚後_下腕鱗_鱗大_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_下腕鱗_鱗大_鱗3CP = new ColorP(this.X0Y0_脚後_下腕鱗_鱗大_鱗3, this.脚後_下腕鱗_鱗大_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_下腕鱗_鱗大_鱗2CP = new ColorP(this.X0Y0_脚後_下腕鱗_鱗大_鱗2, this.脚後_下腕鱗_鱗大_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_下腕鱗_鱗大_鱗1CP = new ColorP(this.X0Y0_脚後_下腕鱗_鱗大_鱗1, this.脚後_下腕鱗_鱗大_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_上腕鱗_鱗5CP = new ColorP(this.X0Y0_脚後_上腕鱗_鱗5, this.脚後_上腕鱗_鱗5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_上腕鱗_鱗4CP = new ColorP(this.X0Y0_脚後_上腕鱗_鱗4, this.脚後_上腕鱗_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_上腕鱗_鱗3CP = new ColorP(this.X0Y0_脚後_上腕鱗_鱗3, this.脚後_上腕鱗_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_上腕鱗_鱗2CP = new ColorP(this.X0Y0_脚後_上腕鱗_鱗2, this.脚後_上腕鱗_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_上腕鱗_鱗1CP = new ColorP(this.X0Y0_脚後_上腕鱗_鱗1, this.脚後_上腕鱗_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_輪_革CP = new ColorP(this.X0Y0_脚後_輪_革, this.脚後_輪_革CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_輪_金具1CP = new ColorP(this.X0Y0_脚後_輪_金具1, this.脚後_輪_金具1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_輪_金具2CP = new ColorP(this.X0Y0_脚後_輪_金具2, this.脚後_輪_金具2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_輪_金具3CP = new ColorP(this.X0Y0_脚後_輪_金具3, this.脚後_輪_金具3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_輪_金具左CP = new ColorP(this.X0Y0_脚後_輪_金具左, this.脚後_輪_金具左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚後_輪_金具右CP = new ColorP(this.X0Y0_脚後_輪_金具右, this.脚後_輪_金具右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_上顎頭部後_頭2CP = new ColorP(this.X0Y0_上顎頭部後_頭2, this.上顎頭部後_頭2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_上顎頭部後_頭1CP = new ColorP(this.X0Y0_上顎頭部後_頭1, this.上顎頭部後_頭1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_下顎頭部後_頭2CP = new ColorP(this.X0Y0_下顎頭部後_頭2, this.下顎頭部後_頭2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_下顎頭部後_頭1CP = new ColorP(this.X0Y0_下顎頭部後_頭1, this.下顎頭部後_頭1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節1_胴CP = new ColorP(this.X0Y0_胴_節1_胴, this.胴_節1_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節1_鱗1CP = new ColorP(this.X0Y0_胴_節1_鱗1, this.胴_節1_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節1_鱗3CP = new ColorP(this.X0Y0_胴_節1_鱗3, this.胴_節1_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節1_鱗2CP = new ColorP(this.X0Y0_胴_節1_鱗2, this.胴_節1_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節2_胴CP = new ColorP(this.X0Y0_胴_節2_胴, this.胴_節2_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節2_鱗1CP = new ColorP(this.X0Y0_胴_節2_鱗1, this.胴_節2_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節2_鱗3CP = new ColorP(this.X0Y0_胴_節2_鱗3, this.胴_節2_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節2_鱗2CP = new ColorP(this.X0Y0_胴_節2_鱗2, this.胴_節2_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節3_胴CP = new ColorP(this.X0Y0_胴_節3_胴, this.胴_節3_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節3_鱗1CP = new ColorP(this.X0Y0_胴_節3_鱗1, this.胴_節3_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節3_鱗3CP = new ColorP(this.X0Y0_胴_節3_鱗3, this.胴_節3_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節3_鱗2CP = new ColorP(this.X0Y0_胴_節3_鱗2, this.胴_節3_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節4_胴CP = new ColorP(this.X0Y0_胴_節4_胴, this.胴_節4_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節4_鱗1CP = new ColorP(this.X0Y0_胴_節4_鱗1, this.胴_節4_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節4_鱗3CP = new ColorP(this.X0Y0_胴_節4_鱗3, this.胴_節4_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節4_鱗2CP = new ColorP(this.X0Y0_胴_節4_鱗2, this.胴_節4_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節5_胴CP = new ColorP(this.X0Y0_胴_節5_胴, this.胴_節5_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節5_鱗1CP = new ColorP(this.X0Y0_胴_節5_鱗1, this.胴_節5_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節5_鱗3CP = new ColorP(this.X0Y0_胴_節5_鱗3, this.胴_節5_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節5_鱗2CP = new ColorP(this.X0Y0_胴_節5_鱗2, this.胴_節5_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節6_胴CP = new ColorP(this.X0Y0_胴_節6_胴, this.胴_節6_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節6_鱗1CP = new ColorP(this.X0Y0_胴_節6_鱗1, this.胴_節6_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節6_鱗3CP = new ColorP(this.X0Y0_胴_節6_鱗3, this.胴_節6_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節6_鱗2CP = new ColorP(this.X0Y0_胴_節6_鱗2, this.胴_節6_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節7_胴CP = new ColorP(this.X0Y0_胴_節7_胴, this.胴_節7_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節7_鱗1CP = new ColorP(this.X0Y0_胴_節7_鱗1, this.胴_節7_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節7_鱗3CP = new ColorP(this.X0Y0_胴_節7_鱗3, this.胴_節7_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節7_鱗2CP = new ColorP(this.X0Y0_胴_節7_鱗2, this.胴_節7_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節8_胴CP = new ColorP(this.X0Y0_胴_節8_胴, this.胴_節8_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節8_鱗1CP = new ColorP(this.X0Y0_胴_節8_鱗1, this.胴_節8_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節8_鱗3CP = new ColorP(this.X0Y0_胴_節8_鱗3, this.胴_節8_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節8_鱗2CP = new ColorP(this.X0Y0_胴_節8_鱗2, this.胴_節8_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節9_胴CP = new ColorP(this.X0Y0_胴_節9_胴, this.胴_節9_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節9_鱗1CP = new ColorP(this.X0Y0_胴_節9_鱗1, this.胴_節9_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節9_鱗3CP = new ColorP(this.X0Y0_胴_節9_鱗3, this.胴_節9_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節9_鱗2CP = new ColorP(this.X0Y0_胴_節9_鱗2, this.胴_節9_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節10_胴CP = new ColorP(this.X0Y0_胴_節10_胴, this.胴_節10_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節10_鱗1CP = new ColorP(this.X0Y0_胴_節10_鱗1, this.胴_節10_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節10_鱗3CP = new ColorP(this.X0Y0_胴_節10_鱗3, this.胴_節10_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節10_鱗2CP = new ColorP(this.X0Y0_胴_節10_鱗2, this.胴_節10_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節11_胴CP = new ColorP(this.X0Y0_胴_節11_胴, this.胴_節11_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節11_鱗1CP = new ColorP(this.X0Y0_胴_節11_鱗1, this.胴_節11_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節11_鱗3CP = new ColorP(this.X0Y0_胴_節11_鱗3, this.胴_節11_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節11_鱗2CP = new ColorP(this.X0Y0_胴_節11_鱗2, this.胴_節11_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節12_胴CP = new ColorP(this.X0Y0_胴_節12_胴, this.胴_節12_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節12_鱗1CP = new ColorP(this.X0Y0_胴_節12_鱗1, this.胴_節12_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節12_鱗3CP = new ColorP(this.X0Y0_胴_節12_鱗3, this.胴_節12_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節12_鱗2CP = new ColorP(this.X0Y0_胴_節12_鱗2, this.胴_節12_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節13_胴CP = new ColorP(this.X0Y0_胴_節13_胴, this.胴_節13_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節13_鱗1CP = new ColorP(this.X0Y0_胴_節13_鱗1, this.胴_節13_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節13_鱗3CP = new ColorP(this.X0Y0_胴_節13_鱗3, this.胴_節13_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節13_鱗2CP = new ColorP(this.X0Y0_胴_節13_鱗2, this.胴_節13_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節14_胴CP = new ColorP(this.X0Y0_胴_節14_胴, this.胴_節14_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節14_鱗1CP = new ColorP(this.X0Y0_胴_節14_鱗1, this.胴_節14_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節14_鱗3CP = new ColorP(this.X0Y0_胴_節14_鱗3, this.胴_節14_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節14_鱗2CP = new ColorP(this.X0Y0_胴_節14_鱗2, this.胴_節14_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節15_胴CP = new ColorP(this.X0Y0_胴_節15_胴, this.胴_節15_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節15_鱗1CP = new ColorP(this.X0Y0_胴_節15_鱗1, this.胴_節15_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節15_鱗3CP = new ColorP(this.X0Y0_胴_節15_鱗3, this.胴_節15_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節15_鱗2CP = new ColorP(this.X0Y0_胴_節15_鱗2, this.胴_節15_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節16_胴CP = new ColorP(this.X0Y0_胴_節16_胴, this.胴_節16_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節16_鱗1CP = new ColorP(this.X0Y0_胴_節16_鱗1, this.胴_節16_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節16_鱗3CP = new ColorP(this.X0Y0_胴_節16_鱗3, this.胴_節16_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節16_鱗2CP = new ColorP(this.X0Y0_胴_節16_鱗2, this.胴_節16_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_輪_革CP = new ColorP(this.X0Y0_胴_輪_革, this.胴_輪_革CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_輪_金具1CP = new ColorP(this.X0Y0_胴_輪_金具1, this.胴_輪_金具1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_輪_金具2CP = new ColorP(this.X0Y0_胴_輪_金具2, this.胴_輪_金具2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_輪_金具3CP = new ColorP(this.X0Y0_胴_輪_金具3, this.胴_輪_金具3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_輪_金具左CP = new ColorP(this.X0Y0_胴_輪_金具左, this.胴_輪_金具左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_輪_金具右CP = new ColorP(this.X0Y0_胴_輪_金具右, this.胴_輪_金具右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節17_胴CP = new ColorP(this.X0Y0_胴_節17_胴, this.胴_節17_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節17_鱗1CP = new ColorP(this.X0Y0_胴_節17_鱗1, this.胴_節17_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節17_鱗3CP = new ColorP(this.X0Y0_胴_節17_鱗3, this.胴_節17_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節17_鱗2CP = new ColorP(this.X0Y0_胴_節17_鱗2, this.胴_節17_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節18_胴CP = new ColorP(this.X0Y0_胴_節18_胴, this.胴_節18_胴CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節18_鱗1CP = new ColorP(this.X0Y0_胴_節18_鱗1, this.胴_節18_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節18_鱗3CP = new ColorP(this.X0Y0_胴_節18_鱗3, this.胴_節18_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_胴_節18_鱗2CP = new ColorP(this.X0Y0_胴_節18_鱗2, this.胴_節18_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_口膜_口膜1CP = new ColorP(this.X0Y0_頭_口膜_口膜1, this.頭_口膜_口膜1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_口膜_口膜2CP = new ColorP(this.X0Y0_頭_口膜_口膜2, this.頭_口膜_口膜2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_口膜_口膜3CP = new ColorP(this.X0Y0_頭_口膜_口膜3, this.頭_口膜_口膜3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_口膜_口膜4CP = new ColorP(this.X0Y0_頭_口膜_口膜4, this.頭_口膜_口膜4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_口膜_口膜5CP = new ColorP(this.X0Y0_頭_口膜_口膜5, this.頭_口膜_口膜5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_口膜_口膜6CP = new ColorP(this.X0Y0_頭_口膜_口膜6, this.頭_口膜_口膜6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_口膜_口膜7CP = new ColorP(this.X0Y0_頭_口膜_口膜7, this.頭_口膜_口膜7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_口膜_口膜8CP = new ColorP(this.X0Y0_頭_口膜_口膜8, this.頭_口膜_口膜8CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_上顎歯後_歯1CP = new ColorP(this.X0Y0_頭_上顎歯後_歯1, this.頭_上顎歯後_歯1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_上顎歯後_歯2CP = new ColorP(this.X0Y0_頭_上顎歯後_歯2, this.頭_上顎歯後_歯2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_上顎歯後_歯3CP = new ColorP(this.X0Y0_頭_上顎歯後_歯3, this.頭_上顎歯後_歯3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_下顎_歯_後_歯1CP = new ColorP(this.X0Y0_頭_下顎_歯_後_歯1, this.頭_下顎_歯_後_歯1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_下顎_歯_後_歯2CP = new ColorP(this.X0Y0_頭_下顎_歯_後_歯2, this.頭_下顎_歯_後_歯2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_下顎_歯_後_歯3CP = new ColorP(this.X0Y0_頭_下顎_歯_後_歯3, this.頭_下顎_歯_後_歯3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_下顎_歯_前_歯1CP = new ColorP(this.X0Y0_頭_下顎_歯_前_歯1, this.頭_下顎_歯_前_歯1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_下顎_歯_前_歯2CP = new ColorP(this.X0Y0_頭_下顎_歯_前_歯2, this.頭_下顎_歯_前_歯2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_下顎_歯_前_歯3CP = new ColorP(this.X0Y0_頭_下顎_歯_前_歯3, this.頭_下顎_歯_前_歯3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_下顎_眼孔1CP = new ColorP(this.X0Y0_頭_下顎_眼孔1, this.頭_下顎_眼孔1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_下顎_眼孔2CP = new ColorP(this.X0Y0_頭_下顎_眼孔2, this.頭_下顎_眼孔2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_下顎_眼_眼1_眼2CP = new ColorP(this.X0Y0_頭_下顎_眼_眼1_眼2, this.頭_下顎_眼_眼1_眼2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_下顎_眼_眼1_眼1CP = new ColorP(this.X0Y0_頭_下顎_眼_眼1_眼1, this.頭_下顎_眼_眼1_眼1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_下顎_眼_眼2_眼2CP = new ColorP(this.X0Y0_頭_下顎_眼_眼2_眼2, this.頭_下顎_眼_眼2_眼2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_下顎_眼_眼2_眼1CP = new ColorP(this.X0Y0_頭_下顎_眼_眼2_眼1, this.頭_下顎_眼_眼2_眼1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_下顎_眼下_眼下CP = new ColorP(this.X0Y0_頭_下顎_眼下_眼下, this.頭_下顎_眼下_眼下CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_下顎_眼下_線CP = new ColorP(this.X0Y0_頭_下顎_眼下_線, this.頭_下顎_眼下_線CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_下顎_頭部_前_頭9CP = new ColorP(this.X0Y0_頭_下顎_頭部_前_頭9, this.頭_下顎_頭部_前_頭9CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_下顎_頭部_前_頭8CP = new ColorP(this.X0Y0_頭_下顎_頭部_前_頭8, this.頭_下顎_頭部_前_頭8CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_下顎_頭部_前_頭7CP = new ColorP(this.X0Y0_頭_下顎_頭部_前_頭7, this.頭_下顎_頭部_前_頭7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_下顎_頭部_前_頭6CP = new ColorP(this.X0Y0_頭_下顎_頭部_前_頭6, this.頭_下顎_頭部_前_頭6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_下顎_頭部_前_頭5CP = new ColorP(this.X0Y0_頭_下顎_頭部_前_頭5, this.頭_下顎_頭部_前_頭5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_下顎_頭部_前_頭4CP = new ColorP(this.X0Y0_頭_下顎_頭部_前_頭4, this.頭_下顎_頭部_前_頭4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_下顎_頭部_前_頭3CP = new ColorP(this.X0Y0_頭_下顎_頭部_前_頭3, this.頭_下顎_頭部_前_頭3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_下顎_頭部_前_頭2CP = new ColorP(this.X0Y0_頭_下顎_頭部_前_頭2, this.頭_下顎_頭部_前_頭2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_下顎_頭部_前_頭1CP = new ColorP(this.X0Y0_頭_下顎_頭部_前_頭1, this.頭_下顎_頭部_前_頭1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_上顎_歯_前_歯1CP = new ColorP(this.X0Y0_頭_上顎_歯_前_歯1, this.頭_上顎_歯_前_歯1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_上顎_歯_前_歯2CP = new ColorP(this.X0Y0_頭_上顎_歯_前_歯2, this.頭_上顎_歯_前_歯2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_上顎_歯_前_歯3CP = new ColorP(this.X0Y0_頭_上顎_歯_前_歯3, this.頭_上顎_歯_前_歯3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_上顎_眼孔1CP = new ColorP(this.X0Y0_頭_上顎_眼孔1, this.頭_上顎_眼孔1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_上顎_眼孔2CP = new ColorP(this.X0Y0_頭_上顎_眼孔2, this.頭_上顎_眼孔2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_上顎_眼_眼1_眼2CP = new ColorP(this.X0Y0_頭_上顎_眼_眼1_眼2, this.頭_上顎_眼_眼1_眼2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_上顎_眼_眼1_眼1CP = new ColorP(this.X0Y0_頭_上顎_眼_眼1_眼1, this.頭_上顎_眼_眼1_眼1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_上顎_眼_眼2_眼2CP = new ColorP(this.X0Y0_頭_上顎_眼_眼2_眼2, this.頭_上顎_眼_眼2_眼2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_上顎_眼_眼2_眼1CP = new ColorP(this.X0Y0_頭_上顎_眼_眼2_眼1, this.頭_上顎_眼_眼2_眼1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_上顎_眼下_眼下CP = new ColorP(this.X0Y0_頭_上顎_眼下_眼下, this.頭_上顎_眼下_眼下CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_上顎_眼下_線CP = new ColorP(this.X0Y0_頭_上顎_眼下_線, this.頭_上顎_眼下_線CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_上顎_頭部_前_頭9CP = new ColorP(this.X0Y0_頭_上顎_頭部_前_頭9, this.頭_上顎_頭部_前_頭9CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_上顎_頭部_前_頭8CP = new ColorP(this.X0Y0_頭_上顎_頭部_前_頭8, this.頭_上顎_頭部_前_頭8CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_上顎_頭部_前_頭7CP = new ColorP(this.X0Y0_頭_上顎_頭部_前_頭7, this.頭_上顎_頭部_前_頭7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_上顎_頭部_前_頭6CP = new ColorP(this.X0Y0_頭_上顎_頭部_前_頭6, this.頭_上顎_頭部_前_頭6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_上顎_頭部_前_頭5CP = new ColorP(this.X0Y0_頭_上顎_頭部_前_頭5, this.頭_上顎_頭部_前_頭5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_上顎_頭部_前_頭4CP = new ColorP(this.X0Y0_頭_上顎_頭部_前_頭4, this.頭_上顎_頭部_前_頭4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_上顎_頭部_前_頭3CP = new ColorP(this.X0Y0_頭_上顎_頭部_前_頭3, this.頭_上顎_頭部_前_頭3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_上顎_頭部_前_頭2CP = new ColorP(this.X0Y0_頭_上顎_頭部_前_頭2, this.頭_上顎_頭部_前_頭2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_上顎_頭部_前_頭1CP = new ColorP(this.X0Y0_頭_上顎_頭部_前_頭1, this.頭_上顎_頭部_前_頭1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_輪_革CP = new ColorP(this.X0Y0_頭_輪_革, this.頭_輪_革CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_輪_金具1CP = new ColorP(this.X0Y0_頭_輪_金具1, this.頭_輪_金具1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_輪_金具2CP = new ColorP(this.X0Y0_頭_輪_金具2, this.頭_輪_金具2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_輪_金具3CP = new ColorP(this.X0Y0_頭_輪_金具3, this.頭_輪_金具3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_輪_金具左CP = new ColorP(this.X0Y0_頭_輪_金具左, this.頭_輪_金具左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_頭_輪_金具右CP = new ColorP(this.X0Y0_頭_輪_金具右, this.頭_輪_金具右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_上腕CP = new ColorP(this.X0Y0_脚前_上腕, this.脚前_上腕CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_下腕CP = new ColorP(this.X0Y0_脚前_下腕, this.脚前_下腕CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_親指_爪CP = new ColorP(this.X0Y0_脚前_手_親指_爪, this.脚前_手_親指_爪CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_手CP = new ColorP(this.X0Y0_脚前_手_手, this.脚前_手_手CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_人指_指CP = new ColorP(this.X0Y0_脚前_手_人指_指, this.脚前_手_人指_指CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_人指_爪CP = new ColorP(this.X0Y0_脚前_手_人指_爪, this.脚前_手_人指_爪CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_人指_水掻CP = new ColorP(this.X0Y0_脚前_手_人指_水掻, this.脚前_手_人指_水掻CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_人指_鱗_鱗4CP = new ColorP(this.X0Y0_脚前_手_人指_鱗_鱗4, this.脚前_手_人指_鱗_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_人指_鱗_鱗3CP = new ColorP(this.X0Y0_脚前_手_人指_鱗_鱗3, this.脚前_手_人指_鱗_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_人指_鱗_鱗2CP = new ColorP(this.X0Y0_脚前_手_人指_鱗_鱗2, this.脚前_手_人指_鱗_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_人指_鱗_鱗1CP = new ColorP(this.X0Y0_脚前_手_人指_鱗_鱗1, this.脚前_手_人指_鱗_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_中指_指CP = new ColorP(this.X0Y0_脚前_手_中指_指, this.脚前_手_中指_指CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_中指_爪CP = new ColorP(this.X0Y0_脚前_手_中指_爪, this.脚前_手_中指_爪CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_中指_水掻CP = new ColorP(this.X0Y0_脚前_手_中指_水掻, this.脚前_手_中指_水掻CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_中指_鱗_鱗4CP = new ColorP(this.X0Y0_脚前_手_中指_鱗_鱗4, this.脚前_手_中指_鱗_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_中指_鱗_鱗3CP = new ColorP(this.X0Y0_脚前_手_中指_鱗_鱗3, this.脚前_手_中指_鱗_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_中指_鱗_鱗2CP = new ColorP(this.X0Y0_脚前_手_中指_鱗_鱗2, this.脚前_手_中指_鱗_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_中指_鱗_鱗1CP = new ColorP(this.X0Y0_脚前_手_中指_鱗_鱗1, this.脚前_手_中指_鱗_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_薬指_指CP = new ColorP(this.X0Y0_脚前_手_薬指_指, this.脚前_手_薬指_指CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_薬指_爪CP = new ColorP(this.X0Y0_脚前_手_薬指_爪, this.脚前_手_薬指_爪CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_薬指_水掻CP = new ColorP(this.X0Y0_脚前_手_薬指_水掻, this.脚前_手_薬指_水掻CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_薬指_鱗_鱗4CP = new ColorP(this.X0Y0_脚前_手_薬指_鱗_鱗4, this.脚前_手_薬指_鱗_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_薬指_鱗_鱗3CP = new ColorP(this.X0Y0_脚前_手_薬指_鱗_鱗3, this.脚前_手_薬指_鱗_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_薬指_鱗_鱗2CP = new ColorP(this.X0Y0_脚前_手_薬指_鱗_鱗2, this.脚前_手_薬指_鱗_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_薬指_鱗_鱗1CP = new ColorP(this.X0Y0_脚前_手_薬指_鱗_鱗1, this.脚前_手_薬指_鱗_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_小指_指CP = new ColorP(this.X0Y0_脚前_手_小指_指, this.脚前_手_小指_指CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_小指_爪CP = new ColorP(this.X0Y0_脚前_手_小指_爪, this.脚前_手_小指_爪CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_小指_鱗_鱗4CP = new ColorP(this.X0Y0_脚前_手_小指_鱗_鱗4, this.脚前_手_小指_鱗_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_小指_鱗_鱗3CP = new ColorP(this.X0Y0_脚前_手_小指_鱗_鱗3, this.脚前_手_小指_鱗_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_小指_鱗_鱗2CP = new ColorP(this.X0Y0_脚前_手_小指_鱗_鱗2, this.脚前_手_小指_鱗_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_小指_鱗_鱗1CP = new ColorP(this.X0Y0_脚前_手_小指_鱗_鱗1, this.脚前_手_小指_鱗_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_鱗_鱗3CP = new ColorP(this.X0Y0_脚前_手_鱗_鱗3, this.脚前_手_鱗_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_鱗_鱗2CP = new ColorP(this.X0Y0_脚前_手_鱗_鱗2, this.脚前_手_鱗_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_手_鱗_鱗1CP = new ColorP(this.X0Y0_脚前_手_鱗_鱗1, this.脚前_手_鱗_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_下腕鱗_鱗小_鱗9CP = new ColorP(this.X0Y0_脚前_下腕鱗_鱗小_鱗9, this.脚前_下腕鱗_鱗小_鱗9CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_下腕鱗_鱗小_鱗8CP = new ColorP(this.X0Y0_脚前_下腕鱗_鱗小_鱗8, this.脚前_下腕鱗_鱗小_鱗8CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_下腕鱗_鱗小_鱗7CP = new ColorP(this.X0Y0_脚前_下腕鱗_鱗小_鱗7, this.脚前_下腕鱗_鱗小_鱗7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_下腕鱗_鱗小_鱗6CP = new ColorP(this.X0Y0_脚前_下腕鱗_鱗小_鱗6, this.脚前_下腕鱗_鱗小_鱗6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_下腕鱗_鱗小_鱗5CP = new ColorP(this.X0Y0_脚前_下腕鱗_鱗小_鱗5, this.脚前_下腕鱗_鱗小_鱗5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_下腕鱗_鱗小_鱗4CP = new ColorP(this.X0Y0_脚前_下腕鱗_鱗小_鱗4, this.脚前_下腕鱗_鱗小_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_下腕鱗_鱗小_鱗3CP = new ColorP(this.X0Y0_脚前_下腕鱗_鱗小_鱗3, this.脚前_下腕鱗_鱗小_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_下腕鱗_鱗小_鱗2CP = new ColorP(this.X0Y0_脚前_下腕鱗_鱗小_鱗2, this.脚前_下腕鱗_鱗小_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_下腕鱗_鱗小_鱗1CP = new ColorP(this.X0Y0_脚前_下腕鱗_鱗小_鱗1, this.脚前_下腕鱗_鱗小_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_下腕鱗_鱗大_鱗9CP = new ColorP(this.X0Y0_脚前_下腕鱗_鱗大_鱗9, this.脚前_下腕鱗_鱗大_鱗9CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_下腕鱗_鱗大_鱗8CP = new ColorP(this.X0Y0_脚前_下腕鱗_鱗大_鱗8, this.脚前_下腕鱗_鱗大_鱗8CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_下腕鱗_鱗大_鱗7CP = new ColorP(this.X0Y0_脚前_下腕鱗_鱗大_鱗7, this.脚前_下腕鱗_鱗大_鱗7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_下腕鱗_鱗大_鱗6CP = new ColorP(this.X0Y0_脚前_下腕鱗_鱗大_鱗6, this.脚前_下腕鱗_鱗大_鱗6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_下腕鱗_鱗大_鱗5CP = new ColorP(this.X0Y0_脚前_下腕鱗_鱗大_鱗5, this.脚前_下腕鱗_鱗大_鱗5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_下腕鱗_鱗大_鱗4CP = new ColorP(this.X0Y0_脚前_下腕鱗_鱗大_鱗4, this.脚前_下腕鱗_鱗大_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_下腕鱗_鱗大_鱗3CP = new ColorP(this.X0Y0_脚前_下腕鱗_鱗大_鱗3, this.脚前_下腕鱗_鱗大_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_下腕鱗_鱗大_鱗2CP = new ColorP(this.X0Y0_脚前_下腕鱗_鱗大_鱗2, this.脚前_下腕鱗_鱗大_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_下腕鱗_鱗大_鱗1CP = new ColorP(this.X0Y0_脚前_下腕鱗_鱗大_鱗1, this.脚前_下腕鱗_鱗大_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_上腕鱗_鱗5CP = new ColorP(this.X0Y0_脚前_上腕鱗_鱗5, this.脚前_上腕鱗_鱗5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_上腕鱗_鱗4CP = new ColorP(this.X0Y0_脚前_上腕鱗_鱗4, this.脚前_上腕鱗_鱗4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_上腕鱗_鱗3CP = new ColorP(this.X0Y0_脚前_上腕鱗_鱗3, this.脚前_上腕鱗_鱗3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_上腕鱗_鱗2CP = new ColorP(this.X0Y0_脚前_上腕鱗_鱗2, this.脚前_上腕鱗_鱗2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_上腕鱗_鱗1CP = new ColorP(this.X0Y0_脚前_上腕鱗_鱗1, this.脚前_上腕鱗_鱗1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_鰭_鰭膜1CP = new ColorP(this.X0Y0_脚前_鰭_鰭膜1, this.脚前_鰭_鰭膜1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_鰭_鰭条1CP = new ColorP(this.X0Y0_脚前_鰭_鰭条1, this.脚前_鰭_鰭条1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_鰭_鰭膜2CP = new ColorP(this.X0Y0_脚前_鰭_鰭膜2, this.脚前_鰭_鰭膜2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_鰭_鰭条2CP = new ColorP(this.X0Y0_脚前_鰭_鰭条2, this.脚前_鰭_鰭条2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_鰭_鰭膜3CP = new ColorP(this.X0Y0_脚前_鰭_鰭膜3, this.脚前_鰭_鰭膜3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_輪_革CP = new ColorP(this.X0Y0_脚前_輪_革, this.脚前_輪_革CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_輪_金具1CP = new ColorP(this.X0Y0_脚前_輪_金具1, this.脚前_輪_金具1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_輪_金具2CP = new ColorP(this.X0Y0_脚前_輪_金具2, this.脚前_輪_金具2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_輪_金具3CP = new ColorP(this.X0Y0_脚前_輪_金具3, this.脚前_輪_金具3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_輪_金具左CP = new ColorP(this.X0Y0_脚前_輪_金具左, this.脚前_輪_金具左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_脚前_輪_金具右CP = new ColorP(this.X0Y0_脚前_輪_金具右, this.脚前_輪_金具右CD, CS$<>8__locals1.DisUnit, true);
			this.濃度 = e.濃度;
			this.鎖1 = new 拘束鎖(CS$<>8__locals1.DisUnit, false, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖3 = new 拘束鎖(CS$<>8__locals1.DisUnit, false, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖5 = new 拘束鎖(CS$<>8__locals1.DisUnit, false, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖3.反転Y = true;
			this.鎖5.反転Y = true;
			this.鎖1.接続(this.鎖1_接続点);
			this.鎖3.接続(this.鎖3_接続点);
			this.鎖5.接続(this.鎖5_接続点);
			int num = this.右 ? 10 : -10;
			this.鎖1.角度B -= (double)num;
			this.鎖3.角度B += (double)num;
			this.鎖5.角度B += (double)num;
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
				this.輪3表示 = this.拘束_;
				this.輪4表示 = this.拘束_;
			}
		}

		public bool 脚後_鰭_鰭膜1_表示
		{
			get
			{
				return this.X0Y0_脚後_鰭_鰭膜1.Dra;
			}
			set
			{
				this.X0Y0_脚後_鰭_鰭膜1.Dra = value;
				this.X0Y0_脚後_鰭_鰭膜1.Hit = value;
			}
		}

		public bool 脚後_鰭_鰭条1_表示
		{
			get
			{
				return this.X0Y0_脚後_鰭_鰭条1.Dra;
			}
			set
			{
				this.X0Y0_脚後_鰭_鰭条1.Dra = value;
				this.X0Y0_脚後_鰭_鰭条1.Hit = value;
			}
		}

		public bool 脚後_鰭_鰭膜2_表示
		{
			get
			{
				return this.X0Y0_脚後_鰭_鰭膜2.Dra;
			}
			set
			{
				this.X0Y0_脚後_鰭_鰭膜2.Dra = value;
				this.X0Y0_脚後_鰭_鰭膜2.Hit = value;
			}
		}

		public bool 脚後_鰭_鰭条2_表示
		{
			get
			{
				return this.X0Y0_脚後_鰭_鰭条2.Dra;
			}
			set
			{
				this.X0Y0_脚後_鰭_鰭条2.Dra = value;
				this.X0Y0_脚後_鰭_鰭条2.Hit = value;
			}
		}

		public bool 脚後_鰭_鰭膜3_表示
		{
			get
			{
				return this.X0Y0_脚後_鰭_鰭膜3.Dra;
			}
			set
			{
				this.X0Y0_脚後_鰭_鰭膜3.Dra = value;
				this.X0Y0_脚後_鰭_鰭膜3.Hit = value;
			}
		}

		public bool 脚後_上腕_表示
		{
			get
			{
				return this.X0Y0_脚後_上腕.Dra;
			}
			set
			{
				this.X0Y0_脚後_上腕.Dra = value;
				this.X0Y0_脚後_上腕.Hit = value;
			}
		}

		public bool 脚後_下腕_表示
		{
			get
			{
				return this.X0Y0_脚後_下腕.Dra;
			}
			set
			{
				this.X0Y0_脚後_下腕.Dra = value;
				this.X0Y0_脚後_下腕.Hit = value;
			}
		}

		public bool 脚後_手_手_表示
		{
			get
			{
				return this.X0Y0_脚後_手_手.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_手.Dra = value;
				this.X0Y0_脚後_手_手.Hit = value;
			}
		}

		public bool 脚後_手_小指_指_表示
		{
			get
			{
				return this.X0Y0_脚後_手_小指_指.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_小指_指.Dra = value;
				this.X0Y0_脚後_手_小指_指.Hit = value;
			}
		}

		public bool 脚後_手_小指_爪_表示
		{
			get
			{
				return this.X0Y0_脚後_手_小指_爪.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_小指_爪.Dra = value;
				this.X0Y0_脚後_手_小指_爪.Hit = value;
			}
		}

		public bool 脚後_手_小指_鱗_鱗4_表示
		{
			get
			{
				return this.X0Y0_脚後_手_小指_鱗_鱗4.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_小指_鱗_鱗4.Dra = value;
				this.X0Y0_脚後_手_小指_鱗_鱗4.Hit = value;
			}
		}

		public bool 脚後_手_小指_鱗_鱗3_表示
		{
			get
			{
				return this.X0Y0_脚後_手_小指_鱗_鱗3.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_小指_鱗_鱗3.Dra = value;
				this.X0Y0_脚後_手_小指_鱗_鱗3.Hit = value;
			}
		}

		public bool 脚後_手_小指_鱗_鱗2_表示
		{
			get
			{
				return this.X0Y0_脚後_手_小指_鱗_鱗2.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_小指_鱗_鱗2.Dra = value;
				this.X0Y0_脚後_手_小指_鱗_鱗2.Hit = value;
			}
		}

		public bool 脚後_手_小指_鱗_鱗1_表示
		{
			get
			{
				return this.X0Y0_脚後_手_小指_鱗_鱗1.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_小指_鱗_鱗1.Dra = value;
				this.X0Y0_脚後_手_小指_鱗_鱗1.Hit = value;
			}
		}

		public bool 脚後_手_小指_水掻_表示
		{
			get
			{
				return this.X0Y0_脚後_手_小指_水掻.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_小指_水掻.Dra = value;
				this.X0Y0_脚後_手_小指_水掻.Hit = value;
			}
		}

		public bool 脚後_手_薬指_指_表示
		{
			get
			{
				return this.X0Y0_脚後_手_薬指_指.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_薬指_指.Dra = value;
				this.X0Y0_脚後_手_薬指_指.Hit = value;
			}
		}

		public bool 脚後_手_薬指_爪_表示
		{
			get
			{
				return this.X0Y0_脚後_手_薬指_爪.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_薬指_爪.Dra = value;
				this.X0Y0_脚後_手_薬指_爪.Hit = value;
			}
		}

		public bool 脚後_手_薬指_水掻_表示
		{
			get
			{
				return this.X0Y0_脚後_手_薬指_水掻.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_薬指_水掻.Dra = value;
				this.X0Y0_脚後_手_薬指_水掻.Hit = value;
			}
		}

		public bool 脚後_手_薬指_鱗_鱗4_表示
		{
			get
			{
				return this.X0Y0_脚後_手_薬指_鱗_鱗4.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_薬指_鱗_鱗4.Dra = value;
				this.X0Y0_脚後_手_薬指_鱗_鱗4.Hit = value;
			}
		}

		public bool 脚後_手_薬指_鱗_鱗3_表示
		{
			get
			{
				return this.X0Y0_脚後_手_薬指_鱗_鱗3.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_薬指_鱗_鱗3.Dra = value;
				this.X0Y0_脚後_手_薬指_鱗_鱗3.Hit = value;
			}
		}

		public bool 脚後_手_薬指_鱗_鱗2_表示
		{
			get
			{
				return this.X0Y0_脚後_手_薬指_鱗_鱗2.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_薬指_鱗_鱗2.Dra = value;
				this.X0Y0_脚後_手_薬指_鱗_鱗2.Hit = value;
			}
		}

		public bool 脚後_手_薬指_鱗_鱗1_表示
		{
			get
			{
				return this.X0Y0_脚後_手_薬指_鱗_鱗1.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_薬指_鱗_鱗1.Dra = value;
				this.X0Y0_脚後_手_薬指_鱗_鱗1.Hit = value;
			}
		}

		public bool 脚後_手_中指_指_表示
		{
			get
			{
				return this.X0Y0_脚後_手_中指_指.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_中指_指.Dra = value;
				this.X0Y0_脚後_手_中指_指.Hit = value;
			}
		}

		public bool 脚後_手_中指_爪_表示
		{
			get
			{
				return this.X0Y0_脚後_手_中指_爪.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_中指_爪.Dra = value;
				this.X0Y0_脚後_手_中指_爪.Hit = value;
			}
		}

		public bool 脚後_手_中指_水掻_表示
		{
			get
			{
				return this.X0Y0_脚後_手_中指_水掻.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_中指_水掻.Dra = value;
				this.X0Y0_脚後_手_中指_水掻.Hit = value;
			}
		}

		public bool 脚後_手_中指_鱗_鱗4_表示
		{
			get
			{
				return this.X0Y0_脚後_手_中指_鱗_鱗4.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_中指_鱗_鱗4.Dra = value;
				this.X0Y0_脚後_手_中指_鱗_鱗4.Hit = value;
			}
		}

		public bool 脚後_手_中指_鱗_鱗3_表示
		{
			get
			{
				return this.X0Y0_脚後_手_中指_鱗_鱗3.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_中指_鱗_鱗3.Dra = value;
				this.X0Y0_脚後_手_中指_鱗_鱗3.Hit = value;
			}
		}

		public bool 脚後_手_中指_鱗_鱗2_表示
		{
			get
			{
				return this.X0Y0_脚後_手_中指_鱗_鱗2.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_中指_鱗_鱗2.Dra = value;
				this.X0Y0_脚後_手_中指_鱗_鱗2.Hit = value;
			}
		}

		public bool 脚後_手_中指_鱗_鱗1_表示
		{
			get
			{
				return this.X0Y0_脚後_手_中指_鱗_鱗1.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_中指_鱗_鱗1.Dra = value;
				this.X0Y0_脚後_手_中指_鱗_鱗1.Hit = value;
			}
		}

		public bool 脚後_手_人指_指_表示
		{
			get
			{
				return this.X0Y0_脚後_手_人指_指.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_人指_指.Dra = value;
				this.X0Y0_脚後_手_人指_指.Hit = value;
			}
		}

		public bool 脚後_手_人指_爪_表示
		{
			get
			{
				return this.X0Y0_脚後_手_人指_爪.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_人指_爪.Dra = value;
				this.X0Y0_脚後_手_人指_爪.Hit = value;
			}
		}

		public bool 脚後_手_人指_鱗_鱗4_表示
		{
			get
			{
				return this.X0Y0_脚後_手_人指_鱗_鱗4.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_人指_鱗_鱗4.Dra = value;
				this.X0Y0_脚後_手_人指_鱗_鱗4.Hit = value;
			}
		}

		public bool 脚後_手_人指_鱗_鱗3_表示
		{
			get
			{
				return this.X0Y0_脚後_手_人指_鱗_鱗3.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_人指_鱗_鱗3.Dra = value;
				this.X0Y0_脚後_手_人指_鱗_鱗3.Hit = value;
			}
		}

		public bool 脚後_手_人指_鱗_鱗2_表示
		{
			get
			{
				return this.X0Y0_脚後_手_人指_鱗_鱗2.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_人指_鱗_鱗2.Dra = value;
				this.X0Y0_脚後_手_人指_鱗_鱗2.Hit = value;
			}
		}

		public bool 脚後_手_人指_鱗_鱗1_表示
		{
			get
			{
				return this.X0Y0_脚後_手_人指_鱗_鱗1.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_人指_鱗_鱗1.Dra = value;
				this.X0Y0_脚後_手_人指_鱗_鱗1.Hit = value;
			}
		}

		public bool 脚後_手_鱗_鱗3_表示
		{
			get
			{
				return this.X0Y0_脚後_手_鱗_鱗3.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_鱗_鱗3.Dra = value;
				this.X0Y0_脚後_手_鱗_鱗3.Hit = value;
			}
		}

		public bool 脚後_手_鱗_鱗2_表示
		{
			get
			{
				return this.X0Y0_脚後_手_鱗_鱗2.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_鱗_鱗2.Dra = value;
				this.X0Y0_脚後_手_鱗_鱗2.Hit = value;
			}
		}

		public bool 脚後_手_鱗_鱗1_表示
		{
			get
			{
				return this.X0Y0_脚後_手_鱗_鱗1.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_鱗_鱗1.Dra = value;
				this.X0Y0_脚後_手_鱗_鱗1.Hit = value;
			}
		}

		public bool 脚後_手_親指_爪_表示
		{
			get
			{
				return this.X0Y0_脚後_手_親指_爪.Dra;
			}
			set
			{
				this.X0Y0_脚後_手_親指_爪.Dra = value;
				this.X0Y0_脚後_手_親指_爪.Hit = value;
			}
		}

		public bool 脚後_下腕鱗_鱗小_鱗9_表示
		{
			get
			{
				return this.X0Y0_脚後_下腕鱗_鱗小_鱗9.Dra;
			}
			set
			{
				this.X0Y0_脚後_下腕鱗_鱗小_鱗9.Dra = value;
				this.X0Y0_脚後_下腕鱗_鱗小_鱗9.Hit = value;
			}
		}

		public bool 脚後_下腕鱗_鱗小_鱗8_表示
		{
			get
			{
				return this.X0Y0_脚後_下腕鱗_鱗小_鱗8.Dra;
			}
			set
			{
				this.X0Y0_脚後_下腕鱗_鱗小_鱗8.Dra = value;
				this.X0Y0_脚後_下腕鱗_鱗小_鱗8.Hit = value;
			}
		}

		public bool 脚後_下腕鱗_鱗小_鱗7_表示
		{
			get
			{
				return this.X0Y0_脚後_下腕鱗_鱗小_鱗7.Dra;
			}
			set
			{
				this.X0Y0_脚後_下腕鱗_鱗小_鱗7.Dra = value;
				this.X0Y0_脚後_下腕鱗_鱗小_鱗7.Hit = value;
			}
		}

		public bool 脚後_下腕鱗_鱗小_鱗6_表示
		{
			get
			{
				return this.X0Y0_脚後_下腕鱗_鱗小_鱗6.Dra;
			}
			set
			{
				this.X0Y0_脚後_下腕鱗_鱗小_鱗6.Dra = value;
				this.X0Y0_脚後_下腕鱗_鱗小_鱗6.Hit = value;
			}
		}

		public bool 脚後_下腕鱗_鱗小_鱗5_表示
		{
			get
			{
				return this.X0Y0_脚後_下腕鱗_鱗小_鱗5.Dra;
			}
			set
			{
				this.X0Y0_脚後_下腕鱗_鱗小_鱗5.Dra = value;
				this.X0Y0_脚後_下腕鱗_鱗小_鱗5.Hit = value;
			}
		}

		public bool 脚後_下腕鱗_鱗小_鱗4_表示
		{
			get
			{
				return this.X0Y0_脚後_下腕鱗_鱗小_鱗4.Dra;
			}
			set
			{
				this.X0Y0_脚後_下腕鱗_鱗小_鱗4.Dra = value;
				this.X0Y0_脚後_下腕鱗_鱗小_鱗4.Hit = value;
			}
		}

		public bool 脚後_下腕鱗_鱗小_鱗3_表示
		{
			get
			{
				return this.X0Y0_脚後_下腕鱗_鱗小_鱗3.Dra;
			}
			set
			{
				this.X0Y0_脚後_下腕鱗_鱗小_鱗3.Dra = value;
				this.X0Y0_脚後_下腕鱗_鱗小_鱗3.Hit = value;
			}
		}

		public bool 脚後_下腕鱗_鱗小_鱗2_表示
		{
			get
			{
				return this.X0Y0_脚後_下腕鱗_鱗小_鱗2.Dra;
			}
			set
			{
				this.X0Y0_脚後_下腕鱗_鱗小_鱗2.Dra = value;
				this.X0Y0_脚後_下腕鱗_鱗小_鱗2.Hit = value;
			}
		}

		public bool 脚後_下腕鱗_鱗小_鱗1_表示
		{
			get
			{
				return this.X0Y0_脚後_下腕鱗_鱗小_鱗1.Dra;
			}
			set
			{
				this.X0Y0_脚後_下腕鱗_鱗小_鱗1.Dra = value;
				this.X0Y0_脚後_下腕鱗_鱗小_鱗1.Hit = value;
			}
		}

		public bool 脚後_下腕鱗_鱗大_鱗9_表示
		{
			get
			{
				return this.X0Y0_脚後_下腕鱗_鱗大_鱗9.Dra;
			}
			set
			{
				this.X0Y0_脚後_下腕鱗_鱗大_鱗9.Dra = value;
				this.X0Y0_脚後_下腕鱗_鱗大_鱗9.Hit = value;
			}
		}

		public bool 脚後_下腕鱗_鱗大_鱗8_表示
		{
			get
			{
				return this.X0Y0_脚後_下腕鱗_鱗大_鱗8.Dra;
			}
			set
			{
				this.X0Y0_脚後_下腕鱗_鱗大_鱗8.Dra = value;
				this.X0Y0_脚後_下腕鱗_鱗大_鱗8.Hit = value;
			}
		}

		public bool 脚後_下腕鱗_鱗大_鱗7_表示
		{
			get
			{
				return this.X0Y0_脚後_下腕鱗_鱗大_鱗7.Dra;
			}
			set
			{
				this.X0Y0_脚後_下腕鱗_鱗大_鱗7.Dra = value;
				this.X0Y0_脚後_下腕鱗_鱗大_鱗7.Hit = value;
			}
		}

		public bool 脚後_下腕鱗_鱗大_鱗6_表示
		{
			get
			{
				return this.X0Y0_脚後_下腕鱗_鱗大_鱗6.Dra;
			}
			set
			{
				this.X0Y0_脚後_下腕鱗_鱗大_鱗6.Dra = value;
				this.X0Y0_脚後_下腕鱗_鱗大_鱗6.Hit = value;
			}
		}

		public bool 脚後_下腕鱗_鱗大_鱗5_表示
		{
			get
			{
				return this.X0Y0_脚後_下腕鱗_鱗大_鱗5.Dra;
			}
			set
			{
				this.X0Y0_脚後_下腕鱗_鱗大_鱗5.Dra = value;
				this.X0Y0_脚後_下腕鱗_鱗大_鱗5.Hit = value;
			}
		}

		public bool 脚後_下腕鱗_鱗大_鱗4_表示
		{
			get
			{
				return this.X0Y0_脚後_下腕鱗_鱗大_鱗4.Dra;
			}
			set
			{
				this.X0Y0_脚後_下腕鱗_鱗大_鱗4.Dra = value;
				this.X0Y0_脚後_下腕鱗_鱗大_鱗4.Hit = value;
			}
		}

		public bool 脚後_下腕鱗_鱗大_鱗3_表示
		{
			get
			{
				return this.X0Y0_脚後_下腕鱗_鱗大_鱗3.Dra;
			}
			set
			{
				this.X0Y0_脚後_下腕鱗_鱗大_鱗3.Dra = value;
				this.X0Y0_脚後_下腕鱗_鱗大_鱗3.Hit = value;
			}
		}

		public bool 脚後_下腕鱗_鱗大_鱗2_表示
		{
			get
			{
				return this.X0Y0_脚後_下腕鱗_鱗大_鱗2.Dra;
			}
			set
			{
				this.X0Y0_脚後_下腕鱗_鱗大_鱗2.Dra = value;
				this.X0Y0_脚後_下腕鱗_鱗大_鱗2.Hit = value;
			}
		}

		public bool 脚後_下腕鱗_鱗大_鱗1_表示
		{
			get
			{
				return this.X0Y0_脚後_下腕鱗_鱗大_鱗1.Dra;
			}
			set
			{
				this.X0Y0_脚後_下腕鱗_鱗大_鱗1.Dra = value;
				this.X0Y0_脚後_下腕鱗_鱗大_鱗1.Hit = value;
			}
		}

		public bool 脚後_上腕鱗_鱗5_表示
		{
			get
			{
				return this.X0Y0_脚後_上腕鱗_鱗5.Dra;
			}
			set
			{
				this.X0Y0_脚後_上腕鱗_鱗5.Dra = value;
				this.X0Y0_脚後_上腕鱗_鱗5.Hit = value;
			}
		}

		public bool 脚後_上腕鱗_鱗4_表示
		{
			get
			{
				return this.X0Y0_脚後_上腕鱗_鱗4.Dra;
			}
			set
			{
				this.X0Y0_脚後_上腕鱗_鱗4.Dra = value;
				this.X0Y0_脚後_上腕鱗_鱗4.Hit = value;
			}
		}

		public bool 脚後_上腕鱗_鱗3_表示
		{
			get
			{
				return this.X0Y0_脚後_上腕鱗_鱗3.Dra;
			}
			set
			{
				this.X0Y0_脚後_上腕鱗_鱗3.Dra = value;
				this.X0Y0_脚後_上腕鱗_鱗3.Hit = value;
			}
		}

		public bool 脚後_上腕鱗_鱗2_表示
		{
			get
			{
				return this.X0Y0_脚後_上腕鱗_鱗2.Dra;
			}
			set
			{
				this.X0Y0_脚後_上腕鱗_鱗2.Dra = value;
				this.X0Y0_脚後_上腕鱗_鱗2.Hit = value;
			}
		}

		public bool 脚後_上腕鱗_鱗1_表示
		{
			get
			{
				return this.X0Y0_脚後_上腕鱗_鱗1.Dra;
			}
			set
			{
				this.X0Y0_脚後_上腕鱗_鱗1.Dra = value;
				this.X0Y0_脚後_上腕鱗_鱗1.Hit = value;
			}
		}

		public bool 脚後_輪_革_表示
		{
			get
			{
				return this.X0Y0_脚後_輪_革.Dra;
			}
			set
			{
				this.X0Y0_脚後_輪_革.Dra = value;
				this.X0Y0_脚後_輪_革.Hit = value;
			}
		}

		public bool 脚後_輪_金具1_表示
		{
			get
			{
				return this.X0Y0_脚後_輪_金具1.Dra;
			}
			set
			{
				this.X0Y0_脚後_輪_金具1.Dra = value;
				this.X0Y0_脚後_輪_金具1.Hit = value;
			}
		}

		public bool 脚後_輪_金具2_表示
		{
			get
			{
				return this.X0Y0_脚後_輪_金具2.Dra;
			}
			set
			{
				this.X0Y0_脚後_輪_金具2.Dra = value;
				this.X0Y0_脚後_輪_金具2.Hit = value;
			}
		}

		public bool 脚後_輪_金具3_表示
		{
			get
			{
				return this.X0Y0_脚後_輪_金具3.Dra;
			}
			set
			{
				this.X0Y0_脚後_輪_金具3.Dra = value;
				this.X0Y0_脚後_輪_金具3.Hit = value;
			}
		}

		public bool 脚後_輪_金具左_表示
		{
			get
			{
				return this.X0Y0_脚後_輪_金具左.Dra;
			}
			set
			{
				this.X0Y0_脚後_輪_金具左.Dra = value;
				this.X0Y0_脚後_輪_金具左.Hit = value;
			}
		}

		public bool 脚後_輪_金具右_表示
		{
			get
			{
				return this.X0Y0_脚後_輪_金具右.Dra;
			}
			set
			{
				this.X0Y0_脚後_輪_金具右.Dra = value;
				this.X0Y0_脚後_輪_金具右.Hit = value;
			}
		}

		public bool 上顎頭部後_頭2_表示
		{
			get
			{
				return this.X0Y0_上顎頭部後_頭2.Dra;
			}
			set
			{
				this.X0Y0_上顎頭部後_頭2.Dra = value;
				this.X0Y0_上顎頭部後_頭2.Hit = value;
			}
		}

		public bool 上顎頭部後_頭1_表示
		{
			get
			{
				return this.X0Y0_上顎頭部後_頭1.Dra;
			}
			set
			{
				this.X0Y0_上顎頭部後_頭1.Dra = value;
				this.X0Y0_上顎頭部後_頭1.Hit = value;
			}
		}

		public bool 下顎頭部後_頭2_表示
		{
			get
			{
				return this.X0Y0_下顎頭部後_頭2.Dra;
			}
			set
			{
				this.X0Y0_下顎頭部後_頭2.Dra = value;
				this.X0Y0_下顎頭部後_頭2.Hit = value;
			}
		}

		public bool 下顎頭部後_頭1_表示
		{
			get
			{
				return this.X0Y0_下顎頭部後_頭1.Dra;
			}
			set
			{
				this.X0Y0_下顎頭部後_頭1.Dra = value;
				this.X0Y0_下顎頭部後_頭1.Hit = value;
			}
		}

		public bool 胴_節1_胴_表示
		{
			get
			{
				return this.X0Y0_胴_節1_胴.Dra;
			}
			set
			{
				this.X0Y0_胴_節1_胴.Dra = value;
				this.X0Y0_胴_節1_胴.Hit = value;
			}
		}

		public bool 胴_節1_鱗1_表示
		{
			get
			{
				return this.X0Y0_胴_節1_鱗1.Dra;
			}
			set
			{
				this.X0Y0_胴_節1_鱗1.Dra = value;
				this.X0Y0_胴_節1_鱗1.Hit = value;
			}
		}

		public bool 胴_節1_鱗3_表示
		{
			get
			{
				return this.X0Y0_胴_節1_鱗3.Dra;
			}
			set
			{
				this.X0Y0_胴_節1_鱗3.Dra = value;
				this.X0Y0_胴_節1_鱗3.Hit = value;
			}
		}

		public bool 胴_節1_鱗2_表示
		{
			get
			{
				return this.X0Y0_胴_節1_鱗2.Dra;
			}
			set
			{
				this.X0Y0_胴_節1_鱗2.Dra = value;
				this.X0Y0_胴_節1_鱗2.Hit = value;
			}
		}

		public bool 胴_節2_胴_表示
		{
			get
			{
				return this.X0Y0_胴_節2_胴.Dra;
			}
			set
			{
				this.X0Y0_胴_節2_胴.Dra = value;
				this.X0Y0_胴_節2_胴.Hit = value;
			}
		}

		public bool 胴_節2_鱗1_表示
		{
			get
			{
				return this.X0Y0_胴_節2_鱗1.Dra;
			}
			set
			{
				this.X0Y0_胴_節2_鱗1.Dra = value;
				this.X0Y0_胴_節2_鱗1.Hit = value;
			}
		}

		public bool 胴_節2_鱗3_表示
		{
			get
			{
				return this.X0Y0_胴_節2_鱗3.Dra;
			}
			set
			{
				this.X0Y0_胴_節2_鱗3.Dra = value;
				this.X0Y0_胴_節2_鱗3.Hit = value;
			}
		}

		public bool 胴_節2_鱗2_表示
		{
			get
			{
				return this.X0Y0_胴_節2_鱗2.Dra;
			}
			set
			{
				this.X0Y0_胴_節2_鱗2.Dra = value;
				this.X0Y0_胴_節2_鱗2.Hit = value;
			}
		}

		public bool 胴_節3_胴_表示
		{
			get
			{
				return this.X0Y0_胴_節3_胴.Dra;
			}
			set
			{
				this.X0Y0_胴_節3_胴.Dra = value;
				this.X0Y0_胴_節3_胴.Hit = value;
			}
		}

		public bool 胴_節3_鱗1_表示
		{
			get
			{
				return this.X0Y0_胴_節3_鱗1.Dra;
			}
			set
			{
				this.X0Y0_胴_節3_鱗1.Dra = value;
				this.X0Y0_胴_節3_鱗1.Hit = value;
			}
		}

		public bool 胴_節3_鱗3_表示
		{
			get
			{
				return this.X0Y0_胴_節3_鱗3.Dra;
			}
			set
			{
				this.X0Y0_胴_節3_鱗3.Dra = value;
				this.X0Y0_胴_節3_鱗3.Hit = value;
			}
		}

		public bool 胴_節3_鱗2_表示
		{
			get
			{
				return this.X0Y0_胴_節3_鱗2.Dra;
			}
			set
			{
				this.X0Y0_胴_節3_鱗2.Dra = value;
				this.X0Y0_胴_節3_鱗2.Hit = value;
			}
		}

		public bool 胴_節4_胴_表示
		{
			get
			{
				return this.X0Y0_胴_節4_胴.Dra;
			}
			set
			{
				this.X0Y0_胴_節4_胴.Dra = value;
				this.X0Y0_胴_節4_胴.Hit = value;
			}
		}

		public bool 胴_節4_鱗1_表示
		{
			get
			{
				return this.X0Y0_胴_節4_鱗1.Dra;
			}
			set
			{
				this.X0Y0_胴_節4_鱗1.Dra = value;
				this.X0Y0_胴_節4_鱗1.Hit = value;
			}
		}

		public bool 胴_節4_鱗3_表示
		{
			get
			{
				return this.X0Y0_胴_節4_鱗3.Dra;
			}
			set
			{
				this.X0Y0_胴_節4_鱗3.Dra = value;
				this.X0Y0_胴_節4_鱗3.Hit = value;
			}
		}

		public bool 胴_節4_鱗2_表示
		{
			get
			{
				return this.X0Y0_胴_節4_鱗2.Dra;
			}
			set
			{
				this.X0Y0_胴_節4_鱗2.Dra = value;
				this.X0Y0_胴_節4_鱗2.Hit = value;
			}
		}

		public bool 胴_節5_胴_表示
		{
			get
			{
				return this.X0Y0_胴_節5_胴.Dra;
			}
			set
			{
				this.X0Y0_胴_節5_胴.Dra = value;
				this.X0Y0_胴_節5_胴.Hit = value;
			}
		}

		public bool 胴_節5_鱗1_表示
		{
			get
			{
				return this.X0Y0_胴_節5_鱗1.Dra;
			}
			set
			{
				this.X0Y0_胴_節5_鱗1.Dra = value;
				this.X0Y0_胴_節5_鱗1.Hit = value;
			}
		}

		public bool 胴_節5_鱗3_表示
		{
			get
			{
				return this.X0Y0_胴_節5_鱗3.Dra;
			}
			set
			{
				this.X0Y0_胴_節5_鱗3.Dra = value;
				this.X0Y0_胴_節5_鱗3.Hit = value;
			}
		}

		public bool 胴_節5_鱗2_表示
		{
			get
			{
				return this.X0Y0_胴_節5_鱗2.Dra;
			}
			set
			{
				this.X0Y0_胴_節5_鱗2.Dra = value;
				this.X0Y0_胴_節5_鱗2.Hit = value;
			}
		}

		public bool 胴_節6_胴_表示
		{
			get
			{
				return this.X0Y0_胴_節6_胴.Dra;
			}
			set
			{
				this.X0Y0_胴_節6_胴.Dra = value;
				this.X0Y0_胴_節6_胴.Hit = value;
			}
		}

		public bool 胴_節6_鱗1_表示
		{
			get
			{
				return this.X0Y0_胴_節6_鱗1.Dra;
			}
			set
			{
				this.X0Y0_胴_節6_鱗1.Dra = value;
				this.X0Y0_胴_節6_鱗1.Hit = value;
			}
		}

		public bool 胴_節6_鱗3_表示
		{
			get
			{
				return this.X0Y0_胴_節6_鱗3.Dra;
			}
			set
			{
				this.X0Y0_胴_節6_鱗3.Dra = value;
				this.X0Y0_胴_節6_鱗3.Hit = value;
			}
		}

		public bool 胴_節6_鱗2_表示
		{
			get
			{
				return this.X0Y0_胴_節6_鱗2.Dra;
			}
			set
			{
				this.X0Y0_胴_節6_鱗2.Dra = value;
				this.X0Y0_胴_節6_鱗2.Hit = value;
			}
		}

		public bool 胴_節7_胴_表示
		{
			get
			{
				return this.X0Y0_胴_節7_胴.Dra;
			}
			set
			{
				this.X0Y0_胴_節7_胴.Dra = value;
				this.X0Y0_胴_節7_胴.Hit = value;
			}
		}

		public bool 胴_節7_鱗1_表示
		{
			get
			{
				return this.X0Y0_胴_節7_鱗1.Dra;
			}
			set
			{
				this.X0Y0_胴_節7_鱗1.Dra = value;
				this.X0Y0_胴_節7_鱗1.Hit = value;
			}
		}

		public bool 胴_節7_鱗3_表示
		{
			get
			{
				return this.X0Y0_胴_節7_鱗3.Dra;
			}
			set
			{
				this.X0Y0_胴_節7_鱗3.Dra = value;
				this.X0Y0_胴_節7_鱗3.Hit = value;
			}
		}

		public bool 胴_節7_鱗2_表示
		{
			get
			{
				return this.X0Y0_胴_節7_鱗2.Dra;
			}
			set
			{
				this.X0Y0_胴_節7_鱗2.Dra = value;
				this.X0Y0_胴_節7_鱗2.Hit = value;
			}
		}

		public bool 胴_節8_胴_表示
		{
			get
			{
				return this.X0Y0_胴_節8_胴.Dra;
			}
			set
			{
				this.X0Y0_胴_節8_胴.Dra = value;
				this.X0Y0_胴_節8_胴.Hit = value;
			}
		}

		public bool 胴_節8_鱗1_表示
		{
			get
			{
				return this.X0Y0_胴_節8_鱗1.Dra;
			}
			set
			{
				this.X0Y0_胴_節8_鱗1.Dra = value;
				this.X0Y0_胴_節8_鱗1.Hit = value;
			}
		}

		public bool 胴_節8_鱗3_表示
		{
			get
			{
				return this.X0Y0_胴_節8_鱗3.Dra;
			}
			set
			{
				this.X0Y0_胴_節8_鱗3.Dra = value;
				this.X0Y0_胴_節8_鱗3.Hit = value;
			}
		}

		public bool 胴_節8_鱗2_表示
		{
			get
			{
				return this.X0Y0_胴_節8_鱗2.Dra;
			}
			set
			{
				this.X0Y0_胴_節8_鱗2.Dra = value;
				this.X0Y0_胴_節8_鱗2.Hit = value;
			}
		}

		public bool 胴_節9_胴_表示
		{
			get
			{
				return this.X0Y0_胴_節9_胴.Dra;
			}
			set
			{
				this.X0Y0_胴_節9_胴.Dra = value;
				this.X0Y0_胴_節9_胴.Hit = value;
			}
		}

		public bool 胴_節9_鱗1_表示
		{
			get
			{
				return this.X0Y0_胴_節9_鱗1.Dra;
			}
			set
			{
				this.X0Y0_胴_節9_鱗1.Dra = value;
				this.X0Y0_胴_節9_鱗1.Hit = value;
			}
		}

		public bool 胴_節9_鱗3_表示
		{
			get
			{
				return this.X0Y0_胴_節9_鱗3.Dra;
			}
			set
			{
				this.X0Y0_胴_節9_鱗3.Dra = value;
				this.X0Y0_胴_節9_鱗3.Hit = value;
			}
		}

		public bool 胴_節9_鱗2_表示
		{
			get
			{
				return this.X0Y0_胴_節9_鱗2.Dra;
			}
			set
			{
				this.X0Y0_胴_節9_鱗2.Dra = value;
				this.X0Y0_胴_節9_鱗2.Hit = value;
			}
		}

		public bool 胴_節10_胴_表示
		{
			get
			{
				return this.X0Y0_胴_節10_胴.Dra;
			}
			set
			{
				this.X0Y0_胴_節10_胴.Dra = value;
				this.X0Y0_胴_節10_胴.Hit = value;
			}
		}

		public bool 胴_節10_鱗1_表示
		{
			get
			{
				return this.X0Y0_胴_節10_鱗1.Dra;
			}
			set
			{
				this.X0Y0_胴_節10_鱗1.Dra = value;
				this.X0Y0_胴_節10_鱗1.Hit = value;
			}
		}

		public bool 胴_節10_鱗3_表示
		{
			get
			{
				return this.X0Y0_胴_節10_鱗3.Dra;
			}
			set
			{
				this.X0Y0_胴_節10_鱗3.Dra = value;
				this.X0Y0_胴_節10_鱗3.Hit = value;
			}
		}

		public bool 胴_節10_鱗2_表示
		{
			get
			{
				return this.X0Y0_胴_節10_鱗2.Dra;
			}
			set
			{
				this.X0Y0_胴_節10_鱗2.Dra = value;
				this.X0Y0_胴_節10_鱗2.Hit = value;
			}
		}

		public bool 胴_節11_胴_表示
		{
			get
			{
				return this.X0Y0_胴_節11_胴.Dra;
			}
			set
			{
				this.X0Y0_胴_節11_胴.Dra = value;
				this.X0Y0_胴_節11_胴.Hit = value;
			}
		}

		public bool 胴_節11_鱗1_表示
		{
			get
			{
				return this.X0Y0_胴_節11_鱗1.Dra;
			}
			set
			{
				this.X0Y0_胴_節11_鱗1.Dra = value;
				this.X0Y0_胴_節11_鱗1.Hit = value;
			}
		}

		public bool 胴_節11_鱗3_表示
		{
			get
			{
				return this.X0Y0_胴_節11_鱗3.Dra;
			}
			set
			{
				this.X0Y0_胴_節11_鱗3.Dra = value;
				this.X0Y0_胴_節11_鱗3.Hit = value;
			}
		}

		public bool 胴_節11_鱗2_表示
		{
			get
			{
				return this.X0Y0_胴_節11_鱗2.Dra;
			}
			set
			{
				this.X0Y0_胴_節11_鱗2.Dra = value;
				this.X0Y0_胴_節11_鱗2.Hit = value;
			}
		}

		public bool 胴_節12_胴_表示
		{
			get
			{
				return this.X0Y0_胴_節12_胴.Dra;
			}
			set
			{
				this.X0Y0_胴_節12_胴.Dra = value;
				this.X0Y0_胴_節12_胴.Hit = value;
			}
		}

		public bool 胴_節12_鱗1_表示
		{
			get
			{
				return this.X0Y0_胴_節12_鱗1.Dra;
			}
			set
			{
				this.X0Y0_胴_節12_鱗1.Dra = value;
				this.X0Y0_胴_節12_鱗1.Hit = value;
			}
		}

		public bool 胴_節12_鱗3_表示
		{
			get
			{
				return this.X0Y0_胴_節12_鱗3.Dra;
			}
			set
			{
				this.X0Y0_胴_節12_鱗3.Dra = value;
				this.X0Y0_胴_節12_鱗3.Hit = value;
			}
		}

		public bool 胴_節12_鱗2_表示
		{
			get
			{
				return this.X0Y0_胴_節12_鱗2.Dra;
			}
			set
			{
				this.X0Y0_胴_節12_鱗2.Dra = value;
				this.X0Y0_胴_節12_鱗2.Hit = value;
			}
		}

		public bool 胴_節13_胴_表示
		{
			get
			{
				return this.X0Y0_胴_節13_胴.Dra;
			}
			set
			{
				this.X0Y0_胴_節13_胴.Dra = value;
				this.X0Y0_胴_節13_胴.Hit = value;
			}
		}

		public bool 胴_節13_鱗1_表示
		{
			get
			{
				return this.X0Y0_胴_節13_鱗1.Dra;
			}
			set
			{
				this.X0Y0_胴_節13_鱗1.Dra = value;
				this.X0Y0_胴_節13_鱗1.Hit = value;
			}
		}

		public bool 胴_節13_鱗3_表示
		{
			get
			{
				return this.X0Y0_胴_節13_鱗3.Dra;
			}
			set
			{
				this.X0Y0_胴_節13_鱗3.Dra = value;
				this.X0Y0_胴_節13_鱗3.Hit = value;
			}
		}

		public bool 胴_節13_鱗2_表示
		{
			get
			{
				return this.X0Y0_胴_節13_鱗2.Dra;
			}
			set
			{
				this.X0Y0_胴_節13_鱗2.Dra = value;
				this.X0Y0_胴_節13_鱗2.Hit = value;
			}
		}

		public bool 胴_節14_胴_表示
		{
			get
			{
				return this.X0Y0_胴_節14_胴.Dra;
			}
			set
			{
				this.X0Y0_胴_節14_胴.Dra = value;
				this.X0Y0_胴_節14_胴.Hit = value;
			}
		}

		public bool 胴_節14_鱗1_表示
		{
			get
			{
				return this.X0Y0_胴_節14_鱗1.Dra;
			}
			set
			{
				this.X0Y0_胴_節14_鱗1.Dra = value;
				this.X0Y0_胴_節14_鱗1.Hit = value;
			}
		}

		public bool 胴_節14_鱗3_表示
		{
			get
			{
				return this.X0Y0_胴_節14_鱗3.Dra;
			}
			set
			{
				this.X0Y0_胴_節14_鱗3.Dra = value;
				this.X0Y0_胴_節14_鱗3.Hit = value;
			}
		}

		public bool 胴_節14_鱗2_表示
		{
			get
			{
				return this.X0Y0_胴_節14_鱗2.Dra;
			}
			set
			{
				this.X0Y0_胴_節14_鱗2.Dra = value;
				this.X0Y0_胴_節14_鱗2.Hit = value;
			}
		}

		public bool 胴_節15_胴_表示
		{
			get
			{
				return this.X0Y0_胴_節15_胴.Dra;
			}
			set
			{
				this.X0Y0_胴_節15_胴.Dra = value;
				this.X0Y0_胴_節15_胴.Hit = value;
			}
		}

		public bool 胴_節15_鱗1_表示
		{
			get
			{
				return this.X0Y0_胴_節15_鱗1.Dra;
			}
			set
			{
				this.X0Y0_胴_節15_鱗1.Dra = value;
				this.X0Y0_胴_節15_鱗1.Hit = value;
			}
		}

		public bool 胴_節15_鱗3_表示
		{
			get
			{
				return this.X0Y0_胴_節15_鱗3.Dra;
			}
			set
			{
				this.X0Y0_胴_節15_鱗3.Dra = value;
				this.X0Y0_胴_節15_鱗3.Hit = value;
			}
		}

		public bool 胴_節15_鱗2_表示
		{
			get
			{
				return this.X0Y0_胴_節15_鱗2.Dra;
			}
			set
			{
				this.X0Y0_胴_節15_鱗2.Dra = value;
				this.X0Y0_胴_節15_鱗2.Hit = value;
			}
		}

		public bool 胴_節16_胴_表示
		{
			get
			{
				return this.X0Y0_胴_節16_胴.Dra;
			}
			set
			{
				this.X0Y0_胴_節16_胴.Dra = value;
				this.X0Y0_胴_節16_胴.Hit = value;
			}
		}

		public bool 胴_節16_鱗1_表示
		{
			get
			{
				return this.X0Y0_胴_節16_鱗1.Dra;
			}
			set
			{
				this.X0Y0_胴_節16_鱗1.Dra = value;
				this.X0Y0_胴_節16_鱗1.Hit = value;
			}
		}

		public bool 胴_節16_鱗3_表示
		{
			get
			{
				return this.X0Y0_胴_節16_鱗3.Dra;
			}
			set
			{
				this.X0Y0_胴_節16_鱗3.Dra = value;
				this.X0Y0_胴_節16_鱗3.Hit = value;
			}
		}

		public bool 胴_節16_鱗2_表示
		{
			get
			{
				return this.X0Y0_胴_節16_鱗2.Dra;
			}
			set
			{
				this.X0Y0_胴_節16_鱗2.Dra = value;
				this.X0Y0_胴_節16_鱗2.Hit = value;
			}
		}

		public bool 胴_輪_革_表示
		{
			get
			{
				return this.X0Y0_胴_輪_革.Dra;
			}
			set
			{
				this.X0Y0_胴_輪_革.Dra = value;
				this.X0Y0_胴_輪_革.Hit = value;
			}
		}

		public bool 胴_輪_金具1_表示
		{
			get
			{
				return this.X0Y0_胴_輪_金具1.Dra;
			}
			set
			{
				this.X0Y0_胴_輪_金具1.Dra = value;
				this.X0Y0_胴_輪_金具1.Hit = value;
			}
		}

		public bool 胴_輪_金具2_表示
		{
			get
			{
				return this.X0Y0_胴_輪_金具2.Dra;
			}
			set
			{
				this.X0Y0_胴_輪_金具2.Dra = value;
				this.X0Y0_胴_輪_金具2.Hit = value;
			}
		}

		public bool 胴_輪_金具3_表示
		{
			get
			{
				return this.X0Y0_胴_輪_金具3.Dra;
			}
			set
			{
				this.X0Y0_胴_輪_金具3.Dra = value;
				this.X0Y0_胴_輪_金具3.Hit = value;
			}
		}

		public bool 胴_輪_金具左_表示
		{
			get
			{
				return this.X0Y0_胴_輪_金具左.Dra;
			}
			set
			{
				this.X0Y0_胴_輪_金具左.Dra = value;
				this.X0Y0_胴_輪_金具左.Hit = value;
			}
		}

		public bool 胴_輪_金具右_表示
		{
			get
			{
				return this.X0Y0_胴_輪_金具右.Dra;
			}
			set
			{
				this.X0Y0_胴_輪_金具右.Dra = value;
				this.X0Y0_胴_輪_金具右.Hit = value;
			}
		}

		public bool 胴_節17_胴_表示
		{
			get
			{
				return this.X0Y0_胴_節17_胴.Dra;
			}
			set
			{
				this.X0Y0_胴_節17_胴.Dra = value;
				this.X0Y0_胴_節17_胴.Hit = value;
			}
		}

		public bool 胴_節17_鱗1_表示
		{
			get
			{
				return this.X0Y0_胴_節17_鱗1.Dra;
			}
			set
			{
				this.X0Y0_胴_節17_鱗1.Dra = value;
				this.X0Y0_胴_節17_鱗1.Hit = value;
			}
		}

		public bool 胴_節17_鱗3_表示
		{
			get
			{
				return this.X0Y0_胴_節17_鱗3.Dra;
			}
			set
			{
				this.X0Y0_胴_節17_鱗3.Dra = value;
				this.X0Y0_胴_節17_鱗3.Hit = value;
			}
		}

		public bool 胴_節17_鱗2_表示
		{
			get
			{
				return this.X0Y0_胴_節17_鱗2.Dra;
			}
			set
			{
				this.X0Y0_胴_節17_鱗2.Dra = value;
				this.X0Y0_胴_節17_鱗2.Hit = value;
			}
		}

		public bool 胴_節18_胴_表示
		{
			get
			{
				return this.X0Y0_胴_節18_胴.Dra;
			}
			set
			{
				this.X0Y0_胴_節18_胴.Dra = value;
				this.X0Y0_胴_節18_胴.Hit = value;
			}
		}

		public bool 胴_節18_鱗1_表示
		{
			get
			{
				return this.X0Y0_胴_節18_鱗1.Dra;
			}
			set
			{
				this.X0Y0_胴_節18_鱗1.Dra = value;
				this.X0Y0_胴_節18_鱗1.Hit = value;
			}
		}

		public bool 胴_節18_鱗3_表示
		{
			get
			{
				return this.X0Y0_胴_節18_鱗3.Dra;
			}
			set
			{
				this.X0Y0_胴_節18_鱗3.Dra = value;
				this.X0Y0_胴_節18_鱗3.Hit = value;
			}
		}

		public bool 胴_節18_鱗2_表示
		{
			get
			{
				return this.X0Y0_胴_節18_鱗2.Dra;
			}
			set
			{
				this.X0Y0_胴_節18_鱗2.Dra = value;
				this.X0Y0_胴_節18_鱗2.Hit = value;
			}
		}

		public bool 頭_口膜_口膜1_表示
		{
			get
			{
				return this.X0Y0_頭_口膜_口膜1.Dra;
			}
			set
			{
				this.X0Y0_頭_口膜_口膜1.Dra = value;
				this.X0Y0_頭_口膜_口膜1.Hit = value;
			}
		}

		public bool 頭_口膜_口膜2_表示
		{
			get
			{
				return this.X0Y0_頭_口膜_口膜2.Dra;
			}
			set
			{
				this.X0Y0_頭_口膜_口膜2.Dra = value;
				this.X0Y0_頭_口膜_口膜2.Hit = value;
			}
		}

		public bool 頭_口膜_口膜3_表示
		{
			get
			{
				return this.X0Y0_頭_口膜_口膜3.Dra;
			}
			set
			{
				this.X0Y0_頭_口膜_口膜3.Dra = value;
				this.X0Y0_頭_口膜_口膜3.Hit = value;
			}
		}

		public bool 頭_口膜_口膜4_表示
		{
			get
			{
				return this.X0Y0_頭_口膜_口膜4.Dra;
			}
			set
			{
				this.X0Y0_頭_口膜_口膜4.Dra = value;
				this.X0Y0_頭_口膜_口膜4.Hit = value;
			}
		}

		public bool 頭_口膜_口膜5_表示
		{
			get
			{
				return this.X0Y0_頭_口膜_口膜5.Dra;
			}
			set
			{
				this.X0Y0_頭_口膜_口膜5.Dra = value;
				this.X0Y0_頭_口膜_口膜5.Hit = value;
			}
		}

		public bool 頭_口膜_口膜6_表示
		{
			get
			{
				return this.X0Y0_頭_口膜_口膜6.Dra;
			}
			set
			{
				this.X0Y0_頭_口膜_口膜6.Dra = value;
				this.X0Y0_頭_口膜_口膜6.Hit = value;
			}
		}

		public bool 頭_口膜_口膜7_表示
		{
			get
			{
				return this.X0Y0_頭_口膜_口膜7.Dra;
			}
			set
			{
				this.X0Y0_頭_口膜_口膜7.Dra = value;
				this.X0Y0_頭_口膜_口膜7.Hit = value;
			}
		}

		public bool 頭_口膜_口膜8_表示
		{
			get
			{
				return this.X0Y0_頭_口膜_口膜8.Dra;
			}
			set
			{
				this.X0Y0_頭_口膜_口膜8.Dra = value;
				this.X0Y0_頭_口膜_口膜8.Hit = value;
			}
		}

		public bool 頭_上顎歯後_歯1_表示
		{
			get
			{
				return this.X0Y0_頭_上顎歯後_歯1.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎歯後_歯1.Dra = value;
				this.X0Y0_頭_上顎歯後_歯1.Hit = value;
			}
		}

		public bool 頭_上顎歯後_歯2_表示
		{
			get
			{
				return this.X0Y0_頭_上顎歯後_歯2.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎歯後_歯2.Dra = value;
				this.X0Y0_頭_上顎歯後_歯2.Hit = value;
			}
		}

		public bool 頭_上顎歯後_歯3_表示
		{
			get
			{
				return this.X0Y0_頭_上顎歯後_歯3.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎歯後_歯3.Dra = value;
				this.X0Y0_頭_上顎歯後_歯3.Hit = value;
			}
		}

		public bool 頭_下顎_歯_後_歯1_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_歯_後_歯1.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_歯_後_歯1.Dra = value;
				this.X0Y0_頭_下顎_歯_後_歯1.Hit = value;
			}
		}

		public bool 頭_下顎_歯_後_歯2_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_歯_後_歯2.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_歯_後_歯2.Dra = value;
				this.X0Y0_頭_下顎_歯_後_歯2.Hit = value;
			}
		}

		public bool 頭_下顎_歯_後_歯3_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_歯_後_歯3.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_歯_後_歯3.Dra = value;
				this.X0Y0_頭_下顎_歯_後_歯3.Hit = value;
			}
		}

		public bool 頭_下顎_歯_前_歯1_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_歯_前_歯1.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_歯_前_歯1.Dra = value;
				this.X0Y0_頭_下顎_歯_前_歯1.Hit = value;
			}
		}

		public bool 頭_下顎_歯_前_歯2_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_歯_前_歯2.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_歯_前_歯2.Dra = value;
				this.X0Y0_頭_下顎_歯_前_歯2.Hit = value;
			}
		}

		public bool 頭_下顎_歯_前_歯3_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_歯_前_歯3.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_歯_前_歯3.Dra = value;
				this.X0Y0_頭_下顎_歯_前_歯3.Hit = value;
			}
		}

		public bool 頭_下顎_眼孔1_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_眼孔1.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_眼孔1.Dra = value;
				this.X0Y0_頭_下顎_眼孔1.Hit = value;
			}
		}

		public bool 頭_下顎_眼孔2_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_眼孔2.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_眼孔2.Dra = value;
				this.X0Y0_頭_下顎_眼孔2.Hit = value;
			}
		}

		public bool 頭_下顎_眼_眼1_眼2_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_眼_眼1_眼2.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_眼_眼1_眼2.Dra = value;
				this.X0Y0_頭_下顎_眼_眼1_眼2.Hit = value;
			}
		}

		public bool 頭_下顎_眼_眼1_眼1_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_眼_眼1_眼1.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_眼_眼1_眼1.Dra = value;
				this.X0Y0_頭_下顎_眼_眼1_眼1.Hit = value;
			}
		}

		public bool 頭_下顎_眼_眼2_眼2_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_眼_眼2_眼2.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_眼_眼2_眼2.Dra = value;
				this.X0Y0_頭_下顎_眼_眼2_眼2.Hit = value;
			}
		}

		public bool 頭_下顎_眼_眼2_眼1_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_眼_眼2_眼1.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_眼_眼2_眼1.Dra = value;
				this.X0Y0_頭_下顎_眼_眼2_眼1.Hit = value;
			}
		}

		public bool 頭_下顎_眼下_眼下_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_眼下_眼下.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_眼下_眼下.Dra = value;
				this.X0Y0_頭_下顎_眼下_眼下.Hit = value;
			}
		}

		public bool 頭_下顎_眼下_線_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_眼下_線.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_眼下_線.Dra = value;
				this.X0Y0_頭_下顎_眼下_線.Hit = value;
			}
		}

		public bool 頭_下顎_頭部_前_頭9_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_頭部_前_頭9.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_頭部_前_頭9.Dra = value;
				this.X0Y0_頭_下顎_頭部_前_頭9.Hit = value;
			}
		}

		public bool 頭_下顎_頭部_前_頭8_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_頭部_前_頭8.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_頭部_前_頭8.Dra = value;
				this.X0Y0_頭_下顎_頭部_前_頭8.Hit = value;
			}
		}

		public bool 頭_下顎_頭部_前_頭7_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_頭部_前_頭7.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_頭部_前_頭7.Dra = value;
				this.X0Y0_頭_下顎_頭部_前_頭7.Hit = value;
			}
		}

		public bool 頭_下顎_頭部_前_頭6_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_頭部_前_頭6.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_頭部_前_頭6.Dra = value;
				this.X0Y0_頭_下顎_頭部_前_頭6.Hit = value;
			}
		}

		public bool 頭_下顎_頭部_前_頭5_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_頭部_前_頭5.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_頭部_前_頭5.Dra = value;
				this.X0Y0_頭_下顎_頭部_前_頭5.Hit = value;
			}
		}

		public bool 頭_下顎_頭部_前_頭4_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_頭部_前_頭4.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_頭部_前_頭4.Dra = value;
				this.X0Y0_頭_下顎_頭部_前_頭4.Hit = value;
			}
		}

		public bool 頭_下顎_頭部_前_頭3_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_頭部_前_頭3.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_頭部_前_頭3.Dra = value;
				this.X0Y0_頭_下顎_頭部_前_頭3.Hit = value;
			}
		}

		public bool 頭_下顎_頭部_前_頭2_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_頭部_前_頭2.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_頭部_前_頭2.Dra = value;
				this.X0Y0_頭_下顎_頭部_前_頭2.Hit = value;
			}
		}

		public bool 頭_下顎_頭部_前_頭1_表示
		{
			get
			{
				return this.X0Y0_頭_下顎_頭部_前_頭1.Dra;
			}
			set
			{
				this.X0Y0_頭_下顎_頭部_前_頭1.Dra = value;
				this.X0Y0_頭_下顎_頭部_前_頭1.Hit = value;
			}
		}

		public bool 頭_上顎_歯_前_歯1_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_歯_前_歯1.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_歯_前_歯1.Dra = value;
				this.X0Y0_頭_上顎_歯_前_歯1.Hit = value;
			}
		}

		public bool 頭_上顎_歯_前_歯2_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_歯_前_歯2.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_歯_前_歯2.Dra = value;
				this.X0Y0_頭_上顎_歯_前_歯2.Hit = value;
			}
		}

		public bool 頭_上顎_歯_前_歯3_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_歯_前_歯3.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_歯_前_歯3.Dra = value;
				this.X0Y0_頭_上顎_歯_前_歯3.Hit = value;
			}
		}

		public bool 頭_上顎_眼孔1_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_眼孔1.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_眼孔1.Dra = value;
				this.X0Y0_頭_上顎_眼孔1.Hit = value;
			}
		}

		public bool 頭_上顎_眼孔2_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_眼孔2.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_眼孔2.Dra = value;
				this.X0Y0_頭_上顎_眼孔2.Hit = value;
			}
		}

		public bool 頭_上顎_眼_眼1_眼2_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_眼_眼1_眼2.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_眼_眼1_眼2.Dra = value;
				this.X0Y0_頭_上顎_眼_眼1_眼2.Hit = value;
			}
		}

		public bool 頭_上顎_眼_眼1_眼1_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_眼_眼1_眼1.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_眼_眼1_眼1.Dra = value;
				this.X0Y0_頭_上顎_眼_眼1_眼1.Hit = value;
			}
		}

		public bool 頭_上顎_眼_眼2_眼2_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_眼_眼2_眼2.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_眼_眼2_眼2.Dra = value;
				this.X0Y0_頭_上顎_眼_眼2_眼2.Hit = value;
			}
		}

		public bool 頭_上顎_眼_眼2_眼1_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_眼_眼2_眼1.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_眼_眼2_眼1.Dra = value;
				this.X0Y0_頭_上顎_眼_眼2_眼1.Hit = value;
			}
		}

		public bool 頭_上顎_眼下_眼下_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_眼下_眼下.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_眼下_眼下.Dra = value;
				this.X0Y0_頭_上顎_眼下_眼下.Hit = value;
			}
		}

		public bool 頭_上顎_眼下_線_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_眼下_線.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_眼下_線.Dra = value;
				this.X0Y0_頭_上顎_眼下_線.Hit = value;
			}
		}

		public bool 頭_上顎_頭部_前_頭9_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_頭部_前_頭9.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_頭部_前_頭9.Dra = value;
				this.X0Y0_頭_上顎_頭部_前_頭9.Hit = value;
			}
		}

		public bool 頭_上顎_頭部_前_頭8_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_頭部_前_頭8.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_頭部_前_頭8.Dra = value;
				this.X0Y0_頭_上顎_頭部_前_頭8.Hit = value;
			}
		}

		public bool 頭_上顎_頭部_前_頭7_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_頭部_前_頭7.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_頭部_前_頭7.Dra = value;
				this.X0Y0_頭_上顎_頭部_前_頭7.Hit = value;
			}
		}

		public bool 頭_上顎_頭部_前_頭6_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_頭部_前_頭6.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_頭部_前_頭6.Dra = value;
				this.X0Y0_頭_上顎_頭部_前_頭6.Hit = value;
			}
		}

		public bool 頭_上顎_頭部_前_頭5_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_頭部_前_頭5.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_頭部_前_頭5.Dra = value;
				this.X0Y0_頭_上顎_頭部_前_頭5.Hit = value;
			}
		}

		public bool 頭_上顎_頭部_前_頭4_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_頭部_前_頭4.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_頭部_前_頭4.Dra = value;
				this.X0Y0_頭_上顎_頭部_前_頭4.Hit = value;
			}
		}

		public bool 頭_上顎_頭部_前_頭3_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_頭部_前_頭3.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_頭部_前_頭3.Dra = value;
				this.X0Y0_頭_上顎_頭部_前_頭3.Hit = value;
			}
		}

		public bool 頭_上顎_頭部_前_頭2_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_頭部_前_頭2.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_頭部_前_頭2.Dra = value;
				this.X0Y0_頭_上顎_頭部_前_頭2.Hit = value;
			}
		}

		public bool 頭_上顎_頭部_前_頭1_表示
		{
			get
			{
				return this.X0Y0_頭_上顎_頭部_前_頭1.Dra;
			}
			set
			{
				this.X0Y0_頭_上顎_頭部_前_頭1.Dra = value;
				this.X0Y0_頭_上顎_頭部_前_頭1.Hit = value;
			}
		}

		public bool 頭_輪_革_表示
		{
			get
			{
				return this.X0Y0_頭_輪_革.Dra;
			}
			set
			{
				this.X0Y0_頭_輪_革.Dra = value;
				this.X0Y0_頭_輪_革.Hit = value;
			}
		}

		public bool 頭_輪_金具1_表示
		{
			get
			{
				return this.X0Y0_頭_輪_金具1.Dra;
			}
			set
			{
				this.X0Y0_頭_輪_金具1.Dra = value;
				this.X0Y0_頭_輪_金具1.Hit = value;
			}
		}

		public bool 頭_輪_金具2_表示
		{
			get
			{
				return this.X0Y0_頭_輪_金具2.Dra;
			}
			set
			{
				this.X0Y0_頭_輪_金具2.Dra = value;
				this.X0Y0_頭_輪_金具2.Hit = value;
			}
		}

		public bool 頭_輪_金具3_表示
		{
			get
			{
				return this.X0Y0_頭_輪_金具3.Dra;
			}
			set
			{
				this.X0Y0_頭_輪_金具3.Dra = value;
				this.X0Y0_頭_輪_金具3.Hit = value;
			}
		}

		public bool 頭_輪_金具左_表示
		{
			get
			{
				return this.X0Y0_頭_輪_金具左.Dra;
			}
			set
			{
				this.X0Y0_頭_輪_金具左.Dra = value;
				this.X0Y0_頭_輪_金具左.Hit = value;
			}
		}

		public bool 頭_輪_金具右_表示
		{
			get
			{
				return this.X0Y0_頭_輪_金具右.Dra;
			}
			set
			{
				this.X0Y0_頭_輪_金具右.Dra = value;
				this.X0Y0_頭_輪_金具右.Hit = value;
			}
		}

		public bool 脚前_上腕_表示
		{
			get
			{
				return this.X0Y0_脚前_上腕.Dra;
			}
			set
			{
				this.X0Y0_脚前_上腕.Dra = value;
				this.X0Y0_脚前_上腕.Hit = value;
			}
		}

		public bool 脚前_下腕_表示
		{
			get
			{
				return this.X0Y0_脚前_下腕.Dra;
			}
			set
			{
				this.X0Y0_脚前_下腕.Dra = value;
				this.X0Y0_脚前_下腕.Hit = value;
			}
		}

		public bool 脚前_手_親指_爪_表示
		{
			get
			{
				return this.X0Y0_脚前_手_親指_爪.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_親指_爪.Dra = value;
				this.X0Y0_脚前_手_親指_爪.Hit = value;
			}
		}

		public bool 脚前_手_手_表示
		{
			get
			{
				return this.X0Y0_脚前_手_手.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_手.Dra = value;
				this.X0Y0_脚前_手_手.Hit = value;
			}
		}

		public bool 脚前_手_人指_指_表示
		{
			get
			{
				return this.X0Y0_脚前_手_人指_指.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_人指_指.Dra = value;
				this.X0Y0_脚前_手_人指_指.Hit = value;
			}
		}

		public bool 脚前_手_人指_爪_表示
		{
			get
			{
				return this.X0Y0_脚前_手_人指_爪.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_人指_爪.Dra = value;
				this.X0Y0_脚前_手_人指_爪.Hit = value;
			}
		}

		public bool 脚前_手_人指_水掻_表示
		{
			get
			{
				return this.X0Y0_脚前_手_人指_水掻.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_人指_水掻.Dra = value;
				this.X0Y0_脚前_手_人指_水掻.Hit = value;
			}
		}

		public bool 脚前_手_人指_鱗_鱗4_表示
		{
			get
			{
				return this.X0Y0_脚前_手_人指_鱗_鱗4.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_人指_鱗_鱗4.Dra = value;
				this.X0Y0_脚前_手_人指_鱗_鱗4.Hit = value;
			}
		}

		public bool 脚前_手_人指_鱗_鱗3_表示
		{
			get
			{
				return this.X0Y0_脚前_手_人指_鱗_鱗3.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_人指_鱗_鱗3.Dra = value;
				this.X0Y0_脚前_手_人指_鱗_鱗3.Hit = value;
			}
		}

		public bool 脚前_手_人指_鱗_鱗2_表示
		{
			get
			{
				return this.X0Y0_脚前_手_人指_鱗_鱗2.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_人指_鱗_鱗2.Dra = value;
				this.X0Y0_脚前_手_人指_鱗_鱗2.Hit = value;
			}
		}

		public bool 脚前_手_人指_鱗_鱗1_表示
		{
			get
			{
				return this.X0Y0_脚前_手_人指_鱗_鱗1.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_人指_鱗_鱗1.Dra = value;
				this.X0Y0_脚前_手_人指_鱗_鱗1.Hit = value;
			}
		}

		public bool 脚前_手_中指_指_表示
		{
			get
			{
				return this.X0Y0_脚前_手_中指_指.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_中指_指.Dra = value;
				this.X0Y0_脚前_手_中指_指.Hit = value;
			}
		}

		public bool 脚前_手_中指_爪_表示
		{
			get
			{
				return this.X0Y0_脚前_手_中指_爪.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_中指_爪.Dra = value;
				this.X0Y0_脚前_手_中指_爪.Hit = value;
			}
		}

		public bool 脚前_手_中指_水掻_表示
		{
			get
			{
				return this.X0Y0_脚前_手_中指_水掻.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_中指_水掻.Dra = value;
				this.X0Y0_脚前_手_中指_水掻.Hit = value;
			}
		}

		public bool 脚前_手_中指_鱗_鱗4_表示
		{
			get
			{
				return this.X0Y0_脚前_手_中指_鱗_鱗4.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_中指_鱗_鱗4.Dra = value;
				this.X0Y0_脚前_手_中指_鱗_鱗4.Hit = value;
			}
		}

		public bool 脚前_手_中指_鱗_鱗3_表示
		{
			get
			{
				return this.X0Y0_脚前_手_中指_鱗_鱗3.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_中指_鱗_鱗3.Dra = value;
				this.X0Y0_脚前_手_中指_鱗_鱗3.Hit = value;
			}
		}

		public bool 脚前_手_中指_鱗_鱗2_表示
		{
			get
			{
				return this.X0Y0_脚前_手_中指_鱗_鱗2.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_中指_鱗_鱗2.Dra = value;
				this.X0Y0_脚前_手_中指_鱗_鱗2.Hit = value;
			}
		}

		public bool 脚前_手_中指_鱗_鱗1_表示
		{
			get
			{
				return this.X0Y0_脚前_手_中指_鱗_鱗1.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_中指_鱗_鱗1.Dra = value;
				this.X0Y0_脚前_手_中指_鱗_鱗1.Hit = value;
			}
		}

		public bool 脚前_手_薬指_指_表示
		{
			get
			{
				return this.X0Y0_脚前_手_薬指_指.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_薬指_指.Dra = value;
				this.X0Y0_脚前_手_薬指_指.Hit = value;
			}
		}

		public bool 脚前_手_薬指_爪_表示
		{
			get
			{
				return this.X0Y0_脚前_手_薬指_爪.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_薬指_爪.Dra = value;
				this.X0Y0_脚前_手_薬指_爪.Hit = value;
			}
		}

		public bool 脚前_手_薬指_水掻_表示
		{
			get
			{
				return this.X0Y0_脚前_手_薬指_水掻.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_薬指_水掻.Dra = value;
				this.X0Y0_脚前_手_薬指_水掻.Hit = value;
			}
		}

		public bool 脚前_手_薬指_鱗_鱗4_表示
		{
			get
			{
				return this.X0Y0_脚前_手_薬指_鱗_鱗4.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_薬指_鱗_鱗4.Dra = value;
				this.X0Y0_脚前_手_薬指_鱗_鱗4.Hit = value;
			}
		}

		public bool 脚前_手_薬指_鱗_鱗3_表示
		{
			get
			{
				return this.X0Y0_脚前_手_薬指_鱗_鱗3.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_薬指_鱗_鱗3.Dra = value;
				this.X0Y0_脚前_手_薬指_鱗_鱗3.Hit = value;
			}
		}

		public bool 脚前_手_薬指_鱗_鱗2_表示
		{
			get
			{
				return this.X0Y0_脚前_手_薬指_鱗_鱗2.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_薬指_鱗_鱗2.Dra = value;
				this.X0Y0_脚前_手_薬指_鱗_鱗2.Hit = value;
			}
		}

		public bool 脚前_手_薬指_鱗_鱗1_表示
		{
			get
			{
				return this.X0Y0_脚前_手_薬指_鱗_鱗1.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_薬指_鱗_鱗1.Dra = value;
				this.X0Y0_脚前_手_薬指_鱗_鱗1.Hit = value;
			}
		}

		public bool 脚前_手_小指_指_表示
		{
			get
			{
				return this.X0Y0_脚前_手_小指_指.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_小指_指.Dra = value;
				this.X0Y0_脚前_手_小指_指.Hit = value;
			}
		}

		public bool 脚前_手_小指_爪_表示
		{
			get
			{
				return this.X0Y0_脚前_手_小指_爪.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_小指_爪.Dra = value;
				this.X0Y0_脚前_手_小指_爪.Hit = value;
			}
		}

		public bool 脚前_手_小指_鱗_鱗4_表示
		{
			get
			{
				return this.X0Y0_脚前_手_小指_鱗_鱗4.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_小指_鱗_鱗4.Dra = value;
				this.X0Y0_脚前_手_小指_鱗_鱗4.Hit = value;
			}
		}

		public bool 脚前_手_小指_鱗_鱗3_表示
		{
			get
			{
				return this.X0Y0_脚前_手_小指_鱗_鱗3.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_小指_鱗_鱗3.Dra = value;
				this.X0Y0_脚前_手_小指_鱗_鱗3.Hit = value;
			}
		}

		public bool 脚前_手_小指_鱗_鱗2_表示
		{
			get
			{
				return this.X0Y0_脚前_手_小指_鱗_鱗2.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_小指_鱗_鱗2.Dra = value;
				this.X0Y0_脚前_手_小指_鱗_鱗2.Hit = value;
			}
		}

		public bool 脚前_手_小指_鱗_鱗1_表示
		{
			get
			{
				return this.X0Y0_脚前_手_小指_鱗_鱗1.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_小指_鱗_鱗1.Dra = value;
				this.X0Y0_脚前_手_小指_鱗_鱗1.Hit = value;
			}
		}

		public bool 脚前_手_鱗_鱗3_表示
		{
			get
			{
				return this.X0Y0_脚前_手_鱗_鱗3.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_鱗_鱗3.Dra = value;
				this.X0Y0_脚前_手_鱗_鱗3.Hit = value;
			}
		}

		public bool 脚前_手_鱗_鱗2_表示
		{
			get
			{
				return this.X0Y0_脚前_手_鱗_鱗2.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_鱗_鱗2.Dra = value;
				this.X0Y0_脚前_手_鱗_鱗2.Hit = value;
			}
		}

		public bool 脚前_手_鱗_鱗1_表示
		{
			get
			{
				return this.X0Y0_脚前_手_鱗_鱗1.Dra;
			}
			set
			{
				this.X0Y0_脚前_手_鱗_鱗1.Dra = value;
				this.X0Y0_脚前_手_鱗_鱗1.Hit = value;
			}
		}

		public bool 脚前_下腕鱗_鱗小_鱗9_表示
		{
			get
			{
				return this.X0Y0_脚前_下腕鱗_鱗小_鱗9.Dra;
			}
			set
			{
				this.X0Y0_脚前_下腕鱗_鱗小_鱗9.Dra = value;
				this.X0Y0_脚前_下腕鱗_鱗小_鱗9.Hit = value;
			}
		}

		public bool 脚前_下腕鱗_鱗小_鱗8_表示
		{
			get
			{
				return this.X0Y0_脚前_下腕鱗_鱗小_鱗8.Dra;
			}
			set
			{
				this.X0Y0_脚前_下腕鱗_鱗小_鱗8.Dra = value;
				this.X0Y0_脚前_下腕鱗_鱗小_鱗8.Hit = value;
			}
		}

		public bool 脚前_下腕鱗_鱗小_鱗7_表示
		{
			get
			{
				return this.X0Y0_脚前_下腕鱗_鱗小_鱗7.Dra;
			}
			set
			{
				this.X0Y0_脚前_下腕鱗_鱗小_鱗7.Dra = value;
				this.X0Y0_脚前_下腕鱗_鱗小_鱗7.Hit = value;
			}
		}

		public bool 脚前_下腕鱗_鱗小_鱗6_表示
		{
			get
			{
				return this.X0Y0_脚前_下腕鱗_鱗小_鱗6.Dra;
			}
			set
			{
				this.X0Y0_脚前_下腕鱗_鱗小_鱗6.Dra = value;
				this.X0Y0_脚前_下腕鱗_鱗小_鱗6.Hit = value;
			}
		}

		public bool 脚前_下腕鱗_鱗小_鱗5_表示
		{
			get
			{
				return this.X0Y0_脚前_下腕鱗_鱗小_鱗5.Dra;
			}
			set
			{
				this.X0Y0_脚前_下腕鱗_鱗小_鱗5.Dra = value;
				this.X0Y0_脚前_下腕鱗_鱗小_鱗5.Hit = value;
			}
		}

		public bool 脚前_下腕鱗_鱗小_鱗4_表示
		{
			get
			{
				return this.X0Y0_脚前_下腕鱗_鱗小_鱗4.Dra;
			}
			set
			{
				this.X0Y0_脚前_下腕鱗_鱗小_鱗4.Dra = value;
				this.X0Y0_脚前_下腕鱗_鱗小_鱗4.Hit = value;
			}
		}

		public bool 脚前_下腕鱗_鱗小_鱗3_表示
		{
			get
			{
				return this.X0Y0_脚前_下腕鱗_鱗小_鱗3.Dra;
			}
			set
			{
				this.X0Y0_脚前_下腕鱗_鱗小_鱗3.Dra = value;
				this.X0Y0_脚前_下腕鱗_鱗小_鱗3.Hit = value;
			}
		}

		public bool 脚前_下腕鱗_鱗小_鱗2_表示
		{
			get
			{
				return this.X0Y0_脚前_下腕鱗_鱗小_鱗2.Dra;
			}
			set
			{
				this.X0Y0_脚前_下腕鱗_鱗小_鱗2.Dra = value;
				this.X0Y0_脚前_下腕鱗_鱗小_鱗2.Hit = value;
			}
		}

		public bool 脚前_下腕鱗_鱗小_鱗1_表示
		{
			get
			{
				return this.X0Y0_脚前_下腕鱗_鱗小_鱗1.Dra;
			}
			set
			{
				this.X0Y0_脚前_下腕鱗_鱗小_鱗1.Dra = value;
				this.X0Y0_脚前_下腕鱗_鱗小_鱗1.Hit = value;
			}
		}

		public bool 脚前_下腕鱗_鱗大_鱗9_表示
		{
			get
			{
				return this.X0Y0_脚前_下腕鱗_鱗大_鱗9.Dra;
			}
			set
			{
				this.X0Y0_脚前_下腕鱗_鱗大_鱗9.Dra = value;
				this.X0Y0_脚前_下腕鱗_鱗大_鱗9.Hit = value;
			}
		}

		public bool 脚前_下腕鱗_鱗大_鱗8_表示
		{
			get
			{
				return this.X0Y0_脚前_下腕鱗_鱗大_鱗8.Dra;
			}
			set
			{
				this.X0Y0_脚前_下腕鱗_鱗大_鱗8.Dra = value;
				this.X0Y0_脚前_下腕鱗_鱗大_鱗8.Hit = value;
			}
		}

		public bool 脚前_下腕鱗_鱗大_鱗7_表示
		{
			get
			{
				return this.X0Y0_脚前_下腕鱗_鱗大_鱗7.Dra;
			}
			set
			{
				this.X0Y0_脚前_下腕鱗_鱗大_鱗7.Dra = value;
				this.X0Y0_脚前_下腕鱗_鱗大_鱗7.Hit = value;
			}
		}

		public bool 脚前_下腕鱗_鱗大_鱗6_表示
		{
			get
			{
				return this.X0Y0_脚前_下腕鱗_鱗大_鱗6.Dra;
			}
			set
			{
				this.X0Y0_脚前_下腕鱗_鱗大_鱗6.Dra = value;
				this.X0Y0_脚前_下腕鱗_鱗大_鱗6.Hit = value;
			}
		}

		public bool 脚前_下腕鱗_鱗大_鱗5_表示
		{
			get
			{
				return this.X0Y0_脚前_下腕鱗_鱗大_鱗5.Dra;
			}
			set
			{
				this.X0Y0_脚前_下腕鱗_鱗大_鱗5.Dra = value;
				this.X0Y0_脚前_下腕鱗_鱗大_鱗5.Hit = value;
			}
		}

		public bool 脚前_下腕鱗_鱗大_鱗4_表示
		{
			get
			{
				return this.X0Y0_脚前_下腕鱗_鱗大_鱗4.Dra;
			}
			set
			{
				this.X0Y0_脚前_下腕鱗_鱗大_鱗4.Dra = value;
				this.X0Y0_脚前_下腕鱗_鱗大_鱗4.Hit = value;
			}
		}

		public bool 脚前_下腕鱗_鱗大_鱗3_表示
		{
			get
			{
				return this.X0Y0_脚前_下腕鱗_鱗大_鱗3.Dra;
			}
			set
			{
				this.X0Y0_脚前_下腕鱗_鱗大_鱗3.Dra = value;
				this.X0Y0_脚前_下腕鱗_鱗大_鱗3.Hit = value;
			}
		}

		public bool 脚前_下腕鱗_鱗大_鱗2_表示
		{
			get
			{
				return this.X0Y0_脚前_下腕鱗_鱗大_鱗2.Dra;
			}
			set
			{
				this.X0Y0_脚前_下腕鱗_鱗大_鱗2.Dra = value;
				this.X0Y0_脚前_下腕鱗_鱗大_鱗2.Hit = value;
			}
		}

		public bool 脚前_下腕鱗_鱗大_鱗1_表示
		{
			get
			{
				return this.X0Y0_脚前_下腕鱗_鱗大_鱗1.Dra;
			}
			set
			{
				this.X0Y0_脚前_下腕鱗_鱗大_鱗1.Dra = value;
				this.X0Y0_脚前_下腕鱗_鱗大_鱗1.Hit = value;
			}
		}

		public bool 脚前_上腕鱗_鱗5_表示
		{
			get
			{
				return this.X0Y0_脚前_上腕鱗_鱗5.Dra;
			}
			set
			{
				this.X0Y0_脚前_上腕鱗_鱗5.Dra = value;
				this.X0Y0_脚前_上腕鱗_鱗5.Hit = value;
			}
		}

		public bool 脚前_上腕鱗_鱗4_表示
		{
			get
			{
				return this.X0Y0_脚前_上腕鱗_鱗4.Dra;
			}
			set
			{
				this.X0Y0_脚前_上腕鱗_鱗4.Dra = value;
				this.X0Y0_脚前_上腕鱗_鱗4.Hit = value;
			}
		}

		public bool 脚前_上腕鱗_鱗3_表示
		{
			get
			{
				return this.X0Y0_脚前_上腕鱗_鱗3.Dra;
			}
			set
			{
				this.X0Y0_脚前_上腕鱗_鱗3.Dra = value;
				this.X0Y0_脚前_上腕鱗_鱗3.Hit = value;
			}
		}

		public bool 脚前_上腕鱗_鱗2_表示
		{
			get
			{
				return this.X0Y0_脚前_上腕鱗_鱗2.Dra;
			}
			set
			{
				this.X0Y0_脚前_上腕鱗_鱗2.Dra = value;
				this.X0Y0_脚前_上腕鱗_鱗2.Hit = value;
			}
		}

		public bool 脚前_上腕鱗_鱗1_表示
		{
			get
			{
				return this.X0Y0_脚前_上腕鱗_鱗1.Dra;
			}
			set
			{
				this.X0Y0_脚前_上腕鱗_鱗1.Dra = value;
				this.X0Y0_脚前_上腕鱗_鱗1.Hit = value;
			}
		}

		public bool 脚前_鰭_鰭膜1_表示
		{
			get
			{
				return this.X0Y0_脚前_鰭_鰭膜1.Dra;
			}
			set
			{
				this.X0Y0_脚前_鰭_鰭膜1.Dra = value;
				this.X0Y0_脚前_鰭_鰭膜1.Hit = value;
			}
		}

		public bool 脚前_鰭_鰭条1_表示
		{
			get
			{
				return this.X0Y0_脚前_鰭_鰭条1.Dra;
			}
			set
			{
				this.X0Y0_脚前_鰭_鰭条1.Dra = value;
				this.X0Y0_脚前_鰭_鰭条1.Hit = value;
			}
		}

		public bool 脚前_鰭_鰭膜2_表示
		{
			get
			{
				return this.X0Y0_脚前_鰭_鰭膜2.Dra;
			}
			set
			{
				this.X0Y0_脚前_鰭_鰭膜2.Dra = value;
				this.X0Y0_脚前_鰭_鰭膜2.Hit = value;
			}
		}

		public bool 脚前_鰭_鰭条2_表示
		{
			get
			{
				return this.X0Y0_脚前_鰭_鰭条2.Dra;
			}
			set
			{
				this.X0Y0_脚前_鰭_鰭条2.Dra = value;
				this.X0Y0_脚前_鰭_鰭条2.Hit = value;
			}
		}

		public bool 脚前_鰭_鰭膜3_表示
		{
			get
			{
				return this.X0Y0_脚前_鰭_鰭膜3.Dra;
			}
			set
			{
				this.X0Y0_脚前_鰭_鰭膜3.Dra = value;
				this.X0Y0_脚前_鰭_鰭膜3.Hit = value;
			}
		}

		public bool 脚前_輪_革_表示
		{
			get
			{
				return this.X0Y0_脚前_輪_革.Dra;
			}
			set
			{
				this.X0Y0_脚前_輪_革.Dra = value;
				this.X0Y0_脚前_輪_革.Hit = value;
			}
		}

		public bool 脚前_輪_金具1_表示
		{
			get
			{
				return this.X0Y0_脚前_輪_金具1.Dra;
			}
			set
			{
				this.X0Y0_脚前_輪_金具1.Dra = value;
				this.X0Y0_脚前_輪_金具1.Hit = value;
			}
		}

		public bool 脚前_輪_金具2_表示
		{
			get
			{
				return this.X0Y0_脚前_輪_金具2.Dra;
			}
			set
			{
				this.X0Y0_脚前_輪_金具2.Dra = value;
				this.X0Y0_脚前_輪_金具2.Hit = value;
			}
		}

		public bool 脚前_輪_金具3_表示
		{
			get
			{
				return this.X0Y0_脚前_輪_金具3.Dra;
			}
			set
			{
				this.X0Y0_脚前_輪_金具3.Dra = value;
				this.X0Y0_脚前_輪_金具3.Hit = value;
			}
		}

		public bool 脚前_輪_金具左_表示
		{
			get
			{
				return this.X0Y0_脚前_輪_金具左.Dra;
			}
			set
			{
				this.X0Y0_脚前_輪_金具左.Dra = value;
				this.X0Y0_脚前_輪_金具左.Hit = value;
			}
		}

		public bool 脚前_輪_金具右_表示
		{
			get
			{
				return this.X0Y0_脚前_輪_金具右.Dra;
			}
			set
			{
				this.X0Y0_脚前_輪_金具右.Dra = value;
				this.X0Y0_脚前_輪_金具右.Hit = value;
			}
		}

		public bool 頭部鱗
		{
			set
			{
				this.X0Y0_上顎頭部後_頭1.OP[this.右 ? 1 : 2].Outline = value;
				this.X0Y0_下顎頭部後_頭1.OP[this.右 ? 2 : 1].Outline = value;
				this.X0Y0_頭_下顎_頭部_前_頭8.OP[this.右 ? 2 : 1].Outline = value;
				this.X0Y0_頭_下顎_頭部_前_頭7.OP[this.右 ? 2 : 1].Outline = value;
				this.X0Y0_頭_下顎_頭部_前_頭6.OP[this.右 ? 2 : 1].Outline = value;
				this.X0Y0_頭_下顎_頭部_前_頭5.OP[this.右 ? 0 : 3].Outline = value;
				this.X0Y0_頭_下顎_頭部_前_頭4.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_頭_下顎_頭部_前_頭3.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_頭_下顎_頭部_前_頭2.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_頭_下顎_頭部_前_頭1.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_頭_上顎_頭部_前_頭8.OP[this.右 ? 1 : 2].Outline = value;
				this.X0Y0_頭_上顎_頭部_前_頭7.OP[this.右 ? 1 : 2].Outline = value;
				this.X0Y0_頭_上顎_頭部_前_頭6.OP[this.右 ? 1 : 2].Outline = value;
				this.X0Y0_頭_上顎_頭部_前_頭5.OP[this.右 ? 3 : 0].Outline = value;
				this.X0Y0_頭_上顎_頭部_前_頭4.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_頭_上顎_頭部_前_頭3.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_頭_上顎_頭部_前_頭2.OP[this.右 ? 2 : 2].Outline = value;
				this.X0Y0_頭_上顎_頭部_前_頭1.OP[this.右 ? 2 : 2].Outline = value;
			}
		}

		public bool 輪1表示
		{
			get
			{
				return this.頭_輪_革_表示;
			}
			set
			{
				this.頭_輪_革_表示 = value;
				this.頭_輪_金具1_表示 = value;
				this.頭_輪_金具2_表示 = value;
				this.頭_輪_金具3_表示 = value;
				this.頭_輪_金具左_表示 = value;
				this.頭_輪_金具右_表示 = value;
			}
		}

		public bool 輪2表示
		{
			get
			{
				return this.胴_輪_革_表示;
			}
			set
			{
				this.胴_輪_革_表示 = value;
				this.胴_輪_金具1_表示 = value;
				this.胴_輪_金具2_表示 = value;
				this.胴_輪_金具3_表示 = value;
				this.胴_輪_金具左_表示 = value;
				this.胴_輪_金具右_表示 = value;
			}
		}

		public bool 輪3表示
		{
			get
			{
				return this.脚前_輪_革_表示;
			}
			set
			{
				this.脚前_輪_革_表示 = (value && this.脚前_上腕_表示);
				this.脚前_輪_金具1_表示 = (value && this.脚前_上腕_表示);
				this.脚前_輪_金具2_表示 = (value && this.脚前_上腕_表示);
				this.脚前_輪_金具3_表示 = (value && this.脚前_上腕_表示);
				this.脚前_輪_金具左_表示 = (value && this.脚前_上腕_表示);
				this.脚前_輪_金具右_表示 = (value && this.脚前_上腕_表示);
			}
		}

		public bool 輪4表示
		{
			get
			{
				return this.脚後_輪_革_表示;
			}
			set
			{
				this.脚後_輪_革_表示 = (value && this.脚後_上腕_表示);
				this.脚後_輪_金具1_表示 = (value && this.脚後_上腕_表示);
				this.脚後_輪_金具2_表示 = (value && this.脚後_上腕_表示);
				this.脚後_輪_金具3_表示 = (value && this.脚後_上腕_表示);
				this.脚後_輪_金具左_表示 = (value && this.脚後_上腕_表示);
				this.脚後_輪_金具右_表示 = (value && this.脚後_上腕_表示);
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
				this.鎖3.表示 = (value && this.脚後_上腕_表示);
				this.鎖5.表示 = (value && this.脚前_上腕_表示);
			}
		}

		public override bool 表示
		{
			get
			{
				return this.脚後_鰭_鰭膜1_表示;
			}
			set
			{
				this.脚後_鰭_鰭膜1_表示 = value;
				this.脚後_鰭_鰭条1_表示 = value;
				this.脚後_鰭_鰭膜2_表示 = value;
				this.脚後_鰭_鰭条2_表示 = value;
				this.脚後_鰭_鰭膜3_表示 = value;
				this.脚後_上腕_表示 = value;
				this.脚後_下腕_表示 = value;
				this.脚後_手_手_表示 = value;
				this.脚後_手_小指_指_表示 = value;
				this.脚後_手_小指_爪_表示 = value;
				this.脚後_手_小指_鱗_鱗4_表示 = value;
				this.脚後_手_小指_鱗_鱗3_表示 = value;
				this.脚後_手_小指_鱗_鱗2_表示 = value;
				this.脚後_手_小指_鱗_鱗1_表示 = value;
				this.脚後_手_小指_水掻_表示 = value;
				this.脚後_手_薬指_指_表示 = value;
				this.脚後_手_薬指_爪_表示 = value;
				this.脚後_手_薬指_水掻_表示 = value;
				this.脚後_手_薬指_鱗_鱗4_表示 = value;
				this.脚後_手_薬指_鱗_鱗3_表示 = value;
				this.脚後_手_薬指_鱗_鱗2_表示 = value;
				this.脚後_手_薬指_鱗_鱗1_表示 = value;
				this.脚後_手_中指_指_表示 = value;
				this.脚後_手_中指_爪_表示 = value;
				this.脚後_手_中指_水掻_表示 = value;
				this.脚後_手_中指_鱗_鱗4_表示 = value;
				this.脚後_手_中指_鱗_鱗3_表示 = value;
				this.脚後_手_中指_鱗_鱗2_表示 = value;
				this.脚後_手_中指_鱗_鱗1_表示 = value;
				this.脚後_手_人指_指_表示 = value;
				this.脚後_手_人指_爪_表示 = value;
				this.脚後_手_人指_鱗_鱗4_表示 = value;
				this.脚後_手_人指_鱗_鱗3_表示 = value;
				this.脚後_手_人指_鱗_鱗2_表示 = value;
				this.脚後_手_人指_鱗_鱗1_表示 = value;
				this.脚後_手_鱗_鱗3_表示 = value;
				this.脚後_手_鱗_鱗2_表示 = value;
				this.脚後_手_鱗_鱗1_表示 = value;
				this.脚後_手_親指_爪_表示 = value;
				this.脚後_下腕鱗_鱗小_鱗9_表示 = value;
				this.脚後_下腕鱗_鱗小_鱗8_表示 = value;
				this.脚後_下腕鱗_鱗小_鱗7_表示 = value;
				this.脚後_下腕鱗_鱗小_鱗6_表示 = value;
				this.脚後_下腕鱗_鱗小_鱗5_表示 = value;
				this.脚後_下腕鱗_鱗小_鱗4_表示 = value;
				this.脚後_下腕鱗_鱗小_鱗3_表示 = value;
				this.脚後_下腕鱗_鱗小_鱗2_表示 = value;
				this.脚後_下腕鱗_鱗小_鱗1_表示 = value;
				this.脚後_下腕鱗_鱗大_鱗9_表示 = value;
				this.脚後_下腕鱗_鱗大_鱗8_表示 = value;
				this.脚後_下腕鱗_鱗大_鱗7_表示 = value;
				this.脚後_下腕鱗_鱗大_鱗6_表示 = value;
				this.脚後_下腕鱗_鱗大_鱗5_表示 = value;
				this.脚後_下腕鱗_鱗大_鱗4_表示 = value;
				this.脚後_下腕鱗_鱗大_鱗3_表示 = value;
				this.脚後_下腕鱗_鱗大_鱗2_表示 = value;
				this.脚後_下腕鱗_鱗大_鱗1_表示 = value;
				this.脚後_上腕鱗_鱗5_表示 = value;
				this.脚後_上腕鱗_鱗4_表示 = value;
				this.脚後_上腕鱗_鱗3_表示 = value;
				this.脚後_上腕鱗_鱗2_表示 = value;
				this.脚後_上腕鱗_鱗1_表示 = value;
				this.脚後_輪_革_表示 = value;
				this.脚後_輪_金具1_表示 = value;
				this.脚後_輪_金具2_表示 = value;
				this.脚後_輪_金具3_表示 = value;
				this.脚後_輪_金具左_表示 = value;
				this.脚後_輪_金具右_表示 = value;
				this.上顎頭部後_頭2_表示 = value;
				this.上顎頭部後_頭1_表示 = value;
				this.下顎頭部後_頭2_表示 = value;
				this.下顎頭部後_頭1_表示 = value;
				this.胴_節1_胴_表示 = value;
				this.胴_節1_鱗1_表示 = value;
				this.胴_節1_鱗3_表示 = value;
				this.胴_節1_鱗2_表示 = value;
				this.胴_節2_胴_表示 = value;
				this.胴_節2_鱗1_表示 = value;
				this.胴_節2_鱗3_表示 = value;
				this.胴_節2_鱗2_表示 = value;
				this.胴_節3_胴_表示 = value;
				this.胴_節3_鱗1_表示 = value;
				this.胴_節3_鱗3_表示 = value;
				this.胴_節3_鱗2_表示 = value;
				this.胴_節4_胴_表示 = value;
				this.胴_節4_鱗1_表示 = value;
				this.胴_節4_鱗3_表示 = value;
				this.胴_節4_鱗2_表示 = value;
				this.胴_節5_胴_表示 = value;
				this.胴_節5_鱗1_表示 = value;
				this.胴_節5_鱗3_表示 = value;
				this.胴_節5_鱗2_表示 = value;
				this.胴_節6_胴_表示 = value;
				this.胴_節6_鱗1_表示 = value;
				this.胴_節6_鱗3_表示 = value;
				this.胴_節6_鱗2_表示 = value;
				this.胴_節7_胴_表示 = value;
				this.胴_節7_鱗1_表示 = value;
				this.胴_節7_鱗3_表示 = value;
				this.胴_節7_鱗2_表示 = value;
				this.胴_節8_胴_表示 = value;
				this.胴_節8_鱗1_表示 = value;
				this.胴_節8_鱗3_表示 = value;
				this.胴_節8_鱗2_表示 = value;
				this.胴_節9_胴_表示 = value;
				this.胴_節9_鱗1_表示 = value;
				this.胴_節9_鱗3_表示 = value;
				this.胴_節9_鱗2_表示 = value;
				this.胴_節10_胴_表示 = value;
				this.胴_節10_鱗1_表示 = value;
				this.胴_節10_鱗3_表示 = value;
				this.胴_節10_鱗2_表示 = value;
				this.胴_節11_胴_表示 = value;
				this.胴_節11_鱗1_表示 = value;
				this.胴_節11_鱗3_表示 = value;
				this.胴_節11_鱗2_表示 = value;
				this.胴_節12_胴_表示 = value;
				this.胴_節12_鱗1_表示 = value;
				this.胴_節12_鱗3_表示 = value;
				this.胴_節12_鱗2_表示 = value;
				this.胴_節13_胴_表示 = value;
				this.胴_節13_鱗1_表示 = value;
				this.胴_節13_鱗3_表示 = value;
				this.胴_節13_鱗2_表示 = value;
				this.胴_節14_胴_表示 = value;
				this.胴_節14_鱗1_表示 = value;
				this.胴_節14_鱗3_表示 = value;
				this.胴_節14_鱗2_表示 = value;
				this.胴_節15_胴_表示 = value;
				this.胴_節15_鱗1_表示 = value;
				this.胴_節15_鱗3_表示 = value;
				this.胴_節15_鱗2_表示 = value;
				this.胴_節16_胴_表示 = value;
				this.胴_節16_鱗1_表示 = value;
				this.胴_節16_鱗3_表示 = value;
				this.胴_節16_鱗2_表示 = value;
				this.胴_輪_革_表示 = value;
				this.胴_輪_金具1_表示 = value;
				this.胴_輪_金具2_表示 = value;
				this.胴_輪_金具3_表示 = value;
				this.胴_輪_金具左_表示 = value;
				this.胴_輪_金具右_表示 = value;
				this.胴_節17_胴_表示 = value;
				this.胴_節17_鱗1_表示 = value;
				this.胴_節17_鱗3_表示 = value;
				this.胴_節17_鱗2_表示 = value;
				this.胴_節18_胴_表示 = value;
				this.胴_節18_鱗1_表示 = value;
				this.胴_節18_鱗3_表示 = value;
				this.胴_節18_鱗2_表示 = value;
				this.頭_口膜_口膜1_表示 = value;
				this.頭_口膜_口膜2_表示 = value;
				this.頭_口膜_口膜3_表示 = value;
				this.頭_口膜_口膜4_表示 = value;
				this.頭_口膜_口膜5_表示 = value;
				this.頭_口膜_口膜6_表示 = value;
				this.頭_口膜_口膜7_表示 = value;
				this.頭_口膜_口膜8_表示 = value;
				this.頭_上顎歯後_歯1_表示 = value;
				this.頭_上顎歯後_歯2_表示 = value;
				this.頭_上顎歯後_歯3_表示 = value;
				this.頭_下顎_歯_後_歯1_表示 = value;
				this.頭_下顎_歯_後_歯2_表示 = value;
				this.頭_下顎_歯_後_歯3_表示 = value;
				this.頭_下顎_歯_前_歯1_表示 = value;
				this.頭_下顎_歯_前_歯2_表示 = value;
				this.頭_下顎_歯_前_歯3_表示 = value;
				this.頭_下顎_眼孔1_表示 = value;
				this.頭_下顎_眼孔2_表示 = value;
				this.頭_下顎_眼_眼1_眼2_表示 = value;
				this.頭_下顎_眼_眼1_眼1_表示 = value;
				this.頭_下顎_眼_眼2_眼2_表示 = value;
				this.頭_下顎_眼_眼2_眼1_表示 = value;
				this.頭_下顎_眼下_眼下_表示 = value;
				this.頭_下顎_眼下_線_表示 = value;
				this.頭_下顎_頭部_前_頭9_表示 = value;
				this.頭_下顎_頭部_前_頭8_表示 = value;
				this.頭_下顎_頭部_前_頭7_表示 = value;
				this.頭_下顎_頭部_前_頭6_表示 = value;
				this.頭_下顎_頭部_前_頭5_表示 = value;
				this.頭_下顎_頭部_前_頭4_表示 = value;
				this.頭_下顎_頭部_前_頭3_表示 = value;
				this.頭_下顎_頭部_前_頭2_表示 = value;
				this.頭_下顎_頭部_前_頭1_表示 = value;
				this.頭_上顎_歯_前_歯1_表示 = value;
				this.頭_上顎_歯_前_歯2_表示 = value;
				this.頭_上顎_歯_前_歯3_表示 = value;
				this.頭_上顎_眼孔1_表示 = value;
				this.頭_上顎_眼孔2_表示 = value;
				this.頭_上顎_眼_眼1_眼2_表示 = value;
				this.頭_上顎_眼_眼1_眼1_表示 = value;
				this.頭_上顎_眼_眼2_眼2_表示 = value;
				this.頭_上顎_眼_眼2_眼1_表示 = value;
				this.頭_上顎_眼下_眼下_表示 = value;
				this.頭_上顎_眼下_線_表示 = value;
				this.頭_上顎_頭部_前_頭9_表示 = value;
				this.頭_上顎_頭部_前_頭8_表示 = value;
				this.頭_上顎_頭部_前_頭7_表示 = value;
				this.頭_上顎_頭部_前_頭6_表示 = value;
				this.頭_上顎_頭部_前_頭5_表示 = value;
				this.頭_上顎_頭部_前_頭4_表示 = value;
				this.頭_上顎_頭部_前_頭3_表示 = value;
				this.頭_上顎_頭部_前_頭2_表示 = value;
				this.頭_上顎_頭部_前_頭1_表示 = value;
				this.頭_輪_革_表示 = value;
				this.頭_輪_金具1_表示 = value;
				this.頭_輪_金具2_表示 = value;
				this.頭_輪_金具3_表示 = value;
				this.頭_輪_金具左_表示 = value;
				this.頭_輪_金具右_表示 = value;
				this.脚前_上腕_表示 = value;
				this.脚前_下腕_表示 = value;
				this.脚前_手_親指_爪_表示 = value;
				this.脚前_手_手_表示 = value;
				this.脚前_手_人指_指_表示 = value;
				this.脚前_手_人指_爪_表示 = value;
				this.脚前_手_人指_水掻_表示 = value;
				this.脚前_手_人指_鱗_鱗4_表示 = value;
				this.脚前_手_人指_鱗_鱗3_表示 = value;
				this.脚前_手_人指_鱗_鱗2_表示 = value;
				this.脚前_手_人指_鱗_鱗1_表示 = value;
				this.脚前_手_中指_指_表示 = value;
				this.脚前_手_中指_爪_表示 = value;
				this.脚前_手_中指_水掻_表示 = value;
				this.脚前_手_中指_鱗_鱗4_表示 = value;
				this.脚前_手_中指_鱗_鱗3_表示 = value;
				this.脚前_手_中指_鱗_鱗2_表示 = value;
				this.脚前_手_中指_鱗_鱗1_表示 = value;
				this.脚前_手_薬指_指_表示 = value;
				this.脚前_手_薬指_爪_表示 = value;
				this.脚前_手_薬指_水掻_表示 = value;
				this.脚前_手_薬指_鱗_鱗4_表示 = value;
				this.脚前_手_薬指_鱗_鱗3_表示 = value;
				this.脚前_手_薬指_鱗_鱗2_表示 = value;
				this.脚前_手_薬指_鱗_鱗1_表示 = value;
				this.脚前_手_小指_指_表示 = value;
				this.脚前_手_小指_爪_表示 = value;
				this.脚前_手_小指_鱗_鱗4_表示 = value;
				this.脚前_手_小指_鱗_鱗3_表示 = value;
				this.脚前_手_小指_鱗_鱗2_表示 = value;
				this.脚前_手_小指_鱗_鱗1_表示 = value;
				this.脚前_手_鱗_鱗3_表示 = value;
				this.脚前_手_鱗_鱗2_表示 = value;
				this.脚前_手_鱗_鱗1_表示 = value;
				this.脚前_下腕鱗_鱗小_鱗9_表示 = value;
				this.脚前_下腕鱗_鱗小_鱗8_表示 = value;
				this.脚前_下腕鱗_鱗小_鱗7_表示 = value;
				this.脚前_下腕鱗_鱗小_鱗6_表示 = value;
				this.脚前_下腕鱗_鱗小_鱗5_表示 = value;
				this.脚前_下腕鱗_鱗小_鱗4_表示 = value;
				this.脚前_下腕鱗_鱗小_鱗3_表示 = value;
				this.脚前_下腕鱗_鱗小_鱗2_表示 = value;
				this.脚前_下腕鱗_鱗小_鱗1_表示 = value;
				this.脚前_下腕鱗_鱗大_鱗9_表示 = value;
				this.脚前_下腕鱗_鱗大_鱗8_表示 = value;
				this.脚前_下腕鱗_鱗大_鱗7_表示 = value;
				this.脚前_下腕鱗_鱗大_鱗6_表示 = value;
				this.脚前_下腕鱗_鱗大_鱗5_表示 = value;
				this.脚前_下腕鱗_鱗大_鱗4_表示 = value;
				this.脚前_下腕鱗_鱗大_鱗3_表示 = value;
				this.脚前_下腕鱗_鱗大_鱗2_表示 = value;
				this.脚前_下腕鱗_鱗大_鱗1_表示 = value;
				this.脚前_上腕鱗_鱗5_表示 = value;
				this.脚前_上腕鱗_鱗4_表示 = value;
				this.脚前_上腕鱗_鱗3_表示 = value;
				this.脚前_上腕鱗_鱗2_表示 = value;
				this.脚前_上腕鱗_鱗1_表示 = value;
				this.脚前_鰭_鰭膜1_表示 = value;
				this.脚前_鰭_鰭条1_表示 = value;
				this.脚前_鰭_鰭膜2_表示 = value;
				this.脚前_鰭_鰭条2_表示 = value;
				this.脚前_鰭_鰭膜3_表示 = value;
				this.脚前_輪_革_表示 = value;
				this.脚前_輪_金具1_表示 = value;
				this.脚前_輪_金具2_表示 = value;
				this.脚前_輪_金具3_表示 = value;
				this.脚前_輪_金具左_表示 = value;
				this.脚前_輪_金具右_表示 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_脚後_鰭_鰭膜1);
			Are.Draw(this.X0Y0_脚後_鰭_鰭条1);
			Are.Draw(this.X0Y0_脚後_鰭_鰭膜2);
			Are.Draw(this.X0Y0_脚後_鰭_鰭条2);
			Are.Draw(this.X0Y0_脚後_鰭_鰭膜3);
			Are.Draw(this.X0Y0_脚後_上腕);
			Are.Draw(this.X0Y0_脚後_下腕);
			Are.Draw(this.X0Y0_脚後_手_手);
			Are.Draw(this.X0Y0_脚後_手_小指_指);
			Are.Draw(this.X0Y0_脚後_手_小指_爪);
			Are.Draw(this.X0Y0_脚後_手_小指_鱗_鱗4);
			Are.Draw(this.X0Y0_脚後_手_小指_鱗_鱗3);
			Are.Draw(this.X0Y0_脚後_手_小指_鱗_鱗2);
			Are.Draw(this.X0Y0_脚後_手_小指_鱗_鱗1);
			Are.Draw(this.X0Y0_脚後_手_小指_水掻);
			Are.Draw(this.X0Y0_脚後_手_薬指_指);
			Are.Draw(this.X0Y0_脚後_手_薬指_爪);
			Are.Draw(this.X0Y0_脚後_手_薬指_水掻);
			Are.Draw(this.X0Y0_脚後_手_薬指_鱗_鱗4);
			Are.Draw(this.X0Y0_脚後_手_薬指_鱗_鱗3);
			Are.Draw(this.X0Y0_脚後_手_薬指_鱗_鱗2);
			Are.Draw(this.X0Y0_脚後_手_薬指_鱗_鱗1);
			Are.Draw(this.X0Y0_脚後_手_中指_指);
			Are.Draw(this.X0Y0_脚後_手_中指_爪);
			Are.Draw(this.X0Y0_脚後_手_中指_水掻);
			Are.Draw(this.X0Y0_脚後_手_中指_鱗_鱗4);
			Are.Draw(this.X0Y0_脚後_手_中指_鱗_鱗3);
			Are.Draw(this.X0Y0_脚後_手_中指_鱗_鱗2);
			Are.Draw(this.X0Y0_脚後_手_中指_鱗_鱗1);
			Are.Draw(this.X0Y0_脚後_手_人指_指);
			Are.Draw(this.X0Y0_脚後_手_人指_爪);
			Are.Draw(this.X0Y0_脚後_手_人指_鱗_鱗4);
			Are.Draw(this.X0Y0_脚後_手_人指_鱗_鱗3);
			Are.Draw(this.X0Y0_脚後_手_人指_鱗_鱗2);
			Are.Draw(this.X0Y0_脚後_手_人指_鱗_鱗1);
			Are.Draw(this.X0Y0_脚後_手_鱗_鱗3);
			Are.Draw(this.X0Y0_脚後_手_鱗_鱗2);
			Are.Draw(this.X0Y0_脚後_手_鱗_鱗1);
			Are.Draw(this.X0Y0_脚後_手_親指_爪);
			Are.Draw(this.X0Y0_脚後_下腕鱗_鱗小_鱗9);
			Are.Draw(this.X0Y0_脚後_下腕鱗_鱗小_鱗8);
			Are.Draw(this.X0Y0_脚後_下腕鱗_鱗小_鱗7);
			Are.Draw(this.X0Y0_脚後_下腕鱗_鱗小_鱗6);
			Are.Draw(this.X0Y0_脚後_下腕鱗_鱗小_鱗5);
			Are.Draw(this.X0Y0_脚後_下腕鱗_鱗小_鱗4);
			Are.Draw(this.X0Y0_脚後_下腕鱗_鱗小_鱗3);
			Are.Draw(this.X0Y0_脚後_下腕鱗_鱗小_鱗2);
			Are.Draw(this.X0Y0_脚後_下腕鱗_鱗小_鱗1);
			Are.Draw(this.X0Y0_脚後_下腕鱗_鱗大_鱗9);
			Are.Draw(this.X0Y0_脚後_下腕鱗_鱗大_鱗8);
			Are.Draw(this.X0Y0_脚後_下腕鱗_鱗大_鱗7);
			Are.Draw(this.X0Y0_脚後_下腕鱗_鱗大_鱗6);
			Are.Draw(this.X0Y0_脚後_下腕鱗_鱗大_鱗5);
			Are.Draw(this.X0Y0_脚後_下腕鱗_鱗大_鱗4);
			Are.Draw(this.X0Y0_脚後_下腕鱗_鱗大_鱗3);
			Are.Draw(this.X0Y0_脚後_下腕鱗_鱗大_鱗2);
			Are.Draw(this.X0Y0_脚後_下腕鱗_鱗大_鱗1);
			Are.Draw(this.X0Y0_脚後_上腕鱗_鱗5);
			Are.Draw(this.X0Y0_脚後_上腕鱗_鱗4);
			Are.Draw(this.X0Y0_脚後_上腕鱗_鱗3);
			Are.Draw(this.X0Y0_脚後_上腕鱗_鱗2);
			Are.Draw(this.X0Y0_脚後_上腕鱗_鱗1);
			Are.Draw(this.X0Y0_脚後_輪_革);
			Are.Draw(this.X0Y0_脚後_輪_金具1);
			Are.Draw(this.X0Y0_脚後_輪_金具2);
			Are.Draw(this.X0Y0_脚後_輪_金具3);
			Are.Draw(this.X0Y0_脚後_輪_金具左);
			Are.Draw(this.X0Y0_脚後_輪_金具右);
			this.鎖3.描画0(Are);
			Are.Draw(this.X0Y0_上顎頭部後_頭2);
			Are.Draw(this.X0Y0_上顎頭部後_頭1);
			Are.Draw(this.X0Y0_下顎頭部後_頭2);
			Are.Draw(this.X0Y0_下顎頭部後_頭1);
			Are.Draw(this.X0Y0_胴_節1_胴);
			Are.Draw(this.X0Y0_胴_節1_鱗1);
			Are.Draw(this.X0Y0_胴_節1_鱗3);
			Are.Draw(this.X0Y0_胴_節1_鱗2);
			Are.Draw(this.X0Y0_胴_節2_胴);
			Are.Draw(this.X0Y0_胴_節2_鱗1);
			Are.Draw(this.X0Y0_胴_節2_鱗3);
			Are.Draw(this.X0Y0_胴_節2_鱗2);
			Are.Draw(this.X0Y0_胴_節3_胴);
			Are.Draw(this.X0Y0_胴_節3_鱗1);
			Are.Draw(this.X0Y0_胴_節3_鱗3);
			Are.Draw(this.X0Y0_胴_節3_鱗2);
			Are.Draw(this.X0Y0_胴_節4_胴);
			Are.Draw(this.X0Y0_胴_節4_鱗1);
			Are.Draw(this.X0Y0_胴_節4_鱗3);
			Are.Draw(this.X0Y0_胴_節4_鱗2);
			Are.Draw(this.X0Y0_胴_節5_胴);
			Are.Draw(this.X0Y0_胴_節5_鱗1);
			Are.Draw(this.X0Y0_胴_節5_鱗3);
			Are.Draw(this.X0Y0_胴_節5_鱗2);
			Are.Draw(this.X0Y0_胴_節6_胴);
			Are.Draw(this.X0Y0_胴_節6_鱗1);
			Are.Draw(this.X0Y0_胴_節6_鱗3);
			Are.Draw(this.X0Y0_胴_節6_鱗2);
			Are.Draw(this.X0Y0_胴_節7_胴);
			Are.Draw(this.X0Y0_胴_節7_鱗1);
			Are.Draw(this.X0Y0_胴_節7_鱗3);
			Are.Draw(this.X0Y0_胴_節7_鱗2);
			Are.Draw(this.X0Y0_胴_節8_胴);
			Are.Draw(this.X0Y0_胴_節8_鱗1);
			Are.Draw(this.X0Y0_胴_節8_鱗3);
			Are.Draw(this.X0Y0_胴_節8_鱗2);
			Are.Draw(this.X0Y0_胴_節9_胴);
			Are.Draw(this.X0Y0_胴_節9_鱗1);
			Are.Draw(this.X0Y0_胴_節9_鱗3);
			Are.Draw(this.X0Y0_胴_節9_鱗2);
			Are.Draw(this.X0Y0_胴_節10_胴);
			Are.Draw(this.X0Y0_胴_節10_鱗1);
			Are.Draw(this.X0Y0_胴_節10_鱗3);
			Are.Draw(this.X0Y0_胴_節10_鱗2);
			Are.Draw(this.X0Y0_胴_節11_胴);
			Are.Draw(this.X0Y0_胴_節11_鱗1);
			Are.Draw(this.X0Y0_胴_節11_鱗3);
			Are.Draw(this.X0Y0_胴_節11_鱗2);
			Are.Draw(this.X0Y0_胴_節12_胴);
			Are.Draw(this.X0Y0_胴_節12_鱗1);
			Are.Draw(this.X0Y0_胴_節12_鱗3);
			Are.Draw(this.X0Y0_胴_節12_鱗2);
			Are.Draw(this.X0Y0_胴_節13_胴);
			Are.Draw(this.X0Y0_胴_節13_鱗1);
			Are.Draw(this.X0Y0_胴_節13_鱗3);
			Are.Draw(this.X0Y0_胴_節13_鱗2);
			Are.Draw(this.X0Y0_胴_節14_胴);
			Are.Draw(this.X0Y0_胴_節14_鱗1);
			Are.Draw(this.X0Y0_胴_節14_鱗3);
			Are.Draw(this.X0Y0_胴_節14_鱗2);
			Are.Draw(this.X0Y0_胴_節15_胴);
			Are.Draw(this.X0Y0_胴_節15_鱗1);
			Are.Draw(this.X0Y0_胴_節15_鱗3);
			Are.Draw(this.X0Y0_胴_節15_鱗2);
			Are.Draw(this.X0Y0_胴_節16_胴);
			Are.Draw(this.X0Y0_胴_節16_鱗1);
			Are.Draw(this.X0Y0_胴_節16_鱗3);
			Are.Draw(this.X0Y0_胴_節16_鱗2);
			Are.Draw(this.X0Y0_胴_輪_革);
			Are.Draw(this.X0Y0_胴_輪_金具1);
			Are.Draw(this.X0Y0_胴_輪_金具2);
			Are.Draw(this.X0Y0_胴_輪_金具3);
			Are.Draw(this.X0Y0_胴_輪_金具左);
			Are.Draw(this.X0Y0_胴_輪_金具右);
			this.鎖1.描画0(Are);
			Are.Draw(this.X0Y0_胴_節17_胴);
			Are.Draw(this.X0Y0_胴_節17_鱗1);
			Are.Draw(this.X0Y0_胴_節17_鱗3);
			Are.Draw(this.X0Y0_胴_節17_鱗2);
			Are.Draw(this.X0Y0_胴_節18_胴);
			Are.Draw(this.X0Y0_胴_節18_鱗1);
			Are.Draw(this.X0Y0_胴_節18_鱗3);
			Are.Draw(this.X0Y0_胴_節18_鱗2);
			Are.Draw(this.X0Y0_頭_口膜_口膜1);
			Are.Draw(this.X0Y0_頭_口膜_口膜2);
			Are.Draw(this.X0Y0_頭_口膜_口膜3);
			Are.Draw(this.X0Y0_頭_口膜_口膜4);
			Are.Draw(this.X0Y0_頭_口膜_口膜5);
			Are.Draw(this.X0Y0_頭_口膜_口膜6);
			Are.Draw(this.X0Y0_頭_口膜_口膜8);
			Are.Draw(this.X0Y0_頭_口膜_口膜7);
			Are.Draw(this.X0Y0_頭_上顎歯後_歯1);
			Are.Draw(this.X0Y0_頭_上顎歯後_歯2);
			Are.Draw(this.X0Y0_頭_上顎歯後_歯3);
			Are.Draw(this.X0Y0_頭_下顎_歯_後_歯1);
			Are.Draw(this.X0Y0_頭_下顎_歯_後_歯2);
			Are.Draw(this.X0Y0_頭_下顎_歯_後_歯3);
			Are.Draw(this.X0Y0_頭_下顎_歯_前_歯1);
			Are.Draw(this.X0Y0_頭_下顎_歯_前_歯2);
			Are.Draw(this.X0Y0_頭_下顎_歯_前_歯3);
			Are.Draw(this.X0Y0_頭_下顎_眼孔1);
			Are.Draw(this.X0Y0_頭_下顎_眼孔2);
			Are.Draw(this.X0Y0_頭_下顎_眼_眼1_眼2);
			Are.Draw(this.X0Y0_頭_下顎_眼_眼1_眼1);
			Are.Draw(this.X0Y0_頭_下顎_眼_眼2_眼2);
			Are.Draw(this.X0Y0_頭_下顎_眼_眼2_眼1);
			Are.Draw(this.X0Y0_頭_下顎_眼下_眼下);
			Are.Draw(this.X0Y0_頭_下顎_眼下_線);
			Are.Draw(this.X0Y0_頭_下顎_頭部_前_頭9);
			Are.Draw(this.X0Y0_頭_下顎_頭部_前_頭8);
			Are.Draw(this.X0Y0_頭_下顎_頭部_前_頭7);
			Are.Draw(this.X0Y0_頭_下顎_頭部_前_頭6);
			Are.Draw(this.X0Y0_頭_下顎_頭部_前_頭5);
			Are.Draw(this.X0Y0_頭_下顎_頭部_前_頭4);
			Are.Draw(this.X0Y0_頭_下顎_頭部_前_頭3);
			Are.Draw(this.X0Y0_頭_下顎_頭部_前_頭2);
			Are.Draw(this.X0Y0_頭_下顎_頭部_前_頭1);
			Are.Draw(this.X0Y0_頭_上顎_歯_前_歯1);
			Are.Draw(this.X0Y0_頭_上顎_歯_前_歯2);
			Are.Draw(this.X0Y0_頭_上顎_歯_前_歯3);
			Are.Draw(this.X0Y0_頭_上顎_眼孔1);
			Are.Draw(this.X0Y0_頭_上顎_眼孔2);
			Are.Draw(this.X0Y0_頭_上顎_眼_眼1_眼2);
			Are.Draw(this.X0Y0_頭_上顎_眼_眼1_眼1);
			Are.Draw(this.X0Y0_頭_上顎_眼_眼2_眼2);
			Are.Draw(this.X0Y0_頭_上顎_眼_眼2_眼1);
			Are.Draw(this.X0Y0_頭_上顎_眼下_眼下);
			Are.Draw(this.X0Y0_頭_上顎_眼下_線);
			Are.Draw(this.X0Y0_頭_上顎_頭部_前_頭9);
			Are.Draw(this.X0Y0_頭_上顎_頭部_前_頭8);
			Are.Draw(this.X0Y0_頭_上顎_頭部_前_頭7);
			Are.Draw(this.X0Y0_頭_上顎_頭部_前_頭6);
			Are.Draw(this.X0Y0_頭_上顎_頭部_前_頭5);
			Are.Draw(this.X0Y0_頭_上顎_頭部_前_頭4);
			Are.Draw(this.X0Y0_頭_上顎_頭部_前_頭3);
			Are.Draw(this.X0Y0_頭_上顎_頭部_前_頭2);
			Are.Draw(this.X0Y0_頭_上顎_頭部_前_頭1);
			Are.Draw(this.X0Y0_頭_輪_革);
			Are.Draw(this.X0Y0_頭_輪_金具1);
			Are.Draw(this.X0Y0_頭_輪_金具2);
			Are.Draw(this.X0Y0_頭_輪_金具3);
			Are.Draw(this.X0Y0_頭_輪_金具左);
			Are.Draw(this.X0Y0_頭_輪_金具右);
			Are.Draw(this.X0Y0_脚前_上腕);
			Are.Draw(this.X0Y0_脚前_下腕);
			Are.Draw(this.X0Y0_脚前_手_親指_爪);
			Are.Draw(this.X0Y0_脚前_手_手);
			Are.Draw(this.X0Y0_脚前_手_人指_指);
			Are.Draw(this.X0Y0_脚前_手_人指_爪);
			Are.Draw(this.X0Y0_脚前_手_人指_水掻);
			Are.Draw(this.X0Y0_脚前_手_人指_鱗_鱗4);
			Are.Draw(this.X0Y0_脚前_手_人指_鱗_鱗3);
			Are.Draw(this.X0Y0_脚前_手_人指_鱗_鱗2);
			Are.Draw(this.X0Y0_脚前_手_人指_鱗_鱗1);
			Are.Draw(this.X0Y0_脚前_手_中指_指);
			Are.Draw(this.X0Y0_脚前_手_中指_爪);
			Are.Draw(this.X0Y0_脚前_手_中指_水掻);
			Are.Draw(this.X0Y0_脚前_手_中指_鱗_鱗4);
			Are.Draw(this.X0Y0_脚前_手_中指_鱗_鱗3);
			Are.Draw(this.X0Y0_脚前_手_中指_鱗_鱗2);
			Are.Draw(this.X0Y0_脚前_手_中指_鱗_鱗1);
			Are.Draw(this.X0Y0_脚前_手_薬指_指);
			Are.Draw(this.X0Y0_脚前_手_薬指_爪);
			Are.Draw(this.X0Y0_脚前_手_薬指_水掻);
			Are.Draw(this.X0Y0_脚前_手_薬指_鱗_鱗4);
			Are.Draw(this.X0Y0_脚前_手_薬指_鱗_鱗3);
			Are.Draw(this.X0Y0_脚前_手_薬指_鱗_鱗2);
			Are.Draw(this.X0Y0_脚前_手_薬指_鱗_鱗1);
			Are.Draw(this.X0Y0_脚前_手_小指_指);
			Are.Draw(this.X0Y0_脚前_手_小指_爪);
			Are.Draw(this.X0Y0_脚前_手_小指_鱗_鱗4);
			Are.Draw(this.X0Y0_脚前_手_小指_鱗_鱗3);
			Are.Draw(this.X0Y0_脚前_手_小指_鱗_鱗2);
			Are.Draw(this.X0Y0_脚前_手_小指_鱗_鱗1);
			Are.Draw(this.X0Y0_脚前_手_鱗_鱗3);
			Are.Draw(this.X0Y0_脚前_手_鱗_鱗2);
			Are.Draw(this.X0Y0_脚前_手_鱗_鱗1);
			Are.Draw(this.X0Y0_脚前_下腕鱗_鱗小_鱗9);
			Are.Draw(this.X0Y0_脚前_下腕鱗_鱗小_鱗8);
			Are.Draw(this.X0Y0_脚前_下腕鱗_鱗小_鱗7);
			Are.Draw(this.X0Y0_脚前_下腕鱗_鱗小_鱗6);
			Are.Draw(this.X0Y0_脚前_下腕鱗_鱗小_鱗5);
			Are.Draw(this.X0Y0_脚前_下腕鱗_鱗小_鱗4);
			Are.Draw(this.X0Y0_脚前_下腕鱗_鱗小_鱗3);
			Are.Draw(this.X0Y0_脚前_下腕鱗_鱗小_鱗2);
			Are.Draw(this.X0Y0_脚前_下腕鱗_鱗小_鱗1);
			Are.Draw(this.X0Y0_脚前_下腕鱗_鱗大_鱗9);
			Are.Draw(this.X0Y0_脚前_下腕鱗_鱗大_鱗8);
			Are.Draw(this.X0Y0_脚前_下腕鱗_鱗大_鱗7);
			Are.Draw(this.X0Y0_脚前_下腕鱗_鱗大_鱗6);
			Are.Draw(this.X0Y0_脚前_下腕鱗_鱗大_鱗5);
			Are.Draw(this.X0Y0_脚前_下腕鱗_鱗大_鱗4);
			Are.Draw(this.X0Y0_脚前_下腕鱗_鱗大_鱗3);
			Are.Draw(this.X0Y0_脚前_下腕鱗_鱗大_鱗2);
			Are.Draw(this.X0Y0_脚前_下腕鱗_鱗大_鱗1);
			Are.Draw(this.X0Y0_脚前_上腕鱗_鱗5);
			Are.Draw(this.X0Y0_脚前_上腕鱗_鱗4);
			Are.Draw(this.X0Y0_脚前_上腕鱗_鱗3);
			Are.Draw(this.X0Y0_脚前_上腕鱗_鱗2);
			Are.Draw(this.X0Y0_脚前_上腕鱗_鱗1);
			Are.Draw(this.X0Y0_脚前_鰭_鰭膜1);
			Are.Draw(this.X0Y0_脚前_鰭_鰭条1);
			Are.Draw(this.X0Y0_脚前_鰭_鰭膜2);
			Are.Draw(this.X0Y0_脚前_鰭_鰭条2);
			Are.Draw(this.X0Y0_脚前_鰭_鰭膜3);
			Are.Draw(this.X0Y0_脚前_輪_革);
			Are.Draw(this.X0Y0_脚前_輪_金具1);
			Are.Draw(this.X0Y0_脚前_輪_金具2);
			Are.Draw(this.X0Y0_脚前_輪_金具3);
			Are.Draw(this.X0Y0_脚前_輪_金具左);
			Are.Draw(this.X0Y0_脚前_輪_金具右);
			this.鎖5.描画0(Are);
		}

		public override void Dispose()
		{
			base.Dispose();
			this.鎖1.Dispose();
			this.鎖3.Dispose();
			this.鎖5.Dispose();
		}

		public override double 濃度
		{
			get
			{
				return this.脚後_鰭_鰭膜1CD.不透明度;
			}
			set
			{
				this.脚後_鰭_鰭膜1CD.不透明度 = value;
				this.脚後_鰭_鰭条1CD.不透明度 = value;
				this.脚後_鰭_鰭膜2CD.不透明度 = value;
				this.脚後_鰭_鰭条2CD.不透明度 = value;
				this.脚後_鰭_鰭膜3CD.不透明度 = value;
				this.脚後_上腕CD.不透明度 = value;
				this.脚後_下腕CD.不透明度 = value;
				this.脚後_手_手CD.不透明度 = value;
				this.脚後_手_小指_指CD.不透明度 = value;
				this.脚後_手_小指_爪CD.不透明度 = value;
				this.脚後_手_小指_鱗_鱗4CD.不透明度 = value;
				this.脚後_手_小指_鱗_鱗3CD.不透明度 = value;
				this.脚後_手_小指_鱗_鱗2CD.不透明度 = value;
				this.脚後_手_小指_鱗_鱗1CD.不透明度 = value;
				this.脚後_手_小指_水掻CD.不透明度 = value;
				this.脚後_手_薬指_指CD.不透明度 = value;
				this.脚後_手_薬指_爪CD.不透明度 = value;
				this.脚後_手_薬指_水掻CD.不透明度 = value;
				this.脚後_手_薬指_鱗_鱗4CD.不透明度 = value;
				this.脚後_手_薬指_鱗_鱗3CD.不透明度 = value;
				this.脚後_手_薬指_鱗_鱗2CD.不透明度 = value;
				this.脚後_手_薬指_鱗_鱗1CD.不透明度 = value;
				this.脚後_手_中指_指CD.不透明度 = value;
				this.脚後_手_中指_爪CD.不透明度 = value;
				this.脚後_手_中指_水掻CD.不透明度 = value;
				this.脚後_手_中指_鱗_鱗4CD.不透明度 = value;
				this.脚後_手_中指_鱗_鱗3CD.不透明度 = value;
				this.脚後_手_中指_鱗_鱗2CD.不透明度 = value;
				this.脚後_手_中指_鱗_鱗1CD.不透明度 = value;
				this.脚後_手_人指_指CD.不透明度 = value;
				this.脚後_手_人指_爪CD.不透明度 = value;
				this.脚後_手_人指_鱗_鱗4CD.不透明度 = value;
				this.脚後_手_人指_鱗_鱗3CD.不透明度 = value;
				this.脚後_手_人指_鱗_鱗2CD.不透明度 = value;
				this.脚後_手_人指_鱗_鱗1CD.不透明度 = value;
				this.脚後_手_鱗_鱗3CD.不透明度 = value;
				this.脚後_手_鱗_鱗2CD.不透明度 = value;
				this.脚後_手_鱗_鱗1CD.不透明度 = value;
				this.脚後_手_親指_爪CD.不透明度 = value;
				this.脚後_下腕鱗_鱗小_鱗9CD.不透明度 = value;
				this.脚後_下腕鱗_鱗小_鱗8CD.不透明度 = value;
				this.脚後_下腕鱗_鱗小_鱗7CD.不透明度 = value;
				this.脚後_下腕鱗_鱗小_鱗6CD.不透明度 = value;
				this.脚後_下腕鱗_鱗小_鱗5CD.不透明度 = value;
				this.脚後_下腕鱗_鱗小_鱗4CD.不透明度 = value;
				this.脚後_下腕鱗_鱗小_鱗3CD.不透明度 = value;
				this.脚後_下腕鱗_鱗小_鱗2CD.不透明度 = value;
				this.脚後_下腕鱗_鱗小_鱗1CD.不透明度 = value;
				this.脚後_下腕鱗_鱗大_鱗9CD.不透明度 = value;
				this.脚後_下腕鱗_鱗大_鱗8CD.不透明度 = value;
				this.脚後_下腕鱗_鱗大_鱗7CD.不透明度 = value;
				this.脚後_下腕鱗_鱗大_鱗6CD.不透明度 = value;
				this.脚後_下腕鱗_鱗大_鱗5CD.不透明度 = value;
				this.脚後_下腕鱗_鱗大_鱗4CD.不透明度 = value;
				this.脚後_下腕鱗_鱗大_鱗3CD.不透明度 = value;
				this.脚後_下腕鱗_鱗大_鱗2CD.不透明度 = value;
				this.脚後_下腕鱗_鱗大_鱗1CD.不透明度 = value;
				this.脚後_上腕鱗_鱗5CD.不透明度 = value;
				this.脚後_上腕鱗_鱗4CD.不透明度 = value;
				this.脚後_上腕鱗_鱗3CD.不透明度 = value;
				this.脚後_上腕鱗_鱗2CD.不透明度 = value;
				this.脚後_上腕鱗_鱗1CD.不透明度 = value;
				this.脚後_輪_革CD.不透明度 = value;
				this.脚後_輪_金具1CD.不透明度 = value;
				this.脚後_輪_金具2CD.不透明度 = value;
				this.脚後_輪_金具3CD.不透明度 = value;
				this.脚後_輪_金具左CD.不透明度 = value;
				this.脚後_輪_金具右CD.不透明度 = value;
				this.上顎頭部後_頭2CD.不透明度 = value;
				this.上顎頭部後_頭1CD.不透明度 = value;
				this.下顎頭部後_頭2CD.不透明度 = value;
				this.下顎頭部後_頭1CD.不透明度 = value;
				this.胴_節1_胴CD.不透明度 = value;
				this.胴_節1_鱗1CD.不透明度 = value;
				this.胴_節1_鱗3CD.不透明度 = value;
				this.胴_節1_鱗2CD.不透明度 = value;
				this.胴_節2_胴CD.不透明度 = value;
				this.胴_節2_鱗1CD.不透明度 = value;
				this.胴_節2_鱗3CD.不透明度 = value;
				this.胴_節2_鱗2CD.不透明度 = value;
				this.胴_節3_胴CD.不透明度 = value;
				this.胴_節3_鱗1CD.不透明度 = value;
				this.胴_節3_鱗3CD.不透明度 = value;
				this.胴_節3_鱗2CD.不透明度 = value;
				this.胴_節4_胴CD.不透明度 = value;
				this.胴_節4_鱗1CD.不透明度 = value;
				this.胴_節4_鱗3CD.不透明度 = value;
				this.胴_節4_鱗2CD.不透明度 = value;
				this.胴_節5_胴CD.不透明度 = value;
				this.胴_節5_鱗1CD.不透明度 = value;
				this.胴_節5_鱗3CD.不透明度 = value;
				this.胴_節5_鱗2CD.不透明度 = value;
				this.胴_節6_胴CD.不透明度 = value;
				this.胴_節6_鱗1CD.不透明度 = value;
				this.胴_節6_鱗3CD.不透明度 = value;
				this.胴_節6_鱗2CD.不透明度 = value;
				this.胴_節7_胴CD.不透明度 = value;
				this.胴_節7_鱗1CD.不透明度 = value;
				this.胴_節7_鱗3CD.不透明度 = value;
				this.胴_節7_鱗2CD.不透明度 = value;
				this.胴_節8_胴CD.不透明度 = value;
				this.胴_節8_鱗1CD.不透明度 = value;
				this.胴_節8_鱗3CD.不透明度 = value;
				this.胴_節8_鱗2CD.不透明度 = value;
				this.胴_節9_胴CD.不透明度 = value;
				this.胴_節9_鱗1CD.不透明度 = value;
				this.胴_節9_鱗3CD.不透明度 = value;
				this.胴_節9_鱗2CD.不透明度 = value;
				this.胴_節10_胴CD.不透明度 = value;
				this.胴_節10_鱗1CD.不透明度 = value;
				this.胴_節10_鱗3CD.不透明度 = value;
				this.胴_節10_鱗2CD.不透明度 = value;
				this.胴_節11_胴CD.不透明度 = value;
				this.胴_節11_鱗1CD.不透明度 = value;
				this.胴_節11_鱗3CD.不透明度 = value;
				this.胴_節11_鱗2CD.不透明度 = value;
				this.胴_節12_胴CD.不透明度 = value;
				this.胴_節12_鱗1CD.不透明度 = value;
				this.胴_節12_鱗3CD.不透明度 = value;
				this.胴_節12_鱗2CD.不透明度 = value;
				this.胴_節13_胴CD.不透明度 = value;
				this.胴_節13_鱗1CD.不透明度 = value;
				this.胴_節13_鱗3CD.不透明度 = value;
				this.胴_節13_鱗2CD.不透明度 = value;
				this.胴_節14_胴CD.不透明度 = value;
				this.胴_節14_鱗1CD.不透明度 = value;
				this.胴_節14_鱗3CD.不透明度 = value;
				this.胴_節14_鱗2CD.不透明度 = value;
				this.胴_節15_胴CD.不透明度 = value;
				this.胴_節15_鱗1CD.不透明度 = value;
				this.胴_節15_鱗3CD.不透明度 = value;
				this.胴_節15_鱗2CD.不透明度 = value;
				this.胴_節16_胴CD.不透明度 = value;
				this.胴_節16_鱗1CD.不透明度 = value;
				this.胴_節16_鱗3CD.不透明度 = value;
				this.胴_節16_鱗2CD.不透明度 = value;
				this.胴_節17_胴CD.不透明度 = value;
				this.胴_節17_鱗1CD.不透明度 = value;
				this.胴_節17_鱗3CD.不透明度 = value;
				this.胴_節17_鱗2CD.不透明度 = value;
				this.胴_節18_胴CD.不透明度 = value;
				this.胴_節18_鱗1CD.不透明度 = value;
				this.胴_節18_鱗3CD.不透明度 = value;
				this.胴_節18_鱗2CD.不透明度 = value;
				this.胴_輪_革CD.不透明度 = value;
				this.胴_輪_金具1CD.不透明度 = value;
				this.胴_輪_金具2CD.不透明度 = value;
				this.胴_輪_金具3CD.不透明度 = value;
				this.胴_輪_金具左CD.不透明度 = value;
				this.胴_輪_金具右CD.不透明度 = value;
				this.頭_口膜_口膜1CD.不透明度 = value;
				this.頭_口膜_口膜2CD.不透明度 = value;
				this.頭_口膜_口膜3CD.不透明度 = value;
				this.頭_口膜_口膜4CD.不透明度 = value;
				this.頭_口膜_口膜5CD.不透明度 = value;
				this.頭_口膜_口膜6CD.不透明度 = value;
				this.頭_口膜_口膜7CD.不透明度 = value;
				this.頭_口膜_口膜8CD.不透明度 = value;
				this.頭_上顎歯後_歯1CD.不透明度 = value;
				this.頭_上顎歯後_歯2CD.不透明度 = value;
				this.頭_上顎歯後_歯3CD.不透明度 = value;
				this.頭_下顎_歯_後_歯1CD.不透明度 = value;
				this.頭_下顎_歯_後_歯2CD.不透明度 = value;
				this.頭_下顎_歯_後_歯3CD.不透明度 = value;
				this.頭_下顎_歯_前_歯1CD.不透明度 = value;
				this.頭_下顎_歯_前_歯2CD.不透明度 = value;
				this.頭_下顎_歯_前_歯3CD.不透明度 = value;
				this.頭_下顎_眼孔1CD.不透明度 = value;
				this.頭_下顎_眼孔2CD.不透明度 = value;
				this.頭_下顎_眼_眼1_眼2CD.不透明度 = value;
				this.頭_下顎_眼_眼1_眼1CD.不透明度 = value;
				this.頭_下顎_眼_眼2_眼2CD.不透明度 = value;
				this.頭_下顎_眼_眼2_眼1CD.不透明度 = value;
				this.頭_下顎_眼下_眼下CD.不透明度 = value;
				this.頭_下顎_眼下_線CD.不透明度 = value;
				this.頭_下顎_頭部_前_頭9CD.不透明度 = value;
				this.頭_下顎_頭部_前_頭8CD.不透明度 = value;
				this.頭_下顎_頭部_前_頭7CD.不透明度 = value;
				this.頭_下顎_頭部_前_頭6CD.不透明度 = value;
				this.頭_下顎_頭部_前_頭5CD.不透明度 = value;
				this.頭_下顎_頭部_前_頭4CD.不透明度 = value;
				this.頭_下顎_頭部_前_頭3CD.不透明度 = value;
				this.頭_下顎_頭部_前_頭2CD.不透明度 = value;
				this.頭_下顎_頭部_前_頭1CD.不透明度 = value;
				this.頭_上顎_歯_前_歯1CD.不透明度 = value;
				this.頭_上顎_歯_前_歯2CD.不透明度 = value;
				this.頭_上顎_歯_前_歯3CD.不透明度 = value;
				this.頭_上顎_眼孔1CD.不透明度 = value;
				this.頭_上顎_眼孔2CD.不透明度 = value;
				this.頭_上顎_眼_眼1_眼2CD.不透明度 = value;
				this.頭_上顎_眼_眼1_眼1CD.不透明度 = value;
				this.頭_上顎_眼_眼2_眼2CD.不透明度 = value;
				this.頭_上顎_眼_眼2_眼1CD.不透明度 = value;
				this.頭_上顎_眼下_眼下CD.不透明度 = value;
				this.頭_上顎_眼下_線CD.不透明度 = value;
				this.頭_上顎_頭部_前_頭9CD.不透明度 = value;
				this.頭_上顎_頭部_前_頭8CD.不透明度 = value;
				this.頭_上顎_頭部_前_頭7CD.不透明度 = value;
				this.頭_上顎_頭部_前_頭6CD.不透明度 = value;
				this.頭_上顎_頭部_前_頭5CD.不透明度 = value;
				this.頭_上顎_頭部_前_頭4CD.不透明度 = value;
				this.頭_上顎_頭部_前_頭3CD.不透明度 = value;
				this.頭_上顎_頭部_前_頭2CD.不透明度 = value;
				this.頭_上顎_頭部_前_頭1CD.不透明度 = value;
				this.頭_輪_革CD.不透明度 = value;
				this.頭_輪_金具1CD.不透明度 = value;
				this.頭_輪_金具2CD.不透明度 = value;
				this.頭_輪_金具3CD.不透明度 = value;
				this.頭_輪_金具左CD.不透明度 = value;
				this.頭_輪_金具右CD.不透明度 = value;
				this.脚前_上腕CD.不透明度 = value;
				this.脚前_下腕CD.不透明度 = value;
				this.脚前_手_親指_爪CD.不透明度 = value;
				this.脚前_手_手CD.不透明度 = value;
				this.脚前_手_人指_指CD.不透明度 = value;
				this.脚前_手_人指_爪CD.不透明度 = value;
				this.脚前_手_人指_水掻CD.不透明度 = value;
				this.脚前_手_人指_鱗_鱗4CD.不透明度 = value;
				this.脚前_手_人指_鱗_鱗3CD.不透明度 = value;
				this.脚前_手_人指_鱗_鱗2CD.不透明度 = value;
				this.脚前_手_人指_鱗_鱗1CD.不透明度 = value;
				this.脚前_手_中指_指CD.不透明度 = value;
				this.脚前_手_中指_爪CD.不透明度 = value;
				this.脚前_手_中指_水掻CD.不透明度 = value;
				this.脚前_手_中指_鱗_鱗4CD.不透明度 = value;
				this.脚前_手_中指_鱗_鱗3CD.不透明度 = value;
				this.脚前_手_中指_鱗_鱗2CD.不透明度 = value;
				this.脚前_手_中指_鱗_鱗1CD.不透明度 = value;
				this.脚前_手_薬指_指CD.不透明度 = value;
				this.脚前_手_薬指_爪CD.不透明度 = value;
				this.脚前_手_薬指_水掻CD.不透明度 = value;
				this.脚前_手_薬指_鱗_鱗4CD.不透明度 = value;
				this.脚前_手_薬指_鱗_鱗3CD.不透明度 = value;
				this.脚前_手_薬指_鱗_鱗2CD.不透明度 = value;
				this.脚前_手_薬指_鱗_鱗1CD.不透明度 = value;
				this.脚前_手_小指_指CD.不透明度 = value;
				this.脚前_手_小指_爪CD.不透明度 = value;
				this.脚前_手_小指_鱗_鱗4CD.不透明度 = value;
				this.脚前_手_小指_鱗_鱗3CD.不透明度 = value;
				this.脚前_手_小指_鱗_鱗2CD.不透明度 = value;
				this.脚前_手_小指_鱗_鱗1CD.不透明度 = value;
				this.脚前_手_鱗_鱗3CD.不透明度 = value;
				this.脚前_手_鱗_鱗2CD.不透明度 = value;
				this.脚前_手_鱗_鱗1CD.不透明度 = value;
				this.脚前_下腕鱗_鱗小_鱗9CD.不透明度 = value;
				this.脚前_下腕鱗_鱗小_鱗8CD.不透明度 = value;
				this.脚前_下腕鱗_鱗小_鱗7CD.不透明度 = value;
				this.脚前_下腕鱗_鱗小_鱗6CD.不透明度 = value;
				this.脚前_下腕鱗_鱗小_鱗5CD.不透明度 = value;
				this.脚前_下腕鱗_鱗小_鱗4CD.不透明度 = value;
				this.脚前_下腕鱗_鱗小_鱗3CD.不透明度 = value;
				this.脚前_下腕鱗_鱗小_鱗2CD.不透明度 = value;
				this.脚前_下腕鱗_鱗小_鱗1CD.不透明度 = value;
				this.脚前_下腕鱗_鱗大_鱗9CD.不透明度 = value;
				this.脚前_下腕鱗_鱗大_鱗8CD.不透明度 = value;
				this.脚前_下腕鱗_鱗大_鱗7CD.不透明度 = value;
				this.脚前_下腕鱗_鱗大_鱗6CD.不透明度 = value;
				this.脚前_下腕鱗_鱗大_鱗5CD.不透明度 = value;
				this.脚前_下腕鱗_鱗大_鱗4CD.不透明度 = value;
				this.脚前_下腕鱗_鱗大_鱗3CD.不透明度 = value;
				this.脚前_下腕鱗_鱗大_鱗2CD.不透明度 = value;
				this.脚前_下腕鱗_鱗大_鱗1CD.不透明度 = value;
				this.脚前_上腕鱗_鱗5CD.不透明度 = value;
				this.脚前_上腕鱗_鱗4CD.不透明度 = value;
				this.脚前_上腕鱗_鱗3CD.不透明度 = value;
				this.脚前_上腕鱗_鱗2CD.不透明度 = value;
				this.脚前_上腕鱗_鱗1CD.不透明度 = value;
				this.脚前_鰭_鰭膜1CD.不透明度 = value;
				this.脚前_鰭_鰭条1CD.不透明度 = value;
				this.脚前_鰭_鰭膜2CD.不透明度 = value;
				this.脚前_鰭_鰭条2CD.不透明度 = value;
				this.脚前_鰭_鰭膜3CD.不透明度 = value;
				this.脚前_輪_革CD.不透明度 = value;
				this.脚前_輪_金具1CD.不透明度 = value;
				this.脚前_輪_金具2CD.不透明度 = value;
				this.脚前_輪_金具3CD.不透明度 = value;
				this.脚前_輪_金具左CD.不透明度 = value;
				this.脚前_輪_金具右CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_脚後_上腕.AngleBase = num * -125.0;
			this.X0Y0_脚後_下腕.AngleBase = num * 8.0;
			this.X0Y0_脚後_手_手.AngleBase = num * 36.0;
			this.X0Y0_脚後_手_小指_指.AngleBase = num * 19.0;
			this.X0Y0_脚後_手_小指_爪.AngleBase = 0.0;
			this.X0Y0_脚後_手_薬指_指.AngleBase = num * 19.0;
			this.X0Y0_脚後_手_薬指_爪.AngleBase = 0.0;
			this.X0Y0_脚後_手_中指_指.AngleBase = num * 19.0;
			this.X0Y0_脚後_手_中指_爪.AngleBase = 0.0;
			this.X0Y0_脚後_手_人指_指.AngleBase = num * 19.0;
			this.X0Y0_脚後_手_人指_爪.AngleBase = 0.0;
			this.X0Y0_脚後_手_親指_爪.AngleBase = num * -18.0;
			this.X0Y0_胴_節1_胴.AngleBase = num * -55.0;
			this.X0Y0_胴_節2_胴.AngleBase = num * 7.0;
			this.X0Y0_胴_節3_胴.AngleBase = num * 7.0;
			this.X0Y0_胴_節4_胴.AngleBase = num * 7.0;
			this.X0Y0_胴_節5_胴.AngleBase = num * 7.0;
			this.X0Y0_胴_節6_胴.AngleBase = num * 7.0;
			this.X0Y0_胴_節7_胴.AngleBase = num * 10.0;
			this.X0Y0_胴_節8_胴.AngleBase = num * 10.0;
			this.X0Y0_胴_節9_胴.AngleBase = num * 10.0;
			this.X0Y0_胴_節10_胴.AngleBase = num * 20.0;
			this.X0Y0_胴_節11_胴.AngleBase = num * 15.0;
			this.X0Y0_胴_節12_胴.AngleBase = num * 15.0;
			this.X0Y0_胴_節13_胴.AngleBase = num * 15.0;
			this.X0Y0_胴_節14_胴.AngleBase = num * -2.0;
			this.X0Y0_胴_節15_胴.AngleBase = num * -2.0;
			this.X0Y0_胴_節16_胴.AngleBase = num * -2.0;
			this.X0Y0_胴_節17_胴.AngleBase = num * -5.0;
			this.X0Y0_胴_節18_胴.AngleBase = num * -25.0;
			this.X0Y0_頭_口膜_口膜1.AngleBase = num * -35.0;
			this.X0Y0_頭_下顎_眼下_眼下.AngleBase = 0.0;
			this.X0Y0_頭_上顎_眼下_眼下.AngleBase = 0.0;
			this.X0Y0_脚前_上腕.AngleBase = num * -105.0;
			this.X0Y0_脚前_下腕.AngleBase = num * 8.0;
			this.X0Y0_脚前_手_親指_爪.AngleBase = num * -18.0;
			this.X0Y0_脚前_手_手.AngleBase = num * 36.0;
			this.X0Y0_脚前_手_人指_指.AngleBase = num * 19.0;
			this.X0Y0_脚前_手_人指_爪.AngleBase = 0.0;
			this.X0Y0_脚前_手_中指_指.AngleBase = num * 19.0;
			this.X0Y0_脚前_手_中指_爪.AngleBase = 0.0;
			this.X0Y0_脚前_手_薬指_指.AngleBase = num * 19.0;
			this.X0Y0_脚前_手_薬指_爪.AngleBase = 0.0;
			this.X0Y0_脚前_手_小指_指.AngleBase = num * 19.0;
			this.X0Y0_脚前_手_小指_爪.AngleBase = 0.0;
			this.本体.JoinPAall();
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_脚後_輪_革 || p == this.X0Y0_脚後_輪_金具1 || p == this.X0Y0_脚後_輪_金具2 || p == this.X0Y0_脚後_輪_金具3 || p == this.X0Y0_脚後_輪_金具左 || p == this.X0Y0_脚後_輪_金具右 || p == this.X0Y0_胴_輪_革 || p == this.X0Y0_胴_輪_金具1 || p == this.X0Y0_胴_輪_金具2 || p == this.X0Y0_胴_輪_金具3 || p == this.X0Y0_胴_輪_金具左 || p == this.X0Y0_胴_輪_金具右 || p == this.X0Y0_頭_輪_革 || p == this.X0Y0_頭_輪_金具1 || p == this.X0Y0_頭_輪_金具2 || p == this.X0Y0_頭_輪_金具3 || p == this.X0Y0_頭_輪_金具左 || p == this.X0Y0_頭_輪_金具右 || p == this.X0Y0_脚前_輪_革 || p == this.X0Y0_脚前_輪_金具1 || p == this.X0Y0_脚前_輪_金具2 || p == this.X0Y0_脚前_輪_金具3 || p == this.X0Y0_脚前_輪_金具左 || p == this.X0Y0_脚前_輪_金具右;
		}

		public override IEnumerable<Par> Enum軸()
		{
			yield return this.X0Y0_胴_節1_胴;
			yield return this.X0Y0_胴_節2_胴;
			yield return this.X0Y0_胴_節3_胴;
			yield return this.X0Y0_胴_節4_胴;
			yield return this.X0Y0_胴_節5_胴;
			yield return this.X0Y0_胴_節6_胴;
			yield return this.X0Y0_胴_節7_胴;
			yield return this.X0Y0_胴_節8_胴;
			yield return this.X0Y0_胴_節9_胴;
			yield return this.X0Y0_胴_節10_胴;
			yield return this.X0Y0_胴_節11_胴;
			yield return this.X0Y0_胴_節12_胴;
			yield return this.X0Y0_胴_節13_胴;
			yield return this.X0Y0_胴_節14_胴;
			yield return this.X0Y0_胴_節15_胴;
			yield return this.X0Y0_胴_節16_胴;
			yield return this.X0Y0_胴_節17_胴;
			yield return this.X0Y0_胴_節18_胴;
			yield break;
		}

		public JointS 頭_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴_節18_胴, 0);
			}
		}

		public JointS 上腕左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴_節9_胴, 1);
			}
		}

		public JointS 上腕右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴_節10_胴, 1);
			}
		}

		public JointS 下腕左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_脚前_上腕, 0);
			}
		}

		public JointS 下腕右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_脚後_上腕, 0);
			}
		}

		public JointS 手左_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_脚前_下腕, 0);
			}
		}

		public JointS 手右_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_脚後_下腕, 0);
			}
		}

		public JointS 鎖1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴_輪_金具左, 0);
			}
		}

		public JointS 鎖2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_胴_輪_金具右, 0);
			}
		}

		public JointS 鎖3_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_脚後_輪_金具左, 0);
			}
		}

		public JointS 鎖4_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_脚後_輪_金具右, 0);
			}
		}

		public JointS 鎖5_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_脚前_輪_金具左, 0);
			}
		}

		public JointS 鎖6_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_脚前_輪_金具右, 0);
			}
		}

		public override void 色更新()
		{
			this.X0Y0_脚後_鰭_鰭膜1CP.Update();
			this.X0Y0_脚後_鰭_鰭条1CP.Update();
			this.X0Y0_脚後_鰭_鰭膜2CP.Update();
			this.X0Y0_脚後_鰭_鰭条2CP.Update();
			this.X0Y0_脚後_鰭_鰭膜3CP.Update();
			this.X0Y0_脚後_上腕CP.Update();
			this.X0Y0_脚後_下腕CP.Update();
			this.X0Y0_脚後_手_手CP.Update();
			this.X0Y0_脚後_手_小指_指CP.Update();
			this.X0Y0_脚後_手_小指_爪CP.Update();
			this.X0Y0_脚後_手_小指_鱗_鱗4CP.Update();
			this.X0Y0_脚後_手_小指_鱗_鱗3CP.Update();
			this.X0Y0_脚後_手_小指_鱗_鱗2CP.Update();
			this.X0Y0_脚後_手_小指_鱗_鱗1CP.Update();
			this.X0Y0_脚後_手_小指_水掻CP.Update();
			this.X0Y0_脚後_手_薬指_指CP.Update();
			this.X0Y0_脚後_手_薬指_爪CP.Update();
			this.X0Y0_脚後_手_薬指_水掻CP.Update();
			this.X0Y0_脚後_手_薬指_鱗_鱗4CP.Update();
			this.X0Y0_脚後_手_薬指_鱗_鱗3CP.Update();
			this.X0Y0_脚後_手_薬指_鱗_鱗2CP.Update();
			this.X0Y0_脚後_手_薬指_鱗_鱗1CP.Update();
			this.X0Y0_脚後_手_中指_指CP.Update();
			this.X0Y0_脚後_手_中指_爪CP.Update();
			this.X0Y0_脚後_手_中指_水掻CP.Update();
			this.X0Y0_脚後_手_中指_鱗_鱗4CP.Update();
			this.X0Y0_脚後_手_中指_鱗_鱗3CP.Update();
			this.X0Y0_脚後_手_中指_鱗_鱗2CP.Update();
			this.X0Y0_脚後_手_中指_鱗_鱗1CP.Update();
			this.X0Y0_脚後_手_人指_指CP.Update();
			this.X0Y0_脚後_手_人指_爪CP.Update();
			this.X0Y0_脚後_手_人指_鱗_鱗4CP.Update();
			this.X0Y0_脚後_手_人指_鱗_鱗3CP.Update();
			this.X0Y0_脚後_手_人指_鱗_鱗2CP.Update();
			this.X0Y0_脚後_手_人指_鱗_鱗1CP.Update();
			this.X0Y0_脚後_手_鱗_鱗3CP.Update();
			this.X0Y0_脚後_手_鱗_鱗2CP.Update();
			this.X0Y0_脚後_手_鱗_鱗1CP.Update();
			this.X0Y0_脚後_手_親指_爪CP.Update();
			this.X0Y0_脚後_下腕鱗_鱗小_鱗9CP.Update();
			this.X0Y0_脚後_下腕鱗_鱗小_鱗8CP.Update();
			this.X0Y0_脚後_下腕鱗_鱗小_鱗7CP.Update();
			this.X0Y0_脚後_下腕鱗_鱗小_鱗6CP.Update();
			this.X0Y0_脚後_下腕鱗_鱗小_鱗5CP.Update();
			this.X0Y0_脚後_下腕鱗_鱗小_鱗4CP.Update();
			this.X0Y0_脚後_下腕鱗_鱗小_鱗3CP.Update();
			this.X0Y0_脚後_下腕鱗_鱗小_鱗2CP.Update();
			this.X0Y0_脚後_下腕鱗_鱗小_鱗1CP.Update();
			this.X0Y0_脚後_下腕鱗_鱗大_鱗9CP.Update();
			this.X0Y0_脚後_下腕鱗_鱗大_鱗8CP.Update();
			this.X0Y0_脚後_下腕鱗_鱗大_鱗7CP.Update();
			this.X0Y0_脚後_下腕鱗_鱗大_鱗6CP.Update();
			this.X0Y0_脚後_下腕鱗_鱗大_鱗5CP.Update();
			this.X0Y0_脚後_下腕鱗_鱗大_鱗4CP.Update();
			this.X0Y0_脚後_下腕鱗_鱗大_鱗3CP.Update();
			this.X0Y0_脚後_下腕鱗_鱗大_鱗2CP.Update();
			this.X0Y0_脚後_下腕鱗_鱗大_鱗1CP.Update();
			this.X0Y0_脚後_上腕鱗_鱗5CP.Update();
			this.X0Y0_脚後_上腕鱗_鱗4CP.Update();
			this.X0Y0_脚後_上腕鱗_鱗3CP.Update();
			this.X0Y0_脚後_上腕鱗_鱗2CP.Update();
			this.X0Y0_脚後_上腕鱗_鱗1CP.Update();
			this.X0Y0_脚後_輪_革CP.Update();
			this.X0Y0_脚後_輪_金具1CP.Update();
			this.X0Y0_脚後_輪_金具2CP.Update();
			this.X0Y0_脚後_輪_金具3CP.Update();
			this.X0Y0_脚後_輪_金具左CP.Update();
			this.X0Y0_脚後_輪_金具右CP.Update();
			this.X0Y0_上顎頭部後_頭2CP.Update();
			this.X0Y0_上顎頭部後_頭1CP.Update();
			this.X0Y0_下顎頭部後_頭2CP.Update();
			this.X0Y0_下顎頭部後_頭1CP.Update();
			this.X0Y0_胴_節1_胴CP.Update();
			this.X0Y0_胴_節1_鱗1CP.Update();
			this.X0Y0_胴_節1_鱗3CP.Update();
			this.X0Y0_胴_節1_鱗2CP.Update();
			this.X0Y0_胴_節2_胴CP.Update();
			this.X0Y0_胴_節2_鱗1CP.Update();
			this.X0Y0_胴_節2_鱗3CP.Update();
			this.X0Y0_胴_節2_鱗2CP.Update();
			this.X0Y0_胴_節3_胴CP.Update();
			this.X0Y0_胴_節3_鱗1CP.Update();
			this.X0Y0_胴_節3_鱗3CP.Update();
			this.X0Y0_胴_節3_鱗2CP.Update();
			this.X0Y0_胴_節4_胴CP.Update();
			this.X0Y0_胴_節4_鱗1CP.Update();
			this.X0Y0_胴_節4_鱗3CP.Update();
			this.X0Y0_胴_節4_鱗2CP.Update();
			this.X0Y0_胴_節5_胴CP.Update();
			this.X0Y0_胴_節5_鱗1CP.Update();
			this.X0Y0_胴_節5_鱗3CP.Update();
			this.X0Y0_胴_節5_鱗2CP.Update();
			this.X0Y0_胴_節6_胴CP.Update();
			this.X0Y0_胴_節6_鱗1CP.Update();
			this.X0Y0_胴_節6_鱗3CP.Update();
			this.X0Y0_胴_節6_鱗2CP.Update();
			this.X0Y0_胴_節7_胴CP.Update();
			this.X0Y0_胴_節7_鱗1CP.Update();
			this.X0Y0_胴_節7_鱗3CP.Update();
			this.X0Y0_胴_節7_鱗2CP.Update();
			this.X0Y0_胴_節8_胴CP.Update();
			this.X0Y0_胴_節8_鱗1CP.Update();
			this.X0Y0_胴_節8_鱗3CP.Update();
			this.X0Y0_胴_節8_鱗2CP.Update();
			this.X0Y0_胴_節9_胴CP.Update();
			this.X0Y0_胴_節9_鱗1CP.Update();
			this.X0Y0_胴_節9_鱗3CP.Update();
			this.X0Y0_胴_節9_鱗2CP.Update();
			this.X0Y0_胴_節10_胴CP.Update();
			this.X0Y0_胴_節10_鱗1CP.Update();
			this.X0Y0_胴_節10_鱗3CP.Update();
			this.X0Y0_胴_節10_鱗2CP.Update();
			this.X0Y0_胴_節11_胴CP.Update();
			this.X0Y0_胴_節11_鱗1CP.Update();
			this.X0Y0_胴_節11_鱗3CP.Update();
			this.X0Y0_胴_節11_鱗2CP.Update();
			this.X0Y0_胴_節12_胴CP.Update();
			this.X0Y0_胴_節12_鱗1CP.Update();
			this.X0Y0_胴_節12_鱗3CP.Update();
			this.X0Y0_胴_節12_鱗2CP.Update();
			this.X0Y0_胴_節13_胴CP.Update();
			this.X0Y0_胴_節13_鱗1CP.Update();
			this.X0Y0_胴_節13_鱗3CP.Update();
			this.X0Y0_胴_節13_鱗2CP.Update();
			this.X0Y0_胴_節14_胴CP.Update();
			this.X0Y0_胴_節14_鱗1CP.Update();
			this.X0Y0_胴_節14_鱗3CP.Update();
			this.X0Y0_胴_節14_鱗2CP.Update();
			this.X0Y0_胴_節15_胴CP.Update();
			this.X0Y0_胴_節15_鱗1CP.Update();
			this.X0Y0_胴_節15_鱗3CP.Update();
			this.X0Y0_胴_節15_鱗2CP.Update();
			this.X0Y0_胴_節16_胴CP.Update();
			this.X0Y0_胴_節16_鱗1CP.Update();
			this.X0Y0_胴_節16_鱗3CP.Update();
			this.X0Y0_胴_節16_鱗2CP.Update();
			this.X0Y0_胴_輪_革CP.Update();
			this.X0Y0_胴_輪_金具1CP.Update();
			this.X0Y0_胴_輪_金具2CP.Update();
			this.X0Y0_胴_輪_金具3CP.Update();
			this.X0Y0_胴_輪_金具左CP.Update();
			this.X0Y0_胴_輪_金具右CP.Update();
			this.X0Y0_胴_節17_胴CP.Update();
			this.X0Y0_胴_節17_鱗1CP.Update();
			this.X0Y0_胴_節17_鱗3CP.Update();
			this.X0Y0_胴_節17_鱗2CP.Update();
			this.X0Y0_胴_節18_胴CP.Update();
			this.X0Y0_胴_節18_鱗1CP.Update();
			this.X0Y0_胴_節18_鱗3CP.Update();
			this.X0Y0_胴_節18_鱗2CP.Update();
			this.X0Y0_頭_口膜_口膜1CP.Update();
			this.X0Y0_頭_口膜_口膜2CP.Update();
			this.X0Y0_頭_口膜_口膜3CP.Update();
			this.X0Y0_頭_口膜_口膜4CP.Update();
			this.X0Y0_頭_口膜_口膜5CP.Update();
			this.X0Y0_頭_口膜_口膜6CP.Update();
			this.X0Y0_頭_口膜_口膜7CP.Update();
			this.X0Y0_頭_口膜_口膜8CP.Update();
			this.X0Y0_頭_上顎歯後_歯1CP.Update();
			this.X0Y0_頭_上顎歯後_歯2CP.Update();
			this.X0Y0_頭_上顎歯後_歯3CP.Update();
			this.X0Y0_頭_下顎_歯_後_歯1CP.Update();
			this.X0Y0_頭_下顎_歯_後_歯2CP.Update();
			this.X0Y0_頭_下顎_歯_後_歯3CP.Update();
			this.X0Y0_頭_下顎_歯_前_歯1CP.Update();
			this.X0Y0_頭_下顎_歯_前_歯2CP.Update();
			this.X0Y0_頭_下顎_歯_前_歯3CP.Update();
			this.X0Y0_頭_下顎_眼孔1CP.Update();
			this.X0Y0_頭_下顎_眼孔2CP.Update();
			this.X0Y0_頭_下顎_眼_眼1_眼2CP.Update();
			this.X0Y0_頭_下顎_眼_眼1_眼1CP.Update();
			this.X0Y0_頭_下顎_眼_眼2_眼2CP.Update();
			this.X0Y0_頭_下顎_眼_眼2_眼1CP.Update();
			this.X0Y0_頭_下顎_眼下_眼下CP.Update();
			this.X0Y0_頭_下顎_眼下_線CP.Update();
			this.X0Y0_頭_下顎_頭部_前_頭9CP.Update();
			this.X0Y0_頭_下顎_頭部_前_頭8CP.Update();
			this.X0Y0_頭_下顎_頭部_前_頭7CP.Update();
			this.X0Y0_頭_下顎_頭部_前_頭6CP.Update();
			this.X0Y0_頭_下顎_頭部_前_頭5CP.Update();
			this.X0Y0_頭_下顎_頭部_前_頭4CP.Update();
			this.X0Y0_頭_下顎_頭部_前_頭3CP.Update();
			this.X0Y0_頭_下顎_頭部_前_頭2CP.Update();
			this.X0Y0_頭_下顎_頭部_前_頭1CP.Update();
			this.X0Y0_頭_上顎_歯_前_歯1CP.Update();
			this.X0Y0_頭_上顎_歯_前_歯2CP.Update();
			this.X0Y0_頭_上顎_歯_前_歯3CP.Update();
			this.X0Y0_頭_上顎_眼孔1CP.Update();
			this.X0Y0_頭_上顎_眼孔2CP.Update();
			this.X0Y0_頭_上顎_眼_眼1_眼2CP.Update();
			this.X0Y0_頭_上顎_眼_眼1_眼1CP.Update();
			this.X0Y0_頭_上顎_眼_眼2_眼2CP.Update();
			this.X0Y0_頭_上顎_眼_眼2_眼1CP.Update();
			this.X0Y0_頭_上顎_眼下_眼下CP.Update();
			this.X0Y0_頭_上顎_眼下_線CP.Update();
			this.X0Y0_頭_上顎_頭部_前_頭9CP.Update();
			this.X0Y0_頭_上顎_頭部_前_頭8CP.Update();
			this.X0Y0_頭_上顎_頭部_前_頭7CP.Update();
			this.X0Y0_頭_上顎_頭部_前_頭6CP.Update();
			this.X0Y0_頭_上顎_頭部_前_頭5CP.Update();
			this.X0Y0_頭_上顎_頭部_前_頭4CP.Update();
			this.X0Y0_頭_上顎_頭部_前_頭3CP.Update();
			this.X0Y0_頭_上顎_頭部_前_頭2CP.Update();
			this.X0Y0_頭_上顎_頭部_前_頭1CP.Update();
			this.X0Y0_頭_輪_革CP.Update();
			this.X0Y0_頭_輪_金具1CP.Update();
			this.X0Y0_頭_輪_金具2CP.Update();
			this.X0Y0_頭_輪_金具3CP.Update();
			this.X0Y0_頭_輪_金具左CP.Update();
			this.X0Y0_頭_輪_金具右CP.Update();
			this.X0Y0_脚前_上腕CP.Update();
			this.X0Y0_脚前_下腕CP.Update();
			this.X0Y0_脚前_手_親指_爪CP.Update();
			this.X0Y0_脚前_手_手CP.Update();
			this.X0Y0_脚前_手_人指_指CP.Update();
			this.X0Y0_脚前_手_人指_爪CP.Update();
			this.X0Y0_脚前_手_人指_水掻CP.Update();
			this.X0Y0_脚前_手_人指_鱗_鱗4CP.Update();
			this.X0Y0_脚前_手_人指_鱗_鱗3CP.Update();
			this.X0Y0_脚前_手_人指_鱗_鱗2CP.Update();
			this.X0Y0_脚前_手_人指_鱗_鱗1CP.Update();
			this.X0Y0_脚前_手_中指_指CP.Update();
			this.X0Y0_脚前_手_中指_爪CP.Update();
			this.X0Y0_脚前_手_中指_水掻CP.Update();
			this.X0Y0_脚前_手_中指_鱗_鱗4CP.Update();
			this.X0Y0_脚前_手_中指_鱗_鱗3CP.Update();
			this.X0Y0_脚前_手_中指_鱗_鱗2CP.Update();
			this.X0Y0_脚前_手_中指_鱗_鱗1CP.Update();
			this.X0Y0_脚前_手_薬指_指CP.Update();
			this.X0Y0_脚前_手_薬指_爪CP.Update();
			this.X0Y0_脚前_手_薬指_水掻CP.Update();
			this.X0Y0_脚前_手_薬指_鱗_鱗4CP.Update();
			this.X0Y0_脚前_手_薬指_鱗_鱗3CP.Update();
			this.X0Y0_脚前_手_薬指_鱗_鱗2CP.Update();
			this.X0Y0_脚前_手_薬指_鱗_鱗1CP.Update();
			this.X0Y0_脚前_手_小指_指CP.Update();
			this.X0Y0_脚前_手_小指_爪CP.Update();
			this.X0Y0_脚前_手_小指_鱗_鱗4CP.Update();
			this.X0Y0_脚前_手_小指_鱗_鱗3CP.Update();
			this.X0Y0_脚前_手_小指_鱗_鱗2CP.Update();
			this.X0Y0_脚前_手_小指_鱗_鱗1CP.Update();
			this.X0Y0_脚前_手_鱗_鱗3CP.Update();
			this.X0Y0_脚前_手_鱗_鱗2CP.Update();
			this.X0Y0_脚前_手_鱗_鱗1CP.Update();
			this.X0Y0_脚前_下腕鱗_鱗小_鱗9CP.Update();
			this.X0Y0_脚前_下腕鱗_鱗小_鱗8CP.Update();
			this.X0Y0_脚前_下腕鱗_鱗小_鱗7CP.Update();
			this.X0Y0_脚前_下腕鱗_鱗小_鱗6CP.Update();
			this.X0Y0_脚前_下腕鱗_鱗小_鱗5CP.Update();
			this.X0Y0_脚前_下腕鱗_鱗小_鱗4CP.Update();
			this.X0Y0_脚前_下腕鱗_鱗小_鱗3CP.Update();
			this.X0Y0_脚前_下腕鱗_鱗小_鱗2CP.Update();
			this.X0Y0_脚前_下腕鱗_鱗小_鱗1CP.Update();
			this.X0Y0_脚前_下腕鱗_鱗大_鱗9CP.Update();
			this.X0Y0_脚前_下腕鱗_鱗大_鱗8CP.Update();
			this.X0Y0_脚前_下腕鱗_鱗大_鱗7CP.Update();
			this.X0Y0_脚前_下腕鱗_鱗大_鱗6CP.Update();
			this.X0Y0_脚前_下腕鱗_鱗大_鱗5CP.Update();
			this.X0Y0_脚前_下腕鱗_鱗大_鱗4CP.Update();
			this.X0Y0_脚前_下腕鱗_鱗大_鱗3CP.Update();
			this.X0Y0_脚前_下腕鱗_鱗大_鱗2CP.Update();
			this.X0Y0_脚前_下腕鱗_鱗大_鱗1CP.Update();
			this.X0Y0_脚前_上腕鱗_鱗5CP.Update();
			this.X0Y0_脚前_上腕鱗_鱗4CP.Update();
			this.X0Y0_脚前_上腕鱗_鱗3CP.Update();
			this.X0Y0_脚前_上腕鱗_鱗2CP.Update();
			this.X0Y0_脚前_上腕鱗_鱗1CP.Update();
			this.X0Y0_脚前_鰭_鰭膜1CP.Update();
			this.X0Y0_脚前_鰭_鰭条1CP.Update();
			this.X0Y0_脚前_鰭_鰭膜2CP.Update();
			this.X0Y0_脚前_鰭_鰭条2CP.Update();
			this.X0Y0_脚前_鰭_鰭膜3CP.Update();
			this.X0Y0_脚前_輪_革CP.Update();
			this.X0Y0_脚前_輪_金具1CP.Update();
			this.X0Y0_脚前_輪_金具2CP.Update();
			this.X0Y0_脚前_輪_金具3CP.Update();
			this.X0Y0_脚前_輪_金具左CP.Update();
			this.X0Y0_脚前_輪_金具右CP.Update();
			this.鎖1.接続PA();
			this.鎖3.接続PA();
			this.鎖5.接続PA();
			this.鎖1.色更新();
			this.鎖3.色更新();
			this.鎖5.色更新();
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
			this.脚後_鰭_鰭膜1CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚後_鰭_鰭条1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚後_鰭_鰭膜2CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚後_鰭_鰭条2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚後_鰭_鰭膜3CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚後_上腕CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚後_下腕CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚後_手_手CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚後_手_小指_指CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚後_手_小指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚後_手_小指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_小指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_小指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_小指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_小指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚後_手_薬指_指CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚後_手_薬指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚後_手_薬指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚後_手_薬指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_薬指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_薬指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_薬指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_中指_指CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚後_手_中指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚後_手_中指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚後_手_中指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_中指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_中指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_中指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_人指_指CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚後_手_人指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚後_手_人指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_人指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_人指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_人指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_親指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚後_下腕鱗_鱗小_鱗9CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚後_下腕鱗_鱗小_鱗8CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚後_下腕鱗_鱗小_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚後_下腕鱗_鱗小_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚後_下腕鱗_鱗小_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚後_下腕鱗_鱗小_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚後_下腕鱗_鱗小_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚後_下腕鱗_鱗小_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚後_下腕鱗_鱗小_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚後_下腕鱗_鱗大_鱗9CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_下腕鱗_鱗大_鱗8CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_下腕鱗_鱗大_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_下腕鱗_鱗大_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_下腕鱗_鱗大_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_下腕鱗_鱗大_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_下腕鱗_鱗大_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_下腕鱗_鱗大_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_下腕鱗_鱗大_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_上腕鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_上腕鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_上腕鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_上腕鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_上腕鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_輪_革CD = new ColorD();
			this.脚後_輪_金具1CD = new ColorD();
			this.脚後_輪_金具2CD = new ColorD();
			this.脚後_輪_金具3CD = new ColorD();
			this.脚後_輪_金具左CD = new ColorD();
			this.脚後_輪_金具右CD = new ColorD();
			this.上顎頭部後_頭2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.上顎頭部後_頭1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.下顎頭部後_頭2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.下顎頭部後_頭1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節1_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節1_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節1_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節1_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節2_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節2_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節2_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節2_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節3_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節3_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節3_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節3_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節4_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節4_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節4_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節4_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節5_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節5_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節5_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節5_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節6_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節6_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節6_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節6_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節7_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節7_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節7_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節7_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節8_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節8_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節8_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節8_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節9_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節9_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節9_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節9_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節10_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節10_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節10_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節10_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節11_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節11_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節11_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節11_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節12_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節12_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節12_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節12_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節13_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節13_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節13_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節13_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節14_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節14_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節14_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節14_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節15_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節15_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節15_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節15_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節16_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節16_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節16_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節16_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節17_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節17_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節17_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節17_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節18_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節18_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節18_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節18_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_輪_革CD = new ColorD();
			this.胴_輪_金具1CD = new ColorD();
			this.胴_輪_金具2CD = new ColorD();
			this.胴_輪_金具3CD = new ColorD();
			this.胴_輪_金具左CD = new ColorD();
			this.胴_輪_金具右CD = new ColorD();
			this.頭_口膜_口膜1CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_口膜_口膜2CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_口膜_口膜3CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_口膜_口膜4CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_口膜_口膜5CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_口膜_口膜6CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_口膜_口膜7CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_口膜_口膜8CD = new ColorD(ref Col.Black, ref 体配色.体0R);
			this.頭_上顎歯後_歯1CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_上顎歯後_歯2CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_上顎歯後_歯3CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_下顎_歯_後_歯1CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_下顎_歯_後_歯2CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_下顎_歯_後_歯3CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_下顎_歯_前_歯1CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_下顎_歯_前_歯2CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_下顎_歯_前_歯3CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_下顎_眼孔1CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_下顎_眼孔2CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_下顎_眼_眼1_眼2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_下顎_眼_眼1_眼1CD = new ColorD(ref Col.Black, ref 体配色.眼0R);
			this.頭_下顎_眼_眼2_眼2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_下顎_眼_眼2_眼1CD = new ColorD(ref Col.Black, ref 体配色.眼0R);
			this.頭_下顎_眼下_眼下CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_下顎_眼下_線CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_下顎_頭部_前_頭9CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_下顎_頭部_前_頭8CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_下顎_頭部_前_頭7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_下顎_頭部_前_頭6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_下顎_頭部_前_頭5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_下顎_頭部_前_頭4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_下顎_頭部_前_頭3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_下顎_頭部_前_頭2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_下顎_頭部_前_頭1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_歯_前_歯1CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_上顎_歯_前_歯2CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_上顎_歯_前_歯3CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_上顎_眼孔1CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_上顎_眼孔2CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_上顎_眼_眼1_眼2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_眼_眼1_眼1CD = new ColorD(ref Col.Black, ref 体配色.眼0R);
			this.頭_上顎_眼_眼2_眼2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_眼_眼2_眼1CD = new ColorD(ref Col.Black, ref 体配色.眼0R);
			this.頭_上顎_眼下_眼下CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_眼下_線CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_頭部_前_頭9CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_頭部_前_頭8CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_頭部_前_頭7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_頭部_前_頭6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_頭部_前_頭5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_頭部_前_頭4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_頭部_前_頭3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_頭部_前_頭2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_頭部_前_頭1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_輪_革CD = new ColorD();
			this.頭_輪_金具1CD = new ColorD();
			this.頭_輪_金具2CD = new ColorD();
			this.頭_輪_金具3CD = new ColorD();
			this.頭_輪_金具左CD = new ColorD();
			this.頭_輪_金具右CD = new ColorD();
			this.脚前_上腕CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚前_下腕CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚前_手_親指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚前_手_手CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚前_手_人指_指CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚前_手_人指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚前_手_人指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚前_手_人指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_人指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_人指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_人指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_中指_指CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚前_手_中指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚前_手_中指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚前_手_中指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_中指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_中指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_中指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_薬指_指CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚前_手_薬指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚前_手_薬指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚前_手_薬指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_薬指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_薬指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_薬指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_小指_指CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚前_手_小指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚前_手_小指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_小指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_小指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_小指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_下腕鱗_鱗小_鱗9CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚前_下腕鱗_鱗小_鱗8CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚前_下腕鱗_鱗小_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚前_下腕鱗_鱗小_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚前_下腕鱗_鱗小_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚前_下腕鱗_鱗小_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚前_下腕鱗_鱗小_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚前_下腕鱗_鱗小_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚前_下腕鱗_鱗小_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚前_下腕鱗_鱗大_鱗9CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_下腕鱗_鱗大_鱗8CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_下腕鱗_鱗大_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_下腕鱗_鱗大_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_下腕鱗_鱗大_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_下腕鱗_鱗大_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_下腕鱗_鱗大_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_下腕鱗_鱗大_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_下腕鱗_鱗大_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_上腕鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_上腕鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_上腕鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_上腕鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_上腕鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_鰭_鰭膜1CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚前_鰭_鰭条1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚前_鰭_鰭膜2CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚前_鰭_鰭条2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚前_鰭_鰭膜3CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚前_輪_革CD = new ColorD();
			this.脚前_輪_金具1CD = new ColorD();
			this.脚前_輪_金具2CD = new ColorD();
			this.脚前_輪_金具3CD = new ColorD();
			this.脚前_輪_金具左CD = new ColorD();
			this.脚前_輪_金具右CD = new ColorD();
		}

		private void 配色T0(体配色 体配色)
		{
			this.脚後_鰭_鰭膜1CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚後_鰭_鰭条1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚後_鰭_鰭膜2CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚後_鰭_鰭条2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚後_鰭_鰭膜3CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚後_上腕CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_下腕CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_手CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_小指_指CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_小指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚後_手_小指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_小指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_小指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_小指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_小指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚後_手_薬指_指CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_薬指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚後_手_薬指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚後_手_薬指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_薬指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_薬指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_薬指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_中指_指CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_中指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚後_手_中指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚後_手_中指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_中指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_中指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_中指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_人指_指CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_人指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚後_手_人指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_人指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_人指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_人指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_親指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚後_下腕鱗_鱗小_鱗9CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚後_下腕鱗_鱗小_鱗8CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_下腕鱗_鱗小_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚後_下腕鱗_鱗小_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_下腕鱗_鱗小_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚後_下腕鱗_鱗小_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_下腕鱗_鱗小_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚後_下腕鱗_鱗小_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_下腕鱗_鱗小_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚後_下腕鱗_鱗大_鱗9CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_下腕鱗_鱗大_鱗8CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_下腕鱗_鱗大_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_下腕鱗_鱗大_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_下腕鱗_鱗大_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_下腕鱗_鱗大_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_下腕鱗_鱗大_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_下腕鱗_鱗大_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_下腕鱗_鱗大_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_上腕鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_上腕鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_上腕鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_上腕鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_上腕鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_輪_革CD = new ColorD();
			this.脚後_輪_金具1CD = new ColorD();
			this.脚後_輪_金具2CD = new ColorD();
			this.脚後_輪_金具3CD = new ColorD();
			this.脚後_輪_金具左CD = new ColorD();
			this.脚後_輪_金具右CD = new ColorD();
			this.上顎頭部後_頭2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.上顎頭部後_頭1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.下顎頭部後_頭2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.下顎頭部後_頭1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節1_胴CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節2_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節3_胴CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節4_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節5_胴CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節6_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節7_胴CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節8_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節9_胴CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節10_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節11_胴CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節12_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節13_胴CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節14_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節15_胴CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節16_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節17_胴CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節18_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節1_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節1_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節1_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節2_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節2_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節2_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節3_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節3_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節3_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節4_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節4_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節4_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節5_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節5_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節5_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節6_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節6_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節6_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節7_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節7_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節7_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節8_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節8_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節8_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節9_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節9_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節9_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節10_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節10_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節10_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節11_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節11_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節11_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節12_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節12_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節12_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節13_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節13_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節13_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節14_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節14_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節14_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節15_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節15_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節15_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節16_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節16_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節16_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節17_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節17_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節17_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節18_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節18_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節18_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_輪_革CD = new ColorD();
			this.胴_輪_金具1CD = new ColorD();
			this.胴_輪_金具2CD = new ColorD();
			this.胴_輪_金具3CD = new ColorD();
			this.胴_輪_金具左CD = new ColorD();
			this.胴_輪_金具右CD = new ColorD();
			this.頭_口膜_口膜1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_口膜_口膜2CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_口膜_口膜3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_口膜_口膜4CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_口膜_口膜5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_口膜_口膜6CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_口膜_口膜7CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_口膜_口膜8CD = new ColorD(ref Col.Black, ref 体配色.体0R);
			this.頭_上顎歯後_歯1CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_上顎歯後_歯2CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_上顎歯後_歯3CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_下顎_歯_後_歯1CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_下顎_歯_後_歯2CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_下顎_歯_後_歯3CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_下顎_歯_前_歯1CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_下顎_歯_前_歯2CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_下顎_歯_前_歯3CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_下顎_眼孔1CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_下顎_眼孔2CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_下顎_眼_眼1_眼2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_下顎_眼_眼1_眼1CD = new ColorD(ref Col.Black, ref 体配色.眼0R);
			this.頭_下顎_眼_眼2_眼2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_下顎_眼_眼2_眼1CD = new ColorD(ref Col.Black, ref 体配色.眼0R);
			this.頭_下顎_眼下_眼下CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_下顎_眼下_線CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_下顎_頭部_前_頭9CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_下顎_頭部_前_頭8CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_下顎_頭部_前_頭7CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_下顎_頭部_前_頭6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_下顎_頭部_前_頭5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_下顎_頭部_前_頭4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_下顎_頭部_前_頭3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_下顎_頭部_前_頭2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_下顎_頭部_前_頭1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_歯_前_歯1CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_上顎_歯_前_歯2CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_上顎_歯_前_歯3CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_上顎_眼孔1CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_上顎_眼孔2CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_上顎_眼_眼1_眼2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_眼_眼1_眼1CD = new ColorD(ref Col.Black, ref 体配色.眼0R);
			this.頭_上顎_眼_眼2_眼2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_眼_眼2_眼1CD = new ColorD(ref Col.Black, ref 体配色.眼0R);
			this.頭_上顎_眼下_眼下CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_眼下_線CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_頭部_前_頭9CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_頭部_前_頭8CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_頭部_前_頭7CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_頭部_前_頭6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_頭部_前_頭5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_頭部_前_頭4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_頭部_前_頭3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_頭部_前_頭2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_頭部_前_頭1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_輪_革CD = new ColorD();
			this.頭_輪_金具1CD = new ColorD();
			this.頭_輪_金具2CD = new ColorD();
			this.頭_輪_金具3CD = new ColorD();
			this.頭_輪_金具左CD = new ColorD();
			this.頭_輪_金具右CD = new ColorD();
			this.脚前_上腕CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_下腕CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_親指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚前_手_手CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_人指_指CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_人指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚前_手_人指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚前_手_人指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_人指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_人指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_人指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_中指_指CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_中指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚前_手_中指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚前_手_中指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_中指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_中指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_中指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_薬指_指CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_薬指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚前_手_薬指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚前_手_薬指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_薬指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_薬指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_薬指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_小指_指CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_小指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚前_手_小指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_小指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_小指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_小指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_下腕鱗_鱗小_鱗9CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚前_下腕鱗_鱗小_鱗8CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_下腕鱗_鱗小_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚前_下腕鱗_鱗小_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_下腕鱗_鱗小_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚前_下腕鱗_鱗小_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_下腕鱗_鱗小_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚前_下腕鱗_鱗小_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_下腕鱗_鱗小_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚前_下腕鱗_鱗大_鱗9CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_下腕鱗_鱗大_鱗8CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_下腕鱗_鱗大_鱗7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_下腕鱗_鱗大_鱗6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_下腕鱗_鱗大_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_下腕鱗_鱗大_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_下腕鱗_鱗大_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_下腕鱗_鱗大_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_下腕鱗_鱗大_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_上腕鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_上腕鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_上腕鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_上腕鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_上腕鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_鰭_鰭膜1CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚前_鰭_鰭条1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚前_鰭_鰭膜2CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚前_鰭_鰭条2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚前_鰭_鰭膜3CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚前_輪_革CD = new ColorD();
			this.脚前_輪_金具1CD = new ColorD();
			this.脚前_輪_金具2CD = new ColorD();
			this.脚前_輪_金具3CD = new ColorD();
			this.脚前_輪_金具左CD = new ColorD();
			this.脚前_輪_金具右CD = new ColorD();
		}

		private void 配色T1(体配色 体配色)
		{
			this.脚後_鰭_鰭膜1CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚後_鰭_鰭条1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚後_鰭_鰭膜2CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚後_鰭_鰭条2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚後_鰭_鰭膜3CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚後_上腕CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚後_下腕CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚後_手_手CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚後_手_小指_指CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚後_手_小指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚後_手_小指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_小指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_小指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_小指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_小指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚後_手_薬指_指CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚後_手_薬指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚後_手_薬指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚後_手_薬指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_薬指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_薬指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_薬指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_中指_指CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚後_手_中指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚後_手_中指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚後_手_中指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_中指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_中指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_中指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_人指_指CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚後_手_人指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚後_手_人指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_人指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_人指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_人指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_手_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_手_親指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚後_下腕鱗_鱗小_鱗9CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_下腕鱗_鱗小_鱗8CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚後_下腕鱗_鱗小_鱗7CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_下腕鱗_鱗小_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚後_下腕鱗_鱗小_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_下腕鱗_鱗小_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚後_下腕鱗_鱗小_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_下腕鱗_鱗小_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚後_下腕鱗_鱗小_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_下腕鱗_鱗大_鱗9CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_下腕鱗_鱗大_鱗8CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_下腕鱗_鱗大_鱗7CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_下腕鱗_鱗大_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_下腕鱗_鱗大_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_下腕鱗_鱗大_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_下腕鱗_鱗大_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_下腕鱗_鱗大_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_下腕鱗_鱗大_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_上腕鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_上腕鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_上腕鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_上腕鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚後_上腕鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚後_輪_革CD = new ColorD();
			this.脚後_輪_金具1CD = new ColorD();
			this.脚後_輪_金具2CD = new ColorD();
			this.脚後_輪_金具3CD = new ColorD();
			this.脚後_輪_金具左CD = new ColorD();
			this.脚後_輪_金具右CD = new ColorD();
			this.上顎頭部後_頭2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.上顎頭部後_頭1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.下顎頭部後_頭2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.下顎頭部後_頭1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節1_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節2_胴CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節3_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節4_胴CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節5_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節6_胴CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節7_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節8_胴CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節9_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節10_胴CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節11_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節12_胴CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節13_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節14_胴CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節15_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節16_胴CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節17_胴CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.胴_節18_胴CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節1_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節1_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節1_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節2_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節2_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節2_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節3_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節3_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節3_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節4_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節4_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節4_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節5_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節5_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節5_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節6_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節6_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節6_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節7_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節7_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節7_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節8_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節8_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節8_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節9_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節9_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節9_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節10_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節10_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節10_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節11_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節11_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節11_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節12_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節12_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節12_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節13_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節13_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節13_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節14_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節14_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節14_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節15_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節15_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節15_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節16_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節16_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節16_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節17_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節17_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節17_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.胴_節18_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節18_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_節18_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.胴_輪_革CD = new ColorD();
			this.胴_輪_金具1CD = new ColorD();
			this.胴_輪_金具2CD = new ColorD();
			this.胴_輪_金具3CD = new ColorD();
			this.胴_輪_金具左CD = new ColorD();
			this.胴_輪_金具右CD = new ColorD();
			this.頭_口膜_口膜1CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_口膜_口膜2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_口膜_口膜3CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_口膜_口膜4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_口膜_口膜5CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_口膜_口膜6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_口膜_口膜7CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_口膜_口膜8CD = new ColorD(ref Col.Black, ref 体配色.刺青R);
			this.頭_上顎歯後_歯1CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_上顎歯後_歯2CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_上顎歯後_歯3CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_下顎_歯_後_歯1CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_下顎_歯_後_歯2CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_下顎_歯_後_歯3CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_下顎_歯_前_歯1CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_下顎_歯_前_歯2CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_下顎_歯_前_歯3CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_下顎_眼孔1CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_下顎_眼孔2CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_下顎_眼_眼1_眼2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_下顎_眼_眼1_眼1CD = new ColorD(ref Col.Black, ref 体配色.眼0R);
			this.頭_下顎_眼_眼2_眼2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_下顎_眼_眼2_眼1CD = new ColorD(ref Col.Black, ref 体配色.眼0R);
			this.頭_下顎_眼下_眼下CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_下顎_眼下_線CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_下顎_頭部_前_頭9CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_下顎_頭部_前_頭8CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_下顎_頭部_前_頭7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_下顎_頭部_前_頭6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_下顎_頭部_前_頭5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_下顎_頭部_前_頭4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_下顎_頭部_前_頭3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_下顎_頭部_前_頭2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_下顎_頭部_前_頭1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_歯_前_歯1CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_上顎_歯_前_歯2CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_上顎_歯_前_歯3CD = new ColorD(ref Col.Black, ref 体配色.歯);
			this.頭_上顎_眼孔1CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_上顎_眼孔2CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.頭_上顎_眼_眼1_眼2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_眼_眼1_眼1CD = new ColorD(ref Col.Black, ref 体配色.眼0R);
			this.頭_上顎_眼_眼2_眼2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_眼_眼2_眼1CD = new ColorD(ref Col.Black, ref 体配色.眼0R);
			this.頭_上顎_眼下_眼下CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_眼下_線CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_頭部_前_頭9CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_頭部_前_頭8CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_頭部_前_頭7CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_頭部_前_頭6CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_頭部_前_頭5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_頭部_前_頭4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_頭部_前_頭3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_上顎_頭部_前_頭2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.頭_上顎_頭部_前_頭1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.頭_輪_革CD = new ColorD();
			this.頭_輪_金具1CD = new ColorD();
			this.頭_輪_金具2CD = new ColorD();
			this.頭_輪_金具3CD = new ColorD();
			this.頭_輪_金具左CD = new ColorD();
			this.頭_輪_金具右CD = new ColorD();
			this.脚前_上腕CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚前_下腕CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚前_手_親指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚前_手_手CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚前_手_人指_指CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚前_手_人指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚前_手_人指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚前_手_人指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_人指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_人指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_人指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_中指_指CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚前_手_中指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚前_手_中指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚前_手_中指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_中指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_中指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_中指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_薬指_指CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚前_手_薬指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚前_手_薬指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚前_手_薬指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_薬指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_薬指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_薬指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_小指_指CD = new ColorD(ref Col.Black, ref 体配色.体0O);
			this.脚前_手_小指_爪CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚前_手_小指_鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_小指_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_小指_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_小指_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_手_鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_手_鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_下腕鱗_鱗小_鱗9CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_下腕鱗_鱗小_鱗8CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚前_下腕鱗_鱗小_鱗7CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_下腕鱗_鱗小_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚前_下腕鱗_鱗小_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_下腕鱗_鱗小_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚前_下腕鱗_鱗小_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_下腕鱗_鱗小_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.脚前_下腕鱗_鱗小_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_下腕鱗_鱗大_鱗9CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_下腕鱗_鱗大_鱗8CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_下腕鱗_鱗大_鱗7CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_下腕鱗_鱗大_鱗6CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_下腕鱗_鱗大_鱗5CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_下腕鱗_鱗大_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_下腕鱗_鱗大_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_下腕鱗_鱗大_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_下腕鱗_鱗大_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_上腕鱗_鱗5CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_上腕鱗_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_上腕鱗_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_上腕鱗_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.脚前_上腕鱗_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.脚前_鰭_鰭膜1CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚前_鰭_鰭条1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚前_鰭_鰭膜2CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚前_鰭_鰭条2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.脚前_鰭_鰭膜3CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.脚前_輪_革CD = new ColorD();
			this.脚前_輪_金具1CD = new ColorD();
			this.脚前_輪_金具2CD = new ColorD();
			this.脚前_輪_金具3CD = new ColorD();
			this.脚前_輪_金具左CD = new ColorD();
			this.脚前_輪_金具右CD = new ColorD();
		}

		public void 輪1配色(拘束具色 配色)
		{
			this.頭_輪_革CD.色 = 配色.革部色;
			this.頭_輪_金具1CD.色 = 配色.金具色;
			this.頭_輪_金具2CD.色 = this.頭_輪_金具1CD.色;
			this.頭_輪_金具3CD.色 = this.頭_輪_金具1CD.色;
			this.頭_輪_金具左CD.色 = this.頭_輪_金具1CD.色;
			this.頭_輪_金具右CD.色 = this.頭_輪_金具1CD.色;
		}

		public void 輪2配色(拘束具色 配色)
		{
			this.胴_輪_革CD.色 = 配色.革部色;
			this.胴_輪_金具1CD.色 = 配色.金具色;
			this.胴_輪_金具2CD.色 = this.胴_輪_金具1CD.色;
			this.胴_輪_金具3CD.色 = this.胴_輪_金具1CD.色;
			this.胴_輪_金具左CD.色 = this.胴_輪_金具1CD.色;
			this.胴_輪_金具右CD.色 = this.胴_輪_金具1CD.色;
		}

		public void 輪3配色(拘束具色 配色)
		{
			this.脚前_輪_革CD.色 = 配色.革部色;
			this.脚前_輪_金具1CD.色 = 配色.金具色;
			this.脚前_輪_金具2CD.色 = this.脚前_輪_金具1CD.色;
			this.脚前_輪_金具3CD.色 = this.脚前_輪_金具1CD.色;
			this.脚前_輪_金具左CD.色 = this.脚前_輪_金具1CD.色;
			this.脚前_輪_金具右CD.色 = this.脚前_輪_金具1CD.色;
		}

		public void 輪4配色(拘束具色 配色)
		{
			this.脚後_輪_革CD.色 = 配色.革部色;
			this.脚後_輪_金具1CD.色 = 配色.金具色;
			this.脚後_輪_金具2CD.色 = this.脚後_輪_金具1CD.色;
			this.脚後_輪_金具3CD.色 = this.脚後_輪_金具1CD.色;
			this.脚後_輪_金具左CD.色 = this.脚後_輪_金具1CD.色;
			this.脚後_輪_金具右CD.色 = this.脚後_輪_金具1CD.色;
		}

		public void 鎖配色(鎖色 配色)
		{
			this.鎖1.配色鎖(配色);
			this.鎖3.配色鎖(配色);
			this.鎖5.配色鎖(配色);
		}

		public Par X0Y0_脚後_鰭_鰭膜1;

		public Par X0Y0_脚後_鰭_鰭条1;

		public Par X0Y0_脚後_鰭_鰭膜2;

		public Par X0Y0_脚後_鰭_鰭条2;

		public Par X0Y0_脚後_鰭_鰭膜3;

		public Par X0Y0_脚後_上腕;

		public Par X0Y0_脚後_下腕;

		public Par X0Y0_脚後_手_手;

		public Par X0Y0_脚後_手_小指_指;

		public Par X0Y0_脚後_手_小指_爪;

		public Par X0Y0_脚後_手_小指_鱗_鱗4;

		public Par X0Y0_脚後_手_小指_鱗_鱗3;

		public Par X0Y0_脚後_手_小指_鱗_鱗2;

		public Par X0Y0_脚後_手_小指_鱗_鱗1;

		public Par X0Y0_脚後_手_小指_水掻;

		public Par X0Y0_脚後_手_薬指_指;

		public Par X0Y0_脚後_手_薬指_爪;

		public Par X0Y0_脚後_手_薬指_水掻;

		public Par X0Y0_脚後_手_薬指_鱗_鱗4;

		public Par X0Y0_脚後_手_薬指_鱗_鱗3;

		public Par X0Y0_脚後_手_薬指_鱗_鱗2;

		public Par X0Y0_脚後_手_薬指_鱗_鱗1;

		public Par X0Y0_脚後_手_中指_指;

		public Par X0Y0_脚後_手_中指_爪;

		public Par X0Y0_脚後_手_中指_水掻;

		public Par X0Y0_脚後_手_中指_鱗_鱗4;

		public Par X0Y0_脚後_手_中指_鱗_鱗3;

		public Par X0Y0_脚後_手_中指_鱗_鱗2;

		public Par X0Y0_脚後_手_中指_鱗_鱗1;

		public Par X0Y0_脚後_手_人指_指;

		public Par X0Y0_脚後_手_人指_爪;

		public Par X0Y0_脚後_手_人指_鱗_鱗4;

		public Par X0Y0_脚後_手_人指_鱗_鱗3;

		public Par X0Y0_脚後_手_人指_鱗_鱗2;

		public Par X0Y0_脚後_手_人指_鱗_鱗1;

		public Par X0Y0_脚後_手_鱗_鱗3;

		public Par X0Y0_脚後_手_鱗_鱗2;

		public Par X0Y0_脚後_手_鱗_鱗1;

		public Par X0Y0_脚後_手_親指_爪;

		public Par X0Y0_脚後_下腕鱗_鱗小_鱗9;

		public Par X0Y0_脚後_下腕鱗_鱗小_鱗8;

		public Par X0Y0_脚後_下腕鱗_鱗小_鱗7;

		public Par X0Y0_脚後_下腕鱗_鱗小_鱗6;

		public Par X0Y0_脚後_下腕鱗_鱗小_鱗5;

		public Par X0Y0_脚後_下腕鱗_鱗小_鱗4;

		public Par X0Y0_脚後_下腕鱗_鱗小_鱗3;

		public Par X0Y0_脚後_下腕鱗_鱗小_鱗2;

		public Par X0Y0_脚後_下腕鱗_鱗小_鱗1;

		public Par X0Y0_脚後_下腕鱗_鱗大_鱗9;

		public Par X0Y0_脚後_下腕鱗_鱗大_鱗8;

		public Par X0Y0_脚後_下腕鱗_鱗大_鱗7;

		public Par X0Y0_脚後_下腕鱗_鱗大_鱗6;

		public Par X0Y0_脚後_下腕鱗_鱗大_鱗5;

		public Par X0Y0_脚後_下腕鱗_鱗大_鱗4;

		public Par X0Y0_脚後_下腕鱗_鱗大_鱗3;

		public Par X0Y0_脚後_下腕鱗_鱗大_鱗2;

		public Par X0Y0_脚後_下腕鱗_鱗大_鱗1;

		public Par X0Y0_脚後_上腕鱗_鱗5;

		public Par X0Y0_脚後_上腕鱗_鱗4;

		public Par X0Y0_脚後_上腕鱗_鱗3;

		public Par X0Y0_脚後_上腕鱗_鱗2;

		public Par X0Y0_脚後_上腕鱗_鱗1;

		public Par X0Y0_脚後_輪_革;

		public Par X0Y0_脚後_輪_金具1;

		public Par X0Y0_脚後_輪_金具2;

		public Par X0Y0_脚後_輪_金具3;

		public Par X0Y0_脚後_輪_金具左;

		public Par X0Y0_脚後_輪_金具右;

		public Par X0Y0_上顎頭部後_頭2;

		public Par X0Y0_上顎頭部後_頭1;

		public Par X0Y0_下顎頭部後_頭2;

		public Par X0Y0_下顎頭部後_頭1;

		public Par X0Y0_胴_節1_胴;

		public Par X0Y0_胴_節1_鱗1;

		public Par X0Y0_胴_節1_鱗3;

		public Par X0Y0_胴_節1_鱗2;

		public Par X0Y0_胴_節2_胴;

		public Par X0Y0_胴_節2_鱗1;

		public Par X0Y0_胴_節2_鱗3;

		public Par X0Y0_胴_節2_鱗2;

		public Par X0Y0_胴_節3_胴;

		public Par X0Y0_胴_節3_鱗1;

		public Par X0Y0_胴_節3_鱗3;

		public Par X0Y0_胴_節3_鱗2;

		public Par X0Y0_胴_節4_胴;

		public Par X0Y0_胴_節4_鱗1;

		public Par X0Y0_胴_節4_鱗3;

		public Par X0Y0_胴_節4_鱗2;

		public Par X0Y0_胴_節5_胴;

		public Par X0Y0_胴_節5_鱗1;

		public Par X0Y0_胴_節5_鱗3;

		public Par X0Y0_胴_節5_鱗2;

		public Par X0Y0_胴_節6_胴;

		public Par X0Y0_胴_節6_鱗1;

		public Par X0Y0_胴_節6_鱗3;

		public Par X0Y0_胴_節6_鱗2;

		public Par X0Y0_胴_節7_胴;

		public Par X0Y0_胴_節7_鱗1;

		public Par X0Y0_胴_節7_鱗3;

		public Par X0Y0_胴_節7_鱗2;

		public Par X0Y0_胴_節8_胴;

		public Par X0Y0_胴_節8_鱗1;

		public Par X0Y0_胴_節8_鱗3;

		public Par X0Y0_胴_節8_鱗2;

		public Par X0Y0_胴_節9_胴;

		public Par X0Y0_胴_節9_鱗1;

		public Par X0Y0_胴_節9_鱗3;

		public Par X0Y0_胴_節9_鱗2;

		public Par X0Y0_胴_節10_胴;

		public Par X0Y0_胴_節10_鱗1;

		public Par X0Y0_胴_節10_鱗3;

		public Par X0Y0_胴_節10_鱗2;

		public Par X0Y0_胴_節11_胴;

		public Par X0Y0_胴_節11_鱗1;

		public Par X0Y0_胴_節11_鱗3;

		public Par X0Y0_胴_節11_鱗2;

		public Par X0Y0_胴_節12_胴;

		public Par X0Y0_胴_節12_鱗1;

		public Par X0Y0_胴_節12_鱗3;

		public Par X0Y0_胴_節12_鱗2;

		public Par X0Y0_胴_節13_胴;

		public Par X0Y0_胴_節13_鱗1;

		public Par X0Y0_胴_節13_鱗3;

		public Par X0Y0_胴_節13_鱗2;

		public Par X0Y0_胴_節14_胴;

		public Par X0Y0_胴_節14_鱗1;

		public Par X0Y0_胴_節14_鱗3;

		public Par X0Y0_胴_節14_鱗2;

		public Par X0Y0_胴_節15_胴;

		public Par X0Y0_胴_節15_鱗1;

		public Par X0Y0_胴_節15_鱗3;

		public Par X0Y0_胴_節15_鱗2;

		public Par X0Y0_胴_節16_胴;

		public Par X0Y0_胴_節16_鱗1;

		public Par X0Y0_胴_節16_鱗3;

		public Par X0Y0_胴_節16_鱗2;

		public Par X0Y0_胴_輪_革;

		public Par X0Y0_胴_輪_金具1;

		public Par X0Y0_胴_輪_金具2;

		public Par X0Y0_胴_輪_金具3;

		public Par X0Y0_胴_輪_金具左;

		public Par X0Y0_胴_輪_金具右;

		public Par X0Y0_胴_節17_胴;

		public Par X0Y0_胴_節17_鱗1;

		public Par X0Y0_胴_節17_鱗3;

		public Par X0Y0_胴_節17_鱗2;

		public Par X0Y0_胴_節18_胴;

		public Par X0Y0_胴_節18_鱗1;

		public Par X0Y0_胴_節18_鱗3;

		public Par X0Y0_胴_節18_鱗2;

		public Par X0Y0_頭_口膜_口膜1;

		public Par X0Y0_頭_口膜_口膜2;

		public Par X0Y0_頭_口膜_口膜3;

		public Par X0Y0_頭_口膜_口膜4;

		public Par X0Y0_頭_口膜_口膜5;

		public Par X0Y0_頭_口膜_口膜6;

		public Par X0Y0_頭_口膜_口膜7;

		public Par X0Y0_頭_口膜_口膜8;

		public Par X0Y0_頭_上顎歯後_歯1;

		public Par X0Y0_頭_上顎歯後_歯2;

		public Par X0Y0_頭_上顎歯後_歯3;

		public Par X0Y0_頭_下顎_歯_後_歯1;

		public Par X0Y0_頭_下顎_歯_後_歯2;

		public Par X0Y0_頭_下顎_歯_後_歯3;

		public Par X0Y0_頭_下顎_歯_前_歯1;

		public Par X0Y0_頭_下顎_歯_前_歯2;

		public Par X0Y0_頭_下顎_歯_前_歯3;

		public Par X0Y0_頭_下顎_眼孔1;

		public Par X0Y0_頭_下顎_眼孔2;

		public Par X0Y0_頭_下顎_眼_眼1_眼2;

		public Par X0Y0_頭_下顎_眼_眼1_眼1;

		public Par X0Y0_頭_下顎_眼_眼2_眼2;

		public Par X0Y0_頭_下顎_眼_眼2_眼1;

		public Par X0Y0_頭_下顎_眼下_眼下;

		public Par X0Y0_頭_下顎_眼下_線;

		public Par X0Y0_頭_下顎_頭部_前_頭9;

		public Par X0Y0_頭_下顎_頭部_前_頭8;

		public Par X0Y0_頭_下顎_頭部_前_頭7;

		public Par X0Y0_頭_下顎_頭部_前_頭6;

		public Par X0Y0_頭_下顎_頭部_前_頭5;

		public Par X0Y0_頭_下顎_頭部_前_頭4;

		public Par X0Y0_頭_下顎_頭部_前_頭3;

		public Par X0Y0_頭_下顎_頭部_前_頭2;

		public Par X0Y0_頭_下顎_頭部_前_頭1;

		public Par X0Y0_頭_上顎_歯_前_歯1;

		public Par X0Y0_頭_上顎_歯_前_歯2;

		public Par X0Y0_頭_上顎_歯_前_歯3;

		public Par X0Y0_頭_上顎_眼孔1;

		public Par X0Y0_頭_上顎_眼孔2;

		public Par X0Y0_頭_上顎_眼_眼1_眼2;

		public Par X0Y0_頭_上顎_眼_眼1_眼1;

		public Par X0Y0_頭_上顎_眼_眼2_眼2;

		public Par X0Y0_頭_上顎_眼_眼2_眼1;

		public Par X0Y0_頭_上顎_眼下_眼下;

		public Par X0Y0_頭_上顎_眼下_線;

		public Par X0Y0_頭_上顎_頭部_前_頭9;

		public Par X0Y0_頭_上顎_頭部_前_頭8;

		public Par X0Y0_頭_上顎_頭部_前_頭7;

		public Par X0Y0_頭_上顎_頭部_前_頭6;

		public Par X0Y0_頭_上顎_頭部_前_頭5;

		public Par X0Y0_頭_上顎_頭部_前_頭4;

		public Par X0Y0_頭_上顎_頭部_前_頭3;

		public Par X0Y0_頭_上顎_頭部_前_頭2;

		public Par X0Y0_頭_上顎_頭部_前_頭1;

		public Par X0Y0_頭_輪_革;

		public Par X0Y0_頭_輪_金具1;

		public Par X0Y0_頭_輪_金具2;

		public Par X0Y0_頭_輪_金具3;

		public Par X0Y0_頭_輪_金具左;

		public Par X0Y0_頭_輪_金具右;

		public Par X0Y0_脚前_上腕;

		public Par X0Y0_脚前_下腕;

		public Par X0Y0_脚前_手_親指_爪;

		public Par X0Y0_脚前_手_手;

		public Par X0Y0_脚前_手_人指_指;

		public Par X0Y0_脚前_手_人指_爪;

		public Par X0Y0_脚前_手_人指_水掻;

		public Par X0Y0_脚前_手_人指_鱗_鱗4;

		public Par X0Y0_脚前_手_人指_鱗_鱗3;

		public Par X0Y0_脚前_手_人指_鱗_鱗2;

		public Par X0Y0_脚前_手_人指_鱗_鱗1;

		public Par X0Y0_脚前_手_中指_指;

		public Par X0Y0_脚前_手_中指_爪;

		public Par X0Y0_脚前_手_中指_水掻;

		public Par X0Y0_脚前_手_中指_鱗_鱗4;

		public Par X0Y0_脚前_手_中指_鱗_鱗3;

		public Par X0Y0_脚前_手_中指_鱗_鱗2;

		public Par X0Y0_脚前_手_中指_鱗_鱗1;

		public Par X0Y0_脚前_手_薬指_指;

		public Par X0Y0_脚前_手_薬指_爪;

		public Par X0Y0_脚前_手_薬指_水掻;

		public Par X0Y0_脚前_手_薬指_鱗_鱗4;

		public Par X0Y0_脚前_手_薬指_鱗_鱗3;

		public Par X0Y0_脚前_手_薬指_鱗_鱗2;

		public Par X0Y0_脚前_手_薬指_鱗_鱗1;

		public Par X0Y0_脚前_手_小指_指;

		public Par X0Y0_脚前_手_小指_爪;

		public Par X0Y0_脚前_手_小指_鱗_鱗4;

		public Par X0Y0_脚前_手_小指_鱗_鱗3;

		public Par X0Y0_脚前_手_小指_鱗_鱗2;

		public Par X0Y0_脚前_手_小指_鱗_鱗1;

		public Par X0Y0_脚前_手_鱗_鱗3;

		public Par X0Y0_脚前_手_鱗_鱗2;

		public Par X0Y0_脚前_手_鱗_鱗1;

		public Par X0Y0_脚前_下腕鱗_鱗小_鱗9;

		public Par X0Y0_脚前_下腕鱗_鱗小_鱗8;

		public Par X0Y0_脚前_下腕鱗_鱗小_鱗7;

		public Par X0Y0_脚前_下腕鱗_鱗小_鱗6;

		public Par X0Y0_脚前_下腕鱗_鱗小_鱗5;

		public Par X0Y0_脚前_下腕鱗_鱗小_鱗4;

		public Par X0Y0_脚前_下腕鱗_鱗小_鱗3;

		public Par X0Y0_脚前_下腕鱗_鱗小_鱗2;

		public Par X0Y0_脚前_下腕鱗_鱗小_鱗1;

		public Par X0Y0_脚前_下腕鱗_鱗大_鱗9;

		public Par X0Y0_脚前_下腕鱗_鱗大_鱗8;

		public Par X0Y0_脚前_下腕鱗_鱗大_鱗7;

		public Par X0Y0_脚前_下腕鱗_鱗大_鱗6;

		public Par X0Y0_脚前_下腕鱗_鱗大_鱗5;

		public Par X0Y0_脚前_下腕鱗_鱗大_鱗4;

		public Par X0Y0_脚前_下腕鱗_鱗大_鱗3;

		public Par X0Y0_脚前_下腕鱗_鱗大_鱗2;

		public Par X0Y0_脚前_下腕鱗_鱗大_鱗1;

		public Par X0Y0_脚前_上腕鱗_鱗5;

		public Par X0Y0_脚前_上腕鱗_鱗4;

		public Par X0Y0_脚前_上腕鱗_鱗3;

		public Par X0Y0_脚前_上腕鱗_鱗2;

		public Par X0Y0_脚前_上腕鱗_鱗1;

		public Par X0Y0_脚前_鰭_鰭膜1;

		public Par X0Y0_脚前_鰭_鰭条1;

		public Par X0Y0_脚前_鰭_鰭膜2;

		public Par X0Y0_脚前_鰭_鰭条2;

		public Par X0Y0_脚前_鰭_鰭膜3;

		public Par X0Y0_脚前_輪_革;

		public Par X0Y0_脚前_輪_金具1;

		public Par X0Y0_脚前_輪_金具2;

		public Par X0Y0_脚前_輪_金具3;

		public Par X0Y0_脚前_輪_金具左;

		public Par X0Y0_脚前_輪_金具右;

		public ColorD 脚後_鰭_鰭膜1CD;

		public ColorD 脚後_鰭_鰭条1CD;

		public ColorD 脚後_鰭_鰭膜2CD;

		public ColorD 脚後_鰭_鰭条2CD;

		public ColorD 脚後_鰭_鰭膜3CD;

		public ColorD 脚後_上腕CD;

		public ColorD 脚後_下腕CD;

		public ColorD 脚後_手_手CD;

		public ColorD 脚後_手_小指_指CD;

		public ColorD 脚後_手_小指_爪CD;

		public ColorD 脚後_手_小指_鱗_鱗4CD;

		public ColorD 脚後_手_小指_鱗_鱗3CD;

		public ColorD 脚後_手_小指_鱗_鱗2CD;

		public ColorD 脚後_手_小指_鱗_鱗1CD;

		public ColorD 脚後_手_小指_水掻CD;

		public ColorD 脚後_手_薬指_指CD;

		public ColorD 脚後_手_薬指_爪CD;

		public ColorD 脚後_手_薬指_水掻CD;

		public ColorD 脚後_手_薬指_鱗_鱗4CD;

		public ColorD 脚後_手_薬指_鱗_鱗3CD;

		public ColorD 脚後_手_薬指_鱗_鱗2CD;

		public ColorD 脚後_手_薬指_鱗_鱗1CD;

		public ColorD 脚後_手_中指_指CD;

		public ColorD 脚後_手_中指_爪CD;

		public ColorD 脚後_手_中指_水掻CD;

		public ColorD 脚後_手_中指_鱗_鱗4CD;

		public ColorD 脚後_手_中指_鱗_鱗3CD;

		public ColorD 脚後_手_中指_鱗_鱗2CD;

		public ColorD 脚後_手_中指_鱗_鱗1CD;

		public ColorD 脚後_手_人指_指CD;

		public ColorD 脚後_手_人指_爪CD;

		public ColorD 脚後_手_人指_鱗_鱗4CD;

		public ColorD 脚後_手_人指_鱗_鱗3CD;

		public ColorD 脚後_手_人指_鱗_鱗2CD;

		public ColorD 脚後_手_人指_鱗_鱗1CD;

		public ColorD 脚後_手_鱗_鱗3CD;

		public ColorD 脚後_手_鱗_鱗2CD;

		public ColorD 脚後_手_鱗_鱗1CD;

		public ColorD 脚後_手_親指_爪CD;

		public ColorD 脚後_下腕鱗_鱗小_鱗9CD;

		public ColorD 脚後_下腕鱗_鱗小_鱗8CD;

		public ColorD 脚後_下腕鱗_鱗小_鱗7CD;

		public ColorD 脚後_下腕鱗_鱗小_鱗6CD;

		public ColorD 脚後_下腕鱗_鱗小_鱗5CD;

		public ColorD 脚後_下腕鱗_鱗小_鱗4CD;

		public ColorD 脚後_下腕鱗_鱗小_鱗3CD;

		public ColorD 脚後_下腕鱗_鱗小_鱗2CD;

		public ColorD 脚後_下腕鱗_鱗小_鱗1CD;

		public ColorD 脚後_下腕鱗_鱗大_鱗9CD;

		public ColorD 脚後_下腕鱗_鱗大_鱗8CD;

		public ColorD 脚後_下腕鱗_鱗大_鱗7CD;

		public ColorD 脚後_下腕鱗_鱗大_鱗6CD;

		public ColorD 脚後_下腕鱗_鱗大_鱗5CD;

		public ColorD 脚後_下腕鱗_鱗大_鱗4CD;

		public ColorD 脚後_下腕鱗_鱗大_鱗3CD;

		public ColorD 脚後_下腕鱗_鱗大_鱗2CD;

		public ColorD 脚後_下腕鱗_鱗大_鱗1CD;

		public ColorD 脚後_上腕鱗_鱗5CD;

		public ColorD 脚後_上腕鱗_鱗4CD;

		public ColorD 脚後_上腕鱗_鱗3CD;

		public ColorD 脚後_上腕鱗_鱗2CD;

		public ColorD 脚後_上腕鱗_鱗1CD;

		public ColorD 脚後_輪_革CD;

		public ColorD 脚後_輪_金具1CD;

		public ColorD 脚後_輪_金具2CD;

		public ColorD 脚後_輪_金具3CD;

		public ColorD 脚後_輪_金具左CD;

		public ColorD 脚後_輪_金具右CD;

		public ColorD 上顎頭部後_頭2CD;

		public ColorD 上顎頭部後_頭1CD;

		public ColorD 下顎頭部後_頭2CD;

		public ColorD 下顎頭部後_頭1CD;

		public ColorD 胴_節1_胴CD;

		public ColorD 胴_節1_鱗1CD;

		public ColorD 胴_節1_鱗3CD;

		public ColorD 胴_節1_鱗2CD;

		public ColorD 胴_節2_胴CD;

		public ColorD 胴_節2_鱗1CD;

		public ColorD 胴_節2_鱗3CD;

		public ColorD 胴_節2_鱗2CD;

		public ColorD 胴_節3_胴CD;

		public ColorD 胴_節3_鱗1CD;

		public ColorD 胴_節3_鱗3CD;

		public ColorD 胴_節3_鱗2CD;

		public ColorD 胴_節4_胴CD;

		public ColorD 胴_節4_鱗1CD;

		public ColorD 胴_節4_鱗3CD;

		public ColorD 胴_節4_鱗2CD;

		public ColorD 胴_節5_胴CD;

		public ColorD 胴_節5_鱗1CD;

		public ColorD 胴_節5_鱗3CD;

		public ColorD 胴_節5_鱗2CD;

		public ColorD 胴_節6_胴CD;

		public ColorD 胴_節6_鱗1CD;

		public ColorD 胴_節6_鱗3CD;

		public ColorD 胴_節6_鱗2CD;

		public ColorD 胴_節7_胴CD;

		public ColorD 胴_節7_鱗1CD;

		public ColorD 胴_節7_鱗3CD;

		public ColorD 胴_節7_鱗2CD;

		public ColorD 胴_節8_胴CD;

		public ColorD 胴_節8_鱗1CD;

		public ColorD 胴_節8_鱗3CD;

		public ColorD 胴_節8_鱗2CD;

		public ColorD 胴_節9_胴CD;

		public ColorD 胴_節9_鱗1CD;

		public ColorD 胴_節9_鱗3CD;

		public ColorD 胴_節9_鱗2CD;

		public ColorD 胴_節10_胴CD;

		public ColorD 胴_節10_鱗1CD;

		public ColorD 胴_節10_鱗3CD;

		public ColorD 胴_節10_鱗2CD;

		public ColorD 胴_節11_胴CD;

		public ColorD 胴_節11_鱗1CD;

		public ColorD 胴_節11_鱗3CD;

		public ColorD 胴_節11_鱗2CD;

		public ColorD 胴_節12_胴CD;

		public ColorD 胴_節12_鱗1CD;

		public ColorD 胴_節12_鱗3CD;

		public ColorD 胴_節12_鱗2CD;

		public ColorD 胴_節13_胴CD;

		public ColorD 胴_節13_鱗1CD;

		public ColorD 胴_節13_鱗3CD;

		public ColorD 胴_節13_鱗2CD;

		public ColorD 胴_節14_胴CD;

		public ColorD 胴_節14_鱗1CD;

		public ColorD 胴_節14_鱗3CD;

		public ColorD 胴_節14_鱗2CD;

		public ColorD 胴_節15_胴CD;

		public ColorD 胴_節15_鱗1CD;

		public ColorD 胴_節15_鱗3CD;

		public ColorD 胴_節15_鱗2CD;

		public ColorD 胴_節16_胴CD;

		public ColorD 胴_節16_鱗1CD;

		public ColorD 胴_節16_鱗3CD;

		public ColorD 胴_節16_鱗2CD;

		public ColorD 胴_節17_胴CD;

		public ColorD 胴_節17_鱗1CD;

		public ColorD 胴_節17_鱗3CD;

		public ColorD 胴_節17_鱗2CD;

		public ColorD 胴_節18_胴CD;

		public ColorD 胴_節18_鱗1CD;

		public ColorD 胴_節18_鱗3CD;

		public ColorD 胴_節18_鱗2CD;

		public ColorD 胴_輪_革CD;

		public ColorD 胴_輪_金具1CD;

		public ColorD 胴_輪_金具2CD;

		public ColorD 胴_輪_金具3CD;

		public ColorD 胴_輪_金具左CD;

		public ColorD 胴_輪_金具右CD;

		public ColorD 頭_口膜_口膜1CD;

		public ColorD 頭_口膜_口膜2CD;

		public ColorD 頭_口膜_口膜3CD;

		public ColorD 頭_口膜_口膜4CD;

		public ColorD 頭_口膜_口膜5CD;

		public ColorD 頭_口膜_口膜6CD;

		public ColorD 頭_口膜_口膜7CD;

		public ColorD 頭_口膜_口膜8CD;

		public ColorD 頭_上顎歯後_歯1CD;

		public ColorD 頭_上顎歯後_歯2CD;

		public ColorD 頭_上顎歯後_歯3CD;

		public ColorD 頭_下顎_歯_後_歯1CD;

		public ColorD 頭_下顎_歯_後_歯2CD;

		public ColorD 頭_下顎_歯_後_歯3CD;

		public ColorD 頭_下顎_歯_前_歯1CD;

		public ColorD 頭_下顎_歯_前_歯2CD;

		public ColorD 頭_下顎_歯_前_歯3CD;

		public ColorD 頭_下顎_眼孔1CD;

		public ColorD 頭_下顎_眼孔2CD;

		public ColorD 頭_下顎_眼_眼1_眼2CD;

		public ColorD 頭_下顎_眼_眼1_眼1CD;

		public ColorD 頭_下顎_眼_眼2_眼2CD;

		public ColorD 頭_下顎_眼_眼2_眼1CD;

		public ColorD 頭_下顎_眼下_眼下CD;

		public ColorD 頭_下顎_眼下_線CD;

		public ColorD 頭_下顎_頭部_前_頭9CD;

		public ColorD 頭_下顎_頭部_前_頭8CD;

		public ColorD 頭_下顎_頭部_前_頭7CD;

		public ColorD 頭_下顎_頭部_前_頭6CD;

		public ColorD 頭_下顎_頭部_前_頭5CD;

		public ColorD 頭_下顎_頭部_前_頭4CD;

		public ColorD 頭_下顎_頭部_前_頭3CD;

		public ColorD 頭_下顎_頭部_前_頭2CD;

		public ColorD 頭_下顎_頭部_前_頭1CD;

		public ColorD 頭_上顎_歯_前_歯1CD;

		public ColorD 頭_上顎_歯_前_歯2CD;

		public ColorD 頭_上顎_歯_前_歯3CD;

		public ColorD 頭_上顎_眼孔1CD;

		public ColorD 頭_上顎_眼孔2CD;

		public ColorD 頭_上顎_眼_眼1_眼2CD;

		public ColorD 頭_上顎_眼_眼1_眼1CD;

		public ColorD 頭_上顎_眼_眼2_眼2CD;

		public ColorD 頭_上顎_眼_眼2_眼1CD;

		public ColorD 頭_上顎_眼下_眼下CD;

		public ColorD 頭_上顎_眼下_線CD;

		public ColorD 頭_上顎_頭部_前_頭9CD;

		public ColorD 頭_上顎_頭部_前_頭8CD;

		public ColorD 頭_上顎_頭部_前_頭7CD;

		public ColorD 頭_上顎_頭部_前_頭6CD;

		public ColorD 頭_上顎_頭部_前_頭5CD;

		public ColorD 頭_上顎_頭部_前_頭4CD;

		public ColorD 頭_上顎_頭部_前_頭3CD;

		public ColorD 頭_上顎_頭部_前_頭2CD;

		public ColorD 頭_上顎_頭部_前_頭1CD;

		public ColorD 頭_輪_革CD;

		public ColorD 頭_輪_金具1CD;

		public ColorD 頭_輪_金具2CD;

		public ColorD 頭_輪_金具3CD;

		public ColorD 頭_輪_金具左CD;

		public ColorD 頭_輪_金具右CD;

		public ColorD 脚前_上腕CD;

		public ColorD 脚前_下腕CD;

		public ColorD 脚前_手_親指_爪CD;

		public ColorD 脚前_手_手CD;

		public ColorD 脚前_手_人指_指CD;

		public ColorD 脚前_手_人指_爪CD;

		public ColorD 脚前_手_人指_水掻CD;

		public ColorD 脚前_手_人指_鱗_鱗4CD;

		public ColorD 脚前_手_人指_鱗_鱗3CD;

		public ColorD 脚前_手_人指_鱗_鱗2CD;

		public ColorD 脚前_手_人指_鱗_鱗1CD;

		public ColorD 脚前_手_中指_指CD;

		public ColorD 脚前_手_中指_爪CD;

		public ColorD 脚前_手_中指_水掻CD;

		public ColorD 脚前_手_中指_鱗_鱗4CD;

		public ColorD 脚前_手_中指_鱗_鱗3CD;

		public ColorD 脚前_手_中指_鱗_鱗2CD;

		public ColorD 脚前_手_中指_鱗_鱗1CD;

		public ColorD 脚前_手_薬指_指CD;

		public ColorD 脚前_手_薬指_爪CD;

		public ColorD 脚前_手_薬指_水掻CD;

		public ColorD 脚前_手_薬指_鱗_鱗4CD;

		public ColorD 脚前_手_薬指_鱗_鱗3CD;

		public ColorD 脚前_手_薬指_鱗_鱗2CD;

		public ColorD 脚前_手_薬指_鱗_鱗1CD;

		public ColorD 脚前_手_小指_指CD;

		public ColorD 脚前_手_小指_爪CD;

		public ColorD 脚前_手_小指_鱗_鱗4CD;

		public ColorD 脚前_手_小指_鱗_鱗3CD;

		public ColorD 脚前_手_小指_鱗_鱗2CD;

		public ColorD 脚前_手_小指_鱗_鱗1CD;

		public ColorD 脚前_手_鱗_鱗3CD;

		public ColorD 脚前_手_鱗_鱗2CD;

		public ColorD 脚前_手_鱗_鱗1CD;

		public ColorD 脚前_下腕鱗_鱗小_鱗9CD;

		public ColorD 脚前_下腕鱗_鱗小_鱗8CD;

		public ColorD 脚前_下腕鱗_鱗小_鱗7CD;

		public ColorD 脚前_下腕鱗_鱗小_鱗6CD;

		public ColorD 脚前_下腕鱗_鱗小_鱗5CD;

		public ColorD 脚前_下腕鱗_鱗小_鱗4CD;

		public ColorD 脚前_下腕鱗_鱗小_鱗3CD;

		public ColorD 脚前_下腕鱗_鱗小_鱗2CD;

		public ColorD 脚前_下腕鱗_鱗小_鱗1CD;

		public ColorD 脚前_下腕鱗_鱗大_鱗9CD;

		public ColorD 脚前_下腕鱗_鱗大_鱗8CD;

		public ColorD 脚前_下腕鱗_鱗大_鱗7CD;

		public ColorD 脚前_下腕鱗_鱗大_鱗6CD;

		public ColorD 脚前_下腕鱗_鱗大_鱗5CD;

		public ColorD 脚前_下腕鱗_鱗大_鱗4CD;

		public ColorD 脚前_下腕鱗_鱗大_鱗3CD;

		public ColorD 脚前_下腕鱗_鱗大_鱗2CD;

		public ColorD 脚前_下腕鱗_鱗大_鱗1CD;

		public ColorD 脚前_上腕鱗_鱗5CD;

		public ColorD 脚前_上腕鱗_鱗4CD;

		public ColorD 脚前_上腕鱗_鱗3CD;

		public ColorD 脚前_上腕鱗_鱗2CD;

		public ColorD 脚前_上腕鱗_鱗1CD;

		public ColorD 脚前_鰭_鰭膜1CD;

		public ColorD 脚前_鰭_鰭条1CD;

		public ColorD 脚前_鰭_鰭膜2CD;

		public ColorD 脚前_鰭_鰭条2CD;

		public ColorD 脚前_鰭_鰭膜3CD;

		public ColorD 脚前_輪_革CD;

		public ColorD 脚前_輪_金具1CD;

		public ColorD 脚前_輪_金具2CD;

		public ColorD 脚前_輪_金具3CD;

		public ColorD 脚前_輪_金具左CD;

		public ColorD 脚前_輪_金具右CD;

		public ColorP X0Y0_脚後_鰭_鰭膜1CP;

		public ColorP X0Y0_脚後_鰭_鰭条1CP;

		public ColorP X0Y0_脚後_鰭_鰭膜2CP;

		public ColorP X0Y0_脚後_鰭_鰭条2CP;

		public ColorP X0Y0_脚後_鰭_鰭膜3CP;

		public ColorP X0Y0_脚後_上腕CP;

		public ColorP X0Y0_脚後_下腕CP;

		public ColorP X0Y0_脚後_手_手CP;

		public ColorP X0Y0_脚後_手_小指_指CP;

		public ColorP X0Y0_脚後_手_小指_爪CP;

		public ColorP X0Y0_脚後_手_小指_鱗_鱗4CP;

		public ColorP X0Y0_脚後_手_小指_鱗_鱗3CP;

		public ColorP X0Y0_脚後_手_小指_鱗_鱗2CP;

		public ColorP X0Y0_脚後_手_小指_鱗_鱗1CP;

		public ColorP X0Y0_脚後_手_小指_水掻CP;

		public ColorP X0Y0_脚後_手_薬指_指CP;

		public ColorP X0Y0_脚後_手_薬指_爪CP;

		public ColorP X0Y0_脚後_手_薬指_水掻CP;

		public ColorP X0Y0_脚後_手_薬指_鱗_鱗4CP;

		public ColorP X0Y0_脚後_手_薬指_鱗_鱗3CP;

		public ColorP X0Y0_脚後_手_薬指_鱗_鱗2CP;

		public ColorP X0Y0_脚後_手_薬指_鱗_鱗1CP;

		public ColorP X0Y0_脚後_手_中指_指CP;

		public ColorP X0Y0_脚後_手_中指_爪CP;

		public ColorP X0Y0_脚後_手_中指_水掻CP;

		public ColorP X0Y0_脚後_手_中指_鱗_鱗4CP;

		public ColorP X0Y0_脚後_手_中指_鱗_鱗3CP;

		public ColorP X0Y0_脚後_手_中指_鱗_鱗2CP;

		public ColorP X0Y0_脚後_手_中指_鱗_鱗1CP;

		public ColorP X0Y0_脚後_手_人指_指CP;

		public ColorP X0Y0_脚後_手_人指_爪CP;

		public ColorP X0Y0_脚後_手_人指_鱗_鱗4CP;

		public ColorP X0Y0_脚後_手_人指_鱗_鱗3CP;

		public ColorP X0Y0_脚後_手_人指_鱗_鱗2CP;

		public ColorP X0Y0_脚後_手_人指_鱗_鱗1CP;

		public ColorP X0Y0_脚後_手_鱗_鱗3CP;

		public ColorP X0Y0_脚後_手_鱗_鱗2CP;

		public ColorP X0Y0_脚後_手_鱗_鱗1CP;

		public ColorP X0Y0_脚後_手_親指_爪CP;

		public ColorP X0Y0_脚後_下腕鱗_鱗小_鱗9CP;

		public ColorP X0Y0_脚後_下腕鱗_鱗小_鱗8CP;

		public ColorP X0Y0_脚後_下腕鱗_鱗小_鱗7CP;

		public ColorP X0Y0_脚後_下腕鱗_鱗小_鱗6CP;

		public ColorP X0Y0_脚後_下腕鱗_鱗小_鱗5CP;

		public ColorP X0Y0_脚後_下腕鱗_鱗小_鱗4CP;

		public ColorP X0Y0_脚後_下腕鱗_鱗小_鱗3CP;

		public ColorP X0Y0_脚後_下腕鱗_鱗小_鱗2CP;

		public ColorP X0Y0_脚後_下腕鱗_鱗小_鱗1CP;

		public ColorP X0Y0_脚後_下腕鱗_鱗大_鱗9CP;

		public ColorP X0Y0_脚後_下腕鱗_鱗大_鱗8CP;

		public ColorP X0Y0_脚後_下腕鱗_鱗大_鱗7CP;

		public ColorP X0Y0_脚後_下腕鱗_鱗大_鱗6CP;

		public ColorP X0Y0_脚後_下腕鱗_鱗大_鱗5CP;

		public ColorP X0Y0_脚後_下腕鱗_鱗大_鱗4CP;

		public ColorP X0Y0_脚後_下腕鱗_鱗大_鱗3CP;

		public ColorP X0Y0_脚後_下腕鱗_鱗大_鱗2CP;

		public ColorP X0Y0_脚後_下腕鱗_鱗大_鱗1CP;

		public ColorP X0Y0_脚後_上腕鱗_鱗5CP;

		public ColorP X0Y0_脚後_上腕鱗_鱗4CP;

		public ColorP X0Y0_脚後_上腕鱗_鱗3CP;

		public ColorP X0Y0_脚後_上腕鱗_鱗2CP;

		public ColorP X0Y0_脚後_上腕鱗_鱗1CP;

		public ColorP X0Y0_脚後_輪_革CP;

		public ColorP X0Y0_脚後_輪_金具1CP;

		public ColorP X0Y0_脚後_輪_金具2CP;

		public ColorP X0Y0_脚後_輪_金具3CP;

		public ColorP X0Y0_脚後_輪_金具左CP;

		public ColorP X0Y0_脚後_輪_金具右CP;

		public ColorP X0Y0_上顎頭部後_頭2CP;

		public ColorP X0Y0_上顎頭部後_頭1CP;

		public ColorP X0Y0_下顎頭部後_頭2CP;

		public ColorP X0Y0_下顎頭部後_頭1CP;

		public ColorP X0Y0_胴_節1_胴CP;

		public ColorP X0Y0_胴_節1_鱗1CP;

		public ColorP X0Y0_胴_節1_鱗3CP;

		public ColorP X0Y0_胴_節1_鱗2CP;

		public ColorP X0Y0_胴_節2_胴CP;

		public ColorP X0Y0_胴_節2_鱗1CP;

		public ColorP X0Y0_胴_節2_鱗3CP;

		public ColorP X0Y0_胴_節2_鱗2CP;

		public ColorP X0Y0_胴_節3_胴CP;

		public ColorP X0Y0_胴_節3_鱗1CP;

		public ColorP X0Y0_胴_節3_鱗3CP;

		public ColorP X0Y0_胴_節3_鱗2CP;

		public ColorP X0Y0_胴_節4_胴CP;

		public ColorP X0Y0_胴_節4_鱗1CP;

		public ColorP X0Y0_胴_節4_鱗3CP;

		public ColorP X0Y0_胴_節4_鱗2CP;

		public ColorP X0Y0_胴_節5_胴CP;

		public ColorP X0Y0_胴_節5_鱗1CP;

		public ColorP X0Y0_胴_節5_鱗3CP;

		public ColorP X0Y0_胴_節5_鱗2CP;

		public ColorP X0Y0_胴_節6_胴CP;

		public ColorP X0Y0_胴_節6_鱗1CP;

		public ColorP X0Y0_胴_節6_鱗3CP;

		public ColorP X0Y0_胴_節6_鱗2CP;

		public ColorP X0Y0_胴_節7_胴CP;

		public ColorP X0Y0_胴_節7_鱗1CP;

		public ColorP X0Y0_胴_節7_鱗3CP;

		public ColorP X0Y0_胴_節7_鱗2CP;

		public ColorP X0Y0_胴_節8_胴CP;

		public ColorP X0Y0_胴_節8_鱗1CP;

		public ColorP X0Y0_胴_節8_鱗3CP;

		public ColorP X0Y0_胴_節8_鱗2CP;

		public ColorP X0Y0_胴_節9_胴CP;

		public ColorP X0Y0_胴_節9_鱗1CP;

		public ColorP X0Y0_胴_節9_鱗3CP;

		public ColorP X0Y0_胴_節9_鱗2CP;

		public ColorP X0Y0_胴_節10_胴CP;

		public ColorP X0Y0_胴_節10_鱗1CP;

		public ColorP X0Y0_胴_節10_鱗3CP;

		public ColorP X0Y0_胴_節10_鱗2CP;

		public ColorP X0Y0_胴_節11_胴CP;

		public ColorP X0Y0_胴_節11_鱗1CP;

		public ColorP X0Y0_胴_節11_鱗3CP;

		public ColorP X0Y0_胴_節11_鱗2CP;

		public ColorP X0Y0_胴_節12_胴CP;

		public ColorP X0Y0_胴_節12_鱗1CP;

		public ColorP X0Y0_胴_節12_鱗3CP;

		public ColorP X0Y0_胴_節12_鱗2CP;

		public ColorP X0Y0_胴_節13_胴CP;

		public ColorP X0Y0_胴_節13_鱗1CP;

		public ColorP X0Y0_胴_節13_鱗3CP;

		public ColorP X0Y0_胴_節13_鱗2CP;

		public ColorP X0Y0_胴_節14_胴CP;

		public ColorP X0Y0_胴_節14_鱗1CP;

		public ColorP X0Y0_胴_節14_鱗3CP;

		public ColorP X0Y0_胴_節14_鱗2CP;

		public ColorP X0Y0_胴_節15_胴CP;

		public ColorP X0Y0_胴_節15_鱗1CP;

		public ColorP X0Y0_胴_節15_鱗3CP;

		public ColorP X0Y0_胴_節15_鱗2CP;

		public ColorP X0Y0_胴_節16_胴CP;

		public ColorP X0Y0_胴_節16_鱗1CP;

		public ColorP X0Y0_胴_節16_鱗3CP;

		public ColorP X0Y0_胴_節16_鱗2CP;

		public ColorP X0Y0_胴_輪_革CP;

		public ColorP X0Y0_胴_輪_金具1CP;

		public ColorP X0Y0_胴_輪_金具2CP;

		public ColorP X0Y0_胴_輪_金具3CP;

		public ColorP X0Y0_胴_輪_金具左CP;

		public ColorP X0Y0_胴_輪_金具右CP;

		public ColorP X0Y0_胴_節17_胴CP;

		public ColorP X0Y0_胴_節17_鱗1CP;

		public ColorP X0Y0_胴_節17_鱗3CP;

		public ColorP X0Y0_胴_節17_鱗2CP;

		public ColorP X0Y0_胴_節18_胴CP;

		public ColorP X0Y0_胴_節18_鱗1CP;

		public ColorP X0Y0_胴_節18_鱗3CP;

		public ColorP X0Y0_胴_節18_鱗2CP;

		public ColorP X0Y0_頭_口膜_口膜1CP;

		public ColorP X0Y0_頭_口膜_口膜2CP;

		public ColorP X0Y0_頭_口膜_口膜3CP;

		public ColorP X0Y0_頭_口膜_口膜4CP;

		public ColorP X0Y0_頭_口膜_口膜5CP;

		public ColorP X0Y0_頭_口膜_口膜6CP;

		public ColorP X0Y0_頭_口膜_口膜7CP;

		public ColorP X0Y0_頭_口膜_口膜8CP;

		public ColorP X0Y0_頭_上顎歯後_歯1CP;

		public ColorP X0Y0_頭_上顎歯後_歯2CP;

		public ColorP X0Y0_頭_上顎歯後_歯3CP;

		public ColorP X0Y0_頭_下顎_歯_後_歯1CP;

		public ColorP X0Y0_頭_下顎_歯_後_歯2CP;

		public ColorP X0Y0_頭_下顎_歯_後_歯3CP;

		public ColorP X0Y0_頭_下顎_歯_前_歯1CP;

		public ColorP X0Y0_頭_下顎_歯_前_歯2CP;

		public ColorP X0Y0_頭_下顎_歯_前_歯3CP;

		public ColorP X0Y0_頭_下顎_眼孔1CP;

		public ColorP X0Y0_頭_下顎_眼孔2CP;

		public ColorP X0Y0_頭_下顎_眼_眼1_眼2CP;

		public ColorP X0Y0_頭_下顎_眼_眼1_眼1CP;

		public ColorP X0Y0_頭_下顎_眼_眼2_眼2CP;

		public ColorP X0Y0_頭_下顎_眼_眼2_眼1CP;

		public ColorP X0Y0_頭_下顎_眼下_眼下CP;

		public ColorP X0Y0_頭_下顎_眼下_線CP;

		public ColorP X0Y0_頭_下顎_頭部_前_頭9CP;

		public ColorP X0Y0_頭_下顎_頭部_前_頭8CP;

		public ColorP X0Y0_頭_下顎_頭部_前_頭7CP;

		public ColorP X0Y0_頭_下顎_頭部_前_頭6CP;

		public ColorP X0Y0_頭_下顎_頭部_前_頭5CP;

		public ColorP X0Y0_頭_下顎_頭部_前_頭4CP;

		public ColorP X0Y0_頭_下顎_頭部_前_頭3CP;

		public ColorP X0Y0_頭_下顎_頭部_前_頭2CP;

		public ColorP X0Y0_頭_下顎_頭部_前_頭1CP;

		public ColorP X0Y0_頭_上顎_歯_前_歯1CP;

		public ColorP X0Y0_頭_上顎_歯_前_歯2CP;

		public ColorP X0Y0_頭_上顎_歯_前_歯3CP;

		public ColorP X0Y0_頭_上顎_眼孔1CP;

		public ColorP X0Y0_頭_上顎_眼孔2CP;

		public ColorP X0Y0_頭_上顎_眼_眼1_眼2CP;

		public ColorP X0Y0_頭_上顎_眼_眼1_眼1CP;

		public ColorP X0Y0_頭_上顎_眼_眼2_眼2CP;

		public ColorP X0Y0_頭_上顎_眼_眼2_眼1CP;

		public ColorP X0Y0_頭_上顎_眼下_眼下CP;

		public ColorP X0Y0_頭_上顎_眼下_線CP;

		public ColorP X0Y0_頭_上顎_頭部_前_頭9CP;

		public ColorP X0Y0_頭_上顎_頭部_前_頭8CP;

		public ColorP X0Y0_頭_上顎_頭部_前_頭7CP;

		public ColorP X0Y0_頭_上顎_頭部_前_頭6CP;

		public ColorP X0Y0_頭_上顎_頭部_前_頭5CP;

		public ColorP X0Y0_頭_上顎_頭部_前_頭4CP;

		public ColorP X0Y0_頭_上顎_頭部_前_頭3CP;

		public ColorP X0Y0_頭_上顎_頭部_前_頭2CP;

		public ColorP X0Y0_頭_上顎_頭部_前_頭1CP;

		public ColorP X0Y0_頭_輪_革CP;

		public ColorP X0Y0_頭_輪_金具1CP;

		public ColorP X0Y0_頭_輪_金具2CP;

		public ColorP X0Y0_頭_輪_金具3CP;

		public ColorP X0Y0_頭_輪_金具左CP;

		public ColorP X0Y0_頭_輪_金具右CP;

		public ColorP X0Y0_脚前_上腕CP;

		public ColorP X0Y0_脚前_下腕CP;

		public ColorP X0Y0_脚前_手_親指_爪CP;

		public ColorP X0Y0_脚前_手_手CP;

		public ColorP X0Y0_脚前_手_人指_指CP;

		public ColorP X0Y0_脚前_手_人指_爪CP;

		public ColorP X0Y0_脚前_手_人指_水掻CP;

		public ColorP X0Y0_脚前_手_人指_鱗_鱗4CP;

		public ColorP X0Y0_脚前_手_人指_鱗_鱗3CP;

		public ColorP X0Y0_脚前_手_人指_鱗_鱗2CP;

		public ColorP X0Y0_脚前_手_人指_鱗_鱗1CP;

		public ColorP X0Y0_脚前_手_中指_指CP;

		public ColorP X0Y0_脚前_手_中指_爪CP;

		public ColorP X0Y0_脚前_手_中指_水掻CP;

		public ColorP X0Y0_脚前_手_中指_鱗_鱗4CP;

		public ColorP X0Y0_脚前_手_中指_鱗_鱗3CP;

		public ColorP X0Y0_脚前_手_中指_鱗_鱗2CP;

		public ColorP X0Y0_脚前_手_中指_鱗_鱗1CP;

		public ColorP X0Y0_脚前_手_薬指_指CP;

		public ColorP X0Y0_脚前_手_薬指_爪CP;

		public ColorP X0Y0_脚前_手_薬指_水掻CP;

		public ColorP X0Y0_脚前_手_薬指_鱗_鱗4CP;

		public ColorP X0Y0_脚前_手_薬指_鱗_鱗3CP;

		public ColorP X0Y0_脚前_手_薬指_鱗_鱗2CP;

		public ColorP X0Y0_脚前_手_薬指_鱗_鱗1CP;

		public ColorP X0Y0_脚前_手_小指_指CP;

		public ColorP X0Y0_脚前_手_小指_爪CP;

		public ColorP X0Y0_脚前_手_小指_鱗_鱗4CP;

		public ColorP X0Y0_脚前_手_小指_鱗_鱗3CP;

		public ColorP X0Y0_脚前_手_小指_鱗_鱗2CP;

		public ColorP X0Y0_脚前_手_小指_鱗_鱗1CP;

		public ColorP X0Y0_脚前_手_鱗_鱗3CP;

		public ColorP X0Y0_脚前_手_鱗_鱗2CP;

		public ColorP X0Y0_脚前_手_鱗_鱗1CP;

		public ColorP X0Y0_脚前_下腕鱗_鱗小_鱗9CP;

		public ColorP X0Y0_脚前_下腕鱗_鱗小_鱗8CP;

		public ColorP X0Y0_脚前_下腕鱗_鱗小_鱗7CP;

		public ColorP X0Y0_脚前_下腕鱗_鱗小_鱗6CP;

		public ColorP X0Y0_脚前_下腕鱗_鱗小_鱗5CP;

		public ColorP X0Y0_脚前_下腕鱗_鱗小_鱗4CP;

		public ColorP X0Y0_脚前_下腕鱗_鱗小_鱗3CP;

		public ColorP X0Y0_脚前_下腕鱗_鱗小_鱗2CP;

		public ColorP X0Y0_脚前_下腕鱗_鱗小_鱗1CP;

		public ColorP X0Y0_脚前_下腕鱗_鱗大_鱗9CP;

		public ColorP X0Y0_脚前_下腕鱗_鱗大_鱗8CP;

		public ColorP X0Y0_脚前_下腕鱗_鱗大_鱗7CP;

		public ColorP X0Y0_脚前_下腕鱗_鱗大_鱗6CP;

		public ColorP X0Y0_脚前_下腕鱗_鱗大_鱗5CP;

		public ColorP X0Y0_脚前_下腕鱗_鱗大_鱗4CP;

		public ColorP X0Y0_脚前_下腕鱗_鱗大_鱗3CP;

		public ColorP X0Y0_脚前_下腕鱗_鱗大_鱗2CP;

		public ColorP X0Y0_脚前_下腕鱗_鱗大_鱗1CP;

		public ColorP X0Y0_脚前_上腕鱗_鱗5CP;

		public ColorP X0Y0_脚前_上腕鱗_鱗4CP;

		public ColorP X0Y0_脚前_上腕鱗_鱗3CP;

		public ColorP X0Y0_脚前_上腕鱗_鱗2CP;

		public ColorP X0Y0_脚前_上腕鱗_鱗1CP;

		public ColorP X0Y0_脚前_鰭_鰭膜1CP;

		public ColorP X0Y0_脚前_鰭_鰭条1CP;

		public ColorP X0Y0_脚前_鰭_鰭膜2CP;

		public ColorP X0Y0_脚前_鰭_鰭条2CP;

		public ColorP X0Y0_脚前_鰭_鰭膜3CP;

		public ColorP X0Y0_脚前_輪_革CP;

		public ColorP X0Y0_脚前_輪_金具1CP;

		public ColorP X0Y0_脚前_輪_金具2CP;

		public ColorP X0Y0_脚前_輪_金具3CP;

		public ColorP X0Y0_脚前_輪_金具左CP;

		public ColorP X0Y0_脚前_輪_金具右CP;

		public 拘束鎖 鎖1;

		public 拘束鎖 鎖3;

		public 拘束鎖 鎖5;

		public Ele[] 頭_接続;

		public Ele[] 上腕左_接続;

		public Ele[] 上腕右_接続;

		public Ele[] 下腕左_接続;

		public Ele[] 下腕右_接続;

		public Ele[] 手左_接続;

		public Ele[] 手右_接続;
	}
}
