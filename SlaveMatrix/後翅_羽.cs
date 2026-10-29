using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
	public class 後翅_羽 : 後翅
	{
		public 後翅_羽(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 後翅_羽D e)
		{
			this.ThisType = base.GetType();
			Dif dif = new Dif(Sta.肢左["後翅"][1]);
			this.本体 = new Difs();
			this.本体.Tag = dif.Tag;
			this.本体.Add(dif);
			Pars pars = this.本体[0][0]["後翅"].ToPars();
			this.X0Y0_後翅_後翅 = pars["後翅"].ToPar();
			this.X0Y0_後翅_翅脈1 = pars["翅脈1"].ToPar();
			this.X0Y0_後翅_翅脈2 = pars["翅脈2"].ToPar();
			this.X0Y0_後翅_翅脈線1 = pars["翅脈線1"].ToPar();
			this.X0Y0_後翅_翅脈線2 = pars["翅脈線2"].ToPar();
			this.X0Y0_後翅_翅脈線3 = pars["翅脈線3"].ToPar();
			this.X0Y0_後翅_翅脈線4 = pars["翅脈線4"].ToPar();
			this.X0Y0_後翅_翅脈線5 = pars["翅脈線5"].ToPar();
			this.X0Y0_後翅_翅脈線6 = pars["翅脈線6"].ToPar();
			this.X0Y0_後翅_翅脈縦線1 = pars["翅脈縦線1"].ToPar();
			this.X0Y0_後翅_翅脈縦線2 = pars["翅脈縦線2"].ToPar();
			this.X0Y0_後翅_翅脈縦線3 = pars["翅脈縦線3"].ToPar();
			this.X0Y0_後翅_翅脈縦線4 = pars["翅脈縦線4"].ToPar();
			this.X0Y0_後翅_翅脈縦線5 = pars["翅脈縦線5"].ToPar();
			this.X0Y0_後翅_翅脈縦線6 = pars["翅脈縦線6"].ToPar();
			this.X0Y0_後翅_翅脈縦線7 = pars["翅脈縦線7"].ToPar();
			this.X0Y0_後翅_翅脈縦線8 = pars["翅脈縦線8"].ToPar();
			this.X0Y0_後翅_翅脈縦線9 = pars["翅脈縦線9"].ToPar();
			this.X0Y0_後翅_翅脈縦線10 = pars["翅脈縦線10"].ToPar();
			this.X0Y0_後翅_翅脈縦線11 = pars["翅脈縦線11"].ToPar();
			this.X0Y0_後翅_翅脈縦線12 = pars["翅脈縦線12"].ToPar();
			this.X0Y0_後翅_翅脈縦線13 = pars["翅脈縦線13"].ToPar();
			this.X0Y0_後翅_翅脈縦線14 = pars["翅脈縦線14"].ToPar();
			this.X0Y0_後翅_翅脈縦線15 = pars["翅脈縦線15"].ToPar();
			this.X0Y0_後翅_翅脈縦線16 = pars["翅脈縦線16"].ToPar();
			this.X0Y0_後翅_翅脈縦線17 = pars["翅脈縦線17"].ToPar();
			Pars pars2 = pars["翅脈網1"].ToPars();
			this.X0Y0_後翅_翅脈網1_翅脈網線1 = pars2["翅脈網線1"].ToPar();
			this.X0Y0_後翅_翅脈網1_翅脈網線2 = pars2["翅脈網線2"].ToPar();
			this.X0Y0_後翅_翅脈網1_翅脈網線3 = pars2["翅脈網線3"].ToPar();
			pars2 = pars["翅脈網2"].ToPars();
			this.X0Y0_後翅_翅脈網2_翅脈網線1 = pars2["翅脈網線1"].ToPar();
			this.X0Y0_後翅_翅脈網2_翅脈網線2 = pars2["翅脈網線2"].ToPar();
			this.X0Y0_後翅_翅脈網2_翅脈網線3 = pars2["翅脈網線3"].ToPar();
			pars2 = pars["翅脈網3"].ToPars();
			this.X0Y0_後翅_翅脈網3_翅脈網線1 = pars2["翅脈網線1"].ToPar();
			this.X0Y0_後翅_翅脈網3_翅脈網線2 = pars2["翅脈網線2"].ToPar();
			pars2 = pars["翅脈網4"].ToPars();
			this.X0Y0_後翅_翅脈網4_翅脈網線1 = pars2["翅脈網線1"].ToPar();
			this.X0Y0_後翅_翅脈網4_翅脈網線2 = pars2["翅脈網線2"].ToPar();
			pars = this.本体[0][1]["後翅"].ToPars();
			this.X0Y1_後翅_後翅 = pars["後翅"].ToPar();
			this.X0Y1_後翅_翅脈1 = pars["翅脈1"].ToPar();
			this.X0Y1_後翅_翅脈2 = pars["翅脈2"].ToPar();
			this.X0Y1_後翅_翅脈線1 = pars["翅脈線1"].ToPar();
			this.X0Y1_後翅_翅脈線2 = pars["翅脈線2"].ToPar();
			this.X0Y1_後翅_翅脈線3 = pars["翅脈線3"].ToPar();
			this.X0Y1_後翅_翅脈線4 = pars["翅脈線4"].ToPar();
			this.X0Y1_後翅_翅脈線5 = pars["翅脈線5"].ToPar();
			this.X0Y1_後翅_翅脈線6 = pars["翅脈線6"].ToPar();
			this.X0Y1_後翅_翅脈縦線1 = pars["翅脈縦線1"].ToPar();
			this.X0Y1_後翅_翅脈縦線2 = pars["翅脈縦線2"].ToPar();
			this.X0Y1_後翅_翅脈縦線3 = pars["翅脈縦線3"].ToPar();
			this.X0Y1_後翅_翅脈縦線4 = pars["翅脈縦線4"].ToPar();
			this.X0Y1_後翅_翅脈縦線5 = pars["翅脈縦線5"].ToPar();
			this.X0Y1_後翅_翅脈縦線6 = pars["翅脈縦線6"].ToPar();
			this.X0Y1_後翅_翅脈縦線7 = pars["翅脈縦線7"].ToPar();
			this.X0Y1_後翅_翅脈縦線8 = pars["翅脈縦線8"].ToPar();
			this.X0Y1_後翅_翅脈縦線9 = pars["翅脈縦線9"].ToPar();
			this.X0Y1_後翅_翅脈縦線10 = pars["翅脈縦線10"].ToPar();
			this.X0Y1_後翅_翅脈縦線11 = pars["翅脈縦線11"].ToPar();
			this.X0Y1_後翅_翅脈縦線12 = pars["翅脈縦線12"].ToPar();
			this.X0Y1_後翅_翅脈縦線13 = pars["翅脈縦線13"].ToPar();
			this.X0Y1_後翅_翅脈縦線14 = pars["翅脈縦線14"].ToPar();
			this.X0Y1_後翅_翅脈縦線15 = pars["翅脈縦線15"].ToPar();
			this.X0Y1_後翅_翅脈縦線16 = pars["翅脈縦線16"].ToPar();
			this.X0Y1_後翅_翅脈縦線17 = pars["翅脈縦線17"].ToPar();
			pars2 = pars["翅脈網1"].ToPars();
			this.X0Y1_後翅_翅脈網1_翅脈網線1 = pars2["翅脈網線1"].ToPar();
			this.X0Y1_後翅_翅脈網1_翅脈網線2 = pars2["翅脈網線2"].ToPar();
			this.X0Y1_後翅_翅脈網1_翅脈網線3 = pars2["翅脈網線3"].ToPar();
			pars2 = pars["翅脈網2"].ToPars();
			this.X0Y1_後翅_翅脈網2_翅脈網線1 = pars2["翅脈網線1"].ToPar();
			this.X0Y1_後翅_翅脈網2_翅脈網線2 = pars2["翅脈網線2"].ToPar();
			this.X0Y1_後翅_翅脈網2_翅脈網線3 = pars2["翅脈網線3"].ToPar();
			pars2 = pars["翅脈網3"].ToPars();
			this.X0Y1_後翅_翅脈網3_翅脈網線1 = pars2["翅脈網線1"].ToPar();
			this.X0Y1_後翅_翅脈網3_翅脈網線2 = pars2["翅脈網線2"].ToPar();
			pars2 = pars["翅脈網4"].ToPars();
			this.X0Y1_後翅_翅脈網4_翅脈網線1 = pars2["翅脈網線1"].ToPar();
			this.X0Y1_後翅_翅脈網4_翅脈網線2 = pars2["翅脈網線2"].ToPar();
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
			this.後翅_後翅_表示 = e.後翅_後翅_表示;
			this.後翅_翅脈1_表示 = e.後翅_翅脈1_表示;
			this.後翅_翅脈2_表示 = e.後翅_翅脈2_表示;
			this.後翅_翅脈線1_表示 = e.後翅_翅脈線1_表示;
			this.後翅_翅脈線2_表示 = e.後翅_翅脈線2_表示;
			this.後翅_翅脈線3_表示 = e.後翅_翅脈線3_表示;
			this.後翅_翅脈線4_表示 = e.後翅_翅脈線4_表示;
			this.後翅_翅脈線5_表示 = e.後翅_翅脈線5_表示;
			this.後翅_翅脈線6_表示 = e.後翅_翅脈線6_表示;
			this.後翅_翅脈縦線1_表示 = e.後翅_翅脈縦線1_表示;
			this.後翅_翅脈縦線2_表示 = e.後翅_翅脈縦線2_表示;
			this.後翅_翅脈縦線3_表示 = e.後翅_翅脈縦線3_表示;
			this.後翅_翅脈縦線4_表示 = e.後翅_翅脈縦線4_表示;
			this.後翅_翅脈縦線5_表示 = e.後翅_翅脈縦線5_表示;
			this.後翅_翅脈縦線6_表示 = e.後翅_翅脈縦線6_表示;
			this.後翅_翅脈縦線7_表示 = e.後翅_翅脈縦線7_表示;
			this.後翅_翅脈縦線8_表示 = e.後翅_翅脈縦線8_表示;
			this.後翅_翅脈縦線9_表示 = e.後翅_翅脈縦線9_表示;
			this.後翅_翅脈縦線10_表示 = e.後翅_翅脈縦線10_表示;
			this.後翅_翅脈縦線11_表示 = e.後翅_翅脈縦線11_表示;
			this.後翅_翅脈縦線12_表示 = e.後翅_翅脈縦線12_表示;
			this.後翅_翅脈縦線13_表示 = e.後翅_翅脈縦線13_表示;
			this.後翅_翅脈縦線14_表示 = e.後翅_翅脈縦線14_表示;
			this.後翅_翅脈縦線15_表示 = e.後翅_翅脈縦線15_表示;
			this.後翅_翅脈縦線16_表示 = e.後翅_翅脈縦線16_表示;
			this.後翅_翅脈縦線17_表示 = e.後翅_翅脈縦線17_表示;
			this.後翅_翅脈網1_翅脈網線1_表示 = e.後翅_翅脈網1_翅脈網線1_表示;
			this.後翅_翅脈網1_翅脈網線2_表示 = e.後翅_翅脈網1_翅脈網線2_表示;
			this.後翅_翅脈網1_翅脈網線3_表示 = e.後翅_翅脈網1_翅脈網線3_表示;
			this.後翅_翅脈網2_翅脈網線1_表示 = e.後翅_翅脈網2_翅脈網線1_表示;
			this.後翅_翅脈網2_翅脈網線2_表示 = e.後翅_翅脈網2_翅脈網線2_表示;
			this.後翅_翅脈網2_翅脈網線3_表示 = e.後翅_翅脈網2_翅脈網線3_表示;
			this.後翅_翅脈網3_翅脈網線1_表示 = e.後翅_翅脈網3_翅脈網線1_表示;
			this.後翅_翅脈網3_翅脈網線2_表示 = e.後翅_翅脈網3_翅脈網線2_表示;
			this.後翅_翅脈網4_翅脈網線1_表示 = e.後翅_翅脈網4_翅脈網線1_表示;
			this.後翅_翅脈網4_翅脈網線2_表示 = e.後翅_翅脈網4_翅脈網線2_表示;
			this.欠損 = e.欠損;
			this.筋肉 = e.筋肉;
			this.拘束 = e.拘束;
			if (!e.表示)
			{
				this.表示 = false;
			}
			this.配色指定 = 配色指定;
			this.配色(体配色);
			this.X0Y0_後翅_後翅CP = new ColorP(this.X0Y0_後翅_後翅, this.後翅_後翅CD, DisUnit, true);
			this.X0Y0_後翅_翅脈1CP = new ColorP(this.X0Y0_後翅_翅脈1, this.後翅_翅脈1CD, DisUnit, true);
			this.X0Y0_後翅_翅脈2CP = new ColorP(this.X0Y0_後翅_翅脈2, this.後翅_翅脈2CD, DisUnit, true);
			this.X0Y0_後翅_翅脈線1CP = new ColorP(this.X0Y0_後翅_翅脈線1, this.後翅_翅脈線1CD, DisUnit, true);
			this.X0Y0_後翅_翅脈線2CP = new ColorP(this.X0Y0_後翅_翅脈線2, this.後翅_翅脈線2CD, DisUnit, true);
			this.X0Y0_後翅_翅脈線3CP = new ColorP(this.X0Y0_後翅_翅脈線3, this.後翅_翅脈線3CD, DisUnit, true);
			this.X0Y0_後翅_翅脈線4CP = new ColorP(this.X0Y0_後翅_翅脈線4, this.後翅_翅脈線4CD, DisUnit, true);
			this.X0Y0_後翅_翅脈線5CP = new ColorP(this.X0Y0_後翅_翅脈線5, this.後翅_翅脈線5CD, DisUnit, true);
			this.X0Y0_後翅_翅脈線6CP = new ColorP(this.X0Y0_後翅_翅脈線6, this.後翅_翅脈線6CD, DisUnit, true);
			this.X0Y0_後翅_翅脈縦線1CP = new ColorP(this.X0Y0_後翅_翅脈縦線1, this.後翅_翅脈縦線1CD, DisUnit, true);
			this.X0Y0_後翅_翅脈縦線2CP = new ColorP(this.X0Y0_後翅_翅脈縦線2, this.後翅_翅脈縦線2CD, DisUnit, true);
			this.X0Y0_後翅_翅脈縦線3CP = new ColorP(this.X0Y0_後翅_翅脈縦線3, this.後翅_翅脈縦線3CD, DisUnit, true);
			this.X0Y0_後翅_翅脈縦線4CP = new ColorP(this.X0Y0_後翅_翅脈縦線4, this.後翅_翅脈縦線4CD, DisUnit, true);
			this.X0Y0_後翅_翅脈縦線5CP = new ColorP(this.X0Y0_後翅_翅脈縦線5, this.後翅_翅脈縦線5CD, DisUnit, true);
			this.X0Y0_後翅_翅脈縦線6CP = new ColorP(this.X0Y0_後翅_翅脈縦線6, this.後翅_翅脈縦線6CD, DisUnit, true);
			this.X0Y0_後翅_翅脈縦線7CP = new ColorP(this.X0Y0_後翅_翅脈縦線7, this.後翅_翅脈縦線7CD, DisUnit, true);
			this.X0Y0_後翅_翅脈縦線8CP = new ColorP(this.X0Y0_後翅_翅脈縦線8, this.後翅_翅脈縦線8CD, DisUnit, true);
			this.X0Y0_後翅_翅脈縦線9CP = new ColorP(this.X0Y0_後翅_翅脈縦線9, this.後翅_翅脈縦線9CD, DisUnit, true);
			this.X0Y0_後翅_翅脈縦線10CP = new ColorP(this.X0Y0_後翅_翅脈縦線10, this.後翅_翅脈縦線10CD, DisUnit, true);
			this.X0Y0_後翅_翅脈縦線11CP = new ColorP(this.X0Y0_後翅_翅脈縦線11, this.後翅_翅脈縦線11CD, DisUnit, true);
			this.X0Y0_後翅_翅脈縦線12CP = new ColorP(this.X0Y0_後翅_翅脈縦線12, this.後翅_翅脈縦線12CD, DisUnit, true);
			this.X0Y0_後翅_翅脈縦線13CP = new ColorP(this.X0Y0_後翅_翅脈縦線13, this.後翅_翅脈縦線13CD, DisUnit, true);
			this.X0Y0_後翅_翅脈縦線14CP = new ColorP(this.X0Y0_後翅_翅脈縦線14, this.後翅_翅脈縦線14CD, DisUnit, true);
			this.X0Y0_後翅_翅脈縦線15CP = new ColorP(this.X0Y0_後翅_翅脈縦線15, this.後翅_翅脈縦線15CD, DisUnit, true);
			this.X0Y0_後翅_翅脈縦線16CP = new ColorP(this.X0Y0_後翅_翅脈縦線16, this.後翅_翅脈縦線16CD, DisUnit, true);
			this.X0Y0_後翅_翅脈縦線17CP = new ColorP(this.X0Y0_後翅_翅脈縦線17, this.後翅_翅脈縦線17CD, DisUnit, true);
			this.X0Y0_後翅_翅脈網1_翅脈網線1CP = new ColorP(this.X0Y0_後翅_翅脈網1_翅脈網線1, this.後翅_翅脈網1_翅脈網線1CD, DisUnit, true);
			this.X0Y0_後翅_翅脈網1_翅脈網線2CP = new ColorP(this.X0Y0_後翅_翅脈網1_翅脈網線2, this.後翅_翅脈網1_翅脈網線2CD, DisUnit, true);
			this.X0Y0_後翅_翅脈網1_翅脈網線3CP = new ColorP(this.X0Y0_後翅_翅脈網1_翅脈網線3, this.後翅_翅脈網1_翅脈網線3CD, DisUnit, true);
			this.X0Y0_後翅_翅脈網2_翅脈網線1CP = new ColorP(this.X0Y0_後翅_翅脈網2_翅脈網線1, this.後翅_翅脈網2_翅脈網線1CD, DisUnit, true);
			this.X0Y0_後翅_翅脈網2_翅脈網線2CP = new ColorP(this.X0Y0_後翅_翅脈網2_翅脈網線2, this.後翅_翅脈網2_翅脈網線2CD, DisUnit, true);
			this.X0Y0_後翅_翅脈網2_翅脈網線3CP = new ColorP(this.X0Y0_後翅_翅脈網2_翅脈網線3, this.後翅_翅脈網2_翅脈網線3CD, DisUnit, true);
			this.X0Y0_後翅_翅脈網3_翅脈網線1CP = new ColorP(this.X0Y0_後翅_翅脈網3_翅脈網線1, this.後翅_翅脈網3_翅脈網線1CD, DisUnit, true);
			this.X0Y0_後翅_翅脈網3_翅脈網線2CP = new ColorP(this.X0Y0_後翅_翅脈網3_翅脈網線2, this.後翅_翅脈網3_翅脈網線2CD, DisUnit, true);
			this.X0Y0_後翅_翅脈網4_翅脈網線1CP = new ColorP(this.X0Y0_後翅_翅脈網4_翅脈網線1, this.後翅_翅脈網4_翅脈網線1CD, DisUnit, true);
			this.X0Y0_後翅_翅脈網4_翅脈網線2CP = new ColorP(this.X0Y0_後翅_翅脈網4_翅脈網線2, this.後翅_翅脈網4_翅脈網線2CD, DisUnit, true);
			this.X0Y1_後翅_後翅CP = new ColorP(this.X0Y1_後翅_後翅, this.後翅_後翅CD, DisUnit, true);
			this.X0Y1_後翅_翅脈1CP = new ColorP(this.X0Y1_後翅_翅脈1, this.後翅_翅脈1CD, DisUnit, true);
			this.X0Y1_後翅_翅脈2CP = new ColorP(this.X0Y1_後翅_翅脈2, this.後翅_翅脈2CD, DisUnit, true);
			this.X0Y1_後翅_翅脈線1CP = new ColorP(this.X0Y1_後翅_翅脈線1, this.後翅_翅脈線1CD, DisUnit, true);
			this.X0Y1_後翅_翅脈線2CP = new ColorP(this.X0Y1_後翅_翅脈線2, this.後翅_翅脈線2CD, DisUnit, true);
			this.X0Y1_後翅_翅脈線3CP = new ColorP(this.X0Y1_後翅_翅脈線3, this.後翅_翅脈線3CD, DisUnit, true);
			this.X0Y1_後翅_翅脈線4CP = new ColorP(this.X0Y1_後翅_翅脈線4, this.後翅_翅脈線4CD, DisUnit, true);
			this.X0Y1_後翅_翅脈線5CP = new ColorP(this.X0Y1_後翅_翅脈線5, this.後翅_翅脈線5CD, DisUnit, true);
			this.X0Y1_後翅_翅脈線6CP = new ColorP(this.X0Y1_後翅_翅脈線6, this.後翅_翅脈線6CD, DisUnit, true);
			this.X0Y1_後翅_翅脈縦線1CP = new ColorP(this.X0Y1_後翅_翅脈縦線1, this.後翅_翅脈縦線1CD, DisUnit, true);
			this.X0Y1_後翅_翅脈縦線2CP = new ColorP(this.X0Y1_後翅_翅脈縦線2, this.後翅_翅脈縦線2CD, DisUnit, true);
			this.X0Y1_後翅_翅脈縦線3CP = new ColorP(this.X0Y1_後翅_翅脈縦線3, this.後翅_翅脈縦線3CD, DisUnit, true);
			this.X0Y1_後翅_翅脈縦線4CP = new ColorP(this.X0Y1_後翅_翅脈縦線4, this.後翅_翅脈縦線4CD, DisUnit, true);
			this.X0Y1_後翅_翅脈縦線5CP = new ColorP(this.X0Y1_後翅_翅脈縦線5, this.後翅_翅脈縦線5CD, DisUnit, true);
			this.X0Y1_後翅_翅脈縦線6CP = new ColorP(this.X0Y1_後翅_翅脈縦線6, this.後翅_翅脈縦線6CD, DisUnit, true);
			this.X0Y1_後翅_翅脈縦線7CP = new ColorP(this.X0Y1_後翅_翅脈縦線7, this.後翅_翅脈縦線7CD, DisUnit, true);
			this.X0Y1_後翅_翅脈縦線8CP = new ColorP(this.X0Y1_後翅_翅脈縦線8, this.後翅_翅脈縦線8CD, DisUnit, true);
			this.X0Y1_後翅_翅脈縦線9CP = new ColorP(this.X0Y1_後翅_翅脈縦線9, this.後翅_翅脈縦線9CD, DisUnit, true);
			this.X0Y1_後翅_翅脈縦線10CP = new ColorP(this.X0Y1_後翅_翅脈縦線10, this.後翅_翅脈縦線10CD, DisUnit, true);
			this.X0Y1_後翅_翅脈縦線11CP = new ColorP(this.X0Y1_後翅_翅脈縦線11, this.後翅_翅脈縦線11CD, DisUnit, true);
			this.X0Y1_後翅_翅脈縦線12CP = new ColorP(this.X0Y1_後翅_翅脈縦線12, this.後翅_翅脈縦線12CD, DisUnit, true);
			this.X0Y1_後翅_翅脈縦線13CP = new ColorP(this.X0Y1_後翅_翅脈縦線13, this.後翅_翅脈縦線13CD, DisUnit, true);
			this.X0Y1_後翅_翅脈縦線14CP = new ColorP(this.X0Y1_後翅_翅脈縦線14, this.後翅_翅脈縦線14CD, DisUnit, true);
			this.X0Y1_後翅_翅脈縦線15CP = new ColorP(this.X0Y1_後翅_翅脈縦線15, this.後翅_翅脈縦線15CD, DisUnit, true);
			this.X0Y1_後翅_翅脈縦線16CP = new ColorP(this.X0Y1_後翅_翅脈縦線16, this.後翅_翅脈縦線16CD, DisUnit, true);
			this.X0Y1_後翅_翅脈縦線17CP = new ColorP(this.X0Y1_後翅_翅脈縦線17, this.後翅_翅脈縦線17CD, DisUnit, true);
			this.X0Y1_後翅_翅脈網1_翅脈網線1CP = new ColorP(this.X0Y1_後翅_翅脈網1_翅脈網線1, this.後翅_翅脈網1_翅脈網線1CD, DisUnit, true);
			this.X0Y1_後翅_翅脈網1_翅脈網線2CP = new ColorP(this.X0Y1_後翅_翅脈網1_翅脈網線2, this.後翅_翅脈網1_翅脈網線2CD, DisUnit, true);
			this.X0Y1_後翅_翅脈網1_翅脈網線3CP = new ColorP(this.X0Y1_後翅_翅脈網1_翅脈網線3, this.後翅_翅脈網1_翅脈網線3CD, DisUnit, true);
			this.X0Y1_後翅_翅脈網2_翅脈網線1CP = new ColorP(this.X0Y1_後翅_翅脈網2_翅脈網線1, this.後翅_翅脈網2_翅脈網線1CD, DisUnit, true);
			this.X0Y1_後翅_翅脈網2_翅脈網線2CP = new ColorP(this.X0Y1_後翅_翅脈網2_翅脈網線2, this.後翅_翅脈網2_翅脈網線2CD, DisUnit, true);
			this.X0Y1_後翅_翅脈網2_翅脈網線3CP = new ColorP(this.X0Y1_後翅_翅脈網2_翅脈網線3, this.後翅_翅脈網2_翅脈網線3CD, DisUnit, true);
			this.X0Y1_後翅_翅脈網3_翅脈網線1CP = new ColorP(this.X0Y1_後翅_翅脈網3_翅脈網線1, this.後翅_翅脈網3_翅脈網線1CD, DisUnit, true);
			this.X0Y1_後翅_翅脈網3_翅脈網線2CP = new ColorP(this.X0Y1_後翅_翅脈網3_翅脈網線2, this.後翅_翅脈網3_翅脈網線2CD, DisUnit, true);
			this.X0Y1_後翅_翅脈網4_翅脈網線1CP = new ColorP(this.X0Y1_後翅_翅脈網4_翅脈網線1, this.後翅_翅脈網4_翅脈網線1CD, DisUnit, true);
			this.X0Y1_後翅_翅脈網4_翅脈網線2CP = new ColorP(this.X0Y1_後翅_翅脈網4_翅脈網線2, this.後翅_翅脈網4_翅脈網線2CD, DisUnit, true);
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
				this.本体.IndexY = (this.欠損_ ? 1 : 0);
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

		public bool 後翅_後翅_表示
		{
			get
			{
				return this.X0Y0_後翅_後翅.Dra;
			}
			set
			{
				this.X0Y0_後翅_後翅.Dra = value;
				this.X0Y1_後翅_後翅.Dra = value;
				this.X0Y0_後翅_後翅.Hit = value;
				this.X0Y1_後翅_後翅.Hit = value;
			}
		}

		public bool 後翅_翅脈1_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈1.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈1.Dra = value;
				this.X0Y1_後翅_翅脈1.Dra = value;
				this.X0Y0_後翅_翅脈1.Hit = value;
				this.X0Y1_後翅_翅脈1.Hit = value;
			}
		}

		public bool 後翅_翅脈2_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈2.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈2.Dra = value;
				this.X0Y1_後翅_翅脈2.Dra = value;
				this.X0Y0_後翅_翅脈2.Hit = value;
				this.X0Y1_後翅_翅脈2.Hit = value;
			}
		}

		public bool 後翅_翅脈線1_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈線1.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈線1.Dra = value;
				this.X0Y1_後翅_翅脈線1.Dra = value;
				this.X0Y0_後翅_翅脈線1.Hit = value;
				this.X0Y1_後翅_翅脈線1.Hit = value;
			}
		}

		public bool 後翅_翅脈線2_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈線2.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈線2.Dra = value;
				this.X0Y1_後翅_翅脈線2.Dra = value;
				this.X0Y0_後翅_翅脈線2.Hit = value;
				this.X0Y1_後翅_翅脈線2.Hit = value;
			}
		}

		public bool 後翅_翅脈線3_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈線3.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈線3.Dra = value;
				this.X0Y1_後翅_翅脈線3.Dra = value;
				this.X0Y0_後翅_翅脈線3.Hit = value;
				this.X0Y1_後翅_翅脈線3.Hit = value;
			}
		}

		public bool 後翅_翅脈線4_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈線4.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈線4.Dra = value;
				this.X0Y1_後翅_翅脈線4.Dra = value;
				this.X0Y0_後翅_翅脈線4.Hit = value;
				this.X0Y1_後翅_翅脈線4.Hit = value;
			}
		}

		public bool 後翅_翅脈線5_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈線5.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈線5.Dra = value;
				this.X0Y1_後翅_翅脈線5.Dra = value;
				this.X0Y0_後翅_翅脈線5.Hit = value;
				this.X0Y1_後翅_翅脈線5.Hit = value;
			}
		}

		public bool 後翅_翅脈線6_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈線6.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈線6.Dra = value;
				this.X0Y1_後翅_翅脈線6.Dra = value;
				this.X0Y0_後翅_翅脈線6.Hit = value;
				this.X0Y1_後翅_翅脈線6.Hit = value;
			}
		}

		public bool 後翅_翅脈縦線1_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈縦線1.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈縦線1.Dra = value;
				this.X0Y1_後翅_翅脈縦線1.Dra = value;
				this.X0Y0_後翅_翅脈縦線1.Hit = value;
				this.X0Y1_後翅_翅脈縦線1.Hit = value;
			}
		}

		public bool 後翅_翅脈縦線2_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈縦線2.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈縦線2.Dra = value;
				this.X0Y1_後翅_翅脈縦線2.Dra = value;
				this.X0Y0_後翅_翅脈縦線2.Hit = value;
				this.X0Y1_後翅_翅脈縦線2.Hit = value;
			}
		}

		public bool 後翅_翅脈縦線3_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈縦線3.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈縦線3.Dra = value;
				this.X0Y1_後翅_翅脈縦線3.Dra = value;
				this.X0Y0_後翅_翅脈縦線3.Hit = value;
				this.X0Y1_後翅_翅脈縦線3.Hit = value;
			}
		}

		public bool 後翅_翅脈縦線4_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈縦線4.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈縦線4.Dra = value;
				this.X0Y1_後翅_翅脈縦線4.Dra = value;
				this.X0Y0_後翅_翅脈縦線4.Hit = value;
				this.X0Y1_後翅_翅脈縦線4.Hit = value;
			}
		}

		public bool 後翅_翅脈縦線5_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈縦線5.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈縦線5.Dra = value;
				this.X0Y1_後翅_翅脈縦線5.Dra = value;
				this.X0Y0_後翅_翅脈縦線5.Hit = value;
				this.X0Y1_後翅_翅脈縦線5.Hit = value;
			}
		}

		public bool 後翅_翅脈縦線6_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈縦線6.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈縦線6.Dra = value;
				this.X0Y1_後翅_翅脈縦線6.Dra = value;
				this.X0Y0_後翅_翅脈縦線6.Hit = value;
				this.X0Y1_後翅_翅脈縦線6.Hit = value;
			}
		}

		public bool 後翅_翅脈縦線7_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈縦線7.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈縦線7.Dra = value;
				this.X0Y1_後翅_翅脈縦線7.Dra = value;
				this.X0Y0_後翅_翅脈縦線7.Hit = value;
				this.X0Y1_後翅_翅脈縦線7.Hit = value;
			}
		}

		public bool 後翅_翅脈縦線8_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈縦線8.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈縦線8.Dra = value;
				this.X0Y1_後翅_翅脈縦線8.Dra = value;
				this.X0Y0_後翅_翅脈縦線8.Hit = value;
				this.X0Y1_後翅_翅脈縦線8.Hit = value;
			}
		}

		public bool 後翅_翅脈縦線9_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈縦線9.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈縦線9.Dra = value;
				this.X0Y1_後翅_翅脈縦線9.Dra = value;
				this.X0Y0_後翅_翅脈縦線9.Hit = value;
				this.X0Y1_後翅_翅脈縦線9.Hit = value;
			}
		}

		public bool 後翅_翅脈縦線10_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈縦線10.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈縦線10.Dra = value;
				this.X0Y1_後翅_翅脈縦線10.Dra = value;
				this.X0Y0_後翅_翅脈縦線10.Hit = value;
				this.X0Y1_後翅_翅脈縦線10.Hit = value;
			}
		}

		public bool 後翅_翅脈縦線11_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈縦線11.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈縦線11.Dra = value;
				this.X0Y1_後翅_翅脈縦線11.Dra = value;
				this.X0Y0_後翅_翅脈縦線11.Hit = value;
				this.X0Y1_後翅_翅脈縦線11.Hit = value;
			}
		}

		public bool 後翅_翅脈縦線12_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈縦線12.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈縦線12.Dra = value;
				this.X0Y1_後翅_翅脈縦線12.Dra = value;
				this.X0Y0_後翅_翅脈縦線12.Hit = value;
				this.X0Y1_後翅_翅脈縦線12.Hit = value;
			}
		}

		public bool 後翅_翅脈縦線13_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈縦線13.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈縦線13.Dra = value;
				this.X0Y1_後翅_翅脈縦線13.Dra = value;
				this.X0Y0_後翅_翅脈縦線13.Hit = value;
				this.X0Y1_後翅_翅脈縦線13.Hit = value;
			}
		}

		public bool 後翅_翅脈縦線14_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈縦線14.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈縦線14.Dra = value;
				this.X0Y1_後翅_翅脈縦線14.Dra = value;
				this.X0Y0_後翅_翅脈縦線14.Hit = value;
				this.X0Y1_後翅_翅脈縦線14.Hit = value;
			}
		}

		public bool 後翅_翅脈縦線15_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈縦線15.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈縦線15.Dra = value;
				this.X0Y1_後翅_翅脈縦線15.Dra = value;
				this.X0Y0_後翅_翅脈縦線15.Hit = value;
				this.X0Y1_後翅_翅脈縦線15.Hit = value;
			}
		}

		public bool 後翅_翅脈縦線16_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈縦線16.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈縦線16.Dra = value;
				this.X0Y1_後翅_翅脈縦線16.Dra = value;
				this.X0Y0_後翅_翅脈縦線16.Hit = value;
				this.X0Y1_後翅_翅脈縦線16.Hit = value;
			}
		}

		public bool 後翅_翅脈縦線17_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈縦線17.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈縦線17.Dra = value;
				this.X0Y1_後翅_翅脈縦線17.Dra = value;
				this.X0Y0_後翅_翅脈縦線17.Hit = value;
				this.X0Y1_後翅_翅脈縦線17.Hit = value;
			}
		}

		public bool 後翅_翅脈網1_翅脈網線1_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈網1_翅脈網線1.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈網1_翅脈網線1.Dra = value;
				this.X0Y1_後翅_翅脈網1_翅脈網線1.Dra = value;
				this.X0Y0_後翅_翅脈網1_翅脈網線1.Hit = value;
				this.X0Y1_後翅_翅脈網1_翅脈網線1.Hit = value;
			}
		}

		public bool 後翅_翅脈網1_翅脈網線2_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈網1_翅脈網線2.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈網1_翅脈網線2.Dra = value;
				this.X0Y1_後翅_翅脈網1_翅脈網線2.Dra = value;
				this.X0Y0_後翅_翅脈網1_翅脈網線2.Hit = value;
				this.X0Y1_後翅_翅脈網1_翅脈網線2.Hit = value;
			}
		}

		public bool 後翅_翅脈網1_翅脈網線3_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈網1_翅脈網線3.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈網1_翅脈網線3.Dra = value;
				this.X0Y1_後翅_翅脈網1_翅脈網線3.Dra = value;
				this.X0Y0_後翅_翅脈網1_翅脈網線3.Hit = value;
				this.X0Y1_後翅_翅脈網1_翅脈網線3.Hit = value;
			}
		}

		public bool 後翅_翅脈網2_翅脈網線1_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈網2_翅脈網線1.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈網2_翅脈網線1.Dra = value;
				this.X0Y1_後翅_翅脈網2_翅脈網線1.Dra = value;
				this.X0Y0_後翅_翅脈網2_翅脈網線1.Hit = value;
				this.X0Y1_後翅_翅脈網2_翅脈網線1.Hit = value;
			}
		}

		public bool 後翅_翅脈網2_翅脈網線2_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈網2_翅脈網線2.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈網2_翅脈網線2.Dra = value;
				this.X0Y1_後翅_翅脈網2_翅脈網線2.Dra = value;
				this.X0Y0_後翅_翅脈網2_翅脈網線2.Hit = value;
				this.X0Y1_後翅_翅脈網2_翅脈網線2.Hit = value;
			}
		}

		public bool 後翅_翅脈網2_翅脈網線3_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈網2_翅脈網線3.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈網2_翅脈網線3.Dra = value;
				this.X0Y1_後翅_翅脈網2_翅脈網線3.Dra = value;
				this.X0Y0_後翅_翅脈網2_翅脈網線3.Hit = value;
				this.X0Y1_後翅_翅脈網2_翅脈網線3.Hit = value;
			}
		}

		public bool 後翅_翅脈網3_翅脈網線1_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈網3_翅脈網線1.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈網3_翅脈網線1.Dra = value;
				this.X0Y1_後翅_翅脈網3_翅脈網線1.Dra = value;
				this.X0Y0_後翅_翅脈網3_翅脈網線1.Hit = value;
				this.X0Y1_後翅_翅脈網3_翅脈網線1.Hit = value;
			}
		}

		public bool 後翅_翅脈網3_翅脈網線2_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈網3_翅脈網線2.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈網3_翅脈網線2.Dra = value;
				this.X0Y1_後翅_翅脈網3_翅脈網線2.Dra = value;
				this.X0Y0_後翅_翅脈網3_翅脈網線2.Hit = value;
				this.X0Y1_後翅_翅脈網3_翅脈網線2.Hit = value;
			}
		}

		public bool 後翅_翅脈網4_翅脈網線1_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈網4_翅脈網線1.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈網4_翅脈網線1.Dra = value;
				this.X0Y1_後翅_翅脈網4_翅脈網線1.Dra = value;
				this.X0Y0_後翅_翅脈網4_翅脈網線1.Hit = value;
				this.X0Y1_後翅_翅脈網4_翅脈網線1.Hit = value;
			}
		}

		public bool 後翅_翅脈網4_翅脈網線2_表示
		{
			get
			{
				return this.X0Y0_後翅_翅脈網4_翅脈網線2.Dra;
			}
			set
			{
				this.X0Y0_後翅_翅脈網4_翅脈網線2.Dra = value;
				this.X0Y1_後翅_翅脈網4_翅脈網線2.Dra = value;
				this.X0Y0_後翅_翅脈網4_翅脈網線2.Hit = value;
				this.X0Y1_後翅_翅脈網4_翅脈網線2.Hit = value;
			}
		}

		public override bool 表示
		{
			get
			{
				return this.後翅_後翅_表示;
			}
			set
			{
				this.後翅_後翅_表示 = value;
				this.後翅_翅脈1_表示 = value;
				this.後翅_翅脈2_表示 = value;
				this.後翅_翅脈線1_表示 = value;
				this.後翅_翅脈線2_表示 = value;
				this.後翅_翅脈線3_表示 = value;
				this.後翅_翅脈線4_表示 = value;
				this.後翅_翅脈線5_表示 = value;
				this.後翅_翅脈線6_表示 = value;
				this.後翅_翅脈縦線1_表示 = value;
				this.後翅_翅脈縦線2_表示 = value;
				this.後翅_翅脈縦線3_表示 = value;
				this.後翅_翅脈縦線4_表示 = value;
				this.後翅_翅脈縦線5_表示 = value;
				this.後翅_翅脈縦線6_表示 = value;
				this.後翅_翅脈縦線7_表示 = value;
				this.後翅_翅脈縦線8_表示 = value;
				this.後翅_翅脈縦線9_表示 = value;
				this.後翅_翅脈縦線10_表示 = value;
				this.後翅_翅脈縦線11_表示 = value;
				this.後翅_翅脈縦線12_表示 = value;
				this.後翅_翅脈縦線13_表示 = value;
				this.後翅_翅脈縦線14_表示 = value;
				this.後翅_翅脈縦線15_表示 = value;
				this.後翅_翅脈縦線16_表示 = value;
				this.後翅_翅脈縦線17_表示 = value;
				this.後翅_翅脈網1_翅脈網線1_表示 = value;
				this.後翅_翅脈網1_翅脈網線2_表示 = value;
				this.後翅_翅脈網1_翅脈網線3_表示 = value;
				this.後翅_翅脈網2_翅脈網線1_表示 = value;
				this.後翅_翅脈網2_翅脈網線2_表示 = value;
				this.後翅_翅脈網2_翅脈網線3_表示 = value;
				this.後翅_翅脈網3_翅脈網線1_表示 = value;
				this.後翅_翅脈網3_翅脈網線2_表示 = value;
				this.後翅_翅脈網4_翅脈網線1_表示 = value;
				this.後翅_翅脈網4_翅脈網線2_表示 = value;
			}
		}

		public override double 濃度
		{
			get
			{
				return this.後翅_後翅CD.不透明度;
			}
			set
			{
				this.後翅_後翅CD.不透明度 = value;
				this.後翅_翅脈1CD.不透明度 = value;
				this.後翅_翅脈2CD.不透明度 = value;
				this.後翅_翅脈線1CD.不透明度 = value;
				this.後翅_翅脈線2CD.不透明度 = value;
				this.後翅_翅脈線3CD.不透明度 = value;
				this.後翅_翅脈線4CD.不透明度 = value;
				this.後翅_翅脈線5CD.不透明度 = value;
				this.後翅_翅脈線6CD.不透明度 = value;
				this.後翅_翅脈縦線1CD.不透明度 = value;
				this.後翅_翅脈縦線2CD.不透明度 = value;
				this.後翅_翅脈縦線3CD.不透明度 = value;
				this.後翅_翅脈縦線4CD.不透明度 = value;
				this.後翅_翅脈縦線5CD.不透明度 = value;
				this.後翅_翅脈縦線6CD.不透明度 = value;
				this.後翅_翅脈縦線7CD.不透明度 = value;
				this.後翅_翅脈縦線8CD.不透明度 = value;
				this.後翅_翅脈縦線9CD.不透明度 = value;
				this.後翅_翅脈縦線10CD.不透明度 = value;
				this.後翅_翅脈縦線11CD.不透明度 = value;
				this.後翅_翅脈縦線12CD.不透明度 = value;
				this.後翅_翅脈縦線13CD.不透明度 = value;
				this.後翅_翅脈縦線14CD.不透明度 = value;
				this.後翅_翅脈縦線15CD.不透明度 = value;
				this.後翅_翅脈縦線16CD.不透明度 = value;
				this.後翅_翅脈縦線17CD.不透明度 = value;
				this.後翅_翅脈網1_翅脈網線1CD.不透明度 = value;
				this.後翅_翅脈網1_翅脈網線2CD.不透明度 = value;
				this.後翅_翅脈網1_翅脈網線3CD.不透明度 = value;
				this.後翅_翅脈網2_翅脈網線1CD.不透明度 = value;
				this.後翅_翅脈網2_翅脈網線2CD.不透明度 = value;
				this.後翅_翅脈網2_翅脈網線3CD.不透明度 = value;
				this.後翅_翅脈網3_翅脈網線1CD.不透明度 = value;
				this.後翅_翅脈網3_翅脈網線2CD.不透明度 = value;
				this.後翅_翅脈網4_翅脈網線1CD.不透明度 = value;
				this.後翅_翅脈網4_翅脈網線2CD.不透明度 = value;
			}
		}

		public override void Set角度0()
		{
			double num = this.右 ? -1.0 : 1.0;
			this.X0Y0_後翅_後翅.AngleBase = num * 3.0;
			this.X0Y1_後翅_後翅.AngleBase = num * 3.0;
			this.本体.JoinPAall();
		}

		public override void 色更新()
		{
			if (this.本体.IndexY == 0)
			{
				this.X0Y0_後翅_後翅CP.Update();
				this.X0Y0_後翅_翅脈1CP.Update();
				this.X0Y0_後翅_翅脈2CP.Update();
				this.X0Y0_後翅_翅脈線1CP.Update();
				this.X0Y0_後翅_翅脈線2CP.Update();
				this.X0Y0_後翅_翅脈線3CP.Update();
				this.X0Y0_後翅_翅脈線4CP.Update();
				this.X0Y0_後翅_翅脈線5CP.Update();
				this.X0Y0_後翅_翅脈線6CP.Update();
				this.X0Y0_後翅_翅脈縦線1CP.Update();
				this.X0Y0_後翅_翅脈縦線2CP.Update();
				this.X0Y0_後翅_翅脈縦線3CP.Update();
				this.X0Y0_後翅_翅脈縦線4CP.Update();
				this.X0Y0_後翅_翅脈縦線5CP.Update();
				this.X0Y0_後翅_翅脈縦線6CP.Update();
				this.X0Y0_後翅_翅脈縦線7CP.Update();
				this.X0Y0_後翅_翅脈縦線8CP.Update();
				this.X0Y0_後翅_翅脈縦線9CP.Update();
				this.X0Y0_後翅_翅脈縦線10CP.Update();
				this.X0Y0_後翅_翅脈縦線11CP.Update();
				this.X0Y0_後翅_翅脈縦線12CP.Update();
				this.X0Y0_後翅_翅脈縦線13CP.Update();
				this.X0Y0_後翅_翅脈縦線14CP.Update();
				this.X0Y0_後翅_翅脈縦線15CP.Update();
				this.X0Y0_後翅_翅脈縦線16CP.Update();
				this.X0Y0_後翅_翅脈縦線17CP.Update();
				this.X0Y0_後翅_翅脈網1_翅脈網線1CP.Update();
				this.X0Y0_後翅_翅脈網1_翅脈網線2CP.Update();
				this.X0Y0_後翅_翅脈網1_翅脈網線3CP.Update();
				this.X0Y0_後翅_翅脈網2_翅脈網線1CP.Update();
				this.X0Y0_後翅_翅脈網2_翅脈網線2CP.Update();
				this.X0Y0_後翅_翅脈網2_翅脈網線3CP.Update();
				this.X0Y0_後翅_翅脈網3_翅脈網線1CP.Update();
				this.X0Y0_後翅_翅脈網3_翅脈網線2CP.Update();
				this.X0Y0_後翅_翅脈網4_翅脈網線1CP.Update();
				this.X0Y0_後翅_翅脈網4_翅脈網線2CP.Update();
				return;
			}
			this.X0Y1_後翅_後翅CP.Update();
			this.X0Y1_後翅_翅脈1CP.Update();
			this.X0Y1_後翅_翅脈2CP.Update();
			this.X0Y1_後翅_翅脈線1CP.Update();
			this.X0Y1_後翅_翅脈線2CP.Update();
			this.X0Y1_後翅_翅脈線3CP.Update();
			this.X0Y1_後翅_翅脈線4CP.Update();
			this.X0Y1_後翅_翅脈線5CP.Update();
			this.X0Y1_後翅_翅脈線6CP.Update();
			this.X0Y1_後翅_翅脈縦線1CP.Update();
			this.X0Y1_後翅_翅脈縦線2CP.Update();
			this.X0Y1_後翅_翅脈縦線3CP.Update();
			this.X0Y1_後翅_翅脈縦線4CP.Update();
			this.X0Y1_後翅_翅脈縦線5CP.Update();
			this.X0Y1_後翅_翅脈縦線6CP.Update();
			this.X0Y1_後翅_翅脈縦線7CP.Update();
			this.X0Y1_後翅_翅脈縦線8CP.Update();
			this.X0Y1_後翅_翅脈縦線9CP.Update();
			this.X0Y1_後翅_翅脈縦線10CP.Update();
			this.X0Y1_後翅_翅脈縦線11CP.Update();
			this.X0Y1_後翅_翅脈縦線12CP.Update();
			this.X0Y1_後翅_翅脈縦線13CP.Update();
			this.X0Y1_後翅_翅脈縦線14CP.Update();
			this.X0Y1_後翅_翅脈縦線15CP.Update();
			this.X0Y1_後翅_翅脈縦線16CP.Update();
			this.X0Y1_後翅_翅脈縦線17CP.Update();
			this.X0Y1_後翅_翅脈網1_翅脈網線1CP.Update();
			this.X0Y1_後翅_翅脈網1_翅脈網線2CP.Update();
			this.X0Y1_後翅_翅脈網1_翅脈網線3CP.Update();
			this.X0Y1_後翅_翅脈網2_翅脈網線1CP.Update();
			this.X0Y1_後翅_翅脈網2_翅脈網線2CP.Update();
			this.X0Y1_後翅_翅脈網2_翅脈網線3CP.Update();
			this.X0Y1_後翅_翅脈網3_翅脈網線1CP.Update();
			this.X0Y1_後翅_翅脈網3_翅脈網線2CP.Update();
			this.X0Y1_後翅_翅脈網4_翅脈網線1CP.Update();
			this.X0Y1_後翅_翅脈網4_翅脈網線2CP.Update();
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
			this.後翅_後翅CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.後翅_翅脈2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.後翅_翅脈線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈線3CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈線4CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈線5CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈線6CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線3CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線4CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線5CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線6CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線7CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線8CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線9CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線10CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線11CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線12CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線13CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線14CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線15CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線16CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線17CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈網1_翅脈網線1CD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.後翅_翅脈網1_翅脈網線2CD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.後翅_翅脈網1_翅脈網線3CD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.後翅_翅脈網2_翅脈網線1CD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.後翅_翅脈網2_翅脈網線2CD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.後翅_翅脈網2_翅脈網線3CD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.後翅_翅脈網3_翅脈網線1CD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.後翅_翅脈網3_翅脈網線2CD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.後翅_翅脈網4_翅脈網線1CD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.後翅_翅脈網4_翅脈網線2CD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
		}

		private void 配色T1(体配色 体配色)
		{
			this.後翅_後翅CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.後翅_翅脈2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.後翅_翅脈線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈線3CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈線4CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈線5CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈線6CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線3CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線4CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線5CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線6CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線7CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線8CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線9CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線10CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線11CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線12CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線13CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線14CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線15CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線16CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線17CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈網1_翅脈網線1CD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.後翅_翅脈網1_翅脈網線2CD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.後翅_翅脈網1_翅脈網線3CD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.後翅_翅脈網2_翅脈網線1CD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.後翅_翅脈網2_翅脈網線2CD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.後翅_翅脈網2_翅脈網線3CD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.後翅_翅脈網3_翅脈網線1CD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.後翅_翅脈網3_翅脈網線2CD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.後翅_翅脈網4_翅脈網線1CD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
			this.後翅_翅脈網4_翅脈網線2CD = new ColorD(ref Col.Black, ref 体配色.ハイライト2O);
		}

		private void 配色T0(体配色 体配色)
		{
			this.後翅_後翅CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈1CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.後翅_翅脈2CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
			this.後翅_翅脈線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈線3CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈線4CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈線5CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈線6CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線1CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線2CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線3CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線4CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線5CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線6CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線7CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線8CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線9CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線10CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線11CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線12CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線13CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線14CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線15CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線16CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈縦線17CD = new ColorD(ref Col.Black, ref Color2.Empty);
			this.後翅_翅脈網1_翅脈網線1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.後翅_翅脈網1_翅脈網線2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.後翅_翅脈網1_翅脈網線3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.後翅_翅脈網2_翅脈網線1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.後翅_翅脈網2_翅脈網線2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.後翅_翅脈網2_翅脈網線3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.後翅_翅脈網3_翅脈網線1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.後翅_翅脈網3_翅脈網線2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.後翅_翅脈網4_翅脈網線1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
			this.後翅_翅脈網4_翅脈網線2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
		}

		public Par X0Y0_後翅_後翅;

		public Par X0Y0_後翅_翅脈1;

		public Par X0Y0_後翅_翅脈2;

		public Par X0Y0_後翅_翅脈線1;

		public Par X0Y0_後翅_翅脈線2;

		public Par X0Y0_後翅_翅脈線3;

		public Par X0Y0_後翅_翅脈線4;

		public Par X0Y0_後翅_翅脈線5;

		public Par X0Y0_後翅_翅脈線6;

		public Par X0Y0_後翅_翅脈縦線1;

		public Par X0Y0_後翅_翅脈縦線2;

		public Par X0Y0_後翅_翅脈縦線3;

		public Par X0Y0_後翅_翅脈縦線4;

		public Par X0Y0_後翅_翅脈縦線5;

		public Par X0Y0_後翅_翅脈縦線6;

		public Par X0Y0_後翅_翅脈縦線7;

		public Par X0Y0_後翅_翅脈縦線8;

		public Par X0Y0_後翅_翅脈縦線9;

		public Par X0Y0_後翅_翅脈縦線10;

		public Par X0Y0_後翅_翅脈縦線11;

		public Par X0Y0_後翅_翅脈縦線12;

		public Par X0Y0_後翅_翅脈縦線13;

		public Par X0Y0_後翅_翅脈縦線14;

		public Par X0Y0_後翅_翅脈縦線15;

		public Par X0Y0_後翅_翅脈縦線16;

		public Par X0Y0_後翅_翅脈縦線17;

		public Par X0Y0_後翅_翅脈網1_翅脈網線1;

		public Par X0Y0_後翅_翅脈網1_翅脈網線2;

		public Par X0Y0_後翅_翅脈網1_翅脈網線3;

		public Par X0Y0_後翅_翅脈網2_翅脈網線1;

		public Par X0Y0_後翅_翅脈網2_翅脈網線2;

		public Par X0Y0_後翅_翅脈網2_翅脈網線3;

		public Par X0Y0_後翅_翅脈網3_翅脈網線1;

		public Par X0Y0_後翅_翅脈網3_翅脈網線2;

		public Par X0Y0_後翅_翅脈網4_翅脈網線1;

		public Par X0Y0_後翅_翅脈網4_翅脈網線2;

		public Par X0Y1_後翅_後翅;

		public Par X0Y1_後翅_翅脈1;

		public Par X0Y1_後翅_翅脈2;

		public Par X0Y1_後翅_翅脈線1;

		public Par X0Y1_後翅_翅脈線2;

		public Par X0Y1_後翅_翅脈線3;

		public Par X0Y1_後翅_翅脈線4;

		public Par X0Y1_後翅_翅脈線5;

		public Par X0Y1_後翅_翅脈線6;

		public Par X0Y1_後翅_翅脈縦線1;

		public Par X0Y1_後翅_翅脈縦線2;

		public Par X0Y1_後翅_翅脈縦線3;

		public Par X0Y1_後翅_翅脈縦線4;

		public Par X0Y1_後翅_翅脈縦線5;

		public Par X0Y1_後翅_翅脈縦線6;

		public Par X0Y1_後翅_翅脈縦線7;

		public Par X0Y1_後翅_翅脈縦線8;

		public Par X0Y1_後翅_翅脈縦線9;

		public Par X0Y1_後翅_翅脈縦線10;

		public Par X0Y1_後翅_翅脈縦線11;

		public Par X0Y1_後翅_翅脈縦線12;

		public Par X0Y1_後翅_翅脈縦線13;

		public Par X0Y1_後翅_翅脈縦線14;

		public Par X0Y1_後翅_翅脈縦線15;

		public Par X0Y1_後翅_翅脈縦線16;

		public Par X0Y1_後翅_翅脈縦線17;

		public Par X0Y1_後翅_翅脈網1_翅脈網線1;

		public Par X0Y1_後翅_翅脈網1_翅脈網線2;

		public Par X0Y1_後翅_翅脈網1_翅脈網線3;

		public Par X0Y1_後翅_翅脈網2_翅脈網線1;

		public Par X0Y1_後翅_翅脈網2_翅脈網線2;

		public Par X0Y1_後翅_翅脈網2_翅脈網線3;

		public Par X0Y1_後翅_翅脈網3_翅脈網線1;

		public Par X0Y1_後翅_翅脈網3_翅脈網線2;

		public Par X0Y1_後翅_翅脈網4_翅脈網線1;

		public Par X0Y1_後翅_翅脈網4_翅脈網線2;

		public ColorD 後翅_後翅CD;

		public ColorD 後翅_翅脈1CD;

		public ColorD 後翅_翅脈2CD;

		public ColorD 後翅_翅脈線1CD;

		public ColorD 後翅_翅脈線2CD;

		public ColorD 後翅_翅脈線3CD;

		public ColorD 後翅_翅脈線4CD;

		public ColorD 後翅_翅脈線5CD;

		public ColorD 後翅_翅脈線6CD;

		public ColorD 後翅_翅脈縦線1CD;

		public ColorD 後翅_翅脈縦線2CD;

		public ColorD 後翅_翅脈縦線3CD;

		public ColorD 後翅_翅脈縦線4CD;

		public ColorD 後翅_翅脈縦線5CD;

		public ColorD 後翅_翅脈縦線6CD;

		public ColorD 後翅_翅脈縦線7CD;

		public ColorD 後翅_翅脈縦線8CD;

		public ColorD 後翅_翅脈縦線9CD;

		public ColorD 後翅_翅脈縦線10CD;

		public ColorD 後翅_翅脈縦線11CD;

		public ColorD 後翅_翅脈縦線12CD;

		public ColorD 後翅_翅脈縦線13CD;

		public ColorD 後翅_翅脈縦線14CD;

		public ColorD 後翅_翅脈縦線15CD;

		public ColorD 後翅_翅脈縦線16CD;

		public ColorD 後翅_翅脈縦線17CD;

		public ColorD 後翅_翅脈網1_翅脈網線1CD;

		public ColorD 後翅_翅脈網1_翅脈網線2CD;

		public ColorD 後翅_翅脈網1_翅脈網線3CD;

		public ColorD 後翅_翅脈網2_翅脈網線1CD;

		public ColorD 後翅_翅脈網2_翅脈網線2CD;

		public ColorD 後翅_翅脈網2_翅脈網線3CD;

		public ColorD 後翅_翅脈網3_翅脈網線1CD;

		public ColorD 後翅_翅脈網3_翅脈網線2CD;

		public ColorD 後翅_翅脈網4_翅脈網線1CD;

		public ColorD 後翅_翅脈網4_翅脈網線2CD;

		public ColorP X0Y0_後翅_後翅CP;

		public ColorP X0Y0_後翅_翅脈1CP;

		public ColorP X0Y0_後翅_翅脈2CP;

		public ColorP X0Y0_後翅_翅脈線1CP;

		public ColorP X0Y0_後翅_翅脈線2CP;

		public ColorP X0Y0_後翅_翅脈線3CP;

		public ColorP X0Y0_後翅_翅脈線4CP;

		public ColorP X0Y0_後翅_翅脈線5CP;

		public ColorP X0Y0_後翅_翅脈線6CP;

		public ColorP X0Y0_後翅_翅脈縦線1CP;

		public ColorP X0Y0_後翅_翅脈縦線2CP;

		public ColorP X0Y0_後翅_翅脈縦線3CP;

		public ColorP X0Y0_後翅_翅脈縦線4CP;

		public ColorP X0Y0_後翅_翅脈縦線5CP;

		public ColorP X0Y0_後翅_翅脈縦線6CP;

		public ColorP X0Y0_後翅_翅脈縦線7CP;

		public ColorP X0Y0_後翅_翅脈縦線8CP;

		public ColorP X0Y0_後翅_翅脈縦線9CP;

		public ColorP X0Y0_後翅_翅脈縦線10CP;

		public ColorP X0Y0_後翅_翅脈縦線11CP;

		public ColorP X0Y0_後翅_翅脈縦線12CP;

		public ColorP X0Y0_後翅_翅脈縦線13CP;

		public ColorP X0Y0_後翅_翅脈縦線14CP;

		public ColorP X0Y0_後翅_翅脈縦線15CP;

		public ColorP X0Y0_後翅_翅脈縦線16CP;

		public ColorP X0Y0_後翅_翅脈縦線17CP;

		public ColorP X0Y0_後翅_翅脈網1_翅脈網線1CP;

		public ColorP X0Y0_後翅_翅脈網1_翅脈網線2CP;

		public ColorP X0Y0_後翅_翅脈網1_翅脈網線3CP;

		public ColorP X0Y0_後翅_翅脈網2_翅脈網線1CP;

		public ColorP X0Y0_後翅_翅脈網2_翅脈網線2CP;

		public ColorP X0Y0_後翅_翅脈網2_翅脈網線3CP;

		public ColorP X0Y0_後翅_翅脈網3_翅脈網線1CP;

		public ColorP X0Y0_後翅_翅脈網3_翅脈網線2CP;

		public ColorP X0Y0_後翅_翅脈網4_翅脈網線1CP;

		public ColorP X0Y0_後翅_翅脈網4_翅脈網線2CP;

		public ColorP X0Y1_後翅_後翅CP;

		public ColorP X0Y1_後翅_翅脈1CP;

		public ColorP X0Y1_後翅_翅脈2CP;

		public ColorP X0Y1_後翅_翅脈線1CP;

		public ColorP X0Y1_後翅_翅脈線2CP;

		public ColorP X0Y1_後翅_翅脈線3CP;

		public ColorP X0Y1_後翅_翅脈線4CP;

		public ColorP X0Y1_後翅_翅脈線5CP;

		public ColorP X0Y1_後翅_翅脈線6CP;

		public ColorP X0Y1_後翅_翅脈縦線1CP;

		public ColorP X0Y1_後翅_翅脈縦線2CP;

		public ColorP X0Y1_後翅_翅脈縦線3CP;

		public ColorP X0Y1_後翅_翅脈縦線4CP;

		public ColorP X0Y1_後翅_翅脈縦線5CP;

		public ColorP X0Y1_後翅_翅脈縦線6CP;

		public ColorP X0Y1_後翅_翅脈縦線7CP;

		public ColorP X0Y1_後翅_翅脈縦線8CP;

		public ColorP X0Y1_後翅_翅脈縦線9CP;

		public ColorP X0Y1_後翅_翅脈縦線10CP;

		public ColorP X0Y1_後翅_翅脈縦線11CP;

		public ColorP X0Y1_後翅_翅脈縦線12CP;

		public ColorP X0Y1_後翅_翅脈縦線13CP;

		public ColorP X0Y1_後翅_翅脈縦線14CP;

		public ColorP X0Y1_後翅_翅脈縦線15CP;

		public ColorP X0Y1_後翅_翅脈縦線16CP;

		public ColorP X0Y1_後翅_翅脈縦線17CP;

		public ColorP X0Y1_後翅_翅脈網1_翅脈網線1CP;

		public ColorP X0Y1_後翅_翅脈網1_翅脈網線2CP;

		public ColorP X0Y1_後翅_翅脈網1_翅脈網線3CP;

		public ColorP X0Y1_後翅_翅脈網2_翅脈網線1CP;

		public ColorP X0Y1_後翅_翅脈網2_翅脈網線2CP;

		public ColorP X0Y1_後翅_翅脈網2_翅脈網線3CP;

		public ColorP X0Y1_後翅_翅脈網3_翅脈網線1CP;

		public ColorP X0Y1_後翅_翅脈網3_翅脈網線2CP;

		public ColorP X0Y1_後翅_翅脈網4_翅脈網線1CP;

		public ColorP X0Y1_後翅_翅脈網4_翅脈網線2CP;
	}
}
