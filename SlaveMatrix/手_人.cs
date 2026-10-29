using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 手_人 : 手
	{
		public 手_人(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 手_人D e)
		{
			this.ThisType = base.GetType();
			this.本体 = new Difs(Sta.腕左["手"]);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["グローブ"].ToPars();
			this.X0Y0_グロ\u30FCブ_グロ\u30FCブ = pars2["グローブ"].ToPar();
			this.X0Y0_グロ\u30FCブ_縁1 = pars2["縁1"].ToPar();
			this.X0Y0_グロ\u30FCブ_縁2 = pars2["縁2"].ToPar();
			this.X0Y0_獣性_獣毛 = pars["獣毛"].ToPar();
			this.X0Y0_手 = pars["手"].ToPar();
			this.X0Y0_獣性_肉球 = pars["獣肉球"].ToPar();
			pars2 = pars["人指"].ToPars();
			this.X0Y0_人指_人指1 = pars2["人指1"].ToPar();
			this.X0Y0_人指_人指3 = pars2["人指3"].ToPar();
			this.X0Y0_人指_人指2 = pars2["人指2"].ToPar();
			this.X0Y0_人指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["中指"].ToPars();
			this.X0Y0_中指_中指1 = pars2["中指1"].ToPar();
			this.X0Y0_中指_中指3 = pars2["中指3"].ToPar();
			this.X0Y0_中指_中指2 = pars2["中指2"].ToPar();
			this.X0Y0_中指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["薬指"].ToPars();
			this.X0Y0_薬指_薬指1 = pars2["薬指1"].ToPar();
			this.X0Y0_薬指_薬指3 = pars2["薬指3"].ToPar();
			this.X0Y0_薬指_薬指2 = pars2["薬指2"].ToPar();
			this.X0Y0_薬指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["小指"].ToPars();
			this.X0Y0_小指_小指1 = pars2["小指1"].ToPar();
			this.X0Y0_小指_小指3 = pars2["小指3"].ToPar();
			this.X0Y0_小指_小指2 = pars2["小指2"].ToPar();
			pars2 = pars["親指"].ToPars();
			this.X0Y0_親指_水掻 = pars2["水掻"].ToPar();
			this.X0Y0_親指_親指1 = pars2["親指1"].ToPar();
			this.X0Y0_親指_獣性_肉球 = pars2["獣肉球"].ToPar();
			this.X0Y0_親指_親指2 = pars2["親指2"].ToPar();
			this.X0Y0_親指_親指3 = pars2["親指3"].ToPar();
			pars = this.本体[0][1];
			pars2 = pars["親指"].ToPars();
			this.X0Y1_親指_親指3 = pars2["親指3"].ToPar();
			this.X0Y1_親指_親指2 = pars2["親指2"].ToPar();
			this.X0Y1_親指_親指1 = pars2["親指1"].ToPar();
			this.X0Y1_親指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["人指"].ToPars();
			this.X0Y1_人指_人指3 = pars2["人指3"].ToPar();
			this.X0Y1_人指_人指2 = pars2["人指2"].ToPar();
			this.X0Y1_人指_人指1 = pars2["人指1"].ToPar();
			this.X0Y1_人指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["中指"].ToPars();
			this.X0Y1_中指_中指3 = pars2["中指3"].ToPar();
			this.X0Y1_中指_中指2 = pars2["中指2"].ToPar();
			this.X0Y1_中指_中指1 = pars2["中指1"].ToPar();
			this.X0Y1_中指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["薬指"].ToPars();
			this.X0Y1_薬指_薬指3 = pars2["薬指3"].ToPar();
			this.X0Y1_薬指_薬指2 = pars2["薬指2"].ToPar();
			this.X0Y1_薬指_薬指1 = pars2["薬指1"].ToPar();
			this.X0Y1_薬指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["小指"].ToPars();
			this.X0Y1_小指_小指3 = pars2["小指3"].ToPar();
			this.X0Y1_小指_小指2 = pars2["小指2"].ToPar();
			this.X0Y1_小指_小指1 = pars2["小指1"].ToPar();
			this.X0Y1_手 = pars["手"].ToPar();
			this.X0Y1_獣性_獣毛 = pars["獣毛"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y1_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y1_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y1_竜性_鱗3 = pars2["鱗3"].ToPar();
			pars2 = pars["悪タトゥ"].ToPars();
			Pars pars3 = pars2["五芒星"].ToPars();
			this.X0Y1_悪タトゥ_五芒星_円1 = pars3["円1"].ToPar();
			this.X0Y1_悪タトゥ_五芒星_円2 = pars3["円2"].ToPar();
			this.X0Y1_悪タトゥ_五芒星_星 = pars3["星"].ToPar();
			this.X0Y1_悪タトゥ_五芒星_五角形 = pars3["五角形"].ToPar();
			pars2 = pars["グローブ"].ToPars();
			this.X0Y1_グロ\u30FCブ_グロ\u30FCブ = pars2["グローブ"].ToPar();
			this.X0Y1_グロ\u30FCブ_縁1 = pars2["縁1"].ToPar();
			this.X0Y1_グロ\u30FCブ_縁2 = pars2["縁2"].ToPar();
			pars = this.本体[0][2];
			pars2 = pars["親指"].ToPars();
			this.X0Y2_親指_親指3 = pars2["親指3"].ToPar();
			this.X0Y2_親指_親指2 = pars2["親指2"].ToPar();
			this.X0Y2_親指_親指1 = pars2["親指1"].ToPar();
			this.X0Y2_親指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["人指"].ToPars();
			this.X0Y2_人指_人指3 = pars2["人指3"].ToPar();
			this.X0Y2_人指_人指2 = pars2["人指2"].ToPar();
			this.X0Y2_人指_人指1 = pars2["人指1"].ToPar();
			this.X0Y2_人指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["中指"].ToPars();
			this.X0Y2_中指_中指3 = pars2["中指3"].ToPar();
			this.X0Y2_中指_中指2 = pars2["中指2"].ToPar();
			this.X0Y2_中指_中指1 = pars2["中指1"].ToPar();
			this.X0Y2_中指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["薬指"].ToPars();
			this.X0Y2_薬指_薬指3 = pars2["薬指3"].ToPar();
			this.X0Y2_薬指_薬指2 = pars2["薬指2"].ToPar();
			this.X0Y2_薬指_薬指1 = pars2["薬指1"].ToPar();
			this.X0Y2_薬指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["小指"].ToPars();
			this.X0Y2_小指_小指3 = pars2["小指3"].ToPar();
			this.X0Y2_小指_小指2 = pars2["小指2"].ToPar();
			this.X0Y2_小指_小指1 = pars2["小指1"].ToPar();
			this.X0Y2_手 = pars["手"].ToPar();
			this.X0Y2_獣性_獣毛 = pars["獣毛"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y2_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y2_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y2_竜性_鱗3 = pars2["鱗3"].ToPar();
			pars2 = pars["悪タトゥ"].ToPars();
			pars3 = pars2["五芒星"].ToPars();
			this.X0Y2_悪タトゥ_五芒星_円1 = pars3["円1"].ToPar();
			this.X0Y2_悪タトゥ_五芒星_円2 = pars3["円2"].ToPar();
			this.X0Y2_悪タトゥ_五芒星_星 = pars3["星"].ToPar();
			this.X0Y2_悪タトゥ_五芒星_五角形 = pars3["五角形"].ToPar();
			pars2 = pars["グローブ"].ToPars();
			this.X0Y2_グロ\u30FCブ_グロ\u30FCブ = pars2["グローブ"].ToPar();
			this.X0Y2_グロ\u30FCブ_縁1 = pars2["縁1"].ToPar();
			this.X0Y2_グロ\u30FCブ_縁2 = pars2["縁2"].ToPar();
			pars = this.本体[0][3];
			pars2 = pars["親指"].ToPars();
			this.X0Y3_親指_親指1 = pars2["親指1"].ToPar();
			this.X0Y3_親指_親指2 = pars2["親指2"].ToPar();
			this.X0Y3_親指_親指3 = pars2["親指3"].ToPar();
			this.X0Y3_親指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["人指"].ToPars();
			this.X0Y3_人指_人指3 = pars2["人指3"].ToPar();
			this.X0Y3_人指_人指2 = pars2["人指2"].ToPar();
			this.X0Y3_人指_人指1 = pars2["人指1"].ToPar();
			this.X0Y3_人指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["中指"].ToPars();
			this.X0Y3_中指_中指3 = pars2["中指3"].ToPar();
			this.X0Y3_中指_中指2 = pars2["中指2"].ToPar();
			this.X0Y3_中指_中指1 = pars2["中指1"].ToPar();
			this.X0Y3_中指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["薬指"].ToPars();
			this.X0Y3_薬指_薬指3 = pars2["薬指3"].ToPar();
			this.X0Y3_薬指_薬指2 = pars2["薬指2"].ToPar();
			this.X0Y3_薬指_薬指1 = pars2["薬指1"].ToPar();
			this.X0Y3_薬指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["小指"].ToPars();
			this.X0Y3_小指_小指3 = pars2["小指3"].ToPar();
			this.X0Y3_小指_小指2 = pars2["小指2"].ToPar();
			this.X0Y3_小指_小指1 = pars2["小指1"].ToPar();
			this.X0Y3_手 = pars["手"].ToPar();
			this.X0Y3_獣性_獣毛 = pars["獣毛"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y3_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y3_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y3_竜性_鱗3 = pars2["鱗3"].ToPar();
			pars2 = pars["悪タトゥ"].ToPars();
			pars3 = pars2["五芒星"].ToPars();
			this.X0Y3_悪タトゥ_五芒星_円1 = pars3["円1"].ToPar();
			this.X0Y3_悪タトゥ_五芒星_円2 = pars3["円2"].ToPar();
			this.X0Y3_悪タトゥ_五芒星_星 = pars3["星"].ToPar();
			this.X0Y3_悪タトゥ_五芒星_五角形 = pars3["五角形"].ToPar();
			pars2 = pars["グローブ"].ToPars();
			this.X0Y3_グロ\u30FCブ_グロ\u30FCブ = pars2["グローブ"].ToPar();
			this.X0Y3_グロ\u30FCブ_縁1 = pars2["縁1"].ToPar();
			this.X0Y3_グロ\u30FCブ_縁2 = pars2["縁2"].ToPar();
			pars = this.本体[0][4];
			pars2 = pars["親指"].ToPars();
			this.X0Y4_親指_親指3 = pars2["親指3"].ToPar();
			this.X0Y4_親指_親指2 = pars2["親指2"].ToPar();
			this.X0Y4_親指_親指1 = pars2["親指1"].ToPar();
			this.X0Y4_親指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["人指"].ToPars();
			this.X0Y4_人指_人指3 = pars2["人指3"].ToPar();
			this.X0Y4_人指_人指2 = pars2["人指2"].ToPar();
			this.X0Y4_人指_人指1 = pars2["人指1"].ToPar();
			this.X0Y4_人指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["小指"].ToPars();
			this.X0Y4_小指_小指3 = pars2["小指3"].ToPar();
			this.X0Y4_小指_小指2 = pars2["小指2"].ToPar();
			this.X0Y4_小指_小指1 = pars2["小指1"].ToPar();
			pars2 = pars["中指"].ToPars();
			this.X0Y4_中指_中指3 = pars2["中指3"].ToPar();
			this.X0Y4_中指_中指2 = pars2["中指2"].ToPar();
			this.X0Y4_中指_中指1 = pars2["中指1"].ToPar();
			this.X0Y4_中指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["薬指"].ToPars();
			this.X0Y4_薬指_薬指3 = pars2["薬指3"].ToPar();
			this.X0Y4_薬指_薬指2 = pars2["薬指2"].ToPar();
			this.X0Y4_薬指_薬指1 = pars2["薬指1"].ToPar();
			this.X0Y4_薬指_水掻 = pars2["水掻"].ToPar();
			this.X0Y4_手 = pars["手"].ToPar();
			this.X0Y4_獣性_獣毛 = pars["獣毛"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y4_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y4_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y4_竜性_鱗3 = pars2["鱗3"].ToPar();
			pars2 = pars["悪タトゥ"].ToPars();
			pars3 = pars2["五芒星"].ToPars();
			this.X0Y4_悪タトゥ_五芒星_円1 = pars3["円1"].ToPar();
			this.X0Y4_悪タトゥ_五芒星_円2 = pars3["円2"].ToPar();
			this.X0Y4_悪タトゥ_五芒星_星 = pars3["星"].ToPar();
			this.X0Y4_悪タトゥ_五芒星_五角形 = pars3["五角形"].ToPar();
			pars2 = pars["グローブ"].ToPars();
			this.X0Y4_グロ\u30FCブ_グロ\u30FCブ = pars2["グローブ"].ToPar();
			this.X0Y4_グロ\u30FCブ_縁1 = pars2["縁1"].ToPar();
			this.X0Y4_グロ\u30FCブ_縁2 = pars2["縁2"].ToPar();
			pars = this.本体[0][5];
			pars2 = pars["親指"].ToPars();
			this.X0Y5_親指_親指1 = pars2["親指1"].ToPar();
			this.X0Y5_親指_親指2 = pars2["親指2"].ToPar();
			this.X0Y5_親指_親指3 = pars2["親指3"].ToPar();
			this.X0Y5_親指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["人指"].ToPars();
			this.X0Y5_人指_人指3 = pars2["人指3"].ToPar();
			this.X0Y5_人指_人指2 = pars2["人指2"].ToPar();
			this.X0Y5_人指_人指1 = pars2["人指1"].ToPar();
			this.X0Y5_人指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["中指"].ToPars();
			this.X0Y5_中指_中指3 = pars2["中指3"].ToPar();
			this.X0Y5_中指_中指2 = pars2["中指2"].ToPar();
			this.X0Y5_中指_中指1 = pars2["中指1"].ToPar();
			this.X0Y5_中指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["薬指"].ToPars();
			this.X0Y5_薬指_薬指3 = pars2["薬指3"].ToPar();
			this.X0Y5_薬指_薬指2 = pars2["薬指2"].ToPar();
			this.X0Y5_薬指_薬指1 = pars2["薬指1"].ToPar();
			this.X0Y5_薬指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["小指"].ToPars();
			this.X0Y5_小指_小指3 = pars2["小指3"].ToPar();
			this.X0Y5_小指_小指2 = pars2["小指2"].ToPar();
			this.X0Y5_小指_小指1 = pars2["小指1"].ToPar();
			this.X0Y5_手 = pars["手"].ToPar();
			this.X0Y5_獣性_獣毛 = pars["獣毛"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y5_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y5_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y5_竜性_鱗3 = pars2["鱗3"].ToPar();
			pars2 = pars["悪タトゥ"].ToPars();
			pars3 = pars2["五芒星"].ToPars();
			this.X0Y5_悪タトゥ_五芒星_円1 = pars3["円1"].ToPar();
			this.X0Y5_悪タトゥ_五芒星_円2 = pars3["円2"].ToPar();
			this.X0Y5_悪タトゥ_五芒星_星 = pars3["星"].ToPar();
			this.X0Y5_悪タトゥ_五芒星_五角形 = pars3["五角形"].ToPar();
			pars2 = pars["グローブ"].ToPars();
			this.X0Y5_グロ\u30FCブ_グロ\u30FCブ = pars2["グローブ"].ToPar();
			this.X0Y5_グロ\u30FCブ_縁1 = pars2["縁1"].ToPar();
			this.X0Y5_グロ\u30FCブ_縁2 = pars2["縁2"].ToPar();
			pars = this.本体[0][6];
			pars2 = pars["小指"].ToPars();
			this.X0Y6_小指_小指3 = pars2["小指3"].ToPar();
			this.X0Y6_小指_小指2 = pars2["小指2"].ToPar();
			this.X0Y6_小指_小指1 = pars2["小指1"].ToPar();
			pars2 = pars["薬指"].ToPars();
			this.X0Y6_薬指_水掻 = pars2["水掻"].ToPar();
			this.X0Y6_薬指_薬指3 = pars2["薬指3"].ToPar();
			this.X0Y6_薬指_薬指2 = pars2["薬指2"].ToPar();
			this.X0Y6_薬指_薬指1 = pars2["薬指1"].ToPar();
			pars2 = pars["中指"].ToPars();
			this.X0Y6_中指_水掻 = pars2["水掻"].ToPar();
			this.X0Y6_中指_中指3 = pars2["中指3"].ToPar();
			this.X0Y6_中指_中指2 = pars2["中指2"].ToPar();
			this.X0Y6_中指_中指1 = pars2["中指1"].ToPar();
			pars2 = pars["人指"].ToPars();
			this.X0Y6_人指_水掻 = pars2["水掻"].ToPar();
			this.X0Y6_人指_人指3 = pars2["人指3"].ToPar();
			this.X0Y6_人指_人指2 = pars2["人指2"].ToPar();
			this.X0Y6_人指_人指1 = pars2["人指1"].ToPar();
			pars2 = pars["親指"].ToPars();
			this.X0Y6_親指_親指3 = pars2["親指3"].ToPar();
			this.X0Y6_親指_親指2 = pars2["親指2"].ToPar();
			this.X0Y6_親指_親指1 = pars2["親指1"].ToPar();
			this.X0Y6_親指_水掻 = pars2["水掻"].ToPar();
			this.X0Y6_手 = pars["手"].ToPar();
			this.X0Y6_獣性_獣毛 = pars["獣毛"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y6_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y6_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y6_竜性_鱗3 = pars2["鱗3"].ToPar();
			pars2 = pars["悪タトゥ"].ToPars();
			pars3 = pars2["五芒星"].ToPars();
			this.X0Y6_悪タトゥ_五芒星_円1 = pars3["円1"].ToPar();
			this.X0Y6_悪タトゥ_五芒星_円2 = pars3["円2"].ToPar();
			this.X0Y6_悪タトゥ_五芒星_星 = pars3["星"].ToPar();
			this.X0Y6_悪タトゥ_五芒星_五角形 = pars3["五角形"].ToPar();
			pars2 = pars["グローブ"].ToPars();
			this.X0Y6_グロ\u30FCブ_グロ\u30FCブ = pars2["グローブ"].ToPar();
			this.X0Y6_グロ\u30FCブ_縁1 = pars2["縁1"].ToPar();
			this.X0Y6_グロ\u30FCブ_縁2 = pars2["縁2"].ToPar();
			pars = this.本体[0][7];
			pars2 = pars["親指"].ToPars();
			this.X0Y7_親指_親指1 = pars2["親指1"].ToPar();
			this.X0Y7_親指_親指2 = pars2["親指2"].ToPar();
			this.X0Y7_親指_親指3 = pars2["親指3"].ToPar();
			this.X0Y7_親指_水掻 = pars2["水掻"].ToPar();
			this.X0Y7_手 = pars["手"].ToPar();
			pars2 = pars["人指"].ToPars();
			this.X0Y7_人指_人指3 = pars2["人指3"].ToPar();
			this.X0Y7_人指_人指2 = pars2["人指2"].ToPar();
			this.X0Y7_人指_人指1 = pars2["人指1"].ToPar();
			this.X0Y7_人指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["中指"].ToPars();
			this.X0Y7_中指_中指3 = pars2["中指3"].ToPar();
			this.X0Y7_中指_中指2 = pars2["中指2"].ToPar();
			this.X0Y7_中指_中指1 = pars2["中指1"].ToPar();
			this.X0Y7_中指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["小指"].ToPars();
			this.X0Y7_小指_小指3 = pars2["小指3"].ToPar();
			this.X0Y7_小指_小指2 = pars2["小指2"].ToPar();
			this.X0Y7_小指_小指1 = pars2["小指1"].ToPar();
			pars2 = pars["薬指"].ToPars();
			this.X0Y7_薬指_薬指3 = pars2["薬指3"].ToPar();
			this.X0Y7_薬指_薬指2 = pars2["薬指2"].ToPar();
			this.X0Y7_薬指_薬指1 = pars2["薬指1"].ToPar();
			this.X0Y7_薬指_水掻 = pars2["水掻"].ToPar();
			this.X0Y7_獣性_獣毛 = pars["獣毛"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y7_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y7_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y7_竜性_鱗3 = pars2["鱗3"].ToPar();
			pars2 = pars["悪タトゥ"].ToPars();
			pars3 = pars2["五芒星"].ToPars();
			this.X0Y7_悪タトゥ_五芒星_円1 = pars3["円1"].ToPar();
			this.X0Y7_悪タトゥ_五芒星_円2 = pars3["円2"].ToPar();
			this.X0Y7_悪タトゥ_五芒星_星 = pars3["星"].ToPar();
			this.X0Y7_悪タトゥ_五芒星_五角形 = pars3["五角形"].ToPar();
			pars2 = pars["グローブ"].ToPars();
			this.X0Y7_グロ\u30FCブ_グロ\u30FCブ = pars2["グローブ"].ToPar();
			this.X0Y7_グロ\u30FCブ_縁1 = pars2["縁1"].ToPar();
			this.X0Y7_グロ\u30FCブ_縁2 = pars2["縁2"].ToPar();
			pars = this.本体[0][8];
			pars2 = pars["親指"].ToPars();
			this.X0Y8_親指_親指3 = pars2["親指3"].ToPar();
			this.X0Y8_親指_親指2 = pars2["親指2"].ToPar();
			this.X0Y8_親指_親指1 = pars2["親指1"].ToPar();
			this.X0Y8_親指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["人指"].ToPars();
			this.X0Y8_人指_人指3 = pars2["人指3"].ToPar();
			this.X0Y8_人指_人指2 = pars2["人指2"].ToPar();
			this.X0Y8_人指_人指1 = pars2["人指1"].ToPar();
			this.X0Y8_人指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["中指"].ToPars();
			this.X0Y8_中指_中指3 = pars2["中指3"].ToPar();
			this.X0Y8_中指_中指2 = pars2["中指2"].ToPar();
			this.X0Y8_中指_中指1 = pars2["中指1"].ToPar();
			this.X0Y8_中指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["薬指"].ToPars();
			this.X0Y8_薬指_薬指3 = pars2["薬指3"].ToPar();
			this.X0Y8_薬指_薬指2 = pars2["薬指2"].ToPar();
			this.X0Y8_薬指_薬指1 = pars2["薬指1"].ToPar();
			this.X0Y8_薬指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["小指"].ToPars();
			this.X0Y8_小指_小指3 = pars2["小指3"].ToPar();
			this.X0Y8_小指_小指2 = pars2["小指2"].ToPar();
			this.X0Y8_小指_小指1 = pars2["小指1"].ToPar();
			this.X0Y8_手 = pars["手"].ToPar();
			this.X0Y8_獣性_獣毛 = pars["獣毛"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y8_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y8_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y8_竜性_鱗3 = pars2["鱗3"].ToPar();
			pars2 = pars["悪タトゥ"].ToPars();
			pars3 = pars2["五芒星"].ToPars();
			this.X0Y8_悪タトゥ_五芒星_円1 = pars3["円1"].ToPar();
			this.X0Y8_悪タトゥ_五芒星_円2 = pars3["円2"].ToPar();
			this.X0Y8_悪タトゥ_五芒星_星 = pars3["星"].ToPar();
			this.X0Y8_悪タトゥ_五芒星_五角形 = pars3["五角形"].ToPar();
			pars2 = pars["グローブ"].ToPars();
			this.X0Y8_グロ\u30FCブ_グロ\u30FCブ = pars2["グローブ"].ToPar();
			this.X0Y8_グロ\u30FCブ_縁1 = pars2["縁1"].ToPar();
			this.X0Y8_グロ\u30FCブ_縁2 = pars2["縁2"].ToPar();
			pars = this.本体[0][9];
			pars2 = pars["グローブ"].ToPars();
			this.X0Y9_グロ\u30FCブ_グロ\u30FCブ = pars2["グローブ"].ToPar();
			this.X0Y9_グロ\u30FCブ_縁1 = pars2["縁1"].ToPar();
			this.X0Y9_グロ\u30FCブ_縁2 = pars2["縁2"].ToPar();
			this.X0Y9_獣性_獣毛 = pars["獣毛"].ToPar();
			this.X0Y9_手 = pars["手"].ToPar();
			this.X0Y9_獣肉球 = pars["獣肉球"].ToPar();
			pars2 = pars["人指"].ToPars();
			this.X0Y9_人指_人指1 = pars2["人指1"].ToPar();
			this.X0Y9_人指_人指3 = pars2["人指3"].ToPar();
			this.X0Y9_人指_人指2 = pars2["人指2"].ToPar();
			this.X0Y9_人指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["中指"].ToPars();
			this.X0Y9_中指_中指1 = pars2["中指1"].ToPar();
			this.X0Y9_中指_中指3 = pars2["中指3"].ToPar();
			this.X0Y9_中指_中指2 = pars2["中指2"].ToPar();
			this.X0Y9_中指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["薬指"].ToPars();
			this.X0Y9_薬指_薬指1 = pars2["薬指1"].ToPar();
			this.X0Y9_薬指_薬指3 = pars2["薬指3"].ToPar();
			this.X0Y9_薬指_薬指2 = pars2["薬指2"].ToPar();
			this.X0Y9_薬指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["小指"].ToPars();
			this.X0Y9_小指_小指1 = pars2["小指1"].ToPar();
			this.X0Y9_小指_小指3 = pars2["小指3"].ToPar();
			this.X0Y9_小指_小指2 = pars2["小指2"].ToPar();
			pars2 = pars["親指"].ToPars();
			this.X0Y9_親指_水掻 = pars2["水掻"].ToPar();
			this.X0Y9_親指_親指1 = pars2["親指1"].ToPar();
			this.X0Y9_親指_獣肉球 = pars2["獣肉球"].ToPar();
			this.X0Y9_親指_親指2 = pars2["親指2"].ToPar();
			this.X0Y9_親指_親指3 = pars2["親指3"].ToPar();
			pars = this.本体[0][10];
			pars2 = pars["親指"].ToPars();
			this.X0Y10_親指_親指3 = pars2["親指3"].ToPar();
			this.X0Y10_親指_親指2 = pars2["親指2"].ToPar();
			this.X0Y10_親指_親指1 = pars2["親指1"].ToPar();
			this.X0Y10_親指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["人指"].ToPars();
			this.X0Y10_人指_人指3 = pars2["人指3"].ToPar();
			this.X0Y10_人指_人指2 = pars2["人指2"].ToPar();
			this.X0Y10_人指_人指1 = pars2["人指1"].ToPar();
			this.X0Y10_人指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["小指"].ToPars();
			this.X0Y10_小指_小指3 = pars2["小指3"].ToPar();
			this.X0Y10_小指_小指2 = pars2["小指2"].ToPar();
			this.X0Y10_小指_小指1 = pars2["小指1"].ToPar();
			pars2 = pars["中指"].ToPars();
			this.X0Y10_中指_中指3 = pars2["中指3"].ToPar();
			this.X0Y10_中指_中指2 = pars2["中指2"].ToPar();
			this.X0Y10_中指_中指1 = pars2["中指1"].ToPar();
			this.X0Y10_中指_水掻 = pars2["水掻"].ToPar();
			pars2 = pars["薬指"].ToPars();
			this.X0Y10_薬指_薬指3 = pars2["薬指3"].ToPar();
			this.X0Y10_薬指_薬指2 = pars2["薬指2"].ToPar();
			this.X0Y10_薬指_薬指1 = pars2["薬指1"].ToPar();
			this.X0Y10_薬指_水掻 = pars2["水掻"].ToPar();
			this.X0Y10_手 = pars["手"].ToPar();
			this.X0Y10_獣性_獣毛 = pars["獣毛"].ToPar();
			pars2 = pars["鱗"].ToPars();
			this.X0Y10_竜性_鱗1 = pars2["鱗1"].ToPar();
			this.X0Y10_竜性_鱗2 = pars2["鱗2"].ToPar();
			this.X0Y10_竜性_鱗3 = pars2["鱗3"].ToPar();
			pars2 = pars["悪タトゥ"].ToPars();
			pars3 = pars2["五芒星"].ToPars();
			this.X0Y10_悪タトゥ_五芒星_円1 = pars3["円1"].ToPar();
			this.X0Y10_悪タトゥ_五芒星_円2 = pars3["円2"].ToPar();
			this.X0Y10_悪タトゥ_五芒星_星 = pars3["星"].ToPar();
			this.X0Y10_悪タトゥ_五芒星_五角形 = pars3["五角形"].ToPar();
			pars2 = pars["グローブ"].ToPars();
			this.X0Y10_グロ\u30FCブ_グロ\u30FCブ = pars2["グローブ"].ToPar();
			this.X0Y10_グロ\u30FCブ_縁1 = pars2["縁1"].ToPar();
			this.X0Y10_グロ\u30FCブ_縁2 = pars2["縁2"].ToPar();
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
			this.グロ\u30FCブ_グロ\u30FCブ_表示 = e.グロ\u30FCブ_グロ\u30FCブ_表示;
			this.グロ\u30FCブ_縁1_表示 = e.グロ\u30FCブ_縁1_表示;
			this.グロ\u30FCブ_縁2_表示 = e.グロ\u30FCブ_縁2_表示;
			this.獣性_獣毛_表示 = e.獣性_獣毛_表示;
			this.手_表示 = e.手_表示;
			this.獣性_肉球_表示 = e.獣性_肉球_表示;
			this.人指_人指1_表示 = e.人指_人指1_表示;
			this.人指_人指3_表示 = e.人指_人指3_表示;
			this.人指_人指2_表示 = e.人指_人指2_表示;
			this.人指_水掻_表示 = e.人指_水掻_表示;
			this.中指_中指1_表示 = e.中指_中指1_表示;
			this.中指_中指3_表示 = e.中指_中指3_表示;
			this.中指_中指2_表示 = e.中指_中指2_表示;
			this.中指_水掻_表示 = e.中指_水掻_表示;
			this.薬指_薬指1_表示 = e.薬指_薬指1_表示;
			this.薬指_薬指3_表示 = e.薬指_薬指3_表示;
			this.薬指_薬指2_表示 = e.薬指_薬指2_表示;
			this.薬指_水掻_表示 = e.薬指_水掻_表示;
			this.小指_小指1_表示 = e.小指_小指1_表示;
			this.小指_小指3_表示 = e.小指_小指3_表示;
			this.小指_小指2_表示 = e.小指_小指2_表示;
			this.親指_水掻_表示 = e.親指_水掻_表示;
			this.親指_親指1_表示 = e.親指_親指1_表示;
			this.親指_獣性_肉球_表示 = e.親指_獣性_肉球_表示;
			this.親指_親指2_表示 = e.親指_親指2_表示;
			this.親指_親指3_表示 = e.親指_親指3_表示;
			this.竜性_鱗1_表示 = e.竜性_鱗1_表示;
			this.竜性_鱗2_表示 = e.竜性_鱗2_表示;
			this.竜性_鱗3_表示 = e.竜性_鱗3_表示;
			this.悪タトゥ_五芒星_円1_表示 = e.悪タトゥ_五芒星_円1_表示;
			this.悪タトゥ_五芒星_円2_表示 = e.悪タトゥ_五芒星_円2_表示;
			this.悪タトゥ_五芒星_星_表示 = e.悪タトゥ_五芒星_星_表示;
			this.悪タトゥ_五芒星_五角形_表示 = e.悪タトゥ_五芒星_五角形_表示;
			this.鋭爪 = e.鋭爪;
			if (e.虫性)
			{
				this.虫性();
			}
			if (e.虫手)
			{
				this.虫手();
			}
			if (e.宇手)
			{
				this.宇手();
			}
			if (e.獣性)
			{
				this.獣性();
			}
			if (e.竜性)
			{
				this.竜性();
			}
			this.グロ\u30FCブ表示 = e.グロ\u30FCブ表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_グロ\u30FCブ_グロ\u30FCブCP = new ColorP(this.X0Y0_グロ\u30FCブ_グロ\u30FCブ, this.グロ\u30FCブ_グロ\u30FCブCD, DisUnit, true);
			this.X0Y0_グロ\u30FCブ_縁1CP = new ColorP(this.X0Y0_グロ\u30FCブ_縁1, this.グロ\u30FCブ_縁1CD, DisUnit, true);
			this.X0Y0_グロ\u30FCブ_縁2CP = new ColorP(this.X0Y0_グロ\u30FCブ_縁2, this.グロ\u30FCブ_縁2CD, DisUnit, true);
			this.X0Y0_獣性_獣毛CP = new ColorP(this.X0Y0_獣性_獣毛, this.獣性_獣毛CD, DisUnit, true);
			this.X0Y0_手CP = new ColorP(this.X0Y0_手, this.手CD, DisUnit, true);
			this.X0Y0_獣性_肉球CP = new ColorP(this.X0Y0_獣性_肉球, this.獣性_肉球CD, DisUnit, true);
			this.X0Y0_人指_人指1CP = new ColorP(this.X0Y0_人指_人指1, this.人指_人指1CD, DisUnit, true);
			this.X0Y0_人指_人指3CP = new ColorP(this.X0Y0_人指_人指3, this.人指_人指3CD, DisUnit, true);
			this.X0Y0_人指_人指2CP = new ColorP(this.X0Y0_人指_人指2, this.人指_人指2CD, DisUnit, true);
			this.X0Y0_人指_水掻CP = new ColorP(this.X0Y0_人指_水掻, this.人指_水掻CD, DisUnit, true);
			this.X0Y0_中指_中指1CP = new ColorP(this.X0Y0_中指_中指1, this.中指_中指1CD, DisUnit, true);
			this.X0Y0_中指_中指3CP = new ColorP(this.X0Y0_中指_中指3, this.中指_中指3CD, DisUnit, true);
			this.X0Y0_中指_中指2CP = new ColorP(this.X0Y0_中指_中指2, this.中指_中指2CD, DisUnit, true);
			this.X0Y0_中指_水掻CP = new ColorP(this.X0Y0_中指_水掻, this.中指_水掻CD, DisUnit, true);
			this.X0Y0_薬指_薬指1CP = new ColorP(this.X0Y0_薬指_薬指1, this.薬指_薬指1CD, DisUnit, true);
			this.X0Y0_薬指_薬指3CP = new ColorP(this.X0Y0_薬指_薬指3, this.薬指_薬指3CD, DisUnit, true);
			this.X0Y0_薬指_薬指2CP = new ColorP(this.X0Y0_薬指_薬指2, this.薬指_薬指2CD, DisUnit, true);
			this.X0Y0_薬指_水掻CP = new ColorP(this.X0Y0_薬指_水掻, this.薬指_水掻CD, DisUnit, true);
			this.X0Y0_小指_小指1CP = new ColorP(this.X0Y0_小指_小指1, this.小指_小指1CD, DisUnit, true);
			this.X0Y0_小指_小指3CP = new ColorP(this.X0Y0_小指_小指3, this.小指_小指3CD, DisUnit, true);
			this.X0Y0_小指_小指2CP = new ColorP(this.X0Y0_小指_小指2, this.小指_小指2CD, DisUnit, true);
			this.X0Y0_親指_水掻CP = new ColorP(this.X0Y0_親指_水掻, this.親指_水掻CD, DisUnit, true);
			this.X0Y0_親指_親指1CP = new ColorP(this.X0Y0_親指_親指1, this.親指_親指1CD, DisUnit, true);
			this.X0Y0_親指_獣性_肉球CP = new ColorP(this.X0Y0_親指_獣性_肉球, this.獣性_肉球CD, DisUnit, true);
			this.X0Y0_親指_親指2CP = new ColorP(this.X0Y0_親指_親指2, this.親指_親指2CD, DisUnit, true);
			this.X0Y0_親指_親指3CP = new ColorP(this.X0Y0_親指_親指3, this.親指_親指3CD, DisUnit, true);
			this.X0Y1_親指_親指3CP = new ColorP(this.X0Y1_親指_親指3, this.親指_親指3CD, DisUnit, true);
			this.X0Y1_親指_親指2CP = new ColorP(this.X0Y1_親指_親指2, this.親指_親指2CD, DisUnit, true);
			this.X0Y1_親指_親指1CP = new ColorP(this.X0Y1_親指_親指1, this.親指_親指1CD, DisUnit, true);
			this.X0Y1_親指_水掻CP = new ColorP(this.X0Y1_親指_水掻, this.親指_水掻CD, DisUnit, true);
			this.X0Y1_人指_人指3CP = new ColorP(this.X0Y1_人指_人指3, this.人指_人指3CD, DisUnit, true);
			this.X0Y1_人指_人指2CP = new ColorP(this.X0Y1_人指_人指2, this.人指_人指2CD, DisUnit, true);
			this.X0Y1_人指_人指1CP = new ColorP(this.X0Y1_人指_人指1, this.人指_人指1CD, DisUnit, true);
			this.X0Y1_人指_水掻CP = new ColorP(this.X0Y1_人指_水掻, this.人指_水掻CD, DisUnit, true);
			this.X0Y1_中指_中指3CP = new ColorP(this.X0Y1_中指_中指3, this.中指_中指3CD, DisUnit, true);
			this.X0Y1_中指_中指2CP = new ColorP(this.X0Y1_中指_中指2, this.中指_中指2CD, DisUnit, true);
			this.X0Y1_中指_中指1CP = new ColorP(this.X0Y1_中指_中指1, this.中指_中指1CD, DisUnit, true);
			this.X0Y1_中指_水掻CP = new ColorP(this.X0Y1_中指_水掻, this.中指_水掻CD, DisUnit, true);
			this.X0Y1_薬指_薬指3CP = new ColorP(this.X0Y1_薬指_薬指3, this.薬指_薬指3CD, DisUnit, true);
			this.X0Y1_薬指_薬指2CP = new ColorP(this.X0Y1_薬指_薬指2, this.薬指_薬指2CD, DisUnit, true);
			this.X0Y1_薬指_薬指1CP = new ColorP(this.X0Y1_薬指_薬指1, this.薬指_薬指1CD, DisUnit, true);
			this.X0Y1_薬指_水掻CP = new ColorP(this.X0Y1_薬指_水掻, this.薬指_水掻CD, DisUnit, true);
			this.X0Y1_小指_小指3CP = new ColorP(this.X0Y1_小指_小指3, this.小指_小指3CD, DisUnit, true);
			this.X0Y1_小指_小指2CP = new ColorP(this.X0Y1_小指_小指2, this.小指_小指2CD, DisUnit, true);
			this.X0Y1_小指_小指1CP = new ColorP(this.X0Y1_小指_小指1, this.小指_小指1CD, DisUnit, true);
			this.X0Y1_手CP = new ColorP(this.X0Y1_手, this.手CD, DisUnit, true);
			this.X0Y1_獣性_獣毛CP = new ColorP(this.X0Y1_獣性_獣毛, this.獣性_獣毛CD, DisUnit, true);
			this.X0Y1_竜性_鱗1CP = new ColorP(this.X0Y1_竜性_鱗1, this.竜性_鱗1CD, DisUnit, true);
			this.X0Y1_竜性_鱗2CP = new ColorP(this.X0Y1_竜性_鱗2, this.竜性_鱗2CD, DisUnit, true);
			this.X0Y1_竜性_鱗3CP = new ColorP(this.X0Y1_竜性_鱗3, this.竜性_鱗3CD, DisUnit, true);
			this.X0Y1_悪タトゥ_五芒星_円1CP = new ColorP(this.X0Y1_悪タトゥ_五芒星_円1, this.悪タトゥ_五芒星_円1CD, DisUnit, false);
			this.X0Y1_悪タトゥ_五芒星_円2CP = new ColorP(this.X0Y1_悪タトゥ_五芒星_円2, this.悪タトゥ_五芒星_円2CD, DisUnit, false);
			this.X0Y1_悪タトゥ_五芒星_星CP = new ColorP(this.X0Y1_悪タトゥ_五芒星_星, this.悪タトゥ_五芒星_星CD, DisUnit, false);
			this.X0Y1_悪タトゥ_五芒星_五角形CP = new ColorP(this.X0Y1_悪タトゥ_五芒星_五角形, this.悪タトゥ_五芒星_五角形CD, DisUnit, false);
			this.X0Y1_グロ\u30FCブ_グロ\u30FCブCP = new ColorP(this.X0Y1_グロ\u30FCブ_グロ\u30FCブ, this.グロ\u30FCブ_グロ\u30FCブCD, DisUnit, true);
			this.X0Y1_グロ\u30FCブ_縁1CP = new ColorP(this.X0Y1_グロ\u30FCブ_縁1, this.グロ\u30FCブ_縁1CD, DisUnit, true);
			this.X0Y1_グロ\u30FCブ_縁2CP = new ColorP(this.X0Y1_グロ\u30FCブ_縁2, this.グロ\u30FCブ_縁2CD, DisUnit, true);
			this.X0Y2_親指_親指3CP = new ColorP(this.X0Y2_親指_親指3, this.親指_親指3CD, DisUnit, true);
			this.X0Y2_親指_親指2CP = new ColorP(this.X0Y2_親指_親指2, this.親指_親指2CD, DisUnit, true);
			this.X0Y2_親指_親指1CP = new ColorP(this.X0Y2_親指_親指1, this.親指_親指1CD, DisUnit, true);
			this.X0Y2_親指_水掻CP = new ColorP(this.X0Y2_親指_水掻, this.親指_水掻CD, DisUnit, true);
			this.X0Y2_人指_人指3CP = new ColorP(this.X0Y2_人指_人指3, this.人指_人指3CD, DisUnit, true);
			this.X0Y2_人指_人指2CP = new ColorP(this.X0Y2_人指_人指2, this.人指_人指2CD, DisUnit, true);
			this.X0Y2_人指_人指1CP = new ColorP(this.X0Y2_人指_人指1, this.人指_人指1CD, DisUnit, true);
			this.X0Y2_人指_水掻CP = new ColorP(this.X0Y2_人指_水掻, this.人指_水掻CD, DisUnit, true);
			this.X0Y2_中指_中指3CP = new ColorP(this.X0Y2_中指_中指3, this.中指_中指3CD, DisUnit, true);
			this.X0Y2_中指_中指2CP = new ColorP(this.X0Y2_中指_中指2, this.中指_中指2CD, DisUnit, true);
			this.X0Y2_中指_中指1CP = new ColorP(this.X0Y2_中指_中指1, this.中指_中指1CD, DisUnit, true);
			this.X0Y2_中指_水掻CP = new ColorP(this.X0Y2_中指_水掻, this.中指_水掻CD, DisUnit, true);
			this.X0Y2_薬指_薬指3CP = new ColorP(this.X0Y2_薬指_薬指3, this.薬指_薬指3CD, DisUnit, true);
			this.X0Y2_薬指_薬指2CP = new ColorP(this.X0Y2_薬指_薬指2, this.薬指_薬指2CD, DisUnit, true);
			this.X0Y2_薬指_薬指1CP = new ColorP(this.X0Y2_薬指_薬指1, this.薬指_薬指1CD, DisUnit, true);
			this.X0Y2_薬指_水掻CP = new ColorP(this.X0Y2_薬指_水掻, this.薬指_水掻CD, DisUnit, true);
			this.X0Y2_小指_小指3CP = new ColorP(this.X0Y2_小指_小指3, this.小指_小指3CD, DisUnit, true);
			this.X0Y2_小指_小指2CP = new ColorP(this.X0Y2_小指_小指2, this.小指_小指2CD, DisUnit, true);
			this.X0Y2_小指_小指1CP = new ColorP(this.X0Y2_小指_小指1, this.小指_小指1CD, DisUnit, true);
			this.X0Y2_手CP = new ColorP(this.X0Y2_手, this.手CD, DisUnit, true);
			this.X0Y2_獣性_獣毛CP = new ColorP(this.X0Y2_獣性_獣毛, this.獣性_獣毛CD, DisUnit, true);
			this.X0Y2_竜性_鱗1CP = new ColorP(this.X0Y2_竜性_鱗1, this.竜性_鱗1CD, DisUnit, true);
			this.X0Y2_竜性_鱗2CP = new ColorP(this.X0Y2_竜性_鱗2, this.竜性_鱗2CD, DisUnit, true);
			this.X0Y2_竜性_鱗3CP = new ColorP(this.X0Y2_竜性_鱗3, this.竜性_鱗3CD, DisUnit, true);
			this.X0Y2_悪タトゥ_五芒星_円1CP = new ColorP(this.X0Y2_悪タトゥ_五芒星_円1, this.悪タトゥ_五芒星_円1CD, DisUnit, false);
			this.X0Y2_悪タトゥ_五芒星_円2CP = new ColorP(this.X0Y2_悪タトゥ_五芒星_円2, this.悪タトゥ_五芒星_円2CD, DisUnit, false);
			this.X0Y2_悪タトゥ_五芒星_星CP = new ColorP(this.X0Y2_悪タトゥ_五芒星_星, this.悪タトゥ_五芒星_星CD, DisUnit, false);
			this.X0Y2_悪タトゥ_五芒星_五角形CP = new ColorP(this.X0Y2_悪タトゥ_五芒星_五角形, this.悪タトゥ_五芒星_五角形CD, DisUnit, false);
			this.X0Y2_グロ\u30FCブ_グロ\u30FCブCP = new ColorP(this.X0Y2_グロ\u30FCブ_グロ\u30FCブ, this.グロ\u30FCブ_グロ\u30FCブCD, DisUnit, true);
			this.X0Y2_グロ\u30FCブ_縁1CP = new ColorP(this.X0Y2_グロ\u30FCブ_縁1, this.グロ\u30FCブ_縁1CD, DisUnit, true);
			this.X0Y2_グロ\u30FCブ_縁2CP = new ColorP(this.X0Y2_グロ\u30FCブ_縁2, this.グロ\u30FCブ_縁2CD, DisUnit, true);
			this.X0Y3_親指_親指1CP = new ColorP(this.X0Y3_親指_親指1, this.親指_親指1CD, DisUnit, true);
			this.X0Y3_親指_親指2CP = new ColorP(this.X0Y3_親指_親指2, this.親指_親指2CD, DisUnit, true);
			this.X0Y3_親指_親指3CP = new ColorP(this.X0Y3_親指_親指3, this.親指_親指3CD, DisUnit, true);
			this.X0Y3_親指_水掻CP = new ColorP(this.X0Y3_親指_水掻, this.親指_水掻CD, DisUnit, true);
			this.X0Y3_人指_人指3CP = new ColorP(this.X0Y3_人指_人指3, this.人指_人指3CD, DisUnit, true);
			this.X0Y3_人指_人指2CP = new ColorP(this.X0Y3_人指_人指2, this.人指_人指2CD, DisUnit, true);
			this.X0Y3_人指_人指1CP = new ColorP(this.X0Y3_人指_人指1, this.人指_人指1CD, DisUnit, true);
			this.X0Y3_人指_水掻CP = new ColorP(this.X0Y3_人指_水掻, this.人指_水掻CD, DisUnit, true);
			this.X0Y3_中指_中指3CP = new ColorP(this.X0Y3_中指_中指3, this.中指_中指3CD, DisUnit, true);
			this.X0Y3_中指_中指2CP = new ColorP(this.X0Y3_中指_中指2, this.中指_中指2CD, DisUnit, true);
			this.X0Y3_中指_中指1CP = new ColorP(this.X0Y3_中指_中指1, this.中指_中指1CD, DisUnit, true);
			this.X0Y3_中指_水掻CP = new ColorP(this.X0Y3_中指_水掻, this.中指_水掻CD, DisUnit, true);
			this.X0Y3_薬指_薬指3CP = new ColorP(this.X0Y3_薬指_薬指3, this.薬指_薬指3CD, DisUnit, true);
			this.X0Y3_薬指_薬指2CP = new ColorP(this.X0Y3_薬指_薬指2, this.薬指_薬指2CD, DisUnit, true);
			this.X0Y3_薬指_薬指1CP = new ColorP(this.X0Y3_薬指_薬指1, this.薬指_薬指1CD, DisUnit, true);
			this.X0Y3_薬指_水掻CP = new ColorP(this.X0Y3_薬指_水掻, this.薬指_水掻CD, DisUnit, true);
			this.X0Y3_小指_小指3CP = new ColorP(this.X0Y3_小指_小指3, this.小指_小指3CD, DisUnit, true);
			this.X0Y3_小指_小指2CP = new ColorP(this.X0Y3_小指_小指2, this.小指_小指2CD, DisUnit, true);
			this.X0Y3_小指_小指1CP = new ColorP(this.X0Y3_小指_小指1, this.小指_小指1CD, DisUnit, true);
			this.X0Y3_手CP = new ColorP(this.X0Y3_手, this.手CD, DisUnit, true);
			this.X0Y3_獣性_獣毛CP = new ColorP(this.X0Y3_獣性_獣毛, this.獣性_獣毛CD, DisUnit, true);
			this.X0Y3_竜性_鱗1CP = new ColorP(this.X0Y3_竜性_鱗1, this.竜性_鱗1CD, DisUnit, true);
			this.X0Y3_竜性_鱗2CP = new ColorP(this.X0Y3_竜性_鱗2, this.竜性_鱗2CD, DisUnit, true);
			this.X0Y3_竜性_鱗3CP = new ColorP(this.X0Y3_竜性_鱗3, this.竜性_鱗3CD, DisUnit, true);
			this.X0Y3_悪タトゥ_五芒星_円1CP = new ColorP(this.X0Y3_悪タトゥ_五芒星_円1, this.悪タトゥ_五芒星_円1CD, DisUnit, false);
			this.X0Y3_悪タトゥ_五芒星_円2CP = new ColorP(this.X0Y3_悪タトゥ_五芒星_円2, this.悪タトゥ_五芒星_円2CD, DisUnit, false);
			this.X0Y3_悪タトゥ_五芒星_星CP = new ColorP(this.X0Y3_悪タトゥ_五芒星_星, this.悪タトゥ_五芒星_星CD, DisUnit, false);
			this.X0Y3_悪タトゥ_五芒星_五角形CP = new ColorP(this.X0Y3_悪タトゥ_五芒星_五角形, this.悪タトゥ_五芒星_五角形CD, DisUnit, false);
			this.X0Y3_グロ\u30FCブ_グロ\u30FCブCP = new ColorP(this.X0Y3_グロ\u30FCブ_グロ\u30FCブ, this.グロ\u30FCブ_グロ\u30FCブCD, DisUnit, true);
			this.X0Y3_グロ\u30FCブ_縁1CP = new ColorP(this.X0Y3_グロ\u30FCブ_縁1, this.グロ\u30FCブ_縁1CD, DisUnit, true);
			this.X0Y3_グロ\u30FCブ_縁2CP = new ColorP(this.X0Y3_グロ\u30FCブ_縁2, this.グロ\u30FCブ_縁2CD, DisUnit, true);
			this.X0Y4_親指_親指3CP = new ColorP(this.X0Y4_親指_親指3, this.親指_親指3CD, DisUnit, true);
			this.X0Y4_親指_親指2CP = new ColorP(this.X0Y4_親指_親指2, this.親指_親指2CD, DisUnit, true);
			this.X0Y4_親指_親指1CP = new ColorP(this.X0Y4_親指_親指1, this.親指_親指1CD, DisUnit, true);
			this.X0Y4_親指_水掻CP = new ColorP(this.X0Y4_親指_水掻, this.親指_水掻CD, DisUnit, true);
			this.X0Y4_人指_人指3CP = new ColorP(this.X0Y4_人指_人指3, this.人指_人指3CD, DisUnit, true);
			this.X0Y4_人指_人指2CP = new ColorP(this.X0Y4_人指_人指2, this.人指_人指2CD, DisUnit, true);
			this.X0Y4_人指_人指1CP = new ColorP(this.X0Y4_人指_人指1, this.人指_人指1CD, DisUnit, true);
			this.X0Y4_人指_水掻CP = new ColorP(this.X0Y4_人指_水掻, this.人指_水掻CD, DisUnit, true);
			this.X0Y4_小指_小指3CP = new ColorP(this.X0Y4_小指_小指3, this.小指_小指3CD, DisUnit, true);
			this.X0Y4_小指_小指2CP = new ColorP(this.X0Y4_小指_小指2, this.小指_小指2CD, DisUnit, true);
			this.X0Y4_小指_小指1CP = new ColorP(this.X0Y4_小指_小指1, this.小指_小指1CD, DisUnit, true);
			this.X0Y4_中指_中指3CP = new ColorP(this.X0Y4_中指_中指3, this.中指_中指3CD, DisUnit, true);
			this.X0Y4_中指_中指2CP = new ColorP(this.X0Y4_中指_中指2, this.中指_中指2CD, DisUnit, true);
			this.X0Y4_中指_中指1CP = new ColorP(this.X0Y4_中指_中指1, this.中指_中指1CD, DisUnit, true);
			this.X0Y4_中指_水掻CP = new ColorP(this.X0Y4_中指_水掻, this.中指_水掻CD, DisUnit, true);
			this.X0Y4_薬指_薬指3CP = new ColorP(this.X0Y4_薬指_薬指3, this.薬指_薬指3CD, DisUnit, true);
			this.X0Y4_薬指_薬指2CP = new ColorP(this.X0Y4_薬指_薬指2, this.薬指_薬指2CD, DisUnit, true);
			this.X0Y4_薬指_薬指1CP = new ColorP(this.X0Y4_薬指_薬指1, this.薬指_薬指1CD, DisUnit, true);
			this.X0Y4_薬指_水掻CP = new ColorP(this.X0Y4_薬指_水掻, this.薬指_水掻CD, DisUnit, true);
			this.X0Y4_手CP = new ColorP(this.X0Y4_手, this.手CD, DisUnit, true);
			this.X0Y4_獣性_獣毛CP = new ColorP(this.X0Y4_獣性_獣毛, this.獣性_獣毛CD, DisUnit, true);
			this.X0Y4_竜性_鱗1CP = new ColorP(this.X0Y4_竜性_鱗1, this.竜性_鱗1CD, DisUnit, true);
			this.X0Y4_竜性_鱗2CP = new ColorP(this.X0Y4_竜性_鱗2, this.竜性_鱗2CD, DisUnit, true);
			this.X0Y4_竜性_鱗3CP = new ColorP(this.X0Y4_竜性_鱗3, this.竜性_鱗3CD, DisUnit, true);
			this.X0Y4_悪タトゥ_五芒星_円1CP = new ColorP(this.X0Y4_悪タトゥ_五芒星_円1, this.悪タトゥ_五芒星_円1CD, DisUnit, false);
			this.X0Y4_悪タトゥ_五芒星_円2CP = new ColorP(this.X0Y4_悪タトゥ_五芒星_円2, this.悪タトゥ_五芒星_円2CD, DisUnit, false);
			this.X0Y4_悪タトゥ_五芒星_星CP = new ColorP(this.X0Y4_悪タトゥ_五芒星_星, this.悪タトゥ_五芒星_星CD, DisUnit, false);
			this.X0Y4_悪タトゥ_五芒星_五角形CP = new ColorP(this.X0Y4_悪タトゥ_五芒星_五角形, this.悪タトゥ_五芒星_五角形CD, DisUnit, false);
			this.X0Y4_グロ\u30FCブ_グロ\u30FCブCP = new ColorP(this.X0Y4_グロ\u30FCブ_グロ\u30FCブ, this.グロ\u30FCブ_グロ\u30FCブCD, DisUnit, true);
			this.X0Y4_グロ\u30FCブ_縁1CP = new ColorP(this.X0Y4_グロ\u30FCブ_縁1, this.グロ\u30FCブ_縁1CD, DisUnit, true);
			this.X0Y4_グロ\u30FCブ_縁2CP = new ColorP(this.X0Y4_グロ\u30FCブ_縁2, this.グロ\u30FCブ_縁2CD, DisUnit, true);
			this.X0Y5_親指_親指1CP = new ColorP(this.X0Y5_親指_親指1, this.親指_親指1CD, DisUnit, true);
			this.X0Y5_親指_親指2CP = new ColorP(this.X0Y5_親指_親指2, this.親指_親指2CD, DisUnit, true);
			this.X0Y5_親指_親指3CP = new ColorP(this.X0Y5_親指_親指3, this.親指_親指3CD, DisUnit, true);
			this.X0Y5_親指_水掻CP = new ColorP(this.X0Y5_親指_水掻, this.親指_水掻CD, DisUnit, true);
			this.X0Y5_人指_人指3CP = new ColorP(this.X0Y5_人指_人指3, this.人指_人指3CD, DisUnit, true);
			this.X0Y5_人指_人指2CP = new ColorP(this.X0Y5_人指_人指2, this.人指_人指2CD, DisUnit, true);
			this.X0Y5_人指_人指1CP = new ColorP(this.X0Y5_人指_人指1, this.人指_人指1CD, DisUnit, true);
			this.X0Y5_人指_水掻CP = new ColorP(this.X0Y5_人指_水掻, this.人指_水掻CD, DisUnit, true);
			this.X0Y5_中指_中指3CP = new ColorP(this.X0Y5_中指_中指3, this.中指_中指3CD, DisUnit, true);
			this.X0Y5_中指_中指2CP = new ColorP(this.X0Y5_中指_中指2, this.中指_中指2CD, DisUnit, true);
			this.X0Y5_中指_中指1CP = new ColorP(this.X0Y5_中指_中指1, this.中指_中指1CD, DisUnit, true);
			this.X0Y5_中指_水掻CP = new ColorP(this.X0Y5_中指_水掻, this.中指_水掻CD, DisUnit, true);
			this.X0Y5_薬指_薬指3CP = new ColorP(this.X0Y5_薬指_薬指3, this.薬指_薬指3CD, DisUnit, true);
			this.X0Y5_薬指_薬指2CP = new ColorP(this.X0Y5_薬指_薬指2, this.薬指_薬指2CD, DisUnit, true);
			this.X0Y5_薬指_薬指1CP = new ColorP(this.X0Y5_薬指_薬指1, this.薬指_薬指1CD, DisUnit, true);
			this.X0Y5_薬指_水掻CP = new ColorP(this.X0Y5_薬指_水掻, this.薬指_水掻CD, DisUnit, true);
			this.X0Y5_小指_小指3CP = new ColorP(this.X0Y5_小指_小指3, this.小指_小指3CD, DisUnit, true);
			this.X0Y5_小指_小指2CP = new ColorP(this.X0Y5_小指_小指2, this.小指_小指2CD, DisUnit, true);
			this.X0Y5_小指_小指1CP = new ColorP(this.X0Y5_小指_小指1, this.小指_小指1CD, DisUnit, true);
			this.X0Y5_手CP = new ColorP(this.X0Y5_手, this.手CD, DisUnit, true);
			this.X0Y5_獣性_獣毛CP = new ColorP(this.X0Y5_獣性_獣毛, this.獣性_獣毛CD, DisUnit, true);
			this.X0Y5_竜性_鱗1CP = new ColorP(this.X0Y5_竜性_鱗1, this.竜性_鱗1CD, DisUnit, true);
			this.X0Y5_竜性_鱗2CP = new ColorP(this.X0Y5_竜性_鱗2, this.竜性_鱗2CD, DisUnit, true);
			this.X0Y5_竜性_鱗3CP = new ColorP(this.X0Y5_竜性_鱗3, this.竜性_鱗3CD, DisUnit, true);
			this.X0Y5_悪タトゥ_五芒星_円1CP = new ColorP(this.X0Y5_悪タトゥ_五芒星_円1, this.悪タトゥ_五芒星_円1CD, DisUnit, false);
			this.X0Y5_悪タトゥ_五芒星_円2CP = new ColorP(this.X0Y5_悪タトゥ_五芒星_円2, this.悪タトゥ_五芒星_円2CD, DisUnit, false);
			this.X0Y5_悪タトゥ_五芒星_星CP = new ColorP(this.X0Y5_悪タトゥ_五芒星_星, this.悪タトゥ_五芒星_星CD, DisUnit, false);
			this.X0Y5_悪タトゥ_五芒星_五角形CP = new ColorP(this.X0Y5_悪タトゥ_五芒星_五角形, this.悪タトゥ_五芒星_五角形CD, DisUnit, false);
			this.X0Y5_グロ\u30FCブ_グロ\u30FCブCP = new ColorP(this.X0Y5_グロ\u30FCブ_グロ\u30FCブ, this.グロ\u30FCブ_グロ\u30FCブCD, DisUnit, true);
			this.X0Y5_グロ\u30FCブ_縁1CP = new ColorP(this.X0Y5_グロ\u30FCブ_縁1, this.グロ\u30FCブ_縁1CD, DisUnit, true);
			this.X0Y5_グロ\u30FCブ_縁2CP = new ColorP(this.X0Y5_グロ\u30FCブ_縁2, this.グロ\u30FCブ_縁2CD, DisUnit, true);
			this.X0Y6_小指_小指3CP = new ColorP(this.X0Y6_小指_小指3, this.小指_小指3CD, DisUnit, true);
			this.X0Y6_小指_小指2CP = new ColorP(this.X0Y6_小指_小指2, this.小指_小指2CD, DisUnit, true);
			this.X0Y6_小指_小指1CP = new ColorP(this.X0Y6_小指_小指1, this.小指_小指1CD, DisUnit, true);
			this.X0Y6_薬指_水掻CP = new ColorP(this.X0Y6_薬指_水掻, this.薬指_水掻CD, DisUnit, true);
			this.X0Y6_薬指_薬指3CP = new ColorP(this.X0Y6_薬指_薬指3, this.薬指_薬指3CD, DisUnit, true);
			this.X0Y6_薬指_薬指2CP = new ColorP(this.X0Y6_薬指_薬指2, this.薬指_薬指2CD, DisUnit, true);
			this.X0Y6_薬指_薬指1CP = new ColorP(this.X0Y6_薬指_薬指1, this.薬指_薬指1CD, DisUnit, true);
			this.X0Y6_中指_水掻CP = new ColorP(this.X0Y6_中指_水掻, this.中指_水掻CD, DisUnit, true);
			this.X0Y6_中指_中指3CP = new ColorP(this.X0Y6_中指_中指3, this.中指_中指3CD, DisUnit, true);
			this.X0Y6_中指_中指2CP = new ColorP(this.X0Y6_中指_中指2, this.中指_中指2CD, DisUnit, true);
			this.X0Y6_中指_中指1CP = new ColorP(this.X0Y6_中指_中指1, this.中指_中指1CD, DisUnit, true);
			this.X0Y6_人指_水掻CP = new ColorP(this.X0Y6_人指_水掻, this.人指_水掻CD, DisUnit, true);
			this.X0Y6_人指_人指3CP = new ColorP(this.X0Y6_人指_人指3, this.人指_人指3CD, DisUnit, true);
			this.X0Y6_人指_人指2CP = new ColorP(this.X0Y6_人指_人指2, this.人指_人指2CD, DisUnit, true);
			this.X0Y6_人指_人指1CP = new ColorP(this.X0Y6_人指_人指1, this.人指_人指1CD, DisUnit, true);
			this.X0Y6_親指_親指3CP = new ColorP(this.X0Y6_親指_親指3, this.親指_親指3CD, DisUnit, true);
			this.X0Y6_親指_親指2CP = new ColorP(this.X0Y6_親指_親指2, this.親指_親指2CD, DisUnit, true);
			this.X0Y6_親指_親指1CP = new ColorP(this.X0Y6_親指_親指1, this.親指_親指1CD, DisUnit, true);
			this.X0Y6_親指_水掻CP = new ColorP(this.X0Y6_親指_水掻, this.親指_水掻CD, DisUnit, true);
			this.X0Y6_手CP = new ColorP(this.X0Y6_手, this.手CD, DisUnit, true);
			this.X0Y6_獣性_獣毛CP = new ColorP(this.X0Y6_獣性_獣毛, this.獣性_獣毛CD, DisUnit, true);
			this.X0Y6_竜性_鱗1CP = new ColorP(this.X0Y6_竜性_鱗1, this.竜性_鱗1CD, DisUnit, true);
			this.X0Y6_竜性_鱗2CP = new ColorP(this.X0Y6_竜性_鱗2, this.竜性_鱗2CD, DisUnit, true);
			this.X0Y6_竜性_鱗3CP = new ColorP(this.X0Y6_竜性_鱗3, this.竜性_鱗3CD, DisUnit, true);
			this.X0Y6_悪タトゥ_五芒星_円1CP = new ColorP(this.X0Y6_悪タトゥ_五芒星_円1, this.悪タトゥ_五芒星_円1CD, DisUnit, false);
			this.X0Y6_悪タトゥ_五芒星_円2CP = new ColorP(this.X0Y6_悪タトゥ_五芒星_円2, this.悪タトゥ_五芒星_円2CD, DisUnit, false);
			this.X0Y6_悪タトゥ_五芒星_星CP = new ColorP(this.X0Y6_悪タトゥ_五芒星_星, this.悪タトゥ_五芒星_星CD, DisUnit, false);
			this.X0Y6_悪タトゥ_五芒星_五角形CP = new ColorP(this.X0Y6_悪タトゥ_五芒星_五角形, this.悪タトゥ_五芒星_五角形CD, DisUnit, false);
			this.X0Y6_グロ\u30FCブ_グロ\u30FCブCP = new ColorP(this.X0Y6_グロ\u30FCブ_グロ\u30FCブ, this.グロ\u30FCブ_グロ\u30FCブCD, DisUnit, true);
			this.X0Y6_グロ\u30FCブ_縁1CP = new ColorP(this.X0Y6_グロ\u30FCブ_縁1, this.グロ\u30FCブ_縁1CD, DisUnit, true);
			this.X0Y6_グロ\u30FCブ_縁2CP = new ColorP(this.X0Y6_グロ\u30FCブ_縁2, this.グロ\u30FCブ_縁2CD, DisUnit, true);
			this.X0Y7_親指_親指1CP = new ColorP(this.X0Y7_親指_親指1, this.親指_親指1CD, DisUnit, true);
			this.X0Y7_親指_親指2CP = new ColorP(this.X0Y7_親指_親指2, this.親指_親指2CD, DisUnit, true);
			this.X0Y7_親指_親指3CP = new ColorP(this.X0Y7_親指_親指3, this.親指_親指3CD, DisUnit, true);
			this.X0Y7_親指_水掻CP = new ColorP(this.X0Y7_親指_水掻, this.親指_水掻CD, DisUnit, true);
			this.X0Y7_手CP = new ColorP(this.X0Y7_手, this.手CD, DisUnit, true);
			this.X0Y7_人指_人指3CP = new ColorP(this.X0Y7_人指_人指3, this.人指_人指3CD, DisUnit, true);
			this.X0Y7_人指_人指2CP = new ColorP(this.X0Y7_人指_人指2, this.人指_人指2CD, DisUnit, true);
			this.X0Y7_人指_人指1CP = new ColorP(this.X0Y7_人指_人指1, this.人指_人指1CD, DisUnit, true);
			this.X0Y7_人指_水掻CP = new ColorP(this.X0Y7_人指_水掻, this.人指_水掻CD, DisUnit, true);
			this.X0Y7_中指_中指3CP = new ColorP(this.X0Y7_中指_中指3, this.中指_中指3CD, DisUnit, true);
			this.X0Y7_中指_中指2CP = new ColorP(this.X0Y7_中指_中指2, this.中指_中指2CD, DisUnit, true);
			this.X0Y7_中指_中指1CP = new ColorP(this.X0Y7_中指_中指1, this.中指_中指1CD, DisUnit, true);
			this.X0Y7_中指_水掻CP = new ColorP(this.X0Y7_中指_水掻, this.中指_水掻CD, DisUnit, true);
			this.X0Y7_小指_小指3CP = new ColorP(this.X0Y7_小指_小指3, this.小指_小指3CD, DisUnit, true);
			this.X0Y7_小指_小指2CP = new ColorP(this.X0Y7_小指_小指2, this.小指_小指2CD, DisUnit, true);
			this.X0Y7_小指_小指1CP = new ColorP(this.X0Y7_小指_小指1, this.小指_小指1CD, DisUnit, true);
			this.X0Y7_薬指_薬指3CP = new ColorP(this.X0Y7_薬指_薬指3, this.薬指_薬指3CD, DisUnit, true);
			this.X0Y7_薬指_薬指2CP = new ColorP(this.X0Y7_薬指_薬指2, this.薬指_薬指2CD, DisUnit, true);
			this.X0Y7_薬指_薬指1CP = new ColorP(this.X0Y7_薬指_薬指1, this.薬指_薬指1CD, DisUnit, true);
			this.X0Y7_薬指_水掻CP = new ColorP(this.X0Y7_薬指_水掻, this.薬指_水掻CD, DisUnit, true);
			this.X0Y7_獣性_獣毛CP = new ColorP(this.X0Y7_獣性_獣毛, this.獣性_獣毛CD, DisUnit, true);
			this.X0Y7_竜性_鱗1CP = new ColorP(this.X0Y7_竜性_鱗1, this.竜性_鱗1CD, DisUnit, true);
			this.X0Y7_竜性_鱗2CP = new ColorP(this.X0Y7_竜性_鱗2, this.竜性_鱗2CD, DisUnit, true);
			this.X0Y7_竜性_鱗3CP = new ColorP(this.X0Y7_竜性_鱗3, this.竜性_鱗3CD, DisUnit, true);
			this.X0Y7_悪タトゥ_五芒星_円1CP = new ColorP(this.X0Y7_悪タトゥ_五芒星_円1, this.悪タトゥ_五芒星_円1CD, DisUnit, false);
			this.X0Y7_悪タトゥ_五芒星_円2CP = new ColorP(this.X0Y7_悪タトゥ_五芒星_円2, this.悪タトゥ_五芒星_円2CD, DisUnit, false);
			this.X0Y7_悪タトゥ_五芒星_星CP = new ColorP(this.X0Y7_悪タトゥ_五芒星_星, this.悪タトゥ_五芒星_星CD, DisUnit, false);
			this.X0Y7_悪タトゥ_五芒星_五角形CP = new ColorP(this.X0Y7_悪タトゥ_五芒星_五角形, this.悪タトゥ_五芒星_五角形CD, DisUnit, false);
			this.X0Y7_グロ\u30FCブ_グロ\u30FCブCP = new ColorP(this.X0Y7_グロ\u30FCブ_グロ\u30FCブ, this.グロ\u30FCブ_グロ\u30FCブCD, DisUnit, true);
			this.X0Y7_グロ\u30FCブ_縁1CP = new ColorP(this.X0Y7_グロ\u30FCブ_縁1, this.グロ\u30FCブ_縁1CD, DisUnit, true);
			this.X0Y7_グロ\u30FCブ_縁2CP = new ColorP(this.X0Y7_グロ\u30FCブ_縁2, this.グロ\u30FCブ_縁2CD, DisUnit, true);
			this.X0Y8_親指_親指3CP = new ColorP(this.X0Y8_親指_親指3, this.親指_親指3CD, DisUnit, true);
			this.X0Y8_親指_親指2CP = new ColorP(this.X0Y8_親指_親指2, this.親指_親指2CD, DisUnit, true);
			this.X0Y8_親指_親指1CP = new ColorP(this.X0Y8_親指_親指1, this.親指_親指1CD, DisUnit, true);
			this.X0Y8_親指_水掻CP = new ColorP(this.X0Y8_親指_水掻, this.親指_水掻CD, DisUnit, true);
			this.X0Y8_人指_人指3CP = new ColorP(this.X0Y8_人指_人指3, this.人指_人指3CD, DisUnit, true);
			this.X0Y8_人指_人指2CP = new ColorP(this.X0Y8_人指_人指2, this.人指_人指2CD, DisUnit, true);
			this.X0Y8_人指_人指1CP = new ColorP(this.X0Y8_人指_人指1, this.人指_人指1CD, DisUnit, true);
			this.X0Y8_人指_水掻CP = new ColorP(this.X0Y8_人指_水掻, this.人指_水掻CD, DisUnit, true);
			this.X0Y8_中指_中指3CP = new ColorP(this.X0Y8_中指_中指3, this.中指_中指3CD, DisUnit, true);
			this.X0Y8_中指_中指2CP = new ColorP(this.X0Y8_中指_中指2, this.中指_中指2CD, DisUnit, true);
			this.X0Y8_中指_中指1CP = new ColorP(this.X0Y8_中指_中指1, this.中指_中指1CD, DisUnit, true);
			this.X0Y8_中指_水掻CP = new ColorP(this.X0Y8_中指_水掻, this.中指_水掻CD, DisUnit, true);
			this.X0Y8_薬指_薬指3CP = new ColorP(this.X0Y8_薬指_薬指3, this.薬指_薬指3CD, DisUnit, true);
			this.X0Y8_薬指_薬指2CP = new ColorP(this.X0Y8_薬指_薬指2, this.薬指_薬指2CD, DisUnit, true);
			this.X0Y8_薬指_薬指1CP = new ColorP(this.X0Y8_薬指_薬指1, this.薬指_薬指1CD, DisUnit, true);
			this.X0Y8_薬指_水掻CP = new ColorP(this.X0Y8_薬指_水掻, this.薬指_水掻CD, DisUnit, true);
			this.X0Y8_小指_小指3CP = new ColorP(this.X0Y8_小指_小指3, this.小指_小指3CD, DisUnit, true);
			this.X0Y8_小指_小指2CP = new ColorP(this.X0Y8_小指_小指2, this.小指_小指2CD, DisUnit, true);
			this.X0Y8_小指_小指1CP = new ColorP(this.X0Y8_小指_小指1, this.小指_小指1CD, DisUnit, true);
			this.X0Y8_手CP = new ColorP(this.X0Y8_手, this.手CD, DisUnit, true);
			this.X0Y8_獣性_獣毛CP = new ColorP(this.X0Y8_獣性_獣毛, this.獣性_獣毛CD, DisUnit, true);
			this.X0Y8_竜性_鱗1CP = new ColorP(this.X0Y8_竜性_鱗1, this.竜性_鱗1CD, DisUnit, true);
			this.X0Y8_竜性_鱗2CP = new ColorP(this.X0Y8_竜性_鱗2, this.竜性_鱗2CD, DisUnit, true);
			this.X0Y8_竜性_鱗3CP = new ColorP(this.X0Y8_竜性_鱗3, this.竜性_鱗3CD, DisUnit, true);
			this.X0Y8_悪タトゥ_五芒星_円1CP = new ColorP(this.X0Y8_悪タトゥ_五芒星_円1, this.悪タトゥ_五芒星_円1CD, DisUnit, false);
			this.X0Y8_悪タトゥ_五芒星_円2CP = new ColorP(this.X0Y8_悪タトゥ_五芒星_円2, this.悪タトゥ_五芒星_円2CD, DisUnit, false);
			this.X0Y8_悪タトゥ_五芒星_星CP = new ColorP(this.X0Y8_悪タトゥ_五芒星_星, this.悪タトゥ_五芒星_星CD, DisUnit, false);
			this.X0Y8_悪タトゥ_五芒星_五角形CP = new ColorP(this.X0Y8_悪タトゥ_五芒星_五角形, this.悪タトゥ_五芒星_五角形CD, DisUnit, false);
			this.X0Y8_グロ\u30FCブ_グロ\u30FCブCP = new ColorP(this.X0Y8_グロ\u30FCブ_グロ\u30FCブ, this.グロ\u30FCブ_グロ\u30FCブCD, DisUnit, true);
			this.X0Y8_グロ\u30FCブ_縁1CP = new ColorP(this.X0Y8_グロ\u30FCブ_縁1, this.グロ\u30FCブ_縁1CD, DisUnit, true);
			this.X0Y8_グロ\u30FCブ_縁2CP = new ColorP(this.X0Y8_グロ\u30FCブ_縁2, this.グロ\u30FCブ_縁2CD, DisUnit, true);
			this.X0Y9_グロ\u30FCブ_グロ\u30FCブCP = new ColorP(this.X0Y9_グロ\u30FCブ_グロ\u30FCブ, this.グロ\u30FCブ_グロ\u30FCブCD, DisUnit, true);
			this.X0Y9_グロ\u30FCブ_縁1CP = new ColorP(this.X0Y9_グロ\u30FCブ_縁1, this.グロ\u30FCブ_縁1CD, DisUnit, true);
			this.X0Y9_グロ\u30FCブ_縁2CP = new ColorP(this.X0Y9_グロ\u30FCブ_縁2, this.グロ\u30FCブ_縁2CD, DisUnit, true);
			this.X0Y9_獣性_獣毛CP = new ColorP(this.X0Y9_獣性_獣毛, this.獣性_獣毛CD, DisUnit, true);
			this.X0Y9_手CP = new ColorP(this.X0Y9_手, this.手CD, DisUnit, true);
			this.X0Y9_獣肉球CP = new ColorP(this.X0Y9_獣肉球, this.獣性_肉球CD, DisUnit, true);
			this.X0Y9_人指_人指1CP = new ColorP(this.X0Y9_人指_人指1, this.人指_人指1CD, DisUnit, true);
			this.X0Y9_人指_人指3CP = new ColorP(this.X0Y9_人指_人指3, this.人指_人指3CD, DisUnit, true);
			this.X0Y9_人指_人指2CP = new ColorP(this.X0Y9_人指_人指2, this.人指_人指2CD, DisUnit, true);
			this.X0Y9_人指_水掻CP = new ColorP(this.X0Y9_人指_水掻, this.人指_水掻CD, DisUnit, true);
			this.X0Y9_中指_中指1CP = new ColorP(this.X0Y9_中指_中指1, this.中指_中指1CD, DisUnit, true);
			this.X0Y9_中指_中指3CP = new ColorP(this.X0Y9_中指_中指3, this.中指_中指3CD, DisUnit, true);
			this.X0Y9_中指_中指2CP = new ColorP(this.X0Y9_中指_中指2, this.中指_中指2CD, DisUnit, true);
			this.X0Y9_中指_水掻CP = new ColorP(this.X0Y9_中指_水掻, this.中指_水掻CD, DisUnit, true);
			this.X0Y9_薬指_薬指1CP = new ColorP(this.X0Y9_薬指_薬指1, this.薬指_薬指1CD, DisUnit, true);
			this.X0Y9_薬指_薬指3CP = new ColorP(this.X0Y9_薬指_薬指3, this.薬指_薬指3CD, DisUnit, true);
			this.X0Y9_薬指_薬指2CP = new ColorP(this.X0Y9_薬指_薬指2, this.薬指_薬指2CD, DisUnit, true);
			this.X0Y9_薬指_水掻CP = new ColorP(this.X0Y9_薬指_水掻, this.薬指_水掻CD, DisUnit, true);
			this.X0Y9_小指_小指1CP = new ColorP(this.X0Y9_小指_小指1, this.小指_小指1CD, DisUnit, true);
			this.X0Y9_小指_小指3CP = new ColorP(this.X0Y9_小指_小指3, this.小指_小指3CD, DisUnit, true);
			this.X0Y9_小指_小指2CP = new ColorP(this.X0Y9_小指_小指2, this.小指_小指2CD, DisUnit, true);
			this.X0Y9_親指_水掻CP = new ColorP(this.X0Y9_親指_水掻, this.親指_水掻CD, DisUnit, true);
			this.X0Y9_親指_親指1CP = new ColorP(this.X0Y9_親指_親指1, this.親指_親指1CD, DisUnit, true);
			this.X0Y9_親指_獣肉球CP = new ColorP(this.X0Y9_親指_獣肉球, this.獣性_肉球CD, DisUnit, true);
			this.X0Y9_親指_親指2CP = new ColorP(this.X0Y9_親指_親指2, this.親指_親指2CD, DisUnit, true);
			this.X0Y9_親指_親指3CP = new ColorP(this.X0Y9_親指_親指3, this.親指_親指3CD, DisUnit, true);
			this.X0Y10_親指_親指3CP = new ColorP(this.X0Y10_親指_親指3, this.親指_親指3CD, DisUnit, true);
			this.X0Y10_親指_親指2CP = new ColorP(this.X0Y10_親指_親指2, this.親指_親指2CD, DisUnit, true);
			this.X0Y10_親指_親指1CP = new ColorP(this.X0Y10_親指_親指1, this.親指_親指1CD, DisUnit, true);
			this.X0Y10_親指_水掻CP = new ColorP(this.X0Y10_親指_水掻, this.親指_水掻CD, DisUnit, true);
			this.X0Y10_人指_人指3CP = new ColorP(this.X0Y10_人指_人指3, this.人指_人指3CD, DisUnit, true);
			this.X0Y10_人指_人指2CP = new ColorP(this.X0Y10_人指_人指2, this.人指_人指2CD, DisUnit, true);
			this.X0Y10_人指_人指1CP = new ColorP(this.X0Y10_人指_人指1, this.人指_人指1CD, DisUnit, true);
			this.X0Y10_人指_水掻CP = new ColorP(this.X0Y10_人指_水掻, this.人指_水掻CD, DisUnit, true);
			this.X0Y10_小指_小指3CP = new ColorP(this.X0Y10_小指_小指3, this.小指_小指3CD, DisUnit, true);
			this.X0Y10_小指_小指2CP = new ColorP(this.X0Y10_小指_小指2, this.小指_小指2CD, DisUnit, true);
			this.X0Y10_小指_小指1CP = new ColorP(this.X0Y10_小指_小指1, this.小指_小指1CD, DisUnit, true);
			this.X0Y10_中指_中指3CP = new ColorP(this.X0Y10_中指_中指3, this.中指_中指3CD, DisUnit, true);
			this.X0Y10_中指_中指2CP = new ColorP(this.X0Y10_中指_中指2, this.中指_中指2CD, DisUnit, true);
			this.X0Y10_中指_中指1CP = new ColorP(this.X0Y10_中指_中指1, this.中指_中指1CD, DisUnit, true);
			this.X0Y10_中指_水掻CP = new ColorP(this.X0Y10_中指_水掻, this.中指_水掻CD, DisUnit, true);
			this.X0Y10_薬指_薬指3CP = new ColorP(this.X0Y10_薬指_薬指3, this.薬指_薬指3CD, DisUnit, true);
			this.X0Y10_薬指_薬指2CP = new ColorP(this.X0Y10_薬指_薬指2, this.薬指_薬指2CD, DisUnit, true);
			this.X0Y10_薬指_薬指1CP = new ColorP(this.X0Y10_薬指_薬指1, this.薬指_薬指1CD, DisUnit, true);
			this.X0Y10_薬指_水掻CP = new ColorP(this.X0Y10_薬指_水掻, this.薬指_水掻CD, DisUnit, true);
			this.X0Y10_手CP = new ColorP(this.X0Y10_手, this.手CD, DisUnit, true);
			this.X0Y10_獣性_獣毛CP = new ColorP(this.X0Y10_獣性_獣毛, this.獣性_獣毛CD, DisUnit, true);
			this.X0Y10_竜性_鱗1CP = new ColorP(this.X0Y10_竜性_鱗1, this.竜性_鱗1CD, DisUnit, true);
			this.X0Y10_竜性_鱗2CP = new ColorP(this.X0Y10_竜性_鱗2, this.竜性_鱗2CD, DisUnit, true);
			this.X0Y10_竜性_鱗3CP = new ColorP(this.X0Y10_竜性_鱗3, this.竜性_鱗3CD, DisUnit, true);
			this.X0Y10_悪タトゥ_五芒星_円1CP = new ColorP(this.X0Y10_悪タトゥ_五芒星_円1, this.悪タトゥ_五芒星_円1CD, DisUnit, false);
			this.X0Y10_悪タトゥ_五芒星_円2CP = new ColorP(this.X0Y10_悪タトゥ_五芒星_円2, this.悪タトゥ_五芒星_円2CD, DisUnit, false);
			this.X0Y10_悪タトゥ_五芒星_星CP = new ColorP(this.X0Y10_悪タトゥ_五芒星_星, this.悪タトゥ_五芒星_星CD, DisUnit, false);
			this.X0Y10_悪タトゥ_五芒星_五角形CP = new ColorP(this.X0Y10_悪タトゥ_五芒星_五角形, this.悪タトゥ_五芒星_五角形CD, DisUnit, false);
			this.X0Y10_グロ\u30FCブ_グロ\u30FCブCP = new ColorP(this.X0Y10_グロ\u30FCブ_グロ\u30FCブ, this.グロ\u30FCブ_グロ\u30FCブCD, DisUnit, true);
			this.X0Y10_グロ\u30FCブ_縁1CP = new ColorP(this.X0Y10_グロ\u30FCブ_縁1, this.グロ\u30FCブ_縁1CD, DisUnit, true);
			this.X0Y10_グロ\u30FCブ_縁2CP = new ColorP(this.X0Y10_グロ\u30FCブ_縁2, this.グロ\u30FCブ_縁2CD, DisUnit, true);
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
			}
		}

		public bool グロ\u30FCブ_グロ\u30FCブ_表示
		{
			get
			{
				return this.X0Y0_グロ\u30FCブ_グロ\u30FCブ.Dra;
			}
			set
			{
				this.X0Y0_グロ\u30FCブ_グロ\u30FCブ.Dra = value;
				this.X0Y1_グロ\u30FCブ_グロ\u30FCブ.Dra = value;
				this.X0Y2_グロ\u30FCブ_グロ\u30FCブ.Dra = value;
				this.X0Y3_グロ\u30FCブ_グロ\u30FCブ.Dra = value;
				this.X0Y4_グロ\u30FCブ_グロ\u30FCブ.Dra = value;
				this.X0Y5_グロ\u30FCブ_グロ\u30FCブ.Dra = value;
				this.X0Y6_グロ\u30FCブ_グロ\u30FCブ.Dra = value;
				this.X0Y7_グロ\u30FCブ_グロ\u30FCブ.Dra = value;
				this.X0Y8_グロ\u30FCブ_グロ\u30FCブ.Dra = value;
				this.X0Y9_グロ\u30FCブ_グロ\u30FCブ.Dra = value;
				this.X0Y10_グロ\u30FCブ_グロ\u30FCブ.Dra = value;
				this.X0Y0_グロ\u30FCブ_グロ\u30FCブ.Hit = value;
				this.X0Y1_グロ\u30FCブ_グロ\u30FCブ.Hit = value;
				this.X0Y2_グロ\u30FCブ_グロ\u30FCブ.Hit = value;
				this.X0Y3_グロ\u30FCブ_グロ\u30FCブ.Hit = value;
				this.X0Y4_グロ\u30FCブ_グロ\u30FCブ.Hit = value;
				this.X0Y5_グロ\u30FCブ_グロ\u30FCブ.Hit = value;
				this.X0Y6_グロ\u30FCブ_グロ\u30FCブ.Hit = value;
				this.X0Y7_グロ\u30FCブ_グロ\u30FCブ.Hit = value;
				this.X0Y8_グロ\u30FCブ_グロ\u30FCブ.Hit = value;
				this.X0Y9_グロ\u30FCブ_グロ\u30FCブ.Hit = value;
				this.X0Y10_グロ\u30FCブ_グロ\u30FCブ.Hit = value;
			}
		}

		public bool グロ\u30FCブ_縁1_表示
		{
			get
			{
				return this.X0Y0_グロ\u30FCブ_縁1.Dra;
			}
			set
			{
				this.X0Y0_グロ\u30FCブ_縁1.Dra = value;
				this.X0Y1_グロ\u30FCブ_縁1.Dra = value;
				this.X0Y2_グロ\u30FCブ_縁1.Dra = value;
				this.X0Y3_グロ\u30FCブ_縁1.Dra = value;
				this.X0Y4_グロ\u30FCブ_縁1.Dra = value;
				this.X0Y5_グロ\u30FCブ_縁1.Dra = value;
				this.X0Y6_グロ\u30FCブ_縁1.Dra = value;
				this.X0Y7_グロ\u30FCブ_縁1.Dra = value;
				this.X0Y8_グロ\u30FCブ_縁1.Dra = value;
				this.X0Y9_グロ\u30FCブ_縁1.Dra = value;
				this.X0Y10_グロ\u30FCブ_縁1.Dra = value;
				this.X0Y0_グロ\u30FCブ_縁1.Hit = value;
				this.X0Y1_グロ\u30FCブ_縁1.Hit = value;
				this.X0Y2_グロ\u30FCブ_縁1.Hit = value;
				this.X0Y3_グロ\u30FCブ_縁1.Hit = value;
				this.X0Y4_グロ\u30FCブ_縁1.Hit = value;
				this.X0Y5_グロ\u30FCブ_縁1.Hit = value;
				this.X0Y6_グロ\u30FCブ_縁1.Hit = value;
				this.X0Y7_グロ\u30FCブ_縁1.Hit = value;
				this.X0Y8_グロ\u30FCブ_縁1.Hit = value;
				this.X0Y9_グロ\u30FCブ_縁1.Hit = value;
				this.X0Y10_グロ\u30FCブ_縁1.Hit = value;
			}
		}

		public bool グロ\u30FCブ_縁2_表示
		{
			get
			{
				return this.X0Y0_グロ\u30FCブ_縁2.Dra;
			}
			set
			{
				this.X0Y0_グロ\u30FCブ_縁2.Dra = value;
				this.X0Y1_グロ\u30FCブ_縁2.Dra = value;
				this.X0Y2_グロ\u30FCブ_縁2.Dra = value;
				this.X0Y3_グロ\u30FCブ_縁2.Dra = value;
				this.X0Y4_グロ\u30FCブ_縁2.Dra = value;
				this.X0Y5_グロ\u30FCブ_縁2.Dra = value;
				this.X0Y6_グロ\u30FCブ_縁2.Dra = value;
				this.X0Y7_グロ\u30FCブ_縁2.Dra = value;
				this.X0Y8_グロ\u30FCブ_縁2.Dra = value;
				this.X0Y9_グロ\u30FCブ_縁2.Dra = value;
				this.X0Y10_グロ\u30FCブ_縁2.Dra = value;
				this.X0Y0_グロ\u30FCブ_縁2.Hit = value;
				this.X0Y1_グロ\u30FCブ_縁2.Hit = value;
				this.X0Y2_グロ\u30FCブ_縁2.Hit = value;
				this.X0Y3_グロ\u30FCブ_縁2.Hit = value;
				this.X0Y4_グロ\u30FCブ_縁2.Hit = value;
				this.X0Y5_グロ\u30FCブ_縁2.Hit = value;
				this.X0Y6_グロ\u30FCブ_縁2.Hit = value;
				this.X0Y7_グロ\u30FCブ_縁2.Hit = value;
				this.X0Y8_グロ\u30FCブ_縁2.Hit = value;
				this.X0Y9_グロ\u30FCブ_縁2.Hit = value;
				this.X0Y10_グロ\u30FCブ_縁2.Hit = value;
			}
		}

		public bool 獣性_獣毛_表示
		{
			get
			{
				return this.X0Y0_獣性_獣毛.Dra;
			}
			set
			{
				this.X0Y0_獣性_獣毛.Dra = value;
				this.X0Y1_獣性_獣毛.Dra = value;
				this.X0Y2_獣性_獣毛.Dra = value;
				this.X0Y3_獣性_獣毛.Dra = value;
				this.X0Y4_獣性_獣毛.Dra = value;
				this.X0Y5_獣性_獣毛.Dra = value;
				this.X0Y6_獣性_獣毛.Dra = value;
				this.X0Y7_獣性_獣毛.Dra = value;
				this.X0Y8_獣性_獣毛.Dra = value;
				this.X0Y9_獣性_獣毛.Dra = value;
				this.X0Y10_獣性_獣毛.Dra = value;
				this.X0Y0_獣性_獣毛.Hit = value;
				this.X0Y1_獣性_獣毛.Hit = value;
				this.X0Y2_獣性_獣毛.Hit = value;
				this.X0Y3_獣性_獣毛.Hit = value;
				this.X0Y4_獣性_獣毛.Hit = value;
				this.X0Y5_獣性_獣毛.Hit = value;
				this.X0Y6_獣性_獣毛.Hit = value;
				this.X0Y7_獣性_獣毛.Hit = value;
				this.X0Y8_獣性_獣毛.Hit = value;
				this.X0Y9_獣性_獣毛.Hit = value;
				this.X0Y10_獣性_獣毛.Hit = value;
			}
		}

		public bool 手_表示
		{
			get
			{
				return this.X0Y0_手.Dra;
			}
			set
			{
				this.X0Y0_手.Dra = value;
				this.X0Y1_手.Dra = value;
				this.X0Y2_手.Dra = value;
				this.X0Y3_手.Dra = value;
				this.X0Y4_手.Dra = value;
				this.X0Y5_手.Dra = value;
				this.X0Y6_手.Dra = value;
				this.X0Y7_手.Dra = value;
				this.X0Y8_手.Dra = value;
				this.X0Y9_手.Dra = value;
				this.X0Y10_手.Dra = value;
				this.X0Y0_手.Hit = value;
				this.X0Y1_手.Hit = value;
				this.X0Y2_手.Hit = value;
				this.X0Y3_手.Hit = value;
				this.X0Y4_手.Hit = value;
				this.X0Y5_手.Hit = value;
				this.X0Y6_手.Hit = value;
				this.X0Y7_手.Hit = value;
				this.X0Y8_手.Hit = value;
				this.X0Y9_手.Hit = value;
				this.X0Y10_手.Hit = value;
			}
		}

		public bool 獣性_肉球_表示
		{
			get
			{
				return this.X0Y0_獣性_肉球.Dra;
			}
			set
			{
				this.X0Y0_獣性_肉球.Dra = value;
				this.X0Y9_獣肉球.Dra = value;
				this.X0Y0_獣性_肉球.Hit = value;
				this.X0Y9_獣肉球.Hit = value;
			}
		}

		public bool 人指_人指1_表示
		{
			get
			{
				return this.X0Y0_人指_人指1.Dra;
			}
			set
			{
				this.X0Y0_人指_人指1.Dra = value;
				this.X0Y1_人指_人指1.Dra = value;
				this.X0Y2_人指_人指1.Dra = value;
				this.X0Y3_人指_人指1.Dra = value;
				this.X0Y4_人指_人指1.Dra = value;
				this.X0Y5_人指_人指1.Dra = value;
				this.X0Y6_人指_人指1.Dra = value;
				this.X0Y7_人指_人指1.Dra = value;
				this.X0Y8_人指_人指1.Dra = value;
				this.X0Y9_人指_人指1.Dra = value;
				this.X0Y10_人指_人指1.Dra = value;
				this.X0Y0_人指_人指1.Hit = value;
				this.X0Y1_人指_人指1.Hit = value;
				this.X0Y2_人指_人指1.Hit = value;
				this.X0Y3_人指_人指1.Hit = value;
				this.X0Y4_人指_人指1.Hit = value;
				this.X0Y5_人指_人指1.Hit = value;
				this.X0Y6_人指_人指1.Hit = value;
				this.X0Y7_人指_人指1.Hit = value;
				this.X0Y8_人指_人指1.Hit = value;
				this.X0Y9_人指_人指1.Hit = value;
				this.X0Y10_人指_人指1.Hit = value;
			}
		}

		public bool 人指_人指3_表示
		{
			get
			{
				return this.X0Y0_人指_人指3.Dra;
			}
			set
			{
				this.X0Y0_人指_人指3.Dra = value;
				this.X0Y1_人指_人指3.Dra = value;
				this.X0Y2_人指_人指3.Dra = value;
				this.X0Y3_人指_人指3.Dra = value;
				this.X0Y4_人指_人指3.Dra = value;
				this.X0Y5_人指_人指3.Dra = value;
				this.X0Y6_人指_人指3.Dra = value;
				this.X0Y7_人指_人指3.Dra = value;
				this.X0Y8_人指_人指3.Dra = value;
				this.X0Y9_人指_人指3.Dra = value;
				this.X0Y10_人指_人指3.Dra = value;
				this.X0Y0_人指_人指3.Hit = value;
				this.X0Y1_人指_人指3.Hit = value;
				this.X0Y2_人指_人指3.Hit = value;
				this.X0Y3_人指_人指3.Hit = value;
				this.X0Y4_人指_人指3.Hit = value;
				this.X0Y5_人指_人指3.Hit = value;
				this.X0Y6_人指_人指3.Hit = value;
				this.X0Y7_人指_人指3.Hit = value;
				this.X0Y8_人指_人指3.Hit = value;
				this.X0Y9_人指_人指3.Hit = value;
				this.X0Y10_人指_人指3.Hit = value;
			}
		}

		public bool 人指_人指2_表示
		{
			get
			{
				return this.X0Y0_人指_人指2.Dra;
			}
			set
			{
				this.X0Y0_人指_人指2.Dra = value;
				this.X0Y1_人指_人指2.Dra = value;
				this.X0Y2_人指_人指2.Dra = value;
				this.X0Y3_人指_人指2.Dra = value;
				this.X0Y4_人指_人指2.Dra = value;
				this.X0Y5_人指_人指2.Dra = value;
				this.X0Y6_人指_人指2.Dra = value;
				this.X0Y7_人指_人指2.Dra = value;
				this.X0Y8_人指_人指2.Dra = value;
				this.X0Y9_人指_人指2.Dra = value;
				this.X0Y10_人指_人指2.Dra = value;
				this.X0Y0_人指_人指2.Hit = value;
				this.X0Y1_人指_人指2.Hit = value;
				this.X0Y2_人指_人指2.Hit = value;
				this.X0Y3_人指_人指2.Hit = value;
				this.X0Y4_人指_人指2.Hit = value;
				this.X0Y5_人指_人指2.Hit = value;
				this.X0Y6_人指_人指2.Hit = value;
				this.X0Y7_人指_人指2.Hit = value;
				this.X0Y8_人指_人指2.Hit = value;
				this.X0Y9_人指_人指2.Hit = value;
				this.X0Y10_人指_人指2.Hit = value;
			}
		}

		public bool 人指_水掻_表示
		{
			get
			{
				return this.X0Y0_人指_水掻.Dra;
			}
			set
			{
				this.X0Y0_人指_水掻.Dra = value;
				this.X0Y1_人指_水掻.Dra = value;
				this.X0Y2_人指_水掻.Dra = value;
				this.X0Y3_人指_水掻.Dra = value;
				this.X0Y4_人指_水掻.Dra = value;
				this.X0Y5_人指_水掻.Dra = value;
				this.X0Y6_人指_水掻.Dra = value;
				this.X0Y7_人指_水掻.Dra = value;
				this.X0Y8_人指_水掻.Dra = value;
				this.X0Y9_人指_水掻.Dra = value;
				this.X0Y10_人指_水掻.Dra = value;
				this.X0Y0_人指_水掻.Hit = value;
				this.X0Y1_人指_水掻.Hit = value;
				this.X0Y2_人指_水掻.Hit = value;
				this.X0Y3_人指_水掻.Hit = value;
				this.X0Y4_人指_水掻.Hit = value;
				this.X0Y5_人指_水掻.Hit = value;
				this.X0Y6_人指_水掻.Hit = value;
				this.X0Y7_人指_水掻.Hit = value;
				this.X0Y8_人指_水掻.Hit = value;
				this.X0Y9_人指_水掻.Hit = value;
				this.X0Y10_人指_水掻.Hit = value;
			}
		}

		public bool 中指_中指1_表示
		{
			get
			{
				return this.X0Y0_中指_中指1.Dra;
			}
			set
			{
				this.X0Y0_中指_中指1.Dra = value;
				this.X0Y1_中指_中指1.Dra = value;
				this.X0Y2_中指_中指1.Dra = value;
				this.X0Y3_中指_中指1.Dra = value;
				this.X0Y4_中指_中指1.Dra = value;
				this.X0Y5_中指_中指1.Dra = value;
				this.X0Y6_中指_中指1.Dra = value;
				this.X0Y7_中指_中指1.Dra = value;
				this.X0Y8_中指_中指1.Dra = value;
				this.X0Y9_中指_中指1.Dra = value;
				this.X0Y10_中指_中指1.Dra = value;
				this.X0Y0_中指_中指1.Hit = value;
				this.X0Y1_中指_中指1.Hit = value;
				this.X0Y2_中指_中指1.Hit = value;
				this.X0Y3_中指_中指1.Hit = value;
				this.X0Y4_中指_中指1.Hit = value;
				this.X0Y5_中指_中指1.Hit = value;
				this.X0Y6_中指_中指1.Hit = value;
				this.X0Y7_中指_中指1.Hit = value;
				this.X0Y8_中指_中指1.Hit = value;
				this.X0Y9_中指_中指1.Hit = value;
				this.X0Y10_中指_中指1.Hit = value;
			}
		}

		public bool 中指_中指3_表示
		{
			get
			{
				return this.X0Y0_中指_中指3.Dra;
			}
			set
			{
				this.X0Y0_中指_中指3.Dra = value;
				this.X0Y1_中指_中指3.Dra = value;
				this.X0Y2_中指_中指3.Dra = value;
				this.X0Y3_中指_中指3.Dra = value;
				this.X0Y4_中指_中指3.Dra = value;
				this.X0Y5_中指_中指3.Dra = value;
				this.X0Y6_中指_中指3.Dra = value;
				this.X0Y7_中指_中指3.Dra = value;
				this.X0Y8_中指_中指3.Dra = value;
				this.X0Y9_中指_中指3.Dra = value;
				this.X0Y10_中指_中指3.Dra = value;
				this.X0Y0_中指_中指3.Hit = value;
				this.X0Y1_中指_中指3.Hit = value;
				this.X0Y2_中指_中指3.Hit = value;
				this.X0Y3_中指_中指3.Hit = value;
				this.X0Y4_中指_中指3.Hit = value;
				this.X0Y5_中指_中指3.Hit = value;
				this.X0Y6_中指_中指3.Hit = value;
				this.X0Y7_中指_中指3.Hit = value;
				this.X0Y8_中指_中指3.Hit = value;
				this.X0Y9_中指_中指3.Hit = value;
				this.X0Y10_中指_中指3.Hit = value;
			}
		}

		public bool 中指_中指2_表示
		{
			get
			{
				return this.X0Y0_中指_中指2.Dra;
			}
			set
			{
				this.X0Y0_中指_中指2.Dra = value;
				this.X0Y1_中指_中指2.Dra = value;
				this.X0Y2_中指_中指2.Dra = value;
				this.X0Y3_中指_中指2.Dra = value;
				this.X0Y4_中指_中指2.Dra = value;
				this.X0Y5_中指_中指2.Dra = value;
				this.X0Y6_中指_中指2.Dra = value;
				this.X0Y7_中指_中指2.Dra = value;
				this.X0Y8_中指_中指2.Dra = value;
				this.X0Y9_中指_中指2.Dra = value;
				this.X0Y10_中指_中指2.Dra = value;
				this.X0Y0_中指_中指2.Hit = value;
				this.X0Y1_中指_中指2.Hit = value;
				this.X0Y2_中指_中指2.Hit = value;
				this.X0Y3_中指_中指2.Hit = value;
				this.X0Y4_中指_中指2.Hit = value;
				this.X0Y5_中指_中指2.Hit = value;
				this.X0Y6_中指_中指2.Hit = value;
				this.X0Y7_中指_中指2.Hit = value;
				this.X0Y8_中指_中指2.Hit = value;
				this.X0Y9_中指_中指2.Hit = value;
				this.X0Y10_中指_中指2.Hit = value;
			}
		}

		public bool 中指_水掻_表示
		{
			get
			{
				return this.X0Y0_中指_水掻.Dra;
			}
			set
			{
				this.X0Y0_中指_水掻.Dra = value;
				this.X0Y1_中指_水掻.Dra = value;
				this.X0Y2_中指_水掻.Dra = value;
				this.X0Y3_中指_水掻.Dra = value;
				this.X0Y4_中指_水掻.Dra = value;
				this.X0Y5_中指_水掻.Dra = value;
				this.X0Y6_中指_水掻.Dra = value;
				this.X0Y7_中指_水掻.Dra = value;
				this.X0Y8_中指_水掻.Dra = value;
				this.X0Y9_中指_水掻.Dra = value;
				this.X0Y10_中指_水掻.Dra = value;
				this.X0Y0_中指_水掻.Hit = value;
				this.X0Y1_中指_水掻.Hit = value;
				this.X0Y2_中指_水掻.Hit = value;
				this.X0Y3_中指_水掻.Hit = value;
				this.X0Y4_中指_水掻.Hit = value;
				this.X0Y5_中指_水掻.Hit = value;
				this.X0Y6_中指_水掻.Hit = value;
				this.X0Y7_中指_水掻.Hit = value;
				this.X0Y8_中指_水掻.Hit = value;
				this.X0Y9_中指_水掻.Hit = value;
				this.X0Y10_中指_水掻.Hit = value;
			}
		}

		public bool 薬指_薬指1_表示
		{
			get
			{
				return this.X0Y0_薬指_薬指1.Dra;
			}
			set
			{
				this.X0Y0_薬指_薬指1.Dra = value;
				this.X0Y1_薬指_薬指1.Dra = value;
				this.X0Y2_薬指_薬指1.Dra = value;
				this.X0Y3_薬指_薬指1.Dra = value;
				this.X0Y4_薬指_薬指1.Dra = value;
				this.X0Y5_薬指_薬指1.Dra = value;
				this.X0Y6_薬指_薬指1.Dra = value;
				this.X0Y7_薬指_薬指1.Dra = value;
				this.X0Y8_薬指_薬指1.Dra = value;
				this.X0Y9_薬指_薬指1.Dra = value;
				this.X0Y10_薬指_薬指1.Dra = value;
				this.X0Y0_薬指_薬指1.Hit = value;
				this.X0Y1_薬指_薬指1.Hit = value;
				this.X0Y2_薬指_薬指1.Hit = value;
				this.X0Y3_薬指_薬指1.Hit = value;
				this.X0Y4_薬指_薬指1.Hit = value;
				this.X0Y5_薬指_薬指1.Hit = value;
				this.X0Y6_薬指_薬指1.Hit = value;
				this.X0Y7_薬指_薬指1.Hit = value;
				this.X0Y8_薬指_薬指1.Hit = value;
				this.X0Y9_薬指_薬指1.Hit = value;
				this.X0Y10_薬指_薬指1.Hit = value;
			}
		}

		public bool 薬指_薬指3_表示
		{
			get
			{
				return this.X0Y0_薬指_薬指3.Dra;
			}
			set
			{
				this.X0Y0_薬指_薬指3.Dra = value;
				this.X0Y1_薬指_薬指3.Dra = value;
				this.X0Y2_薬指_薬指3.Dra = value;
				this.X0Y3_薬指_薬指3.Dra = value;
				this.X0Y4_薬指_薬指3.Dra = value;
				this.X0Y5_薬指_薬指3.Dra = value;
				this.X0Y6_薬指_薬指3.Dra = value;
				this.X0Y7_薬指_薬指3.Dra = value;
				this.X0Y8_薬指_薬指3.Dra = value;
				this.X0Y9_薬指_薬指3.Dra = value;
				this.X0Y10_薬指_薬指3.Dra = value;
				this.X0Y0_薬指_薬指3.Hit = value;
				this.X0Y1_薬指_薬指3.Hit = value;
				this.X0Y2_薬指_薬指3.Hit = value;
				this.X0Y3_薬指_薬指3.Hit = value;
				this.X0Y4_薬指_薬指3.Hit = value;
				this.X0Y5_薬指_薬指3.Hit = value;
				this.X0Y6_薬指_薬指3.Hit = value;
				this.X0Y7_薬指_薬指3.Hit = value;
				this.X0Y8_薬指_薬指3.Hit = value;
				this.X0Y9_薬指_薬指3.Hit = value;
				this.X0Y10_薬指_薬指3.Hit = value;
			}
		}

		public bool 薬指_薬指2_表示
		{
			get
			{
				return this.X0Y0_薬指_薬指2.Dra;
			}
			set
			{
				this.X0Y0_薬指_薬指2.Dra = value;
				this.X0Y1_薬指_薬指2.Dra = value;
				this.X0Y2_薬指_薬指2.Dra = value;
				this.X0Y3_薬指_薬指2.Dra = value;
				this.X0Y4_薬指_薬指2.Dra = value;
				this.X0Y5_薬指_薬指2.Dra = value;
				this.X0Y6_薬指_薬指2.Dra = value;
				this.X0Y7_薬指_薬指2.Dra = value;
				this.X0Y8_薬指_薬指2.Dra = value;
				this.X0Y9_薬指_薬指2.Dra = value;
				this.X0Y10_薬指_薬指2.Dra = value;
				this.X0Y0_薬指_薬指2.Hit = value;
				this.X0Y1_薬指_薬指2.Hit = value;
				this.X0Y2_薬指_薬指2.Hit = value;
				this.X0Y3_薬指_薬指2.Hit = value;
				this.X0Y4_薬指_薬指2.Hit = value;
				this.X0Y5_薬指_薬指2.Hit = value;
				this.X0Y6_薬指_薬指2.Hit = value;
				this.X0Y7_薬指_薬指2.Hit = value;
				this.X0Y8_薬指_薬指2.Hit = value;
				this.X0Y9_薬指_薬指2.Hit = value;
				this.X0Y10_薬指_薬指2.Hit = value;
			}
		}

		public bool 薬指_水掻_表示
		{
			get
			{
				return this.X0Y0_薬指_水掻.Dra;
			}
			set
			{
				this.X0Y0_薬指_水掻.Dra = value;
				this.X0Y1_薬指_水掻.Dra = value;
				this.X0Y2_薬指_水掻.Dra = value;
				this.X0Y3_薬指_水掻.Dra = value;
				this.X0Y4_薬指_水掻.Dra = value;
				this.X0Y5_薬指_水掻.Dra = value;
				this.X0Y6_薬指_水掻.Dra = value;
				this.X0Y7_薬指_水掻.Dra = value;
				this.X0Y8_薬指_水掻.Dra = value;
				this.X0Y9_薬指_水掻.Dra = value;
				this.X0Y10_薬指_水掻.Dra = value;
				this.X0Y0_薬指_水掻.Hit = value;
				this.X0Y1_薬指_水掻.Hit = value;
				this.X0Y2_薬指_水掻.Hit = value;
				this.X0Y3_薬指_水掻.Hit = value;
				this.X0Y4_薬指_水掻.Hit = value;
				this.X0Y5_薬指_水掻.Hit = value;
				this.X0Y6_薬指_水掻.Hit = value;
				this.X0Y7_薬指_水掻.Hit = value;
				this.X0Y8_薬指_水掻.Hit = value;
				this.X0Y9_薬指_水掻.Hit = value;
				this.X0Y10_薬指_水掻.Hit = value;
			}
		}

		public bool 小指_小指1_表示
		{
			get
			{
				return this.X0Y0_小指_小指1.Dra;
			}
			set
			{
				this.X0Y0_小指_小指1.Dra = value;
				this.X0Y1_小指_小指1.Dra = value;
				this.X0Y2_小指_小指1.Dra = value;
				this.X0Y3_小指_小指1.Dra = value;
				this.X0Y4_小指_小指1.Dra = value;
				this.X0Y5_小指_小指1.Dra = value;
				this.X0Y6_小指_小指1.Dra = value;
				this.X0Y7_小指_小指1.Dra = value;
				this.X0Y8_小指_小指1.Dra = value;
				this.X0Y9_小指_小指1.Dra = value;
				this.X0Y10_小指_小指1.Dra = value;
				this.X0Y0_小指_小指1.Hit = value;
				this.X0Y1_小指_小指1.Hit = value;
				this.X0Y2_小指_小指1.Hit = value;
				this.X0Y3_小指_小指1.Hit = value;
				this.X0Y4_小指_小指1.Hit = value;
				this.X0Y5_小指_小指1.Hit = value;
				this.X0Y6_小指_小指1.Hit = value;
				this.X0Y7_小指_小指1.Hit = value;
				this.X0Y8_小指_小指1.Hit = value;
				this.X0Y9_小指_小指1.Hit = value;
				this.X0Y10_小指_小指1.Hit = value;
			}
		}

		public bool 小指_小指3_表示
		{
			get
			{
				return this.X0Y0_小指_小指3.Dra;
			}
			set
			{
				this.X0Y0_小指_小指3.Dra = value;
				this.X0Y1_小指_小指3.Dra = value;
				this.X0Y2_小指_小指3.Dra = value;
				this.X0Y3_小指_小指3.Dra = value;
				this.X0Y4_小指_小指3.Dra = value;
				this.X0Y5_小指_小指3.Dra = value;
				this.X0Y6_小指_小指3.Dra = value;
				this.X0Y7_小指_小指3.Dra = value;
				this.X0Y8_小指_小指3.Dra = value;
				this.X0Y9_小指_小指3.Dra = value;
				this.X0Y10_小指_小指3.Dra = value;
				this.X0Y0_小指_小指3.Hit = value;
				this.X0Y1_小指_小指3.Hit = value;
				this.X0Y2_小指_小指3.Hit = value;
				this.X0Y3_小指_小指3.Hit = value;
				this.X0Y4_小指_小指3.Hit = value;
				this.X0Y5_小指_小指3.Hit = value;
				this.X0Y6_小指_小指3.Hit = value;
				this.X0Y7_小指_小指3.Hit = value;
				this.X0Y8_小指_小指3.Hit = value;
				this.X0Y9_小指_小指3.Hit = value;
				this.X0Y10_小指_小指3.Hit = value;
			}
		}

		public bool 小指_小指2_表示
		{
			get
			{
				return this.X0Y0_小指_小指2.Dra;
			}
			set
			{
				this.X0Y0_小指_小指2.Dra = value;
				this.X0Y1_小指_小指2.Dra = value;
				this.X0Y2_小指_小指2.Dra = value;
				this.X0Y3_小指_小指2.Dra = value;
				this.X0Y4_小指_小指2.Dra = value;
				this.X0Y5_小指_小指2.Dra = value;
				this.X0Y6_小指_小指2.Dra = value;
				this.X0Y7_小指_小指2.Dra = value;
				this.X0Y8_小指_小指2.Dra = value;
				this.X0Y9_小指_小指2.Dra = value;
				this.X0Y10_小指_小指2.Dra = value;
				this.X0Y0_小指_小指2.Hit = value;
				this.X0Y1_小指_小指2.Hit = value;
				this.X0Y2_小指_小指2.Hit = value;
				this.X0Y3_小指_小指2.Hit = value;
				this.X0Y4_小指_小指2.Hit = value;
				this.X0Y5_小指_小指2.Hit = value;
				this.X0Y6_小指_小指2.Hit = value;
				this.X0Y7_小指_小指2.Hit = value;
				this.X0Y8_小指_小指2.Hit = value;
				this.X0Y9_小指_小指2.Hit = value;
				this.X0Y10_小指_小指2.Hit = value;
			}
		}

		public bool 親指_水掻_表示
		{
			get
			{
				return this.X0Y0_親指_水掻.Dra;
			}
			set
			{
				this.X0Y0_親指_水掻.Dra = value;
				this.X0Y1_親指_水掻.Dra = value;
				this.X0Y2_親指_水掻.Dra = value;
				this.X0Y3_親指_水掻.Dra = value;
				this.X0Y4_親指_水掻.Dra = value;
				this.X0Y5_親指_水掻.Dra = value;
				this.X0Y6_親指_水掻.Dra = value;
				this.X0Y7_親指_水掻.Dra = value;
				this.X0Y8_親指_水掻.Dra = value;
				this.X0Y9_親指_水掻.Dra = value;
				this.X0Y10_親指_水掻.Dra = value;
				this.X0Y0_親指_水掻.Hit = value;
				this.X0Y1_親指_水掻.Hit = value;
				this.X0Y2_親指_水掻.Hit = value;
				this.X0Y3_親指_水掻.Hit = value;
				this.X0Y4_親指_水掻.Hit = value;
				this.X0Y5_親指_水掻.Hit = value;
				this.X0Y6_親指_水掻.Hit = value;
				this.X0Y7_親指_水掻.Hit = value;
				this.X0Y8_親指_水掻.Hit = value;
				this.X0Y9_親指_水掻.Hit = value;
				this.X0Y10_親指_水掻.Hit = value;
			}
		}

		public bool 親指_親指1_表示
		{
			get
			{
				return this.X0Y0_親指_親指1.Dra;
			}
			set
			{
				this.X0Y0_親指_親指1.Dra = value;
				this.X0Y1_親指_親指1.Dra = value;
				this.X0Y2_親指_親指1.Dra = value;
				this.X0Y3_親指_親指1.Dra = value;
				this.X0Y4_親指_親指1.Dra = value;
				this.X0Y5_親指_親指1.Dra = value;
				this.X0Y6_親指_親指1.Dra = value;
				this.X0Y7_親指_親指1.Dra = value;
				this.X0Y8_親指_親指1.Dra = value;
				this.X0Y9_親指_親指1.Dra = value;
				this.X0Y10_親指_親指1.Dra = value;
				this.X0Y0_親指_親指1.Hit = value;
				this.X0Y1_親指_親指1.Hit = value;
				this.X0Y2_親指_親指1.Hit = value;
				this.X0Y3_親指_親指1.Hit = value;
				this.X0Y4_親指_親指1.Hit = value;
				this.X0Y5_親指_親指1.Hit = value;
				this.X0Y6_親指_親指1.Hit = value;
				this.X0Y7_親指_親指1.Hit = value;
				this.X0Y8_親指_親指1.Hit = value;
				this.X0Y9_親指_親指1.Hit = value;
				this.X0Y10_親指_親指1.Hit = value;
			}
		}

		public bool 親指_獣性_肉球_表示
		{
			get
			{
				return this.X0Y0_親指_獣性_肉球.Dra;
			}
			set
			{
				this.X0Y0_親指_獣性_肉球.Dra = value;
				this.X0Y9_親指_獣肉球.Dra = value;
				this.X0Y0_親指_獣性_肉球.Hit = value;
				this.X0Y9_親指_獣肉球.Hit = value;
			}
		}

		public bool 親指_親指2_表示
		{
			get
			{
				return this.X0Y0_親指_親指2.Dra;
			}
			set
			{
				this.X0Y0_親指_親指2.Dra = value;
				this.X0Y1_親指_親指2.Dra = value;
				this.X0Y2_親指_親指2.Dra = value;
				this.X0Y3_親指_親指2.Dra = value;
				this.X0Y4_親指_親指2.Dra = value;
				this.X0Y5_親指_親指2.Dra = value;
				this.X0Y6_親指_親指2.Dra = value;
				this.X0Y7_親指_親指2.Dra = value;
				this.X0Y8_親指_親指2.Dra = value;
				this.X0Y9_親指_親指2.Dra = value;
				this.X0Y10_親指_親指2.Dra = value;
				this.X0Y0_親指_親指2.Hit = value;
				this.X0Y1_親指_親指2.Hit = value;
				this.X0Y2_親指_親指2.Hit = value;
				this.X0Y3_親指_親指2.Hit = value;
				this.X0Y4_親指_親指2.Hit = value;
				this.X0Y5_親指_親指2.Hit = value;
				this.X0Y6_親指_親指2.Hit = value;
				this.X0Y7_親指_親指2.Hit = value;
				this.X0Y8_親指_親指2.Hit = value;
				this.X0Y9_親指_親指2.Hit = value;
				this.X0Y10_親指_親指2.Hit = value;
			}
		}

		public bool 親指_親指3_表示
		{
			get
			{
				return this.X0Y0_親指_親指3.Dra;
			}
			set
			{
				this.X0Y0_親指_親指3.Dra = value;
				this.X0Y1_親指_親指3.Dra = value;
				this.X0Y2_親指_親指3.Dra = value;
				this.X0Y3_親指_親指3.Dra = value;
				this.X0Y4_親指_親指3.Dra = value;
				this.X0Y5_親指_親指3.Dra = value;
				this.X0Y6_親指_親指3.Dra = value;
				this.X0Y7_親指_親指3.Dra = value;
				this.X0Y8_親指_親指3.Dra = value;
				this.X0Y9_親指_親指3.Dra = value;
				this.X0Y10_親指_親指3.Dra = value;
				this.X0Y0_親指_親指3.Hit = value;
				this.X0Y1_親指_親指3.Hit = value;
				this.X0Y2_親指_親指3.Hit = value;
				this.X0Y3_親指_親指3.Hit = value;
				this.X0Y4_親指_親指3.Hit = value;
				this.X0Y5_親指_親指3.Hit = value;
				this.X0Y6_親指_親指3.Hit = value;
				this.X0Y7_親指_親指3.Hit = value;
				this.X0Y8_親指_親指3.Hit = value;
				this.X0Y9_親指_親指3.Hit = value;
				this.X0Y10_親指_親指3.Hit = value;
			}
		}

		public bool 竜性_鱗1_表示
		{
			get
			{
				return this.X0Y1_竜性_鱗1.Dra;
			}
			set
			{
				this.X0Y1_竜性_鱗1.Dra = value;
				this.X0Y2_竜性_鱗1.Dra = value;
				this.X0Y3_竜性_鱗1.Dra = value;
				this.X0Y4_竜性_鱗1.Dra = value;
				this.X0Y5_竜性_鱗1.Dra = value;
				this.X0Y6_竜性_鱗1.Dra = value;
				this.X0Y7_竜性_鱗1.Dra = value;
				this.X0Y8_竜性_鱗1.Dra = value;
				this.X0Y10_竜性_鱗1.Dra = value;
				this.X0Y1_竜性_鱗1.Hit = value;
				this.X0Y2_竜性_鱗1.Hit = value;
				this.X0Y3_竜性_鱗1.Hit = value;
				this.X0Y4_竜性_鱗1.Hit = value;
				this.X0Y5_竜性_鱗1.Hit = value;
				this.X0Y6_竜性_鱗1.Hit = value;
				this.X0Y7_竜性_鱗1.Hit = value;
				this.X0Y8_竜性_鱗1.Hit = value;
				this.X0Y10_竜性_鱗1.Hit = value;
			}
		}

		public bool 竜性_鱗2_表示
		{
			get
			{
				return this.X0Y1_竜性_鱗2.Dra;
			}
			set
			{
				this.X0Y1_竜性_鱗2.Dra = value;
				this.X0Y2_竜性_鱗2.Dra = value;
				this.X0Y3_竜性_鱗2.Dra = value;
				this.X0Y4_竜性_鱗2.Dra = value;
				this.X0Y5_竜性_鱗2.Dra = value;
				this.X0Y6_竜性_鱗2.Dra = value;
				this.X0Y7_竜性_鱗2.Dra = value;
				this.X0Y8_竜性_鱗2.Dra = value;
				this.X0Y10_竜性_鱗2.Dra = value;
				this.X0Y1_竜性_鱗2.Hit = value;
				this.X0Y2_竜性_鱗2.Hit = value;
				this.X0Y3_竜性_鱗2.Hit = value;
				this.X0Y4_竜性_鱗2.Hit = value;
				this.X0Y5_竜性_鱗2.Hit = value;
				this.X0Y6_竜性_鱗2.Hit = value;
				this.X0Y7_竜性_鱗2.Hit = value;
				this.X0Y8_竜性_鱗2.Hit = value;
				this.X0Y10_竜性_鱗2.Hit = value;
			}
		}

		public bool 竜性_鱗3_表示
		{
			get
			{
				return this.X0Y1_竜性_鱗3.Dra;
			}
			set
			{
				this.X0Y1_竜性_鱗3.Dra = value;
				this.X0Y2_竜性_鱗3.Dra = value;
				this.X0Y3_竜性_鱗3.Dra = value;
				this.X0Y4_竜性_鱗3.Dra = value;
				this.X0Y5_竜性_鱗3.Dra = value;
				this.X0Y6_竜性_鱗3.Dra = value;
				this.X0Y7_竜性_鱗3.Dra = value;
				this.X0Y8_竜性_鱗3.Dra = value;
				this.X0Y10_竜性_鱗3.Dra = value;
				this.X0Y1_竜性_鱗3.Hit = value;
				this.X0Y2_竜性_鱗3.Hit = value;
				this.X0Y3_竜性_鱗3.Hit = value;
				this.X0Y4_竜性_鱗3.Hit = value;
				this.X0Y5_竜性_鱗3.Hit = value;
				this.X0Y6_竜性_鱗3.Hit = value;
				this.X0Y7_竜性_鱗3.Hit = value;
				this.X0Y8_竜性_鱗3.Hit = value;
				this.X0Y10_竜性_鱗3.Hit = value;
			}
		}

		public bool 悪タトゥ_五芒星_円1_表示
		{
			get
			{
				return this.X0Y1_悪タトゥ_五芒星_円1.Dra;
			}
			set
			{
				this.X0Y1_悪タトゥ_五芒星_円1.Dra = value;
				this.X0Y2_悪タトゥ_五芒星_円1.Dra = value;
				this.X0Y3_悪タトゥ_五芒星_円1.Dra = value;
				this.X0Y4_悪タトゥ_五芒星_円1.Dra = value;
				this.X0Y5_悪タトゥ_五芒星_円1.Dra = value;
				this.X0Y6_悪タトゥ_五芒星_円1.Dra = value;
				this.X0Y7_悪タトゥ_五芒星_円1.Dra = value;
				this.X0Y8_悪タトゥ_五芒星_円1.Dra = value;
				this.X0Y10_悪タトゥ_五芒星_円1.Dra = value;
				this.X0Y1_悪タトゥ_五芒星_円1.Hit = value;
				this.X0Y2_悪タトゥ_五芒星_円1.Hit = value;
				this.X0Y3_悪タトゥ_五芒星_円1.Hit = value;
				this.X0Y4_悪タトゥ_五芒星_円1.Hit = value;
				this.X0Y5_悪タトゥ_五芒星_円1.Hit = value;
				this.X0Y6_悪タトゥ_五芒星_円1.Hit = value;
				this.X0Y7_悪タトゥ_五芒星_円1.Hit = value;
				this.X0Y8_悪タトゥ_五芒星_円1.Hit = value;
				this.X0Y10_悪タトゥ_五芒星_円1.Hit = value;
			}
		}

		public bool 悪タトゥ_五芒星_円2_表示
		{
			get
			{
				return this.X0Y1_悪タトゥ_五芒星_円2.Dra;
			}
			set
			{
				this.X0Y1_悪タトゥ_五芒星_円2.Dra = value;
				this.X0Y2_悪タトゥ_五芒星_円2.Dra = value;
				this.X0Y3_悪タトゥ_五芒星_円2.Dra = value;
				this.X0Y4_悪タトゥ_五芒星_円2.Dra = value;
				this.X0Y5_悪タトゥ_五芒星_円2.Dra = value;
				this.X0Y6_悪タトゥ_五芒星_円2.Dra = value;
				this.X0Y7_悪タトゥ_五芒星_円2.Dra = value;
				this.X0Y8_悪タトゥ_五芒星_円2.Dra = value;
				this.X0Y10_悪タトゥ_五芒星_円2.Dra = value;
				this.X0Y1_悪タトゥ_五芒星_円2.Hit = value;
				this.X0Y2_悪タトゥ_五芒星_円2.Hit = value;
				this.X0Y3_悪タトゥ_五芒星_円2.Hit = value;
				this.X0Y4_悪タトゥ_五芒星_円2.Hit = value;
				this.X0Y5_悪タトゥ_五芒星_円2.Hit = value;
				this.X0Y6_悪タトゥ_五芒星_円2.Hit = value;
				this.X0Y7_悪タトゥ_五芒星_円2.Hit = value;
				this.X0Y8_悪タトゥ_五芒星_円2.Hit = value;
				this.X0Y10_悪タトゥ_五芒星_円2.Hit = value;
			}
		}

		public bool 悪タトゥ_五芒星_星_表示
		{
			get
			{
				return this.X0Y1_悪タトゥ_五芒星_星.Dra;
			}
			set
			{
				this.X0Y1_悪タトゥ_五芒星_星.Dra = value;
				this.X0Y2_悪タトゥ_五芒星_星.Dra = value;
				this.X0Y3_悪タトゥ_五芒星_星.Dra = value;
				this.X0Y4_悪タトゥ_五芒星_星.Dra = value;
				this.X0Y5_悪タトゥ_五芒星_星.Dra = value;
				this.X0Y6_悪タトゥ_五芒星_星.Dra = value;
				this.X0Y7_悪タトゥ_五芒星_星.Dra = value;
				this.X0Y8_悪タトゥ_五芒星_星.Dra = value;
				this.X0Y10_悪タトゥ_五芒星_星.Dra = value;
				this.X0Y1_悪タトゥ_五芒星_星.Hit = value;
				this.X0Y2_悪タトゥ_五芒星_星.Hit = value;
				this.X0Y3_悪タトゥ_五芒星_星.Hit = value;
				this.X0Y4_悪タトゥ_五芒星_星.Hit = value;
				this.X0Y5_悪タトゥ_五芒星_星.Hit = value;
				this.X0Y6_悪タトゥ_五芒星_星.Hit = value;
				this.X0Y7_悪タトゥ_五芒星_星.Hit = value;
				this.X0Y8_悪タトゥ_五芒星_星.Hit = value;
				this.X0Y10_悪タトゥ_五芒星_星.Hit = value;
			}
		}

		public bool 悪タトゥ_五芒星_五角形_表示
		{
			get
			{
				return this.X0Y1_悪タトゥ_五芒星_五角形.Dra;
			}
			set
			{
				this.X0Y1_悪タトゥ_五芒星_五角形.Dra = value;
				this.X0Y2_悪タトゥ_五芒星_五角形.Dra = value;
				this.X0Y3_悪タトゥ_五芒星_五角形.Dra = value;
				this.X0Y4_悪タトゥ_五芒星_五角形.Dra = value;
				this.X0Y5_悪タトゥ_五芒星_五角形.Dra = value;
				this.X0Y6_悪タトゥ_五芒星_五角形.Dra = value;
				this.X0Y7_悪タトゥ_五芒星_五角形.Dra = value;
				this.X0Y8_悪タトゥ_五芒星_五角形.Dra = value;
				this.X0Y10_悪タトゥ_五芒星_五角形.Dra = value;
				this.X0Y1_悪タトゥ_五芒星_五角形.Hit = value;
				this.X0Y2_悪タトゥ_五芒星_五角形.Hit = value;
				this.X0Y3_悪タトゥ_五芒星_五角形.Hit = value;
				this.X0Y4_悪タトゥ_五芒星_五角形.Hit = value;
				this.X0Y5_悪タトゥ_五芒星_五角形.Hit = value;
				this.X0Y6_悪タトゥ_五芒星_五角形.Hit = value;
				this.X0Y7_悪タトゥ_五芒星_五角形.Hit = value;
				this.X0Y8_悪タトゥ_五芒星_五角形.Hit = value;
				this.X0Y10_悪タトゥ_五芒星_五角形.Hit = value;
			}
		}

		public bool グロ\u30FCブ_縁_表示
		{
			get
			{
				return this.グロ\u30FCブ_縁1_表示;
			}
			set
			{
				this.グロ\u30FCブ_縁1_表示 = value;
				this.グロ\u30FCブ_縁2_表示 = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.グロ\u30FCブ_グロ\u30FCブ_表示;
			}
			set
			{
				this.グロ\u30FCブ_グロ\u30FCブ_表示 = value;
				this.グロ\u30FCブ_縁1_表示 = value;
				this.グロ\u30FCブ_縁2_表示 = value;
				this.獣性_獣毛_表示 = value;
				this.手_表示 = value;
				this.獣性_肉球_表示 = value;
				this.人指_人指1_表示 = value;
				this.人指_人指3_表示 = value;
				this.人指_人指2_表示 = value;
				this.人指_水掻_表示 = value;
				this.中指_中指1_表示 = value;
				this.中指_中指3_表示 = value;
				this.中指_中指2_表示 = value;
				this.中指_水掻_表示 = value;
				this.薬指_薬指1_表示 = value;
				this.薬指_薬指3_表示 = value;
				this.薬指_薬指2_表示 = value;
				this.薬指_水掻_表示 = value;
				this.小指_小指1_表示 = value;
				this.小指_小指3_表示 = value;
				this.小指_小指2_表示 = value;
				this.親指_水掻_表示 = value;
				this.親指_親指1_表示 = value;
				this.親指_獣性_肉球_表示 = value;
				this.親指_親指2_表示 = value;
				this.親指_親指3_表示 = value;
				this.竜性_鱗1_表示 = value;
				this.竜性_鱗2_表示 = value;
				this.竜性_鱗3_表示 = value;
				this.悪タトゥ_五芒星_円1_表示 = value;
				this.悪タトゥ_五芒星_円2_表示 = value;
				this.悪タトゥ_五芒星_星_表示 = value;
				this.悪タトゥ_五芒星_五角形_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.グロ\u30FCブ_グロ\u30FCブCD.不透明度;
			}
			set
			{
				this.グロ\u30FCブ_グロ\u30FCブCD.不透明度 = value;
				this.グロ\u30FCブ_縁1CD.不透明度 = value;
				this.グロ\u30FCブ_縁2CD.不透明度 = value;
				this.獣性_獣毛CD.不透明度 = value;
				this.手CD.不透明度 = value;
				this.獣性_肉球CD.不透明度 = value;
				this.人指_人指1CD.不透明度 = value;
				this.人指_人指3CD.不透明度 = value;
				this.人指_人指2CD.不透明度 = value;
				this.人指_水掻CD.不透明度 = value;
				this.中指_中指1CD.不透明度 = value;
				this.中指_中指3CD.不透明度 = value;
				this.中指_中指2CD.不透明度 = value;
				this.中指_水掻CD.不透明度 = value;
				this.薬指_薬指1CD.不透明度 = value;
				this.薬指_薬指3CD.不透明度 = value;
				this.薬指_薬指2CD.不透明度 = value;
				this.薬指_水掻CD.不透明度 = value;
				this.小指_小指1CD.不透明度 = value;
				this.小指_小指3CD.不透明度 = value;
				this.小指_小指2CD.不透明度 = value;
				this.親指_水掻CD.不透明度 = value;
				this.親指_親指1CD.不透明度 = value;
				this.親指_親指2CD.不透明度 = value;
				this.親指_親指3CD.不透明度 = value;
				this.竜性_鱗1CD.不透明度 = value;
				this.竜性_鱗2CD.不透明度 = value;
				this.竜性_鱗3CD.不透明度 = value;
				this.悪タトゥ_五芒星_円1CD.不透明度 = value;
				this.悪タトゥ_五芒星_円2CD.不透明度 = value;
				this.悪タトゥ_五芒星_星CD.不透明度 = value;
				this.悪タトゥ_五芒星_五角形CD.不透明度 = value;
			}
		}

		public double 鋭爪
		{
			set
			{
				double scale = 1.5;
				int num = this.右 ? 1 : 0;
				List<Out> op = this.X0Y0_人指_人指3.OP;
				Out @out = op[(int)((double)(op.Count - num) * 0.5)];
				int num2 = (int)((double)@out.ps.Count * 0.5);
				List<Vector2D> ps = @out.ps;
				int index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y0_人指_人指3.BasePointBase) * scale * value;
				List<Out> op2 = this.X0Y0_中指_中指3.OP;
				@out = op2[(int)((double)(op2.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y0_中指_中指3.BasePointBase) * scale * value;
				List<Out> op3 = this.X0Y0_薬指_薬指3.OP;
				@out = op3[(int)((double)(op3.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y0_薬指_薬指3.BasePointBase) * scale * value;
				List<Out> op4 = this.X0Y0_小指_小指3.OP;
				@out = op4[(int)((double)(op4.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y0_小指_小指3.BasePointBase) * scale * value;
				List<Out> op5 = this.X0Y0_親指_親指3.OP;
				@out = op5[(int)((double)(op5.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y0_親指_親指3.BasePointBase) * scale * 0.65 * value;
				List<Out> op6 = this.X0Y9_人指_人指3.OP;
				@out = op6[(int)((double)(op6.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y9_人指_人指3.BasePointBase) * scale * value;
				List<Out> op7 = this.X0Y9_中指_中指3.OP;
				@out = op7[(int)((double)(op7.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y9_中指_中指3.BasePointBase) * scale * value;
				List<Out> op8 = this.X0Y9_薬指_薬指3.OP;
				@out = op8[(int)((double)(op8.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y9_薬指_薬指3.BasePointBase) * scale * value;
				List<Out> op9 = this.X0Y9_小指_小指3.OP;
				@out = op9[(int)((double)(op9.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y9_小指_小指3.BasePointBase) * scale * value;
				List<Out> op10 = this.X0Y9_親指_親指3.OP;
				@out = op10[(int)((double)(op10.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y9_親指_親指3.BasePointBase) * scale * 0.65 * value;
				num = (this.右 ? 0 : 1);
				List<Out> op11 = this.X0Y1_人指_人指3.OP;
				@out = op11[(int)((double)(op11.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y1_人指_人指3.BasePointBase) * scale * value;
				List<Out> op12 = this.X0Y1_中指_中指3.OP;
				@out = op12[(int)((double)(op12.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y1_中指_中指3.BasePointBase) * scale * value;
				List<Out> op13 = this.X0Y1_薬指_薬指3.OP;
				@out = op13[(int)((double)(op13.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y1_薬指_薬指3.BasePointBase) * scale * value;
				List<Out> op14 = this.X0Y1_小指_小指3.OP;
				@out = op14[(int)((double)(op14.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y1_小指_小指3.BasePointBase) * scale * value;
				List<Out> op15 = this.X0Y1_親指_親指3.OP;
				@out = op15[(int)((double)(op15.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y1_親指_親指3.BasePointBase) * scale * 0.65 * value;
				List<Out> op16 = this.X0Y2_人指_人指3.OP;
				@out = op16[(int)((double)(op16.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y2_人指_人指3.BasePointBase) * scale * value;
				List<Out> op17 = this.X0Y2_中指_中指3.OP;
				@out = op17[(int)((double)(op17.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y2_中指_中指3.BasePointBase) * scale * value;
				List<Out> op18 = this.X0Y2_薬指_薬指3.OP;
				@out = op18[(int)((double)(op18.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y2_薬指_薬指3.BasePointBase) * scale * value;
				List<Out> op19 = this.X0Y2_小指_小指3.OP;
				@out = op19[(int)((double)(op19.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y2_小指_小指3.BasePointBase) * scale * value;
				List<Out> op20 = this.X0Y2_親指_親指3.OP;
				@out = op20[(int)((double)(op20.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y2_親指_親指3.BasePointBase) * scale * 0.65 * value;
				List<Out> op21 = this.X0Y3_人指_人指3.OP;
				@out = op21[(int)((double)(op21.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y3_人指_人指3.BasePointBase) * scale * value;
				List<Out> op22 = this.X0Y3_中指_中指3.OP;
				@out = op22[(int)((double)(op22.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y3_中指_中指3.BasePointBase) * scale * value;
				List<Out> op23 = this.X0Y3_薬指_薬指3.OP;
				@out = op23[(int)((double)(op23.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y3_薬指_薬指3.BasePointBase) * scale * value;
				List<Out> op24 = this.X0Y3_小指_小指3.OP;
				@out = op24[(int)((double)(op24.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y3_小指_小指3.BasePointBase) * scale * value;
				List<Out> op25 = this.X0Y3_親指_親指3.OP;
				@out = op25[(int)((double)(op25.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y3_親指_親指3.BasePointBase) * scale * 0.65 * value;
				List<Out> op26 = this.X0Y4_人指_人指3.OP;
				@out = op26[(int)((double)(op26.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y4_人指_人指3.BasePointBase) * scale * value;
				List<Out> op27 = this.X0Y4_中指_中指3.OP;
				@out = op27[(int)((double)(op27.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y4_中指_中指3.BasePointBase) * scale * value;
				List<Out> op28 = this.X0Y4_薬指_薬指3.OP;
				@out = op28[(int)((double)(op28.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y4_薬指_薬指3.BasePointBase) * scale * value;
				List<Out> op29 = this.X0Y4_小指_小指3.OP;
				@out = op29[(int)((double)(op29.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y4_小指_小指3.BasePointBase) * scale * value;
				List<Out> op30 = this.X0Y4_親指_親指3.OP;
				@out = op30[(int)((double)(op30.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y4_親指_親指3.BasePointBase) * scale * 0.65 * value;
				List<Out> op31 = this.X0Y5_人指_人指3.OP;
				@out = op31[(int)((double)(op31.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y5_人指_人指3.BasePointBase) * scale * value;
				List<Out> op32 = this.X0Y5_中指_中指3.OP;
				@out = op32[(int)((double)(op32.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y5_中指_中指3.BasePointBase) * scale * value;
				List<Out> op33 = this.X0Y5_薬指_薬指3.OP;
				@out = op33[(int)((double)(op33.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y5_薬指_薬指3.BasePointBase) * scale * value;
				List<Out> op34 = this.X0Y5_小指_小指3.OP;
				@out = op34[(int)((double)(op34.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y5_小指_小指3.BasePointBase) * scale * value;
				List<Out> op35 = this.X0Y5_親指_親指3.OP;
				@out = op35[(int)((double)(op35.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y5_親指_親指3.BasePointBase) * scale * 0.65 * value;
				List<Out> op36 = this.X0Y6_人指_人指3.OP;
				@out = op36[(int)((double)(op36.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y6_人指_人指3.BasePointBase) * scale * value;
				List<Out> op37 = this.X0Y6_中指_中指3.OP;
				@out = op37[(int)((double)(op37.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y6_中指_中指3.BasePointBase) * scale * value;
				List<Out> op38 = this.X0Y6_薬指_薬指3.OP;
				@out = op38[(int)((double)(op38.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y6_薬指_薬指3.BasePointBase) * scale * value;
				List<Out> op39 = this.X0Y6_小指_小指3.OP;
				@out = op39[(int)((double)(op39.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y6_小指_小指3.BasePointBase) * scale * value;
				List<Out> op40 = this.X0Y6_親指_親指3.OP;
				@out = op40[(int)((double)(op40.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y6_親指_親指3.BasePointBase) * scale * 0.65 * value;
				List<Out> op41 = this.X0Y7_人指_人指3.OP;
				@out = op41[(int)((double)(op41.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y7_人指_人指3.BasePointBase) * scale * value;
				List<Out> op42 = this.X0Y7_中指_中指3.OP;
				@out = op42[(int)((double)(op42.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y7_中指_中指3.BasePointBase) * scale * value;
				List<Out> op43 = this.X0Y7_薬指_薬指3.OP;
				@out = op43[(int)((double)(op43.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y7_薬指_薬指3.BasePointBase) * scale * value;
				List<Out> op44 = this.X0Y7_小指_小指3.OP;
				@out = op44[(int)((double)(op44.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y7_小指_小指3.BasePointBase) * scale * value;
				List<Out> op45 = this.X0Y7_親指_親指3.OP;
				@out = op45[(int)((double)(op45.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y7_親指_親指3.BasePointBase) * scale * 0.65 * value;
				List<Out> op46 = this.X0Y8_人指_人指3.OP;
				@out = op46[(int)((double)(op46.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y8_人指_人指3.BasePointBase) * scale * value;
				List<Out> op47 = this.X0Y8_中指_中指3.OP;
				@out = op47[(int)((double)(op47.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y8_中指_中指3.BasePointBase) * scale * value;
				List<Out> op48 = this.X0Y8_薬指_薬指3.OP;
				@out = op48[(int)((double)(op48.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y8_薬指_薬指3.BasePointBase) * scale * value;
				List<Out> op49 = this.X0Y8_小指_小指3.OP;
				@out = op49[(int)((double)(op49.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y8_小指_小指3.BasePointBase) * scale * value;
				List<Out> op50 = this.X0Y8_親指_親指3.OP;
				@out = op50[(int)((double)(op50.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y8_親指_親指3.BasePointBase) * scale * 0.65 * value;
				List<Out> op51 = this.X0Y10_人指_人指3.OP;
				@out = op51[(int)((double)(op51.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y10_人指_人指3.BasePointBase) * scale * value;
				List<Out> op52 = this.X0Y10_中指_中指3.OP;
				@out = op52[(int)((double)(op52.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y10_中指_中指3.BasePointBase) * scale * value;
				List<Out> op53 = this.X0Y10_薬指_薬指3.OP;
				@out = op53[(int)((double)(op53.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y10_薬指_薬指3.BasePointBase) * scale * value;
				List<Out> op54 = this.X0Y10_小指_小指3.OP;
				@out = op54[(int)((double)(op54.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y10_小指_小指3.BasePointBase) * scale * value;
				List<Out> op55 = this.X0Y10_親指_親指3.OP;
				@out = op55[(int)((double)(op55.Count - num) * 0.5)];
				num2 = (int)((double)@out.ps.Count * 0.5);
				ps = @out.ps;
				index = num2;
				ps[index] += (@out.ps[num2] - this.X0Y10_親指_親指3.BasePointBase) * scale * 0.65 * value;
			}
		}

		public void 虫性()
		{
			this.X0Y0_手.OP[this.右 ? 6 : 0].Outline = true;
			this.X0Y0_人指_人指2.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y0_中指_中指2.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y0_薬指_薬指2.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y0_小指_小指2.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y0_親指_親指1.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y0_親指_親指2.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y0_親指_親指3.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y1_手.OP[this.右 ? 0 : 10].Outline = true;
			this.X0Y1_人指_人指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y1_人指_人指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y1_人指_人指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y1_人指_人指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y1_中指_中指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y1_中指_中指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y1_中指_中指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y1_中指_中指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y1_薬指_薬指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y1_薬指_薬指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y1_薬指_薬指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y1_薬指_薬指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y1_小指_小指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y1_小指_小指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y1_小指_小指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y1_小指_小指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y1_親指_親指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y1_親指_親指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y1_親指_親指2.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y1_親指_親指2.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y1_親指_親指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y2_手.OP[this.右 ? 0 : 10].Outline = true;
			this.X0Y2_人指_人指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y2_人指_人指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y2_人指_人指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y2_人指_人指2.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y2_人指_人指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y2_人指_人指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y2_中指_中指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y2_中指_中指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y2_中指_中指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y2_中指_中指2.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y2_中指_中指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y2_中指_中指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y2_薬指_薬指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y2_薬指_薬指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y2_薬指_薬指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y2_薬指_薬指2.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y2_薬指_薬指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y2_薬指_薬指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y2_小指_小指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y2_小指_小指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y2_小指_小指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y2_小指_小指2.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y2_小指_小指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y2_小指_小指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y2_親指_親指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y2_親指_親指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y2_親指_親指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y2_親指_親指2.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y2_親指_親指2.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y2_親指_親指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y3_手.OP[this.右 ? 0 : 10].Outline = true;
			this.X0Y3_人指_人指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y3_人指_人指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y3_人指_人指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y3_人指_人指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y3_中指_中指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y3_中指_中指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y3_中指_中指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y3_中指_中指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y3_薬指_薬指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y3_薬指_薬指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y3_薬指_薬指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y3_薬指_薬指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y3_小指_小指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y3_小指_小指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y3_小指_小指2.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y3_小指_小指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y3_親指_親指1.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y3_親指_親指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y3_親指_親指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y4_手.OP[this.右 ? 0 : 10].Outline = true;
			this.X0Y4_人指_人指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y4_人指_人指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y4_人指_人指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y4_人指_人指2.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y4_人指_人指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y4_人指_人指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y4_中指_中指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y4_中指_中指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y4_中指_中指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y4_中指_中指2.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y4_中指_中指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y4_中指_中指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y4_薬指_薬指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y4_薬指_薬指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y4_薬指_薬指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y4_薬指_薬指2.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y4_薬指_薬指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y4_薬指_薬指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y4_小指_小指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y4_小指_小指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y4_小指_小指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y4_小指_小指2.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y4_小指_小指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y4_小指_小指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y4_親指_親指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y4_親指_親指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y4_親指_親指2.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y4_親指_親指2.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y4_親指_親指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y5_手.OP[this.右 ? 0 : 10].Outline = true;
			this.X0Y5_人指_人指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y5_人指_人指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y5_人指_人指2.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y5_人指_人指2.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y5_人指_人指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y5_中指_中指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y5_中指_中指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y5_中指_中指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y5_中指_中指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y5_薬指_薬指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y5_薬指_薬指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y5_薬指_薬指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y5_薬指_薬指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y5_小指_小指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y5_小指_小指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y5_小指_小指2.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y5_小指_小指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y5_親指_親指1.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y5_親指_親指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y5_親指_親指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y6_手.OP[this.右 ? 0 : 10].Outline = true;
			this.X0Y6_手.OP[this.右 ? 10 : 0].Outline = true;
			this.X0Y6_人指_人指1.OP[this.右 ? 4 : 0].Outline = true;
			this.X0Y6_人指_人指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y6_人指_人指2.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y6_人指_人指2.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y6_人指_人指3.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y6_中指_中指1.OP[this.右 ? 4 : 0].Outline = true;
			this.X0Y6_中指_中指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y6_中指_中指2.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y6_中指_中指3.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y6_薬指_薬指1.OP[this.右 ? 4 : 0].Outline = true;
			this.X0Y6_薬指_薬指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y6_薬指_薬指2.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y6_薬指_薬指3.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y6_小指_小指1.OP[this.右 ? 4 : 0].Outline = true;
			this.X0Y6_小指_小指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y6_小指_小指2.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y6_小指_小指2.OP[this.右 ? 1 : 2].Outline = true;
			this.X0Y6_親指_親指1.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y6_親指_親指1.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y6_親指_親指2.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y6_親指_親指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y7_手.OP[this.右 ? 0 : 6].Outline = true;
			this.X0Y7_人指_人指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y7_人指_人指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y7_人指_人指2.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y7_人指_人指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y7_人指_人指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y7_中指_中指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y7_中指_中指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y7_中指_中指2.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y7_中指_中指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y7_中指_中指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y7_薬指_薬指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y7_薬指_薬指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y7_薬指_薬指2.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y7_薬指_薬指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y7_薬指_薬指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y7_小指_小指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y7_小指_小指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y7_小指_小指2.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y7_小指_小指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y7_小指_小指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y7_親指_親指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y7_親指_親指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y7_親指_親指2.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y7_親指_親指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y8_手.OP[this.右 ? 0 : 10].Outline = true;
			this.X0Y8_人指_人指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y8_人指_人指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y8_人指_人指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y8_人指_人指2.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y8_人指_人指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y8_人指_人指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y8_中指_中指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y8_中指_中指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y8_中指_中指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y8_中指_中指2.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y8_中指_中指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y8_中指_中指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y8_薬指_薬指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y8_薬指_薬指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y8_薬指_薬指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y8_薬指_薬指2.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y8_薬指_薬指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y8_薬指_薬指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y8_小指_小指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y8_小指_小指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y8_小指_小指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y8_小指_小指2.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y8_小指_小指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y8_小指_小指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y8_親指_親指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y8_親指_親指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y8_親指_親指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y8_親指_親指2.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y8_親指_親指2.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y8_親指_親指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y9_手.OP[this.右 ? 0 : 6].Outline = true;
			this.X0Y9_人指_人指1.OP[this.右 ? 1 : 2].Outline = true;
			this.X0Y9_人指_人指2.OP[this.右 ? 1 : 2].Outline = true;
			this.X0Y9_中指_中指1.OP[this.右 ? 1 : 2].Outline = true;
			this.X0Y9_中指_中指2.OP[this.右 ? 1 : 2].Outline = true;
			this.X0Y9_薬指_薬指2.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y9_小指_小指2.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y9_親指_親指1.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y9_親指_親指2.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y9_親指_親指3.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y10_手.OP[this.右 ? 0 : 10].Outline = true;
			this.X0Y10_人指_人指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y10_人指_人指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y10_人指_人指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y10_人指_人指2.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y10_人指_人指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y10_人指_人指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y10_中指_中指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y10_中指_中指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y10_中指_中指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y10_中指_中指2.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y10_中指_中指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y10_中指_中指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y10_薬指_薬指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y10_薬指_薬指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y10_薬指_薬指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y10_薬指_薬指2.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y10_薬指_薬指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y10_薬指_薬指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y10_小指_小指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y10_小指_小指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y10_小指_小指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y10_小指_小指2.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y10_小指_小指2.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y10_小指_小指3.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y10_親指_親指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y10_親指_親指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y10_親指_親指2.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y10_親指_親指2.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y10_親指_親指3.OP[this.右 ? 0 : 3].Outline = true;
		}

		public void 虫手()
		{
			this.X0Y0_人指_人指1.SizeBase *= 1.5;
			this.X0Y0_人指_人指3.SizeBase *= 1.5;
			this.X0Y0_人指_人指2.SizeBase *= 1.5;
			this.X0Y0_小指_小指1.SizeBase *= 1.5;
			this.X0Y0_小指_小指3.SizeBase *= 1.5;
			this.X0Y0_小指_小指2.SizeBase *= 1.5;
			this.X0Y0_親指_親指1.SizeBase *= 1.5;
			this.X0Y0_親指_親指2.SizeBase *= 1.5;
			this.X0Y0_親指_親指3.SizeBase *= 1.5;
			this.X0Y1_人指_人指1.SizeBase *= 1.5;
			this.X0Y1_人指_人指3.SizeBase *= 1.5;
			this.X0Y1_人指_人指2.SizeBase *= 1.5;
			this.X0Y1_小指_小指1.SizeBase *= 1.5;
			this.X0Y1_小指_小指3.SizeBase *= 1.5;
			this.X0Y1_小指_小指2.SizeBase *= 1.5;
			this.X0Y1_親指_親指1.SizeBase *= 1.5;
			this.X0Y1_親指_親指2.SizeBase *= 1.5;
			this.X0Y1_親指_親指3.SizeBase *= 1.5;
			this.X0Y2_人指_人指1.SizeBase *= 1.5;
			this.X0Y2_人指_人指3.SizeBase *= 1.5;
			this.X0Y2_人指_人指2.SizeBase *= 1.5;
			this.X0Y2_小指_小指1.SizeBase *= 1.5;
			this.X0Y2_小指_小指3.SizeBase *= 1.5;
			this.X0Y2_小指_小指2.SizeBase *= 1.5;
			this.X0Y2_親指_親指1.SizeBase *= 1.5;
			this.X0Y2_親指_親指2.SizeBase *= 1.5;
			this.X0Y2_親指_親指3.SizeBase *= 1.5;
			this.X0Y3_人指_人指1.SizeBase *= 1.5;
			this.X0Y3_人指_人指3.SizeBase *= 1.5;
			this.X0Y3_人指_人指2.SizeBase *= 1.5;
			this.X0Y3_小指_小指1.SizeBase *= 1.5;
			this.X0Y3_小指_小指3.SizeBase *= 1.5;
			this.X0Y3_小指_小指2.SizeBase *= 1.5;
			this.X0Y3_親指_親指1.SizeBase *= 1.5;
			this.X0Y3_親指_親指2.SizeBase *= 1.5;
			this.X0Y3_親指_親指3.SizeBase *= 1.5;
			this.X0Y4_人指_人指1.SizeBase *= 1.5;
			this.X0Y4_人指_人指3.SizeBase *= 1.5;
			this.X0Y4_人指_人指2.SizeBase *= 1.5;
			this.X0Y4_小指_小指1.SizeBase *= 1.5;
			this.X0Y4_小指_小指3.SizeBase *= 1.5;
			this.X0Y4_小指_小指2.SizeBase *= 1.5;
			this.X0Y4_親指_親指1.SizeBase *= 1.5;
			this.X0Y4_親指_親指2.SizeBase *= 1.5;
			this.X0Y4_親指_親指3.SizeBase *= 1.5;
			this.X0Y5_人指_人指1.SizeBase *= 1.5;
			this.X0Y5_人指_人指3.SizeBase *= 1.5;
			this.X0Y5_人指_人指2.SizeBase *= 1.5;
			this.X0Y5_小指_小指1.SizeBase *= 1.5;
			this.X0Y5_小指_小指3.SizeBase *= 1.5;
			this.X0Y5_小指_小指2.SizeBase *= 1.5;
			this.X0Y5_親指_親指1.SizeBase *= 1.5;
			this.X0Y5_親指_親指2.SizeBase *= 1.5;
			this.X0Y5_親指_親指3.SizeBase *= 1.5;
			this.X0Y6_人指_人指1.SizeBase *= 1.5;
			this.X0Y6_人指_人指3.SizeBase *= 1.5;
			this.X0Y6_人指_人指2.SizeBase *= 1.5;
			this.X0Y6_小指_小指1.SizeBase *= 1.5;
			this.X0Y6_小指_小指3.SizeBase *= 1.5;
			this.X0Y6_小指_小指2.SizeBase *= 1.5;
			this.X0Y6_親指_親指1.SizeBase *= 1.5;
			this.X0Y6_親指_親指2.SizeBase *= 1.5;
			this.X0Y6_親指_親指3.SizeBase *= 1.5;
			this.X0Y7_人指_人指1.SizeBase *= 1.5;
			this.X0Y7_人指_人指3.SizeBase *= 1.5;
			this.X0Y7_人指_人指2.SizeBase *= 1.5;
			this.X0Y7_小指_小指1.SizeBase *= 1.5;
			this.X0Y7_小指_小指3.SizeBase *= 1.5;
			this.X0Y7_小指_小指2.SizeBase *= 1.5;
			this.X0Y7_親指_親指1.SizeBase *= 1.5;
			this.X0Y7_親指_親指2.SizeBase *= 1.5;
			this.X0Y7_親指_親指3.SizeBase *= 1.5;
			this.X0Y8_人指_人指1.SizeBase *= 1.5;
			this.X0Y8_人指_人指3.SizeBase *= 1.5;
			this.X0Y8_人指_人指2.SizeBase *= 1.5;
			this.X0Y8_小指_小指1.SizeBase *= 1.5;
			this.X0Y8_小指_小指3.SizeBase *= 1.5;
			this.X0Y8_小指_小指2.SizeBase *= 1.5;
			this.X0Y8_親指_親指1.SizeBase *= 1.5;
			this.X0Y8_親指_親指2.SizeBase *= 1.5;
			this.X0Y8_親指_親指3.SizeBase *= 1.5;
			this.X0Y9_人指_人指1.SizeBase *= 1.5;
			this.X0Y9_人指_人指3.SizeBase *= 1.5;
			this.X0Y9_人指_人指2.SizeBase *= 1.5;
			this.X0Y9_小指_小指1.SizeBase *= 1.5;
			this.X0Y9_小指_小指3.SizeBase *= 1.5;
			this.X0Y9_小指_小指2.SizeBase *= 1.5;
			this.X0Y9_親指_親指1.SizeBase *= 1.5;
			this.X0Y9_親指_親指2.SizeBase *= 1.5;
			this.X0Y9_親指_親指3.SizeBase *= 1.5;
			this.X0Y10_人指_人指1.SizeBase *= 1.5;
			this.X0Y10_人指_人指3.SizeBase *= 1.5;
			this.X0Y10_人指_人指2.SizeBase *= 1.5;
			this.X0Y10_小指_小指1.SizeBase *= 1.5;
			this.X0Y10_小指_小指3.SizeBase *= 1.5;
			this.X0Y10_小指_小指2.SizeBase *= 1.5;
			this.X0Y10_親指_親指1.SizeBase *= 1.5;
			this.X0Y10_親指_親指2.SizeBase *= 1.5;
			this.X0Y10_親指_親指3.SizeBase *= 1.5;
			this.中指_中指1_表示 = false;
			this.中指_中指3_表示 = false;
			this.中指_中指2_表示 = false;
			this.薬指_薬指1_表示 = false;
			this.薬指_薬指3_表示 = false;
			this.薬指_薬指2_表示 = false;
			this.親指_親指1_表示 = false;
			this.親指_親指3_表示 = false;
			this.親指_親指2_表示 = false;
		}

		public void 宇手()
		{
			this.X0Y0_人指_人指1.SizeBase *= 1.5;
			this.X0Y0_人指_人指3.SizeBase *= 1.5;
			this.X0Y0_人指_人指2.SizeBase *= 1.5;
			this.X0Y0_小指_小指1.SizeBase *= 1.5;
			this.X0Y0_小指_小指3.SizeBase *= 1.5;
			this.X0Y0_小指_小指2.SizeBase *= 1.5;
			this.X0Y0_親指_親指2.SizeBase *= 1.5;
			this.X0Y0_親指_親指3.SizeBase *= 1.5;
			this.X0Y1_人指_人指1.SizeBase *= 1.5;
			this.X0Y1_人指_人指3.SizeBase *= 1.5;
			this.X0Y1_人指_人指2.SizeBase *= 1.5;
			this.X0Y1_小指_小指1.SizeBase *= 1.5;
			this.X0Y1_小指_小指3.SizeBase *= 1.5;
			this.X0Y1_小指_小指2.SizeBase *= 1.5;
			this.X0Y1_親指_親指2.SizeBase *= 1.5;
			this.X0Y1_親指_親指3.SizeBase *= 1.5;
			this.X0Y2_人指_人指1.SizeBase *= 1.5;
			this.X0Y2_人指_人指3.SizeBase *= 1.5;
			this.X0Y2_人指_人指2.SizeBase *= 1.5;
			this.X0Y2_小指_小指1.SizeBase *= 1.5;
			this.X0Y2_小指_小指3.SizeBase *= 1.5;
			this.X0Y2_小指_小指2.SizeBase *= 1.5;
			this.X0Y2_親指_親指2.SizeBase *= 1.5;
			this.X0Y2_親指_親指3.SizeBase *= 1.5;
			this.X0Y3_人指_人指1.SizeBase *= 1.5;
			this.X0Y3_人指_人指3.SizeBase *= 1.5;
			this.X0Y3_人指_人指2.SizeBase *= 1.5;
			this.X0Y3_小指_小指1.SizeBase *= 1.5;
			this.X0Y3_小指_小指3.SizeBase *= 1.5;
			this.X0Y3_小指_小指2.SizeBase *= 1.5;
			this.X0Y3_親指_親指2.SizeBase *= 1.5;
			this.X0Y3_親指_親指3.SizeBase *= 1.5;
			this.X0Y4_人指_人指1.SizeBase *= 1.5;
			this.X0Y4_人指_人指3.SizeBase *= 1.5;
			this.X0Y4_人指_人指2.SizeBase *= 1.5;
			this.X0Y4_小指_小指1.SizeBase *= 1.5;
			this.X0Y4_小指_小指3.SizeBase *= 1.5;
			this.X0Y4_小指_小指2.SizeBase *= 1.5;
			this.X0Y4_親指_親指2.SizeBase *= 1.5;
			this.X0Y4_親指_親指3.SizeBase *= 1.5;
			this.X0Y5_人指_人指1.SizeBase *= 1.5;
			this.X0Y5_人指_人指3.SizeBase *= 1.5;
			this.X0Y5_人指_人指2.SizeBase *= 1.5;
			this.X0Y5_小指_小指1.SizeBase *= 1.5;
			this.X0Y5_小指_小指3.SizeBase *= 1.5;
			this.X0Y5_小指_小指2.SizeBase *= 1.5;
			this.X0Y5_親指_親指2.SizeBase *= 1.5;
			this.X0Y5_親指_親指3.SizeBase *= 1.5;
			this.X0Y6_人指_人指1.SizeBase *= 1.5;
			this.X0Y6_人指_人指3.SizeBase *= 1.5;
			this.X0Y6_人指_人指2.SizeBase *= 1.5;
			this.X0Y6_小指_小指1.SizeBase *= 1.5;
			this.X0Y6_小指_小指3.SizeBase *= 1.5;
			this.X0Y6_小指_小指2.SizeBase *= 1.5;
			this.X0Y6_親指_親指2.SizeBase *= 1.5;
			this.X0Y6_親指_親指3.SizeBase *= 1.5;
			this.X0Y7_人指_人指1.SizeBase *= 1.5;
			this.X0Y7_人指_人指3.SizeBase *= 1.5;
			this.X0Y7_人指_人指2.SizeBase *= 1.5;
			this.X0Y7_小指_小指1.SizeBase *= 1.5;
			this.X0Y7_小指_小指3.SizeBase *= 1.5;
			this.X0Y7_小指_小指2.SizeBase *= 1.5;
			this.X0Y7_親指_親指2.SizeBase *= 1.5;
			this.X0Y7_親指_親指3.SizeBase *= 1.5;
			this.X0Y8_人指_人指1.SizeBase *= 1.5;
			this.X0Y8_人指_人指3.SizeBase *= 1.5;
			this.X0Y8_人指_人指2.SizeBase *= 1.5;
			this.X0Y8_小指_小指1.SizeBase *= 1.5;
			this.X0Y8_小指_小指3.SizeBase *= 1.5;
			this.X0Y8_小指_小指2.SizeBase *= 1.5;
			this.X0Y8_親指_親指2.SizeBase *= 1.5;
			this.X0Y8_親指_親指3.SizeBase *= 1.5;
			this.X0Y9_人指_人指1.SizeBase *= 1.5;
			this.X0Y9_人指_人指3.SizeBase *= 1.5;
			this.X0Y9_人指_人指2.SizeBase *= 1.5;
			this.X0Y9_小指_小指1.SizeBase *= 1.5;
			this.X0Y9_小指_小指3.SizeBase *= 1.5;
			this.X0Y9_小指_小指2.SizeBase *= 1.5;
			this.X0Y9_親指_親指2.SizeBase *= 1.5;
			this.X0Y9_親指_親指3.SizeBase *= 1.5;
			this.X0Y10_人指_人指1.SizeBase *= 1.5;
			this.X0Y10_人指_人指3.SizeBase *= 1.5;
			this.X0Y10_人指_人指2.SizeBase *= 1.5;
			this.X0Y10_小指_小指1.SizeBase *= 1.5;
			this.X0Y10_小指_小指3.SizeBase *= 1.5;
			this.X0Y10_小指_小指2.SizeBase *= 1.5;
			this.X0Y10_親指_親指2.SizeBase *= 1.5;
			this.X0Y10_親指_親指3.SizeBase *= 1.5;
			this.中指_中指1_表示 = false;
			this.中指_中指3_表示 = false;
			this.中指_中指2_表示 = false;
			this.薬指_薬指1_表示 = false;
			this.薬指_薬指3_表示 = false;
			this.薬指_薬指2_表示 = false;
		}

		public void 獣性()
		{
			foreach (Par par in this.本体.EnumAllPar())
			{
				par.OP.ExpansionXY(par.OP.GetCenter(), 0.001);
				par.SizeBase *= 1.2;
			}
		}

		public void 竜性()
		{
			foreach (Par par in this.本体.EnumAllPar())
			{
				if (par.Tag.Contains("鱗"))
				{
					par.SizeBase *= 1.1;
				}
				else
				{
					par.OP.ExpansionXY(par.OP.GetCenter(), 0.001);
					par.JP.ExpansionXY(par.OP.GetCenter(), 0.001);
				}
			}
			this.X0Y0_親指_親指1.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y1_親指_親指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y1_親指_親指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y2_親指_親指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y2_親指_親指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y2_親指_親指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y3_親指_親指1.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y4_親指_親指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y4_親指_親指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y5_親指_親指1.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y6_親指_親指1.OP[this.右 ? 2 : 1].Outline = true;
			this.X0Y6_親指_親指1.OP[this.右 ? 0 : 3].Outline = true;
			this.X0Y7_親指_親指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y7_親指_親指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y8_親指_親指1.OP[this.右 ? 3 : 1].Outline = true;
			this.X0Y8_親指_親指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y8_親指_親指1.OP[this.右 ? 0 : 4].Outline = true;
			this.X0Y9_親指_親指1.OP[this.右 ? 3 : 0].Outline = true;
			this.X0Y10_親指_親指1.OP[this.右 ? 2 : 2].Outline = true;
			this.X0Y10_親指_親指1.OP[this.右 ? 0 : 4].Outline = true;
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
				this.グロ\u30FCブ_縁1_表示 = value;
				this.グロ\u30FCブ_縁2_表示 = value;
			}
		}

		public override bool Is布(Par p)
		{
			return p == this.X0Y0_グロ\u30FCブ_グロ\u30FCブ || p == this.X0Y0_グロ\u30FCブ_縁1 || p == this.X0Y0_グロ\u30FCブ_縁2 || p == this.X0Y1_グロ\u30FCブ_グロ\u30FCブ || p == this.X0Y1_グロ\u30FCブ_縁1 || p == this.X0Y1_グロ\u30FCブ_縁2 || p == this.X0Y2_グロ\u30FCブ_グロ\u30FCブ || p == this.X0Y2_グロ\u30FCブ_縁1 || p == this.X0Y2_グロ\u30FCブ_縁2 || p == this.X0Y3_グロ\u30FCブ_グロ\u30FCブ || p == this.X0Y3_グロ\u30FCブ_縁1 || p == this.X0Y3_グロ\u30FCブ_縁2 || p == this.X0Y4_グロ\u30FCブ_グロ\u30FCブ || p == this.X0Y4_グロ\u30FCブ_縁1 || p == this.X0Y4_グロ\u30FCブ_縁2 || p == this.X0Y5_グロ\u30FCブ_グロ\u30FCブ || p == this.X0Y5_グロ\u30FCブ_縁1 || p == this.X0Y5_グロ\u30FCブ_縁2 || p == this.X0Y6_グロ\u30FCブ_グロ\u30FCブ || p == this.X0Y6_グロ\u30FCブ_縁1 || p == this.X0Y6_グロ\u30FCブ_縁2 || p == this.X0Y7_グロ\u30FCブ_グロ\u30FCブ || p == this.X0Y7_グロ\u30FCブ_縁1 || p == this.X0Y7_グロ\u30FCブ_縁2 || p == this.X0Y8_グロ\u30FCブ_グロ\u30FCブ || p == this.X0Y8_グロ\u30FCブ_縁1 || p == this.X0Y8_グロ\u30FCブ_縁2 || p == this.X0Y9_グロ\u30FCブ_グロ\u30FCブ || p == this.X0Y9_グロ\u30FCブ_縁1 || p == this.X0Y9_グロ\u30FCブ_縁2 || p == this.X0Y10_グロ\u30FCブ_グロ\u30FCブ || p == this.X0Y10_グロ\u30FCブ_縁1 || p == this.X0Y10_グロ\u30FCブ_縁2;
		}

		public override void 色更新()
		{
			switch (this.本体.IndexY)
			{
			case 0:
				this.X0Y0_グロ\u30FCブ_グロ\u30FCブCP.Update();
				this.X0Y0_グロ\u30FCブ_縁1CP.Update();
				this.X0Y0_グロ\u30FCブ_縁2CP.Update();
				this.X0Y0_獣性_獣毛CP.Update();
				this.X0Y0_手CP.Update();
				this.X0Y0_獣性_肉球CP.Update();
				this.X0Y0_人指_人指1CP.Update();
				this.X0Y0_人指_人指3CP.Update();
				this.X0Y0_人指_人指2CP.Update();
				this.X0Y0_人指_水掻CP.Update();
				this.X0Y0_中指_中指1CP.Update();
				this.X0Y0_中指_中指3CP.Update();
				this.X0Y0_中指_中指2CP.Update();
				this.X0Y0_中指_水掻CP.Update();
				this.X0Y0_薬指_薬指1CP.Update();
				this.X0Y0_薬指_薬指3CP.Update();
				this.X0Y0_薬指_薬指2CP.Update();
				this.X0Y0_薬指_水掻CP.Update();
				this.X0Y0_小指_小指1CP.Update();
				this.X0Y0_小指_小指3CP.Update();
				this.X0Y0_小指_小指2CP.Update();
				this.X0Y0_親指_水掻CP.Update();
				this.X0Y0_親指_親指1CP.Update();
				this.X0Y0_親指_獣性_肉球CP.Update();
				this.X0Y0_親指_親指2CP.Update();
				this.X0Y0_親指_親指3CP.Update();
				return;
			case 1:
				this.X0Y1_親指_親指3CP.Update();
				this.X0Y1_親指_親指2CP.Update();
				this.X0Y1_親指_親指1CP.Update();
				this.X0Y1_親指_水掻CP.Update();
				this.X0Y1_人指_人指3CP.Update();
				this.X0Y1_人指_人指2CP.Update();
				this.X0Y1_人指_人指1CP.Update();
				this.X0Y1_人指_水掻CP.Update();
				this.X0Y1_中指_中指3CP.Update();
				this.X0Y1_中指_中指2CP.Update();
				this.X0Y1_中指_中指1CP.Update();
				this.X0Y1_中指_水掻CP.Update();
				this.X0Y1_薬指_薬指3CP.Update();
				this.X0Y1_薬指_薬指2CP.Update();
				this.X0Y1_薬指_薬指1CP.Update();
				this.X0Y1_薬指_水掻CP.Update();
				this.X0Y1_小指_小指3CP.Update();
				this.X0Y1_小指_小指2CP.Update();
				this.X0Y1_小指_小指1CP.Update();
				this.X0Y1_手CP.Update();
				this.X0Y1_獣性_獣毛CP.Update();
				this.X0Y1_竜性_鱗1CP.Update();
				this.X0Y1_竜性_鱗2CP.Update();
				this.X0Y1_竜性_鱗3CP.Update();
				this.X0Y1_悪タトゥ_五芒星_円1CP.Update();
				this.X0Y1_悪タトゥ_五芒星_円2CP.Update();
				this.X0Y1_悪タトゥ_五芒星_星CP.Update();
				this.X0Y1_悪タトゥ_五芒星_五角形CP.Update();
				this.X0Y1_グロ\u30FCブ_グロ\u30FCブCP.Update();
				this.X0Y1_グロ\u30FCブ_縁1CP.Update();
				this.X0Y1_グロ\u30FCブ_縁2CP.Update();
				return;
			case 2:
				this.X0Y2_親指_親指3CP.Update();
				this.X0Y2_親指_親指2CP.Update();
				this.X0Y2_親指_親指1CP.Update();
				this.X0Y2_親指_水掻CP.Update();
				this.X0Y2_人指_人指3CP.Update();
				this.X0Y2_人指_人指2CP.Update();
				this.X0Y2_人指_人指1CP.Update();
				this.X0Y2_人指_水掻CP.Update();
				this.X0Y2_中指_中指3CP.Update();
				this.X0Y2_中指_中指2CP.Update();
				this.X0Y2_中指_中指1CP.Update();
				this.X0Y2_中指_水掻CP.Update();
				this.X0Y2_薬指_薬指3CP.Update();
				this.X0Y2_薬指_薬指2CP.Update();
				this.X0Y2_薬指_薬指1CP.Update();
				this.X0Y2_薬指_水掻CP.Update();
				this.X0Y2_小指_小指3CP.Update();
				this.X0Y2_小指_小指2CP.Update();
				this.X0Y2_小指_小指1CP.Update();
				this.X0Y2_手CP.Update();
				this.X0Y2_獣性_獣毛CP.Update();
				this.X0Y2_竜性_鱗1CP.Update();
				this.X0Y2_竜性_鱗2CP.Update();
				this.X0Y2_竜性_鱗3CP.Update();
				this.X0Y2_悪タトゥ_五芒星_円1CP.Update();
				this.X0Y2_悪タトゥ_五芒星_円2CP.Update();
				this.X0Y2_悪タトゥ_五芒星_星CP.Update();
				this.X0Y2_悪タトゥ_五芒星_五角形CP.Update();
				this.X0Y2_グロ\u30FCブ_グロ\u30FCブCP.Update();
				this.X0Y2_グロ\u30FCブ_縁1CP.Update();
				this.X0Y2_グロ\u30FCブ_縁2CP.Update();
				return;
			case 3:
				this.X0Y3_親指_親指1CP.Update();
				this.X0Y3_親指_親指2CP.Update();
				this.X0Y3_親指_親指3CP.Update();
				this.X0Y3_親指_水掻CP.Update();
				this.X0Y3_人指_人指3CP.Update();
				this.X0Y3_人指_人指2CP.Update();
				this.X0Y3_人指_人指1CP.Update();
				this.X0Y3_人指_水掻CP.Update();
				this.X0Y3_中指_中指3CP.Update();
				this.X0Y3_中指_中指2CP.Update();
				this.X0Y3_中指_中指1CP.Update();
				this.X0Y3_中指_水掻CP.Update();
				this.X0Y3_薬指_薬指3CP.Update();
				this.X0Y3_薬指_薬指2CP.Update();
				this.X0Y3_薬指_薬指1CP.Update();
				this.X0Y3_薬指_水掻CP.Update();
				this.X0Y3_小指_小指3CP.Update();
				this.X0Y3_小指_小指2CP.Update();
				this.X0Y3_小指_小指1CP.Update();
				this.X0Y3_手CP.Update();
				this.X0Y3_獣性_獣毛CP.Update();
				this.X0Y3_竜性_鱗1CP.Update();
				this.X0Y3_竜性_鱗2CP.Update();
				this.X0Y3_竜性_鱗3CP.Update();
				this.X0Y3_悪タトゥ_五芒星_円1CP.Update();
				this.X0Y3_悪タトゥ_五芒星_円2CP.Update();
				this.X0Y3_悪タトゥ_五芒星_星CP.Update();
				this.X0Y3_悪タトゥ_五芒星_五角形CP.Update();
				this.X0Y3_グロ\u30FCブ_グロ\u30FCブCP.Update();
				this.X0Y3_グロ\u30FCブ_縁1CP.Update();
				this.X0Y3_グロ\u30FCブ_縁2CP.Update();
				return;
			case 4:
				this.X0Y4_親指_親指3CP.Update();
				this.X0Y4_親指_親指2CP.Update();
				this.X0Y4_親指_親指1CP.Update();
				this.X0Y4_親指_水掻CP.Update();
				this.X0Y4_人指_人指3CP.Update();
				this.X0Y4_人指_人指2CP.Update();
				this.X0Y4_人指_人指1CP.Update();
				this.X0Y4_人指_水掻CP.Update();
				this.X0Y4_小指_小指3CP.Update();
				this.X0Y4_小指_小指2CP.Update();
				this.X0Y4_小指_小指1CP.Update();
				this.X0Y4_中指_中指3CP.Update();
				this.X0Y4_中指_中指2CP.Update();
				this.X0Y4_中指_中指1CP.Update();
				this.X0Y4_中指_水掻CP.Update();
				this.X0Y4_薬指_薬指3CP.Update();
				this.X0Y4_薬指_薬指2CP.Update();
				this.X0Y4_薬指_薬指1CP.Update();
				this.X0Y4_薬指_水掻CP.Update();
				this.X0Y4_手CP.Update();
				this.X0Y4_獣性_獣毛CP.Update();
				this.X0Y4_竜性_鱗1CP.Update();
				this.X0Y4_竜性_鱗2CP.Update();
				this.X0Y4_竜性_鱗3CP.Update();
				this.X0Y4_悪タトゥ_五芒星_円1CP.Update();
				this.X0Y4_悪タトゥ_五芒星_円2CP.Update();
				this.X0Y4_悪タトゥ_五芒星_星CP.Update();
				this.X0Y4_悪タトゥ_五芒星_五角形CP.Update();
				this.X0Y4_グロ\u30FCブ_グロ\u30FCブCP.Update();
				this.X0Y4_グロ\u30FCブ_縁1CP.Update();
				this.X0Y4_グロ\u30FCブ_縁2CP.Update();
				return;
			case 5:
				this.X0Y5_親指_親指1CP.Update();
				this.X0Y5_親指_親指2CP.Update();
				this.X0Y5_親指_親指3CP.Update();
				this.X0Y5_親指_水掻CP.Update();
				this.X0Y5_人指_人指3CP.Update();
				this.X0Y5_人指_人指2CP.Update();
				this.X0Y5_人指_人指1CP.Update();
				this.X0Y5_人指_水掻CP.Update();
				this.X0Y5_中指_中指3CP.Update();
				this.X0Y5_中指_中指2CP.Update();
				this.X0Y5_中指_中指1CP.Update();
				this.X0Y5_中指_水掻CP.Update();
				this.X0Y5_薬指_薬指3CP.Update();
				this.X0Y5_薬指_薬指2CP.Update();
				this.X0Y5_薬指_薬指1CP.Update();
				this.X0Y5_薬指_水掻CP.Update();
				this.X0Y5_小指_小指3CP.Update();
				this.X0Y5_小指_小指2CP.Update();
				this.X0Y5_小指_小指1CP.Update();
				this.X0Y5_手CP.Update();
				this.X0Y5_獣性_獣毛CP.Update();
				this.X0Y5_竜性_鱗1CP.Update();
				this.X0Y5_竜性_鱗2CP.Update();
				this.X0Y5_竜性_鱗3CP.Update();
				this.X0Y5_悪タトゥ_五芒星_円1CP.Update();
				this.X0Y5_悪タトゥ_五芒星_円2CP.Update();
				this.X0Y5_悪タトゥ_五芒星_星CP.Update();
				this.X0Y5_悪タトゥ_五芒星_五角形CP.Update();
				this.X0Y5_グロ\u30FCブ_グロ\u30FCブCP.Update();
				this.X0Y5_グロ\u30FCブ_縁1CP.Update();
				this.X0Y5_グロ\u30FCブ_縁2CP.Update();
				return;
			case 6:
				this.X0Y6_小指_小指3CP.Update();
				this.X0Y6_小指_小指2CP.Update();
				this.X0Y6_小指_小指1CP.Update();
				this.X0Y6_薬指_水掻CP.Update();
				this.X0Y6_薬指_薬指3CP.Update();
				this.X0Y6_薬指_薬指2CP.Update();
				this.X0Y6_薬指_薬指1CP.Update();
				this.X0Y6_中指_水掻CP.Update();
				this.X0Y6_中指_中指3CP.Update();
				this.X0Y6_中指_中指2CP.Update();
				this.X0Y6_中指_中指1CP.Update();
				this.X0Y6_人指_水掻CP.Update();
				this.X0Y6_人指_人指3CP.Update();
				this.X0Y6_人指_人指2CP.Update();
				this.X0Y6_人指_人指1CP.Update();
				this.X0Y6_親指_親指3CP.Update();
				this.X0Y6_親指_親指2CP.Update();
				this.X0Y6_親指_親指1CP.Update();
				this.X0Y6_親指_水掻CP.Update();
				this.X0Y6_手CP.Update();
				this.X0Y6_獣性_獣毛CP.Update();
				this.X0Y6_竜性_鱗1CP.Update();
				this.X0Y6_竜性_鱗2CP.Update();
				this.X0Y6_竜性_鱗3CP.Update();
				this.X0Y6_悪タトゥ_五芒星_円1CP.Update();
				this.X0Y6_悪タトゥ_五芒星_円2CP.Update();
				this.X0Y6_悪タトゥ_五芒星_星CP.Update();
				this.X0Y6_悪タトゥ_五芒星_五角形CP.Update();
				this.X0Y6_グロ\u30FCブ_グロ\u30FCブCP.Update();
				this.X0Y6_グロ\u30FCブ_縁1CP.Update();
				this.X0Y6_グロ\u30FCブ_縁2CP.Update();
				return;
			case 7:
				this.X0Y7_親指_親指1CP.Update();
				this.X0Y7_親指_親指2CP.Update();
				this.X0Y7_親指_親指3CP.Update();
				this.X0Y7_親指_水掻CP.Update();
				this.X0Y7_手CP.Update();
				this.X0Y7_人指_人指3CP.Update();
				this.X0Y7_人指_人指2CP.Update();
				this.X0Y7_人指_人指1CP.Update();
				this.X0Y7_人指_水掻CP.Update();
				this.X0Y7_中指_中指3CP.Update();
				this.X0Y7_中指_中指2CP.Update();
				this.X0Y7_中指_中指1CP.Update();
				this.X0Y7_中指_水掻CP.Update();
				this.X0Y7_小指_小指3CP.Update();
				this.X0Y7_小指_小指2CP.Update();
				this.X0Y7_小指_小指1CP.Update();
				this.X0Y7_薬指_薬指3CP.Update();
				this.X0Y7_薬指_薬指2CP.Update();
				this.X0Y7_薬指_薬指1CP.Update();
				this.X0Y7_薬指_水掻CP.Update();
				this.X0Y7_獣性_獣毛CP.Update();
				this.X0Y7_竜性_鱗1CP.Update();
				this.X0Y7_竜性_鱗2CP.Update();
				this.X0Y7_竜性_鱗3CP.Update();
				this.X0Y7_悪タトゥ_五芒星_円1CP.Update();
				this.X0Y7_悪タトゥ_五芒星_円2CP.Update();
				this.X0Y7_悪タトゥ_五芒星_星CP.Update();
				this.X0Y7_悪タトゥ_五芒星_五角形CP.Update();
				this.X0Y7_グロ\u30FCブ_グロ\u30FCブCP.Update();
				this.X0Y7_グロ\u30FCブ_縁1CP.Update();
				this.X0Y7_グロ\u30FCブ_縁2CP.Update();
				return;
			case 8:
				this.X0Y8_親指_親指3CP.Update();
				this.X0Y8_親指_親指2CP.Update();
				this.X0Y8_親指_親指1CP.Update();
				this.X0Y8_親指_水掻CP.Update();
				this.X0Y8_人指_人指3CP.Update();
				this.X0Y8_人指_人指2CP.Update();
				this.X0Y8_人指_人指1CP.Update();
				this.X0Y8_人指_水掻CP.Update();
				this.X0Y8_中指_中指3CP.Update();
				this.X0Y8_中指_中指2CP.Update();
				this.X0Y8_中指_中指1CP.Update();
				this.X0Y8_中指_水掻CP.Update();
				this.X0Y8_薬指_薬指3CP.Update();
				this.X0Y8_薬指_薬指2CP.Update();
				this.X0Y8_薬指_薬指1CP.Update();
				this.X0Y8_薬指_水掻CP.Update();
				this.X0Y8_小指_小指3CP.Update();
				this.X0Y8_小指_小指2CP.Update();
				this.X0Y8_小指_小指1CP.Update();
				this.X0Y8_手CP.Update();
				this.X0Y8_獣性_獣毛CP.Update();
				this.X0Y8_竜性_鱗1CP.Update();
				this.X0Y8_竜性_鱗2CP.Update();
				this.X0Y8_竜性_鱗3CP.Update();
				this.X0Y8_悪タトゥ_五芒星_円1CP.Update();
				this.X0Y8_悪タトゥ_五芒星_円2CP.Update();
				this.X0Y8_悪タトゥ_五芒星_星CP.Update();
				this.X0Y8_悪タトゥ_五芒星_五角形CP.Update();
				this.X0Y8_グロ\u30FCブ_グロ\u30FCブCP.Update();
				this.X0Y8_グロ\u30FCブ_縁1CP.Update();
				this.X0Y8_グロ\u30FCブ_縁2CP.Update();
				return;
			case 9:
				this.X0Y9_グロ\u30FCブ_グロ\u30FCブCP.Update();
				this.X0Y9_グロ\u30FCブ_縁1CP.Update();
				this.X0Y9_グロ\u30FCブ_縁2CP.Update();
				this.X0Y9_獣性_獣毛CP.Update();
				this.X0Y9_手CP.Update();
				this.X0Y9_獣肉球CP.Update();
				this.X0Y9_人指_人指1CP.Update();
				this.X0Y9_人指_人指3CP.Update();
				this.X0Y9_人指_人指2CP.Update();
				this.X0Y9_人指_水掻CP.Update();
				this.X0Y9_中指_中指1CP.Update();
				this.X0Y9_中指_中指3CP.Update();
				this.X0Y9_中指_中指2CP.Update();
				this.X0Y9_中指_水掻CP.Update();
				this.X0Y9_薬指_薬指1CP.Update();
				this.X0Y9_薬指_薬指3CP.Update();
				this.X0Y9_薬指_薬指2CP.Update();
				this.X0Y9_薬指_水掻CP.Update();
				this.X0Y9_小指_小指1CP.Update();
				this.X0Y9_小指_小指3CP.Update();
				this.X0Y9_小指_小指2CP.Update();
				this.X0Y9_親指_水掻CP.Update();
				this.X0Y9_親指_親指1CP.Update();
				this.X0Y9_親指_獣肉球CP.Update();
				this.X0Y9_親指_親指2CP.Update();
				this.X0Y9_親指_親指3CP.Update();
				return;
			default:
				this.X0Y10_親指_親指3CP.Update();
				this.X0Y10_親指_親指2CP.Update();
				this.X0Y10_親指_親指1CP.Update();
				this.X0Y10_親指_水掻CP.Update();
				this.X0Y10_人指_人指3CP.Update();
				this.X0Y10_人指_人指2CP.Update();
				this.X0Y10_人指_人指1CP.Update();
				this.X0Y10_人指_水掻CP.Update();
				this.X0Y10_小指_小指3CP.Update();
				this.X0Y10_小指_小指2CP.Update();
				this.X0Y10_小指_小指1CP.Update();
				this.X0Y10_中指_中指3CP.Update();
				this.X0Y10_中指_中指2CP.Update();
				this.X0Y10_中指_中指1CP.Update();
				this.X0Y10_中指_水掻CP.Update();
				this.X0Y10_薬指_薬指3CP.Update();
				this.X0Y10_薬指_薬指2CP.Update();
				this.X0Y10_薬指_薬指1CP.Update();
				this.X0Y10_薬指_水掻CP.Update();
				this.X0Y10_手CP.Update();
				this.X0Y10_獣性_獣毛CP.Update();
				this.X0Y10_竜性_鱗1CP.Update();
				this.X0Y10_竜性_鱗2CP.Update();
				this.X0Y10_竜性_鱗3CP.Update();
				this.X0Y10_悪タトゥ_五芒星_円1CP.Update();
				this.X0Y10_悪タトゥ_五芒星_円2CP.Update();
				this.X0Y10_悪タトゥ_五芒星_星CP.Update();
				this.X0Y10_悪タトゥ_五芒星_五角形CP.Update();
				this.X0Y10_グロ\u30FCブ_グロ\u30FCブCP.Update();
				this.X0Y10_グロ\u30FCブ_縁1CP.Update();
				this.X0Y10_グロ\u30FCブ_縁2CP.Update();
				return;
			}
		}

		private void 配色(体配色 体配色)
		{
			配色指定 配色指定 = this.配色指定;
			if (配色指定 <= 配色指定.B0)
			{
				if (配色指定 == 配色指定.N0)
				{
					this.配色N0(体配色);
					return;
				}
				if (配色指定 == 配色指定.B0)
				{
					this.配色B0(体配色);
					return;
				}
			}
			else
			{
				if (配色指定 == 配色指定.C0)
				{
					this.配色C0(体配色);
					return;
				}
				if (配色指定 == 配色指定.L0)
				{
					this.配色L0(体配色);
					return;
				}
				if (配色指定 == 配色指定.S0)
				{
					this.配色S0(体配色);
					return;
				}
			}
			this.配色N0(体配色);
		}

		private void 配色N0(体配色 体配色)
		{
			this.グロ\u30FCブ_グロ\u30FCブCD = new ColorD();
			this.グロ\u30FCブ_縁1CD = new ColorD();
			this.グロ\u30FCブ_縁2CD = new ColorD();
			this.獣性_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.手CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.獣性_肉球CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.人指_人指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.人指_人指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.人指_人指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.人指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.中指_中指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.中指_中指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.中指_中指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.中指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.薬指_薬指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.薬指_薬指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.薬指_薬指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.薬指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.小指_小指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.小指_小指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.小指_小指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.親指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.親指_親指1CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.親指_親指2CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.親指_親指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.悪タトゥ_五芒星_円1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_円2CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_星CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_五角形CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
		}

		private void 配色B0(体配色 体配色)
		{
			this.グロ\u30FCブ_グロ\u30FCブCD = new ColorD();
			this.グロ\u30FCブ_縁1CD = new ColorD();
			this.グロ\u30FCブ_縁2CD = new ColorD();
			this.獣性_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.手CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.獣性_肉球CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.人指_人指1CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.人指_人指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.人指_人指2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.人指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中指_中指1CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.中指_中指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.中指_中指2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.中指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.薬指_薬指1CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.薬指_薬指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.薬指_薬指2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.薬指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.小指_小指1CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.小指_小指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.小指_小指2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.親指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.親指_親指1CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.親指_親指2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.親指_親指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.悪タトゥ_五芒星_円1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_円2CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_星CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_五角形CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
		}

		private void 配色C0(体配色 体配色)
		{
			this.グロ\u30FCブ_グロ\u30FCブCD = new ColorD();
			this.グロ\u30FCブ_縁1CD = new ColorD();
			this.グロ\u30FCブ_縁2CD = new ColorD();
			this.獣性_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.手CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.獣性_肉球CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.人指_人指1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.人指_人指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.人指_人指2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.人指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中指_中指1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.中指_中指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.中指_中指2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.中指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.薬指_薬指1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.薬指_薬指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.薬指_薬指2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.薬指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.小指_小指1CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.小指_小指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.小指_小指2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.親指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.親指_親指1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.親指_親指2CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
			this.親指_親指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.悪タトゥ_五芒星_円1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_円2CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_星CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_五角形CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
		}

		private void 配色S0(体配色 体配色)
		{
			this.グロ\u30FCブ_グロ\u30FCブCD = new ColorD();
			this.グロ\u30FCブ_縁1CD = new ColorD();
			this.グロ\u30FCブ_縁2CD = new ColorD();
			this.獣性_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.手CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.獣性_肉球CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.人指_人指1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_人指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.人指_人指2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.人指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.中指_中指1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_中指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.中指_中指2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.中指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.薬指_薬指1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_薬指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.薬指_薬指2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.薬指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.小指_小指1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.小指_小指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.小指_小指2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.親指_水掻CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.親指_親指1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
			this.親指_親指2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.親指_親指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.悪タトゥ_五芒星_円1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_円2CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_星CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_五角形CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
		}

		private void 配色L0(体配色 体配色)
		{
			this.グロ\u30FCブ_グロ\u30FCブCD = new ColorD();
			this.グロ\u30FCブ_縁1CD = new ColorD();
			this.グロ\u30FCブ_縁2CD = new ColorD();
			this.獣性_獣毛CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
			this.手CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.獣性_肉球CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
			this.人指_人指1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.人指_人指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.人指_人指2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.人指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.中指_中指1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.中指_中指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.中指_中指2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.中指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.薬指_薬指1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.薬指_薬指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.薬指_薬指2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.薬指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.小指_小指1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.小指_小指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.小指_小指2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.親指_水掻CD = new ColorD(ref Col.Black, ref 体配色.膜O);
			this.親指_親指1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.親指_親指2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.親指_親指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.竜性_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.竜性_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
			this.悪タトゥ_五芒星_円1CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_円2CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_星CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
			this.悪タトゥ_五芒星_五角形CD = new ColorD(ref 体配色.刺青.Col1, ref Color2.Empty);
		}

		public Par X0Y0_グロ\u30FCブ_グロ\u30FCブ;

		public Par X0Y0_グロ\u30FCブ_縁1;

		public Par X0Y0_グロ\u30FCブ_縁2;

		public Par X0Y0_獣性_獣毛;

		public Par X0Y0_手;

		public Par X0Y0_獣性_肉球;

		public Par X0Y0_人指_人指1;

		public Par X0Y0_人指_人指3;

		public Par X0Y0_人指_人指2;

		public Par X0Y0_人指_水掻;

		public Par X0Y0_中指_中指1;

		public Par X0Y0_中指_中指3;

		public Par X0Y0_中指_中指2;

		public Par X0Y0_中指_水掻;

		public Par X0Y0_薬指_薬指1;

		public Par X0Y0_薬指_薬指3;

		public Par X0Y0_薬指_薬指2;

		public Par X0Y0_薬指_水掻;

		public Par X0Y0_小指_小指1;

		public Par X0Y0_小指_小指3;

		public Par X0Y0_小指_小指2;

		public Par X0Y0_親指_水掻;

		public Par X0Y0_親指_親指1;

		public Par X0Y0_親指_獣性_肉球;

		public Par X0Y0_親指_親指2;

		public Par X0Y0_親指_親指3;

		public Par X0Y1_親指_親指3;

		public Par X0Y1_親指_親指2;

		public Par X0Y1_親指_親指1;

		public Par X0Y1_親指_水掻;

		public Par X0Y1_人指_人指3;

		public Par X0Y1_人指_人指2;

		public Par X0Y1_人指_人指1;

		public Par X0Y1_人指_水掻;

		public Par X0Y1_中指_中指3;

		public Par X0Y1_中指_中指2;

		public Par X0Y1_中指_中指1;

		public Par X0Y1_中指_水掻;

		public Par X0Y1_薬指_薬指3;

		public Par X0Y1_薬指_薬指2;

		public Par X0Y1_薬指_薬指1;

		public Par X0Y1_薬指_水掻;

		public Par X0Y1_小指_小指3;

		public Par X0Y1_小指_小指2;

		public Par X0Y1_小指_小指1;

		public Par X0Y1_手;

		public Par X0Y1_獣性_獣毛;

		public Par X0Y1_竜性_鱗1;

		public Par X0Y1_竜性_鱗2;

		public Par X0Y1_竜性_鱗3;

		public Par X0Y1_悪タトゥ_五芒星_円1;

		public Par X0Y1_悪タトゥ_五芒星_円2;

		public Par X0Y1_悪タトゥ_五芒星_星;

		public Par X0Y1_悪タトゥ_五芒星_五角形;

		public Par X0Y1_グロ\u30FCブ_グロ\u30FCブ;

		public Par X0Y1_グロ\u30FCブ_縁1;

		public Par X0Y1_グロ\u30FCブ_縁2;

		public Par X0Y2_親指_親指3;

		public Par X0Y2_親指_親指2;

		public Par X0Y2_親指_親指1;

		public Par X0Y2_親指_水掻;

		public Par X0Y2_人指_人指3;

		public Par X0Y2_人指_人指2;

		public Par X0Y2_人指_人指1;

		public Par X0Y2_人指_水掻;

		public Par X0Y2_中指_中指3;

		public Par X0Y2_中指_中指2;

		public Par X0Y2_中指_中指1;

		public Par X0Y2_中指_水掻;

		public Par X0Y2_薬指_薬指3;

		public Par X0Y2_薬指_薬指2;

		public Par X0Y2_薬指_薬指1;

		public Par X0Y2_薬指_水掻;

		public Par X0Y2_小指_小指3;

		public Par X0Y2_小指_小指2;

		public Par X0Y2_小指_小指1;

		public Par X0Y2_手;

		public Par X0Y2_獣性_獣毛;

		public Par X0Y2_竜性_鱗1;

		public Par X0Y2_竜性_鱗2;

		public Par X0Y2_竜性_鱗3;

		public Par X0Y2_悪タトゥ_五芒星_円1;

		public Par X0Y2_悪タトゥ_五芒星_円2;

		public Par X0Y2_悪タトゥ_五芒星_星;

		public Par X0Y2_悪タトゥ_五芒星_五角形;

		public Par X0Y2_グロ\u30FCブ_グロ\u30FCブ;

		public Par X0Y2_グロ\u30FCブ_縁1;

		public Par X0Y2_グロ\u30FCブ_縁2;

		public Par X0Y3_親指_親指1;

		public Par X0Y3_親指_親指2;

		public Par X0Y3_親指_親指3;

		public Par X0Y3_親指_水掻;

		public Par X0Y3_人指_人指3;

		public Par X0Y3_人指_人指2;

		public Par X0Y3_人指_人指1;

		public Par X0Y3_人指_水掻;

		public Par X0Y3_中指_中指3;

		public Par X0Y3_中指_中指2;

		public Par X0Y3_中指_中指1;

		public Par X0Y3_中指_水掻;

		public Par X0Y3_薬指_薬指3;

		public Par X0Y3_薬指_薬指2;

		public Par X0Y3_薬指_薬指1;

		public Par X0Y3_薬指_水掻;

		public Par X0Y3_小指_小指3;

		public Par X0Y3_小指_小指2;

		public Par X0Y3_小指_小指1;

		public Par X0Y3_手;

		public Par X0Y3_獣性_獣毛;

		public Par X0Y3_竜性_鱗1;

		public Par X0Y3_竜性_鱗2;

		public Par X0Y3_竜性_鱗3;

		public Par X0Y3_悪タトゥ_五芒星_円1;

		public Par X0Y3_悪タトゥ_五芒星_円2;

		public Par X0Y3_悪タトゥ_五芒星_星;

		public Par X0Y3_悪タトゥ_五芒星_五角形;

		public Par X0Y3_グロ\u30FCブ_グロ\u30FCブ;

		public Par X0Y3_グロ\u30FCブ_縁1;

		public Par X0Y3_グロ\u30FCブ_縁2;

		public Par X0Y4_親指_親指3;

		public Par X0Y4_親指_親指2;

		public Par X0Y4_親指_親指1;

		public Par X0Y4_親指_水掻;

		public Par X0Y4_人指_人指3;

		public Par X0Y4_人指_人指2;

		public Par X0Y4_人指_人指1;

		public Par X0Y4_人指_水掻;

		public Par X0Y4_小指_小指3;

		public Par X0Y4_小指_小指2;

		public Par X0Y4_小指_小指1;

		public Par X0Y4_中指_中指3;

		public Par X0Y4_中指_中指2;

		public Par X0Y4_中指_中指1;

		public Par X0Y4_中指_水掻;

		public Par X0Y4_薬指_薬指3;

		public Par X0Y4_薬指_薬指2;

		public Par X0Y4_薬指_薬指1;

		public Par X0Y4_薬指_水掻;

		public Par X0Y4_手;

		public Par X0Y4_獣性_獣毛;

		public Par X0Y4_竜性_鱗1;

		public Par X0Y4_竜性_鱗2;

		public Par X0Y4_竜性_鱗3;

		public Par X0Y4_悪タトゥ_五芒星_円1;

		public Par X0Y4_悪タトゥ_五芒星_円2;

		public Par X0Y4_悪タトゥ_五芒星_星;

		public Par X0Y4_悪タトゥ_五芒星_五角形;

		public Par X0Y4_グロ\u30FCブ_グロ\u30FCブ;

		public Par X0Y4_グロ\u30FCブ_縁1;

		public Par X0Y4_グロ\u30FCブ_縁2;

		public Par X0Y5_親指_親指1;

		public Par X0Y5_親指_親指2;

		public Par X0Y5_親指_親指3;

		public Par X0Y5_親指_水掻;

		public Par X0Y5_人指_人指3;

		public Par X0Y5_人指_人指2;

		public Par X0Y5_人指_人指1;

		public Par X0Y5_人指_水掻;

		public Par X0Y5_中指_中指3;

		public Par X0Y5_中指_中指2;

		public Par X0Y5_中指_中指1;

		public Par X0Y5_中指_水掻;

		public Par X0Y5_薬指_薬指3;

		public Par X0Y5_薬指_薬指2;

		public Par X0Y5_薬指_薬指1;

		public Par X0Y5_薬指_水掻;

		public Par X0Y5_小指_小指3;

		public Par X0Y5_小指_小指2;

		public Par X0Y5_小指_小指1;

		public Par X0Y5_手;

		public Par X0Y5_獣性_獣毛;

		public Par X0Y5_竜性_鱗1;

		public Par X0Y5_竜性_鱗2;

		public Par X0Y5_竜性_鱗3;

		public Par X0Y5_悪タトゥ_五芒星_円1;

		public Par X0Y5_悪タトゥ_五芒星_円2;

		public Par X0Y5_悪タトゥ_五芒星_星;

		public Par X0Y5_悪タトゥ_五芒星_五角形;

		public Par X0Y5_グロ\u30FCブ_グロ\u30FCブ;

		public Par X0Y5_グロ\u30FCブ_縁1;

		public Par X0Y5_グロ\u30FCブ_縁2;

		public Par X0Y6_小指_小指3;

		public Par X0Y6_小指_小指2;

		public Par X0Y6_小指_小指1;

		public Par X0Y6_薬指_水掻;

		public Par X0Y6_薬指_薬指3;

		public Par X0Y6_薬指_薬指2;

		public Par X0Y6_薬指_薬指1;

		public Par X0Y6_中指_水掻;

		public Par X0Y6_中指_中指3;

		public Par X0Y6_中指_中指2;

		public Par X0Y6_中指_中指1;

		public Par X0Y6_人指_水掻;

		public Par X0Y6_人指_人指3;

		public Par X0Y6_人指_人指2;

		public Par X0Y6_人指_人指1;

		public Par X0Y6_親指_親指3;

		public Par X0Y6_親指_親指2;

		public Par X0Y6_親指_親指1;

		public Par X0Y6_親指_水掻;

		public Par X0Y6_手;

		public Par X0Y6_獣性_獣毛;

		public Par X0Y6_竜性_鱗1;

		public Par X0Y6_竜性_鱗2;

		public Par X0Y6_竜性_鱗3;

		public Par X0Y6_悪タトゥ_五芒星_円1;

		public Par X0Y6_悪タトゥ_五芒星_円2;

		public Par X0Y6_悪タトゥ_五芒星_星;

		public Par X0Y6_悪タトゥ_五芒星_五角形;

		public Par X0Y6_グロ\u30FCブ_グロ\u30FCブ;

		public Par X0Y6_グロ\u30FCブ_縁1;

		public Par X0Y6_グロ\u30FCブ_縁2;

		public Par X0Y7_親指_親指1;

		public Par X0Y7_親指_親指2;

		public Par X0Y7_親指_親指3;

		public Par X0Y7_親指_水掻;

		public Par X0Y7_手;

		public Par X0Y7_人指_人指3;

		public Par X0Y7_人指_人指2;

		public Par X0Y7_人指_人指1;

		public Par X0Y7_人指_水掻;

		public Par X0Y7_中指_中指3;

		public Par X0Y7_中指_中指2;

		public Par X0Y7_中指_中指1;

		public Par X0Y7_中指_水掻;

		public Par X0Y7_小指_小指3;

		public Par X0Y7_小指_小指2;

		public Par X0Y7_小指_小指1;

		public Par X0Y7_薬指_薬指3;

		public Par X0Y7_薬指_薬指2;

		public Par X0Y7_薬指_薬指1;

		public Par X0Y7_薬指_水掻;

		public Par X0Y7_獣性_獣毛;

		public Par X0Y7_竜性_鱗1;

		public Par X0Y7_竜性_鱗2;

		public Par X0Y7_竜性_鱗3;

		public Par X0Y7_悪タトゥ_五芒星_円1;

		public Par X0Y7_悪タトゥ_五芒星_円2;

		public Par X0Y7_悪タトゥ_五芒星_星;

		public Par X0Y7_悪タトゥ_五芒星_五角形;

		public Par X0Y7_グロ\u30FCブ_グロ\u30FCブ;

		public Par X0Y7_グロ\u30FCブ_縁1;

		public Par X0Y7_グロ\u30FCブ_縁2;

		public Par X0Y8_親指_親指3;

		public Par X0Y8_親指_親指2;

		public Par X0Y8_親指_親指1;

		public Par X0Y8_親指_水掻;

		public Par X0Y8_人指_人指3;

		public Par X0Y8_人指_人指2;

		public Par X0Y8_人指_人指1;

		public Par X0Y8_人指_水掻;

		public Par X0Y8_中指_中指3;

		public Par X0Y8_中指_中指2;

		public Par X0Y8_中指_中指1;

		public Par X0Y8_中指_水掻;

		public Par X0Y8_薬指_薬指3;

		public Par X0Y8_薬指_薬指2;

		public Par X0Y8_薬指_薬指1;

		public Par X0Y8_薬指_水掻;

		public Par X0Y8_小指_小指3;

		public Par X0Y8_小指_小指2;

		public Par X0Y8_小指_小指1;

		public Par X0Y8_手;

		public Par X0Y8_獣性_獣毛;

		public Par X0Y8_竜性_鱗1;

		public Par X0Y8_竜性_鱗2;

		public Par X0Y8_竜性_鱗3;

		public Par X0Y8_悪タトゥ_五芒星_円1;

		public Par X0Y8_悪タトゥ_五芒星_円2;

		public Par X0Y8_悪タトゥ_五芒星_星;

		public Par X0Y8_悪タトゥ_五芒星_五角形;

		public Par X0Y8_グロ\u30FCブ_グロ\u30FCブ;

		public Par X0Y8_グロ\u30FCブ_縁1;

		public Par X0Y8_グロ\u30FCブ_縁2;

		public Par X0Y9_グロ\u30FCブ_グロ\u30FCブ;

		public Par X0Y9_グロ\u30FCブ_縁1;

		public Par X0Y9_グロ\u30FCブ_縁2;

		public Par X0Y9_獣性_獣毛;

		public Par X0Y9_手;

		public Par X0Y9_獣肉球;

		public Par X0Y9_人指_人指1;

		public Par X0Y9_人指_人指3;

		public Par X0Y9_人指_人指2;

		public Par X0Y9_人指_水掻;

		public Par X0Y9_中指_中指1;

		public Par X0Y9_中指_中指3;

		public Par X0Y9_中指_中指2;

		public Par X0Y9_中指_水掻;

		public Par X0Y9_薬指_薬指1;

		public Par X0Y9_薬指_薬指3;

		public Par X0Y9_薬指_薬指2;

		public Par X0Y9_薬指_水掻;

		public Par X0Y9_小指_小指1;

		public Par X0Y9_小指_小指3;

		public Par X0Y9_小指_小指2;

		public Par X0Y9_親指_水掻;

		public Par X0Y9_親指_親指1;

		public Par X0Y9_親指_獣肉球;

		public Par X0Y9_親指_親指2;

		public Par X0Y9_親指_親指3;

		public Par X0Y10_親指_親指3;

		public Par X0Y10_親指_親指2;

		public Par X0Y10_親指_親指1;

		public Par X0Y10_親指_水掻;

		public Par X0Y10_人指_人指3;

		public Par X0Y10_人指_人指2;

		public Par X0Y10_人指_人指1;

		public Par X0Y10_人指_水掻;

		public Par X0Y10_小指_小指3;

		public Par X0Y10_小指_小指2;

		public Par X0Y10_小指_小指1;

		public Par X0Y10_中指_中指3;

		public Par X0Y10_中指_中指2;

		public Par X0Y10_中指_中指1;

		public Par X0Y10_中指_水掻;

		public Par X0Y10_薬指_薬指3;

		public Par X0Y10_薬指_薬指2;

		public Par X0Y10_薬指_薬指1;

		public Par X0Y10_薬指_水掻;

		public Par X0Y10_手;

		public Par X0Y10_獣性_獣毛;

		public Par X0Y10_竜性_鱗1;

		public Par X0Y10_竜性_鱗2;

		public Par X0Y10_竜性_鱗3;

		public Par X0Y10_悪タトゥ_五芒星_円1;

		public Par X0Y10_悪タトゥ_五芒星_円2;

		public Par X0Y10_悪タトゥ_五芒星_星;

		public Par X0Y10_悪タトゥ_五芒星_五角形;

		public Par X0Y10_グロ\u30FCブ_グロ\u30FCブ;

		public Par X0Y10_グロ\u30FCブ_縁1;

		public Par X0Y10_グロ\u30FCブ_縁2;

		public ColorD グロ\u30FCブ_グロ\u30FCブCD;

		public ColorD グロ\u30FCブ_縁1CD;

		public ColorD グロ\u30FCブ_縁2CD;

		public ColorD 獣性_獣毛CD;

		public ColorD 手CD;

		public ColorD 獣性_肉球CD;

		public ColorD 人指_人指1CD;

		public ColorD 人指_人指3CD;

		public ColorD 人指_人指2CD;

		public ColorD 人指_水掻CD;

		public ColorD 中指_中指1CD;

		public ColorD 中指_中指3CD;

		public ColorD 中指_中指2CD;

		public ColorD 中指_水掻CD;

		public ColorD 薬指_薬指1CD;

		public ColorD 薬指_薬指3CD;

		public ColorD 薬指_薬指2CD;

		public ColorD 薬指_水掻CD;

		public ColorD 小指_小指1CD;

		public ColorD 小指_小指3CD;

		public ColorD 小指_小指2CD;

		public ColorD 親指_水掻CD;

		public ColorD 親指_親指1CD;

		public ColorD 親指_親指2CD;

		public ColorD 親指_親指3CD;

		public ColorD 竜性_鱗1CD;

		public ColorD 竜性_鱗2CD;

		public ColorD 竜性_鱗3CD;

		public ColorD 悪タトゥ_五芒星_円1CD;

		public ColorD 悪タトゥ_五芒星_円2CD;

		public ColorD 悪タトゥ_五芒星_星CD;

		public ColorD 悪タトゥ_五芒星_五角形CD;

		public ColorP X0Y0_グロ\u30FCブ_グロ\u30FCブCP;

		public ColorP X0Y0_グロ\u30FCブ_縁1CP;

		public ColorP X0Y0_グロ\u30FCブ_縁2CP;

		public ColorP X0Y0_獣性_獣毛CP;

		public ColorP X0Y0_手CP;

		public ColorP X0Y0_獣性_肉球CP;

		public ColorP X0Y0_人指_人指1CP;

		public ColorP X0Y0_人指_人指3CP;

		public ColorP X0Y0_人指_人指2CP;

		public ColorP X0Y0_人指_水掻CP;

		public ColorP X0Y0_中指_中指1CP;

		public ColorP X0Y0_中指_中指3CP;

		public ColorP X0Y0_中指_中指2CP;

		public ColorP X0Y0_中指_水掻CP;

		public ColorP X0Y0_薬指_薬指1CP;

		public ColorP X0Y0_薬指_薬指3CP;

		public ColorP X0Y0_薬指_薬指2CP;

		public ColorP X0Y0_薬指_水掻CP;

		public ColorP X0Y0_小指_小指1CP;

		public ColorP X0Y0_小指_小指3CP;

		public ColorP X0Y0_小指_小指2CP;

		public ColorP X0Y0_親指_水掻CP;

		public ColorP X0Y0_親指_親指1CP;

		public ColorP X0Y0_親指_獣性_肉球CP;

		public ColorP X0Y0_親指_親指2CP;

		public ColorP X0Y0_親指_親指3CP;

		public ColorP X0Y1_親指_親指3CP;

		public ColorP X0Y1_親指_親指2CP;

		public ColorP X0Y1_親指_親指1CP;

		public ColorP X0Y1_親指_水掻CP;

		public ColorP X0Y1_人指_人指3CP;

		public ColorP X0Y1_人指_人指2CP;

		public ColorP X0Y1_人指_人指1CP;

		public ColorP X0Y1_人指_水掻CP;

		public ColorP X0Y1_中指_中指3CP;

		public ColorP X0Y1_中指_中指2CP;

		public ColorP X0Y1_中指_中指1CP;

		public ColorP X0Y1_中指_水掻CP;

		public ColorP X0Y1_薬指_薬指3CP;

		public ColorP X0Y1_薬指_薬指2CP;

		public ColorP X0Y1_薬指_薬指1CP;

		public ColorP X0Y1_薬指_水掻CP;

		public ColorP X0Y1_小指_小指3CP;

		public ColorP X0Y1_小指_小指2CP;

		public ColorP X0Y1_小指_小指1CP;

		public ColorP X0Y1_手CP;

		public ColorP X0Y1_獣性_獣毛CP;

		public ColorP X0Y1_竜性_鱗1CP;

		public ColorP X0Y1_竜性_鱗2CP;

		public ColorP X0Y1_竜性_鱗3CP;

		public ColorP X0Y1_悪タトゥ_五芒星_円1CP;

		public ColorP X0Y1_悪タトゥ_五芒星_円2CP;

		public ColorP X0Y1_悪タトゥ_五芒星_星CP;

		public ColorP X0Y1_悪タトゥ_五芒星_五角形CP;

		public ColorP X0Y1_グロ\u30FCブ_グロ\u30FCブCP;

		public ColorP X0Y1_グロ\u30FCブ_縁1CP;

		public ColorP X0Y1_グロ\u30FCブ_縁2CP;

		public ColorP X0Y2_親指_親指3CP;

		public ColorP X0Y2_親指_親指2CP;

		public ColorP X0Y2_親指_親指1CP;

		public ColorP X0Y2_親指_水掻CP;

		public ColorP X0Y2_人指_人指3CP;

		public ColorP X0Y2_人指_人指2CP;

		public ColorP X0Y2_人指_人指1CP;

		public ColorP X0Y2_人指_水掻CP;

		public ColorP X0Y2_中指_中指3CP;

		public ColorP X0Y2_中指_中指2CP;

		public ColorP X0Y2_中指_中指1CP;

		public ColorP X0Y2_中指_水掻CP;

		public ColorP X0Y2_薬指_薬指3CP;

		public ColorP X0Y2_薬指_薬指2CP;

		public ColorP X0Y2_薬指_薬指1CP;

		public ColorP X0Y2_薬指_水掻CP;

		public ColorP X0Y2_小指_小指3CP;

		public ColorP X0Y2_小指_小指2CP;

		public ColorP X0Y2_小指_小指1CP;

		public ColorP X0Y2_手CP;

		public ColorP X0Y2_獣性_獣毛CP;

		public ColorP X0Y2_竜性_鱗1CP;

		public ColorP X0Y2_竜性_鱗2CP;

		public ColorP X0Y2_竜性_鱗3CP;

		public ColorP X0Y2_悪タトゥ_五芒星_円1CP;

		public ColorP X0Y2_悪タトゥ_五芒星_円2CP;

		public ColorP X0Y2_悪タトゥ_五芒星_星CP;

		public ColorP X0Y2_悪タトゥ_五芒星_五角形CP;

		public ColorP X0Y2_グロ\u30FCブ_グロ\u30FCブCP;

		public ColorP X0Y2_グロ\u30FCブ_縁1CP;

		public ColorP X0Y2_グロ\u30FCブ_縁2CP;

		public ColorP X0Y3_親指_親指1CP;

		public ColorP X0Y3_親指_親指2CP;

		public ColorP X0Y3_親指_親指3CP;

		public ColorP X0Y3_親指_水掻CP;

		public ColorP X0Y3_人指_人指3CP;

		public ColorP X0Y3_人指_人指2CP;

		public ColorP X0Y3_人指_人指1CP;

		public ColorP X0Y3_人指_水掻CP;

		public ColorP X0Y3_中指_中指3CP;

		public ColorP X0Y3_中指_中指2CP;

		public ColorP X0Y3_中指_中指1CP;

		public ColorP X0Y3_中指_水掻CP;

		public ColorP X0Y3_薬指_薬指3CP;

		public ColorP X0Y3_薬指_薬指2CP;

		public ColorP X0Y3_薬指_薬指1CP;

		public ColorP X0Y3_薬指_水掻CP;

		public ColorP X0Y3_小指_小指3CP;

		public ColorP X0Y3_小指_小指2CP;

		public ColorP X0Y3_小指_小指1CP;

		public ColorP X0Y3_手CP;

		public ColorP X0Y3_獣性_獣毛CP;

		public ColorP X0Y3_竜性_鱗1CP;

		public ColorP X0Y3_竜性_鱗2CP;

		public ColorP X0Y3_竜性_鱗3CP;

		public ColorP X0Y3_悪タトゥ_五芒星_円1CP;

		public ColorP X0Y3_悪タトゥ_五芒星_円2CP;

		public ColorP X0Y3_悪タトゥ_五芒星_星CP;

		public ColorP X0Y3_悪タトゥ_五芒星_五角形CP;

		public ColorP X0Y3_グロ\u30FCブ_グロ\u30FCブCP;

		public ColorP X0Y3_グロ\u30FCブ_縁1CP;

		public ColorP X0Y3_グロ\u30FCブ_縁2CP;

		public ColorP X0Y4_親指_親指3CP;

		public ColorP X0Y4_親指_親指2CP;

		public ColorP X0Y4_親指_親指1CP;

		public ColorP X0Y4_親指_水掻CP;

		public ColorP X0Y4_人指_人指3CP;

		public ColorP X0Y4_人指_人指2CP;

		public ColorP X0Y4_人指_人指1CP;

		public ColorP X0Y4_人指_水掻CP;

		public ColorP X0Y4_小指_小指3CP;

		public ColorP X0Y4_小指_小指2CP;

		public ColorP X0Y4_小指_小指1CP;

		public ColorP X0Y4_中指_中指3CP;

		public ColorP X0Y4_中指_中指2CP;

		public ColorP X0Y4_中指_中指1CP;

		public ColorP X0Y4_中指_水掻CP;

		public ColorP X0Y4_薬指_薬指3CP;

		public ColorP X0Y4_薬指_薬指2CP;

		public ColorP X0Y4_薬指_薬指1CP;

		public ColorP X0Y4_薬指_水掻CP;

		public ColorP X0Y4_手CP;

		public ColorP X0Y4_獣性_獣毛CP;

		public ColorP X0Y4_竜性_鱗1CP;

		public ColorP X0Y4_竜性_鱗2CP;

		public ColorP X0Y4_竜性_鱗3CP;

		public ColorP X0Y4_悪タトゥ_五芒星_円1CP;

		public ColorP X0Y4_悪タトゥ_五芒星_円2CP;

		public ColorP X0Y4_悪タトゥ_五芒星_星CP;

		public ColorP X0Y4_悪タトゥ_五芒星_五角形CP;

		public ColorP X0Y4_グロ\u30FCブ_グロ\u30FCブCP;

		public ColorP X0Y4_グロ\u30FCブ_縁1CP;

		public ColorP X0Y4_グロ\u30FCブ_縁2CP;

		public ColorP X0Y5_親指_親指1CP;

		public ColorP X0Y5_親指_親指2CP;

		public ColorP X0Y5_親指_親指3CP;

		public ColorP X0Y5_親指_水掻CP;

		public ColorP X0Y5_人指_人指3CP;

		public ColorP X0Y5_人指_人指2CP;

		public ColorP X0Y5_人指_人指1CP;

		public ColorP X0Y5_人指_水掻CP;

		public ColorP X0Y5_中指_中指3CP;

		public ColorP X0Y5_中指_中指2CP;

		public ColorP X0Y5_中指_中指1CP;

		public ColorP X0Y5_中指_水掻CP;

		public ColorP X0Y5_薬指_薬指3CP;

		public ColorP X0Y5_薬指_薬指2CP;

		public ColorP X0Y5_薬指_薬指1CP;

		public ColorP X0Y5_薬指_水掻CP;

		public ColorP X0Y5_小指_小指3CP;

		public ColorP X0Y5_小指_小指2CP;

		public ColorP X0Y5_小指_小指1CP;

		public ColorP X0Y5_手CP;

		public ColorP X0Y5_獣性_獣毛CP;

		public ColorP X0Y5_竜性_鱗1CP;

		public ColorP X0Y5_竜性_鱗2CP;

		public ColorP X0Y5_竜性_鱗3CP;

		public ColorP X0Y5_悪タトゥ_五芒星_円1CP;

		public ColorP X0Y5_悪タトゥ_五芒星_円2CP;

		public ColorP X0Y5_悪タトゥ_五芒星_星CP;

		public ColorP X0Y5_悪タトゥ_五芒星_五角形CP;

		public ColorP X0Y5_グロ\u30FCブ_グロ\u30FCブCP;

		public ColorP X0Y5_グロ\u30FCブ_縁1CP;

		public ColorP X0Y5_グロ\u30FCブ_縁2CP;

		public ColorP X0Y6_小指_小指3CP;

		public ColorP X0Y6_小指_小指2CP;

		public ColorP X0Y6_小指_小指1CP;

		public ColorP X0Y6_薬指_水掻CP;

		public ColorP X0Y6_薬指_薬指3CP;

		public ColorP X0Y6_薬指_薬指2CP;

		public ColorP X0Y6_薬指_薬指1CP;

		public ColorP X0Y6_中指_水掻CP;

		public ColorP X0Y6_中指_中指3CP;

		public ColorP X0Y6_中指_中指2CP;

		public ColorP X0Y6_中指_中指1CP;

		public ColorP X0Y6_人指_水掻CP;

		public ColorP X0Y6_人指_人指3CP;

		public ColorP X0Y6_人指_人指2CP;

		public ColorP X0Y6_人指_人指1CP;

		public ColorP X0Y6_親指_親指3CP;

		public ColorP X0Y6_親指_親指2CP;

		public ColorP X0Y6_親指_親指1CP;

		public ColorP X0Y6_親指_水掻CP;

		public ColorP X0Y6_手CP;

		public ColorP X0Y6_獣性_獣毛CP;

		public ColorP X0Y6_竜性_鱗1CP;

		public ColorP X0Y6_竜性_鱗2CP;

		public ColorP X0Y6_竜性_鱗3CP;

		public ColorP X0Y6_悪タトゥ_五芒星_円1CP;

		public ColorP X0Y6_悪タトゥ_五芒星_円2CP;

		public ColorP X0Y6_悪タトゥ_五芒星_星CP;

		public ColorP X0Y6_悪タトゥ_五芒星_五角形CP;

		public ColorP X0Y6_グロ\u30FCブ_グロ\u30FCブCP;

		public ColorP X0Y6_グロ\u30FCブ_縁1CP;

		public ColorP X0Y6_グロ\u30FCブ_縁2CP;

		public ColorP X0Y7_親指_親指1CP;

		public ColorP X0Y7_親指_親指2CP;

		public ColorP X0Y7_親指_親指3CP;

		public ColorP X0Y7_親指_水掻CP;

		public ColorP X0Y7_手CP;

		public ColorP X0Y7_人指_人指3CP;

		public ColorP X0Y7_人指_人指2CP;

		public ColorP X0Y7_人指_人指1CP;

		public ColorP X0Y7_人指_水掻CP;

		public ColorP X0Y7_中指_中指3CP;

		public ColorP X0Y7_中指_中指2CP;

		public ColorP X0Y7_中指_中指1CP;

		public ColorP X0Y7_中指_水掻CP;

		public ColorP X0Y7_小指_小指3CP;

		public ColorP X0Y7_小指_小指2CP;

		public ColorP X0Y7_小指_小指1CP;

		public ColorP X0Y7_薬指_薬指3CP;

		public ColorP X0Y7_薬指_薬指2CP;

		public ColorP X0Y7_薬指_薬指1CP;

		public ColorP X0Y7_薬指_水掻CP;

		public ColorP X0Y7_獣性_獣毛CP;

		public ColorP X0Y7_竜性_鱗1CP;

		public ColorP X0Y7_竜性_鱗2CP;

		public ColorP X0Y7_竜性_鱗3CP;

		public ColorP X0Y7_悪タトゥ_五芒星_円1CP;

		public ColorP X0Y7_悪タトゥ_五芒星_円2CP;

		public ColorP X0Y7_悪タトゥ_五芒星_星CP;

		public ColorP X0Y7_悪タトゥ_五芒星_五角形CP;

		public ColorP X0Y7_グロ\u30FCブ_グロ\u30FCブCP;

		public ColorP X0Y7_グロ\u30FCブ_縁1CP;

		public ColorP X0Y7_グロ\u30FCブ_縁2CP;

		public ColorP X0Y8_親指_親指3CP;

		public ColorP X0Y8_親指_親指2CP;

		public ColorP X0Y8_親指_親指1CP;

		public ColorP X0Y8_親指_水掻CP;

		public ColorP X0Y8_人指_人指3CP;

		public ColorP X0Y8_人指_人指2CP;

		public ColorP X0Y8_人指_人指1CP;

		public ColorP X0Y8_人指_水掻CP;

		public ColorP X0Y8_中指_中指3CP;

		public ColorP X0Y8_中指_中指2CP;

		public ColorP X0Y8_中指_中指1CP;

		public ColorP X0Y8_中指_水掻CP;

		public ColorP X0Y8_薬指_薬指3CP;

		public ColorP X0Y8_薬指_薬指2CP;

		public ColorP X0Y8_薬指_薬指1CP;

		public ColorP X0Y8_薬指_水掻CP;

		public ColorP X0Y8_小指_小指3CP;

		public ColorP X0Y8_小指_小指2CP;

		public ColorP X0Y8_小指_小指1CP;

		public ColorP X0Y8_手CP;

		public ColorP X0Y8_獣性_獣毛CP;

		public ColorP X0Y8_竜性_鱗1CP;

		public ColorP X0Y8_竜性_鱗2CP;

		public ColorP X0Y8_竜性_鱗3CP;

		public ColorP X0Y8_悪タトゥ_五芒星_円1CP;

		public ColorP X0Y8_悪タトゥ_五芒星_円2CP;

		public ColorP X0Y8_悪タトゥ_五芒星_星CP;

		public ColorP X0Y8_悪タトゥ_五芒星_五角形CP;

		public ColorP X0Y8_グロ\u30FCブ_グロ\u30FCブCP;

		public ColorP X0Y8_グロ\u30FCブ_縁1CP;

		public ColorP X0Y8_グロ\u30FCブ_縁2CP;

		public ColorP X0Y9_グロ\u30FCブ_グロ\u30FCブCP;

		public ColorP X0Y9_グロ\u30FCブ_縁1CP;

		public ColorP X0Y9_グロ\u30FCブ_縁2CP;

		public ColorP X0Y9_獣性_獣毛CP;

		public ColorP X0Y9_手CP;

		public ColorP X0Y9_獣肉球CP;

		public ColorP X0Y9_人指_人指1CP;

		public ColorP X0Y9_人指_人指3CP;

		public ColorP X0Y9_人指_人指2CP;

		public ColorP X0Y9_人指_水掻CP;

		public ColorP X0Y9_中指_中指1CP;

		public ColorP X0Y9_中指_中指3CP;

		public ColorP X0Y9_中指_中指2CP;

		public ColorP X0Y9_中指_水掻CP;

		public ColorP X0Y9_薬指_薬指1CP;

		public ColorP X0Y9_薬指_薬指3CP;

		public ColorP X0Y9_薬指_薬指2CP;

		public ColorP X0Y9_薬指_水掻CP;

		public ColorP X0Y9_小指_小指1CP;

		public ColorP X0Y9_小指_小指3CP;

		public ColorP X0Y9_小指_小指2CP;

		public ColorP X0Y9_親指_水掻CP;

		public ColorP X0Y9_親指_親指1CP;

		public ColorP X0Y9_親指_獣肉球CP;

		public ColorP X0Y9_親指_親指2CP;

		public ColorP X0Y9_親指_親指3CP;

		public ColorP X0Y10_親指_親指3CP;

		public ColorP X0Y10_親指_親指2CP;

		public ColorP X0Y10_親指_親指1CP;

		public ColorP X0Y10_親指_水掻CP;

		public ColorP X0Y10_人指_人指3CP;

		public ColorP X0Y10_人指_人指2CP;

		public ColorP X0Y10_人指_人指1CP;

		public ColorP X0Y10_人指_水掻CP;

		public ColorP X0Y10_小指_小指3CP;

		public ColorP X0Y10_小指_小指2CP;

		public ColorP X0Y10_小指_小指1CP;

		public ColorP X0Y10_中指_中指3CP;

		public ColorP X0Y10_中指_中指2CP;

		public ColorP X0Y10_中指_中指1CP;

		public ColorP X0Y10_中指_水掻CP;

		public ColorP X0Y10_薬指_薬指3CP;

		public ColorP X0Y10_薬指_薬指2CP;

		public ColorP X0Y10_薬指_薬指1CP;

		public ColorP X0Y10_薬指_水掻CP;

		public ColorP X0Y10_手CP;

		public ColorP X0Y10_獣性_獣毛CP;

		public ColorP X0Y10_竜性_鱗1CP;

		public ColorP X0Y10_竜性_鱗2CP;

		public ColorP X0Y10_竜性_鱗3CP;

		public ColorP X0Y10_悪タトゥ_五芒星_円1CP;

		public ColorP X0Y10_悪タトゥ_五芒星_円2CP;

		public ColorP X0Y10_悪タトゥ_五芒星_星CP;

		public ColorP X0Y10_悪タトゥ_五芒星_五角形CP;

		public ColorP X0Y10_グロ\u30FCブ_グロ\u30FCブCP;

		public ColorP X0Y10_グロ\u30FCブ_縁1CP;

		public ColorP X0Y10_グロ\u30FCブ_縁2CP;
	}
}
