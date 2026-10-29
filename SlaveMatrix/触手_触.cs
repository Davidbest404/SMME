using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 触手_触 : 触手
	{
		public 触手_触(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 触手_触D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "触腕";
			dif.Add(new Pars(Sta.肢左["触手"][0][1]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["腕部"].ToPars();
			Pars pars3 = pars2["節1"].ToPars();
			this.X0Y0_腕部_節1_節 = pars3["節"].ToPar();
			Pars pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節1_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節1_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["節2"].ToPars();
			this.X0Y0_腕部_節2_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節2_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節2_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["節3"].ToPars();
			this.X0Y0_腕部_節3_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節3_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節3_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["節4"].ToPars();
			this.X0Y0_腕部_節4_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節4_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節4_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["節5"].ToPars();
			this.X0Y0_腕部_節5_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節5_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節5_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["節6"].ToPars();
			this.X0Y0_腕部_節6_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節6_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節6_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["節7"].ToPars();
			this.X0Y0_腕部_節7_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節7_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節7_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["節8"].ToPars();
			this.X0Y0_腕部_節8_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節8_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節8_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["節9"].ToPars();
			this.X0Y0_腕部_節9_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節9_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節9_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["節10"].ToPars();
			this.X0Y0_腕部_節10_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節10_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節10_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["節11"].ToPars();
			this.X0Y0_腕部_節11_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節11_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節11_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["節12"].ToPars();
			this.X0Y0_腕部_節12_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節12_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節12_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["節13"].ToPars();
			this.X0Y0_腕部_節13_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節13_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節13_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["節14"].ToPars();
			this.X0Y0_腕部_節14_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節14_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節14_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["節15"].ToPars();
			this.X0Y0_腕部_節15_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節15_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節15_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["輪1"].ToPars();
			this.X0Y0_腕部_輪1_革 = pars3["革"].ToPar();
			this.X0Y0_腕部_輪1_金具1 = pars3["金具1"].ToPar();
			this.X0Y0_腕部_輪1_金具2 = pars3["金具2"].ToPar();
			this.X0Y0_腕部_輪1_金具3 = pars3["金具3"].ToPar();
			this.X0Y0_腕部_輪1_金具左 = pars3["金具左"].ToPar();
			this.X0Y0_腕部_輪1_金具右 = pars3["金具右"].ToPar();
			pars3 = pars2["節16"].ToPars();
			this.X0Y0_腕部_節16_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節16_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節16_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["節17"].ToPars();
			this.X0Y0_腕部_節17_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節17_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節17_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["節18"].ToPars();
			this.X0Y0_腕部_節18_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節18_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節18_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["節19"].ToPars();
			this.X0Y0_腕部_節19_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節19_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節19_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["節20"].ToPars();
			this.X0Y0_腕部_節20_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節20_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節20_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["節21"].ToPars();
			this.X0Y0_腕部_節21_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節21_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節21_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["節22"].ToPars();
			this.X0Y0_腕部_節22_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節22_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節22_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["節23"].ToPars();
			this.X0Y0_腕部_節23_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節23_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節23_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["節24"].ToPars();
			this.X0Y0_腕部_節24_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節24_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節24_紋柄_紋柄2 = pars4["柄2"].ToPar();
			pars3 = pars2["節25"].ToPars();
			this.X0Y0_腕部_節25_節 = pars3["節"].ToPar();
			pars4 = pars3["柄"].ToPars();
			this.X0Y0_腕部_節25_紋柄_紋柄1 = pars4["柄1"].ToPar();
			this.X0Y0_腕部_節25_紋柄_紋柄2 = pars4["柄2"].ToPar();
			Pars pars5 = pars["手先"].ToPars();
			pars3 = pars5["節1"].ToPars();
			this.X0Y0_手先_節1_節 = pars3["節"].ToPar();
			this.X0Y0_手先_節1_紋柄1 = pars3["柄1"].ToPar();
			this.X0Y0_手先_節1_紋柄2 = pars3["柄2"].ToPar();
			pars4 = pars3["吸盤"].ToPars();
			this.X0Y0_手先_節1_吸盤_吸盤1 = pars4["吸盤1"].ToPar();
			this.X0Y0_手先_節1_吸盤_吸盤2 = pars4["吸盤2"].ToPar();
			this.X0Y0_手先_節1_吸盤_吸盤3 = pars4["吸盤3"].ToPar();
			this.X0Y0_手先_節1_吸盤_吸盤4 = pars4["吸盤4"].ToPar();
			pars4 = pars3["爪"].ToPars();
			this.X0Y0_手先_節1_爪_爪2 = pars4["爪2"].ToPar();
			this.X0Y0_手先_節1_爪_爪1 = pars4["爪1"].ToPar();
			pars3 = pars5["輪2"].ToPars();
			this.X0Y0_手先_輪2_革 = pars3["革"].ToPar();
			this.X0Y0_手先_輪2_金具1 = pars3["金具1"].ToPar();
			this.X0Y0_手先_輪2_金具2 = pars3["金具2"].ToPar();
			this.X0Y0_手先_輪2_金具3 = pars3["金具3"].ToPar();
			this.X0Y0_手先_輪2_金具左 = pars3["金具左"].ToPar();
			this.X0Y0_手先_輪2_金具右 = pars3["金具右"].ToPar();
			pars3 = pars5["節2"].ToPars();
			this.X0Y0_手先_節2_節 = pars3["節"].ToPar();
			this.X0Y0_手先_節2_紋柄1 = pars3["柄1"].ToPar();
			this.X0Y0_手先_節2_紋柄2 = pars3["柄2"].ToPar();
			pars4 = pars3["吸盤"].ToPars();
			this.X0Y0_手先_節2_吸盤_吸盤1 = pars4["吸盤1"].ToPar();
			this.X0Y0_手先_節2_吸盤_吸盤2 = pars4["吸盤2"].ToPar();
			this.X0Y0_手先_節2_吸盤_吸盤3 = pars4["吸盤3"].ToPar();
			this.X0Y0_手先_節2_吸盤_吸盤4 = pars4["吸盤4"].ToPar();
			pars4 = pars3["爪"].ToPars();
			this.X0Y0_手先_節2_爪_爪2 = pars4["爪2"].ToPar();
			this.X0Y0_手先_節2_爪_爪1 = pars4["爪1"].ToPar();
			pars3 = pars5["節3"].ToPars();
			this.X0Y0_手先_節3_節 = pars3["節"].ToPar();
			this.X0Y0_手先_節3_紋柄1 = pars3["柄1"].ToPar();
			this.X0Y0_手先_節3_紋柄2 = pars3["柄2"].ToPar();
			pars4 = pars3["吸盤"].ToPars();
			this.X0Y0_手先_節3_吸盤_吸盤1 = pars4["吸盤1"].ToPar();
			this.X0Y0_手先_節3_吸盤_吸盤2 = pars4["吸盤2"].ToPar();
			this.X0Y0_手先_節3_吸盤_吸盤3 = pars4["吸盤3"].ToPar();
			this.X0Y0_手先_節3_吸盤_吸盤4 = pars4["吸盤4"].ToPar();
			pars4 = pars3["爪"].ToPars();
			this.X0Y0_手先_節3_爪_爪2 = pars4["爪2"].ToPar();
			this.X0Y0_手先_節3_爪_爪1 = pars4["爪1"].ToPar();
			pars3 = pars5["節4"].ToPars();
			this.X0Y0_手先_節4_節 = pars3["節"].ToPar();
			this.X0Y0_手先_節4_紋柄1 = pars3["柄1"].ToPar();
			this.X0Y0_手先_節4_紋柄2 = pars3["柄2"].ToPar();
			pars4 = pars3["吸盤"].ToPars();
			this.X0Y0_手先_節4_吸盤_吸盤1 = pars4["吸盤1"].ToPar();
			this.X0Y0_手先_節4_吸盤_吸盤2 = pars4["吸盤2"].ToPar();
			this.X0Y0_手先_節4_吸盤_吸盤3 = pars4["吸盤3"].ToPar();
			this.X0Y0_手先_節4_吸盤_吸盤4 = pars4["吸盤4"].ToPar();
			pars4 = pars3["爪"].ToPars();
			this.X0Y0_手先_節4_爪_爪2 = pars4["爪2"].ToPar();
			this.X0Y0_手先_節4_爪_爪1 = pars4["爪1"].ToPar();
			pars3 = pars5["節5"].ToPars();
			this.X0Y0_手先_節5_節 = pars3["節"].ToPar();
			this.X0Y0_手先_節5_紋柄1 = pars3["柄1"].ToPar();
			this.X0Y0_手先_節5_紋柄2 = pars3["柄2"].ToPar();
			pars4 = pars3["吸盤"].ToPars();
			this.X0Y0_手先_節5_吸盤_吸盤1 = pars4["吸盤1"].ToPar();
			this.X0Y0_手先_節5_吸盤_吸盤2 = pars4["吸盤2"].ToPar();
			this.X0Y0_手先_節5_吸盤_吸盤3 = pars4["吸盤3"].ToPar();
			this.X0Y0_手先_節5_吸盤_吸盤4 = pars4["吸盤4"].ToPar();
			pars4 = pars3["爪"].ToPars();
			this.X0Y0_手先_節5_爪_爪2 = pars4["爪2"].ToPar();
			this.X0Y0_手先_節5_爪_爪1 = pars4["爪1"].ToPar();
			pars3 = pars5["節6"].ToPars();
			this.X0Y0_手先_節6_節 = pars3["節"].ToPar();
			this.X0Y0_手先_節6_紋柄1 = pars3["柄1"].ToPar();
			this.X0Y0_手先_節6_紋柄2 = pars3["柄2"].ToPar();
			pars4 = pars3["吸盤"].ToPars();
			this.X0Y0_手先_節6_吸盤_吸盤1 = pars4["吸盤1"].ToPar();
			this.X0Y0_手先_節6_吸盤_吸盤2 = pars4["吸盤2"].ToPar();
			this.X0Y0_手先_節6_吸盤_吸盤3 = pars4["吸盤3"].ToPar();
			this.X0Y0_手先_節6_吸盤_吸盤4 = pars4["吸盤4"].ToPar();
			pars4 = pars3["爪"].ToPars();
			this.X0Y0_手先_節6_爪_爪2 = pars4["爪2"].ToPar();
			this.X0Y0_手先_節6_爪_爪1 = pars4["爪1"].ToPar();
			pars3 = pars5["節7"].ToPars();
			this.X0Y0_手先_節7_節 = pars3["節"].ToPar();
			this.X0Y0_手先_節7_紋柄 = pars3["柄"].ToPar();
			pars4 = pars3["吸盤"].ToPars();
			this.X0Y0_手先_節7_吸盤_吸盤1 = pars4["吸盤1"].ToPar();
			this.X0Y0_手先_節7_吸盤_吸盤2 = pars4["吸盤2"].ToPar();
			this.X0Y0_手先_節7_吸盤_吸盤3 = pars4["吸盤3"].ToPar();
			this.X0Y0_手先_節7_吸盤_吸盤4 = pars4["吸盤4"].ToPar();
			pars4 = pars3["爪"].ToPars();
			this.X0Y0_手先_節7_爪_爪2 = pars4["爪2"].ToPar();
			this.X0Y0_手先_節7_爪_爪1 = pars4["爪1"].ToPar();
			pars3 = pars5["節8"].ToPars();
			this.X0Y0_手先_節8_節 = pars3["節"].ToPar();
			this.X0Y0_手先_節8_紋柄 = pars3["柄"].ToPar();
			pars4 = pars3["吸盤"].ToPars();
			this.X0Y0_手先_節8_吸盤_吸盤1 = pars4["吸盤1"].ToPar();
			this.X0Y0_手先_節8_吸盤_吸盤2 = pars4["吸盤2"].ToPar();
			this.X0Y0_手先_節8_吸盤_吸盤3 = pars4["吸盤3"].ToPar();
			this.X0Y0_手先_節8_吸盤_吸盤4 = pars4["吸盤4"].ToPar();
			pars4 = pars3["爪"].ToPars();
			this.X0Y0_手先_節8_爪_爪2 = pars4["爪2"].ToPar();
			this.X0Y0_手先_節8_爪_爪1 = pars4["爪1"].ToPar();
			pars3 = pars5["節9"].ToPars();
			this.X0Y0_手先_節9_節 = pars3["節"].ToPar();
			this.X0Y0_手先_節9_紋柄 = pars3["柄"].ToPar();
			pars4 = pars3["吸盤"].ToPars();
			this.X0Y0_手先_節9_吸盤_吸盤1 = pars4["吸盤1"].ToPar();
			this.X0Y0_手先_節9_吸盤_吸盤2 = pars4["吸盤2"].ToPar();
			this.X0Y0_手先_節9_吸盤_吸盤3 = pars4["吸盤3"].ToPar();
			this.X0Y0_手先_節9_吸盤_吸盤4 = pars4["吸盤4"].ToPar();
			pars4 = pars3["爪"].ToPars();
			this.X0Y0_手先_節9_爪_爪2 = pars4["爪2"].ToPar();
			this.X0Y0_手先_節9_爪_爪1 = pars4["爪1"].ToPar();
			pars3 = pars5["節10"].ToPars();
			this.X0Y0_手先_節10_節 = pars3["節"].ToPar();
			this.X0Y0_手先_節10_紋柄 = pars3["柄"].ToPar();
			pars4 = pars3["吸盤"].ToPars();
			this.X0Y0_手先_節10_吸盤_吸盤1 = pars4["吸盤1"].ToPar();
			this.X0Y0_手先_節10_吸盤_吸盤2 = pars4["吸盤2"].ToPar();
			this.X0Y0_手先_節10_吸盤_吸盤3 = pars4["吸盤3"].ToPar();
			this.X0Y0_手先_節10_吸盤_吸盤4 = pars4["吸盤4"].ToPar();
			pars4 = pars3["爪"].ToPars();
			this.X0Y0_手先_節10_爪_爪2 = pars4["爪2"].ToPar();
			this.X0Y0_手先_節10_爪_爪1 = pars4["爪1"].ToPar();
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
			this.腕部_節1_節_表示 = e.腕部_節1_節_表示;
			this.腕部_節1_紋柄_紋柄1_表示 = e.腕部_節1_紋柄_紋柄1_表示;
			this.腕部_節1_紋柄_紋柄2_表示 = e.腕部_節1_紋柄_紋柄2_表示;
			this.腕部_節2_節_表示 = e.腕部_節2_節_表示;
			this.腕部_節2_紋柄_紋柄1_表示 = e.腕部_節2_紋柄_紋柄1_表示;
			this.腕部_節2_紋柄_紋柄2_表示 = e.腕部_節2_紋柄_紋柄2_表示;
			this.腕部_節3_節_表示 = e.腕部_節3_節_表示;
			this.腕部_節3_紋柄_紋柄1_表示 = e.腕部_節3_紋柄_紋柄1_表示;
			this.腕部_節3_紋柄_紋柄2_表示 = e.腕部_節3_紋柄_紋柄2_表示;
			this.腕部_節4_節_表示 = e.腕部_節4_節_表示;
			this.腕部_節4_紋柄_紋柄1_表示 = e.腕部_節4_紋柄_紋柄1_表示;
			this.腕部_節4_紋柄_紋柄2_表示 = e.腕部_節4_紋柄_紋柄2_表示;
			this.腕部_節5_節_表示 = e.腕部_節5_節_表示;
			this.腕部_節5_紋柄_紋柄1_表示 = e.腕部_節5_紋柄_紋柄1_表示;
			this.腕部_節5_紋柄_紋柄2_表示 = e.腕部_節5_紋柄_紋柄2_表示;
			this.腕部_節6_節_表示 = e.腕部_節6_節_表示;
			this.腕部_節6_紋柄_紋柄1_表示 = e.腕部_節6_紋柄_紋柄1_表示;
			this.腕部_節6_紋柄_紋柄2_表示 = e.腕部_節6_紋柄_紋柄2_表示;
			this.腕部_節7_節_表示 = e.腕部_節7_節_表示;
			this.腕部_節7_紋柄_紋柄1_表示 = e.腕部_節7_紋柄_紋柄1_表示;
			this.腕部_節7_紋柄_紋柄2_表示 = e.腕部_節7_紋柄_紋柄2_表示;
			this.腕部_節8_節_表示 = e.腕部_節8_節_表示;
			this.腕部_節8_紋柄_紋柄1_表示 = e.腕部_節8_紋柄_紋柄1_表示;
			this.腕部_節8_紋柄_紋柄2_表示 = e.腕部_節8_紋柄_紋柄2_表示;
			this.腕部_節9_節_表示 = e.腕部_節9_節_表示;
			this.腕部_節9_紋柄_紋柄1_表示 = e.腕部_節9_紋柄_紋柄1_表示;
			this.腕部_節9_紋柄_紋柄2_表示 = e.腕部_節9_紋柄_紋柄2_表示;
			this.腕部_節10_節_表示 = e.腕部_節10_節_表示;
			this.腕部_節10_紋柄_紋柄1_表示 = e.腕部_節10_紋柄_紋柄1_表示;
			this.腕部_節10_紋柄_紋柄2_表示 = e.腕部_節10_紋柄_紋柄2_表示;
			this.腕部_節11_節_表示 = e.腕部_節11_節_表示;
			this.腕部_節11_紋柄_紋柄1_表示 = e.腕部_節11_紋柄_紋柄1_表示;
			this.腕部_節11_紋柄_紋柄2_表示 = e.腕部_節11_紋柄_紋柄2_表示;
			this.腕部_節12_節_表示 = e.腕部_節12_節_表示;
			this.腕部_節12_紋柄_紋柄1_表示 = e.腕部_節12_紋柄_紋柄1_表示;
			this.腕部_節12_紋柄_紋柄2_表示 = e.腕部_節12_紋柄_紋柄2_表示;
			this.腕部_節13_節_表示 = e.腕部_節13_節_表示;
			this.腕部_節13_紋柄_紋柄1_表示 = e.腕部_節13_紋柄_紋柄1_表示;
			this.腕部_節13_紋柄_紋柄2_表示 = e.腕部_節13_紋柄_紋柄2_表示;
			this.腕部_節14_節_表示 = e.腕部_節14_節_表示;
			this.腕部_節14_紋柄_紋柄1_表示 = e.腕部_節14_紋柄_紋柄1_表示;
			this.腕部_節14_紋柄_紋柄2_表示 = e.腕部_節14_紋柄_紋柄2_表示;
			this.腕部_節15_節_表示 = e.腕部_節15_節_表示;
			this.腕部_節15_紋柄_紋柄1_表示 = e.腕部_節15_紋柄_紋柄1_表示;
			this.腕部_節15_紋柄_紋柄2_表示 = e.腕部_節15_紋柄_紋柄2_表示;
			this.腕部_輪1_革_表示 = e.腕部_輪1_革_表示;
			this.腕部_輪1_金具1_表示 = e.腕部_輪1_金具1_表示;
			this.腕部_輪1_金具2_表示 = e.腕部_輪1_金具2_表示;
			this.腕部_輪1_金具3_表示 = e.腕部_輪1_金具3_表示;
			this.腕部_輪1_金具左_表示 = e.腕部_輪1_金具左_表示;
			this.腕部_輪1_金具右_表示 = e.腕部_輪1_金具右_表示;
			this.腕部_節16_節_表示 = e.腕部_節16_節_表示;
			this.腕部_節16_紋柄_紋柄1_表示 = e.腕部_節16_紋柄_紋柄1_表示;
			this.腕部_節16_紋柄_紋柄2_表示 = e.腕部_節16_紋柄_紋柄2_表示;
			this.腕部_節17_節_表示 = e.腕部_節17_節_表示;
			this.腕部_節17_紋柄_紋柄1_表示 = e.腕部_節17_紋柄_紋柄1_表示;
			this.腕部_節17_紋柄_紋柄2_表示 = e.腕部_節17_紋柄_紋柄2_表示;
			this.腕部_節18_節_表示 = e.腕部_節18_節_表示;
			this.腕部_節18_紋柄_紋柄1_表示 = e.腕部_節18_紋柄_紋柄1_表示;
			this.腕部_節18_紋柄_紋柄2_表示 = e.腕部_節18_紋柄_紋柄2_表示;
			this.腕部_節19_節_表示 = e.腕部_節19_節_表示;
			this.腕部_節19_紋柄_紋柄1_表示 = e.腕部_節19_紋柄_紋柄1_表示;
			this.腕部_節19_紋柄_紋柄2_表示 = e.腕部_節19_紋柄_紋柄2_表示;
			this.腕部_節20_節_表示 = e.腕部_節20_節_表示;
			this.腕部_節20_紋柄_紋柄1_表示 = e.腕部_節20_紋柄_紋柄1_表示;
			this.腕部_節20_紋柄_紋柄2_表示 = e.腕部_節20_紋柄_紋柄2_表示;
			this.腕部_節21_節_表示 = e.腕部_節21_節_表示;
			this.腕部_節21_紋柄_紋柄1_表示 = e.腕部_節21_紋柄_紋柄1_表示;
			this.腕部_節21_紋柄_紋柄2_表示 = e.腕部_節21_紋柄_紋柄2_表示;
			this.腕部_節22_節_表示 = e.腕部_節22_節_表示;
			this.腕部_節22_紋柄_紋柄1_表示 = e.腕部_節22_紋柄_紋柄1_表示;
			this.腕部_節22_紋柄_紋柄2_表示 = e.腕部_節22_紋柄_紋柄2_表示;
			this.腕部_節23_節_表示 = e.腕部_節23_節_表示;
			this.腕部_節23_紋柄_紋柄1_表示 = e.腕部_節23_紋柄_紋柄1_表示;
			this.腕部_節23_紋柄_紋柄2_表示 = e.腕部_節23_紋柄_紋柄2_表示;
			this.腕部_節24_節_表示 = e.腕部_節24_節_表示;
			this.腕部_節24_紋柄_紋柄1_表示 = e.腕部_節24_紋柄_紋柄1_表示;
			this.腕部_節24_紋柄_紋柄2_表示 = e.腕部_節24_紋柄_紋柄2_表示;
			this.腕部_節25_節_表示 = e.腕部_節25_節_表示;
			this.腕部_節25_紋柄_紋柄1_表示 = e.腕部_節25_紋柄_紋柄1_表示;
			this.腕部_節25_紋柄_紋柄2_表示 = e.腕部_節25_紋柄_紋柄2_表示;
			this.手先_節1_節_表示 = e.手先_節1_節_表示;
			this.手先_節1_紋柄1_表示 = e.手先_節1_紋柄1_表示;
			this.手先_節1_紋柄2_表示 = e.手先_節1_紋柄2_表示;
			this.手先_節1_吸盤_吸盤1_表示 = e.手先_節1_吸盤_吸盤1_表示;
			this.手先_節1_吸盤_吸盤2_表示 = e.手先_節1_吸盤_吸盤2_表示;
			this.手先_節1_吸盤_吸盤3_表示 = e.手先_節1_吸盤_吸盤3_表示;
			this.手先_節1_吸盤_吸盤4_表示 = e.手先_節1_吸盤_吸盤4_表示;
			this.手先_節1_爪_爪2_表示 = e.手先_節1_爪_爪2_表示;
			this.手先_節1_爪_爪1_表示 = e.手先_節1_爪_爪1_表示;
			this.手先_輪2_革_表示 = e.手先_輪2_革_表示;
			this.手先_輪2_金具1_表示 = e.手先_輪2_金具1_表示;
			this.手先_輪2_金具2_表示 = e.手先_輪2_金具2_表示;
			this.手先_輪2_金具3_表示 = e.手先_輪2_金具3_表示;
			this.手先_輪2_金具左_表示 = e.手先_輪2_金具左_表示;
			this.手先_輪2_金具右_表示 = e.手先_輪2_金具右_表示;
			this.手先_節2_節_表示 = e.手先_節2_節_表示;
			this.手先_節2_紋柄1_表示 = e.手先_節2_紋柄1_表示;
			this.手先_節2_紋柄2_表示 = e.手先_節2_紋柄2_表示;
			this.手先_節2_吸盤_吸盤1_表示 = e.手先_節2_吸盤_吸盤1_表示;
			this.手先_節2_吸盤_吸盤2_表示 = e.手先_節2_吸盤_吸盤2_表示;
			this.手先_節2_吸盤_吸盤3_表示 = e.手先_節2_吸盤_吸盤3_表示;
			this.手先_節2_吸盤_吸盤4_表示 = e.手先_節2_吸盤_吸盤4_表示;
			this.手先_節2_爪_爪2_表示 = e.手先_節2_爪_爪2_表示;
			this.手先_節2_爪_爪1_表示 = e.手先_節2_爪_爪1_表示;
			this.手先_節3_節_表示 = e.手先_節3_節_表示;
			this.手先_節3_紋柄1_表示 = e.手先_節3_紋柄1_表示;
			this.手先_節3_紋柄2_表示 = e.手先_節3_紋柄2_表示;
			this.手先_節3_吸盤_吸盤1_表示 = e.手先_節3_吸盤_吸盤1_表示;
			this.手先_節3_吸盤_吸盤2_表示 = e.手先_節3_吸盤_吸盤2_表示;
			this.手先_節3_吸盤_吸盤3_表示 = e.手先_節3_吸盤_吸盤3_表示;
			this.手先_節3_吸盤_吸盤4_表示 = e.手先_節3_吸盤_吸盤4_表示;
			this.手先_節3_爪_爪2_表示 = e.手先_節3_爪_爪2_表示;
			this.手先_節3_爪_爪1_表示 = e.手先_節3_爪_爪1_表示;
			this.手先_節4_節_表示 = e.手先_節4_節_表示;
			this.手先_節4_紋柄1_表示 = e.手先_節4_紋柄1_表示;
			this.手先_節4_紋柄2_表示 = e.手先_節4_紋柄2_表示;
			this.手先_節4_吸盤_吸盤1_表示 = e.手先_節4_吸盤_吸盤1_表示;
			this.手先_節4_吸盤_吸盤2_表示 = e.手先_節4_吸盤_吸盤2_表示;
			this.手先_節4_吸盤_吸盤3_表示 = e.手先_節4_吸盤_吸盤3_表示;
			this.手先_節4_吸盤_吸盤4_表示 = e.手先_節4_吸盤_吸盤4_表示;
			this.手先_節4_爪_爪2_表示 = e.手先_節4_爪_爪2_表示;
			this.手先_節4_爪_爪1_表示 = e.手先_節4_爪_爪1_表示;
			this.手先_節5_節_表示 = e.手先_節5_節_表示;
			this.手先_節5_紋柄1_表示 = e.手先_節5_紋柄1_表示;
			this.手先_節5_紋柄2_表示 = e.手先_節5_紋柄2_表示;
			this.手先_節5_吸盤_吸盤1_表示 = e.手先_節5_吸盤_吸盤1_表示;
			this.手先_節5_吸盤_吸盤2_表示 = e.手先_節5_吸盤_吸盤2_表示;
			this.手先_節5_吸盤_吸盤3_表示 = e.手先_節5_吸盤_吸盤3_表示;
			this.手先_節5_吸盤_吸盤4_表示 = e.手先_節5_吸盤_吸盤4_表示;
			this.手先_節5_爪_爪2_表示 = e.手先_節5_爪_爪2_表示;
			this.手先_節5_爪_爪1_表示 = e.手先_節5_爪_爪1_表示;
			this.手先_節6_節_表示 = e.手先_節6_節_表示;
			this.手先_節6_紋柄1_表示 = e.手先_節6_紋柄1_表示;
			this.手先_節6_紋柄2_表示 = e.手先_節6_紋柄2_表示;
			this.手先_節6_吸盤_吸盤1_表示 = e.手先_節6_吸盤_吸盤1_表示;
			this.手先_節6_吸盤_吸盤2_表示 = e.手先_節6_吸盤_吸盤2_表示;
			this.手先_節6_吸盤_吸盤3_表示 = e.手先_節6_吸盤_吸盤3_表示;
			this.手先_節6_吸盤_吸盤4_表示 = e.手先_節6_吸盤_吸盤4_表示;
			this.手先_節6_爪_爪2_表示 = e.手先_節6_爪_爪2_表示;
			this.手先_節6_爪_爪1_表示 = e.手先_節6_爪_爪1_表示;
			this.手先_節7_節_表示 = e.手先_節7_節_表示;
			this.手先_節7_紋柄_表示 = e.手先_節7_紋柄_表示;
			this.手先_節7_吸盤_吸盤1_表示 = e.手先_節7_吸盤_吸盤1_表示;
			this.手先_節7_吸盤_吸盤2_表示 = e.手先_節7_吸盤_吸盤2_表示;
			this.手先_節7_吸盤_吸盤3_表示 = e.手先_節7_吸盤_吸盤3_表示;
			this.手先_節7_吸盤_吸盤4_表示 = e.手先_節7_吸盤_吸盤4_表示;
			this.手先_節7_爪_爪2_表示 = e.手先_節7_爪_爪2_表示;
			this.手先_節7_爪_爪1_表示 = e.手先_節7_爪_爪1_表示;
			this.手先_節8_節_表示 = e.手先_節8_節_表示;
			this.手先_節8_紋柄_表示 = e.手先_節8_紋柄_表示;
			this.手先_節8_吸盤_吸盤1_表示 = e.手先_節8_吸盤_吸盤1_表示;
			this.手先_節8_吸盤_吸盤2_表示 = e.手先_節8_吸盤_吸盤2_表示;
			this.手先_節8_吸盤_吸盤3_表示 = e.手先_節8_吸盤_吸盤3_表示;
			this.手先_節8_吸盤_吸盤4_表示 = e.手先_節8_吸盤_吸盤4_表示;
			this.手先_節8_爪_爪2_表示 = e.手先_節8_爪_爪2_表示;
			this.手先_節8_爪_爪1_表示 = e.手先_節8_爪_爪1_表示;
			this.手先_節9_節_表示 = e.手先_節9_節_表示;
			this.手先_節9_紋柄_表示 = e.手先_節9_紋柄_表示;
			this.手先_節9_吸盤_吸盤1_表示 = e.手先_節9_吸盤_吸盤1_表示;
			this.手先_節9_吸盤_吸盤2_表示 = e.手先_節9_吸盤_吸盤2_表示;
			this.手先_節9_吸盤_吸盤3_表示 = e.手先_節9_吸盤_吸盤3_表示;
			this.手先_節9_吸盤_吸盤4_表示 = e.手先_節9_吸盤_吸盤4_表示;
			this.手先_節9_爪_爪2_表示 = e.手先_節9_爪_爪2_表示;
			this.手先_節9_爪_爪1_表示 = e.手先_節9_爪_爪1_表示;
			this.手先_節10_節_表示 = e.手先_節10_節_表示;
			this.手先_節10_紋柄_表示 = e.手先_節10_紋柄_表示;
			this.手先_節10_吸盤_吸盤1_表示 = e.手先_節10_吸盤_吸盤1_表示;
			this.手先_節10_吸盤_吸盤2_表示 = e.手先_節10_吸盤_吸盤2_表示;
			this.手先_節10_吸盤_吸盤3_表示 = e.手先_節10_吸盤_吸盤3_表示;
			this.手先_節10_吸盤_吸盤4_表示 = e.手先_節10_吸盤_吸盤4_表示;
			this.手先_節10_爪_爪2_表示 = e.手先_節10_爪_爪2_表示;
			this.手先_節10_爪_爪1_表示 = e.手先_節10_爪_爪1_表示;
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
			this.Pars = new Par[]
			{
				this.X0Y0_腕部_節1_節,
				this.X0Y0_腕部_節2_節,
				this.X0Y0_腕部_節3_節,
				this.X0Y0_腕部_節4_節,
				this.X0Y0_腕部_節5_節,
				this.X0Y0_腕部_節6_節,
				this.X0Y0_腕部_節7_節,
				this.X0Y0_腕部_節8_節,
				this.X0Y0_腕部_節9_節,
				this.X0Y0_腕部_節10_節,
				this.X0Y0_腕部_節11_節,
				this.X0Y0_腕部_節12_節,
				this.X0Y0_腕部_節13_節,
				this.X0Y0_腕部_節14_節,
				this.X0Y0_腕部_節15_節,
				this.X0Y0_腕部_節16_節,
				this.X0Y0_腕部_節17_節,
				this.X0Y0_腕部_節18_節,
				this.X0Y0_腕部_節19_節,
				this.X0Y0_腕部_節20_節,
				this.X0Y0_腕部_節21_節,
				this.X0Y0_腕部_節22_節,
				this.X0Y0_腕部_節23_節,
				this.X0Y0_腕部_節24_節,
				this.X0Y0_腕部_節25_節,
				this.X0Y0_手先_節1_節,
				this.X0Y0_手先_節2_節,
				this.X0Y0_手先_節3_節,
				this.X0Y0_手先_節4_節,
				this.X0Y0_手先_節5_節,
				this.X0Y0_手先_節6_節,
				this.X0Y0_手先_節7_節,
				this.X0Y0_手先_節8_節,
				this.X0Y0_手先_節9_節,
				this.X0Y0_手先_節10_節
			};
			this.X0Y0_腕部_節1_節CP = new ColorP(this.X0Y0_腕部_節1_節, this.腕部_節1_節CD, DisUnit, true);
			this.X0Y0_腕部_節1_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節1_紋柄_紋柄1, this.腕部_節1_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節1_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節1_紋柄_紋柄2, this.腕部_節1_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_節2_節CP = new ColorP(this.X0Y0_腕部_節2_節, this.腕部_節2_節CD, DisUnit, true);
			this.X0Y0_腕部_節2_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節2_紋柄_紋柄1, this.腕部_節2_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節2_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節2_紋柄_紋柄2, this.腕部_節2_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_節3_節CP = new ColorP(this.X0Y0_腕部_節3_節, this.腕部_節3_節CD, DisUnit, true);
			this.X0Y0_腕部_節3_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節3_紋柄_紋柄1, this.腕部_節3_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節3_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節3_紋柄_紋柄2, this.腕部_節3_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_節4_節CP = new ColorP(this.X0Y0_腕部_節4_節, this.腕部_節4_節CD, DisUnit, true);
			this.X0Y0_腕部_節4_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節4_紋柄_紋柄1, this.腕部_節4_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節4_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節4_紋柄_紋柄2, this.腕部_節4_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_節5_節CP = new ColorP(this.X0Y0_腕部_節5_節, this.腕部_節5_節CD, DisUnit, true);
			this.X0Y0_腕部_節5_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節5_紋柄_紋柄1, this.腕部_節5_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節5_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節5_紋柄_紋柄2, this.腕部_節5_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_節6_節CP = new ColorP(this.X0Y0_腕部_節6_節, this.腕部_節6_節CD, DisUnit, true);
			this.X0Y0_腕部_節6_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節6_紋柄_紋柄1, this.腕部_節6_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節6_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節6_紋柄_紋柄2, this.腕部_節6_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_節7_節CP = new ColorP(this.X0Y0_腕部_節7_節, this.腕部_節7_節CD, DisUnit, true);
			this.X0Y0_腕部_節7_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節7_紋柄_紋柄1, this.腕部_節7_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節7_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節7_紋柄_紋柄2, this.腕部_節7_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_節8_節CP = new ColorP(this.X0Y0_腕部_節8_節, this.腕部_節8_節CD, DisUnit, true);
			this.X0Y0_腕部_節8_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節8_紋柄_紋柄1, this.腕部_節8_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節8_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節8_紋柄_紋柄2, this.腕部_節8_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_節9_節CP = new ColorP(this.X0Y0_腕部_節9_節, this.腕部_節9_節CD, DisUnit, true);
			this.X0Y0_腕部_節9_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節9_紋柄_紋柄1, this.腕部_節9_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節9_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節9_紋柄_紋柄2, this.腕部_節9_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_節10_節CP = new ColorP(this.X0Y0_腕部_節10_節, this.腕部_節10_節CD, DisUnit, true);
			this.X0Y0_腕部_節10_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節10_紋柄_紋柄1, this.腕部_節10_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節10_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節10_紋柄_紋柄2, this.腕部_節10_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_節11_節CP = new ColorP(this.X0Y0_腕部_節11_節, this.腕部_節11_節CD, DisUnit, true);
			this.X0Y0_腕部_節11_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節11_紋柄_紋柄1, this.腕部_節11_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節11_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節11_紋柄_紋柄2, this.腕部_節11_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_節12_節CP = new ColorP(this.X0Y0_腕部_節12_節, this.腕部_節12_節CD, DisUnit, true);
			this.X0Y0_腕部_節12_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節12_紋柄_紋柄1, this.腕部_節12_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節12_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節12_紋柄_紋柄2, this.腕部_節12_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_節13_節CP = new ColorP(this.X0Y0_腕部_節13_節, this.腕部_節13_節CD, DisUnit, true);
			this.X0Y0_腕部_節13_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節13_紋柄_紋柄1, this.腕部_節13_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節13_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節13_紋柄_紋柄2, this.腕部_節13_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_節14_節CP = new ColorP(this.X0Y0_腕部_節14_節, this.腕部_節14_節CD, DisUnit, true);
			this.X0Y0_腕部_節14_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節14_紋柄_紋柄1, this.腕部_節14_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節14_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節14_紋柄_紋柄2, this.腕部_節14_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_節15_節CP = new ColorP(this.X0Y0_腕部_節15_節, this.腕部_節15_節CD, DisUnit, true);
			this.X0Y0_腕部_節15_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節15_紋柄_紋柄1, this.腕部_節15_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節15_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節15_紋柄_紋柄2, this.腕部_節15_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_輪1_革CP = new ColorP(this.X0Y0_腕部_輪1_革, this.腕部_輪1_革CD, DisUnit, true);
			this.X0Y0_腕部_輪1_金具1CP = new ColorP(this.X0Y0_腕部_輪1_金具1, this.腕部_輪1_金具1CD, DisUnit, true);
			this.X0Y0_腕部_輪1_金具2CP = new ColorP(this.X0Y0_腕部_輪1_金具2, this.腕部_輪1_金具2CD, DisUnit, true);
			this.X0Y0_腕部_輪1_金具3CP = new ColorP(this.X0Y0_腕部_輪1_金具3, this.腕部_輪1_金具3CD, DisUnit, true);
			this.X0Y0_腕部_輪1_金具左CP = new ColorP(this.X0Y0_腕部_輪1_金具左, this.腕部_輪1_金具左CD, DisUnit, true);
			this.X0Y0_腕部_輪1_金具右CP = new ColorP(this.X0Y0_腕部_輪1_金具右, this.腕部_輪1_金具右CD, DisUnit, true);
			this.X0Y0_腕部_節16_節CP = new ColorP(this.X0Y0_腕部_節16_節, this.腕部_節16_節CD, DisUnit, true);
			this.X0Y0_腕部_節16_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節16_紋柄_紋柄1, this.腕部_節16_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節16_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節16_紋柄_紋柄2, this.腕部_節16_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_節17_節CP = new ColorP(this.X0Y0_腕部_節17_節, this.腕部_節17_節CD, DisUnit, true);
			this.X0Y0_腕部_節17_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節17_紋柄_紋柄1, this.腕部_節17_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節17_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節17_紋柄_紋柄2, this.腕部_節17_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_節18_節CP = new ColorP(this.X0Y0_腕部_節18_節, this.腕部_節18_節CD, DisUnit, true);
			this.X0Y0_腕部_節18_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節18_紋柄_紋柄1, this.腕部_節18_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節18_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節18_紋柄_紋柄2, this.腕部_節18_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_節19_節CP = new ColorP(this.X0Y0_腕部_節19_節, this.腕部_節19_節CD, DisUnit, true);
			this.X0Y0_腕部_節19_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節19_紋柄_紋柄1, this.腕部_節19_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節19_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節19_紋柄_紋柄2, this.腕部_節19_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_節20_節CP = new ColorP(this.X0Y0_腕部_節20_節, this.腕部_節20_節CD, DisUnit, true);
			this.X0Y0_腕部_節20_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節20_紋柄_紋柄1, this.腕部_節20_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節20_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節20_紋柄_紋柄2, this.腕部_節20_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_節21_節CP = new ColorP(this.X0Y0_腕部_節21_節, this.腕部_節21_節CD, DisUnit, true);
			this.X0Y0_腕部_節21_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節21_紋柄_紋柄1, this.腕部_節21_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節21_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節21_紋柄_紋柄2, this.腕部_節21_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_節22_節CP = new ColorP(this.X0Y0_腕部_節22_節, this.腕部_節22_節CD, DisUnit, true);
			this.X0Y0_腕部_節22_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節22_紋柄_紋柄1, this.腕部_節22_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節22_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節22_紋柄_紋柄2, this.腕部_節22_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_節23_節CP = new ColorP(this.X0Y0_腕部_節23_節, this.腕部_節23_節CD, DisUnit, true);
			this.X0Y0_腕部_節23_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節23_紋柄_紋柄1, this.腕部_節23_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節23_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節23_紋柄_紋柄2, this.腕部_節23_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_節24_節CP = new ColorP(this.X0Y0_腕部_節24_節, this.腕部_節24_節CD, DisUnit, true);
			this.X0Y0_腕部_節24_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節24_紋柄_紋柄1, this.腕部_節24_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節24_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節24_紋柄_紋柄2, this.腕部_節24_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_腕部_節25_節CP = new ColorP(this.X0Y0_腕部_節25_節, this.腕部_節25_節CD, DisUnit, true);
			this.X0Y0_腕部_節25_紋柄_紋柄1CP = new ColorP(this.X0Y0_腕部_節25_紋柄_紋柄1, this.腕部_節25_紋柄_紋柄1CD, DisUnit, true);
			this.X0Y0_腕部_節25_紋柄_紋柄2CP = new ColorP(this.X0Y0_腕部_節25_紋柄_紋柄2, this.腕部_節25_紋柄_紋柄2CD, DisUnit, true);
			this.X0Y0_手先_節1_節CP = new ColorP(this.X0Y0_手先_節1_節, this.手先_節1_節CD, DisUnit, true);
			this.X0Y0_手先_節1_紋柄1CP = new ColorP(this.X0Y0_手先_節1_紋柄1, this.手先_節1_紋柄1CD, DisUnit, true);
			this.X0Y0_手先_節1_紋柄2CP = new ColorP(this.X0Y0_手先_節1_紋柄2, this.手先_節1_紋柄2CD, DisUnit, true);
			this.X0Y0_手先_節1_吸盤_吸盤1CP = new ColorP(this.X0Y0_手先_節1_吸盤_吸盤1, this.手先_節1_吸盤_吸盤1CD, DisUnit, true);
			this.X0Y0_手先_節1_吸盤_吸盤2CP = new ColorP(this.X0Y0_手先_節1_吸盤_吸盤2, this.手先_節1_吸盤_吸盤2CD, DisUnit, true);
			this.X0Y0_手先_節1_吸盤_吸盤3CP = new ColorP(this.X0Y0_手先_節1_吸盤_吸盤3, this.手先_節1_吸盤_吸盤3CD, DisUnit, true);
			this.X0Y0_手先_節1_吸盤_吸盤4CP = new ColorP(this.X0Y0_手先_節1_吸盤_吸盤4, this.手先_節1_吸盤_吸盤4CD, DisUnit, true);
			this.X0Y0_手先_節1_爪_爪2CP = new ColorP(this.X0Y0_手先_節1_爪_爪2, this.手先_節1_爪_爪2CD, DisUnit, true);
			this.X0Y0_手先_節1_爪_爪1CP = new ColorP(this.X0Y0_手先_節1_爪_爪1, this.手先_節1_爪_爪1CD, DisUnit, true);
			this.X0Y0_手先_輪2_革CP = new ColorP(this.X0Y0_手先_輪2_革, this.手先_輪2_革CD, DisUnit, true);
			this.X0Y0_手先_輪2_金具1CP = new ColorP(this.X0Y0_手先_輪2_金具1, this.手先_輪2_金具1CD, DisUnit, true);
			this.X0Y0_手先_輪2_金具2CP = new ColorP(this.X0Y0_手先_輪2_金具2, this.手先_輪2_金具2CD, DisUnit, true);
			this.X0Y0_手先_輪2_金具3CP = new ColorP(this.X0Y0_手先_輪2_金具3, this.手先_輪2_金具3CD, DisUnit, true);
			this.X0Y0_手先_輪2_金具左CP = new ColorP(this.X0Y0_手先_輪2_金具左, this.手先_輪2_金具左CD, DisUnit, true);
			this.X0Y0_手先_輪2_金具右CP = new ColorP(this.X0Y0_手先_輪2_金具右, this.手先_輪2_金具右CD, DisUnit, true);
			this.X0Y0_手先_節2_節CP = new ColorP(this.X0Y0_手先_節2_節, this.手先_節2_節CD, DisUnit, true);
			this.X0Y0_手先_節2_紋柄1CP = new ColorP(this.X0Y0_手先_節2_紋柄1, this.手先_節2_紋柄1CD, DisUnit, true);
			this.X0Y0_手先_節2_紋柄2CP = new ColorP(this.X0Y0_手先_節2_紋柄2, this.手先_節2_紋柄2CD, DisUnit, true);
			this.X0Y0_手先_節2_吸盤_吸盤1CP = new ColorP(this.X0Y0_手先_節2_吸盤_吸盤1, this.手先_節2_吸盤_吸盤1CD, DisUnit, true);
			this.X0Y0_手先_節2_吸盤_吸盤2CP = new ColorP(this.X0Y0_手先_節2_吸盤_吸盤2, this.手先_節2_吸盤_吸盤2CD, DisUnit, true);
			this.X0Y0_手先_節2_吸盤_吸盤3CP = new ColorP(this.X0Y0_手先_節2_吸盤_吸盤3, this.手先_節2_吸盤_吸盤3CD, DisUnit, true);
			this.X0Y0_手先_節2_吸盤_吸盤4CP = new ColorP(this.X0Y0_手先_節2_吸盤_吸盤4, this.手先_節2_吸盤_吸盤4CD, DisUnit, true);
			this.X0Y0_手先_節2_爪_爪2CP = new ColorP(this.X0Y0_手先_節2_爪_爪2, this.手先_節2_爪_爪2CD, DisUnit, true);
			this.X0Y0_手先_節2_爪_爪1CP = new ColorP(this.X0Y0_手先_節2_爪_爪1, this.手先_節2_爪_爪1CD, DisUnit, true);
			this.X0Y0_手先_節3_節CP = new ColorP(this.X0Y0_手先_節3_節, this.手先_節3_節CD, DisUnit, true);
			this.X0Y0_手先_節3_紋柄1CP = new ColorP(this.X0Y0_手先_節3_紋柄1, this.手先_節3_紋柄1CD, DisUnit, true);
			this.X0Y0_手先_節3_紋柄2CP = new ColorP(this.X0Y0_手先_節3_紋柄2, this.手先_節3_紋柄2CD, DisUnit, true);
			this.X0Y0_手先_節3_吸盤_吸盤1CP = new ColorP(this.X0Y0_手先_節3_吸盤_吸盤1, this.手先_節3_吸盤_吸盤1CD, DisUnit, true);
			this.X0Y0_手先_節3_吸盤_吸盤2CP = new ColorP(this.X0Y0_手先_節3_吸盤_吸盤2, this.手先_節3_吸盤_吸盤2CD, DisUnit, true);
			this.X0Y0_手先_節3_吸盤_吸盤3CP = new ColorP(this.X0Y0_手先_節3_吸盤_吸盤3, this.手先_節3_吸盤_吸盤3CD, DisUnit, true);
			this.X0Y0_手先_節3_吸盤_吸盤4CP = new ColorP(this.X0Y0_手先_節3_吸盤_吸盤4, this.手先_節3_吸盤_吸盤4CD, DisUnit, true);
			this.X0Y0_手先_節3_爪_爪2CP = new ColorP(this.X0Y0_手先_節3_爪_爪2, this.手先_節3_爪_爪2CD, DisUnit, true);
			this.X0Y0_手先_節3_爪_爪1CP = new ColorP(this.X0Y0_手先_節3_爪_爪1, this.手先_節3_爪_爪1CD, DisUnit, true);
			this.X0Y0_手先_節4_節CP = new ColorP(this.X0Y0_手先_節4_節, this.手先_節4_節CD, DisUnit, true);
			this.X0Y0_手先_節4_紋柄1CP = new ColorP(this.X0Y0_手先_節4_紋柄1, this.手先_節4_紋柄1CD, DisUnit, true);
			this.X0Y0_手先_節4_紋柄2CP = new ColorP(this.X0Y0_手先_節4_紋柄2, this.手先_節4_紋柄2CD, DisUnit, true);
			this.X0Y0_手先_節4_吸盤_吸盤1CP = new ColorP(this.X0Y0_手先_節4_吸盤_吸盤1, this.手先_節4_吸盤_吸盤1CD, DisUnit, true);
			this.X0Y0_手先_節4_吸盤_吸盤2CP = new ColorP(this.X0Y0_手先_節4_吸盤_吸盤2, this.手先_節4_吸盤_吸盤2CD, DisUnit, true);
			this.X0Y0_手先_節4_吸盤_吸盤3CP = new ColorP(this.X0Y0_手先_節4_吸盤_吸盤3, this.手先_節4_吸盤_吸盤3CD, DisUnit, true);
			this.X0Y0_手先_節4_吸盤_吸盤4CP = new ColorP(this.X0Y0_手先_節4_吸盤_吸盤4, this.手先_節4_吸盤_吸盤4CD, DisUnit, true);
			this.X0Y0_手先_節4_爪_爪2CP = new ColorP(this.X0Y0_手先_節4_爪_爪2, this.手先_節4_爪_爪2CD, DisUnit, true);
			this.X0Y0_手先_節4_爪_爪1CP = new ColorP(this.X0Y0_手先_節4_爪_爪1, this.手先_節4_爪_爪1CD, DisUnit, true);
			this.X0Y0_手先_節5_節CP = new ColorP(this.X0Y0_手先_節5_節, this.手先_節5_節CD, DisUnit, true);
			this.X0Y0_手先_節5_紋柄1CP = new ColorP(this.X0Y0_手先_節5_紋柄1, this.手先_節5_紋柄1CD, DisUnit, true);
			this.X0Y0_手先_節5_紋柄2CP = new ColorP(this.X0Y0_手先_節5_紋柄2, this.手先_節5_紋柄2CD, DisUnit, true);
			this.X0Y0_手先_節5_吸盤_吸盤1CP = new ColorP(this.X0Y0_手先_節5_吸盤_吸盤1, this.手先_節5_吸盤_吸盤1CD, DisUnit, true);
			this.X0Y0_手先_節5_吸盤_吸盤2CP = new ColorP(this.X0Y0_手先_節5_吸盤_吸盤2, this.手先_節5_吸盤_吸盤2CD, DisUnit, true);
			this.X0Y0_手先_節5_吸盤_吸盤3CP = new ColorP(this.X0Y0_手先_節5_吸盤_吸盤3, this.手先_節5_吸盤_吸盤3CD, DisUnit, true);
			this.X0Y0_手先_節5_吸盤_吸盤4CP = new ColorP(this.X0Y0_手先_節5_吸盤_吸盤4, this.手先_節5_吸盤_吸盤4CD, DisUnit, true);
			this.X0Y0_手先_節5_爪_爪2CP = new ColorP(this.X0Y0_手先_節5_爪_爪2, this.手先_節5_爪_爪2CD, DisUnit, true);
			this.X0Y0_手先_節5_爪_爪1CP = new ColorP(this.X0Y0_手先_節5_爪_爪1, this.手先_節5_爪_爪1CD, DisUnit, true);
			this.X0Y0_手先_節6_節CP = new ColorP(this.X0Y0_手先_節6_節, this.手先_節6_節CD, DisUnit, true);
			this.X0Y0_手先_節6_紋柄1CP = new ColorP(this.X0Y0_手先_節6_紋柄1, this.手先_節6_紋柄1CD, DisUnit, true);
			this.X0Y0_手先_節6_紋柄2CP = new ColorP(this.X0Y0_手先_節6_紋柄2, this.手先_節6_紋柄2CD, DisUnit, true);
			this.X0Y0_手先_節6_吸盤_吸盤1CP = new ColorP(this.X0Y0_手先_節6_吸盤_吸盤1, this.手先_節6_吸盤_吸盤1CD, DisUnit, true);
			this.X0Y0_手先_節6_吸盤_吸盤2CP = new ColorP(this.X0Y0_手先_節6_吸盤_吸盤2, this.手先_節6_吸盤_吸盤2CD, DisUnit, true);
			this.X0Y0_手先_節6_吸盤_吸盤3CP = new ColorP(this.X0Y0_手先_節6_吸盤_吸盤3, this.手先_節6_吸盤_吸盤3CD, DisUnit, true);
			this.X0Y0_手先_節6_吸盤_吸盤4CP = new ColorP(this.X0Y0_手先_節6_吸盤_吸盤4, this.手先_節6_吸盤_吸盤4CD, DisUnit, true);
			this.X0Y0_手先_節6_爪_爪2CP = new ColorP(this.X0Y0_手先_節6_爪_爪2, this.手先_節6_爪_爪2CD, DisUnit, true);
			this.X0Y0_手先_節6_爪_爪1CP = new ColorP(this.X0Y0_手先_節6_爪_爪1, this.手先_節6_爪_爪1CD, DisUnit, true);
			this.X0Y0_手先_節7_節CP = new ColorP(this.X0Y0_手先_節7_節, this.手先_節7_節CD, DisUnit, true);
			this.X0Y0_手先_節7_紋柄CP = new ColorP(this.X0Y0_手先_節7_紋柄, this.手先_節7_紋柄CD, DisUnit, true);
			this.X0Y0_手先_節7_吸盤_吸盤1CP = new ColorP(this.X0Y0_手先_節7_吸盤_吸盤1, this.手先_節7_吸盤_吸盤1CD, DisUnit, true);
			this.X0Y0_手先_節7_吸盤_吸盤2CP = new ColorP(this.X0Y0_手先_節7_吸盤_吸盤2, this.手先_節7_吸盤_吸盤2CD, DisUnit, true);
			this.X0Y0_手先_節7_吸盤_吸盤3CP = new ColorP(this.X0Y0_手先_節7_吸盤_吸盤3, this.手先_節7_吸盤_吸盤3CD, DisUnit, true);
			this.X0Y0_手先_節7_吸盤_吸盤4CP = new ColorP(this.X0Y0_手先_節7_吸盤_吸盤4, this.手先_節7_吸盤_吸盤4CD, DisUnit, true);
			this.X0Y0_手先_節7_爪_爪2CP = new ColorP(this.X0Y0_手先_節7_爪_爪2, this.手先_節7_爪_爪2CD, DisUnit, true);
			this.X0Y0_手先_節7_爪_爪1CP = new ColorP(this.X0Y0_手先_節7_爪_爪1, this.手先_節7_爪_爪1CD, DisUnit, true);
			this.X0Y0_手先_節8_節CP = new ColorP(this.X0Y0_手先_節8_節, this.手先_節8_節CD, DisUnit, true);
			this.X0Y0_手先_節8_紋柄CP = new ColorP(this.X0Y0_手先_節8_紋柄, this.手先_節8_紋柄CD, DisUnit, true);
			this.X0Y0_手先_節8_吸盤_吸盤1CP = new ColorP(this.X0Y0_手先_節8_吸盤_吸盤1, this.手先_節8_吸盤_吸盤1CD, DisUnit, true);
			this.X0Y0_手先_節8_吸盤_吸盤2CP = new ColorP(this.X0Y0_手先_節8_吸盤_吸盤2, this.手先_節8_吸盤_吸盤2CD, DisUnit, true);
			this.X0Y0_手先_節8_吸盤_吸盤3CP = new ColorP(this.X0Y0_手先_節8_吸盤_吸盤3, this.手先_節8_吸盤_吸盤3CD, DisUnit, true);
			this.X0Y0_手先_節8_吸盤_吸盤4CP = new ColorP(this.X0Y0_手先_節8_吸盤_吸盤4, this.手先_節8_吸盤_吸盤4CD, DisUnit, true);
			this.X0Y0_手先_節8_爪_爪2CP = new ColorP(this.X0Y0_手先_節8_爪_爪2, this.手先_節8_爪_爪2CD, DisUnit, true);
			this.X0Y0_手先_節8_爪_爪1CP = new ColorP(this.X0Y0_手先_節8_爪_爪1, this.手先_節8_爪_爪1CD, DisUnit, true);
			this.X0Y0_手先_節9_節CP = new ColorP(this.X0Y0_手先_節9_節, this.手先_節9_節CD, DisUnit, true);
			this.X0Y0_手先_節9_紋柄CP = new ColorP(this.X0Y0_手先_節9_紋柄, this.手先_節9_紋柄CD, DisUnit, true);
			this.X0Y0_手先_節9_吸盤_吸盤1CP = new ColorP(this.X0Y0_手先_節9_吸盤_吸盤1, this.手先_節9_吸盤_吸盤1CD, DisUnit, true);
			this.X0Y0_手先_節9_吸盤_吸盤2CP = new ColorP(this.X0Y0_手先_節9_吸盤_吸盤2, this.手先_節9_吸盤_吸盤2CD, DisUnit, true);
			this.X0Y0_手先_節9_吸盤_吸盤3CP = new ColorP(this.X0Y0_手先_節9_吸盤_吸盤3, this.手先_節9_吸盤_吸盤3CD, DisUnit, true);
			this.X0Y0_手先_節9_吸盤_吸盤4CP = new ColorP(this.X0Y0_手先_節9_吸盤_吸盤4, this.手先_節9_吸盤_吸盤4CD, DisUnit, true);
			this.X0Y0_手先_節9_爪_爪2CP = new ColorP(this.X0Y0_手先_節9_爪_爪2, this.手先_節9_爪_爪2CD, DisUnit, true);
			this.X0Y0_手先_節9_爪_爪1CP = new ColorP(this.X0Y0_手先_節9_爪_爪1, this.手先_節9_爪_爪1CD, DisUnit, true);
			this.X0Y0_手先_節10_節CP = new ColorP(this.X0Y0_手先_節10_節, this.手先_節10_節CD, DisUnit, true);
			this.X0Y0_手先_節10_紋柄CP = new ColorP(this.X0Y0_手先_節10_紋柄, this.手先_節10_紋柄CD, DisUnit, true);
			this.X0Y0_手先_節10_吸盤_吸盤1CP = new ColorP(this.X0Y0_手先_節10_吸盤_吸盤1, this.手先_節10_吸盤_吸盤1CD, DisUnit, true);
			this.X0Y0_手先_節10_吸盤_吸盤2CP = new ColorP(this.X0Y0_手先_節10_吸盤_吸盤2, this.手先_節10_吸盤_吸盤2CD, DisUnit, true);
			this.X0Y0_手先_節10_吸盤_吸盤3CP = new ColorP(this.X0Y0_手先_節10_吸盤_吸盤3, this.手先_節10_吸盤_吸盤3CD, DisUnit, true);
			this.X0Y0_手先_節10_吸盤_吸盤4CP = new ColorP(this.X0Y0_手先_節10_吸盤_吸盤4, this.手先_節10_吸盤_吸盤4CD, DisUnit, true);
			this.X0Y0_手先_節10_爪_爪2CP = new ColorP(this.X0Y0_手先_節10_爪_爪2, this.手先_節10_爪_爪2CD, DisUnit, true);
			this.X0Y0_手先_節10_爪_爪1CP = new ColorP(this.X0Y0_手先_節10_爪_爪1, this.手先_節10_爪_爪1CD, DisUnit, true);
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

		public bool 腕部_節1_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節1_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節1_節.Dra = value;
				this.X0Y0_腕部_節1_節.Hit = value;
			}
		}

		public bool 腕部_節1_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節1_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節1_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節1_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節1_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節1_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節1_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節1_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_節2_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節2_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節2_節.Dra = value;
				this.X0Y0_腕部_節2_節.Hit = value;
			}
		}

		public bool 腕部_節2_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節2_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節2_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節2_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節2_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節2_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節2_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節2_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_節3_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節3_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節3_節.Dra = value;
				this.X0Y0_腕部_節3_節.Hit = value;
			}
		}

		public bool 腕部_節3_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節3_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節3_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節3_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節3_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節3_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節3_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節3_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_節4_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節4_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節4_節.Dra = value;
				this.X0Y0_腕部_節4_節.Hit = value;
			}
		}

		public bool 腕部_節4_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節4_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節4_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節4_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節4_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節4_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節4_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節4_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_節5_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節5_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節5_節.Dra = value;
				this.X0Y0_腕部_節5_節.Hit = value;
			}
		}

		public bool 腕部_節5_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節5_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節5_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節5_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節5_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節5_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節5_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節5_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_節6_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節6_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節6_節.Dra = value;
				this.X0Y0_腕部_節6_節.Hit = value;
			}
		}

		public bool 腕部_節6_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節6_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節6_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節6_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節6_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節6_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節6_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節6_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_節7_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節7_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節7_節.Dra = value;
				this.X0Y0_腕部_節7_節.Hit = value;
			}
		}

		public bool 腕部_節7_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節7_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節7_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節7_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節7_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節7_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節7_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節7_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_節8_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節8_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節8_節.Dra = value;
				this.X0Y0_腕部_節8_節.Hit = value;
			}
		}

		public bool 腕部_節8_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節8_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節8_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節8_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節8_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節8_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節8_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節8_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_節9_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節9_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節9_節.Dra = value;
				this.X0Y0_腕部_節9_節.Hit = value;
			}
		}

		public bool 腕部_節9_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節9_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節9_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節9_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節9_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節9_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節9_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節9_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_節10_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節10_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節10_節.Dra = value;
				this.X0Y0_腕部_節10_節.Hit = value;
			}
		}

		public bool 腕部_節10_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節10_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節10_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節10_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節10_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節10_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節10_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節10_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_節11_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節11_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節11_節.Dra = value;
				this.X0Y0_腕部_節11_節.Hit = value;
			}
		}

		public bool 腕部_節11_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節11_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節11_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節11_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節11_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節11_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節11_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節11_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_節12_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節12_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節12_節.Dra = value;
				this.X0Y0_腕部_節12_節.Hit = value;
			}
		}

		public bool 腕部_節12_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節12_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節12_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節12_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節12_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節12_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節12_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節12_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_節13_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節13_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節13_節.Dra = value;
				this.X0Y0_腕部_節13_節.Hit = value;
			}
		}

		public bool 腕部_節13_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節13_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節13_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節13_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節13_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節13_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節13_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節13_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_節14_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節14_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節14_節.Dra = value;
				this.X0Y0_腕部_節14_節.Hit = value;
			}
		}

		public bool 腕部_節14_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節14_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節14_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節14_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節14_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節14_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節14_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節14_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_節15_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節15_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節15_節.Dra = value;
				this.X0Y0_腕部_節15_節.Hit = value;
			}
		}

		public bool 腕部_節15_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節15_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節15_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節15_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節15_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節15_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節15_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節15_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_輪1_革_表示
		{
			get
			{
				return this.X0Y0_腕部_輪1_革.Dra;
			}
			set
			{
				this.X0Y0_腕部_輪1_革.Dra = value;
				this.X0Y0_腕部_輪1_革.Hit = value;
			}
		}

		public bool 腕部_輪1_金具1_表示
		{
			get
			{
				return this.X0Y0_腕部_輪1_金具1.Dra;
			}
			set
			{
				this.X0Y0_腕部_輪1_金具1.Dra = value;
				this.X0Y0_腕部_輪1_金具1.Hit = value;
			}
		}

		public bool 腕部_輪1_金具2_表示
		{
			get
			{
				return this.X0Y0_腕部_輪1_金具2.Dra;
			}
			set
			{
				this.X0Y0_腕部_輪1_金具2.Dra = value;
				this.X0Y0_腕部_輪1_金具2.Hit = value;
			}
		}

		public bool 腕部_輪1_金具3_表示
		{
			get
			{
				return this.X0Y0_腕部_輪1_金具3.Dra;
			}
			set
			{
				this.X0Y0_腕部_輪1_金具3.Dra = value;
				this.X0Y0_腕部_輪1_金具3.Hit = value;
			}
		}

		public bool 腕部_輪1_金具左_表示
		{
			get
			{
				return this.X0Y0_腕部_輪1_金具左.Dra;
			}
			set
			{
				this.X0Y0_腕部_輪1_金具左.Dra = value;
				this.X0Y0_腕部_輪1_金具左.Hit = value;
			}
		}

		public bool 腕部_輪1_金具右_表示
		{
			get
			{
				return this.X0Y0_腕部_輪1_金具右.Dra;
			}
			set
			{
				this.X0Y0_腕部_輪1_金具右.Dra = value;
				this.X0Y0_腕部_輪1_金具右.Hit = value;
			}
		}

		public bool 腕部_節16_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節16_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節16_節.Dra = value;
				this.X0Y0_腕部_節16_節.Hit = value;
			}
		}

		public bool 腕部_節16_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節16_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節16_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節16_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節16_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節16_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節16_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節16_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_節17_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節17_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節17_節.Dra = value;
				this.X0Y0_腕部_節17_節.Hit = value;
			}
		}

		public bool 腕部_節17_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節17_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節17_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節17_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節17_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節17_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節17_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節17_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_節18_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節18_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節18_節.Dra = value;
				this.X0Y0_腕部_節18_節.Hit = value;
			}
		}

		public bool 腕部_節18_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節18_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節18_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節18_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節18_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節18_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節18_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節18_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_節19_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節19_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節19_節.Dra = value;
				this.X0Y0_腕部_節19_節.Hit = value;
			}
		}

		public bool 腕部_節19_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節19_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節19_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節19_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節19_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節19_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節19_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節19_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_節20_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節20_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節20_節.Dra = value;
				this.X0Y0_腕部_節20_節.Hit = value;
			}
		}

		public bool 腕部_節20_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節20_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節20_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節20_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節20_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節20_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節20_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節20_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_節21_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節21_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節21_節.Dra = value;
				this.X0Y0_腕部_節21_節.Hit = value;
			}
		}

		public bool 腕部_節21_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節21_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節21_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節21_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節21_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節21_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節21_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節21_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_節22_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節22_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節22_節.Dra = value;
				this.X0Y0_腕部_節22_節.Hit = value;
			}
		}

		public bool 腕部_節22_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節22_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節22_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節22_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節22_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節22_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節22_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節22_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_節23_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節23_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節23_節.Dra = value;
				this.X0Y0_腕部_節23_節.Hit = value;
			}
		}

		public bool 腕部_節23_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節23_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節23_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節23_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節23_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節23_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節23_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節23_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_節24_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節24_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節24_節.Dra = value;
				this.X0Y0_腕部_節24_節.Hit = value;
			}
		}

		public bool 腕部_節24_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節24_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節24_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節24_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節24_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節24_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節24_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節24_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 腕部_節25_節_表示
		{
			get
			{
				return this.X0Y0_腕部_節25_節.Dra;
			}
			set
			{
				this.X0Y0_腕部_節25_節.Dra = value;
				this.X0Y0_腕部_節25_節.Hit = value;
			}
		}

		public bool 腕部_節25_紋柄_紋柄1_表示
		{
			get
			{
				return this.X0Y0_腕部_節25_紋柄_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_腕部_節25_紋柄_紋柄1.Dra = value;
				this.X0Y0_腕部_節25_紋柄_紋柄1.Hit = value;
			}
		}

		public bool 腕部_節25_紋柄_紋柄2_表示
		{
			get
			{
				return this.X0Y0_腕部_節25_紋柄_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_腕部_節25_紋柄_紋柄2.Dra = value;
				this.X0Y0_腕部_節25_紋柄_紋柄2.Hit = value;
			}
		}

		public bool 手先_節1_節_表示
		{
			get
			{
				return this.X0Y0_手先_節1_節.Dra;
			}
			set
			{
				this.X0Y0_手先_節1_節.Dra = value;
				this.X0Y0_手先_節1_節.Hit = value;
			}
		}

		public bool 手先_節1_紋柄1_表示
		{
			get
			{
				return this.X0Y0_手先_節1_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_手先_節1_紋柄1.Dra = value;
				this.X0Y0_手先_節1_紋柄1.Hit = value;
			}
		}

		public bool 手先_節1_紋柄2_表示
		{
			get
			{
				return this.X0Y0_手先_節1_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_手先_節1_紋柄2.Dra = value;
				this.X0Y0_手先_節1_紋柄2.Hit = value;
			}
		}

		public bool 手先_節1_吸盤_吸盤1_表示
		{
			get
			{
				return this.X0Y0_手先_節1_吸盤_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_手先_節1_吸盤_吸盤1.Dra = value;
				this.X0Y0_手先_節1_吸盤_吸盤1.Hit = value;
			}
		}

		public bool 手先_節1_吸盤_吸盤2_表示
		{
			get
			{
				return this.X0Y0_手先_節1_吸盤_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_手先_節1_吸盤_吸盤2.Dra = value;
				this.X0Y0_手先_節1_吸盤_吸盤2.Hit = value;
			}
		}

		public bool 手先_節1_吸盤_吸盤3_表示
		{
			get
			{
				return this.X0Y0_手先_節1_吸盤_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_手先_節1_吸盤_吸盤3.Dra = value;
				this.X0Y0_手先_節1_吸盤_吸盤3.Hit = value;
			}
		}

		public bool 手先_節1_吸盤_吸盤4_表示
		{
			get
			{
				return this.X0Y0_手先_節1_吸盤_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_手先_節1_吸盤_吸盤4.Dra = value;
				this.X0Y0_手先_節1_吸盤_吸盤4.Hit = value;
			}
		}

		public bool 手先_節1_爪_爪2_表示
		{
			get
			{
				return this.X0Y0_手先_節1_爪_爪2.Dra;
			}
			set
			{
				this.X0Y0_手先_節1_爪_爪2.Dra = value;
				this.X0Y0_手先_節1_爪_爪2.Hit = value;
			}
		}

		public bool 手先_節1_爪_爪1_表示
		{
			get
			{
				return this.X0Y0_手先_節1_爪_爪1.Dra;
			}
			set
			{
				this.X0Y0_手先_節1_爪_爪1.Dra = value;
				this.X0Y0_手先_節1_爪_爪1.Hit = value;
			}
		}

		public bool 手先_輪2_革_表示
		{
			get
			{
				return this.X0Y0_手先_輪2_革.Dra;
			}
			set
			{
				this.X0Y0_手先_輪2_革.Dra = value;
				this.X0Y0_手先_輪2_革.Hit = value;
			}
		}

		public bool 手先_輪2_金具1_表示
		{
			get
			{
				return this.X0Y0_手先_輪2_金具1.Dra;
			}
			set
			{
				this.X0Y0_手先_輪2_金具1.Dra = value;
				this.X0Y0_手先_輪2_金具1.Hit = value;
			}
		}

		public bool 手先_輪2_金具2_表示
		{
			get
			{
				return this.X0Y0_手先_輪2_金具2.Dra;
			}
			set
			{
				this.X0Y0_手先_輪2_金具2.Dra = value;
				this.X0Y0_手先_輪2_金具2.Hit = value;
			}
		}

		public bool 手先_輪2_金具3_表示
		{
			get
			{
				return this.X0Y0_手先_輪2_金具3.Dra;
			}
			set
			{
				this.X0Y0_手先_輪2_金具3.Dra = value;
				this.X0Y0_手先_輪2_金具3.Hit = value;
			}
		}

		public bool 手先_輪2_金具左_表示
		{
			get
			{
				return this.X0Y0_手先_輪2_金具左.Dra;
			}
			set
			{
				this.X0Y0_手先_輪2_金具左.Dra = value;
				this.X0Y0_手先_輪2_金具左.Hit = value;
			}
		}

		public bool 手先_輪2_金具右_表示
		{
			get
			{
				return this.X0Y0_手先_輪2_金具右.Dra;
			}
			set
			{
				this.X0Y0_手先_輪2_金具右.Dra = value;
				this.X0Y0_手先_輪2_金具右.Hit = value;
			}
		}

		public bool 手先_節2_節_表示
		{
			get
			{
				return this.X0Y0_手先_節2_節.Dra;
			}
			set
			{
				this.X0Y0_手先_節2_節.Dra = value;
				this.X0Y0_手先_節2_節.Hit = value;
			}
		}

		public bool 手先_節2_紋柄1_表示
		{
			get
			{
				return this.X0Y0_手先_節2_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_手先_節2_紋柄1.Dra = value;
				this.X0Y0_手先_節2_紋柄1.Hit = value;
			}
		}

		public bool 手先_節2_紋柄2_表示
		{
			get
			{
				return this.X0Y0_手先_節2_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_手先_節2_紋柄2.Dra = value;
				this.X0Y0_手先_節2_紋柄2.Hit = value;
			}
		}

		public bool 手先_節2_吸盤_吸盤1_表示
		{
			get
			{
				return this.X0Y0_手先_節2_吸盤_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_手先_節2_吸盤_吸盤1.Dra = value;
				this.X0Y0_手先_節2_吸盤_吸盤1.Hit = value;
			}
		}

		public bool 手先_節2_吸盤_吸盤2_表示
		{
			get
			{
				return this.X0Y0_手先_節2_吸盤_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_手先_節2_吸盤_吸盤2.Dra = value;
				this.X0Y0_手先_節2_吸盤_吸盤2.Hit = value;
			}
		}

		public bool 手先_節2_吸盤_吸盤3_表示
		{
			get
			{
				return this.X0Y0_手先_節2_吸盤_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_手先_節2_吸盤_吸盤3.Dra = value;
				this.X0Y0_手先_節2_吸盤_吸盤3.Hit = value;
			}
		}

		public bool 手先_節2_吸盤_吸盤4_表示
		{
			get
			{
				return this.X0Y0_手先_節2_吸盤_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_手先_節2_吸盤_吸盤4.Dra = value;
				this.X0Y0_手先_節2_吸盤_吸盤4.Hit = value;
			}
		}

		public bool 手先_節2_爪_爪2_表示
		{
			get
			{
				return this.X0Y0_手先_節2_爪_爪2.Dra;
			}
			set
			{
				this.X0Y0_手先_節2_爪_爪2.Dra = value;
				this.X0Y0_手先_節2_爪_爪2.Hit = value;
			}
		}

		public bool 手先_節2_爪_爪1_表示
		{
			get
			{
				return this.X0Y0_手先_節2_爪_爪1.Dra;
			}
			set
			{
				this.X0Y0_手先_節2_爪_爪1.Dra = value;
				this.X0Y0_手先_節2_爪_爪1.Hit = value;
			}
		}

		public bool 手先_節3_節_表示
		{
			get
			{
				return this.X0Y0_手先_節3_節.Dra;
			}
			set
			{
				this.X0Y0_手先_節3_節.Dra = value;
				this.X0Y0_手先_節3_節.Hit = value;
			}
		}

		public bool 手先_節3_紋柄1_表示
		{
			get
			{
				return this.X0Y0_手先_節3_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_手先_節3_紋柄1.Dra = value;
				this.X0Y0_手先_節3_紋柄1.Hit = value;
			}
		}

		public bool 手先_節3_紋柄2_表示
		{
			get
			{
				return this.X0Y0_手先_節3_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_手先_節3_紋柄2.Dra = value;
				this.X0Y0_手先_節3_紋柄2.Hit = value;
			}
		}

		public bool 手先_節3_吸盤_吸盤1_表示
		{
			get
			{
				return this.X0Y0_手先_節3_吸盤_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_手先_節3_吸盤_吸盤1.Dra = value;
				this.X0Y0_手先_節3_吸盤_吸盤1.Hit = value;
			}
		}

		public bool 手先_節3_吸盤_吸盤2_表示
		{
			get
			{
				return this.X0Y0_手先_節3_吸盤_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_手先_節3_吸盤_吸盤2.Dra = value;
				this.X0Y0_手先_節3_吸盤_吸盤2.Hit = value;
			}
		}

		public bool 手先_節3_吸盤_吸盤3_表示
		{
			get
			{
				return this.X0Y0_手先_節3_吸盤_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_手先_節3_吸盤_吸盤3.Dra = value;
				this.X0Y0_手先_節3_吸盤_吸盤3.Hit = value;
			}
		}

		public bool 手先_節3_吸盤_吸盤4_表示
		{
			get
			{
				return this.X0Y0_手先_節3_吸盤_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_手先_節3_吸盤_吸盤4.Dra = value;
				this.X0Y0_手先_節3_吸盤_吸盤4.Hit = value;
			}
		}

		public bool 手先_節3_爪_爪2_表示
		{
			get
			{
				return this.X0Y0_手先_節3_爪_爪2.Dra;
			}
			set
			{
				this.X0Y0_手先_節3_爪_爪2.Dra = value;
				this.X0Y0_手先_節3_爪_爪2.Hit = value;
			}
		}

		public bool 手先_節3_爪_爪1_表示
		{
			get
			{
				return this.X0Y0_手先_節3_爪_爪1.Dra;
			}
			set
			{
				this.X0Y0_手先_節3_爪_爪1.Dra = value;
				this.X0Y0_手先_節3_爪_爪1.Hit = value;
			}
		}

		public bool 手先_節4_節_表示
		{
			get
			{
				return this.X0Y0_手先_節4_節.Dra;
			}
			set
			{
				this.X0Y0_手先_節4_節.Dra = value;
				this.X0Y0_手先_節4_節.Hit = value;
			}
		}

		public bool 手先_節4_紋柄1_表示
		{
			get
			{
				return this.X0Y0_手先_節4_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_手先_節4_紋柄1.Dra = value;
				this.X0Y0_手先_節4_紋柄1.Hit = value;
			}
		}

		public bool 手先_節4_紋柄2_表示
		{
			get
			{
				return this.X0Y0_手先_節4_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_手先_節4_紋柄2.Dra = value;
				this.X0Y0_手先_節4_紋柄2.Hit = value;
			}
		}

		public bool 手先_節4_吸盤_吸盤1_表示
		{
			get
			{
				return this.X0Y0_手先_節4_吸盤_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_手先_節4_吸盤_吸盤1.Dra = value;
				this.X0Y0_手先_節4_吸盤_吸盤1.Hit = value;
			}
		}

		public bool 手先_節4_吸盤_吸盤2_表示
		{
			get
			{
				return this.X0Y0_手先_節4_吸盤_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_手先_節4_吸盤_吸盤2.Dra = value;
				this.X0Y0_手先_節4_吸盤_吸盤2.Hit = value;
			}
		}

		public bool 手先_節4_吸盤_吸盤3_表示
		{
			get
			{
				return this.X0Y0_手先_節4_吸盤_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_手先_節4_吸盤_吸盤3.Dra = value;
				this.X0Y0_手先_節4_吸盤_吸盤3.Hit = value;
			}
		}

		public bool 手先_節4_吸盤_吸盤4_表示
		{
			get
			{
				return this.X0Y0_手先_節4_吸盤_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_手先_節4_吸盤_吸盤4.Dra = value;
				this.X0Y0_手先_節4_吸盤_吸盤4.Hit = value;
			}
		}

		public bool 手先_節4_爪_爪2_表示
		{
			get
			{
				return this.X0Y0_手先_節4_爪_爪2.Dra;
			}
			set
			{
				this.X0Y0_手先_節4_爪_爪2.Dra = value;
				this.X0Y0_手先_節4_爪_爪2.Hit = value;
			}
		}

		public bool 手先_節4_爪_爪1_表示
		{
			get
			{
				return this.X0Y0_手先_節4_爪_爪1.Dra;
			}
			set
			{
				this.X0Y0_手先_節4_爪_爪1.Dra = value;
				this.X0Y0_手先_節4_爪_爪1.Hit = value;
			}
		}

		public bool 手先_節5_節_表示
		{
			get
			{
				return this.X0Y0_手先_節5_節.Dra;
			}
			set
			{
				this.X0Y0_手先_節5_節.Dra = value;
				this.X0Y0_手先_節5_節.Hit = value;
			}
		}

		public bool 手先_節5_紋柄1_表示
		{
			get
			{
				return this.X0Y0_手先_節5_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_手先_節5_紋柄1.Dra = value;
				this.X0Y0_手先_節5_紋柄1.Hit = value;
			}
		}

		public bool 手先_節5_紋柄2_表示
		{
			get
			{
				return this.X0Y0_手先_節5_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_手先_節5_紋柄2.Dra = value;
				this.X0Y0_手先_節5_紋柄2.Hit = value;
			}
		}

		public bool 手先_節5_吸盤_吸盤1_表示
		{
			get
			{
				return this.X0Y0_手先_節5_吸盤_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_手先_節5_吸盤_吸盤1.Dra = value;
				this.X0Y0_手先_節5_吸盤_吸盤1.Hit = value;
			}
		}

		public bool 手先_節5_吸盤_吸盤2_表示
		{
			get
			{
				return this.X0Y0_手先_節5_吸盤_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_手先_節5_吸盤_吸盤2.Dra = value;
				this.X0Y0_手先_節5_吸盤_吸盤2.Hit = value;
			}
		}

		public bool 手先_節5_吸盤_吸盤3_表示
		{
			get
			{
				return this.X0Y0_手先_節5_吸盤_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_手先_節5_吸盤_吸盤3.Dra = value;
				this.X0Y0_手先_節5_吸盤_吸盤3.Hit = value;
			}
		}

		public bool 手先_節5_吸盤_吸盤4_表示
		{
			get
			{
				return this.X0Y0_手先_節5_吸盤_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_手先_節5_吸盤_吸盤4.Dra = value;
				this.X0Y0_手先_節5_吸盤_吸盤4.Hit = value;
			}
		}

		public bool 手先_節5_爪_爪2_表示
		{
			get
			{
				return this.X0Y0_手先_節5_爪_爪2.Dra;
			}
			set
			{
				this.X0Y0_手先_節5_爪_爪2.Dra = value;
				this.X0Y0_手先_節5_爪_爪2.Hit = value;
			}
		}

		public bool 手先_節5_爪_爪1_表示
		{
			get
			{
				return this.X0Y0_手先_節5_爪_爪1.Dra;
			}
			set
			{
				this.X0Y0_手先_節5_爪_爪1.Dra = value;
				this.X0Y0_手先_節5_爪_爪1.Hit = value;
			}
		}

		public bool 手先_節6_節_表示
		{
			get
			{
				return this.X0Y0_手先_節6_節.Dra;
			}
			set
			{
				this.X0Y0_手先_節6_節.Dra = value;
				this.X0Y0_手先_節6_節.Hit = value;
			}
		}

		public bool 手先_節6_紋柄1_表示
		{
			get
			{
				return this.X0Y0_手先_節6_紋柄1.Dra;
			}
			set
			{
				this.X0Y0_手先_節6_紋柄1.Dra = value;
				this.X0Y0_手先_節6_紋柄1.Hit = value;
			}
		}

		public bool 手先_節6_紋柄2_表示
		{
			get
			{
				return this.X0Y0_手先_節6_紋柄2.Dra;
			}
			set
			{
				this.X0Y0_手先_節6_紋柄2.Dra = value;
				this.X0Y0_手先_節6_紋柄2.Hit = value;
			}
		}

		public bool 手先_節6_吸盤_吸盤1_表示
		{
			get
			{
				return this.X0Y0_手先_節6_吸盤_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_手先_節6_吸盤_吸盤1.Dra = value;
				this.X0Y0_手先_節6_吸盤_吸盤1.Hit = value;
			}
		}

		public bool 手先_節6_吸盤_吸盤2_表示
		{
			get
			{
				return this.X0Y0_手先_節6_吸盤_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_手先_節6_吸盤_吸盤2.Dra = value;
				this.X0Y0_手先_節6_吸盤_吸盤2.Hit = value;
			}
		}

		public bool 手先_節6_吸盤_吸盤3_表示
		{
			get
			{
				return this.X0Y0_手先_節6_吸盤_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_手先_節6_吸盤_吸盤3.Dra = value;
				this.X0Y0_手先_節6_吸盤_吸盤3.Hit = value;
			}
		}

		public bool 手先_節6_吸盤_吸盤4_表示
		{
			get
			{
				return this.X0Y0_手先_節6_吸盤_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_手先_節6_吸盤_吸盤4.Dra = value;
				this.X0Y0_手先_節6_吸盤_吸盤4.Hit = value;
			}
		}

		public bool 手先_節6_爪_爪2_表示
		{
			get
			{
				return this.X0Y0_手先_節6_爪_爪2.Dra;
			}
			set
			{
				this.X0Y0_手先_節6_爪_爪2.Dra = value;
				this.X0Y0_手先_節6_爪_爪2.Hit = value;
			}
		}

		public bool 手先_節6_爪_爪1_表示
		{
			get
			{
				return this.X0Y0_手先_節6_爪_爪1.Dra;
			}
			set
			{
				this.X0Y0_手先_節6_爪_爪1.Dra = value;
				this.X0Y0_手先_節6_爪_爪1.Hit = value;
			}
		}

		public bool 手先_節7_節_表示
		{
			get
			{
				return this.X0Y0_手先_節7_節.Dra;
			}
			set
			{
				this.X0Y0_手先_節7_節.Dra = value;
				this.X0Y0_手先_節7_節.Hit = value;
			}
		}

		public bool 手先_節7_紋柄_表示
		{
			get
			{
				return this.X0Y0_手先_節7_紋柄.Dra;
			}
			set
			{
				this.X0Y0_手先_節7_紋柄.Dra = value;
				this.X0Y0_手先_節7_紋柄.Hit = value;
			}
		}

		public bool 手先_節7_吸盤_吸盤1_表示
		{
			get
			{
				return this.X0Y0_手先_節7_吸盤_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_手先_節7_吸盤_吸盤1.Dra = value;
				this.X0Y0_手先_節7_吸盤_吸盤1.Hit = value;
			}
		}

		public bool 手先_節7_吸盤_吸盤2_表示
		{
			get
			{
				return this.X0Y0_手先_節7_吸盤_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_手先_節7_吸盤_吸盤2.Dra = value;
				this.X0Y0_手先_節7_吸盤_吸盤2.Hit = value;
			}
		}

		public bool 手先_節7_吸盤_吸盤3_表示
		{
			get
			{
				return this.X0Y0_手先_節7_吸盤_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_手先_節7_吸盤_吸盤3.Dra = value;
				this.X0Y0_手先_節7_吸盤_吸盤3.Hit = value;
			}
		}

		public bool 手先_節7_吸盤_吸盤4_表示
		{
			get
			{
				return this.X0Y0_手先_節7_吸盤_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_手先_節7_吸盤_吸盤4.Dra = value;
				this.X0Y0_手先_節7_吸盤_吸盤4.Hit = value;
			}
		}

		public bool 手先_節7_爪_爪2_表示
		{
			get
			{
				return this.X0Y0_手先_節7_爪_爪2.Dra;
			}
			set
			{
				this.X0Y0_手先_節7_爪_爪2.Dra = value;
				this.X0Y0_手先_節7_爪_爪2.Hit = value;
			}
		}

		public bool 手先_節7_爪_爪1_表示
		{
			get
			{
				return this.X0Y0_手先_節7_爪_爪1.Dra;
			}
			set
			{
				this.X0Y0_手先_節7_爪_爪1.Dra = value;
				this.X0Y0_手先_節7_爪_爪1.Hit = value;
			}
		}

		public bool 手先_節8_節_表示
		{
			get
			{
				return this.X0Y0_手先_節8_節.Dra;
			}
			set
			{
				this.X0Y0_手先_節8_節.Dra = value;
				this.X0Y0_手先_節8_節.Hit = value;
			}
		}

		public bool 手先_節8_紋柄_表示
		{
			get
			{
				return this.X0Y0_手先_節8_紋柄.Dra;
			}
			set
			{
				this.X0Y0_手先_節8_紋柄.Dra = value;
				this.X0Y0_手先_節8_紋柄.Hit = value;
			}
		}

		public bool 手先_節8_吸盤_吸盤1_表示
		{
			get
			{
				return this.X0Y0_手先_節8_吸盤_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_手先_節8_吸盤_吸盤1.Dra = value;
				this.X0Y0_手先_節8_吸盤_吸盤1.Hit = value;
			}
		}

		public bool 手先_節8_吸盤_吸盤2_表示
		{
			get
			{
				return this.X0Y0_手先_節8_吸盤_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_手先_節8_吸盤_吸盤2.Dra = value;
				this.X0Y0_手先_節8_吸盤_吸盤2.Hit = value;
			}
		}

		public bool 手先_節8_吸盤_吸盤3_表示
		{
			get
			{
				return this.X0Y0_手先_節8_吸盤_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_手先_節8_吸盤_吸盤3.Dra = value;
				this.X0Y0_手先_節8_吸盤_吸盤3.Hit = value;
			}
		}

		public bool 手先_節8_吸盤_吸盤4_表示
		{
			get
			{
				return this.X0Y0_手先_節8_吸盤_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_手先_節8_吸盤_吸盤4.Dra = value;
				this.X0Y0_手先_節8_吸盤_吸盤4.Hit = value;
			}
		}

		public bool 手先_節8_爪_爪2_表示
		{
			get
			{
				return this.X0Y0_手先_節8_爪_爪2.Dra;
			}
			set
			{
				this.X0Y0_手先_節8_爪_爪2.Dra = value;
				this.X0Y0_手先_節8_爪_爪2.Hit = value;
			}
		}

		public bool 手先_節8_爪_爪1_表示
		{
			get
			{
				return this.X0Y0_手先_節8_爪_爪1.Dra;
			}
			set
			{
				this.X0Y0_手先_節8_爪_爪1.Dra = value;
				this.X0Y0_手先_節8_爪_爪1.Hit = value;
			}
		}

		public bool 手先_節9_節_表示
		{
			get
			{
				return this.X0Y0_手先_節9_節.Dra;
			}
			set
			{
				this.X0Y0_手先_節9_節.Dra = value;
				this.X0Y0_手先_節9_節.Hit = value;
			}
		}

		public bool 手先_節9_紋柄_表示
		{
			get
			{
				return this.X0Y0_手先_節9_紋柄.Dra;
			}
			set
			{
				this.X0Y0_手先_節9_紋柄.Dra = value;
				this.X0Y0_手先_節9_紋柄.Hit = value;
			}
		}

		public bool 手先_節9_吸盤_吸盤1_表示
		{
			get
			{
				return this.X0Y0_手先_節9_吸盤_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_手先_節9_吸盤_吸盤1.Dra = value;
				this.X0Y0_手先_節9_吸盤_吸盤1.Hit = value;
			}
		}

		public bool 手先_節9_吸盤_吸盤2_表示
		{
			get
			{
				return this.X0Y0_手先_節9_吸盤_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_手先_節9_吸盤_吸盤2.Dra = value;
				this.X0Y0_手先_節9_吸盤_吸盤2.Hit = value;
			}
		}

		public bool 手先_節9_吸盤_吸盤3_表示
		{
			get
			{
				return this.X0Y0_手先_節9_吸盤_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_手先_節9_吸盤_吸盤3.Dra = value;
				this.X0Y0_手先_節9_吸盤_吸盤3.Hit = value;
			}
		}

		public bool 手先_節9_吸盤_吸盤4_表示
		{
			get
			{
				return this.X0Y0_手先_節9_吸盤_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_手先_節9_吸盤_吸盤4.Dra = value;
				this.X0Y0_手先_節9_吸盤_吸盤4.Hit = value;
			}
		}

		public bool 手先_節9_爪_爪2_表示
		{
			get
			{
				return this.X0Y0_手先_節9_爪_爪2.Dra;
			}
			set
			{
				this.X0Y0_手先_節9_爪_爪2.Dra = value;
				this.X0Y0_手先_節9_爪_爪2.Hit = value;
			}
		}

		public bool 手先_節9_爪_爪1_表示
		{
			get
			{
				return this.X0Y0_手先_節9_爪_爪1.Dra;
			}
			set
			{
				this.X0Y0_手先_節9_爪_爪1.Dra = value;
				this.X0Y0_手先_節9_爪_爪1.Hit = value;
			}
		}

		public bool 手先_節10_節_表示
		{
			get
			{
				return this.X0Y0_手先_節10_節.Dra;
			}
			set
			{
				this.X0Y0_手先_節10_節.Dra = value;
				this.X0Y0_手先_節10_節.Hit = value;
			}
		}

		public bool 手先_節10_紋柄_表示
		{
			get
			{
				return this.X0Y0_手先_節10_紋柄.Dra;
			}
			set
			{
				this.X0Y0_手先_節10_紋柄.Dra = value;
				this.X0Y0_手先_節10_紋柄.Hit = value;
			}
		}

		public bool 手先_節10_吸盤_吸盤1_表示
		{
			get
			{
				return this.X0Y0_手先_節10_吸盤_吸盤1.Dra;
			}
			set
			{
				this.X0Y0_手先_節10_吸盤_吸盤1.Dra = value;
				this.X0Y0_手先_節10_吸盤_吸盤1.Hit = value;
			}
		}

		public bool 手先_節10_吸盤_吸盤2_表示
		{
			get
			{
				return this.X0Y0_手先_節10_吸盤_吸盤2.Dra;
			}
			set
			{
				this.X0Y0_手先_節10_吸盤_吸盤2.Dra = value;
				this.X0Y0_手先_節10_吸盤_吸盤2.Hit = value;
			}
		}

		public bool 手先_節10_吸盤_吸盤3_表示
		{
			get
			{
				return this.X0Y0_手先_節10_吸盤_吸盤3.Dra;
			}
			set
			{
				this.X0Y0_手先_節10_吸盤_吸盤3.Dra = value;
				this.X0Y0_手先_節10_吸盤_吸盤3.Hit = value;
			}
		}

		public bool 手先_節10_吸盤_吸盤4_表示
		{
			get
			{
				return this.X0Y0_手先_節10_吸盤_吸盤4.Dra;
			}
			set
			{
				this.X0Y0_手先_節10_吸盤_吸盤4.Dra = value;
				this.X0Y0_手先_節10_吸盤_吸盤4.Hit = value;
			}
		}

		public bool 手先_節10_爪_爪2_表示
		{
			get
			{
				return this.X0Y0_手先_節10_爪_爪2.Dra;
			}
			set
			{
				this.X0Y0_手先_節10_爪_爪2.Dra = value;
				this.X0Y0_手先_節10_爪_爪2.Hit = value;
			}
		}

		public bool 手先_節10_爪_爪1_表示
		{
			get
			{
				return this.X0Y0_手先_節10_爪_爪1.Dra;
			}
			set
			{
				this.X0Y0_手先_節10_爪_爪1.Dra = value;
				this.X0Y0_手先_節10_爪_爪1.Hit = value;
			}
		}

		public bool 輪1表示
		{
			get
			{
				return this.腕部_輪1_革_表示;
			}
			set
			{
				this.腕部_輪1_革_表示 = value;
				this.腕部_輪1_金具1_表示 = value;
				this.腕部_輪1_金具2_表示 = value;
				this.腕部_輪1_金具3_表示 = value;
				this.腕部_輪1_金具左_表示 = value;
				this.腕部_輪1_金具右_表示 = value;
			}
		}

		public bool 輪2表示
		{
			get
			{
				return this.手先_輪2_革_表示;
			}
			set
			{
				this.手先_輪2_革_表示 = value;
				this.手先_輪2_金具1_表示 = value;
				this.手先_輪2_金具2_表示 = value;
				this.手先_輪2_金具3_表示 = value;
				this.手先_輪2_金具左_表示 = value;
				this.手先_輪2_金具右_表示 = value;
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
				return this.腕部_節1_節_表示;
			}
			set
			{
				this.腕部_節1_節_表示 = value;
				this.腕部_節1_紋柄_紋柄1_表示 = value;
				this.腕部_節1_紋柄_紋柄2_表示 = value;
				this.腕部_節2_節_表示 = value;
				this.腕部_節2_紋柄_紋柄1_表示 = value;
				this.腕部_節2_紋柄_紋柄2_表示 = value;
				this.腕部_節3_節_表示 = value;
				this.腕部_節3_紋柄_紋柄1_表示 = value;
				this.腕部_節3_紋柄_紋柄2_表示 = value;
				this.腕部_節4_節_表示 = value;
				this.腕部_節4_紋柄_紋柄1_表示 = value;
				this.腕部_節4_紋柄_紋柄2_表示 = value;
				this.腕部_節5_節_表示 = value;
				this.腕部_節5_紋柄_紋柄1_表示 = value;
				this.腕部_節5_紋柄_紋柄2_表示 = value;
				this.腕部_節6_節_表示 = value;
				this.腕部_節6_紋柄_紋柄1_表示 = value;
				this.腕部_節6_紋柄_紋柄2_表示 = value;
				this.腕部_節7_節_表示 = value;
				this.腕部_節7_紋柄_紋柄1_表示 = value;
				this.腕部_節7_紋柄_紋柄2_表示 = value;
				this.腕部_節8_節_表示 = value;
				this.腕部_節8_紋柄_紋柄1_表示 = value;
				this.腕部_節8_紋柄_紋柄2_表示 = value;
				this.腕部_節9_節_表示 = value;
				this.腕部_節9_紋柄_紋柄1_表示 = value;
				this.腕部_節9_紋柄_紋柄2_表示 = value;
				this.腕部_節10_節_表示 = value;
				this.腕部_節10_紋柄_紋柄1_表示 = value;
				this.腕部_節10_紋柄_紋柄2_表示 = value;
				this.腕部_節11_節_表示 = value;
				this.腕部_節11_紋柄_紋柄1_表示 = value;
				this.腕部_節11_紋柄_紋柄2_表示 = value;
				this.腕部_節12_節_表示 = value;
				this.腕部_節12_紋柄_紋柄1_表示 = value;
				this.腕部_節12_紋柄_紋柄2_表示 = value;
				this.腕部_節13_節_表示 = value;
				this.腕部_節13_紋柄_紋柄1_表示 = value;
				this.腕部_節13_紋柄_紋柄2_表示 = value;
				this.腕部_節14_節_表示 = value;
				this.腕部_節14_紋柄_紋柄1_表示 = value;
				this.腕部_節14_紋柄_紋柄2_表示 = value;
				this.腕部_節15_節_表示 = value;
				this.腕部_節15_紋柄_紋柄1_表示 = value;
				this.腕部_節15_紋柄_紋柄2_表示 = value;
				this.腕部_輪1_革_表示 = value;
				this.腕部_輪1_金具1_表示 = value;
				this.腕部_輪1_金具2_表示 = value;
				this.腕部_輪1_金具3_表示 = value;
				this.腕部_輪1_金具左_表示 = value;
				this.腕部_輪1_金具右_表示 = value;
				this.腕部_節16_節_表示 = value;
				this.腕部_節16_紋柄_紋柄1_表示 = value;
				this.腕部_節16_紋柄_紋柄2_表示 = value;
				this.腕部_節17_節_表示 = value;
				this.腕部_節17_紋柄_紋柄1_表示 = value;
				this.腕部_節17_紋柄_紋柄2_表示 = value;
				this.腕部_節18_節_表示 = value;
				this.腕部_節18_紋柄_紋柄1_表示 = value;
				this.腕部_節18_紋柄_紋柄2_表示 = value;
				this.腕部_節19_節_表示 = value;
				this.腕部_節19_紋柄_紋柄1_表示 = value;
				this.腕部_節19_紋柄_紋柄2_表示 = value;
				this.腕部_節20_節_表示 = value;
				this.腕部_節20_紋柄_紋柄1_表示 = value;
				this.腕部_節20_紋柄_紋柄2_表示 = value;
				this.腕部_節21_節_表示 = value;
				this.腕部_節21_紋柄_紋柄1_表示 = value;
				this.腕部_節21_紋柄_紋柄2_表示 = value;
				this.腕部_節22_節_表示 = value;
				this.腕部_節22_紋柄_紋柄1_表示 = value;
				this.腕部_節22_紋柄_紋柄2_表示 = value;
				this.腕部_節23_節_表示 = value;
				this.腕部_節23_紋柄_紋柄1_表示 = value;
				this.腕部_節23_紋柄_紋柄2_表示 = value;
				this.腕部_節24_節_表示 = value;
				this.腕部_節24_紋柄_紋柄1_表示 = value;
				this.腕部_節24_紋柄_紋柄2_表示 = value;
				this.腕部_節25_節_表示 = value;
				this.腕部_節25_紋柄_紋柄1_表示 = value;
				this.腕部_節25_紋柄_紋柄2_表示 = value;
				this.手先_節1_節_表示 = value;
				this.手先_節1_紋柄1_表示 = value;
				this.手先_節1_紋柄2_表示 = value;
				this.手先_節1_吸盤_吸盤1_表示 = value;
				this.手先_節1_吸盤_吸盤2_表示 = value;
				this.手先_節1_吸盤_吸盤3_表示 = value;
				this.手先_節1_吸盤_吸盤4_表示 = value;
				this.手先_節1_爪_爪2_表示 = value;
				this.手先_節1_爪_爪1_表示 = value;
				this.手先_輪2_革_表示 = value;
				this.手先_輪2_金具1_表示 = value;
				this.手先_輪2_金具2_表示 = value;
				this.手先_輪2_金具3_表示 = value;
				this.手先_輪2_金具左_表示 = value;
				this.手先_輪2_金具右_表示 = value;
				this.手先_節2_節_表示 = value;
				this.手先_節2_紋柄1_表示 = value;
				this.手先_節2_紋柄2_表示 = value;
				this.手先_節2_吸盤_吸盤1_表示 = value;
				this.手先_節2_吸盤_吸盤2_表示 = value;
				this.手先_節2_吸盤_吸盤3_表示 = value;
				this.手先_節2_吸盤_吸盤4_表示 = value;
				this.手先_節2_爪_爪2_表示 = value;
				this.手先_節2_爪_爪1_表示 = value;
				this.手先_節3_節_表示 = value;
				this.手先_節3_紋柄1_表示 = value;
				this.手先_節3_紋柄2_表示 = value;
				this.手先_節3_吸盤_吸盤1_表示 = value;
				this.手先_節3_吸盤_吸盤2_表示 = value;
				this.手先_節3_吸盤_吸盤3_表示 = value;
				this.手先_節3_吸盤_吸盤4_表示 = value;
				this.手先_節3_爪_爪2_表示 = value;
				this.手先_節3_爪_爪1_表示 = value;
				this.手先_節4_節_表示 = value;
				this.手先_節4_紋柄1_表示 = value;
				this.手先_節4_紋柄2_表示 = value;
				this.手先_節4_吸盤_吸盤1_表示 = value;
				this.手先_節4_吸盤_吸盤2_表示 = value;
				this.手先_節4_吸盤_吸盤3_表示 = value;
				this.手先_節4_吸盤_吸盤4_表示 = value;
				this.手先_節4_爪_爪2_表示 = value;
				this.手先_節4_爪_爪1_表示 = value;
				this.手先_節5_節_表示 = value;
				this.手先_節5_紋柄1_表示 = value;
				this.手先_節5_紋柄2_表示 = value;
				this.手先_節5_吸盤_吸盤1_表示 = value;
				this.手先_節5_吸盤_吸盤2_表示 = value;
				this.手先_節5_吸盤_吸盤3_表示 = value;
				this.手先_節5_吸盤_吸盤4_表示 = value;
				this.手先_節5_爪_爪2_表示 = value;
				this.手先_節5_爪_爪1_表示 = value;
				this.手先_節6_節_表示 = value;
				this.手先_節6_紋柄1_表示 = value;
				this.手先_節6_紋柄2_表示 = value;
				this.手先_節6_吸盤_吸盤1_表示 = value;
				this.手先_節6_吸盤_吸盤2_表示 = value;
				this.手先_節6_吸盤_吸盤3_表示 = value;
				this.手先_節6_吸盤_吸盤4_表示 = value;
				this.手先_節6_爪_爪2_表示 = value;
				this.手先_節6_爪_爪1_表示 = value;
				this.手先_節7_節_表示 = value;
				this.手先_節7_紋柄_表示 = value;
				this.手先_節7_吸盤_吸盤1_表示 = value;
				this.手先_節7_吸盤_吸盤2_表示 = value;
				this.手先_節7_吸盤_吸盤3_表示 = value;
				this.手先_節7_吸盤_吸盤4_表示 = value;
				this.手先_節7_爪_爪2_表示 = value;
				this.手先_節7_爪_爪1_表示 = value;
				this.手先_節8_節_表示 = value;
				this.手先_節8_紋柄_表示 = value;
				this.手先_節8_吸盤_吸盤1_表示 = value;
				this.手先_節8_吸盤_吸盤2_表示 = value;
				this.手先_節8_吸盤_吸盤3_表示 = value;
				this.手先_節8_吸盤_吸盤4_表示 = value;
				this.手先_節8_爪_爪2_表示 = value;
				this.手先_節8_爪_爪1_表示 = value;
				this.手先_節9_節_表示 = value;
				this.手先_節9_紋柄_表示 = value;
				this.手先_節9_吸盤_吸盤1_表示 = value;
				this.手先_節9_吸盤_吸盤2_表示 = value;
				this.手先_節9_吸盤_吸盤3_表示 = value;
				this.手先_節9_吸盤_吸盤4_表示 = value;
				this.手先_節9_爪_爪2_表示 = value;
				this.手先_節9_爪_爪1_表示 = value;
				this.手先_節10_節_表示 = value;
				this.手先_節10_紋柄_表示 = value;
				this.手先_節10_吸盤_吸盤1_表示 = value;
				this.手先_節10_吸盤_吸盤2_表示 = value;
				this.手先_節10_吸盤_吸盤3_表示 = value;
				this.手先_節10_吸盤_吸盤4_表示 = value;
				this.手先_節10_爪_爪2_表示 = value;
				this.手先_節10_爪_爪1_表示 = value;
				this.鎖1.表示 = value;
				this.鎖2.表示 = value;
				this.鎖3.表示 = value;
				this.鎖4.表示 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_腕部_節1_節);
			Are.Draw(this.X0Y0_腕部_節1_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節1_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_節2_節);
			Are.Draw(this.X0Y0_腕部_節2_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節2_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_節3_節);
			Are.Draw(this.X0Y0_腕部_節3_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節3_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_節4_節);
			Are.Draw(this.X0Y0_腕部_節4_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節4_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_節5_節);
			Are.Draw(this.X0Y0_腕部_節5_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節5_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_節6_節);
			Are.Draw(this.X0Y0_腕部_節6_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節6_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_節7_節);
			Are.Draw(this.X0Y0_腕部_節7_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節7_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_節8_節);
			Are.Draw(this.X0Y0_腕部_節8_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節8_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_節9_節);
			Are.Draw(this.X0Y0_腕部_節9_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節9_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_節10_節);
			Are.Draw(this.X0Y0_腕部_節10_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節10_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_節11_節);
			Are.Draw(this.X0Y0_腕部_節11_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節11_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_節12_節);
			Are.Draw(this.X0Y0_腕部_節12_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節12_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_節13_節);
			Are.Draw(this.X0Y0_腕部_節13_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節13_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_節14_節);
			Are.Draw(this.X0Y0_腕部_節14_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節14_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_節15_節);
			Are.Draw(this.X0Y0_腕部_節15_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節15_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_輪1_革);
			Are.Draw(this.X0Y0_腕部_輪1_金具1);
			Are.Draw(this.X0Y0_腕部_輪1_金具2);
			Are.Draw(this.X0Y0_腕部_輪1_金具3);
			Are.Draw(this.X0Y0_腕部_輪1_金具左);
			Are.Draw(this.X0Y0_腕部_輪1_金具右);
			this.鎖1.描画0(Are);
			this.鎖2.描画0(Are);
			Are.Draw(this.X0Y0_腕部_節16_節);
			Are.Draw(this.X0Y0_腕部_節16_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節16_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_節17_節);
			Are.Draw(this.X0Y0_腕部_節17_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節17_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_節18_節);
			Are.Draw(this.X0Y0_腕部_節18_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節18_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_節19_節);
			Are.Draw(this.X0Y0_腕部_節19_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節19_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_節20_節);
			Are.Draw(this.X0Y0_腕部_節20_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節20_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_節21_節);
			Are.Draw(this.X0Y0_腕部_節21_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節21_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_節22_節);
			Are.Draw(this.X0Y0_腕部_節22_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節22_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_節23_節);
			Are.Draw(this.X0Y0_腕部_節23_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節23_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_節24_節);
			Are.Draw(this.X0Y0_腕部_節24_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節24_紋柄_紋柄2);
			Are.Draw(this.X0Y0_腕部_節25_節);
			Are.Draw(this.X0Y0_腕部_節25_紋柄_紋柄1);
			Are.Draw(this.X0Y0_腕部_節25_紋柄_紋柄2);
			Are.Draw(this.X0Y0_手先_節1_節);
			Are.Draw(this.X0Y0_手先_節1_紋柄1);
			Are.Draw(this.X0Y0_手先_節1_紋柄2);
			Are.Draw(this.X0Y0_手先_節1_吸盤_吸盤1);
			Are.Draw(this.X0Y0_手先_節1_吸盤_吸盤2);
			Are.Draw(this.X0Y0_手先_節1_吸盤_吸盤3);
			Are.Draw(this.X0Y0_手先_節1_吸盤_吸盤4);
			Are.Draw(this.X0Y0_手先_節1_爪_爪2);
			Are.Draw(this.X0Y0_手先_節1_爪_爪1);
			Are.Draw(this.X0Y0_手先_輪2_革);
			Are.Draw(this.X0Y0_手先_輪2_金具1);
			Are.Draw(this.X0Y0_手先_輪2_金具2);
			Are.Draw(this.X0Y0_手先_輪2_金具3);
			Are.Draw(this.X0Y0_手先_輪2_金具左);
			Are.Draw(this.X0Y0_手先_輪2_金具右);
			this.鎖3.描画0(Are);
			this.鎖4.描画0(Are);
			Are.Draw(this.X0Y0_手先_節2_節);
			Are.Draw(this.X0Y0_手先_節2_紋柄1);
			Are.Draw(this.X0Y0_手先_節2_紋柄2);
			Are.Draw(this.X0Y0_手先_節2_吸盤_吸盤1);
			Are.Draw(this.X0Y0_手先_節2_吸盤_吸盤2);
			Are.Draw(this.X0Y0_手先_節2_吸盤_吸盤3);
			Are.Draw(this.X0Y0_手先_節2_吸盤_吸盤4);
			Are.Draw(this.X0Y0_手先_節2_爪_爪2);
			Are.Draw(this.X0Y0_手先_節2_爪_爪1);
			Are.Draw(this.X0Y0_手先_節3_節);
			Are.Draw(this.X0Y0_手先_節3_紋柄1);
			Are.Draw(this.X0Y0_手先_節3_紋柄2);
			Are.Draw(this.X0Y0_手先_節3_吸盤_吸盤1);
			Are.Draw(this.X0Y0_手先_節3_吸盤_吸盤2);
			Are.Draw(this.X0Y0_手先_節3_吸盤_吸盤3);
			Are.Draw(this.X0Y0_手先_節3_吸盤_吸盤4);
			Are.Draw(this.X0Y0_手先_節3_爪_爪2);
			Are.Draw(this.X0Y0_手先_節3_爪_爪1);
			Are.Draw(this.X0Y0_手先_節4_節);
			Are.Draw(this.X0Y0_手先_節4_紋柄1);
			Are.Draw(this.X0Y0_手先_節4_紋柄2);
			Are.Draw(this.X0Y0_手先_節4_吸盤_吸盤1);
			Are.Draw(this.X0Y0_手先_節4_吸盤_吸盤2);
			Are.Draw(this.X0Y0_手先_節4_吸盤_吸盤3);
			Are.Draw(this.X0Y0_手先_節4_吸盤_吸盤4);
			Are.Draw(this.X0Y0_手先_節4_爪_爪2);
			Are.Draw(this.X0Y0_手先_節4_爪_爪1);
			Are.Draw(this.X0Y0_手先_節5_節);
			Are.Draw(this.X0Y0_手先_節5_紋柄1);
			Are.Draw(this.X0Y0_手先_節5_紋柄2);
			Are.Draw(this.X0Y0_手先_節5_吸盤_吸盤1);
			Are.Draw(this.X0Y0_手先_節5_吸盤_吸盤2);
			Are.Draw(this.X0Y0_手先_節5_吸盤_吸盤3);
			Are.Draw(this.X0Y0_手先_節5_吸盤_吸盤4);
			Are.Draw(this.X0Y0_手先_節5_爪_爪2);
			Are.Draw(this.X0Y0_手先_節5_爪_爪1);
			Are.Draw(this.X0Y0_手先_節6_節);
			Are.Draw(this.X0Y0_手先_節6_紋柄1);
			Are.Draw(this.X0Y0_手先_節6_紋柄2);
			Are.Draw(this.X0Y0_手先_節6_吸盤_吸盤1);
			Are.Draw(this.X0Y0_手先_節6_吸盤_吸盤2);
			Are.Draw(this.X0Y0_手先_節6_吸盤_吸盤3);
			Are.Draw(this.X0Y0_手先_節6_吸盤_吸盤4);
			Are.Draw(this.X0Y0_手先_節6_爪_爪2);
			Are.Draw(this.X0Y0_手先_節6_爪_爪1);
			Are.Draw(this.X0Y0_手先_節7_節);
			Are.Draw(this.X0Y0_手先_節7_紋柄);
			Are.Draw(this.X0Y0_手先_節7_吸盤_吸盤1);
			Are.Draw(this.X0Y0_手先_節7_吸盤_吸盤2);
			Are.Draw(this.X0Y0_手先_節7_吸盤_吸盤3);
			Are.Draw(this.X0Y0_手先_節7_吸盤_吸盤4);
			Are.Draw(this.X0Y0_手先_節7_爪_爪2);
			Are.Draw(this.X0Y0_手先_節7_爪_爪1);
			Are.Draw(this.X0Y0_手先_節8_節);
			Are.Draw(this.X0Y0_手先_節8_紋柄);
			Are.Draw(this.X0Y0_手先_節8_吸盤_吸盤1);
			Are.Draw(this.X0Y0_手先_節8_吸盤_吸盤2);
			Are.Draw(this.X0Y0_手先_節8_吸盤_吸盤3);
			Are.Draw(this.X0Y0_手先_節8_吸盤_吸盤4);
			Are.Draw(this.X0Y0_手先_節8_爪_爪2);
			Are.Draw(this.X0Y0_手先_節8_爪_爪1);
			Are.Draw(this.X0Y0_手先_節9_節);
			Are.Draw(this.X0Y0_手先_節9_紋柄);
			Are.Draw(this.X0Y0_手先_節9_吸盤_吸盤1);
			Are.Draw(this.X0Y0_手先_節9_吸盤_吸盤2);
			Are.Draw(this.X0Y0_手先_節9_吸盤_吸盤3);
			Are.Draw(this.X0Y0_手先_節9_吸盤_吸盤4);
			Are.Draw(this.X0Y0_手先_節9_爪_爪2);
			Are.Draw(this.X0Y0_手先_節9_爪_爪1);
			Are.Draw(this.X0Y0_手先_節10_節);
			Are.Draw(this.X0Y0_手先_節10_紋柄);
			Are.Draw(this.X0Y0_手先_節10_吸盤_吸盤1);
			Are.Draw(this.X0Y0_手先_節10_吸盤_吸盤2);
			Are.Draw(this.X0Y0_手先_節10_吸盤_吸盤3);
			Are.Draw(this.X0Y0_手先_節10_吸盤_吸盤4);
			Are.Draw(this.X0Y0_手先_節10_爪_爪2);
			Are.Draw(this.X0Y0_手先_節10_爪_爪1);
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
				return this.腕部_節1_節CD.不透明度;
			}
			set
			{
				this.腕部_節1_節CD.不透明度 = value;
				this.腕部_節1_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節1_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節2_節CD.不透明度 = value;
				this.腕部_節2_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節2_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節3_節CD.不透明度 = value;
				this.腕部_節3_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節3_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節4_節CD.不透明度 = value;
				this.腕部_節4_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節4_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節5_節CD.不透明度 = value;
				this.腕部_節5_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節5_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節6_節CD.不透明度 = value;
				this.腕部_節6_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節6_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節7_節CD.不透明度 = value;
				this.腕部_節7_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節7_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節8_節CD.不透明度 = value;
				this.腕部_節8_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節8_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節9_節CD.不透明度 = value;
				this.腕部_節9_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節9_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節10_節CD.不透明度 = value;
				this.腕部_節10_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節10_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節11_節CD.不透明度 = value;
				this.腕部_節11_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節11_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節12_節CD.不透明度 = value;
				this.腕部_節12_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節12_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節13_節CD.不透明度 = value;
				this.腕部_節13_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節13_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節14_節CD.不透明度 = value;
				this.腕部_節14_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節14_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節15_節CD.不透明度 = value;
				this.腕部_節15_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節15_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節16_節CD.不透明度 = value;
				this.腕部_節16_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節16_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節17_節CD.不透明度 = value;
				this.腕部_節17_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節17_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節18_節CD.不透明度 = value;
				this.腕部_節18_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節18_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節19_節CD.不透明度 = value;
				this.腕部_節19_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節19_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節20_節CD.不透明度 = value;
				this.腕部_節20_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節20_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節21_節CD.不透明度 = value;
				this.腕部_節21_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節21_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節22_節CD.不透明度 = value;
				this.腕部_節22_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節22_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節23_節CD.不透明度 = value;
				this.腕部_節23_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節23_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節24_節CD.不透明度 = value;
				this.腕部_節24_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節24_紋柄_紋柄2CD.不透明度 = value;
				this.腕部_節25_節CD.不透明度 = value;
				this.腕部_節25_紋柄_紋柄1CD.不透明度 = value;
				this.腕部_節25_紋柄_紋柄2CD.不透明度 = value;
				this.手先_節1_節CD.不透明度 = value;
				this.手先_節1_紋柄1CD.不透明度 = value;
				this.手先_節1_紋柄2CD.不透明度 = value;
				this.手先_節1_吸盤_吸盤1CD.不透明度 = value;
				this.手先_節1_吸盤_吸盤2CD.不透明度 = value;
				this.手先_節1_吸盤_吸盤3CD.不透明度 = value;
				this.手先_節1_吸盤_吸盤4CD.不透明度 = value;
				this.手先_節1_爪_爪2CD.不透明度 = value;
				this.手先_節1_爪_爪1CD.不透明度 = value;
				this.手先_節2_節CD.不透明度 = value;
				this.手先_節2_紋柄1CD.不透明度 = value;
				this.手先_節2_紋柄2CD.不透明度 = value;
				this.手先_節2_吸盤_吸盤1CD.不透明度 = value;
				this.手先_節2_吸盤_吸盤2CD.不透明度 = value;
				this.手先_節2_吸盤_吸盤3CD.不透明度 = value;
				this.手先_節2_吸盤_吸盤4CD.不透明度 = value;
				this.手先_節2_爪_爪2CD.不透明度 = value;
				this.手先_節2_爪_爪1CD.不透明度 = value;
				this.手先_節3_節CD.不透明度 = value;
				this.手先_節3_紋柄1CD.不透明度 = value;
				this.手先_節3_紋柄2CD.不透明度 = value;
				this.手先_節3_吸盤_吸盤1CD.不透明度 = value;
				this.手先_節3_吸盤_吸盤2CD.不透明度 = value;
				this.手先_節3_吸盤_吸盤3CD.不透明度 = value;
				this.手先_節3_吸盤_吸盤4CD.不透明度 = value;
				this.手先_節3_爪_爪2CD.不透明度 = value;
				this.手先_節3_爪_爪1CD.不透明度 = value;
				this.手先_節4_節CD.不透明度 = value;
				this.手先_節4_紋柄1CD.不透明度 = value;
				this.手先_節4_紋柄2CD.不透明度 = value;
				this.手先_節4_吸盤_吸盤1CD.不透明度 = value;
				this.手先_節4_吸盤_吸盤2CD.不透明度 = value;
				this.手先_節4_吸盤_吸盤3CD.不透明度 = value;
				this.手先_節4_吸盤_吸盤4CD.不透明度 = value;
				this.手先_節4_爪_爪2CD.不透明度 = value;
				this.手先_節4_爪_爪1CD.不透明度 = value;
				this.手先_節5_節CD.不透明度 = value;
				this.手先_節5_紋柄1CD.不透明度 = value;
				this.手先_節5_紋柄2CD.不透明度 = value;
				this.手先_節5_吸盤_吸盤1CD.不透明度 = value;
				this.手先_節5_吸盤_吸盤2CD.不透明度 = value;
				this.手先_節5_吸盤_吸盤3CD.不透明度 = value;
				this.手先_節5_吸盤_吸盤4CD.不透明度 = value;
				this.手先_節5_爪_爪2CD.不透明度 = value;
				this.手先_節5_爪_爪1CD.不透明度 = value;
				this.手先_節6_節CD.不透明度 = value;
				this.手先_節6_紋柄1CD.不透明度 = value;
				this.手先_節6_紋柄2CD.不透明度 = value;
				this.手先_節6_吸盤_吸盤1CD.不透明度 = value;
				this.手先_節6_吸盤_吸盤2CD.不透明度 = value;
				this.手先_節6_吸盤_吸盤3CD.不透明度 = value;
				this.手先_節6_吸盤_吸盤4CD.不透明度 = value;
				this.手先_節6_爪_爪2CD.不透明度 = value;
				this.手先_節6_爪_爪1CD.不透明度 = value;
				this.手先_節7_節CD.不透明度 = value;
				this.手先_節7_紋柄CD.不透明度 = value;
				this.手先_節7_吸盤_吸盤1CD.不透明度 = value;
				this.手先_節7_吸盤_吸盤2CD.不透明度 = value;
				this.手先_節7_吸盤_吸盤3CD.不透明度 = value;
				this.手先_節7_吸盤_吸盤4CD.不透明度 = value;
				this.手先_節7_爪_爪2CD.不透明度 = value;
				this.手先_節7_爪_爪1CD.不透明度 = value;
				this.手先_節8_節CD.不透明度 = value;
				this.手先_節8_紋柄CD.不透明度 = value;
				this.手先_節8_吸盤_吸盤1CD.不透明度 = value;
				this.手先_節8_吸盤_吸盤2CD.不透明度 = value;
				this.手先_節8_吸盤_吸盤3CD.不透明度 = value;
				this.手先_節8_吸盤_吸盤4CD.不透明度 = value;
				this.手先_節8_爪_爪2CD.不透明度 = value;
				this.手先_節8_爪_爪1CD.不透明度 = value;
				this.手先_節9_節CD.不透明度 = value;
				this.手先_節9_紋柄CD.不透明度 = value;
				this.手先_節9_吸盤_吸盤1CD.不透明度 = value;
				this.手先_節9_吸盤_吸盤2CD.不透明度 = value;
				this.手先_節9_吸盤_吸盤3CD.不透明度 = value;
				this.手先_節9_吸盤_吸盤4CD.不透明度 = value;
				this.手先_節9_爪_爪2CD.不透明度 = value;
				this.手先_節9_爪_爪1CD.不透明度 = value;
				this.手先_節10_節CD.不透明度 = value;
				this.手先_節10_紋柄CD.不透明度 = value;
				this.手先_節10_吸盤_吸盤1CD.不透明度 = value;
				this.手先_節10_吸盤_吸盤2CD.不透明度 = value;
				this.手先_節10_吸盤_吸盤3CD.不透明度 = value;
				this.手先_節10_吸盤_吸盤4CD.不透明度 = value;
				this.手先_節10_爪_爪2CD.不透明度 = value;
				this.手先_節10_爪_爪1CD.不透明度 = value;
				this.腕部_輪1_革CD.不透明度 = value;
				this.腕部_輪1_金具1CD.不透明度 = value;
				this.腕部_輪1_金具2CD.不透明度 = value;
				this.腕部_輪1_金具3CD.不透明度 = value;
				this.腕部_輪1_金具左CD.不透明度 = value;
				this.腕部_輪1_金具右CD.不透明度 = value;
				this.手先_輪2_革CD.不透明度 = value;
				this.手先_輪2_金具1CD.不透明度 = value;
				this.手先_輪2_金具2CD.不透明度 = value;
				this.手先_輪2_金具3CD.不透明度 = value;
				this.手先_輪2_金具左CD.不透明度 = value;
				this.手先_輪2_金具右CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			double num2 = 25.0;
			this.X0Y0_腕部_節1_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節2_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節3_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節4_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節5_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節6_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節7_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節8_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節9_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節10_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節11_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節12_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節13_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節14_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節15_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節16_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節17_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節18_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節19_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節20_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節21_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節22_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節23_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節24_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_腕部_節25_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_手先_節1_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_手先_節2_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_手先_節3_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_手先_節4_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_手先_節5_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_手先_節6_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_手先_節7_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_手先_節8_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_手先_節9_節.AngleBase = num2.GetRanAngle();
			this.X0Y0_手先_節10_節.AngleBase = num2.GetRanAngle();
			num2 = 47.0;
			this.X0Y0_手先_節1_爪_爪2.AngleBase = num * num2;
			this.X0Y0_手先_節1_爪_爪1.AngleBase = num * num2;
			this.X0Y0_手先_節2_爪_爪2.AngleBase = num * num2;
			this.X0Y0_手先_節2_爪_爪1.AngleBase = num * num2;
			this.X0Y0_手先_節3_爪_爪2.AngleBase = num * num2;
			this.X0Y0_手先_節3_爪_爪1.AngleBase = num * num2;
			this.X0Y0_手先_節4_爪_爪2.AngleBase = num * num2;
			this.X0Y0_手先_節4_爪_爪1.AngleBase = num * num2;
			this.X0Y0_手先_節5_爪_爪2.AngleBase = num * num2;
			this.X0Y0_手先_節5_爪_爪1.AngleBase = num * num2;
			this.X0Y0_手先_節6_爪_爪2.AngleBase = num * num2;
			this.X0Y0_手先_節6_爪_爪1.AngleBase = num * num2;
			this.X0Y0_手先_節7_爪_爪2.AngleBase = num * num2;
			this.X0Y0_手先_節7_爪_爪1.AngleBase = num * num2;
			this.X0Y0_手先_節8_爪_爪2.AngleBase = num * num2;
			this.X0Y0_手先_節8_爪_爪1.AngleBase = num * num2;
			this.X0Y0_手先_節9_爪_爪2.AngleBase = num * num2;
			this.X0Y0_手先_節9_爪_爪1.AngleBase = num * num2;
			this.X0Y0_手先_節10_爪_爪2.AngleBase = num * num2;
			this.X0Y0_手先_節10_爪_爪1.AngleBase = num * num2;
			this.本体.JoinPAall();
		}

		public void Set角度(触手_触 触)
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_腕部_節1_節.AngleBase = num * 触.X0Y0_腕部_節1_節.AngleBase;
			this.X0Y0_腕部_節2_節.AngleBase = num * 触.X0Y0_腕部_節2_節.AngleBase;
			this.X0Y0_腕部_節3_節.AngleBase = num * 触.X0Y0_腕部_節3_節.AngleBase;
			this.X0Y0_腕部_節4_節.AngleBase = num * 触.X0Y0_腕部_節4_節.AngleBase;
			this.X0Y0_腕部_節5_節.AngleBase = num * 触.X0Y0_腕部_節5_節.AngleBase;
			this.X0Y0_腕部_節6_節.AngleBase = num * 触.X0Y0_腕部_節6_節.AngleBase;
			this.X0Y0_腕部_節7_節.AngleBase = num * 触.X0Y0_腕部_節7_節.AngleBase;
			this.X0Y0_腕部_節8_節.AngleBase = num * 触.X0Y0_腕部_節8_節.AngleBase;
			this.X0Y0_腕部_節9_節.AngleBase = num * 触.X0Y0_腕部_節9_節.AngleBase;
			this.X0Y0_腕部_節10_節.AngleBase = num * 触.X0Y0_腕部_節10_節.AngleBase;
			this.X0Y0_腕部_節11_節.AngleBase = num * 触.X0Y0_腕部_節11_節.AngleBase;
			this.X0Y0_腕部_節12_節.AngleBase = num * 触.X0Y0_腕部_節12_節.AngleBase;
			this.X0Y0_腕部_節13_節.AngleBase = num * 触.X0Y0_腕部_節13_節.AngleBase;
			this.X0Y0_腕部_節14_節.AngleBase = num * 触.X0Y0_腕部_節14_節.AngleBase;
			this.X0Y0_腕部_節15_節.AngleBase = num * 触.X0Y0_腕部_節15_節.AngleBase;
			this.X0Y0_腕部_節16_節.AngleBase = num * 触.X0Y0_腕部_節16_節.AngleBase;
			this.X0Y0_腕部_節17_節.AngleBase = num * 触.X0Y0_腕部_節17_節.AngleBase;
			this.X0Y0_腕部_節18_節.AngleBase = num * 触.X0Y0_腕部_節18_節.AngleBase;
			this.X0Y0_腕部_節19_節.AngleBase = num * 触.X0Y0_腕部_節19_節.AngleBase;
			this.X0Y0_腕部_節20_節.AngleBase = num * 触.X0Y0_腕部_節20_節.AngleBase;
			this.X0Y0_腕部_節21_節.AngleBase = num * 触.X0Y0_腕部_節21_節.AngleBase;
			this.X0Y0_腕部_節22_節.AngleBase = num * 触.X0Y0_腕部_節22_節.AngleBase;
			this.X0Y0_腕部_節23_節.AngleBase = num * 触.X0Y0_腕部_節23_節.AngleBase;
			this.X0Y0_腕部_節24_節.AngleBase = num * 触.X0Y0_腕部_節24_節.AngleBase;
			this.X0Y0_腕部_節25_節.AngleBase = num * 触.X0Y0_腕部_節25_節.AngleBase;
			this.X0Y0_手先_節1_節.AngleBase = num * 触.X0Y0_手先_節1_節.AngleBase;
			this.X0Y0_手先_節2_節.AngleBase = num * 触.X0Y0_手先_節2_節.AngleBase;
			this.X0Y0_手先_節3_節.AngleBase = num * 触.X0Y0_手先_節3_節.AngleBase;
			this.X0Y0_手先_節4_節.AngleBase = num * 触.X0Y0_手先_節4_節.AngleBase;
			this.X0Y0_手先_節5_節.AngleBase = num * 触.X0Y0_手先_節5_節.AngleBase;
			this.X0Y0_手先_節6_節.AngleBase = num * 触.X0Y0_手先_節6_節.AngleBase;
			this.X0Y0_手先_節7_節.AngleBase = num * 触.X0Y0_手先_節7_節.AngleBase;
			this.X0Y0_手先_節8_節.AngleBase = num * 触.X0Y0_手先_節8_節.AngleBase;
			this.X0Y0_手先_節9_節.AngleBase = num * 触.X0Y0_手先_節9_節.AngleBase;
			this.X0Y0_手先_節10_節.AngleBase = num * 触.X0Y0_手先_節10_節.AngleBase;
			this.X0Y0_手先_節1_爪_爪2.AngleBase = num * 触.X0Y0_手先_節1_爪_爪2.AngleBase;
			this.X0Y0_手先_節1_爪_爪1.AngleBase = num * 触.X0Y0_手先_節1_爪_爪1.AngleBase;
			this.X0Y0_手先_節2_爪_爪2.AngleBase = num * 触.X0Y0_手先_節2_爪_爪2.AngleBase;
			this.X0Y0_手先_節2_爪_爪1.AngleBase = num * 触.X0Y0_手先_節2_爪_爪1.AngleBase;
			this.X0Y0_手先_節3_爪_爪2.AngleBase = num * 触.X0Y0_手先_節3_爪_爪2.AngleBase;
			this.X0Y0_手先_節3_爪_爪1.AngleBase = num * 触.X0Y0_手先_節3_爪_爪1.AngleBase;
			this.X0Y0_手先_節4_爪_爪2.AngleBase = num * 触.X0Y0_手先_節4_爪_爪2.AngleBase;
			this.X0Y0_手先_節4_爪_爪1.AngleBase = num * 触.X0Y0_手先_節4_爪_爪1.AngleBase;
			this.X0Y0_手先_節5_爪_爪2.AngleBase = num * 触.X0Y0_手先_節5_爪_爪2.AngleBase;
			this.X0Y0_手先_節5_爪_爪1.AngleBase = num * 触.X0Y0_手先_節5_爪_爪1.AngleBase;
			this.X0Y0_手先_節6_爪_爪2.AngleBase = num * 触.X0Y0_手先_節6_爪_爪2.AngleBase;
			this.X0Y0_手先_節6_爪_爪1.AngleBase = num * 触.X0Y0_手先_節6_爪_爪1.AngleBase;
			this.X0Y0_手先_節7_爪_爪2.AngleBase = num * 触.X0Y0_手先_節7_爪_爪2.AngleBase;
			this.X0Y0_手先_節7_爪_爪1.AngleBase = num * 触.X0Y0_手先_節7_爪_爪1.AngleBase;
			this.X0Y0_手先_節8_爪_爪2.AngleBase = num * 触.X0Y0_手先_節8_爪_爪2.AngleBase;
			this.X0Y0_手先_節8_爪_爪1.AngleBase = num * 触.X0Y0_手先_節8_爪_爪1.AngleBase;
			this.X0Y0_手先_節9_爪_爪2.AngleBase = num * 触.X0Y0_手先_節9_爪_爪2.AngleBase;
			this.X0Y0_手先_節9_爪_爪1.AngleBase = num * 触.X0Y0_手先_節9_爪_爪1.AngleBase;
			this.X0Y0_手先_節10_爪_爪2.AngleBase = num * 触.X0Y0_手先_節10_爪_爪2.AngleBase;
			this.X0Y0_手先_節10_爪_爪1.AngleBase = num * 触.X0Y0_手先_節10_爪_爪1.AngleBase;
			this.本体.JoinPAall();
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_腕部_輪1_革 || p == this.X0Y0_腕部_輪1_金具1 || p == this.X0Y0_腕部_輪1_金具2 || p == this.X0Y0_腕部_輪1_金具3 || p == this.X0Y0_腕部_輪1_金具左 || p == this.X0Y0_腕部_輪1_金具右 || p == this.X0Y0_手先_輪2_革 || p == this.X0Y0_手先_輪2_金具1 || p == this.X0Y0_手先_輪2_金具2 || p == this.X0Y0_手先_輪2_金具3 || p == this.X0Y0_手先_輪2_金具左 || p == this.X0Y0_手先_輪2_金具右;
		}

		public override IEnumerable<Par> Enum軸()
		{
			yield return this.X0Y0_腕部_節1_節;
			yield return this.X0Y0_腕部_節2_節;
			yield return this.X0Y0_腕部_節3_節;
			yield return this.X0Y0_腕部_節4_節;
			yield return this.X0Y0_腕部_節5_節;
			yield return this.X0Y0_腕部_節6_節;
			yield return this.X0Y0_腕部_節7_節;
			yield return this.X0Y0_腕部_節8_節;
			yield return this.X0Y0_腕部_節9_節;
			yield return this.X0Y0_腕部_節10_節;
			yield return this.X0Y0_腕部_節11_節;
			yield return this.X0Y0_腕部_節12_節;
			yield return this.X0Y0_腕部_節13_節;
			yield return this.X0Y0_腕部_節14_節;
			yield return this.X0Y0_腕部_節15_節;
			yield return this.X0Y0_腕部_節16_節;
			yield return this.X0Y0_腕部_節17_節;
			yield return this.X0Y0_腕部_節18_節;
			yield return this.X0Y0_腕部_節19_節;
			yield return this.X0Y0_腕部_節20_節;
			yield return this.X0Y0_腕部_節21_節;
			yield return this.X0Y0_腕部_節22_節;
			yield return this.X0Y0_腕部_節23_節;
			yield return this.X0Y0_腕部_節24_節;
			yield return this.X0Y0_腕部_節25_節;
			yield return this.X0Y0_手先_節1_節;
			yield return this.X0Y0_手先_節2_節;
			yield return this.X0Y0_手先_節3_節;
			yield return this.X0Y0_手先_節4_節;
			yield return this.X0Y0_手先_節5_節;
			yield return this.X0Y0_手先_節6_節;
			yield return this.X0Y0_手先_節7_節;
			yield return this.X0Y0_手先_節8_節;
			yield return this.X0Y0_手先_節9_節;
			yield return this.X0Y0_手先_節10_節;
			yield break;
		}

		public JointS 鎖1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腕部_輪1_金具左, 0);
			}
		}

		public JointS 鎖2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_腕部_輪1_金具右, 0);
			}
		}

		public JointS 鎖3_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_手先_輪2_金具左, 0);
			}
		}

		public JointS 鎖4_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_手先_輪2_金具右, 0);
			}
		}

		public override void 色更新()
		{
			this.Pars.GetMiY_MaY(out this.mm);
			this.X0Y0_腕部_節1_節CP.Update(this.mm);
			this.X0Y0_腕部_節1_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節1_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_節2_節CP.Update(this.mm);
			this.X0Y0_腕部_節2_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節2_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_節3_節CP.Update(this.mm);
			this.X0Y0_腕部_節3_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節3_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_節4_節CP.Update(this.mm);
			this.X0Y0_腕部_節4_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節4_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_節5_節CP.Update(this.mm);
			this.X0Y0_腕部_節5_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節5_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_節6_節CP.Update(this.mm);
			this.X0Y0_腕部_節6_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節6_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_節7_節CP.Update(this.mm);
			this.X0Y0_腕部_節7_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節7_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_節8_節CP.Update(this.mm);
			this.X0Y0_腕部_節8_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節8_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_節9_節CP.Update(this.mm);
			this.X0Y0_腕部_節9_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節9_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_節10_節CP.Update(this.mm);
			this.X0Y0_腕部_節10_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節10_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_節11_節CP.Update(this.mm);
			this.X0Y0_腕部_節11_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節11_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_節12_節CP.Update(this.mm);
			this.X0Y0_腕部_節12_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節12_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_節13_節CP.Update(this.mm);
			this.X0Y0_腕部_節13_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節13_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_節14_節CP.Update(this.mm);
			this.X0Y0_腕部_節14_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節14_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_節15_節CP.Update(this.mm);
			this.X0Y0_腕部_節15_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節15_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_輪1_革CP.Update();
			this.X0Y0_腕部_輪1_金具1CP.Update();
			this.X0Y0_腕部_輪1_金具2CP.Update();
			this.X0Y0_腕部_輪1_金具3CP.Update();
			this.X0Y0_腕部_輪1_金具左CP.Update();
			this.X0Y0_腕部_輪1_金具右CP.Update();
			this.X0Y0_腕部_節16_節CP.Update(this.mm);
			this.X0Y0_腕部_節16_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節16_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_節17_節CP.Update(this.mm);
			this.X0Y0_腕部_節17_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節17_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_節18_節CP.Update(this.mm);
			this.X0Y0_腕部_節18_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節18_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_節19_節CP.Update(this.mm);
			this.X0Y0_腕部_節19_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節19_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_節20_節CP.Update(this.mm);
			this.X0Y0_腕部_節20_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節20_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_節21_節CP.Update(this.mm);
			this.X0Y0_腕部_節21_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節21_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_節22_節CP.Update(this.mm);
			this.X0Y0_腕部_節22_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節22_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_節23_節CP.Update(this.mm);
			this.X0Y0_腕部_節23_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節23_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_節24_節CP.Update(this.mm);
			this.X0Y0_腕部_節24_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節24_紋柄_紋柄2CP.Update();
			this.X0Y0_腕部_節25_節CP.Update(this.mm);
			this.X0Y0_腕部_節25_紋柄_紋柄1CP.Update();
			this.X0Y0_腕部_節25_紋柄_紋柄2CP.Update();
			this.X0Y0_手先_節1_節CP.Update(this.mm);
			this.X0Y0_手先_節1_紋柄1CP.Update();
			this.X0Y0_手先_節1_紋柄2CP.Update();
			this.X0Y0_手先_節1_吸盤_吸盤1CP.Update();
			this.X0Y0_手先_節1_吸盤_吸盤2CP.Update();
			this.X0Y0_手先_節1_吸盤_吸盤3CP.Update();
			this.X0Y0_手先_節1_吸盤_吸盤4CP.Update();
			this.X0Y0_手先_節1_爪_爪2CP.Update();
			this.X0Y0_手先_節1_爪_爪1CP.Update();
			this.X0Y0_手先_輪2_革CP.Update();
			this.X0Y0_手先_輪2_金具1CP.Update();
			this.X0Y0_手先_輪2_金具2CP.Update();
			this.X0Y0_手先_輪2_金具3CP.Update();
			this.X0Y0_手先_輪2_金具左CP.Update();
			this.X0Y0_手先_輪2_金具右CP.Update();
			this.X0Y0_手先_節2_節CP.Update(this.mm);
			this.X0Y0_手先_節2_紋柄1CP.Update();
			this.X0Y0_手先_節2_紋柄2CP.Update();
			this.X0Y0_手先_節2_吸盤_吸盤1CP.Update();
			this.X0Y0_手先_節2_吸盤_吸盤2CP.Update();
			this.X0Y0_手先_節2_吸盤_吸盤3CP.Update();
			this.X0Y0_手先_節2_吸盤_吸盤4CP.Update();
			this.X0Y0_手先_節2_爪_爪2CP.Update();
			this.X0Y0_手先_節2_爪_爪1CP.Update();
			this.X0Y0_手先_節3_節CP.Update(this.mm);
			this.X0Y0_手先_節3_紋柄1CP.Update();
			this.X0Y0_手先_節3_紋柄2CP.Update();
			this.X0Y0_手先_節3_吸盤_吸盤1CP.Update();
			this.X0Y0_手先_節3_吸盤_吸盤2CP.Update();
			this.X0Y0_手先_節3_吸盤_吸盤3CP.Update();
			this.X0Y0_手先_節3_吸盤_吸盤4CP.Update();
			this.X0Y0_手先_節3_爪_爪2CP.Update();
			this.X0Y0_手先_節3_爪_爪1CP.Update();
			this.X0Y0_手先_節4_節CP.Update(this.mm);
			this.X0Y0_手先_節4_紋柄1CP.Update();
			this.X0Y0_手先_節4_紋柄2CP.Update();
			this.X0Y0_手先_節4_吸盤_吸盤1CP.Update();
			this.X0Y0_手先_節4_吸盤_吸盤2CP.Update();
			this.X0Y0_手先_節4_吸盤_吸盤3CP.Update();
			this.X0Y0_手先_節4_吸盤_吸盤4CP.Update();
			this.X0Y0_手先_節4_爪_爪2CP.Update();
			this.X0Y0_手先_節4_爪_爪1CP.Update();
			this.X0Y0_手先_節5_節CP.Update(this.mm);
			this.X0Y0_手先_節5_紋柄1CP.Update();
			this.X0Y0_手先_節5_紋柄2CP.Update();
			this.X0Y0_手先_節5_吸盤_吸盤1CP.Update();
			this.X0Y0_手先_節5_吸盤_吸盤2CP.Update();
			this.X0Y0_手先_節5_吸盤_吸盤3CP.Update();
			this.X0Y0_手先_節5_吸盤_吸盤4CP.Update();
			this.X0Y0_手先_節5_爪_爪2CP.Update();
			this.X0Y0_手先_節5_爪_爪1CP.Update();
			this.X0Y0_手先_節6_節CP.Update(this.mm);
			this.X0Y0_手先_節6_紋柄1CP.Update();
			this.X0Y0_手先_節6_紋柄2CP.Update();
			this.X0Y0_手先_節6_吸盤_吸盤1CP.Update();
			this.X0Y0_手先_節6_吸盤_吸盤2CP.Update();
			this.X0Y0_手先_節6_吸盤_吸盤3CP.Update();
			this.X0Y0_手先_節6_吸盤_吸盤4CP.Update();
			this.X0Y0_手先_節6_爪_爪2CP.Update();
			this.X0Y0_手先_節6_爪_爪1CP.Update();
			this.X0Y0_手先_節7_節CP.Update(this.mm);
			this.X0Y0_手先_節7_紋柄CP.Update();
			this.X0Y0_手先_節7_吸盤_吸盤1CP.Update();
			this.X0Y0_手先_節7_吸盤_吸盤2CP.Update();
			this.X0Y0_手先_節7_吸盤_吸盤3CP.Update();
			this.X0Y0_手先_節7_吸盤_吸盤4CP.Update();
			this.X0Y0_手先_節7_爪_爪2CP.Update();
			this.X0Y0_手先_節7_爪_爪1CP.Update();
			this.X0Y0_手先_節8_節CP.Update(this.mm);
			this.X0Y0_手先_節8_紋柄CP.Update();
			this.X0Y0_手先_節8_吸盤_吸盤1CP.Update();
			this.X0Y0_手先_節8_吸盤_吸盤2CP.Update();
			this.X0Y0_手先_節8_吸盤_吸盤3CP.Update();
			this.X0Y0_手先_節8_吸盤_吸盤4CP.Update();
			this.X0Y0_手先_節8_爪_爪2CP.Update();
			this.X0Y0_手先_節8_爪_爪1CP.Update();
			this.X0Y0_手先_節9_節CP.Update(this.mm);
			this.X0Y0_手先_節9_紋柄CP.Update();
			this.X0Y0_手先_節9_吸盤_吸盤1CP.Update();
			this.X0Y0_手先_節9_吸盤_吸盤2CP.Update();
			this.X0Y0_手先_節9_吸盤_吸盤3CP.Update();
			this.X0Y0_手先_節9_吸盤_吸盤4CP.Update();
			this.X0Y0_手先_節9_爪_爪2CP.Update();
			this.X0Y0_手先_節9_爪_爪1CP.Update();
			this.X0Y0_手先_節10_節CP.Update(this.mm);
			this.X0Y0_手先_節10_紋柄CP.Update();
			this.X0Y0_手先_節10_吸盤_吸盤1CP.Update();
			this.X0Y0_手先_節10_吸盤_吸盤2CP.Update();
			this.X0Y0_手先_節10_吸盤_吸盤3CP.Update();
			this.X0Y0_手先_節10_吸盤_吸盤4CP.Update();
			this.X0Y0_手先_節10_爪_爪2CP.Update();
			this.X0Y0_手先_節10_爪_爪1CP.Update();
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
			this.腕部_節1_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節1_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節1_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節2_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節2_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節2_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節3_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節3_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節3_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節4_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節4_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節4_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節5_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節5_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節5_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節6_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節6_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節6_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節7_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節7_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節7_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節8_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節8_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節8_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節9_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節9_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節9_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節10_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節10_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節10_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節11_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節11_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節11_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節12_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節12_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節12_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節13_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節13_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節13_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節14_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節14_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節14_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節15_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節15_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節15_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節16_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節16_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節16_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節17_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節17_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節17_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節18_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節18_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節18_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節19_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節19_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節19_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節20_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節20_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節20_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節21_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節21_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節21_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節22_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節22_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節22_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節23_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節23_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節23_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節24_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節24_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節24_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節25_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.腕部_節25_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節25_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節1_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.手先_節1_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節1_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節1_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節1_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節1_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節1_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節1_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節1_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節2_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.手先_節2_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節2_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節2_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節2_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節2_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節2_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節2_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節2_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節3_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.手先_節3_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節3_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節3_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節3_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節3_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節3_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節3_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節3_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節4_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.手先_節4_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節4_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節4_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節4_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節4_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節4_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節4_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節4_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節5_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.手先_節5_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節5_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節5_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節5_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節5_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節5_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節5_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節5_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節6_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.手先_節6_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節6_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節6_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節6_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節6_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節6_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節6_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節6_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節7_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.手先_節7_紋柄CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節7_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節7_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節7_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節7_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節7_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節7_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節8_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.手先_節8_紋柄CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節8_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節8_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節8_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節8_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節8_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節8_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節9_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.手先_節9_紋柄CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節9_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節9_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節9_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節9_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節9_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節9_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節10_節CD = new ColorD(ref Col.Black, ref 体配色.体1O);
			this.手先_節10_紋柄CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節10_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節10_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節10_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節10_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節10_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節10_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.腕部_輪1_革CD = new ColorD();
			this.腕部_輪1_金具1CD = new ColorD();
			this.腕部_輪1_金具2CD = new ColorD();
			this.腕部_輪1_金具3CD = new ColorD();
			this.腕部_輪1_金具左CD = new ColorD();
			this.腕部_輪1_金具右CD = new ColorD();
			this.手先_輪2_革CD = new ColorD();
			this.手先_輪2_金具1CD = new ColorD();
			this.手先_輪2_金具2CD = new ColorD();
			this.手先_輪2_金具3CD = new ColorD();
			this.手先_輪2_金具左CD = new ColorD();
			this.手先_輪2_金具右CD = new ColorD();
		}

		private void 配色T0(体配色 体配色)
		{
			this.配色T(0, "節CD", ref 体配色.体1O, ref 体配色.刺青O);
			this.腕部_節1_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節1_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節2_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節2_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節3_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節3_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節4_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節4_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節5_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節5_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節6_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節6_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節7_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節7_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節8_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節8_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節9_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節9_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節10_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節10_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節11_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節11_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節12_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節12_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節13_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節13_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節14_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節14_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節15_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節15_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節16_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節16_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節17_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節17_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節18_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節18_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節19_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節19_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節20_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節20_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節21_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節21_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節22_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節22_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節23_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節23_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節24_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節24_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節25_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節25_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節1_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節1_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節1_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節1_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節1_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節1_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節1_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節1_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節2_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節2_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節2_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節2_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節2_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節2_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節2_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節2_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節3_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節3_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節3_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節3_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節3_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節3_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節3_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節3_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節4_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節4_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節4_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節4_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節4_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節4_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節4_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節4_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節5_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節5_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節5_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節5_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節5_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節5_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節5_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節5_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節6_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節6_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節6_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節6_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節6_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節6_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節6_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節6_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節7_紋柄CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節7_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節7_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節7_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節7_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節7_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節7_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節8_紋柄CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節8_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節8_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節8_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節8_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節8_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節8_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節9_紋柄CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節9_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節9_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節9_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節9_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節9_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節9_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節10_紋柄CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節10_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節10_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節10_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節10_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節10_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節10_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.腕部_輪1_革CD = new ColorD();
			this.腕部_輪1_金具1CD = new ColorD();
			this.腕部_輪1_金具2CD = new ColorD();
			this.腕部_輪1_金具3CD = new ColorD();
			this.腕部_輪1_金具左CD = new ColorD();
			this.腕部_輪1_金具右CD = new ColorD();
			this.手先_輪2_革CD = new ColorD();
			this.手先_輪2_金具1CD = new ColorD();
			this.手先_輪2_金具2CD = new ColorD();
			this.手先_輪2_金具3CD = new ColorD();
			this.手先_輪2_金具左CD = new ColorD();
			this.手先_輪2_金具右CD = new ColorD();
		}

		private void 配色T1(体配色 体配色)
		{
			this.配色T(1, "節CD", ref 体配色.体1O, ref 体配色.刺青O);
			this.腕部_節1_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節1_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節2_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節2_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節3_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節3_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節4_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節4_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節5_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節5_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節6_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節6_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節7_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節7_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節8_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節8_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節9_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節9_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節10_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節10_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節11_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節11_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節12_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節12_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節13_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節13_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節14_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節14_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節15_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節15_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節16_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節16_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節17_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節17_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節18_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節18_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節19_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節19_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節20_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節20_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節21_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節21_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節22_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節22_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節23_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節23_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節24_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節24_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節25_紋柄_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.腕部_節25_紋柄_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節1_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節1_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節1_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節1_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節1_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節1_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節1_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節1_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節2_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節2_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節2_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節2_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節2_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節2_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節2_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節2_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節3_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節3_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節3_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節3_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節3_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節3_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節3_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節3_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節4_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節4_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節4_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節4_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節4_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節4_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節4_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節4_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節5_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節5_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節5_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節5_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節5_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節5_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節5_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節5_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節6_紋柄1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節6_紋柄2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節6_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節6_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節6_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節6_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節6_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節6_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節7_紋柄CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節7_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節7_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節7_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節7_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節7_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節7_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節8_紋柄CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節8_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節8_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節8_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節8_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節8_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節8_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節9_紋柄CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節9_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節9_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節9_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節9_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節9_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節9_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節10_紋柄CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
			this.手先_節10_吸盤_吸盤1CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節10_吸盤_吸盤2CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節10_吸盤_吸盤3CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節10_吸盤_吸盤4CD = new ColorD(ref Col.Black, ref 体配色.白部O);
			this.手先_節10_爪_爪2CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.手先_節10_爪_爪1CD = new ColorD(ref Col.Black, ref 体配色.爪O);
			this.腕部_輪1_革CD = new ColorD();
			this.腕部_輪1_金具1CD = new ColorD();
			this.腕部_輪1_金具2CD = new ColorD();
			this.腕部_輪1_金具3CD = new ColorD();
			this.腕部_輪1_金具左CD = new ColorD();
			this.腕部_輪1_金具右CD = new ColorD();
			this.手先_輪2_革CD = new ColorD();
			this.手先_輪2_金具1CD = new ColorD();
			this.手先_輪2_金具2CD = new ColorD();
			this.手先_輪2_金具3CD = new ColorD();
			this.手先_輪2_金具左CD = new ColorD();
			this.手先_輪2_金具右CD = new ColorD();
		}

		public void 輪1配色(拘束具色 配色)
		{
			this.腕部_輪1_革CD.色 = 配色.革部色;
			this.腕部_輪1_金具1CD.色 = 配色.金具色;
			this.腕部_輪1_金具2CD.色 = this.腕部_輪1_金具1CD.色;
			this.腕部_輪1_金具3CD.色 = this.腕部_輪1_金具1CD.色;
			this.腕部_輪1_金具左CD.色 = this.腕部_輪1_金具1CD.色;
			this.腕部_輪1_金具右CD.色 = this.腕部_輪1_金具1CD.色;
		}

		public void 輪2配色(拘束具色 配色)
		{
			this.手先_輪2_革CD.色 = 配色.革部色;
			this.手先_輪2_金具1CD.色 = 配色.金具色;
			this.手先_輪2_金具2CD.色 = this.手先_輪2_金具1CD.色;
			this.手先_輪2_金具3CD.色 = this.手先_輪2_金具1CD.色;
			this.手先_輪2_金具左CD.色 = this.手先_輪2_金具1CD.色;
			this.手先_輪2_金具右CD.色 = this.手先_輪2_金具1CD.色;
		}

		public void 鎖配色(鎖色 配色)
		{
			this.鎖1.配色鎖(配色);
			this.鎖2.配色鎖(配色);
			this.鎖3.配色鎖(配色);
			this.鎖4.配色鎖(配色);
		}

		public Par X0Y0_腕部_節1_節;

		public Par X0Y0_腕部_節1_紋柄_紋柄1;

		public Par X0Y0_腕部_節1_紋柄_紋柄2;

		public Par X0Y0_腕部_節2_節;

		public Par X0Y0_腕部_節2_紋柄_紋柄1;

		public Par X0Y0_腕部_節2_紋柄_紋柄2;

		public Par X0Y0_腕部_節3_節;

		public Par X0Y0_腕部_節3_紋柄_紋柄1;

		public Par X0Y0_腕部_節3_紋柄_紋柄2;

		public Par X0Y0_腕部_節4_節;

		public Par X0Y0_腕部_節4_紋柄_紋柄1;

		public Par X0Y0_腕部_節4_紋柄_紋柄2;

		public Par X0Y0_腕部_節5_節;

		public Par X0Y0_腕部_節5_紋柄_紋柄1;

		public Par X0Y0_腕部_節5_紋柄_紋柄2;

		public Par X0Y0_腕部_節6_節;

		public Par X0Y0_腕部_節6_紋柄_紋柄1;

		public Par X0Y0_腕部_節6_紋柄_紋柄2;

		public Par X0Y0_腕部_節7_節;

		public Par X0Y0_腕部_節7_紋柄_紋柄1;

		public Par X0Y0_腕部_節7_紋柄_紋柄2;

		public Par X0Y0_腕部_節8_節;

		public Par X0Y0_腕部_節8_紋柄_紋柄1;

		public Par X0Y0_腕部_節8_紋柄_紋柄2;

		public Par X0Y0_腕部_節9_節;

		public Par X0Y0_腕部_節9_紋柄_紋柄1;

		public Par X0Y0_腕部_節9_紋柄_紋柄2;

		public Par X0Y0_腕部_節10_節;

		public Par X0Y0_腕部_節10_紋柄_紋柄1;

		public Par X0Y0_腕部_節10_紋柄_紋柄2;

		public Par X0Y0_腕部_節11_節;

		public Par X0Y0_腕部_節11_紋柄_紋柄1;

		public Par X0Y0_腕部_節11_紋柄_紋柄2;

		public Par X0Y0_腕部_節12_節;

		public Par X0Y0_腕部_節12_紋柄_紋柄1;

		public Par X0Y0_腕部_節12_紋柄_紋柄2;

		public Par X0Y0_腕部_節13_節;

		public Par X0Y0_腕部_節13_紋柄_紋柄1;

		public Par X0Y0_腕部_節13_紋柄_紋柄2;

		public Par X0Y0_腕部_節14_節;

		public Par X0Y0_腕部_節14_紋柄_紋柄1;

		public Par X0Y0_腕部_節14_紋柄_紋柄2;

		public Par X0Y0_腕部_節15_節;

		public Par X0Y0_腕部_節15_紋柄_紋柄1;

		public Par X0Y0_腕部_節15_紋柄_紋柄2;

		public Par X0Y0_腕部_輪1_革;

		public Par X0Y0_腕部_輪1_金具1;

		public Par X0Y0_腕部_輪1_金具2;

		public Par X0Y0_腕部_輪1_金具3;

		public Par X0Y0_腕部_輪1_金具左;

		public Par X0Y0_腕部_輪1_金具右;

		public Par X0Y0_腕部_節16_節;

		public Par X0Y0_腕部_節16_紋柄_紋柄1;

		public Par X0Y0_腕部_節16_紋柄_紋柄2;

		public Par X0Y0_腕部_節17_節;

		public Par X0Y0_腕部_節17_紋柄_紋柄1;

		public Par X0Y0_腕部_節17_紋柄_紋柄2;

		public Par X0Y0_腕部_節18_節;

		public Par X0Y0_腕部_節18_紋柄_紋柄1;

		public Par X0Y0_腕部_節18_紋柄_紋柄2;

		public Par X0Y0_腕部_節19_節;

		public Par X0Y0_腕部_節19_紋柄_紋柄1;

		public Par X0Y0_腕部_節19_紋柄_紋柄2;

		public Par X0Y0_腕部_節20_節;

		public Par X0Y0_腕部_節20_紋柄_紋柄1;

		public Par X0Y0_腕部_節20_紋柄_紋柄2;

		public Par X0Y0_腕部_節21_節;

		public Par X0Y0_腕部_節21_紋柄_紋柄1;

		public Par X0Y0_腕部_節21_紋柄_紋柄2;

		public Par X0Y0_腕部_節22_節;

		public Par X0Y0_腕部_節22_紋柄_紋柄1;

		public Par X0Y0_腕部_節22_紋柄_紋柄2;

		public Par X0Y0_腕部_節23_節;

		public Par X0Y0_腕部_節23_紋柄_紋柄1;

		public Par X0Y0_腕部_節23_紋柄_紋柄2;

		public Par X0Y0_腕部_節24_節;

		public Par X0Y0_腕部_節24_紋柄_紋柄1;

		public Par X0Y0_腕部_節24_紋柄_紋柄2;

		public Par X0Y0_腕部_節25_節;

		public Par X0Y0_腕部_節25_紋柄_紋柄1;

		public Par X0Y0_腕部_節25_紋柄_紋柄2;

		public Par X0Y0_手先_節1_節;

		public Par X0Y0_手先_節1_紋柄1;

		public Par X0Y0_手先_節1_紋柄2;

		public Par X0Y0_手先_節1_吸盤_吸盤1;

		public Par X0Y0_手先_節1_吸盤_吸盤2;

		public Par X0Y0_手先_節1_吸盤_吸盤3;

		public Par X0Y0_手先_節1_吸盤_吸盤4;

		public Par X0Y0_手先_節1_爪_爪2;

		public Par X0Y0_手先_節1_爪_爪1;

		public Par X0Y0_手先_輪2_革;

		public Par X0Y0_手先_輪2_金具1;

		public Par X0Y0_手先_輪2_金具2;

		public Par X0Y0_手先_輪2_金具3;

		public Par X0Y0_手先_輪2_金具左;

		public Par X0Y0_手先_輪2_金具右;

		public Par X0Y0_手先_節2_節;

		public Par X0Y0_手先_節2_紋柄1;

		public Par X0Y0_手先_節2_紋柄2;

		public Par X0Y0_手先_節2_吸盤_吸盤1;

		public Par X0Y0_手先_節2_吸盤_吸盤2;

		public Par X0Y0_手先_節2_吸盤_吸盤3;

		public Par X0Y0_手先_節2_吸盤_吸盤4;

		public Par X0Y0_手先_節2_爪_爪2;

		public Par X0Y0_手先_節2_爪_爪1;

		public Par X0Y0_手先_節3_節;

		public Par X0Y0_手先_節3_紋柄1;

		public Par X0Y0_手先_節3_紋柄2;

		public Par X0Y0_手先_節3_吸盤_吸盤1;

		public Par X0Y0_手先_節3_吸盤_吸盤2;

		public Par X0Y0_手先_節3_吸盤_吸盤3;

		public Par X0Y0_手先_節3_吸盤_吸盤4;

		public Par X0Y0_手先_節3_爪_爪2;

		public Par X0Y0_手先_節3_爪_爪1;

		public Par X0Y0_手先_節4_節;

		public Par X0Y0_手先_節4_紋柄1;

		public Par X0Y0_手先_節4_紋柄2;

		public Par X0Y0_手先_節4_吸盤_吸盤1;

		public Par X0Y0_手先_節4_吸盤_吸盤2;

		public Par X0Y0_手先_節4_吸盤_吸盤3;

		public Par X0Y0_手先_節4_吸盤_吸盤4;

		public Par X0Y0_手先_節4_爪_爪2;

		public Par X0Y0_手先_節4_爪_爪1;

		public Par X0Y0_手先_節5_節;

		public Par X0Y0_手先_節5_紋柄1;

		public Par X0Y0_手先_節5_紋柄2;

		public Par X0Y0_手先_節5_吸盤_吸盤1;

		public Par X0Y0_手先_節5_吸盤_吸盤2;

		public Par X0Y0_手先_節5_吸盤_吸盤3;

		public Par X0Y0_手先_節5_吸盤_吸盤4;

		public Par X0Y0_手先_節5_爪_爪2;

		public Par X0Y0_手先_節5_爪_爪1;

		public Par X0Y0_手先_節6_節;

		public Par X0Y0_手先_節6_紋柄1;

		public Par X0Y0_手先_節6_紋柄2;

		public Par X0Y0_手先_節6_吸盤_吸盤1;

		public Par X0Y0_手先_節6_吸盤_吸盤2;

		public Par X0Y0_手先_節6_吸盤_吸盤3;

		public Par X0Y0_手先_節6_吸盤_吸盤4;

		public Par X0Y0_手先_節6_爪_爪2;

		public Par X0Y0_手先_節6_爪_爪1;

		public Par X0Y0_手先_節7_節;

		public Par X0Y0_手先_節7_紋柄;

		public Par X0Y0_手先_節7_吸盤_吸盤1;

		public Par X0Y0_手先_節7_吸盤_吸盤2;

		public Par X0Y0_手先_節7_吸盤_吸盤3;

		public Par X0Y0_手先_節7_吸盤_吸盤4;

		public Par X0Y0_手先_節7_爪_爪2;

		public Par X0Y0_手先_節7_爪_爪1;

		public Par X0Y0_手先_節8_節;

		public Par X0Y0_手先_節8_紋柄;

		public Par X0Y0_手先_節8_吸盤_吸盤1;

		public Par X0Y0_手先_節8_吸盤_吸盤2;

		public Par X0Y0_手先_節8_吸盤_吸盤3;

		public Par X0Y0_手先_節8_吸盤_吸盤4;

		public Par X0Y0_手先_節8_爪_爪2;

		public Par X0Y0_手先_節8_爪_爪1;

		public Par X0Y0_手先_節9_節;

		public Par X0Y0_手先_節9_紋柄;

		public Par X0Y0_手先_節9_吸盤_吸盤1;

		public Par X0Y0_手先_節9_吸盤_吸盤2;

		public Par X0Y0_手先_節9_吸盤_吸盤3;

		public Par X0Y0_手先_節9_吸盤_吸盤4;

		public Par X0Y0_手先_節9_爪_爪2;

		public Par X0Y0_手先_節9_爪_爪1;

		public Par X0Y0_手先_節10_節;

		public Par X0Y0_手先_節10_紋柄;

		public Par X0Y0_手先_節10_吸盤_吸盤1;

		public Par X0Y0_手先_節10_吸盤_吸盤2;

		public Par X0Y0_手先_節10_吸盤_吸盤3;

		public Par X0Y0_手先_節10_吸盤_吸盤4;

		public Par X0Y0_手先_節10_爪_爪2;

		public Par X0Y0_手先_節10_爪_爪1;

		public ColorD 腕部_節1_節CD;

		public ColorD 腕部_節1_紋柄_紋柄1CD;

		public ColorD 腕部_節1_紋柄_紋柄2CD;

		public ColorD 腕部_節2_節CD;

		public ColorD 腕部_節2_紋柄_紋柄1CD;

		public ColorD 腕部_節2_紋柄_紋柄2CD;

		public ColorD 腕部_節3_節CD;

		public ColorD 腕部_節3_紋柄_紋柄1CD;

		public ColorD 腕部_節3_紋柄_紋柄2CD;

		public ColorD 腕部_節4_節CD;

		public ColorD 腕部_節4_紋柄_紋柄1CD;

		public ColorD 腕部_節4_紋柄_紋柄2CD;

		public ColorD 腕部_節5_節CD;

		public ColorD 腕部_節5_紋柄_紋柄1CD;

		public ColorD 腕部_節5_紋柄_紋柄2CD;

		public ColorD 腕部_節6_節CD;

		public ColorD 腕部_節6_紋柄_紋柄1CD;

		public ColorD 腕部_節6_紋柄_紋柄2CD;

		public ColorD 腕部_節7_節CD;

		public ColorD 腕部_節7_紋柄_紋柄1CD;

		public ColorD 腕部_節7_紋柄_紋柄2CD;

		public ColorD 腕部_節8_節CD;

		public ColorD 腕部_節8_紋柄_紋柄1CD;

		public ColorD 腕部_節8_紋柄_紋柄2CD;

		public ColorD 腕部_節9_節CD;

		public ColorD 腕部_節9_紋柄_紋柄1CD;

		public ColorD 腕部_節9_紋柄_紋柄2CD;

		public ColorD 腕部_節10_節CD;

		public ColorD 腕部_節10_紋柄_紋柄1CD;

		public ColorD 腕部_節10_紋柄_紋柄2CD;

		public ColorD 腕部_節11_節CD;

		public ColorD 腕部_節11_紋柄_紋柄1CD;

		public ColorD 腕部_節11_紋柄_紋柄2CD;

		public ColorD 腕部_節12_節CD;

		public ColorD 腕部_節12_紋柄_紋柄1CD;

		public ColorD 腕部_節12_紋柄_紋柄2CD;

		public ColorD 腕部_節13_節CD;

		public ColorD 腕部_節13_紋柄_紋柄1CD;

		public ColorD 腕部_節13_紋柄_紋柄2CD;

		public ColorD 腕部_節14_節CD;

		public ColorD 腕部_節14_紋柄_紋柄1CD;

		public ColorD 腕部_節14_紋柄_紋柄2CD;

		public ColorD 腕部_節15_節CD;

		public ColorD 腕部_節15_紋柄_紋柄1CD;

		public ColorD 腕部_節15_紋柄_紋柄2CD;

		public ColorD 腕部_節16_節CD;

		public ColorD 腕部_節16_紋柄_紋柄1CD;

		public ColorD 腕部_節16_紋柄_紋柄2CD;

		public ColorD 腕部_節17_節CD;

		public ColorD 腕部_節17_紋柄_紋柄1CD;

		public ColorD 腕部_節17_紋柄_紋柄2CD;

		public ColorD 腕部_節18_節CD;

		public ColorD 腕部_節18_紋柄_紋柄1CD;

		public ColorD 腕部_節18_紋柄_紋柄2CD;

		public ColorD 腕部_節19_節CD;

		public ColorD 腕部_節19_紋柄_紋柄1CD;

		public ColorD 腕部_節19_紋柄_紋柄2CD;

		public ColorD 腕部_節20_節CD;

		public ColorD 腕部_節20_紋柄_紋柄1CD;

		public ColorD 腕部_節20_紋柄_紋柄2CD;

		public ColorD 腕部_節21_節CD;

		public ColorD 腕部_節21_紋柄_紋柄1CD;

		public ColorD 腕部_節21_紋柄_紋柄2CD;

		public ColorD 腕部_節22_節CD;

		public ColorD 腕部_節22_紋柄_紋柄1CD;

		public ColorD 腕部_節22_紋柄_紋柄2CD;

		public ColorD 腕部_節23_節CD;

		public ColorD 腕部_節23_紋柄_紋柄1CD;

		public ColorD 腕部_節23_紋柄_紋柄2CD;

		public ColorD 腕部_節24_節CD;

		public ColorD 腕部_節24_紋柄_紋柄1CD;

		public ColorD 腕部_節24_紋柄_紋柄2CD;

		public ColorD 腕部_節25_節CD;

		public ColorD 腕部_節25_紋柄_紋柄1CD;

		public ColorD 腕部_節25_紋柄_紋柄2CD;

		public ColorD 手先_節1_節CD;

		public ColorD 手先_節1_紋柄1CD;

		public ColorD 手先_節1_紋柄2CD;

		public ColorD 手先_節1_吸盤_吸盤1CD;

		public ColorD 手先_節1_吸盤_吸盤2CD;

		public ColorD 手先_節1_吸盤_吸盤3CD;

		public ColorD 手先_節1_吸盤_吸盤4CD;

		public ColorD 手先_節1_爪_爪2CD;

		public ColorD 手先_節1_爪_爪1CD;

		public ColorD 手先_節2_節CD;

		public ColorD 手先_節2_紋柄1CD;

		public ColorD 手先_節2_紋柄2CD;

		public ColorD 手先_節2_吸盤_吸盤1CD;

		public ColorD 手先_節2_吸盤_吸盤2CD;

		public ColorD 手先_節2_吸盤_吸盤3CD;

		public ColorD 手先_節2_吸盤_吸盤4CD;

		public ColorD 手先_節2_爪_爪2CD;

		public ColorD 手先_節2_爪_爪1CD;

		public ColorD 手先_節3_節CD;

		public ColorD 手先_節3_紋柄1CD;

		public ColorD 手先_節3_紋柄2CD;

		public ColorD 手先_節3_吸盤_吸盤1CD;

		public ColorD 手先_節3_吸盤_吸盤2CD;

		public ColorD 手先_節3_吸盤_吸盤3CD;

		public ColorD 手先_節3_吸盤_吸盤4CD;

		public ColorD 手先_節3_爪_爪2CD;

		public ColorD 手先_節3_爪_爪1CD;

		public ColorD 手先_節4_節CD;

		public ColorD 手先_節4_紋柄1CD;

		public ColorD 手先_節4_紋柄2CD;

		public ColorD 手先_節4_吸盤_吸盤1CD;

		public ColorD 手先_節4_吸盤_吸盤2CD;

		public ColorD 手先_節4_吸盤_吸盤3CD;

		public ColorD 手先_節4_吸盤_吸盤4CD;

		public ColorD 手先_節4_爪_爪2CD;

		public ColorD 手先_節4_爪_爪1CD;

		public ColorD 手先_節5_節CD;

		public ColorD 手先_節5_紋柄1CD;

		public ColorD 手先_節5_紋柄2CD;

		public ColorD 手先_節5_吸盤_吸盤1CD;

		public ColorD 手先_節5_吸盤_吸盤2CD;

		public ColorD 手先_節5_吸盤_吸盤3CD;

		public ColorD 手先_節5_吸盤_吸盤4CD;

		public ColorD 手先_節5_爪_爪2CD;

		public ColorD 手先_節5_爪_爪1CD;

		public ColorD 手先_節6_節CD;

		public ColorD 手先_節6_紋柄1CD;

		public ColorD 手先_節6_紋柄2CD;

		public ColorD 手先_節6_吸盤_吸盤1CD;

		public ColorD 手先_節6_吸盤_吸盤2CD;

		public ColorD 手先_節6_吸盤_吸盤3CD;

		public ColorD 手先_節6_吸盤_吸盤4CD;

		public ColorD 手先_節6_爪_爪2CD;

		public ColorD 手先_節6_爪_爪1CD;

		public ColorD 手先_節7_節CD;

		public ColorD 手先_節7_紋柄CD;

		public ColorD 手先_節7_吸盤_吸盤1CD;

		public ColorD 手先_節7_吸盤_吸盤2CD;

		public ColorD 手先_節7_吸盤_吸盤3CD;

		public ColorD 手先_節7_吸盤_吸盤4CD;

		public ColorD 手先_節7_爪_爪2CD;

		public ColorD 手先_節7_爪_爪1CD;

		public ColorD 手先_節8_節CD;

		public ColorD 手先_節8_紋柄CD;

		public ColorD 手先_節8_吸盤_吸盤1CD;

		public ColorD 手先_節8_吸盤_吸盤2CD;

		public ColorD 手先_節8_吸盤_吸盤3CD;

		public ColorD 手先_節8_吸盤_吸盤4CD;

		public ColorD 手先_節8_爪_爪2CD;

		public ColorD 手先_節8_爪_爪1CD;

		public ColorD 手先_節9_節CD;

		public ColorD 手先_節9_紋柄CD;

		public ColorD 手先_節9_吸盤_吸盤1CD;

		public ColorD 手先_節9_吸盤_吸盤2CD;

		public ColorD 手先_節9_吸盤_吸盤3CD;

		public ColorD 手先_節9_吸盤_吸盤4CD;

		public ColorD 手先_節9_爪_爪2CD;

		public ColorD 手先_節9_爪_爪1CD;

		public ColorD 手先_節10_節CD;

		public ColorD 手先_節10_紋柄CD;

		public ColorD 手先_節10_吸盤_吸盤1CD;

		public ColorD 手先_節10_吸盤_吸盤2CD;

		public ColorD 手先_節10_吸盤_吸盤3CD;

		public ColorD 手先_節10_吸盤_吸盤4CD;

		public ColorD 手先_節10_爪_爪2CD;

		public ColorD 手先_節10_爪_爪1CD;

		public ColorD 腕部_輪1_革CD;

		public ColorD 腕部_輪1_金具1CD;

		public ColorD 腕部_輪1_金具2CD;

		public ColorD 腕部_輪1_金具3CD;

		public ColorD 腕部_輪1_金具左CD;

		public ColorD 腕部_輪1_金具右CD;

		public ColorD 手先_輪2_革CD;

		public ColorD 手先_輪2_金具1CD;

		public ColorD 手先_輪2_金具2CD;

		public ColorD 手先_輪2_金具3CD;

		public ColorD 手先_輪2_金具左CD;

		public ColorD 手先_輪2_金具右CD;

		public ColorP X0Y0_腕部_節1_節CP;

		public ColorP X0Y0_腕部_節1_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節1_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_節2_節CP;

		public ColorP X0Y0_腕部_節2_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節2_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_節3_節CP;

		public ColorP X0Y0_腕部_節3_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節3_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_節4_節CP;

		public ColorP X0Y0_腕部_節4_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節4_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_節5_節CP;

		public ColorP X0Y0_腕部_節5_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節5_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_節6_節CP;

		public ColorP X0Y0_腕部_節6_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節6_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_節7_節CP;

		public ColorP X0Y0_腕部_節7_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節7_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_節8_節CP;

		public ColorP X0Y0_腕部_節8_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節8_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_節9_節CP;

		public ColorP X0Y0_腕部_節9_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節9_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_節10_節CP;

		public ColorP X0Y0_腕部_節10_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節10_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_節11_節CP;

		public ColorP X0Y0_腕部_節11_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節11_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_節12_節CP;

		public ColorP X0Y0_腕部_節12_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節12_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_節13_節CP;

		public ColorP X0Y0_腕部_節13_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節13_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_節14_節CP;

		public ColorP X0Y0_腕部_節14_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節14_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_節15_節CP;

		public ColorP X0Y0_腕部_節15_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節15_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_輪1_革CP;

		public ColorP X0Y0_腕部_輪1_金具1CP;

		public ColorP X0Y0_腕部_輪1_金具2CP;

		public ColorP X0Y0_腕部_輪1_金具3CP;

		public ColorP X0Y0_腕部_輪1_金具左CP;

		public ColorP X0Y0_腕部_輪1_金具右CP;

		public ColorP X0Y0_腕部_節16_節CP;

		public ColorP X0Y0_腕部_節16_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節16_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_節17_節CP;

		public ColorP X0Y0_腕部_節17_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節17_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_節18_節CP;

		public ColorP X0Y0_腕部_節18_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節18_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_節19_節CP;

		public ColorP X0Y0_腕部_節19_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節19_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_節20_節CP;

		public ColorP X0Y0_腕部_節20_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節20_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_節21_節CP;

		public ColorP X0Y0_腕部_節21_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節21_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_節22_節CP;

		public ColorP X0Y0_腕部_節22_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節22_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_節23_節CP;

		public ColorP X0Y0_腕部_節23_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節23_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_節24_節CP;

		public ColorP X0Y0_腕部_節24_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節24_紋柄_紋柄2CP;

		public ColorP X0Y0_腕部_節25_節CP;

		public ColorP X0Y0_腕部_節25_紋柄_紋柄1CP;

		public ColorP X0Y0_腕部_節25_紋柄_紋柄2CP;

		public ColorP X0Y0_手先_節1_節CP;

		public ColorP X0Y0_手先_節1_紋柄1CP;

		public ColorP X0Y0_手先_節1_紋柄2CP;

		public ColorP X0Y0_手先_節1_吸盤_吸盤1CP;

		public ColorP X0Y0_手先_節1_吸盤_吸盤2CP;

		public ColorP X0Y0_手先_節1_吸盤_吸盤3CP;

		public ColorP X0Y0_手先_節1_吸盤_吸盤4CP;

		public ColorP X0Y0_手先_節1_爪_爪2CP;

		public ColorP X0Y0_手先_節1_爪_爪1CP;

		public ColorP X0Y0_手先_輪2_革CP;

		public ColorP X0Y0_手先_輪2_金具1CP;

		public ColorP X0Y0_手先_輪2_金具2CP;

		public ColorP X0Y0_手先_輪2_金具3CP;

		public ColorP X0Y0_手先_輪2_金具左CP;

		public ColorP X0Y0_手先_輪2_金具右CP;

		public ColorP X0Y0_手先_節2_節CP;

		public ColorP X0Y0_手先_節2_紋柄1CP;

		public ColorP X0Y0_手先_節2_紋柄2CP;

		public ColorP X0Y0_手先_節2_吸盤_吸盤1CP;

		public ColorP X0Y0_手先_節2_吸盤_吸盤2CP;

		public ColorP X0Y0_手先_節2_吸盤_吸盤3CP;

		public ColorP X0Y0_手先_節2_吸盤_吸盤4CP;

		public ColorP X0Y0_手先_節2_爪_爪2CP;

		public ColorP X0Y0_手先_節2_爪_爪1CP;

		public ColorP X0Y0_手先_節3_節CP;

		public ColorP X0Y0_手先_節3_紋柄1CP;

		public ColorP X0Y0_手先_節3_紋柄2CP;

		public ColorP X0Y0_手先_節3_吸盤_吸盤1CP;

		public ColorP X0Y0_手先_節3_吸盤_吸盤2CP;

		public ColorP X0Y0_手先_節3_吸盤_吸盤3CP;

		public ColorP X0Y0_手先_節3_吸盤_吸盤4CP;

		public ColorP X0Y0_手先_節3_爪_爪2CP;

		public ColorP X0Y0_手先_節3_爪_爪1CP;

		public ColorP X0Y0_手先_節4_節CP;

		public ColorP X0Y0_手先_節4_紋柄1CP;

		public ColorP X0Y0_手先_節4_紋柄2CP;

		public ColorP X0Y0_手先_節4_吸盤_吸盤1CP;

		public ColorP X0Y0_手先_節4_吸盤_吸盤2CP;

		public ColorP X0Y0_手先_節4_吸盤_吸盤3CP;

		public ColorP X0Y0_手先_節4_吸盤_吸盤4CP;

		public ColorP X0Y0_手先_節4_爪_爪2CP;

		public ColorP X0Y0_手先_節4_爪_爪1CP;

		public ColorP X0Y0_手先_節5_節CP;

		public ColorP X0Y0_手先_節5_紋柄1CP;

		public ColorP X0Y0_手先_節5_紋柄2CP;

		public ColorP X0Y0_手先_節5_吸盤_吸盤1CP;

		public ColorP X0Y0_手先_節5_吸盤_吸盤2CP;

		public ColorP X0Y0_手先_節5_吸盤_吸盤3CP;

		public ColorP X0Y0_手先_節5_吸盤_吸盤4CP;

		public ColorP X0Y0_手先_節5_爪_爪2CP;

		public ColorP X0Y0_手先_節5_爪_爪1CP;

		public ColorP X0Y0_手先_節6_節CP;

		public ColorP X0Y0_手先_節6_紋柄1CP;

		public ColorP X0Y0_手先_節6_紋柄2CP;

		public ColorP X0Y0_手先_節6_吸盤_吸盤1CP;

		public ColorP X0Y0_手先_節6_吸盤_吸盤2CP;

		public ColorP X0Y0_手先_節6_吸盤_吸盤3CP;

		public ColorP X0Y0_手先_節6_吸盤_吸盤4CP;

		public ColorP X0Y0_手先_節6_爪_爪2CP;

		public ColorP X0Y0_手先_節6_爪_爪1CP;

		public ColorP X0Y0_手先_節7_節CP;

		public ColorP X0Y0_手先_節7_紋柄CP;

		public ColorP X0Y0_手先_節7_吸盤_吸盤1CP;

		public ColorP X0Y0_手先_節7_吸盤_吸盤2CP;

		public ColorP X0Y0_手先_節7_吸盤_吸盤3CP;

		public ColorP X0Y0_手先_節7_吸盤_吸盤4CP;

		public ColorP X0Y0_手先_節7_爪_爪2CP;

		public ColorP X0Y0_手先_節7_爪_爪1CP;

		public ColorP X0Y0_手先_節8_節CP;

		public ColorP X0Y0_手先_節8_紋柄CP;

		public ColorP X0Y0_手先_節8_吸盤_吸盤1CP;

		public ColorP X0Y0_手先_節8_吸盤_吸盤2CP;

		public ColorP X0Y0_手先_節8_吸盤_吸盤3CP;

		public ColorP X0Y0_手先_節8_吸盤_吸盤4CP;

		public ColorP X0Y0_手先_節8_爪_爪2CP;

		public ColorP X0Y0_手先_節8_爪_爪1CP;

		public ColorP X0Y0_手先_節9_節CP;

		public ColorP X0Y0_手先_節9_紋柄CP;

		public ColorP X0Y0_手先_節9_吸盤_吸盤1CP;

		public ColorP X0Y0_手先_節9_吸盤_吸盤2CP;

		public ColorP X0Y0_手先_節9_吸盤_吸盤3CP;

		public ColorP X0Y0_手先_節9_吸盤_吸盤4CP;

		public ColorP X0Y0_手先_節9_爪_爪2CP;

		public ColorP X0Y0_手先_節9_爪_爪1CP;

		public ColorP X0Y0_手先_節10_節CP;

		public ColorP X0Y0_手先_節10_紋柄CP;

		public ColorP X0Y0_手先_節10_吸盤_吸盤1CP;

		public ColorP X0Y0_手先_節10_吸盤_吸盤2CP;

		public ColorP X0Y0_手先_節10_吸盤_吸盤3CP;

		public ColorP X0Y0_手先_節10_吸盤_吸盤4CP;

		public ColorP X0Y0_手先_節10_爪_爪2CP;

		public ColorP X0Y0_手先_節10_爪_爪1CP;

		public 拘束鎖 鎖1;

		public 拘束鎖 鎖2;

		public 拘束鎖 鎖3;

		public 拘束鎖 鎖4;

		public Par[] Pars;

		private Vector2D[] mm;
	}
}
