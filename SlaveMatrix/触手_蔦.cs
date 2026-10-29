using System;
using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 触手_蔦 : 触手
	{
		public 触手_蔦(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 触手_蔦D e)
		{
			触手_蔦.<>c__DisplayClass430_0 CS$<>8__locals1 = new 触手_蔦.<>c__DisplayClass430_0();
			CS$<>8__locals1.DisUnit = DisUnit;
			CS$<>8__locals1.Med = Med;
			CS$<>8__locals1.体配色 = 体配色;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.ThisType = base.GetType();
			Dif dif = new Dif();
			dif.Tag = "蔦";
			dif.Add(new Pars(Sta.肢左["触手"][0][3]));
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0];
			Pars pars2 = pars["節1"].ToPars();
			this.X0Y0_節1_節 = pars2["節"].ToPar();
			this.X0Y0_節1_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節1_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節1_脈 = pars2["脈"].ToPar();
			pars2 = pars["節2"].ToPars();
			this.X0Y0_節2_節 = pars2["節"].ToPar();
			this.X0Y0_節2_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節2_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節2_脈 = pars2["脈"].ToPar();
			pars2 = pars["節3"].ToPars();
			this.X0Y0_節3_節 = pars2["節"].ToPar();
			this.X0Y0_節3_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節3_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節3_脈 = pars2["脈"].ToPar();
			pars2 = pars["節4"].ToPars();
			this.X0Y0_節4_節 = pars2["節"].ToPar();
			this.X0Y0_節4_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節4_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節4_脈 = pars2["脈"].ToPar();
			pars2 = pars["節5"].ToPars();
			this.X0Y0_節5_節 = pars2["節"].ToPar();
			this.X0Y0_節5_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節5_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節5_脈 = pars2["脈"].ToPar();
			pars2 = pars["節6"].ToPars();
			this.X0Y0_節6_節 = pars2["節"].ToPar();
			this.X0Y0_節6_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節6_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節6_脈 = pars2["脈"].ToPar();
			pars2 = pars["節7"].ToPars();
			this.X0Y0_節7_節 = pars2["節"].ToPar();
			this.X0Y0_節7_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節7_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節7_脈 = pars2["脈"].ToPar();
			pars2 = pars["節8"].ToPars();
			this.X0Y0_節8_節 = pars2["節"].ToPar();
			this.X0Y0_節8_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節8_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節8_脈 = pars2["脈"].ToPar();
			pars2 = pars["節9"].ToPars();
			this.X0Y0_節9_節 = pars2["節"].ToPar();
			this.X0Y0_節9_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節9_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節9_脈 = pars2["脈"].ToPar();
			pars2 = pars["節10"].ToPars();
			this.X0Y0_節10_節 = pars2["節"].ToPar();
			this.X0Y0_節10_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節10_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節10_脈 = pars2["脈"].ToPar();
			pars2 = pars["節11"].ToPars();
			this.X0Y0_節11_節 = pars2["節"].ToPar();
			this.X0Y0_節11_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節11_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節11_脈 = pars2["脈"].ToPar();
			pars2 = pars["節12"].ToPars();
			this.X0Y0_節12_節 = pars2["節"].ToPar();
			this.X0Y0_節12_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節12_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節12_脈 = pars2["脈"].ToPar();
			pars2 = pars["節13"].ToPars();
			this.X0Y0_節13_節 = pars2["節"].ToPar();
			this.X0Y0_節13_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節13_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節13_脈 = pars2["脈"].ToPar();
			pars2 = pars["輪1"].ToPars();
			this.X0Y0_輪1_革 = pars2["革"].ToPar();
			this.X0Y0_輪1_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_輪1_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_輪1_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_輪1_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_輪1_金具右 = pars2["金具右"].ToPar();
			pars2 = pars["節14"].ToPars();
			this.X0Y0_節14_節 = pars2["節"].ToPar();
			this.X0Y0_節14_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節14_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節14_脈 = pars2["脈"].ToPar();
			pars2 = pars["節15"].ToPars();
			this.X0Y0_節15_節 = pars2["節"].ToPar();
			this.X0Y0_節15_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節15_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節15_脈 = pars2["脈"].ToPar();
			pars2 = pars["節16"].ToPars();
			this.X0Y0_節16_節 = pars2["節"].ToPar();
			this.X0Y0_節16_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節16_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節16_脈 = pars2["脈"].ToPar();
			pars2 = pars["節17"].ToPars();
			this.X0Y0_節17_節 = pars2["節"].ToPar();
			this.X0Y0_節17_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節17_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節17_脈 = pars2["脈"].ToPar();
			pars2 = pars["節18"].ToPars();
			this.X0Y0_節18_節 = pars2["節"].ToPar();
			this.X0Y0_節18_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節18_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節18_脈 = pars2["脈"].ToPar();
			pars2 = pars["節19"].ToPars();
			this.X0Y0_節19_節 = pars2["節"].ToPar();
			this.X0Y0_節19_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節19_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節19_脈 = pars2["脈"].ToPar();
			pars2 = pars["節20"].ToPars();
			this.X0Y0_節20_節 = pars2["節"].ToPar();
			this.X0Y0_節20_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節20_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節20_脈 = pars2["脈"].ToPar();
			pars2 = pars["節21"].ToPars();
			this.X0Y0_節21_節 = pars2["節"].ToPar();
			this.X0Y0_節21_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節21_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節21_脈 = pars2["脈"].ToPar();
			pars2 = pars["節22"].ToPars();
			this.X0Y0_節22_節 = pars2["節"].ToPar();
			this.X0Y0_節22_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節22_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節22_脈 = pars2["脈"].ToPar();
			pars2 = pars["節23"].ToPars();
			this.X0Y0_節23_節 = pars2["節"].ToPar();
			this.X0Y0_節23_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節23_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節23_脈 = pars2["脈"].ToPar();
			pars2 = pars["節24"].ToPars();
			this.X0Y0_節24_節 = pars2["節"].ToPar();
			this.X0Y0_節24_棘1 = pars2["棘1"].ToPar();
			this.X0Y0_節24_棘2 = pars2["棘2"].ToPar();
			this.X0Y0_節24_脈 = pars2["脈"].ToPar();
			pars2 = pars["輪2"].ToPars();
			this.X0Y0_輪2_革 = pars2["革"].ToPar();
			this.X0Y0_輪2_金具1 = pars2["金具1"].ToPar();
			this.X0Y0_輪2_金具2 = pars2["金具2"].ToPar();
			this.X0Y0_輪2_金具3 = pars2["金具3"].ToPar();
			this.X0Y0_輪2_金具左 = pars2["金具左"].ToPar();
			this.X0Y0_輪2_金具右 = pars2["金具右"].ToPar();
			pars2 = pars["先端"].ToPars();
			Pars pars3 = pars2["下顎"].ToPars();
			this.X0Y0_先端_下顎_顎 = pars3["顎"].ToPar();
			this.X0Y0_先端_下顎_口内 = pars3["口内"].ToPar();
			this.X0Y0_先端_下顎_棘12 = pars3["棘12"].ToPar();
			this.X0Y0_先端_下顎_棘11 = pars3["棘11"].ToPar();
			this.X0Y0_先端_下顎_棘10 = pars3["棘10"].ToPar();
			this.X0Y0_先端_下顎_棘9 = pars3["棘9"].ToPar();
			this.X0Y0_先端_下顎_棘8 = pars3["棘8"].ToPar();
			this.X0Y0_先端_下顎_棘7 = pars3["棘7"].ToPar();
			this.X0Y0_先端_下顎_脈1 = pars3["脈1"].ToPar();
			this.X0Y0_先端_下顎_脈2 = pars3["脈2"].ToPar();
			this.X0Y0_先端_下顎_脈3 = pars3["脈3"].ToPar();
			this.X0Y0_先端_下顎_棘6 = pars3["棘6"].ToPar();
			this.X0Y0_先端_下顎_棘5 = pars3["棘5"].ToPar();
			this.X0Y0_先端_下顎_棘4 = pars3["棘4"].ToPar();
			this.X0Y0_先端_下顎_棘3 = pars3["棘3"].ToPar();
			this.X0Y0_先端_下顎_棘2 = pars3["棘2"].ToPar();
			this.X0Y0_先端_下顎_棘1 = pars3["棘1"].ToPar();
			pars3 = pars2["上顎"].ToPars();
			this.X0Y0_先端_上顎_棘12 = pars3["棘12"].ToPar();
			this.X0Y0_先端_上顎_棘11 = pars3["棘11"].ToPar();
			this.X0Y0_先端_上顎_棘10 = pars3["棘10"].ToPar();
			this.X0Y0_先端_上顎_棘9 = pars3["棘9"].ToPar();
			this.X0Y0_先端_上顎_棘8 = pars3["棘8"].ToPar();
			this.X0Y0_先端_上顎_棘7 = pars3["棘7"].ToPar();
			this.X0Y0_先端_上顎_顎 = pars3["顎"].ToPar();
			this.X0Y0_先端_上顎_脈1 = pars3["脈1"].ToPar();
			this.X0Y0_先端_上顎_脈2 = pars3["脈2"].ToPar();
			this.X0Y0_先端_上顎_脈3 = pars3["脈3"].ToPar();
			this.X0Y0_先端_上顎_脈4 = pars3["脈4"].ToPar();
			pars3 = pars2["輪"].ToPars();
			this.X0Y0_先端_輪_革 = pars3["革"].ToPar();
			this.X0Y0_先端_輪_金具1 = pars3["金具1"].ToPar();
			this.X0Y0_先端_輪_金具2 = pars3["金具2"].ToPar();
			this.X0Y0_先端_輪_金具3 = pars3["金具3"].ToPar();
			this.X0Y0_先端_輪_金具左 = pars3["金具左"].ToPar();
			this.X0Y0_先端_輪_金具右 = pars3["金具右"].ToPar();
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
			this.節1_節_表示 = e.節1_節_表示;
			this.節1_棘1_表示 = e.節1_棘1_表示;
			this.節1_棘2_表示 = e.節1_棘2_表示;
			this.節1_脈_表示 = e.節1_脈_表示;
			this.節2_節_表示 = e.節2_節_表示;
			this.節2_棘1_表示 = e.節2_棘1_表示;
			this.節2_棘2_表示 = e.節2_棘2_表示;
			this.節2_脈_表示 = e.節2_脈_表示;
			this.節3_節_表示 = e.節3_節_表示;
			this.節3_棘1_表示 = e.節3_棘1_表示;
			this.節3_棘2_表示 = e.節3_棘2_表示;
			this.節3_脈_表示 = e.節3_脈_表示;
			this.節4_節_表示 = e.節4_節_表示;
			this.節4_棘1_表示 = e.節4_棘1_表示;
			this.節4_棘2_表示 = e.節4_棘2_表示;
			this.節4_脈_表示 = e.節4_脈_表示;
			this.節5_節_表示 = e.節5_節_表示;
			this.節5_棘1_表示 = e.節5_棘1_表示;
			this.節5_棘2_表示 = e.節5_棘2_表示;
			this.節5_脈_表示 = e.節5_脈_表示;
			this.節6_節_表示 = e.節6_節_表示;
			this.節6_棘1_表示 = e.節6_棘1_表示;
			this.節6_棘2_表示 = e.節6_棘2_表示;
			this.節6_脈_表示 = e.節6_脈_表示;
			this.節7_節_表示 = e.節7_節_表示;
			this.節7_棘1_表示 = e.節7_棘1_表示;
			this.節7_棘2_表示 = e.節7_棘2_表示;
			this.節7_脈_表示 = e.節7_脈_表示;
			this.節8_節_表示 = e.節8_節_表示;
			this.節8_棘1_表示 = e.節8_棘1_表示;
			this.節8_棘2_表示 = e.節8_棘2_表示;
			this.節8_脈_表示 = e.節8_脈_表示;
			this.節9_節_表示 = e.節9_節_表示;
			this.節9_棘1_表示 = e.節9_棘1_表示;
			this.節9_棘2_表示 = e.節9_棘2_表示;
			this.節9_脈_表示 = e.節9_脈_表示;
			this.節10_節_表示 = e.節10_節_表示;
			this.節10_棘1_表示 = e.節10_棘1_表示;
			this.節10_棘2_表示 = e.節10_棘2_表示;
			this.節10_脈_表示 = e.節10_脈_表示;
			this.節11_節_表示 = e.節11_節_表示;
			this.節11_棘1_表示 = e.節11_棘1_表示;
			this.節11_棘2_表示 = e.節11_棘2_表示;
			this.節11_脈_表示 = e.節11_脈_表示;
			this.節12_節_表示 = e.節12_節_表示;
			this.節12_棘1_表示 = e.節12_棘1_表示;
			this.節12_棘2_表示 = e.節12_棘2_表示;
			this.節12_脈_表示 = e.節12_脈_表示;
			this.節13_節_表示 = e.節13_節_表示;
			this.節13_棘1_表示 = e.節13_棘1_表示;
			this.節13_棘2_表示 = e.節13_棘2_表示;
			this.節13_脈_表示 = e.節13_脈_表示;
			this.輪1_革_表示 = e.輪1_革_表示;
			this.輪1_金具1_表示 = e.輪1_金具1_表示;
			this.輪1_金具2_表示 = e.輪1_金具2_表示;
			this.輪1_金具3_表示 = e.輪1_金具3_表示;
			this.輪1_金具左_表示 = e.輪1_金具左_表示;
			this.輪1_金具右_表示 = e.輪1_金具右_表示;
			this.節14_節_表示 = e.節14_節_表示;
			this.節14_棘1_表示 = e.節14_棘1_表示;
			this.節14_棘2_表示 = e.節14_棘2_表示;
			this.節14_脈_表示 = e.節14_脈_表示;
			this.節15_節_表示 = e.節15_節_表示;
			this.節15_棘1_表示 = e.節15_棘1_表示;
			this.節15_棘2_表示 = e.節15_棘2_表示;
			this.節15_脈_表示 = e.節15_脈_表示;
			this.節16_節_表示 = e.節16_節_表示;
			this.節16_棘1_表示 = e.節16_棘1_表示;
			this.節16_棘2_表示 = e.節16_棘2_表示;
			this.節16_脈_表示 = e.節16_脈_表示;
			this.節17_節_表示 = e.節17_節_表示;
			this.節17_棘1_表示 = e.節17_棘1_表示;
			this.節17_棘2_表示 = e.節17_棘2_表示;
			this.節17_脈_表示 = e.節17_脈_表示;
			this.節18_節_表示 = e.節18_節_表示;
			this.節18_棘1_表示 = e.節18_棘1_表示;
			this.節18_棘2_表示 = e.節18_棘2_表示;
			this.節18_脈_表示 = e.節18_脈_表示;
			this.節19_節_表示 = e.節19_節_表示;
			this.節19_棘1_表示 = e.節19_棘1_表示;
			this.節19_棘2_表示 = e.節19_棘2_表示;
			this.節19_脈_表示 = e.節19_脈_表示;
			this.節20_節_表示 = e.節20_節_表示;
			this.節20_棘1_表示 = e.節20_棘1_表示;
			this.節20_棘2_表示 = e.節20_棘2_表示;
			this.節20_脈_表示 = e.節20_脈_表示;
			this.節21_節_表示 = e.節21_節_表示;
			this.節21_棘1_表示 = e.節21_棘1_表示;
			this.節21_棘2_表示 = e.節21_棘2_表示;
			this.節21_脈_表示 = e.節21_脈_表示;
			this.節22_節_表示 = e.節22_節_表示;
			this.節22_棘1_表示 = e.節22_棘1_表示;
			this.節22_棘2_表示 = e.節22_棘2_表示;
			this.節22_脈_表示 = e.節22_脈_表示;
			this.節23_節_表示 = e.節23_節_表示;
			this.節23_棘1_表示 = e.節23_棘1_表示;
			this.節23_棘2_表示 = e.節23_棘2_表示;
			this.節23_脈_表示 = e.節23_脈_表示;
			this.節24_節_表示 = e.節24_節_表示;
			this.節24_棘1_表示 = e.節24_棘1_表示;
			this.節24_棘2_表示 = e.節24_棘2_表示;
			this.節24_脈_表示 = e.節24_脈_表示;
			this.輪2_革_表示 = e.輪2_革_表示;
			this.輪2_金具1_表示 = e.輪2_金具1_表示;
			this.輪2_金具2_表示 = e.輪2_金具2_表示;
			this.輪2_金具3_表示 = e.輪2_金具3_表示;
			this.輪2_金具左_表示 = e.輪2_金具左_表示;
			this.輪2_金具右_表示 = e.輪2_金具右_表示;
			this.先端_下顎_顎_表示 = e.先端_下顎_顎_表示;
			this.先端_下顎_口内_表示 = e.先端_下顎_口内_表示;
			this.先端_下顎_棘12_表示 = e.先端_下顎_棘12_表示;
			this.先端_下顎_棘11_表示 = e.先端_下顎_棘11_表示;
			this.先端_下顎_棘10_表示 = e.先端_下顎_棘10_表示;
			this.先端_下顎_棘9_表示 = e.先端_下顎_棘9_表示;
			this.先端_下顎_棘8_表示 = e.先端_下顎_棘8_表示;
			this.先端_下顎_棘7_表示 = e.先端_下顎_棘7_表示;
			this.先端_下顎_脈1_表示 = e.先端_下顎_脈1_表示;
			this.先端_下顎_脈2_表示 = e.先端_下顎_脈2_表示;
			this.先端_下顎_脈3_表示 = e.先端_下顎_脈3_表示;
			this.先端_下顎_棘6_表示 = e.先端_下顎_棘6_表示;
			this.先端_下顎_棘5_表示 = e.先端_下顎_棘5_表示;
			this.先端_下顎_棘4_表示 = e.先端_下顎_棘4_表示;
			this.先端_下顎_棘3_表示 = e.先端_下顎_棘3_表示;
			this.先端_下顎_棘2_表示 = e.先端_下顎_棘2_表示;
			this.先端_下顎_棘1_表示 = e.先端_下顎_棘1_表示;
			this.先端_上顎_棘12_表示 = e.先端_上顎_棘12_表示;
			this.先端_上顎_棘11_表示 = e.先端_上顎_棘11_表示;
			this.先端_上顎_棘10_表示 = e.先端_上顎_棘10_表示;
			this.先端_上顎_棘9_表示 = e.先端_上顎_棘9_表示;
			this.先端_上顎_棘8_表示 = e.先端_上顎_棘8_表示;
			this.先端_上顎_棘7_表示 = e.先端_上顎_棘7_表示;
			this.先端_上顎_顎_表示 = e.先端_上顎_顎_表示;
			this.先端_上顎_脈1_表示 = e.先端_上顎_脈1_表示;
			this.先端_上顎_脈2_表示 = e.先端_上顎_脈2_表示;
			this.先端_上顎_脈3_表示 = e.先端_上顎_脈3_表示;
			this.先端_上顎_脈4_表示 = e.先端_上顎_脈4_表示;
			this.先端_輪_革_表示 = e.先端_輪_革_表示;
			this.先端_輪_金具1_表示 = e.先端_輪_金具1_表示;
			this.先端_輪_金具2_表示 = e.先端_輪_金具2_表示;
			this.先端_輪_金具3_表示 = e.先端_輪_金具3_表示;
			this.先端_輪_金具左_表示 = e.先端_輪_金具左_表示;
			this.先端_輪_金具右_表示 = e.先端_輪_金具右_表示;
			this.先端表示 = e.先端表示;
			this.輪1表示 = e.輪1表示;
			this.輪2表示 = e.輪2表示;
			this.輪3表示 = e.輪3表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			if (e.節1_接続.Count > 0)
			{
				Ele f;
				this.節1_接続 = e.節1_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節1_接続;
					f.接続(CS$<>8__locals1.<>4__this.節1_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節2_接続.Count > 0)
			{
				Ele f;
				this.節2_接続 = e.節2_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節2_接続;
					f.接続(CS$<>8__locals1.<>4__this.節2_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節3_接続.Count > 0)
			{
				Ele f;
				this.節3_接続 = e.節3_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節3_接続;
					f.接続(CS$<>8__locals1.<>4__this.節3_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節4_接続.Count > 0)
			{
				Ele f;
				this.節4_接続 = e.節4_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節4_接続;
					f.接続(CS$<>8__locals1.<>4__this.節4_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節5_接続.Count > 0)
			{
				Ele f;
				this.節5_接続 = e.節5_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節5_接続;
					f.接続(CS$<>8__locals1.<>4__this.節5_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節6_接続.Count > 0)
			{
				Ele f;
				this.節6_接続 = e.節6_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節6_接続;
					f.接続(CS$<>8__locals1.<>4__this.節6_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節7_接続.Count > 0)
			{
				Ele f;
				this.節7_接続 = e.節7_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節7_接続;
					f.接続(CS$<>8__locals1.<>4__this.節7_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節8_接続.Count > 0)
			{
				Ele f;
				this.節8_接続 = e.節8_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節8_接続;
					f.接続(CS$<>8__locals1.<>4__this.節8_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節9_接続.Count > 0)
			{
				Ele f;
				this.節9_接続 = e.節9_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節9_接続;
					f.接続(CS$<>8__locals1.<>4__this.節9_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節10_接続.Count > 0)
			{
				Ele f;
				this.節10_接続 = e.節10_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節10_接続;
					f.接続(CS$<>8__locals1.<>4__this.節10_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節11_接続.Count > 0)
			{
				Ele f;
				this.節11_接続 = e.節11_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節11_接続;
					f.接続(CS$<>8__locals1.<>4__this.節11_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節12_接続.Count > 0)
			{
				Ele f;
				this.節12_接続 = e.節12_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節12_接続;
					f.接続(CS$<>8__locals1.<>4__this.節12_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節13_接続.Count > 0)
			{
				Ele f;
				this.節13_接続 = e.節13_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節13_接続;
					f.接続(CS$<>8__locals1.<>4__this.節13_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節14_接続.Count > 0)
			{
				Ele f;
				this.節14_接続 = e.節14_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節14_接続;
					f.接続(CS$<>8__locals1.<>4__this.節14_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節15_接続.Count > 0)
			{
				Ele f;
				this.節15_接続 = e.節15_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節15_接続;
					f.接続(CS$<>8__locals1.<>4__this.節15_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節16_接続.Count > 0)
			{
				Ele f;
				this.節16_接続 = e.節16_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節16_接続;
					f.接続(CS$<>8__locals1.<>4__this.節16_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節17_接続.Count > 0)
			{
				Ele f;
				this.節17_接続 = e.節17_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節17_接続;
					f.接続(CS$<>8__locals1.<>4__this.節17_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節18_接続.Count > 0)
			{
				Ele f;
				this.節18_接続 = e.節18_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節18_接続;
					f.接続(CS$<>8__locals1.<>4__this.節18_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節19_接続.Count > 0)
			{
				Ele f;
				this.節19_接続 = e.節19_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節19_接続;
					f.接続(CS$<>8__locals1.<>4__this.節19_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節20_接続.Count > 0)
			{
				Ele f;
				this.節20_接続 = e.節20_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節20_接続;
					f.接続(CS$<>8__locals1.<>4__this.節20_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節21_接続.Count > 0)
			{
				Ele f;
				this.節21_接続 = e.節21_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節21_接続;
					f.接続(CS$<>8__locals1.<>4__this.節21_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節22_接続.Count > 0)
			{
				Ele f;
				this.節22_接続 = e.節22_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節22_接続;
					f.接続(CS$<>8__locals1.<>4__this.節22_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節23_接続.Count > 0)
			{
				Ele f;
				this.節23_接続 = e.節23_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節23_接続;
					f.接続(CS$<>8__locals1.<>4__this.節23_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.節24_接続.Count > 0)
			{
				Ele f;
				this.節24_接続 = e.節24_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_節24_接続;
					f.接続(CS$<>8__locals1.<>4__this.節24_接続点);
					return f;
				}).ToArray<Ele>();
			}
			if (e.先端_接続.Count > 0)
			{
				Ele f;
				this.先端_接続 = e.先端_接続.Select(delegate(EleD g)
				{
					f = g.GetEle(CS$<>8__locals1.DisUnit, CS$<>8__locals1.Med, CS$<>8__locals1.体配色);
					f.Par = CS$<>8__locals1.<>4__this;
					f.接続情報 = 接続情報.触手_蔦_先端_接続;
					f.接続(CS$<>8__locals1.<>4__this.先端_接続点);
					return f;
				}).ToArray<Ele>();
			}
			this.配色指定 = 配色指定;
			this.配色(CS$<>8__locals1.体配色);
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
				this.X0Y0_先端_下顎_顎,
				this.X0Y0_先端_上顎_顎
			};
			this.X0Y0_節1_節CP = new ColorP(this.X0Y0_節1_節, this.節1_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節1_棘1CP = new ColorP(this.X0Y0_節1_棘1, this.節1_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節1_棘2CP = new ColorP(this.X0Y0_節1_棘2, this.節1_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節1_脈CP = new ColorP(this.X0Y0_節1_脈, this.節1_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節2_節CP = new ColorP(this.X0Y0_節2_節, this.節2_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節2_棘1CP = new ColorP(this.X0Y0_節2_棘1, this.節2_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節2_棘2CP = new ColorP(this.X0Y0_節2_棘2, this.節2_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節2_脈CP = new ColorP(this.X0Y0_節2_脈, this.節2_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節3_節CP = new ColorP(this.X0Y0_節3_節, this.節3_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節3_棘1CP = new ColorP(this.X0Y0_節3_棘1, this.節3_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節3_棘2CP = new ColorP(this.X0Y0_節3_棘2, this.節3_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節3_脈CP = new ColorP(this.X0Y0_節3_脈, this.節3_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節4_節CP = new ColorP(this.X0Y0_節4_節, this.節4_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節4_棘1CP = new ColorP(this.X0Y0_節4_棘1, this.節4_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節4_棘2CP = new ColorP(this.X0Y0_節4_棘2, this.節4_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節4_脈CP = new ColorP(this.X0Y0_節4_脈, this.節4_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節5_節CP = new ColorP(this.X0Y0_節5_節, this.節5_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節5_棘1CP = new ColorP(this.X0Y0_節5_棘1, this.節5_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節5_棘2CP = new ColorP(this.X0Y0_節5_棘2, this.節5_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節5_脈CP = new ColorP(this.X0Y0_節5_脈, this.節5_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節6_節CP = new ColorP(this.X0Y0_節6_節, this.節6_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節6_棘1CP = new ColorP(this.X0Y0_節6_棘1, this.節6_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節6_棘2CP = new ColorP(this.X0Y0_節6_棘2, this.節6_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節6_脈CP = new ColorP(this.X0Y0_節6_脈, this.節6_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節7_節CP = new ColorP(this.X0Y0_節7_節, this.節7_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節7_棘1CP = new ColorP(this.X0Y0_節7_棘1, this.節7_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節7_棘2CP = new ColorP(this.X0Y0_節7_棘2, this.節7_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節7_脈CP = new ColorP(this.X0Y0_節7_脈, this.節7_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節8_節CP = new ColorP(this.X0Y0_節8_節, this.節8_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節8_棘1CP = new ColorP(this.X0Y0_節8_棘1, this.節8_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節8_棘2CP = new ColorP(this.X0Y0_節8_棘2, this.節8_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節8_脈CP = new ColorP(this.X0Y0_節8_脈, this.節8_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節9_節CP = new ColorP(this.X0Y0_節9_節, this.節9_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節9_棘1CP = new ColorP(this.X0Y0_節9_棘1, this.節9_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節9_棘2CP = new ColorP(this.X0Y0_節9_棘2, this.節9_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節9_脈CP = new ColorP(this.X0Y0_節9_脈, this.節9_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節10_節CP = new ColorP(this.X0Y0_節10_節, this.節10_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節10_棘1CP = new ColorP(this.X0Y0_節10_棘1, this.節10_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節10_棘2CP = new ColorP(this.X0Y0_節10_棘2, this.節10_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節10_脈CP = new ColorP(this.X0Y0_節10_脈, this.節10_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節11_節CP = new ColorP(this.X0Y0_節11_節, this.節11_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節11_棘1CP = new ColorP(this.X0Y0_節11_棘1, this.節11_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節11_棘2CP = new ColorP(this.X0Y0_節11_棘2, this.節11_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節11_脈CP = new ColorP(this.X0Y0_節11_脈, this.節11_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節12_節CP = new ColorP(this.X0Y0_節12_節, this.節12_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節12_棘1CP = new ColorP(this.X0Y0_節12_棘1, this.節12_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節12_棘2CP = new ColorP(this.X0Y0_節12_棘2, this.節12_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節12_脈CP = new ColorP(this.X0Y0_節12_脈, this.節12_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節13_節CP = new ColorP(this.X0Y0_節13_節, this.節13_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節13_棘1CP = new ColorP(this.X0Y0_節13_棘1, this.節13_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節13_棘2CP = new ColorP(this.X0Y0_節13_棘2, this.節13_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節13_脈CP = new ColorP(this.X0Y0_節13_脈, this.節13_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪1_革CP = new ColorP(this.X0Y0_輪1_革, this.輪1_革CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪1_金具1CP = new ColorP(this.X0Y0_輪1_金具1, this.輪1_金具1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪1_金具2CP = new ColorP(this.X0Y0_輪1_金具2, this.輪1_金具2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪1_金具3CP = new ColorP(this.X0Y0_輪1_金具3, this.輪1_金具3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪1_金具左CP = new ColorP(this.X0Y0_輪1_金具左, this.輪1_金具左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪1_金具右CP = new ColorP(this.X0Y0_輪1_金具右, this.輪1_金具右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節14_節CP = new ColorP(this.X0Y0_節14_節, this.節14_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節14_棘1CP = new ColorP(this.X0Y0_節14_棘1, this.節14_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節14_棘2CP = new ColorP(this.X0Y0_節14_棘2, this.節14_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節14_脈CP = new ColorP(this.X0Y0_節14_脈, this.節14_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節15_節CP = new ColorP(this.X0Y0_節15_節, this.節15_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節15_棘1CP = new ColorP(this.X0Y0_節15_棘1, this.節15_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節15_棘2CP = new ColorP(this.X0Y0_節15_棘2, this.節15_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節15_脈CP = new ColorP(this.X0Y0_節15_脈, this.節15_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節16_節CP = new ColorP(this.X0Y0_節16_節, this.節16_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節16_棘1CP = new ColorP(this.X0Y0_節16_棘1, this.節16_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節16_棘2CP = new ColorP(this.X0Y0_節16_棘2, this.節16_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節16_脈CP = new ColorP(this.X0Y0_節16_脈, this.節16_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節17_節CP = new ColorP(this.X0Y0_節17_節, this.節17_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節17_棘1CP = new ColorP(this.X0Y0_節17_棘1, this.節17_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節17_棘2CP = new ColorP(this.X0Y0_節17_棘2, this.節17_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節17_脈CP = new ColorP(this.X0Y0_節17_脈, this.節17_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節18_節CP = new ColorP(this.X0Y0_節18_節, this.節18_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節18_棘1CP = new ColorP(this.X0Y0_節18_棘1, this.節18_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節18_棘2CP = new ColorP(this.X0Y0_節18_棘2, this.節18_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節18_脈CP = new ColorP(this.X0Y0_節18_脈, this.節18_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節19_節CP = new ColorP(this.X0Y0_節19_節, this.節19_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節19_棘1CP = new ColorP(this.X0Y0_節19_棘1, this.節19_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節19_棘2CP = new ColorP(this.X0Y0_節19_棘2, this.節19_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節19_脈CP = new ColorP(this.X0Y0_節19_脈, this.節19_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節20_節CP = new ColorP(this.X0Y0_節20_節, this.節20_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節20_棘1CP = new ColorP(this.X0Y0_節20_棘1, this.節20_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節20_棘2CP = new ColorP(this.X0Y0_節20_棘2, this.節20_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節20_脈CP = new ColorP(this.X0Y0_節20_脈, this.節20_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節21_節CP = new ColorP(this.X0Y0_節21_節, this.節21_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節21_棘1CP = new ColorP(this.X0Y0_節21_棘1, this.節21_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節21_棘2CP = new ColorP(this.X0Y0_節21_棘2, this.節21_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節21_脈CP = new ColorP(this.X0Y0_節21_脈, this.節21_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節22_節CP = new ColorP(this.X0Y0_節22_節, this.節22_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節22_棘1CP = new ColorP(this.X0Y0_節22_棘1, this.節22_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節22_棘2CP = new ColorP(this.X0Y0_節22_棘2, this.節22_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節22_脈CP = new ColorP(this.X0Y0_節22_脈, this.節22_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節23_節CP = new ColorP(this.X0Y0_節23_節, this.節23_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節23_棘1CP = new ColorP(this.X0Y0_節23_棘1, this.節23_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節23_棘2CP = new ColorP(this.X0Y0_節23_棘2, this.節23_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節23_脈CP = new ColorP(this.X0Y0_節23_脈, this.節23_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節24_節CP = new ColorP(this.X0Y0_節24_節, this.節24_節CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節24_棘1CP = new ColorP(this.X0Y0_節24_棘1, this.節24_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節24_棘2CP = new ColorP(this.X0Y0_節24_棘2, this.節24_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_節24_脈CP = new ColorP(this.X0Y0_節24_脈, this.節24_脈CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_革CP = new ColorP(this.X0Y0_輪2_革, this.輪2_革CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_金具1CP = new ColorP(this.X0Y0_輪2_金具1, this.輪2_金具1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_金具2CP = new ColorP(this.X0Y0_輪2_金具2, this.輪2_金具2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_金具3CP = new ColorP(this.X0Y0_輪2_金具3, this.輪2_金具3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_金具左CP = new ColorP(this.X0Y0_輪2_金具左, this.輪2_金具左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_輪2_金具右CP = new ColorP(this.X0Y0_輪2_金具右, this.輪2_金具右CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_下顎_顎CP = new ColorP(this.X0Y0_先端_下顎_顎, this.先端_下顎_顎CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_下顎_口内CP = new ColorP(this.X0Y0_先端_下顎_口内, this.先端_下顎_口内CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_下顎_棘12CP = new ColorP(this.X0Y0_先端_下顎_棘12, this.先端_下顎_棘12CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_下顎_棘11CP = new ColorP(this.X0Y0_先端_下顎_棘11, this.先端_下顎_棘11CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_下顎_棘10CP = new ColorP(this.X0Y0_先端_下顎_棘10, this.先端_下顎_棘10CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_下顎_棘9CP = new ColorP(this.X0Y0_先端_下顎_棘9, this.先端_下顎_棘9CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_下顎_棘8CP = new ColorP(this.X0Y0_先端_下顎_棘8, this.先端_下顎_棘8CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_下顎_棘7CP = new ColorP(this.X0Y0_先端_下顎_棘7, this.先端_下顎_棘7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_下顎_脈1CP = new ColorP(this.X0Y0_先端_下顎_脈1, this.先端_下顎_脈1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_下顎_脈2CP = new ColorP(this.X0Y0_先端_下顎_脈2, this.先端_下顎_脈2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_下顎_脈3CP = new ColorP(this.X0Y0_先端_下顎_脈3, this.先端_下顎_脈3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_下顎_棘6CP = new ColorP(this.X0Y0_先端_下顎_棘6, this.先端_下顎_棘6CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_下顎_棘5CP = new ColorP(this.X0Y0_先端_下顎_棘5, this.先端_下顎_棘5CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_下顎_棘4CP = new ColorP(this.X0Y0_先端_下顎_棘4, this.先端_下顎_棘4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_下顎_棘3CP = new ColorP(this.X0Y0_先端_下顎_棘3, this.先端_下顎_棘3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_下顎_棘2CP = new ColorP(this.X0Y0_先端_下顎_棘2, this.先端_下顎_棘2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_下顎_棘1CP = new ColorP(this.X0Y0_先端_下顎_棘1, this.先端_下顎_棘1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_上顎_棘12CP = new ColorP(this.X0Y0_先端_上顎_棘12, this.先端_上顎_棘12CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_上顎_棘11CP = new ColorP(this.X0Y0_先端_上顎_棘11, this.先端_上顎_棘11CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_上顎_棘10CP = new ColorP(this.X0Y0_先端_上顎_棘10, this.先端_上顎_棘10CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_上顎_棘9CP = new ColorP(this.X0Y0_先端_上顎_棘9, this.先端_上顎_棘9CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_上顎_棘8CP = new ColorP(this.X0Y0_先端_上顎_棘8, this.先端_上顎_棘8CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_上顎_棘7CP = new ColorP(this.X0Y0_先端_上顎_棘7, this.先端_上顎_棘7CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_上顎_顎CP = new ColorP(this.X0Y0_先端_上顎_顎, this.先端_上顎_顎CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_上顎_脈1CP = new ColorP(this.X0Y0_先端_上顎_脈1, this.先端_上顎_脈1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_上顎_脈2CP = new ColorP(this.X0Y0_先端_上顎_脈2, this.先端_上顎_脈2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_上顎_脈3CP = new ColorP(this.X0Y0_先端_上顎_脈3, this.先端_上顎_脈3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_上顎_脈4CP = new ColorP(this.X0Y0_先端_上顎_脈4, this.先端_上顎_脈4CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_輪_革CP = new ColorP(this.X0Y0_先端_輪_革, this.先端_輪_革CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_輪_金具1CP = new ColorP(this.X0Y0_先端_輪_金具1, this.先端_輪_金具1CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_輪_金具2CP = new ColorP(this.X0Y0_先端_輪_金具2, this.先端_輪_金具2CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_輪_金具3CP = new ColorP(this.X0Y0_先端_輪_金具3, this.先端_輪_金具3CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_輪_金具左CP = new ColorP(this.X0Y0_先端_輪_金具左, this.先端_輪_金具左CD, CS$<>8__locals1.DisUnit, true);
			this.X0Y0_先端_輪_金具右CP = new ColorP(this.X0Y0_先端_輪_金具右, this.先端_輪_金具右CD, CS$<>8__locals1.DisUnit, true);
			this.濃度 = e.濃度;
			this.鎖1 = new 拘束鎖(CS$<>8__locals1.DisUnit, false, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖2 = new 拘束鎖(CS$<>8__locals1.DisUnit, true, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖3 = new 拘束鎖(CS$<>8__locals1.DisUnit, false, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖4 = new 拘束鎖(CS$<>8__locals1.DisUnit, true, 配色指定, CS$<>8__locals1.体配色, this.Xasix);
			this.鎖2.反転Y = true;
			this.鎖4.反転Y = true;
			this.鎖1.接続(this.鎖1_接続点);
			this.鎖2.接続(this.鎖2_接続点);
			this.鎖3.接続(this.鎖3_接続点);
			this.鎖4.接続(this.鎖4_接続点);
			int num = this.右 ? -10 : 10;
			this.鎖1.角度B -= (double)num;
			this.鎖2.角度B += (double)num;
			this.鎖3.角度B += (double)num;
			this.鎖4.角度B -= (double)num;
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

		public bool 節1_棘1_表示
		{
			get
			{
				return this.X0Y0_節1_棘1.Dra;
			}
			set
			{
				this.X0Y0_節1_棘1.Dra = value;
				this.X0Y0_節1_棘1.Hit = value;
			}
		}

		public bool 節1_棘2_表示
		{
			get
			{
				return this.X0Y0_節1_棘2.Dra;
			}
			set
			{
				this.X0Y0_節1_棘2.Dra = value;
				this.X0Y0_節1_棘2.Hit = value;
			}
		}

		public bool 節1_脈_表示
		{
			get
			{
				return this.X0Y0_節1_脈.Dra;
			}
			set
			{
				this.X0Y0_節1_脈.Dra = value;
				this.X0Y0_節1_脈.Hit = value;
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

		public bool 節2_棘1_表示
		{
			get
			{
				return this.X0Y0_節2_棘1.Dra;
			}
			set
			{
				this.X0Y0_節2_棘1.Dra = value;
				this.X0Y0_節2_棘1.Hit = value;
			}
		}

		public bool 節2_棘2_表示
		{
			get
			{
				return this.X0Y0_節2_棘2.Dra;
			}
			set
			{
				this.X0Y0_節2_棘2.Dra = value;
				this.X0Y0_節2_棘2.Hit = value;
			}
		}

		public bool 節2_脈_表示
		{
			get
			{
				return this.X0Y0_節2_脈.Dra;
			}
			set
			{
				this.X0Y0_節2_脈.Dra = value;
				this.X0Y0_節2_脈.Hit = value;
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

		public bool 節3_棘1_表示
		{
			get
			{
				return this.X0Y0_節3_棘1.Dra;
			}
			set
			{
				this.X0Y0_節3_棘1.Dra = value;
				this.X0Y0_節3_棘1.Hit = value;
			}
		}

		public bool 節3_棘2_表示
		{
			get
			{
				return this.X0Y0_節3_棘2.Dra;
			}
			set
			{
				this.X0Y0_節3_棘2.Dra = value;
				this.X0Y0_節3_棘2.Hit = value;
			}
		}

		public bool 節3_脈_表示
		{
			get
			{
				return this.X0Y0_節3_脈.Dra;
			}
			set
			{
				this.X0Y0_節3_脈.Dra = value;
				this.X0Y0_節3_脈.Hit = value;
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

		public bool 節4_棘1_表示
		{
			get
			{
				return this.X0Y0_節4_棘1.Dra;
			}
			set
			{
				this.X0Y0_節4_棘1.Dra = value;
				this.X0Y0_節4_棘1.Hit = value;
			}
		}

		public bool 節4_棘2_表示
		{
			get
			{
				return this.X0Y0_節4_棘2.Dra;
			}
			set
			{
				this.X0Y0_節4_棘2.Dra = value;
				this.X0Y0_節4_棘2.Hit = value;
			}
		}

		public bool 節4_脈_表示
		{
			get
			{
				return this.X0Y0_節4_脈.Dra;
			}
			set
			{
				this.X0Y0_節4_脈.Dra = value;
				this.X0Y0_節4_脈.Hit = value;
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

		public bool 節5_棘1_表示
		{
			get
			{
				return this.X0Y0_節5_棘1.Dra;
			}
			set
			{
				this.X0Y0_節5_棘1.Dra = value;
				this.X0Y0_節5_棘1.Hit = value;
			}
		}

		public bool 節5_棘2_表示
		{
			get
			{
				return this.X0Y0_節5_棘2.Dra;
			}
			set
			{
				this.X0Y0_節5_棘2.Dra = value;
				this.X0Y0_節5_棘2.Hit = value;
			}
		}

		public bool 節5_脈_表示
		{
			get
			{
				return this.X0Y0_節5_脈.Dra;
			}
			set
			{
				this.X0Y0_節5_脈.Dra = value;
				this.X0Y0_節5_脈.Hit = value;
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

		public bool 節6_棘1_表示
		{
			get
			{
				return this.X0Y0_節6_棘1.Dra;
			}
			set
			{
				this.X0Y0_節6_棘1.Dra = value;
				this.X0Y0_節6_棘1.Hit = value;
			}
		}

		public bool 節6_棘2_表示
		{
			get
			{
				return this.X0Y0_節6_棘2.Dra;
			}
			set
			{
				this.X0Y0_節6_棘2.Dra = value;
				this.X0Y0_節6_棘2.Hit = value;
			}
		}

		public bool 節6_脈_表示
		{
			get
			{
				return this.X0Y0_節6_脈.Dra;
			}
			set
			{
				this.X0Y0_節6_脈.Dra = value;
				this.X0Y0_節6_脈.Hit = value;
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

		public bool 節7_棘1_表示
		{
			get
			{
				return this.X0Y0_節7_棘1.Dra;
			}
			set
			{
				this.X0Y0_節7_棘1.Dra = value;
				this.X0Y0_節7_棘1.Hit = value;
			}
		}

		public bool 節7_棘2_表示
		{
			get
			{
				return this.X0Y0_節7_棘2.Dra;
			}
			set
			{
				this.X0Y0_節7_棘2.Dra = value;
				this.X0Y0_節7_棘2.Hit = value;
			}
		}

		public bool 節7_脈_表示
		{
			get
			{
				return this.X0Y0_節7_脈.Dra;
			}
			set
			{
				this.X0Y0_節7_脈.Dra = value;
				this.X0Y0_節7_脈.Hit = value;
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

		public bool 節8_棘1_表示
		{
			get
			{
				return this.X0Y0_節8_棘1.Dra;
			}
			set
			{
				this.X0Y0_節8_棘1.Dra = value;
				this.X0Y0_節8_棘1.Hit = value;
			}
		}

		public bool 節8_棘2_表示
		{
			get
			{
				return this.X0Y0_節8_棘2.Dra;
			}
			set
			{
				this.X0Y0_節8_棘2.Dra = value;
				this.X0Y0_節8_棘2.Hit = value;
			}
		}

		public bool 節8_脈_表示
		{
			get
			{
				return this.X0Y0_節8_脈.Dra;
			}
			set
			{
				this.X0Y0_節8_脈.Dra = value;
				this.X0Y0_節8_脈.Hit = value;
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

		public bool 節9_棘1_表示
		{
			get
			{
				return this.X0Y0_節9_棘1.Dra;
			}
			set
			{
				this.X0Y0_節9_棘1.Dra = value;
				this.X0Y0_節9_棘1.Hit = value;
			}
		}

		public bool 節9_棘2_表示
		{
			get
			{
				return this.X0Y0_節9_棘2.Dra;
			}
			set
			{
				this.X0Y0_節9_棘2.Dra = value;
				this.X0Y0_節9_棘2.Hit = value;
			}
		}

		public bool 節9_脈_表示
		{
			get
			{
				return this.X0Y0_節9_脈.Dra;
			}
			set
			{
				this.X0Y0_節9_脈.Dra = value;
				this.X0Y0_節9_脈.Hit = value;
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

		public bool 節10_棘1_表示
		{
			get
			{
				return this.X0Y0_節10_棘1.Dra;
			}
			set
			{
				this.X0Y0_節10_棘1.Dra = value;
				this.X0Y0_節10_棘1.Hit = value;
			}
		}

		public bool 節10_棘2_表示
		{
			get
			{
				return this.X0Y0_節10_棘2.Dra;
			}
			set
			{
				this.X0Y0_節10_棘2.Dra = value;
				this.X0Y0_節10_棘2.Hit = value;
			}
		}

		public bool 節10_脈_表示
		{
			get
			{
				return this.X0Y0_節10_脈.Dra;
			}
			set
			{
				this.X0Y0_節10_脈.Dra = value;
				this.X0Y0_節10_脈.Hit = value;
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

		public bool 節11_棘1_表示
		{
			get
			{
				return this.X0Y0_節11_棘1.Dra;
			}
			set
			{
				this.X0Y0_節11_棘1.Dra = value;
				this.X0Y0_節11_棘1.Hit = value;
			}
		}

		public bool 節11_棘2_表示
		{
			get
			{
				return this.X0Y0_節11_棘2.Dra;
			}
			set
			{
				this.X0Y0_節11_棘2.Dra = value;
				this.X0Y0_節11_棘2.Hit = value;
			}
		}

		public bool 節11_脈_表示
		{
			get
			{
				return this.X0Y0_節11_脈.Dra;
			}
			set
			{
				this.X0Y0_節11_脈.Dra = value;
				this.X0Y0_節11_脈.Hit = value;
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

		public bool 節12_棘1_表示
		{
			get
			{
				return this.X0Y0_節12_棘1.Dra;
			}
			set
			{
				this.X0Y0_節12_棘1.Dra = value;
				this.X0Y0_節12_棘1.Hit = value;
			}
		}

		public bool 節12_棘2_表示
		{
			get
			{
				return this.X0Y0_節12_棘2.Dra;
			}
			set
			{
				this.X0Y0_節12_棘2.Dra = value;
				this.X0Y0_節12_棘2.Hit = value;
			}
		}

		public bool 節12_脈_表示
		{
			get
			{
				return this.X0Y0_節12_脈.Dra;
			}
			set
			{
				this.X0Y0_節12_脈.Dra = value;
				this.X0Y0_節12_脈.Hit = value;
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

		public bool 節13_棘1_表示
		{
			get
			{
				return this.X0Y0_節13_棘1.Dra;
			}
			set
			{
				this.X0Y0_節13_棘1.Dra = value;
				this.X0Y0_節13_棘1.Hit = value;
			}
		}

		public bool 節13_棘2_表示
		{
			get
			{
				return this.X0Y0_節13_棘2.Dra;
			}
			set
			{
				this.X0Y0_節13_棘2.Dra = value;
				this.X0Y0_節13_棘2.Hit = value;
			}
		}

		public bool 節13_脈_表示
		{
			get
			{
				return this.X0Y0_節13_脈.Dra;
			}
			set
			{
				this.X0Y0_節13_脈.Dra = value;
				this.X0Y0_節13_脈.Hit = value;
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

		public bool 節14_棘1_表示
		{
			get
			{
				return this.X0Y0_節14_棘1.Dra;
			}
			set
			{
				this.X0Y0_節14_棘1.Dra = value;
				this.X0Y0_節14_棘1.Hit = value;
			}
		}

		public bool 節14_棘2_表示
		{
			get
			{
				return this.X0Y0_節14_棘2.Dra;
			}
			set
			{
				this.X0Y0_節14_棘2.Dra = value;
				this.X0Y0_節14_棘2.Hit = value;
			}
		}

		public bool 節14_脈_表示
		{
			get
			{
				return this.X0Y0_節14_脈.Dra;
			}
			set
			{
				this.X0Y0_節14_脈.Dra = value;
				this.X0Y0_節14_脈.Hit = value;
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

		public bool 節15_棘1_表示
		{
			get
			{
				return this.X0Y0_節15_棘1.Dra;
			}
			set
			{
				this.X0Y0_節15_棘1.Dra = value;
				this.X0Y0_節15_棘1.Hit = value;
			}
		}

		public bool 節15_棘2_表示
		{
			get
			{
				return this.X0Y0_節15_棘2.Dra;
			}
			set
			{
				this.X0Y0_節15_棘2.Dra = value;
				this.X0Y0_節15_棘2.Hit = value;
			}
		}

		public bool 節15_脈_表示
		{
			get
			{
				return this.X0Y0_節15_脈.Dra;
			}
			set
			{
				this.X0Y0_節15_脈.Dra = value;
				this.X0Y0_節15_脈.Hit = value;
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

		public bool 節16_棘1_表示
		{
			get
			{
				return this.X0Y0_節16_棘1.Dra;
			}
			set
			{
				this.X0Y0_節16_棘1.Dra = value;
				this.X0Y0_節16_棘1.Hit = value;
			}
		}

		public bool 節16_棘2_表示
		{
			get
			{
				return this.X0Y0_節16_棘2.Dra;
			}
			set
			{
				this.X0Y0_節16_棘2.Dra = value;
				this.X0Y0_節16_棘2.Hit = value;
			}
		}

		public bool 節16_脈_表示
		{
			get
			{
				return this.X0Y0_節16_脈.Dra;
			}
			set
			{
				this.X0Y0_節16_脈.Dra = value;
				this.X0Y0_節16_脈.Hit = value;
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

		public bool 節17_棘1_表示
		{
			get
			{
				return this.X0Y0_節17_棘1.Dra;
			}
			set
			{
				this.X0Y0_節17_棘1.Dra = value;
				this.X0Y0_節17_棘1.Hit = value;
			}
		}

		public bool 節17_棘2_表示
		{
			get
			{
				return this.X0Y0_節17_棘2.Dra;
			}
			set
			{
				this.X0Y0_節17_棘2.Dra = value;
				this.X0Y0_節17_棘2.Hit = value;
			}
		}

		public bool 節17_脈_表示
		{
			get
			{
				return this.X0Y0_節17_脈.Dra;
			}
			set
			{
				this.X0Y0_節17_脈.Dra = value;
				this.X0Y0_節17_脈.Hit = value;
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

		public bool 節18_棘1_表示
		{
			get
			{
				return this.X0Y0_節18_棘1.Dra;
			}
			set
			{
				this.X0Y0_節18_棘1.Dra = value;
				this.X0Y0_節18_棘1.Hit = value;
			}
		}

		public bool 節18_棘2_表示
		{
			get
			{
				return this.X0Y0_節18_棘2.Dra;
			}
			set
			{
				this.X0Y0_節18_棘2.Dra = value;
				this.X0Y0_節18_棘2.Hit = value;
			}
		}

		public bool 節18_脈_表示
		{
			get
			{
				return this.X0Y0_節18_脈.Dra;
			}
			set
			{
				this.X0Y0_節18_脈.Dra = value;
				this.X0Y0_節18_脈.Hit = value;
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

		public bool 節19_棘1_表示
		{
			get
			{
				return this.X0Y0_節19_棘1.Dra;
			}
			set
			{
				this.X0Y0_節19_棘1.Dra = value;
				this.X0Y0_節19_棘1.Hit = value;
			}
		}

		public bool 節19_棘2_表示
		{
			get
			{
				return this.X0Y0_節19_棘2.Dra;
			}
			set
			{
				this.X0Y0_節19_棘2.Dra = value;
				this.X0Y0_節19_棘2.Hit = value;
			}
		}

		public bool 節19_脈_表示
		{
			get
			{
				return this.X0Y0_節19_脈.Dra;
			}
			set
			{
				this.X0Y0_節19_脈.Dra = value;
				this.X0Y0_節19_脈.Hit = value;
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

		public bool 節20_棘1_表示
		{
			get
			{
				return this.X0Y0_節20_棘1.Dra;
			}
			set
			{
				this.X0Y0_節20_棘1.Dra = value;
				this.X0Y0_節20_棘1.Hit = value;
			}
		}

		public bool 節20_棘2_表示
		{
			get
			{
				return this.X0Y0_節20_棘2.Dra;
			}
			set
			{
				this.X0Y0_節20_棘2.Dra = value;
				this.X0Y0_節20_棘2.Hit = value;
			}
		}

		public bool 節20_脈_表示
		{
			get
			{
				return this.X0Y0_節20_脈.Dra;
			}
			set
			{
				this.X0Y0_節20_脈.Dra = value;
				this.X0Y0_節20_脈.Hit = value;
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

		public bool 節21_棘1_表示
		{
			get
			{
				return this.X0Y0_節21_棘1.Dra;
			}
			set
			{
				this.X0Y0_節21_棘1.Dra = value;
				this.X0Y0_節21_棘1.Hit = value;
			}
		}

		public bool 節21_棘2_表示
		{
			get
			{
				return this.X0Y0_節21_棘2.Dra;
			}
			set
			{
				this.X0Y0_節21_棘2.Dra = value;
				this.X0Y0_節21_棘2.Hit = value;
			}
		}

		public bool 節21_脈_表示
		{
			get
			{
				return this.X0Y0_節21_脈.Dra;
			}
			set
			{
				this.X0Y0_節21_脈.Dra = value;
				this.X0Y0_節21_脈.Hit = value;
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

		public bool 節22_棘1_表示
		{
			get
			{
				return this.X0Y0_節22_棘1.Dra;
			}
			set
			{
				this.X0Y0_節22_棘1.Dra = value;
				this.X0Y0_節22_棘1.Hit = value;
			}
		}

		public bool 節22_棘2_表示
		{
			get
			{
				return this.X0Y0_節22_棘2.Dra;
			}
			set
			{
				this.X0Y0_節22_棘2.Dra = value;
				this.X0Y0_節22_棘2.Hit = value;
			}
		}

		public bool 節22_脈_表示
		{
			get
			{
				return this.X0Y0_節22_脈.Dra;
			}
			set
			{
				this.X0Y0_節22_脈.Dra = value;
				this.X0Y0_節22_脈.Hit = value;
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

		public bool 節23_棘1_表示
		{
			get
			{
				return this.X0Y0_節23_棘1.Dra;
			}
			set
			{
				this.X0Y0_節23_棘1.Dra = value;
				this.X0Y0_節23_棘1.Hit = value;
			}
		}

		public bool 節23_棘2_表示
		{
			get
			{
				return this.X0Y0_節23_棘2.Dra;
			}
			set
			{
				this.X0Y0_節23_棘2.Dra = value;
				this.X0Y0_節23_棘2.Hit = value;
			}
		}

		public bool 節23_脈_表示
		{
			get
			{
				return this.X0Y0_節23_脈.Dra;
			}
			set
			{
				this.X0Y0_節23_脈.Dra = value;
				this.X0Y0_節23_脈.Hit = value;
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

		public bool 節24_棘1_表示
		{
			get
			{
				return this.X0Y0_節24_棘1.Dra;
			}
			set
			{
				this.X0Y0_節24_棘1.Dra = value;
				this.X0Y0_節24_棘1.Hit = value;
			}
		}

		public bool 節24_棘2_表示
		{
			get
			{
				return this.X0Y0_節24_棘2.Dra;
			}
			set
			{
				this.X0Y0_節24_棘2.Dra = value;
				this.X0Y0_節24_棘2.Hit = value;
			}
		}

		public bool 節24_脈_表示
		{
			get
			{
				return this.X0Y0_節24_脈.Dra;
			}
			set
			{
				this.X0Y0_節24_脈.Dra = value;
				this.X0Y0_節24_脈.Hit = value;
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

		public bool 先端_下顎_顎_表示
		{
			get
			{
				return this.X0Y0_先端_下顎_顎.Dra;
			}
			set
			{
				this.X0Y0_先端_下顎_顎.Dra = value;
				this.X0Y0_先端_下顎_顎.Hit = value;
			}
		}

		public bool 先端_下顎_口内_表示
		{
			get
			{
				return this.X0Y0_先端_下顎_口内.Dra;
			}
			set
			{
				this.X0Y0_先端_下顎_口内.Dra = value;
				this.X0Y0_先端_下顎_口内.Hit = value;
			}
		}

		public bool 先端_下顎_棘12_表示
		{
			get
			{
				return this.X0Y0_先端_下顎_棘12.Dra;
			}
			set
			{
				this.X0Y0_先端_下顎_棘12.Dra = value;
				this.X0Y0_先端_下顎_棘12.Hit = value;
			}
		}

		public bool 先端_下顎_棘11_表示
		{
			get
			{
				return this.X0Y0_先端_下顎_棘11.Dra;
			}
			set
			{
				this.X0Y0_先端_下顎_棘11.Dra = value;
				this.X0Y0_先端_下顎_棘11.Hit = value;
			}
		}

		public bool 先端_下顎_棘10_表示
		{
			get
			{
				return this.X0Y0_先端_下顎_棘10.Dra;
			}
			set
			{
				this.X0Y0_先端_下顎_棘10.Dra = value;
				this.X0Y0_先端_下顎_棘10.Hit = value;
			}
		}

		public bool 先端_下顎_棘9_表示
		{
			get
			{
				return this.X0Y0_先端_下顎_棘9.Dra;
			}
			set
			{
				this.X0Y0_先端_下顎_棘9.Dra = value;
				this.X0Y0_先端_下顎_棘9.Hit = value;
			}
		}

		public bool 先端_下顎_棘8_表示
		{
			get
			{
				return this.X0Y0_先端_下顎_棘8.Dra;
			}
			set
			{
				this.X0Y0_先端_下顎_棘8.Dra = value;
				this.X0Y0_先端_下顎_棘8.Hit = value;
			}
		}

		public bool 先端_下顎_棘7_表示
		{
			get
			{
				return this.X0Y0_先端_下顎_棘7.Dra;
			}
			set
			{
				this.X0Y0_先端_下顎_棘7.Dra = value;
				this.X0Y0_先端_下顎_棘7.Hit = value;
			}
		}

		public bool 先端_下顎_脈1_表示
		{
			get
			{
				return this.X0Y0_先端_下顎_脈1.Dra;
			}
			set
			{
				this.X0Y0_先端_下顎_脈1.Dra = value;
				this.X0Y0_先端_下顎_脈1.Hit = value;
			}
		}

		public bool 先端_下顎_脈2_表示
		{
			get
			{
				return this.X0Y0_先端_下顎_脈2.Dra;
			}
			set
			{
				this.X0Y0_先端_下顎_脈2.Dra = value;
				this.X0Y0_先端_下顎_脈2.Hit = value;
			}
		}

		public bool 先端_下顎_脈3_表示
		{
			get
			{
				return this.X0Y0_先端_下顎_脈3.Dra;
			}
			set
			{
				this.X0Y0_先端_下顎_脈3.Dra = value;
				this.X0Y0_先端_下顎_脈3.Hit = value;
			}
		}

		public bool 先端_下顎_棘6_表示
		{
			get
			{
				return this.X0Y0_先端_下顎_棘6.Dra;
			}
			set
			{
				this.X0Y0_先端_下顎_棘6.Dra = value;
				this.X0Y0_先端_下顎_棘6.Hit = value;
			}
		}

		public bool 先端_下顎_棘5_表示
		{
			get
			{
				return this.X0Y0_先端_下顎_棘5.Dra;
			}
			set
			{
				this.X0Y0_先端_下顎_棘5.Dra = value;
				this.X0Y0_先端_下顎_棘5.Hit = value;
			}
		}

		public bool 先端_下顎_棘4_表示
		{
			get
			{
				return this.X0Y0_先端_下顎_棘4.Dra;
			}
			set
			{
				this.X0Y0_先端_下顎_棘4.Dra = value;
				this.X0Y0_先端_下顎_棘4.Hit = value;
			}
		}

		public bool 先端_下顎_棘3_表示
		{
			get
			{
				return this.X0Y0_先端_下顎_棘3.Dra;
			}
			set
			{
				this.X0Y0_先端_下顎_棘3.Dra = value;
				this.X0Y0_先端_下顎_棘3.Hit = value;
			}
		}

		public bool 先端_下顎_棘2_表示
		{
			get
			{
				return this.X0Y0_先端_下顎_棘2.Dra;
			}
			set
			{
				this.X0Y0_先端_下顎_棘2.Dra = value;
				this.X0Y0_先端_下顎_棘2.Hit = value;
			}
		}

		public bool 先端_下顎_棘1_表示
		{
			get
			{
				return this.X0Y0_先端_下顎_棘1.Dra;
			}
			set
			{
				this.X0Y0_先端_下顎_棘1.Dra = value;
				this.X0Y0_先端_下顎_棘1.Hit = value;
			}
		}

		public bool 先端_上顎_棘12_表示
		{
			get
			{
				return this.X0Y0_先端_上顎_棘12.Dra;
			}
			set
			{
				this.X0Y0_先端_上顎_棘12.Dra = value;
				this.X0Y0_先端_上顎_棘12.Hit = value;
			}
		}

		public bool 先端_上顎_棘11_表示
		{
			get
			{
				return this.X0Y0_先端_上顎_棘11.Dra;
			}
			set
			{
				this.X0Y0_先端_上顎_棘11.Dra = value;
				this.X0Y0_先端_上顎_棘11.Hit = value;
			}
		}

		public bool 先端_上顎_棘10_表示
		{
			get
			{
				return this.X0Y0_先端_上顎_棘10.Dra;
			}
			set
			{
				this.X0Y0_先端_上顎_棘10.Dra = value;
				this.X0Y0_先端_上顎_棘10.Hit = value;
			}
		}

		public bool 先端_上顎_棘9_表示
		{
			get
			{
				return this.X0Y0_先端_上顎_棘9.Dra;
			}
			set
			{
				this.X0Y0_先端_上顎_棘9.Dra = value;
				this.X0Y0_先端_上顎_棘9.Hit = value;
			}
		}

		public bool 先端_上顎_棘8_表示
		{
			get
			{
				return this.X0Y0_先端_上顎_棘8.Dra;
			}
			set
			{
				this.X0Y0_先端_上顎_棘8.Dra = value;
				this.X0Y0_先端_上顎_棘8.Hit = value;
			}
		}

		public bool 先端_上顎_棘7_表示
		{
			get
			{
				return this.X0Y0_先端_上顎_棘7.Dra;
			}
			set
			{
				this.X0Y0_先端_上顎_棘7.Dra = value;
				this.X0Y0_先端_上顎_棘7.Hit = value;
			}
		}

		public bool 先端_上顎_顎_表示
		{
			get
			{
				return this.X0Y0_先端_上顎_顎.Dra;
			}
			set
			{
				this.X0Y0_先端_上顎_顎.Dra = value;
				this.X0Y0_先端_上顎_顎.Hit = value;
			}
		}

		public bool 先端_上顎_脈1_表示
		{
			get
			{
				return this.X0Y0_先端_上顎_脈1.Dra;
			}
			set
			{
				this.X0Y0_先端_上顎_脈1.Dra = value;
				this.X0Y0_先端_上顎_脈1.Hit = value;
			}
		}

		public bool 先端_上顎_脈2_表示
		{
			get
			{
				return this.X0Y0_先端_上顎_脈2.Dra;
			}
			set
			{
				this.X0Y0_先端_上顎_脈2.Dra = value;
				this.X0Y0_先端_上顎_脈2.Hit = value;
			}
		}

		public bool 先端_上顎_脈3_表示
		{
			get
			{
				return this.X0Y0_先端_上顎_脈3.Dra;
			}
			set
			{
				this.X0Y0_先端_上顎_脈3.Dra = value;
				this.X0Y0_先端_上顎_脈3.Hit = value;
			}
		}

		public bool 先端_上顎_脈4_表示
		{
			get
			{
				return this.X0Y0_先端_上顎_脈4.Dra;
			}
			set
			{
				this.X0Y0_先端_上顎_脈4.Dra = value;
				this.X0Y0_先端_上顎_脈4.Hit = value;
			}
		}

		public bool 先端_輪_革_表示
		{
			get
			{
				return this.X0Y0_先端_輪_革.Dra;
			}
			set
			{
				this.X0Y0_先端_輪_革.Dra = value;
				this.X0Y0_先端_輪_革.Hit = value;
			}
		}

		public bool 先端_輪_金具1_表示
		{
			get
			{
				return this.X0Y0_先端_輪_金具1.Dra;
			}
			set
			{
				this.X0Y0_先端_輪_金具1.Dra = value;
				this.X0Y0_先端_輪_金具1.Hit = value;
			}
		}

		public bool 先端_輪_金具2_表示
		{
			get
			{
				return this.X0Y0_先端_輪_金具2.Dra;
			}
			set
			{
				this.X0Y0_先端_輪_金具2.Dra = value;
				this.X0Y0_先端_輪_金具2.Hit = value;
			}
		}

		public bool 先端_輪_金具3_表示
		{
			get
			{
				return this.X0Y0_先端_輪_金具3.Dra;
			}
			set
			{
				this.X0Y0_先端_輪_金具3.Dra = value;
				this.X0Y0_先端_輪_金具3.Hit = value;
			}
		}

		public bool 先端_輪_金具左_表示
		{
			get
			{
				return this.X0Y0_先端_輪_金具左.Dra;
			}
			set
			{
				this.X0Y0_先端_輪_金具左.Dra = value;
				this.X0Y0_先端_輪_金具左.Hit = value;
			}
		}

		public bool 先端_輪_金具右_表示
		{
			get
			{
				return this.X0Y0_先端_輪_金具右.Dra;
			}
			set
			{
				this.X0Y0_先端_輪_金具右.Dra = value;
				this.X0Y0_先端_輪_金具右.Hit = value;
			}
		}

		public bool 先端表示
		{
			get
			{
				return this.先端_下顎_顎_表示;
			}
			set
			{
				this.先端_下顎_顎_表示 = value;
				this.先端_下顎_口内_表示 = value;
				this.先端_下顎_棘12_表示 = value;
				this.先端_下顎_棘11_表示 = value;
				this.先端_下顎_棘10_表示 = value;
				this.先端_下顎_棘9_表示 = value;
				this.先端_下顎_棘8_表示 = value;
				this.先端_下顎_棘7_表示 = value;
				this.先端_下顎_脈1_表示 = value;
				this.先端_下顎_脈2_表示 = value;
				this.先端_下顎_脈3_表示 = value;
				this.先端_下顎_棘6_表示 = value;
				this.先端_下顎_棘5_表示 = value;
				this.先端_下顎_棘4_表示 = value;
				this.先端_下顎_棘3_表示 = value;
				this.先端_下顎_棘2_表示 = value;
				this.先端_下顎_棘1_表示 = value;
				this.先端_上顎_棘12_表示 = value;
				this.先端_上顎_棘11_表示 = value;
				this.先端_上顎_棘10_表示 = value;
				this.先端_上顎_棘9_表示 = value;
				this.先端_上顎_棘8_表示 = value;
				this.先端_上顎_棘7_表示 = value;
				this.先端_上顎_顎_表示 = value;
				this.先端_上顎_脈1_表示 = value;
				this.先端_上顎_脈2_表示 = value;
				this.先端_上顎_脈3_表示 = value;
				this.先端_上顎_脈4_表示 = value;
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

		public bool 輪3表示
		{
			get
			{
				return this.先端_輪_革_表示;
			}
			set
			{
				value = (this.先端表示 && value);
				this.先端_輪_革_表示 = value;
				this.先端_輪_金具1_表示 = value;
				this.先端_輪_金具2_表示 = value;
				this.先端_輪_金具3_表示 = value;
				this.先端_輪_金具左_表示 = value;
				this.先端_輪_金具右_表示 = value;
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
				this.節1_棘1_表示 = value;
				this.節1_棘2_表示 = value;
				this.節1_脈_表示 = value;
				this.節2_節_表示 = value;
				this.節2_棘1_表示 = value;
				this.節2_棘2_表示 = value;
				this.節2_脈_表示 = value;
				this.節3_節_表示 = value;
				this.節3_棘1_表示 = value;
				this.節3_棘2_表示 = value;
				this.節3_脈_表示 = value;
				this.節4_節_表示 = value;
				this.節4_棘1_表示 = value;
				this.節4_棘2_表示 = value;
				this.節4_脈_表示 = value;
				this.節5_節_表示 = value;
				this.節5_棘1_表示 = value;
				this.節5_棘2_表示 = value;
				this.節5_脈_表示 = value;
				this.節6_節_表示 = value;
				this.節6_棘1_表示 = value;
				this.節6_棘2_表示 = value;
				this.節6_脈_表示 = value;
				this.節7_節_表示 = value;
				this.節7_棘1_表示 = value;
				this.節7_棘2_表示 = value;
				this.節7_脈_表示 = value;
				this.節8_節_表示 = value;
				this.節8_棘1_表示 = value;
				this.節8_棘2_表示 = value;
				this.節8_脈_表示 = value;
				this.節9_節_表示 = value;
				this.節9_棘1_表示 = value;
				this.節9_棘2_表示 = value;
				this.節9_脈_表示 = value;
				this.節10_節_表示 = value;
				this.節10_棘1_表示 = value;
				this.節10_棘2_表示 = value;
				this.節10_脈_表示 = value;
				this.節11_節_表示 = value;
				this.節11_棘1_表示 = value;
				this.節11_棘2_表示 = value;
				this.節11_脈_表示 = value;
				this.節12_節_表示 = value;
				this.節12_棘1_表示 = value;
				this.節12_棘2_表示 = value;
				this.節12_脈_表示 = value;
				this.節13_節_表示 = value;
				this.節13_棘1_表示 = value;
				this.節13_棘2_表示 = value;
				this.節13_脈_表示 = value;
				this.輪1_革_表示 = value;
				this.輪1_金具1_表示 = value;
				this.輪1_金具2_表示 = value;
				this.輪1_金具3_表示 = value;
				this.輪1_金具左_表示 = value;
				this.輪1_金具右_表示 = value;
				this.節14_節_表示 = value;
				this.節14_棘1_表示 = value;
				this.節14_棘2_表示 = value;
				this.節14_脈_表示 = value;
				this.節15_節_表示 = value;
				this.節15_棘1_表示 = value;
				this.節15_棘2_表示 = value;
				this.節15_脈_表示 = value;
				this.節16_節_表示 = value;
				this.節16_棘1_表示 = value;
				this.節16_棘2_表示 = value;
				this.節16_脈_表示 = value;
				this.節17_節_表示 = value;
				this.節17_棘1_表示 = value;
				this.節17_棘2_表示 = value;
				this.節17_脈_表示 = value;
				this.節18_節_表示 = value;
				this.節18_棘1_表示 = value;
				this.節18_棘2_表示 = value;
				this.節18_脈_表示 = value;
				this.節19_節_表示 = value;
				this.節19_棘1_表示 = value;
				this.節19_棘2_表示 = value;
				this.節19_脈_表示 = value;
				this.節20_節_表示 = value;
				this.節20_棘1_表示 = value;
				this.節20_棘2_表示 = value;
				this.節20_脈_表示 = value;
				this.節21_節_表示 = value;
				this.節21_棘1_表示 = value;
				this.節21_棘2_表示 = value;
				this.節21_脈_表示 = value;
				this.節22_節_表示 = value;
				this.節22_棘1_表示 = value;
				this.節22_棘2_表示 = value;
				this.節22_脈_表示 = value;
				this.節23_節_表示 = value;
				this.節23_棘1_表示 = value;
				this.節23_棘2_表示 = value;
				this.節23_脈_表示 = value;
				this.節24_節_表示 = value;
				this.節24_棘1_表示 = value;
				this.節24_棘2_表示 = value;
				this.節24_脈_表示 = value;
				this.輪2_革_表示 = value;
				this.輪2_金具1_表示 = value;
				this.輪2_金具2_表示 = value;
				this.輪2_金具3_表示 = value;
				this.輪2_金具左_表示 = value;
				this.輪2_金具右_表示 = value;
				this.先端_下顎_顎_表示 = value;
				this.先端_下顎_口内_表示 = value;
				this.先端_下顎_棘12_表示 = value;
				this.先端_下顎_棘11_表示 = value;
				this.先端_下顎_棘10_表示 = value;
				this.先端_下顎_棘9_表示 = value;
				this.先端_下顎_棘8_表示 = value;
				this.先端_下顎_棘7_表示 = value;
				this.先端_下顎_脈1_表示 = value;
				this.先端_下顎_脈2_表示 = value;
				this.先端_下顎_脈3_表示 = value;
				this.先端_下顎_棘6_表示 = value;
				this.先端_下顎_棘5_表示 = value;
				this.先端_下顎_棘4_表示 = value;
				this.先端_下顎_棘3_表示 = value;
				this.先端_下顎_棘2_表示 = value;
				this.先端_下顎_棘1_表示 = value;
				this.先端_上顎_棘12_表示 = value;
				this.先端_上顎_棘11_表示 = value;
				this.先端_上顎_棘10_表示 = value;
				this.先端_上顎_棘9_表示 = value;
				this.先端_上顎_棘8_表示 = value;
				this.先端_上顎_棘7_表示 = value;
				this.先端_上顎_顎_表示 = value;
				this.先端_上顎_脈1_表示 = value;
				this.先端_上顎_脈2_表示 = value;
				this.先端_上顎_脈3_表示 = value;
				this.先端_上顎_脈4_表示 = value;
				this.先端_輪_革_表示 = value;
				this.先端_輪_金具1_表示 = value;
				this.先端_輪_金具2_表示 = value;
				this.先端_輪_金具3_表示 = value;
				this.先端_輪_金具左_表示 = value;
				this.先端_輪_金具右_表示 = value;
				this.鎖1.表示 = value;
				this.鎖2.表示 = value;
				this.鎖3.表示 = value;
				this.鎖4.表示 = value;
			}
		}

		public override void 描画0(Are Are)
		{
			Are.Draw(this.X0Y0_節1_節);
			Are.Draw(this.X0Y0_節1_棘1);
			Are.Draw(this.X0Y0_節1_棘2);
			Are.Draw(this.X0Y0_節1_脈);
			Are.Draw(this.X0Y0_節2_節);
			Are.Draw(this.X0Y0_節2_棘1);
			Are.Draw(this.X0Y0_節2_棘2);
			Are.Draw(this.X0Y0_節2_脈);
			Are.Draw(this.X0Y0_節3_節);
			Are.Draw(this.X0Y0_節3_棘1);
			Are.Draw(this.X0Y0_節3_棘2);
			Are.Draw(this.X0Y0_節3_脈);
			Are.Draw(this.X0Y0_節4_節);
			Are.Draw(this.X0Y0_節4_棘1);
			Are.Draw(this.X0Y0_節4_棘2);
			Are.Draw(this.X0Y0_節4_脈);
			Are.Draw(this.X0Y0_節5_節);
			Are.Draw(this.X0Y0_節5_棘1);
			Are.Draw(this.X0Y0_節5_棘2);
			Are.Draw(this.X0Y0_節5_脈);
			Are.Draw(this.X0Y0_節6_節);
			Are.Draw(this.X0Y0_節6_棘1);
			Are.Draw(this.X0Y0_節6_棘2);
			Are.Draw(this.X0Y0_節6_脈);
			Are.Draw(this.X0Y0_節7_節);
			Are.Draw(this.X0Y0_節7_棘1);
			Are.Draw(this.X0Y0_節7_棘2);
			Are.Draw(this.X0Y0_節7_脈);
			Are.Draw(this.X0Y0_節8_節);
			Are.Draw(this.X0Y0_節8_棘1);
			Are.Draw(this.X0Y0_節8_棘2);
			Are.Draw(this.X0Y0_節8_脈);
			Are.Draw(this.X0Y0_節9_節);
			Are.Draw(this.X0Y0_節9_棘1);
			Are.Draw(this.X0Y0_節9_棘2);
			Are.Draw(this.X0Y0_節9_脈);
			Are.Draw(this.X0Y0_節10_節);
			Are.Draw(this.X0Y0_節10_棘1);
			Are.Draw(this.X0Y0_節10_棘2);
			Are.Draw(this.X0Y0_節10_脈);
			Are.Draw(this.X0Y0_節11_節);
			Are.Draw(this.X0Y0_節11_棘1);
			Are.Draw(this.X0Y0_節11_棘2);
			Are.Draw(this.X0Y0_節11_脈);
			Are.Draw(this.X0Y0_節12_節);
			Are.Draw(this.X0Y0_節12_棘1);
			Are.Draw(this.X0Y0_節12_棘2);
			Are.Draw(this.X0Y0_節12_脈);
			Are.Draw(this.X0Y0_輪1_革);
			Are.Draw(this.X0Y0_輪1_金具1);
			Are.Draw(this.X0Y0_輪1_金具2);
			Are.Draw(this.X0Y0_輪1_金具3);
			Are.Draw(this.X0Y0_輪1_金具左);
			Are.Draw(this.X0Y0_輪1_金具右);
			this.鎖1.描画0(Are);
			this.鎖2.描画0(Are);
			Are.Draw(this.X0Y0_節13_節);
			Are.Draw(this.X0Y0_節13_棘1);
			Are.Draw(this.X0Y0_節13_棘2);
			Are.Draw(this.X0Y0_節13_脈);
			Are.Draw(this.X0Y0_節14_節);
			Are.Draw(this.X0Y0_節14_棘1);
			Are.Draw(this.X0Y0_節14_棘2);
			Are.Draw(this.X0Y0_節14_脈);
			Are.Draw(this.X0Y0_節15_節);
			Are.Draw(this.X0Y0_節15_棘1);
			Are.Draw(this.X0Y0_節15_棘2);
			Are.Draw(this.X0Y0_節15_脈);
			Are.Draw(this.X0Y0_節16_節);
			Are.Draw(this.X0Y0_節16_棘1);
			Are.Draw(this.X0Y0_節16_棘2);
			Are.Draw(this.X0Y0_節16_脈);
			Are.Draw(this.X0Y0_節17_節);
			Are.Draw(this.X0Y0_節17_棘1);
			Are.Draw(this.X0Y0_節17_棘2);
			Are.Draw(this.X0Y0_節17_脈);
			Are.Draw(this.X0Y0_節18_節);
			Are.Draw(this.X0Y0_節18_棘1);
			Are.Draw(this.X0Y0_節18_棘2);
			Are.Draw(this.X0Y0_節18_脈);
			Are.Draw(this.X0Y0_節19_節);
			Are.Draw(this.X0Y0_節19_棘1);
			Are.Draw(this.X0Y0_節19_棘2);
			Are.Draw(this.X0Y0_節19_脈);
			Are.Draw(this.X0Y0_節20_節);
			Are.Draw(this.X0Y0_節20_棘1);
			Are.Draw(this.X0Y0_節20_棘2);
			Are.Draw(this.X0Y0_節20_脈);
			Are.Draw(this.X0Y0_節21_節);
			Are.Draw(this.X0Y0_節21_棘1);
			Are.Draw(this.X0Y0_節21_棘2);
			Are.Draw(this.X0Y0_節21_脈);
			Are.Draw(this.X0Y0_節22_節);
			Are.Draw(this.X0Y0_節22_棘1);
			Are.Draw(this.X0Y0_節22_棘2);
			Are.Draw(this.X0Y0_節22_脈);
			Are.Draw(this.X0Y0_輪2_革);
			Are.Draw(this.X0Y0_輪2_金具1);
			Are.Draw(this.X0Y0_輪2_金具2);
			Are.Draw(this.X0Y0_輪2_金具3);
			Are.Draw(this.X0Y0_輪2_金具左);
			Are.Draw(this.X0Y0_輪2_金具右);
			this.鎖3.描画0(Are);
			this.鎖4.描画0(Are);
			Are.Draw(this.X0Y0_節23_節);
			Are.Draw(this.X0Y0_節23_棘1);
			Are.Draw(this.X0Y0_節23_棘2);
			Are.Draw(this.X0Y0_節23_脈);
			Are.Draw(this.X0Y0_節24_節);
			Are.Draw(this.X0Y0_節24_棘1);
			Are.Draw(this.X0Y0_節24_棘2);
			Are.Draw(this.X0Y0_節24_脈);
			Are.Draw(this.X0Y0_先端_下顎_顎);
			Are.Draw(this.X0Y0_先端_下顎_口内);
			Are.Draw(this.X0Y0_先端_下顎_棘12);
			Are.Draw(this.X0Y0_先端_下顎_棘11);
			Are.Draw(this.X0Y0_先端_下顎_棘10);
			Are.Draw(this.X0Y0_先端_下顎_棘9);
			Are.Draw(this.X0Y0_先端_下顎_棘8);
			Are.Draw(this.X0Y0_先端_下顎_棘7);
			Are.Draw(this.X0Y0_先端_下顎_脈1);
			Are.Draw(this.X0Y0_先端_下顎_脈2);
			Are.Draw(this.X0Y0_先端_下顎_脈3);
			Are.Draw(this.X0Y0_先端_下顎_棘6);
			Are.Draw(this.X0Y0_先端_下顎_棘5);
			Are.Draw(this.X0Y0_先端_下顎_棘4);
			Are.Draw(this.X0Y0_先端_下顎_棘3);
			Are.Draw(this.X0Y0_先端_下顎_棘2);
			Are.Draw(this.X0Y0_先端_下顎_棘1);
			Are.Draw(this.X0Y0_先端_上顎_棘12);
			Are.Draw(this.X0Y0_先端_上顎_棘11);
			Are.Draw(this.X0Y0_先端_上顎_棘10);
			Are.Draw(this.X0Y0_先端_上顎_棘9);
			Are.Draw(this.X0Y0_先端_上顎_棘8);
			Are.Draw(this.X0Y0_先端_上顎_棘7);
			Are.Draw(this.X0Y0_先端_上顎_顎);
			Are.Draw(this.X0Y0_先端_上顎_脈1);
			Are.Draw(this.X0Y0_先端_上顎_脈2);
			Are.Draw(this.X0Y0_先端_上顎_脈3);
			Are.Draw(this.X0Y0_先端_上顎_脈4);
			Are.Draw(this.X0Y0_先端_輪_革);
			Are.Draw(this.X0Y0_先端_輪_金具1);
			Are.Draw(this.X0Y0_先端_輪_金具2);
			Are.Draw(this.X0Y0_先端_輪_金具3);
			Are.Draw(this.X0Y0_先端_輪_金具左);
			Are.Draw(this.X0Y0_先端_輪_金具右);
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
				this.節1_棘1CD.不透明度 = value;
				this.節1_棘2CD.不透明度 = value;
				this.節1_脈CD.不透明度 = value;
				this.節2_節CD.不透明度 = value;
				this.節2_棘1CD.不透明度 = value;
				this.節2_棘2CD.不透明度 = value;
				this.節2_脈CD.不透明度 = value;
				this.節3_節CD.不透明度 = value;
				this.節3_棘1CD.不透明度 = value;
				this.節3_棘2CD.不透明度 = value;
				this.節3_脈CD.不透明度 = value;
				this.節4_節CD.不透明度 = value;
				this.節4_棘1CD.不透明度 = value;
				this.節4_棘2CD.不透明度 = value;
				this.節4_脈CD.不透明度 = value;
				this.節5_節CD.不透明度 = value;
				this.節5_棘1CD.不透明度 = value;
				this.節5_棘2CD.不透明度 = value;
				this.節5_脈CD.不透明度 = value;
				this.節6_節CD.不透明度 = value;
				this.節6_棘1CD.不透明度 = value;
				this.節6_棘2CD.不透明度 = value;
				this.節6_脈CD.不透明度 = value;
				this.節7_節CD.不透明度 = value;
				this.節7_棘1CD.不透明度 = value;
				this.節7_棘2CD.不透明度 = value;
				this.節7_脈CD.不透明度 = value;
				this.節8_節CD.不透明度 = value;
				this.節8_棘1CD.不透明度 = value;
				this.節8_棘2CD.不透明度 = value;
				this.節8_脈CD.不透明度 = value;
				this.節9_節CD.不透明度 = value;
				this.節9_棘1CD.不透明度 = value;
				this.節9_棘2CD.不透明度 = value;
				this.節9_脈CD.不透明度 = value;
				this.節10_節CD.不透明度 = value;
				this.節10_棘1CD.不透明度 = value;
				this.節10_棘2CD.不透明度 = value;
				this.節10_脈CD.不透明度 = value;
				this.節11_節CD.不透明度 = value;
				this.節11_棘1CD.不透明度 = value;
				this.節11_棘2CD.不透明度 = value;
				this.節11_脈CD.不透明度 = value;
				this.節12_節CD.不透明度 = value;
				this.節12_棘1CD.不透明度 = value;
				this.節12_棘2CD.不透明度 = value;
				this.節12_脈CD.不透明度 = value;
				this.節13_節CD.不透明度 = value;
				this.節13_棘1CD.不透明度 = value;
				this.節13_棘2CD.不透明度 = value;
				this.節13_脈CD.不透明度 = value;
				this.節14_節CD.不透明度 = value;
				this.節14_棘1CD.不透明度 = value;
				this.節14_棘2CD.不透明度 = value;
				this.節14_脈CD.不透明度 = value;
				this.節15_節CD.不透明度 = value;
				this.節15_棘1CD.不透明度 = value;
				this.節15_棘2CD.不透明度 = value;
				this.節15_脈CD.不透明度 = value;
				this.節16_節CD.不透明度 = value;
				this.節16_棘1CD.不透明度 = value;
				this.節16_棘2CD.不透明度 = value;
				this.節16_脈CD.不透明度 = value;
				this.節17_節CD.不透明度 = value;
				this.節17_棘1CD.不透明度 = value;
				this.節17_棘2CD.不透明度 = value;
				this.節17_脈CD.不透明度 = value;
				this.節18_節CD.不透明度 = value;
				this.節18_棘1CD.不透明度 = value;
				this.節18_棘2CD.不透明度 = value;
				this.節18_脈CD.不透明度 = value;
				this.節19_節CD.不透明度 = value;
				this.節19_棘1CD.不透明度 = value;
				this.節19_棘2CD.不透明度 = value;
				this.節19_脈CD.不透明度 = value;
				this.節20_節CD.不透明度 = value;
				this.節20_棘1CD.不透明度 = value;
				this.節20_棘2CD.不透明度 = value;
				this.節20_脈CD.不透明度 = value;
				this.節21_節CD.不透明度 = value;
				this.節21_棘1CD.不透明度 = value;
				this.節21_棘2CD.不透明度 = value;
				this.節21_脈CD.不透明度 = value;
				this.節22_節CD.不透明度 = value;
				this.節22_棘1CD.不透明度 = value;
				this.節22_棘2CD.不透明度 = value;
				this.節22_脈CD.不透明度 = value;
				this.節23_節CD.不透明度 = value;
				this.節23_棘1CD.不透明度 = value;
				this.節23_棘2CD.不透明度 = value;
				this.節23_脈CD.不透明度 = value;
				this.節24_節CD.不透明度 = value;
				this.節24_棘1CD.不透明度 = value;
				this.節24_棘2CD.不透明度 = value;
				this.節24_脈CD.不透明度 = value;
				this.先端_下顎_顎CD.不透明度 = value;
				this.先端_下顎_口内CD.不透明度 = value;
				this.先端_下顎_棘12CD.不透明度 = value;
				this.先端_下顎_棘11CD.不透明度 = value;
				this.先端_下顎_棘10CD.不透明度 = value;
				this.先端_下顎_棘9CD.不透明度 = value;
				this.先端_下顎_棘8CD.不透明度 = value;
				this.先端_下顎_棘7CD.不透明度 = value;
				this.先端_下顎_脈1CD.不透明度 = value;
				this.先端_下顎_脈2CD.不透明度 = value;
				this.先端_下顎_脈3CD.不透明度 = value;
				this.先端_下顎_棘6CD.不透明度 = value;
				this.先端_下顎_棘5CD.不透明度 = value;
				this.先端_下顎_棘4CD.不透明度 = value;
				this.先端_下顎_棘3CD.不透明度 = value;
				this.先端_下顎_棘2CD.不透明度 = value;
				this.先端_下顎_棘1CD.不透明度 = value;
				this.先端_上顎_棘12CD.不透明度 = value;
				this.先端_上顎_棘11CD.不透明度 = value;
				this.先端_上顎_棘10CD.不透明度 = value;
				this.先端_上顎_棘9CD.不透明度 = value;
				this.先端_上顎_棘8CD.不透明度 = value;
				this.先端_上顎_棘7CD.不透明度 = value;
				this.先端_上顎_顎CD.不透明度 = value;
				this.先端_上顎_脈1CD.不透明度 = value;
				this.先端_上顎_脈2CD.不透明度 = value;
				this.先端_上顎_脈3CD.不透明度 = value;
				this.先端_上顎_脈4CD.不透明度 = value;
				this.先端_輪_革CD.不透明度 = value;
				this.先端_輪_金具1CD.不透明度 = value;
				this.先端_輪_金具2CD.不透明度 = value;
				this.先端_輪_金具3CD.不透明度 = value;
				this.先端_輪_金具左CD.不透明度 = value;
				this.先端_輪_金具右CD.不透明度 = value;
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
			double num = this.右 ? -1.0 : 1.0;
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
			this.X0Y0_先端_上顎_顎.AngleBase = num * (double)OthN.XS.NextM(15);
			this.X0Y0_先端_下顎_顎.AngleBase = num * -this.X0Y0_先端_上顎_顎.AngleBase;
			this.本体.JoinPAall();
		}

		public void Set角度(触手_蔦 蔦)
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_節1_節.AngleBase = num * 蔦.X0Y0_節1_節.AngleBase;
			this.X0Y0_節2_節.AngleBase = num * 蔦.X0Y0_節2_節.AngleBase;
			this.X0Y0_節3_節.AngleBase = num * 蔦.X0Y0_節3_節.AngleBase;
			this.X0Y0_節4_節.AngleBase = num * 蔦.X0Y0_節4_節.AngleBase;
			this.X0Y0_節5_節.AngleBase = num * 蔦.X0Y0_節5_節.AngleBase;
			this.X0Y0_節6_節.AngleBase = num * 蔦.X0Y0_節6_節.AngleBase;
			this.X0Y0_節7_節.AngleBase = num * 蔦.X0Y0_節7_節.AngleBase;
			this.X0Y0_節8_節.AngleBase = num * 蔦.X0Y0_節8_節.AngleBase;
			this.X0Y0_節9_節.AngleBase = num * 蔦.X0Y0_節9_節.AngleBase;
			this.X0Y0_節10_節.AngleBase = num * 蔦.X0Y0_節10_節.AngleBase;
			this.X0Y0_節11_節.AngleBase = num * 蔦.X0Y0_節11_節.AngleBase;
			this.X0Y0_節12_節.AngleBase = num * 蔦.X0Y0_節12_節.AngleBase;
			this.X0Y0_節13_節.AngleBase = num * 蔦.X0Y0_節13_節.AngleBase;
			this.X0Y0_節14_節.AngleBase = num * 蔦.X0Y0_節14_節.AngleBase;
			this.X0Y0_節15_節.AngleBase = num * 蔦.X0Y0_節15_節.AngleBase;
			this.X0Y0_節16_節.AngleBase = num * 蔦.X0Y0_節16_節.AngleBase;
			this.X0Y0_節17_節.AngleBase = num * 蔦.X0Y0_節17_節.AngleBase;
			this.X0Y0_節18_節.AngleBase = num * 蔦.X0Y0_節18_節.AngleBase;
			this.X0Y0_節19_節.AngleBase = num * 蔦.X0Y0_節19_節.AngleBase;
			this.X0Y0_節20_節.AngleBase = num * 蔦.X0Y0_節20_節.AngleBase;
			this.X0Y0_節21_節.AngleBase = num * 蔦.X0Y0_節21_節.AngleBase;
			this.X0Y0_節22_節.AngleBase = num * 蔦.X0Y0_節22_節.AngleBase;
			this.X0Y0_節23_節.AngleBase = num * 蔦.X0Y0_節23_節.AngleBase;
			this.X0Y0_節24_節.AngleBase = num * 蔦.X0Y0_節24_節.AngleBase;
			this.X0Y0_先端_上顎_顎.AngleBase = num * 蔦.X0Y0_先端_上顎_顎.AngleBase;
			this.X0Y0_先端_下顎_顎.AngleBase = num * 蔦.X0Y0_先端_下顎_顎.AngleBase;
			this.本体.JoinPAall();
		}

		public override bool Is革(Par p)
		{
			return p == this.X0Y0_輪1_革 || p == this.X0Y0_輪1_金具1 || p == this.X0Y0_輪1_金具2 || p == this.X0Y0_輪1_金具3 || p == this.X0Y0_輪1_金具左 || p == this.X0Y0_輪1_金具右 || p == this.X0Y0_輪2_革 || p == this.X0Y0_輪2_金具1 || p == this.X0Y0_輪2_金具2 || p == this.X0Y0_輪2_金具3 || p == this.X0Y0_輪2_金具左 || p == this.X0Y0_輪2_金具右 || p == this.X0Y0_先端_輪_革 || p == this.X0Y0_先端_輪_金具1 || p == this.X0Y0_先端_輪_金具2 || p == this.X0Y0_先端_輪_金具3 || p == this.X0Y0_先端_輪_金具左 || p == this.X0Y0_先端_輪_金具右;
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
			yield break;
		}

		public JointS 節1_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節1_節, 1);
			}
		}

		public JointS 節2_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節2_節, 1);
			}
		}

		public JointS 節3_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節3_節, 1);
			}
		}

		public JointS 節4_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節4_節, 1);
			}
		}

		public JointS 節5_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節5_節, 1);
			}
		}

		public JointS 節6_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節6_節, 1);
			}
		}

		public JointS 節7_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節7_節, 1);
			}
		}

		public JointS 節8_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節8_節, 1);
			}
		}

		public JointS 節9_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節9_節, 1);
			}
		}

		public JointS 節10_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節10_節, 1);
			}
		}

		public JointS 節11_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節11_節, 1);
			}
		}

		public JointS 節12_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節12_節, 1);
			}
		}

		public JointS 節13_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節13_節, 1);
			}
		}

		public JointS 節14_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節14_節, 1);
			}
		}

		public JointS 節15_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節15_節, 1);
			}
		}

		public JointS 節16_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節16_節, 1);
			}
		}

		public JointS 節17_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節17_節, 1);
			}
		}

		public JointS 節18_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節18_節, 1);
			}
		}

		public JointS 節19_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節19_節, 1);
			}
		}

		public JointS 節20_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節20_節, 1);
			}
		}

		public JointS 節21_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節21_節, 1);
			}
		}

		public JointS 節22_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節22_節, 1);
			}
		}

		public JointS 節23_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節23_節, 1);
			}
		}

		public JointS 節24_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節24_節, 1);
			}
		}

		public JointS 先端_接続点
		{
			get
			{
				return new JointS(this.本体, this.X0Y0_節24_節, 0);
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
			this.Pars.GetMiY_MaY(out this.mm);
			this.X0Y0_節1_節CP.Update(this.mm);
			this.X0Y0_節1_棘1CP.Update();
			this.X0Y0_節1_棘2CP.Update();
			this.X0Y0_節1_脈CP.Update();
			this.X0Y0_節2_節CP.Update(this.mm);
			this.X0Y0_節2_棘1CP.Update();
			this.X0Y0_節2_棘2CP.Update();
			this.X0Y0_節2_脈CP.Update();
			this.X0Y0_節3_節CP.Update(this.mm);
			this.X0Y0_節3_棘1CP.Update();
			this.X0Y0_節3_棘2CP.Update();
			this.X0Y0_節3_脈CP.Update();
			this.X0Y0_節4_節CP.Update(this.mm);
			this.X0Y0_節4_棘1CP.Update();
			this.X0Y0_節4_棘2CP.Update();
			this.X0Y0_節4_脈CP.Update();
			this.X0Y0_節5_節CP.Update(this.mm);
			this.X0Y0_節5_棘1CP.Update();
			this.X0Y0_節5_棘2CP.Update();
			this.X0Y0_節5_脈CP.Update();
			this.X0Y0_節6_節CP.Update(this.mm);
			this.X0Y0_節6_棘1CP.Update();
			this.X0Y0_節6_棘2CP.Update();
			this.X0Y0_節6_脈CP.Update();
			this.X0Y0_節7_節CP.Update(this.mm);
			this.X0Y0_節7_棘1CP.Update();
			this.X0Y0_節7_棘2CP.Update();
			this.X0Y0_節7_脈CP.Update();
			this.X0Y0_節8_節CP.Update(this.mm);
			this.X0Y0_節8_棘1CP.Update();
			this.X0Y0_節8_棘2CP.Update();
			this.X0Y0_節8_脈CP.Update();
			this.X0Y0_節9_節CP.Update(this.mm);
			this.X0Y0_節9_棘1CP.Update();
			this.X0Y0_節9_棘2CP.Update();
			this.X0Y0_節9_脈CP.Update();
			this.X0Y0_節10_節CP.Update(this.mm);
			this.X0Y0_節10_棘1CP.Update();
			this.X0Y0_節10_棘2CP.Update();
			this.X0Y0_節10_脈CP.Update();
			this.X0Y0_節11_節CP.Update(this.mm);
			this.X0Y0_節11_棘1CP.Update();
			this.X0Y0_節11_棘2CP.Update();
			this.X0Y0_節11_脈CP.Update();
			this.X0Y0_節12_節CP.Update(this.mm);
			this.X0Y0_節12_棘1CP.Update();
			this.X0Y0_節12_棘2CP.Update();
			this.X0Y0_節12_脈CP.Update();
			this.X0Y0_節13_節CP.Update(this.mm);
			this.X0Y0_節13_棘1CP.Update();
			this.X0Y0_節13_棘2CP.Update();
			this.X0Y0_節13_脈CP.Update();
			this.X0Y0_輪1_革CP.Update();
			this.X0Y0_輪1_金具1CP.Update();
			this.X0Y0_輪1_金具2CP.Update();
			this.X0Y0_輪1_金具3CP.Update();
			this.X0Y0_輪1_金具左CP.Update();
			this.X0Y0_輪1_金具右CP.Update();
			this.X0Y0_節14_節CP.Update(this.mm);
			this.X0Y0_節14_棘1CP.Update();
			this.X0Y0_節14_棘2CP.Update();
			this.X0Y0_節14_脈CP.Update();
			this.X0Y0_節15_節CP.Update(this.mm);
			this.X0Y0_節15_棘1CP.Update();
			this.X0Y0_節15_棘2CP.Update();
			this.X0Y0_節15_脈CP.Update();
			this.X0Y0_節16_節CP.Update(this.mm);
			this.X0Y0_節16_棘1CP.Update();
			this.X0Y0_節16_棘2CP.Update();
			this.X0Y0_節16_脈CP.Update();
			this.X0Y0_節17_節CP.Update(this.mm);
			this.X0Y0_節17_棘1CP.Update();
			this.X0Y0_節17_棘2CP.Update();
			this.X0Y0_節17_脈CP.Update();
			this.X0Y0_節18_節CP.Update(this.mm);
			this.X0Y0_節18_棘1CP.Update();
			this.X0Y0_節18_棘2CP.Update();
			this.X0Y0_節18_脈CP.Update();
			this.X0Y0_節19_節CP.Update(this.mm);
			this.X0Y0_節19_棘1CP.Update();
			this.X0Y0_節19_棘2CP.Update();
			this.X0Y0_節19_脈CP.Update();
			this.X0Y0_節20_節CP.Update(this.mm);
			this.X0Y0_節20_棘1CP.Update();
			this.X0Y0_節20_棘2CP.Update();
			this.X0Y0_節20_脈CP.Update();
			this.X0Y0_節21_節CP.Update(this.mm);
			this.X0Y0_節21_棘1CP.Update();
			this.X0Y0_節21_棘2CP.Update();
			this.X0Y0_節21_脈CP.Update();
			this.X0Y0_節22_節CP.Update(this.mm);
			this.X0Y0_節22_棘1CP.Update();
			this.X0Y0_節22_棘2CP.Update();
			this.X0Y0_節22_脈CP.Update();
			this.X0Y0_節23_節CP.Update(this.mm);
			this.X0Y0_節23_棘1CP.Update();
			this.X0Y0_節23_棘2CP.Update();
			this.X0Y0_節23_脈CP.Update();
			this.X0Y0_節24_節CP.Update(this.mm);
			this.X0Y0_節24_棘1CP.Update();
			this.X0Y0_節24_棘2CP.Update();
			this.X0Y0_節24_脈CP.Update();
			this.X0Y0_輪2_革CP.Update();
			this.X0Y0_輪2_金具1CP.Update();
			this.X0Y0_輪2_金具2CP.Update();
			this.X0Y0_輪2_金具3CP.Update();
			this.X0Y0_輪2_金具左CP.Update();
			this.X0Y0_輪2_金具右CP.Update();
			this.X0Y0_先端_下顎_顎CP.Update(this.mm);
			this.X0Y0_先端_下顎_口内CP.Update();
			this.X0Y0_先端_下顎_棘12CP.Update();
			this.X0Y0_先端_下顎_棘11CP.Update();
			this.X0Y0_先端_下顎_棘10CP.Update();
			this.X0Y0_先端_下顎_棘9CP.Update();
			this.X0Y0_先端_下顎_棘8CP.Update();
			this.X0Y0_先端_下顎_棘7CP.Update();
			this.X0Y0_先端_下顎_脈1CP.Update();
			this.X0Y0_先端_下顎_脈2CP.Update();
			this.X0Y0_先端_下顎_脈3CP.Update();
			this.X0Y0_先端_下顎_棘6CP.Update();
			this.X0Y0_先端_下顎_棘5CP.Update();
			this.X0Y0_先端_下顎_棘4CP.Update();
			this.X0Y0_先端_下顎_棘3CP.Update();
			this.X0Y0_先端_下顎_棘2CP.Update();
			this.X0Y0_先端_下顎_棘1CP.Update();
			this.X0Y0_先端_上顎_棘12CP.Update();
			this.X0Y0_先端_上顎_棘11CP.Update();
			this.X0Y0_先端_上顎_棘10CP.Update();
			this.X0Y0_先端_上顎_棘9CP.Update();
			this.X0Y0_先端_上顎_棘8CP.Update();
			this.X0Y0_先端_上顎_棘7CP.Update();
			this.X0Y0_先端_上顎_顎CP.Update(this.mm);
			this.X0Y0_先端_上顎_脈1CP.Update();
			this.X0Y0_先端_上顎_脈2CP.Update();
			this.X0Y0_先端_上顎_脈3CP.Update();
			this.X0Y0_先端_上顎_脈4CP.Update();
			this.X0Y0_先端_輪_革CP.Update();
			this.X0Y0_先端_輪_金具1CP.Update();
			this.X0Y0_先端_輪_金具2CP.Update();
			this.X0Y0_先端_輪_金具3CP.Update();
			this.X0Y0_先端_輪_金具左CP.Update();
			this.X0Y0_先端_輪_金具右CP.Update();
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
			this.節1_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節1_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節1_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節1_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節2_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節2_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節2_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節2_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節3_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節3_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節3_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節3_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節4_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節4_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節4_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節4_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節5_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節5_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節5_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節5_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節6_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節6_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節6_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節6_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節7_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節7_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節7_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節7_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節8_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節8_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節8_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節8_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節9_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節9_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節9_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節9_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節10_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節10_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節10_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節10_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節11_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節11_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節11_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節11_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節12_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節12_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節12_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節12_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節13_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節13_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節13_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節13_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節14_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節14_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節14_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節14_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節15_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節15_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節15_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節15_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節16_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節16_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節16_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節16_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節17_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節17_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節17_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節17_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節18_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節18_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節18_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節18_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節19_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節19_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節19_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節19_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節20_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節20_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節20_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節20_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節21_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節21_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節21_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節21_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節22_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節22_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節22_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節22_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節23_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節23_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節23_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節23_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節24_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節24_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節24_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節24_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_顎CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.先端_下顎_口内CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.先端_下顎_棘12CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘11CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘10CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘9CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘8CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘7CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_脈1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_脈2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_脈3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘6CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘5CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘4CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_棘12CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_棘11CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_棘10CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_棘9CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_棘8CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_棘7CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_顎CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.先端_上顎_脈1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_脈2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_脈3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_脈4CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_輪_革CD = new ColorD();
			this.先端_輪_金具1CD = new ColorD();
			this.先端_輪_金具2CD = new ColorD();
			this.先端_輪_金具3CD = new ColorD();
			this.先端_輪_金具左CD = new ColorD();
			this.先端_輪_金具右CD = new ColorD();
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
			this.節1_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節1_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節1_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節1_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節2_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節2_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節2_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節2_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節3_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節3_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節3_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節3_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節4_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節4_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節4_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節4_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節5_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節5_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節5_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節5_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節6_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節6_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節6_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節6_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節7_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節7_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節7_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節7_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節8_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節8_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節8_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節8_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節9_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節9_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節9_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節9_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節10_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節10_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節10_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節10_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節11_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節11_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節11_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節11_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節12_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節12_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節12_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節12_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節13_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節13_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節13_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節13_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節14_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節14_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節14_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節14_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節15_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節15_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節15_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節15_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節16_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節16_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節16_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節16_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節17_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節17_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節17_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節17_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節18_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節18_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節18_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節18_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節19_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節19_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節19_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節19_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節20_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節20_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節20_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節20_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節21_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節21_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節21_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節21_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節22_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節22_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節22_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節22_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節23_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節23_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節23_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節23_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節24_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節24_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節24_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節24_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_顎CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.先端_下顎_口内CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.先端_下顎_棘12CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘11CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘10CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘9CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘8CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘7CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_脈1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_脈2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_脈3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘6CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘5CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘4CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_棘12CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_棘11CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_棘10CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_棘9CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_棘8CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_棘7CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_顎CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.先端_上顎_脈1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_脈2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_脈3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_脈4CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_輪_革CD = new ColorD();
			this.先端_輪_金具1CD = new ColorD();
			this.先端_輪_金具2CD = new ColorD();
			this.先端_輪_金具3CD = new ColorD();
			this.先端_輪_金具左CD = new ColorD();
			this.先端_輪_金具右CD = new ColorD();
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
			this.節1_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節1_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節1_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節1_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節2_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節2_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節2_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節2_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節3_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節3_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節3_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節3_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節4_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節4_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節4_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節4_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節5_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節5_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節5_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節5_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節6_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節6_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節6_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節6_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節7_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節7_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節7_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節7_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節8_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節8_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節8_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節8_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節9_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節9_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節9_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節9_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節10_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節10_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節10_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節10_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節11_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節11_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節11_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節11_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節12_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節12_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節12_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節12_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節13_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節13_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節13_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節13_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節14_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節14_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節14_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節14_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節15_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節15_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節15_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節15_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節16_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節16_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節16_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節16_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節17_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節17_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節17_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節17_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節18_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節18_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節18_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節18_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節19_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節19_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節19_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節19_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節20_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節20_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節20_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節20_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節21_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節21_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節21_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節21_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節22_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節22_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節22_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節22_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節23_節CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.節23_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節23_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節23_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節24_節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.節24_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節24_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.節24_脈CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_顎CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.先端_下顎_口内CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.先端_下顎_棘12CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘11CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘10CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘9CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘8CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘7CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_脈1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_脈2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_脈3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘6CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘5CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘4CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_下顎_棘1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_棘12CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_棘11CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_棘10CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_棘9CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_棘8CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_棘7CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_顎CD = new ColorD(ref Col.Black, ref 体配色.植0O);
			this.先端_上顎_脈1CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_脈2CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_脈3CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_上顎_脈4CD = new ColorD(ref Col.Black, ref 体配色.植1O);
			this.先端_輪_革CD = new ColorD();
			this.先端_輪_金具1CD = new ColorD();
			this.先端_輪_金具2CD = new ColorD();
			this.先端_輪_金具3CD = new ColorD();
			this.先端_輪_金具左CD = new ColorD();
			this.先端_輪_金具右CD = new ColorD();
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

		public void 輪3配色(拘束具色 配色)
		{
			this.先端_輪_革CD.色 = 配色.革部色;
			this.先端_輪_金具1CD.色 = 配色.金具色;
			this.先端_輪_金具2CD.色 = this.先端_輪_金具1CD.色;
			this.先端_輪_金具3CD.色 = this.先端_輪_金具1CD.色;
			this.先端_輪_金具左CD.色 = this.先端_輪_金具1CD.色;
			this.先端_輪_金具右CD.色 = this.先端_輪_金具1CD.色;
		}

		public void 鎖配色(鎖色 配色)
		{
			this.鎖1.配色鎖(配色);
			this.鎖2.配色鎖(配色);
			this.鎖3.配色鎖(配色);
			this.鎖4.配色鎖(配色);
		}

		public Par X0Y0_節1_節;

		public Par X0Y0_節1_棘1;

		public Par X0Y0_節1_棘2;

		public Par X0Y0_節1_脈;

		public Par X0Y0_節2_節;

		public Par X0Y0_節2_棘1;

		public Par X0Y0_節2_棘2;

		public Par X0Y0_節2_脈;

		public Par X0Y0_節3_節;

		public Par X0Y0_節3_棘1;

		public Par X0Y0_節3_棘2;

		public Par X0Y0_節3_脈;

		public Par X0Y0_節4_節;

		public Par X0Y0_節4_棘1;

		public Par X0Y0_節4_棘2;

		public Par X0Y0_節4_脈;

		public Par X0Y0_節5_節;

		public Par X0Y0_節5_棘1;

		public Par X0Y0_節5_棘2;

		public Par X0Y0_節5_脈;

		public Par X0Y0_節6_節;

		public Par X0Y0_節6_棘1;

		public Par X0Y0_節6_棘2;

		public Par X0Y0_節6_脈;

		public Par X0Y0_節7_節;

		public Par X0Y0_節7_棘1;

		public Par X0Y0_節7_棘2;

		public Par X0Y0_節7_脈;

		public Par X0Y0_節8_節;

		public Par X0Y0_節8_棘1;

		public Par X0Y0_節8_棘2;

		public Par X0Y0_節8_脈;

		public Par X0Y0_節9_節;

		public Par X0Y0_節9_棘1;

		public Par X0Y0_節9_棘2;

		public Par X0Y0_節9_脈;

		public Par X0Y0_節10_節;

		public Par X0Y0_節10_棘1;

		public Par X0Y0_節10_棘2;

		public Par X0Y0_節10_脈;

		public Par X0Y0_節11_節;

		public Par X0Y0_節11_棘1;

		public Par X0Y0_節11_棘2;

		public Par X0Y0_節11_脈;

		public Par X0Y0_節12_節;

		public Par X0Y0_節12_棘1;

		public Par X0Y0_節12_棘2;

		public Par X0Y0_節12_脈;

		public Par X0Y0_輪1_革;

		public Par X0Y0_輪1_金具1;

		public Par X0Y0_輪1_金具2;

		public Par X0Y0_輪1_金具3;

		public Par X0Y0_輪1_金具左;

		public Par X0Y0_輪1_金具右;

		public Par X0Y0_節13_節;

		public Par X0Y0_節13_棘1;

		public Par X0Y0_節13_棘2;

		public Par X0Y0_節13_脈;

		public Par X0Y0_節14_節;

		public Par X0Y0_節14_棘1;

		public Par X0Y0_節14_棘2;

		public Par X0Y0_節14_脈;

		public Par X0Y0_節15_節;

		public Par X0Y0_節15_棘1;

		public Par X0Y0_節15_棘2;

		public Par X0Y0_節15_脈;

		public Par X0Y0_節16_節;

		public Par X0Y0_節16_棘1;

		public Par X0Y0_節16_棘2;

		public Par X0Y0_節16_脈;

		public Par X0Y0_節17_節;

		public Par X0Y0_節17_棘1;

		public Par X0Y0_節17_棘2;

		public Par X0Y0_節17_脈;

		public Par X0Y0_節18_節;

		public Par X0Y0_節18_棘1;

		public Par X0Y0_節18_棘2;

		public Par X0Y0_節18_脈;

		public Par X0Y0_節19_節;

		public Par X0Y0_節19_棘1;

		public Par X0Y0_節19_棘2;

		public Par X0Y0_節19_脈;

		public Par X0Y0_節20_節;

		public Par X0Y0_節20_棘1;

		public Par X0Y0_節20_棘2;

		public Par X0Y0_節20_脈;

		public Par X0Y0_節21_節;

		public Par X0Y0_節21_棘1;

		public Par X0Y0_節21_棘2;

		public Par X0Y0_節21_脈;

		public Par X0Y0_節22_節;

		public Par X0Y0_節22_棘1;

		public Par X0Y0_節22_棘2;

		public Par X0Y0_節22_脈;

		public Par X0Y0_輪2_革;

		public Par X0Y0_輪2_金具1;

		public Par X0Y0_輪2_金具2;

		public Par X0Y0_輪2_金具3;

		public Par X0Y0_輪2_金具左;

		public Par X0Y0_輪2_金具右;

		public Par X0Y0_節23_節;

		public Par X0Y0_節23_棘1;

		public Par X0Y0_節23_棘2;

		public Par X0Y0_節23_脈;

		public Par X0Y0_節24_節;

		public Par X0Y0_節24_棘1;

		public Par X0Y0_節24_棘2;

		public Par X0Y0_節24_脈;

		public Par X0Y0_先端_下顎_顎;

		public Par X0Y0_先端_下顎_口内;

		public Par X0Y0_先端_下顎_棘12;

		public Par X0Y0_先端_下顎_棘11;

		public Par X0Y0_先端_下顎_棘10;

		public Par X0Y0_先端_下顎_棘9;

		public Par X0Y0_先端_下顎_棘8;

		public Par X0Y0_先端_下顎_棘7;

		public Par X0Y0_先端_下顎_脈1;

		public Par X0Y0_先端_下顎_脈2;

		public Par X0Y0_先端_下顎_脈3;

		public Par X0Y0_先端_下顎_棘6;

		public Par X0Y0_先端_下顎_棘5;

		public Par X0Y0_先端_下顎_棘4;

		public Par X0Y0_先端_下顎_棘3;

		public Par X0Y0_先端_下顎_棘2;

		public Par X0Y0_先端_下顎_棘1;

		public Par X0Y0_先端_上顎_棘12;

		public Par X0Y0_先端_上顎_棘11;

		public Par X0Y0_先端_上顎_棘10;

		public Par X0Y0_先端_上顎_棘9;

		public Par X0Y0_先端_上顎_棘8;

		public Par X0Y0_先端_上顎_棘7;

		public Par X0Y0_先端_上顎_顎;

		public Par X0Y0_先端_上顎_脈1;

		public Par X0Y0_先端_上顎_脈2;

		public Par X0Y0_先端_上顎_脈3;

		public Par X0Y0_先端_上顎_脈4;

		public Par X0Y0_先端_輪_革;

		public Par X0Y0_先端_輪_金具1;

		public Par X0Y0_先端_輪_金具2;

		public Par X0Y0_先端_輪_金具3;

		public Par X0Y0_先端_輪_金具左;

		public Par X0Y0_先端_輪_金具右;

		public ColorD 節1_節CD;

		public ColorD 節1_棘1CD;

		public ColorD 節1_棘2CD;

		public ColorD 節1_脈CD;

		public ColorD 節2_節CD;

		public ColorD 節2_棘1CD;

		public ColorD 節2_棘2CD;

		public ColorD 節2_脈CD;

		public ColorD 節3_節CD;

		public ColorD 節3_棘1CD;

		public ColorD 節3_棘2CD;

		public ColorD 節3_脈CD;

		public ColorD 節4_節CD;

		public ColorD 節4_棘1CD;

		public ColorD 節4_棘2CD;

		public ColorD 節4_脈CD;

		public ColorD 節5_節CD;

		public ColorD 節5_棘1CD;

		public ColorD 節5_棘2CD;

		public ColorD 節5_脈CD;

		public ColorD 節6_節CD;

		public ColorD 節6_棘1CD;

		public ColorD 節6_棘2CD;

		public ColorD 節6_脈CD;

		public ColorD 節7_節CD;

		public ColorD 節7_棘1CD;

		public ColorD 節7_棘2CD;

		public ColorD 節7_脈CD;

		public ColorD 節8_節CD;

		public ColorD 節8_棘1CD;

		public ColorD 節8_棘2CD;

		public ColorD 節8_脈CD;

		public ColorD 節9_節CD;

		public ColorD 節9_棘1CD;

		public ColorD 節9_棘2CD;

		public ColorD 節9_脈CD;

		public ColorD 節10_節CD;

		public ColorD 節10_棘1CD;

		public ColorD 節10_棘2CD;

		public ColorD 節10_脈CD;

		public ColorD 節11_節CD;

		public ColorD 節11_棘1CD;

		public ColorD 節11_棘2CD;

		public ColorD 節11_脈CD;

		public ColorD 節12_節CD;

		public ColorD 節12_棘1CD;

		public ColorD 節12_棘2CD;

		public ColorD 節12_脈CD;

		public ColorD 節13_節CD;

		public ColorD 節13_棘1CD;

		public ColorD 節13_棘2CD;

		public ColorD 節13_脈CD;

		public ColorD 節14_節CD;

		public ColorD 節14_棘1CD;

		public ColorD 節14_棘2CD;

		public ColorD 節14_脈CD;

		public ColorD 節15_節CD;

		public ColorD 節15_棘1CD;

		public ColorD 節15_棘2CD;

		public ColorD 節15_脈CD;

		public ColorD 節16_節CD;

		public ColorD 節16_棘1CD;

		public ColorD 節16_棘2CD;

		public ColorD 節16_脈CD;

		public ColorD 節17_節CD;

		public ColorD 節17_棘1CD;

		public ColorD 節17_棘2CD;

		public ColorD 節17_脈CD;

		public ColorD 節18_節CD;

		public ColorD 節18_棘1CD;

		public ColorD 節18_棘2CD;

		public ColorD 節18_脈CD;

		public ColorD 節19_節CD;

		public ColorD 節19_棘1CD;

		public ColorD 節19_棘2CD;

		public ColorD 節19_脈CD;

		public ColorD 節20_節CD;

		public ColorD 節20_棘1CD;

		public ColorD 節20_棘2CD;

		public ColorD 節20_脈CD;

		public ColorD 節21_節CD;

		public ColorD 節21_棘1CD;

		public ColorD 節21_棘2CD;

		public ColorD 節21_脈CD;

		public ColorD 節22_節CD;

		public ColorD 節22_棘1CD;

		public ColorD 節22_棘2CD;

		public ColorD 節22_脈CD;

		public ColorD 節23_節CD;

		public ColorD 節23_棘1CD;

		public ColorD 節23_棘2CD;

		public ColorD 節23_脈CD;

		public ColorD 節24_節CD;

		public ColorD 節24_棘1CD;

		public ColorD 節24_棘2CD;

		public ColorD 節24_脈CD;

		public ColorD 先端_下顎_顎CD;

		public ColorD 先端_下顎_口内CD;

		public ColorD 先端_下顎_棘12CD;

		public ColorD 先端_下顎_棘11CD;

		public ColorD 先端_下顎_棘10CD;

		public ColorD 先端_下顎_棘9CD;

		public ColorD 先端_下顎_棘8CD;

		public ColorD 先端_下顎_棘7CD;

		public ColorD 先端_下顎_脈1CD;

		public ColorD 先端_下顎_脈2CD;

		public ColorD 先端_下顎_脈3CD;

		public ColorD 先端_下顎_棘6CD;

		public ColorD 先端_下顎_棘5CD;

		public ColorD 先端_下顎_棘4CD;

		public ColorD 先端_下顎_棘3CD;

		public ColorD 先端_下顎_棘2CD;

		public ColorD 先端_下顎_棘1CD;

		public ColorD 先端_上顎_棘12CD;

		public ColorD 先端_上顎_棘11CD;

		public ColorD 先端_上顎_棘10CD;

		public ColorD 先端_上顎_棘9CD;

		public ColorD 先端_上顎_棘8CD;

		public ColorD 先端_上顎_棘7CD;

		public ColorD 先端_上顎_顎CD;

		public ColorD 先端_上顎_脈1CD;

		public ColorD 先端_上顎_脈2CD;

		public ColorD 先端_上顎_脈3CD;

		public ColorD 先端_上顎_脈4CD;

		public ColorD 先端_輪_革CD;

		public ColorD 先端_輪_金具1CD;

		public ColorD 先端_輪_金具2CD;

		public ColorD 先端_輪_金具3CD;

		public ColorD 先端_輪_金具左CD;

		public ColorD 先端_輪_金具右CD;

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

		public ColorP X0Y0_節1_棘1CP;

		public ColorP X0Y0_節1_棘2CP;

		public ColorP X0Y0_節1_脈CP;

		public ColorP X0Y0_節2_節CP;

		public ColorP X0Y0_節2_棘1CP;

		public ColorP X0Y0_節2_棘2CP;

		public ColorP X0Y0_節2_脈CP;

		public ColorP X0Y0_節3_節CP;

		public ColorP X0Y0_節3_棘1CP;

		public ColorP X0Y0_節3_棘2CP;

		public ColorP X0Y0_節3_脈CP;

		public ColorP X0Y0_節4_節CP;

		public ColorP X0Y0_節4_棘1CP;

		public ColorP X0Y0_節4_棘2CP;

		public ColorP X0Y0_節4_脈CP;

		public ColorP X0Y0_節5_節CP;

		public ColorP X0Y0_節5_棘1CP;

		public ColorP X0Y0_節5_棘2CP;

		public ColorP X0Y0_節5_脈CP;

		public ColorP X0Y0_節6_節CP;

		public ColorP X0Y0_節6_棘1CP;

		public ColorP X0Y0_節6_棘2CP;

		public ColorP X0Y0_節6_脈CP;

		public ColorP X0Y0_節7_節CP;

		public ColorP X0Y0_節7_棘1CP;

		public ColorP X0Y0_節7_棘2CP;

		public ColorP X0Y0_節7_脈CP;

		public ColorP X0Y0_節8_節CP;

		public ColorP X0Y0_節8_棘1CP;

		public ColorP X0Y0_節8_棘2CP;

		public ColorP X0Y0_節8_脈CP;

		public ColorP X0Y0_節9_節CP;

		public ColorP X0Y0_節9_棘1CP;

		public ColorP X0Y0_節9_棘2CP;

		public ColorP X0Y0_節9_脈CP;

		public ColorP X0Y0_節10_節CP;

		public ColorP X0Y0_節10_棘1CP;

		public ColorP X0Y0_節10_棘2CP;

		public ColorP X0Y0_節10_脈CP;

		public ColorP X0Y0_節11_節CP;

		public ColorP X0Y0_節11_棘1CP;

		public ColorP X0Y0_節11_棘2CP;

		public ColorP X0Y0_節11_脈CP;

		public ColorP X0Y0_節12_節CP;

		public ColorP X0Y0_節12_棘1CP;

		public ColorP X0Y0_節12_棘2CP;

		public ColorP X0Y0_節12_脈CP;

		public ColorP X0Y0_節13_節CP;

		public ColorP X0Y0_節13_棘1CP;

		public ColorP X0Y0_節13_棘2CP;

		public ColorP X0Y0_節13_脈CP;

		public ColorP X0Y0_輪1_革CP;

		public ColorP X0Y0_輪1_金具1CP;

		public ColorP X0Y0_輪1_金具2CP;

		public ColorP X0Y0_輪1_金具3CP;

		public ColorP X0Y0_輪1_金具左CP;

		public ColorP X0Y0_輪1_金具右CP;

		public ColorP X0Y0_節14_節CP;

		public ColorP X0Y0_節14_棘1CP;

		public ColorP X0Y0_節14_棘2CP;

		public ColorP X0Y0_節14_脈CP;

		public ColorP X0Y0_節15_節CP;

		public ColorP X0Y0_節15_棘1CP;

		public ColorP X0Y0_節15_棘2CP;

		public ColorP X0Y0_節15_脈CP;

		public ColorP X0Y0_節16_節CP;

		public ColorP X0Y0_節16_棘1CP;

		public ColorP X0Y0_節16_棘2CP;

		public ColorP X0Y0_節16_脈CP;

		public ColorP X0Y0_節17_節CP;

		public ColorP X0Y0_節17_棘1CP;

		public ColorP X0Y0_節17_棘2CP;

		public ColorP X0Y0_節17_脈CP;

		public ColorP X0Y0_節18_節CP;

		public ColorP X0Y0_節18_棘1CP;

		public ColorP X0Y0_節18_棘2CP;

		public ColorP X0Y0_節18_脈CP;

		public ColorP X0Y0_節19_節CP;

		public ColorP X0Y0_節19_棘1CP;

		public ColorP X0Y0_節19_棘2CP;

		public ColorP X0Y0_節19_脈CP;

		public ColorP X0Y0_節20_節CP;

		public ColorP X0Y0_節20_棘1CP;

		public ColorP X0Y0_節20_棘2CP;

		public ColorP X0Y0_節20_脈CP;

		public ColorP X0Y0_節21_節CP;

		public ColorP X0Y0_節21_棘1CP;

		public ColorP X0Y0_節21_棘2CP;

		public ColorP X0Y0_節21_脈CP;

		public ColorP X0Y0_節22_節CP;

		public ColorP X0Y0_節22_棘1CP;

		public ColorP X0Y0_節22_棘2CP;

		public ColorP X0Y0_節22_脈CP;

		public ColorP X0Y0_節23_節CP;

		public ColorP X0Y0_節23_棘1CP;

		public ColorP X0Y0_節23_棘2CP;

		public ColorP X0Y0_節23_脈CP;

		public ColorP X0Y0_節24_節CP;

		public ColorP X0Y0_節24_棘1CP;

		public ColorP X0Y0_節24_棘2CP;

		public ColorP X0Y0_節24_脈CP;

		public ColorP X0Y0_輪2_革CP;

		public ColorP X0Y0_輪2_金具1CP;

		public ColorP X0Y0_輪2_金具2CP;

		public ColorP X0Y0_輪2_金具3CP;

		public ColorP X0Y0_輪2_金具左CP;

		public ColorP X0Y0_輪2_金具右CP;

		public ColorP X0Y0_先端_下顎_顎CP;

		public ColorP X0Y0_先端_下顎_口内CP;

		public ColorP X0Y0_先端_下顎_棘12CP;

		public ColorP X0Y0_先端_下顎_棘11CP;

		public ColorP X0Y0_先端_下顎_棘10CP;

		public ColorP X0Y0_先端_下顎_棘9CP;

		public ColorP X0Y0_先端_下顎_棘8CP;

		public ColorP X0Y0_先端_下顎_棘7CP;

		public ColorP X0Y0_先端_下顎_脈1CP;

		public ColorP X0Y0_先端_下顎_脈2CP;

		public ColorP X0Y0_先端_下顎_脈3CP;

		public ColorP X0Y0_先端_下顎_棘6CP;

		public ColorP X0Y0_先端_下顎_棘5CP;

		public ColorP X0Y0_先端_下顎_棘4CP;

		public ColorP X0Y0_先端_下顎_棘3CP;

		public ColorP X0Y0_先端_下顎_棘2CP;

		public ColorP X0Y0_先端_下顎_棘1CP;

		public ColorP X0Y0_先端_上顎_棘12CP;

		public ColorP X0Y0_先端_上顎_棘11CP;

		public ColorP X0Y0_先端_上顎_棘10CP;

		public ColorP X0Y0_先端_上顎_棘9CP;

		public ColorP X0Y0_先端_上顎_棘8CP;

		public ColorP X0Y0_先端_上顎_棘7CP;

		public ColorP X0Y0_先端_上顎_顎CP;

		public ColorP X0Y0_先端_上顎_脈1CP;

		public ColorP X0Y0_先端_上顎_脈2CP;

		public ColorP X0Y0_先端_上顎_脈3CP;

		public ColorP X0Y0_先端_上顎_脈4CP;

		public ColorP X0Y0_先端_輪_革CP;

		public ColorP X0Y0_先端_輪_金具1CP;

		public ColorP X0Y0_先端_輪_金具2CP;

		public ColorP X0Y0_先端_輪_金具3CP;

		public ColorP X0Y0_先端_輪_金具左CP;

		public ColorP X0Y0_先端_輪_金具右CP;

		public 拘束鎖 鎖1;

		public 拘束鎖 鎖2;

		public 拘束鎖 鎖3;

		public 拘束鎖 鎖4;

		public Ele[] 節1_接続;

		public Ele[] 節2_接続;

		public Ele[] 節3_接続;

		public Ele[] 節4_接続;

		public Ele[] 節5_接続;

		public Ele[] 節6_接続;

		public Ele[] 節7_接続;

		public Ele[] 節8_接続;

		public Ele[] 節9_接続;

		public Ele[] 節10_接続;

		public Ele[] 節11_接続;

		public Ele[] 節12_接続;

		public Ele[] 節13_接続;

		public Ele[] 節14_接続;

		public Ele[] 節15_接続;

		public Ele[] 節16_接続;

		public Ele[] 節17_接続;

		public Ele[] 節18_接続;

		public Ele[] 節19_接続;

		public Ele[] 節20_接続;

		public Ele[] 節21_接続;

		public Ele[] 節22_接続;

		public Ele[] 節23_接続;

		public Ele[] 節24_接続;

		public Ele[] 先端_接続;

		public Par[] Pars;

		private Vector2D[] mm;
	}
}
